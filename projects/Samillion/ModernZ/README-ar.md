<h1 align="center">ModernZ - بديل أنيق لـ OSC لـ mpv</h1>

OSC أنيق وحديث لـ [mpv](https://mpv.io/)، هذا المشروع هو فرع من ModernX مصمم لتعزيز الوظائف بإضافة المزيد من الميزات، مع الحفاظ على المعايير الأساسية لـ OSC في mpv.

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>التثبيت »</strong></a>
  <br>
  <a href="#configuration">الإعداد</a>
  ·
  <a href="#controls">التحكم</a>
  ·
  <a href="#interactive-menus">القوائم التفاعلية</a>
  ·
  <a href="#translations">لغة OSC</a>
  ·
  <a href="#extras">السكريبتات الإضافية</a>
</p>

## الميزات

- 🎨 واجهة حديثة وقابلة للتخصيص [[الخيارات](#configuration)]
- 📷 وضع عارض الصور مع تحكم في التكبير [[التفاصيل](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ أزرار: تحميل، قائمة التشغيل، التحكم في السرعة، لقطة شاشة، تثبيت، تكرار، التخزين المؤقت والمزيد. [[التفاصيل](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 قوائم تفاعلية لقائمة التشغيل، الترجمات، الفصول، مسارات الصوت وأجهزة الصوت [[التفاصيل](#interactive-menus)]
- 🌐 دعم متعدد اللغات مع تكامل JSON [locale](#translations)
- ⌨️ تحكمات قابلة للتكوين [[التفاصيل](#controls)]
- 🖼️ معاينات مصغرة للفيديو مع [thumbfast](https://github.com/po5/thumbfast)

## التخصيص

يمكنك تغيير موضوع الأيقونات إلى `fluent` أو `material` ليناسب ذوقك وأسلوبك باستخدام خيار `icon_theme` في ملف `modernz.conf` الخاص بك

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

لست من محبي الأزرار والنصوص البيضاء؟ لديك التحكم الكامل لتخصيص الألوان وتصميم الأزرار لتعكس أسلوبك تمامًا.

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

راجع قسم [تخصيص الألوان](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style) في دليل الإعدادات لمزيد من التفاصيل حول كيفية تخصيص الألوان والأزرار.

## القوائم التفاعلية

يدعم ModernZ وحدة التحكم/التحديد المدمجة في mpv ([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0)) لقائمة التشغيل، الترجمات، التنقل بين الفصول والمزيد.

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## التثبيت

1. **تعطيل OSC الافتراضي**

   - أضف `osc=no` في ملف `mpv.conf` الخاص بك

2. **نسخ الملفات**

   - ضع `modernz.lua` في مجلد السكريبتات الخاص بـ mpv
   - ضع `fluent-system-icons.ttf` و `material-design-icons.ttf` في مجلد الخطوط الخاص بـ mpv
   - (اختياري) ضع `thumbfast.lua` في مجلد السكريبتات الخاص بـ mpv

3. **المواقع**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **هيكل المجلدات** [[دليل mpv](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (اختياري)
   ```

## الإعداد

1. أنشئ ملف `modernz.conf` في مجلد `/script-opts` لتخصيص الإعدادات

   - [تحميل ملف modernz.conf الافتراضي](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. مثال على إعداد قصير:

   ```EditorConfig
   # لون شريط التقدم (صيغة هكس)
   seekbarfg_color=#B7410E

   # خيارات الواجهة
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

لقائمة كاملة من الخيارات، [اطلع على القائمة التفصيلية هنا](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md).

## التحكم

### تفاعلات الأزرار

- النقر الأيسر: الإجراء الأساسي
- النقر الأيمن: الإجراء الثانوي
- النقر الأوسط/Shift+نقرة يسرى: إجراء بديل

> [!ملاحظة]
> النقر الأوسط يؤدي نفس وظيفة `Shift+زر الفأرة الأيسر`، مما يسمح بالاستخدام بيد واحدة

لقائمة كاملة من التفاعلات، اطلع على [دليل تفاعلات الأزرار](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md).

### اختصارات لوحة المفاتيح

لا يحدد ModernZ اختصارات بشكل افتراضي لتجنب التداخل مع إعداداتك الحالية. يمكنك إضافة الاختصارات في `input.conf` إذا رغبت:

```
w   script-binding modernz/progress-toggle           # تبديل شريط التقدم
x   script-message-to modernz osc-show               # عرض OSC
y   script-message-to modernz osc-visibility cycle   # تبديل أوضاع الرؤية
z   script-message-to modernz osc-idlescreen         # تبديل شاشة الخمول
```

## الترجمات

يتوفر ModernZ حاليًا باللغة الإنجليزية، ولكن يمكنك بسهولة تغييره إلى لغتك المفضلة! إليك الطريقة:

1. **تحميل حزمة اللغة:**

احصل على ملف [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) من هذا المستودع. يحتوي هذا الملف على ترجمات للغات متعددة.

2. **أضف اللغات إلى mpv:**

انسخ ملف `modernz-locale.json` المحمّل إلى مجلد `/script-opts` الخاص بـ mpv.

3. **اختر لغتك:**

هناك طريقتان لتعيين لغتك المفضلة:

- **الموصى بها:** استخدم ملف `modernz.conf`

  ```ini
  # مثال إعداد في modernz.conf
  # تعيين اللغة إلى الصينية المبسطة
  language=zh
  ```

- **بديل:** تحرير سكريبت `modernz.lua`

  افتح `modernz.lua` وابحث عن قسم `user_opts` قرب البداية. غيّر قيمة `language` إلى رمز لغتك المفضل:

  ```lua
  local user_opts = {
      -- عام
      language = "en",  -- غيّر هذا إلى رمز لغتك المفضل
      ...
  }
  ```

**هل تحتاج لمزيد من المعلومات؟**

لقائمة كاملة باللغات المتاحة، إرشادات المساهمة، وشرح تفصيلي للترجمة، قم بزيارة [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md).

## السكريبتات الإضافية

السكريبتات التالية هي من كتابتي وأقوم بصيانتها، لا تتردد في استخدامها إذا كانت مفيدة لك.

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - سكريبت بسيط يعرض مؤشر عند التوقف المؤقت

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - سكريبت mpv بسيط يغير تلقائيًا `ytdl-format` (yt-dlp) للنطاقات المحددة.

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - سكريبت mpv بسيط يغير نسبة العرض إلى الارتفاع 4:3 لملفات/بث الفيديو إلى 16:9 تلقائيًا.

لمزيد من السكريبتات المفيدة، راجع [ويكي سكريبتات مستخدمي mpv](https://github.com/mpv-player/mpv/wiki/User-Scripts). يقدم مجموعة واسعة من السكريبتات التي ساهم بها المجتمع لتعزيز تجربة mpv الخاصة بك.

## التاريخ

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - مشتق من [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - مشتق من [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - مشتق من [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**لماذا التفرع مرة أخرى؟**

- لإضافة العديد من الميزات في: [تخصيص الألوان](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style)، [الخيارات](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md) و[تكامل اللغة](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- لدمج وحدة التحكم والتحديد في osc، مما ألهم mpv لتطبيقه في osc الافتراضي. [مرجع [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- لإضافة تخطيط مخصص للصور. [[التفاصيل](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- لإعادة تصميم المشروع بالكامل ليتوافق مع معايير osc الافتراضي لـ mpv، لضمان التوافق
- لإزالة الأخطاء القديمة والتكرار في الكود
    - مما يسمح للفروع الأخرى من `Modern` باستخدام ModernZ كأساس، مثل [zydezu/ModernX](https://github.com/zydezu/ModernX). [[مرجع](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

بالمجمل، للحفاظ على وإحياء أصل `modern-osc`.
مع ذلك، لا يزال ModernZ يستخدم أجزاءً من الكود القديم، ويستحق كل مؤلف ومساهم في الفروع السابقة والحالية التقدير (بما في ذلك osc الافتراضي الخاص بـ mpv)، ولهذا السبب يتم ذكرهم بالتفصيل.

#### الشكر:

- الخط: أيقونات نظام واجهة المستخدم Fluent [[التفاصيل](https://github.com/microsoft/fluentui-system-icons)] [[ملف الخط](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- الخط معدّل بواسطة [Xurdejl](https://github.com/Xurdejl) للاستخدام في ModernZ osc
- [mpv](https://github.com/mpv-player/mpv) و [osc.lua](https://github.com/mpv-player/mpv/blob/master/player/lua/osc.lua) الخاص بهم، حيث تم إعادة بناء ModernZ osc على معايير osc الافتراضية وتطبيق التحديثات منها
- جميع المصادر الأصلية لـ osc الحديثة وفروعها كما هو مذكور في [التاريخ](#history)
- جميع [المساهمين](https://github.com/Samillion/ModernZ/graphs/contributors) والمختبرين والمستخدمين الذين ساعدوا بشكل مباشر أو غير مباشر في ModernZ osc ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---