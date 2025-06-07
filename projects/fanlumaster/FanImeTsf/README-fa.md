## FanImeTsf

این بخش TSF از [FanImeServer](https://github.com/fanlumaster/FanImeServer) است.

توجه: در حال حاضر فقط از برنامه‌های ۶۴ بیتی پشتیبانی می‌شود.

## نحوه ساخت

### پیش‌نیازها

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

مطمئن شوید که vcpkg و gsudo توسط **Scoop** نصب شده‌اند.

## مراحل ساخت

### ساخت

ابتدا مخزن را کلون کنید،

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

سپس محیط را آماده کنید،

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

سپس، کامپایل کنید،

```powershell
.\scripts\lcompile.ps1
```

### نصب

پاورشل را به عنوان ادمین اجرا کنید و مطمئن شوید گزینه سیستم `Enable sudo` را فعال کرده‌اید.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

سپس یک پوشه به نام `FanImeTsf` در `C:\Program Files\` بسازید و فایل `FanImeTsf.dll` را در آن کپی کنید،

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

سپس نصب کنید،

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### حذف نصب

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## تصاویر

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## نقشه راه

در حال حاضر فقط از شوانگ‌پین شیائوهه پشتیبانی می‌شود.

### چینی

- شوانگ‌پین شیائوهه
- چوان‌پین
- کدهای کمکی در استفاده از اجزای هانزی
- دیکشنری قابل سفارشی‌سازی
- موتور IME قابل سفارشی‌سازی
- اسکین‌های قابل سفارشی‌سازی
- جابجایی بین چینی ساده و سنتی
- تکمیل خودکار انگلیسی
- API ایمی ابری متن‌باز
- تغییر ظاهر پنجره کاندیدها بین حالت عمودی و افقی
- کلیدهای کنترلی: بیشتر قابلیت‌ها باید به‌طور آزادانه توسط کاربر فعال/غیرفعال یا سفارشی شوند

### پشتیبانی ژاپنی

شاید یک پروژه مجزا باشد.

و شاید پشتیبانی از برخی زبان‌های دیگر نیز اضافه شود.

### منابع

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---