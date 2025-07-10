<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="شعار محرك ألعاب Basketo" width="200"/>
</p>

<h2 align="center">أنشئ، العب، ألهم. ألعاب تنبض بالحياة. ✨</h2>

<h1 align="center">محرك ألعاب Basketo</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- استبدل your_discord_server_id بمعرف الخادم الفعلي الخاص بك -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (formerly Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
مرحبًا بك في محرك Basketo - مشروع شغوف نبذل فيه قصارى جهدنا لإنشاء محرك رائع وعالي الأداء، مع خطة مثيرة لجعله محرك ألعاب أصلي معتمد على الذكاء الاصطناعي. يتميز بواجهة محرر مشابهة لـ Unity، تكامل Gemini AI، نظام تأثيرات صوتية متعددة متقدم، وبنية ECS قوية. سواء كنت هنا للمساهمة، أو اقتراح الأفكار، أو فقط لمتابعة تطوره، فأنت جزء من هذه الرحلة! 🚀
</p>
## 🚀 الحالة الحالية للمحرك
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Current State of Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>اطلع على أحدث التطورات والميزات أثناء العمل!</em> 🎮
</p>

## ✨ الميزات الرئيسية

### 🎮 **واجهة محرر شبيهة بوحدة Unity**
- **إعداد نافذتين**: محرر المشهد وعرض اللعبة جنبًا إلى جنب
- **التحرير المباشر**: تعديل المشاهد أثناء تشغيل اللعبة
- **لوحة الفحص**: تعديل المكونات بصريًا عن طريق السحب والإفلات
- **عرض التسلسل الهرمي**: تنظيم وإدارة الكيانات
- **متصفح الأصول**: إدارة سهلة للقوام والصوتيات

### 🤖 **تطوير أصلي بالذكاء الاصطناعي**
- **دمج Gemini AI**: أوامر باللغة الطبيعية لتطوير الألعاب
- **توليد ذكي للنصوص البرمجية**: إنشاء نصوص Lua مدعومة بالذكاء الاصطناعي
- **تعديل الكيانات**: وصف التغييرات باللغة الإنجليزية البسيطة
- **إعداد واجهة برمجة التطبيقات بسهولة**: تكوين مفتاح Gemini API مدمج
### 🔊 **نظام الصوت المتقدم**
- **تأثيرات صوتية متعددة**: عدة أصوات مسماة لكل كيان (المشي، القفز، الهجوم، إلخ)
- **الصوت التقليدي**: موسيقى خلفية وأصوات بيئة محيطة
- **تكامل مع Lua**: تشغيل الأصوات من السكريبتات باستخدام `PlaySound(entity, "action")`
- **محرر بصري**: إدارة المؤثرات الصوتية من خلال المفتش

### 🎯 **نظام الكيان-المكون (ECS)**
- **أداء عالي**: مُحسّن للتعامل مع أعداد كبيرة من الكيانات
- **تصميم معياري**: مزج المكونات ومطابقتها حسب الحاجة
- **تكامل السكريبتات**: برمجة Lua مع وصول كامل لنظام ECS
- **تحديثات فورية**: تعديل المكونات بشكل حي

### 🎨 **الرسومات والرسوم المتحركة**
- **عرض السبرايت**: خط أنابيب رسومات ثنائية الأبعاد فعّال
- **نظام الرسوم المتحركة**: رسوم متحركة معتمدة على الإطارات مع خاصية التكرار
- **نظام التحويل**: الموضع، الدوران، والتكبير/التصغير
- **نظام الكاميرا**: دعم لعدة كاميرات

### ⚡ **الفيزياء والتصادم**
- **كشف التصادم**: تصادم AABB مع تحسين مكاني
- **فيزياء الجسم الصلب**: الجاذبية، السرعة، والقوى
- **استدعاءات التصادم**: أحداث تصادم يمكن الوصول إليها عبر السكريبت
- **التقسيم المكاني**: تحسين الأداء باستخدام شجرة رباعية (Quadtree)
## 🎬 انقر على الصورة أدناه لمشاهدة عرض فيديو توضيحي:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="عرض محرك Basketo" width="500"/>
  </a>
</p>

## 🗒️ دليل البدء السريع

### 1. **احصل على مفتاح Gemini API الخاص بك** (اختياري لكن موصى به)
- قم بزيارة [Google AI Studio](https://aistudio.google.com/app/apikey)
- سجّل الدخول وأنشئ مفتاح API مجاني
- هذا يمكِّن الميزات المدعومة بالذكاء الاصطناعي مثل الأوامر باللغة الطبيعية

### 2. **البناء والتشغيل**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **تكوين ميزات الذكاء الاصطناعي**
- في المحرك، انتقل إلى لوحة أوامر الذكاء الاصطناعي (أسفل)
- ابحث عن "🤖 تكوين Gemini AI"
- أدخل مفتاح API الخاص بك واضغط على "حفظ"

### 4. **ابدأ في الإنشاء**
- جرِّب أوامر الذكاء الاصطناعي: `"create a player at 100 200"`
- أضف مؤثرات صوتية إلى الكيانات في المفتش
- اكتب سكريبتات Lua أو دع الذكاء الاصطناعي يقوم بإنشائها
- استخدم محرر النوافذ المزدوجة للتطوير الحي

## �🛠️ بناء المحرك (لينكس) 🐧

### المتطلبات الأساسية
- يجب توفر CMake 3.26.0 أو أحدث.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (لميزات الذكاء الاصطناعي)
- nlohmann/json (مضمنة كـ submodule)
- ImGui (مضمنة كـ submodule)

### خطوات البناء
```bash
# استنساخ المستودع
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### التشغيل
```bash
./BasketoGameEngine

```
إذا كنت تريد تشغيل اختبار الفيزياء:
```bash
./PhysicsTest

```

## 🛠️ بناء المحرك (ويندوز) 💻

### المتطلبات المسبقة

1. **فيجوال ستوديو 2022 (الإصدار المجتمعي أو أعلى)**  
   قم بالتثبيت مع حزم العمل التالية:
   - تطوير سطح المكتب باستخدام ++C
   - أدوات ++C CMake لنظام ويندوز
   - حزمة تطوير برامج ويندوز 10 أو 11 (SDK)

2. **CMake** (موجود مع فيجوال ستوديو أو يمكن تحميله من https://cmake.org/download/)

3. **vcpkg** (يُستخدم لتثبيت الاعتمادات البرمجية)


---
### تثبيت التبعيات

```bash
# افتح موجه أوامر المطور لـ VS 2022 أو PowerShell

# استنساخ vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# تثبيت المكتبات المطلوبة
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### خطوات البناء
```bash
# استنساخ مستودع Basketo
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# التهيئة باستخدام CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/path/to/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# استبدل "C:/path/to/vcpkg" بالمسار الكامل إلى دليل vcpkg الخاص بك

# بناء المحرك
cmake --build . --config Release
```

---

### التشغيل

```bash
# من دليل build/Release
```
./BasketoGameEngine.exe

# لتشغيل اختبار الفيزياء
./PhysicsTest.exe
```

## 📚 التوثيق

### الميزات الأساسية
- **[نظام المؤثرات الصوتية](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: دليل كامل للمؤثرات الصوتية المتعددة
- **[إعداد واجهة Gemini API](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: إعداد الذكاء الاصطناعي خطوة بخطوة
- **[برمجة Lua](assets/Scripts/)**: أمثلة على السكريبتات ومرجع API

### أمثلة على الاستخدام

#### تطوير مدعوم بالذكاء الاصطناعي
```bash
# أوامر باللغة الطبيعية
"أنشئ شخصية لاعب في الموضع 100 200"
"أضف سلوك القفز للاعب"
"اجعل العدو يتحرك بشكل أسرع"

# توليد السكريبت
gemini_script أنشئ وحدة تحكم بلعبة منصات مع قفزة مزدوجة
```

#### مؤثرات صوتية متعددة
```lua
-- في سكريبتات Lua الخاصة بك
PlaySound(entity, "jump")    -- تشغيل صوت القفز
PlaySound(entity, "walk")    -- تشغيل صوت المشي
PlaySound(entity, "attack")  -- تشغيل صوت الهجوم

-- التحقق مما إذا كان الصوت موجوداً
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### نظام المكوّنات
- **Transform**: الموقع، التدوير، التحجيم
- **Sprite**: عرض الخامات
- **Animation**: الرسوم المتحركة القائمة على الإطارات
- **Script**: سكريبتات Lua للسلوك
- **Collider**: تصادم فيزيائي
- **Rigidbody**: محاكاة فيزيائية
- **Audio**: موسيقى خلفية
- **SoundEffects**: عدة أصوات مسماة
- **Camera**: إدارة العرض
## 🤝 شارك في المشروع

نحن نحب المساهمات من مجتمعنا ❤️. للحصول على تفاصيل حول المساهمة أو تشغيل المشروع لأغراض التطوير، اطلع على [إرشادات المساهمة](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md). <!-- بافتراض وجود هذا الملف -->

- 🐛 هل وجدت خطأ؟ افتح تذكرة جديدة!
- ✨ لديك فكرة ميزة رائعة؟ نود سماعها!
- 💻 تريد المساهمة؟ قم بعمل fork، ثم برمج، ثم أنشئ طلب دمج (pull request)!

لنقم ببناء هذا المحرك معًا ونجعل تطوير الألعاب ممتعًا وسهلًا للجميع. 🌍

## 👥 المجتمع
مرحبًا بك بأحضان واسعة 🤗. نحن متحمسون جدًا لمساهمات المجتمع بكافة أنواعها - سواء كانت تحسينات على الكود 📝، تحديثات التوثيق 📚، تقارير الأخطاء 🐞، طلبات الميزات 💡، أو النقاشات في Discord الخاص بنا 🗣️.

انضم إلى مجتمعنا من هنا:

- 👋 [انضم إلى مجتمع Discord الخاص بنا](https://discord.gg/F3DswRMW)
- ⭐ [ضع نجمة لنا على GitHub](https://github.com/basketoengine/Basketo)

## 🙏 ادعمنا:
نحن نعمل باستمرار على تطوير المشروع، وهناك المزيد من الميزات والأمثلة قادمة قريبًا 🌟. إذا أعجبك هذا المشروع، يرجى وضع نجمة ⭐ في مستودع GitHub [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) للبقاء على اطلاع ودعمنا للنمو. 🌱

---

برمجة وصناعة ألعاب سعيدة! 🎉🎮

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---