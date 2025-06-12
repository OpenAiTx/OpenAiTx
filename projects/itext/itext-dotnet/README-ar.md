<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(المعروف سابقًا باسم iTextSharp)** هي مكتبة عالية الأداء تم اختبارها في العديد من التطبيقات، تتيح لك
إنشاء وتكييف
وفحص وصيانة مستندات PDF، مما يسمح لك بإضافة وظائف PDF إلى مشاريعك البرمجية بسهولة. وهي متوفرة أيضًا لـ [Java](https://github.com/itext/itext7).

### الميزات الرئيسية لمكتبة iText Core/Community:

* المكتبة الأساسية:
    * إنشاء ملفات PDF باستخدام محرك التنسيق الخاص بنا
    * معالجة ملفات PDF، مثل دمج عدة ملفات PDF في ملف واحد، إضافة محتوى جديد، ...
    * التوقيع الرقمي لملفات PDF
    * إنشاء ومعالجة نماذج PDF
    * التعامل مع مستندات PDF/A
    * التعامل مع مستندات PDF/UA
    * تشفير متوافق مع FIPS
    * توليد الباركود
    * دعم SVG
* [الإضافات:][all products]
    * تحويل XML/HTML و CSS إلى PDF [المستودع][pdfhtml]، [المعلومات][pdfhtmlproduct]
    * تنقيح المعلومات الحساسة في مستندات PDF [المستودع][pdfsweep]، [المعلومات][pdfsweepproduct]
    * دعم مجموعات الحروف الدولية (مثل العربية، الصينية، العبرية، التايلاندية، ...) [المعلومات][calligraph]
    * تحسين ملفات PDF لتقليل حجم الملف وزيادة الأداء [المعلومات][optimizer]
    * تسطيح مستندات XFA [المعلومات][xfa]
    * تصحيح أخطاء PDF [المستودع][rups]، [المعلومات][rupsproduct]

هل تريد اكتشاف ما هو ممكن؟ توجه إلى [معمل العروض التوضيحية الخاص بنا](https://itextpdf.com/demos)! يحتوي على مجموعة من
تطبيقات العرض الجاهزة للاستخدام عبر الإنترنت!

### البدء

أسهل طريقة للبدء هي استخدام NuGet، فقط نفذ أمر التثبيت التالي في مجلد مشروعك:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

للحالات الأكثر تقدماً، يرجى الرجوع إلى
[إرشادات التثبيت](https://kb.itextpdf.com/home/it7kb/installation-guidelines).
يمكنك أيضًا [بناء iText Community من المصدر][building].

### مرحبًا PDF!

يوضح المثال التالي مدى سهولة إنشاء مستند PDF بسيط:

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

### أمثلة

للحصول على أمثلة أكثر تقدماً، راجع [قاعدة المعرفة](https://kb.itextpdf.com/home/it7kb/examples) أو
[المستودع الرئيسي للأمثلة](https://github.com/itext/i7ns-samples). يمكنك العثور على مكافئات C# لأمثلة
توقيع Java [هنا](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications)،
على الرغم من أن الشيفرة البرمجية لـ Java متشابهة جدًا لأنها تستخدم نفس الواجهة البرمجية.

بعض ملفات PDF الناتجة قد لا يتم عرضها بشكل صحيح في عارض GitHub، لذا تأكد من تنزيلها لرؤية النتائج الصحيحة.

| الوصف                                      | الرابط                                                                                                                                                                                                                                                                                                   |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **التنسيق الأساسي**                        |                                                                                                                                                                                                                                                                                                        |
| تغيير خصائص النص                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)، [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| إنشاء جدول بسيط                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs)،  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| إضافة صورة إلى مستند PDF                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs)، [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| إنشاء قائمة                                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs)، [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| إضافة علامة مائية                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs)،  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| إضافة روابط للتنقل داخل المستند             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs)،  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| إنشاء تعليق منبثق                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs)،  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| تغيير الخط                                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| إضافة حقول النماذج                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **إعدادات المستند العامة**                  |                                                                                                                                                                                                                                                                                                        |
| تغيير حجم الصفحة والهامش                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs)،  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| كتابة PDF إلى مصفوفة بايت بدلاً من القرص     | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| تغيير تدوير الصفحة                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs)،  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| إضافة رأس وتذييل                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs)،  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| دمج المستندات                               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs)،  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| تسطيح التعليقات التوضيحية                   | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| إنشاء مستند PDF/UA                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs)،  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| إنشاء مستند PDF/A-3                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| إنشاء مستند PDF/A-4                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| إنشاء مستند WTPDF                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| إنشاء مستند ZUGFeRD/Factur-X               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs)، [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| تفعيل FIPS                                  | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| مثال FIPS SHA3                              | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| تحويل SVG إلى PDF                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| تحويل SVG إلى PDF باستخدام التنسيق           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| تحويل SVG كسلسلة نصية إلى PDF               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| تحويل SVG إلى PdfPage                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| تحويل SVG إلى XObject                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| تحويل SVG إلى PDF باستخدام pdfCalligraph     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **تحويل HTML و CSS إلى PDF**                | [رابط المستودع](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                                 |
| تحويل مستند HTML بسيط إلى PDF               | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **تنقيح المحتوى بأمان**                     | [رابط المستودع](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                                |
| تنقيح المحتوى                               | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| تنقيح بناءً على تعبير منتظم                 | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **دعم أنظمة الكتابة المعقدة**               | [رابط الوثائق](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                            |
| إضافة نص عربي                               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs)، [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **تحسين ملفات PDF**                        | [رابط الوثائق](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                |
| تقليل حجم PDF                               | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **تسطيح XFA**                               | [رابط الوثائق](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                       |
| تسطيح مستند XFA                             | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [رابط المستودع](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                    |
| تصحيح أخطاء PDF                             | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### الأسئلة الشائعة، الدروس، إلخ ###

اطلع على [قاعدة معرفة iText](https://kb.itextpdf.com)
ودليل [البدء السريع لـ iText](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) ودروس أخرى،
[الأسئلة الشائعة](https://kb.itextpdf.com/home/it7kb/faq) والمزيد. لمعلومات وأمثلة حول التوقيعات الرقمية وiText،
تأكد من زيارة [مركز التواقيع الرقمية](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub).

تمت الإجابة عن العديد من الأسئلة الشائعة بالفعل
على [Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7)، لذا تأكد من الاطلاع هناك أيضًا.

### المساهمة

لقد ساهم العديد من الأشخاص في **iText Core/Community** على مر السنين. إذا وجدت خطأ أو خطأ في التوثيق، أو لديك ميزة جديدة تريد تنفيذها، فنحن نرحب بمساهماتك.

يمكن تقديم التغييرات أو الإصلاحات الصغيرة كـ [طلب سحب](https://github.com/itext/itext7-dotnet/pulls)، أما بالنسبة
للتغييرات الكبيرة فنرجو منك التواصل معنا عبر community@apryse.com حتى نتمكن من تنسيق الجهود ومنع تكرار العمل.

يرجى قراءة [إرشادات المساهمة][contributing] لمزيد من التفاصيل حول إرسال الشيفرة، وقواعد البرمجة، وغير ذلك.

### الترخيص

**iText** مرخصة ترخيصًا مزدوجًا كـ [AGPL][agpl]/[برنامج تجاري][sales].

AGPL هو ترخيص برنامج حر/مفتوح المصدر، لكن هذا لا يعني أن البرنامج [مجاني][gratis]!

AGPL هو ترخيص copyleft، مما يعني أن أي عمل مشتق يجب أن يكون أيضًا مرخصًا بنفس الشروط. إذا كنت تستخدم iText في برنامج أو خدمة لا يمكنها الامتثال لشروط AGPL، يتوفر لدينا ترخيص تجاري يعفيك من هذه الالتزامات.

تواصل مع [المبيعات] لمزيد من المعلومات.

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