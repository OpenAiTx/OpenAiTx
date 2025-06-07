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

Flutter คือ SDK ของ Google สำหรับสร้างประสบการณ์ผู้ใช้งานที่สวยงามและรวดเร็วบนอุปกรณ์มือถือ เว็บ และเดสก์ท็อป จากชุดโค้ดเดียว Flutter สามารถทำงานร่วมกับโค้ดที่มีอยู่ ใช้โดยนักพัฒนาและองค์กรทั่วโลก และเป็นโอเพ่นซอร์สให้ใช้ฟรี

## เอกสารประกอบ

* [ติดตั้ง Flutter](https://flutter.dev/get-started/)
* [เอกสาร Flutter](https://docs.flutter.dev/)
* [วิกิการพัฒนา](./docs/README.md)
* [การมีส่วนร่วมกับ Flutter](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

สำหรับประกาศเกี่ยวกับเวอร์ชันใหม่ ติดตามรายชื่ออีเมล [flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce) เอกสารของเรายังติดตาม [การเปลี่ยนแปลงสำคัญ](https://docs.flutter.dev/release/breaking-changes) ในแต่ละเวอร์ชันอีกด้วย

## ข้อกำหนดในการให้บริการ

เครื่องมือ Flutter อาจดาวน์โหลดทรัพยากรจากเซิร์ฟเวอร์ของ Google เป็นครั้งคราว โดยการดาวน์โหลดหรือใช้งาน Flutter SDK ถือว่าคุณยอมรับข้อกำหนดในการให้บริการของ Google: https://policies.google.com/terms

ตัวอย่างเช่น เมื่อทำการติดตั้งจาก GitHub (แทนที่จะติดตั้งจากไฟล์แพ็คเกจสำเร็จรูป) เครื่องมือ Flutter จะดาวน์โหลด Dart SDK จากเซิร์ฟเวอร์ของ Google ทันทีที่เรียกใช้ครั้งแรก เนื่องจาก Dart SDK ถูกใช้ในการเรียกใช้เครื่องมือ `flutter` เอง สิ่งนี้จะเกิดขึ้นเช่นกันเมื่อทำการอัปเกรด Flutter (เช่น การรันคำสั่ง `flutter upgrade`)

## เกี่ยวกับ Flutter

เราคิดว่า Flutter จะช่วยให้คุณสร้างแอปที่สวยงามและรวดเร็ว ด้วยโมเดลการพัฒนาที่มีประสิทธิภาพ ขยายได้ และเปิดกว้าง ไม่ว่าคุณจะตั้งเป้าหมายไปยัง iOS หรือ Android เว็บ วินโดวส์ macOS ลินุกซ์ หรือฝังเป็น UI toolkit สำหรับแพลตฟอร์มที่คุณเลือก

### ประสบการณ์ผู้ใช้ที่สวยงาม

เราต้องการให้นักออกแบบสามารถถ่ายทอดวิสัยทัศน์สร้างสรรค์ของตนได้อย่างเต็มที่ โดยไม่ต้องลดทอนเนื่องจากข้อจำกัดของเฟรมเวิร์กพื้นฐาน สถาปัตยกรรมแบบ [layered architecture] ของ Flutter ช่วยให้คุณควบคุมทุกพิกเซลบนหน้าจอ และความสามารถด้านคอมโพสิตที่ทรงพลังช่วยให้คุณซ้อนและเคลื่อนไหวกราฟิก วิดีโอ ข้อความ และคอนโทรลต่าง ๆ ได้อย่างไม่มีข้อจำกัด Flutter มาพร้อมกับ [ชุดวิดเจ็ต][widget catalog] ที่สร้างประสบการณ์ระดับพิกเซลเพอร์เฟกต์ไม่ว่าคุณจะสร้างสำหรับ iOS ([Cupertino]) หรือแพลตฟอร์มอื่น ๆ ([Material]) พร้อมรองรับการปรับแต่งหรือสร้างองค์ประกอบภาพใหม่ทั้งหมดได้ตามต้องการ

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### ผลลัพธ์ที่รวดเร็ว

Flutter เร็วมาก ขับเคลื่อนโดยไลบรารีกราฟิก 2D ที่เร่งด้วยฮาร์ดแวร์ เช่น [Skia] (ซึ่งเป็นพื้นฐานของ Chrome และ Android) และ [Impeller] เราออกแบบ Flutter เพื่อรองรับกราฟิกที่ลื่นไหล ไม่สะดุด และทำงานได้เร็วเท่ากับความเร็วของอุปกรณ์ของคุณ

โค้ด Flutter ขับเคลื่อนโดย [Dart platform] ซึ่งมีความสามารถในการคอมไพล์เป็นโค้ดเครื่อง ARM 32 บิตและ 64 บิตสำหรับ iOS และ Android, JavaScript และ WebAssembly สำหรับเว็บ รวมถึง Intel x64 และ ARM สำหรับอุปกรณ์เดสก์ท็อป

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### การพัฒนาที่มีประสิทธิภาพ

Flutter มีฟีเจอร์ [stateful hot reload][Hot reload] ที่ช่วยให้คุณปรับเปลี่ยนโค้ดและเห็นผลลัพธ์ได้ทันทีโดยไม่ต้องรีสตาร์ทแอปหรือสูญเสียสถานะของแอป

[![Hot reload animation][]][Hot reload]

### โมเดลที่ขยายได้และเปิดกว้าง

Flutter ใช้งานร่วมกับเครื่องมือพัฒนาใด ๆ ก็ได้ (หรือไม่ใช้เครื่องมือเลยก็ได้) และยังมีปลั๊กอินสำหรับทั้ง [Visual Studio Code] และ [IntelliJ / Android Studio] Flutter มี [แพ็กเกจมากมาย][Flutter packages] ให้คุณใช้เร่งการพัฒนา ไม่ว่าคุณจะมุ่งเป้าไปที่แพลตฟอร์มใดก็ตาม และการเข้าถึงโค้ดเนทีฟอื่น ๆ ก็ทำได้ง่าย ด้วยการรองรับทั้ง FFI ([บน Android][Android FFI], [บน iOS][iOS FFI], [บน macOS][macOS FFI], และ [บน Windows][Windows FFI]) รวมถึง [API เฉพาะแพลตฟอร์ม][platform channels]

Flutter เป็นโปรเจกต์โอเพ่นซอร์สอย่างสมบูรณ์ และเรายินดีต้อนรับทุกการมีส่วนร่วม ข้อมูลเกี่ยวกับวิธีเริ่มต้นสามารถดูได้ที่ [คู่มือผู้ร่วมพัฒนา](CONTRIBUTING.md)

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