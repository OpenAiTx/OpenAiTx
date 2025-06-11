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
 귀하의 <a href="https://github.com/mini-software/miniauth">Star</a>, <a href="https://miniexcel.github.io/">기부</a>, <a href="https://www.linkedin.com/in/itweihan/">추천</a>이 MiniAuth를 더 좋게 만듭니다 
</div>




### 소개



"한 줄 코드"로 asp.net core identity 사용자/역할 관리 웹을 신규/기존 프로젝트에 추가할 수 있습니다

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


### 특징

- 호환성: JWT, 쿠키, 세션 등 기반의 .NET Identity 지원
- 간단함: 플러그앤플레이 설계, API, SPA, MVC, Razor Page 등 지원
- 다양한 데이터베이스 지원: Oracle, SQL Server, MySQL 등 EF Core 지원
- 비침투성: 기존 데이터베이스나 프로젝트 구조에 영향 없음
- 멀티플랫폼: Linux, macOS 환경 지원



### 설치

NuGet에서 패키지 설치

### 빠른 시작

Startup에서 한 줄 코드 `services.AddMiniAuth()`를 추가한 후, 프로젝트를 실행하세요. 예시:

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

기본 관리자 계정은 `admin@mini-software.github.io` 이며 비밀번호는 `E7c4f679-f379-42bf-b547-684d456bc37f` 입니다(비밀번호 변경 필수). 관리자 페이지는 `http(s)://yourhost/miniauth/index.html` 에서 접근할 수 있습니다.

권한 관리 또는 역할 제어가 필요한 클래스나 메서드에 `[Authorize]` 또는 `[Authorize(Roles = "role")]` 를 추가하세요. 로그인하지 않으면 401 상태를, 권한이 없으면 403 상태를 반환합니다.



### MiniAuth 쿠키 기반 인증

MiniAuth는 기본적으로 단일 쿠키 기반 인증이 설정되어 있습니다. 프론트엔드/백엔드 분리 프로젝트의 경우 JWT 등 인증 방식으로 변경해 주세요.



### MiniAuth JWT 인증

AuthenticationType = BearerJwt로 설정

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

새 JWT 보안 키를 반드시 설정하세요. 예:

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### 토큰 받기

프론트엔드 Javascript XHR 예시

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

응답 예시

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

`accessToken`을 localstorage 또는 쿠키에 저장하세요. [Authorize] API 호출 시 `Header Authorization`에 `Bearer + 공백 + accessToken`을 설정하면 시스템이 자동으로 인증을 수행합니다.

예시:

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



#### 만료 시간 설정

```c#
options.TokenExpiresIn = 30 * 60; 
```

단위는 초이며, 기본값은 30분입니다. 또한 .NET JWT의 JwtBearerOptions의 ClockSkew가 기본적으로 5분이 추가되어 있음에 유의하세요. [이유](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

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
만료 시간은 `MiniAuthOptions.TokenExpiresIn / 2`로 설정되어 있으며, 기본값은 30분입니다.



### 설정, 옵션, 커스터마이징

#### 기본 모드

- MiniAuth의 기본 모드는 IT 관리자가 중앙 집중식으로 사용자 관리를 하는 방식입니다. 사용자 등록, 비밀번호 재설정 등의 작업은 role = miniauth-admin이 미리 정의된 관리자 계정으로만 가능합니다.

#### MiniAuth 로그인 비활성화

자체 로그인 로직, 페이지, API만 사용하려는 경우 로그인 경로를 지정하고 MiniAuth 로그인 스위치를 비활성화할 수 있습니다.
```C#
// 서비스 등록 전에 위치시켜 주세요
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### 기본 SQLite 연결 문자열 커스터마이즈

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### 커스텀 데이터베이스, 사용자, 역할

MiniAuth는 기본적으로 SQLite EF Core, IdentityUser, IdentityRole과 원활하게 동작하도록 설계되었습니다. 변경이 필요하다면, `app.UseMiniAuth`의 제네릭을 사용하여 다른 데이터베이스와 사용자, 역할 클래스를 지정하세요.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### 로그인, 사용자 인증

비 ApiController의 경우 기본 로그인 리다이렉트는 login.html 페이지로 이동합니다(Headers["X-Requested-With"] == "XMLHttpRequest" 또는 ApiControllerAttribute가 있는지 여부로 결정).
ApiController로 지정된 컨트롤러는 기본적으로 로그인 페이지로 리다이렉트하지 않고 401 상태 코드를 반환합니다.

### 프론트엔드 커스터마이즈

- 관리자 대시보드 프론트엔드는 `/src/Frontend_Identity`에 있으며, 주로 Vue3 + Vite를 사용합니다. `npm run build`를 실행하면 miniauth UI가 갱신됩니다.
- 기본 miniauth 로그인 페이지를 사용하지 않으려면, MVC에서 identity가 제공하는 scaffold된 Login.cshtml을 사용할 수 있고, 또는 miniauth 프론트엔드의 login.html, js, css 파일을 수정할 수 있습니다.

### 커스텀 라우트 프리픽스

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

기본 RoutePrefix는 `MiniAuth`입니다.



### 로그인 API (JWT)

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



### 회원가입

ASP.NET Core Identity에서 제공하는 내장 회원가입 API와 페이지를 사용해 주세요.

### 비밀번호 찾기

ASP.NET Core Identity에서 제공하는 내장 비밀번호 찾기 API와 페이지를 사용해 주세요.

### 사용자 정보 조회

사용자 정보 조회를 위해 ASP.NET Core Identity에서 제공하는 내장 API와 페이지를 활용하세요. 애플리케이션 요구에 따라 필요한 사용자 데이터를 노출하기 위해 추가적인 로직이나 엔드포인트가 필요할 수 있습니다. ASP.NET Core Identity는 프로필 데이터, 역할, 클레임 등 사용자 정보를 관리하는 강력한 프레임워크를 제공합니다.

### 참고 사항

#### 순서 주의

UseMiniAuth는 라우트 생성 이후에 위치시켜야 합니다. 그렇지 않으면 권한 체크를 위한 라우팅 데이터를 시스템이 얻지 못합니다. 예시는 다음과 같습니다:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### 주의: 역할 규칙 추가

`AddRoles<IdentityRole>()`을 꼭 추가해야 `[Authorize(Roles = "permission")]`이 정상 동작합니다.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### 기존 Identity 프로젝트에 MiniAuth 통합 및 커스텀 로직 추가

AddMiniAuth의 autoUse를 비활성화하고, UseMiniAuth를 직접 인증 이후에 위치시키고, 제네릭 파라미터를 자신의 IdentityDBContext, 사용자, 권한 인증으로 교체하세요. 예시는 다음과 같습니다:

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

이렇게 하면, 자신만의 사용자, 역할, 데이터베이스, Identity 로직을 사용할 수 있습니다.



#### 분산 시스템

- 데이터베이스 소스는 SQL Server, MySQL, PostgreSQL 등으로 전환하는 것을 고려하세요.
- 분산 환경에서의 통합을 위해 JWT와 같은 인증 방식으로 전환하는 것을 권장합니다.

### 릴리즈 노트

업데이트는 [Release Notes](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases)에서 확인하세요.

### TODO

링크: [MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---