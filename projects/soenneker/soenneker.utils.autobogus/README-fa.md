[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### تولیدکننده خودکار .NET

این پروژه یک سازنده و پرکننده خودکار برای تولیدکننده داده جعلی [Bogus](https://github.com/bchavez/Bogus) است. این پروژه جایگزینی برای کتابخانه رهاشده [AutoBogus](https://github.com/nickdodd79/AutoBogus) می‌باشد.

اهداف:
- *سریع* بودن
- پشتیبانی از جدیدترین نوع‌ها در .NET

این پروژه از سریع‌ترین کش بازتابی .NET یعنی [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache) استفاده می‌کند. به‌روزرسانی‌های Bogus به صورت خودکار یکپارچه می‌شوند.

.NET 8+ پشتیبانی می‌شود.

## نصب

```
dotnet add package Soenneker.Utils.AutoBogus
```

## استفاده

- ایجاد یک نمونه از `AutoFaker`:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- فراخوانی `Generate<>()` برای هر نوع دلخواه:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- همچنین می‌توان نوع‌ها را از طریق آرگومان تولید کرد:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- تعیین faker، پیکربندی، قواعد و غیره:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

این روش توصیه‌شده برای کنترل شخصی‌سازی نوع‌ها است:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker در دسترس است
        target.Name = context.Faker.Random.Word();

        // AutoFaker نیز در دسترس است
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

سپس کافی است `AutoFakerOverride` را به نمونه `AutoFaker.Config` اضافه کنید:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

این کلاس از `Bogus.Faker` ارث‌بری کرده و می‌توان قواعد خاص به نمونه `AutoFaker` را تعیین کرد.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## واسط‌ها/انتزاعی‌ها

کتابخانه پایه برای واسط‌ها یا اشیای انتزاعی تولید انجام نمی‌دهد، اما این افزونه‌ها امکان تولید mock آن‌ها را فراهم می‌کنند:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## نکات
- ⚠️ نمونه‌سازی یک `AutoFaker` زمان قابل‌توجهی می‌گیرد به دلیل مقداردهی اولیه `Faker` در Bogus (تقریباً 1 میلی‌ثانیه). توصیه می‌شود در صورت امکان از یک نمونه مشترک استفاده شود.
- `AutoFaker.GenerateStatic<T>()` نیز موجود است، اما بهتر است استفاده نشود (زیرا در هر فراخوانی یک `AutoFaker`/`Faker` جدید می‌سازد).

## یادداشت‌ها
- برخی الگوها که در AutoBogus وجود داشتند، به دلیل پیچیدگی و تأثیر بر عملکرد حذف شده‌اند.
- این پروژه هنوز در حال توسعه است. مشارکت شما استقبال می‌شود.

## بنچمارک‌ها

### Soenneker.Utils.AutoBogus - `AutoFaker`

| متد             | میانگین      | خطا      | انحراف معیار |
|---------------- |-------------:|---------:|-------------:|
| Generate_int     |    79.40 ns  | 0.635 ns |  0.563 ns    |
| Generate_string  |   241.35 ns  | 3.553 ns |  3.324 ns    |
| Generate_complex | 6,782.34 ns  | 43.811 ns| 38.837 ns    |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| متد             | میانگین     | خطا      | انحراف معیار |
|---------------- |------------:|---------:|-------------:|
| Generate_string  |   283.6 ns  | 3.28 ns |  3.07 ns     |
| Generate_complex | 8,504.0 ns  |76.58 ns | 67.89 ns     |

### AutoBogus

| متد             | میانگین     | خطا      | انحراف معیار |
|---------------- |------------:|---------:|-------------:|
| Generate_int     |   1.17 ms   | 0.033 ms| 0.026 ms     |
| Generate_complex |  10.91 ms   | 0.181 ms| 0.236 ms     |

### Bogus

| متد         | میانگین         | خطا         | انحراف معیار    |
|-------------|----------------:|------------:|----------------:|
| Bogus_int   |      19.70 ns   |     0.176 ns|     0.165 ns    |
| Bogus_string|     171.75 ns   |     2.763 ns|     2.585 ns    |
| Bogus_ctor  | 730,669.06 ns   | 8,246.622 ns| 7,310.416 ns    |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---