<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, .NET için bir JWT (JSON Web Token) uygulaması](#jwtnet-a-jwt-json-web-token-implementation-for-net)
- [Sponsor](#sponsor)
- [Mevcut NuGet paketleri](#avaliable-nuget-packages)
- [Desteklenen .NET sürümleri:](#supported-net-versions)
- [Jwt.NET](#jwtnet)
  - [Token oluşturma (encode etme)](#creating-encoding-token)
    - [Ya da akıcı (fluent) builder API'si kullanılarak](#or-using-the-fluent-builder-api)
  - [Token'ı çözümleme (decode etme) ve doğrulama](#parsing-decoding-and-verifying-token)
    - [Ya da akıcı (fluent) builder API'si kullanılarak](#or-using-the-fluent-builder-api-1)
    - [Ya da akıcı (fluent) builder API'si kullanılarak](#or-using-the-fluent-builder-api-2)
  - [Token süresinin dolduğunu doğrulama](#validate-token-expiration)
  - [Token başlığını çözümleme (decode etme)](#parsing-decoding-token-header)
    - [Ya da akıcı (fluent) builder API'si kullanılarak](#or-using-the-fluent-builder-api-3)
  - [Token doğrulamanın bazı bölümlerini devre dışı bırakma](#turning-off-parts-of-token-validation)
    - [Ya da akıcı (fluent) builder API'si kullanılarak](#or-using-the-fluent-builder-api-4)
  - [Özel JSON serileştirici](#custom-json-serializer)
  - [Varsayılan JsonNetSerializer ile özel JSON serileştirme ayarları](#custom-json-serialization-settings-with-the-default-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [JWT'yi doğrulamak için kimlik doğrulama işleyicisi kaydetme](#register-authentication-handler-to-validate-jwt)
  - [Identity veya AuthenticationTicket üretmek için özel fabrikalar](#custom-factories-to-produce-identity-or-authenticationticket)
- [Lisans](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, .NET için bir JWT (JSON Web Token) uygulaması

Bu kütüphane [JSON Web Token](https://tools.ietf.org/html/rfc7519) oluşturmayı ve çözümlemeyi destekler.

## Sponsor

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | JWT projenize hızlıca güvenli bir kimlik doğrulama eklemek istiyorsanız, [bir Auth0 hesabı oluşturun](https://a0.to/try-auth0); Ücretsiz! |

## Mevcut NuGet paketleri

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Microsoft Dependency Injection container için Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. ASP.NET Core için Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Desteklenen .NET sürümleri:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Token oluşturma (encode etme)

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
const string key = null; // asimetrik algoritma ise gerek yok

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### Ya da akıcı (fluent) builder API'si kullanılarak

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Token'ı çözümleme (decode etme) ve doğrulama

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
    Console.WriteLine("Token henüz geçerli değil");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Token'ın süresi dolmuş");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Token'ın imzası geçersiz");
}
```

#### Ya da akıcı (fluent) builder API'si kullanılarak

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

Çıktı şöyle olur:

>{ "claim1": 0, "claim2": "claim2-value" }

JSON yükünü doğrudan bir .NET türüne de serileştirebilirsiniz:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### Ya da akıcı (fluent) builder API'si kullanılarak

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Token süresinin dolduğunu doğrulama

[RFC 7519 bölüm 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4)'te açıklandığı gibi:

>`exp` iddiası, JWT'nin işlenmek üzere kabul edilmemesi gereken veya sonrasındaki zamanı belirtir.

Eğer payload içinde varsa ve mevcut zamanın geçmişindeyse, token doğrulamadan geçemez. Değer [Unix epoch](https://en.wikipedia.org/wiki/Unix_time), 1/1/1970 00:00:00 UTC'den itibaren geçen saniye sayısı olarak belirtilmelidir.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // token 5 dakika önce süresi dolmuş

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // TokenExpiredException fırlatır
```

Daha sonra, [RFC 7519 bölüm 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5)'te açıklandığı gibi:

>`nbf` (not before) iddiası, JWT'nin işlenmek üzere kabul edilmemesi gereken zamandan öncesini belirtir.

Eğer payload içinde varsa ve mevcut zamanın öncesindeyse, token doğrulamadan geçemez.

### Token başlığını çözümleme (decode etme)

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### Ya da akıcı (fluent) builder API'si kullanılarak
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### Jeton doğrulamanın bazı bölümlerini kapatma

Bir jetonu doğrulamak, ancak doğrulamanın bazı bölümlerini (örneğin jetonun süresinin dolup dolmadığı veya henüz geçerli olup olmadığı) dikkate almak istemiyorsanız, `JwtValidator` sınıfının yapıcısına bir `ValidateParameters` nesnesi gönderebilirsiniz.

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
var json = decoder.Decode(expiredToken); // süresi dolmuş jeton nedeniyle hata fırlatmaz
```

#### Veya fluent builder API kullanarak

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

### Özel JSON serileştirici

Varsayılan olarak JSON serileştirme, [Json.Net](https://www.json.net) kullanılarak gerçekleştirilen JsonNetSerializer tarafından yapılır. Farklı bir serileştirici kullanmak için `IJsonSerializer` arayüzünü uygulayın:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // Favori JSON serileştiricinizi kullanarak uygulayın
    }

    public T Deserialize<T>(string json)
    {
        // Favori JSON serileştiricinizi kullanarak uygulayın
    }
}
```

Ve ardından bu serileştiriciyi JwtEncoder yapıcısına iletin:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### Varsayılan JsonNetSerializer ile özel JSON serileştirme ayarları

Yukarıda belirtildiği gibi, varsayılan JSON serileştirme `JsonNetSerializer` tarafından yapılır. Kendi özel serileştirme ayarlarınızı aşağıdaki şekilde tanımlayabilirsiniz:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // Tüm anahtarlar model/özellikteki tam büyük/küçük harf yapısı yerine küçük harfle başlar, örn. fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // Kolay okunur, ancak yük boyutunu azaltmak için Formatting.None da kullanabilirsiniz
    Formatting = Formatting.Indented,
    
    // En uygun datetime formatı.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // Değer null olduğunda anahtar/değer ekleme.
    NullValueHandling = NullValueHandling.Ignore,
    
    // enum için int değer yerine string değerini kullan, örn. "red" için enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### JWT'yi doğrulamak için kimlik doğrulama işleyicisini kaydetme

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
                     // gizli anahtarlar, yalnızca HMACSHA256Algorithm gibi simetrik algoritmalar için gereklidir
                     // options.Keys = new[] { "mySecret" };
                     
                     // isteğe bağlı; JWT imzası geçersizse istisna fırlatmayı devre dışı bırak
                     // options.VerifySignature = false;
                 });
  // generic olmayan AddJwt() sürümü, IAlgorithmFactory örneğinin manuel olarak kaydedilmesini gerektirir
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // veya
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // veya özel bir IAlgorithmFactory uygulaması kullanmak için generic sürüm AddJwt<TFactory() kullanılabilir
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Identity veya AuthenticationTicket üretmek için özel fabrikalar

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## Lisans

Aşağıdaki projeler ve bunlardan türeyen paketler Kamu Malı lisansı altındadır, ayrıntılar için [LICENSE#Public-Domain](LICENSE.md#Public-Domain) dosyasına bakınız.

- JWT 

Aşağıdaki projeler ve bunlardan türeyen paketler MIT Lisansı altındadır, ayrıntılar için [LICENSE#MIT](LICENSE.md#MIT) dosyasına bakınız.

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---