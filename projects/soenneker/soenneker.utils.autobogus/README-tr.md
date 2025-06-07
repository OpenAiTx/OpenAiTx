[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### .NET Otomatik Üretici 

Bu proje, sahte veri üreticisi [Bogus](https://github.com/bchavez/Bogus) için otomatik bir oluşturucu ve doldurucudur. Bırakılmış olan [AutoBogus](https://github.com/nickdodd79/AutoBogus) kütüphanesinin bir yerine geçme çözümüdür.

Hedefler:
- *Hızlı* olmak
- .NET'teki en yeni türleri desteklemek

.NET Reflection önbelleğinin en hızlısını kullanır: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Bogus güncellemeleri otomatik olarak entegre edilir.

.NET 8+ desteklenmektedir.

## Kurulum

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Kullanım

- Bir `AutoFaker` örneği oluşturun:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Herhangi bir türde `Generate<>()` metodunu çağırın:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- Ayrıca bir argüman üzerinden tür üretmek de mümkündür:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Bir faker, konfigürasyon, kural vb. belirleyin:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

Tür özelleştirmesini kontrol etmenin önerilen yolu budur:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker kullanılabilir
        target.Name = context.Faker.Random.Word();

        // AutoFaker da kullanılabilir
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Daha sonra sadece `AutoFakerOverride`'ı `AutoFaker.Config` örneğine ekleyin:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

Bu sınıf `Bogus.Faker`'dan türetilmiştir ve `AutoFaker` örneğine özgü kuralları belirlemek için kullanılabilir.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Arayüzler/Abstractlar

Temel kütüphane arayüzleri veya soyut nesneleri üretmez, ancak bunların taklitlerini oluşturmak için aşağıdakileri kullanabilirsiniz:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## İpuçları
- ⚠️ Bir `AutoFaker` örneği oluşturmak, Bogus `Faker` başlatmasından dolayı göz ardı edilemeyecek bir süre alır (neredeyse 1ms). Mümkünse tek bir örnek kullanılması tavsiye edilir.
- `AutoFaker.GenerateStatic<T>()` da mevcuttur fakat her çağrıda yeni bir `AutoFaker`/`Faker` oluşturduğu için kaçınılmalıdır.

## Notlar
- AutoBogus'ta var olan bazı desenler, karmaşıklık ve performans etkisi nedeniyle kaldırılmıştır.
- Bu proje geliştirme aşamasındadır. Katkıda bulunmak isteyenler memnuniyetle karşılanır.

## Kıyaslamalar

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Metot           | Ortalama    | Hata      | StdSapma   |
|-----------------|------------:|----------:|-----------:|
| Generate_int    |    79.40 ns |  0.635 ns |  0.563 ns  |
| Generate_string |   241.35 ns |  3.553 ns |  3.324 ns  |
| Generate_complex| 6,782.34 ns | 43.811 ns | 38.837 ns  |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Metot           | Ortalama   | Hata     | StdSapma   |
|-----------------|-----------:|---------:|-----------:|
| Generate_string |   283.6 ns |  3.28 ns |  3.07 ns   |
| Generate_complex| 8,504.0 ns | 76.58 ns | 67.89 ns   |

### AutoBogus

| Metot           | Ortalama  | Hata    | StdSapma   |
|-----------------|----------:|--------:|-----------:|
| Generate_int    |   1.17 ms | 0.033 ms| 0.026 ms   |
| Generate_complex|  10.91 ms | 0.181 ms| 0.236 ms   |

### Bogus

| Metot        | Ortalama       | Hata         | StdSapma      |
|--------------|---------------:|-------------:|--------------:|
| Bogus_int    |      19.70 ns  |     0.176 ns |     0.165 ns  |
| Bogus_string |     171.75 ns  |     2.763 ns |     2.585 ns  |
| Bogus_ctor   | 730,669.06 ns  | 8,246.622 ns | 7,310.416 ns  |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---