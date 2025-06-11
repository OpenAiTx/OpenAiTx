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
 Ваш <a href="https://github.com/mini-software/miniauth">Star</a>, <a href="https://miniexcel.github.io/">Donate</a>, <a href="https://www.linkedin.com/in/itweihan/">Recomm.</a> могут сделать MiniAuth лучше 
</div>




### Введение



"Одна строка кода" добавляет веб-управление пользователями/ролями asp.net core identity для ваших новых/старых проектов

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


### Особенности

- Совместимость: поддержка .NET identity на основе JWT, Cookie, Session и др.
- Простота: Plug-and-play дизайн, поддержка API, SPA, MVC, Razor Page и др.
- Поддержка различных БД: Oracle, SQL Server, MySQL и др. через EF Core
- Неинвазивность: не влияет на существующие базы данных и структуру проекта
- Мультиплатформенность: поддержка Linux, macOS



### Установка

Установите пакет из NuGet

### Быстрый старт

Добавьте одну строку кода `services.AddMiniAuth()` в Startup, затем запустите ваш проект. Пример:

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

Учетная запись администратора по умолчанию: `admin@mini-software.github.io`, пароль: `E7c4f679-f379-42bf-b547-684d456bc37f` (не забудьте сменить пароль). Страница администратора доступна по адресу `http(s)://yourhost/miniauth/index.html`.

Добавьте `[Authorize]` для категорий или методов, которым требуется управление разрешениями, либо контроль ролей `[Authorize(Roles = "role")]`. При отсутствии входа возвращается статус 401, при отсутствии разрешения — 403.



### MiniAuth Cookie Identity

По умолчанию MiniAuth использует Cookie Based identity, пожалуйста, переключитесь на JWT и др. для проектов с разделением фронтенда и бэкенда.



### MiniAuth  JWT  Identity

Установите AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

Не забудьте установить новый JWT Security Key, например:

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### Получение токена

Пример XHR на Javascript для фронтенда

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

ответ

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

Сохраните `accessToken` в localstorage или cookie. При вызове вашего API с [Authorize] установите заголовок `Authorization` как `Bearer + пробел + accessToken`, система автоматически выполнит проверку.

Пример:

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



#### Установка времени жизни токена

```c#
options.TokenExpiresIn = 30 * 60; 
```

Единица измерения — секунды, по умолчанию 30 минут. Дополнительно обратите внимание, что .NET JWT ClockSkew в JwtBearerOptions по умолчанию добавляет еще 5 минут [почему](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

#### API обновления токена (JWT)

API : `/MiniAuth/refreshToken`
Тело запроса:

```json
{
   "refreshToken":"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyMzk5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.HYBWrM2suDiM4OG0FSlXhNgktZIG9l3ufmIAnwZiIoU"
}
```
Заголовок:
```
Authorization:Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyNTc5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.rgAgsziAdLqOC9NYra-M9WQl8BJ99sRdfzRKNkMz9dk
```
Время жизни токена установлено как `MiniAuthOptions.TokenExpiresIn / 2`, по умолчанию 30 минут.



### Настройки, опции, кастомизация

#### Режим по умолчанию

- Режим по умолчанию MiniAuth — централизованное управление пользователями ИТ-администратором. Операции регистрации пользователя и сброса пароля требуют учетной записи администратора с ролью miniauth-admin.

#### Отключение входа через MiniAuth

Если вы хотите использовать только свою логику входа, страницы и API, укажите путь входа и отключите MiniAuth вход.

```C#
// Разместите перед регистрацией сервиса 
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### Настройка строки подключения SQLite по умолчанию

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### Пользовательская база данных, пользователи и роли

MiniAuth по умолчанию работает с SQLite EF Core, IdentityUser и IdentityRole. Если вам нужно использовать другие базы данных или собственные классы пользователей и ролей, укажите их с помощью дженериков в `app.UseMiniAuth`.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### Логин, аутентификация пользователя

Для не-ApiController стандартное перенаправление при входе осуществляется на страницу login.html (определяется по Headers["X-Requested-With"] == "XMLHttpRequest" или наличию атрибута ApiController).
Контроллеры, помеченные как ApiController, по умолчанию не перенаправляются на страницу входа — вместо этого возвращается статус-код 401.

### Пользовательский фронтенд

- Фронтенд панели администратора находится в `/src/Frontend_Identity` и в основном использует Vue3 + Vite. Запуск команды `npm run build` обновит интерфейс miniauth.
- Если вы не хотите использовать стандартную страницу входа miniauth, MVC позволяет использовать сгенерированный Login.cshtml от Identity или модифицировать файлы login.html, js и css во фронтенде miniauth.

### Кастомный префикс маршрута

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

Префикс маршрута по умолчанию — `MiniAuth`.



### API входа (JWT)

API: `/MiniAuth/login`

Тело запроса:

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

Ответ: 

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



### Регистрация

Пожалуйста, используйте встроенный API и страницы регистрации, предоставленные ASP.NET Core Identity.

### Забыли пароль

Пожалуйста, используйте встроенный API и страницы восстановления пароля, предоставленные ASP.NET Core Identity.

### Получение информации о пользователе

Пожалуйста, используйте встроенные API и страницы ASP.NET Core Identity для получения информации о пользователе. Обратите внимание, что в зависимости от потребностей вашего приложения, возможно, потребуется реализовать дополнительную логику или эндпоинты для предоставления нужных данных. ASP.NET Core Identity предоставляет надёжный фреймворк для управления информацией о пользователях, включая профиль, роли и клеймы.

### Примечания

#### Важно: порядок вызова

Пожалуйста, размещайте UseMiniAuth после генерации маршрутов, иначе система не сможет получить данные маршрутизации для проверки прав доступа, например:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### Важно: добавьте роли

Пожалуйста, добавьте `AddRoles<IdentityRole>()`, иначе `[Authorize(Roles = "permission")]` не будет работать.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### Интеграция MiniAuth в существующий проект Identity с кастомной логикой

Отключите autoUse у AddMiniAuth, и разместите UseMiniAuth после вашей собственной аутентификации, заменив дженерики на свои IdentityDBContext, пользователя и логику проверки прав. Пример:

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

Это позволяет использовать собственных пользователей, роли, базу данных и логику Identity.



#### Распределённые системы

- Для источников данных рекомендуется переключиться на базы данных, такие как SQL Server, MySQL, PostgreSQL и т.д.
- В распределённой среде рекомендуется использовать методы аутентификации, такие как JWT.

### Примечания к релизу

Смотрите [Примечания к релизу](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) для получения обновлений.

### TODO

Ссылка: [Проект MiniAuth.Identify](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---