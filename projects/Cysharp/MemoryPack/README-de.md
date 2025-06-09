# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

Zero-Encoding-Binärserialisierer mit extremer Performance für C# und Unity.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> Verglichen mit [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/). Gemessen mit .NET 7 / Ryzen 9 5950X Maschine. Diese Serialisierer haben eine `IBufferWriter<byte>`-Methode, serialisiert mit `ArrayBufferWriter<byte>` und wiederverwendet, um das Messen von Buffer-Kopien zu vermeiden.

Für Standardobjekte ist MemoryPack x10 schneller und x2 ~ x5 schneller als andere Binärserialisierer. Für Struct-Arrays ist MemoryPack noch leistungsfähiger, mit Geschwindigkeiten von bis zu x50 ~ x200 im Vergleich zu anderen Serialisierern.

MemoryPack ist mein vierter Serialisierer. Zuvor habe ich bekannte Serialisierer wie ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp) entwickelt. Der Grund für die Geschwindigkeit von MemoryPack ist sein C#-spezifisches, für C# optimiertes Binärformat und eine gut abgestimmte Implementierung basierend auf meinen bisherigen Erfahrungen. Es ist zudem ein komplett neues Design, das .NET 7, C# 11 und den Incremental Source Generator nutzt (.NET Standard 2.1 (.NET 5, 6) und es gibt auch Unity-Unterstützung).

Andere Serialisierer führen viele Kodierungsoperationen wie VarInt-Kodierung, Tag, String usw. durch. Das MemoryPack-Format verwendet ein Zero-Encoding-Design, das so viel C#-Speicher wie möglich kopiert. Zero-Encoding ist ähnlich wie FlatBuffers, benötigt jedoch keinen speziellen Typ. Das Serialisierungsziel von MemoryPack ist POCO.

Abgesehen von der Performance bietet MemoryPack folgende Funktionen:

* Unterstützung moderner I/O-APIs (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Native AOT-freundliche Codegenerierung via Source Generator, keine dynamische Codegenerierung (IL.Emit)
* Reflektionsfreie, nicht-generische APIs
* Deserialisierung in bestehende Instanzen
* Polymorphe (Union) Serialisierung
* Eingeschränkte versionstolerante (schnell/Standard) und vollständige versionstolerante Unterstützung
* Serialisierung von zirkulären Referenzen
* Streaming-Serialisierung auf Basis von PipeWriter/Reader
* TypeScript-Codegenerierung und ASP.NET Core Formatter
* Unity (2021.3) IL2CPP-Unterstützung via .NET Source Generator

Installation
---
Diese Bibliothek wird über NuGet verteilt. Für beste Performance wird `.NET 7` empfohlen. Mindestvoraussetzung ist `.NET Standard 2.1`.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

Außerdem benötigt ein Code-Editor Roslyn 4.3.1-Unterstützung, z. B. Visual Studio 2022 Version 17.3, .NET SDK 6.0.401. Weitere Details finden Sie im Dokument zur [Roslyn-Version-Unterstützung](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support).

Für Unity sind Anforderungen und Installationsprozess völlig unterschiedlich. Details finden Sie im Abschnitt [Unity](#unity).

Schnellstart
---
Definieren Sie eine zu serialisierende Struktur oder Klasse und versehen Sie sie mit dem `[MemoryPackable]`-Attribut sowie dem Schlüsselwort `partial`.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

Der Serialisierungscode wird durch das C# Source Generator Feature generiert, das das Interface `IMemoryPackable<T>` implementiert. In Visual Studio können Sie den generierten Code mit dem Shortcut `Ctrl+K, R` auf den Klassennamen prüfen und `*.MemoryPackFormatter.g.cs` auswählen.

Rufen Sie `MemoryPackSerializer.Serialize<T>/Deserialize<T>` auf, um eine Objektinstanz zu serialisieren/deserialisieren.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

Die `Serialize`-Methode unterstützt als Rückgabetyp `byte[]`, kann aber auch in `IBufferWriter<byte>` oder `Stream` serialisieren. Die `Deserialize`-Methode unterstützt `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` und `Stream`. Es gibt auch nicht-generische Versionen.

Eingebaut unterstützte Typen
---
Diese Typen können standardmäßig serialisiert werden:

* .NET-Primitiven (`byte`, `int`, `bool`, `char`, `double`, usw.)
* Unverwaltete Typen (Beliebiges `enum`, beliebige benutzerdefinierte `struct`, die keine Referenztypen enthalten)
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
* Immutable Collections (`ImmutableList<>` usw.) und Interfaces (`IImmutableList<>` usw.)

Definieren von `[MemoryPackable]` `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` kann auf jede `class`, `struct`, `record`, `record struct` und `interface` angewendet werden. Wenn ein Typ ein `struct` oder `record struct` ist, der keine Referenztypen enthält ([C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)), werden keine weiteren Annotationen (ignore, include, constructor, callbacks) verwendet – die Serialisierung/Deserialisierung erfolgt direkt aus dem Speicher.

Andernfalls serialisiert `[MemoryPackable]` standardmäßig öffentliche Instanz-Properties oder Felder. Sie können `[MemoryPackIgnore]` verwenden, um ein Serialisierungsziel zu entfernen, `[MemoryPackInclude]` hebt ein privates Element zum Serialisierungsziel hervor.

```csharp
[MemoryPackable]
public partial class Sample
{
    // Diese Typen werden standardmäßig serialisiert
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // Diese Typen werden standardmäßig nicht serialisiert
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // Mit [MemoryPackIgnore] kann ein öffentliches Mitglied vom Ziel entfernt werden
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // Mit [MemoryPackInclude] kann ein privates Mitglied zum Serialisierungsziel gemacht werden
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

Der Codegenerator von `MemoryPack` fügt Informationen darüber hinzu, welche Mitglieder serialisiert werden, im Abschnitt `<remarks />`. Dies kann mit einem Mouseover über den Typ via Intellisense angezeigt werden.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

Alle Mitglieder müssen memorypack-serialisierbar sein, andernfalls gibt der Codegenerator einen Fehler aus.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack verfügt über 35 Diagnoseregeln (`MEMPACK001` bis `MEMPACK035`), um den Einsatz komfortabel zu gestalten.

Wenn für einen Zieltyp extern eine MemoryPack-Serialisierung definiert und registriert wurde, verwenden Sie `[MemoryPackAllowSerialize]`, um Diagnosen zu unterdrücken.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

Die Reihenfolge der Mitglieder ist **wichtig**, MemoryPack serialisiert weder den Mitgliedsnamen noch andere Informationen, sondern serialisiert die Felder in der Reihenfolge ihrer Deklaration. Wird ein Typ vererbt, erfolgt die Serialisierung in der Reihenfolge Eltern → Kind. Die Reihenfolge der Mitglieder darf sich für die Deserialisierung nicht ändern. Für Schema-Entwicklung siehe den Abschnitt [Version tolerant](#version-tolerant).

Die Standardreihenfolge ist sequentiell, Sie können jedoch das explizite Layout mit `[MemoryPackable(SerializeLayout.Explicit)]` und `[MemoryPackOrder()]` wählen.

```csharp
// serialisiert Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### Konstruktor-Auswahl

MemoryPack unterstützt sowohl parametrisierte als auch parameterlose Konstruktoren. Die Auswahl des Konstruktors erfolgt nach folgenden Regeln (gilt für Klassen und Strukturen):

* Wenn `[MemoryPackConstructor]` vorhanden ist, wird dieser verwendet.
* Wenn kein expliziter Konstruktor (einschließlich privat) vorhanden ist, wird ein parameterloser verwendet.
* Gibt es einen parameterlosen/parametrisierten Konstruktor (einschließlich privat), wird dieser verwendet.
* Gibt es mehrere Konstruktoren, muss das Attribut `[MemoryPackConstructor]` auf den gewünschten Konstruktor angewendet werden (der Generator wählt keinen automatisch aus), andernfalls gibt der Generator einen Fehler aus.
* Wird ein parametrisierter Konstruktor verwendet, müssen alle Parameternamen mit den entsprechenden Mitgliedsnamen übereinstimmen (Groß-/Kleinschreibung wird ignoriert).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // Sie können einen parametrisierten Konstruktor verwenden – die Parameternamen müssen mit den jeweiligen Mitgliedsnamen übereinstimmen (Groß-/Kleinschreibung wird ignoriert)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// Unterstützung auch für record primary constructor
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
// Wenn es mehrere Konstruktoren gibt, sollte [MemoryPackConstructor] verwendet werden
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### Serialisierungs-Callbacks

Beim Serialisieren/Deserialisieren kann MemoryPack ein Vorher-/Nachher-Ereignis mithilfe der Attribute `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]` auslösen. Es können sowohl statische als auch Instanz- (nicht-statische) Methoden sowie öffentliche und private Methoden annotiert werden.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // Die Reihenfolge der Methodenaufrufe ist: statisch -> Instanz
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // Private Methoden sind ebenfalls erlaubt
    [MemoryPackOnSerializing]
    void OnSerializing2()
    {
        Console.WriteLine(nameof(OnSerializing2));
    }

    // serializing -> /* serialisieren */ -> serialized
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

    // Hinweis: Instanzmethode mit MemoryPackOnDeserializing wird nicht aufgerufen, wenn die Instanz nicht per `ref` übergeben wird
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

Callbacks erlauben parameterlose Methoden und Methoden mit `ref reader/writer, ref T value`. Zum Beispiel können Ref-Callbacks einen benutzerdefinierten Header vor dem Serialisierungsprozess schreiben/lesen.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, verwenden Sie where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // GUID im Header ausgeben.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // Benutzerdefinierten Header vor dem Deserialisieren lesen
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

Wenn Sie einen Wert auf `ref value` setzen, können Sie den Wert ändern, der für die Serialisierung/Deserialisierung verwendet wird. Zum Beispiel eine Instanz aus dem ServiceProvider erstellen.

```csharp
// Vor der Verwendung dieses Formatters ServiceProvider setzen
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

Eigene Collection definieren
---
Standardmäßig versucht ein mit `[MemoryPackObject]` annotierter Typ, seine Mitglieder zu serialisieren. Wenn ein Typ jedoch eine Collection (`ICollection<>`, `ISet<>`, `IDictionary<,>`) ist, verwenden Sie `GenerateType.Collection`, um ihn korrekt zu serialisieren.

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

Statischer Konstruktor
---
Eine MemoryPackable-Klasse kann keinen statischen Konstruktor definieren, da die generierte Partial-Klasse diesen verwendet. Stattdessen können Sie eine `static partial void StaticConstructor()` definieren, um denselben Zweck zu erfüllen.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Polymorphismus (Union)
---
MemoryPack unterstützt das Serialisieren von Interface- und abstrakten Klassenobjekten für Polymorphismus-Serialisierung. In MemoryPack wird dieses Feature als Union bezeichnet. Nur Interfaces und abstrakte Klassen dürfen mit `[MemoryPackUnion]` annotiert werden. Eindeutige Union-Tags sind erforderlich.

```csharp
// [MemoryPackable] und abgeleitete Typen mit [MemoryPackUnion] annotieren
// Union unterstützt auch abstrakte Klassen
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

// Als Interface-Typ serialisieren.
var bin = MemoryPackSerializer.Serialize(data);

// Als Interface-Typ deserialisieren.
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

`tag` erlaubt Werte von `0` bis `65535`, besonders effizient ist es für Werte unter `250`.
```
Wenn sich ein Interface und abgeleitete Typen in verschiedenen Assemblies befinden, können Sie stattdessen `MemoryPackUnionFormatterAttribute` verwenden. Formatter werden so generiert, dass sie automatisch über `ModuleInitializer` in C# 9.0 und höher registriert werden.

> Beachten Sie, dass `ModuleInitializer` in Unity nicht unterstützt wird, daher muss der Formatter manuell registriert werden. Um Ihren Union Formatter zu registrieren, rufen Sie `{Name Ihres Union Formatters}Initializer.RegisterFormatter()` manuell im Startup auf. Zum Beispiel `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB Definition außerhalb des Zieltyps
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Union kann im Code über `DynamicUnionFormatter<T>` zusammengesetzt werden.

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
`Serialize` hat drei Überladungen.

```csharp
// Nicht-generische API ist ebenfalls verfügbar, bei diesen Versionen ist das erste Argument der Typ und der Wert ist object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

Für die Performance wird die Verwendung der `BufferWriter`-API empfohlen. Diese serialisiert direkt in den Puffer. Sie kann auf `PipeWriter` in `System.IO.Pipelines`, `BodyWriter` in ASP .NET Core usw. angewendet werden.

Wenn ein `byte[]` benötigt wird (z. B. `RedisValue` in [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)), ist die Rückgabe-API `byte[]` einfach und fast genauso schnell.

Beachten Sie, dass `SerializeAsync` für `Stream` nur für das Flush asynchron ist; es serialisiert alles auf einmal in den internen Pool-Puffer von MemoryPack und schreibt dann mit `WriteAsync`. Daher ist die `BufferWriter`-Überladung, die Puffer und Flush trennt und steuert, besser geeignet.

Wenn Sie einen vollständigen Streaming-Write durchführen möchten, siehe den Abschnitt [Streaming Serialization](#streaming-serialization).

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` konfiguriert, ob Zeichenfolgen als UTF16 oder UTF8 serialisiert werden. Dies kann konfiguriert werden, indem Sie `MemoryPackSerializerOptions.Utf8` für UTF8-Codierung, `MemoryPackSerializerOptions.Utf16` für UTF16-Codierung oder `MemoryPackSerializerOptions.Default` (Standard: UTF8) übergeben. Wenn null übergeben wird oder der Standardparameter verwendet wird, erfolgt die Codierung in UTF8.

Da die interne Zeichenfolgenrepräsentation von C# UTF16 ist, ist UTF16 in der Leistung besser. Allerdings ist das Payload-Volumen tendenziell größer; in UTF8 ist eine ASCII-Zeichenfolge ein Byte, in UTF16 zwei Bytes. Da der Unterschied in der Größe des Payloads so groß ist, ist UTF8 standardmäßig eingestellt.

Wenn die Daten nicht ASCII sind (z. B. Japanisch, was mehr als 3 Bytes sein kann und UTF8 größer macht), oder Sie sie separat komprimieren müssen, kann UTF16 bessere Ergebnisse liefern.

Während UTF8 oder UTF16 bei der Serialisierung ausgewählt werden kann, ist es bei der Deserialisierung nicht notwendig, dies anzugeben. Es wird automatisch erkannt und normal deserialisiert.

Zusätzlich können Sie `IServiceProvider? ServiceProvider { get; init; }` aus den Optionen abrufen/setzen. Es ist nützlich, um z. B. ein DI-Objekt (`ILogger<T>`) aus dem Serialisierungsprozess zu erhalten (`MemoryPackReader/MemoryPackWriter` hat die Eigenschaft `.Options`).

Deserialize API
---
`Deserialize` unterstützt Überladungen für `ReadOnlySpan<byte>` und `ReadOnlySequence<byte>`, `Stream` sowie `ref`.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

Die `ref`-Überladung überschreibt eine bestehende Instanz, Details siehe im Abschnitt [Overwrite](#overwrite).

`DeserializeAsync(Stream)` ist keine vollständige Streaming-Leseoperation, zunächst wird bis zum Ende des Streams in den internen Pool von MemoryPack gelesen, dann deserialisiert.

Wenn Sie eine vollständige Streaming-Leseoperation durchführen möchten, siehe den Abschnitt [Streaming Serialization](#streaming-serialization).

Overwrite
---
Um Allokationen zu reduzieren, unterstützt MemoryPack das Deserialisieren in eine bestehende Instanz und überschreibt sie. Dies kann mit der Überladung `Deserialize(ref T? value)` verwendet werden.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// Daten in bestehende Instanz überschreiben.
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack versucht, so viel wie möglich zu überschreiben, aber wenn die folgenden Bedingungen nicht erfüllt sind, wird eine neue Instanz erstellt (wie bei normaler Deserialisierung).

* ref-Wert (einschließlich Mitglieder im Objektgraphen) ist null, dann neue Instanz setzen
* erlaubt nur parameterlosen Konstruktor, bei parametrisiertem Konstruktor wird eine neue Instanz erstellt
* wenn der Wert `T[]` ist, wird er nur wiederverwendet, wenn die Länge gleich ist, sonst neue Instanz erstellen
* wenn der Wert eine Collection ist, die eine `.Clear()`-Methode hat (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`), wird Clear() aufgerufen und sie wiederverwendet, sonst neue Instanz erstellen

Versionstolerant
---
Im Standardmodus (`GenerateType.Object`) unterstützt MemoryPack begrenzte Schema-Evolution.

* unmanaged struct kann nicht mehr verändert werden
* Mitglieder können hinzugefügt, aber nicht entfernt werden
* Mitgliedername kann geändert werden
* Reihenfolge der Mitglieder darf nicht geändert werden
* Mitgliedstyp darf nicht geändert werden

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Hinzufügen ist OK.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Entfernen ist NICHT ERLAUBT.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Änderung der Reihenfolge ist NICHT ERLAUBT.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

Im Anwendungsfall ist das Speichern alter Daten (in Datei, Redis usw.) und das Einlesen in ein neues Schema immer in Ordnung. Im RPC-Szenario existiert das Schema sowohl auf Client- als auch auf Serverseite, der Client muss vor dem Server aktualisiert werden. Ein aktualisierter Client kann ohne Probleme mit einem alten Server verbinden, aber ein alter Client kann nicht mit einem neuen Server verbinden.

Standardmäßig werden beim Einlesen alter Daten in ein neues Schema alle Mitglieder, die auf der Datenseite nicht vorhanden sind, mit dem Literal `default` initialisiert.
Wenn Sie dies vermeiden und Initialwerte von Feldern/Properties verwenden möchten, können Sie `[SuppressDefaultInitialization]` verwenden.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < wenn alte Daten fehlen, wird `111` gesetzt.
    
    public int Prop3 { get; set; } = 222; // < wenn alte Daten fehlen, wird `default` gesetzt.
}
```

 `[SuppressDefaultInitialization]` hat folgende Einschränkungen:
- Kann nicht mit readonly, init-only und required Modifier verwendet werden.

Der nächste Abschnitt [Serialization info](#serialization-info) zeigt, wie Sie Schemaänderungen, z. B. per CI, überprüfen können, um Fehler zu vermeiden.

Wenn Sie `GenerateType.VersionTolerant` verwenden, wird vollständige Versionstoleranz unterstützt.

* unmanaged struct kann nicht mehr verändert werden
* alle Mitglieder müssen explizit `[MemoryPackOrder]` haben (außer bei Anmerkung `SerializeLayout.Sequential`)
* Mitglieder können hinzugefügt, entfernt, aber Reihenfolge nicht wiederverwendet werden (fehlende Reihenfolge kann verwendet werden)
* Mitgliedername kann geändert werden
* Reihenfolge der Mitglieder darf nicht geändert werden
* Mitgliedstyp darf nicht geändert werden

```csharp
// Serialisieren/Deserialisieren ist in beide Richtungen möglich: 
// VersionTolerantObject1 -> VersionTolerantObject2 und 
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

// gelöscht
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// hinzugefügt
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// Wenn SerializeLayout.Sequential explizit gesetzt ist, wird die automatische Reihenfolge ermöglicht.
// Allerdings kann kein Mitglied für Versionstoleranz entfernt werden.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` ist beim Serialisieren langsamer als `GenerateType.Object`. Außerdem wird die Payload-Größe leicht größer sein.

Serialisierungsinfo
----
Sie können im Typ mittels IntelliSense prüfen, welche Mitglieder serialisiert werden. Es gibt eine Option, diese Information zur Kompilierzeit in eine Datei zu schreiben. Setzen Sie `MemoryPackGenerator_SerializationInfoOutputDirectory` wie folgt.

```xml
<!-- Ausgabe der MemoryPack-Serialisierungsinfo in ein Verzeichnis -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

Die folgende Information wird in die Datei geschrieben.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

Wenn der Typ unmanaged ist, wird `unmanaged` vor dem Typnamen angezeigt.

```txt
unmanaged FooStruct
---
int x
int y
```

Durch das Überprüfen der Unterschiede in dieser Datei können gefährliche Schemaänderungen verhindert werden. Zum Beispiel könnten Sie CI nutzen, um die folgenden Regeln zu erkennen:

* Änderung eines unmanaged Typs
* Änderung der Mitgliederreihenfolge
* Löschen von Mitgliedern

Zirkuläre Referenzen
---
MemoryPack unterstützt ebenfalls zirkuläre Referenzen. Dies ermöglicht, dass Baumobjekte wie sie sind serialisiert werden.

```csharp
// Um zirkuläre Referenzen zu ermöglichen, verwenden Sie GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

Zum Beispiel wird der [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references)-Code wie folgt aussehen.

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

`GenerateType.CircularReference` hat die gleichen Eigenschaften wie Versionstoleranz. Allerdings gibt es als zusätzliche Einschränkung nur parameterlose Konstruktoren. Außerdem wird das Objekt-Referenz-Tracking nur für Objekte durchgeführt, die mit `GenerateType.CircularReference` markiert sind. Wenn Sie ein anderes Objekt nachverfolgen möchten, kapseln Sie es.

CustomFormatter
---
Wenn Sie `MemoryPackCustomFormatterAttribute<T>` oder `MemoryPackCustomFormatterAttribute<TFormatter, T>` (leistungsfähiger, aber komplexer) implementieren, können Sie einen benutzerdefinierten Formatter für ein Member von MemoryPackObject konfigurieren.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack stellt folgende Formatierungsattribute bereit: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // Serialisiert dieses Member als UTF16 String, ist performanter als UTF8, aber bei ASCII ist die Größe größer (bei nicht-ASCII manchmal kleiner).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // Beim Deserialisieren wird das Dictionary mit StringComparer.OrdinalIgnoreCase initialisiert.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // Beim Deserialisieren werden alle Strings intern gespeichert (siehe: String.Intern). Falls ähnliche Werte wiederholt auftreten, wird Speicher gespart.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Um den EqualityComparer für ein Set/Dictionary zu konfigurieren, besitzen alle eingebauten Formatter einen Konstruktor-Überladung für den Comparer. Sie können einfach eigene EqualityComparer-Formatter erstellen.

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

`BitPackFormatter` komprimiert nur `bool[]`-Typen. `bool[]` wird normalerweise mit 1 Byte pro booleschem Wert serialisiert, aber `BitPackFormatter` serialisiert `bool[]` wie ein `BitArray` und speichert jedes bool als 1 Bit. Mit `BitPackFormatter` werden 8 bools zu 1 Byte, wo sie normalerweise 8 Bytes wären, was zu einer 8x kleineren Größe führt.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` ist für `byte[]`, zum Beispiel können Sie große Payloads mit Brotli komprimieren.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` ist für `string`, serialisiert komprimierte Strings (UTF16) mit Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```
`BrotliFormatter<T>` ist für jeden Typ geeignet; die serialisierten Daten werden durch Brotli komprimiert. Wenn der Typ `byte[]` oder `string` ist, sollten Sie aus Performancegründen `BrotliFormatter` oder `BrotliStringFormatter` verwenden.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

Deserialisierung mit Array-Pooling
---
Um ein großes Array (beliebiges `T`) zu deserialisieren, bietet MemoryPack mehrere effiziente Pooling-Methoden. Die effektivste Methode ist die Verwendung der [#Overwrite](#overwrite)-Funktion. Insbesondere `List<T>` wird immer wiederverwendet.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> wird wiederverwendet, keine Allokation bei der Deserialisierung.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// Für effiziente Operationen kann man Span<T> über CollectionsMarshal erhalten
var span = CollectionsMarshal.AsSpan(value.Payload);
```

Eine bequeme Möglichkeit besteht darin, beim Deserialisieren in einen ArrayPool zu deserialisieren. MemoryPack stellt dafür `MemoryPoolFormatter<T>` und `ReadOnlyMemoryPoolFormatter<T>` zur Verfügung.

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

    // Sie müssen den Rückgabecode selbst schreiben, hier ein Beispiel.

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
    // alles machen...
}   // Rückgabe an ArrayPool
```

Performance
---
Siehe meinen Blog-Artikel: [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

Payload-Größe und Komprimierung
---
Die Payload-Größe hängt vom Zielwert ab; im Gegensatz zu JSON gibt es keine Schlüssel und es handelt sich um ein Binärformat, sodass die Payload-Größe wahrscheinlich kleiner ist als bei JSON.

Bei Formaten mit Varint-Encoding wie MessagePack und Protobuf ist MemoryPack tendenziell größer, wenn viele ints verwendet werden (in MemoryPack sind ints aufgrund des Fixed-Size-Encodings immer 4 Bytes, während sie in MessagePack 1~5 Bytes sind).

float und double sind in MemoryPack 4 bzw. 8 Bytes groß, in MessagePack jedoch 5 bzw. 9 Bytes. Daher ist MemoryPack z.B. bei Vector3 (float, float, float)-Arrays kleiner.

String ist standardmäßig UTF8, was anderen Serialisierern ähnelt, aber wenn die UTF16-Option gewählt wird, ist es von anderer Natur.

In jedem Fall sollte bei großer Payload-Größe eine Komprimierung in Betracht gezogen werden. LZ4, ZStandard und Brotli werden empfohlen.

### Komprimierung

MemoryPack bietet einen effizienten Helfer für [Brotli](https://github.com/google/brotli)-Komprimierung über [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) und [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder). Die `BrotliCompressor` und `BrotliDecompressor` von MemoryPack bieten Komprimierung/Dekomprimierung, die für das interne Verhalten von MemoryPack optimiert ist.

```csharp
using MemoryPack.Compression;

// Komprimierung (benötigt using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// Komprimiertes byte[] erhalten
var compressedBytes = compressor.ToArray();

// Oder in einen anderen IBufferWriter<byte> schreiben (z. B. PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Dekomprimierung (benötigt using)
using var decompressor = new BrotliDecompressor();

// Dekomprimierten ReadOnlySequence<byte> aus ReadOnlySpan<byte> oder ReadOnlySequence<byte> erhalten
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

Sowohl `BrotliCompressor` als auch `BrotliDecompressor` sind structs, sie allokieren keinen Speicher auf dem Heap. Beide speichern komprimierte oder dekomprimierte Daten in einem internen Speicherpool für Serialize/Deserialize. Daher ist es notwendig, das Memory-Pooling freizugeben – denken Sie daran, `using` zu verwenden.

Der Komprimierungsgrad ist sehr wichtig. Der Standardwert ist auf quality-1 (CompressionLevel.Fastest) gesetzt, was sich vom .NET-Standard unterscheidet (CompressionLevel.Optimal, quality-4).

Fastest (quality-1) ist in der Geschwindigkeit nahe an [LZ4](https://github.com/lz4/lz4), aber 4 ist deutlich langsamer. Dies hat sich als kritisch für das Serialisierer-Szenario erwiesen. Seien Sie vorsichtig bei der Verwendung des Standard-`BrotliStream` (quality-4 ist Standard). Komprimierungs-/Dekomprimierungsgeschwindigkeiten und -größen unterscheiden sich je nach Daten erheblich. Bereiten Sie daher die zu verarbeitenden Daten vor und testen Sie selbst.

Beachten Sie, dass es einen mehrfachen Geschwindigkeitseinbruch zwischen MemoryPacks unkomprimierten und Brotli-komprimierten Daten gibt.

Brotli wird auch in einem benutzerdefinierten Formatter unterstützt. Mit `BrotliFormatter` kann ein bestimmtes Member komprimiert werden.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

Externe Typen serialisieren
---
Wenn Sie externe Typen serialisieren möchten, können Sie einen benutzerdefinierten Formatter erstellen und diesen beim Provider registrieren. Details siehe [Formatter/Provider API](#formatterprovider-api). Das Erstellen eines benutzerdefinierten Formatters ist jedoch schwierig. Wir empfehlen daher, einen Wrapper-Typ zu erstellen. Beispiel: Wenn Sie einen externen Typ namens `AnimationCurve` serialisieren möchten.

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

Der zu umschließende Typ ist public, wird aber von der Serialisierung ausgeschlossen (`MemoryPackIgnore`). Die zu serialisierenden Eigenschaften sind privat, werden aber einbezogen (`MemoryPackInclude`). Zwei Konstruktorvarianten sollten ebenfalls vorbereitet werden. Der vom Serializer verwendete Konstruktor sollte privat sein.

So wie es ist, muss bei jeder Verwendung ein Wrapper erstellt werden, was umständlich ist. Außerdem kann ein Struct-Wrapper kein null darstellen. Erstellen wir daher einen benutzerdefinierten Formatter.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity unterstützt weder scoped noch TBufferWriter, daher Signatur ändern zu `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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

Registrieren Sie abschließend den Formatter beim Start.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> Hinweis: Die AnimationCurve von Unity ist standardmäßig serialisierbar, daher wird dieser benutzerdefinierte Formatter für AnimationCurve nicht benötigt.

Pakete
---
MemoryPack umfasst folgende Pakete.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` ist die Hauptbibliothek und bietet vollständige Unterstützung für die hochperformante Serialisierung und Deserialisierung binärer Objekte. Sie hängt von `MemoryPack.Core` für die grundlegenden Basiskomponenten und von `MemoryPack.Generator` für die Codegenerierung ab. `MemoryPack.Streaming` fügt zusätzliche Erweiterungen für [Streaming Serialization](https://raw.githubusercontent.com/Cysharp/MemoryPack/main/#streaming-serialization) hinzu. `MemoryPack.AspNetCoreMvcFormatter` fügt Input/Output-Formatter für ASP.NET Core hinzu. `MemoryPack.UnityShims` stellt Unity-Shim-Typen und Formatter für den gemeinsamen Typenaustausch zwischen .NET und Unity bereit.

TypeScript und ASP.NET Core Formatter
---
MemoryPack unterstützt die Codegenerierung für TypeScript. Es generiert Klassen- und Serialisierungscode aus C#. Anders ausgedrückt: Sie können Typen mit dem Browser teilen, ohne OpenAPI, proto usw. zu verwenden.

Die Codegenerierung ist in den Source Generator integriert. Die folgenden Optionen (`MemoryPackGenerator_TypeScriptOutputDirectory`) legen das Ausgabeverzeichnis für den TypeScript-Code fest. Laufzeitcode wird gleichzeitig ausgegeben, sodass keine zusätzlichen Abhängigkeiten erforderlich sind.

```xml
<!-- gibt den memorypack TypeScript-Code in das Verzeichnis aus -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Ein C#-MemoryPackable-Typ muss mit `[GenerateTypeScript]` annotiert werden.

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

Der Laufzeitcode und der TypeScript-Typ werden im Zielverzeichnis generiert.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

Der generierte Code sieht wie folgt aus, mit einfachen Feldern und statischen Methoden für serialize/serializeArray und deserialize/deserializeArray.

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

Sie können diesen Typ folgendermaßen verwenden.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// serialisieren zu Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// deserialisieren von ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

Das Paket `MemoryPack.AspNetCoreMvcFormatter` fügt `MemoryPack` Input- und Output-Formatter für ASP.NET Core MVC hinzu. Sie können `MemoryPackInputFormatter`, `MemoryPackOutputFormatter` zu ASP.NET Core MVC mit folgendem Code hinzufügen.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // Wenn checkContentType: true, dann können mehrere Formate ausgegeben werden (JSON/MemoryPack, etc...). Standard ist false.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

Wenn Sie von HttpClient aus aufrufen, können Sie `application/x-memorypack` als Content-Header setzen.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### TypeScript-Typzuordnung

Es gibt einige Einschränkungen bei den generierbaren Typen. Unter den primitiven Typen werden `char` und `decimal` nicht unterstützt. Auch OpenGenerics-Typen können nicht verwendet werden.

|  C#  |  TypeScript  | Beschreibung |
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
| `Guid` |  `string`  | In TypeScript, wird als String dargestellt, aber als 16-Byte-Binärwert serialisiert/deserialisiert
| `DateTime` | `Date` | DateTimeKind wird ignoriert
| `enum` | `const enum` | `long` und `ulong` als Basistyp werden nicht unterstützt
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | Unterstützt alle von `ICollection<T>` implementierten Typen wie `List<T>`
| `: ISet<T>` | `Set<T> \| null` | Unterstützt alle von `ISet<T>` implementierten Typen wie `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | Unterstützt alle von `IDictionary<K,V>` implementierten Typen wie `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | Unterstützt nur Klassen
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` kann nur auf Klassen angewendet werden und wird derzeit von Structs nicht unterstützt.

### Import-Dateierweiterung und Membernamen-Konvention konfigurieren

Standardmäßig generiert MemoryPack die Dateierweiterung als `.js`, z. B. `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. Wenn Sie eine andere Erweiterung oder keine Erweiterung wünschen, verwenden Sie `MemoryPackGenerator_TypeScriptImportExtension`, um dies zu konfigurieren.
Auch die Membernamen werden automatisch in camelCase umgewandelt. Wenn Sie den Originalnamen verwenden möchten, setzen Sie `MemoryPackGenerator_TypeScriptConvertPropertyName` auf `false`.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- erlaubt auch leer -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- Standardwert ist true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- Standardwert ist false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` sorgt dafür, dass C# Nullable-Annotationen im TypeScript-Code übernommen werden. Standardmäßig ist dies auf false gesetzt, sodass alles nullable ist.

Streaming-Serialisierung
---
`MemoryPack.Streaming` stellt `MemoryPackStreamingSerializer` bereit, welcher zusätzliche Unterstützung für die Serialisierung und Deserialisierung von Sammlungen mit Streams bietet.

```csharp
public static class MemoryPackStreamingSerializer
{
    public static async ValueTask SerializeAsync<T>(PipeWriter pipeWriter, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async ValueTask SerializeAsync<T>(Stream stream, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async IAsyncEnumerable<T?> DeserializeAsync<T>(PipeReader pipeReader, int bufferAtLeast = 4096, int readMinimumSize = 8192, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    public static IAsyncEnumerable<T?> DeserializeAsync<T>(Stream stream, int bufferAtLeast = 4096, int readMinimumSize = 8192, CancellationToken cancellationToken = default)
}
```

Formatter/Provider-API
---
Wenn Sie einen Formatter manuell implementieren möchten, erben Sie von `MemoryPackFormatter<T>` und überschreiben Sie die Methoden `Serialize` und `Deserialize`.

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

        // Verwenden Sie die Writer-Methoden.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // Verwenden Sie die Reader-Methoden.
    }
}
```
Der erstellte Formatter wird mit `MemoryPackFormatterProvider` registriert.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

Hinweis: `unmanged struct` (enthält keine Referenztypen) kann keinen benutzerdefinierten Formatter verwenden, es wird immer das native Speicherlayout serialisiert.

MemoryPackWriter/ReaderOptionalState
---
Die Initialisierung von `MemoryPackWriter`/`MemoryPackReader` erfordert OptionalState. Dies ist ein Wrapper um `MemoryPackSerializerOptions` und kann aus dem `MemoryPackWriterOptionalStatePool` erstellt werden.

```csharp
// Nach dem Dispose wird OptionalState an den Pool zurückgegeben.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// für Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

Abhängigkeit vom Ziel-Framework
---
MemoryPack stellt `netstandard2.1` und `net7.0` bereit, aber beide sind nicht kompatibel. Wenn Sie z. B. MemoryPackable-Typen unter einem `netstandard2.1`-Projekt verwenden und diese aus einem `net7.0`-Projekt verwenden, wird zur Laufzeit eine Ausnahme wie diese ausgelöst:

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

Da net7.0 statische abstrakte Member (`Virtual static method`) verwendet, die von netstandard2.1 nicht unterstützt werden, ist dieses Verhalten spezifikationsbedingt.

Ein .NET 7-Projekt sollte nicht die netstandard 2.1-dll verwenden. Anders gesagt: Wenn die Anwendung ein .NET 7-Projekt ist, müssen alle Abhängigkeiten, die MemoryPack nutzen, .NET 7 unterstützen. Wenn also ein Bibliotheksentwickler eine Abhängigkeit zu MemoryPack hat, muss das Ziel-Framework dual konfiguriert werden.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) ist ein code-first grpc-dotnet Framework, das MessagePack anstelle von protobuf verwendet. MagicOnion unterstützt jetzt MemoryPack als Serialisierungsschicht über das Paket `MagicOnion.Serialization.MemoryPack` (Preview). Details siehe: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

Die minimal unterstützte Unity-Version ist `2022.3.12f1`.

Das Kernpaket `MemoryPack` wird über NuGet bereitgestellt. Es ist auch in Unity verfügbar. Wenn Sie Unterstützung für Unity-eigene Typen benötigen, stellen wir zusätzlich die Erweiterung MemoryPack.Unity bereit.

1. Installieren Sie `MemoryPack` über NuGet mithilfe von [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* Öffnen Sie das Fenster "NuGet -> Manage NuGet Packages", suchen Sie nach "MemoryPack" und klicken Sie auf Installieren.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* Wenn Sie auf Versionskonflikte stoßen, deaktivieren Sie bitte die Versionsvalidierung in den Player Settings (Edit -> Project Settings -> Player -> Nach unten scrollen und "Other Settings" ausklappen, dann "Assembly Version Validation" unter dem Abschnitt "Configuration" deaktivieren).

2. Installieren Sie das Paket `MemoryPack.Unity` durch Referenzieren der Git-URL

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack verwendet den *.*.* Release-Tag, sodass Sie eine Version wie #1.0.0 angeben können. Beispiel: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


Wie bei der .NET-Version wird der Code durch einen Codegenerator (`MemoryPack.Generator.dll`) generiert. Die reflektionsfreie Implementierung bietet auch unter IL2CPP die beste Performance.

Weitere Informationen zu Unity und Source Generator finden Sie in der [Unity-Dokumentation](https://docs.unity3d.com/Manual/roslyn-analyzers.html).

Source Generator wird auch offiziell von Unity in [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) und [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html) verwendet. Anders ausgedrückt: Es ist der Standard für Codegenerierung in der nächsten Unity-Generation.

Sie können alle nicht verwalteten Typen (wie `Vector3`, `Rect`, etc...) und einige Klassen (`AnimationCurve`, `Gradient`, `RectOffset`) serialisieren. Wenn Sie andere Unity-spezifische Typen serialisieren möchten, siehe Abschnitt [Serialize external types](#serialize-external-types).

In Bezug auf die Performance ist MemoryPack in Unity etwa 3–10 Mal schneller als JsonUtility.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

Wenn gemeinsamer Code Unity-Typen (`Vector2`, etc...) enthält, stellt MemoryPack das NuGet-Paket `MemoryPack.UnityShims` bereit.

Das Paket `MemoryPack.UnityShims` bietet Shims für Unitys Standard-Structs (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) sowie einige Klassen (`AnimationCurve`, `Gradient`, `RectOffset`).

> [!WARNING]
> Aktuell bestehen folgende Einschränkungen bei der Verwendung in Unity


1. Die Unity-Version unterstützt keine CustomFormatter.
2. Wenn Sie .NET7 oder neuer verwenden, ist das MemoryPack-Binärformat nicht vollständig mit Unity kompatibel.
    - Dieses Problem tritt bei Wertetypen auf, bei denen `[StructLayout(LayoutKind.Auto)]` explizit angegeben ist. (Standard für struct ist `LayoutKind.Sequencial`.) Solche Typen können in .NET serialisierte Binärdaten nicht in Unity deserialisieren und umgekehrt.
    - Betroffene Typen sind typischerweise:
        - `DateTimeOffset`
        - `ValueTuple`
    - Die einfache Lösung ist derzeit, diese Typen nicht zu verwenden.


Native AOT
---
Leider führt .NET 7 Native AOT zu einem Absturz (`Generic virtual method pointer lookup failure`) beim Einsatz von MemoryPack aufgrund eines Laufzeitfehlers. 
Dies wird in .NET 8 behoben. Die Verwendung einer Vorschauversion von ``Microsoft.DotNet.ILCompiler`` behebt das Problem auch in .NET 7. Siehe [Kommentar im Issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611), wie man dies einrichtet.

Binäres Drahtformat – Spezifikation
---
Der Typ von `T`, der in `Serialize<T>` und `Deserialize<T>` definiert ist, wird als C#-Schema bezeichnet. Das MemoryPack-Format ist kein selbstbeschreibendes Format. Für das Deserialisieren ist das entsprechende C#-Schema erforderlich. Diese Typen existieren als interne Repräsentation der Binärdaten, können aber ohne C#-Schema nicht bestimmt werden.

Das Endian-Format muss `Little Endian` sein. Die Referenzimplementierung in C# beachtet die Endianness jedoch nicht, daher kann sie nicht auf Big-Endian-Maschinen verwendet werden. Moderne Computer sind jedoch in der Regel Little-Endian.

Es gibt acht Format-Typen:

* Unmanaged struct
* Object
* Version Tolerant Object
* Circular Reference Object
* Tuple
* Collection
* String
* Union

### Unmanaged struct

Unmanaged struct ist eine C#-Struktur, die keine Referenztypen enthält, ähnlich wie die Einschränkung für [C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types). Das Serialisieren erfolgt entsprechend dem Speicherlayout der Struktur, einschließlich Padding.

### Object

`(byte memberCount, [values...])`

Ein Object hat ein 1-Byte großes, unsigniertes Byte als Memberanzahl im Header. Die Memberanzahl erlaubt Werte von `0` bis `249`, `255` bedeutet, dass das Objekt `null` ist. Die Werte speichern die MemoryPack-Werte entsprechend der Anzahl der Member.

### Versionstolerantes Object

`(byte memberCount, [varint byte-length-of-values...], [values...])`

Das versionstolerante Objekt ist ähnlich wie Object, enthält jedoch die Byte-Längen der Werte im Header. Varint folgt dieser Spezifikation: Das erste sbyte ist der Wert oder typeCode, die nächsten X Bytes sind der Wert. 0 bis 127 = unsigned Byte Wert, -1 bis -120 = signed Byte Wert, -121 = Byte, -122 = SByte, -123 = UShort, -124 = Short, -125 = UInt, -126 = Int, -127 = ULong, -128 = Long.

### Circular Reference Object

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

Circular Reference Object ist ähnlich wie das versionstolerante Objekt, aber wenn memberCount 250 ist, folgt als nächstes ein varint (unsigned-int32) als referenceId. Wenn nicht, wird nach den Byte-Längen der Werte eine varint referenceId geschrieben.

### Tuple

`(values...)`

Tuple ist eine festgelegte, nicht-nullbare Wertesammlung. In .NET werden `KeyValuePair<TKey, TValue>` und `ValueTuple<T,...>` als Tuple serialisiert.

### Collection

`(int length, [values...])`

Collection hat einen 4-Byte großen, signierten Integer als Datenanzahl im Header, `-1` bedeutet `null`. Die Werte speichern die MemoryPack-Werte entsprechend der Länge.

### String

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

String hat zwei Formen, UTF16 und UTF8. Wenn der erste 4-Byte große, signierte Integer `-1` ist, bedeutet das null. `0` bedeutet leer. UTF16 ist dasselbe wie Collection (serialisiert als `ReadOnlySpan<char>`, die Byte-Anzahl von utf16-value ist utf16-length * 2). Wenn der erste signed Integer <= `-2` ist, wird der Wert per UTF8 kodiert. utf8-byte-count wird im Komplement kodiert, `~utf8-byte-count` ergibt die Anzahl der Bytes. Der nächste signed Integer ist utf16-length, wobei `-1` eine unbekannte Länge darstellt. utf8-bytes enthalten Bytes entsprechend der Anzahl von utf8-byte-count.

### Union

`(byte tag, value)`  
`(250, ushort tag, value)`

Das erste unsigned Byte ist ein Tag für den unterscheidbaren Werttyp oder ein Flag, `0` bis `249` stehen für das Tag, `250` bedeutet, dass das nächste unsigned Short das Tag ist, `255` bedeutet, dass die Union `null` ist.

Lizenz
---
Diese Bibliothek ist unter der MIT-Lizenz lizenziert.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---