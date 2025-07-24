# Đặc Tả Giao Thức Gọi Công Cụ Toàn Cầu (UTCP)

Kho lưu trữ này chứa tài liệu đặc tả chính thức cho Giao Thức Gọi Công Cụ Toàn Cầu (UTCP). UTCP là một tiêu chuẩn hiện đại, linh hoạt và có khả năng mở rộng để định nghĩa và tương tác với các công cụ trên nhiều giao thức truyền thông khác nhau.

## UTCP là gì?

UTCP cung cấp một phương thức chuẩn hóa để các hệ thống AI và các khách hàng khác có thể phát hiện và gọi các công cụ từ nhiều nhà cung cấp khác nhau, bất kể giao thức nền tảng được sử dụng (HTTP, WebSocket, CLI, v.v.). Tài liệu đặc tả này định nghĩa:

- Cơ chế phát hiện công cụ
- Định dạng gọi công cụ
- Cấu hình nhà cung cấp
- Phương thức xác thực
- Xử lý phản hồi

## Đóng góp vào Đặc tả

Chúng tôi hoan nghênh mọi đóng góp cho đặc tả UTCP! Đây là cách bạn có thể đóng góp:

1. **Fork kho lưu trữ**: Tạo một bản fork kho lưu trữ đặc tả của riêng bạn
2. **Thực hiện thay đổi**: Cập nhật hoặc bổ sung tài liệu khi cần thiết
3. **Gửi pull request**: Mở một PR với các thay đổi của bạn để được xem xét
4. **Tham gia thảo luận**: Tham gia trao đổi về các thay đổi được đề xuất

Khi đóng góp, vui lòng tuân thủ các hướng dẫn sau:

- Đảm bảo các thay đổi của bạn phù hợp với tầm nhìn và mục tiêu chung của UTCP
- Tuân thủ cấu trúc và định dạng tài liệu đã thiết lập
- Bao gồm ví dụ khi bổ sung tính năng hoặc khái niệm mới
- Cập nhật các phần liên quan để duy trì tính nhất quán cho toàn bộ tài liệu

## Xây dựng Tài liệu Tại chỗ

### Yêu cầu tiên quyết

Để xây dựng và xem trước trang tài liệu tại chỗ, bạn cần:

- Ruby phiên bản 2.5.0 trở lên
- RubyGems
- Bundler

### Thiết lập

1. Sao chép kho lưu trữ:
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. Cài đặt các phụ thuộc:

   ```bash
   bundle install
   ```
### Chạy Trang Tài Liệu

Để xây dựng và phục vụ trang web tại máy cục bộ:


```bash
bundle exec jekyll serve
```
Điều này sẽ khởi động một máy chủ web cục bộ tại `http://localhost:4000` nơi bạn có thể xem trước tài liệu.

## Cấu trúc Tài liệu

Tài liệu UTCP được tổ chức như sau:

- `index.md`: Trang chủ và giới thiệu về UTCP
- `docs/`
  - `introduction.md`: Giới thiệu chi tiết và các khái niệm cốt lõi
  - `for-tool-providers.md`: Hướng dẫn triển khai nhà cung cấp công cụ
  - `for-tool-callers.md`: Hướng dẫn triển khai bên gọi công cụ
  - `providers/`: Tài liệu cho từng loại nhà cung cấp
    - `http.md`: Nhà cung cấp HTTP
    - `websocket.md`: Nhà cung cấp WebSocket
    - `cli.md`: Nhà cung cấp CLI
    - `sse.md`: Nhà cung cấp Server-Sent Events
    - v.v.
  - `implementation.md`: Hướng dẫn triển khai và thực tiễn tốt nhất

## Làm việc với Đặc tả

### Chỉnh sửa Tài liệu

Tài liệu được viết ở định dạng Markdown với phần đầu Jekyll. Khi thực hiện thay đổi:

1. Đảm bảo file Markdown của bạn tuân theo phong cách đã thiết lập
2. Xem trước các thay đổi cục bộ trước khi gửi PR
3. Giữ các ví dụ được cập nhật theo đặc tả mới nhất
4. Cập nhật các mục điều hướng trong `_config.yml` nếu thêm trang mới

### Tổ chức File

Khi thêm tài liệu mới:

- Đặt tài liệu riêng cho từng nhà cung cấp vào `docs/providers/`
- Sử dụng phần đầu nhất quán với thứ tự điều hướng phù hợp
- Bao gồm các thẻ để cải thiện khả năng tìm kiếm trên GitHub Pages

## Kiểm soát Phiên bản

Đặc tả UTCP tuân theo phiên bản hóa ngữ nghĩa:

- Phiên bản lớn (1.0, 2.0): Các thay đổi phá vỡ tương thích giao thức
- Phiên bản nhỏ (1.1, 1.2): Thêm tính năng mới tương thích ngược
- Phiên bản vá (1.0.1, 1.0.2): Sửa lỗi và làm rõ tương thích ngược

## Giấy phép

Đặc tả này được phân phối theo Giấy phép Công cộng Mozilla 2.0 (MPL-2.0).

## Tài nguyên Bổ sung

- [Tổ chức UTCP trên GitHub](https://github.com/universal-tool-calling-protocol)
- [Trang web UTCP](https://utcp.io)
- [Các triển khai tham khảo](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Thảo luận cộng đồng](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---