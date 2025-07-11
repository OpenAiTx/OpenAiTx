# 🎫 BiliTickerStorm

## ⚙️ توضیحات سرویس

| نام سرویس             | توضیحات              | ملاحظات    |
| ------------------- | ------------------- | -------- |
| `ticket-master`     | سرویس اصلی کنترل، مسئول زمان‌بندی وظایف     | استقرار تک‌نمونه |
| `ticket-worker`     | Worker خرید بلیت، قابل مقیاس‌پذیری افقی | پشتیبانی از چند نمونه |
| `gt-python`         | سرویس پردازش کپچای تصویری       | استقرار تک‌نمونه |

---

## 🚀 مراحل سریع استقرار

> برای راه‌اندازی کلاستر می‌توانید به [راهنمای راه‌اندازی کلاستر](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md) مراجعه کنید.

<details> <summary><strong>📦 نصب از مخزن راه دور (توصیه‌شده)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. نصب Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` دایرکتوری فایل پیکربندی خرید بلیت است که برای کانتینر `ticket-master` مانت می‌شود. برای تولید فایل پیکربندی خرید بلیت از https://github.com/mikumifa/biliTickerBuy استفاده کنید.
> - `ticketWorker.pushplusToken` پیکربندی ارسال pushplus است. پس از تنظیم، می‌توانید اعلان‌های نتیجه خرید بلیت را دریافت کنید.
> - `ticketWorker.ticketInterval` فاصله زمانی بین تلاش‌های خرید بلیت به ثانیه است که به طور پیش‌فرض ۳۰۰ میلی‌ثانیه می‌باشد.
> - `ticketWorker.ticketTimeStart` زمان شروع برنامه‌ریزی شده است که فرمت آن `2025-05-20T13:14` می‌باشد. اگر مقداردهی نشود، به صورت پیش‌فرض پس از باز شدن کانتینر، خرید بلیت فوراً آغاز می‌شود.

### 3. ارتقاء Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 نصب Chart به‌صورت محلی</strong></summary>


### 1. نصب Chart

```bash
# کلون کردن مخزن
git clone https://github.com/mikumifa/biliTickerStorm
# استفاده از بسته Chart محلی
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. بروزرسانی Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 دستورات عمومی</strong></summary>

### ⏹ حذف نصب
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 سلب مسئولیت

این پروژه مطابق با پروانه MIT License ارائه شده و صرفاً برای یادگیری و پژوهش‌های شخصی مورد استفاده قرار می‌گیرد. لطفاً از استفاده این پروژه برای هرگونه فعالیت تجاری یا منفعت‌طلبانه خودداری فرمایید و همچنین هرگونه استفاده به منظور خرید خودکار، اقدامات غیرقانونی یا نقض قوانین پلتفرم‌های مربوطه اکیداً ممنوع است. کلیه عواقب ناشی از استفاده از این پروژه بر عهده کاربر بوده و هیچ ارتباطی با نویسنده ندارد.

در صورتی که این پروژه را fork یا استفاده می‌کنید، حتماً قوانین و مقررات مربوطه و همچنین قوانین پلتفرم هدف را رعایت فرمایید.

## 💡 درباره نرخ دسترسی و کنترل همزمانی
این پروژه در طراحی خود به طور جدی اصل «غیر تهاجمی بودن» را رعایت می‌کند تا از ایجاد هرگونه اختلال در سرورهای هدف (مانند Bilibili) جلوگیری شود.

تمامی بازه‌های زمانی بین درخواست‌های شبکه توسط کاربر قابل تنظیم است و مقدار پیش‌فرض آن شبیه‌سازی سرعت عملیات دستی یک کاربر معمولی است. برنامه به صورت پیش‌فرض به صورت تک‌ریسمانی اجرا می‌شود و هیچ وظیفه همزمانی ندارد. در صورت عدم موفقیت درخواست، برنامه تعداد محدودی تلاش مجدد انجام داده و بین هر بار تلاش تاخیر مناسبی ایجاد می‌کند تا از ایجاد درخواست‌های مکرر با فرکانس بالا جلوگیری شود. پروژه کاملاً متکی بر رابط‌های عمومی و ساختار صفحات وب پلتفرم بوده و هیچگونه روش مخرب مانند دور زدن کنترل ریسک یا ربایش API در آن وجود ندارد.
## 🛡️ بیانیه احترام به پلتفرم

در طراحی این برنامه تا حد امکان تلاش شده است تا فرکانس درخواست‌ها کنترل شود و از ایجاد هرگونه بار یا تاثیر قابل توجه بر سرورهای Bilibili جلوگیری گردد. این پروژه صرفاً برای اهداف آموزشی است و قابلیت استفاده در مقیاس وسیع یا با همزمانی بالا را ندارد و هیچ‌گونه رفتار مخرب یا قصد اختلال در خدمات را دنبال نمی‌کند.

در صورتی که در این پروژه محتوایی وجود دارد که حقوق قانونی شرکت Bilibili را نقض می‌کند، لطفاً از طریق ایمیل [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com) با من تماس بگیرید. من در اسرع وقت محتوای مربوطه را حذف کرده و این مخزن را پاک خواهم کرد. بابت هرگونه ناراحتی ایجاد شده، صمیمانه عذرخواهی می‌کنم و از درک و همراهی شما سپاسگزارم.

## 📄 مجوز

[مجوز MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---