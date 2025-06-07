[![Electron Logo](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![GitHub Actions Build Status](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Electron Discord Invite](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: Các bản dịch có sẵn: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
Xem các tài liệu này bằng các ngôn ngữ khác trên dự án [Crowdin](https://crowdin.com/project/electron) của chúng tôi.

Framework Electron cho phép bạn viết các ứng dụng desktop đa nền tảng
sử dụng JavaScript, HTML và CSS. Nó được xây dựng dựa trên [Node.js](https://nodejs.org/) và
[Chromium](https://www.chromium.org) và được sử dụng bởi
[Visual Studio Code](https://github.com/Microsoft/vscode/) cùng nhiều [ứng dụng](https://electronjs.org/apps) khác.

Theo dõi [@electronjs](https://twitter.com/electronjs) trên Twitter để nhận các
thông báo quan trọng.

Dự án này tuân thủ [bộ quy tắc ứng xử](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md) Contributor Covenant.
Bằng việc tham gia, bạn được kỳ vọng tuân thủ bộ quy tắc này. Vui lòng báo cáo hành vi không chấp nhận được đến [coc@electronjs.org](mailto:coc@electronjs.org).

## Cài đặt

Để cài đặt các bản nhị phân Electron đã được xây dựng sẵn, sử dụng [`npm`](https://docs.npmjs.com/).
Phương pháp ưu tiên là cài Electron như một phụ thuộc phát triển trong
ứng dụng của bạn:

```sh
npm install electron --save-dev
```

Để biết thêm các tùy chọn cài đặt và mẹo khắc phục sự cố, xem
[hướng dẫn cài đặt](docs/tutorial/installation.md). Để biết thông tin về cách quản lý các phiên bản Electron trong ứng dụng của bạn, xem
[quản lý phiên bản Electron](docs/tutorial/electron-versioning.md).

## Hỗ trợ nền tảng

Mỗi bản phát hành Electron cung cấp các tệp nhị phân cho macOS, Windows và Linux.

* macOS (Big Sur trở lên): Electron cung cấp các tệp nhị phân Intel 64-bit và Apple Silicon / ARM cho macOS.
* Windows (Windows 10 trở lên): Electron cung cấp các tệp nhị phân `ia32` (`x86`), `x64` (`amd64`) và `arm64` cho Windows. Hỗ trợ Windows on ARM được thêm vào trong Electron 5.0.8. Hỗ trợ cho Windows 7, 8 và 8.1 đã [bị loại bỏ trong Electron 23, phù hợp với chính sách ngừng hỗ trợ Windows của Chromium](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: Các tệp nhị phân Electron được xây dựng sẵn trên Ubuntu 20.04. Chúng cũng đã được xác minh hoạt động trên:
  * Ubuntu 18.04 trở lên
  * Fedora 32 trở lên
  * Debian 10 trở lên

## Electron Fiddle

Sử dụng [`Electron Fiddle`](https://github.com/electron/fiddle)
để xây dựng, chạy và đóng gói các thử nghiệm nhỏ với Electron, xem các ví dụ mã cho tất cả API của Electron,
và thử các phiên bản Electron khác nhau. Công cụ này được thiết kế để giúp bạn bắt đầu với
Electron dễ dàng hơn.

## Tài nguyên học Electron

* [electronjs.org/docs](https://electronjs.org/docs) - Tất cả tài liệu về Electron
* [electron/fiddle](https://github.com/electron/fiddle) - Công cụ xây dựng, chạy và đóng gói các thử nghiệm nhỏ với Electron
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - Các ứng dụng mẫu khởi tạo do cộng đồng tạo ra

## Sử dụng bằng lập trình

Hầu hết mọi người sử dụng Electron từ dòng lệnh, nhưng nếu bạn require `electron` trong
**ứng dụng Node** của mình (không phải ứng dụng Electron) nó sẽ trả về đường dẫn tệp
tới tệp nhị phân. Sử dụng cách này để khởi chạy Electron từ các script Node:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// sẽ in ra đường dẫn tương tự như /Users/maf/.../Electron
console.log(electron)

// khởi chạy Electron
const child = proc.spawn(electron)
```

### Mirrors

* [Trung Quốc](https://npmmirror.com/mirrors/electron/)

Xem [Hướng dẫn cài đặt nâng cao](https://www.electronjs.org/docs/latest/tutorial/installation#mirror) để tìm hiểu cách sử dụng mirror tùy chỉnh.

## Dịch tài liệu

Chúng tôi cộng tác dịch tài liệu thông qua [Crowdin](https://crowdin.com/project/electron).
Hiện tại chúng tôi chấp nhận các bản dịch cho tiếng Trung (Giản thể), Pháp, Đức, Nhật, Bồ Đào Nha,
Nga và Tây Ban Nha.

## Đóng góp

Nếu bạn quan tâm đến việc báo cáo/sửa lỗi và đóng góp trực tiếp vào mã nguồn, vui lòng xem [CONTRIBUTING.md](CONTRIBUTING.md) để biết thêm thông tin về những gì chúng tôi cần và cách bắt đầu.

## Cộng đồng

Thông tin về báo cáo lỗi, nhận hỗ trợ, tìm kiếm công cụ bên thứ ba và các ứng dụng mẫu,
và nhiều nội dung khác có thể được tìm thấy tại [Trang cộng đồng](https://www.electronjs.org/community).

## Giấy phép

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Khi sử dụng logo Electron, hãy đảm bảo tuân thủ [Chính sách nhãn hiệu của OpenJS Foundation](https://trademark-policy.openjsf.org/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---