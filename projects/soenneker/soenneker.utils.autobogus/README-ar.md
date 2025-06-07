[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### مولد .NET التلقائي

هذا المشروع هو منشئ ومُعبئ تلقائي لمولد البيانات المزيفة [Bogus](https://github.com/bchavez/Bogus). وهو بديل لمكتبة [AutoBogus](https://github.com/nickdodd79/AutoBogus) المهجورة.

الأهداف:
- أن يكون *سريعًا*
- دعم أحدث الأنواع في .NET

يستخدم أسرع كاش انعكاس في .NET: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). يتم دمج تحديثات Bogus تلقائيًا.

يدعم .NET 8+.

## التثبيت

```
dotnet add package Soenneker.Utils.AutoBogus
```

## الاستخدام

- أنشئ مثيلًا لـ `AutoFaker`:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- استدعِ `Generate<>()` على أي نوع تريده:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- من الممكن أيضًا توليد الأنواع عبر وسيطة:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- تعيين faker أو الإعدادات أو القواعد، إلخ:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

هذه هي الطريقة الموصى بها للتحكم في تخصيص النوع:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker متاح
        target.Name = context.Faker.Random.Word();

        // AutoFaker متاح أيضًا
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

ثم قم فقط بإضافة `AutoFakerOverride` إلى مثيل `AutoFaker.Config`:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

يرث هذا من `Bogus.Faker`، ويمكن استخدامه لتعيين قواعد محددة لمثيل `AutoFaker`.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## الواجهات/الكائنات المجردة

المكتبة الأساسية لا تولد واجهات أو كائنات مجردة، ولكن هذه الإضافات تتيح لك توليد نسخ وهمية منها:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## نصائح
- ⚠️ إنشاء مثيل لـ `AutoFaker` يستغرق وقتًا غير بسيط بسبب تهيئة Bogus `Faker` (حوالي 1 مللي ثانية). يُنصح باستخدام مثيل واحد فقط إذا أمكن.
- يتوفر أيضًا `AutoFaker.GenerateStatic<T>()`، لكن يُفضل تجنبه (لأنه ينشئ مثيلًا جديدًا من `AutoFaker`/`Faker` في كل مرة).

## ملاحظات
- تم إزالة بعض الأنماط التي كانت موجودة في AutoBogus بسبب التعقيد والأثر على الأداء.
- هذا العمل قيد التطوير. المساهمة مرحب بها.

## اختبارات الأداء

### Soenneker.Utils.AutoBogus - `AutoFaker`

| الطريقة          | المتوسط      | الخطأ      | الانحراف المعياري |
|------------------|------------:|----------:|-----------------:|
| Generate_int     |    79.40 ns |  0.635 ns |       0.563 ns   |
| Generate_string  |   241.35 ns |  3.553 ns |       3.324 ns   |
| Generate_complex | 6,782.34 ns | 43.811 ns |      38.837 ns   |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| الطريقة          | المتوسط    | الخطأ    | الانحراف المعياري |
|------------------|-----------:|---------:|-----------------:|
| Generate_string  |   283.6 ns |  3.28 ns |        3.07 ns   |
| Generate_complex | 8,504.0 ns | 76.58 ns |       67.89 ns   |

### AutoBogus

| الطريقة          | المتوسط   | الخطأ    | الانحراف المعياري |
|------------------|----------:|---------:|-----------------:|
| Generate_int     |   1.17 ms | 0.033 ms |      0.026 ms    |
| Generate_complex |  10.91 ms | 0.181 ms |      0.236 ms    |

### Bogus

| الطريقة       | المتوسط        | الخطأ        | الانحراف المعياري |
|---------------|--------------:|-------------:|-----------------:|
| Bogus_int     |      19.70 ns |     0.176 ns |      0.165 ns    |
| Bogus_string  |     171.75 ns |     2.763 ns |      2.585 ns    |
| Bogus_ctor    | 730,669.06 ns | 8,246.622 ns |  7,310.416 ns    |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---