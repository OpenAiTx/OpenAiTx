<div align="center">
<p><a href="https://www.nuget.org/packages/MiniAuth"><img src="https://img.shields.io/nuget/v/MiniAuth.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniAuth"><img src="https://img.shields.io/nuget/dt/MiniAuth.svg" alt=""></a>  
<a href="https://gitee.com/shps951023/MiniAuth"><img src="https://gitee.com/shps951023/MiniAuth/badge/star.svg" alt="star"></a> <a href="https://github.com/Mini-Software/MiniAuth" rel="nofollow"><img src="https://img.shields.io/github/stars/Mini-Software/MiniAuth?logo=github" alt="GitHub stars"></a> <a href="https://www.nuget.org/packages/MiniAuth"><img src="https://img.shields.io/badge/.NET-%3E%3D%206.0-red.svg" alt="version"></a>
</p>
</div>

---

<div align="center">
<p><strong>
    <a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a> | <a href="README.ja.md">日本語</a> | <a href="README.ko.md">한국어</a> | <a href="README.es.md">Español</a>  
</strong></p>
</div>



---

<div align="center">
 Sizin <a href="https://github.com/mini-software/miniauth">Yıldız</a>, <a href="https://miniexcel.github.io/">Bağış</a>, <a href="https://www.linkedin.com/in/itweihan/">Tavsiye</a> MiniAuth'u daha iyi hale getirebilir 
</div>




### Giriş



"Tek satır kod" ile asp.net core identity kullanıcı/rol yönetimi web arayüzünü yeni/eski projelerinize ekleyin

<table>
    <tr>
        <td><img src="https://github.com/mini-software/MiniExcel/assets/12729184/d2aec694-158d-4ebc-bd8b-0e9ae1f855ac" alt="Image 1"></td>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/2f791e25-9158-495e-9383-4fbedf9b982b" alt="Image 2"></td>
    </tr>
    <tr>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/03d72ed7-8fb9-465f-9093-24b00279eeb2" alt="Image 3"></td>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/841df179-7e5f-481a-9039-46738b20aa2e" alt="Image 4"></td>
    </tr>
</table>


### Özellikler

- Uyumluluk: .NET identity, JWT, Cookie, Session vb. tabanlı desteği
- Basit: Tak-çalıştır tasarım, API, SPA, MVC, Razor Page, vb.
- Çoklu veritabanı desteği: Oracle, SQL Server, MySQL vb. EF Core
- Müdahalesiz: Mevcut veritabanı veya proje yapısını etkilemez
- Çoklu platform: Linux, macOS ortamlarını destekler



### Kurulum

Paketi NuGet üzerinden kurun

### Hızlı Başlangıç

Startup'ta tek satır kod `services.AddMiniAuth()` ekleyin, ardından projenizi çalıştırın. Örnek:

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMiniAuth(); // <= ❗❗❗

        var app = builder.Build();
        app.Run();
    }
}
```

Varsayılan yönetici hesabı `admin@mini-software.github.io` ve şifresi `E7c4f679-f379-42bf-b547-684d456bc37f`'dir (şifreyi değiştirmeyi unutmayın). Yönetici sayfasına `http(s)://yourhost/miniauth/index.html` üzerinden erişebilirsiniz.

İzin yönetimi veya rol kontrolü gereken kategori veya metotlara `[Authorize]` veya `[Authorize(Roles = "role")]` ekleyin; giriş yapılmamışsa 401, yetki yoksa 403 durumu döner.



### MiniAuth Cookie Identity

MiniAuth varsayılan olarak tekli Cookie tabanlı kimlik doğrulama ile gelir, ön-yüz ve arka-yüz ayrık projeler için JWT vb. kimlik doğrulama yöntemine geçmeniz gerekir.



### MiniAuth  JWT  Identity

AuthenticationType = BearerJwt olarak ayarlama

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

Lütfen yeni bir JWT Security Key ayarlamayı unutmayın, örneğin:

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### Token Alma

Frontend Javascript XHR örneği

```javascript
var data = JSON.stringify({
  "username": "admin@mini-software.github.io",
  "password": "E7c4f679-f379-42bf-b547-684d456bc37f",
  "remember": false
});
var xhr = new XMLHttpRequest();
xhr.withCredentials = true;
xhr.addEventListener("readystatechange", function() {
  if(this.readyState === 4) {
    console.log(this.responseText);
  }
});
xhr.open("POST", "http://yourhost/miniauth/login");
xhr.setRequestHeader("Content-Type", "application/json");
xhr.send(data);
```

cevap

```json
{
    "ok": true,
    "code": 200,
    "message": null,
    "data": {
        "tokenType": "Bearer",
        "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiJhZG1pbkBtaW5pLXNvZnR3YXJlLmdpdGh1Yi5pbyIsIm5iZiI6MTcxODIwNDg5NSwiZXhwIjoxNzE4MjA1Nzk1LCJpYXQiOjE3MTgyMDQ4OTUsImlzcyI6Ik1pbmlBdXRoIn0._-DQ_rcbeju8_nrK2lD5we0rre04_xdDZNF6NhM0Rg0",
        "expiresIn": 900
    }
}
```

`accessToken`'ı localstorage veya bir cookie'de saklayın. [Authorize] API'nizi çağırırken `Header Authorization` değerini `Bearer + boşluk + accessToken` olarak ayarlayın, sistem otomatik olarak doğrulayacaktır.

Örnek:

```js
var xhr = new XMLHttpRequest();
xhr.withCredentials = true;
xhr.addEventListener("readystatechange", function() {
  if(this.readyState === 4) {
    console.log(this.responseText);
  }
});
xhr.open("GET", "http://yourhost:5014/your/api");
xhr.setRequestHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiJhZG1pbkBtaW5pLXNvZnR3YXJlLmdpdGh1Yi5pbyIsIm5iZiI6MTcxODIwNDg5NSwiZXhwIjoxNzE4MjA1Nzk1LCJpYXQiOjE3MTgyMDQ4OTUsImlzcyI6Ik1pbmlBdXRoIn0._-DQ_rcbeju8_nrK2lD5we0rre04_xdDZNF6NhM0Rg0");
xhr.send();
```



#### Son Kullanım Süresi Ayarlama

```c#
options.TokenExpiresIn = 30 * 60; 
```

Birim saniyedir, varsayılan olarak 30 dakika ayarlanır. Ayrıca, .NET JWT ClockSkew değerinin JwtBearerOptions içinde ön tanımlı olarak 5 dakika eklediğini unutmayın [sebep](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

#### Refresh Token API (JWT)

API : `/MiniAuth/refreshToken`
Gövde:

```json
{
   "refreshToken":"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyMzk5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.HYBWrM2suDiM4OG0FSlXhNgktZIG9l3ufmIAnwZiIoU"
}
```
Başlık:
```
Authorization:Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyNTc5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.rgAgsziAdLqOC9NYra-M9WQl8BJ99sRdfzRKNkMz9dk
```
Son kullanma süresi `MiniAuthOptions.TokenExpiresIn / 2` olarak ayarlanır, varsayılanı 30 dakikadır.



### Ayarlar, Seçenekler, Özelleştirme

#### Varsayılan Mod

- MiniAuth'un varsayılan modu, IT Yöneticileri tarafından merkezi kullanıcı yönetimidir. Kullanıcı kaydı ve şifre sıfırlama gibi işlemler, önceden tanımlı role = miniauth-admin olan yönetici hesabı gerektirir.

#### MiniAuth Girişini Devre Dışı Bırakma

Kendi giriş mantığınızı, sayfalarınızı ve API'lerinizi kullanmak istiyorsanız, giriş yolunu belirtebilir ve MiniAuth giriş anahtarını devre dışı bırakabilirsiniz.
```C#
// Servis kaydından önce ekleyin
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### Varsayılan SQLite Bağlantı Dizesini Özelleştirme

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### Özel Veritabanı, Kullanıcılar ve Roller

MiniAuth varsayılan olarak SQLite EF Core, IdentityUser ve IdentityRole ile sorunsuz çalışacak şekilde tasarlanmıştır. Değiştirmeniz gerekirse, lütfen farklı veritabanlarını ve kendi kullanıcı ve rol sınıflarınızı `app.UseMiniAuth` içindeki generic parametrelerle belirtin.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### Giriş, Kullanıcı Kimlik Doğrulama

ApiController olmayanlar için, varsayılan giriş yönlendirmesi login.html sayfasına yapılır (Headers["X-Requested-With"] == "XMLHttpRequest" olup olmadığı veya ApiControllerAttribute varlığına bakılarak belirlenir).
ApiController ile işaretlenmiş denetleyiciler varsayılan olarak bir giriş sayfasına yönlendirmez; bunun yerine 401 durum kodu döndürürler.

### Özel Ön Yüz

- Yönetici paneli ön yüzü `/src/Frontend_Identity` dizinindedir ve ağırlıklı olarak Vue3 + Vite kullanır. `npm run build` çalıştırmak miniauth UI'ı günceller.
- Varsayılan miniauth giriş sayfasını kullanmak istemiyorsanız, MVC ile identity tarafından sağlanan scaffolded Login.cshtml dosyasını kullanabilir ya da miniauth frontendindeki login.html, js ve css dosyalarını değiştirebilirsiniz.

### Özel Rota Öneki

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

Varsayılan RoutePrefix `MiniAuth`'tur.



### Giriş API'si (JWT)

API: `/MiniAuth/login`

Gövde:

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

Yanıt: 

```json
{
    "ok": true,
    "code": 200,
    "message": null,
    "data": {
        "tokenType": "Bearer",
        "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyNTc5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.rgAgsziAdLqOC9NYra-M9WQl8BJ99sRdfzRKNkMz9dk",
        "expiresIn": 3600,
        "refreshToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyMzk5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.HYBWrM2suDiM4OG0FSlXhNgktZIG9l3ufmIAnwZiIoU"
    }
}
```



### Kayıt

Lütfen ASP.NET Core Identity tarafından sağlanan yerleşik kayıt API'sini ve sayfalarını kullanın.

### Şifremi Unuttum

Lütfen ASP.NET Core Identity tarafından sağlanan yerleşik şifremi unuttum API'sini ve sayfalarını kullanın.

### Kullanıcı Bilgilerini Getirme

Lütfen kullanıcı bilgilerini almak için ASP.NET Core Identity tarafından sağlanan yerleşik API'leri ve sayfaları kullanın. İhtiyacınız olan kullanıcı verisini dışa aktarmak için özel mantık veya uç noktalar eklemeniz gerekebilir. ASP.NET Core Identity, profil verisi, roller ve claim'ler dahil olmak üzere kullanıcı bilgilerini yönetmek için sağlam bir çerçeve sunar.

### Notlar

#### Sıralamaya Dikkat

Lütfen UseMiniAuth'u rota üretiminden sonra yerleştirin, aksi takdirde sistem izin kontrolleri için rota verilerini alamaz, aşağıdaki gibi:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### Dikkat: Lütfen Rol Kurallarını Ekleyin

Lütfen `AddRoles<IdentityRole>()` ekleyin, aksi takdirde `[Authorize(Roles = "permission")]` etkili olmayacaktır.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### MiniAuth'u Özel Mantıkla Mevcut Bir Identity Projesine Entegre Etmek

AddMiniAuth'un autoUse özelliğini devre dışı bırakın ve kendi kimlik doğrulamanızdan sonra UseMiniAuth'u yerleştirin; generic parametreleri kendi IdentityDBContext, kullanıcı ve izin doğrulamanızla değiştirin. Örnek:

```csharp
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddControllersWithViews();

            builder.Services.AddMiniAuth(autoUse: false); // <= ❗❗❗


            var app = builder.Build();

            app.UseMiniAuth<ApplicationDbContext, IdentityUser, IdentityRole>();  // <= ❗❗❗ 
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
```

Bu şekilde kendi kullanıcılarınızı, rollerinizi, veritabanınızı ve Identity mantığınızı kullanabilirsiniz.



#### Dağıtık Sistemler

- Veritabanı kaynakları için SQL Server, MySQL, PostgreSQL gibi veritabanlarına geçiş yapmayı düşünün.
- Dağıtık ortamlarda daha iyi entegrasyon için JWT gibi kimlik doğrulama yöntemlerine geçilmesi önerilir.

### Sürüm Notları

Güncellemeler için [Sürüm Notları](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) bölümüne bakınız.

### TODO

Bağlantı: [MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---