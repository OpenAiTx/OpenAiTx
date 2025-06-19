# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

Trình khởi chạy ứng dụng đa nền tảng ưu tiên web với plugin dựa trên React

> [!WARNING]
> Trình khởi chạy đang được phát triển bởi một lập trình viên duy nhất vào thời gian rảnh.
> Quá trình thay đổi có thể chậm nhưng ổn định
>
> Có thể sẽ có các thay đổi phá vỡ, sẽ được ghi chú trong [changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md).

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## Demo

Demo hơi lỗi thời

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## Tính năng

- Ưu tiên plugin
  - Plugin được viết bằng TypeScript
  - API plugin mở rộng 
      - Tạo UI view
      - Lệnh một lần (one-shot commands)
      - Cung cấp động danh sách lệnh một lần
      - Hiển thị nội dung "inline" nhanh ngay dưới thanh tìm kiếm chính dựa vào giá trị trong đó
      - Lấy nội dung từ và thêm vào Clipboard
  - Plugin được phân phối dưới dạng nhánh riêng biệt trong Git repository, nghĩa là việc phân phối plugin không cần máy chủ trung tâm
  - ID plugin chỉ là URL Git Repository
  - Giao diện người dùng dựa trên [React](https://github.com/facebook/react) cho plugin
    - Được triển khai bằng React Reconciler tùy chỉnh (không dùng Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno cho phép sandbox mã plugin JavaScript để tăng bảo mật
    - Plugin bắt buộc phải khai báo rõ quyền hạn cần thiết để hoạt động
    - Node.js được dùng để chạy các công cụ plugin, nhưng khi phát triển plugin bạn luôn viết mã chạy trên Deno
- Được thiết kế đa nền tảng ngay từ đầu
- Lệnh và View có thể chạy/mở bằng phím tắt toàn cục tùy chỉnh
- Có thể gán alias tìm kiếm tùy chỉnh cho Lệnh hoặc View
- Hỗ trợ chủ đề tùy chỉnh (custom theme)
- Chức năng tích hợp được cung cấp bởi các plugin đi kèm sẵn
  - Ứng dụng: hiển thị các ứng dụng đã cài đặt trên hệ thống trong kết quả tìm kiếm
    - Plugin cũng theo dõi cửa sổ và ứng dụng tương ứng, nên khi mở lại ứng dụng đã mở sẽ mặc định hiển thị cửa sổ đã tạo trước đó
      - Không phải hệ thống nào cũng được hỗ trợ lúc này. Xem [hỗ trợ tính năng](https://gauntlet.sh/docs/feature-support)
  - Máy tính: hiển thị kết quả phép toán ngay dưới thanh tìm kiếm chính
    - Bao gồm chuyển đổi tiền tệ theo tỷ giá hối đoái
    - Được cung cấp bởi [Numbat](https://github.com/sharkdp/numbat)
- Sắp xếp kết quả tìm kiếm dựa trên tần suất và thời gian sử dụng (frecency)
   - Frecency là sự kết hợp giữa tần suất và thời gian gần nhất sử dụng
   - Mục càng được dùng nhiều thì sẽ ở vị trí cao hơn trong danh sách kết quả, nhưng các mục dùng nhiều trong quá khứ sẽ xếp hạng thấp hơn các mục dùng gần đây với số lần tương đương
   - Kết quả được khớp từng từ bằng chuỗi con

##### Hỗ trợ hệ điều hành

##### Chính thức
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### Hỗ trợ tốt nhất có thể
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland chưa được hỗ trợ, xem [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## Bắt đầu

### Cài đặt Gauntlet

Xem [Cài đặt](https://gauntlet.sh/docs/installation)

### Phím tắt toàn cục

Cửa sổ chính có thể mở bằng phím tắt toàn cục hoặc lệnh CLI:
- Phím tắt toàn cục (có thể thay đổi trong Cài đặt)
  - Windows: <kbd>ALT</kbd> + <kbd>Space</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Space</kbd>
  - Linux Wayland
    - Có thể không hỗ trợ phím tắt toàn cục, xem [hỗ trợ tính năng](https://gauntlet.sh/docs/feature-support)
    - Vui lòng dùng lệnh CLI thay thế, và gọi lệnh đó bằng cách riêng của trình quản lý cửa sổ
  - macOS: <kbd>CMD</kbd> + <kbd>Space</kbd>
- Lệnh CLI
  - `gauntlet open`

### Cài đặt plugin

Plugin được cài trong giao diện Cài đặt. Dùng URL Git repository của plugin để cài, ví dụ `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### Tạo plugin của riêng bạn

Xem [Bắt đầu phát triển plugin](https://gauntlet.sh/docs/plugin-development/getting-started)

## Chủ đề (Theming)

Xem [Chủ đề](https://gauntlet.sh/docs/theming)

## Xây dựng Gauntlet

Bạn cần:
- NodeJS
- Rust
- Trình biên dịch Protobuf
- CMake (không dùng trực tiếp bởi dự án, nhưng là phụ thuộc cần thiết)
- Trên Linux: `libxkbcommon-dev` (lưu ý: tên có thể khác tùy theo bản phân phối)

### Dev

Để build dev chạy:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
Ở chế độ dev (không có tính năng "release") ứng dụng chỉ dùng thư mục bên trong thư mục dự án để lưu trạng thái hoặc bộ nhớ đệm, tránh làm ảnh hưởng cài đặt toàn cục

### Chưa đóng gói

Để build file nhị phân bản phát hành chưa đóng gói, chạy:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Đã đóng gói
Để build gói cài đặt riêng cho hệ điều hành, chạy một trong các lệnh sau:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

Nhưng phát hành phiên bản mới cần thực hiện qua GitHub Actions

## Đóng góp

Nếu bạn muốn hỗ trợ phát triển Gauntlet, bạn có thể giúp theo nhiều cách ngoài việc đóng góp mã nguồn:
- Báo cáo lỗi hoặc vấn đề về UI/UX
- Tạo plugin

Đối với các vấn đề đơn giản, bạn cứ tự do mở issue hoặc PR và tự xử lý.
Với những thay đổi lớn hơn, vui lòng liên hệ tác giả trên Discord (liên kết mời ở đầu README) để thảo luận trước.

Chào đón mọi đóng góp.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---