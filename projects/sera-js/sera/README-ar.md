<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


![serajs (2)](https://github.com/user-attachments/assets/7ccff260-491d-420b-8e22-4579f9bad50a)

## 📖 **مقدمة**

> 📚 المشاريع  —  seraJs

🔗(محفظة الأعمال)[https://seraprogrammer.github.io/seraportfolio/] 

🔗(مدونة تجريبية)[https://seraprogrammer.github.io/serajsBlogsDemo/] 


```bash
npx degit sera-js/template my-app
cd my-app
```
**سيرا جي إس** هي مكتبة جافاسكريبت تفاعلية خفيفة الوزن تعتمد على "الإشارات"  
لبناء واجهات مستخدم ديناميكية.

بحجم **969 بايت فقط مضغوط** و **135 سطرًا فقط من الكود**، تعتبر مكتبة تفاعلية لواجهات المستخدم خفيفة للغاية — حيث تقدم قوة التفاعلية مع أقل استهلاك للموارد.

> ⚡️ _تركز سيرا جي إس على **البساطة** و**الأداء** دون التضحية بتجربة المطور._


*مقارنة حجم الحزمة (مصغر + مضغوط)*

| المكتبة | الحجم (مضغوط) | الحاجة لخطوة بناء | الغرض الرئيسي | الميزات الأساسية |
|---------|---------------|-------------------|----------------|------------------|
| SeraJS | 1.25 كيلوبايت | اختياري 😎 | واجهات تفاعلية | 135 سطر كود، خفيفة للغاية |
| React | ~40 كيلوبايت | نعم | مكونات واجهة المستخدم | DOM افتراضي، هيكلية معتمدة على المكونات، JSX |
| Vue | ~33 كيلوبايت | اختياري | إطار تدريجي | ربط بيانات تفاعلي، نظام المكونات، مكونات ملف واحد |
| Solid.js | ~7 كيلوبايت | نعم | واجهات تفاعلية | بدون DOM افتراضي، قوالب مترجمة، تفاعلية دقيقة |
| Alpine.js | ~7.1 كيلوبايت | لا | إطار خفيف | تلاعب DOM محدود، بناء جمل تصريحي، يعمل مع HTML الموجود |
| Preact | ~4 كيلوبايت | نعم | بديل React | متوافق مع React API، حجم أصغر، أداء أسرع |
| htmx | ~14 كيلوبايت | لا | تحسينات AJAX | سمات HTML لـ AJAX، جافاسكريبت قليلة، مناسب للتصيير الخادمي |



---

## ⚙️ **المفاهيم الأساسية**

### 🔄 **تفاعلية قائمة على الإشارات**

تستخدم سيرا جي إس **نظام إشارات تفاعلي**، وهو نهج حديث لإدارة الحالة  
يُمكّن من تحديثات فعّالة:

- 🧠 **الإشارات**  
  قيم تفاعلية مستقلة تُخطر المشتركين عند تغيرها.

- 🌀 **التأثيرات**  
  دوال تعيد التنفيذ تلقائيًا عند تغير التبعيات (الإشارات).

- 🧭 **ميمو**  
  أداة حفظ النتائج مشابهة لـ React's `useMemo`، تُستخدم لتخزين نتيجة  
  عملية حسابية اعتماداً على التبعيات التفاعلية لتجنب إعادة الحساب غير الضروري.

- 🔬 **تحديثات دقيقة**  
  يتم تحديث عناصر DOM المتأثرة فقط بتغيرات الحالة،  
  مما يؤدي إلى إعادة رسم قليلة وأداء مرتفع.

> 💡 **تم تصميم سيرا جي إس لتكون بديهية، سريعة، وسهلة الدمج في أي مشروع — مما يجعلها خيارًا مثاليًا لتطوير الواجهات الأمامية الحديثة.**


## لماذا سيرا جي إس؟

تجمع سيرا جي إس بين أفضل ميزات مكتبات مثل React و Solid و Lit — حيث تدمج أنماطًا مألوفة مع نهج بسيط وجديد.

بحجم 1.25 كيلوبايت مضغوط و135 سطرًا فقط من الكود، تبقى هذه المكتبة التفاعلية خفيفة للغاية مع تقديم تفاعلية قوية.

سواء كنت تريد نظام بناء أو تفضل العمل بدون بناء، فإن سيرا جي إس تلبي رغبتك. فهي مرنة لتناسب أسلوب تطويرك — استخدمها كما *تريد*.


## 🌱 **مثال أساسي على Sera.js**

مثال بسيط يُظهر رسالة Hello World باستخدام Sera.js.

### 📄 App.jsx






```jsx
import { h } from "serajs";

export default function App() {
  return (
    <h1>Hello world</h1>
  );
}
```
## بدون بناء، بدون تبعيات


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





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---