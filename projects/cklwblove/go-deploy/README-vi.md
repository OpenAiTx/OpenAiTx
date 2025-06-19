# Go-Deploy 部署工具

Một công cụ triển khai tự động hóa dựa trên ngôn ngữ Go, hỗ trợ tải lên sản phẩm build cục bộ lên máy chủ từ xa thông qua giao thức SFTP.

## Tính năng

- ✅ **Truyền tải an toàn**: Sử dụng giao thức SFTP, truyền tải mã hóa dựa trên SSH
- ✅ **Đồng bộ thư mục**: Tải lên toàn bộ cấu trúc thư mục một cách đệ quy, giữ nguyên phân cấp file
- ✅ **Tạo thông minh**: Tự động tạo cấu trúc thư mục trên máy chủ từ xa
- ✅ **Tự động thích ứng đường dẫn**: Tự động tính toán đường dẫn cục bộ dựa trên vị trí file thực thi, không cần quan tâm thư mục thực thi
- ✅ **Hỗ trợ file cấu hình**: Hỗ trợ file cấu hình JSON, thuận tiện quản lý cấu hình nhiều môi trường khác nhau
- ✅ **Loại trừ file**: Hỗ trợ mẫu ký tự đại diện để loại trừ file không cần tải lên
- ✅ **Tự động sao lưu**: Tự động sao lưu file trên máy chủ trước khi tải lên
- ✅ **Cơ chế thử lại**: Tự động thử lại khi tải lên thất bại, nâng cao tỷ lệ thành công
- ✅ **Thống kê chi tiết**: Hiển thị số lượng file tải lên, dung lượng truyền tải, thời gian và tốc độ
- ✅ **Hiển thị tiến trình**: Hiển thị tiến trình tải lên và thông tin file theo thời gian thực
- ✅ **Xử lý lỗi**: Xử lý lỗi hoàn thiện và xuất log

## Yêu cầu hệ thống

- Go 1.18 hoặc phiên bản cao hơn
- Máy chủ mục tiêu hỗ trợ giao thức SSH/SFTP

## Hướng dẫn cài đặt

### 1. Clone dự án

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Khởi tạo module Go

```bash
go mod init go-deploy
go mod tidy
```

### 3. Cài đặt phụ thuộc

Chương trình sẽ tự động tải về các phụ thuộc sau:

- `github.com/pkg/sftp` - Client SFTP
- `golang.org/x/crypto/ssh` - Client SSH

## Hướng dẫn cấu hình

Chương trình hỗ trợ hai cách cấu hình:

### 1. Sử dụng file cấu hình (Khuyến nghị)

Sao chép `config.example.json` thành `config.json` và sửa đổi cấu hình:

```bash
cp config.example.json config.json
```

Sau đó chỉnh sửa `config.json`:

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### Giải thích các trường cấu hình

**Cấu hình server**:

- `host`: Địa chỉ máy chủ SSH
- `port`: Cổng SSH, thường là 22
- `username`: Tên đăng nhập SSH
- `password`: Mật khẩu SSH (khuyến nghị sử dụng xác thực bằng khóa ở môi trường production)
- `timeout`: Thời gian chờ kết nối (giây)

**Cấu hình paths**:

- `local`: Đường dẫn thư mục cục bộ, hỗ trợ cả đường dẫn tương đối và tuyệt đối
- `remote`: Đường dẫn thư mục trên máy chủ, phải là đường dẫn tuyệt đối

**Cấu hình options**:

- `backup`: Có tạo bản sao lưu file đã tồn tại trên máy chủ trước khi tải lên hay không
- `backup_suffix`: Phần đuôi file sao lưu, có thể tự đặt, nếu file sao lưu không tồn tại sẽ bỏ qua
- `exclude_patterns`: Mẫu loại trừ file, hỗ trợ ký tự đại diện
- `max_retries`: Số lần thử lại tối đa khi tải lên thất bại
- `chunk_size`: Kích thước khối truyền tải (byte, hiện chưa hỗ trợ)

### 2. Cấu hình mặc định (Chế độ tương thích)

Nếu không có file `config.json`, chương trình sẽ sử dụng cấu hình mặc định tích hợp sẵn, đảm bảo tương thích ngược.

#### Ưu tiên file cấu hình

1. **File cấu hình chỉ định qua dòng lệnh**: File được chỉ định qua tham số `--config`
2. **File cấu hình mặc định**: `config.json` trong thư mục hiện tại
3. **Cấu hình mặc định tích hợp**: Nếu không có hai file trên, dùng cấu hình mặc định tích hợp sẵn trong chương trình

#### Quy tắc xử lý đường dẫn

- **Đường dẫn file cấu hình**:

  - Đường dẫn tương đối: Tính từ thư mục chứa file thực thi
  - Đường dẫn tuyệt đối: Dùng trực tiếp đường dẫn chỉ định
- **Đường dẫn thư mục cục bộ**:

  - Đường dẫn tương đối: Tính từ thư mục chứa file thực thi
  - Đường dẫn tuyệt đối: Dùng trực tiếp đường dẫn chỉ định

## Hướng dẫn chạy chương trình

### Tham số dòng lệnh

Chương trình hỗ trợ các tham số dòng lệnh sau:

```bash
# Hiển thị thông tin trợ giúp
./deploy --help

# Hiển thị thông tin phiên bản  
./deploy --version

# Sử dụng file cấu hình mặc định config.json
./deploy

# Sử dụng file cấu hình chỉ định
./deploy --config prod.json

# Sử dụng file cấu hình với đường dẫn tuyệt đối
./deploy --config /path/to/config.json
```

### Chạy trong môi trường phát triển

```bash
# Sử dụng cấu hình mặc định
go run main.go

# Sử dụng file cấu hình chỉ định
go run main.go --config test.json

# Hiển thị trợ giúp
go run main.go --help
```

### Chạy sau khi biên dịch

```bash
# Biên dịch
go build -o deploy main.go

# Chạy với cấu hình mặc định
./deploy

# Chạy với file cấu hình chỉ định
./deploy --config prod.json
```

## Hướng dẫn đóng gói

### 1. Đóng gói cho nền tảng hiện tại

```bash
# Biên dịch file thực thi cho nền tảng hiện tại
go build -o deploy main.go
```

### 2. Đóng gói đa nền tảng

#### Linux 64-bit

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64-bit
```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64位

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. Tối ưu hóa đóng gói (Giảm kích thước tệp)

```bash
# Loại bỏ thông tin gỡ lỗi và bảng ký hiệu
go build -ldflags="-s -w" -o deploy main.go

# Sử dụng UPX để nén (cần cài đặt UPX trước)
upx --best deploy
```

### 4. Script đóng gói hàng loạt

Tạo script `build.sh`:

```bash
#!/bin/bash

# Tạo thư mục build
mkdir -p builds

# Đóng gói phiên bản cho từng nền tảng
echo "Đang đóng gói bản Linux 64-bit..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Đang đóng gói bản Windows 64-bit..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "Đang đóng gói bản macOS 64-bit..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "Đang đóng gói bản macOS ARM64..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "Đóng gói hoàn tất!"
ls -la builds/
```

Chạy script:

```bash
chmod +x build.sh
./build.sh
```

## Ví dụ sử dụng

### Hiển thị thông tin trợ giúp

```bash
$ ./deploy --help
Go-Deploy Công cụ triển khai

Cách dùng: ./deploy [tùy chọn]

Tùy chọn:
  -config string
        Đường dẫn tệp cấu hình (default "config.json")
  -help
        Hiển thị thông tin trợ giúp
  -version
        Hiển thị thông tin phiên bản

Ví dụ:
  ./deploy                           # Sử dụng tệp cấu hình mặc định config.json
  ./deploy --config prod.json        # Sử dụng tệp cấu hình chỉ định
  ./deploy --config /path/to/config.json  # Sử dụng tệp cấu hình với đường dẫn tuyệt đối
```

### Sử dụng tệp cấu hình chỉ định

```bash
$ ./deploy --config prod.json
Bắt đầu thực thi chương trình triển khai...
Đang thử đọc tệp cấu hình: /path/to/go-deploy/prod.json
Đang sử dụng tệp cấu hình...
Thư mục cục bộ /path/to/project/dist tồn tại
Đang kết nối đến máy chủ SSH...
Kết nối máy chủ SSH thành công
...
```

### Sử dụng tệp cấu hình

```bash
$ ./deploy
Bắt đầu thực thi chương trình triển khai...
Đang thử đọc tệp cấu hình: /path/to/go-deploy/config.json
Đang sử dụng tệp cấu hình...
Thư mục cục bộ /path/to/project/unpackage/dist/build/web tồn tại
Đang kết nối đến máy chủ SSH...
Kết nối máy chủ SSH thành công
Đang tạo client SFTP...
Tạo client SFTP thành công
Chuẩn bị tải lên thư mục từ xa: /opt/xsoft/nginx/html/app/dist
Bắt đầu tải lên thư mục...
Bắt đầu duyệt thư mục cục bộ: /path/to/project/unpackage/dist/build/web
Tạo thư mục: /opt/xsoft/nginx/html/app/dist
Tệp static/js/app.js.map bị loại trừ, bỏ qua tải lên
Tạo bản sao lưu: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
Tải lên tệp: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
Tệp .DS_Store bị loại trừ, bỏ qua tải lên
Tải lên tệp: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
Tải lên thất bại (thử 1/3): Lỗi mạng
Thử lại tải lên tệp (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
Tải lên tệp: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
Tải lên thư mục thành công!
Thông tin thống kê:
  - Số tệp đã tải lên: 485
  - Số thư mục đã tạo: 18
  - Tổng dung lượng truyền: 25.8 MB
  - Thời gian tải lên: 38.5s
  - Tổng thời gian: 39.2s
  - Tốc độ truyền: 0.67 MB/s
```

## Lưu ý

1. **Bảo mật**:

   - Môi trường sản xuất khuyến nghị dùng xác thực khóa SSH thay cho mật khẩu
   - Hiện tại sử dụng `ssh.InsecureIgnoreHostKey()`, môi trường sản xuất nên xác thực khóa máy chủ
2. **Mạng**:

   - Đảm bảo máy cục bộ có thể truy cập cổng 22 của máy chủ đích
   - Tốc độ truyền tải phụ thuộc vào băng thông mạng và hiệu năng máy chủ
3. **Quyền**:

   - Đảm bảo người dùng SSH có quyền ghi vào thư mục đích
   - Nếu cần, có thể sử dụng quyền sudo
4. **Đường dẫn**:

   - Đường dẫn cục bộ tự động tính toán dựa trên vị trí file thực thi, không cần quan tâm thư mục làm việc
   - Đường dẫn máy chủ dùng đường dẫn tuyệt đối

## Xử lý sự cố

### Các vấn đề thường gặp

1. **Kết nối quá thời gian**

   ```
   Kết nối máy chủ SSH thất bại: dial tcp: i/o timeout
   ```

   - Kiểm tra địa chỉ và cổng máy chủ
   - Xác nhận kết nối mạng thông suốt
   - Kiểm tra cấu hình tường lửa
2. **Xác thực thất bại**

   ```
   Đăng nhập thất bại: ssh: handshake failed
   ```

   - Kiểm tra tên đăng nhập và mật khẩu
   - Xác nhận dịch vụ SSH đã khởi động
   - Kiểm tra cấu hình SSH
3. **Lỗi quyền truy cập**

   ```
   Tạo thư mục thất bại: permission denied
   ```

   - Kiểm tra quyền ghi thư mục đích của người dùng
   - Có thể cần sử dụng sudo hoặc thay đổi chủ sở hữu thư mục
4. **Thư mục cục bộ không tồn tại**

   ```
   Lỗi: Thư mục cục bộ /path/to/unpackage/dist/build/web không tồn tại
   ```

   - Xác nhận đã hoàn thành build cục bộ
   - Kiểm tra cấu trúc thư mục dự án đúng
   - Chương trình sẽ tự động tính toán đường dẫn, không cần tự thay đổi thư mục làm việc

## Ghi chú phát triển

### Cấu trúc dự án

```
go-deploy/
├── main.go                 # File chương trình chính
├── go.mod                  # File module Go  
├── go.sum                  # File kiểm tra phụ thuộc
```
├── README.md               # Tài liệu hướng dẫn chi tiết
├── Makefile                # Công cụ xây dựng
├── build.sh                # Script đóng gói hàng loạt
├── install.sh              # Script cài đặt một lần
└── config.example.json     # Tệp cấu hình mẫu
```

### Các hàm chính

- `main()` - Hàm chính, xử lý kết nối và gọi hàm upload
- `uploadDirectory()` - Đệ quy tải lên thư mục
- `uploadFile()` - Tải lên một tệp đơn lẻ
- `mkdirAll()` - Đệ quy tạo thư mục từ xa

## Giấy phép

Giấy phép MIT

## Đóng góp

Hoan nghênh gửi Issue và Pull Request!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---