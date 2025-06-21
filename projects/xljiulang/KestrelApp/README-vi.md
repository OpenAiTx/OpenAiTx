# KestrelApp
Ví dụ ứng dụng lập trình mạng dựa trên Kestrel

### 1 Mục đích dự án
1. Hiểu rằng lập trình mạng không còn cần bắt đầu từ Socket
2. Hiểu rằng lập trình mạng không còn cần framework bên thứ ba (bao gồm cả Dotnetty)
3. Hiểu về lập trình mạng dạng “búp bê lồng nhau” `telnet` over `websocket` over `tls` over `xxx mã hóa riêng` over `tcp`
4. Có thể phát triển ứng dụng mạng dựa trên KestrelFramework

### 2 Tài liệu tham khảo
**Tài liệu nội bộ**：[docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**Tài liệu bên ngoài**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Một số thư viện cơ sở cần thiết cho lập trình mạng kestrel
1. Giao diện middleware và đăng ký middleware trong Kestrel
2. System.Buffers: Lớp thao tác bộ đệm
3. System.IO: Lớp thao tác luồng
4. System.IO.Pipelines: Lớp thao tác ống dẫn song công
5. Middleware: Một số middleware của kestrel

### 4 KestrelApp
Ứng dụng Kestrel, bao gồm nội dung
1. Cấu hình EndPoint lắng nghe
2. Cấu hình giao thức sử dụng cho EndPoint

### 5 KestrelApp.Middleware
Thư viện lớp middleware của KestrelApp
#### 5.1 Echo
Ví dụ về giao thức ứng dụng Echo đơn giản

#### 5.2 FlowAnalyze
Ví dụ middleware thống kê lưu lượng tầng truyền tải

#### 5.3 FlowXor
Ví dụ middleware xử lý xor lưu lượng tầng truyền tải

#### 5.4 HttpProxy
Ví dụ về giao thức ứng dụng proxy http

#### 5.5 Telnet
Ví dụ về giao thức ứng dụng Telnet đơn giản

#### 5.6 TelnetProxy
Ví dụ chuyển tiếp lưu lượng đến máy chủ telnet

#### 5.6 Redis
Máy chủ giao thức redis, ví dụ về cách sử dụng middleware ứng dụng

### Cộng đồng mã nguồn mở – Bạn làm nó tuyệt vời hơn
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---