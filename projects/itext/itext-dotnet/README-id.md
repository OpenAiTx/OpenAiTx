<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(sebelumnya dikenal sebagai iTextSharp)** adalah pustaka berperforma tinggi yang telah terbukti dan memungkinkan Anda
untuk membuat, mengadaptasi,
memeriksa dan memelihara dokumen PDF, sehingga Anda dapat menambahkan fungsionalitas PDF
ke proyek perangkat lunak Anda dengan mudah. iText juga tersedia untuk [Java](https://github.com/itext/itext7).

### Fitur utama iText Core/Community adalah:

* Pustaka inti:
    * Pembuatan PDF dengan menggunakan layout engine kami
    * Manipulasi PDF, misal menggabungkan beberapa PDF menjadi satu, menambahkan konten baru, ...
    * Penandatanganan digital PDF
    * Pembuatan dan manipulasi formulir PDF
    * Bekerja dengan dokumen PDF/A
    * Bekerja dengan dokumen PDF/UA
    * Kriptografi sesuai FIPS
    * Pembuatan barcode
    * Dukungan SVG
* [Addon:][all products]
    * Konversi XML/HTML & CSS ke PDF [repo][pdfhtml], [info][pdfhtmlproduct]
    * Menyensor informasi sensitif dalam dokumen PDF [repo][pdfsweep], [info][pdfsweepproduct]
    * Dukungan untuk karakter internasional (misal Arab, Tionghoa, Ibrani, Thai, ...) [info][calligraph]
    * Optimasi dokumen PDF untuk mengurangi ukuran file dan meningkatkan performa [info][optimizer]
    * Flattening dokumen XFA [info][xfa]
    * Debugging PDF [repo][rups], [info][rupsproduct]

Ingin tahu apa saja yang bisa dilakukan? Kunjungi [Demo Lab](https://itextpdf.com/demos)! Di sana terdapat koleksi
aplikasi demo siap pakai secara daring!

### Memulai

Cara termudah untuk memulai adalah menggunakan NuGet, cukup jalankan perintah instalasi berikut di folder
proyek Anda:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

Untuk penggunaan yang lebih lanjut, silakan merujuk ke
[Panduan Instalasi](https://kb.itextpdf.com/home/it7kb/installation-guidelines).
Anda juga dapat [membangun iText Community dari sumber][building].

### Hello PDF!

Contoh berikut menunjukkan betapa mudahnya membuat dokumen PDF sederhana:

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

### Contoh

Untuk contoh yang lebih lanjut, silakan merujuk ke [Knowledge Base](https://kb.itextpdf.com/home/it7kb/examples) atau
[Repo Contoh utama](https://github.com/itext/i7ns-samples). Anda dapat menemukan contoh C# yang setara dengan
contoh Java [Signing](https://github.com/itext/i7js-signing-examples) [di sini](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications),
meskipun kode Java sangat mirip karena mereka menggunakan API yang sama.

Beberapa file PDF keluaran mungkin akan ditampilkan secara tidak benar oleh previewer GitHub, jadi pastikan untuk mengunduhnya agar dapat melihat
hasil yang benar.

| Deskripsi                                  | Tautan                                                                                                                                                                                                                                                                                                   |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Layout dasar**                           |                                                                                                                                                                                                                                                                                                        |
| Ubah properti teks                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| Membuat tabel sederhana                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| Menambahkan gambar ke dokumen PDF          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| Membuat daftar                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| Menambahkan watermark                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| Menambahkan tautan navigasi dalam dokumen  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| Membuat anotasi popup                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| Mengganti font                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| Menambahkan isian formulir                 | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Pengaturan dokumen umum**                |                                                                                                                                                                                                                                                                                                        |
| Ubah ukuran halaman dan margin             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| Tulis PDF ke byte array, bukan ke disk     | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| Ubah rotasi halaman                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| Menambahkan header dan footer              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| Menggabungkan dokumen                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| Flatten anotasi                            | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| Membuat dokumen PDF/UA                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| Membuat dokumen PDF/A-3                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| Membuat dokumen PDF/A-4                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| Membuat dokumen WTPDF                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| Membuat dokumen ZUGFeRD/Factur-X           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| Aktifkan FIPS                              | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| Contoh FIPS SHA3                           | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| Konversi SVG ke PDF                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| Konversi SVG ke PDF menggunakan layout     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| Konversi SVG sebagai string ke PDF         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| Konversi SVG ke PdfPage                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| Konversi SVG sebagai XObject               | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| Konversi SVG ke PDF dengan pdfCalligraph   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Konversi HTML dan CSS ke PDF**           | [Link ke repo](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                                   |
| Konversi dokumen HTML sederhana ke PDF     | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Redaksi konten secara aman**             | [Link ke repo](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                                  |
| Meredaksi konten                           | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| Redaksi berdasarkan regex                  | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Dukungan sistem penulisan kompleks**     | [Link ke dokumentasi](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                     |
| Menambahkan teks Arab                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Optimasi PDF**                           | [Link ke dokumentasi](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                         |
| Mengurangi ukuran PDF                      | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Flattening XFA**                         | [Link ke dokumentasi](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                |
| Flatten dokumen XFA                        | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [Link ke repo](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                      |
| Debug PDF                                  | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### FAQ, tutorial, dll. ###

Lihat [iText Knowledge Base](https://kb.itextpdf.com) untuk
[tutorial iText Jump-start](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) dan tutorial lainnya,
[FAQ](https://kb.itextpdf.com/home/it7kb/faq) dan lainnya. Untuk informasi dan contoh spesifik terkait tanda tangan digital dan iText, pastikan untuk melihat
[Digital Signatures Hub](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub).

Banyak pertanyaan umum yang sudah dijawab di
[Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7), jadi pastikan juga untuk memeriksanya.

### Kontribusi

Banyak orang telah berkontribusi pada **iText Core/Community** selama bertahun-tahun. Jika Anda menemukan bug, kesalahan dokumentasi, atau memiliki fitur baru yang ingin diimplementasikan, kami menyambut kontribusi Anda.

Perubahan kecil atau perbaikan dapat diajukan sebagai [Pull Request](https://github.com/itext/itext7-dotnet/pulls), sedangkan untuk perubahan besar kami meminta Anda menghubungi kami di community@apryse.com agar kami dapat mengoordinasikan upaya dan mencegah duplikasi pekerjaan.

Silakan baca [Panduan Kontribusi][contributing] kami untuk detail tentang pengiriman kode, aturan penulisan kode, dan lainnya.

### Lisensi

**iText** dilisensikan ganda sebagai [AGPL][agpl]/[Perangkat Lunak Komersial][sales].

AGPL adalah lisensi perangkat lunak bebas/sumber terbuka, namun ini tidak berarti perangkat lunak tersebut [gratis][gratis]!

AGPL adalah lisensi copyleft, artinya setiap karya turunan juga harus dilisensikan dengan persyaratan yang sama. Jika
Anda menggunakan iText dalam perangkat lunak atau layanan yang tidak dapat mematuhi ketentuan AGPL, kami menyediakan lisensi komersial
yang membebaskan Anda dari kewajiban tersebut.

Hubungi [Sales] untuk info lebih lanjut.

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