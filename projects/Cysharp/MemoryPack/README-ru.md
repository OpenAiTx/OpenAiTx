# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

Экстремально производительный бинарный сериализатор без кодирования для C# и Unity.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> Сравнение с [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/). Замеры производились на машине .NET 7 / Ryzen 9 5950X. Все эти сериализаторы используют метод `IBufferWriter<byte>`, сериализация производилась с помощью `ArrayBufferWriter<byte>` с повторным использованием для исключения измерения копирования буфера.

Для стандартных объектов MemoryPack работает в 10 раз быстрее, а также в 2–5 раз быстрее других бинарных сериализаторов. Для массивов структур MemoryPack еще мощнее — скорость выше в 50–200 раз по сравнению с другими сериализаторами.

MemoryPack — мой четвертый сериализатор. Ранее я создал известные сериализаторы: ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). Причина высокой скорости MemoryPack — это специфичный для C#, оптимизированный бинарный формат и хорошо настроенная реализация, основанная на моем предыдущем опыте. Это совершенно новый дизайн с использованием .NET 7, C# 11 и Incremental Source Generator (также поддерживается .NET Standard 2.1 (.NET 5, 6) и Unity).

Другие сериализаторы выполняют множество операций кодирования, таких как VarInt кодирование, теги, строки и т.д. Формат MemoryPack использует схему нулевого кодирования, при которой копируется как можно больше памяти C#. Zero-encoding похож на FlatBuffers, но не требует специальных типов — целью сериализации MemoryPack является POCO.

Помимо производительности, MemoryPack обладает следующими возможностями.

* Поддержка современных I/O API (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Генерация кода на основе Source Generator, дружественная к Native AOT, без Dynamic CodeGen (IL.Emit)
* API без рефлексии и без generic-параметров
* Десериализация в существующий экземпляр
* Сериализация полиморфизма (Union)
* Ограниченная (быстрая/по умолчанию) и полная поддержка tolerant-сериализации по версиям
* Сериализация циклических ссылок
* Потоковая сериализация на основе PipeWriter/Reader
* Генерация TypeScript-кода и ASP.NET Core Formatter
* Поддержка Unity (2021.3) IL2CPP через .NET Source Generator

Установка
---
Эта библиотека распространяется через NuGet. Для наилучшей производительности рекомендуется использовать `.NET 7`. Минимальное требование — `.NET Standard 2.1`.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

Также редактор кода должен поддерживать Roslyn 4.3.1, например Visual Studio 2022 версии 17.3, .NET SDK 6.0.401. Подробнее см. в документе [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support).

Для Unity требования и процесс установки полностью отличаются. Подробнее см. раздел [Unity](#unity).

Quick Start
---
Определите структуру или класс для сериализации и пометьте его атрибутом `[MemoryPackable]` и ключевым словом `partial`.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

Код для сериализации генерируется функцией C# Source Generator, реализующей интерфейс `IMemoryPackable<T>`. В Visual Studio сгенерированный код можно посмотреть по сочетанию клавиш `Ctrl+K, R` на имени класса, выбрав `*.MemoryPackFormatter.g.cs`.

Для сериализации/десериализации экземпляра объекта вызовите `MemoryPackSerializer.Serialize<T>/Deserialize<T>`.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

Метод `Serialize` поддерживает возврат типа `byte[]`, а также может сериализовать в `IBufferWriter<byte>` или `Stream`. Метод `Deserialize` поддерживает `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` и `Stream`. Также есть версии без generic-параметров.

Поддерживаемые типы из коробки
---
Эти типы могут сериализоваться по умолчанию:

* Примитивы .NET (`byte`, `int`, `bool`, `char`, `double` и т.д.)
* Неуправляемые типы (любой `enum`, любой пользовательский `struct`, не содержащий ссылочных типов)
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
* Неизменяемые коллекции (`ImmutableList<>` и др.) и интерфейсы (`IImmutableList<>` и др.)

Объявление `[MemoryPackable]` для `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` может быть применён к любому `class`, `struct`, `record`, `record struct` и `interface`. Если тип — это `struct` или `record struct`, не содержащий ссылочных типов ([неуправляемые типы C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)), любые дополнительные атрибуты (ignore, include, constructor, callbacks) не используются, сериализация/десериализация происходит напрямую из памяти.

В остальных случаях по умолчанию `[MemoryPackable]` сериализует публичные экземплярные свойства или поля. Можно использовать `[MemoryPackIgnore]` для исключения члена из сериализации, `[MemoryPackInclude]` — чтобы добавить приватный член в сериализацию.

```csharp
[MemoryPackable]
public partial class Sample
{
    // эти члены сериализуются по умолчанию
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // эти члены по умолчанию не сериализуются
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // используйте [MemoryPackIgnore] для исключения публичного члена из сериализации
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // используйте [MemoryPackInclude], чтобы добавить приватный член в сериализацию
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

Генератор кода MemoryPack добавляет информацию о сериализуемых членах в раздел `<remarks />`. Это можно посмотреть, наведя курсор на тип в Intellisense.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

Все члены должны быть сериализуемыми средствами MemoryPack, иначе генератор кода выдаст ошибку.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

В MemoryPack определено 35 диагностических правил (`MEMPACK001` — `MEMPACK035`) для комфортного использования.

Если сериализация типа реализована внешне и зарегистрирована, используйте `[MemoryPackAllowSerialize]` для подавления диагностики.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

Порядок членов **важен**, MemoryPack не сериализует имя члена или другую информацию, вместо этого сериализуя члены в порядке их объявления. Если тип наследуется, сериализация происходит в порядке родитель → потомок. Порядок членов нельзя менять при десериализации. Для эволюции схемы см. раздел [Version tolerant](#version-tolerant).

По умолчанию порядок последовательный, но можно выбрать явное размещение с помощью `[MemoryPackable(SerializeLayout.Explicit)]` и `[MemoryPackOrder()]`.

```csharp
// сериализует Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### Выбор конструктора

MemoryPack поддерживает как конструкторы с параметрами, так и без них. Выбор конструктора происходит по следующим правилам (применяется к классам и структурам):

* Если присутствует `[MemoryPackConstructor]`, он используется.
* Если нет явного конструктора (включая приватный), используется конструктор без параметров.
* Если есть только один конструктор без параметров или с параметрами (включая приватный), он используется.
* Если есть несколько конструкторов, атрибут `[MemoryPackConstructor]` должен быть применён к нужному (генератор не выберет автоматически), иначе будет ошибка.
* При использовании конструктора с параметрами, все имена параметров должны совпадать с именами членов (без учета регистра).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // Можно использовать конструктор с параметрами — имена параметров должны совпадать с именами членов (без учета регистра)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// также поддерживается record с primary-конструктором
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
// Если существует несколько конструкторов, то следует использовать [MemoryPackConstructor]
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### Колбэки сериализации

При сериализации/десериализации MemoryPack может вызывать события до/после процесса с помощью атрибутов `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]`. Эти атрибуты можно применять как к статическим, так и к экземплярным (нестатическим) методам, а также к публичным и приватным методам.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // порядок вызова методов: static -> instance
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // также допускается приватный метод
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

    // Примечание: экземплярный метод с MemoryPackOnDeserializing не вызывается, если экземпляр не передан через `ref`
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

Колбэки поддерживают методы без параметров и методы с параметрами `ref reader/writer, ref T value`. Например, колбэки с ref могут записывать/читать пользовательский заголовок перед процессом сериализации.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, используйте where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // записываем GUID в заголовок.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // читаем пользовательский заголовок перед десериализацией
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

Если присвоить значение переменной `ref value`, можно изменить значение, используемое для сериализации/десериализации. Например, создать экземпляр через ServiceProvider.

```csharp
// перед использованием этого форматтера, установите ServiceProvider
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

Определение пользовательской коллекции
---
По умолчанию, тип с аннотацией `[MemoryPackObject]` пытается сериализовать свои члены. Однако если тип является коллекцией (`ICollection<>`, `ISet<>`, `IDictionary<,>`), используйте `GenerateType.Collection` для корректной сериализации.

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

Статический конструктор
---
Класс с MemoryPackable не может определять статический конструктор, потому что генерируемый partial-класс использует его. Вместо этого можно определить метод `static partial void StaticConstructor()` для выполнения той же задачи.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Полиморфизм (Union)
---
MemoryPack поддерживает сериализацию объектов интерфейсов и абстрактных классов для полиморфной сериализации. В MemoryPack эта функция называется Union. Только интерфейсы и абстрактные классы допускается аннотировать атрибутами `[MemoryPackUnion]`. Требуются уникальные теги union.

```csharp
// Аннотируйте [MemoryPackable] и типы-наследники с помощью [MemoryPackUnion]
// Union также поддерживает абстрактные классы
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

// Сериализация как интерфейсного типа.
var bin = MemoryPackSerializer.Serialize(data);

// Десериализация как интерфейсного типа.
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

`tag` допускает значения от `0` до `65535`, особенно эффективно использовать значения меньше `250`.
```
Если интерфейс и производные типы находятся в разных сборках, вместо этого можно использовать `MemoryPackUnionFormatterAttribute`. Форматтеры генерируются таким образом, что они автоматически регистрируются через `ModuleInitializer` в C# 9.0 и выше.

> Обратите внимание, что `ModuleInitializer` не поддерживается в Unity, поэтому форматтер необходимо регистрировать вручную. Для регистрации вашего union форматтера вызовите `{имя вашего union форматтера}Initializer.RegisterFormatter()` вручную при запуске. Например, `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB определяет объявление вне целевого типа
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Union можно собрать в коде через `DynamicUnionFormatter<T>`.

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
У `Serialize` есть три перегрузки.

```csharp
// Также доступен не-генерик API, в этих версиях первый аргумент — Type, а value — object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

Для повышения производительности рекомендуется использовать API с `BufferWriter`. Это сериализует данные напрямую в буфер. Может быть применено к `PipeWriter` из `System.IO.Pipelines`, `BodyWriter` в ASP .NET Core и т.д.

Если требуется `byte[]` (например, `RedisValue` в [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)), возвращаемый API `byte[]` прост и почти так же быстр.

Обратите внимание, что `SerializeAsync` для `Stream` асинхронен только для Flush; он сериализует всё сразу во внутренний пул буфера MemoryPack, а затем записывает с помощью `WriteAsync`. Поэтому перегрузка с `BufferWriter`, которая разделяет и управляет буфером и flush, предпочтительнее.

Если вы хотите полностью потоковую запись, смотрите раздел [Streaming Serialization](#streaming-serialization).

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` настраивает, сериализуются ли строки как UTF16 или UTF8. Это можно настроить, передав `MemoryPackSerializerOptions.Utf8` для кодировки UTF8, `MemoryPackSerializerOptions.Utf16` для кодировки UTF16 или `MemoryPackSerializerOptions.Default`, что по умолчанию использует UTF8. Передача null или использование параметра по умолчанию приводит к кодированию в UTF8.

Поскольку внутренняя реализация строки в C# — это UTF16, UTF16 работает быстрее. Однако полезная нагрузка обычно больше; в UTF8 ASCII-строка занимает один байт, а в UTF16 — два байта. Из-за значительной разницы в размере полезной нагрузки по умолчанию используется UTF8.

Если данные не ASCII (например, японский язык, где символ может занимать больше 3 байт, и UTF8 будет больше), или если вы планируете сжимать данные отдельно, UTF16 может дать лучшие результаты.

Хотя при сериализации можно выбрать UTF8 или UTF16, при десериализации указывать это не требуется. Формат будет определён и десериализован автоматически.

Дополнительно вы можете получить/установить `IServiceProvider? ServiceProvider { get; init; }` через опции. Это полезно для получения DI-объектов (например, `ILogger<T>`) из процесса сериализации (`MemoryPackReader/MemoryPackWriter` имеют свойство .Options).

Deserialize API
---
У `Deserialize` есть перегрузки для `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`, `Stream` и поддержка `ref`.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

Перегрузка с `ref` перезаписывает существующий экземпляр, подробности смотрите в разделе [Overwrite](#overwrite).

`DeserializeAsync(Stream)` — это не полностью потоковая операция чтения: сначала он читает во внутренний пул MemoryPack до конца потока, затем десериализует.

Если вы хотите полностью потоковую операцию чтения, смотрите раздел [Streaming Serialization](#streaming-serialization).

Overwrite
---
Для уменьшения количества аллокаций MemoryPack поддерживает десериализацию в существующий экземпляр, перезаписывая его. Это можно использовать с перегрузкой `Deserialize(ref T? value)`.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// перезаписать данные в существующий экземпляр.
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack попытается перезаписать как можно больше, но если не совпадают следующие условия, будет создан новый экземпляр (как при обычной десериализации):

* ref значение (включая члены объектного графа) равно null — создать новый экземпляр
* допускается только конструктор без параметров, если используется конструктор с параметрами — создать новый экземпляр
* если значение — `T[]`, переиспользовать только если длина совпадает, иначе создать новый экземпляр
* если значение — коллекция с методом `.Clear()` (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) — вызвать Clear() и переиспользовать, иначе создать новый экземпляр

Version tolerant
---
По умолчанию (`GenerateType.Object`) MemoryPack поддерживает ограниченную эволюцию схемы.

* unmanaged struct больше нельзя изменять
* можно добавлять члены, но нельзя удалять
* можно менять имя члена
* нельзя менять порядок членов
* нельзя менять тип члена

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Добавлять можно.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Удалять нельзя.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Менять порядок нельзя.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

В реальных сценариях — хранить старые данные (в файл, в redis и т.д.) и читать их новой схемой всегда допустимо. В RPC-сценарии схема существует и на клиенте, и на сервере, клиент должен быть обновлён раньше сервера. Обновлённый клиент без проблем подключается к старому серверу, но старый клиент не сможет подключиться к новому серверу.


По умолчанию, когда старые данные читаются новой схемой, любые отсутствующие на стороне данных члены инициализируются литералом `default`.
Если вы хотите этого избежать и использовать начальные значения полей/свойств, используйте `[SuppressDefaultInitialization]`.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < если старых данных нет, установить `111`.
    
    public int Prop3 { get; set; } = 222; // < если старых данных нет, установить `default`.
}
```

 `[SuppressDefaultInitialization]` имеет следующие ограничения:
- Нельзя использовать с модификаторами readonly, init-only и required.

Следующий раздел [Serialization info](#serialization-info) показывает, как проверять изменения схемы, например, средствами CI, чтобы предотвратить ошибки.

При использовании `GenerateType.VersionTolerant` поддерживается полная устойчивость к версиям.

* unmanaged struct больше нельзя изменять
* всем членам нужно явно добавить `[MemoryPackOrder]` (кроме случаев с аннотацией `SerializeLayout.Sequential`)
* члены можно добавлять и удалять, но нельзя переиспользовать порядок (можно использовать пропущенные номера)
* можно менять имя члена
* нельзя менять порядок членов
* нельзя менять тип члена

```csharp
// Допустимо сериализовать/десериализовать оба варианта
// VersionTolerantObject1 -> VersionTolerantObject2 и 
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

// удалено
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// добавлено
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// Если явно установить SerializeLayout.Sequential, члены будут упорядочены автоматически.
// Но в этом режиме нельзя удалять члены для поддержки version-tolerant.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` сериализуется медленнее, чем `GenerateType.Object`. Также размер полезной нагрузки будет немного больше.

Информация о сериализации
----
Вы можете проверить в IntelliSense, какие члены типа сериализуются. Существует опция записи этой информации в файл во время компиляции. Установите `MemoryPackGenerator_SerializationInfoOutputDirectory` следующим образом.

```xml
<!-- вывод информации о сериализации memorypack в директорию -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

В файл будет записана следующая информация.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

Если тип неуправляемый, перед именем типа будет указано `unmanaged`.

```txt
unmanaged FooStruct
---
int x
int y
```

Проверяя различия в этом файле, можно предотвратить опасные изменения схемы. Например, вы можете использовать CI для обнаружения следующих правил

* изменение неуправляемого типа
* изменение порядка членов
* удаление члена

Циклические ссылки
---
MemoryPack также поддерживает циклические ссылки. Это позволяет сериализовать дерево объектов как есть.

```csharp
// чтобы включить циклические ссылки, используйте GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

 Например, [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) код будет выглядеть следующим образом.

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

`GenerateType.CircularReference` имеет те же характеристики, что и version-tolerant. Однако, как дополнительное ограничение, разрешены только конструкторы без параметров. Также отслеживание ссылок на объекты выполняется только для объектов, помеченных `GenerateType.CircularReference`. Если вы хотите отслеживать другие объекты, оберните их.

CustomFormatter
---
Если реализовать `MemoryPackCustomFormatterAttribute<T>` или `MemoryPackCustomFormatterAttribute<TFormatter, T>` (более производительно, но сложнее), вы можете настроить использование собственного форматтера для члена MemoryPackObject.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack предоставляет следующие атрибуты форматирования: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // сериализовать этот член как строку UTF16, это быстрее, чем UTF8, но для ASCII размер больше (а для не-ASCII иногда меньше).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // При десериализации Dictionary инициализируется с StringComparer.OrdinalIgnoreCase.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // Во время десериализации все строки интернируются (см. String.Intern). Если одинаковые значения встречаются многократно, это экономит память.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Для настройки equality comparer для set/dictionary, все встроенные форматтеры имеют перегрузку конструктора с comparer. Вы можете легко создать свои собственные форматтеры с equality-comparer.

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

`BitPackFormatter` сжимает только типы `bool[]`. Обычно `bool[]` сериализуется как 1 байт на значение, однако `BitPackFormatter` сериализует `bool[]` как `BitArray`, сохраняя каждый bool в 1 бите. Используя `BitPackFormatter`, 8 bool-значений становятся 1 байтом вместо 8, что дает 8-кратное уменьшение размера.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` предназначен для `byte[]`, например, вы можете сжать большой payload с помощью Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` предназначен для `string`, сериализует строку (UTF16) в сжатом виде с помощью Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```

`BrotliFormatter<T>` предназначен для любого типа, сериализованные данные сжимаются с помощью Brotli. Если тип является `byte[]` или `string`, для повышения производительности рекомендуется использовать `BrotliFormatter` или `BrotliStringFormatter`.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

Десериализация с использованием пула массивов
---
Для десериализации больших массивов (любого типа `T`) MemoryPack предлагает несколько эффективных методов с использованием пула. Наиболее эффективный способ — использовать функцию [#Overwrite](#overwrite). В частности, `List<T>` всегда переиспользуется.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> переиспользуется, не происходит аллокаций при десериализации.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// для эффективной работы можно получить Span<T> через CollectionsMarshal
var span = CollectionsMarshal.AsSpan(value.Payload);
```

Удобный способ — десериализовать непосредственно в ArrayPool во время десериализации. MemoryPack предоставляет `MemoryPoolFormatter<T>` и `ReadOnlyMemoryPoolFormatter<T>`.

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

    // Код возврата памяти вы должны написать самостоятельно, ниже пример.

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
    // любые действия...
}   // возврат в ArrayPool
```

Производительность
---
Смотрите мою статью в блоге [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

Размер полезной нагрузки и сжатие
---
Размер полезной нагрузки зависит от целевого значения; в отличие от JSON, здесь нет ключей, и это бинарный формат, поэтому размер полезной нагрузки, скорее всего, будет меньше, чем у JSON.

Для форматов с varint-кодированием, таких как MessagePack и Protobuf, размер данных в MemoryPack может быть больше, если часто используются int (в MemoryPack int всегда 4 байта из-за фиксированного размера кодирования, в то время как в MessagePack это 1~5 байт).

float и double занимают 4 и 8 байт в MemoryPack, но 5 и 9 байт в MessagePack. Поэтому MemoryPack меньше, например, для массивов Vector3 (float, float, float).

Строки по умолчанию в формате UTF8, что аналогично другим сериализаторам, но если выбран вариант UTF16, это будет другой случай.

В любом случае, если размер полезной нагрузки велик, стоит рассмотреть возможность сжатия. Рекомендуются LZ4, ZStandard и Brotli.

### Сжатие

MemoryPack предоставляет эффективный помощник для сжатия [Brotli](https://github.com/google/brotli) через [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) и [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder). Классы `BrotliCompressor` и `BrotliDecompressor` в MemoryPack обеспечивают сжатие/распаковку, оптимизированные для внутренней работы MemoryPack.

```csharp
using MemoryPack.Compression;

// Сжатие (требуется using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// Получить сжатый byte[]
var compressedBytes = compressor.ToArray();

// Или записать в другой IBufferWriter<byte> (например, PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Распаковка (требуется using)
using var decompressor = new BrotliDecompressor();

// Получить распакованный ReadOnlySequence<byte> из ReadOnlySpan<byte> или ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

Оба класса `BrotliCompressor` и `BrotliDecompressor` являются структурами и не выделяют память в куче. Оба хранят сжатые или распакованные данные во внутреннем пуле памяти для Serialize/Deserialize. Поэтому необходимо освобождать пул памяти, не забывайте использовать `using`.

Уровень сжатия очень важен. По умолчанию установлен quality-1 (CompressionLevel.Fastest), что отличается от значения по умолчанию в .NET (CompressionLevel.Optimal, quality-4).

Fastest (quality-1) по скорости будет близок к [LZ4](https://github.com/lz4/lz4), но quality-4 значительно медленнее. Это было признано критически важным для сценария использования сериализатора. Будьте осторожны при использовании стандартного `BrotliStream` (по умолчанию quality-4). В любом случае, скорость и степень сжатия/распаковки могут существенно отличаться в зависимости от данных. Пожалуйста, подготовьте собственные данные и протестируйте самостоятельно.

Обратите внимание, что между несжатым MemoryPack и MemoryPack с Brotli существует многократная разница в скорости.

Brotli также поддерживается в пользовательском формате. `BrotliFormatter` может сжимать конкретное поле.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

Сериализация внешних типов
---
Если вы хотите сериализовать внешние типы, вы можете создать собственный форматтер и зарегистрировать его в провайдере, подробнее смотрите [Formatter/Provider API](#formatterprovider-api). Однако создание собственного форматтера довольно сложно. Поэтому рекомендуется создать обёрточный тип. Например, если вы хотите сериализовать внешний тип `AnimationCurve`.

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

Тип, который необходимо обернуть, является общедоступным, но исключён из сериализации (`MemoryPackIgnore`). Свойства, которые вы хотите сериализовать, приватные, но включены (`MemoryPackInclude`). Также должны быть подготовлены два варианта конструкторов. Конструктор, используемый сериализатором, должен быть приватным.

В текущем виде требуется оборачивать каждый раз, что неудобно. Кроме того, обёртка-структура не может представлять null. Поэтому создадим пользовательский форматтер.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity не поддерживает scoped и TBufferWriter, поэтому измените сигнатуру на `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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

Наконец, зарегистрируйте форматтер при запуске.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> Примечание: Unity's AnimationCurve может сериализоваться по умолчанию, поэтому этот пользовательский форматтер для AnimationCurve не требуется

Пакеты
---
MemoryPack включает следующие пакеты.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` — это основная библиотека, предоставляющая полную поддержку высокопроизводительной сериализации и десериализации бинарных объектов. Она зависит от `MemoryPack.Core` для базовых библиотек и от `MemoryPack.Generator` для генерации кода. `MemoryPack.Streaming` добавляет дополнительные расширения для [потоковой сериализации](#streaming-serialization).  `MemoryPack.AspNetCoreMvcFormatter` добавляет форматтеры ввода/вывода для ASP.NET Core. `MemoryPack.UnityShims` добавляет типы-шимы и форматтеры для совместного использования типов между .NET и Unity.

TypeScript и ASP.NET Core Formatter
---
MemoryPack поддерживает генерацию кода TypeScript. Он генерирует класс и код сериализации из C#, другими словами, вы можете делиться типами с браузером без использования OpenAPI, proto и т.д.

Генерация кода интегрирована с Source Generator, следующие опции (`MemoryPackGenerator_TypeScriptOutputDirectory`) задают директорию вывода для кода TypeScript. Код рантайма выводится одновременно, поэтому дополнительные зависимости не требуются.

```xml
<!-- вывод кода memorypack TypeScript в директорию -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Тип C# MemoryPackable должен быть аннотирован атрибутом `[GenerateTypeScript]`.

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

Код рантайма и типы TypeScript будут сгенерированы в целевой директории.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

Сгенерированный код выглядит следующим образом, с простыми полями и статическими методами для serialize/serializeArray и deserialize/deserializeArray.

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

Вы можете использовать этот тип следующим образом.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// сериализация в Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// десериализация из ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

Пакет `MemoryPack.AspNetCoreMvcFormatter` добавляет входные и выходные форматтеры `MemoryPack` для ASP.NET Core MVC. Вы можете добавить `MemoryPackInputFormatter`, `MemoryPackOutputFormatter` в ASP.NET Core MVC следующим образом.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // Если checkContentType: true, то можно выводить несколько форматов (JSON/MemoryPack и др.). По умолчанию false.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

Если вы вызываете из HttpClient, вы можете установить `application/x-memorypack` в заголовке Content-Type.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### Сопоставление типов TypeScript

Существует несколько ограничений на типы, которые могут быть сгенерированы. Среди примитивов не поддерживаются `char` и `decimal`. Также нельзя использовать типы OpenGenerics.

|  C#  |  TypeScript  | Описание |
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
| `Guid` |  `string`  | В TypeScript представлен как строка, но сериализуется/десериализуется как 16-байтовое бинарное значение
| `DateTime` | `Date` | DateTimeKind будет проигнорирован
| `enum` | `const enum` | Не поддерживается базовый тип `long` и `ulong`
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | Поддерживаются все типы, реализующие `ICollection<T>`, такие как `List<T>`
| `: ISet<T>` | `Set<T> \| null` | Поддерживаются все типы, реализующие `ISet<T>`, такие как `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | Поддерживаются все типы, реализующие `IDictionary<K,V>`, такие как `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | Поддерживаются только классы
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` может быть применён только к классам и в настоящее время не поддерживается для структур.

### Настройка расширения импортируемого файла и регистра имен членов

По умолчанию MemoryPack генерирует расширение файла как `.js`, например: `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. Если вы хотите изменить расширение или сделать его пустым, используйте параметр `MemoryPackGenerator_TypeScriptImportExtension`.
Также имена членов автоматически преобразуются в camelCase. Если вы хотите использовать исходное имя, установите `MemoryPackGenerator_TypeScriptConvertPropertyName` в `false`.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- допускается пустое значение -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- значение по умолчанию true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- значение по умолчанию false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` позволяет аннотациям nullable C# отображаться в TypeScript-коде. По умолчанию false, делая все nullable.

Сериализация потоков
---
`MemoryPack.Streaming` предоставляет `MemoryPackStreamingSerializer`, который добавляет дополнительную поддержку сериализации и десериализации коллекций с использованием потоков.

```csharp
public static class MemoryPackStreamingSerializer
{
    public static async ValueTask SerializeAsync<T>(PipeWriter pipeWriter, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async ValueTask SerializeAsync<T>(Stream stream, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async IAsyncEnumerable<T?> DeserializeAsync<T>(PipeReader pipeReader, int bufferAtLeast = 4096, int readMinimumSize = 8192, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    public static IAsyncEnumerable<T?> DeserializeAsync<T>(Stream stream, int bufferAtLeast = 4096, int readMinimumSize = 8192, CancellationToken cancellationToken = default)
}
```

API Форматтер/Провайдер
---
Если вы хотите реализовать форматтер вручную, наследуйте `MemoryPackFormatter<T>` и переопределите методы `Serialize` и `Deserialize`.

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

        // используйте методы writer.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // используйте методы reader.
    }
}
```
Созданный форматтер регистрируется с помощью `MemoryPackFormatterProvider`.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

Примечание: `unmanged struct` (не содержит ссылочных типов) не может использовать пользовательский форматтер, всегда сериализуется в нативном формате памяти.

MemoryPackWriter/ReaderOptionalState
---
Инициализация `MemoryPackWriter`/`MemoryPackReader` требует OptionalState. Это обёртка над `MemoryPackSerializerOptions`, которую можно создать из `MemoryPackWriterOptionalStatePool`.

```csharp
// при освобождении, OptionalState возвращается в пул.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// для Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

Зависимость от целевого фреймворка
---
MemoryPack предоставляет `netstandard2.1` и `net7.0`, но они не совместимы между собой. Например, если типы MemoryPackable определены в проекте `netstandard2.1` и используются из проекта `net7.0`, будет выброшено исключение времени выполнения, подобное этому:

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

Поскольку в net7.0 используются статические абстрактные члены (`Virtual static method`), которые не поддерживаются в netstandard2.1, такое поведение является спецификацией.

Проект .NET 7 не должен использовать dll для netstandard 2.1. Другими словами, если приложение – это проект .NET 7, все зависимости, использующие MemoryPack, должны поддерживать .NET 7. Поэтому, если библиотека зависит от MemoryPack, необходимо настроить поддержку двух целевых фреймворков.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) — это grpc-dotnet-фреймворк с подходом code-first, использующий MessagePack вместо protobuf. MagicOnion теперь поддерживает MemoryPack как слой сериализации через пакет `MagicOnion.Serialization.MemoryPack` (preview). Подробнее: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

Минимально поддерживаемая версия Unity — `2022.3.12f1`.

Базовый пакет `MemoryPack` предоставляется через nuget. Он также доступен в Unity. Для поддержки встроенных типов Unity мы дополнительно предоставляем расширение MemoryPack.Unity.

1. Установите `MemoryPack` из NuGet с помощью [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* Откройте окно NuGet -> Manage NuGet Packages, найдите "MemoryPack" и нажмите Install.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* Если возникла ошибка конфликта версий, отключите проверку версии в Player Settings (Edit -> Project Settings -> Player -> прокрутите вниз и разверните "Other Settings", затем снимите "Assembly Version Validation" в разделе "Configuration").

2. Установите пакет `MemoryPack.Unity`, добавив ссылку на git URL

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack использует релизные теги *.*.*, поэтому вы можете указать версию как #1.0.0. Например: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


Как и в .NET-версии, код генерируется генератором кода (`MemoryPack.Generator.dll`). Реализация без рефлексии также обеспечивает наилучшую производительность в IL2CPP.

Для получения дополнительной информации об Unity и Source Generator обратитесь к [документации Unity](https://docs.unity3d.com/Manual/roslyn-analyzers.html).

Source Generator также официально используется в Unity пакетами [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) и [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html). Другими словами, это стандарт для генерации кода в следующем поколении Unity.

Вы можете сериализовать все unmanaged-типы (такие как `Vector3`, `Rect` и т.д.) и некоторые классы (`AnimationCurve`, `Gradient`, `RectOffset`). Если вы хотите сериализовать другие Unity-специфические типы, смотрите раздел [Serialize external types](#serialize-external-types).

По производительности в Unity MemoryPack быстрее JsonUtility в 3-10 раз.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

Если в общем коде используются типы Unity (`Vector2` и т.д.), MemoryPack предоставляет пакет `MemoryPack.UnityShims` в NuGet.

Пакет `MemoryPack.UnityShims` предоставляет заглушки для стандартных структур Unity (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) и некоторых классов (`AnimationCurve`, `Gradient`, `RectOffset`).

> [!WARNING]
> В настоящее время существуют следующие ограничения для использования в Unity

1. Версия для Unity не поддерживает CustomFormatter.
2. Если вы используете .NET7 или новее, бинарный формат MemoryPack полностью не совместим с Unity.
    - Эта проблема возникает для value-типов, у которых явно указан `[StructLayout(LayoutKind.Auto)]`. (По умолчанию для struct используется `LayoutKind.Sequencil`.) Для таких типов бинарные данные, сериализованные в .NET, не могут быть десериализованы в Unity. Аналогично, бинарные данные, сериализованные в Unity, не могут быть сериализованы на .NET стороне.
    - Обычно это касается следующих типов:
        - `DateTimeOffset`
        - `ValueTuple`
    - На данный момент простое решение — не использовать эти типы.

Native AOT
---
К сожалению, .NET 7 Native AOT вызывает сбой (`Generic virtual method pointer lookup failure`) при использовании MemoryPack из-за бага рантайма. 
Он будет исправлен в .NET 8. Использование ``Microsoft.DotNet.ILCompiler`` preview-версии решает проблему в .NET 7. Подробнее о настройке смотрите в [комментарии к issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611).

Спецификация бинарного wire-формата
---
Тип `T`, определённый в `Serialize<T>` и `Deserialize<T>`, называется C# схемой. Формат MemoryPack не является самоописательным. Для десериализации требуется соответствующая C# схема. Эти типы существуют как внутренние представления бинарных данных, но без C# схемы типы определить невозможно.

Порядок байт должен быть `Little Endian`. Однако эталонная реализация на C# не учитывает порядок байт, поэтому не может использоваться на big-endian машине. Однако современные компьютеры обычно используют little-endian.

Существует восемь типов форматов.

* Unmanaged struct
* Object
* Version Tolerant Object
* Circular Reference Object
* Tuple
* Collection
* String
* Union

### Unmanaged struct

Unmanaged struct — это структура C# без ссылочных типов, с аналогичным ограничением как у [неуправляемых типов C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types). Сериализация происходит согласно расположению структуры в памяти, включая паддинг.

### Object

`(byte memberCount, [values...])`

Объект содержит 1 байт (unsigned byte) в заголовке как количество членов. Количество членов допускает значения от `0` до `249`, `255` означает, что объект равен `null`. Values содержит значения memorypack для количества членов.

### Version Tolerant Object

`(byte memberCount, [varint byte-length-of-values...], [values...])`

Version Tolerant Object похож на Object, но содержит длины значений в заголовке. varint следует этим спецификациям: первый sbyte — это значение или typeCode, следующие X байт — это значение. 0 до 127 = unsigned byte value, -1 до -120 = signed byte value, -121 = byte, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long.

### Circular Reference Object

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

Circular Reference Object похож на Version Tolerant Object, но если memberCount равен 250, следующий varint(unsigned-int32) — это referenceId. Если нет, после byte-length-of-values записывается varint referenceId.

### Tuple

`(values...)`

Tuple — это коллекция значений фиксированного размера, не допускающая null. В .NET, `KeyValuePair<TKey, TValue>` и `ValueTuple<T,...>` сериализуются как Tuple.

### Collection

`(int length, [values...])`

Collection содержит 4-байтовое знаковое целое число в заголовке как количество данных, `-1` обозначает `null`. Values содержит значения memorypack для количества length.

### String

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

String имеет две формы: UTF16 и UTF8. Если первое 4-байтовое знаковое целое равно `-1`, это означает null. `0` — пустая строка. UTF16 аналогичен коллекции (сериализуется как `ReadOnlySpan<char>`, размер в байтах равен utf16-length * 2). Если первое знаковое целое <= `-2`, значение закодировано в UTF8. utf8-byte-count кодируется в дополнительном коде, `~utf8-byte-count` для получения количества байт. Следующее знаковое целое — utf16-length, допускается `-1`, что означает неизвестную длину. utf8-bytes содержит байты на количество utf8-byte-count.

### Union

`(byte tag, value)`  
`(250, ushort tag, value)`

Первый unsigned byte — это tag для дискриминируемого типа значения или флага, `0` до `249` — это tag, `250` означает, что следующий unsigned short — это tag, `255` означает, что union равен `null`.

License
---
Эта библиотека лицензируется по лицензии MIT.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---