## FanImeTsf

นี่คือ TSF สำหรับ [FanImeServer](https://github.com/fanlumaster/FanImeServer)

หมายเหตุ: ขณะนี้รองรับเฉพาะแอปพลิเคชัน 64 บิตเท่านั้น

## วิธีการสร้าง

### ข้อกำหนดเบื้องต้น

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

ตรวจสอบให้แน่ใจว่าได้ติดตั้ง vcpkg และ gsudo ด้วย **Scoop** แล้ว

## ขั้นตอนการสร้าง

### การสร้าง

ก่อนอื่น โคลน repository

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

จากนั้น เตรียมสภาพแวดล้อม

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

จากนั้น สร้างโปรแกรม

```powershell
.\scripts\lcompile.ps1
```

### การติดตั้ง

เปิด powershell ด้วยสิทธิ์ผู้ดูแลระบบ และตรวจสอบให้แน่ใจว่าได้เปิดใช้งานตัวเลือกระบบ `Enable sudo`

![](https://i.postimg.cc/zJCn9Cnn/image.png)

จากนั้น สร้างโฟลเดอร์ใน `C:\Program Files\` ชื่อ `FanImeTsf` และคัดลอก `FanImeTsf.dll` ไปยังโฟลเดอร์ดังกล่าว

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

จากนั้น ติดตั้ง

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### การถอนการติดตั้ง

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## ภาพหน้าจอ

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## โร้ดแมป

ปัจจุบันรองรับเฉพาะเซียวเหอชวงผิน

### ภาษาจีน

- เซียวเหอชวงผิน
- ฉวนผิน
- โค้ดช่วยเหลือในการใช้ส่วนประกอบอักษรจีน
- พจนานุกรมที่สามารถปรับแต่งได้
- เอนจิ้น IME ที่ปรับแต่งได้
- สกินปรับแต่งเองได้
- สลับระหว่างภาษาจีนตัวย่อและตัวเต็ม
- เติมข้อความภาษาอังกฤษอัตโนมัติ
- Open-Sourced Cloud IME API
- สลับหน้าต่างตัวเลือกคำระหว่างแนวตั้งและแนวนอน
- สวิตช์ฟีเจอร์: ฟีเจอร์ส่วนใหญ่ควรเปิด-ปิดหรือปรับแต่งได้อย่างอิสระโดยผู้ใช้

### การรองรับภาษาญี่ปุ่น

อาจจะเป็นโปรเจกต์แยกต่างหาก

และอาจจะรองรับภาษาอื่น ๆ ด้วย

### อ้างอิง

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---