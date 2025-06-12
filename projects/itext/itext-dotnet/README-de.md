<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(früher bekannt als iTextSharp)** ist eine leistungsstarke, praxiserprobte Bibliothek, die es Ihnen ermöglicht,
PDF-Dokumente zu erstellen, anzupassen,
zu inspizieren und zu verwalten, wodurch Sie Ihrer Softwareprojekte mühelos mit PDF-
Funktionalität ausstatten können. Sie ist auch für [Java](https://github.com/itext/itext7) verfügbar.

### Die wichtigsten Funktionen von iText Core/Community sind:

* Kernbibliothek:
    * PDF-Erstellung mit Hilfe unserer Layout-Engine
    * PDF-Bearbeitung, z. B. das Zusammenführen mehrerer PDFs zu einem, Hinzufügen neuer Inhalte, ...
    * Digitale Signatur von PDFs
    * Erstellung und Bearbeitung von PDF-Formularen
    * Arbeiten mit PDF/A-Dokumenten
    * Arbeiten mit PDF/UA-Dokumenten
    * FIPS-konforme Kryptografie
    * Barcode-Erstellung
    * SVG-Unterstützung
* [Addons:][all products]
    * Konvertieren von XML/HTML & CSS zu PDF [Repo][pdfhtml], [Info][pdfhtmlproduct]
    * Schwärzen sensibler Informationen in PDF-Dokumenten [Repo][pdfsweep], [Info][pdfsweepproduct]
    * Unterstützung internationaler Zeichensätze (z. B. Arabisch, Chinesisch, Hebräisch, Thailändisch, ...) [Info][calligraph]
    * Optimierung von PDF-Dokumenten für geringere Dateigröße und höhere Performance [Info][optimizer]
    * XFA-Dokumente glätten [Info][xfa]
    * PDF-Debugging [Repo][rups], [Info][rupsproduct]

Sie möchten herausfinden, was möglich ist? Besuchen Sie unser [Demo Lab](https://itextpdf.com/demos)! Es enthält eine Sammlung von
Demo-Anwendungen, die Sie direkt online nutzen können!

### Erste Schritte

Der einfachste Weg, um loszulegen, ist die Verwendung von NuGet. Führen Sie einfach folgenden Installationsbefehl im Verzeichnis Ihres
Projekts aus:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

Für fortgeschrittene Anwendungsfälle beachten Sie bitte
die [Installationsanleitung](https://kb.itextpdf.com/home/it7kb/installation-guidelines).
Sie können iText Community auch [aus dem Quellcode bauen][building].

### Hello PDF!

Das folgende Beispiel zeigt, wie einfach es ist, ein einfaches PDF-Dokument zu erstellen:

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

### Beispiele

Für fortgeschrittene Beispiele schauen Sie in unsere [Knowledge Base](https://kb.itextpdf.com/home/it7kb/examples) oder das
Haupt-[Beispiel-Repository](https://github.com/itext/i7ns-samples). C#-Äquivalente zu den
Java-[Signaturbeispielen](https://github.com/itext/i7js-signing-examples) finden Sie [hier](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications),
obwohl der Java-Code sehr ähnlich ist, da beide APIs gleich sind.

Einige der erzeugten PDF-Dateien werden vom GitHub-Previewer nicht korrekt angezeigt, laden Sie sie daher herunter, um das korrekte
Ergebnis zu sehen.

| Beschreibung                               | Link                                                                                                                                                                                                                                                                                                   |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Grundlegendes Layout**                   |                                                                                                                                                                                                                                                                                                        |
| Text-Eigenschaften ändern                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| Einfache Tabelle erstellen                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| Ein Bild zu einem PDF-Dokument hinzufügen  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| Eine Liste erstellen                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| Ein Wasserzeichen hinzufügen               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| Links zum Navigieren innerhalb eines Dokuments hinzufügen | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| Popup-Anmerkung erstellen                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| Schriftart ändern                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| Formularfelder hinzufügen                  | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Allgemeine Dokumenteinstellungen**       |                                                                                                                                                                                                                                                                                                        |
| Seitengröße und Rand ändern                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| PDF in Byte-Array statt auf Festplatte schreiben | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| Seitenrotation ändern                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| Kopf- und Fußzeile hinzufügen              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| Dokumente zusammenführen                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| Anmerkungen glätten                        | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| PDF/UA-Dokument erstellen                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| PDF/A-3-Dokument erstellen                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| PDF/A-4-Dokument erstellen                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| WTPDF-Dokument erstellen                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| ZUGFeRD/Factur-X-Dokument erstellen        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| FIPS aktivieren                            | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| FIPS SHA3  Beispiel                        | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| SVG in PDF umwandeln                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| SVG in PDF mit Layout umwandeln            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| SVG als String zu PDF umwandeln            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| SVG in PdfPage umwandeln                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| SVG als XObject umwandeln                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| SVG in PDF mit pdfCalligraph umwandeln     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **HTML und CSS in PDF umwandeln**          | [Link zum Repo](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                                  |
| Einfaches HTML-Dokument zu PDF konvertieren| [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Sichere Schwärzung von Inhalten**        | [Link zum Repo](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                                 |
| Inhalt schwärzen                           | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| Schwärzen auf Basis von Regex              | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Unterstützung komplexer Schriftsysteme** | [Link zu den Docs](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                         |
| Arabischen Text hinzufügen                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDFs optimieren**                        | [Link zu den Docs](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                            |
| PDF-Größe reduzieren                       | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **XFA-Glättung**                           | [Link zu den Docs](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                   |
| Ein XFA-Dokument glätten                   | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [Link zum Repo](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                     |
| PDF debuggen                               | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### FAQs, Tutorials usw. ###

Schauen Sie in die [iText Knowledge Base](https://kb.itextpdf.com) für
das [iText Jump-start Tutorial](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) und andere
Tutorials, [FAQs](https://kb.itextpdf.com/home/it7kb/faq) und mehr. Für spezielle Informationen und Beispiele zu
digitalen Signaturen und iText besuchen Sie unbedingt
das [Digital Signatures Hub](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub).

Viele häufige Fragen wurden bereits
auf [Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7) beantwortet – schauen Sie auch dort vorbei.

### Beitrag leisten

Viele Menschen haben im Laufe der Jahre zu **iText Core/Community** beigetragen. Wenn Sie einen Fehler gefunden, einen
Dokumentationsfehler entdeckt oder ein neues Feature implementieren möchten, sind Ihre Beiträge willkommen.

Kleine Änderungen oder Korrekturen können Sie als [Pull Request](https://github.com/itext/itext7-dotnet/pulls) einreichen. Bei
größeren Änderungen bitten wir Sie, uns unter community@apryse.com zu kontaktieren, damit wir unsere Bemühungen besser koordinieren und
Doppelarbeit vermeiden können.

Bitte lesen Sie unsere [Beitragsrichtlinien][contributing] für Details zu Code-Einreichungen, Codierungsregeln und mehr.

### Lizenzierung

**iText** ist dual lizenziert als [AGPL][agpl]/[kommerzielle Software][sales].

Die AGPL ist eine freie/Open-Source-Softwarelizenz, das bedeutet jedoch nicht, dass die Software [gratis][gratis] ist!

Die AGPL ist eine Copyleft-Lizenz, das heißt, jede abgeleitete Arbeit muss ebenfalls unter denselben Bedingungen lizenziert werden. Wenn
Sie iText in Software oder einem Dienst verwenden, der nicht mit den AGPL-Bedingungen vereinbar ist, bieten wir eine kommerzielle Lizenz
an, die Sie von diesen Verpflichtungen befreit.

Kontaktieren Sie [Sales] für weitere Informationen.

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