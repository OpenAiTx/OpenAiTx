**هذا المستودع على GitHub (<https://github.com/Genymobile/scrcpy>) هو المصدر الرسمي الوحيد للمشروع. لا تقم بتنزيل الإصدارات من مواقع عشوائية، حتى وإن كان اسمها يحتوي على `scrcpy`.**

# scrcpy (الإصدار 3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_تنطق "**scr**een **c**o**py**"_

يعمل هذا التطبيق على عكس أجهزة أندرويد (الفيديو والصوت) المتصلة عبر USB أو
[TCP/IP](doc/connection.md#tcpip-wireless)، ويسمح بالتحكم باستخدام لوحة مفاتيح وفأرة الكمبيوتر. لا يتطلب صلاحية _root_ أو تثبيت تطبيق على الجهاز. يعمل على أنظمة _Linux_ و_Windows_ و_macOS_.

![لقطة شاشة](assets/screenshot-debian-600.jpg)

يركز على:

 - **الخفة**: أصلي، يعرض فقط شاشة الجهاز
 - **الأداء**: 30~120 إطار في الثانية، حسب الجهاز
 - **الجودة**: 1920×1080 أو أكثر
 - **زمن استجابة منخفض**: [35~70 مللي ثانية][lowlatency]
 - **زمن بدء تشغيل منخفض**: ~1 ثانية لعرض أول صورة
 - **عدم التدخل**: لا يُترك أي شيء مثبت على جهاز الأندرويد
 - **فائدة المستخدم**: لا حساب، لا إعلانات، لا يتطلب الإنترنت
 - **الحرية**: برنامج مجاني ومفتوح المصدر

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

تشمل ميزاته:
 - [تمرير الصوت](doc/audio.md) (أندرويد 11+)
 - [التسجيل](doc/recording.md)
 - [شاشة افتراضية](doc/virtual_display.md)
 - العكس مع [إيقاف شاشة جهاز الأندرويد](doc/device.md#turn-screen-off)
 - [النسخ واللصق](doc/control.md#copy-paste) في كلا الاتجاهين
 - [جودة قابلة للتكوين](doc/video.md)
 - [عكس الكاميرا](doc/camera.md) (أندرويد 12+)
 - [العكس ككاميرا ويب (V4L2)](doc/v4l2.md) (لينكس فقط)
 - محاكاة [لوحة المفاتيح][hid-keyboard] و[الفأرة][hid-mouse] الفعلية (HID)
 - دعم [يد التحكم بالألعاب](doc/gamepad.md)
 - [وضع OTG](doc/otg.md)
 - والمزيد...

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## المتطلبات الأساسية

يتطلب جهاز الأندرويد إصدار API 21 على الأقل (أندرويد 5.0).

[تمرير الصوت](doc/audio.md) مدعوم للإصدار API >= 30 (أندرويد 11+).

تأكد من أنك [فعّلت تصحيح أخطاء USB][enable-adb] على جهازك.

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

على بعض الأجهزة (خاصة Xiaomi)، قد تظهر الرسالة التالية:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

في هذه الحالة، تحتاج إلى تفعيل [خيار إضافي][control] وهو `تصحيح أخطاء USB (إعدادات الأمان)` (هذا خيار مختلف عن `تصحيح أخطاء USB`) للتحكم فيه باستخدام لوحة المفاتيح والفأرة. يجب إعادة تشغيل الجهاز بعد تفعيل هذا الخيار.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

لاحظ أن تصحيح أخطاء USB غير مطلوب لتشغيل scrcpy في [وضع OTG](doc/otg.md).

## الحصول على التطبيق

 - [لينكس](doc/linux.md)
 - [ويندوز](doc/windows.md) (اقرأ [كيفية التشغيل](doc/windows.md#run))
 - [ماك](doc/macos.md)

## نصائح يجب معرفتها

 - [تقليل الدقة](doc/video.md#size) قد يحسن الأداء بشكل كبير (`scrcpy -m1024`)
 - [_النقر بزر الفأرة الأيمن_](doc/mouse.md#mouse-bindings) ينفذ أمر `BACK`
 - [_النقر بزر الفأرة الأوسط_](doc/mouse.md#mouse-bindings) ينفذ أمر `HOME`
 - <kbd>Alt</kbd>+<kbd>f</kbd> يبدل [وضع ملء الشاشة](doc/window.md#fullscreen)
 - هناك العديد من [اختصارات لوحة المفاتيح](doc/shortcuts.md) الأخرى

## أمثلة للاستخدام

هناك العديد من الخيارات، [موثقة](#user-documentation) في صفحات منفصلة. فيما يلي بعض الأمثلة الشائعة فقط.

 - التقاط الشاشة بصيغة H.265 (جودة أفضل)، تحديد الحجم إلى 1920، تحديد معدل الإطارات إلى 60 إطار بالثانية، تعطيل الصوت، والتحكم بالجهاز بمحاكاة لوحة مفاتيح فعلية:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # نسخة مختصرة
    ```

 - تشغيل VLC في شاشة افتراضية جديدة (منفصلة عن شاشة الجهاز):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - تسجيل كاميرا الجهاز بصيغة H.265 بدقة 1920x1080 (والميكروفون) إلى ملف MP4:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - التقاط الكاميرا الأمامية للجهاز وعرضها ككاميرا ويب على الكمبيوتر (على لينكس):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - التحكم بالجهاز بدون عكس الشاشة بمحاكاة لوحة مفاتيح وفأرة فعلية (لا يتطلب تصحيح أخطاء USB):

    ```bash
    scrcpy --otg
    ```

 - التحكم بالجهاز باستخدام وحدات التحكم بالألعاب المتصلة بالكمبيوتر:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # نسخة مختصرة
    ```

## توثيق المستخدم

يوفر التطبيق الكثير من الميزات وخيارات التكوين. تم توثيقها في الصفحات التالية:

 - [الاتصال](doc/connection.md)
 - [الفيديو](doc/video.md)
 - [الصوت](doc/audio.md)
 - [التحكم](doc/control.md)
 - [لوحة المفاتيح](doc/keyboard.md)
 - [الفأرة](doc/mouse.md)
 - [يد التحكم بالألعاب](doc/gamepad.md)
 - [الجهاز](doc/device.md)
 - [النافذة](doc/window.md)
 - [التسجيل](doc/recording.md)
 - [الشاشة الافتراضية](doc/virtual_display.md)
 - [الأنفاق](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [الكاميرا](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [الاختصارات](doc/shortcuts.md)

## الموارد

 - [الأسئلة المتكررة](FAQ.md)
 - [الترجمات][wiki] (قد لا تكون محدثة دائمًا)
 - [تعليمات البناء](doc/build.md)
 - [المطورون](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki

## مقالات

- [تقديم scrcpy][article-intro]
- [scrcpy يعمل الآن لاسلكياً][article-tcpip]
- [scrcpy 2.0، مع الصوت][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## التواصل

يمكنك فتح [بلاغ](issue) للإبلاغ عن الأخطاء، أو طلب الميزات، أو الاستفسارات العامة.

بالنسبة للإبلاغ عن الأخطاء، يرجى قراءة [الأسئلة المتكررة](FAQ.md) أولًا، فقد تجد حلاً لمشكلتك فورًا.

[issue]: https://github.com/Genymobile/scrcpy/issues

يمكنك أيضًا استخدام:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - تويتر: [`@scrcpy_app`](https://twitter.com/scrcpy_app)

## التبرع

أنا [@rom1v](https://github.com/rom1v)، مؤلف ومشرف _scrcpy_.

إذا أعجبك هذا التطبيق، يمكنك [دعم عملي مفتوح المصدر][donate]:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## الرخصة

    حقوق النشر (C) 2018 Genymobile
    حقوق النشر (C) 2018-2025 Romain Vimont

    مرخص بموجب رخصة أباتشي، الإصدار 2.0 ("الرخصة")؛
    لا يجوز لك استخدام هذا الملف إلا وفقًا للرخصة.
    يمكنك الحصول على نسخة من الرخصة على

        http://www.apache.org/licenses/LICENSE-2.0

    ما لم ينص القانون المعمول به أو تم الاتفاق كتابيًا، يتم توزيع البرنامج
    على أساس "كما هو"، دون أي ضمانات أو شروط من أي نوع، سواء كانت صريحة أو ضمنية.
    راجع الرخصة لمزيد من التفاصيل حول الأذونات والقيود.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---