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
## به دیسکورد Vintage LLM بپیوندید

اگر به **مدل‌های زبان تاریخی**، **داده‌ مجموعه‌های مرتبط با زمان** یا آینده پروژه‌هایی مانند **TimeCapsuleLLM**، **Violet-1.4B**، **Mr. Chatterbox** علاقه‌مند هستید، به جامعه ما بپیوندید.

ما از این سرور برای بحث درباره ایده‌ها، به اشتراک‌گذاری پیشرفت‌ها و ارتباط با دیگران در این حوزه استفاده می‌کنیم.

[به دیسکورد بپیوندید](https://discord.gg/JeWkk4z5)

##  رفتار مدل و محدودیت‌ها

### **v0**  

دستورهای اولیه نشان می‌دهد مدل با زبان و رفتار دهه ۱۸۰۰ پاسخ می‌دهد.
مثال: دستور: "Who art Henry?" و پاسخ: "I know that man, I have did not a black, the storm."

![نمونه خروجی TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- بدون اشاره به مفاهیم مدرن  
- واژگان غالباً مطابق دوره تاریخی  
- جملات عمدتاً نامفهوم (انتظار می‌رود با داده آموزشی ~۱۸۷MB)

### **v0.5-london** 

پیشرفت چشمگیر نسبت به v0.  
- سبک نوشتاری ویکتوریایی، نقطه‌گذاری مناسب، جملات عمدتاً دستوری  
- هنوز نرخ بالای توهمات واقعی  
- نویز OCR ("Digitized by Google") همچنان در خروجی‌ها وجود دارد

![نمونه خروجی TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

اولین مدلی که یک رویداد واقعی تاریخی را با یک شخصیت واقعی از مجموعه داده‌ها به یاد آورده و ارتباط می‌دهد.

مثال: دستور: "It was the year of our Lord 1834" 

خروجی: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

در ابتدا تصور می‌کردم که تظاهرات به طور تصادفی همان سال رخ داده اما به این تصویر نگاه کنید: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### **v2mini-eval1-london**

با استفاده از یک نمونه ۱۵ گیگابایتی از دیتاست ۹۰ گیگابایتی v2 آموزش داده شده است.
مدل فقط تا ۱۰ هزار گام آموزش دیده است.

مشکلی در توکنیزاسیون وجود داشت که باعث شد خروجی به این شکل باشد:

درخواست:
چارلز دیکنز کیست؟


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
اصلاح‌شده:

«چارلز دیکنز کیست؟ آیا آن اثر بیشتر از آثار برانگیزاننده و عالی او، در نمایشنامه‌هایش، یا در مزرعه شرکت بزرگ بوده است؟ هنوز چه چیزی باید از جک پیکت نقل کنم؟ آیا نمی‌دانید که آن‌ها نوعی تاخت‌وتاز، یا سینه‌زنی، یا کاری که باید در زمانی انجام می‌شد که جکسون از پنجره نگاه می‌کرد، بودند؟ موفقیت یک انگلیسی چیست و چه چیزی را پسرش هنوز برای من کشف نکرده که بتوان با آن چنین باری را به انجام رساند؟ آیا تاکنون گذری به جاده قدیمی یا به نسیم لنگر در پای قایق ما داشته‌اید که باید ما را ترک کنید؟ واقعیت این است که چه باد از دشت در شب شنبه یا ظهر، یا تا شمال، یا به گونه‌ای دیگر برخیزد یا نه، ما ناچاریم مانعی هولناک را توصیف کنیم، با همان تأثیراتی که اکنون وجود دارد. در این وضعیت، حداقل، گفتن این که ما آن اتاق را ترک کرده‌ایم چندان اغراق نیست. فکر می‌کنم سه نسخه در «پانصدبرابر» وجود دارد که باید به آن‌ها مراجعه کرد، به‌عنوان اولین شماره از خوانندگانی که مایلند...[ی]...»

### **v2mini-eval2-london**

آموزش داده شده با همان نمونه ۱۵ گیگابایتی که برای آموزش eval1 استفاده شده بود.
مدل دوباره فقط تا ۱۰ هزار گام آموزش دیده است.

پرومپت: چارلز داروین

چارلز داروینECCEMACY. آقا، — مورد زیر برای من جالب است: — من دو هفته در لندن بودم و به شدت دچار حمله رماتیسم شدم. اولین حمله رماتیسم یک هفته قبل از دیدار با شما بود و دومین بار هنگام دیدار با شما و سومین بار نیز همزمان با آن. اما دومین حمله نقرس با هیچ نشانه تب‌آلودی همراه نبود، ولی با افزایش جریان ادرار و دفع بیشتر ادرار همراه بود. سومین حمله یک ساعت بعد از دیدار با شما رخ داد و پس از آن بازگشت حمله نقرس و بازگشت سریع‌تر نقرس اتفاق افتاد. حمله چهارم نیز با تب همراه بود اما همیشه با نشانه‌های تب‌آلود همراه نبود. سومین حمله نقرس دو هفته بعد از بیمار شدن شما رخ داد و چهارمین حمله با حمله نقرس دنبال شد. حمله چهارم دو هفته بعد از حمله به شما رخ داد و با حسی همراه بود

### **v2-london**

آموزش داده شده با یک دیتاست ۹۰ گیگابایتی (۱۱۲ گیگابایت توکنیزه‌شده)
آموزش تا ۱۸۲ هزار گام

![نمونه خروجی TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![نمونه خروجی TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **گام بعدی چیست؟**

- توسعه TimeCapsuleLLM v3 آغاز شده است
- افزایش حجم دیتاست و پوشش جغرافیایی
- گسترش فراتر از لندن به شهرهای دیگر

این کار با همکاری پژوهشگرانی از دانشگاه کالج لندن (UCL) در حال انجام است و مشارکت‌های نهادی بیشتری در دست بررسی است.


##  دیتاست‌ها

### **v2**

- ۹۰ گیگابایت (خام) متون لندن ۱۸۰۰ تا ۱۸۷۵
- ۱۳۶,۳۴۴ سند
- دیتاست کامل توکنیزه شده اکنون اینجا در دسترس است: https://huggingface.co/datasets/postgrammar/london-llm-1800


### آمار سوگیری
![سوگیری ضمیر](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

![سوگیری جغرافیایی](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

![سوگیری زمانی](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

برای اطلاعات بیشتر به [گزارش سوگیری نسخه ۲](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) مراجعه کنید.


-


## نحوه استفاده

این پروژه عمدتاً بر گردآوری داده‌های تاریخی، آماده‌سازی آن برای آموزش و ساخت توکنایزر متمرکز است. فرآیند کامل آموزش LLM در اینجا پوشش داده نمی‌شود؛ برای این منظور به nanoGPT توسط Andrej Karpathy مراجعه کنید.

### مرحله ۱: جمع‌آوری و آماده‌سازی متون تاریخی

- فایل‌های .txt کتاب‌ها، اسناد و غیره از حوزه عمومی را از دوره زمانی موردنظر (مثلاً لندن ۱۸۰۰-۱۸۷۵) جمع‌آوری کنید.
- آن‌ها را در محدوده زمان/مکان انتخابی نگه دارید.
- فایل‌های متنی را با اسکریپت یا به صورت دستی تمیز کنید و سربرگ/پابرگ‌های پروژه گوتنبرگ، یادداشت‌های مدرن یا خطاهای OCR را حذف نمایید.

### مرحله ۲: ساخت توکنایزر سفارشی

- train_tokenizer.py یا train_tokenizer_hf.py را روی داده‌های تمیز شده اجرا کنید.
- این کار vocab.json و merges.txt را به شما می‌دهد.
- این فایل‌ها واژگان و قوانین ادغام برای مدل شما را تعریف می‌کنند.

### مرحله ۳: آموزش مدل شما

- برای فرآیند آموزش یا مستندات معماری انتخابی خود به [nanoGPT توسط Andrej Karpathy](https://github.com/karpathy/nanoGPT) مراجعه کنید.

# سوالات متداول

## آموزش انتخابی زمانی چیست؟

آموزش انتخابی زمانی (STT) روشی در یادگیری ماشین است که در آن همه داده‌های آموزشی به طور خاص برای قرار گرفتن در یک دوره تاریخی خاص گردآوری می‌شوند. این کار به منظور مدل‌سازی زبان و دانش آن دوره بدون تأثیر مفاهیم مدرن انجام می‌شود. برای مثال، مدل فعلی من (نسخه ۰.۵) صرفاً بر داده‌های ۱۸۰۰-۱۸۷۵ آموزش دیده است، به صورت کامل از ابتدا آموزش داده شده و خروجی آن منعکس‌کننده سبک زبانی و زمینه تاریخی آن دوره است.

## چرا فقط از فاین‌تیون یا LoRA استفاده نمی‌کنید؟
برای این پروژه من تلاش می‌کنم یک مدل زبانی بسازم که از سوگیری‌های مدرن پاک باشد. اگر چیزی مثل GPT-2 را فاین‌تیون کنم، آن قبلاً پیش‌آموزش داده شده و آن اطلاعات از بین نمی‌رود. اگر مدل زبانی را از ابتدا آموزش دهم، تظاهر به قدیمی بودن نمی‌کند، واقعاً همین‌گونه است. هدف فعلی این پروژه ساخت مدلی است که منحصراً با استفاده از دانش کتاب‌های لندن منتشرشده بین سال‌های ۱۸۰۰ تا ۱۸۷۵ استدلال کند.

## از چه نوع داده‌ای برای آموزش استفاده کردید؟

من از کتاب‌ها، اسناد حقوقی، روزنامه‌ها و سایر نوشته‌های لندن بین سال‌های ۱۸۰۰ تا ۱۸۷۵ استفاده می‌کنم. لیستی که پیوند دادم (برای نسخه v0) حدود ۲۰۰ مورد دارد اما برای اولین آموزش فقط از ۵۰ فایل به حجم تقریبی ۱۸۷ مگابایت استفاده کردم. می‌توانید فهرست اسناد را مشاهده کنید:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

اندازه دیتاست‌ها:
- v0: حدود ۱۸۷ مگابایت
- v0.5: حدود ۴۳۵ مگابایت
- v1: حدود ۶.۲۵ گیگابایت
- v2mini-eval1: ۱۵ گیگابایت (نمونه‌ای از ۹۰ گیگابایت v2)
- v2: ۹۰ گیگابایت

## اندازه مدل‌ها چقدر است؟

v0: شانزده میلیون پارامتر

v0.5: صد و بیست و سه میلیون پارامتر

v1: هفتصد میلیون پارامتر

v2mini-eval1: سیصد میلیون پارامتر

v2mini-eval2: دویست میلیون پارامتر

v2: یک میلیارد و دویست میلیون پارامتر

## مشخصات آموزش؟ 

### v0/v0.5
کارت گرافیک: Geforce rtx 4060
پردازنده: i5-13400F
رم: ۱۶ گیگابایت DDR5.

### v1
کارت گرافیک: A100 SXM اجاره‌ای

### v2mini-eval1/eval2

GPU: اجاره‌ای A100 SXM

### v2
GPU: اجاره‌ای H100 SXM

## کارهای مرتبط

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  - مدل LLM با ۱۳ میلیارد پارامتر که بر روی ۲۶۰ میلیارد توکن متنی پیش از ۱۹۳۰ با Q&A آموزش دیده است. همچنین یک نسخه [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base) نیز وجود دارد.
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  - مدل LLM با ۱.۴ میلیارد پارامتر که بر روی متون ۱۸۰۰ تا ۱۸۹۹ با Q&A آموزش دیده است. همچنین یک نسخه [160M](https://huggingface.co/zakarth/violet-160m-chat) نیز وجود دارد.
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  - مدل LLM با ۳۴۰ میلیون پارامتر که بر روی بیش از ۲۸,۰۰۰ متن بین سال‌های ۱۸۳۷ تا ۱۸۹۹ با Q&A آموزش دیده است.

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - خانواده‌ای از مدل‌های LLM با ۴ میلیارد پارامتر مبتنی بر معماری Qwen3 که از ابتدا بر روی ۸۰ میلیارد توکن داده تاریخی تا سال‌های ۱۹۱۳، ۱۹۲۹، ۱۹۳۳، ۱۹۳۹، ۱۹۴۶ آموزش دیده‌اند.

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT یک فاین‌تیون از Mistral-Hermes 2 بر روی ۱۱,۰۰۰ متن اوایل دوران مدرن به زبان‌های انگلیسی، فرانسوی و لاتین است که عمدتاً از EEBO و Gallica آمده‌اند.

## تشکر و قدردانی

مایلم از [دکتر حامد یعقوبیان](https://hamedyaghoobian.com) بابت نظارت علمی، راهنمایی در زمینه چارچوب‌بندی تحقیق و ارزیابی، و همچنین کمک در آموزش توکنایزر و آماده‌سازی داده برای انتشار نسخه v2 تشکر کنم. بازخورد و تجربیات ایشان نقش اساسی در بهبود ارائه این کار داشت.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---