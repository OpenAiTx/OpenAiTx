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
<p>โปรเจกต์นี้เป็นส่วนหนึ่งของ <a href="https://www.dotnetfoundation.org/">.NET Foundation</a> และดำเนินการภายใต้ <a href="https://www.dotnetfoundation.org/code-of-conduct">code of conduct</a> ของพวกเขา </p>
</div>

---

<div style="text-align: center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a></strong></p>
</div>

---

<div style="text-align: center">
 การ <a href="https://github.com/mini-software/MiniExcel">Star</a> และ <a href="https://miniexcel.github.io">Donate</a> ของคุณสามารถทำให้ MiniExcel ดีขึ้น
</div>

---

### บทนำ

MiniExcel คือเครื่องมือ .NET สำหรับประมวลผล Excel ที่เรียบง่ายและมีประสิทธิภาพ เพื่อหลีกเลี่ยงปัญหา OOM

ปัจจุบัน เฟรมเวิร์กยอดนิยมส่วนใหญ่ต้องโหลดข้อมูลทั้งหมดเข้าไปในหน่วยความจำเพื่อความสะดวกในการทำงาน แต่จะทำให้เกิดปัญหาการใช้หน่วยความจำสูง MiniExcel พยายามใช้อัลกอริทึมจาก stream เพื่อลดการใช้งานหน่วยความจำจาก 1000 MB เหลือเพียงไม่กี่ MB เพื่อหลีกเลี่ยง OOM (out of memory)

![image](https://user-images.githubusercontent.com/12729184/113086657-ab8bd000-9214-11eb-9563-c970ac1ee35e.png)

### คุณสมบัติ

- ใช้หน่วยความจำน้อย หลีกเลี่ยง OOM (out of memory) และ full GC
- รองรับการทำงานกับข้อมูลแต่ละแถวแบบ real time
- รองรับการใช้ LINQ แบบ deferred execution ทำให้สามารถทำ query ที่ซับซ้อนและแบ่งหน้าได้รวดเร็วโดยใช้ทรัพยากรต่ำ
- น้ำหนักเบา ไม่ต้องติดตั้ง Microsoft Office ไม่มี COM+ ขนาด DLL น้อยกว่า 400KB
- API ใช้งานง่ายสำหรับอ่าน/เขียน/เติมข้อมูลใน Excel

### เริ่มต้นใช้งาน

- [นำเข้า/Query Excel](#getstart1)

- [ส่งออก/สร้าง Excel](#getstart2)

- [Excel Template](#getstart3)

- [Excel Column Name/Index/Ignore Attribute](#getstart4)

- [ตัวอย่าง](#getstart5)

### การติดตั้ง

คุณสามารถติดตั้ง package [จาก NuGet](https://www.nuget.org/packages/MiniExcel)

### บันทึกการออกรุ่น

โปรดตรวจสอบ [Release Notes](docs)

### สิ่งที่ต้องทำ

โปรดตรวจสอบ [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true)

### ประสิทธิภาพ

โค้ดสำหรับการทดสอบ benchmark สามารถดูได้ที่ [MiniExcel.Benchmarks](benchmarks/MiniExcel.Benchmarks/Program.cs)

ไฟล์ที่ใช้ในการทดสอบประสิทธิภาพคือ [**Test1,000,000x10.xlsx**](benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx) เป็นไฟล์ขนาด 32MB มีข้อมูล 1,000,000 แถว * 10 คอลัมน์ โดยแต่ละเซลล์มีค่า "HelloWorld"

หากต้องการรัน benchmark ทั้งหมด ใช้คำสั่ง:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

คุณสามารถดูผลลัพธ์ benchmark สำหรับ release ล่าสุดได้ [ที่นี่](benchmarks/results)

### Query/Import Excel  <a name="getstart1"></a>

#### 1. รัน query และ map ผลลัพธ์ไปยัง IEnumerable แบบ strongly typed [[ทดลองใช้งาน]](https://dotnetfiddle.net/w5WD1J)

แนะนำให้ใช้ Stream.Query เนื่องจากมีประสิทธิภาพดีกว่า

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

// หรือ

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. รัน query และ map เป็น list ของ dynamic object โดยไม่ใช้ header [[ทดลองใช้งาน]](https://dotnetfiddle.net/w5WD1J)

* คีย์ dynamic คือ `A.B.C.D..`

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp

var rows = MiniExcel.Query(path).ToList();

// หรือ
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```

#### 3. รัน query โดยใช้แถวแรกเป็น header [[ทดลองใช้งาน]](https://dotnetfiddle.net/w5WD1J)

หมายเหตุ: หากมีชื่อคอลัมน์ซ้ำ จะใช้ตัวขวาสุด

Input Excel :

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |

```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// หรือ

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```

#### 4. Query รองรับ LINQ Extension First/Take/Skip ...ฯลฯ

Query First
```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// หรือ

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```

เปรียบเทียบประสิทธิภาพ MiniExcel/ExcelDataReader/ClosedXML/EPPlus
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### 5. Query โดยระบุชื่อ sheet

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//หรือ
stream.Query(sheetName: "SheetName");
```

#### 6. Query ชื่อ sheet ทั้งหมดและ rows

```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. Get Columns

```csharp
var columns = MiniExcel.GetColumns(path); // เช่น ผลลัพธ์ : ["A","B"...]

var cnt = columns.Count;  // นับจำนวนคอลัมน์
```

#### 8. Dynamic Query cast row เป็น `IDictionary<string,object>`

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// หรือ
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// หรือ Query เฉพาะช่วง (ใช้ตัวอักษรพิมพ์ใหญ่)
// A2 คือแถวที่สองของคอลัมน์ A, C3 คือแถวที่สามของคอลัมน์ C
// ถ้าไม่ต้องการจำกัดแถว ไม่ต้องใส่ตัวเลข
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```

#### 9. Query Excel คืนค่า DataTable

ไม่แนะนำ เพราะ DataTable จะโหลดข้อมูลทั้งหมดเข้า memory และทำให้เสียข้อดีเรื่องการใช้ memory ต่ำของ MiniExcel

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)

#### 10. ระบุ cell ที่จะเริ่มอ่านข้อมูล

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)

#### 11. Fill เซลล์ที่ถูก Merge

หมายเหตุ: ประสิทธิภาพจะช้ากว่ากรณีไม่ใช้ merge fill

เหตุผล: มาตรฐาน OpenXml วาง mergeCells ไว้ท้ายไฟล์ ทำให้ต้องวนลูปอ่าน sheetxml 2 รอบ

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

รองรับการ fill หลายแถวและหลายคอลัมน์ที่มีความยาว/กว้างแตกต่างกัน

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. อ่านไฟล์ขนาดใหญ่ด้วย disk-base cache (Disk-Base Cache - SharedString)

ถ้า SharedStrings ขนาดเกิน 5 MB MiniExcel จะใช้ local disk cache โดยอัตโนมัติ เช่น [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx) (ข้อมูลล้านแถว) หากปิด disk cache จะใช้หน่วยความจำสูงสุด 195MB แต่ถ้าเปิด disk cache ใช้เพียง 65MB ทั้งนี้จะแลกกับเวลาอ่านที่เพิ่มจาก 7.4 วินาทีเป็น 27.2 วินาที หากไม่ต้องการใช้สามารถปิด disk cache ดังนี้:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

สามารถใช้ `SharedStringCacheSize ` เพื่อเปลี่ยนขนาดไฟล์ sharedString ที่จะใช้ disk cache
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)

### Create/Export Excel  <a name="getstart2"></a>

1. ต้องเป็นชนิดที่ไม่ abstract และมี constructor แบบไม่มี parameter ที่เป็น public

2. MiniExcel รองรับ IEnumerable Deferred Execution ถ้าต้องการใช้หน่วยความจำน้อยสุด กรุณาอย่าเรียกใช้ ToList

เช่น: ใช้หรือไม่ใช้ ToList กับการใช้ memory
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)

#### 1. Anonymous หรือ strongly type [[ทดลองใช้งาน]](https://dotnetfiddle.net/w5WD1J)

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

ผลลัพธ์ที่ได้:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |

#### 3.  IDataReader
- `แนะนำ` เพราะสามารถหลีกเลี่ยงการโหลดข้อมูลทั้งหมดเข้า memory
```csharp
MiniExcel.SaveAs(path, reader);
```

![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

DataReader ส่งออกหลาย sheet (แนะนำโดย Dapper ExecuteReader)

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

- `ไม่แนะนำ` เพราะจะโหลดข้อมูลทั้งหมดเข้า memory

- DataTable จะใช้ Caption เป็นชื่อคอลัมน์ก่อน จากนั้นใช้ columname

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

ขอบคุณ @shaofing #552 , กรุณาใช้ `CommandDefinition + CommandFlags.NoCache`

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // หมายเหตุ: QueryAsync จะ throw exception ปิดการเชื่อมต่อ
    MiniExcel.SaveAs(path, rows);
}
```

โค้ดด้านล่างนี้จะโหลดข้อมูลทั้งหมดเข้า memory

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(@"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2");
    MiniExcel.SaveAs(path, rows);
}
```

#### 6. SaveAs ไปยัง MemoryStream  [[ทดลองใช้งาน]](https://dotnetfiddle.net/JOen0e)

```csharp
using (var stream = new MemoryStream()) //รองรับ FileStream,MemoryStream ฯลฯ
{
    stream.SaveAs(values);
}
```

ตัวอย่าง: API สำหรับส่งออก excel

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

#### 7. สร้างหลาย Sheets

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

#### 8. ตัวเลือก TableStyles

สไตล์เริ่มต้น

![image](https://user-images.githubusercontent.com/12729184/138234373-cfa97109-b71f-4711-b7f5-0eaaa4a0a3a6.png)

ไม่กำหนด style

```csharp
var config = new OpenXmlConfiguration()
{
     TableStyles = TableStyles.None
};
MiniExcel.SaveAs(path, value,configuration:config);
```

![image](https://user-images.githubusercontent.com/12729184/118784917-f3e57700-b8c2-11eb-8718-8d955b1bc197.png)

#### 9. AutoFilter

ตั้งแต่ v0.19.0 `OpenXmlConfiguration.AutoFilter` สามารถเปิด/ปิด AutoFilter ได้ ค่า default คือ `true` การตั้งค่าง่าย ๆ ดังนี้:

```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```

#### 10. สร้างรูปภาพ

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

#### 11. ส่งออกไฟล์แบบ Byte Array

ตั้งแต่ 1.22.0 เมื่อ value เป็นชนิด `byte[]` ระบบจะบันทึก path ของไฟล์ใน cell โดยอัตโนมัติ และเมื่อ import จะ convert เป็น `byte[]` ได้ ถ้าไม่ต้องการใช้ สามารถตั้งค่า `OpenXmlConfiguration.EnableConvertByteArray` เป็น `false` เพื่อเพิ่มประสิทธิภาพ

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### 12. Merge เซลล์แนวตั้งที่เหมือนกัน

ฟีเจอร์นี้รองรับเฉพาะไฟล์ `xlsx` และ merge เซลล์แนวตั้งระหว่างแท็ก @merge และ @endmerge
สามารถใช้ @mergelimit เพื่อจำกัดขอบเขตการ merge

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

ตัวอย่างไฟล์ก่อนและหลัง merge:

#### 13. ข้ามค่าที่เป็น null

เพิ่มตัวเลือกเพื่อเขียน cell ว่างสำหรับค่า null:

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
     EnableWriteNullValueCell = true // ค่าเริ่มต้น
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

#### 14. Freeze Panes
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // ค่า default คือ 1
    FreezeColumnCount = 2   // ค่า default คือ 0
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

### เติมข้อมูลลง Excel Template <a name="getstart3"></a>

- ประกาศคล้าย template Vue `{{ชื่อตัวแปร}}` หรือ collection rendering `{{ชื่อcollection.ชื่อfield}}`
- Collection rendering รองรับ IEnumerable/DataTable/DapperRow

#### 1. เติมข้อมูลพื้นฐาน

Template:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

ผลลัพธ์:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

โค้ด:
```csharp
// 1. โดย POCO
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);

// 2. โดย Dictionary
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```

#### 2. เติมข้อมูล IEnumerable

> หมายเหตุ: จะใช้ IEnumerable แรกของคอลัมน์เดียวกันเป็นพื้นฐานในการเติม list

Template:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

ผลลัพธ์:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

โค้ด:
```csharp
//1. โดย POCO
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

//2. โดย Dictionary
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

#### 3. เติมข้อมูล Complex

> หมายเหตุ: รองรับ multi-sheets และใช้ตัวแปรเดียวกัน

Template:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

ผลลัพธ์:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)

```csharp
// 1. โดย POCO
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

// 2. โดย Dictionary
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

#### 4. เติมข้อมูลขนาดใหญ่แบบประสิทธิภาพสูง

> หมายเหตุ: ใช้ IEnumerable แบบ deferred execution ไม่ ToList จะประหยัด memory สูงสุดใน MiniExcel

![image](https://user-images.githubusercontent.com/12729184/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)

#### 5. Cell value auto mapping type

Template

![image](https://user-images.githubusercontent.com/12729184/114802504-64830a80-9dd0-11eb-8d56-8e8c401b3ace.png)

ผลลัพธ์

![image](https://user-images.githubusercontent.com/12729184/114802419-43221e80-9dd0-11eb-9ffe-a2ce34fe7076.png)

Class

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

Code

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

#### 6. ตัวอย่าง: List Github Projects

Template

![image](https://user-images.githubusercontent.com/12729184/115068623-12073280-9f25-11eb-9124-f4b3efcdb2a7.png)

ผลลัพธ์

![image](https://user-images.githubusercontent.com/12729184/115068639-1a5f6d80-9f25-11eb-9f45-27c434d19a78.png)

Code

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

#### 7. เติมข้อมูลแบบ Grouped

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
##### 1. ใช้แท็ก `@group` และ `@header`

##### 2. ใช้แท็ก @group โดยไม่ใช้ @header

##### 3. ไม่ใช้แท็ก @group

#### 8. If/ElseIf/Else Statements ใน cell

กติกา:
1. รองรับ DateTime, Double, Int กับตัวดำเนินการ ==, !=, >, >=, <, <=
2. String รองรับ ==, !=
3. แต่ละ statement ต้องขึ้นบรรทัดใหม่
4. ต้องมีช่องว่างหนึ่งช่องก่อนและหลัง operator
5. ไม่ควรมีบรรทัดใหม่ใน statement
6. Cell ต้องอยู่ในรูปแบบที่กำหนด

```csharp
@if(name == Jack)
{{employees.name}}
@elseif(name == Neo)
Test {{employees.name}}
@else
{{employees.department}}
@endif
```

#### 9. DataTable เป็น parameter

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

#### 10. สูตรคำนวณ (Formulas)

##### 1. ตัวอย่าง
เติมสูตรด้วย `$` และใช้ `$enumrowstart` และ `$enumrowend` สำหรับอ้างอิงแถวเริ่มและสิ้นสุดของ enumerable

##### 2. ตัวอย่างสูตรอื่น:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| Sum          | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| Alt. Average | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| Range        | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |

#### 11. อื่น ๆ

##### 1. ตรวจสอบ key ของ template parameter

ตั้งแต่ V1.24.0 ค่า default จะไม่ throw error หาก key หาย และจะเติมเป็น empty string, `IgnoreTemplateParameterMissing` สามารถควบคุมได้ว่าจะ throw exception หรือไม่

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```

### Excel Column Name/Index/Ignore Attribute <a name="getstart4"></a>

#### 1. ระบุชื่อคอลัมน์, index คอลัมน์, ข้ามคอลัมน์

ตัวอย่าง Excel

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

โค้ด

```csharp
public class ExcelAttributeDemo
{
    [ExcelColumnName("Column1")]
    public string Test1 { get; set; }
    [ExcelColumnName("Column2")]
    public string Test2 { get; set; }
    [ExcelIgnore]
    public string Test3 { get; set; }
    [ExcelColumnIndex("I")] // ระบบจะเปลี่ยน "I" เป็น index 8
    public string Test4 { get; set; }
    public string Test5 { get; } // ไม่มี set จะถูกข้าม
    public string Test6 { get; private set; } // set ไม่เป็น public จะถูกข้าม
    [ExcelColumnIndex(3)] // เริ่มที่ 0
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

#### 2. Custom Format (ExcelFormatAttribute)

ตั้งแต่ V0.21.0 รองรับคลาสที่มีเมธอด `ToString(string content)` สำหรับ format

Class

```csharp
public class Dto
{
    public string Name { get; set; }

    [ExcelFormat("MMMM dd, yyyy")]
    public DateTime InDate { get; set; }
}
```

Code

```csharp
var value = new Dto[] {
    new Issue241Dto{ Name="Jack",InDate=new DateTime(2021,01,04)},
    new Issue241Dto{ Name="Henry",InDate=new DateTime(2020,04,05)},
};
MiniExcel.SaveAs(path, value);
```

#### 3. กำหนดความกว้างของคอลัมน์ (ExcelColumnWidthAttribute)

```csharp
public class Dto
{
    [ExcelColumnWidth(20)]
    public int ID { get; set; }
    [ExcelColumnWidth(15.50)]
    public string Name { get; set; }
}
```

#### 4. แมพชื่อคอลัมน์หลายชื่อกับ property เดียวกัน

```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```

#### 5. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

ตั้งแต่ 1.24.0 รองรับ System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

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

ตั้งแต่ V1.26.0 สามารถรวม attribute หลายตัวได้ เช่น:
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

ตั้งแต่ V1.26.0 สามารถตั้งค่า attribute ของ Column แบบ dynamic ได้
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

#### 8. DynamicSheetAttribute

ตั้งแต่ V1.31.4 สามารถตั้งค่า attribute ของ Sheet แบบ dynamic ได้ เช่น ตั้งชื่อ sheet หรือสถานะ (visibility)
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

สามารถใช้ attribute ExcelSheetAttribute ได้เช่นกัน:

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

### Add, Delete, Update

#### Add

v1.28.0 รองรับ CSV insert N แถวหลังแถวสุดท้าย

```csharp
// ต้นฉบับ
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// แทรก 1 แถวหลังสุดท้าย
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// แทรก N แถวหลังสุดท้าย
{
    var value = new[] {
          new { ID=4,Name ="Frank",InDate=new DateTime(2021,06,07)},
          new { ID=5,Name ="Gloria",InDate=new DateTime(2022,05,03)},
    };
    MiniExcel.Insert(path, value);
}
```

v1.37.0 รองรับ excel insert sheet ใหม่เข้า workbook เดิม

```csharp
// ต้นฉบับ excel
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// แทรก sheet ใหม่
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```

#### Delete(รอ)

#### Update(รอ)

### ตรวจสอบประเภท Excel อัตโนมัติ <a name="getstart5"></a>

- MiniExcel จะตรวจสอบว่าเป็น xlsx หรือ csv โดยดูจากนามสกุลไฟล์ ถ้าไม่แน่ใจ กรุณาระบุเอง
- Stream ไม่สามารถรู้ชนิดไฟล์ กรุณาระบุเอง

```csharp
stream.SaveAs(excelType:ExcelType.CSV);
//หรือ
stream.SaveAs(excelType:ExcelType.XLSX);
//หรือ
stream.Query(excelType:ExcelType.CSV);
//หรือ
stream.Query(excelType:ExcelType.XLSX);
```

### CSV

#### หมายเหตุ

- ค่า default คืนค่าเป็น `string` และจะไม่ถูกแปลงเป็นตัวเลขหรือวันที่ เว้นแต่จะกำหนด type ด้วย generic

#### กำหนดตัวคั่นเอง

ค่า default ใช้ `,` เป็นตัวคั่น สามารถเปลี่ยน `Seperator` ได้

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

ตั้งแต่ V1.30.1 รองรับฟังก์ชัน custom separator (ขอบคุณ @hyzx86)

```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```

#### กำหนดขึ้นบรรทัดใหม่เอง

ค่า default ใช้ `\r\n` เป็น newline สามารถเปลี่ยน `NewLine` ได้

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

#### กำหนด encoding เอง

- encoding เริ่มต้นคือ "Detect Encoding From Byte Order Marks"  (detectEncodingFromByteOrderMarks: true)
- ถ้าต้องการ encoding แบบ custom ให้เปลี่ยน StreamReaderFunc / StreamWriterFunc

```csharp
// อ่าน
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// เขียน
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamWriterFunc = (stream) => new StreamWriter(stream, Encoding.GetEncoding("gb2312"))
};
MiniExcel.SaveAs(path, value,excelType:ExcelType.CSV, configuration: config);
```

#### อ่านค่าว่างเป็น null

ค่า default ช่องว่างจะถูก map เป็น string.Empty สามารถเปลี่ยนได้

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
   ReadEmptyStringAsNull = true
};
```

### DataReader

#### 1. GetReader
ตั้งแต่ 1.23.0 สามารถ GetDataReader ได้

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

- v0.17.0 รองรับ Async (ขอบคุณ isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))

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

-  v1.25.0 รองรับ `cancellationToken`

### อื่น ๆ

#### 1. Enum

ชื่อ enum และ property ใน excel ต้องตรงกัน ระบบจะ mapping อัตโนมัติ (case insensitive)

ตั้งแต่ V0.18.0 รองรับ Enum Description

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

ตั้งแต่ 1.30.0 รองรับ excel Description to Enum (ขอบคุณ @KaneLeung)

#### 2. แปลง CSV เป็น XLSX หรือ XLSX เป็น CSV

```csharp
MiniExcel.ConvertXlsxToCsv(xlsxPath, csvPath);
MiniExcel.ConvertXlsxToCsv(xlsxStream, csvStream);
MiniExcel.ConvertCsvToXlsx(csvPath, xlsxPath);
MiniExcel.ConvertCsvToXlsx(csvStream, xlsxStream);
```

#### 3. กำหนด CultureInfo เอง

ตั้งแต่ 1.22.0 สามารถกำหนด CultureInfo ได้เอง ค่า default `CultureInfo.InvariantCulture`

```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// หรือ
MiniExcel.Query(path, configuration: config);
```

#### 4. กำหนด Buffer Size เอง
```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```

#### 5. FastMode

ระบบจะไม่ควบคุม memory แต่จะได้ speed การ save ที่เร็วขึ้น

```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```

#### 6. Batch Add Image (MiniExcel.AddPicture)

```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // default null คือ sheet แรก
        CellAddress = "C3", // จำเป็นต้องระบุ
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // default PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // จำเป็นต้องระบุ
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```

#### 7. Get Sheets Dimension

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```

### ตัวอย่าง:

#### 1. SQLite & Dapper `Large Size File` SQL Insert หลีกเลี่ยง OOM

หมายเหตุ: กรุณาอย่าใช้ ToList/ToArray หลัง Query เพราะจะโหลดข้อมูลทั้งหมดเข้า memory

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

#### 2. ASP.NET Core 3.1 หรือ MVC 5 Download/Upload Excel Xlsx API Demo [ทดลอง](tests/MiniExcel.Tests.AspNetCore)

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

####  3. Query แบบแบ่งหน้า

```csharp
void Main()
{
    var rows = MiniExcel.Query(path);

    Console.WriteLine("==== หน้า 1 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:1));
    Console.WriteLine("==== หน้า 50 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:50));
    Console.WriteLine("==== หน้า 5000 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:5000));
}

public static IEnumerable<T> Page<T>(IEnumerable<T> en, int pageSize, int page)
{
    return en.Skip(page * pageSize).Take(pageSize);
}
```

#### 4. WebForm ส่งออก Excel โดยใช้ memorystream

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

#### 5. Dynamic i18n multi-language และการจัดการ role authority

สร้าง method เพื่อจัดการ i18n และ permission management และใช้ `yield return` เพื่อ return IEnumerable<Dictionary<string, object>> เพื่อประมวลผลแบบ dynamic และใช้ memory ต่ำ

```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us และ Sales role");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "en-US";
        var role = "Sales";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
        MiniExcel.Query(path, true).Dump();
    }

    Console.WriteLine("zh-CN และ PMC role");
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
            newOrder.Add("ลูกค้า", order.CustomerID);
            newOrder.Add("เลขที่คำสั่งซื้อ", order.OrderNo);
            newOrder.Add("รหัสสินค้า", order.ProductID);
            newOrder.Add("จำนวน", order.Qty);
            if (role == "Sales")
                newOrder.Add("ราคา", order.Amt);
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

### คำถามที่พบบ่อย (FAQ)

#### Q: ชื่อหัวตาราง Excel ไม่ตรงกับ property ใน class แมพยังไง?

A. กรุณาใช้ ExcelColumnName attribute

#### Q. Query หรือ export หลาย sheet ได้อย่างไร?

A. ใช้เมธอด `GetSheetNames` กับ parameter sheetName ใน Query

```csharp
var sheets = MiniExcel.GetSheetNames(path);
foreach (var sheet in sheets)
{
    Console.WriteLine($"sheet name : {sheet} ");
    var rows = MiniExcel.Query(path,useHeaderRow:true,sheetName:sheet);
    Console.WriteLine(rows);
}
```

#### Q. Query หรือ export ข้อมูลเกี่ยวกับ visibility ของ sheet ได้อย่างไร?

A. ใช้เมธอด `GetSheetInformations`

```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // index ของ sheet เริ่มที่ 0
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // ชื่อ sheet
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // สถานะ visibility - visible / hidden
}
```

#### Q. ใช้ Count จะโหลดข้อมูลทั้งหมดเข้า memory หรือไม่?

ไม่ ภาพทดสอบมี 1 ล้านแถว*10 คอลัมน์ ใช้ memory สูงสุด <60MB และใช้เวลา 13.65 วินาที

#### Q. Query โดยใช้ index เป็นตัวเลขได้ไหม?

โดยปกติ index ของ Query คือ string Key: A,B,C.... ถ้าต้องการใช้ index ตัวเลข สามารถเขียน method แปลงเอง

#### Q. export Excel ที่ value ว่าง จะได้ไฟล์เปล่า

เพราะ MiniExcel ใช้ logic คล้าย JSON.NET ดึง type จาก value แบบ dynamic เพื่อให้งานง่าย ถ้าไม่มีข้อมูล type จะไม่ถูกกำหนด

> Strong type & DataTable จะสร้าง header, แต่ Dictionary จะยังได้ Excel ว่าง

#### Q. หยุด foreach เมื่อเจอ row ว่างได้อย่างไร?

ใช้ LINQ TakeWhile กับ MiniExcel เพื่อหยุด iterator เมื่อเจอ row ว่าง

#### Q. ลบ row ว่างได้อย่างไร?

IEnumerable:

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

DataTable:

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

#### Q. SaveAs(path,value) จะเขียนทับไฟล์เดิมโดยไม่ error "The file ...xlsx already exists" ได้อย่างไร?

ใช้ class Stream เพื่อกำหนด logic การสร้างไฟล์เอง เช่น:

```C#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```

หรือ ตั้งแต่ V1.25.0 SaveAs รองรับ parameter overwriteFile เพื่ออนุญาตเขียนทับไฟล์เดิม

```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```

### ข้อจำกัด

- ยังไม่รองรับ xls และไฟล์เข้ารหัส
- xlsm รองรับเฉพาะ Query

### อ้างอิง

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)

### ขอบคุณ

####  [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

ขอบคุณสำหรับการสนับสนุน IDE All product ฟรีสำหรับโปรเจกต์นี้ ([License](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))

### การแบ่งปันผลงาน/การบริจาค
ลิงก์ https://github.com/orgs/mini-software/discussions/754

### ผู้ร่วมพัฒนา

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)

---- Powered By MiniAiTx ----