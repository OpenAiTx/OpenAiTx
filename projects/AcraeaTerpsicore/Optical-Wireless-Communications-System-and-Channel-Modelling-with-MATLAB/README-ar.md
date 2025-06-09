[toc]

## نظرة عامة

يحتوي هذا المستودع على الشيفرة المصدرية المتعلقة بكتاب *تصميم نظام الاتصالات الضوئية اللاسلكية ونمذجة القناة باستخدام MATLAB*.

**بعض الشيفرات الأصلية احتوت على مشاكل وكانت بحاجة إلى تعديلات. لقد قمت بإجراء التعديلات اللازمة لتحسين العملية والوظائف.**


## إصدار MATLAB

MATLAB R2024a

## هيكلية الدليل

- `util/` - سكريبتات ووظائف مساعدة.

## وصف بعض الشيفرات

فيما يلي قائمة ببعض سكريبتات MATLAB المضمنة في هذا المستودع (ليس جميعها):

| الاسم                     | الوصف                                                                                                                     |
| ------------------------ | ------------------------------------------------------------------------------------------------------------------------- |
| `CORRECT_plot_Fig3p31.m` | دالة كثافة الاحتمال (PDF) لتوزيع جاما-جاما                                                                              |
| `CORRECT_plot_Fig3p28.m` | دالة كثافة الاحتمال (PDF) لتوزيع اللوغاريتمي الطبيعي                                                                      |
| `CORRECT_program_4p4.m`  | البرنامج 4.4: كود MATLAB لمحاكاة معدل خطأ البت (BER) في نمط تشغيل-إيقاف بدون عودة للصفر (OOK-NRZ)                         |
| `CORRECT_program_4p5.m`  | البرنامج 4.5: كود MATLAB لمحاكاة BER لنمط OOK-NRZ باستخدام مستقبل يعتمد على مرشح مطابق                                   |
| `CORRECT_plot_Fig4p13.m` | البرنامج 4.10: كود MATLAB لحساب كثافة القدرة الطيفية (PSD) لتعديل فاصل النبضة المنفصلة (DPIM) (بدون فترة حراسة)           |

## طريقة الاستخدام

لاستخدام هذه السكريبتات، تأكد من تضمين مجلد `util/` في مسار MATLAB الخاص بك. يمكن تحقيق ذلك بإضافة السطر التالي إلى سكريبت بدء تشغيل MATLAB الخاص بك أو تشغيله مباشرة في نافذة أوامر MATLAB:

```matlab
addpath('path/to/util');
```

استبدل `'path/to/util'` بالمسار الفعلي لمجلد `util/`.

## المساهمة

لا تتردد في المساهمة في هذا المستودع عن طريق عمل fork وتقديم طلبات دمج (Pull Requests). أي تحسينات أو إصلاحات للأخطاء أو ميزات إضافية مرحب بها.

## الشكر والتقدير

هذا المشروع مبني على كتاب *تصميم نظام الاتصالات الضوئية اللاسلكية ونمذجة القناة باستخدام MATLAB*. شكر خاص لمؤلفي ومساهمي الشيفرة الأصلية.

---


### &#8627; Stargazers
[![Stargazers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/stars/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/stargazers)

### &#8627; Forkers
[![Forkers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/forks/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/network/members)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---