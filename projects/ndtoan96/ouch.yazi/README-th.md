
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ndtoan96&project=ouch.yazi&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ouch.yazi

ปลั๊กอิน [ouch](https://github.com/ouch-org/ouch) สำหรับ [Yazi](https://github.com/sxyazi/yazi)

![ouch.yazi](https://github.com/ndtoan96/ouch.yazi/assets/33489972/946397ec-b37b-4bf4-93f1-c676fc8e59f2)

## คุณสมบัติ
- แสดงตัวอย่างไฟล์บีบอัด
- การบีบอัด

## การติดตั้ง

### ตัวจัดการแพ็คเกจ Yazi
```bash
ya pkg add ndtoan96/ouch
```

### Git
```bash
# Linux/macOS
git clone https://github.com/ndtoan96/ouch.yazi.git ~/.config/yazi/plugins/ouch.yazi

# Windows with cmd
git clone https://github.com/ndtoan96/ouch.yazi.git %AppData%\yazi\config\plugins\ouch.yazi

# Windows with powershell
git clone https://github.com/ndtoan96/ouch.yazi.git "$($env:APPDATA)\yazi\config\plugins\ouch.yazi"
```
ตรวจสอบให้แน่ใจว่าคุณได้ติดตั้ง [ouch](https://github.com/ouch-org/ouch) และอยู่ใน `PATH` ของคุณแล้ว

## การใช้งาน

### ดูตัวอย่าง
สำหรับการดูตัวอย่างไฟล์บีบอัด ให้เพิ่มสิ่งนี้ลงใน `yazi.toml` ของคุณ:


```toml
[[plugin.prepend_previewers]]
mime = "application/{*zip,tar,bzip2,7z*,rar,xz,zstd,java-archive}"
run  = "ouch"
```

ตอนนี้ให้ไปที่คลังข้อมูลบน Yazi คุณควรเห็นเนื้อหาของคลังในหน้าต่างแสดงตัวอย่าง คุณสามารถใช้ `J` และ `K` เพื่อเลื่อนขึ้นและลงในหน้าต่างแสดงตัวอย่าง

#### การปรับแต่ง

การแสดงตัวอย่างสามารถปรับแต่งได้โดยการเพิ่มอาร์กิวเมนต์เพิ่มเติมในสตริง `run`:

```toml
[plugin]
prepend_previewers = [
	# Change the top-level archive icon
	{ ..., run = "ouch --archive-icon='🗄️ '" },
	# Or remove it by setting it to ''
	{ ..., run = "ouch --archive-icon=''" },

	# Enable file icons
	{ ..., run = "ouch --show-file-icons" },

	# Disable tree view
	{ ..., run = "ouch --list-view" },

	# These can be combined
	{ ..., run = "ouch --archive-icon='🗄️ ' --show-file-icons --list-view" },
]
```

### การบีบอัด
สำหรับการบีบอัด ให้เพิ่มสิ่งนี้ลงใน `keymap.toml` ของคุณ:

```toml
[[mgr.prepend_keymap]]
on = ["C"]
run = "plugin ouch"
desc = "Compress with ouch"
```
ปลั๊กอินนี้ใช้รูปแบบ `zip` เป็นค่าเริ่มต้น คุณสามารถเปลี่ยนรูปแบบได้เมื่อคุณตั้งชื่อไฟล์เอาต์พุต โดย `ouch` จะตรวจสอบรูปแบบจากนามสกุลไฟล์

และตัวอย่างเช่น หากคุณต้องการตั้งค่า `7z` เป็นรูปแบบเริ่มต้น คุณสามารถใช้ `plugin ouch 7z`

### การคลายการบีบอัด
ปลั๊กอินนี้ไม่มีฟีเจอร์คลายการบีบอัด เพราะ Yazi รองรับอยู่แล้ว
หากต้องการคลายการบีบอัดด้วย `ouch` ให้กำหนดค่า opener ใน `yazi.toml`


```toml
[opener]
extract = [
	{ run = 'ouch d -y %*', desc = "Extract here with ouch", for = "windows" },
	{ run = 'ouch d -y "$@"', desc = "Extract here with ouch", for = "unix" },
]
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---