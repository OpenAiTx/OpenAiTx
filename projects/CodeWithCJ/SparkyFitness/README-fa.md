# SparkyFitness - جایگزین سلف‌ هاست شده برای MyFitnessPal

SparkyFitness یک برنامه جامع برای مدیریت و پیگیری تناسب اندام است که برای کمک به کاربران در نظارت بر تغذیه، ورزش و اندازه‌گیری‌های بدن طراحی شده است. این برنامه ابزارهایی برای پیگیری پیشرفت روزانه، تعیین هدف و ارائه گزارش‌های تحلیلی جهت حمایت از سبک زندگی سالم فراهم می‌کند.


## ✨ امکانات

### 🍎 پیگیری تغذیه

* **ثبت وعده‌های غذایی روزانه**
* **ایجاد و مدیریت غذاها و دسته‌بندی‌های سفارشی**
* **مشاهده خلاصه‌ها و تحلیل روندها با نمودارهای تعاملی**

### 💪 ثبت تمرینات ورزشی

* **ثبت تمرینات ورزشی**
* **جستجو و مرور پایگاه داده جامع تمرینات ورزشی**
* **پیگیری پیشرفت تناسب اندام در طول زمان**

### 💧 پایش میزان مصرف آب

* **پیگیری اهداف روزانه هیدراسیون**
* **ثبت سریع و ساده مصرف آب**

### 📏 اندازه‌گیری‌های بدن

* **ثبت معیارهای بدن** (مانند وزن، دور کمر، بازوها)
* **افزودن انواع اندازه‌گیری سفارشی**
* **تصویری‌سازی پیشرفت از طریق نمودارها**

### 🎯 تعیین اهداف

* **تعیین و مدیریت اهداف تناسب اندام و تغذیه**
* **پیگیری پیشرفت در طول زمان**

### 🗓️ بازبینی‌های روزانه

* **پایش فعالیت‌های روزانه**
* **حفظ تداوم با پیگیری عادت‌ها**

### 🤖 مربی تغذیه هوشمند (SparkyAI)

* **ثبت غذا، ورزش، آمار بدنی و گام‌ها از طریق چت**
* **آپلود تصویر غذا برای ثبت خودکار وعده‌ها**
* **شامل تاریخچه چت و راهنمایی شخصی‌سازی شده**

### 🔒 احراز هویت کاربر و پروفایل‌ها

* **سیستم ورود امن**
* **امکان جابجایی بین پروفایل‌های کاربری**
* **پشتیبانی از دسترسی و مدیریت خانواده**

### 📊 گزارش‌های جامع

* **تولید خلاصه برای تغذیه و معیارهای بدن**
* **پیگیری روندهای بلندمدت طی هفته‌ها یا ماه‌ها**

### 🎨 تم‌های قابل شخصی‌سازی

* **تغییر بین حالت روشن و تاریک**
* **طراحی شده با رابط کاربری مینیمال و بدون حواس‌پرتی**

### نیاز به راهنمایی دارید؟
* **به دیسکورد بپیوندید**
  https://discord.gg/vcnMT5cPEA
* **در بحث‌ها پست بگذارید**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 شروع به کار

برای راه‌اندازی برنامه SparkyFitness روی دستگاه خود، مراحل زیر را دنبال کنید:

### پیش‌نیازها

*   **پروژه Supabase:** شما باید یک پروژه Supabase راه‌اندازی کنید.
    *   **ایجاد پروژه جدید در Supabase:** به [Supabase](https://app.supabase.com/) بروید و یک پروژه جدید بسازید. (در صورت تمایل می‌توانید پروژه Supabase را به صورت محلی نیز راه‌اندازی کنید.)
    *   آدرس پروژه و Anon Key را از تنظیمات پروژه خود (بخش API) دریافت کنید.
    *   **نکته مهم درباره احراز هویت Supabase:** پیکربندی URL را در تنظیمات احراز هویت Supabase مطابق دامنه خود به‌روزرسانی کنید. این مورد برای عملکرد صحیح دامنه و دریافت دعوت‌نامه ایمیل هنگام ثبت‌نام ضروری است. Supabase امکانات امنیتی گسترده و گزینه‌های SSO شخص ثالث ارائه می‌دهد؛ آن‌ها را مطابق نیاز پروژه پیکربندی کنید.
    *   استقرار خودکار پایگاه داده روی Supabase با IPV4 در نسخه رایگان فعال نیست. بنابراین باید شبکه خود را برای استفاده از اتصال IPV6 پیکربندی کنید. در غیر این صورت مهاجرت پایگاه داده با خطا مواجه می‌شود و باید به صورت دستی استقرار دهید.       


    

### نصب

1.  **پیکربندی متغیرهای محیطی:**
    یک فایل `.env` در پوشه private ایجاد کنید. اگر از Portainer استفاده می‌کنید، مستقیماً آن را در همان‌جا ایجاد کنید. 
    اطلاعات Supabase خود را اضافه کنید:
    ```
    VITE_SUPABASE_URL="YOUR_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="YOUR_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="YOUR_SUPABASE_PROJECT_REF"    
    ```

2.  **اجرا با Docker Compose:**
    ایمیج‌های Docker را دریافت کرده و سرویس‌ها را راه‌اندازی کنید:
    ```sh
    docker compose pull
    docker compose up -d
    ```

3.  **دسترسی به برنامه:**
    پس از راه‌اندازی سرویس‌ها، SparkyFitness را در مرورگر وب خود در این آدرس باز کنید:
    ```
    http://localhost:3000
    ```

4.  **پیکربندی اختیاری چت‌بات هوش مصنوعی:**
    برای فعال‌سازی کامل عملکرد چت‌بات هوش مصنوعی، شامل ذخیره‌سازی امن کلید API و دسترسی به پایگاه داده، مراحل زیر را دنبال کنید:

    *   **پیکربندی `AI_API_ENCRYPTION_KEY`:** یک کلید مخفی در "Supabase -> Edge Functions" -> "Environment Variables" ایجاد کنید. این کلید برای رمزنگاری کلیدهای هوش مصنوعی شما هنگام ذخیره‌سازی در Supabase استفاده می‌شود.

    *   **تولید `SUPABASE_ACCESS_TOKEN`:**
        1.  وارد کنسول Docker خود شوید.
        2.  دستور `supabase login` را اجرا کنید و از طریق URL ارائه‌شده احراز هویت نمایید.
        3.  توکن دسترسی را با اجرای دستور `cat ~/.supabase/access-token` دریافت کنید.
        4.  فایل `docker-compose.yml` یا تنظیمات Portainer خود را با این توکن به‌روزرسانی کرده و مجدد استقرار دهید.
        5.  پس از استقرار مجدد، وارد SparkyFitness شوید و سرویس هوش مصنوعی را با ارائه‌دهنده موردنظر خود پیکربندی کنید.
     

### استقرار دستی پایگاه داده و توابع در Supabase
**روش ۱:  
**اگر اتصال شبکه IPV6 ندارید، مهاجرت پایگاه داده با شکست مواجه می‌شود زیرا نسخه رایگان Supabase از اتصال مستقیم IPV4 پشتیبانی نمی‌کند.

   1. آخرین نسخه را دانلود و در رایانه خود از حالت فشرده خارج کنید.
   2. به پوشه پروژه بروید. Docker باید اجرا شود.
   3. دستورات زیر را اجرا کنید. (استقرار توابع فقط برای پیکربندی هوش مصنوعی لازم است. اگر به چت‌بات نیاز ندارید، این مرحله را رد کنید)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
دوباره Docker compose را اجرا کنید. برنامه Front end شروع به کار خواهد کرد.

**روش ۲:  
   1. آخرین نسخه را دانلود و در رایانه خود از حالت فشرده خارج کنید.  
   2. به پوشه پروژه بروید.  
   3. به مسیر supabase/migrations بروید. دستورات SQL را کپی کرده و یکی‌یکی به ترتیب صعودی در Supabase-->Project-->SQL Editor اجرا کنید.  
   4. [اختیاری] همین کار را برای supabase/functions/chat در صورت نیاز به چت‌بات هوش مصنوعی انجام دهید. فایل index.js را کپی کرده و در Supabase-->Project-->Edge Function-->Deploy new function اجرا کنید.  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---