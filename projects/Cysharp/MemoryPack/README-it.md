# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

Serializer binario a prestazioni estreme con zero encoding per C# e Unity.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> Confrontato con [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/). Misurato su macchina .NET 7 / Ryzen 9 5950X. Questi serializer hanno il metodo `IBufferWriter<byte>`, serializzato usando `ArrayBufferWriter<byte>` e riutilizzato per evitare la misurazione della copia del buffer.

Per gli oggetti standard, MemoryPack è x10 più veloce e da x2 a x5 più veloce rispetto ad altri serializer binari. Per array di struct, MemoryPack è ancora più potente, con velocità fino a x50 ~ x200 rispetto agli altri serializer.

MemoryPack è il mio quarto serializer, precedentemente ho creato serializer ben noti, ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). Il motivo della velocità di MemoryPack è dovuto al suo formato binario specifico e ottimizzato per C# e a un'implementazione ben calibrata basata sulla mia esperienza passata. È anche un design completamente nuovo che utilizza .NET 7 e C# 11 e l'Incremental Source Generator (supporta anche .NET Standard 2.1 (.NET 5, 6) e Unity).

Altri serializer eseguono molte operazioni di codifica come VarInt, tag, stringhe, ecc. Il formato MemoryPack utilizza un design zero-encoding che copia quanta più memoria C# possibile. Lo zero-encoding è simile a FlatBuffers, ma non necessita di un tipo speciale, il target della serializzazione MemoryPack è POCO.

Oltre alle prestazioni, MemoryPack offre queste funzionalità.

* Supporto alle moderne API di I/O (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Generazione di codice tramite Source Generator nativo AOT friendly, senza Dynamic CodeGen (IL.Emit)
* API non generiche senza riflessione
* Deserializzazione su istanza esistente
* Serializzazione polimorfica (Union)
* Supporto version-tolerant limitato (fast/default) e completo
* Serializzazione di riferimenti circolari
* Serializzazione streaming basata su PipeWriter/Reader
* Generazione di codice TypeScript e ASP.NET Core Formatter
* Supporto Unity (2021.3) IL2CPP tramite .NET Source Generator

Installazione
---
Questa libreria è distribuita tramite NuGet. Per le migliori prestazioni, si consiglia di usare `.NET 7`. Il requisito minimo è `.NET Standard 2.1`.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

Inoltre, l'editor di codice richiede il supporto Roslyn 4.3.1, ad esempio Visual Studio 2022 versione 17.3, .NET SDK 6.0.401. Per dettagli, consultare il documento [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support).

Per Unity, i requisiti e il processo di installazione sono completamente diversi. Vedere la sezione [Unity](#unity) per i dettagli.

Guida rapida
---
Definire una struct o una classe da serializzare e annotarla con l'attributo `[MemoryPackable]` e la keyword `partial`.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

Il codice di serializzazione è generato tramite la funzionalità C# source generator che implementa l'interfaccia `IMemoryPackable<T>`. In Visual Studio puoi vedere il codice generato usando la scorciatoia `Ctrl+K, R` sul nome della classe e selezionando `*.MemoryPackFormatter.g.cs`.

Chiama `MemoryPackSerializer.Serialize<T>/Deserialize<T>` per serializzare/deserializzare un'istanza oggetto.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

Il metodo `Serialize` supporta il tipo di ritorno `byte[]` così come la serializzazione su `IBufferWriter<byte>` o `Stream`. Il metodo `Deserialize` supporta `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` e `Stream`. Esistono anche versioni non generiche.

Tipi supportati di default
---
Questi tipi possono essere serializzati di default:

* Primitivi .NET (`byte`, `int`, `bool`, `char`, `double`, ecc.)
* Tipi unmanaged (Qualsiasi `enum`, qualsiasi `struct` definita dall'utente che non contiene tipi reference)
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
* Collezioni immutable (`ImmutableList<>`, ecc.) e interfacce (`IImmutableList<>`, ecc.)

Definire `[MemoryPackable]` `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` può annotare qualsiasi `class`, `struct`, `record`, `record struct` e `interface`. Se un tipo è `struct` o `record struct` che non contiene tipi reference ([Tipi unmanaged in C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)), non viene utilizzata alcuna annotazione aggiuntiva (ignore, include, constructor, callbacks), serializzando/deserializzando direttamente dalla memoria.

Altrimenti, di default, `[MemoryPackable]` serializza le proprietà o i campi pubblici di istanza. Puoi usare `[MemoryPackIgnore]` per escludere un membro dalla serializzazione, `[MemoryPackInclude]` promuove un membro privato a target di serializzazione.

```csharp
[MemoryPackable]
public partial class Sample
{
    // questi tipi vengono serializzati di default
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // questi tipi non vengono serializzati di default
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // usa [MemoryPackIgnore] per rimuovere un membro pubblico dalla serializzazione
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // usa [MemoryPackInclude] per promuovere un membro privato a target di serializzazione
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

Il code generator di `MemoryPack` aggiunge informazioni su quali membri sono serializzati nella sezione `<remarks />`. Questo può essere visualizzato passando il mouse sul tipo con Intellisense.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

Tutti i membri devono essere serializzabili da memorypack, altrimenti il code generator genererà un errore.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack ha 35 regole diagnostiche (`MEMPACK001` a `MEMPACK035`) per una definizione confortevole.

Se il tipo target è definito per la serializzazione MemoryPack esternamente e registrato, usa `[MemoryPackAllowSerialize]` per silenziare la diagnostica.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

L'ordine dei membri è **importante**, MemoryPack non serializza il nome del membro o altre informazioni, ma serializza i campi nell'ordine in cui sono dichiarati. Se un tipo è ereditato, la serializzazione avviene nell'ordine genitore → figlio. L'ordine dei membri non può cambiare per la deserializzazione. Per l'evoluzione dello schema, vedere la sezione [Version tolerant](#version-tolerant).

L'ordine di default è sequenziale, ma puoi scegliere il layout esplicito con `[MemoryPackable(SerializeLayout.Explicit)]` e `[MemoryPackOrder()]`.

```csharp
// serializza Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### Selezione del costruttore

MemoryPack supporta sia costruttori parametrizzati che senza parametri. La selezione del costruttore segue queste regole. (Si applica a classi e struct).

* Se esiste `[MemoryPackConstructor]`, viene usato quello.
* Se non ci sono costruttori espliciti (incluso privato), viene usato quello senza parametri.
* Se c’è un solo costruttore senza parametri/parametrizzato (incluso privato), viene usato quello.
* Se ci sono più costruttori, allora l’attributo `[MemoryPackConstructor]` deve essere applicato al costruttore desiderato (il generatore non ne sceglierà uno automaticamente), altrimenti verrà generato un errore.
* Se si utilizza un costruttore parametrizzato, tutti i nomi dei parametri devono corrispondere ai nomi dei membri corrispondenti (case-insensitive).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // Si può usare un costruttore parametrizzato - i nomi dei parametri devono corrispondere ai nomi dei membri (case-insensitive)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// supporta anche il costruttore primario dei record
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
// Se ci sono più costruttori, allora si dovrebbe usare [MemoryPackConstructor]
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### Callback di serializzazione

Durante la serializzazione/deserializzazione, MemoryPack può invocare un evento prima/dopo usando gli attributi `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]`. È possibile annotare sia metodi statici che di istanza (non statici), sia metodi pubblici che privati.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // l’ordine di chiamata dei metodi è statico -> istanza
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // permette anche metodi privati
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

    // Nota: il metodo di istanza con MemoryPackOnDeserializing non viene chiamato se l’istanza non è passata tramite `ref`
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

I callback permettono sia metodi senza parametri sia metodi con `ref reader/writer, ref T value`. Ad esempio, i callback ref possono scrivere/leggere un header personalizzato prima del processo di serializzazione.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, usa where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // emette un GUID nell’header.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // legge l’header personalizzato prima della deserializzazione
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

Se si assegna un valore a `ref value`, è possibile cambiare il valore utilizzato per la serializzazione/deserializzazione. Ad esempio, istanziare da un ServiceProvider.

```csharp
// prima di usare questo formatter, impostare ServiceProvider
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

Definire una collezione personalizzata
---
Per impostazione predefinita, un tipo annotato con `[MemoryPackObject]` cerca di serializzare i suoi membri. Tuttavia, se un tipo è una collezione (`ICollection<>`, `ISet<>`, `IDictionary<,>`), usa `GenerateType.Collection` per serializzarlo correttamente.

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

Costruttore statico
---
Una classe MemoryPackable non può definire un costruttore statico perché la classe partial generata lo utilizza. In alternativa, si può definire un metodo `static partial void StaticConstructor()` per ottenere lo stesso risultato.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Polimorfismo (Union)
---
MemoryPack supporta la serializzazione di oggetti interfaccia e classi astratte per la serializzazione polimorfica. In MemoryPack questa funzionalità è chiamata Union. Solo interfacce e classi astratte possono essere annotate con l’attributo `[MemoryPackUnion]`. Sono richiesti tag univoci di union.

```csharp
// Annotare [MemoryPackable] e i tipi derivati con [MemoryPackUnion]
// Union supporta anche classi astratte
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

// Serializza come tipo interfaccia.
var bin = MemoryPackSerializer.Serialize(data);

// Deserializza come tipo interfaccia.
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

Il `tag` consente valori da `0` a `65535`, ed è particolarmente efficiente per valori inferiori a `250`.
```
Se un'interfaccia e i tipi derivati si trovano in assembly diversi, puoi utilizzare invece `MemoryPackUnionFormatterAttribute`. I formatter vengono generati in modo che siano automaticamente registrati tramite `ModuleInitializer` in C# 9.0 e versioni successive.

> Nota che `ModuleInitializer` non è supportato in Unity, quindi il formatter deve essere registrato manualmente. Per registrare il tuo union formatter invoca manualmente `{nome del tuo union formatter}Initializer.RegisterFormatter()` all'avvio. Ad esempio, `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB definisce la definizione al di fuori del tipo target
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Un'unione può essere assemblata nel codice tramite `DynamicUnionFormatter<T>`.

```csharp
// (ushort, Type)[]
var formatter = new DynamicUnionFormatter<IFooBarBaz>(
    (0, typeof(Foo)),
    (1, typeof(Bar)),
    (2, typeof(Baz))
);

MemoryPackFormatterProvider.Register(formatter);
```

API Serialize
---
`Serialize` ha tre overload.

```csharp
// È disponibile anche una API non generica, in cui il primo argomento è Type e il valore è object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

Per motivi di prestazioni, l'API consigliata utilizza `BufferWriter`. Questa serializza direttamente nel buffer. Può essere applicata a `PipeWriter` in `System.IO.Pipelines`, `BodyWriter` in ASP .NET Core, ecc.

Se è richiesto un `byte[]` (ad esempio `RedisValue` in [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)), l'API che restituisce `byte[]` è semplice e quasi altrettanto veloce.

Nota che `SerializeAsync` per `Stream` è asincrona solo per Flush; serializza tutto in una volta nel buffer interno di MemoryPack e poi scrive utilizzando `WriteAsync`. Pertanto, la versione con overload `BufferWriter`, che separa e controlla buffer e flush, è preferibile.

Se desideri eseguire una scrittura streaming completa, consulta la sezione [Streaming Serialization](#streaming-serialization).

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` configura se le stringhe vengono serializzate come UTF16 o UTF8. Può essere configurato passando `MemoryPackSerializerOptions.Utf8` per la codifica UTF8, `MemoryPackSerializerOptions.Utf16` per la codifica UTF16 oppure `MemoryPackSerializerOptions.Default` che di default usa UTF8. Passare null o usare il parametro di default comporta la codifica UTF8.

Poiché la rappresentazione interna delle stringhe in C# è UTF16, UTF16 ha prestazioni migliori. Tuttavia, il payload tende a essere più grande; in UTF8, una stringa ASCII è un byte, mentre in UTF16 sono due byte. Poiché la differenza di dimensione di questo payload è così grande, UTF8 è impostato come default.

Se i dati non sono ASCII (ad esempio giapponese, che può richiedere più di 3 byte e con UTF8 è più grande), o se devi comprimerli separatamente, UTF16 può dare risultati migliori.

Mentre UTF8 o UTF16 possono essere selezionati durante la serializzazione, non è necessario specificarlo durante la deserializzazione. Verrà rilevato automaticamente e deserializzato normalmente.

Inoltre puoi ottenere/impostare `IServiceProvider? ServiceProvider { get; init; }` dalle opzioni. È utile per ottenere oggetti DI (come `ILogger<T>`) dal processo di serializzazione (`MemoryPackReader/MemoryPackWriter` ha la proprietà .Options).

API Deserialize
---
`Deserialize` ha overload per `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`, `Stream` e supporto per `ref`.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

L'overload `ref` sovrascrive un'istanza esistente, per dettagli vedi la sezione [Overwrite](#overwrite).

`DeserializeAsync(Stream)` non è una lettura streaming completa: prima legge nel pool interno di MemoryPack fino alla fine dello stream, poi deserializza.

Se vuoi eseguire una lettura streaming completa, consulta la sezione [Streaming Serialization](#streaming-serialization).

Overwrite
---
Per ridurre le allocazioni, MemoryPack supporta la deserializzazione su un'istanza esistente, sovrascrivendola. Questo può essere usato con l'overload `Deserialize(ref T? value)`.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// sovrascrive i dati nell'istanza esistente.
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack tenterà di sovrascrivere il più possibile, ma se non si verificano le seguenti condizioni, verrà creata una nuova istanza (come nella deserializzazione normale).

* il valore ref (inclusi i membri nel grafo degli oggetti) è null, viene impostata una nuova istanza
* consente solo il costruttore senza parametri, se viene usato un costruttore parametrico, crea una nuova istanza
* se il valore è `T[]`, viene riutilizzato solo se la lunghezza è la stessa, altrimenti viene creata una nuova istanza
* se il valore è una collezione che ha il metodo `.Clear()` (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`), viene chiamato Clear() e la collezione viene riutilizzata, altrimenti viene creata una nuova istanza

Version tolerant
---
Di default (`GenerateType.Object`), MemoryPack supporta un'evoluzione limitata dello schema.

* una struct non gestita non può più essere modificata
* i membri possono essere aggiunti, ma non possono essere eliminati
* è possibile cambiare il nome del membro
* non è possibile cambiare l'ordine dei membri
* non è possibile cambiare il tipo del membro

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// L'aggiunta è OK.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// La rimozione NON è consentita.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Cambiare ordine NON è consentito.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

Nell'uso pratico, salvare dati vecchi (su file, su redis, ecc...) e leggerli con uno schema nuovo è sempre consentito. Nello scenario RPC, lo schema esiste sia lato client che lato server, il client deve essere aggiornato prima del server. Un client aggiornato può connettersi senza problemi a un server vecchio, ma un client vecchio non può connettersi a un server nuovo.

Di default, quando i dati vecchi vengono letti su uno schema nuovo, tutti i membri non presenti nei dati sono inizializzati con il valore letterale `default`.
Se vuoi evitare questo comportamento e usare i valori iniziali dei campi/proprietà, puoi usare `[SuppressDefaultInitialization]`.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < se i dati vecchi mancano, imposta `111`.
    
    public int Prop3 { get; set; } = 222; // < se i dati vecchi mancano, imposta `default`.
}
```

 `[SuppressDefaultInitialization]` ha le seguenti limitazioni:
- Non può essere usato con readonly, init-only e modificatore required.

La prossima sezione [Serialization info](#serialization-info) mostra come verificare le modifiche allo schema, ad esempio tramite CI, per prevenire errori.

Quando si utilizza `GenerateType.VersionTolerant`, viene supportata la piena tolleranza di versione.

* una struct non gestita non può più essere modificata
* tutti i membri devono aggiungere `[MemoryPackOrder]` esplicitamente (tranne se si annota `SerializeLayout.Sequential`)
* i membri possono essere aggiunti, possono essere eliminati ma non si può riutilizzare l'ordine (è possibile usare ordini mancanti)
* è possibile cambiare il nome del membro
* non è possibile cambiare l'ordine dei membri
* non è possibile cambiare il tipo del membro

```csharp
// Ok per serializzare/deserializzare sia 
// VersionTolerantObject1 -> VersionTolerantObject2 che 
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

// eliminato
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// aggiunto
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// Se si imposta esplicitamente SerializeLayout.Sequential, consente l'ordinamento automatico.
// Tuttavia, non è possibile rimuovere alcun membro per la tolleranza alle versioni.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` è più lento di `GenerateType.Object` durante la serializzazione. Inoltre, la dimensione del payload sarà leggermente maggiore.

Informazioni sulla serializzazione
----
Puoi verificare tramite IntelliSense quali membri di un tipo vengono serializzati. Esiste un'opzione per scrivere queste informazioni su un file in fase di compilazione. Imposta `MemoryPackGenerator_SerializationInfoOutputDirectory` come segue.

```xml
<!-- output memorypack serialization info to directory -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

Le seguenti informazioni vengono scritte nel file.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

Se il tipo è unmanaged, viene visualizzato `unmanaged` prima del nome del tipo.

```txt
unmanaged FooStruct
---
int x
int y
```

Controllando le differenze in questo file, è possibile prevenire cambiamenti pericolosi dello schema. Ad esempio, potresti voler utilizzare la CI per rilevare le seguenti regole

* modifica di un tipo unmanaged
* cambio dell'ordine dei membri
* eliminazione di un membro

Riferimento Circolare
---
MemoryPack supporta anche il riferimento circolare. Questo consente di serializzare gli oggetti ad albero così come sono.

```csharp
// per abilitare il riferimento circolare, usare GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

Ad esempio, il codice [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) diventerà così.

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

`GenerateType.CircularReference` ha le stesse caratteristiche della tolleranza alle versioni. Tuttavia, come vincolo aggiuntivo, sono consentiti solo costruttori senza parametri. Inoltre, il tracciamento dei riferimenti agli oggetti viene effettuato solo per gli oggetti contrassegnati con `GenerateType.CircularReference`. Se desideri tracciare altri oggetti, incapsulali.

CustomFormatter
---
Se implementi `MemoryPackCustomFormatterAttribute<T>` oppure `MemoryPackCustomFormatterAttribute<TFormatter, T>` (più performante, ma complesso), puoi configurare un formatter personalizzato per i membri di MemoryPackObject.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack fornisce i seguenti attributi di formattazione: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // serializza questo membro come String UTF16, è più performante di UTF8 ma in ASCII la dimensione è maggiore (ma per caratteri non ASCII, talvolta è più piccola).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // In deserializzazione, il Dictionary viene inizializzato con StringComparer.OrdinalIgnoreCase.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // In deserializzazione, tutte le stringhe vengono internate (vedi: String.Intern). Se valori simili si ripetono, si risparmia memoria.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Per configurare l'equality comparer di un set/dictionary, tutti i formatter integrati dispongono di un overload del costruttore con comparer. Puoi creare facilmente formatter personalizzati per equality comparer.

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

`BitPackFormatter` comprime solo i tipi `bool[]`. `bool[]` normalmente viene serializzato come 1 byte per ogni valore booleano, tuttavia `BitPackFormatter` serializza `bool[]` come una `BitArray` memorizzando ogni bool come 1 bit. Usando `BitPackFormatter`, 8 bool diventano 1 byte dove normalmente sarebbero 8 byte, ottenendo una dimensione 8 volte inferiore.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` è per `byte[]`, ad esempio puoi comprimere un payload di grandi dimensioni con Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` è per `string`, serializza stringhe compresse (UTF16) con Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```

`BrotliFormatter<T>` è per qualsiasi tipo, i dati serializzati vengono compressi tramite Brotli. Se un tipo è `byte[]` o `string`, dovresti utilizzare `BrotliFormatter` o `BrotliStringFormatter` per motivi di performance.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

Deserialize array pooling
---
Per deserializzare un grande array (qualsiasi `T`), MemoryPack offre diversi metodi di pooling efficienti. Il modo più efficace è usare la funzione [#Overwrite](#overwrite). In particolare `List<T>` viene sempre riutilizzata.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> viene riutilizzata, nessuna allocazione in deserializzazione.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// per un'operazione efficiente, puoi ottenere Span<T> tramite CollectionsMarshal
var span = CollectionsMarshal.AsSpan(value.Payload);
```

Un modo conveniente è deserializzare su un ArrayPool al momento della deserializzazione. MemoryPack fornisce `MemoryPoolFormatter<T>` e `ReadOnlyMemoryPoolFormatter<T>`.

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

    // Devi scrivere tu stesso il codice di rilascio, qui un esempio.

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
    // fai qualsiasi cosa...
}   // ritorna all'ArrayPool
```

Performance
---
Vedi il mio post sul blog [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

Dimensione del payload e compressione
---
La dimensione del payload dipende dal valore di destinazione; a differenza di JSON, non ci sono chiavi ed è un formato binario, quindi la dimensione del payload sarà probabilmente più piccola rispetto a JSON.

Per chi utilizza la codifica varint, come MessagePack e Protobuf, MemoryPack tende ad essere più grande se si usano molti interi (in MemoryPack, gli int sono sempre 4 byte a causa della codifica a dimensione fissa, mentre in MessagePack sono 1~5 byte).

float e double sono 4 byte e 8 byte in MemoryPack, ma 5 byte e 9 byte in MessagePack. Quindi MemoryPack è più piccolo, ad esempio, per array di Vector3 (float, float, float).

Le stringhe sono in UTF8 di default, il che è simile ad altri serializer, ma se viene scelta l'opzione UTF16, sarà di natura diversa.

In ogni caso, se la dimensione del payload è grande, si dovrebbe considerare la compressione. Sono raccomandati LZ4, ZStandard e Brotli.

### Compressione

MemoryPack fornisce un helper efficiente per la compressione [Brotli](https://github.com/google/brotli) tramite [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) e [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder). `BrotliCompressor` e `BrotliDecompressor` di MemoryPack offrono compressione/decompressione ottimizzata per il comportamento interno di MemoryPack.

```csharp
using MemoryPack.Compression;

// Compressione (richiede using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// Ottieni byte[] compresso
var compressedBytes = compressor.ToArray();

// Oppure scrivi su un altro IBufferWriter<byte> (ad esempio PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Decompressione (richiede using)
using var decompressor = new BrotliDecompressor();

// Ottieni ReadOnlySequence<byte> decompresso da ReadOnlySpan<byte> o ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

Sia `BrotliCompressor` che `BrotliDecompressor` sono struct, non allocano memoria sull'heap. Entrambi memorizzano i dati compressi o decompressi in un memory pool interno per Serialize/Deserialize. Pertanto, è necessario rilasciare il pooling della memoria, non dimenticare di usare `using`.

Il livello di compressione è molto importante. Il valore predefinito è impostato su quality-1 (CompressionLevel.Fastest), che è diverso dal valore predefinito di .NET (CompressionLevel.Optimal, quality-4).

Fastest (quality-1) sarà vicino alla velocità di [LZ4](https://github.com/lz4/lz4), ma 4 è molto più lento. Questo è stato ritenuto critico nello scenario d'uso del serializer. Fai attenzione quando usi `BrotliStream` standard (quality-4 è il valore predefinito). In ogni caso, le velocità di compressione/decompressione e le dimensioni varieranno molto a seconda dei dati. Prepara i dati da gestire per la tua applicazione e testa personalmente.

Nota che c'è una penalità di velocità di vari ordini di grandezza tra l'uso di MemoryPack non compresso e la compressione aggiuntiva di Brotli.

Brotli è supportato anche in un formatter personalizzato. `BrotliFormatter` può comprimere un membro specifico.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

Serializzare tipi esterni
---
Se vuoi serializzare tipi esterni, puoi creare un formatter personalizzato e registrarlo nel provider, vedi [Formatter/Provider API](#formatterprovider-api) per dettagli. Tuttavia, creare un formatter personalizzato è difficile. Perciò, si consiglia di creare un tipo wrapper. Ad esempio, se vuoi serializzare un tipo esterno chiamato `AnimationCurve`.

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

Il tipo da wrappare è pubblico, ma escluso dalla serializzazione (`MemoryPackIgnore`). Le proprietà che vuoi serializzare sono private, ma incluse (`MemoryPackInclude`). Devono essere preparati anche due tipi di costruttori. Il costruttore usato dal serializer dovrebbe essere privato.

Così com'è, deve essere wrappato ogni volta, il che è scomodo. Inoltre, lo struct wrapper non può rappresentare null. Quindi creiamo un formatter personalizzato.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity non supporta scoped e TBufferWriter quindi cambia la firma in `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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

Infine, registra il formatter nell’avvio dell’applicazione.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> Nota: AnimationCurve di Unity è serializzabile di default, quindi non necessita di questo custom formatter per AnimationCurve.

Pacchetti
---
MemoryPack include questi pacchetti.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` è la libreria principale, fornisce il pieno supporto per la serializzazione e deserializzazione ad alte prestazioni di oggetti binari. Dipende da `MemoryPack.Core` per le librerie base core e da `MemoryPack.Generator` per la generazione del codice. `MemoryPack.Streaming` aggiunge estensioni aggiuntive per la [Streaming Serialization](#streaming-serialization). `MemoryPack.AspNetCoreMvcFormatter` aggiunge formatter di input/output per ASP.NET Core. `MemoryPack.UnityShims` aggiunge tipi shim e formatter per la condivisione di tipi tra .NET e Unity.

TypeScript e ASP.NET Core Formatter
---
MemoryPack supporta la generazione di codice TypeScript. Genera classi e codice di serializzazione da C#, in altre parole, puoi condividere tipi con il browser senza utilizzare OpenAPI, proto, ecc.

La generazione del codice è integrata con Source Generator, le seguenti opzioni (`MemoryPackGenerator_TypeScriptOutputDirectory`) impostano la directory di output per il codice TypeScript. Il codice runtime viene generato contemporaneamente, quindi non sono necessarie dipendenze aggiuntive.

```xml
<!-- output memorypack TypeScript code to directory -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Un tipo C# MemoryPackable deve essere annotato con `[GenerateTypeScript]`.

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

Il codice runtime e il tipo TypeScript verranno generati nella directory di destinazione.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

Il codice generato è il seguente, con campi semplici e metodi statici per serialize/serializeArray e deserialize/deserializeArray.

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

Puoi utilizzare questo tipo come segue.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// serializza in Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// deserializza da ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

Il pacchetto `MemoryPack.AspNetCoreMvcFormatter` aggiunge formatter di input e output `MemoryPack` per ASP.NET Core MVC. Puoi aggiungere `MemoryPackInputFormatter`, `MemoryPackOutputFormatter` ad ASP.NET Core MVC con il seguente codice.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // Se checkContentType: true allora è possibile produrre output in più formati (JSON/MemoryPack, ecc...). Il valore predefinito è false.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

Se chiami da HttpClient, puoi impostare `application/x-memorypack` come content-header.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### TypeScript Type Mapping

Ci sono alcune restrizioni sui tipi che possono essere generati. Tra i tipi primitivi, `char` e `decimal` non sono supportati. Inoltre, non è possibile utilizzare tipi OpenGenerics.

|  C#  |  TypeScript  | Descrizione |
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
| `Guid` |  `string`  | In TypeScript, rappresentato come stringa ma serializzato/deserializzato come binario a 16 byte
| `DateTime` | `Date` | DateTimeKind verrà ignorato
| `enum` | `const enum` | Il tipo sottostante `long` e `ulong` non è supportato
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | Supporta tutti i tipi che implementano `ICollection<T>`, come `List<T>`
| `: ISet<T>` | `Set<T> \| null` | Supporta tutti i tipi che implementano `ISet<T>`, come `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | Supporta tutti i tipi che implementano `IDictionary<K,V>`, come `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | Supporta solo classi
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` può essere applicato solo alle classi e attualmente non è supportato per le struct.

### Configurare l'estensione del file di import e il casing dei nomi dei membri

Di default, MemoryPack genera l'estensione dei file come `.js`, ad esempio `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. Se vuoi cambiare l'estensione o lasciarla vuota, usa `MemoryPackGenerator_TypeScriptImportExtension` per configurarla.
Inoltre, il nome dei membri viene automaticamente convertito in camelCase. Se vuoi usare il nome originale, imposta `MemoryPackGenerator_TypeScriptConvertPropertyName` a `false`.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- permette vuoto -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- default è true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- default è false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` permette che le annotazioni nullable di C# siano riflesse nel codice TypeScript. Il default è false, rendendo tutto nullable.

Serializzazione Streaming
---
`MemoryPack.Streaming` fornisce `MemoryPackStreamingSerializer`, che aggiunge supporto aggiuntivo per la serializzazione e deserializzazione di collezioni tramite stream.

```csharp
public static class MemoryPackStreamingSerializer
{
    public static async ValueTask SerializeAsync<T>(PipeWriter pipeWriter, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async ValueTask SerializeAsync<T>(Stream stream, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async IAsyncEnumerable<T?> DeserializeAsync<T>(PipeReader pipeReader, int bufferAtLeast = 4096, int readMinimumSize = 8192, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    public static IAsyncEnumerable<T?> DeserializeAsync<T>(Stream stream, int bufferAtLeast = 4096, int readMinimumSize = 8192, CancellationToken cancellationToken = default)
}
```

API Formatter/Provider
---
Se vuoi implementare manualmente un formatter, eredita da `MemoryPackFormatter<T>` e sovrascrivi i metodi `Serialize` e `Deserialize`.

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

        // usa il metodo writer.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // usa il metodo reader.
    }
}
```
Il formatter creato viene registrato con `MemoryPackFormatterProvider`.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

Nota: le `unmanaged struct` (che non contengono tipi reference) non possono usare custom formatter, vengono sempre serializzate con layout di memoria nativo.

MemoryPackWriter/ReaderOptionalState
---
L'inizializzazione di `MemoryPackWriter`/`MemoryPackReader` richiede OptionalState. È un wrapper di `MemoryPackSerializerOptions` e può essere creato da `MemoryPackWriterOptionalStatePool`.

```csharp
// quando viene eliminato, OptionalState tornerà al pool.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// per Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

Dipendenza dal framework di destinazione
---
MemoryPack fornisce `netstandard2.1` e `net7.0` ma entrambi non sono compatibili. Ad esempio, tipi MemoryPackable sotto un progetto `netstandard2.1` e usati da un progetto `net7.0` generano una eccezione a runtime come questa

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

Poiché net7.0 usa membri statici astratti (`Virtual static method`), che non sono supportati da netstandard2.1, questo comportamento è una specifica.

Un progetto .NET 7 non dovrebbe usare la dll netstandard 2.1. In altre parole, se l'applicazione è un progetto .NET 7, tutte le dipendenze che usano MemoryPack devono supportare .NET 7. Quindi, se uno sviluppatore di librerie ha una dipendenza su MemoryPack, è necessario configurare il doppio target framework.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) è un framework grpc-dotnet code-first che utilizza MessagePack invece di protobuf. MagicOnion ora supporta MemoryPack come layer di serializzazione tramite il pacchetto `MagicOnion.Serialization.MemoryPack` (in anteprima). Vedi dettagli: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

La versione minima supportata di Unity è `2022.3.12f1`.

Il pacchetto core `MemoryPack` è fornito tramite nuget. È disponibile anche in Unity. Se vuoi ottenere il supporto per i tipi integrati di Unity, forniamo inoltre l'estensione MemoryPack.Unity.

1. Installa `MemoryPack` da NuGet usando [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* Apri la finestra da NuGet -> Gestisci Pacchetti NuGet, cerca "MemoryPack" e premi Installa.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* Se incontri errori di conflitto di versione, disabilita la validazione delle versioni nelle Impostazioni del Player (Modifica -> Impostazioni Progetto -> Player -> Scorri verso il basso ed espandi "Other Settings" quindi deseleziona "Assembly Version Validation" sotto la sezione "Configuration").

2. Installa il pacchetto `MemoryPack.Unity` facendo riferimento all'URL git

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack usa il tag di rilascio *.*.* quindi puoi specificare una versione come #1.0.0. Ad esempio: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


Come nella versione .NET, il codice è generato da un code generator (`MemoryPack.Generator.dll`). L'implementazione senza reflection fornisce anche le migliori prestazioni in IL2CPP.

Per maggiori informazioni su Unity e Source Generator, fai riferimento alla [documentazione Unity](https://docs.unity3d.com/Manual/roslyn-analyzers.html).

Source Generator è utilizzato ufficialmente anche da Unity tramite [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) e [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html). In altre parole, è lo standard per la generazione di codice nella prossima generazione di Unity.

Puoi serializzare tutti i tipi unmanaged (come `Vector3`, `Rect`, ecc...) e alcune classi (`AnimationCurve`, `Gradient`, `RectOffset`). Se vuoi serializzare altri tipi specifici di Unity, vedi la sezione [Serialize external types](#serialize-external-types).

In termini di performance su Unity, MemoryPack è da 3 a 10 volte più veloce di JsonUtility.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

Se il codice condiviso contiene tipi di Unity (`Vector2`, ecc...), MemoryPack fornisce il pacchetto `MemoryPack.UnityShims` su NuGet.

Il pacchetto `MemoryPack.UnityShims` fornisce shims per gli struct standard di Unity (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) e alcune classi (`AnimationCurve`, `Gradient`, `RectOffset`).

> [!WARNING]
> Attualmente, esistono le seguenti limitazioni per l'utilizzo in Unity


1. La versione Unity non supporta CustomFormatter.
2. Se usi .NET7 o successivi, il formato binario di MemoryPack non è pienamente compatibile con Unity.
    - Questo problema si verifica con i tipi value cui è stato specificato esplicitamente `[StructLayout(LayoutKind.Auto)]`. (Il default per struct è `LayoutKind.Sequential`.) Per questi tipi, i binari serializzati in .NET non possono essere deserializzati in Unity. Allo stesso modo, un binario serializzato in Unity non può essere serializzato lato .NET.
    - I tipi interessati includono tipicamente i seguenti tipi.
        - `DateTimeOffset`
        - `ValueTuple`
    - Al momento, la soluzione più semplice è non utilizzare questi tipi.


Native AOT
---
Sfortunatamente, .NET 7 Native AOT causa un crash (`Generic virtual method pointer lookup failure`) quando si usa MemoryPack a causa di un bug del runtime. 
Verrà corretto in .NET 8. Usando la versione preview di ``Microsoft.DotNet.ILCompiler``, il problema sarà risolto anche in .NET 7. Vedi il [commento all'issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) per sapere come configurarlo.

Specifiche del formato binario wire
---
Il tipo di `T` definito in `Serialize<T>` e `Deserialize<T>` è chiamato schema C#. Il formato MemoryPack non è un formato auto-descrivente. La deserializzazione richiede il relativo schema C#. Questi tipi esistono come rappresentazioni interne dei binari, ma i tipi non possono essere determinati senza uno schema C#.

L'endianness deve essere `Little Endian`. Tuttavia, l'implementazione C# di riferimento non si preoccupa dell'endianness quindi non può essere usata su macchine big-endian. Tuttavia, i computer moderni sono solitamente little-endian.

Esistono otto tipi di formato.

* Struct unmanaged
* Oggetto
* Oggetto tollerante alle versioni
* Oggetto con Riferimento Circolare
* Tupla
* Collezione
* Stringa
* Unione

### Struttura Unmanaged

Una struttura unmanaged è una struct C# che non contiene tipi riferimento, con un vincolo simile a [C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types). La serializzazione avviene secondo il layout della struct così com’è, inclusi eventuali padding.

### Oggetto

`(byte memberCount, [values...])`

Un oggetto ha 1 byte non firmato come conteggio dei membri nell’header. Il conteggio dei membri consente valori da `0` a `249`, `255` rappresenta che l’oggetto è `null`. I valori memorizzano valori memorypack per il numero di membri.

### Oggetto Tollerante alle Versioni

`(byte memberCount, [varint byte-length-of-values...], [values...])`

Un Oggetto Tollerante alle Versioni è simile a Oggetto ma nell’header contiene la lunghezza in byte dei valori. Il varint segue queste specifiche: il primo sbyte è valore o typeCode, i successivi X byte sono il valore. Da 0 a 127 = valore unsigned byte, da -1 a -120 = valore signed byte, -121 = byte, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long.

### Oggetto con Riferimento Circolare

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

Un Oggetto con Riferimento Circolare è simile a Oggetto Tollerante alle Versioni ma se memberCount è 250, il varint(unsigned-int32) successivo è referenceId. Altrimenti, dopo byte-length-of-values, viene scritto varint referenceId.

### Tupla

`(values...)`

Una tupla è una collezione di valori di dimensione fissa e non nullable. In .NET, `KeyValuePair<TKey, TValue>` e `ValueTuple<T,...>` sono serializzati come Tuple.

### Collezione

`(int length, [values...])`

Una Collezione ha un intero a 4 byte firmato come conteggio dati nell’header, `-1` rappresenta `null`. I valori memorizzano valori memorypack per il numero di length.

### Stringa

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

Una stringa ha due forme, UTF16 e UTF8. Se il primo intero a 4 byte firmato è `-1`, rappresenta null. `0` rappresenta vuota. UTF16 è uguale a collezione (serializzata come `ReadOnlySpan<char>`, il numero di byte di utf16-value è utf16-length * 2). Se il primo intero firmato <= `-2`, il valore è codificato in UTF8. utf8-byte-count è codificato in complemento, `~utf8-byte-count` per recuperare il conteggio dei byte. Il prossimo intero firmato è utf16-length, può essere `-1` che rappresenta una lunghezza sconosciuta. utf8-bytes memorizza i byte per il numero di utf8-byte-count.

### Unione

`(byte tag, value)`  
`(250, ushort tag, value)`

Il primo byte non firmato è tag, che discrimina il tipo di valore o flag, da `0` a `249` rappresenta il tag, `250` indica che il prossimo unsigned short è il tag, `255` rappresenta che l’unione è `null`.

License
---
Questa libreria è concessa in licenza sotto la licenza MIT.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---