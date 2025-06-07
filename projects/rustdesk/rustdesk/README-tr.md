<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - Uzaktan masaüstünüz"><br>
  <a href="#raw-steps-to-build">Derleme</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">Yapı</a> •
  <a href="#snapshot">Anlık Görüntü</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>Bu README’yi, <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">RustDesk UI</a> ve <a href="https://github.com/rustdesk/doc.rustdesk.com">RustDesk Dokümantasyonu</a>’nu ana dilinize çevirmemiz için yardıma ihtiyacımız var</b>
</p>

> [!Dikkat]
> **Yanlış Kullanım Sorumluluk Reddi:** <br>
> RustDesk geliştiricileri bu yazılımın etik olmayan veya yasa dışı herhangi bir şekilde kullanılmasını onaylamaz veya desteklemez. Yetkisiz erişim, kontrol veya gizliliğe tecavüz gibi yanlış kullanımlar kesinlikle yönergelerimize aykırıdır. Yazarlar uygulamanın yanlış kullanımından sorumlu tutulamaz.

Bizimle sohbet edin: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

Rust ile yazılmış bir başka uzaktan masaüstü yazılımı. Kutudan çıkar çıkmaz çalışır, yapılandırma gerektirmez. Verilerinizin tam kontrolü sizde, güvenlik konusunda endişeniz olmasın. Bizim buluşma/aktarma sunucumuzu kullanabilir, [kendi sunucunuzu kurabilir](https://rustdesk.com/server) veya [kendi buluşma/aktarma sunucunuzu yazabilirsiniz](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk, herkesin katkılarını memnuniyetle karşılar. Başlamak için [CONTRIBUTING.md](docs/CONTRIBUTING.md) dosyasına bakabilirsiniz.

[**SSS**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**İKİLİ DOSYA İNDİR**](https://github.com/rustdesk/rustdesk/releases)

[**GECE YAPISI**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="F-Droid'dan İndir"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Flathub'dan İndir"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## Bağımlılıklar

Masaüstü sürümleri için arayüzde Flutter veya Sciter (artık kullanılmıyor) kullanılır, bu doküman sadece Sciter içindir çünkü başlamak daha kolay ve dostçadır. Flutter sürümünü derlemek için [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) dosyamıza bakabilirsiniz.

Lütfen Sciter dinamik kütüphanesini kendiniz indirin.

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## Derleme için Temel Adımlar

- Rust geliştirme ortamınızı ve C++ derleme ortamınızı hazırlayın

- [vcpkg](https://github.com/microsoft/vcpkg) kurun ve `VCPKG_ROOT` ortam değişkenini doğru ayarlayın

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- `cargo run` komutunu çalıştırın

## [Derleme](https://rustdesk.com/docs/en/dev/build/)

## Linux'ta Nasıl Derlenir

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

### vcpkg Kurulumu

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### libvpx Düzelt (Fedora için)

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

### Derleme

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

## Docker ile Nasıl Derlenir

Depoyu klonlayıp Docker konteynerini oluşturun:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

Uygulamayı her derlemek istediğinizde şu komutu çalıştırın:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

İlk derlemenin bağımlılıklar önbelleğe alınmadan önce daha uzun sürebileceğini, sonraki derlemelerin ise daha hızlı olacağını unutmayın. Ayrıca, derleme komutuna farklı argümanlar vermeniz gerekirse, komutun sonundaki `<OPTIONAL-ARGS>` kısmında belirtebilirsiniz. Örneğin, optimize edilmiş bir sürüm derlemek isterseniz, yukarıdaki komutun sonuna `--release` ekleyin. Ortaya çıkan çalıştırılabilir dosya sisteminizde target klasöründe olacak ve şu şekilde çalıştırılabilir:

```sh
target/debug/rustdesk
```

Ya da, release sürümünü çalıştırıyorsanız:

```sh
target/release/rustdesk
```

Bu komutları RustDesk deposunun kök dizininden çalıştırdığınızdan emin olun, aksi takdirde uygulama gerekli kaynakları bulamayabilir. Ayrıca, `install` veya `run` gibi diğer cargo alt komutlarının şu anda bu yöntemle desteklenmediğini unutmayın; çünkü bunlar programı konteyner içinde kurar veya çalıştırır, ana makinede değil.

## Dosya Yapısı

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: video kodeği, yapılandırma, tcp/udp sarmalayıcı, protobuf, dosya transferi için fs fonksiyonları ve çeşitli yardımcı fonksiyonlar
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: ekran görüntüsü alma
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: platforma özel klavye/fare kontrolü
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: Windows, Linux, macOS için dosya kopyala/yapıştır desteği
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: eski Sciter arayüzü (artık kullanılmıyor)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: ses/pano/girdi/video servisleri ve ağ bağlantıları
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: eş bağlantısı başlatma
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: [rustdesk-server](https://github.com/rustdesk/rustdesk-server) ile iletişim, uzaktan doğrudan (TCP hole punching) veya yönlendirilmiş bağlantı bekleme
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: platforma özel kod
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: masaüstü ve mobil için Flutter kodu
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: Flutter web istemcisi için JavaScript

## Ekran Görüntüleri

![Bağlantı Yöneticisi](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Bir Windows PC'ye Bağlandı](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![Dosya Transferi](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![TCP Tünelleme](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---