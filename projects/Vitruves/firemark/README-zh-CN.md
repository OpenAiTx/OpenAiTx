
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/firemark.png" alt="firemark" width="200">
</p>

<h1 align="center">firemark</h1>

<p align="center">一个用于图片和PDF的快速、单文件水印工具。使用Rust构建。</p>

## 为什么要为您的文档加水印？

每年，数百万人因一份简单的文件交换而成为身份欺诈的受害者。
常见场景：您正在找房租赁。
房东——或冒充房东的人——要求您提供身份证、工资单、税单的复印件。
您未做任何标记就发送了这些文件。
“房东”消失后，您的文件便被用来开设银行账户、申请贷款，或伪造您的身份。

为您发送的每一份文件加水印是最有效的防护措施。
一个可见的覆盖层，写着**“发送给XYZ机构——2026年3月——仅限租房申请”**，让该文件对其他用途毫无价值。
如果文件泄露，您能准确追踪来源。

firemark让这一切变得轻松：一条命令，支持任意图片或PDF，17种视觉风格，抗篡改的加密水印图案，并支持整个文件夹的批量处理。

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="加水印前后对比" width="800">
  <br>
  <em>加水印前后——只需一条命令，文档即可追踪且篡改可见。</em>
</p>

## 安装

从 [crates.io](https://crates.io/crates/firemark) 获取：





```bash
cargo install firemark
```
来自源头：


```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```

生成一个单一的优化二进制文件（约5 MB）。

## 快速开始

```bash
# Watermark a single image
firemark photo_id.png -m "Flat rental — SCI Dupont — March 2026"

# Watermark a PDF
firemark tax_notice.pdf -m "CONFIDENTIAL" -s "Do not distribute"

# Watermark an entire folder recursively
firemark ./documents/ -R -m "Sent to Agency X" -t stamp

# Preview without writing files
firemark id_card.jpg -m "Draft" -n
```
输出默认保存在与输入文件相同目录下，文件名为 `{name}-watermarked.{ext}`。  
使用 `-o` 可设置明确的输出路径，或用 `-S` 指定自定义后缀。  

## 水印类型  

| 标志 | 样式 | 描述 |  
|---|---|---|  
| `diagonal` | 斜线网格 | 全页重复斜向文字（默认） |  
| `stamp` | 印章 | 大型居中印章，带双重边框 |  
| `stencil` | 模板 | 全宽军事模板字体 |  
| `typewriter` | 打字机 | 等宽打字机字体 |  
| `handwritten` | 签名 | 手写风格签名并带下划线 |  
| `redacted` | 涂黑 | 全宽黑色涂黑条 |  
| `badge` | 徽章 | 安全盾牌/徽章标志 |  
| `ribbon` | 缎带 | 斜角缎带横幅 |  
| `seal` | 印章 | 圆形公证风格印章 |  
| `frame` | 边框 | 全页装饰边框 |  
| `tile` | 瓷砖 | 密集均匀文字网格 |  
| `mosaic` | 马赛克 | 随机散布文字 |  
| `weave` | 编织 | 交错斜向编织 |  
| `ghost` | 幽灵 | 极其细微浮雕文字 |  
| `watercolor` | 水彩 | 柔和模糊水彩效果 |  
| `noise` | 噪点 | 像素噪点扰乱文字 |  
| `halftone` | 半色调 | 点阵半色调文字 |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```
## 安全水印

firemark 覆盖了受钞票安全特征启发的加密水印图案。  
这些精细的几何图案极难被图像编辑器移除。

| 样式 | 描述 |
|---|---|
| `guilloche` | 正弦波包络带（默认） |
| `rosette` | 斯比罗图 + 角玫瑰曲线 |
| `crosshatch` | 细斜对角菱形格网 |
| `border` | 波浪嵌套安全边框 |
| `lissajous` | 参数化利萨茹图形 |
| `moire` | 同心圆干涉 |
| `spiral` | 阿基米德螺旋涡旋 |
| `mesh` | 六边形蜂巢网格 |
| `plume` | 散布在表面的流动羽毛状曲线 |
| `constellation` | 由细几何网连接的星节点 |
| `ripple` | 来自随机起点的重叠椭圆波前 |
| `full` | 所有图案组合 |
| `none` | 禁用水印 |



```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## AI去除加固

每次渲染默认都是非确定性的。firemark应用通用的
渲染后扰动（alpha抖动、亚像素色噪、边缘微点、
稀疏幽灵像素）和每个渲染器的随机化，确保没有两个输出
像素完全相同——即使设置相同。这使得AI
视觉模型无法学习可预测的模式来进行去除。

除此之外，默认嵌入对抗性提示注入条以
混淆AI水印去除工具。如果不想显示提示文本，可用`--no-anti-ai`禁用：


```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## 常用选项

```
-m, --main-text           Primary watermark text
-s, --secondary-text      Secondary text line
-t, --type                Watermark style (see table above)
-o, --output              Output file path
-S, --suffix              Custom output suffix (default: "watermarked")
-c, --color               Color — name or #RRGGBB (default: blue)
-O, --opacity             Opacity 0.0–1.0 (default: 0.5)
-r, --rotation            Angle in degrees (default: -45)
-p, --position            center, top-left, top-right, bottom-left, bottom-right, tile
-f, --font                Font name or path to .ttf/.otf
-I, --image               Overlay an image as watermark
    --qr-data             Embed a QR code with custom data
    --qr-code-position    QR code placement (default: center)
    --qr-code-size        QR code size in pixels (default: auto)
    --border              Draw a border around the watermark
    --shadow              Add a drop shadow
    --filigrane           Security filigrane style (default: guilloche)
    --no-anti-ai          Disable adversarial prompt injection (on by default)
```

完整的70多个标志列表，请参见 [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md)。

## PDF 选项

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## 批处理

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```
已经带有水印的文件（匹配后缀）在重新运行时会自动跳过。

## 配置文件

将选项保存在 TOML 文件中，以避免重复输入参数。请参见
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) 获取包含两个预设的完整示例：**超安全**（密集铺设，完整水印，二维码可追踪，元数据清除）和**轻量**（简单对角文本，无额外功能）。





```toml
# Global defaults
main_text = "CONFIDENTIAL"
secondary_text = "{author} — {date}"
watermark_type = "diagonal"
color = "#1a3c6e"
opacity = 0.45
font_weight = "bold"
filigrane = "guilloche"
border = true

[preset.ultra-secure]
main_text = "CONFIDENTIAL — {author}"
watermark_type = "tile"
color = "#CC0000"
opacity = 0.6
filigrane = "full"
anti_ai = true
qr_data = "firemark://{author}/{timestamp}/{uuid}"
strip_metadata = true

[preset.light]
main_text = "COPY"
watermark_type = "diagonal"
color = "#555555"
opacity = 0.3
filigrane = "none"
anti_ai = false
```

```bash
firemark doc.pdf --config firemark.toml
firemark doc.pdf --config firemark.toml --preset ultra-secure
firemark doc.pdf --config firemark.toml --preset light
firemark doc.pdf --save-preset mypreset    # save current flags
firemark --list-presets                     # list available presets
```

## 格式支持

| 格式 | 输入 | 输出 |
|---|---|---|
| PNG | 是 | 是 |
| JPEG | 是 | 是 |
| PDF | 是 | 是 |
| WebP | 是 | 是 |
| TIFF | 是 | 是 |

支持跨格式转换（例如 `firemark photo.webp -o out.pdf`）。

## 许可证

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---