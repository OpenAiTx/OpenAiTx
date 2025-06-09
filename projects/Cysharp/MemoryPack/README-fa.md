# مموری‌پک (MemoryPack)

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

سریالایزر باینری با عملکرد فوق‌العاده و بدون رمزگذاری برای C# و یونیتی.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> مقایسه با [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json)، [protobuf-net](https://github.com/protobuf-net/protobuf-net)، [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp)، [Orleans.Serialization](https://github.com/dotnet/orleans/). اندازه‌گیری شده با .NET 7 / Ryzen 9 5950X. این سریالایزرها متد `IBufferWriter<byte>` دارند، با استفاده از `ArrayBufferWriter<byte>` سریالایز شده‌اند و برای جلوگیری از اندازه‌گیری کپی بافر، مجدداً استفاده شده‌اند.

برای اشیاء معمولی، مموری‌پک تا ۱۰ برابر سریع‌تر و ۲ تا ۵ برابر سریع‌تر از سایر سریالایزرهای باینری است. برای آرایه‌های ساختاری، مموری‌پک حتی قدرتمندتر است و سرعتی تا ۵۰ تا ۲۰۰ برابر بیشتر از سایر سریالایزرها دارد.

مموری‌پک چهارمین سریالایزر من است، قبلاً سریالایزرهای مشهوری مانند ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~، ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~، [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp) را ساخته‌ام. دلیل سرعت مموری‌پک، فرمت باینری خاص و بهینه‌شده برای C# و پیاده‌سازی دقیق آن بر اساس تجربیات قبلی من است. همچنین این یک طراحی کاملاً جدید است که از .NET 7 و C# 11 و ابزار Incremental Source Generator استفاده می‌کند (پشتیبانی از .NET Standard 2.1 (.NET 5, 6) و همچنین پشتیبانی یونیتی وجود دارد).

سایر سریالایزرها عملیات‌های رمزنویسی زیادی مانند VarInt encoding، تگ، رشته و غیره را انجام می‌دهند. فرمت مموری‌پک از طراحی صفر-رمزگذاری استفاده می‌کند که تا حد امکان حافظه C# را کپی می‌کند. صفر-رمزگذاری مشابه FlatBuffers است اما به نوع خاصی نیاز ندارد؛ هدف سریالایز مموری‌پک، POCO است.

علاوه بر عملکرد، مموری‌پک این ویژگی‌ها را دارد:

* پشتیبانی از APIهای مدرن I/O (`IBufferWriter<byte>`، `ReadOnlySpan<byte>`، `ReadOnlySequence<byte>`)
* تولید کد مبتنی بر Source Generator بومی و سازگار با Native AOT، بدون Dynamic CodeGen (IL.Emit)
* APIهای غیرجنریک بدون ریفلکشن
* پشتیبانی از دسیریالایز به نمونه موجود
* سریالایز چندشکلی (Polymorphism/Union)
* پشتیبانی نسخه‌پذیری محدود (سریع/پیش‌فرض) و کامل
* پشتیبانی از سریالایز مرجع دایره‌ای
* سریالایز استریم مبتنی بر PipeWriter/Reader
* تولید کد تایپ‌اسکریپت و Formatter برای ASP.NET Core
* پشتیبانی یونیتی (2021.3) IL2CPP از طریق .NET Source Generator

نصب
---
این کتابخانه از طریق NuGet توزیع می‌شود. برای بهترین عملکرد، توصیه می‌شود از `.NET 7` استفاده کنید. حداقل نیازمندی، `.NET Standard 2.1` است.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

همچنین ویرایشگر کد باید از Roslyn 4.3.1 پشتیبانی کند، برای مثال Visual Studio 2022 نسخه 17.3، .NET SDK 6.0.401. برای جزئیات بیشتر به [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support) مراجعه کنید.

برای یونیتی، نیازمندی‌ها و روند نصب کاملاً متفاوت است. برای جزئیات به بخش [Unity](#unity) مراجعه کنید.

شروع سریع
---
یک ساختار (struct) یا کلاس (class) برای سریالایز تعریف کنید و آن را با ویژگی `[MemoryPackable]` و کلیدواژه `partial` نشانه‌گذاری کنید.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

کد سریالایز توسط قابلیت Source Generator سی‌شارپ تولید می‌شود که رابط `IMemoryPackable<T>` را پیاده‌سازی می‌کند. در Visual Studio می‌توانید با استفاده از میانبر `Ctrl+K, R` روی نام کلاس و انتخاب `*.MemoryPackFormatter.g.cs` کد تولیدی را بررسی کنید.

برای سریالایز/دسیریالایز نمونه یک شی، متد `MemoryPackSerializer.Serialize<T>/Deserialize<T>` را فراخوانی کنید.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

متد `Serialize` علاوه بر بازگشت آرایه `byte[]` می‌تواند به `IBufferWriter<byte>` یا `Stream` نیز سریالایز کند. متد `Deserialize` از `ReadOnlySpan<byte>`، `ReadOnlySequence<byte>` و `Stream` پشتیبانی می‌کند. همچنین نسخه‌های غیرجنریک نیز وجود دارد.

انواع پشتیبانی‌شده داخلی
---
این انواع به صورت پیش‌فرض قابل سریالایز هستند:

* انواع اولیه دات‌نت (`byte`، `int`، `bool`، `char`، `double` و غیره)
* انواع غیرمدیریت‌شده (هر `enum`، هر `struct` تعریف‌شده توسط کاربر که نوع ارجاعی ندارد)
* `string`، `decimal`، `Half`، `Int128`، `UInt128`، `Guid`، `Rune`، `BigInteger`
* `TimeSpan`،  `DateTime`، `DateTimeOffset`، `TimeOnly`، `DateOnly`، `TimeZoneInfo`
* `Complex`، `Plane`، `Quaternion`، `Matrix3x2`، `Matrix4x4`، `Vector2`، `Vector3`، `Vector4`
* `Uri`، `Version`، `StringBuilder`، `Type`، `BitArray`، `CultureInfo`
* `T[]`، `T[,]`، `T[,,]`، `T[,,,]`، `Memory<>`، `ReadOnlyMemory<>`، `ArraySegment<>`، `ReadOnlySequence<>`
* `Nullable<>`، `Lazy<>`، `KeyValuePair<,>`، `Tuple<,...>`، `ValueTuple<,...>`
* `List<>`، `LinkedList<>`، `Queue<>`، `Stack<>`، `HashSet<>`، `SortedSet<>`، `PriorityQueue<,>`
* `Dictionary<,>`، `SortedList<,>`، `SortedDictionary<,>`،  `ReadOnlyDictionary<,>` 
* `Collection<>`، `ReadOnlyCollection<>`، `ObservableCollection<>`، `ReadOnlyObservableCollection<>`
* `IEnumerable<>`، `ICollection<>`، `IList<>`، `IReadOnlyCollection<>`، `IReadOnlyList<>`، `ISet<>`
* `IDictionary<,>`، `IReadOnlyDictionary<,>`، `ILookup<,>`، `IGrouping<,>`,
* `ConcurrentBag<>`، `ConcurrentQueue<>`، `ConcurrentStack<>`، `ConcurrentDictionary<,>`، `BlockingCollection<>`
* مجموعه‌های تغییرناپذیر (`ImmutableList<>` و غیره) و اینترفیس‌ها (`IImmutableList<>` و غیره)

تعریف `[MemoryPackable]` برای `class` / `struct` / `record` / `record struct`
---
ویژگی `[MemoryPackable]` را می‌توان روی هر `class`، `struct`، `record`، `record struct` و `interface` قرار داد. اگر نوع، `struct` یا `record struct` باشد و حاوی هیچ نوع ارجاعی نباشد ([انواع غیرمدیریت‌شده C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types))، هیچ نشانه‌گذاری اضافی (ignore، include، constructor، callbacks) به کار نمی‌رود و سریالایز/دسیریالایز مستقیماً از حافظه انجام می‌شود.

در غیر این صورت، به طور پیش‌فرض `[MemoryPackable]` خصوصیات یا فیلدهای عمومی نمونه را سریالایز می‌کند. می‌توانید از `[MemoryPackIgnore]` برای حذف عضو از هدف سریالایز و از `[MemoryPackInclude]` برای ارتقای یک عضو خصوصی به هدف سریالایز استفاده کنید.

```csharp
[MemoryPackable]
public partial class Sample
{
    // این اعضا به طور پیش‌فرض سریالایز می‌شوند
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // این اعضا به طور پیش‌فرض سریالایز نمی‌شوند
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // استفاده از [MemoryPackIgnore] برای حذف عضو عمومی از سریالایز
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // استفاده از [MemoryPackInclude] برای ارتقای عضو خصوصی به هدف سریالایز
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

تولیدکننده کد مموری‌پک اطلاعات اعضایی که سریالایز می‌شوند را به بخش `<remarks />` اضافه می‌کند. این اطلاعات را می‌توانید با نگه داشتن نشانگر روی نوع در Intellisense مشاهده کنید.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

تمامی اعضا باید قابل سریالایز با مموری‌پک باشند، در غیر این صورت تولیدکننده کد خطا صادر می‌کند.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

مموری‌پک ۳۵ قانون تشخیص خطا (`MEMPACK001` تا `MEMPACK035`) دارد تا تعریف را راحت‌تر کند.

اگر نوع هدف، سریالایز مموری‌پک را به صورت خارجی تعریف و ثبت کرده‌اید، از `[MemoryPackAllowSerialize]` برای خاموش کردن تشخیص خطا استفاده کنید.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

ترتیب اعضا **مهم** است؛ مموری‌پک نام عضو یا اطلاعات دیگری را سریالایز نمی‌کند، بلکه فیلدها را به ترتیبی که تعریف شده‌اند سریالایز می‌کند. اگر نوع ارث‌بری داشته باشد، ترتیب سریالایز به صورت والد → فرزند انجام می‌شود. ترتیب اعضا برای دسیریالایز نباید تغییر کند. برای تکامل شِما (Schema Evolution) به بخش [نسخه‌پذیر](#version-tolerant) مراجعه کنید.

ترتیب پیش‌فرض به صورت متوالی است اما می‌توانید با `[MemoryPackable(SerializeLayout.Explicit)]` و `[MemoryPackOrder()]` ترتیب صریح را انتخاب کنید.

```csharp
// سریالایز Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### انتخاب سازنده (Constructor Selection)

مموری‌پک از هر دو سازنده پارامتردار و بدون پارامتر پشتیبانی می‌کند. انتخاب سازنده بر اساس این قوانین است (برای کلاس‌ها و ساختارها):

* اگر `[MemoryPackConstructor]` وجود داشته باشد، از آن استفاده می‌شود.
* اگر سازنده صریحی وجود نداشته باشد (شامل خصوصی)، از سازنده بدون پارامتر استفاده می‌شود.
* اگر یک سازنده بدون پارامتر/پارامتردار (شامل خصوصی) وجود داشته باشد، از آن استفاده می‌شود.
* اگر چندین سازنده وجود داشته باشد، باید ویژگی `[MemoryPackConstructor]` را به سازنده مورد نظر اعمال کنید (تولیدکننده به طور خودکار انتخاب نمی‌کند)، در غیر این صورت خطا صادر می‌شود.
* در صورت استفاده از سازنده پارامتردار، نام تمام پارامترها باید با نام اعضای مربوطه (بدون توجه به بزرگی/کوچکی حروف) یکسان باشد.

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // می‌توانید از سازنده پارامتردار استفاده کنید - نام پارامترها باید با نام اعضای مربوطه (بدون حساسیت به حروف) یکسان باشد
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// همچنین از سازنده اولیه record پشتیبانی می‌کند
[MemoryPackable]
public partial record Person2(int Age, string Name);

public partial class Person3
{
    public int Age { get; set; }
    public string Name { get; set; }

    public Person3()
    {
    }
```
```csharp
// اگر چندین سازنده وجود داشته باشد، باید از [MemoryPackConstructor] استفاده شود
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### فراخوانی‌های سریال‌سازی

در هنگام سریال‌سازی/بازسریال‌سازی، MemoryPack می‌تواند رویداد قبل/بعد را با استفاده از ویژگی‌های `[MemoryPackOnSerializing]`، `[MemoryPackOnSerialized]`، `[MemoryPackOnDeserializing]`، `[MemoryPackOnDeserialized]` فراخوانی کند. این ویژگی‌ها می‌توانند روی متدهای استاتیک و نمونه (غیراستاتیک)، و متدهای عمومی و خصوصی اعمال شوند.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // ترتیب فراخوانی متد: استاتیک -> نمونه
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // همچنین متد خصوصی مجاز است
    [MemoryPackOnSerializing]
    void OnSerializing2()
    {
        Console.WriteLine(nameof(OnSerializing2));
    }

    // serializing -> /* serialize */ -> serialized
    [MemoryPackOnSerialized]
    static void OnSerialized1()
    {
        Console.WriteLine(nameof(OnSerialized1));
    }

    [MemoryPackOnSerialized]
    public void OnSerialized2()
    {
        Console.WriteLine(nameof(OnSerialized2));
    }

    [MemoryPackOnDeserializing]
    public static void OnDeserializing1()
    {
        Console.WriteLine(nameof(OnDeserializing1));
    }

    // توجه: متد نمونه با MemoryPackOnDeserializing، اگر نمونه با `ref` ارسال نشود، فراخوانی نمی‌شود
    [MemoryPackOnDeserializing]
    public void OnDeserializing2()
    {
        Console.WriteLine(nameof(OnDeserializing2));
    }

    [MemoryPackOnDeserialized]
    public static void OnDeserialized1()
    {
        Console.WriteLine(nameof(OnDeserialized1));
    }

    [MemoryPackOnDeserialized]
    public void OnDeserialized2()
    {
        Console.WriteLine(nameof(OnDeserialized2));
    }
}
```

فراخوانی‌ها اجازه متد بدون پارامتر و متد `ref reader/writer, ref T value` را می‌دهند. برای مثال، فراخوانی‌های ref می‌توانند هدر سفارشی را قبل از فرایند سریال‌سازی بنویسند/بخوانند.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1، استفاده از where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // تولید GUID در هدر.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // خواندن هدر سفارشی قبل از بازسریال‌سازی
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

اگر مقداری را به `ref value` اختصاص دهید، می‌توانید مقدار استفاده‌شده در سریال‌سازی/بازسریال‌سازی را تغییر دهید. برای مثال، نمونه‌سازی از ServiceProvider.

```csharp
// قبل از استفاده از این فرمت‌کننده، ServiceProvider را تنظیم کنید
// var options = MemoryPackSerializerOptions.Default with { ServiceProvider = provider };
// MemoryPackSerializer.Deserialize(value, options);

[MemoryPackable]
public partial class InstantiateFromServiceProvider
{
    static IServiceProvider serviceProvider = default!;

    public int MyProperty { get; private set; }

    [MemoryPackOnDeserializing]
    static void OnDeserializing(ref MemoryPackReader reader, ref InstantiateFromServiceProvider value)
    {
        if (value != null) return;
        value = reader.Options.ServiceProvider!.GetRequiredService<InstantiateFromServiceProvider>();
    }
}
```

تعریف مجموعه سفارشی
---
به صورت پیش‌فرض، نوعی که با `[MemoryPackObject]` نشانه‌گذاری شده سعی می‌کند اعضای خود را سریال‌سازی کند. با این حال، اگر یک نوع یک مجموعه باشد (`ICollection<>`، `ISet<>`، `IDictionary<,>`)، برای سریال‌سازی صحیح باید از `GenerateType.Collection` استفاده کنید.

```csharp
[MemoryPackable(GenerateType.Collection)]
public partial class MyList<T> : List<T>
{
}

[MemoryPackable(GenerateType.Collection)]
public partial class MyStringDictionary<TValue> : Dictionary<string, TValue>
{

}
```

سازنده استاتیک
---
کلاس MemoryPackable نمی‌تواند سازنده استاتیک تعریف کند زیرا کلاس partial تولیدشده از آن استفاده می‌کند. در عوض، می‌توانید از `static partial void StaticConstructor()` برای انجام همان کار استفاده کنید.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

چندریختی (Union)
---
MemoryPack از سریال‌سازی اشیای واسط (interface) و کلاس‌های انتزاعی برای سریال‌سازی چندریختی پشتیبانی می‌کند. در MemoryPack این قابلیت Union نامیده می‌شود. تنها واسط‌ها و کلاس‌های انتزاعی اجازه دارند با ویژگی `[MemoryPackUnion]` نشانه‌گذاری شوند. تگ‌های یونیک برای یونین الزامی است.

```csharp
// واسط [MemoryPackable] و انواع ارث‌بری با [MemoryPackUnion] نشانه‌گذاری شوند
// Union همچنین از کلاس انتزاعی پشتیبانی می‌کند
[MemoryPackable]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial interface IUnionSample
{
}

[MemoryPackable]
public partial class FooClass : IUnionSample
{
    public int XYZ { get; set; }
}

[MemoryPackable]
public partial class BarClass : IUnionSample
{
    public string? OPQ { get; set; }
}
// ---

IUnionSample data = new FooClass() { XYZ = 999 };

// سریال‌سازی به عنوان نوع واسط.
var bin = MemoryPackSerializer.Serialize(data);

// بازسریال‌سازی به عنوان نوع واسط.
var reData = MemoryPackSerializer.Deserialize<IUnionSample>(bin);

switch (reData)
{
    case FooClass x:
        Console.WriteLine(x.XYZ);
        break;
    case BarClass x:
        Console.WriteLine(x.OPQ);
        break;
    default:
        break;
}
```

`tag` مجاز است مقادیر `0` تا `65535` را داشته باشد و برای مقادیر کمتر از `250` بسیار بهینه است.
```
اگر یک اینترفیس و انواع مشتق آن در اسمبلی‌های مختلف قرار داشته باشند، می‌توانید به جای آن از `MemoryPackUnionFormatterAttribute` استفاده کنید. فرمتترها به گونه‌ای تولید می‌شوند که به صورت خودکار از طریق `ModuleInitializer` در #C 9.0 و بالاتر ثبت می‌شوند.

> توجه داشته باشید که `ModuleInitializer` در یونیتی پشتیبانی نمی‌شود، بنابراین فرمتتر باید به صورت دستی ثبت شود. برای ثبت فرمتتر یونین خود، متد `{نام فرمتتر یونین شما}Initializer.RegisterFormatter()` را به صورت دستی در Startup فراخوانی کنید. برای مثال `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB تعریف خارج از نوع هدف
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

یونین را می‌توان به صورت کد با استفاده از `DynamicUnionFormatter<T>` ساخت.

```csharp
// (ushort, Type)[]
var formatter = new DynamicUnionFormatter<IFooBarBaz>(
    (0, typeof(Foo)),
    (1, typeof(Bar)),
    (2, typeof(Baz))
);

MemoryPackFormatterProvider.Register(formatter);
```

API سریال‌سازی
---
`Serialize` سه اورلود دارد.

```csharp
// API غیرجنریک نیز موجود است، در این نسخه آرگومان اول Type و مقدار object? است
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

برای کارایی بیشتر، API پیشنهادی از `BufferWriter` استفاده می‌کند. این کار مستقیماً در بافر سریال‌سازی می‌کند. این قابلیت را می‌توان به `PipeWriter` در `System.IO.Pipelines`، `BodyWriter` در ASP .NET Core و غیره اعمال کرد.

اگر به `byte[]` نیاز باشد (مثلاً `RedisValue` در [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis))، API بازگشتی `byte[]` ساده و تقریباً به همان سرعت است.

توجه داشته باشید که `SerializeAsync` برای `Stream` فقط برای Flush به صورت ناهمگام است؛ همه چیز را یک‌باره در بافر داخلی MemoryPack سریال‌سازی می‌کند و سپس با استفاده از `WriteAsync` می‌نویسد. بنابراین، اورلود `BufferWriter` که بافر و flush را جدا و کنترل می‌کند، بهتر است.

اگر می‌خواهید نوشتن کامل استریم را انجام دهید، به بخش [سریال‌سازی جریانی](#streaming-serialization) مراجعه کنید.

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` تعیین می‌کند که رشته‌ها به صورت UTF16 یا UTF8 سریال‌سازی شوند. این موضوع را می‌توان با ارسال `MemoryPackSerializerOptions.Utf8` برای کدگذاری UTF8، `MemoryPackSerializerOptions.Utf16` برای کدگذاری UTF16 یا `MemoryPackSerializerOptions.Default` که به طور پیش‌فرض UTF8 است، پیکربندی کرد. ارسال null یا استفاده از پارامتر پیش‌فرض منجر به کدگذاری UTF8 می‌شود.

از آنجا که نمایش داخلی رشته در #C به صورت UTF16 است، UTF16 عملکرد بهتری دارد. با این حال، حجم داده معمولاً بزرگ‌تر است؛ در UTF8، یک رشته ASCII یک بایت است، در حالی که در UTF16 دو بایت است. به دلیل تفاوت زیاد حجم داده، به طور پیش‌فرض UTF8 انتخاب شده است.

اگر داده غیر ASCII باشد (مانند ژاپنی که می‌تواند بیش از 3 بایت باشد و UTF8 بزرگ‌تر است) یا اگر باید جداگانه فشرده‌سازی شود، UTF16 ممکن است نتیجه بهتری بدهد.

در حالی که UTF8 یا UTF16 را می‌توان هنگام سریال‌سازی انتخاب کرد، لازم نیست هنگام دسیریال‌سازی آن را مشخص کنید. به طور خودکار تشخیص داده می‌شود و به صورت معمول دسیریال‌سازی می‌شود.

علاوه بر این، می‌توانید `IServiceProvider? ServiceProvider { get; init; }` را از گزینه‌ها بگیرید/تنظیم کنید. این قابلیت برای گرفتن شی DI (مانند `ILogger<T>`) از فرآیند سریال‌سازی مفید است (`MemoryPackReader/MemoryPackWriter` دارای خاصیت .Options هستند).

API دسیریال‌سازی
---
`Deserialize` دارای اورلودهایی با `ReadOnlySpan<byte>` و `ReadOnlySequence<byte>`، `Stream` و پشتیبانی از `ref` است.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

اورلود `ref` یک نمونه موجود را بازنویسی می‌کند، برای جزئیات به بخش [بازنویسی](#overwrite) مراجعه کنید.

`DeserializeAsync(Stream)` یک عملیات خواندن کامل جریانی نیست؛ ابتدا تا انتهای استریم در بافر داخلی MemoryPack می‌خواند، سپس دسیریال‌سازی می‌کند.

اگر می‌خواهید عملیات خواندن کامل جریانی انجام دهید، به بخش [سریال‌سازی جریانی](#streaming-serialization) مراجعه کنید.

بازنویسی
---
برای کاهش تخصیص حافظه، MemoryPack امکان دسیریال‌سازی روی یک نمونه موجود و بازنویسی آن را فراهم می‌کند. این قابلیت را می‌توان با اورلود `Deserialize(ref T? value)` استفاده کرد.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// بازنویسی داده روی نمونه موجود.
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack تا جایی که ممکن باشد تلاش می‌کند بازنویسی انجام دهد، اما اگر شرایط زیر برقرار نباشد، یک نمونه جدید ایجاد می‌کند (مانند دسیریال‌سازی معمولی).

* مقدار ref (شامل اعضا در گراف شی) null باشد، نمونه جدید ایجاد می‌شود
* فقط سازنده بدون پارامتر مجاز است، اگر سازنده پارامتری باشد، نمونه جدید ایجاد می‌شود
* اگر مقدار از نوع `T[]` باشد، فقط در صورتی که طول یکسان باشد بازاستفاده می‌شود، در غیر این صورت نمونه جدید ایجاد می‌شود
* اگر مقدار مجموعه‌ای باشد که متد `.Clear()` دارد (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) متد Clear() فراخوانی و بازاستفاده می‌شود، در غیر این صورت نمونه جدید ایجاد می‌شود

مقاوم در برابر نسخه
---
در حالت پیش‌فرض (`GenerateType.Object`)، MemoryPack از تکامل محدود طرحواره پشتیبانی می‌کند.

* ساختارهای غیرمدیریت‌شده دیگر قابل تغییر نیستند
* اعضا می‌توانند اضافه شوند اما حذف نمی‌شوند
* می‌توان نام عضو را تغییر داد
* نمی‌توان ترتیب اعضا را تغییر داد
* نمی‌توان نوع عضو را تغییر داد

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// اضافه کردن مجاز است.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// حذف کردن مجاز نیست.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// تغییر ترتیب مجاز نیست.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

در کاربردها، ذخیره داده قدیمی (در فایل، ردیس و غیره) و خواندن با طرحواره جدید همیشه مجاز است. در سناریوی RPC، طرحواره هم در سمت کلاینت و هم سرور وجود دارد، کلاینت باید قبل از سرور به‌روزرسانی شود. کلاینت به‌روزرسانی‌شده مشکلی برای اتصال به سرور قدیمی ندارد اما کلاینت قدیمی نمی‌تواند به سرور جدید متصل شود.

به طور پیش‌فرض، وقتی داده قدیمی با طرحواره جدید خوانده می‌شود، هر عضوی که در داده وجود ندارد با مقدار `default` مقداردهی اولیه می‌شود.
اگر می‌خواهید این رفتار را تغییر دهید و از مقادیر اولیه فیلد/خاصیت‌ها استفاده کنید، می‌توانید از `[SuppressDefaultInitialization]` استفاده کنید.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < اگر داده قدیمی موجود نباشد، مقدار `111` قرار می‌گیرد.
    
    public int Prop3 { get; set; } = 222; // < اگر داده قدیمی موجود نباشد، مقدار `default` قرار می‌گیرد.
}
```

 `[SuppressDefaultInitialization]` محدودیت‌های زیر را دارد:
- نمی‌توان با readonly، init-only و required modifier استفاده کرد.

بخش بعدی [اطلاعات سریال‌سازی](#serialization-info) نشان می‌دهد که چگونه با CI برای جلوگیری از حوادث، تغییرات طرحواره را بررسی کنید.

هنگام استفاده از `GenerateType.VersionTolerant`، پشتیبانی کامل از تحمل نسخه وجود دارد.

* ساختار غیرمدیریت‌شده دیگر قابل تغییر نیست
* همه اعضا باید صراحتاً با `[MemoryPackOrder]` نشانه‌گذاری شوند (مگر این که `SerializeLayout.Sequential` استفاده شود)
* اعضا می‌توانند اضافه یا حذف شوند اما ترتیب قبلی را نمی‌توان دوباره استفاده کرد (می‌توان از ترتیب جاافتاده استفاده کرد)
* می‌توان نام عضو را تغییر داد
* نمی‌توان ترتیب عضو را تغییر داد
* نمی‌توان نوع عضو را تغییر داد

```csharp
// امکان سریال/دسیریال هر دو جهت 
// VersionTolerantObject1 -> VersionTolerantObject2 و 
// VersionTolerantObject2 -> VersionTolerantObject1 وجود دارد

[MemoryPackable(GenerateType.VersionTolerant)]
public partial class VersionTolerantObject1
{
    [MemoryPackOrder(0)]
    public int MyProperty0 { get; set; } = default;

    [MemoryPackOrder(1)]
    public long MyProperty1 { get; set; } = default;

    [MemoryPackOrder(2)]
    public short MyProperty2 { get; set; } = default;
}

[MemoryPackable(GenerateType.VersionTolerant)]
public partial class VersionTolerantObject2
{
```csharp
[MemoryPackOrder(0)]
public int MyProperty0 { get; set; } = default;

// حذف شده
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// اضافه شده
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// اگر به طور صریح SerializeLayout.Sequential تنظیم شود، اجازه می‌دهد ترتیب به صورت خودکار تنظیم شود.
// اما امکان حذف هیچ عضوی برای نسخه‌پذیری وجود ندارد.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` در زمان سریال‌سازی کندتر از `GenerateType.Object` است. همچنین اندازه‌ی payload کمی بزرگ‌تر خواهد بود.

اطلاعات سریال‌سازی
----
می‌توانید با استفاده از IntelliSense در نوع، اعضایی که سریال‌سازی می‌شوند را بررسی کنید. گزینه‌ای وجود دارد که این اطلاعات را در زمان کامپایل در یک فایل بنویسید. متغیر `MemoryPackGenerator_SerializationInfoOutputDirectory` را به صورت زیر تنظیم کنید.

```xml
<!-- خروجی اطلاعات سریال‌سازی memorypack به دایرکتوری -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

اطلاعات زیر در فایل نوشته می‌شود.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

اگر نوع unmanaged باشد، کلمه `unmanaged` قبل از نام نوع نمایش داده می‌شود.

```txt
unmanaged FooStruct
---
int x
int y
```

با بررسی تفاوت‌های این فایل، می‌توان از ایجاد تغییرات خطرناک در طرحواره جلوگیری کرد. به عنوان مثال، می‌توانید از CI برای شناسایی قوانین زیر استفاده کنید:

* تغییر نوع unmanaged
* تغییر ترتیب اعضا
* حذف عضو

ارجاع چرخشی (Circular Reference)
---
MemoryPack از ارجاع چرخشی نیز پشتیبانی می‌کند. این قابلیت امکان سریال‌سازی اشیای درختی به همان صورت را فراهم می‌کند.

```csharp
// برای فعال‌سازی ارجاع چرخشی، از GenerateType.CircularReference استفاده کنید
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

برای مثال، [کد System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) به صورت زیر خواهد بود.

```csharp
// https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references?pivots=dotnet-7-0
Employee tyler = new()
{
    Name = "Tyler Stein"
};

Employee adrian = new()
{
    Name = "Adrian King"
};

tyler.DirectReports = new List<Employee> { adrian };
adrian.Manager = tyler;

var bin = MemoryPackSerializer.Serialize(tyler);
Employee? tylerDeserialized = MemoryPackSerializer.Deserialize<Employee>(bin);

Console.WriteLine(tylerDeserialized?.DirectReports?[0].Manager == tylerDeserialized); // true

[MemoryPackable(GenerateType.CircularReference)]
public partial class Employee
{
    [MemoryPackOrder(0)]
    public string? Name { get; set; }
    [MemoryPackOrder(1)]
    public Employee? Manager { get; set; }
    [MemoryPackOrder(2)]
    public List<Employee>? DirectReports { get; set; }
}
```

`GenerateType.CircularReference` دارای ویژگی‌هایی مشابه نسخه‌پذیر است. با این حال، به عنوان یک محدودیت اضافی، فقط سازنده‌های بدون پارامتر مجاز هستند. همچنین، ردیابی ارجاعات شی فقط برای اشیایی که با `GenerateType.CircularReference` علامت‌گذاری شده‌اند انجام می‌شود. اگر می‌خواهید شیء دیگری را ردیابی کنید، باید آن را wrap کنید.

فرمت‌کننده سفارشی (CustomFormatter)
---
اگر `MemoryPackCustomFormatterAttribute<T>` یا `MemoryPackCustomFormatterAttribute<TFormatter, T>` (عملکرد بهتر، اما پیچیده‌تر) را پیاده‌سازی کنید، می‌توانید برای عضوهای MemoryPackObject از فرمت‌کننده سفارشی استفاده کنید.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack فرمت‌کننده‌های زیر را ارائه می‌دهد: `Utf8StringFormatterAttribute`، `Utf16StringFormatterAttribute`، `InternStringFormatterAttribute`، `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`، `BitPackFormatterAttribute`، `BrotliFormatter`، `BrotliStringFormatter`، `BrotliFormatter<T>`، `MemoryPoolFormatter<T>`، `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // این عضو به صورت رشته UTF16 سریال‌سازی می‌شود، از نظر عملکرد بهتر از UTF8 است اما در حالت ASCII، اندازه بزرگ‌تر است (اما در حالت غیر ASCII، گاهی اوقات کوچک‌تر است).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // در زمان deserialize، Dictionary با StringComparer.OrdinalIgnoreCase مقداردهی اولیه می‌شود.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // در زمان deserialize، تمام رشته‌ها intern می‌شوند (نگاه کنید به: String.Intern). اگر مقادیر مشابه به طور مکرر بیایند، حافظه صرفه‌جویی می‌شود.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

برای پیکربندی equality comparer مجموعه‌ها/دیکشنری‌ها، تمام فرمت‌کننده‌های داخلی دارای overload سازنده comparer هستند. می‌توانید فرمت‌کننده مقایسه برابری سفارشی را به راحتی ایجاد کنید.

```csharp
public sealed class OrdinalIgnoreCaseStringDictionaryFormatter<TValue> : MemoryPackCustomFormatterAttribute<Dictionary<string, TValue?>>
{
    static readonly DictionaryFormatter<string, TValue?> formatter = new DictionaryFormatter<string, TValue?>(StringComparer.OrdinalIgnoreCase);

    public override IMemoryPackFormatter<Dictionary<string, TValue?>> GetFormatter()
    {
        return formatter;
    }
}
```

`BitPackFormatter` فقط برای نوع‌های `bool[]` فشرده‌سازی انجام می‌دهد. به طور معمول `bool[]` به صورت 1 بایت برای هر مقدار boolean سریال‌سازی می‌شود، اما `BitPackFormatter` آرایه `bool[]` را مانند یک `BitArray` سریال‌سازی می‌کند و هر مقدار را به صورت 1 بیت ذخیره می‌کند. با استفاده از `BitPackFormatter`، 8 مقدار بولی فقط 1 بایت مصرف می‌کند، در حالی که معمولاً 8 بایت مصرف می‌کند و باعث کاهش 8 برابری اندازه می‌شود.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` برای `byte[]` است، به عنوان مثال می‌توانید payload بزرگ را با Brotli فشرده‌سازی کنید.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` برای `string` است، رشته فشرده‌شده (UTF16) را با Brotli سریال‌سازی می‌کند.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```
`BrotliFormatter<T>` برای هر نوعی استفاده می‌شود که داده‌های سریال‌شده آن توسط Brotli فشرده شده‌اند. اگر نوع داده شما `byte[]` یا `string` باشد، برای کارایی بهتر باید از `BrotliFormatter` یا `BrotliStringFormatter` استفاده کنید.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

واگذاری آرایه در زمان Deserialize
---
برای deserialize کردن آرایه‌های بزرگ (هر نوع `T`)، MemoryPack چندین روش کارآمد مبتنی بر pool ارائه می‌دهد. موثرترین روش استفاده از تابع [#Overwrite](#overwrite) است. به طور خاص، `List<T>` همیشه مجدداً استفاده می‌شود.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> مجدداً استفاده می‌شود، در زمان deserialize تخصیص جدیدی صورت نمی‌گیرد.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// برای عملیات کارآمدتر، می‌توانید با CollectionsMarshal یک Span<T> بگیرید
var span = CollectionsMarshal.AsSpan(value.Payload);
```

یک روش راحت این است که در زمان deserialize کردن به یک ArrayPool، داده‌ها را deserialize کنید. MemoryPack دو formatter با نام‌های `MemoryPoolFormatter<T>` و `ReadOnlyMemoryPoolFormatter<T>` ارائه می‌دهد.

```csharp
[MemoryPackable]
public partial class PoolModelSample : IDisposable
{
    public int Id { get; }

    [MemoryPoolFormatter<byte>]
    public Memory<byte> Payload { get; private set; }

    public PoolModelSample(int id, Memory<byte> payload)
    {
        Id = id;
        Payload = payload;
    }

    // باید کد برگشت را خودتان بنویسید، اینجا یک نمونه آورده شده است.

    bool usePool;

    [MemoryPackOnDeserialized]
    void OnDeserialized()
    {
        usePool = true;
    }

    public void Dispose()
    {
        if (!usePool) return;

        Return(Payload); Payload = default;
    }

    static void Return<T>(Memory<T> memory) => Return((ReadOnlyMemory<T>)memory);

    static void Return<T>(ReadOnlyMemory<T> memory)
    {
        if (MemoryMarshal.TryGetArray(memory, out var segment) && segment.Array is { Length: > 0 })
        {
            ArrayPool<T>.Shared.Return(segment.Array, clearArray: RuntimeHelpers.IsReferenceOrContainsReferences<T>());
        }
    }
}

// ---

using(var value = MemoryPackSerializer.Deserialize<PoolModelSample>(bin))
{
    // هر کاری لازم است انجام دهید...
}   // بازگشت به ArrayPool
```

کارایی
---
به پست وبلاگ من مراجعه کنید: [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

اندازه Payload و فشرده‌سازی
---
اندازه payload به مقدار هدف بستگی دارد؛ بر خلاف JSON، کلید وجود ندارد و فرمت باینری است، بنابراین اندازه payload معمولاً کوچکتر از JSON است.

در فرمت‌هایی مانند MessagePack و Protobuf که varint دارند، اگر تعداد زیادی int داشته باشید، اندازه MemoryPack معمولاً بزرگتر خواهد بود (در MemoryPack، int ها همیشه 4 بایت هستند به خاطر encoding با اندازه ثابت، در حالی که در MessagePack بین 1 تا 5 بایت هستند).

float و double در MemoryPack به ترتیب 4 و 8 بایت هستند، اما در MessagePack به ترتیب 5 و 9 بایت. بنابراین، MemoryPack برای مثال، برای آرایه‌های Vector3 (float, float, float) کوچکتر خواهد بود.

رشته (String) به طور پیش‌فرض UTF8 است که مشابه سایر serializerهاست، اما اگر گزینه UTF16 انتخاب شود، ماهیت آن متفاوت خواهد بود.

در هر صورت، اگر اندازه payload بزرگ است، فشرده‌سازی باید در نظر گرفته شود. LZ4، ZStandard و Brotli توصیه می‌شوند.

### فشرده‌سازی

MemoryPack یک ابزار کمکی کارآمد برای فشرده‌سازی [Brotli](https://github.com/google/brotli) از طریق [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) و [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder) ارائه می‌دهد. `BrotliCompressor` و `BrotliDecompressor` در MemoryPack، فشرده‌سازی/بازفشرده‌سازی بهینه‌شده برای رفتار داخلی MemoryPack را فراهم می‌کنند.

```csharp
using MemoryPack.Compression;

// فشرده‌سازی (نیاز به using دارد)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// دریافت آرایه بایت فشرده‌شده
var compressedBytes = compressor.ToArray();

// یا نوشتن در IBufferWriter<byte> دیگر (مثلاً PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// بازفشرده‌سازی (نیاز به using دارد)
using var decompressor = new BrotliDecompressor();

// دریافت ReadOnlySequence<byte> بازفشرده‌شده از ReadOnlySpan<byte> یا ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

هر دو `BrotliCompressor` و `BrotliDecompressor` از نوع struct هستند و حافظه‌ای روی heap تخصیص نمی‌دهند. هر دو داده‌های فشرده یا بازفشرده شده را در یک memory pool داخلی برای Serialize/Deserialize نگه می‌دارند. بنابراین، آزادسازی memory pool ضروری است، فراموش نکنید که از `using` استفاده کنید.

سطح فشرده‌سازی بسیار مهم است. مقدار پیش‌فرض quality-1 (CompressionLevel.Fastest) است که با پیش‌فرض .NET (CompressionLevel.Optimal، quality-4) متفاوت است.

Fastest (quality-1) تقریباً به سرعت [LZ4](https://github.com/lz4/lz4) می‌رسد، اما quality-4 بسیار کندتر است. این موضوع در سناریوی استفاده از serializer حیاتی تشخیص داده شد. هنگام استفاده از `BrotliStream` استاندارد احتیاط کنید (quality-4 به صورت پیش‌فرض فعال است). در هر صورت، سرعت و اندازه‌های فشرده‌سازی/بازفشرده‌سازی برای داده‌های مختلف نتایج بسیار متفاوتی خواهد داشت. لطفاً داده‌هایی که قرار است توسط برنامه شما پردازش شوند را آماده کرده و خودتان تست کنید.

توجه داشته باشید که بین حالت بدون فشرده‌سازی MemoryPack و فشرده‌سازی Brotli، چندین برابر کاهش سرعت وجود دارد.

Brotli همچنین در formatter سفارشی پشتیبانی می‌شود. `BrotliFormatter` می‌تواند فقط یک عضو خاص را فشرده کند.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

سریال‌سازی انواع خارجی
---
اگر می‌خواهید انواع خارجی را سریال‌سازی کنید، می‌توانید یک formatter سفارشی ساخته و آن را به provider ثبت کنید. برای جزئیات بیشتر به [Formatter/Provider API](#formatterprovider-api) مراجعه کنید. با این حال، ساخت یک formatter سفارشی دشوار است. بنابراین، پیشنهاد می‌کنیم یک نوع wrapper بسازید. برای مثال، اگر می‌خواهید یک نوع خارجی به نام `AnimationCurve` را سریال‌سازی کنید.

```csharp
// Keyframe: (float time, float inTangent, float outTangent, int tangentMode, int weightedMode, float inWeight, float outWeight)
[MemoryPackable]
public readonly partial struct SerializableAnimationCurve
{
    [MemoryPackIgnore]
    public readonly AnimationCurve AnimationCurve;

    [MemoryPackInclude]
    WrapMode preWrapMode => AnimationCurve.preWrapMode;
    [MemoryPackInclude]
    WrapMode postWrapMode => AnimationCurve.postWrapMode;
    [MemoryPackInclude]
    Keyframe[] keys => AnimationCurve.keys;

    [MemoryPackConstructor]
    SerializableAnimationCurve(WrapMode preWrapMode, WrapMode postWrapMode, Keyframe[] keys)
    {
        var curve = new AnimationCurve(keys);
        curve.preWrapMode = preWrapMode;
        curve.postWrapMode = postWrapMode;
        this.AnimationCurve = curve;
    }

    public SerializableAnimationCurve(AnimationCurve animationCurve)
    {
        this.AnimationCurve = animationCurve;
    }
}
```

نوعی که قرار است wrap شود public است اما از سریال‌سازی مستثنی شده (`MemoryPackIgnore`). Propertyهایی که می‌خواهید سریال‌سازی شوند private هستند اما شامل شده‌اند (`MemoryPackInclude`). همچنین باید دو نوع سازنده آماده شود. سازنده‌ای که توسط serializer استفاده می‌شود باید private باشد.

در این حالت، باید هر بار wrap انجام شود که راحت نیست. همچنین wrapper از نوع struct نمی‌تواند null را نمایش دهد. پس بیایید یک formatter سفارشی بسازیم.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity از scoped و TBufferWriter پشتیبانی نمی‌کند، پس امضای متد را به `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)` تغییر دهید.
    public override void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, scoped ref AnimationCurve? value)
    {
        if (value == null)
```csharp
{
    writer.WriteNullObjectHeader();
    return;
}

writer.WritePackable(new SerializableAnimationCurve(value));
}

public override void Deserialize(ref MemoryPackReader reader, scoped ref AnimationCurve? value)
{
    if (reader.PeekIsNull())
    {
        reader.Advance(1); // skip null block
        value = null;
        return;
    }
    
    var wrapped = reader.ReadPackable<SerializableAnimationCurve>();
    value = wrapped.AnimationCurve;
}
```

در نهایت، فرمت‌تر را در زمان راه‌اندازی ثبت کنید.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> توجه: AnimationCurve یونیتی به طور پیش‌فرض قابل سریال‌سازی است، بنابراین نیازی به این فرمت‌تر سفارشی برای AnimationCurve نیست.

پکیج‌ها
---
MemoryPack دارای این پکیج‌ها است.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` کتابخانه اصلی است که پشتیبانی کامل از سریال‌سازی و دی‌سریال‌سازی با کارایی بالا برای اشیاء باینری را فراهم می‌کند. این پکیج به `MemoryPack.Core` برای کتابخانه‌های پایه و به `MemoryPack.Generator` برای تولید کد وابسته است. `MemoryPack.Streaming` افزونه‌هایی برای [سریال‌سازی جریانی](#streaming-serialization) اضافه می‌کند. `MemoryPack.AspNetCoreMvcFormatter` فرمت‌تر ورودی/خروجی برای ASP.NET Core اضافه می‌کند. `MemoryPack.UnityShims` انواع شیم یونیتی و فرمت‌ترها را جهت اشتراک نوع بین .NET و یونیتی اضافه می‌کند.

فرمت‌تر TypeScript و ASP.NET Core
---
MemoryPack از تولید کد TypeScript پشتیبانی می‌کند. این ابزار کد کلاس و سریال‌سازی را از C# تولید می‌کند، به عبارت دیگر، شما می‌توانید بدون استفاده از OpenAPI، پروتو و غیره، نوع‌ها را با مرورگر به اشتراک بگذارید.

تولید کد با Source Generator یکپارچه شده است، گزینه‌های زیر (`MemoryPackGenerator_TypeScriptOutputDirectory`) دایرکتوری خروجی کد TypeScript را تنظیم می‌کند. کد زمان اجرا همزمان خروجی می‌شود، بنابراین به هیچ وابستگی اضافی نیاز نیست.

```xml
<!-- خروجی کد TypeScript memorypack به دایرکتوری -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

نوع MemoryPackable در C# باید با `[GenerateTypeScript]` نشانه‌گذاری شود.

```csharp
[MemoryPackable]
[GenerateTypeScript]
public partial class Person
{
    public required Guid Id { get; init; }
    public required int Age { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required DateTime DateOfBirth { get; init; }
    public required Gender Gender { get; init; }
    public required string[] Emails { get; init; }
}

public enum Gender
{
    Male, Female, Other
}
```

کد زمان اجرا و نوع TypeScript در دایرکتوری هدف تولید خواهند شد.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

کد تولید شده به صورت زیر است، با فیلدهای ساده و متدهای استاتیک برای serialize/serializeArray و deserialize/deserializeArray.

```typescript
import { MemoryPackWriter } from "./MemoryPackWriter.js";
import { MemoryPackReader } from "./MemoryPackReader.js";
import { Gender } from "./Gender.js"; 

export class Person {
    id: string;
    age: number;
    firstName: string | null;
    lastName: string | null;
    dateOfBirth: Date;
    gender: Gender;
    emails: (string | null)[] | null;

    constructor() {
        // snip...
    }

    static serialize(value: Person | null): Uint8Array {
        // snip...
    }

    static serializeCore(writer: MemoryPackWriter, value: Person | null): void {
        // snip...
    }

    static serializeArray(value: (Person | null)[] | null): Uint8Array {
        // snip...
    }

    static serializeArrayCore(writer: MemoryPackWriter, value: (Person | null)[] | null): void {
        // snip...
    }
    static deserialize(buffer: ArrayBuffer): Person | null {
        // snip...
    }

    static deserializeCore(reader: MemoryPackReader): Person | null {
        // snip...
    }

    static deserializeArray(buffer: ArrayBuffer): (Person | null)[] | null {
        // snip...
    }

    static deserializeArrayCore(reader: MemoryPackReader): (Person | null)[] | null {
        // snip...
    }
}
```

شما می‌توانید از این نوع به صورت زیر استفاده کنید.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// سریال‌سازی به Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// دی‌سریال‌سازی از ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

پکیج `MemoryPack.AspNetCoreMvcFormatter` فرمت‌تر ورودی و خروجی `MemoryPack` را برای ASP.NET Core MVC اضافه می‌کند. شما می‌توانید `MemoryPackInputFormatter` و `MemoryPackOutputFormatter` را با کد زیر به ASP.NET Core MVC اضافه کنید.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // اگر checkContentType: true باشد، می‌توان چندین فرمت خروجی (JSON/MemoryPack و غیره) داشت. مقدار پیش‌فرض false است.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

اگر از HttpClient فراخوانی می‌کنید، می‌توانید `application/x-memorypack` را به هدر content تنظیم کنید.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### نگاشت نوع TypeScript

تعدادی محدودیت برای نوع‌هایی که می‌توان تولید کرد وجود دارد. در میان نوع‌های پایه، `char` و `decimal` پشتیبانی نمی‌شوند. همچنین نوع OpenGenerics قابل استفاده نیست.

|  C#  |  TypeScript  | توضیحات |
| ---- | ---- | ---- |
| `bool` |  `boolean`  |
| `byte` |  `number`  |
| `sbyte` |  `number`  |
| `int` |  `number` |
| `uint` |  `number` |
| `short` |  `number` |
| `ushort` |  `number` |
| `long` |  `bigint` |
| `ulong` |  `bigint` |
| `float` |  `number` |
| `double` |  `number` |
| `string` |  `string \| null`  | 
| `Guid` |  `string`  | در TypeScript، به صورت رشته نمایش داده می‌شود اما به صورت باینری 16 بایتی سریالایز/دیسریالایز می‌شود
| `DateTime` | `Date` | DateTimeKind نادیده گرفته می‌شود
| `enum` | `const enum` | نوع پایه `long` و `ulong` پشتیبانی نمی‌شود
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | از تمام انواع پیاده‌سازی شده‌ی `ICollection<T>` مانند `List<T>` پشتیبانی می‌کند
| `: ISet<T>` | `Set<T> \| null` | از تمام انواع پیاده‌سازی شده‌ی `ISet<T>` مانند `HashSet<T>` پشتیبانی می‌کند
| `: IDictionary<K,V>` | `Map<K, V> \| null` | از تمام انواع پیاده‌سازی شده‌ی `IDictionary<K,V>` مانند `Dictionary<K,V>` پشتیبانی می‌کند.
| `[MemoryPackable]` | `class` | فقط از کلاس پشتیبانی می‌کند
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` فقط می‌تواند روی کلاس‌ها اعمال شود و در حال حاضر برای struct پشتیبانی نمی‌شود.

### پیکربندی پسوند فایل import و نوع نامگذاری اعضا

به طور پیش‌فرض، MemoryPack پسوند فایل را به صورت `.js` تولید می‌کند مانند `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. اگر می‌خواهید پسوند دیگری یا خالی استفاده کنید، از `MemoryPackGenerator_TypeScriptImportExtension` برای پیکربندی آن استفاده نمایید.
همچنین نام عضو به صورت خودکار به camelCase تبدیل می‌شود. اگر می‌خواهید نام اصلی را حفظ کنید، مقدار `MemoryPackGenerator_TypeScriptConvertPropertyName` را به `false` تنظیم کنید.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- مقدار خالی مجاز است -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- مقدار پیش‌فرض true است -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- مقدار پیش‌فرض false است -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` اجازه می‌دهد تا نشانه‌گذاری nullable در C# در کد TypeScript منعکس شود. مقدار پیش‌فرض false است و همه چیز nullable خواهد بود.

سریال‌سازی استریمینگ
---
`MemoryPack.Streaming` کلاس `MemoryPackStreamingSerializer` را ارائه می‌دهد که پشتیبانی اضافی برای سریال‌سازی و دی‌سریال‌سازی مجموعه‌ها با استفاده از stream را فراهم می‌کند.

```csharp
public static class MemoryPackStreamingSerializer
{
    public static async ValueTask SerializeAsync<T>(PipeWriter pipeWriter, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async ValueTask SerializeAsync<T>(Stream stream, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async IAsyncEnumerable<T?> DeserializeAsync<T>(PipeReader pipeReader, int bufferAtLeast = 4096, int readMinimumSize = 8192, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    public static IAsyncEnumerable<T?> DeserializeAsync<T>(Stream stream, int bufferAtLeast = 4096, int readMinimumSize = 8192, CancellationToken cancellationToken = default)
}
```

رابط Formatter/Provider
---
اگر می‌خواهید formatter را به صورت دستی پیاده‌سازی کنید، از `MemoryPackFormatter<T>` ارث‌بری کرده و متدهای `Serialize` و `Deserialize` را بازنویسی نمایید.

```csharp
public class SkeltonFormatter : MemoryPackFormatter<Skelton>
{
    public override void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, scoped ref Skelton? value)
    {
        if (value == null)
        {
            writer.WriteNullObjectHeader();
            return;
        }

        // استفاده از متدهای writer.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // استفاده از متدهای reader.
    }
}
```
Formatter ایجاد شده با `MemoryPackFormatterProvider` ثبت می‌شود.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

توجه: `unmanged struct` (بدون نوع مرجع) نمی‌تواند از custom formatter استفاده کند و همواره به صورت ساختار native memory سریالایز می‌شود.

MemoryPackWriter/ReaderOptionalState
---
مقداردهی اولیه به `MemoryPackWriter`/`MemoryPackReader` نیاز به OptionalState دارد. این یک wrapper از `MemoryPackSerializerOptions` است که می‌تواند از `MemoryPackWriterOptionalStatePool` ساخته شود.

```csharp
// هنگام dispose، OptionalState به pool بازگردانده می‌شود.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// برای Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

وابستگی به چارچوب هدف
---
MemoryPack از `netstandard2.1` و `net7.0` پشتیبانی می‌کند اما این دو با یکدیگر سازگار نیستند. به عنوان مثال، اگر انواع MemoryPackable تحت پروژه `netstandard2.1` باشند و از آن در پروژه `net7.0` استفاده شود، خطای زمان اجرا به صورت زیر رخ می‌دهد

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

از آن‌جا که net7.0 از اعضای static abstract (`Virtual static method`) استفاده می‌کند که توسط netstandard2.1 پشتیبانی نمی‌شود، این رفتار یک ویژگی مشخص شده است.

پروژه .NET 7 نباید از dll مربوط به netstandard 2.1 استفاده کند. به عبارت دیگر، اگر برنامه یک پروژه .NET 7 است، همه وابستگی‌هایی که از MemoryPack استفاده می‌کنند باید از .NET 7 پشتیبانی کنند. بنابراین اگر یک توسعه‌دهنده کتابخانه وابستگی به MemoryPack دارد، باید پیکربندی دوگانه چارچوب هدف را انجام دهد.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) یک چارچوب grpc-dotnet بر مبنای کد (code-first) است که به جای protobuf از MessagePack استفاده می‌کند. MagicOnion اکنون از MemoryPack به عنوان لایه سریال‌سازی از طریق پکیج `MagicOnion.Serialization.MemoryPack` (پیش‌نمایش) پشتیبانی می‌کند. جزئیات بیشتر: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

یونیتی
---

حداقل نسخه پشتیبانی‌شده یونیتی `2022.3.12f1` است.

پکیج اصلی `MemoryPack` توسط nuget ارائه می‌شود و در یونیتی نیز قابل استفاده است. اگر نیاز به پشتیبانی از انواع داخلی یونیتی دارید، افزونه MemoryPack.Unity را به صورت مجزا ارائه می‌دهیم.

1. نصب `MemoryPack` از طریق NuGet با استفاده از [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* از منوی NuGet -> Manage NuGet Packages را باز کنید، "MemoryPack" را جستجو کرده و روی Install کلیک کنید.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* اگر با خطای تضاد نسخه مواجه شدید، اعتبارسنجی نسخه را در تنظیمات پلیر غیرفعال کنید (Edit -> Project Settings -> Player -> پایین بروید و "Other Settings" را باز کنید سپس تیک "Assembly Version Validation" را در بخش "Configuration" بردارید).

2. پکیج `MemoryPack.Unity` را با ارجاع به آدرس گیت نصب کنید

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack از تگ انتشار *.*.* استفاده می‌کند، بنابراین می‌توانید نسخه‌ای مانند #1.0.0 مشخص کنید. برای مثال: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


مانند نسخه .NET، کد توسط یک تولیدکننده کد (`MemoryPack.Generator.dll`) ایجاد می‌شود. پیاده‌سازی بدون Reflection نیز بهترین عملکرد را در IL2CPP ارائه می‌دهد.

برای اطلاعات بیشتر درباره یونیتی و Source Generator به [مستندات یونیتی](https://docs.unity3d.com/Manual/roslyn-analyzers.html) مراجعه فرمایید.

Source Generator به طور رسمی توسط یونیتی در [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) و [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html) استفاده می‌شود. به عبارت دیگر، این استاندارد نسل بعدی تولید کد در یونیتی است.

شما می‌توانید همه انواع unmanaged (مانند `Vector3`، `Rect` و غیره) و برخی کلاس‌ها (`AnimationCurve`، `Gradient`، `RectOffset`) را سریالایز کنید. اگر می‌خواهید انواع خاص یونیتی را سریالایز کنید، به بخش [Serialize external types](#serialize-external-types) مراجعه کنید.

در یونیتی، MemoryPack تا 3 تا 10 برابر سریع‌تر از JsonUtility عمل می‌کند.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

اگر کد اشتراکی شامل نوعی از یونیتی (مانند `Vector2` و غیره) باشد، MemoryPack بسته `MemoryPack.UnityShims` را در NuGet ارائه می‌دهد.

بسته `MemoryPack.UnityShims` شیم‌هایی برای ساختارهای استاندارد یونیتی (`Vector2`، `Vector3`، `Vector4`، `Quaternion`، `Color`، `Bounds`، `Rect`، `Keyframe`، `WrapMode`، `Matrix4x4`، `GradientColorKey`، `GradientAlphaKey`، `GradientMode`، `Color32`، `LayerMask`، `Vector2Int`، `Vector3Int`، `RangeInt`، `RectInt`، `BoundsInt`) و برخی کلاس‌ها (`AnimationCurve`، `Gradient`، `RectOffset`) فراهم می‌کند.

> [!WARNING]
> در حال حاضر محدودیت‌های زیر برای استفاده در یونیتی وجود دارد


1. نسخه یونیتی از CustomFormatter پشتیبانی نمی‌کند.
2. اگر از .NET7 یا بالاتر استفاده می‌کنید، فرمت باینری MemoryPack کاملاً با یونیتی سازگار نیست.
    - این مشکل برای انواع مقدار که `[StructLayout(LayoutKind.Auto)]` به طور صریح مشخص شده رخ می‌دهد. (پیش‌فرض struct، `LayoutKind.Sequencil` است.) برای این نوع، فایل باینری سریالایز شده در .NET قابل دی‌سریالایز در یونیتی نیست. به طور مشابه، باینری سریالایز شده در یونیتی قابل دی‌سریالایز در سمت .NET نیست.
    - انواع متأثر معمولاً شامل موارد زیر هستند:
        - `DateTimeOffset`
        - `ValueTuple`
    - در حال حاضر راه‌حل ساده این است که از این انواع استفاده نکنید.


Native AOT
---
متأسفانه، Native AOT در .NET 7 باعث کرش می‌شود (`Generic virtual method pointer lookup failure`) هنگام استفاده از MemoryPack به دلیل یک باگ زمان اجرا. این مشکل قرار است در .NET 8 رفع شود. استفاده از نسخه پیش‌نمایش ``Microsoft.DotNet.ILCompiler`` این مشکل را در .NET 7 حل می‌کند. لطفاً برای نحوه راه‌اندازی به [نظر این issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) مراجعه کنید.

مشخصات فرمت باینری wire
---
نوع `T` تعریف‌شده در `Serialize<T>` و `Deserialize<T>` به عنوان schema سی‌شارپ شناخته می‌شود. فرمت MemoryPack یک فرمت خودتوصیف نیست. دی‌سریالایز نیاز به schema متناظر سی‌شارپ دارد. این انواع به عنوان نمایش داخلی باینری‌ها وجود دارند اما بدون schema سی‌شارپ نمی‌توان نوع را تشخیص داد.

Endian باید `Little Endian` باشد. با این حال، پیاده‌سازی مرجع سی‌شارپ به Endianness توجهی ندارد، بنابراین روی ماشین big-endian قابل استفاده نیست. البته رایانه‌های مدرن معمولاً little-endian هستند.

هشت نوع فرمت وجود دارد:

* ساختار Unmanaged
* شیء (Object)
* شیء با تحمل نسخه (Version Tolerant Object)
* شیء با ارجاع حلقه‌ای
* تاپل
* کالکشن
* رشته
* یونیون

### ساختار Unmanaged

ساختار Unmanaged، struct در زبان C# است که نوع ارجاعی ندارد، محدودیتی مشابه [انواع Unmanaged در C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types) دارد. لایه‌بندی struct به همان صورت سریال‌سازی می‌شود و شامل padding نیز می‌باشد.

### شیء

`(byte memberCount, [values...])`

شیء دارای یک بایت بدون علامت به عنوان تعداد اعضا در هدر است. تعداد اعضا می‌تواند از `0` تا `249` باشد، `255` نشان‌دهنده این است که شیء `null` است. مقادیر، مقدار memorypack را به تعداد تعداد اعضا ذخیره می‌کنند.

### شیء مقاوم در برابر نسخه

`(byte memberCount, [varint byte-length-of-values...], [values...])`

شیء مقاوم در برابر نسخه مشابه شیء معمولی است اما در هدر، طول بایت مقادیر را دارد. varint مطابق این مشخصات است، اولین sbyte مقدار یا typeCode است و X بایت بعدی مقدار است. 0 تا 127 = مقدار unsigned byte، -1 تا -120 = مقدار signed byte، -121 = byte، -122 = sbyte، -123 = ushort، -124 = short، -125 = uint، -126 = int، -127 = ulong، -128 = long.

### شیء با ارجاع حلقه‌ای

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

شیء با ارجاع حلقه‌ای مشابه شیء مقاوم در برابر نسخه است اما اگر memberCount برابر 250 باشد، varint بعدی (unsigned-int32) referenceId است. در غیر این صورت، بعد از byte-length-of-values، varint referenceId نوشته می‌شود.

### تاپل

`(values...)`

تاپل یک مجموعه با اندازه ثابت و غیرقابل null شدن است. در .NET، `KeyValuePair<TKey, TValue>` و `ValueTuple<T,...>` به عنوان تاپل سریال‌سازی می‌شوند.

### کالکشن

`(int length, [values...])`

کالکشن دارای یک عدد صحیح 4 بایتی با علامت به عنوان تعداد داده‌ها در هدر است، `-1` نشان‌دهنده `null` است. مقادیر، مقدار memorypack را به تعداد length ذخیره می‌کنند.

### رشته

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

رشته دو حالت دارد، UTF16 و UTF8. اگر اولین عدد صحیح 4 بایتی با علامت `-1` باشد، نشان‌دهنده null است. `0` نشان‌دهنده خالی بودن است. UTF16 مشابه کالکشن است (سریال‌سازی به صورت `ReadOnlySpan<char>`، تعداد بایت utf16-value برابر است با utf16-length * 2). اگر اولین عدد صحیح با علامت <= `-2` باشد، مقدار با UTF8 کدگذاری شده است. utf8-byte-count به صورت متمم، `~utf8-byte-count` برای به دست آوردن تعداد بایت‌ها کدگذاری شده است. عدد صحیح بعدی طول utf16 است و مقدار `-1` نیز مجاز است که نشان‌دهنده طول نامشخص است. utf8-bytes بایت‌ها را به تعداد utf8-byte-count ذخیره می‌کند.

### یونیون

`(byte tag, value)`  
`(250, ushort tag, value)`

اولین بایت بدون علامت، تگ است که برای نوع مقدار تمایز یافته یا فلگ استفاده می‌شود، `0` تا `249` معرف تگ است، `250` نشان‌دهنده این است که unsigned short بعدی تگ است، `255` نشان‌دهنده این است که union مقدار `null` دارد.

License
---
این کتابخانه تحت مجوز MIT ارائه شده است.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---