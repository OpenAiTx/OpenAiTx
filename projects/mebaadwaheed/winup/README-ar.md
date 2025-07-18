<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Desktop App](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Support](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## أمثلة على الصور

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## تأكد من تنزيل آخر إصدار ثابت (LSR) وليس الأحدث/LFR! الإصدار الحالي LSR: 2.4.9

`pip install winup==2.4.9`

**إطار عمل قوي و"بايثوني" بشكل مذهل لبناء تطبيقات سطح مكتب جميلة.**

WinUp هو إطار واجهة مستخدم حديث للغة بايثون يغلّف قوة PySide6 (Qt) في واجهة برمجة تطبيقات بسيطة، وصفية، وسهلة للمطورين. صُمم لتمكينك من بناء التطبيقات بسرعة أكبر، وكتابة كود أنظف، والاستمتاع بعملية التطوير.

### ✨ الآن مع دعم الويب!
يدعم WinUp الآن أيضًا بناء تطبيقات ويب تفاعلية بالكامل وحالة قائمة باستخدام نفس النهج القائم على المكونات والمتمحور حول بايثون. يستخدم وحدة الويب FastAPI وWebSockets في الخلفية لتوفير بساطة WinUp للمتصفح.

[توثيق الويب](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **تنويه:** دعم الويب ميزة اختيارية. لاستخدامه، يجب تثبيت تبعيات الويب:
> ```bash
> pip install "winup[web]"
> ```

[المساهمة](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[سجل التحديثات](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[الترخيص](LICENSE)

---

## لماذا WinUp؟ (بدلاً من PySide6 الخام أو Tkinter)

قد يكون تطوير تطبيقات سطح المكتب في بايثون معقدًا. تم بناء WinUp لحل هذه المشكلة.

| الميزة                  | طريقة WinUp ✨                                                                  | طريقة PySide6 / Tkinter الخام 😟                                                              |
| ----------------------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------- |
| **التخطيطات**           | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                  |
| **التصميم**             | `props={"background-color": "blue", "font-size": "16px"}`                      | سلاسل QSS يدوية، `widget.setStyleSheet(...)`، كائنات تصميم معقدة.                           |
| **إدارة الحالة**        | `state.bind(widget, "prop", "key")`                                            | دوال رد يدوي، getters/setters، `StringVar()`، كود مكرر في كل مكان.                           |
| **الربط ذو الاتجاهين**  | `state.bind_two_way(input_widget, "key")`                                      | غير موجود. يتطلب معالجات on_change يدوية لتحديث الحالة والواجهة.                             |
| **أدوات المطور**        | **إعادة تحميل تلقائية مدمجة**، محلل الأداء، وأدوات نافذة جاهزة.                | غير موجودة. يجب إعادة تشغيل التطبيق لكل تغيير في الواجهة.                                    |
| **هيكلية الكود**        | مكونات قابلة لإعادة الاستخدام ومستقلة مع `@component`.                        | غالبًا ما يؤدي ذلك إلى كود ضخم أو نصوص إجرائية.                                              |

**باختصار، يوفر WinUp الميزات "القاتلة" لإطارات عمل الويب الحديثة (مثل React أو Vue) لسطح المكتب، ويوفر وقتك ويتيح لك التركيز على منطق تطبيقك فقط.**

# 🧊 WinUp مقابل 🧱 PyEdifice (حسب طلب مستخدم Reddit)

| الميزة                          | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 المعمارية                    | نمط React + حالة        | نمط React + حالة                 |
| 🌐 التوجيه المدمج                | ✅ نعم (`Router(routes={...})`)      | ❌ لا يوجد توجيه مدمج             |
| ♻️ خطافات دورة الحياة           | ✅ `on_mount`, `on_unmount`, إلخ.    | ⚠️ محدود (`did_mount`, إلخ.)      |
| 🎨 النظام الموحد/التصميم         | ✅ ثيمات عامة ومحلية                 | ❌ حقن CSS يدوي                   |
| 🔲 خيارات التخطيط                | ✅ صف، عمود، شبكة، تكديس، Flexbox   | ⚠️ غالبًا Box وHBox/VBox          |
| 🎞️ الحركات                      | ✅ مدمجة (تلاشي، تكبير، إلخ.)       | ❌ لا يوجد مدمج                   |
| 🔁 إعادة التحميل الفوري (LHR)    | ✅ مستقر وسريع (`loadup dev`)       | ⚠️ تجريبي، دعم محدود              |
| 📦 التغليف                       | ✅ مع LoadUp (يعتمد على PyInstaller) | ❌ يجب دمج PyInstaller يدويًا      |
| 🧩 إعادة استخدام المكونات        | ✅ عالية، وصفية                      | ✅ عالية                           |

| 🛠 أدوات المطورين              | ✅ أدوات المطورين مخططة، المفتش قريبًا  | ❌ لا يوجد حتى الآن                 |
| 📱 دعم الهواتف المحمولة         | ❌ ليس بعد                           | ❌ غير مدعوم                       |
| 🧠 سهولة التعلم                 | ✅ سهل لمستخدمي بايثون+ريأكت         | ✅ سهل لكن بأدوات أقل              |

> ✅ = مدمج أو قوي  
> ⚠️ = جزئي أو محدود  
> ❌ = مفقود تمامًا
---

## الميزات الأساسية

*   **واجهة مستخدم إعلانية وبايثونية:** أنشئ تخطيطات معقدة باستخدام كائنات `Row` و`Column` البسيطة بدلًا من تخطيطات الصناديق التقليدية.
*   **معمارية قائمة على المكونات:** استخدم ديكوريتر `@component` لإنشاء ودجات واجهة مستخدم معيارية وقابلة لإعادة الاستخدام من دوال بسيطة.
*   **نظام تنسيق قوي:** نسّق الودجات الخاصة بك باستخدام قواميس بايثون بسيطة عبر `props`. أنشئ "فئات" عالمية شبيهة بـ CSS باستخدام `style.add_style_dict`.
*   **هيكل تطبيق كامل:** أنشئ تطبيقات احترافية عبر واجهة برمجة إعلانية لعناصر مثل `MenuBar`، و`ToolBar`، و`StatusBar`، و`SystemTrayIcon`.
*   **مشغل مهام غير متزامن:** نفذ العمليات طويلة الأمد في الخلفية بدون تجميد واجهتك باستخدام ديكوريتر `@tasks.run` البسيط.
*   **أداء افتراضي محسّن:** يتضمن ديكوريتر اختياري `@memo` لتخزين نتائج رسم المكونات وتجنب إعادة الحساب غير الضرورية.
*   **قابلية التوسعة المتقدمة:**
    *   **مصنع الودجات:** استبدل أي ودجت افتراضي بتنفيذك المخصص (مثل المبني بلغة ++C) باستخدام `ui.register_widget()`.
    *   **نوافذ متعددة:** أنشئ وادِر نوافذ مستقلة متعددة لتطبيقات معقدة مثل لوحات الأدوات أو مشغلات الموسيقى.
*   **إدارة الحالة التفاعلية:**
    *   **ربط أحادي الاتجاه:** حدّث واجهتك تلقائيًا عند تغيير البيانات باستخدام `state.bind()`.
    *   **ربط ثنائي الاتجاه:** قم بمزامنة ودجات الإدخال مع الحالة بسهولة عبر `state.bind_two_way()`.
    *   **الاشتراكات:** نفذ أي دالة استجابة لتغييرات الحالة باستخدام `state.subscribe()`.
*   **أدوات صديقة للمطور:**
    *   **إعادة تحميل فورية:** شاهد تغييرات واجهتك مباشرة بدون إعادة تشغيل التطبيق.
    *   **محلل الأداء:** قِس أداء أي دالة بسهولة باستخدام ديكوريتر `@profiler.measure()`.
    *   **أدوات النوافذ:** ركز، ومض، أو أدِر نافذة التطبيق بسهولة.
*   **توجيه مدمج:** أنشئ تطبيقات متعددة الصفحات بسهولة عبر موجه يعتمد على الحالة وبواجهة بديهية.
*   **طبقة بيانات مرنة:** يتضمن موصلات بسيطة وموحدة لـ SQLite وPostgreSQL وMySQL وMongoDB وFirebase.

---

# التوثيق

اكتشف ميزات WinUp بمزيد من العمق:

## المفاهيم الأساسية
- [**نموذج المكونات والتنسيق**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**إدارة الحالة**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**خطافات دورة الحياة**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**التوجيه**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**الوضع المطلق (متقدم)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## أدوات المطورين
- [**إعادة تحميل فورية حية (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**محلل الأداء**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**التخزين المؤقت (Memoization)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**مشغل المهام غير المتزامنة**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## مكونات واجهة المستخدم
- [**مكتبة المكونات الكاملة**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## المساهمة

WinUp هو مشروع مفتوح المصدر. المساهمات مرحب بها!

## الرخصة

هذا المشروع مرخص بموجب رخصة MIT. راجع **LICENSE** لمزيد من المعلومات.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---