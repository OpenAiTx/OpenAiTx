[toc]

## ภาพรวม

ที่เก็บข้อมูลนี้ประกอบด้วยซอร์สโค้ดที่เกี่ยวข้องกับ *ระบบการสื่อสารไร้สายด้วยแสงและการสร้างแบบจำลองช่องสัญญาณด้วย MATLAB* 

**บางส่วนของโค้ดต้นฉบับมีปัญหาและจำเป็นต้องได้รับการแก้ไข ข้าพเจ้าได้ปรับปรุงโค้ดให้เหมาะสมและสามารถใช้งานได้จริงมากยิ่งขึ้น**

## เวอร์ชัน MATLAB

MATLAB R2024a

## โครงสร้างไดเรกทอรี

- `util/` - สคริปต์และฟังก์ชันยูทิลิตี้

## คำอธิบายบางส่วนของโค้ด

ด้านล่างคือรายชื่อของสคริปต์ MATLAB ที่รวมอยู่ในที่เก็บนี้ (ไม่ครบทุกไฟล์):

| ชื่อ                       | คำอธิบาย                                                                                           |
| -------------------------- | --------------------------------------------------------------------------------------------------- |
| `CORRECT_plot_Fig3p31.m`   | ฟังก์ชันความหนาแน่นความน่าจะเป็นแบบแกมมา-แกมมา (PDF)                                            |
| `CORRECT_plot_Fig3p28.m`   | PDF ของการแจกแจงแบบลอก-นอร์มอล                                                                   |
| `CORRECT_program_4p4.m`    | โปรแกรม 4.4: โค้ด MATLAB สำหรับจำลองอัตราความผิดพลาดบิต (BER) ของ On-Off Keying Non-Return-to-Zero (OOK-NRZ)   |
| `CORRECT_program_4p5.m`    | โปรแกรม 4.5: โค้ด MATLAB สำหรับจำลอง BER ของ OOK-NRZ โดยใช้ตัวรับสัญญาณแบบแมตช์ฟิลเตอร์                       |
| `CORRECT_plot_Fig4p13.m`   | โปรแกรม 4.10: โค้ด MATLAB สำหรับคำนวณ Power Spectral Density (PSD) ของ Discrete Pulse Interval Modulation (DPIM) (0 Guard Slot) |

## วิธีใช้งาน

เพื่อใช้งานสคริปต์เหล่านี้ ให้แน่ใจว่าได้เพิ่ม `util/` ลงใน path ของ MATLAB โดยสามารถเพิ่มบรรทัดต่อไปนี้ในสคริปต์เริ่มต้นของ MATLAB หรือรันโดยตรงในหน้าต่างคำสั่งของ MATLAB:

```matlab
addpath('path/to/util');
```

เปลี่ยน `'path/to/util'` เป็น path จริงของไดเรกทอรี `util/`

## การมีส่วนร่วม

คุณสามารถมีส่วนร่วมในที่เก็บนี้ได้โดยการ fork และส่ง pull request การปรับปรุง แก้ไขข้อผิดพลาด หรือฟีเจอร์เพิ่มเติมยินดีต้อนรับเสมอ

## คำขอบคุณ

โครงการนี้อ้างอิงจาก *ระบบการสื่อสารไร้สายด้วยแสงและการสร้างแบบจำลองช่องสัญญาณด้วย MATLAB* ขอขอบคุณผู้เขียนและผู้มีส่วนร่วมในโค้ดต้นฉบับมา ณ ที่นี้

---

### &#8627; ผู้กดดาว
[![Stargazers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/stars/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/stargazers)

### &#8627; ผู้ fork
[![Forkers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/forks/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/network/members)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---