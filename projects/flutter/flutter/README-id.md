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

Flutter adalah SDK dari Google untuk membuat pengalaman pengguna yang indah dan cepat untuk perangkat mobile, web, dan desktop dari satu basis kode. Flutter dapat digunakan dengan kode yang sudah ada, digunakan oleh para pengembang dan organisasi di seluruh dunia, serta gratis dan bersifat open source.

## Dokumentasi

* [Instalasi Flutter](https://flutter.dev/get-started/)
* [Dokumentasi Flutter](https://docs.flutter.dev/)
* [Wiki Pengembangan](./docs/README.md)
* [Kontribusi pada Flutter](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

Untuk pengumuman tentang rilis baru, ikuti milis
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce).
Dokumentasi kami juga melacak [perubahan yang memutus kompatibilitas](https://docs.flutter.dev/release/breaking-changes) di setiap rilis.

## Syarat Layanan

Alat Flutter terkadang dapat mengunduh sumber daya dari server Google. Dengan mengunduh atau menggunakan SDK Flutter, Anda menyetujui Syarat Layanan Google: https://policies.google.com/terms

Sebagai contoh, ketika diinstal dari GitHub (berbeda dengan dari arsip yang sudah dikemas), alat Flutter akan mengunduh Dart SDK dari server Google secara langsung saat dijalankan pertama kali, karena digunakan untuk menjalankan alat `flutter` itu sendiri. Hal ini juga akan terjadi saat Flutter diperbarui (misal dengan menjalankan perintah `flutter upgrade`).

## Tentang Flutter

Kami percaya Flutter akan membantu Anda membuat aplikasi yang indah dan cepat, dengan model pengembangan yang produktif, mudah dikembangkan, dan terbuka, baik Anda menargetkan iOS atau Android, web, Windows, macOS, Linux, atau menggunakannya sebagai toolkit UI untuk platform pilihan Anda.

### Pengalaman Pengguna yang Indah

Kami ingin memungkinkan desainer untuk mewujudkan visi kreatif mereka sepenuhnya tanpa perlu mengurangi kualitas karena keterbatasan framework. [Arsitektur berlapis](https://docs.flutter.dev/resources/inside-flutter) milik Flutter memberikan Anda kontrol atas setiap piksel di layar dan kemampuan komposisi yang kuat memungkinkan Anda menumpuk dan menganimasikan grafik, video, teks, dan kontrol tanpa batasan. Flutter mencakup [katalog widget][widget catalog] lengkap yang memberikan pengalaman pixel-perfect baik untuk iOS ([Cupertino]) maupun platform lain ([Material]), serta mendukung kustomisasi atau pembuatan komponen visual baru sepenuhnya.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Gambar hero Reflectly"></p>

### Hasil yang Cepat

Flutter sangat cepat. Didukung oleh pustaka grafis 2D yang dipercepat perangkat keras seperti [Skia] (yang juga digunakan oleh Chrome dan Android) dan [Impeller]. Kami merancang Flutter untuk mendukung grafis bebas gangguan, tanpa lag pada kecepatan asli perangkat Anda.

Kode Flutter dijalankan oleh [platform Dart] kelas dunia, yang memungkinkan kompilasi ke kode mesin ARM 32-bit dan 64-bit untuk iOS dan Android, JavaScript dan WebAssembly untuk web, serta Intel x64 dan ARM untuk perangkat desktop.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Diagram Dart"></p>

### Pengembangan Produktif

Flutter menawarkan [stateful hot reload][Hot reload], yang memungkinkan Anda melakukan perubahan pada kode dan melihat hasilnya secara instan tanpa harus memulai ulang aplikasi atau kehilangan statusnya.

[![Animasi Hot reload][]][Hot reload]

### Model yang Mudah Dikembangkan dan Terbuka

Flutter dapat digunakan dengan alat pengembangan apa pun (atau tanpa alat sama sekali), dan juga menyediakan plugin editor untuk [Visual Studio Code] dan [IntelliJ / Android Studio]. Flutter menyediakan [puluhan ribu paket][Flutter packages] untuk mempercepat pengembangan Anda, terlepas dari platform target Anda. Akses ke kode native lain juga mudah, dengan dukungan FFI ([di Android][Android FFI], [di iOS][iOS FFI], [di macOS][macOS FFI], dan [di Windows][Windows FFI]) serta [API spesifik platform][platform channels].

Flutter adalah proyek open-source sepenuhnya, dan kami menerima kontribusi. Informasi tentang cara memulai dapat ditemukan di [panduan kontributor](CONTRIBUTING.md).

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