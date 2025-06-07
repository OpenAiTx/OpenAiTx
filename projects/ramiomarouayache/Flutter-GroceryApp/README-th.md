# GroceryApp Starter

เทมเพลตแอปพลิเคชันซื้อของชำที่ออกแบบมาเพื่อประสบการณ์การช็อปปิ้งที่ง่ายและตรงไปตรงมา 🛒✨

หากคุณพบว่า repository นี้มีประโยชน์ อย่าลืมกดดาว ⭐ เพื่อเป็นกำลังใจ

## การออกแบบ

**คลิกที่ภาพด้านล่างเพื่อดูดีไซน์ใน Figma:**

[![Design Preview](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨ความต้องการ

1. **สภาพแวดล้อมในการพัฒนา:**
   - IDE ใดก็ได้ที่ติดตั้ง Flutter SDK (เช่น VSCode, Android Studio, IntelliJ เป็นต้น)

2. **ฐานความรู้:**
   - มีความรู้พื้นฐานถึงระดับกลางเกี่ยวกับ Dart และ Flutter
   - เข้าใจสถาปัตยกรรม MVVM
   - คุ้นเคยกับการจัดการ API
   - เข้าใจพื้นฐานการจัดการสถานะด้วย GetX
  
## การทดสอบ
* คุณสามารถดาวน์โหลดเวอร์ชันก่อนปล่อยสำหรับอุปกรณ์แอนดรอยด์ได้ที่นี่ [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1)
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## การติดตั้ง
* เริ่มต้นด้วยการกำหนดค่า endpoint ผลิตภัณฑ์, ข้อมูลรับรอง และพารามิเตอร์ต่าง ๆ ของคุณใน `lib\constants\AppConstants`
* **หรืออีกทางเลือกหนึ่ง**, ใช้ endpoint ฟรีที่ให้ไว้ด้านล่าง (ณ วันที่แชร์) เพื่อทดสอบให้สำเร็จ
```dart
class AppConstants {
  // แทนที่ "YOUR_API_PREFIX" ด้วย API base URL ของคุณเอง
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //IF_EXIST

  // สำหรับการทดสอบ ใช้ API base URL ฟรีจากเวอร์ชันที่ปล่อยแล้ว
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // ชื่อเต็มของเจ้าของโปรเจกต์
  static const String projectOwnerName = "FULL_NAME";
}
```

## หมายเหตุ
* หากต้องการใช้ API endpoints ของคุณเอง ให้ปรับแต่งเลเยอร์ตรรกะตามแนวทางสถาปัตยกรรม MVVM โดยอ้างอิงจากเอกสาร API ของคุณ
* รูปภาพบางส่วนในเวอร์ชันก่อนปล่อยถูกลบออกเนื่องจากข้อจำกัดด้านลิขสิทธิ์

## การมีส่วนร่วม

กรุณา fork repository นี้และมีส่วนร่วมกลับโดยใช้
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls)

การมีส่วนร่วมทุกประเภท ไม่ว่าจะเป็นฟีเจอร์หลัก แก้ไขบั๊ก หรือการปรับปรุงเล็กน้อย ล้วนได้รับการต้อนรับและชื่นชม
แต่จะถูกตรวจสอบอย่างละเอียดถี่ถ้วน


## เริ่มต้นใช้งาน
โปรเจกต์นี้เป็นจุดเริ่มต้นสำหรับแอปพลิเคชัน Flutter

แหล่งข้อมูลเล็กน้อยเพื่อช่วยให้คุณเริ่มต้น หากนี่คือโปรเจกต์ Flutter แรกของคุณ:

- [Lab: เขียนแอป Flutter แรกของคุณ](https://flutter.io/docs/get-started/codelab)
- [Cookbook: ตัวอย่าง Flutter ที่เป็นประโยชน์](https://flutter.io/docs/cookbook)

## จำนวนผู้เยี่ยมชม

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---