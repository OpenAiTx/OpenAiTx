<image src="https://raw.githubusercontent.com/UglyToad/Pdf/master/documentation/pdfpig.png" width="128px" height="128px"/>

# PdfPig

[![nuget](https://img.shields.io/nuget/dt/PdfPig)](https://www.nuget.org/packages/PdfPig/)
[![Build and test](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test.yml/badge.svg)](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test.yml)
[![Build and test [MacOS]](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test_macos.yml/badge.svg)](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test_macos.yml)

PdfPigはPDFファイルからテキストや内容を読み取ることをサポートします。また、基本的なPDFファイルの作成もサポートしています。

## インストール

このパッケージはリリースタブまたはNugetから入手可能です：

https://www.nuget.org/packages/PdfPig/

またはパッケージマネージャーコンソールから：

    > Install-Package PdfPig

バージョンが1.0.0未満の間は、マイナーバージョンであっても公開APIが警告なしに変更される可能性があります（1.0.0に達するまではSemVerは遵守されません）。

## はじめに

詳細な例については[wiki](https://github.com/UglyToad/PdfPig/wiki)を参照してください。

### PDFからテキストを読み取る

現時点での最も簡単な使い方は、ドキュメントを開き、すべてのページから単語を読み取ることです：

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

`page.Text` を直接使用してはいけません。使い方をよく理解している場合を除きます。`Text` プロパティは内部のコンテンツの順序を保持しますが、それはほとんどの場合、望む順序のテキストではありません。

これらのレイアウト解析ツールは、ほとんどの場合、望むテキストを取得できるはずです。

### PDFドキュメントの作成
ドキュメントを作成するには `PdfDocumentBuilder` クラスを使用します。Standard 14 フォントは、すぐに始めるための簡単な方法を提供します：

```cs
PdfDocumentBuilder builder = new PdfDocumentBuilder();

PdfPageBuilder page = builder.AddPage(PageSize.A4);

// Fonts must be registered with the document builder prior to use to prevent duplication.
PdfDocumentBuilder.AddedFont font = builder.AddStandard14Font(Standard14Font.Helvetica);

page.AddText("Hello World!", 12, new PdfPoint(25, 700), font);

byte[] documentBytes = builder.Build();

File.WriteAllBytes(@"C:\git\newPdf.pdf", documentBytes);
```
出力は、ページ上部近くにHelveticaで「Hello World!」と書かれた1ページのPDFドキュメントです：

![Image shows a PDF document in Google Chrome's PDF viewer. The text "Hello World!" is visible](https://raw.githubusercontent.com/UglyToad/Pdf/master/documentation/builder-output.png)

各フォントはページ間でフォントリソースを共有できるように、使用前に`PdfDocumentBuilder`で登録する必要があります。サポートされているのはStandard 14フォントとTrueTypeフォント（.ttf）のみです。

ドキュメントの作成は既存のPDFドキュメントに対して非常に限定的な変更をサポートします。ただし、以下のいずれもサポートしていません：

- フォームの編集
- 注釈、メタデータ、ドキュメント構造データのコピーまたは変更
- 既存フォントを使用したテキストの追加や削除

### 高度なドキュメント抽出
この例では、より高度なドキュメント抽出が行われます。`PdfDocumentBuilder`を使用して、デバッグ情報（境界ボックスと読み順）を追加したPDFのコピーを作成します。



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

![Image shows a PDF document created by the above code block with the bounding boxes and reading order of the words displayed](/documentation/boundingBoxes_ReadingOrder.png)

詳細なドキュメント解析については、[Document Layout Analysis](https://github.com/UglyToad/PdfPig/wiki/Document-Layout-Analysis)をご覧ください。

ドキュメントレイアウト解析のためのより高度なツールについては、[Export](https://github.com/UglyToad/PdfPig/wiki/Document-Layout-Analysis#export)をご覧ください。


## 使用法

### PdfDocument

`PdfDocument` クラスは、ファイルから読み込むかバイト列として渡されたドキュメントの内容にアクセスを提供します。ファイルから開くには、`PdfDocument.Open` の静的メソッドを使用します：

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

`PdfDocument` は `IDisposable` を実装しているため、`using` ステートメント内でのみ使用するべきです（消費者が他の場所で破棄しない限り）。

暗号化されたドキュメントは PdfPig で開くことができます。所有者パスワードまたはユーザーパスワードを指定するには、`Open` を呼び出す際にオプションの `ParsingOptions` を `Password` プロパティを定義して渡します。例えば：

    using (PdfDocument document = PdfDocument.Open(@"C:\my-file.pdf",  new ParsingOptions { Password = "password here" }))

試すパスワードのリストを提供することもできます：

```cs
using (PdfDocument document = PdfDocument.Open(@"C:\file.pdf", new ParsingOptions
{
	Passwords = new List<string> { "One", "Two" }
}))
```
ドキュメントには、`document.Version` でアクセスできる準拠しているPDF仕様のバージョンが含まれています。

    decimal version = document.Version;

### ドキュメントの作成

`PdfDocumentBuilder` はページやコンテンツのない新しいドキュメントを作成します。

テキストコンテンツには、ビルダーにフォントを登録する必要があります。このライブラリはデフォルトでAdobeが提供するStandard 14フォントとTrueType形式のフォントをサポートしています。

Standard 14フォントを追加するには以下を使用します：

    public AddedFont AddStandard14Font(Standard14Font type)

またはTrueTypeフォントの場合は以下を使用します：

    AddedFont AddTrueTypeFont(IReadOnlyList<byte> fontFileBytes)

TrueTypeファイル（.ttf）のバイト列を渡します。TrueTypeファイルがPDFドキュメントに埋め込み可能かどうかは以下で確認できます：

    bool CanUseTrueTypeFont(IReadOnlyList<byte> fontFileBytes, out IReadOnlyList<string> reasons)

チェックに失敗した場合、フォントを使用できない理由のリストが提供されます。圧縮されたフォントファイルは結果のドキュメントに埋め込まれ配布されるため、TrueTypeフォントの使用前にライセンスを確認してください。

`AddedFont` クラスはドキュメントビルダーに保存されたフォントのキーを表します。ページにテキストコンテンツを追加する際にこれを指定する必要があります。ドキュメントにページを追加するには以下を使用します：

    PdfPageBuilder AddPage(PageSize size, bool isPortrait = true)

指定されたサイズで新しい `PdfPageBuilder` を作成します。最初に追加されたページがページ番号1、次が2、3と続きます。ページビルダーはテキストの追加、線や長方形の描画、描画前のテキストサイズの測定をサポートします。

線や長方形を描画するには以下のメソッドを使用します：


```cs
void DrawLine(PdfPoint from, PdfPoint to, decimal lineWidth = 1)
void DrawRectangle(PdfPoint position, decimal width, decimal height, decimal lineWidth = 1)
```
線の幅は変更可能で、デフォルトは1です。長方形は塗りつぶされておらず、現在は塗りつぶし色を変更できません。

ページにテキストを書くには、上記で説明した `PdfDocumentBuilder` のメソッドから得られる `AddedFont` の参照が必要です。次に、以下を使用してテキストをページに描画できます:

    IReadOnlyList<Letter> AddText(string text, decimal fontSize, PdfPoint position, PdfDocumentBuilder.AddedFont font)

ここで `position` は描画するテキストのベースラインです。現在は **ASCIIテキストのみサポート** されています。描画前にテキストのサイズを測定するには、次のメソッドを使用します:

    IReadOnlyList<Letter> MeasureText(string text, decimal fontSize, PdfPoint position, PdfDocumentBuilder.AddedFont font)

これは `AddText` とは異なり、ページの状態を変更しません。

テキスト、線、長方形のRGB色の変更は次の方法でサポートされています:


```cs
void SetStrokeColor(byte r, byte g, byte b)
void SetTextAndFillColor(byte r, byte g, byte b)
```

RGB値を0から255の間で受け取ります。これらのメソッドの後に呼び出されるすべての操作で色は有効なままで、次のメソッドを使ってリセットされるまで続きます：

    void ResetColor()

これはストローク、塗りつぶし、テキスト描画の色を黒にリセットします。

### ドキュメント情報

`PdfDocument` はPDFファイルに定義された `DocumentInformation` としてドキュメントのメタデータにアクセスを提供します。これらは通常提供されないため、ほとんどのエントリは `null` になります：

```
PdfDocument document = PdfDocument.Open(fileName);

// The name of the program used to convert this document to PDF.
string producer = document.Information.Producer;

// The title given to the document
string title = document.Information.Title;
// etc...
```

### ドキュメント構造

`PdfDocument`にはStructureメンバーがあります：

    UglyToad.PdfPig.Structure structure = document.Structure;

これにより、トークン化されたPDFドキュメントの内容にアクセスできます：

```cs
Catalog catalog = structure.Catalog;
DictionaryToken pagesDictionary = catalog.PagesDictionary;
```

pages 辞書は PDF ドキュメント内のページツリーのルートです。構造はまた、識別番号がわかっていれば PDF 内の任意のオブジェクトにランダムアクセスできる `GetObject(IndirectReference reference)` メソッドを公開しています。これは `69 0 R` の形式の識別子で、69 がオブジェクト番号、0 が世代番号です。

### Page

`Page` はページの幅と高さをポイント単位で含み、`PageSize` 列挙型へのマッピングも提供します：


```cs
PageSize size = Page.Size;

bool isA4 = size == PageSize.A4;
```
`Page` はページのテキストにアクセスできますが、RAG/LLMsのためにテキストをインデックス化する場合は、`ContentOrderTextExtractor` やその他の代替手段を使用すべきです：

    string text = page.Text;

単語にアクセスするメソッドもあります。デフォルトのメソッドは基本的なヒューリスティックを使用します。高度なケースでは、独自の `IWordExtractor` を実装するか、`NearestNeighbourWordExtractor` を使用できます：

    IEnumerable<Word> words = page.GetWords();

ページのコンテンツストリームでグラフィックスやコンテンツを描画するために使用される生の操作にもアクセスできます：

    IReadOnlyList<IGraphicsStateOperation> operations = page.Operations;

個々のオペレーターの意味についてはPDF仕様書を参照してください。

ページごとのPDF画像オブジェクトを取得するAPIもあります：

    IEnumerable<XObjectImage> images = page.GetImages();

[Imagesに関するWiki](https://github.com/UglyToad/PdfPig/wiki/Images) をお読みください。

### Letter

PDFの内部構造上、ページのテキストは文書に表示されるテキストの読みやすい表現とは限りません。PDFはプレゼンテーション形式であるため、テキストは任意の順序で描画され、必ずしも読み順ではありません。これにより、スペースが欠落したり、単語がテキスト内で予期しない位置にある場合があります。

ユーザーがページ上の実際のテキスト順を解決するのを助けるために、`Page` ファイルは文字のリストへのアクセスを提供します：

    IReadOnlyList<Letter> letters = page.Letters;

これらの文字には以下が含まれます：

- 文字のテキスト：`letter.Value`。
- 文字の左下の位置：`letter.Location`。
- 文字の幅：`letter.Width`。
- スケールされていない相対テキスト単位でのフォントサイズ（これらのサイズはPDF内部のもので、ピクセル、ポイント、その他の単位のサイズに対応しません）：`letter.FontSize`。
- 文字のレンダリングに使用されたフォント名（利用可能な場合）：`letter.FontName`。
- 文字/グリフの可視領域を完全に含む最小の矩形：`letter.GlyphRectangle`。
- ベースラインの開始点と終了点である `StartBaseLine` と `EndBaseLine`。これにより文字が回転しているかがわかります。`TextDirection` はこれが一般的な回転かカスタム回転かを示します。

文字の位置は、原点がページの左下隅であるPDF座標系で測定されます。したがって、Y値が大きいほどページの上部に近いことを意味します。

### 注釈

各ページの注釈の取得は、以下のメソッドを使用して提供されます：

    page.GetAnnotations()

この呼び出しはキャッシュされず、使用前にドキュメントが破棄されていない必要があります。注釈は編集できません。

### しおり

ドキュメントのしおり（アウトライン）はドキュメントレベルで取得できます：

    bool hasBookmarks = document.TryGetBookmarks(out Bookmarks bookmarks);

ドキュメントにしおりが定義されていない場合は `false` を返します。

### フォーム

インタラクティブフォーム（AcroForms）のフォームフィールドは以下で取得できます：

    bool hasForm = document.TryGetForm(out AcroForm form);

ドキュメントにフォームが含まれていない場合は `false` を返します。

フィールドは `AcroForm` の `Fields` プロパティを使ってアクセスできます。フォームはドキュメントレベルで定義されているため、ドキュメント内のすべてのページのフィールドが返されます。フィールドは enum `AcroFieldType` によって定義された型（例えば `PushButton`、`Checkbox`、`Text` など）です。

PdfPigではフォームは読み取り専用であり、値の変更や追加はできないことに注意してください。

### ハイパーリンク

ページにはハイパーリンク（リンクタイプの注釈）を抽出するメソッドがあります：

    IReadOnlyList<UglyToad.PdfPig.Content.Hyperlink> hyperlinks = page.GetHyperlinks();

ドキュメント作成時にハイパーリンクを追加または編集することはできません。

### TrueType

PDFファイル内のTrueTypeフォントを扱うためのクラスは公開されています。入力ファイルが与えられた場合：



```cs
using UglyToad.PdfPig.Fonts.TrueType;
using UglyToad.PdfPig.Fonts.TrueType.Parser;

byte[] fontBytes = System.IO.File.ReadAllBytes(@"C:\font.ttf");
TrueTypeDataBytes input = new TrueTypeDataBytes(fontBytes);
TrueTypeFont font = TrueTypeFontParser.Parse(input);
```
解析されたフォントを検査することができます。

### 埋め込みファイル

PDFファイルには、文書注釈のために完全に埋め込まれた他のファイルが含まれている場合があります。埋め込みファイルの一覧とそのバイト内容にアクセスすることができます：


```cs
if (document.Advanced.TryGetEmbeddedFiles(out IReadOnlyList<EmbeddedFile> files)
    && files.Count > 0)
{
    var firstFile = files[0];
    string name = firstFile.Name;
    IReadOnlyList<byte> bytes = firstFile.Bytes;
}
```

### マージ

`PdfMerger` クラスを使用して、2つ以上の既存のPDFファイルをマージできます:

```cs
var resultFileBytes = PdfMerger.Merge(filePath1, filePath2);
File.WriteAllBytes(@"C:\pdfs\outputfilename.pdf", resultFileBytes);
```

## Wiki
詳細なガイドやAPIの例については、[wiki](https://github.com/UglyToad/PdfPig/wiki)をご覧ください。

## Issues

バグに遭遇した場合は、ぜひIssueを提出してください。詳細は[issueポリシー](https://github.com/UglyToad/PdfPig/issues/1095)および[貢献ガイド](https://github.com/UglyToad/PdfPig/blob/master/CONTRIBUTING.md)をご確認ください。

## API Reference

doxygenドキュメントを生成する場合は、`doxygen doxygen-docs`を実行し、`docs/doxygen/html/index.html`を開いてください。

## Credit

このプロジェクトは[PDFBox](https://github.com/apache/pdfbox)をC#に移植する試みとして始まりました。このプロジェクトは[PDFBox](https://pdfbox.apache.org/)チームとApache Foundationの作業なしには実現できませんでした。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---