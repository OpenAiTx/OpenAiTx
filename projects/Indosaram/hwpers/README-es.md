# hwpers

[![Crates.io](https://img.shields.io/crates/v/hwpers.svg)](https://crates.io/crates/hwpers)
[![Documentation](https://docs.rs/hwpers/badge.svg)](https://docs.rs/hwpers)
[![CI](https://github.com/Indosaram/hwpers/workflows/CI/badge.svg)](https://github.com/Indosaram/hwpers/actions)
[![License](https://img.shields.io/badge/license-MIT%2FApache--2.0-blue.svg)](LICENSE-MIT)

Una biblioteca Rust para analizar archivos coreanos Hangul Word Processor (HWP) con soporte completo para renderizado de diseño.

## Características

### Analizador (Lectura de archivos HWP)
- **Soporte completo del formato HWP 5.0**: Analiza todos los componentes del documento incluyendo texto, formato, tablas y objetos incrustados
- **Renderizado visual de diseño**: Reconstruye documentos con precisión de píxel cuando hay datos de diseño disponibles
- **Preservación de fuente y estilo**: Extrae y aplica las fuentes originales, tamaños, colores y formato de texto
- **Motor avanzado de diseño**: Soporte para diseños de múltiples columnas, posicionamiento línea por línea y formato a nivel de carácter
- **Exportación SVG**: Renderiza documentos a gráficos vectoriales escalables
- **Análisis sin copias**: Análisis eficiente con asignación mínima de memoria
- **Rust seguro**: Implementación segura en memoria con manejo completo de errores

### Escritor (Creación de archivos HWP) - v0.3.0+
- **Creación de documentos**: Soporte completo para escritura de documentos HWP
- **Formato de texto enriquecido**: Negrita, cursiva, colores, fuentes, tamaños
- **Tablas**: Creación, estilo, combinación de celdas
- **Listas**: Viñetas, numeración, formatos coreano/alfabético/romano
- **Imágenes**: PNG/JPEG/BMP/GIF con leyendas
- **Cuadros de texto**: Cuadros de texto posicionados y estilizados
- **Hipervínculos**: Enlaces URL, correo electrónico, archivos y marcadores
- **Encabezados/Pies de página**: Números de página y contenido personalizado
- **Diseño de página**: Tamaños, márgenes, orientación, columnas, fondos

## Inicio rápido

Agrega esto a tu `Cargo.toml`:

```toml
[dependencies]
hwpers = "0.3"
```

### Uso Básico

```rust
use hwpers::HwpReader;

// Parse an HWP file
let document = HwpReader::from_file("document.hwp")?;

// Extract text content
let text = document.extract_text();
println!("{}", text);

// Access document properties
if let Some(props) = document.get_properties() {
    println!("Pages: {}", props.total_page_count);
}

// Iterate through sections and paragraphs
for (i, section) in document.sections().enumerate() {
    println!("Section {}: {} paragraphs", i, section.paragraphs.len());
    
    for paragraph in &section.paragraphs {
        if let Some(text) = &paragraph.text {
            println!("  {}", text.content);
        }
    }
}
```

### Renderizado del Diseño Visual

```rust
use hwpers::{HwpReader, render::{HwpRenderer, RenderOptions}};

let document = HwpReader::from_file("document.hwp")?;

// Create renderer with custom options
let options = RenderOptions {
    dpi: 96,
    scale: 1.0,
    show_margins: false,
    show_baselines: false,
};

let renderer = HwpRenderer::new(&document, options);
let result = renderer.render();

// Export first page to SVG
if let Some(svg) = result.to_svg(0) {
    std::fs::write("page1.svg", svg)?;
}

println!("Rendered {} pages", result.pages.len());
```

### Creación de Documentos (v0.3.0+)

```rust
use hwpers::writer::HwpWriter;
use hwpers::model::hyperlink::Hyperlink;

// Create a new document
let mut writer = HwpWriter::new();

// Add formatted text
writer.add_aligned_paragraph(
    "제목",
    hwpers::writer::style::ParagraphAlignment::Center
)?;

// Add hyperlinks
let link = Hyperlink::new_url("Rust", "https://rust-lang.org");
writer.add_paragraph_with_hyperlinks(
    "Visit Rust website",
    vec![link]
)?;

// Configure page layout
writer.set_custom_page_size(210.0, 297.0, // A4 size
    hwpers::model::page_layout::PageOrientation::Portrait)?;
writer.set_page_margins_mm(20.0, 20.0, 20.0, 20.0);

// Add header and footer
writer.add_header("Document Header");
writer.add_footer_with_page_number("Page ", 
    hwpers::model::header_footer::PageNumberFormat::Numeric);

// Save the document
writer.save_to_file("output.hwp")?;
```
### Acceso a Formateo Avanzado


```rust
// Access character and paragraph formatting
for section in document.sections() {
    for paragraph in &section.paragraphs {
        // Get paragraph formatting
        if let Some(para_shape) = document.get_para_shape(paragraph.para_shape_id as usize) {
            println!("Indent: {}, Alignment: {}", 
                para_shape.indent, 
                para_shape.get_alignment()
            );
        }
        
        // Get character formatting runs
        if let Some(char_shapes) = &paragraph.char_shapes {
            for pos_shape in &char_shapes.char_positions {
                if let Some(char_shape) = document.get_char_shape(pos_shape.char_shape_id as usize) {
                    println!("Position {}: Size {}, Bold: {}", 
                        pos_shape.position,
                        char_shape.base_size / 100,
                        char_shape.is_bold()
                    );
                }
            }
        }
    }
}
```

## Funciones Soportadas

### Estructura del Documento
- ✅ Encabezado de archivo y detección de versión
- ✅ Propiedades y metadatos del documento
- ✅ Definiciones de secciones y diseño de página
- ✅ Formato de párrafo y de caracteres
- ✅ Definiciones de fuentes (FaceName)
- ✅ Estilos y plantillas

### Tipos de Contenido
- ✅ Contenido de texto con soporte completo Unicode
- ✅ Tablas y datos estructurados
- ✅ Objetos de control (imágenes, objetos OLE)
- ✅ Listas numeradas y con viñetas
- ✅ Tabulaciones y alineación

### Diseño y Renderizado
- ✅ Dimensiones de página y márgenes
- ✅ Diseños de múltiples columnas
- ✅ Posicionamiento línea por línea (cuando está disponible)
- ✅ Posicionamiento a nivel de carácter (cuando está disponible)
- ✅ Bordes y patrones de relleno
- ✅ Exportación SVG con posicionamiento preciso

### Funciones Avanzadas
- ✅ Soporte de documentos comprimidos
- ✅ Manejo del formato CFB (Archivo Binario Compuesto)
- ✅ Soporte múltiple de codificación (UTF-16LE)
- ✅ Recuperación de errores y análisis parcial

## Herramienta de Línea de Comandos

La biblioteca incluye una herramienta de línea de comandos para inspeccionar archivos HWP:

```bash
# Install the tool
cargo install hwpers

# Inspect an HWP file
hwp_info document.hwp
```
## Soporte de Formato

Esta biblioteca soporta archivos en formato HWP 5.0. Para formatos HWP más antiguos, considere usar herramientas de conversión de formato primero.

## Funciones del Escritor (v0.3.0+)

La funcionalidad del escritor HWP ha sido mejorada significativamente con soporte integral de características:

### ✅ Completamente Implementado
- **Hipervínculos**: Soporte completo de hipervínculos con serialización adecuada
  - Enlaces URL, enlaces de correo electrónico, enlaces a archivos, marcadores
  - Múltiples hipervínculos por párrafo
  - Estilización personalizada (colores, subrayado, estado visitado)
- **Encabezado/Pie de página**: Implementación completa de encabezados y pies de página
  - Texto personalizado para encabezado/pie de página
  - Numeración de páginas con múltiples formatos (numérico, romano, etc.)
  - Múltiples encabezados/pies de página por documento
- **Diseño de Página**: Control integral del diseño de página
  - Tamaños de página personalizados y tamaños estándar (A4, Carta, etc.)
  - Orientación vertical/horizontal
  - Márgenes personalizados (estrecho, normal, amplio, personalizado)
  - Diseños de múltiples columnas con espaciado ajustable
  - Colores de fondo de página
- **Tablas**: Creación y formateo completo de tablas
  - Bordes y estilización de celdas
  - Combinación de celdas (horizontal y vertical)
  - Contenido personalizado en celdas
- **Listas/Numeración**: Soporte completo para listas
  - Listas con viñetas con diferentes símbolos por nivel
  - Listas numeradas (1., 2., 3., ...)
  - Listas alfabéticas (a), b), c), ...)
  - Listas con números romanos (i., ii., iii., ...)
  - Listas coreanas (가., 나., 다., ...)
  - Listas anidadas con sangría adecuada
- **Cuadros de Texto**: Implementación completa de cuadros de texto
  - Cuadros de texto posicionados
  - Cuadros de texto estilizados (resaltado, advertencia, información, etc.)
  - Estilización personalizada (bordes, fondos, alineación)
  - Cuadros de texto flotantes con rotación y transparencia

- **Imágenes**: Inserción completa de imágenes  
  - Soporte para PNG, JPEG, BMP, GIF  
  - Dimensiones y posicionamiento personalizados  
  - Leyendas para imágenes  
  - Integración adecuada con BinData  
- **Texto con estilo**: Formato de texto enriquecido  
  - Negrita, cursiva, subrayado, tachado  
  - Fuentes y tamaños personalizados  
  - Colores de texto y colores de fondo  
  - Múltiples estilos en un solo párrafo  
- **Formato avanzado**:  
  - Alineación de párrafos (izquierda, centro, derecha, justificado)  
  - Control de interlineado  
  - Espaciado de párrafo (antes/después)  
  - Encabezados con tamaño automático  
  - Estilos de carácter y de párrafo  
- **Propiedades del documento**: Soporte completo de metadatos  
  - Título, autor, asunto, palabras clave  
  - Estadísticas del documento (conteo de caracteres, conteo de palabras, etc.)  
  - Actualizaciones automáticas de estadísticas  

### ❌ Aún no implementado  
- **Formas/Dibujo**: Formas geométricas y objetos de dibujo  
  - Rectángulos, círculos, elipses  
  - Líneas, flechas, polígonos  
  - Formas personalizadas con estilo  
  - Formas con contenido de texto  
  - Agrupación de formas  
  - *(Ver examples/shape_document.rs.disabled para ejemplos de uso)*  
- **Gráficos/Diagramas**: Objetos de visualización de datos  
- **Ecuaciones matemáticas**: Soporte MathML  
- **Formularios**: Campos de entrada y controles de formulario  
- **Comentarios/Anotaciones**: Funciones de revisión y comentarios  
- **Control de cambios**: Historial de revisiones  
- **Combinar correspondencia**: Inserción de campos variables  

### 🔧 Problemas conocidos  
- No hay soporte de compresión para el escritor (el lector soporta comprimido y sin comprimir)  
- Algunas funciones avanzadas de tablas pueden tener problemas de compatibilidad con versiones antiguas de Hanword  

## Contribuir

¡Las contribuciones son bienvenidas! No dude en enviar una Pull Request. Para cambios importantes, por favor abra un issue primero para discutir lo que desea cambiar.

## Licencia

Este proyecto está licenciado bajo cualquiera de

- Licencia Apache, Versión 2.0, ([LICENSE-APACHE](LICENSE-APACHE) o http://www.apache.org/licenses/LICENSE-2.0)
- Licencia MIT ([LICENSE-MIT](LICENSE-MIT) o http://opensource.org/licenses/MIT)

a su elección.

## Agradecimientos

- Especificación del formato de archivo HWP por Hancom Inc.
- Comunidad de procesamiento de texto coreano
- Ecosistema de análisis y procesamiento de documentos en Rust

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-13

---