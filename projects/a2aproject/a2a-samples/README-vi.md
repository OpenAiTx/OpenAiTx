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

Kho lưu trữ này chứa các mẫu mã và bản demo sử dụng [Giao thức Agent2Agent (A2A)](https://goo.gle/a2a).

## Kho lưu trữ liên quan

- [A2A](https://github.com/a2aproject/A2A) - Đặc tả và tài liệu A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK A2A cho Python.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Công cụ giao diện người dùng để kiểm tra các agent hỗ trợ A2A.

## Đóng góp

Rất hoan nghênh các đóng góp! Xem [Hướng dẫn đóng góp](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Hỗ trợ

Vui lòng sử dụng [trang issues](https://github.com/a2aproject/a2a-samples/issues) để gửi đề xuất, phản hồi hoặc báo cáo lỗi.

## Miễn trừ trách nhiệm

Kho lưu trữ này không phải là sản phẩm được Google hỗ trợ chính thức. Mã nguồn trong kho lưu trữ này chỉ dành cho mục đích minh họa.

Quan trọng: Mã mẫu được cung cấp chỉ dùng để minh họa và trình bày cơ chế của giao thức Agent-to-Agent (A2A). Khi xây dựng ứng dụng sản xuất, điều quan trọng là phải xem bất kỳ agent nào hoạt động ngoài phạm vi kiểm soát trực tiếp của bạn là thực thể có thể không đáng tin cậy.

Tất cả dữ liệu nhận từ agent bên ngoài — bao gồm nhưng không giới hạn ở AgentCard, tin nhắn, hiện vật, và trạng thái tác vụ — nên được xử lý như dữ liệu không tin cậy. Ví dụ, một agent độc hại có thể cung cấp AgentCard chứa dữ liệu đã bị sửa đổi trong các trường (ví dụ: mô tả, tên, kỹ năng.mô tả). Nếu dữ liệu này được sử dụng mà không kiểm tra an toàn để tạo prompt cho Mô hình Ngôn ngữ Lớn (LLM), nó có thể khiến ứng dụng của bạn bị tấn công prompt injection. Việc không xác thực và làm sạch dữ liệu này trước khi sử dụng có thể gây ra lỗ hổng bảo mật cho ứng dụng của bạn.

Nhà phát triển chịu trách nhiệm thực hiện các biện pháp bảo mật phù hợp, như xác thực đầu vào và xử lý thông tin xác thực an toàn để bảo vệ hệ thống và người dùng của họ.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---