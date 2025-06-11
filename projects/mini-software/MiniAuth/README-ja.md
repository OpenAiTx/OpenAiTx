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
 あなたの<a href="https://github.com/mini-software/miniauth">Star</a>、<a href="https://miniexcel.github.io/">寄付</a>、<a href="https://www.linkedin.com/in/itweihan/">推薦</a>がMiniAuthをより良くします 
</div>




### はじめに



「ワンラインコード」で新規／既存プロジェクトにasp.net core identityユーザー・ロール管理Webを追加

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


### 特徴

- 互換性：JWT、Cookie、Session等に基づく.NET Identityをサポート
- シンプル：プラグアンドプレイ設計、API、SPA、MVC、Razor Page等対応
- 複数データベース対応：Oracle、SQL Server、MySQL等に対応。EF Coreベース
- 非侵入型：既存のデータベースやプロジェクト構造に影響を与えません
- マルチプラットフォーム：Linux、macOS環境に対応



### インストール

NuGetからパッケージをインストール

### クイックスタート

Startupに1行`services.AddMiniAuth()`を追加し、プロジェクトを実行するだけ。例：

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

デフォルトの管理者アカウントは`admin@mini-software.github.io`、パスワードは`E7c4f679-f379-42bf-b547-684d456bc37f`です（パスワードは必ず変更してください）。管理画面は`http(s)://yourhost/miniauth/index.html`でアクセスできます。

権限管理やロール制御が必要なカテゴリやメソッドには`[Authorize]`や`[Authorize(Roles = "role")]`を付与してください。未ログインの場合は401、権限なしの場合は403ステータスを返します。



### MiniAuth Cookie Identity

MiniAuthはデフォルトで単一のCookieベース認証が設定されています。フロントエンド・バックエンド分離プロジェクトの場合はJWT等に変更してください。



### MiniAuth  JWT  Identity

AuthenticationType = BearerJwtを設定

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

JWTセキュリティキーも必ず新規で設定してください。例：

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### トークン取得方法

フロントエンドJavascript XHR例

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

レスポンス例

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

`accessToken`をlocalstorageやcookie等に保存し、[Authorize]API呼び出し時は`Header Authorization`に`Bearer + 半角スペース + accessToken`を設定してください。システムが自動的に検証します。

例：

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



#### 有効期限設定

```c#
options.TokenExpiresIn = 30 * 60; 
```

単位は秒で、デフォルトは30分です。また、.NET JWTのJwtBearerOptionsのClockSkewにより5分多く許容されている点にもご注意ください。[理由](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api)。

#### リフレッシュトークンAPI（JWT）

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
有効期限は`MiniAuthOptions.TokenExpiresIn / 2`で設定され、デフォルトは30分です。



### 設定・オプション・カスタマイズ

#### デフォルトモード

- MiniAuthのデフォルトモードはIT管理者による集中ユーザー管理です。ユーザー登録やパスワードリセットなどの操作には、role = miniauth-adminが付与された管理者アカウントが必要です。

#### MiniAuthログインを無効化

自身のログインロジック、ページ、APIのみを使用したい場合は、ログインパスを指定し、MiniAuthログインスイッチを無効化できます。
```C#
// サービス登録の前に配置してください
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### デフォルトのSQLite接続文字列をカスタマイズ

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### カスタムデータベース、ユーザー、ロール

MiniAuthはデフォルトでSQLite EF Core、IdentityUser、IdentityRoleとシームレスに動作するように設計されています。これらを変更する場合は、`app.UseMiniAuth`でジェネリクスを使用して異なるデータベースや独自のユーザークラス・ロールクラスを指定してください。

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### ログイン、ユーザー認証

ApiControllerでない場合、デフォルトのログインリダイレクト先はlogin.htmlページです（Headers["X-Requested-With"] == "XMLHttpRequest"かApiControllerAttributeの有無で判定）。
ApiControllerとしてマークされたコントローラーは、デフォルトでログインページにリダイレクトされず、401ステータスコードを返します。

### カスタムフロントエンド

- 管理ダッシュボードのフロントエンドは `/src/Frontend_Identity` にあり、主にVue3 + Viteを使用しています。`npm run build`を実行するとminiauth UIが更新されます。
- デフォルトのminiauthログインページを使用しない場合、MVCではidentityで提供されるscaffoldされたLogin.cshtmlを使うことができ、またはminiauthフロントエンドのlogin.html、js、cssファイルを修正できます。

### カスタムルートプレフィックス

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

デフォルトのRoutePrefixは`MiniAuth`です。



### ログインAPI（JWT）

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



### ユーザー登録

ASP.NET Core Identityが提供する組み込みの登録APIおよびページをご利用ください。

### パスワードをお忘れの場合

ASP.NET Core Identityが提供する組み込みのパスワードリセットAPIおよびページをご利用ください。

### ユーザー情報の取得

ユーザー情報の取得には、ASP.NET Core Identityが提供する組み込みのAPIおよびページをご利用ください。必要なユーザーデータを公開するために、アプリケーションの要件に応じて追加のロジックやエンドポイントの実装が必要になる場合があります。ASP.NET Core Identityは、プロフィールデータ、ロール、クレームを含むユーザー情報管理のための堅牢なフレームワークを提供します。

### 注意事項

#### 順序に注意

UseMiniAuthはルート生成の後に配置してください。そうしないと、権限チェック用のルーティングデータが取得できません。以下のようにします。

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### 注意: ロールルールを追加してください

`AddRoles<IdentityRole>()`を追加してください。追加しないと`[Authorize(Roles = "permission")]`が機能しません。

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### 既存のIdentityプロジェクトへのMiniAuthの統合とカスタムロジック

AddMiniAuthのautoUseを無効化し、自身の認証の後にUseMiniAuthを配置します。ジェネリックパラメータを自身のIdentityDBContext、ユーザー、認可ロジックに置き換えてください。以下は例です。

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

これにより、独自のユーザー、ロール、データベース、Identityロジックを切り替えて使用できます。



#### 分散システム

- データベースソースには、SQL Server、MySQL、PostgreSQLなどのデータベースへの切り替えを検討してください。
- 分散環境での統合を強化するため、JWTなどの認証方式への切り替えを推奨します。

### リリースノート

更新内容については[リリースノート](https://raw.githubusercontent.com/mini-software/MiniAuth/main/releases)をご参照ください。

### TODO

リンク: [MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---