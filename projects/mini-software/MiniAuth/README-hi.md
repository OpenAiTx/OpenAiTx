<div align="center">
<p><a href="https://www.nuget.org/packages/MiniAuth"><img src="https://img.shields.io/nuget/v/MiniAuth.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniAuth"><img src="https://img.shields.io/nuget/dt/MiniAuth.svg" alt=""></a>  
<a href="https://gitee.com/shps951023/MiniAuth"><img src="https://gitee.com/shps951023/MiniAuth/badge/star.svg" alt="star"></a> <a href="https://github.com/Mini-Software/MiniAuth" rel="nofollow"><img src="https://img.shields.io/github/stars/Mini-Software/MiniAuth?logo=github" alt="GitHub stars"></a> <a href="https://www.nuget.org/packages/MiniAuth"><img src="https://img.shields.io/badge/.NET-%3E%3D%206.0-red.svg" alt="version"></a>
</p>
</div>

---

<div align="center">
<p><strong>
    <a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a> | <a href="README.ja.md">日本語</a> | <a href="README.ko.md">한국어</a> | <a href="README.es.md">Español</a>  
</strong></p>
</div>



---

<div align="center">
 आपका <a href="https://github.com/mini-software/miniauth">Star</a>, <a href="https://miniexcel.github.io/">Donate</a>, <a href="https://www.linkedin.com/in/itweihan/">Recomm.</a> MiniAuth को और बेहतर बना सकता है 
</div>




### परिचय



"एक लाइन कोड" आपके नए/पुराने प्रोजेक्ट्स में asp.net core identity यूजर/रोल मैनेजमेंट वेब जोड़ता है

<table>
    <tr>
        <td><img src="https://github.com/mini-software/MiniExcel/assets/12729184/d2aec694-158d-4ebc-bd8b-0e9ae1f855ac" alt="Image 1"></td>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/2f791e25-9158-495e-9383-4fbedf9b982b" alt="Image 2"></td>
    </tr>
    <tr>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/03d72ed7-8fb9-465f-9093-24b00279eeb2" alt="Image 3"></td>
        <td><img src="https://github.com/mini-software/MiniAuth/assets/12729184/841df179-7e5f-481a-9039-46738b20aa2e" alt="Image 4"></td>
    </tr>
</table>


### विशेषताएँ

- अनुकूलता: .NET identity को सपोर्ट करता है, JWT, Cookie, Session आदि पर आधारित
- सरल: प्लग-एंड-प्ले डिज़ाइन, API, SPA, MVC, Razor Page आदि
- मल्टीपल डेटाबेस सपोर्ट: Oracle, SQL Server, MySQL आदि, EF Core के साथ
- नॉन-इंट्रूसिव: मौजूदा डेटाबेस या प्रोजेक्ट स्ट्रक्चर को प्रभावित नहीं करता
- मल्टी-प्लेटफार्म: Linux, macOS एनवायरनमेंट सपोर्ट करता है



### इंस्टॉलेशन

NuGet से पैकेज इंस्टॉल करें

### क्विक स्टार्ट

Startup में केवल एक लाइन कोड `services.AddMiniAuth()` जोड़ें, फिर अपने प्रोजेक्ट को रन करें। उदाहरण:

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMiniAuth(); // <= ❗❗❗

        var app = builder.Build();
        app.Run();
    }
}
```

डिफ़ॉल्ट एडमिन खाता है `admin@mini-software.github.io` और पासवर्ड है `E7c4f679-f379-42bf-b547-684d456bc37f` (कृपया पासवर्ड बदलना न भूलें)। एडमिन पेज पर पहुँचें: `http(s)://yourhost/miniauth/index.html`

उन कैटेगरी या मेथड पर `[Authorize]` जोड़ें जिनमें अनुमति प्रबंधन या रोल नियंत्रण आवश्यक है, या रोल नियंत्रण के लिए `[Authorize(Roles = "role")]`। लॉगिन नहीं होने पर 401 स्टेटस मिलेगा, और अनुमति न होने पर 403 स्टेटस मिलेगा।



### MiniAuth कुकी आइडेंटिटी

MiniAuth डिफ़ॉल्ट रूप से सिंगल Cookie Based आइडेंटिटी के रूप में सेट है, फ्रंटएंड और बैकएंड सेपरेशन प्रोजेक्ट्स के लिए कृपया JWT आदि ऑथ का उपयोग करें।



### MiniAuth JWT आइडेंटिटी

AuthenticationType = BearerJwt सेट करना

```C#
builder.Services.AddMiniAuth(options:(options) =>
{
    options.AuthenticationType = MiniAuthOptions.AuthType.BearerJwt;
});
```

कृपया नया JWT Security Key सेट करना न भूलें, उदाहरण के लिए:

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.JWTKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6ee3edbf-488e-4484-9c2c-e3ffa6dcbc09"));
});
```

#### टोकन प्राप्त करना

फ्रंटएंड जावास्क्रिप्ट XHR उदाहरण

```javascript
var data = JSON.stringify({
  "username": "admin@mini-software.github.io",
  "password": "E7c4f679-f379-42bf-b547-684d456bc37f",
  "remember": false
});
var xhr = new XMLHttpRequest();
xhr.withCredentials = true;
xhr.addEventListener("readystatechange", function() {
  if(this.readyState === 4) {
    console.log(this.responseText);
  }
});
xhr.open("POST", "http://yourhost/miniauth/login");
xhr.setRequestHeader("Content-Type", "application/json");
xhr.send(data);
```

response

```json
{
    "ok": true,
    "code": 200,
    "message": null,
    "data": {
        "tokenType": "Bearer",
        "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiJhZG1pbkBtaW5pLXNvZnR3YXJlLmdpdGh1Yi5pbyIsIm5iZiI6MTcxODIwNDg5NSwiZXhwIjoxNzE4MjA1Nzk1LCJpYXQiOjE3MTgyMDQ4OTUsImlzcyI6Ik1pbmlBdXRoIn0._-DQ_rcbeju8_nrK2lD5we0rre04_xdDZNF6NhM0Rg0",
        "expiresIn": 900
    }
}
```

`accessToken` को localstorage या cookie में सेव करें। अपनी [Authorize] API कॉल करते समय, `Header Authorization` में `Bearer + स्पेस + accessToken` सेट करें, सिस्टम स्वतः उसे सत्यापित करेगा।

उदाहरण:

```js
var xhr = new XMLHttpRequest();
xhr.withCredentials = true;
xhr.addEventListener("readystatechange", function() {
  if(this.readyState === 4) {
    console.log(this.responseText);
  }
});
xhr.open("GET", "http://yourhost:5014/your/api");
xhr.setRequestHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiJhZG1pbkBtaW5pLXNvZnR3YXJlLmdpdGh1Yi5pbyIsIm5iZiI6MTcxODIwNDg5NSwiZXhwIjoxNzE4MjA1Nzk1LCJpYXQiOjE3MTgyMDQ4OTUsImlzcyI6Ik1pbmlBdXRoIn0._-DQ_rcbeju8_nrK2lD5we0rre04_xdDZNF6NhM0Rg0");
xhr.send();
```



#### समाप्ति समय सेट करें

```c#
options.TokenExpiresIn = 30 * 60; 
```

यूनिट सेकंड में है, डिफ़ॉल्ट सेटिंग 30 मिनट है। साथ ही ध्यान दें कि .NET JWT में JwtBearerOptions का ClockSkew डिफ़ॉल्ट रूप से 5 मिनट अतिरिक्त जोड़ता है [कारण](https://stackoverflow.com/questions/43045035/jwt-token-authentication-expired-tokens-still-working-net-core-web-api)।

#### रिफ्रेश टोकन API (JWT)

API : `/MiniAuth/refreshToken`
Body:

```json
{
   "refreshToken":"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyMzk5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.HYBWrM2suDiM4OG0FSlXhNgktZIG9l3ufmIAnwZiIoU"
}
```
Header:
```
Authorization:Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyNTc5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.rgAgsziAdLqOC9NYra-M9WQl8BJ99sRdfzRKNkMz9dk
```
समाप्ति समय सेट किया गया है `MiniAuthOptions.TokenExpiresIn / 2`, डिफ़ॉल्ट 30 मिनट।



### सेटिंग्स, विकल्प, कस्टमाइज़ेशन

#### डिफ़ॉल्ट मोड

- MiniAuth का डिफ़ॉल्ट मोड IT एडमिन्स द्वारा केंद्रीकृत यूजर प्रबंधन है। उपयोगकर्ता पंजीकरण और पासवर्ड रीसेट जैसी क्रियाओं के लिए प्री-डिफाइंड रोल = miniauth-admin वाले एडमिन खाते की आवश्यकता होती है।

#### MiniAuth लॉगिन निष्क्रिय करें

यदि आप केवल अपनी खुद की लॉगिन लॉजिक, पेज और API का उपयोग करना चाहते हैं, तो आप लॉगिन पाथ निर्दिष्ट कर सकते हैं और MiniAuth लॉगिन को बंद कर सकते हैं।
```C#
// सेवा पंजीकरण से पहले रखें 
builder.Services.AddMiniAuth(options: (options) =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.DisableMiniAuthLogin = true;
});
```

#### डिफ़ॉल्ट SQLite कनेक्शन स्ट्रिंग को कस्टमाइज़ करें

```C#
builder.Services.AddMiniAuth(options: (options) =>
{
    options.SqliteConnectionString = "Data Source=miniauth_identity.db";
});
```



### कस्टम डेटाबेस, उपयोगकर्ता, और भूमिकाएँ

MiniAuth डिफ़ॉल्ट रूप से SQLite EF Core, IdentityUser, और IdentityRole के साथ सहजता से काम करने के लिए डिज़ाइन किया गया है। यदि आपको स्विच करने की आवश्यकता है, तो कृपया `app.UseMiniAuth` में जेनेरिक्स का उपयोग करके अलग डेटाबेस और अपने स्वयं के उपयोगकर्ता और भूमिका क्लासेस निर्दिष्ट करें।

```C#
app.UseMiniAuth<YourDbContext, YourIdentityUser, YourIdentityRole>();
```



### लॉगिन, उपयोगकर्ता प्रमाणीकरण

गैर-ApiController के लिए, डिफ़ॉल्ट लॉगिन रीडायरेक्शन login.html पेज पर होता है (यह Headers["X-Requested-With"] == "XMLHttpRequest" या ApiControllerAttribute की उपस्थिति की जांच करके निर्धारित किया जाता है)।
ApiController के रूप में चिह्नित कंट्रोलर्स डिफ़ॉल्ट रूप से लॉगिन पेज पर रीडायरेक्ट नहीं करते हैं; इसके बजाय, वे 401 स्टेटस कोड लौटाते हैं।

### कस्टम फ्रंटएंड

- एडमिन डैशबोर्ड फ्रंटएंड `/src/Frontend_Identity` में स्थित है और मुख्य रूप से Vue3 + Vite का उपयोग करता है। `npm run build` चलाने से miniauth UI अपडेट हो जाएगा।
- यदि आप डिफ़ॉल्ट miniauth लॉगिन पेज का उपयोग नहीं करना चाहते हैं, तो MVC आपको identity द्वारा प्रदान किए गए scaffolded Login.cshtml का उपयोग करने की अनुमति देता है, या आप miniauth फ्रंटएंड में login.html, js, और css फाइलों को संशोधित कर सकते हैं।

### कस्टम रूट प्रीफिक्स

```
builder.Services.AddMiniAuth(options: (options) =>
{
    options.RoutePrefix = "YourName";
});
```

डिफ़ॉल्ट RoutePrefix `MiniAuth` है।



### लॉगिन API (JWT)

API: `/MiniAuth/login`

बॉडी:

```json
{
   "username":"admin@mini-software.github.io",
   "password":"E7c4f679-f379-42bf-b547-684d456bc37f",
   "remember":false
}
```

रिस्पॉन्स: 

```json
{
    "ok": true,
    "code": 200,
    "message": null,
    "data": {
        "tokenType": "Bearer",
        "accessToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiYWRtaW5AbWluaS1zb2Z0d2FyZS5naXRodWIuaW8iLCJyb2xlIjoibWluaWF1dGgtYWRtaW4iLCJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyNTc5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.rgAgsziAdLqOC9NYra-M9WQl8BJ99sRdfzRKNkMz9dk",
        "expiresIn": 3600,
        "refreshToken": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxZTIxOGY4My1iZjE3LTRhY2YtODhmOS1iOTQ3NjhjOWUwMGMiLCJuYmYiOjE3MTg1MjIxOTEsImV4cCI6MTcxODUyMzk5MSwiaWF0IjoxNzE4NTIyMTkxLCJpc3MiOiJNaW5pQXV0aCJ9.HYBWrM2suDiM4OG0FSlXhNgktZIG9l3ufmIAnwZiIoU"
    }
}
```



### पंजीकरण

कृपया ASP.NET Core Identity द्वारा प्रदान किए गए बिल्ट-इन पंजीकरण API और पेज का उपयोग करें।

### पासवर्ड भूल गए

कृपया ASP.NET Core Identity द्वारा प्रदान किए गए बिल्ट-इन पासवर्ड भूल गए API और पेज का उपयोग करें।

### उपयोगकर्ता जानकारी प्राप्त करें

कृपया उपयोगकर्ता जानकारी प्राप्त करने के लिए ASP.NET Core Identity द्वारा प्रदान किए गए बिल्ट-इन API और पेज का उपयोग करें। ध्यान दें कि अपनी विशिष्ट एप्लिकेशन आवश्यकताओं के अनुसार आवश्यक उपयोगकर्ता डेटा को उजागर करने के लिए आपको अतिरिक्त लॉजिक या एंडपॉइंट्स लागू करने की आवश्यकता हो सकती है। ASP.NET Core Identity उपयोगकर्ता जानकारी प्रबंधन, प्रोफ़ाइल डेटा, भूमिकाएँ, और दावों के लिए एक मजबूत ढांचा प्रदान करता है।

### नोट्स

#### क्रम पर ध्यान दें

कृपया UseMiniAuth को रूट जनरेशन के बाद रखें, अन्यथा सिस्टम अनुमति जांच के लिए रूटिंग डेटा प्राप्त नहीं कर सकता, जैसा कि नीचे है:

```c#
app.UseRouting();
app.UseMiniAuth();
```

#### ध्यान दें: कृपया भूमिका नियम जोड़ें

कृपया `AddRoles<IdentityRole>()` जोड़ें, अन्यथा `[Authorize(Roles = "permission")]` प्रभावी नहीं होगा।

```C#
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // ❗❗❗ 
    .AddEntityFrameworkStores<ApplicationDbContext>();
```

### कस्टम लॉजिक के साथ मौजूदा Identity प्रोजेक्ट में MiniAuth को एकीकृत करना

AddMiniAuth के autoUse को अक्षम करें, और अपने स्वयं के प्रमाणीकरण के बाद UseMiniAuth को रखें, और जेनेरिक पैरामीटर्स को अपने IdentityDBContext, उपयोगकर्ता, और अनुमति प्रमाणीकरण से बदलें। एक उदाहरण:

```csharp
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddControllersWithViews();

            builder.Services.AddMiniAuth(autoUse: false); // <= ❗❗❗


            var app = builder.Build();

            app.UseMiniAuth<ApplicationDbContext, IdentityUser, IdentityRole>();  // <= ❗❗❗ 
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
```

यह आपको अपने स्वयं के उपयोगकर्ता, भूमिकाएँ, डेटाबेस, और Identity लॉजिक का उपयोग करने की सुविधा देता है।



#### डिस्ट्रीब्यूटेड सिस्टम्स

- डेटाबेस स्रोतों के लिए, SQL Server, MySQL, PostgreSQL आदि जैसे डेटाबेस में स्विच करने पर विचार करें।
- डिस्ट्रीब्यूटेड वातावरण में बेहतर एकीकरण के लिए JWT जैसे प्रमाणीकरण तरीकों में स्विच करने की सलाह दी जाती है।

### रिलीज़ नोट्स

अपडेट के लिए [रिलीज़ नोट्स](releases) देखें।

### TODO

लिंक: [MiniAuth.Identify project](https://github.com/orgs/mini-software/projects/7/views/1)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---