
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

# नथिंग बट निक्स

**अपने GitHub Actions रनर को [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ पावरहाउस में बदलें, पहले से इंस्टॉल बेमतलब सॉफ़्टवेयर को निर्दयता से हटाकर।**

GitHub Actions रनर पर Nix के लिए बहुत ही कम डिस्क स्पेस उपलब्ध होती है - केवल लगभग ~20GB।
*Nothing but Nix* **अनावश्यक सॉफ़्टवेयर को बेरहमी से हटाता है**, जिससे आपको अपने Nix स्टोर के लिए **65GB से 130GB** तक की जगह मिलती है! 💪

## उपयोग 🔧

अपने वर्कफ़्लो में Nix इंस्टॉल करने से **पहले** इस एक्शन को जोड़ें:

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

- केवल आधिकारिक **Ubuntu** GitHub Actions रनर का समर्थन करता है
- **Nix** स्थापित होने से **पहले** चलना चाहिए

## समस्या: Nix को फलने-फूलने के लिए जगह बनाना 🌱

मानक GitHub Actions रनर *"अनावश्यक सॉफ़्टवेयर"* से भरे हुए हैं, जिनकी आपको Nix वर्कफ़्लो में कभी ज़रूरत नहीं पड़ेगी:

- 🌍 वेब ब्राउज़र। बहुत सारे। सब चाहिए!
- 🐳 Docker इमेजें जो बहुमूल्य डिस्क स्थान के गीगाबाइट्स खा जाती हैं
- 💻 अनावश्यक भाषा रनटाइम (.NET, Ruby, PHP, Java...)
- 📦 पैकेज मैनेजर जो डिजिटल धूल जमा कर रहे हैं
- 📚 डाक्यूमेंटेशन जिसे कोई कभी नहीं पढ़ेगा

इस अनावश्यकता के कारण आपके Nix स्टोर के लिए केवल ~20GB बचता है - जो गंभीर Nix बिल्ड्स के लिए मुश्किल से पर्याप्त है! 😞

## समाधान: केवल Nix ️❄️

**केवल Nix** GitHub Actions रनर पर कठोर दृष्टिकोण अपनाता है और दो-चरणीय हमले के माध्यम से डिस्क स्थान को निर्दयता से पुनः प्राप्त करता है:

1. **प्रारंभिक कटौती:** तुरंत `/nix` वॉल्यूम (~65GB) बनाता है, `/mnt` से मुक्त स्थान का दावा करके
2. **पृष्ठभूमि विनाश:** जब आपका वर्कफ़्लो चलता रहता है, हम अनावश्यक सॉफ़्टवेयर को निर्दयता से हटा देते हैं ताकि आपका `/nix` वॉल्यूम ~130GB तक बढ़ सके
   - वेब ब्राउज़र? नहीं ⛔
   - Docker इमेजें? चली गईं 🗑️
   - भाषा रनटाइम्स? नष्ट 💥
   - पैकेज मैनेजर? ध्वस्त 💣
   - डाक्यूमेंटेशन? वाष्पीकृत ️👻

फाइल सिस्टम सफाई `rmz` ( [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) प्रोजेक्ट से) द्वारा संचालित है - यह `rm` का उच्च-प्रदर्शन विकल्प है जो स्थान पुनः प्राप्ति को बहुत तेज़ बना देता है! ⚡
   - मानक `rm` की तुलना में दस गुना तेज़
   - अधिकतम दक्षता के लिए डिलीशन को समानांतर प्रोसेस करता है
   - **मिनटों की बजाय कुछ सेकंड में डिस्क स्थान पुनः प्राप्त करता है!** ️⏱️

अंतिम परिणाम? एक GitHub Actions रनर जिसमें **65GB से 130GB** तक Nix के लिए तैयार स्थान है! 😁

### डायनामिक वॉल्यूम वृद्धि

अन्य समाधानों के विपरीत, **केवल Nix** आपके `/nix` वॉल्यूम को डायनामिक रूप से बढ़ाता है:

1. **प्रारंभिक वॉल्यूम निर्माण (1-10 सेकंड):** (*Hatchet Protocol पर निर्भर*)
   - `/mnt` पर उपलब्ध मुक्त स्थान से लूप डिवाइस बनाता है
   - RAID0 कॉन्फ़िगरेशन में BTRFS फ़ाइल सिस्टम सेट करता है
   - कम्प्रेशन और प्रदर्शन ट्यूनिंग के साथ माउंट करता है
   - 65GB का `/nix` तुरंत उपलब्ध कराता है, सफाई शुरू होने से पहले ही

2. **पृष्ठभूमि विस्तार (30-180 सेकंड):** (*Hatchet Protocol पर निर्भर*)
   - सफाई संचालन करता है
   - जैसे-जैसे अनावश्यक सॉफ़्टवेयर हटता है, नये मुक्त स्थान की निगरानी करता है
   - `/nix` वॉल्यूम में विस्तार डिस्क को डायनामिक रूप से जोड़ता है
   - फाइल सिस्टम को नया स्थान शामिल करने के लिए रिबैलेंस करता है

`/nix` वॉल्यूम अपने-आप **वर्कफ़्लो निष्पादन के दौरान बढ़ता है** 🎩🪄

### अपना हथियार चुनें: Hatchet Protocol 🪓

`hatchet-protocol` इनपुट के साथ विनाश का स्तर नियंत्रित करें 💥:

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

अब जाएँ और उस शानदार Nix स्टोर स्पेस के साथ कुछ अद्भुत बनाएं! ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---