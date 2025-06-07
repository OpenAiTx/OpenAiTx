[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### Bộ sinh tự động cho .NET

Dự án này là một công cụ tự động tạo và điền dữ liệu giả cho trình tạo dữ liệu giả [Bogus](https://github.com/bchavez/Bogus). Đây là một sự thay thế cho thư viện [AutoBogus](https://github.com/nickdodd79/AutoBogus) đã bị bỏ rơi.

Mục tiêu:
- *Nhanh*
- Hỗ trợ các kiểu dữ liệu mới nhất trong .NET

Nó sử dụng bộ nhớ đệm Reflection .NET nhanh nhất: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Các bản cập nhật của Bogus sẽ được tích hợp tự động.

Hỗ trợ .NET 8+.

## Cài đặt

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Sử dụng

- Tạo một instance của `AutoFaker`:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Gọi `Generate<>()` trên bất kỳ kiểu nào bạn muốn:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- Cũng có thể sinh kiểu dữ liệu qua đối số:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Thiết lập faker, cấu hình, quy tắc, v.v:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

Đây là cách khuyến nghị để kiểm soát việc tuỳ chỉnh kiểu dữ liệu:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker có sẵn
        target.Name = context.Faker.Random.Word();

        // AutoFaker cũng có sẵn
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Sau đó chỉ cần thêm `AutoFakerOverride` vào instance `AutoFaker.Config`:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

Lớp này kế thừa từ `Bogus.Faker`, và có thể được sử dụng để định nghĩa các quy tắc riêng cho instance `AutoFaker`.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Interface/Lớp trừu tượng

Thư viện gốc không sinh interface hoặc đối tượng trừu tượng, nhưng các package sau cho phép bạn sinh mock cho chúng:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## Mẹo
- ⚠️ Khởi tạo một `AutoFaker` tốn một lượng thời gian không nhỏ do quá trình khởi tạo `Faker` của Bogus (gần 1ms). Khuyến nghị nên sử dụng một instance duy nhất nếu có thể.
- `AutoFaker.GenerateStatic<T>()` cũng có sẵn, nhưng nên tránh sử dụng (vì nó tạo mới một `AutoFaker`/`Faker` mỗi lần gọi).

## Lưu ý
- Một số pattern từng tồn tại trong AutoBogus đã bị loại bỏ do độ phức tạp và ảnh hưởng hiệu năng.
- Dự án đang trong quá trình phát triển. Hoan nghênh đóng góp.

## Benchmark

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Phương thức      | Mean        | Sai số    | Độ lệch chuẩn |
|----------------- |------------:|----------:|--------------:|
| Generate_int     |    79.40 ns |  0.635 ns |    0.563 ns   |
| Generate_string  |   241.35 ns |  3.553 ns |    3.324 ns   |
| Generate_complex | 6,782.34 ns | 43.811 ns |   38.837 ns   |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Phương thức      | Mean       | Sai số    | Độ lệch chuẩn |
|----------------- |-----------:|----------:|--------------:|
| Generate_string  |   283.6 ns |  3.28 ns  |    3.07 ns    |
| Generate_complex | 8,504.0 ns | 76.58 ns  |   67.89 ns    |

### AutoBogus

| Phương thức      | Mean      | Sai số    | Độ lệch chuẩn |
|----------------- |----------:|----------:|--------------:|
| Generate_int     |   1.17 ms | 0.033 ms  |   0.026 ms    |
| Generate_complex |  10.91 ms | 0.181 ms  |   0.236 ms    |

### Bogus

| Phương thức   | Mean          | Sai số        | Độ lệch chuẩn   |
|-------------- |--------------:|--------------:|----------------:|
| Bogus_int     |      19.70 ns |     0.176 ns  |     0.165 ns    |
| Bogus_string  |     171.75 ns |     2.763 ns  |     2.585 ns    |
| Bogus_ctor    | 730,669.06 ns | 8,246.622 ns  | 7,310.416 ns    |


---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---