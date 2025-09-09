
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# prettier-plugin-classnames

एक प्रीटियर प्लगइन जो कि विस्तृत क्लास नामों को `printWidth` विकल्प के आधार पर रैप करता है।

![इस प्लगइन के लिए एक उपयोग केस।](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## इंस्टॉलेशन[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: यदि आपके `prettier-plugin-classnames` संस्करण की संख्या `0.4.0` से कम है, तो आपको `@prettier/sync` भी इंस्टॉल करना होगा।

## कॉन्फ़िगरेशन

JSON उदाहरण:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

JS उदाहरण (CommonJS मॉड्यूल):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

JS उदाहरण (ES मॉड्यूल):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

## विकल्प

### कस्टम एट्रिब्यूट्स

उन एट्रिब्यूट्स की सूची जो वर्ग नाम को समेटते हैं।<br>
`class` और `className` एट्रिब्यूट्स हमेशा समर्थित हैं, भले ही कोई विकल्प निर्दिष्ट न हो।

<!-- prettier-ignore -->
डिफ़ॉल्ट | CLI&nbsp;ओवरराइड | API&nbsp;ओवरराइड
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### कस्टम फंक्शन्स

उन फंक्शन्स की सूची जो वर्ग नाम को समेटते हैं।<br>
`classNames` फंक्शन हमेशा समर्थित है, भले ही कोई विकल्प निर्दिष्ट न हो।

<!-- prettier-ignore -->
डिफ़ॉल्ट | CLI&nbsp;ओवरराइड | API&nbsp;ओवरराइड
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### समाप्ति स्थिति

v0.5.0 में पहली बार उपलब्ध।<br>
`absolute-with-indent` v0.6.0 में जोड़ा गया था।<br>
`absolute-with-indent` v0.8.0 में हटा दिया गया, लेकिन आप `absolute` के साथ वही आउटपुट प्राप्त कर सकते हैं।<br>
डिफ़ॉल्ट मान v0.8.0 में `relative` से बदलकर `absolute` कर दिया गया है।

यह प्रत्येक पंक्ति पर मूल वर्ग नाम को बहु-पंक्ति वर्ग नाम से बदलते समय वर्ग नाम समाप्त करने का मानदंड है।

- `absolute` उदाहरण:

  ```
  --------------------------------------------------| printWidth=50
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 border
          border-zinc-400/30 dark:bg-neutral-900/50
          dark:border-neutral-500/30 px-4 py-4
          rounded-xl"
      >
        {children}
      </div>
    );
  }
  ```

- `relative` उदाहरण:

  ```
  --------------------------------------------------| printWidth=50
  export function Callout({ children }) {
    return (
      <div
                  |--------------------------------------------------|
        className="bg-gray-100/50 border border-zinc-400/30
         |--------------------------------------------------|
          dark:bg-neutral-900/50 dark:border-neutral-500/30
          px-4 py-4 rounded-xl"
      >
        {children}
      </div>
    );
  }
  ```

<!-- prettier-ignore -->
डिफ़ॉल्ट | CLI&nbsp;ओवरराइड | API&nbsp;ओवरराइड
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### सिंटैक्स ट्रांसफॉर्मेशन

पहली बार v0.7.7 में उपलब्ध।

अगर किसी क्लास नाम में नॉन-एक्सप्रेशन सिंटैक्स में लाइन रैपिंग होती है, तो उसे एक्सप्रेशन सिंटैक्स में बदल दिया जाता है। यह ट्रांसफॉर्मेशन रिवर्सिबल फॉर्मेटिंग को सपोर्ट नहीं करता।

<!-- prettier-ignore -->
डिफ़ॉल्ट | CLI&nbsp;ओवरराइड | API&nbsp;ओवरराइड
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## संस्करण संबंध भाई-बहन प्लगइन्स के साथ

`0.6.0` से शुरू करते हुए, जब एक तरफ माइनर रिलीज़ होती है, तो मैं संभव हो तो उस बदलाव को दूसरी तरफ भी दर्शाने की योजना बनाता हूँ।

![संस्करण संबंध.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## अन्य Prettier प्लगइन्स के साथ कम्पैटिबिलिटी

अगर एक से अधिक Prettier प्लगइन उस टेक्स्ट को फॉर्मेट कर सकते हैं जिसे आप फॉर्मेट करना चाहते हैं, तो Prettier केवल उन प्लगइन्स में से अंतिम वाले का उपयोग करेगा।

इस स्थिति में, आप [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) जोड़कर उन प्लगइन्स को क्रमशः लागू करने के लिए इसे इस प्रकार कॉन्फ़िगर कर सकते हैं।

JSON उदाहरण:

<!-- prettier-ignore -->
```json
{
  "plugins": [
    "prettier-plugin-tailwindcss",
    "prettier-plugin-classnames",
    "prettier-plugin-merge"
  ]
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---