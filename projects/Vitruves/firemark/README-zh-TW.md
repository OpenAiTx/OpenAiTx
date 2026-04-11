<div align="right">
  <details>
    <summary >🌐 語言</summary>
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

<p align="center">一款用 Rust 編寫的快速、單一可執行檔的影像與 PDF 浮水印工具。</p>


## 為什麼要對文件加浮水印？

每年，數百萬人因身份詐騙而受害，而這些詐騙往往始於一次簡單的文件交換。常見情境：你正在找房出租。房東——或冒充房東的人——要求你提供身分證、薪資單、稅單的副本。你毫無標記地發送出去。「房東」消失了，你的文件被用來開設銀行帳戶、申請貸款，或偽造你的身分。

對每一份你發送的文件加浮水印，是最有效的防禦方式。明顯的浮水印文字，例如 **「僅供 XYZ 機構 — 2026年3月 — 租屋申請使用」**，可讓文件對其他用途變得毫無價值。如果外洩，你也能精確追蹤來源。

firemark 讓這一切變得輕而易舉：一個指令，任意圖片或 PDF，17 種視覺風格，抗編輯的加密浮水印圖樣，以及可批次處理整個資料夾。

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="浮水印前後比較" width="800">
  <br>
  <em>加浮水印前後 —— 一個指令，文件即可追蹤且具防篡改特性。</em>
</p>

## 安裝

從 [crates.io](https://crates.io/crates/firemark) 取得：











```bash
cargo install firemark
```

從來源：

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```
產生單一最佳化的二進位檔（約 5 MB）。

## 快速開始


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
輸出會與輸入檔案一起儲存，預設為 `{name}-watermarked.{ext}`。
使用 `-o` 可設定明確的輸出路徑，或用 `-S` 設定自訂後綴。

## 浮水印類型

| 旗標 | 樣式 | 說明 |
|---|---|---|
| `diagonal` | 斜對角格網 | 全頁重複斜對角文字（預設） |
| `stamp` | 橡皮圖章 | 大型居中圖章，雙層邊框 |
| `stencil` | 模板字 | 全寬軍用模板字母 |
| `typewriter` | 打字機 | 等寬打字機文字 |
| `handwritten` | 手寫簽名 | 帶底線的手寫風格簽名 |
| `redacted` | 編輯遮蔽 | 全寬黑色遮蔽條 |
| `badge` | 徽章盾牌 | 安全盾牌／徽章圖案 |
| `ribbon` | 緞帶 | 斜角角落緞帶橫幅 |
| `seal` | 印章 | 圓形公證印章風格 |
| `frame` | 邊框 | 全頁裝飾邊框 |
| `tile` | 瓦片 | 密集均勻文字格網 |
| `mosaic` | 馬賽克 | 隨機散佈文字 |
| `weave` | 編織 | 交錯斜對角編織 |
| `ghost` | 幽靈 | 超淡浮雕文字 |
| `watercolor` | 水彩 | 柔和模糊水洗效果 |
| `noise` | 噪點 | 文字加像素噪點 |
| `halftone` | 網點 | 文字以網點格網顯示 |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```
## 安全浮水印

firemark 疊加了受鈔票安全特徵啟發的加密浮水印圖案。這些精細的幾何圖案極難被圖像編輯器去除。

| 樣式 | 說明 |
|---|---|
| `guilloche` | 正弦波包絡帶（預設） |
| `rosette` | 螺旋儀圖形＋角落玫瑰曲線 |
| `crosshatch` | 細緻的斜向菱形格紋 |
| `border` | 波浪狀多層安全邊框 |
| `lissajous` | 參數化 Lissajous 圖形 |
| `moire` | 同心圓干涉圖案 |
| `spiral` | 阿基米德螺旋渦旋 |
| `mesh` | 六角蜂巢格紋 |
| `plume` | 彷彿羽毛流動般的曲線散佈於表面 |
| `constellation` | 星點由精細幾何網路連接 |
| `ripple` | 來自隨機起點的橢圓波前重疊 |
| `full` | 所有圖案組合 |
| `none` | 停用浮水印 |




```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## AI 移除防護強化

每次渲染預設都是非決定性的。firemark 會套用通用的渲染後擾動（alpha 抖動、次像素色彩雜訊、邊緣微點、
稀疏幽靈像素）以及每個渲染器的隨機化，確保即使設定相同，也不會有兩個輸出是像素級一致的。這讓 AI
視覺模型無法學習可預測的減除模式。

此外，對抗性提示注入條帶會預設嵌入，以干擾 AI 浮水印移除工具。如果你不需要可見的提示文字，請使用 `--no-anti-ai` 停用：





```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## 常用選項

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

如需完整的 70+ 旗標列表，請參閱 [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md)。

## PDF 選項

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## 批次處理

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```
已加浮水印的檔案（符合副檔名）在重新執行時會自動跳過。

## 設定檔

將選項儲存在 TOML 檔案中，以避免重複輸入旗標。請參閱
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) 以取得完整範例，
其中包含兩種預設：**ultra-secure**（高密度鋪排、完整浮水印、QR 可追蹤、移除中繼資料）與 **light**（簡單斜體文字，無額外功能）。




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
## 格式支援

| 格式 | 輸入 | 輸出 |
|---|---|---|
| PNG | 是 | 是 |
| JPEG | 是 | 是 |
| PDF | 是 | 是 |
| WebP | 是 | 是 |
| TIFF | 是 | 是 |

支援跨格式轉換（例如：`firemark photo.webp -o out.pdf`）。

## 授權

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---