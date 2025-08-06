# OfficeIMO - Biblioteca .NET para Microsoft Word

OfficeIMO está disponible como un paquete NuGet desde la galería y es el método de instalación preferido.

[![descargas nuget](https://img.shields.io/nuget/dt/officeIMO.Word?label=nuget%20downloads)](https://www.nuget.org/packages/OfficeIMO.Word)
[![versión nuget](https://img.shields.io/nuget/v/OfficeIMO.Word)](https://www.nuget.org/packages/OfficeIMO.Word)
[![licencia](https://img.shields.io/github/license/EvotecIT/OfficeIMO.svg)](#)
[![CI](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master)](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml)
[![codecov](https://codecov.io/gh/EvotecIT/OfficeIMO/branch/master/graph/badge.svg)](https://codecov.io/gh/EvotecIT/OfficeIMO)

Si deseas contactarme, puedes hacerlo vía Twitter o LinkedIn.

[![twitter](https://img.shields.io/twitter/follow/PrzemyslawKlys.svg?label=Twitter%20%40PrzemyslawKlys&style=social)](https://twitter.com/PrzemyslawKlys)
[![blog](https://img.shields.io/badge/Blog-evotec.xyz-2A6496.svg)](https://evotec.xyz/hub)
[![linked](https://img.shields.io/badge/LinkedIn-pklys-0077B5.svg?logo=LinkedIn)](https://www.linkedin.com/in/pklys)
[![discord](https://img.shields.io/discord/508328927853281280?style=flat-square&label=discord%20chat)](https://evo.yt/discord)

## De qué se trata

Este es un pequeño proyecto (en desarrollo) que permite crear documentos de Microsoft Word (.docx) usando .NET.
Internamente utiliza [OpenXML SDK](https://github.com/OfficeDev/Open-XML-SDK) pero lo simplifica mucho.
Fue creado porque trabajar con OpenXML es demasiado difícil para mí y consume mucho tiempo.
Lo creé para usar dentro del módulo de PowerShell llamado [PSWriteOffice](https://github.com/EvotecIT/PSWriteOffice),
pero pensé que podría ser útil para otros en la comunidad .NET.
Este repositorio también incluye un componente experimental **OfficeIMO.Excel** para crear hojas de cálculo simples.

Si quieres ver lo que puede hacer, echa un vistazo a esta [publicación en el blog](https://evotec.xyz/officeimo-free-cross-platform-microsoft-word-net-library/).

Solía usar la biblioteca DocX (de la cual fui coautor/mantenedor antes de que la tomara Xceed) para crear documentos de Microsoft Word,
pero solo soporta .NET Framework, y su más reciente licencia comunitaria hace que el proyecto sea inutilizable.

*Como no soy realmente un desarrollador, y apenas sé lo que hago, si sabes cómo ayudar, por favor hazlo.*

- Si ves malas prácticas, por favor abre un issue/envía un PR.
- Si sabes cómo hacer algo en OpenXML que pueda ayudar a este proyecto - por favor abre un issue/envía un PR
- Si ves algo que podría funcionar mejor - por favor abre un issue/envía un PR
- Si ves algo en lo que me he equivocado - por favor abre un issue/envía un PR
- Si ves algo que no funciona como creo que funciona - por favor abre un issue/envía un PR

Si detectas algún problema o tienes sugerencias para mejorar, por favor abre un issue o envía un pull request.
Lo principal es que debe funcionar con .NET Framework 4.7.2, .NET Standard 2.0, etc.

**Este proyecto está en desarrollo y como tal hay muchas cosas que pueden y cambiarán, especialmente si algunas personas ayudan.**


| Plataforma | Estado | Cobertura de Código | .NET |
| --------- | ------ | ------------------- | ---- |
| Windows   | ![Windows](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `netstandard2.0`, `net472`, `net8.0`, `net9.0`; OfficeIMO.Excel: `netstandard2.0`, `net472`, `net48`, `net8.0`, `net9.0` |
| Linux     | ![Linux](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `net8.0`; OfficeIMO.Excel: `net8.0`, `net9.0` |
| MacOs     | ![macOS](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `net8.0`; OfficeIMO.Excel: `net8.0`, `net9.0` |
## Apoya Este Proyecto

Si encuentras útil este proyecto, considera apoyar su desarrollo.
Tu patrocinio ayudará a los mantenedores a dedicar más tiempo al mantenimiento y desarrollo de nuevas funcionalidades para todos.

Crear y mantener este proyecto requiere mucho tiempo y esfuerzo.
Al convertirte en patrocinador, puedes ayudar a asegurar que siga siendo gratuito y accesible para todos los que lo necesiten.

Para ser patrocinador, puedes elegir entre las siguientes opciones:

- [Hazte patrocinador vía GitHub Sponsors :heart:](https://github.com/sponsors/PrzemyslawKlys)
- [Hazte patrocinador vía PayPal :heart:](https://paypal.me/PrzemyslawKlys)

Tu patrocinio es completamente opcional y no es necesario para usar este proyecto.
Queremos que este proyecto permanezca open-source y disponible para que cualquiera lo use gratis,
independientemente de si deciden patrocinarlo o no.

Si trabajas para una empresa que usa nuestras bibliotecas .NET o módulos de PowerShell,
considera pedir a tu gerente o equipo de marketing si tu empresa estaría interesada en apoyar este proyecto.
El apoyo de tu empresa puede ayudarnos a continuar manteniendo y mejorando este proyecto para beneficio de todos.

¡Gracias por considerar apoyar este proyecto!

## Por favor comparte con la comunidad

Por favor considera compartir una publicación sobre OfficeIMO y el valor que ofrece. ¡Realmente ayuda!

[![Compartir en reddit](https://img.shields.io/badge/share%20on-reddit-red?logo=reddit)](https://reddit.com/submit?url=https://github.com/EvotecIT/OfficeIMO&title=OfficeIMO)
[![Compartir en hacker news](https://img.shields.io/badge/share%20on-hacker%20news-orange?logo=ycombinator)](https://news.ycombinator.com/submitlink?u=https://github.com/EvotecIT/OfficeIMO)
[![Compartir en twitter](https://img.shields.io/badge/share%20on-twitter-03A9F4?logo=twitter)](https://twitter.com/share?url=https://github.com/EvotecIT/OfficeIMO&t=OfficeIMO)
[![Compartir en facebook](https://img.shields.io/badge/share%20on-facebook-1976D2?logo=facebook)](https://www.facebook.com/sharer/sharer.php?u=https://github.com/EvotecIT/OfficeIMO)
[![Compartir en linkedin](https://img.shields.io/badge/share%20on-linkedin-3949AB?logo=linkedin)](https://www.linkedin.com/shareArticle?url=https://github.com/EvotecIT/OfficeIMO&title=OfficeIMO)

## Funcionalidades

Aquí hay una lista de funcionalidades actualmente soportadas (y probablemente muchas que olvidé) y las que están planeadas. No es una lista cerrada, más bien un TODO, y estoy seguro que hay más:

- ☑️ Conceptos básicos de Word
    - ☑️ Crear
    - ☑️ Cargar
    - ☑️ Guardar (abrir automáticamente al guardar como opción)
    - ☑️ GuardarComo (abrir automáticamente al guardar como opción)
- ☑️ Propiedades de Word
    - ☑️ Leer propiedades básicas y personalizadas
    - ☑️ Establecer propiedades básicas y personalizadas
- ☑️ Secciones
    - ☑️ Agregar Párrafos
    - ☑️ Agregar Encabezados y Pies de página (Impares/Pares/Primero)
    - ☑️ Eliminar Encabezados y Pies de página (Impares/Pares/Primero)
    - ☑️ Eliminar Párrafos
    - ☑️ Eliminar secciones
- ☑️ Encabezados y pies de página en el documento (sin incluir secciones)
    - ☑️ Agregar Predeterminado, Impar, Par, Primero
    - ☑️ Eliminar Predeterminado, Impar, Par, Primero
- ☑️ Párrafos/Texto y aplicar negrita, subrayado, color, etc.
    - ☑️ Estilos de párrafo personalizados vía `WordParagraphStyle`
- ☑️ Párrafos y cambiar alineación
- ☑️ Sangría de párrafos (antes, después, primera línea, francesa)
- ☑️ Espaciado entre líneas con soporte para twips y puntos
- ☑️ Tablas
    - ☑️ [Agregar y modificar estilos de tabla (uno de 105 estilos integrados)](https://evotec.xyz/docs/adding-tables-with-built-in-styles-managing-borders/)
    - ☑️ Agregar filas y columnas
    - ☑️ Agregar celdas
    - ☑️ Agregar propiedades a celdas
    - ☑️ [Agregar y modificar bordes de celdas de tabla](https://evotec.xyz/docs/adding-tables-with-built-in-styles-managing-borders/)
    - ☑️ Eliminar filas
    - ☑️ Eliminar celdas
    - ☑️ Otros
        - ☑️ Combinar celdas (vertical y horizontalmente)
        - ☑️ Dividir celdas (verticalmente)
        - ☑️ Dividir celdas (horizontalmente)
        - ☑️ Detectar celdas combinadas (vertical y horizontalmente)
        - ☑️ Tablas anidadas
        - ☑️ Repetir fila de encabezado en cada página
        - ☑️ Controlar saltos de página en filas
        - ☑️ Establecer altura de fila y ancho de tabla
- ☑️ Imágenes/Fotos (soporta BMP, GIF, JPEG, PNG, TIFF, EMF con varias opciones de ajuste)
    - ☑️ Agregar imágenes desde archivo a Word
    - ☑️ Agregar imágenes desde cadenas Base64
    - ☑️ Guardar imagen de Word a archivo
    - ☑️ Recortar imágenes y establecer transparencia
    - ☑️ Posicionamiento de imagen y obtención de ubicación
    - ◼️ Otros tipos de ubicación
- ☑️ Hipervínculos
    - ☑️ Agregar hipervínculo
    - ☑️ Leer hipervínculo
    - ☑️ Eliminar hipervínculo
    - ☑️ Cambiar hipervínculo
- ☑️ Saltos de página
    - ☑️ Agregar salto de página
    - ☑️ Leer salto de página
    - ☑️ Eliminar salto de página
    - ☑️ Cambiar salto de página
- ☑️ Numeración de páginas
    - ☑️ Insertar números de página en encabezados o pies de página
    - ☑️ Elegir estilo con `WordPageNumberStyle`
- ☑️ Marcadores
    - ☑️ Agregar marcador
    - ☑️ Leer marcador
    - ☑️ Eliminar marcador
    - ☑️ Cambiar marcador
- ☑️ Buscar y reemplazar texto
  - ☑️ Comentarios
      - ☑️ Agregar comentarios
      - ☑️ Leer comentarios
      - ☑️ Eliminar comentarios (individual o todos)
      - ☑️ Seguimiento de comentarios
      - ☑️ Respuestas en hilo
- ☑️ Campos
    - ☑️ Agregar campo
    - ☑️ Leer campo
    - ☑️ Eliminar campo
    - ☑️ Cambiar campo
- ☑️ Notas al pie
    - ☑️ Agregar nuevas notas al pie
    - ☑️ Leer notas al pie
    - ☑️ Eliminar notas al pie
- ☑️ Notas al final
    - ☑️ Agregar nuevas notas al final
    - ☑️ Leer notas al final
    - ☑️ Eliminar notas al final
- ☑️ Variables del documento
    - ☑️ Establecer y leer variables almacenadas en el documento
    - ☑️ Eliminar variables por nombre o índice
- ☑️ Macros
    - ☑️ Agregar o extraer proyectos VBA
    - ☑️ Eliminar módulos de macro
- ☑️ Combinar correspondencia
    - ☑️ Reemplazar valores de `MERGEFIELD`
    - ☑️ Opcionalmente conservar códigos de campo
- ☑️ Controles de contenido
    - ☑️ Agregar controles
    - ☑️ Leer controles
    - ☑️ Actualizar texto de controles
    - ☑️ Eliminar controles
    - ☑️ Controles de formulario de casilla de verificación
    - ☑️ Controles de formulario de selector de fecha
    - ☑️ Controles de formulario de lista desplegable
    - ☑️ Controles de formulario de cuadro combinado
    - ☑️ Controles de formulario de imagen
    - ☑️ Controles de formulario de sección repetida
- ☑️ Formas
    - ☑️ Agregar rectángulos
    - ☑️ Agregar elipses
    - ☑️ Agregar líneas
    - ☑️ Agregar polígonos
    - ☑️ Establecer color de relleno y trazo
    - ☑️ Eliminar formas
- ☑️ Gráficos
    - ☑️ Agregar gráficos
        - ☑️ Gráficos de pastel y pastel 3D
        - ☑️ Gráficos de barras y barras 3D
        - ☑️ Gráficos de líneas y líneas 3D
        - ☑️ Combinados (barra + línea)
        - ☑️ Área y área 3D
        - ☑️ Dispersión
        - ☑️ Radar
    - ☑️ Añadir categorías y leyendas
    - ☑️ Configurar ejes
    - ☑️ Añadir múltiples series
    - ⚠️ Al mezclar series de barras y líneas, llamar a `AddChartAxisX` antes de agregar
      cualquier dato para que ambos tipos de gráfico compartan el mismo eje de categorías.
- ☑️ Ecuaciones
    - ☑️ Insertar ecuaciones Office Math desde OMML
    - ☑️ Eliminar ecuaciones cuando sea necesario
- ☑️ Listas
    - ☑️ Añadir listas
    - ☑️ Eliminar listas
    - ☑️ Clonar listas preservando la numeración
    - ☑️ Añadir listas con viñetas de imagen
    - ☑️ Crear listas personalizadas con viñetas y numeración
    - ☑️ Detectar el estilo de lista de párrafos existentes
- ☑️ Tabla de contenido
    - ☑️ Añadir tabla de contenido (TOC)
    - ☑️ Actualizar campos TOC al abrir
- ☑️ Bordes
    - ☑️ Estilos integrados o configuraciones personalizadas
    - ☑️ Cambiar tamaño, color, estilo y espaciado
- ☑️ Fondo
    - ☑️ Establecer color de fondo
- ☑️ Marcas de agua
    - ☑️ Añadir marca de agua de texto o imagen
    - ☑️ Elegir estilo de texto o imagen mediante `WordWatermarkStyle`
    - ☑️ Establecer rotación, ancho y alto
    - ☑️ Eliminar marca de agua

- ☑️ Portadas
    - ☑️ Añadir portadas integradas

- ☑️ Fuentes
    - ☑️ Incrustar fuentes mediante `WordDocument.EmbedFont`

- ☑️ Contenido incrustado
    - ☑️ Añadir documentos incrustados (RTF, HTML, TXT)
    - ☑️ Añadir fragmentos HTML
    - ☑️ Insertar fragmento HTML tras un párrafo
    - ☑️ Reemplazar texto con un fragmento HTML
    - ☑️ Eliminar documentos incrustados
    - ☑️ Incrustar objetos con iconos y tamaños personalizados
 - ☑️ [Firmas digitales y seguridad de documentos](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.DigitalSignature.cs)
 - ☑️ [Opciones de protección de documentos](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Settings.cs) (documento final, solo lectura recomendado, solo lectura forzado)
 - ☑️ [Aceptar/rechazar revisiones](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Revisions.cs)
 - ☑️ [APIs asíncronas para guardar/cargar](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Async.cs)
 - ☑️ [Combinar múltiples documentos](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.MergeDocuments.cs)
 - ☑️ [Cuadros de texto con opciones de posicionamiento](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.TextBox.cs)
 - ☑️ [Orientación de página, tamaño y márgenes predefinidos](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.PageSettings.cs) ([márgenes](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Sections.cs))
 - ☑️ [Caracteres de tabulación y tabuladores personalizados](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.TabStops.cs)
 - ☑️ [Utilidades para validación de documentos](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Validation.cs)
 - ☑️ [Método CleanupDocument](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Cleanup.cs) que fusiona ejecuciones idénticas
 - ☑️ [Serialización XML de párrafos](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Examples/Word/XmlSerialization/XmlSerialization.Basic.cs)
 - ☑️ [Ayudas para conversión de unidades de medida](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.HelpersConversions.cs)

- ☑️ Componente experimental de Excel
    - ☑️ Crear y cargar libros de trabajo
    - ☑️ Añadir hojas de cálculo
    - ☑️ APIs asíncronas para guardar y cargar


## Funciones (en líneas breves):

Esta lista de funciones es para cuando quieres arreglar algo rápidamente en lugar de usar todas las características completas.
Estas funciones están disponibles como parte de la clase `WordHelpers`.

- ☑️ Eliminar encabezados y pies de página de un archivo
- ☑️ Convertir plantilla DOTX a DOCX

## Ejemplos

### Documento básico con pocas propiedades y un párrafo

Este breve ejemplo muestra cómo crear un documento Word con solo un párrafo de texto y algunas propiedades del documento.

```csharp
string filePath = System.IO.Path.Combine(
    "Support",
    "GitHub",
    "PSWriteOffice",
    "Examples",
    "Documents",
    "BasicDocument.docx");

using (WordDocument document = WordDocument.Create(filePath)) {
    document.BuiltinDocumentProperties.Title = "This is my title";
    document.BuiltinDocumentProperties.Creator = "Przemysław Kłys";
    document.BuiltinDocumentProperties.Keywords = "word, docx, test";

    var paragraph = document.AddParagraph("Basic paragraph");
    paragraph.ParagraphAlignment = JustificationValues.Center;
    paragraph.Color = SixLabors.ImageSharp.Color.Red;

document.Save(true);
}
```

### Creación de documentos directamente en un flujo

Esta sobrecarga permite generar un documento completamente en memoria o en cualquier flujo proporcionado.

```csharp
using var stream = new MemoryStream();
using (var document = WordDocument.Create(stream)) {
    document.AddParagraph("Stream based document");
    document.Save(stream);
}
stream.Position = 0;
using (var loaded = WordDocument.Load(stream)) {
    Console.WriteLine(loaded.Paragraphs[0].Text);
}
```

### Guardar como un nuevo documento

`SaveAs` clona el documento actual a una nueva ruta y devuelve una nueva instancia de `WordDocument` sin cambiar la `FilePath` original.

```csharp
using (WordDocument document = WordDocument.Create()) {
    document.AddParagraph("Some text");
    using var copy = document.SaveAs(filePath);
    // document.FilePath is still null
    // copy.FilePath equals filePath
}
```

### Guardar en matrices de bytes y flujos

`SaveAsByteArray` y `SaveAsMemoryStream` te permiten mantener todo en memoria. `SaveAs(Stream)` clona el documento en un flujo proporcionado y devuelve una nueva instancia cargada desde él.

```csharp
using (WordDocument document = WordDocument.Create()) {
    document.AddParagraph("In memory");
    byte[] data = document.SaveAsByteArray();
    using MemoryStream stream = document.SaveAsMemoryStream();
    using var clone = document.SaveAs(stream);
}
```

### Incrustar una fuente

`EmbedFont` añade un archivo de fuente TrueType u OpenType al documento para que pueda ser utilizado en cualquier equipo.

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("This document uses an embedded font.");
    document.Save();
}
```

`EmbedFont` tiene una sobrecarga que puede registrar un estilo de párrafo automáticamente:

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath, "DejaVuStyle", "DejaVu Style");
    document.AddParagraph("Styled paragraph").SetStyleId("DejaVuStyle");
    document.Save();
}
```

### Mezclando fuentes integradas y embebidas

Después de incrustar una fuente, puedes referenciarla por nombre junto con las fuentes estándar.

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("Builtin Arial").SetFontFamily("Arial");
    document.AddParagraph("Embedded DejaVu Sans").SetFontFamily("DejaVu Sans");
    var mixed = document.AddParagraph("Mix: ");
    mixed.AddText("Arial, ").SetFontFamily("Arial");
    mixed.AddText("DejaVu").SetFontFamily("DejaVu Sans");
    document.Save();
}
```

También puede crear un estilo de párrafo que utilice la fuente incrustada.

```csharp
var style = new Style { Type = StyleValues.Paragraph, StyleId = "EmbeddedStyle" };
style.Append(new StyleName { Val = "EmbeddedStyle" });
style.Append(new StyleRunProperties(new RunFonts { Ascii = "DejaVu Sans" }));
WordParagraphStyle.RegisterCustomStyle("EmbeddedStyle", style);

using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("Paragraph with embedded style").SetStyleId("EmbeddedStyle");
    document.AddParagraph("Built-in style example").Style = WordParagraphStyles.Normal;
    document.Save();
}
```

### Documento básico con encabezados/pies de página (primero, impar, par)

Este breve ejemplo muestra cómo agregar encabezados y pies de página a un documento de Word.

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.Sections[0].PageOrientation = PageOrientationValues.Landscape;
    document.AddParagraph("Test Section0");
    document.AddHeadersAndFooters();
    document.DifferentFirstPage = true;
    document.DifferentOddAndEvenPages = true;

    document.Sections[0].Header.First.AddParagraph().SetText("Test Section 0 - First Header");
    document.Sections[0].Header.Default.AddParagraph().SetText("Test Section 0 - Header");
    document.Sections[0].Header.Even.AddParagraph().SetText("Test Section 0 - Even");

    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();

    var section1 = document.AddSection();
    section1.PageOrientation = PageOrientationValues.Portrait;
    section1.AddParagraph("Test Section1");
    section1.AddHeadersAndFooters();
    section1.Header.Default.AddParagraph().SetText("Test Section 1 - Header");
    section1.DifferentFirstPage = true;
    section1.Header.First.AddParagraph().SetText("Test Section 1 - First Header");

    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();

    var section2 = document.AddSection();
    section2.AddParagraph("Test Section2");
    section2.PageOrientation = PageOrientationValues.Landscape;
    section2.AddHeadersAndFooters();
    section2.Header.Default.AddParagraph().SetText("Test Section 2 - Header");

    document.AddParagraph("Test Section2 - Paragraph 1");

    var section3 = document.AddSection();
    section3.AddParagraph("Test Section3");
    section3.AddHeadersAndFooters();
    section3.Header.Default.AddParagraph().SetText("Test Section 3 - Header");

    Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Paragraphs[0].Text);
    Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 1: " + document.Sections[2].Paragraphs[1].Text);
    Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Paragraphs[0].Text);

    Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Header.Default.Paragraphs[0].Text);
    document.Save(true);
}
```

### Añadiendo un Control de Contenido

Este ejemplo muestra cómo añadir y actualizar un control de contenido simple y luego recuperarlo por etiqueta.

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    var sdt = document.AddStructuredDocumentTag("Hello", "MyAlias", "MyTag");
    sdt.Text = "Changed";
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    var tag = document.GetStructuredDocumentTagByTag("MyTag");
Console.WriteLine(tag.Text);
}
```

### Múltiples Controles de Contenido

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.AddStructuredDocumentTag("First", "Alias1", "Tag1");
    document.AddStructuredDocumentTag("Second", "Alias2", "Tag2");
    document.AddStructuredDocumentTag("Third", "Alias3", "Tag3");
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    foreach (var control in document.StructuredDocumentTags) {
        Console.WriteLine(control.Tag + ": " + control.Text);
    }
}
```
### Uso Avanzado del Control de Contenido


```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.AddStructuredDocumentTag("First", "Alias1", "Tag1");
    document.AddStructuredDocumentTag("Second", "Alias2", "Tag2");
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    var alias = document.GetStructuredDocumentTagByAlias("Alias2");
    alias.Text = "Updated";
    var tag = document.GetStructuredDocumentTagByTag("Tag1");
    Console.WriteLine(tag.Text);
}
```

### Uso avanzado de OfficeIMO

Este breve ejemplo muestra múltiples características de `OfficeIMO.Word`

```csharp
string filePath = System.IO.Path.Combine(folderPath, "AdvancedDocument.docx");
using (WordDocument document = WordDocument.Create(filePath)) {
    // lets add some properties to the document
    document.BuiltinDocumentProperties.Title = "Cover Page Templates";
    document.BuiltinDocumentProperties.Subject = "How to use Cover Pages with TOC";
    document.ApplicationProperties.Company = "Evotec Services";

    // we force document to update fields on open, this will be used by TOC
    document.Settings.UpdateFieldsOnOpen = true;

    // lets add one of multiple added Cover Pages
    document.AddCoverPage(CoverPageTemplate.IonDark);

    // lets add Table of Content (1 of 2)
    document.AddTableOfContent(TableOfContentStyle.Template1);

    // lets add page break
    document.AddPageBreak();

    // lets create a list that will be binded to TOC
    var wordListToc = document.AddTableOfContentList(WordListStyle.Headings111);

    wordListToc.AddItem("How to add a table to document?");

    document.AddParagraph("In the first paragraph I would like to show you how to add a table to the document using one of the 105 built-in styles:");

    // adding a table and modifying content
    var table = document.AddTable(5, 4, WordTableStyle.GridTable5DarkAccent5);
    table.Rows[3].Cells[2].Paragraphs[0].Text = "Adding text to cell";
    table.Rows[3].Cells[2].Paragraphs[0].Color = Color.Blue; ;
    table.Rows[3].Cells[3].Paragraphs[0].Text = "Different cell";

    document.AddParagraph("As you can see adding a table with some style, and adding content to it ").SetBold().SetUnderline(UnderlineValues.Dotted).AddText("is not really complicated").SetColor(Color.OrangeRed);

    wordListToc.AddItem("How to add a list to document?");

    var paragraph = document.AddParagraph("Adding lists is similar to ading a table. Just define a list and add list items to it. ").SetText("Remember that you can add anything between list items! ");
    paragraph.SetColor(Color.Blue).SetText("For example TOC List is just another list, but defining a specific style.");

    var list = document.AddList(WordListStyle.Bulleted);
    list.AddItem("First element of list", 0);
    list.AddItem("Second element of list", 1);

    var paragraphWithHyperlink = document.AddHyperLink("Go to Evotec Blogs", new Uri("https://evotec.xyz"), true, "URL with tooltip");
    // you can also change the hyperlink text, uri later on using properties
    paragraphWithHyperlink.Hyperlink.Uri = new Uri("https://evotec.xyz/hub");
    paragraphWithHyperlink.ParagraphAlignment = JustificationValues.Center;

    list.AddItem("3rd element of list, but added after hyperlink", 0);
    list.AddItem("4th element with hyperlink ").AddHyperLink("included.", new Uri("https://evotec.xyz/hub"), addStyle: true);

    document.AddParagraph();

    // create a custom bullet list
    var custom = document.AddCustomBulletList(WordListLevelKind.BulletSquareSymbol, "Courier New", SixLabors.ImageSharp.Color.Red, fontSize: 16);
    custom.AddItem("Custom bullet item");

    // create a list using an image as the bullet
    var pictureList = document.AddPictureBulletList(Path.Combine(folderPath, "Images", "Kulek.jpg"));
    pictureList.AddItem("Image bullet 1");
    pictureList.AddItem("Image bullet 2");

    // create a multi-level custom list
    var builder = document.AddCustomList()
        .AddListLevel(1, WordListLevelKind.BulletSquareSymbol, "Courier New", SixLabors.ImageSharp.Color.Red, fontSize: 14)
        .AddListLevel(5, WordListLevelKind.BulletBlackCircle, "Arial", colorHex: "#00ff00", fontSize: 10);
    builder.AddItem("First");
    builder.AddItem("Fifth", 4);

    // Note: use AddCustomList() rather than AddList(WordListStyle.Custom)
    // when you want to build lists with your own levels.
    // See [Custom Lists](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/Docs/custom-lists.md) for details on configuring levels.

    var listNumbered = document.AddList(WordListStyle.Heading1ai);
    listNumbered.AddItem("Different list number 1");
    listNumbered.AddItem("Different list number 2", 1);
    listNumbered.AddItem("Different list number 3", 1);
    listNumbered.AddItem("Different list number 4", 1);

    var section = document.AddSection();
    section.PageOrientation = PageOrientationValues.Landscape;
    section.PageSettings.PageSize = WordPageSize.A4;

    wordListToc.AddItem("Adding headers / footers");

    // lets add headers and footers
    document.AddHeadersAndFooters();

    // adding text to default header
    document.Header.Default.AddParagraph("Text added to header - Default");

    var section1 = document.AddSection();
    section1.PageOrientation = PageOrientationValues.Portrait;
    section1.PageSettings.PageSize = WordPageSize.A5;

    wordListToc.AddItem("Adding custom properties to document");

    document.CustomDocumentProperties.Add("TestProperty", new WordCustomProperty { Value = DateTime.Today });
    document.CustomDocumentProperties.Add("MyName", new WordCustomProperty("Some text"));
    document.CustomDocumentProperties.Add("IsTodayGreatDay", new WordCustomProperty(true));

    // document variables available via DocVariable fields
    document.SetDocumentVariable("Project", "OfficeIMO");
    document.SetDocumentVariable("Year", DateTime.Now.Year.ToString());

    if (document.HasDocumentVariables) {
        foreach (var pair in document.DocumentVariables) {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    document.Save(openWord);
}
```

## Pruebas

Además del hecho de que `OfficeIMO.Word` utiliza Pruebas Unitarias, también se usan [Pruebas de Caracterización](https://es.wikipedia.org/wiki/Prueba_de_caracterizaci%C3%B3n).
Las pruebas de caracterización se añadieron para no pasar por alto un cambio que rompa el comportamiento. Estas pruebas se basan en [Verify](https://github.com/VerifyTests/Verify) (["Snapshot Testing en .NET con Verify"](https://youtu.be/wA7oJDyvn4c)).
si necesitas añadir o actualizar una instantánea verificada, puedes usar el script de powershell:
```bash
$ pwsh -c ./Build/ApproveVerifyTests.ps1
```
Para mostrar una diferencia gráfica en lugar de la salida de consola cuando fallan las pruebas de Verificación, configure  
la variable de entorno `DiffEngine_Disabled=false` antes de ejecutar las pruebas.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---