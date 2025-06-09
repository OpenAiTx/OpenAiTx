<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net، یک پیاده‌سازی JWT (JSON Web Token) برای دات‌نت](#jwtnet-a-jwt-json-web-token-implementation-for-net)
- [حامی مالی](#sponsor)
- [پکیج‌های قابل دسترس در NuGet](#avaliable-nuget-packages)
- [نسخه‌های پشتیبانی شده دات‌نت:](#supported-net-versions)
- [Jwt.NET](#jwtnet)
  - [ایجاد (کدگذاری) توکن](#creating-encoding-token)
    - [یا استفاده از API سازنده Fluent](#or-using-the-fluent-builder-api)
  - [تجزیه (دیکد) و اعتبارسنجی توکن](#parsing-decoding-and-verifying-token)
    - [یا استفاده از API سازنده Fluent](#or-using-the-fluent-builder-api-1)
    - [یا استفاده از API سازنده Fluent](#or-using-the-fluent-builder-api-2)
  - [اعتبارسنجی انقضای توکن](#validate-token-expiration)
  - [تجزیه (دیکد) هدر توکن](#parsing-decoding-token-header)
    - [یا استفاده از API سازنده Fluent](#or-using-the-fluent-builder-api-3)
  - [غیرفعال کردن بخش‌هایی از اعتبارسنجی توکن](#turning-off-parts-of-token-validation)
    - [یا استفاده از API سازنده Fluent](#or-using-the-fluent-builder-api-4)
  - [سریالایزر سفارشی JSON](#custom-json-serializer)
  - [تنظیمات سفارشی سریال‌سازی JSON با سریالایزر پیش‌فرض JsonNetSerializer](#custom-json-serialization-settings-with-the-default-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [ثبت هندلر احراز هویت برای اعتبارسنجی JWT](#register-authentication-handler-to-validate-jwt)
  - [کارخانه‌های سفارشی برای تولید Identity یا AuthenticationTicket](#custom-factories-to-produce-identity-or-authenticationticket)
- [مجوز](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![وضعیت ساخت](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![وضعیت انتشار](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net، یک پیاده‌سازی JWT (JSON Web Token) برای دات‌نت

این کتابخانه از تولید و دیکد کردن [JSON Web Tokens](https://tools.ietf.org/html/rfc7519) پشتیبانی می‌کند.

## حامی مالی

| | |
|-|-|
| [<img alt="لوگوی Auth0" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | اگر می‌خواهید سریعاً یک احراز هویت امن به پروژه JWT خود اضافه کنید، [یک حساب Auth0 بسازید](https://a0.to/try-auth0)؛ رایگان است! |

## پکیج‌های قابل دسترس در NuGet

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net برای Microsoft Dependency Injection container

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net برای ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## نسخه‌های پشتیبانی شده دات‌نت:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### ایجاد (کدگذاری) توکن

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
const string key = null; // در الگوریتم‌های نامتقارن نیاز نیست

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### یا استفاده از API سازنده Fluent

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### تجزیه (دیکد) و اعتبارسنجی توکن

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
    Console.WriteLine("توکن هنوز معتبر نیست");
}
catch (TokenExpiredException)
{
    Console.WriteLine("توکن منقضی شده است");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("امضای توکن نامعتبر است");
}
```

#### یا استفاده از API سازنده Fluent

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

خروجی به شکل زیر خواهد بود:

>{ "claim1": 0, "claim2": "claim2-value" }

همچنین می‌توانید payload را مستقیماً به یک نوع دات‌نت deserialize کنید:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### یا استفاده از API سازنده Fluent

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### اعتبارسنجی انقضای توکن

مطابق با [RFC 7519 بخش 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4):

>`exp` نشان‌دهنده زمان انقضایی است که بعد از آن JWT نباید برای پردازش پذیرفته شود.

اگر این claim در payload باشد و زمان فعلی از مقدار آن گذشته باشد، توکن تأیید نخواهد شد. مقدار باید به صورت تعداد ثانیه‌های گذشته از [یونیکس اپوک](https://en.wikipedia.org/wiki/Unix_time) (1/1/1970 00:00:00 UTC) مشخص شود.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // توکن ۵ دقیقه قبل منقضی شده است

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // منجر به TokenExpiredException می‌شود
```

سپس، مطابق با [RFC 7519 بخش 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5):

>claim "nbf" (not before) زمان قبل از پذیرش JWT برای پردازش را تعیین می‌کند

اگر این claim در payload باشد و زمان فعلی قبل از مقدار آن باشد، توکن تأیید نخواهد شد.

### تجزیه (دیکد) هدر توکن

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### یا استفاده از API سازنده Fluent

```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### غیرفعال کردن بخش‌هایی از اعتبارسنجی توکن

اگر می‌خواهید یک توکن را اعتبارسنجی کنید اما برخی بخش‌های اعتبارسنجی (مانند این که آیا توکن منقضی شده یا هنوز معتبر نیست) را نادیده بگیرید، می‌توانید یک شیء `ValidateParameters` را به سازنده کلاس `JwtValidator` ارسال کنید.

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
var json = decoder.Decode(expiredToken); // به خاطر انقضای توکن خطا نخواهد داد
```

#### یا با استفاده از Fluent Builder API

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

### سریالایزر JSON سفارشی

به طور پیش‌فرض، سریال‌سازی JSON توسط JsonNetSerializer که با استفاده از [Json.Net](https://www.json.net) پیاده‌سازی شده است، انجام می‌شود. برای استفاده از سریالایزر دیگر، کافیست رابط `IJsonSerializer` را پیاده‌سازی کنید:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // پیاده‌سازی با استفاده از سریالایزر JSON مورد علاقه شما
    }

    public T Deserialize<T>(string json)
    {
        // پیاده‌سازی با استفاده از سریالایزر JSON مورد علاقه شما
    }
}
```

سپس این سریالایزر را به سازنده JwtEncoder ارسال کنید:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### تنظیمات سفارشی سریال‌سازی JSON با JsonNetSerializer پیش‌فرض

همان‌طور که ذکر شد، سریال‌سازی پیش‌فرض JSON توسط `JsonNetSerializer` انجام می‌شود. می‌توانید تنظیمات سفارشی سریال‌سازی خود را به صورت زیر تعریف کنید:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // همه کلیدها با حروف کوچک شروع می‌شوند به جای این که دقیقا از حالت مدل/ویژگی پیروی کنند، مثلا fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // فرمت خوانا و آسان برای خواندن، اما می‌توانید از Formatting.None برای کاهش حجم داده ارسالی استفاده کنید
    Formatting = Formatting.Indented,
    
    // مناسب‌ترین فرمت datetime.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // در صورتی که مقدار null باشد، کلید/مقدار اضافه نشود.
    NullValueHandling = NullValueHandling.Ignore,
    
    // استفاده از مقدار رشته‌ای enum به جای مقدار int ضمنی، مثلا "red" برای enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net در ASP.NET Core

### ثبت handler احراز هویت برای اعتبارسنجی JWT

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
                     // کلیدها، فقط برای الگوریتم‌های متقارن مانند HMACSHA256Algorithm نیاز است
                     // options.Keys = new[] { "mySecret" };
                     
                     // اختیاری؛ غیرفعال کردن پرتاب استثنا اگر امضای JWT نامعتبر باشد
                     // options.VerifySignature = false;
                 });
  // نسخه غیر generic متد AddJwt() نیاز به ثبت دستی یک نمونه IAlgorithmFactory دارد
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // یا
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // یا از نسخه generic متد AddJwt<TFactory() برای استفاده از پیاده‌سازی سفارشی IAlgorithmFactory استفاده کنید
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### کارخانه‌های سفارشی برای تولید Identity یا AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## مجوز

پروژه‌های زیر و بسته‌های حاصل از آن‌ها تحت مجوز Public Domain منتشر شده‌اند. فایل [LICENSE#Public-Domain](LICENSE.md#Public-Domain) را ببینید.

- JWT 

پروژه‌های زیر و بسته‌های حاصل از آن‌ها تحت مجوز MIT منتشر شده‌اند. فایل [LICENSE#MIT](LICENSE.md#MIT) را ببینید.

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---