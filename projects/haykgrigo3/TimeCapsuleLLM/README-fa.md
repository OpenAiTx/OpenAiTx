<div align="right">
  <details>
<summary>🌐 زبان</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# تایم‌کپسول ال‌ال‌ام

*یک مدل زبانی که **از پایه** تنها بر اساس داده‌های مکان‌ها و دوره‌های زمانی خاص آموزش دیده تا تعصبات مدرن را کاهش دهد و صدای، واژگان و جهان‌بینی آن دوران را بازنمایی کند.*

تصور کنید اگر یک مدل هوش مصنوعی فقط تظاهر به تاریخی بودن نمی‌کرد، بلکه واقعا تاریخی بود.

نسخه v0 و v0.5 بر پایه [nanoGPT از آندری کارپاتی](https://github.com/karpathy/nanoGPT) ساخته شده‌اند. اسکریپت‌های اصلی آموزش و معماری مدل، کار اوست.

نسخه v1 بر پایه [Phi 1.5 از مایکروسافت](https://huggingface.co/microsoft/phi-1_5) ساخته شده است.

نسخه v2 بر پایه llamaforcausallm ساخته شده است.

[لینک Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## وضعیت پژوهش
این پروژه به طور مستقل آغاز و توسعه یافته است.

در حال حاضر تحت نظارت دانشگاهی و با همکاری پژوهشی وابسته به کالج مولنبرگ انجام می‌شود.

## استناد

اگر از این پایگاه داده یا مدل در کارهای علمی استفاده می‌کنید، لطفاً به شکل زیر ارجاع دهید:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## رفتار مدل و محدودیت‌ها

### **v0**  

در ابتدای کار، مدل با زبان و رفتار قرن ۱۸۰۰ پاسخ می‌دهد.  
نمونه: درخواست: "چه کسی هنری است؟" و پاسخ داد: "من آن مرد را می‌شناسم، من کاری نکردم، طوفان."  

![نمونه خروجی TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- هیچ اشاره‌ای به مفاهیم مدرن ندارد  
- عمدتاً واژگان دقیق دوره تاریخی  
- جملات عمدتاً بی‌معنی (با توجه به داده‌های آموزشی ~۱۸۷MB قابل انتظار است)

### **v0.5** 

پیشرفتی قابل توجه نسبت به v0.  
- سبک نگارش ویکتوریایی، نشانه‌گذاری صحیح، جملات عمدتاً دستوری  
- هنوز نرخ بالای توهمات واقعی  
- نویز OCR ("Digitized by Google") هنوز در خروجی‌ها وجود دارد

![نمونه خروجی TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

اولین مدل که توانست یک رویداد تاریخی واقعی را با یک شخصیت واقعی از مجموعه داده‌ها مرتبط کند.

نمونه: درخواست: "سال ۱۸۳۴ میلادی بود"

خروجی: "سال ۱۸۳۴ میلادی بود و خیابان‌های لندن پر از اعتراض و دادخواست بود. علت، همانطور که بسیاری نقل کردند، به طور خصوصی مطرح نشد، بلکه همان روز توسط لرد پالمرستون پیگیری شد و مردم بیانیه کوتاهی از مشکلاتی که قانون به آن‌ها رسیده دریافت خواهند کرد. بسیار جای تأسف دارد که وقایع فعلی در تاریخ جهان روشن است و در نتیجه شناخته خواهد شد. درست نیست که همان کسانی که اولین بار انجیل را در اورشلیم منتشر کردند، باید چنین رکورد گسترده و جالبی از رونق و شکوفایی داشته باشند."

در ابتدا تصور کردم که اعتراض به طور اتفاقی همان سال رخ داده است اما به این تصویر توجه کنید: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

با استفاده از نمونه‌ای ۱۵GB از مجموعه داده ۹۰GB نسخه v2 آموزش داده شده است.
مدل فقط تا ۱۰ هزار گام آموزش دیده است.

مشکلی در توکنایزیشن وجود داشت که باعث شد خروجی به این صورت باشد:

چارلز دیکنز کیست؟



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
اصلاح‌شده:

"چارلز دیکنز کیست؟ آیا این اثر بیشتر از آثار فوق‌العاده و برانگیزاننده‌اش در نمایشنامه‌ها یا در مزرعه شرکت بزرگ است؟ هنوز چه چیزی باید از جک پیکت نقل کنم؟ آیا نمی‌دانید که آن‌ها نوعی تاخت‌وتاز یا اره کردن سینه‌های خود بودند، یا چه باید کرد زمانی که جکسون از پنجره نگاه می‌کرد؟ موفقیت یک انگلیسی چیست، و چیزی که پسرش هنوز برای من کشف نکرده است، که به واسطه آن بتوان چنین وزنی را به انجام رساند؟ آیا تا به حال راهی به جاده قدیمی باز کرده‌اید، یا تا نسیم لنگر در پای قایق ما، که باید ما را ترک کنید؟ واقعیت این است که چه باد از دشت در شب شنبه یا ظهر، یا تا شمال یا به گونه‌ای دیگر بلند شود یا نه، ما ناچار خواهیم بود مانعی سهمگین را توصیف کنیم، با همان اثراتی که اکنون هست. دست‌کم در این وضعیت نمی‌توان گفت که ما آن اتاق را ترک نکرده‌ایم. معتقدم سه نسخه در «پانصدبرابر» وجود دارد که باید به آن‌ها اشاره شود، به عنوان اولین شماره از خوانندگان ما که مایل‌اند...[ا]..."

### **v2mini-eval2**

با استفاده از همان نمونه ۱۵ گیگابایتی که برای آموزش eval1 استفاده شد، آموزش داده شده است.
مدل دوباره فقط تا ۱۰ هزار گام آموزش دیده است.

پرامپت: چارلز داروین

چارلز داروینECCEMACY. آقا، — مورد زیر برای من جالب است: — من دو هفته در لندن بودم و به شدت دچار حمله روماتیسم شدم. اولین حمله روماتیسم یک هفته پیش از دیدار با شما بود، و دومی زمانی که شما را دیدم، و سومی نیز همزمان با آن بود. دومین حمله نقرس اما با هیچ‌گونه علائم تب همراه نبود، اما با افزایش جریان ادرار و تخلیه بیشتر ادرار همراه بود. سومین حمله یک ساعت پس از دیدار با شما رخ داد و با بازگشت حمله‌ای از نقرس و بازگشتی سریع‌تر از نقرس همراه بود. چهارمین حمله نیز با تب همراه بود اما همیشه با علائم تب همراه نبود. سومین حمله نقرس دو هفته پس از بیماری شما بود و چهارمی با حمله‌ای از نقرس دنبال شد. چهارمین حمله دو هفته پس از حمله به شما بود و با احساسی همراه بود

### **v2**

با استفاده از یک مجموعه داده ۹۰ گیگابایتی (۱۱۲ گیگابایت توکنیزه شده) آموزش دیده است
تا ۱۸۲ هزار گام آموزش داده شده است

![نمونه خروجی TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![نمونه خروجی TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  مجموعه‌داده‌ها

### **v2**

- ۹۰ گیگابایت (خام) از متون لندن در سال‌های ۱۸۰۰ تا ۱۸۷۵
- ۱۳۶,۳۴۴ سند
- کل مجموعه داده توکنیزه شده اکنون اینجا در دسترس است: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### آمار سوگیری 
  ![سوگیری ضمیر](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![سوگیری جغرافیایی](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![سوگیری زمانی](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

برای اطلاعات بیشتر به [گزارش سوگیری v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) مراجعه کنید.


## چگونه استفاده کنیم

این پروژه عمدتاً بر جمع‌آوری داده‌های تاریخی، آماده‌سازی آن برای آموزش و ساخت توکنایزر تمرکز دارد. من فرآیند کامل آموزش LLM را پوشش نمی‌دهم، برای آن به nanoGPT نوشته‌ی Andrej Karpathy مراجعه کنید.

### مرحله ۱: جمع‌آوری و آماده‌سازی متون تاریخی

- فایل‌های .txt کتاب‌ها، اسناد و غیره را از حوزه عمومی و دوره زمانی مورد نظر خود جمع‌آوری کنید (مثلاً لندن ۱۸۰۰-۱۸۵۰)
- آن‌ها را در پنجره زمانی/مکانی انتخابی خود نگه دارید
- فایل‌های متنی را با اسکریپت یا به صورت دستی پاک‌سازی کنید، سربرگ/پاورقی‌های پروژه گوتنبرگ، حاشیه‌نویسی‌های مدرن یا خطاهای OCR را حذف نمایید.

### مرحله ۲: ساخت توکنایزر سفارشی

- train_tokenizer.py یا train_tokenizer_hf.py را روی داده‌های پاک شده اجرا کنید.
- این کار vocab.json و merges.txt را به شما می‌دهد.
- این فایل‌ها واژگان و قوانین ادغام مدل شما را تعریف می‌کنند.

### مرحله ۳: آموزش مدل شما

- برای فرآیند آموزش یا مستندات معماری انتخابی، به [nanoGPT نوشته‌ی Andrej Karpathy](https://github.com/karpathy/nanoGPT) مراجعه کنید.

# سوالات متداول

## آموزش انتخابی زمانی چیست؟

آموزش انتخابی زمانی (STT) رویکردی در یادگیری ماشین است که تمام داده‌های آموزشی به طور خاص در یک دوره تاریخی معین گردآوری می‌شوند. این کار برای مدل‌سازی زبان و دانش آن عصر بدون تأثیر مفاهیم مدرن انجام می‌شود. مثلاً مدل فعلی من (v0.5) فقط با داده‌های ۱۸۰۰-۱۸۷۵ آموزش دیده، از ابتدا آموزش داده شده و نه به صورت fine-tune؛ بنابراین خروجی آن سبک زبانی و زمینه تاریخی همان دوره را منعکس می‌کند.

## چرا فقط از fine-tuning یا LoRA استفاده نمی‌کنید؟

در این پروژه هدفم ساخت مدل زبانی است که از سوگیری مدرن دور باشد. اگر چیزی مثل GPT-2 را fine-tune کنم، آن قبلاً آموزش دیده و آن اطلاعات از بین نمی‌رود. اگر از ابتدا آموزش بدهم، مدل زبانی فقط واقعاً قدیمی خواهد بود و تظاهر نمی‌کند. هدف فعلی این پروژه ساخت مدلی است که فقط با دانش کتاب‌های لندن ۱۸۰۰ تا ۱۸۷۵ استدلال کند.

## چه نوع داده‌هایی برای آموزش استفاده کردید؟

من از کتاب‌ها، اسناد حقوقی، روزنامه‌ها و نوشته‌های دیگر لندن ۱۸۰۰–۱۸۷۵ استفاده کردم. لیستی که پیوند داده‌ام (برای v0) حدود ۲۰۰ مورد دارد اما برای اولین آموزش فقط ۵۰ فایل حدود ~۱۸۷ مگابایت استفاده کردم. می‌توانید لیست اسناد را مشاهده کنید:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

اندازه‌های دیتاست:
- v0: ~۱۸۷MB
- v0.5: ~۴۳۵MB
- v1: ~۶.۲۵GB

- v2mini-eval1: ۱۵ گیگابایت (نمونه‌ای از ۹۰ گیگابایت v2)
- v2: ۹۰ گیگابایت

## اندازه مدل‌ها چقدر است؟

v0: ۱۶ میلیون پارامتر

v0.5: ۱۲۳ میلیون پارامتر

v1: ۷۰۰ میلیون پارامتر

v2mini-eval1: ۳۰۰ میلیون پارامتر

v2mini-eval2: ۲۰۰ میلیون پارامتر

v2: ۱.۲ میلیارد پارامتر

## مشخصات آموزش؟

### v0/v0.5
کارت گرافیک: Geforce RTX 4060
پردازنده: i5-13400F
رم: ۱۶ گیگابایت DDR5.

### v1
کارت گرافیک: اجاره‌ای A100 SXM

### v2mini-eval1/eval2
کارت گرافیک: اجاره‌ای A100 SXM

### v2
کارت گرافیک: اجاره‌ای H100 SXM

## تشکر و قدردانی

مایلم از [دکتر حامد یغوبیان](https://hamedyaghoobian.com) بابت نظارت علمی، راهنمایی در چارچوب‌بندی پژوهش و ارزیابی، و همچنین کمک در آموزش توکنایزر و آماده‌سازی دیتاست برای انتشار v2 تشکر کنم. بازخورد و تجربیات ایشان نقش اساسی در بهبود ارائه این کار داشت.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---