[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### เครื่องมือสร้างข้อมูลอัตโนมัติสำหรับ .NET 

โปรเจกต์นี้เป็นเครื่องมือสร้างและเติมข้อมูลปลอมโดยอัตโนมัติสำหรับตัวสร้างข้อมูลปลอม [Bogus](https://github.com/bchavez/Bogus) โดยเป็นตัวแทนของไลบรารี [AutoBogus](https://github.com/nickdodd79/AutoBogus) ที่ถูกยกเลิกไปแล้ว

เป้าหมาย:
- ให้ *รวดเร็ว*
- รองรับชนิดข้อมูลล่าสุดใน .NET

ใช้แคช Reflection ที่เร็วที่สุดใน .NET: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache) การอัปเดตของ Bogus จะถูกรวมเข้ามาโดยอัตโนมัติ

รองรับ .NET 8 ขึ้นไป

## การติดตั้ง

```
dotnet add package Soenneker.Utils.AutoBogus
```

## การใช้งาน

- สร้างอินสแตนซ์ `AutoFaker`:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- เรียกใช้ `Generate<>()` กับชนิดข้อมูลที่ต้องการ:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- สามารถสร้างชนิดข้อมูลโดยส่งเป็นอาร์กิวเมนต์ได้เช่นกัน:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- กำหนด faker, การตั้งค่า, กฎ ฯลฯ:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

นี่เป็นวิธีที่แนะนำสำหรับการควบคุมการปรับแต่งชนิดข้อมูล:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // มี Faker ให้ใช้งาน
        target.Name = context.Faker.Random.Word();

        // มี AutoFaker ให้ใช้งานเช่นกัน
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

จากนั้นเพียงแค่เพิ่ม `AutoFakerOverride` ลงในอินสแตนซ์ `AutoFaker.Config`:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

คลาสนี้สืบทอดมาจาก `Bogus.Faker` และสามารถใช้สำหรับกำหนดกฎเฉพาะให้กับอินสแตนซ์ `AutoFaker`

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## อินเทอร์เฟซ/แอ็บสแตรกต์

ไลบรารีหลักจะไม่สร้างอินเทอร์เฟซหรืออ็อบเจ็กต์แอ็บสแตรกต์ แต่สิ่งเหล่านี้จะช่วยให้คุณสามารถสร้าง mock ได้:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## เคล็ดลับ
- ⚠️ การสร้างอินสแตนซ์ `AutoFaker` จะใช้เวลาพอสมควรเนื่องจากการเริ่มต้น `Faker` ของ Bogus (เกือบ 1ms) แนะนำให้ใช้เพียงอินสแตนซ์เดียวหากเป็นไปได้
- มี `AutoFaker.GenerateStatic<T>()` ให้ใช้งาน แต่ควรหลีกเลี่ยง (เนื่องจากจะสร้าง `AutoFaker`/`Faker` ใหม่ทุกครั้งที่เรียกใช้)

## หมายเหตุ
- รูปแบบบางอย่างที่มีอยู่ใน AutoBogus เดิมถูกนำออกไปเนื่องจากความซับซ้อนและผลกระทบด้านประสิทธิภาพ
- โครงการนี้ยังอยู่ในระหว่างการพัฒนา ยินดีรับการร่วมพัฒนา

## การทดสอบประสิทธิภาพ

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| Generate_int     |    79.40 ns |  0.635 ns |  0.563 ns |
| Generate_string  |   241.35 ns |  3.553 ns |  3.324 ns |
| Generate_complex | 6,782.34 ns | 43.811 ns | 38.837 ns |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Method           | Mean       | Error    | StdDev   |
|----------------- |-----------:|---------:|---------:|
| Generate_string  |   283.6 ns |  3.28 ns |  3.07 ns |
| Generate_complex | 8,504.0 ns | 76.58 ns | 67.89 ns |

### AutoBogus

| Method           | Mean      | Error    | StdDev   |
|----------------- |----------:|---------:|---------:|
| Generate_int     |   1.17 ms | 0.033 ms | 0.026 ms |
| Generate_complex |  10.91 ms | 0.181 ms | 0.236 ms |

### Bogus

| Method       | Mean          | Error        | StdDev       |
|------------- |--------------:|-------------:|-------------:|
| Bogus_int    |      19.70 ns |     0.176 ns |     0.165 ns |
| Bogus_string |     171.75 ns |     2.763 ns |     2.585 ns |
| Bogus_ctor   | 730,669.06 ns | 8,246.622 ns | 7,310.416 ns |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---