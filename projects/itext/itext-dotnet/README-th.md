<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(เดิมชื่อ iTextSharp)** เป็นไลบรารีประสิทธิภาพสูงที่ผ่านการทดสอบมาอย่างดี ช่วยให้คุณสามารถสร้าง ปรับแต่ง ตรวจสอบ และดูแลไฟล์ PDF ได้อย่างง่ายดาย เพิ่มความสามารถเกี่ยวกับ PDF ให้กับโครงการซอฟต์แวร์ของคุณได้อย่างง่ายดาย นอกจากนี้ยังมีให้ใช้งานสำหรับ [Java](https://github.com/itext/itext7) ด้วย

### คุณสมบัติหลักของ iText Core/Community ได้แก่:

* ไลบรารีหลัก:
    * สร้างไฟล์ PDF ด้วย Layout Engine ของเรา
    * การปรับแต่ง PDF เช่น การรวมไฟล์ PDF หลายไฟล์ การเพิ่มเนื้อหาใหม่ ฯลฯ
    * การลงนามดิจิทัลใน PDF
    * การสร้างและจัดการฟอร์ม PDF
    * ทำงานกับเอกสาร PDF/A
    * ทำงานกับเอกสาร PDF/UA
    * การเข้ารหัสที่สอดคล้องกับ FIPS
    * การสร้างบาร์โค้ด
    * รองรับ SVG
* [ส่วนเสริม:][all products]
    * แปลง XML/HTML & CSS เป็น PDF [repo][pdfhtml], [info][pdfhtmlproduct]
    * การเซ็นเซอร์ข้อมูลสำคัญในเอกสาร PDF [repo][pdfsweep], [info][pdfsweepproduct]
    * รองรับชุดอักขระนานาชาติ (เช่น อาหรับ, จีน, ฮิบรู, ไทย, ...) [info][calligraph]
    * ปรับแต่งเอกสาร PDF ให้ขนาดไฟล์เล็กลงและประสิทธิภาพสูงขึ้น [info][optimizer]
    * ทำให้เอกสาร XFA แบนราบ [info][xfa]
    * ดีบัก PDF [repo][rups], [info][rupsproduct]

อยากค้นพบความสามารถต่าง ๆ เพิ่มเติม? ไปที่ [Demo Lab](https://itextpdf.com/demos)! ที่นี่มีแอปสาธิตให้ทดลองใช้งานออนไลน์มากมาย!

### เริ่มต้นใช้งาน

วิธีที่ง่ายที่สุดในการเริ่มต้นใช้งานคือใช้ NuGet เพียงรันคำสั่งติดตั้งด้านล่างในโฟลเดอร์ของโปรเจกต์คุณ:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

สำหรับกรณีการใช้งานขั้นสูง กรุณาดูที่
[คู่มือการติดตั้ง](https://kb.itextpdf.com/home/it7kb/installation-guidelines)
คุณยังสามารถ [คอมไพล์ iText Community จากซอร์ส][building] ได้เช่นกัน

### Hello PDF!

ตัวอย่างต่อไปนี้แสดงให้เห็นว่าการสร้างเอกสาร PDF อย่างง่ายนั้นง่ายเพียงใด:

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

### ตัวอย่าง

สำหรับตัวอย่างขั้นสูงเพิ่มเติม โปรดดูที่ [Knowledge Base](https://kb.itextpdf.com/home/it7kb/examples) หรือ
[คลังตัวอย่างหลัก](https://github.com/itext/i7ns-samples) คุณสามารถหาตัวอย่าง C# ที่เทียบเท่ากับ
[Java Signing examples](https://github.com/itext/i7js-signing-examples) [ที่นี่](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications)
แม้ว่าโค้ด Java จะคล้ายกันมากเนื่องจากใช้ API เดียวกัน

ไฟล์ PDF ผลลัพธ์บางไฟล์อาจแสดงผลผิดพลาดบนตัวอย่างของ GitHub โปรดดาวน์โหลดเพื่อดูผลลัพธ์ที่ถูกต้อง

| คำอธิบาย                                 | ลิงก์                                                                                                                                                                                                                                                                                                   |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **เลย์เอาต์พื้นฐาน**                      |                                                                                                                                                                                                                                                                                                        |
| เปลี่ยนคุณสมบัติข้อความ                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| สร้างตารางอย่างง่าย                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| เพิ่มรูปภาพลงในเอกสาร PDF                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| สร้างลิสต์                                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| เพิ่มลายน้ำ                                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| เพิ่มลิงก์ภายในเอกสาร                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| สร้าง popup annotation                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| เปลี่ยนฟอนต์                               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| เพิ่มฟิลด์ฟอร์ม                            | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **การตั้งค่าเอกสารทั่วไป**                |                                                                                                                                                                                                                                                                                                        |
| เปลี่ยนขนาดหน้าและระยะขอบ                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| เขียน PDF เป็น byte array แทนการบันทึกลงดิสก์ | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| เปลี่ยนการหมุนหน้ากระดาษ                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| เพิ่มหัวกระดาษและท้ายกระดาษ               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| รวมเอกสาร                                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| Flatten annotation                         | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| สร้างเอกสาร PDF/UA                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| สร้างเอกสาร PDF/A-3                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| สร้างเอกสาร PDF/A-4                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| สร้างเอกสาร WTPDF                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| สร้างเอกสาร ZUGFeRD/Factur-X              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| เปิดใช้ FIPS                               | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| ตัวอย่าง FIPS SHA3                        | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| แปลง SVG เป็น PDF                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| แปลง SVG เป็น PDF ด้วย layout              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| แปลง SVG ที่เป็น string เป็น PDF           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| แปลง SVG เป็น PdfPage                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| แปลง SVG เป็น XObject                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| แปลง SVG เป็น PDF ด้วย pdfCalligraph       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **แปลง HTML และ CSS เป็น PDF**             | [ลิงก์ไปยัง repo](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                               |
| แปลงเอกสาร HTML อย่างง่ายเป็น PDF         | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **การลบเนื้อหาอย่างปลอดภัย**              | [ลิงก์ไปยัง repo](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                              |
| ลบเนื้อหา                                  | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| ลบตาม regex                                | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **รองรับระบบเขียนภาษาซับซ้อน**           | [ลิงก์ไปยัง docs](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                         |
| เพิ่มข้อความภาษาอาหรับ                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **ปรับแต่งขนาดไฟล์ PDF**                  | [ลิงก์ไปยัง docs](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                             |
| ลดขนาดไฟล์ PDF                             | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **XFA flattening**                         | [ลิงก์ไปยัง docs](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                   |
| ทำให้เอกสาร XFA แบนราบ                     | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [ลิงก์ไปยัง repo](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                  |
| ดีบัก PDF                                  | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### คำถามที่พบบ่อย, บทเรียน, ฯลฯ ###

ดู [iText Knowledge Base](https://kb.itextpdf.com)
สำหรับ [iText Jump-start tutorial](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) และบทเรียนอื่น ๆ,
[FAQs](https://kb.itextpdf.com/home/it7kb/faq) และอีกมากมาย สำหรับข้อมูลเฉพาะและตัวอย่างเกี่ยวกับการลงนามดิจิทัลใน iText กรุณาตรวจสอบที่
[Digital Signatures Hub](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub)

คำถามที่พบบ่อยจำนวนมากได้รับคำตอบไว้แล้วที่
[Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7) กรุณาตรวจสอบที่นั่นด้วย

### การร่วมพัฒนา

มีผู้คนมากมายที่ร่วมพัฒนา **iText Core/Community** ตลอดหลายปีที่ผ่านมา หากคุณพบข้อผิดพลาดในซอฟต์แวร์หรือเอกสาร หรือมีฟีเจอร์ใหม่ ๆ ที่อยากเสนอ เรายินดีต้อนรับการมีส่วนร่วมของคุณ

การแก้ไขหรือปรับปรุงเล็กน้อย สามารถส่งเป็น [Pull Request](https://github.com/itext/itext7-dotnet/pulls) ได้เลย ส่วนการเปลี่ยนแปลงใหญ่ ๆ กรุณาติดต่อเราที่ community@apryse.com เพื่อจะได้ประสานงานและป้องกันงานซ้ำซ้อน

กรุณาอ่าน [Contribution Guidelines][contributing] สำหรับรายละเอียดเกี่ยวกับการส่งโค้ด กฎการเขียนโค้ด ฯลฯ

### การอนุญาตใช้งาน

**iText** มีการอนุญาตใช้งานแบบคู่ทั้ง [AGPL][agpl]/[ซอฟต์แวร์เชิงพาณิชย์][sales]

AGPL เป็นซอฟต์แวร์โอเพ่นซอร์สฟรี แต่ไม่ได้หมายความว่าซอฟต์แวร์นี้จะ [ฟรี][gratis]!

AGPL เป็นไลเซนส์ copyleft หมายความว่างานที่ต่อยอดต้องได้รับอนุญาตภายใต้เงื่อนไขเดียวกัน หากคุณใช้ iText ในซอฟต์แวร์หรือบริการที่ไม่สามารถปฏิบัติตามเงื่อนไข AGPL ได้ เรายังมีไลเซนส์เชิงพาณิชย์ที่ยกเว้นข้อผูกมัดเหล่านี้ให้คุณ

ติดต่อ [ฝ่ายขาย] สำหรับข้อมูลเพิ่มเติม

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