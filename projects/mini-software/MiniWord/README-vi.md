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
 Việc bạn <a href="https://github.com/mini-software/MiniWord">Star</a> và <a href="https://miniexcel.github.io">ủng hộ</a> có thể giúp MiniWord trở nên tốt hơn
</div>

---

## Giới thiệu

MiniWord là một thư viện tạo mẫu Word cho .NET dễ sử dụng và hiệu quả.

![image](https://user-images.githubusercontent.com/12729184/190835307-6cd87982-b5f3-4a79-9682-bdd1cc02a4ea.png)



## Bắt đầu

### Cài đặt

- liên kết nuget : https://www.nuget.org/packages/MiniWord

### Khởi động nhanh

Template tuân thủ thiết kế "CÁI GÌ bạn thấy là cái bạn nhận được", và hoàn toàn giữ nguyên định dạng thẻ mẫu.

```csharp
var value = new Dictionary<string, object>(){["title"] = "Hello MiniWord"};
MiniSoftware.MiniWord.SaveAsByTemplate(outputPath, templatePath, value);
```

![image](https://user-images.githubusercontent.com/12729184/190875707-6c5639ab-9518-4dc1-85d8-81e20af465e8.png)

### Đầu vào, đầu ra

- Đầu vào hỗ trợ đường dẫn file, byte[]
- Đầu ra hỗ trợ đường dẫn file, byte[], stream

```csharp
SaveAsByTemplate(string path, string templatePath, Dictionary<string, object> value)
SaveAsByTemplate(string path, byte[] templateBytes, Dictionary<string, object> value)
SaveAsByTemplate(this Stream stream, string templatePath, Dictionary<string, object> value)
SaveAsByTemplate(this Stream stream, byte[] templateBytes, Dictionary<string, object> value)
```



## Thẻ

Định dạng chuỗi mẫu MiniWord giống như Vue, React `{{tag}}`, người dùng chỉ cần đảm bảo tên thẻ và key của tham số value giống nhau thì hệ thống sẽ tự động thay thế.

### Văn bản

```csharp
{{tag}}
```

##### Ví dụ

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

##### Mẫu

![image](https://user-images.githubusercontent.com/12729184/190834360-39b4b799-d523-4b7e-9331-047a61fd5eb9.png)

##### Kết quả

![image](https://user-images.githubusercontent.com/12729184/190834455-ba065211-0f9d-41d1-9b7a-5d9e96ac2eff.png)

### Hình ảnh

Kiểu giá trị là `MiniWordPicture`

##### Ví dụ

```csharp
var value = new Dictionary<string, object>()
{
    ["Logo"] = new MiniWordPicture() { Path= PathHelper.GetFile("DemoLogo.png"), Width= 180, Height= 180 }
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```



##### Mẫu

![image](https://user-images.githubusercontent.com/12729184/190647953-6f9da393-e666-4658-a56d-b3a7f13c0ea1.png)

##### Kết quả

![image](https://user-images.githubusercontent.com/12729184/190648179-30258d82-723d-4266-b711-43f132d1842d.png)

### Danh sách

Giá trị thẻ là kiểu `string[]` hoặc `IList<string>`

##### Ví dụ

```csharp
var value = new Dictionary<string, object>()
{
    ["managers"] = new[] { "Jack" ,"Alan"},
    ["employees"] = new[] { "Mike" ,"Henry"},
};
MiniWord.SaveAsByTemplate(path, templatePath, value);
```

Mẫu

![image](https://user-images.githubusercontent.com/12729184/190645513-230c54f3-d38f-47af-b844-0c8c1eff2f52.png)

##### Kết quả

![image](https://user-images.githubusercontent.com/12729184/190645704-1f6405e9-71e3-45b9-aa99-2ba52e5e1519.png)

### Bảng

Giá trị thẻ là kiểu `IEmerable<Dictionary<string,object>>`

##### Ví dụ

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

##### Mẫu

![image](https://user-images.githubusercontent.com/12729184/190843632-05bb6459-f1c1-4bdc-a79b-54889afdfeea.png)


##### Kết quả

![image](https://user-images.githubusercontent.com/12729184/190843663-c00baf16-21f2-4579-9d08-996a2c8c549b.png)

### Danh sách lồng nhau

Giá trị thẻ là kiểu `IEnumerable<MiniWordForeach>`. Cần thêm các thẻ `{{foreach` và `endforeach}}` vào mẫu.

##### Ví dụ

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

##### Mẫu

![before_foreach](https://raw.githubusercontent.com/mini-software/MiniWord/main/user-images.githubusercontent.com/38832863/220123955-063c9345-3998-4fd7-982c-8d1e3b48bbf8.PNG)

<img width="755" alt="Screenshot 2023-08-08 at 17 59 37" src="https://raw.githubusercontent.com/mini-software/MiniWord/main/github.com/mini-software/MiniWord/assets/38832863/7811bf53-48cf-4fa4-85d7-d98663feb119">

##### Kết quả

![after_foreach](https://raw.githubusercontent.com/mini-software/MiniWord/main/user-images.githubusercontent.com/38832863/220123960-913a7140-2fa2-415e-bb3e-456e04167382.PNG)

<img width="755" alt="Screenshot 2023-08-08 at 18 00 15" src="https://raw.githubusercontent.com/mini-software/MiniWord/main/github.com/mini-software/MiniWord/assets/38832863/9e1afcf7-64b1-441c-8488-9ea2bd3114a1">

### Câu lệnh If trong mẫu

Đối với nhiều đoạn văn, sử dụng thẻ @if và @endif.  
Đối với một đoạn văn và bên trong foreach, sử dụng thẻ `{{if` và `endif}}` theo yêu cầu của mẫu.

##### Ví dụ

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

##### Mẫu cho nhiều đoạn văn

![before_if](https://raw.githubusercontent.com/mini-software/MiniWord/main/user-images.githubusercontent.com/38832863/220125429-7dd6ce94-35c6-478e-8903-064f9cf9361a.PNG)

##### Kết quả cho nhiều đoạn văn

![after_if](https://raw.githubusercontent.com/mini-software/MiniWord/main/user-images.githubusercontent.com/38832863/220125435-72ea24b4-2412-45de-961a-ad4b2134417b.PNG)

##### Mẫu cho một đoạn văn

<img width="931" alt="Screenshot 2023-08-08 at 17 55 46" src="https://raw.githubusercontent.com/mini-software/MiniWord/main/github.com/mini-software/MiniWord/assets/38832863/2adea468-a9c1-422f-a270-167086bc4ba3">

##### Kết quả cho một đoạn văn

<img width="536" alt="Screenshot 2023-08-08 at 17 56 47" src="https://raw.githubusercontent.com/mini-software/MiniWord/main/github.com/mini-software/MiniWord/assets/38832863/01f71c0f-eee0-4189-8510-abe063126514">

### ColorText

##### Ví dụ

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


## Khác

### Tham số POCO hoặc dynamic

v0.5.0 hỗ trợ tham số POCO hoặc dynamic

```csharp
var value = new { title = "Hello MiniWord" };
MiniWord.SaveAsByTemplate(outputPath, templatePath, value);
```

### FontColor và HighlightColor
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

### HyperLink

Nếu kiểu giá trị là `MiniWordHyperLink` hệ thống sẽ thay thế chuỗi mẫu bằng liên kết.

* Url: Đường dẫn URI của HyperLink
* Text: Mô tả

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



## Ví dụ



#### Xuất API ASP.NET Core 3.1

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
```csharp
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

## Hỗ trợ : [Liên kết Ủng hộ](https://miniexcel.github.io/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---