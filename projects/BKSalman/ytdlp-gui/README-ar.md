# ytdlp-gui
واجهة مستخدم رسومية لـ yt-dlp مكتوبة بلغة Rust

- [التثبيت](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [فيدورا](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [أوبونتو](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [توزيعات أخرى](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [ويندوز](https://github.com/BKSalman/ytdlp-gui#windows)
- [البناء من المصدر](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [الإعداد](https://github.com/BKSalman/ytdlp-gui#configuration)
- [المساهمة](https://github.com/BKSalman/ytdlp-gui#contribution)

# معاينة
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# التثبيت
## لينكس

### NixOS (Flake)
يمكنك استخدام flake.nix الموجود في المستودع

في ملف `flake.nix` الخاص بك:
```nix
{
  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs/nixpkgs-unstable";

    ytdlp-gui = {
      url = "github:bksalman/ytdlp-gui";
    };
  };

    outputs = { nixpkgs, ytdlp-gui, ...}:
    let
      system = "x86_64-linux";

      pkgs = import nixpkgs {
        inherit system;
        overlays = [
          ytdlp-gui.overlay
        ];
      };
    in
    {
      ...snip
```

ثم يمكنك إضافته كحزمة عادية، إما إلى home-manager أو nixosConfiguration

### فيدورا
قم بتحميل حزمة rpm من صفحة الإصدارات ثم قم بتثبيتها باستخدام الأمر ``sudo dnf localinstall <rpm_package_name>``

### أوبونتو
قم بتحميل حزمة deb من صفحة الإصدارات ثم قم بتثبيتها باستخدام الأمر ``sudo apt install ./<deb_package_name>``

### آرتش

متوفر في AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### توزيعات أخرى

#### 1- تحميل ``yt-dlp``
إما

&nbsp; &nbsp; &nbsp; أ- من مستودع التوزيعة الخاصة بك

&nbsp; &nbsp; &nbsp; ب- أو تحميل [الملف الثنائي](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp)، ثم نقله إلى دليل bin الخاص بك، واجعله قابلًا للتنفيذ عبر تشغيل الأمر `chmod +x <bin_file>`

#### 2- تحميل ``ffmpeg`` أو ``ffmpeg-free`` من مستودعات التوزيعة الخاصة بك


#### 3- تحميل الملف الثنائي لـ ``ytdlp-gui`` من [صفحة الإصدارات](https://github.com/BKSalman/ytdlp-gui/releases)

## ويندوز
##### ببساطة قم بتحميل ملف zip من صفحة الإصدارات، فك ضغطه في مجلد فرعي وابدأ تشغيل ``ytdlp-gui.exe``

# البناء من المصدر
لبناء البرنامج من المصدر تحتاج إلى وجود `cargo` و `rustc`، يمكنك تثبيتهما عبر `rustup` (مدير أدوات Rust)، أو من مستودعات التوزيعة الخاصة بك، حسب ما تفضل

بعد ذلك شغّل الأوامر التالية:
```bash
# استنساخ المستودع إلى مجلد "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# الدخول إلى المجلد
cd ytdlp-gui
# يمكنك بناء المشروع باستخدام هذا الأمر
cargo build
# أو بناءه بوضع الإصدار لأداء أفضل
cargo build -r
```
ثم سيكون الملف الثنائي إما في `<project-root>/target/debug/ytdlp-gui` أو `<project-root>/target/release/ytdlp-gui`

ويمكنك تشغيله مباشرة:
```bash
# من جذر المشروع
./target/release/ytdlp-gui
```

أو باستخدام cargo:
```bash
cargo r
# أو لوضع الإصدار
cargo r -r
```

# الإعداد

لـ الإصدار v0.2.2+ يقوم التطبيق بحفظ الإعدادات في دليل الإعداد الافتراضي للنظام/المنصة في ``<config_dir>/ytdlp-gui/config.toml``

يبدو الملف الافتراضي كالتالي:

```toml
# اختياري
# هذا هو مسار الدليل الخاص بالملفات التنفيذية، وليس الملف التنفيذي نفسه
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) إذا لم يتم تعيينه، سيكون الأمر `yt-dlp <app_args>`

# اختياري
download_folder = "<some_cool_path>" # الافتراضي = "~/Videos"

[options]
video_resolution = "FullHD" # الخيارات: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # الخيارات: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # الخيارات: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  الخيارات: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### ملاحظة: خيارات الجودة/الصيغة تُحفظ تلقائيًا عند الضغط على زر التحميل

# المساهمة
جميع أشكال المساهمة مرحب بها، سواء كانت طلبات سحب، أو تقارير مشاكل/طلبات تحسين

مع ذلك، قد لا أكون سريعًا في الرد عليها أو تنفيذ المطلوب، لأنني أركز على أشياء أخرى

لكن سأبذل قصارى جهدي 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---