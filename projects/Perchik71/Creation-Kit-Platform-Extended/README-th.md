
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
**CKPE** เป็นแพลตฟอร์มโอเพ่นซอร์สที่ทรงพลัง ปรับปรุงและแก้ไข Creation Kit editor จาก **Bethesda** รองรับเกมอย่าง **Skyrim Special Edition**, **Fallout 4**, **Starfield** และเป็นตัวสืบทอดของโปรเจกต์ [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test) รวมถึง [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test) ที่เป็นจุดเริ่มต้นของผู้เขียน **perchik71**  

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) หน้า  

# ข้อกำหนดที่ต้องใช้
[toml11](https://github.com/ToruNiina/toml11) โดย `ToruNiina` และอื่นๆ  
[Zydis](https://github.com/zyantific/zydis.git) โดย `zyantifi` และอื่นๆ  
[zipper](https://github.com/kuba--/zip.git) โดย `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) โดย `ebiggers` และอื่นๆ  
[xbyak](https://github.com/herumi/xbyak.git) โดย `herumi` และอื่นๆ    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) โดย `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) โดย `perchik71` *(recursive)*

# การติดตั้ง
>[!IMPORTANT]
>ปล่อย regular หรือ noavx2?  
>ตรวจสอบกับ Steam ว่า CPU ของคุณรองรับ avx2 หรือไม่ เปิด Steam ที่มุมซ้ายบนชี้เมาส์ที่เมนูช่วยเหลือ เลือกข้อมูลระบบ แล้วค้นหา AVX2  
>หากรองรับ ให้ใช้ตัว regular release  
>ถ้าไม่รองรับ ให้ใช้ตัว noavx2 release  
### ติดตั้งใหม่ทั้งหมด
ดาวน์โหลด [supported game](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) และติดตั้ง Creation Kit  
ดาวน์โหลด [เวอร์ชันล่าสุด](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) ของ **CKPE** สำหรับเกมของคุณ  
แตกไฟล์ทั้งหมดลงในโฟลเดอร์เกม ให้แน่ใจว่า **ckpe_loader.exe** อยู่โฟลเดอร์เดียวกับ **CreationKit.exe**
### อัปเดต
ดาวน์โหลด [เวอร์ชันล่าสุด](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) ของ **CKPE** สำหรับเกมของคุณ  
แตกไฟล์ทั้งหมดลงในโฟลเดอร์เกม ให้แน่ใจว่า **ckpe_loader.exe** อยู่โฟลเดอร์เดียวกับ **CreationKit.exe**  
ยอมรับการแทนที่ไฟล์ทั้งหมด
### คอมไพล์
ผู้ใช้ทั่วไปต้องการวิธีนี้เพื่อเข้าถึงฟีเจอร์ใหม่ที่ยังไม่ปล่อย  
เปิดโปรเจกต์ใน **`Visual Studio 2022`** หรือใหม่กว่า สร้างโปรเจกต์ในโหมด **`Release`** หรือ **`Release-NoAVX2`**  
จากนั้นย้ายไฟล์เอาต์พุตไปยังโฟลเดอร์เกม ให้แน่ใจว่า **ckpe_loader.exe** อยู่โฟลเดอร์เดียวกับ **CreationKit.exe**  
หากมีการถามให้แทนที่ไฟล์เก่า ให้ยอมรับการแทนที่ทั้งหมด
### อัตโนมัติ build (Beta)
ดาวน์โหลด [commit build ล่าสุด](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) ของ **CKPE** สำหรับเกมของคุณ  
แตกไฟล์ทั้งหมดลงในโฟลเดอร์เกม ให้แน่ใจว่า **ckpe_loader.exe** อยู่โฟลเดอร์เดียวกับ **CreationKit.exe**  
ข้อผิดพลาดที่อาจเกิดขึ้น

# เครดิต
[Nukem9](https://github.com/Nukem9) (สำหรับฟังก์ชันทดลอง, hash และอื่นๆ ที่มีประโยชน์มาก)  
[adzm](https://github.com/adzm) (ผมขอขอบคุณสำหรับผลงานของคุณมาก คุณได้ [ทำสำเร็จ](https://github.com/adzm/win32-custom-menubar-aero-theme) ในสิ่งที่ผมอยากทำมานานแล้วด้วยตัวเอง)  
[yak3d](https://github.com/yak3d) (สำหรับการมีส่วนร่วมและการพัฒนา workflow และสนับสนุน Starfield เวอร์ชันใหม่ล่าสุด)  
[DioKyrie-Git](https://github.com/DioKyrie-Git) (สำหรับการออกแบบ readme)  

# ใบอนุญาต
เริ่มต้นตั้งแต่ v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) โปรเจกต์นี้ได้รับอนุญาตโดย [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html) <br />
เวอร์ชันก่อนหน้าได้รับอนุญาตโดย [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
ลิขสิทธิ์ © 2023-2025 aka perchik71 สงวนลิขสิทธิ์ทั้งหมด <br />
ไฟล์ `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` มีไฟล์ที่เป็นกรรมสิทธิ์และไม่ได้รับอนุญาต; เช่นเดียวกับไฟล์ใน `d3dcompiler\*.*` <br />
ไลบรารีที่ใช้งานอยู่ภายใต้ใบอนุญาตของแต่ละตัว  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---