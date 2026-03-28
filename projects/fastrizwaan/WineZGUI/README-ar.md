<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### واجهة رسومية لـ Wine باستخدام Zenity - العب وشارك!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)


## ما هو WineZGUI

WineZGUI (تُنطق: وين-زي-جو-إي) هو واجهة أمامية لبرنامج Wine لتشغيل ألعاب ويندوز بسهولة باستخدام Wine. إنه مجموعة من سكربتات Bash لإدارة Wine Prefix ودمجها مع سطح المكتب في لينكس لتجربة ألعاب واين أسهل باستخدام Zenity. يسمح بتشغيل التطبيقات أو الألعاب التنفيذية (غير المثبتة) بسرعة من مدير الملفات مثل Nautilus، ويسمح بإنشاء واين بريفكس منفصل لكل ملف EXE من ويندوز.

## لماذا WineZGUI؟

1. يشغل ألعاب ويندوز أو ملفات exe من مدير الملفات
2. ينشئ اختصاراً للتطبيق للوصول الأسهل.
3. يركز على تشغيل الألعاب وليس إعداد البريفكس.
4. نسخ احتياطي واستعادة البريفكس للاستخدام لاحقاً.
5. إنشاء حزم ألعاب للمشاركة (بريفكس+لعبة)

## كيف يعمل

1. عند فتح ملف تنفيذي أو باينري ويندوز باستخدام WineZGUI،
2. يقوم بإنشاء بريفكس جديد (ينسخ القالب) واختصار على سطح المكتب باسم ملف EXE.
3. عندما يشغل المستخدم السكربت، يتم تشغيل ملف exe.
4. إذا كان ملف إعداد، سيكتشف exe المثبت ويقوم بإنشاء اختصارات في قائمة الألعاب.

## كيفية تشغيل لعبة أو برنامج على قرص أو مجلد آخر

افتح الطرفية واكتب التالي:

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### تثبيت WineZGUI

يتوفر WineZGUI كحزمة Flatpak على Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

يمكن لـ Flathub WineZGUI فقط الوصول إلى مجلدات Desktop و Documents و Downloads و Music و Pictures و Videos. للوصول إلى ملفات من أماكن أخرى أو أقسام أو أقراص مركبة أخرى، إما أن تنقلها إلى المجلدات المذكورة سابقاً (Downloads إلخ) أو تحتاج إلى إذن قراءة، والذي يمكن منحه باستخدام تطبيق Flatseal أو عبر سطر الأوامر `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

أنصح بشدة باستخدام نسخة flatpak، لأن wine من التوزيعة (wine-staging) يتم تحديثه باستمرار وقد تتوقف الألعاب عن العمل كل بضعة أيام. استخدام wine المستقر من flathub أفضل أو استخدم wine المستقر 5.0 أو 7.0 من حزم التوزيعة.

#### تثبيت WineZGUI flatpak على [توزيعات لينكس المدعومة](https://flatpak.org/setup/)

تم تعبئة WineZGUI في flatpak-wine من قبلي. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) حزمة flatpak الأخرى لي والتي تم إهمالها الآن [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)


### الإعداد على نظام لينكس، انظر [المتطلبات](https://github.com/fastrizwaan/WineZGUI#requirements)

الإعداد فوري حيث يتم نسخ بعض الملفات إلى أدلة محددة.

##### الإصدار 0.99.13

حمّل المصدر [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) أو استخدم `git tag 0.99.13`

##### استخدام tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### علامة git 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### إصدار التطوير

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### إزالة WineZGUI

##### إزالة Flatpak

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### إلغاء تثبيت النظام

قم بتشغيل `uninstall` من نفس دليل مصدر التثبيت

```
sudo ./setup --uninstall
```

## المتطلبات

`wine` - البرنامج الرئيسي

`winetricks` - يجب توفر سكريبت إضافي لـ wine

`perl‑image‑exiftool` - لاستخراج اسم التطبيق/اللعبة

`icoutils` - لاستخراج الأيقونة من ملف exe

`gnome-terminal` - (اختياري) للوصول إلى دليل الـ prefix في الصدفة

## تثبيت المتطلبات لنظام التشغيل لينكس

### توزيعات تدعم Flatpak

احصل على [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) الذي يتضمن جميع التبعيات. مفيد للتوزيعات التي لا توفر wine.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## تبعيات وقت التشغيل:

### فيدورا 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### ديبيان / أوبونتو / لينكس منت

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### سولوس

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### أرتش لينكس / إنديفور أو إس

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### وحدات تحكم متوافقة مع XBOX

قم ببناء وتثبيت برامج تشغيل النواة لوحدات تحكم xbox 360 المتوافقة من https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---