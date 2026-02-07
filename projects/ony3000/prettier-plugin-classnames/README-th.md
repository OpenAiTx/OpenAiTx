<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

ปลั๊กอิน Prettier ที่ช่วยตัดบรรทัดชื่อคลาสที่ยาวตามตัวเลือก `printWidth`

![ตัวอย่างการใช้งานปลั๊กอินนี้](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## การติดตั้ง[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: หากเวอร์ชันของ `prettier-plugin-classnames` ของคุณต่ำกว่า `0.4.0` คุณจะต้องติดตั้ง `@prettier/sync` ด้วย

## การตั้งค่า

ตัวอย่าง JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

ตัวอย่าง JS (โมดูล CommonJS):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

ตัวอย่าง JS (ES module):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

## ตัวเลือก

### คุณสมบัติที่กำหนดเอง

รายการคุณสมบัติที่ชื่อคลาสที่ครอบคลุม<br>
แอตทริบิวต์ `class` และ `className` จะรองรับเสมอ แม้ว่าจะไม่มีการระบุออปชั่นใด ๆ

<!-- prettier-ignore -->
ค่าเริ่มต้น | การแทนที่ด้วย CLI&nbsp; | การแทนที่ด้วย API&nbsp;
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### ฟังก์ชันที่กำหนดเอง

รายการฟังก์ชันที่ชื่อคลาสที่ครอบคลุม<br>
ฟังก์ชัน `classNames` จะรองรับเสมอ แม้ว่าจะไม่มีการระบุออปชั่นใด ๆ

<!-- prettier-ignore -->
ค่าเริ่มต้น | การแทนที่ด้วย CLI&nbsp; | การแทนที่ด้วย API&nbsp;
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### ตำแหน่งสิ้นสุด

เริ่มรองรับใน v0.5.0.<br>
`absolute-with-indent` ถูกเพิ่มใน v0.6.0.<br>
`absolute-with-indent` ถูกลบออกใน v0.8.0 แต่คุณสามารถได้ผลลัพธ์เดียวกันด้วย `absolute`.<br>
ค่าดีฟอลต์ถูกเปลี่ยนจาก `relative` เป็น `absolute` ใน v0.8.0

นี่คือเกณฑ์สำหรับการสิ้นสุดชื่อคลาสในแต่ละบรรทัดเมื่อแทนที่ชื่อคลาสเดิมด้วยชื่อคลาสแบบหลายบรรทัด

- ตัวอย่าง `absolute`:

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

- ตัวอย่าง `relative`:

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
ค่าเริ่มต้น | การแทนที่ CLI&nbsp; | การแทนที่ API&nbsp;
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### การแปลงไวยากรณ์

เริ่มใช้งานได้ตั้งแต่ v0.7.7

หากเกิดการตัดบรรทัดในชื่อคลาสที่เขียนด้วยไวยากรณ์ที่ไม่ใช่นิพจน์ จะถูกแปลงเป็นไวยากรณ์แบบนิพจน์ การแปลงนี้ไม่รองรับการจัดรูปแบบย้อนกลับ

<!-- prettier-ignore -->
ค่าเริ่มต้น | การแทนที่ CLI&nbsp; | การแทนที่ API&nbsp;
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## ความสัมพันธ์ของเวอร์ชันกับปลั๊กอินที่เกี่ยวข้อง

เริ่มต้นตั้งแต่เวอร์ชัน `0.6.0` เมื่อมีการออกเวอร์ชันย่อยในฝั่งหนึ่ง ฉันมีแผนจะสะท้อนการเปลี่ยนแปลงนั้นไปยังอีกฝั่งหนึ่งด้วยหากเป็นไปได้

![ความสัมพันธ์ของเวอร์ชัน](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## ความเข้ากันได้กับปลั๊กอิน Prettier อื่น ๆ

หากมีปลั๊กอิน Prettier มากกว่าหนึ่งที่สามารถจัดรูปแบบข้อความที่คุณต้องการ Prettier จะใช้เฉพาะปลั๊กอินตัวสุดท้ายเท่านั้น

ในกรณีนี้ คุณสามารถกำหนดค่าได้ดังนี้โดยเพิ่ม [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) เพื่อให้ปลั๊กอินเหล่านั้นทำงานตามลำดับ

ตัวอย่าง JSON:

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-07

---