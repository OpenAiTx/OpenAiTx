<h1 align="center">تینک‌ساوند (ThinkSound)</h1>

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
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  اگر این پروژه برایتان مفید بود،<br>
  یک ستاره ⭐ در گیت‌هاب بسیار قدردانی خواهد شد!
</p>

---

**تینک‌ساوند (ThinkSound)** یک چارچوب واحد برای تولید Any2Audio با هدایت تطبیق جریان مبتنی بر استدلال زنجیره‌ای (Chain-of-Thought - CoT) است.

پیاده‌سازی PyTorch برای تولید و ویرایش صوت چندوجهی: تولید یا ویرایش صوت از ویدیو، متن و صوت، با پشتیبانی از استدلال مرحله به مرحله توسط مدل‌های زبان بزرگ چندوجهی (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 اخبار
- **2025.07.17** &nbsp; 🧠 امکان فاین‌تیونینگ فعال شد: کد آموزش و فاین‌تیونینگ اکنون به صورت عمومی منتشر شده و دستورالعمل‌های واضح برای شخصی‌سازی و گسترش تینک‌ساوند با داده‌های خودتان ارائه شده است.
- **2025.07.15** &nbsp; 📦 نصب و استفاده ساده‌تر: وابستگی‌ها روی PyPI برای راه‌اندازی آسان بین پلتفرمی؛ اسکریپت‌های `.bat` ویندوز ایجاد محیط و اجرای اسکریپت را خودکار می‌کنند.
- **2025.07.08** &nbsp;  🔧 به‌روزرسانی عمده: مدل سبک‌سازی شده و مصرف حافظه و GPU بهینه شده، اکنون پشتیبانی از تولید صوت با توان بالا در مقیاس وسیع!
- **2025.07.01** &nbsp; 🔥دموی آنلاین در [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) و [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) برای تجربه تعاملی!
- **2025.07.01** &nbsp; 🔥اسکریپت‌های استنتاج و رابط وب منتشر شد؛ 
- **2025.06** &nbsp; 🔥[مقاله ThinkSound](https://arxiv.org/pdf/2506.21448) در arXiv منتشر شد!
- **2025.06** &nbsp; 🔥[دموی آنلاین](http://thinksound-project.github.io/) راه‌اندازی شد - همین حالا امتحان کنید!

---


## 🚀 ویژگی‌ها

- **Any2Audio**: تولید صوت از هر مدالیته دلخواه — ویدیو، متن، صوت یا ترکیب آن‌ها.
- **ویدیو به صوت SOTA**: دستیابی به نتایج پیشرفته در چندین بنچمارک V2A.
- **استدلال مبتنی بر CoT**: استدلال زنجیره‌ای برای تولید صوت ترکیبی و قابل کنترل از طریق MLLMها.
- **ویرایش تعاملی مبتنی بر شیء**: اصلاح یا ویرایش رویدادهای صوتی خاص با کلیک روی اشیای تصویری یا استفاده از دستورالعمل‌های متنی.
- **چارچوب یکپارچه**: یک مدل پایه برای تولید، ویرایش و جریان کاری تعاملی.

---

## ✨ مرور روش

تینک‌ساوند تولید و ویرایش صوت را به سه مرحله تعاملی تقسیم می‌کند که همگی با استدلال زنجیره‌ای مبتنی بر MLLM هدایت می‌شوند:

1. **تولید فولی:** تولید صداهای پایه‌ای، هم‌معنا و هم‌زمان با ویدیو.
2. **اصلاح مبتنی بر شیء:** اصلاح یا افزودن صدا برای اشیای تعیین‌شده توسط کاربر از طریق کلیک یا انتخاب ناحیه در ویدیو.
3. **ویرایش هدفمند صوت:** اصلاح صوت تولیدشده با استفاده از دستورالعمل‌های زبان طبیعی سطح بالا.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- یک دیتاست بزرگ با حاشیه‌نویسی CoT (**AudioCoT**) برای آموزش ماژول استدلال و مدل پایه صوتی یکپارچه استفاده شده است.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

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

به [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md) مراجعه کنید


---

## 📝 کارهای باقی‌مانده و برنامه‌های آینده
* - [ ] متن باز کردن دیتاست AudioCoT و خط لوله خودکار (انتظار می‌رود قبل از ۲۳/۰۷/۲۰۲۵)
* - [ ] انتشار یک مدل پایه قدرتمندتر که حوزه‌های بیشتری را پوشش دهد تا خلق فولی جذاب‌تر و فراگیرتری ارائه دهد (انتظار می‌رود تا پایان آگوست ۲۰۲۵)
* - [ ] افزودن پشتیبانی از حالت‌های اضافی و وظایف پایین‌دستی (انتظار می‌رود قبل از پایان جولای ۲۰۲۵)
* - [ ] انتشار مدل‌ها در مقیاس‌های مختلف (انتظار می‌رود قبل از پایان جولای ۲۰۲۵)
* - [x] انتشار اسکریپت‌های آموزش برای مدل‌های ThinkSound
* - [x] README شروع سریع برای ویندوز مناسب مبتدیان
---


## 📄 مجوز

این پروژه تحت مجوز Apache 2.0 منتشر شده است.

> **توجه:**
> کد، مدل‌ها و دیتاست **تنها برای اهداف پژوهشی و آموزشی** هستند.
> **استفاده تجاری مجاز نیست.**
> برای دریافت مجوز تجاری، لطفاً با نویسندگان تماس بگیرید.

**📦 اجزای شخص ثالث**

* **Stable Audio Open VAE** (توسط Stability AI):
  این مخزن شامل یک VAE ریزتنظیم‌شده از [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) است که تحت [مجوز Stability AI Community](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) قرار دارد.
  **استفاده تجاری و بازتوزیع نیازمند کسب اجازه قبلی از Stability AI است.**

* 📘 **سایر کدها و مدل‌ها** تحت مجوز Apache License 2.0 منتشر شده‌اند.

---

## تقدیر و تشکر

تشکر فراوان از:

* **stable-audio-tools** (توسط Stability AI):
برای فراهم کردن چارچوبی آسان برای تولید صوت، همچنین ماژول VAE و وزن‌ها.
* **MMAudio**:
  برای پیاده‌سازی backbone مدل MM-DiT در حوزه صوت.

---

## 📖 استناد

اگر ThinkSound برای پژوهش یا کار شما مفید بود، لطفاً به مقاله ما استناد کنید:



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

## 📬 تماس

✨ در صورت داشتن هرگونه سؤال یا پیشنهاد، لطفاً [یک ایشو باز کنید](https://github.com/liuhuadai/ThinkSound/issues) یا از طریق ایمیل ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) با ما تماس بگیرید!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---