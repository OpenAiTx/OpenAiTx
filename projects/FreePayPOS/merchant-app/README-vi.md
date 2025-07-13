# Thiết bị thanh toán NFC

Một thiết bị thanh toán NFC đa chuỗi xử lý các khoản thanh toán tiền mã hóa trên 5 mạng blockchain với khả năng giám sát giao dịch theo thời gian thực và theo dõi lịch sử toàn diện.

## 🌐 Mạng lưới được hỗ trợ

- **Ethereum**
- **Base** 
- **Arbitrum** 
- **Optimism** 
- **Polygon** 

### 🎯 **Ưu tiên thanh toán thông minh**

Thay vì phải thương lượng về sự kết hợp giữa chuỗi / token với người bán, thiết bị thanh toán sẽ tự động xử lý việc này. Đầu tiên, nó xác định một mạng lưới mà người bán hỗ trợ và bạn cũng có số dư, sau đó gửi giao dịch với ETH hoặc một token ERC-20 theo thứ tự ưu tiên sau:

```
Stablecoin trên L2 > Token khác trên L2 > ETH trên L2 > Stablecoin trên L1 > Token khác trên L1 > ETH trên L1
```
## 🚀 Bắt đầu nhanh

1. **Cài đặt các phụ thuộc:**
   ```bash
   npm install
   ```

2. **Thiết lập môi trường:**
   ```bash
   echo "ALCHEMY_API_KEY=your_alchemy_api_key_here" > .env
   ```

3. **Chạy terminal:**
   ```bash
   npm start
   ```

4. **Mở giao diện:**
   Truy cập vào `http://localhost:3000`

## 🏗️ Kiến trúc

```
src/
├── server.ts                   # Máy chủ Express & Bộ xử lý WebSocket
├── app.ts                      # Bộ điều phối ứng dụng chính
├── web/index.html              # Giao diện người dùng của máy POS thanh toán
├── config/index.ts             # Cấu hình đa chuỗi
└── services/
    ├── nfcService.ts           # Đầu đọc NFC & quét ví
    ├── alchemyService.ts       # Theo dõi & kiểm tra số dư đa chuỗi
    ├── paymentService.ts       # Lựa chọn thanh toán & tạo EIP-681
    ├── ethereumService.ts      # Tiện ích xác thực địa chỉ
    └── addressProcessor.ts     # Ngăn ngừa xử lý trùng lặp
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # Cài đặt các phụ thuộc để xây dựng ảnh Raspberry Pi
    └── build-pi-image-osx.sh       # Xây dựng ảnh Raspberry Pi
```
## 💡 Sử dụng

### **Xử lý Thanh toán**
1. Nhập số tiền bằng bàn phím (theo cent: "150" = 1,50 USD)
2. Nhấn "Charge" để bắt đầu thanh toán
3. Khách hàng chạm thiết bị NFC để gửi thanh toán
4. Theo dõi thời gian thực xác nhận giao dịch
5. Thông báo "Approved" với liên kết block explorer

### **Lịch sử Giao dịch**
1. Nhấn nút 📜 lịch sử trên bàn phím
2. Xem tất cả giao dịch hoặc quét ví để xem lịch sử cụ thể
3. Nhấn "📱 Quét Ví để Xem Lịch Sử" và yêu cầu khách hàng chạm thiết bị
4. Duyệt các giao dịch đã lọc cho ví cụ thể đó


## 🔄 Quy trình Thanh toán

1. **Nhận diện NFC** → Khách hàng chạm thiết bị
2. **Truy xuất Đa Chuỗi** → Phân tích danh mục trên cả 6 chuỗi
3. **Lựa chọn Thông minh** → Chọn token thanh toán tối ưu dựa trên hệ thống ưu tiên
4. **Tạo EIP-681** → Yêu cầu thanh toán với chain ID
5. **Giám sát Thời gian Thực** → WebSocket/polling để xác nhận giao dịch
6. **Ghi nhật ký Lịch sử** → Giao dịch được lưu với đầy đủ siêu dữ liệu
## 🛡️ Giám Sát Giao Dịch

- **Giám sát WebSocket** cho Ethereum, Base, Arbitrum, Optimism, Polygon
- **Giám sát dựa trên polling** dự phòng
- **Tự động ngắt kết nối** sau 5 phút
- **Tích hợp block explorer** để xác minh giao dịch
- **Theo dõi trạng thái**: đã phát hiện → đã xác nhận → thất bại

## 🍓 Triển Khai Trên Raspberry Pi

Thiết bị thanh toán NFC này có thể được triển khai như một **ki-ốt plug-and-play** trên phần cứng Raspberry Pi cho mục đích sử dụng thực tế.

### **Yêu Cầu Phần Cứng**
- Raspberry Pi 4B (khuyến nghị RAM 4GB trở lên)
- Màn hình cảm ứng Raspberry Pi chính hãng 7"
- **Đầu đọc NFC ACR1252U-M1** (hỗ trợ riêng biệt)
- Thẻ MicroSD 32GB trở lên

### **Tính Năng Triển Khai**
- **Xây dựng chỉ với một lệnh** tạo ảnh thẻ SD có thể khởi động
- **WiFi và thông tin xác thực API** được cấu hình sẵn
- **Khởi động tự động** với chế độ ki-ốt toàn màn hình
- **Xác thực an toàn** ngăn triển khai với địa chỉ thử nghiệm
- Hỗ trợ xây dựng trên **macOS và Linux**
### **Triển Khai Nhanh**
```bash
# Di chuyển đến thư mục script triển khai
cd scripts/rpi-deploy

# Cấu hình triển khai của bạn
cp build-config.env.template build-config.env
# Chỉnh sửa build-config.env với WiFi, khóa API, và địa chỉ merchant của bạn

# Tạo ảnh khởi động (macOS)
./build-pi-image-osx.sh

# Ghi file nfc-terminal-<date>.img.gz đã tạo ra vào thẻ SD bằng Raspberry Pi Imager và khởi động!
```

📖 **[Hướng Dẫn Triển Khai Đầy Đủ](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---