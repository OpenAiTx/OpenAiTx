# ReferenceTrimmer
[![NuGet Version](https://img.shields.io/nuget/v/ReferenceTrimmer.svg)](https://www.nuget.org/packages/ReferenceTrimmer)
[![NuGet Downloads](https://img.shields.io/nuget/dt/ReferenceTrimmer.svg)](https://www.nuget.org/packages/ReferenceTrimmer)

MSBuildプロジェクトから削除可能なC#依存関係を簡単に特定し、MSVCの出力を表示してリンク時に使用されていないライブラリや遅延ロードDLLを示します。プロジェクトの依存関係を削除するとビルド依存関係グラフが平坦化され、ビルドの並列性が向上し、ビルド全体の時間が短縮されます。

## ルール
このパッケージにより以下の警告が生成されます：

| Id     | 説明 |
|--------|-------------|
| RT0000 | 使用参照検出の精度向上のためドキュメント生成を有効にする |
| RT0001 | 不要な参照 |
| RT0002 | 不要なプロジェクト参照 |
| RT0003 | 不要なパッケージ参照 |

## 使い方
プロジェクトに[ReferenceTrimmer](https://www.nuget.org/packages/ReferenceTrimmer)パッケージの参照を追加するか、リポジトリの[`Directory.Packages.props`](https://raw.githubusercontent.com/dfederm/ReferenceTrimmer/main/./Directory.Build.props)で共通のパッケージ参照として追加します。

[Central Package Management](https://learn.microsoft.com/en-us/nuget/consume-packages/Central-Package-Management)を使用している場合は、`Directory.Packages.props`の`GlobalPackageReference`として追加し、リポジトリ全体に適用できます。

```xml
  <ItemGroup>
    <GlobalPackageReference Include="ReferenceTrimmer" Version="{LatestVersion}" />
  </ItemGroup>
```

### C#
良好な解析結果を得るために、C#のドキュメントXML生成を有効にする必要があります。リポジトリがまだグローバルにdocxmlを使用していない場合、これによりdocxml固有の多くのエラーや警告が発生する可能性があります。さらに、docxmlを有効にすると追加の出力I/Oが発生し、大規模なリポジトリの処理が遅くなることがあります。

`Directory.Build.props`に以下のようなコードブロックを追加することで、ReferenceTrimmerをデフォルトでオフにしつつ、特定のdocxml関連の警告やエラーをオフにできます。ReferenceTrimmerビルドは、MSBuildコマンドラインで`/p:EnableReferenceTrimmer=true`を設定するか、同じプロパティ値を環境変数として設定することで有効にできます。リポジトリ専用のビルドパイプラインを作成し、ReferenceTrimmerビルドを実行することも可能です。

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

注意: より良い結果を得るために、[`IDE0005`](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0005) 不要な `using` ルールを有効にしてください。これにより、C# コンパイラーが不要な `using` ディレクティブからの誤検知されたアセンブリ使用を回避し、削除可能な依存関係を見逃さなくなります。IDE0005 コード解析ルールが `<GenerateDocumentationFile>` プロパティの有効化を必要とする理由についても注記を参照してください。使用されている参照の検出精度向上にはドキュメント生成も必要です（https://github.com/dotnet/roslyn/issues/66188 に基づく）。

### C++ (.vcxproj プロジェクト)
ReferenceTrimmer for C++ は MSBuild の [分散ロガー](https://learn.microsoft.com/en-us/visualstudio/msbuild/logging-in-a-multi-processor-environment?view=vs-2022) です。MSBuild の標準出力ストリーム（現時点で MSBuild 内部ロガーには出力しません）にガイダンスを書き込み、ビルド作業ディレクトリに `ReferenceTrimmerUnusedMSVCLibraries.json.log` を出力します。

分散ロガーは MSBuild コマンドラインで `-distributedlogger` パラメーターを使って設定が必要です。パッケージのロガーを取得し使用する方法については、[BuildWithReferenceTrimmer サンプルスクリプト](https://raw.githubusercontent.com/dfederm/ReferenceTrimmer/main/./examples/BuildWithReferenceTrimmer.cmd) を参照してください。

`.vcxproj` のリストアで ReferenceTrimmer の props と targets をビルドに追加するために、`dotnet restore` の代わりに `msbuild -restore` または `msbuild /t:Restore` を使用してください。*注意*: MSBuild で `Sequence contains no elements` 例外が発生する場合は、https://github.com/dotnet/NuGet.BuildTasks/issues/154 を参照して回避策や修正状況を確認してください。

現在の実装では MSVC の `link.exe` フラグ `/VERBOSE:UNUSEDLIBS` と `/VERBOSE:UNUSEDDELAYLOAD` を有効にしています。これらのフラグはリンカーに未使用の .lib ファイルおよび遅延ロード DLL を標準出力に表示させます。これにはコードバンドルを含む .lib ファイルや DLL のインポートライブラリが含まれます。これらのライブラリを削除することでリンカーの I/O とメモリ使用量を削減します。以下はリンカー出力の例です：

```text
Unused libraries:
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\gdi32.lib
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\winspool.lib
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\comdlg32.lib
```

ReferenceTrimmer はこの出力を読み取り、結果として得られたライブラリを2つのセットに分割します：

#### Windows SDK インポートライブラリ
MSBuild 用 Microsoft C++ SDK は、`AdditionalDependencies` プロパティに kernel32.lib や user32.lib のような Win32 インポートライブラリのデフォルトリストを含みます。ローカルの VS インストールでデフォルトリストを検索するには：

```cmd
findstr /s CoreLibraryDependencies "\Program Files"\*props
```
これらを無効にするには、vcxproj の `<AdditionalDependencies>` プロパティをプロジェクトに必要な SDK の .lib ファイルのリストのみに変更し、デフォルトのリストを避けるために `%(AdditionalDependencies)` をプロパティに追加しないでください。例:


```xml
<ItemDefinitionGroup>
  <Link>
    <AdditionalDependencies>kernel32.lib;shlwapi.lib;ws2_32.lib</AdditionalDependencies>
  </Link>
</ItemDefinitionGroup>
```
すべてのSDKの.libファイルがこの方法で削除できるわけではありません。場合によっては、`<IgnoreSpecificDefaultLibraries>`も使用する必要があります:


```xml
<ItemDefinitionGroup>
  <Link>
    <IgnoreSpecificDefaultLibraries>OLDNAMES.lib;%(IgnoreSpecificDefaultLibraries)</IgnoreSpecificDefaultLibraries>
  </Link>
</ItemDefinitionGroup>
```

#### パッケージまたはプロジェクトライブラリ
リポジトリ内の.vcxprojによって作成された未使用の.libを見つけた場合、そのvcxprojへの`ProjectReference`を削除して、ビルド依存関係グラフを改善し、ビルド時の並列処理を向上させることができます。

パッケージ由来の未使用の.libを見つけた場合は、リンク時間を短縮するために、その.libへの参照をプロジェクトから削除してください。

## 参照に対するルールの無効化
特定のプロジェクトまたはパッケージ参照でルールをオフにするには、該当するRTxxxxコードをNoWarnメタデータ属性に追加します。例：

```xml
<ProjectReference Include="../Other/Project.csproj" NoWarn="RT0002" />
```

## 設定
`$(EnableReferenceTrimmer)` - 指定したプロジェクトでビルドロジックを実行するかどうかを制御します。デフォルトは `true` です。

`$(ReferenceTrimmerEnableVcxproj)` - 使用されていないライブラリや遅延ロードDLLを表示するためにMSVCのリンクフラグを設定するかどうかを制御します。デフォルトは `true` です。

## 仕組み

### C#
C#のサポートには主に2つの要素があります。まず、コンパイラに渡されたすべての参照を収集するMSBuildタスクがあります。さらに、Visual Studio 2019 バージョン16.10、.NET 5から提供されているRoslynコンパイラに付属する [`GetUsedAssemblyReferences`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.compilation.getusedassemblyreferences) アナライザーAPIを使用するRoslynアナライザーがあります（詳細は https://github.com/dotnet/roslyn/blob/main/docs/wiki/NuGet-packages.md#versioning を参照）。これはコンパイルに必要だった参照を正確に教えてくれるコンパイラの機能です。アナライザーはタスクで収集した参照の集合と、コンパイラが使用したと示す参照を比較します。

### C++ (.vcxproj プロジェクト)
ReferenceTrimmerは上記のMSVC `link.exe` フラグを有効にし、`Link` MSBuildタスクからの出力を解析します。出力を分類し、MSBuildコンソール出力および前述のJSON出力ファイルに出力します。現時点ではMSBuildの警告は発行しません。

## 今後の開発
https://github.com/dotnet/sdk/issues/10414 の結果は `ReferenceTrimmer` の今後の更新に役立つ可能性があります。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-21

---