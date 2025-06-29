# سین‌گن (SinGAN)

[پروژه](https://tamarott.github.io/SinGAN.htm) | [آرکایو](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [مواد تکمیلی](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [سخنرانی (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191)
### پیاده‌سازی رسمی pytorch از مقاله: "سین‌گن: یادگیری یک مدل مولد از یک تصویر طبیعی منفرد"
#### برنده جایزه بهترین مقاله ICCV 2019 (جایزه Marr)

## نمونه‌های تصادفی از *یک* تصویر
با سین‌گن، شما می‌توانید یک مدل مولد را فقط از یک تصویر طبیعی آموزش دهید، و سپس نمونه‌های تصادفی از همان تصویر تولید کنید، برای مثال:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)

## کاربردهای سین‌گن
سین‌گن همچنین می‌تواند برای مجموعه‌ای از وظایف دستکاری تصویر مورد استفاده قرار گیرد، برای مثال:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
این کار با تزریق یک تصویر به مدل آموزش‌دیده انجام می‌شود. برای جزئیات بیشتر به بخش ۴ مقاله ما [اینجا](https://arxiv.org/pdf/1905.01164.pdf) مراجعه کنید.

### ارجاع
اگر از این کد در پژوهش خود استفاده می‌کنید، لطفاً به مقاله ما ارجاع دهید:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## کد

### نصب پیش‌نیازها

```
python -m pip install -r requirements.txt
```

این کد با python 3.6 و torch 1.4 تست شده است.

توجه داشته باشید: این کد فعلاً فقط از torch 1.4 یا نسخه‌های قبل‌تر پشتیبانی می‌کند به دلیل طرح بهینه‌سازی.

برای نسخه‌های جدیدتر torch، می‌توانید این مخزن را امتحان کنید: https://github.com/kligvasser/SinGAN (نتایج الزاماً با پیاده‌سازی رسمی یکسان نخواهد بود).

### آموزش
برای آموزش مدل سین‌گن روی تصویر دلخواه خود، تصویر مورد نظر را در پوشه Input/Images قرار دهید و اجرا کنید

```
python main_train.py --input_name <input_file_name>
```

این کار همچنین مدل آموزش‌دیده را به کار می‌گیرد تا نمونه‌های تصادفی از مقیاس خشن‌تر (n=0) تولید کند.

برای اجرای این کد روی سیستم cpu، هنگام اجرای `main_train.py` گزینه `--not_cuda` را مشخص کنید.

### نمونه‌های تصادفی
برای تولید نمونه‌های تصادفی از هر مقیاس شروع تولید، ابتدا مدل سین‌گن را روی تصویر مورد نظر آموزش دهید (طبق توضیحات بالا)، سپس اجرا کنید

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

توجه کنید: برای استفاده از مدل کامل، عدد مقیاس شروع تولید را 0 قرار دهید، برای شروع از مقیاس دوم، آن را 1 قرار دهید و به همین ترتیب.

### نمونه‌های تصادفی با اندازه دلخواه
برای تولید نمونه‌های تصادفی با اندازه‌های دلخواه، ابتدا مدل سین‌گن را روی تصویر مورد نظر آموزش دهید (طبق توضیحات بالا)، سپس اجرا کنید

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

### انیمیشن از یک تصویر منفرد

برای تولید یک انیمیشن کوتاه از یک تصویر منفرد، اجرا کنید

```
python animation.py --input_name <input_file_name> 
```

این کار به طور خودکار یک مرحله آموزش جدید با حالت padding نویزی را آغاز می‌کند.

### یکسان‌سازی (Harmonization)

برای یکسان‌سازی یک شیء چسبانده شده در یک تصویر (نمونه‌ای را در شکل ۱۳ مقاله [ما](https://arxiv.org/pdf/1905.01164.pdf) ببینید)، ابتدا مدل سین‌گن را روی تصویر پس‌زمینه دلخواه آموزش دهید (طبق توضیحات بالا)، سپس تصویر مرجع چسبانده‌شده و ماسک دودویی آن را در پوشه "Input/Harmonization" ذخیره کنید (برای نمونه به تصاویر ذخیره‌شده مراجعه کنید). دستور زیر را اجرا کنید

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

توجه داشته باشید که مقیاس تزریق متفاوت، اثرات یکسان‌سازی متفاوتی ایجاد می‌کند. خشن‌ترین مقیاس تزریق برابر با 1 است.

### ویرایش

برای ویرایش یک تصویر (نمونه‌ای را در شکل ۱۲ مقاله [ما](https://arxiv.org/pdf/1905.01164.pdf) ببینید)، ابتدا مدل سین‌گن را روی تصویر اصلی (ویرایش‌نشده) آموزش دهید (طبق توضیحات بالا)، سپس ویرایش ساده را به عنوان تصویر مرجع همراه با نقشه دودویی مربوطه در پوشه "Input/Editing" ذخیره کنید (برای نمونه به تصاویر ذخیره‌شده مراجعه کنید). دستور زیر را اجرا کنید

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
```
هم خروجی ماسک‌شده و هم خروجی بدون ماسک ذخیره خواهند شد.
در اینجا نیز، مقیاس‌های تزریق مختلف، افکت‌های ویرایشی متفاوتی تولید خواهند کرد. درشت‌ترین مقیاس تزریق برابر با 1 است.

### تبدیل نقاشی به تصویر

برای تبدیل یک نقاشی به یک تصویر واقعی (به مثال در شکل 11 در [مقاله ما](https://arxiv.org/pdf/1905.01164.pdf) مراجعه کنید)، ابتدا باید مدل SinGAN را روی تصویر دلخواه آموزش دهید (همانطور که در بالا توضیح داده شد)، سپس نقاشی خود را در مسیر "Input/Paint" ذخیره کنید و دستور زیر را اجرا نمایید:

```
python paint2image.py --input_name <training_image_file_name> --ref_name <paint_image_file_name> --paint_start_scale <scale to inject>
```
در اینجا نیز، مقیاس‌های تزریق مختلف، افکت‌های ویرایشی متفاوتی تولید خواهند کرد. درشت‌ترین مقیاس تزریق برابر با 1 است.

گزینه پیشرفته: مقدار quantization_flag را True قرار دهید تا *فقط* سطح تزریق مدل مجدداً آموزش داده شود و نسخه کوانتایز رنگی از تصاویر تولیدی بزرگ‌نمایی‌شده از مقیاس قبلی به دست آید. برای برخی تصاویر، این کار ممکن است به نتایج واقعی‌تری منجر شود.

### ابر وضوح (Super Resolution)
برای افزایش وضوح تصویر، دستور زیر را اجرا کنید:
```
python SR.py --input_name <LR_image_file_name>
```
این دستور به طور خودکار مدل SinGAN را برای ضریب بزرگ‌نمایی 4 برابر آموزش می‌دهد (در صورت عدم وجود قبلی).
برای ضریب‌های بزرگ‌نمایی مختلف، می‌توانید پارامتر `--sr_factor` را هنگام فراخوانی تابع مشخص کنید.
نتایج SinGAN روی دیتاست BSD100 را می‌توانید از پوشه 'Downloads' دانلود کنید.

## داده‌ها و توابع اضافی

### فاصله فرچت اینسپشن تک‌تصویری (SIFID score)
برای محاسبه SIFID بین تصاویر واقعی و نمونه‌های جعلی متناظر آن‌ها، دستور زیر را اجرا کنید:
```
python SIFID/sifid_score.py --path2real <real images path> --path2fake <fake images path> 
```  
اطمینان حاصل کنید که نام فایل هر تصویر جعلی دقیقاً با نام فایل تصویر واقعی متناظر آن یکسان باشد. تصاویر باید با فرمت `.jpg` ذخیره شوند.

### نتایج ابر وضوح
نتایج SR مدل SinGAN بر روی دیتاست BSD100 را می‌توانید از پوشه 'Downloads' دانلود کنید.

### مطالعه کاربری
داده‌های استفاده‌شده برای مطالعه کاربری را می‌توانید در پوشه Downloads پیدا کنید.

پوشه real: ۵۰ تصویر واقعی که به صورت تصادفی از [پایگاه داده places](http://places.csail.mit.edu/) انتخاب شده‌اند.

پوشه fake_high_variance: نمونه‌های تصادفی که برای هر تصویر واقعی از n=N شروع شده‌اند.

پوشه fake_mid_variance: نمونه‌های تصادفی که برای هر تصویر واقعی از n=N-1 شروع شده‌اند.

برای جزئیات بیشتر لطفاً به بخش 3.1 در [مقاله ما](https://arxiv.org/pdf/1905.01164.pdf) مراجعه کنید.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---