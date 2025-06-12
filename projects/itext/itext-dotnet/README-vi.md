<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(trước đây gọi là iTextSharp)** là một thư viện hiệu năng cao, đã được kiểm nghiệm thực tế, cho phép bạn
tạo, chỉnh sửa,
kiểm tra và duy trì các tài liệu PDF, giúp bạn dễ dàng thêm chức năng PDF
vào các dự án phần mềm của mình. Thư viện này cũng có sẵn cho [Java](https://github.com/itext/itext7).

### Các tính năng chính của iText Core/Community:

* Thư viện cốt lõi:
    * Tạo PDF với công cụ bố cục của chúng tôi
    * Chỉnh sửa PDF, ví dụ như gộp nhiều file PDF thành một, thêm nội dung mới, ...
    * Ký số tài liệu PDF
    * Tạo và chỉnh sửa biểu mẫu PDF
    * Làm việc với tài liệu PDF/A
    * Làm việc với tài liệu PDF/UA
    * Mã hóa tuân thủ FIPS
    * Tạo mã vạch
    * Hỗ trợ SVG
* [Các tiện ích bổ sung:][all products]
    * Chuyển đổi XML/HTML & CSS sang PDF [repo][pdfhtml], [thông tin][pdfhtmlproduct]
    * Ẩn thông tin nhạy cảm trong tài liệu PDF [repo][pdfsweep], [thông tin][pdfsweepproduct]
    * Hỗ trợ bộ ký tự quốc tế (ví dụ: Ả Rập, Trung Quốc, Do Thái, Thái Lan, ...) [thông tin][calligraph]
    * Tối ưu hóa tài liệu PDF để giảm kích thước file, tăng hiệu năng [thông tin][optimizer]
    * Làm phẳng tài liệu XFA [thông tin][xfa]
    * Gỡ lỗi PDF [repo][rups], [thông tin][rupsproduct]

Muốn khám phá thêm các khả năng? Truy cập [Demo Lab](https://itextpdf.com/demos)! Nơi đây có một bộ sưu tập
ứng dụng demo sẵn sàng sử dụng trực tuyến!

### Bắt đầu nhanh

Cách đơn giản nhất để bắt đầu là sử dụng NuGet, chỉ cần thực hiện lệnh cài đặt sau trong thư mục dự án của bạn:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

Đối với các trường hợp sử dụng nâng cao, vui lòng tham khảo
[Hướng dẫn cài đặt](https://kb.itextpdf.com/home/it7kb/installation-guidelines).
Bạn cũng có thể [biên dịch iText Community từ mã nguồn][building].

### Hello PDF!

Ví dụ sau đây cho thấy việc tạo một tài liệu PDF đơn giản dễ dàng như thế nào:

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

### Ví dụ

Để xem các ví dụ nâng cao hơn, hãy tham khảo [Knowledge Base](https://kb.itextpdf.com/home/it7kb/examples) hoặc
[Kho ví dụ chính](https://github.com/itext/i7ns-samples). Bạn có thể tìm thấy các ví dụ C# tương đương với
ví dụ Java về [Ký số](https://github.com/itext/i7js-signing-examples) [tại đây](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications),
mặc dù mã Java rất giống vì chúng dùng cùng API.

Một số file PDF đầu ra sẽ hiển thị không chính xác bởi trình xem trước của GitHub, vì vậy hãy tải xuống để xem kết quả đúng.

| Mô tả                                      | Liên kết                                                                                                                                                                                                                                                                                               |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Bố cục cơ bản**                          |                                                                                                                                                                                                                                                                                                        |
| Thay đổi thuộc tính văn bản                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| Tạo bảng đơn giản                          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| Thêm hình ảnh vào tài liệu PDF             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| Tạo danh sách                               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| Thêm watermark                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| Thêm liên kết để điều hướng trong tài liệu | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| Tạo chú thích popup                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| Thay đổi phông chữ                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| Thêm trường biểu mẫu                       | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Thiết lập tài liệu tổng quát**           |                                                                                                                                                                                                                                                                                                        |
| Thay đổi kích thước và lề trang            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| Ghi PDF vào mảng byte thay vì ổ đĩa        | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| Thay đổi xoay trang                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| Thêm header và footer                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| Gộp các tài liệu                           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| Làm phẳng chú thích                        | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| Tạo tài liệu PDF/UA                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| Tạo tài liệu PDF/A-3                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| Tạo tài liệu PDF/A-4                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| Tạo tài liệu WTPDF                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| Tạo tài liệu ZUGFeRD/Factur-X              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| Bật FIPS                                   | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| Ví dụ FIPS SHA3                            | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| Chuyển đổi SVG sang PDF                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| Chuyển đổi SVG sang PDF sử dụng layout     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| Chuyển SVG dạng chuỗi sang PDF             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| Chuyển SVG thành PdfPage                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| Chuyển SVG sang XObject                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| Chuyển SVG sang PDF với pdfCalligraph      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Chuyển đổi HTML và CSS sang PDF**        | [Link tới repo](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                                  |
| Chuyển đổi tài liệu HTML đơn giản sang PDF | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Ẩn an toàn nội dung**                    | [Link tới repo](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                                 |
| Ẩn nội dung                                | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| Ẩn dựa trên regex                          | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Hỗ trợ hệ thống chữ viết phức tạp**      | [Link tới tài liệu](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                       |
| Thêm văn bản tiếng Ả Rập                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Tối ưu hóa PDF**                         | [Link tới tài liệu](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                           |
| Giảm kích thước PDF                        | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Làm phẳng XFA**                          | [Link tới tài liệu](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                  |
| Làm phẳng tài liệu XFA                     | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [Link tới repo](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                     |
| Gỡ lỗi PDF                                 | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### Câu hỏi thường gặp, hướng dẫn, v.v. ###

Tham khảo [iText Knowledge Base](https://kb.itextpdf.com) để xem
[hướng dẫn bắt đầu nhanh với iText](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) và các
hướng dẫn khác, [Câu hỏi thường gặp](https://kb.itextpdf.com/home/it7kb/faq) và nhiều hơn nữa. Đối với thông tin và ví dụ về
chữ ký số và iText, hãy chắc chắn xem
[Digital Signatures Hub](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub).

Nhiều câu hỏi phổ biến đã được trả lời
trên [Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7), hãy kiểm tra ở đó.

### Đóng góp

Nhiều người đã đóng góp cho **iText Core/Community** trong nhiều năm qua. Nếu bạn phát hiện lỗi, sai sót trong tài liệu,
hoặc có tính năng mới muốn bổ sung, chúng tôi hoan nghênh đóng góp của bạn.

Các thay đổi nhỏ hoặc sửa lỗi có thể gửi qua [Pull Request](https://github.com/itext/itext7-dotnet/pulls), còn với
thay đổi lớn, vui lòng liên hệ với chúng tôi tại community@apryse.com để chúng ta phối hợp tốt hơn và tránh trùng lặp công việc.

Vui lòng đọc [Hướng dẫn đóng góp][contributing] để biết chi tiết về việc gửi mã, quy tắc lập trình và thông tin khác.

### Giấy phép

**iText** có hai loại giấy phép: [AGPL][agpl]/[Phần mềm thương mại][sales].

AGPL là giấy phép phần mềm miễn phí/mã nguồn mở, tuy nhiên, điều này không có nghĩa là phần mềm [miễn phí][gratis]!

AGPL là giấy phép copyleft, nghĩa là bất kỳ phần mềm phái sinh nào cũng phải được cấp phép dưới cùng điều khoản. Nếu
bạn sử dụng iText trong phần mềm hoặc dịch vụ không thể tuân thủ điều khoản AGPL, chúng tôi có giấy phép thương mại
giúp bạn miễn trừ các nghĩa vụ này.

Liên hệ [Sales] để biết thêm thông tin.

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

[tất cả sản phẩm]: https://itextpdf.com/products

[pdfhtmlproduct]: https://itextpdf.com/products/itext-pdf-html

[xfa]: https://itextpdf.com/products/flatten-pdf-pdfxfa

[rupsproduct]: https://itextpdf.com/products/rups

[calligraph]: https://itextpdf.com/products/pdfcalligraph

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---