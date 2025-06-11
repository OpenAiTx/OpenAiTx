<div align="center">
<p><a href="https://www.nuget.org/packages/MiniAuth"><img src="https://img.shields.io/nuget/v/MiniAuth.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniAuth"><img src="https://img.shields.io/nuget/dt/MiniAuth.svg" alt=""></a>  
<a href="https://gitee.com/shps951023/MiniAuth"><img src="https://gitee.com/shps951023/MiniAuth/badge/star.svg" alt="star"></a> <a href="https://github.com/Mini-Software/MiniAuth" rel="nofollow"><img src="https://img.shields.io/github/stars/Mini-Software/MiniAuth?logo=github" alt="GitHub stars"></a> <a href="https://www.nuget.org/packages/MiniAuth"><img src="https://img.shields.io/badge/.NET-%3E%3D%206.0-red.svg" alt="version"></a>
</p>
</div>

---

<div align="center">
<p><strong>
    <a href="README.md">English</a> | <a href="README.zh-CN.md">簡體中文</a> | <a href="README.zh-Hant.md">繁體中文</a> | <a href="README.ja.md">日本語</a> | <a href="README.ko.md">한국어</a> | <a href="README.es.md">Español</a>  
</strong></p>
</div>



---

<div align="center">
 您的<a href="https://github.com/mini-software/miniauth">Star</a>、<a href="https://miniexcel.github.io/">捐贈</a>、<a href="https://www.linkedin.com/in/itweihan/">推薦</a>能讓 MiniAuth 更加完善
</div>




### 介紹



「一行程式碼」即可為新／舊專案快速加入 asp.net core identity 用戶／角色管理 Web 後台

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


### 功能特色

- 相容性：支援 .NET identity，基於 JWT、Cookie、Session 等
- 簡單易用：即插即用設計，支援 API、SPA、MVC、Razor Page 等架構
- 多資料庫支援：相容 Oracle、SQL Server、MySQL 等，基於 EF Core
- 非侵入式：不影響現有資料庫及專案結構
- 跨平台：支援 Linux、macOS 環境



### 安裝方式

從 NuGet 安裝套件

### 快速上手

在 Startup 中只需新增一行程式碼 `services.AddMiniAuth()`，然後執行您的專案。範例：

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

預設管理員帳號為 `admin@mini-software.github.io`，密碼為 `E7c4f679-f379-42bf-b547-684d456bc37f`（請記得變更密碼）。管理頁面存取網址為 `http(s)://yourhost/miniauth/index.html`。

在需要權限管理的類別或方法標註 `[Authorize]`，或加上角色控制 `[Authorize(Roles = "role")]`，未登入會回傳 401，無權限會回傳 403。



### MiniAuth Cookie 身分驗證

MiniAuth 預設為單一 Cookie Based 身分驗證，若前後端分離專案請改為 JWT 等驗證方式。



### MiniAuth JWT 身分驗證

設定 AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

請記得設定新的 JWT Security Key，例如：

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### 取得 Token

前端 Javascript XHR 範例

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

回應

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

將 `accessToken` 儲存於 localstorage 或 cookie。呼叫您的 [Authorize] API 時，請將 `Header Authorization` 設為 `Bearer + 空格 + accessToken`，系統會自動驗證。

範例：

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



#### 設定 Token 有效時間

```c#
options.TokenExpiresIn = 30 * 60; 
```

單位為秒，預設 30 分鐘。另外注意 .NET JWT 的 JwtBearerOptions 預設 ClockSkew 會再多加 5 分鐘，[說明](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api)。

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
過期時間為 `MiniAuthOptions.TokenExpiresIn / 2`，預設 30 分鐘。



### 設定、選項與自訂

#### 預設模式

- MiniAuth 預設模式為 IT 管理員集中管理使用者。像是使用者註冊及密碼重設等操作，需擁有預設角色 = miniauth-admin 的管理員帳號。

#### 關閉 MiniAuth 登入

如果您只想使用自己實作的登入邏輯、頁面與 API，可指定登入路徑並關閉 MiniAuth 登入開關。

```C#
// 請放在服務註冊之前
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### 自訂預設 SQLite 連線字串

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### 自訂資料庫、使用者與角色

MiniAuth 預設可與 SQLite EF Core、IdentityUser 和 IdentityRole 無縫搭配。如需切換，請於 `app.UseMiniAuth` 以泛型指定不同的資料庫及自有的使用者與角色類別。

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### 登入、使用者驗證

對於非 ApiController，預設登入導向 login.html 頁面（判斷依據為 Headers["X-Requested-With"] == "XMLHttpRequest" 或帶有 ApiControllerAttribute）。
標註為 ApiController 的控制器預設不會重導登入頁，而是直接回傳 401 狀態碼。

### 自訂前端

- 管理後台前端位於 `/src/Frontend_Identity`，主要採用 Vue3 + Vite。執行 `npm run build` 將會更新 miniauth UI。
- 若不想使用預設 miniauth 登入頁，MVC 可直接使用 Identity 所提供的 Login.cshtml 或自行修改 miniauth 前端中的 login.html、js 及 css 檔案。

### 自訂路由前綴

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

預設的 RoutePrefix 為 `MiniAuth`。



### 登入 API（JWT）

API：`/MiniAuth/login`

Body：

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

Response：

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



### 註冊

請使用 ASP.NET Core Identity 內建的註冊 API 與頁面。

### 忘記密碼

請使用 ASP.NET Core Identity 內建的忘記密碼 API 與頁面。

### 取得使用者資訊

請利用 ASP.NET Core Identity 內建的 API 與頁面來取得使用者資訊。請注意，視您的應用需求，可能需要實作額外邏輯或端點以對外提供所需的使用者資料。ASP.NET Core Identity 提供了完整的使用者資訊管理框架，包括個人資料、角色與 Claims。

### 注意事項

#### 注意順序

請將 UseMiniAuth 放在路由產生之後，否則系統將無法取得權限檢查所需的路由資料，例如：

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### 注意：請加入角色規則

請務必加入 `AddRoles<IdentityRole>()`，否則 `[Authorize(Roles = "permission")]` 不會生效。

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### 與既有 Identity 專案及自訂邏輯整合 MiniAuth

停用 AddMiniAuth 的 autoUse，並將 UseMiniAuth 放於自身驗證之後，泛型參數請替換為您自己的 IdentityDBContext、User 與權限驗證類別。範例如下：

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

這樣您即可切換使用自有的使用者、角色、資料庫與 Identity 邏輯。



#### 分散式系統

- 資料庫來源建議切換為 SQL Server、MySQL、PostgreSQL 等資料庫。
- 分散式環境下建議切換為 JWT 等驗證方式以利整合。

### 發布說明

請參閱 [發布說明](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) 以獲取更新資訊。

### TODO

連結：[MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---