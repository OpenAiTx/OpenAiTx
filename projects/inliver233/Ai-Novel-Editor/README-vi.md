<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# Trình biên tập tiểu thuyết AI

Trình biên tập tiểu thuyết hỗ trợ AI dựa trên PyQt6, cung cấp các công cụ viết chuyên nghiệp như tự động hoàn thành thông minh, quản lý dự án, tổ chức khái niệm, v.v.

## Cài đặt

1. Sao chép dự án
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Tạo môi trường ảo
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```
Sử dụng uv
```bash
uv venv -p 3.11
```
3. Cài đặt các phụ thuộc
```bash
pip install -r requirements.txt
```
Sử dụng uv
```bash
uv sync
```

4. Chạy chương trình
```bash
python -m src
```

## Chức năng chính

### Quản lý dự án
- Cấu trúc tài liệu phân cấp (Tác phẩm > Chương > Cảnh)
- Nhập và xuất dự án (hỗ trợ các định dạng TEXT, MARKDOWN, DOCX, PDF, HTML)
- Tự động sao lưu và kiểm soát phiên bản
- Quản lý nhiều dự án
### Chức năng bổ sung AI
- Ba chế độ bổ sung: Tự động bổ sung, bổ sung thủ công (khuyến nghị nhấn một lần tab để kích hoạt, nhấn thêm một lần tab để áp dụng bổ sung), vô hiệu hóa bổ sung
- Ba chế độ ngữ cảnh:
  - Chế độ nhanh: Ngữ cảnh nhẹ, phản hồi nhanh
  - Chế độ cân bằng: Ngữ cảnh trung bình, cân bằng giữa chất lượng và tốc độ
  - Chế độ toàn cục: Ngữ cảnh đầy đủ của dự án, hiệu quả tốt nhất
- Hỗ trợ nhiều dịch vụ AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, v.v.

### Quản lý đề cương
- Cấu trúc cây đề cương trực quan
- Kéo thả để sắp xếp và điều chỉnh cấp bậc
- Dẫn hướng tài liệu nhanh chóng
- Phân tích và đề xuất tối ưu hóa đề cương

### Cấu hình API
- Trung tâm cấu hình AI thống nhất
- Cấu hình mặc định cho nhiều nhà cung cấp dịch vụ
- Chức năng kiểm tra kết nối
- Lưu, nhập và xuất phương án cấu hình
### Cài đặt tự động hoàn thông minh
- Có thể điều chỉnh độ trễ kích hoạt
- Giới hạn độ dài hoàn thành
- Cấu hình độ dài ngữ cảnh
- Hỗ trợ phản hồi dạng luồng

### Chỉnh sửa từ khóa gợi ý
- Tích hợp nhiều mẫu viết sẵn
- Tùy chỉnh mẫu từ khóa gợi ý
- Quản lý phân loại mẫu
- Cấu hình mẫu theo từng chế độ

### Chức năng giao diện
- Chủ đề sáng và tối
- Bố cục ba cột (cây dự án, trình soạn thảo, bảng khái niệm)
- Thanh bên có thể thu gọn
- Chế độ viết toàn màn hình
- Chế độ tập trung (câu, đoạn, máy đánh chữ, chế độ thiền, chế độ nhập vai)

### Tìm kiếm và thay thế
- Tìm kiếm toàn bộ văn bản dự án
- Hỗ trợ biểu thức chính quy
- Chức năng thay thế hàng loạt
- Tuỳ chọn tìm kiếm nâng cao

### Quản lý khái niệm
- Tự động phát hiện vai trò, địa điểm, vật phẩm
- Quản lý quan hệ khái niệm
- Hệ thống nhãn và phân loại
- Chèn khái niệm nhanh

## Phím tắt

- `Ctrl+N`: Tạo dự án mới
- `Ctrl+O`: Mở dự án
- `Ctrl+S`: Lưu tài liệu
- `F11`: Chế độ toàn màn hình
- `Tab`: Kích hoạt AI hoàn thành thủ công (ở chế độ thủ công)
- `Ctrl+F`: Tìm kiếm
- `Ctrl+H`: Tìm kiếm và thay thế
- `Ctrl+Shift+H`: Tìm kiếm và thay thế nâng cao
## Yêu cầu hệ thống

- Python 3.8+
- PyQt6
- Hệ điều hành: Windows, macOS, Linux

## Tác giả

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---