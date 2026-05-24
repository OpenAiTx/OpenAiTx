
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Mua cho tôi một ly cà phê tại ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Một trình duyệt tệp đơn giản được tạo ra vì tôi muốn học ngôn ngữ Rust.
  <br>
  Nó độc lập với hệ điều hành và được tối ưu hóa cho hiệu suất.
</p>

<br/><br/>

Hiệu năng được đạt được nhờ ["jwalk"](https://crates.io/crates/jwalk/versions) và ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver không sử dụng bộ nhớ đệm đường dẫn để truy cập tệp và thư mục, vì vậy hiệu năng dựa vào Rust, tốc độ của ổ đĩa và sức mạnh của cpu.

⁉️ Lưu ý rằng phần mềm này vẫn đang trong quá trình phát triển và có thể chứa lỗi!
<br/><br/>

# Liên kết
- <a href="#basic-features">Tính năng cơ bản</a>
- <a href="#advanced-features">Tính năng nâng cao</a>
- <a href="#dependencies-if-not-working-instantly">Phụ thuộc</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">Triển khai FTP (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">Vấn đề đã biết</a>
- <a href="#-todos">Các việc cần làm</a>
- <a href="#user-interface">Giao diện người dùng</a>

## Tính năng cơ bản
- Duyệt qua các thư mục như bạn đã biết
- Sao chép & Dán, xóa, tạo và đổi tên tệp và thư mục
- Chuyển đổi giữa chế độ lưới, danh sách và cột Miller
- Đóng các cửa sổ bật lên bằng phím esc
- Nhảy trực tiếp đến một thư mục với Ctrl / Cmd + G bằng cách nhập đường dẫn
- Sắp xếp các mục trong chế độ danh sách theo kích thước, tên hoặc lần sửa đổi cuối

## Tính năng nâng cao
- Nén tệp và thư mục
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Giải nén các tệp lưu trữ
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- Điều hướng đến một thư mục bằng phím tắt LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)
  - Tự cấu hình các đường dẫn trong phần cài đặt
- Tạo tệp với F6
- Tạo thư mục với F7
- Xem hai ngăn (Dual-Pane)
  - Tìm kiếm tệp với F8
  - Sao chép phần tử được chọn sang ngăn khác bằng F5
  - Di chuyển phần tử được chọn sang ngăn khác với LShift + F5
- Kéo và thả tệp vào trình khám phá để sao chép chúng vào thư mục hiện tại
- Đổi tên nhiều mục đã chọn với Ctrl / Cmd + LShift + M
  - Thực hiện đổi tên nhiều mục với Ctrl / Cmd + Return
- Xem nhanh tệp -> Chọn mục thư mục và nhấn phím cách.
  - Hỗ trợ các tệp: tất cả tệp ảnh (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Các mục khác sẽ hiển thị một ô nhỏ với một số thông tin về nó. (đường dẫn, kích thước, lần sửa đổi cuối)
- Điều hướng tức thì -> Bắt đầu nhập và tự động lọc các mục thư mục giúp đôi khi <br/>
  điều hướng đến vị trí mong muốn nhanh hơn nhiều

## Phụ thuộc (Nếu không hoạt động ngay lập tức)

<details>
<summary>Mở rộng để xem</summary>

### Linux

- openssl1.1

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Arch
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Fedora
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ Tích hợp FTP (sshfs)
<details>
  <summary>Mở rộng để xem</summary>
  <br/>
  Các phụ thuộc (Cần được cài đặt thêm):
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | Chưa được hỗ trợ **_hiện tại_** |

  ### Cài đặt:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### Linux
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ Hỗ trợ ngôn ngữ
- Tiếng Anh
  - Sắp tới sẽ có tuỳ chọn chọn giữa các ngôn ngữ ...
</details>

## ⚠️ Các vấn đề đã biết:
- Kéo và thả ra ngoài cửa sổ hiện tại chưa luôn hoạt động trên linux
- Trên windows bạn có thể cần cài đặt [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Quyền trên ms-windows hơi lạ một chút
  - Bạn có thể phải chạy chương trình với quyền quản trị viên nếu gặp vấn đề khi sao chép phần tử hoặc tương tự
- Có thể bạn cần cài đặt openssl1.1 trên hệ thống linux nếu chương trình không khởi động

## 📝 Việc cần làm:
- Đa ngôn ngữ
- Yêu thích
- Truy cập dịch vụ lưu trữ trực tuyến (Google Drive, v.v.)

## Giao diện người dùng

### Kiểu danh sách
<img width="1119" height="673" alt="Screenshot 2025-11-16 at 13 53 53" src="https://github.com/user-attachments/assets/cfe15e6f-9936-4e29-9ca5-0f83f366c9dc" />

### Kiểu lưới
<img width="1121" height="674" alt="Screenshot 2025-11-16 at 13 53 46" src="https://github.com/user-attachments/assets/69dbeee0-b53c-4566-b90e-e85ab97e0033" />

### Xem dạng cột Miller
<img width="1112" height="664" alt="Screenshot 2025-11-16 at 13 54 29" src="https://github.com/user-attachments/assets/1f540880-2097-423b-8522-1ef466aee1bd" />

### Chế độ hai cửa sổ
<img width="1119" height="667" alt="Screenshot 2025-11-16 at 13 55 16" src="https://github.com/user-attachments/assets/80706079-a048-4e9e-93f0-54fa270f30ac" />

## Cách đóng góp
Thiết lập máy của bạn để phát triển các ứng dụng tauri v1: [Yêu cầu tiên quyết Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Khi đã xong chỉ cần chạy ```git clone https://github.com/RickyDane/CoDriver``` hoặc ```gh repo clone RickyDane/CoDriver``` tại một vị trí trên máy của bạn.
</br></br>
Bạn có thể chạy ```cargo tauri dev``` trong thư mục gốc của dự án này để bắt đầu build và chạy CoDriver.
</br>
Nhớ cài đặt tauri-cli: ```cargo install tauri-cli```
</br>

## Ký phát hành

Các tệp phát hành trên macOS phải được ký và xác thực để tránh Gatekeeper báo rằng ứng dụng đã cài đặt bị hỏng. Xem [Ký và xác thực trên macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) để biết các secrets GitHub Actions cần thiết và lệnh xác minh.

## Lịch sử gắn sao

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Biểu đồ lịch sử gắn sao" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Phần mềm bên thứ ba khác
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---