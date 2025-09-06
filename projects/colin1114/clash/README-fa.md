
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">انگلیسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">ژاپنی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">کره‌ای</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">هندی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">تایلندی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">فرانسوی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">آلمانی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">اسپانیایی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">ایتالیایی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">روسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">پرتغالی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">هلندی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">لهستانی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">عربی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">ترکی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">ویتنامی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">اندونزیایی</a></p>
      </div>
    </div>
  </details>
</div>

تسریع CDN و محافظت امنیتی این پروژه توسط Tencent EdgeOne حمایت می‌شود.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

نویسنده این پروژه colin1114 است.

# 🚀 تبدیل‌کننده اشتراک Clash

یک ابزار آنلاین زیبا و قدرتمند برای تبدیل انواع لینک‌های اشتراک پروکسی به فرمت پیکربندی Clash. پشتیبانی از استقرار خودکار توسط Cloudflare Workers & Pages و ارائه سرویس تبدیل اشتراک سریع و قابل اعتماد.

## ✨ ویژگی‌های عملکردی

- 🎨 **رابط کاربری زیبا و مدرن** - با پس‌زمینه گرادیان و طراحی کارت‌مانند
- 🔄 **پشتیبانی از چندین پروتکل** - پشتیبانی از V2Ray، VLESS، Shadowsocks، Trojan و سایر پروتکل‌های رایج
- ☁️ **استقرار ابری** - شتاب‌دهی جهانی CDN از طریق Cloudflare Workers
- 📱 **طراحی واکنش‌گرا** - سازگاری کامل با دسکتاپ و موبایل
- ⚡ **تبدیل سریع** - تبدیل آنی لینک اشتراک به پیکربندی Clash
- 📋 **کپی هوشمند** - پشتیبانی از کپی یک‌کلیکی پیکربندی YAML تولیدشده، سازگار با انواع مرورگرها
- 📡 **تولید لینک اشتراک** - تولید خودکار لینک اشتراکی قابل ورود مستقیم به Clash
- 🌐 **دسترسی آنلاین به YAML** - ارائه چند روش دسترسی به فایل YAML:
  - 📡 لینک اشتراک: پشتیبانی از بروزرسانی خودکار کلاینت Clash
  - 🔗 مشاهده آنلاین: مشاهده مستقیم محتوای پیکربندی در مرورگر
  - 💾 دانلود فایل: دانلود فایل .yaml به صورت محلی
  - ⚡ دسترسی سریع: لینک دانلود ساده‌شده
- 🔧 **پشتیبانی UTF-8** - پشتیبانی کامل از نام و پیکربندی نودهای چینی
- 🆓 **کاملاً رایگان** - مبتنی بر سرویس رایگان Cloudflare، بدون محدودیت استفاده

## 📁 ساختار پروژه

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 شروع سریع

### روش اول: اجرای محلی

1. **کلون کردن پروژه**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **راه‌اندازی سرور محلی**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **دسترسی به برنامه**
   - مرورگر را باز کرده و به `http://localhost:8000` مراجعه کنید
   - در محیط محلی، پیکربندی نمونه نمایش داده می‌شود

### روش دوم: استقرار Cloudflare Workers

#### مرحله ۱: ایجاد Worker

1. به [Cloudflare Workers](https://workers.cloudflare.com/) مراجعه کنید
2. در حساب Cloudflare ثبت‌نام/ورود کنید
3. بر روی "Create a Worker" کلیک کنید
4. کد موجود در `worker.js` را به طور کامل در ویرایشگر کپی کنید
5. بر روی "Save and Deploy" کلیک کنید

#### مرحله ۲: استقرار با استفاده از Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### مرحله ۳: پیکربندی دامنه (اختیاری)

1. افزودن دامنه سفارشی در تنظیمات Worker
2. یا استفاده از دامنه پیش‌فرض ارائه‌شده توسط Cloudflare

### روش سوم: استقرار Cloudflare Pages

#### گزینه A: یکپارچه‌سازی با GitHub (توصیه‌شده)

1. **آماده‌سازی مخزن**
   - کد را به مخزن GitHub ارسال کنید
   - اطمینان حاصل کنید که همه فایل‌های مورد نیاز موجود باشند

2. **ایجاد پروژه Pages**
   - به [Cloudflare Pages](https://pages.cloudflare.com/) مراجعه کنید
   - مخزن GitHub خود را متصل کنید
   - مخزن پروژه را انتخاب کنید

3. **تنظیمات ساخت**
   - فرمان ساخت: خالی بگذارید یا `echo "No build required"`
   - پوشه خروجی ساخت: `/` (شاخه اصلی)
   - متغیرهای محیطی: نیازی به تنظیم ندارد

#### گزینه B: بارگذاری مستقیم

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ معماری فنی

### تکنولوژی‌های فرانت‌اند
- **HTML5** - زبان نشانه‌گذاری مدرن
- **CSS3** - طراحی واکنش‌گرا و افکت‌های انیمیشن
- **Vanilla JavaScript** - تعاملات سبک فرانت‌اند

### تکنولوژی‌های بک‌اند
- **Cloudflare Workers** - پلتفرم محاسبات لبه
- **Web APIs** - API استاندارد Fetch و پردازش پاسخ

### فرمت‌های پروتکل پشتیبانی‌شده
- **VMess** - پروتکل استاندارد V2Ray
- **VLESS** - پروتکل سبک V2Ray (پشتیبانی از Reality)
- **Shadowsocks** - پروتکل پراکسی کلاسیک
- **Trojan** - پروتکل پراکسی نوظهور

### نقاط پایانی API
- `GET /` - صفحه اصلی
- `POST /convert` - API تبدیل اشتراک
- `GET /clash/{config-id}` - دریافت فایل پیکربندی YAML (لینک اشتراک)
- `GET /yaml/{config-id}` - دانلود فایل پیکربندی YAML
- `OPTIONS /*` - درخواست پیش‌بررسی CORS

## 📖 راهنمای استفاده

### استفاده پایه

1. **وارد کردن لینک اشتراک**
   - لینک اشتراک پراکسی خود را در کادر ورودی بچسبانید
   - پشتیبانی از لینک اشتراک رمزگذاری‌شده با Base64

2. **تنظیم نام پیکربندی**
   - به صورت اختیاری برای فایل پیکربندی نام دلخواه تعیین کنید
   - پیش‌فرض "My Clash Config" است

3. **تبدیل پیکربندی**
   - روی دکمه "تبدیل اشتراک" کلیک کنید
   - منتظر بمانید تا تبدیل انجام شود
4. **استفاده از پیکربندی**
   - پیکربندی YAML تولید شده را کپی کنید
   - آن را در کلاینت Clash وارد کنید و استفاده نمایید

5. **استفاده از لینک اشتراک (توصیه‌شده)**
   - لینک اشتراک تولید شده را کپی کنید
   - اشتراک را در کلاینت Clash اضافه کنید
   - پیکربندی به صورت خودکار همگام‌سازی می‌شود، نیازی به بروزرسانی دستی نیست

### پیکربندی پیشرفته

پیکربندی تولید شده Clash شامل ویژگی‌های زیر است:

- **سیاست گروه پروکسی**
  - 🚀 انتخاب نود - انتخاب دستی پروکسی
  - ♻️ انتخاب خودکار - انتخاب خودکار بر اساس تست تأخیر
  - 🎯 اتصال مستقیم جهانی - اتصال مستقیم

- **پیکربندی DNS**
  - فعال‌سازی تحلیل DNS
  - پشتیبانی از حالت fake-ip
  - تقسیم DNS داخلی و خارجی

- **قوانین مسیریابی**
  - اتصال مستقیم به آدرس‌های محلی
  - اتصال مستقیم به IPهای داخلی
  - سایر ترافیک‌ها از طریق پروکسی

## 🔧 رفع مشکلات استقرار

### مشکلات رایج

#### 1. Wrangler نقطه ورود را پیدا نمی‌کند
**پیام خطا**: `Missing entry-point to Worker script`

**راه حل**:
- مطمئن شوید که فایل `wrangler.jsonc` در دایرکتوری اصلی پروژه وجود دارد
- بررسی کنید که فیلد `main` در `wrangler.jsonc` به `worker.js` اشاره کند


#### 2. GitHub Actions با شکست در استقرار مواجه شد
**راه‌حل**:
- در تنظیمات مخزن GitHub موارد زیر را به عنوان Secrets اضافه کنید:
  - `CLOUDFLARE_API_TOKEN`: توکن API کلودفلر
  - `CLOUDFLARE_ACCOUNT_ID`: شناسه حساب کلودفلر

#### 3. شکست در ساخت Pages
**راه‌حل**:
- فرمان ساخت را خالی یا `echo "No build required"` قرار دهید
- مطمئن شوید که مسیر خروجی ساخت بر روی `/` تنظیم شده است

### توضیحات فایل‌های پیکربندی استقرار

- **`wrangler.jsonc`**: پیکربندی Wrangler CLI برای استقرار Worker
- **`_headers`**: پیکربندی HTTP Header برای Cloudflare Pages
- **`.github/workflows/deploy.yml`**: پیکربندی استقرار خودکار GitHub Actions

## 🔧 پیکربندی سفارشی

### ویرایش گروه پراکسی

می‌توانید تابع `convertToClash` در `worker.js` را برای سفارشی‌سازی گروه پراکسی ویرایش کنید:

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### قوانین مسیریابی سفارشی

برای افزودن قوانین مسیریابی سفارشی، آرایه `rules` را ویرایش کنید:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 ویژگی‌های عملکرد

- **CDN جهانی** - Cloudflare با پوشش نقاط لبه در سراسر جهان
- **پاسخ سریع** - زمان پاسخ‌دهی متوسط < ۱۰۰ میلی‌ثانیه
- **دردسترس بودن بالا** - ۹۹.۹٪ قابلیت دسترسی سرویس
- **سقف رایگان** - روزانه ۱۰۰,۰۰۰ درخواست

## 🔒 توضیحات امنیتی

- **حریم خصوصی داده‌ها** - داده‌های اشتراک فقط در فرآیند تبدیل استفاده می‌شوند و ذخیره نمی‌شوند
- **رمزنگاری HTTPS** - تمام ارتباطات با رمزنگاری HTTPS انجام می‌شود
- **شفافیت متن‌باز** - کد منبع کامل منتشر شده و قابل بررسی توسط شماست

## 🤝 راهنمای مشارکت

از ارسال Issue و Pull Request استقبال می‌شود!

1. مخزن را Fork کنید
2. یک شاخه ویژگی بسازید (`git checkout -b feature/AmazingFeature`)
3. تغییرات را ثبت کنید (`git commit -m 'Add some AmazingFeature'`)
4. به شاخه ارسال کنید (`git push origin feature/AmazingFeature`)
5. Pull Request باز کنید

## 📝 تاریخچه بروزرسانی

### v1.1.0
- ✅ پشتیبانی از پروتکل VLESS (شامل انتقال امن Reality)
- ✅ بهبود سازگاری پروتکل‌ها

### v1.0.0
- ✅ تبدیل پایه‌ای اشتراک‌ها
- ✅ رابط کاربری زیبا
- ✅ پشتیبانی از Cloudflare Workers
- ✅ پشتیبانی از چندین پروتکل (VMess، Shadowsocks، Trojan)
- ✅ طراحی واکنش‌گرا
- ✅ قابلیت کپی با یک کلیک

## 📞 پشتیبانی و بازخورد

اگر در هنگام استفاده با مشکل مواجه شدید یا پیشنهادی دارید، لطفاً:

1. این سند README را مطالعه کنید
2. یک [Issue](../../issues) ارسال کنید
3. یک [Discussion](../../discussions) آغاز کنید

## 📄 مجوز

این پروژه تحت مجوز MIT منتشر شده است - جزئیات در فایل [LICENSE](LICENSE)

## 🙏 تقدیر و تشکر

- [Cloudflare Workers](https://workers.cloudflare.com/) - ارائه‌دهنده پلتفرم محاسبات لبه‌ای
- [Clash](https://github.com/Dreamacro/clash) - کلاینت پراکسی عالی
- حمایت همه مشارکت‌کنندگان و کاربران

---

⭐ اگر این پروژه برای شما مفید بود، لطفاً به آن یک ستاره بدهید! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---