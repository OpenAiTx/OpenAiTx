<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, uma implementação JWT (JSON Web Token) para .NET](#jwtnet-uma-implementação-jwt-json-web-token-para-net)
- [Patrocinador](#patrocinador)
- [Pacotes NuGet disponíveis](#pacotes-nuget-disponíveis)
- [Versões .NET suportadas:](#versões-net-suportadas)
- [Jwt.NET](#jwtnet)
  - [Criando (codificando) token](#criando-codificando-token)
    - [Ou usando a API fluente de builder](#ou-usando-a-api-fluente-de-builder)
  - [Analisando (decodificando) e verificando token](#analisando-decodificando-e-verificando-token)
    - [Ou usando a API fluente de builder](#ou-usando-a-api-fluente-de-builder-1)
    - [Ou usando a API fluente de builder](#ou-usando-a-api-fluente-de-builder-2)
  - [Validar expiração do token](#validar-expiração-do-token)
  - [Analisando (decodificando) o header do token](#analisando-decodificando-o-header-do-token)
    - [Ou usando a API fluente de builder](#ou-usando-a-api-fluente-de-builder-3)
  - [Desativando partes da validação do token](#desativando-partes-da-validação-do-token)
    - [Ou usando a API fluente de builder](#ou-usando-a-api-fluente-de-builder-4)
  - [Serializador JSON customizado](#serializador-json-customizado)
  - [Configurações customizadas de serialização JSON com o JsonNetSerializer padrão](#configurações-customizadas-de-serialização-json-com-o-jsonnetserializer-padrão)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [Registrar handler de autenticação para validar JWT](#registrar-handler-de-autenticação-para-validar-jwt)
  - [Fábricas customizadas para produzir Identity ou AuthenticationTicket](#fábricas-customizadas-para-produzir-identity-ou-authenticationticket)
- [Licença](#licença)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, uma implementação JWT (JSON Web Token) para .NET

Esta biblioteca suporta a geração e decodificação de [JSON Web Tokens](https://tools.ietf.org/html/rfc7519).

## Patrocinador

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | Se você deseja implementar rapidamente uma autenticação segura em seu projeto JWT, [crie uma conta Auth0](https://a0.to/try-auth0); é grátis! |

## Pacotes NuGet disponíveis

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net para o container Microsoft Dependency Injection

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net para ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Versões .NET suportadas:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Criando (codificando) token

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
const string key = null; // não necessário se o algoritmo for assimétrico

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### Ou usando a API fluente de builder

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Analisando (decodificando) e verificando token

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
    Console.WriteLine("Token ainda não é válido");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Token expirou");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Token possui assinatura inválida");
}
```

#### Ou usando a API fluente de builder

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

A saída será:

>{ "claim1": 0, "claim2": "claim2-value" }

Você também pode desserializar o payload JSON diretamente para um tipo .NET:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### Ou usando a API fluente de builder

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Validar expiração do token

Como descrito na [RFC 7519 seção 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4):

>A claim `exp` identifica o horário de expiração no qual ou após o qual o JWT NÃO DEVE ser aceito para processamento.

Se estiver presente no payload e já tiver passado do horário atual, o token falhará na verificação. O valor deve ser especificado como o número de segundos desde a [época Unix](https://en.wikipedia.org/wiki/Unix_time), 1/1/1970 00:00:00 UTC.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // o token expirou há 5 minutos

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // lança TokenExpiredException
```

Então, como descrito na [RFC 7519 seção 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5):

>A claim "nbf" (not before) identifica o horário antes do qual o JWT NÃO DEVE ser aceito para processamento.

Se estiver presente no payload e for anterior ao horário atual, o token falhará na verificação.

### Analisando (decodificando) o header do token

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### Ou usando a API fluente de builder
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### Desativando partes da validação do token

Se você deseja validar um token, mas ignorar certas partes da validação (como se o token expirou ou ainda não é válido), você pode passar um objeto `ValidateParameters` para o construtor da classe `JwtValidator`.

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
var json = decoder.Decode(expiredToken); // não lançará exceção devido ao token expirado
```

#### Ou usando a API fluente do builder

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

Por padrão, a serialização JSON é realizada pelo JsonNetSerializer implementado usando [Json.Net](https://www.json.net). Para usar um diferente, implemente a interface `IJsonSerializer`:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // Implemente usando seu serializador JSON favorito
    }

    public T Deserialize<T>(string json)
    {
        // Implemente usando seu serializador JSON favorito
    }
}
```

E então passe esse serializador para o construtor do JwtEncoder:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### Configurações de serialização JSON personalizadas com o JsonNetSerializer padrão

Como mencionado acima, a serialização JSON padrão é feita pelo `JsonNetSerializer`. Você pode definir suas próprias configurações de serialização personalizadas da seguinte forma:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // Todas as chaves começam com caracteres minúsculos ao invés da capitalização exata do modelo/propriedade, por exemplo fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // Fácil de ler, mas você também pode usar Formatting.None para reduzir o tamanho do payload
    Formatting = Formatting.Indented,
    
    // O formato de data/hora mais apropriado.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // Não adiciona chaves/valores quando o valor é nulo.
    NullValueHandling = NullValueHandling.Ignore,
    
    // Usa o valor string do enum, não o valor int implícito, por exemplo "red" para enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### Registrar manipulador de autenticação para validar JWT

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
                     // segredos, necessários apenas para algoritmos simétricos, como HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // opcionalmente; desabilita lançar exceção se a assinatura do JWT for inválida
                     // options.VerifySignature = false;
                 });
  // a versão não genérica AddJwt() exige o registro manual de uma instância de IAlgorithmFactory
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // ou
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // ou use a versão genérica AddJwt<TFactory() para usar uma implementação personalizada de IAlgorithmFactory
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Fábricas personalizadas para produzir Identity ou AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## Licença

Os seguintes projetos e seus pacotes resultantes estão licenciados sob Domínio Público, veja o arquivo [LICENSE#Public-Domain](LICENSE.md#Public-Domain).

- JWT 

Os seguintes projetos e seus pacotes resultantes estão licenciados sob a Licença MIT, veja o arquivo [LICENSE#MIT](LICENSE.md#MIT).

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---