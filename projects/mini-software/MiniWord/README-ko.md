<div align="center">
<p><a href="https://www.nuget.org/packages/MiniWord"><img src="https://img.shields.io/nuget/v/MiniWord.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniWord"><img src="https://img.shields.io/nuget/dt/MiniWord.svg" alt=""></a>
<a href="https://github.com/mini-software/MiniWord" rel="nofollow"><img src="https://img.shields.io/github/stars/mini-software/MiniWord?logo=github" alt="GitHub stars"></a>
<a href="https://www.nuget.org/packages/MiniWord"><img src="https://img.shields.io/badge/.NET-%3E%3D%204.5-red.svg" alt="version"></a>
<a href="https://deepwiki.com/mini-software/MiniWord"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
</p>
</div>

---

<div align="center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a></strong></p>
</div>

---

<div align="center">
 당신의 <a href="https://github.com/mini-software/MiniWord">Star</a> 와 <a href="https://miniexcel.github.io">dotnate</a> 는 MiniWord를 더 좋게 만듭니다
</div>

---

## 소개

MiniWord는 쉽고 효율적인 .NET 워드 템플릿 라이브러리입니다.

![image](https://user-images.githubusercontent.com/12729184/190835307-6cd87982-b5f3-4a79-9682-bdd1cc02a4ea.png)



## 시작하기

### 설치

- nuget 링크 : https://www.nuget.org/packages/MiniWord

### 빠른 시작

템플릿은 "보이는 것이 결과물" 디자인을 따르며, 템플릿 태그 스타일이 완전히 보존됩니다.

```csharp
var value = new Dictionary<string, object>(){["title"] = "Hello MiniWord"};
MiniSoftware.MiniWord.SaveAsByTemplate(outputPath, templatePath, value);
```

![image](https://user-images.githubusercontent.com/12729184/190875707-6c5639ab-9518-4dc1-85d8-81e20af465e8.png)

### 입력, 출력

- 입력: 파일 경로, byte[] 지원
- 출력: 파일 경로, byte[], stream 지원

```csharp
SaveAsByTemplate(string path, string templatePath, Dictionary<string, object> value)
SaveAsByTemplate(string path, byte[] templateBytes, Dictionary<string, object> value)
SaveAsByTemplate(this Stream stream, string templatePath, Dictionary<string, object> value)
SaveAsByTemplate(this Stream stream, byte[] templateBytes, Dictionary<string, object> value)
```



## 태그

MiniWord 템플릿의 문자열 형식은 Vue, React의 `{{tag}}`와 유사하며, 사용자는 태그와 value 파라미터의 key만 일치시켜주면 시스템이 자동으로 치환해줍니다.

### 텍스트

```csharp
{{tag}}
```

##### 예제

```csharp
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["Department"] = "IT Department",
    ["Purpose"] = "Shanghai site needs a new system to control HR system.",
    ["StartDate"] = DateTime.Parse("2022-09-07 08:30:00"),
    ["EndDate"] = DateTime.Parse("2022-09-15 15:30:00"),
    ["Approved"] = true,
    ["Total_Amount"] = 123456,
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

##### 템플릿

![image](https://user-images.githubusercontent.com/12729184/190834360-39b4b799-d523-4b7e-9331-047a61fd5eb9.png)

##### 결과

![image](https://user-images.githubusercontent.com/12729184/190834455-ba065211-0f9d-41d1-9b7a-5d9e96ac2eff.png)

### 이미지

Value 타입은 `MiniWordPicture` 입니다

##### 예제

```csharp
var value = new Dictionary<string, object>()
{
    ["Logo"] = new MiniWordPicture() { Path= PathHelper.GetFile("DemoLogo.png"), Width= 180, Height= 180 }
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```



##### 템플릿

![image](https://user-images.githubusercontent.com/12729184/190647953-6f9da393-e666-4658-a56d-b3a7f13c0ea1.png)

##### 결과

![image](https://user-images.githubusercontent.com/12729184/190648179-30258d82-723d-4266-b711-43f132d1842d.png)

### 리스트

태그 값은 `string[]` 또는 `IList<string>` 타입입니다

##### 예제

```csharp
var value = new Dictionary<string, object>()
{
    ["managers"] = new[] { "Jack" ,"Alan"},
    ["employees"] = new[] { "Mike" ,"Henry"},
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

템플릿

![image](https://user-images.githubusercontent.com/12729184/190645513-230c54f3-d38f-47af-b844-0c8c1eff2f52.png)

##### 결과

![image](https://user-images.githubusercontent.com/12729184/190645704-1f6405e9-71e3-45b9-aa99-2ba52e5e1519.png)

### 테이블

태그 값은 `IEmerable<Dictionary<string,object>>` 타입입니다

##### 예제

```csharp
var value = new Dictionary<string, object>()
{
    ["TripHs"] = new List<Dictionary<string, object>>
    {
        new Dictionary<string, object>
        {
            { "sDate",DateTime.Parse("2022-09-08 08:30:00")},
            { "eDate",DateTime.Parse("2022-09-08 15:00:00")},
            { "How","Discussion requirement part1"},
            { "Photo",new MiniWordPicture() { Path = PathHelper.GetFile("DemoExpenseMeeting02.png"), Width = 160, Height = 90 }},
        },
        new Dictionary<string, object>
        {
            { "sDate",DateTime.Parse("2022-09-09 08:30:00")},
            { "eDate",DateTime.Parse("2022-09-09 17:00:00")},
            { "How","Discussion requirement part2 and development"},
            { "Photo",new MiniWordPicture() { Path = PathHelper.GetFile("DemoExpenseMeeting01.png"), Width = 160, Height = 90 }},
        },
    }
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

##### 템플릿

![image](https://user-images.githubusercontent.com/12729184/190843632-05bb6459-f1c1-4bdc-a79b-54889afdfeea.png)


##### 결과

![image](https://user-images.githubusercontent.com/12729184/190843663-c00baf16-21f2-4579-9d08-996a2c8c549b.png)

### 리스트 안의 리스트

태그 값은 `IEnumerable<MiniWordForeach>` 타입입니다. 템플릿에 `{{foreach` 와 `endforeach}}` 태그를 추가해야 합니다.

##### 예제

```csharp
var value = new Dictionary<string, object>()
{
    ["TripHs"] = new List<Dictionary<string, object>>
    {
        new Dictionary<string, object>
        {
            { "sDate", DateTime.Parse("2022-09-08 08:30:00") },
            { "eDate", DateTime.Parse("2022-09-08 15:00:00") },
            { "How", "Discussion requirement part1" },
            {
                "Details", new List<MiniWordForeach>()
                {
```csharp
                    new MiniWordForeach()
                    {
                        Value = new Dictionary<string, object>()
                        {
                            {"Text", "Air"},
                            {"Value", "Airplane"}
                        },
                        Separator = " | "
                    },
                    new MiniWordForeach()
                    {
                        Value = new Dictionary<string, object>()
                        {
                            {"Text", "Parking"},
                            {"Value", "Car"}
                        },
                        Separator = " / "
                    }
                }
            }
        }
    }
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

##### 템플릿

![before_foreach](https://raw.githubusercontent.com/mini-software/MiniWord/main/user-images.githubusercontent.com/38832863/220123955-063c9345-3998-4fd7-982c-8d1e3b48bbf8.PNG)

<img width="755" alt="Screenshot 2023-08-08 at 17 59 37" src="https://raw.githubusercontent.com/mini-software/MiniWord/main/github.com/mini-software/MiniWord/assets/38832863/7811bf53-48cf-4fa4-85d7-d98663feb119">

##### 결과

![after_foreach](https://raw.githubusercontent.com/mini-software/MiniWord/main/user-images.githubusercontent.com/38832863/220123960-913a7140-2fa2-415e-bb3e-456e04167382.PNG)

<img width="755" alt="Screenshot 2023-08-08 at 18 00 15" src="https://raw.githubusercontent.com/mini-software/MiniWord/main/github.com/mini-software/MiniWord/assets/38832863/9e1afcf7-64b1-441c-8488-9ea2bd3114a1">

### 템플릿 내 if 문

여러 문단의 경우, @if 및 @endif 태그를 사용합니다.  
단일 문단 및 foreach 내부에서는 `{{if` 와 `endif}}` 태그를 사용하여 템플릿에 조건문을 작성할 수 있습니다.

##### 예시

```csharp
var value = new Dictionary<string, object>()
{
    ["Name"] = new List<MiniWordHyperLink>(){
        new MiniWordHyperLink(){
            Url = "https://google.com",
            Text = "測試連結22!!"
        },
        new MiniWordHyperLink(){
            Url = "https://google1.com",
            Text = "測試連結11!!"
        }
    },
    ["Company_Name"] = "MiniSofteware",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123,
    ["APP"] = "Demo APP",
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

##### 다중 문단 템플릿

![before_if](https://raw.githubusercontent.com/mini-software/MiniWord/main/user-images.githubusercontent.com/38832863/220125429-7dd6ce94-35c6-478e-8903-064f9cf9361a.PNG)

##### 다중 문단 결과

![after_if](https://raw.githubusercontent.com/mini-software/MiniWord/main/user-images.githubusercontent.com/38832863/220125435-72ea24b4-2412-45de-961a-ad4b2134417b.PNG)

##### 단일 문단 템플릿

<img width="931" alt="Screenshot 2023-08-08 at 17 55 46" src="https://raw.githubusercontent.com/mini-software/MiniWord/main/github.com/mini-software/MiniWord/assets/38832863/2adea468-a9c1-422f-a270-167086bc4ba3">

##### 단일 문단 결과

<img width="536" alt="Screenshot 2023-08-08 at 17 56 47" src="https://raw.githubusercontent.com/mini-software/MiniWord/main/github.com/mini-software/MiniWord/assets/38832863/01f71c0f-eee0-4189-8510-abe063126514">

### ColorText

##### 예시

```csharp
var value = new
{
    Company_Name = new MiniWordColorText { Text = "MiniSofteware", FontColor = "#eb70AB", },
    Name = new[] {
        new MiniWordColorText { Text = "Ja", HighlightColor = "#eb70AB" },
        new MiniWordColorText { Text = "ck", HighlightColor = "#a56abe" }
    },
    CreateDate = new MiniWordColorText
    {
        Text = new DateTime(2021, 01, 01).ToString(),
        HighlightColor = "#eb70AB",
        FontColor = "#ffffff",
    },
    VIP = true,
    Points = 123,
    APP = "Demo APP",
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```


## 기타

### POCO 또는 dynamic 파라미터

v0.5.0에서는 POCO 또는 dynamic 파라미터를 지원합니다.

```csharp
var value = new { title = "Hello MiniWord" };
MiniWord.SaveAsByTemplate(outputPath, templatePath, value);
```

### FontColor 및 HighlightColor
```csharp
var value = new
{
    Company_Name = new MiniWordColorText { Text = "MiniSofteware", FontColor = "#eb70AB" },
    Name = new MiniWordColorText { Text = "Jack", HighlightColor = "#eb70AB" },
    CreateDate = new MiniWordColorText { Text = new DateTime(2021, 01, 01).ToString(), HighlightColor = "#eb70AB", FontColor = "#ffffff" },
    VIP = true,
    Points = 123,
    APP = "Demo APP",
};
```

### 하이퍼링크

값 타입이 `MiniWordHyperLink`일 경우 시스템은 템플릿 문자열을 하이퍼링크로 대체합니다.

* Url： 하이퍼링크 URI 타겟 경로
* Text：설명

```csharp
var value = new
{
    ["Name"] = new MiniWordHyperLink(){
        Url = "https://google.com",
        Text = "Test Link!!"
    },
    ["Company_Name"] = "MiniSofteware",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123,
    ["APP"] = "Demo APP",
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```



## 예제



#### ASP.NET Core 3.1 API 내보내기

```cs
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using MiniSoftware;

public class Program
{
    public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
}

public class Startup
{
    public void ConfigureServices(IServiceCollection services) => services.AddMvc();
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseStaticFiles();
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=api}/{action=Index}/{id?}");
        });
    }
}

public class ApiController : Controller
```
{
    public IActionResult Index()
    {
        return new ContentResult
        {
            ContentType = "text/html",
            StatusCode = (int)HttpStatusCode.OK,
            Content = @"<html><body>
<a href='api/DownloadWordFromTemplatePath'>DownloadWordFromTemplatePath</a><br>
<a href='api/DownloadWordFromTemplateBytes'>DownloadWordFromTemplateBytes</a><br>
</body></html>"
        };
    }

    static Dictionary<string, object> defaultValue = new Dictionary<string, object>()
    {
        ["title"] = "FooCompany",
        ["managers"] = new List<Dictionary<string, object>> {
            new Dictionary<string, object>{{"name","Jack"},{ "department", "HR" } },
            new Dictionary<string, object> {{ "name", "Loan"},{ "department", "IT" } }
        },
        ["employees"] = new List<Dictionary<string, object>> {
            new Dictionary<string, object>{{ "name", "Wade" },{ "department", "HR" } },
            new Dictionary<string, object> {{ "name", "Felix" },{ "department", "HR" } },
            new Dictionary<string, object>{{ "name", "Eric" },{ "department", "IT" } },
            new Dictionary<string, object> {{ "name", "Keaton" },{ "department", "IT" } }
        }
    };

    public IActionResult DownloadWordFromTemplatePath()
    {
        string templatePath = "TestTemplateComplex.docx";

        Dictionary<string, object> value = defaultValue;

        MemoryStream memoryStream = new MemoryStream();
        MiniWord.SaveAsByTemplate(memoryStream, templatePath, value);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.wordprocessingml.document")
        {
            FileDownloadName = "demo.docx"
        };
    }

    private static Dictionary<string, Byte[]> TemplateBytesCache = new Dictionary<string, byte[]>();

    static ApiController()
    {
        string templatePath = "TestTemplateComplex.docx";
        byte[] bytes = System.IO.File.ReadAllBytes(templatePath);
        TemplateBytesCache.Add(templatePath, bytes);
    }

    public IActionResult DownloadWordFromTemplateBytes()
    {
        byte[] bytes = TemplateBytesCache["TestTemplateComplex.docx"];

        Dictionary<string, object> value = defaultValue;

        MemoryStream memoryStream = new MemoryStream();
        MiniWord.SaveAsByTemplate(memoryStream, bytes, value);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.wordprocessingml.document")
        {
            FileDownloadName = "demo.docx"
        };
    }
}
```






## 지원 : [기부 링크](https://miniexcel.github.io/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---