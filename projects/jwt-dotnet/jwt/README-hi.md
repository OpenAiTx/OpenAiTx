<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, .NET के लिए JWT (JSON Web Token) का एक इम्प्लीमेंटेशन](#jwtnet-a-jwt-json-web-token-implementation-for-net)
- [प्रायोजक](#sponsor)
- [उपलब्ध NuGet पैकेजेस](#avaliable-nuget-packages)
- [समर्थित .NET संस्करण:](#supported-net-versions)
- [Jwt.NET](#jwtnet)
  - [टोकन बनाना (एन्कोडिंग)](#creating-encoding-token)
    - [या फ्लुएंट बिल्डर API का उपयोग करते हुए](#or-using-the-fluent-builder-api)
  - [टोकन पार्स (डीकोड) करना और सत्यापित करना](#parsing-decoding-and-verifying-token)
    - [या फ्लुएंट बिल्डर API का उपयोग करते हुए](#or-using-the-fluent-builder-api-1)
    - [या फ्लुएंट बिल्डर API का उपयोग करते हुए](#or-using-the-fluent-builder-api-2)
  - [टोकन एक्सपाइरी वेलिडेट करना](#validate-token-expiration)
  - [टोकन हैडर पार्स (डीकोड) करना](#parsing-decoding-token-header)
    - [या फ्लुएंट बिल्डर API का उपयोग करते हुए](#or-using-the-fluent-builder-api-3)
  - [टोकन वेलिडेशन के कुछ हिस्से बंद करना](#turning-off-parts-of-token-validation)
    - [या फ्लुएंट बिल्डर API का उपयोग करते हुए](#or-using-the-fluent-builder-api-4)
  - [कस्टम JSON सीरियलाइज़र](#custom-json-serializer)
  - [डिफॉल्ट JsonNetSerializer के साथ कस्टम JSON सीरियलाइजेशन सेटिंग्स](#custom-json-serialization-settings-with-the-default-jsonnetserializer)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [JWT को सत्यापित करने के लिए ऑथेंटिकेशन हैंडलर रजिस्टर करें](#register-authentication-handler-to-validate-jwt)
  - [Identity या AuthenticationTicket बनाने के लिए कस्टम फैक्ट्रियां](#custom-factories-to-produce-identity-or-authenticationticket)
- [लाइसेंस](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, .NET के लिए JWT (JSON Web Token) का एक इम्प्लीमेंटेशन

यह लाइब्रेरी [JSON Web Tokens](https://tools.ietf.org/html/rfc7519) को जेनरेट और डिकोड करने का समर्थन करती है।

## प्रायोजक

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | यदि आप अपने JWT प्रोजेक्ट में जल्दी से सिक्योर ऑथेंटिकेशन इम्प्लीमेंट करना चाहते हैं, तो [Auth0 खाता बनाएँ](https://a0.to/try-auth0); यह मुफ़्त है! |

## उपलब्ध NuGet पैकेजेस

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Microsoft Dependency Injection कंटेनर के लिए Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. ASP.NET Core के लिए Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## समर्थित .NET संस्करण:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### टोकन बनाना (एन्कोडिंग)

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
const string key = null; // अगर algorithm asymmetric है तो ज़रूरत नहीं

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### या फ्लुएंट बिल्डर API का उपयोग करते हुए

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### टोकन पार्स (डीकोड) करना और सत्यापित करना

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
    Console.WriteLine("Token अभी मान्य नहीं है");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Token की समय-सीमा समाप्त हो चुकी है");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Token का हस्ताक्षर अमान्य है");
}
```

#### या फ्लुएंट बिल्डर API का उपयोग करते हुए

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

आउटपुट कुछ ऐसा होगा:

>{ "claim1": 0, "claim2": "claim2-value" }

आप JSON पेलोड को सीधे .NET टाइप में भी डीसिरियलाइज़ कर सकते हैं:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### या फ्लुएंट बिल्डर API का उपयोग करते हुए

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### टोकन एक्सपाइरी वेलिडेट करना

जैसा कि [RFC 7519 सेक्शन 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4) में वर्णित है:

>`exp` दावा टोकन की समाप्ति का समय दर्शाता है, जिसके बाद JWT को प्रोसेसिंग के लिए स्वीकार नहीं किया जाना चाहिए।

यदि यह पेलोड में उपस्थित है और वर्तमान समय से अधिक है, तो टोकन वेरिफिकेशन में फेल हो जाएगा। मान को [Unix epoch](https://en.wikipedia.org/wiki/Unix_time), 1/1/1970 00:00:00 UTC से सेकंड्स के रूप में देना चाहिए।

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // टोकन 5 मिनट पहले ही समाप्त हो चुका है

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // यह TokenExpiredException फेंकेगा
```

इसके बाद, जैसा कि [RFC 7519 सेक्शन 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5) में वर्णित है:

>`"nbf"` (not before) दावा उस समय को दर्शाता है, जिसके पहले JWT को प्रोसेसिंग के लिए स्वीकार नहीं किया जाना चाहिए

यदि यह पेलोड में उपस्थित है और वर्तमान समय से पहले है, तो टोकन वेरिफिकेशन में फेल हो जाएगा।

### टोकन हैडर पार्स (डीकोड) करना

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### या फ्लुएंट बिल्डर API का उपयोग करते हुए

```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### टोकन मान्यता के कुछ भागों को बंद करना

यदि आप किसी टोकन को सत्यापित करना चाहते हैं लेकिन सत्यापन के कुछ भागों (जैसे कि टोकन समाप्त हो गया है या अभी मान्य नहीं है) को अनदेखा करना चाहते हैं, तो आप `JwtValidator` क्लास के कन्स्ट्रक्टर में `ValidateParameters` ऑब्जेक्ट पास कर सकते हैं।

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
var json = decoder.Decode(expiredToken); // समाप्त टोकन के कारण अपवाद नहीं फेंकेगा
```

#### या फ्लुएंट बिल्डर API का उपयोग करते हुए

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

### कस्टम JSON सीरियलाइज़र

डिफ़ॉल्ट रूप से JSON सीरियलाइज़ेशन [Json.Net](https://www.json.net) का उपयोग करके लागू JsonNetSerializer द्वारा किया जाता है। किसी अन्य को उपयोग करने के लिए, `IJsonSerializer` इंटरफेस को लागू करें:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // पसंदीदा JSON सीरियलाइज़र का उपयोग करके लागू करें
    }

    public T Deserialize<T>(string json)
    {
        // पसंदीदा JSON सीरियलाइज़र का उपयोग करके लागू करें
    }
}
```

और फिर इस सीरियलाइज़र को JwtEncoder के कन्स्ट्रक्टर में पास करें:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### डिफ़ॉल्ट JsonNetSerializer के साथ कस्टम JSON सीरियलाइज़ेशन सेटिंग्स

जैसा कि ऊपर उल्लेख किया गया है, डिफ़ॉल्ट JSON सीरियलाइज़ेशन `JsonNetSerializer` द्वारा किया जाता है। आप अपनी कस्टम सीरियलाइज़ेशन सेटिंग्स इस प्रकार परिभाषित कर सकते हैं:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // सभी कुंजियाँ छोटे अक्षरों से शुरू होती हैं, उदाहरण के लिए fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // पढ़ने में आसान, लेकिन आप पेलोड साइज कम करने के लिए Formatting.None भी उपयोग कर सकते हैं
    Formatting = Formatting.Indented,
    
    // सबसे उपयुक्त तारीख-समय प्रारूप।
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // जब मान null हो तो कुंजी/मान न जोड़ें।
    NullValueHandling = NullValueHandling.Ignore,
    
    // enum का स्ट्रिंग मान उपयोग करें, न कि int मान, जैसे enum Color { Red } के लिए "red"
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### JWT को मान्य करने के लिए प्रमाणीकरण हैंडलर पंजीकृत करें

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
                     // सीक्रेट, केवल सिमेट्रिक एल्गोरिदम के लिए आवश्यक, जैसे HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // वैकल्पिक; यदि JWT हस्ताक्षर अमान्य है तो अपवाद फेंकना अक्षम करें
                     // options.VerifySignature = false;
                 });
  // गैर-जनरिक संस्करण AddJwt() के लिए IAlgorithmFactory का उदाहरण मैन्युअल रूप से पंजीकृत करना आवश्यक है
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // या
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // या कस्टम IAlgorithmFactory के लिए जनरिक संस्करण AddJwt<TFactory() का उपयोग करें
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Identity या AuthenticationTicket उत्पन्न करने के लिए कस्टम फैक्ट्रियाँ

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## लाइसेंस

निम्नलिखित प्रोजेक्ट्स और उनके परिणामस्वरूप पैकेज सार्वजनिक डोमेन के तहत लाइसेंस प्राप्त हैं, विवरण के लिए देखें [LICENSE#Public-Domain](LICENSE.md#Public-Domain) फ़ाइल।

- JWT 

निम्नलिखित प्रोजेक्ट्स और उनके परिणामस्वरूप पैकेज MIT लाइसेंस के तहत लाइसेंस प्राप्त हैं, विवरण के लिए देखें [LICENSE#MIT](LICENSE.md#MIT) फ़ाइल।

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---