<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **（以前は iTextSharp として知られていました）** は、高性能で実績のあるライブラリであり、PDFドキュメントの作成、加工、検査、および保守を可能にし、ソフトウェアプロジェクトに簡単にPDF機能を追加できます。[Java 版](https://github.com/itext/itext7)も利用可能です。

### iText Core/Community の主な特徴：

* コアライブラリ:
    * レイアウトエンジンを使用したPDF作成
    * PDFの操作（例：複数のPDFを一つに結合、新しいコンテンツの追加 など）
    * PDFのデジタル署名
    * PDFフォームの作成と操作
    * PDF/Aドキュメントの取り扱い
    * PDF/UAドキュメントの取り扱い
    * FIPS準拠の暗号化
    * バーコード生成
    * SVGサポート
* [アドオン:][all products]
    * XML/HTML & CSS からPDFへの変換 [リポジトリ][pdfhtml], [詳細][pdfhtmlproduct]
    * PDFドキュメント内の機密情報の墨消し [リポジトリ][pdfsweep], [詳細][pdfsweepproduct]
    * 国際的な文字セット（例：アラビア語、中国語、ヘブライ語、タイ語等）サポート [詳細][calligraph]
    * PDFドキュメントの最適化（ファイルサイズの削減、高速化） [詳細][optimizer]
    * XFAドキュメントのフラット化 [詳細][xfa]
    * PDFデバッグ [リポジトリ][rups], [詳細][rupsproduct]

どんなことができるか知りたいですか？[Demo Lab](https://itextpdf.com/demos) をご覧ください！オンラインですぐに使えるデモアプリケーション集があります。

### はじめに

最も簡単な導入方法はNuGetの利用です。プロジェクトフォルダ内で以下のインストールコマンドを実行してください：

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

さらに高度な利用方法については、
[インストールガイド](https://kb.itextpdf.com/home/it7kb/installation-guidelines) をご参照ください。
[iText Community をソースからビルド][building]することも可能です。

### Hello PDF!

以下の例は、シンプルなPDFドキュメントを簡単に作成できることを示しています：

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

### サンプル

より高度なサンプルについては、[Knowledge Base](https://kb.itextpdf.com/home/it7kb/examples) や
メインの [サンプルリポジトリ](https://github.com/itext/i7ns-samples) をご参照ください。C# 版の
Java [署名サンプル](https://github.com/itext/i7js-signing-examples) の対応例は[こちら](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications) にあります。Javaコードも同じAPIのため非常に似ています。

一部の出力PDFファイルはGitHubのプレビュー機能では正しく表示されない場合があります。正しい結果を見るにはダウンロードしてご確認ください。

| 説明                                        | リンク                                                                                                                                                                                                                                                                                                   |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **基本レイアウト**                           |                                                                                                                                                                                                                                                                                                        |
| テキストプロパティの変更                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| シンプルなテーブルの作成                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| PDFドキュメントに画像を追加                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| リストの作成                                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| 透かしの追加                                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| 文書内での移動リンクを追加                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| ポップアップ注釈の作成                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| フォントの変更                               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| フォームフィールドの追加                     | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **文書の一般設定**                          |                                                                                                                                                                                                                                                                                                        |
| ページサイズと余白の変更                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| ディスクではなくバイト配列にPDFを書き込む     | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| ページ回転の変更                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| ヘッダーとフッターの追加                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| ドキュメントの結合                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| 注釈のフラット化                             | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| PDF/UAドキュメントの作成                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| PDF/A-3ドキュメントの作成                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| PDF/A-4ドキュメントの作成                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| WTPDFドキュメントの作成                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| ZUGFeRD/Factur-Xドキュメントの作成          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| FIPS有効化                                  | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| FIPS SHA3 例                               | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| SVGをPDFに変換                              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| レイアウトを使ってSVGをPDFに変換            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| 文字列としてのSVGをPDFに変換                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| SVGをPdfPageに変換                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| SVGをXObjectとして変換                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| pdfCalligraphを使ってSVGをPDFに変換         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **HTMLとCSSからPDFへの変換**                | [リポジトリへのリンク](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                           |
| シンプルなHTMLドキュメントをPDFに変換       | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **コンテンツの安全な墨消し**                | [リポジトリへのリンク](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                          |
| コンテンツの墨消し                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| 正規表現に基づく墨消し                      | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **複雑な書記体系のサポート**                | [ドキュメントへのリンク](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                  |
| アラビア語テキストの追加                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDFの最適化**                             | [ドキュメントへのリンク](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                      |
| PDFサイズの削減                             | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **XFAフラット化**                           | [ドキュメントへのリンク](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                             |
| XFAドキュメントのフラット化                 | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [リポジトリへのリンク](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                              |
| PDFのデバッグ                               | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### FAQ、チュートリアル等 ###

[iText Knowledge Base](https://kb.itextpdf.com) をご覧いただき、
[iText Jump-start チュートリアル](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) やその他
のチュートリアル、[FAQ](https://kb.itextpdf.com/home/it7kb/faq) などをご利用ください。電子署名とiTextに関する具体的な情報やサンプルについては
[Digital Signatures Hub](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub) も必ずご確認ください。

よくある質問の多くはすでに
[Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7) で回答されていますので、そちらもご確認ください。

### コントリビュートについて

**iText Core/Community** にはこれまで多くの方々からご貢献をいただいています。もしバグやドキュメントの誤り、新しい機能追加などがありましたら、ぜひご協力ください。

小さな変更や修正は [Pull Request](https://github.com/itext/itext7-dotnet/pulls) として送信できますが、
大きな変更の場合は、作業の重複を避けるため community@apryse.com までご連絡ください。

コード提出ルール等の詳細は [コントリビューションガイドライン][contributing] をご覧ください。

### ライセンス

**iText** は [AGPL][agpl]/[商用ソフトウェア][sales] のデュアルライセンスです。

AGPLはフリー／オープンソースソフトウェアライセンスですが、これはソフトウェアが[無料][gratis]という意味ではありません！

AGPLはコピーレフトライセンスであり、派生物も同じ条件でライセンスされる必要があります。iTextをAGPLの条件に従えないソフトウェアやサービスでご利用の場合は、そのような義務を免除する商用ライセンスもご用意しています。

詳細は [Sales] までお問い合わせください。

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