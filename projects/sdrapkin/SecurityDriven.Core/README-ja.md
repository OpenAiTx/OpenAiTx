# **CryptoRandom** [![GitHub Actions](https://github.com/sdrapkin/SecurityDriven.Core/workflows/.NET%20CI/badge.svg)](https://github.com/sdrapkin/SecurityDriven.Core/actions) [![NuGet](https://img.shields.io/nuget/v/CryptoRandom.svg)](https://www.nuget.org/packages/CryptoRandom/)

### by [Stan Drapkin](https://github.com/sdrapkin/)

## **CryptoRandom** : ランダム

* **正しく実装された .NET の Random**
* [高速], [スレッドセーフ], [暗号学的に強力]: 3つを選択
* `System.Random` のサブクラスかつ置換
* `System.Security.Cryptography.RandomNumberGenerator` の置換も可能 ([リンク](https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.randomnumbergenerator))
* `CryptoRandom` は（`System.Random` と違い）:
	* **高速** (`Random` や `RandomNumberGenerator` よりはるかに高速)
	* **スレッドセーフ**（すべての API）
	* **暗号学的に強力**（シード付きまたはシードなし）
* シード付き `CryptoRandom` に対して [Fast-Key-Erasure](https://blog.cr.yp.to/20170723-random.html) RNG を実装
* すべての .NET バージョンでシード付き `CryptoRandom` の同一シーケンスを生成（`Random` とは異なる）
* シードなしでは（追加のスマート機能付きで）`RandomNumberGenerator` をラップ
* *バックトラッキング耐性* を提供：内部状態から出力を復元不可
* ~1.3cpb（バイトあたりのサイクル）性能を達成し、[AES-NI](https://en.wikipedia.org/wiki/AES_instruction_set) と同等の速度
* CPU/Core ごとにスケーラブル
* 例：`CryptoRandom.NextGuid()` と `Guid.NewGuid()` の比較 [BenchmarkDotNet]:
	* Windows-x64 で4〜5倍高速
	* Linux-x64 で5〜30倍高速
	* Linux-ARM64（AWS Graviton-2）で4〜5倍高速
* .NET 5.0+ および 6.0+ 向けに構築
* 広範なテストカバレッジと正確性検証（110以上のテスト）
	* CI は Linux-latest と Windows-latest 上で .NET 5/6/7/8/9/10 を実行

---
## **CryptoRandom API**:
* `System.Random` のすべての API ([リンク](https://docs.microsoft.com/en-us/dotnet/api/system.random))
* 便利な静的共有インスタンス `CryptoRandom.Shared`（もちろんスレッドセーフ）
* シード付きコンストラクタ:
	* `CryptoRandom(ReadOnlySpan<byte> seedKey)`
	* `CryptoRandom(int Seed)`（シード付き `Random` のコンストラクタと同様）
* `byte[] NextBytes(int count)`
* `Guid NextGuid()`
	* Windows 上の `Guid.NewGuid()` より5倍（500%）高速
	* Linux 上の `Guid.NewGuid()` より15倍（1500%）高速
	* 122ビットではなく128ビットの乱数を生成
* `Guid SqlServerGuid()`
	* SQLサーバークラスタキーとして適した新しいGuidを返します
	* Guid構造は `[8 バイトのランダム][SQLサーバー順の DateTime.UtcNow の 8 バイト]`
	* 各Guidは100ナノ秒の `UtcNow` 精度の範囲で順序付けられるべきです
	* 合理的な推測困難性とオンラインブルートフォース攻撃からの保護のための64ビットエントロピー
	* `Guid.NewGuid()` より約15%高速
* `long NextInt64()`
* `long NextInt64(long maxValue)`
* `long NextInt64(long minValue, long maxValue)`
* ランダムな `struct` （使用には注意してください）:
	* `void Next<T>(ref T @struct) where T : unmanaged`
	* `T Next<T>() where T : unmanaged`
---
## **Utils API** (`SecurityDriven.Core.Utils`):
* `static Span<byte> AsSpan<T>(ref T @struct) where T : unmanaged`
	* アンマネージド構造体Tを同等の `Span<byte>` にキャストします
* `static ref T AsStruct<T>(Span<byte> span) where T : unmanaged`
	* `Span<byte>` を同等のアンマネージド構造体Tにキャストします
* `int StructSizer<T>.Size`
	* 構造体Tのバイトサイズを返します

---
## **簡易ベンチマーク**:
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
## **`Random` と `RandomNumberGenerator` の問題点は？**
* `Random` は遅く、スレッドセーフではない（同時アクセス時にひどくかつ静かに失敗する）
* `Random` は誤って実装されている：
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
* `Random`/.NET 6 のシードなしは高速（新しいアルゴリズム）で、安全な `.Shared` プロパティがありますが、インスタンスはスレッドセーフではありません
* `Random`/.NET 6 のシードありはレガシーで遅い非スレッドセーフな .NET アルゴリズムにフォールバックします
* どちらの `Random` 実装も暗号学的に強力な結果を目指していません
* `RandomNumberGenerator` は、賢いラッピングとより有用な `Random` API によってはるかに高速になり得ます

---
## **スループット（単一スレッド）.NET 6：**
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

## **スループット（シングルスレッド） .NET 5:**
```csharp
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host] : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```
|             メソッド | バイト数 |        平均値 |       誤差 |     標準偏差 | 比率 | 比率標準偏差 | スループット |
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