# Trình soạn thảo tiểu thuyết AI

Trình soạn thảo tiểu thuyết hỗ trợ AI dựa trên PyQt6, cung cấp các công cụ viết chuyên nghiệp như tự động hoàn thành thông minh, quản lý dự án, tổ chức khái niệm, v.v.

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
- Tự động sao lưu và kiểm soát phiên bản
- Quản lý nhiều dự án

### Chức năng AI tự động hoàn thành
- Ba chế độ hoàn thành: Tự động hoàn thành, Hoàn thành thủ công (khuyên dùng: nhấn Tab một lần để kích hoạt, nhấn Tab lần nữa để áp dụng hoàn thành), Tắt hoàn thành
- Ba chế độ ngữ cảnh:
  - Chế độ nhanh: ngữ cảnh nhẹ, phản hồi nhanh
  - Chế độ cân bằng: ngữ cảnh vừa phải, cân bằng giữa chất lượng và tốc độ
  - Chế độ toàn cục: ngữ cảnh toàn bộ dự án, hiệu quả tốt nhất
- Hỗ trợ nhiều dịch vụ AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq, v.v.
### Quản lý đề cương
- Cấu trúc cây đề cương trực quan
- Kéo thả sắp xếp và điều chỉnh thứ bậc
- Dẫn hướng tài liệu nhanh chóng
- Phân tích đề cương và đề xuất tối ưu

### Cấu hình API
- Trung tâm cấu hình AI thống nhất
- Cấu hình thiết lập trước cho nhiều nhà cung cấp dịch vụ
- Chức năng kiểm tra kết nối
- Lưu, nhập và xuất phương án cấu hình

### Cài đặt tự động hoàn thành thông minh
- Điều chỉnh được độ trễ kích hoạt
- Giới hạn độ dài hoàn thành
- Cấu hình độ dài ngữ cảnh
- Hỗ trợ phản hồi theo luồng

### Chỉnh sửa từ gợi ý
- Tích hợp nhiều mẫu viết sẵn
- Tùy chỉnh mẫu từ gợi ý
- Quản lý phân loại mẫu
- Cấu hình mẫu theo chế độ đặc thù
### Chức năng giao diện
- Chủ đề sáng tối kép
- Bố cục ba cột (cây dự án, trình soạn thảo, bảng khái niệm)
- Thanh bên có thể thu gọn
- Chế độ viết toàn màn hình
- Chế độ tập trung (câu, đoạn, máy đánh chữ, chế độ thiền, chế độ đắm chìm)

### Tìm kiếm và thay thế
- Tìm kiếm văn bản toàn dự án
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
- `Tab`: Kích hoạt hoàn thành AI thủ công (ở chế độ thủ công)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---