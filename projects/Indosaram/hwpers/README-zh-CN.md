# hwpers

[![Crates.io](https://img.shields.io/crates/v/hwpers.svg)](https://crates.io/crates/hwpers)
[![Documentation](https://docs.rs/hwpers/badge.svg)](https://docs.rs/hwpers)
[![CI](https://github.com/Indosaram/hwpers/workflows/CI/badge.svg)](https://github.com/Indosaram/hwpers/actions)
[![License](https://img.shields.io/badge/license-MIT%2FApache--2.0-blue.svg)](LICENSE-MIT)

一个用于解析韩国韩文文字处理器（HWP）文件的 Rust 库，支持完整的布局渲染。

## 功能

### 解析器（读取 HWP 文件）
- **完整支持 HWP 5.0 格式**：解析所有文档组件，包括文本、格式、表格和嵌入对象
- **视觉布局渲染**：在有布局数据时，实现像素级精准文档重构
- **字体和样式保留**：提取并应用原始字体、大小、颜色和文本格式
- **高级布局引擎**：支持多栏布局、逐行定位和字符级格式化
- **SVG 导出**：将文档渲染为可缩放矢量图形
- **零拷贝解析**：高效解析，最小内存分配
- **安全的 Rust**：内存安全实现，全面的错误处理

### 写入器（创建 HWP 文件）- v0.3.0+
- **文档创建**：完整支持 HWP 文档写入
- **丰富文本格式**：加粗、斜体、颜色、字体、大小
- **表格**：创建、样式、单元格合并
- **列表**：项目符号、编号、韩文/字母/罗马格式
- **图片**：PNG/JPEG/BMP/GIF 及带标题
- **文本框**：定位和样式文本框
- **超链接**：URL、电子邮件、文件和书签链接
- **页眉/页脚**：页码和自定义内容
- **页面布局**：尺寸、边距、方向、栏数、背景

## 快速开始

将以下内容添加到你的 `Cargo.toml`：

```toml
[dependencies]
hwpers = "0.3"
```

### 基本用法

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

### 可视布局渲染

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
### 创建文档（v0.3.0+）


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

### 高级格式访问

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

## 支持的功能

### 文档结构
- ✅ 文件头和版本检测
- ✅ 文档属性和元数据
- ✅ 节定义和页面布局
- ✅ 段落和字符格式化
- ✅ 字体定义（FaceName）
- ✅ 样式和模板

### 内容类型
- ✅ 支持完整Unicode的文本内容
- ✅ 表格和结构化数据
- ✅ 控制对象（图像、OLE对象）
- ✅ 编号和项目符号列表
- ✅ 制表位和对齐

### 布局和渲染
- ✅ 页面尺寸和边距
- ✅ 多栏布局
- ✅ 按行定位（可用时）
- ✅ 字符级定位（可用时）
- ✅ 边框和填充图案
- ✅ 精确定位的SVG导出

### 高级功能
- ✅ 压缩文档支持
- ✅ CFB（复合文件二进制）格式处理
- ✅ 多种编码支持（UTF-16LE）
- ✅ 错误恢复和部分解析

## 命令行工具

该库包含一个用于检查HWP文件的命令行工具：

```bash
# Install the tool
cargo install hwpers

# Inspect an HWP file
hwp_info document.hwp
```

## 格式支持

本库支持 HWP 5.0 格式文件。对于更早版本的 HWP 格式，建议先使用格式转换工具。

## 写入器功能（v0.3.0+）

HWP 写入器功能得到了显著提升，支持全面的功能特性：

### ✅ 完全实现
- **超链接**：完整的超链接支持及正确的序列化
  - URL 链接、电子邮件链接、文件链接、书签
  - 每段支持多个超链接
  - 自定义样式（颜色、下划线、访问状态）
- **页眉/页脚**：完整的页眉和页脚实现
  - 自定义页眉/页脚文本
  - 多种格式的页码（数字、罗马数字等）
  - 每文档支持多个页眉/页脚
- **页面布局**：全面的页面布局控制
  - 自定义页面大小及标准尺寸（A4、信纸等）
  - 纵向/横向方向
  - 自定义页边距（窄、正常、宽、自定义）
  - 多栏布局及可调间距
  - 页面背景颜色
- **表格**：完整的表格创建与格式化
  - 单元格边框及样式
  - 单元格合并（横向和纵向）
  - 自定义单元格内容
- **列表/编号**：完整的列表支持
  - 不同层级的项目符号列表
  - 编号列表（1., 2., 3., ...）
  - 字母列表（a), b), c), ...）
  - 罗马数字列表（i., ii., iii., ...）
  - 韩文列表（가., 나., 다., ...）
  - 嵌套列表及正确缩进
- **文本框**：完整的文本框实现
  - 定位文本框
  - 样式文本框（高亮、警告、信息等）
  - 自定义样式（边框、背景、对齐）
  - 浮动文本框支持旋转及透明度
- **图片**：完整的图片插入功能  
  - 支持 PNG、JPEG、BMP、GIF  
  - 自定义尺寸和位置  
  - 图片说明文字  
  - 正确的 BinData 集成  
- **样式文本**：丰富的文本格式化  
  - 粗体、斜体、下划线、删除线  
  - 自定义字体和字号  
  - 文字颜色和背景颜色  
  - 单段落内多重样式  
- **高级格式**：  
  - 段落对齐（左对齐、居中、右对齐、两端对齐）  
  - 行距控制  
  - 段前/段后间距  
  - 自动调整大小的标题  
  - 字符和段落样式  
- **文档属性**：完整的元数据支持  
  - 标题、作者、主题、关键词  
  - 文档统计信息（字符数、字数等）  
  - 自动统计信息更新  

### ❌ 尚未实现  
- **形状/绘图**：几何形状和绘图对象  
  - 矩形、圆形、椭圆  
  - 直线、箭头、多边形  
  - 带样式的自定义形状  
  - 带文本内容的形状  
  - 形状分组  
  - *（参见 examples/shape_document.rs.disabled 中的用例）*  
- **图表/图形**：数据可视化对象  
- **数学公式**：MathML 支持  
- **表单**：输入字段和表单控件  
- **评论/批注**：审阅和评论功能  
- **修订**：修订历史  
- **邮件合并**：变量字段插入  

### 🔧 已知问题  
- 写入器不支持压缩（读取器支持压缩和非压缩）  
- 某些高级表格功能可能与较旧的 Hanword 版本存在兼容性问题  

## 贡献

欢迎贡献！请随时提交 Pull Request。对于重大更改，请先开启 issue 以讨论您想要更改的内容。

## 许可证

本项目授权协议为以下任意一种

- Apache 许可证 2.0 版，([LICENSE-APACHE](LICENSE-APACHE) 或 http://www.apache.org/licenses/LICENSE-2.0)
- MIT 许可证 ([LICENSE-MIT](LICENSE-MIT) 或 http://opensource.org/licenses/MIT)

由您选择。

## 致谢

- Hancom Inc. 提供的 HWP 文件格式规范
- 韩国文本处理社区
- Rust 解析和文档处理生态系统

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-13

---