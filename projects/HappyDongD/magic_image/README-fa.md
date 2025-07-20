<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">عربی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">اندونزیایی</a>
      </div>
    </div>
  </details>
</div>

# نقاشی جادویی هوش مصنوعی

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

یک برنامه نقاشی هوش مصنوعی مبتنی بر Next.js با امکانات اصلی زیر:
- 🎨 پشتیبانی از مدل‌های مختلف هوش مصنوعی (Sora، DALL-E، GPT و غیره) و افزودن مدل سفارشی
- 🖼️ ارائه قابلیت تولید تصویر از متن و تصویر به تصویر، پشتیبانی از چند مرجع تصویری و ویرایش منطقه‌ای
- 🔐 ذخیره‌سازی محلی تمام داده‌ها و کلیدهای API جهت حفظ حریم خصوصی
- 💻 پشتیبانی از نسخه وب و بسته‌بندی برنامه دسکتاپ، قابل استفاده در چند پلتفرم

## تجربه آنلاین

آدرس دسترسی: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### تصاویر برنامه

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="应用截图4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="应用截图4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="应用截图1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="应用截图2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="应用截图3" width="800" style="margin-bottom: 20px"/>
</div>

## ویژگی‌های کلیدی

- 🎨 پشتیبانی از مدل‌های مختلف هوش مصنوعی
  - مدل GPT Sora_Image
  - مدل GPT 4o_Image
  - مدل GPT Image 1
  - مدل DALL-E 3
  - 🆕 مدل سفارشی (پشتیبانی از افزودن مدل خصوصی)
- ✍️ قابلیت تولید تصویر از متن
  - پشتیبانی از واژه‌های کلیدی سفارشی
  - انتخاب نسبت تصویر
  - پشتیبانی از اندازه‌های مختلف تصویر
- 🖼️ قابلیت تولید تصویر از تصویر
  - پشتیبانی از ویرایش تصویر
  - پشتیبانی از ویرایش ماسک منطقه‌ای
  - پشتیبانی از تنظیم کیفیت تصویر
  - پشتیبانی از چند مرجع تصویری (بارگذاری همزمان چند تصویر)
- 🔒 امنیت داده‌ها
  - تمام تصاویر تولید شده و سوابق فقط در مرورگر محلی ذخیره می‌شوند
  - پشتیبانی از آدرس پراکسی API سفارشی
  - پشتیبانی از پیکربندی کلید API
- 📱 طراحی رابط کاربری
  - رابط کاربری مدرن
  - تجربه تعامل روان
  - نمایش با فرمت Markdown
  - پشتیبانی از برجسته‌سازی کد
- 🖥️ پشتیبانی چندپلتفرمی
  - قابلیت بسته‌بندی به عنوان برنامه دسکتاپ (ویندوز، مک، لینوکس)
  - پشتیبانی از استفاده آفلاین (نیاز به پیکربندی رابط API)

## پشته فناوری

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (بسته‌بندی برنامه دسکتاپ)

## توسعه محلی

1. کلون کردن پروژه

```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. نصب وابستگی‌ها

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. راه‌اندازی سرور توسعه

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. 访问 [http://localhost:3000](http://localhost:3000)

## بسته‌بندی برنامه دسکتاپ

این پروژه از Tauri برای بسته‌بندی برنامه دسکتاپ استفاده می‌کند و از سیستم‌عامل‌های Windows، macOS و Linux پشتیبانی می‌کند.

### آماده‌سازی محیط

پیش از بسته‌بندی برنامه دسکتاپ، باید وابستگی‌های زیر نصب شوند:

1. **نصب Rust**:
   - مراجعه به [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - نصب Rust و Cargo طبق راهنما

2. **وابستگی‌های سیستمی**:
   - **Windows**: نصب [ابزار ساخت Visual Studio C++](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: نصب ابزار خط فرمان Xcode (`xcode-select --install`)
   - **Linux**: نصب وابستگی‌های مرتبط، توضیحات بیشتر در [مستندات Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)

### حالت توسعه


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### ساخت برنامه دسکتاپ


```bash
# 构建桌面应用安装包
npm run desktop
```
پس از اتمام ساخت، می‌توانید بسته نصبی مربوط به سیستم را در پوشه `src-tauri/target/release/bundle` پیدا کنید.

## استقرار در Vercel

1. این پروژه را به حساب GitHub خود Fork کنید

2. در [Vercel](https://vercel.com) یک پروژه جدید ایجاد کنید

3. مخزن GitHub خود را وارد کنید

4. روی استقرار کلیک کنید

## راهنمای استفاده

1. برای اولین بار نیاز به پیکربندی کلید API دارید
   - روی "تنظیمات کلید" در بالا سمت راست کلیک کنید
   - کلید API و آدرس پایه را وارد کنید
   - روی ذخیره کلیک کنید
   - همچنین می‌توانید از طریق پارامتر URL به سرعت پیکربندی کنید:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
توجه: کاراکترهای خاص در URL باید کدگذاری URL شوند

2. انتخاب حالت تولید
   - تولید تصویر از متن: با توصیف متنی تصویر ایجاد کنید
   - ویرایش تصویر: با بارگذاری تصویر ویرایش انجام دهید

3. تنظیم پارامترهای تولید
   - انتخاب مدل هوش مصنوعی (مدل داخلی یا مدل سفارشی)
   - تنظیم نسبت تصویر
   - تنظیم کیفیت تصویر (در حالت ویرایش تصویر)

4. مدیریت مدل سفارشی
   - روی آیکون تنظیمات کنار جعبه انتخاب مدل کلیک کنید
   - افزودن مدل جدید: نام مدل، مقدار مدل و نوع مدل را وارد کنید
   - ویرایش مدل: روی دکمه ویرایش مدل موجود کلیک کنید
   - حذف مدل: روی دکمه حذف مدل موجود کلیک کنید
   - انتخاب مدل: با کلیک روی دکمه مثبت مدل را بلافاصله انتخاب و استفاده کنید

5. توضیح نوع مدل
   - قالب DALL-E: استفاده از رابط تولید تصویر (/v1/images/generations)
   - قالب OpenAI: استفاده از رابط گفتگو (/v1/chat/completions)

6. تولید تصویر
   - وارد کردن عبارت راهنما
   - کلیک روی دکمه "تولید تصویر"
   - منتظر بمانید تا تولید کامل شود

7. مدیریت تصاویر
   - مشاهده تاریخچه
   - دانلود تصاویر تولید شده
   - ویرایش تصاویر موجود

## نکات مهم

- همه تصاویر تولید شده و تاریخچه فقط در مرورگر محلی ذخیره می‌شوند
- استفاده از حالت ناشناس یا تعویض دستگاه باعث از دست رفتن داده‌ها می‌شود
- لطفاً به موقع تصاویر مهم را دانلود و پشتیبان‌گیری کنید
- پیکربندی API به طور امن در مرورگر شما ذخیره می‌شود و به سرور ارسال نمی‌شود
- بارگذاری منابع HTTP در سایت HTTPS توسط مرورگر مسدود می‌شود و برنامه به طور خودکار رابط HTTP را به HTTPS تبدیل می‌کند

## راهنمای مشارکت

ارسال Issue و Pull Request برای کمک به بهبود پروژه خوشامد می‌باشد.

## مجوز

این پروژه تحت مجوز [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0) ارائه شده است.

طبق این مجوز، شما می‌توانید:
- ✅ استفاده تجاری: می‌توانید نرم‌افزار را برای مصارف تجاری استفاده کنید
- ✅ ویرایش: می‌توانید کد منبع نرم‌افزار را ویرایش کنید
- ✅ توزیع: می‌توانید نرم‌افزار را توزیع کنید
- ✅ استفاده شخصی: می‌توانید نرم‌افزار را برای استفاده شخصی به کار ببرید
- ✅ مجوز ثبت اختراع: این مجوز همچنین مجوز ثبت اختراع را ارائه می‌دهد

اما باید شرایط زیر را رعایت کنید:
- 📝 اعلامیه مجوز و کپی‌رایت: باید مجوز اصلی و اعلامیه کپی‌رایت را درج کنید
- 📝 اعلام تغییرات: باید تغییرات اساسی در کد اصلی را اعلام کنید
- 📝 اعلامیه علائم تجاری: نباید از علائم تجاری مشارکت‌کنندگان استفاده کنید

---

## یک فنجان قهوه برای من بخرید

اگر این پروژه برای شما مفید بود، خوشحال می‌شوم یک فنجان قهوه برایم بخرید ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="کد پرداخت ویچت" width="300" />
  <p>یک فنجان قهوه برایم بخرید</p>
</div>

## اطلاعات تماس

اگر سؤال یا پیشنهادی دارید، خوشحال می‌شوم از طریق ویچت با من تماس بگیرید:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="اطلاعات تماس ویچت" width="300" />
  <p>کد QR را اسکن کنید و ویچت را اضافه نمایید</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---