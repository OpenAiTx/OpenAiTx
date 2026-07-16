
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

# 💻 Windows ใน Docker Container
ค้นพบวิธีการใหม่ที่มีประสิทธิภาพในการติดตั้งระบบปฏิบัติการ Windows (x64) บนระบบ Linux ของคุณโดยใช้พลังของ Vagrant VM, libvirt และ docker-compose เทคโนโลยีเหล่านี้ช่วยให้คุณสามารถคอนเทนเนอร์ไลซ์ Windows OS และจัดการอินสแตนซ์ Windows ได้เหมือนกับคอนเทนเนอร์ Docker อื่น ๆ การผสานรวมนี้เข้ากับเวิร์กโฟลว์ที่มีอยู่จะช่วยเพิ่มความสะดวกและเพิ่มประสิทธิภาพการใช้งานทรัพยากรอย่างมาก

⭐ **อย่าลืมกดดาวให้โปรเจกต์หากมันช่วยคุณได้!**

## 📋 ข้อกำหนดเบื้องต้น

ตรวจสอบให้แน่ใจว่าระบบของคุณตรงตามข้อกำหนดดังต่อไปนี้:

- **Docker:** เวอร์ชัน 20 ขึ้นไป [(ติดตั้ง Docker)](https://www.docker.com/)

- **ระบบปฏิบัติการโฮสต์:** Linux

- **เปิดใช้งาน Virtualization:**
  - ตรวจสอบด้วยคำสั่ง:
    - `lscpu | grep -i Virtualization`
  - ผลลัพธ์แสดงว่า:
    - `VT-x` → รองรับและเปิดใช้งาน Intel virtualization แล้ว
    - `AMD-V` → รองรับและเปิดใช้งาน AMD virtualization แล้ว
  - หากยังไม่เปิดใช้งาน virtualization ให้เปิดใน BIOS/UEFI

- **`cgroup: host`** ในไฟล์ compose เป็นสิ่งจำเป็น: libvirt และ daemon ที่มันสร้างขึ้นต้องการสิทธิ์เข้าถึง cgroup ทั้งหมด มิฉะนั้นคอนเทนเนอร์จะไม่สามารถเริ่มได้บนโฮสต์ที่ใช้ cgroup v2

## 🚀 คู่มือการติดตั้ง

1. สร้างหรืออัปเดตไฟล์ตัวแปรสภาพแวดล้อม `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. สร้างไฟล์ `docker-compose.yml`
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
3. สร้างไฟล์ `docker-compose.override.yml` เมื่อคุณต้องการให้ VM ของคุณคงอยู่ถาวร
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
4. รัน: `docker compose up -d`

> **การบู๊ตครั้งแรกจะใช้เวลาหลายนาที** — Vagrant box ถูกบรรจุไว้ในอิมเมจแล้ว แต่ VM ยังต้องบู๊ตและรันสคริปต์ provisioning (ติดตั้ง Chocolatey, ขยายขนาดดิสก์, ปรับ registry) ติดตามความคืบหน้าด้วย `docker compose logs -f`

> เมื่อคุณต้องการทำลายทุกอย่าง ใช้ `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 การเข้าถึง  

### Remote Desktop (RDP)  
สำหรับดีบักหรือทดสอบ คุณสามารถเชื่อมต่อกับ VM โดยใช้ **Remote Desktop** ที่พอร์ต `3389`  

#### ซอฟต์แวร์สำหรับการเข้าถึง Remote Desktop  
| OS       | ซอฟต์แวร์ |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` หรือ [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | **Remote Desktop Connection** ที่มาพร้อมเครื่อง |

---

### SSH   
คุณสามารถเชื่อมต่อผ่าน SSH โดยใช้ข้อมูลผู้ใช้ **administrator** หรือ **Vagrant**

```bash
ssh <user>@<host> -p 2222
```

## 🔑 การเข้าสู่ระบบผู้ใช้
ผู้ใช้เริ่มต้นตามอิมเมจ Vagrant มีดังนี้:

1. ผู้ดูแลระบบ
    - ชื่อผู้ใช้: Administrator
    - รหัสผ่าน: vagrant
2. ผู้ใช้ทั่วไป
    - ชื่อผู้ใช้: vagrant
    - รหัสผ่าน: vagrant

## ⚠️ ข้อจำกัด

- **รองรับเฉพาะ Linux host เท่านั้น** — ขึ้นอยู่กับ `/dev/kvm` และ libvirt; ไม่รองรับ macOS และ Windows host
- **ใบอนุญาตทดลองใช้** — กล่องที่ใช้เป็นสำเนาทดลองของ Windows Server 2022 การเปิดใช้งานหมดอายุตามเงื่อนไขการทดลองของ Microsoft
- **ไม่มีการ sync โฟลเดอร์** — `rsync`, `smb` และ `nfs` ถูกปิดใน [Vagrantfile](Vagrantfile) (rsync ต้องติดตั้งฝั่ง Windows ก่อนรัน provisioning; SMB sync ไม่รองรับกับ Linux host; NFS ใน container จะเจอ `no support in current kernel`)
- **ประสิทธิภาพ** — หากไม่มี nested KVM ให้กับ Docker (เช่นบน cloud VM ที่ไม่เปิดเผย KVM) แขกจะ fallback เป็น QEMU ปกติและช้ากว่าหลายเท่า

## 🔧 การแก้ไขปัญหา

- **`KVM acceleration is not available`** ใน log → host ไม่เปิดเผย `/dev/kvm` ตรวจสอบว่าเปิด virtualization ใน BIOS, โหลด module `kvm` แล้ว (`lsmod | grep kvm`) และมี `/dev/kvm` บน host สคริปต์เริ่มต้นจะ fallback เป็น QEMU อัตโนมัติ คาดว่าจะช้าลงมาก
- **Port 3389 / 2222 ถูกใช้งานแล้ว** → มีบริการ RDP/SSH อื่นรันอยู่บน host ให้หยุดหรือเปลี่ยน mapping port ฝั่ง host ใน `docker-compose.yml`
- **Container ปิดตัวทันที** → เกิดจากปัญหา cgroup หรือสิทธิ์ ตรวจสอบว่า `privileged: true` และ `cgroup: host` ถูกตั้งไว้ จากนั้นดู log ด้วย `docker compose logs win10`
- **`vagrant up` ค้างที่ "Waiting for domain to get an IP address"** → เครือข่าย NAT ดีฟอลต์ของ libvirt ไม่ทำงาน ให้ restart container หรือสั่ง `virsh net-start default` จากข้างใน

## 📚 อ่านเพิ่มเติมและแหล่งข้อมูล

- [Windows Vagrant Tutorial](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrant image: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant by HashiCorp](https://www.vagrantup.com/)
- [Windows Virtual Machine in a Linux Docker Container](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU inside a container](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---