<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


![serajs (2)](https://github.com/user-attachments/assets/7ccff260-491d-420b-8e22-4579f9bad50a)

## 📖 **परिचय**

> 📚 परियोजनाएँ  —  seraJs

🔗(पोर्टफोलियो)[https://seraprogrammer.github.io/seraportfolio/] 

🔗(डेमो ब्लॉग)[https://seraprogrammer.github.io/serajsBlogsDemo/] 


```bash
npx degit sera-js/template my-app
cd my-app
```
**SeraJS** एक हल्का-फुल्का, **सिग्नल-आधारित प्रतिक्रियाशील जावास्क्रिप्ट लाइब्रेरी** है  
डायनामिक यूज़र इंटरफेस बनाने के लिए।

सिर्फ **969 बाइट्स gzipped** और केवल **135 लाइनों** के कोड के साथ, यह एक बेहद हल्की प्रतिक्रियाशील UI लाइब्रेरी है — जो न्यूनतम ओवरहेड में शक्तिशाली रिएक्टिविटी प्रदान करती है।

> ⚡️ _SeraJS **मिनिमलिज़्म** और **परफॉर्मेंस** पर ध्यान केंद्रित करता है  
> बिना डेवलपर अनुभव से समझौता किए।_


*बंडल साइज़ तुलना (मिनिफाइड + गज़िप्ड)*

| लाइब्रेरी | साइज़ (gzipped) | बिल्ड स्टेप आवश्यक | मुख्य उद्देश्य | मुख्य फ़ीचर्स |
|-----------|----------------|-------------------|----------------|----------------|
| SeraJS | 1.25kb | वैकल्पिक 😎 | प्रतिक्रियाशील UI | 135 लाइनों का कोड, अत्यंत हल्का |
| React | ~40kb | हाँ | UI कंपोनेंट्स | वर्चुअल DOM, कंपोनेंट आधारित आर्किटेक्चर, JSX |
| Vue | ~33kb | वैकल्पिक | प्रोग्रेसिव फ्रेमवर्क | प्रतिक्रियाशील डेटा बाइंडिंग, कंपोनेंट सिस्टम, सिंगल-फाइल कंपोनेंट्स |
| Solid.js | ~7kb | हाँ | प्रतिक्रियाशील UI | बिना वर्चुअल DOM, कंपाइल्ड टेम्पलेट्स, सूक्ष्म रिएक्टिविटी |
| Alpine.js | ~7.1kb | नहीं | हल्का फ्रेमवर्क | न्यूनतम DOM मैनिपुलेशन, घोषणात्मक सिंटैक्स, मौजूदा HTML के साथ काम करता है |
| Preact | ~4kb | हाँ | React विकल्प | React के साथ API संगत, छोटा आकार, तेज प्रदर्शन |
| htmx | ~14kb | नहीं | AJAX संवर्द्धन | AJAX के लिए HTML एट्रिब्यूट्स, न्यूनतम जावास्क्रिप्ट, सर्वर-साइड रेंडरिंग अनुकूल |



---

## ⚙️ **मूल अवधारणाएँ**

### 🔄 **सिग्नल-आधारित प्रतिक्रियाशीलता**

SeraJS एक **सिग्नल-आधारित प्रतिक्रियाशील प्रणाली** का उपयोग करता है,  
स्टेट मैनेजमेंट का एक आधुनिक तरीका जो कुशल अपडेट्स को सक्षम बनाता है:

- 🧠 **सिग्नल्स**  
  स्व-निहित प्रतिक्रियाशील मान जो बदलने पर सब्सक्राइबर को सूचित करते हैं।

- 🌀 **इफेक्ट्स**  
  वे फ़ंक्शन्स जो स्वतः पुनः-निष्पादित होते हैं जब उनके डिपेंडेंसी (सिग्नल्स)  
  बदलते हैं।

- 🧭 **मेमो**  
  React के `useMemo` जैसा एक मेमोराइज़ेशन हेल्पर, प्रतिक्रियाशील डिपेंडेंसी  
  के आधार पर किसी गणना के परिणाम को कैश करने के लिए, ताकि अनावश्यक  
  पुनर्गणनाएँ टाली जा सकें।

- 🔬 **सूक्ष्म अपडेट्स**  
  केवल वही DOM एलिमेंट्स अपडेट होते हैं जो स्टेट परिवर्तन से प्रभावित होते हैं,  
  जिससे न्यूनतम री-रेंडरिंग और उच्च प्रदर्शन मिलता है।

> 💡 **SeraJS को सहज, तेज और किसी भी  
> प्रोजेक्ट में आसानी से एकीकृत करने योग्य बनाने के लिए डिज़ाइन किया गया है —  
> जिससे यह आधुनिक फ्रंटएंड डेवलपमेंट के लिए एक परिपूर्ण विकल्प बन जाता है।**


## SeraJS क्यों?

SeraJS, React, Solid और Lit जैसी लाइब्रेरियों के सर्वोत्तम हिस्सों को एक साथ लाता है —  
परिचित पैटर्न को एक नए, न्यूनतम दृष्टिकोण के साथ मिलाते हुए।

सिर्फ 1.25KB gzipped और केवल 135 लाइनों के कोड के साथ, यह प्रतिक्रियाशील UI लाइब्रेरी  
अत्यंत हल्की रहते हुए भी शक्तिशाली रिएक्टिविटी देती है।

चाहे आप बिल्ड सिस्टम चाहते हों या बिना बिल्ड वर्कफ़्लो पसंद करते हों, SeraJS आपके लिए तैयार है।  
यह आपकी डेव स्टाइल के अनुसार लचीला है — जैसे *आप* चाहें, वैसे इस्तेमाल करें।


## 🌱 **Sera.js बेसिक उदाहरण**

Sera.js का उपयोग करते हुए Hello World संदेश दिखाने वाला एक न्यूनतम उदाहरण।

### 📄 App.jsx
```jsx
import { h } from "serajs";

export default function App() {
  return (
    <h1>Hello world</h1>
  );
}
```
## कोई बिल्ड नहीं, कोई निर्भरता नहीं


```html
<!DOCTYPE html>
<html>
  <head>
    <title>Sera js 😎</title>
  </head>
  <body>
    <script type="module">
      import { h, setSignal, setEffect } from "//unpkg.com/serajs";

      function Hello() {
        const [count, setCount] = setSignal(0);

        setEffect(() => {
          console.log(count());
        });

        return h(
          "div",
          null,
          h("h1", null, "Hello World!"),
          h("p", { style: { color: "red" } }, "Do you Like Serajs?"),
          h("h1", null, () => `Count: ${count()}`),
          h(
            "button",
            { onclick: () => setCount(count() + 1) },
            "Increase Count"
          )
        );
      }

      const root = document.body;
      root.appendChild(Hello());
    </script>
  </body>
</html>
```





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---