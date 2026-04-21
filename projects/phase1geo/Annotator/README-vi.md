
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Annotator

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Tải về trên AppCenter"/>
  </a>
</p>

![<center><b>Cửa Sổ Chính - Giao Diện Sáng</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Chú thích hình ảnh cho Elementary OS")

## Tổng Quan

Chú thích hình ảnh của bạn và để một bức tranh nói lên 1000 từ.

- Tải hình ảnh từ hệ thống tệp, clipboard, hoặc tạo ảnh chụp màn hình để chú thích.
- Thêm hình dạng, nhãn dán, hình ảnh, văn bản, bản vẽ và các chú thích khác để làm nổi bật chi tiết hình ảnh.
- Thêm kính lúp để tăng cường chi tiết hình ảnh.
- Làm mờ các phần của hình ảnh để che giấu dữ liệu.
- Cắt, thay đổi kích thước và thêm viền cho hình ảnh.
- Kiểm soát màu sắc, độ dày đường và chi tiết phông chữ.
- Hỗ trợ phóng to.
- Hỗ trợ chọn màu trong hình ảnh đã tải.
- Hoàn tác/làm lại không giới hạn cho mọi thay đổi.
- Kéo và thả bản sao PNG của hình ảnh đã chú thích.
- Xuất sang các định dạng hình ảnh JPEG, PNG, TIFF, BMP, PDF, SVG và WebP.
- Hỗ trợ sao chép hình ảnh đã chú thích vào clipboard.
- Hỗ trợ máy in.

## Cài Đặt

### Debian (từ mã nguồn)

Bạn sẽ cần các phụ thuộc sau để biên dịch Annotator:

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-7-dev
- libgtk-4-dev
- libxml2-dev
- libarchive-dev
- libwebp-dev

Để cài đặt Annotator từ mã nguồn, hãy chạy `./app install`.

Để chạy Annotator, hãy chạy `com.github.phase1geo.annotator`.

### Ubuntu (PPA)

Bạn có thể sử dụng [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/) được duy trì bởi @PandaJim. PPA hỗ trợ Ubuntu 20.04+. Nhập lần lượt các lệnh sau

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```

### Arch Linux

Nếu bạn là người dùng Arch Linux, có một
[gói AUR](https://aur.archlinux.org/packages/annotator/)
`annotator`:

```
% yay -S annotator
```

### Flatpak

Ngoài ra, Annotator có thể được cài đặt và chạy qua Flatpak.

Để biên dịch Flatpak elementary từ mã nguồn, chạy `./app elementary`.

Để biên dịch Flatpak Flathub từ mã nguồn, chạy `./app flathub`.

Sau đó, bạn có thể chạy nó bằng: `./app run-flatpak`.

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Tải về từ AppCenter"/>
  </a>
</p>

## Ghi công

Tích hợp `document-edit-symbolic.svg` và `image-crop-symbolic.svg` từ
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic),
theo điều khoản của giấy phép GPL v3.0.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---