# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~आगे की योजना है कि ente-io/ente पर माइग्रेट किया जाए, क्योंकि मुझे फोटो स्टोर करने के लिए s3 की जरूरत है~~
> 
> लेकिन ente में अभी भी बहुत कम फीचर्स हैं
> 
> अब juicedata/juicefs का उपयोग कर s3 को माउंट किया गया है

## परियोजना का संक्षिप्त परिचय

यह परियोजना [Immich](https://github.com/immich-app/immich) फोटो प्रबंधन प्रणाली के एआई क्षमता संवर्धन समाधान के रूप में है। इसमें मुख्य रूप से निम्नलिखित घटकों द्वारा Immich के मूल फीचर्स को विस्तारित किया गया है:

- **inference-gateway**: Go भाषा में लिखा गया गेटवे सेवा, जो Immich के मशीन लर्निंग अनुरोधों का स्मार्ट डायवर्शन करता है
- **mt-photos-ai**: Python और FastAPI पर आधारित एआई सेवा, जिसमें RapidOCR और cn-clip मॉडल एकीकृत हैं
- Immich की कार्यक्षमता का विस्तार, जिसमें OCR टेक्स्ट रिकग्निशन सर्च और एकल मीडिया एआई डेटा री-प्रोसेसिंग, OCR पूर्ण-पाठ वेक्टर और CLIP वेक्टर स्कोरिंग मिक्स्ड सॉर्टिंग शामिल है
- PostgreSQL में zhparser चीनी वर्ड सेगमेंटेशन जोड़ा गया

## प्रमुख विशेषताएँ

### 1. OCR टेक्स्ट पहचान और खोज

- RapidOCR का उपयोग कर इमेज में मौजूद टेक्स्ट की पहचान
- हिंदी और अंग्रेजी दोनों के मिश्रित टेक्स्ट की पहचान को सपोर्ट करता है
- इमेज टेक्स्ट कंटेंट पर आधारित खोज की सुविधा

### 2. CLIP इमेज वेक्टर प्रोसेसिंग

- cn-clip मॉडल के आधार पर अधिक सटीक चीनी इमेज-टेक्स्ट मैचिंग
- अर्थ-आधारित खोज को सपोर्ट करता है, जिससे खोज की सटीकता बढ़ती है

### 3. एकल मीडिया एआई डेटा री-प्रोसेसिंग

- किसी एक फोटो/वीडियो के लिए OCR डेटा दोबारा जनरेट करने की सुविधा
- किसी एक फोटो/वीडियो के लिए CLIP वेक्टर डेटा दोबारा जनरेट करने की सुविधा
- जब पहचान का परिणाम सही न हो तो मैन्युअल रीफ्रेश की सुविधा

## सिस्टम आर्किटेक्चर

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP请求
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python服务)    │
                     │                  │
                     └──────────────────┘
```
## घटक विस्तृत विवरण

### inference-gateway

Go भाषा में लिखा गया गेटवे सेवा, मुख्य जिम्मेदारियाँ:
- Immich की मशीन लर्निंग अनुरोधों को प्राप्त करना
- अनुरोध के प्रकार के अनुसार OCR और CLIP अनुरोधों को mt-photos-ai सेवा पर अग्रेषित करना
- अन्य मशीन लर्निंग अनुरोधों (जैसे फेस रिकग्निशन) को Immich की मूल मशीन लर्निंग सेवा पर अग्रेषित करना
- प्रमाणीकरण और डेटा प्रारूप रूपांतरण संभालना

### mt-photos-ai

Python और FastAPI में लिखा गया AI सेवा, यह प्रदान करता है:
- OCR टेक्स्ट रिकग्निशन API (RapidOCR पर आधारित)
- CLIP वेक्टर प्रोसेसिंग API (cn-clip पर आधारित)
- GPU त्वरक का समर्थन

## परिनियोजन निर्देश

### पर्यावरण आवश्यकताएँ

- Docker और Docker Compose
- NVIDIA GPU (वैकल्पिक, लेकिन प्रोसेसिंग को तेज करने के लिए अनुशंसित)
- पर्याप्त संग्रहण स्थान

### कॉन्फ़िगरेशन विवरण

1. **inference-gateway कॉन्फ़िगरेशन**

मुख्य पर्यावरण वेरिएबल्स:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **mt-photos-ai कॉन्फ़िगरेशन**

मुख्य परिवेश वेरिएबल्स:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### परिनियोजन चरण

1. रिपॉजिटरी क्लोन करें:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. सेवा प्रारंभ करें:

```bash
docker-compose up -d
```
## उपयोग निर्देश

1. **Immich में कस्टम ML सेवा को कॉन्फ़िगर करें**

Immich की कॉन्फ़िगरेशन फ़ाइल में, मशीन लर्निंग सेवा का पता inference-gateway की ओर इंगित करें:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **OCR खोज का उपयोग**

- Immich खोज बार में `ocr:` उपसर्ग का उपयोग करके OCR खोज करें
- उदाहरण: `ocr:चालान` उन तस्वीरों को खोजेगा जिनमें "चालान" शब्द मौजूद है

3. **एकल मीडिया AI डेटा पुन: प्रोसेसिंग**

- फोटो विवरण पृष्ठ पर, मेनू विकल्प पर क्लिक करें
- "OCR डेटा पुन: उत्पन्न करें" या "CLIP वेक्टर पुन: उत्पन्न करें" चुनें
- सिस्टम उस फोटो का AI डेटा दोबारा प्रोसेस करेगा

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

यह प्रोजेक्ट MIT लाइसेंस के अंतर्गत ओपन सोर्स है।

## आभार

- [Immich](https://github.com/immich-app/immich) - ओपन सोर्स सेल्फ-होस्टेड फोटो और वीडियो बैकअप समाधान
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - PaddleOCR आधारित क्रॉस-प्लेटफार्म OCR लाइब्रेरी
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - चीनी मल्टीमॉडल कॉन्ट्रास्टिव लर्निंग प्री-ट्रेंड मॉडल



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---