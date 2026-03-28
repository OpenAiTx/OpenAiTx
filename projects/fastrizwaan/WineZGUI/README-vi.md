
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### Giao diện đồ họa Wine sử dụng Zenity - Chơi và Chia sẻ!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Tải về từ Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## WineZGUI là gì

WineZGUI (phát âm là Wine-Zee-Goo-Eee) là một giao diện người dùng cho Wine, giúp chơi game Windows trên Wine dễ dàng hơn. Đây là tập hợp các script Bash để quản lý Wine Prefix và tích hợp với Desktop Linux, nhằm mang lại trải nghiệm chơi game Wine thuận tiện hơn bằng Zenity. Nó cho phép khởi chạy nhanh các ứng dụng hoặc game EXE Direct play (không cài đặt) từ trình quản lý tệp như Nautilus và cho phép tạo wine prefix riêng cho từng tệp EXE của Windows.

## Tại sao nên dùng WineZGUI?

1. Chạy game hoặc tệp exe Windows trực tiếp từ trình quản lý tệp
2. Tạo lối tắt ứng dụng để truy cập dễ dàng hơn.
3. Tập trung vào chơi game thay vì thiết lập prefix.
4. Sao lưu và khôi phục prefix để sử dụng sau này.
5. Tạo Game Bundles để chia sẻ (prefix+game)

## Cách hoạt động

1. Khi một tệp nhị phân hoặc exe Windows được mở bằng WineZGUI,
2. Nó tạo một prefix mới (sao chép mẫu) và một lối tắt trên desktop với tên tệp EXE.
3. Khi người dùng chạy script, exe sẽ được khởi động.
4. Nếu là file cài đặt, nó sẽ phát hiện exe đã cài và tạo lối tắt trong danh mục Games menu.

## Cách chạy Game hoặc Chương trình trên ổ hoặc thư mục khác

Mở Terminal của bạn và gõ lệnh sau:

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### Cài đặt WineZGUI

WineZGUI có sẵn dưới dạng Flatpak trên Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Tải về trên Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

WineZGUI từ Flathub chỉ có thể truy cập Desktop, Documents, Downloads, Music, Pictures, Videos. Để truy cập file từ các vị trí khác hoặc các phân vùng/ổ đĩa gắn ngoài, bạn có thể sao chép chúng vào các thư mục đã đề cập (Downloads, v.v.) hoặc cần cấp quyền đọc, có thể thực hiện bằng ứng dụng Flatseal hoặc dòng lệnh `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

Tôi rất khuyến nghị sử dụng phiên bản flatpak, vì wine của distro (wine-staging) thường xuyên cập nhật và game có thể bị lỗi mỗi vài ngày. Sử dụng wine stable từ flathub sẽ ổn định hơn hoặc dùng wine stable 5.0 hoặc 7.0 từ các gói của distro.

#### Cài đặt flatpak WineZGUI trên [distro Linux được hỗ trợ](https://flatpak.org/setup/)

WineZGUI được đóng gói trong flatpak-wine bởi chính tôi. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) và flatpak trước đây của tôi giờ đã ngưng hỗ trợ [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)


### CÀI ĐẶT trên hệ thống Linux, xem [Yêu cầu](https://github.com/fastrizwaan/WineZGUI#requirements)

Cài đặt diễn ra ngay lập tức vì chỉ sao chép một vài tệp vào các thư mục cụ thể.

##### Phiên bản 0.99.13

Tải mã nguồn [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) hoặc sử dụng `git tag 0.99.13`

##### Sử dụng tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### git tag 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### Phiên bản phát triển

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### Gỡ cài đặt WineZGUI

##### Gỡ cài đặt Flatpak

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### Gỡ cài đặt hệ thống

Chạy `uninstall` từ cùng thư mục nguồn cài đặt

```
sudo ./setup --uninstall
```

## Yêu cầu

`wine` - chương trình chính

`winetricks` - script addon cần có cho wine

`perl‑image‑exiftool` - để trích xuất tên ứng dụng/trò chơi

`icoutils` - để trích xuất biểu tượng từ file exe

`gnome-terminal` - (tùy chọn) để truy cập thư mục prefix trong shell

## Cài đặt yêu cầu cho hệ điều hành Linux

### Các bản phân phối hỗ trợ Flatpak

Tải [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) bao gồm tất cả các phụ thuộc. Hữu ích cho các bản phân phối không đóng gói wine.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Các phụ thuộc thời gian chạy:

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### Solus

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### Arch Linux / EndeavourOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### Bộ điều khiển tương thích XBOX

biên dịch và cài đặt trình điều khiển kernel cho các bộ điều khiển tương thích xbox 360 từ https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---