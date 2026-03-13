# hwpers

[![Crates.io](https://img.shields.io/crates/v/hwpers.svg)](https://crates.io/crates/hwpers)
[![Documentation](https://docs.rs/hwpers/badge.svg)](https://docs.rs/hwpers)
[![CI](https://github.com/Indosaram/hwpers/workflows/CI/badge.svg)](https://github.com/Indosaram/hwpers/actions)
[![License](https://img.shields.io/badge/license-MIT%2FApache--2.0-blue.svg)](LICENSE-MIT)

A Rust library for parsing Korean Hangul Word Processor (HWP) files with full layout rendering support.

## Features

### Parser (Reading HWP files)
- **Complete HWP 5.0 Format Support**: Parse all document components including text, formatting, tables, and embedded objects
- **Visual Layout Rendering**: Reconstruct documents with pixel-perfect accuracy when layout data is available
- **Font and Style Preservation**: Extract and apply original fonts, sizes, colors, and text formatting
- **Advanced Layout Engine**: Support for multi-column layouts, line-by-line positioning, and character-level formatting
- **SVG Export**: Render documents to scalable vector graphics
- **Zero-copy Parsing**: Efficient parsing with minimal memory allocation
- **Safe Rust**: Memory-safe implementation with comprehensive error handling

### Writer (Creating HWP files) - v0.3.0+
- **Document Creation**: Full HWP document writing support
- **Rich Text Formatting**: Bold, italic, colors, fonts, sizes
- **Tables**: Creation, styling, cell merging
- **Lists**: Bullets, numbering, Korean/alphabetic/roman formats
- **Images**: PNG/JPEG/BMP/GIF with captions
- **Text Boxes**: Positioned and styled text boxes
- **Hyperlinks**: URL, email, file, and bookmark links
- **Headers/Footers**: Page numbers and custom content
- **Page Layout**: Sizes, margins, orientation, columns, backgrounds

## Quick Start

Add this to your `Cargo.toml`:

```toml
[dependencies]
hwpers = "0.3"
```

### Basic Usage

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

### Visual Layout Rendering

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

### Creating Documents (v0.3.0+)

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

### Advanced Formatting Access

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

## Supported Features

### Document Structure
- ✅ File header and version detection
- ✅ Document properties and metadata
- ✅ Section definitions and page layout
- ✅ Paragraph and character formatting
- ✅ Font definitions (FaceName)
- ✅ Styles and templates

### Content Types
- ✅ Text content with full Unicode support
- ✅ Tables and structured data
- ✅ Control objects (images, OLE objects)
- ✅ Numbering and bullet lists
- ✅ Tab stops and alignment

### Layout and Rendering
- ✅ Page dimensions and margins
- ✅ Multi-column layouts
- ✅ Line-by-line positioning (when available)
- ✅ Character-level positioning (when available)
- ✅ Borders and fill patterns
- ✅ SVG export with accurate positioning

### Advanced Features
- ✅ Compressed document support
- ✅ CFB (Compound File Binary) format handling
- ✅ Multiple encoding support (UTF-16LE)
- ✅ Error recovery and partial parsing

## Command Line Tool

The library includes a command-line tool for inspecting HWP files:

```bash
# Install the tool
cargo install hwpers

# Inspect an HWP file
hwp_info document.hwp
```

## Format Support

This library supports HWP 5.0 format files. For older HWP formats, consider using format conversion tools first.

## Writer Features (v0.3.0+)

The HWP writer functionality has been significantly improved with comprehensive feature support:

### ✅ Fully Implemented
- **Hyperlinks**: Complete hyperlink support with proper serialization
  - URL links, email links, file links, bookmarks
  - Multiple hyperlinks per paragraph
  - Custom styling (colors, underline, visited state)
- **Header/Footer**: Full header and footer implementation
  - Custom header/footer text
  - Page numbering with multiple formats (numeric, roman, etc.)
  - Multiple headers/footers per document
- **Page Layout**: Comprehensive page layout control
  - Custom page sizes and standard sizes (A4, Letter, etc.)
  - Portrait/landscape orientation
  - Custom margins (narrow, normal, wide, custom)
  - Multi-column layouts with adjustable spacing
  - Page background colors
- **Tables**: Full table creation and formatting
  - Cell borders and styling
  - Cell merging (horizontal and vertical)
  - Custom cell content
- **Lists/Numbering**: Complete list support
  - Bullet lists with different symbols per level
  - Numbered lists (1., 2., 3., ...)
  - Alphabetic lists (a), b), c), ...)
  - Roman numeral lists (i., ii., iii., ...)
  - Korean lists (가., 나., 다., ...)
  - Nested lists with proper indentation
- **Text Boxes**: Full text box implementation
  - Positioned text boxes
  - Styled text boxes (highlight, warning, info, etc.)
  - Custom styling (borders, backgrounds, alignment)
  - Floating text boxes with rotation and transparency
- **Images**: Complete image insertion
  - PNG, JPEG, BMP, GIF support
  - Custom dimensions and positioning
  - Image captions
  - Proper BinData integration
- **Styled Text**: Rich text formatting
  - Bold, italic, underline, strikethrough
  - Custom fonts and sizes
  - Text colors and background colors
  - Multiple styles in single paragraph
- **Advanced Formatting**:
  - Paragraph alignment (left, center, right, justify)
  - Line spacing control
  - Paragraph spacing (before/after)
  - Headings with automatic sizing
  - Character and paragraph styles
- **Document Properties**: Full metadata support
  - Title, author, subject, keywords
  - Document statistics (character count, word count, etc.)
  - Automatic statistics updates

### ❌ Not Yet Implemented
- **Shapes/Drawing**: Geometric shapes and drawing objects
  - Rectangles, circles, ellipses
  - Lines, arrows, polygons
  - Custom shapes with styling
  - Shapes with text content
  - Shape grouping
  - *(See examples/shape_document.rs.disabled for usage examples)*
- **Charts/Graphs**: Data visualization objects
- **Mathematical Equations**: MathML support
- **Forms**: Input fields and form controls
- **Comments/Annotations**: Review and comment features
- **Track Changes**: Revision history
- **Mail Merge**: Variable field insertion

### 🔧 Known Issues
- No compression support for writer (reader supports both compressed and uncompressed)
- Some advanced table features may have compatibility issues with older Hanword versions

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under either of

- Apache License, Version 2.0, ([LICENSE-APACHE](LICENSE-APACHE) or http://www.apache.org/licenses/LICENSE-2.0)
- MIT license ([LICENSE-MIT](LICENSE-MIT) or http://opensource.org/licenses/MIT)

at your option.

## Acknowledgments

- HWP file format specification by Hancom Inc.
- Korean text processing community
- Rust parsing and document processing ecosystem