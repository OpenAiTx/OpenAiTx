
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Lịch Gia Đình Thông Minh Tự Làm (Bản Sao Skylight)

![Lịch Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Giới thiệu

Gần đây vợ tôi liên tục bị quảng cáo trên mạng xã hội về các loại lịch thông minh cho gia đình (Skylight, Cozyla, Hearth) và đã sẵn sàng chi hơn 300 đô cho một chiếc. Trước khi đồng ý, tôi xin cô ấy cho tôi thời gian để nghiên cứu về chúng.
Tôi nhận ra hầu hết các sản phẩm đều cung cấp chức năng tương tự nhưng giá cả lại khác biệt đáng kể. Quan trọng nhất, tôi không thấy tính năng nào nổi bật mà tôi không thể tự triển khai trên **Home Assistant**.

**Mục Tiêu:** Một lịch cảm ứng để bàn thân thiện, được vợ chấp nhận (WAF), tích hợp sâu vào hệ thống nhà thông minh mà không mất phí hàng tháng.

## 💡 Tại sao nên tự làm (DIY)?

Chọn hướng tự làm với Home Assistant mang lại nhiều lợi ích so với việc mua màn hình Skylight/Hearth:

* **Không phí hàng tháng:** Tránh các gói đăng ký cho tính năng "cao cấp".
* **Tích hợp liền mạch:** Có thể kết nối với hệ thống đèn, việc nhà (Grocy) và cảm biến hiện diện.
* **Tận dụng phần cứng cũ:** Tái sử dụng một Mini PC và màn hình tiêu chuẩn.
* **Riêng tư:** Không bị phụ thuộc vào nhà cung cấp hoặc lo lắng công ty ngừng hoạt động.

## 🛠 Lựa chọn phần cứng

Hiện tại, hệ thống này được xây dựng để hiển thị bảng điều khiển trên bất kỳ màn hình HD (1920x1080) nào.

Trong trường hợp của tôi, yêu cầu là nó phải "trông giống" Skylight, có cảm ứng, để bàn, và có thể di chuyển đến các vị trí khác nhau. Vì vậy, tôi đã chọn phần cứng như mô tả bên dưới.
Tuy nhiên, nhu cầu của bạn có thể khác và bạn sẽ cần điều chỉnh cho phù hợp, ví dụ nếu bạn muốn hiển thị trên máy tính bảng hoặc thiết bị khác.

Phần cứng tôi chọn ban đầu dựa trên các tiêu chí trên cộng với hi vọng có thể mở rộng chức năng với webcam, loa và micro. Hiện tại, nhìn lại tôi có thể sẽ làm khác đi, vì chưa có thời gian hiện thực hóa các ý tưởng phần cứng bổ sung này.

* **Màn hình:** [HP Engage 15-inch Touchscreen](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Tôi chọn sản phẩm này thay vì các màn hình di động thông thường vì nó tích hợp sẵn **Loa, Webcam, và Micro**, cho phép mở rộng điều khiển bằng giọng nói hoặc gọi video trong tương lai.
* **Máy tính:** Một Mini PC cũ (NUC/Tiny PC) chạy Windows/Linux ở chế độ Kiosk, hoặc Raspberry Pi 4.~~

## ✨ Tính năng

* **Xem lịch theo từng thành viên & cả gia đình:** Bật/tắt lịch của từng thành viên.
* **Đồng bộ hai chiều:** Chỉnh sửa sự kiện trên màn hình hoặc trên điện thoại (Google Calendar).
* **Popup "Thêm sự kiện":** Giao diện tùy chỉnh để thêm sự kiện trực tiếp vào các lịch cụ thể từ màn hình.
* **Thời tiết & ngày tháng:** Thanh tiêu đề đẹp mắt, dễ nhìn.
* **Phản hồi linh hoạt:** Tự động điều chỉnh số ngày hiển thị dựa trên độ rộng màn hình (di động hoặc máy tính để bàn).

---

## ⚙️ Hướng dẫn cài đặt

*Lưu ý: Thiết lập này sử dụng một **YAML Package** để tự động tạo tất cả các helper, script, và biến cần thiết cho bạn. Bạn không cần tạo thủ công.*



### 1. Yêu cầu tiên quyết (HACS)

Bạn phải cài đặt [HACS](https://hacs.xyz/). Vui lòng cài đặt các tích hợp **Giao diện người dùng** sau:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Bắt buộc để các popup hoạt động)
* `layout-card` (Bắt buộc cho chế độ xem Sections)
* `button-card` (Bắt buộc cho popup thêm sự kiện)

### 2. Backend (Bộ não xử lý)

1. Mở file `configuration.yaml` của bạn trong Home Assistant.
2. Đảm bảo bạn đã thêm dòng sau dưới `homeassistant:` để bật các package:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Tạo một thư mục tên là `packages` trong thư mục cấu hình HA của bạn (nếu bạn chưa có).
4. Tải xuống [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) từ kho lưu trữ này.
5. Đặt tệp vào trong thư mục `packages/` của bạn.
6. **Khởi động lại Home Assistant**.

### 3. Các Lịch

Bạn có thể sử dụng **Lịch Google** hoặc **Lịch Cục Bộ**.

#### Lựa chọn A: Lịch Cục Bộ (Dễ nhất)

Lưu ý điều này chưa được kiểm thử vì tôi chỉ dùng Lịch Google

1. Vào **Cài đặt > Thiết bị & Dịch vụ**.
2. Thêm tích hợp **Lịch Cục Bộ**.
3. Tạo các lịch với tên chính xác: `Alice`, `Bob`, `Charlie`, `Daisy`, `Family`.
    * *Nếu bạn sử dụng các tên này, mã sẽ hoạt động ngay lập tức!*

#### Lựa chọn B: Lịch Google

1. Mở `packages/family_calendar.yaml`.
2. Cuộn đến đoạn script `add_google_calendar_event`.
3. Cập nhật `calendar_map` để trỏ đến các thực thể Google thật của bạn:


    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```

#### Thiết lập Ngày nghỉ lễ

Kể từ các bản cập nhật Home Assistant, Ngày nghỉ lễ hiện được thêm qua giao diện UI:

1. Vào **Cài đặt > Thiết bị & Dịch vụ > Thêm tích hợp > Holiday**.
2. Chọn quốc gia của bạn.
3. Kiểm tra entity ID (ví dụ: `calendar.holidays`). Nếu khác với mặc định, hãy cập nhật nó trong dashboard YAML.

### 4. Bảng điều khiển (Giao diện)

1. Tạo một Dashboard View mới (Chọn loại View là **Sections**).
2. Sao chép mã từ [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).
3. **Tùy chỉnh:**
   * **Tìm & Thay thế:** Thay thế `person.alice` bằng các entity thành viên gia đình thực tế của bạn.
   * **Thời tiết:** Thay thế `weather.home` bằng nhà cung cấp thời tiết của bạn.
   * **Nền:** Cập nhật URL hình ảnh ở cuối yaml.

### Bước 5: Chủ đề (Tùy chọn)

Để có kiểu font chữ riêng biệt (Ovo):

1. Đảm bảo file `configuration.yaml` của bạn có dòng này dưới `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Tạo một thư mục tên là `themes` trong thư mục cấu hình của bạn.
3. Tải về [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) và đặt vào thư mục đó.
4. Khởi động lại Home Assistant.
5. Vào Hồ sơ của bạn (Biểu tượng người dùng ở góc dưới bên trái) và đổi **Giao diện** thành `Skylight`.
LƯU Ý: Giao diện này không bao quát hoàn toàn, vì vậy hãy lưu ý điều đó

---

## 📐 Cách hoạt động (Bên trong)

### Logic Lọc

Thẻ `week-planner-card` không hỗ trợ ẩn các lịch cụ thể một cách linh động. Để giải quyết, tôi sử dụng **Input Texts** như bộ lọc Regex.

* Khi bạn nhấn nút của một người, nó sẽ chuyển đổi bộ lọc của họ giữa `.*` (Hiện tất cả) và `^$` (Ẩn tất cả).
* `config-template-card` sẽ chèn các biến này vào thẻ lịch một cách động.

### Script Tạo Sự Kiện

Cửa sổ "Thêm sự kiện" sử dụng một script duy nhất để xử lý logic cho nhiều người và nhiều loại sự kiện (Cả ngày hoặc có thời gian).


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## LƯU Ý

Bài đăng gốc của tôi chỉ nhằm cung cấp cái nhìn tổng quan về cách thực hiện và cho phép mọi người điều chỉnh mã để phù hợp với tình huống cụ thể của họ.

Đặc biệt tôi làm điều này vì mỗi màn hình và nhu cầu đều khác nhau. Tôi không thể phát triển cho tất cả các kích thước màn hình, bảng điều khiển tiềm năng, v.v. Nên nó được xây dựng để hoạt động trên màn hình tôi đã đề cập hoặc bất kỳ màn hình nào (1920x1080) nhưng có thể chỉnh sửa cho các loại khác.

Nói về màn hình, ban đầu tôi gợi ý màn hình đó vì nó được giảm giá trên Woot và là cách rất kinh tế để có một màn hình cảm ứng vào thời điểm đó. Giờ có thể không còn như vậy, hãy dùng bất kỳ màn hình nào phù hợp với bạn. Máy tính bảng, màn hình cảm ứng, điện thoại, bất cứ gì. Điều chính bạn cần chỉnh sửa là bảng điều khiển.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---