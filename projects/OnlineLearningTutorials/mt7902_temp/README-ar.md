
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 برنامج تشغيل MT7902 كجزء فرعي من برنامج تشغيل MT7921 (✅ يعمل)
شريحة Mediatek mt7902 واي فاي 6E تدعم البلوتوث والواي فاي

> [!هام]
> نواة لينوكس 7.1 تدعم رسمياً شريحة MT7902 WIFI 6E

## 📁 استنساخ المستودع

قم باستنساخ المستودع إلى جهاز الكمبيوتر المحلي الخاص بك
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
إذا كنت لا تريد استنساخ السجل السابق إذًا
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## التثبيت


### 🚀 دليل تثبيت البرنامج النصي (موصى به لأنظمة Ubuntu)
اجعل البرنامج النصي قابلًا للتنفيذ إذا لم يكن كذلك بالفعل
```
chmod +x ./install_guide.sh
```
الآن شغّل هذا البرنامج النصي
```
./install_guide.sh
```
سيطلب كلمة المرور تلقائيًا عند الحاجة
* سيطلب منك هذا السكربت تثبيت البرنامج الثابت وبرنامج تشغيل البلوتوث والواي فاي واحدًا تلو الآخر
* تم اختباره على أوبونتو مع نواة لينكس 7.0

### 🚀 إصلاح تلقائي سهل (موصى به للأنظمة المبنية على Arch)
إذا كنت ترغب في إصلاح الواي فاي والبلوتوث بسرعة على أي نواة حديثة، اتبع الخطوات التالية:

اجعل السكربت قابلاً للتنفيذ إذا لم يكن كذلك بالفعل
```
chmod +x ./fix_my_wifi.sh
```

**قم بتشغيل سكريبت الإصلاح التلقائي** باستخدام sudo:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 ما يقوم به هذا السكربت:
* **التحقق من التبعيات:** يتأكد من توفر `gcc`/`clang`، و `make`، و `bc`، ورؤوس النواة الحالية (`kernel-headers`) لديك. إذا لم تكن موجودة - يقوم بتثبيتها باستخدام مدير الحزم المفضل لديك.
* **ترجمة التعريفات:** يبني تلقائيًا تعريفات الواي فاي والبلوتوث المطابقة لإصدار النواة الخاص بك.
* **إصلاح دائم:** يثبت خدمة نظام تضمن بقاء الواي فاي نشطًا حتى بعد إعادة تشغيل الحاسوب.
* **الأمان:** يثبت الوحدات في مجلد مخصص (`/lib/modules/mt7902_custom`) لتجنب التلاعب بملفات النظام الافتراضية.

> [!NOTE]
> ستحتاج إلى اتصال بالإنترنت (عن طريق الإيثرنت أو مشاركة الإنترنت عبر USB من هاتفك) في أول مرة تقوم فيها بتشغيل هذا السكربت لتنزيل أدوات البناء الضرورية (مثل المترجم، رؤوس لينكس، إلخ).



## ✅ تم الاختبار على (تم التحقق من عمله)
تم التحقق من عمل هذا الإصلاح وهو مؤكد على الأجهزة التالية:

* **الماركة:** ASUS
* **الطراز:** Vivobook Go (E1404FA)، Vivobook 14 (X1404ZA)
* **الشريحة:** MediaTek MT7902 (WiFi 6E)
* **إصدار النواة:** 6.19.0 (لينكس)، 6.19.11، 7.0.7
* **أنظمة التشغيل:** Arch، Ubuntu
* **مدير الحزم:** pacman، apt

## متوفر لـ:
* **نظام التشغيل**: أي نظام يدعم أحد مديري الحزم المذكورين
* **مديرو الحزم المفضلون:** apt، pacman، dnf، zypper، nix-shell
* **إصدارات النواة:** 6.14-7.0.7



## 🔧 البرمجيات الثابتة المستخدمة
يتم تخزين البرمجيات الثابتة في مجلد `firmware`.


## 📱 البلوتوث ✅ (يعمل)
> [!WARNING]
> إذا كان تعريف البلوتوث يتعارض مع `gen4-mt7902` يرجى إزالة البرنامج الثابت للبلوتوث حتى لا يتداخل مع هذا التعريف
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> يستخدم هذا المشروع البرنامج الثابت التالي
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

لتمكين البلوتوث، انتقل إلى مجلد إصدار النواة الحالي لديك. ``
على سبيل المثال إذا كان لديك نواة linux-6.16 انتقل إلى المجلد `./linux-6.16/drivers/bluetooth` .
افتح الطرفية في هذا الدليل وقم بالترجمة باستخدام الأمر `make`.
يتم ترجمة وحدتي نواة هما `btusb.ko` و `btmtk.ko`.
لتمكين البلوتوث في جهازك، قم بإزالة btusb و btmtk من نظامك وقم بتثبيت هذين الملفين، استخدم الأوامر
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
الآن تحقق مما إذا كان البلوتوث يعمل الآن.

## 💻 الواي فاي ✅ (يعمل)
> [!هام]
> يوجد مستودع يعمل مع بعض القيود [هنا](https://github.com/hmtheboy154/gen4-mt7902)

برنامج تشغيل الواي فاي للـ mt7902، الذي تم إصداره مؤخرًا من قبل ميدياتك، موجود داخل مجلد `latest`.

إذا كنت تستخدم أوبونتو، فقط انتقل إلى مجلد `latest` وقم بتشغيل الأمر التالي في الطرفية.
```
make
```
سيقوم بتجميع جميع الوحدات، وضغطها وتثبيتها (استبدال وحدة النواة الأصلية بالوحدة المعدلة). إذا كنت تستخدم توزيعة أخرى أو لا ترغب في تنفيذ جميع الخطوات وترغب فقط في تجميع الشيفرة، فقم بتشغيل ذلك في الطرفية

```
make module_compile
```
لضغط الوحدة التي قمت بتجميعها، ثم تشغيلها في الطرفية
```
make module_compress
```
لتثبيت الوحدة المضغوطة إلى وحدة نواة النظام، قم بتشغيل الأمر في الطرفية
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---