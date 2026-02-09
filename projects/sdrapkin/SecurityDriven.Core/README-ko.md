# **CryptoRandom** [![GitHub Actions](https://github.com/sdrapkin/SecurityDriven.Core/workflows/.NET%20CI/badge.svg)](https://github.com/sdrapkin/SecurityDriven.Core/actions) [![NuGet](https://img.shields.io/nuget/v/CryptoRandom.svg)](https://www.nuget.org/packages/CryptoRandom/)

### by [Stan Drapkin](https://github.com/sdrapkin/)

## **CryptoRandom** : 랜덤

* **올바르게 구현된 .NET Random**
* [빠름], [스레드 안전], [암호학적으로 강함]: 3가지 모두 선택 가능
* `System.Random`의 서브클래스이자 대체품
* `System.Security.Cryptography.RandomNumberGenerator`도 대체 ([링크](https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.randomnumbergenerator))
* `CryptoRandom`은 (`System.Random`과 달리):
	* **빠름** (`Random` 또는 `RandomNumberGenerator`보다 훨씬 빠름)
	* **스레드 안전** (모든 API)
	* **암호학적으로 강함** (시드 유무 모두 가능)
* 시드된 `CryptoRandom`에 대해 [Fast-Key-Erasure](https://blog.cr.yp.to/20170723-random.html) RNG 구현
* *모든* .NET 버전에서 시드된 `CryptoRandom` 값의 *동일한* 시퀀스 생성 (`Random`과 달리)
* 시드가 없는 경우에는 `RandomNumberGenerator`를 래핑 (추가적인 스마트 기능 포함)
* *역추적 방지(backtracking resistance)* 제공: 내부 상태로부터 출력값 복구 불가
* 약 1.3cpb (cycles-per-byte) 성능 달성, [AES-NI](https://en.wikipedia.org/wiki/AES_instruction_set)와 유사
* CPU/코어별 확장 가능
* 예시: `CryptoRandom.NextGuid()` vs. `Guid.NewGuid()` [BenchmarkDotNet]:
	* Windows-x64에서 4~5배 빠름
	* Linux-x64에서 5~30배 빠름
	* Linux-ARM64 (AWS Graviton-2)에서 4~5배 빠름
* .NET 5.0+ 및 6.0+용으로 제작
* 광범위한 테스트 커버리지 및 정확성 검증 (110개 이상의 테스트)
	* CI는 Linux-latest 및 Windows-latest에서 .NET 5/6/7/8/9/10 대상으로 실행

---
## **CryptoRandom API**:
* `System.Random`의 모든 API ([링크](https://docs.microsoft.com/en-us/dotnet/api/system.random))
* 편의를 위한 `CryptoRandom.Shared` 정적 공유 인스턴스 제공 (물론 스레드 안전)
* 시드 생성자:
	* `CryptoRandom(ReadOnlySpan<byte> seedKey)`
	* `CryptoRandom(int Seed)` (`Random` 시드 생성자와 동일)
* `byte[] NextBytes(int count)`
* `Guid NextGuid()`
	* Windows에서 `Guid.NewGuid()`보다 5배 (500%) 빠름
	* Linux에서 `Guid.NewGuid()`보다 15배 (1500%) 빠름
	* 122비트 대신 128비트 랜덤 생성
* `Guid SqlServerGuid()`
	* SQL-서버 클러스터 키로 사용하기에 적합한 새 Guid 반환
	* Guid 구조는 `[8 바이트의 랜덤][8 바이트의 SQL-서버 정렬된 DateTime.UtcNow]`
	* 각 Guid는 100나노초 `UtcNow` 정밀도 한계 내에서 순차적이어야 함
	* 합리적인 추측 불가능성과 온라인 무차별 대입 공격 방지를 위한 64비트 엔트로피
	* `Guid.NewGuid()`보다 약 15% 빠름
* `long NextInt64()`
* `long NextInt64(long maxValue)`
* `long NextInt64(long minValue, long maxValue)`
* 랜덤 `struct` (작업에 대해 확실히 이해하고 사용하세요):
	* `void Next<T>(ref T @struct) where T : unmanaged`
	* `T Next<T>() where T : unmanaged`
---
## **Utils API** (`SecurityDriven.Core.Utils`):
* `static Span<byte> AsSpan<T>(ref T @struct) where T : unmanaged`
	* 관리되지 않는 struct T를 동등한 `Span<byte>`로 캐스팅
* `static ref T AsStruct<T>(Span<byte> span) where T : unmanaged`
	* `Span<byte>`를 동등한 관리되지 않는 struct T로 캐스팅
* `int StructSizer<T>.Size`
	* struct T의 바이트 크기 반환

---
## **빠른 벤치마크**:
```csharp
using SecurityDriven.Core;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

Console.WriteLine($"[{RuntimeInformation.FrameworkDescription}]");
Stopwatch sw1 = new(), sw2 = new();
const long ITER = 100_000_000, REPS = 5;

for (int i = 0; i++ < REPS;)
{
    sw1.Restart();
    Parallel.For(0, ITER, static i => CryptoRandom.Shared.NextGuid());
    sw1.Stop();
    Console.WriteLine($"{sw1.Elapsed} cryptoRandom.NextGuid()");

    sw2.Restart();
    Parallel.For(0, ITER, static i => Guid.NewGuid());
    sw2.Stop();

    var ratio = sw2.Elapsed / sw1.Elapsed;
    Console.WriteLine($"{sw2.Elapsed} Guid.NewGuid() [{ratio:N2}x slower]");
}
```
```csharp
Output:
[.NET 6.0.0-rc.1.21451.13]
00:00:00.5486513 cryptoRandom.NextGuid()
00:00:02.0587652 Guid.NewGuid() [3.75x slower]
00:00:00.4117180 cryptoRandom.NextGuid()
00:00:02.0485556 Guid.NewGuid() [4.98x slower]
00:00:00.4103378 cryptoRandom.NextGuid()
00:00:02.0534771 Guid.NewGuid() [5.00x slower]
00:00:00.4100701 cryptoRandom.NextGuid()
00:00:02.0823213 Guid.NewGuid() [5.08x slower]
00:00:00.4017192 cryptoRandom.NextGuid()
00:00:02.0488105 Guid.NewGuid() [5.10x slower]
```
---
## **`Random`과 `RandomNumberGenerator`의 문제점은 무엇인가요?**
* `Random`은 느리고 스레드에 안전하지 않으며(동시 접근 시 심각하게 실패하고 조용히 오류가 발생함)
* `Random`은 잘못 구현되어 있음:
```csharp
Random r = new Random(); // new CryptoRandom();
const int mod = 2;
int[] hist = new int[mod];
for (int i = 0; i < 10000000; i++)
{
	int num = r.Next(0x55555555);
	int num2 = num % 2;
	++hist[num2];
}
for (int i = 0; i < mod; i++)
	Console.WriteLine($"{i}: {hist[i]}");
// Run this on .NET 5 or below. Surprised? Now change to CryptoRandom
// Fails on .NET 6 if you use seeded "new Random(seed)"
```
* `Random`/.NET 6 시드 없이 빠름(새로운 알고리즘), 안전한 `.Shared` 속성 제공, 하지만 인스턴스는 스레드 안전하지 않음  
* `Random`/.NET 6 시드 있는 경우 느린 레거시 비스레드 안전 .NET 알고리즘으로 대체됨  
* 두 `Random` 구현 모두 암호학적으로 강력한 결과를 목표로 하지 않음  
* `RandomNumberGenerator`는 지능적인 래핑과 더 유용한 `Random` API로 훨씬 빠를 수 있음  

---  
## **처리량(단일 스레드) .NET 6:**
```csharp
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host] : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT
```
|             Method | BYTES |         Mean |       Error |     StdDev | Ratio | RatioSD | Throughput |
|------------------- |------ |-------------:|------------:|-----------:|------:|--------:|-----------:|
|       SystemRandom |    32 |     7.483 μs |   0.2714 μs |  0.0149 μs |  0.21 |    0.00 | 4,176 MB/s |
| SystemSharedRandom |    32 |    13.197 μs |   3.3861 μs |  0.1856 μs |  0.38 |    0.00 | 2,368 MB/s |
| SeededSystemRandom |    32 |   261.568 μs |  12.8670 μs |  0.7053 μs |  7.46 |    0.04 |   119 MB/s |
|       CryptoRandom |    32 |    35.083 μs |   1.6305 μs |  0.0894 μs |  1.00 |    0.00 |   891 MB/s |
| SeededCryptoRandom |    32 |    27.551 μs |   0.9383 μs |  0.0514 μs |  0.79 |    0.00 | 1,134 MB/s |
|           RNG_Fill |    32 |   106.507 μs |  14.8172 μs |  0.8122 μs |  3.04 |    0.02 |   293 MB/s |
|                    |       |              |             |            |       |         |            |
|       SystemRandom |  1024 |   132.600 μs |   4.5819 μs |  0.2511 μs |  0.35 |    0.00 | 7,541 MB/s |
| SystemSharedRandom |  1024 |   139.345 μs |  28.1093 μs |  1.5408 μs |  0.37 |    0.00 | 7,176 MB/s |
| SeededSystemRandom |  1024 | 8,260.379 μs | 265.3543 μs | 14.5450 μs | 21.79 |    0.01 |   121 MB/s |
|       CryptoRandom |  1024 |   379.137 μs |   8.8802 μs |  0.4868 μs |  1.00 |    0.00 | 2,638 MB/s |
| SeededCryptoRandom |  1024 |   320.513 μs |  21.3931 μs |  1.1726 μs |  0.85 |    0.00 | 3,120 MB/s |
|           RNG_Fill |  1024 |   447.914 μs |  15.4506 μs |  0.8469 μs |  1.18 |    0.00 | 2,233 MB/s |

## **처리량 (단일 스레드) .NET 5:**
```csharp
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host] : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```
|             메서드 | 바이트 |        평균 |      오차 |    표준편차 | 비율 | 비율표준편차 | 처리량 |
|------------------- |------ |------------:|-----------:|----------:|------:|--------:|-----------:|
|       SystemRandom |    32 |   252.89 μs |  53.609 μs |  2.938 μs |  7.30 |    0.09 |   124 MB/s |
| SeededSystemRandom |    32 |   259.82 μs |   3.966 μs |  0.217 μs |  7.50 |    0.03 |   120 MB/s |
|       CryptoRandom |    32 |    34.66 μs |   2.193 μs |  0.120 μs |  1.00 |    0.00 |   902 MB/s |
| SeededCryptoRandom |    32 |    26.71 μs |   3.703 μs |  0.203 μs |  0.77 |    0.01 | 1,170 MB/s |
|           RNG_Fill |    32 |   105.98 μs |   9.724 μs |  0.533 μs |  3.06 |    0.02 |   295 MB/s |
|                    |       |             |            |           |       |         |            |
|       SystemRandom |  1024 | 8,403.73 μs | 510.750 μs | 27.996 μs | 22.35 |    0.06 |   119 MB/s |
| SeededSystemRandom |  1024 | 8,262.47 μs | 721.788 μs | 39.564 μs | 21.98 |    0.13 |   121 MB/s |
|       CryptoRandom |  1024 |   375.98 μs |   8.603 μs |  0.472 μs |  1.00 |    0.00 | 2,660 MB/s |
| SeededCryptoRandom |  1024 |   318.11 μs | 219.420 μs | 12.027 μs |  0.85 |    0.03 | 3,144 MB/s |
|           RNG_Fill |  1024 |   450.76 μs |  32.919 μs |  1.804 μs |  1.20 |    0.00 | 2,218 MB/s |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---