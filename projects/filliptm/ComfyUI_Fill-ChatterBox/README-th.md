<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

หากคุณชื่นชอบโปรเจกต์นี้ โปรดพิจารณาสนับสนุนผมบน Patreon!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

ส่วนขยายโหนดแบบกำหนดเองสำหรับ ComfyUI ที่เพิ่มความสามารถแปลงข้อความเป็นเสียง (TTS) และแปลงเสียง (VC) โดยใช้ไลบรารี Chatterbox
รองรับสูงสุด 40 วินาที ผมพยายามลบข้อจำกัดนี้แล้ว แต่โมเดลจะผิดเพี้ยนมากหากเกินกว่านั้น จึงยังคงต้องมีข้อจำกัดนี้

![ChatterBox Example](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## การติดตั้ง

1. โคลน repository นี้ไปยังไดเรกทอรี custom_nodes ของ ComfyUI ของคุณ:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. ติดตั้ง dependencies พื้นฐาน:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (ตัวเลือก) ติดตั้งการรองรับลายน้ำ:

   ```bash
   pip install resemble-perth
   ```
**หมายเหตุ**: แพ็กเกจ `resemble-perth` อาจมีปัญหาความเข้ากันได้กับ Python 3.12+ หากคุณพบข้อผิดพลาดในการนำเข้า โหนดจะยังคงทำงานได้โดยไม่มีลายน้ำ


## การใช้งาน

### โหนดแปลงข้อความเป็นเสียงพูด (FL Chatterbox TTS)
- เพิ่มโหนด "FL Chatterbox TTS" ลงในเวิร์กโฟลว์ของคุณ
- กำหนดค่าข้อความอินพุตและพารามิเตอร์ต่างๆ (exaggeration, cfg_weight, temperature)
- สามารถให้พรอมต์เสียงสำหรับการโคลนเสียงได้ตามต้องการ

### โหนดแปลงเสียงพูด (FL Chatterbox VC)
- เพิ่มโหนด "FL Chatterbox VC" ลงในเวิร์กโฟลว์ของคุณ
- เชื่อมต่อเสียงอินพุตและเสียงเป้าหมาย
- ทั้งสองโหนดรองรับการทำงานแบบ fallback ไปยัง CPU หากเกิดข้อผิดพลาดของ CUDA

## บันทึกการเปลี่ยนแปลง

### 24/6/2025
- เพิ่มพารามิเตอร์ seed ในทั้งสองโหนด TTS และ VC เพื่อให้การสร้างซ้ำได้
- ช่วงของ seed: 0 ถึง 4,294,967,295 (จำนวนเต็ม 32 บิต)
- ทำให้ผลลัพธ์เสียงออกมาสอดคล้องกันสำหรับการดีบักและควบคุมเวิร์กโฟลว์
- ทำให้การใส่ลายน้ำ Perth เป็นตัวเลือกเพื่อแก้ปัญหาความเข้ากันได้กับ Python 3.12+
- ขณะนี้โหนดจะทำงานได้แม้การนำเข้า resemble-perth ล้มเหลว

### 31/5/2025
- เพิ่มฟังก์ชันโหลดโมเดลแบบถาวร และแถบโหลด
- เพิ่มการรองรับ Mac (ต้องทดสอบต่อ ติดต่อฉันได้)
- ลบไลบรารี chatterbox-tts และพัฒนาโค้ด inference เอง



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---