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
 <a href="https://github.com/mini-software/miniauth">Star</a>, <a href="https://miniexcel.github.io/">Donasi</a>, <a href="https://www.linkedin.com/in/itweihan/">Rekomendasi</a> Anda dapat membuat MiniAuth menjadi lebih baik 
</div>




### Pendahuluan



"Satu baris kode" menambahkan web manajemen user/role asp.net core identity untuk proyek baru/lama Anda

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


### Fitur

- Kompatibilitas: Mendukung .NET identity Berbasis JWT, Cookie, Session, dll.
- Sederhana: Desain plug-and-play, API, SPA, MVC, Razor Page, dll.
- Mendukung banyak database: Mendukung Oracle, SQL Server, MySQL, dll. EF Core
- Non-intrusif: Tidak memengaruhi database atau struktur proyek yang sudah ada
- Multi-platform: Mendukung lingkungan Linux, macOS



### Instalasi

Instal paket dari NuGet

### Quick Start

Tambahkan satu baris kode `services.AddMiniAuth()` di Startup, lalu jalankan proyek Anda. Contoh:

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

Akun admin default adalah `admin@mini-software.github.io` dengan password `E7c4f679-f379-42bf-b547-684d456bc37f` (ingat untuk mengubah password-nya). Halaman admin dapat diakses di `http(s)://yourhost/miniauth/index.html`.

Tambahkan `[Authorize]` pada kategori atau metode yang memerlukan manajemen izin, atau kontrol role `[Authorize(Roles = "role")]`, akan mengembalikan status 401 jika belum login, dan mengembalikan status 403 jika tidak memiliki izin.



### MiniAuth Cookie Identity

MiniAuth secara preset sebagai single identity Berbasis Cookie, silakan ubah ke JWT, dll. untuk proyek frontend dan backend terpisah.



### MiniAuth  JWT  Identity

Set AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

Pastikan untuk mengatur JWT Security Key baru, misalnya.

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### Mendapatkan token

Contoh Javascript XHR Frontend

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

respon

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

Simpan `accessToken` di localstorage atau cookie. Saat memanggil API [Authorize] Anda, atur `Header Authorization` menjadi `Bearer + spasi + accessToken`, dan sistem akan memverifikasinya secara otomatis.

Contoh:

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



#### Mengatur Waktu Kadaluwarsa

```c#
options.TokenExpiresIn = 30 * 60; 
```

Satuan dalam detik, dengan pengaturan default 30 menit. Selain itu, perlu diperhatikan bahwa .NET JWT ClockSkew di JwtBearerOptions secara preset menambah 5 menit ekstra [alasan](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

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
Waktu kadaluwarsa diatur ke `MiniAuthOptions.TokenExpiresIn / 2`, dengan default 30 menit.



### Pengaturan, Opsi, Kustomisasi

#### Mode Default

- Mode default MiniAuth adalah manajemen user terpusat oleh IT Admin. Operasi seperti registrasi user dan reset password memerlukan akun admin dengan role bawaan = miniauth-admin.

#### Nonaktifkan Login MiniAuth

Jika Anda hanya ingin menggunakan logika login, halaman, dan API Anda sendiri, Anda dapat menentukan login path dan menonaktifkan switch login MiniAuth.
```C#
// Tempatkan sebelum registrasi service
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### Kustomisasi Default SQLite Connection String

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### Database, User, dan Role Kustom

MiniAuth dirancang untuk bekerja secara mulus dengan SQLite EF Core, IdentityUser, dan IdentityRole secara default. Jika Anda perlu mengganti, silakan tentukan database berbeda serta kelas user dan role Anda sendiri menggunakan generik di `app.UseMiniAuth`.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### Login, Autentikasi Pengguna

Untuk non-ApiController, pengalihan login default adalah ke halaman login.html (ditentukan dengan memeriksa apakah Headers["X-Requested-With"] == "XMLHttpRequest" atau adanya ApiControllerAttribute).
Controller yang diberi penanda ApiController secara default tidak mengalihkan ke halaman login; sebagai gantinya, mereka mengembalikan kode status 401.

### Frontend Kustom

- Frontend dashboard admin terletak di `/src/Frontend_Identity` dan utamanya menggunakan Vue3 + Vite. Jalankan `npm run build` untuk memperbarui UI miniauth.
- Jika Anda tidak ingin menggunakan halaman login miniauth default, MVC memungkinkan Anda menggunakan Login.cshtml hasil scaffold dari identity, atau Anda dapat mengubah file login.html, js, dan css di frontend miniauth.

### Kustom Route Prefix

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

RoutePrefix default adalah `MiniAuth`.



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

Respons: 

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



### Registrasi

Silakan gunakan API dan halaman registrasi bawaan yang disediakan oleh ASP.NET Core Identity.

### Lupa Kata Sandi

Silakan gunakan API dan halaman lupa kata sandi bawaan yang disediakan oleh ASP.NET Core Identity.

### Mendapatkan Informasi Pengguna

Silakan gunakan API dan halaman bawaan dari ASP.NET Core Identity untuk mengambil informasi pengguna. Perlu dicatat bahwa Anda mungkin perlu mengimplementasikan logika tambahan atau endpoint untuk mengekspos data pengguna yang diperlukan, tergantung kebutuhan aplikasi Anda. ASP.NET Core Identity menyediakan kerangka kerja yang kuat untuk mengelola informasi pengguna, termasuk data profil, role, dan klaim.

### Catatan

#### Perhatian Urutan

Silakan letakkan UseMiniAuth setelah pembuatan rute, jika tidak, sistem tidak dapat memperoleh data routing untuk pemeriksaan izin, seperti berikut:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### Perhatian: Tambahkan Role Rules

Silakan tambahkan `AddRoles<IdentityRole>()`, jika tidak `[Authorize(Roles = "permission")]` tidak akan berfungsi.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### Mengintegrasikan MiniAuth ke dalam Proyek Identity Eksisting dengan Logika Kustom

Nonaktifkan autoUse pada AddMiniAuth, dan letakkan UseMiniAuth setelah autentikasi Anda sendiri, ganti parameter generik dengan IdentityDBContext, user, dan autentikasi permission milik Anda. Berikut contoh penggunaannya:

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

Ini memungkinkan Anda untuk berpindah antara pengguna, role, database, dan logika Identity milik Anda sendiri.



#### Sistem Terdistribusi

- Untuk sumber database, pertimbangkan untuk beralih ke database seperti SQL Server, MySQL, PostgreSQL, dll.
- Disarankan untuk beralih ke metode autentikasi seperti JWT untuk integrasi yang lebih baik di lingkungan terdistribusi.

### Catatan Rilis

Lihat [Catatan Rilis](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) untuk pembaruan.

### TODO

Tautan: [Proyek MiniAuth.Identify](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---