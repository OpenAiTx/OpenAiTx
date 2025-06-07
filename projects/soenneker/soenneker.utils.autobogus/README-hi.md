[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### .NET ऑटोजेनरेटर

यह प्रोजेक्ट फेक डेटा जनरेटर [Bogus](https://github.com/bchavez/Bogus) के लिए एक स्वचालित क्रिएटर और पॉप्युलेटर है। यह छोड़ी गई [AutoBogus](https://github.com/nickdodd79/AutoBogus) लाइब्रेरी के लिए एक रिप्लेसमेंट है।

लक्ष्य:
- *तेज़* होना
- .NET में नवीनतम टाइप्स का समर्थन करना

यह सबसे तेज़ .NET रिफ्लेक्शन कैश का उपयोग करता है: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache)। Bogus अपडेट्स स्वचालित रूप से एकीकृत हो जाते हैं।

.NET 8+ समर्थित है।

## इंस्टॉलेशन

```
dotnet add package Soenneker.Utils.AutoBogus
```

## उपयोग

- एक `AutoFaker` इंस्टेंस बनाएं:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- किसी भी टाइप पर `Generate<>()` कॉल करें:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- एक आर्गुमेंट के माध्यम से टाइप भी जनरेट किए जा सकते हैं:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- एक फेकर, कॉन्फ़िगरेशन, नियम आदि सेट करें:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

यह टाइप कस्टमाइजेशन को नियंत्रित करने का अनुशंसित तरीका है:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker उपलब्ध है
        target.Name = context.Faker.Random.Word();

        // AutoFaker भी उपलब्ध है
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

फिर बस `AutoFaker.Config` इंस्टेंस में `AutoFakerOverride` जोड़ें:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

यह `Bogus.Faker` से इनहेरिट करता है, और इसका उपयोग `AutoFaker` इंस्टेंस के लिए विशिष्ट नियम निर्धारित करने हेतु किया जा सकता है।

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## इंटरफेस/एब्सट्रैक्ट्स

बेस लाइब्रेरी इंटरफेस या एब्सट्रैक्ट ऑब्जेक्ट्स को जनरेट नहीं करती, लेकिन ये आपको उनके मॉक जनरेट करने की सुविधा देती हैं:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## सुझाव
- ⚠️ एक `AutoFaker` को इनस्टैंटिएट करना Bogus `Faker` इनिशियलाइज़ेशन के कारण कुछ समय लेता है (लगभग 1ms)। यदि संभव हो तो एक ही इंस्टेंस का उपयोग करने की सिफारिश की जाती है।
- `AutoFaker.GenerateStatic<T>()` भी उपलब्ध है, लेकिन इससे बचना चाहिए (क्योंकि यह हर कॉल पर नया `AutoFaker`/`Faker` बनाता है)।

## नोट्स
- AutoBogus में मौजूद कुछ पैटर्न को जटिलता और प्रदर्शन प्रभाव के कारण हटा दिया गया है।
- यह कार्य प्रगति पर है। योगदान का स्वागत है।

## बेंचमार्क्स

### Soenneker.Utils.AutoBogus - `AutoFaker`

| मेथड            | औसत समय    | त्रुटि      | मानक विचलन |
|----------------- |-----------:|-----------:|------------:|
| Generate_int     |    79.40 ns |  0.635 ns |  0.563 ns  |
| Generate_string  |   241.35 ns |  3.553 ns |  3.324 ns  |
| Generate_complex | 6,782.34 ns | 43.811 ns | 38.837 ns  |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| मेथड            | औसत समय   | त्रुटि    | मानक विचलन |
|----------------- |----------:|---------:|------------:|
| Generate_string  |   283.6 ns |  3.28 ns |  3.07 ns   |
| Generate_complex | 8,504.0 ns | 76.58 ns | 67.89 ns   |

### AutoBogus

| मेथड            | औसत समय  | त्रुटि    | मानक विचलन |
|----------------- |---------:|---------:|------------:|
| Generate_int     |   1.17 ms | 0.033 ms | 0.026 ms   |
| Generate_complex |  10.91 ms | 0.181 ms | 0.236 ms   |

### Bogus

| मेथड        | औसत समय       | त्रुटि        | मानक विचलन   |
|------------- |-------------:|-------------:|-------------:|
| Bogus_int    |      19.70 ns |     0.176 ns |     0.165 ns |
| Bogus_string |     171.75 ns |     2.763 ns |     2.585 ns |
| Bogus_ctor   | 730,669.06 ns | 8,246.622 ns | 7,310.416 ns |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---