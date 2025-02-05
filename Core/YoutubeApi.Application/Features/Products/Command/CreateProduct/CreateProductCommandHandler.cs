using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Application.Bases;
using YoutubeApi.Application.Features.Products.Rules;
using YoutubeApi.Application.Interfaces.AutoMapper;
using YoutubeApi.Application.Interfaces.UnitOfWorks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler : BaseHandler, IRequestHandler<CreateProductCommandRequest, Unit>
    {
        private readonly ProductRules productRules;

        public CreateProductCommandHandler(ProductRules productRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.productRules = productRules;
        }
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                IList<Product> products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();

                await productRules.ProductTitleMustNotBeSame(products, request.Title);

                Product product = new(request.Title, request.Description, request.BrandId, request.Price, request.Discount);

                await unitOfWork.GetWriteRepository<Product>().AddAsync(product);
                if (await unitOfWork.SaveAsync() > 0)
                {
                    var productCategories = new List<ProductCategory>();
                    foreach (var categoryId in request.CategoryIds)
                    {
                        productCategories.Add(new ProductCategory
                        {
                            ProductId = product.Id,
                            CategoryId = categoryId
                        });
                    }

                    await unitOfWork.GetWriteRepository<ProductCategory>().AddRangeAsync(productCategories);
                    await unitOfWork.SaveAsync(); // Tek bir kaydetme işlemi
                }

                return Unit.Value;
            }
            catch (Exception ex)
            {
                // Log the exception (logging mechanism not shown here)
                throw new Exception("An error occurred while creating the product.", ex);
            }
        }
    }
}
