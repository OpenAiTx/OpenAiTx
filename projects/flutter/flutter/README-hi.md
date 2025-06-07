<a href="https://flutter.dev/">
  <h1 align="center">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://storage.googleapis.com/cms-storage-bucket/6e19fee6b47b36ca613f.png">
      <img alt="Flutter" src="https://storage.googleapis.com/cms-storage-bucket/c823e53b3a1a7b0d36a9.png">
    </picture>
  </h1>
</a>

[![Flutter CI Status](https://flutter-dashboard.appspot.com/api/public/build-status-badge?repo=flutter)](https://flutter-dashboard.appspot.com/#/build?repo=flutter)
[![Discord badge][]][Discord instructions]
[![Twitter handle][]][Twitter badge]
[![BlueSky badge][]][BlueSky handle]
[![codecov](https://codecov.io/gh/flutter/flutter/branch/master/graph/badge.svg?token=11yDrJU2M2)](https://codecov.io/gh/flutter/flutter)
[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/5631/badge)](https://bestpractices.coreinfrastructure.org/projects/5631)
[![SLSA 1](https://slsa.dev/images/gh-badge-level1.svg)](https://slsa.dev)

Flutter गूगल का SDK है, जो एक ही कोडबेस से मोबाइल, वेब और डेस्कटॉप के लिए सुंदर, तेज़ यूजर एक्सपीरियंस बनाने के लिए उपयोग किया जाता है। Flutter मौजूदा कोड के साथ काम करता है, दुनिया भर के डेवलपर्स और संगठनों द्वारा उपयोग किया जाता है, और यह मुफ्त तथा ओपन सोर्स है।

## प्रलेखन (Documentation)

* [Flutter स्थापित करें](https://flutter.dev/get-started/)
* [Flutter प्रलेखन](https://docs.flutter.dev/)
* [डेवलपमेंट विकी](./docs/README.md)
* [Flutter में योगदान करें](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

नई रिलीज़ के बारे में घोषणाओं के लिए, [flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce) मेलिंग लिस्ट को फॉलो करें। हमारा प्रलेखन रिलीज़ के दौरान [महत्वपूर्ण बदलावों](https://docs.flutter.dev/release/breaking-changes) को भी ट्रैक करता है।

## सेवा की शर्तें (Terms of service)

Flutter टूल कभी-कभी Google सर्वर से संसाधनों को डाउनलोड कर सकता है। Flutter SDK डाउनलोड या उपयोग करके, आप Google की सेवा की शर्तों से सहमत होते हैं: https://policies.google.com/terms

उदाहरण के लिए, जब GitHub से इंस्टॉल किया जाता है (प्रीपैकेज्ड आर्काइव से नहीं), तो Flutter टूल पहली बार चलाने पर Dart SDK को तुरंत Google सर्वर से डाउनलोड करेगा, क्योंकि यह `flutter` टूल को चलाने के लिए उपयोग किया जाता है। यह तब भी होगा जब Flutter को अपग्रेड किया जाएगा (जैसे `flutter upgrade` कमांड चलाने पर)।

## Flutter के बारे में

हम मानते हैं कि Flutter आपकी मदद करेगा सुंदर, तेज़ ऐप्स बनाने में, एक उत्पादक, विस्तार योग्य और ओपन डेवेलपमेंट मॉडल के साथ, चाहे आप iOS या Android, वेब, Windows, macOS, Linux को टार्गेट कर रहे हों या इसे अपनी पसंद के प्लेटफॉर्म के लिए UI टूलकिट के रूप में एम्बेड कर रहे हों।

### सुंदर यूजर एक्सपीरियंस

हम चाहते हैं कि डिज़ाइनर अपनी पूरी रचनात्मक दृष्टि को बिना किसी समझौते के प्रस्तुत कर सकें, जो आमतौर पर अंडरलाइंग फ्रेमवर्क की सीमाओं के कारण होता है। Flutter की [लेयर्ड आर्किटेक्चर] आपको स्क्रीन पर हर पिक्सल पर नियंत्रण देती है और इसकी शक्तिशाली कंपोजिटिंग क्षमताएं आपको बिना किसी सीमा के ग्राफ़िक्स, वीडियो, टेक्स्ट और कंट्रोल्स को ओवरले और एनिमेट करने देती हैं। Flutter में एक पूरा [विजेट सेट][widget catalog] शामिल है, जो पिक्सल-परफेक्ट एक्सपीरियंस देता है, चाहे आप iOS ([Cupertino]) या अन्य प्लेटफॉर्म ([Material]) के लिए बना रहे हों, साथ ही पूरी तरह से नए विजुअल कंपोनेंट्स कस्टमाइज़ या क्रिएट करने का समर्थन भी मिलता है।

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### तेज़ परिणाम

Flutter तेज़ है। यह हार्डवेयर-एक्सेलरेटेड 2D ग्राफिक्स लाइब्रेरीज़ जैसे [Skia] (जो Chrome और Android का भी आधार है) और [Impeller] द्वारा संचालित है। हमने Flutter को आपके डिवाइस की नेटिव स्पीड पर ग्लिच-फ्री, जैंक-फ्री ग्राफिक्स को सपोर्ट करने के लिए डिज़ाइन किया है।

Flutter कोड विश्व-स्तरीय [Dart प्लेटफार्म] द्वारा संचालित है, जो iOS और Android के लिए 32-बिट और 64-बिट ARM मशीन कोड, वेब के लिए JavaScript और WebAssembly, साथ ही डेस्कटॉप डिवाइसेज़ के लिए Intel x64 और ARM में कंपाइल करने की सुविधा देता है।

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### उत्पादक विकास

Flutter [स्टेटफुल हॉट रीलोड][Hot reload] ऑफर करता है, जिससे आप अपने कोड में बदलाव कर सकते हैं और तुरंत परिणाम देख सकते हैं, बिना अपनी ऐप को रीस्टार्ट किए या उसका स्टेट खोए।

[![Hot reload animation][]][Hot reload]

### विस्तार योग्य और ओपन मॉडल

Flutter किसी भी डेवेलपमेंट टूल (या बिना किसी टूल के भी) के साथ काम करता है, और साथ ही [Visual Studio Code] और [IntelliJ / Android Studio] दोनों के लिए एडिटर प्लग-इन भी शामिल हैं। Flutter आपके डेवेलपमेंट को तेज़ करने के लिए [दसियों हज़ार पैकेज][Flutter packages] उपलब्ध कराता है, चाहे आपका टार्गेट प्लेटफॉर्म कुछ भी हो। और अन्य नेटिव कोड तक पहुँच आसान है, FFI ([Android पर][Android FFI], [iOS पर][iOS FFI], [macOS पर][macOS FFI], और [Windows पर][Windows FFI]) के साथ-साथ [प्लेटफॉर्म-विशिष्ट API][platform channels] का समर्थन भी है।

Flutter एक पूर्णत: ओपन-सोर्स प्रोजेक्ट है, और हम योगदानों का स्वागत करते हैं। आरंभ करने की जानकारी हमारे [योगदानकर्ता गाइड](CONTRIBUTING.md) में पाई जा सकती है।

[flutter.dev]: https://flutter.dev
[Discord instructions]: ./docs/contributing/Chat.md
[Discord badge]: https://img.shields.io/discord/608014603317936148?logo=discord
[Twitter handle]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[Twitter badge]: https://twitter.com/intent/follow?screen_name=flutterdev
[BlueSky badge]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[BlueSky handle]: https://bsky.app/profile/flutter.dev
[layered architecture]: https://docs.flutter.dev/resources/inside-flutter
[architectural overview]: https://docs.flutter.dev/resources/architectural-overview
[widget catalog]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[Dart platform]: https://dart.dev/
[Hot reload animation]: https://github.com/flutter/website/blob/main/src/content/assets/images/docs/tools/android-studio/hot-reload.gif?raw=true
[Hot reload]: https://docs.flutter.dev/development/tools/hot-reload
[Visual Studio Code]: https://marketplace.visualstudio.com/items?itemName=Dart-Code.flutter
[IntelliJ / Android Studio]: https://plugins.jetbrains.com/plugin/9212-flutter
[Flutter packages]: https://pub.dev/flutter
[Android FFI]: https://docs.flutter.dev/development/platform-integration/android/c-interop
[iOS FFI]: https://docs.flutter.dev/development/platform-integration/ios/c-interop
[macOS FFI]: https://docs.flutter.dev/development/platform-integration/macos/c-interop
[Windows FFI]: https://docs.flutter.dev/development/platform-integration/windows/building#integrating-with-windows
[platform channels]: https://docs.flutter.dev/development/platform-integration/platform-channels
[interop example]: https://github.com/flutter/flutter/tree/main/examples/platform_channel
[Impeller]: https://docs.flutter.dev/perf/impeller

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---