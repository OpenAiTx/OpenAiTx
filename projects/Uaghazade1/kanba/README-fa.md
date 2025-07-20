<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">اندونزیایی</a>
      </div>
    </div>
  </details>
</div>

# یک جایگزین متن‌باز و سبک برای Trello، طراحی‌شده برای سازندگان و هکرهای مستقل.

تمرکز بر سادگی، سرعت و مقیاس‌پذیری.
ساخته‌شده با فناوری‌های مدرن: Tailwind CSS، shadcn/ui، Supabase، و یکپارچه‌سازی Stripe.
پشتیبانی از پروژه‌های نامحدود، همکاری تیمی، حالت تاریک/روشن و تجربه کاربری روان.
ایده‌آل برای توسعه‌دهندگان مستقل و تیم‌های کوچک که به کنترل کامل بدون پیچیدگی غیرضروری نیاز دارند.

## 🌟 اگر این پروژه برای شما مفید بود، با دادن یک ستاره از آن حمایت کنید! این کار به دیگران هم کمک می‌کند تا آن را پیدا کنند.

# راهنمای استقرار

## مرور کلی
این برنامه اکنون به جای استفاده از Supabase Edge Functions برای یکپارچه‌سازی Stripe، از مسیرهای API محلی Next.js استفاده می‌کند. این کار استقرار را ساده‌تر می‌کند و به شما امکان می‌دهد از فایل‌های استاندارد .env برای پیکربندی استفاده کنید.

## تنظیم متغیرهای محیطی

### 1. ساخت فایل .env.local
فایل `.env.example` را به `.env.local` کپی کرده و مقادیر واقعی خود را وارد کنید:


```bash
cp .env.example .env.local
```
### 2. متغیرهای محیطی مورد نیاز

#### پیکربندی Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - آدرس پروژه Supabase شما
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - کلید ناشناس Supabase شما
- `SUPABASE_SERVICE_ROLE_KEY` - کلید نقش سرویس Supabase شما (فقط سمت سرور)

#### پیکربندی Stripe (اختیاری)
- `STRIPE_SECRET_KEY` - کلید مخفی Stripe شما (فقط سمت سرور)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - کلید انتشار Stripe شما
- `STRIPE_WEBHOOK_SECRET` - کلید مخفی webhook در Stripe

#### پیکربندی سایت
- `NEXT_PUBLIC_SITE_URL` - آدرس سایت شما (برای محیط تولید)
- `NEXTAUTH_URL` - آدرس سایت شما (همانند بالا)
- `NEXTAUTH_SECRET` - یک کلید تصادفی برای NextAuth

## توسعه محلی

1. نصب وابستگی‌ها:

```bash
npm install
```
2. متغیرهای محیطی خود را در فایل `.env.local` تنظیم کنید

3. سرور توسعه را اجرا کنید:

```bash
npm run dev
```
4. وب‌هوک‌های Stripe را به صورت محلی با استفاده از Stripe CLI تست کنید:

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```
## استقرار در محیط تولید


### استقرار در Vercel

1. **استقرار در Vercel:**

```bash
npx vercel
```
2. **متغیرهای محیطی:**
   همه متغیرهای محیطی را از طریق داشبورد Vercel یا CLI اضافه کنید

3. **تنظیم Webhook استرایپ:**
   - آدرس webhook را به این صورت قرار دهید: `https://your-domain.vercel.app/api/stripe/webhook`

## نقاط پایانی API

این برنامه اکنون از این مسیرهای API محلی استفاده می‌کند:

- `POST /api/stripe/checkout` - ایجاد نشست‌های پرداخت استرایپ
- `POST /api/stripe/webhook` - مدیریت رویدادهای webhook استرایپ

## مزایای مسیرهای محلی API

1. **استقرار ساده‌تر** - نیازی به استقرار جداگانه edge functions نیست
2. **متغیرهای محیطی** - پشتیبانی استاندارد از فایل .env
3. **اشکال‌زدایی بهتر** - اشکال‌زدایی راحت‌تر به صورت محلی
4. **ادغام بهتر با فریم‌ورک** - ادغام بهتر با Next.js
5. **بدون وابستگی به فروشنده خاص** - امکان استقرار روی هر پلتفرمی که Next.js را پشتیبانی کند

## رفع اشکال

1. **مشکلات Webhook:**
   - اطمینان حاصل کنید که `STRIPE_WEBHOOK_SECRET` با endpoint مربوطه در استرایپ مطابقت دارد
   - لاگ‌های webhook را در داشبورد استرایپ بررسی کنید
   - صحت آدرس webhook را تأیید کنید

2. **متغیرهای محیطی:**
   - اطمینان حاصل کنید همه متغیرهای مورد نیاز تنظیم شده‌اند
   - وجود اشتباه تایپی در نام متغیرها را بررسی کنید
   - اطمینان حاصل کنید کلید نقش سرویس Supabase مجوزهای لازم را دارد

3. **مشکلات CORS:**
   - مسیرهای API دارای headerهای مناسب CORS هستند
   - اطمینان حاصل کنید دامنه شما در صورت نیاز در لیست سفید قرار دارد

## یادداشت‌های امنیتی

- هرگز `STRIPE_SECRET_KEY` یا `SUPABASE_SERVICE_ROLE_KEY` را در اختیار کلاینت قرار ندهید
- فقط برای متغیرهای سمت کاربر از پیشوند `NEXT_PUBLIC_` استفاده کنید
- کلیدهای مخفی webhook خود را به طور منظم تعویض کنید
- تحویل webhook را در داشبورد استرایپ پایش کنید



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---