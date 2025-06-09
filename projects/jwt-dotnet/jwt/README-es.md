<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, una implementación de JWT (JSON Web Token) para .NET](#jwtnet-una-implementación-de-jwt-json-web-token-para-net)
- [Patrocinador](#patrocinador)
- [Paquetes NuGet disponibles](#paquetes-nuget-disponibles)
- [Versiones de .NET soportadas:](#versiones-de-net-soportadas)
- [Jwt.NET](#jwtnet)
  - [Creación (codificación) de tokens](#creación-codificación-de-tokens)
    - [O usando la API de construcción fluida (fluent builder API)](#o-usando-la-api-de-construcción-fluida-fluent-builder-api)
  - [Análisis (decodificación) y verificación de tokens](#análisis-decodificación-y-verificación-de-tokens)
    - [O usando la API de construcción fluida (fluent builder API)](#o-usando-la-api-de-construcción-fluida-fluent-builder-api-1)
    - [O usando la API de construcción fluida (fluent builder API)](#o-usando-la-api-de-construcción-fluida-fluent-builder-api-2)
  - [Validar la expiración del token](#validar-la-expiración-del-token)
  - [Análisis (decodificación) del encabezado del token](#análisis-decodificación-del-encabezado-del-token)
    - [O usando la API de construcción fluida (fluent builder API)](#o-usando-la-api-de-construcción-fluida-fluent-builder-api-3)
  - [Desactivar partes de la validación del token](#desactivar-partes-de-la-validación-del-token)
    - [O usando la API de construcción fluida (fluent builder API)](#o-usando-la-api-de-construcción-fluida-fluent-builder-api-4)
  - [Serializador JSON personalizado](#serializador-json-personalizado)
  - [Configuración personalizada de serialización JSON con el JsonNetSerializer por defecto](#configuración-personalizada-de-serialización-json-con-el-jsonnetserializer-por-defecto)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [Registrar el manejador de autenticación para validar JWT](#registrar-el-manejador-de-autenticación-para-validar-jwt)
  - [Fábricas personalizadas para producir Identity o AuthenticationTicket](#fábricas-personalizadas-para-producir-identity-o-authenticationticket)
- [Licencia](#licencia)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, una implementación de JWT (JSON Web Token) para .NET

Esta biblioteca soporta la generación y decodificación de [JSON Web Tokens](https://tools.ietf.org/html/rfc7519).

## Patrocinador

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | Si quieres implementar rápidamente una autenticación segura en tu proyecto JWT, [crea una cuenta en Auth0](https://a0.to/try-auth0); ¡es gratis! |

## Paquetes NuGet disponibles

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net para el contenedor de Inyección de Dependencias de Microsoft

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net para ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Versiones de .NET soportadas:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Creación (codificación) de tokens

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
const string key = null; // no es necesario si el algoritmo es asimétrico

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### O usando la API de construcción fluida (fluent builder API)

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Análisis (decodificación) y verificación de tokens

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
    Console.WriteLine("El token aún no es válido");
}
catch (TokenExpiredException)
{
    Console.WriteLine("El token ha expirado");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("El token tiene una firma no válida");
}
```

#### O usando la API de construcción fluida (fluent builder API)

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

La salida sería:

>{ "claim1": 0, "claim2": "claim2-value" }

También puedes deserializar el payload JSON directamente a un tipo .NET:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### O usando la API de construcción fluida (fluent builder API)

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Validar la expiración del token

Como se describe en la [RFC 7519 sección 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4):

>El parámetro `exp` identifica el instante de expiración a partir del cual el JWT NO DEBE ser aceptado para su procesamiento.

Si está presente en el payload y está en el pasado respecto al tiempo actual, el token fallará la verificación. El valor debe especificarse como el número de segundos desde la [época Unix](https://es.wikipedia.org/wiki/Tiempo_Unix), 1/1/1970 00:00:00 UTC.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // el token expiró hace 5 minutos

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // lanza TokenExpiredException
```

Luego, como se describe en la [RFC 7519 sección 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5):

>El parámetro "nbf" (not before/no antes de) identifica el momento antes del cual el JWT NO DEBE ser aceptado para su procesamiento

Si está presente en el payload y es anterior al tiempo actual, el token fallará la verificación.

### Análisis (decodificación) del encabezado del token

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### O usando la API de construcción fluida (fluent builder API)

```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### Desactivar partes de la validación del token

Si deseas validar un token pero ignorar ciertas partes de la validación (como si el token ha expirado o aún no es válido), puedes pasar un objeto `ValidateParameters` al constructor de la clase `JwtValidator`.

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
var json = decoder.Decode(expiredToken); // no lanzará excepción por token expirado
```

#### O usando la API fluent builder

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

### Serializador JSON personalizado

Por defecto, la serialización JSON se realiza mediante JsonNetSerializer implementado usando [Json.Net](https://www.json.net). Para usar uno diferente, implementa la interfaz `IJsonSerializer`:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // Implementar usando tu serializador JSON favorito
    }

    public T Deserialize<T>(string json)
    {
        // Implementar usando tu serializador JSON favorito
    }
}
```

Y luego pasa este serializador al constructor de JwtEncoder:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### Configuración personalizada de serialización JSON con el JsonNetSerializer por defecto

Como se mencionó anteriormente, la serialización JSON por defecto se realiza con `JsonNetSerializer`. Puedes definir tu propia configuración de serialización personalizada de la siguiente manera:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // Todas las claves empiezan con minúscula en lugar del casing exacto del modelo/propiedad, por ejemplo fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // Legible y fácil de leer, pero también puedes usar Formatting.None para reducir el tamaño del payload
    Formatting = Formatting.Indented,
    
    // El formato de fecha y hora más apropiado.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // No agregar claves/valores cuando el valor sea null.
    NullValueHandling = NullValueHandling.Ignore,
    
    // Usar el valor string del enum, no el valor int implícito, por ejemplo "red" para enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### Registrar el manejador de autenticación para validar JWT

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
                     // secretos, requerido solo para algoritmos simétricos, como HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // opcionalmente; deshabilitar lanzar una excepción si la firma JWT es inválida
                     // options.VerifySignature = false;
                 });
  // la versión no genérica AddJwt() requiere registrar manualmente una instancia de IAlgorithmFactory
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // o
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // o usa la versión genérica AddJwt<TFactory() para usar una implementación personalizada de IAlgorithmFactory
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Fábricas personalizadas para producir Identity o AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## Licencia

Los siguientes proyectos y sus paquetes resultantes están licenciados bajo Dominio Público, ver el archivo [LICENSE#Public-Domain](LICENSE.md#Public-Domain).

- JWT 

Los siguientes proyectos y sus paquetes resultantes están licenciados bajo la Licencia MIT, ver el archivo [LICENSE#MIT](LICENSE.md#MIT).

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---