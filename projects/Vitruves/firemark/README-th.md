<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

<p align="center">เครื่องมือวอเตอร์มาร์คภาพและ PDF ที่รวดเร็วและเป็นไฟล์เดียว สร้างด้วยภาษา Rust</p>


## ทำไมต้องติดลายน้ำเอกสารของคุณ?

ในแต่ละปี มีผู้คนหลายล้านคนตกเป็นเหยื่อของการฉ้อโกงข้อมูลส่วนตัวที่เริ่มต้นจากการแลกเปลี่ยนเอกสารง่ายๆ หนึ่งฉบับ ตัวอย่างที่พบบ่อย: คุณกำลังมองหาห้องเช่า เจ้าของห้อง — หรือผู้ที่แอบอ้างเป็นเจ้าของ — ขอสำเนาบัตรประชาชน สลิปเงินเดือน หรือใบแจ้งภาษี คุณส่งให้โดยไม่ทำเครื่องหมาย เอกสารของคุณถูกใช้เปิดบัญชีธนาคาร กู้เงิน หรือปลอมแปลงตัวตนในนามของคุณ

การติดลายน้ำบนเอกสารทุกฉบับที่คุณส่งออกไปคือวิธีป้องกันที่ได้ผลที่สุด เครื่องหมายทับที่มองเห็นได้ เช่น **"ส่งให้สำนักงาน XYZ — มีนาคม 2026 — ใช้เฉพาะสมัครเช่าห้องเท่านั้น"** ทำให้เอกสารนั้นไม่มีค่าสำหรับวัตถุประสงค์อื่น หากเอกสารถูกเผยแพร่ คุณจะทราบทันทีว่าแหล่งที่มาคือที่ใด

firemark ช่วยให้เรื่องนี้เป็นเรื่องง่าย: คำสั่งเดียว รองรับทั้งรูปภาพหรือ PDF มีสไตล์ให้เลือก 17 แบบ ลวดลายฟิลิกรีเข้ารหัสที่ต้านทานการแก้ไข และรองรับการประมวลผลทั้งโฟลเดอร์

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="ก่อนและหลังติดลายน้ำ" width="800">
  <br>
  <em>ก่อนและหลัง — แค่คำสั่งเดียว เอกสารถูกติดตามและตรวจสอบการแก้ไขได้ทันที</em>
</p>

## วิธีติดตั้ง

จาก [crates.io](https://crates.io/crates/firemark):











```bash
cargo install firemark
```

จากแหล่งที่มา:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```
สร้างไฟล์ไบนารีเดียวที่ได้รับการปรับแต่งให้เหมาะสม (~5 MB)

## เริ่มต้นอย่างรวดเร็ว


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
ผลลัพธ์จะถูกบันทึกไว้ข้างไฟล์ต้นฉบับในรูปแบบ `{name}-watermarked.{ext}` โดยค่าเริ่มต้น
ใช้ `-o` เพื่อกำหนดเส้นทางไฟล์ผลลัพธ์โดยตรง หรือ `-S` สำหรับกำหนดคำต่อท้ายแบบกำหนดเอง

## ประเภทลายน้ำ

| Flag | Style | คำอธิบาย |
|---|---|---|
| `diagonal` | ตะแกรงแนวทแยง | ข้อความซ้ำแนวทแยงเต็มหน้า (ค่าเริ่มต้น) |
| `stamp` | ตราประทับ | ตราประทับขนาดใหญ่ตรงกลางพร้อมขอบสองชั้น |
| `stencil` | ลายฉลุ | ตัวอักษรลายฉลุทหารเต็มความกว้าง |
| `typewriter` | เครื่องพิมพ์ดีด | ข้อความแบบฟอนต์คงที่เหมือนเครื่องพิมพ์ดีด |
| `handwritten` | ลายมือเซ็น | ลายมือเซ็นสไตล์เขียนมือพร้อมขีดเส้นใต้ |
| `redacted` | ปกปิด | แถบปกปิดสีดำเต็มความกว้าง |
| `badge` | โล่ | ตราสัญลักษณ์โล่ความปลอดภัย |
| `ribbon` | ริบบิ้น | แถบริบบิ้นเฉียงตรงมุม |
| `seal` | ตราประทับกลม | ตราประทับกลมแบบโนตารี |
| `frame` | กรอบ | กรอบตกแต่งเต็มหน้า |
| `tile` | กระเบื้อง | ตารางข้อความหนาแน่นสม่ำเสมอ |
| `mosaic` | โมเสก | ข้อความกระจายแบบสุ่มทั่วหน้า |
| `weave` | สาน | ลายสานแนวทแยงไขว้กัน |
| `ghost` | เงา | ข้อความนูนจางพิเศษ |
| `watercolor` | สีน้ำ | เอฟเฟกต์ล้างสีเบลออ่อนนุ่ม |
| `noise` | รบกวน | ข้อความหยาบด้วยจุดรบกวนพิกเซล |
| `halftone` | จุดราสีเทา | ข้อความแบบตารางจุดราสีเทา |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## ลายน้ำเพื่อความปลอดภัย

firemark ซ้อนทับลายฟิลีกรานแบบเข้ารหัสที่ได้รับแรงบันดาลใจจากคุณสมบัติความปลอดภัยของธนบัตร ลวดลายเรขาคณิตละเอียดเหล่านี้ลบออกได้ยากมากด้วยโปรแกรมแก้ไขภาพ

| สไตล์ | คำอธิบาย |
|---|---|
| `guilloche` | แถบคลื่นไซนูซอยด์แบบซ้อนกัน (ค่าเริ่มต้น) |
| `rosette` | เส้นกราฟสไปโรกราฟ + เส้นโค้งกุหลาบที่มุม |
| `crosshatch` | ตาข่ายข้าวหลามตัดแนวทแยงละเอียด |
| `border` | เส้นขอบนิรภัยแบบคลื่นซ้อนกันหลายชั้น |
| `lissajous` | รูปแบบพาราเมตริก Lissajous |
| `moire` | ลวดลายแทรกสอดวงกลมร่วมศูนย์กลาง |
| `spiral` | วงวนสไปรัลแบบอาร์คีมีดีนส์ |
| `mesh` | ตาข่ายรังผึ้งหกเหลี่ยม |
| `plume` | เส้นโค้งคล้ายขนนกไหลกระจายทั่วพื้นผิว |
| `constellation` | โหนดรูปดาวเชื่อมต่อด้วยเส้นเรขาคณิตละเอียด |
| `ripple` | แนวคลื่นวงรีซ้อนกันจากจุดกำเนิดสุ่ม |
| `full` | รวมลวดลายทั้งหมด |
| `none` | ปิดการใช้งานฟิลีกราน |



```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## การเสริมความแข็งแกร่งต่อการลบโดย AI

ทุกการเรนเดอร์จะเป็นแบบไม่กำหนดค่าล่วงหน้าโดยอัตโนมัติ firemark ใช้การรบกวนหลังเรนเดอร์แบบสากล (จิตเตอร์อัลฟา, สัญญาณรบกวนสีระดับซับพิกเซล, จุดขนาดเล็กที่ขอบ, พิกเซลผีแบบกระจัดกระจาย) และการสุ่มต่อเรนเดอร์แต่ละตัว เพื่อให้ไม่มีผลลัพธ์ใดที่เหมือนกันเป๊ะทุกพิกเซล — แม้จะตั้งค่าทุกอย่างเหมือนกันก็ตาม สิ่งนี้ทำให้แบบจำลองการมองเห็นของ AI ไม่สามารถเรียนรู้รูปแบบที่ทำนายได้เพื่อหักลบ

นอกจากนี้ แถบฉีดคำสั่งเชิงปฏิปักษ์จะถูกฝังอยู่โดยอัตโนมัติเพื่อสร้างความสับสนให้กับเครื่องมือของ AI ที่ใช้ลบลายน้ำ หากไม่ต้องการข้อความคำสั่งที่มองเห็นได้ ให้ปิดด้วย `--no-anti-ai`:







```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## ตัวเลือกทั่วไป

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

สำหรับรายการธงทั้งหมดกว่า 70 รายการ ดูได้ที่ [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md)

## ตัวเลือก PDF

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## การประมวลผลแบบแบตช์

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```

ไฟล์ที่ถูกลายน้ำแล้ว (ที่ตรงกับคำนำหน้าหรือคำต่อท้าย) จะถูกข้ามโดยอัตโนมัติเมื่อเรียกใช้งานซ้ำ

## ไฟล์กำหนดค่า

บันทึกตัวเลือกต่าง ๆ ในไฟล์ TOML เพื่อหลีกเลี่ยงการต้องระบุแฟลกซ้ำ ดูตัวอย่างเต็มที่
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) สำหรับตัวอย่างที่สมบูรณ์พร้อมสองพรีเซ็ต: **ultra-secure** (การปูกระเบื้องหนาแน่น ลายน้ำเต็มรูปแบบ การตรวจสอบย้อนกลับด้วย QR การลบข้อมูลเมตา) และ **light** (ข้อความแนวทแยงแบบง่าย ไม่มีคุณสมบัติเสริม)




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

## รองรับรูปแบบไฟล์

| รูปแบบ | อินพุต | เอาต์พุต |
|---|---|---|
| PNG | ใช่ | ใช่ |
| JPEG | ใช่ | ใช่ |
| PDF | ใช่ | ใช่ |
| WebP | ใช่ | ใช่ |
| TIFF | ใช่ | ใช่ |

รองรับการแปลงข้ามรูปแบบไฟล์ (เช่น `firemark photo.webp -o out.pdf`)

## ใบอนุญาต

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---