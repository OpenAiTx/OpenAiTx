# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="assets/linux/icon_256.png">

مشغل تطبيقات متعدد المنصات يعتمد على الويب مع إضافات مبنية باستخدام React

> [!WARNING]
> يتم تطوير المشغل بواسطة مطور واحد في وقت فراغه.
> قد تكون التغييرات بطيئة ولكنها ثابتة
>
> من المحتمل أن تكون هناك تغييرات جذرية سيتم توثيقها في [سجل التغييرات](CHANGELOG.md).

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## العرض التوضيحي

عرض توضيحي قديم قليلاً

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## الميزات

- الأولوية للإضافات
  - الإضافات مكتوبة بلغة TypeScript
  - واجهة برمجة تطبيقات (API) للإضافات موسعة 
      - إنشاء واجهات مستخدم
      - أوامر تنفيذ لمرة واحدة
      - توفير قائمة من أوامر التنفيذ لمرة واحدة بشكل ديناميكي
      - عرض محتوى "مضمن" سريع مباشرةً تحت شريط البحث الرئيسي بناءً على القيمة المدخلة فيه
      - جلب المحتوى من الحافظة وإضافة محتوى إليها
  - يتم توزيع الإضافات كفرع منفصل في مستودع Git، مما يعني أن توزيع الإضافة لا يحتاج إلى أي خادم مركزي
  - معرفات الإضافات هي فقط روابط مستودعات Git
  - واجهة مستخدم مبنية على [React](https://github.com/facebook/react) للإضافات
    - تم تنفيذها باستخدام React Reconciler مخصص (بدون Electron)
  - [بيئة تشغيل جافاسكريبت Deno](https://github.com/denoland/deno)
    - يسمح Deno بتشغيل كود إضافات جافاسكريبت في بيئة معزولة لأمان أفضل
    - يجب على الإضافات تحديد الصلاحيات المطلوبة للعمل بشكل صريح
    - يُستخدم Node.js لتشغيل أدوات تطوير الإضافات، ولكن كمطور إضافة ستكتب دائماً كود يعمل على Deno
- مصمم مع مراعاة دعم تعدد المنصات منذ البداية
- يمكن تشغيل الأوامر والواجهات باستخدام اختصارات عالمية مخصصة
- يمكن تعيين اختصار بحث مخصص للأوامر أو الواجهات
- دعم السمات المخصصة
- الوظائف المدمجة يتم توفيرها عبر إضافات مرفقة
  - التطبيقات: يعرض التطبيقات المثبتة على النظام في نتائج البحث
    - تتابع الإضافة أيضاً النوافذ والتطبيقات المرتبطة بها، لذا عند فتح تطبيق مفتوح بالفعل سيتم بشكل افتراضي إظهار النافذة التي تم إنشاؤها سابقاً
      - ليس كل الأنظمة مدعومة حالياً. راجع [دعم الميزات](https://gauntlet.sh/docs/feature-support)
  - الآلة الحاسبة: تعرض نتيجة العمليات الرياضية مباشرةً تحت شريط البحث الرئيسي
    - يشمل تحويل العملات باستخدام أسعار الصرف
    - مدعوم بواسطة [Numbat](https://github.com/sharkdp/numbat)
- ترتيب نتائج البحث بناءً على التكرار والحداثة (Frecency)
   - Frecency هو مزيج من التكرار والحداثة
   - كلما زاد استخدام العنصر ارتفع ترتيبه في قائمة النتائج، ولكن العناصر التي تم استخدامها كثيراً في الماضي سيتم تصنيفها أقل من العناصر التي تم استخدامها بنفس العدد مؤخراً
   - يتم مطابقة النتائج لكل كلمة عبر جزء من الكلمة (substring)

##### دعم أنظمة التشغيل

##### رسمي
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### حسب الإمكانية
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland غير مدعوم بعد، راجع [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## البدء

### تثبيت Gauntlet

راجع [التثبيت](https://gauntlet.sh/docs/installation)

### الاختصار العالمي

يمكن فتح النافذة الرئيسية باستخدام اختصار عالمي أو أمر CLI:
- الاختصار العالمي (يمكن تغييره من الإعدادات)
  - ويندوز: <kbd>ALT</kbd> + <kbd>Space</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Space</kbd>
  - Linux Wayland
    - قد لا يكون الاختصار العالمي مدعوماً، راجع [دعم الميزات](https://gauntlet.sh/docs/feature-support)
    - الرجاء استخدام أمر CLI بدلاً من ذلك، وتشغيله باستخدام طريقة خاصة بمدير النوافذ
  - macOS: <kbd>CMD</kbd> + <kbd>Space</kbd>
- أمر CLI
  - `gauntlet open`

### تثبيت إضافة

يتم تثبيت الإضافات من واجهة الإعدادات. استخدم رابط مستودع Git الخاص بالإضافة لتثبيتها، مثال: `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### إنشاء إضافة خاصة بك

راجع [البدء في تطوير الإضافات](https://gauntlet.sh/docs/plugin-development/getting-started)

## التخصيص (السمات)

راجع [التخصيص](https://gauntlet.sh/docs/theming)

## بناء Gauntlet

ستحتاج إلى:
- NodeJS
- Rust
- مترجم Protobuf
- CMake (غير مستخدم مباشرةً في المشروع، لكنه مطلوب بواسطة إحدى التبعيات)
- على لينكس: `libxkbcommon-dev` (ملاحظة: قد يختلف الاسم حسب التوزيعة المستخدمة)

### التطوير

لبناء نسخة التطوير نفذ:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
في وضع التطوير (بدون ميزة "release") سيستخدم التطبيق مجلدات داخل مجلد المشروع فقط لتخزين الحالة أو الكاش، لتجنب التأثير على التثبيت العالمي

### النسخة غير المعبأة بعد

لبناء ملف تنفيذ للنسخة غير المعبأة بعد، نفذ:
```bash
npm ci
npm run build
cargo build --release --features release
```

### النسخة المعبأة
لبناء حزمة خاصة بنظام التشغيل، نفذ أحد الأوامر التالية:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

لكن إصدار النسخة الجديدة يجب أن يتم عبر GitHub Actions

## المساهمة

إذا كنت ترغب في المساعدة في بناء Gauntlet يمكنك ذلك بطرق أكثر من مجرد المساهمة بالكود:
- الإبلاغ عن خطأ أو مشكلة في واجهة المستخدم/تجربة المستخدم
- إنشاء إضافة

للمشاكل البسيطة لا تتردد في فتح تذكرة أو PR ومعالجتها بنفسك. 
للتغييرات الكبيرة يرجى التواصل مع المطورين عبر Discord (رابط الدعوة أعلى ملف README) والمناقشة أولاً.

جميع أنواع المساهمات مرحب بها.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---