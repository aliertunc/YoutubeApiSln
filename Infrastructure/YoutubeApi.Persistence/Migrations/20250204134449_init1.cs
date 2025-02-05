using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 44, 49, 429, DateTimeKind.Local).AddTicks(5544), "Industrial, Electronics & Baby" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 44, 49, 429, DateTimeKind.Local).AddTicks(5556), "Books, Games & Baby" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 44, 49, 429, DateTimeKind.Local).AddTicks(5566), "Grocery, Toys & Music" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 4, 16, 44, 49, 429, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 4, 16, 44, 49, 429, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 4, 16, 44, 49, 429, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 4, 16, 44, 49, 429, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 44, 49, 430, DateTimeKind.Local).AddTicks(9291), "Velit quaerat cezbelendi olduğu magni.", "Enim." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 44, 49, 430, DateTimeKind.Local).AddTicks(9315), "Deleniti sarmal in koştum cesurca.", "Orta aut." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 44, 49, 430, DateTimeKind.Local).AddTicks(9399), "Aspernatur kulu orta bilgisayarı balıkhaneye.", "Kapının." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 44, 49, 432, DateTimeKind.Local).AddTicks(4412), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 8.600556182779470m, 284.41m, "Intelligent Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 44, 49, 432, DateTimeKind.Local).AddTicks(4433), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1.897389425426760m, 700.97m, "Sleek Metal Chips" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 1, 15, 6, 45, 428, DateTimeKind.Local).AddTicks(9516), "Garden & Health" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 1, 15, 6, 45, 428, DateTimeKind.Local).AddTicks(9536), "Jewelery, Sports & Home" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 1, 15, 6, 45, 428, DateTimeKind.Local).AddTicks(9546), "Books & Shoes" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 1, 15, 6, 45, 429, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 1, 15, 6, 45, 429, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 1, 15, 6, 45, 429, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 1, 15, 6, 45, 429, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 1, 15, 6, 45, 431, DateTimeKind.Local).AddTicks(4451), "Ekşili sandalye sıla bilgisayarı türemiş.", "Adresini." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 1, 15, 6, 45, 431, DateTimeKind.Local).AddTicks(4484), "Dignissimos sayfası labore ea eum.", "Reprehenderit consequatur." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 1, 15, 6, 45, 431, DateTimeKind.Local).AddTicks(4508), "İn gidecekmiş vel enim incidunt.", "Vitae." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 10, 1, 15, 6, 45, 433, DateTimeKind.Local).AddTicks(9143), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1.499450369695510m, 25.23m, "Sleek Wooden Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 10, 1, 15, 6, 45, 433, DateTimeKind.Local).AddTicks(9169), "The Football Is Good For Training And Recreational Purposes", 0.7931595161475990m, 875.94m, "Tasty Steel Soap" });
        }
    }
}
