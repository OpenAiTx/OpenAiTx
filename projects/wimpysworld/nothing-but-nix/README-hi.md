
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# कुछ नहीं बस निक्स

**अपने GitHub Actions रनर को एक [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ पावरहाउस में बदलें, पहले से इंस्टॉल किए गए अनावश्यक सॉफ़्टवेयर को बेरहमी से हटाकर।**

GitHub Actions रनर में Nix के लिए बहुत कम डिस्क स्पेस होती है - सिर्फ ~20GB।
*कुछ नहीं बस निक्स* **अनावश्यक सॉफ़्टवेयर को पूरी तरह से हटा देता है**, जिससे आपको अपने Nix स्टोर के लिए **65GB से 130GB** तक जगह मिलती है! 💪

## उपयोग कैसे करें 🔧

इस क्रिया को अपने वर्कफ़्लो में Nix इंस्टॉल करने से **पहले** जोड़ें:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### आवश्यकताएँ ️✔️

- केवल आधिकारिक **Ubuntu** GitHub Actions रनर को ही समर्थन करता है
- **Nix** स्थापित होने से **पहले** चलना चाहिए
- **macOS/Darwin रनर:** यदि इसे macOS पर चलाया जाए तो यह क्रियावली एक चेतावनी के साथ शालीनता से छोड़ दी जाएगी। macOS रनर पहले ही Nix के लिए पर्याप्त स्थान प्रदान करते हैं और इस क्रियावली की आवश्यकता नहीं है
- **Windows रनर:** यदि इसे Windows पर चलाया जाए तो यह क्रियावली एक चेतावनी के साथ शालीनता से छोड़ दी जाएगी। Windows रनर में फाइलसिस्टम लेआउट और बाधाएँ भिन्न होती हैं

## समस्या: Nix के विकास के लिए जगह बनाना 🌱

मानक GitHub Actions रनर *"अनावश्यक सॉफ़्टवेयर"* से भरे होते हैं जिनका आप Nix वर्कफ़्लो में कभी उपयोग नहीं करेंगे:

- 🌍 वेब ब्राउज़र। बहुत सारे। सब चाहिए!
- 🐳 Docker इमेजेज जो बहुमूल्य डिस्क स्पेस के गीगाबाइट्स घेरती हैं
- 💻 अनावश्यक लैंग्वेज रनटाइम्स (.NET, Ruby, PHP, Java...)
- 📦 पैकेज मैनेजर जो डिजिटल धूल जमा कर रहे हैं
- 📚 डाक्यूमेंटेशन जिसे कोई कभी नहीं पढ़ेगा

इस अनावश्यकता के कारण आपके Nix स्टोर के लिए केवल ~20GB बचता है - गंभीर Nix बिल्ड के लिए मुश्किल से ही पर्याप्त! 😞

## समाधान: केवल Nix ️❄️

**केवल Nix** GitHub Actions रनर पर कठोर दृष्टिकोण अपनाता है और दो-चरणीय हमले के ज़रिए डिस्क स्पेस पुनः प्राप्त करता है:

1. **प्रारंभिक कटौती:** `/mnt` से खाली स्थान का दावा कर तुरंत एक बड़ा `/nix` वॉल्यूम (~65GB) बनाता है
2. **पृष्ठभूमि सफाया:** जब आपका वर्कफ़्लो चलता रहता है, हम अनावश्यक सॉफ़्टवेयर को निर्ममता से हटाते हैं ताकि आपका `/nix` वॉल्यूम ~130GB तक बढ़ सके
   - वेब ब्राउज़र? नहीं ⛔
   - Docker इमेजेज? हट गईं 🗑️
   - लैंग्वेज रनटाइम्स? नष्ट 💥
   - पैकेज मैनेजर? विनष्ट 💣
   - डाक्यूमेंटेशन? वाष्पीकृत ️👻

फाइल सिस्टम सफाई को `rmz` ( [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) प्रोजेक्ट से) द्वारा संचालित किया जाता है - `rm` का एक उच्च-प्रदर्शन विकल्प जो स्पेस रिक्लेमेशन को बेहद तेज बनाता है! ⚡
   - मानक `rm` की तुलना में कई गुना तेज
   - अधिकतम दक्षता के लिए डिलीशन को समानांतर संसाधित करता है
   - **डिस्क स्पेस को मिनटों के बजाय सेकंडों में रिक्लेम करता है!** ️⏱️

अंतिम परिणाम? एक GitHub Actions रनर जिसमें **65GB से 130GB** तक Nix के लिए तैयार स्थान है! 😁

### डायनामिक वॉल्यूम ग्रोथ
अन्य समाधानों के विपरीत, **Nothing but Nix** आपके `/nix` वॉल्यूम को गतिशील रूप से बढ़ाता है:

1. **प्रारंभिक वॉल्यूम निर्माण (1-10 सेकंड):** (*Hatchet Protocol पर निर्भर*)
   - `/mnt` पर खाली स्थान से एक लूप डिवाइस बनाता है
   - RAID0 कॉन्फ़िगरेशन में BTRFS फाइल सिस्टम सेटअप करता है
   - कंप्रेशन और प्रदर्शन ट्यूनिंग के साथ माउंट करता है
   - 65GB का `/nix` तुरंत प्रदान करता है, यहां तक कि पर्जिंग शुरू होने से पहले भी

2. **पृष्ठभूमि विस्तार (30-180 सेकंड):** (*Hatchet Protocol पर निर्भर*)
   - पर्जिंग ऑपरेशन्स निष्पादित करता है
   - जैसे ही फालतू डेटा हटता है, नए मुक्त स्थान की निगरानी करता है
   - `/nix` वॉल्यूम में विस्तार के लिए एक नया डिस्क गतिशील रूप से जोड़ता है
   - नई जगह को शामिल करने के लिए फाइल सिस्टम को री-बैलेंस करता है

`/nix` वॉल्यूम स्वचालित रूप से **वर्कफ़्लो निष्पादन के दौरान बढ़ता है** 🎩🪄

### अपना हथियार चुनें: The Hatchet Protocol 🪓

`hatchet-protocol` इनपुट के साथ विनाश के स्तर को नियंत्रित करें 💥:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### प्रोटोकॉल तुलना ⚖️

| प्रोटोकॉल | `/nix` | विवरण                                            | apt शुद्धिकरण | docker शुद्धिकरण | snap शुद्धिकरण | शुद्ध की गई फाइल सिस्टम्स     |
|-----------|--------|--------------------------------------------------|---------------|------------------|----------------|------------------------------|
| Holster   | ~65GB  | कुल्हाड़ी म्यान में, `/mnt` से जगह का उपयोग      | नहीं          | नहीं             | नहीं           | कोई नहीं                     |
| Carve     | ~85GB  | `/` और `/mnt` से फ्री स्पेस को मिलाएं और बनाएं   | नहीं          | नहीं             | नहीं           | कोई नहीं                     |
| Cleave    | ~115GB | बड़े पैकेजों को निर्णायक रूप से हटाएं            | न्यूनतम       | हाँ              | हाँ            | `/opt` और `/usr/local`       |
| Rampage   | ~130GB | हर तरह के फालतू को निर्दयी रूप से हटाना         | आक्रामक       | हाँ              | हाँ            | मुहाहा! 🔥🌎                  |

सावधानीपूर्वक चुनें:
- **Holster** जब रनर के सभी टूल्स पूरी तरह काम करने चाहिएँ
- **Carve** रनर टूलिंग को सुरक्षित रखते हुए Nix के लिए सारी फ्री जगह चाहिए
- **Cleave** (*डिफ़ॉल्ट*) संतुलित जगह और कार्यक्षमता के लिए
- **Rampage** जब अधिकतम Nix जगह चाहिए और जो टूटे उसकी चिंता नहीं `#nix-is-life`

### तबाही का गवाह बनें 🩸

डिफ़ॉल्ट रूप से, शुद्धिकरण प्रक्रिया पृष्ठभूमि में चुपचाप चलती है जबकि आपका वर्कफ़्लो जारी रहता है। लेकिन यदि आप वास्तविक समय में कत्लेआम देखना चाहते हैं:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### सुरक्षित आश्रयों को अनुकूलित करें 🛡️

कस्टम सुरक्षित आश्रय आकारों के साथ Nix स्टोर की ज़मीन पर कब्ज़ा करने से कितनी जगह बचानी है, इसे नियंत्रित करें:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```
ये सुरक्षित क्षेत्र यह निर्धारित करते हैं कि स्पेस रिक्लेमेशन के दौरान कितनी जगह (MB में) दया करके छोड़ी जाएगी:
- डिफ़ॉल्ट `root-safe-haven` है 2048MB (2GB)
- डिफ़ॉल्ट `mnt-safe-haven` है 1024MB (1GB)

अगर आपको अपनी फाइल सिस्टम्स पर ज्यादा जगह चाहिए तो इन मानों को बढ़ाएँ, या फिर बिना दया दिखाए इन्हें घटाएँ! 😈

### /nix की यूज़र ओनरशिप दें (Nix अनुमति आदेश) 🧑‍⚖️

कुछ Nix इंस्टॉलर या कॉन्फ़िगरेशन अपेक्षा करते हैं कि `/nix` डायरेक्टरी वर्तमान यूज़र द्वारा लिखने योग्य हो। डिफ़ॉल्ट रूप से, `/nix` का मालिक root होता है। अगर आपको यूज़र ओनरशिप चाहिए (जैसे कि कुछ Nix इंस्टॉलर स्क्रिप्ट्स के लिए जो `/nix` के भीतर सभी ऑपरेशनों के लिए `sudo` का उपयोग नहीं करती हैं), तो आप `nix-permission-edict` को सक्षम कर सकते हैं:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```
जब `nix-permission-edict` को `true` पर सेट किया जाता है, तो यह क्रिया `/nix` को माउंट करने के बाद `sudo chown -R "$(id --user)":"$(id --group)" /nix` चलाएगी।

### Nix को /nix/build उपयोग करने के लिए कॉन्फ़िगर करें

यह क्रिया Nix डेरिवेशन बिल्ड्स के लिए रिक्लेम की गई स्पेस का उपयोग करने हेतु `/nix/build` बनाती है। अपने Nix कॉन्फ़िगरेशन में `build-dir` जोड़ें:


```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

या DeterminateSystems के साथ:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```
यह Nix को सिस्टम की डिफ़ॉल्ट टेम्परेरी डायरेक्टरी के बजाय बड़े BTRFS वॉल्यूम पर बिल्ड करने का निर्देश देता है।

## समस्या निवारण 🔍

### बड़े बिल्ड के दौरान "डिवाइस पर कोई जगह नहीं बची"

यदि आपका बिल्ड केवल Nix का उपयोग करने के बावजूद भी स्पेस खत्म कर देता है, तो संभावना है कि बैकग्राउंड पर्जिंग आपके बिल्ड के उपलब्ध स्पेस को उपयोग करने से पहले पूरी नहीं हुई है। यह आमतौर पर इनको प्रभावित करता है:

- NixOS VM टेस्ट जो बड़े डिस्क इमेज बनाते हैं
- बिल्ड्स जिनमें कई डिपेंडेंसीज़ हैं जो कैश नहीं हुई हैं
- Rust टूलचेन और अन्य बड़े संकलन

**समाधान:** सिंक्रोनस पर्जिंग को मजबूर करने के लिए `witness-carnage: true` का उपयोग करें। यह सुनिश्चित करता है कि सारा स्पेस *आपके बिल्ड शुरू होने से पहले* रिक्लेम हो जाए:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```
यह आपके वर्कफ़्लो सेटअप में 30-180 सेकंड जोड़ता है, लेकिन यह सुनिश्चित करता है कि जब आपका बिल्ड शुरू हो तब अधिकतम स्थान उपलब्ध हो।

अब उस शानदार Nix स्टोर स्पेस के साथ कुछ अद्भुत बनाएं! ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---