<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - เดสก์ท็อประยะไกลของคุณ"><br>
  <a href="#raw-steps-to-build">การสร้าง</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">โครงสร้าง</a> •
  <a href="#snapshot">สแนปช็อต</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>เราต้องการความช่วยเหลือของคุณในการแปล README นี้, <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">RustDesk UI</a> และ <a href="https://github.com/rustdesk/doc.rustdesk.com">RustDesk Doc</a> เป็นภาษาแม่ของคุณ</b>
</p>

> [!Caution]
> **คำปฏิเสธการใช้งานในทางที่ผิด:** <br>
> นักพัฒนา RustDesk ไม่สนับสนุนหรือยอมรับการใช้งานซอฟต์แวร์นี้ในทางที่ผิดจรรยาบรรณหรือผิดกฎหมาย การใช้งานที่ไม่ถูกต้อง เช่น การเข้าถึงโดยไม่ได้รับอนุญาต การควบคุม หรือการละเมิดความเป็นส่วนตัว ถือเป็นสิ่งที่ขัดต่อแนวทางของเรา ผู้เขียนจะไม่รับผิดชอบต่อการใช้งานแอปพลิเคชันนี้ในทางที่ผิด

พูดคุยกับเรา: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

ซอฟต์แวร์เดสก์ท็อประยะไกลอีกตัวหนึ่งที่พัฒนาด้วยภาษา Rust ใช้งานได้ทันทีโดยไม่ต้องตั้งค่า คุณสามารถควบคุมข้อมูลของคุณได้อย่างเต็มที่โดยไม่ต้องกังวลเรื่องความปลอดภัย คุณสามารถใช้เซิร์ฟเวอร์ rendezvous/relay ของเรา, [ตั้งค่าเซิร์ฟเวอร์ของคุณเอง](https://rustdesk.com/server) หรือ [เขียนเซิร์ฟเวอร์ rendezvous/relay ของคุณเอง](https://github.com/rustdesk/rustdesk-server-demo)

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk ยินดีต้อนรับการมีส่วนร่วมจากทุกคน ดู [CONTRIBUTING.md](docs/CONTRIBUTING.md) สำหรับคำแนะนำในการเริ่มต้น

[**FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**ดาวน์โหลด BINARY**](https://github.com/rustdesk/rustdesk/releases)

[**NIGHTLY BUILD**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="รับแอปบน F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="รับแอปบน Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## ข้อกำหนดเบื้องต้น

เวอร์ชันเดสก์ท็อปใช้ Flutter หรือ Sciter (เลิกใช้งานแล้ว) สำหรับ GUI คู่มือนี้สำหรับ Sciter เท่านั้น เนื่องจากเริ่มต้นได้ง่ายและเป็นมิตรกว่า ดู [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) สำหรับวิธีสร้างเวอร์ชัน Flutter

กรุณาดาวน์โหลดไลบรารี Sciter แบบไดนามิกด้วยตนเอง

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## ขั้นตอนการสร้างแบบดิบ

- เตรียมสภาพแวดล้อมสำหรับพัฒนา Rust และสภาพแวดล้อมสำหรับคอมไพล์ C++

- ติดตั้ง [vcpkg](https://github.com/microsoft/vcpkg) และตั้งค่าตัวแปรสภาพแวดล้อม `VCPKG_ROOT` ให้ถูกต้อง

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- รัน `cargo run`

## [การสร้าง](https://rustdesk.com/docs/en/dev/build/)

## วิธีสร้างบน Linux

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

### ติดตั้ง vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### แก้ไข libvpx (สำหรับ Fedora)

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

### สร้างโปรแกรม

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

## วิธีสร้างด้วย Docker

เริ่มต้นโดยโคลนรีโพซิทอรีและสร้าง Docker container:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

จากนั้นทุกครั้งที่คุณต้องการสร้างแอปพลิเคชัน ให้รันคำสั่งนี้:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

โปรดทราบว่าการสร้างครั้งแรกอาจใช้เวลานานกว่าปกติเนื่องจากต้องดาวน์โหลด dependencies หลังจากนั้นการสร้างครั้งต่อๆ ไปจะเร็วขึ้น นอกจากนี้ หากคุณต้องการระบุอาร์กิวเมนต์เพิ่มเติมให้กับคำสั่ง build คุณสามารถเพิ่มไว้ท้ายคำสั่งในตำแหน่ง `<OPTIONAL-ARGS>` ตัวอย่างเช่น หากคุณต้องการสร้างแบบ release ที่ปรับแต่งแล้ว ให้รันคำสั่งข้างต้นตามด้วย `--release` ไฟล์ executable ที่ได้จะอยู่ในโฟลเดอร์ target บนระบบของคุณ และสามารถรันได้ด้วย:

```sh
target/debug/rustdesk
```

หรือหากคุณรันแบบ release executable:

```sh
target/release/rustdesk
```

โปรดตรวจสอบว่าคุณกำลังรันคำสั่งเหล่านี้จาก root ของ RustDesk repository ไม่เช่นนั้นแอปพลิเคชันอาจไม่พบ resource ที่ต้องการ โปรดทราบด้วยว่าคำสั่งย่อยอื่นๆ ของ cargo เช่น `install` หรือ `run` ยังไม่รองรับวิธีนี้ เนื่องจากจะติดตั้งหรือรันโปรแกรมภายใน container แทนที่จะเป็นบนโฮสต์

## โครงสร้างไฟล์

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: ตัวเข้ารหัสวิดีโอ, การตั้งค่า, ตัวห่อ tcp/udp, protobuf, ฟังก์ชัน fs สำหรับการโอนไฟล์ และฟังก์ชันยูทิลิตี้อื่นๆ
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: จับภาพหน้าจอ
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: การควบคุมคีย์บอร์ด/เมาส์เฉพาะแพลตฟอร์ม
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: การคัดลอกและวางไฟล์สำหรับ Windows, Linux, macOS
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: Sciter UI ที่เลิกใช้แล้ว (deprecated)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: บริการเสียง/คลิปบอร์ด/อินพุต/วิดีโอ และการเชื่อมต่อเครือข่าย
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: เริ่มต้นการเชื่อมต่อ peer
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: สื่อสารกับ [rustdesk-server](https://github.com/rustdesk/rustdesk-server), รอการเชื่อมต่อแบบ direct (TCP hole punching) หรือ relayed
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: โค้ดเฉพาะแพลตฟอร์ม
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: โค้ด Flutter สำหรับเดสก์ท็อปและมือถือ
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: JavaScript สำหรับ Flutter web client

## ภาพหน้าจอ

![ตัวจัดการการเชื่อมต่อ](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![เชื่อมต่อกับ PC Windows](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![โอนไฟล์](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![TCP Tunneling](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---