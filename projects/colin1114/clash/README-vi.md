
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

Dự án này được tài trợ tăng tốc CDN và bảo vệ an ninh bởi Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

Tác giả của dự án này là colin1114.

# 🚀 Clash Bộ chuyển đổi đăng ký

Một công cụ trực tuyến đẹp mắt và mạnh mẽ, dùng để chuyển đổi các liên kết đăng ký proxy khác nhau sang định dạng cấu hình Clash. Hỗ trợ triển khai tự động qua Cloudflare Workers & Pages, cung cấp dịch vụ chuyển đổi đăng ký nhanh chóng, đáng tin cậy.

## ✨ Đặc điểm tính năng

- 🎨 **Giao diện hiện đại đẹp mắt** - Sử dụng nền chuyển màu và thiết kế dạng thẻ
- 🔄 **Hỗ trợ đa giao thức** - Hỗ trợ các giao thức phổ biến như V2Ray, VLESS, Shadowsocks, Trojan
- ☁️ **Triển khai trên đám mây** - Tăng tốc CDN toàn cầu thông qua Cloudflare Workers
- 📱 **Thiết kế đáp ứng** - Tương thích hoàn hảo với máy tính và thiết bị di động
- ⚡ **Chuyển đổi nhanh** - Chuyển đổi liên kết đăng ký thành cấu hình Clash theo thời gian thực
- 📋 **Sao chép thông minh** - Hỗ trợ sao chép cấu hình YAML chỉ với một cú nhấp chuột, tương thích với mọi trình duyệt
- 📡 **Tạo liên kết đăng ký** - Tự động tạo liên kết đăng ký có thể nhập trực tiếp vào Clash
- 🌐 **Truy cập YAML trực tuyến** - Cung cấp nhiều cách truy cập file YAML:
  - 📡 Liên kết đăng ký: Hỗ trợ cập nhật tự động cho ứng dụng Clash
  - 🔗 Xem trực tuyến: Xem nội dung cấu hình trực tiếp trên trình duyệt
  - 💾 Tải xuống file: Tải file .yaml về máy tính
  - ⚡ Truy cập nhanh: Liên kết tải về đơn giản hóa
- 🔧 **Hỗ trợ UTF-8** - Hỗ trợ hoàn hảo tên nút và cấu hình tiếng Trung
- 🆓 **Hoàn toàn miễn phí** - Dựa trên dịch vụ miễn phí của Cloudflare, không giới hạn sử dụng

## 📁 Cấu trúc dự án

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 Bắt đầu nhanh

### Phương pháp 1: Chạy cục bộ

1. **Clone dự án**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Khởi động máy chủ cục bộ**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Truy cập ứng dụng**
   - Mở trình duyệt và truy cập `http://localhost:8000`
   - Trong môi trường cục bộ sẽ hiển thị cấu hình mẫu

### Phương pháp 2: Triển khai bằng Cloudflare Workers

#### Bước 1: Tạo Worker

1. Truy cập [Cloudflare Workers](https://workers.cloudflare.com/)
2. Đăng ký/đăng nhập tài khoản Cloudflare
3. Nhấn "Create a Worker"
4. Sao chép toàn bộ mã trong `worker.js` vào trình soạn thảo
5. Nhấn "Save and Deploy"

#### Bước 2: Triển khai bằng Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Bước 3: Cấu hình tên miền (tùy chọn)

1. Thêm tên miền tùy chỉnh trong phần cài đặt Worker
2. Hoặc sử dụng tên miền mặc định do Cloudflare cung cấp

### Phương pháp 3: Triển khai bằng Cloudflare Pages

#### Tùy chọn A: Tích hợp với GitHub (khuyến nghị)

1. **Chuẩn bị kho mã**
   - Đẩy mã lên kho GitHub
   - Đảm bảo bao gồm tất cả các tệp cần thiết

2. **Tạo dự án Pages**
   - Truy cập [Cloudflare Pages](https://pages.cloudflare.com/)
   - Kết nối kho GitHub của bạn
   - Chọn kho dự án

3. **Cài đặt xây dựng**
   - Lệnh xây dựng: Để trống hoặc `echo "No build required"`
   - Thư mục đầu ra xây dựng: `/` (thư mục gốc)
   - Biến môi trường: Không cần thiết lập

#### Tùy chọn B: Tải lên trực tiếp

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Kiến trúc kỹ thuật

### Ngăn xếp công nghệ Frontend
- **HTML5** - Ngôn ngữ đánh dấu hiện đại
- **CSS3** - Thiết kế đáp ứng và hiệu ứng hoạt hình
- **Vanilla JavaScript** - Tương tác front-end nhẹ

### Ngăn xếp công nghệ Backend
- **Cloudflare Workers** - Nền tảng điện toán biên
- **Web APIs** - Fetch API tiêu chuẩn và xử lý phản hồi

### Định dạng giao thức hỗ trợ
- **VMess** - Giao thức tiêu chuẩn V2Ray
- **VLESS** - Giao thức nhẹ V2Ray (hỗ trợ Reality)
- **Shadowsocks** - Giao thức proxy kinh điển
- **Trojan** - Giao thức proxy mới nổi

### API Endpoint
- `GET /` - Trang chính
- `POST /convert` - API chuyển đổi đăng ký
- `GET /clash/{config-id}` - Lấy file cấu hình YAML (link đăng ký)
- `GET /yaml/{config-id}` - Tải file cấu hình YAML
- `OPTIONS /*` - Yêu cầu kiểm tra trước CORS

## 📖 Hướng dẫn sử dụng

### Sử dụng cơ bản

1. **Nhập liên kết đăng ký**
   - Dán liên kết đăng ký proxy của bạn vào ô nhập
   - Hỗ trợ liên kết đăng ký mã hóa Base64

2. **Thiết lập tên cấu hình**
   - Tùy chọn đặt tên tùy chỉnh cho file cấu hình
   - Mặc định là "My Clash Config"

3. **Chuyển đổi cấu hình**
   - Nhấn nút "Chuyển đổi đăng ký"
   - Chờ chuyển đổi hoàn tất
4. **Sử dụng cấu hình**
   - Sao chép cấu hình YAML đã tạo
   - Nhập vào ứng dụng Clash để sử dụng

5. **Sử dụng liên kết đăng ký (khuyến nghị)**
   - Sao chép liên kết đăng ký đã tạo
   - Thêm liên kết đăng ký vào ứng dụng Clash
   - Cấu hình sẽ tự động đồng bộ, không cần cập nhật thủ công

### Cấu hình nâng cao

Cấu hình Clash được tạo ra bao gồm các tính năng sau:

- **Chính sách nhóm proxy**
  - 🚀 Chọn nút - Tự chọn proxy
  - ♻️ Chọn tự động - Kiểm tra độ trễ và chọn tự động
  - 🎯 Kết nối trực tiếp toàn cầu - Kết nối trực tiếp

- **Cấu hình DNS**
  - Bật phân giải DNS
  - Hỗ trợ chế độ fake-ip
  - Phân luồng DNS trong nước và quốc tế

- **Quy tắc định tuyến**
  - Địa chỉ nội bộ kết nối trực tiếp
  - IP trong nước kết nối trực tiếp
  - Lưu lượng khác đi qua proxy

## 🔧 Xử lý sự cố triển khai

### Vấn đề thường gặp

#### 1. Wrangler không tìm thấy điểm vào
**Thông báo lỗi**: `Missing entry-point to Worker script`

**Giải pháp**: 
- Đảm bảo thư mục gốc dự án có file `wrangler.jsonc`
- Kiểm tra trường `main` trong `wrangler.jsonc` trỏ đến `worker.js`


#### 2. GitHub Actions triển khai thất bại
**Giải pháp**:
- Thêm các Secrets sau trong cài đặt kho GitHub:
  - `CLOUDFLARE_API_TOKEN`: Mã thông báo API Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: ID tài khoản Cloudflare

#### 3. Pages xây dựng thất bại
**Giải pháp**:
- Đặt lệnh xây dựng thành rỗng hoặc `echo "No build required"`
- Đảm bảo thư mục đầu ra xây dựng được đặt thành `/`

### Giải thích về tập tin cấu hình triển khai

- **`wrangler.jsonc`**: Cấu hình CLI Wrangler, dùng để triển khai Worker
- **`_headers`**: Cấu hình HTTP header cho Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Cấu hình tự động triển khai của GitHub Actions

## 🔧 Cấu hình tùy chỉnh

### Chỉnh sửa nhóm proxy

Có thể chỉnh sửa hàm `convertToClash` trong `worker.js` để tùy chỉnh nhóm proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### Quy tắc định tuyến tùy chỉnh

Chỉnh sửa mảng `rules` để thêm quy tắc định tuyến tùy chỉnh:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Đặc tính hiệu năng

- **CDN toàn cầu** - Cloudflare với các node biên phủ sóng toàn thế giới
- **Phản hồi nhanh** - Thời gian phản hồi trung bình < 100ms
- **Tính sẵn sàng cao** - Dịch vụ khả dụng 99.9%
- **Miễn phí giới hạn** - 100.000 yêu cầu mỗi ngày

## 🔒 Hướng dẫn bảo mật

- **Bảo mật dữ liệu** - Dữ liệu đăng ký chỉ được sử dụng trong quá trình chuyển đổi, không lưu trữ
- **Mã hóa HTTPS** - Mọi giao tiếp đều được mã hóa qua HTTPS
- **Mã nguồn mở minh bạch** - Toàn bộ mã nguồn công khai, có thể tự kiểm tra

## 🤝 Hướng dẫn đóng góp

Hoan nghênh gửi Issue và Pull Request!

1. Fork kho lưu trữ này
2. Tạo nhánh tính năng (`git checkout -b feature/AmazingFeature`)
3. Cam kết thay đổi (`git commit -m 'Add some AmazingFeature'`)
4. Đẩy lên nhánh (`git push origin feature/AmazingFeature`)
5. Tạo Pull Request

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
- ✅ Chức năng sao chép một lần nhấn

## 📞 Hỗ trợ và phản hồi

Nếu bạn gặp vấn đề hoặc có đề xuất trong quá trình sử dụng, vui lòng:

1. Xem tài liệu README này
2. Gửi [Issue](../../issues)
3. Khởi động [Discussion](../../discussions)

## 📄 Giấy phép

Dự án này sử dụng giấy phép MIT - xem chi tiết trong tệp [LICENSE](LICENSE)

## 🙏 Lời cảm ơn

- [Cloudflare Workers](https://workers.cloudflare.com/) - Cung cấp nền tảng điện toán biên
- [Clash](https://github.com/Dreamacro/clash) - Ứng dụng proxy xuất sắc
- Cảm ơn sự hỗ trợ của tất cả các cộng tác viên và người dùng

---

⭐ Nếu dự án này hữu ích với bạn, hãy cho nó một Star! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---