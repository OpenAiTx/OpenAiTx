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
 การ <a href="https://github.com/mini-software/miniauth">Star</a>, <a href="https://miniexcel.github.io/">Donate</a>, <a href="https://www.linkedin.com/in/itweihan/">Recomm.</a> ของคุณสามารถทำให้ MiniAuth ดีขึ้นได้ 
</div>




### แนะนำ



"โค้ดบรรทัดเดียว" เพิ่มการจัดการผู้ใช้/บทบาทของ asp.net core identity ให้กับโปรเจกต์ใหม่หรือเก่าของคุณ

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


### คุณสมบัติ

- รองรับ: รองรับ .NET identity บนพื้นฐาน JWT, Cookie, Session ฯลฯ
- เรียบง่าย: ดีไซน์ Plug-and-play, ใช้งานได้กับ API, SPA, MVC, Razor Page ฯลฯ
- รองรับหลายฐานข้อมูล: รองรับ Oracle, SQL Server, MySQL ฯลฯ โดยใช้ EF Core
- ไม่รบกวน: ไม่กระทบโครงสร้างฐานข้อมูลหรือโปรเจกต์ที่มีอยู่เดิม
- ข้ามแพลตฟอร์ม: รองรับ Linux, macOS



### การติดตั้ง

ติดตั้งแพ็กเกจจาก NuGet

### เริ่มต้นอย่างรวดเร็ว

เพิ่มโค้ดบรรทัดเดียว `services.AddMiniAuth()` ใน Startup จากนั้นรันโปรเจกต์ของคุณ ตัวอย่าง:

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

บัญชีแอดมินเริ่มต้นคือ `admin@mini-software.github.io` รหัสผ่าน `E7c4f679-f379-42bf-b547-684d456bc37f` (โปรดเปลี่ยนรหัสผ่าน) เข้าถึงหน้าแอดมินได้ที่ `http(s)://yourhost/miniauth/index.html`

เพิ่ม `[Authorize]` ที่คลาสหรือเมธอดที่ต้องการควบคุมสิทธิ์ หรือควบคุมบทบาท `[Authorize(Roles = "role")]` หากยังไม่ได้ล็อกอินจะคืนค่า 401 และหากไม่มีสิทธิ์จะคืนค่า 403



### MiniAuth Cookie Identity

MiniAuth กำหนดค่าเริ่มต้นให้ใช้ Coookie Based identity โปรดเปลี่ยนเป็น JWT ฯลฯ สำหรับโปรเจกต์ที่แยก frontend/backend



### MiniAuth  JWT  Identity

ตั้งค่า AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

โปรดตั้งค่า JWT Security Key ใหม่ เช่น

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### การขอ token

ตัวอย่าง XHR ด้วย Javascript ฝั่ง frontend

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

ผลลัพธ์

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

บันทึก `accessToken` ใน localstorage หรือ cookie เมื่อเรียก [Authorize] API ให้ตั้งค่า `Header Authorization` เป็น `Bearer + เว้นวรรค + accessToken` ระบบจะตรวจสอบให้อัตโนมัติ

ตัวอย่าง:

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



#### ตั้งค่าเวลาหมดอายุ

```c#
options.TokenExpiresIn = 30 * 60; 
```

หน่วยเป็นวินาที ค่าเริ่มต้นคือ 30 นาที นอกจากนี้ให้ทราบว่า .NET JWT ClockSkew ใน JwtBearerOptions จะเพิ่มเวลาอีก 5 นาที [เหตุผล](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api)

#### Refresh Token API (JWT)

API : `/MiniAuth/refreshToken`
Body:

```json
{
   "refreshToken":"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyMzk5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.HYBWrM2suDiM4OG0FSlXhNgktZIG9l3ufmIAnwZiIoU"
}
```
Header:
```
Authorization:Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyNTc5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.rgAgsziAdLqOC9NYra-M9WQl8BJ99sRdfzRKNkMz9dk
```
เวลาหมดอายุถูกตั้งค่าเป็น `MiniAuthOptions.TokenExpiresIn / 2` ค่าเริ่มต้นคือ 30 นาที



### การตั้งค่า, ตัวเลือก, การปรับแต่ง

#### โหมดเริ่มต้น

- โหมดเริ่มต้นของ MiniAuth คือการจัดการผู้ใช้แบบรวมศูนย์โดยผู้ดูแลระบบ IT การลงทะเบียนผู้ใช้และรีเซ็ตรหัสผ่านต้องใช้บัญชีแอดมินที่มี role = miniauth-admin

#### ปิดการใช้งาน MiniAuth Login

หากคุณต้องการใช้เฉพาะตรรกะการล็อกอิน หน้า หรือ API ของคุณเอง คุณสามารถระบุ login path และปิดการใช้งาน MiniAuth login ได้
```C#
// วางไว้ก่อนการลงทะเบียน service 
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### กำหนดค่า Connection String ของ SQLite เอง

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### ฐานข้อมูล, ผู้ใช้, และบทบาทแบบกำหนดเอง

MiniAuth ถูกออกแบบมาให้ทำงานร่วมกับ SQLite EF Core, IdentityUser, และ IdentityRole ได้อย่างไร้รอยต่อโดยค่าเริ่มต้น หากคุณต้องการเปลี่ยน โปรดระบุฐานข้อมูลที่แตกต่างกันและคลาสผู้ใช้กับบทบาทของคุณเองผ่าน generics ใน `app.UseMiniAuth`

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### การเข้าสู่ระบบ, การยืนยันตัวตนผู้ใช้

สำหรับ non-ApiController การ redirect เข้าสู่ระบบโดยดีฟอลต์จะไปยังหน้า login.html (พิจารณาจาก Headers["X-Requested-With"] == "XMLHttpRequest" หรือการมี ApiControllerAttribute)
Controllers ที่มีเครื่องหมาย ApiController ตามดีฟอลต์จะไม่ redirect ไปหน้าล็อกอิน แต่จะคืนค่า status code 401 แทน

### ปรับแต่ง Frontend

- Frontend ของ admin dashboard อยู่ที่ `/src/Frontend_Identity` และใช้ Vue3 + Vite เป็นหลัก การรัน `npm run build` จะอัปเดต UI ของ miniauth
- หากไม่ต้องการใช้หน้า login ของ miniauth ที่ให้มา MVC สามารถใช้ scaffolded Login.cshtml ที่ identity เตรียมไว้ หรือจะแก้ไขไฟล์ login.html, js และ css ใน frontend ของ miniauth ก็ได้

### กำหนด Route Prefix เอง

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

ค่า RoutePrefix เริ่มต้นคือ `MiniAuth`



### Login API (JWT)

API: `/MiniAuth/login`

Body:

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

Response: 

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



### การสมัครสมาชิก

โปรดใช้ API และหน้าสมัครสมาชิกที่มีใน ASP.NET Core Identity

### ลืมรหัสผ่าน

โปรดใช้ API และหน้าสำหรับลืมรหัสผ่านที่มีอยู่ใน ASP.NET Core Identity

### รับข้อมูลผู้ใช้

โปรดใช้ API และหน้าที่มีใน ASP.NET Core Identity เพื่อดึงข้อมูลผู้ใช้ หมายเหตุ: คุณอาจต้องเพิ่มตรรกะหรือ endpoint เพิ่มเติมเพื่อเปิดเผยข้อมูลผู้ใช้ตามที่ระบบของคุณต้องการ ASP.NET Core Identity มีกรอบการจัดการข้อมูลผู้ใช้ที่สมบูรณ์ รวมถึงข้อมูลโปรไฟล์, บทบาท และ claims

### หมายเหตุ

#### ใส่ใจลำดับการเรียก

โปรดใช้ UseMiniAuth หลังจากการสร้าง route ไม่เช่นนั้นระบบจะไม่สามารถดึงข้อมูล route สำหรับการตรวจสอบสิทธิ์ได้ ดังนี้:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### สำคัญ: ต้องเพิ่ม Role Rules

โปรดเพิ่ม `AddRoles<IdentityRole>()` ไม่เช่นนั้น `[Authorize(Roles = "permission")]` จะไม่ทำงาน

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### การเชื่อมต่อ MiniAuth กับโปรเจค Identity ที่มี logic เฉพาะทางของคุณเอง

ปิด autoUse ของ AddMiniAuth แล้วใช้ UseMiniAuth หลังจาก authentication ของคุณเอง โดยแทนที่ generic parameter ด้วย IdentityDBContext, user, และ permission authentication ของคุณเอง ตัวอย่างเช่น:

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

ช่วยให้คุณสามารถสลับการใช้งานผู้ใช้, บทบาท, ฐานข้อมูล และตรรกะ Identity ของคุณเองได้



#### ระบบกระจายศูนย์

- สำหรับแหล่งข้อมูลฐานข้อมูล แนะนำให้เปลี่ยนไปใช้ SQL Server, MySQL, PostgreSQL ฯลฯ
- แนะนำให้เปลี่ยนไปใช้วิธี authentication เช่น JWT เพื่อการรวมระบบที่ดีขึ้นในสภาพแวดล้อมแบบ distributed

### บันทึกการอัปเดต

ดู [Release Notes](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) สำหรับอัปเดต

### TODO

ลิงก์: [MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---