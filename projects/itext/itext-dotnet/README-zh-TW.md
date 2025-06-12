<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **（前稱 iTextSharp）** 是一個高效能、經過實戰驗證的函式庫，可讓您建立、調整、檢查和維護 PDF 文件，輕鬆為您的軟體專案加入 PDF 功能。此函式庫亦可用於 [Java](https://github.com/itext/itext7)。

### iText Core/Community 的主要特點包括：

* 核心函式庫：
    * 利用我們的版面引擎建立 PDF
    * PDF 操作，如合併多個 PDF 為一、添加新內容等
    * PDF 數位簽章
    * PDF 表單建立與操作
    * 處理 PDF/A 文件
    * 處理 PDF/UA 文件
    * 支援 FIPS 標準的加密
    * 條碼產生
    * SVG 支援
* [附加元件：][all products]
    * 將 XML/HTML & CSS 轉換為 PDF [repo][pdfhtml], [info][pdfhtmlproduct]
    * 在 PDF 文件中遮蔽敏感資訊 [repo][pdfsweep], [info][pdfsweepproduct]
    * 支援國際字元集（如阿拉伯文、中文、希伯來文、泰文等） [info][calligraph]
    * 最佳化 PDF 文件以減少檔案大小及提升效能 [info][optimizer]
    * XFA 文件扁平化 [info][xfa]
    * PDF 除錯 [repo][rups], [info][rupsproduct]

想探索更多可能性？歡迎造訪我們的 [Demo Lab](https://itextpdf.com/demos)！這裡收錄了可線上使用的各種示範應用程式！

### 快速開始

最簡單的入門方式是使用 NuGet，只需在您的專案資料夾中執行以下安裝指令：

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

如需進階用法，請參閱
[安裝指南](https://kb.itextpdf.com/home/it7kb/installation-guidelines)。
您也可以[從原始碼建置 iText Community][building]。

### Hello PDF!

下例展示了如何輕鬆建立一個簡單的 PDF 文件：

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

### 範例

如需更多進階範例，請參閱我們的 [知識庫](https://kb.itextpdf.com/home/it7kb/examples) 或主 [範例程式庫](https://github.com/itext/i7ns-samples)。您可以在這裡找到 C# 與 Java [簽章範例](https://github.com/itext/i7js-signing-examples) 的對應版本：[這裡](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications)，兩者的 API 非常類似。

部分輸出的 PDF 檔案在 GitHub 預覽中可能顯示不正確，請下載後再檢視正確結果。

| 描述                                      | 連結                                                                                                                                                                                                                                                                                                   |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **基本版面**                               |                                                                                                                                                                                                                                                                                                        |
| 更改文字屬性                               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| 建立簡單表格                               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| 為 PDF 文件加入圖片                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| 建立清單                                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| 加入浮水印                                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| 加入文件內導覽連結                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| 建立彈出式註解                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| 更換字型                                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| 加入表單欄位                               | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **一般文件設定**                           |                                                                                                                                                                                                                                                                                                        |
| 更改頁面大小與邊界                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| 將 PDF 輸出至位元組陣列而非磁碟           | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| 更改頁面旋轉                               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| 加入頁首與頁尾                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| 合併文件                                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| 註解扁平化                                 | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| 建立 PDF/UA 文件                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| 建立 PDF/A-3 文件                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| 建立 PDF/A-4 文件                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| 建立 WTPDF 文件                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| 建立 ZUGFeRD/Factur-X 文件                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| 啟用 FIPS                                  | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| FIPS SHA3 範例                             | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| 將 SVG 轉換為 PDF                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| 以版面方式將 SVG 轉換為 PDF                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| 將 SVG 字串轉換為 PDF                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| 將 SVG 轉為 PdfPage                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| 將 SVG 轉為 XObject                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| 使用 pdfCalligraph 將 SVG 轉為 PDF         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **HTML 與 CSS 轉 PDF**                     | [原始碼連結](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                                   |
| 將簡單 HTML 文件轉為 PDF                   | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **安全遮蔽內容**                           | [原始碼連結](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                                  |
| 遮蔽內容                                   | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| 依正則表達式遮蔽                           | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **支援複雜書寫系統**                       | [文件連結](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                            |
| 加入阿拉伯文                               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF 最佳化**                             | [文件連結](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                |
| 減少 PDF 檔案大小                          | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **XFA 扁平化**                             | [文件連結](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                       |
| XFA 文件扁平化                             | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [原始碼連結](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                      |
| 除錯 PDF                                   | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### 常見問題、教學等

請參閱 [iText 知識庫](https://kb.itextpdf.com) 以獲取
[iText 快速入門教學](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) 及其他教學、[常見問題集](https://kb.itextpdf.com/home/it7kb/faq) 等。關於數位簽章及 iText 的專門資訊與範例，請務必參閱
[數位簽章專區](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub)。

許多常見問題已在 [Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7) 被解答，請一併查閱。

### 貢獻

多年來有許多人為 **iText Core/Community** 做出貢獻。如果您發現錯誤、文件內容有誤，或想新增新功能，非常歡迎您貢獻。

小幅更動或修正可以提交 [Pull Request](https://github.com/itext/itext7-dotnet/pulls)；若是重大變更，請先聯絡 community@apryse.com，以便協調並避免重工。

請詳閱我們的[貢獻指南][contributing]，了解程式碼提交、編碼規範等細節。

### 授權

**iText** 採用 [AGPL][agpl]/[商業軟體][sales] 雙重授權。

AGPL 是一個自由/開放原始碼授權，但這並不代表軟體是[免費][gratis]的！

AGPL 是一種 copyleft 授權，代表所有衍生作品也必須使用相同條款授權。如果您的軟體或服務無法符合 AGPL 規範，我們亦提供可免除此義務的商業授權。

如需更多資訊，請聯絡 [Sales]。

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