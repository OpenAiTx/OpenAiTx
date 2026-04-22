
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

**Lưu ý!** Chiến dịch gọi vốn cộng đồng sắp tới cho "MiciMike Home Mini Drop-In PCB" (bản Google Home Mini thế hệ 1) hiện đã được liệt kê trong giai đoạn tiền ra mắt trên Crowd Supply (chỉ xem trước dự án), và nếu thành công sẽ lên kế hoạch cho chiến dịch tương tự cho Nest Mini, hãy xem chi tiết tại đây:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Cả hai đều là dự án phần cứng mã nguồn mở hoàn toàn, lấy cảm hứng ý tưởng từ [Onju Voice](https://github.com/justLV/onju-voice) nhưng hướng tới tuân thủ [tiêu chuẩn trợ lý giọng nói mở của Open Home Foundation với Home Assistant Voice Preview Edition làm tham chiếu](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) cho thiết kế và thông số kỹ thuật của PCB.

# Phạm vi dự án

Mục tiêu của dự án và kho lưu trữ này (tương tự như [Onju Voice](https://github.com/justLV/onju-voice) nhưng theo giấy phép phần cứng mã nguồn mở hoàn toàn) là thiết kế một bo mạch PCB thay thế (Bo mạch mạch in) với sơ đồ phần cứng mà bất kỳ ai cũng có thể tự làm/xây dựng hoặc đặt hàng từ nhà sản xuất PCB như một linh kiện thay thế tùy chỉnh cho Google Nest Mini (thế hệ 2).

Dự án chủ yếu dành cho những người muốn chuyển đổi/tái sử dụng loa thông minh Google Nest Mini cũ thành phần cứng mã nguồn mở cho [Điều khiển giọng nói Home Assistant](https://www.home-assistant.io/voice_control/) và/hoặc loa xuất âm thanh cho [Music Assistant](https://www.music-assistant.io), (tuy nhiên phần cứng này cũng có thể dùng cho các ứng dụng khác với firmware khác vì nó dựa trên nền tảng Espressif ESP32 phổ biến).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Thiết kế phần cứng sẽ (tương tự như [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) tích hợp SoC ESP32-S3 cho WiFi, BLE, và [phát hiện từ khóa đánh thức tích hợp](https://www.home-assistant.io/voice_control/about_wake_word/) (sử dụng firmware [ESPHome không cần mã](https://esphome.io/)) + chip XMOS xCORE XU316 để xử lý âm thanh nâng cao (với firmware tùy chỉnh cho xử lý tín hiệu microphone, giúp nhận dạng giọng nói tốt hơn nhờ các thuật toán nội bộ như Khử ồn, Khử vọng âm thanh, Khử nhiễu và Tự động điều chỉnh âm lượng).

Về chức năng, phần cứng này được thiết kế để tương thích phần lớn với thiết kế tham chiếu [Home Assistant Voice Preview Edition (hay Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) đã được phát hành dưới dạng phần cứng mã nguồn mở bởi Open Home Foundation hợp tác cùng Nabu Casa). Khác biệt chính là các giới hạn do vỏ và linh kiện Google Nest Mini quy định, (tức là thiết kế phần cứng dự án nest-mini-drop-in-pcb sẽ bị giới hạn bởi các đầu vào vật lý tương tự như phần cứng gốc của Google).

Do đó phạm vi của dự án/kho này không phải là phát triển tính năng/chức năng mới cho firmware ESPHome, nên nếu bạn muốn điều này thì hãy chuyển sang phát triển firmware của Home Assistant Voice Preview Edition cũng như mã nguồn chính của ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Kêu gọi hợp tác

Nếu bạn có kinh nghiệm về thiết kế bố trí PCB, (đặc biệt là về đi dây, đổ nền, hoặc thiết kế layout số + tương tự nhạy nhiễu), **sự giúp đỡ của bạn rất được hoan nghênh**! Hãy thoải mái mở issue mới, gửi đề xuất/yêu cầu, đóng góp ý kiến/phản hồi cho các issue hiện có, hoặc fork kho này.

Để biết thêm thông tin về ý tưởng khái niệm, xem và đóng góp cho thảo luận liên quan tại chủ đề trên diễn đàn cộng đồng Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Tình trạng hiện tại

- ✅ Đã hoàn thành sơ đồ mạch
- ✅ Đã đặt xong linh kiện
- ✅ Đã hoàn thành đi dây
- ✅ Đã hoàn thành đổ nền, chiến lược che chắn và xem xét EMI
- ⚠️ Lô thử nghiệm đầu tiên thất bại do hai lỗi - đã sửa
- 🕓 đang chờ lô kiểm tra thứ hai

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Công cụ đã sử dụng

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC để lấy footprint

## Thông số phần cứng đã biết

- PCB 4 lớp
- Chip trần ESP32-S3R8 (ESP32-S3 cho WiFi, BLE và nhận diện từ khóa đánh thức tích hợp)
- XMOS XU316-1024-QF60B-C24 (xử lý âm thanh DSP xCORE XMOS XU316)
- Flash SPI kép (vì ESP32 và XMOS đều có flash SPI riêng)
- Hai bus I²S (để cho phép giao diện I2S đồng thời, ví dụ xuất âm thanh và nhập âm thanh cùng lúc)
- TAS5805M (TAS5805MPWPR) cho đầu ra loa (Khuếch đại âm thanh Class-D Mono I2S với cấu hình DSP qua I2C)
- 2 micro MEMS (kép MMICT390200012 với khoảng cách giữa hai micro là 68mm)
- 6 đèn LED RGB SK6812
- Đầu vào nguồn USB-C và 14V tùy chỉnh (Lưu ý! Không được kết nối USB-C và jack nguồn cùng lúc)

---

> ⚠️ Nạp firmware qua USB-C yêu cầu phải ngắt nguồn chính 14V. Xem ghi chú silkscreen trên PCB để biết chi tiết.

## Tham khảo

### Tài nguyên Home Assistant Voice Preview Edition bao gồm file thiết kế PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome cho Home Assistant Voice PE (cũng dùng kết hợp ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### Vi điều khiển XMOS xCORE DSP (XU316-1024-QF60B-C32)

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
Bất kỳ phiên bản sửa đổi nào của phần cứng này cũng phải được phân phối theo cùng giấy phép.

☕ Nếu bạn muốn ủng hộ dự án này, hãy [mua cho tôi một ly cà phê trên Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---