# Mẫu Agent2Agent (A2A)

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

Kho lưu trữ này chứa các mẫu mã và bản demo sử dụng [Giao thức Agent2Agent (A2A)](https://goo.gle/a2a).

## Kho lưu trữ liên quan

- [A2A](https://github.com/a2aproject/A2A) - Đặc tả và tài liệu của A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK A2A Python.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Công cụ giao diện người dùng để kiểm tra các agent hỗ trợ A2A.

## Đóng góp

Hoan nghênh mọi đóng góp! Xem [Hướng dẫn đóng góp](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Hỗ trợ

Vui lòng sử dụng [trang Issues](https://github.com/a2aproject/a2a-samples/issues) để gửi đề xuất, phản hồi hoặc báo cáo lỗi.

## Tuyên bố miễn trừ trách nhiệm

Kho lưu trữ này không phải là sản phẩm chính thức được Google hỗ trợ. Mã nguồn trong kho lưu trữ này chỉ nhằm mục đích trình diễn.

Lưu ý quan trọng: Mã mẫu được cung cấp chỉ nhằm mục đích trình diễn và minh họa cơ chế của giao thức Agent-to-Agent (A2A). Khi xây dựng các ứng dụng sản xuất, điều quan trọng là phải xem bất kỳ agent nào hoạt động ngoài phạm vi kiểm soát trực tiếp của bạn là một thực thể có thể không đáng tin cậy.

Tất cả dữ liệu nhận được từ một agent bên ngoài—bao gồm nhưng không giới hạn thẻ AgentCard, tin nhắn, hiện vật và trạng thái nhiệm vụ—cần được xử lý như dữ liệu không đáng tin cậy. Ví dụ, một agent độc hại có thể cung cấp một AgentCard chứa dữ liệu được chỉnh sửa trong các trường của nó (ví dụ: mô tả, tên, kỹ năng.mô_tả). Nếu dữ liệu này được sử dụng mà không kiểm duyệt để tạo prompt cho Mô hình Ngôn ngữ Lớn (LLM), nó có thể làm lộ ứng dụng của bạn với các cuộc tấn công chèn prompt. Không xác thực và kiểm duyệt dữ liệu này đúng cách trước khi sử dụng có thể đưa lỗ hổng bảo mật vào ứng dụng của bạn.

Các nhà phát triển có trách nhiệm triển khai các biện pháp bảo mật phù hợp, như xác thực đầu vào và xử lý thông tin xác thực an toàn để bảo vệ hệ thống và người dùng của mình.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---