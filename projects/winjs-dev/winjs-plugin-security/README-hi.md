<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# winjs-plugin-security

WinJS प्रोजेक्ट के लिए सुरक्षा बढ़ाने वाला एक प्लगइन, जो मुख्य रूप से SRI (Subresource Integrity) गुण उत्पन्न करने के लिए प्रयोग होता है।

## फ़ीचर विशेषताएँ

- HTML फाइलों में `<script>` और `<link>` टैग्स के लिए अपने आप SRI गुण उत्पन्न करता है
- SHA-256, SHA-384, SHA-512 हैश एल्गोरिद्म का समर्थन करता है (कनफ़िगर करने योग्य)
- SRI के सही काम के लिए अपने आप `crossorigin="anonymous"` गुण जोड़ता है
- केवल प्रोडक्शन एनवायरनमेंट में सक्रिय, डेवेलपमेंट एनवायरनमेंट में अपने आप छोड़ देता है

## इंस्टॉलेशन


```bash
pnpm add @winner-fed/plugin-security
```
## उपयोग विधि

अपने `.winrc.ts` कॉन्फ़िगरेशन फ़ाइल में प्लगइन कॉन्फ़िगरेशन जोड़ें:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## कॉन्फ़िगरेशन विकल्प

### `sri`

- **प्रकार**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **डिफ़ॉल्ट मान**: मैन्युअली सेट करना आवश्यक है
- **विवरण**: क्या SRI (सब-रिसोर्स इंटीग्रिटी) फ़ीचर सक्षम करना है, तथा वैकल्पिक हैश एल्गोरिद्म कॉन्फ़िगरेशन

जब इसे `true` या `{}` पर सेट किया जाता है, तो प्लगइन:

1. बिल्ड के बाद बने HTML फ़ाइलों को स्कैन करता है
2. जिन `<script>` टैग्स में `src` गुण है, उनमें `integrity` गुण जोड़ता है
3. जिन `<link>` टैग्स में `href` गुण है, उनमें `integrity` गुण जोड़ता है
4. अपने-आप `crossorigin="anonymous"` गुण जोड़ता है (यदि वह मौजूद नहीं है)

आप ऑब्जेक्ट के रूप में हैश एल्गोरिद्म भी निर्दिष्ट कर सकते हैं:


```typescript
security: {
  sri: {
    algorithm: 'sha512' // 可选 'sha256' | 'sha384' | 'sha512'，默认 'sha512'
  }
}
```

## 示例

### 输入 HTML

```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css">
</head>
<body>
  <script src="/assets/app.js"></script>
</body>
</html>
```
### आउटपुट HTML (SRI सक्षम होने के बाद)


```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css" integrity="sha512-ABC123..." crossorigin="anonymous">
</head>
<body>
  <script src="/assets/app.js" integrity="sha512-XYZ789..." crossorigin="anonymous"></script>
</body>
</html>
```
## सुरक्षा निर्देश

SRI (सब-रिसोर्स इंटीग्रिटी) एक सुरक्षा सुविधा है, जो ब्राउज़र को प्राप्त संसाधनों (जैसे कि CDN से प्राप्त संसाधन) की सत्यता की पुष्टि करने की अनुमति देती है कि वे दुर्भावनापूर्ण रूप से संशोधित नहीं किए गए हैं। जब ब्राउज़र संसाधन लोड करता है, तो वह संसाधन का हैश मान निकालता है और उसे `integrity` गुण में निर्दिष्ट हैश मान से तुलना करता है। यदि हैश मान मेल नहीं खाते, तो ब्राउज़र उस संसाधन को लोड करने से इनकार कर देता है।

`<script>` टैग के लिए, परिणामस्वरूप उसमें लिखी गई कोड निष्पादित नहीं होगी; CSS लिंक्स के मामले में, उसमें दी गई शैलियाँ लोड नहीं होंगी।

SRI के बारे में अधिक जानकारी के लिए [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity) देखें।

## ध्यान देने योग्य बातें

1. यह प्लगइन केवल प्रोडक्शन बिल्ड के समय प्रभावी होता है, डेवलपमेंट एनवायरनमेंट में यह स्वतः बायपास हो जाएगा
2. यह सुनिश्चित करें कि संसाधन फ़ाइलें बिल्ड आउटपुट डायरेक्टरी में उपलब्ध हों
3. `integrity` गुण को सही तरीके से काम करने के लिए `crossorigin` गुण के साथ प्रयोग करना आवश्यक है

## लाइसेंस

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---