<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="โลโก้ Basketo Game Engine" width="200"/>
</p>

<h2 align="center">สร้างสรรค์, เล่น, สร้างแรงบันดาลใจ เกมที่มีชีวิตชีวา ✨</h2>

<h1 align="center">Basketo Game Engine</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- เปลี่ยน your_discord_server_id เป็นหมายเลขเซิร์ฟเวอร์ของคุณจริง ๆ -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (ชื่อเดิม Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
ยินดีต้อนรับสู่ Basketo Engine - โครงการที่เกิดจากความหลงใหล ที่เราทุ่มเทอย่างเต็มที่ในการสร้างเอนจินที่ยอดเยี่ยมและมีประสิทธิภาพ พร้อมแผนการที่น่าตื่นเต้นในการพัฒนาให้เป็นเอนจินเกมที่ AI-Native มีอินเทอร์เฟซตัวแก้ไขที่คล้าย Unity, การผสานรวม Gemini AI, ระบบเสียงเอฟเฟกต์หลายแชนแนลขั้นสูง และสถาปัตยกรรม ECS ที่ทรงพลัง ไม่ว่าคุณจะมาร่วมพัฒนา เสนอไอเดีย หรือแค่ติดตามการเติบโต คุณก็เป็นส่วนหนึ่งของการเดินทางนี้! 🚀
</p>
## 🚀 สถานะปัจจุบันของเอนจิน
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Current State of Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>ตรวจสอบพัฒนาการล่าสุดและฟีเจอร์ใหม่ ๆ ได้ที่นี่!</em> 🎮
</p>

## ✨ คุณสมบัติเด่น

### 🎮 **อินเทอร์เฟซตัวแก้ไขแบบ Unity**
- **หน้าต่างคู่**: ตัวแก้ไขฉากและมุมมองเกมแบบเคียงข้างกัน
- **แก้ไขแบบเรียลไทม์**: ปรับแต่งฉากขณะเกมกำลังทำงาน
- **แผง Inspector**: แก้ไขคอมโพเนนต์แบบลากและวางได้อย่างสะดวก
- **มุมมองลำดับชั้น**: จัดระเบียบและจัดการเอนทิตี้ได้ง่าย
- **เบราว์เซอร์สินทรัพย์**: จัดการเท็กซ์เจอร์และเสียงได้อย่างง่ายดาย

### 🤖 **การพัฒนาแบบ AI-Native**
- **ผสานรวม Gemini AI**: คำสั่งภาษาธรรมชาติสำหรับพัฒนาเกม
- **การสร้างสคริปต์อัจฉริยะ**: สร้างสคริปต์ Lua ด้วย AI
- **แก้ไขเอนทิตี้**: อธิบายการเปลี่ยนแปลงเป็นภาษาอังกฤษธรรมดาได้
- **ตั้งค่า API ง่าย**: กำหนดค่า Gemini API key ได้ในตัว
### 🔊 **ระบบเสียงขั้นสูง**
- **เอฟเฟกต์เสียงหลายแบบ**: เสียงที่มีชื่อหลายรายการต่อเอนทิตี (เดิน, กระโดด, โจมตี ฯลฯ)
- **เสียงแบบดั้งเดิม**: เพลงพื้นหลังและเสียงบรรยากาศ
- **การเชื่อมต่อกับ Lua**: เรียกใช้เสียงจากสคริปต์ด้วย `PlaySound(entity, "action")`
- **ตัวแก้ไขแบบภาพ**: จัดการเอฟเฟกต์เสียงผ่านตัวตรวจสอบ

### 🎯 **เอนทิตี-คอมโพเนนต์-ซิสเต็ม (ECS)**
- **ประสิทธิภาพสูง**: ปรับแต่งเพื่อรองรับเอนทิตีจำนวนมาก
- **การออกแบบแบบโมดูลาร์**: ผสมผสานคอมโพเนนต์ตามต้องการ
- **เชื่อมต่อกับสคริปต์**: สคริปต์ Lua ที่เข้าถึง ECS ได้อย่างเต็มที่
- **อัปเดตแบบเรียลไทม์**: แก้ไขคอมโพเนนต์ได้สด ๆ

### 🎨 **กราฟิก & แอนิเมชัน**
- **เรนเดอร์สไปรต์**: ท่อกราฟิก 2D ที่มีประสิทธิภาพ
- **ระบบแอนิเมชัน**: แอนิเมชันแบบเฟรมพร้อมการวนซ้ำ
- **ระบบทรานส์ฟอร์ม**: ตำแหน่ง, การหมุน, และการปรับขนาด
- **ระบบกล้อง**: รองรับกล้องหลายตัว

### ⚡ **ฟิสิกส์ & การชน**
- **ตรวจจับการชน**: การชนแบบ AABB พร้อมการปรับแต่งพื้นที่
- **ฟิสิกส์ริจิดบอดี**: แรงโน้มถ่วง, ความเร็ว, และแรงต่าง ๆ
- **คอลแบ็กการชน**: เหตุการณ์การชนที่เข้าถึงได้จากสคริปต์
- **การแบ่งพื้นที่**: การปรับแต่งประสิทธิภาพด้วยควอดทรี
## 🎬 คลิกที่ภาพด้านล่างเพื่อดูวิดีโอสาธิต:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## � คู่มือเริ่มต้นอย่างรวดเร็ว

### 1. **รับคีย์ API ของ Gemini** (ไม่จำเป็นแต่แนะนำให้มี)
- ไปที่ [Google AI Studio](https://aistudio.google.com/app/apikey)
- ลงชื่อเข้าใช้และสร้างคีย์ API ฟรี
- สิ่งนี้จะเปิดใช้งานฟีเจอร์ที่ใช้ AI เช่น คำสั่งภาษาธรรมชาติ

### 2. **สร้างและรัน**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **กำหนดค่าฟีเจอร์ AI**
- ในเอนจิน ไปที่แผง AI Prompt (ด้านล่าง)
- มองหา "🤖 Gemini AI Configuration"
- ป้อน API key ของคุณแล้วคลิก "Save"

### 4. **เริ่มต้นสร้างผลงาน**
- ลองใช้คำสั่ง AI: `"create a player at 100 200"`
- เพิ่มเอฟเฟกต์เสียงให้กับเอนทิตีในอินสเป็กเตอร์
- เขียนสคริปต์ Lua หรือให้ AI สร้างสคริปต์ให้
- ใช้งานตัวแก้ไขแบบสองหน้าต่างสำหรับการพัฒนาแบบเรียลไทม์

## 🛠️ การสร้างเอนจิน (Linux) 🐧

### ข้อกำหนดเบื้องต้น
- ต้องใช้ CMake 3.26.0 หรือสูงกว่า
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (สำหรับฟีเจอร์ AI)
- nlohmann/json (ถูกรวมเป็น submodule)
- ImGui (ถูกรวมเป็น submodule)
### ขั้นตอนการ Build
```bash
# โคลนรีโพซิทอรี
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### การรันโปรแกรม
```bash
./BasketoGameEngine

```
หากคุณต้องการรันทดสอบฟิสิกส์:
```bash
./PhysicsTest

```

## 🛠️ การสร้างเอนจิน (Windows) 💻

### ข้อกำหนดเบื้องต้น

1. **Visual Studio 2022 (Community Edition หรือสูงกว่า)**  
   ติดตั้งด้วย workload ต่อไปนี้:
   - Desktop development with C++
   - C++ CMake tools for Windows
   - Windows 10 หรือ 11 SDK

2. **CMake** (รวมมากับ Visual Studio หรือดาวน์โหลดจาก https://cmake.org/download/)

3. **vcpkg** (ใช้สำหรับติดตั้ง dependencies)


---
### ติดตั้ง Dependencies

```bash
# เปิด Developer Command Prompt สำหรับ VS 2022 หรือ PowerShell

# โคลน vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# ติดตั้งไลบรารีที่จำเป็น
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### ขั้นตอนการ Build
```bash
# โคลนที่เก็บ Basketo
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# กำหนดค่าด้วย CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/path/to/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# แทนที่ "C:/path/to/vcpkg" ด้วยพาธแบบเต็มไปยังไดเรกทอรี vcpkg ของคุณ

# สร้างเอนจิน
cmake --build . --config Release
```

---

### การรัน

```bash
# จากไดเรกทอรี build/Release
```
./BasketoGameEngine.exe

# เพื่อทดสอบฟิสิกส์
./PhysicsTest.exe
```

## 📚 เอกสารประกอบ

### ฟีเจอร์หลัก
- **[ระบบเอฟเฟกต์เสียง](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: คู่มือสมบูรณ์สำหรับระบบเอฟเฟกต์เสียงหลายแบบ
- **[การตั้งค่า Gemini API](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: การกำหนดค่า AI ทีละขั้นตอน
- **[การเขียนสคริปต์ด้วย Lua](assets/Scripts/)**: ตัวอย่างสคริปต์และการอ้างอิง API

### ตัวอย่างการใช้งาน

#### การพัฒนาด้วย AI
```bash
# คำสั่งภาษาธรรมชาติ
"สร้างตัวละครผู้เล่นที่ตำแหน่ง 100 200"
"เพิ่มพฤติกรรมการกระโดดให้กับผู้เล่น"
"ทำให้ศัตรูเคลื่อนที่เร็วขึ้น"

# การสร้างสคริปต์
gemini_script สร้างตัวควบคุมแพลตฟอร์มเมอร์พร้อมการกระโดดสองครั้ง
```

#### เอฟเฟกต์เสียงหลายเสียง
```lua
-- ในสคริปต์ Lua ของคุณ
PlaySound(entity, "jump")    -- เล่นเสียงกระโดด
PlaySound(entity, "walk")    -- เล่นเสียงเดิน
PlaySound(entity, "attack")  -- เล่นเสียงโจมตี

-- ตรวจสอบว่าเสียงมีอยู่หรือไม่
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### ระบบคอมโพเนนต์
- **Transform**: ตำแหน่ง, การหมุน, ขนาด
- **Sprite**: การเรนเดอร์เท็กซ์เจอร์
- **Animation**: แอนิเมชันแบบเฟรม
- **Script**: สคริปต์พฤติกรรม Lua
- **Collider**: การชนทางฟิสิกส์
- **Rigidbody**: การจำลองฟิสิกส์
- **Audio**: เพลงพื้นหลัง
- **SoundEffects**: เสียงหลายชื่อ
- **Camera**: การจัดการมุมมอง
## 🤝 เข้าร่วมกับเรา

เรายินดีรับการมีส่วนร่วมจากชุมชนของเรา ❤️ สำหรับรายละเอียดเกี่ยวกับการมีส่วนร่วม หรือการรันโปรเจกต์เพื่อการพัฒนา โปรดดูที่ [แนวทางการมีส่วนร่วม](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md) <!-- สมมติว่าคุณมีไฟล์นี้ -->

- 🐛 พบข้อบกพร่อง? เปิด issue ได้เลย!
- ✨ มีไอเดียฟีเจอร์เจ๋ง ๆ ไหม? บอกเราเลย!
- 💻 อยากร่วมพัฒนา? Fork, เขียนโค้ด แล้วสร้าง pull request!

มาสร้างเอนจินนี้ไปด้วยกัน และทำให้การพัฒนาเกมเป็นเรื่องสนุกและง่ายสำหรับทุกคน 🌍

## 👥 ชุมชน
ขอต้อนรับด้วยกอดใหญ่ ๆ 🤗 เราตื่นเต้นมากกับการมีส่วนร่วมของชุมชนในทุกรูปแบบ ไม่ว่าจะเป็นการปรับปรุงโค้ด 📝, อัปเดตเอกสาร 📚, รายงานปัญหา 🐞, ขอฟีเจอร์ 💡 หรือร่วมพูดคุยใน Discord ของเรา 🗣️

เข้าร่วมชุมชนของเราได้ที่นี่:

- 👋 [เข้าร่วมชุมชน Discord ของเรา](https://discord.gg/F3DswRMW)
- ⭐ [กดดาวให้เราบน GitHub](https://github.com/basketoengine/Basketo)

## 🙏 สนับสนุนเรา:
เรากำลังพัฒนาอย่างต่อเนื่อง และจะมีฟีเจอร์และตัวอย่างใหม่ ๆ มาให้เร็ว ๆ นี้ 🌟 หากคุณชื่นชอบโปรเจกต์นี้ โปรดกดดาว ⭐ ที่ GitHub repo [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) เพื่อติดตามข่าวสารและช่วยให้เราเติบโต 🌱

---

ขอให้สนุกกับการเขียนโค้ดและสร้างเกม! 🎉🎮


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---