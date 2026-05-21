# Các mẫu Agent2Agent (A2A)

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Dùng thử trên Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 Ngôn ngữ</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
    </div>
  </details>
</div>

Chào mừng bạn đến với các mẫu mã nguồn và bản trình diễn chính thức cho [Giao thức Agent2Agent (A2A)](https://goo.gle/a2a).

Chúng tôi rất vui khi bạn có mặt ở đây! Dù bạn đang khám phá kiến trúc đa tác tử lần đầu hay xây dựng các mạng lưới tác tử tương tác nâng cao, kho lưu trữ này cung cấp tài nguyên học tập đơn giản, truyền cảm hứng và dễ tiếp cận để tăng tốc phát triển của bạn.

## Tại sao chọn Agent2Agent?

Trong một thế giới đa dạng về các framework và hệ sinh thái AI, các tác tử cần một ngôn ngữ chung để giao tiếp, hợp tác và phân công nhiệm vụ một cách an toàn. Giao thức A2A thiết lập một tiêu chuẩn mở, nhất quán cho sự tương tác giữa các tác tử.

Các ví dụ của chúng tôi cho thấy cách giải quyết các bài toán đa tác tử phức tạp một cách dễ dàng trên nhiều ngôn ngữ và ứng dụng chủ khác nhau.

## Bắt đầu nhanh

Khởi động và chạy ngay lập tức bằng cách triển khai một tác tử Helloworld và giao tiếp với nó qua ứng dụng dòng lệnh Python của chúng tôi.

1. **Khởi động máy chủ Agent**:
   Mở terminal và khởi chạy máy chủ tác tử Helloworld:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **Chạy Host Client**:
   Mở một cửa sổ terminal thứ hai và chạy ứng dụng khách CLI để gửi một tác vụ đến agent:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## Cấu Trúc Kho Lưu Trữ

Kho lưu trữ được tổ chức thành một số thư mục chính theo ngôn ngữ lập trình:

| Thư mục | Mô tả |
| --- | --- |
| [samples](/samples) | Các mẫu A2A cốt lõi được tổ chức theo ngôn ngữ lập trình. |
| [samples/python](/samples/python) | Trình bày các triển khai agent Python sử dụng A2A Python SDK. |
| [samples/go](/samples/go) | Trình bày các triển khai agent Go sử dụng A2A Go SDK. |
| [samples/dotnet](/samples/dotnet) | Trình bày các triển khai agent C# sử dụng A2A .NET SDK. |
| [samples/java](/samples/java) | Trình bày các triển khai agent Java sử dụng A2A Java SDK. |
| [samples/js](/samples/js) | Trình bày các triển khai agent Node.js sử dụng A2A JavaScript SDK. |

## Đóng Góp

Chúng tôi hoan nghênh và khuyến khích mọi đóng góp ở tất cả các cấp độ kỹ năng! Nếu bạn có ý tưởng cho một mẫu mới, sửa lỗi, hoặc cải thiện tài liệu, hãy xem [Hướng dẫn đóng góp](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md) của chúng tôi.

## Hỗ Trợ

Chúng tôi cam kết xây dựng một cộng đồng chào đón và hỗ trợ. Nếu bạn có câu hỏi, góp ý, hoặc gặp phải vấn đề nào, hãy liên hệ tại [trang issues](https://github.com/a2aproject/a2a-samples/issues) của chúng tôi.

## Các Kho Liên Quan

| Kho lưu trữ | Danh mục | Mô tả |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | Đặc tả lõi | Đặc tả và tài liệu của A2A. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | Công cụ | Công cụ giao diện người dùng kiểm tra các agent hỗ trợ A2A. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | Kiểm thử | Bộ kiểm thử xác thực sự tuân thủ giao thức A2A. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | Kiểm thử | Bộ công cụ xác minh khả năng tương thích giữa các triển khai và phiên bản SDK A2A khác nhau bằng mô hình truyền nhiều bước và các giao thức truyền dẫn khác nhau. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | SDK Python chính thức cho A2A. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | SDK Go chính thức cho A2A. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | SDK Java chính thức cho A2A. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | SDK Node.js/JavaScript chính thức cho A2A. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | SDK C#/.NET chính thức cho A2A. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | SDK Rust chính thức cho A2A. |

## Miễn Trừ Trách Nhiệm

**Quan trọng:** Mã mẫu được cung cấp chỉ nhằm mục đích minh họa và trình bày cơ chế của
Giao thức Agent-to-Agent (A2A). Khi xây dựng các ứng dụng sản xuất, điều quan trọng là phải xem bất kỳ agent nào hoạt động ngoài tầm kiểm soát trực tiếp của bạn là một thực thể có thể không đáng tin cậy.

Mọi dữ liệu nhận được từ một agent bên ngoài—bao gồm nhưng không giới hạn ở AgentCard của nó, tin nhắn,
artifact và trạng thái tác vụ—đều nên được xử lý như đầu vào không đáng tin cậy. Ví dụ, một agent độc hại
có thể cung cấp một AgentCard chứa dữ liệu được chế tạo trong các trường của nó (ví dụ: mô tả, tên,
skills.description). Nếu dữ liệu này được sử dụng mà không qua kiểm tra để tạo prompt cho Mô hình Ngôn ngữ Lớn (LLM),
nó có thể khiến ứng dụng của bạn gặp phải các cuộc tấn công chèn prompt. Việc không kiểm tra và làm sạch dữ liệu này đúng cách trước khi sử dụng
có thể tạo ra lỗ hổng bảo mật cho ứng dụng của bạn.

> Các nhà phát triển chịu trách nhiệm triển khai các biện pháp bảo mật phù hợp, chẳng hạn như kiểm tra đầu vào
> và xử lý thông tin xác thực an toàn để bảo vệ hệ thống và người dùng của họ.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---