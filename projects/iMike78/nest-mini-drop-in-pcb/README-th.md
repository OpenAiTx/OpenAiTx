
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">อังกฤษ</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">ญี่ปุ่น</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">เกาหลี</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">ฮินดี</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">ฝรั่งเศส</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">เยอรมัน</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">สเปน</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">อิตาลี</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">รัสเซีย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">โปรตุเกส</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">ดัตช์</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">โปแลนด์</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">อาหรับ</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">เปอร์เซีย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">ตุรกี</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">เวียดนาม</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">อินโดนีเซีย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">อัสสัม</
      </div>
    </div>
  </details>

</div>

# MiciMike แผงวงจรพิมพ์ทดแทนสำหรับ Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) คือแผงวงจรพิมพ์ (PCB) ทดแทนสำหรับ ["Google Nest Mini" (ลำโพงอัจฉริยะรุ่นที่สองของ Google ที่ใช้พอร์ตชาร์จแบบหัวกลม)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)) ซึ่งใช้ไมโครคอนโทรลเลอร์ ESP32 และ XMOS สำหรับรันเฟิร์มแวร์โอเพ่นซอร์ส

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

เคล็ดลับ! หากคุณกำลังมองหาแผงวงจรพิมพ์ทดแทนแบบเดียวกันสำหรับ "Google Home Mini" (ลำโพงอัจฉริยะรุ่นแรกของ Google ที่ใช้พอร์ตชาร์จแบบ Micro-USB) กรุณาดูโปรเจกต์คู่กันที่ https://github.com/iMike78/home-mini-v1-drop-in-pcb
ทั้งสองโปรเจกต์นี้เป็นโครงการฮาร์ดแวร์โอเพนซอร์สเต็มรูปแบบ โดยได้แรงบันดาลใจบางส่วนจาก [Onju Voice](https://github.com/justLV/onju-voice) แต่มีเป้าหมายเพื่อปฏิบัติตาม [มาตรฐานผู้ช่วยเสียงโอเพนซอร์สของ Open Home Foundation โดยอ้างอิง Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) สำหรับการออกแบบและข้อกำหนดของ PCB

# ขอบเขตของโปรเจกต์

เป้าหมายของโปรเจกต์และที่เก็บนี้ (ซึ่งคล้ายกับ [Onju Voice](https://github.com/justLV/onju-voice) แต่ใช้สัญญาอนุญาตฮาร์ดแวร์โอเพนซอร์สอย่างสมบูรณ์) คือออกแบบแผงวงจรพิมพ์ (PCB) ที่เป็นตัวแทนแบบ drop-in พร้อมทั้งแผนผังวงจรที่ใครๆ ก็สามารถสร้าง/ประกอบหรือสั่งซื้อจากผู้ผลิต PCB แบบครบวงจรได้ เพื่อใช้แทนแผงวงจรของ Google Nest Mini (รุ่นที่ 2)

กลุ่มเป้าหมายหลักคือผู้ที่ต้องการดัดแปลง/นำ Google Nest Mini ลำโพงอัจฉริยะรุ่นเก่ากลับมาใช้ใหม่เป็นฮาร์ดแวร์โอเพนซอร์สสำหรับ [การควบคุมเสียง Home Assistant](https://www.home-assistant.io/voice_control/) และ/หรือใช้งานเป็นลำโพงเอาต์พุตสำหรับ [Music Assistant](https://www.music-assistant.io) (อย่างไรก็ตาม ฮาร์ดแวร์นี้สามารถนำไปใช้กับแอปพลิเคชันอื่นๆ ได้อีกด้วย เพียงเปลี่ยนเฟิร์มแวร์ เนื่องจากใช้แพลตฟอร์ม Espressif ESP32 ที่เป็นที่นิยม)

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

การออกแบบฮาร์ดแวร์จะ (คล้ายกับ [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) ผนวกรวม ESP32-S3 SoC สำหรับ WiFi, BLE และ [การตรวจจับคำปลุกในตัว](https://www.home-assistant.io/voice_control/about_wake_word/) (ด้วย [เฟิร์มแวร์ ESPHome แบบไม่ต้องเขียนโค้ด](https://esphome.io/)) + ชิป XMOS xCORE XU316 สำหรับประมวลผลเสียงขั้นสูง (ด้วยเฟิร์มแวร์เฉพาะ เพื่อจัดการสัญญาณไมโครโฟนให้เสียงพูดชัดเจนขึ้นผ่านอัลกอริทึม Noise Suppression, Acoustic Echo Cancellation, Interference Cancellation และ Automatic Gain Control ที่ทำงานภายในเครื่อง)

ในแง่ของฟังก์ชันการทำงานจะถูกออกแบบมาให้เข้ากันได้กับฮาร์ดแวร์อ้างอิง [Home Assistant Voice Preview Edition (หรือ Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (ซึ่งเผยแพร่เป็นฮาร์ดแวร์โอเพนซอร์สโดย Open Home Foundation ร่วมกับ Nabu Casa) ความแตกต่างหลักจะเป็นข้อจำกัดจากตัวกล่องและส่วนประกอบของ Google Nest Mini (เช่น โปรเจกต์ nest-mini-drop-in-pcb จะจำกัดปุ่มและอินพุตเท่าที่ฮาร์ดแวร์ต้นฉบับของ Google มี)

ดังนั้นขอบเขตของโปรเจกต์/ที่เก็บนี้จะไม่พัฒนาเฟิร์มแวร์ ESPHome ใหม่ หากต้องการฟีเจอร์ใหม่ กรุณาร่วมพัฒนากับโครงการ Home Assistant Voice Preview Edition และโค้ดต้นน้ำ ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## ขอเชิญร่วมมือ

หากคุณมีประสบการณ์กับการออกแบบเลย์เอาต์ PCB (โดยเฉพาะการเดินลายวงจร, การเทกราวด์, หรือเลย์เอาต์ดิจิทัล+อนาล็อกที่ไวต่อสัญญาณรบกวน) **ขอความร่วมมือจากคุณเป็นอย่างยิ่ง**! คุณสามารถเปิด issue ใหม่ เสนอคำแนะนำ/ร้องขอ หรือแสดงความคิดเห็นกับ issue เดิม หรือ fork repository นี้ได้เลย

สำหรับข้อมูลแนวคิดเพิ่มเติมหรือร่วมพูดคุย อ่านและมีส่วนร่วมในหัวข้อฟอรั่มของ Home Assistant ดังนี้:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### สถานะปัจจุบัน

- ✅ วาดวงจรเสร็จสมบูรณ์
- ✅ วางตำแหน่งชิ้นส่วนเสร็จสมบูรณ์
- ✅ เดินลายวงจรเสร็จสมบูรณ์
- ✅ เทกราวด์ วางแผนการชีลด์ และพิจารณา EMI แล้ว
- ⚠️ ชุดทดสอบแรกผิดพลาด 2 จุด - แก้ไขแล้ว
- 🕓 รอชุดทดสอบที่ 2

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## เครื่องมือที่ใช้

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC สำหรับการค้นหา footprint

## ข้อมูลจำเพาะของฮาร์ดแวร์ที่ทราบ

- PCB แบบ 4 เลเยอร์
- ชิปเปล่า ESP32-S3R8 (ESP32-S3 สำหรับ WiFi, BLE, และการตรวจจับ wake-word บนบอร์ด)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP สำหรับประมวลผลเสียง)
- แฟลช SPI คู่ (ESP32 และ XMOS มีแฟลช SPI ของตนเอง)
- บัส I²S คู่ (เพื่อให้สามารถใช้ I2S หลายอินเทอร์เฟซพร้อมกัน เช่น ส่งออกและรับเสียงพร้อมกัน)
- MAX98357 สำหรับขับลำโพง (I2S Class-D Mono Audio Amplifier)
- ไมโครโฟน MEMS 2 ตัว (MMICT390200012 สองตัว ระยะห่างระหว่างไมค์ 68 มม.)
- ไฟ LED RGB SK6812 จำนวน 6 ดวง
- อินพุต USB-C แบบกำหนดเอง และไฟเข้า 14V (หมายเหตุ! ห้ามต่อ USB-C และแจ็คถังพร้อมกัน)

---

> ⚠️ การแฟลชผ่าน USB-C ต้องถอดปลั๊กไฟหลัก 14V ออกก่อน ดูข้อความบน silkscreen ที่ PCB สำหรับรายละเอียด

## แหล่งอ้างอิง

### แหล่งข้อมูล Home Assistant Voice Preview Edition รวมถึงไฟล์ออกแบบ PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### เฟิร์มแวร์ ESPHome สำหรับ Home Assistant Voice PE (ซึ่งใช้ชิป ESP32-S3 + XMOS XU316 เหมือนกัน):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### ชิป MCU XMOS xCORE DSP (XU316-1024-QF60B-C32)

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### เฟิร์มแวร์ XMOS จากโครงการ ESPHome สำหรับฮาร์ดแวร์ Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## ใบอนุญาต

โครงการนี้ได้รับอนุญาตภายใต้ [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
ฮาร์ดแวร์ที่ถูกปรับแต่งจะต้องเผยแพร่ภายใต้ใบอนุญาตเดียวกันนี้ด้วย

☕ หากคุณต้องการสนับสนุนโครงการนี้ สามารถ [ซื้อกาแฟให้ฉันที่ Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---