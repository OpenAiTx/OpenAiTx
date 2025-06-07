# mimotion
![刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# تزييف عدد الخطوات تلقائيًا في تطبيق شاومي للياقة

> تزييف عدد الخطوات تلقائيًا في تطبيق شاومي للياقة

## دليل النشر عبر Github Actions

### 1. عمل Fork لهذا المستودع

### 2. إعداد اسم المستخدم وكلمة المرور
# إضافة بتاريخ 2023-02-24
أضف متغيرًا باسم **CONFIG**: من Settings-->Secrets-->New secret ، وقم بتكوين حسابات متعددة باستخدام قالب الـjson أدناه، يدعم البريد الإلكتروني ورقم الهاتف المحمول
```
{
  "TG_BOT_TOKEN": "رمز TG_BOT_TOKEN في تليغرام، إذا لم يوجد يرجى تركه فارغًا",
  "TG_USER_ID": "معرّف TG_USER_ID في تليغرام، إذا لم يوجد يرجى تركه فارغًا",
  "SKEY": "مفتاح sckey لخدمة酷推، إذا لم يوجد يرجى تركه فارغًا",
  "SCKEY": "مفتاح sckey لخدمة server酱، إذا لم يوجد يرجى تركه فارغًا",
  "POSITION": "هل تم تفعيل إشعارات WeChat للمؤسسات، إذا لم يوجد يرجى تركه فارغًا",
  "CORPID": "معرّف المؤسسة، قم بتسجيل الدخول إلى WeChat للمؤسسات، وابحث عنه في معلومات المؤسسة، إذا لم يوجد يرجى تركه فارغًا",
  "CORPSECRET": "السر الخاص بالتطبيق الذاتي في WeChat للمؤسسات، إذا لم يوجد يرجى تركه فارغًا",
  "AGENTID": "أدخل معرّف تطبيق WeChat للمؤسسات الخاص بك بدون علامات اقتباس، قيمة عددية، إذا لم يوجد يرجى تركه فارغًا",
  "TOUSER": "أدخل قائمة معرفات الأعضاء المستلمين، عدة مستلمين افصلهم بـ”&#166;”، الحد الأقصى 1000. إذا تم تعيينها إلى”@all”، سيتم إرسال الرسالة إلى جميع الأعضاء. إذا لم يوجد يرجى تركه فارغًا",
  "TOPARTY": "أدخل قائمة معرفات الأقسام المستلمة، عدة مستلمين افصلهم بـ”&#166;”، الحد الأقصى 100. إذا تم تعيين touser إلى”@all” عيّن هنا أيضًا ”@all”، إذا لم يوجد يرجى تركه فارغًا",
  "TOTAG": "أدخل قائمة معرفات الوسوم المستلمة، عدة مستلمين افصلهم بـ”&#166;”، الحد الأقصى 100. إذا تم تعيين touser إلى”@all” عيّن هنا أيضًا ”@all”، إذا لم يوجد يرجى تركه فارغًا",
  "OPEN_GET_WEATHER": "تفعيل تقليل الخطوات حسب حالة الطقس في المنطقة، إذا لم يوجد يرجى تركه فارغًا",
  "AREA": "تعيين المنطقة للحصول على حالة الطقس (إجباري عند التفعيل أعلاه)، مثال: بكين، إذا لم يوجد يرجى تركه فارغًا",
  "QWEATHER": "أدخل هنا مفتاح Private KEY لخدمة HeWeather، رابط التقديم https://console.qweather.com/#/apps، إذا لم يوجد يرجى تركه فارغًا",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "أدخل الحد الأقصى للخطوات للحساب الإضافي كما أعلاه",
      "min_step": "أدخل الحد الأدنى للخطوات للحساب الإضافي كما أعلاه",
      "password": "أدخل كلمة المرور للحساب الإضافي كما أعلاه",
      "user": "أدخل رقم الهاتف للحساب الإضافي كما أعلاه"
    }
  ]
}
```
> أضف متغيرًا باسم **PAT**: من Settings-->Secrets-->New secret

| Secrets |  الصيغة  |
| -------- | ----- |
| PAT |   هنا يجب أن تقوم بتقديم طلب للحصول على **PAT**، والقيمة هي رمز github token، الدليل: https://www.jianshu.com/p/bb82b3ad1d11، يجب أن تمتلك صلاحيات repo و workflow، هذا الحقل إجباري لتجنب أخطاء صلاحيات git push. |

**مثال CONFIG**
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "أدخل الحد الأقصى للخطوات للحساب الإضافي كما أعلاه",
      "min_step": "أدخل الحد الأدنى للخطوات للحساب الإضافي كما أعلاه",
      "password": "أدخل كلمة المرور للحساب الإضافي كما أعلاه",
      "user": "أدخل رقم الهاتف للحساب الإضافي كما أعلاه"
    }
  ]
}
```

### 3. تخصيص وقت التشغيل

حرر ملف **random_cron.sh**
قم بتعديل شرط جملة **if** إلى توقيت UTC، أي **توقيت بكين -8**، مثلاً إذا كان توقيت بكين هو 8 صباحًا يكون توقيت UTC هو منتصف الليل، الوقت المطلوب للتشغيل -8 هو توقيت UTC المطلوب



## ملاحظات هامة

1. يتم التشغيل سبع مرات يوميًا، يتم التحكم فيها بواسطة random_cron.sh، والدقائق تكون عشوائية

2. يجب التأكد من تطابق عدد الحسابات مع كلمات المرور، وإلا لن يعمل!

3. يجب أن يكون وقت التشغيل بتوقيت UTC!

4. رابط تسجيل server酱 [اضغط هنا](https://sct.ftqq.com/)

5. إذا لم يتم تحديث الخطوات في تطبيق Alipay، انتقل إلى تطبيق شاومي للياقة -> الإعدادات -> الحساب -> تسجيل الخروج -> امسح البيانات، ثم سجّل الدخول مجددًا وأعد ربط الطرف الثالث

6. تطبيق شاومي للياقة نفسه لن يحدث الخطوات، فقط التطبيقات المرتبطة ستتم مزامنتها!!

7. يرجى عمل Fork للفرع الرئيسي [الرابط](https://github.com/xunichanghuan/mimotion-run/) أثناء الاستخدام لتجنب ظهور أخطاء غير ضرورية.

8. يرجى الانتباه، الحساب المستخدم ليس [حساب شاومي] وإنما حساب [تطبيق شاومي للياقة].

## عدد النجوم عبر التاريخ

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---