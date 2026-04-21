
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# المعلق

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="احصل عليه من AppCenter"/>
  </a>
</p>

![<center><b>النافذة الرئيسية - النمط الفاتح</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "تعليق الصور لنظام Elementary OS")

## نظرة عامة

قم بتعليق صورك ودع الصورة تتحدث بألف كلمة.

- حمّل صورة من نظام الملفات، الحافظة، أو أنشئ لقطة شاشة للتعليق عليها.
- أضف أشكالاً، ملصقات، صوراً، نصوصاً، رسومات، وعناصر توضيحية أخرى لتسليط الضوء على تفاصيل الصورة.
- أضف مكبرات لزيادة وضوح تفاصيل الصورة.
- قم بتضبيب أجزاء من الصورة لإخفاء البيانات.
- قص، غيّر حجم الصورة وأضف حدوداً للصورة.
- تحكم في الألوان، سمك الخط وتفاصيل الخط.
- دعم التكبير والتصغير.
- دعم اختيار الألوان من داخل الصورة المحمّلة.
- تراجع/إعادة غير محدود لأي تغيير.
- اسحب وأسقط نسخ PNG من الصورة المعلّقة.
- تصدير إلى صيغ الصور JPEG, PNG, TIFF, BMP, PDF, SVG و WebP.
- دعم نسخ الصورة المعلّقة إلى الحافظة.
- دعم الطابعة.

## التثبيت

### ديبيان (من المصدر)

ستحتاج إلى الحزم التالية لبناء Annotator:

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-7-dev
- libgtk-4-dev
- libxml2-dev
- libarchive-dev
- libwebp-dev

لتثبيت Annotator من المصدر، شغل الأمر `./app install`.

لتشغيل Annotator، شغّل `com.github.phase1geo.annotator`.

### أوبونتو (PPA)

يمكنك استخدام [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/) الذي يديره @PandaJim. يدعم الـ PPA أوبونتو 20.04+. أدخل الأوامر التالية واحداً تلو الآخر

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```

### آرتش لينكس

إذا كنت من مستخدمي آرتش لينكس، هناك
[حزمة AUR](https://aur.archlinux.org/packages/annotator/)
`annotator`:

```
% yay -S annotator
```

### فلاتباك

بالإضافة إلى ذلك، يمكن تثبيت وتشغيل Annotator عبر فلاتباك.

لبناء حزمة فلاتباك الخاصة بـ elementary من المصدر، نفذ الأمر `./app elementary`.

لبناء حزمة فلاتباك الخاصة بـ Flathub من المصدر، نفذ الأمر `./app flathub`.

بعد ذلك، يمكنك تشغيلها عبر: `./app run-flatpak`.

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="احصل عليها من AppCenter"/>
  </a>
</p>

## الشكر والتقدير

يتضمن `document-edit-symbolic.svg` و `image-crop-symbolic.svg` من
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic)،
تحت شروط رخصة GPL v3.0.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---