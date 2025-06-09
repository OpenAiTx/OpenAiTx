<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, een JWT (JSON Web Token) implementatie voor .NET](#jwtnet-een-jwt-json-web-token-implementatie-voor-net)
- [Sponsor](#sponsor)
- [Beschikbare NuGet-pakketten](#beschikbare-nuget-pakketten)
- [Ondersteunde .NET-versies:](#ondersteunde-net-versies)
- [Jwt.NET](#jwtnet)
  - [Token aanmaken (coderen)](#token-aanmaken-coderen)
    - [Of gebruik de fluent builder API](#of-gebruik-de-fluent-builder-api)
  - [Token ontleden (decoderen) en verifiëren](#token-ontleden-decoderen-en-verifiëren)
    - [Of gebruik de fluent builder API](#of-gebruik-de-fluent-builder-api-1)
    - [Of gebruik de fluent builder API](#of-gebruik-de-fluent-builder-api-2)
  - [Tokenverval valideren](#tokenverval-valideren)
  - [Token header ontleden (decoderen)](#token-header-ontleden-decoderen)
    - [Of gebruik de fluent builder API](#of-gebruik-de-fluent-builder-api-3)
  - [Delen van tokenvalidatie uitschakelen](#delen-van-tokenvalidatie-uitschakelen)
    - [Of gebruik de fluent builder API](#of-gebruik-de-fluent-builder-api-4)
  - [Aangepaste JSON-serializer](#aangepaste-json-serializer)
  - [Aangepaste JSON-serialisatie-instellingen met de standaard JsonNetSerializer](#aangepaste-json-serialisatie-instellingen-met-de-standaard-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [Authenticatiehandler registreren om JWT te valideren](#authenticatiehandler-registreren-om-jwt-te-valideren)
  - [Aangepaste factories voor het produceren van Identity of AuthenticationTicket](#aangepaste-factories-voor-het-produceren-van-identity-of-authenticationticket)
- [Licentie](#licentie)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, een JWT (JSON Web Token) implementatie voor .NET

Deze bibliotheek ondersteunt het genereren en decoderen van [JSON Web Tokens](https://tools.ietf.org/html/rfc7519).

## Sponsor

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | Wil je snel een veilige authenticatie implementeren in je JWT-project? [Maak een Auth0-account aan](https://a0.to/try-auth0); het is gratis! |

## Beschikbare NuGet-pakketten

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net voor Microsoft Dependency Injection container

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net voor ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Ondersteunde .NET-versies:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Token aanmaken (coderen)

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
const string key = null; // niet nodig als het algoritme asymmetrisch is

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### Of gebruik de fluent builder API

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Token ontleden (decoderen) en verifiëren

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
    Console.WriteLine("Token is nog niet geldig");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Token is verlopen");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Token heeft een ongeldige handtekening");
}
```

#### Of gebruik de fluent builder API

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

De uitvoer zal zijn:

>{ "claim1": 0, "claim2": "claim2-value" }

Je kunt de JSON-payload ook direct deserialiseren naar een .NET-type:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### Of gebruik de fluent builder API

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Tokenverval valideren

Zoals beschreven in de [RFC 7519 sectie 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4):

>De `exp` claim identificeert het tijdstip waarop of waarna de JWT NIET meer geaccepteerd mag worden voor verwerking.

Als deze aanwezig is in de payload en de tijd is verstreken, zal de tokenverificatie falen. De waarde moet worden opgegeven als het aantal seconden sinds de [Unix-epoch](https://en.wikipedia.org/wiki/Unix_time), 1/1/1970 00:00:00 UTC.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // token is 5 minuten geleden verlopen

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // gooit TokenExpiredException
```

Zoals vervolgens beschreven in [RFC 7519 sectie 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5):

>De "nbf" (not before) claim identificeert het tijdstip vóór welke de JWT NIET mag worden geaccepteerd voor verwerking

Als deze aanwezig is in de payload en het tijdstip ligt in de toekomst, zal de tokenverificatie falen.

### Token header ontleden (decoderen)

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### Of gebruik de fluent builder API
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### Uitschakelen van delen van tokenvalidatie

Als je een token wilt valideren maar bepaalde onderdelen van de validatie wilt negeren (zoals of het token is verlopen of nog niet geldig is), kun je een `ValidateParameters` object meegeven aan de constructor van de `JwtValidator` klasse.

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
var json = decoder.Decode(expiredToken); // zal geen foutmelding geven vanwege verlopen token
```

#### Of gebruik de fluent builder API

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

### Aangepaste JSON-serializer

Standaard wordt JSON-serialisatie uitgevoerd door JsonNetSerializer, geïmplementeerd met [Json.Net](https://www.json.net). Om een andere te gebruiken, implementeer je de `IJsonSerializer` interface:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // Implementeer met je favoriete JSON-serializer
    }

    public T Deserialize<T>(string json)
    {
        // Implementeer met je favoriete JSON-serializer
    }
}
```

En geef deze serializer door aan de JwtEncoder constructor:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### Aangepaste JSON-serialisatie-instellingen met de standaard JsonNetSerializer

Zoals hierboven vermeld, wordt de standaard JSON-serialisatie gedaan door `JsonNetSerializer`. Je kunt je eigen aangepaste serialisatie-instellingen definiëren als volgt:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // Alle sleutels beginnen met kleine letters in plaats van de exacte casing van het model/eigenschap, bijv. fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // Mooi en makkelijk leesbaar, maar je kunt ook Formatting.None gebruiken om de payload te verkleinen
    Formatting = Formatting.Indented,
    
    // Het meest geschikte datetime-formaat.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // Voeg geen sleutels/waarden toe wanneer de waarde null is.
    NullValueHandling = NullValueHandling.Ignore,
    
    // Gebruik de enum stringwaarde, niet de impliciete int-waarde, bijv. "red" voor enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### Authenticatiehandler registreren om JWT te valideren

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
                     // secrets, alleen vereist voor symmetrische algoritmen, zoals HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // optioneel; schakel het gooien van een exceptie uit als de JWT-handtekening ongeldig is
                     // options.VerifySignature = false;
                 });
  // de niet-generieke versie AddJwt() vereist het handmatig registreren van een instantie van IAlgorithmFactory
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // of
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // of gebruik de generieke versie AddJwt<TFactory() om een aangepaste implementatie van IAlgorithmFactory te gebruiken
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Aangepaste factories om Identity of AuthenticationTicket te produceren

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## Licentie

De volgende projecten en hun resulterende pakketten zijn gelicentieerd onder het Public Domain, zie het [LICENSE#Public-Domain](LICENSE.md#Public-Domain) bestand.

- JWT 

De volgende projecten en hun resulterende pakketten zijn gelicentieerd onder de MIT-licentie, zie het [LICENSE#MIT](LICENSE.md#MIT) bestand.

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---