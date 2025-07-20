<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - نظام روبوت خدمة العملاء الذكي لمنصة شيانيو

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

حل ذكاء اصطناعي تم تطويره خصيصًا لمنصة شيانيو، يتيح المراقبة الآلية على مدار 24/7، ويدعم اتخاذ القرار التعاوني بين عدة خبراء، والمساومة الذكية، والمحادثة المدركة للسياق.

## 🎮 منطقة التجربة - تجربة سريعة (بدون إعداد)

لا حاجة لبيئة محلية أو إعداد أسرار! **يمكنك تشغيل روبوت شيانيو مباشرة من خلال صفحة GitHub Actions عبر تمرير المعلمات** بضغطة واحدة.

### كيفية الاستخدام
1. **اعمل Fork لهذا المستودع** → اضغط زر `Fork` في الزاوية اليمنى العليا
2. **تشغيل Action**:
   - ادخل إلى تبويب `Actions` في مستودعك
   - اختر **`🚀 Run Service`** ضمن سير العمل
   - اضغط زر **`Run workflow`** واملأ المعلمات:
      - `API Key`: الصق مفتاح API الخاص بك لنموذج الذكاء الاصطناعي (مثل Aliyun DashScope)
      - `Cookies`: الصق سلسلة الكوكيز الكاملة من واجهة شيانيو على الويب
3. **عرض سجل التشغيل**:
   - بعد بدء الروبوت سيستمع تلقائيًا لرسائل شيانيو
   - ابحث عن `🤖 Reply:` في سجل الـ Action لمراجعة المحادثات

### ملاحظات هامة
⚠️ انتبه لقيود التشغيل المؤقتة:
- التشغيل الافتراضي **30 دقيقة** (حد حساب GitHub المجاني)
- المعلومات الحساسة (مثل الكوكيز) **لن تُخزّن** وستعمل فقط لجلسة واحدة

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 الميزات الأساسية

### محرك المحادثة الذكي
| وحدة الوظائف   | التقنية المستخدمة        | الميزات الرئيسية                                                     |
| ------------- | ----------------------- | ------------------------------------------------------------ |
| إدراك السياق   | تخزين تاريخ المحادثة     | إدارة ذاكرة محادثة خفيفة الوزن، وتقديم تاريخ المحادثة الكامل كمدخل لنموذج الذكاء الاصطناعي       |
| توجيه الخبراء  | LLM prompt+توجيه بالقاعدة | تحديد النية بناءً على هندسة الإيحاء → توزيع ديناميكي على وكلاء خبراء، يدعم التحويل بين المساومة/الدعم الفني/خدمة العملاء |

### مصفوفة الوظائف التجارية
| الوحدة      | تم التنفيذ                | المخطط له                     |
| ----------- | ------------------------ | -------------------------- |
| المحرك الأساسي | ✅ رد تلقائي بالنموذج<br>✅ إدارة السياق | 🔄 تعزيز تحليل المشاعر               |
| نظام المساومة | ✅ استراتيجية تخفيض تدريجية           | 🔄 مقارنة الأسعار في السوق            |
| الدعم الفني   | ✅ دمج البحث عبر الإنترنت             | 🔄 تعزيز قاعدة المعرفة RAG           |

## 🚴 البدء السريع

### متطلبات البيئة
- JDK 21+
- Maven 3.9.10+

### خطوات التثبيت

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 المشاركة والمساهمة

نرحب بتقديم الاقتراحات عبر Issue أو المساهمة في الكود عبر PR، يرجى اتباع [دليل المساهمة](https://contributing.md/)



## 🛡 ملاحظات هامة

⚠️ انتباه: **هذا المشروع مخصص فقط للتعلم والت交流، إذا كان هناك انتهاك للحقوق يرجى التواصل مع المؤلف لحذف المحتوى.**

نظرًا لطبيعة المشروع الخاصة، قد يقوم فريق التطوير في أي وقت بـ**إيقاف التحديثات** أو **حذف المشروع**.


## 🧸 شكر خاص

تم إعادة بناء هذا المشروع بالاعتماد على المشاريع مفتوحة المصدر التالية:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - نظام خدمة عملاء ذكي لمنصة Xianyu، تم تطويره بواسطة [@shaxiu](https://github.com/shaxiu) و[@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---