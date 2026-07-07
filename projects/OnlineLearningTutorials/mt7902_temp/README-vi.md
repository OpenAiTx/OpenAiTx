
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 Trình điều khiển MT7902 như một phần phụ của trình điều khiển MT7921 (✅ Hoạt động)
Chip wifi 6E Mediatek mt7902 hỗ trợ Bluetooth và WiFi

> [!IMPORTANT]
> Kernel Linux 7.1 chính thức hỗ trợ chip WIFI 6E MT7902


## 📁 Nhân bản kho lưu trữ
Sao chép kho lưu trữ về máy tính cá nhân của bạn
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
Nếu bạn không muốn sao chép lịch sử trước đó thì
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## Cài đặt


### 🚀 Script Hướng dẫn Cài đặt (Khuyến nghị cho hệ thống dựa trên Ubuntu)
Hãy làm cho script có thể thực thi nếu chưa có
```
chmod +x ./install_guide.sh
```
Bây giờ hãy chạy script này
```
./install_guide.sh
```
Nó sẽ tự động yêu cầu mật khẩu khi cần thiết
* Script này sẽ yêu cầu bạn cài đặt firmware, driver bluetooth và wifi từng bước một
* Đã được kiểm tra trên Ubuntu với nhân linux 7.0

### 🚀 Sửa lỗi tự động dễ dàng (Khuyến nghị cho hệ thống dựa trên Arch)
Nếu bạn muốn nhanh chóng sửa WiFi và Bluetooth trên bất kỳ nhân hiện đại nào, hãy làm theo các bước sau:

Làm cho script trở nên có thể thực thi nếu chưa
```
chmod +x ./fix_my_wifi.sh
```

**Chạy script sửa lỗi tự động** với quyền sudo:
```bash
sudo bash fix_my_wifi.sh
```
#### 📖 Kịch bản này thực hiện những gì:
* **Kiểm tra các phụ thuộc:** Đảm bảo bạn đã cài đặt `gcc`/`clang`, `make`, `bc`, và `kernel-headers` hiện tại. Nếu chưa có - sẽ tự động cài đặt bằng trình quản lý gói mà bạn chọn
* **Biên dịch Driver:** Tự động biên dịch cả driver WiFi và Bluetooth phù hợp với đúng phiên bản kernel của bạn.
* **Khắc phục lâu dài:** Cài đặt một dịch vụ hệ thống đảm bảo WiFi của bạn luôn hoạt động ngay cả sau khi khởi động lại máy tính.
* **An toàn:** Cài đặt module vào thư mục riêng (`/lib/modules/mt7902_custom`) để tránh làm ảnh hưởng đến các tệp hệ thống mặc định.

> [!NOTE]
> Bạn sẽ cần kết nối Internet (qua Ethernet hoặc chia sẻ USB từ điện thoại) lần đầu tiên chạy để tải về các công cụ cần thiết để xây dựng. (Ví dụ như compiler, linux-headers, v.v.)


## ✅ Đã kiểm tra trên (Đã xác thực hoạt động)
Bản vá này đã được xác minh và xác nhận hoạt động trên:

* **Thương hiệu:** ASUS
* **Mẫu:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **Chipset:** MediaTek MT7902 (WiFi 6E)
* **Phiên bản Kernel:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **Hệ điều hành:** Arch, Ubuntu
* **Trình quản lý gói:** pacman, apt

## Có sẵn cho:
* **Hệ điều hành**: Bất kỳ hệ điều hành nào hỗ trợ một trong các trình quản lý gói
* **Trình quản lý gói ưu tiên:** apt, pacman, dnf, zypper, nix-shell
* **Phiên bản Kernel:** 6.14-7.0.7


## 🔧 Firmware sử dụng
Firmware được lưu trong thư mục `firmware`.


## 📱 Bluetooth ✅ (Hoạt động)
> [!WARNING]
> Nếu driver bluetooth xung đột với `gen4-mt7902` thì vui lòng xóa firmware bluetooth để không gây can thiệp đến driver này
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> Dự án này sử dụng firmware
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Để bật bluetooth, hãy vào thư mục tương ứng với phiên bản kernel hiện tại của bạn. ``
Ví dụ nếu bạn dùng kernel linux-6.16 thì vào thư mục `./linux-6.16/drivers/bluetooth` .

Mở terminal trong thư mục này và biên dịch với lệnh `make`.
Hai mô-đun kernel được biên dịch là `btusb.ko` và `btmtk.ko`.
Để kích hoạt bluetooth trên thiết bị của bạn, hãy gỡ bỏ btusb và btmtk trong hệ thống và cài đặt hai tệp này, sử dụng các lệnh
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
Bây giờ hãy kiểm tra xem bluetooth của bạn đã hoạt động chưa.

## 💻 WiFi ✅ (Hoạt động)
> [!QUAN TRỌNG]
> Một kho lưu trữ hoạt động với một số hạn chế có tại [đây](https://github.com/hmtheboy154/gen4-mt7902)

Trình điều khiển WiFi cho mt7902, vừa được Mediatek phát hành gần đây, nằm trong thư mục `latest`.

Nếu bạn đang sử dụng Ubuntu thì chỉ cần vào thư mục `latest` và chạy lệnh sau trong terminal.
```
make
```
Nó sẽ biên dịch tất cả các mô-đun, nén lại và cài đặt nó (thay thế mô-đun kernel gốc bằng mô-đun đã chỉnh sửa). Nếu bạn dùng bản phân phối khác hoặc không muốn thực hiện tất cả các bước mà chỉ muốn biên dịch mã, hãy chạy trong terminal

```
make module_compile
```
Để nén module bạn đã biên dịch, sau đó chạy trong terminal
```
make module_compress
```
Để cài đặt mô-đun đã nén vào mô-đun kernel của hệ thống, hãy chạy trong terminal
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---