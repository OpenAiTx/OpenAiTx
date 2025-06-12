<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(이전 명칭: iTextSharp)**는 고성능, 검증된 라이브러리로, PDF 문서를 생성, 수정, 검사 및 유지보수할 수 있게 하여 소프트웨어 프로젝트에 손쉽게 PDF 기능을 추가할 수 있도록 합니다. 또한 [Java](https://github.com/itext/itext7)용으로도 제공됩니다.

### iText Core/Community의 주요 특징:

* 코어 라이브러리:
    * 레이아웃 엔진을 사용한 PDF 생성
    * PDF 조작, 예: 여러 PDF를 하나로 병합, 신규 콘텐츠 추가 등
    * PDF 디지털 서명
    * PDF 폼 생성 및 조작
    * PDF/A 문서 작업
    * PDF/UA 문서 작업
    * FIPS-준수 암호화
    * 바코드 생성
    * SVG 지원
* [애드온:][all products]
    * XML/HTML & CSS를 PDF로 변환 [repo][pdfhtml], [info][pdfhtmlproduct]
    * PDF 문서 내 민감한 정보 마스킹 [repo][pdfsweep], [info][pdfsweepproduct]
    * 국제 문자셋 지원 (예: 아랍어, 중국어, 히브리어, 태국어 등) [info][calligraph]
    * PDF 문서 최적화(파일 크기 축소, 성능 향상) [info][optimizer]
    * XFA 문서 평탄화 [info][xfa]
    * PDF 디버깅 [repo][rups], [info][rupsproduct]

무엇이 가능한지 궁금하다면 [Demo Lab](https://itextpdf.com/demos)에서 온라인으로 바로 사용할 수 있는 다양한 데모 애플리케이션을 확인해보세요!

### 시작하기

가장 쉬운 시작 방법은 NuGet을 사용하는 것입니다. 프로젝트 폴더에서 다음 설치 명령을 실행하세요:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

더 고급 사용 사례는 [설치 가이드](https://kb.itextpdf.com/home/it7kb/installation-guidelines)를 참조하세요.
또한 [소스에서 iText Community 빌드][building]도 가능합니다.

### Hello PDF!

다음 예시는 간단한 PDF 문서를 얼마나 쉽게 생성할 수 있는지 보여줍니다:

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

### 예제

더 많은 고급 예제는 [Knowledge Base](https://kb.itextpdf.com/home/it7kb/examples)나
주요 [예제 저장소](https://github.com/itext/i7ns-samples)를 참조하세요. 
Java [서명 예제](https://github.com/itext/i7js-signing-examples)의 C# 버전은 [여기](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications)에서 찾을 수 있으며, Java와 C# 모두 동일한 API를 사용하므로 코드가 매우 유사합니다.

일부 출력 PDF 파일은 GitHub 미리보기에서 올바르게 표시되지 않을 수 있으니, 정확한 결과를 확인하려면 다운로드해보세요.

| 설명                                       | 링크                                                                                                                                                                                                                                                                                                   |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **기본 레이아웃**                           |                                                                                                                                                                                                                                                                                                        |
| 텍스트 속성 변경                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| 간단한 테이블 생성                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| PDF 문서에 이미지 추가                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| 리스트 생성                                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |
| 워터마크 추가                               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| 문서 내 네비게이션 링크 추가                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| 팝업 주석 생성                              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| 폰트 변경                                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| 폼 필드 추가                                | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **일반 문서 설정**                          |                                                                                                                                                                                                                                                                                                        |
| 페이지 크기 및 마진 변경                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| PDF를 디스크 대신 바이트 배열로 쓰기         | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| 페이지 회전 변경                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| 헤더 및 푸터 추가                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| 문서 병합                                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| 주석 평탄화                                 | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| PDF/UA 문서 생성                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| PDF/A-3 문서 생성                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| PDF/A-4 문서 생성                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| WTPDF 문서 생성                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| ZUGFeRD/Factur-X 문서 생성                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| FIPS 활성화                                 | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| FIPS SHA3 예제                              | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| SVG를 PDF로 변환                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| 레이아웃을 사용하여 SVG를 PDF로 변환         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| 문자열 형태의 SVG를 PDF로 변환               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| SVG를 PdfPage로 변환                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| SVG를 XObject로 변환                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| pdfCalligraph를 사용하여 SVG를 PDF로 변환    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **HTML 및 CSS를 PDF로 변환**                | [리포지토리 링크](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                               |
| 간단한 HTML 문서를 PDF로 변환               | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **콘텐츠 보안 마스킹**                      | [리포지토리 링크](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                              |
| 콘텐츠 마스킹                               | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| 정규식을 이용한 마스킹                      | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **복잡한 문자 시스템 지원**                 | [문서 링크](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                              |
| 아랍어 텍스트 추가                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF 최적화**                              | [문서 링크](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                  |
| PDF 파일 크기 축소                          | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **XFA 평탄화**                              | [문서 링크](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                         |
| XFA 문서 평탄화                             | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [리포지토리 링크](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                  |
| PDF 디버깅                                  | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### FAQ, 튜토리얼 등 ###

[iText Knowledge Base](https://kb.itextpdf.com)에서
[iText 점프스타트 튜토리얼](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) 및 기타
튜토리얼, [FAQ](https://kb.itextpdf.com/home/it7kb/faq) 등을 확인할 수 있습니다. 디지털 서명 및 iText 관련 정보와 예제는
[Digital Signatures Hub](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub)를 참고하세요.

많은 일반적인 질문은 이미
[Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7)에 답변되어 있으니, 이곳도 꼭 확인하세요.

### 기여하기

수년간 많은 분들이 **iText Core/Community**에 기여해왔습니다. 버그 발견, 문서 오류, 혹은 새 기능 제안이 있다면 언제든 기여를 환영합니다.

작은 수정이나 버그 픽스는 [Pull Request](https://github.com/itext/itext7-dotnet/pulls)로 제출하실 수 있으며,
주요 변경 사항의 경우 community@apryse.com으로 연락해 협업과 중복 작업 방지를 도와주세요.

코드 제출, 코딩 규칙 등 자세한 내용은 [기여 가이드라인][contributing]을 읽어주세요.

### 라이선스

**iText**는 [AGPL][agpl]/[상업용 소프트웨어][sales] 이중 라이선스로 제공됩니다.

AGPL은 자유/오픈소스 소프트웨어 라이선스이지만, 이것이 [무료][gratis]라는 의미는 아닙니다!

AGPL은 카피레프트 라이선스로, 파생 저작물 역시 동일한 라이선스 조건을 따라야 합니다. 만약 AGPL 조건을 준수할 수 없는 소프트웨어 또는 서비스에서 iText를 사용하려면, 이러한 의무에서 면제되는 상업용 라이선스를 제공합니다.

자세한 내용은 [Sales]에 문의하세요.

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