# Sep - 世界上最快的 .NET CSV 解析器
![.NET](https://img.shields.io/badge/net8.0%20net9.0-5C2D91?logo=.NET&labelColor=gray)
![C#](https://img.shields.io/badge/C%23-13.0-239120?labelColor=gray)
[![Build Status](https://github.com/nietras/Sep/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/nietras/Sep/actions/workflows/dotnet.yml)
[![Super-Linter](https://github.com/nietras/Sep/actions/workflows/super-linter.yml/badge.svg)](https://github.com/marketplace/actions/super-linter)
[![codecov](https://codecov.io/gh/nietras/Sep/branch/main/graph/badge.svg?token=WN56CR3X0D)](https://codecov.io/gh/nietras/Sep)
[![CodeQL](https://github.com/nietras/Sep/workflows/CodeQL/badge.svg)](https://github.com/nietras/Sep/actions?query=workflow%3ACodeQL)
[![Nuget](https://img.shields.io/nuget/v/Sep?color=purple)](https://www.nuget.org/packages/Sep/)
[![Release](https://img.shields.io/github/v/release/nietras/Sep)](https://github.com/nietras/Sep/releases/)
[![downloads](https://img.shields.io/nuget/dt/Sep)](https://www.nuget.org/packages/Sep)
![Size](https://img.shields.io/github/repo-size/nietras/Sep.svg)
[![License](https://img.shields.io/github/license/nietras/Sep)](https://github.com/nietras/Sep/blob/main/LICENSE)
[![Blog](https://img.shields.io/badge/blog-nietras.com-4993DD)](https://nietras.com)
![GitHub Repo stars](https://img.shields.io/github/stars/nietras/Sep?style=flat)

现代、极简、极速、零分配，支持分隔值（如 `csv`、`tsv` 等）的读写。跨平台、可裁剪，兼容 AOT/NativeAOT。API 设计有主见，面向实际，特别针对机器学习场景实现。

⭐ 如果你喜欢这个项目，请为其加星。⭐

**🌃  现代化** - 利用 [`Span<T>`](https://learn.microsoft.com/en-us/archive/msdn-magazine/2018/january/csharp-all-about-span-exploring-a-new-net-mainstay)、[泛型数学](https://devblogs.microsoft.com/dotnet/dotnet-7-generic-math/)（[`ISpanParsable<T>`](https://learn.microsoft.com/en-us/dotnet/api/system.ispanparsable-1)/[`ISpanFormattable`](https://learn.microsoft.com/en-us/dotnet/api/system.ispanformattable)）、[`ref struct`](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/ref-struct)、[`ArrayPool<T>`](https://learn.microsoft.com/en-us/dotnet/api/system.buffers.arraypool-1) 以及 [.NET 7+ 和 C# 11+](https://nietras.com/2022/11/26/dotnet-and-csharp-versions/) 的相关特性，带来现代且高效的实现。

**🔎 极简** - 简洁且表达力强的 API，选项少，无隐藏的输入输出变化。读写即所得。例如默认情况下不会“自动”转义/反转义引号或修剪空格。可通过 [SepReaderOptions](#sepreaderoptions)、[Unescaping](#unescaping) 和 [Trimming](#trimming) 开启。写入端的 [转义](#escaping) 见 [SepWriterOptions](#sepwriteroptions)。

**🚀 极速** - 支持架构相关和跨平台的 SIMD 向量化解析，包括 64/128/256/512-bit 路径，如 AVX2、AVX-512（.NET 8.0+）、NEON。浮点解析集成 [csFastFloat](https://github.com/CarlVerret/csFastFloat)。跨平台详细[性能基准](#comparison-benchmarks)。

**🌪️ 多线程** - 高效的并行 CSV 解析，[速度可达 CsvHelper 的 35 倍](#floats-reader-comparison-benchmarks)，详见 [ParallelEnumerate](#parallelenumerate-and-enumerate) 与[性能基准](#comparison-benchmarks)。

**🌀 异步支持** - 高效的基于 `ValueTask` 的 `async/await` 支持。需 C# 13.0+，.NET 9.0+ 下 `SepReader` 实现 `IAsyncEnumerable<>`。详见 [Async Support](#async-support)。

**🗑️ 零分配** - 智能高效的内存管理，预热后零分配，轻松支持读写值数组（如特征）而无需反复分配。

**✅ 充分测试** - 覆盖率高，重点关注边界条件测试，包括随机 [fuzz 测试](https://en.wikipedia.org/wiki/Fuzzing)。

**🌐 跨平台** - 适用于所有 .NET 支持的平台和架构。100% 纯托管，现代 C# 编写。

**✂️ 可裁剪且兼容 AOT/NativeAOT** - 无反射或动态代码生成，完全[可裁剪](https://learn.microsoft.com/en-us/dotnet/core/deploying/trimming/prepare-libraries-for-trimming)且[AOT](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/) 兼容。控制台测试程序可精简至数 MB。💾

**🗣️ 有主见且实用** - 遵循 [RFC-4180](https://www.ietf.org/rfc/rfc4180.txt) 基本规范，但对引号与行结束等细节采取有主见的实用做法。见 [RFC-4180](#rfc-4180)。

[示例](#example) | [命名与术语](#naming-and-terminology) | [API](#application-programming-interface-api) | [限制与约束](#limitations-and-constraints) | [性能对比](#comparison-benchmarks) | [示例目录](#example-catalogue) | [RFC-4180](#rfc-4180) | [FAQ](#frequently-asked-questions-faq)  | [API 参考](#public-api-reference)

## 示例
```csharp
var text = """
           A;B;C;D;E;F
           Sep;🚀;1;1.2;0.1;0.5
           CSV;✅;2;2.2;0.2;1.5
           """;

using var reader = Sep.Reader().FromText(text);   // 从表头自动推断分隔符
using var writer = reader.Spec.Writer().ToText(); // Writer 由 reader 'Spec' 定义
                                                  // 读写文件请用 .FromFile(...)/ToFile(...)
var idx = reader.Header.IndexOf("B");
var nms = new[] { "E", "F" };

foreach (var readRow in reader)           // 逐行读取
{
    var a = readRow["A"].Span;            // ReadOnlySpan<char> 方式取列
    var b = readRow[idx].ToString();      // 列转为 string（可能被池化）
    var c = readRow["C"].Parse<int>();    // 解析为任意 T : ISpanParsable<T>
    var d = readRow["D"].Parse<float>();  // 浮点用 csFastFloat 快速解析
    var s = readRow[nms].Parse<double>(); // 多列解析为 Span<T>
                                          // - Sep 自动管理数组分配与复用
    foreach (ref var v in s) { v *= 10; }

    using var writeRow = writer.NewRow(); // 新起一行，Dispose 时写入
    writeRow["A"].Set(a);                 // Set 支持 ReadOnlySpan<char>
    writeRow["B"].Set(b);                 // Set 支持 string
    writeRow["C"].Set($"{c * 2}");        // 支持插值字符串，无分配
    writeRow["D"].Format(d / 2);          // Format 任意 T : ISpanFormattable
    writeRow[nms].Format(s);              // 多列直接格式化
    // 列首次访问时自动添加，表头在写首行时写出
}

var expected = """
               A;B;C;D;E;F
               Sep;🚀;2;0.6;1;5
               CSV;✅;4;1.1;2;15
               
               """;                       // 结尾空行用于统一行结束符
Assert.AreEqual(expected, writer.ToString());

// 上述代码仅供演示。
// 命名简短、常量重复仅为展示。
```

## 命名与术语
Sep 的命名/术语不依赖 [RFC-4180](#rfc-4180)，而是更贴合机器学习等领域使用场景，并在合适时采用缩写或简写以简化代码且不引起歧义。例如用 `Sep` 表示 `Separator`，用 `Col` 表示 `Column`。

|术语 | 说明 |
|-----|------|
|`Sep` | 分隔符（separator/delimiter）的缩写。例如逗号（`,`）为 CSV 文件的分隔符。|
|`Header` | 可选的首行，用于定义列名。|
|`Row` | 一行由若干列（col/column）组成，可能跨多行。又称 record。|
|`Col` | 列（column/field）的缩写。|
|`Line` | 一行字符，行结束于 `\r\n`、`\r`、`\n`。|
|`Index` | 0 基索引，如 `RowIndex` 为 0 表示首行（或表头）。|
|`Number` | 1 基索引，如 `LineNumber` 为 1 表示首行（如 notepad）。由于一行可能跨多行，所以行号有 *From* 和 *ToExcl* 区间，语法如 C# 的 `[LineNumberFrom..LineNumberToExcl]`。|

## 应用编程接口（API）
`Sep` 不仅是库的简写名，也是使用的入口和合法分隔符的容器。其基本定义如下：
```csharp
public readonly record struct Sep(char Separator);
```
构造时会校验分隔符字符，保证在限定范围内且不是如 `"`（引号）等特殊字符。见 [src/Sep/Sep.cs](https://raw.githubusercontent.com/nietras/Sep/main/src/Sep/Sep.cs)。出于内部优化，分隔符也有限制，不能任用任意字符。

⚠ 注意所有类型均在命名空间 `nietras.SeparatedValues` 下，而非 `Sep`，因为类型与命名空间同名会有问题。

入门时可用 `Sep` 作为静态入口创建 reader 或 writer。例如，reader 用法如下：
```csharp
using var reader = Sep.Reader().FromFile("titanic.csv");
```
其中 `.Reader()` 相当于：
```csharp
using var reader = Sep.Auto.Reader().FromFile("titanic.csv");
```
`Sep? Auto => null;` 为静态属性，返回 `null` 表示分隔符需从首行（可能是表头）自动推断。若首行没有支持的分隔符或无行，则采用默认分隔符。

⚠ Sep 默认分隔符为 `;`，因为内部专有库原本如此设计，也可避免 `,` 在部分本地化场景被用作小数点而必须加引号。

如需指定分隔符，可写：
```csharp
using var reader = Sep.New(',').Reader().FromFile("titanic.csv");
```
或
```csharp
var sep = new Sep(',');
using var reader = sep.Reader().FromFile("titanic.csv");
```
writer 类似：
```csharp
using var writer = Sep.Writer().ToFile("titanic.csv");
```
或
```csharp
using var writer = Sep.New(',').Writer().ToFile("titanic.csv");
```
writer 必须指定有效分隔符，无法自动推断。为便于分隔符与 `CultureInfo` 流转，`SepReader` 和 `SepWriter` 均有 `Spec` 属性，类型为 [`SepSpec`](https://raw.githubusercontent.com/nietras/Sep/main/src/Sep/SepSpec.cs)，只定义这两项。示例：
```csharp
using var reader = Sep.Reader().FromFile("titanic.csv");
using var writer = reader.Spec.Writer().ToFile("titanic-survivors.csv");
```
此时 writer 会采用 reader 推断的分隔符。

### API 模式
整体读写流程类似如下：
```text
Sep/Spec => SepReaderOptions => SepReader => Row => Col(s) => Span/ToString/Parse
Sep/Spec => SepWriterOptions => SepWriter => Row => Col(s) => Set/Format
```
每一步都流畅衔接。例如 `Reader()` 是 `Sep` 或 `SepSpec` 的扩展方法，返回 `SepReaderOptions`。`Writer()` 同理返回 `SepWriterOptions`。

[`SepReaderOptions`](https://raw.githubusercontent.com/nietras/Sep/main/src/Sep/SepReaderOptions.cs) 与 [`SepWriterOptions`](https://raw.githubusercontent.com/nietras/Sep/main/src/Sep/SepWriterOptions.cs) 可选配置。后续各节有详细 API 说明。

完整示例见上方 [示例](#example) 或 [ReadMeTest.cs](https://raw.githubusercontent.com/nietras/Sep/main/src/Sep.XyzTest/ReadMeTest.cs)。

⚠ Sep 的 `Row`/`Col`/`Cols` 是 [`ref struct`](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/ref-struct)（请点击链接了解其限制）。这些类型仅作为底层 reader/writer 的门面/间接层，不能用 LINQ，也不能 `reader.ToArray()`。从 .NET9+ 起 reader 实现了 `IEnumerable<>`，但 ref struct 依然不兼容 LINQ。需要 per row 状态时请自行解析或复制。`Col`/`Cols` 也指向可复用的内部状态，避免为每行分配，确保最佳性能，同时保证结构良好且易用的 API。更多说明见[相关章节](#why-sepreader-was-not-ienumerable-until-net-9-and-is-not-linq-compatible)。

⚠ 公共类型和方法见 [API 参考](#public-api-reference)。

### SepReader API
`SepReader` API 结构（伪 C#）如下：
```csharp
using var reader = Sep.Reader(o => o).FromFile/FromText/From...;
var header = reader.Header;
var _ = header.IndexOf/IndicesOf/NamesStartingWith...;
foreach (var row in reader)
{
    var _ = row[colName/colNames].Span/ToString/Parse<T>...;
    var _ = row[colIndex/colIndices].Span/ToString/Parse<T>...;
}
```
使用要点如下：

 1. 可选指定 `Sep` 或自动推断分隔符。
 1. 创建 reader，可选配置 `SepReaderOptions`。如无表头可用：
    ```csharp
    Sep.Reader(o => o with { HasHeader = false })
    ```
    所有选项见 [SepReaderOptions](#sepreaderoptions)。
 1. 通过 `From` 方法指定数据源，如文件、字符串（`string`）、`TextWriter` 等。
 1. 可选访问表头。例如取所有以 `GT_` 开头的列名：
    ```csharp
    var colNames = header.NamesStarting("GT_");
    var colIndices = header.IndicesOf(colNames);
    ```
 1. 逐行遍历，每次只处理一行。
 1. 通过列名或索引访问列，亦可批量操作。Sep 内部池化/复用多列操作所需的数组。
 1. 用 `Span` 直接访问列（`ReadOnlySpan<char>`），或用 `ToString` 转为字符串，或用 `Parse<T>`（T : ISpanParsable<T>）解析为类型。

#### SepReaderOptions
可用选项如下：
```csharp
/// <summary>
/// 指定分隔符，若为 `null` 则自动检测（首行）。
/// </summary>
public Sep? Sep { get; init; } = null;
/// <summary>
/// 内部 char 缓冲区初始长度。
/// </summary>
public int InitialBufferLength { get; init; } = SepDefaults.InitialBufferLength;
/// <summary>
/// 解析用区域文化（culture），可为 null 表示默认。
/// </summary>
public CultureInfo? CultureInfo { get; init; } = SepDefaults.CultureInfo;
/// <summary>
/// 首行是否为表头。
/// </summary>
public bool HasHeader { get; init; } = true;
/// <summary>
/// 比较表头列名和索引时用的 IEqualityComparer。
/// </summary>
public IEqualityComparer<string> ColNameComparer { get; init; } = SepDefaults.ColNameComparer;
/// <summary>
/// 列 span 转 string 的方法工厂。
/// </summary>
public SepCreateToString CreateToString { get; init; } = SepToString.Direct;
/// <summary>
/// 禁用 csFastFloat 解析 float/double。
/// </summary>
public bool DisableFastFloat { get; init; } = false;
/// <summary>
/// 禁用列数一致性检查。
/// </summary>
public bool DisableColCountCheck { get; init; } = false;
/// <summary>
/// 禁用引号解析。
/// </summary>
public bool DisableQuotesParsing { get; init; } = false;
/// <summary>
/// 列访问时反转义引号。
/// </summary>
/// <remarks>
/// 若为 true，若列以引号开头，则去除最外两引号，内部每对引号去一个。反转义原地操作，故 <see cref="SepReader.Row.Span" /> 在下次列访问前可能“污染”。效率优先，无需二次分配。表头也会反转义。需 <see cref="DisableQuotesParsing"/> 为 false。
/// </remarks>
public bool Unescape { get; init; } = false;
/// <summary>
/// 列访问时修剪空格（仅 ASCII 32）。
/// </summary>
/// <remarks>
/// 默认不修剪。见 <see cref="SepTrim"/>。修剪也可能原地发生。表头也会修剪。仅修剪空格 ` `（ASCII 32），非所有空白字符。
/// </remarks>
public SepTrim Trim { get; init; } = SepTrim.None;
/// <summary>
/// async 方法调用时传递的 ConfigureAwait。
/// </summary>
public bool AsyncContinueOnCapturedContext { get; init; } = false;
```

#### 反转义（Unescaping）
Sep 反转义引号经过仔细设计以保证正确且高效，但对无效输入时的处理与 CsvHelper/Sylvan 等有差异。Sep 设计原则为不抛异常，兼顾速度与简单。

表格对比见原文（略）。

#### 修剪（Trimming）
Sep 用 [`SepTrim`](https://raw.githubusercontent.com/nietras/Sep/main/src/Sep/SepTrim.cs) 枚举支持修剪，具体效果见原文表格（略）。Sep 支持先修剪再反转义。

#### SepReader 可调试性
SepReader 在调试器中的显示友好，详情见原文。

##### SepReader.Row 可调试性
调试器悬停 `row` 时会显示如：
```text
  2:[5..9] = "B;\"Apple\r\nBanana\r\nOrange\r\nPear\""
```
格式为：
```text
<ROWINDEX>:[<LINENUMBERRANGE>] = "<ROW>"
```
可定位行号。展开 `row` 可见各列内容。

##### SepReader.Col 可调试性
悬停 `col` 显示内容字符串。

#### 为什么 SepReader 直到 .NET 9 才实现 IEnumerable，且不兼容 LINQ
详见原文。Sep 的 Row/Col/Cols 均为 ref struct，底层为 reader 的门面，不能 ToArray/LINQ。如需 LINQ，建议先用自定义方法/迭代器解析为其它类型。Sep 提供了 `Enumerate`/`ParallelEnumerate` 等辅助方法。

#### ParallelEnumerate 与 Enumerate
Sep 的 `ParallelEnumerate` 基于 LINQ 的 `AsParallel().AsOrdered()`，用于高效并行解析（解析阶段，不建议用于每行耗时很久的操作）。如每行操作耗时超过 1 毫秒，建议将耗时操作放到 `ParallelEnumerate`/`Enumerate` 之后。

### SepWriter API
`SepWriter` API 结构（伪 C#）如下：
```csharp
using var writer = Sep.Writer(o => o).ToFile/ToText/To...;
foreach (var data in EnumerateData())
{
    using var row = writer.NewRow();
    var _ = row[colName/colNames].Set/Format<T>...;
    var _ = row[colIndex/colIndices].Set/Format<T>...;
}
```
使用要点如下：

 1. 可选指定 `Sep` 或默认分隔符。
 1. 创建 writer，可选配置 `SepWriterOptions`。详见 [SepWriterOptions](#sepwriteroptions)。
 1. 通过 `To` 方法指定目标（如文件、字符串、`TextWriter`）。
 1. ⚠ 当前不支持预先定义表头，表头根据首行写入时的列顺序自动生成。
 1. 用 `NewRow` 新建行。⚠ 每次新行前请先 Dispose 上一行！Sep 提供重载，可直接用 `SepReader.Row` 复制一行。
    ```csharp
    using var reader = Sep.Reader().FromText(text);
    using var writer = reader.Spec.Writer().ToText();
    foreach (var readRow in reader)
    {   using var writeRow = writer.NewRow(readRow); }
    ```
 1. 按名/索引创建列，或批量列操作。内部自动池化/复用多列数组。
 1. 用 `Set` 设值（支持 ReadOnlySpan<char>、string、插值字符串），或用 `Format<T>`。
 1. 行在 Dispose 时写入。
    > 这样做便于将来支持列删除、移动、重命名等灵活操作（暂未支持）。

#### SepWriterOptions
可用选项如下：
```csharp
/// <summary>
/// 指定分隔符。
/// </summary>
public Sep Sep { get; init; }
/// <summary>
/// 解析用区域文化（culture），可为 null 表示默认。
/// </summary>
public CultureInfo? CultureInfo { get; init; }
/// <summary>
/// 是否先写表头（需全部列有名，否则可仅索引写列）。
/// </summary>
public bool WriteHeader { get; init; } = true;
/// <summary>
/// 禁用列数一致性检查。
/// </summary>
/// <remarks>
/// 若为 true，则 <see cref="ColNotSetOption"/> 控制未设值列如何处理（跳过或写空）。若跳过，则数据行的列顺序可能与表头不一致。
/// 只要按顺序写入，列数可任意。
/// </remarks>
public bool DisableColCountCheck { get; init; } = false;
/// <summary>
/// 未设值列的处理方式。
/// </summary>
public SepColNotSetOption ColNotSetOption { get; init; } = SepColNotSetOption.Throw;
/// <summary>
/// 写入时是否转义列名和值。
/// </summary>
/// <remarks>
/// 若为 true，列含分隔符、回车（`\r`）、换行（`\n`）、引号（`"`）时，加双引号包裹，内部引号变双引号。表头也适用。
/// </remarks>
public bool Escape { get; init; } = false;
/// <summary>
/// async 方法调用时传递的 ConfigureAwait。
/// </summary>
public bool AsyncContinueOnCapturedContext { get; init; } = false;
```

#### 转义（Escaping）
Sep 默认不转义，开启后与主流库一致（CsvHelper 还会转义空格，但不是必须的）。

原文表格略。

## 异步支持
Sep 支持高效的基于 `ValueTask` 的异步读写。

由于 `SepReader.Row` 和 `SepWriter.Row` 都是 `ref struct`（只可同时用一个，指向内部状态），`async/await` 仅支持 C# 13.0+（支持 ref/unsafe in async/iterator，详见 [C# 13 新特性](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13)）。详细约束见官方文档。

.NET 9.0+/C# 13.0+ 下 `SepReader` 实现 `IAsyncEnumerable<SepReader.Row>` 和 `IEnumerable<SepReader.Row>`。

异步支持直接集成于 `SepReader` 和 `SepWriter`，类似 `TextReader`/`TextWriter`。开发者需自行调用异步方法并用 `await`。示例：

```csharp
var text = """
           A;B;C;D;E;F
           Sep;🚀;1;1.2;0.1;0.5
           CSV;✅;2;2.2;0.2;1.5
           
           """; // 末尾空行为统一行结束

using var reader = await Sep.Reader().FromTextAsync(text);
await using var writer = reader.Spec.Writer().ToText();
await foreach (var readRow in reader)
{
    await using var writeRow = writer.NewRow(readRow);
}
Assert.AreEqual(text, writer.ToString());
```

注意：`SepReader` 的 `FromTextAsync` 需 await（因要确定分隔符和表头），后续行可用 `await foreach` 异步遍历。漏写 await 则为同步遍历。

`SepWriter` 的 `To*` 方法无 Async 变体，创建同步，行写入和 Dispose/DisposeAsync 时才会写内容。读端无需异步释放，但 `SepWriter` 建议用 `await using`。

支持取消的 API 也提供 `CancellationToken`。详细见 [API 参考](#public-api-reference)。

此外，[SepReaderOptions](#sepreaderoptions) 与 [SepWriterOptions](#sepwriteroptions) 均有 `AsyncContinueOnCapturedContext`，内部转发到 `ConfigureAwait`。

## 限制与约束
Sep 以极简高效为目标，具有限定：

* 不原生支持 `#` 注释。可手动跳过行：
   ```csharp
   foreach (var row in reader)
   {
        // 如果行以 # 开头则跳过
        if (!row.Span.StartsWith("#"))
        {
             // ...
        }
   }
   ```
   该方式无法跳过表头前以 `#` 开头的行，完整例子见 [示例目录](#example-catalogue)。

## 性能对比
为评估 Sep 性能，选取如下对比对象：

* [CsvHelper](https://github.com/JoshClose/csvhelper) - 最流行的 CSV 库，NuGet 超高下载量。功能丰富，成熟稳定。
* [Sylvan](https://github.com/MarkPflug/Sylvan) - 以速度著称，曾被评为[.NET 最快 CSV 库](https://www.joelverhagen.com/blog/2020/12/fastest-net-csv-parsers)（Sep 改变了这一点 😉）。
* `ReadLine`/`WriteLine` - 基础实现，逐行读取并按分隔符切分。写入时直接拼接。无引号等处理。

所有基准测试均在内存中（`StringReader`/`StreamReader+MemoryStream`，`StringWriter`/`StreamWriter+MemoryStream`），避免磁盘影响。

`StringReader`/`StringWriter` 下每个 `char` 视为 2 字节，`StreamReader`/`StreamWriter` 下为 UTF-8，通常 1 字节。默认只展示 `StringReader`/`StringWriter` 结果，其他场景与其一致，性能约减半。

所有测试中，Sep 作为 [BenchmarkDotNet](https://benchmarkdotnet.org/) 的基线（`Ratio` 为 1.00），其他库的 `Ratio` 表示 Sep 的几倍速度或内存分配。

> 声明：本对比在特定前提/假设下进行。Sep 为全新库，充分利用 .NET 最新特性；CsvHelper/Sylvan 因兼容旧环境或历史负担，可能无法轻松用上新特性。Sep、Sylvan、CsvHelper 功能侧重点不同，性能只是其中之一。评估时请结合实际需求。

### 运行时与平台
基准测试运行环境及平台配置详见原文。

### Reader 对比基准
- NCsvPerf 场景
- [**Floats**](#floats-reader-comparison-benchmarks)（如机器学习中的浮点特征）

详细场景及结果表格见原文。

#### NCsvPerf PackageAssets 基准
简述：以 [NCsvPerf](https://github.com/joelverhagen/NCsvPerf) 真实数据集，涉及 25 列，测试各库性能。Sylvan、CsvHelper、Sep 均采用字符串池化优化（Sep 支持按列池化更高效）。Sep 在所有指标下均为最快，并发（MT）下领先更多。

详细数据表略。

#### 含引号等特殊情况
在有引号、空格等特殊情况时，Sep 解析性能依然领先，详细见原文各表格。

#### 浮点型特征场景（Floats Reader Benchmarks）
模拟机器学习特征数据，批量高效解析浮点数组，Sep 内置 csFastFloat，解析浮点数比 Sylvan 快 2 倍以上，并发下可达 23 倍。对比 CsvHelper，单线程快 4 倍，并发快 35 倍。

详细数据表略。

### Writer 对比基准
Writer 部分基准待补充，Sep 以便捷与灵活为主，性能仍然高效但未必绝对最快。

## 示例目录
以下示例可见于 [ReadMeTest.cs](https://raw.githubusercontent.com/nietras/Sep/main/src/Sep.XyzTest/ReadMeTest.cs)。

- **复制行**
- **异步复制行**
- **跳过空行**
- **在 async/await 场景下用 Enumerate 扩展方法（C# 13.0 前）**
- **在 async/await 场景下用本地函数**
- **跳过以 # 开头的注释行/行**

每个示例代码见原文。

## RFC-4180
[RFC-4180](https://www.ietf.org/rfc/rfc4180.txt) 标准要求用 `\r\n` 行结束，Sep 支持常见的 `\r\n`、`\n`、`\r`。写入时用 `Environment.NewLine`。引号配对即视为转义。

许多库号称兼容 RFC，但 RFC 非常严格（仅允许逗号分隔符等），Sep 写入默认用 `;`，读取时自动检测分隔符。这是显著不兼容的设计。

ABNF 语法见原文。

总之，Sep 以实际机器学习等场景为主，采取更实用的做法。

## 常见问题（FAQ）
如有疑问请在 GitHub 提问。

* *Sep 是否支持类似 [CsvHelper 对象映射](https://joshclose.github.io/CsvHelper/examples/reading/get-class-records/)?*  
  不支持，Sep 以极简为目标，无对象映射。对象映射常依赖反射，Sep 避免此类实现。对象映射通常需手写每个属性的映射逻辑，这与自己写解析代码差别不大。如确需此功能，可考虑自定义 [source generator](https://devblogs.microsoft.com/dotnet/new-c-source-generator-samples/)。未来可能会内置，但近期暂无计划。

### SepReader 常见问题

### SepWriter 常见问题

## 相关链接

* [用 GitHub 和 GitHub Actions 发布 NuGet 包最佳实践](https://www.meziantou.net/publishing-a-nuget-package-following-best-practices-using-github.htm)

## API 参考
```csharp
// 省略，内容同原文，未翻译 API 代码注释
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---