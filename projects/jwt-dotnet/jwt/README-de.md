<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, eine JWT (JSON Web Token) Implementierung für .NET](#jwtnet-eine-jwt-json-web-token-implementierung-für-net)
- [Sponsor](#sponsor)
- [Verfügbare NuGet-Pakete](#verfügbare-nuget-pakete)
- [Unterstützte .NET-Versionen:](#unterstützte-net-versionen)
- [Jwt.NET](#jwtnet)
  - [Token erstellen (kodieren)](#token-erstellen-kodieren)
    - [Oder mit der Fluent-Builder-API](#oder-mit-der-fluent-builder-api)
  - [Token parsen (dekodieren) und verifizieren](#token-parsen-dekodieren-und-verifizieren)
    - [Oder mit der Fluent-Builder-API](#oder-mit-der-fluent-builder-api-1)
    - [Oder mit der Fluent-Builder-API](#oder-mit-der-fluent-builder-api-2)
  - [Token-Ablauf validieren](#token-ablauf-validieren)
  - [Token-Header parsen (dekodieren)](#token-header-parsen-dekodieren)
    - [Oder mit der Fluent-Builder-API](#oder-mit-der-fluent-builder-api-3)
  - [Teile der Token-Validierung abschalten](#teile-der-token-validierung-abschalten)
    - [Oder mit der Fluent-Builder-API](#oder-mit-der-fluent-builder-api-4)
  - [Benutzerdefinierter JSON-Serializer](#benutzerdefinierter-json-serializer)
  - [Benutzerdefinierte JSON-Serialisierungs-Einstellungen mit dem Standard-JsonNetSerializer](#benutzerdefinierte-json-serialisierungs-einstellungen-mit-dem-standard-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [Authentifizierungs-Handler zur Validierung von JWT registrieren](#authentifizierungs-handler-zur-validierung-von-jwt-registrieren)
  - [Benutzerdefinierte Factory-Methoden zur Erstellung von Identity oder AuthenticationTicket](#benutzerdefinierte-factory-methoden-zur-erstellung-von-identity-oder-authenticationticket)
- [Lizenz](#lizenz)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, eine JWT (JSON Web Token) Implementierung für .NET

Diese Bibliothek unterstützt das Erzeugen und Dekodieren von [JSON Web Tokens](https://tools.ietf.org/html/rfc7519).

## Sponsor

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | Wenn Sie eine sichere Authentifizierung in Ihr JWT-Projekt schnell integrieren möchten, [erstellen Sie ein Auth0-Konto](https://a0.to/try-auth0); es ist kostenlos! |

## Verfügbare NuGet-Pakete

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net für Microsoft Dependency Injection Container

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net für ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Unterstützte .NET-Versionen:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Token erstellen (kodieren)

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
const string key = null; // bei asymmetrischem Algorithmus nicht erforderlich

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### Oder mit der Fluent-Builder-API

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Token parsen (dekodieren) und verifizieren

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
    Console.WriteLine("Token ist noch nicht gültig");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Token ist abgelaufen");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Token hat eine ungültige Signatur");
}
```

#### Oder mit der Fluent-Builder-API

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

Die Ausgabe wäre:

>{ "claim1": 0, "claim2": "claim2-value" }

Sie können das JSON-Payload auch direkt in einen .NET-Typ deserialisieren:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### Oder mit der Fluent-Builder-API

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Token-Ablauf validieren

Wie in [RFC 7519 Abschnitt 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4) beschrieben:

>Der `exp`-Claim gibt die Ablaufzeit an, nach der das JWT NICHT mehr zur Verarbeitung akzeptiert werden DARF.

Wenn dieses Feld im Payload vorhanden ist und in der Vergangenheit liegt, schlägt die Verifikation des Tokens fehl. Der Wert muss als Anzahl der Sekunden seit der [Unix-Epoche](https://de.wikipedia.org/wiki/Unixzeit), 1.1.1970 00:00:00 UTC, angegeben werden.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // Token ist vor 5 Minuten abgelaufen

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // wirft TokenExpiredException
```

Dann, wie in [RFC 7519 Abschnitt 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5) beschrieben:

>Der "nbf" (not before) Claim gibt die Zeit an, vor der das JWT NICHT zur Verarbeitung akzeptiert werden DARF

Wenn dieses Feld im Payload vorhanden ist und in der Zukunft liegt, schlägt die Verifikation des Tokens fehl.

### Token-Header parsen (dekodieren)

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### Oder mit der Fluent-Builder-API
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### Deaktivieren von Teilen der Token-Validierung

Wenn Sie ein Token validieren möchten, aber bestimmte Teile der Validierung ignorieren möchten (z. B. ob das Token abgelaufen ist oder noch nicht gültig ist), können Sie ein `ValidateParameters`-Objekt an den Konstruktor der `JwtValidator`-Klasse übergeben.

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
var json = decoder.Decode(expiredToken); // wirft keine Ausnahme wegen abgelaufenem Token
```

#### Oder mit der Fluent Builder API

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

### Benutzerdefinierter JSON-Serializer

Standardmäßig wird die JSON-Serialisierung durch den JsonNetSerializer durchgeführt, der mit [Json.Net](https://www.json.net) implementiert ist. Um einen anderen zu verwenden, implementieren Sie das `IJsonSerializer`-Interface:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // Implementierung mit bevorzugtem JSON-Serializer
    }

    public T Deserialize<T>(string json)
    {
        // Implementierung mit bevorzugtem JSON-Serializer
    }
}
```

Und geben Sie diesen Serializer dann an den JwtEncoder-Konstruktor weiter:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### Benutzerdefinierte JSON-Serialisierungseinstellungen mit dem Standard-JsonNetSerializer

Wie oben erwähnt, erfolgt die Standard-JSON-Serialisierung durch `JsonNetSerializer`. Sie können eigene Serialisierungseinstellungen wie folgt definieren:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // Alle Schlüssel beginnen mit Kleinbuchstaben anstelle der exakten Groß-/Kleinschreibung des Modells/Eigenschaft, z. B. fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // Schön und leicht lesbar, aber Sie können auch Formatting.None verwenden, um die Payload-Größe zu reduzieren
    Formatting = Formatting.Indented,
    
    // Das passendste Datetime-Format.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // Keine Schlüssel/Werte hinzufügen, wenn der Wert null ist.
    NullValueHandling = NullValueHandling.Ignore,
    
    // Den Enum-String-Wert verwenden, nicht den impliziten int-Wert, z. B. "red" für enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### Authentifizierungs-Handler zur Validierung von JWT registrieren

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
                     // Geheimnisse, nur für symmetrische Algorithmen wie HMACSHA256Algorithm erforderlich
                     // options.Keys = new[] { "mySecret" };
                     
                     // optional; Deaktivieren des Auswerfens einer Ausnahme, wenn die JWT-Signatur ungültig ist
                     // options.VerifySignature = false;
                 });
  // Die nicht-generische Version AddJwt() erfordert die manuelle Registrierung einer Instanz von IAlgorithmFactory
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // oder
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // oder verwenden Sie die generische Version AddJwt<TFactory(), um eine benutzerdefinierte Implementierung von IAlgorithmFactory zu verwenden
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Benutzerdefinierte Factories zur Erzeugung von Identity oder AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## Lizenz

Die folgenden Projekte und deren resultierende Pakete stehen unter Public Domain, siehe die Datei [LICENSE#Public-Domain](LICENSE.md#Public-Domain).

- JWT 

Die folgenden Projekte und deren resultierende Pakete stehen unter der MIT-Lizenz, siehe die Datei [LICENSE#MIT](LICENSE.md#MIT).

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---