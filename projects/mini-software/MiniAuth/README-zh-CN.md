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
 您的<a href="https://github.com/mini-software/miniauth">Star</a>、<a href="https://miniexcel.github.io/">捐赠</a>、<a href="https://www.linkedin.com/in/itweihan/">推荐</a>可以让 MiniAuth 变得更好 
</div>




### 简介



“一行代码”即可为您的新/旧项目添加 asp.net core 身份用户/角色管理 Web 界面

<table>
    <tr>
        <td><img src="https://github.com/mini-software/MiniExcel/assets/12729184/d2aec694-158d-4ebc-bd8b-0e9ae1f855ac" alt="图片1"></td>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/2f791e25-9158-495e-9383-4fbedf9b982b" alt="图片2"></td>
    </tr>
    <tr>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/03d72ed7-8fb9-465f-9093-24b00279eeb2" alt="图片3"></td>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/841df179-7e5f-481a-9039-46738b20aa2e" alt="图片4"></td>
    </tr>
</table>


### 特性

- 兼容性：支持 .NET Identity，基于 JWT、Cookie、Session 等
- 简单：即插即用设计，支持 API、SPA、MVC、Razor Page 等
- 支持多数据库：支持 Oracle、SQL Server、MySQL 等，基于 EF Core
- 无侵入：不会影响现有数据库或项目结构
- 多平台：支持 Linux、macOS 环境



### 安装

通过 NuGet 安装包

### 快速开始

在 Startup 中添加一行代码 `services.AddMiniAuth()`，然后运行您的项目。例如：

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

默认管理员账号为 `admin@mini-software.github.io`，密码为 `E7c4f679-f379-42bf-b547-684d456bc37f`（请务必更改密码）。管理页面访问地址为 `http(s)://yourhost/miniauth/index.html`。

在需要权限管理或角色控制的类或方法上添加 `[Authorize]`，如角色控制 `[Authorize(Roles = "role")]`。未登录返回 401 状态码，无权限返回 403 状态码。



### MiniAuth Cookie 身份认证

MiniAuth 默认预设为 Cookie Based 身份认证，如前后端分离项目请切换为 JWT 等认证方式。



### MiniAuth JWT 身份认证

设置 AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

请务必设置新的 JWT 安全密钥，例如：

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### 获取 token

前端 Javascript XHR 示例

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

返回

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

将 `accessToken` 保存在 localstorage 或 Cookie 中。调用带有 [Authorize] 的 API 时，在 `Header Authorization` 设置为 `Bearer + 空格 + accessToken`，系统会自动校验。

示例：

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



#### 设置过期时间

```c#
options.TokenExpiresIn = 30 * 60; 
```

单位为秒，默认 30 分钟。另外需要注意，.NET JWT 在 JwtBearerOptions 中 ClockSkew 预设会多加 5 分钟 [原因](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api)。

#### 刷新 Token API（JWT）

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
过期时间为 `MiniAuthOptions.TokenExpiresIn / 2`，默认 30 分钟。



### 设置、选项与自定义

#### 默认模式

- MiniAuth 的默认模式为 IT 管理员集中用户管理。用户注册、密码重置等操作需要预设角色为 miniauth-admin 的管理员账号。

#### 禁用 MiniAuth 登录

如果您只想使用自定义登录逻辑、页面和 API，可以指定登录路径并关闭 MiniAuth 登录开关。

```C#
// 在服务注册之前放置
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### 自定义默认 SQLite 连接字符串

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### 自定义数据库、用户与角色

MiniAuth 默认可与 SQLite EF Core、IdentityUser 和 IdentityRole 无缝配合。如果需要切换，请在 `app.UseMiniAuth` 中通过泛型指定不同的数据库和自定义的用户及角色类。

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### 登录与用户认证

对于非 ApiController，默认登录重定向到 login.html 页面（依据 Headers["X-Requested-With"] == "XMLHttpRequest" 或是否存在 ApiControllerAttribute 判断）。
被标记为 ApiController 的控制器默认不重定向到登录页，而是直接返回 401 状态码。

### 自定义前端

- 管理后台前端位于 `/src/Frontend_Identity`，主要使用 Vue3 + Vite。运行 `npm run build` 可更新 miniauth UI。
- 如果不想使用默认 miniauth 登录页，MVC 允许您使用 identity 提供的脚手架 Login.cshtml，或自行修改 miniauth 前端中的 login.html、js 和 css 文件。

### 自定义路由前缀

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

默认 RoutePrefix 为 `MiniAuth`。



### 登录 API（JWT）

接口：`/MiniAuth/login`

请求体：

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

响应：

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



### 注册

请使用 ASP.NET Core Identity 内置的注册 API 与页面。

### 忘记密码

请使用 ASP.NET Core Identity 内置的忘记密码 API 与页面。

### 获取用户信息

请利用 ASP.NET Core Identity 内置的 API 与页面获取用户信息。注意：根据您的具体应用需求，您可能需要实现额外的逻辑或端点以暴露所需的用户数据。ASP.NET Core Identity 提供了强大的用户信息管理框架，包括资料数据、角色和声明。

### 注意事项

#### 注意顺序

请将 UseMiniAuth 放在路由生成之后，否则系统无法获取路由数据进行权限检查，如下所示：

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### 注意：请添加角色规则

请添加 `AddRoles<IdentityRole>()`，否则 `[Authorize(Roles = "permission")]` 不会生效。

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### 集成 MiniAuth 到已有的 Identity 项目并自定义逻辑

禁用 AddMiniAuth 的 autoUse，并在自己的认证后调用 UseMiniAuth，泛型参数替换为自己的 IdentityDBContext、用户和权限认证。如下示例：

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

这样可以灵活切换为自定义的用户、角色、数据库与 Identity 逻辑。



#### 分布式系统

- 数据库可考虑切换为 SQL Server、MySQL、PostgreSQL 等数据库。
- 建议切换为 JWT 等认证方式，以便更好地适应分布式环境。

### 发布日志

请参阅 [发布日志](releases) 获取更新。

### TODO

链接：[MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---