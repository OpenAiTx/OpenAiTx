
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

**เปลี่ยนเครื่องรัน GitHub Actions ของคุณให้กลายเป็นขุมพลัง [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ โดยการกำจัดซอฟต์แวร์ที่ไม่จำเป็นออกอย่างเด็ดขาด**

GitHub Actions runner มาพร้อมกับพื้นที่ดิสก์สำหรับ Nix เพียงเล็กน้อย - แค่ประมาณ ~20GB เท่านั้น
*Nothing but Nix* **จะลบซอฟต์แวร์ที่ไม่จำเป็นออกอย่างรุนแรง** ให้คุณมีพื้นที่ว่างสำหรับ Nix store **65GB ถึง 130GB**! 💪

## วิธีใช้ 🔧

เพิ่มแอ็กชันนี้ **ก่อน** การติดตั้ง Nix ใน workflow ของคุณ:

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
- ต้องทำงาน **ก่อน** ที่จะติดตั้ง Nix

## ปัญหา: สร้างพื้นที่ให้ Nix เจริญเติบโต 🌱

GitHub Actions runners มาตรฐานนั้นอัดแน่นไปด้วย *"bloatware"* ที่คุณจะไม่มีวันได้ใช้ใน workflow ของ Nix:

- 🌍 เว็บเบราว์เซอร์มากมาย ต้องมีให้ครบ!
- 🐳 Docker images กินพื้นที่ดิสก์เป็นกิกะไบต์
- 💻 รันไทม์ภาษาที่ไม่จำเป็น (.NET, Ruby, PHP, Java...)
- 📦 ตัวจัดการแพ็กเกจที่ไม่มีใครแตะต้อง
- 📚 เอกสารที่ไม่มีใครอ่าน

ของแถมเหล่านี้เหลือพื้นที่ให้ Nix store แค่ ~20GB - แทบไม่พอสำหรับงาน build Nix จริงจัง! 😞

## ทางออก: มีแค่ Nix เท่านั้น ️❄️

**Nothing but Nix** ใช้วิธีการแบบ "scorched-earth" กับ GitHub Actions runners และทวงคืนพื้นที่ดิสก์อย่างไร้ปรานีผ่านสองเฟส:

1. **ตัดตอนแรก:** สร้าง volume `/nix` ขนาดใหญ่ (~65GB) ทันทีโดยดึงพื้นที่ว่างจาก `/mnt`
2. **กวาดล้างพื้นหลัง:** ขณะที่ workflow ของคุณยังทำงานอยู่ เราจะกำจัดซอฟต์แวร์ที่ไม่จำเป็นทั้งหมดเพื่อขยาย volume `/nix` ของคุณได้สูงสุดถึง ~130GB
   - เว็บเบราว์เซอร์? ไม่เอา ⛔
   - Docker images? ลบทิ้ง 🗑️
   - รันไทม์ภาษา? กำจัด 💥
   - ตัวจัดการแพ็กเกจ? ทำลาย 💣
   - เอกสาร? ระเหย ️👻

การล้างไฟล์นี้ขับเคลื่อนด้วย `rmz` (จากโปรเจกต์ [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - ตัวเลือกที่มีประสิทธิภาพสูงกว่า `rm` ในการ reclaim พื้นที่! ⚡
   - เร็วกว่า `rm` มาตรฐานหลายเท่าตัว
   - ลบแบบขนานเพื่อประสิทธิภาพสูงสุด
   - **ทวงคืนพื้นที่ดิสก์ได้ในไม่กี่วินาทีแทนนาที!** ️⏱️

ผลลัพธ์สุดท้าย? GitHub Actions runner ที่มีพื้นที่ Nix พร้อมใช้ **65GB ถึง 130GB**! 😁

### การเติบโตของ Volume แบบไดนามิก

ต่างจากโซลูชันอื่น ๆ **Nothing but Nix** ขยาย volume `/nix` ของคุณแบบไดนามิก:

1. **สร้าง Volume เริ่มต้น (1-10 วินาที):** (*ขึ้นกับ Hatchet Protocol*)
   - สร้าง loop device จากพื้นที่ว่างบน `/mnt`
   - ตั้งค่าระบบไฟล์ BTRFS แบบ RAID0
   - mount พร้อมเปิด compression และจูน performance
   - ให้ `/nix` ขนาด 65GB ทันที แม้ก่อนเริ่มล้างข้อมูล

2. **ขยายในพื้นหลัง (30-180 วินาที):** (*ขึ้นกับ Hatchet Protocol*)
   - ดำเนินการ purge
   - เฝ้าดูพื้นที่ที่ถูกคืนหลังจากกำจัด bloat
   - เพิ่ม disk ขยายเข้ากับ volume `/nix` แบบไดนามิก
   - rebalance ไฟล์ซิสเต็มเพื่อรวมพื้นที่ใหม่

volume `/nix` จะ **ขยายอัตโนมัติระหว่าง workflow** 🎩🪄

### เลือกอาวุธของคุณ: Hatchet Protocol 🪓

ควบคุมระดับความเด็ดขาด 💥 ด้วย input `hatchet-protocol`:

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
เมื่อกำหนดค่า `nix-permission-edict` เป็น `true` แอ็กชันจะรันคำสั่ง `sudo chown -R "$(id --user)":"$(id --group)" /nix` หลังจากที่เมานต์ `/nix` แล้ว

ตอนนี้ไปสร้างสรรค์สิ่งที่น่าทึ่งด้วยพื้นที่ Nix store อันรุ่งโรจน์นี้กันเถอะ! ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---