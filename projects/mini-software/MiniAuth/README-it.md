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
 Il tuo <a href="https://github.com/mini-software/miniauth">Star</a>, <a href="https://miniexcel.github.io/">Dona</a>, <a href="https://www.linkedin.com/in/itweihan/">Raccomanda</a> può rendere MiniAuth migliore 
</div>




### Introduzione



"One-line code" aggiunge la gestione utenti/ruoli di asp.net core identity web ai tuoi progetti nuovi/vecchi

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


### Caratteristiche

- Compatibilità: Supporta .NET identity basato su JWT, Cookie, Sessione, ecc.
- Semplice: Design plug-and-play, API, SPA, MVC, Razor Page, ecc.
- Supporta più database: Supporta Oracle, SQL Server, MySQL, ecc. EF Core
- Non intrusivo: Non influenza i database o le strutture di progetto esistenti
- Multipiattaforma: Supporta ambienti Linux, macOS



### Installazione

Installa il pacchetto da NuGet

### Avvio Rapido

Aggiungi una sola riga di codice `services.AddMiniAuth()` in Startup, poi esegui il tuo progetto. Esempio:

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

L'account admin predefinito è `admin@mini-software.github.io` con la password `E7c4f679-f379-42bf-b547-684d456bc37f` (ricordati di cambiare la password). La pagina di amministrazione è accessibile su `http(s)://yourhost/miniauth/index.html`.

Aggiungi `[Authorize]` alle classi o ai metodi che richiedono la gestione dei permessi, oppure controllo del ruolo `[Authorize(Roles = "role")]`, restituisce status 401 se non loggato e status 403 se non autorizzato.



### MiniAuth Cookie Identity

MiniAuth è preimpostato come identità basata su Cookie singolo, cambiare a JWT, ecc. Auth per progetti con separazione front-end e back-end.



### MiniAuth  JWT  Identity

Impostare AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

Ricordati di impostare una nuova chiave di sicurezza JWT, es.

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### Ottenere il token

Esempio Javascript XHR lato frontend

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

risposta

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

Salva l'`accessToken` in localstorage o in un cookie. Quando chiami la tua API [Authorize], imposta `Header Authorization` su `Bearer + spazio + accessToken`, e il sistema lo verificherà automaticamente.

Esempio:

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



#### Impostare il Tempo di Scadenza

```c#
options.TokenExpiresIn = 30 * 60; 
```

L'unità è in secondi, con valore predefinito di 30 minuti. Inoltre, nota che in .NET JWT ClockSkew nelle JwtBearerOptions è preimpostato per aggiungere altri 5 minuti [motivo](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

#### API di Refresh Token (JWT)

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
Il tempo di scadenza è impostato a `MiniAuthOptions.TokenExpiresIn / 2`, con valore predefinito di 30 minuti.



### Impostazioni, Opzioni, Personalizzazione

#### Modalità Predefinita

- La modalità predefinita di MiniAuth è la gestione centralizzata degli utenti da parte degli amministratori IT. Operazioni come registrazione utente e reset password richiedono un account admin con ruolo predefinito = miniauth-admin.

#### Disabilitare Login MiniAuth

Se vuoi utilizzare solo la tua logica di login, pagine e API, puoi specificare il percorso di login e disabilitare lo switch di login di MiniAuth.
```C#
// Inserire prima della registrazione del servizio
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### Personalizzare la Stringa di Connessione SQLite Predefinita

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### Database, Utenti e Ruoli Personalizzati

MiniAuth è progettato per funzionare perfettamente con SQLite EF Core, IdentityUser e IdentityRole per impostazione predefinita. Se hai bisogno di cambiare, specifica database diversi e le tue classi utente e ruolo utilizzando i generici in `app.UseMiniAuth`.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### Login, Autenticazione Utente

Per i controller non-ApiController, la redirezione di login predefinita è verso la pagina login.html (determinata verificando se Headers["X-Requested-With"] == "XMLHttpRequest" o la presenza di ApiControllerAttribute).
I controller contrassegnati come ApiController non vengono reindirizzati di default a una pagina di login; invece, restituiscono un codice di stato 401.

### Frontend Personalizzato

- Il frontend della dashboard amministrativa si trova in `/src/Frontend_Identity` e utilizza principalmente Vue3 + Vite. Eseguendo `npm run build` verrà aggiornata la UI di miniauth.
- Se non vuoi utilizzare la pagina di login predefinita di miniauth, MVC ti permette di utilizzare il Login.cshtml scaffolded fornito da identity, oppure puoi modificare i file login.html, js e css nel frontend miniauth.

### Prefisso di Rotta Personalizzato

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

Il RoutePrefix predefinito è `MiniAuth`.



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

Risposta: 

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



### Registrazione

Utilizza le API e le pagine di registrazione integrate fornite da ASP.NET Core Identity.

### Password Dimenticata

Utilizza le API e le pagine per il recupero password integrate fornite da ASP.NET Core Identity.

### Ottenere Informazioni Utente

Utilizza le API e le pagine integrate fornite da ASP.NET Core Identity per recuperare le informazioni utente. Nota che potresti dover implementare logiche o endpoint aggiuntivi per esporre i dati utente richiesti, a seconda delle esigenze specifiche della tua applicazione. ASP.NET Core Identity fornisce un framework robusto per la gestione delle informazioni utente, inclusi dati di profilo, ruoli e claims.

### Note

#### Attenzione all'Ordine

Posiziona UseMiniAuth dopo la generazione delle rotte, altrimenti il sistema non può ottenere i dati di routing per i controlli sui permessi, come segue:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### Attenzione: Aggiungi le Regole dei Ruoli

Aggiungi `AddRoles<IdentityRole>()`, altrimenti `[Authorize(Roles = "permission")]` non avrà effetto.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### Integrazione di MiniAuth in un Progetto Identity Esistente con Logica Personalizzata

Disabilita l'autoUse di AddMiniAuth e posiziona UseMiniAuth dopo la tua autenticazione, sostituendo i parametri generici con i tuoi IdentityDBContext, utente e autenticazione dei permessi. Ecco un esempio:

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

Questo ti permette di utilizzare i tuoi utenti, ruoli, database e la logica di Identity personalizzata.



#### Sistemi Distribuiti

- Per le fonti dati, valuta di passare a database come SQL Server, MySQL, PostgreSQL, ecc.
- Si consiglia di utilizzare metodi di autenticazione come JWT per una migliore integrazione in ambienti distribuiti.

### Note di Rilascio

Consulta le [Note di Rilascio](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) per gli aggiornamenti.

### TODO

Link: [MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---