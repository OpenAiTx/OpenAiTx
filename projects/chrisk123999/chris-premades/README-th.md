# Readme

ชุดรวมไอเทมอัตโนมัติ เช่น เวทมนตร์ ความสามารถคลาส ความสามารถมอนสเตอร์ ฯลฯ กลไกสำหรับทำให้สิ่งเหล่านั้นเป็นไปได้ และส่วนขยายเพื่อความสะดวกในการใช้งานสำหรับสภาพแวดล้อม D&D5e ที่เน้นการอัตโนมัติสูงโดยใช้ Midi-QOL คลังข้อมูล (Compendiums) ที่รวมอยู่ในโมดูลนี้จะไม่มีคำอธิบายของไอเทม แม้ว่าโมดูลนี้จะมีการพึ่งพาหลายโมดูลจากผู้เขียนต่าง ๆ โปรดอย่ารบกวน tposney, Wasp หรือผู้เขียนโมดูลคนอื่น ๆ ด้วยปัญหาหรือบั๊กที่เกี่ยวข้องกับโมดูลนี้ รายงานบั๊กและคำขอเพิ่มฟีเจอร์ขนาดใหญ่สามารถแจ้งได้ที่ GitHub การสนับสนุนที่รวดเร็วและการขอฟีเจอร์สามารถติดต่อได้ที่ [Discord server](https://discord.gg/BumxBcQDrT)

![CauldronofPlentifulResourcesMedium](https://github.com/user-attachments/assets/58c729ba-c499-45a3-a62c-c6982ad1f725) 
  
### ผู้เขียน:
[Chris](https://github.com/chrisk123999) <br> 
[Autumn](https://github.com/Autumn225) <br>
[Michael](https://github.com/roth-michael) <br>
[SagaTympana](https://github.com/SagaTympana)

### สนับสนุน:
[<img src="https://raw.githubusercontent.com/chrisk123999/chris-premades/master/images/chris-kofi.svg" width=237px />](https://ko-fi.com/O5O5G582S) <br>
[<img src="https://raw.githubusercontent.com/chrisk123999/chris-premades/master/images/michael-kofi.svg" width=253px />](https://ko-fi.com/T6T8XKCII)
  
# โมดูลที่จำเป็น  
| โมดูล | เวอร์ชันขั้นต่ำ |  
| --- | --- | 
| D&D 5e System | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.systems%5B%3A1%5D.compatibility.minimum&label=%20&color=orange) | 
| Midi-Qol | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B0%5D.compatibility.minimum&label=%20&color=green) |  
| Dynamic Active Effects | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B3%5D.compatibility.minimum&label=%20&color=green) |
| Jules & Ben's Animated Assets | ![Static Badge](https://img.shields.io/badge/0.6.0-blue) |  
| Sequencer | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B1%5D.compatibility.minimum&label=%20&color=green) |  
| Socket Lib | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B2%5D.compatibility.minimum&label=%20&color=green) |  
| Time's Up | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B4%5D.compatibility.minimum&label=%20&color=green) |
  
# โมดูลเสริมที่รองรับ:  
- Gambit's Premades
- Midi Item Showcase Community
- Universal Animations
- [Animated Spell Effects: Cartoon](https://github.com/chrisk123999/animated-spell-effects-cartoon/releases/download/0.4.6/module.json)
- Visual Active Effects
- D&D Beyond Importer
- Tidy5e Sheet
- Token Magic FX
  
# ฟีเจอร์หลัก:
- คลังรวมเวทมนตร์ ไอเทม ความสามารถคลาส และอื่น ๆ ที่ตั้งค่าให้ทำงานอัตโนมัติ
- ปุ่มบนแถบหัวเรื่องเพื่อเปิดอินเทอร์เฟซสำหรับจัดการและตั้งค่าระบบอัตโนมัติที่มีในโมดูล
- แอนิเมชันสวยงามที่สร้างโดย ***Eskiemoh*** สำหรับการอัตโนมัติบางรายการ โดยใช้ *Patreon JB2A* และ *Animated Spell Effects: Cartoon*
- ตัวจัดการการทอยแบบกำหนดเองสำหรับการทอยแบบแมนนวล เหมาะสำหรับการเล่นแบบพบปะกัน
- API กำหนดเองที่ต่อยอดจาก workflow ของ Midi-QOL เพื่อการควบคุมจังหวะเหตุการณ์และการอัตโนมัติของเอฟเฟกต์เวทมนตร์ที่ทับซ้อนกัน
- Public API สำหรับเรียกใช้งานมาโครที่กำหนดเอง
- ส่วนขยายอินเทอร์เฟซผู้ใช้ต่าง ๆ เพื่อความสะดวกในการใช้งาน
- การเปลี่ยนแปลงเอฟเฟกต์ เช่น การเพิ่มคำอธิบายอัตโนมัติ เปลี่ยนไอคอนสถานะ และติดธง Midi-QOL ที่เกี่ยวข้องกับสถานะนั้น ๆ
- อินเทอร์เฟซเอฟเฟกต์ที่กำหนดเองสำหรับจัดเก็บและนำเอฟเฟกต์ที่กำหนดเองไปใช้
- กลไกเสริมและโฮมบรูว์ เช่น DMG Cleave, Exploding Heals และ BG3 Weapon Actions
- สำรองข้อมูลตัวละครโดยอัตโนมัติ

# ลิงก์ชุมชน:
[Cauldron of Plentiful Resources Discord](https://discord.gg/BumxBcQDrT)<br>
[Foundry VTT Discord](https://discord.gg/foundryvtt)<br>
[Posney's Foundry Automation Discord](https://discord.gg/Xd4NEvw5d7)<br>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---