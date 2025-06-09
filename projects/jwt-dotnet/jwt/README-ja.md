<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net、.NET向けJWT（JSON Web Token）実装](#jwtnet-a-jwt-json-web-token-implementation-for-net)
- [スポンサー](#sponsor)
- [利用可能なNuGetパッケージ](#avaliable-nuget-packages)
- [対応している.NETバージョン:](#supported-net-versions)
- [Jwt.NET](#jwtnet)
  - [トークンの作成（エンコード）](#creating-encoding-token)
    - [またはフルエントビルダーAPIの利用](#or-using-the-fluent-builder-api)
  - [トークンの解析（デコード）と検証](#parsing-decoding-and-verifying-token)
    - [またはフルエントビルダーAPIの利用](#or-using-the-fluent-builder-api-1)
    - [またはフルエントビルダーAPIの利用](#or-using-the-fluent-builder-api-2)
  - [トークン有効期限の検証](#validate-token-expiration)
  - [トークンヘッダーの解析（デコード）](#parsing-decoding-token-header)
    - [またはフルエントビルダーAPIの利用](#or-using-the-fluent-builder-api-3)
  - [トークン検証の一部無効化](#turning-off-parts-of-token-validation)
    - [またはフルエントビルダーAPIの利用](#or-using-the-fluent-builder-api-4)
  - [カスタムJSONシリアライザ](#custom-json-serializer)
  - [デフォルトJsonNetSerializerによるカスタムJSONシリアライズ設定](#custom-json-serialization-settings-with-the-default-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [JWTを検証する認証ハンドラの登録](#register-authentication-handler-to-validate-jwt)
  - [IdentityやAuthenticationTicketを生成するカスタムファクトリ](#custom-factories-to-produce-identity-or-authenticationticket)
- [ライセンス](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net、.NET向けJWT（JSON Web Token）実装

このライブラリは[JSON Web Tokens](https://tools.ietf.org/html/rfc7519)の生成とデコードをサポートします。

## スポンサー

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | JWTプロジェクトへ安全な認証を素早く導入したい場合は、[Auth0アカウントを作成](https://a0.to/try-auth0)してください。無料で利用できます！ |

## 利用可能なNuGetパッケージ

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Microsoft Dependency Injectionコンテナ向けJwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. ASP.NET Core向けJwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## 対応している.NETバージョン:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### トークンの作成（エンコード）

```c#
var payload = new Dictionary<string, object>
{
    { "claim1", 0 },
    { "claim2", "claim2-value" }
};

IJwtAlgorithm algorithm = new RS256Algorithm(certificate);
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
const string key = null; // アルゴリズムが非対称の場合は不要

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### またはフルエントビルダーAPIの利用

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### トークンの解析（デコード）と検証

```c#
try
{
    IJsonSerializer serializer = new JsonNetSerializer();
    IDateTimeProvider provider = new UtcDateTimeProvider();
    IJwtValidator validator = new JwtValidator(serializer, provider);
    IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
    IJwtAlgorithm algorithm = new RS256Algorithm(certificate);
    IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);
    
    var json = decoder.Decode(token);
    Console.WriteLine(json);
}
catch (TokenNotYetValidException)
{
    Console.WriteLine("トークンはまだ有効ではありません");
}
catch (TokenExpiredException)
{
    Console.WriteLine("トークンの有効期限が切れています");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("トークンの署名が無効です");
}
```

#### またはフルエントビルダーAPIの利用

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

出力例:

>{ "claim1": 0, "claim2": "claim2-value" }

JSONペイロードを.NET型へ直接デシリアライズすることも可能です:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### またはフルエントビルダーAPIの利用

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### トークン有効期限の検証

[RFC 7519 セクション4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4)で説明されている通り:

>`exp` クレームは、JWTが処理のために受け付けられるべきでない時刻を識別します。

ペイロードに存在し、現在時刻を過ぎている場合はトークンの検証が失敗します。値は[Unixエポック](https://en.wikipedia.org/wiki/Unix_time)（1970年1月1日00:00:00 UTC）からの経過秒数で指定する必要があります。

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // トークンは5分前に有効期限切れ

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // TokenExpiredExceptionをスロー
```

続いて、[RFC 7519 セクション4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5)で説明されている通り:

>`nbf`（not before）クレームは、JWTが処理のために受け付けられるべきでない時刻を識別します

ペイロードに存在し、現在時刻より後の場合、トークンの検証は失敗します。

### トークンヘッダーの解析（デコード）

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### またはフルエントビルダーAPIの利用

```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### トークン検証の一部を無効にする

トークンを検証したいが、検証の一部（例えばトークンが有効期限切れか、まだ有効でないかなど）を無視したい場合は、`ValidateParameters` オブジェクトを `JwtValidator` クラスのコンストラクタに渡すことができます。

```c#
var validationParameters = new ValidationParameters
{
    ValidateSignature = true,
    ValidateExpirationTime = false,
    ValidateIssuedTime = false,
    TimeMargin = 100
};
IJwtValidator validator = new JwtValidator(serializer, provider, validationParameters);
IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);
var json = decoder.Decode(expiredToken); // 有効期限切れのトークンでも例外をスローしません
```

#### またはフルーエントビルダーAPIを使用する

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorirhm(certificate))
                     .WithSecret(secret)
                     .WithValidationParameters(
                         new ValidationParameters
                         {
                             ValidateSignature = true,
                             ValidateExpirationTime = false,
                             ValidateIssuedTime = false,
                             TimeMargin = 100
                         })
                     .Decode(expiredToken);
```

### カスタムJSONシリアライザー

デフォルトでは、JSONシリアライズは [Json.Net](https://www.json.net) を使って実装された JsonNetSerializer によって行われます。別のものを使用したい場合は、`IJsonSerializer` インターフェースを実装してください。

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // お好みのJSONシリアライザーで実装
    }

    public T Deserialize<T>(string json)
    {
        // お好みのJSONシリアライザーで実装
    }
}
```

そして、このシリアライザーを JwtEncoder のコンストラクタに渡します。

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### デフォルトのJsonNetSerializerでカスタムJSONシリアライズ設定を利用する

前述の通り、デフォルトのJSONシリアライズは `JsonNetSerializer` により行われます。以下のように独自のシリアライズ設定を定義できます。

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // モデル／プロパティの正確な大文字小文字ではなく、すべてのキーが小文字で始まります。例: fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // 読みやすくしますが、ペイロードサイズを減らす場合は Formatting.None も使えます
    Formatting = Formatting.Indented,
    
    // 最も適切な日付時刻フォーマット
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // 値が null の場合はキー／値を追加しません
    NullValueHandling = NullValueHandling.Ignore,
    
    // 列挙型は暗黙の int 値ではなく文字列値を使います。例: enum Color { Red } の "red"
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### JWTを検証する認証ハンドラの登録

```c#
public void ConfigureServices(IServiceCollection services)
{
    services.AddAuthentication(options =>
                 {
                     options.DefaultAuthenticateScheme = JwtAuthenticationDefaults.AuthenticationScheme;
                     options.DefaultChallengeScheme = JwtAuthenticationDefaults.AuthenticationScheme;
                 })
            .AddJwt(options =>
                 {
                     // シークレット。対称アルゴリズム（HMACSHA256Algorithmなど）の場合のみ必須
                     // options.Keys = new[] { "mySecret" };
                     
                     // 任意。JWT署名が無効な場合に例外をスローしないようにする
                     // options.VerifySignature = false;
                 });
  // ジェネリックでないAddJwt()を使う場合は、IAlgorithmFactoryのインスタンスを手動で登録する必要があります
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // または
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // またはジェネリック版 AddJwt<TFactory()> を使い、独自実装の IAlgorithmFactory を利用
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Identity または AuthenticationTicket を生成するカスタムファクトリ

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## ライセンス

以下のプロジェクトおよびそれらにより生成されたパッケージはパブリックドメインの下でライセンスされています。詳細は [LICENSE#Public-Domain](LICENSE.md#Public-Domain) ファイルを参照してください。

- JWT 

以下のプロジェクトおよびそれらにより生成されたパッケージはMITライセンスの下でライセンスされています。詳細は [LICENSE#MIT](LICENSE.md#MIT) ファイルを参照してください。

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---