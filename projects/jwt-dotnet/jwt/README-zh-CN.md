<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net，.NET 的 JWT（JSON Web Token）实现](#jwtnet-a-jwt-json-web-token-implementation-for-net)
- [赞助商](#sponsor)
- [可用的 NuGet 包](#avaliable-nuget-packages)
- [支持的 .NET 版本：](#supported-net-versions)
- [Jwt.NET](#jwtnet)
  - [创建（编码）令牌](#creating-encoding-token)
    - [或使用 Fluent Builder API](#or-using-the-fluent-builder-api)
  - [解析（解码）并验证令牌](#parsing-decoding-and-verifying-token)
    - [或使用 Fluent Builder API](#or-using-the-fluent-builder-api-1)
    - [或使用 Fluent Builder API](#or-using-the-fluent-builder-api-2)
  - [验证令牌过期时间](#validate-token-expiration)
  - [解析（解码）令牌头部](#parsing-decoding-token-header)
    - [或使用 Fluent Builder API](#or-using-the-fluent-builder-api-3)
  - [关闭部分令牌验证](#turning-off-parts-of-token-validation)
    - [或使用 Fluent Builder API](#or-using-the-fluent-builder-api-4)
  - [自定义 JSON 序列化器](#custom-json-serializer)
  - [使用默认 JsonNetSerializer 的自定义 JSON 序列化设置](#custom-json-serialization-settings-with-the-default-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [注册身份验证处理程序以验证 JWT](#register-authentication-handler-to-validate-jwt)
  - [自定义工厂生成 Identity 或 AuthenticationTicket](#custom-factories-to-produce-identity-or-authenticationticket)
- [许可证](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net，.NET 的 JWT（JSON Web Token）实现

该库支持生成和解码 [JSON Web Tokens](https://tools.ietf.org/html/rfc7519)。

## 赞助商

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | 如果你想快速为你的 JWT 项目实现安全认证，[创建一个 Auth0 账户](https://a0.to/try-auth0)；永久免费！ |

## 可用的 NuGet 包

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. 用于 Microsoft 依赖注入容器的 Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. 用于 ASP.NET Core 的 Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## 支持的 .NET 版本：

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### 创建（编码）令牌

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
const string key = null; // 如果算法为非对称则不需要密钥

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### 或使用 Fluent Builder API

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### 解析（解码）并验证令牌

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
    Console.WriteLine("Token is not valid yet");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Token has expired");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Token has invalid signature");
}
```

#### 或使用 Fluent Builder API

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

输出结果将为：

>{ "claim1": 0, "claim2": "claim2-value" }

你也可以直接将 JSON 载荷反序列化为 .NET 类型：

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### 或使用 Fluent Builder API

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### 验证令牌过期时间

如 [RFC 7519 第 4.1.4 节](https://tools.ietf.org/html/rfc7519#section-4.1.4) 所述：

>`exp` 声明用于标识 JWT 不得被接受处理的过期时间。

如果它出现在载荷中且已超过当前时间，令牌验证将失败。该值必须指定为自 [Unix 纪元](https://en.wikipedia.org/wiki/Unix_time)（1970 年 1 月 1 日 00:00:00 UTC）以来的秒数。

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // 令牌已过期 5 分钟

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // 抛出 TokenExpiredException
```

然后，如 [RFC 7519 第 4.1.5 节](https://tools.ietf.org/html/rfc7519#section-4.1.5) 所述：

>“nbf”（不早于）声明用于标识 JWT 不得被接受处理的时间

如果它出现在载荷中且早于当前时间，令牌验证将失败。

### 解析（解码）令牌头部

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### 或使用 Fluent Builder API
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### 关闭部分令牌验证

如果你想要验证令牌，但忽略某些验证部分（比如令牌是否已过期或尚未生效），可以将 `ValidateParameters` 对象传递给 `JwtValidator` 类的构造函数。

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
var json = decoder.Decode(expiredToken); // 不会因令牌过期而抛出异常
```

#### 或者使用流式构建器 API

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

### 自定义 JSON 序列化器

默认情况下，JSON 序列化由基于 [Json.Net](https://www.json.net) 实现的 JsonNetSerializer 完成。要使用其他序列化器，请实现 `IJsonSerializer` 接口：

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // 使用你喜欢的 JSON 序列化器实现
    }

    public T Deserialize<T>(string json)
    {
        // 使用你喜欢的 JSON 序列化器实现
    }
}
```

然后将该序列化器传递给 JwtEncoder 构造函数：

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### 使用默认 JsonNetSerializer 的自定义 JSON 序列化设置

如上所述，默认的 JSON 序列化是通过 `JsonNetSerializer` 完成的。你可以如下定义自己的自定义序列化设置：

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // 所有键以小写字母开头，而不是模型/属性的原始大小写，例如 fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // 更易于阅读，也可以使用 Formatting.None 来减小载荷大小
    Formatting = Formatting.Indented,
    
    // 最合适的日期时间格式
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // 当值为 null 时不添加键/值
    NullValueHandling = NullValueHandling.Ignore,
    
    // 使用枚举的字符串值，而不是隐式的整型值，例如枚举 Color { Red } 的 "red"
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### 注册认证处理程序以验证 JWT

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
                     // 密钥，仅对对称算法（如 HMACSHA256Algorithm）必需
                     // options.Keys = new[] { "mySecret" };
                     
                     // 可选；若 JWT 签名无效时禁用抛出异常
                     // options.VerifySignature = false;
                 });
  // 非泛型版本 AddJwt() 需要手动注册 IAlgorithmFactory 实例
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // 或者
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // 或使用泛型版本 AddJwt<TFactory>()，以使用自定义的 IAlgorithmFactory 实现
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### 自定义工厂生成 Identity 或 AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## 许可证

以下项目及其生成的软件包采用公有领域（Public Domain）许可，详见 [LICENSE#Public-Domain](LICENSE.md#Public-Domain) 文件。

- JWT 

以下项目及其生成的软件包采用 MIT 许可证，详见 [LICENSE#MIT](LICENSE.md#MIT) 文件。

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---