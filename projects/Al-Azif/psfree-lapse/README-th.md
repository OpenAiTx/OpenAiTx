# PSFree เวอร์ชัน 1.5.1

PSFree คือชุดของ exploit สำหรับเครื่องเล่น PS4 โดยโฟกัสหลักของ repo นี้คือสำหรับ PS4 แต่เราพยายามพอร์ตให้สามารถใช้กับ PS5 ได้เช่นกัน

## คุณสมบัติ

- **ตรวจจับอัตโนมัติ:** ตรวจจับประเภทเครื่องและเวอร์ชันเฟิร์มแวร์โดยอัตโนมัติ (ผ่าน `src/config.mjs`)
- **WebKit Exploit (PSFree):** จุดเริ่มต้นผ่านเว็บเบราว์เซอร์ของเครื่องคอนโซล
- **Kernel Exploit (Lapse):** ยกระดับสิทธิ์ไปยังระดับเคอร์เนล
- **Payload Loader:** หลังจากเจาะระบบเคอร์เนลสำเร็จ จะรอรับ payload ที่พอร์ต 9020

## ขอบเขตของช่องโหว่

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## ที่รองรับโดย Repository นี้

ตารางนี้แสดงเวอร์ชันเฟิร์มแวร์ที่ _เวอร์ชันปัจจุบัน_ ของ repository นี้รองรับการใช้งาน exploit chain ได้จริงและผ่านการทดสอบแล้ว

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_หมายเหตุ: การรองรับเฟิร์มแวร์อื่น ๆ ที่ระบุไว้ในตาราง "ขอบเขตของช่องโหว่" อาจจะกำลังอยู่ในระหว่างการพัฒนา หรืออาจเคยรองรับในเวอร์ชันก่อนหน้านี้ของ repository นี้ กรุณาตรวจสอบที่ [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) สำหรับรายละเอียดประวัติการรองรับ_

## รายการที่ต้องทำ (TODO List)

- [ ] ปัญหาหน้าจอดำ/เซฟกับบางเกม
- [ ] `lapse.mjs`: ตั้งค่าบิตสำหรับ JIT privileges อย่างเดียว
- [ ] `view.mjs`: สมมติว่าเป็น PS4, เพิ่มการรองรับ PS5 ด้วย
- [ ] เพิ่มการรองรับ PS5

## ลิขสิทธิ์และผู้เขียน

AGPL-3.0-or-later (ดูที่ [LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). Repo นี้เป็นของกลุ่ม `anonymous` เราเรียกผู้ร่วมพัฒนาที่ไม่เปิดเผยตัวตนว่า "anonymous" เช่นกัน

## เครดิต

- anonymous สำหรับ PS4 firmware kernel dumps
- ตรวจสอบไฟล์ที่เกี่ยวข้องสำหรับ **ผู้ร่วมพัฒนาเพิ่มเติม** หากไม่มีระบุเป็นอย่างอื่น ทุกอย่างในนี้สามารถให้เครดิตกับเราได้เช่นเดียวกัน

## การบริจาค

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---