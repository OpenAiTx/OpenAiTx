**این مخزن GitHub (<https://github.com/Genymobile/scrcpy>) تنها منبع رسمی برای این پروژه است. نسخه‌ها را از سایت‌های نامعتبر دانلود نکنید، حتی اگر نام آن‌ها شامل `scrcpy` باشد.**

# scrcpy (نسخه ۳.۲)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_تلفظ: "**scr**een **c**o**py**"_

این برنامه دستگاه‌های اندرویدی (تصویر و صدا) متصل شده از طریق USB یا
[TCP/IP](doc/connection.md#tcpip-wireless) را آینه می‌کند و امکان کنترل با استفاده از
صفحه‌کلید و ماوس رایانه را فراهم می‌کند. نیاز به دسترسی _root_ یا نصب هیچ اپی روی دستگاه ندارد. بر روی _لینوکس_، _ویندوز_ و _مک‌اواس_ کار می‌کند.

![تصویر نمونه](assets/screenshot-debian-600.jpg)

تمرکز این برنامه بر روی موارد زیر است:

 - **سبکی**: بومی، فقط نمایش صفحه دستگاه
 - **کارایی**: ۳۰ تا ۱۲۰ فریم بر ثانیه، بسته به دستگاه
 - **کیفیت**: ۱۹۲۰×۱۰۸۰ یا بالاتر
 - **تاخیر پایین**: [۳۵ تا ۷۰ میلی‌ثانیه][lowlatency]
 - **زمان راه‌اندازی پایین**: حدود ۱ ثانیه برای نمایش اولین تصویر
 - **عدم مزاحمت**: هیچ چیزی روی دستگاه اندرویدی نصب نمی‌شود
 - **مزایای کاربر**: بدون حساب کاربری، بدون تبلیغات، بدون نیاز به اینترنت
 - **آزادی**: نرم‌افزار آزاد و متن‌باز

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

ویژگی‌های آن شامل:
 - [ارسال صدا](doc/audio.md) (اندروید ۱۱ به بالا)
 - [ضبط](doc/recording.md)
 - [نمایشگر مجازی](doc/virtual_display.md)
 - آینه‌سازی با [صفحه خاموش دستگاه اندروید](doc/device.md#turn-screen-off)
 - [کپی-پیست](doc/control.md#copy-paste) در هر دو جهت
 - [کیفیت قابل تنظیم](doc/video.md)
 - [آینه‌سازی دوربین](doc/camera.md) (اندروید ۱۲ به بالا)
 - [آینه‌سازی به عنوان وبکم (V4L2)](doc/v4l2.md) (فقط لینوکس)
 - شبیه‌سازی فیزیکی [صفحه‌کلید][hid-keyboard] و [ماوس][hid-mouse] (HID)
 - پشتیبانی از [گیم‌پد](doc/gamepad.md)
 - [حالت OTG](doc/otg.md)
 - و امکانات بیشتر…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## پیش‌نیازها

دستگاه اندرویدی حداقل باید API 21 (اندروید ۵.۰) داشته باشد.

[ارسال صدا](doc/audio.md) برای API >= 30 (اندروید ۱۱ به بالا) پشتیبانی می‌شود.

اطمینان حاصل کنید که [اشکال‌زدایی USB][enable-adb] را روی دستگاه خود فعال کرده‌اید.

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

در برخی دستگاه‌ها (به ویژه شیائومی)، ممکن است خطای زیر را دریافت کنید:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

در این صورت باید [یک گزینه اضافی][control] به نام `USB debugging (Security Settings)`
(این گزینه با `USB debugging` متفاوت است) را فعال کنید تا بتوانید با صفحه‌کلید و ماوس دستگاه را کنترل کنید. پس از تنظیم این گزینه، راه‌اندازی مجدد دستگاه ضروری است.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

توجه داشته باشید که برای اجرای scrcpy در [حالت OTG](doc/otg.md) نیازی به اشکال‌زدایی USB نیست.

## دریافت برنامه

 - [لینوکس](doc/linux.md)
 - [ویندوز](doc/windows.md) (راهنمای [اجرای برنامه](doc/windows.md#run) را بخوانید)
 - [مک‌اواس](doc/macos.md)

## نکات ضروری

 - [کاهش وضوح تصویر](doc/video.md#size) می‌تواند کارایی را به طور قابل توجهی افزایش دهد
   (`scrcpy -m1024`)
 - [کلیک راست](doc/mouse.md#mouse-bindings) معادل دکمه `BACK` است
 - [کلیک وسط](doc/mouse.md#mouse-bindings) معادل دکمه `HOME` است
 - <kbd>Alt</kbd>+<kbd>f</kbd> حالت [تمام‌صفحه](doc/window.md#fullscreen) را فعال/غیرفعال می‌کند
 - سایر [میانبرها](doc/shortcuts.md) نیز وجود دارد

## مثال‌های استفاده

گزینه‌های زیادی وجود دارد که در صفحات [مستندسازی شده](#user-documentation) جداگانه توضیح داده شده‌اند.
در اینجا فقط چند مثال رایج آورده شده است.

 - ضبط صفحه با کدک H.265 (کیفیت بهتر)، محدود کردن اندازه به ۱۹۲۰، محدود کردن
   نرخ فریم به ۶۰fps، غیرفعال کردن صدا و کنترل دستگاه با شبیه‌سازی صفحه‌کلید فیزیکی:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # نسخه کوتاه
    ```

 - اجرای VLC در یک نمایشگر مجازی جدید (جدا از نمایشگر دستگاه):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - ضبط دوربین دستگاه با کیفیت H.265 و وضوح ۱۹۲۰x۱۰۸۰ (و میکروفون) در یک فایل MP4:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - ضبط دوربین جلوی دستگاه و ارائه آن به عنوان وبکم روی رایانه (در لینوکس):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - کنترل دستگاه بدون آینه‌سازی با شبیه‌سازی صفحه‌کلید و ماوس فیزیکی (بدون نیاز به اشکال‌زدایی USB):

    ```bash
    scrcpy --otg
    ```

 - کنترل دستگاه با استفاده از دسته‌های بازی متصل به رایانه:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # نسخه کوتاه
    ```

## مستندات کاربر

این برنامه ویژگی‌ها و گزینه‌های پیکربندی زیادی ارائه می‌دهد. آن‌ها در صفحات زیر مستندسازی شده‌اند:

 - [اتصال](doc/connection.md)
 - [ویدیو](doc/video.md)
 - [صدا](doc/audio.md)
 - [کنترل](doc/control.md)
 - [صفحه‌کلید](doc/keyboard.md)
 - [ماوس](doc/mouse.md)
 - [گیم‌پد](doc/gamepad.md)
 - [دستگاه](doc/device.md)
 - [پنجره](doc/window.md)
 - [ضبط](doc/recording.md)
 - [نمایشگر مجازی](doc/virtual_display.md)
 - [تونل‌ها](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [دوربین](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [میانبرها](doc/shortcuts.md)

## منابع

 - [سوالات متداول](FAQ.md)
 - [ترجمه‌ها][wiki] (ممکن است به‌روز نباشد)
 - [دستورالعمل ساخت](doc/build.md)
 - [توسعه‌دهندگان](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki

## مقالات

- [معرفی scrcpy][article-intro]
- [scrcpy اکنون به صورت بی‌سیم کار می‌کند][article-tcpip]
- [scrcpy 2.0 با صدا][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## تماس

برای گزارش اشکال، درخواست ویژگی یا سوالات عمومی می‌توانید یک [issue] باز کنید.

برای گزارش اشکال، ابتدا [سوالات متداول](FAQ.md) را مطالعه کنید، ممکن است فوراً راه‌حل مشکل خود را بیابید.

[issue]: https://github.com/Genymobile/scrcpy/issues

همچنین می‌توانید از این روش‌ها استفاده کنید:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)

## حمایت مالی

من [@rom1v](https://github.com/rom1v) هستم، نویسنده و نگهدارنده _scrcpy_.

اگر از این برنامه لذت بردید، می‌توانید از [کار متن‌باز من][donate] حمایت کنید:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## مجوز

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    تحت مجوز Apache License, Version 2.0 (مجوز)؛
    شما نمی‌توانید این فایل را جز در مطابقت با مجوز استفاده کنید.
    می‌توانید نسخه‌ای از مجوز را از نشانی زیر دریافت کنید:

        http://www.apache.org/licenses/LICENSE-2.0

    مگر آنکه طبق قانون الزامی باشد یا به صورت مکتوب توافق شده باشد،
    نرم‌افزار توزیع شده تحت این مجوز به صورت "همان‌گونه که هست" ارائه می‌شود،
    بدون هیچگونه ضمانت، اعم از صریح یا ضمنی.
    برای اطلاعات بیشتر به مجوز مراجعه کنید.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---