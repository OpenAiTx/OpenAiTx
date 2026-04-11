<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

<p align="center">Một công cụ đóng dấu bản quyền nhanh, dạng tệp đơn cho hình ảnh và PDF. Được phát triển bằng Rust.</p>


## Tại sao cần đóng dấu watermark cho tài liệu?

Mỗi năm, hàng triệu người trở thành nạn nhân của lừa đảo danh tính bắt đầu bằng một
cuộc trao đổi tài liệu đơn giản. Một kịch bản phổ biến: bạn đang tìm thuê căn hộ.
Chủ nhà — hoặc ai đó giả làm chủ nhà — yêu cầu bản sao giấy tờ tùy thân, bảng lương,
thông báo thuế. Bạn gửi chúng mà không đánh dấu. "Chủ nhà" biến mất, và tài liệu của bạn
bây giờ được dùng để mở tài khoản ngân hàng, vay tiền, hoặc giả mạo danh tính của bạn.

Đóng dấu watermark mọi tài liệu bạn gửi đi là cách phòng vệ hiệu quả nhất.
Một lớp phủ hiển thị dòng chữ **"Gửi cho đơn vị XYZ — Tháng 3/2026 — Chỉ dùng cho
đơn xin thuê nhà"** khiến tài liệu vô dụng cho mục đích khác. Nếu bị rò rỉ, bạn biết ngay nguồn gốc.

firemark giúp bạn dễ dàng: một lệnh, bất kỳ hình ảnh hoặc PDF nào, 17 kiểu hiển thị,
mẫu filigrane mật mã chống chỉnh sửa, và xử lý hàng loạt cho toàn bộ thư mục.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Trước và sau khi đóng watermark" width="800">
  <br>
  <em>Trước và sau — một lệnh, tài liệu giờ đã có thể truy vết và phát hiện chỉnh sửa.</em>
</p>

## Cài đặt

Từ [crates.io](https://crates.io/crates/firemark):




```bash
cargo install firemark
```

Từ nguồn:

```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```
Tạo ra một tệp nhị phân tối ưu duy nhất (~5 MB).

## Bắt đầu nhanh


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

Đầu ra được lưu cùng với đầu vào dưới dạng `{name}-watermarked.{ext}` theo mặc định.
Sử dụng `-o` để đặt đường dẫn đầu ra cụ thể, hoặc `-S` cho hậu tố tùy chỉnh.

## Các loại watermark

| Cờ | Kiểu | Mô tả |
|---|---|---|
| `diagonal` | Lưới chéo | Văn bản chéo lặp lại toàn trang (mặc định) |
| `stamp` | Dấu cao su | Dấu lớn ở giữa với viền đôi |
| `stencil` | Chữ khuôn | Chữ khuôn quân đội toàn chiều rộng |
| `typewriter` | Máy đánh chữ | Văn bản kiểu máy đánh chữ đơn cách |
| `handwritten` | Chữ ký | Chữ ký kiểu viết tay có gạch dưới |
| `redacted` | Bị che | Thanh che đen toàn chiều rộng |
| `badge` | Huy hiệu | Biểu tượng huy hiệu/bảo vệ an ninh |
| `ribbon` | Dải ruy băng | Biểu ngữ dải ruy băng góc chéo |
| `seal` | Con dấu | Con dấu tròn kiểu công chứng |
| `frame` | Khung | Viền trang trí toàn trang |
| `tile` | Ô lưới | Lưới văn bản đồng đều dày đặc |
| `mosaic` | Khảm | Văn bản rải ngẫu nhiên |
| `weave` | Đan | Lưới đan chéo xen kẽ |
| `ghost` | Bóng mờ | Văn bản nổi cực kỳ tinh tế |
| `watercolor` | Màu nước | Hiệu ứng mờ nhòe mềm mại |
| `noise` | Nhiễu | Văn bản bị nhiễu pixel |
| `halftone` | Độ phân giải | Văn bản dạng lưới chấm halftone |

```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```

## Dấu bảo mật filigrane

firemark phủ lên các mẫu filigrane mã hóa lấy cảm hứng từ các đặc điểm bảo mật trên tiền giấy. Những họa tiết hình học tinh xảo này cực kỳ khó bị xóa bởi các phần mềm chỉnh sửa ảnh.

| Kiểu | Mô tả |
|---|---|
| `guilloche` | Dải sóng sin bao bọc (mặc định) |
| `rosette` | Đường cong hoa thị + hoa hồng ở góc |
| `crosshatch` | Lưới kim cương chéo mịn |
| `border` | Viền bảo mật lượn sóng lồng nhau |
| `lissajous` | Hình tham số Lissajous |
| `moire` | Nhiễu vòng tròn đồng tâm |
| `spiral` | Xoáy xoắn ốc Archimedes |
| `mesh` | Lưới tổ ong hình lục giác |
| `plume` | Đường cong như lông vũ trải đều trên bề mặt |
| `constellation` | Điểm sao nối bằng mạng hình học tinh xảo |
| `ripple` | Mặt sóng elip chồng lên nhau từ các điểm ngẫu nhiên |
| `full` | Kết hợp tất cả các mẫu |
| `none` | Tắt filigrane |



```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## Tăng cường chống gỡ bỏ bằng AI

Mỗi lần render đều không xác định theo mặc định. firemark áp dụng nhiễu sau khi render một cách toàn diện (dao động alpha, nhiễu màu ở mức dưới điểm ảnh, các chấm siêu nhỏ ở cạnh, các điểm ảnh ma thưa thớt) và ngẫu nhiên hóa theo từng trình kết xuất để không có hai đầu ra nào giống hệt từng pixel — ngay cả khi dùng cùng thiết lập. Điều này khiến các mô hình thị giác AI không thể học được mẫu dự đoán để loại bỏ.

Bên cạnh đó, các dải chèn prompt đối kháng được nhúng mặc định để gây nhiễu cho các công cụ AI loại bỏ watermark. Vô hiệu hóa bằng `--no-anti-ai` nếu bạn không muốn hiển thị văn bản prompt:







```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## Các tùy chọn phổ biến

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

Để xem danh sách đầy đủ hơn 70 cờ, hãy xem [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md).

## Tùy chọn PDF

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## Xử lý theo lô

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```
Các tệp đã được đóng dấu bản quyền (khớp với hậu tố) sẽ tự động được bỏ qua khi chạy lại.

## Tệp cấu hình

Lưu các tùy chọn trong tệp TOML để tránh lặp lại các cờ. Xem
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml) để biết một ví dụ đầy đủ
với hai cấu hình sẵn: **ultra-secure** (lưới dày đặc, watermark đầy đủ, truy vết QR,
loại bỏ metadata) và **light** (chỉ có chữ chéo đơn giản, không thêm gì khác).



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

## Hỗ trợ định dạng

| Định dạng | Đầu vào | Đầu ra |
|---|---|---|
| PNG | có | có |
| JPEG | có | có |
| PDF | có | có |
| WebP | có | có |
| TIFF | có | có |

Hỗ trợ chuyển đổi giữa các định dạng (ví dụ: `firemark photo.webp -o out.pdf`).

## Giấy phép

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---