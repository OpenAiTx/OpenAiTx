<div style="text-align: center">
<p><a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/v/MiniExcel.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/dt/MiniExcel.svg" alt=""></a>
<a href="https://ci.appveyor.com/project/mini-software/miniexcel/branch/master"><img src="https://ci.appveyor.com/api/projects/status/b2vustrwsuqx45f4/branch/master?svg=true" alt="Build status"></a>
<a href="https://gitee.com/dotnetchina/MiniExcel"><img src="https://gitee.com/dotnetchina/MiniExcel/badge/star.svg" alt="star"></a> <a href="https://github.com/mini-software/MiniExcel" rel="nofollow"><img src="https://img.shields.io/github/stars/mini-software/MiniExcel?logo=github" alt="GitHub stars"></a>
<a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/badge/.NET-%3E%3D%204.5-red.svg" alt="version"></a>
<a href="https://deepwiki.com/mini-software/MiniExcel"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
</p>
</div>

---

[<img align="right" src="https://github.com/dotnet-foundation/swag/blob/main/logo/dotnetfoundation_v4.png?raw=true" width="100" />](https://www.dotnetfoundation.org/)

<div style="text-align: center">
<p>यह प्रोजेक्ट <a href="https://www.dotnetfoundation.org/">.NET Foundation</a> का हिस्सा है और इनके <a href="https://www.dotnetfoundation.org/code-of-conduct">code of conduct</a> के अंतर्गत संचालित होता है। </p>
</div>

---

<div style="text-align: center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a></strong></p>
</div>

---

<div style="text-align: center">
 आपका <a href="https://github.com/mini-software/MiniExcel">Star</a> और <a href="https://miniexcel.github.io">Donate</a> MiniExcel को बेहतर बना सकता है
</div>

---

### परिचय

MiniExcel एक सरल और कुशल .NET एक्सेल प्रोसेसिंग टूल है जो OOM से बचाता है।

वर्तमान में, अधिकांश लोकप्रिय फ्रेमवर्क्स को संचालन को सुविधाजनक बनाने के लिए सारा डेटा मेमोरी में लोड करना पड़ता है, जिससे मेमोरी की खपत की समस्या होती है। MiniExcel स्ट्रीम से एल्गोरिदम का उपयोग करने की कोशिश करता है ताकि मूल 1000 MB के उपयोग को कुछ MB तक कम किया जा सके और OOM (out of memory) से बचा जा सके।

![image](https://user-images.githubusercontent.com/12729184/113086657-ab8bd000-9214-11eb-9563-c970ac1ee35e.png)

### विशेषताएँ

- कम मेमोरी खपत, OOM (out of memory) और full GC से बचाव
- प्रत्येक डेटा पंक्ति का रीयल-टाइम संचालन समर्थित
- LINQ डिफर्ड निष्पादन का समर्थन, जिससे कम-खपत, तेज पेजिंग और अन्य जटिल क्वेरीज़ संभव
- हल्का, Microsoft Office इंस्टॉल किए बिना, कोई COM+ नहीं, DLL आकार 400KB से कम
- एक्सेल पढ़ने/लिखने/भरने के लिए आसान API शैली

### शुरुआत करें

- [Excel इंपोर्ट/क्वेरी करें](#getstart1)

- [Excel एक्सपोर्ट/क्रिएट करें](#getstart2)

- [Excel टेम्पलेट](#getstart3)

- [Excel कॉलम नाम/इंडेक्स/इग्नोर एट्रीब्यूट](#getstart4)

- [उदाहरण](#getstart5)

### इंस्टॉलेशन

आप पैकेज [NuGet से इंस्टॉल](https://www.nuget.org/packages/MiniExcel) कर सकते हैं

### रिलीज़ नोट्स

कृपया [रिलीज़ नोट्स](docs) देखें

### TODO

कृपया देखें  [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true)

### प्रदर्शन

बेंचमार्क के लिए कोड [MiniExcel.Benchmarks](benchmarks/MiniExcel.Benchmarks/Program.cs) में पाया जा सकता है।

प्रदर्शन परीक्षण के लिए उपयोग की गई फ़ाइल है [**Test1,000,000x10.xlsx**](benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx), एक 32MB दस्तावेज जिसमें 1,000,000 पंक्तियाँ * 10 कॉलम हैं, जिनकी सेल्स "HelloWorld" स्ट्रिंग से भरी हैं।

सभी बेंचमार्क चलाने के लिए:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

आप नवीनतम रिलीज़ के लिए बेंचमार्क परिणाम [यहाँ](benchmarks/results) देख सकते हैं।

### एक्सेल क्वेरी/इंपोर्ट  <a name="getstart1"></a>

#### 1. एक क्वेरी निष्पादित करें और परिणामों को स्ट्रॉन्गली टाइप्ड IEnumerable में मैप करें [[Try it]](https://dotnetfiddle.net/w5WD1J)

बेहतर दक्षता के लिए Stream.Query का उपयोग करने की सिफारिश की जाती है।

```csharp
public class UserAccount
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public DateTime BoD { get; set; }
    public int Age { get; set; }
    public bool VIP { get; set; }
    public decimal Points { get; set; }
}

var rows = MiniExcel.Query<UserAccount>(path);

// या

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. हेड का उपयोग किए बिना डायनामिक ऑब्जेक्ट्स की लिस्ट में क्वेरी मैप करें [[Try it]](https://dotnetfiddle.net/w5WD1J)

* डायनामिक की `A.B.C.D..` है

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp

var rows = MiniExcel.Query(path).ToList();

// या
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```

#### 3. पहले हैडर रो के साथ क्वेरी निष्पादित करें [[Try it]](https://dotnetfiddle.net/w5WD1J)

नोट: एक ही कॉलम नाम के लिए सबसे दाईं ओर वाला उपयोग होता है

इनपुट एक्सेल :

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// या

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```

#### 4. क्वेरी LINQ एक्सटेंशन First/Take/Skip ...आदि को सपोर्ट करती है

Query First
```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// या

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```

MiniExcel/ExcelDataReader/ClosedXML/EPPlus के बीच प्रदर्शन
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### 5. शीट नाम द्वारा क्वेरी करें

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//या
stream.Query(sheetName: "SheetName");
```

#### 6. सभी शीट नाम और पंक्तियाँ क्वेरी करें
```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. कॉलम प्राप्त करें

```csharp
var columns = MiniExcel.GetColumns(path); // उदाहरण : ["A","B"...]

var cnt = columns.Count;  // कॉलम की संख्या प्राप्त करें
```

#### 8. डायनामिक क्वेरी को `IDictionary<string,object>` में कास्ट करें

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// या
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// या निर्दिष्ट रेंज क्वेरी करें (कैपिटल में)
// A2 कॉलम A की दूसरी पंक्ति को दर्शाता है, C3 कॉलम C की तीसरी पंक्ति को दर्शाता है
// यदि आप पंक्तियों को प्रतिबंधित नहीं करना चाहते, तो संख्या शामिल न करें
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```



#### 9. एक्सेल क्वेरी का परिणाम DataTable के रूप में

अनुशंसित नहीं है, क्योंकि DataTable सभी डेटा को मेमोरी में लोड कर लेता है और MiniExcel की कम मेमोरी खपत की विशेषता खो देता है।

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)



#### 10. डेटा पढ़ना शुरू करने के लिए सेल निर्दिष्ट करें

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)



#### 11. मर्ज की गई सेल्स भरें

नोट: दक्षता `मर्ज भराव का उपयोग न करने` की तुलना में धीमी है

कारण: OpenXml मानक mergeCells को फाइल के अंत में रखता है, जिससे sheetxml को दो बार foreach करना पड़ता है

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

वैरिएबल लंबाई और चौड़ाई, मल्टी-रो और कॉलम भराव को सपोर्ट करता है

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. डिस्क-बेस कैश द्वारा बड़े फाइल पढ़ना (Disk-Base Cache - SharedString)

यदि SharedStrings का आकार 5 MB से अधिक है, तो MiniExcel डिफ़ॉल्ट रूप से लोकल डिस्क कैश का उपयोग करेगा, जैसे, [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx)(एक मिलियन पंक्तियों का डेटा), जब डिस्क कैश निष्क्रिय होता है तो अधिकतम मेमोरी उपयोग 195MB है, लेकिन सक्रिय डिस्क कैश केवल 65MB की आवश्यकता होती है। ध्यान दें, इस अनुकूलन के लिए कुछ दक्षता लागत की आवश्यकता होती है, तो इस मामले में पढ़ने का समय 7.4 सेकंड से 27.2 सेकंड तक बढ़ जाएगा, यदि आपको इसकी आवश्यकता नहीं है तो आप निम्न कोड से डिस्क कैश को निष्क्रिय कर सकते हैं:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

आप `SharedStringCacheSize` का उपयोग करके disk caching के लिए sharedString फाइल का आकार निर्दिष्ट कर सकते हैं:
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```


![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)









### एक्सेल बनाएं/निर्यात करें  <a name="getstart2"></a>

1. सार्वजनिक पैरामीटर रहित कंस्ट्रक्टर के साथ गैर-एब्सट्रैक्ट टाइप होना चाहिए।

2. MiniExcel IEnumerable Deferred Execution को सपोर्ट करता है, यदि आप न्यूनतम मेमोरी का उपयोग करना चाहते हैं, तो कृपया ToList जैसे मेथड्स का उपयोग न करें

उदाहरण : ToList या नहीं मेमोरी उपयोग
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)



#### 1. अनाम या स्ट्रॉन्गली टाइप [[Try it]](https://dotnetfiddle.net/w5WD1J)

```csharp
var path = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.xlsx");
MiniExcel.SaveAs(path, new[] {
    new { Column1 = "MiniExcel", Column2 = 1 },
    new { Column1 = "Github", Column2 = 2}
});
```

#### 2. `IEnumerable<IDictionary<string, object>>`

```csharp
var values = new List<Dictionary<string, object>>()
{
    new Dictionary<string,object>{{ "Column1", "MiniExcel" }, { "Column2", 1 } },
    new Dictionary<string,object>{{ "Column1", "Github" }, { "Column2", 2 } }
};
MiniExcel.SaveAs(path, values);
```

फाइल का परिणाम :

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


#### 3.  IDataReader
- `अनुशंसित`, यह सभी डेटा को मेमोरी में लोड करने से बचाता है
```csharp
MiniExcel.SaveAs(path, reader);
```

![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

DataReader से मल्टीपल शीट्स एक्सपोर्ट करें (Dapper ExecuteReader द्वारा अनुशंसित)

```csharp
using (var cnn = Connection)
{
    cnn.Open();
    var sheets = new Dictionary<string,object>();
    sheets.Add("sheet1", cnn.ExecuteReader("select 1 id"));
    sheets.Add("sheet2", cnn.ExecuteReader("select 2 id"));
    MiniExcel.SaveAs("Demo.xlsx", sheets);
}
```



#### 4. Datatable

- `अनुशंसित नहीं`, यह सभी डेटा को मेमोरी में लोड कर देता है

- DataTable पहले कॉलम नाम के लिए Caption का उपयोग करता है, फिर columname का

```csharp
var path = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.xlsx");
var table = new DataTable();
{
    table.Columns.Add("Column1", typeof(string));
    table.Columns.Add("Column2", typeof(decimal));
    table.Rows.Add("MiniExcel", 1);
    table.Rows.Add("Github", 2);
}

MiniExcel.SaveAs(path, table);
```

####  5. Dapper Query

धन्यवाद @shaofing #552, कृपया `CommandDefinition + CommandFlags.NoCache` का उपयोग करें

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // नोट: QueryAsync क्लोज़ कनेक्शन एक्सेप्शन फेंकेगा
    MiniExcel.SaveAs(path, rows);
```
```
}
```

नीचे दिया गया कोड सभी डेटा को मेमोरी में लोड करेगा

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(@"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2");
    MiniExcel.SaveAs(path, rows);
}
```


#### 6. मेमोरीस्ट्रीम में SaveAs करें  [[Try it]](https://dotnetfiddle.net/JOen0e)

```csharp
using (var stream = new MemoryStream()) //FileStream, MemoryStream आदि को सपोर्ट करता है।
{
    stream.SaveAs(values);
}
```

उदाहरण : एक्सपोर्ट एक्सेल के लिए एपीआई

```csharp
public IActionResult DownloadExcel()
{
    var values = new[] {
        new { Column1 = "MiniExcel", Column2 = 1 },
        new { Column1 = "Github", Column2 = 2}
    };

    var memoryStream = new MemoryStream();
    memoryStream.SaveAs(values);
    memoryStream.Seek(0, SeekOrigin.Begin);
    return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
    {
        FileDownloadName = "demo.xlsx"
    };
}
```


#### 7. मल्टीपल शीट्स बनाएं

```csharp
// 1. Dictionary<string,object>
var users = new[] { new { Name = "Jack", Age = 25 }, new { Name = "Mike", Age = 44 } };
var department = new[] { new { ID = "01", Name = "HR" }, new { ID = "02", Name = "IT" } };
var sheets = new Dictionary<string, object>
{
    ["users"] = users,
    ["department"] = department
};
MiniExcel.SaveAs(path, sheets);

// 2. DataSet
var sheets = new DataSet();
sheets.Add(UsersDataTable);
sheets.Add(DepartmentDataTable);
//..
MiniExcel.SaveAs(path, sheets);
```

![image](https://user-images.githubusercontent.com/12729184/118130875-6e7c4580-b430-11eb-9b82-22f02716bd63.png)


#### 8. TableStyles विकल्प

डिफ़ॉल्ट स्टाइल

![image](https://user-images.githubusercontent.com/12729184/138234373-cfa97109-b71f-4711-b7f5-0eaaa4a0a3a6.png)

स्टाइल कॉन्फ़िगरेशन के बिना

```csharp
var config = new OpenXmlConfiguration()
{
     TableStyles = TableStyles.None
};
MiniExcel.SaveAs(path, value,configuration:config);
```

![image](https://user-images.githubusercontent.com/12729184/118784917-f3e57700-b8c2-11eb-8718-8d955b1bc197.png)


#### 9. AutoFilter

v0.19.0 से `OpenXmlConfiguration.AutoFilter` ऑटोफिल्टर को सक्षम/अक्षम कर सकता है, डिफ़ॉल्ट मान `true` है, और ऑटोफिल्टर सेट करने का तरीका:

```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```



#### 10. इमेज बनाएं

```csharp
var value = new[] {
    new { Name="github",Image=File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png"))},
    new { Name="google",Image=File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png"))},
    new { Name="microsoft",Image=File.ReadAllBytes(PathHelper.GetFile("images/microsoft_logo.png"))},
    new { Name="reddit",Image=File.ReadAllBytes(PathHelper.GetFile("images/reddit_logo.png"))},
    new { Name="statck_overflow",Image=File.ReadAllBytes(PathHelper.GetFile("images/statck_overflow_logo.png"))},
};
MiniExcel.SaveAs(path, value);
```

![image](https://user-images.githubusercontent.com/12729184/150462383-ad9931b3-ed8d-4221-a1d6-66f799743433.png)



#### 11. बाइट ऐरे फाइल निर्यात

संस्करण 1.22.0 से, जब मान का प्रकार `byte[]` है, तब सिस्टम डिफ़ॉल्ट रूप से सेल में फाइल पथ सेव करेगा, और जब इम्पोर्ट किया जाएगा तो सिस्टम इसे `byte[]` में बदल सकता है। और यदि आप इसका उपयोग नहीं करना चाहते हैं, तो आप `OpenXmlConfiguration.EnableConvertByteArray` को `false` सेट कर सकते हैं, इससे सिस्टम की दक्षता बढ़ेगी।

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

संस्करण 1.22.0 से, जब मान का प्रकार `byte[]` है, तब सिस्टम डिफ़ॉल्ट रूप से सेल में फाइल पथ सेव करेगा, और जब इम्पोर्ट किया जाएगा तो सिस्टम इसे `byte[]` में बदल सकता है। और यदि आप इसका उपयोग नहीं करना चाहते हैं, तो आप `OpenXmlConfiguration.EnableConvertByteArray` को `false` सेट कर सकते हैं, इससे सिस्टम की दक्षता बढ़ेगी।

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### 12. एक जैसे सेल्स को वर्टिकली मर्ज करना

यह सुविधा केवल `xlsx` फॉर्मेट में समर्थित है और @merge और @endmerge टैग्स के बीच सेल्स को वर्टिकली मर्ज करती है।
आप @mergelimit का उपयोग करके वर्टिकल मर्जिंग की सीमा निर्धारित कर सकते हैं।

```csharp
var mergedFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid().ToString()}.xlsx");

var path = @"../../../../../samples/xlsx/TestMergeWithTag.xlsx";

MiniExcel.MergeSameCells(mergedFilePath, path);
```

```csharp
var memoryStream = new MemoryStream();

var path = @"../../../../../samples/xlsx/TestMergeWithTag.xlsx";

memoryStream.MergeSameCells(path);
```

मर्ज करने से पहले और बाद में फाइल की सामग्री:

मर्ज लिमिट के बिना:

<img width="318" alt="Screenshot 2023-08-07 at 11 59 24" src="https://github.com/mini-software/MiniExcel/assets/38832863/49cc96b9-6c35-4bf3-8d43-a9752a15b22e">

<img width="318" alt="Screenshot 2023-08-07 at 11 59 57" src="https://github.com/mini-software/MiniExcel/assets/38832863/3fbd529b-3ae6-4bbe-b4d8-2793a5a58010">

मर्ज लिमिट के साथ:

<img width="346" alt="Screenshot 2023-08-08 at 18 21 00" src="https://github.com/mini-software/MiniExcel/assets/38832863/04049d28-84d5-4c2a-bcff-5847547df5e1">

<img width="346" alt="Screenshot 2023-08-08 at 18 21 40" src="https://github.com/mini-software/MiniExcel/assets/38832863/f5cf8957-b0b0-4831-b8fc-8556299235c2">

#### 13. null मान छोड़ें

null मान के लिए खाली सेल लिखने के लिए नया स्पष्ट विकल्प:

```csharp
DataTable dt = new DataTable();

/* ... */

DataRow dr = dt.NewRow();

dr["Name1"] = "Somebody once";
dr["Name2"] = null;
dr["Name3"] = "told me.";

dt.Rows.Add(dr);

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = true // डिफ़ॉल्ट मान।
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://user-images.githubusercontent.com/31481586/241419455-3c0aec8a-4e5f-4d83-b7ec-6572124c165d.png)

```xml
<x:row r="2">
    <x:c r="A2" t ="str" s="2">
        <x:v>Somebody once</x:v>
    </x:c>
    <x:c r="B2" s="2"></x:c>
    <x:c r="C2" t ="str" s="2">
        <x:v>told me.</x:v>
    </x:c>
</x:row>
```

पिछला व्यवहार:

```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = false // डिफ़ॉल्ट मान true है।
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://user-images.githubusercontent.com/31481586/241419441-c4f27e8f-3f87-46db-a10f-08665864c874.png)

```xml
<x:row r="2">
    <x:c r="A2" t ="str" s="2">
        <x:v>Somebody once</x:v>
    </x:c>
    <x:c r="B2" t ="str" s="2">
        <x:v></x:v>
    </x:c>
    <x:c r="C2" t ="str" s="2">
        <x:v>told me.</x:v>
    </x:c>
</x:row>
```

null और DBNull मानों के लिए कार्य करता है।

#### 14. फ्रीज़ पेन (Freeze Panes)
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // डिफ़ॉल्ट 1 है
    FreezeColumnCount = 2   // डिफ़ॉल्ट 0 है
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/freeze-pane-1.png)


### एक्सेल टेम्पलेट में डेटा भरना <a name="getstart3"></a>

- डिक्लेरेशन Vue टेम्पलेट `{{variable name}}` की तरह है, या कलेक्शन रेंडरिंग `{{collection name.field name}}`
- कलेक्शन रेंडरिंग IEnumerable/DataTable/DapperRow को सपोर्ट करता है

#### 1. बेसिक फ़िल

टेम्पलेट:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

परिणाम:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

कोड:
```csharp
// 1. POCO द्वारा
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);


// 2. डिक्शनरी द्वारा
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 2. IEnumerable डेटा फ़िल

> नोट1: लिस्ट भरने के लिए एक ही कॉलम वाले पहले IEnumerable को आधार के रूप में उपयोग करें

टेम्पलेट:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

परिणाम:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

कोड:
```csharp
//1. POCO द्वारा
var value = new
{
    employees = new[] {
        new {name="Jack",department="HR"},
        new {name="Lisa",department="HR"},
        new {name="John",department="HR"},
        new {name="Mike",department="IT"},
        new {name="Neo",department="IT"},
        new {name="Loan",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);

//2. डिक्शनरी द्वारा
var value = new Dictionary<string, object>()
{
    ["employees"] = new[] {
        new {name="Jack",department="HR"},
        new {name="Lisa",department="HR"},
        new {name="John",department="HR"},
        new {name="Mike",department="IT"},
        new {name="Neo",department="IT"},
        new {name="Loan",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 3. जटिल डेटा फ़िल

> नोट: मल्टी-शीट्स और एक ही वैरिएबल का उपयोग सपोर्ट करता है

टेम्पलेट:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

परिणाम:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)

```csharp
// 1. POCO द्वारा
var value = new
{
    title = "FooCompany",
    managers = new[] {
        new {name="Jack",department="HR"},
        new {name="Loan",department="IT"}
    },
    employees = new[] {
        new {name="Wade",department="HR"},
        new {name="Felix",department="HR"},
        new {name="Eric",department="IT"},
        new {name="Keaton",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);

// 2. डिक्शनरी द्वारा
var value = new Dictionary<string, object>()
{
    ["title"] = "FooCompany",
    ["managers"] = new[] {
        new {name="Jack",department="HR"},
        new {name="Loan",department="IT"}
    },
    ["employees"] = new[] {
        new {name="Wade",department="HR"},
        new {name="Felix",department="HR"},
        new {name="Eric",department="IT"},
        new {name="Keaton",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```

#### 4. बड़े डेटा का प्रदर्शन भरना

> नोट: MiniExcel में IEnumerable डिफर्ड एक्जीक्यूशन (ToList नहीं) का उपयोग करने से अधिकतम मेमोरी उपयोग बचाया जा सकता है

![image](https://user-images.githubusercontent.com/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)



#### 5. सेल वैल्यू ऑटो मैपिंग टाइप

टेम्पलेट

![image](https://user-images.githubusercontent.com/114802504-64830a80-9dd0-11eb-8d56-8e8c401b3ace.png)

परिणाम

![image](https://user-images.githubusercontent.com/114802419-43221e80-9dd0-11eb-9ffe-a2ce34fe7076.png)

क्लास

```csharp
public class Poco
{
    public string @string { get; set; }
    public int? @int { get; set; }
```
```csharp
public decimal? @decimal { get; set; }
public double? @double { get; set; }
public DateTime? datetime { get; set; }
public bool? @bool { get; set; }
public Guid? Guid { get; set; }
}
```

कोड

```csharp
var poco = new TestIEnumerableTypePoco { @string = "string", @int = 123, @decimal = decimal.Parse("123.45"), @double = (double)123.33, @datetime = new DateTime(2021, 4, 1), @bool = true, @Guid = Guid.NewGuid() };
var value = new
{
    Ts = new[] {
        poco,
        new TestIEnumerableTypePoco{},
        null,
        poco
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 6. उदाहरण :  Github प्रोजेक्ट्स की सूची बनाना

टेम्पलेट

![image](https://user-images.githubusercontent.com/12729184/115068623-12073280-9f25-11eb-9124-f4b3efcdb2a7.png)


परिणाम

![image](https://user-images.githubusercontent.com/12729184/115068639-1a5f6d80-9f25-11eb-9f45-27c434d19a78.png)

कोड

```csharp
var projects = new[]
{
    new {Name = "MiniExcel",Link="https://github.com/mini-software/MiniExcel",Star=146, CreateTime=new DateTime(2021,03,01)},
    new {Name = "HtmlTableHelper",Link="https://github.com/mini-software/HtmlTableHelper",Star=16, CreateTime=new DateTime(2020,02,01)},
    new {Name = "PocoClassGenerator",Link="https://github.com/mini-software/PocoClassGenerator",Star=16, CreateTime=new DateTime(2019,03,17)}
};
var value = new
{
    User = "ITWeiHan",
    Projects = projects,
    TotalStar = projects.Sum(s => s.Star)
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```

#### 7. समूहबद्ध डेटा भरना

```csharp
var value = new Dictionary<string, object>()
{
    ["employees"] = new[] {
        new {name="Jack",department="HR"},
        new {name="Jack",department="HR"},
        new {name="John",department="HR"},
        new {name="John",department="IT"},
        new {name="Neo",department="IT"},
        new {name="Loan",department="IT"}
    }
};
await MiniExcel.SaveAsByTemplateAsync(path, templatePath, value);
```
##### 1. `@group` टैग के साथ और `@header` टैग के साथ

पहले

![before_with_header](https://user-images.githubusercontent.com/38832863/218646717-21b9d57a-2be2-4e9a-801b-ae212231d2b4.PNG)

बाद में

![after_with_header](https://user-images.githubusercontent.com/38832863/218646721-58a7a340-7004-4bc2-af24-cffcb2c20737.PNG)

##### 2. @group टैग के साथ लेकिन @header टैग के बिना

पहले

![before_without_header](https://user-images.githubusercontent.com/38832863/218646873-b12417fa-801b-4890-8e96-669ed3b43902.PNG)

बाद में

![after_without_header](https://user-images.githubusercontent.com/38832863/218646872-622461ba-342e-49ee-834f-b91ad9c2dac3.PNG)

##### 3. @group टैग के बिना

पहले

![without_group](https://user-images.githubusercontent.com/38832863/218646975-f52a68eb-e031-43b5-abaa-03b67c052d1a.PNG)

बाद में

![without_group_after](https://user-images.githubusercontent.com/38832863/218646974-4a3c0e07-7c66-4088-ad07-b4ad3695b7e1.PNG)

#### 8. सेल के अंदर If/ElseIf/Else स्टेटमेंट्स

नियम:
1. DateTime, Double, Int के लिए ==, !=, >, >=, <, <= ऑपरेटरों को सपोर्ट करता है।
2. String के लिए ==, != ऑपरेटरों को सपोर्ट करता है।
3. प्रत्येक स्टेटमेंट नई लाइन में होनी चाहिए।
4. ऑपरेटरों के पहले और बाद में एक स्पेस होना चाहिए।
5. स्टेटमेंट्स के अंदर नई लाइन नहीं होनी चाहिए।
6. सेल बिल्कुल नीचे दिए गए फॉर्मेट में होनी चाहिए।

```csharp
@if(name == Jack)
{{employees.name}}
@elseif(name == Neo)
Test {{employees.name}}
@else
{{employees.department}}
@endif
```

पहले

![if_before](https://user-images.githubusercontent.com/38832863/235360606-ca654769-ff55-4f5b-98d2-d2ec0edb8173.PNG)

बाद में

![if_after](https://user-images.githubusercontent.com/38832863/235360609-869bb960-d63d-45ae-8d64-9e8b0d0ab658.PNG)

#### 9. DataTable को पैरामीटर के रूप में उपयोग करना

```csharp
var managers = new DataTable();
{
    managers.Columns.Add("name");
    managers.Columns.Add("department");
    managers.Rows.Add("Jack", "HR");
    managers.Rows.Add("Loan", "IT");
}
var value = new Dictionary<string, object>()
{
    ["title"] = "FooCompany",
    ["managers"] = managers,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```
#### 10. सूत्र (Formulas)

##### 1. उदाहरण
अपने फॉर्मूला से पहले `$` लगाएं और `$enumrowstart` तथा `$enumrowend` का उपयोग करें, एन्यूमेरेबल के प्रारंभ और अंत पंक्तियों को संदर्भित करने के लिए:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-1.png)

जब टेम्पलेट रेंडर होता है, `$` प्रीफिक्स हटा दिया जाएगा और `$enumrowstart` व `$enumrowend` को एन्यूमेरेबल के प्रारंभ और अंत पंक्ति नंबरों से बदल दिया जाएगा:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-2.png)

##### 2. अन्य उदाहरण सूत्र:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| योग          | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| वैकल्पिक औसत | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| रेंज         | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |


#### 11. अन्य

##### 1. टेम्पलेट पैरामीटर कुंजी जांचना

V1.24.0 से, डिफ़ॉल्ट रूप से टेम्पलेट में अनुपस्थित पैरामीटर कुंजी को अनदेखा किया जाता है और उसे खाली स्ट्रिंग से बदल दिया जाता है, `IgnoreTemplateParameterMissing` यह नियंत्रित कर सकता है कि अपवाद (Exception) फेंके या नहीं।

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```

![image](https://user-images.githubusercontent.com/12729184/157464332-e316f829-54aa-4c84-a5aa-9aef337b668d.png)



### एक्सेल कॉलम नाम/इंडेक्स/इग्नोर एट्रिब्यूट <a name="getstart4"></a>



#### 1. कॉलम नाम, कॉलम इंडेक्स, कॉलम इग्नोर निर्दिष्ट करना

एक्सेल उदाहरण

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

कोड

```csharp
public class ExcelAttributeDemo
{
    [ExcelColumnName("Column1")]
```
```csharp
public string Test1 { get; set; }
[ExcelColumnName("Column2")]
public string Test2 { get; set; }
[ExcelIgnore]
public string Test3 { get; set; }
[ExcelColumnIndex("I")] // सिस्टम "I" को 8 इंडेक्स में बदल देगा
public string Test4 { get; set; }
public string Test5 { get; } //set के बिना इसे अनदेखा किया जाएगा
public string Test6 { get; private set; } //un-public set को अनदेखा किया जाएगा
[ExcelColumnIndex(3)] // 0 से शुरू होता है
public string Test7 { get; set; }
}

var rows = MiniExcel.Query<ExcelAttributeDemo>(path).ToList();
Assert.Equal("Column1", rows[0].Test1);
Assert.Equal("Column2", rows[0].Test2);
Assert.Null(rows[0].Test3);
Assert.Equal("Test7", rows[0].Test4);
Assert.Null(rows[0].Test5);
Assert.Null(rows[0].Test6);
Assert.Equal("Test4", rows[0].Test7);
```





#### 2. कस्टम फ़ॉर्मेट (ExcelFormatAttribute)

V0.21.0 से, उस क्लास को सपोर्ट करता है जिसमें `ToString(string content)` मेथड फॉर्मेट हो

क्लास

```csharp
public class Dto
{
    public string Name { get; set; }

    [ExcelFormat("MMMM dd, yyyy")]
    public DateTime InDate { get; set; }
}
```

कोड

```csharp
var value = new Dto[] {
    new Issue241Dto{ Name="Jack",InDate=new DateTime(2021,01,04)},
    new Issue241Dto{ Name="Henry",InDate=new DateTime(2020,04,05)},
};
MiniExcel.SaveAs(path, value);
```

परिणाम

![image](https://user-images.githubusercontent.com/12729184/118910788-ab2bcd80-b957-11eb-8d42-bfce36621b1b.png)

Query कस्टम फॉर्मेट रूपांतरण को सपोर्ट करता है

![image](https://user-images.githubusercontent.com/12729184/118911286-87b55280-b958-11eb-9a88-c8ff403d240a.png)

#### 3. कॉलम चौड़ाई सेट करें (ExcelColumnWidthAttribute)

```csharp
public class Dto
{
    [ExcelColumnWidth(20)]
    public int ID { get; set; }
    [ExcelColumnWidth(15.50)]
    public string Name { get; set; }
}
```

#### 4. एक ही प्रॉपर्टी के लिए मल्टीपल कॉलम नाम मैपिंग।

```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```



#### 5. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

संस्करण 1.24.0 से, सिस्टम System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute को सपोर्ट करता है

```C#
public class TestIssueI4TXGTDto
{
    public int ID { get; set; }
    public string Name { get; set; }
    [DisplayName("Specification")]
    public string Spc { get; set; }
    [DisplayName("Unit Price")]
    public decimal Up { get; set; }
}
```



#### 6. ExcelColumnAttribute

V1.26.0 से, कई एट्रिब्यूट्स को सिंप्लिफाई किया जा सकता है जैसे:
```csharp
        public class TestIssueI4ZYUUDto
        {
            [ExcelColumn(Name = "ID",Index =0)]
            public string MyProperty { get; set; }
            [ExcelColumn(Name = "CreateDate", Index = 1,Format ="yyyy-MM",Width =100)]
            public DateTime MyProperty2 { get; set; }
        }
```



#### 7. DynamicColumnAttribute

V1.26.0 से, हम कॉलम के एट्रिब्यूट्स को डायनामिक रूप से सेट कर सकते हैं
```csharp
            var config = new OpenXmlConfiguration
            {
                DynamicColumns = new DynamicExcelColumn[] {
                    new DynamicExcelColumn("id"){Ignore=true},
                    new DynamicExcelColumn("name"){Index=1,Width=10},
                    new DynamicExcelColumn("createdate"){Index=0,Format="yyyy-MM-dd",Width=15},
                    new DynamicExcelColumn("point"){Index=2,Name="Account Point"},
                }
            };
            var path = PathHelper.GetTempPath();
            var value = new[] { new { id = 1, name = "Jack", createdate = new DateTime(2022, 04, 12) ,point = 123.456} };
            MiniExcel.SaveAs(path, value, configuration: config);
```
![image](https://user-images.githubusercontent.com/12729184/164510353-5aecbc4e-c3ce-41e8-b6cf-afd55eb23b68.png)

#### 8. DynamicSheetAttribute

V1.31.4 से हम शीट के एट्रिब्यूट्स को डायनामिक रूप से सेट कर सकते हैं। हम शीट का नाम और स्थिति (विजिबिलिटी) सेट कर सकते हैं।
```csharp
            var configuration = new OpenXmlConfiguration
            {
                DynamicSheets = new DynamicExcelSheet[] {
                    new DynamicExcelSheet("usersSheet") { Name = "Users", State = SheetState.Visible },
                    new DynamicExcelSheet("departmentSheet") { Name = "Departments", State = SheetState.Hidden }
                }
            };

            var users = new[] { new { Name = "Jack", Age = 25 }, new { Name = "Mike", Age = 44 } };
            var department = new[] { new { ID = "01", Name = "HR" }, new { ID = "02", Name = "IT" } };
            var sheets = new Dictionary<string, object>
            {
                ["usersSheet"] = users,
                ["departmentSheet"] = department
            };

            var path = PathHelper.GetTempPath();
            MiniExcel.SaveAs(path, sheets, configuration: configuration);
```

हम नया एट्रिब्यूट ExcelSheetAttribute भी उपयोग कर सकते हैं:

```C#
   [ExcelSheet(Name = "Departments", State = SheetState.Hidden)]
   private class DepartmentDto
   {
      [ExcelColumn(Name = "ID",Index = 0)]
      public string ID { get; set; }
      [ExcelColumn(Name = "Name",Index = 1)]
      public string Name { get; set; }
   }
```

### जोड़ें, हटाएं, अपडेट करें

#### जोड़ें

v1.28.0 सपोर्ट करता है कि CSV में अंतिम पंक्ति के बाद N पंक्तियों का डाटा इंसर्ट करें

```csharp
// मूल
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// अंतिम के बाद 1 पंक्ति इंसर्ट करें
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// अंतिम के बाद N पंक्तियाँ इंसर्ट करें
{
    var value = new[] {
          new { ID=4,Name ="Frank",InDate=new DateTime(2021,06,07)},
          new { ID=5,Name ="Gloria",InDate=new DateTime(2022,05,03)},
```
```
};
MiniExcel.Insert(path, value);
}
```

![image](https://user-images.githubusercontent.com/12729184/191023733-1e2fa732-db5c-4a3a-9722-b891fe5aa069.png)

v1.37.0 समर्थन करता है Excel में एक नई शीट को मौजूदा वर्कबुक में जोड़ना

```csharp
// मूल Excel
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// एक नई शीट जोड़ें
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```



#### Delete(प्रतीक्षारत)

#### Update(प्रतीक्षारत)



### Excel प्रकार स्वत: पहचान <a name="getstart5"></a>

- MiniExcel डिफ़ॉल्ट रूप से `file extension` के आधार पर यह जांचेगा कि यह xlsx है या csv, लेकिन इसमें अशुद्धि हो सकती है, कृपया इसे मैन्युअल रूप से निर्दिष्ट करें।
- स्ट्रीम से यह पता नहीं चल सकता कि यह कौन सा excel है, कृपया इसे मैन्युअल रूप से निर्दिष्ट करें।

```csharp
stream.SaveAs(excelType:ExcelType.CSV);
//या
stream.SaveAs(excelType:ExcelType.XLSX);
//या
stream.Query(excelType:ExcelType.CSV);
//या
stream.Query(excelType:ExcelType.XLSX);
```





### CSV

#### नोट

- डिफ़ॉल्ट रूप से `string` प्रकार लौटता है, और मान को नंबर या datetime में परिवर्तित नहीं किया जाएगा, जब तक कि प्रकार को strong typing generic द्वारा परिभाषित नहीं किया गया हो।



#### कस्टम सेपरेटर

डिफ़ॉल्ट सेपरेटर `,` है, आप कस्टमाईज़ेशन के लिए `Seperator` प्रॉपर्टी को संशोधित कर सकते हैं

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

V1.30.1 से कस्टम सेपरेटर फ़ंक्शन का समर्थन (धन्यवाद @hyzx86)

```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```



#### कस्टम लाइन ब्रेक

डिफ़ॉल्ट रूप से `\r\n` नया लाइन कैरेक्टर है, आप कस्टमाईज़ेशन के लिए `NewLine` प्रॉपर्टी को संशोधित कर सकते हैं

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```



#### कस्टम एनकोडिंग

- डिफ़ॉल्ट एनकोडिंग "Detect Encoding From Byte Order Marks"  (detectEncodingFromByteOrderMarks: true) है
- यदि आपकी कस्टम एनकोडिंग आवश्यकता है, तो कृपया StreamReaderFunc / StreamWriterFunc प्रॉपर्टी को संशोधित करें

```csharp
// पढ़ना
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// लिखना
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamWriterFunc = (stream) => new StreamWriter(stream, Encoding.GetEncoding("gb2312"))
};
MiniExcel.SaveAs(path, value,excelType:ExcelType.CSV, configuration: config);
```

#### खाली स्ट्रिंग को null के रूप में पढ़ना

डिफ़ॉल्ट रूप से, खाली मान string.Empty में मैप होते हैं। आप इस व्यवहार को संशोधित कर सकते हैं

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
   ReadEmptyStringAsNull = true
};
```


### DataReader

#### 1. GetReader
संस्करण 1.23.0 से, आप GetDataReader का उपयोग कर सकते हैं

```csharp
    using (var reader = MiniExcel.GetReader(path,true))
    {
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var value = reader.GetValue(i);
            }
        }
    }
```



###  Async

- v0.17.0 से Async का समर्थन (धन्यवाद isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))

```csharp
public static Task SaveAsAsync(string path, object value, bool printHeader = true, string sheetName = "Sheet1", ExcelType excelType = ExcelType.UNKNOWN, IConfiguration configuration = null)
public static Task SaveAsAsync(this Stream stream, object value, bool printHeader = true, string sheetName = "Sheet1", ExcelType excelType = ExcelType.XLSX, IConfiguration configuration = null)
public static Task<IEnumerable<dynamic>> QueryAsync(string path, bool useHeaderRow = false, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null)
public static Task<IEnumerable<T>> QueryAsync<T>(this Stream stream, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null) where T : class, new()
public static Task<IEnumerable<T>> QueryAsync<T>(string path, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null) where T : class, new()
public static Task<IEnumerable<IDictionary<string, object>>> QueryAsync(this Stream stream, bool useHeaderRow = false, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null)
public static Task SaveAsByTemplateAsync(this Stream stream, string templatePath, object value)
public static Task SaveAsByTemplateAsync(this Stream stream, byte[] templateBytes, object value)
public static Task SaveAsByTemplateAsync(string path, string templatePath, object value)
public static Task SaveAsByTemplateAsync(string path, byte[] templateBytes, object value)
public static Task<DataTable> QueryAsDataTableAsync(string path, bool useHeaderRow = true, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null)
```

-  v1.25.0 से `cancellationToken` का समर्थन।



### अन्य

#### 1. Enum

सुनिश्चित करें कि Excel और प्रॉपर्टी नाम एक जैसे हैं, सिस्टम स्वतः मैपिंग कर देगा (केस सेंसिटिव नहीं है)

![image](https://user-images.githubusercontent.com/12729184/116210595-9784b100-a775-11eb-936f-8e7a8b435961.png)

V0.18.0 से Enum Description का समर्थन

```csharp
public class Dto
{
    public string Name { get; set; }
    public I49RYZUserType UserType { get; set; }
}

public enum Type
{
    [Description("General User")]
    V1,
    [Description("General Administrator")]
    V2,
    [Description("Super Administrator")]
    V3
}
```
```

![image](https://user-images.githubusercontent.com/12729184/133116630-27cc7161-099a-48b8-9784-cd1e443af3d1.png)

संस्करण 1.30.0 से Excel Description to Enum का समर्थन है, धन्यवाद @KaneLeung

#### 2. CSV को XLSX में या XLSX को CSV में कनवर्ट करें

```csharp
MiniExcel.ConvertXlsxToCsv(xlsxPath, csvPath);
MiniExcel.ConvertXlsxToCsv(xlsxStream, csvStream);
MiniExcel.ConvertCsvToXlsx(csvPath, xlsxPath);
MiniExcel.ConvertCsvToXlsx(csvStream, xlsxStream);
```
```csharp
using (var excelStream = new FileStream(path: filePath, FileMode.Open, FileAccess.Read))
using (var csvStream = new MemoryStream())
{
   MiniExcel.ConvertXlsxToCsv(excelStream, csvStream);
}
```

#### 3. कस्टम CultureInfo

संस्करण 1.22.0 से, आप नीचे दिखाए अनुसार कस्टम CultureInfo सेट कर सकते हैं, सिस्टम डिफ़ॉल्ट `CultureInfo.InvariantCulture` है।

```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// या
MiniExcel.Query(path, configuration: config);
```


#### 4. कस्टम बफर साइज
```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```

#### 5. FastMode

सिस्टम मेमोरी को नियंत्रित नहीं करेगा, लेकिन आप तेज़ सेविंग स्पीड प्राप्त कर सकते हैं।

```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```

#### 6. बैच इमेज जोड़ें (MiniExcel.AddPicture)

```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // डिफ़ॉल्ट null है, यानी पहला शीट
        CellAddress = "C3", // आवश्यक
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // डिफ़ॉल्ट PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // आवश्यक
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```
![Image](https://github.com/user-attachments/assets/19c4d241-9753-4ede-96c8-f810c1a22247)

#### 7. शीट्स का Dimension प्राप्त करें

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```

### उदाहरण:

#### 1. SQLite & Dapper `बड़े आकार की फ़ाइल` SQL Insert OOM से बचाव

नोट : कृपया Query के बाद ToList/ToArray मेथड्स न कॉल करें, इससे सभी डेटा मेमोरी में लोड हो जाएगा

```csharp
using (var connection = new SQLiteConnection(connectionString))
{
    connection.Open();
    using (var transaction = connection.BeginTransaction())
    using (var stream = File.OpenRead(path))
    {
       var rows = stream.Query();
       foreach (var row in rows)
             connection.Execute("insert into T (A,B) values (@A,@B)", new { row.A, row.B }, transaction: transaction);
       transaction.Commit();
    }
}
```

प्रदर्शन:
![image](https://user-images.githubusercontent.com/12729184/111072579-2dda7b80-8516-11eb-9843-c01a1edc88ec.png)





#### 2. ASP.NET Core 3.1 या MVC 5 डाउनलोड/अपलोड Excel Xlsx API डेमो [Try it](tests/MiniExcel.Tests.AspNetCore)

```csharp
public class ApiController : Controller
{
    public IActionResult Index()
    {
        return new ContentResult
        {
            ContentType = "text/html",
            StatusCode = (int)HttpStatusCode.OK,
            Content = @"<html><body>
<a href='api/DownloadExcel'>DownloadExcel</a><br>
<a href='api/DownloadExcelFromTemplatePath'>DownloadExcelFromTemplatePath</a><br>
<a href='api/DownloadExcelFromTemplateBytes'>DownloadExcelFromTemplateBytes</a><br>
<p>Upload Excel</p>
<form method='post' enctype='multipart/form-data' action='/api/uploadexcel'>
    <input type='file' name='excel'> <br>
    <input type='submit' >
</form>
</body></html>"
        };
    }

    public IActionResult DownloadExcel()
    {
        var values = new[] {
            new { Column1 = "MiniExcel", Column2 = 1 },
            new { Column1 = "Github", Column2 = 2}
        };
        var memoryStream = new MemoryStream();
        memoryStream.SaveAs(values);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            FileDownloadName = "demo.xlsx"
        };
    }

    public IActionResult DownloadExcelFromTemplatePath()
    {
        string templatePath = "TestTemplateComplex.xlsx";

        Dictionary<string, object> value = new Dictionary<string, object>()
        {
            ["title"] = "FooCompany",
            ["managers"] = new[] {
                new {name="Jack",department="HR"},
                new {name="Loan",department="IT"}
            },
            ["employees"] = new[] {
                new {name="Wade",department="HR"},
                new {name="Felix",department="HR"},
                new {name="Eric",department="IT"},
                new {name="Keaton",department="IT"}
            }
        };

        MemoryStream memoryStream = new MemoryStream();
        memoryStream.SaveAsByTemplate(templatePath, value);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            FileDownloadName = "demo.xlsx"
        };
    }

    private static Dictionary<string, Byte[]> TemplateBytesCache = new Dictionary<string, byte[]>();

    static ApiController()
    {
        string templatePath = "TestTemplateComplex.xlsx";
        byte[] bytes = System.IO.File.ReadAllBytes(templatePath);
        TemplateBytesCache.Add(templatePath, bytes);
    }

    public IActionResult DownloadExcelFromTemplateBytes()
    {
        byte[] bytes = TemplateBytesCache["TestTemplateComplex.xlsx"];

        Dictionary<string, object> value = new Dictionary<string, object>()
        {
            ["title"] = "FooCompany",
            ["managers"] = new[] {
                new {name="Jack",department="HR"},
                new {name="Loan",department="IT"}
```
```csharp
            },
            ["employees"] = new[] {
                new {name="Wade",department="HR"},
                new {name="Felix",department="HR"},
                new {name="Eric",department="IT"},
                new {name="Keaton",department="IT"}
            }
        };

        MemoryStream memoryStream = new MemoryStream();
        memoryStream.SaveAsByTemplate(bytes, value);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            FileDownloadName = "demo.xlsx"
        };
    }

    public IActionResult UploadExcel(IFormFile excel)
    {
        var stream = new MemoryStream();
        excel.CopyTo(stream);

        foreach (var item in stream.Query(true))
        {
            // अपनी लॉजिक आदि यहाँ करें।
        }

        return Ok("File uploaded successfully");
    }
}
```

####  3. पेजिंग क्वेरी

```csharp
void Main()
{
    var rows = MiniExcel.Query(path);

    Console.WriteLine("==== No.1 Page ====");
    Console.WriteLine(Page(rows,pageSize:3,page:1));
    Console.WriteLine("==== No.50 Page ====");
    Console.WriteLine(Page(rows,pageSize:3,page:50));
    Console.WriteLine("==== No.5000 Page ====");
    Console.WriteLine(Page(rows,pageSize:3,page:5000));
}

public static IEnumerable<T> Page<T>(IEnumerable<T> en, int pageSize, int page)
{
    return en.Skip(page * pageSize).Take(pageSize);
}
```

![20210419](https://user-images.githubusercontent.com/12729184/114679083-6ef4c400-9d3e-11eb-9f78-a86daa45fe46.gif)



#### 4. वेबफॉर्म द्वारा मेमोरीस्ट्रीम से एक्सेल एक्सपोर्ट करें

```csharp
var fileName = "Demo.xlsx";
var sheetName = "Sheet1";
HttpResponse response = HttpContext.Current.Response;
response.Clear();
response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
response.AddHeader("Content-Disposition", $"attachment;filename=\"{fileName}\"");
var values = new[] {
    new { Column1 = "MiniExcel", Column2 = 1 },
    new { Column1 = "Github", Column2 = 2}
};
var memoryStream = new MemoryStream();
memoryStream.SaveAs(values, sheetName: sheetName);
memoryStream.Seek(0, SeekOrigin.Begin);
memoryStream.CopyTo(Response.OutputStream);
response.End();
```



#### 5. डायनामिक i18n मल्टी-लैंग्वेज और रोल अथॉरिटी मैनेजमेंट

उदाहरण की तरह, i18n और परमिशन मैनेजमेंट को हैंडल करने के लिए एक मेथड बनाएं, और `yield return` का उपयोग करके IEnumerable<Dictionary<string, object>> लौटाएं, जिससे डायनामिक और लो-मेमोरी प्रोसेसिंग इफेक्ट्स मिलें

```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us और Sales रोल");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "en-US";
        var role = "Sales";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
        MiniExcel.Query(path, true).Dump();
    }

    Console.WriteLine("zh-CN और PMC रोल");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "zh-CN";
        var role = "PMC";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
        MiniExcel.Query(path, true).Dump();
    }
}

private IEnumerable<Dictionary<string, object>> GetOrders(string lang, string role, Order[] orders)
{
    foreach (var order in orders)
    {
        var newOrder = new Dictionary<string, object>();

        if (lang == "zh-CN")
        {
            newOrder.Add("客户编号", order.CustomerID);
            newOrder.Add("订单编号", order.OrderNo);
            newOrder.Add("产品编号", order.ProductID);
            newOrder.Add("数量", order.Qty);
            if (role == "Sales")
                newOrder.Add("价格", order.Amt);
            yield return newOrder;
        }
        else if (lang == "en-US")
        {
            newOrder.Add("Customer ID", order.CustomerID);
            newOrder.Add("Order No", order.OrderNo);
            newOrder.Add("Product ID", order.ProductID);
            newOrder.Add("Quantity", order.Qty);
            if (role == "Sales")
                newOrder.Add("Amount", order.Amt);
            yield return newOrder;
        }
        else
        {
            throw new InvalidDataException($"lang {lang} wrong");
        }
    }
}

public class Order
{
    public string OrderNo { get; set; }
    public string CustomerID { get; set; }
    public decimal Qty { get; set; }
    public string ProductID { get; set; }
    public decimal Amt { get; set; }
}
```

![image](https://user-images.githubusercontent.com/12729184/118939964-d24bc480-b982-11eb-88dd-f06655f6121a.png)



### FAQ

#### प्रश्न: एक्सेल हेडर टाइटल क्लास प्रॉपर्टी नाम के बराबर नहीं है, मैपिंग कैसे करें?

उत्तर: कृपया ExcelColumnName एट्रिब्यूट का उपयोग करें

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### प्रश्न: मल्टीपल-शीट्स को क्वेरी या एक्सपोर्ट कैसे करें?

उत्तर: `GetSheetNames` मेथड का उपयोग करें और  Query  में sheetName पैरामीटर पास करें।



```csharp
var sheets = MiniExcel.GetSheetNames(path);
foreach (var sheet in sheets)
{
    Console.WriteLine($"sheet name : {sheet} ");
    var rows = MiniExcel.Query(path,useHeaderRow:true,sheetName:sheet);
    Console.WriteLine(rows);
}
```

![image](https://user-images.githubusercontent.com/12729184/116199841-2a1f5300-a76a-11eb-90a3-6710561cf6db.png)

#### प्रश्न: शीट विजिबिलिटी की जानकारी कैसे क्वेरी या एक्सपोर्ट करें?

उत्तर: `GetSheetInformations` मेथड का उपयोग करें।



```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // अगला शीट इंडेक्स - 0 से शुरू होता है
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // शीट का नाम
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // शीट विजिबिलिटी स्टेट - visible / hidden
}
```
```
#### प्रश्न: क्या Count का उपयोग करने से सारा डेटा मेमोरी में लोड हो जाएगा?

नहीं, इमेज टेस्ट में 1 मिलियन पंक्तियाँ * 10 कॉलम का डेटा है, अधिकतम मेमोरी उपयोग <60MB है, और इसमें 13.65 सेकंड लगते हैं

![image](https://user-images.githubusercontent.com/12729184/117118518-70586000-adc3-11eb-9ce3-2ba76cf8b5e5.png)

#### प्रश्न: Query में integer index का उपयोग कैसे करें?

Query का डिफ़ॉल्ट इंडेक्स string Key: A,B,C.... है। अगर आप इसे संख्यात्मक इंडेक्स में बदलना चाहते हैं, तो कृपया निम्नलिखित विधि बनाएं

```csharp
void Main()
{
    var path = @"D:\git\MiniExcel\samples\xlsx\TestTypeMapping.xlsx";
    var rows = MiniExcel.Query(path,true);
    foreach (var r in ConvertToIntIndexRows(rows))
    {
        Console.Write($"column 0 : {r[0]} ,column 1 : {r[1]}");
        Console.WriteLine();
    }
}

private IEnumerable<Dictionary<int, object>> ConvertToIntIndexRows(IEnumerable<object> rows)
{
    ICollection<string> keys = null;
    var isFirst = true;
    foreach (IDictionary<string,object> r in rows)
    {
        if(isFirst)
        {
            keys = r.Keys;
            isFirst = false;
        }

        var dic = new Dictionary<int, object>();
        var index = 0;
        foreach (var key in keys)
            dic[index++] = r[key];
        yield return dic;
    }
}
```

#### प्रश्न: जब Excel एक्सपोर्ट करते समय value खाली होती है तो बिना शीर्षक का खाली एक्सेल क्यों बनता है?

क्योंकि MiniExcel JSON.NET के समान लॉजिक का उपयोग करता है जो वैल्यू से डायनामिक रूप से टाइप प्राप्त करता है ताकि API ऑपरेशन को सरल बनाया जा सके, डेटा के बिना टाइप ज्ञात नहीं किया जा सकता। अधिक जानकारी के लिए देखें [issue #133](https://github.com/mini-software/MiniExcel/issues/133)।

![image](https://user-images.githubusercontent.com/12729184/122639771-546c0c00-d12e-11eb-800c-498db27889ca.png)

> Strong type & DataTable हेडर जेनरेट करेंगे, लेकिन Dictionary में फिर भी Excel खाली रहेगा

#### प्रश्न: खाली row पर foreach को कैसे रोकें?

MiniExcel को `LINQ TakeWhile` के साथ उपयोग किया जा सकता है ताकि foreach इटरेटर को रोका जा सके।

![Image](https://user-images.githubusercontent.com/12729184/130209137-162621c2-f337-4479-9996-beeac65bc4d4.png)

#### प्रश्न: खाली rows को कैसे हटाएं?

![image](https://user-images.githubusercontent.com/12729184/137873865-7107d8f5-eb59-42db-903a-44e80589f1b2.png)


IEnumerable :

```csharp
public static IEnumerable<dynamic> QueryWithoutEmptyRow(Stream stream, bool useHeaderRow, string sheetName, ExcelType excelType, string startCell, IConfiguration configuration)
{
    var rows = stream.Query(useHeaderRow,sheetName,excelType,startCell,configuration);
    foreach (IDictionary<string,object> row in rows)
    {
        if(row.Keys.Any(key=>row[key]!=null))
            yield return row;
    }
}
```



DataTable :

```csharp
public static DataTable QueryAsDataTableWithoutEmptyRow(Stream stream, bool useHeaderRow, string sheetName, ExcelType excelType, string startCell, IConfiguration configuration)
{
    if (sheetName == null && excelType != ExcelType.CSV) /*Issue #279*/
        sheetName = stream.GetSheetNames().First();

    var dt = new DataTable(sheetName);
    var first = true;
    var rows = stream.Query(useHeaderRow,sheetName,excelType,startCell,configuration);
    foreach (IDictionary<string, object> row in rows)
    {
        if (first)
        {

            foreach (var key in row.Keys)
            {
                var column = new DataColumn(key, typeof(object)) { Caption = key };
                dt.Columns.Add(column);
            }

            dt.BeginLoadData();
            first = false;
        }

        var newRow = dt.NewRow();
        var isNull=true;
        foreach (var key in row.Keys)
        {
            var _v = row[key];
            if(_v!=null)
                isNull = false;
            newRow[key] = _v;
        }

        if(!isNull)
            dt.Rows.Add(newRow);
    }

    dt.EndLoadData();
    return dt;
}
```



#### प्रश्न: SaveAs(path,value) का उपयोग करके मौजूदा फ़ाइल को कैसे बदलें और "The file ...xlsx already exists error" न आए

कृपया फ़ाइल बनाने के कस्टम लॉजिक के लिए Stream class का उपयोग करें, उदाहरण:

```C#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```



या, V1.25.0 से, SaveAs में overwriteFile पैरामीटर है जिससे मौजूदा फ़ाइल को ओवरराइट करना संभव है

```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```




### सीमाएँ और ध्यान देने योग्य बातें

- वर्तमान में xls और encrypted फ़ाइल समर्थित नहीं है
- xlsm केवल Query को सपोर्ट करता है



### संदर्भ

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)



### धन्यवाद

####  [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

इस प्रोजेक्ट के लिए मुफ्त All product IDE प्रदान करने के लिए धन्यवाद ([License](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))



### योगदान साझा दान
लिंक https://github.com/orgs/mini-software/discussions/754

### योगदानकर्ता

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---