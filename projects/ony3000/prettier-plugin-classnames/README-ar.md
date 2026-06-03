<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

إضافة لـ Prettier تقوم بتقسيم أسماء الصفوف الطويلة بناءً على خيار `printWidth`.

![حالة استخدام لهذه الإضافة.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## التثبيت[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: إذا كان إصدارك من `prettier-plugin-classnames` أقل من `0.4.0`، ستحتاج أيضًا إلى تثبيت `@prettier/sync`.

## التهيئة

مثال JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

مثال JS (وحدة CommonJS):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

مثال JS (وحدة ES):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### تجاوز Markdown/MDX

لا يدعم هذا البرنامج الإضافي Markdown و MDX، ولكن إذا كان هذا البرنامج الإضافي يدعم لغة داخل كتل الشيفرة (مثل Vue)، فقد يحدث تنسيق غير مقصود داخل كتل الشيفرة.

لمنع التنسيق غير المقصود، يمكنك استخدام تجاوزات التكوين لـ Markdown و MDX.

مثال JSON:

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

## الخيارات

### السمات المخصصة

قائمة السمات التي تحتوي على أسماء الفئات المغلقة.<br>
سمتا `class` و `className` مدعومتان دائمًا، حتى لو لم يتم تحديد أي خيارات.

<!-- prettier-ignore -->
القيمة الافتراضية | تجاوز CLI | تجاوز API
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### الدوال المخصصة

قائمة الدوال التي تحتوي على أسماء الفئات المغلقة.<br>
دالة `classNames` مدعومة دائمًا، حتى لو لم يتم تحديد أي خيارات.

<!-- prettier-ignore -->
القيمة الافتراضية | تجاوز CLI | تجاوز API
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### وضع النهاية

ظهرت لأول مرة في الإصدار v0.5.0.<br>
تمت إضافة `absolute-with-indent` في v0.6.0.<br>
تمت إزالة `absolute-with-indent` في v0.8.0، لكن يمكنك الحصول على نفس الناتج باستخدام `absolute`.<br>
تم تغيير القيمة الافتراضية من `relative` إلى `absolute` في v0.8.0.

هذا هو المعيار لإنهاء اسم الفئة في كل سطر عند استبدال اسم الفئة الأصلي باسم فئة متعدد الأسطر.

- مثال على `absolute`:

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

- مثال على `relative`:

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
الافتراضي | تجاوز CLI&nbsp; | تجاوز API&nbsp;
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### تحويل الصياغة النحوية

متوفر لأول مرة في الإصدار v0.7.7.

إذا حدث التفاف للسطر في اسم صنف مكتوب بصياغة غير تعبيرية، يتم تحويله إلى صياغة تعبيرية. هذا التحويل لا يدعم التنسيق العكسي.

<!-- prettier-ignore -->
الافتراضي | تجاوز CLI&nbsp; | تجاوز API&nbsp;
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### عرض الطباعة لأسماء الأصناف

متوفر لأول مرة في الإصدار v0.10.0.

حدد عرض الطباعة لاسم الصنف. إذا لم يتم توفير قيمة، سيتم استخدام قيمة `printWidth` كافتراضية.

<!-- prettier-ignore -->
الافتراضي | تجاوز CLI&nbsp; | تجاوز API&nbsp;
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## الارتباط بين الإصدارات والإضافات الشقيقة

بدءًا من الإصدار `0.6.0`، عند وجود إصدار فرعي في أحد الجانبين، أخطط لعكس هذا التغيير على الجانب الآخر أيضًا إذا أمكن.

![الارتباط بين الإصدارات.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## التوافق مع إضافات Prettier الأخرى

إذا كان بإمكان أكثر من إضافة Prettier التعامل مع النص الذي تريد تنسيقه، فسيستخدم Prettier فقط آخر إضافة من هذه الإضافات.

في هذه الحالة، يمكنك تهيئتها كما يلي عن طريق إضافة [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) لتطبيق هذه الإضافات بالتسلسل.

مثال JSON:

<!-- تجاهل التنسيق -->
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