# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` đã được triển khai bằng `Rust` hỗ trợ proxy `http/https`, proxy `socks5`, proxy ngược, cân bằng tải, máy chủ tệp tĩnh, proxy `websocket`, chuyển tiếp TCP/UDP lớp 4, xuyên NAT, v.v.

## 📦 Cài đặt & 🏃 Sử dụng

### Cài đặt

```bash
cargo install wmproxy
```

HOẶC

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### Sử dụng
Cổng mặc định là 8090, địa chỉ lắng nghe mặc định là 127.0.0.1
```bash
# Sử dụng trực tiếp với tham số mặc định
wmproxy proxy

# Thiết lập tài khoản và mật khẩu
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Các lệnh khác
wmproxy --help

# Khởi động bằng cấu hình file
wmproxy config -c config/client.toml
```

##### Khởi động proxy cấp hai
1. Khởi động proxy ở máy cục bộ
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
Hoặc
```bash
wmproxy config -c config/client.toml
```
File cấu hình như sau:
```toml
[proxy]
# Địa chỉ kết nối tới máy chủ
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# Có mã hóa khi kết nối tới máy chủ không
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# Mảng cấu hình ánh xạ nội bộ

  # Chuyển tiếp tên miền localhost tới 127.0.0.1:8080
[[proxy.mappings]]
name = "web"
mode = "http"
local_addr = "127.0.0.1:8080"
domain = "localhost"

headers = [
  "proxy x-forward-for {client_ip}",
  "proxy + from $url",
  "+ last-modified 'from proxy'",
  "- etag",
]

# Chuyển tiếp mọi lưu lượng tcp tới 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Vì chỉ chuyển tiếp nên thiết lập tài khoản mật khẩu ở node hiện tại là không cần thiết. `-S` biểu thị địa chỉ proxy cấp hai sẽ kết nối, **có tham số này thì là proxy chuyển tiếp, nếu không có thì là proxy đầu cuối.** ```--ts``` biểu thị khi kết nối proxy cha thì cần sử dụng kết nối mã hóa.

2. Khởi động proxy ở máy từ xa
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
Hoặc
```bash
wmproxy config -c config/server.toml
```
File cấu hình như sau:
```toml
[proxy]
# Địa chỉ ip lắng nghe
bind_addr = "127.0.0.1:8091"

# Các chức năng proxy hỗ trợ, 1 là http, 2 là https, 4 là socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# Địa chỉ lắng nghe http ánh xạ nội bộ
map_http_bind = "127.0.0.1:8001"
# Địa chỉ lắng nghe tcp ánh xạ nội bộ
map_tcp_bind = "127.0.0.1:8002"
# Địa chỉ lắng nghe https ánh xạ nội bộ
map_https_bind = "127.0.0.1:8003"
# Chứng chỉ public key cho ánh xạ nội bộ, để trống sẽ dùng chứng chỉ mặc định
# map_cert = 
# Chứng chỉ private key cho ánh xạ nội bộ, để trống sẽ dùng chứng chỉ mặc định
# map_key =
# Xác thực hai chiều
two_way_tls = true
# Có nhận kết nối từ client mã hóa không
tc = true
# Chế độ dịch vụ hiện tại, server là máy chủ, client là máy khách
mode = "server"
```

```--tc``` biểu thị khi nhận kết nối từ proxy con cần dùng kết nối mã hóa, có thể dùng ```--cert``` để chỉ định public key của chứng chỉ, ```--key``` để chỉ định private key của chứng chỉ, ```--domain``` để chỉ định tên miền của chứng chỉ, nếu không chỉ định sẽ dùng chứng chỉ mặc định.
> Khi truy cập thông qua proxy, chúng ta không còn cách nào lấy được địa chỉ thực sự của yêu cầu, chỉ có thể lấy địa chỉ do proxy khởi tạo.

### Xác thực giữa các proxy
> Hiện tại cung cấp hai phương thức xác thực, ```two_way_tls``` bật xác thực chứng chỉ phía client, phương thức còn lại là server cấu hình ```username``` và ```password``` thì client cũng cần cấu hình tương tự để xác thực. Hai cách này có thể kết hợp hoặc dùng riêng lẻ.
> Cấu hình thêm như sau:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Lộ trình phát triển
### socks5

- [x] Hỗ trợ IPV6
- [x] Phương thức xác thực `SOCKS5`
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] Lệnh `SOCKS5`
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] Hỗ trợ IPV6

### Xuyên NAT (NAT Traversal)

- [x] Hỗ trợ Http
- [x] Hỗ trợ Https
- [x] Hỗ trợ Tcp

### Proxy ngược

- [x] Máy chủ tệp tĩnh
- [x] Kiểm tra sức khỏe bị động
- [x] Kiểm tra sức khỏe chủ động
- [x] Nạp lại cấu hình nóng
- [x] Cân bằng tải
- [x] Cân bằng tải TCP lớp 4
- [x] Cân bằng tải UDP lớp 4
- [x] Kiểm soát lưu lượng
- [x] Chuyển tiếp websocket

### Năng lực cơ bản
- [x] Ghi log

#### Năng lực mở rộng

- [x] Giới hạn tốc độ yêu cầu (limit_req)
- [x] Sửa đổi HTTP Request Header
- [x] Hỗ trợ xuyên NAT HTTP2
- [x] Điều khiển micro client
- [x] try_paths
- [x] tcp sang websocket
- [x] websocket sang tcp


## Lịch sử Star

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---