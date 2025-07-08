# Spegel – สะท้อนเว็บผ่าน AI

เขียนเว็บไซต์ใหม่โดยอัตโนมัติเป็น Markdown ที่เหมาะสำหรับการดูในเทอร์มินัล
อ่านบล็อกแนะนำได้ [ที่นี่](https://simedw.com/2025/06/23/introducing-spegel/)

นี่เป็นหลักฐานแนวคิด (proof-of-concept) อาจมีบั๊กเกิดขึ้นได้ แต่สามารถแจ้งปัญหาหรือส่ง pull request ได้ตามสะดวก

##  ภาพหน้าจอ
บางครั้งคุณไม่อยากอ่านเรื่องราวชีวิตใครสักคนแค่เพื่อจะได้สูตรอาหาร
![ตัวอย่างสูตรอาหาร](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## การติดตั้ง

ต้องการ Python 3.11 ขึ้นไป

```
pip install spegel
```
หรือโคลน repo แล้วติดตั้งในโหมดแก้ไขได้

```bash
# โคลนและเข้าโฟลเดอร์
$ git clone <repo-url>
$ cd spegel

# ติดตั้ง dependencies และ CLI
$ pip install -e .
```

## คีย์ API
ปัจจุบัน Spegel รองรับเฉพาะ Gemini 2.5 Flash เท่านั้น หากต้องการใช้งาน คุณต้องกำหนด API key ในตัวแปร env

```
GEMINI_API_KEY=...
```


## วิธีใช้งาน

### เปิดเบราว์เซอร์

```bash
spegel                # เริ่มต้นที่หน้าต้อนรับ
spegel bbc.com        # เปิด URL ทันที
```

หรือเทียบเท่า:

```bash
python -m spegel      # เริ่มต้นที่หน้าต้อนรับ
python -m spegel bbc.com
```

### ควบคุมพื้นฐาน
- `/`         – เปิดช่องป้อน URL
- `Tab`/`Shift+Tab` – เลื่อนลิงก์ไปข้างหน้า/ย้อนกลับ
- `Enter`     – เปิดลิงก์ที่เลือก
- `e`         – แก้ไข prompt สำหรับ LLM ของมุมมองปัจจุบัน
- `b`         – ย้อนกลับ
- `q`         – ออกจากโปรแกรม

## การแก้ไขการตั้งค่า

Spegel โหลดค่าการตั้งค่าจากไฟล์ config แบบ TOML คุณสามารถปรับแต่งมุมมอง, prompt และตัวเลือก UI ได้

**ลำดับการค้นหาไฟล์ config:**
1. `./.spegel.toml` (ไดเรกทอรีปัจจุบัน)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

วิธีแก้ไขการตั้งค่า:
1. คัดลอก config ตัวอย่าง:
   ```bash
   cp example_config.toml .spegel.toml
   # หรือสร้าง ~/.spegel.toml
   ```
2. แก้ไข `.spegel.toml` ด้วย editor ที่คุณชอบ

ตัวอย่าง snippet:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transform this webpage into the perfect terminal browsing experience! ..."
```

---

ดูรายละเอียดเพิ่มเติมที่โค้ดหรือเปิด issue ได้!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---