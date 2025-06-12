<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(wcześniej znany jako iTextSharp)** to wydajna, sprawdzona biblioteka, która umożliwia tworzenie, modyfikowanie, przeglądanie i utrzymywanie dokumentów PDF, pozwalając na łatwe dodanie funkcjonalności PDF do Twoich projektów programistycznych. Biblioteka jest również dostępna dla [Java](https://github.com/itext/itext7).

### Kluczowe funkcje iText Core/Community:

* Główna biblioteka:
    * Tworzenie PDF z wykorzystaniem naszego silnika układu
    * Manipulacja PDF, np. łączenie wielu plików PDF w jeden, dodawanie nowej zawartości, ...
    * Cyfrowe podpisywanie PDF
    * Tworzenie i obsługa formularzy PDF
    * Praca z dokumentami PDF/A
    * Praca z dokumentami PDF/UA
    * Kryptografia zgodna z FIPS
    * Generowanie kodów kreskowych
    * Obsługa SVG
* [Dodatki:][all products]
    * Konwersja XML/HTML i CSS do PDF [repo][pdfhtml], [info][pdfhtmlproduct]
    * Redagowanie wrażliwych informacji w dokumentach PDF [repo][pdfsweep], [info][pdfsweepproduct]
    * Obsługa międzynarodowych zestawów znaków (np. arabski, chiński, hebrajski, tajski, ...) [info][calligraph]
    * Optymalizacja dokumentów PDF w celu zmniejszenia rozmiaru pliku i zwiększenia wydajności [info][optimizer]
    * Spłaszczanie dokumentów XFA [info][xfa]
    * Debugowanie PDF [repo][rups], [info][rupsproduct]

Chcesz odkryć możliwości? Zajrzyj do naszego [Demo Lab](https://itextpdf.com/demos)! Zawiera kolekcję
aplikacji demonstracyjnych gotowych do użycia online!

### Pierwsze kroki

Najłatwiejszym sposobem rozpoczęcia pracy jest użycie NuGet, wystarczy wykonać następujące polecenie instalacji w folderze Twojego projektu:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

W przypadku bardziej zaawansowanych zastosowań, zapoznaj się z [Wytycznymi instalacji](https://kb.itextpdf.com/home/it7kb/installation-guidelines).
Możesz również [zbudować iText Community ze źródeł][building].

### Hello PDF!

Poniższy przykład pokazuje, jak łatwo utworzyć prosty dokument PDF:

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

### Przykłady

Bardziej zaawansowane przykłady znajdziesz w naszej [Bazie Wiedzy](https://kb.itextpdf.com/home/it7kb/examples) lub w głównym [repozytorium z przykładami](https://github.com/itext/i7ns-samples). Odpowiedniki C# do przykładów Java [Podpisywanie](https://github.com/itext/i7js-signing-examples) znajdziesz [tutaj](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications), choć kod Java jest bardzo podobny, ponieważ korzysta z tego samego API.

Niektóre wyjściowe pliki PDF mogą być niepoprawnie wyświetlane przez podgląd na GitHub, więc pobierz je, aby zobaczyć poprawne rezultaty.

| Opis                                       | Link                                                                                                                                                                                                                                                                                                   |
|---------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Podstawowy układ**                        |                                                                                                                                                                                                                                                                                                        |
| Zmiana właściwości tekstu                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| Tworzenie prostej tabeli                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| Dodanie obrazu do dokumentu PDF             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| Tworzenie listy                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| Dodanie znaku wodnego                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| Dodanie linków nawigacyjnych w dokumencie   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| Tworzenie adnotacji typu popup              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| Zmiana czcionki                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| Dodanie pól formularza                      | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **Ustawienia dokumentu**                    |                                                                                                                                                                                                                                                                                                        |
| Zmiana rozmiaru strony i marginesów         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| Zapis PDF do tablicy bajtów zamiast na dysk | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| Zmiana rotacji strony                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| Dodanie nagłówka i stopki                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| Scalanie dokumentów                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| Spłaszczanie adnotacji                      | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                           |                                                                                                                                                                                                                                                                                                        |
| Tworzenie dokumentu PDF/UA                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| Tworzenie dokumentu PDF/A-3                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| Tworzenie dokumentu PDF/A-4                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| Tworzenie dokumentu WTPDF                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| Tworzenie dokumentu ZUGFeRD/Factur-X        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                    |                                                                                                                                                                                                                                                                                                        |
| Włączenie FIPS                              | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| Przykład FIPS SHA3                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                     |                                                                                                                                                                                                                                                                                                        |
| Konwersja SVG do PDF                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| Konwersja SVG do PDF z układem              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| Konwersja SVG jako string do PDF            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| Konwersja SVG do PdfPage                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| Konwersja SVG jako XObject                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| Konwersja SVG do PDF z pdfCalligraph        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **Konwersja HTML i CSS do PDF**             | [Link do repozytorium](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                           |
| Konwersja prostego dokumentu HTML do PDF    | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **Bezpieczne redagowanie treści**           | [Link do repozytorium](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                          |
| Redagowanie treści                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| Redagowanie na podstawie regex              | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **Obsługa złożonych systemów pisma**        | [Link do dokumentacji](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                    |
| Dodanie tekstu arabskiego                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **Optymalizacja PDF**                       | [Link do dokumentacji](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                        |
| Zmniejszenie rozmiaru pliku PDF             | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **Spłaszczanie XFA**                        | [Link do dokumentacji](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                               |
| Spłaszczanie dokumentu XFA                  | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                        |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                    | [Link do repozytorium](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                              |
| Debugowanie PDF                             | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### FAQ, samouczki, itd. ###

Zajrzyj do [Bazy Wiedzy iText](https://kb.itextpdf.com) po [samouczek iText Jump-start](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) i inne samouczki, [FAQ](https://kb.itextpdf.com/home/it7kb/faq) i więcej. Po szczegółowe informacje i przykłady dotyczące podpisów cyfrowych i iText, koniecznie sprawdź [Digital Signatures Hub](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub).

Wiele typowych pytań zostało już omówionych na [Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7), więc koniecznie sprawdź także tam.

### Współtworzenie

Wiele osób przyczyniło się do rozwoju **iText Core/Community** na przestrzeni lat. Jeśli znalazłeś błąd, pomyłkę w dokumentacji lub masz nową funkcję do wdrożenia, zapraszamy do współpracy.

Drobne zmiany lub poprawki możesz zgłosić jako [Pull Request](https://github.com/itext/itext7-dotnet/pulls), natomiast w przypadku większych zmian prosimy o kontakt pod adresem community@apryse.com, abyśmy mogli lepiej skoordynować działania i uniknąć dublowania prac.

Przeczytaj nasze [Wytyczne dotyczące współtworzenia][contributing], aby poznać szczegóły dotyczące zgłaszania kodu, zasad kodowania i innych kwestii.

### Licencjonowanie

**iText** jest dostępny na podwójnej licencji jako [AGPL][agpl]/[oprogramowanie komercyjne][sales].

AGPL to licencja wolnego/otwartego oprogramowania, jednak nie oznacza to, że oprogramowanie jest [gratis][gratis]!

AGPL to licencja typu copyleft, co oznacza, że każde dzieło pochodne musi być licencjonowane na tych samych warunkach. Jeśli używasz iText w oprogramowaniu lub usłudze, która nie może spełnić warunków AGPL, mamy dostępną licencję komercyjną, która zwalnia z tych obowiązków.

Skontaktuj się z [Działem Sprzedaży], aby uzyskać więcej informacji.

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