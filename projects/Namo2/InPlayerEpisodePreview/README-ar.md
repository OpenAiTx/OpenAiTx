<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <p>تم إنشاء الترجمات التالية تلقائيًا باستخدام الذكاء الاصطناعي. يرجى ملاحظة أنها قد تتضمن بعض الأخطاء أو تشير إلى إصدارات أقدم من ملف القراءة هذا.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

معاينة حلقات المشغل
====================
## 📄 حول
يضيف هذا الإضافة قائمة حلقات إلى مشغل الفيديو، مما يتيح لك معاينة كل حلقة من المسلسل التلفزيوني دون الحاجة لمغادرة المشغل.

يدعم هذا التعديل العملاء التاليين:
* [عميل Jellyfin للويب](https://github.com/jellyfin/jellyfin-web)
* [مشغل وسائط Jellyfin](https://github.com/jellyfin/jellyfin-media-player) (JMP) عميل سطح المكتب

## ✨ الميزات
* عرض جميع حلقات الموسم
* التبديل بين المواسم
* عرض عنوان الحلقة والوصف والصورة المصغرة وتقدم التشغيل
* عرض تفاصيل الحلقة مثل التقييم المجتمعي
* تعليم الحلقات كمشاهدة أو مفضلة
* بدء حلقة جديدة
* يجب أن يعمل مع السمات المخصصة

## 📸 معاينة
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

السمة المستخدمة: (SkinManager) Kaleidochromic
<br>
هذه المعاينة تفتقد الأزرار الجديدة لتعليم الحلقة كمكتملة أو مفضلة.

## 🔧 التثبيت

### عميل الويب لجليفاين (الخادم)

> [!ملاحظة]
> يُنصح بشدة بتثبيت [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) على الأقل الإصدار v2.2.1.0. فهو يساعد على تجنب مشاكل الأذونات أثناء تعديل ملف index.html على أي نوع من التثبيت!
<details open>
<summary> عرض التعليمات... </summary>

1. أضف ملف التعريف `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` كمستودع إضافات جليفاين إلى الخادم الخاص بك.
2. قم بتثبيت الإضافة `InPlayerEpisodePreview` من المستودع.
3. أعد تشغيل خادم جليفاين.
</details>

### عميل سطح المكتب Jellyfin Media Player (JMP) (مهمل)
<details>
<summary> عرض التعليمات... </summary>

**تم إهماله مع إصدار JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

نظرًا لأن العميل الجديد لـ JMP يستخدم مشغل الويب الحالي من الخادم نفسه، لم يعد من الضروري إجراء أي تغييرات مباشرة على كود العميل.

هذه هي الطريقة الموصى بها لتثبيت السكريبت على عميل سطح المكتب.
إذا لم تكن تشعر بالراحة في تعديل ملف nativeshell.js بنفسك (الخطوات من 3 إلى 6)، يمكنك بدلاً من ذلك تحميل الإصدار الكامل، والذي يتضمن السكربت مضافاً بالفعل إلى ملف nativeshell.js.
لا يزال من غير الواضح ما إذا كانت هناك مشاكل محتملة عند استبدال ملف nativeshell.js بالملف الموجود في الإصدار، لذا يُنصح باتباع جميع الخطوات أدناه.

1. قم بتنزيل أحدث إصدار [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) أو [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (يتضمن السكربت مضافاً بالفعل إلى ملف nativeshell.js)
2. استخرج ملف zip إلى دليل Jellyfin الخاص بك (مثال: C:\Program Files\Jellyfin\Jellyfin Media Player)
3. داخل دليل Jellyfin الخاص بك، اتبع مسار المجلد "web-client\extension"
4. افتح ملف "nativeshell.js" في محرر نصوص.
5. داخل الملف، ابحث عن القسم `const plugins = [];`. أضف سطرًا جديدًا في بداية القائمة والصق `'inPlayerEpisodePreviewPlugin',`. يجب أن يبدو القسم الآن مشابهاً لهذا:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. احفظ الملف وأعد تشغيل عميل JMP.
</details>

## 💡 استكشاف الأخطاء وإصلاحها

### 1. زر المعاينة غير ظاهر
غالبًا ما يكون ذلك مرتبطًا بأذونات خاطئة لملف `index.html`.

<details>
<summary> عرض قائمة بالحلول الممكنة... </summary>

#### 1.1 تجنب هذه المشكلة باستخدام إضافة [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation).

#### 1.2 تغيير الملكية داخل حاوية دوكر
إذا كنت تشغل jellyfin داخل حاوية دوكر، يمكنك تغيير الملكية بالأمر التالي
(استبدل jellyfin باسم الحاوية الخاصة بك، user و group باسم المستخدم والمجموعة للحاوية):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
يمكنك تشغيل هذا كوظيفة مجدولة (cron job) عند بدء تشغيل النظام.
(شكرًا لـ [muisje](https://github.com/muisje) لمساعدته في [هذا](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) الحل)

#### 1.3 تغيير الملكية عند التشغيل على نظام ويندوز
1. انتقل إلى: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. انقر بزر الفأرة الأيمن على `index.html` → `خصائص` → علامة تبويب `الأمان` → انقر على `تعديل`
3. اختر المستخدم الخاص بك من القائمة ثم ضع علامة في مربع إذن الكتابة.
4. أعد تشغيل كل من الخادم والعميل.
   (شكرًا لـ [xeuc](https://github.com/xeuc) على [هذا](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) الحل)

إذا لم تنجح أي من الحلول السابقة، يرجى مراجعة المشكلات القديمة. مثل [هنا](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) أو [هنا](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
إذا واجهت أي خطأ لا يمكنك حله بنفسك، لا تتردد في فتح تذكرة جديدة.
<br/>يرجى تذكر أن كل نظام مختلف وقد يؤدي ذلك إلى سلوك غير متوقع، لذا أضف أكبر قدر ممكن من المعلومات عنه.
<br/>سجلات Jellyfin وسجلات وحدة التحكم من المتصفح (مسبوقة بـ [InPlayerEpisodePreview]) تكون دائمًا مفيدة.

## الشكر والتقدير
هيكلية الإضافة مبنية وملهمة من إضافة [Jellyscrub](https://github.com/nicknsy/jellyscrub) بواسطة [NickNSY](https://github.com/nicknsy).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---