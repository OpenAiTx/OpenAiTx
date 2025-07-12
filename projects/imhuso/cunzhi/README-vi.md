#寸止 🛑

> **AI Đối thoại "xuất tinh sớm" chấm dứt, để trao đổi kéo dài đến cùng**

Bạn vẫn còn phát điên vì trợ lý AI luôn kết thúc đối thoại quá sớm? Rõ ràng còn rất nhiều điều muốn trao đổi, mà nó lại hỏi "Bạn còn cần giúp gì nữa không?" **寸止** chuyên trị căn bệnh này!

Khi AI muốn "làm cho xong chuyện",寸止 sẽ kịp thời bật hộp thoại, giúp bạn tiếp tục trao đổi sâu hơn, cho đến khi vấn đề thực sự được giải quyết.

## 🌟 Tính năng cốt lõi

- 🛑 **Chặn thông minh**: Tự động bật tuỳ chọn tiếp tục khi AI muốn kết thúc
- 🧠 **Quản lý ghi nhớ**: Lưu trữ quy chuẩn phát triển và sở thích theo dự án
- 🎨 **Tương tác tinh tế**: Hỗ trợ Markdown, nhiều phương thức nhập liệu
- ⚡ **Cài đặt tức thì**: Cài đặt trong 3 giây, hỗ trợ đa nền tảng

## 📸 Xem hiệu quả

### 🛑 Cửa sổ chặn thông minh bật lên
![寸止弹窗演示](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*Khi AI muốn kết thúc đối thoại, cửa sổ thông minh của寸止 sẽ kịp thời xuất hiện, cung cấp các tuỳ chọn định sẵn để bạn lựa chọn nhanh chóng, giúp trao đổi tiếp tục sâu hơn*
### ⚙️ Giao diện quản lý cài đặt
![寸止设置界面](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*Giao diện cài đặt tinh tế, hỗ trợ quản lý bộ nhớ, chuyển đổi chức năng, thay đổi chủ đề và tạo gợi ý thông minh*

## 🚀 Bắt đầu sử dụng

### Cách 1: Cài đặt nhanh (khuyến nghị)

**Người dùng macOS:**
```bash
# Cài đặt trong 3 giây, không cần chờ biên dịch
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **Khắc phục sự cố**: Nếu gặp lỗi tải về 404, vui lòng thực hiện các bước sau:
>
> ```bash
> # Xóa bộ nhớ cache tap cũ
> brew untap imhuso/cunzhi
> # Cài đặt lại
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **Ví dụ lỗi thường gặp:**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> Nguyên nhân thường do vấn đề cache phiên bản cũ khiến số phiên bản không khớp. Chỉ cần xóa tap và cài đặt lại là được.

**Người dùng Windows/Linux:**
Khuyến nghị sử dụng cách 2 để tải về thủ công, đơn giản và nhanh chóng!
### 方式二：手 động tải về

1. Truy cập [trang Releases](https://github.com/imhuso/cunzhi/releases)
2. Tải về phiên bản phù hợp với hệ thống của bạn:
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. Sau khi giải nén, thêm `寸止` và `等一下` vào biến PATH của hệ thống

## ⚡ Bắt đầu nhanh

### Bước 1: Cấu hình máy khách MCP

Thêm vào tệp cấu hình của máy khách MCP của bạn (ví dụ như Claude Desktop):

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### Bước 2: Mở giao diện cài đặt

```bash
# Chạy lệnh cài đặt
Đợi một chút
```

### Bước 3: Cấu hình Prompt

Trong tab "Prompt tham khảo" của giao diện cài đặt:
1. Xem các prompt được tự động tạo ra
2. Nhấn nút sao chép
3. Thêm prompt vào trợ lý AI của bạn

### Bước 4: Bắt đầu sử dụng

Bây giờ trợ lý AI của bạn đã sở hữu các chức năng chặn thông minh, quản lý bộ nhớ và tương tác cửa sổ bật lên!

> 💡 **Mẹo nhỏ**: Bạn có thể tham khảo prompt được tạo ra để tùy chỉnh cá nhân, tạo nên trải nghiệm tương tác AI riêng biệt.
## 🤝 Tham gia đóng góp

寸止 là một dự án mã nguồn mở, chúng tôi hoan nghênh mọi hình thức đóng góp!

### 🐛 Phát hiện vấn đề?
- [Gửi Issue](https://github.com/imhuso/cunzhi/issues) để mô tả vấn đề
- Cung cấp các bước tái hiện và thông tin môi trường

### 💡 Có ý tưởng hay?
- [Tạo thảo luận](https://github.com/imhuso/cunzhi/discussions) để chia sẻ ý tưởng của bạn
- Gửi Pull Request để triển khai tính năng mới

### 🛠️ Phát triển cục bộ
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 Liên hệ với chúng tôi

- 🐛 **Phản hồi vấn đề**：[GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **Thảo luận tính năng**：[GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **Yêu thích dự án**：Hãy cho chúng tôi một Star để ủng hộ!

## 📄 Giấy phép mã nguồn mở

MIT License - Sử dụng tự do, hoan nghênh đóng góp!

---

<div align="center">

**Nói lời tạm biệt với hiện tượng "xuất tinh sớm" trong đối thoại AI | Để mỗi lần giao tiếp đều kéo dài đến cuối cùng**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 Báo cáo lỗi](https://github.com/imhuso/cunzhi/issues) · [💡 Yêu cầu tính năng](https://github.com/imhuso/cunzhi/discussions)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---