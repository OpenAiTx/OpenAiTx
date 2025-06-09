# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

Ekstremalnie wydajny, binarny serializer C# i Unity bez kodowania (zero encoding).

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> Porównanie z [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/). Pomiar wykonany na .NET 7 / Ryzen 9 5950X. Serializatory te posiadają metodę `IBufferWriter<byte>`, serializacja z użyciem `ArrayBufferWriter<byte>` i ponowne użycie bufora w celu uniknięcia kopiowania podczas pomiaru.

Dla standardowych obiektów, MemoryPack jest x10 szybszy oraz x2 ~ x5 szybszy niż inne binarne serializatory. Dla tablic struktur, MemoryPack jest jeszcze potężniejszy, osiągając prędkość nawet x50 ~ x200 większą niż inne serializatory.

MemoryPack jest moim czwartym serializatorem, wcześniej stworzyłem znane serializatory, ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). Powodem szybkości MemoryPack jest jego specyficzny dla C#, zoptymalizowany pod C# format binarny oraz doskonale dostrojona implementacja oparta na moim wcześniejszym doświadczeniu. Jest to także zupełnie nowy projekt wykorzystujący .NET 7, C# 11 oraz Incremental Source Generator (.NET Standard 2.1 (.NET 5, 6) oraz wsparcie dla Unity).

Inne serializatory wykonują wiele operacji kodowania takich jak kodowanie VarInt, tagi, stringi itd. Format MemoryPack stosuje podejście zero-encoding, kopiując jak najwięcej pamięci C#. Zero-encoding jest podobny do FlatBuffers, jednak nie wymaga specjalnych typów, a celem serializacji MemoryPack są POCO.

Poza wydajnością, MemoryPack oferuje także:

* Wsparcie dla nowoczesnych API I/O (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Natywna, przyjazna AOT generacja kodu oparta na Source Generator, bez Dynamic CodeGen (IL.Emit)
* API bez refleksji i niegenericzne
* Deserializacja do istniejącej instancji
* Serializacja polimorficzna (Union)
* Ograniczona tolerancja wersji (szybka/domyslna) oraz pełna tolerancja wersji
* Serializacja cyklicznych referencji
* Serializacja strumieniowa oparta na PipeWriter/Reader
* Generowanie kodu TypeScript i formatter dla ASP.NET Core
* Wsparcie dla Unity (2021.3) IL2CPP przez .NET Source Generator

Instalacja
---
Biblioteka jest dystrybuowana przez NuGet. Dla najlepszej wydajności zaleca się użycie `.NET 7`. Minimalnym wymaganiem jest `.NET Standard 2.1`.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

Wymagany jest także edytor kodu ze wsparciem dla Roslyn 4.3.1, np. Visual Studio 2022 w wersji 17.3, .NET SDK 6.0.401. Szczegóły w dokumencie [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support).

W przypadku Unity wymagania i proces instalacji są zupełnie inne. Szczegóły w sekcji [Unity](#unity).

Szybki start
---
Zdefiniuj strukturę lub klasę do serializacji i oznacz ją atrybutem `[MemoryPackable]` oraz słowem kluczowym `partial`.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

Kod do serializacji generowany jest przez C# source generator, który implementuje interfejs `IMemoryPackable<T>`. W Visual Studio możesz sprawdzić wygenerowany kod skrótem `Ctrl+K, R` na nazwie klasy i wybrać `*.MemoryPackFormatter.g.cs`.

Wywołaj `MemoryPackSerializer.Serialize<T>/Deserialize<T>`, aby zserializować/deserializować instancję obiektu.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

Metoda `Serialize` obsługuje zwracanie typu `byte[]`, a także potrafi serializować do `IBufferWriter<byte>` lub `Stream`. Metoda `Deserialize` obsługuje `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` oraz `Stream`. Istnieją również wersje niegeneryczne tych metod.

Wspierane typy wbudowane
---
Domyślnie mogą być serializowane następujące typy:

* Typy prymitywne .NET (`byte`, `int`, `bool`, `char`, `double`, itd.)
* Typy niezarządzane (dowolne `enum`, dowolny własny `struct` nie zawierający typów referencyjnych)
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
* Kolekcje niemutowalne (`ImmutableList<>`, itd.) oraz interfejsy (`IImmutableList<>`, itd.)

Definiowanie `[MemoryPackable]` `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` można oznaczyć dowolną `class`, `struct`, `record`, `record struct` oraz `interface`. Jeśli typ to `struct` lub `record struct`, który nie zawiera typów referencyjnych ([C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)), żadne dodatkowe adnotacje (ignore, include, constructor, callbacks) nie są wykorzystywane – serializacja/deserializacja odbywa się bezpośrednio z pamięci.

W przeciwnym przypadku, domyślnie `[MemoryPackable]` serializuje publiczne właściwości instancyjne lub pola. Możesz użyć `[MemoryPackIgnore]`, aby wykluczyć członek z serializacji, a `[MemoryPackInclude]` promuje prywatny człon na cel serializacji.

```csharp
[MemoryPackable]
public partial class Sample
{
    // te typy są domyślnie serializowane
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // te typy nie są serializowane domyślnie
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // użyj [MemoryPackIgnore], aby wykluczyć publiczny człon z serializacji
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // użyj [MemoryPackInclude], aby promować prywatny człon do serializacji
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

Generator kodu `MemoryPack` dodaje informację o tym, które człony są serializowane do sekcji `<remarks />`. Można to podejrzeć najeżdżając na typ w Intellisense.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

Wszystkie człony muszą być serializowalne przez MemoryPack, w przeciwnym razie generator kodu zgłosi błąd.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack posiada 35 reguł diagnostycznych (`MEMPACK001` do `MEMPACK035`), aby ułatwić definiowanie typów.

Jeśli typ docelowy jest definiowany zewnętrznie dla serializacji MemoryPack i jest zarejestrowany, użyj `[MemoryPackAllowSerialize]`, aby wyciszyć diagnostykę.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

Kolejność członów jest **ważna** – MemoryPack nie serializuje nazw członów ani dodatkowych informacji, zamiast tego serializuje pola w kolejności ich zadeklarowania. Jeśli typ jest dziedziczony, serializacja następuje w kolejności rodzic → dziecko. Kolejność członów nie może się zmienić podczas deserializacji. W celu ewolucji schematu, zobacz sekcję [Version tolerant](#version-tolerant).

Domyślna kolejność to sekwencyjna, ale możesz wybrać układ jawny z `[MemoryPackable(SerializeLayout.Explicit)]` i `[MemoryPackOrder()]`.

```csharp
// serializuje Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### Wybór konstruktora

MemoryPack obsługuje zarówno konstruktory z parametrami, jak i bezparametrowe. Wybór konstruktora odbywa się według następujących zasad (dotyczy klas i struktur):

* Jeśli jest `[MemoryPackConstructor]`, użyj go.
* Jeśli nie ma jawnego konstruktora (w tym prywatnego), użyj bezparametrowego.
* Jeśli istnieje tylko jeden konstruktor bezparametrowy/parametryzowany (w tym prywatny), użyj go.
* Jeśli jest wiele konstruktorów, należy oznaczyć żądany konstruktor atrybutem `[MemoryPackConstructor]` (generator nie wybierze automatycznie), w przeciwnym razie generator zgłosi błąd.
* Jeśli używasz konstruktora z parametrami, wszystkie nazwy parametrów muszą odpowiadać nazwom członów (bez rozróżniania wielkości liter).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // Możesz użyć konstruktora z parametrami - nazwy parametrów muszą odpowiadać nazwom członów (bez rozróżniania wielkości liter)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// obsługuje także rekordowy konstruktor główny
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
// Jeśli istnieje wiele konstruktorów, należy użyć [MemoryPackConstructor]
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### Callbacki serializacji

Podczas serializacji/deserializacji, MemoryPack może wywołać zdarzenie przed/po użyciu atrybutów `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]`. Można je oznaczać zarówno dla metod statycznych, jak i instancyjnych (niestatycznych), a także dla metod publicznych i prywatnych.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // kolejność wywołań metod to static -> instance
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // dopuszczalna jest również metoda prywatna
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

    // Uwaga: metoda instancyjna z MemoryPackOnDeserializing nie zostanie wywołana, jeśli instancja nie zostanie przekazana przez `ref`
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

Callbacki pozwalają na metody bezparametrowe oraz metody `ref reader/writer, ref T value`. Przykładowo, callbacki ref mogą zapisywać/odczytywać niestandardowy nagłówek przed procesem serializacji.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, użyj where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // zapisuje GUID w nagłówku.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // odczytuje niestandardowy nagłówek przed deserializacją
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

Jeśli ustawisz wartość w `ref value`, możesz zmienić wartość używaną podczas serializacji/deserializacji. Przykładowo, można zainicjalizować instancję z ServiceProvider.

```csharp
// przed użyciem tego formatera ustaw ServiceProvider
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

Definiowanie własnej kolekcji
---
Domyślnie typ oznaczony `[MemoryPackObject]` próbuje serializować swoje człony. Jednak jeśli typ jest kolekcją (`ICollection<>`, `ISet<>`, `IDictionary<,>`), należy użyć `GenerateType.Collection`, aby poprawnie go serializować.

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

Konstruktor statyczny
---
Klasa MemoryPackable nie może definiować statycznego konstruktora, ponieważ generowana klasa partial go używa. Zamiast tego możesz zdefiniować `static partial void StaticConstructor()`, aby osiągnąć ten sam efekt.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Polimorfizm (Union)
---
MemoryPack obsługuje serializację obiektów interfejsów i klas abstrakcyjnych w celu serializacji polimorficznej. W MemoryPack ta funkcja nazywa się Union. Tylko interfejsy i klasy abstrakcyjne mogą być oznaczane atrybutami `[MemoryPackUnion]`. Wymagane są unikalne tagi union.

```csharp
// Oznacz [MemoryPackable] oraz typy dziedziczące przez [MemoryPackUnion]
// Union obsługuje również klasy abstrakcyjne
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

// Serializacja jako typ interfejsu.
var bin = MemoryPackSerializer.Serialize(data);

// Deserializacja jako typ interfejsu.
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

`tag` pozwala na wartości od `0` do `65535`, szczególnie efektywne są wartości mniejsze niż `250`.
```
Jeśli interfejs i typy pochodne znajdują się w różnych zestawach, możesz zamiast tego użyć `MemoryPackUnionFormatterAttribute`. Formattery są generowane w taki sposób, że są automatycznie rejestrowane za pomocą `ModuleInitializer` w C# 9.0 i nowszych.

> Uwaga: `ModuleInitializer` nie jest obsługiwany w Unity, więc formatter musi zostać zarejestrowany ręcznie. Aby zarejestrować własny union formatter, wywołaj ręcznie `{nazwa twojego union formattera}Initializer.RegisterFormatter()` podczas uruchamiania aplikacji. Na przykład `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB definicja poza typem docelowym
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Unie można zbudować w kodzie za pomocą `DynamicUnionFormatter<T>`.

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
`Serialize` ma trzy przeciążenia.

```csharp
// Dostępne jest również niegeneryczne API, w tej wersji pierwszym argumentem jest Type, a value to object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

Ze względów wydajności zalecane jest API wykorzystujące `BufferWriter`. Serializuje ono bezpośrednio do bufora. Może być stosowane do `PipeWriter` z `System.IO.Pipelines`, `BodyWriter` w ASP .NET Core, itd.

Jeśli wymagane jest `byte[]` (np. `RedisValue` w [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)), API zwracające `byte[]` jest proste i niemal tak szybkie.

Należy pamiętać, że `SerializeAsync` dla `Stream` jest asynchroniczne tylko podczas Flush; całość jest serializowana jednorazowo do wewnętrznego bufora MemoryPack, a następnie zapisywana za pomocą `WriteAsync`. Dlatego przeciążenie z `BufferWriter`, które oddziela i kontroluje bufor oraz flush, jest lepsze.

Jeśli chcesz wykonać pełne, strumieniowe zapisanie, zobacz sekcję [Streaming Serialization](#streaming-serialization).

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` konfiguruje, czy ciągi znaków są serializowane jako UTF16, czy UTF8. Można to skonfigurować, przekazując `MemoryPackSerializerOptions.Utf8` dla kodowania UTF8, `MemoryPackSerializerOptions.Utf16` dla UTF16 lub `MemoryPackSerializerOptions.Default`, które domyślnie ustawia UTF8. Przekazanie null lub użycie parametru domyślnego skutkuje kodowaniem UTF8.

Ponieważ wewnętrzna reprezentacja stringów w C# to UTF16, UTF16 jest bardziej wydajne. Jednak rozmiar danych może być większy; w UTF8 ciąg ASCII to jeden bajt, podczas gdy w UTF16 to dwa bajty. Ponieważ różnica w rozmiarze danych może być znaczna, domyślnie ustawione jest UTF8.

Jeśli dane są nie-ASCII (np. japoński, który może zajmować więcej niż 3 bajty i UTF8 jest większe), lub jeśli musisz kompresować je osobno, lepsze wyniki może dać UTF16.

Podczas serializacji można wybrać UTF8 lub UTF16, nie trzeba tego jednak określać przy deserializacji. Zostanie to wykryte automatycznie i zdeserializowane prawidłowo.

Dodatkowo możesz pobrać/ustawić `IServiceProvider? ServiceProvider { get; init; }` z opcji. Przydatne do pobierania obiektu DI (np. `ILogger<T>`) w trakcie procesu serializacji (`MemoryPackReader/MemoryPackWriter` posiadają właściwość .Options).

Deserialize API
---
`Deserialize` posiada przeciążenia dla `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`, `Stream` oraz wsparcie dla `ref`.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

Przeciążenie `ref` nadpisuje istniejącą instancję; szczegóły w sekcji [Overwrite](#overwrite).

`DeserializeAsync(Stream)` nie jest pełną operacją odczytu strumieniowego – najpierw czyta do wewnętrznego bufora MemoryPack aż do końca strumienia, a następnie deserializuje.

Jeśli chcesz wykonać pełny odczyt strumieniowy, zobacz sekcję [Streaming Serialization](#streaming-serialization).

Overwrite
---
Aby ograniczyć alokacje, MemoryPack umożliwia deserializację do istniejącej instancji, nadpisując ją. Można to wykorzystać przez przeciążenie `Deserialize(ref T? value)`.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// nadpisz dane do istniejącej instancji.
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack spróbuje nadpisać tyle, ile możliwe, ale jeśli poniższe warunki nie są spełnione, zostanie utworzona nowa instancja (jak przy normalnej deserializacji).

* ref value (w tym członkowie grafu obiektów) to null, ustaw nową instancję
* dozwolony jest tylko konstruktor bezparametrowy, jeśli używany jest konstruktor z parametrami, tworzona jest nowa instancja
* jeśli wartość to `T[]`, ponowne użycie tylko przy tej samej długości, w przeciwnym razie nowa instancja
* jeśli wartość to kolekcja, która ma metodę `.Clear()` (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`), wywołaj Clear() i użyj ponownie, w przeciwnym razie utwórz nową instancję

Odporność na wersje
---
Domyślnie (`GenerateType.Object`) MemoryPack obsługuje ograniczoną ewolucję schematu.

* struktury niezarządzane nie mogą być już zmieniane
* można dodawać członków, ale nie można ich usuwać
* można zmieniać nazwę członka
* nie można zmieniać kolejności członków
* nie można zmieniać typu członka

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Dodanie jest OK.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Usunięcie jest NG.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Zmiana kolejności jest NG.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

W zastosowaniach, przechowywanie starych danych (do pliku, do redis, itd.) i odczyt do nowego schematu jest zawsze poprawny. W scenariuszu RPC, schemat istnieje po stronie klienta i serwera, klient musi zostać zaktualizowany przed serwerem. Zaktualizowany klient nie ma problemu z połączeniem ze starym serwerem, ale stary klient nie może połączyć się z nowym serwerem.

Domyślnie, gdy stare dane są odczytywane do nowego schematu, wszyscy członkowie nieobecni po stronie danych są inicjowani z literalem `default`.
Jeśli chcesz tego uniknąć i użyć wartości początkowych pól/właściwości, możesz użyć `[SuppressDefaultInitialization]`.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < jeśli stare dane są nieobecne, ustaw `111`.
    
    public int Prop3 { get; set; } = 222; // < jeśli stare dane są nieobecne, ustaw `default`.
}
```

 `[SuppressDefaultInitialization]` ma następujące ograniczenia:
- Nie może być używane z readonly, init-only i modyfikatorem required.

Następna sekcja [Serialization info](#serialization-info) pokazuje, jak sprawdzać zmiany schematu, np. przez CI, aby zapobiegać błędom.

Przy użyciu `GenerateType.VersionTolerant` obsługiwana jest pełna odporność na wersje.

* struktura niezarządzana nie może być już zmieniana
* wszyscy członkowie muszą mieć jawnie dodany `[MemoryPackOrder]` (z wyjątkiem adnotacji `SerializeLayout.Sequential`)
* członków można dodawać, można usuwać, ale nie można ponownie używać numerów porządkowych (można używać brakujących numerów)
* można zmieniać nazwę członka
* nie można zmieniać kolejności członków
* nie można zmieniać typu członka

```csharp
// Możliwa serializacja/deserializacja w obu kierunkach 
// VersionTolerantObject1 -> VersionTolerantObject2 oraz 
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

// usunięto
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// dodano
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// Jeśli jawnie ustawisz SerializeLayout.Sequential, pozwala to na automatyczne nadawanie kolejności.
// Jednak nie można usuwać żadnego członka dla wersji tolerancyjnej.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` jest wolniejszy niż `GenerateType.Object` podczas serializacji. Dodatkowo, rozmiar danych wyjściowych będzie nieco większy.

Informacje o serializacji
----
Możesz sprawdzić w IntelliSense, które członkowie danego typu są serializowane. Istnieje opcja zapisania tych informacji do pliku podczas kompilacji. Ustaw `MemoryPackGenerator_SerializationInfoOutputDirectory` w następujący sposób.

```xml
<!-- zapisz informacje o serializacji memorypack do katalogu -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

Następujące informacje są zapisywane do pliku.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

Jeśli typ jest niezarządzany, przed nazwą typu pojawi się `unmanaged`.

```txt
unmanaged FooStruct
---
int x
int y
```

Porównując różnice w tym pliku, można zapobiec niebezpiecznym zmianom schematu. Na przykład, możesz użyć CI do wykrywania następujących reguł:

* modyfikacja typu niezarządzanego
* zmiana kolejności członków
* usunięcie członka

Cykliczne referencje
---
MemoryPack obsługuje również cykliczne referencje. Pozwala to na serializację obiektów drzewiastych bez zmian.

```csharp
// aby włączyć cykliczne referencje, użyj GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

 Na przykład, kod [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) będzie wyglądał tak:

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

`GenerateType.CircularReference` ma te same cechy co wersja tolerancyjna. Jednak jako dodatkowe ograniczenie, dozwolone są tylko konstruktory bezparametrowe. Dodatkowo, śledzenie referencji obiektów wykonywane jest tylko dla obiektów oznaczonych `GenerateType.CircularReference`. Jeśli chcesz śledzić inny obiekt, opakuj go.

CustomFormatter
---
Jeśli zaimplementujesz `MemoryPackCustomFormatterAttribute<T>` lub `MemoryPackCustomFormatterAttribute<TFormatter, T>` (bardziej wydajne, ale bardziej złożone), możesz skonfigurować użycie własnego formatera dla członka MemoryPackObject.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack udostępnia następujące atrybuty formatowania: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // serializuje ten członek jako UTF16 String, jest to szybsze niż UTF8, ale dla ASCII rozmiar jest większy (dla znaków nie-ASCII, czasem mniejszy).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // Podczas deserializacji Dictionary jest inicjalizowany z StringComparer.OrdinalIgnoreCase.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // Podczas deserializacji wszystkie stringi są internowane (patrz: String.Intern). Jeśli podobne wartości powtarzają się, oszczędza to pamięć.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Aby skonfigurować comparer równości dla set/dictionary, wszystkie wbudowane formatery mają przeciążenie konstruktora z comparerem. Możesz łatwo utworzyć własne formatery z porównywaniem równości.

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

`BitPackFormatter` kompresuje tylko typy `bool[]`. `bool[]` jest normalnie serializowane jako 1 bajt na wartość, jednak `BitPackFormatter` serializuje `bool[]` jak `BitArray`, zapisując każdą wartość jako 1 bit. Używając `BitPackFormatter`, 8 wartości bool staje się 1 bajtem zamiast 8, co daje 8-krotne zmniejszenie rozmiaru.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` jest przeznaczony dla `byte[]`, na przykład możesz skompresować duży payload za pomocą Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` jest przeznaczony dla `string`, serializuje skompresowany string (UTF16) przy użyciu Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```

`BrotliFormatter<T>` jest przeznaczony dla dowolnego typu, dane zserializowane są kompresowane przez Brotli. Jeśli typem jest `byte[]` lub `string`, dla wydajności powinieneś użyć `BrotliFormatter` lub `BrotliStringFormatter`.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

Deserializacja z wykorzystaniem puli tablic
---
Aby deserializować dużą tablicę (dowolnego typu `T`), MemoryPack oferuje wiele wydajnych metod z wykorzystaniem puli. Najbardziej efektywną metodą jest użycie funkcji [#Overwrite](#overwrite). W szczególności `List<T>` jest zawsze ponownie wykorzystywana.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> jest ponownie wykorzystywana, brak alokacji przy deserializacji.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// dla wydajnej operacji można uzyskać Span<T> przez CollectionsMarshal
var span = CollectionsMarshal.AsSpan(value.Payload);
```

Wygodnym sposobem jest deserializacja do ArrayPool w czasie deserializacji. MemoryPack udostępnia `MemoryPoolFormatter<T>` i `ReadOnlyMemoryPoolFormatter<T>`.

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

    // Kod zwracający zasoby należy napisać samodzielnie, poniżej fragment.

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
    // wykonaj dowolne operacje...
}   // zwraca do ArrayPool
```

Wydajność
---
Zobacz mój wpis na blogu [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

Rozmiar payload i kompresja
---
Rozmiar payload zależy od wartości docelowej; w przeciwieństwie do JSON nie ma kluczy i jest to format binarny, więc rozmiar payload będzie prawdopodobnie mniejszy niż w JSON.

Dla formatów z kodowaniem varint, takich jak MessagePack i Protobuf, MemoryPack ma tendencję do generowania większych plików, jeśli często używane są liczby typu int (w MemoryPack inty zawsze mają 4 bajty ze względu na kodowanie o stałym rozmiarze, podczas gdy w MessagePack mają 1~5 bajtów).

float i double mają w MemoryPack odpowiednio 4 i 8 bajtów, ale w MessagePack 5 i 9 bajtów. Zatem w przypadku np. tablic Vector3 (float, float, float) MemoryPack będzie mniejszy.

String jest domyślnie kodowany jako UTF8, co jest podobne do innych serializerów, ale jeśli wybrana zostanie opcja UTF16, będzie miał inny charakter.

W każdym przypadku, jeśli payload jest duży, należy rozważyć kompresję. Zalecane są LZ4, ZStandard oraz Brotli.

### Kompresja

MemoryPack udostępnia wydajny helper dla kompresji [Brotli](https://github.com/google/brotli) przez [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) oraz [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder). `BrotliCompressor` oraz `BrotliDecompressor` z MemoryPack oferują kompresję/dekompresję zoptymalizowaną pod kątem wewnętrznego działania MemoryPack.

```csharp
using MemoryPack.Compression;

// Kompresja (wymaga using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// Uzyskaj skompresowany byte[]
var compressedBytes = compressor.ToArray();

// Lub zapisz do innego IBufferWriter<byte> (np. PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Dekompresja (wymaga using)
using var decompressor = new BrotliDecompressor();

// Uzyskaj zdekompresowany ReadOnlySequence<byte> z ReadOnlySpan<byte> lub ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

Zarówno `BrotliCompressor`, jak i `BrotliDecompressor` to struktury, nie alokują pamięci na stercie. Oba przechowują skompresowane lub zdekompresowane dane w wewnętrznej puli pamięci dla Serialize/Deserialize. Dlatego konieczne jest zwolnienie puli pamięci – nie zapomnij o użyciu `using`.

Poziom kompresji jest bardzo istotny. Domyślnie ustawiony jest na quality-1 (CompressionLevel.Fastest), co różni się od domyślnego poziomu w .NET (CompressionLevel.Optimal, quality-4).

Fastest (quality-1) będzie zbliżony szybkością do [LZ4](https://github.com/lz4/lz4), ale jakość 4 jest znacznie wolniejsza. Uznano to za kluczowe w przypadku zastosowań serializera. Zachowaj ostrożność przy używaniu standardowego `BrotliStream` (domyślnie quality-4). W każdym przypadku prędkości i rozmiary kompresji/dekompresji będą się bardzo różnić w zależności od danych. Przygotuj dane, które będą obsługiwane w Twojej aplikacji i przetestuj to samodzielnie.

Zwróć uwagę, że pomiędzy niekompresowanym MemoryPack a kompresją Brotli występuje kilkukrotny spadek wydajności.

Brotli jest również obsługiwany w niestandardowym formaterze. `BrotliFormatter` może kompresować konkretny człon.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

Serializacja typów zewnętrznych
---
Jeśli chcesz serializować typy zewnętrzne, możesz stworzyć niestandardowy formatter i zarejestrować go w providerze, szczegóły znajdziesz w [Formatter/Provider API](#formatterprovider-api). Jednak stworzenie własnego formattera jest trudne. Dlatego zalecamy stworzenie typu wrappera. Przykładowo, jeśli chcesz serializować typ zewnętrzny o nazwie `AnimationCurve`.

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

Typ do opakowania jest publiczny, ale wykluczony z serializacji (`MemoryPackIgnore`). Właściwości, które chcesz serializować, są prywatne, ale dołączone (`MemoryPackInclude`). Należy również przygotować dwa wzorce konstruktorów. Konstruktor używany przez serializer powinien być prywatny.

W obecnej postaci należy go opakowywać za każdym razem, co jest niewygodne. Dodatkowo wrapper w formie struktury nie może reprezentować null. Stwórzmy więc niestandardowy formatter.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity nie obsługuje scoped i TBufferWriter, więc zmień sygnaturę na `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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
        reader.Advance(1); // pomiń blok null
        value = null;
        return;
    }
    
    var wrapped = reader.ReadPackable<SerializableAnimationCurve>();
    value = wrapped.AnimationCurve;
}
}
```

Na końcu zarejestruj formatter przy uruchamianiu aplikacji.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> Uwaga: AnimationCurve w Unity jest domyślnie serializowalny, więc nie wymaga niestandardowego formatera dla AnimationCurve

Pakiety
---
MemoryPack udostępnia następujące pakiety.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` to główna biblioteka zapewniająca pełne wsparcie dla wysokowydajnej serializacji i deserializacji binarnych obiektów. Zależy od `MemoryPack.Core` (biblioteki bazowe) oraz `MemoryPack.Generator` (generowanie kodu). `MemoryPack.Streaming` dodaje rozszerzenia do [Serializacji strumieniowej](#streaming-serialization). `MemoryPack.AspNetCoreMvcFormatter` dodaje formatery wejścia/wyjścia dla ASP.NET Core. `MemoryPack.UnityShims` dodaje typy shim i formatery dla współdzielenia typów pomiędzy .NET a Unity.

TypeScript oraz ASP.NET Core Formatter
---
MemoryPack obsługuje generowanie kodu TypeScript. Generuje klasy oraz kod serializacji z C#, innymi słowy możesz współdzielić typy z przeglądarką bez użycia OpenAPI, proto itp.

Generowanie kodu jest zintegrowane z Source Generator. Poniższa opcja (`MemoryPackGenerator_TypeScriptOutputDirectory`) ustawia katalog wyjściowy dla kodu TypeScript. Kod runtime jest generowany równocześnie, więc nie są wymagane żadne dodatkowe zależności.

```xml
<!-- wyprowadź kod TypeScript memorypack do katalogu -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Typ C# MemoryPackable musi być oznaczony atrybutem `[GenerateTypeScript]`.

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

Kod runtime oraz typy TypeScript zostaną wygenerowane w docelowym katalogu.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

Wygenerowany kod wygląda następująco, z prostymi polami oraz statycznymi metodami serialize/serializeArray oraz deserialize/deserializeArray.

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

Możesz używać tego typu w następujący sposób.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// serializacja do Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// deserializacja z ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

Pakiet `MemoryPack.AspNetCoreMvcFormatter` dodaje formatery wejścia/wyjścia `MemoryPack` dla ASP.NET Core MVC. Możesz dodać `MemoryPackInputFormatter`, `MemoryPackOutputFormatter` do ASP.NET Core MVC następującym kodem.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // Jeśli checkContentType: true, wtedy możliwy jest output w wielu formatach (JSON/MemoryPack, itd...). Domyślnie false.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

Jeśli wywołujesz z HttpClient, możesz ustawić `application/x-memorypack` w nagłówku content-type.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### Mapowanie typów TypeScript

Istnieje kilka ograniczeń dotyczących typów, które mogą być generowane. Spośród typów prostych, `char` i `decimal` nie są obsługiwane. Nie można również używać typów OpenGenerics.

|  C#  |  TypeScript  | Opis |
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
| `Guid` |  `string`  | W TypeScript reprezentowany jako string, ale serializowany/deserializowany jako 16-bajtowa binaria
| `DateTime` | `Date` | DateTimeKind zostanie zignorowany
| `enum` | `const enum` | Typ bazowy `long` i `ulong` nie jest obsługiwany
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | Obsługuje wszystkie typy implementujące `ICollection<T>`, np. `List<T>`
| `: ISet<T>` | `Set<T> \| null` | Obsługuje wszystkie typy implementujące `ISet<T>`, np. `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | Obsługuje wszystkie typy implementujące `IDictionary<K,V>`, np. `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | Obsługuje tylko klasy
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` może być stosowany tylko do klas i obecnie nie jest obsługiwany dla struktur.

### Konfiguracja rozszerzenia pliku importu i konwencji nazewnictwa członków

Domyślnie MemoryPack generuje rozszerzenie pliku jako `.js`, np. `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. Jeśli chcesz użyć innego rozszerzenia lub pustego, użyj `MemoryPackGenerator_TypeScriptImportExtension`, aby to skonfigurować.
Nazwy członków są automatycznie konwertowane do camelCase. Jeśli chcesz używać oryginalnych nazw, ustaw `MemoryPackGenerator_TypeScriptConvertPropertyName` na `false`.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- pozwala na pustą wartość -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- domyślnie true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- domyślnie false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` pozwala na odzwierciedlenie adnotacji nullable C# w kodzie TypeScript. Domyślnie jest wyłączone (false), więc wszystko jest nullable.

Serializacja strumieniowa
---
`MemoryPack.Streaming` udostępnia `MemoryPackStreamingSerializer`, który zapewnia dodatkowe wsparcie dla serializacji i deserializacji kolekcji przez strumienie.

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
Jeśli chcesz zaimplementować własny formatter, dziedzicz po `MemoryPackFormatter<T>` i nadpisz metody `Serialize` oraz `Deserialize`.

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

        // użyj metod writer'a.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // użyj metod reader'a.
    }
}
```
Utworzony formatter rejestruje się przy pomocy `MemoryPackFormatterProvider`.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

Uwaga: `unmanaged struct` (niezawierający typów referencyjnych) nie może korzystać z własnego formattera, zawsze serializuje natywny układ pamięci.

MemoryPackWriter/ReaderOptionalState
---
Inicjalizacja `MemoryPackWriter`/`MemoryPackReader` wymaga OptionalState. To wrapper na `MemoryPackSerializerOptions`, który można utworzyć za pomocą `MemoryPackWriterOptionalStatePool`.

```csharp
// po zwolnieniu, OptionalState wraca do puli.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// dla Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

Zależność od frameworka docelowego
---
MemoryPack udostępnia `netstandard2.1` oraz `net7.0`, ale oba nie są kompatybilne. Na przykład, gdy typy MemoryPackable są w projekcie `netstandard2.1` i używasz ich w projekcie `net7.0`, pojawi się błąd w czasie wykonywania, taki jak

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

Ponieważ net7.0 używa statycznych członków abstrakcyjnych (`Virtual static method`), które nie są obsługiwane w netstandard2.1, to zachowanie jest zgodne ze specyfikacją.

Projekt .NET 7 nie powinien używać dll netstandard 2.1. Innymi słowy, jeśli aplikacja to projekt .NET 7, wszystkie zależności używające MemoryPack muszą obsługiwać .NET 7. Jeśli więc deweloper biblioteki zależy od MemoryPack, należy skonfigurować podwójny target framework.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) to framework grpc-dotnet code-first wykorzystujący MessagePack zamiast protobuf. MagicOnion obsługuje teraz MemoryPack jako warstwę serializacji przez pakiet `MagicOnion.Serialization.MemoryPack` (preview). Szczegóły: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

Minimalna wspierana wersja Unity to `2022.3.12f1`.

Podstawowa paczka `MemoryPack` jest dostępna przez nuget. Jest również dostępna w Unity. Jeśli chcesz uzyskać wsparcie dla wbudowanych typów Unity, dodatkowo udostępniamy rozszerzenie MemoryPack.Unity.

1. Zainstaluj `MemoryPack` z NuGet przy użyciu [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* Otwórz okno z NuGet -> Manage NuGet Packages, wyszukaj "MemoryPack" i naciśnij Install.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* Jeśli pojawi się błąd konfliktu wersji, wyłącz walidację wersji w Player Settings (Edit -> Project Settings -> Player -> Przewiń w dół i rozwiń "Other Settings", a następnie odznacz "Assembly Version Validation" w sekcji "Configuration").

2. Zainstaluj pakiet `MemoryPack.Unity` dodając referencję do git URL

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack używa tagów wydania *.*.*, więc możesz określić wersję np. #1.0.0. Przykład: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


Podobnie jak w wersji .NET, kod generowany jest przez generator kodu (`MemoryPack.Generator.dll`). Implementacja bez refleksji zapewnia również najlepszą wydajność w IL2CPP.

Więcej informacji o Unity i generatorze źródeł znajdziesz w [dokumentacji Unity](https://docs.unity3d.com/Manual/roslyn-analyzers.html).

Generator źródeł jest oficjalnie używany przez Unity w [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) oraz [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html). Innymi słowy, jest to standard generowania kodu w nowej generacji Unity.

Możesz serializować wszystkie typy unmanaged (takie jak `Vector3`, `Rect` itd.) oraz niektóre klasy (`AnimationCurve`, `Gradient`, `RectOffset`). Jeśli chcesz serializować inne typy specyficzne dla Unity, zobacz sekcję [Serializacja typów zewnętrznych](#serialize-external-types).

Pod względem wydajności w Unity, MemoryPack jest x3~x10 szybszy od JsonUtility.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

Jeśli kod współdzielony używa typów Unity (`Vector2` itd.), MemoryPack udostępnia pakiet `MemoryPack.UnityShims` w NuGet.

Paczka `MemoryPack.UnityShims` zapewnia shim'y dla standardowych struktur Unity (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) oraz niektórych klas (`AnimationCurve`, `Gradient`, `RectOffset`).

> [!WARNING]
> Aktualnie w Unity obowiązują następujące ograniczenia:


1. Wersja Unity nie obsługuje CustomFormatter.
2. Jeśli używasz .NET7 lub nowszego, binarny format MemoryPack nie jest w pełni kompatybilny z Unity.
    - Problem dotyczy typów wartościowych, dla których jawnie określono `[StructLayout(LayoutKind.Auto)]`. (Domyślnie dla struktur to `LayoutKind.Sequential`.) Dla takich typów, binaria serializowane w .NET nie mogą być deserializowane w Unity. Podobnie, binaria serializowane w Unity nie mogą być serializowane po stronie .NET.
    - Dotyczy to zwykle następujących typów:
        - `DateTimeOffset`
        - `ValueTuple`
    - Aktualnie prostym rozwiązaniem jest nieużywanie tych typów.


Native AOT
---
Niestety, .NET 7 Native AOT powoduje awarię (`Generic virtual method pointer lookup failure`) podczas używania MemoryPack z powodu błędu środowiska uruchomieniowego. 
Ma to zostać naprawione w .NET 8. Użycie wersji preview `Microsoft.DotNet.ILCompiler` rozwiąże problem w .NET 7. Zobacz [komentarz w issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) jak to skonfigurować.

Specyfikacja binarnego formatu wire
---
Typ `T` zdefiniowany w `Serialize<T>` i `Deserialize<T>` nazywany jest schematem C#. Format MemoryPack nie jest formatem samoopisującym. Do deserializacji wymagany jest odpowiadający schemat C#. Te typy istnieją jako wewnętrzna reprezentacja binariów, ale typów nie można określić bez schematu C#.

Endian musi być `Little Endian`. Jednak referencyjna implementacja C# nie zwraca uwagi na endianness, więc nie można jej używać na maszynach big-endian. Jednak współczesne komputery są zazwyczaj little-endian.

Istnieje osiem typów formatów.

* Unmanaged struct
* Object
* Version Tolerant Object
* Obiekt z Cyklicznym Odwołaniem
* Krotka (Tuple)
* Kolekcja
* Ciąg znaków (String)
* Unia (Union)

### Niezarządzana struktura

Niezarządzana struktura to struktura C# nie zawierająca typów referencyjnych, podobne ograniczenie jak [C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types). Serializowany jest układ struktury taki, jaki jest, włącznie z paddingiem.

### Obiekt

`(byte memberCount, [values...])`

Obiekt posiada 1-bajtowy, nieznakowany bajt jako liczbę członków w nagłówku. Liczba członków pozwala na wartości od `0` do `249`, `255` oznacza, że obiekt jest `null`. Wartości przechowują wartości memorypack dla liczby członków.

### Obiekt odporny na wersje

`(byte memberCount, [varint byte-length-of-values...], [values...])`

Obiekt odporny na wersje jest podobny do Obiektu, ale posiada długość bajtową wartości w nagłówku. Varint przestrzega tej specyfikacji: pierwszy sbyte to wartość lub typeCode, a kolejne X bajtów to wartość. 0 do 127 = nieznakowany bajt, -1 do -120 = znakowany bajt, -121 = bajt, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long.

### Obiekt z Cyklicznym Odwołaniem

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

Obiekt z Cyklicznym Odwołaniem jest podobny do Obiektu odpornego na wersje, ale jeśli memberCount to 250, następny varint(unsigned-int32) to referenceId. W przeciwnym razie, po byte-length-of-values, zapisywany jest varint referenceId.

### Krotka (Tuple)

`(values...)`

Krotka to kolekcja wartości o stałym rozmiarze, nieprzyjmująca wartości null. W .NET, `KeyValuePair<TKey, TValue>` oraz `ValueTuple<T,...>` są serializowane jako Krotka.

### Kolekcja

`(int length, [values...])`

Kolekcja posiada 4-bajtową liczbę całkowitą ze znakiem jako liczbę danych w nagłówku, `-1` oznacza `null`. Wartości przechowują wartości memorypack dla liczby length.

### Ciąg znaków (String)

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

Ciąg znaków ma dwie formy: UTF16 i UTF8. Jeśli pierwsza 4-bajtowa liczba całkowita ze znakiem to `-1`, oznacza null. `0` oznacza pusty ciąg znaków. UTF16 jest taki sam jak kolekcja (serializowany jako `ReadOnlySpan<char>`, liczba bajtów utf16-value to utf16-length * 2). Jeśli pierwsza liczba całkowita ze znakiem <= `-2`, wartość jest zakodowana przez UTF8. utf8-byte-count jest kodowany jako dopełnienie, `~utf8-byte-count` aby uzyskać liczbę bajtów. Następna liczba całkowita ze znakiem to utf16-length, dopuszcza się `-1`, co oznacza nieznaną długość. utf8-bytes przechowuje bajty o liczbie utf8-byte-count.

### Unia (Union)

`(byte tag, value)`  
`(250, ushort tag, value)`

Pierwszy nieznakowany bajt to tag dla wyróżnionego typu wartości lub flagi, `0` do `249` oznacza tag, `250` oznacza, że następny nieznakowany short to tag, `255` oznacza, że unia jest `null`.

Licencja
---
Ta biblioteka jest licencjonowana na podstawie licencji MIT.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---