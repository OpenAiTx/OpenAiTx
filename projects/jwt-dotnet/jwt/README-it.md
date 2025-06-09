<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, una implementazione JWT (JSON Web Token) per .NET](#jwtnet-una-implementazione-jwt-json-web-token-per-net)
- [Sponsor](#sponsor)
- [Pacchetti NuGet disponibili](#pacchetti-nuget-disponibili)
- [Versioni .NET supportate:](#versioni-net-supportate)
- [Jwt.NET](#jwtnet)
  - [Creazione (codifica) di un token](#creazione-codifica-di-un-token)
    - [Oppure usando la Fluent Builder API](#oppure-usando-la-fluent-builder-api)
  - [Parsing (decodifica) e verifica del token](#parsing-decodifica-e-verifica-del-token)
    - [Oppure usando la Fluent Builder API](#oppure-usando-la-fluent-builder-api-1)
    - [Oppure usando la Fluent Builder API](#oppure-usando-la-fluent-builder-api-2)
  - [Validare la scadenza del token](#validare-la-scadenza-del-token)
  - [Parsing (decodifica) dell’header del token](#parsing-decodifica-dellheader-del-token)
    - [Oppure usando la Fluent Builder API](#oppure-usando-la-fluent-builder-api-3)
  - [Disattivare parti della validazione del token](#disattivare-parti-della-validazione-del-token)
    - [Oppure usando la Fluent Builder API](#oppure-usando-la-fluent-builder-api-4)
  - [Serializzatore JSON personalizzato](#serializzatore-json-personalizzato)
  - [Impostazioni di serializzazione JSON personalizzate con il JsonNetSerializer predefinito](#impostazioni-di-serializzazione-json-personalizzate-con-il-jsonnetserializer-predefinito)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [Registrare l’handler di autenticazione per validare i JWT](#registrare-lhandler-di-autenticazione-per-validare-i-jwt)
  - [Factory personalizzate per produrre Identity o AuthenticationTicket](#factory-personalizzate-per-produrre-identity-o-authenticationticket)
- [Licenza](#licenza)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, una implementazione JWT (JSON Web Token) per .NET

Questa libreria supporta la generazione e la decodifica di [JSON Web Token](https://tools.ietf.org/html/rfc7519).

## Sponsor

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | Se vuoi implementare rapidamente un’autenticazione sicura nel tuo progetto JWT, [crea un account Auth0](https://a0.to/try-auth0); è gratuito! |

## Pacchetti NuGet disponibili

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net per il contenitore di Iniezione delle Dipendenze di Microsoft

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net per ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Versioni .NET supportate:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Creazione (codifica) di un token

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
const string key = null; // non necessario se l’algoritmo è asimmetrico

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### Oppure usando la Fluent Builder API

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Parsing (decodifica) e verifica del token

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
    Console.WriteLine("Il token non è ancora valido");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Il token è scaduto");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Il token ha una firma non valida");
}
```

#### Oppure usando la Fluent Builder API

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

L’output sarà:

>{ "claim1": 0, "claim2": "claim2-value" }

Puoi anche deserializzare direttamente il payload JSON in un tipo .NET:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### Oppure usando la Fluent Builder API

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Validare la scadenza del token

Come descritto nella [RFC 7519 sezione 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4):

>La claim `exp` identifica il tempo di scadenza oltre il quale il JWT NON DEVE essere accettato per l’elaborazione.

Se è presente nel payload e supera l’ora corrente, il token non verrà verificato. Il valore deve essere specificato come numero di secondi trascorsi dall’[epoca Unix](https://en.wikipedia.org/wiki/Unix_time), 1/1/1970 00:00:00 UTC.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // il token è scaduto 5 minuti fa

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // genera TokenExpiredException
```

Poi, come descritto nella [RFC 7519 sezione 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5):

>La claim "nbf" (not before) identifica il momento prima del quale il JWT NON DEVE essere accettato per l’elaborazione

Se è presente nel payload ed è successiva all’ora corrente, il token non verrà verificato.

### Parsing (decodifica) dell’header del token

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### Oppure usando la Fluent Builder API
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### Disattivare parti della validazione del token

Se desideri validare un token ma ignorare determinate parti della validazione (ad esempio se il token è scaduto o non ancora valido), puoi passare un oggetto `ValidateParameters` al costruttore della classe `JwtValidator`.

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
var json = decoder.Decode(expiredToken); // non lancerà eccezione a causa del token scaduto
```

#### Oppure utilizzando la Fluent Builder API

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

### Serializer JSON personalizzato

Di default la serializzazione JSON è eseguita da JsonNetSerializer implementato utilizzando [Json.Net](https://www.json.net). Per usarne uno diverso, implementa l’interfaccia `IJsonSerializer`:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // Implementa utilizzando il tuo serializer JSON preferito
    }

    public T Deserialize<T>(string json)
    {
        // Implementa utilizzando il tuo serializer JSON preferito
    }
}
```

E poi passa questo serializer al costruttore di JwtEncoder:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### Impostazioni di serializzazione JSON personalizzate con il JsonNetSerializer predefinito

Come menzionato sopra, la serializzazione JSON predefinita è eseguita da `JsonNetSerializer`. Puoi definire le tue impostazioni di serializzazione personalizzate come segue:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // Tutte le chiavi iniziano con caratteri minuscoli invece che con la stessa capitalizzazione del modello/proprietà, es. fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // Facile da leggere, ma puoi anche usare Formatting.None per ridurre la dimensione del payload
    Formatting = Formatting.Indented,
    
    // Il formato datetime più appropriato.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // Non aggiungere chiavi/valori quando il valore è null.
    NullValueHandling = NullValueHandling.Ignore,
    
    // Usa il valore stringa dell'enum, non il valore int implicito, es. "red" per enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### Registrare l’handler di autenticazione per validare JWT

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
                     // secrets, richiesto solo per algoritmi simmetrici, come HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // opzionale; disabilita il lancio di un'eccezione se la firma JWT non è valida
                     // options.VerifySignature = false;
                 });
  // la versione non generica AddJwt() richiede la registrazione manuale di un’istanza di IAlgorithmFactory
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // oppure
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // oppure usa la versione generica AddJwt<TFactory() per usare un’implementazione personalizzata di IAlgorithmFactory
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Factory personalizzate per produrre Identity o AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## Licenza

I seguenti progetti e i relativi package risultanti sono concessi sotto Public Domain, vedi il file [LICENSE#Public-Domain](LICENSE.md#Public-Domain).

- JWT 

I seguenti progetti e i relativi package risultanti sono concessi sotto licenza MIT, vedi il file [LICENSE#MIT](LICENSE.md#MIT).

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---