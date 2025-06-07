<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - Máy tính từ xa của bạn"><br>
  <a href="#raw-steps-to-build">Biên dịch</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">Cấu trúc</a> •
  <a href="#snapshot">Ảnh chụp màn hình</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>Chúng tôi cần sự giúp đỡ của bạn để dịch README này, <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">Giao diện RustDesk</a> và <a href="https://github.com/rustdesk/doc.rustdesk.com">Tài liệu RustDesk</a> sang ngôn ngữ mẹ đẻ của bạn</b>
</p>

> [!Caution]
> **Tuyên bố miễn trừ lạm dụng:** <br>
> Các nhà phát triển RustDesk không ủng hộ hoặc khuyến khích bất kỳ hành vi sử dụng phần mềm này một cách phi đạo đức hoặc bất hợp pháp nào. Việc lạm dụng, chẳng hạn như truy cập trái phép, kiểm soát hoặc xâm phạm quyền riêng tư, là hoàn toàn trái với hướng dẫn của chúng tôi. Tác giả không chịu trách nhiệm về bất kỳ hành vi lạm dụng nào của ứng dụng.

Trò chuyện với chúng tôi: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

Một phần mềm điều khiển máy tính từ xa khác, được viết bằng Rust. Hoạt động ngay sau khi cài đặt, không cần cấu hình. Bạn hoàn toàn kiểm soát dữ liệu của mình, không lo ngại về bảo mật. Bạn có thể sử dụng máy chủ rendezvous/relay của chúng tôi, [tự thiết lập máy chủ riêng](https://rustdesk.com/server), hoặc [tự viết máy chủ rendezvous/relay của bạn](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk chào đón sự đóng góp từ tất cả mọi người. Xem [CONTRIBUTING.md](docs/CONTRIBUTING.md) để được hướng dẫn bắt đầu.

[**CÂU HỎI THƯỜNG GẶP**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**TẢI BINARY**](https://github.com/rustdesk/rustdesk/releases)

[**BẢN NIGHTLY**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Get it on F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Get it on Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## Phụ thuộc

Phiên bản máy tính sử dụng Flutter hoặc Sciter (không còn hỗ trợ) cho giao diện, hướng dẫn này chỉ dành cho Sciter, vì dễ bắt đầu hơn. Xem [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) để biết cách biên dịch phiên bản Flutter.

Vui lòng tự tải về thư viện động Sciter.

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## Các bước biên dịch cơ bản

- Chuẩn bị môi trường phát triển Rust và môi trường biên dịch C++

- Cài đặt [vcpkg](https://github.com/microsoft/vcpkg), và thiết lập biến môi trường `VCPKG_ROOT` chính xác

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- chạy `cargo run`

## [Biên dịch](https://rustdesk.com/docs/en/dev/build/)

## Cách biên dịch trên Linux

### Ubuntu 18 (Debian 10)

```sh
sudo apt install -y zip g++ gcc git curl wget nasm yasm libgtk-3-dev clang libxcb-randr0-dev libxdo-dev \
        libxfixes-dev libxcb-shape0-dev libxcb-xfixes0-dev libasound2-dev libpulse-dev cmake make \
        libclang-dev ninja-build libgstreamer1.0-dev libgstreamer-plugins-base1.0-dev libpam0g-dev
```

### openSUSE Tumbleweed

```sh
sudo zypper install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libXfixes-devel cmake alsa-lib-devel gstreamer-devel gstreamer-plugins-base-devel xdotool-devel pam-devel
```

### Fedora 28 (CentOS 8)

```sh
sudo yum -y install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libxdo-devel libXfixes-devel pulseaudio-libs-devel cmake alsa-lib-devel gstreamer1-devel gstreamer1-plugins-base-devel pam-devel
```

### Arch (Manjaro)

```sh
sudo pacman -Syu --needed unzip git cmake gcc curl wget yasm nasm zip make pkg-config clang gtk3 xdotool libxcb libxfixes alsa-lib pipewire
```

### Cài đặt vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### Sửa libvpx (Đối với Fedora)

```sh
cd vcpkg/buildtrees/libvpx/src
cd *
./configure
sed -i 's/CFLAGS+=-I/CFLAGS+=-fPIC -I/g' Makefile
sed -i 's/CXXFLAGS+=-I/CXXFLAGS+=-fPIC -I/g' Makefile
make
cp libvpx.a $HOME/vcpkg/installed/x64-linux/lib/
cd
```

### Biên dịch

```sh
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
source $HOME/.cargo/env
git clone --recurse-submodules https://github.com/rustdesk/rustdesk
cd rustdesk
mkdir -p target/debug
wget https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so
mv libsciter-gtk.so target/debug
VCPKG_ROOT=$HOME/vcpkg cargo run
```

## Cách biên dịch bằng Docker

Bắt đầu bằng cách clone repository và build container Docker:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

Sau đó, mỗi lần bạn cần biên dịch ứng dụng, hãy chạy lệnh sau:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

Lưu ý rằng lần build đầu tiên có thể sẽ lâu hơn do cần tải về các phụ thuộc, các lần build sau sẽ nhanh hơn. Ngoài ra, nếu bạn cần chỉ định các đối số khác cho lệnh build, có thể thêm vào cuối lệnh ở vị trí `<OPTIONAL-ARGS>`. Ví dụ, nếu bạn muốn build phiên bản tối ưu hóa cho phát hành, hãy thêm `--release` vào sau lệnh trên. File thực thi kết quả sẽ nằm trong thư mục target trên hệ thống của bạn, có thể chạy bằng:

```sh
target/debug/rustdesk
```

Hoặc nếu bạn chạy file thực thi bản phát hành:

```sh
target/release/rustdesk
```

Hãy đảm bảo bạn đang chạy các lệnh này từ thư mục gốc của repository RustDesk, nếu không ứng dụng có thể không tìm thấy tài nguyên cần thiết. Lưu ý rằng các lệnh cargo khác như `install` hoặc `run` hiện không được hỗ trợ qua phương pháp này vì chúng sẽ cài đặt hoặc chạy chương trình bên trong container thay vì trên máy chủ.

## Cấu trúc thư mục

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: bộ mã hóa/giải mã video, cấu hình, bọc tcp/udp, protobuf, hàm hệ thống file cho truyền file và một số hàm tiện ích khác
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: chụp màn hình
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: điều khiển bàn phím/chuột theo từng nền tảng
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: triển khai sao chép và dán file cho Windows, Linux, macOS.
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: giao diện Sciter (không còn sử dụng)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: dịch vụ âm thanh/bảng tạm/nhập liệu/video và kết nối mạng
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: khởi tạo kết nối peer
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: giao tiếp với [rustdesk-server](https://github.com/rustdesk/rustdesk-server), chờ kết nối trực tiếp từ xa (TCP hole punching) hoặc kết nối qua relay
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: mã nguồn theo từng nền tảng
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: mã nguồn Flutter cho desktop và di động
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: JavaScript cho Flutter web client

## Ảnh chụp màn hình

![Trình quản lý kết nối](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Kết nối tới một máy tính Windows](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![Truyền file](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![Đường hầm TCP](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---