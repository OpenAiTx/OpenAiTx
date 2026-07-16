
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 💻 Windows trong Docker Container
Khám phá một phương pháp sáng tạo và hiệu quả để triển khai hệ điều hành Windows (x64) trên hệ thống linux của bạn bằng sức mạnh của Vagrant VM, libvirt và docker-compose. Những công nghệ này kết hợp giúp bạn đóng gói hệ điều hành Windows vào container, cho phép bạn quản lý một phiên bản Windows giống như bất kỳ container Docker nào. Việc tích hợp liền mạch vào quy trình công việc hiện có này giúp tăng sự tiện lợi và tối ưu hóa phân bổ tài nguyên.

⭐ **Đừng quên đánh dấu sao dự án nếu nó đã giúp bạn!**

## 📋 Điều kiện tiên quyết

Đảm bảo hệ thống của bạn đáp ứng các yêu cầu sau:

- **Docker:** Phiên bản 20 trở lên [(Cài đặt Docker)](https://www.docker.com/)

- **Hệ điều hành máy chủ:** Linux

- **Đã bật ảo hóa:**
  - Kiểm tra với:
    - `lscpu | grep -i Virtualization`
  - Kết quả hiển thị:
    - `VT-x` → Hỗ trợ & đã bật ảo hóa Intel.
    - `AMD-V` → Hỗ trợ & đã bật ảo hóa AMD.
  - Nếu ảo hóa chưa bật, hãy bật nó trong cài đặt BIOS/UEFI.

- **`cgroup: host`** trong file compose là bắt buộc: libvirt và các daemon mà nó sinh ra cần toàn quyền truy cập cgroup, nếu không container sẽ không khởi động được trên máy chủ dùng cgroup v2.

## 🚀 Hướng dẫn triển khai

1. Tạo/Cập nhật file môi trường `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. Tạo `docker-compose.yml`
```yaml
services:
  win10:
    image: docker.io/vaggeliskls/windows-in-docker-container:latest
    platform: linux/amd64
    env_file: .env
    stdin_open: true
    tty: true
    privileged: true
    cgroup: host
    restart: always
    ports:
      - 3389:3389
      - 2222:2222
```
3. Tạo `docker-compose.override.yml` khi bạn muốn VM của mình được duy trì lâu dài
```yaml
services:
  win10:
    volumes:
      - libvirt_data:/var/lib/libvirt
      - vagrant_data:/root/.vagrant.d
      - vagrant_project:/app/.vagrant
      - libvirt_config:/etc/libvirt

volumes:
  libvirt_data:
    name: libvirt_data
  vagrant_data:
    name: vagrant_data
  vagrant_project:
    name: vagrant_project
  libvirt_config:
    name: libvirt_config
```
4. Chạy: `docker compose up -d`

> **Khởi động lần đầu mất vài phút** — Hộp Vagrant đã được tích hợp sẵn vào image, nhưng máy ảo vẫn cần khởi động và chạy script chuẩn bị (cài đặt Chocolatey, thay đổi kích thước ổ đĩa, chỉnh sửa registry). Theo dõi tiến trình với `docker compose logs -f`.

> Khi bạn muốn hủy bỏ mọi thứ, hãy dùng `docker compose down -v`

![ảnh chụp màn hình windows](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Truy cập  

### Remote Desktop (RDP)  
Để gỡ lỗi hoặc kiểm thử, bạn có thể kết nối tới máy ảo bằng **Remote Desktop** qua cổng `3389`.  

#### Phần mềm truy cập Remote Desktop  
| Hệ điều hành | Phần mềm |
|-------------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` hoặc [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | **Remote Desktop Connection** tích hợp sẵn |

---

### SSH   
Bạn có thể kết nối qua SSH bằng thông tin đăng nhập của người dùng **administrator** hoặc **Vagrant**.  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 Đăng nhập Người dùng
Người dùng mặc định dựa trên hình ảnh Vagrant là:

1. Administrator
    - Tên đăng nhập: Administrator
    - Mật khẩu: vagrant
2. User
    - Tên đăng nhập: vagrant
    - Mật khẩu: vagrant

## ⚠️ Hạn chế

- **Chỉ hỗ trợ máy chủ Linux** — dựa vào `/dev/kvm` và libvirt; không hỗ trợ máy chủ macOS và Windows.
- **Giấy phép đánh giá** — box nền tảng cung cấp bản sao Windows Server 2022 dạng đánh giá. Kích hoạt sẽ hết hạn theo điều khoản đánh giá của Microsoft.
- **Không có thư mục đồng bộ** — `rsync`, `smb` và `nfs` đều bị vô hiệu hóa trong [Vagrantfile](Vagrantfile) (rsync cần cài đặt phía Windows trước khi chạy provisioning; SMB không hỗ trợ thư mục đồng bộ với máy chủ Linux; NFS trong container gặp lỗi `no support in current kernel`).
- **Hiệu năng** — nếu Docker không có KVM lồng (ví dụ trên VM đám mây không lộ KVM), máy khách sẽ chuyển sang QEMU thuần và chậm hơn nhiều lần.

## 🔧 Khắc phục sự cố

- **`KVM acceleration is not available`** trong log → máy chủ không cung cấp `/dev/kvm`. Kiểm tra đã bật ảo hóa trong BIOS, module `kvm` đã tải (`lsmod | grep kvm`), và `/dev/kvm` tồn tại trên máy chủ. Script khởi động sẽ tự động chuyển sang QEMU; mong đợi hiệu năng giảm mạnh.
- **Cổng 3389 / 2222 đã sử dụng** → dịch vụ RDP/SSH khác đã chiếm trên máy chủ. Dừng nó hoặc đổi ánh xạ cổng phía máy chủ trong `docker-compose.yml`.
- **Container thoát ngay lập tức** → hầu hết là lỗi cgroup hoặc quyền hạn. Xác nhận đã đặt `privileged: true` và `cgroup: host`, sau đó kiểm tra `docker compose logs win10`.
- **`vagrant up` treo ở "Waiting for domain to get an IP address"** → mạng NAT mặc định của libvirt chưa chạy. Khởi động lại container, hoặc chạy `virsh net-start default` từ bên trong nó.

## 📚 Đọc thêm và Tài nguyên

- [Hướng dẫn Windows Vagrant](https://github.com/SecurityWeekly/vulhub-lab)
- [Hình ảnh Vagrant: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant bởi HashiCorp](https://www.vagrantup.com/)
- [Máy ảo Windows trong Container Docker Linux](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU bên trong container](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---