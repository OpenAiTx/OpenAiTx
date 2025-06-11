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
 ستاره <a href="https://github.com/mini-software/miniauth">Star</a>، <a href="https://miniexcel.github.io/">حمایت مالی</a>، <a href="https://www.linkedin.com/in/itweihan/">پیشنهاد</a> شما می‌تواند MiniAuth را بهتر کند 
</div>




### مقدمه

با "یک خط کد"، مدیریت کاربران/نقش‌های هویت asp.net core را به پروژه‌های جدید/قدیمی خود اضافه کنید

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


### امکانات

- سازگاری: پشتیبانی از هویت .NET مبتنی بر JWT، کوکی، نشست و غیره
- ساده: طراحی plug-and-play، پشتیبانی از API، SPA، MVC، Razor Page و غیره
- پشتیبانی از چند پایگاه داده: پشتیبانی از Oracle، SQL Server، MySQL و غیره با EF Core
- غیرتهاجمی: بدون تأثیر بر پایگاه داده یا ساختار پروژه‌های موجود
- چندسکویی: پشتیبانی از محیط‌های Linux و macOS



### نصب

پکیج را از NuGet نصب کنید

### شروع سریع

در Startup تنها یک خط کد `services.AddMiniAuth()` اضافه کنید و پروژه خود را اجرا نمایید. مثال:

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

حساب کاربری پیش‌فرض مدیریت، `admin@mini-software.github.io` با رمز عبور `E7c4f679-f379-42bf-b547-684d456bc37f` می‌باشد (حتماً رمز عبور را تغییر دهید). صفحه مدیریت از طریق `http(s)://yourhost/miniauth/index.html` در دسترس است.

برای کنترل سطح دسترسی، روی دسته‌ها یا متدهایی که نیاز به مدیریت مجوز یا نقش دارند، `[Authorize]` یا کنترل نقش `[Authorize(Roles = "role")]` اضافه کنید؛ در صورت عدم ورود، وضعیت 401 بازگردانده می‌شود و در صورت عدم داشتن مجوز، وضعیت 403 برگردانده می‌شود.



### هویت کوکی MiniAuth

MiniAuth به صورت پیش‌فرض بر پایه کوکی (Cookie Based identity) تنظیم شده است؛ لطفاً برای پروژه‌های جدا از فرانت و بک‌اند به JWT و غیره تغییر دهید.



### هویت JWT در MiniAuth

تنظیم AuthenticationType به BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

حتماً کلید امنیتی JWT جدید تعیین کنید، مانند:

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### دریافت توکن

نمونه XHR جاوااسکریپت فرانت‌اند

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

پاسخ

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

`accessToken` را در localstorage یا کوکی ذخیره کنید. هنگام فراخوانی API دارای [Authorize]، در هدر درخواست مقدار `Authorization` را به صورت `Bearer + فاصله + accessToken` قرار دهید؛ سیستم به صورت خودکار آن را اعتبارسنجی می‌کند.

نمونه:

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



#### تنظیم زمان انقضا

```c#
options.TokenExpiresIn = 30 * 60; 
```

واحد زمان بر حسب ثانیه است و مقدار پیش‌فرض ۳۰ دقیقه می‌باشد. همچنین توجه داشته باشید که .NET JWT ClockSkew در JwtBearerOptions به طور پیش‌فرض ۵ دقیقه به زمان اضافه می‌کند [دلیل](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

#### API رفرش توکن (JWT)

API : `/MiniAuth/refreshToken`
بدنه:

```json
{
   "refreshToken":"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyMzk5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.HYBWrM2suDiM4OG0FSlXhNgktZIG9l3ufmIAnwZiIoU"
}
```
هدر:
```
Authorization:Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyNTc5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.rgAgsziAdLqOC9NYra-M9WQl8BJ99sRdfzRKNkMz9dk
```
زمان انقضا به صورت `MiniAuthOptions.TokenExpiresIn / 2` تعیین می‌شود که به طور پیش‌فرض ۳۰ دقیقه است.



### تنظیمات، گزینه‌ها و سفارشی‌سازی

#### حالت پیش‌فرض

- حالت پیش‌فرض MiniAuth مدیریت متمرکز کاربران توسط مدیر IT است. عملیات‌هایی مانند ثبت‌نام کاربر و بازنشانی رمز عبور نیازمند حساب کاربری با نقش از پیش تعریف شده = miniauth-admin می‌باشد.

#### غیرفعال کردن ورود MiniAuth

اگر فقط قصد دارید از منطق ورود، صفحات و APIهای اختصاصی خود استفاده کنید، می‌توانید مسیر ورود را مشخص کرده و سوییچ ورود MiniAuth را غیرفعال نمایید.
```C#
// قبل از ثبت سرویس قرار دهید
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### شخصی‌سازی رشته اتصال پیش‌فرض SQLite

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### پایگاه داده سفارشی، کاربران و نقش‌ها

MiniAuth به طور پیش‌فرض برای کار با SQLite EF Core، IdentityUser و IdentityRole طراحی شده است. اگر نیاز به تغییر دارید، لطفاً پایگاه داده‌های مختلف و کلاس‌های کاربر و نقش خود را با استفاده از جنریک‌ها در `app.UseMiniAuth` مشخص کنید.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### ورود، احراز هویت کاربر

برای کنترلرهایی که ApiController نیستند، هدایت ورود پیش‌فرض به صفحه login.html است (با بررسی Headers["X-Requested-With"] == "XMLHttpRequest" یا وجود ApiControllerAttribute تعیین می‌شود).
کنترلرهایی که با ApiController علامت‌گذاری شده‌اند، به طور پیش‌فرض به صفحه ورود هدایت نمی‌شوند؛ بلکه کد وضعیت 401 را باز می‌گردانند.

### رابط کاربری سفارشی

- رابط کاربری داشبورد مدیریت در مسیر `/src/Frontend_Identity` قرار دارد و عمدتاً از Vue3 + Vite استفاده می‌کند. اجرای `npm run build` رابط کاربری miniauth را به‌روزرسانی می‌کند.
- اگر نمی‌خواهید از صفحه ورود پیش‌فرض miniauth استفاده کنید، MVC به شما اجازه می‌دهد از Login.cshtml اسکفلد شده که توسط identity ارائه شده استفاده کنید یا فایل‌های login.html، js و css را در رابط کاربری miniauth ویرایش کنید.

### پیشوند مسیر سفارشی

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

RoutePrefix پیش‌فرض `MiniAuth` است.



### API ورود (JWT)

آدرس API: `/MiniAuth/login`

بدنه:

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

پاسخ: 

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



### ثبت‌نام

لطفاً از API و صفحات ثبت‌نام داخلی ارائه شده توسط ASP.NET Core Identity استفاده کنید.

### فراموشی رمز عبور

لطفاً از API و صفحات فراموشی رمز عبور داخلی ارائه شده توسط ASP.NET Core Identity استفاده کنید.

### دریافت اطلاعات کاربر

لطفاً برای دریافت اطلاعات کاربر از API‌ها و صفحات داخلی ارائه شده توسط ASP.NET Core Identity استفاده نمایید. توجه داشته باشید که ممکن است بسته به نیاز برنامه خود، نیاز به پیاده‌سازی منطق یا نقاط پایانی اضافی برای نمایش داده‌های مورد نیاز داشته باشید. ASP.NET Core Identity یک چارچوب قدرتمند برای مدیریت اطلاعات کاربر از جمله داده‌های پروفایل، نقش‌ها و claims فراهم می‌کند.

### نکات

#### توجه به ترتیب

لطفاً UseMiniAuth را بعد از تولید مسیرها قرار دهید، در غیر این صورت سیستم نمی‌تواند داده‌های مسیر را برای بررسی دسترسی دریافت کند، مانند زیر:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### توجه: افزودن قوانین نقش

لطفاً `AddRoles<IdentityRole>()` را اضافه کنید، در غیر این صورت `[Authorize(Roles = "permission")]` اعمال نخواهد شد.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### یکپارچه‌سازی MiniAuth با پروژه Identity موجود با منطق سفارشی

autoUse مربوط به AddMiniAuth را غیرفعال کنید و UseMiniAuth را بعد از احراز هویت خود قرار دهید و پارامترهای جنریک را با IdentityDBContext، کاربر و احراز هویت مجوز خود جایگزین کنید. یک مثال:

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

این به شما امکان می‌دهد از کاربران، نقش‌ها، پایگاه داده و منطق Identity خود استفاده کنید.



#### سیستم‌های توزیع‌شده

- برای منابع پایگاه داده، استفاده از پایگاه داده‌هایی مانند SQL Server، MySQL، PostgreSQL و غیره را در نظر بگیرید.
- توصیه می‌شود برای یکپارچگی بهتر در محیط توزیع‌شده، به روش‌های احراز هویت مانند JWT تغییر دهید.

### یادداشت‌های انتشار

برای به‌روزرسانی‌ها به [یادداشت‌های انتشار](releases) مراجعه کنید.

### TODO

لینک: [پروژه MiniAuth.Identify](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---