
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>

</div>

<div align="center"> 
    <br/>
    <p>
        <img src="https://github.com/neon443/AirAP/blob/main/Icon/icon.png?raw=true" title="icon" alt="icon" width="100" />
    </p>
    <p>
        ใช้ไอโฟนของคุณเป็นตัวรับ AirPlay
        <br/>
        <a href="https://neon443.github.io">
            สร้างโดย neon443
        </a>
    </p>
    <p>
        <a href="https://testflight.apple.com/join/8aeqD8Q2">
            testflight
        </a>
    </p>
    <br/>
</div>

<div align="center">
  <a href="https://shipwrecked.hackclub.com/?t=ghrm" target="_blank">
    <img src="https://github.com/neon443/AirAP/blob/main/Icon/shipwrecked.png?raw=true" 
         alt="โปรเจกต์นี้เป็นส่วนหนึ่งของ Shipwrecked, แฮกกาธอนแห่งแรกของโลกบนเกาะ!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP คือเซิร์ฟเวอร์ AirPlay แบบ native เต็มรูปแบบที่เขียนด้วยภาษา Swift สำหรับ iOS โดยพื้นฐานแล้ว AirAP ช่วยให้คุณใช้ iPhone เป็นตัวรับสัญญาณ AirPlay ใน iTunes หรือบน Mac ของคุณ หมายความว่าคุณสามารถใช้ iPhone เพื่อเล่นเสียงจากอุปกรณ์ของคุณได้

## AirAP คืออะไร?

คุณเคยอยากสตรีมเสียงจาก Mac, Apple TV, หรืออุปกรณ์ iOS อื่นไปยัง iPhone ของคุณไหม? AirAP ทำให้สิ่งนี้เป็นไปได้ด้วยการสร้างเซิร์ฟเวอร์ AirPlay เต็มรูปแบบที่รันแบบ native บน iOS เมื่อคุณติดตั้งแล้ว iPhone ของคุณจะปรากฏเป็นจุดหมาย AirPlay ที่เลือกได้ในแผงเสียงของ System Preferences, Music.app หรือแอปใด ๆ ที่รองรับ AirPlay

แนวคิดนี้อาจดูย้อนกลับในตอนแรก - เพราะเราคุ้นเคยกับการสตรีมจาก iPhone ไปยังอุปกรณ์อื่น ๆ แต่จริง ๆ แล้วมีหลายสถานการณ์ที่คุณอยากทำตรงกันข้าม เช่น คุณกำลังทำงานบน Mac ตอนกลางคืนและต้องการส่งเสียงไปยัง iPhone พร้อมหูฟังเพื่อไม่ให้รบกวนใคร (สวัสดี 👋) หรือคุณเป็นนักพัฒนาที่กำลังทดสอบแอปเสียงและต้องการสลับอุปกรณ์เอาต์พุตอย่างรวดเร็ว หรืออาจอยากนำลำโพงแบบสายเก่ากลับมาใช้ใหม่

## การติดตั้ง AirAP

ลองใช้งานได้โดย [เปิดลิงก์ TestFlight นี้](https://testflight.apple.com/join/8aeqD8Q2), ติดตั้ง AirAP และทำตามคำแนะนำ หลังจากติดตั้ง ให้เปิด AirAP และตรวจสอบว่า iPhone ของคุณเชื่อมต่อกับ Wi-Fi เดียวกับอุปกรณ์ที่ต้องการสตรีมเสียง iPhone ของคุณจะปรากฏในรายการอุปกรณ์ AirPlay โดยอัตโนมัติ พร้อมรับเสียง - หากไม่ปรากฏ ลองรีสตาร์ทแอป

## การคอมไพล์

ตรวจสอบว่าคุณมี [homebrew](https://brew.sh)
```
brew install carthage
git clone https://github.com/neon443/AirAP
cd AirAP
carthage checkout
open AirAP.xcodeproj
```
After adding your Team ID in Project > AirAP > Signing and Capabilities, hit `Command + R` to build and run! 

### thanks to

[qasim/Airstream](https://github.com/qasim/Airstream)
[shairplay](https://github.com/juhovh/shairplay)
would not have been possible without these

---

<sup>
&copy; 2025 Nihaal Sharma. AirPlay, iPhone, iTunes, Mac, and Apple TV are trademarks of Apple Inc.
</sup>






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---