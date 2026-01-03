
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

# Thay thế PCB MiciMike cho Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) là một bo mạch PCB thay thế cho ["Google Nest Mini" (loa thông minh thế hệ thứ hai của Google với cổng sạc dạng tròn)](https://vi.wikipedia.org/wiki/Google_Nest_(smart_speakers)), nhưng được thiết kế dựa trên vi điều khiển ESP32 và XMOS để chạy phần mềm mã nguồn mở.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Mẹo! Nếu bạn đang tìm kiếm một bo mạch PCB thay thế tương tự cho "Google Home Mini" (phần cứng loa thông minh thế hệ đầu tiên của Google với cổng sạc Micro-USB) thì hãy tham khảo dự án chị em tại https://github.com/iMike78/home-mini-v1-drop-in-pcb
Cả hai dự án này đều là phần cứng mã nguồn mở hoàn toàn, lấy cảm hứng ý tưởng từ [Onju Voice](https://github.com/justLV/onju-voice) nhưng hướng tới tuân thủ [tiêu chuẩn trợ lý giọng nói mở của Open Home Foundation với Home Assistant Voice Preview Edition làm tham chiếu](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) cho thiết kế và thông số kỹ thuật PCB.

# Phạm vi dự án

Mục tiêu của dự án và kho lưu trữ này (tương tự như [Onju Voice](https://github.com/justLV/onju-voice) nhưng dưới giấy phép phần cứng mã nguồn mở hoàn toàn) là thiết kế một bảng mạch in (PCB) thay thế trực tiếp với sơ đồ phần cứng mà bất kỳ ai cũng có thể tự chế tạo/xây dựng hoặc đặt hàng từ một nhà sản xuất PCB như một bảng mạch in thay thế tùy chỉnh cho Google Nest Mini (thế hệ 2).

Dự án này chủ yếu nhắm đến những người muốn chuyển đổi/tái sử dụng loa thông minh Google Nest Mini cũ thành phần cứng mã nguồn mở để [điều khiển giọng nói Home Assistant](https://www.home-assistant.io/voice_control/) và/hoặc phát nhạc cho [Music Assistant](https://www.music-assistant.io), (tuy nhiên phần cứng này cũng có thể được sử dụng với các ứng dụng khác với firmware khác vì nó dựa trên nền tảng phổ biến Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Thiết kế phần cứng sẽ (tương tự như [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) tích hợp SoC ESP32-S3 cho WiFi, BLE và [nhận diện từ khóa đánh thức trên bo mạch](https://www.home-assistant.io/voice_control/about_wake_word/) (sử dụng firmware [ESPHome không cần code](https://esphome.io/)) + chip XMOS xCORE XU316 cho xử lý âm thanh nâng cao (với firmware tùy chỉnh dùng để xử lý tín hiệu micro nhằm cải thiện khả năng nhận diện giọng nói nhờ các thuật toán chạy cục bộ cho loại bỏ tiếng ồn, khử vọng âm, khử nhiễu, và tự động điều chỉnh biên độ).

Về tính năng, phần cứng này được thiết kế tương thích chủ yếu với [Home Assistant Voice Preview Edition (hay Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (đã được phát hành dưới dạng thiết kế phần cứng mã nguồn mở bởi Open Home Foundation hợp tác với Nabu Casa). Khác biệt chính sẽ do các giới hạn về vỏ máy và linh kiện của Google Nest Mini, (tức là thiết kế phần cứng của dự án nest-mini-drop-in-pcb cũng sẽ bị giới hạn bởi các đầu vào vật lý tương tự như phần cứng gốc của Google).

Vì vậy phạm vi của dự án/kho lưu trữ này không nhằm phát triển các tính năng/chức năng mới cho firmware ESPHome, nếu bạn muốn các chức năng đó, bạn cần tham gia phát triển firmware của Home Assistant Voice Preview Edition cũng như mã nguồn chính của ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Lời mời hợp tác

Nếu bạn có kinh nghiệm thiết kế bố trí PCB, (đặc biệt là về đi dây PCB, đổ đồng, hoặc bố trí digital+analog nhạy cảm với nhiễu), **rất mong nhận được sự hỗ trợ của bạn**! Hãy tự do mở issue mới, gửi đề xuất/yêu cầu, đóng góp ý kiến/phản hồi cho các vấn đề hiện có, hoặc fork kho lưu trữ này.

Để biết thêm thông tin về ý tưởng/khái niệm, hãy xem và đóng góp vào cuộc thảo luận liên quan tại chủ đề diễn đàn cộng đồng Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Trạng thái hiện tại

- ✅ Hoàn thành sơ đồ mạch
- ✅ Đã bố trí linh kiện
- ✅ Đã đi dây mạch
- ✅ Đã hoàn thành đổ đồng, chiến lược che chắn và xem xét EMI
- ⚠️ Lô thử nghiệm đầu tiên thất bại do hai lỗi - đã khắc phục
- 🕓 Đang chờ lô thử nghiệm lần 2

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## Công cụ sử dụng

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC để tìm nguồn footprint

## Thông số kỹ thuật phần cứng đã biết

- PCB 4 lớp
- Chip trần ESP32-S3R8 (ESP32-S3 cho WiFi, BLE và phát hiện từ khóa trên bo mạch)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP xử lý âm thanh)
- Hai bộ nhớ flash SPI (do ESP32 và XMOS có flash SPI riêng)
- Hai bus I²S (cho phép các giao diện I2S hoạt động đồng thời, ví dụ xuất âm thanh và nhập âm thanh cùng lúc)
- MAX98357 cho đầu ra loa (Mạch khuếch đại âm thanh Mono Class-D I2S)
- 2x micro MEMS (đôi MMICT390200012 với khoảng cách giữa hai mic là 68mm)
- 6x đèn LED RGB SK6812
- Đầu vào USB-C và nguồn 14V tùy chỉnh (Lưu ý! Không thể kết nối đồng thời USB-C và jack nguồn tròn)

---

> ⚠️ Nạp firmware qua USB-C yêu cầu ngắt kết nối nguồn đầu vào 14V chính. Xem ghi chú silkscreen trên PCB để biết chi tiết.

## Tài liệu tham khảo

### Tài nguyên Home Assistant Voice Preview Edition bao gồm các tập tin thiết kế PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome cho Home Assistant Voice PE (cũng sử dụng kết hợp ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### Chip MCU XMOS xCORE DSP (XU316-1024-QF60B-C32)

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Firmware XMOS từ dự án ESPHome cho phần cứng Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Giấy phép

Dự án này được cấp phép theo [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Mọi phiên bản sửa đổi của phần cứng này cũng phải được phân phối theo cùng giấy phép.

☕ Nếu bạn muốn ủng hộ dự án này, hãy [mua cho tôi một ly cà phê trên Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---