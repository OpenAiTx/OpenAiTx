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
 Votre <a href="https://github.com/mini-software/miniauth">étoile</a>, <a href="https://miniexcel.github.io/">don</a>, <a href="https://www.linkedin.com/in/itweihan/">recommandation</a> peuvent rendre MiniAuth meilleur 
</div>




### Introduction



« Un code en une ligne » ajoute une gestion web des utilisateurs/rôles asp.net core identity à vos projets neufs ou existants

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


### Fonctionnalités

- Compatibilité : Prend en charge .NET Identity basé sur JWT, Cookie, Session, etc.
- Simplicité : Conception plug-and-play, API, SPA, MVC, Razor Page, etc.
- Prise en charge de plusieurs bases de données : Oracle, SQL Server, MySQL, etc. via EF Core
- Non intrusif : N’affecte pas les bases de données existantes ou la structure du projet
- Multi-plateforme : Prend en charge les environnements Linux, macOS



### Installation

Installez le package depuis NuGet

### Démarrage rapide

Ajoutez une seule ligne de code `services.AddMiniAuth()` dans Startup, puis lancez votre projet. Exemple :

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

Le compte admin par défaut est `admin@mini-software.github.io` avec le mot de passe `E7c4f679-f379-42bf-b547-684d456bc37f` (n’oubliez pas de modifier le mot de passe). La page d’administration est accessible à l’adresse `http(s)://votrehost/miniauth/index.html`.

Ajoutez `[Authorize]` aux catégories ou méthodes nécessitant une gestion des autorisations, ou un contrôle de rôle `[Authorize(Roles = "role")]`, renvoie un statut 401 si non connecté, et 403 si non autorisé.



### MiniAuth Cookie Identity

MiniAuth est préconfiguré en mode identité basée sur un seul Cookie. Pour les projets front-end/back-end séparés, veuillez changer pour JWT, etc.



### MiniAuth JWT Identity

Définir AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

Veuillez penser à définir une nouvelle clé de sécurité JWT, par exemple :

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### Récupération du token

Exemple Javascript XHR côté front-end

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

réponse

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

Sauvegardez le `accessToken` dans le localstorage ou un cookie. Lors de l’appel de votre API [Authorize], définissez le `Header Authorization` sur `Bearer + espace + accessToken`, le système le vérifiera automatiquement.

Exemple :

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



#### Définir la durée d’expiration

```c#
options.TokenExpiresIn = 30 * 60; 
```

L’unité est en secondes, la valeur par défaut est 30 minutes. Notez également que le ClockSkew JWT de .NET dans JwtBearerOptions est préconfiguré pour ajouter 5 minutes supplémentaires [raison](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

#### API de rafraîchissement du token (JWT)

API : `/MiniAuth/refreshToken`
Body :

```json
{
   "refreshToken":"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyMzk5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.HYBWrM2suDiM4OG0FSlXhNgktZIG9l3ufmIAnwZiIoU"
}
```
Header :
```
Authorization:Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyNTc5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.rgAgsziAdLqOC9NYra-M9WQl8BJ99sRdfzRKNkMz9dk
```
La durée d’expiration est définie à `MiniAuthOptions.TokenExpiresIn / 2`, valeur par défaut 30 minutes.



### Paramètres, options, personnalisation

#### Mode par défaut

- Le mode par défaut de MiniAuth est la gestion centralisée des utilisateurs par les administrateurs IT. Les opérations telles que l’inscription d’utilisateurs et la réinitialisation des mots de passe nécessitent un compte administrateur avec le rôle prédéfini = miniauth-admin.

#### Désactiver la connexion MiniAuth

Si vous souhaitez uniquement utiliser votre propre logique de connexion, vos pages et API, vous pouvez spécifier le chemin d’accès à la connexion et désactiver la connexion MiniAuth.
```C#
// À placer avant l’enregistrement du service
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### Personnaliser la chaîne de connexion SQLite par défaut

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### Base de données, utilisateurs et rôles personnalisés

MiniAuth est conçu pour fonctionner parfaitement avec SQLite EF Core, IdentityUser et IdentityRole par défaut. Si vous devez changer, veuillez spécifier différentes bases de données et vos propres classes utilisateur et rôle en utilisant les génériques dans `app.UseMiniAuth`.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### Connexion, authentification utilisateur

Pour les contrôleurs non-ApiController, la redirection de connexion par défaut est vers la page login.html (déterminée en vérifiant si Headers["X-Requested-With"] == "XMLHttpRequest" ou la présence de l’ApiControllerAttribute).
Les contrôleurs marqués ApiController ne redirigent pas par défaut vers une page de connexion ; ils renvoient un code d’état 401.

### Frontend personnalisé

- Le frontend du tableau de bord d’administration se trouve dans `/src/Frontend_Identity` et utilise principalement Vue3 + Vite. L’exécution de `npm run build` mettra à jour l’UI de miniauth.
- Si vous ne souhaitez pas utiliser la page de connexion miniauth par défaut, MVC vous permet d’utiliser le Login.cshtml généré par identity, ou vous pouvez modifier les fichiers login.html, js et css du frontend miniauth.

### Préfixe de route personnalisé

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

Le RoutePrefix par défaut est `MiniAuth`.



### API de connexion (JWT)

API : `/MiniAuth/login`

Body :

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

Réponse : 

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



### Inscription

Veuillez utiliser l’API d’inscription et les pages intégrées fournies par ASP.NET Core Identity.

### Mot de passe oublié

Veuillez utiliser l’API et les pages intégrées de récupération de mot de passe fournies par ASP.NET Core Identity.

### Obtenir les informations de l’utilisateur

Veuillez utiliser les API et pages intégrées fournies par ASP.NET Core Identity pour récupérer les informations utilisateur. Notez que vous devrez peut-être implémenter une logique ou des points de terminaison supplémentaires pour exposer les données utilisateur requises, selon les besoins spécifiques de votre application. ASP.NET Core Identity fournit un cadre robuste pour la gestion des informations utilisateur, y compris les données de profil, les rôles et les claims.

### Remarques

#### Attention à l’ordre

Veuillez placer UseMiniAuth après la génération des routes, sinon le système ne pourra pas obtenir les données de routage pour les vérifications d’autorisation, comme suit :

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### Attention : veuillez ajouter les règles de rôle

Veuillez ajouter `AddRoles<IdentityRole>()`, sinon `[Authorize(Roles = "permission")]` ne fonctionnera pas.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### Intégration de MiniAuth dans un projet Identity existant avec logique personnalisée

Désactivez l’autoUse de AddMiniAuth, et placez UseMiniAuth après votre propre authentification, en remplaçant les paramètres génériques par votre propre IdentityDBContext, utilisateur et logique d’authentification des permissions. Voici un exemple :

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

Cela vous permet de basculer entre vos propres utilisateurs, rôles, base de données et logique Identity.



#### Systèmes distribués

- Pour les sources de base de données, envisagez de passer à des bases telles que SQL Server, MySQL, PostgreSQL, etc.
- Il est recommandé de passer à des méthodes d’authentification comme JWT pour une meilleure intégration dans un environnement distribué.

### Notes de version

Consultez les [Notes de version](releases) pour les mises à jour.

### TODO

Lien : [Projet MiniAuth.Identify](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---