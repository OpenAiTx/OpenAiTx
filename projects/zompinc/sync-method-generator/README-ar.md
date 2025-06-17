# مولد طرق التزامن (Sync Method Generator)

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![دعم .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

يُنتج هذا [مولد الشيفرة المصدرية لـ .NET](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) طريقة متزامنة (Sync) من طريقة غير متزامنة (Async).

## حالات الاستخدام

- مكتبة تعرض كل من النسخة المتزامنة وغير المتزامنة من طريقة ما
- تطبيق يحتاج إلى معالجة نوعين من البيانات بنفس الطريقة:
  - بيانات كبيرة من I/O لا يمكن تخزينها في الذاكرة قبل المعالجة: الطريقة غير المتزامنة الأصلية
  - عينة صغيرة من البيانات في الذاكرة، عادةً ما تكون عينة من البيانات الأكبر: الطريقة المتزامنة المُولدة

## كيف يعمل

### CreateSyncVersionAttribute

قم بتزيين طريقتك غير المتزامنة بـ `CreateSyncVersionAttribute` في صفك أو هيكلك أو سجلك `partial`

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

وسوف يولد نسخة متزامنة من الطريقة:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

قائمة التغييرات التي يتم تطبيقها على الطريقة المتزامنة الجديدة:

- إزالة المعدل async
- إزالة await من الطرق وكذلك تعليمة `foreach`
- تغيير الأنواع

  | من                                                                                                                                                                                                | إلى                                                                                                                                   |
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
- \* يتم التعامل مع [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask) بنفس طريقة [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)
- إزالة الوسائط (parameters)
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1)
- تغييرات الاستدعاء
  - إزالة `ConfigureAwait` من [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.configureawait) و[التعدادات غير المتزامنة](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - إزالة `WaitAsync` من [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.waitasync)
  - إزالة [WithCancellation](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - إعادة كتابة الاستدعاءات غير المتزامنة ذات اللاحقة `Async` لاستدعاء النسخة المتزامنة (مثلاً، [MoveNextAsync()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) تصبح [MoveNext()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext))
  - إزالة الاستدعاءات غير المتزامنة بدون اللاحقة `Async`
  - إزالة وسيطة [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - إزالة نداء [IProgress\<T>.Report(T)](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1.report)
  - إزالة الخاصية [Memory\<T>.Span](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1.span)
  - تغيير `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.fromresult)(`value`) إلى `value`
  - تغيير `await` [Task.Delay](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay)(`value`) إلى [Thread.Sleep](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep)(`value`)
  - تغيير أي استدعاء يُرجع [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) إلى [IEnumerable.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator)()
- إزالة `CreateSyncVersionAttribute`
- تحديث توثيق XML

#### الخصائص

##### OmitNullableDirective

يكتشف مولد الشيفرة المصدرية إصدار اللغة أثناء التجميع. بشكل افتراضي، سيولد توجيه `#nullable enable` إذا وفقط إذا كان إصدار اللغة 8 أو أعلى. نظرًا لأنه [مستحيل](https://github.com/dotnet/roslyn/issues/49555) تحديد ما إذا كان سياق القيم القابلة للإلغاء مفعّلًا أم لا بشكل موثوق، فإن الخاصية `OmitNullableDirective` متاحة لتجاهل هذا التوجيه من التوليد.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### رمز SYNC_ONLY

في حالة وجود منطق يجب تنفيذه فقط في النسخة المتزامنة من الطريقة، قم بتغليفه بتوجيه #if `SYNC_ONLY`.

يجب عدم تعريف `SYNC_ONLY` في أي مكان. سيقوم مولد الشيفرة بفحص توجيهات #if لهذا الرمز.

سيتم نسخ الكود داخل كتلة `SYNC_ONLY` كما هو. ما لم يتم استخدام المساحات الاسمية العامة في المشروع، يجب أن يحتوي هذا الكود على أسماء مساحات الأسماء المؤهلة بالكامل.

الصياغة التالية:

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

ستنتج:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

إذا كنت تريد التنفيذ فقط في النسخة غير المتزامنة الأصلية، اقلب العلم هكذا: `#if !SYNC_ONLY`.

ملاحظة: لا يمكن خلط `SYNC_ONLY` مع رموز أخرى في تعبير شرطي ولا يمكن أن يحتوي على توجيه `#elif`.

## التثبيت

لإضافة المكتبة استخدم:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## التطوير

### المشاريع ذات الصلة

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - يسمح بالتبديل بين النسخ المتزامنة وغير المتزامنة من الطريقة. مفيد جدًا في تطوير هذه المكتبة.

### Act

هذا المشروع متوافق تمامًا مع [act](https://github.com/nektos/act).

بخلاف الحزم المطلوبة لتشغيل `act` نفسه، يقوم سكريبت GitHub Actions بتثبيت أي شيء آخر قد يكون مفقودًا، مثل node وyarn وdotnet. على منصة Windows، يتم تثبيت البرمجيات على المضيف نفسه بسبب [عدم وجود](https://github.com/nektos/act/issues/1608) دعم للحاويات.

لبناء المشروع باستخدام act اتبع التعليمات التالية:

#### Windows

ثبت [chocolatey](https://chocolatey.org/install) إذا لم يكن مثبتًا.

ثبت الحزم التالية إذا لم تكن مثبتة:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

في دليل المشروع، شغّل:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

ثبت act باتباع هذه [التعليمات](https://lindevs.com/install-act-on-ubuntu).

في دليل المشروع، شغّل:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---