# Spegel – AI के माध्यम से वेब को परावर्तित करें

स्वचालित रूप से वेबसाइटों को फिर से लिखता है और टर्मिनल में देखने के लिए अनुकूलित मार्कडाउन में बदलता है।
परिचय ब्लॉग पोस्ट [यहाँ पढ़ें](https://simedw.com/2025/06/23/introducing-spegel/)

यह एक प्रूफ-ऑफ-कॉन्सेप्ट है, बग्स की संभावना है लेकिन आप बेझिझक कोई इश्यू या पुल रिक्वेस्ट उठा सकते हैं।

##  स्क्रीनशॉट
कभी-कभी आप केवल एक रेसिपी तक पहुँचने के लिए किसी की जीवन कहानी नहीं पढ़ना चाहते
![Recipe Example](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## इंस्टॉलेशन

Python 3.11+ आवश्यक है

```
pip install spegel
```
या रिपॉजिटरी को क्लोन करके एडिटेबल मोड में इंस्टॉल करें

```bash
# क्लोन करें और डिरेक्टरी में जाएं
$ git clone <repo-url>
$ cd spegel

# डिपेंडेंसीज़ और CLI इंस्टॉल करें
$ pip install -e .
```

## API कुंजियाँ
Spegel वर्तमान में केवल Gemini 2.5 Flash को सपोर्ट करता है, इसे उपयोग करने के लिए आपको अपना API key env में देना होगा

```
GEMINI_API_KEY=...
```


## उपयोग

### ब्राउज़र लॉन्च करें

```bash
spegel                # वेलकम स्क्रीन के साथ प्रारंभ करें
spegel bbc.com        # तुरंत एक URL खोलें
```

या, समकक्ष रूप से:

```bash
python -m spegel      # वेलकम स्क्रीन के साथ प्रारंभ करें
python -m spegel bbc.com
```

### बुनियादी नियंत्रण
- `/`         – URL इनपुट खोलें
- `Tab`/`Shift+Tab` – लिंक्स में घूमना
- `Enter`     – चयनित लिंक खोलें
- `e`         – वर्तमान दृश्य के लिए LLM प्रॉम्प्ट संपादित करें
- `b`         – पीछे जाएं
- `q`         – बाहर निकलें

## सेटिंग्स संपादन

Spegel सेटिंग्स को TOML कॉन्फ़िग फाइल से लोड करता है। आप दृश्य, प्रॉम्प्ट्स और UI विकल्पों को अनुकूलित कर सकते हैं।

**कॉन्फ़िग फाइल खोज क्रम:**
1. `./.spegel.toml` (वर्तमान डिरेक्टरी)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

सेटिंग्स संपादित करने के लिए:
1. उदाहरण कॉन्फ़िग कॉपी करें:
   ```bash
   cp example_config.toml .spegel.toml
   # या बनाएँ ~/.spegel.toml
   ```
2. अपनी पसंदीदा एडिटर में `.spegel.toml` संपादित करें।

उदाहरण स्निपेट:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transform this webpage into the perfect terminal browsing experience! ..."
```

---

अधिक जानकारी के लिए, कोड देखें या कोई इश्यू खोलें!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---