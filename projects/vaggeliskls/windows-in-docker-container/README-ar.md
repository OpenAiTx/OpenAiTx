
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# 💻 ويندوز في حاوية دوكر
اكتشف طريقة مبتكرة وفعّالة لنشر نظام التشغيل ويندوز (x64) على نظام لينكس الخاص بك باستخدام قوة Vagrant VM و libvirt و docker-compose. تساعدك هذه التقنيات معًا على تحويل نظام ويندوز إلى حاوية، مما يمكّنك من إدارة نسخة ويندوز كما تدير أي حاوية دوكر أخرى. هذا التكامل السلس مع سير العمل الحالي يعزز بشكل كبير من الراحة ويحسّن تخصيص الموارد.

⭐ **لا تنسَ وضع نجمة للمشروع إذا أفادك!**

## 📋 المتطلبات الأساسية

تأكد أن نظامك يلبي المتطلبات التالية:

- **دوكر:** الإصدار 20 أو أعلى [(تثبيت دوكر)](https://www.docker.com/)

- **نظام التشغيل المستضيف:** لينكس

- **تمكين المحاكاة الافتراضية:**
  - تحقق باستخدام:
    - `lscpu | grep -i Virtualization`
  - يشير الناتج إلى:
    - `VT-x` → المحاكاة الافتراضية من إنتل مدعومة ومفعلة.
    - `AMD-V` → المحاكاة الافتراضية من AMD مدعومة ومفعلة.
  - إذا لم تكن المحاكاة الافتراضية مفعلة، قم بتمكينها من إعدادات BIOS/UEFI.

- **`cgroup: host`** في ملف التكوين مطلوب: libvirt والخوادم التي ينشئها تحتاج صلاحية وصول كاملة إلى cgroup، وإلا سيفشل الحاوية في البدء على الأنظمة التي تستخدم cgroup v2.

## 🚀 دليل النشر

1. أنشئ/حدّث ملف البيئة `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. أنشئ `docker-compose.yml`
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
3. أنشئ ملف `docker-compose.override.yml` عندما تريد أن تكون الآلة الافتراضية (VM) الخاصة بك مستدامة
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

4. شغّل: `docker compose up -d`

> **الإقلاع الأول يستغرق عدة دقائق** — صندوق Vagrant مضمن بالفعل في الصورة، ولكن لا يزال على الجهاز الافتراضي الإقلاع وتشغيل سكريبت التهيئة (تثبيت Chocolatey، توسيع القرص، تعديلات الريجستري). تابع التقدم باستخدام `docker compose logs -f`.

> عندما تريد إزالة كل شيء استخدم `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 الوصول  

### سطح المكتب البعيد (RDP)  
لأغراض التصحيح أو الاختبار، يمكنك الاتصال بالجهاز الافتراضي باستخدام **سطح المكتب البعيد** على المنفذ `3389`.  

#### البرامج للوصول إلى سطح المكتب البعيد  
| نظام التشغيل | البرنامج |
|--------------|----------------|
| **لينكس**    | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` أو [`Remmina`](https://remmina.org/) |
| **ماك أو إس** | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **ويندوز**   | أداة **الاتصال بسطح المكتب البعيد** المدمجة |

---

### SSH   
يمكنك الاتصال عبر SSH باستخدام بيانات اعتماد المستخدم **administrator** أو **Vagrant**.  
```bash
ssh <user>@<host> -p 2222
```

## 🔑 تسجيل دخول المستخدم
المستخدمون الافتراضيون بناءً على صورة Vagrant هم:

1. المسؤول
    - اسم المستخدم: Administrator
    - كلمة المرور: vagrant
2. المستخدم
    - اسم المستخدم: vagrant
    - كلمة المرور: vagrant

## ⚠️ القيود

- **يعمل فقط على نظام لينكس** — يعتمد على `/dev/kvm` و libvirt؛ لا يدعم أنظمة macOS و Windows.
- **ترخيص تجريبي** — الحزمة الأساسية توفر نسخة تجريبية من Windows Server 2022. تنتهي فترة التفعيل وفقًا لشروط مايكروسوفت.
- **لا توجد مجلدات متزامنة** — `rsync`، `smb`، و`nfs` جميعها غير مفعلة في [Vagrantfile](Vagrantfile) (يحتاج rsync لتثبيت على جانب ويندوز قبل بدء التهيئة؛ مجلدات SMB المتزامنة غير مدعومة مع مضيف لينكس؛ داخل الحاوية يصادف NFS رسالة `لا يوجد دعم في النواة الحالية`).
- **الأداء** — في حال عدم توفر KVM المتداخل لـ Docker (مثلاً عند استخدام VM سحابية لا تتيح KVM)، يعود النظام إلى QEMU العادي ويصبح الأداء أبطأ بعدة مرات.

## 🔧 استكشاف الأخطاء وإصلاحها

- **`KVM acceleration is not available`** في السجلات → المضيف لا يتيح `/dev/kvm`. تحقق من تفعيل المحاكاة الافتراضية في BIOS، تحميل وحدة `kvm` (`lsmod | grep kvm`)، ووجود `/dev/kvm` على المضيف. يبدأ البرنامج تلقائيًا باستخدام QEMU؛ توقع تباطؤًا كبيرًا.
- **المنفذ 3389 / 2222 مستخدم بالفعل** → خدمة RDP/SSH أخرى مرتبطة بالمضيف. أوقفها أو غير تعيين المنفذ في `docker-compose.yml`.
- **الحاوية تغلق فورًا** → غالبًا مشكلة في cgroup أو الأذونات. تأكد من وجود `privileged: true` و`cgroup: host`، ثم تحقق من سجلات `docker compose logs win10`.
- **`vagrant up` يتوقف عند "Waiting for domain to get an IP address"** → شبكة NAT الافتراضية لـ libvirt غير مفعلة. أعد تشغيل الحاوية أو نفذ `virsh net-start default` من داخلها.

## 📚 القراءة والموارد الإضافية

- [دليل Vagrant لـ Windows](https://github.com/SecurityWeekly/vulhub-lab)
- [صورة Vagrant: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant بواسطة HashiCorp](https://www.vagrantup.com/)
- [ماكينة ويندوز افتراضية داخل حاوية Docker على لينكس](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [تشغيل GPU داخل الحاوية](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---