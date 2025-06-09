# อัปเดตฐานข้อมูล Browserslist

<img width="120" height="120" alt="โลโก้ Browserslist โดย Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

เครื่องมือ CLI สำหรับอัปเดต `caniuse-lite` ด้วยฐานข้อมูลเบราว์เซอร์
จาก [Browserslist](https://github.com/browserslist/browserslist/) config

บางคำค้นหา เช่น `last 2 versions` หรือ `>1%` ขึ้นอยู่กับข้อมูลจริง
จาก `caniuse-lite`

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="ได้รับการสนับสนุนโดย Evil Martians" width="236" height="54">
</a>

## ทำไมคุณควรเรียกใช้งานเป็นประจำ

`npx update-browserslist-db@latest` จะอัปเดตเวอร์ชันของ `caniuse-lite`
ในไฟล์ lock ของ npm, yarn หรือ pnpm ของคุณ

การอัปเดตนี้จะนำเข้าข้อมูลเกี่ยวกับเบราว์เซอร์ใหม่ ๆ ไปยังเครื่องมือ polyfill
เช่น Autoprefixer หรือ Babel และช่วยลด polyfill ที่ไม่จำเป็นออกไป

คุณควรทำสิ่งนี้เป็นประจำด้วย 3 เหตุผลดังนี้:

1. เพื่อใช้เวอร์ชันของเบราว์เซอร์และสถิติล่าสุดในคำค้นหาเช่น
   `last 2 versions` หรือ `>1%` ตัวอย่างเช่น หากคุณสร้างโปรเจกต์เมื่อ 2 ปีก่อน
   และไม่ได้อัปเดต dependencies เลย `last 1 version`
   จะคืนค่าเป็นเบราว์เซอร์ที่มีอายุ 2 ปี
2. ข้อมูลเบราว์เซอร์ที่เป็นปัจจุบันจะช่วยให้ใช้ polyfill น้อยลง ช่วยลด
   ขนาดไฟล์ JS และ CSS และปรับปรุงประสิทธิภาพเว็บไซต์
3. การทำ deduplication ของ `caniuse-lite`: เพื่อซิงโครไนซ์เวอร์ชันในเครื่องมือที่แตกต่างกัน

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---