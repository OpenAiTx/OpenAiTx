
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Nutty [![Translation status](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Build Status](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
เครื่องมือยูทิลิตี้เครือข่าย

ผู้เขียน: Siddhartha Das

แอปพลิเคชันง่าย ๆ ที่สร้างขึ้นสำหรับ elementary OS เพื่อแสดงข้อมูลสำคัญเกี่ยวกับเครือข่าย ข้อมูลจะแสดงในแท็บต่อไปนี้<br>
1. ข้อมูลของฉัน: ให้ข้อมูลพื้นฐานและข้อมูลเชิงลึกของการ์ดเครือข่ายบนอุปกรณ์<br>
2. การใช้งาน: แสดงข้อมูลการใช้งานเครือข่ายในสองมุมมอง - การใช้งานย้อนหลังและการใช้งานปัจจุบัน<br>
3. ความเร็ว: ตรวจสอบความเร็วอัปโหลดและดาวน์โหลด รวมถึงรับเวลาการเข้าถึงโฮสต์<br>
4. พอร์ต: ให้ข้อมูลเกี่ยวกับพอร์ตที่ใช้งานอยู่และแอปพลิเคชันที่กำลังใช้บนอุปกรณ์เครื่องนี้<br>
5. อุปกรณ์: ตรวจสอบ แจ้งเตือน และให้ข้อมูลเกี่ยวกับอุปกรณ์อื่นที่เชื่อมต่อกับเครือข่าย<br>

ตรวจสอบเว็บไซต์ Nutty สำหรับรายละเอียดฟีเจอร์ คีย์ลัด คู่มือการติดตั้งบน Ubuntu และดิสโตรที่รองรับอื่น ๆ ฯลฯ : <br>
https://babluboy.github.io/nutty/

## การคอมไพล์ ทดสอบ และติดตั้งจากซอร์ส

คุณจะต้องมี dependencies ต่อไปนี้สำหรับการคอมไพล์:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

และ dependencies เหล่านี้สำหรับการรันโปรแกรม:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

บางครั้ง vnstat อาจไม่เริ่มทำงานหลังติดตั้ง กรุณาใช้คำสั่งของระบบ init ที่เหมาะสมเพื่อเริ่ม daemon vnstat เช่น `sudo systemctl enable vnstat`

รัน `meson build` เพื่อกำหนดค่าสภาพแวดล้อมการคอมไพล์ และรัน `ninja test` เพื่อคอมไพล์

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```

ในการติดตั้ง ให้ใช้ `sudo ninja install` แล้วจึงเรียกใช้งานด้วย `com.github.babluboy.nutty`

```
sudo ninja install
com.github.babluboy.nutty
```
หากต้องการถอนการติดตั้ง ให้ไปที่ไดเรกทอรี build และรัน

```
sudo ninja uninstall
```

### การติดตั้งจากแพ็คเกจ Deb

ในการติดตั้ง Nutty จากแพ็คเกจ `.deb` ให้แน่ใจว่าคุณได้ติดตั้งการพึ่งพาที่จำเป็นสำหรับการใช้งาน Nutty ทั้งหมดตามที่กล่าวไว้ข้างต้นแล้ว (ไม่จำเป็นต้องติดตั้งการพึ่งพาสำหรับการคอมไพล์) จากนั้นให้รันคำสั่งด้านล่างนี้
```bash
sudo dpkg -i <deb-package-name>.deb
```

และหากต้องการถอนการติดตั้ง Nutty ที่ติดตั้งผ่านแพ็กเกจ `.deb` ให้รัน
```bash
sudo apt autoremove com.github.babluboy.nutty
```
หากคุณต้องการสร้างแพ็กเกจ `.deb` ของ Nutty ด้วยตัวเองโดยตรง ให้ติดตั้งแพ็กเกจที่จำเป็นสำหรับการ build ข้างต้นก่อน แล้วจึงรัน

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---