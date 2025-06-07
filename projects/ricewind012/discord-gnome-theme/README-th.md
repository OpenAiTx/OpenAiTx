# ธีม Discord GNOME

ธีม GNOME สำหรับ Discord ที่ออกแบบตามสไตล์ Adwaita และแนวทางปฏิบัติอินเทอร์เฟซของ GNOME (ตามที่ CSS ของ Discord อนุญาตให้ทำได้)

## ข้อกำหนด

1. Vesktop

   สำหรับเปิดใช้งานแถบชื่อเรื่องของ Windows

2. การตั้งค่า > ภาษา > เลือก "English (US)"

   สิ่งนี้ช่วยให้สามารถใช้ไอคอนแบบกำหนดเองได้ เนื่องจากวิธีการที่ Discord ตรวจสอบไอคอน คุณสามารถ [แปล](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss) ธีมนี้ได้ แต่โปรดอ่านหมายเหตุเกี่ยวกับการแปล

3. การตั้งค่า > ปลั๊กอิน > เปิดใช้งาน "ThemeAttributes"

   สิ่งนี้ช่วยให้แสดงไอคอนในกล่องโต้ตอบการตั้งค่าได้

4. การตั้งค่า > Vesktop Settings > เปิดใช้งาน "Discord Titlebar"

   ไม่บังคับ แต่แนะนำหากคุณมีแถบชื่อเรื่อง

### ตัวเลือกเพิ่มเติม

1. ลบการอ้างอิงถึง Nitro: https://github.com/CroissantDuNord/discord-adblock

## ปรัชญาการออกแบบธีม

### แนวทางปฏิบัติอินเทอร์เฟซของมนุษย์

ธีมนี้อาจไม่เป็นไปตาม HIG ทั้งหมด เนื่องจากข้อจำกัดด้าน CSS หรือการออกแบบของ Discord หรือการเลือกของผู้พัฒนาเอง

### การสนับสนุน

สิ่งเหล่านี้ไม่ได้รับการสนับสนุน:

- Discord experiments

  ผู้พัฒนาไม่ได้ทำงานกับ Discord จึงไม่สามารถทราบได้ว่า experiments เหล่านี้จะถูกเปลี่ยนแปลง เลิกใช้ ฯลฯ หรือไม่ กล่าวคือ ภาระในการดูแลรักษา — ผู้พัฒนาดูแลโปรเจกต์อื่น ๆ หลายโปรเจกต์

- Nitro

  ข้อยกเว้น — สิ่งใดก็ตามที่เข้าถึงได้ด้วยปลั๊กอิน FakeNitro

คุณ \*สามารถ\* เปิด issue เกี่ยวกับสิ่งเหล่านี้ได้ แต่จะได้รับการแก้ไขก็ต่อเมื่อเป็นการแก้ไขที่ง่าย เช่น ไอคอนที่ขาดหายไป

## การติดตั้ง

### ไม่ต้องตั้งค่า

คัดลอกข้อความต่อไปนี้ไปยังกล่องข้อความที่อยู่ใน การตั้งค่า > ธีม > ธีมออนไลน์:

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### รวมการตั้งค่า

นำ [gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) ไปไว้ที่ ~/.config/vesktop/themes ซึ่งยังคงได้รับการอัปเดตโดยอัตโนมัติ

## ตัวอย่างตัวอย่าง

![first](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![cozy second](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![third](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---