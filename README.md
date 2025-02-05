#  CQRS Project

## 📌 Kullanılan Tasarım Desenleri

### 🏛 Onion Architecture (Soğan Mimarisi)
- Uygulamanın bağımlılıklarını en aza indirerek, katmanlar arasındaki bağımlılıkları merkezden dışa doğru yöneten bir mimari desendir.

### ⚡ CQRS (Command Query Responsibility Segregation)
- Veri okuma (**Query**) ve yazma (**Command**) işlemlerini birbirinden ayırarak, her birini farklı modeller ve işlemlerle ele alan bir tasarım desenidir.

### 🔥 Exception Handling Middleware
- `ConfigureExceptionHandlingMiddleware` kullanılarak **özel hata yönetimi** sağlanmıştır. Bu sayede **global hata yönetimi** merkezi bir noktada ele alınmıştır.

---

## 📦 Kullanılan NuGet Kütüphaneleri

| 📌 Kütüphane | 📄 Açıklama |
|-------------|------------|
| **MediatR** | Uygulama içindeki bileşenler arasında **gevşek bağlılık** sağlayarak, isteklerin ve bildirimlerin işlenmesini kolaylaştırır. |
| **FluentValidation** | Veri doğrulama işlemlerini **daha temiz ve anlaşılır** bir şekilde gerçekleştirmeyi sağlar. |
| **AutoMapper** | Farklı nesneler arasında **otomatik eşleme** yapmayı sağlar. |
| **Microsoft.AspNetCore.Authentication.JwtBearer** | JWT (**JSON Web Token**) ile kimlik doğrulama işlemlerini gerçekleştirir. |
| **EntityFrameworkCore** | Veritabanı işlemlerini **nesne-ilişkisel haritalama (ORM)** yöntemiyle gerçekleştirir. |
| **Swashbuckle.AspNetCore (Swagger)** | API **dokümantasyonu** ve **test işlemlerini** kolaylaştırır. |
| **Microsoft.Extensions.Caching.StackExchangeRedis** | Redis kullanarak **cache (önbellekleme)** işlemlerini yönetmek için kullanılır. |

---

## 🔑 Swagger ve JWT Güvenlik Yapılandırması

- **Swagger** arayüzü için **JWT tabanlı kimlik doğrulama** mekanizması eklenmiştir.
- Swagger üzerinden **Authorization** başlığına aşağıdaki formatta token girilerek API çağrıları yapılabilir:
