# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

Kho lưu trữ này chứa Gemini CLI, một công cụ dòng lệnh AI giúp kết nối với các công cụ của bạn, hiểu mã nguồn và tăng tốc các quy trình làm việc của bạn.

Với Gemini CLI, bạn có thể:

- Truy vấn và chỉnh sửa các bộ mã nguồn lớn trong và ngoài cửa sổ ngữ cảnh 1M token của Gemini.
- Tạo ứng dụng mới từ PDF hoặc bản phác thảo, sử dụng khả năng đa phương thức của Gemini.
- Tự động hóa các tác vụ vận hành, như truy vấn pull request hoặc xử lý các lần rebase phức tạp.
- Sử dụng các công cụ và máy chủ MCP để kết nối các khả năng mới, bao gồm [tạo phương tiện với Imagen, Veo hoặc Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)
- Định hướng truy vấn của bạn với [Google Search](https://ai.google.dev/gemini-api/docs/grounding), công cụ này được tích hợp sẵn trong Gemini.

## Bắt đầu nhanh

1. **Yêu cầu:** Đảm bảo bạn đã cài đặt [Node.js phiên bản 18](https://nodejs.org/en/download) hoặc mới hơn.
2. **Chạy CLI:** Thực thi lệnh sau trong terminal của bạn:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   Hoặc cài đặt với:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **Chọn chủ đề màu sắc**
4. **Xác thực:** Khi được yêu cầu, hãy đăng nhập bằng tài khoản Google cá nhân của bạn. Điều này sẽ cho phép bạn thực hiện tối đa 60 yêu cầu mô hình mỗi phút và 1.000 yêu cầu mô hình mỗi ngày với Gemini.

Bạn đã sẵn sàng sử dụng Gemini CLI!

### Đối với người dùng nâng cao hoặc cần tăng giới hạn:

Nếu bạn cần sử dụng một mô hình cụ thể hoặc yêu cầu dung lượng yêu cầu cao hơn, bạn có thể sử dụng khóa API:

1. Tạo khóa từ [Google AI Studio](https://aistudio.google.com/apikey).
2. Thiết lập nó làm biến môi trường trong terminal của bạn. Thay `YOUR_API_KEY` bằng khóa bạn đã tạo.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Để biết thêm phương pháp xác thực khác, bao gồm tài khoản Google Workspace, xem hướng dẫn [xác thực](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md).

## Ví dụ

Khi CLI đang chạy, bạn có thể bắt đầu tương tác với Gemini từ shell của mình.

Bạn có thể bắt đầu một dự án từ một thư mục mới:

```sh
cd new-project/
gemini
> Viết cho tôi một bot Gemini Discord trả lời các câu hỏi bằng file FAQ.md mà tôi sẽ cung cấp
```

Hoặc làm việc với một dự án hiện có:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Cho tôi bản tóm tắt tất cả các thay đổi đã được thực hiện vào ngày hôm qua
```

### Các bước tiếp theo

- Tìm hiểu cách [đóng góp hoặc build từ mã nguồn](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- Khám phá các **[Lệnh CLI](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**.
- Nếu bạn gặp bất kỳ sự cố nào, hãy xem **[hướng dẫn khắc phục sự cố](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**.
- Để tham khảo tài liệu đầy đủ, xem [tài liệu đầy đủ](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md).
- Tham khảo một số [tác vụ phổ biến](#popular-tasks) để lấy cảm hứng thêm.

### Khắc phục sự cố

Truy cập [hướng dẫn khắc phục sự cố](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) nếu bạn đang gặp vấn đề.

## Các tác vụ phổ biến

### Khám phá một mã nguồn mới

Bắt đầu bằng cách `cd` vào kho lưu trữ hiện có hoặc vừa clone và chạy `gemini`.

```text
> Mô tả các thành phần chính của kiến trúc hệ thống này.
```

```text
> Những cơ chế bảo mật nào đang được áp dụng?
```

### Làm việc với mã nguồn hiện tại của bạn

```text
> Triển khai bản nháp đầu tiên cho issue GitHub #123.
```

```text
> Giúp tôi chuyển đổi bộ mã nguồn này sang phiên bản Java mới nhất. Hãy bắt đầu với một kế hoạch.
```

### Tự động hóa quy trình làm việc

Sử dụng máy chủ MCP để tích hợp các công cụ hệ thống cục bộ với bộ công cụ cộng tác doanh nghiệp của bạn.

```text
> Tạo cho tôi một slide deck hiển thị lịch sử git trong 7 ngày qua, được nhóm theo tính năng và thành viên nhóm.
```

```text
> Tạo một ứng dụng web toàn màn hình cho màn hình tường để hiển thị các issue GitHub được tương tác nhiều nhất của chúng tôi.
```

### Tương tác với hệ thống của bạn

```text
> Chuyển đổi tất cả hình ảnh trong thư mục này sang png, và đổi tên chúng theo ngày từ dữ liệu exif.
```

```text
> Sắp xếp hóa đơn PDF của tôi theo tháng chi tiêu.
```

## Điều khoản dịch vụ và Thông báo quyền riêng tư

Để biết chi tiết về điều khoản dịch vụ và thông báo quyền riêng tư áp dụng cho việc sử dụng Gemini CLI, hãy xem [Điều khoản dịch vụ và Thông báo quyền riêng tư](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---