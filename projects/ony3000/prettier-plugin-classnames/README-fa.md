
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# prettier-plugin-classnames

یک افزونه Prettier که نام‌های کلاس طولانی را بر اساس گزینه `printWidth` به صورت چند خطی می‌شکند.

![یک کاربرد این افزونه.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## نصب[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: اگر نسخه‌ی `prettier-plugin-classnames` شما کمتر از `0.4.0` باشد، همچنین باید `@prettier/sync` را نصب کنید.

## پیکربندی

نمونه JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

نمونه JS (ماژول CommonJS):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

مثال JS (ماژول ES):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

## گزینه‌ها

### ویژگی‌های سفارشی

فهرستی از ویژگی‌ها که نام کلاس‌های محصورکننده را شامل می‌شوند.<br>
ویژگی‌های `class` و `className` همواره پشتیبانی می‌شوند، حتی اگر هیچ گزینه‌ای تعیین نشده باشد.

<!-- prettier-ignore -->
پیش‌فرض | جایگزینی&nbsp;CLI | جایگزینی&nbsp;API
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### توابع سفارشی

فهرستی از توابع که نام کلاس‌های محصورکننده را شامل می‌شوند.<br>
تابع `classNames` همواره پشتیبانی می‌شود، حتی اگر هیچ گزینه‌ای تعیین نشده باشد.

<!-- prettier-ignore -->
پیش‌فرض | جایگزینی&nbsp;CLI | جایگزینی&nbsp;API
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### موقعیت پایانی

برای اولین بار در نسخه v0.5.0 ارائه شد.<br>
`absolute-with-indent` در نسخه v0.6.0 اضافه شد.<br>
`absolute-with-indent` در نسخه v0.8.0 حذف شد، اما می‌توانید همان خروجی را با `absolute` دریافت کنید.<br>
مقدار پیش‌فرض از `relative` به `absolute` در نسخه v0.8.0 تغییر کرد.

این معیار برای پایان نام کلاس در هر خط هنگام جایگزینی نام کلاس اصلی با نام کلاس چندخطی است.

- مثال `absolute`:

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

- مثال `relative`:

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
پیش‌فرض | جایگزینی CLI&nbsp; | جایگزینی API&nbsp;
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### تبدیل نحو

اولین بار در نسخه v0.7.7 ارائه شد.

اگر در یک نام کلاس نوشته‌شده به صورت نحو غیرعبارتی، شکست خط رخ دهد، به نحو عبارتی تبدیل می‌شود. این تبدیل از قالب‌بندی برگشت‌پذیر پشتیبانی نمی‌کند.

<!-- prettier-ignore -->
پیش‌فرض | جایگزینی CLI&nbsp; | جایگزینی API&nbsp;
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## همبستگی نسخه با پلاگین‌های هم‌خانواده

از نسخه `0.6.0`، در صورت انتشار یک نسخه کوچک در یک طرف، در صورت امکان آن تغییر را در طرف دیگر نیز اعمال خواهم کرد.

![همبستگی نسخه.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## سازگاری با سایر پلاگین‌های Prettier

اگر بیش از یک پلاگین Prettier بتواند متنی را که می‌خواهید قالب‌بندی کنید مدیریت کند، Prettier فقط آخرین پلاگین از آن‌ها را استفاده خواهد کرد.

در این حالت، می‌توانید با افزودن [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) آن را طوری پیکربندی کنید که این پلاگین‌ها به صورت متوالی اعمال شوند.

نمونه JSON:

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