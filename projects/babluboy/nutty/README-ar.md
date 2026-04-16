<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">الإنجليزية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">اليابانية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">الكورية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">الهندية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">التايلاندية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">الفرنسية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">الألمانية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">الإسبانية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">الإيطالية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">الروسية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">البرتغالية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">الهولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">البولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">الفارسية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">التركية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">الفيتنامية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">الإندونيسية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ناتي [![حالة الترجمة](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![حالة البناء](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![حالة Snap](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![تبرع](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
أداة شبكة

المؤلف: سيدهارتا داس

تطبيق بسيط تم تصميمه لنظام التشغيل إلمنتري لتوفير معلومات أساسية حول الجوانب المتعلقة بالشبكة. يتم عرض المعلومات في علامات التبويب التالية.<br>
1. معلوماتي: توفر معلومات أساسية ومفصلة حول بطاقة شبكة الجهاز<br>
2. الاستخدام: يعرض استخدام بيانات الشبكة في عرضين - الاستخدام التاريخي والاستخدام الحالي<br>

3. السرعة: تحقق من سرعات الرفع والتنزيل واحصل على أوقات المسار إلى مضيف<br>
4. المنافذ: يوفر معلومات عن المنافذ النشطة والتطبيقات التي تستخدمها على الجهاز المحلي<br>
5. الأجهزة: يراقب وينبه ويوفر معلومات حول الأجهزة الأخرى المتصلة على الشبكة<br>

تحقق من موقع Nutty لمزيد من التفاصيل حول الميزات، والاختصارات، وأدلة التثبيت لأوبونتو والتوزيعات المدعومة الأخرى، إلخ: <br>
https://babluboy.github.io/nutty/

## البناء والاختبار والتثبيت من المصدر

ستحتاج إلى التبعيات التالية للبناء:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

وهذه التبعيات للتشغيل:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

أحيانًا لا يبدأ vnstat تلقائيًا عند التثبيت، استخدم الأمر المناسب لنظام التهيئة لتشغيل خدمة vnstat، مثل: `sudo systemctl enable vnstat`

قم بتشغيل `meson build` لإعداد بيئة البناء ثم قم بتشغيل `ninja test` للبناء

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```

لتثبيت، استخدم `sudo ninja install`، ثم نفّذ الأمر `com.github.babluboy.nutty`

```
sudo ninja install
com.github.babluboy.nutty
```
لإلغاء التثبيت، انتقل إلى دليل البناء وقم بتشغيل

```
sudo ninja uninstall
```

### التثبيت من حزمة Deb

لتثبيت Nutty من حزمة `.deb` تأكد من أنك قمت بتثبيت جميع تبعيات التشغيل المذكورة أعلاه لـ Nutty (لا حاجة لتبعيات البناء). ثم شغّل الأمر التالي
```bash
sudo dpkg -i <deb-package-name>.deb
```

ولإلغاء تثبيت Nutty الذي تم تثبيته عبر حزمة `.deb` قم بتشغيل
```bash
sudo apt autoremove com.github.babluboy.nutty
```
إذا كنت ترغب في بناء حزمة `.deb` الخاصة بـ Nutty بنفسك مباشرة، فقم بتثبيت تبعيات البناء المذكورة أعلاه ثم قم بتشغيل

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---