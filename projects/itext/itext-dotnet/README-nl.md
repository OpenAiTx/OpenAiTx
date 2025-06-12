<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(voorheen bekend als iTextSharp)** is een krachtige, bewezen bibliotheek die u in staat stelt om PDF-documenten te creëren, aan te passen, te inspecteren en te onderhouden, waardoor u eenvoudig PDF-functionaliteit aan uw softwareprojecten kunt toevoegen. Het is ook beschikbaar voor [Java](https://github.com/itext/itext7).

### De belangrijkste kenmerken van iText Core/Community zijn:

* Kernbibliotheek:
    * PDF-creatie met behulp van onze layout-engine
    * PDF-manipulatie, zoals het samenvoegen van meerdere PDF's tot één, nieuwe inhoud toevoegen, ...
    * Digitale ondertekening van PDF's
    * Aanmaak en bewerking van PDF-formulieren
    * Werken met PDF/A-documenten
    * Werken met PDF/UA-documenten
    * FIPS-conforme cryptografie
    * Barcode-generatie
    * SVG-ondersteuning
* [Add-ons:][all products]
    * Converteren van XML/HTML & CSS naar PDF [repo][pdfhtml], [info][pdfhtmlproduct]
    * Redactie van gevoelige informatie in PDF-documenten [repo][pdfsweep], [info][pdfsweepproduct]
    * Ondersteuning voor internationale tekensets (bijv. Arabisch, Chinees, Hebreeuws, Thais, ...) [info][calligraph]
    * Optimaliseren van PDF-documenten voor kleinere bestandsgrootte en betere prestaties [info][optimizer]
    * Flattenen van XFA-documenten [info][xfa]
    * PDF-debugging [repo][rups], [info][rupsproduct]

Wilt u ontdekken wat er mogelijk is? Bezoek ons [Demo Lab](https://itextpdf.com/demos)! Het bevat een verzameling demo-applicaties die online klaar voor gebruik zijn!

### Aan de slag

De eenvoudigste manier om te beginnen is via NuGet. Voer simpelweg het volgende installatiecommando uit in de map van uw project:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

Voor meer geavanceerde toepassingen, raadpleeg
de [Installatierichtlijnen](https://kb.itextpdf.com/home/it7kb/installation-guidelines).
U kunt iText Community ook [bouwen vanuit de broncode][building].

### Hello PDF!

Het volgende voorbeeld laat zien hoe eenvoudig het is om een simpel PDF-document te maken:

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

### Voorbeelden

Voor meer geavanceerde voorbeelden, raadpleeg onze [Knowledge Base](https://kb.itextpdf.com/home/it7kb/examples) of de
hoofd [Examples repo](https://github.com/itext/i7ns-samples). U vindt C#-equivalenten van de
Java [Signing voorbeelden](https://github.com/itext/i7js-signing-examples) [hier](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications),
hoewel de Java-code erg vergelijkbaar is omdat ze dezelfde API hebben.

Sommige van de gegenereerde PDF-bestanden worden mogelijk niet correct weergegeven door de GitHub-previewfunctie, dus download ze om het juiste resultaat te zien.

| Beschrijving                                | Link                                                                                                                                                                                                                                                                                                   |
|---------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Basis lay-out**                           |                                                                                                                                                                                                                                                                                                        |
| Teksteigenschappen wijzigen                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| Een eenvoudige tabel maken                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| Een afbeelding toevoegen aan een PDF        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| Een lijst maken                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| Watermerk toevoegen                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| Links toevoegen voor navigatie in document  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| Pop-up annotatie maken                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| Lettertype wijzigen                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| Formuliervelden toevoegen                   | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                         |                                                                                                                                                                                                                                                                                                        |
| **Algemene documentinstellingen**           |                                                                                                                                                                                                                                                                                                        |
| Paginagrootte en marges wijzigen            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| PDF naar byte-array schrijven i.p.v. naar schijf | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| Paginarotatie wijzigen                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| Kop- en voettekst toevoegen                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| Documenten samenvoegen                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| Annotaties flattenen                        | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                           |                                                                                                                                                                                                                                                                                                        |
| PDF/UA-document maken                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| PDF/A-3-document maken                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| PDF/A-4-document maken                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| WTPDF-document maken                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| ZUGFeRD/Factur-X-document maken             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                    |                                                                                                                                                                                                                                                                                                        |
| FIPS inschakelen                            | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| FIPS SHA3 voorbeeld                         | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                     |                                                                                                                                                                                                                                                                                                        |
| SVG omzetten naar PDF                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| SVG omzetten naar PDF met layout            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| SVG als string omzetten naar PDF            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| SVG omzetten naar een PdfPage               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| SVG als XObject omzetten                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| SVG omzetten naar PDF met pdfCalligraph     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **HTML en CSS omzetten naar PDF**           | [Link naar repo](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                                |
| Eenvoudig HTML-document omzetten naar PDF   | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **Veilige redactie van inhoud**             | [Link naar repo](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                                |
| Inhoud redigeren                            | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| Redigeren op basis van regex                | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **Ondersteuning voor complexe schriftsystemen** | [Link naar docs](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                          |
| Arabische tekst toevoegen                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **PDF's optimaliseren**                     | [Link naar docs](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                              |
| PDF-grootte verkleinen                      | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **XFA flattening**                          | [Link naar docs](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                     |
| XFA-document flattenen                      | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                    | [Link naar repo](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                    |
| PDF debuggen                                | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### FAQ's, tutorials, enz. ###

Bekijk de [iText Knowledge Base](https://kb.itextpdf.com) voor de [iText Jump-start tutorial](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) en andere
tutorials, [FAQ's](https://kb.itextpdf.com/home/it7kb/faq) en meer. Voor specifieke informatie en voorbeelden met betrekking tot
digitale handtekeningen en iText, bekijk zeker
de [Digital Signatures Hub](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub).

Veelgestelde vragen zijn al beantwoord op [Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7), dus kijk daar zeker ook even.

### Bijdragen

Veel mensen hebben door de jaren heen bijgedragen aan **iText Core/Community**. Als u een bug heeft gevonden, een fout in de documentatie, of een gloednieuwe functie wilt toevoegen, verwelkomen wij uw bijdrage.

Kleine wijzigingen of fixes kunnen worden ingediend als een [Pull Request](https://github.com/itext/itext7-dotnet/pulls). Voor grotere wijzigingen verzoeken wij u contact met ons op te nemen via community@apryse.com, zodat we onze inspanningen beter kunnen coördineren en dubbel werk kunnen voorkomen.

Lees onze [Bijdrage-richtlijnen][contributing] voor details over code-indiening, coderingsregels en meer.

### Licenties

**iText** heeft een duale licentie als [AGPL][agpl]/[Commerciële software][sales].

AGPL is een vrije/open-source softwarelicentie, maar dit betekent niet dat de software [gratis][gratis] is!

De AGPL is een copyleft-licentie, wat betekent dat elk afgeleid werk ook onder dezelfde voorwaarden gelicenseerd moet worden. Als u iText gebruikt in software of een dienst die niet kan voldoen aan de AGPL-voorwaarden, bieden wij een commerciële licentie die u van deze verplichtingen vrijstelt.

Neem contact op met [Sales] voor meer informatie.

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