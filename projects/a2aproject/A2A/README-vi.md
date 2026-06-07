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
    <h1>Giao thức Agent2Agent (A2A)</h1>
  </div>
</div>

**Một giao thức mở cho phép giao tiếp và tương tác giữa các ứng dụng đại lý mờ đục.**

Giao thức Agent2Agent (A2A) giải quyết một thách thức quan trọng trong lĩnh vực AI: cho phép các đại lý AI tổng hợp, được xây dựng trên nhiều framework khác nhau bởi các công ty khác nhau vận hành trên các máy chủ riêng biệt, giao tiếp và hợp tác hiệu quả - như các đại lý, không chỉ là công cụ. A2A hướng tới cung cấp một ngôn ngữ chung cho các đại lý, thúc đẩy một hệ sinh thái AI liên kết, mạnh mẽ và sáng tạo hơn.

Với A2A, các đại lý có thể:

- Khám phá năng lực của nhau.
- Đàm phán phương thức tương tác (văn bản, biểu mẫu, đa phương tiện).
- Hợp tác an toàn về các nhiệm vụ kéo dài.
- Hoạt động mà không tiết lộ trạng thái nội bộ, bộ nhớ hoặc công cụ của mình.

## Khóa học DeepLearning.AI

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

Tham gia khóa học ngắn về [A2A: Giao thức Agent2Agent](https://goo.gle/dlai-a2a), được xây dựng hợp tác cùng Google Cloud và IBM Research, giảng dạy bởi [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini), và [Sandi Besen](https://github.com/sandijean90).

**Những gì bạn sẽ học:**

- **Làm cho đại lý tuân thủ A2A:** Công khai đại lý xây dựng với các framework như Google ADK, LangGraph hoặc BeeAI dưới dạng máy chủ A2A.
- **Kết nối đại lý:** Tạo khách hàng A2A từ đầu hoặc dùng tích hợp để kết nối với các đại lý tuân thủ A2A.
- **Điều phối quy trình làm việc:** Xây dựng các quy trình làm việc tuần tự và phân cấp của các đại lý tuân thủ A2A.
- **Hệ thống đa đại lý:** Xây dựng hệ thống đa đại lý trong lĩnh vực y tế sử dụng các framework khác nhau và xem cách A2A thúc đẩy hợp tác.
- **A2A và MCP:** Tìm hiểu cách A2A bổ sung cho MCP bằng việc cho phép các đại lý hợp tác lẫn nhau.

## Tại sao chọn A2A?

Khi các đại lý AI ngày càng phổ biến, khả năng tương tác là điều quan trọng để xây dựng các ứng dụng phức tạp, đa chức năng. A2A hướng tới:

- **Xóa bỏ ngăn cách:** Kết nối các đại lý giữa các hệ sinh thái khác nhau.
- **Cho phép hợp tác phức tạp:** Cho phép các đại lý chuyên biệt cùng làm việc trên nhiệm vụ mà một đại lý đơn lẻ không thể xử lý.
- **Thúc đẩy tiêu chuẩn mở:** Khuyến khích cách tiếp cận cộng đồng cho giao tiếp đại lý, thúc đẩy đổi mới và áp dụng rộng rãi.
- **Giữ tính mờ đục:** Cho phép đại lý hợp tác mà không cần chia sẻ bộ nhớ nội bộ, logic độc quyền hoặc triển khai công cụ cụ thể, tăng cường bảo mật và bảo vệ quyền sở hữu trí tuệ.

### Tính năng chính

- **Giao tiếp chuẩn hóa:** JSON-RPC 2.0 qua HTTP(S).
- **Khám phá Agent:** Thông qua "Agent Cards" mô tả khả năng và thông tin kết nối.
- **Tương tác linh hoạt:** Hỗ trợ yêu cầu/phản hồi đồng bộ, streaming (SSE) và thông báo đẩy bất đồng bộ.
- **Trao đổi dữ liệu phong phú:** Xử lý văn bản, tệp tin và dữ liệu JSON có cấu trúc.
- **Sẵn sàng cho doanh nghiệp:** Thiết kế với bảo mật, xác thực và khả năng quan sát.

## Bắt đầu

- 📚 **Khám phá tài liệu:** Truy cập [Trang tài liệu giao thức Agent2Agent](https://a2a-protocol.org) để xem tổng quan, đặc tả giao thức đầy đủ, hướng dẫn và tutorial.
- 📝 **Xem đặc tả:** [Đặc tả giao thức A2A](https://a2a-protocol.org/latest/specification/)
- Sử dụng các SDK:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) dùng maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) dùng [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 Sử dụng [mẫu](https://github.com/a2aproject/a2a-samples) của chúng tôi để xem A2A hoạt động

## Đóng góp

Chúng tôi hoan nghênh sự đóng góp của cộng đồng để nâng cao và phát triển giao thức A2A!

- **Câu hỏi & Thảo luận:** Tham gia [GitHub Discussions](https://github.com/a2aproject/A2A/discussions).
- **Vấn đề & Phản hồi:** Báo cáo vấn đề hoặc đề xuất cải tiến qua [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Hướng dẫn đóng góp:** Xem [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) để biết chi tiết cách đóng góp.
- **Phản hồi riêng:** Sử dụng [Google Form](https://goo.gle/a2a-feedback) này.
- **Chương trình đối tác:** Khách hàng Google Cloud có thể tham gia chương trình đối tác qua [form](https://goo.gle/a2a-partner) này.

## Tiếp theo

### Cải tiến giao thức

- **Khám phá Agent:**
    - Chính thức hóa việc đưa các cơ chế ủy quyền và thông tin xác thực tùy chọn trực tiếp vào `AgentCard`.
- **Cộng tác Agent:**
    - Khảo sát phương thức `QuerySkill()` để kiểm tra động các kỹ năng chưa hỗ trợ hoặc chưa dự đoán.
- **Vòng đời Tác vụ & Trải nghiệm Người dùng (UX):**
    - Hỗ trợ đàm phán UX động _trong_ một tác vụ (ví dụ: agent thêm âm thanh/hình ảnh trong quá trình trò chuyện).
- **Phương thức Client & Giao thức Truyền tải:**
    - Xem xét mở rộng hỗ trợ cho các phương thức do client khởi tạo (ngoài quản lý tác vụ).
    - Cải thiện độ tin cậy khi truyền phát và cơ chế thông báo đẩy.

## Giới thiệu

Giao thức A2A là một dự án mã nguồn mở dưới sự bảo trợ của Linux Foundation, do Google đóng góp. Dự án được cấp phép theo [Giấy phép Apache 2.0](LICENSE) và mở cho sự đóng góp từ cộng đồng.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---