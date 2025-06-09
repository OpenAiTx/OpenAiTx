<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DO NOT EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Jwt.Net, một thư viện triển khai JWT (JSON Web Token) cho .NET](#jwtnet-một-thư-viện-triển-khai-jwt-json-web-token-cho-net)
- [Nhà tài trợ](#nhà-tài-trợ)
- [Các gói NuGet sẵn có](#các-gói-nuget-sẵn-có)
- [Các phiên bản .NET được hỗ trợ:](#các-phiên-bản-net-được-hỗ-trợ)
- [Jwt.NET](#jwtnet)
  - [Tạo (mã hóa) token](#tạo-mã-hóa-token)
    - [Hoặc sử dụng fluent builder API](#hoặc-sử-dụng-fluent-builder-api)
  - [Phân tích (giải mã) và xác minh token](#phân-tích-giải-mã-và-xác-minh-token)
    - [Hoặc sử dụng fluent builder API](#hoặc-sử-dụng-fluent-builder-api-1)
    - [Hoặc sử dụng fluent builder API](#hoặc-sử-dụng-fluent-builder-api-2)
  - [Kiểm tra hạn token](#kiểm-tra-hạn-token)
  - [Phân tích (giải mã) header của token](#phân-tích-giải-mã-header-của-token)
    - [Hoặc sử dụng fluent builder API](#hoặc-sử-dụng-fluent-builder-api-3)
  - [Tắt một số phần kiểm tra token](#tắt-một-số-phần-kiểm-tra-token)
    - [Hoặc sử dụng fluent builder API](#hoặc-sử-dụng-fluent-builder-api-4)
  - [Tùy chỉnh trình tuần tự hóa JSON](#tùy-chỉnh-trình-tuần-tự-hóa-json)
  - [Tùy chỉnh thiết lập tuần tự hóa JSON với JsonNetSerializer mặc định](#tùy-chỉnh-thiết-lập-tuần-tự-hóa-json-với-jsonnetserializer-mặc-định)
- [Jwt.Net ASP.NET Core](#jwtnet-aspnet-core)
  - [Đăng ký trình xử lý xác thực để kiểm tra JWT](#đăng-ký-trình-xử-lý-xác-thực-để-kiểm-tra-jwt)
  - [Các factory tùy chỉnh để tạo Identity hoặc AuthenticationTicket](#các-factory-tùy-chỉnh-để-tạo-identity-hoặc-authenticationticket)
- [Giấy phép](#giấy-phép)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

[![Build status](https://abatishchev.visualstudio.com/OpenSource/_apis/build/status/Jwt.Net-CI)](https://abatishchev.visualstudio.com/OpenSource/_build/latest?definitionId=9)
[![Release status](https://abatishchev.vsrm.visualstudio.com/_apis/public/Release/badge/b7fc2610-91d5-4968-814c-97a9d76b03c4/2/2)](https://abatishchev.visualstudio.com/OpenSource/_release?_a=releases&view=mine&definitionId=2)

## Jwt.Net, một thư viện triển khai JWT (JSON Web Token) cho .NET

Thư viện này hỗ trợ tạo và giải mã [JSON Web Tokens](https://tools.ietf.org/html/rfc7519).

## Nhà tài trợ

| | |
|-|-|
| [<img alt="Auth0 logo" src="https://cdn.auth0.com/blog/github-sponsorships/brand-evolution-logo-Auth0-horizontal-Indigo.png" height="91">](https://a0.to/try-auth0) | Nếu bạn muốn nhanh chóng triển khai xác thực bảo mật cho dự án JWT của mình, [tạo tài khoản Auth0](https://a0.to/try-auth0); Miễn phí! |

## Các gói NuGet sẵn có

1.  Jwt.Net

[![NuGet](https://img.shields.io/nuget/v/JWT.svg)](https://www.nuget.org/packages/JWT)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.svg)](https://www.nuget.org/packages/JWT)

2. Jwt.Net cho Microsoft Dependency Injection container

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.DependencyInjection.svg)](https://www.nuget.org/packages/JWT.Extensions.DependencyInjection)

3. Jwt.Net cho ASP.NET Core

[![NuGet](https://img.shields.io/nuget/v/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)
[![NuGet Pre](https://img.shields.io/nuget/vpre/JWT.Extensions.AspNetCore.svg)](https://www.nuget.org/packages/JWT.Extensions.AspNetCore)

## Các phiên bản .NET được hỗ trợ:

- .NET Framework 3.5
- .NET Framework 4.0 - 4.8
- .NET Standard 1.3, 2.0
- .NET 6.0

## Jwt.NET

### Tạo (mã hóa) token

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
const string key = null; // không cần nếu thuật toán bất đối xứng

var token = encoder.Encode(payload, key);
Console.WriteLine(token);
```

#### Hoặc sử dụng fluent builder API

```c#
var token = JwtBuilder.Create()
                      .WithAlgorithm(new RS256Algorithm(certificate))
                      .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                      .AddClaim("claim1", 0)
                      .AddClaim("claim2", "claim2-value")
                      .Encode();
Console.WriteLine(token);
```
### Phân tích (giải mã) và xác minh token

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
    Console.WriteLine("Token chưa hợp lệ");
}
catch (TokenExpiredException)
{
    Console.WriteLine("Token đã hết hạn");
}
catch (SignatureVerificationException)
{
    Console.WriteLine("Token có chữ ký không hợp lệ");
}
```

#### Hoặc sử dụng fluent builder API

```c#
var json = JwtBuilder.Create()
                     .WithAlgorithm(new RS256Algorithm(certificate))
                     .MustVerifySignature()
                     .Decode(token);                    
Console.WriteLine(json);
```

Kết quả sẽ là:

>{ "claim1": 0, "claim2": "claim2-value" }

Bạn cũng có thể giải mã trực tiếp JSON payload thành kiểu dữ liệu .NET:

```c#
var payload = decoder.DecodeToObject<IDictionary<string, object>>(token, secret);
```

#### Hoặc sử dụng fluent builder API

```c#
var payload = JwtBuilder.Create()
                        .WithAlgorithm(new RS256Algorithm(certificate))
                        .WithSecret(secret)
                        .MustVerifySignature()
                        .Decode<IDictionary<string, object>>(token);     
```

### Kiểm tra hạn token

Như đã mô tả trong [RFC 7519 section 4.1.4](https://tools.ietf.org/html/rfc7519#section-4.1.4):

>`exp` claim xác định thời điểm hết hạn mà sau đó JWT KHÔNG ĐƯỢC chấp nhận để xử lý.

Nếu trường này có trong payload và đã vượt quá thời gian hiện tại, token sẽ không vượt qua xác minh. Giá trị cần được chỉ định là số giây kể từ [Unix epoch](https://en.wikipedia.org/wiki/Unix_time), 1/1/1970 00:00:00 UTC.

```c#
IDateTimeProvider provider = new UtcDateTimeProvider();
var now = provider.GetNow().AddMinutes(-5); // token đã hết hạn 5 phút trước

double secondsSinceEpoch = UnixEpoch.GetSecondsSince(now);

var payload = new Dictionary<string, object>
{
    { "exp", secondsSinceEpoch }
};
var token = encoder.Encode(payload);

decoder.Decode(token); // sẽ ném ra TokenExpiredException
```

Sau đó, như đã mô tả trong [RFC 7519 section 4.1.5](https://tools.ietf.org/html/rfc7519#section-4.1.5):

>`nbf` (not before) xác định thời điểm trước đó JWT KHÔNG ĐƯỢC chấp nhận để xử lý

Nếu trường này có trong payload và trước thời gian hiện tại, token sẽ không vượt qua xác minh.

### Phân tích (giải mã) header của token

```c#
IJsonSerializer serializer = new JsonNetSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtDecoder decoder = new JwtDecoder(serializer, urlEncoder);

JwtHeader header = decoder.DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

#### Hoặc sử dụng fluent builder API
```c#
JwtHeader header = JwtBuilder.Create()
                             .DecodeHeader<JwtHeader>(token);

var typ = header.Type; // JWT
var alg = header.Algorithm; // RS256
var kid = header.KeyId; // CFAEAE2D650A6CA9862575DE54371EA980643849
```

### Tắt một phần xác thực token

Nếu bạn muốn xác thực một token nhưng bỏ qua một số phần của việc xác thực (chẳng hạn như kiểm tra token đã hết hạn hoặc chưa hợp lệ), bạn có thể truyền một đối tượng `ValidateParameters` vào constructor của lớp `JwtValidator`.

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
var json = decoder.Decode(expiredToken); // sẽ không ném ngoại lệ vì token đã hết hạn
```

#### Hoặc sử dụng fluent builder API

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

### Tùy chỉnh trình tuần tự JSON

Mặc định, quá trình tuần tự hóa JSON được thực hiện bởi JsonNetSerializer được xây dựng dựa trên [Json.Net](https://www.json.net). Để sử dụng trình tuần tự khác, hãy triển khai giao diện `IJsonSerializer`:

```c#
public sealed class CustomJsonSerializer : IJsonSerializer
{
    public string Serialize(object obj)
    {
        // Triển khai bằng trình tuần tự JSON ưa thích
    }

    public T Deserialize<T>(string json)
    {
        // Triển khai bằng trình tuần tự JSON ưa thích
    }
}
```

Và sau đó truyền trình tuần tự này vào constructor của JwtEncoder:

```c#
IJwtAlgorithm algorithm = new RS256Algorirhm(certificate);
IJsonSerializer serializer = new CustomJsonSerializer();
IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
```

### Tùy chỉnh thiết lập tuần tự JSON với JsonNetSerializer mặc định

Như đã đề cập ở trên, tuần tự hóa JSON mặc định được thực hiện bởi `JsonNetSerializer`. Bạn có thể định nghĩa các thiết lập tuần tự hóa tùy chỉnh như sau:

```c#
JsonSerializer customJsonSerializer = new JsonSerializer
{
    // Tất cả các khóa bắt đầu bằng ký tự thường thay vì giữ nguyên kiểu chữ của model/thuộc tính, ví dụ: fullName
    ContractResolver = new CamelCasePropertyNamesContractResolver(), 
    
    // Định dạng dễ đọc, nhưng bạn cũng có thể dùng Formatting.None để giảm kích thước payload
    Formatting = Formatting.Indented,
    
    // Định dạng ngày giờ phù hợp nhất.
    DateFormatHandling = DateFormatHandling.IsoDateFormat,
    
    // Không thêm khóa/giá trị khi giá trị là null.
    NullValueHandling = NullValueHandling.Ignore,
    
    // Sử dụng giá trị chuỗi của enum, không phải giá trị int ngầm định, ví dụ: "red" cho enum Color { Red }
    Converters.Add(new StringEnumConverter())
};
IJsonSerializer serializer = new JsonNetSerializer(customJsonSerializer);
```

## Jwt.Net ASP.NET Core

### Đăng ký trình xử lý xác thực để kiểm tra JWT

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
                     // bí mật, chỉ yêu cầu cho các thuật toán đối xứng, như HMACSHA256Algorithm
                     // options.Keys = new[] { "mySecret" };
                     
                     // tùy chọn; tắt việc ném ngoại lệ nếu chữ ký JWT không hợp lệ
                     // options.VerifySignature = false;
                 });
  // phiên bản không generic AddJwt() yêu cầu đăng ký thủ công một instance của IAlgorithmFactory
  services.AddSingleton<IAlgorithmFactory>(new RSAlgorithmFactory(certificate));
  // hoặc
  services.AddSingleton<IAlgorithmFactory>(new DelegateAlgorithmFactory(algorithm));

  // hoặc sử dụng phiên bản generic AddJwt<TFactory() để sử dụng triển khai tùy chỉnh của IAlgorithmFactory
  .AddJwt<MyCustomAlgorithmFactory>(options => ...);
}

public void Configure(IApplicationBuilder app)
{
    app.UseAuthentication();
}
```

### Factory tùy chỉnh để tạo Identity hoặc AuthenticationTicket

```c#
services.AddSingleton<IIdentityFactory, CustomIdentityFctory>();
services.AddSingleton<ITicketFactory, CustomTicketFactory>();
```

## Giấy phép

Các dự án sau và các gói phần mềm kết quả của chúng được cấp phép theo Public Domain, xem tệp [LICENSE#Public-Domain](LICENSE.md#Public-Domain).

- JWT 

Các dự án sau và các gói phần mềm kết quả của chúng được cấp phép theo giấy phép MIT, xem tệp [LICENSE#MIT](LICENSE.md#MIT).

- JWT.Extensions.AspNetCore
- JWT.Extensions.DependencyInjection
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---