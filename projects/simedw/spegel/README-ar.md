# سبيغل – عكس الويب من خلال الذكاء الاصطناعي

يعيد كتابة مواقع الويب تلقائيًا إلى صيغة ماركداون محسّنة للعرض في الطرفية.
اقرأ منشور المقدمة [هنا](https://simedw.com/2025/06/23/introducing-spegel/)

هذا إثبات مفهوم، من المتوقع وجود أخطاء لكن لا تتردد في رفع مشكلة أو طلب سحب.

## لقطة شاشة
أحيانًا لا ترغب في قراءة قصة حياة شخص ما فقط للوصول إلى وصفة
![مثال على وصفة](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## التثبيت

يتطلب بايثون 3.11 أو أحدث

```
pip install spegel
```
أو استنسخ المستودع وقم بتثبيته في وضع التحرير

```bash
# استنسخ وادخل إلى الدليل
$ git clone <repo-url>
$ cd spegel

# ثبت التبعيات وواجهة الأوامر
$ pip install -e .
```

## مفاتيح API
سبيغل يدعم حاليًا فقط Gemini 2.5 Flash، لاستخدامه يجب عليك توفير مفتاح API الخاص بك في متغير البيئة

```
GEMINI_API_KEY=...
```


## الاستخدام

### تشغيل المتصفح

```bash
spegel                # البدء مع شاشة الترحيب
spegel bbc.com        # فتح عنوان URL مباشرة
```

أو، بشكل مكافئ:

```bash
python -m spegel      # البدء مع شاشة الترحيب
python -m spegel bbc.com
```

### عناصر التحكم الأساسية
- `/`         – فتح إدخال عنوان URL
- `Tab`/`Shift+Tab` – التنقل بين الروابط
- `Enter`     – فتح الرابط المحدد
- `e`         – تحرير موجه LLM للعرض الحالي
- `b`         – الرجوع للخلف
- `q`         – إنهاء

## تحرير الإعدادات

يقوم سبيغل بتحميل الإعدادات من ملف إعدادات بصيغة TOML. يمكنك تخصيص العروض، والموجهات، وخيارات واجهة المستخدم.

**ترتيب البحث عن ملف الإعدادات:**
1. `./.spegel.toml` (الدليل الحالي)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

لتعديل الإعدادات:
1. انسخ ملف الإعدادات النموذجي:
   ```bash
   cp example_config.toml .spegel.toml
   # أو أنشئ ~/.spegel.toml
   ```
2. حرر ملف `.spegel.toml` في محررك المفضل.

مقطع نموذجي:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "حوّل صفحة الويب هذه إلى تجربة تصفح طرفية مثالية! ..."
```

---

للمزيد، راجع الكود أو افتح تذكرة مشكلة!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---