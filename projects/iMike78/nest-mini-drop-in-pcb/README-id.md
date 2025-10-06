
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

# Pengganti PCB drop-in MiciMike untuk Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) adalah pengganti PCB drop-in untuk ["Google Nest Mini" (smart speaker generasi kedua dari Google dengan port pengisian daya konektor barel)](https://id.wikipedia.org/wiki/Google_Nest_(smart_speakers)), namun berbasis pada mikrokontroler ESP32 dan XMOS untuk menjalankan firmware open-source.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Tip! Jika Anda mencari pengganti PCB drop-in serupa untuk "Google Home Mini" (hardware smart speaker generasi pertama Google dengan port pengisian daya Micro-USB), silakan lihat proyek saudara di https://github.com/iMike78/home-mini-v1-drop-in-pcb

Kedua proyek ini adalah proyek perangkat keras open-source sepenuhnya, mengambil inspirasi konsep dari [Onju Voice](https://github.com/justLV/onju-voice) namun bertujuan mengikuti [standar asisten suara open-source Open Home Foundation dengan Home Assistant Voice Preview Edition sebagai referensi](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) untuk desain dan spesifikasi PCB.

# Ruang lingkup proyek

Tujuan dari proyek dan repositori ini (yang mirip dengan [Onju Voice](https://github.com/justLV/onju-voice) namun di bawah lisensi perangkat keras open-source sepenuhnya) adalah merancang PCB (Printed Circuit Board) pengganti drop-in dengan skematik perangkat keras yang dapat dibuat/dibangun atau dipesan oleh siapa saja dari produsen PCB satu pintu sebagai PCB pengganti khusus untuk Google Nest Mini (Gen 2).

Ini terutama ditujukan bagi orang yang ingin mengonversi/mengubah speaker pintar Google Nest Mini lama mereka menjadi perangkat keras open-source untuk [Kontrol Suara Home Assistant](https://www.home-assistant.io/voice_control/) dan/atau output speaker media player untuk [Music Assistant](https://www.music-assistant.io), (namun perangkat keras ini kemungkinan juga bisa digunakan untuk aplikasi lain dengan firmware berbeda karena berbasis pada platform populer Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Desain perangkat keras ini (mirip dengan [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) akan mengintegrasikan ESP32-S3 SoC untuk WiFi, BLE, dan [deteksi wake-word onboard](https://www.home-assistant.io/voice_control/about_wake_word/) (menggunakan firmware tanpa kode [ESPHome](https://esphome.io/)) + chip XMOS xCORE XU316 untuk pemrosesan audio lanjutan (dengan firmware khusus untuk pembersihan mikrofon yang dialihkan untuk meningkatkan kemampuan pengenalan suara menggunakan algoritma lokal untuk Noise Suppression, Acoustic Echo Cancellation, Interference Cancellation, dan Automatic Gain Control).

Dari sisi fungsionalitas, perangkat keras ini dibuat agar sebagian besar kompatibel dengan referensi desain [Home Assistant Voice Preview Edition (alias Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (yang telah dirilis sebagai desain perangkat keras open-source dari Open Home Foundation bekerja sama dengan Nabu Casa). Perbedaan utama akan disebabkan oleh batasan yang ditentukan oleh cangkang dan komponen Google Nest Mini, (yaitu desain perangkat keras nest-mini-drop-in-pcb proyek akan dibatasi oleh jenis input kapasitas fisik yang sama seperti perangkat keras asli Google).

Dengan demikian ruang lingkup proyek/repositori ini bukan untuk mengembangkan fitur/fungsi baru untuk firmware ESPHome, jadi jika Anda menginginkan itu maka Anda perlu beralih ke pengembangan firmware Home Assistant Voice Preview Edition serta ke kode utama ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Permintaan kolaborasi

Jika Anda memiliki pengalaman dalam desain layout PCB, (dan terutama dengan routing PCB, ground pouring, atau layout digital+analog yang sensitif terhadap noise), **bantuan Anda sangat dihargai**! Silakan buka issue baru, ajukan saran/permintaan, dan tambahkan masukan/umpan balik pada issue yang sudah ada, atau fork repositori ini.

Untuk informasi lebih lanjut tentang konsep/ide silakan lihat dan berkontribusi pada diskusi terkait juga di thread forum komunitas Home Assistant berikut:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Status terkini

- ✅ Skematik selesai
- ✅ Penempatan komponen selesai
- ✅ Routing selesai
- ✅ Ground pour, strategi shielding, dan pertimbangan EMI selesai
- ⚠️ Batch uji coba pertama gagal pada dua error - sudah diperbaiki
- 🕓 menunggu batch uji coba kedua

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Tools yang digunakan

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC untuk sumber footprint

## Spesifikasi perangkat keras yang diketahui

- PCB 4 lapis
- Chip ESP32-S3R8 bare (ESP32-S3 untuk WiFi, BLE, dan deteksi kata bangun onboard)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP pemrosesan audio)
- Dual SPI flash
- Dual bus I²S (untuk memungkinkan antarmuka I2S secara bersamaan, yaitu output audio dan input audio simultan)
- MAX98357 untuk output speaker (I2S Class-D Mono Audio Amplifier)
- 2x mikrofon MEMS (MSM261DHP)
- LED SK6812
- Input daya USB-C dan 14V khusus

---

> ⚠️ Melakukan flashing via USB-C membutuhkan pemutusan input daya utama 14V. Lihat catatan silkscreen pada PCB untuk detailnya.

## Referensi

### Sumber daya Home Assistant Voice Preview Edition termasuk file desain PCB
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Firmware ESPHome untuk Home Assistant Voice PE (yang juga menggunakan kombinasi ESP32-S3 + XMOS XU316 yang sama):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) chip IC MCU

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Firmware XMOS dari proyek ESPHome untuk perangkat Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Lisensi

Proyek ini dilisensikan di bawah [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Setiap versi modifikasi dari perangkat keras ini juga harus didistribusikan di bawah lisensi yang sama.

☕ Jika Anda ingin mendukung proyek ini, silakan [beli saya kopi di Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---