
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

[中文版本](https://github.com/asr-pub/index-tts-lora/blob/main/README_zh.md) | [अंग्रेज़ी संस्करण](https://github.com/asr-pub/index-tts-lora/blob/main/README.md)

यह परियोजना Bilibili के [index-tts](https://github.com/index-tts/index-tts) पर आधारित है, जो **एकल वक्ता और बहु-वक्ता** सेटअप के लिए **LoRA फाइन-ट्यूनिंग** समाधान प्रदान करती है। इसका उद्देश्य उच्च गुणवत्ता वाले वक्ता ऑडियो संश्लेषण में **लय और स्वाभाविकता** को बढ़ाना है।

### प्रशिक्षण एवं अनुमान

#### 1. ऑडियो टोकन और वक्ता स्थिति निष्कर्षण

```shell
# Extract tokens and speaker conditions
python tools/extract_codec.py --audio_list ${audio_list} --extract_condition

# audio_list format: audio_path + transcript, separated by \t
/path/to/audio.wav 小朋友们，大家好，我是凯叔，今天我们讲一个龟兔赛跑的故事。
```

एक्सट्रैक्शन के बाद, प्रोसेस्ड फाइलें और `speaker_info.json` फाइल `finetune_data/processed_data/` डायरेक्टरी के तहत जेनरेट होंगी। उदाहरण के लिए:

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

#### 2. प्रशिक्षण

```shell
python train.py
```

#### 3. निष्कर्ष

```shell
python indextts/infer.py
```

### फाइन-ट्यूनिंग परिणाम

इस प्रयोग में **चीनी ऑडियो डेटा** का उपयोग किया गया है *Kai Shu Tells Stories* से, जिसकी कुल अवधि **\~30 मिनट** और **270 ऑडियो क्लिप्स** है।
डेटासेट को **244 प्रशिक्षण नमूनों** और **26 सत्यापन नमूनों** में विभाजित किया गया है।
नोट: ट्रांस्क्रिप्ट्स स्वचालित रूप से ASR और विराम चिन्ह मॉडल्स द्वारा बनाई गई हैं, बिना मैन्युअल सुधार के, इसलिए कुछ त्रुटियाँ अपेक्षित हैं।

उदाहरण प्रशिक्षण नमूना, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. भाषण संश्लेषण उदाहरण


| टेक्स्ट                                                        | ऑडियो                                                         |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| पुराने घर की घड़ी आधी रात तीन बजे पर रुकी है, धूल में अजनबी पैरों के निशान उभर आते हैं। जासूस झुककर देखता है, फर्श की दरार में खून लगा हुआ अंगूठी छिपी है। | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| चांदनी में, कद्दू ने अचानक हँसता चेहरा बना लिया, बेलें मुड़ती हुई बगिया की जाली खोल देती हैं। छोटी लड़की उचककर खड़ी होती है, सुनती है कि मशरूम प्राचीन लोरी गा रहे हैं। | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| तो Java में मिड-लेवल भी सीखना है, M और बाहरी फ्रंटएंड एप्लिकेशन सिस्टम डेवलपमेंट तक, Java Script का डेटाबेस सीखना है, डायनामिक वेबसाइट बनाना सीखना है। | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| यह financial report कंपनी की पिछले एक तिमाही की revenue performance और expenditure trends का विस्तृत विश्लेषण करती है। | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| पहाड़ चढ़ा, पहाड़ उतरा, एक पहाड़ ऊपर, एक पहाड़ नीचे, तीन ली तीन मीटर तीन दौड़े, एक बड़ा ऊँचा पहाड़ चढ़ा, पहाड़ की ऊँचाई तीन सौ तीस। पहाड़ चढ़कर जोर से बोला: मैं पहाड़ से तीन फीट ऊँचा हूँ। | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| एक दुबला आदमी सड़क के किनारे अपनी शर्ट और एक जूता उतारकर और बैग पास में रखकर लेटा हुआ है। | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| जैसे-जैसे रिसर्च आगे बढ़ी, दंत क्षय के खिलाफ फ्लोराइड की सुरक्षा प्रभाव सिद्ध हुई। | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. मॉडल मूल्यांकन
मूल्यांकन सेट का विवरण देखें: [2025 Benchmark of Mainstream TTS Models: Who Is the Best Voice Synthesis Solution?](https://mp.weixin.qq.com/s/5z_aRKQG3OIv7fnSdxegqQ)
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### आभार

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---