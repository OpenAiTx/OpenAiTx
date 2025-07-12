# Git Smart Squash

หยุดเสียเวลากับการจัดระเบียบคอมมิทด้วยตนเอง ให้ AI จัดการแทนคุณ

## ปัญหา

คุณคงเคยเจอ: มีคอมมิท 15 ครั้งสำหรับฟีเจอร์หนึ่ง โดยครึ่งหนึ่งเป็น "fix", "typo" หรือ "WIP" ตอนนี้คุณต้องจัดการให้เรียบร้อยเพื่อรีวิว PR การ squash และเขียนใหม่ด้วยตัวเองเป็นเรื่องน่าเบื่อ

## ทางออก

Git Smart Squash วิเคราะห์การเปลี่ยนแปลงของคุณและจัดระเบียบใหม่ให้เป็นคอมมิทที่มีเหตุผลพร้อมข้อความที่เหมาะสม:

```bash
# ก่อน: สาขาที่รกของคุณ
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation

# หลังจากนั้น: คอมมิตที่สะอาดและเป็นลำดับ

* feat: implement JWT authentication system
* test: add auth endpoint coverage
```

## เริ่มต้นอย่างรวดเร็ว

### 1. ติดตั้ง

```bash
# ใช้ pip
pip install git-smart-squash

# ใช้ pipx (แนะนำสำหรับการติดตั้งแยก)
pipx install git-smart-squash

# ใช้ uv (ตัวจัดการแพ็กเกจ Python ที่รวดเร็ว)
uv tool install git-smart-squash
```
### 2. ตั้งค่า AI

**ตัวเลือก A: ใช้งานในเครื่อง (ฟรี, เป็นส่วนตัว)**
```bash
# ติดตั้ง Ollama จาก https://ollama.com
ollama pull devstral  # โมเดลเริ่มต้น
```

**ตัวเลือก B: ใช้งานบนคลาวด์ (ผลลัพธ์ดีกว่า)**
```bash
export OPENAI_API_KEY="your-key"
export ANTHROPIC_API_KEY="your-key"
export GEMINI_API_KEY="your-key"
```

### 3. เริ่มทำงาน

```bash
cd your-repo
git-smart-squash
```
เสร็จแล้ว ตรวจสอบแผนและอนุมัติ

## พารามิเตอร์บรรทัดคำสั่ง

| พารามิเตอร์ | คำอธิบาย | ค่าเริ่มต้น |
|-------------|-----------|-------------|
| `--base` | สาขาหลักที่ใช้เปรียบเทียบ | ไฟล์ config หรือ `main` |
| `--ai-provider` | ผู้ให้บริการ AI ที่จะใช้ (openai, anthropic, local, gemini) | กำหนดใน settings |
| `--model` | โมเดล AI เฉพาะที่จะใช้ (ดูโมเดลที่แนะนำด้านล่าง) | ค่าเริ่มต้นของผู้ให้บริการ |
| `--config` | พาธไปยังไฟล์คอนฟิกแบบกำหนดเอง | `.git-smart-squash.yml` หรือ `~/.git-smart-squash.yml` |
| `--auto-apply` | ใช้แผน commit โดยไม่ต้องยืนยัน | `false` |
| `--instructions`, `-i` | คำแนะนำกำหนดเองสำหรับ AI (เช่น "จัดกลุ่มตามฟีเจอร์") | ไม่มี |
| `--no-attribution` | ปิดข้อความ attribution ใน commit | `false` |
| `--debug` | เปิดโหมด debug เพื่อดูข้อมูลละเอียด | `false` |

## โมเดลที่แนะนำ

### โมเดลเริ่มต้น
- **OpenAI**: `gpt-4.1` (ค่าเริ่มต้น)
- **Anthropic**: `claude-sonnet-4-20250514` (ค่าเริ่มต้น)
- **Gemini**: `gemini-2.5-pro` (ค่าเริ่มต้น)
- **Local/Ollama**: `devstral` (ค่าเริ่มต้น)
### การเลือกโมเดล
```bash
# ระบุโมเดลที่แตกต่าง
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# สำหรับ Ollama ในเครื่อง
git-smart-squash --ai-provider local --model llama-3.1
```

## คำสั่งกำหนดเอง

พารามิเตอร์ `--instructions` ช่วยให้คุณควบคุมวิธีการจัดระเบียบคอมมิทได้:

### ตัวอย่าง
```bash
# เพิ่มคำนำหน้าตั๋ว
git-smart-squash -i "Prefix all commits with [ABC-1234]"

# แยกตามประเภท
git-smart-squash -i "Keep backend and frontend changes in separate commits"
```
# จำกัดจำนวนคอมมิต
git-smart-squash -i "สร้างคอมมิตรวมไม่เกิน 3 คอมมิตทั้งหมด"
```

### เคล็ดลับเพื่อผลลัพธ์ที่ดียิ่งขึ้น
- **ระบุให้ชัดเจน**: "จัดกลุ่ม migration ของฐานข้อมูลแยกกัน" จะได้ผลดีกว่า "จัดระเบียบให้ดูดี"
- **ทีละคำสั่ง**: คำสั่งที่ซับซ้อนหรือหลายส่วนในครั้งเดียวอาจถูกละเลยบางส่วน
- **ใช้โมเดลที่ดีกว่า**: โมเดลขนาดใหญ่จะปฏิบัติตามคำสั่งได้แม่นยำกว่าโมเดลขนาดเล็ก

## กรณีใช้งานทั่วไป

### "ฉันต้องการจัดระเบียบก่อนรีวิว PR"
```bash
git-smart-squash              # แสดงแผนและขอการยืนยันก่อนดำเนินการ
git-smart-squash --auto-apply # ดำเนินการอัตโนมัติโดยไม่ขอการยืนยัน
```

### "ฉันทำงานกับ branch หลักที่แตกต่างออกไป"
```bash
git-smart-squash --base develop
```
### "ฉันต้องการใช้ผู้ให้บริการ AI เฉพาะ"
```bash
git-smart-squash --ai-provider openai
```

## ความปลอดภัย

**โค้ดของคุณปลอดภัย:**
- แสดงแผนก่อนทำการเปลี่ยนแปลง
- สร้างสาขาสำรองอัตโนมัติ
- ต้องการไดเรกทอรีการทำงานที่สะอาด
- ไม่เคย push โดยไม่ได้รับคำสั่งจากคุณ

**หากเกิดปัญหา:**
```bash
# ค้นหาสำรอง
git branch | grep backup

# กู้คืน
git reset --hard your-branch-backup-[timestamp]
```

## ผู้ให้บริการ AI

| ผู้ให้บริการ | ค่าใช้จ่าย | ความเป็นส่วนตัว |
|--------------|------------|-----------------|
| **Ollama**   | ฟรี        | ในเครื่อง       |
| **OpenAI**   | ~0.01 ดอลลาร์ | คลาวด์        |
| **Anthropic**| ~0.01 ดอลลาร์ | คลาวด์        |
| **Gemini**   | ~0.01 ดอลลาร์ | คลาวด์        |

## การตั้งค่าขั้นสูง (ไม่บังคับ)

ต้องการปรับแต่งเพิ่มเติม? สร้างไฟล์ config:

**สำหรับโปรเจกต์** (`.git-smart-squash.yml` ใน repo ของคุณ):
```yaml
ai:
  provider: openai  # ใช้ OpenAI สำหรับโปรเจกต์นี้
base: develop       # ใช้ develop เป็น base branch สำหรับโปรเจกต์นี้
```
**Global default** (`~/.git-smart-squash.yml`):
```yaml
ai:
  provider: local   # ใช้ AI ในเครื่องเสมอโดยเป็นค่าเริ่มต้น
base: main          # สาขาหลักเริ่มต้นสำหรับทุกโปรเจกต์
```

## การแก้ไขปัญหา

### ข้อผิดพลาด "Invalid JSON"
โดยปกติหมายถึงโมเดล AI ไม่สามารถจัดรูปแบบการตอบกลับได้อย่างถูกต้อง:
- **กับ Ollama**: เปลี่ยนจาก `llama2` เป็น `mistral` หรือ `mixtral`
- **วิธีแก้ไข**: ใช้คำสั่ง `ollama pull mistral` แล้วลองใหม่
- **ทางเลือก**: ใช้ผู้ให้บริการคลาวด์ด้วย `--ai-provider openai`

### โมเดลไม่ปฏิบัติตามคำสั่ง
บางโมเดลประสบปัญหากับคำสั่งที่ซับซ้อน:
- **ใช้โมเดลที่ดีกว่า**: `--model gpt-4-turbo` หรือ `--model claude-3-opus`
- **ทำให้คำสั่งง่ายขึ้น**: คำสั่งที่ชัดเจนเพียงข้อเดียวจะได้ผลดีกว่าหลายข้อ
- **ระบุให้ชัดเจน**: "เติมด้วย [ABC-123] ด้านหน้า" ไม่ใช่ "เพิ่มหมายเลข ticket"
### "ไม่พบ Ollama"
```bash
# ติดตั้งจาก https://ollama.com
ollama serve
ollama pull devstral  # โมเดลเริ่มต้น
```

### การจัดกลุ่ม Commit ไม่ดี
หาก AI สร้าง commit มากเกินไปหรือจัดกลุ่มไม่ดี:
- **โมเดลไม่เพียงพอ**: ใช้โมเดลที่ใหญ่ขึ้น
- **เพิ่มคำแนะนำ**: `-i "Group related changes, max 3 commits"`
- **ให้ข้อเสนอแนะ**: สร้าง issue บน GitHub และแจ้งให้เราทราบว่าเกิดอะไรขึ้น

### ปัญหาการติดตั้ง (Mac)
หากคุณไม่มี pip หรือชอบการติดตั้งแบบแยก:
```bash
# ใช้ pipx (แนะนำ)
brew install pipx
pipx install git-smart-squash
```
### "ไม่มีการเปลี่ยนแปลงให้จัดระเบียบใหม่"
```bash
git log --oneline main..HEAD  # ตรวจสอบว่าคุณมีคอมมิตหรือไม่
git diff main                 # ตรวจสอบว่าคุณมีการเปลี่ยนแปลงหรือไม่
```

### Diff ขนาดใหญ่ / ขีดจำกัดโทเค็น
โมเดลแบบโลคัลมีขีดจำกัดประมาณ 32k โทเค็น สำหรับการเปลี่ยนแปลงขนาดใหญ่:
- ใช้ `--base` กับคอมมิตที่ใหม่กว่า
- เปลี่ยนไปใช้คลาวด์: `--ai-provider openai`
- แยกเป็น PR ขนาดเล็กลง

### ต้องการความช่วยเหลือเพิ่มเติม?

ดู [เอกสารประกอบแบบละเอียด](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md) หรือเปิด issue ได้เลย!

## ใบอนุญาต

สัญญาอนุญาต MIT - ดูรายละเอียดได้ที่ไฟล์ [LICENSE](LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---