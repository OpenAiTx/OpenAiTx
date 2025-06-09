[toc]

## مرور کلی

این مخزن شامل کد منبع مرتبط با *مدل‌سازی سیستم و کانال مخابرات نوری بی‌سیم با متلب* می‌باشد.

**برخی از کدهای اصلی دارای مشکلاتی بودند و نیاز به اصلاح داشتند. من تغییرات لازم را جهت افزایش کاربردی بودن و کارایی انجام داده‌ام.**



## نسخه متلب

MATLAB R2024a

## ساختار دایرکتوری

- `util/` - اسکریپت‌ها و توابع کمکی.

## توضیحات برخی از کدها

در ادامه فهرستی از اسکریپت‌های متلب موجود در این مخزن آورده شده است (همه کدها را شامل نمی‌شود):

| نام                      | توضیح                                                                                                                          |
| ------------------------ | ------------------------------------------------------------------------------------------------------------------------------ |
| `CORRECT_plot_Fig3p31.m` | تابع چگالی احتمال گاما-گاما (PDF)                                                                                              |
| `CORRECT_plot_Fig3p28.m` | تابع چگالی احتمال توزیع لگ-نرمال (PDF)                                                                                        |
| `CORRECT_program_4p4.m`  | برنامه ۴.۴: کد متلب جهت شبیه‌سازی نرخ خطای بیت (BER) مدولاسیون کلیدزنی روشن-خاموش بدون بازگشت به صفر (OOK-NRZ)              |
| `CORRECT_program_4p5.m`  | برنامه ۴.۵: کد متلب جهت شبیه‌سازی BER برای OOK-NRZ با استفاده از گیرنده مبتنی بر فیلتر تطبیقی                                 |
| `CORRECT_plot_Fig4p13.m` | برنامه ۴.۱۰: کد متلب جهت محاسبه چگالی طیفی توان (PSD) مدولاسیون فاصله زمانی پالسی گسسته (DPIM) (بدون اسلات محافظ)           |

## نحوه استفاده

برای استفاده از این اسکریپت‌ها، اطمینان حاصل کنید که مسیر `util/` در مسیر متلب شما قرار دارد. این کار را می‌توانید با افزودن خط زیر به اسکریپت راه‌اندازی متلب خود یا با اجرای مستقیم آن در پنجره فرمان متلب انجام دهید:

```matlab
addpath('path/to/util');
```

`'path/to/util'` را با مسیر واقعی دایرکتوری `util/` جایگزین کنید.

## مشارکت

لطفاً در صورت تمایل با فورک کردن این مخزن و ارسال درخواست pull به بهبود آن کمک کنید. هرگونه بهبود، رفع اشکال یا افزودن ویژگی جدید مورد استقبال قرار می‌گیرد.

## قدردانی

این پروژه بر اساس *مدل‌سازی سیستم و کانال مخابرات نوری بی‌سیم با متلب* است. از نویسندگان و مشارکت‌کنندگان کد اصلی صمیمانه تشکر می‌شود.

---



### &#8627; Stargazers
[![Stargazers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/stars/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/stargazers)

### &#8627; Forkers
[![Forkers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/forks/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/network/members)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---