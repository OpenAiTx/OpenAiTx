# Генератор синхронных методов

[![Сборка](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Поддержка .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

Этот [генератор исходного кода .NET](https://learn.microsoft.com/ru-ru/dotnet/csharp/roslyn-sdk/source-generators-overview) создает синхронный метод на основе асинхронного.

## Сценарии использования

- Библиотека, предоставляющая как синхронную, так и асинхронную версию метода
- Приложение должно обрабатывать два типа данных одинаковым способом:
  - Большие данные из I/O, которые нельзя сохранить в памяти перед обработкой: исходный асинхронный метод
  - Малый образец данных в памяти, обычно являющийся подмножеством больших данных: сгенерированный синхронный метод

## Как это работает

### CreateSyncVersionAttribute

Украсьте ваш асинхронный метод атрибутом `CreateSyncVersionAttribute` в вашем `partial` классе, структуре или записи

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

И будет сгенерирована синхронная версия метода:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

Список изменений, применяемых к новому синхронизированному методу:

- Удаление модификатора async
- Удаление await из методов, а также из оператора `foreach`
- Изменение типов

  | Из | В |
  | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
  | [Task](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.task)*                                                                                                                   | void                                                                                                                                 |
  | [Task\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.task-1)                                                                                                              | T                                                                                                                                    |
  | [Func](https://learn.microsoft.com/ru-ru/dotnet/api/system.func-1)\<Task>                                                                                                                           | [Action](https://learn.microsoft.com/ru-ru/dotnet/api/system.action)                                                                 |
  | Func\<Task\<T>>                                                                                                                                                                                     | Func\<T>                                                                                                                             |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                  | [IEnumerable\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.generic.ienumerable-1)                             |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                  | [IEnumerator\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/ru-ru/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)                 | [IEnumerator\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/ru-ru/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.generic.ienumerable-1.getenumerator) |
  | [Memory\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.memory-1)                                                                                                                          | [Span\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.span-1)                                                               |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.readonlymemory-1)                                                                                                          | [ReadOnlySpan\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.readonlyspan-1)                                               |
- \* [ValueTask](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.valuetask) обрабатываются точно так же, как и [Task](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.task)
- Удаление параметров
  - [CancellationToken](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.iprogress-1)
- Изменения вызовов
  - Удаление `ConfigureAwait` из [Tasks](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.task.configureawait) и [Асинхронных перечислений](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - Удаление `WaitAsync` из [Tasks](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.task.waitasync)
  - Удаление [WithCancellation](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - Переписывание асинхронных вызовов с суффиксом `Async` для вызова синхронной версии (например, [MoveNextAsync()](https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) становится [MoveNext()](https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.ienumerator.movenext))
  - Удаление асинхронных вызовов без суффикса `Async`
  - Удаление параметра [CancellationToken](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.cancellationtoken)
  - Удаление вызова [IProgress\<T>.Report(T)](https://learn.microsoft.com/ru-ru/dotnet/api/system.iprogress-1.report)
  - Удаление свойства [Memory\<T>.Span](https://learn.microsoft.com/ru-ru/dotnet/api/system.memory-1.span)
  - Замена `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.task.fromresult)(`value`) на `value`
  - Замена `await` [Task.Delay](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.task.delay)(`value`) на [Thread.Sleep](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.thread.sleep)(`value`)
  - Замена любого вызова, возвращающего [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/ru-ru/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) на [IEnumerable.GetEnumerator](https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.ienumerable.getenumerator)()
- Удаление `CreateSyncVersionAttribute`
- Обновление XML-документации

#### Свойства

##### OmitNullableDirective

Этот генератор исходного кода определяет версию языка во время компиляции. По умолчанию он будет генерировать директиву `#nullable enable` только если версия языка 8 или выше. Поскольку [невозможно](https://github.com/dotnet/roslyn/issues/49555) надежно определить, включен ли контекст nullable, свойство `OmitNullableDirective` позволяет не генерировать эту директиву.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### Символ SYNC_ONLY

Если есть логика, которую следует выполнять только в синхронизированной версии метода, оберните ее в директиву `#if SYNC_ONLY`.

`SYNC_ONLY` не должен быть определен нигде. Генератор исходного кода будет сканировать директивы #if для этого символа.

Код внутри блока `SYNC_ONLY` будет скопирован как есть. Если в проекте не используются глобальные пространства имен, этот код должен содержать полностью квалифицированные пространства имен.

Следующий синтаксис:

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

выведет:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

Если вы хотите, чтобы код выполнялся только в исходной асинхронной версии, используйте флаг так: `#if !SYNC_ONLY`.

Примечание: `SYNC_ONLY` не может быть объединен с другими символами в условном выражении и не может использоваться с директивой `#elif`.

## Установка

Для добавления библиотеки используйте:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Разработка

### Связанные проекты

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - Позволяет переключаться между синхронной и асинхронной версией метода. Очень полезно при разработке этой библиотеки.

### Act

Этот проект полностью совместим с [act](https://github.com/nektos/act).

Помимо необходимых пакетов для запуска самого `act`, скрипт GitHub Actions устанавливает все, чего может не хватать, например, node, yarn и dotnet. На платформе Windows установка программ производится непосредственно на хосте из-за [отсутствия](https://github.com/nektos/act/issues/1608) поддержки контейнеров.

Чтобы собрать проект с помощью act, выполните следующие инструкции:

#### Windows

Установите [chocolatey](https://chocolatey.org/install), если он отсутствует.

Установите следующие пакеты, если они не установлены:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

В каталоге проекта выполните:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Установите act, следуя этим [инструкциям](https://lindevs.com/install-act-on-ubuntu).

В каталоге проекта выполните:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---