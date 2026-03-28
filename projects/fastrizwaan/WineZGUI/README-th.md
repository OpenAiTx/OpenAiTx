
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### ส่วนติดต่อผู้ใช้ Wine ด้วย Zenity - เล่นและแชร์ได้เลย!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='ดาวน์โหลดจาก Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## WineZGUI คืออะไร

WineZGUI (อ่านว่า ไวน์-ซี-กู-อี) เป็นส่วนหน้า (frontend) ของ Wine สำหรับเล่นเกม Windows บน Wine ได้อย่างง่ายดาย โดยเป็นชุดสคริปต์ Bash สำหรับจัดการ Wine Prefix และบูรณาการกับเดสก์ท็อปของ Linux เพื่อประสบการณ์เล่นเกม Wine ที่ง่ายขึ้นโดยใช้ Zenity ช่วยให้สามารถเปิดโปรแกรมหรือเกม EXE แบบ Direct play (โดยไม่ต้องติดตั้ง) จากตัวจัดการไฟล์อย่าง Nautilus และสร้าง wine prefix แยกสำหรับแต่ละไฟล์ EXE ของ Windows ได้

## ทำไมต้องใช้ WineZGUI?

1. รันเกมหรือไฟล์ exe ของ Windows จากตัวจัดการไฟล์
2. สร้างช็อตคัตของแอปพลิเคชันเพื่อการเข้าถึงที่ง่ายขึ้น
3. เน้นที่การเล่นเกม ไม่ใช่การตั้งค่า prefix
4. สำรองและกู้คืน prefix เพื่อใช้งานในภายหลัง
5. สร้าง Game Bundle เพื่อแบ่งปัน (prefix+เกม)

## WineZGUI ทำงานอย่างไร

1. เมื่อเปิดไบนารีหรือ exe ของ Windows ด้วย WineZGUI,
2. จะสร้าง prefix ใหม่ (คัดลอกจากเทมเพลต) และสร้างช็อตคัตบนเดสก์ท็อปโดยใช้ชื่อไฟล์ EXE
3. เมื่อผู้ใช้เปิดสคริปต์ ไฟล์ exe จะถูกรัน
4. หากเป็นไฟล์ติดตั้ง จะตรวจจับ exe ที่ติดตั้งและสร้างช็อตคัตในหมวดเมนู Games

## วิธีรันเกมหรือโปรแกรมบนไดรฟ์หรือไดเรกทอรีอื่น

เปิด Terminal แล้วพิมพ์คำสั่งนี้:

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### ติดตั้ง WineZGUI

WineZGUI มีให้ติดตั้งเป็น Flatpak บน Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI สามารถเข้าถึงได้แค่ Desktop, Documents, Downloads, Music, Pictures, Videos เท่านั้น หากต้องการเข้าถึงไฟล์จากตำแหน่งอื่นหรือพาร์ติชัน/ไดรฟ์ที่เมานต์ไว้ ต้องคัดลอกไฟล์ไปยังโฟลเดอร์ข้างต้น (Downloads ฯลฯ) หรือให้สิทธิ์อ่านไฟล์โดยใช้แอป Flatseal หรือคำสั่ง `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

ขอแนะนำให้ใช้เวอร์ชัน flatpak เพราะ wine แบบ distro (wine-staging) จะอัปเดตบ่อยและเกมอาจเสียทุกไม่กี่วัน การใช้ wine stable จาก flathub หรือ wine stable 5.0 หรือ 7.0 จากแพ็คเกจของ distro จะดีกว่า

#### ติดตั้ง WineZGUI flatpak บน [Linux ที่รองรับ](https://flatpak.org/setup/)

WineZGUI ถูกแพ็กเกจใน flatpak-wine โดยผู้เขียนเอง [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) และ flatpak-wine เดิม (เลิกใช้แล้ว) [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### การติดตั้งบนระบบ Linux ดูที่ [ข้อกำหนด](https://github.com/fastrizwaan/WineZGUI#requirements)

การติดตั้งทำได้ทันทีเพียงคัดลอกไฟล์ไม่กี่ไฟล์ไปยังไดเรกทอรีที่กำหนด

##### เวอร์ชัน 0.99.13

ดาวน์โหลดซอร์ส [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) หรือใช้ `git tag 0.99.13`

##### การใช้ tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### git tag 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### เวอร์ชันสำหรับพัฒนา

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### ถอนการติดตั้ง WineZGUI

##### ถอนการติดตั้ง Flatpak

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### ถอนการติดตั้งระบบ

รัน `uninstall` จากไดเรกทอรีแหล่งติดตั้งเดียวกัน

```
sudo ./setup --uninstall
```

## ข้อกำหนด

`wine` - โปรแกรมหลัก

`winetricks` - สคริปต์เสริมที่จำเป็นสำหรับ wine

`perl‑image‑exiftool` - สำหรับดึงชื่อแอปพลิเคชัน/เกม

`icoutils` - สำหรับดึงไอคอนจากไฟล์ exe

`gnome-terminal` - (ไม่บังคับ) สำหรับเข้าถึงไดเรกทอรี prefix ใน shell

## การติดตั้งข้อกำหนดสำหรับระบบปฏิบัติการ Linux

### ดิสโทรที่รองรับ Flatpak

ดาวน์โหลด [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) ซึ่งรวมทุก dependency แล้ว เหมาะสำหรับดิสโทรที่ไม่มีแพ็กเกจ wine

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## ข้อกำหนดสำหรับการทำงาน:

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### โซลัส

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### Arch Linux / EndeavourOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### คอนโทรลเลอร์ที่รองรับ XBOX

สร้างและติดตั้งไดรเวอร์เคอร์เนลสำหรับคอนโทรลเลอร์ที่รองรับ xbox 360 จาก https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---