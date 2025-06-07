<p align="center">
  <img src="https://github.com/molvqingtai/WebChat/blob/master/public/logo.png" width="200px"/>
</p>

# WebChat

[![GitHub License](https://img.shields.io/github/license/molvqingtai/WebChat)](https://github.com/molvqingtai/WebChat/blob/master/LICENSE) [![Chrome Web Store Version](https://img.shields.io/chrome-web-store/v/cpaedhbidlpnbdfegakhiamfpndhjpgf)](https://chromewebstore.google.com/detail/webchat/cpaedhbidlpnbdfegakhiamfpndhjpgf) [![GitHub Release](https://img.shields.io/github/v/release/molvqingtai/WebChat)](https://github.com/molvqingtai/WebChat/releases)

> แชทกับใครก็ได้บนทุกเว็บไซต์

นี่คือส่วนขยายเบราว์เซอร์สำหรับแชทแบบไม่ระบุตัวตน ที่กระจายศูนย์และไม่มีเซิร์ฟเวอร์ โดยใช้ WebRTC เพื่อการสื่อสารแบบเข้ารหัสจากต้นทางถึงปลายทาง เน้นความเป็นส่วนตัว ข้อมูลทั้งหมดจะถูกจัดเก็บไว้ในเครื่องของคุณเอง

จุดมุ่งหมายคือ เพิ่มฟังก์ชันห้องแชทให้กับทุกเว็บไซต์ คุณจะไม่รู้สึกโดดเดี่ยวอีกต่อไป

### การติดตั้ง

**ติดตั้งผ่าน Store**

- [Chrome Web Store](https://chromewebstore.google.com/detail/webchat/cpaedhbidlpnbdfegakhiamfpndhjpgf)
- [Edge Web Store](https://microsoftedge.microsoft.com/addons/detail/mmfdplbomjjlgdffecapcpgjmhfhmiob)
- [Firefox Addons](https://addons.mozilla.org/firefox/addon/webchat/)

**ติดตั้งด้วยตนเอง**

1. ไปที่คลัง GitHub ([Releases](https://github.com/molvqingtai/WebChat/releases))
2. คลิกที่ปุ่ม "Assets" แล้วเลือก "web-chat-\*.zip"
3. แตกไฟล์ ZIP ไปยังโฟลเดอร์บนคอมพิวเตอร์ของคุณ
4. เปิดหน้าจัดการส่วนขยายในเบราว์เซอร์ของคุณ (โดยปกติคือ chrome://extensions/)
   - เปิด "โหมดนักพัฒนา"
   - คลิก "โหลดแบบไม่บรรจุแพ็ค" และเลือกโฟลเดอร์ที่คุณเพิ่งแตกไฟล์

### วิธีใช้งาน

หลังจากติดตั้งส่วนขยายแล้ว คุณจะเห็นไอคอนรูปผีที่มุมขวาล่างของทุกเว็บไซต์ ให้คลิกที่ไอคอนนี้ แล้วคุณจะสามารถแชทกับผู้อื่นที่อยู่บนเว็บไซต์เดียวกันได้อย่างสนุกสนาน!

### วิดีโอ

https://github.com/user-attachments/assets/e7ac9b8e-1b6c-43fb-8469-7a0a2c09d450

### ยืนอยู่บนไหล่ยักษ์

นอกจากแนวคิดแชทกระจายศูนย์ที่ยอดเยี่ยมแล้ว ยังใช้เทคโนโลยีที่ยอดเยี่ยมต่างๆ ดังนี้

- **[remesh](https://github.com/remesh-js/remesh)**: เฟรมเวิร์ก JavaScript ที่นำหลัก DDD มาใช้ แยกส่วน UI และ Logic อย่างแท้จริง ช่วยให้เปลี่ยน UI ได้ง่าย เช่น เขียนใหม่ด้วย Vue เพราะไม่ขึ้นกับ UI เดิม

- **[shadcn/ui](https://ui.shadcn.com/)**: ไลบรารี UI ที่สวยงามและเป็นผู้นำแนวคิด no-install สะดวกต่อการปรับแต่งสไตล์อย่างยิ่ง

- **[wxt](https://wxt.dev/)**: นี่คือเฟรมเวิร์กที่ดีที่สุดสำหรับสร้างส่วนขยายเบราว์เซอร์ที่เคยใช้มา

- ~~**[trystero](https://github.com/dmotz/trystero)**: ไลบรารีหลักสำหรับการสื่อสารแบบกระจายศูนย์ รองรับการเชื่อมต่อเครือข่ายกระจายศูนย์ เช่น IPFS, torrent, Nostr ฯลฯ~~
- **[Artico](https://github.com/matallui/artico)**: ชุดไลบรารีที่ยืดหยุ่น ช่วยให้คุณสร้างโซลูชัน WebRTC ของตัวเองได้

- **[ugly-avatar](https://github.com/txstc55/ugly-avatar)**: ใช้สร้างอวาตาร์สุ่มที่โดดเด่น

### ผู้สนับสนุน

WebChat เป็นโครงการโอเพนซอร์สที่การพัฒนาอย่างต่อเนื่องเกิดขึ้นได้ด้วยการสนับสนุนจากผู้สนับสนุนที่ยอดเยี่ยมเหล่านี้

[![Powered by DartNode](https://dartnode.com/branding/DN-Open-Source-sm.png)](https://dartnode.com "Powered by DartNode - Free VPS for Open Source")

### ใบอนุญาต

โปรเจกต์นี้อยู่ภายใต้สัญญาอนุญาต MIT - ดูรายละเอียดได้ที่ไฟล์ [LICENSE](https://github.com/molvqingtai/WebChat/blob/master/LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---