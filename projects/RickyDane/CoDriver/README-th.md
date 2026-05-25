
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='ซื้อกาแฟให้ฉันที่ ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  ตัวสำรวจไฟล์ง่าย ๆ ที่เกิดขึ้นเพราะฉันอยากเรียนรู้ภาษา Rust
  <br>
  สามารถใช้งานได้กับทุกระบบปฏิบัติการและถูกปรับแต่งให้เหมาะสมสำหรับการเพิ่มประสิทธิภาพ
</p>

<br/><br/>

ประสิทธิภาพนี้เกิดจากการใช้ ["jwalk"](https://crates.io/crates/jwalk/versions) และ ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver ไม่ใช้การแคช path เพื่อเข้าถึงไฟล์และโฟลเดอร์ ดังนั้นประสิทธิภาพจึงขึ้นอยู่กับ Rust, ความเร็วของดิสก์ และพลังของ cpu

⁉️ โปรดทราบว่าซอฟต์แวร์นี้ยังอยู่ระหว่างการพัฒนาและอาจมีบั๊ก!
<br/><br/>

# ลิงก์
- <a href="#basic-features">ฟีเจอร์พื้นฐาน</a>
- <a href="#advanced-features">ฟีเจอร์ขั้นสูง</a>
- <a href="#dependencies-if-not-working-instantly">การพึ่งพา</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">การใช้งาน FTP (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">ปัญหาที่ทราบแล้ว</a>
- <a href="#-todos">รายการที่ต้องทำ</a>
- <a href="#user-interface">ส่วนติดต่อผู้ใช้</a>

## คุณสมบัติพื้นฐาน
- นำทางผ่านไดเรกทอรีตามที่คุณคุ้นเคย
- คัดลอก & วาง, ลบ, สร้าง และเปลี่ยนชื่อไฟล์และโฟลเดอร์
- สลับระหว่างโหมดกริด, รายการ และคอลัมน์มิลเลอร์
- ปิดป็อปอัพด้วยปุ่ม esc
- ไปยังไดเรกทอรีโดยตรงด้วย Ctrl / Cmd + G โดยกรอกเส้นทาง
- เรียงรายการในโหมดรายการตามขนาด, ชื่อ หรือแก้ไขล่าสุด

## คุณสมบัติขั้นสูง
- บีบอัดไฟล์และโฟลเดอร์
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- แตกไฟล์บีบอัด
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- นำทางไปยังไดเรกทอรีด้วยปุ่มลัด LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)
  - กำหนดเส้นทางเองในหน้าการตั้งค่า
- สร้างไฟล์ด้วย F6
- สร้างโฟลเดอร์ด้วย F7
- มุมมองแบบสองพาเนล
  - ค้นหาไฟล์ด้วย F8
  - คัดลอกองค์ประกอบที่เลือกไปยังพาเนลอื่นด้วย F5
  - ย้ายองค์ประกอบที่เลือกไปยังพาเนลอื่นด้วย LShift + F5
- ลากและวางไฟล์ในตัวสำรวจเพื่อคัดลอกไปยังไดเรกทอรีปัจจุบัน
- เปลี่ยนชื่อหลายรายการที่เลือกด้วย Ctrl / Cmd + LShift + M
  - รันเปลี่ยนชื่อหลายรายการด้วย Ctrl / Cmd + Return
- ดูตัวอย่างไฟล์อย่างรวดเร็ว -> เลือกรายการในไดเรกทอรีแล้วกดปุ่ม space bar
  - ไฟล์ที่รองรับ: ไฟล์รูปภาพทั้งหมด (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - รายการอื่นๆ จะแสดงกระเบื้องเล็กพร้อมข้อมูลบางอย่าง (เส้นทาง, ขนาด, แก้ไขล่าสุด)
- นำทางทันที -> เริ่มพิมพ์และกรองรายการในไดเรกทอรีโดยอัตโนมัติทำให้บางครั้ง <br/>
  นำทางไปยังตำแหน่งที่ต้องการได้เร็วกว่ามาก

## การพึ่งพา (หากใช้งานไม่ได้ทันที)

<details>
<summary>ขยายเพื่อแสดง</summary>

### ลินุกซ์

- openssl1.1

#### เดเบียน / อูบุนตู
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Arch
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Fedora
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ การเชื่อมต่อ FTP (sshfs)
<details>
  <summary>ขยายเพื่อแสดง</summary>
  <br/>
  ข้อกำหนดเพิ่มเติม (ต้องติดตั้งเพิ่มเติม):
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | ยังไม่รองรับ **_ขณะนี้_** |

  ### การติดตั้ง:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### ลินุกซ์
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ การรองรับภาษา
- ภาษาอังกฤษ
  - ตัวเลือกสำหรับเลือกภาษากำลังจะมาเร็วๆ นี้ ...
</details>

## ⚠️ ปัญหาที่ทราบแล้ว:
- การลากและวางออกนอกหน้าต่างยังใช้งานไม่ได้เสมอไปบน linux
- บน windows คุณอาจต้องติดตั้ง [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- การอนุญาตบน ms-windows อาจจะแปลกนิดหน่อย
  - คุณอาจต้องรันโปรแกรมในฐานะผู้ดูแลระบบหากพบปัญหาในการคัดล้ององค์ประกอบหรือสิ่งที่คล้ายกัน
- อาจมีปัญหาที่คุณต้องติดตั้ง openssl1.1 บนระบบ linux เมื่อโปรแกรมไม่เริ่มทำงาน

## 📝 สิ่งที่ต้องทำ:
- หลายภาษา
- รายการโปรด
- เข้าถึงบริการจัดเก็บข้อมูลออนไลน์ (Google drive ฯลฯ)

## ส่วนติดต่อผู้ใช้
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## วิธีการร่วมพัฒนา
ตั้งค่าคอมพิวเตอร์ของคุณสำหรับการพัฒนาแอป tauri v1: [Tauri prerequisites](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
เมื่อเสร็จแล้วให้พิมพ์ ```git clone https://github.com/RickyDane/CoDriver``` หรือ ```gh repo clone RickyDane/CoDriver``` ในตำแหน่งใดก็ได้บนเครื่องของคุณ
</br></br>
คุณควรจะสามารถรัน ```cargo tauri dev``` ในไดเรกทอรีรากของโปรเจกต์นี้เพื่อเริ่มต้นสร้างและรัน CoDriver
</br>
อย่าลืมติดตั้ง tauri-cli: ```cargo install tauri-cli```
</br>

## การเซ็นรับรองการปล่อยเวอร์ชัน
ไฟล์ที่ปล่อยสำหรับ macOS จะต้องถูกเซ็นและรับรองความถูกต้อง (notarized) เพื่อหลีกเลี่ยงไม่ให้ Gatekeeper รายงานว่าแอปที่ติดตั้งเสียหาย โปรดดู [macOS signing and notarization](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) สำหรับความลับของ GitHub Actions ที่จำเป็นและคำสั่งตรวจสอบ

## ประวัติการให้ดาว

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="แผนภูมิประวัติการให้ดาว" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### ซอฟต์แวร์ของบุคคลที่สามอื่น ๆ
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---