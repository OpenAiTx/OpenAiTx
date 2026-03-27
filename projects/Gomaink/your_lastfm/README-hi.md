<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Status](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# आपका LastFM

एक कंटेनरीकृत Node.js एप्लिकेशन जो **Last.fm** से स्क्रॉबल्स सिंक्रनाइज़ करता है, उन्हें लोकल **SQLite** डेटाबेस में संग्रहीत करता है, और एक वेब डैशबोर्ड प्रदान करता है।

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />

---

## परियोजना

**Your LastFM** एक Node.js एप्लिकेशन है जिसे **स्वचालित रूप से Last.fm से संगीत स्क्रॉबल्स सिंक्रोनाइज़ करने** के लिए डिज़ाइन किया गया है। यह आपके सुनने के इतिहास को एक स्थानीय SQLite डेटाबेस में संरक्षित करता है और डेटा विज़ुअलाइज़ेशन के लिए एक वेब इंटरफ़ेस उपलब्ध कराता है।

यह परियोजना पूरी तरह से **Docker** के साथ कंटेनराइज़्ड है, जिसमें डेटाबेस इनिशियलाइज़ेशन और अनुक्रमिक निष्पादन को संभालने के लिए एक स्वचालित एंट्रीपॉइंट है (पहले सिंकिंग, फिर वेब एपीआई लॉन्च)। यह कंटेनर के अंदर वेब सेवा को सक्रिय और लचीला बनाए रखने के लिए **PM2** प्रोसेस मैनेजर का भी उपयोग करता है।

## विशेषताएँ
### इंटरएक्टिव वेब डैशबोर्ड

- आपके संगीत गतिविधि को विज़ुअलाइज़ करने के लिए स्वच्छ, आधुनिक वेब इंटरफ़ेस।

### स्वचालित Last.fm स्क्रॉबल सिंक्रोनाइज़ेशन

- समय-समय पर Last.fm से आपके सुनने के इतिहास (स्क्रॉबल्स) को प्राप्त करता है और सहेजता है।
- आपके डेटा को बिना किसी मैन्युअल हस्तक्षेप के हमेशा अपडेट रखता है।

### स्थानीय संगीत इतिहास डेटाबेस

- सभी स्क्रॉबल्स को एक स्थानीय SQLite डेटाबेस में सहेजता है।
- तेज़ क्वेरी और ऐतिहासिक डेटा तक ऑफलाइन पहुँच की अनुमति देता है।

### हालिया स्क्रॉबल्स दृश्य

- आपके सबसे हाल के ट्रैक्स दिखाता है।
- ट्रैक, एल्बम और कलाकारों के लिए स्मार्ट इमेज फॉलबैक लॉजिक।

### मित्र तुलना (संगतता दृश्य)

- अपने Last.fm मित्रों के साथ अपने संगीत स्वाद की तुलना करें।
- संगतता स्तर दिखाता है (बहुत कम → सुपर)।
- सामान्य शीर्ष कलाकार, एल्बम और ट्रैक दिखाता है।
- वास्तविक सुनने के डेटा के आधार पर संगतता की गणना और सामान्यीकरण करता है।

### साझा करने योग्य संगीत कार्ड

- आपके सुनने के डेटा के आधार पर डायनामिक इमेज बनाएं।
- फ़ीड पोस्ट और इंस्टाग्राम स्टोरीज़ (9:16) के लिए अनुकूलित लेआउट।

- सर्वर-साइड छवि रेंडरिंग के लिए node-canvas का उपयोग करके बनाया गया।

## आवश्यकताएँ

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## स्थापना

### एक `.env` फ़ाइल बनाएँ

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: अपना API कुंजी प्राप्त करने के लिए [यहाँ](https://www.last.fm/api/account/create) एक API खाता बनाएँ।

### डॉकर कम्पोज़

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

टर्मिनल पर:
`docker compose up -d`

फिर एक्सेस करें:
```
http://localhost:1533
```
(या `localhost` को अपने सर्वर IP से बदलें)

## लाइसेंस

यह परियोजना MIT लाइसेंस के अंतर्गत लाइसेंस प्राप्त है।



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---