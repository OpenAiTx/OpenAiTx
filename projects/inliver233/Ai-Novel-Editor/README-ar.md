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
# محرر الروايات الذكي بالذكاء الاصطناعي

محرر روايات مساعد بالذكاء الاصطناعي مبني على PyQt6، يوفر أدوات كتابة احترافية مثل الإكمال الذكي، إدارة المشاريع، وتنظيم المفاهيم.

## التثبيت

1. استنساخ المشروع
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. إنشاء بيئة افتراضية
```bash
python -m venv venv
venv\Scripts\activate     # ويندوز
```
استخدام uv
```bash
uv venv -p 3.11
```
3. تثبيت الاعتمادات
```bash
pip install -r requirements.txt
```
استخدام uv
```bash
uv sync
```

4. تشغيل البرنامج
```bash
python -m src
```

## الوظائف الرئيسية

### إدارة المشروع
- هيكل وثائق هرمي (عمل > فصل > مشهد)
- استيراد وتصدير المشاريع (يدعم TEXT، MARKDOWN، DOCX، PDF، HTML)
- نسخ احتياطي تلقائي والتحكم في الإصدارات
- إدارة مشاريع متعددة
### ميزة الإكمال الذكي بالذكاء الاصطناعي
- ثلاث أوضاع للإكمال: الإكمال التلقائي، الإكمال اليدوي (موصى به: اضغط Tab مرة واحدة للتفعيل، ثم اضغط Tab مرة أخرى لتطبيق الإكمال)، تعطيل الإكمال
- ثلاث أوضاع للسياق:
  - وضع سريع: سياق خفيف الوزن، استجابة سريعة
  - وضع متوازن: سياق متوسط، توازن بين الجودة والسرعة
  - وضع شامل: سياق المشروع الكامل، أفضل النتائج
- يدعم خدمات الذكاء الاصطناعي المتعددة: OpenAI، Claude، Tongyi Qianwen، Zhipu AI، DeepSeek، Groq وغيرها

### إدارة المخطط التفصيلي
- هيكل شجرة المخطط التفصيلي المرئي
- السحب والإفلات لترتيب وتعديل المستويات
- تنقل سريع في المستند
- تحليل المخطط التفصيلي واقتراحات التحسين

### إعدادات API
- مركز إعدادات موحد للذكاء الاصطناعي
- إعدادات جاهزة لعدة مزودي خدمات
- ميزة اختبار الاتصال
- حفظ إعدادات التكوين والاستيراد والتصدير
### إعدادات الإكمال الذكي
- قابلية ضبط تأخير التفعيل
- حد لطول الإكمال
- إعداد طول السياق
- دعم الاستجابة المتدفقة

### تحرير كلمات التلميح
- قوالب كتابة مدمجة متعددة
- قوالب كلمات تلميح مخصصة
- إدارة تصنيف القوالب
- إعداد قوالب مخصصة للوضعيات

### ميزات الواجهة
- ثيم مزدوج (فاتح/داكن)
- تخطيط ثلاثي الأعمدة (شجرة المشروع، المحرر، لوحة المفاهيم)
- شريط جانبي قابل للطي
- وضع كتابة ملء الشاشة
- وضع التركيز (جملة، فقرة، آلة كاتبة، وضع زن، وضع غامر)

### البحث والاستبدال
- البحث في نص المشروع بالكامل
- دعم التعابير النمطية (الريجيكس)
- وظيفة الاستبدال الدفعي
- خيارات بحث متقدمة

### إدارة المفاهيم
- اكتشاف تلقائي للأدوار، المواقع، والأشياء
- إدارة علاقات المفاهيم
- نظام الوسوم والتصنيفات
- إدراج سريع للمفاهيم

## اختصارات لوحة المفاتيح

- `Ctrl+N`: مشروع جديد
- `Ctrl+O`: فتح مشروع
- `Ctrl+S`: حفظ المستند
- `F11`: وضع ملء الشاشة
- `Tab`: تفعيل الإكمال التلقائي للذكاء الاصطناعي يدويًا (في الوضع اليدوي)
- `Ctrl+F`: بحث
- `Ctrl+H`: بحث واستبدال
- `Ctrl+Shift+H`: بحث واستبدال متقدم
## متطلبات النظام

- Python 3.8+
- PyQt6
- نظام التشغيل: Windows، macOS، Linux

## المؤلف

**inliver**
- البريد الإلكتروني: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---