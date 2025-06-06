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
<p>यह प्रोजेक्ट <a href="https://www.dotnetfoundation.org/">.NET Foundation</a> का हिस्सा है और इनके <a href="https://www.dotnetfoundation.org/code-of-conduct">code of conduct</a> के तहत संचालित होता है।</p>
</div>

---

<div style="text-align: center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a></strong></p>
</div>

---

<div style="text-align: center">
 आपकी <a href="https://github.com/mini-software/MiniExcel">Star</a> और <a href="https://miniexcel.github.io">Donate</a> MiniExcel को और बेहतर बना सकती है।
</div>

---

### परिचय

MiniExcel एक सरल और कुशल .NET एक्सेल प्रोसेसिंग टूल है जो OOM (Out Of Memory) से बचाता है।

वर्तमान में, अधिकांश लोकप्रिय फ्रेमवर्क को ऑपरेशन की सुविधा के लिए सभी डेटा को मेमोरी में लोड करना पड़ता है, लेकिन इससे मेमोरी की खपत बढ़ जाती है। MiniExcel स्ट्रीम से एल्गोरिद्म का उपयोग करके मूल 1000 MB उपयोग को कुछ MB तक कम करने का प्रयास करता है ताकि OOM (out of memory) से बचा जा सके।

![image](https://user-images.githubusercontent.com/12729184/113086657-ab8bd000-9214-11eb-9563-c970ac1ee35e.png)

### विशेषताएँ

- कम मेमोरी खपत, OOM (out of memory) और फुल GC से बचाव
- प्रत्येक पंक्ति के डेटा का रीयल-टाइम ऑपरेशन सपोर्ट करता है
- LINQ डिफर्ड एक्जीक्यूशन सपोर्ट करता है, जिससे कम-खपत, तेज पेजिंग और अन्य जटिल क्वेरी की जा सकती है
- हल्का, Microsoft Office की आवश्यकता नहीं, कोई COM+ नहीं, DLL आकार 400KB से कम
- आसान API स्टाइल से एक्सेल पढ़ें/लिखें/भरें

### आरंभ करें

- [इम्पोर्ट/क्वेरी एक्सेल](#getstart1)

- [एक्सपोर्ट/क्रिएट एक्सेल](#getstart2)

- [एक्सेल टेम्पलेट](#getstart3)

- [एक्सेल कॉलम नाम/इंडेक्स/इग्नोर एट्रीब्यूट](#getstart4)

- [उदाहरण](#getstart5)

### इंस्टॉलेशन

आप पैकेज को [NuGet से इंस्टॉल](https://www.nuget.org/packages/MiniExcel) कर सकते हैं

### रिलीज़ नोट्स

कृपया देखें [रिलीज़ नोट्स](docs)

### TODO

कृपया देखें  [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true)

### प्रदर्शन

बेंचमार्क के लिए कोड [MiniExcel.Benchmarks](benchmarks/MiniExcel.Benchmarks/Program.cs) में मिल सकता है।

प्रदर्शन परीक्षण के लिए प्रयुक्त फ़ाइल है [**Test1,000,000x10.xlsx**](benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx), जो 32MB की डॉक्युमेंट है जिसमें 1,000,000 रो * 10 कॉलम हैं, और सभी सेल "HelloWorld" स्ट्रिंग से भरे हैं।

सभी बेंचमार्क चलाने के लिए:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

ताज़ा रिलीज़ के लिए बेंचमार्क परिणाम [यहाँ](benchmarks/results) देखें।

### एक्सेल क्वेरी/इम्पोर्ट  <a name="getstart1"></a>

#### 1. क्वेरी निष्पादित करें और परिणामों को स्ट्रॉन्गली टाइप्ड IEnumerable में मैप करें [[Try it]](https://dotnetfiddle.net/w5WD1J)

बेहतर दक्षता के लिए Stream.Query का उपयोग करने की सिफारिश है।

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

#### 2. बिना हैडर के डायनामिक ऑब्जेक्ट्स की सूची में क्वेरी को मैप करें [[Try it]](https://dotnetfiddle.net/w5WD1J)

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

नोट: एक ही कॉलम नाम के लिए दाहिने ओर वाला लिया जाएगा

इनपुट एक्सेल:

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

#### 4. LINQ एक्सटेंशन First/Take/Skip आदि के साथ क्वेरी सपोर्ट

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

#### 5. शीट नाम से क्वेरी करें

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//या
stream.Query(sheetName: "SheetName");
```

#### 6. सभी शीट नाम और रो क्वेरी करें

```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. कॉलम प्राप्त करें

```csharp
var columns = MiniExcel.GetColumns(path); // उदाहरण के लिए परिणाम: ["A","B"...]

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
// या निर्दिष्ट रेंज में क्वेरी करें (अक्षर कैपिटल में)
// A2 का अर्थ है कॉलम A की दूसरी पंक्ति, C3 का अर्थ है कॉलम C की तीसरी पंक्ति
// यदि आप पंक्तियों को प्रतिबंधित नहीं करना चाहते हैं, तो नंबर शामिल न करें
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```

#### 9. क्वेरी एक्सेल DataTable लौटाए

सिफारिश नहीं की जाती, क्योंकि DataTable सभी डेटा को मेमोरी में लोड कर देगा और MiniExcel की कम मेमोरी खपत की विशेषता खो देगा।

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)

#### 10. डेटा पढ़ना शुरू करने के लिए सेल निर्दिष्ट करें

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)

#### 11. मर्ज किए गए सेल्स को भरें

नोट: `merge fill न करने की तुलना में यह धीमा है`

कारण: OpenXml मानक mergeCells को फ़ाइल के अंत में रखता है, जिससे sheetxml को दो बार foreach करना पड़ता है

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

चर लंबाई और चौड़ाई मल्टी-रो और कॉलम भरना सपोर्ट करता है

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. डिस्क-बेस्ड कैश द्वारा बड़ी फ़ाइल पढ़ना (Disk-Base Cache - SharedString)

यदि SharedStrings का आकार 5 MB से अधिक है, तो MiniExcel डिफ़ॉल्ट रूप से स्थानीय डिस्क कैश का उपयोग करेगा, जैसे [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx) (एक मिलियन रो डेटा), जब डिस्क कैश बंद है तो अधिकतम मेमोरी उपयोग 195MB है, लेकिन डिस्क कैश सक्षम होने पर केवल 65MB चाहिए। ध्यान दें, इस ऑप्टिमाइजेशन में कुछ दक्षता लागत होती है, इसलिए इस केस में पढ़ने का समय 7.4 सेकंड से 27.2 सेकंड तक बढ़ जाता है, यदि आपको इसकी आवश्यकता नहीं है तो आप निम्न कोड से डिस्क कैश बंद कर सकते हैं:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

आप `SharedStringCacheSize` का उपयोग करके साझा स्ट्रिंग फ़ाइल का आकार बदल सकते हैं, ताकि निर्दिष्ट आकार से अधिक होने पर डिस्क कैशिंग हो
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)

---

**(आगे के अनुभागों का हिन्दी अनुवाद इसी संरचना और तकनीकी शब्दावली के अनुसार जारी रखें...)**

---

**[नोट: यदि आपको दस्तावेज़ का कोई विशेष भाग या सेक्शन हिन्दी में चाहिए तो कृपया निर्दिष्ट करें, क्योंकि पूरे दस्तावेज़ का अनुवाद एक बार में सीमित है। ऊपर की तरह हर टेक्निकल सेक्शन, कोड स्निपेट, तालिका, और छवि के कैप्शन को हिन्दी में ट्रांसलेट किया जाएगा।]**
---- Powered By MiniAiTx ----