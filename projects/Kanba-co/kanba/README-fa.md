<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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
  <img alt="Vercel OSS Program" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# جایگزین سبک و متن‌باز Trello که برای سازندگان و برنامه‌نویسان مستقل طراحی شده است.

تمرکز بر سادگی، سرعت و مقیاس‌پذیری.
ساخته شده با فناوری‌های مدرن: Tailwind CSS، shadcn/ui، Supabase، و ادغام Stripe.
پشتیبانی از پروژه‌های نامحدود، همکاری تیمی، حالت تاریک/روشن و تجربه کاربری یکپارچه.
مناسب برای توسعه‌دهندگان فردی و تیم‌های کوچک که کنترل کامل بدون پیچیدگی اضافی می‌خواهند.

## 🌟 اگر این پروژه برای شما مفید بود، لطفاً به آن ستاره بدهید! این کار باعث می‌شود دیگران هم آن را کشف کنند.

# راهنمای استقرار

## نمای کلی
این برنامه اکنون به جای Supabase Edge Functions برای ادغام Stripe از مسیرهای محلی API در Next.js استفاده می‌کند. این کار استقرار را ساده‌تر کرده و به شما امکان می‌دهد از فایل‌های استاندارد .env برای پیکربندی استفاده کنید.

## راه‌اندازی متغیرهای محیطی

### ۱. ایجاد فایل .env.local
فایل `.env.example` را به `.env.local` کپی کرده و مقادیر واقعی خود را وارد کنید:


```bash
cp .env.example .env.local
```

### ۲. متغیرهای محیطی مورد نیاز

#### پیکربندی Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - آدرس پروژه Supabase شما
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - کلید ناشناس Supabase شما
- `SUPABASE_SERVICE_ROLE_KEY` - کلید نقش سرویس Supabase شما (فقط سمت سرور)

#### پیکربندی Stripe (اختیاری)
- `STRIPE_SECRET_KEY` - کلید مخفی Stripe شما (فقط سمت سرور)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - کلید عمومی Stripe شما
- `STRIPE_WEBHOOK_SECRET` - کلید مخفی webhook Stripe شما

#### پیکربندی سایت
- `NEXT_PUBLIC_SITE_URL` - آدرس سایت شما (برای محیط تولید)
- `NEXTAUTH_URL` - آدرس سایت شما (همانند بالا)
- `NEXTAUTH_SECRET` - یک مقدار تصادفی به عنوان رمز برای NextAuth

## توسعه محلی

۱. نصب وابستگی‌ها:
```bash
npm install
```

۲. متغیرهای محیطی خود را در فایل `.env.local` تنظیم کنید

۳. سرور توسعه را اجرا کنید:
```bash
npm run dev
```

4. وب‌هوک‌های Stripe را به صورت محلی با استفاده از Stripe CLI تست کنید:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## استقرار تولید


### استقرار در Vercel

1. **استقرار در Vercel:**
```bash
npx vercel
```
2. **متغیرهای محیطی:**
   همه متغیرهای محیطی را از طریق داشبورد یا CLI ورسل اضافه کنید

3. **راه‌اندازی Stripe Webhook:**
   - وب‌هوک را به این آدرس اشاره دهید: `https://your-domain.vercel.app/api/stripe/webhook`

## نقاط پایانی API

برنامه اکنون از این مسیرهای محلی API استفاده می‌کند:

- `POST /api/stripe/checkout` - ایجاد نشست پرداخت Stripe
- `POST /api/stripe/webhook` - مدیریت رویدادهای وب‌هوک Stripe

## مزایای مسیرهای محلی API

1. **استقرار ساده‌تر** - نیازی به استقرار توابع edge جداگانه نیست
2. **متغیرهای محیطی** - پشتیبانی استاندارد از فایل .env
3. **اشکال‌زدایی بهتر** - رفع اشکال محلی راحت‌تر است
4. **یکپارچگی با فریمورک** - یکپارچگی بهتر با Next.js
5. **عدم قفل‌شدگی به فروشنده** - قابلیت استقرار روی هر پلتفرمی که Next.js را پشتیبانی می‌کند

## رفع اشکال

1. **مشکلات وب‌هوک:**
   - اطمینان حاصل کنید که `STRIPE_WEBHOOK_SECRET` با نقطه پایانی وب‌هوک Stripe شما مطابقت دارد
   - لاگ‌های وب‌هوک را در داشبورد Stripe بررسی کنید
   - صحت آدرس URL وب‌هوک را تایید کنید

2. **متغیرهای محیطی:**
   - اطمینان حاصل کنید همه متغیرهای لازم تنظیم شده‌اند
   - وجود اشتباه تایپی در نام متغیرها را بررسی کنید
   - مطمئن شوید کلید نقش سرویس Supabase مجوزهای لازم را دارد

3. **مشکلات CORS:**
   - مسیرهای API شامل هدرهای CORS مناسب هستند
   - در صورت نیاز، اطمینان حاصل کنید دامنه شما در لیست سفید قرار گرفته است

## نکات امنیتی

- هرگز `STRIPE_SECRET_KEY` یا `SUPABASE_SERVICE_ROLE_KEY` را به سمت کاربر ارسال نکنید
- فقط برای متغیرهای سمت کاربر از پیشوند `NEXT_PUBLIC_` استفاده کنید
- به طور منظم رمزهای وب‌هوک خود را تغییر دهید
- تحویل وب‌هوک را در داشبورد Stripe پایش کنید



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---