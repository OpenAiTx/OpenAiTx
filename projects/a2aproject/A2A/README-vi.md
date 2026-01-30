# Giao thức Agent2Agent (A2A)

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Hỏi Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Ngôn ngữ</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Giao Thức Agent2Agent (A2A)</h1>
  </div>
</div>

**Một giao thức mở cho phép giao tiếp và khả năng tương tác giữa các ứng dụng đại lý đen hộp.**

Giao thức Agent2Agent (A2A) giải quyết một thách thức quan trọng trong lĩnh vực AI: cho phép các đại lý AI tổng hợp, được xây dựng trên nhiều framework khác nhau bởi các công ty khác nhau chạy trên các máy chủ riêng biệt, có thể giao tiếp và hợp tác hiệu quả - như các đại lý, không chỉ là công cụ. A2A hướng tới việc cung cấp một ngôn ngữ chung cho các đại lý, thúc đẩy một hệ sinh thái AI liên kết, mạnh mẽ và đổi mới hơn.

Với A2A, các đại lý có thể:

- Khám phá các khả năng của nhau.
- Thương lượng phương thức tương tác (văn bản, biểu mẫu, phương tiện).
- Hợp tác an toàn trong các tác vụ kéo dài.
- Hoạt động mà không cần tiết lộ trạng thái nội bộ, bộ nhớ hoặc công cụ.

## Video Giới Thiệu về A2A

[![A2A Intro Video](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## Tại sao chọn A2A?

Khi các đại lý AI trở nên phổ biến hơn, khả năng tương tác của họ là yếu tố then chốt để xây dựng các ứng dụng phức tạp, đa chức năng. A2A hướng tới:

- **Phá Vỡ Rào Cản:** Kết nối đại lý trên các hệ sinh thái khác nhau.
- **Cho Phép Hợp Tác Phức Tạp:** Cho phép các đại lý chuyên biệt làm việc cùng nhau trong những tác vụ một đại lý không thể tự xử lý.
- **Thúc Đẩy Tiêu Chuẩn Mở:** Khuyến khích cách tiếp cận cộng đồng cho giao tiếp đại lý, thúc đẩy đổi mới và mở rộng ứng dụng.
- **Bảo Toàn Tính Đục:** Cho phép đại lý hợp tác mà không phải chia sẻ bộ nhớ nội bộ, logic độc quyền hoặc các triển khai công cụ cụ thể, nâng cao bảo mật và bảo vệ tài sản trí tuệ.

### Các Tính Năng Chính

- **Giao Tiếp Chuẩn Hóa:** JSON-RPC 2.0 qua HTTP(S).
- **Khám Phá Đại Lý:** Thông qua "Agent Card" mô tả khả năng và thông tin kết nối.
- **Tương Tác Linh Hoạt:** Hỗ trợ yêu cầu/đáp ứng đồng bộ, streaming (SSE), và thông báo đẩy bất đồng bộ.
- **Trao Đổi Dữ Liệu Phong Phú:** Xử lý văn bản, tệp tin và dữ liệu JSON có cấu trúc.
- **Sẵn Sàng Cho Doanh Nghiệp:** Thiết kế với tiêu chí bảo mật, xác thực và khả năng giám sát.

## Bắt Đầu

- 📚 **Khám phá Tài liệu:** Truy cập [Trang Tài liệu Giao thức Agent2Agent](https://a2a-protocol.org) để xem tổng quan đầy đủ, đặc tả giao thức, hướng dẫn và các bài học.
- 📝 **Xem Đặc tả:** [Đặc tả Giao thức A2A](https://a2a-protocol.org/latest/specification/)
- Sử dụng các SDK:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) sử dụng maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) sử dụng [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Sử dụng [các ví dụ mẫu](https://github.com/a2aproject/a2a-samples) để xem A2A hoạt động

## Đóng góp

Chúng tôi hoan nghênh sự đóng góp từ cộng đồng để cải tiến và phát triển giao thức A2A!

- **Câu hỏi & Thảo luận:** Tham gia [GitHub Discussions](https://github.com/a2aproject/A2A/discussions).
- **Vấn đề & Phản hồi:** Báo cáo vấn đề hoặc đề xuất cải tiến qua [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Hướng dẫn đóng góp:** Xem [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) để biết chi tiết cách đóng góp.
- **Phản hồi riêng tư:** Sử dụng [Google Form này](https://goo.gle/a2a-feedback).
- **Chương trình Đối tác:** Khách hàng Google Cloud có thể tham gia chương trình đối tác qua [form này](https://goo.gle/a2a-partner).

## Tiếp theo

### Nâng cấp Giao thức

- **Khám phá Agent:**
    - Chuẩn hóa việc đưa vào các phương án ủy quyền và thông tin xác thực tùy chọn trực tiếp trong `AgentCard`.
- **Hợp tác Agent:**
    - Nghiên cứu phương thức `QuerySkill()` để kiểm tra động các kỹ năng không được hỗ trợ hoặc ngoài dự kiến.
- **Vòng đời & UX của Tác vụ:**
    - Hỗ trợ đàm phán UX động _trong_ một tác vụ (ví dụ: agent thêm audio/video giữa cuộc hội thoại).
- **Phương thức Client & Giao vận:**
    - Khám phá việc mở rộng hỗ trợ cho các phương thức do client khởi tạo (vượt ra ngoài quản lý tác vụ).
    - Cải thiện độ tin cậy của streaming và cơ chế thông báo đẩy.

## Giới thiệu

Giao thức A2A là một dự án mã nguồn mở dưới sự bảo trợ của Linux Foundation, do Google đóng góp. Dự án được cấp phép theo [Apache License 2.0](LICENSE) và mở rộng cho sự đóng góp từ cộng đồng.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---