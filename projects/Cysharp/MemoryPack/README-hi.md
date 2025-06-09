# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

C# और Unity के लिए शून्य एन्कोडिंग, अत्यधिक प्रदर्शन वाला बाइनरी सीरियलाइज़र।

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> तुलना की गई है [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/) के साथ। .NET 7 / Ryzen 9 5950X मशीन द्वारा मापा गया। इन सीरियलाइज़रों में `IBufferWriter<byte>` विधि है, जिसे `ArrayBufferWriter<byte>` के उपयोग से सीरियलाइज़ किया गया है और बफर कॉपी को मापने से बचने के लिए पुन: उपयोग किया गया है।

सामान्य ऑब्जेक्ट्स के लिए, MemoryPack x10 गुना तेज़ और अन्य बाइनरी सीरियलाइज़रों की तुलना में x2 ~ x5 गुना तेज़ है। स्ट्रक्चर एरे के लिए, MemoryPack और भी अधिक शक्तिशाली है, जिसकी गति अन्य सीरियलाइज़रों से x50 ~ x200 गुना अधिक है।

MemoryPack मेरा चौथा सीरियलाइज़र है, इससे पहले मैंने प्रसिद्ध सीरियलाइज़र बनाए हैं, ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp)। MemoryPack की गति का कारण इसकी C#-विशिष्ट, C#-अनुकूलित बाइनरी फ़ॉर्मेट और मेरे पिछले अनुभव पर आधारित एक अच्छी तरह से ट्यून की गई इम्प्लीमेंटेशन है। यह पूरी तरह से नया डिज़ाइन है, जिसमें .NET 7 और C# 11 तथा Incremental Source Generator ( .NET Standard 2.1 (.NET 5, 6) और Unity के लिए भी सपोर्ट है) का उपयोग किया गया है।

अन्य सीरियलाइज़र कई एन्कोडिंग ऑपरेशन्स करते हैं जैसे VarInt एन्कोडिंग, टैग, स्ट्रिंग आदि। MemoryPack फॉर्मेट शून्य-एन्कोडिंग डिज़ाइन का उपयोग करता है जो संभवतः जितना अधिक C# मेमोरी हो सके, उसे कॉपी करता है। शून्य-एन्कोडिंग FlatBuffers के समान है, लेकिन इसके लिए विशेष प्रकार की आवश्यकता नहीं है, MemoryPack का सीरियलाइज़ेशन लक्ष्य POCO है।

प्रदर्शन के अलावा, MemoryPack में ये विशेषताएँ हैं:

* आधुनिक I/O APIs का समर्थन (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Native AOT फ्रेंडली Source Generator आधारित कोड जनरेशन, कोई डायनामिक CodeGen (IL.Emit) नहीं
* Reflectionless non-generics APIs
* मौजूदा इंस्टेंस में डीसिरियलाइज़ करें
* पॉलिमॉर्फिज्म (Union) सीरियलाइज़ेशन
* सीमित वर्शन-टोलरेंट (फास्ट/डिफ़ॉल्ट) और पूर्ण वर्शन-टोलरेंट सपोर्ट
* Circular reference सीरियलाइज़ेशन
* PipeWriter/Reader आधारित स्ट्रीमिंग सीरियलाइज़ेशन
* TypeScript कोड जनरेशन और ASP.NET Core Formatter
* Unity (2021.3) IL2CPP सपोर्ट .NET Source Generator के माध्यम से

इंस्टॉलेशन
---
यह लाइब्रेरी NuGet के माध्यम से वितरित की जाती है। सर्वोत्तम प्रदर्शन के लिए, `.NET 7` का उपयोग करने की सिफारिश की जाती है। न्यूनतम आवश्यकता `.NET Standard 2.1` है।

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

साथ ही कोड एडिटर में Roslyn 4.3.1 सपोर्ट होना आवश्यक है, जैसे Visual Studio 2022 version 17.3, .NET SDK 6.0.401। विवरण के लिए, [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support) दस्तावेज़ देखें।

Unity के लिए, आवश्यकताएँ और इंस्टॉलेशन प्रक्रिया पूरी तरह से अलग है। विवरण के लिए [Unity](#unity) अनुभाग देखें।

त्वरित प्रारंभ
---
सीरियलाइज़ करने के लिए एक struct या class को परिभाषित करें और उसे `[MemoryPackable]` एट्रिब्यूट तथा `partial` कीवर्ड से सजाएँ।

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

सीरियलाइज़ेशन कोड C# सोर्स जनरेटर फीचर द्वारा जनरेट किया जाता है, जो `IMemoryPackable<T>` इंटरफ़ेस को इम्प्लीमेंट करता है। Visual Studio में आप जेनरेटेड कोड को क्लास नाम पर `Ctrl+K, R` शॉर्टकट का उपयोग करके और `*.MemoryPackFormatter.g.cs` चुनकर देख सकते हैं।

किसी ऑब्जेक्ट इंस्टेंस को सीरियलाइज़/डीसीरियलाइज़ करने के लिए `MemoryPackSerializer.Serialize<T>/Deserialize<T>` कॉल करें।

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

`Serialize` मेथड `byte[]` रिटर्न टाइप को सपोर्ट करती है, साथ ही यह `IBufferWriter<byte>` या `Stream` में भी सीरियलाइज़ कर सकती है। `Deserialize` मेथड `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` और `Stream` को सपोर्ट करती है। और नॉन-जनरिक वर्शन भी उपलब्ध हैं।

बिल्ट-इन सपोर्टेड टाइप्स
---
ये टाइप्स डिफ़ॉल्ट रूप से सीरियलाइज़ किए जा सकते हैं:

* .NET प्रिमिटिव्स (`byte`, `int`, `bool`, `char`, `double`, आदि)
* Unmanaged टाइप्स (कोई भी `enum`, कोई भी यूज़र-डिफाइन्ड `struct` जिसमें रेफरेंस टाइप्स न हों)
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
* Immutable collections (`ImmutableList<>`, आदि) और इंटरफेसेस (`IImmutableList<>`, आदि)

`[MemoryPackable]` `class` / `struct` / `record` / `record struct` को परिभाषित करें
---
`[MemoryPackable]` को किसी भी `class`, `struct`, `record`, `record struct` और `interface` पर लगाया जा सकता है। यदि कोई टाइप `struct` या `record struct` है जिसमें कोई रेफरेंस टाइप नहीं है ([C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)), तो कोई अतिरिक्त एट्रिब्यूट (ignore, include, constructor, callbacks) उपयोग नहीं होते, इसे सीधे मेमोरी से सीरियलाइज़/डीसीरियलाइज़ किया जाता है।

अन्यथा, डिफ़ॉल्ट रूप से, `[MemoryPackable]` पब्लिक इंस्टेंस प्रॉपर्टीज़ या फील्ड्स को सीरियलाइज़ करता है। आप `[MemoryPackIgnore]` का उपयोग करके किसी सीरियलाइज़ेशन टार्गेट को हटा सकते हैं, `[MemoryPackInclude]` किसी प्राइवेट सदस्य को सीरियलाइज़ेशन टार्गेट में प्रमोट करता है।

```csharp
[MemoryPackable]
public partial class Sample
{
    // ये टाइप्स डिफ़ॉल्ट रूप से सीरियलाइज़ होते हैं
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // ये टाइप्स डिफ़ॉल्ट रूप से सीरियलाइज़ नहीं होते हैं
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // किसी पब्लिक सदस्य को टार्गेट से हटाने के लिए [MemoryPackIgnore] का उपयोग करें
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // किसी प्राइवेट सदस्य को सीरियलाइज़ेशन टार्गेट में प्रमोट करने के लिए [MemoryPackInclude] का उपयोग करें
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

`MemoryPack` का कोड जनरेटर `<remarks />` सेक्शन में यह जानकारी जोड़ता है कि कौन से सदस्य सीरियलाइज़ किए गए हैं। इसे टाइप पर Intellisense के साथ होवर करके देखा जा सकता है।

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

सभी सदस्यों का मेमोरीपैक-सीरियलाइज़ेबल होना आवश्यक है, यदि नहीं, तो कोड जनरेटर त्रुटि देगा।

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack में 35 डायग्नोस्टिक्स नियम हैं (`MEMPACK001` से `MEMPACK035`) ताकि डिफ़ाइन करना सरल हो।

यदि टार्गेट टाइप का MemoryPack सीरियलाइज़ेशन बाहरी रूप से डिफाइन किया गया है और रजिस्टर्ड है, तो डायग्नोस्टिक्स को साइलेंट करने के लिए `[MemoryPackAllowSerialize]` का उपयोग करें।

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

सदस्यों का क्रम **महत्वपूर्ण** है, MemoryPack सदस्य-नाम या अन्य जानकारी को सीरियलाइज़ नहीं करता, बल्कि फील्ड्स को उनके डिक्लेरेशन क्रम में सीरियलाइज़ करता है। यदि टाइप इनहेरिटेड है, तो सीरियलाइज़ेशन माता-पिता → बच्चे के क्रम में किया जाता है। डीसिरियलाइज़ेशन के लिए सदस्यों का क्रम बदला नहीं जा सकता। स्कीमा इवोल्यूशन के लिए, [Version tolerant](#version-tolerant) अनुभाग देखें।

डिफ़ॉल्ट क्रम अनुक्रमिक है, लेकिन आप `[MemoryPackable(SerializeLayout.Explicit)]` और `[MemoryPackOrder()]` के साथ स्पष्ट लेआउट चुन सकते हैं।

```csharp
// Prop0 -> Prop1 को सीरियलाइज़ करें
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### कन्स्ट्रक्टर चयन

MemoryPack पैरामीटराइज्ड और पैरामीटरलेस दोनों कन्स्ट्रक्टर्स को सपोर्ट करता है। कन्स्ट्रक्टर का चयन ये नियम अपनाता है (क्लास और स्ट्रक्चर दोनों पर लागू):

* यदि `[MemoryPackConstructor]` है, तो उसी का उपयोग करें।
* यदि कोई स्पष्ट कन्स्ट्रक्टर (प्राइवेट सहित) नहीं है, तो पैरामीटरलेस का उपयोग करें।
* यदि एक ही पैरामीटरलेस/पैरामीटराइज्ड कन्स्ट्रक्टर (प्राइवेट सहित) है, तो उसी का उपयोग करें।
* यदि एक से अधिक कन्स्ट्रक्टर हैं, तो वांछित कन्स्ट्रक्टर पर `[MemoryPackConstructor]` एट्रिब्यूट लगाया जाना चाहिए (जनरेटर अपने आप कोई नहीं चुनेगा), अन्यथा जनरेटर त्रुटि देगा।
* यदि पैरामीटराइज्ड कन्स्ट्रक्टर का उपयोग करते हैं, तो सभी पैरामीटर नाम संबंधित सदस्य नामों से मेल खाने चाहिए (केस-इन्सेंसिटिव)।

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // आप पैरामीटराइज्ड कन्स्ट्रक्टर का उपयोग कर सकते हैं - पैरामीटर नाम संबंधित सदस्यों के नाम से मेल खाने चाहिए (केस-इन्सेंसिटिव)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// रिकॉर्ड प्राइमरी कन्स्ट्रक्टर भी सपोर्टेड है
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
// यदि एक से अधिक कंस्ट्रक्टर हैं, तो [MemoryPackConstructor] का उपयोग किया जाना चाहिए
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### सीरियलाइज़ेशन कॉलबैक

सीरियलाइज़/डिसीरियलाइज़ करते समय, MemoryPack `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]` एट्रिब्यूट्स का उपयोग कर के पहले/बाद में इवेंट को इनवोक कर सकता है। यह दोनों static और instance (non-static) मेथड्स, और public तथा private मेथड्स पर एनोनेट किया जा सकता है।

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // मेथड कॉल ऑर्डर है static -> instance
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // प्राइवेट मेथड भी अनुमति है
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

    // नोट: instance मेथड जिसमें MemoryPackOnDeserializing है, वह तब नहीं कॉल होता अगर instance `ref` से पास न हो
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

कॉलबैक बिना पैरामीटर वाले मेथड और `ref reader/writer, ref T value` मेथड की अनुमति देता है। उदाहरण के लिए, ref कॉलबैक सीरियलाइज़ेशन प्रोसेस से पहले कस्टम हेडर लिख/पढ़ सकते हैं।

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, उपयोग करें where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // हेडर में GUID लिखें।
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // डिसीरियलाइज़ से पहले कस्टम हेडर पढ़ें
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

यदि `ref value` में कोई मान सेट किया जाए, तो आप सीरियलाइज़ेशन/डिसीरियलाइज़ेशन के लिए उपयोग किए गए मान को बदल सकते हैं। उदाहरण के लिए, ServiceProvider से इंस्टेंसिएट करें।

```csharp
// इस फॉर्मेटर का उपयोग करने से पहले, ServiceProvider सेट करें
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

कस्टम कलेक्शन परिभाषित करें
---
डिफ़ॉल्ट रूप से, एनोनेटेड `[MemoryPackObject]` टाइप अपने सदस्यों को सीरियलाइज़ करने की कोशिश करता है। हालांकि, यदि कोई टाइप कलेक्शन (`ICollection<>`, `ISet<>`, `IDictionary<,>`) है, तो इसे सही तरीके से सीरियलाइज़ करने के लिए `GenerateType.Collection` का उपयोग करें।

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
MemoryPackable क्लास static constructor को परिभाषित नहीं कर सकती क्योंकि जेनेरेटेड partial class इसका उपयोग करती है। इसके बजाय, आप वही कार्य करने के लिए `static partial void StaticConstructor()` परिभाषित कर सकते हैं।

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
MemoryPack इंटरफेस और एब्सट्रैक्ट क्लास ऑब्जेक्ट्स को सीरियलाइज़ करने के लिए पोलीमॉर्फिज्म सीरियलाइज़ेशन का समर्थन करता है। MemoryPack में इस फीचर को Union कहा जाता है। केवल इंटरफेस और एब्सट्रैक्ट क्लासेज को `[MemoryPackUnion]` एट्रिब्यूट्स के साथ एनोनेट करने की अनुमति है। यूनिक यूनियन टैग्स आवश्यक हैं।

```csharp
// [MemoryPackable] और इनहेरिटेंस टाइप्स को [MemoryPackUnion] से एनोनेट करें
// Union एब्सट्रैक्ट क्लास को भी सपोर्ट करता है
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

// इंटरफेस टाइप के रूप में सीरियलाइज़ करें।
var bin = MemoryPackSerializer.Serialize(data);

// इंटरफेस टाइप के रूप में डिसीरियलाइज़ करें।
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

`tag` की अनुमति `0` ~ `65535` तक है, यह विशेष रूप से `250` से कम के लिए कुशल है।
```
यदि कोई इंटरफ़ेस और डेराइव्ड टाइप्स अलग-अलग असेंबली में हैं, तो आप इसके बजाय `MemoryPackUnionFormatterAttribute` का उपयोग कर सकते हैं। फॉर्मेटर्स इस प्रकार जनरेट किए जाते हैं कि वे स्वचालित रूप से C# 9.0 और उसके ऊपर में `ModuleInitializer` के माध्यम से रजिस्टर हो जाते हैं।

> ध्यान दें कि `ModuleInitializer` यूनिटी में समर्थित नहीं है, इसलिए फॉर्मेटर को मैन्युअली रजिस्टर करना होगा। अपने यूनियन फॉर्मेटर को रजिस्टर करने के लिए स्टार्टअप में `{name of your union formatter}Initializer.RegisterFormatter()` मैन्युअली कॉल करें। उदाहरण के लिए `UnionSampleFormatterInitializer.RegisterFormatter()`।

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB में टारगेट टाइप के बाहर डिफिनिशन डिफाइन करें
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

यूनियन को कोड में `DynamicUnionFormatter<T>` के माध्यम से असेंबल किया जा सकता है।

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
`Serialize` के तीन ओवरलोड्स हैं।

```csharp
// नॉन-जेनरिक API भी उपलब्ध है, इन वर्शन में पहला आर्ग्युमेंट टाइप होता है और वैल्यू ऑब्जेक्ट?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

परफॉर्मेंस के लिए, अनुशंसित API `BufferWriter` का उपयोग करता है। यह सीधे बफर में सीरियलाइज़ करता है। इसे `System.IO.Pipelines` के `PipeWriter`, ASP .NET Core के `BodyWriter` आदि पर लागू किया जा सकता है।

यदि `byte[]` आवश्यक है (जैसे [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis) में `RedisValue`), तो रिटर्निंग `byte[]` API सरल और लगभग उतना ही तेज़ है।

ध्यान दें कि `Stream` के लिए `SerializeAsync` केवल Flush के लिए असिंक्रोनस है; यह सब कुछ एक बार MemoryPack के इंटरनल पूल बफर में सीरियलाइज़ करता है और फिर `WriteAsync` का उपयोग करता है। इसलिए, `BufferWriter` ओवरलोड, जो बफर और फ्लश को अलग और नियंत्रित करता है, बेहतर है।

यदि आप पूरी तरह से स्ट्रीमिंग राइट करना चाहते हैं, तो [Streaming Serialization](#streaming-serialization) सेक्शन देखें।

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` यह कॉन्फ़िगर करता है कि स्ट्रिंग्स को UTF16 या UTF8 के रूप में सीरियलाइज़ किया जाए। इसे UTF8 एन्कोडिंग के लिए `MemoryPackSerializerOptions.Utf8`, UTF16 के लिए `MemoryPackSerializerOptions.Utf16` या डिफ़ॉल्ट के लिए `MemoryPackSerializerOptions.Default` (जो डिफ़ॉल्ट रूप से UTF8 है) पास करके सेट किया जा सकता है। null पास करने या डिफ़ॉल्ट पैरामीटर का उपयोग करने पर UTF8 एन्कोडिंग होती है।

चूंकि C# की इंटरनल स्ट्रिंग रिप्रेजेंटेशन UTF16 है, इसलिए UTF16 परफॉर्मेंस में बेहतर है। हालांकि, पेलोड आमतौर पर बड़ा होता है; UTF8 में एक ASCII स्ट्रिंग एक बाइट है, जबकि UTF16 में दो बाइट होती है। इस पेलोड के साइज में बड़ा अंतर होने के कारण, डिफ़ॉल्ट रूप से UTF8 सेट किया गया है।

यदि डेटा नॉन-ASCII है (जैसे जापानी, जो 3 से अधिक बाइट हो सकता है, और UTF8 में बड़ा होता है), या यदि आपको इसे अलग से कंप्रेस करना है, तो UTF16 बेहतर परिणाम दे सकता है।

सीरियलाइज़ेशन के दौरान आप UTF8 या UTF16 चुन सकते हैं, लेकिन डीसिरियलाइज़ेशन के दौरान इसे स्पेसिफाई करना आवश्यक नहीं है। यह स्वचालित रूप से डिटेक्ट और सामान्य रूप से डीसिरियलाइज़ हो जाएगा।

इसके अलावा, आप ऑप्शंस से `IServiceProvider? ServiceProvider { get; init; }` प्राप्त/सेट कर सकते हैं। यह सीरियलाइज़ेशन प्रोसेस से DI ऑब्जेक्ट (जैसे `ILogger<T>`) प्राप्त करने में उपयोगी है (`MemoryPackReader/MemoryPackWriter` में .Options प्रॉपर्टी है)।

Deserialize API
---
`Deserialize` में `ReadOnlySpan<byte>` और `ReadOnlySequence<byte>`, `Stream` ओवरलोड और `ref` सपोर्ट है।

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

`ref` ओवरलोड मौजूदा इंस्टेंस को ओवरराइट करता है, विवरण के लिए [Overwrite](#overwrite) सेक्शन देखें।

`DeserializeAsync(Stream)` पूरी तरह से स्ट्रीमिंग रीड ऑपरेशन नहीं है, पहले यह MemoryPack के इंटरनल पूल में एंड-ऑफ-स्ट्रीम तक पढ़ता है, फिर डीसिरियलाइज़ करता है।

यदि आप पूरी तरह से स्ट्रीमिंग रीड ऑपरेशन करना चाहते हैं, तो [Streaming Serialization](#streaming-serialization) सेक्शन देखें।

Overwrite
---
अलोकेशन्स को कम करने के लिए, MemoryPack मौजूदा इंस्टेंस में डीसिरियलाइज़ करके उसे ओवरराइट करने को सपोर्ट करता है। इसे `Deserialize(ref T? value)` ओवरलोड के साथ उपयोग किया जा सकता है।

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// मौजूदा इंस्टेंस में डेटा ओवरराइट करें।
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack जितना संभव हो उतना ओवरराइट करने का प्रयास करेगा, लेकिन यदि निम्नलिखित कंडीशंस मेल नहीं खातीं, तो यह नया इंस्टेंस बनाएगा (सामान्य डीसिरियलाइज़ेशन की तरह)।

* ref value (ऑब्जेक्ट ग्राफ में मेंबर्स सहित) null है, नया इंस्टेंस सेट करें
* केवल पैरामीटरलेस कंस्ट्रक्टर की अनुमति है, यदि पैरामीटराइज्ड कंस्ट्रक्टर का उपयोग किया गया है, तो नया इंस्टेंस बनाएं
* यदि value `T[]` है, तो केवल तभी री-यूज़ करें जब लेंथ समान हो, अन्यथा नया इंस्टेंस बनाएं
* यदि value ऐसी कलेक्शन है जिसमें `.Clear()` मेथड है (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) तो Clear() कॉल करें और री-यूज़ करें, अन्यथा नया इंस्टेंस बनाएं

Version tolerant
---
डिफ़ॉल्ट में (`GenerateType.Object`), MemoryPack सीमित स्कीमा इवोल्यूशन को सपोर्ट करता है।

* unmanaged struct अब बदला नहीं जा सकता
* मेंबर्स जोड़े जा सकते हैं, लेकिन हटाए नहीं जा सकते
* मेंबर नाम बदला जा सकता है
* मेंबर ऑर्डर बदला नहीं जा सकता
* मेंबर टाइप बदला नहीं जा सकता

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Add करना ठीक है।
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Remove करना NG (नॉट गुड) है।
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// ऑर्डर बदलना NG (नॉट गुड) है।
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

उपयोग में, पुराना डेटा (फाइल में, रेडिस में आदि) स्टोर करें और नए स्कीमा में पढ़ना हमेशा ठीक है। RPC परिदृश्य में, स्कीमा क्लाइंट और सर्वर दोनों साइड पर मौजूद होता है, क्लाइंट को सर्वर से पहले अपडेट करना चाहिए। अपडेटेड क्लाइंट को पुराने सर्वर से कनेक्ट करने में कोई समस्या नहीं है, लेकिन पुराना क्लाइंट नए सर्वर से कनेक्ट नहीं कर सकता।

डिफ़ॉल्ट रूप से, जब पुराना डेटा नए स्कीमा में पढ़ा जाता है, तो डेटा साइड पर मौजूद न होने वाले सभी मेंबर्स को `default` लिटरल से इनिशियलाइज़ किया जाता है।
यदि आप इससे बचना चाहते हैं और फील्ड/प्रॉपर्टीज के इनिशियल वैल्यू का उपयोग करना चाहते हैं, तो आप `[SuppressDefaultInitialization]` का उपयोग कर सकते हैं।

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < अगर पुराना डेटा मिसिंग है तो `111` सेट करें।
    
    public int Prop3 { get; set; } = 222; // < अगर पुराना डेटा मिसिंग है तो `default` सेट करें।
}
```

`[SuppressDefaultInitialization]` की निम्नलिखित सीमाएँ हैं:
- इसे readonly, init-only, और required मोडिफायर के साथ उपयोग नहीं किया जा सकता।

अगला [Serialization info](#serialization-info) सेक्शन दिखाता है कि स्कीमा बदलावों की जांच कैसे करें, जैसे CI के द्वारा, दुर्घटनाओं को रोकने के लिए।

जब `GenerateType.VersionTolerant` का उपयोग करते हैं, तो यह पूर्ण वर्शन-टॉलरेंट को सपोर्ट करता है।

* unmanaged struct अब बदला नहीं जा सकता
* सभी मेंबर्स को स्पष्ट रूप से `[MemoryPackOrder]` जोड़ना आवश्यक है (सिवाय `SerializeLayout.Sequential` के)
* मेंबर्स जोड़े जा सकते हैं, हटाए जा सकते हैं लेकिन ऑर्डर को री-यूज़ नहीं किया जा सकता (मिसिंग ऑर्डर का उपयोग कर सकते हैं)
* मेंबर नाम बदला जा सकता है
* मेंबर ऑर्डर बदला नहीं जा सकता
* मेंबर टाइप बदला नहीं जा सकता

```csharp
// दोनों को serialize/deserialize करना ठीक है 
// VersionTolerantObject1 -> VersionTolerantObject2 और 
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

// हटाया गया
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// जोड़ा गया
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// यदि SerializeLayout.Sequential को स्पष्ट रूप से सेट किया गया है, तो स्वतः क्रम की अनुमति देता है।
// लेकिन यह वर्शन-टॉलरेंट के लिए कोई सदस्य हटाने की अनुमति नहीं देता।
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` को serialize करने में `GenerateType.Object` की तुलना में धीमा है। साथ ही, पेलोड का आकार थोड़ा बड़ा होगा।

Serialization जानकारी
----
आप यह देख सकते हैं कि किस प्रकार के कौन से सदस्य serialize हो रहे हैं, इसके लिए IntelliSense में चेक करें। एक विकल्प है कि इस जानकारी को compile समय पर एक फ़ाइल में लिखा जाए। `MemoryPackGenerator_SerializationInfoOutputDirectory` को निम्न प्रकार से सेट करें।

```xml
<!-- memorypack serialization info को directory में आउटपुट करें -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

निम्न जानकारी फ़ाइल में लिखी जाती है।

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

यदि प्रकार unmanaged है, तो type नाम से पहले `unmanaged` दिखाया जाता है।

```txt
unmanaged FooStruct
---
int x
int y
```

इस फ़ाइल में अंतर की जाँच करके, खतरनाक schema बदलाव को रोका जा सकता है। उदाहरण के लिए, आप निम्न नियमों का पता लगाने के लिए CI का उपयोग कर सकते हैं

* unmanaged type को बदलना
* सदस्य के क्रम में परिवर्तन
* सदस्य को हटाना

Circular Reference
---
MemoryPack सर्कुलर रेफरेंस को भी सपोर्ट करता है। इससे ट्री ऑब्जेक्ट्स को जैसा है वैसा serialize किया जा सकता है।

```csharp
// सर्कुलर-रेफरेंस सक्षम करने के लिए, GenerateType.CircularReference का उपयोग करें
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

 उदाहरण के लिए, [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) कोड यहां जैसा होगा।

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

`GenerateType.CircularReference` में version-tolerant के समान विशेषताएँ हैं। हालांकि, एक अतिरिक्त बाध्यता के रूप में, केवल parameterless constructors की अनुमति है। साथ ही, object reference tracking केवल उन्हीं objects के लिए किया जाता है जिन्हें `GenerateType.CircularReference` के साथ चिह्नित किया गया है। यदि आप किसी अन्य object को ट्रैक करना चाहते हैं, तो उसे wrap करें।

CustomFormatter
---
यदि आप `MemoryPackCustomFormatterAttribute<T>` या `MemoryPackCustomFormatterAttribute<TFormatter, T>` (अधिक performant, लेकिन जटिल) को implement करते हैं, तो आप MemoryPackObject के सदस्य के लिए custom formatter का उपयोग configure कर सकते हैं।

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack निम्नलिखित formatting attributes प्रदान करता है: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // इस सदस्य को UTF16 String के रूप में serialize करें, यह UTF8 की तुलना में बेहतर performance देता है लेकिन ASCII में, आकार बड़ा होता है (लेकिन non ASCII में कभी-कभी छोटा भी हो सकता है)।
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // deserialize में, Dictionary को StringComparer.OrdinalIgnoreCase के साथ initialize किया जाता है।
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // deserialize समय, सभी string को intern किया जाता है (देखें: String.Intern)। यदि समान मान बार-बार आते हैं, तो यह memory बचाता है।
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Set/dictionary के equality comparer को configure करने के लिए, सभी built-in formatter में एक comparer constructor overload होता है। आप आसानी से custom equality-comparer formatter बना सकते हैं।

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

`BitPackFormatter` केवल `bool[]` प्रकार को compress करता है। `bool[]` आमतौर पर प्रत्येक boolean मान के लिए 1 बाइट के रूप में serialize होता है, लेकिन `BitPackFormatter` `bool[]` को एक `BitArray` की तरह serialize करता है, जिसमें प्रत्येक bool को 1 बिट के रूप में संग्रहित किया जाता है। `BitPackFormatter` का उपयोग करने पर, 8 bools = 1 बाइट, जबकि सामान्यतः 8 बाइट होते, जिससे आकार 8 गुना कम हो जाता है।

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` `byte[]` के लिए है, उदाहरण के लिए आप Brotli द्वारा बड़े payload को compress कर सकते हैं।

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` `string` के लिए है, Brotli द्वारा compressed string (UTF16) को serialize करता है।

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```
`BrotliFormatter<T>` किसी भी प्रकार के लिए है, ब्रोटली द्वारा संपीड़ित सीरियलाइज़्ड डेटा के लिए। यदि प्रकार `byte[]` या `string` है, तो प्रदर्शन के लिए आपको `BrotliFormatter` या `BrotliStringFormatter` का उपयोग करना चाहिए।

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

एरे पूलिंग को डिसीरियलाइज़ करना
---
किसी बड़े एरे (किसी भी `T`) को डिसीरियलाइज़ करने के लिए, MemoryPack कई कुशल पूलिंग विधियाँ प्रदान करता है। सबसे प्रभावी तरीका है [#Overwrite](#overwrite) फ़ंक्शन का उपयोग करना। विशेष रूप से `List<T>` हमेशा पुन: उपयोग होती है।

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> पुन: उपयोग होती है, डिसीरियलाइज़ में कोई आवंटन नहीं।
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// कुशल संचालन के लिए, आप CollectionsMarshal द्वारा Span<T> प्राप्त कर सकते हैं
var span = CollectionsMarshal.AsSpan(value.Payload);
```

एक सुविधाजनक तरीका है डिसीरियलाइज़ के समय ArrayPool में डिसीरियलाइज़ करना। MemoryPack `MemoryPoolFormatter<T>` और `ReadOnlyMemoryPoolFormatter<T>` प्रदान करता है।

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

    // आपको return कोड स्वयं लिखना होगा, यहाँ स्निपेट है।

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
    // कुछ भी करें...
}   // ArrayPool में वापस करें
```

प्रदर्शन
---
मेरा ब्लॉग पोस्ट देखें [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

पेलोड आकार और संपीड़न
---
पेलोड आकार लक्ष्य मान पर निर्भर करता है; JSON के विपरीत, इसमें कोई कुंजी नहीं होती और यह एक बाइनरी फॉर्मेट है, इसलिए पेलोड आकार JSON से छोटा होने की संभावना है।

उनके लिए जिनमें varint एन्कोडिंग है, जैसे MessagePack और Protobuf, यदि बहुत अधिक int का उपयोग किया गया हो तो MemoryPack बड़ा हो सकता है (MemoryPack में, int हमेशा 4 बाइट होते हैं फिक्स्ड साइज एन्कोडिंग के कारण, जबकि MessagePack में 1~5 बाइट होते हैं)।

float और double MemoryPack में 4 बाइट और 8 बाइट हैं, लेकिन MessagePack में 5 बाइट और 9 बाइट हैं। तो उदाहरण के लिए, Vector3 (float, float, float) एरे के लिए MemoryPack छोटा होता है।

String डिफ़ॉल्ट रूप से UTF8 है, जो अन्य सीरियलाइज़र्स के समान है, लेकिन यदि UTF16 विकल्प चुना जाता है, तो यह अलग प्रकार का होगा।

किसी भी स्थिति में, यदि पेलोड आकार बड़ा है, तो संपीड़न पर विचार किया जाना चाहिए। LZ4, ZStandard और Brotli अनुशंसित हैं।

### संपीड़न

MemoryPack [Brotli](https://github.com/google/brotli) संपीड़न के लिए [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) और [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder) के माध्यम से एक कुशल हेल्पर प्रदान करता है। MemoryPack के `BrotliCompressor` और `BrotliDecompressor` MemoryPack के आंतरिक व्यवहार के लिए अनुकूलित संपीड़न/डिसम्प्रेशन प्रदान करते हैं।

```csharp
using MemoryPack.Compression;

// Compression(आवश्यक using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// संपीड़ित byte[] प्राप्त करें
var compressedBytes = compressor.ToArray();

// या अन्य IBufferWriter<byte> में लिखें (जैसे PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Decompression(आवश्यक using)
using var decompressor = new BrotliDecompressor();

// ReadOnlySpan<byte> या ReadOnlySequence<byte> से डिसम्प्रेस्ड ReadOnlySequence<byte> प्राप्त करें
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

दोनों `BrotliCompressor` और `BrotliDecompressor` struct हैं, यह heap पर मेमोरी आवंटित नहीं करते। दोनों Serialize/Deserialize के लिए डेटा को एक आंतरिक मेमोरी पूल में संग्रहित करते हैं। इसलिए, मेमोरी पूलिंग को रिलीज़ करना आवश्यक है, `using` का उपयोग करना न भूलें।

संपीड़न स्तर बहुत महत्वपूर्ण है। डिफ़ॉल्ट रूप से quality-1 (CompressionLevel.Fastest) सेट किया गया है, जो .NET डिफ़ॉल्ट (CompressionLevel.Optimal, quality-4) से अलग है।

Fastest (quality-1) की गति [LZ4](https://github.com/lz4/lz4) के करीब होगी, लेकिन 4 बहुत धीमा है। यह सीरियलाइज़र उपयोग परिदृश्य में महत्वपूर्ण पाया गया। मानक `BrotliStream` का उपयोग करते समय सावधान रहें (डिफ़ॉल्ट quality-4 है)। किसी भी स्थिति में, संपीड़न/डिसम्प्रेशन की गति और आकार अलग-अलग डेटा के लिए बहुत भिन्न होंगे। कृपया अपने एप्लिकेशन द्वारा उपयोग किए जाने वाले डेटा के साथ स्वयं परीक्षण करें।

ध्यान दें कि MemoryPack के असंपीड़ित और Brotli के संपीड़न के बीच कई गुना गति दंड है।

Brotli कस्टम फ़ॉर्मेटर में भी समर्थित है। `BrotliFormatter` किसी विशिष्ट सदस्य को संपीड़ित कर सकता है।

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

बाहरी प्रकारों को सीरियलाइज़ करें
---
यदि आप बाहरी प्रकारों को सीरियलाइज़ करना चाहते हैं, तो आप एक कस्टम फ़ॉर्मेटर बना सकते हैं और उसे प्रोवाइडर में रजिस्टर कर सकते हैं, विवरण के लिए देखें [Formatter/Provider API](#formatterprovider-api)। हालांकि, एक कस्टम फ़ॉर्मेटर बनाना कठिन है। इसलिए, हम एक रैपर टाइप बनाने की सलाह देते हैं। उदाहरण के लिए, यदि आप `AnimationCurve` नामक बाहरी प्रकार को सीरियलाइज़ करना चाहते हैं।

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

रैप करने के लिए प्रकार सार्वजनिक है, लेकिन सीरियलाइज़ेशन से बाहर रखा गया है (`MemoryPackIgnore`)। जिन गुणों को आप सीरियलाइज़ करना चाहते हैं वे निजी हैं, लेकिन शामिल किए गए हैं (`MemoryPackInclude`)। दो प्रकार के कन्स्ट्रक्टर भी तैयार किए जाने चाहिए। सीरियलाइज़र द्वारा उपयोग किया जाने वाला कन्स्ट्रक्टर निजी होना चाहिए।

जैसा है, इसे हर बार रैप करना होगा, जो असुविधाजनक है। और साथ ही struct wrapper null को निरूपित नहीं कर सकता। तो आइए एक कस्टम फ़ॉर्मेटर बनाते हैं।

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity scoped और TBufferWriter को सपोर्ट नहीं करता, इसलिए signature बदलें `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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
        reader.Advance(1); // null ब्लॉक को छोड़ें
        value = null;
        return;
    }
    
    var wrapped = reader.ReadPackable<SerializableAnimationCurve>();
    value = wrapped.AnimationCurve;
}
```

अंत में, स्टार्टअप में फॉर्मेटर को रजिस्टर करें।

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> नोट: Unity की AnimationCurve डिफ़ॉल्ट रूप से सीरियलाइज़ेबल है इसलिए AnimationCurve के लिए इस कस्टम फॉर्मेटर की आवश्यकता नहीं है।

Packages
---
MemoryPack के ये पैकेज हैं।

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` मुख्य लाइब्रेरी है, यह बाइनरी ऑब्जेक्ट्स के हाई परफॉर्मेंस सीरियलाइज़ेशन और डीसीरियलाइज़ेशन के लिए पूरी सपोर्ट प्रदान करता है। यह `MemoryPack.Core` पर बेस लाइब्रेरीज़ के लिए और `MemoryPack.Generator` पर कोड जेनरेशन के लिए निर्भर करता है। `MemoryPack.Streaming` [Streaming Serialization](#streaming-serialization) के लिए अतिरिक्त एक्सटेंशन जोड़ता है।  `MemoryPack.AspNetCoreMvcFormatter` ASP.NET Core के लिए इनपुट/आउटपुट फॉर्मेटर्स जोड़ता है। `MemoryPack.UnityShims` .NET और Unity के बीच साझा किए जाने वाले टाइप्स के लिए Unity शिम टाइप्स और फॉर्मेटर्स जोड़ता है।

TypeScript और ASP.NET Core Formatter
---
MemoryPack TypeScript कोड जेनरेशन सपोर्ट करता है। यह C# से क्लास और सीरियलाइज़ेशन कोड जेनरेट करता है, दूसरे शब्दों में, आप OpenAPI, proto, आदि का उपयोग किए बिना ब्राउज़र के साथ टाइप्स साझा कर सकते हैं।

कोड जेनरेशन Source Generator के साथ इंटीग्रेटेड है, निम्नलिखित विकल्प (`MemoryPackGenerator_TypeScriptOutputDirectory`) TypeScript कोड के लिए आउटपुट डायरेक्टरी सेट करते हैं। रनटाइम कोड भी एक ही समय पर आउटपुट होता है, इसलिए कोई अतिरिक्त डिपेंडेंसी आवश्यक नहीं है।

```xml
<!-- मेमोरीपैक TypeScript कोड को डायरेक्टरी में आउटपुट करें -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

एक C# MemoryPackable टाइप को `[GenerateTypeScript]` के साथ एनोटेट किया जाना चाहिए।

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

रनटाइम कोड और TypeScript टाइप लक्ष्य डायरेक्टरी में जेनरेट हो जाएंगे।

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

जेनरेट किया गया कोड निम्नानुसार है, जिसमें सरल फील्ड्स और serialize/serializeArray व deserialize/deserializeArray के लिए स्टैटिक मेथड्स होते हैं।

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

आप इस टाइप का उपयोग निम्नानुसार कर सकते हैं।

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// Uint8Array में सीरियलाइज़ करें
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// ArrayBuffer से डीसीरियलाइज़ करें 
let person2 = Person.deserialize(buffer);
```

`MemoryPack.AspNetCoreMvcFormatter` पैकेज ASP.NET Core MVC के लिए `MemoryPack` इनपुट और आउटपुट फॉर्मेटर जोड़ता है। आप निम्नलिखित कोड के साथ ASP.NET Core MVC में `MemoryPackInputFormatter`, `MemoryPackOutputFormatter` जोड़ सकते हैं।

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // यदि checkContentType: true है तो मल्टीपल फॉर्मेट (JSON/MemoryPack, आदि) आउटपुट कर सकते हैं। डिफ़ॉल्ट false है।
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

यदि आप HttpClient से कॉल करते हैं, तो आप कंटेंट-हेडर में `application/x-memorypack` सेट कर सकते हैं।

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### TypeScript टाइप मैपिंग

उन टाइप्स पर कुछ प्रतिबंध हैं जिन्हें जेनरेट किया जा सकता है। प्रिमिटिव्स में, `char` और `decimal` समर्थित नहीं हैं। इसके अलावा, OpenGenerics टाइप का उपयोग नहीं किया जा सकता।

|  C#  |  TypeScript  | विवरण |
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
| `Guid` |  `string`  | TypeScript में string के रूप में प्रस्तुत किया जाता है, लेकिन 16 बाइट बाइनरी के रूप में serialize/deserialize होता है
| `DateTime` | `Date` | DateTimeKind को अनदेखा किया जाएगा
| `enum` | `const enum` | `long` और `ulong` आधारभूत प्रकार समर्थित नहीं हैं
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | सभी `ICollection<T>` लागू प्रकार जैसे `List<T>` को समर्थन करता है
| `: ISet<T>` | `Set<T> \| null` | सभी `ISet<T>` लागू प्रकार जैसे `HashSet<T>` को समर्थन करता है
| `: IDictionary<K,V>` | `Map<K, V> \| null` | सभी `IDictionary<K,V>` लागू प्रकार जैसे `Dictionary<K,V>` को समर्थन करता है।
| `[MemoryPackable]` | `class` | केवल class को समर्थन करता है
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` केवल classes पर लागू किया जा सकता है और वर्तमान में struct द्वारा समर्थित नहीं है।

### इम्पोर्ट फाइल एक्सटेंशन और सदस्य नाम केसिंग कॉन्फ़िगर करें

डिफ़ॉल्ट रूप में, MemoryPack फाइल एक्सटेंशन को `.js` के रूप में जेनरेट करता है जैसे कि `import { MemoryPackWriter } from "./MemoryPackWriter.js";`। यदि आप कोई अन्य एक्सटेंशन या खाली रखना चाहते हैं, तो इसे कॉन्फ़िगर करने के लिए `MemoryPackGenerator_TypeScriptImportExtension` का उपयोग करें।
साथ ही सदस्य नाम अपने आप camelCase में बदल जाता है। यदि आप मूल नाम का उपयोग करना चाहते हैं, तो `MemoryPackGenerator_TypeScriptConvertPropertyName` को `false` पर सेट करें।

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- खाली रखना संभव है -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- डिफ़ॉल्ट true है -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- डिफ़ॉल्ट false है -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` C# nullable एनोटेशन को TypeScript कोड में प्रतिबिंबित करने की अनुमति देता है। डिफ़ॉल्ट रूप से false है, जिससे सब कुछ nullable बन जाता है।

Streaming Serialization
---
`MemoryPack.Streaming` `MemoryPackStreamingSerializer` प्रदान करता है, जो streams के साथ collections को serialize और deserialize करने के लिए अतिरिक्त समर्थन जोड़ता है।

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
यदि आप formatter को मैन्युअली लागू करना चाहते हैं, तो `MemoryPackFormatter<T>` से इनहेरिट करें और `Serialize` और `Deserialize` मेथड्स को override करें।

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

        // writer मेथड का उपयोग करें।
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // reader मेथड का उपयोग करें।
    }
}
```
बनाए गए formatter को `MemoryPackFormatterProvider` के साथ रजिस्टर किया जाता है।

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

नोट: `unmanged struct` (जिसमें कोई reference types नहीं हैं) कस्टम formatter का उपयोग नहीं कर सकते, यह हमेशा native memory layout को serialize करता है।

MemoryPackWriter/ReaderOptionalState
---
`MemoryPackWriter`/`MemoryPackReader` को इनिशियलाइज़ करने के लिए OptionalState की आवश्यकता होती है। यह `MemoryPackSerializerOptions` का wrapper है, जिसे `MemoryPackWriterOptionalStatePool` से बनाया जा सकता है।

```csharp
// जब dispose किया जाएगा, OptionalState pool में वापस चला जाएगा।
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// Reader के लिए
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

Target framework dependency
---
MemoryPack `netstandard2.1` और `net7.0` प्रदान करता है, लेकिन दोनों संगत नहीं हैं। उदाहरण के लिए, यदि आप `netstandard2.1` प्रोजेक्ट के तहत MemoryPackable types का उपयोग करते हैं और उसे `net7.0` प्रोजेक्ट से उपयोग करते हैं, तो रनटाइम exception मिलेगा, जैसे:

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

चूंकि net7.0 static abstract members (`Virtual static method`) का उपयोग करता है, जो netstandard2.1 में समर्थित नहीं है, यह व्यवहार एक विशेषता है।

.NET 7 प्रोजेक्ट को netstandard 2.1 dll का उपयोग नहीं करना चाहिए। दूसरे शब्दों में, यदि एप्लिकेशन .NET 7 प्रोजेक्ट है, तो सभी dependencies जिन्हें MemoryPack का उपयोग करना है, उन्हें .NET 7 को समर्थन करना चाहिए। इसलिए यदि किसी लाइब्रेरी डेवलपर की dependency MemoryPack पर है, तो आपको dual target framework कॉन्फ़िगर करना होगा।

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) एक code-first grpc-dotnet framework है, जो protobuf के बजाय MessagePack का उपयोग करता है। MagicOnion अब MemoryPack को serialization layer के रूप में `MagicOnion.Serialization.MemoryPack` पैकेज (preview) के माध्यम से समर्थन करता है। विवरण देखें: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

न्यूनतम समर्थित Unity संस्करण `2022.3.12f1` है।

`MemoryPack` कोर पैकेज nuget द्वारा प्रदान किया गया है। यह Unity में भी उपलब्ध है। यदि आप Unity बिल्ट-इन टाइप समर्थन प्राप्त करना चाहते हैं, तो हम अतिरिक्त रूप से MemoryPack.Unity एक्सटेंशन प्रदान करते हैं।

1. [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) का उपयोग कर NuGet से `MemoryPack` इंस्टॉल करें

* NuGet -> Manage NuGet Packages विंडो खोलें, "MemoryPack" सर्च करें और Install दबाएं।
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* यदि आपको version conflicts error मिलता है, तो कृपया Player Settings (Edit -> Project Settings -> Player -> नीचे स्क्रॉल करें और "Other Settings" को विस्तार करें, फिर "Configuration" सेक्शन के तहत "Assembly Version Validation" को अनचेक करें) में version validation को disable करें।

2. git URL का संदर्भ देकर `MemoryPack.Unity` पैकेज इंस्टॉल करें

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack *.*.* रिलीज़ टैग का उपयोग करता है, इसलिए आप एक version जैसे #1.0.0 निर्दिष्ट कर सकते हैं। उदाहरण: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


.NET संस्करण की तरह, कोड जेनरेशन एक कोड जनरेटर (`MemoryPack.Generator.dll`) द्वारा होती है। Reflection-free implementation IL2CPP में भी बेहतरीन प्रदर्शन प्रदान करता है।

Unity और Source Generator के बारे में अधिक जानकारी के लिए, कृपया [Unity documentation](https://docs.unity3d.com/Manual/roslyn-analyzers.html) देखें।

Source Generator का आधिकारिक रूप से Unity द्वारा [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) और [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html) में भी उपयोग होता है। दूसरे शब्दों में, यह अगली पीढ़ी के Unity में कोड जेनरेशन का मानक है।

आप सभी unmanaged types (जैसे कि `Vector3`, `Rect`, आदि...) और कुछ classes (`AnimationCurve`, `Gradient`, `RectOffset`) को serialize कर सकते हैं। यदि आप अन्य Unity-विशिष्ट प्रकार serialize करना चाहते हैं, तो [Serialize external types](#serialize-external-types) अनुभाग देखें।

Unity में प्रदर्शन के मामले में, MemoryPack JsonUtility से x3~x10 गुना तेज है।

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

यदि साझा कोड में Unity का type (`Vector2`, आदि...) है, तो MemoryPack NuGet में `MemoryPack.UnityShims` पैकेज प्रदान करता है।

`MemoryPack.UnityShims` पैकेज Unity के मानक structs (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) और कुछ classes (`AnimationCurve`, `Gradient`, `RectOffset`) के लिए shims प्रदान करता है।

> [!WARNING]
> वर्तमान में, Unity में उपयोग के लिए निम्नलिखित सीमाएँ हैं


1. Unity संस्करण CustomFormatter को समर्थन नहीं करता।
2. यदि आप .NET7 या बाद के संस्करण का उपयोग कर रहे हैं, तो MemoryPack बाइनरी फॉर्मेट Unity के साथ पूरी तरह संगत नहीं है।
    - यह समस्या उन value types के साथ होती है, जिनमें `[StructLayout(LayoutKind.Auto)]` स्पष्ट रूप से निर्दिष्ट है। (struct का डिफ़ॉल्ट `LayoutKind.Sequencil` होता है।) ऐसे types के लिए, .NET में serialize किया गया binary, Untiy में deserialize नहीं किया जा सकता। इसी तरह, Unity में serialize किया गया binary .NET साइड में serialize नहीं किया जा सकता।
    - प्रभावित types में आमतौर पर निम्नलिखित प्रकार शामिल हैं।
        - `DateTimeOffset`
        - `ValueTuple`
    - वर्तमान में, आसान समाधान यह है कि इन types का उपयोग न करें।


Native AOT
---
दुर्भाग्यवश, .NET 7 Native AOT में एक रनटाइम बग के कारण MemoryPack का उपयोग करते समय crash (`Generic virtual method pointer lookup failure`) होता है। यह .NET 8 में ठीक किया जाएगा। `Microsoft.DotNet.ILCompiler` के preview संस्करण का उपयोग करने से .NET 7 में इसे ठीक किया जा सकता है। कृपया [issue's comment](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) देखें कि इसे कैसे सेटअप करें।

Binary wire format specification
---
`Serialize<T>` और `Deserialize<T>` में परिभाषित `T` प्रकार को C# schema कहा जाता है। MemoryPack फॉर्मेट self-described फॉर्मेट नहीं है। Deserialize के लिए संबंधित C# schema की आवश्यकता होती है। ये types binaries के आंतरिक प्रतिनिधित्व के रूप में मौजूद होते हैं, लेकिन types C# schema के बिना निर्धारित नहीं किए जा सकते।

Endian `Little Endian` होना चाहिए। हालांकि, reference C# implementation endianness की परवाह नहीं करता, इसलिए इसे big-endian मशीन पर उपयोग नहीं किया जा सकता। हालांकि, आधुनिक कंप्यूटर आमतौर पर little-endian होते हैं।

फॉर्मेट के आठ प्रकार हैं।

* Unmanaged struct
* Object
* Version Tolerant Object
* सर्कुलर रेफरेंस ऑब्जेक्ट  
* टपल  
* कलेक्शन  
* स्ट्रिंग  
* यूनियन  

### अनमैनेज्ड स्ट्रक्चर

अनमैनेज्ड स्ट्रक्चर वह C# स्ट्रक्चर है जिसमें रेफरेंस टाइप्स नहीं होते, यह [C# अनमैनेज्ड टाइप्स](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types) जैसी कंस्ट्रेंट के समान है। स्ट्रक्चर लेआउट को जेसा है वैसा ही सीरियलाइज़ किया जाता है, जिसमें पैडिंग भी शामिल होती है।

### ऑब्जेक्ट

`(byte memberCount, [values...])`

ऑब्जेक्ट के हैडर में 1 बाइट अनसाइन्ड बाइट के रूप में मेंबर काउंट होता है। मेंबर काउंट `0` से `249` तक हो सकता है, `255` दर्शाता है कि ऑब्जेक्ट `null` है। वैल्यूज़ में मेंबर काउंट की संख्या के लिए मेमोरीपैक वैल्यू स्टोर होती है।

### वर्शन टॉलरेंट ऑब्जेक्ट

`(byte memberCount, [varint byte-length-of-values...], [values...])`

वर्शन टॉलरेंट ऑब्जेक्ट ऑब्जेक्ट के समान है, लेकिन इसमें हैडर में वैल्यूज़ की बाइट लेंथ होती है। वरिन्ट इन स्पेसिफिकेशन का पालन करता है, पहला sbyte वैल्यू या टाइपकोड होता है और अगले X बाइट वैल्यू होते हैं। 0 से 127 = अनसाइन्ड बाइट वैल्यू, -1 से -120 = साइनड बाइट वैल्यू, -121 = बाइट, -122 = स्बाइट, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long।

### सर्कुलर रेफरेंस ऑब्जेक्ट

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

सर्कुलर रेफरेंस ऑब्जेक्ट वर्शन टॉलरेंट ऑब्जेक्ट के समान है लेकिन अगर memberCount 250 है, तो अगला varint (unsigned-int32) referenceId होता है। यदि नहीं, तो byte-length-of-values के बाद varint referenceId लिखा जाता है।

### टपल

`(values...)`

टपल फिक्स्ड-साइज़, नॉन-नल वैल्यू कलेक्शन है। .NET में, `KeyValuePair<TKey, TValue>` और `ValueTuple<T,...>` को टपल के रूप में सीरियलाइज़ किया जाता है।

### कलेक्शन

`(int length, [values...])`

कलेक्शन के हैडर में 4 बाइट साइनड इन्टीजर के रूप में डेटा काउंट होता है, `-1` का अर्थ है `null`। वैल्यूज़ में लेंथ की संख्या के लिए मेमोरीपैक वैल्यू स्टोर होती है।

### स्ट्रिंग

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

स्ट्रिंग के दो रूप होते हैं, UTF16 और UTF8। अगर पहली 4-बाइट साइनड इन्टीजर `-1` है, तो यह null दर्शाता है। `0` का अर्थ है खाली। UTF16 कलेक्शन के समान है (`ReadOnlySpan<char>` के रूप में सीरियलाइज़), utf16-value के बाइट काउंट = utf16-length * 2। अगर पहली साइनड इन्टीजर <= `-2`, तो वैल्यू UTF8 में एन्कोड की जाती है। utf8-byte-count कंप्लीमेंट में एन्कोडेड है, बाइट्स की गिनती प्राप्त करने के लिए `~utf8-byte-count`। अगला साइनड इन्टीजर utf16-length है, यह `-1` हो सकता है जो अज्ञात लंबाई दर्शाता है। utf8-bytes में utf8-byte-count की संख्या के लिए बाइट्स स्टोर होती हैं।

### यूनियन

`(byte tag, value)`  
`(250, ushort tag, value)`

पहली अनसाइन्ड बाइट टैग है जो डिस्क्रिमिनेटेड वैल्यू टाइप या फ्लैग के लिए है, `0` से `249` टैग दर्शाते हैं, `250` दर्शाता है कि अगला अनसाइन्ड शॉर्ट टैग है, `255` दर्शाता है कि यूनियन `null` है।

License  
---  
यह लाइब्रेरी MIT लाइसेंस के तहत लाइसेंस प्राप्त है।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---