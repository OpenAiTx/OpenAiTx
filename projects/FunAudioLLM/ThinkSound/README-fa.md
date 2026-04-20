<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
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
  اگر این پروژه برای شما مفید بود،<br>
  یک ستاره ⭐ در گیت‌هاب بسیار ارزشمند خواهد بود!
</p>

---

## ساختار مخزن
این مخزن **ThinkSound** در GitHub میزبان دو پروژه مرتبط در شاخه‌های جداگانه است:

| شاخه | پروژه | مستندسازی |
|--------|---------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — تولید یکپارچه Any2Audio با تطبیق جریان مبتنی بر CoT | این فایل: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — کار ادامه‌دار (ICLR 2026) در تبدیل ویدیو به صدا با CoT-RL چندبعدی | **`README.md`** در شاخه [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) |

برای **ThinkSound**، از شاخه **`master`** (همین README) استفاده کنید. برای **PrismAudio**، شاخه **`prismaudio`** را بررسی و **`README.md`** آن را دنبال کنید.

---

**ThinkSound** یک چارچوب یکپارچه برای تولید Any2Audio با تطبیق جریان هدایت‌شده توسط استدلال زنجیره‌ای (CoT) است.

پیاده‌سازی PyTorch برای تولید و ویرایش صوت چندمدلی: تولید یا ویرایش صوت از ویدیو، متن و صوت، با بهره‌گیری از استدلال مرحله‌به‌مرحله مدل‌های زبانی بزرگ چندمدلی (MLLMs).

![پیشنمایش](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 اخبار
- **2026.03.24** &nbsp; 🔥 **PrismAudio** در همین مخزن و شاخه [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) منتشر شد — برای راه‌اندازی و مدل‌ها به **`README.md`** آن مراجعه کنید.
- **2026.01.26** &nbsp; 🎉 PrismAudio به **کنفرانس اصلی ICLR 2026** پذیرفته شد (کد/مستندات در `prismaudio`).
- **2025.11.25** &nbsp; 🔥 [دموی آنلاین PrismAudio](http://prismaudio-project.github.io/) فعال است.
- **2025.11.25** &nbsp; 🔥 [مقاله PrismAudio](https://arxiv.org/pdf/2511.18833) در arXiv — CoT-RL چندبعدی برای تبدیل ویدیو به صوت.
- **2025.09.19** &nbsp; 🎉 **ThinkSound** به **کنفرانس اصلی NeurIPS 2025** پذیرفته شد!
- **2025.09.01** &nbsp; دیتاست AudioCoT ما اکنون به‌صورت متن‌باز روی [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT) در دسترس است!
- **2025.07.17** &nbsp; 🧠 قابلیت آموزش و ریزتنظیم: کد آموزش و ریزتنظیم به همراه دستورالعمل‌های واضح برای شخصی‌سازی و گسترش ThinkSound با داده‌های خودتان منتشر شد.
- **2025.07.15** &nbsp; 📦 نصب و استفاده ساده‌تر: وابستگی‌ها در PyPI برای راه‌اندازی آسان بین‌سیستمی؛ اسکریپت‌های `.bat` ویندوز ایجاد محیط و اجرای اسکریپت‌ها را خودکار می‌کنند.
- **2025.07.08** &nbsp;  🔧 بروزرسانی عمده: مدل سبک‌تر شده و استفاده از حافظه و GPU بهینه شده، اکنون از تولید صوت با توان بالا در مقیاس پشتیبانی می‌کند!
- **2025.07.01** &nbsp; دموی آنلاین در [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) و [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) برای تجربه تعاملی!
- **2025.07.01** &nbsp; اسکریپت‌های استنتاج و رابط وب منتشر شد؛ 
- **2025.06** &nbsp; [مقاله ThinkSound](https://arxiv.org/pdf/2506.21448) در arXiv منتشر شد!
- **2025.06** &nbsp; [دموی آنلاین](http://thinksound-project.github.io/) فعال است - هم‌اکنون امتحان کنید!

---


<div align="center">

### کار ادامه‌دار: PrismAudio (همین مخزن، شاخه `prismaudio`)

**PrismAudio** جانشین ThinkSound (ICLR 2026) است که تحت نامی جدید توسعه یافته اما در این مخزن در شاخه **`prismaudio`** نگهداری می‌شود. راهنمای نصب، نقاط بازیابی و نحوه استناد در **[`README.md` روی آن شاخه](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)** موجود است.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) یا شاخه را در گیت‌هاب باز کنید.

</div>

---


## 🚀 قابلیت‌ها

- **Any2Audio**: تولید صوت از هر نوع ورودی — ویدئو، متن، صدا یا ترکیبی از آن‌ها.
- **ویدئو به صوت SOTA**: دستیابی به نتایج پیشرفته در چندین بنچمارک V2A.
- **استدلال مبتنی بر CoT**: تولید صوت ترکیبی و قابل کنترل با استفاده از استدلال زنجیره‌ای توسط MLLMها.
- **ویرایش تعاملی مبتنی بر شیء**: اصلاح یا ویرایش رویدادهای صوتی خاص با کلیک روی اشیاء تصویری یا استفاده از دستورهای متنی.
- **چارچوب یکپارچه**: یک مدل پایه که از تولید، ویرایش و روند تعاملی پشتیبانی می‌کند.

---

## ✨ نمای کلی روش

ThinkSound فرایند تولید و ویرایش صوت را به سه مرحله تعاملی تقسیم می‌کند که همگی توسط استدلال زنجیره‌ای مبتنی بر MLLM (CoT) هدایت می‌شوند:

1. **تولید Foley:** تولید صداهای پایه‌ای با هم‌ترازی معنایی و زمانی از ویدئو.
2. **اصلاح مبتنی بر شیء:** اصلاح یا افزودن صدا برای اشیاء انتخابی کاربر از طریق کلیک یا تعیین ناحیه در ویدئو.
3. **ویرایش هدفمند صوت:** ویرایش صوت تولید شده با استفاده از دستورهای زبان طبیعی سطح بالا.

![نمای کلی ThinkSound](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- یک مجموعه داده بزرگ با حاشیه‌نویسی CoT (**AudioCoT**) برای آموزش ماژول استدلال و مدل پایه صوتی یکپارچه استفاده شده است.
![روند AudioCoT](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ شروع سریع

**آماده‌سازی محیط:**

```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
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


## 📄 مجوز

این پروژه تحت مجوز Apache 2.0 منتشر شده است.

> **توجه:**
> کد، مدل‌ها و داده‌ها **فقط برای اهداف پژوهشی و آموزشی** ارائه شده‌اند.
> **استفاده تجاری مجاز نیست.**
> برای دریافت مجوز تجاری، لطفاً با نویسندگان تماس بگیرید.

**📦 اجزای شخص ثالث**

* **Stable Audio Open VAE** (توسط Stability AI):
  این مخزن شامل یک VAE تنظیم‌شده از [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) است که تحت [مجوز Stability AI Community](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) منتشر شده است.
  **استفاده تجاری و توزیع مجدد نیازمند اجازه قبلی از Stability AI است.**

* 📘 **سایر کدها و مدل‌ها** تحت مجوز Apache License 2.0 منتشر شده‌اند.

---

## تقدیر و تشکر

با تشکر فراوان از:

* **stable-audio-tools** (توسط Stability AI):
برای ارائه یک چارچوب ساده برای تولید صوت، همچنین ماژول VAE و وزن‌های آن.
* **MMAudio**:
  برای پیاده‌سازی بک‌بون MM-DiT در حوزه صوت.

---


## 📖 استناد

اگر پروژه ما را در تحقیقات یا کار خود مفید یافتید، لطفاً به مقاله ما استناد کنید:

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
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---