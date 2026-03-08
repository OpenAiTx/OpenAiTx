
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">الإنجليزية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">اليابانية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">الكورية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">الهندية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">التايلاندية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">الفرنسية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">الألمانية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">الإسبانية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">الإيطالية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">الروسية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">البرتغالية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">الهولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">البولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">الفارسية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">التركية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">الفيتنامية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">الإندونيسية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# تقويم العائلة الذكي المنزلي DIY (نسخة Skylight)

![تقويم Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 مقدمة

في الآونة الأخيرة، تعرضت زوجتي لسيل من الإعلانات على وسائل التواصل الاجتماعي حول تقاويم المنازل الذكية (Skylight، Cozyla، Hearth) وكانت على استعداد لإنفاق أكثر من 300 دولار على واحد منها. قبل أن أعطيها الموافقة، طلبت فرصة للبحث عنها.

لاحظت أن معظم الخيارات تقدم وظائف متشابهة ولكنها تختلف بشكل كبير في السعر. والأهم من ذلك، لم أجد أي ميزة بارزة لا يمكنني تنفيذها في **Home Assistant**.

**الهدف:** تقويم بشاشة لمس يوضع على سطح الطاولة، مقبول وفق معيار WAF (عامل قبول الزوجة)، ويتكامل بعمق مع منزلنا الذكي بدون رسوم شهرية.

## 💡 لماذا التصنيع الذاتي؟

اختيار طريق التصنيع الذاتي باستخدام Home Assistant قدم عدة فوائد مقارنة بشراء شاشة Skylight/Hearth:

* **لا رسوم شهرية:** تجنب الاشتراكات للحصول على ميزات "مميزة".
* **تكامل سلس:** يتواصل مع أضوائنا، المهام المنزلية (Grocy)، وأجهزة استشعار التواجد.
* **إعادة استخدام الأجهزة القديمة:** تم إعادة توظيف Mini PC وشاشة قياسية.
* **الخصوصية:** لا يوجد ارتباط بمورد أو خطر إيقاف الشركة لخدماتها.

## 🛠 اختيار الأجهزة

حالياً تم بناء النظام ليعرض لوحة التحكم على أي شاشة HD (1920x1080).

بالنسبة لي، كان الشرط أن "يشبه" skylight، يكون بشاشة لمس، يوضع على سطح الطاولة، وإمكانية نقله إلى أماكن مختلفة. لذلك اخترت الأجهزة الموضحة أدناه.
ومع ذلك، قد يكون وضعك مختلفاً وقد تحتاج إلى تعديل ذلك حسب الحاجة، على سبيل المثال إذا كنت تريد عرضه على جهاز لوحي أو شيء آخر.

الأجهزة التي استخدمتها في البداية اخترتها بناءً على ما ذكرت أعلاه بالإضافة إلى أمل توسيع الوظائف باستخدام الكاميرا، السماعة والميكروفون. حالياً ربما كنت سأبنيه بطريقة مختلفة الآن بعد التجربة، لأنني لم أجد وقتاً لمعالجة أفكار الأجهزة الإضافية تلك.

* **الشاشة:** [شاشة HP Engage لمس 15 بوصة](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). اخترتها على الشاشات المحمولة العادية لأنها تحتوي على **سماعة، كاميرا ويب، وميكروفون** مدمجين، مما يسمح بإضافة تحكم صوتي أو مكالمات فيديو مستقبلاً.
* **الحاسوب:** جهاز Mini PC قديم (NUC/Tiny PC) يعمل بنظام Windows/Linux بوضع Kiosk، أو Raspberry Pi 4.~~

## ✨ الميزات

* **عرض عائلي وفردي:** تبديل عرض تقاويم أفراد العائلة حسب الرغبة.
* **مزامنة ثنائية الاتجاه:** تعديل الأحداث على الشاشة أو على هواتفنا (تقويم Google).
* **نافذة "إضافة حدث":** واجهة مستخدم مخصصة لإضافة الأحداث مباشرة إلى تقاويم محددة من الشاشة.
* **الطقس والتاريخ:** رأس جميل وسهل القراءة.
* **استجابة تلقائية:** يعدل عدد الأيام تلقائياً حسب عرض الشاشة (جوال مقابل سطح المكتب).

---

## ⚙️ دليل التثبيت

*ملاحظة: هذا الإعداد يستخدم **حزمة YAML** لإنشاء جميع المساعدين والبرمجيات النصية والمتغيرات الضرورية تلقائياً. لا تحتاج إلى إنشائها يدوياً.*


### 1. المتطلبات الأساسية (HACS)

يجب أن يكون لديك [HACS](https://hacs.xyz/) مثبتًا. يرجى تثبيت تكاملات **الواجهة الأمامية** التالية:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (مطلوب لعمل النوافذ المنبثقة)
* `layout-card` (مطلوب لعرض الأقسام)
* `button-card` (مطلوب لإضافة الحدث من النافذة المنبثقة)

*ملاحظة: في الإعدادات → الأجهزة والخدمات، تأكد من ظهور Browser Mod كتكامل (قرص) وليس فقط تحت HACS.
إذا لم يكن هناك، انقر على إضافة تكامل → Browser Mod وأكمل الخطوات، ثم أعد تشغيل HA.
التثبيت عبر HACS يقوم فقط بتحميل الملفات؛ يجب إضافة التكامل حتى يسجل HA إجراءاته/كياناته.

### 2. الخلفية (العقل)

1. افتح ملف `configuration.yaml` في Home Assistant.
2. تأكد من إضافة هذا السطر تحت `homeassistant:` لتمكين الحزم:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. أنشئ مجلدًا باسم `packages` في دليل إعدادات HA الخاص بك (إذا لم يكن موجودًا لديك).
4. قم بتنزيل [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) من هذا المستودع.
5. ابحث عن السلسلة [ #<--- UPDATE THIS ENTITY] وقم بتحديث معرّف كيان التقويم ليتناسب مع بيئتك. راجع القسم 3 لمزيد من التفاصيل.
6. ضع الملف داخل مجلد `packages/` الخاص بك.
7. **أعد تشغيل Home Assistant**.

### 3. التقويمات

يمكنك استخدام **تقويمات Google** أو **التقويمات المحلية**.

#### الخيار أ: إعادة استخدام أسماء التقويمات (الأسهل)


1. انتقل إلى **الإعدادات > الأجهزة والخدمات**.
2. أضف تكامل **التقويم المحلي**.
3. أنشئ تقويمات بأسماء مطابقة تمامًا: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`.
    * *إذا استخدمت هذه الأسماء، سيعمل الكود مباشرة!*

#### الخيار ب: تقويم مخصص

1. انتقل إلى **الإعدادات > الأجهزة والخدمات**.
2. أضف تكامل **التقويم المحلي** أو **تقويم Google**.
3. انتقل إلى **الإعداد > التكاملات > التقويم المحلي** أو **تقويم Google** واختر "إضافة إدخال"
4. لكل إدخال تم إنشاؤه، احصل على معرّف الكيان لتحديث ملف dashboard.yaml.
5. افتح `dashboard.yaml`.
6. ابحث عن `# <--- UPDATE THIS ENTITY`.
7. حدث معرّف الكيان ليتناسب مع بيئتك


#### إعداد العطل الرسمية

منذ تحديثات Home Assistant، تتم إضافة العطل الرسمية الآن عبر الواجهة الرسومية:

1. انتقل إلى **الإعدادات > الأجهزة والخدمات > إضافة تكامل > عطلة**.
2. اختر بلدك.
3. تحقق من معرّف الكيان (مثال: `calendar.holidays`). إذا كان يختلف عن الافتراضي، حدّثه في ملف YAML للوحة المعلومات.

### 4. لوحة المعلومات (المظهر)


1. انتقل إلى **الإعدادات > لوحة التحكم**
2. انقر على **إضافة لوحة تحكم** (اختر خيار "لوحة تحكم جديدة من الصفر" وتأكد من اختيار "إضافة إلى الشريط الجانبي").
3. في القائمة اليسرى، حدد لوحة التحكم الجديدة التي أنشأتها ثم انقر على أيقونة القلم لتحريرها.
5. اختر أيقونة النقاط الثلاث ثم اختر "محرر التهيئة الخام".
6. انسخ والصق الكود من [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).

### الخطوة 5: السمة (اختياري)

للحصول على شكل الخط المحدد (Ovo):

1. تأكد من وجود هذا السطر في ملف `configuration.yaml` تحت قسم `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. أنشئ مجلدًا باسم `themes` في دليل الإعدادات الخاص بك.
3. قم بتنزيل [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) وضعه في ذلك المجلد.
4. استخدم محرر الملفات وقم بتحميل calbackgrd.png إلى مجلد /www/، والذي يُترجم داخليًا إلى /local على لوحة المعلومات.
5. أعد تشغيل Home Assistant.
6. انتقل إلى ملفك الشخصي (رمز المستخدم أسفل اليسار) وغيّر **السمة** إلى `Skylight`.
ملاحظة: السمة ليست شاملة، لذا ضع ذلك في اعتبارك

---

## 📐 كيف يعمل (تحت الغطاء)

### منطق التصفية

بطاقة `week-planner-card` لا تدعم إخفاء تقاويم محددة ديناميكيًا بشكل افتراضي. لحل ذلك، استخدمت **حقول نصية إدخالية** تعمل كمرشحات Regex.

* عندما تضغط على زر شخص ما، يتم تبديل مرشحهم بين ‎`.*`‎ (عرض الكل) و ‎`^$`‎ (عدم عرض شيء).
* بطاقة ‎`config-template-card`‎ تضخ هذه المتغيرات في بطاقة التقويم ديناميكيًا.

### برنامج إنشاء الحدث

نافذة "إضافة حدث" المنبثقة تستخدم برنامجًا واحدًا يتعامل مع المنطق لعدة أشخاص وأنواع أحداث (طوال اليوم مقابل محدد الوقت).


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## ملاحظات

كان منشوري الأصلي مجرد إعطاء نظرة عامة عالية المستوى حول كيفية القيام بذلك والسماح للناس بتعديل الكود ليعمل في سيناريوهاتهم الخاصة.

فعلت ذلك بشكل خاص لأن كل شاشة واحتياج مختلفان. لا يمكنني التطوير لجميع أحجام الشاشات، ولوحات المعلومات، وما إلى ذلك. لذا تم بناؤه ليعمل على الشاشة التي ذكرتها أو أي شاشة (1920x1080) ولكن يجب أن يكون قابلاً للتعديل للآخرين.

وبالحديث عن الشاشة، لقد اقترحت تلك في الأصل لأنها كانت معروضة للبيع في Woot وكانت طريقة اقتصادية جدًا للحصول على شاشة تعمل باللمس في ذلك الوقت. قد لا يكون هذا هو الحال الآن، لذا استخدم أي شاشة تناسبك. جهاز لوحي، شاشة لمس، هاتف، أي شيء. الشيء الرئيسي الذي ستحتاج إلى تعديله هو لوحة المعلومات.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---