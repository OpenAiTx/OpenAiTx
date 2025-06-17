# Générateur de Méthodes Synchrones

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

Ce [générateur de code source .NET](https://learn.microsoft.com/fr-fr/dotnet/csharp/roslyn-sdk/source-generators-overview) produit une méthode synchrone à partir d'une méthode asynchrone.

## Cas d’utilisation

- Une bibliothèque qui expose à la fois une version synchrone et asynchrone d’une méthode
- Une application doit traiter deux types de données de la même manière :
  - De grandes données provenant d’E/S qui ne peuvent pas être stockées en mémoire avant traitement : Méthode asynchrone d’origine
  - Un petit échantillon de données en mémoire, généralement un échantillon des grandes données : Méthode synchrone générée

## Fonctionnement

### CreateSyncVersionAttribute

Décorez votre méthode asynchrone avec `CreateSyncVersionAttribute` dans votre classe, struct ou record `partial`.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

Une version synchrone de la méthode sera alors générée :

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

Liste des modifications appliquées à la nouvelle méthode synchronisée :

- Suppression du modificateur async
- Suppression de await dans les méthodes ainsi que dans les instructions `foreach`
- Modification des types

  | De                                                                                                                                                                                                | Vers                                                                                                                                    |
  | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
  | [Task](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.tasks.task)*                                                                                                                 | void                                                                                                                                   |
  | [Task\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.tasks.task-1)                                                                                                            | T                                                                                                                                      |
  | [Func](https://learn.microsoft.com/fr-fr/dotnet/api/system.func-1)\<Task>                                                                                                                         | [Action](https://learn.microsoft.com/fr-fr/dotnet/api/system.action)                                                                   |
  | Func\<Task\<T>>                                                                                                                                                                                   | Func\<T>                                                                                                                               |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                | [IEnumerable\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.ienumerable-1)                                |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                | [IEnumerator\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.ienumerator-1)                                |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/fr-fr/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)               | [IEnumerator\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.ienumerator-1)                                |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/fr-fr/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.ienumerable-1.getenumerator)    |
  | [Memory\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.memory-1)                                                                                                                        | [Span\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.span-1)                                                                 |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.readonlymemory-1)                                                                                                        | [ReadOnlySpan\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.readonlyspan-1)                                                 |
- \* Les [ValueTask](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.tasks.valuetask) sont traités exactement comme les [Task](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.tasks.task)
- Suppression des paramètres
  - [CancellationToken](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.iprogress-1)
- Modifications des appels
  - Suppression de `ConfigureAwait` sur les [Tasks](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.tasks.task.configureawait) et [énumérations asynchrones](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - Suppression de `WaitAsync` sur les [Tasks](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.tasks.task.waitasync)
  - Suppression de [WithCancellation](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - Réécriture des appels asynchrones avec le suffixe `Async` pour appeler la version synchrone (ex. [MoveNextAsync()](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) devient [MoveNext()](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.ienumerator.movenext))
  - Suppression des appels asynchrones sans suffixe `Async`
  - Suppression du paramètre [CancellationToken](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.cancellationtoken)
  - Suppression de l’appel à [IProgress\<T>.Report(T)](https://learn.microsoft.com/fr-fr/dotnet/api/system.iprogress-1.report)
  - Suppression de la propriété [Memory\<T>.Span](https://learn.microsoft.com/fr-fr/dotnet/api/system.memory-1.span)
  - Modification de `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.tasks.task.fromresult)(`value`) en `value`
  - Modification de `await` [Task.Delay](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.tasks.task.delay)(`value`) en [Thread.Sleep](https://learn.microsoft.com/fr-fr/dotnet/api/system.threading.thread.sleep)(`value`)
  - Toute invocation retournant [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/fr-fr/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) devient [IEnumerable.GetEnumerator](https://learn.microsoft.com/fr-fr/dotnet/api/system.collections.ienumerable.getenumerator)()
- Suppression de `CreateSyncVersionAttribute`
- Mise à jour de la documentation XML

#### Propriétés

##### OmitNullableDirective

Ce générateur de code source détecte la version du langage lors de la compilation. Par défaut, il va générer la directive `#nullable enable` si et seulement si la version du langage est 8 ou supérieure. Comme il est [impossible](https://github.com/dotnet/roslyn/issues/49555) de déterminer de manière fiable si le contexte nullable est activé ou non, la propriété `OmitNullableDirective` est disponible pour omettre cette directive lors de la génération.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### Symbole SYNC_ONLY

Si une logique doit être exécutée uniquement dans la version synchronisée de la méthode, encadrez-la avec la directive `#if SYNC_ONLY`.

`SYNC_ONLY` ne doit pas être défini ailleurs. Le générateur de code source va analyser les directives #if à la recherche de ce symbole.

Le code à l’intérieur du bloc `SYNC_ONLY` sera copié tel quel. Sauf si des espaces de noms globaux sont utilisés dans le projet, ce code doit contenir des espaces de noms pleinement qualifiés.

La syntaxe suivante :

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

donnera en sortie :

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

Si vous souhaitez exécuter un code uniquement dans la version asynchrone d’origine, inversez le drapeau ainsi : `#if !SYNC_ONLY`.

Remarque : `SYNC_ONLY` ne peut pas être combiné à d’autres symboles dans une expression conditionnelle et ne peut pas avoir de directive `#elif`.

## Installation

Pour ajouter la bibliothèque, utilisez :

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Développement

### Projets connexes

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - Permet de basculer entre les versions synchrones et asynchrones d’une méthode. Très utile pour le développement de cette bibliothèque.

### Act

Ce projet est entièrement compatible avec [act](https://github.com/nektos/act).

En dehors des paquets nécessaires pour exécuter `act` lui-même, le script GitHub Actions installe tout ce qui pourrait manquer, comme node, yarn et dotnet. Sur la plateforme Windows, l’installation des logiciels est effectuée sur l’hôte lui-même en raison du [manque](https://github.com/nektos/act/issues/1608) de support des conteneurs.

Pour construire le projet avec act, suivez ces instructions :

#### Windows

Installez [chocolatey](https://chocolatey.org/install) si besoin.

Installez les paquets suivants si besoin :

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

Dans le répertoire du projet, exécutez :

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Installez act en suivant ces [instructions](https://lindevs.com/install-act-on-ubuntu).

Dans le répertoire du projet, exécutez :

```pwsh
act --artifact-server-path /tmp/artifacts
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---