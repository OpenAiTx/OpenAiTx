
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Annotator

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="ดาวน์โหลดได้ที่ AppCenter"/>
  </a>
</p>

![<center><b>หน้าต่างหลัก - ธีมสว่าง</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "การใส่คำอธิบายภาพสำหรับ Elementary OS")

## ภาพรวม

ใส่คำอธิบายภาพของคุณและให้ภาพบอกเล่าเรื่องราวแทนคำพูดนับพันคำ

- โหลดภาพจากระบบไฟล์, คลิปบอร์ด หรือสร้างภาพหน้าจอเพื่อใส่คำอธิบาย
- เพิ่มรูปทรง, สติ๊กเกอร์, ภาพ, ข้อความ, ภาพวาด และป้ายกำกับอื่นๆ เพื่อเน้นรายละเอียดของภาพ
- เพิ่มแว่นขยายเพื่อเพิ่มรายละเอียดของภาพ
- เบลอส่วนต่างๆ ของภาพเพื่อปกปิดข้อมูล
- ครอบตัด, ปรับขนาด และเพิ่มกรอบให้ภาพ
- ควบคุมสี, ความหนาของเส้น และรายละเอียดแบบอักษร
- รองรับการซูม
- รองรับตัวเลือกสีภายในภาพที่โหลด
- เลิกทำ/ทำซ้ำการเปลี่ยนแปลงได้ไม่จำกัด
- ลากและวางสำเนา PNG ของภาพที่ใส่คำอธิบาย
- ส่งออกเป็นไฟล์ภาพ JPEG, PNG, TIFF, BMP, PDF, SVG และ WebP
- รองรับการคัดลอกภาพที่ใส่คำอธิบายไปยังคลิปบอร์ด
- รองรับเครื่องพิมพ์

## การติดตั้ง

### Debian (จากซอร์ส)

คุณจะต้องใช้ส่วนประกอบต่อไปนี้ในการสร้าง Annotator:

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-7-dev
- libgtk-4-dev
- libxml2-dev
- libarchive-dev
- libwebp-dev

เพื่อทำการติดตั้ง Annotator จากซอร์ส ให้เรียกใช้ `./app install`

เพื่อเรียกใช้ Annotator ให้รัน `com.github.phase1geo.annotator`

### Ubuntu (PPA)

คุณสามารถใช้ [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/) ที่ดูแลโดย @PandaJim ได้ PPA นี้รองรับ Ubuntu 20.04+ ให้ป้อนคำสั่งต่อไปนี้ทีละคำสั่ง

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```

### Arch Linux

หากคุณเป็นผู้ใช้ Arch Linux มี
[แพ็กเกจ AUR](https://aur.archlinux.org/packages/annotator/)
`annotator`:

```
% yay -S annotator
```

### Flatpak

นอกจากนี้ Annotator ยังสามารถติดตั้งและใช้งานผ่าน Flatpak ได้อีกด้วย

หากต้องการสร้าง elementary Flatpak จากซอร์ส ให้รัน `./app elementary`

หากต้องการสร้าง Flathub Flatpak จากซอร์ส ให้รัน `./app flathub`

หลังจากนั้น คุณสามารถเรียกใช้งานด้วย: `./app run-flatpak`

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Get it on AppCenter"/>
  </a>
</p>

## เครดิต

ประกอบด้วย `document-edit-symbolic.svg` และ `image-crop-symbolic.svg` จาก
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic),
ภายใต้เงื่อนไขของสัญญาอนุญาต GPL v3.0


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---