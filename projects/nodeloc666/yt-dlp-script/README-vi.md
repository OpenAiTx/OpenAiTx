
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 Công cụ tải video hàng loạt yt-dlp (Hỗ trợ Windows / Linux)

> Dựa trên [yt-dlp](https://github.com/yt-dlp/yt-dlp), đây là script tải video một chạm, lấy cảm hứng từ [chia sẻ của NodeSeek](https://www.nodeseek.com/post-334093-2#15).
> Hỗ trợ tải đơn lẻ và tải hàng loạt video, tương thích với Windows và các bản phân phối Linux phổ biến (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Đặc điểm tính năng

* 📥 **Chạy bằng một cú nhấp**: Không cần cấu hình thủ công, chỉ cần nhập theo hướng dẫn để bắt đầu tải xuống
* 🍪 **Hỗ trợ tùy chỉnh Cookie**: Phù hợp với video yêu cầu đăng nhập để tải về (⚠️ Tính năng này chưa được xác thực, có thể có lỗi)
* 📂 **Hỗ trợ tùy chọn thư mục đầu ra**: Dễ dàng lưu vào thư mục chỉ định
* 📃 **Hỗ trợ tải xuống hàng loạt**: Tự động đọc các liên kết trong file `urls.txt` để tải xuống
* ⚙️ **Tự động cài đặt phụ thuộc**: Tự động cài đặt `yt-dlp` và `ffmpeg` trên môi trường Linux

---

## 🖼️ Xem trước ảnh chụp màn hình

| Ví dụ 1                                                                  | Ví dụ 2                                                                  |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![Ví dụ 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Ví dụ 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Ví dụ 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Ví dụ 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Hướng dẫn sử dụng trên Windows

1. Tải về các tệp sau:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` phiên bản Windows](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. Sau khi giải nén, đặt các tệp sau vào cùng một thư mục (ví dụ thư mục `yt-dlp`):

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (tệp script)

3. Nhấp đúp để chạy `yt-dlp.bat`, làm theo hướng dẫn để tải video.
4. Chỉnh sửa config/config.ini để thay đổi cấu hình mặc định

---

## 🐧 Hướng dẫn sử dụng trên Linux (Script mới nhất của lion đại ca cũng đã tích hợp script chức năng tương tự)

**Hệ điều hành hỗ trợ**: Debian / Ubuntu / Alpine / CentOS

Triển khai hoặc cập nhật và chạy chỉ với một cú nhấp:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

Nếu cần gỡ cài đặt:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Khuyến nghị sử dụng Android

1. Sử dụng ứng dụng [Seal](https://github.com/JunkFood02/Seal) để trải nghiệm chức năng `yt-dlp` trên Android.
2. Cài đặt Debian trên termux cũng có thể tải về, nhưng không cần thiết phải dùng cách này, Seal rất dễ dùng

---

## ⚠️ Lưu ý

1. **Chế độ tải hàng loạt**: Script sẽ tự động đọc file `config\urls.txt` trong thư mục hiện tại, mỗi dòng là một liên kết video. Nếu file không tồn tại, sẽ tự động tạo mới.
2. **Cảnh báo sử dụng tài nguyên**: Thiết bị có bộ nhớ nhỏ nên tránh tải đồng thời nhiều video lớn hoặc đặt số luồng quá cao.
3. **Lưu ý đặc biệt cho CentOS**: Do môi trường khá đặc biệt, chưa được kiểm tra đầy đủ, khuyến nghị chỉ dùng ở môi trường thử nghiệm. Các hệ thống phổ biến khác đều đã xác nhận hoạt động tốt.
4. Lỗi nhỏ trên bản Linux: Khi chạy script đến trang chủ sẽ kiểm tra phụ thuộc một lần, theo nguyên tắc code chạy được là được, lười sửa lại
5. Lỗi nhỏ trên bản Windows: Khi chuyển từ trang khác về trang chủ rồi chọn lại, tùy chọn mặc định có thể bị mất hiệu lực, gây kẹt vòng lặp, khả năng có hạn, chưa sửa được
Hai cách giải quyết:
    1. Thoát ra và chạy lại
    2. Không dùng mặc định, chỉ cần chọn theo số

---

## 📄 Giấy phép

Dự án này tuân thủ [MIT License](https://opensource.org/licenses/MIT).

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---