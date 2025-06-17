# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

Generator sumber [.NET ini](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) menghasilkan metode sinkron dari metode asinkron.

## Kasus Penggunaan

- Sebuah pustaka yang menyediakan versi sinkron dan asinkron dari sebuah metode
- Sebuah aplikasi harus memproses dua jenis data dengan cara yang sama:
  - Data besar dari I/O yang tidak dapat disimpan di memori sebelum diproses: Metode asinkron asli
  - Sampel data kecil di memori, biasanya sampel dari data yang lebih besar: Metode sinkron yang dihasilkan

## Cara Kerja

### CreateSyncVersionAttribute

Hiasi metode asinkron Anda dengan `CreateSyncVersionAttribute` di dalam kelas, struct, atau record `partial` Anda

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

Dan akan menghasilkan versi sinkron dari metode tersebut:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

Daftar perubahan yang diterapkan pada metode sinkron yang baru:

- Menghapus modifier async
- Menghapus await dari metode serta pernyataan `foreach`
- Mengubah tipe data

  | Dari                                                                                                                                                                                                | Ke                                                                                                                                   |
  | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
  | [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)*                                                                                                                   | void                                                                                                                                 |
  | [Task\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)                                                                                                              | T                                                                                                                                    |
  | [Func](https://learn.microsoft.com/en-us/dotnet/api/system.func-1)\<Task>                                                                                                                           | [Action](https://learn.microsoft.com/en-us/dotnet/api/system.action)                                                                 |
  | Func\<Task\<T>>                                                                                                                                                                                     | Func\<T>                                                                                                                             |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                  | [IEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)                             |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                  | [IEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)                 | [IEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator) |
  | [Memory\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1)                                                                                                                          | [Span\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.span-1)                                                               |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.readonlymemory-1)                                                                                                          | [ReadOnlySpan\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.readonlyspan-1)                                               |
- \* [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask) diperlakukan persis seperti [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)
- Menghapus parameter
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1)
- Perubahan pemanggilan
  - Menghapus `ConfigureAwait` dari [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.configureawait) dan [Enumerasi Asinkron](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - Menghapus `WaitAsync` dari [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.waitasync)
  - Menghapus [WithCancellation](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - Menulis ulang pemanggilan asinkron dengan akhiran `Async` agar memanggil versi sinkron (misal [MoveNextAsync()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) menjadi [MoveNext()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext))
  - Menghapus pemanggilan asinkron tanpa akhiran `Async`
  - Menghapus parameter [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - Menghapus pemanggilan [IProgress\<T>.Report(T)](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1.report)
  - Menghapus properti [Memory\<T>.Span](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1.span)
  - Mengubah `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.fromresult)(`value`) menjadi `value`
  - Mengubah `await` [Task.Delay](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay)(`value`) menjadi [Thread.Sleep](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep)(`value`)
  - Mengubah setiap pemanggilan yang mengembalikan [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) menjadi [IEnumerable.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator)()
- Menghapus `CreateSyncVersionAttribute`
- Memperbarui dokumentasi XML

#### Properti

##### OmitNullableDirective

Generator sumber ini mendeteksi versi bahasa selama kompilasi. Secara default, ini akan menghasilkan direktif `#nullable enable` jika dan hanya jika versi bahasa adalah 8 atau di atasnya. Karena [tidak mungkin](https://github.com/dotnet/roslyn/issues/49555) untuk menentukan secara andal apakah konteks nullable diaktifkan atau tidak, properti `OmitNullableDirective` tersedia untuk menghilangkan direktif tersebut dari hasil generate.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### Simbol SYNC_ONLY

Jika ada logika yang hanya boleh dijalankan pada versi sinkron dari metode, bungkus logika tersebut dalam direktif `SYNC_ONLY` #if.

`SYNC_ONLY` tidak boleh didefinisikan di mana pun. Generator sumber akan memindai direktif #if untuk simbol ini.

Kode di dalam blok `SYNC_ONLY` akan disalin apa adanya. Kecuali namespace global digunakan di proyek, kode ini sebaiknya menggunakan namespace lengkap.

Sintaks berikut:

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
public async Task WithSyncOnlyDirectiveAsync(CancellationToken ct)
{
#if SYNC_ONLY
    System.Console.Write("Sync");
#endif
    await Task.CompletedTask;
}
```

akan menghasilkan:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

Jika Anda hanya ingin menjalankan di versi asinkron asli, balikkan flag seperti ini: `#if !SYNC_ONLY`.

Catatan: `SYNC_ONLY` tidak dapat dicampur dengan simbol lain dalam ekspresi kondisional dan tidak boleh memiliki direktif `#elif`.

## Instalasi

Untuk menambahkan pustaka gunakan:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Pengembangan

### Proyek Terkait

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - Memungkinkan beralih antara versi sinkron dan asinkron dari sebuah metode. Sangat berguna dalam pengembangan pustaka ini.

### Act

Proyek ini sepenuhnya kompatibel dengan [act](https://github.com/nektos/act).

Selain paket yang dibutuhkan untuk menjalankan `act` itu sendiri, skrip GitHub Actions akan menginstal apa pun yang mungkin belum terpasang, seperti node, yarn, dan dotnet. Pada platform Windows, instalasi perangkat lunak dilakukan di host itu sendiri karena [tidak adanya](https://github.com/nektos/act/issues/1608) dukungan kontainer.

Untuk membangun proyek menggunakan act ikuti instruksi berikut:

#### Windows

Instal [chocolatey](https://chocolatey.org/install) jika belum ada.

Instal paket berikut jika belum ada:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

Di direktori proyek jalankan:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Instal act dengan mengikuti [instruksi ini](https://lindevs.com/install-act-on-ubuntu).

Di direktori proyek jalankan:

```pwsh
act --artifact-server-path /tmp/artifacts
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---