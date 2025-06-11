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
 Seu <a href="https://github.com/mini-software/miniauth">Star</a>, <a href="https://miniexcel.github.io/">Doação</a>, <a href="https://www.linkedin.com/in/itweihan/">Recomendação</a> pode tornar o MiniAuth melhor 
</div>




### Introdução



"Uma linha de código" adiciona gerenciamento de usuários/papéis (role) do asp.net core identity web para seus projetos novos/antigos

<table>
    <tr>
        <td><img src="https://github.com/mini-software/MiniExcel/assets/12729184/d2aec694-158d-4ebc-bd8b-0e9ae1f855ac" alt="Imagem 1"></td>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/2f791e25-9158-495e-9383-4fbedf9b982b" alt="Imagem 2"></td>
    </tr>
    <tr>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/03d72ed7-8fb9-465f-9093-24b00279eeb2" alt="Imagem 3"></td>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/841df179-7e5f-481a-9039-46738b20aa2e" alt="Imagem 4"></td>
    </tr>
</table>


### Funcionalidades

- Compatibilidade: Suporta .NET Identity baseado em JWT, Cookie, Session, etc.
- Simples: Design plug-and-play, API, SPA, MVC, Razor Page, etc.
- Suporta múltiplos bancos de dados: Suporta Oracle, SQL Server, MySQL, etc. via EF Core
- Não intrusivo: Não afeta bancos de dados ou estruturas de projetos existentes
- Multi-plataforma: Suporta ambientes Linux, macOS



### Instalação

Instale o pacote pelo NuGet

### Início Rápido

Adicione uma única linha de código `services.AddMiniAuth()` no Startup e execute seu projeto. Exemplo:

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

A conta padrão de administrador é `admin@mini-software.github.io` com a senha `E7c4f679-f379-42bf-b547-684d456bc37f` (lembre-se de alterar a senha). A página de administração pode ser acessada em `http(s)://seuhost/miniauth/index.html`.

Adicione `[Authorize]` às categorias ou métodos que exigem gerenciamento de permissão, ou controle por papel `[Authorize(Roles = "role")]`. Retorna status 401 se não estiver logado, e retorna status 403 se não houver permissão.



### MiniAuth Cookie Identity

O MiniAuth vem pré-configurado como identidade baseada em Cookie único, por favor, altere para JWT, etc., para projetos com separação entre frontend e backend.



### MiniAuth JWT Identity

Configurando AuthenticationType = BearerJwt

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

Lembre-se de definir uma nova chave de segurança JWT, por exemplo:

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### Obtendo o token

Exemplo de XHR em Javascript no frontend

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
xhr.open("POST", "http://seuhost/miniauth/login");
xhr.setRequestHeader("Content-Type", "application/json");
xhr.send(data);
```

resposta

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

Salve o `accessToken` no localstorage ou em um cookie. Ao chamar sua API com [Authorize], defina o `Header Authorization` como `Bearer + espaço + accessToken`, e o sistema fará a verificação automaticamente.

Exemplo:

```js
var xhr = new XMLHttpRequest();
xhr.withCredentials = true;
xhr.addEventListener("readystatechange", function() {
  if(this.readyState === 4) {
    console.log(this.responseText);
  }
});
xhr.open("GET", "http://seuhost:5014/sua/api");
xhr.setRequestHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiJhZG1pbkBtaW5pLXNvZnR3YXJlLmdpdGh1Yi5pbyIsIm5iZiI6MTcxODIwNDg5NSwiZXhwIjoxNzE4MjA1Nzk1LCJpYXQiOjE3MTgyMDQ4OTUsImlzcyI6Ik1pbmlBdXRoIn0._-DQ_rcbeju8_nrK2lD5we0rre04_xdDZNF6NhM0Rg0");
xhr.send();
```



#### Definir Tempo de Expiração

```c#
options.TokenExpiresIn = 30 * 60; 
```

A unidade é em segundos, com configuração padrão de 30 minutos. Além disso, observe que o .NET JWT ClockSkew em JwtBearerOptions está pré-configurado para adicionar mais 5 minutos [motivo](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api).

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
O tempo de expiração é definido como `MiniAuthOptions.TokenExpiresIn / 2`, com padrão de 30 minutos.



### Configurações, Opções, Personalização

#### Modo Padrão

- O modo padrão do MiniAuth é o gerenciamento centralizado de usuários por administradores de TI. Operações como registro de usuários e redefinição de senha exigem uma conta de administrador com o papel pré-definido = miniauth-admin.

#### Desabilitar Login MiniAuth

Se você deseja usar apenas sua própria lógica de login, páginas e APIs, pode especificar o caminho de login e desabilitar o login do MiniAuth.
```C#
// Coloque antes do registro do serviço 
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### Personalizar a String de Conexão SQLite Padrão

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### Banco de Dados, Usuários e Papéis Personalizados

O MiniAuth foi projetado para funcionar perfeitamente com SQLite EF Core, IdentityUser e IdentityRole por padrão. Se precisar mudar, especifique diferentes bancos de dados e suas próprias classes de usuário e papel usando genéricos em `app.UseMiniAuth`.

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### Login, Autenticação de Usuário

Para non-ApiController, o redirecionamento de login padrão é para a página login.html (determinado verificando se Headers["X-Requested-With"] == "XMLHttpRequest" ou pela presença do ApiControllerAttribute).
Controllers marcados como ApiController não redirecionam para uma página de login por padrão; em vez disso, retornam um código de status 401.

### Frontend Personalizado

- O frontend do painel de administração está localizado em `/src/Frontend_Identity` e utiliza principalmente Vue3 + Vite. Executar `npm run build` atualizará a interface do MiniAuth.
- Se você não quiser usar a página de login padrão do MiniAuth, o MVC permite utilizar o Login.cshtml gerado pelo scaffold do identity ou modificar os arquivos login.html, js e css do frontend do MiniAuth.

### Prefixo de Rota Personalizado

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

O RoutePrefix padrão é `MiniAuth`.



### API de Login (JWT)

API: `/MiniAuth/login`

Corpo:

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

Resposta: 

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

Por favor, utilize a API e as páginas de registro integradas fornecidas pelo ASP.NET Core Identity.

### Esqueci a Senha

Por favor, utilize a API e as páginas de recuperação de senha integradas fornecidas pelo ASP.NET Core Identity.

### Obter Informações do Usuário

Por favor, utilize as APIs e páginas integradas fornecidas pelo ASP.NET Core Identity para recuperar informações do usuário. Observe que pode ser necessário implementar lógica ou endpoints adicionais para expor os dados necessários do usuário, dependendo das necessidades específicas da sua aplicação. O ASP.NET Core Identity fornece uma estrutura robusta para gerenciamento de informações do usuário, incluindo dados de perfil, papéis e claims.

### Observações

#### Atenção à Ordem

Por favor, coloque o UseMiniAuth após a geração das rotas, caso contrário, o sistema não poderá obter dados de roteamento para verificações de permissão, conforme segue:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### Atenção: Adicione Regras de Papel

Por favor, adicione `AddRoles<IdentityRole>()`, caso contrário `[Authorize(Roles = "permission")]` não terá efeito.

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### Integrando MiniAuth em um Projeto Identity Existente com Lógica Personalizada

Desabilite o autoUse do AddMiniAuth e coloque o UseMiniAuth após sua própria autenticação, substituindo os parâmetros genéricos pelo seu IdentityDBContext, usuário e autenticação de permissão. Veja um exemplo:

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

Isso permite alternar entre o uso dos seus próprios usuários, papéis, banco de dados e lógica do Identity.



#### Sistemas Distribuídos

- Para fontes de banco de dados, considere a troca para bancos como SQL Server, MySQL, PostgreSQL, etc.
- Recomenda-se trocar para métodos de autenticação como JWT para melhor integração em ambientes distribuídos.

### Notas de Lançamento

Consulte as [Notas de Lançamento](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases) para atualizações.

### TODO

Link: [Projeto MiniAuth.Identify](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---