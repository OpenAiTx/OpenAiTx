<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, การใช้งาน JWT (JSON Web Token) สำหรับ .NET](#jwtnet-a-jwt-json-web-token-implementation-for-net)
- [สปอนเซอร์](#sponsor)
- [แพ็คเกจ NuGet ที่มีให้ใช้งาน](#avaliable-nuget-packages)
- [เวอร์ชัน .NET ที่รองรับ:](#supported-net-versions)
- [Jwt.NET](#jwtnet)
  - [การสร้าง (เข้ารหัส) โทเคน](#creating-encoding-token)
    - [หรือใช้ fluent builder API](#or-using-the-fluent-builder-api)
  - [การแปลง (ถอดรหัส) และตรวจสอบโทเคน](#parsing-decoding-and-verifying-token)
    - [หรือใช้ fluent builder API](#or-using-the-fluent-builder-api-1)
    - [หรือใช้ fluent builder API](#or-using-the-fluent-builder-api-2)
  - [ตรวจสอบวันหมดอายุของโทเคน](#validate-token-expiration)
  - [การแปลง (ถอดรหัส) เฮดเดอร์ของโทเคน](#parsing-decoding-token-header)
    - [หรือใช้ fluent builder API](#or-using-the-fluent-builder-api-3)
  - [ปิดการตรวจสอบบางส่วนของโทเคน](#turning-off-parts-of-token-validation)
    - [หรือใช้ fluent builder API](#or-using-the-fluent-builder-api-4)
  - [ปรับแต่ง JSON serializer](#custom-json-serializer)
  - [ปรับแต่งค่า JSON serialization ร่วมกับ JsonNetSerializer เริ่มต้น](#custom-json-serialization-settings-with-the-default-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [ลงทะเบียน authentication handler เพื่อตรวจสอบ JWT](#register-authentication-handler-to-validate-jwt)
  - [โรงงานกำหนดเองเพื่อสร้าง Identity หรือ AuthenticationTicket](#custom-factories-to-produce-identity-or-authenticationticket)
- [ไลเซนส์](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, การใช้งาน JWT (JSON Web Token) สำหรับ .NET

ไลบรารีนี้รองรับการสร้างและถอดรหัส [JSON Web Tokens](https://tools.ietf.org/html/rfc7519)

## สปอนเซอร์

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | หากคุณต้องการเพิ่มการยืนยันตัวตนที่ปลอดภัยให้กับโปรเจกต์ JWT ของคุณอย่างรวดเร็ว [สร้างบัญชี Auth0](https://a0.to/try-auth0) ได้ฟรี! |

## แพ็คเกจ NuGet ที่มีให้ใช้งาน

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net สำหรับ Microsoft Dependency Injection container

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net สำหรับ ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## เวอร์ชัน .NET ที่รองรับ:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### การสร้าง (เข้ารหัส) โทเคน

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
const string key = null; // ไม่ต้องใช้ถ้าเป็นอัลกอริทึมแบบอสมมาตร

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### หรือใช้ fluent builder API

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### การแปลง (ถอดรหัส) และตรวจสอบโทเคน

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
    Console.WriteLine("Token ยังไม่สามารถใช้งานได้");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Token หมดอายุแล้ว");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("ลายเซ็นของ Token ไม่ถูกต้อง");
}
```

#### หรือใช้ fluent builder API

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

ผลลัพธ์จะเป็น:

>{ "claim1": 0, "claim2": "claim2-value" }

คุณสามารถแปลง payload JSON ไปเป็นชนิดข้อมูลของ .NET ได้โดยตรงเช่นกัน:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### หรือใช้ fluent builder API

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### ตรวจสอบวันหมดอายุของโทเคน

ตามที่ระบุไว้ใน [RFC 7519 หมวด 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4):

> `exp` claim ใช้ระบุเวลาหมดอายุ ซึ่งหลังจากเวลานี้ JWT จะต้องไม่ถูกยอมรับในการประมวลผล

หาก `exp` มีใน payload และเวลาปัจจุบันเกินเวลาที่กำหนด โทเคนจะไม่ผ่านการตรวจสอบ ค่านี้ต้องเป็นจำนวนวินาทีตั้งแต่ [Unix epoch](https://en.wikipedia.org/wiki/Unix_time), 1/1/1970 00:00:00 UTC

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // โทเคนหมดอายุไปแล้ว 5 นาที

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // จะเกิดข้อผิดพลาด TokenExpiredException
```

ต่อมา ตามที่ระบุใน [RFC 7519 หมวด 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5):

> claim "nbf" (not before) ใช้ระบุเวลาก่อนที่ JWT จะยังไม่สามารถใช้งานได้

หาก `nbf` มีใน payload และเวลาปัจจุบันยังไม่ถึงเวลานั้น โทเคนจะไม่ผ่านการตรวจสอบ

### การแปลง (ถอดรหัส) เฮดเดอร์ของโทเคน

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### หรือใช้ fluent builder API
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### ปิดการตรวจสอบบางส่วนของโทเคน

หากคุณต้องการตรวจสอบความถูกต้องของโทเคนแต่ต้องการข้ามบางส่วนของการตรวจสอบ (เช่น การหมดอายุของโทเคนหรือโทเคนยังไม่เริ่มใช้) คุณสามารถส่งอ็อบเจ็กต์ `ValidateParameters` ไปยัง constructor ของคลาส `JwtValidator`

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
var json = decoder.Decode(expiredToken); // จะไม่ throw แม้ token หมดอายุ
```

#### หรือใช้ Fluent Builder API

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

### กำหนด JSON Serializer เอง

โดยปกติแล้วการแปลงเป็น JSON จะดำเนินการโดย JsonNetSerializer ซึ่งใช้ [Json.Net](https://www.json.net) หากต้องการใช้งานตัวอื่น ให้ implements อินเทอร์เฟซ `IJsonSerializer`:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // เขียนโค้ดโดยใช้ JSON serializer ที่คุณชื่นชอบ
    }

    public T Deserialize<T>(string json)
    {
        // เขียนโค้ดโดยใช้ JSON serializer ที่คุณชื่นชอบ
    }
}
```

จากนั้นส่ง serializer นี้ไปยัง constructor ของ JwtEncoder:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### ตั้งค่า JSON Serialization เองโดยใช้ JsonNetSerializer เริ่มต้น

ดังที่กล่าวไว้ข้างต้น การแปลงเป็น JSON เริ่มต้นจะใช้ `JsonNetSerializer` คุณสามารถกำหนดค่า serialization เองได้ดังนี้:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // คีย์ทั้งหมดขึ้นต้นด้วยอักษรตัวเล็ก เช่น fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // อ่านง่ายสวยงาม แต่สามารถใช้ Formatting.None เพื่อลดขนาด payload ได้
    Formatting = Formatting.Indented,
    
    // รูปแบบวันที่ที่เหมาะสม
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // จะไม่เพิ่ม key/value ถ้า value เป็น null
    NullValueHandling = NullValueHandling.Ignore,
    
    // ใช้ค่า string ของ enum ไม่ใช่ค่า int เช่น "red" สำหรับ enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### ลงทะเบียน handler สำหรับการตรวจสอบ JWT

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
                     // secrets, ใช้กับอัลกอริทึมสมมาตรเท่านั้น เช่น HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // เลือกได้; ปิดการ throw exception หากลายเซ็น JWT ไม่ถูกต้อง
                     // options.VerifySignature = false;
                 });
  // กรณีใช้ AddJwt() แบบไม่ระบุ generic ต้องลงทะเบียน IAlgorithmFactory ด้วยตัวเอง
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // หรือ
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // หรือใช้ AddJwt<TFactory>() เพื่อใช้ implementation ของ IAlgorithmFactory แบบกำหนดเอง
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### สร้าง Factory เองเพื่อผลิต Identity หรือ AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## ใบอนุญาต

โปรเจกต์ดังต่อไปนี้และแพคเกจที่ได้จากโปรเจกต์เหล่านี้อยู่ภายใต้สาธารณสมบัติ (Public Domain) ดูรายละเอียดได้ที่ไฟล์ [LICENSE#Public-Domain](LICENSE.md#Public-Domain)

- JWT 

โปรเจกต์ดังต่อไปนี้และแพคเกจที่ได้จากโปรเจกต์เหล่านี้อยู่ภายใต้สัญญาอนุญาต MIT ดูรายละเอียดได้ที่ไฟล์ [LICENSE#MIT](LICENSE.md#MIT)

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---