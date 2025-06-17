# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (哇!! NB)

VANB เป็นเครื่องมือแปลงสตรีมวิดีโอ/เสียงที่พัฒนาบนพื้นฐาน GStreamer รองรับการแปลงแบบสองทิศทางระหว่างโปรโตคอล NDI และ RTMP ช่วยให้สามารถส่งแหล่ง NDI ไปยังเซิร์ฟเวอร์ RTMP หรือแปลงสตรีม RTMP ให้ออกเป็น NDI ได้

โปรเจกต์นี้เปิดซอร์สภายใต้สัญญาอนุญาต [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html)

## แพลตฟอร์มที่รองรับ

ปัจจุบันรองรับแพลตฟอร์มต่อไปนี้เป็นหลัก:
- macOS (Apple Silicon)

## ข้อกำหนดของระบบ

### ระบบที่ต้องติดตั้ง
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### ขั้นตอนการติดตั้ง
1. ติดตั้ง [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. ติดตั้ง GStreamer ผ่าน Homebrew
```bash
brew install --cask --zap gstreamer-development
```

3. โคลนโปรเจกต์จากคลัง
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. ติดตั้งไลบรารี Python ที่ต้องใช้
```bash
pip install -r requirements.txt
```

5. กำหนดค่า environment variables (ดูตัวอย่างจากไฟล์ .env)
```bash
# กำหนดเส้นทาง NDI SDK
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# กำหนดเส้นทาง GStreamer plugins
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## วิธีการใช้งาน

### NDI ไป RTMP (ฝั่งส่ง)
```bash
python vanb_tx.py
```
โปรแกรมจะสแกนหาแหล่ง NDI ที่ใช้งานได้โดยอัตโนมัติ และแจ้งให้กรอกที่อยู่ RTMP สำหรับ push stream

### RTMP ไป NDI (ฝั่งรับ)
```bash
python vanb_rx.py
```
หลังจากกรอกที่อยู่ RTMP โปรแกรมจะสร้างเอาท์พุต NDI ใหม่โดยอัตโนมัติ

## สถานะการพัฒนา

### ฟีเจอร์ที่ทำสำเร็จแล้ว
- ✓ แปลง NDI เป็น RTMP
- ✓ แปลง RTMP เป็น NDI
- ✓ ปรับอัตโนมัติ frame rate และ resolution
- ✓ ซิงค์เสียงและวิดีโอ
- ✓ สแกนแหล่ง NDI อัตโนมัติ
- ✓ ตั้งชื่อเอาท์พุต NDI อัตโนมัติ
- ✓ VideoToolbox ฮาร์ดแวร์เข้ารหัส/ถอดรหัส

### ฟีเจอร์ที่อยู่ระหว่างการพัฒนา
- ⨯ รองรับไฟล์คอนฟิก (Profile/config.json)
  - ควบคุมพารามิเตอร์ input/output ผ่านไฟล์คอนฟิก
  - รองรับหลาย preset สำหรับการแปลง
  - ปรับขนาด buffer และ latency ได้
  - ปรับสมดุลคุณภาพและประสิทธิภาพการแปลงได้
- ⨯ รองรับหลายสตรีมพร้อมกัน (multi-stream concurrent)

## ประกาศการอนุญาต

⚠️ **หมายเหตุสำคัญ: สัญญาอนุญาตและการปฏิบัติตาม**

### สัญญาอนุญาตซอฟต์แวร์

โปรเจกต์นี้ใช้สัญญาอนุญาต [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html)

เหตุผลที่เลือกใช้ GPL-3.0:
1. โปรเจกต์นี้ใช้ GStreamer plugins ที่เป็น GPL หลายตัว:
   - `x264`: ตัวเข้ารหัสวิดีโอ H.264 (GPL)
   - `x265`: ตัวเข้ารหัสวิดีโอ HEVC/H.265 (GPL)
   - `faad`: ตัวถอดรหัสเสียง AAC (GPL)
2. ตามเงื่อนไขการแพร่กระจายของ GPL ซอฟต์แวร์ที่ใช้คอมโพเนนต์ GPL ต้องใช้สัญญาอนุญาต GPL เช่นกัน
3. การเลือกใช้ GPL-3.0 ช่วยให้มั่นใจว่าเข้ากันได้กับสัญญาอนุญาตของคอมโพเนนต์ทั้งหมด

### ข้อกำหนดของสัญญาอนุญาต

เมื่อใช้งานโปรเจกต์นี้ คุณต้องปฏิบัติตามข้อกำหนดดังต่อไปนี้:
1. **เผยแพร่ซอร์สโค้ด**: หากคุณแก้ไขหรือผนวกโค้ดนี้เข้ากับโปรเจกต์ของคุณ คุณต้องเปิดซอร์สโค้ดทั้งหมด
2. **คงไว้ซึ่งสัญญาอนุญาต**: โปรเจกต์ของคุณต้องใช้สัญญาอนุญาต GPL-3.0 ต่อไป
3. **คงไว้ซึ่งประกาศลิขสิทธิ์**: คุณต้องเก็บประกาศลิขสิทธิ์และสัญญาอนุญาตต้นฉบับไว้
4. **ระบุการแก้ไขอย่างชัดเจน**: หากคุณแก้ไขโค้ด ต้องระบุการเปลี่ยนแปลงที่ทำไว้อย่างชัดเจน
5. **การให้สิทธิ์สิทธิบัตร**: GPL-3.0 มีข้อกำหนดการให้สิทธิ์สิทธิบัตรโดยชัดแจ้ง

### สัญญาอนุญาตคอมโพเนนต์ GStreamer
1. โปรเจกต์นี้ใช้สำหรับการพัฒนาและทดสอบเท่านั้น
2. NDI® เป็นเครื่องหมายการค้าจดทะเบียนของ NewTek, Inc.
3. การใช้งานโปรเจกต์นี้ต้องปฏิบัติตามข้อตกลงสัญญาอนุญาต NewTek NDI® SDK
4. ก่อนใช้งานในสภาพแวดล้อม production กรุณาตรวจสอบให้แน่ใจว่าคุณได้รับสิทธิ์การใช้งานที่จำเป็นครบถ้วน

## การรายงานปัญหา

หากพบปัญหา กรุณา:
1. ตรวจสอบว่าตั้งค่า environment variables ถูกต้องหรือไม่
2. ตรวจสอบว่าได้ติดตั้ง GStreamer plugins ถูกต้องแล้ว
3. ดูข้อมูล error รายละเอียดในไฟล์ log
4. ส่งปัญหาผ่าน Issues พร้อมแนบ log และข้อมูลสภาพแวดล้อม

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---