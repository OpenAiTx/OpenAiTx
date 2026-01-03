
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">الإنجليزية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">اليابانية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">الكورية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">الهندية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">التايلاندية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">الفرنسية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">الألمانية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">الإسبانية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">الإيطالية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">الروسية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">البرتغالية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">الهولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">البولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">الفارسية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">التركية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">الفيتنامية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">الإندونيسية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">الآسامية</
      </div>
    </div>
  </details>

</div>

# لوحة الدوائر المطبوعة البديلة MiciMike لجهاز Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) هي لوحة دوائر مطبوعة بديلة لجهاز ["Google Nest Mini" (مكبر الصوت الذكي من الجيل الثاني من جوجل مع منفذ شحن أسطواني)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))، لكنها تعتمد على متحكمات ESP32 و XMOS لتشغيل البرمجيات مفتوحة المصدر.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

نصيحة! إذا كنت تبحث بدلاً من ذلك عن لوحة دوائر مطبوعة بديلة مماثلة لجهاز "Google Home Mini" (مكبر الصوت الذكي من الجيل الأول من جوجل مع منفذ شحن Micro-USB)، يمكنك الاطلاع على المشروع الشقيق على الرابط https://github.com/iMike78/home-mini-v1-drop-in-pcb
كلا المشروعين هما مشاريع أجهزة مفتوحة المصدر بالكامل، حيث تم استلهام بعض الأفكار من [Onju Voice](https://github.com/justLV/onju-voice)، لكن الهدف هو اتباع [معيار مساعدين الصوت المفتوح من مؤسسة المنزل المفتوح مع إصدار المعاينة الصوتية لمساعد المنزل كمصدر مرجعي](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) لتصميمات PCB والمواصفات.

# نطاق المشروع

هدف هذا المشروع والمستودع (الذي يشبه [Onju Voice](https://github.com/justLV/onju-voice) ولكن تحت ترخيص أجهزة مفتوحة المصدر بالكامل) هو تصميم لوحة دوائر مطبوعة بديلة جاهزة (PCB) مع مخططات الأجهزة التي يمكن لأي شخص تصنيعها أو طلبها من مصنع لوحات دوائر مطبوعة كبديل مخصص لجهاز Google Nest Mini (الجيل الثاني).

يستهدف هذا بشكل أساسي الأشخاص الذين يرغبون في تحويل/إعادة استخدام مكبرات الصوت الذكية Google Nest Mini القديمة إلى أجهزة مفتوحة المصدر من أجل [التحكم الصوتي في مساعد المنزل](https://www.home-assistant.io/voice_control/) و/أو إخراج مكبر الصوت كمشغل وسائط لـ [Music Assistant](https://www.music-assistant.io)، (وربما يمكن استخدام الأجهزة أيضًا مع تطبيقات أخرى باستخدام برامج ثابتة مختلفة لأنها تعتمد على منصة Espressif ESP32 الشهيرة).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

سيتكامل تصميم الأجهزة (مشابهًا لـ [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) مع شريحة ESP32-S3 SoC للاتصال اللاسلكي WiFi و BLE، و [اكتشاف كلمة التنبيه المدمج](https://www.home-assistant.io/voice_control/about_wake_word/) (باستخدام برنامج [ESPHome firmware](https://esphome.io/) بدون كود) + شريحة XMOS xCORE XU316 لمعالجة الصوت المتقدمة (مع برنامج ثابت مخصص لتنظيف الميكروفون لتحسين قدرات التعرف على الصوت باستخدام خوارزميات تعمل محليًا مثل كبت الضوضاء، وإلغاء الصدى الصوتي، وإلغاء التداخل، والتحكم التلقائي في الكسب).

من ناحية الوظائف، تم تصميمه ليكون متوافقًا إلى حد كبير مع الأجهزة المرجعية لـ [Home Assistant Voice Preview Edition (المعروفة أيضًا باسم Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) التي تم إصدارها كتصميم أجهزة مفتوحة المصدر من مؤسسة المنزل المفتوح بالتعاون مع Nabu Casa). الاختلاف الرئيسي سيكون بسبب القيود التي يفرضها غلاف ومكونات Google Nest Mini، (أي أن تصميم nest-mini-drop-in-pcb للأجهزة سيكون محدودًا بنفس نوع الإدخالات الفيزيائية مثل الأجهزة الأصلية من Google).

وبالتالي، فإن نطاق هذا المشروع/المستودع ليس لتطوير ميزات/وظائف جديدة لبرنامج ESPHome الثابت، فإذا كنت ترغب بذلك فعليك التوجه إلى تطوير البرنامج الثابت لإصدار المعاينة الصوتية لمساعد المنزل بالإضافة إلى كود ESPHome الرئيسي:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## طلب التعاون

إذا كان لديك خبرة في تصميم تخطيط PCB، (وخاصة في توجيه PCB، وصب الأرضي، أو تخطيطات رقمية+تناظرية حساسة للضوضاء)، **فمساعدتك محل تقدير كبير**! يرجى الشعور بالحرية في فتح قضية جديدة، وتقديم اقتراحات/طلبات، وإضافة المدخلات/الملاحظات إلى القضايا الحالية، أو عمل فورك لهذا المستودع.

لمزيد من المعلومات حول المفهوم/الفكرة، يرجى الإطلاع والمساهمة في المناقشة ذات الصلة في هذا الموضوع على منتدى مجتمع Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### الحالة الحالية

- ✅ تم الانتهاء من المخطط
- ✅ تم وضع المكونات
- ✅ تم الانتهاء من التوجيه
- ✅ تم الانتهاء من صب الأرضي، واستراتيجية الحماية، واعتبارات EMI
- ⚠️ فشل الدفعة التجريبية الأولى بسبب خطأين - تم إصلاحهما
- 🕓 بانتظار الدفعة التجريبية الثانية

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## الأدوات المستخدمة

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC لمصادر البصمات الإلكترونية

## المواصفات المعروفة للأجهزة

- لوحة PCB بأربع طبقات
- شريحة ESP32-S3R8 مجردة (ESP32-S3 للواي فاي، البلوتوث، واكتشاف كلمة التنبيه المدمج)
- XMOS XU316-1024-QF60B-C24 (معالج صوت DSP من نوع XMOS XU316 xCORE)
- ذاكرة فلاش SPI مزدوجة (حيث أن ESP32 وXMOS لديهما ذاكرة فلاش SPI خاصة بكل منهما)
- ناقلا I²S مزدوجان (للسماح بواجهات I2S في نفس الوقت، أي الإخراج الصوتي والإدخال الصوتي المتزامنين)
- MAX98357 لإخراج الصوت للسماعة (مضخم صوت أحادي من الفئة D عبر I2S)
- 2x ميكروفونات MEMS (زوج من MMICT390200012 مع مسافة 68 مم بين الميكروفونين)
- 6x مصابيح LED RGB نوع SK6812
- مدخل طاقة مخصص USB-C و14 فولت (ملاحظة! لا يمكن توصيل USB-C وموصل البرميل في نفس الوقت)

---

> ⚠️ البرمجة عبر USB-C تتطلب فصل مدخل طاقة 14 فولت الرئيسي. راجع الملاحظة المطبوعة على اللوحة لمزيد من التفاصيل.

## المراجع

### مصادر إصدار المعاينة الصوتية لـ Home Assistant بما في ذلك ملفات تصميم PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### برنامج ESPHome الثابت لـ Home Assistant Voice PE (الذي يستخدم أيضًا نفس تركيبة ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### دائرة تحكم XMOS xCORE DSP (XU316-1024-QF60B-C32) IC

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### برنامج XMOS الثابت من مشروع ESPHome لأجهزة Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## الترخيص

تم ترخيص هذا المشروع بموجب [رخصة الأجهزة المفتوحة من سيرن النسخة 2 - متبادلة بقوة (CERN-OHL-S v2)]
يجب أيضًا توزيع أي إصدار معدل من هذا الجهاز بنفس الرخصة.

☕ إذا كنت ترغب في دعم هذا المشروع، لا تتردد في [شراء كوب قهوة لي على Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---