<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/firemark.png" alt="firemark" width="200">
</p>

<h1 align="center">फायरमार्क</h1>

<p align="center">छवियों और पीडीएफ़ के लिए एक तेज़, सिंगल-बाइनरी वॉटरमार्किंग टूल। रस्ट में निर्मित।</p>


## अपने दस्तावेज़ों पर वॉटरमार्क क्यों लगाएँ?

हर साल, लाखों लोग पहचान धोखाधड़ी का शिकार होते हैं, जिसकी शुरुआत एक साधारण दस्तावेज़ के आदान-प्रदान से होती है।
एक आम स्थिति: आप किराए के लिए फ्लैट ढूंढ रहे हैं।
मकान मालिक — या कोई जो मकान मालिक बनकर पेश आ रहा है — आपसे आपकी आईडी, वेतन पर्ची, या कर नोटिस की प्रति मांगता है।
आप उन्हें बिना किसी निशान के भेज देते हैं। "मकान मालिक" गायब हो जाता है, और आपके दस्तावेज़ अब बैंक खाते खोलने, ऋण लेने, या आपके नाम पर पहचान बनाने के लिए उपयोग किए जाते हैं।

आपके द्वारा भेजे जाने वाले हर दस्तावेज़ पर वॉटरमार्क लगाना सबसे प्रभावी सुरक्षा है।
एक स्पष्ट ओवरले जिसमें लिखा है **"XYZ एजेंसी को भेजा गया — मार्च 2026 — केवल फ्लैट किराया आवेदन"** दस्तावेज़ को किसी अन्य उद्देश्य के लिए बेकार बना देता है। अगर यह लीक होता है, तो आपको तुरंत पता चल जाएगा कि यह कहाँ से आया।

firemark इसे बेहद आसान बनाता है: एक कमांड, कोई भी इमेज या पीडीएफ, 17 दृश्य शैलियाँ, क्रिप्टोग्राफिक फिलीग्रीन पैटर्न जो संपादन का विरोध करते हैं, और पूरे फोल्डर के लिए बैच प्रोसेसिंग।

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="Before and after watermarking" width="800">
  <br>
  <em>पहले और बाद में — एक कमांड, दस्तावेज़ अब ट्रेस करने योग्य और छेड़छाड़ के प्रमाण के साथ।</em>
</p>

## इंस्टॉल करें

[crates.io](https://crates.io/crates/firemark) से:







```bash
cargo install firemark
```
स्रोत से:


```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```
एक एकल ऑप्टिमाइज़्ड बाइनरी (~5 MB) उत्पन्न करता है।

## त्वरित प्रारंभ


```bash
# Watermark a single image
firemark photo_id.png -m "Flat rental — SCI Dupont — March 2026"

# Watermark a PDF
firemark tax_notice.pdf -m "CONFIDENTIAL" -s "Do not distribute"

# Watermark an entire folder recursively
firemark ./documents/ -R -m "Sent to Agency X" -t stamp

# Preview without writing files
firemark id_card.jpg -m "Draft" -n
```
आउटपुट डिफ़ॉल्ट रूप से इनपुट के साथ `{name}-watermarked.{ext}` के रूप में सहेजा जाता है।
`-o` का उपयोग करके एक स्पष्ट आउटपुट पथ सेट करें, या कस्टम उपसर्ग के लिए `-S` का उपयोग करें।

## वॉटरमार्क प्रकार

| फ्लैग | शैली | विवरण |
|---|---|---|
| `diagonal` | तिरछा ग्रिड | पूरे पृष्ठ पर दोहराया गया तिरछा पाठ (डिफ़ॉल्ट) |
| `stamp` | रबर स्टैम्प | डबल बॉर्डर के साथ बड़ा केंद्रित स्टैम्प |
| `stencil` | स्टेंसिल | पूरे पृष्ठ की सैन्य स्टेंसिल अक्षर |
| `typewriter` | टाइपराइटर | मोनोस्पेस्ड टाइपराइटर पाठ |
| `handwritten` | हस्ताक्षर | रेखांकित हस्तलिखित शैली का हस्ताक्षर |
| `redacted` | संपादन | पूरे पृष्ठ की काली संपादन पट्टियाँ |
| `badge` | शील्ड | सुरक्षा शील्ड/बैज प्रतीक |
| `ribbon` | रिबन | तिरछा कोने वाला रिबन बैनर |
| `seal` | मोहर | वृत्ताकार नोटरी-शैली की मोहर |
| `frame` | फ़्रेम | पूरे पृष्ठ की सजावटी सीमा |
| `tile` | टाइल | घना एकरूप पाठ ग्रिड |
| `mosaic` | मोज़ेक | बेतरतीब बिखरा हुआ पाठ |
| `weave` | वीव | इंटरलॉकिंग तिरछा वीव |
| `ghost` | घोस्ट | अल्ट्रा-सबटल उभरा हुआ पाठ |
| `watercolor` | जलरंग | नरम धुंधला वॉश प्रभाव |
| `noise` | नॉइज़ | पिक्सल नॉइज़ के साथ विक्षुब्ध पाठ |
| `halftone` | हाफ़टोन | हाफ़टोन डॉट ग्रिड के रूप में पाठ |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```
## सुरक्षा फिलिग्रेन

फायरमार्क क्रिप्टोग्राफिक फिलिग्रेन पैटर्न ओवरले करता है, जो बैंकनोट सुरक्षा विशेषताओं से प्रेरित हैं। ये सूक्ष्म ज्यामितीय पैटर्न इमेज एडिटरों से हटाना अत्यंत कठिन होते हैं।

| शैली | विवरण |
|---|---|
| `guilloche` | साइनसॉइडल वेव एनवेलप बैंड (डिफ़ॉल्ट) |
| `rosette` | स्पायरोग्राफ + कोने की गुलाब वक्र |
| `crosshatch` | महीन तिरछा डायमंड जाली |
| `border` | लहरदार नेस्टेड सुरक्षा बॉर्डर |
| `lissajous` | पैरामीट्रिक लिसाजू फिगर |
| `moire` | सन्निकट वृत्तीय हस्तक्षेप |
| `spiral` | आर्किमिडियन सर्पिल वॉर्टेक्स |
| `mesh` | षट्भुजाकार मधुमक्खी छत्ता ग्रिड |
| `plume` | सतह पर बिखरी प्रवाहित पंख जैसी वक्र |
| `constellation` | तारकीय नोड्स को महीन ज्यामितीय जाल से जोड़ा गया |
| `ripple` | यादृच्छिक स्रोतों से ओवरलैपिंग दीर्घवृत्तीय तरंग लहरें |
| `full` | सभी पैटर्न संयुक्त |
| `none` | फिलिग्रेन अक्षम करें |




```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```

## एआई-हटाने की सख्ती

हर रेंडर डिफ़ॉल्ट रूप से गैर-निर्धारित होता है। फायरमार्क सार्वभौमिक
पोस्ट-रेंडर पर्टर्बेशन (अल्फा जिटर, सब-पिक्सेल रंग शोर, किनारे पर माइक्रो-डॉट्स,
छिटपुट भूत पिक्सेल) और प्रति-रेंडरर रैंडमाइजेशन लागू करता है ताकि कोई दो आउटपुट
पिक्सल-एक समान न हों — भले ही सेटिंग्स समान हों। इससे एआई
विज़न मॉडल के लिए कोई पूर्वानुमेय पैटर्न सीखकर घटाना असंभव हो जाता है।

इसके अलावा, विरोधी प्रॉम्प्ट-इंजेक्शन स्ट्रिप्स डिफ़ॉल्ट रूप से एम्बेड की जाती हैं ताकि एआई वॉटरमार्क हटाने के टूल्स को भ्रमित किया जा सके। यदि आप दृश्य प्रॉम्प्ट टेक्स्ट नहीं चाहते, तो `--no-anti-ai` के साथ अक्षम करें:



```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## सामान्य विकल्प

```
-m, --main-text           Primary watermark text
-s, --secondary-text      Secondary text line
-t, --type                Watermark style (see table above)
-o, --output              Output file path
-S, --suffix              Custom output suffix (default: "watermarked")
-c, --color               Color — name or #RRGGBB (default: blue)
-O, --opacity             Opacity 0.0–1.0 (default: 0.5)
-r, --rotation            Angle in degrees (default: -45)
-p, --position            center, top-left, top-right, bottom-left, bottom-right, tile
-f, --font                Font name or path to .ttf/.otf
-I, --image               Overlay an image as watermark
    --qr-data             Embed a QR code with custom data
    --qr-code-position    QR code placement (default: center)
    --qr-code-size        QR code size in pixels (default: auto)
    --border              Draw a border around the watermark
    --shadow              Add a drop shadow
    --filigrane           Security filigrane style (default: guilloche)
    --no-anti-ai          Disable adversarial prompt injection (on by default)
```

70+ फ्लैग्स की पूरी सूची के लिए, [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md) देखें।

## PDF विकल्प

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## बैच प्रोसेसिंग

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```
पहले से वॉटरमार्क लगे फाइलें (जिनमें उपसर्ग मेल खाता है) को पुनः चलाने पर स्वचालित रूप से छोड़ दिया जाता है।

## कॉन्फ़िगरेशन फ़ाइल

फ्लैग्स को बार-बार दोहराने से बचने के लिए विकल्पों को एक TOML फाइल में सहेजें। पूर्ण उदाहरण के लिए देखें
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml)
जिसमें दो प्रीसेट्स हैं: **अत्यंत-सुरक्षित** (घना टाइलिंग, पूर्ण फिलिग्रेन, QR
ट्रेसबिलिटी, मेटाडेटा स्ट्रिपिंग) और **हल्का** (साधारण तिरछा पाठ, कोई अतिरिक्त नहीं)।



```toml
# Global defaults
main_text = "CONFIDENTIAL"
secondary_text = "{author} — {date}"
watermark_type = "diagonal"
color = "#1a3c6e"
opacity = 0.45
font_weight = "bold"
filigrane = "guilloche"
border = true

[preset.ultra-secure]
main_text = "CONFIDENTIAL — {author}"
watermark_type = "tile"
color = "#CC0000"
opacity = 0.6
filigrane = "full"
anti_ai = true
qr_data = "firemark://{author}/{timestamp}/{uuid}"
strip_metadata = true

[preset.light]
main_text = "COPY"
watermark_type = "diagonal"
color = "#555555"
opacity = 0.3
filigrane = "none"
anti_ai = false
```

```bash
firemark doc.pdf --config firemark.toml
firemark doc.pdf --config firemark.toml --preset ultra-secure
firemark doc.pdf --config firemark.toml --preset light
firemark doc.pdf --save-preset mypreset    # save current flags
firemark --list-presets                     # list available presets
```
## प्रारूप समर्थन

| प्रारूप | इनपुट | आउटपुट |
|---|---|---|
| PNG | हाँ | हाँ |
| JPEG | हाँ | हाँ |
| PDF | हाँ | हाँ |
| WebP | हाँ | हाँ |
| TIFF | हाँ | हाँ |

क्रॉस-प्रारूप रूपांतरण समर्थित है (जैसे `firemark photo.webp -o out.pdf`)।

## लाइसेंस

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---