<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **（前称为 iTextSharp）** 是一个高性能、经过实战考验的库，允许你创建、修改、检查和维护 PDF 文档，使你能够轻松为软件项目添加 PDF 功能。它也可用于 [Java](https://github.com/itext/itext7)。

### iText Core/Community 的主要特性：

* 核心库:
    * 基于布局引擎的 PDF 创建
    * PDF 操作，例如将多个 PDF 合并为一个、添加新内容等
    * PDF 数字签名
    * PDF 表单的创建与操作
    * 处理 PDF/A 文档
    * 处理 PDF/UA 文档
    * 符合 FIPS 标准的加密
    * 条形码生成
    * SVG 支持
* [插件：][all products]
    * 将 XML/HTML & CSS 转换为 PDF [仓库][pdfhtml]，[信息][pdfhtmlproduct]
    * PDF 文档中的敏感信息遮盖 [仓库][pdfsweep]，[信息][pdfsweepproduct]
    * 支持国际字符集（如阿拉伯语、中文、希伯来语、泰语等）[信息][calligraph]
    * 优化 PDF 文档以减小文件大小并提升性能 [信息][optimizer]
    * XFA 文档扁平化 [信息][xfa]
    * PDF 调试 [仓库][rups]，[信息][rupsproduct]

想探索更多可能性？请访问我们的 [Demo Lab](https://itextpdf.com/demos)！其中包含一系列可在线使用的演示应用！

### 快速开始

最简单的入门方式是使用 NuGet，只需在你的项目文件夹中执行以下安装命令：

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

如需更高级的用法，请参考
[安装指南](https://kb.itextpdf.com/home/it7kb/installation-guidelines)。
你也可以[从源码构建 iText Community][building]。

### Hello PDF!

以下示例展示了创建一个简单 PDF 文档有多么容易：

```csharp
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace HelloPdf {
    class Program {
        static void Main(string[] args) {
            using var document = new Document(new PdfDocument(new PdfWriter("helloworld-pdf.pdf")));
            document.Add(new Paragraph("Hello World!"));
        }
    }
}
```

### 示例

更多高级示例请参考我们的 [知识库](https://kb.itextpdf.com/home/it7kb/examples) 或主
[示例仓库](https://github.com/itext/i7ns-samples)。你可以在此找到 C# 版本的
Java [签名示例](https://github.com/itext/i7js-signing-examples) [这里](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications)，而且 Java 代码与 C# 代码非常相似，因为它们具有相同的 API。

部分输出的 PDF 文件在 GitHub 预览器中显示可能不正确，请务必下载后查看正确效果。

| 描述                                    | 链接                                                                                                                                                                                                                                                                                                   |
|-----------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **基础布局**                             |                                                                                                                                                                                                                                                                                                        |
| 更改文本属性                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| 创建简单表格                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| 向 PDF 文档添加图片                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| 创建列表                                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| 添加水印                                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| 添加文档内导航链接                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| 创建弹出注释                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| 更改字体                                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| 添加表单域                              | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                      |                                                                                                                                                                                                                                                                                                        |
| **通用文档设置**                        |                                                                                                                                                                                                                                                                                                        |
| 更改页面大小和边距                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| 输出 PDF 到字节数组而非磁盘             | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| 更改页面旋转                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| 添加页眉和页脚                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| 合并文档                                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| 扁平化注释                              | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                    |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                       |                                                                                                                                                                                                                                                                                                        |
| 创建 PDF/UA 文档                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| 创建 PDF/A-3 文档                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| 创建 PDF/A-4 文档                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| 创建 WTPDF 文档                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| 创建 ZUGFeRD/Factur-X 文档              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                    |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                |                                                                                                                                                                                                                                                                                                        |
| 启用 FIPS                               | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| FIPS SHA3 示例                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                    |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                 |                                                                                                                                                                                                                                                                                                        |
| SVG 转 PDF                              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| 使用布局引擎将 SVG 转 PDF               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| 将字符串形式的 SVG 转 PDF               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| SVG 转 PdfPage                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| SVG 作为 XObject                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| 使用 pdfCalligraph 将 SVG 转 PDF        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                    |                                                                                                                                                                                                                                                                                                        |
| **HTML 和 CSS 转 PDF**                  | [仓库链接](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                                      |
| 将简单 HTML 文档转为 PDF                | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                    |                                                                                                                                                                                                                                                                                                        |
| **安全遮盖内容**                        | [仓库链接](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                                     |
| 遮盖内容                                | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| 基于正则表达式遮盖                      | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                    |                                                                                                                                                                                                                                                                                                        |
| **支持复杂书写系统**                    | [文档链接](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                               |
| 添加阿拉伯文本                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                    |                                                                                                                                                                                                                                                                                                        |
| **PDF 优化**                            | [文档链接](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                   |
| 减小 PDF 大小                           | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                    |                                                                                                                                                                                                                                                                                                        |
| **XFA 扁平化**                          | [文档链接](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                          |
| 扁平化 XFA 文档                         | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                |
| <br>                                    |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                | [仓库链接](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                         |
| 调试 PDF                                | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### 常见问题、教程等 ###

查看 [iText 知识库](https://kb.itextpdf.com)
的 [iText Jump-start 教程](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) 及其他
教程、[常见问题](https://kb.itextpdf.com/home/it7kb/faq) 等内容。关于数字签名和 iText 的具体信息和示例，请务必查看
[数字签名中心](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub)。

许多常见问题已经在
[Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7) 上得到了解答，请务必也在此查找。

### 参与贡献

多年来，许多人对 **iText Core/Community** 做出了贡献。如果你发现了 bug、文档错误，或有很酷的新功能想实现，欢迎你的贡献。

小的更改或修复可以作为 [Pull Request](https://github.com/itext/itext7-dotnet/pulls) 提交，对于较大的更改，请通过 community@apryse.com 联系我们，以便更好地协调并避免重复劳动。

请阅读我们的 [贡献指南][contributing]，了解代码提交、编码规范等详情。

### 许可协议

**iText** 采用 [AGPL][agpl]/[商业软件][sales] 双重许可。

AGPL 是一种免费/开源软件许可证，但这并不意味着软件是[免费][gratis]的！

AGPL 是一种 copyleft 许可证，这意味着任何衍生作品也必须在相同条款下授权。如果你在软件或服务中使用 iText，但无法遵守 AGPL 条款，我们提供商业许可，可免除此类义务。

请联系 [销售] 获取更多信息。

[agpl]: LICENSE.md

[building]: BUILDING.md

[contributing]: CONTRIBUTING.md

[layoutMd]: layout/README.md

[itext]: https://itextpdf.com/

[github]: https://github.com/itext/itext7

[latest]: https://github.com/itext/itext7/releases/latest

[sales]: https://itextpdf.com/sales

[gratis]: https://en.wikipedia.org/wiki/Gratis_versus_libre

[rups]: https://github.com/itext/i7j-rups

[pdfhtml]: https://github.com/itext/i7n-pdfhtml

[pdfsweep]: https://github.com/itext/i7n-pdfsweep

[itext7net]: https://github.com/itext/itext7-dotnet
[pdfsweepproduct]: https://itextpdf.com/products/pdf-redaction-pdfsweep

[optimizer]: https://itextpdf.com/products/compress-pdf-pdfoptimizer

[all products]: https://itextpdf.com/products

[pdfhtmlproduct]: https://itextpdf.com/products/itext-pdf-html

[xfa]: https://itextpdf.com/products/flatten-pdf-pdfxfa

[rupsproduct]: https://itextpdf.com/products/rups

[calligraph]: https://itextpdf.com/products/pdfcalligraph

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---