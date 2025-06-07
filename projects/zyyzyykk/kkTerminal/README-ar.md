# kkTerminal

> kkTerminal، طرفية لاتصال SSH عبر الويب
>
> المؤلف: [zyyzyykk](https://github.com/zyyzyykk/)
>
> الشيفرة المصدرية: https://github.com/zyyzyykk/kkTerminal
>
> عنوان Docker Hub: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> المعاينة: https://ssh.kkbpro.com/
>
> وقت التحديث: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ التكامل السريع

استخدم وسم `iframe` في صفحات HTML للدمج السريع:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 النشر باستخدام Docker

1. سحب الصورة:

```bash
docker pull zyyzyykk/kkterminal
```

2. أنشئ وشغل حاوية مع تعيين المنفذ: `-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. تخصيص كلمة الفن: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. الوصول من المتصفح: `http://server-ip:3000/`

### 🛸 المعاينة

قم بزيارة الموقع التالي: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**المزيد من معاينات الوحدات**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 وصف الوظائف

1. kkTerminal هو طرفية لاتصال SSH عبر الويب. انقر على أيقونة الطرفية في الزاوية العلوية اليسرى واختر إعدادات الاتصال لإنشاء اتصال SSH

2. يدعم استخدام وسم `iframe` في صفحات الويب للدمج السريع في مواقع الطرف الثالث

3. يدعم تخصيص إعدادات الطرفية من خلال [معاملات الرابط](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. يدعم التدويل والتبديل بين اللغتين الصينية والإنجليزية

5. يدعم النشر المحلي على الحاسب وفتح نافذة المتصفح تلقائياً عند بدء التشغيل

6. يدعم التكيف مع حجم النافذة وإدخال اللغة الصينية

7. يدعم إعدادات التفضيلات المخصصة، بحيث يمكن للمستخدمين اختيار لون الخلفية/المقدمة، حجم الخط، نمط عرض المؤشر، تفعيل TCode للطرفية، إلخ

8. يدعم إعادة التشغيل: سيتم إعادة التشغيل تلقائياً بعد تعديل إعدادات اتصال SSH أو إعدادات التفضيلات المخصصة، أو يمكن إعادة التشغيل يدوياً بعد قطع اتصال SSH

9. يدعم النسخ واللصق:

   - النسخ: مثل طرفية `Git`، تحديد النص سيتم نسخه تلقائياً

   - اللصق: مثل طرفية `Cmd`، انقر بزر الماوس الأيمن للصق (يتطلب إذن وصول المتصفح)


9. يدعم إدارة الملفات، افتح وحدة إدارة الملفات لعرض وفك ضغط ورفع وتنزيل الملفات/المجلدات

10. يدعم اختصارات لوحة المفاتيح مثل تحديد ملفات متعددة/الكل، نسخ ولصق، قص، تبديل التحديد، فتح، إلخ

11. يدعم تصفح الملفات وتحريرها، تعديل الملف وحفظه على الخادم البعيد باستخدام `ctrl+s`

12. يدعم [TCode (كود الطرفية)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md)، والذي يمكنه تنفيذ سير عمل تلقائي شبيه بسكربتات Shell عبر TCode مخصص

13. يدعم تسجيل العمليات والمزامنة السحابية

14. يدعم وظائف التعاون، المراقبة وDocker

### 👨‍💻 سجلات التحديث

##### zyyzyykk/kkterminal:3.6.0: latest

- إضافة وظيفة التعاون المتقدمة
- إضافة وظيفة المراقبة المتقدمة
- إضافة وظيفة Docker المتقدمة
- تحسين حجم الحزمة وعرض صفحة الويب

##### zyyzyykk/kkterminal:3.5.6: 

- دعم المزيد من معاملات الرابط
- إضافة نسبة حجم النص والصورة في المحرر
- تحسين عرض صفحة الويب

##### zyyzyykk/kkterminal:3.5.3: 

- إضافة معلمة في الرابط لتخصيص إعدادات الطرفية
- إصلاح خطأ إعادة التشغيل للنوافذ المتعددة
- إضافة وظيفة تسجيل العمليات والمزامنة السحابية
- إعادة هيكلة بعض منطق الشيفرة

[**سجل التحديثات السابقة**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 البنية

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ عن هذا المشروع

المستخدمون الأعزاء،

يؤسفني أن أعلن أنه بسبب ضيق الوقت والطاقة، لن أتمكن من صيانة `kkTerminal` في المستقبل.

إذا كنت مهتماً بـ `kkTerminal` أو ترغب في الاستمرار في صيانته، لا تتردد في التواصل معي أو فتح تذكرة.

إذا اكتشفت أخطاء أو رغبت في تطوير ميزات جديدة، يرجى أيضاً فتح تذكرة.

أخيراً، شكراً لدعمكم لـ `kkTerminal` وآمل بصدق أن يكون `kkTerminal` قد ساعدكم بالفعل.

مع أطيب التحيات،

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 النجوم

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---