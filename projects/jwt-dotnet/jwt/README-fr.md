<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, une implémentation JWT (JSON Web Token) pour .NET](#jwtnet-une-implémentation-jwt-json-web-token-pour-net)
- [Sponsor](#sponsor)
- [Packages NuGet disponibles](#packages-nuget-disponibles)
- [Versions .NET supportées :](#versions-net-supportées)
- [Jwt.NET](#jwtnet)
  - [Création (encodage) d’un jeton](#création-encodage-dun-jeton)
    - [Ou en utilisant l’API fluide builder](#ou-en-utilisant-lapi-fluide-builder)
  - [Analyse (décodage) et vérification du jeton](#analyse-décodage-et-vérification-du-jeton)
    - [Ou en utilisant l’API fluide builder](#ou-en-utilisant-lapi-fluide-builder-1)
    - [Ou en utilisant l’API fluide builder](#ou-en-utilisant-lapi-fluide-builder-2)
  - [Validation de l’expiration du jeton](#validation-de-lexpiration-du-jeton)
  - [Analyse (décodage) de l’en-tête du jeton](#analyse-décodage-de-len-tête-du-jeton)
    - [Ou en utilisant l’API fluide builder](#ou-en-utilisant-lapi-fluide-builder-3)
  - [Désactivation de parties de la validation du jeton](#désactivation-de-parties-de-la-validation-du-jeton)
    - [Ou en utilisant l’API fluide builder](#ou-en-utilisant-lapi-fluide-builder-4)
  - [Sérialiseur JSON personnalisé](#sérialiseur-json-personnalisé)
  - [Paramètres de sérialisation JSON personnalisés avec le JsonNetSerializer par défaut](#paramètres-de-sérialisation-json-personnalisés-avec-le-jsonnetserializer-par-défaut)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [Enregistrer un gestionnaire d’authentification pour valider le JWT](#enregistrer-un-gestionnaire-dauthentification-pour-valider-le-jwt)
  - [Fabriques personnalisées pour produire Identity ou AuthenticationTicket](#fabriques-personnalisées-pour-produire-identity-ou-authenticationticket)
- [Licence](#licence)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, une implémentation JWT (JSON Web Token) pour .NET

Cette bibliothèque permet de générer et de décoder des [JSON Web Tokens](https://tools.ietf.org/html/rfc7519).

## Sponsor

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | Si vous souhaitez implémenter rapidement une authentification sécurisée à votre projet JWT, [créez un compte Auth0](https://a0.to/try-auth0) ; c’est gratuit ! |

## Packages NuGet disponibles

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net pour le conteneur d’injection de dépendances Microsoft

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net pour ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Versions .NET supportées :

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Création (encodage) d’un jeton

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
const string key = null; // non nécessaire si l’algorithme est asymétrique

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### Ou en utilisant l’API fluide builder

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Analyse (décodage) et vérification du jeton

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
    Console.WriteLine("Le jeton n’est pas encore valide");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Le jeton a expiré");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Le jeton a une signature invalide");
}
```

#### Ou en utilisant l’API fluide builder

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

Le résultat serait :

>{ "claim1": 0, "claim2": "claim2-value" }

Vous pouvez aussi désérialiser directement la charge utile JSON dans un type .NET :

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### Ou en utilisant l’API fluide builder

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Validation de l’expiration du jeton

Comme décrit dans la [RFC 7519 section 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4) :

>La revendication `exp` identifie l’heure d’expiration à partir de laquelle le JWT NE DOIT PLUS être accepté pour traitement.

Si elle est présente dans la charge utile et qu’elle est antérieure à l’heure actuelle, le jeton échouera à la vérification. La valeur doit être spécifiée comme le nombre de secondes depuis l’[époque Unix](https://en.wikipedia.org/wiki/Unix_time), 01/01/1970 00:00:00 UTC.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // le jeton a expiré il y a 5 minutes

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // déclenche TokenExpiredException
```

Puis, comme décrit dans la [RFC 7519 section 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5) :

>La revendication "nbf" (not before) identifie l’heure avant laquelle le JWT NE DOIT PAS être accepté pour traitement.

Si elle est présente dans la charge utile et qu’elle est postérieure à l’heure actuelle, le jeton échouera à la vérification.

### Analyse (décodage) de l’en-tête du jeton

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### Ou en utilisant l’API fluide builder
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### Désactivation de certaines parties de la validation du jeton

Si vous souhaitez valider un jeton mais ignorer certaines parties de la validation (par exemple, vérifier si le jeton a expiré ou n'est pas encore valide), vous pouvez passer un objet `ValidateParameters` au constructeur de la classe `JwtValidator`.

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
var json = decoder.Decode(expiredToken); // ne lèvera pas d’exception à cause d’un jeton expiré
```

#### Ou en utilisant l’API fluide du builder

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

### Sérialiseur JSON personnalisé

Par défaut, la sérialisation JSON est effectuée par `JsonNetSerializer` implémenté avec [Json.Net](https://www.json.net). Pour en utiliser un autre, implémentez l’interface `IJsonSerializer` :

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // Implémenter en utilisant votre sérialiseur JSON préféré
    }

    public T Deserialize<T>(string json)
    {
        // Implémenter en utilisant votre sérialiseur JSON préféré
    }
}
```

Puis passez ce sérialiseur au constructeur de JwtEncoder :

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### Paramètres de sérialisation JSON personnalisés avec le JsonNetSerializer par défaut

Comme mentionné ci-dessus, la sérialisation JSON par défaut est réalisée par `JsonNetSerializer`. Vous pouvez définir vos propres paramètres de sérialisation personnalisés comme suit :

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // Toutes les clés commencent par une minuscule au lieu de respecter la casse exacte du modèle/propriété, ex : fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // Facile à lire, mais vous pouvez aussi utiliser Formatting.None pour réduire la taille de la charge utile
    Formatting = Formatting.Indented,
    
    // Le format de date/heure le plus approprié.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // Ne pas ajouter les clés/valeurs si la valeur est null.
    NullValueHandling = NullValueHandling.Ignore,
    
    // Utiliser la valeur chaîne de l’énum, pas la valeur int implicite, ex : "red" pour enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### Enregistrement du gestionnaire d’authentification pour valider les JWT

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
                     // secrets, requis uniquement pour les algorithmes symétriques, tels que HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // optionnellement ; désactiver le lancement d'une exception si la signature du JWT est invalide
                     // options.VerifySignature = false;
                 });
  // la version non générique AddJwt() nécessite d’enregistrer manuellement une instance de IAlgorithmFactory
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // ou
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // ou utilisez la version générique AddJwt<TFactory() pour une implémentation personnalisée de IAlgorithmFactory
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Usines personnalisées pour produire Identity ou AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## Licence

Les projets suivants et leurs packages résultants sont publiés sous licence Domaine Public, voir le fichier [LICENSE#Public-Domain](LICENSE.md#Public-Domain).

- JWT 

Les projets suivants et leurs packages résultants sont publiés sous licence MIT, voir le fichier [LICENSE#MIT](LICENSE.md#MIT).

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---