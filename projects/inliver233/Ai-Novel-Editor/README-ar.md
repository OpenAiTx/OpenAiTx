
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# محرر الروايات بالذكاء الاصطناعي

محرر روايات مدعوم بالذكاء الاصطناعي مبني على PyQt6، يوفر أدوات كتابة احترافية مثل الإكمال الذكي، إدارة المشاريع، وتنظيم المفاهيم.

## التثبيت

1. استنساخ المشروع
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. إنشاء بيئة افتراضية
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. تثبيت الاعتمادات
```bash
pip install -r requirements.txt
```

4. تشغيل البرنامج
```bash
python src/main.py
```
## الوظائف الرئيسية

### إدارة المشاريع
- هيكلية وثائق هرمية (العمل > الفصل > المشهد)
- استيراد وتصدير المشاريع (يدعم تنسيقات TEXT، MARKDOWN، DOCX، PDF، HTML)
- نسخ احتياطي تلقائي والتحكم في الإصدارات
- إدارة مشاريع متعددة

### وظيفة الإكمال الذكي بالذكاء الاصطناعي
- ثلاثة أوضاع للإكمال: الإكمال التلقائي، الإكمال اليدوي (موصى به: اضغط Tab مرة واحدة للتفعيل، ثم مرة أخرى لتطبيق الإكمال)، تعطيل الإكمال
- ثلاثة أوضاع للسياق:
  - الوضع السريع: سياق خفيف الوزن، استجابة سريعة
  - الوضع المتوازن: سياق متوسط، توازن بين الجودة والسرعة
  - الوضع الشامل: سياق المشروع الكامل، أفضل النتائج
- دعم لخدمات الذكاء الاصطناعي المتعددة: OpenAI، Claude، Tongyi Qianwen، Zhipu AI، DeepSeek، Groq وغيرها

### إدارة المخطط التفصيلي
- هيكل شجرة مخطط تفصيلي مرئي
- ترتيب وسحب وتعديل المستويات
- تنقل سريع بين الوثائق
- تحليل المخطط التفصيلي واقتراحات تحسين

### إعدادات واجهة برمجة التطبيقات (API)
- مركز إعدادات ذكاء اصطناعي موحد
- إعدادات مسبقة لعدة مزودين
- ميزة اختبار الاتصال
- حفظ واستيراد/تصدير إعدادات التكوين

### إعدادات الإكمال الذكي
- تأخير قابل للتعديل في التفعيل
- حد لطول الإكمال
- إعداد طول السياق
- دعم الاستجابة المتدفقة

### تحرير العبارات التلميحية
- قوالب كتابة مدمجة متعددة
- قوالب تلميحية مخصصة
- إدارة تصنيف القوالب
- إعداد قوالب خاصة بكل وضع


### ميزات الواجهة
- ثيم مزدوج (فاتح/داكن)
- تخطيط ثلاثي الأعمدة (شجرة المشاريع، المحرر، لوحة المفاهيم)
- شريط جانبي قابل للطي
- وضع الكتابة بملء الشاشة
- وضع التركيز (جملة، فقرة، آلة كتابة، وضع الزن، وضع الانغماس)

### البحث والاستبدال
- بحث نصي في كامل المشروع
- دعم التعابير النمطية (Regex)
- وظيفة الاستبدال الدفعي
- خيارات بحث متقدمة

### إدارة المفاهيم
- كشف تلقائي للشخصيات، الأماكن، الأشياء
- إدارة علاقات المفاهيم
- نظام الوسوم والتصنيفات
- إدراج سريع للمفاهيم

## اختصارات لوحة المفاتيح

- `Ctrl+N`: مشروع جديد
- `Ctrl+O`: فتح مشروع
- `Ctrl+S`: حفظ المستند
- `F11`: وضع ملء الشاشة
- `Tab`: تفعيل إكمال الذكاء الاصطناعي يدويًا (في الوضع اليدوي)
- `Ctrl+F`: بحث
- `Ctrl+H`: بحث واستبدال
- `Ctrl+Shift+H`: بحث واستبدال متقدم


## متطلبات النظام

- بايثون 3.8+
- PyQt6
- أنظمة التشغيل: ويندوز، macOS، لينكس

## المؤلف

**inliver**
- البريد الإلكتروني: inliverapi@outlook.com  
- جيت هب: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---