# رابط کاربری وب استیبل دیفیوشن
یک رابط وب برای استیبل دیفیوشن، پیاده‌سازی شده با استفاده از کتابخانه Gradio.

![](screenshot.png)

## امکانات
[نمایش جزئیات ویژگی‌ها به همراه تصاویر](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- حالت‌های اصلی txt2img و img2img
- اسکریپت نصب و اجرای با یک کلیک (اما باید python و git را نصب کنید)
- Outpainting
- Inpainting
- Color Sketch
- Prompt Matrix
- بزرگ‌نمایی استیبل دیفیوشن
- توجه (Attention)، مشخص کردن بخش‌هایی از متن که مدل باید به آن‌ها بیشتر توجه کند
    - یک مرد در یک `((تاکسیدو))` - مدل به تاکسیدو بیشتر توجه می‌کند
    - یک مرد در یک `(tuxedo:1.21)` - سینتکس جایگزین
    - انتخاب متن و فشردن `Ctrl+Up` یا `Ctrl+Down` (یا `Command+Up` یا `Command+Down` در MacOS) برای تنظیم خودکار توجه به متن انتخاب شده (کد توسط کاربری ناشناس ارائه شده)
- Loopback، اجرای فرایند img2img چندین بار
- نمودار X/Y/Z، روشی برای رسم نمودار سه‌بعدی تصاویر با پارامترهای مختلف
- Textual Inversion
    - می‌توانید به هر تعداد embedding که بخواهید داشته باشید و هر نامی برای آن انتخاب کنید
    - استفاده از چند embedding با تعداد بردارهای مختلف برای هر توکن
    - سازگار با اعداد اعشاری با دقت نیمه (half precision)
    - آموزش embedding روی کارت ۸ گیگ (گزارش‌هایی از کار کردن روی ۶ گیگ هم وجود دارد)
- تب Extras با:
    - GFPGAN، شبکه عصبی برای اصلاح چهره‌ها
    - CodeFormer، ابزار بازسازی چهره به عنوان جایگزین GFPGAN
    - RealESRGAN، شبکه عصبی بزرگ‌کننده تصویر
    - ESRGAN، شبکه عصبی بزرگ‌کننده تصویر با مدل‌های ثالث متعدد
    - SwinIR و Swin2SR ([اینجا را ببینید](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092))، شبکه عصبی بزرگ‌کننده تصویر
    - LDSR، بزرگ‌نمایی با وضوح فوق‌العاده بر پایه لاتنت دیفیوشن
- گزینه‌های تغییر نسبت ابعاد تصاویر
- انتخاب روش نمونه‌گیری (Sampling)
    - تنظیم مقدار eta نمونه‌گیر (ضریب نویز)
    - گزینه‌های پیشرفته‌تر تنظیم نویز
- امکان توقف فرایند در هر زمان
- پشتیبانی از کارت گرافیک ۴ گیگ (گزارش‌هایی از کارکرد بر روی ۲ گیگ نیز وجود دارد)
- دانه (seed) صحیح برای دسته‌ها
- اعتبارسنجی زنده طول توکن‌های prompt
- پارامترهای تولید
     - پارامترهای استفاده‌شده برای تولید تصاویر با خود تصویر ذخیره می‌شوند
     - در chunkهای PNG برای PNG و در EXIF برای JPEG
     - می‌توانید تصویر را به تب PNG info بکشید تا پارامترهای تولید بازگردانی و به طور خودکار در رابط قرار گیرند
     - قابل غیرفعال‌سازی در تنظیمات
     - امکان کشیدن و رها کردن تصویر یا متن-پارامترها به کادر prompt
- دکمه خواندن پارامترهای تولید، پارامترها را از کادر prompt به رابط بارگذاری می‌کند
- صفحه تنظیمات
- اجرای کد پایتون دلخواه از رابط (باید با `--allow-code` اجرا شود)
- راهنمایی با حرکت ماوس بر روی بیشتر عناصر رابط
- امکان تغییر مقادیر پیش‌فرض/حداقل/حداکثر/گام عناصر رابط از طریق فایل متنی پیکربندی
- پشتیبانی از تایلینگ، یک چک‌باکس برای ایجاد تصاویری که قابلیت تکرار دارند (مانند تکسچر)
- نوار پیشرفت و پیش‌نمایش زنده تولید تصویر
    - می‌توان از شبکه عصبی جداگانه برای پیش‌نمایش با حداقل مصرف VRAM و منابع محاسباتی استفاده کرد
- Prompt منفی، یک فیلد متنی اضافی که می‌توانید مواردی که نمی‌خواهید در تصویر تولید شده باشند را وارد کنید
- استایل‌ها، روشی برای ذخیره بخشی از prompt و استفاده آسان از آن‌ها بعداً از طریق منوی کشویی
- واریاسیون‌ها، روشی برای تولید تصویر مشابه با تفاوت‌های جزئی
- Seed resizing، روشی برای تولید تصویر یکسان در وضوح کمی متفاوت
- CLIP interrogator، دکمه‌ای برای حدس زدن prompt از روی یک تصویر
- ویرایش prompt، روشی برای تغییر prompt در میانه تولید؛ مثلاً شروع با یک هندوانه و تغییر به دختر انیمه‌ای در اواسط تولید
- پردازش دسته‌ای، پردازش یک گروه فایل با img2img
- جایگزین img2img، روش Euler معکوس برای کنترل cross-attention
- Highres Fix، گزینه‌ای برای تولید تصاویر با وضوح بالا فقط با یک کلیک و بدون اعوجاج معمول
- بارگذاری مجدد چک‌پوینت‌ها در حین اجرا
- ادغام چک‌پوینت، تبی برای ادغام حداکثر ۳ چک‌پوینت در یک چک‌پوینت واحد
- [اسکریپت‌های سفارشی](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) با افزونه‌های متعدد از جامعه کاربری
- [کامپوزیبل دیفیوشن](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/)، روشی برای استفاده همزمان از چندین prompt
     - جدا کردن promptها با `AND` بزرگ
     - پشتیبانی از وزن‌دهی promptها: `a cat :1.2 AND a dog AND a penguin :2.2`
- بدون محدودیت تعداد توکن برای prompt (در نسخه اصلی تا ۷۵ توکن مجاز است)
- یکپارچه‌سازی DeepDanbooru، تولید برچسب‌های سبک danbooru برای promptهای انیمه‌ای
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers)، افزایش سرعت عمده برای برخی کارت‌ها (افزودن `--xformers` به آرگومان خط فرمان)
- از طریق افزونه: [تب تاریخچه](https://github.com/yfszzx/stable-diffusion-webui-images-browser): مشاهده، مدیریت و حذف راحت تصاویر در رابط
- گزینه تولید بی‌پایان
- تب آموزش
     - گزینه‌های هایپرنتورک و embedding
     - پیش‌پردازش تصاویر: کراپ کردن، آینه‌ای کردن، برچسب‌گذاری خودکار با BLIP یا deepdanbooru (برای انیمه)
- Clip skip
- هایپرنتورک‌ها
- لوراها (شبیه هایپرنتورک‌ها اما زیباتر)
- رابط کاربری جداگانه برای انتخاب و پیش‌نمایش embeddingها، هایپرنتورک‌ها یا لوراها برای افزودن به prompt
- امکان انتخاب VAE متفاوت از صفحه تنظیمات
- نمایش زمان تخمینی اتمام در نوار پیشرفت
- API
- پشتیبانی از [مدل inpainting اختصاصی](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) توسط RunwayML
- از طریق افزونه: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients)، روشی برای تولید تصاویر با زیبایی‌شناسی خاص با استفاده از embedهای تصویری clip ([پیاده‌سازی](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- پشتیبانی از [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - برای راهنما [ویکی](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) را ببینید
- پشتیبانی از [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - برای راهنما [ویکی](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) را ببینید
- بدون حروف نامناسب!
- بارگذاری چک‌پوینت‌ها با فرمت safetensors
- محدودیت وضوح آسان‌تر: ابعاد تصویر تولیدی باید مضرب ۸ باشد (نه ۶۴)
- حالا با مجوز (license)!
- تغییر ترتیب عناصر رابط از صفحه تنظیمات
- پشتیبانی از [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## نصب و اجرا
اطمینان حاصل کنید که [پیش‌نیازها](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) فراهم شده و دستورالعمل‌های زیر را دنبال کنید:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (توصیه‌شده)
- کارت‌های گرافیک [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs)
- [پردازنده‌های Intel، کارت‌های گرافیک Intel (یکپارچه و مجزا)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (صفحه ویکی خارجی)
- [Ascend NPUs](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (صفحه ویکی خارجی)

همچنین می‌توانید از سرویس‌های آنلاین (مانند Google Colab) استفاده کنید:

- [فهرست سرویس‌های آنلاین](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### نصب در ویندوز ۱۰/۱۱ با کارت‌های NVidia از طریق بسته انتشار
1. فایل `sd.webui.zip` را از [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) دانلود و محتویات آن را استخراج کنید.
2. `update.bat` را اجرا کنید.
3. `run.bat` را اجرا کنید.
> برای جزئیات بیشتر [راهنمای نصب و اجرا روی کارت‌های NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) را ببینید

### نصب خودکار در ویندوز
1. [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) را نصب کنید (نسخه‌های جدیدتر پایتون torch را پشتیبانی نمی‌کنند)، گزینه "Add Python to PATH" را فعال کنید.
2. [git](https://git-scm.com/download/win) را نصب کنید.
3. مخزن stable-diffusion-webui را دانلود کنید؛ برای نمونه با اجرای دستور `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`
4. فایل `webui-user.bat` را از Windows Explorer به صورت کاربر عادی (نه ادمین) اجرا کنید.

### نصب خودکار در لینوکس
1. پیش‌نیازها را نصب کنید:
```bash
# مبتنی بر Debian:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# مبتنی بر Red Hat:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# مبتنی بر openSUSE:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# مبتنی بر Arch:
sudo pacman -S wget git python3
```
اگر سیستم شما جدید است، باید python3.11 یا python3.10 را نصب کنید:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # با پکیج python3.11 اشتباه نشود

# فقط برای 3.11
# سپس متغیر env را در اسکریپت launch تنظیم کنید
export python_cmd="python3.11"
# یا در webui-user.sh
python_cmd="python3.11"
```
2. به دایرکتوری‌ای بروید که مایل به نصب وب‌یوآی هستید و فرمان زیر را اجرا کنید:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
یا به سادگی مخزن را در هر جا که می‌خواهید کلون کنید:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. `webui.sh` را اجرا کنید.
4. فایل `webui-user.sh` را برای گزینه‌ها بررسی کنید.

### نصب روی Apple Silicon

دستورالعمل‌ها را [اینجا](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon) بیابید.

## مشارکت
برای افزودن کد به این مخزن: [مشارکت](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## مستندات

مستندات از این README به [ویکی پروژه](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki) منتقل شده است.

برای ایندکس شدن توسط گوگل و سایر موتورهای جستجو، این لینک (برای انسان‌ها نیست) به [ویکی قابل خزش](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki) ارائه شده است.

## اعتبارها
مجوزهای کدهای استفاده‌شده در صفحه `Settings -> Licenses` و همچنین فایل `html/licenses.html` موجود است.

- استیبل دیفیوشن - https://github.com/Stability-AI/stablediffusion، https://github.com/CompVis/taming-transformers، https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel پیاده‌سازی:
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- ایده‌هایی برای بهینه‌سازی - https://github.com/basujindal/stable-diffusion
- بهینه‌سازی لایه Cross Attention - Doggettx - https://github.com/Doggettx/stable-diffusion، ایده اصلی برای ویرایش prompt.
- بهینه‌سازی لایه Cross Attention - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (در اصل http://github.com/lstein/stable-diffusion)
- بهینه‌سازی زیر-درجه‌ای لایه Cross Attention - Alex Birch (https://github.com/Birch-san/diffusers/pull/1)، امین رضایی (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - رینون گال - https://github.com/rinongal/textual_inversion (از کد او استفاده نشده اما ایده‌ها گرفته شده است)
- ایده برای بزرگ‌نمایی SD - https://github.com/jquesnelle/txt2imghd
- تولید نویز برای outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- ایده و بخشی از کد CLIP interrogator - https://github.com/pharmapsychotic/clip-interrogator
- ایده برای Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - interrogator برای مدل‌های انیمه https://github.com/KichangKim/DeepDanbooru
- نمونه‌گیری با دقت float32 از UNet با float16 - marunine برای ایده، Birch-san برای پیاده‌سازی در Diffusers (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (ستاره)، Aleksander Holynski (ستاره)، Alexei A. Efros (بدون ستاره) - https://github.com/timothybrooks/instruct-pix2pix
- مشاوره امنیتی - RyotaK
- UniPC sampler - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Restart sampling - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- اسکریپت اولیه Gradio - پست شده در 4chan توسط یک کاربر ناشناس. سپاس از کاربر ناشناس.
- (شما)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---