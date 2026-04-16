
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Nutty [![Trạng thái dịch](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Trạng thái Build](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Quyên góp](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Một tiện ích mạng

Tác giả: Siddhartha Das

Một ứng dụng đơn giản được tạo ra cho elementary OS để cung cấp các thông tin thiết yếu liên quan đến mạng. Thông tin được trình bày dưới dạng các tab sau.<br>
1. Thông tin của tôi: Cung cấp thông tin cơ bản và chi tiết về card mạng của thiết bị<br>
2. Sử dụng: Cung cấp dữ liệu sử dụng mạng theo hai chế độ xem - sử dụng lịch sử và sử dụng hiện tại<br>
3. Tốc độ: Kiểm tra tốc độ Tải lên và Tải xuống và lấy thời gian định tuyến đến một máy chủ<br>
4. Cổng: Cung cấp thông tin về các cổng đang hoạt động và ứng dụng đang sử dụng chúng trên thiết bị cục bộ<br>
5. Thiết bị: Giám sát, cảnh báo và cung cấp thông tin về các thiết bị khác được kết nối trong mạng<br>

Kiểm tra trang web Nutty để biết chi tiết về các tính năng, phím tắt, hướng dẫn cài đặt cho Ubuntu và các bản phân phối được hỗ trợ khác, v.v.: <br>
https://babluboy.github.io/nutty/

## Xây dựng, Kiểm tra và Cài đặt từ Mã nguồn

Bạn sẽ cần các phụ thuộc sau để xây dựng:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

Và các phụ thuộc này để thực thi:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Đôi khi vnstat không được khởi động sau khi cài đặt, hãy sử dụng lệnh hệ thống khởi tạo thích hợp để khởi động tiến trình vnstat, ví dụ: `sudo systemctl enable vnstat`

Chạy `meson build` để cấu hình môi trường xây dựng và chạy `ninja test` để xây dựng

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```

Để cài đặt, sử dụng `sudo ninja install`, sau đó chạy với `com.github.babluboy.nutty`

```
sudo ninja install
com.github.babluboy.nutty
```
Để gỡ cài đặt, hãy vào thư mục build và chạy

```
sudo ninja uninstall
```

### Cài đặt từ gói Deb

Để cài đặt Nutty từ gói `.deb`, hãy đảm bảo bạn đã cài đặt tất cả các phụ thuộc thực thi của Nutty như đã đề cập ở trên (không cần các phụ thuộc biên dịch). Sau đó chạy lệnh dưới đây
```bash
sudo dpkg -i <deb-package-name>.deb
```
Và để gỡ cài đặt Nutty đã được cài đặt qua gói `.deb`, hãy chạy

```bash
sudo apt autoremove com.github.babluboy.nutty
```
Nếu bạn muốn tự mình xây dựng gói `.deb` của Nutty thì hãy cài đặt các phụ thuộc xây dựng ở trên và sau đó chạy

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---