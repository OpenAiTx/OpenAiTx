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
 Tu <a href="https://github.com/mini-software/miniauth">Estrella</a>, <a href="https://miniexcel.github.io/">Donación</a>, <a href="https://www.linkedin.com/in/itweihan/">Recomendación</a> pueden hacer MiniAuth mejor 
</div>

### Introducción

"Una sola línea de código" agrega gestión de usuarios/roles de asp.net core identity web para tus proyectos nuevos o existentes

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

### Características

- Compatibilidad: Soporta .NET Identity basado en JWT, Cookie, Session, etc.
- Sencillo: Diseño plug-and-play, API, SPA, MVC, Razor Page, etc.
- Soporta múltiples bases de datos: Oracle, SQL Server, MySQL, etc. EF Core
- No intrusivo: No afecta las bases de datos existentes ni la estructura del proyecto
- Multi-plataforma: Soporta entornos Linux, macOS

### Instalación

Instala el paquete desde NuGet

### Inicio Rápido

Agrega una sola línea de código `services.AddMiniAuth()` en Startup, luego ejecuta tu proyecto. Ejemplo:

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

La cuenta de administrador predeterminada es `admin@mini-software.github.io` con la contraseña `E7c4f679-f379-42bf-b547-684d456bc37f` (recuerda cambiar la contraseña). La página de administración está disponible en `http(s)://tuhost/miniauth/index.html`.

Agrega `[Authorize]` a las categorías o métodos que requieran gestión de permisos, o control de roles `[Authorize(Roles = "role")]`, devolverá estado 401 si no has iniciado sesión, y devolverá estado 403 si no tienes permiso.

### MiniAuth Cookie Identity

MiniAuth está preconfigurado como identidad basada en Cookie. Por favor, cambia a JWT, etc. para proyectos con separación frontend-backend.

### MiniAuth JWT Identity

Configura AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

Recuerda establecer una nueva clave de seguridad JWT, por ejemplo:

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### Obtener token

Ejemplo de Javascript XHR en el frontend

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
xhr.open("POST", "http://tuhost/miniauth/login");
xhr.setRequestHeader("Content-Type", "application/json");
xhr.send(data);
```

respuesta

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

Guarda el `accessToken` en localstorage o en una cookie. Al llamar a tu API [Authorize], establece el `Header Authorization` a `Bearer + espacio + accessToken`, y el sistema lo verificará automáticamente.

Ejemplo:

```js
var xhr = new XMLHttpRequest();
xhr.withCredentials = true;
xhr.addEventListener("readystatechange", function() {
  if(this.readyState === 4) {
    console.log(this.responseText);
  }
});
xhr.open("GET", "http://tuhost:5014/your/api");
xhr.setRequestHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiJhZG1pbkBtaW5pLXNvZnR3YXJlLmdpdGh1Yi5pbyIsIm5iZiI6MTcxODIwNDg5NSwiZXhwIjoxNzE4MjA1Nzk1LCJpYXQiOjE3MTgyMDQ4OTUsImlzcyI6Ik1pbmlBdXRoIn0._-DQ_rcbeju8_nrK2lD5we0rre04_xdDZNF6NhM0Rg0");
xhr.send();
```

#### Configurar tiempo de expiración

```c#
options.TokenExpiresIn = 30 * 60; 
```

La unidad es en segundos, con un valor predeterminado de 30 minutos. Además, ten en cuenta que .NET JWT ClockSkew en JwtBearerOptions está preconfigurado para añadir 5 minutos extra [razón](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

#### API de Refresh Token (JWT)

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
El tiempo de expiración se establece en `MiniAuthOptions.TokenExpiresIn / 2`, con un valor predeterminado de 30 minutos.

### Configuración, Opciones, Personalización

#### Modo Predeterminado

- El modo predeterminado de MiniAuth es la gestión centralizada de usuarios por parte de los administradores de IT. Operaciones como registro de usuarios y restablecimiento de contraseñas requieren una cuenta de administrador con el rol predefinido = miniauth-admin.

#### Deshabilitar el login de MiniAuth

Si solo quieres utilizar tu propia lógica de login, páginas y APIs, puedes especificar la ruta de login y deshabilitar el login de MiniAuth.
```C#
// Coloque antes del registro del servicio 
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### Personalizar la Cadena de Conexión SQLite Predeterminada

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### Base de Datos Personalizada, Usuarios y Roles

MiniAuth está diseñado para funcionar perfectamente con SQLite EF Core, IdentityUser e IdentityRole por defecto. Si necesitas cambiar, especifica diferentes bases de datos y tus propias clases de usuario y rol usando genéricos en `app.UseMiniAuth`.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### Inicio de Sesión, Autenticación de Usuario

Para controladores que no son ApiController, la redirección predeterminada de inicio de sesión es a la página login.html (determinado por verificar si Headers["X-Requested-With"] == "XMLHttpRequest" o la presencia de ApiControllerAttribute).
Los controladores marcados como ApiController no redirigen por defecto a una página de inicio de sesión; en su lugar, devuelven un código de estado 401.

### Frontend Personalizado

- El frontend del panel de administración se encuentra en `/src/Frontend_Identity` y utiliza principalmente Vue3 + Vite. Ejecutar `npm run build` actualizará la interfaz de usuario de miniauth.
- Si no deseas usar la página de inicio de sesión predeterminada de miniauth, MVC te permite usar la Login.cshtml generada por identity, o puedes modificar los archivos login.html, js y css en el frontend de miniauth.

### Prefijo de Ruta Personalizado

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

El RoutePrefix predeterminado es `MiniAuth`.



### API de Inicio de Sesión (JWT)

API: `/MiniAuth/login`

Cuerpo:

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

Respuesta: 

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



### Registro

Utiliza la API y las páginas de registro integradas que proporciona ASP.NET Core Identity.

### Olvidé mi Contraseña

Utiliza la API y las páginas para recuperar contraseña integradas que proporciona ASP.NET Core Identity.

### Obtener Información de Usuario

Utiliza las APIs y páginas integradas proporcionadas por ASP.NET Core Identity para recuperar información de usuario. Ten en cuenta que puede que necesites implementar lógica adicional o endpoints para exponer los datos de usuario requeridos, dependiendo de las necesidades específicas de tu aplicación. ASP.NET Core Identity proporciona un marco robusto para la gestión de información de usuario, incluyendo datos de perfil, roles y claims.

### Notas

#### Atención al Orden

Coloca UseMiniAuth después de la generación de rutas, de lo contrario, el sistema no podrá obtener datos de enrutamiento para las comprobaciones de permisos, como se muestra a continuación:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### Atención: Añade las Reglas de Roles

Por favor, añade `AddRoles<IdentityRole>()`, de lo contrario `[Authorize(Roles = "permission")]` no tendrá efecto.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### Integrar MiniAuth en un Proyecto Identity Existente con Lógica Personalizada

Desactiva el autoUse de AddMiniAuth y coloca UseMiniAuth después de tu propia autenticación, reemplazando los parámetros genéricos con tu propio IdentityDBContext, usuario y autenticación de permisos. Aquí tienes un ejemplo:

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

Esto te permite alternar entre usar tus propios usuarios, roles, base de datos y lógica de Identity.



#### Sistemas Distribuidos

- Para fuentes de base de datos, considera cambiar a bases de datos como SQL Server, MySQL, PostgreSQL, etc.
- Se recomienda cambiar a métodos de autenticación como JWT para una mejor integración en entornos distribuidos.

### Notas de Lanzamiento

Consulta las [Notas de Lanzamiento](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) para actualizaciones.

### TODO

Enlace: [MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---