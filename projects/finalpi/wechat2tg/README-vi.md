# wechat2tg-mac

Dựa trên giao thức WeChat Mac để gửi và nhận tin nhắn WeChat trên Telegram, dịch vụ wx2tg-server không mã nguồn mở vì lý do bảo mật

## Nhóm TG: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## Chức năng chính

1. Nhận tin nhắn trò chuyện riêng, tin nhắn nhóm, tin nhắn công khai và tin nhắn WeCom của WeChat
2. Telegram gửi tin nhắn đến người dùng WeChat, nhóm WeChat, tài khoản công khai chỉ định
3. Chặn tin nhắn từ các nhóm chỉ định

## Loại tin nhắn hỗ trợ

### Danh sách loại tin nhắn WeChat hỗ trợ

+ [x] Tin nhắn văn bản
+ [x] Tin nhắn WeCom
+ [x] Nhãn dán WeChat
+ [x] Tin nhắn hình ảnh
+ [x] Tin nhắn video
+ [x] Thông báo cuộc gọi âm thanh/video (chỉ nhắc nhở)
+ [x] Tin nhắn tệp
+ [x] Tin nhắn liên kết
+ [x] Tin nhắn nhóm
+ [x] Tin nhắn nhóm @ (cả @tất cả và @bạn sẽ chuyển thành Telegram @bạn)
+ [x] Tin nhắn công khai
+ [x] emoji
+ [x] Tin nhắn vị trí
+ [x] Tin nhắn thu hồi
+ [x] Tin nhắn thoại
+ [ ] Tin nhắn lì xì (chỉ nhắc nhở, không lấy được nội dung)
+ [ ] Tin nhắn Mini Program

### Danh sách loại tin nhắn Telegram hỗ trợ

+ [x] Tin nhắn văn bản
+ [x] Nhãn dán
+ [x] Tin nhắn hình ảnh
+ [x] Tin nhắn video
+ [x] Tin nhắn tệp
+ [x] Tin nhắn thoại

## Lưu ý

1. Dự án này chỉ dùng cho mục đích nghiên cứu kỹ thuật và học tập, không sử dụng cho mục đích phi pháp
2. Chào mừng gửi issue nếu gặp bất cứ vấn đề nào

## Triển khai cài đặt

Sao chép file `.env.example` thành file `.env`, sau đó cấu hình biến môi trường trong file `.env`

Sao chép file `app.conf.example` trong dự án thành file `app.conf` vào thư mục `conf`, đặt địa chỉ Redis thành địa chỉ Redis mà bạn đã triển khai

### docker-compose

Tạo file `docker-compose.yml`:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # Sau khi mount thư mục, file sticker không cần chuyển đổi lại
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # Kéo image
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### Chạy

```shell
docker-compose up -d
```

#### Tắt chế độ riêng tư bot

Tắt chế độ riêng tư của bot, mở BotFather, nhập `/mybots`, chọn bot của bạn. Nhấn `Bot Settings` - `Group Privacy` - `Turn off`
, khi xuất hiện `Privacy mode is disabled for xxx` là đã tắt thành công

## Hướng dẫn sử dụng

### Lệnh BOT

- `/login`: Lấy mã QR đăng nhập; khi triển khai lần đầu, người gửi lệnh `/login` đầu tiên sẽ trở thành chủ sở hữu `BOT`

- `/flogin`: Lấy mã QR đăng nhập trợ lý truyền file, hỗ trợ nhận video và tệp

- `/update`: Cập nhật ảnh đại diện và thông tin nickname nhóm

- `/message`: Bật/tắt nhận tin nhắn nhóm

- `/forward`: Bật/tắt chuyển tiếp tin nhắn từ người khác hoặc bot trong nhóm

- `/user`: Lấy danh sách người dùng WeChat; nhấn nút để tạo nhóm mới hoặc liên kết người dùng (có thể tìm kiếm qua tên hoặc ghi chú, ví dụ: `/user Zhang` để tìm người dùng WeChat chứa "Zhang")

- `/room`: Lấy danh sách nhóm WeChat; nhấn nút để tạo nhóm mới hoặc liên kết nhóm WeChat (có thể tìm kiếm qua tên hoặc ghi chú, ví dụ: `/room Delivery` để tìm nhóm WeChat chứa "Delivery")

- `/settings`: Thiết lập chương trình

- `/unbind`: Bỏ liên kết nhóm WeChat hoặc người dùng WeChat (chỉ hỗ trợ trong nhóm)

### Giải thích biến môi trường

|Tên| Bắt buộc | Mô tả                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| Có    | Token của Telegram Bot, tạo bằng [BotFather](https://t.me/BotFather) |
|`API_ID`| Có    | API ID của Telegram API                                          |
|`API_HASH`| Có    | API HASH của Telegram API                                        |
|`BASE_API`| Có    | Địa chỉ API đầy đủ của container wx2tg-server                            | |
|`PROXY_PROTOCOL`| Không    | Loại proxy (socks5,http,https)                                     |
|`PROXY_HOST`| Không    | URL proxy                                                        |
|`PROXY_PORT`| Không    | Cổng proxy                                                         |
|`PROXY_USERNAME`| Không    | Tên đăng nhập proxy                                                         |
|`PROXY_PASSWORD`| Không    | Mật khẩu proxy                                                          |
|`ROOM_MESSAGE`| Không    | Định dạng hiển thị tin nhắn nhóm WeChat trong BOT                             |
|`OFFICIAL_MESSAGE`| Không    | Định dạng hiển thị tin nhắn công khai trong BOT                              |
|`CONTACT_MESSAGE`| Không    | Định dạng hiển thị tin nhắn người dùng WeChat trong BOT                      |
|`ROOM_MESSAGE_GROUP`| Không    | Định dạng hiển thị tin nhắn nhóm WeChat trong nhóm                             |
|`CONTACT_MESSAGE_GROUP`| Không    | Định dạng hiển thị tin nhắn người dùng WeChat trong nhóm                        |
|`OFFICIAL_MESSAGE_GROUP`| Không    | Định dạng hiển thị tin nhắn công khai trong nhóm                                 |
|`CREATE_ROOM_NAME`| Không    | Định dạng tên nhóm khi tự động tạo nhóm WeChat                                     |
|`CREATE_CONTACT_NAME`| Không    | Định dạng tên nhóm khi tự động tạo nhóm liên hệ WeChat                             |
|`MESSAGE_DISPLAY`| Không    | Định dạng hiển thị tin nhắn văn bản                                              |

 ---

### Giải thích lệnh `/settings`

1. WeChat emoji hiển thị bằng liên kết ảnh: Bật lên sẽ chuyển các biểu tượng mặt cười của bạn bè thành liên kết ảnh
2. Đồng bộ thông tin nhóm khi khởi động: Bật lên sẽ đồng bộ thông tin của tất cả mọi người khi khởi động chương trình, cập nhật ảnh đại diện và tên nhóm

---

### Chuyển giọng nói thành văn bản

1. Cấu hình `TENCENT_SECRET_ID` và `TENCENT_SECRET_KEY`, có thể đăng ký tại [Bảng điều khiển nhận diện giọng nói Tencent](https://console.cloud.tencent.com/asr)
   . Có hạn mức miễn phí
2. Bật tính năng chuyển giọng nói thành văn bản tự động trong `/settings`

---

### Lấy `API_ID` và `API_HASH`

1. Đăng nhập [tài khoản telegram](https://my.telegram.org/)

2. Nhấn vào "API development tools" và điền thông tin chi tiết ứng dụng (chỉ cần tiêu đề và viết tắt)

3. Nhấn "Create application"

---

### Tùy chỉnh mẫu tin nhắn

Nếu bạn muốn thay đổi định dạng người gửi tin nhắn, bạn có thể sửa biến môi trường trong docker hoặc file `.env`

Các placeholder trong mẫu tin nhắn tùy chỉnh:

`#[alias]`: Ghi chú liên hệ

`#[name]`: Biệt danh liên hệ

`#[topic]`: Biệt danh nhóm

`#[alias_first]`: Ưu tiên ghi chú, nếu không có sẽ hiển thị biệt danh

`#[identity]`: Văn bản thông tin nhận dạng

`#[body]`: Nội dung tin nhắn

`#[br]`: Xuống dòng

### Cách @tất cả

Gửi tin nhắn bắt đầu bằng `@all` sẽ @tất cả, chỉ hỗ trợ tin nhắn văn bản @tất cả

---

## Câu hỏi thường gặp


## Tham gia phát triển

1. fork dự án, chuyển sang nhánh `wx2tg-mac-dev` hoặc tạo nhánh mới. Vui lòng không commit trực tiếp vào nhánh chính
2. Gửi Pull Request tới nhánh `wx2tg-mac-dev`

## License

[MIT](LICENSE)

## Cảm ơn

Cảm ơn Jetbrains đã hỗ trợ dự án này

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---