
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 ไดรเวอร์ MT7902 เป็นส่วนย่อยของไดรเวอร์ MT7921 (✅ ใช้งานได้)
ชิป Mediatek mt7902 wifi 6E รองรับบลูทูธและ WiFi

> [!IMPORTANT]
> เคอร์เนล Linux 7.1 รองรับชิป MT7902 WIFI 6E อย่างเป็นทางการ


## 📁 การโคลนรีโพซิทอรี
โคลนรีโพซิทอรีไปยังคอมพิวเตอร์ของคุณ
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
หากคุณไม่ต้องการโคลนประวัติที่ผ่านมา
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## การติดตั้ง


### 🚀 สคริปต์คู่มือการติดตั้ง (แนะนำสำหรับระบบที่ใช้ Ubuntu)
ทำให้สคริปต์สามารถรันได้ หากยังไม่สามารถรันได้
```
chmod +x ./install_guide.sh
```
ตอนนี้ให้เรียกใช้สคริปต์นี้
```
./install_guide.sh
```
ระบบจะขอรหัสผ่านโดยอัตโนมัติเมื่อจำเป็น
* สคริปต์นี้จะถามให้คุณติดตั้งเฟิร์มแวร์ ไดรเวอร์บลูทูธ และไวไฟทีละรายการ
* ทดสอบบน Ubuntu กับเคอร์เนล linux 7.0

### 🚀 วิธีแก้ไขอัตโนมัติง่าย ๆ (แนะนำสำหรับระบบที่ใช้ Arch)
หากคุณต้องการแก้ไข WiFi และ Bluetooth อย่างรวดเร็วบนเคอร์เนลสมัยใหม่ ให้ทำตามขั้นตอนนี้:

ทำให้สคริปต์สามารถรันได้ หากยังไม่ได้ตั้งค่า
```
chmod +x ./fix_my_wifi.sh
```

**เรียกใช้สคริปต์แก้ไขอัตโนมัติ** ด้วย sudo:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 สคริปต์นี้ทำอะไรบ้าง:
* **ตรวจสอบการพึ่งพา:** ตรวจสอบให้แน่ใจว่าคุณมี `gcc`/`clang`, `make`, `bc` และ `kernel-headers` ที่ตรงกับเครื่องของคุณ หากยังไม่มี - จะติดตั้งด้วยตัวจัดการแพ็กเกจที่คุณเลือก
* **คอมไพล์ไดรเวอร์:** สร้างไดรเวอร์ WiFi และ Bluetooth สำหรับ kernel เวอร์ชันของคุณโดยอัตโนมัติ
* **แก้ไขถาวร:** ติดตั้ง system service ที่รับประกันว่า WiFi ของคุณจะยังคงใช้งานได้แม้รีสตาร์ทคอมพิวเตอร์
* **ความปลอดภัย:** ติดตั้งโมดูลลงในไดเรกทอรีเฉพาะ (`/lib/modules/mt7902_custom`) เพื่อไม่ให้ยุ่งกับไฟล์ระบบปกติของคุณ

> [!NOTE]
> คุณจะต้องเชื่อมต่ออินเทอร์เน็ต (ผ่าน Ethernet หรือ USB tethering จากโทรศัพท์ของคุณ) ในการรันครั้งแรกเพื่อดาวน์โหลดเครื่องมือที่จำเป็นในการ build (เช่น compilator, linux-headers ฯลฯ)


## ✅ ทดสอบแล้วบน (ยืนยันว่าใช้งานได้)
การแก้ไขนี้ได้รับการยืนยันและยืนยันว่าใช้งานได้บน:

* **ยี่ห้อ:** ASUS
* **รุ่น:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **ชิปเซ็ต:** MediaTek MT7902 (WiFi 6E)
* **เวอร์ชัน Kernel:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **ระบบปฏิบัติการ:** Arch, Ubuntu
* **ตัวจัดการแพ็กเกจ:** pacman, apt

## รองรับสำหรับ:
* **ระบบปฏิบัติการ**: ระบบปฏิบัติการใดก็ได้ที่รองรับหนึ่งใน PM
* **ตัวจัดการแพ็กเกจที่รองรับ:** apt, pacman, dnf, zypper, nix-shell
* **เวอร์ชัน Kernel:** 6.14-7.0.7


## 🔧 เฟิร์มแวร์ที่ใช้
เฟิร์มแวร์จะถูกเก็บไว้ในโฟลเดอร์ `firmware`


## 📱 Bluetooth ✅ (ใช้งานได้)
> [!WARNING]
> หากไดรเวอร์บลูทูธมีปัญหากับ `gen4-mt7902` ให้ลบไฟล์เฟิร์มแวร์บลูทูธออกเพื่อไม่ให้รบกวนกับไดรเวอร์นี้
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> โปรเจกต์นี้ใช้เฟิร์มแวร์
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

เพื่อเปิดใช้งานบลูทูธ ให้ไปที่ไดเรกทอรีของ kernel เวอร์ชันปัจจุบันของคุณ ``
เช่น หากคุณใช้ kernel linux-6.16 ให้ไปที่ไดเรกทอรี `./linux-6.16/drivers/bluetooth` .
เปิดเทอร์มินัลในไดเรกทอรีนี้และคอมไพล์ด้วยคำสั่ง `make`
โมดูลเคอร์เนลสองตัวจะถูกคอมไพล์คือ `btusb.ko` และ `btmtk.ko`
เพื่อเปิดใช้งานบลูทูธในอุปกรณ์ของคุณ ให้ลบ btusb และ btmtk ในระบบของคุณและติดตั้งไฟล์สองนี้ โดยใช้คำสั่ง
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
ตอนนี้ตรวจสอบว่า Bluetooth ของคุณทำงานแล้วหรือไม่

## 💻 WiFi ✅ (ใช้งานได้)
> [!IMPORTANT]
> ที่เก็บข้อมูลที่ใช้งานได้พร้อมข้อจำกัดบางอย่างอยู่ [ที่นี่](https://github.com/hmtheboy154/gen4-mt7902)

ไดรเวอร์ WiFi สำหรับ mt7902 ซึ่งเพิ่งถูกปล่อยโดย mediatek อยู่ในโฟลเดอร์ `latest`

หากคุณใช้ Ubuntu ให้ไปที่โฟลเดอร์ `latest` แล้วรันคำสั่งต่อไปนี้ในเทอร์มินัล
```
make
```
มันจะคอมไพล์โมดูลทั้งหมด บีบอัด และติดตั้ง (แทนที่โมดูลเคอร์เนลเดิมด้วยโมดูลที่แก้ไขแล้ว) หากคุณใช้ดิสโทรอื่นหรือไม่ต้องการทุกขั้นตอนและต้องการแค่คอมไพล์โค้ด ให้รันในเทอร์มินัล

```
make module_compile
```
เพื่อบีบอัดโมดูลที่คุณได้คอมไพล์แล้ว จากนั้นรันในเทอร์มินัล
```
make module_compress
```
ในการติดตั้งโมดูลที่ถูกบีบอัดไปยังโมดูลเคอร์เนลของระบบ ให้รันในเทอร์มินัล
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---