<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(ранее известная как iTextSharp)** — это высокопроизводительная, проверенная временем библиотека, которая позволяет создавать, изменять, просматривать и поддерживать PDF-документы, легко добавляя функциональность PDF в ваши программные проекты. Она также доступна для [Java](https://github.com/itext/itext7).

### Ключевые возможности iText Core/Community:

* Основная библиотека:
    * Создание PDF с использованием нашего движка разметки
    * Манипулирование PDF, например, объединение нескольких PDF в один, добавление нового контента и др.
    * Цифровая подпись PDF
    * Создание и изменение PDF-форм
    * Работа с документами PDF/A
    * Работа с документами PDF/UA
    * Криптография, соответствующая стандарту FIPS
    * Генерация штрих-кодов
    * Поддержка SVG
* [Дополнения:][all products]
    * Конвертация XML/HTML & CSS в PDF [репозиторий][pdfhtml], [информация][pdfhtmlproduct]
    * Сокрытие конфиденциальной информации в PDF-документах [репозиторий][pdfsweep], [информация][pdfsweepproduct]
    * Поддержка международных наборов символов (например, арабский, китайский, иврит, тайский, ...) [информация][calligraph]
    * Оптимизация PDF-документов для уменьшения размера файла и повышения производительности [информация][optimizer]
    * Преобразование XFA-документов в статическую форму [информация][xfa]
    * Отладка PDF [репозиторий][rups], [информация][rupsproduct]

Хотите узнать, на что способна библиотека? Загляните в наш [Demo Lab](https://itextpdf.com/demos)! Здесь собрана коллекция демонстрационных приложений, готовых к использованию онлайн!

### Начало работы

Самый простой способ начать — использовать NuGet, просто выполните следующую команду установки в папке вашего проекта:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

Для более сложных сценариев использования ознакомьтесь с [Руководством по установке](https://kb.itextpdf.com/home/it7kb/installation-guidelines).
Вы также можете [собрать iText Community из исходников][building].

### Hello PDF!

Следующий пример демонстрирует, как просто создать простой PDF-документ:

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

### Примеры

Для более сложных примеров обратитесь к нашей [Базе знаний](https://kb.itextpdf.com/home/it7kb/examples) или к основному [репозиторию с примерами](https://github.com/itext/i7ns-samples). Вы найдете C#-аналоги к
Java [примерам подписания](https://github.com/itext/i7js-signing-examples) [здесь](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications),
хотя код на Java очень похож, так как используется тот же API.

Некоторые PDF-файлы результатов могут отображаться некорректно в предпросмотре GitHub, поэтому обязательно скачайте их для корректного просмотра.

| Описание                                   | Ссылка                                                                                                                                                                                                                                                                                                 |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Базовая разметка**                       |                                                                                                                                                                                                                                                                                                        |
| Изменение свойств текста                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| Создание простой таблицы                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| Добавление изображения в PDF-документ      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| Создание списка                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| Добавление водяного знака                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| Добавление ссылок для навигации по документу | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| Создание всплывающей аннотации             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| Изменение шрифта                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| Добавление полей формы                     | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Общие настройки документа**               |                                                                                                                                                                                                                                                                                                        |
| Изменение размера страницы и отступов       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| Запись PDF в массив байт вместо файла       | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| Изменение поворота страницы                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| Добавление колонтитулов                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| Объединение документов                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| Сведение аннотаций                         | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| Создание документа PDF/UA                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| Создание документа PDF/A-3                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| Создание документа PDF/A-4                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| Создание документа WTPDF                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| Создание документа ZUGFeRD/Factur-X        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| Включить FIPS                              | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| Пример FIPS SHA3                           | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| Конвертация SVG в PDF                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| Конвертация SVG в PDF с использованием layout | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| Конвертация SVG-строки в PDF               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| Конвертация SVG в PdfPage                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| Конвертация SVG как XObject                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| Конвертация SVG в PDF с помощью pdfCalligraph | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Конвертация HTML и CSS в PDF**           | [Ссылка на репозиторий](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                         |
| Конвертация простого HTML-документа в PDF  | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Безопасное сокрытие содержимого**        | [Ссылка на репозиторий](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                        |
| Сокрытие содержимого                       | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| Сокрытие по регулярному выражению          | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Поддержка сложных систем письма**        | [Ссылка на документацию](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                  |
| Добавление арабского текста                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Оптимизация PDF**                        | [Ссылка на документацию](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                      |
| Уменьшение размера PDF                     | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Сведение XFA**                           | [Ссылка на документацию](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                             |
| Сведение XFA-документа                     | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [Ссылка на репозиторий](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                            |
| Отладка PDF                                | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### FAQ, обучающие материалы и другое ###

Посетите [Базу знаний iText](https://kb.itextpdf.com) для
[Обучающего руководства по запуску iText](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) и других
учебников, [FAQ](https://kb.itextpdf.com/home/it7kb/faq) и многого другого. Для получения конкретной информации и примеров, связанных с цифровыми подписями и iText, обязательно ознакомьтесь с
[Центром цифровых подписей](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub).

Многие часто задаваемые вопросы уже были рассмотрены на [Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7), обязательно проверьте и там.

### Вклад

Многие люди внесли свой вклад в **iText Core/Community** за прошедшие годы. Если вы обнаружили ошибку, опечатку в документации или хотите реализовать новую функцию — мы приветствуем ваш вклад.

Небольшие изменения или исправления можно отправлять через [Pull Request](https://github.com/itext/itext7-dotnet/pulls), а для существенных изменений просьба связаться с нами по адресу community@apryse.com, чтобы мы могли лучше скоординировать усилия и избежать дублирования работы.

Пожалуйста, ознакомьтесь с нашими [Рекомендациями по вкладу][contributing] для подробностей о правилах кодирования, отправке кода и прочем.

### Лицензирование

**iText** распространяется по двойной лицензии [AGPL][agpl]/[Коммерческое ПО][sales].

AGPL — это бесплатная/открытая лицензия, однако это не означает, что программное обеспечение [бесплатное][gratis]!

AGPL — это лицензия copyleft, что означает, что любые производные работы также должны распространяться на тех же условиях. Если вы используете iText в программном обеспечении или сервисе, которые не могут соответствовать условиям AGPL, у нас есть коммерческая лицензия, освобождающая от таких обязательств.

Свяжитесь с [отделом продаж] для получения дополнительной информации.

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