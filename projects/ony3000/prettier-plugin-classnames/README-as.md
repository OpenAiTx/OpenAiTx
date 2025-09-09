
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
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fr">ফ্ৰান্সে</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=de">জাৰ্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=es">স্পেনীয়</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=it">ইটালিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pl">পোলিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ar">আরবী</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fa">ফাৰ্চী</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=tr">টাৰ্কিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=vi">ভিয়েটনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=id">ইন্দোনেছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# prettier-plugin-classnames

এটা Prettier প্লাগিন যি বিস্তৃত ক্লাছ নামসমূহ `printWidth` বিকল্প অনুসৰি ৰেপ কৰে।

![এই প্লাগিনৰ এটা ব্যৱহাৰৰ উদাহৰণ।](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## সংস্থাপন[^1]

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

- `relative` উদাহৰণ:

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
Default | CLI&nbsp;Override | API&nbsp;Override
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Syntax Transformation

প্ৰথমবাৰৰ বাবে v0.7.7-ত উপলব্ধ।

যদি একোটা শ্ৰেণী নামত (class name) non-expression syntax-ত line wrapping হয়, তেতিয়া সেইটো expression syntax-লৈ ৰূপান্তৰিত কৰা হয়। এই ৰূপান্তৰ reversible formatting-ৰ সমৰ্থন নকৰে।

<!-- prettier-ignore -->
Default | CLI&nbsp;Override | API&nbsp;Override
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## Version correlation with sibling plugins

`0.6.0`-ৰ পৰা আৰম্ভ কৰি, যদি এফালে minor release হয়, তেন্তে সম্ভৱ হলে সেই পৰিৱর্তন আনফালতো প্ৰতিফলিত কৰাৰ পৰিকল্পনা আছে।

![Version correlation.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Compatibility with other Prettier plugins

যদি একাধিক Prettier plugin-এ আপোনাৰ format কৰিবলগীয়া পাঠ্য হেণ্ডল কৰিব পাৰে, তেন্তে Prettier কেৱল শেষ plugin-টো ব্যৱহাৰ কৰিব।

এই ক্ষেত্ৰত, [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) যোগ কৰি তলত দেখুওৱা দৰে sequentially plugins-বোৰ apply কৰিব পাৰে।

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


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---