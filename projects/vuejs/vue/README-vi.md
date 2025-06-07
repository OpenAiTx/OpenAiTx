## Vue 2 đã kết thúc vòng đời hỗ trợ (End of Life)

**Bạn đang xem kho lưu trữ không còn hoạt động của Vue 2. Kho lưu trữ được duy trì tích cực cho phiên bản mới nhất của Vue là [vuejs/core](https://github.com/vuejs/core).**

Vue đã kết thúc vòng đời hỗ trợ vào ngày 31 tháng 12 năm 2023. Nó sẽ không còn nhận được các tính năng mới, cập nhật hay sửa lỗi nữa. Tuy nhiên, Vue 2 vẫn có sẵn trên tất cả các kênh phân phối hiện có (CDN, trình quản lý gói, Github, v.v.).

Nếu bạn đang bắt đầu một dự án mới, vui lòng bắt đầu với phiên bản Vue mới nhất (3.x). Chúng tôi cũng khuyến nghị mạnh mẽ người dùng Vue 2 hiện tại nâng cấp ([hướng dẫn](https://v3-migration.vuejs.org/)), nhưng chúng tôi cũng hiểu rằng không phải ai cũng có đủ thời gian hoặc lý do để thực hiện điều đó. Nếu bạn buộc phải tiếp tục sử dụng Vue 2 nhưng có các yêu cầu về tuân thủ hoặc bảo mật đối với phần mềm không còn được duy trì, hãy tham khảo [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme).

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## Nhà tài trợ

Vue.js là một dự án mã nguồn mở theo giấy phép MIT với quá trình phát triển liên tục hoàn toàn nhờ sự hỗ trợ từ những [nhà tài trợ tuyệt vời này](https://github.com/vuejs/core/blob/main/BACKERS.md). Nếu bạn muốn tham gia cùng họ, vui lòng cân nhắc [tài trợ cho sự phát triển của Vue](https://vuejs.org/sponsor/).

<p align="center">
  <h3 align="center">Nhà tài trợ đặc biệt</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## Giới thiệu

Vue (phát âm là `/vjuː/`, giống từ “view”) là một **framework tiến bộ** để xây dựng giao diện người dùng. Nó được thiết kế từ đầu để có thể áp dụng dần dần và dễ dàng mở rộng từ một thư viện nhỏ đến một framework hoàn chỉnh tùy theo trường hợp sử dụng. Vue bao gồm một thư viện lõi dễ tiếp cận, chỉ tập trung vào tầng hiển thị, và một hệ sinh thái các thư viện hỗ trợ giúp bạn giải quyết sự phức tạp trong các ứng dụng đơn trang lớn (Single-Page Applications).

#### Tương thích trình duyệt

Vue.js hỗ trợ tất cả các trình duyệt [tuân thủ ES5](https://compat-table.github.io/compat-table/es5/) (IE8 và thấp hơn không được hỗ trợ).

## Hệ sinh thái

| Dự án                  | Trạng thái                                                    | Mô tả                                                     |
| ---------------------- | ------------------------------------------------------------- | --------------------------------------------------------- |
| [vue-router]           | [![vue-router-status]][vue-router-package]                    | Định tuyến ứng dụng đơn trang                             |
| [vuex]                 | [![vuex-status]][vuex-package]                                | Quản lý trạng thái quy mô lớn                             |
| [vue-cli]              | [![vue-cli-status]][vue-cli-package]                          | Tạo khung dự án                                           |
| [vue-loader]           | [![vue-loader-status]][vue-loader-package]                    | Bộ tải thành phần đơn tập tin (`*.vue` file) cho webpack  |
| [vue-server-renderer]  | [![vue-server-renderer-status]][vue-server-renderer-package]  | Hỗ trợ render phía máy chủ                                |
| [vue-class-component]  | [![vue-class-component-status]][vue-class-component-package]  | Decorator TypeScript cho API dựa trên class               |
| [vue-rx]               | [![vue-rx-status]][vue-rx-package]                            | Tích hợp RxJS                                             |
| [vue-devtools]         | [![vue-devtools-status]][vue-devtools-package]                | Tiện ích mở rộng DevTools cho trình duyệt                 |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## Tài liệu

Để xem [các ví dụ trực tiếp](https://v2.vuejs.org/v2/examples/) và tài liệu, hãy truy cập [vuejs.org](https://v2.vuejs.org).

## Câu hỏi

Để đặt câu hỏi và nhận hỗ trợ, vui lòng sử dụng [diễn đàn chính thức](https://forum.vuejs.org) hoặc [kênh trò chuyện cộng đồng](https://chat.vuejs.org/). Danh sách các vấn đề của kho lưu trữ này chỉ dành **riêng** cho báo cáo lỗi và yêu cầu tính năng.

## Vấn đề (Issues)

Vui lòng chắc chắn đã đọc [Danh sách kiểm tra khi báo cáo vấn đề](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) trước khi mở một vấn đề mới. Những vấn đề không tuân thủ hướng dẫn có thể bị đóng ngay lập tức.

## Nhật ký thay đổi

Những thay đổi chi tiết cho từng phiên bản được ghi lại trong [ghi chú phát hành](https://github.com/vuejs/vue/releases).

## Giữ liên lạc

- [Twitter](https://twitter.com/vuejs)
- [Blog](https://medium.com/the-vue-point)
- [Bảng việc làm](https://vuejobs.com/?ref=vuejs)

## Đóng góp

Vui lòng đảm bảo đã đọc [Hướng dẫn đóng góp](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) trước khi gửi pull request. Nếu bạn có dự án/thành phần/công cụ liên quan đến Vue, hãy thêm nó bằng pull request vào [danh sách tổng hợp này](https://github.com/vuejs/awesome-vue)!

Cảm ơn tất cả những người đã đóng góp cho Vue!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## Giấy phép

[MIT](https://opensource.org/licenses/MIT)

Bản quyền (c) 2013-nay, Yuxi (Evan) You

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---