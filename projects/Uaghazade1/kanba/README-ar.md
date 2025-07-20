<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# بديل Trello مفتوح المصدر وخفيف الوزن، مصمم للمطورين والمستقلين.

يركز على البساطة والسرعة وقابلية التوسع.
مبني بأحدث التقنيات: Tailwind CSS وshadcn/ui وSupabase وتكامل Stripe.
يدعم مشاريع غير محدودة، تعاون الفرق، الوضع الليلي/النهاري، وتجربة مستخدم سلسة.
مثالي للمطورين الفرديين والفرق الصغيرة الذين يرغبون في التحكم الكامل بدون تعقيد غير ضروري.

## 🌟 إذا وجدت هذا المشروع مفيدًا، فكر في منحه نجمة! هذا يساعد الآخرين أيضًا في اكتشافه.

# دليل النشر

## نظرة عامة
يستخدم هذا التطبيق الآن مسارات API المحلية لـ Next.js بدلاً من وظائف Supabase Edge لتكامل Stripe. هذا يجعل النشر أبسط ويسمح لك باستخدام ملفات .env القياسية لإعداد التكوين.

## إعداد متغيرات البيئة

### 1. إنشاء ملف .env.local
قم بنسخ `.env.example` إلى `.env.local` واملأ القيم الفعلية الخاصة بك:


```bash
cp .env.example .env.local
```
### 2. متغيرات البيئة المطلوبة

#### إعداد Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - عنوان مشروع Supabase الخاص بك
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - مفتاح Supabase المجهول الخاص بك
- `SUPABASE_SERVICE_ROLE_KEY` - مفتاح دور خدمة Supabase الخاص بك (للاستخدام من جهة الخادم فقط)

#### إعداد Stripe (اختياري)
- `STRIPE_SECRET_KEY` - مفتاح Stripe السري الخاص بك (للاستخدام من جهة الخادم فقط)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - مفتاح Stripe للنشر الخاص بك
- `STRIPE_WEBHOOK_SECRET` - سر Webhook الخاص بـ Stripe

#### إعداد الموقع
- `NEXT_PUBLIC_SITE_URL` - عنوان موقعك (للإنتاج)
- `NEXTAUTH_URL` - عنوان موقعك (نفس القيمة أعلاه)
- `NEXTAUTH_SECRET` - سر عشوائي لـ NextAuth

## التطوير المحلي

1. تثبيت التبعيات:

```bash
npm install
```
2. قم بإعداد متغيرات البيئة الخاصة بك في `.env.local`

3. شغّل خادم التطوير:

```bash
npm run dev
```
4. اختبر Webhooks الخاصة بـ Stripe محلياً باستخدام Stripe CLI:

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```
## النشر للإنتاج


### النشر على Vercel

1. **النشر على Vercel:**

```bash
npx vercel
```
2. **متغيرات البيئة:**
   أضف جميع متغيرات البيئة من خلال لوحة تحكم Vercel أو عبر CLI

3. **إعداد Webhook لـ Stripe:**
   - وجه الـ webhook إلى: `https://your-domain.vercel.app/api/stripe/webhook`

## نقاط النهاية لواجهة برمجة التطبيقات (API Endpoints)

يستخدم التطبيق الآن هذه المسارات المحلية لواجهة برمجة التطبيقات:

- `POST /api/stripe/checkout` - ينشئ جلسات دفع Stripe
- `POST /api/stripe/webhook` - يتعامل مع أحداث Webhook لـ Stripe

## فوائد المسارات المحلية لواجهة البرمجة

1. **نشر أبسط** - لا حاجة لنشر وظائف Edge منفصلة
2. **متغيرات البيئة** - دعم قياسي لملفات .env
3. **تصحيح الأخطاء بشكل أفضل** - أسهل في التصحيح محلياً
4. **تكامل مع الإطار البرمجي** - تكامل أفضل مع Next.js
5. **لا يوجد اعتماد على جهة واحدة** - يمكن النشر على أي منصة تدعم Next.js

## استكشاف الأخطاء وإصلاحها

1. **مشاكل Webhook:**
   - تأكد من أن `STRIPE_WEBHOOK_SECRET` يطابق نقطة نهاية webhook في Stripe
   - تحقق من سجلات webhook في لوحة تحكم Stripe
   - تحقق من صحة عنوان URL الخاص بالـ webhook

2. **مشاكل متغيرات البيئة:**
   - تأكد من ضبط جميع المتغيرات المطلوبة
   - تحقق من عدم وجود أخطاء إملائية في أسماء المتغيرات
   - تحقق أن مفتاح دور خدمة Supabase لديه الصلاحيات المناسبة

3. **مشاكل CORS:**
   - تشمل مسارات API رؤوس CORS المناسبة
   - تأكد من إدراج نطاقك في القائمة البيضاء إذا لزم الأمر

## ملاحظات الأمان

- لا تعرض أبداً `STRIPE_SECRET_KEY` أو `SUPABASE_SERVICE_ROLE_KEY` للعميل
- استخدم بادئة `NEXT_PUBLIC_` فقط للمتغيرات الخاصة بالعميل
- قم بتدوير أسرار الـ webhook بشكل منتظم
- راقب تسليم webhook في لوحة تحكم Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---