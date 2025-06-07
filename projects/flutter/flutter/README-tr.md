<a href="https://flutter.dev/">
  <h1 align="center">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://storage.googleapis.com/cms-storage-bucket/6e19fee6b47b36ca613f.png">
      <img alt="Flutter" src="https://storage.googleapis.com/cms-storage-bucket/c823e53b3a1a7b0d36a9.png">
    </picture>
  </h1>
</a>

[![Flutter CI Durumu](https://flutter-dashboard.appspot.com/api/public/build-status-badge?repo=flutter)](https://flutter-dashboard.appspot.com/#/build?repo=flutter)
[![Discord rozet][]][Discord talimatları]
[![Twitter hesabı][]][Twitter rozeti]
[![BlueSky rozeti][]][BlueSky hesabı]
[![codecov](https://codecov.io/gh/flutter/flutter/branch/master/graph/badge.svg?token=11yDrJU2M2)](https://codecov.io/gh/flutter/flutter)
[![CII En İyi Uygulamalar](https://bestpractices.coreinfrastructure.org/projects/5631/badge)](https://bestpractices.coreinfrastructure.org/projects/5631)
[![SLSA 1](https://slsa.dev/images/gh-badge-level1.svg)](https://slsa.dev)

Flutter, Google'ın mobil, web ve masaüstü için tek bir kod tabanından
güzel ve hızlı kullanıcı deneyimleri oluşturmayı sağlayan SDK'sıdır.
Flutter mevcut kod ile çalışır, dünya genelinde geliştiriciler ve kuruluşlar
tarafından kullanılır ve ücretsiz ve açık kaynaklıdır.

## Dokümantasyon

* [Flutter'ı yükle](https://flutter.dev/get-started/)
* [Flutter dokümantasyonu](https://docs.flutter.dev/)
* [Geliştirme wikisi](./docs/README.md)
* [Flutter'a katkıda bulunma](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

Yeni sürümlerle ilgili duyurular için
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce)
posta listesine abone olabilirsiniz. Belgelerimiz ayrıca sürümler arasında olan [önemli değişiklikleri](https://docs.flutter.dev/release/breaking-changes) takip eder.

## Hizmet Şartları

Flutter aracı zaman zaman Google sunucularından kaynaklar indirebilir.
Flutter SDK'sını indirerek veya kullanarak, Google Hizmet Şartları'nı kabul etmiş olursunuz: https://policies.google.com/terms

Örneğin, GitHub üzerinden (önceden paketlenmiş bir arşivden farklı olarak) yüklendiğinde, Flutter aracı ilk çalıştırıldığında Dart SDK'sını Google sunucularından indirir, çünkü bu, `flutter` aracını çalıştırmak için kullanılır. Bu, Flutter yükseltildiğinde de (örn. `flutter upgrade` komutu çalıştırıldığında) gerçekleşir.

## Flutter Hakkında

Flutter'ın, iOS veya Android, web, Windows, macOS, Linux için ya da seçtiğiniz bir platformda UI araç takımı olarak hedeflediğinizde, üretken, genişletilebilir ve açık bir geliştirme modeliyle güzel ve hızlı uygulamalar oluşturmanıza yardımcı olacağına inanıyoruz.

### Güzel Kullanıcı Deneyimleri

Tasarımcıların, altındaki çerçevenin kısıtlamaları nedeniyle vizyonlarını azaltmak zorunda kalmadan, tüm yaratıcı vizyonlarını sunmalarını mümkün kılmak istiyoruz. Flutter’ın [katmanlı mimarisi], ekrandaki her piksel üzerinde size kontrol sağlar ve güçlü birleştirme yetenekleriyle grafik, video, metin ve kontrolleri kısıtlama olmadan üst üste bindirip animasyon yapmanıza olanak tanır. Flutter, iOS ([Cupertino]) ya da diğer platformlar ([Material]) için piksel mükemmeliğinde deneyimler sunan tam bir [widget seti][widget kataloğu] ile birlikte gelir ve tamamen yeni görsel bileşenler oluşturma veya özelleştirme desteği de sunar.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly ana görseli"></p>

### Hızlı Sonuçlar

Flutter hızlıdır. [Skia] (Chrome ve Android'in temelini oluşturan) ve [Impeller] gibi donanım hızlandırmalı 2D grafik kütüphaneleri tarafından desteklenmektedir. Flutter’ı, cihazınızın doğal hızında kesintisiz, takılmasız grafikler sunacak şekilde tasarladık.

Flutter kodu, 32-bit ve 64-bit ARM makine koduna (iOS ve Android için), web için JavaScript ve WebAssembly’ye, masaüstü cihazlar için ise Intel x64 ve ARM’a derlemeye olanak tanıyan dünya standartlarında [Dart platformu] tarafından desteklenir.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diyagramı"></p>

### Üretken Geliştirme

Flutter, [durumlu hızlı yeniden yükleme][Hızlı yeniden yükleme] sunar; böylece kodunuzda değişiklikler yapabilir ve uygulamanızı yeniden başlatmadan veya durumunu kaybetmeden sonuçları anında görebilirsiniz.

[![Hızlı yeniden yükleme animasyonu][]][Hızlı yeniden yükleme]

### Genişletilebilir ve Açık Model

Flutter, herhangi bir geliştirme aracıyla (veya hiçbiriyle) çalışır ve ayrıca hem [Visual Studio Code] hem de [IntelliJ / Android Studio] için editör eklentileri içerir. Flutter, hedef platformunuz ne olursa olsun geliştirme sürecinizi hızlandıracak [on binlerce paket][Flutter paketleri] sunar. Ayrıca, hem FFI ([Android'de][Android FFI], [iOS'da][iOS FFI], [macOS'da][macOS FFI], ve [Windows'da][Windows FFI]) hem de [platforma özel API'ler][platform kanalları] ile diğer yerel kodlara erişmek kolaydır.

Flutter tamamen açık kaynaklı bir projedir ve katkıları memnuniyetle karşılıyoruz.
Başlamak için gerekli bilgiler [katkıda bulunan rehberimizde](CONTRIBUTING.md) bulunabilir.

[flutter.dev]: https://flutter.dev
[Discord talimatları]: ./docs/contributing/Chat.md
[Discord rozet]: https://img.shields.io/discord/608014603317936148?logo=discord
[Twitter hesabı]: https://img.shields.io/twitter/follow/flutterdev.svg?style=social&label=Follow
[Twitter rozeti]: https://twitter.com/intent/follow?screen_name=flutterdev
[BlueSky rozeti]: https://img.shields.io/badge/Bluesky-0285FF?logo=bluesky&logoColor=fff&label=Follow%20me%20on&color=0285FF
[BlueSky hesabı]: https://bsky.app/profile/flutter.dev
[katmanlı mimari]: https://docs.flutter.dev/resources/inside-flutter
[mimari genel bakış]: https://docs.flutter.dev/resources/architectural-overview
[widget kataloğu]: https://flutter.dev/widgets/
[Cupertino]: https://docs.flutter.dev/development/ui/widgets/cupertino
[Material]: https://docs.flutter.dev/development/ui/widgets/material
[Skia]: https://skia.org/
[Dart platformu]: https://dart.dev/
[Hızlı yeniden yükleme animasyonu]: https://github.com/flutter/website/blob/main/src/content/assets/images/docs/tools/android-studio/hot-reload.gif?raw=true
[Hızlı yeniden yükleme]: https://docs.flutter.dev/development/tools/hot-reload
[Visual Studio Code]: https://marketplace.visualstudio.com/items?itemName=Dart-Code.flutter
[IntelliJ / Android Studio]: https://plugins.jetbrains.com/plugin/9212-flutter
[Flutter paketleri]: https://pub.dev/flutter
[Android FFI]: https://docs.flutter.dev/development/platform-integration/android/c-interop
[iOS FFI]: https://docs.flutter.dev/development/platform-integration/ios/c-interop
[macOS FFI]: https://docs.flutter.dev/development/platform-integration/macos/c-interop
[Windows FFI]: https://docs.flutter.dev/development/platform-integration/windows/building#integrating-with-windows
[platform kanalları]: https://docs.flutter.dev/development/platform-integration/platform-channels
[interop örneği]: https://github.com/flutter/flutter/tree/main/examples/platform_channel
[Impeller]: https://docs.flutter.dev/perf/impeller

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---