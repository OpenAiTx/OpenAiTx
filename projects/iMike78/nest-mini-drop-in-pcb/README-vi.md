
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Thay thế PCB dạng drop-in MiciMike cho Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) là một bo mạch PCB thay thế dạng drop-in cho ["Google Nest Mini" (loa thông minh thế hệ thứ hai của Google với cổng sạc kiểu barrel connector)](https://vi.wikipedia.org/wiki/Google_Nest_(loa_thông_minh)), nhưng dựa trên vi điều khiển ESP32 và XMOS để chạy firmware mã nguồn mở.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Mẹo! Nếu bạn đang tìm kiếm bo mạch PCB thay thế dạng drop-in cho "Google Home Mini" (phần cứng loa thông minh thế hệ đầu tiên của Google với cổng sạc Micro-USB) thì hãy tham khảo dự án liên quan tại https://github.com/iMike78/home-mini-v1-drop-in-pcb

Cả hai đều là các dự án phần cứng mã nguồn mở hoàn toàn, lấy cảm hứng từ một số ý tưởng của [Onju Voice](https://github.com/justLV/onju-voice) nhưng hướng tới tuân thủ [tiêu chuẩn trợ lý giọng nói mở của Open Home Foundation với Home Assistant Voice Preview Edition làm tham chiếu](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) cho thiết kế và thông số PCB.

# Phạm vi dự án

Mục tiêu của dự án và kho lưu trữ này (tương tự như [Onju Voice](https://github.com/justLV/onju-voice) nhưng theo giấy phép phần cứng mã nguồn mở hoàn toàn) là thiết kế một PCB thay thế trực tiếp (Bảng mạch in) với sơ đồ phần cứng mà bất kỳ ai cũng có thể tự chế tạo/xây dựng hoặc đặt hàng từ nhà sản xuất PCB một cửa như một PCB thay thế tùy chỉnh cho Google Nest Mini (thế hệ 2).

Điều này chủ yếu nhắm tới những người muốn chuyển đổi/tái sử dụng loa thông minh Google Nest Mini cũ của họ thành phần cứng mã nguồn mở cho [Điều khiển giọng nói Home Assistant](https://www.home-assistant.io/voice_control/) và/hoặc đầu ra loa phát nhạc cho [Music Assistant](https://www.music-assistant.io), (tuy nhiên phần cứng cũng có thể sử dụng với các ứng dụng khác với firmware khác, vì nó dựa trên nền tảng Espressif ESP32 phổ biến).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Thiết kế phần cứng sẽ (tương tự như [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) tích hợp SoC ESP32-S3 cho WiFi, BLE, và [phát hiện từ đánh thức trên bo mạch](https://www.home-assistant.io/voice_control/about_wake_word/) (sử dụng firmware [ESPHome không cần mã hóa](https://esphome.io/)) + chip XMOS xCORE XU316 để xử lý âm thanh nâng cao (với firmware tùy chỉnh để xử lý micro nhằm cải thiện khả năng nhận diện giọng nói bằng cách sử dụng các thuật toán chạy cục bộ cho Khử ồn, Khử vọng âm, Khử nhiễu và Điều chỉnh tự động mức độ âm thanh).

Về chức năng, nó được thiết kế để tương thích phần cứng chủ yếu với [Home Assistant Voice Preview Edition (hay còn gọi là Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) thiết kế tham chiếu (đã được phát hành dưới dạng thiết kế phần cứng mã nguồn mở từ Open Home Foundation phối hợp với Nabu Casa). Sự khác biệt chính sẽ là do những hạn chế được xác định bởi vỏ và linh kiện Google Nest Mini, (tức là thiết kế phần cứng dự án nest-mini-drop-in-pcb sẽ bị giới hạn bởi các loại đầu vào vật lý tương tự như phần cứng gốc của Google).

Vì vậy, phạm vi của dự án/kho lưu trữ này không phải là phát triển tính năng/chức năng mới cho firmware ESPHome, nên nếu bạn muốn điều đó thì hãy chuyển sang phát triển firmware của Home Assistant Voice Preview Edition cũng như mã nguồn chính của ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Kêu gọi hợp tác

Nếu bạn có kinh nghiệm với thiết kế layout PCB, (đặc biệt là với định tuyến PCB, đổ ground, hoặc thiết kế layout kỹ thuật số+analog nhạy cảm với nhiễu), **rất mong nhận được sự hỗ trợ của bạn**! Xin vui lòng mở issue mới, gửi đề xuất/yêu cầu, và đóng góp ý kiến/phản hồi vào các issue hiện có, hoặc fork kho lưu trữ này.

Để biết thêm thông tin về ý tưởng/khái niệm, xem và đóng góp vào chủ đề thảo luận liên quan tại diễn đàn cộng đồng Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Tình trạng hiện tại

- ✅ Đã hoàn thành sơ đồ mạch
- ✅ Đã hoàn thành bố trí linh kiện
- ✅ Đã hoàn thành định tuyến
- ✅ Đã hoàn thành đổ ground, chiến lược chống nhiễu và xem xét EMI
- ⚠️ Lô thử nghiệm đầu tiên thất bại do hai lỗi - đã sửa
- 🕓 Đang chờ lô thử nghiệm thứ 2

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Công cụ đã sử dụng

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC để tìm nguồn footprint

## Thông số phần cứng đã biết

- PCB 4 lớp
- Chip trần ESP32-S3R8 (ESP32-S3 cho WiFi, BLE và nhận diện từ khóa đánh thức trên bo mạch)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP xử lý âm thanh)
- Dual SPI flash
- Dual bus I²S (cho phép giao diện I2S đồng thời, tức là xuất và nhập âm thanh cùng lúc)
- MAX98357 cho đầu ra loa (Bộ khuếch đại âm thanh Mono Class-D I2S)
- 2x micro MEMS (MSM261DHP)
- Đèn LED SK6812
- Đầu vào nguồn USB-C và 14V tùy chỉnh

---

> ⚠️ Nạp firmware qua USB-C yêu cầu ngắt kết nối nguồn chính 14V. Xem ghi chú silkscreen trên PCB để biết chi tiết.

## Tham khảo

### Tài nguyên Home Assistant Voice Preview Edition bao gồm file thiết kế PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/vi/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome cho Home Assistant Voice PE (cũng sử dụng cùng kết hợp ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### Chip IC MCU XMOS xCORE DSP (XU316-1024-QF60B-C32)

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Firmware XMOS từ dự án ESPHome dành cho phần cứng Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Giấy phép

Dự án này được cấp phép theo [Giấy phép Phần cứng Mở CERN Phiên bản 2 - Tương hỗ mạnh mẽ (CERN-OHL-S v2)]
Bất kỳ phiên bản đã chỉnh sửa nào của phần cứng này cũng phải được phân phối theo cùng giấy phép.

☕ Nếu bạn muốn ủng hộ dự án này, hãy [mua cho tôi một ly cà phê trên Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---