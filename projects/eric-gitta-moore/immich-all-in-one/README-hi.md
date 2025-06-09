# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~आगे की योजना है कि ente-io/ente पर माइग्रेट किया जाए, क्योंकि मुझे s3 की आवश्यकता है फोटो स्टोरेज के लिए~~
> 
> ente में अभी भी बहुत कम फीचर्स हैं
> 
> अब juicedata/juicefs का उपयोग कर s3 को माउंट किया गया है

## परियोजना परिचय

यह परियोजना [Immich](https://github.com/immich-app/immich) फोटो प्रबंधन सिस्टम की AI क्षमताओं को बढ़ाने का समाधान है। मुख्य रूप से निम्नलिखित घटकों के माध्यम से Immich की मूल सुविधाओं का विस्तार किया गया है:

- **inference-gateway**: Go भाषा में लिखा गया गेटवे सेवा, जो Immich के मशीन लर्निंग अनुरोधों का बुद्धिमान रूटिंग करती है
- **mt-photos-ai**: Python और FastAPI आधारित AI सेवा, जिसमें RapidOCR और cn-clip मॉडल एकीकृत हैं
- Immich के लिए फीचर विस्तार, जिसमें OCR टेक्स्ट रिकग्निशन सर्च और एकल मीडिया AI डेटा री-प्रोसेसिंग, OCR फुलटेक्स्ट वेक्टर और CLIP वेक्टर स्कोरिंग मिक्स्ड सॉर्टिंग शामिल हैं
- PostgreSQL में zhparser चीनी वर्ड सेगमेंटेशन जोड़ा गया

## मुख्य विशेषताएं

### 1. OCR टेक्स्ट पहचान और खोज

- RapidOCR का उपयोग कर चित्रों में पाठ की पहचान
- चीनी-अंग्रेजी मिश्रित टेक्स्ट पहचान का समर्थन
- चित्रों के टेक्स्ट सामग्री के आधार पर खोज सुविधा

### 2. CLIP इमेज वेक्टर प्रोसेसिंग

- cn-clip मॉडल के आधार पर अधिक सटीक चीनी इमेज-टेक्स्ट मिलान
- सिमेंटिक सर्च का समर्थन, जिससे खोज सटीकता बेहतर होती है

### 3. एकल मीडिया AI डेटा री-प्रोसेसिंग

- एकल चित्र/वीडियो के लिए OCR डेटा दोबारा जनरेट करने का समर्थन
- एकल चित्र/वीडियो के लिए CLIP वेक्टर डेटा दोबारा जनरेट करने का समर्थन
- पहचान परिणाम गलत होने की स्थिति में मैन्युअल रीफ्रेश की सुविधा

## सिस्टम आर्किटेक्चर

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Goगेटवे)     │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIPअनुरोध
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │ (Pythonसेवा)     │
                     │                  │
                     └──────────────────┘
```

## घटकों का विवरण

### inference-gateway

Go भाषा में लिखा गया गेटवे सेवा, मुख्य जिम्मेदारियां:
- Immich के मशीन लर्निंग अनुरोध प्राप्त करना
- अनुरोध के प्रकार के अनुसार OCR और CLIP अनुरोधों को mt-photos-ai सेवा पर रूट करना
- अन्य मशीन लर्निंग अनुरोध (जैसे फेस रिकग्निशन) को Immich की मूल मशीन लर्निंग सेवा पर रूट करना
- प्रमाणीकरण और डेटा फॉर्मेट रूपांतरण को संभालना

### mt-photos-ai

Python और FastAPI में लिखा गया AI सेवा, उपलब्ध कराता है:
- OCR टेक्स्ट रिकग्निशन API (RapidOCR आधारित)
- CLIP वेक्टर प्रोसेसिंग API (cn-clip आधारित)
- GPU त्वरितीकरण का समर्थन

## परिनियोजन निर्देश

### पर्यावरण आवश्यकताएं

- Docker और Docker Compose
- NVIDIA GPU (वैकल्पिक, लेकिन प्रोसेसिंग को तेज करने के लिए अनुशंसित)
- पर्याप्त स्टोरेज स्पेस

### कॉन्फ़िगरेशन विवरण

1. **inference-gateway कॉन्फ़िगरेशन**

मुख्य पर्यावरण वेरिएबल्स:
```
IMMICH_API=http://localhost:3003  # Immich API पता
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai सेवा का पता
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API कुंजी
PORT=8080  # गेटवे लिसनिंग पोर्ट
```

2. **mt-photos-ai कॉन्फ़िगरेशन**

मुख्य पर्यावरण वेरिएबल्स:
```
CLIP_MODEL=ViT-B-16  # CLIP मॉडल नाम
CLIP_DOWNLOAD_ROOT=./models/clip  # मॉडल डाउनलोड पथ
DEVICE=cuda  # या cpu, इंफरेंस डिवाइस
HTTP_PORT=8060  # सेवा लिसनिंग पोर्ट
```

### परिनियोजन चरण

1. रिपॉजिटरी क्लोन करें:
```bash
git clone https://github.com/आपका-यूज़रनेम/immich-all-in-one.git
cd immich-all-in-one
```

2. सेवा प्रारंभ करें:
```bash
docker-compose up -d
```

## उपयोग निर्देश

1. **Immich में कस्टम ML सेवा का कॉन्फ़िगरेशन**

Immich की कॉन्फ़िगरेशन फ़ाइल में, मशीन लर्निंग सेवा का पता inference-gateway पर सेट करें:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **OCR सर्च का उपयोग**

- Immich सर्च बार में `ocr:` प्रीफिक्स के साथ OCR सर्च करें
- उदाहरण: `ocr:इनवॉयस` से "इनवॉयस" शब्द वाले चित्र खोजे जाएंगे

3. **एकल मीडिया AI डेटा री-प्रोसेसिंग**

- फोटो डिटेल पेज पर, मेनू विकल्प पर क्लिक करें
- "OCR डेटा दोबारा जनरेट करें" या "CLIP वेक्टर दोबारा जनरेट करें" चुनें
- सिस्टम संबंधित फोटो का AI डेटा दोबारा प्रोसेस करेगा

## विकास गाइड

### inference-gateway (Go)

कंपाइल और रन करें:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

डेवलपमेंट एनवायरनमेंट सेटअप:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## लाइसेंस

यह परियोजना MIT लाइसेंस के तहत ओपनसोर्स है।

## आभार

- [Immich](https://github.com/immich-app/immich) - ओपनसोर्स सेल्फ-होस्टेड फोटो और वीडियो बैकअप समाधान
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - PaddleOCR आधारित क्रॉस-प्लेटफार्म OCR लाइब्रेरी
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - चीनी मल्टीमॉडल कॉन्ट्रास्टिव लर्निंग प्रीट्रेंड मॉडल

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---