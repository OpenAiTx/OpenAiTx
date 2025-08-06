# OfficeIMO - Microsoft Word .NET 库

OfficeIMO 可作为 NuGet 包从库中获取，是推荐的安装方式。

[![nuget 下载量](https://img.shields.io/nuget/dt/officeIMO.Word?label=nuget%20downloads)](https://www.nuget.org/packages/OfficeIMO.Word)
[![nuget 版本](https://img.shields.io/nuget/v/OfficeIMO.Word)](https://www.nuget.org/packages/OfficeIMO.Word)
[![许可证](https://img.shields.io/github/license/EvotecIT/OfficeIMO.svg)](#)
[![CI](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master)](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml)
[![代码覆盖率](https://codecov.io/gh/EvotecIT/OfficeIMO/branch/master/graph/badge.svg)](https://codecov.io/gh/EvotecIT/OfficeIMO)

如果您想联系我，可以通过 Twitter 或 LinkedIn。

[![twitter](https://img.shields.io/twitter/follow/PrzemyslawKlys.svg?label=Twitter%20%40PrzemyslawKlys&style=social)](https://twitter.com/PrzemyslawKlys)
[![博客](https://img.shields.io/badge/Blog-evotec.xyz-2A6496.svg)](https://evotec.xyz/hub)
[![linked](https://img.shields.io/badge/LinkedIn-pklys-0077B5.svg?logo=LinkedIn)](https://www.linkedin.com/in/pklys)
[![discord](https://img.shields.io/discord/508328927853281280?style=flat-square&label=discord%20chat)](https://evo.yt/discord)

## 项目简介

这是一个小型项目（正在开发中），允许使用 .NET 创建 Microsoft Word 文档（.docx）。
底层使用了 [OpenXML SDK](https://github.com/OfficeDev/Open-XML-SDK)，但大大简化了使用。
创建它的原因是因为对我来说，使用 OpenXML 太复杂且费时。
我为 PowerShell 模块 [PSWriteOffice](https://github.com/EvotecIT/PSWriteOffice) 创建了它，
但认为它也可能对 .NET 社区的其他人有用。
该仓库还包括一个实验性的 **OfficeIMO.Excel** 组件，用于创建简单的电子表格。

如果您想看看它能做些什么，可以查看这篇[博客文章](https://evotec.xyz/officeimo-free-cross-platform-microsoft-word-net-library/)。

我以前使用 DocX 库（我曾是其共同作者/维护者，后来被 Xceed 接手）来创建 Microsoft Word 文档，
但它只支持 .NET Framework，而且其最新的社区许可证使该项目无法使用。

*因为我不是真正的开发者，也不太知道自己在做什么，如果您知道如何帮忙——请帮忙。*

- 如果您发现不良实践，请提交 issue/PR。
- 如果您知道如何用 OpenXML 做些什么能帮助此项目，请提交 issue/PR。
- 如果您看到有改进空间的地方，请提交 issue/PR。
- 如果您看到我做了蠢事，请提交 issue/PR。
- 如果您看到某些功能不按我想的方式工作，请提交 issue/PR。

如果您发现任何问题或有改进建议，请提交 issue 或 pull request。
最重要的是——它必须兼容 .NET Framework 4.7.2、.NET Standard 2.0 等。

**该项目正在开发中，因此很多东西可能会变化，尤其是如果有人参与帮助的话。**


| 平台     | 状态   | 代码覆盖率   | .NET                                                                                                          |
| -------- | ------ | ----------- | ------------------------------------------------------------------------------------------------------------- |
| Windows  | ![Windows](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `netstandard2.0`, `net472`, `net8.0`, `net9.0`; OfficeIMO.Excel: `netstandard2.0`, `net472`, `net48`, `net8.0`, `net9.0` |
| Linux    | ![Linux](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `net8.0`; OfficeIMO.Excel: `net8.0`, `net9.0`                                                    |
| MacOs    | ![macOS](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `net8.0`; OfficeIMO.Excel: `net8.0`, `net9.0`                                                    |
## 支持本项目

如果您觉得本项目有帮助，请考虑支持其开发。
您的赞助将帮助维护者投入更多时间进行维护和新功能开发。

创建和维护该项目需要大量时间和精力。
通过成为赞助者，您可以帮助确保项目免费且对所有需要的人开放。

成为赞助者，您可以选择以下方式：

- [通过 GitHub Sponsors 成为赞助者 :heart:](https://github.com/sponsors/PrzemyslawKlys)
- [通过 PayPal 成为赞助者 :heart:](https://paypal.me/PrzemyslawKlys)

您的赞助完全是自愿的，使用本项目无需赞助。
我们希望本项目保持开源，免费供任何人使用，
无论他们是否选择赞助。

如果您所在的公司使用我们的 .NET 库或 PowerShell 模块，
请考虑向您的经理或市场团队询问贵公司是否有兴趣支持本项目。
贵公司的支持可以帮助我们继续维护和改进此项目，造福所有人。

感谢您考虑支持本项目！

## 请与社区分享

请考虑发布关于 OfficeIMO 及其价值的帖子。这真的很有帮助！

[![分享到 reddit](https://img.shields.io/badge/share%20on-reddit-red?logo=reddit)](https://reddit.com/submit?url=https://github.com/EvotecIT/OfficeIMO&title=OfficeIMO)
[![分享到 hacker news](https://img.shields.io/badge/share%20on-hacker%20news-orange?logo=ycombinator)](https://news.ycombinator.com/submitlink?u=https://github.com/EvotecIT/OfficeIMO)
[![分享到 twitter](https://img.shields.io/badge/share%20on-twitter-03A9F4?logo=twitter)](https://twitter.com/share?url=https://github.com/EvotecIT/OfficeIMO&t=OfficeIMO)
[![分享到 facebook](https://img.shields.io/badge/share%20on-facebook-1976D2?logo=facebook)](https://www.facebook.com/sharer/sharer.php?u=https://github.com/EvotecIT/OfficeIMO)
[![分享到 linkedin](https://img.shields.io/badge/share%20on-linkedin-3949AB?logo=linkedin)](https://www.linkedin.com/shareArticle?url=https://github.com/EvotecIT/OfficeIMO&title=OfficeIMO)

## 功能

以下是当前支持的功能列表（可能还有很多我忘了的）及计划中的功能。这不是封闭列表，更像是待办事项，我相信还有更多：

- ☑️ Word 基础功能
    - ☑️ 创建
    - ☑️ 加载
    - ☑️ 保存（保存时自动打开选项）
    - ☑️ 另存为（另存为时自动打开选项）
- ☑️ Word 属性
    - ☑️ 读取基础和自定义属性
    - ☑️ 设置基础和自定义属性
- ☑️ 分节
    - ☑️ 添加段落
    - ☑️ 添加页眉和页脚（奇数页/偶数页/首页）
    - ☑️ 移除页眉和页脚（奇数页/偶数页/首页）
    - ☑️ 移除段落
    - ☑️ 删除节
- ☑️ 文档中的页眉和页脚（不包括节）
    - ☑️ 添加默认、奇数、偶数、首页
    - ☑️ 删除默认、奇数、偶数、首页
- ☑️ 段落/文本并使其加粗、加下划线、着色等
    - ☑️ 通过 `WordParagraphStyle` 自定义段落样式
- ☑️ 段落并更改对齐方式
- ☑️ 段落缩进（前、后、首行、悬挂）
- ☑️ 行距，支持 twips 和点数
- ☑️ 表格
    - ☑️ [添加和修改表格样式（105 种内置样式之一）](https://evotec.xyz/docs/adding-tables-with-built-in-styles-managing-borders/)
    - ☑️ 添加行和列
    - ☑️ 添加单元格
    - ☑️ 添加单元格属性
    - ☑️ [添加和修改表格单元格边框](https://evotec.xyz/docs/adding-tables-with-built-in-styles-managing-borders/)
    - ☑️ 删除行
    - ☑️ 删除单元格
    - ☑️ 其他
        - ☑️ 合并单元格（垂直、水平）
        - ☑️ 拆分单元格（垂直）
        - ☑️ 拆分单元格（水平）
        - ☑️ 检测合并单元格（垂直、水平）
        - ☑️ 嵌套表格
        - ☑️ 每页重复表头行
        - ☑️ 控制行分页
        - ☑️ 设置行高和表格宽度
- ☑️ 图片（支持 BMP、GIF、JPEG、PNG、TIFF、EMF，带多种环绕选项）
    - ☑️ 从文件添加图片到 Word
    - ☑️ 从 Base64 字符串添加图片
    - ☑️ 从 Word 保存图片到文件
    - ☑️ 裁剪图片并设置透明度
    - ☑️ 图片定位和位置获取
    - ◼️ 其他位置类型
- ☑️ 超链接
    - ☑️ 添加超链接
    - ☑️ 读取超链接
    - ☑️ 删除超链接
    - ☑️ 更改超链接
- ☑️ 分页符
    - ☑️ 添加分页符
    - ☑️ 读取分页符
    - ☑️ 删除分页符
    - ☑️ 更改分页符
- ☑️ 页码
    - ☑️ 在页眉或页脚插入页码
    - ☑️ 通过 `WordPageNumberStyle` 选择样式
- ☑️ 书签
    - ☑️ 添加书签
    - ☑️ 读取书签
    - ☑️ 删除书签
    - ☑️ 更改书签
- ☑️ 查找和替换文本
  - ☑️ 评论
      - ☑️ 添加评论
      - ☑️ 读取评论
      - ☑️ 删除评论（单个或全部）
      - ☑️ 跟踪评论
      - ☑️ 线程回复
- ☑️ 字段
    - ☑️ 添加字段
    - ☑️ 读取字段
    - ☑️ 删除字段
    - ☑️ 更改字段
- ☑️ 脚注
    - ☑️ 添加新脚注
    - ☑️ 读取脚注
    - ☑️ 删除脚注
- ☑️ 尾注
    - ☑️ 添加新尾注
    - ☑️ 读取尾注
    - ☑️ 删除尾注
- ☑️ 文档变量
    - ☑️ 设置和读取文档中存储的变量
    - ☑️ 按名称或索引删除变量
- ☑️ 宏
    - ☑️ 添加或提取 VBA 项目
    - ☑️ 删除宏模块
- ☑️ 邮件合并
    - ☑️ 替换 `MERGEFIELD` 值
    - ☑️ 可选保留字段代码
- ☑️ 内容控件
    - ☑️ 添加控件
    - ☑️ 读取控件
    - ☑️ 更新控件文本
    - ☑️ 删除控件
    - ☑️ 复选框表单控件
    - ☑️ 日期选择器表单控件
    - ☑️ 下拉列表表单控件
    - ☑️ 组合框表单控件
    - ☑️ 图片表单控件
    - ☑️ 重复节表单控件
- ☑️ 形状
    - ☑️ 添加矩形
    - ☑️ 添加椭圆
    - ☑️ 添加直线
    - ☑️ 添加多边形
    - ☑️ 设置填充和描边颜色
    - ☑️ 删除形状
- ☑️ 图表
    - ☑️ 添加图表
        - ☑️ 饼图和3D饼图
        - ☑️ 条形图和3D条形图
        - ☑️ 折线图和3D折线图
        - ☑️ 组合图（条形 + 折线）
        - ☑️ 面积图和3D面积图
        - ☑️ 散点图
        - ☑️ 雷达图
    - ☑️ 添加类别和图例
    - ☑️ 配置坐标轴
    - ☑️ 添加多个系列
    - ⚠️ 混合条形图和折线图系列时，在添加任何数据之前调用 `AddChartAxisX`，使两种图表类型共享相同的类别轴。
- ☑️ 公式
    - ☑️ 从OMML插入Office数学公式
    - ☑️ 需要时删除公式
- ☑️ 列表
    - ☑️ 添加列表
    - ☑️ 删除列表
    - ☑️ 克隆列表并保留编号设置
    - ☑️ 添加图片项目符号列表
    - ☑️ 创建自定义项目符号和编号列表
    - ☑️ 从现有段落检测列表样式
- ☑️ 目录
    - ☑️ 添加目录
    - ☑️ 打开时更新目录字段
- ☑️ 边框
    - ☑️ 内置样式或自定义设置
    - ☑️ 更改大小、颜色、样式和间距
- ☑️ 背景
    - ☑️ 设置背景颜色
- ☑️ 水印
    - ☑️ 添加文本或图片水印
    - ☑️ 通过 `WordWatermarkStyle` 选择文本或图片样式
    - ☑️ 设置旋转角度、宽度和高度
    - ☑️ 移除水印

- ☑️ 封面页
    - ☑️ 添加内置封面页

- ☑️ 字体
    - ☑️ 通过 `WordDocument.EmbedFont` 嵌入字体

- ☑️ 嵌入内容
    - ☑️ 添加嵌入文档（RTF、HTML、TXT）
    - ☑️ 添加HTML片段
    - ☑️ 在段落后插入HTML片段
    - ☑️ 用HTML片段替换文本
    - ☑️ 移除嵌入文档
    - ☑️ 使用自定义图标和大小嵌入对象
 - ☑️ [数字签名和文档安全](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.DigitalSignature.cs)
 - ☑️ [文档保护选项](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Settings.cs)（最终文档、推荐只读、强制只读）
 - ☑️ [接受/拒绝修订](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Revisions.cs)
 - ☑️ [异步保存/加载API](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Async.cs)
 - ☑️ [合并多个文档](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.MergeDocuments.cs)
 - ☑️ [带定位选项的文本框](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.TextBox.cs)
 - ☑️ [页面方向、页面大小和边距预设](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.PageSettings.cs)（[边距](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Sections.cs)）
 - ☑️ [制表符和自定义制表位](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.TabStops.cs)
 - ☑️ [文档验证工具](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Validation.cs)
 - ☑️ [CleanupDocument方法](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Cleanup.cs) 合并相同的运行
 - ☑️ [段落XML序列化](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Examples/Word/XmlSerialization/XmlSerialization.Basic.cs)
 - ☑️ [测量单位转换辅助](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.HelpersConversions.cs)

- ☑️ 实验性Excel组件
    - ☑️ 创建和加载工作簿
    - ☑️ 添加工作表
    - ☑️ 异步保存和加载API


## 功能（一行介绍）：

该功能列表适用于您想快速修复某些内容而非使用全部功能的情况。
这些功能作为 `WordHelpers` 类的一部分提供。

- ☑️ 从文件中移除页眉和页脚
- ☑️ 将DOTX模板转换为DOCX

## 示例

### 基本文档，包含少量文档属性和段落

此简短示例展示如何创建一个仅包含一段文本和少量文档属性的Word文档。


```csharp
string filePath = System.IO.Path.Combine(
    "Support",
    "GitHub",
    "PSWriteOffice",
    "Examples",
    "Documents",
    "BasicDocument.docx");

using (WordDocument document = WordDocument.Create(filePath)) {
    document.BuiltinDocumentProperties.Title = "This is my title";
    document.BuiltinDocumentProperties.Creator = "Przemysław Kłys";
    document.BuiltinDocumentProperties.Keywords = "word, docx, test";

    var paragraph = document.AddParagraph("Basic paragraph");
    paragraph.ParagraphAlignment = JustificationValues.Center;
    paragraph.Color = SixLabors.ImageSharp.Color.Red;

document.Save(true);
}
```

### 直接在流中创建文档

此重载允许完全在内存中或任何提供的流上生成文档。

```csharp
using var stream = new MemoryStream();
using (var document = WordDocument.Create(stream)) {
    document.AddParagraph("Stream based document");
    document.Save(stream);
}
stream.Position = 0;
using (var loaded = WordDocument.Load(stream)) {
    Console.WriteLine(loaded.Paragraphs[0].Text);
}
```

### 另存为新文档

`SaveAs` 会将当前文档克隆到一个新路径，并返回一个新的 `WordDocument` 实例，且不会更改原始的 `FilePath`。

```csharp
using (WordDocument document = WordDocument.Create()) {
    document.AddParagraph("Some text");
    using var copy = document.SaveAs(filePath);
    // document.FilePath is still null
    // copy.FilePath equals filePath
}
```

### 保存到字节数组和流

`SaveAsByteArray` 和 `SaveAsMemoryStream` 允许您将所有内容保存在内存中。`SaveAs(Stream)` 将文档克隆到提供的流中，并返回一个从该流加载的新实例。

```csharp
using (WordDocument document = WordDocument.Create()) {
    document.AddParagraph("In memory");
    byte[] data = document.SaveAsByteArray();
    using MemoryStream stream = document.SaveAsMemoryStream();
    using var clone = document.SaveAs(stream);
}
```

### 嵌入字体

`EmbedFont` 将 TrueType 或 OpenType 字体文件添加到文档中，以便在任何机器上使用。

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("This document uses an embedded font.");
    document.Save();
}
```

`EmbedFont` 有一个重载，可以自动注册段落样式：

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath, "DejaVuStyle", "DejaVu Style");
    document.AddParagraph("Styled paragraph").SetStyleId("DejaVuStyle");
    document.Save();
}
```

### 混合内置字体和嵌入字体

嵌入字体后，可以通过名称引用它，同时也可以引用标准字体。

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("Builtin Arial").SetFontFamily("Arial");
    document.AddParagraph("Embedded DejaVu Sans").SetFontFamily("DejaVu Sans");
    var mixed = document.AddParagraph("Mix: ");
    mixed.AddText("Arial, ").SetFontFamily("Arial");
    mixed.AddText("DejaVu").SetFontFamily("DejaVu Sans");
    document.Save();
}
```

您也可以创建使用嵌入字体的段落样式。

```csharp
var style = new Style { Type = StyleValues.Paragraph, StyleId = "EmbeddedStyle" };
style.Append(new StyleName { Val = "EmbeddedStyle" });
style.Append(new StyleRunProperties(new RunFonts { Ascii = "DejaVu Sans" }));
WordParagraphStyle.RegisterCustomStyle("EmbeddedStyle", style);

using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("Paragraph with embedded style").SetStyleId("EmbeddedStyle");
    document.AddParagraph("Built-in style example").Style = WordParagraphStyles.Normal;
    document.Save();
}
```

### 带页眉/页脚的基本文档（首页、奇数页、偶数页）

这个简短的示例展示了如何向 Word 文档添加页眉和页脚。

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.Sections[0].PageOrientation = PageOrientationValues.Landscape;
    document.AddParagraph("Test Section0");
    document.AddHeadersAndFooters();
    document.DifferentFirstPage = true;
    document.DifferentOddAndEvenPages = true;

    document.Sections[0].Header.First.AddParagraph().SetText("Test Section 0 - First Header");
    document.Sections[0].Header.Default.AddParagraph().SetText("Test Section 0 - Header");
    document.Sections[0].Header.Even.AddParagraph().SetText("Test Section 0 - Even");

    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();

    var section1 = document.AddSection();
    section1.PageOrientation = PageOrientationValues.Portrait;
    section1.AddParagraph("Test Section1");
    section1.AddHeadersAndFooters();
    section1.Header.Default.AddParagraph().SetText("Test Section 1 - Header");
    section1.DifferentFirstPage = true;
    section1.Header.First.AddParagraph().SetText("Test Section 1 - First Header");

    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();

    var section2 = document.AddSection();
    section2.AddParagraph("Test Section2");
    section2.PageOrientation = PageOrientationValues.Landscape;
    section2.AddHeadersAndFooters();
    section2.Header.Default.AddParagraph().SetText("Test Section 2 - Header");

    document.AddParagraph("Test Section2 - Paragraph 1");

    var section3 = document.AddSection();
    section3.AddParagraph("Test Section3");
    section3.AddHeadersAndFooters();
    section3.Header.Default.AddParagraph().SetText("Test Section 3 - Header");

    Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Paragraphs[0].Text);
    Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 1: " + document.Sections[2].Paragraphs[1].Text);
    Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Paragraphs[0].Text);

    Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Header.Default.Paragraphs[0].Text);
    document.Save(true);
}
```

### 添加内容控件

本示例演示如何添加和更新一个简单的内容控件，然后通过标签检索它。

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    var sdt = document.AddStructuredDocumentTag("Hello", "MyAlias", "MyTag");
    sdt.Text = "Changed";
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    var tag = document.GetStructuredDocumentTagByTag("MyTag");
Console.WriteLine(tag.Text);
}
```

### 多个内容控件

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.AddStructuredDocumentTag("First", "Alias1", "Tag1");
    document.AddStructuredDocumentTag("Second", "Alias2", "Tag2");
    document.AddStructuredDocumentTag("Third", "Alias3", "Tag3");
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    foreach (var control in document.StructuredDocumentTags) {
        Console.WriteLine(control.Tag + ": " + control.Text);
    }
}
```

### 高级内容控制用法

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.AddStructuredDocumentTag("First", "Alias1", "Tag1");
    document.AddStructuredDocumentTag("Second", "Alias2", "Tag2");
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    var alias = document.GetStructuredDocumentTagByAlias("Alias2");
    alias.Text = "Updated";
    var tag = document.GetStructuredDocumentTagByTag("Tag1");
    Console.WriteLine(tag.Text);
}
```

### OfficeIMO 的高级用法

这个简短的示例展示了 `OfficeIMO.Word` 的多种功能

```csharp
string filePath = System.IO.Path.Combine(folderPath, "AdvancedDocument.docx");
using (WordDocument document = WordDocument.Create(filePath)) {
    // lets add some properties to the document
    document.BuiltinDocumentProperties.Title = "Cover Page Templates";
    document.BuiltinDocumentProperties.Subject = "How to use Cover Pages with TOC";
    document.ApplicationProperties.Company = "Evotec Services";

    // we force document to update fields on open, this will be used by TOC
    document.Settings.UpdateFieldsOnOpen = true;

    // lets add one of multiple added Cover Pages
    document.AddCoverPage(CoverPageTemplate.IonDark);

    // lets add Table of Content (1 of 2)
    document.AddTableOfContent(TableOfContentStyle.Template1);

    // lets add page break
    document.AddPageBreak();

    // lets create a list that will be binded to TOC
    var wordListToc = document.AddTableOfContentList(WordListStyle.Headings111);

    wordListToc.AddItem("How to add a table to document?");

    document.AddParagraph("In the first paragraph I would like to show you how to add a table to the document using one of the 105 built-in styles:");

    // adding a table and modifying content
    var table = document.AddTable(5, 4, WordTableStyle.GridTable5DarkAccent5);
    table.Rows[3].Cells[2].Paragraphs[0].Text = "Adding text to cell";
    table.Rows[3].Cells[2].Paragraphs[0].Color = Color.Blue; ;
    table.Rows[3].Cells[3].Paragraphs[0].Text = "Different cell";

    document.AddParagraph("As you can see adding a table with some style, and adding content to it ").SetBold().SetUnderline(UnderlineValues.Dotted).AddText("is not really complicated").SetColor(Color.OrangeRed);

    wordListToc.AddItem("How to add a list to document?");

    var paragraph = document.AddParagraph("Adding lists is similar to ading a table. Just define a list and add list items to it. ").SetText("Remember that you can add anything between list items! ");
    paragraph.SetColor(Color.Blue).SetText("For example TOC List is just another list, but defining a specific style.");

    var list = document.AddList(WordListStyle.Bulleted);
    list.AddItem("First element of list", 0);
    list.AddItem("Second element of list", 1);

    var paragraphWithHyperlink = document.AddHyperLink("Go to Evotec Blogs", new Uri("https://evotec.xyz"), true, "URL with tooltip");
    // you can also change the hyperlink text, uri later on using properties
    paragraphWithHyperlink.Hyperlink.Uri = new Uri("https://evotec.xyz/hub");
    paragraphWithHyperlink.ParagraphAlignment = JustificationValues.Center;

    list.AddItem("3rd element of list, but added after hyperlink", 0);
    list.AddItem("4th element with hyperlink ").AddHyperLink("included.", new Uri("https://evotec.xyz/hub"), addStyle: true);

    document.AddParagraph();

    // create a custom bullet list
    var custom = document.AddCustomBulletList(WordListLevelKind.BulletSquareSymbol, "Courier New", SixLabors.ImageSharp.Color.Red, fontSize: 16);
    custom.AddItem("Custom bullet item");

    // create a list using an image as the bullet
    var pictureList = document.AddPictureBulletList(Path.Combine(folderPath, "Images", "Kulek.jpg"));
    pictureList.AddItem("Image bullet 1");
    pictureList.AddItem("Image bullet 2");

    // create a multi-level custom list
    var builder = document.AddCustomList()
        .AddListLevel(1, WordListLevelKind.BulletSquareSymbol, "Courier New", SixLabors.ImageSharp.Color.Red, fontSize: 14)
        .AddListLevel(5, WordListLevelKind.BulletBlackCircle, "Arial", colorHex: "#00ff00", fontSize: 10);
    builder.AddItem("First");
    builder.AddItem("Fifth", 4);

    // Note: use AddCustomList() rather than AddList(WordListStyle.Custom)
    // when you want to build lists with your own levels.
    // See [Custom Lists](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/Docs/custom-lists.md) for details on configuring levels.

    var listNumbered = document.AddList(WordListStyle.Heading1ai);
    listNumbered.AddItem("Different list number 1");
    listNumbered.AddItem("Different list number 2", 1);
    listNumbered.AddItem("Different list number 3", 1);
    listNumbered.AddItem("Different list number 4", 1);

    var section = document.AddSection();
    section.PageOrientation = PageOrientationValues.Landscape;
    section.PageSettings.PageSize = WordPageSize.A4;

    wordListToc.AddItem("Adding headers / footers");

    // lets add headers and footers
    document.AddHeadersAndFooters();

    // adding text to default header
    document.Header.Default.AddParagraph("Text added to header - Default");

    var section1 = document.AddSection();
    section1.PageOrientation = PageOrientationValues.Portrait;
    section1.PageSettings.PageSize = WordPageSize.A5;

    wordListToc.AddItem("Adding custom properties to document");

    document.CustomDocumentProperties.Add("TestProperty", new WordCustomProperty { Value = DateTime.Today });
    document.CustomDocumentProperties.Add("MyName", new WordCustomProperty("Some text"));
    document.CustomDocumentProperties.Add("IsTodayGreatDay", new WordCustomProperty(true));

    // document variables available via DocVariable fields
    document.SetDocumentVariable("Project", "OfficeIMO");
    document.SetDocumentVariable("Year", DateTime.Now.Year.ToString());

    if (document.HasDocumentVariables) {
        foreach (var pair in document.DocumentVariables) {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    document.Save(openWord);
}
```

## 测试

除了 `OfficeIMO.Word` 使用单元测试外，还使用了[特征测试](https://en.wikipedia.org/wiki/Characterization_test)。
添加特征测试是为了防止忽视破坏行为的更改。这些测试基于[Verify](https://github.com/VerifyTests/Verify)（[“.NET 中的快照测试与 Verify”](https://youtu.be/wA7oJDyvn4c)）。
如果需要添加或更新已验证的快照，可以使用 powershell 脚本：
```bash
$ pwsh -c ./Build/ApproveVerifyTests.ps1
```
要在 Verify 测试失败时显示图形差异而不是控制台输出，请在运行测试之前设置环境变量 `DiffEngine_Disabled=false`。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---