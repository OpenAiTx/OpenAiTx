<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (به زودی)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (به زودی)</a> |
        | <a href="#" title="Coming soon">ไทย (به زودی)</a> |
        | <a href="#" title="Coming soon">Français (به زودی)</a>
        | <a href="#" title="Coming soon">Deutsch (به زودی)</a>
        | <a href="#" title="Coming soon">Español (به زودی)</a>
        | <a href="#" title="Coming soon">Italiano (به زودی)</a>
        | <a href="#" title="Coming soon">Русский (به زودی)</a>
        | <a href="#" title="Coming soon">Português (به زودی)</a>
        | <a href="#" title="Coming soon">Nederlands (به زودی)</a>
        | <a href="#" title="Coming soon">Polski (به زودی)</a>
        | <a href="#" title="Coming soon">العربية (به زودی)</a>
        | <a href="#" title="Coming soon">فارسی (به زودی)</a>
        | <a href="#" title="Coming soon">Türkçe (به زودی)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (به زودی)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (به زودی)</a>

      </div>
    </div>
  </details>
</div>

# تایم‌کپسول ال‌ال‌ام

*یک مدل زبانی که **از صفر** فقط با داده‌های مربوط به مکان‌ها و دوره‌های زمانی خاص آموزش داده شده تا سوگیری‌های مدرن را کاهش داده و صدای، واژگان و جهان‌بینی آن عصر را شبیه‌سازی کند.*

تصور کنید اگر یک مدل هوش مصنوعی فقط وانمود به تاریخی بودن نکند، بلکه واقعا تاریخی باشد.

نسخه‌های v0 و v0.5 بر پایه [nanoGPT توسط آندری کارپاتی](https://github.com/karpathy/nanoGPT) ساخته شده‌اند. اسکریپت‌های اصلی آموزش و معماری مدل متعلق به اوست.


نسخه v1 ساخته شده بر پایه [Phi 1.5 از مایکروسافت](https://huggingface.co/microsoft/phi-1_5)

## رفتار مدل و محدودیت‌ها

### **نسخه v0**

دستورهای اولیه نشان می‌دهد که مدل با زبان و رفتار مربوط به قرن ۱۸۰۰ پاسخ می‌دهد.
مثال: دستور: "Who art Henry?" و پاسخ داد: "I know that man, I have did not a black, the storm."

![نمونه خروجی TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- هیچ اشاره‌ای به مفاهیم مدرن ندارد
- عمدتاً واژگان مطابق با دوره تاریخی
- جملات عمدتاً نامنسجم هستند (انتظار می‌رود با داده آموزشی ~۱۸۷MB)

### **نسخه v0.5**

بهبود قابل توجه نسبت به نسخه v0.
- سبک نگارش ویکتوریایی، نقطه‌گذاری صحیح، جملات عمدتاً دستورزبانی
- نرخ بالای هذیان‌گویی واقعیات همچنان وجود دارد
- نویز OCR («Digitized by Google») هنوز در خروجی‌ها دیده می‌شود

![نمونه خروجی TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **نسخه v1**

اولین مدلی که توانست یک واقعه تاریخی واقعی را با یک شخصیت واقعی از مجموعه داده مرتبط کند.

مثال: دستور: "It was the year of our Lord 1834"

خروجی: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

در ابتدا فرض کردم که شاید اعتراضات به طور تصادفی همان سال رخ داده‌اند اما به این توجه کنید: ![اعتراض ۱۸۳۴](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### چرا این مهم است:

این اولین نمونه از مدلی است که سال را به یک واقعه تاریخی واقعی و یک فرد واقعی مرتبط با آن واقعه (لرد پالمرستون) وصل می‌کند. مدل‌های قبلی (v0 و v0.5) فقط می‌توانستند سبک نگارش قرن نوزدهم را تقلید کنند اما همیشه وقایع، افراد و حقایق را هذیان‌گویی می‌کردند. این نشان می‌دهد که مدل شروع به یادآوری اطلاعات از مجموعه داده کرده است.

## برنامه‌های آتی

- تقریباً ۱۷۵,۰۰۰ متن منتشر شده در لندن از ۱۸۰۰ تا ۱۸۷۵ در اینترنت آرکایو وجود دارد
- قصد دارم پیکره داده را گسترش داده و بیشتر پاک‌سازی کنم تا توانایی استدلال بهتری داشته باشد
- گسترش به مناطق و دوره‌های زمانی مختلف برای مدل‌های تاریخی بیشتر

## نحوه استفاده

این پروژه عمدتاً بر گردآوری داده‌های تاریخی، آماده‌سازی آن برای آموزش و ساخت توکنیزر تمرکز دارد. فرایند کامل آموزش LLM را پوشش نمی‌دهم، برای این منظور به nanoGPT نوشته Andrej Karpathy مراجعه کنید.

### مرحله ۱: گردآوری و آماده‌سازی متون تاریخی

- فایل‌های .txt از کتاب‌ها، اسناد و... دامنه عمومی را از دوره زمانی انتخابی خود جمع‌آوری کنید (مثلاً لندن ۱۸۰۰-۱۸۵۰)
- آن‌ها را در محدوده زمان/مکان انتخابی خود نگه دارید
- فایل‌های متنی را با یک اسکریپت یا به صورت دستی پاک‌سازی کنید و سربرگ/پاورقی پروژه گوتنبرگ، حاشیه‌نویسی مدرن یا خطاهای OCR را حذف کنید.

### مرحله ۲: ساخت توکنیزر سفارشی

- train_tokenizer.py یا train_tokenizer_hf.py را روی داده‌های پاک‌سازی شده اجرا کنید.
- این کار vocab.json و merges.txt را به شما می‌دهد
- این فایل‌ها واژگان و قواعد ادغام را برای مدل شما تعریف می‌کنند

### مرحله ۳: آموزش مدل خود

- برای فرایند آموزش یا مستندات معماری انتخابی خود به [nanoGPT توسط Andrej Karpathy](https://github.com/karpathy/nanoGPT) مراجعه کنید.

# پرسش‌های متداول

## آموزش زمانی انتخابی (Selective Temporal Training) چیست؟

آموزش زمانی انتخابی (STT) روشی در یادگیری ماشین است که همه داده‌های آموزشی به طور خاص برای قرار گرفتن در یک دوره زمانی تاریخی خاص انتخاب می‌شوند. این کار برای مدل‌سازی زبان و دانش آن دوره بدون تأثیر مفاهیم مدرن انجام می‌شود. به عنوان مثال، مدل فعلی من (v0.5) فقط با داده‌های ۱۸۰۰ تا ۱۸۷۵ آموزش دیده است، و از پایه آموزش داده شده تا خروجی آن منعکس‌کننده سبک زبانی و زمینه تاریخی همان دوره باشد.

## چرا فقط از فاین‌تیون یا LoRA استفاده نمی‌کنید؟

در این پروژه قصد دارم مدلی بسازم که از سوگیری‌های مدرن دور باشد. اگر مثل GPT-2 را فاین‌تیون کنم، قبلاً آموزش دیده و آن اطلاعات حذف نمی‌شود. اگر از پایه آموزش دهم، مدل واقعاً قدیمی خواهد بود و فقط وانمود نمی‌کند. هدف فعلی این پروژه ساخت مدلی است که فقط با دانش کتاب‌های لندن منتشر شده بین ۱۸۰۰ تا ۱۸۷۵ استدلال کند.

## از چه نوع داده‌ای برای آموزش استفاده کرده‌اید؟

از کتاب‌ها، اسناد حقوقی، روزنامه‌ها و نوشته‌های دیگر لندن ۱۸۰۰–۱۸۷۵ استفاده کرده‌ام. لیستی که لینک کرده‌ام (برای v0) حدوداً ۲۰۰ مورد دارد اما برای اولین آموزش فقط از ۵۰ فایل به حجم تقریبی ۱۸۷ مگابایت استفاده شد. می‌توانید لیست اسناد را مشاهده کنید:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt



اندازه مجموعه داده‌ها:
v0: حدود ۱۸۷ مگابایت
v0.5: حدود ۴۳۵ مگابایت
v1: حدود ۶.۲۵ گیگابایت

## اندازه مدل‌ها چقدر است؟

V0: ۱۶ میلیون پارامتر

V0.5: ۱۲۳ میلیون پارامتر

V1: ۷۰۰ میلیون پارامتر

# مشخصات آموزش؟

# V0/V0.5
کارت گرافیک: Geforce RTX 4060
پردازنده: i5-13400F
رم: ۱۶ گیگابایت DDR5.

# V1
کارت گرافیک: A100 اجاره‌ای

















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---