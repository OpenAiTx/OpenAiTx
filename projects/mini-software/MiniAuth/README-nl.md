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
 Uw <a href="https://github.com/mini-software/miniauth">Ster</a>, <a href="https://miniexcel.github.io/">Donatie</a>, <a href="https://www.linkedin.com/in/itweihan/">Aanbeveling</a> kan MiniAuth beter maken 
</div>




### Introductie



"One-line code" voegt asp.net core identity gebruikers-/rolbeheer web toe aan uw nieuwe/oude projecten

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


### Functionaliteiten

- Compatibiliteit: Ondersteunt .NET identity op basis van JWT, Cookie, Sessie, enz.
- Eenvoudig: Plug-and-play ontwerp, API, SPA, MVC, Razor Page, enz.
- Ondersteunt meerdere databases: Ondersteunt Oracle, SQL Server, MySQL, enz. EF Core
- Niet-invasief: Heeft geen invloed op bestaande databases of projectstructuren
- Multi-platform: Ondersteunt Linux, macOS omgevingen



### Installatie

Installeer het pakket via NuGet

### Snelstart

Voeg een enkele regel code `services.AddMiniAuth()` toe in Startup, en voer daarna uw project uit. Voorbeeld:

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

Het standaard beheerderaccount is `admin@mini-software.github.io` met het wachtwoord `E7c4f679-f379-42bf-b547-684d456bc37f` (vergeet niet het wachtwoord te wijzigen). De beheerpagina is bereikbaar op `http(s)://yourhost/miniauth/index.html`.

Voeg `[Authorize]` toe aan categorieën of methoden die rechtenbeheer vereisen, of rolcontrole `[Authorize(Roles = "role")]`, retourneert status 401 als niet ingelogd, en status 403 als geen toestemming.



### MiniAuth Cookie Identity

MiniAuth is standaard ingesteld als een enkele Cookie Based identity, wijzig dit naar JWT, enz. Authenticatie voor projecten met frontend-backend scheiding.



### MiniAuth JWT Identity

AuthenticationType instellen op BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

Vergeet niet om een nieuwe JWT Security Key in te stellen, bijvoorbeeld:

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### Token ophalen

Frontend Javascript XHR voorbeeld

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

response

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

Sla de `accessToken` op in localstorage of een cookie. Bij het aanroepen van uw [Authorize] API, stel de `Header Authorization` in op `Bearer + spatie + accessToken`, en het systeem zal dit automatisch verifiëren.

Voorbeeld:

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



#### Vervaltijd instellen

```c#
options.TokenExpiresIn = 30 * 60; 
```

De eenheid is seconden, standaard ingesteld op 30 minuten. Let op dat .NET JWT ClockSkew in JwtBearerOptions standaard 5 minuten extra toevoegt [reden](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

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
De vervaltijd is ingesteld op `MiniAuthOptions.TokenExpiresIn / 2`, standaard 30 minuten.



### Instellingen, Opties, Aanpassingen

#### Standaardmodus

- De standaardmodus van MiniAuth is gecentraliseerd gebruikersbeheer door IT-beheerders. Handelingen zoals gebruikersregistratie en wachtwoordherstel vereisen een beheerdersaccount met de vooraf gedefinieerde rol = miniauth-admin.

#### MiniAuth Login uitschakelen

Als u alleen uw eigen loginlogica, pagina's en API's wilt gebruiken, kunt u het loginpad specificeren en de MiniAuth login uitschakelen.
```C#
// Plaats vóór de service-registratie
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### Standaard SQLite-verbindingstekenreeks aanpassen

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### Aangepaste Database, Gebruikers en Rollen

MiniAuth is standaard ontworpen om naadloos samen te werken met SQLite EF Core, IdentityUser en IdentityRole. Als je wilt wisselen, specificeer dan een andere database en je eigen gebruikers- en rolklassen via generics in `app.UseMiniAuth`.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### Inloggen, Gebruikersauthenticatie

Voor non-ApiController is de standaard login-redirect naar de login.html-pagina (bepaald door te controleren of Headers["X-Requested-With"] == "XMLHttpRequest" of de aanwezigheid van de ApiControllerAttribute).
Controllers gemarkeerd als ApiController worden standaard niet omgeleid naar een loginpagina; ze geven in plaats daarvan een 401-statuscode terug.

### Aangepaste Frontend

- De admin-dashboard frontend bevindt zich in `/src/Frontend_Identity` en gebruikt voornamelijk Vue3 + Vite. Door `npm run build` uit te voeren, wordt de miniauth-UI bijgewerkt.
- Als je de standaard miniauth-inlogpagina niet wilt gebruiken, kun je met MVC de gescaffolde Login.cshtml van Identity gebruiken, of je kunt de login.html, js en css-bestanden in de miniauth-frontend aanpassen.

### Aangeprefixeerde Route

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

De standaard RoutePrefix is `MiniAuth`.



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



### Registratie

Gebruik de ingebouwde registratie-API en -pagina's die door ASP.NET Core Identity worden geleverd.

### Wachtwoord vergeten

Gebruik de ingebouwde "wachtwoord vergeten"-API en -pagina's die door ASP.NET Core Identity worden geleverd.

### Gebruikersinformatie ophalen

Maak gebruik van de ingebouwde API’s en pagina’s van ASP.NET Core Identity om gebruikersinformatie op te halen. Houd er rekening mee dat je mogelijk extra logica of endpoints moet implementeren om de vereiste gebruikersgegevens beschikbaar te stellen, afhankelijk van je specifieke applicatiebehoeften. ASP.NET Core Identity biedt een robuust framework voor het beheren van gebruikersinformatie, inclusief profielgegevens, rollen en claims.

### Opmerkingen

#### Let op de Volgorde

Plaats UseMiniAuth na de routegeneratie, anders kan het systeem geen routeringsgegevens verkrijgen voor machtigingscontroles, als volgt:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### Let op: Voeg Rolregels Toe

Voeg `AddRoles<IdentityRole>()` toe, anders zal `[Authorize(Roles = "permission")]` geen effect hebben.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### MiniAuth integreren in een Bestaand Identity Project met Aangepaste Logica

Schakel de autoUse van AddMiniAuth uit en plaats UseMiniAuth na je eigen authenticatie, waarbij je de generieke parameters vervangt door je eigen IdentityDBContext, gebruiker en permissie-authenticatie. Hier is een voorbeeld:

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

Hierdoor kun je schakelen tussen het gebruik van je eigen gebruikers, rollen, database en Identity-logica.



#### Gedistribueerde Systemen

- Overweeg voor databronnen over te stappen op databases zoals SQL Server, MySQL, PostgreSQL, enz.
- Het wordt aanbevolen over te schakelen op authenticatiemethoden zoals JWT voor betere integratie in een gedistribueerde omgeving.

### Release Notes

Zie de [Release Notes](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) voor updates.

### TODO

Link: [MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---