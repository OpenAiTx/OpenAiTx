# ytdlp-gui
یک رابط گرافیکی برای yt-dlp نوشته شده با زبان Rust

- [نصب](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [توزیع‌های دیگر](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [ویندوز](https://github.com/BKSalman/ytdlp-gui#windows)
- [ساخت از سورس](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [پیکربندی](https://github.com/BKSalman/ytdlp-gui#configuration)
- [مشارکت](https://github.com/BKSalman/ytdlp-gui#contribution)

# پیش‌نمایش
![image](https://github.com/user-attachments/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# نصب
## لینوکس

### NixOS (Flake)
می‌توانید از flake.nix موجود در مخزن استفاده کنید

در فایل `flake.nix` خود:
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

سپس می‌توانید آن را به عنوان یک بسته عادی اضافه کنید، چه به home-manager خود یا nixosConfiguration

### فدورا
بسته rpm را از صفحه ریلیزها دانلود کرده و سپس با دستور ``sudo dnf localinstall <rpm_package_name>`` نصب کنید

### اوبونتو
بسته deb را از صفحه ریلیزها دانلود کرده و سپس با دستور ``sudo apt install ./<deb_package_name>`` نصب کنید

### آرچ

در AUR موجود است [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### توزیع‌های دیگر

#### ۱- دانلود ``yt-dlp``
یا

&nbsp; &nbsp; &nbsp; الف- از مخزن توزیع خود

&nbsp; &nbsp; &nbsp; ب- یا باینری [این‌جا](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp) را دانلود کنید، سپس آن را به دایرکتوری bin خود منتقل کرده و با اجرای `chmod +x <bin_file>` قابل اجرا کنید

#### ۲- دانلود ``ffmpeg`` یا ``ffmpeg-free`` از مخازن توزیع خود


#### ۳- دانلود باینری ``ytdlp-gui`` از [صفحه ریلیزها](https://github.com/BKSalman/ytdlp-gui/releases)

## ویندوز
##### فقط فایل zip را از صفحه ریلیزها دانلود کنید، در یک پوشه فرعی استخراج کنید و فایل ``ytdlp-gui.exe`` را اجرا کنید

# ساخت از سورس
برای ساخت از سورس نیاز به `cargo` و `rustc` دارید، می‌توانید آن‌ها را از طریق `rustup` (مدیر ابزارهای Rust) یا از مخازن توزیع خود نصب کنید، هر کدام را که ترجیح می‌دهید

سپس دستورات زیر را اجرا کنید:
```bash
# کلون کردن مخزن در پوشه "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# وارد پوشه شوید
cd ytdlp-gui
# می‌توانید پروژه را با این دستور بسازید
cargo build
# یا در حالت release برای عملکرد بهتر بسازید
cargo build -r
```
سپس باینری در یکی از مسیرهای `<project-root>/target/debug/ytdlp-gui` یا `<project-root>/target/release/ytdlp-gui` قرار خواهد داشت

و می‌توانید آن را به طور مستقیم اجرا کنید:
```bash
# از ریشه پروژه
./target/release/ytdlp-gui
```

یا با استفاده از cargo:
```bash
cargo r
# یا برای حالت release
cargo r -r
```

# پیکربندی

برای نسخه v0.2.2+ برنامه تنظیمات را در دایرکتوری پیش‌فرض پیکربندی برای پلتفرم/سیستم عامل مربوطه در ``<config_dir>/ytdlp-gui/config.toml`` ذخیره می‌کند

فایل پیش‌فرض به این شکل است:

```toml
# اختیاری
# این مسیر دایرکتوری bin است، نه خود فایل bin
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) اگر تنظیم نشود فرمان به صورت `yt-dlp <app_args>` اجرا می‌شود

# اختیاری
download_folder = "<some_cool_path>" # پیش‌فرض = "~/Videos"

[options]
video_resolution = "FullHD" # گزینه‌ها: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # گزینه‌ها: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # گزینه‌ها: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" # گزینه‌ها: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### توجه: گزینه‌های کیفیت/فرمت هنگام فشردن دکمه دانلود به صورت خودکار ذخیره می‌شوند

# مشارکت
تمام اشکال مشارکت پذیرفته می‌شود، چه درخواست Pull، چه Issues (گزارش باگ/درخواست ویژگی)

با این حال، ممکن است پاسخگویی سریع نداشته باشم یا درخواست‌ها را سریع پیاده‌سازی نکنم، چون روی مسائل دیگر تمرکز دارم

اما تمام تلاش خود را خواهم کرد 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---