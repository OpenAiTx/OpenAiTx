# پراکندگی گوسی سه‌بعدی برای رندرینگ میدان تابش در زمان واقعی - پیاده‌سازی C++ و CUDA

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

یک پیاده‌سازی با کارایی بالا به زبان C++ و CUDA از پراکندگی گوسی سه‌بعدی، ساخته شده بر پایه بک‌اند رستری‌سازی [gsplat](https://github.com/nerfstudio-project/gsplat).

## اخبار
- **[2025-06-10]**: برخی مشکلات رفع شدند. در حال کاهش فاصله با معیارهای gsplat هستیم. با این حال، هنوز اختلاف کوچکی وجود دارد.
- **[2025-06-04]**: استراتژی MCMC با گزینه خط فرمان `--max-cap` برای کنترل حداکثر تعداد گوسی‌ها اضافه شد.
- **[2025-06-03]**: به بک‌اند Gsplat سوئیچ شد و مجوز به‌روزرسانی شد.
- **[2024-05-27]**: به LibTorch 2.7.0 برای سازگاری و عملکرد بهتر به‌روزرسانی شد. تغییرات شکسته‌کننده در مدیریت وضعیت بهینه‌ساز رفع شدند.
- **[2024-05-26]**: هدف فعلی این مخزن حرکت به سمت مجوز اجازه‌محور است. کارهای عمده‌ای برای جایگزینی رسترایزر با پیاده‌سازی gsplat انجام شده است.

## معیارها
در حال حاضر این پیاده‌سازی به نتایج هم‌سطح با gsplat-mcmc نمی‌رسد، اما پروژه در حال پیشرفت است.  
تنها مسئله زمان برای رفع باگ است. کمک‌ها خوش‌آمد هستند :)  
معیارهای استراتژی mcmc به شرح زیر است:

| صحنه    | تکرار    | PSNR          | SSIM         | LPIPS        | زمان هر تصویر | تعداد گوسی‌ها |
| -------- | --------- | ------------- | ------------ | ------------ | -------------- | ------------- |
| garden   | 30000     | 27.112114     | 0.854833     | 0.157624     | 0.304765       | 1000000       |
| bicycle  | 30000     | 25.047745     | 0.767729     | 0.254825     | 0.293618       | 1000000       |
| stump    | 30000     | 26.554749     | 0.784203     | 0.263013     | 0.296536       | 1000000       |
| bonsai   | 30000     | 32.534199     | 0.948675     | 0.246924     | 0.436188       | 1000000       |
| counter  | 30000     | 29.187017     | 0.915823     | 0.242159     | 0.441259       | 1000000       |
| kitchen  | 30000     | 31.680832     | 0.933897     | 0.154965     | 0.449078       | 1000000       |
| room     | 30000     | 32.211632     | 0.930754     | 0.273719     | 0.413519       | 1000000       |
| **میانگین** | **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**   | **1000000**   |

## جامعه و پشتیبانی

به جامعه رو به رشد ما بپیوندید برای بحث، پشتیبانی و به‌روزرسانی‌ها:  
- 💬 **[جامعه Discord](https://discord.gg/TbxJST2BbC)** - کمک بگیرید، نتایج را به اشتراک بگذارید، و در توسعه مشارکت کنید  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - به وبسایت ما برای منابع بیشتر سر بزنید  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - فهرست کامل مقالات و منابع  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - برای جدیدترین به‌روزرسانی‌ها دنبال کنید

## دستورالعمل‌های ساخت و اجرا

### پیش‌نیازهای نرم‌افزاری
1. **لینوکس** (تست شده با Ubuntu 22.04) - ویندوز فعلاً پشتیبانی نمی‌شود  
2. **CMake** نسخه 3.24 یا بالاتر  
3. **CUDA** نسخه 11.8 یا بالاتر (ممکن است با نسخه‌های پایین‌تر با پیکربندی دستی کار کند)  
4. **پایتون** با هدرهای توسعه  
5. **LibTorch 2.7.0** - دستورالعمل نصب در ادامه  
6. بقیه وابستگی‌ها به‌صورت خودکار توسط CMake مدیریت می‌شوند

### پیش‌نیازهای سخت‌افزاری
1. **کارت گرافیک NVIDIA** با پشتیبانی CUDA  
    - تست شده با موفقیت: RTX 4090، RTX A5000، RTX 3090Ti، A100  
    - مشکل شناخته شده با RTX 3080Ti در داده‌های بزرگ‌تر (ببینید #21)  
2. حداقل قابلیت محاسباتی: 8.0

> اگر روی سخت‌افزار دیگری با موفقیت اجرا کردید، لطفاً تجربه خود را در بخش Discussions به اشتراک بگذارید!

### دستورالعمل ساخت

```bash
# کلون کردن مخزن به همراه زیرمدول‌ها
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# دانلود و نصب LibTorch
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# ساخت پروژه
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

این پروژه از **LibTorch 2.7.0** برای بهترین عملکرد و سازگاری استفاده می‌کند:

- **عملکرد بهبود یافته**: بهینه‌سازی و مدیریت حافظه بهتر  
- **ثبات API**: جدیدترین API پایدار PyTorch C++  
- **سازگاری CUDA**: ادغام بهتر با CUDA 11.8+  
- **رفع اشکال**: مشکلات مدیریت وضعیت بهینه‌ساز برطرف شده‌اند

### ارتقاء از نسخه‌های قبلی
1. نسخه جدید LibTorch را طبق دستور ساخت دانلود کنید  
2. پوشه ساخت خود را پاک کنید: `rm -rf build/`  
3. پروژه را مجدداً بسازید

## مجموعه داده

مجموعه داده را از مخزن اصلی دانلود کنید:  
[مجموعه داده Tanks & Trains](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

آن را در پوشه `data` در ریشه پروژه استخراج کنید.

## گزینه‌های خط فرمان

### گزینه‌های اصلی

- **`-h, --help`**  
  نمایش منوی راهنما

- **`-d, --data-path [PATH]`**  
  مسیر داده‌های آموزش (الزامی)

- **`-o, --output-path [PATH]`**  
  مسیر ذخیره مدل آموزش‌دیده (پیش‌فرض: `./output`)

- **`-i, --iter [NUM]`**  
  تعداد تکرارهای آموزش (پیش‌فرض: 30000)  
    - مقاله 30 هزار تکرار را پیشنهاد می‌دهد، اما معمولاً 6 تا 7 هزار تکرار نتایج اولیه خوبی می‌دهد  
    - خروجی‌ها هر 7 هزار تکرار و در پایان ذخیره می‌شوند

- **`-f, --force`**  
  اجبار به بازنویسی پوشه خروجی موجود

- **`-r, --resolution [NUM]`**  
  تنظیم رزولوشن تصاویر آموزش

### گزینه‌های مخصوص MCMC

- **`--max-cap [NUM]`**  
  حداکثر تعداد گوسی‌ها برای استراتژی MCMC (پیش‌فرض: 1000000)  
    - کنترل حد بالای پراکندگی گوسی‌ها در طول آموزش  
    - مناسب برای محیط‌های دارای محدودیت حافظه

### نمونه استفاده

آموزش پایه:
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

آموزش MCMC با محدودیت تعداد گوسی:
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## راهنمای مشارکت

از مشارکت شما استقبال می‌کنیم! برای شروع:

1. **شروع به کار**:  
    - مسائل برچسب‌خورده به عنوان **good first issues** را برای وظایف مناسب مبتدیان بررسی کنید  
    - برای ایده‌های جدید، یک بحث باز کنید یا به [Discord](https://discord.gg/TbxJST2BbC) ما بپیوندید

2. **قبل از ارسال PR**:  
    - از `clang-format` برای یکنواختی سبک کد استفاده کنید  
    - از هوک پیش‌کامیت استفاده کنید: `cp tools/pre-commit .git/hooks/`  
    - وابستگی‌های جدید را ابتدا در یک issue مطرح کنید - هدف ما کمینه کردن وابستگی‌ها است

## قدردانی‌ها

این پیاده‌سازی بر پایه چند پروژه کلیدی ساخته شده است:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: ما از بک‌اند رستری‌سازی CUDA بسیار بهینه‌شده gsplat استفاده می‌کنیم که بهبودهای عملکردی قابل توجه و بهره‌وری حافظه بهتری ارائه می‌دهد.

- **پراکندگی گوسی سه‌بعدی اصلی**: بر اساس کار پیشگامانه Kerbl و همکاران.

## استناد

اگر از این نرم‌افزار در تحقیقات خود استفاده کردید، لطفاً کار اصلی را استناد دهید:

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## مجوز

جزئیات در فایل LICENSE موجود است.

---

**با ما در ارتباط باشید:**  
- 🌐 وبسایت: [mrnerf.com](https://mrnerf.com)  
- 📚 مقالات: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [به جامعه ما بپیوندید](https://discord.gg/TbxJST2BbC)  
- 🐦 توییتر: دنبال کنید [@janusch_patas](https://twitter.com/janusch_patas) برای به‌روزرسانی‌های توسعه

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---