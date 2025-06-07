<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## Giới thiệu

Tauri là một framework để xây dựng các tệp nhị phân nhỏ gọn, cực kỳ nhanh cho tất cả các nền tảng máy tính để bàn chính. Các nhà phát triển có thể tích hợp bất kỳ framework giao diện nào biên dịch ra HTML, JS và CSS để xây dựng giao diện người dùng. Phần backend của ứng dụng là một tệp nhị phân viết bằng Rust với API mà phía giao diện có thể tương tác.

Giao diện người dùng trong các ứng dụng Tauri hiện đang sử dụng [`tao`](https://docs.rs/tao) như một thư viện quản lý cửa sổ trên macOS, Windows, Linux, Android và iOS. Để kết xuất ứng dụng của bạn, Tauri sử dụng [WRY](https://github.com/tauri-apps/wry), một thư viện cung cấp giao diện thống nhất với webview của hệ thống, tận dụng WKWebView trên macOS & iOS, WebView2 trên Windows, WebKitGTK trên Linux và Android System WebView trên Android.

Để tìm hiểu thêm về cách các thành phần này liên kết với nhau, vui lòng tham khảo tài liệu [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md) này.

## Bắt đầu

Nếu bạn quan tâm đến việc tạo một ứng dụng Tauri, vui lòng truy cập [trang tài liệu](https://tauri.app).

Cách nhanh nhất để bắt đầu là cài đặt [các yêu cầu cần thiết](https://v2.tauri.app/start/prerequisites/) cho hệ thống của bạn và tạo một dự án mới với [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage). Ví dụ với `npm`:

```sh
npm create tauri-app@latest
```

## Tính năng

Danh sách các tính năng của Tauri bao gồm, nhưng không giới hạn ở:

- Tích hợp sẵn công cụ đóng gói ứng dụng để tạo các gói ứng dụng với các định dạng như `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` và các trình cài đặt Windows như `.exe` (qua NSIS) và `.msi` (qua WiX).
- Tích hợp sẵn tính năng tự cập nhật (chỉ trên máy tính để bàn)
- Biểu tượng khay hệ thống
- Thông báo gốc
- Giao thức WebView gốc (Tauri không tạo máy chủ http(s) localhost để phục vụ nội dung WebView)
- GitHub action cho CI mượt mà
- Tiện ích mở rộng VS Code

### Nền tảng

Tauri hiện hỗ trợ phát triển và phân phối trên các nền tảng sau:

| Nền tảng   | Phiên bản                                                                                                        |
| :--------- | :-------------------------------------------------------------------------------------------------------------- |
| Windows    | 7 trở lên                                                                                                        |
| macOS      | 10.15 trở lên                                                                                                   |
| Linux      | webkit2gtk 4.0 cho Tauri v1 (ví dụ Ubuntu 18.04). webkit2gtk 4.1 cho Tauri v2 (ví dụ Ubuntu 22.04).             |
| iOS/iPadOS | 9 trở lên                                                                                                        |
| Android    | 7 trở lên (hiện tại là 8 trở lên)                                                                               |

## Đóng góp

Trước khi bạn bắt đầu làm việc gì đó, tốt nhất nên kiểm tra xem đã có issue tồn tại chưa. Ngoài ra, nên ghé qua máy chủ Discord và xác nhận với nhóm xem ý tưởng đó có hợp lý không hoặc liệu đã có ai khác đang làm chưa.

Vui lòng đảm bảo đọc [Hướng dẫn đóng góp](./.github/CONTRIBUTING.md) trước khi gửi pull request.

Cảm ơn tất cả mọi người đã đóng góp cho Tauri!

### Tài liệu

Việc viết tài liệu trong một hệ thống đa ngôn ngữ là một thách thức. Vì vậy, chúng tôi ưu tiên sử dụng tài liệu nội tuyến trong mã nguồn Rust & JS càng nhiều càng tốt. Hãy xem kho lưu trữ chứa trang tài liệu để biết thêm thông tin: <https://github.com/tauri-apps/tauri-docs>

## Đối tác

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

Để xem danh sách đầy đủ các nhà tài trợ, vui lòng truy cập [trang web của chúng tôi](https://tauri.app#sponsors) và [Open Collective](https://opencollective.com/tauri).

## Tổ chức

Tauri hướng tới trở thành một tập thể bền vững dựa trên các nguyên tắc hướng dẫn [cộng đồng phần mềm tự do và mở bền vững](https://sfosc.org). Vì mục tiêu này, Tauri đã trở thành một Chương trình trong [Commons Conservancy](https://commonsconservancy.org/), và bạn có thể đóng góp tài chính qua [Open Collective](https://opencollective.com/tauri).

## Giấy phép

Mã nguồn: (c) 2015 - Nay - Chương trình Tauri thuộc The Commons Conservancy.

MIT hoặc MIT/Apache 2.0 tùy trường hợp.

Logo: CC-BY-NC-ND

- Thiết kế logo Tauri gốc bởi [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) và [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---