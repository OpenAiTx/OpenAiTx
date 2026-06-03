<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">تایلندی</a>
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

یک افزونه Prettier که نام کلاس‌های طولانی را بر اساس گزینه `printWidth` می‌شکند.

![یک نمونه کاربرد از این افزونه.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

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

### جایگزینی Markdown/MDX

این افزونه از Markdown و MDX پشتیبانی نمی‌کند، اما اگر این افزونه از یک زبان درون بلوک‌های کد (مثلاً Vue) پشتیبانی کند، فرمت‌بندی ناخواسته ممکن است درون بلوک‌های کد رخ دهد.

برای جلوگیری از فرمت‌بندی ناخواسته، می‌توانید از تنظیمات جایگزین برای Markdown و MDX استفاده کنید.

نمونه JSON:

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

- مثال `relative`:

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
پیش‌فرض | جایگزینی&nbsp;CLI | جایگزینی&nbsp;API
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### تبدیل نحو (Syntax Transformation)

اولین بار در نسخه v0.7.7 ارائه شد.

اگر شکست خط در نام کلاس نوشته شده با نحو غیر-عبارتی رخ دهد، به نحو عبارتی تبدیل می‌شود. این تبدیل از قالب‌بندی معکوس پشتیبانی نمی‌کند.

<!-- prettier-ignore -->
پیش‌فرض | جایگزینی&nbsp;CLI | جایگزینی&nbsp;API
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### عرض چاپ نام کلاس‌ها (Classnames Print Width)

اولین بار در نسخه v0.10.0 ارائه شد.

عرض چاپ نام کلاس را مشخص کنید. اگر مقداری ارائه نشود، مقدار `printWidth` به عنوان پیش‌فرض استفاده می‌شود.

<!-- prettier-ignore -->
پیش‌فرض | جایگزینی&nbsp;CLI | جایگزینی&nbsp;API
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## همبستگی نسخه با افزونه‌های هم‌خانواده

از نسخه `0.6.0`، زمانی که یک انتشار جزئی در یک طرف باشد، در صورت امکان آن تغییر را در طرف دیگر نیز منعکس خواهم کرد.

![همبستگی نسخه.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## سازگاری با سایر افزونه‌های Prettier

اگر بیش از یک افزونه Prettier بتواند متنی که می‌خواهید قالب‌بندی کنید را مدیریت کند، Prettier فقط آخرین افزونه از آن‌ها را استفاده می‌کند.

در این حالت، می‌توانید آن را به صورت زیر با افزودن [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) تنظیم کنید تا افزونه‌ها به صورت متوالی اعمال شوند.

مثال JSON:

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