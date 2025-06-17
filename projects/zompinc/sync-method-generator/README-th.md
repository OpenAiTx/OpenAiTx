# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

[ตัวสร้างซิงค์เมธอด](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) (.NET source generator) นี้จะสร้างเมธอดแบบซิงค์จากเมธอดแบบอะซิงค์

## กรณีการใช้งาน

- ไลบรารีที่ต้องการเปิดเผยทั้งเมธอดแบบซิงค์และอะซิงค์
- แอปพลิเคชันที่ต้องประมวลผลข้อมูลสองประเภทในแบบเดียวกัน:
  - ข้อมูลขนาดใหญ่จาก I/O ที่ไม่สามารถเก็บไว้ในหน่วยความจำก่อนประมวลผล: ใช้เมธอดอะซิงค์ต้นฉบับ
  - ตัวอย่างข้อมูลขนาดเล็กในหน่วยความจำ มักเป็นตัวอย่างของข้อมูลขนาดใหญ่: ใช้เมธอดซิงค์ที่ถูกสร้างขึ้น

## วิธีการทำงาน

### CreateSyncVersionAttribute

ตกแต่งเมธอดอะซิงค์ของคุณด้วย `CreateSyncVersionAttribute` ในคลาส, struct หรือ record แบบ `partial` ของคุณ

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

แล้วมันจะสร้างเมธอดแบบซิงค์ให้โดยอัตโนมัติ:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

รายการของการเปลี่ยนแปลงที่ใช้กับเมธอดที่ถูกซิงโครไนซ์ใหม่:

- ลบตัวกำหนด async
- ลบ await จากเมธอดและจากคำสั่ง `foreach`
- เปลี่ยนประเภทข้อมูล

  | จาก                                                                                                                                                                                                | เป็น                                                                                                                                   |
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
- \* [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask) จะถูกจัดการเหมือนกับ [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)
- ลบพารามิเตอร์
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1)
- การเปลี่ยนแปลงของการเรียกใช้งาน
  - ลบ `ConfigureAwait` จาก [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.configureawait) และ [Asynchronous Enumerations](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - ลบ `WaitAsync` จาก [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.waitasync)
  - ลบ [WithCancellation](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - เขียนใหม่การเรียกใช้งานแบบอะซิงค์ที่ลงท้ายด้วย `Async` ให้เรียกใช้เวอร์ชันซิงค์ (เช่น [MoveNextAsync()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) จะกลายเป็น [MoveNext()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext))
  - ลบการเรียกใช้งานอะซิงค์ที่ไม่มีคำว่า `Async` ต่อท้าย
  - ลบพารามิเตอร์ [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - ลบการเรียก [IProgress\<T>.Report(T)](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1.report)
  - ลบพร็อพเพอร์ตี้ [Memory\<T>.Span](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1.span)
  - เปลี่ยน `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.fromresult)(`value`) เป็น `value`
  - เปลี่ยน `await` [Task.Delay](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay)(`value`) เป็น [Thread.Sleep](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep)(`value`)
  - เปลี่ยนการเรียกใช้งานใด ๆ ที่คืนค่าเป็น [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) ให้เป็น [IEnumerable.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator)()
- ลบ `CreateSyncVersionAttribute`
- ปรับปรุง XML documentation

#### Properties

##### OmitNullableDirective

ซอร์สเจเนอเรเตอร์นี้จะตรวจจับเวอร์ชันของภาษาในระหว่างการคอมไพล์ โดยค่าเริ่มต้นจะสร้าง directive `#nullable enable` ก็ต่อเมื่อเวอร์ชันของภาษาเป็น 8 ขึ้นไปเท่านั้น เนื่องจาก [ไม่สามารถ](https://github.com/dotnet/roslyn/issues/49555) ตรวจสอบได้อย่างน่าเชื่อถือว่าสภาพแวดล้อม nullable เปิดอยู่หรือไม่ จึงมี property `OmitNullableDirective` เพื่อข้ามการสร้าง directive ดังกล่าว

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### สัญลักษณ์ SYNC_ONLY

ในกรณีที่มีโค้ดที่ต้องการให้รันเฉพาะในเวอร์ชันซิงค์ของเมธอด ให้ห่อโค้ดนั้นไว้ใน directive `SYNC_ONLY` #if

`SYNC_ONLY` ต้องไม่ถูกนิยามไว้ที่ใดในโปรเจกต์ ซอร์สเจเนอเรเตอร์จะค้นหาสัญลักษณ์นี้จาก #if

โค้ดในบล็อก `SYNC_ONLY` จะถูกคัดลอกไปตรง ๆ หากโปรเจกต์ไม่ได้ใช้ global namespace โค้ดนี้ควรระบุ namespace แบบเต็ม

ตัวอย่าง syntax:

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

จะได้ผลลัพธ์เป็น:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

หากต้องการให้รันเฉพาะในเวอร์ชัน async ต้นฉบับ ให้กลับเงื่อนไขเป็น `#if !SYNC_ONLY`

หมายเหตุ: `SYNC_ONLY` ไม่สามารถใช้ร่วมกับสัญลักษณ์อื่นในนิพจน์เงื่อนไข และไม่สามารถมี directive `#elif`

## การติดตั้ง

เพื่อเพิ่มไลบรารีนี้ ให้ใช้คำสั่ง:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## การพัฒนา

### โปรเจกต์ที่เกี่ยวข้อง

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - ช่วยให้สลับระหว่างเมธอดซิงค์และอะซิงค์ได้ สะดวกมากในงานพัฒนาไลบรารีนี้

### Act

โปรเจกต์นี้รองรับ [act](https://github.com/nektos/act) อย่างสมบูรณ์

นอกเหนือจากแพ็กเกจที่จำเป็นต่อการรัน `act` สคริปต์ GitHub Actions จะติดตั้งซอฟต์แวร์ที่อาจขาดไป เช่น node, yarn และ dotnet สำหรับ Windows การติดตั้งซอฟต์แวร์จะทำบนโฮสต์โดยตรงเนื่องจาก [ข้อจำกัด](https://github.com/nektos/act/issues/1608) ของ container

เพื่อ build โปรเจกต์ด้วย act ให้ทำตามขั้นตอนต่อไปนี้:

#### Windows

ติดตั้ง [chocolatey](https://chocolatey.org/install) หากยังไม่มี

ติดตั้งแพ็กเกจเหล่านี้หากยังไม่มี:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

ในไดเรกทอรีโปรเจกต์ ให้รัน:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

ติดตั้ง act ตาม [คำแนะนำนี้](https://lindevs.com/install-act-on-ubuntu)

ในไดเรกทอรีโปรเจกต์ ให้รัน:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---