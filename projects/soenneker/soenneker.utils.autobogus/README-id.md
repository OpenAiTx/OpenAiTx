[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### Autogenerator .NET

Proyek ini adalah pembuat dan pengisi otomatis untuk generator data palsu [Bogus](https://github.com/bchavez/Bogus). Ini merupakan pengganti pustaka [AutoBogus](https://github.com/nickdodd79/AutoBogus) yang sudah tidak dikembangkan lagi.

Tujuannya:
- Menjadi *cepat*
- Mendukung tipe terbaru di .NET

Menggunakan cache Reflection .NET tercepat: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Pembaruan Bogus diintegrasikan secara otomatis.

Mendukung .NET 8+.

## Instalasi

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Penggunaan

- Buat sebuah instance `AutoFaker`:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Panggil `Generate<>()` pada tipe apa pun yang Anda inginkan:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- Juga memungkinkan untuk menghasilkan tipe melalui argumen:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Atur faker, konfigurasi, aturan, dll:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

Ini adalah cara yang direkomendasikan untuk mengontrol kustomisasi tipe:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker tersedia
        target.Name = context.Faker.Random.Word();

        // AutoFaker juga tersedia
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Kemudian cukup tambahkan `AutoFakerOverride` ke instance `AutoFaker.Config`:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

Ini merupakan turunan dari `Bogus.Faker`, dan dapat digunakan untuk menetapkan aturan khusus pada instance `AutoFaker`.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Interface/Abstrak

Pustaka dasar tidak menghasilkan interface atau objek abstrak, tetapi berikut ini memungkinkan Anda untuk menghasilkan mock-nya:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## Tips
- ⚠️ Membuat sebuah instance `AutoFaker` memerlukan waktu yang tidak sepele karena inisialisasi `Faker` dari Bogus (hampir 1ms). Disarankan menggunakan satu instance saja jika memungkinkan.
- `AutoFaker.GenerateStatic<T>()` juga tersedia, namun sebaiknya dihindari (karena membuat `AutoFaker`/`Faker` baru setiap kali dipanggil).

## Catatan
- Beberapa pola yang ada di AutoBogus telah dihapus karena kompleksitas dan dampak kinerja.
- Ini adalah proyek yang masih dikembangkan. Kontribusi sangat diterima.

## Benchmark

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| Generate_int     |    79.40 ns |  0.635 ns |  0.563 ns |
| Generate_string  |   241.35 ns |  3.553 ns |  3.324 ns |
| Generate_complex | 6,782.34 ns | 43.811 ns | 38.837 ns |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Method           | Mean       | Error    | StdDev   |
|----------------- |-----------:|---------:|---------:|
| Generate_string  |   283.6 ns |  3.28 ns |  3.07 ns |
| Generate_complex | 8,504.0 ns | 76.58 ns | 67.89 ns |

### AutoBogus

| Method           | Mean      | Error    | StdDev   |
|----------------- |----------:|---------:|---------:|
| Generate_int     |   1.17 ms | 0.033 ms | 0.026 ms |
| Generate_complex |  10.91 ms | 0.181 ms | 0.236 ms |

### Bogus

| Method       | Mean          | Error        | StdDev       |
|------------- |--------------:|-------------:|-------------:|
| Bogus_int    |      19.70 ns |     0.176 ns |     0.165 ns |
| Bogus_string |     171.75 ns |     2.763 ns |     2.585 ns |
| Bogus_ctor   | 730,669.06 ns | 8,246.622 ns | 7,310.416 ns |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---