<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, a JWT (JSON Web Token) implementation for .NET](#jwtnet-a-jwt-json-web-token-implementation-for-net)
- [Sponsor](#sponsor)
- [Avaliable NuGet packages](#avaliable-nuget-packages)
- [Supported .NET versions:](#supported-net-versions)
- [Jwt.NET](#jwtnet)
  - [Creating (encoding) token](#creating-encoding-token)
    - [Or using the fluent builder API](#or-using-the-fluent-builder-api)
  - [Parsing (decoding) and verifying token](#parsing-decoding-and-verifying-token)
    - [Or using the fluent builder API](#or-using-the-fluent-builder-api-1)
    - [Or using the fluent builder API](#or-using-the-fluent-builder-api-2)
  - [Validate token expiration](#validate-token-expiration)
  - [Parsing (decoding) token header](#parsing-decoding-token-header)
    - [Or using the fluent builder API](#or-using-the-fluent-builder-api-3)
  - [Turning off parts of token validation](#turning-off-parts-of-token-validation)
    - [Or using the fluent builder API](#or-using-the-fluent-builder-api-4)
  - [Custom JSON serializer](#custom-json-serializer)
  - [Custom JSON serialization settings with the default JsonNetSerializer](#custom-json-serialization-settings-with-the-default-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [Register authentication handler to validate JWT](#register-authentication-handler-to-validate-jwt)
  - [Custom factories to produce Identity or AuthenticationTicket](#custom-factories-to-produce-identity-or-authenticationticket)
- [License](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, a JWT (JSON Web Token) implementation for .NET

이 라이브러리는 [JSON Web Tokens](https://tools.ietf.org/html/rfc7519)의 생성 및 디코딩을 지원합니다.

## Sponsor

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | JWT 프로젝트에 빠르게 보안 인증을 구현하고 싶다면 [Auth0 계정을 생성하세요](https://a0.to/try-auth0); 무료입니다! |

## Avaliable NuGet packages

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Microsoft Dependency Injection 컨테이너용 Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. ASP.NET Core용 Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Supported .NET versions:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Creating (encoding) token

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
const string key = null; // 비대칭 알고리즘인 경우 필요하지 않음

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### Or using the fluent builder API

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Parsing (decoding) and verifying token

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
    Console.WriteLine("토큰이 아직 유효하지 않습니다");
}
catch (TokenExpiredException)
{
    Console.WriteLine("토큰이 만료되었습니다");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("토큰 서명이 올바르지 않습니다");
}
```

#### Or using the fluent builder API

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

출력 예시는 다음과 같습니다:

>{ "claim1": 0, "claim2": "claim2-value" }

또한, JSON payload를 .NET 타입으로 직접 역직렬화할 수 있습니다:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### Or using the fluent builder API

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Validate token expiration

[RFC 7519 section 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4)에 설명된 대로:

>`exp` 클레임은 JWT가 처리용으로 더 이상 허용되어서는 안 되는 만료 시간을 식별합니다.

payload에 존재하고 현재 시간이 이를 지난 경우, 토큰 검증에 실패하게 됩니다. 값은 [Unix epoch](https://en.wikipedia.org/wiki/Unix_time), 1970년 1월 1일 00:00:00 UTC 이후의 초 단위로 지정해야 합니다.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // 토큰이 5분 전에 만료됨

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // TokenExpiredException 발생
```

그리고, [RFC 7519 section 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5)에 설명된 대로:

>"nbf" (not before) 클레임은 JWT가 처리용으로 허용되기 전의 시간을 식별합니다.

payload에 존재하고 현재 시간 이전인 경우, 토큰 검증에 실패하게 됩니다.

### Parsing (decoding) token header

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### Or using the fluent builder API
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### 토큰 유효성 검사의 일부를 비활성화하기

토큰을 검증하되, 만료 여부나 아직 유효하지 않은 경우와 같은 특정 검증을 무시하고 싶다면, `JwtValidator` 클래스의 생성자에 `ValidateParameters` 객체를 전달할 수 있습니다.

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
var json = decoder.Decode(expiredToken); // 만료된 토큰이어도 예외가 발생하지 않음
```

#### 또는 fluent builder API 사용

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

### 커스텀 JSON 직렬화기

기본적으로 JSON 직렬화는 [Json.Net](https://www.json.net)을 사용하여 구현된 JsonNetSerializer가 수행합니다. 다른 것을 사용하려면, `IJsonSerializer` 인터페이스를 구현하면 됩니다.

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // 선호하는 JSON 직렬화기 사용하여 구현
    }

    public T Deserialize<T>(string json)
    {
        // 선호하는 JSON 직렬화기 사용하여 구현
    }
}
```

그리고 이 직렬화기를 JwtEncoder 생성자에 전달합니다.

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### 기본 JsonNetSerializer에서 커스텀 JSON 직렬화 설정

위에서 언급했듯이, 기본 JSON 직렬화는 `JsonNetSerializer`로 처리됩니다. 아래와 같이 커스텀 직렬화 설정을 정의할 수 있습니다.

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // 모든 키는 모델/프로퍼티의 정확한 대소문자가 아닌 소문자로 시작, 예: fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // 가독성이 좋으나, 페이로드 크기를 줄이려면 Formatting.None 사용 가능
    Formatting = Formatting.Indented,
    
    // 가장 적합한 날짜/시간 형식
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // 값이 null일 경우 키/값을 추가하지 않음
    NullValueHandling = NullValueHandling.Ignore,
    
    // enum의 암시적 int 값이 아닌 문자열 값을 사용, 예: enum Color { Red }일 때 "red"
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### JWT 유효성 검사용 인증 핸들러 등록

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
                     // 대칭 알고리즘(HMACSHA256Algorithm 등)에서만 필요, 시크릿 지정
                     // options.Keys = new[] { "mySecret" };
                     
                     // 선택 사항; JWT 서명이 유효하지 않을 때 예외 발생 비활성화
                     // options.VerifySignature = false;
                 });
  // 비제네릭 AddJwt() 사용 시 IAlgorithmFactory 인스턴스 직접 등록 필요
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // 또는
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // 또는 제네릭 버전 AddJwt<TFactory()로 IAlgorithmFactory의 커스텀 구현체 사용
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Identity 또는 AuthenticationTicket 생성을 위한 커스텀 팩토리

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## 라이선스

다음 프로젝트 및 결과물 패키지는 퍼블릭 도메인으로 라이선스가 부여되어 있습니다. 자세한 내용은 [LICENSE#Public-Domain](LICENSE.md#Public-Domain) 파일을 참고하세요.

- JWT 

다음 프로젝트 및 결과물 패키지는 MIT 라이선스 하에 있습니다. 자세한 내용은 [LICENSE#MIT](LICENSE.md#MIT) 파일을 참고하세요.

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---