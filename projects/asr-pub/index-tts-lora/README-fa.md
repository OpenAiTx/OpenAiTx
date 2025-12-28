<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# index-tts-lora

[نسخه چینی](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [نسخه انگلیسی](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

این پروژه بر پایه [index-tts](https://github.com/index-tts/index-tts) بیلیبیلی ساخته شده است و راهکارهای **تنظیم دقیق LoRA** را برای هر دو حالت **تک‌گوینده و چند‌گوینده** ارائه می‌دهد. هدف آن بهبود **وزن و طبیعی بودن** در سنتز صدای با کیفیت بالا برای گویندگان است.

### آموزش و استنتاج


#### ۱. استخراج توکن صوتی و شرایط گوینده

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

پس از استخراج، فایل‌های پردازش‌شده و `speaker_info.json` در پوشه `finetune_data/processed_data/` ایجاد خواهند شد. برای مثال:

```json
[
    {
        "speaker": "kaishu_30min",
        "avg_duration": 6.6729,
        "sample_num": 270,
        "total_duration_in_seconds": 1801.696,
        "total_duration_in_minutes": 30.028,
        "total_duration_in_hours": 0.500,
        "train_jsonl": "/path/to/kaishu_30min/metadata_train.jsonl",
        "valid_jsonl": "/path/to/kaishu_30min/metadata_valid.jsonl",
        "medoid_condition": "/path/to/kaishu_30min/medoid_condition.npy"
    }
]
```

#### ۲. آموزش

```shell
python train.py
```

#### ۳. استنتاج

```shell
python indextts/infer.py
```

### نتایج تنظیم دقیق

این آزمایش از **داده‌های صوتی چینی** مجموعه *Kai Shu Tells Stories* با مدت زمان کل **حدود ۳۰ دقیقه** و **۲۷۰ کلیپ صوتی** استفاده می‌کند.
داده‌ها به **۲۴۴ نمونه آموزشی** و **۲۶ نمونه اعتبارسنجی** تقسیم شده‌اند.
توجه: متن‌های گفتاری به صورت خودکار با مدل‌های ASR و نقطه‌گذاری تولید شده‌اند و بدون اصلاح دستی هستند، بنابراین انتظار برخی خطاها وجود دارد.

نمونه آموزشی مثال، `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### ۱. نمونه‌های سنتز گفتار


| متن                                                          | صوت                                                          |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| ساعت خانه قدیمی در ساعت سه نیمه‌شب ایستاده بود، ردپای غریبه‌ای در میان گرد و غبار ظاهر شد. کارآگاه خم شد و حلقه‌ای خون‌آلود را میان شیارهای کف زمین پیدا کرد. | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| زیر نور ماه، کدو ناگهان صورت خندان پیدا کرد، شاخه‌ها پیچ خوردند و نرده باغ را کنار زدند. دخترک روی پنجه پا ایستاد و شنید قارچ‌ها لالایی قدیمی می‌خوانند. | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| پس در جاوا سطح متوسط را باید بیاموزید، همچنین توسعه سیستم‌های کاربردی فرانت‌اند خارجی تا جاوا اسکریپت و پایگاه داده را بیاموزید و سایت‌های پویا بسازید. | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| این financial report عملکرد درآمد و روند هزینه شرکت را در سه‌ماهه گذشته به طور دقیق تحلیل کرده است. | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| از کوه بالا و پایین رفت، یک کوه دیگر، سه لی و سه متر دوید، یک کوه بلند بالا رفت، ارتفاع کوه سیصد و سی متر بود. بالای کوه با صدای بلند گفت: من سه وجب از کوه بلندترم. | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| مردی لاغر با پیراهن و یک کفش کنار خیابان دراز کشیده و کیسه‌ها کنار اوست. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| با ادامه تحقیقات، اثر محافظتی فلوراید در برابر پوسیدگی دندان اثبات شد. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### ۲. ارزیابی مدل
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### تقدیر و تشکر

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---