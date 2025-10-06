
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# استبدال لوحة الدوائر المطبوعة MiciMike لجهاز Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) هو بديل لوحة دوائر مطبوعة لجهاز ["Google Nest Mini" (مكبر الصوت الذكي من الجيل الثاني من جوجل مع منفذ شحن بموصل برميلي)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))، ولكنه يعتمد على متحكمات ESP32 و XMOS لتشغيل البرامج مفتوحة المصدر.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

نصيحة! إذا كنت تبحث بدلاً من ذلك عن بديل مشابه للوحة الدوائر المطبوعة لجهاز "Google Home Mini" (مكبر الصوت الذكي من الجيل الأول من جوجل مع منفذ شحن Micro-USB)، تحقق من المشروع الشقيق على https://github.com/iMike78/home-mini-v1-drop-in-pcb

كلا المشروعين هما مشاريع أجهزة مفتوحة المصدر بالكامل، يستلهمان بعض الأفكار من [Onju Voice](https://github.com/justLV/onju-voice) ولكن يهدفان إلى اتباع [معيار المساعدات الصوتية المفتوحة لمؤسسة Open Home مع إصدار المعاينة الصوتية لـ Home Assistant كمرجع](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) لتصميمات وأواصفات لوحات الدوائر المطبوعة.

# نطاق المشروع

هدف هذا المشروع والمستودع (المشابه لـ [Onju Voice](https://github.com/justLV/onju-voice) لكن تحت ترخيص أجهزة مفتوحة المصدر بالكامل) هو تصميم لوحة دوائر مطبوعة بديلة جاهزة (PCB) مع مخططات الأجهزة بحيث يمكن لأي شخص تصنيعها أو طلبها من مصنع لوحات دوائر مطبوعة كبديل مخصص لجهاز Google Nest Mini (الجيل الثاني).

يستهدف هذا بشكل أساسي الأشخاص الذين يرغبون في تحويل/إعادة استخدام مكبرات الصوت الذكية Google Nest Mini القديمة الخاصة بهم إلى أجهزة مفتوحة المصدر للتحكم الصوتي في [Home Assistant](https://www.home-assistant.io/voice_control/) و/أو كمخرج مكبر صوت لمشغل الوسائط لـ [Music Assistant](https://www.music-assistant.io)، (ومع ذلك يمكن استخدام الجهاز أيضاً مع تطبيقات أخرى مع برامج ثابتة مختلفة لأنه يعتمد على منصة Espressif ESP32 الشهيرة).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

سيتم دمج التصميم المادي (كما في [إصدار معاينة الصوت لـ Home Assistant](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) دائرة متكاملة ESP32-S3 للواي فاي، والبلوتوث، و[اكتشاف كلمة التنبيه على اللوحة](https://www.home-assistant.io/voice_control/about_wake_word/) (باستخدام برنامج [ESPHome](https://esphome.io/) بدون كود) + شريحة XMOS xCORE XU316 لمعالجة الصوت المتقدمة (مع برنامج ثابت مخصص لتنظيف الميكروفون بهدف تحسين قدرات التعرف على الصوت باستخدام خوارزميات محلية لقمع الضوضاء، إلغاء الصدى الصوتي، إلغاء التداخل، والتحكم التلقائي في الكسب).

من ناحية الوظائف، تم تصميمه ليكون متوافقاً إلى حد كبير مع الأجهزة المرجعية لإصدار معاينة الصوت لـ [Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (التي تم إصدارها كمخططات أجهزة مفتوحة المصدر من مؤسسة Open Home بالتعاون مع Nabu Casa). وسيكون الاختلاف الرئيسي بسبب القيود التي يفرضها هيكل Google Nest Mini ومكوناته، أي أن تصميم nest-mini-drop-in-pcb سيكون محدوداً بنفس نوع المدخلات المادية التي يتوفر عليها الجهاز الأصلي من Google.

وبالتالي، فإن نطاق هذا المشروع/المستودع لا يشمل تطوير ميزات أو وظائف جديدة لبرنامج ESPHome الثابت، فإذا كنت ترغب في ذلك فعليك بدلاً من ذلك الرجوع إلى تطوير برنامج إصدار معاينة الصوت لـ Home Assistant بالإضافة إلى كود ESPHome الأساسي:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## طلب التعاون

إذا كان لديك خبرة في تصميم تخطيط لوحات الدوائر المطبوعة، (وخاصة في توجيه المسارات، وسكب الأرضي، أو تخطيطات رقمية + تماثلية حساسة للضوضاء)، **فمساعدتك محل تقدير كبير**! يرجى فتح قضية جديدة، تقديم اقتراحات/طلبات، وإضافة مدخلات/ملاحظات للقضايا الموجودة، أو عمل fork لهذا المستودع.

لمزيد من المعلومات حول المفهوم/الفكرة ولمناقشة الموضوع، يرجى مراجعة والمساهمة في هذا النقاش في منتدى مجتمع Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### الوضع الحالي

- ✅ تم الانتهاء من المخطط
- ✅ تم وضع المكونات
- ✅ تم الانتهاء من التوجيه
- ✅ تم الانتهاء من سكب الأرضي، واستراتيجية الحماية، واعتبارات التداخل الكهرومغناطيسي
- ⚠️ فشلت الدفعة الاختبارية الأولى بسبب خطأين - تم إصلاحهما
- 🕓 في انتظار الدفعة الاختبارية الثانية

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## الأدوات المستخدمة

- 🛠️ كي كاد 9
- 🧰 SnapEDA / LCSC لمصادر البصمة

## المواصفات المعروفة للأجهزة

- لوحة دوائر مطبوعة بأربع طبقات
- شريحة ESP32-S3R8 مجردة (ESP32-S3 للواي فاي، البلوتوث، والكشف عن كلمة التنبيه المدمج)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP لمعالجة الصوت)
- فلاش مزدوج SPI
- ناقلا I²S مزدوجان (للسماح بواجهات I2S في نفس الوقت، أي الإخراج والإدخال الصوتي المتزامن)
- MAX98357 لإخراج السماعة (مضخم صوت أحادي الفئة-D عبر I2S)
- 2x ميكروفونات MEMS (MSM261DHP)
- مصابيح SK6812
- إدخال طاقة USB-C مخصص وطاقة 14V

---

> ⚠️ البرمجة عبر USB-C تتطلب فصل مدخل الطاقة الرئيسي 14V. راجع ملاحظة السلك سكرين على اللوحة لمزيد من التفاصيل.

## المراجع

### موارد إصدار المعاينة الصوتية لـ Home Assistant بما في ذلك ملفات تصميم اللوحة
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### البرنامج الثابت ESPHome لـ Home Assistant Voice PE (والذي يستخدم أيضاً نفس مجموعة ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### شريحة المعالجة XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### البرنامج الثابت من XMOS الخاص بمشروع ESPHome لأجهزة Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## الترخيص

تم ترخيص هذا المشروع بموجب [رخصة سيرن للأجهزة المفتوحة الإصدار 2 - متبادل بقوة (CERN-OHL-S v2)]
يجب أن يتم توزيع أي إصدار معدل من هذا الجهاز تحت نفس الرخصة أيضًا.

☕ إذا رغبت في دعم هذا المشروع، يمكنك [شراء لي قهوة على Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---