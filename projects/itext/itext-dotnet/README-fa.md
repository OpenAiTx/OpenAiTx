<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(که قبلاً با نام iTextSharp شناخته می‌شد)** یک کتابخانه قدرتمند، با کارایی بالا و آزمایش‌شده در شرایط واقعی است که به شما اجازه می‌دهد اسناد PDF را ایجاد، ویرایش، بررسی و نگهداری کنید و به راحتی قابلیت‌های PDF را به پروژه‌های نرم‌افزاری خود اضافه نمایید. همچنین نسخه‌ای برای [جاوا](https://github.com/itext/itext7) نیز در دسترس است.

### ویژگی‌های کلیدی iText Core/Community عبارت‌اند از:

* کتابخانه اصلی:
    * ایجاد PDF با استفاده از موتور صفحه‌آرایی ما
    * ویرایش PDF، مانند ادغام چند PDF در یک، افزودن محتوای جدید و ...
    * امضای دیجیتال PDF
    * ایجاد و ویرایش فرم‌های PDF
    * کار با اسناد PDF/A
    * کار با اسناد PDF/UA
    * رمزنگاری مطابق با استاندارد FIPS
    * تولید بارکد
    * پشتیبانی از SVG
* [افزونه‌ها:][all products]
    * تبدیل XML/HTML و CSS به PDF [مخزن][pdfhtml]، [اطلاعات][pdfhtmlproduct]
    * حذف اطلاعات حساس از اسناد PDF [مخزن][pdfsweep]، [اطلاعات][pdfsweepproduct]
    * پشتیبانی از مجموعه کاراکترهای بین‌المللی (مانند عربی، چینی، عبری، تایلندی و ...) [اطلاعات][calligraph]
    * بهینه‌سازی اسناد PDF برای کاهش حجم فایل و افزایش عملکرد [اطلاعات][optimizer]
    * تخت‌کردن اسناد XFA [اطلاعات][xfa]
    * اشکال‌زدایی PDF [مخزن][rups]، [اطلاعات][rupsproduct]

مایلید ببینید چه چیزهایی ممکن است؟ به [آزمایشگاه دمو](https://itextpdf.com/demos) ما سر بزنید! مجموعه‌ای از برنامه‌های نمونه آماده استفاده آنلاین را شامل می‌شود!

### شروع به کار

آسان‌ترین راه برای شروع، استفاده از NuGet است؛ کافیست دستور نصب زیر را در پوشه پروژه خود اجرا کنید:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

برای سناریوهای پیشرفته‌تر، لطفاً به [راهنمای نصب](https://kb.itextpdf.com/home/it7kb/installation-guidelines) مراجعه کنید.
همچنین می‌توانید [iText Community را از سورس بسازید][building].

### سلام PDF!

مثال زیر نشان می‌دهد که ساخت یک سند PDF ساده چقدر آسان است:

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

### مثال‌ها

برای مثال‌های پیشرفته‌تر به [پایگاه دانش](https://kb.itextpdf.com/home/it7kb/examples) یا [مخزن اصلی مثال‌ها](https://github.com/itext/i7ns-samples) مراجعه کنید. معادل‌های C# برای مثال‌های امضای جاوا [در اینجا](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications) موجود است، هرچند کد جاوا تقریباً مشابه است زیرا هر دو از یک API استفاده می‌کنند.

برخی از فایل‌های خروجی PDF ممکن است به درستی توسط پیش‌نمایش GitHub نمایش داده نشوند، بنابراین برای مشاهده نتایج صحیح، آن‌ها را دانلود نمایید.

| توضیحات                                  | لینک                                                                                                                                                                                                                                                                                                   |
|-------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **صفحه‌آرایی پایه**                      |                                                                                                                                                                                                                                                                                                        |
| تغییر ویژگی‌های متن                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| ایجاد یک جدول ساده                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| افزودن تصویر به سند PDF                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| ایجاد یک لیست                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| افزودن واترمارک                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| افزودن پیوند برای پیمایش در سند           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| ایجاد یادداشت پاپ‌آپ                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| تغییر فونت                                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| افزودن فیلدهای فرم                        | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **تنظیمات عمومی سند**                     |                                                                                                                                                                                                                                                                                                        |
| تغییر اندازه و حاشیه صفحه                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| نوشتن PDF به آرایه بایت به‌جای دیسک       | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| تغییر چرخش صفحه                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| افزودن سربرگ و پاورقی                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| ادغام اسناد                                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| تخت‌کردن یادداشت‌ها                        | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| ایجاد سند PDF/UA                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| ایجاد سند PDF/A-3                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| ایجاد سند PDF/A-4                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| ایجاد سند WTPDF                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| ایجاد سند ZUGFeRD/Factur-X                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| فعال‌سازی FIPS                             | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| مثال FIPS SHA3                             | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| تبدیل SVG به PDF                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| تبدیل SVG به PDF با استفاده از صفحه‌آرایی  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| تبدیل SVG به رشته و سپس به PDF              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| تبدیل SVG به PdfPage                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| تبدیل SVG به XObject                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| تبدیل SVG به PDF با pdfCalligraph           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **تبدیل HTML و CSS به PDF**                 | [لینک به مخزن](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                                   |
| تبدیل سند HTML ساده به PDF                  | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **حذف ایمن محتوا**                          | [لینک به مخزن](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                                  |
| حذف محتوا                                   | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| حذف مبتنی بر regex                          | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **پشتیبانی از سیستم‌های نوشتاری پیچیده**    | [لینک به مستندات](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                         |
| افزودن متن عربی                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **بهینه‌سازی PDFها**                        | [لینک به مستندات](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                             |
| کاهش حجم PDF                                | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **تخت‌کردن XFA**                            | [لینک به مستندات](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                    |
| تخت‌کردن سند XFA                            | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                    | [لینک به مخزن](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                      |
| اشکال‌زدایی PDF                             | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### سوالات متداول، آموزش‌ها و غیره ###

به [پایگاه دانش iText](https://kb.itextpdf.com) مراجعه کنید برای
[آموزش شروع سریع iText](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) و سایر
آموزش‌ها، [سوالات متداول](https://kb.itextpdf.com/home/it7kb/faq) و موارد بیشتر. برای اطلاعات و مثال‌های خاص مرتبط با امضاهای دیجیتال و iText، حتماً به
[مرکز امضاهای دیجیتال](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub) مراجعه کنید.

بسیاری از سوالات متداول قبلاً در
[Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7) پاسخ داده شده‌اند، پس حتماً آنجا را نیز بررسی کنید.

### مشارکت

افراد زیادی در طول سال‌ها به **iText Core/Community** کمک کرده‌اند. اگر باگی پیدا کردید، اشتباهی در مستندسازی دیدید، یا ویژگی جدیدی دارید که می‌خواهید پیاده‌سازی کنید، از مشارکت شما استقبال می‌کنیم.

تغییرات یا اصلاحات کوچک را می‌توانید به صورت [Pull Request](https://github.com/itext/itext7-dotnet/pulls) ارسال کنید، در حالی که برای تغییرات عمده درخواست می‌کنیم با ما در community@apryse.com تماس بگیرید تا تلاش‌هایمان هماهنگ شده و از دوباره‌کاری جلوگیری شود.

لطفاً [راهنمای مشارکت][contributing] ما را برای جزئیات ارسال کد، قوانین کدنویسی و موارد بیشتر مطالعه نمایید.

### مجوز

**iText** به صورت دوگانه با مجوز [AGPL][agpl]/[نرم‌افزار تجاری][sales] منتشر می‌شود.

AGPL یک مجوز نرم‌افزاری آزاد/متن‌باز است، اما این به معنای [رایگان][gratis] بودن نرم‌افزار نیست!

AGPL یک مجوز کوپایلِفت است، به این معنی که هر اثر مشتق‌شده نیز باید تحت همین شرایط مجوزدهی شود. اگر شما از iText در نرم‌افزار یا سرویسی استفاده می‌کنید که نمی‌تواند با شرایط AGPL مطابقت داشته باشد، ما مجوز تجاری ارائه می‌دهیم که شما را از این تعهدات معاف می‌کند.

برای اطلاعات بیشتر با [فروش] تماس بگیرید.

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