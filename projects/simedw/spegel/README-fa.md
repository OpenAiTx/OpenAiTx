# اسپگل – بازتاب وب از طریق هوش مصنوعی

به طور خودکار وب‌سایت‌ها را به مارک‌داون بهینه‌شده برای نمایش در ترمینال بازنویسی می‌کند.
مقدمه وبلاگ را [اینجا بخوانید](https://simedw.com/2025/06/23/introducing-spegel/)

این یک اثبات مفهوم است، انتظار وجود باگ می‌رود اما می‌توانید آزادانه issue یا pull request ثبت کنید.

##  اسکرین‌شات
گاهی نمی‌خواهید کل داستان زندگی کسی را بخوانید تا به یک دستور پخت برسید
![نمونه دستور پخت](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## نصب

نیازمند پایتون ۳.۱۱ به بالا

```
pip install spegel
```
یا مخزن را کلون کنید و به صورت قابل ویرایش نصب کنید

```bash
# کلون کردن و ورود به دایرکتوری
$ git clone <repo-url>
$ cd spegel

# نصب وابستگی‌ها و CLI
$ pip install -e .
```

## کلیدهای API
اسپگل در حال حاضر فقط از Gemini 2.5 Flash پشتیبانی می‌کند، برای استفاده باید کلید API خود را در env قرار دهید

```
GEMINI_API_KEY=...
```


## نحوه استفاده

### اجرای مرورگر

```bash
spegel                # شروع با صفحه خوش‌آمدگویی
spegel bbc.com        # باز کردن مستقیم یک URL
```

یا به طور معادل:

```bash
python -m spegel      # شروع با صفحه خوش‌آمدگویی
python -m spegel bbc.com
```

### کنترل‌های پایه
- `/`         – باز کردن ورودی URL
- `Tab`/`Shift+Tab` – جابجایی بین لینک‌ها
- `Enter`     – باز کردن لینک انتخاب‌شده
- `e`         – ویرایش پرامپت LLM برای نمای فعلی
- `b`         – بازگشت
- `q`         – خروج

## ویرایش تنظیمات

اسپگل تنظیمات را از یک فایل پیکربندی TOML بارگذاری می‌کند. می‌توانید نماها، پرامپت‌ها و گزینه‌های رابط کاربری را شخصی‌سازی کنید.

**ترتیب جستجوی فایل پیکربندی:**
1. `./.spegel.toml` (دایرکتوری جاری)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

برای ویرایش تنظیمات:
1. کپی کردن کانفیگ نمونه:
   ```bash
   cp example_config.toml .spegel.toml
   # یا ایجاد ~/.spegel.toml
   ```
2. فایل `.spegel.toml` را در ویرایشگر مورد علاقه خود ویرایش کنید.

نمونه کد:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "این صفحه وب را به یک تجربه مرور عالی برای ترمینال تبدیل کن! ..."
```

---

برای اطلاعات بیشتر، کد را ببینید یا issue باز کنید!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---