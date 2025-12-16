
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
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fr">ফ্ৰান্সী</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=de">ডয়েচ</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=es">স্পেনিছ</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=it">ইটালিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=nl">নেদাৰলেণ্ডছ</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=pl">প'লিচ</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=fa">ফাৰ্ছী</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=tr">টাৰ্কিছ</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=vi">ভিয়েটনামীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=id">ইণ্ডোনেচিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=asr-pub&project=index-tts-lora&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# index-tts-lora

[中文 সংস্কৰণ](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [ইংৰাজী সংস্কৰণ](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

এই প্ৰকল্পটো Bilibili ৰ [index-tts](https://github.com/index-tts/index-tts) ৰ আধাৰত নিৰ্মিত, যি **single-speaker আৰু multi-speaker** দুয়োটা বাবে **LoRA fine-tuning** সমাধান প্ৰদান কৰে। ইয়াৰ উদ্দেশ্য হৈছে উচ্চ-গুণগত মানৰ বক্তা শব্দ সংশ্লেষণত **প্ৰসডি আৰু প্ৰাকৃতিকতা** বৃদ্ধি কৰা।

### প্রশিক্ষণ আৰু অনুমান

#### ১. অডিঅ' টোকেন আৰু বক্তাৰ অৱস্থা উলিওৱা

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

এই পৰীক্ষাত **চীনীয়া অডিঅ' ডাটা** ব্যৱহাৰ কৰা হৈছে *কাই শু গল্প কয়* ৰ পৰা, মুঠ সময়সীমা **\~৩০ মিনিট** আৰু **২৭০টা অডিঅ' ক্লিপ**।
ডেটাসেটখন **২৪৪টা প্ৰশিক্ষণ নমুনা** আৰু **২৬টা ভেলিডেশ্যন নমুনা**ত বিভক্ত কৰা হৈছে।
টোকা: ট্ৰান্স্ক্ৰিপ্টসমূহ ASR আৰু পাংচুৱেচন মডেলৰ জৰিয়তে স্বয়ংক্ৰিয়ভাৱে তৈয়াৰ কৰা হৈছে, হাতেদিয়ে সংশোধন কৰা হোৱা নাই, সেইবাবে কিছু ভুল থাকিব পাৰে।

উদাহৰণ স্বৰূপে প্ৰশিক্ষণ নমুনা, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### ১. বাক্য সংশ্লেষণ উদাহৰণসমূহ


| পাঠ                                                         | অডিঅ'                                                        |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| পুৰণি ঘৰখনৰ ঘড়ী নিশা তিনি বজাত বন্ধ হৈ থাকিল, ধূলিত দেখা দিলে অজানা ভৰিৰ ছাঁ। গোয়েন্দাগৰাকীয়ে ভুমিত থুপ হৈ, মাটিৰ ফাঁকত ৰক্তৰে ভেজা আঙুঠি এটা পালে। | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| জোনাকৰ তলত, কুমৰা অকস্মাৎ হাঁহিৰ মুখ লৈ উঠিল, লতা-বেটা খুলি দিয়াৰ দৰে বাগিচাৰ বেড়াখন ঠেলি দিলে। সৰু ছোৱালীজনী ভৰিত ভৰি দি উঠি, মছৰুমবোৰে পুৰণি ললিপিঠা গীত গাইছে শুনিলে। | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| তেন্তে Java-ৰ ভিতৰত মধ্যম স্তৰৰ বিষয়ও শিকা লাগে, আৰু বাহিৰৰ frontend application system development, Java Script-ৰ database, dynamic website বনাবলৈ শিকা লাগে। | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| এই financial report-এ কোম্পানীটোৰ বিগত এটা quarter-ৰ revenue performance আৰু expenditure trends বিস্তারিতভাৱে বিশ্লেষণ কৰিছে। | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| পাহাৰলৈ উঠিল, পাহাৰৰ পৰা নামিল, এজন পাহাৰ, আনজন পাহাৰ, তিনি মাইল তিনি মিটাৰ দৌৰি, এটা ডাঙৰ পাহাৰত উঠিল, পাহাৰৰ উচ্চতা তিনিশ তিন। পাহাৰত উঠি, ডাঙৰকৈ কৈছে: মই পাহাৰৰ পৰা তিনিচুক উচ্চ। | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| A thin man lies against the side of the street with his shirt and a shoe off and bags nearby. | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| As research continued, the protective effect of fluoride against dental decay was demonstrated. | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### ২. মডেল মূল্যায়ন
মূল্যায়ন ছেটৰ বিৱৰণৰ বাবে চাওক: [২০২৫ মূলধাৰা TTS মডেলৰ বেঞ্চমাৰ্ক: কোনটো হৈছে আটাইতকৈ ভাল ভয়েছ সংশ্লেষণ সমাধান?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### স্বীকৃতি

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---