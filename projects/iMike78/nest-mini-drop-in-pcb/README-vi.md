
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
**Lưu ý!** Hiện tại đang có một chiến dịch gọi vốn cộng đồng cho "MiciMike Home Mini Drop-In PCB" (Google Home Mini thế hệ 1) đang được mở bán trước trên Crowd Supply (chỉ xem trước dự án), nếu thành công sẽ lên kế hoạch cho chiến dịch tương tự cho Nest Mini (thế hệ 2) mới hơn, hãy xem thông tin tại đây và ủng hộ dự án này gián tiếp bằng cách đặt mua nếu có thể:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Cả hai dự án này đều là phần cứng mã nguồn mở hoàn toàn, lấy cảm hứng ý tưởng từ [Onju Voice](https://github.com/justLV/onju-voice) nhưng hướng tới tuân thủ [tiêu chuẩn trợ lý giọng nói mở của Open Home Foundation, lấy Home Assistant Voice Preview Edition làm tham chiếu](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) cho thiết kế và thông số kỹ thuật PCB.

# Phạm vi dự án

Mục tiêu của dự án và kho lưu trữ này (tương tự như [Onju Voice](https://github.com/justLV/onju-voice) nhưng theo giấy phép phần cứng mã nguồn mở hoàn toàn) là thiết kế một bo mạch PCB thay thế (Bo mạch in - Printed Circuit Board) cùng sơ đồ phần cứng để bất kỳ ai cũng có thể tự chế tạo/lắp ráp hoặc đặt hàng từ nhà sản xuất PCB như một sản phẩm tùy chỉnh cho Google Nest Mini (thế hệ 2).

Đối tượng chính là những người muốn chuyển đổi/tái sử dụng loa thông minh Google Nest Mini cũ thành phần cứng mã nguồn mở cho [Điều khiển bằng giọng nói của Home Assistant](https://www.home-assistant.io/voice_control/) và/hoặc xuất âm thanh cho [Music Assistant](https://www.music-assistant.io), (tuy nhiên phần cứng này cũng có thể dùng cho các ứng dụng khác với firmware khác, vì nó dựa trên nền tảng Espressif ESP32 phổ biến).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="First test PCB">

Thiết kế phần cứng sẽ (tương tự như [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) tích hợp SoC ESP32-S3 cho WiFi, BLE, và [phát hiện từ khóa đánh thức trên bo mạch](https://www.home-assistant.io/voice_control/about_wake_word/) (sử dụng firmware [ESPHome không cần code](https://esphome.io/)) + chip XMOS xCORE XU316 cho xử lý âm thanh nâng cao (với firmware tùy chỉnh để lọc tiếng ồn micro, giúp nhận diện giọng nói tốt hơn nhờ các thuật toán xử lý tại chỗ như Khử ồn, Khử vọng âm, Loại bỏ nhiễu, và Tự động điều chỉnh âm lượng).

Về tính năng, phần cứng này được thiết kế tương thích phần lớn với [Home Assistant Voice Preview Edition (hay Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) theo thiết kế tham chiếu (đã được phát hành dưới dạng phần cứng mã nguồn mở bởi Open Home Foundation phối hợp cùng Nabu Casa). Khác biệt chính là các giới hạn do vỏ ngoài và linh kiện của Google Nest Mini (tức là phần cứng nest-mini-drop-in-pcb sẽ bị giới hạn bởi các đầu vào vật lý như thiết bị gốc của Google).

Do đó, phạm vi của dự án/kho lưu trữ này không nhằm phát triển tính năng/chức năng mới cho firmware ESPHome, nếu bạn muốn phát triển thêm thì hãy tham gia vào phát triển firmware cho Home Assistant Voice Preview Edition cũng như mã nguồn chính của ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Kêu gọi hợp tác

Nếu bạn có kinh nghiệm về thiết kế layout PCB, (đặc biệt là routing PCB, đổ lớp đất, hoặc thiết kế digital+analog nhạy cảm nhiễu), **rất mong nhận được sự giúp đỡ của bạn**! Hãy tự do mở issue mới, gửi đề xuất/yêu cầu, góp ý vào các issue hiện có, hoặc fork kho lưu trữ này.

Để biết thêm thông tin về ý tưởng/khái niệm và tham gia thảo luận, hãy xem chủ đề trên diễn đàn cộng đồng Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Trạng thái hiện tại

- ✅ Đã hoàn tất sơ đồ mạch
- ✅ Đã bố trí linh kiện
- ✅ Đã hoàn tất routing
- ✅ Đã hoàn tất đổ lớp đất, chiến lược che chắn và xem xét EMI
- ⛔ Lô thử nghiệm đầu tiên thất bại do hai lỗi - đã sửa

- ⚠️ Lô thử nghiệm thứ 2 hoạt động một phần
- ✅ Đã thêm tùy chọn debug XTAG4 cho lô tiếp theo

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## Các công cụ sử dụng

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC để tìm kiếm footprint

## Thông số phần cứng đã biết

- PCB 4 lớp
- Chip ESP32-S3R8 trần (ESP32-S3 dùng cho WiFi, BLE và phát hiện từ đánh thức trên bo mạch)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP xử lý âm thanh)
- Bộ nhớ SPI flash 16 MB (ESP32-S3)
- Bộ nhớ SPI flash 4 MB (XMOS XU316)
- Hai bus I²S (đầu vào và đầu ra âm thanh đồng thời)
- TAS5805M (TAS5805MPWPR) ampli stereo Class-D tích hợp DSP (âm thanh I2S, điều khiển I2C), cấu hình cho đầu ra loa mono BTL
- 3 micro MEMS (MMICT390200012) sắp xếp trên một cung bán kính 34 mm - firmware hiện tại sử dụng 2 micro, phần cứng đã hỗ trợ mảng 3 micro
- 6 đèn LED RGB SK6812
- Đầu vào nguồn USB-C và 14V tùy chỉnh (Lưu ý! USB-C và đầu nối thùng không thể kết nối cùng lúc)
- Bộ điều khiển cảm ứng điện dung MPR121 (dùng cho đầu vào cảm ứng thay vì cảm ứng điện dung gốc của ESP32-S3)

---

> ⚠️ Nạp firmware qua USB-C yêu cầu ngắt kết nối nguồn chính 14V. Xem ghi chú silkscreen trên PCB để biết chi tiết.

## Tham khảo

### Tài nguyên Home Assistant Voice Preview Edition bao gồm tệp thiết kế PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome cho Home Assistant Voice PE (cũng sử dụng cùng ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### Vi xử lý XMOS xCORE DSP (XU316-1024-QF60B-C24) MCU IC chip

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

Dự án này được cấp phép theo [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Bất kỳ phiên bản chỉnh sửa nào của phần cứng này cũng phải được phân phối theo cùng giấy phép.

☕ Nếu bạn muốn hỗ trợ dự án này, hãy [mua cho tôi một ly cà phê trên Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---