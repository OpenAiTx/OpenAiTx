<h1 align="center">Chào mừng sử dụng&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Công cụ tự động tiếp tục Cursor, tự động thử lại Cursor, tự động xác nhận Cursor, thống kê sử dụng Cursor, công cụ tăng cường Cursor, công cụ hỗ trợ Cursor, công cụ tự động hóa Cursor, cài đặt chủ đề Cursor, Cursor Auto Continue Tool, Cursor Auto Retry Tool, Cursor Auto Confirm Tool, Cursor Usage Statistics Tool, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor after 25 tool calls, Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [Trang chủ](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper là một công cụ tự động hóa tăng cường dành riêng cho Cursor IDE, có thể hiển thị thời lượng sử dụng theo thời gian thực, tự động xử lý giới hạn 25 lần hội thoại, lỗi kết nối mạng, xác nhận nhắc nhở v.v..., giúp trải nghiệm phát triển của bạn mượt mà hơn.

**Video demo:** [Video demo Cursor Auto Helper](https://www.bilibili.com/video/BV1cajKzCEzv/)

Nếu chất lượng prompt tốt, yêu cầu dự án được hoạch định rõ ràng, chương trình này có thể giúp Cursor hoàn thành một dự án hoàn toàn tự động mà không cần can thiệp thủ công.

> 🔒 **Tương thích phiên bản:** Hiện tại đã phát triển và kiểm thử trên Cursor 0.49.6, Cursor 1.0.0, lý thuyết tương thích với các phiên bản Cursor 0.48.x - 1.0.0.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖Nhật ký cập nhật

- 2025-06-01 Phát hành phiên bản v2.3, thêm chức năng cài đặt chủ đề Cursor, tối ưu tính ổn định tiêm mã, sửa hiển thị thời lượng sử dụng đồng nhất với định dạng chính thức
- 2025-05-21 Phát hành phiên bản v2.1, tái cấu trúc kiến trúc, hỗ trợ đa nền tảng, bổ sung chức năng hiển thị thời lượng sử dụng theo thời gian thực v.v...
- 2025-04-25 Hoàn thành phiên bản v1.0, tự động xử lý giới hạn 25 lần hội thoại, lỗi kết nối mạng, xác nhận nhắc nhở v.v...
- 2025-04-20 Khởi động dự án

## 🌟 Thực hành tốt nhất Cursor Auto Helper

Lưu ý: Tài liệu dưới đây có thể được tạo với sự hỗ trợ của AI như Cursor, cần kiểm tra và điều chỉnh thủ công.

**BƯỚC 1:** Thiết kế chi tiết yêu cầu hệ thống dự án (yêu cầu càng rõ ràng thì chất lượng dự án càng cao), biên soạn prompt phát triển dự án chất lượng cao **SYSTEM.md**

**BƯỚC 2:** Dựa vào **SYSTEM.md** xuất ra tài liệu thiết kế phát triển hệ thống chất lượng cao **DESIGN.md**

**BƯỚC 3:** Dựa vào **SYSTEM.md** và **DESIGN.md** xuất ra tài liệu kế hoạch phát triển chất lượng cao **TODOLIST.md**

**BƯỚC 4:** Sử dụng **Cursor Auto Helper**, chỉ định **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md**, sử dụng prompt tự động tiếp tục phản hồi, để Cursor tự động hoàn thành phát triển dự án theo kế hoạch phát triển cho đến khi xong

**Prompt tự động tiếp tục Cursor Auto Helper:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md Vui lòng nghiêm ngặt thực hiện phát triển các chức năng tiếp theo theo kế hoạch phát triển trong TODOLIST, đồng thời cập nhật ghi chú TODOLIST theo thời gian thực, sau khi hoàn thành mỗi công việc cần hỏi tôi "có tiếp tục không", cho đến khi hoàn thành dự án thì trả về "dự án đã hoàn thành"
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 Hướng dẫn sử dụng

Hoan nghênh Star ủng hộ, nếu có vấn đề xin vui lòng tạo [Issues](https://github.com/pen9un/cursor-auto-helper/issues).

### 📝 Giải thích file cấu hình

File cấu hình `config.ini` **dùng để tùy chỉnh hành vi tự động hóa** (có thể thiết lập và thử nghiệm theo nhu cầu), hỗ trợ các mục cấu hình sau:

#### Cấu hình cơ bản
```ini
[common]
log_enable = true     # Có bật ghi nhật ký hay không, nếu không muốn ghi log có thể chuyển thành false

[cursor]
path = C:\Path\To\Cursor.exe  # Đường dẫn cài đặt Cursor IDE, chương trình sẽ tự động tìm đường dẫn Cursor, nếu không tìm thấy sẽ có thông báo, chỉ cần sửa mục này
```

#### Cấu hình hành động tự động
Mỗi hành động tự động lấy tiền tố là `actiontên.` và hỗ trợ các trường sau:

- `type`: Loại hành động
  - `click`: Nhấn nút
  - `input_and_submit`: Nhập và gửi

- `text` / `text_list`: Nội dung văn bản khớp
  - `text`: Một chuỗi đơn
  - `text_list`: Nhiều chuỗi ngăn cách bằng dấu |, chỉ cần nội dung trang có một chuỗi sẽ kích hoạt

- `button_selector`: CSS selector của nút cần nhấn (chỉ áp dụng cho loại `click`)
- `button_text`: Nội dung văn bản của nút (tùy chọn, giới hạn nút chính xác hơn)
- `input_box_selector`: CSS selector của ô nhập liệu (cần cho loại `input_and_submit`)
- `input_content`: Nội dung cần nhập tự động
- `submit_btn_selector`: CSS selector của nút gửi
- `delay`: Độ trễ trước khi thực hiện hành động (ms), có thể dùng để chờ trang render

##### Ví dụ cấu hình
```ini
[auto_actions]
# Tự động thử lại khi kết nối thất bại
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# sau 25 lần gọi tool
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "请继续"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_continue.delay = 1000

# Tự động xác nhận tiếp tục
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **Lưu ý:**
> 1. Tên của mỗi action (như `action_retry`, `action_continue`) có thể tự định nghĩa, nhưng tất cả các trường của cùng một action phải có tiền tố giống nhau
> 2. Khuyến nghị sử dụng công cụ phát triển trình duyệt để xác định chính xác CSS selector
> 3. Sau khi chỉnh sửa file cấu hình cần khởi động lại chương trình để có hiệu lực

## 🎯 Ứng dụng thực tế

### 💼 Phát triển hội thoại dài
- Tự động xử lý giới hạn 25 lượt hội thoại, hỗ trợ phát triển hội thoại dài liên tục, tự động tiếp tục quy trình hội thoại, nâng cao hiệu suất phát triển.

### 👥 Mạng không ổn định
- Tự động phát hiện bất thường mạng, tự động thử lại kết nối thông minh, tự động khôi phục hội thoại, đảm bảo liên tục trong phát triển.

### 🏢 Xác nhận tình huống
- Nhận diện thông minh các tình huống nhắc xác nhận, tự động xử lý thông báo xác nhận, giảm can thiệp thủ công.

### 📚 Giám sát lượng sử dụng
- Thống kê thời gian thực số lượt hội thoại, giám sát lượng sử dụng Cursor, ghi lại dữ liệu sử dụng, tối ưu hóa hiệu quả sử dụng.

Hiển thị lượng sử dụng trên terminal:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Hiển thị lượng sử dụng trên Cursor IDE:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟Mô tả chức năng

### 🤖Tự động tiếp tục hội thoại dài
- Tự động xử lý giới hạn 25 lượt hội thoại của Cursor, hỗ trợ nhiều vòng hội thoại liên tục.

### 🎨 Tự động thử lại kết nối
- Tự động phát hiện lỗi kết nối mạng, thử lại thông minh, giám sát trạng thái kết nối theo thời gian thực.

### 📱 Tự động xác nhận thông báo
- Nhận diện thông minh nhiều tình huống xác nhận, tự động xử lý cửa sổ xác nhận.
- Hỗ trợ tùy chỉnh nội dung xác nhận và phản hồi, giảm can thiệp thủ công.
- Quy tắc cấu hình linh hoạt, thích ứng với đa dạng quy trình phát triển.

### 🛍️ Thống kê lượng sử dụng
- Thống kê thời gian thực số lượt hội thoại và lượng sử dụng, tự động ghi lại dữ liệu.
- Dữ liệu sử dụng được trực quan hóa, tiện lợi cho phân tích và tối ưu hóa.
- Hỗ trợ hiển thị log màu sắc trên terminal, bảng lượng sử dụng trên IDE, nâng cao khả năng sử dụng.

### 💡 Hệ thống log
- Hỗ trợ nhiều cấp độ log (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), hiển thị màu sắc trên terminal.
- File log tự động tạo theo ngày, hỗ trợ ghi file và hiển thị bảng kéo thả.
- Bảng thời gian thực giúp lập trình viên giám sát và truy vết.

### 🔒 Tương thích phiên bản & tối ưu hiệu năng
- Phát triển dựa trên Cursor 0.49.6, các chức năng cốt lõi đã được kiểm thử đầy đủ.
- Tối ưu hóa cho các phiên bản cụ thể, liên tục cập nhật theo các bản Cursor mới.
- Ổn định, tương thích tốt, phù hợp môi trường sản xuất.

## 🔮Hiệu quả trình diễn

### 🤖 Tự động tiếp tục hội thoại

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Trình diễn chương trình hoàn thiện tự động với Cursor

Từ yêu cầu dự án đến triển khai hoàn chỉnh, toàn bộ không cần can thiệp thủ công:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝Tác giả

👤 **pen9un**

* Website: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️Hỗ trợ

Nếu bạn thấy dự án này hữu ích, hãy để lại một ⭐️⭐️ miễn phí

## ✨Lịch sử Star

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 Thống kê lượt truy cập

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---