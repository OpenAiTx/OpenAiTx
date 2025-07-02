# 🚀 MCP AI开发助手

> MCP công cụ hỗ trợ AI developer thực hiện phân tích yêu cầu thông minh và thiết kế kiến trúc

## ✨ Tính năng cốt lõi

- **Làm rõ yêu cầu thông minh**: Tự động nhận dạng loại dự án, sinh câu hỏi chuyên biệt
- **Quản lý nhận thức phân nhánh**: Theo dõi mục tiêu dự án, thiết kế chức năng, sở thích kỹ thuật, thiết kế UI, v.v.
- **Tự động sinh kiến trúc**: Sinh giải pháp kiến trúc kỹ thuật dựa trên yêu cầu đầy đủ
- **Lưu trữ lâu dài**: Tự động lưu kết quả phân tích, hỗ trợ xuất tài liệu

## 📁 Cấu hình nhanh

### Cấu hình phiên bản cũ
1. **Clone mã nguồn**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **Khuyến nghị môi trường ảo**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **Cài đặt phụ thuộc**
   ```bash
   pip install -r requirements.txt
   ```

4. **Vị trí file cấu hình**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **Thêm cấu hình**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Khởi động lại Claude Desktop**

### Cấu hình phiên bản mới
#### 🔧 Công cụ cốt lõi
1. **start_new_project** - Bắt đầu dự án mới
2. **create_requirement_blueprint** - Tạo bản thiết kế yêu cầu
3. **requirement_clarifier** - Nhận gợi ý làm rõ yêu cầu
4. **save_clarification_tasks** - Lưu nhiệm vụ làm rõ
5. **update_branch_status** - Cập nhật trạng thái nhánh
6. **requirement_manager** - Quản lý tài liệu yêu cầu
7. **check_architecture_prerequisites** - Kiểm tra điều kiện tiên quyết kiến trúc
8. **get_architecture_design_prompt** - Nhận gợi ý thiết kế kiến trúc
9. **save_generated_architecture** - Lưu thiết kế kiến trúc đã sinh
10. **export_final_document** - Xuất tài liệu hoàn chỉnh
11. **view_requirements_status** - Xem trạng thái yêu cầu

#### Cấu hình (Kết nối trực tiếp từ xa, sao chép vào công cụ của bạn, thay thế MCP_STORAGE_DIR bằng thư mục cục bộ của bạn)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 Quy trình sử dụng

### Các bước cơ bản

1. **Làm rõ yêu cầu**
   ```
   requirement_clarifier("Tôi muốn làm một nền tảng giáo dục trực tuyến")
   ```

2. **Quản lý yêu cầu**
   ```
   requirement_manager("Người dùng mục tiêu: học sinh và giáo viên", "Tổng quan dự án")
   ```

3. **Xem trạng thái**
   ```
   view_requirements_status()
   ```

4. **Thiết kế kiến trúc**
   ```
   architecture_designer("Kiến trúc nền tảng giáo dục trực tuyến")
   ```

5. **Xuất tài liệu**
   ```
   export_final_document()
   ```

## 🚀 Bắt đầu sử dụng

### Khởi động nhanh
1. **Cấu hình Claude Desktop** (tham khảo phương pháp cấu hình phía trên)
2. **Khởi động lại Claude Desktop**
3. **Bắt đầu phân tích yêu cầu thông minh**:
   ```
   requirement_clarifier("Mô tả ý tưởng dự án của bạn")
   ```
4. **Làm theo hướng dẫn thông minh của AI**, từng bước hoàn thiện các nhánh yêu cầu
5. **Xuất tài liệu hoàn chỉnh**:
   ```
   export_final_document()
   ```

### Thực tiễn tốt nhất
- 💬 **Tin tưởng quản lý nhánh của AI**: Để AI hướng dẫn bạn hoàn thành tất cả các nhánh yêu cầu
- 🎯 **Diễn đạt rõ ràng sở thích**: Diễn đạt rõ ràng sở thích về lựa chọn công nghệ, phong cách UI, v.v.
- 📊 **Thường xuyên kiểm tra trạng thái**: Sử dụng `view_requirements_status` để nắm bắt tiến độ
- 🤖 **Ủy quyền hợp lý cho AI**: Với các phần không chắc chắn, bạn có thể nói "dùng phương án thông thường"

---

**🎯 Giờ đây bạn đã sở hữu một trợ lý phát triển AI thực sự thông minh, nó sẽ ghi nhớ từng chi tiết và hướng dẫn bạn hoàn thành phân tích yêu cầu toàn diện!**

## 💬 Nhóm trao đổi

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="交流群">
<br>
Nhóm trao đổi
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---