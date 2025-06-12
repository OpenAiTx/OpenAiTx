<p align="center">
    <img src="https://raw.githubusercontent.com/itext/itext-dotnet/develop/assets/iText_Logo_Small.png" alt="Logo iText">
</p>

![Nuget](https://img.shields.io/nuget/v/itext7)
[![Licencia AGPL](https://img.shields.io/badge/license-AGPL-blue.svg)](https://github.com/itext/itext7/blob/master/LICENSE.md)
![Nuget](https://img.shields.io/nuget/dt/itext7)
![GitHub commit activity (branch)](https://img.shields.io/github/commit-activity/m/itext/itext7-dotnet)

iText Core/Community **(anteriormente conocido como iTextSharp)** es una biblioteca de alto rendimiento y probada en batalla que te permite crear, adaptar, inspeccionar y mantener documentos PDF, permitiéndote añadir funcionalidad PDF a tus proyectos de software con facilidad. También está disponible para [Java](https://github.com/itext/itext7).

### Las características clave de iText Core/Community son:

* Biblioteca principal:
    * Creación de PDF utilizando nuestro motor de maquetado
    * Manipulación de PDF, por ejemplo, fusionar múltiples PDFs en uno, añadir nuevo contenido, ...
    * Firma digital de PDF
    * Creación y manipulación de formularios PDF
    * Trabajar con documentos PDF/A
    * Trabajar con documentos PDF/UA
    * Criptografía compatible con FIPS
    * Generación de códigos de barras
    * Soporte para SVG
* [Addons:][all products]
    * Conversión de XML/HTML y CSS a PDF [repo][pdfhtml], [info][pdfhtmlproduct]
    * Redacción de información sensible en documentos PDF [repo][pdfsweep], [info][pdfsweepproduct]
    * Soporte para conjuntos de caracteres internacionales (por ejemplo, árabe, chino, hebreo, tailandés, ...) [info][calligraph]
    * Optimización de documentos PDF para reducir el tamaño del archivo y aumentar el rendimiento [info][optimizer]
    * Aplanar documentos XFA [info][xfa]
    * Depuración de PDF [repo][rups], [info][rupsproduct]

¿Quieres descubrir lo que es posible? ¡Visita nuestro [Demo Lab](https://itextpdf.com/demos)! Contiene una colección de aplicaciones demo listas para usar en línea.

### Comenzando

La forma más sencilla de empezar es usar NuGet, simplemente ejecuta el siguiente comando de instalación en la carpeta de tu proyecto:

```shell
dotnet add package itext --version <REEMPLAZA_CON_LA_VERSION_DE_ITEXT_DESEADA>
dotnet add package itext.bouncy-castle-adapter --version <REEMPLAZA_CON_LA_VERSION_DE_ITEXT_DESEADA>
```

Para casos de uso más avanzados, consulta las [Directrices de instalación](https://kb.itextpdf.com/home/it7kb/installation-guidelines).
También puedes [compilar iText Community desde el código fuente][building].

### ¡Hola PDF!

El siguiente ejemplo muestra lo fácil que es crear un documento PDF simple:

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

### Ejemplos

Para ejemplos más avanzados, consulta nuestra [Base de Conocimiento](https://kb.itextpdf.com/home/it7kb/examples) o el [repositorio principal de Ejemplos](https://github.com/itext/i7ns-samples). Puedes encontrar equivalentes en C# de los ejemplos de firma de Java [Signing examples](https://github.com/itext/i7js-signing-examples) [aquí](https://github.com/itext/itext-publications-samples-dotnet/tree/develop/itext/itext.publications), aunque el código Java es muy similar ya que tienen la misma API.

Algunos de los archivos PDF resultantes se mostrarán incorrectamente en el visor previo de GitHub, así que asegúrate de descargarlos para ver los resultados correctos.

| Descripción                                | Enlace                                                                                                                                                                                                                                                                                                   |
|--------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Maquetado básico**                       |                                                                                                                                                                                                                                                                                                          |
| Cambiar propiedades del texto              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_paragraphTextWithStyle.pdf)                              |
| Crear una tabla simple                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/tables/SimpleTable9.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/tables/cmp_simple_table9.pdf)                                                  |
| Añadir una imagen a un documento PDF       | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/images/MultipleImages.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/images/cmp_multiple_images.pdf)                                             |
| Crear una lista                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/objects/NestedLists.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/objects/cmp_nested_list.pdf)                                                  |                                                                                                                                                                                                      
| Añadir una marca de agua                   | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/Watermarking.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_watermarkings.pdf)                                              |
| Añadir enlaces para navegar en el documento| [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/AddLinkAnnotation5.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_add_link_annotation5.pdf)                         |
| Crear una anotación emergente              | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/annotations/MovePopup.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/annotations/cmp_move_popup.pdf)                                            |
| Cambiar fuente                             | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/ParagraphTextWithStyle.cs)                                                                                                                                                 |
| Añadir campos de formulario                | [C#](https://kb.itextpdf.com/home/it7kb/examples/forms-in-itext-core-8-0-0)                                                                                                                                                                                                                             |
 <br>                                       |                                                                                                                                                                                                                                                                                                         |
| **Configuraciones generales del documento**|                                                                                                                                                                                                                                                                                                          |
| Cambiar tamaño y márgenes de página        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/layout/PageSizeAndMargins.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/layout/cmp_pageSizeAndMargins.pdf)                                     |
| Escribir PDF en un array de bytes          | [C#](https://stackoverflow.com/a/67411657/10015628)                                                                                                                                                                                                                                                     |
| Cambiar rotación de página                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/PageRotation.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_page_rotation.pdf)                                              |
| Añadir encabezado y pie de página          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/events/TextFooter.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/events/cmp_text_footer.pdf)                                                  |
| Unir documentos                            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/merge/AddCover1.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/merge/cmp_add_cover.pdf)                                                         |
| Aplanar anotaciones                        | [C#](https://kb.itextpdf.com/home/it7kb/examples/high-level-annotation-flattening)                                                                                                                                                                                                                      |
| <br>                                       |                                                                                                                                                                                                                                                                                                         |
| **PDF/UA, PDF/A**                          |                                                                                                                                                                                                                                                                                                         |
| Crear documento PDF/UA                     | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/PdfUA.cs),  [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/pdfua/cmp_pdf_ua.pdf)                                                               |
| Crear documento PDF/A-3                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA3.cs)                                                                                                                                                                   |
| Crear documento PDF/A-4                    | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfa/PdfA4.cs)                                                                                                                                                                  |
| Crear documento WTPDF                      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/pdfua/Wtpdf.cs)                                                                                                                                                                 |
| Crear documento ZUGFeRD/Factur-X           | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/zugferd/BasicSample.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/zugferd/cmp_invoice_with_zugferd.pdf) |
| <br>                                       |                                                                                                                                                                                                                                                                                                         |
| **FIPS**                                   |                                                                                                                                                                                                                                                                                                         |
| Habilitar FIPS                             | [C#](https://kb.itextpdf.com/home/it7kb/releases/release-itext-core-8-0-0/breaking-changes-for-itext-core-8-0-0/bouncy-castle-changes)                                                                                                                                                                 |
| Ejemplo FIPS SHA3                          | [C#](https://kb.itextpdf.com/home/it7kb/examples/fips-sha3-examples-for-itext-core-8-0-0)                                                                                                                                                                                                              |
| <br>                                       |                                                                                                                                                                                                                                                                                                         |
| **SVG**                                    |                                                                                                                                                                                                                                                                                                         |
| Convertir SVG a PDF                        | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdf.cs)                                                                                                                                                         |
| Convertir SVG a PDF usando layout          | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToLayoutImage.cs)                                                                                                                                                 |
| Convertir SVG como string a PDF            | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgStringToPdf.cs)                                                                                                                                                   |
| Convertir SVG a una PdfPage                | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfPage.cs)                                                                                                                                                     |
| Convertir SVG como XObject                 | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToXObject.cs)                                                                                                                                                     |
| Convertir SVG a PDF con pdfCalligraph      | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/svg/ConvertSvgToPdfWithPdfCalligraph.cs)                                                                                                                                        |
| <br>                                       |                                                                                                                                                                                                                                                                                                         |
| **Convertir HTML y CSS a PDF**             | [Enlace al repo](https://github.com/itext/i7j-pdfhtml)                                                                                                                                                                                                                                                 |
| Convertir un HTML simple a PDF             | [C#](https://kb.itextpdf.com/home/it7kb/ebooks/itext-7-converting-html-to-pdf-with-pdfhtml)                                                                                                                                                                                                            |
| <br>                                       |                                                                                                                                                                                                                                                                                                         |
| **Redacción segura de contenido**          | [Enlace al repo](https://github.com/itext/i7j-pdfsweep)                                                                                                                                                                                                                                                |
| Redacción de contenido                     | [C#](https://kb.itextpdf.com/home/it7kb/examples/removing-content-with-pdfsweep)                                                                                                                                                                                                                       |
| Redactar usando expresiones regulares      | [C#](https://itextpdf.com/products/pdf-redaction-pdfsweep)                                                                                                                                                                                                                                             |
| <br>                                       |                                                                                                                                                                                                                                                                                                         |
| **Soporte para sistemas de escritura complejos** | [Enlace a la documentación](https://itextpdf.com/products/pdfcalligraph)                                                                                                                                                                                                                               |
| Añadir texto árabe                         | [C#](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/itext/samples/sandbox/typography/arabic/ArabicWordSpacing.cs), [PDF](https://github.com/itext/itext-publications-samples-dotnet/blob/master/itext/itext.samples/cmpfiles/sandbox/typography/cmp_ArabicWordSpacing.pdf)                     |
| <br>                                       |                                                                                                                                                                                                                                                                                                         |
| **Optimización de PDFs**                   | [Enlace a la documentación](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                   |
| Reducir tamaño del PDF                     | [C#](https://itextpdf.com/products/compress-pdf-pdfoptimizer)                                                                                                                                                                                                                                          |
| <br>                                       |                                                                                                                                                                                                                                                                                                         |
| **Aplanado de XFA**                        | [Enlace a la documentación](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                          |
| Aplanar un documento XFA                   | [C#](https://itextpdf.com/products/flatten-pdf-pdfxfa)                                                                                                                                                                                                                                                 |
| <br>                                       |                                                                                                                                                                                                                                                                                                         |
| **RUPS**                                   | [Enlace al repo](https://github.com/itext/i7j-rups)                                                                                                                                                                                                                                                    |
| Depurar un PDF                             | [C#](https://github.com/itext/i7j-rups/releases/latest)                                                                                                                                                                                                                                                |

### Preguntas frecuentes, tutoriales, etc. ###

Consulta la [Base de Conocimiento de iText](https://kb.itextpdf.com) para el [Tutorial de inicio rápido de iText](https://kb.itextpdf.com/home/it7kb/ebooks/itext-jump-start-tutorial-for-net) y otros tutoriales, [FAQs](https://kb.itextpdf.com/home/it7kb/faq) y más. Para información específica y ejemplos relacionados con firmas digitales e iText, asegúrate de revisar el [Centro de Firmas Digitales](https://kb.itextpdf.com/home/it7kb/digital-signatures-hub).

Muchas preguntas comunes ya han sido respondidas en [Stack Overflow](https://stackoverflow.com/questions/tagged/itext+itext7), así que asegúrate de revisar allí también.

### Contribuir

Muchas personas han contribuido a **iText Core/Community** a lo largo de los años. Si has encontrado un error, un fallo en la documentación, o tienes una nueva funcionalidad que quieras implementar, damos la bienvenida a tus contribuciones.

Pequeños cambios o correcciones pueden ser enviados como un [Pull Request](https://github.com/itext/itext7-dotnet/pulls), mientras que para cambios mayores te pedimos que nos contactes en community@apryse.com para coordinar mejor nuestros esfuerzos y prevenir duplicación de trabajo.

Por favor, lee nuestras [Directrices de Contribución][contributing] para detalles sobre el envío de código, reglas de codificación y más.

### Licenciamiento

**iText** está bajo doble licencia como [AGPL][agpl]/[software comercial][sales].

AGPL es una licencia de software libre/código abierto, sin embargo, esto no significa que el software sea [gratis][gratis]!

La AGPL es una licencia copyleft, lo que significa que cualquier trabajo derivado también debe estar licenciado bajo los mismos términos. Si usas iText en un software o servicio que no puede cumplir los términos de la AGPL, tenemos una licencia comercial disponible que te exime de esas obligaciones.

Contacta con [Ventas] para más información.

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