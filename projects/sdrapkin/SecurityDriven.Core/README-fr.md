# **CryptoRandom** [![GitHub Actions](https://github.com/sdrapkin/SecurityDriven.Core/workflows/.NET%20CI/badge.svg)](https://github.com/sdrapkin/SecurityDriven.Core/actions) [![NuGet](https://img.shields.io/nuget/v/CryptoRandom.svg)](https://www.nuget.org/packages/CryptoRandom/)

### par [Stan Drapkin](https://github.com/sdrapkin/)

## **CryptoRandom** : Aléatoire

* **.NET Random fait correctement**
* [Rapide], [Thread-safe], [Cryptographiquement sûr] : choisissez 3
* Sous-classes et remplace `System.Random`
* Remplace également `System.Security.Cryptography.RandomNumberGenerator` ([lien](https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.randomnumbergenerator))
* `CryptoRandom` est (contrairement à `System.Random`) :
	* **Rapide** (beaucoup plus rapide que `Random` ou `RandomNumberGenerator`)
	* **Thread-safe** (toutes les API)
	* **Cryptographiquement sûr** (avec ou sans graine)
* Implémente un RNG [Fast-Key-Erasure](https://blog.cr.yp.to/20170723-random.html) pour `CryptoRandom` avec graine
* Produit *la même* séquence de valeurs `CryptoRandom` avec graine sur *toutes* les versions de .NET (contrairement à `Random`)
* Enveloppe `RandomNumberGenerator` pour les cas sans graine (avec des optimisations supplémentaires)
* Fournit une *résistance au retour en arrière* : l’état interne ne peut être utilisé pour récupérer la sortie
* Atteint une performance d’environ ~1,3cpb (cycles par octet), similaire à [AES-NI](https://fr.wikipedia.org/wiki/AES_instruction_set)
* S’adapte par CPU/Core
* Exemple : `CryptoRandom.NextGuid()` vs. `Guid.NewGuid()` [BenchmarkDotNet] :
	* 4~5x plus rapide sur Windows-x64
	* 5~30x plus rapide sur Linux-x64
	* 4~5x plus rapide sur Linux-ARM64 (AWS Graviton-2)
* Conçu pour .NET 5.0+ et 6.0+
* Couverture de test étendue & validation de correction (110+ tests)
	* CI s’exécute sur Linux-latest & Windows-latest pour .NET 5/6/7/8/9/10

---
## **API CryptoRandom** :
* Toutes les API de `System.Random` ([lien](https://docs.microsoft.com/en-us/dotnet/api/system.random))
* Instance partagée statique `CryptoRandom.Shared` pour commodité (thread-safe bien sûr)
* Constructeurs avec graine :
	* `CryptoRandom(ReadOnlySpan<byte> seedKey)`
	* `CryptoRandom(int Seed)` (comme le constructeur `Random` avec graine)
* `byte[] NextBytes(int count)`
* `Guid NextGuid()`
	* 5x (500 %) plus rapide que `Guid.NewGuid()` sur Windows
	* 15x (1500 %) plus rapide que `Guid.NewGuid()` sur Linux
	* 128 bits aléatoires, au lieu de 122
* `Guid SqlServerGuid()`
	* Retourne un nouveau Guid bien adapté pour être utilisé comme clé clusterisée SQL-Server
	* La structure du Guid est `[8 octets aléatoires][8 octets de DateTime.UtcNow ordonné par SQL-Server]`
	* Chaque Guid doit être séquentiel dans les limites de précision de 100 nanosecondes de `UtcNow`
	* Entropie 64 bits pour une incertitude raisonnable et une protection contre les attaques par force brute en ligne
	* ~15% plus rapide que `Guid.NewGuid()`
* `long NextInt64()`
* `long NextInt64(long maxValue)`
* `long NextInt64(long minValue, long maxValue)`
* `struct` aléatoires (assurez-vous de savoir ce que vous faites) :
	* `void Next<T>(ref T @struct) where T : unmanaged`
	* `T Next<T>() where T : unmanaged`
---
## **API Utils** (`SecurityDriven.Core.Utils`) :
* `static Span<byte> AsSpan<T>(ref T @struct) where T : unmanaged`
	* Convertit la struct non managée T en `Span<byte>` équivalent
* `static ref T AsStruct<T>(Span<byte> span) where T : unmanaged`
	* Convertit `Span<byte>` en struct non managée T équivalent
* `int StructSizer<T>.Size`
	* Retourne la taille en octets de la struct T

---
## **Benchmark rapide** :
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
## **Qu'y a-t-il de problématique avec `Random` et `RandomNumberGenerator` ?**
* `Random` est lent et non sécurisé pour les threads (échoue lamentablement et silencieusement en cas d'accès concurrent)
* `Random` est mal implémenté :
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
* `Random`/.NET 6 non initialisé est rapide (nouvel algorithme), avec une propriété `.Shared` sécurisée, mais les instances ne sont pas thread-safe  
* `Random`/.NET 6 initialisé revient à l’algorithme .NET ancien, lent et non thread-safe  
* Aucune des deux implémentations de `Random` ne vise des résultats cryptographiquement sûrs  
* `RandomNumberGenerator` peut être beaucoup plus rapide avec un encapsulage intelligent et une API `Random` plus utile  

---  
## **Débit (mono-thread) .NET 6 :**
```csharp
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host] : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT
```
|             Méthode | OCTETS |         Moyenne |       Erreur |     ÉcartType | Rapport | ÉcartRapport | Débit |
|-------------------- |------- |---------------:|-------------:|--------------:|--------:|-------------:|-------:|
|       SystemRandom  |    32  |     7,483 μs   |   0,2714 μs  |  0,0149 μs    |  0,21   |    0,00      | 4 176 Mo/s |
| SystemSharedRandom  |    32  |    13,197 μs   |   3,3861 μs  |  0,1856 μs    |  0,38   |    0,00      | 2 368 Mo/s |
| SeededSystemRandom  |    32  |   261,568 μs   |  12,8670 μs  |  0,7053 μs    |  7,46   |    0,04      |   119 Mo/s |
|       CryptoRandom  |    32  |    35,083 μs   |   1,6305 μs  |  0,0894 μs    |  1,00   |    0,00      |   891 Mo/s |
| SeededCryptoRandom  |    32  |    27,551 μs   |   0,9383 μs  |  0,0514 μs    |  0,79   |    0,00      | 1 134 Mo/s |
|           RNG_Fill  |    32  |   106,507 μs   |  14,8172 μs  |  0,8122 μs    |  3,04   |    0,02      |   293 Mo/s |
|                     |        |                |              |               |         |              |          |
|       SystemRandom  |  1024  |   132,600 μs   |   4,5819 μs  |  0,2511 μs    |  0,35   |    0,00      | 7 541 Mo/s |
| SystemSharedRandom  |  1024  |   139,345 μs   |  28,1093 μs  |  1,5408 μs    |  0,37   |    0,00      | 7 176 Mo/s |
| SeededSystemRandom  |  1024  | 8 260,379 μs   | 265,3543 μs  | 14,5450 μs    | 21,79   |    0,01      |   121 Mo/s |
|       CryptoRandom  |  1024  |   379,137 μs   |   8,8802 μs  |  0,4868 μs    |  1,00   |    0,00      | 2 638 Mo/s |
| SeededCryptoRandom  |  1024  |   320,513 μs   |  21,3931 μs  |  1,1726 μs    |  0,85   |    0,00      | 3 120 Mo/s |
|           RNG_Fill  |  1024  |   447,914 μs   |  15,4506 μs  |  0,8469 μs    |  1,18   |    0,00      | 2 233 Mo/s |

## **Débit (mono-thread) .NET 5 :**
```csharp
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host] : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
```
|             Méthode | OCTETS |        Moyenne |      Erreur |    ÉcartType | Ratio | RatioSD | Débit |
|------------------- |-------|--------------:|------------:|-------------:|------:|--------:|-------:|
|       SystemRandom |    32 |   252,89 μs   |  53,609 μs  |  2,938 μs    |  7,30 |    0,09 | 124 Mo/s |
| SeededSystemRandom |    32 |   259,82 μs   |   3,966 μs  |  0,217 μs    |  7,50 |    0,03 | 120 Mo/s |
|       CryptoRandom |    32 |    34,66 μs   |   2,193 μs  |  0,120 μs    |  1,00 |    0,00 | 902 Mo/s |
| SeededCryptoRandom |    32 |    26,71 μs   |   3,703 μs  |  0,203 μs    |  0,77 |    0,01 | 1 170 Mo/s |
|           RNG_Fill |    32 |   105,98 μs   |   9,724 μs  |  0,533 μs    |  3,06 |    0,02 | 295 Mo/s |
|                    |       |              |             |              |       |         |         |
|       SystemRandom |  1024 | 8 403,73 μs   | 510,750 μs  | 27,996 μs    | 22,35 |    0,06 | 119 Mo/s |
| SeededSystemRandom |  1024 | 8 262,47 μs   | 721,788 μs  | 39,564 μs    | 21,98 |    0,13 | 121 Mo/s |
|       CryptoRandom |  1024 |   375,98 μs   |   8,603 μs  |  0,472 μs    |  1,00 |    0,00 | 2 660 Mo/s |
| SeededCryptoRandom |  1024 |   318,11 μs   | 219,420 μs  | 12,027 μs    |  0,85 |    0,03 | 3 144 Mo/s |
|           RNG_Fill |  1024 |   450,76 μs   |  32,919 μs  |  1,804 μs    |  1,20 |    0,00 | 2 218 Mo/s |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-09

---