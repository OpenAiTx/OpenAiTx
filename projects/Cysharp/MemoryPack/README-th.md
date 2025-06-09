# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

ตัวซีเรียไลเซอร์ข้อมูลไบนารีประสิทธิภาพสูงแบบ zero encoding สำหรับ C# และ Unity

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> เปรียบเทียบกับ [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/). วัดผลด้วย .NET 7 / Ryzen 9 5950X เครื่อง. ซีเรียไลเซอร์เหล่านี้มีเมธอด `IBufferWriter<byte>`, ซีเรียไลซ์ด้วย `ArrayBufferWriter<byte>` และนำกลับมาใช้ซ้ำเพื่อหลีกเลี่ยงการวัดการคัดลอกบัฟเฟอร์.

สำหรับอ็อบเจ็กต์มาตรฐาน MemoryPack เร็วกว่า x10 และเร็วกว่า binary serializers อื่น ๆ x2 ~ x5 สำหรับ struct array, MemoryPack ทรงพลังยิ่งขึ้น โดยเร็วกว่าซีเรียไลเซอร์อื่นถึง x50 ~ x200

MemoryPack คือซีเรียไลเซอร์ตัวที่ 4 ที่ผมสร้างมาก่อนหน้านี้ ได้แก่ ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). เหตุผลที่ MemoryPack รวดเร็ว เพราะใช้ฟอร์แมตไบนารีที่ออกแบบมาเฉพาะและปรับแต่งสำหรับ C# อย่างดี และอิมพลีเมนเทชั่นที่ปรับจูนมาจากประสบการณ์เดิม นอกจากนี้ยังเป็นดีไซน์ใหม่หมดที่ใช้ .NET 7 และ C# 11 รวมถึง Incremental Source Generator (รองรับ .NET Standard 2.1 (.NET 5, 6) และ Unity ด้วย)

ซีเรียไลเซอร์อื่นจะมีขั้นตอน encoding หลายอย่าง เช่น VarInt encoding, tag, string ฯลฯ แต่ MemoryPack ใช้ดีไซน์ zero-encoding ที่คัดลอกหน่วยความจำของ C# ได้มากที่สุดเท่าที่ทำได้ แนวคิด zero-encoding คล้าย FlatBuffers แต่ไม่ต้องใช้ชนิดพิเศษ โดย MemoryPack สามารถซีเรียไลซ์ POCO ได้เลย

นอกจากประสิทธิภาพแล้ว MemoryPack ยังมีฟีเจอร์เหล่านี้

* รองรับ I/O APIs สมัยใหม่ (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* การสร้างโค้ดโดย Source Generator ที่เป็นมิตรกับ Native AOT, ไม่ใช้ Dynamic CodeGen (IL.Emit)
* API ที่ไม่ใช้ Reflection และไม่ต้องใช้เจนเนอริก
* Deserialize ลงในอินสแตนซ์ที่มีอยู่แล้ว
* ซีเรียไลซ์แบบ Polymorphism (Union)
* รองรับ version-tolerant แบบจำกัด (fast/default) และแบบเต็ม
* รองรับ Circular reference serialization
* รองรับ PipeWriter/Reader สำหรับ serialization แบบสตรีม
* การสร้างโค้ด TypeScript และ ASP.NET Core Formatter
* รองรับ Unity (2021.3) IL2CPP ผ่าน .NET Source Generator

การติดตั้ง
---
ไลบรารีนี้เผยแพร่ผ่าน NuGet สำหรับประสิทธิภาพสูงสุด แนะนำให้ใช้ `.NET 7` ข้อกำหนดขั้นต่ำคือ `.NET Standard 2.1`

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

และตัวแก้ไขโค้ดต้องรองรับ Roslyn 4.3.1 เช่น Visual Studio 2022 เวอร์ชัน 17.3, .NET SDK 6.0.401 รายละเอียดดูที่ [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support)

สำหรับ Unity ข้อกำหนดและขั้นตอนติดตั้งจะแตกต่างกันโดยสิ้นเชิง ดูรายละเอียดในหัวข้อ [Unity](#unity)

เริ่มต้นใช้งานอย่างรวดเร็ว
---
กำหนด struct หรือ class ที่ต้องการซีเรียไลซ์และใส่ attribute `[MemoryPackable]` พร้อมกับใช้ keyword `partial`

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

โค้ดสำหรับ serialization จะถูกสร้างโดยฟีเจอร์ C# source generator ซึ่งจะ implements อินเตอร์เฟซ `IMemoryPackable<T>` ใน Visual Studio สามารถดูโค้ดที่สร้างขึ้นได้โดยใช้คีย์ลัด `Ctrl+K, R` ที่ชื่อคลาสและเลือก `*.MemoryPackFormatter.g.cs`

เรียกใช้ `MemoryPackSerializer.Serialize<T>/Deserialize<T>` เพื่อซีเรียไลซ์/ดีซีเรียไลซ์อินสแตนซ์ของอ็อบเจ็กต์

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

เมธอด `Serialize` รองรับทั้งการคืนค่าเป็น `byte[]` รวมถึงสามารถซีเรียไลซ์ไปยัง `IBufferWriter<byte>` หรือ `Stream` ได้ เมธอด `Deserialize` รองรับ `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` และ `Stream` รวมถึงมีเวอร์ชันที่ไม่ใช้เจนเนอริกด้วย

ประเภทที่รองรับในตัว
---
ประเภทเหล่านี้สามารถซีเรียไลซ์ได้โดยตรง:

* .NET primitives (`byte`, `int`, `bool`, `char`, `double` ฯลฯ)
* Unmanaged types (เช่น `enum` ใดๆ, `struct` ที่ผู้ใช้กำหนดเองซึ่งไม่มี reference types)
* `string`, `decimal`, `Half`, `Int128`, `UInt128`, `Guid`, `Rune`, `BigInteger`
* `TimeSpan`,  `DateTime`, `DateTimeOffset`, `TimeOnly`, `DateOnly`, `TimeZoneInfo`
* `Complex`, `Plane`, `Quaternion`, `Matrix3x2`, `Matrix4x4`, `Vector2`, `Vector3`, `Vector4`
* `Uri`, `Version`, `StringBuilder`, `Type`, `BitArray`, `CultureInfo`
* `T[]`, `T[,]`, `T[,,]`, `T[,,,]`, `Memory<>`, `ReadOnlyMemory<>`, `ArraySegment<>`, `ReadOnlySequence<>`
* `Nullable<>`, `Lazy<>`, `KeyValuePair<,>`, `Tuple<,...>`, `ValueTuple<,...>`
* `List<>`, `LinkedList<>`, `Queue<>`, `Stack<>`, `HashSet<>`, `SortedSet<>`, `PriorityQueue<,>`
* `Dictionary<,>`, `SortedList<,>`, `SortedDictionary<,>`,  `ReadOnlyDictionary<,>` 
* `Collection<>`, `ReadOnlyCollection<>`, `ObservableCollection<>`, `ReadOnlyObservableCollection<>`
* `IEnumerable<>`, `ICollection<>`, `IList<>`, `IReadOnlyCollection<>`, `IReadOnlyList<>`, `ISet<>`
* `IDictionary<,>`, `IReadOnlyDictionary<,>`, `ILookup<,>`, `IGrouping<,>`,
* `ConcurrentBag<>`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentDictionary<,>`, `BlockingCollection<>`
* Immutable collections (`ImmutableList<>` ฯลฯ) และ interfaces (`IImmutableList<>` ฯลฯ)

การกำหนด `[MemoryPackable]` ให้กับ `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` สามารถใช้กับ `class`, `struct`, `record`, `record struct` และ `interface` ใดๆ หากชนิดเป็น `struct` หรือ `record struct` ที่ไม่มี reference types ([C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)) จะไม่ใช้ annotation อื่นใด (ignore, include, constructor, callbacks) โดยจะซีเรียไลซ์/ดีซีเรียไลซ์ตรงจากเมมโมรี

ในกรณีอื่น `[MemoryPackable]` จะซีเรียไลซ์ property หรือ field สาธารณะโดยอัตโนมัติ สามารถใช้ `[MemoryPackIgnore]` เพื่อลบออกจาก serialization target หรือ `[MemoryPackInclude]` เพื่อโปรโมตสมาชิก private ให้ซีเรียไลซ์ได้

```csharp
[MemoryPackable]
public partial class Sample
{
    // สมาชิกเหล่านี้จะถูกซีเรียไลซ์โดยอัตโนมัติ
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // สมาชิกเหล่านี้จะไม่ถูกซีเรียไลซ์โดยอัตโนมัติ
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // ใช้ [MemoryPackIgnore] เพื่อลบ public member ออกจาก target
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // ใช้ [MemoryPackInclude] เพื่อโปรโมตสมาชิก private ให้ซีเรียไลซ์ได้
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

ตัว generator ของ `MemoryPack` จะเพิ่มข้อมูลว่าสมาชิกตัวไหนถูกซีเรียไลซ์ลงในส่วน `<remarks />` ซึ่งสามารถดูได้โดยเอาเมาส์ชี้ที่ชนิดนั้นใน Intellisense

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

สมาชิกทั้งหมดต้องสามารถซีเรียไลซ์ด้วย memorypack ได้ หากไม่เป็นไปตามนั้น code generator จะส่ง error

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack มี diagnostic rule ทั้งหมด 35 ข้อ (`MEMPACK001` ถึง `MEMPACK035`) เพื่อให้กำหนดได้อย่างมั่นใจ

หากชนิดเป้าหมายมีการกำหนด MemoryPack serialization ภายนอกและมีการลงทะเบียนแล้ว สามารถใช้ `[MemoryPackAllowSerialize]` เพื่อปิด diagnostic ได้

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

ลำดับของสมาชิก **สำคัญมาก** MemoryPack จะไม่ซีเรียไลซ์ชื่อสมาชิกหรือข้อมูลอื่น ๆ แต่จะซีเรียไลซ์ฟิลด์ตามลำดับที่ประกาศ ถ้าชนิดมีการสืบทอด จะซีเรียไลซ์ตามลำดับ parent → child ลำดับสมาชิกต้องไม่เปลี่ยนสำหรับการดีซีเรียไลซ์ ในกรณี schema evolution ดูในหัวข้อ [Version tolerant](#version-tolerant)

ลำดับปกติจะเป็นไปตามลำดับประกาศ แต่สามารถเลือก explicit layout ได้ด้วย `[MemoryPackable(SerializeLayout.Explicit)]` และ `[MemoryPackOrder()]`

```csharp
// ซีเรียไลซ์ Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### การเลือก Constructor

MemoryPack รองรับทั้ง parameterized และ parameterless constructor กติกาการเลือก constructor มีดังนี้ (ใช้กับทั้ง class และ struct):

* หากมี `[MemoryPackConstructor]` จะใช้ตัวนั้น
* หากไม่มี constructor (รวมถึง private) จะใช้ parameterless
* หากมี constructor แบบ parameterless/parameterized เพียงหนึ่งตัว (รวมถึง private) จะใช้ตัวนั้น
* หากมี constructor หลายตัว ต้องใส่ attribute `[MemoryPackConstructor]` ให้กับ constructor ที่ต้องการ (generator จะไม่เลือกให้เอง) มิฉะนั้น generator จะส่ง error
* หากใช้ parameterized constructor ชื่อ parameter ทั้งหมดต้องตรงกับชื่อสมาชิก (case-insensitive)

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // สามารถใช้ parameterized constructor ได้ - ชื่อ parameter ต้องตรงกับชื่อสมาชิก (case-insensitive)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// รองรับ record primary constructor ด้วย
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
// หากมี constructor หลายตัว จะต้องใช้ [MemoryPackConstructor]
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### การเรียก callback ระหว่างการ serialization

เมื่อทำการ serialize/deserialize, MemoryPack สามารถเรียกใช้งาน event ก่อน/หลัง ได้โดยใช้ attribute `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]` สามารถใส่ annotation ได้ทั้ง method แบบ static และ instance (ไม่ใช่ static) และทั้ง method ที่เป็น public และ private

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // ลำดับการเรียก method คือ static -> instance
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // รองรับ method แบบ private ด้วย
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

    // หมายเหตุ: instance method ที่มี MemoryPackOnDeserializing จะไม่ถูกเรียกถ้า instance ไม่ถูกส่งแบบ `ref`
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

Callback รองรับ method ที่ไม่มี parameter และแบบ `ref reader/writer, ref T value` ด้วย ตัวอย่างเช่น callback แบบ ref สามารถเขียน/อ่าน header แบบ custom ก่อนเริ่มกระบวนการ serialization

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, ใช้ where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // เขียน GUID ที่ header
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // อ่าน custom header ก่อน deserialize
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

หากกำหนดค่าให้กับ `ref value` จะสามารถเปลี่ยนแปลงค่าที่ใช้ในการ serialize/deserialize ได้ เช่น การสร้าง instance จาก ServiceProvider

```csharp
// ก่อนใช้ formatter นี้ ให้ตั้งค่า ServiceProvider
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

การกำหนด collection แบบ custom
---
โดยปกติแล้ว type ที่มี annotation `[MemoryPackObject]` จะพยายาม serialize สมาชิกของตนเอง อย่างไรก็ตาม หาก type นั้นเป็น collection (`ICollection<>`, `ISet<>`, `IDictionary<,>`) ให้ใช้ `GenerateType.Collection` เพื่อให้ serialize ได้อย่างถูกต้อง

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

Static constructor
---
คลาส MemoryPackable ไม่สามารถกำหนด static constructor ได้เพราะ partial class ที่ถูก generate จะใช้งานมันอยู่แล้ว ให้กำหนดเป็น `static partial void StaticConstructor()` แทนเพื่อให้ได้ผลลัพธ์แบบเดียวกัน

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Polymorphism (Union)
---
MemoryPack รองรับการ serialize อ็อบเจ็กต์ที่เป็น interface และ abstract class สำหรับการ serialize แบบ polymorphism โดยใน MemoryPack คุณสมบัตินี้เรียกว่า Union โดยจะอนุญาตให้เฉพาะ interface และ abstract class เท่านั้นที่ใช้ attribute `[MemoryPackUnion]` ได้ ต้องกำหนด tag ของ union ให้ไม่ซ้ำกัน

```csharp
// ใส่ [MemoryPackable] และ type ที่สืบทอดด้วย [MemoryPackUnion]
// Union รองรับ abstract class ด้วย
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

// Serialize เป็น type ของ interface
var bin = MemoryPackSerializer.Serialize(data);

// Deserialize เป็น type ของ interface
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

`tag` รองรับค่าตั้งแต่ `0` ถึง `65535` และมีประสิทธิภาพสูงเป็นพิเศษสำหรับค่าต่ำกว่า `250`
หากอินเทอร์เฟซและไทป์ที่สืบทอดอยู่ใน Assembly ที่ต่างกัน คุณสามารถใช้ `MemoryPackUnionFormatterAttribute` แทนได้ Formatter จะถูกสร้างขึ้นโดยอัตโนมัติและลงทะเบียนผ่าน `ModuleInitializer` ใน C# 9.0 ขึ้นไป

> หมายเหตุว่า `ModuleInitializer` ไม่รองรับใน Unity ดังนั้น Formatter จะต้องลงทะเบียนด้วยตนเอง ในการลงทะเบียน union formatter ของคุณ ให้เรียกใช้ `{name of your union formatter}Initializer.RegisterFormatter()` ด้วยตนเองใน Startup ตัวอย่างเช่น `UnionSampleFormatterInitializer.RegisterFormatter()`

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB กำหนด definition นอกเหนือจาก type เป้าหมาย
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Union สามารถรวมกันในโค้ดได้ผ่าน `DynamicUnionFormatter<T>`

```csharp
// (ushort, Type)[]
var formatter = new DynamicUnionFormatter<IFooBarBaz>(
    (0, typeof(Foo)),
    (1, typeof(Bar)),
    (2, typeof(Baz))
);

MemoryPackFormatterProvider.Register(formatter);
```

Serialize API
---
`Serialize` มีทั้งหมดสาม overload

```csharp
// Non generic API ก็มีเช่นกัน เวอร์ชันนี้ argument แรกเป็น Type และ value เป็น object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

เพื่อประสิทธิภาพที่ดี API ที่แนะนำคือการใช้ `BufferWriter` ซึ่งจะ serialize ตรงเข้า buffer สามารถใช้กับ `PipeWriter` จาก `System.IO.Pipelines`, `BodyWriter` ใน ASP .NET Core ฯลฯ

หากต้องการ `byte[]` (เช่น `RedisValue` ใน [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)) การคืนค่า API แบบ `byte[]` ก็ใช้งานง่ายและเร็วเกือบเท่ากัน

โปรดทราบว่า `SerializeAsync` สำหรับ `Stream` จะเป็นแบบ asynchronous เฉพาะตอน Flush; โดยจะ serialize ทั้งหมดลง MemoryPack internal pool buffer แล้วจึงเขียนด้วย `WriteAsync` ดังนั้น overload แบบ `BufferWriter` ที่แยกและควบคุม buffer กับ flush ได้จะดีกว่า

หากคุณต้องการทำ streaming write แบบสมบูรณ์ โปรดดูหัวข้อ [Streaming Serialization](#streaming-serialization)

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` ใช้ตั้งค่าว่าจะ serialize string เป็น UTF16 หรือ UTF8 โดยสามารถตั้งค่าได้โดยส่ง `MemoryPackSerializerOptions.Utf8` สำหรับ encoding แบบ UTF8, `MemoryPackSerializerOptions.Utf16` สำหรับ UTF16 หรือ `MemoryPackSerializerOptions.Default` ซึ่งตั้งค่าเริ่มต้นเป็น UTF8 หากส่ง null หรือใช้ parameter default จะเป็น UTF8

เนื่องจาก string ใน C# จะเป็น UTF16 อยู่แล้ว การใช้ UTF16 จะเร็วกว่า แต่ขนาด payload จะใหญ่กว่า; ใน UTF8 string ASCII จะใช้ 1 byte, แต่ใน UTF16 จะใช้ 2 byte เนื่องจากความแตกต่างของขนาด payload นี้จึงตั้งค่า default เป็น UTF8

หากข้อมูลเป็น non-ASCII (เช่น ญี่ปุ่น ที่อาจเกิน 3 byte และ UTF8 ใหญ่กว่า) หรือหากคุณต้องบีบอัดแยกต่างหาก การใช้ UTF16 อาจให้ผลลัพธ์ที่ดีกว่า

แม้จะเลือก UTF8 หรือ UTF16 ตอน serialize ได้ แต่ขณะ deserialize ไม่จำเป็นต้องระบุ จะตรวจจับและแปลงกลับโดยอัตโนมัติ

นอกจากนี้คุณยังสามารถ get/set `IServiceProvider? ServiceProvider { get; init; }` จาก options ได้ด้วย ใช้กับกรณีต้องการ DI object (เช่น `ILogger<T>`) จากกระบวนการ serialization (`MemoryPackReader/MemoryPackWriter` มี .Options property)

Deserialize API
---
`Deserialize` มี overload สำหรับ `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`, `Stream` และรองรับ `ref`

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

overload แบบ `ref` จะ overwrite instance ที่มีอยู่ รายละเอียดดูหัวข้อ [Overwrite](#overwrite)

`DeserializeAsync(Stream)` ไม่ได้เป็นการอ่าน stream แบบ streaming เต็มรูปแบบ โดยจะอ่านเข้า internal pool ของ MemoryPack จนจบ stream แล้วจึง deserialize

หากคุณต้องการทำ streaming read แบบสมบูรณ์ โปรดดูหัวข้อ [Streaming Serialization](#streaming-serialization)

Overwrite
---
เพื่อช่วยลด allocation, MemoryPack รองรับการ deserialize ทับ instance เดิม โดยใช้ overload `Deserialize(ref T? value)`

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// overwrite ข้อมูลลง instance เดิม
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack จะพยายาม overwrite ให้มากที่สุดเท่าที่จะทำได้ แต่หากมีเงื่อนไขดังต่อไปนี้ไม่ตรง จะสร้าง instance ใหม่ (เหมือนการ deserialize ปกติ)

* ref value (รวมสมาชิกใน object graph) เป็น null, จะ set instance ใหม่
* อนุญาตเฉพาะ constructor แบบไม่มี parameter ถ้าใช้ parameterized constructor จะสร้าง instance ใหม่
* หาก value เป็น `T[]` จะ reuse เฉพาะกรณี length เท่ากัน, ไม่เช่นนั้นสร้าง instance ใหม่
* หาก value เป็น collection ที่มี `.Clear()` เช่น (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) จะเรียก Clear() และ reuse, ไม่เช่นนั้นสร้าง instance ใหม่

Version tolerant
---
โดยค่าเริ่มต้น (`GenerateType.Object`), MemoryPack รองรับ schema evolution แบบจำกัด

* struct แบบ unmanaged ไม่สามารถเปลี่ยนแปลงได้อีก
* สามารถเพิ่มสมาชิกได้ แต่ลบออกไม่ได้
* เปลี่ยนชื่อสมาชิกได้
* เปลี่ยนลำดับสมาชิกไม่ได้
* เปลี่ยนชนิดสมาชิกไม่ได้

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Add ได้
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Remove ไม่ได้
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// เปลี่ยนลำดับไม่ได้
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

สำหรับ use-case ที่เก็บข้อมูลเก่า (ไฟล์, redis, ฯลฯ) แล้วอ่านด้วย schema ใหม่ สามารถทำได้เสมอ ในกรณี RPC schema จะมีทั้งฝั่ง client และ server โดย client ต้องอัปเดตให้ใหม่ก่อน server client ที่อัปเดตแล้วจะเชื่อมต่อกับ server เก่าได้ แต่ client เก่าเชื่อมต่อกับ server ใหม่ไม่ได้

โดยปกติเมื่ออ่านข้อมูลเก่าเข้า schema ใหม่ สมาชิกที่ไม่มีในฝั่งข้อมูลจะถูกกำหนดค่าเป็น `default` เสมอ
หากต้องการหลีกเลี่ยงและใช้ค่าเริ่มต้นของ field/property สามารถใช้ `[SuppressDefaultInitialization]`

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < ถ้าข้อมูลเก่าขาด จะ set เป็น `111`
    
    public int Prop3 { get; set; } = 222; // < ถ้าข้อมูลเก่าขาด จะ set เป็น `default`
}
```

 `[SuppressDefaultInitialization]` มีข้อจำกัดดังนี้:
- ใช้กับ readonly, init-only และ required modifier ไม่ได้

หัวข้อถัดไป [Serialization info](#serialization-info) จะแสดงวิธีเช็ค schema change เช่น โดย CI เพื่อป้องกันข้อผิดพลาด

เมื่อใช้ `GenerateType.VersionTolerant` จะรองรับ version-tolerant อย่างสมบูรณ์

* struct แบบ unmanaged ไม่สามารถเปลี่ยนแปลงได้อีก
* ต้องเพิ่ม `[MemoryPackOrder]` ให้ทุกสมาชิก (ยกเว้น annotate `SerializeLayout.Sequential`)
* สามารถเพิ่มหรือลบสมาชิกได้ แต่ห้าม reuse order (ใช้ order ที่ขาดได้)
* เปลี่ยนชื่อสมาชิกได้
* เปลี่ยนลำดับสมาชิกไม่ได้
* เปลี่ยนชนิดสมาชิกไม่ได้

```csharp
// Ok ทั้ง serialize/deserialize จาก 
// VersionTolerantObject1 -> VersionTolerantObject2 และ 
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

// deleted
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// added
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// ถ้ากำหนด SerializeLayout.Sequential โดยตรง จะสามารถจัดลำดับอัตโนมัติได้
// แต่จะไม่สามารถลบสมาชิกใด ๆ สำหรับการรองรับเวอร์ชันได้
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` จะช้ากว่า `GenerateType.Object` ในการซีเรียลไลซ์ และขนาดของ payload จะใหญ่กว่าเล็กน้อย

ข้อมูลการซีเรียลไลซ์
----
คุณสามารถตรวจสอบ IntelliSense ใน type ว่าสมาชิกใดถูกซีเรียลไลซ์ มีตัวเลือกสำหรับเขียนข้อมูลนี้ลงไฟล์ขณะ compile ตั้งค่า `MemoryPackGenerator_SerializationInfoOutputDirectory` ดังนี้

```xml
<!-- ส่งออกข้อมูลการซีเรียลไลซ์ memorypack ไปที่ไดเรกทอรี -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

ข้อมูลต่อไปนี้จะถูกเขียนลงไฟล์

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

ถ้าประเภทเป็น unmanaged จะแสดง `unmanaged` ก่อนชื่อประเภท

```txt
unmanaged FooStruct
---
int x
int y
```

โดยการตรวจสอบความแตกต่างในไฟล์นี้ สามารถป้องกันการเปลี่ยนแปลง schema ที่อันตรายได้ ตัวอย่างเช่น คุณอาจต้องการใช้ CI เพื่อตรวจจับกฎต่อไปนี้

* แก้ไข unmanaged type
* การเปลี่ยนลำดับสมาชิก
* การลบสมาชิก

Circular Reference
---
MemoryPack รองรับ circular reference ด้วยเช่นกัน สิ่งนี้ทำให้สามารถซีเรียลไลซ์อ็อบเจกต์แบบต้นไม้ได้ตามจริง

```csharp
// เพื่อเปิดใช้งาน circular-reference ให้ใช้ GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

ตัวอย่างเช่น [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) โค้ดจะเป็นดังนี้

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

`GenerateType.CircularReference` มีลักษณะเช่นเดียวกับ version-tolerant แต่มีข้อจำกัดเพิ่มเติม คือต้องมีคอนสตรัคเตอร์แบบไม่มีพารามิเตอร์เท่านั้น และจะมีการติดตาม object reference เฉพาะกับอ็อบเจกต์ที่กำกับด้วย `GenerateType.CircularReference` เท่านั้น หากต้องการติดตามอ็อบเจกต์อื่น ให้ห่อมันไว้

CustomFormatter
---
หาก implements `MemoryPackCustomFormatterAttribute<T>` หรือ `MemoryPackCustomFormatterAttribute<TFormatter, T>` (มีประสิทธิภาพมากกว่าแต่ซับซ้อนกว่า) คุณสามารถกำหนด custom formatter ให้กับสมาชิกของ MemoryPackObject ได้

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack มี attribute สำหรับ formatting ดังต่อไปนี้: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`

```csharp
[MemoryPackable]
public partial class Sample
{
    // ซีเรียลไลซ์สมาชิกนี้เป็น UTF16 String มีประสิทธิภาพมากกว่า UTF8 แต่ใน ASCII ขนาดใหญ่กว่า (แต่ non ASCII บางครั้งเล็กกว่า)
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // ตอน deserialize Dictionary จะถูก initialize ด้วย StringComparer.OrdinalIgnoreCase
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // ตอน deserialize string ทั้งหมดจะถูก interned (ดู: String.Intern) ถ้ามีค่าคล้ายกันซ้ำ ๆ จะช่วยประหยัดหน่วยความจำ
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

หากต้องการกำหนด equality comparer สำหรับ set/dictionary ฟอร์แมตเตอร์ทั้งหมดที่มีในระบบจะมี constructor overload สำหรับ comparer ให้คุณสามารถสร้าง custom equality-comparer formatter ได้ง่าย

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

`BitPackFormatter` บีบอัดเฉพาะประเภท `bool[]` เท่านั้น โดยปกติ `bool[]` จะซีเรียลไลซ์เป็น 1 ไบต์ต่อค่า boolean แต่ `BitPackFormatter` จะซีเรียลไลซ์ `bool[]` แบบเดียวกับ `BitArray` โดยแต่ละค่า bool จะเก็บเป็น 1 บิต การใช้ `BitPackFormatter` จะทำให้ 8 ค่า bool เก็บใน 1 ไบต์ซึ่งปกติจะเป็น 8 ไบต์ ส่งผลให้ขนาดลดลง 8 เท่า

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` ใช้สำหรับ `byte[]` ตัวอย่างเช่น คุณสามารถบีบอัด payload ขนาดใหญ่ด้วย Brotli

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` สำหรับ `string` ซีเรียลไลซ์ string ที่ถูกบีบอัด (UTF16) ด้วย Brotli

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
`BrotliFormatter<T>` เหมาะสำหรับใช้กับทุกชนิดข้อมูล ข้อมูลที่ถูกซีเรียลไลซ์จะถูกบีบอัดด้วย Brotli หากชนิดข้อมูลเป็น `byte[]` หรือ `string` ควรใช้ `BrotliFormatter` หรือ `BrotliStringFormatter` เพื่อประสิทธิภาพที่ดีกว่า

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

การถอดรหัสแบบ array pooling
---
เพื่อถอดรหัสอาร์เรย์ขนาดใหญ่ (ชนิดใด ๆ `T`) MemoryPack มีวิธี pooling ที่มีประสิทธิภาพหลายรูปแบบ วิธีที่มีประสิทธิภาพสูงสุดคือการใช้ฟังก์ชัน [#Overwrite](#overwrite) โดยเฉพาะ `List<T>` จะถูกนำกลับมาใช้ซ้ำเสมอ

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> ถูกนำกลับมาใช้ซ้ำ ไม่มีการจัดสรรหน่วยความจำใหม่ขณะถอดรหัส
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// เพื่อให้ทำงานได้อย่างมีประสิทธิภาพ สามารถแปลงเป็น Span<T> ได้โดยใช้ CollectionsMarshal
var span = CollectionsMarshal.AsSpan(value.Payload);
```

อีกวิธีที่สะดวกคือถอดรหัสลงใน ArrayPool ระหว่างการถอดรหัส MemoryPack มี `MemoryPoolFormatter<T>` และ `ReadOnlyMemoryPoolFormatter<T>` ให้ใช้งาน

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

    // ต้องเขียนโค้ดสำหรับคืนหน่วยความจำเอง ตัวอย่างโค้ด

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
    // ทำงานใด ๆ ...
}   // คืนหน่วยความจำให้ ArrayPool
```

ประสิทธิภาพ
---
ดูบทความของผู้เขียน [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

ขนาด Payload และการบีบอัด
---
ขนาด payload จะขึ้นอยู่กับข้อมูลเป้าหมาย; ไม่เหมือน JSON ที่มี key และเป็นฟอร์แมตแบบ text แต่ MemoryPack เป็นไบนารี ดังนั้นขนาด payload มักจะเล็กกว่า JSON

สำหรับฟอร์แมตที่ใช้ varint encoding เช่น MessagePack และ Protobuf ในกรณีที่ใช้งาน int จำนวนมาก MemoryPack อาจมีขนาดใหญ่กว่า (ใน MemoryPack, int จะถูกเข้ารหัสขนาดคงที่ 4 ไบต์เสมอ ในขณะที่ MessagePack จะใช้ 1~5 ไบต์)

float และ double ใน MemoryPack จะใช้ 4 ไบต์ และ 8 ไบต์ ตามลำดับ แต่ใน MessagePack จะใช้ 5 ไบต์ และ 9 ไบต์ ดังนั้น MemoryPack จะเล็กกว่า เช่นในอาร์เรย์ Vector3 (float, float, float)

String จะเป็น UTF8 โดยดีฟอลต์ คล้ายกับ serializer อื่น ๆ แต่ถ้าเลือกตัวเลือก UTF16 จะมีลักษณะแตกต่างกัน

ในทุกกรณี ถ้าขนาด payload ใหญ่ ควรพิจารณาบีบอัดข้อมูล แนะนำให้ใช้ LZ4, ZStandard และ Brotli

### การบีบอัด (Compression)

MemoryPack มี helper ที่มีประสิทธิภาพสำหรับการบีบอัด [Brotli](https://github.com/google/brotli) ผ่าน [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) และ [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder) โดย `BrotliCompressor` และ `BrotliDecompressor` ของ MemoryPack ได้รับการปรับแต่งสำหรับการทำงานร่วมกับ MemoryPack โดยเฉพาะ

```csharp
using MemoryPack.Compression;

// การบีบอัด (ต้องใช้ using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// ได้ byte[] ที่ถูกบีบอัด
var compressedBytes = compressor.ToArray();

// หรือเขียนไปยัง IBufferWriter<byte> อื่น ๆ (เช่น PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// การคลายบีบอัด (ต้องใช้ using)
using var decompressor = new BrotliDecompressor();

// ได้ ReadOnlySequence<byte> ที่คลายบีบอัดแล้ว จาก ReadOnlySpan<byte> หรือ ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

ทั้ง `BrotliCompressor` และ `BrotliDecompressor` เป็น struct ไม่มีการจัดสรรหน่วยความจำบน heap ข้อมูลที่ถูกบีบอัด/คลายบีบอัดจะถูกเก็บใน memory pool ภายในระหว่าง Serialize/Deserialize ดังนั้นจำเป็นต้องคืนหน่วยความจำ อย่าลืมใช้ `using`

ระดับการบีบอัด (Compression level) มีความสำคัญมาก โดยดีฟอลต์จะตั้งไว้ที่ quality-1 (CompressionLevel.Fastest) ซึ่งแตกต่างจากดีฟอลต์ของ .NET (CompressionLevel.Optimal, quality-4)

Fastest (quality-1) จะมีความเร็วใกล้เคียงกับ [LZ4](https://github.com/lz4/lz4) แต่ quality-4 จะช้ากว่ามาก การเลือกนี้สำคัญมากสำหรับการใช้งาน serializer โปรดระวังเมื่อใช้ `BrotliStream` มาตรฐาน (quality-4 เป็นดีฟอลต์) ทั้งนี้ ความเร็วและขนาดของการบีบอัด/คลายบีบอัดจะต่างกันมากตามข้อมูลที่ใช้ ควรเตรียมข้อมูลให้เหมาะสมกับแอปพลิเคชันของคุณและทดสอบเอง

โปรดทราบว่ามีค่าเสียเวลาแบบหลายเท่าระหว่างการซีเรียลไลซ์แบบไม่บีบอัดของ MemoryPack กับการเพิ่มการบีบอัดของ Brotli

Brotli ยังรองรับใน custom formatter ด้วย `BrotliFormatter` สามารถบีบอัดเฉพาะสมาชิกที่ต้องการได้

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

ซีเรียลไลซ์ชนิดข้อมูลภายนอก
---
หากต้องการซีเรียลไลซ์ชนิดข้อมูลภายนอก สามารถสร้าง custom formatter และลงทะเบียนกับ provider ดูรายละเอียดที่ [Formatter/Provider API](#formatterprovider-api) อย่างไรก็ตาม การสร้าง custom formatter ทำได้ยาก จึงแนะนำให้สร้าง type wrapper ตัวอย่างเช่น หากต้องการซีเรียลไลซ์ชนิดข้อมูลภายนอกชื่อว่า `AnimationCurve`

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

ชนิดข้อมูลที่ต้องการ wrap ต้องเป็น public แต่ไม่ถูกซีเรียลไลซ์ (`MemoryPackIgnore`) ส่วน property ที่ต้องการซีเรียลไลซ์แม้เป็น private สามารถใช้ (`MemoryPackInclude`) ได้ ควรเตรียม constructor สองแบบ โดย constructor ที่ serializer ใช้งานควรเป็นแบบ private

แต่การ wrap ทุกครั้งอาจไม่สะดวก และ struct wrapper ไม่สามารถแทนค่า null ได้ ดังนั้นควรสร้าง custom formatter

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity ไม่รองรับ scoped และ TBufferWriter จึงเปลี่ยน signature เป็น `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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
}
```

สุดท้าย ให้ทำการลงทะเบียน formatter ในขั้นตอนเริ่มต้นของโปรแกรม

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> หมายเหตุ: AnimationCurve ของ Unity สามารถซีเรียลไลซ์ได้โดยค่าเริ่มต้น ดังนั้นจึงไม่จำเป็นต้องใช้ custom formatter สำหรับ AnimationCurve

Packages
---
MemoryPack มีแพ็กเกจดังต่อไปนี้

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` คือไลบรารีหลัก ซึ่งให้การสนับสนุนเต็มรูปแบบสำหรับการซีเรียลไลซ์และดีซีเรียลไลซ์วัตถุแบบไบนารีที่มีประสิทธิภาพสูง โดยขึ้นกับ `MemoryPack.Core` สำหรับไลบรารีพื้นฐานหลัก และ `MemoryPack.Generator` สำหรับการสร้างโค้ด `MemoryPack.Streaming` เพิ่มส่วนขยายสำหรับ [Streaming Serialization](#streaming-serialization)  `MemoryPack.AspNetCoreMvcFormatter` เพิ่ม input/output formatter สำหรับ ASP.NET Core `MemoryPack.UnityShims` เพิ่ม Unity shim types และ formatter สำหรับแชร์ type ระหว่าง .NET และ Unity

TypeScript และ ASP.NET Core Formatter
---
MemoryPack รองรับการสร้างโค้ด TypeScript โดยจะสร้าง class และโค้ดซีเรียลไลซ์จาก C# กล่าวอีกนัยหนึ่ง คุณสามารถแชร์ type กับฝั่ง Browser ได้โดยไม่ต้องใช้ OpenAPI, proto ฯลฯ

การสร้างโค้ดจะถูกรวมอยู่กับ Source Generator โดยตัวเลือกต่อไปนี้ (`MemoryPackGenerator_TypeScriptOutputDirectory`) เป็นการกำหนดไดเรกทอรีเอาต์พุตสำหรับโค้ด TypeScript โค้ด runtime จะถูกสร้างพร้อมกัน ดังนั้นไม่ต้องการ dependency เพิ่มเติม

```xml
<!-- output memorypack TypeScript code ไปยังไดเรกทอรี -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Type ที่เป็น MemoryPackable ของ C# ต้องประกาศ annotation ด้วย `[GenerateTypeScript]`

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

โค้ด runtime และ type ของ TypeScript จะถูกสร้างไว้ในไดเรกทอรีเป้าหมาย

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

โค้ดที่ถูกสร้างจะเป็นดังนี้ โดยมีฟิลด์แบบง่ายและเมธอดแบบ static สำหรับ serialize/serializeArray และ deserialize/deserializeArray

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

คุณสามารถใช้งาน type นี้ได้ตามตัวอย่างต่อไปนี้

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// serialize เป็น Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// deserialize จาก ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

แพ็กเกจ `MemoryPack.AspNetCoreMvcFormatter` จะเพิ่ม input และ output formatter ของ `MemoryPack` สำหรับ ASP.NET Core MVC คุณสามารถเพิ่ม `MemoryPackInputFormatter`, `MemoryPackOutputFormatter` ให้กับ ASP.NET Core MVC ด้วยโค้ดต่อไปนี้

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // หาก checkContentType: true จะสามารถ output ได้หลาย format (JSON/MemoryPack ฯลฯ) ค่าเริ่มต้นคือ false
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

ถ้าคุณเรียกใช้งานจาก HttpClient สามารถตั้งค่า `application/x-memorypack` ไปที่ content-header ได้

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### การแมป Type ของ TypeScript

มีข้อจำกัดบางประการเกี่ยวกับ type ที่สามารถสร้างได้ ในหมู่ primitive นั้น `char` และ `decimal` ไม่รองรับ และ OpenGenerics type ไม่สามารถใช้งานได้

|  C#  |  TypeScript  | คำอธิบาย |
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
| `Guid` |  `string`  | ใน TypeScript จะแทนเป็น string แต่ serialize/deserialize เป็นไบนารี 16 ไบต์
| `DateTime` | `Date` | DateTimeKind จะถูกละเว้น
| `enum` | `const enum` | `long` และ `ulong` เป็น underlying type ไม่รองรับ
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | รองรับทุก type ที่ implement `ICollection<T>` เช่น `List<T>`
| `: ISet<T>` | `Set<T> \| null` | รองรับทุก type ที่ implement `ISet<T>` เช่น `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | รองรับทุก type ที่ implement `IDictionary<K,V>` เช่น `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | รองรับเฉพาะ class เท่านั้น
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` สามารถใช้ได้เฉพาะกับ class และปัจจุบันยังไม่รองรับ struct

### กำหนดนามสกุลไฟล์ import และรูปแบบชื่อสมาชิก

โดยค่าเริ่มต้น MemoryPack จะสร้างนามสกุลไฟล์เป็น `.js` เช่น `import { MemoryPackWriter } from "./MemoryPackWriter.js";` หากคุณต้องการเปลี่ยนนามสกุลอื่นหรือเว้นว่างไว้ ให้ใช้ `MemoryPackGenerator_TypeScriptImportExtension` เพื่อกำหนดค่า
นอกจากนี้ ชื่อสมาชิกจะถูกแปลงเป็น camelCase โดยอัตโนมัติ หากคุณต้องการใช้ชื่อเดิม ให้ตั้งค่า `MemoryPackGenerator_TypeScriptConvertPropertyName` เป็น `false`

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- allows empty -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- default is true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- default is false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` ช่วยให้ annotation nullable ของ C# สะท้อนในโค้ด TypeScript ได้ ค่าเริ่มต้นคือ false ซึ่งจะทำให้ทุกอย่าง nullable

การทำ Streaming Serialization
---
`MemoryPack.Streaming` มี `MemoryPackStreamingSerializer` ซึ่งเพิ่มการรองรับเพิ่มเติมสำหรับการ serialize และ deserialize คอลเลกชันด้วย stream

```csharp
public static class MemoryPackStreamingSerializer
{
    public static async ValueTask SerializeAsync<T>(PipeWriter pipeWriter, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async ValueTask SerializeAsync<T>(Stream stream, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async IAsyncEnumerable<T?> DeserializeAsync<T>(PipeReader pipeReader, int bufferAtLeast = 4096, int readMinimumSize = 8192, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    public static IAsyncEnumerable<T?> DeserializeAsync<T>(Stream stream, int bufferAtLeast = 4096, int readMinimumSize = 8192, CancellationToken cancellationToken = default)
}
```

Formatter/Provider API
---
หากคุณต้องการ implement formatter ด้วยตนเอง ให้สืบทอด `MemoryPackFormatter<T>` และ override เมธอด `Serialize` และ `Deserialize`

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

        // ใช้เมธอด writer
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // ใช้เมธอด reader
    }
}
```
Formatter ที่สร้างขึ้นจะต้องลงทะเบียนกับ `MemoryPackFormatterProvider`

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

หมายเหตุ: `unmanaged struct` (คือ struct ที่ไม่มี reference type ภายใน) ไม่สามารถใช้ custom formatter ได้ จะ serialize memory layout ตาม native เสมอ

MemoryPackWriter/ReaderOptionalState
---
การสร้าง `MemoryPackWriter`/`MemoryPackReader` ต้องใช้ OptionalState ซึ่งเป็น wrapper ของ `MemoryPackSerializerOptions` สามารถสร้างได้จาก `MemoryPackWriterOptionalStatePool`

```csharp
// เมื่อ dispose แล้ว OptionalState จะคืนกลับไปยัง pool
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// สำหรับ Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

การขึ้นกับ target framework
---
MemoryPack มีทั้ง `netstandard2.1` และ `net7.0` แต่ทั้งสองไม่สามารถใช้แทนกันได้ ตัวอย่างเช่น หากใช้ MemoryPackable types ในโปรเจกต์ `netstandard2.1` และนำไปใช้กับโปรเจกต์ `net7.0` จะเกิด runtime exception เช่นนี้

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

เนื่องจาก net7.0 ใช้ static abstract member (`Virtual static method`) ซึ่งไม่รองรับใน netstandard2.1 ดังนั้นพฤติกรรมนี้เป็นไปตามสเปค

โปรเจกต์ .NET 7 ไม่ควรใช้ dll ของ netstandard 2.1 กล่าวอีกนัยหนึ่ง หาก Application เป็น .NET 7 โปรเจกต์ ทุก dependency ที่ใช้ MemoryPack จะต้องรองรับ .NET 7 ด้วย ดังนั้นหากนักพัฒนาไลบรารีมี dependency กับ MemoryPack คุณต้องตั้งค่า dual target framework

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) คือ grpc-dotnet แบบ code-first ที่ใช้ MessagePack แทน protobuf ตอนนี้ MagicOnion รองรับ MemoryPack เป็น serialization layer ผ่านแพ็กเกจ `MagicOnion.Serialization.MemoryPack` (preview) ดูรายละเอียด: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

Unity เวอร์ชันต่ำสุดที่รองรับคือ `2022.3.12f1`

แพ็กเกจหลัก `MemoryPack` มีให้ใน NuGet และสามารถใช้กับ Unity ได้ หากต้องการรองรับ type เฉพาะของ Unity ให้ใช้ MemoryPack.Unity extension เพิ่มเติม

1. ติดตั้ง `MemoryPack` จาก NuGet โดยใช้ [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* เปิดเมนู Window -> Manage NuGet Packages, ค้นหา "MemoryPack" แล้วกด Install
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* หากพบข้อผิดพลาด version conflicts ให้ปิดการตรวจสอบ version validation ที่ Player Settings (Edit -> Project Settings -> Player -> เลื่อนลงแล้วขยาย "Other Settings" จากนั้นยกเลิกเลือก "Assembly Version Validation" ในส่วน "Configuration")

2. ติดตั้งแพ็กเกจ `MemoryPack.Unity` โดยอ้างอิง git URL

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack ใช้ tag เวอร์ชันรูปแบบ *.*.* คุณสามารถระบุเวอร์ชันได้ เช่น #1.0.0 ตัวอย่าง: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


เหมือนเวอร์ชัน .NET โค้ดจะถูกสร้างโดย code generator (`MemoryPack.Generator.dll`) การ implement แบบไม่ใช้ Reflection ก็ช่วยให้ performance ดีที่สุดใน IL2CPP

ดูข้อมูลเพิ่มเติมเกี่ยวกับ Unity และ Source Generator ได้ที่ [เอกสาร Unity](https://docs.unity3d.com/Manual/roslyn-analyzers.html)

Source Generator ได้ถูกใช้โดย Unity อย่างเป็นทางการใน [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) และ [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html) กล่าวคือ มาตรฐานการสร้างโค้ดใน Unity ยุคใหม่

คุณสามารถ serialize ทุก unmanaged type ได้ (เช่น `Vector3`, `Rect`, ฯลฯ) และ class บางตัว (`AnimationCurve`, `Gradient`, `RectOffset`) หากต้องการ serialize type เฉพาะของ Unity อื่นๆ ดูที่หัวข้อ [Serialize external types](#serialize-external-types)

ด้าน performance ใน Unity, MemoryPack เร็วกว่า JsonUtility ประมาณ x3~x10 เท่า

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

หากโค้ดที่แชร์มี type ของ Unity (`Vector2` ฯลฯ) MemoryPack มีแพ็กเกจ `MemoryPack.UnityShims` ให้ใน NuGet

แพ็กเกจ `MemoryPack.UnityShims` ให้ shims สำหรับ struct มาตรฐานของ Unity (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) และ class บางตัว (`AnimationCurve`, `Gradient`, `RectOffset`)

> [!WARNING]
> ขณะนี้ยังมีข้อจำกัดต่อไปนี้สำหรับการใช้งานใน Unity

1. เวอร์ชัน Unity ยังไม่รองรับ CustomFormatter
2. หากใช้ .NET7 ขึ้นไป รูปแบบ binary ของ MemoryPack อาจไม่เข้ากันกับ Unity อย่างสมบูรณ์
    - ปัญหานี้จะเกิดกับ value type ที่ระบุ `[StructLayout(LayoutKind.Auto)]` ไว้ชัดเจน (default ของ struct คือ `LayoutKind.Sequential`) สำหรับ type เหล่านี้ binary ที่ serialize ใน .NET จะไม่สามารถ deserialize ได้ใน Unity และในทางกลับกัน
    - ประเภทที่ได้รับผลกระทบมักจะเป็น
        - `DateTimeOffset`
        - `ValueTuple`
    - ปัจจุบันวิธีแก้ไขง่ายที่สุดคือไม่ใช้ type เหล่านี้

Native AOT
---
น่าเสียดายที่ .NET 7 Native AOT จะ crash (`Generic virtual method pointer lookup failure`) เมื่อใช้ MemoryPack เนื่องจากบั๊กใน runtime ซึ่งจะถูกแก้ไขใน .NET 8 หากใช้ ``Microsoft.DotNet.ILCompiler`` เวอร์ชัน preview จะสามารถแก้ไขใน .NET 7 ได้ โปรดดู [คอมเมนต์ใน issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) สำหรับวิธีการตั้งค่า

สเปค Binary wire format
---
ชนิดของ `T` ที่กำหนดใน `Serialize<T>` และ `Deserialize<T>` เรียกว่า C# schema ฟอร์แมต MemoryPack ไม่ใช่ฟอร์แมตแบบ self-described ดังนั้น deserialize จะต้องใช้ C# schema ที่ตรงกัน ชนิดเหล่านี้จะอยู่ใน binary เป็น internal representation แต่ไม่สามารถระบุชนิดได้หากไม่มี C# schema

Endian ต้องเป็น `Little Endian` อย่างไรก็ตาม implementation ของ C# ที่ใช้เป็น reference ไม่สน endianness ดังนั้นจึงไม่สามารถใช้กับเครื่อง big-endian ได้ แต่คอมพิวเตอร์ยุคใหม่โดยปกติจะเป็น little-endian

มีฟอร์แมตอยู่ 8 ประเภท

* Unmanaged struct
* Object
* Version Tolerant Object
* วัตถุอ้างอิงแบบวนรอบ (Circular Reference Object)
* ทูเพิล (Tuple)
* คอลเลกชัน (Collection)
* สตริง (String)
* ยูเนียน (Union)

### โครงสร้างที่ไม่จัดการ (Unmanaged struct)

โครงสร้างที่ไม่จัดการ คือ struct ของ C# ที่ไม่มีชนิดอ้างอิง (reference types) ภายใน มีข้อจำกัดคล้ายกับ [C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types) การซีเรียลไลซ์จะเก็บข้อมูลตาม layout ของ struct รวมถึงช่องว่าง (padding)

### วัตถุ (Object)

`(byte memberCount, [values...])`

Object มี header เป็น unsigned byte ขนาด 1 ไบต์ แทนจำนวนสมาชิก (`memberCount`) ซึ่งสามารถมีค่าได้ตั้งแต่ `0` ถึง `249` โดย `255` หมายถึง object นี้เป็น `null` ค่า values จะเก็บข้อมูล memorypack ตามจำนวนสมาชิก

### วัตถุที่ทนต่อเวอร์ชัน (Version Tolerant Object)

`(byte memberCount, [varint byte-length-of-values...], [values...])`

Version Tolerant Object จะคล้ายกับ Object แต่มีการเก็บความยาวของ value แต่ละตัวใน header โดยใช้ varint ตามสเปคนี้ ไบต์แรกเป็น sbyte คือ value หรือ typeCode และไบต์ต่อไปคือ value 0 ถึง 127 = unsigned byte value, -1 ถึง -120 = signed byte value, -121 = byte, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long

### วัตถุอ้างอิงแบบวนรอบ (Circular Reference Object)

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

Circular Reference Object จะคล้ายกับ Version Tolerant Object แต่ถ้า memberCount เป็น 250 ค่า varint (unsigned-int32) ถัดไปจะเป็น referenceId หากไม่ใช่ หลัง byte-length-of-values จะเขียน varint referenceId ต่อ

### ทูเพิล (Tuple)

`(values...)`

Tuple คือคอลเลกชันค่าขนาดคงที่ (fixed-size) ที่ไม่อนุญาต null ใน .NET `KeyValuePair<TKey, TValue>` และ `ValueTuple<T,...>` จะถูกซีเรียลไลซ์แบบ Tuple

### คอลเลกชัน (Collection)

`(int length, [values...])`

Collection มี header เป็น integer 4 ไบต์แบบ signed สำหรับบอกจำนวนข้อมูล `-1` หมายถึง `null` values จะเก็บข้อมูล memorypack ตามจำนวน length

### สตริง (String)

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

String มีสองรูปแบบ คือ UTF16 และ UTF8 ถ้า integer 4 ไบต์แรกเป็น `-1` หมายถึง null, `0` หมายถึงว่าง (empty) UTF16 จะเหมือนกับ collection (ซีเรียลไลซ์เป็น `ReadOnlySpan<char>`, ขนาดไบต์ของ utf16-value คือ utf16-length * 2) ถ้า integer แรก <= `-2` ค่า string จะถูกเข้ารหัสแบบ UTF8 โดย utf8-byte-count จะถูกเข้ารหัสในรูปแบบ complement, ใช้ `~utf8-byte-count` เพื่อหาจำนวนไบต์ ถัดไปเป็น utf16-length ซึ่งอาจเป็น `-1` เพื่อแสดงว่าความยาวไม่ทราบแน่ชัด utf8-bytes จะเก็บไบต์ตามจำนวน utf8-byte-count

### ยูเนียน (Union)

`(byte tag, value)`  
`(250, ushort tag, value)`

ไบต์แรกเป็น unsigned byte ใช้เป็น tag สำหรับแยก discriminated value type หรือ flag ค่า `0` ถึง `249` คือ tag, `250` หมายถึง unsigned short ถัดไปคือ tag, `255` หมายถึง union เป็น `null`

License
---
ไลบรารีนี้ได้รับอนุญาตภายใต้ MIT License.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---