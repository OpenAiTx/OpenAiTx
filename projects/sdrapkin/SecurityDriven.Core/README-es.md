# **CryptoRandom** [![GitHub Actions](https://github.com/sdrapkin/SecurityDriven.Core/workflows/.NET%20CI/badge.svg)](https://github.com/sdrapkin/SecurityDriven.Core/actions) [![NuGet](https://img.shields.io/nuget/v/CryptoRandom.svg)](https://www.nuget.org/packages/CryptoRandom/)

### por [Stan Drapkin](https://github.com/sdrapkin/)

## **CryptoRandom** : Aleatorio

* **.NET Random hecho bien**
* [Rápido], [Seguro para hilos], [Criptográficamente fuerte]: elige 3
* Subclases y reemplaza a `System.Random`
* También reemplaza a `System.Security.Cryptography.RandomNumberGenerator` ([enlace](https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.randomnumbergenerator))
* `CryptoRandom` es (a diferencia de `System.Random`):
	* **Rápido** (mucho más rápido que `Random` o `RandomNumberGenerator`)
	* **Seguro para hilos** (todas las APIs)
	* **Criptográficamente fuerte** (con o sin semilla)
* Implementa RNG [Fast-Key-Erasure](https://blog.cr.yp.to/20170723-random.html) para `CryptoRandom` con semilla
* Produce *la misma* secuencia de valores `CryptoRandom` con semilla en *todas* las versiones de .NET (a diferencia de `Random`)
* Envuelve `RandomNumberGenerator` para sin semilla (con inteligencia adicional)
* Proporciona *resistencia a retroceso*: el estado interno no puede usarse para recuperar la salida
* Logra un rendimiento de ~1.3cpb (ciclos por byte), similar a [AES-NI](https://en.wikipedia.org/wiki/AES_instruction_set)
* Escala por CPU/Núcleo
* Ejemplo: `CryptoRandom.NextGuid()` vs. `Guid.NewGuid()` [BenchmarkDotNet]:
	* 4~5x más rápido en Windows-x64
	* 5~30x más rápido en Linux-x64
	* 4~5x más rápido en Linux-ARM64 (AWS Graviton-2)
* Diseñado para .NET 5.0+ y 6.0+
* Cobertura de pruebas extensa y validación de corrección (110+ pruebas)
	* CI ejecutándose en Linux-latest y Windows-latest para .NET 5/6/7/8/9/10

---
## **API de CryptoRandom**:
* Todas las APIs de `System.Random` ([enlace](https://docs.microsoft.com/en-us/dotnet/api/system.random))
* Instancia compartida estática `CryptoRandom.Shared` para conveniencia (segura para hilos por supuesto)
* Constructores con semilla:
	* `CryptoRandom(ReadOnlySpan<byte> seedKey)`
	* `CryptoRandom(int Seed)` (igual que el constructor con semilla de `Random`)
* `byte[] NextBytes(int count)`
* `Guid NextGuid()`
	* 5x (500%) más rápido que `Guid.NewGuid()` en Windows
	* 15x (1500%) más rápido que `Guid.NewGuid()` en Linux
	* 128 bits aleatorios, en lugar de 122
* `Guid SqlServerGuid()`
	* Devuelve un nuevo Guid adecuado para ser usado como clave agrupada en SQL Server
	* La estructura del Guid es `[8 bytes aleatorios][8 bytes de DateTime.UtcNow ordenados por SQL Server]`
	* Cada Guid debe ser secuencial dentro de los límites de precisión de 100 nanosegundos de `UtcNow`
	* Entropía de 64 bits para una razonable imprevisibilidad y protección contra ataques de fuerza bruta en línea
	* ~15% más rápido que `Guid.NewGuid()`
* `long NextInt64()`
* `long NextInt64(long maxValue)`
* `long NextInt64(long minValue, long maxValue)`
* `struct` aleatorios (asegúrate de saber lo que haces):
	* `void Next<T>(ref T @struct) where T : unmanaged`
	* `T Next<T>() where T : unmanaged`
---
## **Utils API** (`SecurityDriven.Core.Utils`):
* `static Span<byte> AsSpan<T>(ref T @struct) where T : unmanaged`
	* Convierte una estructura no administrada T en un `Span<byte>` equivalente
* `static ref T AsStruct<T>(Span<byte> span) where T : unmanaged`
	* Convierte un `Span<byte>` en una estructura no administrada T equivalente
* `int StructSizer<T>.Size`
	* Devuelve el tamaño en bytes de la estructura T

---
## **Benchmark rápido**:
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
## **¿Qué está mal con `Random` y `RandomNumberGenerator`?**
* `Random` es lento y no es seguro para subprocesos (falla miserablemente y silenciosamente en accesos concurrentes)
* `Random` está implementado incorrectamente:
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
* `Random`/.NET 6 sin semilla es rápido (nuevo algoritmo), con una propiedad `.Shared` segura, pero las instancias no son seguras para subprocesos
* `Random`/.NET 6 con semilla vuelve al algoritmo heredado lento y no seguro para subprocesos de .NET
* Ninguna implementación de `Random` apunta a resultados criptográficamente fuertes
* `RandomNumberGenerator` puede ser mucho más rápido con un envoltorio inteligente y una API `Random` más útil

---
## **Rendimiento (monohilo) .NET 6:**
```csharp
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host] : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT
```
|             Método | BYTES |         Media |       Error |     DesvEst | Ratio | RatioDE | Rendimiento |
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

## **Rendimiento (hilo único) .NET 5:**
```csharp
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host] : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```
|             Método | BYTES |        Media |      Error |    DesvEst | Ratio | RatioDE | Rendimiento |
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