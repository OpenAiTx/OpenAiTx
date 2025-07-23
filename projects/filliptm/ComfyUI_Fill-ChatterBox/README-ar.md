<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

إذا أعجبك هذا المشروع، يمكنك دعمي على باتريون!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

امتداد عقدة مخصص لـ ComfyUI يضيف إمكانيات تحويل النص إلى كلام (TTS) وتحويل الصوت (VC) باستخدام مكتبة Chatterbox.
يدعم حتى 40 ثانية كحد أقصى. لقد حاولت إزالة هذا القيد، لكن النموذج يفشل بشكل كبير مع أي مدة أطول من ذلك، لذا بقي على حاله.

![ChatterBox Example](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## التثبيت

1. قم باستنساخ هذا المستودع داخل دليل custom_nodes في ComfyUI الخاص بك:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. قم بتثبيت الاعتمادات الأساسية:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (اختياري) قم بتثبيت دعم العلامة المائية:

   ```bash
   pip install resemble-perth
   ```
**ملاحظة**: قد تواجه حزمة `resemble-perth` مشاكل توافق مع Python 3.12+. إذا واجهت أخطاء في الاستيراد، ستظل العقد تعمل بدون العلامة المائية.

## الاستخدام

### عقدة تحويل النص إلى كلام (FL Chatterbox TTS)
- أضف عقدة "FL Chatterbox TTS" إلى سير العمل الخاص بك
- قم بتكوين مدخل النص والمعلمات (المبالغة، cfg_weight، درجة الحرارة)
- يمكنك اختيارياً توفير موجه صوتي لاستنساخ الصوت

### عقدة تحويل الصوت (FL Chatterbox VC)
- أضف عقدة "FL Chatterbox VC" إلى سير العمل الخاص بك
- قم بتوصيل الصوت المدخل والصوت المستهدف
- كلا العقدتين تدعمان الرجوع إلى المعالج المركزي في حال حدوث أخطاء CUDA

## سجل التغييرات

### 2025/6/24
- تمت إضافة معلمة البذرة إلى كل من عقدتي TTS و VC لتوليد قابل لإعادة الإنتاج
- نطاق البذرة: من 0 إلى 4,294,967,295 (عدد صحيح 32-بت)
- يتيح إخراجاً صوتياً متسقاً لأغراض التصحيح والتحكم في سير العمل
- جعل العلامة المائية الخاصة بـ Perth اختيارية لإصلاح مشاكل التوافق مع Python 3.12+
- العقد تعمل الآن بدون العلامة المائية إذا فشل استيراد resemble-perth

### 2025/5/31
- تمت إضافة تحميل النماذج بشكل دائم، ووظيفة شريط التحميل
- تمت إضافة دعم أجهزة Mac (بحاجة للاختبار، تواصل معي إذا كنت مهتماً)
- تمت إزالة مكتبة chatterbox-tts وتم تنفيذ كود الاستدلال الأصلي.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---