<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

إضافة لتعزيز الأمان في مشاريع WinJS، تُستخدم بشكل أساسي لتوليد خاصية SRI (تكامل الموارد الفرعية).

<p>
  <a href="https://npmjs.com/package/@winner-fed/plugin-security">
   <img src="https://img.shields.io/npm/v/@winner-fed/plugin-security?style=flat-square&colorA=564341&colorB=EDED91" alt="إصدار npm" />
  </a>
  <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="الترخيص" />
  <a href="https://npmcharts.com/compare/@winner-fed/plugin-security?minimal=true"><img src="https://img.shields.io/npm/dm/@winner-fed/plugin-security.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="عدد التنزيلات" /></a>
</p>

## الميزات

- توليد خاصية SRI تلقائياً لعناصر `<script>` و `<link>` في ملفات HTML
- دعم خوارزميات التجزئة SHA-256 و SHA-384 و SHA-512 (قابل للتكوين)
- إضافة خاصية `crossorigin="anonymous"` تلقائياً لضمان عمل SRI بشكل صحيح
- يعمل فقط في بيئة الإنتاج، ويتخطى تلقائياً في بيئة التطوير

## التثبيت


```bash
pnpm add @winner-fed/plugin-security
```
## طريقة الاستخدام

أضف إعدادات الإضافة في ملف التكوين الخاص بك `.winrc.ts`:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## خيارات التكوين

### `sri`

- **النوع**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **القيمة الافتراضية**: يجب تعيينها يدويًا
- **الوصف**: تحديد ما إذا كان سيتم تفعيل ميزة SRI (تكامل الموارد الفرعية)، بالإضافة إلى إمكانية ضبط خوارزمية التجزئة اختياريًا

عند التعيين إلى `true` أو `{}`، سيقوم الملحق بـ:

1. مسح ملفات HTML الناتجة بعد البناء
2. إضافة خاصية `integrity` لجميع وسوم `<script>` التي تحتوي على خاصية `src`
3. إضافة خاصية `integrity` لجميع وسوم `<link>` التي تحتوي على خاصية `href`
4. إضافة خاصية `crossorigin="anonymous"` تلقائيًا (إذا لم تكن موجودة)

يمكنك أيضًا تحديد خوارزمية التجزئة عن طريق كائن:


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
### إخراج HTML (بعد تمكين SRI)


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
## تعليمات الأمان

SRI (تكامل الموارد الفرعية) هي ميزة أمان تتيح للمتصفح التحقق من أن الموارد التي تم الحصول عليها (مثل الموارد التي تم الحصول عليها من CDN) لم يتم تعديلها بشكل ضار. عندما يقوم المتصفح بتحميل المورد، سيحسب قيمة التجزئة للمورد ويقارنها بقيمة التجزئة المحددة في خاصية `integrity`. إذا لم تتطابق قيمة التجزئة، سيرفض المتصفح تحميل هذا المورد.

بالنسبة إلى وسم `<script>`, ستكون النتيجة هي رفض تنفيذ الكود الموجود بداخله؛ أما بالنسبة إلى روابط CSS، فالنتيجة هي عدم تحميل الأنماط الموجودة فيها.

لمزيد من المعلومات حول SRI، يمكنك مراجعة [تكامل الموارد الفرعية - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity).

## ملاحظات

1. هذا الملحق يعمل فقط عند البناء للإنتاج، وسيتم تخطيه تلقائيًا في بيئة التطوير
2. يجب التأكد من أن ملفات الموارد قابلة للوصول في دليل إخراج البناء
3. يجب استخدام خاصية `integrity` مع خاصية `crossorigin` حتى تعمل بشكل صحيح

## الرخصة

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---