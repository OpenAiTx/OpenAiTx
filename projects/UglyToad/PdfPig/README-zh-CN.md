<image src="https://raw.githubusercontent.com/UglyToad/Pdf/master/documentation/pdfpig.png" width="128px" height="128px"/>

# PdfPig

[![nuget](https://img.shields.io/nuget/dt/PdfPig)](https://www.nuget.org/packages/PdfPig/)
[![Build and test](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test.yml/badge.svg)](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test.yml)
[![Build and test [MacOS]](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test_macos.yml/badge.svg)](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test_macos.yml)

PdfPig 支持从 PDF 文件中读取文本和内容。它还支持基本的 PDF 文件创建。

## 安装

该包可通过发布标签或 Nuget 获得：

https://www.nuget.org/packages/PdfPig/

或者通过包管理控制台：

    > Install-Package PdfPig

在版本低于 1.0.0 时，小版本号更新将不通知地更改公共 API（直到达到 1.0.0 版本前不会遵循 SemVer）。

## 入门

查看 [wiki](https://github.com/UglyToad/PdfPig/wiki) 获取更多示例

### 从 PDF 中读取文本

目前最简单的用法是打开文档，读取每页的单词：

```cs
// using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;
// using UglyToad.PdfPig.DocumentLayoutAnalysis.WordExtractor;
using (PdfDocument document = PdfDocument.Open(@"C:\Documents\document.pdf"))
{
    foreach (Page page in document.GetPages())
    {
        string text = ContentOrderTextExtractor.GetText(page);
        IEnumerable<Word> words = page.GetWords(NearestNeighbourWordExtractor.Instance);
    }
}
```

你**不应该**直接使用`page.Text`，除非你知道自己在做什么。`Text`属性保留了内部内容的顺序，这通常不是你想要的文本顺序。

这些布局分析工具应该能在大多数情况下帮你获得想要的文本。

### 创建 PDF 文档
要创建文档，请使用类`PdfDocumentBuilder`。标准14种字体提供了一个快速入门的方法：

```cs
PdfDocumentBuilder builder = new PdfDocumentBuilder();

PdfPageBuilder page = builder.AddPage(PageSize.A4);

// Fonts must be registered with the document builder prior to use to prevent duplication.
PdfDocumentBuilder.AddedFont font = builder.AddStandard14Font(Standard14Font.Helvetica);

page.AddText("Hello World!", 12, new PdfPoint(25, 700), font);

byte[] documentBytes = builder.Build();

File.WriteAllBytes(@"C:\git\newPdf.pdf", documentBytes);
```
输出是一个1页的PDF文档，页面顶部附近用Helvetica字体显示文本“Hello World！”：

![图片显示了Google Chrome的PDF查看器中的PDF文档。文本“Hello World！”可见](https://raw.githubusercontent.com/UglyToad/Pdf/master/documentation/builder-output.png)

每种字体必须先在`PdfDocumentBuilder`中注册，才能启用页面共享字体资源。仅支持标准14字体和TrueType字体（.ttf）。

文档创建支持对现有PDF文档的非常有限的更改。但不支持以下任何操作：

- 编辑表单
- 复制或更改注释、元数据或文档结构数据
- 使用现有字体添加或删除文本

### 高级文档提取
在此示例中执行了更高级的文档提取。`PdfDocumentBuilder`用于创建带有调试信息（边界框和阅读顺序）副本的PDF。



```cs
//using UglyToad.PdfPig;
//using UglyToad.PdfPig.DocumentLayoutAnalysis.PageSegmenter;
//using UglyToad.PdfPig.DocumentLayoutAnalysis.ReadingOrderDetector;
//using UglyToad.PdfPig.DocumentLayoutAnalysis.WordExtractor;
//using UglyToad.PdfPig.Fonts.Standard14Fonts;
//using UglyToad.PdfPig.Writer;


var sourcePdfPath = "";
var outputPath = "";
var pageNumber = 1;
using (var document = PdfDocument.Open(sourcePdfPath))
{
    var builder = new PdfDocumentBuilder { };
    PdfDocumentBuilder.AddedFont font = builder.AddStandard14Font(Standard14Font.Helvetica);
    var pageBuilder = builder.AddPage(document, pageNumber);
    pageBuilder.SetStrokeColor(0, 255, 0);
    var page = document.GetPage(pageNumber);

    var letters = page.Letters; // no preprocessing

    // 1. Extract words
    var wordExtractor = NearestNeighbourWordExtractor.Instance;

    var words = wordExtractor.GetWords(letters);

    // 2. Segment page
    var pageSegmenter = DocstrumBoundingBoxes.Instance;

    var textBlocks = pageSegmenter.GetBlocks(words);

    // 3. Postprocessing
    var readingOrder = UnsupervisedReadingOrderDetector.Instance;
    var orderedTextBlocks = readingOrder.Get(textBlocks);

    // 4. Add debug info - Bounding boxes and reading order
    foreach (var block in orderedTextBlocks)
    {
        var bbox = block.BoundingBox;
        pageBuilder.DrawRectangle(bbox.BottomLeft, bbox.Width, bbox.Height);
        pageBuilder.AddText(block.ReadingOrder.ToString(), 8, bbox.TopLeft, font);
    }

    // 5. Write result to a file
    byte[] fileBytes = builder.Build();
    File.WriteAllBytes(outputPath, fileBytes); // save to file
}
```

![图片显示由上述代码块创建的PDF文档，带有单词的边界框和阅读顺序](/documentation/boundingBoxes_ReadingOrder.png)

有关高级文档分析的更多信息，请参见[文档布局分析](https://github.com/UglyToad/PdfPig/wiki/Document-Layout-Analysis)。

有关分析文档布局的更多高级工具，请参见[导出](https://github.com/UglyToad/PdfPig/wiki/Document-Layout-Analysis#export)。


## 用法

### PdfDocument

`PdfDocument` 类提供访问从文件加载或以字节传入的文档内容。要从文件打开，请使用 `PdfDocument.Open` 静态方法：

```cs
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

using (PdfDocument document = PdfDocument.Open(@"C:\my-file.pdf"))
{
	int pageCount = document.NumberOfPages;

	// Page number starts from 1, not 0.
	Page page = document.GetPage(1);

	decimal widthInPoints = page.Width;
	decimal heightInPoints = page.Height;

	string text = page.Text;
}
```
`PdfDocument` 应该只在 `using` 语句中使用，因为它实现了 `IDisposable`（除非使用者在其他地方释放它）。

PdfPig 可以打开加密文档。要提供所有者密码或用户密码，请在调用 `Open` 时传入带有 `Password` 属性定义的可选 `ParsingOptions`。例如：

    using (PdfDocument document = PdfDocument.Open(@"C:\my-file.pdf",  new ParsingOptions { Password = "password here" }))

您也可以提供一个密码列表进行尝试：


```cs
using (PdfDocument document = PdfDocument.Open(@"C:\file.pdf", new ParsingOptions
{
	Passwords = new List<string> { "One", "Two" }
}))
```
文档包含其遵循的 PDF 规范版本，可通过 `document.Version` 访问：

    decimal version = document.Version;

### 文档创建

`PdfDocumentBuilder` 创建一个没有页面或内容的新文档。

对于文本内容，必须向构建器注册字体。该库默认支持 Adobe 提供的标准 14 字体和 TrueType 格式字体。

添加标准 14 字体使用：

    public AddedFont AddStandard14Font(Standard14Font type)

或者对于 TrueType 字体使用：

    AddedFont AddTrueTypeFont(IReadOnlyList<byte> fontFileBytes)

传入 TrueType 文件（.ttf）的字节。您可以使用以下方法检查 TrueType 文件是否适合嵌入 PDF 文档：

    bool CanUseTrueTypeFont(IReadOnlyList<byte> fontFileBytes, out IReadOnlyList<string> reasons)

如果检查失败，会提供字体无法使用的原因列表。您应在使用 TrueType 字体前检查其许可，因为压缩字体文件会被嵌入并随生成的文档分发。

`AddedFont` 类表示存储在文档构建器上的字体的键。添加文本内容到页面时必须提供此键。添加页面到文档使用：

    PdfPageBuilder AddPage(PageSize size, bool isPortrait = true)

这将创建一个指定大小的新 `PdfPageBuilder`。第一个添加的页面编号为 1，依次为 2、3 等。页面构建器支持添加文本、绘制线条和矩形，以及在绘制前测量文本大小。

绘制线条和矩形使用以下方法：


```cs
void DrawLine(PdfPoint from, PdfPoint to, decimal lineWidth = 1)
void DrawRectangle(PdfPoint position, decimal width, decimal height, decimal lineWidth = 1)
```
线宽可以变化，默认值为1。矩形是空心的，目前无法更改填充颜色。

要向页面写入文本，必须引用上文所述的 `PdfDocumentBuilder` 方法中的 `AddedFont`。然后可以使用以下方法将文本绘制到页面：

    IReadOnlyList<Letter> AddText(string text, decimal fontSize, PdfPoint position, PdfDocumentBuilder.AddedFont font)

其中 `position` 是要绘制文本的基线位置。目前**仅支持ASCII文本**。您还可以使用以下方法在绘制之前测量文本的最终大小：

    IReadOnlyList<Letter> MeasureText(string text, decimal fontSize, PdfPoint position, PdfDocumentBuilder.AddedFont font)

该方法不会改变页面状态，与 `AddText` 不同。

支持通过以下方式更改文本、线条和矩形的RGB颜色：


```cs
void SetStrokeColor(byte r, byte g, byte b)
void SetTextAndFillColor(byte r, byte g, byte b)
```

其接受介于0到255之间的RGB值。颜色将在调用这些方法后对所有操作保持激活状态，直到使用以下方法重置：

    void ResetColor()

该方法将笔触、填充和文本绘制的颜色重置为黑色。

### 文档信息

`PdfDocument` 提供对PDF文件中定义的文档元数据的访问，作为 `DocumentInformation`。这些信息往往未被提供，因此大多数条目将为 `null`：

```
PdfDocument document = PdfDocument.Open(fileName);

// The name of the program used to convert this document to PDF.
string producer = document.Information.Producer;

// The title given to the document
string title = document.Information.Title;
// etc...
```

### 文档结构

`PdfDocument` 有一个 Structure 成员：

    UglyToad.PdfPig.Structure structure = document.Structure;

这提供了对标记化 PDF 文档内容的访问：

```cs
Catalog catalog = structure.Catalog;
DictionaryToken pagesDictionary = catalog.PagesDictionary;
```

pages 字典是 PDF 文档中 pages 树的根节点。该结构还公开了一个 `GetObject(IndirectReference reference)` 方法，允许只要知道对象的标识号，就可以随机访问 PDF 中的任何对象。该标识符的形式为 `69 0 R`，其中 69 是对象编号，0 是生成号。

### Page

`Page` 包含以点为单位的页面宽度和高度，以及映射到 `PageSize` 枚举：


```cs
PageSize size = Page.Size;

bool isA4 = size == PageSize.A4;
```
`Page` 提供对页面文本的访问，但如果要索引文本，例如用于 RAG/LLMs，应使用 `ContentOrderTextExtractor` 或其他替代方法：

    string text = page.Text;

有一个方法可以访问单词。默认方法使用基本启发式。对于高级用例，您也可以实现自己的 `IWordExtractor` 或使用 `NearestNeighbourWordExtractor`：

    IEnumerable<Word> words = page.GetWords();

您还可以访问用于在页面上绘制图形和内容的页面内容流中的原始操作：

    IReadOnlyList<IGraphicsStateOperation> operations = page.Operations;

有关各个操作符的含义，请参阅 PDF 规范。

还有一个 API 可以按页检索 PDF 图像对象：

    IEnumerable<XObjectImage> images = page.GetImages();

请阅读 [关于图像的 Wiki](https://github.com/UglyToad/PdfPig/wiki/Images)。

### Letter

由于 PDF 内部结构的方式，页面文本可能不是文档中显示文本的可读表示。因为 PDF 是一种呈现格式，文本可以以任何顺序绘制，不一定是阅读顺序。这意味着文本中可能缺少空格，或者单词位置可能异常。

为了帮助用户解决页面上实际文本顺序，`Page` 文件提供对字母列表的访问：

    IReadOnlyList<Letter> letters = page.Letters;

这些字母包含：

- 字母的文本：`letter.Value`。
- 字母左下角的位置：`letter.Location`。
- 字母的宽度：`letter.Width`。
- 字体大小（未缩放的相对文本单位，这些大小是 PDF 内部的，不对应像素、点或其他单位的大小）：`letter.FontSize`。
- 用于渲染字母的字体名称（如果可用）：`letter.FontName`。
- 一个矩形，是完全包含字母/字形可见区域的最小矩形：`letter.GlyphRectangle`。
- 基线起点和终点的点 `StartBaseLine` 和 `EndBaseLine`，指示字母是否旋转。`TextDirection` 表示这是常用旋转还是自定义旋转。

字母位置以 PDF 坐标测量，原点位于页面左下角。因此，较高的 Y 值意味着更接近页面顶部。

### 注释

每页的注释可以通过以下方法获取：

    page.GetAnnotations()

该调用不进行缓存，且文档在使用前不得被释放。注释不可编辑。

### 书签

文档的书签（大纲）可在文档级别获取：

    bool hasBookmarks = document.TryGetBookmarks(out Bookmarks bookmarks);

如果文档未定义任何书签，则返回 `false`。

### 表单

交互式表单（AcroForms）的表单字段可通过以下方式获取：

    bool hasForm = document.TryGetForm(out AcroForm form);

如果文档不包含表单，则返回 `false`。

字段可通过 `AcroForm` 的 `Fields` 属性访问。由于表单定义在文档级别，因此该属性返回文档中所有页面的字段。字段类型由枚举 `AcroFieldType` 定义，例如 `PushButton`、`Checkbox`、`Text` 等。

请注意，表单为只读，无法通过 PdfPig 更改或添加值。

### 超链接

页面具有提取超链接（链接类型注释）的方法：

    IReadOnlyList<UglyToad.PdfPig.Content.Hyperlink> hyperlinks = page.GetHyperlinks();

构建文档时无法添加或编辑超链接。

### TrueType

用于处理 PDF 文件中 TrueType 字体的类可供公开使用。给定一个输入文件：



```cs
using UglyToad.PdfPig.Fonts.TrueType;
using UglyToad.PdfPig.Fonts.TrueType.Parser;

byte[] fontBytes = System.IO.File.ReadAllBytes(@"C:\font.ttf");
TrueTypeDataBytes input = new TrueTypeDataBytes(fontBytes);
TrueTypeFont font = TrueTypeFontParser.Parse(input);
```
解析后的字体随后可以进行检查。

### 嵌入文件

PDF 文件可能包含完全嵌入其中的其他文件，用于文档注释。可以访问嵌入文件的列表及其字节内容：


```cs
if (document.Advanced.TryGetEmbeddedFiles(out IReadOnlyList<EmbeddedFile> files)
    && files.Count > 0)
{
    var firstFile = files[0];
    string name = firstFile.Name;
    IReadOnlyList<byte> bytes = firstFile.Bytes;
}
```

### 合并

您可以使用 `PdfMerger` 类合并 2 个或更多现有的 PDF 文件：

```cs
var resultFileBytes = PdfMerger.Merge(filePath1, filePath2);
File.WriteAllBytes(@"C:\pdfs\outputfilename.pdf", resultFileBytes);
```

## Wiki
查看我们的[wiki](https://github.com/UglyToad/PdfPig/wiki)以获取更多示例和详细的API指南。

## Issues

如果您遇到错误，请务必提交问题。详情请参阅我们的[问题政策](https://github.com/UglyToad/PdfPig/issues/1095)和[贡献指南](https://github.com/UglyToad/PdfPig/blob/master/CONTRIBUTING.md)。

## API Reference

如果您想生成doxygen文档，请运行`doxygen doxygen-docs`并打开`docs/doxygen/html/index.html`。

## Credit

该项目起初是将[PDFBox](https://github.com/apache/pdfbox)移植到C#的尝试。没有[PDFBox](https://pdfbox.apache.org/)团队和Apache基金会的工作，这个项目是不可能实现的。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---