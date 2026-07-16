
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=en">انگلیسی</a>
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

# 💻 ویندوز در کانتینر داکر
یک روش نوآورانه و کارآمد برای استقرار سیستم‌عامل ویندوز (x64) بر روی سیستم لینوکس خود را با استفاده از قدرت Vagrant VM، libvirt و docker-compose کشف کنید. این فناوری‌ها با هم به شما امکان کانتینری‌سازی ویندوز را می‌دهند تا بتوانید یک نمونه ویندوز را همانند هر کانتینر داکر مدیریت کنید. این یکپارچگی بی‌نقص با روندهای کاری موجود، به طور قابل توجهی راحتی را افزایش داده و تخصیص منابع را بهینه می‌کند.

⭐ **اگر این پروژه به شما کمک کرد، فراموش نکنید که آن را ستاره‌دار کنید!**

## 📋 پیش‌نیازها

اطمینان حاصل کنید که سیستم شما شرایط زیر را دارد:

- **داکر:** نسخه ۲۰ یا بالاتر [(نصب داکر)](https://www.docker.com/)

- **سیستم‌عامل میزبان:** لینوکس

- **فعال بودن مجازی‌سازی:**
  - بررسی با:
    - `lscpu | grep -i Virtualization`
  - خروجی نشان می‌دهد:
    - `VT-x` → مجازی‌سازی اینتل پشتیبانی و فعال است.
    - `AMD-V` → مجازی‌سازی AMD پشتیبانی و فعال است.
  - اگر مجازی‌سازی فعال نیست، آن را در تنظیمات BIOS/UEFI فعال کنید.

- **`cgroup: host`** در فایل کامپوز الزامی است: libvirt و سرویس‌های وابسته به آن نیاز به دسترسی کامل به cgroup دارند، در غیر این صورت کانتینر روی میزبان‌های cgroup v2 اجرا نمی‌شود.

## 🚀 راهنمای استقرار

۱. فایل محیطی `.env` را ایجاد یا به‌روزرسانی کنید
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
۲. فایل `docker-compose.yml` را ایجاد کنید
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
۳. زمانی که می‌خواهید ماشین مجازی شما پایدار باشد، فایل `docker-compose.override.yml` را ایجاد کنید
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

4. اجرا کنید: `docker compose up -d`

> **راه‌اندازی اولیه چند دقیقه طول می‌کشد** — جعبه Vagrant از قبل در تصویر پخته شده است، اما ماشین مجازی هنوز باید بوت شود و اسکریپت آماده‌سازی را اجرا کند (نصب Chocolatey، تغییر اندازه دیسک، اصلاحات رجیستری). پیشرفت را با `docker compose logs -f` دنبال کنید.

> زمانی که می‌خواهید همه چیز را حذف کنید `docker compose down -v`

![تصویر ویندوز](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 دسترسی  

### Remote Desktop (RDP)  
برای اشکال‌زدایی یا تست، می‌توانید با استفاده از **Remote Desktop** و پورت `3389` به ماشین مجازی متصل شوید.  

#### نرم‌افزارهای دسترسی Remote Desktop  
| سیستم‌عامل | نرم‌افزار |
|------------|----------------|
| **لینوکس**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` یا [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **ویندوز**  | **Remote Desktop Connection** داخلی |

---

### SSH   
می‌توانید با استفاده از اعتبارسنجی کاربران **administrator** یا **Vagrant** از طریق SSH متصل شوید.  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 ورود کاربر
کاربران پیش‌فرض بر اساس تصویر Vagrant عبارتند از:

1. مدیر
    - نام کاربری: Administrator
    - رمز عبور: vagrant
2. کاربر
    - نام کاربری: vagrant
    - رمز عبور: vagrant

## ⚠️ محدودیت‌ها

- **فقط میزبان لینوکس** — وابسته به `/dev/kvm` و libvirt؛ میزبان‌های macOS و ویندوز پشتیبانی نمی‌شوند.
- **مجوز ارزیابی** — جعبه زیرین یک نسخه ارزیابی Windows Server 2022 را ارائه می‌دهد. فعال‌سازی طبق شرایط ارزیابی مایکروسافت منقضی می‌شود.
- **بدون فولدرهای همگام** — `rsync`، `smb` و `nfs` در [Vagrantfile](Vagrantfile) فعال نیستند (rsync قبل از اجرا نیاز به نصب در ویندوز دارد؛ فولدرهای همگام SMB با میزبان لینوکس پشتیبانی نمی‌شوند؛ nfs درون کانتینر با خطای `no support in current kernel` مواجه می‌شود).
- **عملکرد** — بدون KVM تو در تو برای Docker (مثلاً روی VM ابری که KVM را در دسترس نمی‌گذارد)، مهمان به QEMU ساده برمی‌گردد و چندین برابر کندتر اجرا می‌شود.

## 🔧 رفع اشکال

- **`KVM acceleration is not available`** در لاگ‌ها → میزبان `/dev/kvm` را در دسترس قرار نداده است. بررسی کنید مجازی‌سازی در BIOS فعال باشد، ماژول `kvm` بارگذاری شده باشد (`lsmod | grep kvm`)، و `/dev/kvm` روی میزبان وجود داشته باشد. اسکریپت راه‌اندازی به طور خودکار به QEMU برمی‌گردد؛ انتظار کاهش شدید سرعت را داشته باشید.
- **پورت 3389 / 2222 قبلاً استفاده شده** → سرویس RDP/SSH دیگری روی میزبان فعال است. آن را متوقف کنید یا نگاشت پورت سمت میزبان را در `docker-compose.yml` تغییر دهید.
- **کانتینر فوراً خارج می‌شود** → تقریباً همیشه مشکل cgroup یا سطح دسترسی است. تأیید کنید `privileged: true` و `cgroup: host` تنظیم شده‌اند، سپس لاگ‌های `docker compose logs win10` را بررسی کنید.
- **`vagrant up` روی "Waiting for domain to get an IP address" گیر می‌کند** → شبکه NAT پیش‌فرض libvirt فعال نیست. کانتینر را مجدداً راه‌اندازی کنید، یا از داخل آن دستور `virsh net-start default` را اجرا نمایید.

## 📚 مطالعه بیشتر و منابع

- [آموزش Vagrant ویندوز](https://github.com/SecurityWeekly/vulhub-lab)
- [تصویر Vagrant: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant توسط HashiCorp](https://www.vagrantup.com/)
- [ماشین مجازی ویندوز در کانتینر داکر لینوکس](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU داخل کانتینر](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---