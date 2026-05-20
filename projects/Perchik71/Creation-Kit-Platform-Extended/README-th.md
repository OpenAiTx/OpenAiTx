
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  ชุดรวมของการปรับปรุง แก้ไข และทรัพยากรที่วิศวกรรมย้อนกลับสำหรับ Creation Kit โดย Bethesda
</p>

# คำอธิบาย
**CKPE** เป็นแพลตฟอร์มที่มีพลังและเป็นซอร์สโค้ดที่ใช้ร่วมกัน ช่วยแก้ไขและปรับปรุง Creation Kit editor จาก **Bethesda** หลายจุด รองรับเกม เช่น **Skyrim Special Edition**, **Fallout 4**, **Starfield** เป็นโครงการสืบทอดจาก [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test) รวมถึง [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test) ซึ่งเป็นจุดเริ่มต้นของผู้เขียน **perchik71**  

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) หน้า  

# การพึ่งพา
[toml11](https://github.com/ToruNiina/toml11) โดย `ToruNiina` และอื่น ๆ  
[Zydis](https://github.com/zyantific/zydis.git) โดย `zyantifi` และอื่น ๆ  
[zipper](https://github.com/kuba--/zip.git) โดย `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) โดย `ebiggers` และอื่น ๆ  
[xbyak](https://github.com/herumi/xbyak.git) โดย `herumi` และอื่น ๆ    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) โดย `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) โดย `perchik71` *(recursive)*

# การติดตั้ง
>[!IMPORTANT]
>จะใช้รุ่นปกติหรือ noavx2 ดี?  
>ตรวจสอบกับ Steam ว่า CPU ของคุณรองรับ avx2 หรือไม่ เปิด Steam มุมซ้ายบน ชี้ที่เมนูช่วยเหลือ เลือก System Information และค้นหา AVX2  
>ถ้ารองรับให้ใช้รุ่นปกติ  
>ถ้าไม่รองรับให้ใช้รุ่น noavx2  
### การติดตั้งใหม่
ดาวน์โหลด [เกมที่รองรับ](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) และติดตั้ง Creation Kit  
ดาวน์โหลด [รุ่นล่าสุด](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) ของ **CKPE** สำหรับเกมของคุณ  
แตกไฟล์ทั้งหมดลงในโฟลเดอร์เกม เพื่อให้ **ckpe_loader.exe** อยู่โฟลเดอร์เดียวกับ **CreationKit.exe**
### อัปเดต
ดาวน์โหลด [รุ่นล่าสุด](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) ของ **CKPE** สำหรับเกมของคุณ  
แตกไฟล์ทั้งหมดลงในโฟลเดอร์เกม เพื่อให้ **ckpe_loader.exe** อยู่โฟลเดอร์เดียวกับ **CreationKit.exe**  
ตอบตกลงเพื่อแทนที่ไฟล์ทั้งหมด
### การคอมไพล์
ผู้ใช้ทั่วไปต้องการวิธีนี้เมื่อจะเข้าถึงฟีเจอร์ใหม่ ๆ ที่ยังไม่ได้ปล่อย  
เปิดโปรเจกต์ใน **`Visual Studio 2022`** หรือใหม่กว่า สร้างโปรเจกต์ในโหมด **`Release`** หรือ **`Release-NoAVX2`**  
จากนั้นนำไฟล์เอาต์พุตไปไว้ในโฟลเดอร์เกม เพื่อให้ **ckpe_loader.exe** อยู่ในโฟลเดอร์เดียวกับ **CreationKit.exe**  
หากถูกถามให้แทนที่ไฟล์เก่า ให้ตอบตกลง
### การสร้างอัตโนมัติ (Beta)
ดาวน์โหลด [commit build ล่าสุด](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) ของ **CKPE** สำหรับเกมของคุณ  
แตกไฟล์ทั้งหมดลงในโฟลเดอร์เกม เพื่อให้ **ckpe_loader.exe** อยู่โฟลเดอร์เดียวกับ **CreationKit.exe**  
อาจเกิดข้อผิดพลาดได้

# เครดิต
[Nukem9](https://github.com/Nukem9) (สำหรับฟังก์ชันทดลอง, hash และอื่น ๆ ที่มีประโยชน์มาก)  
[adzm](https://github.com/adzm) (ขอขอบคุณสำหรับผลงานของคุณมาก คุณได้ [ทำ](https://github.com/adzm/win32-custom-menubar-aero-theme) ในสิ่งที่ฉันอยากทำเองมานานแล้ว)  
[yak3d](https://github.com/yak3d) (สำหรับการมีส่วนร่วมและการพัฒนา workflow รวมถึงการสนับสนุน Starfield เวอร์ชันใหม่ล่าสุด)  
[DioKyrie-Git](https://github.com/DioKyrie-Git) (สำหรับการออกแบบ readme)  

# สัญญาอนุญาต
เริ่มต้นตั้งแต่ v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) โครงการนี้อยู่ภายใต้สัญญาอนุญาต [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
เวอร์ชันก่อนหน้านี้อยู่ภายใต้สัญญาอนุญาต [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
ลิขสิทธิ์ © 2023-2025 aka perchik71. สงวนลิขสิทธิ์ทั้งหมด. <br />
ไฟล์ `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` มีไฟล์เฉพาะที่ไม่ได้รับอนุญาต เช่นเดียวกับไฟล์ใน `d3dcompiler\*.*`. <br />
ส่วนประกอบที่ต้องพึ่งพาอยู่ภายใต้สัญญาอนุญาตของแต่ละรายการ. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---