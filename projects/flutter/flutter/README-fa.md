<a href="https://flutter.dev/">
  <h1 align="center">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://storage.googleapis.com/cms-storage-bucket/6e19fee6b47b36ca613f.png">
      <img alt="Flutter" src="https://storage.googleapis.com/cms-storage-bucket/c823e53b3a1a7b0d36a9.png">
    </picture>
  </h1>
</a>

[![وضعیت CI فلاتر](https://flutter-dashboard.appspot.com/api/public/build-status-badge?repo=flutter)](https://flutter-dashboard.appspot.com/#/build?repo=flutter)
[![نشان دیسکورد][]][دستورالعمل‌های دیسکورد]
[![نشان توییتر][]][دسته توییتر]
[![نشان BlueSky][]][دسته BlueSky]
[![codecov](https://codecov.io/gh/flutter/flutter/branch/master/graph/badge.svg?token=11yDrJU2M2)](https://codecov.io/gh/flutter/flutter)
[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/5631/badge)](https://bestpractices.coreinfrastructure.org/projects/5631)
[![SLSA 1](https://slsa.dev/images/gh-badge-level1.svg)](https://slsa.dev)

فلاتر کیت توسعه نرم‌افزار (SDK) گوگل برای ساخت تجربه‌های کاربری زیبا و سریع برای موبایل، وب و دسکتاپ از یک کدبیس واحد است. فلاتر با کد موجود کار می‌کند، توسط توسعه‌دهندگان و سازمان‌های سراسر جهان استفاده می‌شود و رایگان و متن‌باز است.

## مستندات

* [نصب فلاتر](https://flutter.dev/get-started/)
* [مستندات فلاتر](https://docs.flutter.dev/)
* [ویکی توسعه](./docs/README.md)
* [مشارکت در فلاتر](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

برای اطلاعیه‌های مربوط به نسخه‌های جدید، فهرست پستی 
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce)
را دنبال کنید. مستندات ما همچنین [تغییرات ناسازگار](https://docs.flutter.dev/release/breaking-changes) را در نسخه‌های مختلف پیگیری می‌کند.

## شرایط خدمات

ابزار فلاتر ممکن است گاهی منابعی را از سرورهای گوگل دانلود کند. با دانلود یا استفاده از SDK فلاتر، شما با شرایط خدمات گوگل موافقت می‌کنید:
https://policies.google.com/terms

برای مثال، زمانی که فلاتر از گیت‌هاب نصب می‌شود (برخلاف آرشیو از پیش بسته‌بندی‌شده)، ابزار فلاتر هنگام اولین اجرا، SDK دارت را از سرورهای گوگل دانلود می‌کند، زیرا برای اجرای ابزار `flutter` به آن نیاز دارد. این امر هنگام ارتقای فلاتر (مثلاً با اجرای دستور `flutter upgrade`) نیز رخ خواهد داد.

## درباره فلاتر

ما معتقدیم فلاتر به شما کمک می‌کند اپلیکیشن‌هایی زیبا و سریع با مدلی مولد، توسعه‌پذیر و باز بسازید؛ چه برای iOS، اندروید، وب، ویندوز، مک‌اواس، لینوکس هدف‌گیری کنید یا بخواهید آن را به‌عنوان کیت واسط کاربری برای پلتفرم دلخواه خود به کار ببرید.

### تجربه‌های کاربری زیبا

ما می‌خواهیم طراحان بتوانند تمام دید خلاقانه خود را بدون محدودیت‌های چارچوب زیرین پیاده کنند. [معماری لایه‌ای](https://docs.flutter.dev/resources/inside-flutter) فلاتر به شما کنترل کامل بر هر پیکسل صفحه می‌دهد و قابلیت‌های ترکیب قدرتمند آن اجازه می‌دهد گرافیک، ویدیو، متن و کنترل‌ها را بدون محدودیت روی هم قرار داده و متحرک کنید. فلاتر یک [مجموعه کامل از ویجت‌ها][کاتالوگ ویجت] ارائه می‌دهد که تجربه‌هایی پیکسلی بی‌نقص، چه برای iOS ([Cupertino]) و چه سایر پلتفرم‌ها ([Material]) فراهم می‌کند، به همراه پشتیبانی از سفارشی‌سازی یا ساخت اجزای بصری جدید.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="تصویر قهرمان Reflectly"></p>

### نتایج سریع

فلاتر سریع است. این فریم‌ورک توسط کتابخانه‌های گرافیکی دوبعدی شتاب‌گرفته با سخت‌افزار مانند [Skia] (که زیربنای کروم و اندروید است) و [Impeller] پشتیبانی می‌شود. ما فلاتر را طوری معماری کردیم که گرافیک بدون لگ و پرش را با سرعت بومی دستگاه شما ارائه دهد.

کد فلاتر توسط پلتفرم [دارت](https://dart.dev/) پشتیبانی می‌شود که امکان کامپایل به کد ماشین ARM 32 بیت و 64 بیت برای iOS و اندروید، جاوااسکریپت و WebAssembly برای وب و همچنین Intel x64 و ARM برای دسکتاپ را فراهم می‌کند.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="نمودار دارت"></p>

### توسعه مولد

فلاتر قابلیت [بارگذاری مجدد حالت‌دار][بارگذاری مجدد داغ] را ارائه می‌دهد، که به شما اجازه می‌دهد تغییرات کد خود را فوراً مشاهده کنید، بدون نیاز به راه‌اندازی مجدد برنامه یا از دست دادن وضعیت آن.

[![انیمیشن بارگذاری مجدد داغ][]][بارگذاری مجدد داغ]

### مدل توسعه‌پذیر و باز

فلاتر با هر ابزار توسعه‌ای (یا حتی بدون ابزار) کار می‌کند و افزونه‌های ویرایشگر برای [Visual Studio Code] و [IntelliJ / Android Studio] را نیز ارائه می‌دهد. فلاتر [ده‌ها هزار بسته][بسته‌های فلاتر] برای سرعت بخشیدن به توسعه شما، صرف‌نظر از پلتفرم هدف، ارائه می‌کند. همچنین دسترسی به سایر کدهای بومی آسان است و از هر دو روش FFI ([در اندروید][FFI اندروید]، [در iOS][FFI آی‌اواس]، [در مک‌اواس][FFI مک‌اواس] و [در ویندوز][FFI ویندوز]) و همچنین [رابط‌های API مخصوص پلتفرم][کانال‌های پلتفرم] پشتیبانی می‌کند.

فلاتر پروژه‌ای کاملاً متن‌باز است و ما از مشارکت شما استقبال می‌کنیم.
اطلاعات شروع کار را می‌توانید در [راهنمای مشارکت‌کنندگان](CONTRIBUTING.md) بیابید.

[flutter.dev]: https://flutter.dev
[دستورالعمل‌های دیسکورد]: ./docs/contributing/Chat.md
[نشان دیسکورد]: https://img.shields.io/discord/608014603317936148?logo=discord
[دسته توییتر]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[نشان توییتر]: https://twitter.com/intent/follow?screen_name=flutterdev
[نشان BlueSky]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[دسته BlueSky]: https://bsky.app/profile/flutter.dev
[معماری لایه‌ای]: https://docs.flutter.dev/resources/inside-flutter
[نمای کلی معماری]: https://docs.flutter.dev/resources/architectural-overview
[کاتالوگ ویجت]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[پلتفرم دارت]: https://dart.dev/
[انیمیشن بارگذاری مجدد داغ]: https://github.com/flutter/website/blob/main/src/content/assets/images/docs/tools/android-studio/hot-reload.gif?raw=true
[بارگذاری مجدد داغ]: https://docs.flutter.dev/development/tools/hot-reload
[Visual Studio Code]: https://marketplace.visualstudio.com/items?itemName=Dart-Code.flutter
[IntelliJ / Android Studio]: https://plugins.jetbrains.com/plugin/9212-flutter
[بسته‌های فلاتر]: https://pub.dev/flutter
[FFI اندروید]: https://docs.flutter.dev/development/platform-integration/android/c-interop
[FFI آی‌اواس]: https://docs.flutter.dev/development/platform-integration/ios/c-interop
[FFI مک‌اواس]: https://docs.flutter.dev/development/platform-integration/macos/c-interop
[FFI ویندوز]: https://docs.flutter.dev/development/platform-integration/windows/building#integrating-with-windows
[کانال‌های پلتفرم]: https://docs.flutter.dev/development/platform-integration/platform-channels
[مثال اینتراپ]: https://github.com/flutter/flutter/tree/main/examples/platform_channel
[Impeller]: https://docs.flutter.dev/perf/impeller

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---