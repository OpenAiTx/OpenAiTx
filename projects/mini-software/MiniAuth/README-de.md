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
 Ihr <a href="https://github.com/mini-software/miniauth">Stern</a>, <a href="https://miniexcel.github.io/">Spende</a>, <a href="https://www.linkedin.com/in/itweihan/">Empfehlung</a> kann MiniAuth besser machen 
</div>




### Einführung



"Einzeilige Code"-Lösung ergänzt asp.net core Identity Benutzer-/Rollenverwaltung-Web für Ihre neuen/alten Projekte

<table>
    <tr>
        <td><img src="https://github.com/mini-software/MiniExcel/assets/12729184/d2aec694-158d-4ebc-bd8b-0e9ae1f855ac" alt="Bild 1"></td>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/2f791e25-9158-495e-9383-4fbedf9b982b" alt="Bild 2"></td>
    </tr>
    <tr>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/03d72ed7-8fb9-465f-9093-24b00279eeb2" alt="Bild 3"></td>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/841df179-7e5f-481a-9039-46738b20aa2e" alt="Bild 4"></td>
    </tr>
</table>


### Funktionen

- Kompatibilität: Unterstützt .NET Identity basierend auf JWT, Cookie, Session, usw.
- Einfach: Plug-and-Play-Design, API, SPA, MVC, Razor Page, usw.
- Unterstützt mehrere Datenbanken: Unterstützt Oracle, SQL Server, MySQL, usw. EF Core
- Nicht-invasiv: Beeinträchtigt bestehende Datenbanken oder Projektstrukturen nicht
- Multi-Plattform: Unterstützt Linux-, macOS-Umgebungen



### Installation

Installieren Sie das Paket über NuGet

### Schnellstart

Fügen Sie eine einzelne Codezeile `services.AddMiniAuth()` im Startup hinzu und starten Sie dann Ihr Projekt. Beispiel:

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

Das Standard-Admin-Konto ist `admin@mini-software.github.io` mit dem Passwort `E7c4f679-f379-42bf-b547-684d456bc37f` (Passwort bitte ändern). Die Admin-Seite ist erreichbar unter `http(s)://yourhost/miniauth/index.html`.

Fügen Sie `[Authorize]` zu Kategorien oder Methoden hinzu, die Berechtigungsverwaltung oder Rollenkontrolle benötigen `[Authorize(Roles = "role")]`. Es wird der Status 401 zurückgegeben, wenn Sie nicht eingeloggt sind, und 403, wenn keine Berechtigung besteht.



### MiniAuth Cookie Identity

MiniAuth ist standardmäßig als einzelnes Cookie-basiertes Identity-Login vorkonfiguriert, bitte für Frontend-Backend-getrennte Projekte auf JWT usw. Authentifizierung umstellen.



### MiniAuth JWT Identity

Setzen Sie AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

Bitte denken Sie daran, einen neuen JWT Security Key zu setzen, z. B.

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### Token abrufen

Frontend Javascript XHR Beispiel

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

Antwort

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

Speichern Sie das `accessToken` in localstorage oder einem Cookie. Beim Aufruf Ihrer [Authorize] API setzen Sie den `Header Authorization` auf `Bearer + Leerzeichen + accessToken`, das System prüft diesen dann automatisch.

Beispiel:

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



#### Ablaufzeit festlegen

```c#
options.TokenExpiresIn = 30 * 60; 
```

Die Einheit ist Sekunden, standardmäßig 30 Minuten. Zusätzlich ist zu beachten, dass .NET JWT ClockSkew in JwtBearerOptions standardmäßig 5 Minuten hinzufügt [Begründung](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

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
Die Ablaufzeit ist gesetzt auf `MiniAuthOptions.TokenExpiresIn / 2`, standardmäßig 30 Minuten.



### Einstellungen, Optionen, Anpassungen

#### Standardmodus

- Der Standardmodus von MiniAuth ist die zentrale Benutzerverwaltung durch IT-Admins. Vorgänge wie Benutzerregistrierung und Passwortzurücksetzung benötigen ein Admin-Konto mit der vordefinierten Rolle = miniauth-admin.

#### MiniAuth Login deaktivieren

Wenn Sie ausschließlich Ihre eigene Login-Logik, Seiten und APIs verwenden möchten, können Sie den Login-Pfad angeben und den MiniAuth-Login deaktivieren.
```C#
// Vor der Service-Registrierung platzieren
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### Standardmäßige SQLite-Verbindungszeichenfolge anpassen

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### Benutzerdefinierte Datenbank, Benutzer und Rollen

MiniAuth ist standardmäßig darauf ausgelegt, nahtlos mit SQLite EF Core, IdentityUser und IdentityRole zu arbeiten. Wenn Sie wechseln möchten, geben Sie bitte andere Datenbanken sowie Ihre eigenen Benutzer- und Rollenkassen per Generics in `app.UseMiniAuth` an.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### Login, Benutzerauthentifizierung

Für Nicht-ApiController erfolgt die standardmäßige Login-Umleitung auf die login.html-Seite (bestimmt durch Prüfung, ob Headers["X-Requested-With"] == "XMLHttpRequest" oder durch Vorhandensein des ApiControllerAttribute).
Controller, die als ApiController markiert sind, leiten standardmäßig **nicht** auf eine Login-Seite um, sondern geben einen 401-Statuscode zurück.

### Eigenes Frontend

- Das Admin-Dashboard-Frontend befindet sich in `/src/Frontend_Identity` und verwendet hauptsächlich Vue3 + Vite. Durch Ausführen von `npm run build` wird das miniauth UI aktualisiert.
- Wenn Sie die standardmäßige miniauth Login-Seite nicht verwenden möchten, können Sie mit MVC die von Identity bereitgestellte Login.cshtml nutzen oder die login.html-, js- und css-Dateien im miniauth-Frontend anpassen.

### Benutzerdefiniertes Routenpräfix

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

Das Standard-RoutePrefix ist `MiniAuth`.



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

Antwort: 

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



### Registrierung

Bitte verwenden Sie die von ASP.NET Core Identity bereitgestellte eingebaute Registrierungs-API und -Seiten.

### Passwort vergessen

Bitte nutzen Sie die eingebaute Passwort-vergessen-API und -Seiten von ASP.NET Core Identity.

### Benutzerinformationen abrufen

Bitte verwenden Sie die von ASP.NET Core Identity bereitgestellten APIs und Seiten, um Benutzerinformationen abzurufen. Beachten Sie, dass Sie ggf. zusätzliche Logik oder Endpunkte implementieren müssen, um die benötigten Benutzerdaten bereitzustellen, abhängig von den Anforderungen Ihrer Anwendung. ASP.NET Core Identity bietet einen robusten Rahmen für die Verwaltung von Benutzerdaten, einschließlich Profildaten, Rollen und Claims.

### Hinweise

#### Reihenfolge beachten

Bitte platzieren Sie UseMiniAuth **nach** der Routenerzeugung, da das System sonst keine Routendaten für die Berechtigungsprüfung erhalten kann, z. B.:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### Achtung: Rollenregel hinzufügen

Bitte fügen Sie `AddRoles<IdentityRole>()` hinzu, da sonst `[Authorize(Roles = "permission")]` keine Wirkung zeigt.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### MiniAuth in ein bestehendes Identity-Projekt mit eigener Logik integrieren

Deaktivieren Sie das automatische autoUse von AddMiniAuth und platzieren Sie UseMiniAuth nach Ihrer eigenen Authentifizierung. Ersetzen Sie die Generics durch Ihren eigenen IdentityDBContext, Benutzer und Berechtigungslogik. Beispiel:

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

So können Sie zwischen eigenen Benutzern, Rollen, Datenbank und Identity-Logik wechseln.



#### Verteilte Systeme

- Für Datenbankquellen empfiehlt sich der Wechsel auf Datenbanken wie SQL Server, MySQL, PostgreSQL usw.
- Für eine bessere Integration in verteilten Umgebungen empfiehlt es sich, Authentifizierungsmethoden wie JWT zu verwenden.

### Release Notes

Siehe [Release Notes](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) für Updates.

### TODO

Link: [MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---