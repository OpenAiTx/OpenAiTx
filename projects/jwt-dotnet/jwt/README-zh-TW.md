<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net，一個用於 .NET 的 JWT（JSON Web Token）實作](#jwtnet-a-jwt-json-web-token-implementation-for-net)
- [贊助](#sponsor)
- [可用的 NuGet 套件](#avaliable-nuget-packages)
- [支援的 .NET 版本：](#supported-net-versions)
- [Jwt.NET](#jwtnet)
  - [建立（編碼）Token](#creating-encoding-token)
    - [或使用 fluent builder API](#or-using-the-fluent-builder-api)
  - [解析（解碼）與驗證 Token](#parsing-decoding-and-verifying-token)
    - [或使用 fluent builder API](#or-using-the-fluent-builder-api-1)
    - [或使用 fluent builder API](#or-using-the-fluent-builder-api-2)
  - [驗證 Token 到期時間](#validate-token-expiration)
  - [解析（解碼）Token 標頭](#parsing-decoding-token-header)
    - [或使用 fluent builder API](#or-using-the-fluent-builder-api-3)
  - [關閉部分 Token 驗證](#turning-off-parts-of-token-validation)
    - [或使用 fluent builder API](#or-using-the-fluent-builder-api-4)
  - [自訂 JSON 序列化器](#custom-json-serializer)
  - [使用預設 JsonNetSerializer 的自訂 JSON 序列化設定](#custom-json-serialization-settings-with-the-default-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [註冊驗證 JWT 的認證處理器](#register-authentication-handler-to-validate-jwt)
  - [自訂工廠以產生 Identity 或 AuthenticationTicket](#custom-factories-to-produce-identity-or-authenticationticket)
- [授權條款](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net，一個用於 .NET 的 JWT（JSON Web Token）實作

此函式庫支援產生與解碼 [JSON Web Tokens](https://tools.ietf.org/html/rfc7519)。

## 贊助

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | 如果您想要快速為您的 JWT 專案實現安全的認證，[建立一個 Auth0 帳號](https://a0.to/try-auth0)；免費使用！ |

## 可用的 NuGet 套件

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. 適用於 Microsoft Dependency Injection 容器的 Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. 適用於 ASP.NET Core 的 Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## 支援的 .NET 版本：

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### 建立（編碼）Token

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
const string key = null; // 若為非對稱演算法則不需設定 key

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### 或使用 fluent builder API

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### 解析（解碼）與驗證 Token

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
    Console.WriteLine("Token 尚未生效");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Token 已過期");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Token 簽章驗證失敗");
}
```

#### 或使用 fluent builder API

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

輸出結果會是：

>{ "claim1": 0, "claim2": "claim2-value" }

你也可以直接將 JSON payload 反序列化為 .NET 型別：

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### 或使用 fluent builder API

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### 驗證 Token 到期時間

如 [RFC 7519 section 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4) 所述：

> `exp` 聲明標識了 JWT 不應被接受處理的過期時間點。

如果 payload 中包含此欄位且早於目前時間，Token 驗證會失敗。該值必須指定為自 [Unix 紀元](https://en.wikipedia.org/wiki/Unix_time)（1970/1/1 00:00:00 UTC）以來的秒數。

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // token 已於 5 分鐘前過期

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // 會丟出 TokenExpiredException
```

接著，根據 [RFC 7519 section 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5)：

> "nbf"（not before）聲明標識了 JWT 不應被接受處理的起始時間

如果 payload 中包含此欄位且早於目前時間，Token 驗證會失敗。

### 解析（解碼）Token 標頭

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### 或使用 fluent builder API
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### 關閉部分權杖驗證

如果您希望驗證權杖，但忽略某些驗證部分（例如權杖是否已過期或尚未生效），可以將 `ValidateParameters` 物件傳遞給 `JwtValidator` 類別的建構子。

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
var json = decoder.Decode(expiredToken); // 不會因為權杖過期而丟出例外
```

#### 或使用 fluent builder API

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

### 自訂 JSON 序列化器

預設的 JSON 序列化由以 [Json.Net](https://www.json.net) 實作的 JsonNetSerializer 執行。若要使用不同的序列化器，請實作 `IJsonSerializer` 介面：

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // 使用您偏好的 JSON 序列化器實作
    }

    public T Deserialize<T>(string json)
    {
        // 使用您偏好的 JSON 序列化器實作
    }
}
```

然後將此序列化器傳遞給 JwtEncoder 建構子：

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### 使用預設 JsonNetSerializer 的自訂 JSON 序列化設定

如上所述，預設的 JSON 序列化由 `JsonNetSerializer` 執行。您可以如下定義自己的自訂序列化設定：

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // 所有鍵皆以小寫字母開頭，而不是模型/屬性的原始大小寫，例如 fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // 格式化為易讀的格式，但您也可以使用 Formatting.None 以減少負載大小
    Formatting = Formatting.Indented,
    
    // 採用最合適的日期時間格式
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // 當值為 null 時不加入鍵/值
    NullValueHandling = NullValueHandling.Ignore,
    
    // 使用列舉的字串值，而非預設的 int 值，例如 enum Color { Red } 會顯示為 "red"
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### 註冊驗證處理器以驗證 JWT

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
                     // 金鑰，僅對對稱式演算法（如 HMACSHA256Algorithm）為必填
                     // options.Keys = new[] { "mySecret" };
                     
                     // 可選；如 JWT 簽名無效時不丟出例外
                     // options.VerifySignature = false;
                 });
  // 非泛型版本 AddJwt() 需手動註冊 IAlgorithmFactory 實體
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // 或
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // 或使用泛型版本 AddJwt<TFactory() 以自訂 IAlgorithmFactory 實作
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### 產生 Identity 或 AuthenticationTicket 的自訂工廠

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## 授權條款

以下專案及其所產生的套件以 Public Domain 授權，詳見 [LICENSE#Public-Domain](LICENSE.md#Public-Domain) 檔案。

- JWT 

以下專案及其所產生的套件以 MIT 授權，詳見 [LICENSE#MIT](LICENSE.md#MIT) 檔案。

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---