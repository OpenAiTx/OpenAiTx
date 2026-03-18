
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**เปลี่ยน GitHub Actions runner ของคุณให้กลายเป็นศูนย์พลังงาน [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ ด้วยการกำจัดซอฟต์แวร์ที่ติดตั้งมาเกินความจำเป็นอย่างเด็ดขาด**

GitHub Actions runner มีพื้นที่ดิสก์สำหรับ Nix เพียงเล็กน้อย ประมาณ ~20GB เท่านั้น
*Nothing but Nix* **กำจัดซอฟต์แวร์ที่ไม่จำเป็นอย่างโหดเหี้ยม** ให้คุณมีพื้นที่สำหรับ Nix store **65GB ถึง 130GB**! 💪

## วิธีใช้งาน 🔧

เพิ่มการดำเนินการนี้ **ก่อน** ติดตั้ง Nix ในขั้นตอนการทำงานของคุณ:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### ข้อกำหนด ️✔️

- รองรับเฉพาะ **Ubuntu** GitHub Actions runners อย่างเป็นทางการเท่านั้น
- ต้องทำงาน **ก่อน** การติดตั้ง Nix
- **macOS/Darwin runners**: แอ็กชันนี้จะข้ามอย่างสุภาพพร้อมแจ้งเตือนหากทำงานบน macOS เนื่องจาก macOS runner มีพื้นที่เพียงพอสำหรับ Nix อยู่แล้วและไม่จำเป็นต้องใช้แอ็กชันนี้
- **Windows runners**: แอ็กชันนี้จะข้ามอย่างสุภาพพร้อมแจ้งเตือนหากทำงานบน Windows เนื่องจาก Windows runner มีรูปแบบไฟล์ระบบและข้อจำกัดที่แตกต่างกัน

## ปัญหา: การจัดพื้นที่ให้ Nix เติบโต 🌱

GitHub Actions runners มาตรฐานเต็มไปด้วย *"bloatware"* ที่คุณจะไม่ได้ใช้ในการทำงานกับ Nix:

- 🌍 เว็บเบราว์เซอร์จำนวนมาก ต้องมีให้ครบ!
- 🐳 Docker images ที่ใช้พื้นที่ดิสก์เป็นกิกะไบต์
- 💻 รันไทม์ภาษาไม่จำเป็น (.NET, Ruby, PHP, Java...)
- 📦 ตัวจัดการแพ็กเกจที่เก็บฝุ่นดิจิทัล
- 📚 เอกสารที่ไม่มีใครอ่าน

สิ่งเหล่านี้ทำให้เหลือพื้นที่ ~20GB สำหรับ Nix store เท่านั้น - แทบจะไม่เพียงพอสำหรับการ build Nix อย่างจริงจัง! 😞

## ทางออก: มีแค่ Nix เท่านั้น ️❄️

**Nothing but Nix** ใช้วิธี "เผาไร่" กับ GitHub Actions runners และทวงคืนพื้นที่ดิสก์อย่างโหดเหี้ยมด้วยการโจมตีสองระยะ:

1. **ฟันรอบแรก:** สร้าง volume `/nix` ขนาดใหญ่ (~65GB) ทันทีโดยใช้พื้นที่ว่างจาก `/mnt`
2. **ระยะหลัง:** ในขณะที่ workflow ของคุณดำเนินต่อ เราจะกำจัดซอฟต์แวร์ที่ไม่จำเป็นอย่างโหดเหี้ยมเพื่อขยาย volume `/nix` ให้ถึง ~130GB
   - เว็บเบราว์เซอร์? ไม่ต้อง ⛔
   - Docker images? ลบออก 🗑️
   - รันไทม์ภาษา? ขจัด 💥
   - ตัวจัดการแพ็กเกจ? ทำลาย 💣
   - เอกสาร? ระเหย ️👻

การล้างระบบไฟล์นี้ขับเคลื่อนด้วย `rmz` (จากโครงการ [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - ทางเลือกที่มีประสิทธิภาพสูงแทน `rm` ที่ทำให้การทวงคืนพื้นที่เร็วสุดๆ! ⚡
   - เร็วกว่ามาตรฐาน `rm` หลายเท่า
   - ลบไฟล์แบบขนานเพื่อประสิทธิภาพสูงสุด
   - **ทวงคืนพื้นที่ดิสก์ในวินาทีแทนนาที!** ️⏱️

ผลลัพธ์สุดท้าย? GitHub Actions runner ที่มีพื้นที่พร้อมใช้กับ Nix **65GB ถึง 130GB**! 😁

### การเติบโตของ volume แบบไดนามิก

แตกต่างจากโซลูชันอื่น ๆ **Nothing but Nix** จะขยายปริมาณ `/nix` ของคุณแบบไดนามิก:

1. **การสร้างปริมาณเริ่มต้น (1-10 วินาที):** (*ขึ้นอยู่กับ Hatchet Protocol*)
   - สร้างอุปกรณ์ loop จากพื้นที่ว่างบน `/mnt`
   - ตั้งค่าไฟล์ระบบ BTRFS ในการกำหนดค่า RAID0
   - เมานต์พร้อมการบีบอัดและปรับแต่งประสิทธิภาพ
   - ให้พื้นที่ `/nix` ขนาด 65GB ทันที แม้ก่อนจะเริ่มกระบวนการ purge

2. **การขยายแบบเบื้องหลัง (30-180 วินาที):** (*ขึ้นอยู่กับ Hatchet Protocol*)
   - ดำเนินการ purge
   - เฝ้าดูพื้นที่ที่ถูกปลดปล่อยใหม่เมื่อบวมถูกกำจัด
   - เพิ่มดิสก์ขยายไปยังปริมาณ `/nix` แบบไดนามิก
   - ปรับสมดุลไฟล์ระบบเพื่อรวมพื้นที่ใหม่

ปริมาณ `/nix` จะ **ขยายโดยอัตโนมัติขณะทำงาน** 🎩🪄

### เลือกอาวุธของคุณ: Hatchet Protocol 🪓

ควบคุมระดับการทำลายล้าง 💥 ด้วย input `hatchet-protocol`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### เปรียบเทียบโปรโตคอล ⚖️

| โปรโตคอล | `/nix` | คำอธิบาย                                      | ลบ apt  | ลบ docker | ลบ snap | ระบบไฟล์ที่ถูกลบ         |
|----------|--------|--------------------------------------------------|---------|-----------|---------|--------------------------|
| Holster  | ~65GB  | เก็บขวานไว้ในฝัก ใช้พื้นที่จาก `/mnt`          | ไม่     | ไม่       | ไม่     | ไม่มี                    |
| Carve    | ~85GB  | ผสมผสานและนำพื้นที่ว่างจาก `/` และ `/mnt` มาใช้ | ไม่     | ไม่       | ไม่     | ไม่มี                    |
| Cleave   | ~115GB | ตัดสินใจเฉียบขาด ลบแพ็กเกจขนาดใหญ่             | น้อยมาก | ใช่       | ใช่     | `/opt` และ `/usr/local`  |
| Rampage  | ~130GB | กำจัดขยะทุกอย่างอย่างโหดเหี้ยม                  | รุนแรง  | ใช่       | ใช่     | มูอาฮาฮาฮา! 🔥🌎         |

เลือกให้ดี:
- **Holster** เมื่อคุณต้องการให้เครื่องมือ runner ใช้งานได้ครบถ้วน
- **Carve** เพื่อรักษาเครื่องมือ runner แต่ยึดพื้นที่ว่างทั้งหมดให้ Nix
- **Cleave** (*ค่าเริ่มต้น*) เพื่อสมดุลพื้นที่กับความสามารถในการทำงาน
- **Rampage** เมื่อต้องการพื้นที่ Nix สูงสุดและไม่แคร์ว่าอะไรจะพัง `#nix-is-life`

### เห็นกับตา เลือดสาด 🩸

โดยปกติ กระบวนการ purge จะทำงานเงียบ ๆ เบื้องหลังขณะ workflow ของคุณดำเนินต่อ แต่ถ้าคุณอยากดูการล้างบางแบบ real-time:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### ปรับแต่ง Safe Havens 🛡️

ควบคุมพื้นที่ที่ต้องกันไว้จากการจับจองของ Nix store ด้วยขนาด Safe Haven ที่กำหนดเอง:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

พื้นที่ปลอดภัยเหล่านี้กำหนดว่าพื้นที่ (เป็น MB) จะถูกละเว้นไม่ถูกนำไปใช้คืนพื้นที่ได้มากเพียงใด:
- ค่าเริ่มต้นของ `root-safe-haven` คือ 2048MB (2GB)
- ค่าเริ่มต้นของ `mnt-safe-haven` คือ 1024MB (1GB)

เพิ่มค่าดังกล่าวหากคุณต้องการพื้นที่สำรองมากขึ้นในไฟล์ระบบของคุณ หรือลดค่าลงหากคุณไม่ต้องการสำรองพื้นที่เลย! 😈

### ให้สิทธิ์ผู้ใช้เป็นเจ้าของ /nix (กฎอนุญาตสิทธิ์ Nix) 🧑‍⚖️

บางโปรแกรมติดตั้งหรือการตั้งค่า Nix คาดหวังว่าไดเรกทอรี `/nix` จะสามารถเขียนโดยผู้ใช้ปัจจุบันได้ โดยค่าเริ่มต้น `/nix` จะเป็นของ root หากคุณต้องการให้ผู้ใช้เป็นเจ้าของ (เช่น สำหรับบางสคริปต์ติดตั้ง Nix ที่ไม่ได้ใช้ `sudo` กับทุกการดำเนินการใน `/nix`) คุณสามารถเปิดใช้ `nix-permission-edict` ได้:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```
เมื่อ `nix-permission-edict` ถูกตั้งค่าเป็น `true` การดำเนินการจะรันคำสั่ง `sudo chown -R "$(id --user)":"$(id --group)" /nix` หลังจากเมานต์ `/nix`

### กำหนดค่า Nix ให้ใช้ /nix/build

การดำเนินการนี้จะสร้าง `/nix/build` สำหรับการสร้าง Nix derivation เพื่อใช้พื้นที่ที่ถูกเรียกคืน เพิ่ม `build-dir` ลงในการกำหนดค่า Nix ของคุณ:


```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```
หรือกับ DeterminateSystems:


```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```
นี่จะสั่งให้ Nix ทำการ build บน volume BTRFS ขนาดใหญ่แทนที่จะเป็นไดเรกทอรีชั่วคราวเริ่มต้นของระบบ

## การแก้ไขปัญหา 🔍

### "ไม่มีพื้นที่ว่างบนอุปกรณ์" ระหว่างการ build ขนาดใหญ่

หากการ build ของคุณพื้นที่เต็มทั้งที่ใช้แต่ Nix น่าจะเป็นเพราะการลบข้อมูลเบื้องหลังยังไม่เสร็จสิ้นก่อนที่ build ของคุณจะใช้พื้นที่ว่างหมด ปัญหานี้มักเกิดกับ:

- การทดสอบ VM ของ NixOS ที่ประกอบ image ดิสก์ขนาดใหญ่
- Build ที่มี dependencies จำนวนมากซึ่งไม่ได้ cache ไว้
- Rust toolchains และการ compile ขนาดใหญ่อื่นๆ

**วิธีแก้:** ใช้ `witness-carnage: true` เพื่อบังคับให้มีการลบข้อมูลแบบ synchronous วิธีนี้จะรับประกันว่าพื้นที่ทั้งหมดจะถูกเคลียร์ *ก่อน* ที่ build ของคุณจะเริ่ม:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```

สิ่งนี้จะเพิ่มเวลา 30-180 วินาทีในการตั้งค่าการทำงานของคุณ แต่รับประกันว่าพื้นที่สูงสุดจะพร้อมใช้งานเมื่อการสร้างของคุณเริ่มต้น

ตอนนี้ไปสร้างสิ่งที่ยอดเยี่ยมด้วยพื้นที่ Nix store อันรุ่งเรืองทั้งหมดนั้น! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---