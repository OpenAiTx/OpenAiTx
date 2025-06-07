# EmuReady

منصة مدعومة من المجتمع لتعقب توافق المحاكيات عبر أجهزة ومحاكيات مختلفة.

قم بزيارة موقعنا الإلكتروني: [https://emuready.com](https://emuready.com)

---

**لقطة شاشة للصفحة الرئيسية**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**لقطة شاشة لصفحة قوائم التوافق**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**لقطة شاشة لصفحة الألعاب**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## نظرة عامة

يساعد EmuReady المستخدمين على مشاركة واكتشاف معلومات توافق المحاكاة عبر أجهزة وبرمجيات مختلفة. يمكن للمستخدمين المساهمة بتقارير التوافق، التصويت على القوائم، ومناقشة تركيبات محددة من الألعاب/الأجهزة/المحاكيات.

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## الميزات

- **قاعدة بيانات شاملة للتوافق**: تتبع أداء الألعاب على مختلف المحاكيات والأجهزة
- **مساهمات المستخدمين**: تقارير مدفوعة من المجتمع ونظام تصويت
- **نظام النقاش**: سلاسل تعليقات مع إمكانية التصويت بالإيجاب أو السلب
- **لوحة تحكم المسؤول**: إدارة المستخدمين، القوائم، والإشراف على المحتوى
- **تصميم متجاوب**: يعمل على الجوال، الجهاز اللوحي، وسطح المكتب

## التحسينات الأخيرة

تم تحسين قاعدة الشيفرة بشكل كبير من خلال التحسينات التالية:

### مكونات واجهة المستخدم

- إنشاء مكون **ErrorBoundary** لتحسين التعامل مع الأخطاء واستعادتها
- إضافة مكون **OptimizedImage** باستخدام مكون الصور في Next.js لأداء أفضل
- تحسين **التنقل بين الصفحات** بإضافة ميزات وصول أفضل، تنقل عبر لوحة المفاتيح، وتجربة مستخدم محسنة
- تعزيز مكون **Badge** بمزيد من المتغيرات والأحجام وخيار الحبة البيضاوية
- إضافة مكون **ThemeToggle** للتبديل بين الأنماط الفاتحة والداكنة وأنماط النظام
- تنفيذ **SortableHeader** لفرز الجداول مع مؤشرات بصرية

### التخزين المؤقت والأداء

- تحسين إعدادات React Query بقيم افتراضية أفضل للتخزين المؤقت، أوقات التحديث، ومنطق إعادة المحاولة
- إضافة تحسين الصور لصور الأجهزة
- تنفيذ معالجة الأخطاء الصحيحة في جميع أنحاء التطبيق

### الوصول

- تعزيز التنقل عبر لوحة المفاتيح للعناصر التفاعلية
- إضافة تسميات وأدوار ARIA بشكل صحيح
- تحسين إدارة التركيز
- تباين ألوان أفضل في مكونات واجهة المستخدم

### الأمان

- التحقق من صحة البيانات وتنقيتها على عدة مستويات (العميل، الخادم، قاعدة البيانات)
- تنفيذ سياسة أمان المحتوى
- الحماية من هجمات XSS وCSRF
- مصادقة آمنة باستخدام NextAuth.js
- التحقق من تحميل الملفات وتدابير الأمان
- تقييد طول المدخلات وتنقيتها بشكل صحيح
- التحقق من UUID لمنع التلاعب بالمعاملات

### تجربة المطور

- إضافة نصوص npm إضافية لسير العمل التطويري
- هيكل مشروع أفضل مع صادرات متسقة
- تعزيز ملاحظات الأخطاء باستخدام ErrorBoundary مخصص
- تحسين صفحة 404 بخيارات تنقل مفيدة

### الثيمات

- إضافة اكتشاف تفضيلات الثيم من النظام
- إنشاء تبديل للثيم مع عدة خيارات واجهة مستخدم
- تحسين تنفيذ النمط الداكن عبر المكونات

## بدء الاستخدام

### المتطلبات الأساسية

- Node.js 20+
- `npm`
- PostgreSQL (أو SQLite لأغراض التطوير)

### التثبيت

1. استنساخ المستودع

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. تثبيت التبعيات

```bash
npm install
```

3. إعداد متغيرات البيئة

```bash
cp .env.example .env
```

ثم قم بتحرير ملف `.env` بمعلومات قاعدة بياناتك وإعدادات التكوين الأخرى.

4. إعداد قاعدة البيانات

```bash
npx prisma generate
npx prisma db push
```

5. تشغيل خادم التطوير

```bash
npm run dev
```

6. افتح [http://localhost:3000](http://localhost:3000) في متصفحك

## السكريبتات المتوفرة

- `npm run dev` - بدء خادم التطوير
- `npm run dev:strict` - بدء التشغيل مع وضع React الصارم
- `npm run build` - بناء المشروع للإنتاج
- `npm run start` - بدء خادم الإنتاج
- `npm run test` - تشغيل الاختبارات
- `npm run lint` - تشغيل ESLint
- `npm run lint:fix` - إصلاح مشاكل التنسيق
- `npm run format` - تنسيق الشيفرة باستخدام Prettier
- `npm run typecheck` - التحقق من أنواع TypeScript
- `npm run analyze` - تحليل حجم الحزمة
- `npm run clean` - تنظيف ذاكرة بناء المشروع
- `npm run prepare-deploy` - التحضير للنشر (تنسيق، التحقق من الأنواع، اختبار، بناء)

### أوامر Prisma

- `npx prisma db seed` - تعبئة قاعدة البيانات بالبيانات الأولية
- `npx prisma studio` - فتح Prisma Studio
- `npx prisma db pull` - سحب بنية قاعدة البيانات
- `npx prisma db push` - دفع بنية قاعدة البيانات

راجع [مرجع Prisma CLI](https://www.prisma.io/docs/orm/reference/prisma-cli-reference) لمزيد من التفاصيل.

## حزمة التقنيات

- **الإطار**: Next.js 15
- **قاعدة بيانات ORM**: Prisma
- **واجهة برمجة التطبيقات**: tRPC
- **المصادقة**: NextAuth.js
- **تصميم الستايل**: Tailwind CSS
- **إدارة الحالة**: React Query
- **التحقق من الأنواع**: TypeScript
- **التحريك**: Framer Motion
- **التحقق**: Zod، سياسة أمان المحتوى، التحقق من المدخلات

## المساهمة

نرحب بجميع المساهمات! يرجى الاطلاع على [إرشادات المساهمة](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) لمزيد من التفاصيل.

## الرخصة

هذا المشروع مرخص بموجب رخصة MIT - راجع ملف [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) لمزيد من التفاصيل.

## قواعد السلوك (قريباً)

يرجى ملاحظة أن هذا المشروع يلتزم بـ [قواعد السلوك](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md). بمشاركتك في هذا المشروع، فإنك توافق على الالتزام بشروطها.

## الأمان (قريباً)

إذا اكتشفت ثغرة أمنية، يرجى اتباع [سياسة الأمان](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) للإبلاغ عنها.

## الشكر والتقدير

- جميع [المساهمين](https://github.com/Producdevity/emuready/graphs/contributors)
- مجتمع المحاكاة على الإلهام والدعم

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---