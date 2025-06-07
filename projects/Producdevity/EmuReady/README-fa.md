# امو‌ردی (EmuReady)

یک پلتفرم مبتنی بر جامعه برای پیگیری سازگاری شبیه‌سازی در دستگاه‌ها و شبیه‌سازهای مختلف.

از وب‌سایت ما بازدید کنید: [https://emuready.com](https://emuready.com)

---

**تصویر صفحه اصلی**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**تصویر صفحه فهرست سازگاری**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**تصویر صفحه بازی‌ها**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## نمای کلی

امو‌ردی به کاربران کمک می‌کند اطلاعات سازگاری شبیه‌سازی را در پیکربندی‌های سخت‌افزاری و نرم‌افزاری مختلف به اشتراک بگذارند و کشف کنند. کاربران می‌توانند گزارش‌های سازگاری را ارسال کنند، به فهرست‌ها رأی دهند و درباره ترکیب‌های خاص بازی/دستگاه/شبیه‌ساز بحث کنند.

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## ویژگی‌ها

- **پایگاه داده جامع سازگاری**: پیگیری عملکرد بازی‌ها روی شبیه‌سازها و دستگاه‌های مختلف
- **مشارکت کاربران**: گزارش‌ها و سیستم رأی‌دهی مبتنی بر جامعه
- **سیستم بحث**: موضوعات نظردهی با قابلیت رأی مثبت و منفی
- **داشبورد مدیریت**: مدیریت کاربران، فهرست‌ها و محتوای سایت
- **طراحی واکنش‌گرا**: سازگار با موبایل، تبلت و دسکتاپ

## بهبودهای اخیر

پایه کد به طور قابل توجهی با بهبودهای زیر ارتقا یافته است:

### اجزای UI

- ایجاد کامپوننت **ErrorBoundary** برای مدیریت و بازیابی بهتر خطاها
- افزودن کامپوننت **OptimizedImage** با استفاده از کامپوننت Image از Next.js برای عملکرد بهتر
- بهبود **Pagination** با ویژگی‌های دسترسی‌پذیری، ناوبری با صفحه کلید و تجربه کاربری بهتر
- ارتقای کامپوننت **Badge** با انواع مختلف، اندازه‌های بیشتر و گزینه pill
- افزودن کامپوننت **ThemeToggle** برای تغییر بین تم روشن، تاریک و سیستم
- پیاده‌سازی **SortableHeader** برای مرتب‌سازی جداول با شاخص‌های بصری

### کشینگ و عملکرد

- بهبود تنظیمات React Query با پیش‌فرض‌های بهتر برای کشینگ، زمان ماندگاری و منطق تلاش مجدد
- بهینه‌سازی تصاویر برای تصاویر دستگاه‌ها
- پیاده‌سازی مدیریت خطای صحیح در سراسر برنامه

### دسترسی‌پذیری

- بهبود ناوبری با صفحه کلید برای اجزای تعاملی
- افزودن برچسب‌ها و نقش‌های ARIA مناسب
- بهبود مدیریت فوکوس
- تضاد رنگی بهتر در اجزای UI

### امنیت

- اعتبارسنجی و پاک‌سازی داده‌ها در سطوح مختلف (کلاینت، سرور، پایگاه داده)
- پیاده‌سازی Content Security Policy
- محافظت در برابر حملات XSS و CSRF
- احراز هویت امن با NextAuth.js
- اعتبارسنجی بارگذاری فایل و تدابیر امنیتی
- محدودیت طول ورودی و پاک‌سازی مناسب
- اعتبارسنجی UUID برای جلوگیری از دستکاری پارامترها

### تجربه توسعه‌دهنده

- افزودن اسکریپت‌های npm اضافی برای روند توسعه
- ساختار پروژه بهتر با خروجی‌های منسجم
- بازخورد خطای بهتر با ErrorBoundary سفارشی
- بهبود صفحه 404 با گزینه‌های ناوبری مفید

### تم‌دهی

- اضافه شدن تشخیص ترجیح تم سیستم
- ایجاد سوییچ تم با گزینه‌های متنوع در UI
- بهبود پیاده‌سازی حالت تاریک در اجزا

## شروع به کار

### پیش‌نیازها

- Node.js نسخه 20 یا بالاتر
- `npm`
- PostgreSQL (یا SQLite برای توسعه)

### نصب

1. مخزن را کلون کنید

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. وابستگی‌ها را نصب کنید

```bash
npm install
```

3. متغیرهای محیطی را تنظیم کنید

```bash
cp .env.example .env
```

سپس فایل `.env` را با اطلاعات پایگاه داده و سایر تنظیمات خود ویرایش کنید.

4. پایگاه داده را راه‌اندازی کنید

```bash
npx prisma generate
npx prisma db push
```

5. سرور توسعه را اجرا کنید

```bash
npm run dev
```

6. [http://localhost:3000](http://localhost:3000) را در مرورگر خود باز کنید

## اسکریپت‌های موجود

- `npm run dev` - اجرای سرور توسعه
- `npm run dev:strict` - اجرا با حالت strict ری‌اکت
- `npm run build` - ساخت برای تولید
- `npm run start` - اجرای سرور تولید
- `npm run test` - اجرای تست‌ها
- `npm run lint` - اجرای ESLint
- `npm run lint:fix` - رفع مشکلات lint
- `npm run format` - فرمت کد با Prettier
- `npm run typecheck` - بررسی نوع‌های TypeScript
- `npm run analyze` - تحلیل اندازه بسته
- `npm run clean` - پاک‌سازی کش ساخت
- `npm run prepare-deploy` - آماده‌سازی برای استقرار (lint، typecheck، test، build)

### دستورهای Prisma

- `npx prisma db seed` - مقداردهی اولیه پایگاه داده
- `npx prisma studio` - باز کردن Prisma Studio
- `npx prisma db pull` - دریافت شمای پایگاه داده
- `npx prisma db push` - ارسال شمای پایگاه داده

برای جزئیات بیشتر به [Prisma Cli Reference](https://www.prisma.io/docs/orm/reference/prisma-cli-reference) مراجعه کنید.

## تکنولوژی‌های استفاده شده

- **فریم‌ورک**: Next.js 15
- **ORM پایگاه داده**: Prisma
- **API**: tRPC
- **احراز هویت**: NextAuth.js
- **استایل‌دهی**: Tailwind CSS
- **مدیریت وضعیت**: React Query
- **بررسی نوع‌ها**: TypeScript
- **انیمیشن**: Framer Motion
- **اعتبارسنجی**: Zod، سیاست امنیت محتوا، اعتبارسنجی ورودی

## مشارکت

ما از مشارکت استقبال می‌کنیم! لطفاً برای اطلاعات بیشتر [راهنمای مشارکت](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) را ببینید.

## مجوز

این پروژه تحت مجوز MIT است - برای جزئیات به فایل [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) مراجعه کنید.

## منشور رفتار (در دست اقدام)

توجه داشته باشید که این پروژه از [منشور رفتار](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md) پیروی می‌کند. با مشارکت در این پروژه، شما با شرایط آن موافقت می‌کنید.

## امنیت (در دست اقدام)

در صورتی که آسیب‌پذیری امنیتی پیدا کردید، لطفاً برای گزارش آن از [سیاست امنیتی ما](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) پیروی کنید.

## تقدیر و تشکر

- همه [مشارکت‌کنندگان](https://github.com/Producdevity/emuready/graphs/contributors)
- جامعه شبیه‌سازی برای الهام و پشتیبانی

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---