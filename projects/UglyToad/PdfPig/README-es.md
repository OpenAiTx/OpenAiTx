<image src="https://raw.githubusercontent.com/UglyToad/Pdf/master/documentation/pdfpig.png" width="128px" height="128px"/>

# PdfPig

[![nuget](https://img.shields.io/nuget/dt/PdfPig)](https://www.nuget.org/packages/PdfPig/)
[![Build and test](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test.yml/badge.svg)](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test.yml)
[![Build and test [MacOS]](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test_macos.yml/badge.svg)](https://github.com/UglyToad/PdfPig/actions/workflows/build_and_test_macos.yml)

PdfPig soporta la lectura de texto y contenido de archivos PDF. También soporta la creación básica de archivos PDF.

## Instalación

El paquete está disponible a través de la pestaña de lanzamientos o desde Nuget:

https://www.nuget.org/packages/PdfPig/

O desde la consola del administrador de paquetes:

    > Install-Package PdfPig

Mientras la versión esté por debajo de 1.0.0, las versiones menores cambiarán la API pública sin advertencia (no se seguirá SemVer hasta alcanzar la versión 1.0.0).

## Comenzando

Consulta la [wiki](https://github.com/UglyToad/PdfPig/wiki) para más ejemplos

### Leer texto de un PDF

El uso más simple en esta etapa es abrir un documento, leyendo las palabras de cada página:

```cs
// using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;
// using UglyToad.PdfPig.DocumentLayoutAnalysis.WordExtractor;
using (PdfDocument document = PdfDocument.Open(@"C:\Documents\document.pdf"))
{
    foreach (Page page in document.GetPages())
    {
        string text = ContentOrderTextExtractor.GetText(page);
        IEnumerable<Word> words = page.GetWords(NearestNeighbourWordExtractor.Instance);
    }
}
```

No **deberías** usar `page.Text` directamente, a menos que sepas lo que estás haciendo. La propiedad `Text` preserva el orden interno del contenido que rara vez es el texto en el orden que deseas.

Estas herramientas de análisis de diseño deberían obtener el texto que deseas en la mayoría de los casos.

### Crear documento PDF
Para crear documentos usa la clase `PdfDocumentBuilder`. Las fuentes estándar 14 proporcionan una forma rápida de comenzar:

```cs
PdfDocumentBuilder builder = new PdfDocumentBuilder();

PdfPageBuilder page = builder.AddPage(PageSize.A4);

// Fonts must be registered with the document builder prior to use to prevent duplication.
PdfDocumentBuilder.AddedFont font = builder.AddStandard14Font(Standard14Font.Helvetica);

page.AddText("Hello World!", 12, new PdfPoint(25, 700), font);

byte[] documentBytes = builder.Build();

File.WriteAllBytes(@"C:\git\newPdf.pdf", documentBytes);
```
La salida es un documento PDF de 1 página con el texto "¡Hola Mundo!" en Helvetica cerca de la parte superior de la página:

![La imagen muestra un documento PDF en el visor de PDF de Google Chrome. El texto "¡Hola Mundo!" es visible](https://raw.githubusercontent.com/UglyToad/Pdf/master/documentation/builder-output.png)

Cada fuente debe ser registrada con el `PdfDocumentBuilder` antes de usarla para permitir que las páginas compartan los recursos de la fuente. Solo se admiten las 14 fuentes estándar y fuentes TrueType (.ttf).

La creación de documentos soporta cambios muy limitados en documentos PDF existentes. Sin embargo, no soporta ninguno de los siguientes:

- Edición de formularios
- Copiar o cambiar anotaciones, metadatos o datos de estructura del documento
- Añadir o eliminar texto con fuentes existentes

### Extracción avanzada de documentos
En este ejemplo se realiza una extracción de documento más avanzada. `PdfDocumentBuilder` se usa para crear una copia del pdf con información de depuración (cajas delimitadoras y orden de lectura) añadida.



```cs
//using UglyToad.PdfPig;
//using UglyToad.PdfPig.DocumentLayoutAnalysis.PageSegmenter;
//using UglyToad.PdfPig.DocumentLayoutAnalysis.ReadingOrderDetector;
//using UglyToad.PdfPig.DocumentLayoutAnalysis.WordExtractor;
//using UglyToad.PdfPig.Fonts.Standard14Fonts;
//using UglyToad.PdfPig.Writer;


var sourcePdfPath = "";
var outputPath = "";
var pageNumber = 1;
using (var document = PdfDocument.Open(sourcePdfPath))
{
    var builder = new PdfDocumentBuilder { };
    PdfDocumentBuilder.AddedFont font = builder.AddStandard14Font(Standard14Font.Helvetica);
    var pageBuilder = builder.AddPage(document, pageNumber);
    pageBuilder.SetStrokeColor(0, 255, 0);
    var page = document.GetPage(pageNumber);

    var letters = page.Letters; // no preprocessing

    // 1. Extract words
    var wordExtractor = NearestNeighbourWordExtractor.Instance;

    var words = wordExtractor.GetWords(letters);

    // 2. Segment page
    var pageSegmenter = DocstrumBoundingBoxes.Instance;

    var textBlocks = pageSegmenter.GetBlocks(words);

    // 3. Postprocessing
    var readingOrder = UnsupervisedReadingOrderDetector.Instance;
    var orderedTextBlocks = readingOrder.Get(textBlocks);

    // 4. Add debug info - Bounding boxes and reading order
    foreach (var block in orderedTextBlocks)
    {
        var bbox = block.BoundingBox;
        pageBuilder.DrawRectangle(bbox.BottomLeft, bbox.Width, bbox.Height);
        pageBuilder.AddText(block.ReadingOrder.ToString(), 8, bbox.TopLeft, font);
    }

    // 5. Write result to a file
    byte[] fileBytes = builder.Build();
    File.WriteAllBytes(outputPath, fileBytes); // save to file
}
```

![La imagen muestra un documento PDF creado por el bloque de código anterior con las cajas delimitadoras y el orden de lectura de las palabras mostrados](/documentation/boundingBoxes_ReadingOrder.png)

Consulte [Análisis de Diseño de Documento](https://github.com/UglyToad/PdfPig/wiki/Document-Layout-Analysis) para más información sobre análisis avanzado de documentos.

Consulte [Exportar](https://github.com/UglyToad/PdfPig/wiki/Document-Layout-Analysis#export) para herramientas más avanzadas para analizar diseños de documentos.


## Uso

### PdfDocument

La clase `PdfDocument` proporciona acceso al contenido de un documento cargado ya sea desde un archivo o pasado como bytes. Para abrir desde un archivo use el método estático `PdfDocument.Open`:

```cs
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

using (PdfDocument document = PdfDocument.Open(@"C:\my-file.pdf"))
{
	int pageCount = document.NumberOfPages;

	// Page number starts from 1, not 0.
	Page page = document.GetPage(1);

	decimal widthInPoints = page.Width;
	decimal heightInPoints = page.Height;

	string text = page.Text;
}
```
`PdfDocument` solo debe usarse en una declaración `using` ya que implementa `IDisposable` (a menos que el consumidor lo libere en otro lugar).

Los documentos encriptados pueden abrirse con PdfPig. Para proporcionar una contraseña de propietario o de usuario, proporcione las `ParsingOptions` opcionales al llamar a `Open` con la propiedad `Password` definida. Por ejemplo:

    using (PdfDocument document = PdfDocument.Open(@"C:\mi-archivo.pdf",  new ParsingOptions { Password = "contraseña aquí" }))

También puede proporcionar una lista de contraseñas para intentar:


```cs
using (PdfDocument document = PdfDocument.Open(@"C:\file.pdf", new ParsingOptions
{
	Passwords = new List<string> { "One", "Two" }
}))
```

El documento contiene la versión de la especificación PDF con la que cumple, accesible mediante `document.Version`:

    decimal version = document.Version;

### Creación de Documento

El `PdfDocumentBuilder` crea un nuevo documento sin páginas ni contenido.

Para contenido de texto, debe registrarse una fuente con el constructor. Esta biblioteca soporta las fuentes Standard 14 proporcionadas por Adobe por defecto y fuentes en formato TrueType.

Para agregar una fuente Standard 14 use:

    public AddedFont AddStandard14Font(Standard14Font type)

O para una fuente TrueType use:

    AddedFont AddTrueTypeFont(IReadOnlyList<byte> fontFileBytes)

Pasando los bytes de un archivo TrueType (.ttf). Puede verificar la idoneidad de un archivo TrueType para incrustar en un documento PDF usando:

    bool CanUseTrueTypeFont(IReadOnlyList<byte> fontFileBytes, out IReadOnlyList<string> reasons)

Que proporciona una lista de razones por las que la fuente no puede usarse si la comprobación falla. Debe verificar la licencia de una fuente TrueType antes de usarla, ya que el archivo comprimido de la fuente se incrusta y distribuye con el documento resultante.

La clase `AddedFont` representa una clave para la fuente almacenada en el constructor del documento. Esto debe proporcionarse al añadir contenido de texto a las páginas. Para agregar una página a un documento use:

    PdfPageBuilder AddPage(PageSize size, bool isPortrait = true)

Esto crea un nuevo `PdfPageBuilder` con el tamaño especificado. La primera página agregada es la número 1, luego la 2, luego la 3, etc. El constructor de páginas soporta añadir texto, dibujar líneas y rectángulos y medir el tamaño del texto antes de dibujarlo.

Para dibujar líneas y rectángulos use los métodos:

```cs
void DrawLine(PdfPoint from, PdfPoint to, decimal lineWidth = 1)
void DrawRectangle(PdfPoint position, decimal width, decimal height, decimal lineWidth = 1)
```

El ancho de línea se puede variar y por defecto es 1. Los rectángulos no están rellenos y el color de relleno no se puede cambiar actualmente.

Para escribir texto en la página debe tener una referencia a una `AddedFont` de los métodos en `PdfDocumentBuilder` como se describió anteriormente. Luego puede dibujar el texto en la página usando:

    IReadOnlyList<Letter> AddText(string text, decimal fontSize, PdfPoint position, PdfDocumentBuilder.AddedFont font)

Donde `position` es la línea base del texto a dibujar. Actualmente **solo se soporta texto ASCII**. También puede medir el tamaño resultante del texto antes de dibujarlo usando el método:

    IReadOnlyList<Letter> MeasureText(string text, decimal fontSize, PdfPoint position, PdfDocumentBuilder.AddedFont font)

Que no cambia el estado de la página, a diferencia de `AddText`.

Cambiar el color RGB del texto, líneas y rectángulos está soportado usando:

```cs
void SetStrokeColor(byte r, byte g, byte b)
void SetTextAndFillColor(byte r, byte g, byte b)
```

Que toman valores RGB entre 0 y 255. El color permanecerá activo para todas las operaciones llamadas después de estos métodos hasta que se llame a reset usando:

    void ResetColor()

Que restablece el color para trazo, relleno y dibujo de texto a negro.

### Información del Documento

El `PdfDocument` proporciona acceso a los metadatos del documento como `DocumentInformation` definidos en el archivo PDF. Estos suelen no estar proporcionados, por lo que la mayoría de estas entradas serán `null`:

```
PdfDocument document = PdfDocument.Open(fileName);

// The name of the program used to convert this document to PDF.
string producer = document.Information.Producer;

// The title given to the document
string title = document.Information.Title;
// etc...
```

### Estructura del Documento

El `PdfDocument` tiene un miembro Structure:

    UglyToad.PdfPig.Structure structure = document.Structure;

Esto proporciona acceso al contenido tokenizado del documento PDF:

```cs
Catalog catalog = structure.Catalog;
DictionaryToken pagesDictionary = catalog.PagesDictionary;
```

El diccionario de páginas es la raíz del árbol de páginas dentro de un documento PDF. La estructura también expone un método `GetObject(IndirectReference reference)` que permite el acceso aleatorio a cualquier objeto en el PDF siempre que se conozca su número de identificador. Este es un identificador de la forma `69 0 R` donde 69 es el número de objeto y 0 es la generación.

### Página

La `Page` contiene el ancho y alto de la página en puntos así como el mapeo al enumerado `PageSize`:


```cs
PageSize size = Page.Size;

bool isA4 = size == PageSize.A4;
```
`Page` proporciona acceso al texto de la página, pero debe usar `ContentOrderTextExtractor` o alternativas si está indexando el texto, por ejemplo, para RAG/LLMs:

    string text = page.Text;

Hay un método que proporciona acceso a las palabras. El método predeterminado utiliza heurísticas básicas. Para casos avanzados, también puede implementar su propio `IWordExtractor` o usar el `NearestNeighbourWordExtractor`:

    IEnumerable<Word> words = page.GetWords();

También puede acceder a las operaciones en bruto utilizadas en el flujo de contenido de la página para dibujar gráficos y contenido en la página:

    IReadOnlyList<IGraphicsStateOperation> operations = page.Operations;

Consulte la especificación PDF para el significado de los operadores individuales.

También hay una API para recuperar los objetos de imagen PDF por página:

    IEnumerable<XObjectImage> images = page.GetImages();

Por favor, lea la [wiki sobre Imágenes](https://github.com/UglyToad/PdfPig/wiki/Images).

### Letter

Debido a la forma en que un PDF está estructurado internamente, el texto de la página puede no ser una representación legible del texto tal como aparece en el documento. Dado que PDF es un formato de presentación, el texto puede dibujarse en cualquier orden, no necesariamente en orden de lectura. Esto significa que pueden faltar espacios o que las palabras pueden estar en posiciones inesperadas en el texto.

Para ayudar a los usuarios a resolver el orden real del texto en la página, el archivo `Page` proporciona acceso a una lista de las letras:

    IReadOnlyList<Letter> letters = page.Letters;

Estas letras contienen:

- El texto de la letra: `letter.Value`.
- La ubicación de la esquina inferior izquierda de la letra: `letter.Location`.
- El ancho de la letra: `letter.Width`.
- El tamaño de fuente en unidades de texto relativas sin escalar (estos tamaños son internos al PDF y no corresponden a tamaños en píxeles, puntos u otras unidades): `letter.FontSize`.
- El nombre de la fuente utilizada para renderizar la letra, si está disponible: `letter.FontName`.
- Un rectángulo que es el rectángulo más pequeño que contiene completamente la región visible de la letra/glifo: `letter.GlyphRectangle`.
- Los puntos al inicio y al final de la línea base `StartBaseLine` y `EndBaseLine` que indican si la letra está rotada. La `TextDirection` indica si esta es una rotación comúnmente usada o una rotación personalizada.

La posición de la letra se mide en coordenadas PDF donde el origen está en la esquina inferior izquierda de la página. Por lo tanto, un valor Y más alto significa más cerca de la parte superior de la página.

### Anotaciones

La recuperación de anotaciones en cada página se realiza utilizando el método:

    page.GetAnnotations()

Esta llamada no está en caché y el documento no debe haberse cerrado antes de su uso. Las anotaciones no pueden ser editadas.

### Marcadores

Los marcadores (esquemas) de un documento pueden obtenerse a nivel del documento:

    bool hasBookmarks = document.TryGetBookmarks(out Bookmarks bookmarks);

Esto devolverá `false` si el documento no define ningún marcador.

### Formularios

Los campos de formulario para formularios interactivos (AcroForms) pueden obtenerse usando:

    bool hasForm = document.TryGetForm(out AcroForm form);

Esto devolverá `false` si el documento no contiene un formulario.

Los campos pueden accederse usando la propiedad `Fields` de `AcroForm`. Dado que el formulario se define a nivel de documento, esto devolverá campos de todas las páginas del documento. Los campos son de los tipos definidos por el enum `AcroFieldType`, por ejemplo `PushButton`, `Checkbox`, `Text`, etc.

Tenga en cuenta que los formularios son de solo lectura y los valores no pueden cambiarse ni añadirse usando PdfPig.

### Hipervínculos

Una página tiene un método para extraer hipervínculos (anotaciones del tipo enlace):

    IReadOnlyList<UglyToad.PdfPig.Content.Hyperlink> hyperlinks = page.GetHyperlinks();

Los hipervínculos no pueden añadirse ni editarse al construir documentos.

### TrueType

Las clases usadas para trabajar con fuentes TrueType en el archivo PDF están disponibles para uso público. Dado un archivo de entrada:



```cs
using UglyToad.PdfPig.Fonts.TrueType;
using UglyToad.PdfPig.Fonts.TrueType.Parser;

byte[] fontBytes = System.IO.File.ReadAllBytes(@"C:\font.ttf");
TrueTypeDataBytes input = new TrueTypeDataBytes(fontBytes);
TrueTypeFont font = TrueTypeFontParser.Parse(input);
```

La fuente analizada puede ser inspeccionada.

### Archivos incrustados

Los archivos PDF pueden contener otros archivos completamente incrustados dentro de ellos para anotaciones de documentos. Se puede acceder a la lista de archivos incrustados y su contenido en bytes:

```cs
if (document.Advanced.TryGetEmbeddedFiles(out IReadOnlyList<EmbeddedFile> files)
    && files.Count > 0)
{
    var firstFile = files[0];
    string name = firstFile.Name;
    IReadOnlyList<byte> bytes = firstFile.Bytes;
}
```

### Fusión

Puedes fusionar 2 o más archivos PDF existentes utilizando la clase `PdfMerger`:

```cs
var resultFileBytes = PdfMerger.Merge(filePath1, filePath2);
File.WriteAllBytes(@"C:\pdfs\outputfilename.pdf", resultFileBytes);
```

## Wiki
Consulta nuestro [wiki](https://github.com/UglyToad/PdfPig/wiki) para más ejemplos y guías detalladas sobre la API.

## Problemas

Por favor, reporta un problema si encuentras un error. Consulta nuestra [política de problemas](https://github.com/UglyToad/PdfPig/issues/1095) y la [guía de contribución](https://github.com/UglyToad/PdfPig/blob/master/CONTRIBUTING.md) para más detalles.

## Referencia de la API

Si deseas generar documentación doxygen, ejecuta `doxygen doxygen-docs` y abre `docs/doxygen/html/index.html`.

## Créditos

Este proyecto comenzó como un esfuerzo para portar [PDFBox](https://github.com/apache/pdfbox) a C#. Este proyecto no sería posible sin el trabajo realizado por el equipo de [PDFBox](https://pdfbox.apache.org/) y la Fundación Apache.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---