# ReferenceTrimmer
[![NuGet Version](https://img.shields.io/nuget/v/ReferenceTrimmer.svg)](https://www.nuget.org/packages/ReferenceTrimmer)
[![NuGet Downloads](https://img.shields.io/nuget/dt/ReferenceTrimmer.svg)](https://www.nuget.org/packages/ReferenceTrimmer)

Identifique fácilmente qué dependencias de C# se pueden eliminar de un proyecto MSBuild y exponga la salida de MSVC para mostrar bibliotecas no utilizadas y DLLs de carga diferida en tiempo de enlace. Eliminar dependencias del proyecto aplana su gráfico de dependencias de compilación, lo que puede mejorar el paralelismo de la compilación y reducir el tiempo total de construcción.

## Reglas
Las siguientes advertencias son generadas por este paquete:

| Id     | Descripción |
|--------|-------------|
| RT0000 | Habilitar la generación de documentación para la precisión de la detección de referencias usadas |
| RT0001 | Referencia innecesaria  |
| RT0002 | Referencia de proyecto innecesaria |
| RT0003 | Referencia de paquete innecesaria |

## Cómo usar
Agregue una referencia de paquete al paquete [ReferenceTrimmer](https://www.nuget.org/packages/ReferenceTrimmer) en sus proyectos, o como una referencia de paquete común en el [`Directory.Packages.props`](https://raw.githubusercontent.com/dfederm/ReferenceTrimmer/main/./Directory.Build.props) del repositorio.

Si utiliza [Central Package Management](https://learn.microsoft.com/en-us/nuget/consume-packages/Central-Package-Management), puede usarlo como un `GlobalPackageReference` en su `Directory.Packages.props` para aplicarlo a todo el repositorio.

```xml
  <ItemGroup>
    <GlobalPackageReference Include="ReferenceTrimmer" Version="{LatestVersion}" />
  </ItemGroup>
```

### C#
Necesitarás habilitar la generación de XML de documentación de C# para asegurar buenos resultados de análisis. Si tu repositorio no está usando docxml globalmente, esto puede introducir un gran número de errores y advertencias específicas de docxml. Además, activar docxml añade entrada/salida adicional que puede ralentizar repositorios grandes.

Puedes desactivar advertencias y errores específicos relacionados con docxml mientras mantienes ReferenceTrimmer desactivado usando un bloque de código como este en tu `Directory.Build.props`. Activa la compilación de ReferenceTrimmer configurando `/p:EnableReferenceTrimmer=true` en la línea de comandos de MSBuild o estableciendo el mismo valor de propiedad como variable de entorno. Podrías crear una canalización de compilación separada para tu repositorio para ejecutar compilaciones de ReferenceTrimmer.

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
Nota: Para obtener mejores resultados, active la regla innecesaria de `using` [`IDE0005`](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0005). Esto evita que el compilador de C# detecte un uso falso positivo de ensamblado debido a directivas `using` no necesarias, lo que puede hacer que pase por alto una dependencia que se puede eliminar. Vea también la nota sobre por qué la regla de análisis de código IDE0005 requiere que la propiedad `<GenerateDocumentationFile>` esté habilitada. La generación de documentación también es necesaria para la precisión en la detección de referencias usadas (basado en https://github.com/dotnet/roslyn/issues/66188).

### C++ (proyectos .vcxproj)
ReferenceTrimmer para C++ es un registrador distribuido (distributed logger) de MSBuild [distributed logger](https://learn.microsoft.com/en-us/visualstudio/msbuild/logging-in-a-multi-processor-environment?view=vs-2022). Escribe instrucciones en el flujo stdout de MSBuild (no en el registrador interno de MSBuild en este momento) y escribe `ReferenceTrimmerUnusedMSVCLibraries.json.log` en el directorio de trabajo de la compilación.

El registrador distribuido requiere configuración en la línea de comandos de MSBuild usando el parámetro `-distributedlogger`. Consulte el [script de ejemplo BuildWithReferenceTrimmer](https://raw.githubusercontent.com/dfederm/ReferenceTrimmer/main/./examples/BuildWithReferenceTrimmer.cmd) para ver cómo orquestar la descarga y uso de los registradores del paquete.

Use `msbuild -restore` o `msbuild /t:Restore` en lugar de `dotnet restore` para asegurar que la restauración de .vcxproj funcione para agregar las propiedades y objetivos ReferenceTrimmer a su compilación. *NOTA*: Si ve una excepción `Sequence contains no elements` de MSBuild, consulte https://github.com/dotnet/NuGet.BuildTasks/issues/154 para una solución alternativa o estado de una corrección.

La implementación actual activa las banderas de `link.exe` de MSVC `/VERBOSE:UNUSEDLIBS` y `/VERBOSE:UNUSEDDELAYLOAD`. Estas banderas indican al enlazador que imprima en stdout los archivos .lib y DLLs de carga diferida no usados. Esto incluirá archivos .lib que contienen paquetes de código así como bibliotecas de importación para DLLs. Eliminar estas bibliotecas reduce la E/S y el uso de memoria del enlazador. Aquí hay un ejemplo de la salida del enlazador:


```text
Unused libraries:
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\gdi32.lib
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\winspool.lib
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\comdlg32.lib
```

ReferenceTrimmer lee esta salida y divide las bibliotecas resultantes en dos conjuntos:

#### Bibliotecas de importación del SDK de Windows
El SDK de Microsoft C++ para MSBuild incluye en la propiedad `AdditionalDependencies` una lista predeterminada de bibliotecas de importación Win32 como kernel32.lib y user32.lib. Puedes encontrar la lista predeterminada en tu instalación local de VS buscando:

```cmd
findstr /s CoreLibraryDependencies "\Program Files"\*props
```

Para deshabilitar estos, modifique la propiedad `<AdditionalDependencies>` del archivo vcxproj para que contenga solo la lista de archivos .lib del SDK necesarios para el proyecto, y no agregue `%(AdditionalDependencies)` a la propiedad para evitar la lista predeterminada. Ejemplo:

```xml
<ItemDefinitionGroup>
  <Link>
    <AdditionalDependencies>kernel32.lib;shlwapi.lib;ws2_32.lib</AdditionalDependencies>
  </Link>
</ItemDefinitionGroup>
```

No todos los archivos .lib del SDK pueden eliminarse de esta manera. Es posible que también necesite usar `<IgnoreSpecificDefaultLibraries>`:

```xml
<ItemDefinitionGroup>
  <Link>
    <IgnoreSpecificDefaultLibraries>OLDNAMES.lib;%(IgnoreSpecificDefaultLibraries)</IgnoreSpecificDefaultLibraries>
  </Link>
</ItemDefinitionGroup>
```

#### Bibliotecas de paquete o proyecto
Si encuentras un archivo .lib no utilizado que es creado por un .vcxproj en tu repositorio, deberías poder eliminar la `ProjectReference` a ese vcxproj para mejorar el grafo de dependencias de compilación y permitir un mayor paralelismo durante la compilación.

Si encuentras un archivo .lib no utilizado que proviene de un paquete, elimina la referencia a ese .lib de tu proyecto para acelerar el enlace.

## Deshabilitar una regla en una referencia
Para desactivar una regla en un proyecto específico o referencia de paquete, agrega el código RTxxxx relevante a un atributo de metadatos NoWarn. Por ejemplo:

```xml
<ProjectReference Include="../Other/Project.csproj" NoWarn="RT0002" />
```

## Configuración
`$(EnableReferenceTrimmer)` - Controla si la lógica de compilación debe ejecutarse para un proyecto dado. Por defecto es `true`.

`$(ReferenceTrimmerEnableVcxproj)` - Controla si se configuran las banderas de enlace de MSVC para imprimir bibliotecas no usadas y DLLs de carga retardada. Por defecto es `true`.

## ¿Cómo funciona?

### C#
Hay dos componentes principales para el soporte de C#. Primero, hay una tarea de MSBuild que recopila todas las referencias pasadas al compilador. También hay un Analizador Roslyn que usa la API de analizador [`GetUsedAssemblyReferences`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.compilation.getusedassemblyreferences), disponible desde el compilador Roslyn incluido en Visual Studio 2019 versión 16.10, .NET 5. (ver https://github.com/dotnet/roslyn/blob/main/docs/wiki/NuGet-packages.md#versioning). Este es el compilador indicándonos exactamente qué referencias se necesitaron durante la compilación. El analizador luego compara el conjunto de referencias que la tarea recopiló con las que el compilador dice que se usaron.

### C++ (proyectos .vcxproj)
ReferenceTrimmer habilita las banderas de MSVC `link.exe` mencionadas arriba, luego analiza la salida proveniente de la tarea `Link` de MSBuild. Categoriza las salidas y las emite en la salida de consola de MSBuild y en el archivo JSON mencionado arriba. Actualmente no emite advertencias de MSBuild.

## Desarrollo futuro
El resultado de https://github.com/dotnet/sdk/issues/10414 podría ser útil para futuras actualizaciones de `ReferenceTrimmer`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-21

---