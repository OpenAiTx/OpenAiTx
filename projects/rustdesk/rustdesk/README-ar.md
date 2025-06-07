<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - سطح المكتب البعيد الخاص بك"><br>
  <a href="#raw-steps-to-build">البناء</a> •
  <a href="#how-to-build-with-docker">دوكر</a> •
  <a href="#file-structure">الهيكلية</a> •
  <a href="#snapshot">لقطة شاشة</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>نحن بحاجة إلى مساعدتك لترجمة ملف README هذا، <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">واجهة RustDesk</a> و <a href="https://github.com/rustdesk/doc.rustdesk.com">وثائق RustDesk</a> إلى لغتك الأم</b>
</p>

> [!تنبيه]
> **إخلاء المسؤولية عن سوء الاستخدام:** <br>
> لا يوافق مطورو RustDesk أو يدعمون أي استخدام غير أخلاقي أو غير قانوني لهذا البرنامج. سوء الاستخدام، مثل الوصول أو التحكم غير المصرح به أو انتهاك الخصوصية، مخالف تمامًا لإرشاداتنا. المؤلفون غير مسؤولين عن أي سوء استخدام للتطبيق.

تحدث معنا: [ديسكورد](https://discord.gg/nDceKgxnkV) | [تويتر](https://twitter.com/rustdesk) | [ريديت](https://www.reddit.com/r/rustdesk) | [يوتيوب](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

برنامج سطح مكتب بعيد آخر، مكتوب بلغة Rust. يعمل مباشرة دون الحاجة إلى إعدادات. لديك السيطرة الكاملة على بياناتك، دون أي قلق بشأن الأمان. يمكنك استخدام خادم التلاقي/الترحيل الخاص بنا، [أو إعداد خادم خاص بك](https://rustdesk.com/server)، أو [كتابة خادم التلاقي/الترحيل الخاص بك](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

يرحب RustDesk بمساهمة الجميع. راجع [CONTRIBUTING.md](docs/CONTRIBUTING.md) للمساعدة في البدء.

[**الأسئلة الشائعة**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**تحميل البرنامج الثنائي**](https://github.com/rustdesk/rustdesk/releases)

[**الإصدار الليلي**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="احصل عليه من F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="احصل عليه من Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## الاعتمادات

إصدارات سطح المكتب تستخدم Flutter أو Sciter (متوقف) للواجهة الرسومية، هذا الدليل مخصص لـ Sciter فقط لأنه أسهل وأكثر ودية للبداية. تحقق من [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) لبناء نسخة Flutter.

يرجى تحميل مكتبة Sciter الديناميكية بنفسك.

[ويندوز](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[لينكس](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[ماك](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## خطوات البناء الأولية

- جهز بيئة تطوير Rust وبيئة بناء ++C

- ثبت [vcpkg](https://github.com/microsoft/vcpkg)، واضبط متغير البيئة `VCPKG_ROOT` بشكل صحيح

  - ويندوز: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - لينكس/ماك: vcpkg install libvpx libyuv opus aom

- نفذ الأمر `cargo run`

## [البناء](https://rustdesk.com/docs/en/dev/build/)

## كيفية البناء على لينكس

### أوبونتو 18 (ديبيان 10)

```sh
sudo apt install -y zip g++ gcc git curl wget nasm yasm libgtk-3-dev clang libxcb-randr0-dev libxdo-dev \
        libxfixes-dev libxcb-shape0-dev libxcb-xfixes0-dev libasound2-dev libpulse-dev cmake make \
        libclang-dev ninja-build libgstreamer1.0-dev libgstreamer-plugins-base1.0-dev libpam0g-dev
```

### أوبن سوزي تامبليويد

```sh
sudo zypper install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libXfixes-devel cmake alsa-lib-devel gstreamer-devel gstreamer-plugins-base-devel xdotool-devel pam-devel
```

### فيدورا 28 (CentOS 8)

```sh
sudo yum -y install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libxdo-devel libXfixes-devel pulseaudio-libs-devel cmake alsa-lib-devel gstreamer1-devel gstreamer1-plugins-base-devel pam-devel
```

### آرتش (مانجارو)

```sh
sudo pacman -Syu --needed unzip git cmake gcc curl wget yasm nasm zip make pkg-config clang gtk3 xdotool libxcb libxfixes alsa-lib pipewire
```

### تثبيت vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### إصلاح libvpx (لفيدورا)

```sh
cd vcpkg/buildtrees/libvpx/src
cd *
./configure
sed -i 's/CFLAGS+=-I/CFLAGS+=-fPIC -I/g' Makefile
sed -i 's/CXXFLAGS+=-I/CXXFLAGS+=-fPIC -I/g' Makefile
make
cp libvpx.a $HOME/vcpkg/installed/x64-linux/lib/
cd
```

### البناء

```sh
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
source $HOME/.cargo/env
git clone --recurse-submodules https://github.com/rustdesk/rustdesk
cd rustdesk
mkdir -p target/debug
wget https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so
mv libsciter-gtk.so target/debug
VCPKG_ROOT=$HOME/vcpkg cargo run
```

## كيفية البناء باستخدام دوكر

ابدأ باستنساخ المستودع وبناء حاوية دوكر:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

ثم، في كل مرة تحتاج فيها لبناء التطبيق، نفذ الأمر التالي:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

لاحظ أن البناء الأول قد يستغرق وقتًا أطول قبل تخزين الاعتمادات مؤقتًا، وستكون عمليات البناء اللاحقة أسرع. بالإضافة إلى ذلك، إذا كنت بحاجة لتحديد معاملات مختلفة لأمر البناء، يمكنك إضافتها في نهاية الأمر في موضع `<OPTIONAL-ARGS>`. على سبيل المثال، إذا أردت بناء نسخة إصدار محسنة، نفذ الأمر أعلاه متبوعًا بـ `--release`. الملف التنفيذي الناتج سيكون متاحًا في مجلد target على نظامك، ويمكن تشغيله باستخدام:

```sh
target/debug/rustdesk
```

أو، إذا كنت تشغل إصدار الإصدار:

```sh
target/release/rustdesk
```

يرجى التأكد من تنفيذ هذه الأوامر من جذر مستودع RustDesk، وإلا قد لا يتمكن التطبيق من العثور على الموارد المطلوبة. أيضًا، لاحظ أن أوامر cargo الفرعية الأخرى مثل `install` أو `run` غير مدعومة حاليًا بهذه الطريقة، لأنها ستثبت أو تشغل البرنامج داخل الحاوية بدلاً من الجهاز المضيف.

## الهيكلية

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: ترميز الفيديو، الإعدادات، تغليف tcp/udp، protobuf، وظائف نظام الملفات لنقل الملفات، وبعض وظائف الأدوات الأخرى
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: التقاط الشاشة
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: تحكم لوحة المفاتيح/الماوس حسب النظام الأساسي
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: تنفيذ نسخ ولصق الملفات لويندوز، لينكس، ماك.
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: واجهة Sciter قديمة (متوقفة)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: خدمات الصوت/الحافظة/الإدخال/الفيديو، واتصالات الشبكة
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: بدء اتصال الند للند
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: التواصل مع [rustdesk-server](https://github.com/rustdesk/rustdesk-server)، انتظار اتصال مباشر (TCP hole punching) أو اتصال مرحل
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: كود خاص بالنظام الأساسي
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: كود Flutter لسطح المكتب والجوال
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: جافاسكريبت لعميل Flutter على الويب

## لقطات الشاشة

![مدير الاتصال](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![متصل بجهاز ويندوز](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![نقل الملفات](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![نفق TCP](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---