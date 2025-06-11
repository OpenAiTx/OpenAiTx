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
 Twój <a href="https://github.com/mini-software/miniauth">Star</a>, <a href="https://miniexcel.github.io/">Darowizna</a>, <a href="https://www.linkedin.com/in/itweihan/">Polecenie</a> mogą uczynić MiniAuth lepszym 
</div>




### Wprowadzenie



"Jedna linia kodu" dodaje webowe zarządzanie użytkownikami/rolami tożsamości asp.net core do Twoich nowych/starych projektów

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


### Funkcje

- Kompatybilność: Wspiera .NET identity w oparciu o JWT, Cookie, Sesję itp.
- Prosty: Projekt plug-and-play, API, SPA, MVC, Razor Page itp.
- Obsługuje wiele baz danych: Wspiera Oracle, SQL Server, MySQL itp. EF Core
- Nieinwazyjność: Nie wpływa na istniejące bazy danych ani strukturę projektu
- Wieloplatformowość: Wspiera środowiska Linux, macOS



### Instalacja

Zainstaluj pakiet z NuGet

### Szybki start

Dodaj jedną linię kodu `services.AddMiniAuth()` w Startup, a następnie uruchom swój projekt. Przykład:

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

Domyślne konto administratora to `admin@mini-software.github.io` z hasłem `E7c4f679-f379-42bf-b547-684d456bc37f` (pamiętaj, aby zmienić hasło). Strona administracyjna dostępna jest pod adresem `http(s)://yourhost/miniauth/index.html`.

Dodaj `[Authorize]` do kategorii lub metod, które wymagają zarządzania uprawnieniami lub kontroli ról `[Authorize(Roles = "role")]`, zwróci status 401 jeśli nie zalogowano, oraz 403 jeśli brak uprawnień.



### MiniAuth Cookie Identity

MiniAuth domyślnie działa jako pojedyncza tożsamość oparta na Cookie. Dla projektów z rozdzielonym frontem i backendem zmień na JWT lub inne uwierzytelnianie.



### MiniAuth  JWT  Identity

Ustawienie AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

Pamiętaj, aby ustawić nowy klucz bezpieczeństwa JWT, np.

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### Pobieranie tokena

Przykład front-end XHR w Javascript

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

odpowiedź

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

Zapisz `accessToken` w localstorage lub cookie. Wywołując swoje API [Authorize], ustaw nagłówek `Header Authorization` na `Bearer + spacja + accessToken`, a system automatycznie go zweryfikuje.

Przykład:

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



#### Ustaw czas wygaśnięcia

```c#
options.TokenExpiresIn = 30 * 60; 
```

Jednostka to sekundy, domyślnie ustawione na 30 minut. Dodatkowo, zauważ, że .NET JWT ClockSkew w JwtBearerOptions domyślnie dodaje dodatkowe 5 minut [powód](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

#### API odświeżania tokena (JWT)

API : `/MiniAuth/refreshToken`
Body:

```json
{
   "refreshToken":"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyMzk5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.HYBWrM2suDiM4OG0FSlXhNgktZIG9l3ufmIAnwZiIoU"
}
```
Nagłówek:
```
Authorization:Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyNTc5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.rgAgsziAdLqOC9NYra-M9WQl8BJ99sRdfzRKNkMz9dk
```
Czas wygaśnięcia ustawiony jest na `MiniAuthOptions.TokenExpiresIn / 2`, domyślnie 30 minut.



### Ustawienia, opcje, dostosowanie

#### Tryb domyślny

- Domyślnym trybem MiniAuth jest scentralizowane zarządzanie użytkownikami przez administratorów IT. Operacje takie jak rejestracja użytkownika i resetowanie hasła wymagają konta administratora z predefiniowaną rolą = miniauth-admin.

#### Wyłącz logowanie MiniAuth

Jeśli chcesz używać tylko własnej logiki logowania, stron i API, możesz określić ścieżkę logowania i wyłączyć przełącznik logowania MiniAuth.
```C#
// Umieść przed rejestracją usług
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### Dostosowanie domyślnego łańcucha połączenia SQLite

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### Własna baza danych, użytkownicy i role

MiniAuth jest domyślnie zaprojektowany do bezproblemowej współpracy z SQLite EF Core, IdentityUser oraz IdentityRole. Jeśli chcesz zmienić te elementy, określ inne bazy danych oraz własne klasy użytkownika i roli, używając generyków w `app.UseMiniAuth`.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### Logowanie, uwierzytelnianie użytkownika

Dla nie-ApiController, domyślne przekierowanie logowania kieruje na stronę login.html (określone poprzez sprawdzenie, czy Headers["X-Requested-With"] == "XMLHttpRequest" lub obecność ApiControllerAttribute).
Kontrolery oznaczone jako ApiController nie przekierowują domyślnie na stronę logowania; zamiast tego zwracają kod statusu 401.

### Własny frontend

- Frontend panelu administracyjnego znajduje się w `/src/Frontend_Identity` i głównie korzysta z Vue3 + Vite. Uruchomienie `npm run build` zaktualizuje interfejs miniauth.
- Jeśli nie chcesz używać domyślnej strony logowania miniauth, MVC pozwala użyć wygenerowanego Login.cshtml dostarczonego przez identity lub możesz zmodyfikować pliki login.html, js i css w frontendzie miniauth.

### Własny prefiks trasy

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

Domyślny RoutePrefix to `MiniAuth`.



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

Odpowiedź: 

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



### Rejestracja

Proszę używać wbudowanego API oraz stron rejestracyjnych dostarczanych przez ASP.NET Core Identity.

### Zapomniane hasło

Proszę używać wbudowanego API oraz stron do odzyskiwania hasła dostarczanych przez ASP.NET Core Identity.

### Pobieranie informacji o użytkowniku

Proszę korzystać z wbudowanych API oraz stron dostarczanych przez ASP.NET Core Identity do pobierania informacji o użytkowniku. Należy pamiętać, że w zależności od potrzeb aplikacji możesz potrzebować zaimplementować dodatkową logikę lub endpointy, aby udostępnić wymagane dane użytkownika. ASP.NET Core Identity zapewnia solidny framework do zarządzania informacjami o użytkownikach, w tym danymi profilu, rolami i roszczeniami.

### Uwagi

#### Uwaga na kolejność

Proszę umieścić UseMiniAuth po generowaniu tras, w przeciwnym razie system nie będzie mógł uzyskać danych tras do sprawdzania uprawnień, jak poniżej:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### Uwaga: Dodaj reguły ról

Proszę dodać `AddRoles<IdentityRole>()`, w przeciwnym razie `[Authorize(Roles = "permission")]` nie będzie działać.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### Integracja MiniAuth z istniejącym projektem Identity z własną logiką

Wyłącz autoUse w AddMiniAuth oraz umieść UseMiniAuth po własnej autentykacji, podmieniając parametry generyczne na własny IdentityDBContext, użytkownika oraz mechanizm uwierzytelniania uprawnień. Przykład:

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

To pozwala na korzystanie z własnych użytkowników, ról, bazy danych oraz logiki Identity.



#### Systemy rozproszone

- Dla źródeł bazy danych rozważ przełączenie na bazy danych takie jak SQL Server, MySQL, PostgreSQL itd.
- Zaleca się przejście na metody uwierzytelniania takie jak JWT dla lepszej integracji w środowisku rozproszonym.

### Notatki o wydaniach

Zobacz [Release Notes](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) po aktualizacje.

### TODO

Link: [MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---