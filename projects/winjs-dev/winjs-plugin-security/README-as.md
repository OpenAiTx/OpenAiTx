
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

WinJS প্ৰকল্পসমূহৰ বাবে নিৰাপত্তা বঢ়োৱা সুবিধা আগবঢ়োৱা এটা প্লাগইন, মূলত SRI (Subresource Integrity) গুণ সম্পত্তি উৎপন্ন কৰাত ব্যৱহাৰ হয়।

<p>
  <a href="https://npmjs.com/package/@winner-fed/plugin-security">
   <img src="https://img.shields.io/npm/v/@winner-fed/plugin-security?style=flat-square&colorA=564341&colorB=EDED91" alt="npm version" />
  </a>
  <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="license" />
  <a href="https://npmcharts.com/compare/@winner-fed/plugin-security?minimal=true"><img src="https://img.shields.io/npm/dm/@winner-fed/plugin-security.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="downloads" /></a>
</p>

## বৈশিষ্ট্যসমূহ

- HTML ফাইলত থকা `<script>` আৰু `<link>` টেগৰ বাবে স্বয়ংক্ৰিয়ভাৱে SRI গুণ সম্পত্তি উৎপন্ন কৰে
- SHA-256, SHA-384, SHA-512 হেচ এলগৰিদম সমৰ্থিত (কনফিগাৰ কৰিব পৰা যায়)
- SRI সঠিকভাৱে কাম কৰিবলৈ স্বয়ংক্ৰিয়ভাৱে `crossorigin="anonymous"` গুণ সংযোজন কৰে
- কেৱল উৎপাদন পৰিবেশত প্ৰযোজ্য, উন্নয়ন পৰ্যায়ত স্বয়ংক্ৰিয়ভাৱে বাদ দিয়া হয়

## সংস্থাপন

```bash
pnpm add @winner-fed/plugin-security
```

## ব্যৱহাৰৰ পদ্ধতি

আপোনাৰ `.winrc.ts` কনফিগাৰেচন ফাইলত প্লাগিন কনফিগাৰেচন যোগ কৰক:

```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```

## সংৰূপ বিকল্পসমূহ

### `sri`

- **প্ৰকাৰ**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **অবিকল্পিত মান**: নিজে হাতে সংযোজন কৰিব লাগিব
- **বিৱৰণ**: SRI (সাব-ৰিছৰ্চ ইন্টেগ্ৰিটি) ফাংচন সক্ৰিয় কৰিব নে, লগতে ঐচ্ছিক হেছ এলগৰিদম সংৰূপ

`true` বা `{}` হিচাপে সংৰূপ কৰিলে, প্লাগিনে:

1. নিৰ্মাণ-শেষৰ HTML ফাইল চাব
2. সকলো `src` গুণবিশিষ্ট `<script>` টেগত `integrity` গুণ সংযোজন কৰিব
3. সকলো `href` গুণবিশিষ্ট `<link>` টেগত `integrity` গুণ সংযোজন কৰিব
4. স্বয়ংক্ৰিয়ভাৱে `crossorigin="anonymous"` গুণ সংযোজন কৰিব (যদি নাথাকে)

আপুনি অবজেক্টৰ জৰিয়তে হেছ এলগৰিদমো নিৰ্ধাৰণ কৰিব পাৰে:

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

### HTML নিৰ্গমন (SRI সক্ৰিয় কৰাৰ পাছত)

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

## সুৰক্ষা নিৰ্দেশনা

SRI (উপ-সম্পদ অখণ্ডতা) এটা সুৰক্ষা বৈশিষ্ট্য, যি ব্ৰাউজাৰে সংগৃহীত সম্পদসমূহ (যেনে CDN ৰ পৰা সংগৃহীত সম্পদ) দুষ্কৃতিপূৰ্ণভাৱে সলনি কৰা হোৱা নাই জানিবৰ বাবে যাচাই কৰিব পাৰে। যেতিয়া ব্ৰাউজাৰে সম্পদটো লোড কৰে, তেতিয়া সম্পদটোৰ হেছ মান গণনা কৰি `integrity` গুণৰ ভিতৰত নিৰ্দিষ্ট কৰা হেছ মানৰ সৈতে তুলনা কৰে। যদি হেছ মান মিল নাখায়, তেন্তে ব্ৰাউজাৰে সম্পদটো লোড কৰিবলৈ অস্বীকাৰ কৰে।

`<script>` টেগৰ ক্ষেত্ৰত, ফলাফল হৈছে তাৰ ভিতৰৰ কোডটো সম্পাদন নকৰা; CSS লিংকৰ ক্ষেত্ৰত, ফলাফল হৈছে তাৰ ভিতৰৰ ষ্টাইল লোড নকৰা।

SRI সম্পৰ্কে অধিক জানিবলৈ, [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity) চাব পাৰে।

## মনোযোগৰ বিষয়

1. এই প্লাগিন কেৱল প্ৰ'ডাকশ্যন বিল্ডত প্ৰযোজ্য, ডেভেলপমেন্ট পৰিৱেশত স্বয়ংক্ৰিয়ভাৱে উপেক্ষা কৰা হয়
2. নিশ্চিত কৰিব লাগিব যে সম্পদ ফাইলসমূহ নিৰ্মাণৰ আউটপুট ডিৰেক্টৰিত পোৱা যায়
3. `integrity` গুণটো `crossorigin` গুণৰ সৈতে ব্যৱহাৰ কৰিলে মাত্ৰ ঠিক মতে কাম কৰে

## লাইচেঞ্চ

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---