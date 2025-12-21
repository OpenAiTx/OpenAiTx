# ReferenceTrimmer
[![NuGet Version](https://img.shields.io/nuget/v/ReferenceTrimmer.svg)](https://www.nuget.org/packages/ReferenceTrimmer)
[![NuGet Downloads](https://img.shields.io/nuget/dt/ReferenceTrimmer.svg)](https://www.nuget.org/packages/ReferenceTrimmer)

轻松识别哪些 C# 依赖可以从 MSBuild 项目中移除，并暴露 MSVC 输出以显示链接时未使用的库和延迟加载的 DLL。移除项目依赖关系可以扁平化您的构建依赖图，从而提高构建并行度并减少端到端的构建时间。

## 规则
本包会生成以下警告：

| Id     | 描述          |
|--------|--------------|
| RT0000 | 启用文档生成以确保已用引用检测的准确性 |
| RT0001 | 不必要的引用  |
| RT0002 | 不必要的项目引用 |
| RT0003 | 不必要的包引用 |

## 使用方法
在您的项目中添加对 [ReferenceTrimmer](https://www.nuget.org/packages/ReferenceTrimmer) 包的引用，或作为仓库中 [`Directory.Packages.props`](https://raw.githubusercontent.com/dfederm/ReferenceTrimmer/main/./Directory.Build.props) 的公共包引用。

如果您使用的是 [中央包管理](https://learn.microsoft.com/en-us/nuget/consume-packages/Central-Package-Management)，可以将其作为 `GlobalPackageReference` 添加到您的 `Directory.Packages.props` 中，以应用于整个仓库。

```xml
  <ItemGroup>
    <GlobalPackageReference Include="ReferenceTrimmer" Version="{LatestVersion}" />
  </ItemGroup>
```
### C#
你需要启用 C# 文档 XML 生成以确保良好的分析结果。如果你的仓库尚未全局使用 docxml，这可能会引入大量特定于 docxml 的错误和警告。此外，开启 docxml 会增加额外的输出 I/O，可能会减慢大型仓库的速度。

你可以在 `Directory.Build.props` 中使用如下代码块关闭特定的 docxml 相关警告和错误，同时默认关闭 ReferenceTrimmer。通过在 MSBuild 命令行上设置 `/p:EnableReferenceTrimmer=true` 或将相同的属性值设置为环境变量，可以开启 ReferenceTrimmer 构建。你也可以为你的仓库创建一个单独的构建管道来运行 ReferenceTrimmer 构建。


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
注意：为了获得更好的效果，请启用 [`IDE0005`](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0005) 不必要的 `using` 规则。这可以避免 C# 编译器因未使用的 `using` 指令产生的错误正向程序集使用，从而错过可移除的依赖项。另请参阅 IDE0005 代码分析规则为何需要启用 `<GenerateDocumentationFile>` 属性的说明。文档生成也是检测已用引用准确性的必要条件（基于 https://github.com/dotnet/roslyn/issues/66188）。

### C++ (.vcxproj 项目)
ReferenceTrimmer 对于 C++ 是一个 MSBuild [分布式记录器](https://learn.microsoft.com/en-us/visualstudio/msbuild/logging-in-a-multi-processor-environment?view=vs-2022)。它将指导信息写入 MSBuild 标准输出流（目前不是写入 MSBuild 内部记录器），并将 `ReferenceTrimmerUnusedMSVCLibraries.json.log` 写入构建工作目录。

分布式记录器需要在 MSBuild 命令行使用 `-distributedlogger` 参数进行配置。有关如何协调拉取和使用该包的记录器，请参见 [BuildWithReferenceTrimmer 示例脚本](https://raw.githubusercontent.com/dfederm/ReferenceTrimmer/main/./examples/BuildWithReferenceTrimmer.cmd)。

使用 `msbuild -restore` 或 `msbuild /t:Restore` 替代 `dotnet restore`，以确保 .vcxproj 的还原能够正常工作，从而将 ReferenceTrimmer 的 props 和 targets 添加到构建中。*注意*：如果您在 MSBuild 中看到 `Sequence contains no elements` 异常，请参阅 https://github.com/dotnet/NuGet.BuildTasks/issues/154 了解解决方法或修复状态。

当前实现开启了 MSVC `link.exe` 标志 `/VERBOSE:UNUSEDLIBS` 和 `/VERBOSE:UNUSEDDELAYLOAD`。这些标志指示链接器将未使用的 .lib 文件和延迟加载 DLL 打印到标准输出。这将包括包含代码包的 .lib 文件以及 DLL 的导入库。移除这些库可以减少链接器的 I/O 和内存使用。以下是链接器输出示例：


```text
Unused libraries:
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\gdi32.lib
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\winspool.lib
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\comdlg32.lib
```

ReferenceTrimmer 读取此输出并将生成的库拆分为两组：

#### Windows SDK 导入库
用于 MSBuild 的 Microsoft C++ SDK 在 `AdditionalDependencies` 属性中包含了默认的 Win32 导入库列表，如 kernel32.lib 和 user32.lib。您可以通过搜索在本地 VS 安装中找到默认列表：

```cmd
findstr /s CoreLibraryDependencies "\Program Files"\*props
```

要禁用这些，请修改 vcxproj 中的 `<AdditionalDependencies>` 属性，仅包含项目所需的 SDK .lib 文件列表，并且不要将 `%(AdditionalDependencies)` 添加到该属性中，以避免使用默认列表。示例： 

```xml
<ItemDefinitionGroup>
  <Link>
    <AdditionalDependencies>kernel32.lib;shlwapi.lib;ws2_32.lib</AdditionalDependencies>
  </Link>
</ItemDefinitionGroup>
```

并非所有 SDK 的 .lib 文件都可以通过这种方式移除。您可能还需要使用 `<IgnoreSpecificDefaultLibraries>` ：

```xml
<ItemDefinitionGroup>
  <Link>
    <IgnoreSpecificDefaultLibraries>OLDNAMES.lib;%(IgnoreSpecificDefaultLibraries)</IgnoreSpecificDefaultLibraries>
  </Link>
</ItemDefinitionGroup>
```

#### 包或项目库
如果你发现仓库中某个 .vcxproj 生成了未使用的 .lib 文件，你应该能够移除对该 vcxproj 的 `ProjectReference`，以优化构建依赖图并在构建过程中实现更高的并行度。

如果你发现未使用的 .lib 文件来自某个包，请从项目中移除对该 .lib 的引用，以加快链接速度。

## 在引用上禁用规则
要关闭特定项目或包引用上的规则，请将相关的 RTxxxx 代码添加到 NoWarn 元数据属性中。例如：

```xml
<ProjectReference Include="../Other/Project.csproj" NoWarn="RT0002" />
```

## 配置
`$(EnableReferenceTrimmer)` - 控制是否为给定项目运行构建逻辑。默认为 `true`。

`$(ReferenceTrimmerEnableVcxproj)` - 控制是否设置 MSVC 链接标志以打印未使用的库和延迟加载的 DLL。默认为 `true`。

## 它是如何工作的？

### C#
C# 支持主要有两个部分。首先有一个 MSBuild 任务，它收集传递给编译器的所有引用。还有一个 Roslyn 分析器，使用 [`GetUsedAssemblyReferences`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.compilation.getusedassemblyreferences) 分析器 API，该 API 从随 Visual Studio 2019 版本 16.10 发布的 Roslyn 编译器和 .NET 5 开始可用。（参见 https://github.com/dotnet/roslyn/blob/main/docs/wiki/NuGet-packages.md#versioning）。这是编译器告诉我们编译时到底需要哪些引用。分析器随后将任务收集的引用集合与编译器所说的已使用引用进行比较。

### C++（.vcxproj 项目）
ReferenceTrimmer 启用上述 MSVC `link.exe` 标志，然后解析来自 `Link` MSBuild 任务的输出。它对输出进行分类，并将其发布到 MSBuild 控制台输出和上述 JSON 输出文件中。目前它不会发出 MSBuild 警告。

## 未来开发
https://github.com/dotnet/sdk/issues/10414 的结果可能对 `ReferenceTrimmer` 未来的更新有用。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-21

---