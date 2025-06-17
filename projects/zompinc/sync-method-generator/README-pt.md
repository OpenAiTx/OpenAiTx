# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

Este [gerador de código-fonte do .NET](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) produz um método síncrono a partir de um método assíncrono.

## Casos de uso

- Uma biblioteca que expõe versões síncrona e assíncrona de um método
- Uma aplicação precisa processar dois tipos de dados da mesma forma:
  - Dados grandes vindos de I/O que não podem ser armazenados em memória antes do processamento: Método assíncrono original
  - Pequena amostra de dados em memória, geralmente uma amostra dos dados maiores: Método síncrono gerado

## Como funciona

### CreateSyncVersionAttribute

Decore seu método assíncrono com `CreateSyncVersionAttribute` em sua classe, struct ou record `partial`.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

E será gerada uma versão síncrona do método:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

Lista de alterações aplicadas ao novo método sincronizado:

- Remove o modificador async
- Remove await dos métodos, bem como da instrução `foreach`
- Altera os tipos

  | De                                                                                                                                                                                                  | Para                                                                                                                                |
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
- \* [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask)s são tratados exatamente como [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)s
- Remove parâmetros
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1)
- Alterações de invocação
  - Remove `ConfigureAwait` de [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.configureawait) e [Enumerações Assíncronas](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - Remove `WaitAsync` de [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.waitasync)
  - Remove [WithCancellation](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - Reescreve invocações assíncronas com sufixo `Async` para chamar a versão síncrona (ex: [MoveNextAsync()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) torna-se [MoveNext()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext))
  - Remove invocações assíncronas sem o sufixo `Async`
  - Remove o parâmetro [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - Remove a chamada [IProgress\<T>.Report(T)](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1.report)
  - Remove a propriedade [Memory\<T>.Span](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1.span)
  - Altera `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.fromresult)(`value`) para `value`
  - Altera `await` [Task.Delay](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay)(`value`) para [Thread.Sleep](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep)(`value`)
  - Altera qualquer invocação que retorna [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) para [IEnumerable.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator)()
- Remove `CreateSyncVersionAttribute`
- Atualiza a documentação XML

#### Propriedades

##### OmitNullableDirective

Este gerador de código-fonte detecta a versão da linguagem durante a compilação. Por padrão, ele irá gerar a diretiva `#nullable enable` se, e somente se, a versão da linguagem for 8 ou superior. Como é [impossível](https://github.com/dotnet/roslyn/issues/49555) determinar de forma confiável se o contexto anulável está ativado ou não, a propriedade `OmitNullableDirective` está disponível para omitir essa diretiva na geração.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### Símbolo SYNC_ONLY

Caso exista lógica que deve ser executada apenas na versão sincronizada do método, envolva-a na diretiva `#if SYNC_ONLY`.

`SYNC_ONLY` não deve ser definido em nenhum lugar. O gerador de código-fonte irá escanear as diretivas #if para este símbolo.

O código dentro do bloco `SYNC_ONLY` será copiado como está. A menos que namespaces globais sejam usados no projeto, esse código deve conter namespaces totalmente qualificados.

A seguinte sintaxe:

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

irá gerar:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

Se você deseja executar apenas na versão assíncrona original, inverta o sinal assim: `#if !SYNC_ONLY`.

Nota: `SYNC_ONLY` não pode ser misturado com outros símbolos em uma expressão condicional e não pode ter diretiva `#elif`.

## Instalação

Para adicionar a biblioteca utilize:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Desenvolvimento

### Projetos relacionados

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - Permite alternar entre versões síncrona e assíncrona de um método. Muito útil durante o desenvolvimento desta biblioteca.

### Act

Este projeto é totalmente compatível com o [act](https://github.com/nektos/act).

Além dos pacotes necessários para rodar o próprio `act`, o script do GitHub Actions instala qualquer outra dependência que possa faltar, como node, yarn e dotnet. Na plataforma Windows, a instalação de software é realizada no próprio host devido à [falta](https://github.com/nektos/act/issues/1608) de suporte a containers.

Para construir o projeto usando act, siga estas instruções:

#### Windows

Instale o [chocolatey](https://chocolatey.org/install) se necessário.

Instale os seguintes pacotes, se necessário:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

No diretório do projeto execute:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Instale o act seguindo estas [instruções](https://lindevs.com/install-act-on-ubuntu).

No diretório do projeto execute:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---