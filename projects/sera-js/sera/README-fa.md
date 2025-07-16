<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ar">عربی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=id">اندونزیایی</a>
      </div>
    </div>
  </details>
</div>


![serajs (2)](https://github.com/user-attachments/assets/7ccff260-491d-420b-8e22-4579f9bad50a)

## 📖 **مقدمه**

> 📚 پروژه‌ها  —  seraJs

🔗(نمونه کارها)[https://seraprogrammer.github.io/seraportfolio/] 

🔗(وبلاگ نمایشی)[https://seraprogrammer.github.io/serajsBlogsDemo/] 


```bash
npx degit sera-js/template my-app
cd my-app
```
**SeraJS** یک کتابخانه‌ی جاوااسکریپت واکنشی مبتنی بر سیگنال و سبک است برای
ساخت رابط‌های کاربری پویا.

با فقط **۹۶۹ بایت پس از فشرده‌سازی (gzipped)** و تنها **۱۳۵ خط کد**، این کتابخانه یکی از سبک‌ترین کتابخانه‌های رابط کاربری واکنشی است — که واکنش‌پذیری قدرتمندی را با کمترین سربار ارائه می‌دهد.

> ⚡️ _SeraJS بر **مینیمالیسم** و **عملکرد بالا** تمرکز دارد بدون آنکه تجربه
> توسعه‌دهنده را قربانی کند._


*مقایسه حجم بسته (Minified + Gzipped)*

| کتابخانه | حجم (gzipped) | نیاز به Build | هدف اصلی | ویژگی‌های کلیدی |
|----------|---------------|----------------|-----------|-----------------|
| SeraJS | ۱.۲۵kb | اختیاری 😎 | رابط کاربری واکنشی | ۱۳۵ خط کد، فوق‌العاده سبک |
| React | ~۴۰kb | بله | اجزای UI | Virtual DOM، معماری مبتنی بر کامپوننت، JSX |
| Vue | ~۳۳kb | اختیاری | فریم‌ورک تدریجی | داده‌های واکنشی، سیستم کامپوننت، فایل‌های تک-کامپوننت |
| Solid.js | ~۷kb | بله | رابط کاربری واکنشی | بدون Virtual DOM، قالب‌های کامپایل شده، واکنش‌پذیری دقیق |
| Alpine.js | ~۷.۱kb | خیر | فریم‌ورک سبک | کمترین دستکاری DOM، سینتکس اعلامی، سازگار با HTML موجود |
| Preact | ~۴kb | بله | جایگزین React | سازگار با API React، حجم کمتر، عملکرد سریع‌تر |
| htmx | ~۱۴kb | خیر | بهبود AJAX | ویژگی‌های HTML برای AJAX، جاوااسکریپت حداقلی، سازگار با رندر سمت سرور |



---

## ⚙️ **مفاهیم اصلی**

### 🔄 **واکنش‌پذیری مبتنی بر سیگنال**

SeraJS از یک **سیستم واکنشی مبتنی بر سیگنال** استفاده می‌کند، رویکردی مدرن برای مدیریت وضعیت که به‌روزرسانی‌های کارآمد را ممکن می‌سازد:

- 🧠 **سیگنال‌ها**  
  مقادیر واکنشی مستقل که هنگام تغییر، به مشترکین اطلاع می‌دهند.

- 🌀 **افکت‌ها**  
  توابعی که به‌طور خودکار زمانی که وابستگی‌هایشان (سیگنال‌ها)  
  تغییر می‌کند دوباره اجرا می‌شوند.

- 🧭 **Memo**  
  یک ابزار حافظه‌سازی مشابه React `useMemo` که برای ذخیره نتیجه  
  یک محاسبه بر اساس وابستگی‌های واکنشی استفاده می‌شود تا از محاسبات غیرضروری جلوگیری کند.

- 🔬 **به‌روزرسانی‌های دقیق**  
  فقط عناصر DOM خاصی که تحت تأثیر تغییر وضعیت قرار می‌گیرند به‌روزرسانی می‌شوند،  
  که باعث رندر مجدد حداقلی و عملکرد بالا می‌شود.

> 💡 **SeraJS برای سادگی، سرعت، و ادغام آسان در هر پروژه طراحی شده است — و آن را به انتخابی عالی برای توسعه فرانت‌اند مدرن تبدیل می‌کند.**


## چرا SeraJS؟

SeraJS بهترین ویژگی‌های کتابخانه‌هایی مانند React، Solid و Lit را ترکیب می‌کند — و الگوهای آشنا را با رویکردی تازه و مینیمال در هم می‌آمیزد.

با فقط ۱.۲۵KB پس از فشرده‌سازی و تنها ۱۳۵ خط کد، این کتابخانه فوق‌العاده سبک باقی می‌ماند و همزمان واکنش‌پذیری قدرتمندی ارائه می‌دهد.

چه به سیستم Build نیاز داشته باشید و چه ترجیح دهید بدون Build کار کنید، SeraJS پاسخگوی نیاز شماست. این کتابخانه به اندازه کافی انعطاف‌پذیر است تا متناسب با سبک توسعه شما باشد — از آن به همان صورتی که *شما* می‌خواهید استفاده کنید.


## 🌱 **نمونه ساده Sera.js**

یک نمونه حداقلی که پیام Hello World را با استفاده از Sera.js نمایش می‌دهد.

### 📄 App.jsx





```jsx
import { h } from "serajs";

export default function App() {
  return (
    <h1>Hello world</h1>
  );
}
```
## بدون نیاز به ساخت، بدون وابستگی


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
<translate-content>
</translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---