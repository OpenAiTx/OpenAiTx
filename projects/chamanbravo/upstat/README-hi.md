<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# अपस्टेट

> सरल और उपयोग में आसान स्वयं-होस्टेड स्थिति निगरानी उपकरण


![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 लाइव डेमो

इसे आज़माएँ।

डेमो सर्वर (स्थान: सिंगापुर): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

यूज़रनेम: `demo`
पासवर्ड: `demodemo`

## ⭐ विशेषताएँ

अभी और सुविधाओं की आवश्यकता है लेकिन फिलहाल...

- HTTP(s) के लिए अपटाइम मॉनिटरिंग
- स्थिति और विलंबता चार्ट
- Discord के माध्यम से सूचनाएँ
- 60-सेकंड के अंतराल
- आकर्षक, प्रतिक्रियाशील, तेज़ UI/UX
- बहु स्थिति पृष्ठ
- स्थिति पृष्ठों को विशिष्ट डोमेन से जोड़ें
- पिंग चार्ट
- प्रमाणपत्र जानकारी
- PWA
- Sqlite और Postgres डेटाबेस समर्थन

और दर्जनों छोटी सुविधाएँ जोड़ी जाएंगी।

## 🔧 स्थापना कैसे करें

### 🐳 डॉकर

Sqlite के लिए

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```

पोस्टग्रेस के लिए

```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat अब http://localhost:3000 पर चल रहा है

> [!IMPORTANT]
> डिप्लॉय करने से पहले पर्यावरण मानों को बदलना सुनिश्चित करें।

### 💪🏻 नॉन-डॉकर

आवश्यकताएँ:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- पोस्टग्रेस (वैकल्पिक)

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## टेक स्टैक

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 योगदान

मैं योगदान का स्वागत करता हूँ! योगदान ही ओपन सोर्स समुदाय को सीखने, प्रेरित होने और निर्माण करने के लिए एक अद्भुत स्थान बनाते हैं। आपके द्वारा किया गया कोई भी योगदान **बहुत सराहा जाएगा**।

यदि आपके पास कोई सुझाव है जिससे यह बेहतर हो सकता है, तो कृपया रिपॉजिटरी को फोर्क करें, बदलाव करें और पुल रिक्वेस्ट बनाएं। आप "enhancement" टैग के साथ एक इश्यू भी खोल सकते हैं।
प्रोजेक्ट को स्टार देना न भूलें! एक बार फिर धन्यवाद!

1. प्रोजेक्ट को फोर्क करें
2. अपनी फ़ीचर ब्रांच बनाएँ (`git checkout -b feature/AmazingFeature`)
3. अपने बदलाव कमिट करें (`git commit -m 'Add some AmazingFeature'`)
4. ब्रांच पर पुश करें (`git push origin feature/AmazingFeature`)
5. पुल रिक्वेस्ट खोलें

## योगदानकर्ता

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 लाइसेंस

यह प्रोजेक्ट [MIT License](https://opensource.org/license/mit/) के तहत लाइसेंस प्राप्त है।

## 🖼 अन्य स्क्रीनशॉट्स

मॉनिटर बनाएँ

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

मॉनिटर पृष्ठ

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---