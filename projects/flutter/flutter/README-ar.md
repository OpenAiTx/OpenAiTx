<a href="https://flutter.dev/">
  <h1 align="center">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://storage.googleapis.com/cms-storage-bucket/6e19fee6b47b36ca613f.png">
      <img alt="Flutter" src="https://storage.googleapis.com/cms-storage-bucket/c823e53b3a1a7b0d36a9.png">
    </picture>
  </h1>
</a>

[![حالة Flutter CI](https://flutter-dashboard.appspot.com/api/public/build-status-badge?repo=flutter)](https://flutter-dashboard.appspot.com/#/build?repo=flutter)
[![شعار ديسكورد][]][تعليمات ديسكورد]
[![حساب تويتر][]][شعار تويتر]
[![شعار BlueSky][]][حساب BlueSky]
[![codecov](https://codecov.io/gh/flutter/flutter/branch/master/graph/badge.svg?token=11yDrJU2M2)](https://codecov.io/gh/flutter/flutter)
[![أفضل الممارسات CII](https://bestpractices.coreinfrastructure.org/projects/5631/badge)](https://bestpractices.coreinfrastructure.org/projects/5631)
[![SLSA 1](https://slsa.dev/images/gh-badge-level1.svg)](https://slsa.dev)

فلاتر هو مجموعة تطوير البرمجيات (SDK) من جوجل لإنشاء تجارب مستخدم جميلة وسريعة للهواتف المحمولة، الويب، وسطح المكتب من قاعدة شيفرة واحدة. يعمل فلاتر مع الشيفرة الموجودة مسبقًا، ويستخدمه المطورون والمؤسسات حول العالم، وهو مجاني ومفتوح المصدر.

## التوثيق

* [تثبيت فلاتر](https://flutter.dev/get-started/)
* [توثيق فلاتر](https://docs.flutter.dev/)
* [ويكي التطوير](./docs/README.md)
* [المساهمة في فلاتر](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

للحصول على إعلانات حول الإصدارات الجديدة، تابع قائمة البريد
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce).
كما يتتبع توثيقنا أيضًا [التغييرات الكبرى](https://docs.flutter.dev/release/breaking-changes) عبر الإصدارات.

## شروط الخدمة

قد يقوم أداة فلاتر أحيانًا بتنزيل موارد من خوادم جوجل. بتنزيلك أو استخدامك لمجموعة تطوير فلاتر، فإنك توافق على شروط خدمة جوجل: https://policies.google.com/terms

على سبيل المثال، عند التثبيت من GitHub (بدلاً من أرشيف معبأ مسبقًا)، ستقوم أداة فلاتر بتنزيل حزمة Dart SDK من خوادم جوجل فور تشغيلها لأول مرة، حيث يتم استخدامه لتشغيل أداة `flutter` نفسها. سيحدث هذا أيضًا عند ترقية فلاتر (مثلًا عند تشغيل أمر `flutter upgrade`).

## حول فلاتر

نعتقد أن فلاتر سيساعدك في إنشاء تطبيقات جميلة وسريعة، مع نموذج تطوير منتج وقابل للتوسعة ومفتوح المصدر، سواء كنت تستهدف iOS أو Android أو الويب أو Windows أو macOS أو Linux أو تضمينه كعدة واجهة المستخدم لأي منصة من اختيارك.

### تجارب مستخدم جميلة

نرغب في تمكين المصممين من تنفيذ رؤيتهم الإبداعية الكاملة دون الاضطرار إلى تقليصها بسبب قيود الإطار الأساسي. يتيح لك [الهيكل الطبقي لفلاتر] التحكم في كل بكسل على الشاشة، كما تتيح لك قدرات التركيب القوية الخاصة به تراكب وتحريك الرسومات والفيديو والنصوص وعناصر التحكم دون أي حدود. يتضمن فلاتر [مجموعة كاملة من الودجات][كتالوج الودجات] التي تقدم تجارب دقيقة على مستوى البكسل سواء كنت تبني لمنصة iOS ([Cupertino]) أو منصات أخرى ([Material])، مع دعم لتخصيص أو إنشاء مكونات مرئية جديدة كليًا.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### نتائج سريعة

فلاتر سريع. فهو مدعوم بمكتبات رسومات ثنائية الأبعاد معززة بالأجهزة مثل [Skia] (التي تدعم كروم وأندرويد) و[Impeller]. قمنا بتصميم فلاتر لدعم رسومات خالية من التقطعات وبسرعة أصلية على جهازك.

شيفرة فلاتر مدعومة بمنصة [Dart] العالمية، والتي تتيح الترجمة إلى كود آلة ARM بنظامي 32-بت و64-بت لـ iOS وAndroid، وJavaScript وWebAssembly للويب، بالإضافة إلى Intel x64 وARM لأجهزة سطح المكتب.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### تطوير منتج

يقدم فلاتر [إعادة تحميل الحالة الفورية][إعادة التحميل الفوري]، مما يتيح لك إجراء تغييرات على الشيفرة ورؤية النتائج فورًا دون إعادة تشغيل التطبيق أو فقدان حالته.

[![رسم متحرك لإعادة التحميل الفوري][]][إعادة التحميل الفوري]

### نموذج قابل للتوسعة ومفتوح المصدر

يعمل فلاتر مع أي أداة تطوير (أو بدونها)، كما يتضمن مكونات إضافية للمحرر لكل من [Visual Studio Code] و[IntelliJ / Android Studio]. يوفر فلاتر [عشرات الآلاف من الحزم][حزم فلاتر] لتسريع تطويرك، بغض النظر عن المنصة المستهدفة. كما أن الوصول إلى الشيفرة الأصلية الأخرى سهل، مع دعم لكل من FFI ([على أندرويد][FFI أندرويد]، [على iOS][FFI iOS]، [على macOS][FFI macOS]، و[على Windows][FFI ويندوز]) بالإضافة إلى [واجهات برمجة التطبيقات الخاصة بالمنصة][قنوات المنصة].

فلاتر مشروع مفتوح المصدر بالكامل، ونرحب بالمساهمات. يمكن العثور على معلومات حول كيفية البدء في [دليل المساهمين](CONTRIBUTING.md).

[flutter.dev]: https://flutter.dev
[تعليمات ديسكورد]: ./docs/contributing/Chat.md
[شعار ديسكورد]: https://img.shields.io/discord/608014603317936148?logo=discord
[حساب تويتر]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[شعار تويتر]: https://twitter.com/intent/follow?screen_name=flutterdev
[شعار BlueSky]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[حساب BlueSky]: https://bsky.app/profile/flutter.dev
[الهيكل الطبقي لفلاتر]: https://docs.flutter.dev/resources/inside-flutter
[لمحة معمارية]: https://docs.flutter.dev/resources/architectural-overview
[كتالوج الودجات]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[Dart]: https://dart.dev/
[رسم متحرك لإعادة التحميل الفوري]: https://github.com/flutter/website/blob/main/src/content/assets/images/docs/tools/android-studio/hot-reload.gif?raw=true
[إعادة التحميل الفوري]: https://docs.flutter.dev/development/tools/hot-reload
[Visual Studio Code]: https://marketplace.visualstudio.com/items?itemName=Dart-Code.flutter
[IntelliJ / Android Studio]: https://plugins.jetbrains.com/plugin/9212-flutter
[حزم فلاتر]: https://pub.dev/flutter
[FFI أندرويد]: https://docs.flutter.dev/development/platform-integration/android/c-interop
[FFI iOS]: https://docs.flutter.dev/development/platform-integration/ios/c-interop
[FFI macOS]: https://docs.flutter.dev/development/platform-integration/macos/c-interop
[FFI ويندوز]: https://docs.flutter.dev/development/platform-integration/windows/building#integrating-with-windows
[قنوات المنصة]: https://docs.flutter.dev/development/platform-integration/platform-channels
[مثال التوافق]: https://github.com/flutter/flutter/tree/main/examples/platform_channel
[Impeller]: https://docs.flutter.dev/perf/impeller

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---