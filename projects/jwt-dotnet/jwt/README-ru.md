<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, реализация JWT (JSON Web Token) для .NET](#jwtnet-a-jwt-json-web-token-implementation-for-net)
- [Спонсор](#sponsor)
- [Доступные NuGet-пакеты](#avaliable-nuget-packages)
- [Поддерживаемые версии .NET:](#supported-net-versions)
- [Jwt.NET](#jwtnet)
  - [Создание (кодирование) токена](#creating-encoding-token)
    - [Или с помощью fluent builder API](#or-using-the-fluent-builder-api)
  - [Парсинг (декодирование) и проверка токена](#parsing-decoding-and-verifying-token)
    - [Или с помощью fluent builder API](#or-using-the-fluent-builder-api-1)
    - [Или с помощью fluent builder API](#or-using-the-fluent-builder-api-2)
  - [Проверка срока действия токена](#validate-token-expiration)
  - [Парсинг (декодирование) заголовка токена](#parsing-decoding-token-header)
    - [Или с помощью fluent builder API](#or-using-the-fluent-builder-api-3)
  - [Отключение части проверки токена](#turning-off-parts-of-token-validation)
    - [Или с помощью fluent builder API](#or-using-the-fluent-builder-api-4)
  - [Пользовательский JSON-сериализатор](#custom-json-serializer)
  - [Пользовательские настройки сериализации JSON с использованием стандартного JsonNetSerializer](#custom-json-serialization-settings-with-the-default-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [Регистрация обработчика аутентификации для проверки JWT](#register-authentication-handler-to-validate-jwt)
  - [Пользовательские фабрики для создания Identity или AuthenticationTicket](#custom-factories-to-produce-identity-or-authenticationticket)
- [Лицензия](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, реализация JWT (JSON Web Token) для .NET

Эта библиотека поддерживает генерацию и декодирование [JSON Web Tokens](https://tools.ietf.org/html/rfc7519).

## Спонсор

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | Если вы хотите быстро внедрить безопасную аутентификацию в свой проект с JWT, [создайте аккаунт в Auth0](https://a0.to/try-auth0); это бесплатно! |

## Доступные NuGet-пакеты

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net для контейнера внедрения зависимостей Microsoft

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net для ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Поддерживаемые версии .NET:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Создание (кодирование) токена

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
const string key = null; // не требуется, если используется асимметричный алгоритм

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### Или с помощью fluent builder API

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Парсинг (декодирование) и проверка токена

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

#### Или с помощью fluent builder API

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

Результат будет:

>{ "claim1": 0, "claim2": "claim2-value" }

Вы также можете десериализовать JSON-полезную нагрузку напрямую в тип .NET:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### Или с помощью fluent builder API

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Проверка срока действия токена

Как указано в [RFC 7519, раздел 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4):

>Поле `exp` определяет момент времени, после которого JWT НЕ ДОЛЖЕН приниматься для обработки.

Если это поле присутствует в полезной нагрузке и его значение меньше текущего времени, токен не пройдет проверку. Значение должно быть указано как количество секунд с [эпохи Unix](https://en.wikipedia.org/wiki/Unix_time), 1/1/1970 00:00:00 UTC.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // токен истек 5 минут назад

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // выбрасывает TokenExpiredException
```

Далее, как указано в [RFC 7519, раздел 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5):

>Поле "nbf" (not before) определяет момент времени, до которого JWT НЕ ДОЛЖЕН приниматься для обработки

Если это поле присутствует в полезной нагрузке и его значение больше текущего времени, токен не пройдет проверку.

### Парсинг (декодирование) заголовка токена

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### Или с помощью fluent builder API
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### Отключение частей валидации токена

Если вы хотите валидировать токен, но игнорировать некоторые части валидации (например, истёк ли срок действия токена или ещё не наступил), вы можете передать объект `ValidateParameters` в конструктор класса `JwtValidator`.

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
var json = decoder.Decode(expiredToken); // не выбросит исключение из-за истёкшего токена
```

#### Или используя fluent builder API

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

### Пользовательский JSON-сериализатор

По умолчанию сериализация JSON выполняется с помощью JsonNetSerializer, реализованного с использованием [Json.Net](https://www.json.net). Чтобы использовать другой сериализатор, реализуйте интерфейс `IJsonSerializer`:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // Реализуйте с использованием любимого JSON-сериализатора
    }

    public T Deserialize<T>(string json)
    {
        // Реализуйте с использованием любимого JSON-сериализатора
    }
}
```

Затем передайте этот сериализатор в конструктор JwtEncoder:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### Пользовательские настройки сериализации JSON с использованием стандартного JsonNetSerializer

Как упоминалось выше, сериализация JSON по умолчанию выполняется с помощью `JsonNetSerializer`. Вы можете определить свои собственные настройки сериализации следующим образом:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // Все ключи начинаются с маленькой буквы вместо использования регистра модели/свойства, например, fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // Красиво и удобно для чтения, но вы также можете использовать Formatting.None для уменьшения размера данных
    Formatting = Formatting.Indented,
    
    // Наиболее подходящий формат даты и времени.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // Не добавлять ключи/значения, если значение равно null.
    NullValueHandling = NullValueHandling.Ignore,
    
    // Использовать строковое значение enum, а не неявное int-значение, например, "red" для enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### Регистрируем обработчик аутентификации для проверки JWT

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
                     // секреты, требуются только для симметричных алгоритмов, например, HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // необязательно; отключает выброс исключения при недействительной подписи JWT
                     // options.VerifySignature = false;
                 });
  // не-генерик версия AddJwt() требует ручной регистрации экземпляра IAlgorithmFactory
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // или
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // или используйте генерик-версию AddJwt<TFactory() для использования собственной реализации IAlgorithmFactory
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Пользовательские фабрики для создания Identity или AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## Лицензия

Следующие проекты и полученные из них пакеты лицензированы как Public Domain, см. файл [LICENSE#Public-Domain](LICENSE.md#Public-Domain).

- JWT 

Следующие проекты и полученные из них пакеты лицензированы под лицензией MIT, см. файл [LICENSE#MIT](LICENSE.md#MIT).

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---