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

यह प्रोजेक्ट Bilibili के [index-tts](https://github.com/index-tts/index-tts) पर आधारित है, जो **LoRA फाइन-ट्यूनिंग** समाधानों को **एकल-स्पीकर और बहु-स्पीकर** दोनों सेटअप के लिए प्रदान करता है। इसका उद्देश्य उच्च गुणवत्ता वाली स्पीकर ऑडियो सिंथेसिस में **स्वर और प्राकृतिकता** को बढ़ाना है।

### प्रशिक्षण और अनुमान


#### 1. ऑडियो टोकन और स्पीकर कंडीशन निष्कर्षण

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

यह प्रयोग **चीनी ऑडियो डेटा** का उपयोग करता है जो *काई शू टेल्स स्टोरीज़* से लिया गया है, कुल अवधि **\~30 मिनट** और **270 ऑडियो क्लिप्स** की है।
डेटासेट को **244 प्रशिक्षण नमूनों** और **26 मान्यता नमूनों** में विभाजित किया गया है।
नोट: ट्रांसक्रिप्ट्स को ASR और विराम चिह्न मॉडलों के माध्यम से स्वचालित रूप से उत्पन्न किया गया, बिना मैन्युअल सुधार के, इसलिए कुछ त्रुटियाँ अपेक्षित हैं।

उदाहरण प्रशिक्षण नमूना, `他上了马车，来到了皇宫之中。`：[kaishu_train_01.wav](https://github.com/user-attachments/files/22354621/kaishu_train_01.wav)


#### 1. वाक् संश्लेषण उदाहरण


| पाठ                                                            | ऑडियो                                                        |
| -------------------------------------------------------------- | ------------------------------------------------------------ |
| पुरानी हवेली की घड़ी आधी रात के तीन बजे रुकी थी, धूल में अजनबी पैरों के निशान उभरे थे। जासूस झुककर देखता है, फर्श की दरार में खून से सनी अंगूठी छिपी थी। | [kaishu_cn_1.wav](https://github.com/user-attachments/files/22354649/kaishu_cn_1.wav) |
| चांदनी में कद्दू ने अचानक मुस्कान वाला चेहरा बना लिया, बेलें मरोड़ती हुई बगिया की बाड़ खोलती हैं। छोटी लड़की उचककर, सुनती है कि मशरूम प्राचीन लोरी गुनगुना रहे हैं। | [kaishu_cn_2.wav](https://github.com/user-attachments/files/22354652/kaishu_cn_2.wav) |
| तो Java में मिड-लेवल भी सीखना है, M तथा बाहरी फ्रंटएंड एप्लिकेशन सिस्टम डेवलपमेंट तक, Java Script का डेटाबेस, और डायनामिक वेबसाइट बनाना भी सीखना है। | [kaishu_cn_en_mix_1.wav](https://github.com/user-attachments/files/22354654/kaishu_cn_en_mix_1.wav) |
| यह financial report कंपनी के पिछले तिमाही के revenue performance और expenditure trends का विस्तार से विश्लेषण करती है। | [kaishu_cn_en_mix_2.wav](https://github.com/user-attachments/files/22354656/kaishu_cn_en_mix_2.wav) |
| पहाड़ चढ़े, पहाड़ उतरे, एक पहाड़ ऊपर, दूसरा पहाड़ नीचे, तीन कोस तीन मीटर तीन दौड़े, एक ऊँचा बड़ा पहाड़ चढ़ा, पहाड़ की ऊँचाई तीन सौ तीन। पहाड़ पर चढ़कर ऊँचे स्वर में बोला: मैं पहाड़ से तीन फुट तीन ऊँचा हूँ। | [kaishu_raokouling.wav](https://github.com/user-attachments/files/22354658/kaishu_raokouling.wav) |
| एक पतला आदमी सड़क के किनारे अपनी शर्ट और एक जूते के बिना लेटा है, बैग पास में हैं। | [kaishu_en_1.wav](https://github.com/user-attachments/files/22354659/kaishu_en_1.wav) |
| जैसे-जैसे शोध आगे बढ़ा, दंत क्षय के खिलाफ फ्लोराइड का सुरक्षात्मक प्रभाव प्रदर्शित हुआ। | [kaishu_en_2.wav](https://github.com/user-attachments/files/22354661/kaishu_en_2.wav) |

#### 2. मॉडल मूल्यांकन
<img width="1182" height="261" alt="image" src="https://github.com/user-attachments/assets/fb86938d-95d9-4b10-9588-2de1e43b51d1" />

### आभार

[index-tts](https://github.com/index-tts/index-tts)

[finetune-index-tts](https://github.com/yrom/finetune-index-tts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---