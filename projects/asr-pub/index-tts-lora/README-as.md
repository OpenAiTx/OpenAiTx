
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

[中文 সংস্কৰণ](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [English Version](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

এই প্ৰকল্পটো Bilibili-ৰ [index-tts](https://github.com/index-tts/index-tts)-ৰ ওপৰত আধাৰিত, যি **LoRA fine-tuning**-ৰ সমাধান দুয়োটা **একক-প্ৰবক্তা আৰু বহু-প্ৰবক্তা** সংহতিসকলৰ বাবে প্ৰদান কৰে। ইয়াৰ উদ্দেশ্য হৈছে উচ্চ-গুণমানৰ প্ৰবক্তা অডিঅ' সংশ্লেষণত **ছন্দ আৰু প্ৰাকৃতিকতা** উন্নত কৰা।

### প্ৰশিক্ষণ আৰু অনুমান

#### ১. অডিঅ' ট'কেন আৰু বক্তাৰ অৱস্থা নিৰ্যাসণ

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

উদ্ধাৰ কৰাৰ পিছত, প্ৰক্ৰিয়াকৃত ফাইলসমূহ আৰু `speaker_info.json` ফাইলখন `finetune_data/processed_data/` ডাইৰেক্টৰীত সৃষ্টি কৰা হ'ব। উদাহৰণস্বৰূপ:

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

#### 2. প্ৰশিক্ষণ

```shell
python train.py
```

#### 3. অনুমান

```shell
python indextts/infer.py
```

### ফাইন-টিউনিং ফলাফলসমূহ

এই পৰীক্ষাত **চীনাৰ অডিঅ' ডেটা** ব্যৱহাৰ কৰা হৈছে *কাই শু কাহিনী কয়*ৰ পৰা, মুঠ দৈৰ্ঘ্য **\~৩০ মিনিট** আৰু **২৭০টা অডিঅ' ক্লিপ**।
ডেটাসেটটো **২৪৪টা প্ৰশিক্ষণ নমুনা** আৰু **২৬টা মান্যতা নমুনা**ত বিভক্ত কৰা হৈছে।
টোকা: প্ৰতিলিপিসমূহ ASR আৰু যতিচিহ্ন মডেলৰ জৰিয়তে স্বয়ংক্ৰিয়ভাৱে সৃষ্টি কৰা হৈছে, মানৱীয় সংশোধন অবিহনে, গতিকে কিছুমান ভুল আশা কৰিব পাৰি।

প্ৰশিক্ষণ নমুনাৰ উদাহৰণ, `তেওঁ গাড়ীত উঠি, ৰাজপ্ৰাসাদলৈ গ'ল।`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### ১. বক্তৃতা সংশ্লেষণৰ উদাহৰণসমূহ


| পাঠ্য                                                         | অডিঅ'                                                        |
| ------------------------------------------------------------- | ------------------------------------------------------------- |
| পুৰণি ঘৰটোৰ ঘড়ী নিশা তিনি বজাত ৰৈ গ'ল, ধূলিকণাত দেখা দিলে এগুচ্ছ অচিন পায়েৰে গছ। অনুসন্ধানকাৰীয়ে ভুঁইত বহি চালে, মেজৰ ফাঁকত ৰৈ থকা ৰক্তলগা আঙঠীটো উলিয়াই পালে। | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| জোনাকৰ পোহৰত, কুমড়াটোৱে হঠাৎ হাঁহি-মুখ ল'লে, লতা-পাতত ভৰ দি বাগিছাৰ বেড়া ঠেলি খুলিলে। সৰু ছোৱালীজনীয়ে ভৰিত উঠি, ছত্রাকৰ গীত গোৱা শুনিলে, পুৰণি ল'ৰাৰ লয়ত। | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| তেন্তে Java-ৰ ভিতৰত মধ্যমীয়া আৰু শিকিব লাগিব, M আৰু বাহিৰৰ ফ্ৰন্টএণ্ড এপ্লিকেশন ছিষ্টেম ডেভেলপমেণ্টলৈ, Java Script-ৰ ডাটাবেছ শিকিব লাগিব, ডাইনামিক ৱেবছাইটো বনাব শিকিব লাগিব। | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| এই financial report-টোৱে কোম্পানীটোৰ যোৱা তিনি মাহৰ revenue performance আৰু expenditure trends বিশদভাৱে বিশ্লেষণ কৰিছে। | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| পাহাৰলৈ উঠা নামা এটা পাহাৰ, আন এটা পাহাৰ, তিনিমাইল তিনিমিটাৰ দৌৰি, এখন ডাঙৰ পাহাৰ উলিয়াই উঠিল, পাহাৰটো উচ্চতা তিনি শত ত্ৰিশ। পাহাৰত উঠি, ডাঙৰকৈ ক'লে: মই পাহাৰৰ পৰা তিনি হাত ডাঙৰ। | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| A thin man lies against the side of the street with his shirt and a shoe off and bags nearby. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| As research continued, the protective effect of fluoride against dental decay was demonstrated. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### ২. মডেল মূল্যায়ন
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### কৃতজ্ঞতা

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---