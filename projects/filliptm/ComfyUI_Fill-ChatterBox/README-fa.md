<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

اگر از این پروژه لذت می‌برید، می‌توانید از من در Patreon حمایت کنید!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

یک افزونه نود سفارشی برای ComfyUI که با استفاده از کتابخانه Chatterbox قابلیت‌های تبدیل متن به گفتار (TTS) و تبدیل صدا (VC) را اضافه می‌کند.
حداکثر از ۴۰ ثانیه پشتیبانی می‌شود. تلاش کردم این محدودیت را حذف کنم، اما مدل در مدت طولانی‌تر به شدت دچار مشکل می‌شود، بنابراین این محدودیت باقی مانده است.

![نمونه ChatterBox](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## نصب

1. این مخزن را در پوشه custom_nodes مربوط به ComfyUI خود کلون کنید:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. وابستگی‌های پایه را نصب کنید:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (اختیاری) پشتیبانی از واترمارک را نصب کنید:

   ```bash
   pip install resemble-perth
   ```
  **توجه**: بسته `resemble-perth` ممکن است با نسخه Python 3.12+ ناسازگار باشد. اگر با خطاهای ایمپورت مواجه شدید، نودها همچنان بدون واترمارکینگ کار خواهند کرد.


## نحوه استفاده

### نود تبدیل متن به گفتار (FL Chatterbox TTS)
- نود "FL Chatterbox TTS" را به جریان کاری خود اضافه کنید
- ورودی متن و پارامترها (exaggeration، cfg_weight، temperature) را پیکربندی کنید
- در صورت تمایل یک پرامپت صوتی برای شبیه‌سازی صدا وارد کنید

### نود تبدیل صدا (FL Chatterbox VC)
- نود "FL Chatterbox VC" را به جریان کاری خود اضافه کنید
- ورودی صوت و صدای هدف را متصل کنید
- هر دو نود در صورت بروز خطای CUDA از CPU به عنوان پشتیبان پشتیبانی می‌کنند

## تغییرات

### ۲۴/۶/۲۰۲۵
- پارامتر seed به هر دو نود TTS و VC برای تولید قابل تکرار اضافه شد
- بازه seed: از ۰ تا ۴٬۲۹۴٬۹۶۷٬۲۹۵ (عدد صحیح ۳۲-بیتی)
- خروجی صوتی یکنواخت برای اشکال‌زدایی و کنترل جریان کاری را ممکن می‌سازد
- واترمارکینگ Perth اختیاری شد تا ناسازگاری با Python 3.12+ رفع شود
- اکنون نودها در صورت خطای ایمپورت resemble-perth بدون واترمارکینگ کار می‌کنند

### ۳۱/۵/۲۰۲۵
- بارگذاری مدل ماندگار و عملکرد نوار بارگذاری اضافه شد
- پشتیبانی از مک اضافه شد (نیاز به تست دارد، اگر خواستید اطلاع دهید)
- کتابخانه chatterbox-tts حذف شد و کد استنتاج بومی پیاده‌سازی شد.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---