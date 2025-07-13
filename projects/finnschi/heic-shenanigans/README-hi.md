# 🖼️ HEIC इमेज प्रोसेसिंग टूल्स

HEIC (हाई एफिशिएंसी इमेज कंटेनर) फाइलों के प्रोसेसिंग के लिए पायथन टूल्स का संग्रह, जिसमें HDR कंटेंट एक्सट्रैक्शन और EXR कन्वर्जन पर विशेष ध्यान दिया गया है।

## 🛠️ टूल्स का अवलोकन

### 1. gain_map_extract.py
HEIC फाइलों से सभी घटक निकालता है, जिसमें शामिल हैं:
- बेस इमेजेज़
- HDR गेन मैप्स
- डेप्थ मैप्स
- पूरी मेटाडेटा (EXIF, XMP, ICC प्रोफाइल्स)

### 2. heic_to_exr.py
HEIC फाइलों को OpenEXR फॉर्मेट में कन्वर्ट करता है:
- बेस इमेज और गेन मैप को HDR EXR में एप्पल के तरीके से मिलाता है
- पूरी डायनामिक रेंज को सुरक्षित रखता है
- जहां संभव हो, मेटाडेटा को बनाए रखता है
- बैच प्रोसेसिंग को सपोर्ट करता है
### 3. merge_to_exr.sh
बैच प्रोसेसिंग के लिए शेल स्क्रिप्ट:
- HEIC से EXR रूपांतरण को स्वचालित करता है
- कई फाइलों को संभालता है
- प्रगति प्रतिक्रिया प्रदान करता है
- डायरेक्टरी संरचना बनाए रखता है

## 🔧 स्थापना

### आवश्यकताएँ
- Python 3.8 या उच्चतर
- pip (Python पैकेज प्रबंधक)
- Git (रिपॉजिटरी क्लोन करने के लिए)

### macOS
```bash
# यदि पहले से इंस्टॉल नहीं है तो Homebrew इंस्टॉल करें
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"

# Python और OpenEXR निर्भरताएँ इंस्टॉल करें
brew install python3 openexr

# रिपॉजिटरी क्लोन करें
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# वर्चुअल एनवायरनमेंट बनाएं और सक्रिय करें
python3 -m venv venv
source venv/bin/activate

# पायथन डिपेंडेंसीज़ इंस्टॉल करें
pip install -r requirements.txt
```

### लिनक्स (Ubuntu/Debian)
```bash
# सिस्टम डिपेंडेंसीज़ इंस्टॉल करें
sudo apt-get update
sudo apt-get install python3 python3-pip python3-venv openexr libopenexr-dev

# रिपॉजिटरी क्लोन करें
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# वर्चुअल एनवायरनमेंट बनाएँ और सक्रिय करें
python3 -m venv venv
source venv/bin/activate

# Python निर्भरताएँ स्थापित करें
pip install -r requirements.txt
```

### विंडोज़
```powershell
# Python को https://www.python.org/downloads/ से इंस्टॉल करें
# Git को https://git-scm.com/download/win से इंस्टॉल करें

# रिपॉजिटरी क्लोन करें
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# वर्चुअल एनवायरनमेंट बनाएं और सक्रिय करें
python -m venv venv
.\venv\Scripts\activate

# Python डिपेंडेंसीज़ इंस्टॉल करें
pip install -r requirements.txt
```

## 📋 आवश्यकताएँ
सभी आवश्यक Python पैकेज requirements.txt में सूचीबद्ध हैं:
- Pillow: इमेज प्रोसेसिंग लाइब्रेरी
- pillow-heif: HEIC फाइल सपोर्ट
- numpy: संख्यात्मक संचालन
- defusedxml: सुरक्षित XML पार्सिंग

सिस्टम डिपेंडेंसीज़ (पैकेज मैनेजर के माध्यम से इंस्टॉल):
- OpenEXR और OpenImageIO (oiiotool) EXR फाइल हैंडलिंग के लिए

## 💻 उपयोग
### गेन मैप एक्सट्रैक्शन
```bash
python gain_map_extract.py input.heic [--output-dir OUTPUT_DIR]
```

### HEIC से EXR रूपांतरण
```bash
python heic_to_exr.py input.heic [--output-dir OUTPUT_DIR]
```

### बैच प्रोसेसिंग
```bash
./merge_to_exr.sh input_directory output_directory
```

## 📁 आउटपुट फाइलें

### gain_map_extract.py आउटपुट:
- बेस इमेज: `{filename}_base.tiff`
- गेन मैप्स: `{filename}_gain_map_{id}.tiff`
- डेप्थ मैप्स: `{filename}_depth_{index}.tiff`
- मेटाडेटा: `{filename}_metadata.json`
### heic_to_exr.py आउटपुट:
- HDR EXR फ़ाइल: `{filename}.exr`

## 🔍 उन्नत उपयोग

### मेटाडेटा हैंडलिंग
- बाइनरी डेटा को base64 में एन्कोड किया जाता है
- ICC प्रोफाइल सुरक्षित रखे जाते हैं
- EXIF डेटा जहाँ संभव हो संरक्षित रहता है

### HDR प्रोसेसिंग
- गेन मैप्स को सही ढंग से स्केल किया जाता है
- लीनियर कलर स्पेस बनाए रखा जाता है
- EXR आउटपुट में पूर्ण डायनेमिक रेंज संरक्षित रहती है

## ⚠️ ज्ञात सीमाएँ
- कुछ HEIC वेरिएंट्स पूरी तरह से समर्थित नहीं हो सकते हैं
- डेप्थ मैप एक्सट्रैक्शन केवल समर्थित डिवाइसों तक ही सीमित है
- Windows में OpenEXR सपोर्ट के लिए अतिरिक्त कॉन्फ़िगरेशन की आवश्यकता हो सकती है
## 🤝 योगदान
योगदान का स्वागत है! कृपया स्वतंत्र रूप से एक पुल रिक्वेस्ट सबमिट करें।



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---