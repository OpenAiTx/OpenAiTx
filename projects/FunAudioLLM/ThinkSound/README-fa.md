# 🎶 ThinkSound

<p align="center">
  اگر این پروژه برای شما مفید بود، یک ستاره ⭐ در گیت‌هاب بسیار ارزشمند خواهد بود!
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

---

**ThinkSound** یک چارچوب یکپارچه Any2Audio برای تولید صوت با راهنمایی تطبیق جریان بر اساس استدلال زنجیره‌ای (Chain-of-Thought یا CoT) است.

پیاده‌سازی با PyTorch برای تولید و ویرایش صوت چندرسانه‌ای: تولید یا ویرایش صوت از ویدئو، متن و صوت، با پشتیبانی از استدلال گام به گام مبتنی بر مدل‌های زبانی بزرگ چندرسانه‌ای (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 اخبار
- **2025.07** &nbsp; 🔥دموی آنلاین روی [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) و [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) برای تجربه تعاملی!
- **2025.07** &nbsp; 🔥اسکریپت‌های استنتاج و رابط وب منتشر شد؛
- **2025.06** &nbsp; 🔥[مقاله ThinkSound](https://arxiv.org/pdf/2506.21448) در arXiv منتشر شد!
- **2025.06** &nbsp; 🔥[دموی آنلاین](http://thinksound-project.github.io/) فعال شد - همین حالا امتحان کنید!

---

## 🚀 ویژگی‌ها

- **Any2Audio**: تولید صوت از هر نوع مدالیتی — ویدئو، متن، صوت، یا ترکیب آن‌ها.
- **بهترین عملکرد Video-to-Audio**: دستیابی به نتایج پیشرفته در چندین بنچمارک V2A.
- **استدلال مبتنی بر CoT**: استدلال زنجیره‌ای برای تولید صوت ترکیبی و قابل کنترل با استفاده از MLLMs.
- **ویرایش تعاملی مبتنی بر شیء**: پالایش یا ویرایش رویدادهای صوتی خاص با کلیک روی اشیاء تصویری یا با دستور متنی.
- **چارچوب یکپارچه**: یک مدل پایه برای تولید، ویرایش و جریان کاری تعاملی.

---

## ✨ مروری بر روش

ThinkSound تولید و ویرایش صوت را به سه مرحله تعاملی تقسیم می‌کند که همگی توسط استدلال زنجیره‌ای مبتنی بر MLLM هدایت می‌شوند:

1. **تولید Foley:** تولید صداهای پایه، هم‌تراز معنایی و زمانی از ویدئو.
2. **پالایش مبتنی بر شیء:** پالایش یا افزودن صدا برای اشیاء مشخص‌شده توسط کاربر از طریق کلیک یا ناحیه‌بندی در ویدئو.
3. **ویرایش هدفمند صوت:** ویرایش صوت تولید شده با استفاده از دستورات زبان طبیعی سطح بالا.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- یک دیتاست با حاشیه‌نویسی CoT در مقیاس بزرگ (**AudioCoT**) برای آموزش ماژول استدلال و مدل پایه صوتی یکپارچه استفاده می‌شود.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ شروع سریع

**آماده‌سازی محیط:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# دانلود وزن‌های آموزش‌دیده از https://huggingface.co/liuhuadai/ThinkSound به پوشه ckpts/
# وزن‌های مدل همچنین از https://www.modelscope.cn/models/iic/ThinkSound قابل دانلود هستند
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**قابل اجرا کردن اسکریپت**
```bash
chmod +x scripts/demo.sh
```

**اجرای اسکریپت**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### استفاده از رابط وب

برای تجربه تعاملی، رابط وب Gradio را اجرا کنید:

```bash
python app.py
```

---
## 📝 TODO

- ☐ انتشار اسکریپت‌های آموزش برای مدل‌های ThinkSound
- ☐ متن‌باز کردن دیتاست AudioCoT و خط لوله خودکار
- ☐ ارائه مستندات جامع و مرجع API
- ☐ افزودن پشتیبانی از مودالیتـی‌ها و وظایف پایین‌دستی بیشتر

---

## 📄 مجوز

این پروژه تحت [مجوز Apache 2.0](LICENSE) منتشر شده است.

> **توجه:**  
> کد، مدل‌ها و دیتاست **تنها برای اهداف پژوهشی و آموزشی** هستند.  
> **استفاده تجاری مجاز نیست.**
>
> برای دریافت مجوز تجاری، لطفاً با نویسندگان تماس بگیرید.

---

## 📖 استناد

اگر ThinkSound در پژوهش یا کار شما مفید بوده است، لطفاً به مقاله ما ارجاع دهید:

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

✨ در صورت داشتن هرگونه سوال یا پیشنهاد، [یک ایشو باز کنید](https://github.com/liuhuadai/ThinkSound/issues) یا از طریق ایمیل ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) با ما در ارتباط باشید!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---