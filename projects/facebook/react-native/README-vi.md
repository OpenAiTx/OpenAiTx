<h1 align="center">
  <a href="https://reactnative.dev/">
    React Native
  </a>
</h1>

<p align="center">
  <strong>Học một lần, viết ở mọi nơi:</strong><br>
  Xây dựng ứng dụng di động với React.
</p>

<p align="center">
  <a href="https://github.com/facebook/react-native/blob/HEAD/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="React Native được phát hành dưới giấy phép MIT." />
  </a>
  <a href="https://www.npmjs.org/package/react-native">
    <img src="https://img.shields.io/npm/v/react-native?color=brightgreen&label=npm%20package" alt="Phiên bản gói npm hiện tại." />
  </a>
  <a href="https://reactnative.dev/docs/contributing">
    <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="Chào mừng PRs!" />
  </a>
  <a href="https://twitter.com/intent/follow?screen_name=reactnative">
    <img src="https://img.shields.io/twitter/follow/reactnative.svg?label=Follow%20@reactnative" alt="Theo dõi @reactnative" />
  </a>
</p>

<h3 align="center">
  <a href="https://reactnative.dev/docs/getting-started">Bắt đầu</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/tutorial">Học những điều cơ bản</a>
  <span> · </span>
  <a href="https://reactnative.dev/showcase">Trình diễn</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/contributing">Đóng góp</a>
  <span> · </span>
  <a href="https://reactnative.dev/help">Cộng đồng</a>
  <span> · </span>
  <a href="https://github.com/facebook/react-native/blob/HEAD/.github/SUPPORT.md">Hỗ trợ</a>
</h3>

React Native mang [**React**'s][r] - khung giao diện khai báo UI đến iOS và Android. Với React Native, bạn sử dụng các điều khiển giao diện gốc và có quyền truy cập đầy đủ vào nền tảng gốc.

- **Khai báo.** React giúp việc tạo giao diện người dùng tương tác trở nên dễ dàng. Các view khai báo làm cho mã của bạn dễ dự đoán hơn và dễ debug hơn.
- **Dựa trên thành phần.** Xây dựng các thành phần được đóng gói quản lý trạng thái của chính chúng, sau đó kết hợp chúng để tạo ra các giao diện phức tạp.
- **Tốc độ phát triển.** Thấy các thay đổi cục bộ trong vài giây. Thay đổi mã JavaScript có thể được tải lại trực tiếp mà không cần xây dựng lại ứng dụng gốc.
- **Tính di động.** Tái sử dụng mã trên iOS, Android và [nền tảng khác][p].

React Native được phát triển và hỗ trợ bởi nhiều công ty và các cộng tác viên lõi cá nhân. Tìm hiểu thêm trong [tổng quan hệ sinh thái][e] của chúng tôi.

[r]: https://react.dev/
[p]: https://reactnative.dev/docs/out-of-tree-platforms
[e]: https://github.com/facebook/react-native/blob/HEAD/ECOSYSTEM.md

## Mục lục

- [Yêu cầu](#-requirements)
- [Xây dựng ứng dụng React Native đầu tiên của bạn](#-building-your-first-react-native-app)
- [Tài liệu](#-documentation)
- [Nâng cấp](#-upgrading)
- [Cách đóng góp](#-how-to-contribute)
- [Quy tắc ứng xử](#code-of-conduct)
- [Giấy phép](#-license)


## 📋 Yêu cầu

Các ứng dụng React Native có thể hướng đến iOS 15.1 và Android 7.0 (API 24) hoặc mới hơn. Bạn có thể sử dụng Windows, macOS hoặc Linux làm hệ điều hành phát triển, mặc dù việc xây dựng và chạy ứng dụng iOS chỉ giới hạn trên macOS. Các công cụ như [Expo](https://expo.dev) có thể được sử dụng để khắc phục điều này.

## 🎉 Xây dựng ứng dụng React Native đầu tiên của bạn

Làm theo [hướng dẫn Bắt đầu](https://reactnative.dev/docs/getting-started). Cách cài đặt React Native được khuyến nghị phụ thuộc vào dự án của bạn. Dưới đây là hướng dẫn nhanh cho các kịch bản phổ biến nhất:

- [Trải nghiệm React Native][hello-world]
- [Tạo ứng dụng mới][new-app]
- [Thêm React Native vào ứng dụng hiện có][existing]

[hello-world]: https://snack.expo.dev/@samples/hello-world
[new-app]: https://reactnative.dev/docs/getting-started
[existing]: https://reactnative.dev/docs/integration-with-existing-apps

## 📖 Tài liệu

Tài liệu đầy đủ cho React Native có thể được tìm thấy trên [website][docs] của chúng tôi.

Tài liệu React Native trình bày về các thành phần, API và các chủ đề riêng biệt cho React Native. Để biết thêm tài liệu về API React dùng chung giữa React Native và React DOM, hãy tham khảo [tài liệu React][r-docs].

Nguồn tài liệu và website React Native được lưu trữ trong một kho riêng, [**@facebook/react-native-website**][repo-website].

[docs]: https://reactnative.dev/docs/getting-started
[r-docs]: https://react.dev/learn
[repo-website]: https://github.com/facebook/react-native-website

## 🚀 Nâng cấp

Nâng cấp lên các phiên bản mới của React Native có thể mang đến cho bạn nhiều API, view, công cụ phát triển và các tính năng khác. Xem [Hướng dẫn Nâng cấp][u] để biết hướng dẫn chi tiết.

Các bản phát hành React Native được thảo luận [tại kho thảo luận này](https://github.com/reactwg/react-native-releases/discussions).

[u]: https://reactnative.dev/docs/upgrading
[repo-releases]: https://github.com/react-native-community/react-native-releases

## 👏 Cách đóng góp

Mục đích chính của kho lưu trữ này là tiếp tục phát triển lõi React Native. Chúng tôi muốn việc đóng góp cho dự án này trở nên dễ dàng và minh bạch nhất có thể, và chúng tôi biết ơn cộng đồng đã đóng góp sửa lỗi và cải tiến. Đọc bên dưới để biết cách bạn có thể tham gia cải thiện React Native.

### [Quy tắc Ứng xử][code]

Facebook đã áp dụng Quy tắc Ứng xử mà chúng tôi mong đợi các thành viên dự án tuân thủ.
Vui lòng đọc [toàn văn][code] để hiểu những hành động nào sẽ và không được chấp nhận.

[code]: https://code.fb.com/codeofconduct/

### [Hướng dẫn Đóng góp][contribute]

Đọc [**Hướng dẫn Đóng góp**][contribute] của chúng tôi để tìm hiểu về quy trình phát triển, cách đề xuất sửa lỗi và cải tiến, cũng như cách xây dựng và kiểm thử các thay đổi với React Native.

[contribute]: https://reactnative.dev/docs/contributing

### [Lộ trình mã nguồn mở][roadmap]

Bạn có thể tìm hiểu thêm về tầm nhìn của chúng tôi cho React Native trong [**Lộ trình**][roadmap].

[roadmap]: https://github.com/facebook/react-native/wiki/Roadmap

### Các vấn đề dễ cho người mới

Chúng tôi có một danh sách [good first issues][gfi] gồm các lỗi có phạm vi khá hạn chế. Đây là nơi tuyệt vời để bắt đầu, tích lũy kinh nghiệm và làm quen với quy trình đóng góp của chúng tôi.

[gfi]: https://github.com/facebook/react-native/labels/good%20first%20issue

### Thảo luận

Các thảo luận và đề xuất lớn hơn được thảo luận tại [**@react-native-community/discussions-and-proposals**][repo-meta].

[repo-meta]: https://github.com/react-native-community/discussions-and-proposals

## 📄 Giấy phép

React Native được cấp phép theo MIT, như được nêu trong file [LICENSE][l].

[l]: https://github.com/facebook/react-native/blob/main/LICENSE

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---