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

<div align="center">
  <br />
<br />
<a href="https://kanba.co">
  <img alt="Kanba" src="https://www.kanba.co/dark-hero.png" style=" width: 800px " />
</a>
    <br />
<br />
</div>

<div align="center">
  <br />
<br />
<a href="https://vercel.com/oss">
  <img alt="برنامج Vercel OSS" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# بديل Trello مفتوح المصدر وخفيف الوزن صُمم للمبتكرين والمطورين المستقلين.

يركز على البساطة والسرعة وقابلية التوسع.
تم بناؤه باستخدام أحدث التقنيات: Tailwind CSS، shadcn/ui، Supabase، تكامل مع Stripe.
يدعم مشاريع غير محدودة، تعاون الفريق، الوضع الداكن/الفاتح، وتجربة مستخدم سلسة.
مثالي للمطورين الأفراد والفرق الصغيرة الذين يرغبون في تحكم كامل بدون تعقيد غير ضروري.

## 🌟 إذا وجدت هذا المشروع مفيدًا، فكر في منحه نجمة! هذا يساعد الآخرين في اكتشافه أيضًا.

# دليل النشر

## نظرة عامة
يستخدم هذا التطبيق الآن مسارات API المحلية لـ Next.js بدلاً من وظائف Supabase Edge لتكامل Stripe. هذا يجعل النشر أبسط ويسمح لك باستخدام ملفات .env القياسية للإعداد.

## إعداد متغيرات البيئة

### 1. إنشاء ملف .env.local
انسخ `.env.example` إلى `.env.local` واملأ القيم الفعلية الخاصة بك:


```bash
cp .env.example .env.local
```

### 2. متغيرات البيئة المطلوبة

#### إعدادات Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - عنوان مشروع Supabase الخاص بك
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - مفتاح Supabase المجهول الخاص بك
- `SUPABASE_SERVICE_ROLE_KEY` - مفتاح دور خدمة Supabase (للاستخدام من جانب الخادم فقط)

#### إعدادات Stripe (اختياري)
- `STRIPE_SECRET_KEY` - مفتاح Stripe السري الخاص بك (للاستخدام من جانب الخادم فقط)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - مفتاح Stripe القابل للنشر الخاص بك
- `STRIPE_WEBHOOK_SECRET` - سر Webhook الخاص بـ Stripe

#### إعدادات الموقع
- `NEXT_PUBLIC_SITE_URL` - عنوان موقعك (للإنتاج)
- `NEXTAUTH_URL` - عنوان موقعك (نفس القيمة أعلاه)
- `NEXTAUTH_SECRET` - سر عشوائي لـ NextAuth

## التطوير المحلي

1. تثبيت الاعتمادات:
```bash
npm install
```

٢. قم بإعداد متغيرات البيئة الخاصة بك في `.env.local`

٣. شغّل خادم التطوير:
```bash
npm run dev
```
٤. اختبر Webhooks الخاصة بـ Stripe محليًا باستخدام Stripe CLI:

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## النشر للإنتاج


### النشر على Vercel

1. **انشر على Vercel:**
```bash
npx vercel
```
2. **متغيرات البيئة:**
   أضف جميع متغيرات البيئة من خلال لوحة تحكم Vercel أو CLI

3. **إعداد Webhook لـ Stripe:**
   - وجه الـ webhook إلى: `https://your-domain.vercel.app/api/stripe/webhook`

## نقاط نهاية API

يستخدم التطبيق الآن مسارات API المحلية التالية:

- `POST /api/stripe/checkout` - ينشئ جلسات الدفع في Stripe
- `POST /api/stripe/webhook` - يتعامل مع أحداث webhook لـ Stripe

## فوائد مسارات API المحلية

1. **نشر أبسط** - لا حاجة لنشر وظائف edge منفصلة
2. **متغيرات البيئة** - دعم ملف .env القياسي
3. **تصحيح أفضل للأخطاء** - أسهل في التصحيح محليًا
4. **تكامل مع الإطار** - تكامل أفضل مع Next.js
5. **لا يوجد احتكار مزود** - يمكن النشر على أي منصة تدعم Next.js

## استكشاف الأخطاء وإصلاحها

1. **مشاكل الـ Webhook:**
   - تأكد من أن `STRIPE_WEBHOOK_SECRET` يطابق نقطة نهاية webhook في Stripe
   - تحقق من سجلات الـ webhook في لوحة تحكم Stripe
   - تحقق من صحة عنوان URL للـ webhook

2. **متغيرات البيئة:**
   - تأكد من تعيين جميع المتغيرات المطلوبة
   - تحقق من وجود أخطاء إملائية في أسماء المتغيرات
   - تحقق من أن مفتاح دور خدمة Supabase لديه الأذونات المناسبة

3. **مشاكل CORS:**
   - تتضمن مسارات API رؤوس CORS المناسبة
   - تأكد من أن نطاقك مضاف إلى القائمة البيضاء إذا لزم الأمر

## ملاحظات أمنية

- لا تعرض أبدًا `STRIPE_SECRET_KEY` أو `SUPABASE_SERVICE_ROLE_KEY` للعميل
- استخدم بادئة `NEXT_PUBLIC_` فقط لمتغيرات جهة العميل
- قم بتدوير أسرار webhook بانتظام
- راقب تسليم الـ webhook في لوحة تحكم Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---