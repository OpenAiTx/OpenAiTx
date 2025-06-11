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
 نجمك على <a href="https://github.com/mini-software/miniauth">GitHub</a>، تبرعك عبر <a href="https://miniexcel.github.io/">Donate</a>، وتوصيتك عبر <a href="https://www.linkedin.com/in/itweihan/">LinkedIn</a> يمكن أن تجعل MiniAuth أفضل 
</div>




### المقدمة



"سطر واحد من الكود" يضيف إدارة مستخدم/دور هوية asp.net core لتطبيق الويب في مشاريعك الجديدة أو القديمة

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


### الميزات

- التوافق: يدعم هوية .NET على أساس JWT، الكوكيز، الجلسة، إلخ.
- بسيط: تصميم جاهز للتوصيل والتشغيل، يدعم API، SPA، MVC، Razor Page، إلخ.
- يدعم قواعد بيانات متعددة: يدعم Oracle، SQL Server، MySQL، إلخ عبر EF Core
- غير تدخلي: لا يؤثر على قواعد البيانات أو هياكل المشاريع الحالية
- متعدد المنصات: يدعم بيئات Linux وmacOS



### التثبيت

قم بتثبيت الحزمة من NuGet

### بداية سريعة

أضف سطر كود واحد `services.AddMiniAuth()` في Startup، ثم شغل مشروعك. مثال:

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

حساب المدير الافتراضي هو `admin@mini-software.github.io` وكلمة المرور `E7c4f679-f379-42bf-b547-684d456bc37f` (تذكر تغيير كلمة المرور). يمكنك الدخول إلى صفحة الإدارة عبر `http(s)://yourhost/miniauth/index.html`.

أضف `[Authorize]` إلى الأقسام أو الدوال التي تتطلب إدارة الصلاحيات، أو تحكم الدور `[Authorize(Roles = "role")]`، حيث يتم إرجاع الحالة 401 إذا لم يتم تسجيل الدخول، ويتم إرجاع الحالة 403 إذا لم تتوفر الصلاحية.



### MiniAuth هوية الكوكيز

تم ضبط MiniAuth مسبقًا كهُوية تعتمد على الكوكيز، يرجى التغيير إلى JWT أو غيره إذا كان مشروعك بفصل بين الواجهة الأمامية والخلفية.



### MiniAuth  هوية JWT

تعيين AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

يرجى تذكر تعيين مفتاح أمان JWT جديد، على سبيل المثال:

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### الحصول على التوكن

مثال XHR في جافاسكريبت للواجهة الأمامية

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

الاستجابة

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

احفظ الـ `accessToken` في localstorage أو ككوكي. عند استدعاء API المؤمنة بـ [Authorize]، قم بتعيين الـ `Header Authorization` إلى `Bearer + مسافة + accessToken`، وسيتم التحقق تلقائيًا.

مثال:

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



#### تعيين مدة انتهاء الصلاحية

```c#
options.TokenExpiresIn = 30 * 60; 
```

الوحدة بالثواني، والإعداد الافتراضي 30 دقيقة. لاحظ أيضًا أن .NET JWT ClockSkew في JwtBearerOptions مضبوط مسبقًا لإضافة 5 دقائق إضافية [السبب](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

#### API لتحديث التوكن (JWT)

API : `/MiniAuth/refreshToken`
المحتوى:

```json
{
   "refreshToken":"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyMzk5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.HYBWrM2suDiM4OG0FSlXhNgktZIG9l3ufmIAnwZiIoU"
}
```
الهيدر:
```
Authorization:Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyNTc5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.rgAgsziAdLqOC9NYra-M9WQl8BJ99sRdfzRKNkMz9dk
```
مدة الانتهاء مضبوطة على `MiniAuthOptions.TokenExpiresIn / 2`، والقيمة الافتراضية 30 دقيقة.



### الإعدادات، الخيارات، التخصيص

#### الوضع الافتراضي

- الوضع الافتراضي لـ MiniAuth هو إدارة مركزية للمستخدمين من قبل مسؤولي تكنولوجيا المعلومات. عمليات مثل تسجيل المستخدم وإعادة تعيين كلمة المرور تتطلب حساب مدير مع الدور المحدد مسبقًا = miniauth-admin.

#### تعطيل تسجيل الدخول عبر MiniAuth

إذا كنت ترغب فقط في استخدام منطق تسجيل الدخول الخاص بك، والصفحات، وواجهات API، يمكنك تحديد مسار تسجيل الدخول وإيقاف تشغيل تسجيل الدخول عبر MiniAuth.
```C#
// ضع هذا قبل تسجيل الخدمة
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### تخصيص سلسلة الاتصال الافتراضية لـ SQLite

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### قاعدة بيانات مخصصة، المستخدمون، والأدوار

تم تصميم MiniAuth للعمل بسلاسة مع SQLite EF Core، وIdentityUser، وIdentityRole بشكل افتراضي. إذا كنت بحاجة إلى التبديل، يرجى تحديد قواعد بيانات مختلفة وفئات المستخدم والدور الخاصة بك باستخدام Generics في `app.UseMiniAuth`.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### تسجيل الدخول، مصادقة المستخدم

بالنسبة لغير ApiController، فإن إعادة التوجيه الافتراضية لتسجيل الدخول تكون إلى صفحة login.html (يتم تحديد ذلك من خلال التحقق من Headers["X-Requested-With"] == "XMLHttpRequest" أو وجود ApiControllerAttribute).
المتحكمات التي تم تعليمها بـ ApiController لا تعيد التوجيه إلى صفحة تسجيل الدخول افتراضيًا؛ بل تعيد رمز الحالة 401.

### واجهة أمامية مخصصة

- توجد واجهة لوحة تحكم المشرف في `/src/Frontend_Identity` وتستخدم بشكل رئيسي Vue3 + Vite. عند تشغيل `npm run build` سيتم تحديث واجهة miniauth.
- إذا لم ترغب في استخدام صفحة تسجيل الدخول الافتراضية لـ miniauth، يسمح لك MVC باستخدام Login.cshtml الذي توفره الهوية أو يمكنك تعديل ملفات login.html وjs وcss في الواجهة الأمامية لـ miniauth.

### بادئة مسار مخصصة

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

بادئة المسار الافتراضية هي `MiniAuth`.



### واجهة برمجة تطبيقات تسجيل الدخول (JWT)

API: `/MiniAuth/login`

Body:

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

الاستجابة: 

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



### التسجيل

يرجى استخدام واجهات برمجة التطبيقات والصفحات المدمجة للتسجيل التي يوفرها ASP.NET Core Identity.

### نسيت كلمة المرور

يرجى استخدام واجهات برمجة التطبيقات والصفحات المدمجة لنسيان كلمة المرور التي يوفرها ASP.NET Core Identity.

### الحصول على معلومات المستخدم

يرجى استخدام واجهات برمجة التطبيقات والصفحات المدمجة التي يوفرها ASP.NET Core Identity لاسترداد معلومات المستخدم. لاحظ أنه قد تحتاج إلى تنفيذ منطق إضافي أو نقاط نهاية للكشف عن بيانات المستخدم المطلوبة، حسب احتياجات تطبيقك المحددة. يوفر ASP.NET Core Identity إطار عمل قوي لإدارة معلومات المستخدم، بما في ذلك بيانات الملف الشخصي، والأدوار، والمطالبات.

### ملاحظات

#### الانتباه للترتيب

يرجى وضع UseMiniAuth بعد توليد المسارات، وإلا فلن يتمكن النظام من الحصول على بيانات المسارات لفحص الأذونات، كما يلي:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### انتبه: يرجى إضافة قواعد الدور

يرجى إضافة `AddRoles<IdentityRole>()`، وإلا لن تعمل `[Authorize(Roles = "permission")]`.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### دمج MiniAuth في مشروع Identity قائم مع منطق مخصص

عطّل autoUse في AddMiniAuth، وضع UseMiniAuth بعد المصادقة الخاصة بك، وبدّل المعاملات الجنريك بـ IdentityDBContext الخاص بك، والمستخدم، ومصادقة الأذونات الخاصة بك. إليك مثال:

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

يسمح لك هذا بالتبديل بين استخدام المستخدمين، الأدوار، قاعدة البيانات، ومنطق الهوية الخاص بك.



#### الأنظمة الموزعة

- لمصادر قاعدة البيانات، ضع في اعتبارك التبديل إلى قواعد بيانات مثل SQL Server، MySQL، PostgreSQL، إلخ.
- يوصى بالتبديل إلى طرق مصادقة مثل JWT لدمج أفضل في بيئة موزعة.

### ملاحظات الإصدار

راجع [ملاحظات الإصدار](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) للتحديثات.

### TODO

الرابط: [مشروع MiniAuth.Identify](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---