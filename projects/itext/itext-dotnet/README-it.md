<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![Licenza AGPL](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(precedentemente noto come iTextSharp)** è una libreria ad alte prestazioni, collaudata e affidabile che consente di creare, modificare,
ispezionare e mantenere documenti PDF, permettendo di aggiungere facilmente funzionalità PDF ai tuoi progetti software. È disponibile anche per [Java](https://github.com/itext/itext7).

### Le funzionalità principali di iText Core/Community sono:

* Libreria Core:
    * Creazione di PDF tramite il nostro motore di layout
    * Manipolazione PDF, ad esempio unione di più PDF in uno, aggiunta di nuovo contenuto, ...
    * Firma digitale PDF
    * Creazione e manipolazione di moduli PDF
    * Lavorare con documenti PDF/A
    * Lavorare con documenti PDF/UA
    * Crittografia conforme a FIPS
    * Generazione di codici a barre
    * Supporto SVG
* [Addons:][all products]
    * Conversione di XML/HTML & CSS in PDF [repo][pdfhtml], [info][pdfhtmlproduct]
    * Redazione di informazioni sensibili nei documenti PDF [repo][pdfsweep], [info][pdfsweepproduct]
    * Supporto per set di caratteri internazionali (es. arabo, cinese, ebraico, tailandese, ...) [info][calligraph]
    * Ottimizzazione dei documenti PDF per ridurre la dimensione del file e aumentare le prestazioni [info][optimizer]
    * Appiattimento di documenti XFA [info][xfa]
    * Debug dei PDF [repo][rups], [info][rupsproduct]

Vuoi scoprire cosa è possibile fare? Visita il nostro [Demo Lab](https://itextpdf.com/demos)! Contiene una raccolta di applicazioni demo pronte per l'uso online!

### Per iniziare

Il modo più semplice per iniziare è usare NuGet, basta eseguire il seguente comando di installazione nella cartella del tuo progetto:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

Per casi d'uso più avanzati, fai riferimento alle [linee guida per l'installazione](https://kb.itextpdf.com/home/it7kb/installation-guidelines).
Puoi anche [compilare iText Community dal sorgente][building].

### Hello PDF!

Il seguente esempio mostra quanto sia facile creare un semplice documento PDF:

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

### Esempi

Per esempi più avanzati, fai riferimento alla nostra [Knowledge Base](https://kb.itextpdf.com/home/it7kb/examples) o al
[repository principale degli esempi](https://github.com/itext/i7ns-samples). Puoi trovare gli equivalenti C# degli
esempi di firma Java [Signing examples](https://github.com/itext/i7js-signing-examples) [qui](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications),
anche se il codice Java è molto simile poiché utilizzano la stessa API.

Alcuni dei file PDF di output potrebbero essere visualizzati in modo errato dall'anteprima di GitHub, quindi assicurati di scaricarli per vedere i risultati corretti.

| Descrizione                                | Link                                                                                                                                                                                                                                                                                                   |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Layout di base**                         |                                                                                                                                                                                                                                                                                                        |
| Modifica delle proprietà del testo         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| Creazione di una tabella semplice          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| Aggiungere un'immagine a un documento PDF  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| Creare una lista                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| Aggiungere una filigrana                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| Aggiungere collegamenti per navigare nel documento | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| Creare un'annotazione popup                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| Modifica del font                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| Aggiungere campi modulo                    | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Impostazioni generali del documento**    |                                                                                                                                                                                                                                                                                                        |
| Modifica dimensione pagina e margine       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| Scrivere PDF in un array di byte invece che su disco | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| Modifica della rotazione pagina            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| Aggiungere intestazione e piè di pagina    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| Unire documenti                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| Appiattire annotazioni                     | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| Creare documento PDF/UA                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| Creare documento PDF/A-3                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| Creare documento PDF/A-4                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| Creare documento WTPDF                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| Creare documento ZUGFeRD/Factur-X          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| Abilitare FIPS                             | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| Esempio FIPS SHA3                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| Convertire SVG in PDF                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| Convertire SVG in PDF usando il layout     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| Convertire SVG come stringa in PDF         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| Convertire SVG in una PdfPage              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| Convertire SVG come XObject                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| Convertire SVG in PDF con pdfCalligraph    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Convertire HTML e CSS in PDF**           | [Link al repo](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                                   |
| Convertire un semplice documento HTML in PDF | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Redazione sicura del contenuto**         | [Link al repo](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                                  |
| Redazione del contenuto                    | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| Redazione basata su regex                  | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Supporto per sistemi di scrittura complessi** | [Link alla documentazione](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                 |
| Aggiungere testo arabo                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Ottimizzazione dei PDF**                 | [Link alla documentazione](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                        |
| Ridurre la dimensione del PDF              | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Appiattimento XFA**                      | [Link alla documentazione](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                             |
| Appiattire un documento XFA                | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [Link al repo](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                      |
| Debug di un PDF                            | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### FAQ, tutorial, ecc. ###

Consulta la [iText Knowledge Base](https://kb.itextpdf.com) per
il [tutorial iText Jump-start](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) e altri
tutorial, [FAQ](https://kb.itextpdf.com/home/it7kb/faq) e altro ancora. Per informazioni specifiche ed esempi relativi
alle firme digitali e iText, assicurati di consultare
il [Digital Signatures Hub](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub).

Molte domande comuni hanno già ricevuto risposta su [Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7), quindi assicurati di controllare anche lì.

### Contribuire

Molte persone hanno contribuito a **iText Core/Community** nel corso degli anni. Se hai trovato un bug, un errore nella documentazione o hai una nuova funzionalità da implementare, accogliamo con piacere i tuoi contributi.

Piccoli cambiamenti o correzioni possono essere inviati come [Pull Request](https://github.com/itext/itext7-dotnet/pulls), mentre per
modifiche importanti ti chiediamo di contattarci a community@apryse.com così da poter coordinare meglio i nostri sforzi ed evitare duplicazioni di lavoro.

Leggi le nostre [Linee guida per il contributo][contributing] per dettagli su invio del codice, regole di codifica e altro.

### Licenza

**iText** è distribuito con doppia licenza [AGPL][agpl]/[Software commerciale][sales].

AGPL è una licenza software libera/open-source, tuttavia, questo non significa che il software sia [gratis][gratis]!

La AGPL è una licenza copyleft, il che significa che ogni opera derivata deve essere anch'essa distribuita con la stessa licenza. Se stai usando iText in un software o servizio che non può rispettare i termini AGPL, è disponibile una licenza commerciale che ti esonera da tali obblighi.

Contatta [Sales] per maggiori informazioni.

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

[pdfhtml]: https://github.com/itext/itext-dotnet/develop/i7n-pdfhtml

[pdfsweep]: https://github.com/itext/itext-dotnet/develop/i7n-pdfsweep

[itext7net]: https://github.com/itext/itext7-dotnet
[pdfsweepproduct]: https://itextpdf.com/products/pdf-redaction-pdfsweep

[optimizer]: https://itextpdf.com/products/compress-pdf-pdfoptimizer

[tutti i prodotti]: https://itextpdf.com/products

[pdfhtmlproduct]: https://itextpdf.com/products/itext-pdf-html

[xfa]: https://itextpdf.com/products/flatten-pdf-pdfxfa

[rupsproduct]: https://itextpdf.com/products/rups

[calligraph]: https://itextpdf.com/products/pdfcalligraph

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---