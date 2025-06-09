# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

مُسلسل ثنائي عالي الأداء بدون ترميز للأشياء في C# و Unity.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> مقارنةً مع [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json)، [protobuf-net](https://github.com/protobuf-net/protobuf-net)، [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp)، [Orleans.Serialization](https://github.com/dotnet/orleans/). تم القياس باستخدام .NET 7 / Ryzen 9 5950X. هذه المسلسلات لديها طريقة `IBufferWriter<byte>`، تم التسلسل باستخدام `ArrayBufferWriter<byte>` وإعادة استخدامه لتجنب قياس نسخ الذاكرة المؤقتة.

بالنسبة للأشياء القياسية، يعد MemoryPack أسرع بـ 10 مرات و x2 ~ x5 أسرع من مسلسلات ثنائية أخرى. بالنسبة لمصفوفة الهياكل، يكون MemoryPack أكثر قوة، بسرعة تصل إلى x50 ~ x200 مقارنةً بالمسلسلات الأخرى.

MemoryPack هو المسلسل الرابع الذي أنشأته، حيث أنني أنشأت سابقاً مسلسلات معروفة، ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~، ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~، [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). سبب سرعة MemoryPack هو اعتماده على تنسيق ثنائي خاص ومحسن لـ C# وتنفيذ مضبوط جيداً بناءً على خبرتي السابقة. كما أنه تصميم جديد بالكامل يستفيد من .NET 7 و C# 11 وميزة Incremental Source Generator (يدعم أيضاً .NET Standard 2.1 (.NET 5, 6) ويوجد دعم لـ Unity).

المسلسلات الأخرى تقوم بالكثير من عمليات الترميز مثل ترميز VarInt، والعلامات، والسلاسل النصية، إلخ. يستخدم تنسيق MemoryPack تصميم "صفر ترميز" حيث يتم نسخ أكبر قدر ممكن من ذاكرة C#. صفر ترميز مشابه لـ FlatBuffers، لكنه لا يحتاج إلى نوع خاص، هدف تسلسل MemoryPack هو كائنات POCO.

بالإضافة إلى الأداء، يتميز MemoryPack بالخصائص التالية:

* دعم واجهات I/O الحديثة (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* توليد كود معتمد على Source Generator مناسب لـ Native AOT، بدون Dynamic CodeGen (IL.Emit)
* واجهات برمجية بدون انعكاس وغير عامة
* فك تسلسل إلى كائن موجود مسبقاً
* تسلسل متعدد الأشكال (الاتحاد)
* دعم محدود للتوافق مع الإصدارات (سريع/افتراضي) ودعم كامل للتوافق مع الإصدارات
* دعم تسلسل المراجع الدائرية
* تسلسل تدفقي مبني على PipeWriter/Reader
* توليد كود TypeScript و ASP.NET Core Formatter
* دعم Unity (2021.3) IL2CPP عبر .NET Source Generator

التثبيت
---
يتم توزيع هذه المكتبة عبر NuGet. لأفضل أداء، يوصى باستخدام `.NET 7`. الحد الأدنى هو `.NET Standard 2.1`.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

ويتطلب محرر الكود أيضاً دعم Roslyn 4.3.1، على سبيل المثال Visual Studio 2022 الإصدار 17.3، .NET SDK 6.0.401. للمزيد من التفاصيل، راجع [وثيقة دعم إصدار Roslyn](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support).

بالنسبة لـ Unity، المتطلبات وطريقة التثبيت مختلفة تماماً. راجع قسم [Unity](#unity) للمزيد من التفاصيل.

بداية سريعة
---
عرّف هيكل أو فئة ليتم تسلسلها وعلّمها بوسم `[MemoryPackable]` وكلمة `partial`.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

يتم توليد كود التسلسل بواسطة ميزة مولد الكود المصدر في C# والتي تنفذ واجهة `IMemoryPackable<T>`. في Visual Studio يمكنك معاينة الكود المولد باستخدام اختصار `Ctrl+K, R` على اسم الفئة واختيار `*.MemoryPackFormatter.g.cs`.

استدعِ `MemoryPackSerializer.Serialize<T>/Deserialize<T>` لتسلسل/فك تسلسل نسخة من الكائن.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

تدعم طريقة `Serialize` نوع الإرجاع `byte[]` كما يمكنها التسلسل إلى `IBufferWriter<byte>` أو `Stream`. تدعم طريقة `Deserialize` كل من `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` و `Stream`. وهناك أيضاً إصدارات غير عامة.

الأنواع المدعومة افتراضياً
---
هذه الأنواع يمكن تسلسلها افتراضياً:

* الأنواع الأولية في .NET (`byte`, `int`, `bool`, `char`, `double`, إلخ)
* الأنواع غير المُدارة (أي `enum`, أي هيكل معرفة من المستخدم لا يحتوي على أنواع مرجعية)
* `string`, `decimal`, `Half`, `Int128`, `UInt128`, `Guid`, `Rune`, `BigInteger`
* `TimeSpan`,  `DateTime`, `DateTimeOffset`, `TimeOnly`, `DateOnly`, `TimeZoneInfo`
* `Complex`, `Plane`, `Quaternion` `Matrix3x2`, `Matrix4x4`, `Vector2`, `Vector3`, `Vector4`
* `Uri`, `Version`, `StringBuilder`, `Type`, `BitArray`, `CultureInfo`
* `T[]`, `T[,]`, `T[,,]`, `T[,,,]`, `Memory<>`, `ReadOnlyMemory<>`, `ArraySegment<>`, `ReadOnlySequence<>`
* `Nullable<>`, `Lazy<>`, `KeyValuePair<,>`, `Tuple<,...>`, `ValueTuple<,...>`
* `List<>`, `LinkedList<>`, `Queue<>`, `Stack<>`, `HashSet<>`, `SortedSet<>`, `PriorityQueue<,>`
* `Dictionary<,>`, `SortedList<,>`, `SortedDictionary<,>`,  `ReadOnlyDictionary<,>` 
* `Collection<>`, `ReadOnlyCollection<>`, `ObservableCollection<>`, `ReadOnlyObservableCollection<>`
* `IEnumerable<>`, `ICollection<>`, `IList<>`, `IReadOnlyCollection<>`, `IReadOnlyList<>`, `ISet<>`
* `IDictionary<,>`, `IReadOnlyDictionary<,>`, `ILookup<,>`, `IGrouping<,>`,
* `ConcurrentBag<>`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentDictionary<,>`, `BlockingCollection<>`
* المجموعات الثابتة (`ImmutableList<>`, إلخ) والواجهات (`IImmutableList<>`, إلخ)

تعريف `[MemoryPackable]` `class` / `struct` / `record` / `record struct`
---
يمكن وسم `[MemoryPackable]` لأي `class`, `struct`, `record`, `record struct` و `interface`. إذا كان النوع `struct` أو `record struct` ولا يحتوي على أنواع مرجعية ([أنواع C# غير المُدارة](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)) فلن يتم استخدام أي وسم إضافي (تجاهل، تضمين، مُنشئ، ردود نداء)، حيث يتم التسلسل/فك التسلسل مباشرةً من الذاكرة.

أما خلاف ذلك، فبشكل افتراضي، يقوم `[MemoryPackable]` بتسلسل الخصائص أو الحقول العامة فقط. يمكنك استخدام `[MemoryPackIgnore]` لإزالة الهدف من التسلسل، ويقوم `[MemoryPackInclude]` بترقية عضو خاص ليكون هدفاً للتسلسل.

```csharp
[MemoryPackable]
public partial class Sample
{
    // يتم تسلسل هذه الأنواع افتراضياً
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // هذه الأنواع لا يتم تسلسلها افتراضياً
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // استخدم [MemoryPackIgnore] لإزالة عضو عام من التسلسل
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // استخدم [MemoryPackInclude] لترقية عضو خاص ليكون هدفاً للتسلسل
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

يضيف مولد كود MemoryPack معلومات حول الأعضاء التي تم تسلسلها إلى قسم `<remarks />`. يمكن مشاهدة ذلك بالتمرير فوق النوع في Intellisense.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

يجب أن تكون جميع الأعضاء قابلة للتسلسل بواسطة memorypack، وإلا سيصدر مولد الكود خطأ.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

لـ MemoryPack 35 قاعدة تشخيص (`MEMPACK001` إلى `MEMPACK035`) لتعريفها بشكل مريح.

إذا تم تعريف نوع الهدف لتسلسل MemoryPack خارجياً وتم تسجيله، استخدم `[MemoryPackAllowSerialize]` لكتم التشخيص.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

ترتيب الأعضاء **مهم جداً**، حيث أن MemoryPack لا يسلسل أسماء الأعضاء أو معلومات أخرى، بل يسلسل الحقول حسب ترتيب تعريفها. إذا كان النوع موروث، يتم التسلسل بترتيب الوالد → الابن. لا يمكن تغيير ترتيب الأعضاء لعملية فك التسلسل. لمزيد من التفاصيل حول تطوير المخطط، راجع قسم [التوافق مع الإصدارات](#version-tolerant).

الترتيب الافتراضي هو تسلسلي، لكن يمكنك اختيار الترتيب الصريح باستخدام `[MemoryPackable(SerializeLayout.Explicit)]` و `[MemoryPackOrder()]`.

```csharp
// تسلسل Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### اختيار المُنشئ

يدعم MemoryPack كل من المُنشئات ذات المعاملات وبدون معاملات. اختيار المُنشئ يتبع القواعد التالية (ينطبق على الكلاسات والهياكل):

* إذا كان هناك `[MemoryPackConstructor]`، يتم استخدامه.
* إذا لم يوجد مُنشئ صريح (بما في ذلك الخاص)، يتم استخدام مُنشئ بدون معاملات.
* إذا كان هناك مُنشئ واحد فقط (بما في ذلك الخاص)، يتم استخدامه سواء كان بدون أو مع معاملات.
* إذا كان هناك عدة منشئات، يجب تطبيق وسم `[MemoryPackConstructor]` على المنشئ المطلوب (لن يختار المولد تلقائياً)، وإلا سيصدر المولد خطأ.
* إذا كان يتم استخدام مُنشئ بمعاملات، يجب أن تتطابق جميع أسماء المعاملات مع أسماء الأعضاء المقابلة (بدون حساسية لحالة الأحرف).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // يمكنك استخدام مُنشئ بمعاملات - يجب أن تتطابق أسماء المعاملات مع أسماء الأعضاء (بدون حساسية لحالة الأحرف)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// يدعم أيضاً مُنشئ record الأساسي
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
// إذا كان هناك عدة منشئين، يجب استخدام [MemoryPackConstructor]
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### استدعاءات التسلسل (Serialization callbacks)

عند إجراء التسلسل/إلغاء التسلسل، يمكن لـ MemoryPack استدعاء حدث قبل/بعد العملية باستخدام السمات `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]`. يمكن وضعها على كل من الدوال الساكنة ودوال الكائن (غير الساكنة)، وعلى الدوال العامة والخاصة.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // ترتيب استدعاء الدوال هو: الساكنة -> الكائن
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // يسمح أيضًا بالدوال الخاصة
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

    // ملاحظة: الدالة الكائنية مع MemoryPackOnDeserializing لن يتم استدعاؤها إذا لم يتم تمرير الكائن بواسطة `ref`
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

تسمح الاستدعاءات بدوال بدون معلمات ودوال من نوع `ref reader/writer, ref T value`. على سبيل المثال، يمكن لاستدعاءات ref كتابة/قراءة رأس مخصص قبل عملية التسلسل.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1، استخدم where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // كتابة GUID في رأس البيانات.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // قراءة رأس مخصص قبل إلغاء التسلسل
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

إذا تم تعيين قيمة لـ `ref value`، يمكنك تغيير القيمة المستخدمة في التسلسل/إلغاء التسلسل. على سبيل المثال، الإنشاء من ServiceProvider.

```csharp
// قبل استخدام هذا المنسق، عيّن ServiceProvider
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

تعريف مجموعة مخصصة
---
بشكل افتراضي، يحاول النوع المميز بـ `[MemoryPackObject]` تسلسل أعضائه. ومع ذلك، إذا كان النوع مجموعة (`ICollection<>`, `ISet<>`, `IDictionary<,>`)، استخدم `GenerateType.Collection` لتسلسلها بشكل صحيح.

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

المُنشئ الساكن
---
لا يمكن لفئة MemoryPackable تعريف مُنشئ ساكن لأن الفئة الجزئية المولدة تستخدمه. بدلاً من ذلك، يمكنك تعريف `static partial void StaticConstructor()` للقيام بنفس الشيء.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

تعدد الأشكال (Union)
---
يدعم MemoryPack تسلسل كائنات الواجهة والفئات المجردة لتسلسل تعدد الأشكال. في MemoryPack تسمى هذه الميزة Union. يُسمح فقط للواجهات والفئات المجردة بوضع سمة `[MemoryPackUnion]` عليها. يجب أن تكون علامات الاتحاد فريدة.

```csharp
// ضع [MemoryPackable] وأنواع الوراثة مع [MemoryPackUnion]
// يدعم الاتحاد أيضًا الفئة المجردة
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

// التسلسل كنوع واجهة.
var bin = MemoryPackSerializer.Serialize(data);

// إلغاء التسلسل كنوع واجهة.
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

يسمح `tag` بقيم من `0` إلى `65535`، وهو فعال بشكل خاص للقيم الأقل من `250`.
```
إذا كان هناك واجهة وأنواع مشتقة منها في تجمعات مختلفة، يمكنك استخدام `MemoryPackUnionFormatterAttribute` بدلاً من ذلك. يتم إنشاء المُنسّقات بحيث يتم تسجيلها تلقائيًا عبر `ModuleInitializer` في C# 9.0 وما فوق.

> لاحظ أن `ModuleInitializer` غير مدعوم في Unity، لذلك يجب تسجيل المُنسّق يدويًا. لتسجيل مُنسّق الاتحاد الخاص بك، قم بمناداة `{اسم مُنسّق الاتحاد الخاص بك}Initializer.RegisterFormatter()` يدويًا في بدء التشغيل (Startup). على سبيل المثال `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB تعريف المُنسّق خارج نوع الهدف
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

يمكن جمع الاتحاد في الشيفرة عبر `DynamicUnionFormatter<T>`.

```csharp
// (ushort, Type)[]
var formatter = new DynamicUnionFormatter<IFooBarBaz>(
    (0, typeof(Foo)),
    (1, typeof(Bar)),
    (2, typeof(Baz))
);

MemoryPackFormatterProvider.Register(formatter);
```

واجهة برمجة التطبيقات للتسلسل
---
لـ `Serialize` ثلاث دوال تحميل (overloads).

```csharp
// يوجد أيضًا واجهة برمجة تطبيقات غير عامة، في هذه النسخة الوسيطة الأولى هي Type والقيمة هي object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

للحصول على أفضل أداء، يُوصى باستخدام واجهة برمجة التطبيقات التي تستخدم `BufferWriter`. هذا يقوم بالتسلسل مباشرةً إلى المخزن المؤقت. يمكن تطبيقه على `PipeWriter` في `System.IO.Pipelines`، و`BodyWriter` في ASP .NET Core، إلخ.

إذا كان هناك حاجة إلى `byte[]` (على سبيل المثال `RedisValue` في [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis))، فإن واجهة برمجة التطبيقات التي تعيد `byte[]` بسيطة وسريعة تقريبًا بنفس السرعة.

لاحظ أن `SerializeAsync` لـ `Stream` غير متزامنة إلا من حيث التفريغ (Flush)؛ حيث يتم تسلسل كل شيء مرة واحدة في مخزن مؤقت داخلي لـ MemoryPack ثم يُكتب باستخدام `WriteAsync`. لذلك، الدالة التي تعتمد على `BufferWriter` وتفصل بين المخزن المؤقت والتفريغ أفضل.

إذا كنت ترغب في إجراء كتابة تدفقية كاملة، راجع قسم [التسلسل المتدفق](#streaming-serialization).

### خيارات MemoryPackSerializerOptions

تُحدد `MemoryPackSerializerOptions` ما إذا كانت السلاسل النصية سيتم تسلسلها كـ UTF16 أو UTF8. يمكن ضبط هذا عن طريق تمرير `MemoryPackSerializerOptions.Utf8` لترميز UTF8، أو `MemoryPackSerializerOptions.Utf16` لترميز UTF16، أو `MemoryPackSerializerOptions.Default` التي تتيح الافتراضي وهو UTF8. تمرير قيمة null أو استخدام القيمة الافتراضية يؤدي إلى ترميز UTF8.

نظرًا لأن التمثيل الداخلي للسلاسل في C# هو UTF16، فإن أداء UTF16 أفضل. ومع ذلك، يكون حجم الحمولة عادةً أكبر؛ في UTF8، السلسلة ASCII تأخذ بايت واحد، بينما في UTF16 تأخذ بايتين. وبما أن الفرق في حجم الحمولة كبير، فالإعداد الافتراضي هو UTF8.

إذا كانت البيانات غير ASCII (مثل اليابانية، والتي يمكن أن تتجاوز 3 بايت، وUTF8 يكون أكبر)، أو إذا كان عليك ضغطها بشكل منفصل، فقد يعطي UTF16 نتائج أفضل.

بينما يمكن اختيار UTF8 أو UTF16 أثناء التسلسل، ليس من الضروري تحديده أثناء فك التسلسل. سيتم اكتشافه تلقائيًا وفك تسلسله بشكل طبيعي.

بالإضافة إلى ذلك يمكنك الحصول/تعيين `IServiceProvider? ServiceProvider { get; init; }` من الخيارات. يكون هذا مفيدًا للحصول على كائن DI (مثل `ILogger<T>`) أثناء عملية التسلسل (`MemoryPackReader/MemoryPackWriter` يحتويان على خاصية .Options).

واجهة برمجة التطبيقات لفك التسلسل
---
`Deserialize` لها تحميلات عبر `ReadOnlySpan<byte>` و`ReadOnlySequence<byte>`، ودعم `Stream` و`ref`.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

تحميلات `ref` تقوم بالكتابة فوق مثيل موجود، لمزيد من التفاصيل راجع قسم [الكتابة فوق](#overwrite).

`DeserializeAsync(Stream)` ليست عملية قراءة تدفقية كاملة، أولاً تقرأ إلى مخزن مؤقت داخلي خاص بـ MemoryPack حتى نهاية التدفق، ثم تقوم بفك التسلسل.

إذا كنت تريد القيام بعملية قراءة تدفقية كاملة، راجع قسم [التسلسل المتدفق](#streaming-serialization).

الكتابة فوق
---
لتقليل التخصيصات، يدعم MemoryPack فك التسلسل إلى مثيل موجود، والكتابة فوقه. يمكن استخدام ذلك مع تحميل `Deserialize(ref T? value)`.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// الكتابة فوق البيانات إلى المثيل الموجود.
MemoryPackSerializer.Deserialize(bin, ref person);
```

سيحاول MemoryPack الكتابة فوق أكبر قدر ممكن، ولكن إذا لم تتطابق الشروط التالية، سيتم إنشاء مثيل جديد (كما في فك التسلسل العادي):

* إذا كانت قيمة المرجع (بما في ذلك الأعضاء في الرسم البياني للكائنات) null، سيتم تعيين مثيل جديد
* يسمح فقط بالمنشئ بدون معلمات، إذا تم استخدام منشئ بمعلمات، سيتم إنشاء مثيل جديد
* إذا كانت القيمة `T[]`، يتم إعادة الاستخدام فقط إذا كان الطول متساويًا، وإلا يتم إنشاء مثيل جديد
* إذا كانت القيمة مجموعة تحتوي على دالة `.Clear()` (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) يتم مناداة Clear() وإعادة استخدامها، وإلا يتم إنشاء مثيل جديد

دعم الإصدارات (Version tolerant)
---
في الوضع الافتراضي (`GenerateType.Object`)، يدعم MemoryPack تطور المخطط بشكل محدود.

* لا يمكن تغيير struct غير المدار بعد الآن
* يمكن إضافة أعضاء، لكن لا يمكن حذفهم
* يمكن تغيير اسم العضو
* لا يمكن تغيير ترتيب الأعضاء
* لا يمكن تغيير نوع العضو

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// الإضافة مسموحة.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// الحذف غير مسموح.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// تغيير الترتيب غير مسموح.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

في حالات الاستخدام، يكون تخزين البيانات القديمة (إلى ملف، إلى redis، إلخ...) وقراءتها إلى مخطط جديد دائمًا ممكنًا. في سيناريو RPC، يوجد المخطط على كل من جانب العميل والخادم، ويجب تحديث العميل قبل الخادم. لا يوجد مشكلة في اتصال عميل محدث بخادم قديم، لكن لا يمكن لعميل قديم الاتصال بخادم جديد.

افتراضيًا، عندما تُقرأ البيانات القديمة إلى مخطط جديد، يتم تهيئة أي أعضاء غير موجودين على جانب البيانات بقيمة `default`.
إذا كنت تريد تجنب ذلك واستخدام القيم الافتراضية للحقل/الخاصية، يمكنك استخدام `[SuppressDefaultInitialization]`.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < إذا كانت البيانات القديمة مفقودة، يتم تعيين `111`.
    
    public int Prop3 { get; set; } = 222; // < إذا كانت البيانات القديمة مفقودة، يتم تعيين `default`.
}
```

 `[SuppressDefaultInitialization]` لديها القيد التالي:
- لا يمكن استخدامها مع readonly أو init-only أو required.

يعرض القسم التالي [معلومات التسلسل](#serialization-info) كيفية التحقق من تغيرات المخطط، مثلاً عبر CI، لمنع الحوادث.

عند استخدام `GenerateType.VersionTolerant`، فهو يدعم التوافق الكامل مع الإصدارات.

* لا يمكن تغيير struct غير المدار بعد الآن
* يجب أن يضاف لجميع الأعضاء `[MemoryPackOrder]` صراحةً (إلا إذا تم وضع الخاصية `SerializeLayout.Sequential`)
* يمكن إضافة الأعضاء أو حذفهم لكن لا يمكن إعادة استخدام الترتيب (يمكن استخدام الترتيب المفقود)
* يمكن تغيير اسم العضو
* لا يمكن تغيير ترتيب الأعضاء
* لا يمكن تغيير نوع العضو

```csharp
// يمكن التسلسل/فك التسلسل بين 
// VersionTolerantObject1 -> VersionTolerantObject2 و 
// VersionTolerantObject2 -> VersionTolerantObject1

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

// تم الحذف
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// تم الإضافة
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// إذا تم تعيين SerializeLayout.Sequential بشكل صريح، يسمح بالترتيب التلقائي.
// لكن لا يمكن حذف أي عضو لدعم تحمل الإصدارات.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` أبطأ من `GenerateType.Object` في التسلسل. وأيضاً، سيكون حجم الحمولة أكبر قليلاً.

معلومات التسلسل
----
يمكنك التحقق من IntelliSense في النوع لمعرفة الأعضاء التي يتم تسلسلها. هناك خيار لكتابة هذه المعلومات إلى ملف أثناء وقت الترجمة. قم بتعيين `MemoryPackGenerator_SerializationInfoOutputDirectory` كما يلي.

```xml
<!-- إخراج معلومات تسلسل memorypack إلى الدليل -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

المعلومات التالية تُكتب إلى الملف.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

إذا كان النوع unmanaged، يتم عرض `unmanaged` قبل اسم النوع.

```txt
unmanaged FooStruct
---
int x
int y
```

من خلال فحص الفروقات في هذا الملف، يمكن منع تغييرات المخطط الخطرة. على سبيل المثال، قد ترغب في استخدام CI لاكتشاف القواعد التالية

* تعديل نوع unmanaged
* تغيير ترتيب الأعضاء
* حذف الأعضاء

المرجعية الدائرية
---
يدعم MemoryPack أيضاً المرجعية الدائرية. هذا يسمح بتسلسل كائنات الشجرة كما هي.

```csharp
// لتمكين المرجعية الدائرية، استخدم GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

على سبيل المثال، كود [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) سيصبح هكذا.

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

`GenerateType.CircularReference` له نفس خصائص تحمل الإصدارات. ولكن، كقيد إضافي، يُسمح فقط بالمنشئين بدون معلمات. أيضاً، تتبع مراجع الكائنات يتم فقط للكائنات التي تم تعليمها بـ `GenerateType.CircularReference`. إذا كنت تريد تتبع أي كائن آخر، قم بتغليفه.

المحول المخصص (CustomFormatter)
---
إذا قمت بتنفيذ `MemoryPackCustomFormatterAttribute<T>` أو `MemoryPackCustomFormatterAttribute<TFormatter, T>` (أكثر كفاءة، لكن معقدة)، يمكنك تكوين استخدام محول مخصص لعضو في MemoryPackObject.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

يوفر MemoryPack سمات التنسيق التالية: `Utf8StringFormatterAttribute`، `Utf16StringFormatterAttribute`، `InternStringFormatterAttribute`، `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`، `BitPackFormatterAttribute`، `BrotliFormatter`، `BrotliStringFormatter`، `BrotliFormatter<T>`، `MemoryPoolFormatter<T>`، `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // يتم تسلسل هذا العضو كسلسلة UTF16، وهو أسرع من UTF8 لكن في ASCII، الحجم يكون أكبر (لكن في غير ASCII، أحياناً أصغر).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // عند فك التسلسل، تتم تهيئة Dictionary باستخدام StringComparer.OrdinalIgnoreCase.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // عند فك التسلسل، جميع السلاسل تُحفظ في الذاكرة (انظر: String.Intern). إذا تكررت القيم المشابهة، يتم توفير الذاكرة.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

لكي تقوم بتكوين مقارن التساوي للمجموعات/القواميس، جميع المحولات المدمجة لديها زيادة مُنشئ مع المقارن. يمكنك بسهولة إنشاء محولات مخصصة لمقارن التساوي.

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

`BitPackFormatter` يضغط فقط أنواع `bool[]`. عادةً يتم تسلسل `bool[]` كبايت واحد لكل قيمة منطقية، ومع ذلك فإن `BitPackFormatter` يسلسل `bool[]` مثل `BitArray` حيث يتم تخزين كل قيمة منطقية كبت واحد. باستخدام `BitPackFormatter`، تتحول 8 قيم منطقية إلى بايت واحد حيث كانت ستكون 8 بايت، مما يؤدي إلى حجم أصغر بـ 8 مرات.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` مخصص لـ `byte[]`، على سبيل المثال يمكنك ضغط حمولة كبيرة باستخدام Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` مخصص لـ `string`، يقوم بتسلسل السلسلة المضغوطة (UTF16) باستخدام Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```
```
`BrotliFormatter<T>` مخصص لأي نوع، حيث يتم ضغط البيانات المسلسلة باستخدام Brotli. إذا كان النوع هو `byte[]` أو `string`، يجب عليك استخدام `BrotliFormatter` أو `BrotliStringFormatter` لتحقيق أفضل أداء.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

تجميع مصفوفة أثناء فك التسلسل
---
من أجل فك تسلسل مصفوفة كبيرة (أي `T`)، يوفر MemoryPack عدة طرق فعالة للتجميع المؤقت (pooling). الطريقة الأكثر فعالية هي استخدام وظيفة [#Overwrite](#overwrite). وخاصةً، يتم دائمًا إعادة استخدام `List<T>`.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// يتم إعادة استخدام List<byte>، ولا يوجد تخصيص جديد أثناء فك التسلسل.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// للحصول على عمليات فعالة، يمكنك الحصول على Span<T> باستخدام CollectionsMarshal
var span = CollectionsMarshal.AsSpan(value.Payload);
```

هناك طريقة مريحة وهي فك التسلسل إلى ArrayPool في وقت فك التسلسل. يوفر MemoryPack كل من `MemoryPoolFormatter<T>` و `ReadOnlyMemoryPoolFormatter<T>`.

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

    // يجب عليك كتابة كود الإرجاع بنفسك، هنا مثال مقتطف.

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
    // تنفيذ أي عملية...
}   // الإرجاع إلى ArrayPool
```

الأداء
---
راجع منشور مدونتي [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

حجم الحمولة والضغط
---
يعتمد حجم الحمولة على القيمة المستهدفة؛ على عكس JSON، لا توجد مفاتيح وهو تنسيق ثنائي، لذلك من المحتمل أن يكون حجم الحمولة أصغر من JSON.

بالنسبة لأولئك الذين يستخدمون ترميز varint، مثل MessagePack و Protobuf، يميل حجم MemoryPack إلى أن يكون أكبر إذا تم استخدام الكثير من الأعداد الصحيحة (في MemoryPack، الأعداد الصحيحة دائمًا 4 بايت بسبب ترميز الحجم الثابت، بينما MessagePack من 1 إلى 5 بايت).

float و double هما 4 بايت و 8 بايت في MemoryPack، لكن 5 بايت و 9 بايت في MessagePack. لذلك، يكون MemoryPack أصغر، على سبيل المثال، لمصفوفات Vector3 (float, float, float).

السلسلة (String) تكون UTF8 افتراضيًا، وهو مشابه لمجمعات التسلسل الأخرى، ولكن إذا تم اختيار خيار UTF16، فسيكون الأمر ذا طبيعة مختلفة.

على أي حال، إذا كان حجم الحمولة كبيرًا، يجب التفكير في الضغط. يوصى باستخدام LZ4، ZStandard و Brotli.

### الضغط

يوفر MemoryPack أداة مساعدة فعّالة لضغط [Brotli](https://github.com/google/brotli) عبر [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) و [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder). يوفر كل من `BrotliCompressor` و `BrotliDecompressor` الخاصين بـ MemoryPack ضغط/فك ضغط مُحسّن لسلوك MemoryPack الداخلي.

```csharp
using MemoryPack.Compression;

// الضغط (يتطلب using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// الحصول على مصفوفة byte[] مضغوطة
var compressedBytes = compressor.ToArray();

// أو الكتابة إلى IBufferWriter<byte> آخر (مثال PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// فك الضغط (يتطلب using)
using var decompressor = new BrotliDecompressor();

// الحصول على ReadOnlySequence<byte> بعد فك الضغط من ReadOnlySpan<byte> أو ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

كل من `BrotliCompressor` و `BrotliDecompressor` هما struct، ولا يقومان بتخصيص الذاكرة في الكومة (heap). كلاهما يخزن البيانات المضغوطة أو المفكوكة الضغط في تجميع ذاكرة داخلي لعمليات Serialize/Deserialize. لذلك، من الضروري تحرير ذاكرة التجميع، لا تنس استخدام `using`.

مستوى الضغط مهم جدًا. الافتراضي مضبوط على quality-1 (CompressionLevel.Fastest)، وهو يختلف عن الافتراضي في .NET (CompressionLevel.Optimal, quality-4).

Fastest (quality-1) سيكون قريبًا من سرعة [LZ4](https://github.com/lz4/lz4)، لكن الجودة 4 أبطأ بكثير. تم اعتبار ذلك أمرًا حرجًا في سيناريو استخدام المجمع التسلسلي. كن حذرًا عند استخدام `BrotliStream` القياسي (quality-4 هو الافتراضي). على أي حال، سرعات الضغط/فك الضغط والأحجام ستنتج نتائج مختلفة جدًا مع أنواع البيانات المختلفة. يرجى تحضير البيانات التي ستتعامل معها تطبيقك واختبارها بنفسك.

لاحظ أن هناك عقوبة سرعة كبيرة بين MemoryPack غير المضغوط وضغط Brotli المضاف.

Brotli مدعوم أيضًا في formatter مخصص. يمكن لـ `BrotliFormatter` ضغط عضو معين.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

تسلسل الأنواع الخارجية
---
إذا كنت ترغب في تسلسل أنواع خارجية، يمكنك إنشاء formatter مخصص وتسجيله في provider، راجع [Formatter/Provider API](#formatterprovider-api) للمزيد من التفاصيل. ومع ذلك، فإن إنشاء formatter مخصص أمر صعب. لذلك نوصي بإنشاء نوع wrapper. على سبيل المثال، إذا كنت ترغب في تسلسل نوع خارجي يُسمى `AnimationCurve`.

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

النوع الذي يتم تغليفه (wrap) هو عام (public)، ولكن تم استثناؤه من التسلسل (`MemoryPackIgnore`). أما الخصائص التي تريد تسلسلها فهي خاصة (private)، لكن تم تضمينها (`MemoryPackInclude`). يجب أيضًا تجهيز نمطين من المنشئين (constructors). يجب أن يكون المنشئ الذي يستخدمه المجمع التسلسلي خاصًا (private).

كما هو، يجب تغليفه في كل مرة، وهذا غير مريح. وأيضًا غلاف struct لا يمكنه تمثيل null. لذا دعنا ننشئ formatter مخصص.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity لا تدعم scoped و TBufferWriter لذا غيّر التوقيع إلى `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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

أخيرًا، قم بتسجيل المهيئ في بدء التشغيل.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> ملاحظة: يمكن تسلسل AnimationCurve الخاصة بـ Unity افتراضيًا، لذلك لا تحتاج إلى هذا المهيئ المخصص لـ AnimationCurve

الحزم
---
يمتلك MemoryPack الحزم التالية.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

الحزمة `MemoryPack` هي المكتبة الرئيسية، توفر دعمًا كاملاً للتسلسل وإلغاء التسلسل عالي الأداء للكائنات الثنائية. تعتمد على `MemoryPack.Core` لمكتبات الأساسيات و `MemoryPack.Generator` لتوليد الشيفرة. تضيف `MemoryPack.Streaming` توسعات إضافية لـ [التسلسل المتدفق](#streaming-serialization). تضيف `MemoryPack.AspNetCoreMvcFormatter` مهيئات إدخال/إخراج لـ ASP.NET Core. تضيف `MemoryPack.UnityShims` أنواع وملحقات Unity للمشاركة بين .NET و Unity.

TypeScript ومهيئ ASP.NET Core
---
يدعم MemoryPack توليد الشيفرة لـ TypeScript. يقوم بتوليد الأصناف وشيفرة التسلسل من C#، بمعنى آخر، يمكنك مشاركة الأنواع مع المتصفح بدون استخدام OpenAPI أو proto أو ما شابه.

توليد الشيفرة مدمج مع الـ Source Generator، الخيارات التالية (`MemoryPackGenerator_TypeScriptOutputDirectory`) تحدد دليل إخراج شيفرة TypeScript. يتم إخراج شيفرة وقت التشغيل في نفس الوقت، لذلك لا توجد تبعيات إضافية مطلوبة.

```xml
<!-- إخراج شيفرة TypeScript الخاصة بـ memorypack إلى الدليل -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

يجب أن يكون نوع MemoryPackable في C# مشروحًا بـ `[GenerateTypeScript]`.

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

سيتم توليد شيفرة وقت التشغيل ونوع TypeScript في الدليل المستهدف.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

الشيفرة المولدة كما يلي، مع حقول بسيطة ودوال ساكنة لـ serialize/serializeArray و deserialize/deserializeArray.

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

يمكنك استخدام هذا النوع كما يلي.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// تسلسل إلى Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// إلغاء التسلسل من ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

تضيف حزمة `MemoryPack.AspNetCoreMvcFormatter` مهيئات إدخال وإخراج MemoryPack لـ ASP.NET Core MVC. يمكنك إضافة `MemoryPackInputFormatter` و `MemoryPackOutputFormatter` إلى ASP.NET Core MVC بالشيفرة التالية.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // إذا كان checkContentType: true يمكن حينها إخراج عدة تنسيقات (JSON/MemoryPack، إلخ...). القيمة الافتراضية هي false.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

إذا قمت بالاتصال من HttpClient، يمكنك تعيين `application/x-memorypack` في ترويسة المحتوى.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### تطابق أنواع TypeScript

هناك بعض القيود على الأنواع التي يمكن توليدها. من بين الأنواع البدائية، لا يتم دعم `char` و `decimal`. كما لا يمكن استخدام النوع OpenGenerics.

|  C#  |  TypeScript  | الوصف |
| ---- | ---- | ---- |
| `bool` |  `boolean`  |
| `byte` |  `number`  |
| `sbyte` |  `number`  |
| `int` |  `number` |
| `uint` |  `number` |
| `short` |  `number` |
| `ushort` |  `number` |
| `long` |  `bigint` |
```
| `ulong` |  `bigint` |
| `float` |  `number` |
| `double` |  `number` |
| `string` |  `string \| null`  | 
| `Guid` |  `string`  | في TypeScript، يمثّل كسلسلة نصية لكن يُسلسل/يُفك تسلسلها كثنائية 16 بايت
| `DateTime` | `Date` | سيتم تجاهل DateTimeKind
| `enum` | `const enum` | نوع الأساس `long` و `ulong` غير مدعوم
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | يدعم جميع الأنواع التي تطبق `ICollection<T>` مثل `List<T>`
| `: ISet<T>` | `Set<T> \| null` | يدعم جميع الأنواع التي تطبق `ISet<T>` مثل `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | يدعم جميع الأنواع التي تطبق `IDictionary<K,V>` مثل `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | يدعم الأصناف فقط
| `[MemoryPackUnion]` | `abstract class` |

يمكن تطبيق `[GenerateTypeScript]` على الأصناف فقط، وغير مدعوم حاليًا للهياكل (struct).

### ضبط امتداد ملف الاستيراد وحالة أسماء الأعضاء

بشكل افتراضي، يقوم MemoryPack بتوليد امتداد الملف كـ `.js` مثل `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. إذا أردت تغييره إلى امتداد آخر أو تركه فارغًا، استخدم الخاصية `MemoryPackGenerator_TypeScriptImportExtension` لضبط ذلك.
أيضًا، يتم تحويل اسم العضو تلقائيًا إلى صيغة camelCase. إذا أردت استخدام الاسم الأصلي، اضبط الخاصية `MemoryPackGenerator_TypeScriptConvertPropertyName` إلى `false`.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- يسمح بتركها فارغة -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- الافتراضي هو true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- الافتراضي هو false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

تسمح الخاصية `MemoryPackGenerator_TypeScriptEnableNullableTypes` بأن تنعكس تعليقات Nullable في C# على كود TypeScript. الافتراضي هو false، مما يجعل كل شيء قابلًا للإهمال (nullable).

تسلسل البث (Streaming Serialization)
---
يوفر `MemoryPack.Streaming` الفئة `MemoryPackStreamingSerializer`، والتي تضيف دعمًا إضافيًا لتسلسل وفك تسلسل المجموعات باستخدام التدفقات (streams).

```csharp
public static class MemoryPackStreamingSerializer
{
    public static async ValueTask SerializeAsync<T>(PipeWriter pipeWriter, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async ValueTask SerializeAsync<T>(Stream stream, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async IAsyncEnumerable<T?> DeserializeAsync<T>(PipeReader pipeReader, int bufferAtLeast = 4096, int readMinimumSize = 8192, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    public static IAsyncEnumerable<T?> DeserializeAsync<T>(Stream stream, int bufferAtLeast = 4096, int readMinimumSize = 8192, CancellationToken cancellationToken = default)
}
```

واجهة برمجة تطبيقات Formatter/Provider
---
إذا كنت تريد تنفيذ Formatter يدويًا، قم بوراثة `MemoryPackFormatter<T>` وأعد تعريف طريقتي `Serialize` و `Deserialize`.

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

        // استخدم طريقة writer.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // استخدم طريقة reader.
    }
}
```
يتم تسجيل الـ Formatter الذي تم إنشاؤه باستخدام `MemoryPackFormatterProvider`.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

ملاحظة: لا يمكن استخدام Formatter مخصص مع `unmanged struct` (الذي لا يحتوي على أنواع مرجعية)، حيث يتم دومًا تسلسل تخطيط الذاكرة الأصلي.

MemoryPackWriter/ReaderOptionalState
---
تهيئة `MemoryPackWriter`/`MemoryPackReader` تتطلب OptionalState. وهو غلاف لـ `MemoryPackSerializerOptions`، ويمكن إنشاؤه من `MemoryPackWriterOptionalStatePool`.

```csharp
// عند التخلص، سيتم إعادة OptionalState إلى التجمع.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// للقراءة
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

الاعتمادية على إطار العمل المستهدف
---
يوفر MemoryPack كلاً من `netstandard2.1` و `net7.0` لكن كلاهما غير متوافقين مع بعضهما. على سبيل المثال، إذا كانت الأنواع MemoryPackable ضمن مشروع `netstandard2.1` وتستخدمها من مشروع `net7.0`، سيتم رمي استثناء وقت التشغيل مثل:

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

نظرًا لأن net7.0 يستخدم أعضاء ثابتة مجردة (`Virtual static method`)، التي لا يدعمها netstandard2.1، فهذا السلوك هو ضمن المواصفات.

يجب ألا يستخدم مشروع .NET 7 مكتبة netstandard 2.1 dll. بمعنى آخر، إذا كان التطبيق هو مشروع .NET 7، يجب أن تدعم جميع الاعتمادات التي تستخدم MemoryPack .NET 7. إذا كان مطور مكتبة لديه اعتماد على MemoryPack، يجب عليه ضبط إطار عمل مزدوج.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) هو إطار عمل grpc-dotnet يعتمد على الكود أولًا ويستخدم MessagePack بدلًا من protobuf. يدعم MagicOnion الآن MemoryPack كطبقة تسلسل عبر الحزمة `MagicOnion.Serialization.MemoryPack` (نسخة تجريبية). لمزيد من التفاصيل: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

أقل إصدار Unity مدعوم هو `2022.3.12f1`.

حزمة MemoryPack الأساسية متوفرة عبر nuget. وهي متوفرة أيضًا في Unity. إذا كنت تريد دعم أنواع Unity المدمجة، نوفر إضافة MemoryPack.Unity.

1. قم بتثبيت `MemoryPack` من NuGet باستخدام [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* افتح نافذة NuGet -> إدارة حزم NuGet، وابحث عن "MemoryPack" واضغط على تثبيت.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* إذا واجهت خطأ تعارض الإصدارات، يرجى تعطيل التحقق من الإصدار في إعدادات المشغل (Edit -> Project Settings -> Player -> مرر للأسفل وافتح "Other Settings" ثم ألغِ تحديد "Assembly Version Validation" تحت قسم "Configuration").

2. قم بتثبيت الحزمة `MemoryPack.Unity` عن طريق الإشارة إلى عنوان git

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


يستخدم MemoryPack علامة إصدار *.*.*، لذا يمكنك تحديد إصدار مثل #1.0.0. على سبيل المثال: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


كما هو الحال مع إصدار .NET، يتم توليد الكود بواسطة مولد الكود (`MemoryPack.Generator.dll`). كما يوفر التنفيذ الخالي من الانعكاس أفضل أداء في IL2CPP.

لمزيد من المعلومات حول Unity وSource Generator، يرجى الرجوع إلى [توثيق Unity](https://docs.unity3d.com/Manual/roslyn-analyzers.html).

يتم استخدام Source Generator رسميًا أيضًا من قبل Unity عبر [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) و[com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html). بمعنى آخر، إنه المعيار لتوليد الكود في الجيل القادم من Unity.

يمكنك تسلسل جميع الأنواع غير المدارة (مثل `Vector3`، `Rect`، إلخ...) وبعض الأصناف (`AnimationCurve`، `Gradient`، `RectOffset`). إذا أردت تسلسل أنواع Unity-specific أخرى، راجع قسم [تسلسل الأنواع الخارجية](#serialize-external-types).

في الأداء على Unity، MemoryPack أسرع من JsonUtility بمعدل x3~x10.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

إذا كان الكود المشترك يحتوي على أنواع Unity (`Vector2`، إلخ...)، يوفر MemoryPack حزمة `MemoryPack.UnityShims` على NuGet.

توفر حزمة `MemoryPack.UnityShims` شيمز للهياكل القياسية في Unity (`Vector2`، `Vector3`، `Vector4`، `Quaternion`، `Color`، `Bounds`، `Rect`، `Keyframe`، `WrapMode`، `Matrix4x4`، `GradientColorKey`، `GradientAlphaKey`، `GradientMode`، `Color32`، `LayerMask`، `Vector2Int`، `Vector3Int`، `RangeInt`، `RectInt`، `BoundsInt`) وبعض الأصناف (`AnimationCurve`، `Gradient`، `RectOffset`).

> [!تحذير]
> حاليًا، هناك القيود التالية للاستخدام في Unity


1. إصدار Unity لا يدعم CustomFormatter.
2. إذا كنت تستخدم .NET7 أو أحدث، فإن تنسيق MemoryPack الثنائي غير متوافق بالكامل مع Unity.
    - تحدث هذه المشكلة مع الأنواع القيمية التي تم تحديد `[StructLayout(LayoutKind.Auto)]` لها صراحة. (الإفتراضي للهيكل هو `LayoutKind.Sequencil`). لهذه الأنواع، لا يمكن فك تسلسل الثنائي الذي تم تسلسله في .NET في Unity. وبالمثل، لا يمكن تسلسل الثنائي الذي تم تسلسله في Unity في جانب .NET.
    - الأنواع المتأثرة تشمل عادةً الأنواع التالية:
        - `DateTimeOffset`
        - `ValueTuple`
    - الحل البسيط حاليًا هو عدم استخدام هذه الأنواع.


Native AOT
---
للأسف، .NET 7 Native AOT يسبب تعطل (`Generic virtual method pointer lookup failure`) عند استخدام MemoryPack بسبب خطأ في وقت التشغيل. 
سيتم إصلاحه في .NET 8. باستخدام نسخة المعاينة من ``Microsoft.DotNet.ILCompiler``، سيتم إصلاحه في .NET 7. يرجى مراجعة [تعليق المشكلة](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) لمعرفة كيفية الإعداد.

مواصفات تنسيق السلك الثنائي (Binary wire format specification)
---
نوع `T` المعرّف في `Serialize<T>` و `Deserialize<T>` يسمى مخطط C#. تنسيق MemoryPack ليس تنسيقًا معرّفًا ذاتيًا. فك التسلسل يتطلب مخطط C# المقابل. هذه الأنواع موجودة كممثلات داخلية للثنائي، لكن لا يمكن تحديد الأنواع بدون مخطط C#.

يجب أن يكون Endian هو `Little Endian`. مع ذلك، تنفيذ C# المرجعي لا يهتم بالـ endianness لذلك لا يمكن استخدامه على أجهزة big-endian. ومع ذلك، الحواسيب الحديثة عادةً ما تكون little-endian.

هناك ثمانية أنواع من التنسيق.

* هيكل غير مُدار (Unmanaged struct)
* كائن (Object)
* كائن متحمل للإصدارات (Version Tolerant Object)
* كائن المرجع الدائري
* Tuple
* المجموعة (Collection)
* السلسلة النصية (String)
* الاتحاد (Union)

### الهيكل غير المُدار (Unmanaged struct)

الهيكل غير المُدار هو هيكل (struct) في C# لا يحتوي على أنواع مرجعية، وهو مشابه للقيود الموجودة في [أنواع C# غير المُدارة](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types). يتم تسلسل تخطيط الهيكل كما هو، بما في ذلك الحشو.

### الكائن (Object)

`(byte memberCount, [values...])`

الكائن يحتوي على بايت واحد غير موقّع كعدد الأعضاء في الترويسة. عدد الأعضاء يسمح بالقيم من `0` إلى `249`، ويمثل `255` أن الكائن هو `null`. القيم تخزن قيمة memorypack بعدد الأعضاء.

### كائن متسامح مع الإصدارات (Version Tolerant Object)

`(byte memberCount, [varint byte-length-of-values...], [values...])`

الكائن المتسامح مع الإصدارات مشابه للكائن العادي ولكن يحتوي على طول القيم بالبايت في الترويسة. varint يتبع هذه المواصفات: أول sbyte هو القيمة أو typeCode، والبايتات التالية هي القيمة. من 0 إلى 127 = قيمة بايت غير موقّع، من -1 إلى -120 = قيمة بايت موقّع، -121 = بايت، -122 = sbyte، -123 = ushort، -124 = short، -125 = uint، -126 = int، -127 = ulong، -128 = long.

### كائن المرجع الدائري (Circular Reference Object)

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

كائن المرجع الدائري مشابه لكائن متسامح مع الإصدارات، ولكن إذا كان memberCount يساوي 250، فإن varint (unsigned-int32) التالي هو referenceId. إذا لم يكن كذلك، بعد byte-length-of-values، تتم كتابة varint referenceId.

### Tuple

`(values...)`

الـ Tuple هو مجموعة ذات حجم ثابت وغير قابلة لأن تكون null من القيم. في .NET، يتم تسلسل كل من `KeyValuePair<TKey, TValue>` و`ValueTuple<T,...>` كـ Tuple.

### المجموعة (Collection)

`(int length, [values...])`

المجموعة تحتوي على عدد صحيح موقّع من 4 بايت كعدد البيانات في الترويسة، ويمثل `-1` قيمة `null`. القيم تخزن قيمة memorypack بعدد الطول.

### السلسلة النصية (String)

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

السلسلة النصية لها شكلان: UTF16 وUTF8. إذا كان أول عدد صحيح موقّع من 4 بايت هو `-1`، فهذا يعني أنها null. وإذا كان `0`، فهذا يعني أنها فارغة. UTF16 مماثلة للمجموعة (تسلسل كـ `ReadOnlySpan<char>`، وعدد بايتات utf16-value هو utf16-length * 2). إذا كان العدد الصحيح الأول <= `-2`، يتم ترميز القيمة بـ UTF8. يتم ترميز utf8-byte-count بطريقة متممة، استخدم `~utf8-byte-count` لاسترداد عدد البايتات. العدد الصحيح التالي هو utf16-length، ويسمح بأن يكون `-1` ليمثل طول غير معروف. utf8-bytes تخزن البايتات بعدد utf8-byte-count.

### الاتحاد (Union)

`(byte tag, value)`  
`(250, ushort tag, value)`

أول بايت غير موقّع هو tag الذي يُستخدم لتمييز نوع القيمة أو العلم، من `0` إلى `249` تمثل tag، و`250` تعني أن الـ unsigned short التالي هو tag، و`255` تعني أن الاتحاد هو `null`.

الترخيص (License)
---
هذه المكتبة مرخصة بموجب رخصة MIT.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---