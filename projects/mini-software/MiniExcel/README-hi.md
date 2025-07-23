<div align="center">
<p><a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/v/MiniExcel.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/dt/MiniExcel.svg" alt=""></a>
<a href="https://ci.appveyor.com/project/mini-software/miniexcel/branch/master"><img src="https://ci.appveyor.com/api/projects/status/b2vustrwsuqx45f4/branch/master?svg=true" alt="Build status"></a>
<a href="https://gitee.com/dotnetchina/MiniExcel"><img src="https://gitee.com/dotnetchina/MiniExcel/badge/star.svg" alt="star"></a> <a href="https://github.com/mini-software/MiniExcel" rel="nofollow"><img src="https://img.shields.io/github/stars/mini-software/MiniExcel?logo=github" alt="GitHub stars"></a>
<a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/badge/.NET-%3E%3D%204.5-red.svg" alt="version"></a>
<a href="https://deepwiki.com/mini-software/MiniExcel"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
</p>
</div>

---

[<img align="right" src="https://github.com/dotnet-foundation/swag/blob/main/logo/dotnetfoundation_v4.png?raw=true" width="100" />](https://www.dotnetfoundation.org/)

<div align="center">
<p>यह परियोजना <a href="https://www.dotnetfoundation.org/">.NET Foundation</a> का हिस्सा है और इनके <a href="https://www.dotnetfoundation.org/code-of-conduct">आचार संहिता</a> के तहत संचालित होती है।</p>
</div>

---

<div align="center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ja">日本語</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ko">한국어</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=hi">हिन्दी</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=th">ไทย</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fr">Français</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=de">Deutsch</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=es">Español</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=it">Italiano</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ru">Русский</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pt">Português</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=nl">Nederlands</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pl">Polski</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ar">العربية</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fa">فارسی</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=tr">Türkçe</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=vi">Tiếng Việt</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=id">Bahasa Indonesia</a><p></p>
</strong></p>
</div>


---

<div align="center">
 आपकी <a href="https://github.com/mini-software/MiniExcel">स्टार</a> या <a href="https://miniexcel.github.io">दान</a> MiniExcel को और बेहतर बना सकते हैं
</div>

---

### परिचय

MiniExcel एक सरल और कुशल Excel प्रोसेसिंग टूल है जो .NET के लिए विशेष रूप से न्यूनतम मेमोरी उपयोग को ध्यान में रखकर बनाया गया है।

वर्तमान में, अधिकांश लोकप्रिय फ्रेमवर्क्स को संचालन के लिए Excel दस्तावेज़ से सारा डेटा मेमोरी में लोड करना पड़ता है, जिससे मेमोरी खपत की समस्या हो सकती है। MiniExcel का तरीका अलग है: इसमें डेटा को स्ट्रीमिंग रूप में पंक्ति-दर-पंक्ति प्रोसेस किया जाता है, जिससे मूल खपत सैंकड़ों मेगाबाइट्स से घटकर कुछ मेगाबाइट्स रह जाती है, और इस तरह आउट-ऑफ-मेमोरी (OOM) समस्याओं को प्रभावी रूप से रोका जा सकता है।

```mermaid
flowchart LR
    A1(["Excel analysis<br>process"]) --> A2{{"Unzipping<br>XLSX file"}} --> A3{{"Parsing<br>OpenXML"}} --> A4{{"Model<br>conversion"}} --> A5(["Output"])

    B1(["Other Excel<br>Frameworks"]) --> B2{{"Memory"}} --> B3{{"Memory"}} --> B4{{"Workbooks &<br>Worksheets"}} --> B5(["All rows at<br>the same time"])

    C1(["MiniExcel"]) --> C2{{"Stream"}} --> C3{{"Stream"}} --> C4{{"POCO or dynamic"}} --> C5(["Deferred execution<br>row by row"])

    classDef analysis fill:#D0E8FF,stroke:#1E88E5,color:#0D47A1,font-weight:bold;
    classDef others fill:#FCE4EC,stroke:#EC407A,color:#880E4F,font-weight:bold;
    classDef miniexcel fill:#E8F5E9,stroke:#388E3C,color:#1B5E20,font-weight:bold;

    class A1,A2,A3,A4,A5 analysis;
    class B1,B2,B3,B4,B5 others;
    class C1,C2,C3,C4,C5 miniexcel;
```
### विशेषताएँ

- मेमोरी उपयोग को न्यूनतम करता है, जिससे आउट-ऑफ-मेमोरी (OOM) त्रुटियाँ और पूर्ण गार्बेज कलेक्शन से बचाव होता है
- बड़े डेटा सेट्स पर बेहतर प्रदर्शन के लिए रीयल-टाइम, रो-स्तरीय डेटा संचालन सक्षम करता है
- LINQ के साथ डिफर्ड एक्जीक्यूशन को सपोर्ट करता है, जिससे तेज़, मेमोरी-कुशल पेजिंग और जटिल क्वेरीज संभव होती हैं
- हल्का, Microsoft Office या COM+ घटकों की आवश्यकता नहीं, और DLL का आकार 500KB से कम
- सरल और सहज API शैली, जिससे एक्सेल पढ़ना/लिखना/भरना आसान है

### आरंभ करें

- [Excel आयात/प्रश्न करें](#getstart1)

- [Excel निर्यात/बनाएँ](#getstart2)

- [Excel टेम्पलेट](#getstart3)

- [Excel कॉलम नाम/इंडेक्स/इग्नोर एट्रिब्यूट](#getstart4)

- [उदाहरण](#getstart5)



### स्थापना

आप पैकेज को [NuGet से इंस्टॉल कर सकते हैं](https://www.nuget.org/packages/MiniExcel)

### रिलीज़ नोट्स

कृपया [रिलीज़ नोट्स](docs) देखें

### TODO

कृपया [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true) देखें

### प्रदर्शन

बेंचमार्क्स का कोड [MiniExcel.Benchmarks](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Program.cs) में पाया जा सकता है।

प्रदर्शन परीक्षण के लिए प्रयुक्त फाइल है [**Test1,000,000x10.xlsx**](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx), जो 32MB का दस्तावेज़ है, जिसमें 1,000,000 पंक्तियाँ * 10 कॉलम हैं, जिनकी कोशिकाएँ "HelloWorld" स्ट्रिंग से भरी हैं।

सभी बेंचमार्क्स चलाने के लिए उपयोग करें:


```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```
आप नवीनतम रिलीज़ के लिए बेंचमार्क के परिणाम [यहाँ](benchmarks/results) देख सकते हैं।

### एक्सेल क्वेरी/इम्पोर्ट  <a name="getstart1"></a>

#### 1. एक क्वेरी निष्पादित करें और परिणामों को एक स्ट्रॉन्गली टाइप्ड IEnumerable में मैप करें [[अためष्‍ा प्रयास करें]](https://dotnetfiddle.net/w5WD1J)

बेहतर दक्षता के कारण Stream.Query का उपयोग करने की सिफारिश की जाती है।



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

// or

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```
![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. एक क्वेरी निष्पादित करें और उसे डायनामिक ऑब्जेक्ट्स की सूची में मैप करें बिना हेड का उपयोग किए [[Try it]](https://dotnetfiddle.net/w5WD1J)

* डायनामिक कुंजी है `A.B.C.D..`

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |


```csharp

var rows = MiniExcel.Query(path).ToList();

// or
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```
#### 3. पहले हेडर पंक्ति के साथ क्वेरी निष्पादित करें [[इसे आज़माएँ]](https://dotnetfiddle.net/w5WD1J)

नोट : एक जैसे कॉलम नाम के लिए दाहिनी ओर वाला अंतिम नाम उपयोग होगा

इनपुट एक्सेल :

| कॉलम1     | कॉलम2   |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |



```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// or

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```
#### 4. क्वेरी समर्थन LINQ एक्सटेंशन फर्स्ट/टेक/स्किप ...आदि

क्वेरी फर्स्ट

```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// or

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
//or
stream.Query(sheetName: "SheetName");
```
#### 6. सभी शीट नाम और पंक्तियों को क्वेरी करें


```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```
#### 7. कॉलम प्राप्त करें


```csharp
var columns = MiniExcel.GetColumns(path); // e.g result : ["A","B"...]

var cnt = columns.Count;  // get column count
```
#### 8. डायनामिक क्वेरी में पंक्ति को `IDictionary<string,object>` में कास्ट करें


```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// or
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// or Query specified ranges (capitalized)
// A2 represents the second row of column A, C3 represents the third row of column C
// If you don't want to restrict rows, just don't include numbers
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```
#### 9. क्वेरी एक्सेल रिटर्न DataTable

सिफारिश नहीं की जाती है, क्योंकि DataTable सभी डेटा को मेमोरी में लोड कर लेगा और MiniExcel की कम मेमोरी खपत की विशेषता खो देगा।




```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```
![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)



#### 10. डेटा पढ़ना शुरू करने के लिए सेल निर्दिष्ट करें


```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```
![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)



#### 11. मर्ज की गई कोशिकाएँ भरें

नोट: दक्षता `मर्ज फिल का उपयोग न करने` की तुलना में धीमी है

कारण: OpenXml मानक mergeCells को फाइल के नीचे डालता है, जिससे sheetxml पर दो बार foreach की आवश्यकता होती है


```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```
![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

चर लंबाई और चौड़ाई वाली बहु-पंक्ति और स्तंभ भरने का समर्थन करता है

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. डिस्क-बेस कैश द्वारा बड़े फाइल को पढ़ना (Disk-Base Cache - SharedString)

यदि SharedStrings का आकार 5 एमबी से अधिक हो जाता है, तो MiniExcel डिफ़ॉल्ट रूप से स्थानीय डिस्क कैश का उपयोग करेगा, उदाहरण के लिए, [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx)(दस लाख पंक्तियों का डेटा), जब डिस्क कैश अक्षम हो तो अधिकतम मेमोरी उपयोग 195MB है, लेकिन सक्षम डिस्क कैश के साथ केवल 65MB की जरूरत होती है। ध्यान दें, इस अनुकूलन के लिए कुछ दक्षता लागत लगती है, इसलिए इस केस में पढ़ने का समय 7.4 सेकंड से बढ़कर 27.2 सेकंड हो जाएगा। यदि आपको इसकी आवश्यकता नहीं है तो आप निम्न कोड के साथ डिस्क कैश को अक्षम कर सकते हैं:


```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```
आप `SharedStringCacheSize` का उपयोग करके डिस्क कैशिंग के लिए निर्दिष्ट आकार से अधिक sharedString फ़ाइल का आकार बदल सकते हैं।

```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```
![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)









### एक्सेल बनाएँ/एक्सपोर्ट करें  <a name="getstart2"></a>

1. एक गैर-सार्वजनिक प्रकार होना चाहिए जिसमें एक सार्वजनिक पैरामीटर रहित कन्स्ट्रक्टर हो।

2. MiniExcel IEnumerable Deferred Execution को सपोर्ट करता है, यदि आप सबसे कम मेमोरी का उपयोग करना चाहते हैं, तो कृपया ToList जैसे मेथड्स न कॉल करें

उदाहरण : ToList या न करें, मेमोरी का उपयोग
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)



#### 1. अनाम या मजबूत प्रकार [[आजमाएं]](https://dotnetfiddle.net/w5WD1J)



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
फ़ाइल परिणाम बनाएँ :

| कॉलम1      | कॉलम2  |
|------------|---------|
| MiniExcel  | 1       |
| Github     | 2       |


#### 3.  IDataReader
- `अनुशंसित`, यह सभी डेटा को मेमोरी में लोड करने से बचा सकता है

```csharp
MiniExcel.SaveAs(path, reader);
```
![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

DataReader कई शीट्स को निर्यात करता है (Dapper ExecuteReader द्वारा अनुशंसित)


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
#### 4. डाटाटेबल

- `सिफारिश नहीं की जाती`, यह सभी डेटा को मेमोरी में लोड कर देगा

- डाटाटेबल पहले कॉलम नाम के लिए कैप्शन का उपयोग करता है, फिर कॉलम नाम का उपयोग करता है




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
####  5. Dapper क्वेरी

धन्यवाद @shaofing #552, कृपया `CommandDefinition + CommandFlags.NoCache` का उपयोग करें


```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // Note: QueryAsync will throw close connection exception
    MiniExcel.SaveAs(path, rows);
}
```
नीचे दिया गया कोड सभी डेटा को मेमोरी में लोड कर देगा


```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(@"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2");
    MiniExcel.SaveAs(path, rows);
}
```
#### 6. मेमोरीस्ट्रीम में SaveAs  [[प्रयास करें]](https://dotnetfiddle.net/JOen0e)



```csharp
using (var stream = new MemoryStream()) //support FileStream,MemoryStream ect.
{
    stream.SaveAs(values);
}
```
उदा : एक्सेल निर्यात के लिए एपीआई  


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
#### 7. कई शीट्स बनाएं



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


#### 8. टेबलस्टाइल्स विकल्प

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


#### 9. ऑटोफ़िल्टर

v0.19.0 से `OpenXmlConfiguration.AutoFilter` ऑटोफ़िल्टर को सक्षम/अक्षम कर सकता है, डिफ़ॉल्ट मान `true` है, और ऑटोफ़िल्टर सेट करने का तरीका:


```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```




#### 10. छवि बनाएं


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



#### 11. बाइट एरे फ़ाइल निर्यात

संस्करण 1.22.0 से, जब मान का प्रकार `byte[]` होता है, तो सिस्टम डिफ़ॉल्ट रूप से सेल में फ़ाइल पथ को सहेजता है, और आयात करते समय सिस्टम इसे `byte[]` में परिवर्तित कर सकता है। और यदि आप इसका उपयोग नहीं करना चाहते हैं, तो आप `OpenXmlConfiguration.EnableConvertByteArray` को `false` पर सेट कर सकते हैं, इससे सिस्टम की दक्षता में सुधार हो सकता है।

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

संस्करण 1.22.0 से, जब मान का प्रकार `byte[]` होता है, तो सिस्टम डिफ़ॉल्ट रूप से सेल में फ़ाइल पथ को सहेजता है, और आयात करते समय सिस्टम इसे `byte[]` में परिवर्तित कर सकता है। और यदि आप इसका उपयोग नहीं करना चाहते हैं, तो आप `OpenXmlConfiguration.EnableConvertByteArray` को `false` पर सेट कर सकते हैं, इससे सिस्टम की दक्षता में सुधार हो सकता है।

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### 12. एक जैसे सेल को लंबवत मर्ज करें

यह सुविधा केवल `xlsx` प्रारूप में समर्थित है और @merge तथा @endmerge टैग्स के बीच सेल्स को लंबवत रूप से मर्ज करती है।
आप @mergelimit का उपयोग करके सेल्स के लंबवत मर्ज की सीमा निर्धारित कर सकते हैं।


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
मर्ज से पहले और बाद की फ़ाइल सामग्री:

मर्ज सीमा के बिना:

<img width="318" alt="Screenshot 2023-08-07 at 11 59 24" src="https://github.com/mini-software/MiniExcel/assets/38832863/49cc96b9-6c35-4bf3-8d43-a9752a15b22e">

<img width="318" alt="Screenshot 2023-08-07 at 11 59 57" src="https://github.com/mini-software/MiniExcel/assets/38832863/3fbd529b-3ae6-4bbe-b4d8-2793a5a58010">

मर्ज सीमा के साथ:

<img width="346" alt="Screenshot 2023-08-08 at 18 21 00" src="https://github.com/mini-software/MiniExcel/assets/38832863/04049d28-84d5-4c2a-bcff-5847547df5e1">

<img width="346" alt="Screenshot 2023-08-08 at 18 21 40" src="https://github.com/mini-software/MiniExcel/assets/38832863/f5cf8957-b0b0-4831-b8fc-8556299235c2">

#### 13. नल मान छोड़ें

नल मानों के लिए खाली सेल लिखने का नया स्पष्ट विकल्प:


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
     EnableWriteNullValueCell = true // Default value.
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
     EnableWriteNullValueCell = false // Default value is true.
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```
![चित्र](https://user-images.githubusercontent.com/31481586/241419441-c4f27e8f-3f87-46db-a10f-08665864c874.png)


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
शून्य और DBNull मानों के लिए कार्य करता है।

#### 14. पैन को फ्रीज करें

```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // default is 1
    FreezeColumnCount = 2   // default is 0
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```
![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/freeze-pane-1.png)


### एक्सेल टेम्पलेट में डेटा भरें <a name="getstart3"></a>

- डिक्लेरेशन Vue टेम्पलेट `{{variable name}}` के समान है, या कलेक्शन रेंडरिंग `{{collection name.field name}}`
- कलेक्शन रेंडरिंग IEnumerable/DataTable/DapperRow को सपोर्ट करता है

#### 1. बेसिक फिल

टेम्पलेट:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

परिणाम:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

कोड:

```csharp
// 1. By POCO
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);


// 2. By Dictionary
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```
#### 2. IEnumerable डेटा भरना

> नोट1: सूची भरने के लिए समान कॉलम के पहले IEnumerable का उपयोग आधार के रूप में करें

टेम्पलेट:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

परिणाम:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

कोड:



```csharp
//1. By POCO
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

//2. By Dictionary
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
#### 3. जटिल डेटा भरना

> नोट: मल्टी-शीट्स का समर्थन करता है और एक ही वेरिएबल का उपयोग करता है

टेम्पलेट:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

परिणाम:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)




```csharp
// 1. By POCO
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

// 2. By Dictionary
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
#### 4. बिग डेटा प्रदर्शन भरें

> नोट: IEnumerable डिफर्ड एक्जीक्यूशन का उपयोग करना, न कि ToList, MiniExcel में अधिकतम मेमोरी उपयोग को बचा सकता है

![image](https://user-images.githubusercontent.com/12729184/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)



#### 5. सेल वैल्यू ऑटो मैपिंग प्रकार

टेम्पलेट

![image](https://user-images.githubusercontent.com/12729184/114802504-64830a80-9dd0-11eb-8d56-8e8c401b3ace.png)

परिणाम

![image](https://user-images.githubusercontent.com/12729184/114802419-43221e80-9dd0-11eb-9ffe-a2ce34fe7076.png)

क्लास


```csharp
public class Poco
{
    public string @string { get; set; }
    public int? @int { get; set; }
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
#### 7. समूहित डेटा भरें


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

पूर्व

![before_with_header](https://user-images.githubusercontent.com/38832863/218646717-21b9d57a-2be2-4e9a-801b-ae212231d2b4.PNG)

बाद

![after_with_header](https://user-images.githubusercontent.com/38832863/218646721-58a7a340-7004-4bc2-af24-cffcb2c20737.PNG)

##### 2. @group टैग के साथ और @header टैग के बिना

पूर्व

![before_without_header](https://user-images.githubusercontent.com/38832863/218646873-b12417fa-801b-4890-8e96-669ed3b43902.PNG)

बाद

![after_without_header](https://user-images.githubusercontent.com/38832863/218646872-622461ba-342e-49ee-834f-b91ad9c2dac3.PNG)

##### 3. @group टैग के बिना

पूर्व

![without_group](https://user-images.githubusercontent.com/38832863/218646975-f52a68eb-e031-43b5-abaa-03b67c052d1a.PNG)

बाद

![without_group_after](https://user-images.githubusercontent.com/38832863/218646974-4a3c0e07-7c66-4088-ad07-b4ad3695b7e1.PNG)

#### 8. सेल के अंदर If/ElseIf/Else स्टेटमेंट्स

नियम:
1. DateTime, Double, Int के लिए ==, !=, >, >=, <, <= ऑपरेटर का समर्थन करता है।
2. String के लिए ==, != ऑपरेटर का समर्थन करता है।
3. प्रत्येक स्टेटमेंट नई पंक्ति में होनी चाहिए।
4. ऑपरेटर के पहले और बाद में एक स्पेस होना चाहिए।
5. स्टेटमेंट्स के अंदर कोई नई पंक्ति नहीं होनी चाहिए।
6. सेल ठीक नीचे दिए गए प्रारूप में होनी चाहिए।

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

#### 9. DataTable को पैरामीटर के रूप में


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
#### 10. सूत्र

##### 1. उदाहरण
अपने सूत्र के आगे `$` लगाएँ और संदर्भित श्रेणी की शुरुआत और अंत की पंक्तियों को चिह्नित करने के लिए `$enumrowstart` और `$enumrowend` का उपयोग करें:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-1.png)

जब टेम्पलेट को रेंडर किया जाता है, तो `$` उपसर्ग हटा दिया जाएगा और `$enumrowstart` तथा `$enumrowend` को गिनने योग्य श्रेणी की शुरुआत और अंत की पंक्ति संख्याओं से बदल दिया जाएगा:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-2.png)

##### 2. अन्य उदाहरण सूत्र:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| योग          | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| वैकल्पिक औसत | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| श्रेणी       | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |


#### 11. अन्य

##### 1. टेम्पलेट पैरामीटर कुंजी की जांच

V1.24.0 से, डिफ़ॉल्ट रूप से टेम्पलेट में गायब पैरामीटर कुंजी को अनदेखा कर दिया जाता है और उसे खाली स्ट्रिंग से बदल दिया जाता है, `IgnoreTemplateParameterMissing` अपवाद फेंकने को नियंत्रित कर सकता है या नहीं।

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```
![image](https://user-images.githubusercontent.com/12729184/157464332-e316f829-54aa-4c84-a5aa-9aef337b668d.png)



### एक्सेल कॉलम नाम/इंडेक्स/इग्नोर एट्रिब्यूट <a name="getstart4"></a>



#### 1. कॉलम नाम, कॉलम इंडेक्स, कॉलम इग्नोर निर्दिष्ट करें

एक्सेल उदाहरण

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

कोड


```csharp
public class ExcelAttributeDemo
{
    [ExcelColumnName("Column1")]
    public string Test1 { get; set; }
    [ExcelColumnName("Column2")]
    public string Test2 { get; set; }
    [ExcelIgnore]
    public string Test3 { get; set; }
    [ExcelColumnIndex("I")] // system will convert "I" to 8 index
    public string Test4 { get; set; }
    public string Test5 { get; } //wihout set will ignore
    public string Test6 { get; private set; } //un-public set will ignore
    [ExcelColumnIndex(3)] // start with 0
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






#### 2. कस्टम प्रारूप (ExcelFormatAttribute)

V0.21.0 से समर्थन वर्ग जिसमें `ToString(string content)` मेथड प्रारूप है

कक्षा


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

क्वेरी कस्टम फ़ॉर्मेट रूपांतरण को सपोर्ट करती है

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
#### 4. कई कॉलम नामों का एक ही प्रॉपर्टी से मैप होना।


```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```




#### 5. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

संस्करण 1.24.0 से, सिस्टम System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute का समर्थन करता है


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

V1.26.0 से, कई विशेषताओं को इस प्रकार सरल बनाया जा सकता है :



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

V1.26.0 से, हम Column की विशेषताओं को डायनामिक रूप से सेट कर सकते हैं



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

#### 8. डायनामिकशीटएट्रीब्यूट

V1.31.4 से हम शीट की विशेषताएँ डायनामिक रूप से सेट कर सकते हैं। हम शीट का नाम और स्थिति (दृश्यता) सेट कर सकते हैं।
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
हम नए गुण ExcelSheetAttribute का भी उपयोग कर सकते हैं:


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

v1.28.0 अब CSV में अंतिम पंक्ति के बाद N पंक्तियों का डाटा जोड़ने का समर्थन करता है


```csharp
// Origin
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// Insert 1 rows after last
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// Insert N rows after last
{
    var value = new[] {
          new { ID=4,Name ="Frank",InDate=new DateTime(2021,06,07)},
          new { ID=5,Name ="Gloria",InDate=new DateTime(2022,05,03)},
    };
    MiniExcel.Insert(path, value);
}
```
![image](https://user-images.githubusercontent.com/12729184/191023733-1e2fa732-db5c-4a3a-9722-b891fe5aa069.png)

v1.37.0 समर्थन करता है कि एक्सेल में मौजूदा वर्कबुक में एक नया शीट डाली जा सकती है


```csharp
// Origin excel
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// Insert a new sheet
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```
#### हटाएं(प्रतीक्षा में)

#### अपडेट(प्रतीक्षा में)



### एक्सेल प्रकार ऑटो चेक <a name="getstart5"></a>

- MiniExcel डिफ़ॉल्ट रूप से `फाइल एक्सटेंशन` के आधार पर जांचेगा कि यह xlsx है या csv, लेकिन इसमें गलतियां हो सकती हैं, कृपया इसे मैन्युअल रूप से निर्दिष्ट करें।
- स्ट्रीम से यह पता नहीं लगाया जा सकता कि वह किस एक्सेल से है, कृपया इसे मैन्युअल रूप से निर्दिष्ट करें।




```csharp
stream.SaveAs(excelType:ExcelType.CSV);
//or
stream.SaveAs(excelType:ExcelType.XLSX);
//or
stream.Query(excelType:ExcelType.CSV);
//or
stream.Query(excelType:ExcelType.XLSX);
```






### सीएसवी

#### नोट

- डिफ़ॉल्ट रूप से रिटर्न किया गया प्रकार `string` होता है, और मान को नंबर या दिनांक में परिवर्तित नहीं किया जाएगा, जब तक कि प्रकार को स्ट्रॉन्ग टाइपिंग जेनेरिक द्वारा परिभाषित न किया गया हो।



#### कस्टम सेपरेटर

डिफ़ॉल्ट रूप से सेपरेटर `,` होता है, आप कस्टमाइज़ेशन के लिए `Seperator` प्रॉपर्टी को संशोधित कर सकते हैं।


```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```
V1.30.1 से कस्टम सेपरेटर के लिए फंक्शन का समर्थन किया गया है (धन्यवाद @hyzx86)


```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```
#### कस्टम लाइन ब्रेक

डिफ़ॉल्ट रूप से `\r\n` न्यूलाइन कैरेक्टर है, आप अनुकूलन के लिए `NewLine` प्रॉपर्टी को संशोधित कर सकते हैं




```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```
#### कस्टम कोडिंग

- डिफ़ॉल्ट एन्कोडिंग "बाइट ऑर्डर मार्क्स से एन्कोडिंग का पता लगाएं" है (detectEncodingFromByteOrderMarks: true)
- यदि आपकी कोई कस्टम एन्कोडिंग आवश्यकताएँ हैं, तो कृपया StreamReaderFunc / StreamWriterFunc प्रॉपर्टी को संशोधित करें




```csharp
// Read
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// Write
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamWriterFunc = (stream) => new StreamWriter(stream, Encoding.GetEncoding("gb2312"))
};
MiniExcel.SaveAs(path, value,excelType:ExcelType.CSV, configuration: config);
```
#### खाली स्ट्रिंग को null के रूप में पढ़ें

डिफ़ॉल्ट रूप से, खाली मान string.Empty में मैप किए जाते हैं। आप इस व्यवहार को बदल सकते हैं


```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
   ReadEmptyStringAsNull = true
};
```
### डेटा रीडर

#### 1. गेटरीडर
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
###  असिंक

- v0.17.0 असिंक का समर्थन करता है (धन्यवाद isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))




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
-  v1.25.0 में `cancellationToken` का समर्थन है।



### अन्य

#### 1. एनम

सुनिश्चित करें कि एक्सेल और प्रॉपर्टी का नाम एक जैसा हो, सिस्टम स्वतः मैपिंग करेगा (केस असंवेदनशील)

![image](https://user-images.githubusercontent.com/12729184/116210595-9784b100-a775-11eb-936f-8e7a8b435961.png)

V0.18.0 से एनम विवरण का समर्थन है


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
![image](https://user-images.githubusercontent.com/12729184/133116630-27cc7161-099a-48b8-9784-cd1e443af3d1.png)

चूंकि 1.30.0 संस्करण से Excel Description को Enum में सपोर्ट किया गया है, धन्यवाद @KaneLeung

#### 2. CSV को XLSX में कनवर्ट करें या XLSX को CSV में कनवर्ट करें


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

संस्करण 1.22.0 से, आप नीचे दिए गए तरीके से कस्टम CultureInfo बना सकते हैं, सिस्टम डिफ़ॉल्ट `CultureInfo.InvariantCulture` है।


```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// or
MiniExcel.Query(path, configuration: config);
```
#### 4. कस्टम बफर आकार


```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```
#### 5. फास्टमोड

सिस्टम मेमोरी को नियंत्रित नहीं करेगा, लेकिन आप तेज़ सेव स्पीड प्राप्त कर सकते हैं।


```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```
#### 6. बैच में चित्र जोड़ें (MiniExcel.AddPicture)

कृपया बैच में पंक्तियों का डेटा उत्पन्न करने से पहले चित्र जोड़ें, अन्यथा AddPicture को कॉल करते समय सिस्टम अधिक मेमोरी का उपयोग करेगा।


```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // default null is first sheet
        CellAddress = "C3", // required
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // default PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // required
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```
![Image](https://github.com/user-attachments/assets/19c4d241-9753-4ede-96c8-f810c1a22247)

#### 7. शीट्स का आयाम प्राप्त करें

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```
### उदाहरण:

#### 1. SQLite और Dapper `बड़े आकार की फ़ाइल` SQL इन्सर्ट में OOM से बचाव

नोट : कृपया Query के बाद ToList/ToArray मेथड्स को न बुलाएँ, इससे सारा डेटा मेमोरी में लोड हो जाएगा


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





#### 2. ASP.NET Core 3.1 या MVC 5 में एक्सेल Xlsx डाउनलोड/अपलोड API डेमो [इसे आज़माएँ](https://raw.githubusercontent.com/mini-software/MiniExcel/master/tests/MiniExcel.Tests.AspNetCore)


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
</body></html{{"
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
            // do your logic etc.
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



#### 4. मेमोरीस्ट्रीम द्वारा WebForm एक्सेल निर्यात करें


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
#### 5. डायनामिक i18n मल्टी-लैंग्वेज और रोल अथॉरिटी प्रबंधन

उदाहरण की तरह, i18n और परमिशन मैनेजमेंट को संभालने के लिए एक मेथड बनाएं, और डायनामिक तथा कम मेमोरी प्रोसेसिंग प्रभाव प्राप्त करने के लिए `yield return to return IEnumerable<Dictionary<string, object>>` का उपयोग करें




```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us and Sales role");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "en-US";
        var role = "Sales";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
        MiniExcel.Query(path, true).Dump();
    }

    Console.WriteLine("zh-CN and PMC role");
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



### अक्सर पूछे जाने वाले प्रश्न (FAQ)

#### प्रश्न: यदि Excel हेडर शीर्षक क्लास प्रॉपर्टी नाम के बराबर नहीं है, तो मैपिंग कैसे करें?

उत्तर: कृपया ExcelColumnName एट्रिब्यूट का उपयोग करें

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### प्रश्न: एक साथ कई शीट्स को कैसे क्वेरी या एक्सपोर्ट करें?

उत्तर: `GetSheetNames` मेथड का उपयोग करें, साथ में  Query  के sheetName पैरामीटर के साथ।




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

#### प्रश्न: शीट की दृश्यता के बारे में जानकारी कैसे प्राप्त करें या एक्सपोर्ट करें?

उत्तर: `GetSheetInformations` विधि।




```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // next sheet index - numbered from 0
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // sheet name
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // sheet visibility state - visible / hidden
}
```
#### प्रश्न: क्या Count का उपयोग करने से सारा डेटा मेमोरी में लोड हो जाएगा?

नहीं, इमेज टेस्ट में 1 मिलियन पंक्तियाँ * 10 कॉलम का डेटा है, अधिकतम मेमोरी उपयोग <60MB है, और इसमें 13.65 सेकंड लगते हैं

![image](https://user-images.githubusercontent.com/12729184/117118518-70586000-adc3-11eb-9ce3-2ba76cf8b5e5.png)

#### प्रश्न: Query में पूर्णांक इंडेक्स का उपयोग कैसे करें?

Query का डिफ़ॉल्ट इंडेक्स स्ट्रिंग Key होता है: A,B,C.... यदि आप इसे संख्यात्मक इंडेक्स में बदलना चाहते हैं, तो कृपया निम्नलिखित विधि बनाएं ताकि इसे कन्वर्ट किया जा सके



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
#### प्रश्न. जब मान खाली होता है तो एक्सपोर्टिंग एक्सेल के समय बिना शीर्षक का खाली एक्सेल जनरेट होता है

क्योंकि MiniExcel JSON.NET के समान लॉजिक का उपयोग करता है जिससे मान से डायनामिकली टाइप प्राप्त की जाती है ताकि API ऑपरेशनों को सरल बनाया जा सके, डेटा के बिना टाइप पता नहीं चल सकती। बेहतर समझ के लिए [issue #133](https://github.com/mini-software/MiniExcel/issues/133) देख सकते हैं।

![image](https://user-images.githubusercontent.com/12729184/122639771-546c0c00-d12e-11eb-800c-498db27889ca.png)

> Strong type और DataTable हेडर जेनरेट करेंगे, लेकिन Dictionary में एक्सेल फिर भी खाली रहेगा

#### प्रश्न. खाली पंक्ति पर foreach कैसे रोका जाए?

MiniExcel को `LINQ TakeWhile` के साथ उपयोग किया जा सकता है जिससे foreach इटरेटर को रोका जा सके।

![Image](https://user-images.githubusercontent.com/12729184/130209137-162621c2-f337-4479-9996-beeac65bc4d4.png)

#### प्रश्न. खाली पंक्तियाँ कैसे हटाएं?

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



डेटाटेबल :



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




#### प्रश्न: SaveAs(path,value) का उपयोग करके मौजूदा फ़ाइल को कैसे बदलें और "The file ...xlsx already exists" त्रुटि के बिना सहेजें?


कृपया कस्टम फ़ाइल बनाने की लॉजिक के लिए Stream क्लास का उपयोग करें, उदाहरण के लिए:


```C#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```




या, V1.25.0 से, SaveAs में overwriteFile पैरामीटर का समर्थन है ताकि मौजूदा फ़ाइल को ओवरराइट करने को सक्षम/अक्षम किया जा सके


```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```



### सीमाएँ और सावधानियाँ

- अभी xls और एन्क्रिप्टेड फाइल का समर्थन नहीं है
- xlsm केवल Query का समर्थन करता है



### संदर्भ

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)



### धन्यवाद

####  [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

इस प्रोजेक्ट के लिए मुफ्त All product IDE उपलब्ध कराने के लिए धन्यवाद ([लाइसेंस](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))



### योगदान साझा करें और दान करें
लिंक https://github.com/orgs/mini-software/discussions/754

### योगदानकर्ता

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---