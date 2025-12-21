# ReferenceTrimmer
[![NuGet Version](https://img.shields.io/nuget/v/ReferenceTrimmer.svg)](https://www.nuget.org/packages/ReferenceTrimmer)
[![NuGet Downloads](https://img.shields.io/nuget/dt/ReferenceTrimmer.svg)](https://www.nuget.org/packages/ReferenceTrimmer)

Identifiez facilement quelles dépendances C# peuvent être supprimées d’un projet MSBuild, et exposez la sortie MSVC pour afficher les bibliothèques inutilisées et les DLLs chargées en différé au moment du lien. La suppression des dépendances de projet aplatit votre graphe de dépendances de build, ce qui peut améliorer le parallélisme de build et réduire le temps de build de bout en bout.

## Règles
Les avertissements suivants sont générés par ce package :

| Id     | Description |
|--------|-------------|
| RT0000 | Activer la génération de documentation pour une détection précise des références utilisées |
| RT0001 | Référence inutile  |
| RT0002 | Référence de projet inutile |
| RT0003 | Référence de package inutile |

## Comment utiliser
Ajoutez une référence de package au package [ReferenceTrimmer](https://www.nuget.org/packages/ReferenceTrimmer) dans vos projets, ou comme référence de package commune dans le [`Directory.Packages.props`](https://raw.githubusercontent.com/dfederm/ReferenceTrimmer/main/./Directory.Build.props) du dépôt.

Si vous utilisez la [gestion centralisée des packages](https://learn.microsoft.com/en-us/nuget/consume-packages/Central-Package-Management), vous pouvez l’utiliser comme `GlobalPackageReference` dans votre `Directory.Packages.props` pour l’appliquer à l’ensemble du dépôt.

```xml
  <ItemGroup>
    <GlobalPackageReference Include="ReferenceTrimmer" Version="{LatestVersion}" />
  </ItemGroup>
```
### C#
Vous devrez activer la génération de la documentation XML C# pour garantir de bons résultats d'analyse. Si votre dépôt n'utilise pas déjà docxml globalement, cela peut entraîner un grand nombre d'erreurs et d'avertissements spécifiques à docxml. De plus, activer docxml ajoute des entrées/sorties supplémentaires qui peuvent ralentir les grands dépôts.

Vous pouvez désactiver certains avertissements et erreurs liés à docxml tout en désactivant par défaut ReferenceTrimmer à l'aide d'un bloc de code comme celui-ci dans votre `Directory.Build.props`. Activez la compilation ReferenceTrimmer en définissant `/p:EnableReferenceTrimmer=true` dans la ligne de commande MSBuild ou en définissant la même propriété en tant que variable d'environnement. Vous pouvez créer une pipeline de compilation distincte pour votre dépôt afin d'exécuter les compilations ReferenceTrimmer.


```xml
  <!-- ReferenceTrimmer - run build with /p:EnableReferenceTrimmer=true to enable -->
  <PropertyGroup Label="ReferenceTrimmer">
    <EnableReferenceTrimmer Condition=" '$(EnableReferenceTrimmer)' == '' ">false</EnableReferenceTrimmer>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(EnableReferenceTrimmer)' == 'true' and '$(GenerateDocumentationFile)' != 'true' " Label="ReferenceTrimmer">
    <!-- Documentation file generation is required for more accurate C# detection. -->
    <GenerateDocumentationFile>true</GenerateDocumentationFile>

    <!-- Suppress XML doc comment issues to avoid errors during ReferenceTrimmer:
         - CS0419: Ambiguous reference in cref attribute
         - CS1570: XML comment has badly formed XML
         - CS1573: Parameter has no matching param tag in the XML comment
         - CS1574: XML comment has cref attribute that could not be resolved
         - CS1584: XML comment has syntactically incorrect cref attribute
         - CS1591: Missing XML comment for publicly visible type or member
         - SA1602: Enumeration items should be documented
    -->
    <NoWarn>$(NoWarn);419;1570;1573;1574;1584;1591;SA1602</NoWarn>
  </PropertyGroup>
```

Note : Pour obtenir de meilleurs résultats, activez la règle [`IDE0005`](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0005) des `using` inutiles. Cela évite que le compilateur C# détecte à tort une utilisation d’assembly due à des directives `using` non nécessaires, ce qui l’empêcherait de repérer une dépendance supprimable. Voir aussi la note expliquant pourquoi la règle d’analyse de code IDE0005 nécessite que la propriété `<GenerateDocumentationFile>` soit activée. La génération de documentation est aussi requise pour la précision de la détection des références utilisées (basé sur https://github.com/dotnet/roslyn/issues/66188).

### C++ (projets .vcxproj)  
ReferenceTrimmer pour C++ est un [logger distribué](https://learn.microsoft.com/en-us/visualstudio/msbuild/logging-in-a-multi-processor-environment?view=vs-2022) MSBuild. Il écrit des indications dans le flux stdout de MSBuild (pas dans le logger interne MSBuild pour le moment) et crée le fichier `ReferenceTrimmerUnusedMSVCLibraries.json.log` dans le répertoire de travail de la compilation.

Le logger distribué nécessite une configuration en ligne de commande MSBuild via le paramètre `-distributedlogger`. Voir le [script d’exemple BuildWithReferenceTrimmer](https://raw.githubusercontent.com/dfederm/ReferenceTrimmer/main/./examples/BuildWithReferenceTrimmer.cmd) pour savoir comment orchestrer la récupération et l’utilisation des loggers du package.

Utilisez `msbuild -restore` ou `msbuild /t:Restore` au lieu de `dotnet restore` pour garantir que la restauration des .vcxproj fonctionnera et ajoutera les props et targets ReferenceTrimmer à votre compilation. *REMARQUE* : si vous rencontrez une exception `Sequence contains no elements` de MSBuild, consultez https://github.com/dotnet/NuGet.BuildTasks/issues/154 pour une solution de contournement ou l’état d’une correction.

L’implémentation actuelle active les options du lien MSVC `link.exe` `/VERBOSE:UNUSEDLIBS` et `/VERBOSE:UNUSEDDELAYLOAD`. Ces options demandent à l’éditeur de liens d’afficher les fichiers .lib et DLLs chargées en différé non utilisés dans stdout. Cela inclut les fichiers .lib contenant des bundles de code ainsi que les bibliothèques d’importation pour DLLs. Supprimer ces bibliothèques réduit les entrées/sorties et la mémoire utilisée par l’éditeur de liens. Voici un exemple de sortie du linker :

```text
Unused libraries:
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\gdi32.lib
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\winspool.lib
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\comdlg32.lib
```

ReferenceTrimmer lit cette sortie et divise les bibliothèques résultantes en deux ensembles :

#### Bibliothèques d’importation du SDK Windows
Le SDK Microsoft C++ pour MSBuild inclut dans la propriété `AdditionalDependencies` une liste par défaut de bibliothèques d’importation Win32 telles que kernel32.lib et user32.lib. Vous pouvez trouver la liste par défaut dans votre installation locale de VS en recherchant :

```cmd
findstr /s CoreLibraryDependencies "\Program Files"\*props
```

Pour désactiver ceux-ci, modifiez la propriété `<AdditionalDependencies>` du vcxproj pour ne contenir que la liste des fichiers .lib du SDK nécessaires au projet, et n’ajoutez pas `%(AdditionalDependencies)` à la propriété afin d’éviter la liste par défaut. Exemple :

```xml
<ItemDefinitionGroup>
  <Link>
    <AdditionalDependencies>kernel32.lib;shlwapi.lib;ws2_32.lib</AdditionalDependencies>
  </Link>
</ItemDefinitionGroup>
```

Tous les fichiers .lib du SDK ne peuvent pas être supprimés de cette manière. Il peut être nécessaire d'utiliser également `<IgnoreSpecificDefaultLibraries>` :

```xml
<ItemDefinitionGroup>
  <Link>
    <IgnoreSpecificDefaultLibraries>OLDNAMES.lib;%(IgnoreSpecificDefaultLibraries)</IgnoreSpecificDefaultLibraries>
  </Link>
</ItemDefinitionGroup>
```

#### Bibliothèques de package ou de projet
Si vous trouvez un .lib inutilisé créé par un .vcxproj dans votre dépôt, vous devriez pouvoir supprimer la `ProjectReference` à ce vcxproj pour améliorer votre graphe de dépendances de construction et permettre une plus grande parallélisation lors de la construction.

Si vous trouvez un .lib inutilisé provenant d’un package, supprimez la référence à ce .lib de votre projet pour accélérer l’édition des liens.

## Désactivation d’une règle sur une référence
Pour désactiver une règle sur une référence spécifique de projet ou de package, ajoutez le code RTxxxx pertinent à un attribut NoWarn de métadonnées. Par exemple :

```xml
<ProjectReference Include="../Other/Project.csproj" NoWarn="RT0002" />
```

## Configuration
`$(EnableReferenceTrimmer)` - Contrôle si la logique de build doit s'exécuter pour un projet donné. Par défaut à `true`.

`$(ReferenceTrimmerEnableVcxproj)` - Contrôle si les flags de lien MSVC sont configurés pour afficher les bibliothèques inutilisées et les DLL chargées en différé. Par défaut à `true`.

## Comment cela fonctionne-t-il ?

### C#
Il y a deux principaux éléments pour la prise en charge de C#. Tout d'abord, il y a une tâche MSBuild qui collecte toutes les références transmises au compilateur. Il y a également un analyseur Roslyn qui utilise l'API d'analyseur [`GetUsedAssemblyReferences`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.compilation.getusedassemblyreferences) disponible à partir du compilateur Roslyn fourni avec Visual Studio 2019 version 16.10, .NET 5. (voir https://github.com/dotnet/roslyn/blob/main/docs/wiki/NuGet-packages.md#versioning). C'est le compilateur qui nous indique exactement quelles références étaient nécessaires lors de la compilation. L'analyseur compare ensuite l'ensemble des références collectées par la tâche avec celles que le compilateur indique avoir utilisées.

### C++ (projets .vcxproj)
ReferenceTrimmer active les flags `link.exe` de MSVC mentionnés ci-dessus, puis analyse la sortie provenant de la tâche MSBuild `Link`. Il catégorise les sorties et les affiche dans la sortie console MSBuild ainsi que dans le fichier de sortie JSON mentionné ci-dessus. Il n'émet pas d'avertissements MSBuild pour le moment.

## Développements futurs
Le résultat de https://github.com/dotnet/sdk/issues/10414 pourrait être utile pour les futures mises à jour de `ReferenceTrimmer`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-21

---