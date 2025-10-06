<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

# MiciMike แผงวงจร PCB แบบเปลี่ยนได้สำหรับ Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) คือแผงวงจร PCB แบบเปลี่ยนได้สำหรับ ["Google Nest Mini" (ลำโพงอัจฉริยะรุ่นที่สองของ Google ที่ใช้พอร์ตชาร์จแบบหัวกลม)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)) แต่ใช้ไมโครคอนโทรลเลอร์ ESP32 และ XMOS สำหรับรันเฟิร์มแวร์โอเพ่นซอร์ส

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

คำแนะนำ! หากคุณกำลังมองหาแผงวงจร PCB แบบเปลี่ยนได้สำหรับ "Google Home Mini" (ฮาร์ดแวร์ลำโพงอัจฉริยะรุ่นแรกของ Google ที่ใช้พอร์ตชาร์จแบบ Micro-USB) กรุณาดูโครงการที่เกี่ยวข้องที่ https://github.com/iMike78/home-mini-v1-drop-in-pcb


โครงการทั้งสองนี้เป็นโปรเจกต์ฮาร์ดแวร์โอเพนซอร์สทั้งหมด โดยได้รับแรงบันดาลใจบางส่วนจาก [Onju Voice](https://github.com/justLV/onju-voice) แต่ตั้งเป้าหมายเพื่อปฏิบัติตาม [มาตรฐานผู้ช่วยเสียงโอเพนซอร์สของ Open Home Foundation โดยอ้างอิงจาก Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) สำหรับการออกแบบและข้อกำหนด PCB

# ขอบเขตโครงการ

เป้าหมายของโครงการและคลังนี้ (ซึ่งคล้ายกับ [Onju Voice](https://github.com/justLV/onju-voice) แต่ภายใต้สัญญาอนุญาตฮาร์ดแวร์โอเพนซอร์สเต็มรูปแบบ) คือการออกแบบแผงวงจรพิมพ์ (PCB) ทดแทนที่สามารถสร้าง/ประกอบหรือสั่งผลิตจากโรงงาน PCB แบบครบวงจรเป็นแผงวงจรทดแทนสำหรับ Google Nest Mini (รุ่นที่ 2)

กลุ่มเป้าหมายหลักคือผู้ที่ต้องการแปลง/นำลำโพงอัจฉริยะ Google Nest Mini รุ่นเก่าของตนมาใช้งานกับฮาร์ดแวร์โอเพนซอร์สสำหรับ [การควบคุมเสียงของ Home Assistant](https://www.home-assistant.io/voice_control/) และ/หรือใช้งานเป็นลำโพงสำหรับ [Music Assistant](https://www.music-assistant.io) (อย่างไรก็ตาม ฮาร์ดแวร์นี้อาจนำไปใช้กับแอปพลิเคชันอื่น ๆ ได้เช่นกันด้วยเฟิร์มแวร์อื่น เนื่องจากเป็นแพลตฟอร์ม Espressif ESP32 ที่ได้รับความนิยม)

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

การออกแบบฮาร์ดแวร์จะรวม ESP32-S3 SoC สำหรับ WiFi, BLE และ [การตรวจจับคำปลุกบนบอร์ด](https://www.home-assistant.io/voice_control/about_wake_word/) (ใช้เฟิร์มแวร์ [ESPHome แบบไม่ต้องเขียนโค้ด](https://esphome.io/)) + ชิป XMOS xCORE XU316 สำหรับการประมวลผลเสียงขั้นสูง (พร้อมเฟิร์มแวร์แบบกำหนดเองสำหรับการปรับปรุงไมโครโฟนเพื่อเพิ่มประสิทธิภาพการรู้จำเสียง โดยใช้อัลกอริทึมในเครื่องสำหรับการลดเสียงรบกวน, การตัดเสียงสะท้อน, การตัดสัญญาณรบกวน และการปรับระดับเสียงอัตโนมัติ)

ในด้านฟังก์ชันการทำงาน จะออกแบบให้ส่วนใหญ่มาตรฐานฮาร์ดแวร์ใกล้เคียงกับ [Home Assistant Voice Preview Edition (หรือ Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) อ้างอิง (ซึ่งถูกปล่อยเป็นฮาร์ดแวร์โอเพนซอร์สโดย Open Home Foundation ร่วมกับ Nabu Casa) ความแตกต่างหลักจะเกิดจากข้อจำกัดของตัวกล่องและชิ้นส่วนของ Google Nest Mini (เช่น การออกแบบฮาร์ดแวร์ nest-mini-drop-in-pcb จะจำกัดด้วยอินพุตขนาดเดียวกับฮาร์ดแวร์ต้นแบบจาก Google)

ดังนั้นขอบเขตของโครงการ/คลังนี้ไม่รวมถึงการพัฒนาฟีเจอร์/ฟังก์ชันใหม่สำหรับเฟิร์มแวร์ ESPHome หากต้องการให้พัฒนาฟีเจอร์เฟิร์มแวร์ ต้องไปที่การพัฒนาเฟิร์มแวร์ของ Home Assistant Voice Preview Edition รวมถึงโค้ดหลักของ ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## ขอเชิญร่วมมือ

หากคุณมีประสบการณ์ด้านออกแบบ PCB (โดยเฉพาะการเดินสาย PCB, การเทกราวด์ หรือการออกแบบที่มีสัญญาณดิจิทัล+แอนะล็อกไวต่อสัญญาณรบกวน) **ขอขอบคุณสำหรับความช่วยเหลือของคุณ!** สามารถเปิด issue ใหม่, เสนอแนะ/ขอสิ่งที่ต้องการ, แสดงความคิดเห็น/ข้อเสนอแนะใน issue ที่มีอยู่ หรือ fork คลังนี้ได้ตามสะดวก

สำหรับข้อมูลเพิ่มเติมเกี่ยวกับแนวคิด/ไอเดีย ดูและร่วมสนทนาในกระทู้ฟอรั่ม Home Assistant community นี้:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### สถานะล่าสุด

- ✅ เสร็จสิ้นการออกแบบวงจร
- ✅ เสร็จสิ้นการจัดวางชิ้นส่วน
- ✅ เดินสายเรียบร้อยแล้ว
- ✅ เทกราวด์ วางแผนการป้องกัน และพิจารณา EMI เรียบร้อย
- ⚠️ ชุดทดสอบแรกไม่ผ่าน 2 จุด - ได้แก้ไขแล้ว
- 🕓 รอชุดทดสอบที่สอง

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## เครื่องมือที่ใช้

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC สำหรับการค้นหา footprint

## ข้อมูลจำเพาะของฮาร์ดแวร์ที่ทราบ

- แผงวงจร PCB 4 ชั้น
- ชิปเปลือย ESP32-S3R8 (ESP32-S3 สำหรับ WiFi, BLE และการตรวจจับ wake-word บนบอร์ด)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP สำหรับประมวลผลเสียง)
- แฟลช SPI คู่
- บัส I²S คู่ (เพื่อให้รองรับอินเทอร์เฟซ I2S พร้อมกัน เช่น เล่นเสียงและรับเสียงไปพร้อมกัน)
- MAX98357 สำหรับขับเสียงลำโพง (I2S Class-D Mono Audio Amplifier)
- ไมโครโฟน MEMS 2 ตัว (MSM261DHP)
- ไฟ LED SK6812
- อินพุตพลังงาน USB-C และ 14V แบบกำหนดเอง

---

> ⚠️ การแฟลชผ่าน USB-C จำเป็นต้องถอดแหล่งจ่ายไฟหลัก 14V ออกก่อน ดูรายละเอียดจากข้อความบน PCB

## แหล่งอ้างอิง

### แหล่งข้อมูล Home Assistant Voice Preview Edition รวมถึงไฟล์ออกแบบ PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### เฟิร์มแวร์ ESPHome สำหรับ Home Assistant Voice PE (ที่ใช้ ESP32-S3 + XMOS XU316 เหมือนกัน):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### ชิป IC XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### เฟิร์มแวร์ XMOS จากโปรเจกต์ ESPHome สำหรับฮาร์ดแวร์ Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## ใบอนุญาต

โปรเจกต์นี้ได้รับอนุญาตภายใต้ [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
ฮาร์ดแวร์เวอร์ชันที่แก้ไขแล้วจะต้องเผยแพร่ภายใต้ใบอนุญาตเดียวกันด้วย

☕ หากคุณต้องการสนับสนุนโปรเจกต์นี้ สามารถ [ซื้อกาแฟให้ฉันบน Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---