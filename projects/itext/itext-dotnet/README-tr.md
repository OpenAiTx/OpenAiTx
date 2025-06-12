<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(önceki adıyla iTextSharp)**, PDF belgeleri oluşturmanıza, uyarlamanıza,
incelemenize ve bakımını yapmanıza olanak tanıyan, yüksek performanslı, saha testinden geçmiş bir kütüphanedir.
Yazılım projelerinize kolayca PDF işlevselliği eklemenizi sağlar. [Java](https://github.com/itext/itext7) için de mevcuttur.

### iText Core/Community'nin ana özellikleri:

* Temel kütüphane:
    * Düzen motorumuzun kullanımıyla PDF oluşturma
    * PDF üzerinde işlemler, ör. birden fazla PDF’yi birleştirme, yeni içerik ekleme, ...
    * PDF dijital imzalama
    * PDF formu oluşturma ve düzenleme
    * PDF/A belgeleriyle çalışma
    * PDF/UA belgeleriyle çalışma
    * FIPS uyumlu kriptografi
    * Barkod oluşturma
    * SVG desteği
* [Eklentiler:][all products]
    * XML/HTML & CSS’yi PDF’e dönüştürme [repo][pdfhtml], [bilgi][pdfhtmlproduct]
    * PDF belgelerindeki hassas bilgileri karartma [repo][pdfsweep], [bilgi][pdfsweepproduct]
    * Uluslararası karakter setleri desteği (örn. Arapça, Çince, İbranice, Tayca, ...) [bilgi][calligraph]
    * PDF belgelerini daha küçük dosya boyutu ve artırılmış performans için optimize etme [bilgi][optimizer]
    * XFA belgelerini düzleştirme [bilgi][xfa]
    * PDF hata ayıklama [repo][rups], [bilgi][rupsproduct]

Neler mümkün keşfetmek ister misiniz? [Demo Lab’ımıza](https://itextpdf.com/demos) göz atın! Çevrimiçi olarak hemen kullanıma hazır demo uygulamalar koleksiyonu içerir!

### Başlarken

Başlamanın en kolay yolu NuGet kullanmaktır; projenizin klasöründe aşağıdaki yükleme komutunu çalıştırmanız yeterlidir:

```shell
dotnet add package itext --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
dotnet add package itext.bouncy-castle-adapter --version <REPLACE_WITH_DESIRED_ITEXT_VERSION>
```

Daha gelişmiş kullanım durumları için lütfen
[Kurulum kılavuzuna](https://kb.itextpdf.com/home/it7kb/installation-guidelines) bakınız.
Ayrıca [iText Community’yi kaynak kodundan derleyebilirsiniz][building].

### Merhaba PDF!

Aşağıdaki örnek, basit bir PDF belgesinin ne kadar kolay oluşturulabileceğini gösterir:

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

### Örnekler

Daha gelişmiş örnekler için [Bilgi Bankamıza](https://kb.itextpdf.com/home/it7kb/examples) veya ana
[Örnekler deposuna](https://github.com/itext/i7ns-samples) bakabilirsiniz. Java’daki
[İmzalama örneklerinin](https://github.com/itext/i7js-signing-examples) C# karşılıklarını
[burada](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications)
bulabilirsiniz, Java kodu çok benzerdir çünkü aynı API’ye sahiptirler.

Bazı çıktı PDF dosyaları GitHub önizleyicisinde hatalı görüntülenebilir, bu nedenle doğru sonuçları görmek için indirmeniz önerilir.

| Açıklama                                   | Bağlantı                                                                                                                                                                                                                                                                                                |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Temel düzen**                            |                                                                                                                                                                                                                                                                                                        |
| Metin özelliklerini değiştirme             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                                |
| Basit bir tablo oluşturma                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| PDF belgesine görsel ekleme                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                               |
| Liste oluşturma                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                    |                                                                                                                                                                                                      
| Filigran ekleme                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                                  |
| Belge içinde gezinmek için bağlantı ekleme | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                           |
| Açılır açıklama (popup annotation) ekleme  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                              |
| Yazı tipi değiştirme                       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                                     |
| Form alanı ekleme                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                            |
 <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Genel belge ayarları**                   |                                                                                                                                                                                                                                                                                                        |
| Sayfa boyutu ve kenar boşluğunu değiştirme | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                       |
| PDF’i diske değil byte dizisine yazma      | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                    |
| Sayfa döndürme                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                                  |
| Üstbilgi ve altbilgi ekleme                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                      |
| Belgeleri birleştirme                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                           |
| Açıklamaları düzleştirme                   | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                        |
| PDF/UA belgesi oluşturma                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                                  |
| PDF/A-3 belgesi oluşturma                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                                        |
| PDF/A-4 belgesi oluşturma                  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                   |
| WTPDF belgesi oluşturma                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                  |
| ZUGFeRD/Factur-X belgesi oluşturma         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                        |
| FIPS etkinleştirme                         | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| FIPS SHA3  örneği                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                        |
| SVG’yi PDF’e dönüştürme                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                        |
| Düzen kullanarak SVG’yi PDF’e dönüştürme   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                |
| Dize olarak SVG’yi PDF’e dönüştürme        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                  |
| SVG’yi bir PdfPage’e dönüştürme            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                    |
| SVG’yi XObject olarak dönüştürme           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                    |
| pdfCalligraph ile SVG’yi PDF’e dönüştürme  | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                       |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **HTML ve CSS’yi PDF’e dönüştürme**        | [Depoya bağlantı](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                                |
| Basit bir HTML belgeyi PDF’e dönüştürme    | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **İçeriğin güvenli karartılması**          | [Depoya bağlantı](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                               |
| İçerik karartma                            | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| Regex ile karartma                         | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **Karmaşık yazı sistemleri desteği**       | [Dökümana bağlantı](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                                       |
| Arapça metin ekleme                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                           |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **PDF’leri optimize etme**                 | [Dökümana bağlantı](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                           |
| PDF boyutunu küçültme                      | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **XFA düzleştirme**                        | [Dökümana bağlantı](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                  |
| XFA belgesini düzleştirme                  | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                        |
| **RUPS**                                   | [Depoya bağlantı](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                   |
| PDF hata ayıklama                          | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### SSS, eğitimler, vb. ###

[iText Bilgi Bankasına](https://kb.itextpdf.com) göz atın,
[iText Jump-start eğitimi](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) ve diğer
eğitimler, [SSS’ler](https://kb.itextpdf.com/home/it7kb/faq) ve daha fazlası için. Dijital imzalar ve iText ile ilgili
özel bilgi ve örnekler için
[Dijital İmzalar Merkezi’ni](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub) kontrol ettiğinizden emin olun.

Birçok yaygın soru zaten
[Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7)’da cevaplandı, oraya da bakmayı unutmayın.

### Katkıda Bulunma

Yıllar boyunca birçok kişi **iText Core/Community**'ye katkıda bulundu. Bir hata, dokümantasyonda bir yanlışlık bulduysanız veya uygulamak istediğiniz harika bir yeni özellik varsa, katkılarınızı bekliyoruz.

Küçük değişiklikler veya düzeltmeler [Pull Request](https://github.com/itext/itext7-dotnet/pulls) olarak gönderilebilir, ancak
büyük değişiklikler için lütfen bizimle community@apryse.com üzerinden iletişime geçin, böylece çabalarımızı daha iyi koordine edebilir ve iş tekrarını önleyebiliriz.

Kod gönderimleri, kodlama kuralları ve daha fazlası için lütfen [Katkı Rehberimizi][contributing] okuyunuz.

### Lisanslama

**iText** [AGPL][agpl]/[Ticari yazılım][sales] olarak çift lisanslıdır.

AGPL ücretsiz/açık kaynak bir yazılım lisansıdır, ancak bu yazılımın [bedava][gratis] olduğu anlamına gelmez!

AGPL bir copyleft lisansıdır; yani, herhangi bir türev çalışmanın da aynı şartlar altında lisanslanması gerekir. iText’i AGPL şartlarına uygun olamayacak bir yazılım veya hizmette kullanıyorsanız, sizi bu yükümlülüklerden muaf tutan ticari bir lisansımız mevcuttur.

Daha fazla bilgi için [Satış] ile iletişime geçin.

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

[tüm ürünler]: https://itextpdf.com/products

[pdfhtmlproduct]: https://itextpdf.com/products/itext-pdf-html

[xfa]: https://itextpdf.com/products/flatten-pdf-pdfxfa

[rupsproduct]: https://itextpdf.com/products/rups

[calligraph]: https://itextpdf.com/products/pdfcalligraph

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---