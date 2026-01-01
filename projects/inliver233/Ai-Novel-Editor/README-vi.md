
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

# Trình Soạn Thảo Tiểu Thuyết AI

Dựa trên PyQt6, đây là trình soạn thảo tiểu thuyết hỗ trợ AI, cung cấp các công cụ viết chuyên nghiệp như hoàn thiện thông minh, quản lý dự án, tổ chức ý tưởng.

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

3. Cài đặt các phụ thuộc
```bash
pip install -r requirements.txt
```

4. Chạy chương trình
```bash
python src/main.py
```

## Chức năng chính

### Quản lý dự án
- Cấu trúc tài liệu phân cấp (Tác phẩm > Chương > Cảnh)
- Nhập/xuất dự án (hỗ trợ các định dạng TEXT, MARKDOWN, DOCX, PDF, HTML)
- Sao lưu tự động và kiểm soát phiên bản
- Quản lý nhiều dự án

### Chức năng AI bổ sung
- Ba chế độ bổ sung: Tự động bổ sung, thủ công bổ sung (khuyên dùng: nhấn tab một lần để kích hoạt, nhấn tab lần nữa để áp dụng), tắt bổ sung
- Ba chế độ ngữ cảnh:
  - Chế độ nhanh: ngữ cảnh nhẹ, phản hồi nhanh
  - Chế độ cân bằng: ngữ cảnh vừa, cân bằng chất lượng và tốc độ
  - Chế độ toàn cục: ngữ cảnh toàn bộ dự án, hiệu quả tốt nhất
- Hỗ trợ nhiều dịch vụ AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, v.v.

### Quản lý đề cương
- Cấu trúc cây đề cương trực quan
- Sắp xếp kéo thả và điều chỉnh cấp bậc
- Điều hướng nhanh trong tài liệu
- Phân tích và đề xuất tối ưu đề cương

### Cấu hình API
- Trung tâm cấu hình AI hợp nhất
- Cấu hình mặc định cho nhiều nhà cung cấp dịch vụ
- Chức năng kiểm tra kết nối
- Lưu, nhập/xuất phương án cấu hình

### Cài đặt bổ sung thông minh
- Điều chỉnh độ trễ kích hoạt
- Giới hạn độ dài bổ sung
- Cấu hình độ dài ngữ cảnh
- Hỗ trợ phản hồi dạng dòng

### Chỉnh sửa từ khóa gợi ý
- Tích hợp nhiều mẫu viết sẵn
- Tùy chỉnh mẫu từ khóa gợi ý
- Quản lý phân loại mẫu
- Cấu hình mẫu theo từng chế độ

### Chức năng giao diện
- Hai chủ đề sáng tối
- Bố cục ba cột (cây dự án, trình soạn thảo, bảng khái niệm)
- Thanh bên có thể thu gọn
- Chế độ viết toàn màn hình
- Chế độ tập trung (câu, đoạn, máy đánh chữ, thiền, chìm đắm)

### Tìm kiếm và thay thế
- Tìm kiếm toàn bộ văn bản dự án
- Hỗ trợ biểu thức chính quy
- Chức năng thay thế hàng loạt
- Tùy chọn tìm kiếm nâng cao

### Quản lý khái niệm
- Tự động phát hiện nhân vật, địa điểm, vật phẩm
- Quản lý mối quan hệ giữa các khái niệm
- Hệ thống nhãn và phân loại
- Chèn nhanh khái niệm

## Phím tắt

- `Ctrl+N`: Tạo dự án mới
- `Ctrl+O`: Mở dự án
- `Ctrl+S`: Lưu tài liệu
- `F11`: Chế độ toàn màn hình
- `Tab`: Kích hoạt AI hoàn thành thủ công (ở chế độ thủ công)
- `Ctrl+F`: Tìm kiếm
- `Ctrl+H`: Tìm kiếm và thay thế
- `Ctrl+Shift+H`: Tìm kiếm thay thế nâng cao


## Yêu cầu hệ thống

- Python 3.8+
- PyQt6
- Hệ điều hành: Windows, macOS, Linux

## Tác giả

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---