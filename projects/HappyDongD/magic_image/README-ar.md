<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# الرسم السحري بالذكاء الاصطناعي

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

تطبيق للرسم بالذكاء الاصطناعي مبني على Next.js، ويتميز بالوظائف الرئيسية التالية:
- 🎨 يدعم نماذج ذكاء اصطناعي متعددة (Sora، DALL-E، GPT وغيرها) مع إمكانية إضافة نماذج مخصصة
- 🖼️ يوفر إمكانيات تحويل النص إلى صورة والصورة إلى صورة، مع دعم التعديل المرجعي المتعدد والتحرير المناطقي
- 🔐 جميع البيانات ومفاتيح API مخزنة محلياً لضمان الخصوصية والأمان
- 💻 يدعم استخدام الويب والتغليف كتطبيق سطح مكتب، مع توافق عبر الأنظمة

## تجربة مباشرة

رابط الوصول: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### لقطات من التطبيق

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="تطبيق لقطة 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="تطبيق لقطة 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="تطبيق لقطة 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="تطبيق لقطة 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="تطبيق لقطة 3" width="800" style="margin-bottom: 20px"/>
</div>

## الميزات

- 🎨 يدعم نماذج ذكاء اصطناعي متعددة
  - نموذج GPT Sora_Image
  - نموذج GPT 4o_Image
  - نموذج GPT Image 1
  - نموذج DALL-E 3
  - 🆕 نماذج مخصصة (دعم إضافة النماذج الخاصة)
- ✍️ تحويل النص إلى صورة
  - يدعم تخصيص العبارات التوضيحية
  - إمكانية اختيار نسبة أبعاد الصورة
  - يدعم أحجام صور متعددة
- 🖼️ تحويل الصورة إلى صورة
  - يدعم تحرير الصور
  - يدعم التحرير المناطقي باستخدام القناع
  - يدعم تعديل جودة الصورة
  - يدعم المراجع المتعددة (رفع عدة صور دفعة واحدة)
- 🔒 أمان البيانات
  - جميع الصور والسجلات المحفوظة محلياً فقط في المتصفح
  - يدعم تخصيص عنوان وكيل API
  - يدعم إعداد مفتاح API
- 📱 تصميم واجهة المستخدم
  - واجهة عصرية
  - تجربة تفاعل سلسة
  - عرض بصيغة Markdown
  - دعم تمييز الشيفرة البرمجية
- 🖥️ دعم عبر المنصات
  - يدعم التغليف كتطبيق سطح مكتب (Windows، macOS، Linux)
  - يدعم العمل دون اتصال (مع ضرورة إعداد واجهة API)

## حزمة التقنيات

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (تغليف تطبيقات سطح المكتب)

## التطوير المحلي

1. استنساخ المشروع

```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. تثبيت الاعتمادات

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. بدء تشغيل خادم التطوير

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. 访问 [http://localhost:3000](http://localhost:3000)

## حزم تطبيق سطح المكتب

يستخدم هذا المشروع Tauri لحزم تطبيقات سطح المكتب، ويدعم أنظمة Windows وmacOS وLinux.

### تجهيز البيئة

قبل حزم تطبيق سطح المكتب، يجب تثبيت الاعتمادات التالية:

1. **تثبيت Rust**:
   - زر [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - اتبع التعليمات لتثبيت Rust وCargo

2. **اعتمادات النظام**:
   - **Windows**: تثبيت [أدوات بناء Visual Studio C++‎](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: تثبيت أدوات سطر أوامر Xcode (`xcode-select --install`)
   - **Linux**: تثبيت الاعتمادات ذات الصلة، راجع [دليل Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)

### وضع التطوير


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### بناء تطبيقات سطح المكتب


```bash
# 构建桌面应用安装包
npm run desktop
```
بعد الانتهاء من البناء، يمكنك العثور على حزمة التثبيت الخاصة بالنظام في دليل `src-tauri/target/release/bundle`.

## النشر على Vercel

1. قم بعمل Fork لهذا المشروع إلى حساب GitHub الخاص بك

2. أنشئ مشروعاً جديداً على [Vercel](https://vercel.com)

3. استورد مستودع GitHub الخاص بك

4. اضغط على نشر

## تعليمات الاستخدام

1. في أول استخدام يجب إعداد مفتاح API
   - اضغط على "إعدادات المفتاح" في الزاوية اليمنى العليا
   - أدخل مفتاح API والعنوان الأساسي
   - اضغط على حفظ
   - يمكنك أيضاً الإعداد السريع عبر معلمات URL:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
    ملاحظة: يجب ترميز الأحرف الخاصة في عنوان URL باستخدام ترميز URL

2. اختيار وضع التوليد
   - توليد صورة من نص: توليد صورة من خلال وصف نصي
   - تعديل صورة: رفع صورة لتحريرها

3. ضبط معلمات التوليد
   - اختيار نموذج الذكاء الاصطناعي (نموذج مدمج أو مخصص)
   - ضبط نسبة أبعاد الصورة
   - تعديل جودة الصورة (وضع تعديل صورة)

4. إدارة النماذج المخصصة
   - انقر على أيقونة الإعداد بجانب مربع اختيار النموذج
   - إضافة نموذج جديد: أدخل اسم النموذج، قيمة النموذج، واختر نوع النموذج
   - تحرير نموذج: انقر على زر تحرير النموذج الموجود
   - حذف نموذج: انقر على زر حذف النموذج الموجود
   - اختيار نموذج: انقر على زر علامة الجمع لاختيار النموذج فورًا

5. شرح أنواع النماذج
   - تنسيق DALL-E: يستخدم واجهة توليد الصور (/v1/images/generations)
   - تنسيق OpenAI: يستخدم واجهة الدردشة (/v1/chat/completions)

6. توليد الصور
   - إدخال الكلمات الدلالية
   - النقر على زر "توليد صورة"
   - الانتظار حتى انتهاء التوليد

7. إدارة الصور
   - عرض السجلات السابقة
   - تحميل الصور المولدة
   - تحرير الصور الحالية

## ملاحظات هامة

- جميع الصور المولدة والسجلات تحفظ فقط في متصفحك المحلي
- استخدام وضع التصفح الخفي أو تغيير الجهاز سيؤدي إلى فقدان البيانات
- يرجى تحميل ونسخ الصور الهامة احتياطيًا في الوقت المناسب
- إعدادات API سيتم حفظها بأمان في متصفحك ولن ترفع إلى الخادم
- تحميل مصادر HTTP على مواقع HTTPS سيتم حظره من قبل المتصفح، سيقوم التطبيق بتحويل واجهات HTTP تلقائيًا إلى HTTPS

## إرشادات المساهمة

نرحب بتقديم Issues و Pull Requests للمساعدة في تحسين المشروع.

## الترخيص

هذا المشروع مرخص تحت [رخصة أباتشي 2.0](https://www.apache.org/licenses/LICENSE-2.0).

وفقًا للرخصة، يمكنك:
- ✅ الاستخدام التجاري: يمكنك استخدام البرنامج للأغراض التجارية
- ✅ التعديل: يمكنك تعديل كود البرنامج المصدر
- ✅ التوزيع: يمكنك توزيع البرنامج
- ✅ الاستخدام الشخصي: يمكنك استخدام البرنامج استخدامًا شخصيًا
- ✅ ترخيص براءات الاختراع: توفر هذه الرخصة أيضًا ترخيصًا للبراءات

ولكن يجب الالتزام بالشروط التالية:
- 📝 بيان الترخيص وحقوق النشر: يجب إرفاق الترخيص الأصلي وبيان حقوق النشر
- 📝 بيان التغييرات: يجب الإشارة إلى التغييرات الكبيرة على الكود الأصلي
- 📝 بيان العلامات التجارية: لا يجوز استخدام العلامات التجارية للمساهمين

---

## اشترِ لي كوب قهوة

إذا كان هذا المشروع مفيدًا لك، يمكنك دعمي بشراء كوب قهوة ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="رمز دفع WeChat" width="300" />
  <p>اشترِ لي كوب قهوة</p>
</div>

## معلومات التواصل

إذا كان لديك أي أسئلة أو اقتراحات، يمكنك التواصل معي عبر WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="معلومات تواصل WeChat" width="300" />
  <p>امسح رمز الاستجابة السريعة لإضافة WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---