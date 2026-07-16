
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

# 💻 Windows di dalam Kontainer Docker
Temukan metode inovatif dan efisien untuk menjalankan OS Windows (x64) pada sistem Linux Anda dengan memanfaatkan kekuatan Vagrant VM, libvirt, dan docker-compose. Ketiga teknologi ini memungkinkan Anda mengkontainerisasi OS Windows, sehingga Anda dapat mengelola sebuah instance Windows layaknya kontainer Docker biasa. Integrasi mulus ke dalam alur kerja yang sudah ada ini secara signifikan meningkatkan kenyamanan dan mengoptimalkan alokasi sumber daya.

⭐ **Jangan lupa untuk memberi bintang pada proyek ini jika bermanfaat untuk Anda!**

## 📋 Prasyarat

Pastikan sistem Anda memenuhi persyaratan berikut:

- **Docker:** Versi 20 atau lebih tinggi [(Instal Docker)](https://www.docker.com/)

- **Host OS:** Linux

- **Virtualisasi Diaktifkan:**
  - Periksa dengan:
    - `lscpu | grep -i Virtualization`
  - Output menunjukkan:
    - `VT-x` → Virtualisasi Intel didukung & diaktifkan.
    - `AMD-V` → Virtualisasi AMD didukung & diaktifkan.
  - Jika virtualisasi belum diaktifkan, aktifkan di pengaturan BIOS/UEFI.

- **`cgroup: host`** dalam file compose diperlukan: libvirt dan daemon yang dijalankan membutuhkan akses penuh ke cgroup, jika tidak kontainer gagal dijalankan pada host cgroup v2.

## 🚀 Panduan Deploy

1. Buat/Perbarui file lingkungan `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. Buat `docker-compose.yml`
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
3. Buat `docker-compose.override.yml` ketika Anda ingin VM Anda bersifat persisten
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
4. Jalankan: `docker compose up -d`

> **Boot pertama memerlukan beberapa menit** — Vagrant box sudah disertakan dalam image, namun VM tetap harus booting dan menjalankan provisioning script (instalasi Chocolatey, resize disk, tweak registry). Ikuti progres dengan `docker compose logs -f`.

> Jika Anda ingin menghancurkan semuanya `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Akses  

### Remote Desktop (RDP)  
Untuk debugging atau pengujian, Anda dapat terhubung ke VM menggunakan **Remote Desktop** pada port `3389`.  

#### Perangkat Lunak untuk Akses Remote Desktop  
| OS       | Perangkat Lunak |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` atau [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | **Remote Desktop Connection** bawaan |

---

### SSH   
Anda dapat terhubung melalui SSH menggunakan kredensial pengguna **administrator** atau **Vagrant**.  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 Login Pengguna
Pengguna default berdasarkan image Vagrant adalah:

1. Administrator
    - Nama Pengguna: Administrator
    - Kata Sandi: vagrant
2. Pengguna
    - Nama Pengguna: vagrant
    - Kata Sandi: vagrant

## ⚠️ Keterbatasan

- **Hanya host Linux** — bergantung pada `/dev/kvm` dan libvirt; host macOS dan Windows tidak didukung.
- **Lisensi eval** — box mendasar mengirimkan salinan evaluasi Windows Server 2022. Aktivasi akan berakhir sesuai dengan ketentuan evaluasi Microsoft.
- **Tidak ada folder yang disinkronkan** — `rsync`, `smb`, dan `nfs` semuanya tidak terhubung dalam [Vagrantfile](Vagrantfile) (rsync membutuhkan instalasi di sisi Windows sebelum provisioning berjalan; folder SMB yang disinkronkan tidak didukung dengan host Linux; NFS dalam container terkena `no support in current kernel`).
- **Performa** — tanpa KVM bertingkat yang tersedia untuk Docker (misalnya pada VM cloud yang tidak mengekspor KVM), guest akan kembali ke QEMU biasa dan beberapa kali lebih lambat.

## 🔧 Pemecahan Masalah

- **`KVM acceleration is not available`** di log → host tidak mengekspor `/dev/kvm`. Periksa virtualisasi sudah diaktifkan di BIOS, modul `kvm` sudah dimuat (`lsmod | grep kvm`), dan `/dev/kvm` ada di host. Skrip startup akan kembali ke QEMU secara otomatis; harapkan perlambatan besar.
- **Port 3389 / 2222 sudah digunakan** → layanan RDP/SSH lain sudah terikat di host. Matikan, atau ubah pemetaan port di sisi host pada `docker-compose.yml`.
- **Container langsung keluar** → hampir selalu masalah cgroup atau privilege. Pastikan `privileged: true` dan `cgroup: host` sudah diatur, lalu periksa `docker compose logs win10`.
- **`vagrant up` berhenti di "Waiting for domain to get an IP address"** → jaringan NAT default libvirt tidak berjalan. Restart container, atau jalankan `virsh net-start default` dari dalamnya.

## 📚 Bacaan dan Referensi Lanjutan

- [Tutorial Vagrant Windows](https://github.com/SecurityWeekly/vulhub-lab)
- [Image Vagrant: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant oleh HashiCorp](https://www.vagrantup.com/)
- [Mesin Virtual Windows dalam Container Docker Linux](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU di dalam container](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---