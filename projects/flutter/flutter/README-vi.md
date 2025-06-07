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

Flutter là SDK của Google giúp xây dựng trải nghiệm người dùng đẹp mắt, nhanh chóng cho
di động, web và desktop chỉ từ một mã nguồn duy nhất. Flutter có thể làm việc với mã nguồn hiện có,
được sử dụng bởi các nhà phát triển và tổ chức trên toàn thế giới, và hoàn toàn miễn phí
cũng như mã nguồn mở.

## Tài liệu

* [Cài đặt Flutter](https://flutter.dev/get-started/)
* [Tài liệu Flutter](https://docs.flutter.dev/)
* [Wiki phát triển](./docs/README.md)
* [Đóng góp cho Flutter](https://github.com/flutter/flutter/blob/main/CONTRIBUTING.md)

Để nhận thông báo về các bản phát hành mới, hãy theo dõi danh sách gửi thư
[flutter-announce@googlegroups.com](https://groups.google.com/forum/#!forum/flutter-announce).
Tài liệu của chúng tôi cũng ghi lại [các thay đổi phá vỡ](https://docs.flutter.dev/release/breaking-changes) giữa các bản phát hành.

## Điều khoản dịch vụ

Công cụ Flutter đôi khi sẽ tải xuống tài nguyên từ các máy chủ của Google. Bằng việc
tải xuống hoặc sử dụng Flutter SDK, bạn đồng ý với Điều khoản dịch vụ của Google:
https://policies.google.com/terms

Ví dụ, khi cài đặt từ GitHub (khác với việc cài đặt từ gói đã đóng gói sẵn),
công cụ Flutter sẽ tải xuống Dart SDK từ máy chủ Google
ngay khi chạy lần đầu, vì nó được sử dụng để thực thi công cụ `flutter`.
Điều này cũng sẽ xảy ra khi Flutter được nâng cấp (ví dụ bằng cách chạy lệnh `flutter upgrade`).

## Giới thiệu về Flutter

Chúng tôi tin rằng Flutter sẽ giúp bạn tạo ra các ứng dụng đẹp mắt, nhanh chóng, với mô hình phát triển hiệu quả,
có khả năng mở rộng và mở, dù bạn đang hướng tới iOS hay Android,
web, Windows, macOS, Linux hoặc tích hợp nó như một bộ công cụ giao diện người dùng cho nền tảng bạn chọn.

### Trải nghiệm người dùng đẹp mắt

Chúng tôi mong muốn giúp các nhà thiết kế truyền tải trọn vẹn ý tưởng sáng tạo mà không bị giới hạn
bởi framework nền tảng. [Kiến trúc phân tầng] của Flutter cho phép bạn kiểm soát từng điểm ảnh trên màn hình
và khả năng tổng hợp mạnh mẽ giúp bạn xếp chồng và hoạt ảnh các đồ họa, video, văn bản và điều khiển mà không bị giới hạn.
Flutter bao gồm đầy đủ [bộ widget][widget catalog] mang lại trải nghiệm chính xác từng điểm ảnh dù bạn đang phát triển cho iOS ([Cupertino]) hay các nền tảng khác ([Material]), cùng với
hỗ trợ tùy chỉnh hoặc tạo các thành phần giao diện hoàn toàn mới.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/reflectly-hero-600px.png?raw=true" alt="Reflectly hero image"></p>

### Hiệu suất nhanh

Flutter rất nhanh. Nó được hỗ trợ bởi các thư viện đồ họa 2D tăng tốc phần cứng
như [Skia] (nền tảng của Chrome và Android) và [Impeller]. Chúng tôi đã kiến trúc Flutter để
hỗ trợ đồ họa mượt mà, không giật lag với tốc độ gốc của thiết bị.

Mã Flutter được vận hành bởi [nền tảng Dart] hàng đầu thế giới, cho phép
biên dịch sang mã máy ARM 32-bit và 64-bit cho iOS và Android,
JavaScript và WebAssembly cho web, cũng như Intel x64 và ARM
cho các thiết bị desktop.

<p align="center"><img src="https://github.com/flutter/website/blob/main/src/content/assets/images/docs/homepage/dart-diagram-small.png?raw=true" alt="Dart diagram"></p>

### Phát triển hiệu quả

Flutter cung cấp [stateful hot reload][Hot reload], cho phép bạn thay đổi mã nguồn
và xem kết quả ngay lập tức mà không cần khởi động lại ứng dụng hoặc mất trạng thái.

[![Hot reload animation][]][Hot reload]

### Mô hình mở rộng và mở

Flutter hoạt động với bất kỳ công cụ phát triển nào (hoặc không cần công cụ),
và cũng bao gồm các plugin cho cả [Visual Studio Code] và [IntelliJ / Android Studio].
Flutter cung cấp [hàng chục nghìn package][Flutter packages] để tăng tốc quá trình phát triển,
bất kể nền tảng mục tiêu của bạn là gì. Và việc truy cập mã native khác rất dễ dàng,
với hỗ trợ cả FFI ([trên Android][Android FFI], [trên iOS][iOS FFI],
[trên macOS][macOS FFI], và [trên Windows][Windows FFI]) cũng như
[các API đặc thù nền tảng][platform channels].

Flutter là một dự án hoàn toàn mã nguồn mở và chúng tôi hoan nghênh mọi sự đóng góp.
Thông tin về cách bắt đầu có thể được tìm thấy tại
[hướng dẫn đóng góp](CONTRIBUTING.md).

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