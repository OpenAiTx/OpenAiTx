<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net، تنفيذ JWT (JSON Web Token) لـ .NET](#jwtnet-a-jwt-json-web-token-implementation-for-net)
- [راعي](#sponsor)
- [حزم NuGet المتوفرة](#avaliable-nuget-packages)
- [إصدارات .NET المدعومة:](#supported-net-versions)
- [Jwt.NET](#jwtnet)
  - [إنشاء (ترميز) التوكن](#creating-encoding-token)
    - [أو باستخدام واجهة بناء Fluent](#or-using-the-fluent-builder-api)
  - [تحليل (فك ترميز) والتحقق من صحة التوكن](#parsing-decoding-and-verifying-token)
    - [أو باستخدام واجهة بناء Fluent](#or-using-the-fluent-builder-api-1)
    - [أو باستخدام واجهة بناء Fluent](#or-using-the-fluent-builder-api-2)
  - [التحقق من انتهاء صلاحية التوكن](#validate-token-expiration)
  - [تحليل (فك ترميز) رأس التوكن](#parsing-decoding-token-header)
    - [أو باستخدام واجهة بناء Fluent](#or-using-the-fluent-builder-api-3)
  - [إيقاف أجزاء من التحقق من صحة التوكن](#turning-off-parts-of-token-validation)
    - [أو باستخدام واجهة بناء Fluent](#or-using-the-fluent-builder-api-4)
  - [Serializer JSON مخصص](#custom-json-serializer)
  - [إعدادات تسلسل JSON مخصصة مع JsonNetSerializer الافتراضي](#custom-json-serialization-settings-with-the-default-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [تسجيل معالج المصادقة للتحقق من صحة JWT](#register-authentication-handler-to-validate-jwt)
  - [مصانع مخصصة لإنشاء Identity أو AuthenticationTicket](#custom-factories-to-produce-identity-or-authenticationticket)
- [الرخصة](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net، تنفيذ JWT (JSON Web Token) لـ .NET

تدعم هذه المكتبة إنشاء وفك ترميز [JSON Web Tokens](https://tools.ietf.org/html/rfc7519).

## راعي

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | إذا كنت تريد تنفيذ مصادقة آمنة بسرعة لمشروع JWT الخاص بك، [قم بإنشاء حساب Auth0](https://a0.to/try-auth0)؛ إنه مجاني! |

## حزم NuGet المتوفرة

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net لحاوية حقن التبعيات الخاصة بـ Microsoft

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net لـ ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## إصدارات .NET المدعومة:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### إنشاء (ترميز) التوكن

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
const string key = null; // ليس مطلوبًا إذا كان الخوارزمية غير متناظرة

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### أو باستخدام واجهة بناء Fluent

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### تحليل (فك ترميز) والتحقق من صحة التوكن

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
    Console.WriteLine("التوكن غير صالح بعد");
}
catch (TokenExpiredException)
{
    Console.WriteLine("انتهت صلاحية التوكن");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("توقيع التوكن غير صالح");
}
```

#### أو باستخدام واجهة بناء Fluent

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

سيكون الناتج:

>{ "claim1": 0, "claim2": "claim2-value" }

يمكنك أيضًا فك تسلسل حمولة JSON مباشرة إلى نوع .NET:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### أو باستخدام واجهة بناء Fluent

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### التحقق من انتهاء صلاحية التوكن

كما هو موضح في [RFC 7519 القسم 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4):

>معرّف `exp` يشير إلى وقت انتهاء الصلاحية الذي يجب بعده عدم قبول JWT للمعالجة.

إذا كان موجودًا في الحمولة وتجاوز الوقت الحالي، فسيفشل التحقق من التوكن. يجب تحديد القيمة على أنها عدد الثواني منذ [بداية يونكس](https://en.wikipedia.org/wiki/Unix_time)، 1/1/1970 00:00:00 UTC.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // انتهت صلاحية التوكن منذ 5 دقائق

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // يرمي TokenExpiredException
```

ثم، كما هو موضح في [RFC 7519 القسم 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5):

>معرّف "nbf" (ليس قبل) يشير إلى الوقت الذي لا يجب قبول JWT قبله للمعالجة

إذا كان موجودًا في الحمولة وكان قبل الوقت الحالي، فسيفشل التحقق من التوكن.

### تحليل (فك ترميز) رأس التوكن

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### أو باستخدام واجهة بناء Fluent
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### إيقاف أجزاء من تحقق الرمز المميز

إذا كنت ترغب في التحقق من صحة رمز مميز ولكن تجاهل أجزاء معينة من التحقق (مثل ما إذا كان الرمز المميز قد انتهت صلاحيته أو لم يصبح صالحًا بعد)، يمكنك تمرير كائن `ValidateParameters` إلى مُنشئ فئة `JwtValidator`.

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
var json = decoder.Decode(expiredToken); // لن يرمي استثناء بسبب انتهاء صلاحية الرمز
```

#### أو باستخدام واجهة البناء المتسلسلة (Fluent Builder API)

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

### مُسلسل JSON مخصص

بشكل افتراضي، تتم عملية تسلسل JSON بواسطة `JsonNetSerializer` التي تم تنفيذها باستخدام [Json.Net](https://www.json.net). لاستخدام مُسلسل مختلف، قم بتنفيذ واجهة `IJsonSerializer`:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // نفذ باستخدام مُسلسل JSON المفضل لديك
    }

    public T Deserialize<T>(string json)
    {
        // نفذ باستخدام مُسلسل JSON المفضل لديك
    }
}
```

ثم مرر هذا المُسلسل إلى مُنشئ JwtEncoder:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### إعدادات تسلسل JSON مخصصة مع JsonNetSerializer الافتراضي

كما ذكر أعلاه، يتم التسلسل الافتراضي لـ JSON بواسطة `JsonNetSerializer`. يمكنك تعريف إعدادات التسلسل المخصصة الخاصة بك كما يلي:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // جميع المفاتيح تبدأ بحروف صغيرة بدلاً من مطابقة حالة الأحرف في النموذج/الخاصية، مثل fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // تنسيق سهل القراءة، ويمكنك أيضًا استخدام Formatting.None لتقليل حجم الحمولة
    Formatting = Formatting.Indented,
    
    // أنسب تنسيق للتاريخ والوقت.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // لا تضف المفاتيح/القيم عند كون القيمة null.
    NullValueHandling = NullValueHandling.Ignore,
    
    // استخدم القيمة النصية لـ enum، وليس القيمة الرقمية الضمنية، مثل "red" لـ enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### تسجيل معالج المصادقة للتحقق من صحة JWT

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
                     // الأسرار، مطلوبة فقط للخوارزميات المتماثلة، مثل HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // اختياريًا؛ تعطيل رمي الاستثناء إذا كان توقيع JWT غير صالح
                     // options.VerifySignature = false;
                 });
  // النسخة غير العامة AddJwt() تتطلب تسجيل مثيل من IAlgorithmFactory يدويًا
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // أو
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // أو استخدم النسخة العامة AddJwt<TFactory() لاستخدام تنفيذ مخصص لـ IAlgorithmFactory
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### مصانع مخصصة لإنتاج Identity أو AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## الرخصة

المشاريع التالية والحزم الناتجة عنها مرخصة ضمن الملكية العامة، راجع ملف [LICENSE#Public-Domain](LICENSE.md#Public-Domain).

- JWT 

المشاريع التالية والحزم الناتجة عنها مرخصة ضمن رخصة MIT، راجع ملف [LICENSE#MIT](LICENSE.md#MIT).

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---