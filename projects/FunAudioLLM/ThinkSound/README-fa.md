<h1 align="center">تینک‌ساند</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">انگلیسی</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">اسپانیایی</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">فرانسوی</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">ژاپنی</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
<p align="center">
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="دموی آنلاین"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-تجربه آنلاین-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  اگر این پروژه برای شما مفید بود،<br>
  یک ستاره ⭐ در گیت‌هاب بسیار ارزشمند خواهد بود!
</p>

---

**تینک‌ساند** یک چارچوب یکپارچه برای تولید Any2Audio است که با تطبیق جریان و راهنمایی استدلال زنجیره‌ای (CoT) هدایت می‌شود.
پیاده‌سازی PyTorch برای تولید و ویرایش صوت چندرسانه‌ای: تولید یا ویرایش صوت از ویدئو، متن و صوت، با پشتیبانی از استدلال گام‌به‌گام مبتنی بر مدل‌های زبانی بزرگ چندرسانه‌ای (MLLMs).

![نمونه](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 اخبار
- **۲۰۲۵.۰۹.۱۹** &nbsp; 🎉 ThinkSound به **کنفرانس اصلی NeurIPS 2025** پذیرفته شد!
- **۲۰۲۵.۰۹.۰۱** &nbsp; 🔥 مجموعه داده AudioCoT اکنون متن‌باز بوده و در [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT) در دسترس است!
- **۲۰۲۵.۰۷.۱۷** &nbsp; 🧠 امکان تنظیم دقیق: کد آموزش و تنظیم دقیق اکنون به صورت عمومی منتشر شده و دستورالعمل‌های واضح برای سفارشی‌سازی و توسعه ThinkSound با داده‌های خودتان ارائه شده است.
- **۲۰۲۵.۰۷.۱۵** &nbsp; 📦 نصب و کاربری ساده: وابستگی‌ها در PyPI برای راه‌اندازی آسان در همه سیستم‌عامل‌ها؛ اسکریپت‌های `.bat` ویندوز ایجاد محیط و اجرای اسکریپت‌ها را خودکار می‌کنند.
- **۲۰۲۵.۰۷.۰۸** &nbsp;  🔧 به‌روزرسانی عمده: مدل سبک‌تر شده و مصرف حافظه و GPU بهینه شده است، اکنون از تولید صوت با توان بالا در مقیاس پشتیبانی می‌کند!
- **۲۰۲۵.۰۷.۰۱** &nbsp; 🔥دموی آنلاین در [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) و [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) برای تجربه تعاملی!
- **۲۰۲۵.۰۷.۰۱** &nbsp; 🔥اسکریپت‌های استنتاج و رابط وب منتشر شد؛ 
- **۲۰۲۵.۰۶** &nbsp; 🔥[مقاله ThinkSound](https://arxiv.org/pdf/2506.21448) در arXiv منتشر شد!
- **۲۰۲۵.۰۶** &nbsp; 🔥[دموی آنلاین](http://thinksound-project.github.io/) فعال است - همین حالا امتحان کنید!

---


## 🚀 قابلیت‌ها

- **Any2Audio**: تولید صوت از هر نوع داده — ویدئو، متن، صوت یا ترکیب آن‌ها.
- **ویدئو به صوت SOTA**: دستیابی به بهترین نتایج در چندین معیار V2A.
- **استدلال مبتنی بر CoT**: استدلال زنجیره‌ای برای تولید صوت ترکیبی و قابل کنترل با MLLMs.
- **ویرایش تعاملی مبتنی بر شیء**: اصلاح یا ویرایش رویدادهای صوتی خاص با کلیک روی اشیاء تصویری یا دستور متنی.
- **چارچوب یکپارچه**: یک مدل بنیادی واحد برای تولید، ویرایش و جریان کاری تعاملی.

---

## ✨ مرور روش

ThinkSound تولید و ویرایش صوت را به سه مرحله تعاملی تقسیم می‌کند که همگی با استدلال زنجیره‌ای مبتنی بر MLLM هدایت می‌شوند:

1. **تولید Foley:** تولید صداهای پایه، هم‌تراز معنایی و زمانی با ویدئو.
2. **اصلاح مبتنی بر شیء:** اصلاح یا افزودن صدا برای اشیاء مشخص‌شده توسط کاربر از طریق کلیک یا ناحیه‌های ویدئو.
3. **ویرایش هدفمند صوت:** تغییر صوت تولیدشده با دستورالعمل‌های طبیعی سطح بالا.

![نمای کلی ThinkSound](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- مجموعه داده بزرگ‌مقیاس با برچسب CoT (**AudioCoT**) برای آموزش ماژول استدلال و مدل پایه صوتی یکپارچه استفاده می‌شود.

![خط لوله AudioCoT](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ شروع سریع

**آماده‌سازی محیط:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **نکته ویندوز:**  
> کاربران ویندوز می‌توانند به سادگی فایل `setup_windows.bat` را اجرا کنند (یا روی آن دوبار کلیک کنند) تا محیط کاندا به‌طور خودکار ساخته شود، تمامی وابستگی‌ها (از جمله FFmpeg) نصب شوند و مدل از پیش آموزش‌دیده دانلود گردد — هیچ تنظیمات دستی لازم نیست.  
> قبل از اجرای اسکریپت، مطمئن شوید که `conda` و `git` نصب شده و در PATH سیستم شما قرار دارند.


### ▶️ اجرای دمو

#### **لینوکس/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **ویندوز**

در عوض می‌توانید از اسکریپت `.bat` ارائه‌شده استفاده کنید:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**توجه:**

* `<path-to-your-demo-video>`: مسیر یک ویدئوی تکی
* `[use-half]` (اختیاری): افزودن use-half در انتها برای فعال‌سازی استخراج ویژگی با دقت نیمه.

---

### 📦 استنتاج دسته‌ای

#### **لینوکس/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **ویندوز**

از اسکریپت معادل `.bat` استفاده کنید:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**توجه:**

* `<video_path>`: مسیر دایرکتوری اصلی که حاوی تمام ویدیوهای .mp4 برای پردازش است (همه ویدیوها باید مدت زمان یکسان داشته باشند).
* `<csv_path>`: یک فایل CSV با متون راهنما برای هر ویدیو (فرمت را در `demo_test.csv` ببینید).
* `<save_path>` (اختیاری): مسیر ذخیره‌سازی فایل‌های صوتی تولید شده. به طور پیش‌فرض `results/features` است.
* `[use-half]` (اختیاری): افزودن use-half در انتها برای فعال‌سازی استخراج ویژگی با دقت نیمه.

---


### استفاده از رابط وب

برای تجربه تعاملی، رابط وب Gradio را اجرا کنید:


```bash
python app.py
```


## 🏋️ آموزش مدل

به [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md) مراجعه کنید.


---

## 📝 برنامه‌های آینده و کارهای باقی‌مانده
* - [ ] انتشار یک مدل پایه قدرتمندتر که چندین حوزه را پوشش دهد و خلق فولی جذاب‌تر و فراگیرتری ارائه کند
* - [ ] افزودن پشتیبانی از حالت‌های بیشتر و وظایف پایین‌دستی
* - [ ] انتشار مدل‌ها در مقیاس‌های مختلف
* - [x] متن‌باز کردن مجموعه داده AudioCoT و خط لوله خودکار
* - [x] انتشار اسکریپت‌های آموزش برای مدل‌های ThinkSound
* - [x] README شروع سریع برای ویندوز مناسب مبتدیان
---


## 📄 مجوز

این پروژه تحت مجوز Apache 2.0 منتشر شده است.

> **توجه:**
> کد، مدل‌ها و مجموعه داده **فقط برای اهداف پژوهشی و آموزشی** هستند.
> **استفاده تجاری مجاز نیست.**
> برای اخذ مجوز تجاری، لطفاً با نویسندگان تماس بگیرید.

**📦 اجزای شخص ثالث**

* **Stable Audio Open VAE** (توسط Stability AI):
  این مخزن شامل یک VAE تنظیم‌شده از [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) است که تحت [مجوز Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) ارائه شده است.
  **استفاده و توزیع تجاری نیازمند اخذ مجوز قبلی از Stability AI است.**

* 📘 **سایر کدها و مدل‌ها** تحت مجوز Apache License 2.0 منتشر شده‌اند.

---

## تقدیر و تشکر

با تشکر فراوان از:

* **stable-audio-tools** (توسط Stability AI):
برای ارائه یک چارچوب آسان برای تولید صوت، همچنین ماژول VAE و وزن‌ها.
* **MMAudio**:
  برای پیاده‌سازی ستون فقرات MM-DiT در حوزه صوت.

---

## 📖 ارجاع

اگر ThinkSound در تحقیقات یا کار شما مفید بود، لطفاً مقاله ما را ارجاع دهید:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-04

---