<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, implementacja JWT (JSON Web Token) dla .NET](#jwtnet-implementacja-jwt-json-web-token-dla-net)
- [Sponsor](#sponsor)
- [Dostępne pakiety NuGet](#dostępne-pakiety-nuget)
- [Obsługiwane wersje .NET:](#obsługiwane-wersje-net)
- [Jwt.NET](#jwtnet)
  - [Tworzenie (kodowanie) tokena](#tworzenie-kodowanie-tokena)
    - [Lub z użyciem płynnego API buildera](#lub-z-użyciem-płynnego-api-buildera)
  - [Parsowanie (dekodowanie) i weryfikacja tokena](#parsowanie-dekodowanie-i-weryfikacja-tokena)
    - [Lub z użyciem płynnego API buildera](#lub-z-użyciem-płynnego-api-buildera-1)
    - [Lub z użyciem płynnego API buildera](#lub-z-użyciem-płynnego-api-buildera-2)
  - [Weryfikacja wygaśnięcia tokena](#weryfikacja-wygaśnięcia-tokena)
  - [Parsowanie (dekodowanie) nagłówka tokena](#parsowanie-dekodowanie-nagłówka-tokena)
    - [Lub z użyciem płynnego API buildera](#lub-z-użyciem-płynnego-api-buildera-3)
  - [Wyłączanie części walidacji tokena](#wyłączanie-części-walidacji-tokena)
    - [Lub z użyciem płynnego API buildera](#lub-z-użyciem-płynnego-api-buildera-4)
  - [Własny serializer JSON](#własny-serializer-json)
  - [Własne ustawienia serializacji JSON z domyślnym JsonNetSerializer](#własne-ustawienia-serializacji-json-z-domyślnym-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [Rejestracja handlera uwierzytelniania do walidacji JWT](#rejestracja-handlera-uwierzytelniania-do-walidacji-jwt)
  - [Własne fabryki do tworzenia Identity lub AuthenticationTicket](#własne-fabryki-do-tworzenia-identity-lub-authenticationticket)
- [Licencja](#licencja)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, implementacja JWT (JSON Web Token) dla .NET

Ta biblioteka obsługuje generowanie i dekodowanie [JSON Web Tokens](https://tools.ietf.org/html/rfc7519).

## Sponsor

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | Jeśli chcesz szybko wdrożyć bezpieczną autoryzację do swojego projektu JWT, [załóż konto Auth0](https://a0.to/try-auth0); to darmowe! |

## Dostępne pakiety NuGet

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net dla kontenera Microsoft Dependency Injection

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net dla ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Obsługiwane wersje .NET:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Tworzenie (kodowanie) tokena

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
const string key = null; // niepotrzebne, jeśli algorytm jest asymetryczny

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### Lub z użyciem płynnego API buildera

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Parsowanie (dekodowanie) i weryfikacja tokena

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
    Console.WriteLine("Token nie jest jeszcze ważny");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Token wygasł");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Token ma nieprawidłowy podpis");
}
```

#### Lub z użyciem płynnego API buildera

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

Wynik będzie następujący:

>{ "claim1": 0, "claim2": "claim2-value" }

Możesz też zdeserializować ładunek JSON bezpośrednio do typu .NET:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### Lub z użyciem płynnego API buildera

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Weryfikacja wygaśnięcia tokena

Jak opisano w [RFC 7519 sekcja 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4):

>Oznaczenie `exp` wskazuje czas wygaśnięcia, po którym JWT NIE MOŻE być zaakceptowany do przetwarzania.

Jeśli ten znacznik jest obecny w ładunku i jest wcześniejszy niż aktualny czas, token nie przejdzie weryfikacji. Wartość musi być podana jako liczba sekund od [epoki Unix](https://pl.wikipedia.org/wiki/Czas_Unix), 1/1/1970 00:00:00 UTC.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // token wygasł 5 minut temu

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // rzuca wyjątek TokenExpiredException
```

Następnie, jak opisano w [RFC 7519 sekcja 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5):

>Znak "nbf" (not before) wskazuje czas, przed którym JWT NIE MOŻE być zaakceptowany do przetwarzania

Jeśli jest obecny w ładunku i jest późniejszy niż aktualny czas, token nie przejdzie weryfikacji.

### Parsowanie (dekodowanie) nagłówka tokena

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### Lub z użyciem płynnego API buildera
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### Wyłączanie części walidacji tokena

Jeśli chcesz zwalidować token, ale pominąć niektóre elementy walidacji (takie jak sprawdzanie, czy token wygasł lub nie jest jeszcze ważny), możesz przekazać obiekt `ValidateParameters` do konstruktora klasy `JwtValidator`.

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
var json = decoder.Decode(expiredToken); // nie zgłosi wyjątku z powodu wygasłego tokena
```

#### Lub korzystając z płynnego API buildera

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

### Własny serializer JSON

Domyślnie serializacja JSON jest wykonywana przez JsonNetSerializer zaimplementowany przy użyciu [Json.Net](https://www.json.net). Aby użyć innego serializera, zaimplementuj interfejs `IJsonSerializer`:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // Implementacja przy użyciu ulubionego serializera JSON
    }

    public T Deserialize<T>(string json)
    {
        // Implementacja przy użyciu ulubionego serializera JSON
    }
}
```

Następnie przekaż ten serializer do konstruktora JwtEncoder:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### Własne ustawienia serializacji JSON z domyślnym JsonNetSerializer

Jak wspomniano powyżej, domyślna serializacja JSON jest realizowana przez `JsonNetSerializer`. Możesz zdefiniować własne ustawienia serializacji w następujący sposób:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // Wszystkie klucze zaczynają się od małej litery zamiast dokładnej wielkości liter modelu/właściwości, np. fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // Ładny i czytelny format, ale możesz też użyć Formatting.None, by zmniejszyć rozmiar payloadu
    Formatting = Formatting.Indented,
    
    // Najbardziej odpowiedni format daty i czasu.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // Nie dodawaj kluczy/wartości, gdy wartość jest null.
    NullValueHandling = NullValueHandling.Ignore,
    
    // Użyj wartości enum jako string, nie domyślnego int, np. "red" dla enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### Rejestracja handlera uwierzytelniania do walidacji JWT

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
                     // sekrety, wymagane tylko dla algorytmów symetrycznych, takich jak HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // opcjonalnie; wyłącz zgłaszanie wyjątku, jeśli podpis JWT jest nieprawidłowy
                     // options.VerifySignature = false;
                 });
  // niegeneryczna wersja AddJwt() wymaga ręcznej rejestracji instancji IAlgorithmFactory
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // lub
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // lub użyj generycznej wersji AddJwt<TFactory() do użycia własnej implementacji IAlgorithmFactory
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Własne fabryki do tworzenia Identity lub AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## Licencja

Poniższe projekty i powstałe z nich paczki są licencjonowane na zasadach domeny publicznej, patrz plik [LICENSE#Public-Domain](LICENSE.md#Public-Domain).

- JWT 

Poniższe projekty i powstałe z nich paczki są licencjonowane na zasadach licencji MIT, patrz plik [LICENSE#MIT](LICENSE.md#MIT).

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---