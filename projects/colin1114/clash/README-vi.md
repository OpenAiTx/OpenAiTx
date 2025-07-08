CDN tăng tốc và bảo vệ an ninh cho dự án này được tài trợ bởi Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

Tác giả của dự án này là colin1114.

# 🚀 Clash 订阅转换器

Một công cụ trực tuyến đẹp mắt và mạnh mẽ, dùng để chuyển đổi các liên kết đăng ký proxy khác nhau sang định dạng cấu hình Clash. Hỗ trợ tự động triển khai qua Cloudflare Workers & Pages, cung cấp dịch vụ chuyển đổi đăng ký nhanh chóng, đáng tin cậy.

## ✨ Tính năng

- 🎨 **Giao diện hiện đại đẹp mắt** - Sử dụng nền chuyển màu và thiết kế dạng thẻ
- 🔄 **Hỗ trợ đa giao thức** - Hỗ trợ các giao thức phổ biến như V2Ray, VLESS, Shadowsocks, Trojan, v.v.
- ☁️ **Triển khai trên đám mây** - Thực hiện tăng tốc CDN toàn cầu qua Cloudflare Workers
- 📱 **Thiết kế đáp ứng** - Tương thích hoàn hảo với cả máy tính để bàn và thiết bị di động
- ⚡ **Chuyển đổi nhanh chóng** - Chuyển đổi liên kết đăng ký thành cấu hình Clash theo thời gian thực
- 📋 **Sao chép thông minh** - Hỗ trợ sao chép cấu hình YAML đã tạo chỉ với một cú nhấp, tương thích nhiều trình duyệt
- 📡 **Tạo liên kết đăng ký** - Tự động tạo liên kết đăng ký có thể nhập trực tiếp vào Clash
- 🌐 **Truy cập YAML trực tuyến** - Cung cấp nhiều phương thức truy cập file YAML:
  - 📡 Liên kết đăng ký: Hỗ trợ Clash client tự động cập nhật
  - 🔗 Xem trực tuyến: Xem trực tiếp nội dung cấu hình trên trình duyệt
  - 💾 Tải file: Tải file .yaml về máy
  - ⚡ Truy cập nhanh: Liên kết tải xuống rút gọn
- 🔧 **Hỗ trợ UTF-8** - Hỗ trợ hoàn hảo tên node và cấu hình tiếng Trung
- 🆓 **Hoàn toàn miễn phí** - Dựa trên dịch vụ miễn phí của Cloudflare, không giới hạn sử dụng

## 📁 Cấu trúc dự án

```
clash/
├── index.html              # Trang giao diện phía trước
├── worker.js               # Mã nguồn backend Cloudflare Worker
├── wrangler.jsonc          # File cấu hình Wrangler
├── _headers                # Cấu hình HTTP header cho Cloudflare Pages
├── .github/
│   └── workflows/
│       └── deploy.yml      # Cấu hình triển khai GitHub Actions
├── README.md              # Tài liệu hướng dẫn dự án
└── package.json           # File cấu hình dự án
```

## 🚀 Bắt đầu nhanh

### Cách 1: Chạy tại máy cục bộ

1. **Clone dự án**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Khởi động máy chủ cục bộ**
   ```bash
   # Dùng Python
   python -m http.server 8000
   
   # Hoặc dùng Node.js
   npx serve .
   ```

3. **Truy cập ứng dụng**
   - Mở trình duyệt và truy cập `http://localhost:8000`
   - Sẽ hiển thị cấu hình mẫu trong môi trường cục bộ

### Cách 2: Triển khai trên Cloudflare Workers

#### Bước 1: Tạo Worker

1. Truy cập [Cloudflare Workers](https://workers.cloudflare.com/)
2. Đăng ký/đăng nhập tài khoản Cloudflare
3. Nhấn "Create a Worker"
4. Sao chép toàn bộ mã trong `worker.js` vào trình chỉnh sửa
5. Nhấn "Save and Deploy"

#### Bước 2: Triển khai bằng Wrangler CLI

```bash
# Cài đặt Wrangler CLI
npm install -g wrangler

# Đăng nhập Cloudflare
wrangler login

# Triển khai Worker
npm run deploy:worker
```

#### Bước 3: Cấu hình tên miền (tùy chọn)

1. Thêm tên miền tùy chỉnh trong phần cài đặt Worker
2. Hoặc sử dụng tên miền mặc định do Cloudflare cung cấp

### Cách 3: Triển khai trên Cloudflare Pages

#### Lựa chọn A: Tích hợp GitHub (khuyến nghị)

1. **Chuẩn bị kho mã**
   - Đẩy mã nguồn lên kho GitHub
   - Đảm bảo bao gồm đầy đủ các tệp cần thiết
2. **Tạo dự án Pages**
   - Truy cập [Cloudflare Pages](https://pages.cloudflare.com/)
   - Kết nối kho lưu trữ GitHub của bạn
   - Chọn kho lưu trữ dự án

3. **Cài đặt xây dựng**
   - Lệnh xây dựng: Để trống hoặc `echo "No build required"`
   - Thư mục đầu ra xây dựng: `/` (thư mục gốc)
   - Biến môi trường: Không cần thiết lập

#### Lựa chọn B: Tải lên trực tiếp

```bash
# Triển khai bằng Wrangler Pages
npm run deploy:pages
```

## 🛠️ Kiến trúc kỹ thuật

### Ngăn xếp công nghệ Frontend
- **HTML5** - Ngôn ngữ đánh dấu hiện đại
- **CSS3** - Thiết kế đáp ứng và hiệu ứng động
- **Vanilla JavaScript** - Tương tác frontend nhẹ

### Ngăn xếp công nghệ Backend
- **Cloudflare Workers** - Nền tảng điện toán biên
- **Web APIs** - Chuẩn Fetch API và xử lý phản hồi

### Định dạng giao thức hỗ trợ
- **VMess** - Giao thức tiêu chuẩn V2Ray
- **VLESS** - Giao thức nhẹ V2Ray (hỗ trợ Reality)
- **Shadowsocks** - Giao thức proxy kinh điển
- **Trojan** - Giao thức proxy mới nổi

### Các endpoint API
- `GET /` - Trang chính
- `POST /convert` - API chuyển đổi đăng ký
- `GET /clash/{config-id}` - Lấy file cấu hình YAML (liên kết đăng ký)
- `GET /yaml/{config-id}` - Tải về file cấu hình YAML
- `OPTIONS /*` - Yêu cầu kiểm tra trước CORS

## 📖 Hướng dẫn sử dụng

### Sử dụng cơ bản

1. **Nhập liên kết đăng ký**
   - Dán liên kết đăng ký proxy của bạn vào ô nhập
   - Hỗ trợ liên kết đăng ký mã hóa Base64

2. **Đặt tên cấu hình**
   - Tùy chọn đặt tên tùy chỉnh cho file cấu hình
   - Mặc định là "My Clash Config"

3. **Chuyển đổi cấu hình**
   - Nhấn nút "Chuyển đổi đăng ký"
   - Chờ quá trình chuyển đổi hoàn tất

4. **Sử dụng cấu hình**
   - Sao chép file cấu hình YAML đã tạo
   - Nhập vào ứng dụng Clash để sử dụng

5. **Sử dụng liên kết đăng ký (khuyến nghị)**
   - Sao chép liên kết đăng ký đã tạo
   - Thêm vào ứng dụng Clash dưới dạng đăng ký
   - Cấu hình sẽ tự động đồng bộ, không cần cập nhật thủ công

### Cấu hình nâng cao

File cấu hình Clash được tạo ra có các đặc điểm sau:

- **Chính sách nhóm proxy**
  - 🚀 Chọn nút - Chọn proxy thủ công
  - ♻️ Tự động chọn - Kiểm tra độ trễ tự động chọn
  - 🎯 Kết nối trực tiếp toàn cầu - Kết nối trực tiếp

- **Cấu hình DNS**
  - Bật phân giải DNS
  - Hỗ trợ chế độ fake-ip
  - Phân luồng DNS trong nước và quốc tế

- **Quy tắc định tuyến**
  - Địa chỉ nội bộ kết nối trực tiếp
  - IP trong nước kết nối trực tiếp
  - Các lưu lượng khác đi qua proxy

## 🔧 Khắc phục sự cố triển khai

### Các vấn đề phổ biến

#### 1. Wrangler không tìm thấy điểm bắt đầu
**Thông báo lỗi**: `Missing entry-point to Worker script`

**Giải pháp**: 
- Đảm bảo thư mục gốc dự án có file `wrangler.jsonc`
- Kiểm tra trường `main` trong `wrangler.jsonc` trỏ đến `worker.js`

#### 2. Triển khai GitHub Actions thất bại
**Giải pháp**:
- Thêm các Secrets sau trong phần thiết lập kho lưu trữ GitHub:
  - `CLOUDFLARE_API_TOKEN`: Mã API Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: ID Tài khoản Cloudflare

#### 3. Xây dựng Pages thất bại
**Giải pháp**:
- Đặt lệnh xây dựng thành rỗng hoặc `echo "No build required"`
- Đảm bảo thư mục xuất ra của quá trình xây dựng được đặt là `/`

### Giải thích tệp cấu hình triển khai

- **`wrangler.jsonc`**: Cấu hình Wrangler CLI, dùng để triển khai Worker
- **`_headers`**: Cấu hình HTTP header cho Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Cấu hình tự động triển khai với GitHub Actions

## 🔧 Cấu hình tùy chỉnh

### Sửa đổi nhóm proxy

Có thể chỉnh sửa hàm `convertToClash` trong `worker.js` để tùy chỉnh nhóm proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 Lựa chọn nút',
    type: 'select',
    proxies: ['♻️ Tự động chọn', '🎯 Kết nối trực tiếp toàn cầu', ...proxyNames]
  },
  // Thêm nhiều nhóm proxy khác...
]
```

### Tùy chỉnh quy tắc định tuyến

Chỉnh sửa mảng `rules` để thêm các quy tắc định tuyến tùy chỉnh:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 Lựa chọn nút',
  'DOMAIN-SUFFIX,local,DIRECT',
  // Thêm nhiều quy tắc khác...
]
```

## 📊 Tính năng hiệu năng

- **CDN toàn cầu** - Cloudflare với các điểm biên trên toàn thế giới
- **Phản hồi nhanh** - Thời gian phản hồi trung bình < 100ms
- **Độ sẵn sàng cao** - 99.9% thời gian hoạt động dịch vụ
- **Miễn phí hạn mức** - 100.000 yêu cầu mỗi ngày

## 🔒 Thông tin bảo mật

- **Bảo mật dữ liệu** - Dữ liệu đăng ký chỉ được sử dụng trong quá trình chuyển đổi, không lưu trữ
- **Mã hóa HTTPS** - Tất cả các giao tiếp đều được mã hóa qua HTTPS
- **Mã nguồn mở minh bạch** - Toàn bộ mã nguồn được công khai, có thể tự kiểm tra

## 🤝 Hướng dẫn đóng góp

Hoan nghênh gửi Issue và Pull Request!

1. Fork kho lưu trữ này
2. Tạo nhánh tính năng (`git checkout -b feature/AmazingFeature`)
3. Commit thay đổi (`git commit -m 'Add some AmazingFeature'`)
4. Push lên nhánh (`git push origin feature/AmazingFeature`)
5. Mở Pull Request

## 📝 Nhật ký cập nhật

### v1.1.0
- ✅ Thêm hỗ trợ giao thức VLESS (bao gồm truyền tải bảo mật Reality)
- ✅ Cải thiện khả năng tương thích giao thức

### v1.0.0
- ✅ Chức năng chuyển đổi đăng ký cơ bản
- ✅ Giao diện người dùng đẹp mắt
- ✅ Hỗ trợ Cloudflare Workers
- ✅ Hỗ trợ đa giao thức (VMess, Shadowsocks, Trojan)
- ✅ Thiết kế đáp ứng
- ✅ Chức năng sao chép một chạm

## 📞 Hỗ trợ & Phản hồi

Nếu bạn gặp vấn đề hoặc có đề xuất trong quá trình sử dụng, vui lòng:

1. Xem tài liệu README này
2. Gửi [Issue](../../issues)
3. Mở [Discussion](../../discussions)

## 📄 Giấy phép

Dự án này sử dụng giấy phép MIT - Xem chi tiết tại tệp [LICENSE](LICENSE)

## 🙏 Lời cảm ơn

- [Cloudflare Workers](https://workers.cloudflare.com/) - Nền tảng điện toán biên
- [Clash](https://github.com/Dreamacro/clash) - Ứng dụng proxy xuất sắc
- Cảm ơn tất cả các nhà đóng góp và người dùng đã ủng hộ

---
⭐ Nếu dự án này hữu ích đối với bạn, hãy cho nó một Star!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---