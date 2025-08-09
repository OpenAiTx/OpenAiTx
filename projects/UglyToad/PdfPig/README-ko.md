<image src="https://raw.githubusercontent.com/UglyToad/Pdf/master/documentation/pdfpig.png" width="128px" height="128px"/>

# PdfPig

[![nuget](https://img.shields.io/nuget/dt/PdfPig)](https://www.nuget.org/packages/PdfPig/)
[![Build and test](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test.yml/badge.svg)](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test.yml)
[![Build and test [MacOS]](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test_macos.yml/badge.svg)](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test_macos.yml)

PdfPig은 PDF 파일에서 텍스트와 콘텐츠를 읽는 것을 지원합니다. 또한 기본적인 PDF 파일 생성도 지원합니다.

## 설치

패키지는 릴리즈 탭이나 Nuget에서 사용 가능합니다:

https://www.nuget.org/packages/PdfPig/

또는 패키지 관리자 콘솔에서:

    > Install-Package PdfPig

버전이 1.0.0 미만인 동안에는 경고 없이 공용 API가 변경될 수 있습니다 (1.0.0에 도달할 때까지 SemVer가 준수되지 않습니다).

## 시작하기

더 많은 예제는 [위키](https://github.com/UglyToad/PdfPig/wiki)를 참조하세요

### PDF에서 텍스트 읽기

현재 가장 간단한 사용법은 문서를 열고 모든 페이지에서 단어를 읽는 것입니다:

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
`page.Text`를 직접 사용해서는 **안 됩니다**, 만약 사용한다면 무엇을 하는지 정확히 알고 있어야 합니다. `Text` 속성은 내부 콘텐츠 순서를 보존하는데, 이는 거의 원하는 순서의 텍스트가 아닙니다.

이 레이아웃 분석 도구들은 대부분의 경우 원하는 텍스트를 얻는 데 도움이 될 것입니다.

### PDF 문서 생성
문서를 생성하려면 `PdfDocumentBuilder` 클래스를 사용하세요. Standard 14 폰트는 빠르게 시작할 수 있는 방법을 제공합니다:


```cs
PdfDocumentBuilder builder = new PdfDocumentBuilder();

PdfPageBuilder page = builder.AddPage(PageSize.A4);

// Fonts must be registered with the document builder prior to use to prevent duplication.
PdfDocumentBuilder.AddedFont font = builder.AddStandard14Font(Standard14Font.Helvetica);

page.AddText("Hello World!", 12, new PdfPoint(25, 700), font);

byte[] documentBytes = builder.Build();

File.WriteAllBytes(@"C:\git\newPdf.pdf", documentBytes);
```
출력은 페이지 상단 근처에 헬베티카 글꼴로 "Hello World!" 텍스트가 있는 1페이지 PDF 문서입니다:

![이미지는 Google Chrome의 PDF 뷰어에서 PDF 문서를 보여줍니다. "Hello World!" 텍스트가 보입니다](https://raw.githubusercontent.com/UglyToad/Pdf/master/documentation/builder-output.png)

각 글꼴은 `PdfDocumentBuilder`에 사전에 등록되어야 페이지들이 글꼴 리소스를 공유할 수 있습니다. 표준 14 글꼴과 TrueType 글꼴(.ttf)만 지원됩니다.

문서 생성은 기존 PDF 문서에 매우 제한적인 변경만 지원합니다. 그러나 다음과 같은 작업은 지원하지 않습니다:

- 폼 편집
- 주석, 메타데이터 또는 문서 구조 데이터 복사 또는 변경
- 기존 글꼴로 텍스트 추가 또는 제거

### 고급 문서 추출
이 예제에서는 보다 고급 문서 추출이 수행됩니다. `PdfDocumentBuilder`를 사용하여 디버그 정보(경계 상자 및 읽기 순서)가 추가된 pdf 복사본을 만듭니다.



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

![위 코드를 통해 생성된 PDF 문서의 단어 경계 상자와 읽기 순서가 표시된 이미지](/documentation/boundingBoxes_ReadingOrder.png)

고급 문서 분석에 관한 자세한 내용은 [문서 레이아웃 분석](https://github.com/UglyToad/PdfPig/wiki/Document-Layout-Analysis)을 참조하세요.

문서 레이아웃 분석을 위한 더 고급 도구는 [내보내기](https://github.com/UglyToad/PdfPig/wiki/Document-Layout-Analysis#export)를 참조하세요.


## 사용법

### PdfDocument

`PdfDocument` 클래스는 파일에서 로드되었거나 바이트로 전달된 문서의 내용에 접근할 수 있도록 합니다. 파일에서 열려면 `PdfDocument.Open` 정적 메서드를 사용하세요:

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
`PdfDocument`는 `IDisposable`을 구현하므로 `using` 문 내에서만 사용해야 합니다(소비자가 다른 곳에서 해제하지 않는 한).

암호화된 문서는 PdfPig로 열 수 있습니다. 소유자 또는 사용자 암호를 제공하려면 `Open`을 호출할 때 `Password` 속성이 정의된 선택적 `ParsingOptions`를 제공합니다. 예를 들어:

    using (PdfDocument document = PdfDocument.Open(@"C:\my-file.pdf",  new ParsingOptions { Password = "password here" }))

시도할 암호 목록을 제공할 수도 있습니다:


```cs
using (PdfDocument document = PdfDocument.Open(@"C:\file.pdf", new ParsingOptions
{
	Passwords = new List<string> { "One", "Two" }
}))
```
문서에는 `document.Version`을 통해 접근할 수 있는 준수하는 PDF 사양 버전이 포함되어 있습니다:

    decimal version = document.Version;

### 문서 생성

`PdfDocumentBuilder`는 페이지나 내용이 없는 새 문서를 생성합니다.

텍스트 내용을 위해서는 빌더에 글꼴이 등록되어야 합니다. 이 라이브러리는 기본적으로 Adobe에서 제공하는 Standard 14 글꼴과 TrueType 형식 글꼴을 지원합니다.

Standard 14 글꼴을 추가하려면 다음을 사용하세요:

    public AddedFont AddStandard14Font(Standard14Font type)

또는 TrueType 글꼴의 경우:

    AddedFont AddTrueTypeFont(IReadOnlyList<byte> fontFileBytes)

TrueType 파일(.ttf)의 바이트를 전달합니다. TrueType 파일이 PDF 문서에 포함하기 적합한지 확인하려면 다음을 사용할 수 있습니다:

    bool CanUseTrueTypeFont(IReadOnlyList<byte> fontFileBytes, out IReadOnlyList<string> reasons)

이 함수는 체크 실패 시 글꼴을 사용할 수 없는 이유 목록을 제공합니다. TrueType 글꼴을 사용하기 전에 라이선스를 확인해야 합니다. 왜냐하면 압축된 글꼴 파일이 결과 문서에 포함되어 배포되기 때문입니다.

`AddedFont` 클래스는 문서 빌더에 저장된 글꼴에 대한 키를 나타냅니다. 페이지에 텍스트 내용을 추가할 때 반드시 이 키를 제공해야 합니다. 문서에 페이지를 추가하려면 다음을 사용하세요:

    PdfPageBuilder AddPage(PageSize size, bool isPortrait = true)

지정한 크기로 새 `PdfPageBuilder`를 생성합니다. 처음 추가된 페이지가 1번 페이지이고 그 다음이 2, 3 등입니다. 페이지 빌더는 텍스트 추가, 선과 사각형 그리기, 그리고 그리기 전에 텍스트 크기 측정을 지원합니다.

선과 사각형을 그리려면 다음 메서드를 사용하세요:


```cs
void DrawLine(PdfPoint from, PdfPoint to, decimal lineWidth = 1)
void DrawRectangle(PdfPoint position, decimal width, decimal height, decimal lineWidth = 1)
```
선 너비는 변경할 수 있으며 기본값은 1입니다. 사각형은 채워지지 않으며 현재 채우기 색상을 변경할 수 없습니다.

페이지에 텍스트를 작성하려면 위에서 설명한 `PdfDocumentBuilder`의 메서드에서 `AddedFont`에 대한 참조가 있어야 합니다. 그런 다음 다음을 사용하여 텍스트를 페이지에 그릴 수 있습니다:

    IReadOnlyList<Letter> AddText(string text, decimal fontSize, PdfPoint position, PdfDocumentBuilder.AddedFont font)

여기서 `position`은 그릴 텍스트의 기준선입니다. 현재 **ASCII 텍스트만 지원**됩니다. 또한 다음 메서드를 사용하여 그리기 전에 텍스트의 결과 크기를 측정할 수 있습니다:

    IReadOnlyList<Letter> MeasureText(string text, decimal fontSize, PdfPoint position, PdfDocumentBuilder.AddedFont font)

이 메서드는 `AddText`와 달리 페이지의 상태를 변경하지 않습니다.

텍스트, 선 및 사각형의 RGB 색상 변경은 다음을 사용하여 지원됩니다:


```cs
void SetStrokeColor(byte r, byte g, byte b)
void SetTextAndFillColor(byte r, byte g, byte b)
```
  
RGB 값이 0에서 255 사이인 값을 받습니다. 이 색상은 다음 메서드들이 호출될 때까지 모든 작업에 대해 활성 상태로 유지되며, 다음을 사용하여 리셋할 때까지 유지됩니다:

    void ResetColor()

이는 스트로크, 채우기 및 텍스트 그리기 색상을 검정색으로 재설정합니다.

### 문서 정보

`PdfDocument`는 PDF 파일에 정의된 문서 메타데이터에 대한 접근을 `DocumentInformation`으로 제공합니다. 이 정보들은 대부분 제공되지 않으므로 대부분의 항목이 `null`일 것입니다:

```
PdfDocument document = PdfDocument.Open(fileName);

// The name of the program used to convert this document to PDF.
string producer = document.Information.Producer;

// The title given to the document
string title = document.Information.Title;
// etc...
```
### 문서 구조

`PdfDocument`에는 Structure 멤버가 있습니다:

    UglyToad.PdfPig.Structure structure = document.Structure;

이것은 토큰화된 PDF 문서 내용에 접근을 제공합니다:


```cs
Catalog catalog = structure.Catalog;
DictionaryToken pagesDictionary = catalog.PagesDictionary;
```

페이지 사전은 PDF 문서 내 페이지 트리의 루트입니다. 이 구조는 식별자 번호가 알려져 있는 한 PDF 내의 모든 객체에 임의 접근을 허용하는 `GetObject(IndirectReference reference)` 메서드도 노출합니다. 이 식별자는 `69 0 R` 형식이며, 여기서 69는 객체 번호이고 0은 세대 번호입니다.

### 페이지

`Page`는 포인트 단위의 페이지 너비와 높이 및 `PageSize` 열거형에 대한 매핑을 포함합니다:


```cs
PageSize size = Page.Size;

bool isA4 = size == PageSize.A4;
```
`Page`는 페이지의 텍스트에 접근할 수 있지만, 텍스트를 인덱싱할 때는 예를 들어 RAG/LLMs 용으로 `ContentOrderTextExtractor` 또는 대체 방법을 사용하는 것이 좋습니다:

    string text = page.Text;

단어에 접근할 수 있는 메서드가 있습니다. 기본 메서드는 기본적인 휴리스틱을 사용합니다. 고급 경우에는 직접 `IWordExtractor`를 구현하거나 `NearestNeighbourWordExtractor`를 사용할 수 있습니다:

    IEnumerable<Word> words = page.GetWords();

페이지의 콘텐츠 스트림에서 그래픽과 콘텐츠를 그리기 위해 사용된 원시 작업들에도 접근할 수 있습니다:

    IReadOnlyList<IGraphicsStateOperation> operations = page.Operations;

개별 연산자의 의미는 PDF 명세서를 참조하세요.

페이지별 PDF 이미지 객체를 가져오는 API도 있습니다:

    IEnumerable<XObjectImage> images = page.GetImages();

[Images 위키](https://github.com/UglyToad/PdfPig/wiki/Images)를 읽어보세요.

### Letter

PDF가 내부적으로 구성되는 방식 때문에 페이지 텍스트는 문서에 나타나는 텍스트의 읽기 가능한 표현이 아닐 수 있습니다. PDF는 표현 형식이기 때문에 텍스트가 반드시 읽기 순서대로 그려지지 않습니다. 이로 인해 공백이 없거나 단어가 예상치 못한 위치에 있을 수 있습니다.

사용자가 실제 페이지 텍스트 순서를 해결하도록 돕기 위해 `Page` 파일은 문자 목록에 접근할 수 있도록 제공합니다:

    IReadOnlyList<Letter> letters = page.Letters;

이 문자들은 다음을 포함합니다:

- 문자의 텍스트: `letter.Value`.
- 문자의 왼쪽 하단 위치: `letter.Location`.
- 문자의 너비: `letter.Width`.
- 스케일링되지 않은 상대 텍스트 단위의 글꼴 크기(PDF 내부 크기로, 픽셀, 포인트 또는 다른 단위와 일치하지 않음): `letter.FontSize`.
- 문자를 렌더링하는 데 사용된 글꼴 이름(가능한 경우): `letter.FontName`.
- 문자/글리프의 가시 영역을 완전히 포함하는 가장 작은 사각형: `letter.GlyphRectangle`.
- 문자가 회전되었는지 나타내는 기준선 시작점과 끝점 `StartBaseLine` 및 `EndBaseLine`. `TextDirection`은 일반적으로 사용되는 회전인지 사용자 지정 회전인지 나타냅니다.

문자 위치는 PDF 좌표계로 측정되며, 원점은 페이지의 왼쪽 하단 모서리입니다. 따라서 Y 값이 클수록 페이지 상단에 가깝습니다.

### 주석

각 페이지의 주석을 가져오는 방법은 다음과 같습니다:

    page.GetAnnotations()

이 호출은 캐시되지 않으며, 문서가 사용 전에 해제되지 않아야 합니다. 주석은 편집할 수 없습니다.

### 북마크

문서의 북마크(개요)는 문서 수준에서 가져올 수 있습니다:

    bool hasBookmarks = document.TryGetBookmarks(out Bookmarks bookmarks);

문서에 북마크가 정의되어 있지 않으면 `false`를 반환합니다.

### 폼

대화형 폼(AcroForms)의 폼 필드는 다음을 사용하여 가져올 수 있습니다:

    bool hasForm = document.TryGetForm(out AcroForm form);

문서에 폼이 포함되어 있지 않으면 `false`를 반환합니다.

필드는 `AcroForm`의 `Fields` 속성을 통해 접근할 수 있습니다. 폼이 문서 수준에서 정의되어 있으므로 문서의 모든 페이지에서 필드를 반환합니다. 필드는 `AcroFieldType` 열거형으로 정의된 유형이며, 예를 들어 `PushButton`, `Checkbox`, `Text` 등이 있습니다.

PdfPig을 사용하여 폼은 읽기 전용이며 값 변경이나 추가는 불가능합니다.

### 하이퍼링크

페이지는 하이퍼링크(링크 유형 주석)를 추출하는 메서드를 갖고 있습니다:

    IReadOnlyList<UglyToad.PdfPig.Content.Hyperlink> hyperlinks = page.GetHyperlinks();

문서 작성 시 하이퍼링크를 추가하거나 편집할 수 없습니다.

### TrueType

PDF 파일 내 TrueType 글꼴 작업에 사용되는 클래스는 공개되어 있습니다. 입력 파일이 주어지면:



```cs
using UglyToad.PdfPig.Fonts.TrueType;
using UglyToad.PdfPig.Fonts.TrueType.Parser;

byte[] fontBytes = System.IO.File.ReadAllBytes(@"C:\font.ttf");
TrueTypeDataBytes input = new TrueTypeDataBytes(fontBytes);
TrueTypeFont font = TrueTypeFontParser.Parse(input);
```

파싱된 폰트를 검사할 수 있습니다.

### 포함된 파일

PDF 파일에는 문서 주석을 위해 완전히 포함된 다른 파일들이 있을 수 있습니다. 포함된 파일 목록과 해당 바이트 내용을 확인할 수 있습니다:

```cs
if (document.Advanced.TryGetEmbeddedFiles(out IReadOnlyList<EmbeddedFile> files)
    && files.Count > 0)
{
    var firstFile = files[0];
    string name = firstFile.Name;
    IReadOnlyList<byte> bytes = firstFile.Bytes;
}
```

### 병합

`PdfMerger` 클래스를 사용하여 2개 이상의 기존 PDF 파일을 병합할 수 있습니다:

```cs
var resultFileBytes = PdfMerger.Merge(filePath1, filePath2);
File.WriteAllBytes(@"C:\pdfs\outputfilename.pdf", resultFileBytes);
```
## Wiki
더 많은 예제와 API에 대한 자세한 안내는 [위키](https://github.com/UglyToad/PdfPig/wiki)를 확인하세요.

## Issues

버그가 발견되면 꼭 이슈를 등록해 주세요. 자세한 내용은 [이슈 정책](https://github.com/UglyToad/PdfPig/issues/1095)과 [기여 가이드](https://github.com/UglyToad/PdfPig/blob/master/CONTRIBUTING.md)를 참조하세요.

## API Reference

doxygen 문서를 생성하려면 `doxygen doxygen-docs` 명령을 실행한 후 `docs/doxygen/html/index.html`을 열어보세요.

## Credit

이 프로젝트는 [PDFBox](https://github.com/apache/pdfbox)를 C#으로 포팅하는 작업에서 시작되었습니다. 이 프로젝트는 [PDFBox](https://pdfbox.apache.org/) 팀과 아파치 재단의 작업 없이는 불가능했을 것입니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---