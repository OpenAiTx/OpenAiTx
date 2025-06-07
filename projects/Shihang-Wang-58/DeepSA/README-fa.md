[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: یک پیش‌بینی‌کننده مبتنی بر یادگیری عمیق برای قابلیت سنتز ترکیبات

با توسعه مداوم فناوری هوش مصنوعی، مدل‌های تولید مولکول مبتنی بر یادگیری عمیق به طور فزاینده‌ای برای تولید مولکول‌ها استفاده می‌شوند. با این حال، اغلب بسیاری از مولکول‌های جدید تولیدشده توسط این مدل‌ها با چالش‌های بزرگی از نظر قابلیت سنتز مواجه هستند.

DeepSA به منظور پیش‌بینی قابلیت سنتز ترکیبات ارائه شده است و نرخ غنای اولیه بسیار بالاتری در تمایز مولکول‌هایی که سنتز آن‌ها دشوار است دارد. این امر به کاربران کمک می‌کند تا مولکول‌های کم‌هزینه‌تری را برای سنتز انتخاب کنند و در نتیجه زمان کشف و توسعه دارو کاهش می‌یابد. شما می‌توانید از DeepSA در وب‌سرور https://bailab.siais.shanghaitech.edu.cn/deepsa استفاده کنید.<br/>

## الزامات
وابستگی‌ها را می‌توانید با استفاده از دستور زیر نصب کنید:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# برای نسخه gpu
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### اخبار 🔔

* 2024-12، به دلیل اینکه [AutoGluon پشتیبانی از نسخه ۳.۸ پایتون را متوقف کرده است](https://github.com/autogluon/autogluon/pull/4512) از اکتبر ۲۰۲۴، بنابراین ما DeepSA را به پایتون نسخه ۳.۱۲ به‌روزرسانی کردیم و اسکریپت‌های آموزش و پیش‌بینی را برای سازگاری با آخرین نسخه AutoGluon به‌روزرسانی کردیم، از توجه شما به DeepSA سپاسگزاریم!

* 2023-7، نسخه DeepSA_v1.0 منتشر شد، خوشحال می‌شویم بازخورد خود را در بخش issue ارائه دهید!

## داده‌ها
داده‌های آموزش و تست گسترش‌یافته را می‌توانید به راحتی از این آدرس دانلود کنید:
https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing

## نحوه استفاده برای پژوهشگران
اگر می‌خواهید مدل خودتان را آموزش دهید، می‌توانید آن را از خط فرمان اجرا کنید:

اجرا:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
اگر می‌خواهید از مدل پیشنهادی ما استفاده کنید،

اجرا:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## سرور آنلاین

ما یک مدل پیش‌آموزش‌دیده را روی یک سرور اختصاصی پیاده‌سازی کرده‌ایم که به طور عمومی در دسترس است: https://bailab.siais.shanghaitech.edu.cn/deepsa تا پژوهشگران زیست‌پزشکی بتوانند به راحتی از DeepSA در فعالیت‌های پژوهشی خود استفاده کنند.

کاربران می‌توانند فایل‌های SMILES یا csv خود را در سرور بارگذاری کنند و سپس به سرعت نتایج پیش‌بینی‌شده را دریافت نمایند.

## <span id="citelink">ارجاع</span>
اگر این مخزن در تحقیقات شما مفید بود، لطفاً به مقاله ما ارجاع دهید:

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## تماس
اگر سوالی دارید، لطفاً با Shihang Wang (ایمیل: wangshh12022@shanghaitech.edu.cn) یا Lin Wang (ایمیل: wanglin3@shanghaitech.edu.cn) تماس بگیرید.

درخواست‌های Pull بسیار مورد استقبال قرار می‌گیرند!

## تقدیر و تشکر
ما از پشتیبانی پلتفرم HPC دانشگاه شانگهای‌تک سپاسگزاریم.<br/>
از توجه همه شما به این کار متشکریم.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---