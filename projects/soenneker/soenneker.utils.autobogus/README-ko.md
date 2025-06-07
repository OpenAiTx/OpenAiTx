[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### .NET 자동 생성기

이 프로젝트는 가짜 데이터 생성기인 [Bogus](https://github.com/bchavez/Bogus)를 위한 자동 생성 및 채움 도구입니다. 이는 더 이상 유지되지 않는 [AutoBogus](https://github.com/nickdodd79/AutoBogus) 라이브러리의 대체품입니다.

목표:
- *빠른* 성능
- .NET의 최신 타입 지원

.NET에서 가장 빠른 Reflection 캐시인 [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache)를 사용합니다. Bogus 업데이트는 자동으로 통합됩니다.

.NET 8+을 지원합니다.

## 설치

```
dotnet add package Soenneker.Utils.AutoBogus
```

## 사용법

- `AutoFaker` 인스턴스를 생성합니다:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- 원하는 타입에 대해 `Generate<>()`를 호출합니다:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- 인자를 통해 타입을 생성할 수도 있습니다:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- faker, 설정, 규칙 등을 지정할 수 있습니다:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

타입 커스터마이징을 제어하는 권장 방식입니다:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker 사용 가능
        target.Name = context.Faker.Random.Word();

        // AutoFaker도 사용 가능
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

그런 다음 `AutoFakerOverride`를 `AutoFaker.Config` 인스턴스에 추가합니다:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

이는 `Bogus.Faker`를 상속하며, `AutoFaker` 인스턴스에 특정한 규칙을 지정할 때 사용할 수 있습니다.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## 인터페이스/추상 클래스

기본 라이브러리는 인터페이스나 추상 객체를 생성하지 않지만, 다음 패키지를 통해 이들의 mock을 생성할 수 있습니다:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## 팁
- ⚠️ `AutoFaker` 인스턴스화는 Bogus `Faker` 초기화 때문에 시간이 다소 소요됩니다(거의 1ms). 가능하다면 단일 인스턴스 사용을 권장합니다.
- `AutoFaker.GenerateStatic<T>()`도 제공되지만, 호출 시마다 새로운 `AutoFaker`/`Faker`가 생성되므로 사용을 피하는 것이 좋습니다.

## 참고사항
- AutoBogus에 있던 일부 패턴들은 복잡성과 성능 저하로 인해 제거되었습니다.
- 현재 개발 중인 프로젝트입니다. 기여를 환영합니다.

## 벤치마크

### Soenneker.Utils.AutoBogus - `AutoFaker`

| 메서드           | 평균        | 오차     | 표준편차    |
|----------------- |------------:|----------:|----------:|
| Generate_int     |    79.40 ns |  0.635 ns |  0.563 ns |
| Generate_string  |   241.35 ns |  3.553 ns |  3.324 ns |
| Generate_complex | 6,782.34 ns | 43.811 ns | 38.837 ns |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| 메서드           | 평균       | 오차    | 표준편차   |
|----------------- |-----------:|---------:|---------:|
| Generate_string  |   283.6 ns |  3.28 ns |  3.07 ns |
| Generate_complex | 8,504.0 ns | 76.58 ns | 67.89 ns |

### AutoBogus

| 메서드           | 평균      | 오차    | 표준편차   |
|----------------- |----------:|---------:|---------:|
| Generate_int     |   1.17 ms | 0.033 ms | 0.026 ms |
| Generate_complex |  10.91 ms | 0.181 ms | 0.236 ms |

### Bogus

| 메서드       | 평균          | 오차        | 표준편차       |
|------------- |--------------:|-------------:|-------------:|
| Bogus_int    |      19.70 ns |     0.176 ns |     0.165 ns |
| Bogus_string |     171.75 ns |     2.763 ns |     2.585 ns |
| Bogus_ctor   | 730,669.06 ns | 8,246.622 ns | 7,310.416 ns |


---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---