
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ar">العربیة</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# اوچ.یازی

[اوچ](https://github.com/ouch-org/ouch) افزونه‌ای برای [یازی](https://github.com/sxyazi/yazi) است.

![اوچ.یازی](https://github.com/ndtoan96/ouch.yazi/assets/33489972/946397ec-b37b-4bf4-93f1-c676fc8e59f2)

## ویژگی‌ها
- پیش‌نمایش آرشیو
- فشرده‌سازی

## نصب

### مدیر بسته یازی
```bash
ya pkg add ndtoan96/ouch
```

### Git
```bash
# Linux/macOS
git clone https://github.com/ndtoan96/ouch.yazi.git ~/.config/yazi/plugins/ouch.yazi

# Windows with cmd
git clone https://github.com/ndtoan96/ouch.yazi.git %AppData%\yazi\config\plugins\ouch.yazi

# Windows with powershell
git clone https://github.com/ndtoan96/ouch.yazi.git "$($env:APPDATA)\yazi\config\plugins\ouch.yazi"
```

اطمینان حاصل کنید که [ouch](https://github.com/ouch-org/ouch) نصب شده و در مسیر `PATH` شما قرار دارد.

## نحوه استفاده

### پیش‌نمایش
برای پیش‌نمایش آرشیو، این مورد را به `yazi.toml` خود اضافه کنید:

```toml
[[plugin.prepend_previewers]]
mime = "application/{*zip,tar,bzip2,7z*,rar,xz,zstd,java-archive}"
run  = "ouch"
```
اکنون به یک آرشیو در Yazi بروید، باید محتوای آرشیو را در پانل پیش‌نمایش ببینید. می‌توانید از کلیدهای `J` و `K` برای بالا و پایین بردن پیش‌نمایش استفاده کنید.

#### سفارشی‌سازی

پیش‌نمایش‌ها را می‌توان با افزودن آرگومان‌های اضافی در رشته‌ی `run` سفارشی‌سازی کرد:


```toml
[plugin]
prepend_previewers = [
	# Change the top-level archive icon
	{ ..., run = "ouch --archive-icon='🗄️ '" },
	# Or remove it by setting it to ''
	{ ..., run = "ouch --archive-icon=''" },

	# Enable file icons
	{ ..., run = "ouch --show-file-icons" },

	# Disable tree view
	{ ..., run = "ouch --list-view" },

	# These can be combined
	{ ..., run = "ouch --archive-icon='🗄️ ' --show-file-icons --list-view" },
]
```

### فشرده‌سازی
برای فشرده‌سازی، این مورد را به فایل `keymap.toml` خود اضافه کنید:

```toml
[[mgr.prepend_keymap]]
on = ["C"]
run = "plugin ouch"
desc = "Compress with ouch"
```

افزونه به طور پیش‌فرض از فرمت `zip` استفاده می‌کند. شما می‌توانید هنگام نام‌گذاری فایل خروجی، فرمت را تغییر دهید؛ `ouch` فرمت را بر اساس پسوند فایل تشخیص می‌دهد.

و برای مثال، اگر می‌خواهید فرمت پیش‌فرض را به `7z` تغییر دهید، می‌توانید از دستور `plugin ouch 7z` استفاده کنید.

### استخراج
این افزونه قابلیت استخراج را ارائه نمی‌دهد زیرا این ویژگی در یازی پشتیبانی می‌شود.
برای استخراج با `ouch`، بازکننده را در `yazi.toml` تنظیم کنید.

```toml
[opener]
extract = [
	{ run = 'ouch d -y %*', desc = "Extract here with ouch", for = "windows" },
	{ run = 'ouch d -y "$@"', desc = "Extract here with ouch", for = "unix" },
]
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---