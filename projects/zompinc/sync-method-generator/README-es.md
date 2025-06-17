# Generador de Métodos Sincrónicos

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Soporte .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

Este [generador de código fuente para .NET](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) produce un método sincrónico a partir de uno asincrónico.

## Casos de uso

- Una biblioteca que expone ambas versiones, sincrónica y asincrónica, de un método
- Una aplicación que debe procesar dos tipos de datos de la misma manera:
  - Datos grandes provenientes de I/O que no pueden almacenarse en memoria antes de procesar: Método asincrónico original
  - Muestra pequeña de datos en memoria, usualmente una muestra de los datos grandes: Método sincrónico generado

## Cómo funciona

### CreateSyncVersionAttribute

Decora tu método asincrónico con `CreateSyncVersionAttribute` en tu clase, struct o record `partial`

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

Y generará una versión sincrónica del método:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

Lista de cambios aplicados al nuevo método sincronizado:

- Elimina el modificador async
- Elimina await de los métodos así como de la instrucción `foreach`
- Cambia los tipos

  | De                                                                                                                                                                                                | A                                                                                                                                   |
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
- \* [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask)s son tratados exactamente igual que [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)s
- Elimina parámetros
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1)
- Cambios en invocación
  - Elimina `ConfigureAwait` de [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.configureawait) y [Enumeraciones Asíncronas](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - Elimina `WaitAsync` de [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.waitasync)
  - Elimina [WithCancellation](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - Reescribe invocaciones asíncronas con sufijo `Async` para llamar a la versión sincrónica (por ejemplo, [MoveNextAsync()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) se convierte en [MoveNext()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext))
  - Elimina invocaciones asíncronas sin el sufijo `Async`
  - Elimina el parámetro [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - Elimina la llamada [IProgress\<T>.Report(T)](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1.report)
  - Elimina la propiedad [Memory\<T>.Span](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1.span)
  - Cambia `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.fromresult)(`value`) por `value`
  - Cambia `await` [Task.Delay](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay)(`value`) por [Thread.Sleep](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep)(`value`)
  - Cambia cualquier invocación que retorne [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) por [IEnumerable.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator)()
- Elimina `CreateSyncVersionAttribute`
- Actualiza la documentación XML

#### Propiedades

##### OmitNullableDirective

Este generador de código fuente detecta la versión del lenguaje durante la compilación. Por defecto, generará la directiva `#nullable enable` solo si la versión del lenguaje es 8 o superior. Ya que es [imposible](https://github.com/dotnet/roslyn/issues/49555) determinar de forma confiable si el contexto nullable está activado o no, la propiedad `OmitNullableDirective` está disponible para omitir dicha directiva en la generación.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### Símbolo SYNC_ONLY

En caso de que haya lógica que solo deba ejecutarse en la versión sincronizada del método, encierra dicha lógica en la directiva `#if SYNC_ONLY`.

`SYNC_ONLY` no debe estar definido en ninguna parte. El generador de código fuente escaneará las directivas #if para este símbolo.

El código dentro del bloque `SYNC_ONLY` será copiado tal cual. A menos que se usen espacios de nombres globales en el proyecto, este código debe contener espacios de nombres completamente calificados.

La siguiente sintaxis:

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

producirá:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

Si solo quieres ejecutar en la versión asincrónica original, invierte el flag así: `#if !SYNC_ONLY`.

Nota: `SYNC_ONLY` no puede mezclarse con otros símbolos en una expresión condicional y no puede tener la directiva `#elif`.

## Instalación

Para agregar la biblioteca utiliza:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Desarrollo

### Proyectos relacionados

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - Permite alternar entre versiones sincrónica y asincrónica de un método. Muy útil en el desarrollo de esta biblioteca.

### Act

Este proyecto es totalmente compatible con [act](https://github.com/nektos/act).

Además de los paquetes requeridos para ejecutar `act` en sí, el script de GitHub Actions instala cualquier otra cosa que pueda faltar, como node, yarn y dotnet. En la plataforma Windows, la instalación del software se realiza en el propio host debido a la [falta](https://github.com/nektos/act/issues/1608) de soporte para contenedores.

Para compilar el proyecto utilizando act, sigue estas instrucciones:

#### Windows

Instala [chocolatey](https://chocolatey.org/install) si no lo tienes.

Instala los siguientes paquetes si no los tienes:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

En el directorio del proyecto ejecuta:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Instala act siguiendo estas [instrucciones](https://lindevs.com/install-act-on-ubuntu).

En el directorio del proyecto ejecuta:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---