<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, sebuah implementasi JWT (JSON Web Token) untuk .NET](#jwtnet-sebuah-implementasi-jwt-json-web-token-untuk-net)
- [Sponsor](#sponsor)
- [Paket NuGet yang Tersedia](#paket-nuget-yang-tersedia)
- [Versi .NET yang Didukung:](#versi-net-yang-didukung)
- [Jwt.NET](#jwtnet)
  - [Membuat (encode) token](#membuat-encode-token)
    - [Atau menggunakan fluent builder API](#atau-menggunakan-fluent-builder-api)
  - [Mengurai (decode) dan memverifikasi token](#mengurai-decode-dan-memverifikasi-token)
    - [Atau menggunakan fluent builder API](#atau-menggunakan-fluent-builder-api-1)
    - [Atau menggunakan fluent builder API](#atau-menggunakan-fluent-builder-api-2)
  - [Validasi kedaluwarsa token](#validasi-kedaluwarsa-token)
  - [Mengurai (decode) header token](#mengurai-decode-header-token)
    - [Atau menggunakan fluent builder API](#atau-menggunakan-fluent-builder-api-3)
  - [Mematikan sebagian validasi token](#mematikan-sebagian-validasi-token)
    - [Atau menggunakan fluent builder API](#atau-menggunakan-fluent-builder-api-4)
  - [Serializer JSON Kustom](#serializer-json-kustom)
  - [Pengaturan serialisasi JSON kustom dengan JsonNetSerializer bawaan](#pengaturan-serialisasi-json-kustom-dengan-jsonnetserializer-bawaan)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [Mendaftarkan handler autentikasi untuk memvalidasi JWT](#mendaftarkan-handler-autentikasi-untuk-memvalidasi-jwt)
  - [Factory kustom untuk menghasilkan Identity atau AuthenticationTicket](#factory-kustom-untuk-menghasilkan-identity-atau-authenticationticket)
- [Lisensi](#lisensi)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, sebuah implementasi JWT (JSON Web Token) untuk .NET

Library ini mendukung pembuatan dan penguraian [JSON Web Token](https://tools.ietf.org/html/rfc7519).

## Sponsor

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | Jika Anda ingin dengan cepat mengimplementasikan autentikasi aman pada proyek JWT Anda, [buat akun Auth0](https://a0.to/try-auth0); Gratis! |

## Paket NuGet yang Tersedia

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net untuk Microsoft Dependency Injection container

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net untuk ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Versi .NET yang Didukung:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Membuat (encode) token

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
const string key = null; // tidak perlu jika algoritma asimetris

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### Atau menggunakan fluent builder API

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Mengurai (decode) dan memverifikasi token

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
    Console.WriteLine("Token belum berlaku");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Token telah kedaluwarsa");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Tanda tangan token tidak valid");
}
```

#### Atau menggunakan fluent builder API

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

Keluaran akan berupa:

>{ "claim1": 0, "claim2": "claim2-value" }

Anda juga dapat langsung mendeserialisasikan payload JSON ke tipe .NET:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### Atau menggunakan fluent builder API

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Validasi kedaluwarsa token

Seperti dijelaskan pada [RFC 7519 section 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4):

>Claim `exp` mengidentifikasi waktu kedaluwarsa di mana setelahnya JWT TIDAK BOLEH diterima untuk diproses.

Jika ada di payload dan sudah melewati waktu saat ini, maka token akan gagal verifikasi. Nilainya harus ditentukan sebagai jumlah detik sejak [Unix epoch](https://en.wikipedia.org/wiki/Unix_time), 1/1/1970 00:00:00 UTC.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // token sudah kedaluwarsa 5 menit yang lalu

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // melempar TokenExpiredException
```

Kemudian, seperti dijelaskan pada [RFC 7519 section 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5):

>Claim "nbf" (not before) mengidentifikasi waktu sebelum JWT TIDAK BOLEH diterima untuk diproses

Jika ada di payload dan sebelum waktu saat ini, maka token akan gagal verifikasi.

### Mengurai (decode) header token

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### Atau menggunakan fluent builder API
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### Mematikan bagian dari validasi token

Jika Anda ingin memvalidasi token tetapi mengabaikan bagian tertentu dari validasi (seperti apakah token sudah kedaluwarsa atau belum valid), Anda dapat meneruskan objek `ValidateParameters` ke konstruktor kelas `JwtValidator`.

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
var json = decoder.Decode(expiredToken); // tidak akan melempar error karena token kedaluwarsa
```

#### Atau menggunakan fluent builder API

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

### Serializer JSON Kustom

Secara default serialisasi JSON dilakukan oleh JsonNetSerializer yang diimplementasikan menggunakan [Json.Net](https://www.json.net). Untuk menggunakan yang lain, implementasikan antarmuka `IJsonSerializer`:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // Implementasi menggunakan serializer JSON favorit Anda
    }

    public T Deserialize<T>(string json)
    {
        // Implementasi menggunakan serializer JSON favorit Anda
    }
}
```

Lalu teruskan serializer ini ke konstruktor JwtEncoder:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### Pengaturan serialisasi JSON kustom dengan JsonNetSerializer default

Seperti disebutkan di atas, serialisasi JSON default dilakukan oleh `JsonNetSerializer`. Anda dapat menentukan pengaturan serialisasi kustom Anda sendiri sebagai berikut:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // Semua key diawali huruf kecil bukan casing asli model/properti, misal fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // Mudah dibaca, tapi bisa juga pakai Formatting.None untuk memperkecil payload
    Formatting = Formatting.Indented,
    
    // Format datetime yang paling tepat.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // Tidak menambah key/value jika nilainya null.
    NullValueHandling = NullValueHandling.Ignore,
    
    // Pakai nilai string enum, bukan nilai int implisit, misal "red" untuk enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### Mendaftarkan handler autentikasi untuk memvalidasi JWT

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
                     // secrets, hanya diperlukan untuk algoritma simetris, seperti HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // opsional; nonaktifkan melempar exception jika signature JWT tidak valid
                     // options.VerifySignature = false;
                 });
  // versi non-generic AddJwt() memerlukan pendaftaran instance IAlgorithmFactory secara manual
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // atau
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // atau gunakan versi generic AddJwt<TFactory() untuk menggunakan implementasi IAlgorithmFactory kustom
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Pabrik kustom untuk menghasilkan Identity atau AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## Lisensi

Proyek berikut dan paket hasilnya dilisensikan di bawah Public Domain, lihat berkas [LICENSE#Public-Domain](LICENSE.md#Public-Domain).

- JWT 

Proyek berikut dan paket hasilnya dilisensikan di bawah Lisensi MIT, lihat berkas [LICENSE#MIT](LICENSE.md#MIT).

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---