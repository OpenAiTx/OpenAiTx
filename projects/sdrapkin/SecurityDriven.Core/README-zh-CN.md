# **CryptoRandom** [![GitHub Actions](https://github.com/sdrapkin/SecurityDriven.Core/workflows/.NET%20CI/badge.svg)](https://github.com/sdrapkin/SecurityDriven.Core/actions) [![NuGet](https://img.shields.io/nuget/v/CryptoRandom.svg)](https://www.nuget.org/packages/CryptoRandom/)

### 作者 [Stan Drapkin](https://github.com/sdrapkin/)

## **CryptoRandom** : 随机数

* **.NET 随机数的正确实现**
* [快速]，[线程安全]，[密码学强度]：三者兼得
* 继承并替代 `System.Random`
* 也替代 `System.Security.Cryptography.RandomNumberGenerator` ([链接](https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.randomnumbergenerator))
* `CryptoRandom`（不同于 `System.Random`）：
	* **快速**（比 `Random` 或 `RandomNumberGenerator` 快得多）
	* **线程安全**（所有API）
	* **密码学强度**（有种子或无种子）
* 实现了用于有种子 `CryptoRandom` 的[快速密钥擦除](https://blog.cr.yp.to/20170723-random.html)随机数生成器
* 在*所有* .NET 版本中产生*相同*的有种子 `CryptoRandom` 序列（不同于 `Random`）
* 对无种子模式封装了 `RandomNumberGenerator`（并具备额外智能）
* 提供*回溯抵抗*：内部状态不能用来恢复输出
* 实现约 ~1.3cpb（周期/字节）性能，类似于 [AES-NI](https://en.wikipedia.org/wiki/AES_instruction_set)
* 按 CPU/Core 进行扩展
* 示例：`CryptoRandom.NextGuid()` 与 `Guid.NewGuid()` [BenchmarkDotNet]：
	* Windows-x64 下快 4~5 倍
	* Linux-x64 下快 5~30 倍
	* Linux-ARM64（AWS Graviton-2）下快 4~5 倍
* 适用于 .NET 5.0+ 和 6.0+
* 广泛的测试覆盖和正确性验证（110+ 测试）
	* CI 在 Linux-latest & Windows-latest 上运行，支持 .NET 5/6/7/8/9/10

---
## **CryptoRandom API**:
* `System.Random` 的所有 API ([链接](https://docs.microsoft.com/en-us/dotnet/api/system.random))
* `CryptoRandom.Shared` 静态共享实例，方便使用（当然线程安全）
* 有种子构造函数：
	* `CryptoRandom(ReadOnlySpan<byte> seedKey)`
	* `CryptoRandom(int Seed)`（类似有种子 `Random` 构造函数）
* `byte[] NextBytes(int count)`
* `Guid NextGuid()`
	* Windows 下比 `Guid.NewGuid()` 快 5 倍（500%）
	* Linux 下比 `Guid.NewGuid()` 快 15 倍（1500%）
	* 生成 128 位随机数，而不是 122 位
* `Guid SqlServerGuid()`
	* 返回适合用作 SQL Server 聚集键的新 Guid
	* Guid 结构为 `[8 个随机字节][8 个 SQL Server 有序的 DateTime.UtcNow 字节]`
	* 每个 Guid 应在 100 纳秒的 `UtcNow` 精度限制内顺序生成
	* 64 位熵，保证合理的不可预测性和防止在线暴力攻击
	* 比 `Guid.NewGuid()` 快约 15%
* `long NextInt64()`
* `long NextInt64(long maxValue)`
* `long NextInt64(long minValue, long maxValue)`
* 随机生成 `struct`（确保你知道自己在做什么）:
	* `void Next<T>(ref T @struct) where T : unmanaged`
	* `T Next<T>() where T : unmanaged`
---
## **Utils API** (`SecurityDriven.Core.Utils`):
* `static Span<byte> AsSpan<T>(ref T @struct) where T : unmanaged`
	* 将非托管结构体 T 转换为等效的 `Span<byte>`
* `static ref T AsStruct<T>(Span<byte> span) where T : unmanaged`
	* 将 `Span<byte>` 转换为等效的非托管结构体 T
* `int StructSizer<T>.Size`
	* 返回结构体 T 的字节大小

---
## **快速基准测试**:
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
## **`Random` 和 `RandomNumberGenerator` 有什么问题？**
* `Random` 速度慢且非线程安全（在并发访问时会惨烈且无声地失败）
* `Random` 实现不正确：
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
* `Random`/.NET 6 无种子时速度很快（新算法），具有安全的 `.Shared` 属性，但实例不是线程安全的  
* `Random`/.NET 6 有种子时退回到传统的慢速非线程安全 .NET 算法  
* 两种 `Random` 实现都不针对加密强度的结果设计  
* 通过智能封装和更实用的 `Random` API，`RandomNumberGenerator` 可以更快  

---  
## **吞吐量（单线程）.NET 6：**
```csharp
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host] : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT
```
|             方法 | 字节数 |         平均值 |       误差 |     标准差 | 比率 | 比率标准差 | 吞吐量 |
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

## **吞吐量（单线程）.NET 5：**
```csharp
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host] : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```
|             方法 | 字节数 |        平均值 |       误差 |     标准差 | 比率 | 比率标准差 | 吞吐量 |
|------------------- |------ |------------:|-----------:|----------:|------:|--------:|-----------:|
|       SystemRandom |    32 |   252.89 微秒 |  53.609 微秒 |  2.938 微秒 |  7.30 |    0.09 |   124 MB/s |
| SeededSystemRandom |    32 |   259.82 微秒 |   3.966 微秒 |  0.217 微秒 |  7.50 |    0.03 |   120 MB/s |
|       CryptoRandom |    32 |    34.66 微秒 |   2.193 微秒 |  0.120 微秒 |  1.00 |    0.00 |   902 MB/s |
| SeededCryptoRandom |    32 |    26.71 微秒 |   3.703 微秒 |  0.203 微秒 |  0.77 |    0.01 | 1,170 MB/s |
|           RNG_Fill |    32 |   105.98 微秒 |   9.724 微秒 |  0.533 微秒 |  3.06 |    0.02 |   295 MB/s |
|                    |       |             |            |           |       |         |            |
|       SystemRandom |  1024 | 8,403.73 微秒 | 510.750 微秒 | 27.996 微秒 | 22.35 |    0.06 |   119 MB/s |
| SeededSystemRandom |  1024 | 8,262.47 微秒 | 721.788 微秒 | 39.564 微秒 | 21.98 |    0.13 |   121 MB/s |
|       CryptoRandom |  1024 |   375.98 微秒 |   8.603 微秒 |  0.472 微秒 |  1.00 |    0.00 | 2,660 MB/s |
| SeededCryptoRandom |  1024 |   318.11 微秒 | 219.420 微秒 | 12.027 微秒 |  0.85 |    0.03 | 3,144 MB/s |
|           RNG_Fill |  1024 |   450.76 微秒 |  32.919 微秒 |  1.804 微秒 |  1.20 |    0.00 | 2,218 MB/s |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---