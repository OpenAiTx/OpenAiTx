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
 Ngôi sao <a href="https://github.com/mini-software/miniauth">Star</a>, <a href="https://miniexcel.github.io/">Ủng hộ</a>, <a href="https://www.linkedin.com/in/itweihan/">Giới thiệu</a> của bạn có thể giúp MiniAuth phát triển tốt hơn 
</div>




### Giới thiệu



"Chỉ với một dòng code" thêm chức năng quản lý user/role cho asp.net core identity vào các dự án mới/cũ của bạn

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


### Tính năng

- Tương thích: Hỗ trợ .NET Identity dựa trên JWT, Cookie, Session, v.v.
- Đơn giản: Thiết kế plug-and-play, hỗ trợ API, SPA, MVC, Razor Page, v.v.
- Hỗ trợ nhiều cơ sở dữ liệu: Hỗ trợ Oracle, SQL Server, MySQL, v.v. qua EF Core
- Không xâm lấn: Không ảnh hưởng đến cơ sở dữ liệu hoặc cấu trúc dự án hiện tại
- Đa nền tảng: Hỗ trợ môi trường Linux, macOS



### Cài đặt

Cài đặt gói từ NuGet

### Bắt đầu nhanh

Chỉ cần thêm một dòng `services.AddMiniAuth()` trong Startup, sau đó chạy dự án của bạn. Ví dụ:

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

Tài khoản admin mặc định là `admin@mini-software.github.io` với mật khẩu `E7c4f679-f379-42bf-b547-684d456bc37f` (hãy nhớ thay đổi mật khẩu). Truy cập trang admin tại `http(s)://yourhost/miniauth/index.html`.

Thêm `[Authorize]` cho các controller hoặc method cần quản lý quyền, hoặc kiểm soát theo vai trò `[Authorize(Roles = "role")]`, trả về trạng thái 401 nếu chưa đăng nhập, trả về 403 nếu không có quyền truy cập.



### MiniAuth Cookie Identity

MiniAuth mặc định sử dụng xác thực dựa trên Cookie đơn, vui lòng chuyển sang JWT, v.v. cho các dự án tách biệt frontend và backend.



### MiniAuth  JWT  Identity

Thiết lập AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

Hãy nhớ thiết lập JWT Security Key mới, ví dụ:

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### Lấy token

Ví dụ Javascript XHR phía frontend

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

kết quả trả về

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

Lưu `accessToken` vào localstorage hoặc cookie. Khi gọi các API có [Authorize], hãy thiết lập `Header Authorization` là `Bearer + khoảng trắng + accessToken`, hệ thống sẽ tự động xác thực.

Ví dụ:

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



#### Thiết lập thời gian hết hạn

```c#
options.TokenExpiresIn = 30 * 60; 
```

Đơn vị là giây, mặc định là 30 phút. Ngoài ra, lưu ý .NET JWT ClockSkew trong JwtBearerOptions mặc định sẽ cộng thêm 5 phút [lý do](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

#### API làm mới Token (JWT)

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
Thời gian hết hạn được thiết lập là `MiniAuthOptions.TokenExpiresIn / 2`, mặc định là 30 phút.



### Cài đặt, Tùy chọn, Tùy biến

#### Chế độ mặc định

- Chế độ mặc định của MiniAuth là quản lý người dùng tập trung bởi IT Admin. Các thao tác như đăng ký người dùng và đặt lại mật khẩu yêu cầu tài khoản admin với role được thiết lập sẵn là miniauth-admin.

#### Tắt đăng nhập MiniAuth

Nếu bạn chỉ muốn sử dụng logic đăng nhập, trang và API riêng của mình, bạn có thể chỉ định đường dẫn đăng nhập và tắt chức năng đăng nhập của MiniAuth.
```C#
// Đặt trước khi đăng ký dịch vụ 
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### Tùy chỉnh chuỗi kết nối SQLite mặc định

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### Cơ sở dữ liệu, người dùng và vai trò tùy chỉnh

MiniAuth được thiết kế để hoạt động liền mạch với SQLite EF Core, IdentityUser và IdentityRole theo mặc định. Nếu bạn cần thay đổi, hãy chỉ định cơ sở dữ liệu khác và lớp người dùng, vai trò của riêng bạn bằng cách sử dụng generics trong `app.UseMiniAuth`.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### Đăng nhập, xác thực người dùng

Đối với non-ApiController, mặc định sẽ chuyển hướng đăng nhập đến trang login.html (được xác định bằng cách kiểm tra nếu Headers["X-Requested-With"] == "XMLHttpRequest" hoặc có ApiControllerAttribute).
Các controller được đánh dấu ApiController mặc định sẽ không chuyển hướng đến trang đăng nhập; thay vào đó trả về mã trạng thái 401.

### Tùy chỉnh giao diện frontend

- Giao diện dashboard quản trị nằm trong `/src/Frontend_Identity` và chủ yếu sử dụng Vue3 + Vite. Chạy `npm run build` sẽ cập nhật giao diện miniauth.
- Nếu bạn không muốn sử dụng trang đăng nhập mặc định của miniauth, MVC cho phép sử dụng Login.cshtml được scaffold sẵn của identity, hoặc bạn có thể sửa các file login.html, js, css trong frontend của miniauth.

### Tùy chỉnh tiền tố route

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

RoutePrefix mặc định là `MiniAuth`.



### API đăng nhập (JWT)

API: `/MiniAuth/login`

Body:

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

Phản hồi: 

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



### Đăng ký

Vui lòng sử dụng API và trang đăng ký tích hợp sẵn do ASP.NET Core Identity cung cấp.

### Quên mật khẩu

Vui lòng sử dụng API và trang quên mật khẩu tích hợp sẵn do ASP.NET Core Identity cung cấp.

### Lấy thông tin người dùng

Vui lòng sử dụng các API và trang tích hợp sẵn do ASP.NET Core Identity cung cấp để lấy thông tin người dùng. Lưu ý rằng bạn có thể cần triển khai thêm logic hoặc endpoint để lộ thông tin người dùng cần thiết, tùy thuộc vào nhu cầu ứng dụng cụ thể. ASP.NET Core Identity cung cấp một framework mạnh mẽ để quản lý thông tin người dùng, bao gồm dữ liệu hồ sơ, vai trò và claims.

### Ghi chú

#### Lưu ý thứ tự gọi middleware

Vui lòng đặt UseMiniAuth sau khi sinh route, nếu không hệ thống sẽ không lấy được dữ liệu route để kiểm tra quyền, ví dụ:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### Lưu ý: Thêm quy tắc vai trò

Vui lòng thêm `AddRoles<IdentityRole>()`, nếu không `[Authorize(Roles = "permission")]` sẽ không có hiệu lực.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### Tích hợp MiniAuth vào dự án Identity có logic tùy chỉnh

Tắt autoUse của AddMiniAuth, đặt UseMiniAuth sau xác thực của bạn, thay thế các generic parameter bằng IdentityDBContext, user, xác thực quyền của bạn. Ví dụ:

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

Điều này cho phép bạn chuyển đổi sử dụng người dùng, vai trò, cơ sở dữ liệu và logic Identity của riêng mình.



#### Hệ thống phân tán

- Với nguồn dữ liệu database, hãy cân nhắc chuyển sang các hệ quản trị như SQL Server, MySQL, PostgreSQL, v.v.
- Khuyến nghị sử dụng các phương thức xác thực như JWT để tích hợp tốt hơn trong môi trường phân tán.

### Ghi chú phát hành

Tham khảo [Ghi chú phát hành](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) để cập nhật thông tin mới.

### TODO

Liên kết: [MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---