<div align="center">
<h1>گفتار فیش (Fish Speech)</h1>

**English** | [简体中文](docs/README.zh.md) | [Portuguese](docs/README.pt-BR.md) | [日本語](docs/README.ja.md) | [한국어](docs/README.ko.md) <br>

<a href="https://www.producthunt.com/posts/fish-speech-1-4?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-fish&#0045;speech&#0045;1&#0045;4" target="_blank">
    <img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=488440&theme=light" alt="Fish&#0032;Speech&#0032;1&#0046;4 - Open&#0045;Source&#0032;Multilingual&#0032;Text&#0045;to&#0045;Speech&#0032;with&#0032;Voice&#0032;Cloning | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" />
</a>
<a href="https://trendshift.io/repositories/7014" target="_blank">
    <img src="https://trendshift.io/api/badge/repositories/7014" alt="fishaudio%2Ffish-speech | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/>
</a>
<br>
</div>
<br>

<div align="center">
    <img src="https://count.getloli.com/get/@fish-speech?theme=asoul" /><br>
</div>

<br>

<div align="center">
    <a target="_blank" href="https://discord.gg/Es5qTB9BcN">
        <img alt="Discord" src="https://img.shields.io/discord/1214047546020728892?color=%23738ADB&label=Discord&logo=discord&logoColor=white&style=flat-square"/>
    </a>
    <a target="_blank" href="https://hub.docker.com/r/fishaudio/fish-speech">
        <img alt="Docker" src="https://img.shields.io/docker/pulls/fishaudio/fish-speech?style=flat-square&logo=docker"/>
    </a>
    <a target="_blank" href="https://pd.qq.com/s/bwxia254o">
      <img alt="QQ Channel" src="https://img.shields.io/badge/QQ-blue?logo=tencentqq">
    </a>
</div>

<div align="center">
    <a target="_blank" href="https://huggingface.co/spaces/TTS-AGI/TTS-Arena-V2">
      <img alt="TTS-Arena2 Score" src="https://img.shields.io/badge/TTS_Arena2-Rank_%231-gold?style=flat-square&logo=trophy&logoColor=white">
    </a>
    <a target="_blank" href="https://huggingface.co/spaces/fishaudio/fish-speech-1">
        <img alt="Huggingface" src="https://img.shields.io/badge/🤗%20-space%20demo-yellow"/>
    </a>
    <a target="_blank" href="https://huggingface.co/fishaudio/openaudio-s1-mini">
        <img alt="HuggingFace Model" src="https://img.shields.io/badge/🤗%20-models-orange"/>
    </a>
</div>

> [!IMPORTANT]
> **اطلاعیه مجوز**  
> این کد تحت مجوز **Apache License** منتشر شده و تمام وزن‌های مدل تحت مجوز **CC-BY-NC-SA-4.0** عرضه شده‌اند. لطفاً برای اطلاعات بیشتر به [LICENSE](LICENSE) مراجعه کنید.

> [!WARNING]
> **سلب مسئولیت قانونی**  
> ما هیچ گونه مسئولیتی در قبال استفاده غیرقانونی از این کد نداریم. لطفاً قوانین محلی خود درباره DMCA و سایر قوانین مرتبط را مطالعه فرمایید.

---

## 🎉 اطلاعیه

با خوشحالی اعلام می‌کنیم که برند خود را به **OpenAudio** تغییر داده‌ایم — معرفی مجموعه‌ای انقلابی از مدل‌های پیشرفته تبدیل متن به گفتار (TTS) که بر پایه Fish-Speech ساخته شده‌اند.

ما مفتخریم که **OpenAudio-S1** را به عنوان اولین مدل این سری عرضه می‌کنیم که بهبودهای چشمگیری در کیفیت، عملکرد و قابلیت‌ها ارائه می‌دهد.

OpenAudio-S1 در دو نسخه عرضه می‌شود: **OpenAudio-S1** و **OpenAudio-S1-mini**. هر دو مدل هم‌اکنون در [Fish Audio Playground](https://fish.audio) (برای **OpenAudio-S1**) و [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (برای **OpenAudio-S1-mini**) در دسترس هستند.

برای اطلاعات فنی و بلاگ به [وبسایت OpenAudio](https://openaudio.com/blogs/s1) مراجعه کنید.

## نکات برجسته ✨

### **کیفیت عالی TTS**

ما از معیارهای ارزیابی Seed TTS برای سنجش عملکرد مدل استفاده می‌کنیم و نتایج نشان می‌دهد که OpenAudio S1 به **0.008 WER** و **0.004 CER** روی متن انگلیسی دست یافته است که به طور قابل توجهی بهتر از مدل‌های پیشین است. (انگلیسی، ارزیابی خودکار، مبتنی بر OpenAI gpt-4o-transcribe، فاصله گوینده با استفاده از Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| مدل | نرخ خطای واژه (WER) | نرخ خطای نویسه (CER) | فاصله گوینده |
|-------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **بهترین مدل در TTS-Arena2** 🏆

OpenAudio S1 به **رتبه ۱** در [TTS-Arena2](https://arena.speechcolab.org/)، معیار سنجش تبدیل متن به گفتار، دست یافته است:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **کنترل گفتار**

OpenAudio S1 **از طیف وسیعی از احساسات، لحن‌ها و نشانه‌های ویژه** برای بهبود سنتز گفتار پشتیبانی می‌کند:

- **احساسات پایه**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **احساسات پیشرفته**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **نشانه‌های لحن**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **افکت‌های صوتی ویژه**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

همچنین می‌توانید از Ha,ha,ha برای کنترل استفاده کنید، موارد متعددی دیگر نیز وجود دارد که منتظر کشف شماست.

(در حال حاضر پشتیبانی برای انگلیسی، چینی و ژاپنی؛ زبان‌های بیشتر به زودی افزوده خواهند شد!)

### **دو نوع مدل**

| مدل | اندازه | دسترسی | ویژگی‌ها |
|-------|------|--------------|----------|
| **S1** | ۴ میلیارد پارامتر | قابل دسترسی در [fish.audio](fish.audio) | مدل پرچمدار با تمام قابلیت‌ها |
| **S1-mini** | ۰.۵ میلیارد پارامتر | قابل دسترسی در huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | نسخه تقطیر شده با قابلیت‌های اصلی |

هر دو مدل S1 و S1-mini از یادگیری تقویتی آنلاین با بازخورد انسانی (RLHF) بهره می‌برند.

## **ویژگی‌ها**

1. **تبدیل متن به گفتار Zero-shot & Few-shot:** با وارد کردن نمونه صوتی ۱۰ تا ۳۰ ثانیه‌ای، خروجی TTS با کیفیت بالا تولید کنید. **برای راهنمایی کامل، [بهترین شیوه‌های شبیه‌سازی صدا](https://docs.fish.audio/text-to-speech/voice-clone-best-practices) را ببینید.**

2. **پشتیبانی چندزبانه و میان‌زبانی:** کافیست متن چندزبانه را کپی و در جعبه ورودی قرار دهید—نگران زبان نباشید. پشتیبانی فعلی از انگلیسی، ژاپنی، کره‌ای، چینی، فرانسوی، آلمانی، عربی و اسپانیایی.

3. **بدون وابستگی به فونِم:** مدل دارای قابلیت تعمیم قوی است و برای تبدیل متن به گفتار نیازی به فونم ندارد. با هر اسکریپت زبانی کار می‌کند.

4. **دقت بسیار بالا:** نرخ خطای نویسه (CER) حدود ۰.۴٪ و نرخ خطای واژه (WER) حدود ۰.۸٪ برای Seed-TTS Eval.

5. **سریع:** با شتاب‌دهی fish-tech، ضریب زمان واقعی حدود ۱:۵ روی لپ‌تاپ Nvidia RTX 4060 و ۱:۱۵ روی Nvidia RTX 4090 است.

6. **استنتاج از طریق WebUI:** رابط کاربری وب مبتنی بر Gradio، سازگار با Chrome، Firefox، Edge و سایر مرورگرها.

7. **استنتاج از طریق GUI:** رابط گرافیکی PyQt6 که به طور کامل با سرور API کار می‌کند. پشتیبانی از لینوکس، ویندوز و macOS. [مشاهده GUI](https://github.com/AnyaCoder/fish-speech-gui).

8. **قابل استقرار:** سرور استنتاج را به راحتی با پشتیبانی بومی از لینوکس و ویندوز (به زودی مک) راه‌اندازی کنید، با حداقل افت سرعت.

## **رسانه و دموها**

<div align="center">

### **رسانه‌های اجتماعی**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **دموهای تعاملی**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **نمایش‌های ویدیویی**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **نمونه‌های صوتی**
<div style="margin: 20px 0;">
    <em>نمونه‌های صوتی با کیفیت بالا به زودی در دسترس قرار خواهند گرفت و قابلیت‌های TTS چندزبانه ما را در زبان‌ها و احساسات مختلف نشان خواهند داد.</em>
</div>

</div>

---

## مستندات

- [ساخت محیط](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [استنتاج](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## اعتبارها

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## گزارش فنی (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---