<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

এটা Prettier প্লাগিন যি বৰ্ণনামূলক ক্লাছ নামসমূহক `printWidth` বিকল্পৰ আধাৰত ৰেপ কৰে।

![এই প্লাগিনৰ এটা ব্যৱহাৰিক দৃষ্টান্ত।](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## স্থাপন[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: যদি আপোনাৰ `prettier-plugin-classnames` ৰ সংস্কৰণ `0.4.0` তকৈ কম হয়, তেন্তে আপোনাক `@prettier/sync`ো ইনষ্টল কৰিব লাগিব।

## সংৰূপণ

JSON উদাহৰণ:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

JS উদাহৰণ (CommonJS মডিউল):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

JS উদাহৰণ (ES মডিউল):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### Markdown/MDX অ'ভাৰাইড

এই প্লাগইনটোৱে Markdown আৰু MDX সমৰ্থন নকৰে, কিন্তু যদি এই প্লাগইনটোৱে ক'ড ব্লকসমূহৰ ভিতৰত কোনো ভাষা সমৰ্থন কৰে (উদাহৰণস্বৰূপে Vue), তেন্তে ক'ড ব্লকসমূহৰ ভিতৰত অনিচ্ছাকৃত ফৰ্মেটিং ঘটিব পাৰে।

অনিচ্ছাকৃত ফৰ্মেটিং ৰোধ কৰিবলৈ, আপুনি Markdown আৰু MDX-ৰ বাবে কনফিগাৰেচন অ'ভাৰাইড ব্যৱহাৰ কৰিব পাৰে।

JSON উদাহৰণ:

```json
{
  "plugins": ["prettier-plugin-classnames"],
  "customFunctions": ["clsx"],
  "overrides": [
    {
      "files": ["*.md", "*.mdx"],
      "options": {
        "plugins": []
      }
    }
  ]
}
```

## বিকল্পসমূহ

### কাষ্টম এট্ৰিবিউটসমূহ

এনক্ল'জিং ক্লাছ নামসমূহৰ এট্ৰিবিউটৰ তালিকা।<br>
`class` আৰু `className` এট্ৰিবিউট সদায় সমৰ্থিত, বিকল্প নিৰ্ধাৰণ নকৰিলেও।

<!-- prettier-ignore -->
ডিফ'ল্ট | CLI&nbsp;ওভাৰ্ৰাইড | API&nbsp;ওভাৰ্ৰাইড
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### কাষ্টম ফাংচনসমূহ

এনক্ল'জিং ক্লাছ নামসমূহৰ ফাংচনসমূহৰ তালিকা।<br>
`classNames` ফাংচন সদায় সমৰ্থিত, বিকল্প নিৰ্ধাৰণ নকৰিলেও।

<!-- prettier-ignore -->
ডিফ'ল্ট | CLI&nbsp;ওভাৰ্ৰাইড | API&nbsp;ওভাৰ্ৰাইড
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### সমাপ্তিৰ অৱস্থান

প্ৰথমবাৰৰ বাবে v0.5.0-ত উপলব্ধ।<br>
`absolute-with-indent` v0.6.0-ত যোগ কৰা হৈছিল।<br>
`absolute-with-indent` v0.8.0-ত আঁতৰ কৰা হৈছিল, কিন্তু আপুনি `absolute` ব্যৱহাৰ কৰি একে আউটপুট পাব পাৰে।<br>
ডিফ'ল্ট মান v0.8.0-ত `relative`ৰ পৰা `absolute`লৈ সলনি কৰা হৈছিল।

এইটো হৈছে প্ৰতিটো শাৰীত ক্লাছ নাম শেষ কৰাৰ মানদণ্ড, যেতিয়া মূল ক্লাছ নামক বহু-শাৰীৰ ক্লাছ নামৰ সৈতে প্ৰতিস্থাপন কৰা হয়।

- `absolute` উদাহৰণ:

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 dark:bg-neutral-900/50
          border border-zinc-400/30 dark:border-neutral-500/30
          rounded-xl px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

- `relative` উদাহৰণ:

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
       |------------------------------------------------------------|
        className="bg-gray-100/50 dark:bg-neutral-900/50 border
         |------------------------------------------------------------|
          border-zinc-400/30 dark:border-neutral-500/30 rounded-xl
          px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```
<!-- prettier-ignore -->
ডিফল্ট | CLI&nbsp;অভাৰাইড | API&nbsp;অভাৰাইড
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### সিন্টেক্স ৰূপান্তৰ

প্ৰথমবাৰ v0.7.7-ত উপলব্ধ।

যদি কোনো শ্ৰেণী নামত ন-এক্সপ্ৰেশন সিন্টেক্সত লিখা হলে লাইনৰ মোচন ঘটে, তেন্তে সেইটো এক্সপ্ৰেশন সিন্টেক্সলৈ ৰূপান্তৰিত হয়। এই ৰূপান্তৰ reversible formatting সমৰ্থন নকৰে।

<!-- prettier-ignore -->
ডিফল্ট | CLI&nbsp;অভাৰাইড | API&nbsp;অভাৰাইড
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### শ্ৰেণী নাম প্ৰিন্ট উইড্থ

প্ৰথমবাৰ v0.10.0-ত উপলব্ধ।

শ্ৰেণী নামৰ প্ৰিন্ট উইড্থ নিৰ্ধাৰণ কৰক। যদি কোনো মান দিয়া নহয়, `printWidth` মানটো ডিফল্ট হিচাপে ব্যৱহাৰ কৰা হয়।

<!-- prettier-ignore -->
ডিফল্ট | CLI&nbsp;অভাৰাইড | API&nbsp;অভাৰাইড
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## সংস্কৰণৰ সম্পৰ্ক সibling প্লাগইনৰ সৈতে

`0.6.0`-ৰ পৰা আৰম্ভ কৰি, যদি কোনো এটা দিশত minor release থাকে, সম্ভৱ হলে সেই পৰিবর্তন আন দিশতো প্রতিফলিত কৰাৰ পৰিকল্পনা আছে।

![সংস্কৰণৰ সম্পৰ্ক।](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## আন Prettier প্লাগইনৰ সৈতে সামঞ্জস্যতা

যদি একাধিক Prettier প্লাগইনে আপোনাৰ ফৰ্মেট কৰিবলৈ চোৱা টেক্সটটো হেণ্ডল কৰিব পাৰে, Prettier কেৱল সেই প্লাগইনৰ অন্তিমটোহে ব্যৱহাৰ কৰে।

এই ক্ষেত্ৰত, [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) যোগ কৰি সেই প্লাগইনবোৰক ক্ৰমে প্রয়োগ কৰিবলৈ তলত দেখুৱোৱা মতে কনফিগাৰ কৰিব পাৰি।


JSON উদাহৰণ:

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

## Stargazers over time

[![Stargazers over time](https://starchart.cc/ony3000/prettier-plugin-classnames.svg?variant=adaptive)](https://starchart.cc/ony3000/prettier-plugin-classnames)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---