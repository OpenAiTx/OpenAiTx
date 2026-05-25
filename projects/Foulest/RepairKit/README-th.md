# RepairKit

[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](LICENSE)
[![CodeQL](https://github.com/Foulest/RepairKit/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/Foulest/RepairKit/actions/workflows/github-code-scanning/codeql)
[![Downloads](https://img.shields.io/github/downloads/Foulest/RepairKit/total.svg)](https://github.com/Foulest/RepairKit/releases)

**RepairKit** คือชุดเครื่องมือซ่อมแซมและบำรุงรักษา Windows แบบครบวงจรที่ใช้ Java

[Softpedia](https://softpedia.com/get/System/OS-Enhancements/RepairKit.shtml)
• [MajorGeeks](https://m.majorgeeks.com/files/details/repairkit.html)
• [Uptodown](https://repairkit.en.uptodown.com/windows)
• [AlternativeTo](https://alternativeto.net/software/repairkit/about)

<div align="left">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Foulest&project=RepairKit&lang=as">অসমীয়া</
      </div>
</div>
  </details>
</div>

###

[![RepairKit Banner](https://i.imgur.com/EfAmXt4.png)](https://github.com/Foulest/RepairKit/releases)

###

## คู่มือการติดตั้งและตั้งค่า

<p align="center">
  <a href="https://youtu.be/EMVeKIvVPcg" title="รับชมบน YouTube"><img src="https://i.imgur.com/OOyZmUe.png" alt="รับชมบน YouTube"></a>
</p>

## คุณสมบัติ

### **การซ่อมแซมอัตโนมัติ**

ดำเนินการล้างระบบและซ่อมแซมอย่างครบถ้วนโดยอัตโนมัติ รวมถึง:

- สร้างจุดคืนค่าระบบ (Restore Point)
- ลบนโยบายระบบที่เป็นอันตราย
- ปรับแต่งรีจิสทรีและระบบ
- ลบฟีเจอร์ Windows ที่มีความเสี่ยง
- ปรับตั้งค่าสำหรับ Windows Defender ให้เหมาะสม
- ลบไฟล์ขยะที่หาเจอยาก
- ลบซอฟต์แวร์ที่มาพร้อมเครื่องที่ไม่ต้องการ
- ซ่อมแซมปัญหาดิสก์และไฟล์ Windows ที่เสียหาย
- อัปเดตโปรแกรมที่ติดตั้งที่ล้าสมัย

ทุกฟังก์ชันในการซ่อมแซมสามารถปรับแต่งได้อย่างเต็มที่ คุณสามารถเปิดหรือปิดแต่ละรายการซ่อมแซมตามต้องการโดยใช้
ช่องทำเครื่องหมายบนแผงควบคุม หรือไฟล์การกำหนดค่าในโฟลเดอร์ **config** **โปรดแก้ไขไฟล์เหล่านี้เฉพาะเมื่อคุณมั่นใจในสิ่งที่ทำ**

> **หมายเหตุ:** ตัวเลือก **Remove Malware** ที่เคยมีได้ถูกนำออกแล้ว ขณะนี้ **Run Windows Defender Tweaks**
> จะใช้การตั้งค่าสำหรับ Windows Defender ที่เหมาะสมแทน คุณสามารถสแกนด้วยตนเองผ่านโปรแกรม Emsisoft หรือ Sophos
> ได้ที่ตัวเลือก Scan ในแผงโปรแกรมที่มีประโยชน์


![ซ่อมแซมอัตโนมัติ](https://i.imgur.com/mnkUQV1.png)

### **โปรแกรมที่มีประโยชน์**

เข้าถึงเครื่องมือซอฟต์แวร์สำคัญสำหรับการบำรุงรักษาระบบ รวมถึง:

- **[CPU-Z](https://cpuid.com/softwares/cpu-z.html)**: ตรวจสอบรายละเอียดฮาร์ดแวร์ของระบบคุณ
- **[HWMonitor](https://cpuid.com/softwares/hwmonitor.html)**: ตรวจสอบอุณหภูมิและข้อมูลฮาร์ดแวร์
- **[Emsisoft Scan](https://emsisoft.com/en/home/emergency-kit)**: สแกนมัลแวร์ด้วย Emsisoft Emergency Kit
- **[Sophos Scan](https://sophos.com/en-us/free-tools/virus-removal-tool)**: สแกนมัลแวร์ด้วย Sophos Scan & Clean
- **[TreeSize](https://jam-software.com/treesize_free)**: วิเคราะห์และจัดการเนื้อหาในดิสก์
- **[Everything](https://voidtools.com)**: เครื่องมือค้นหาไฟล์ที่รวดเร็วมาก
- **[CrystalDiskInfo](https://sourceforge.net/projects/crystaldiskinfo)**: ตรวจสอบสุขภาพและสถานะฮาร์ดดิสก์ของคุณ
- **[CrystalDiskMark](https://crystalmark.info/en/software/crystaldiskmark)**: ทดสอบความเร็วอ่าน/เขียนของฮาร์ดดิสก์
- **[Autoruns](https://learn.microsoft.com/en-us/sysinternals/downloads/autoruns)**: ทางเลือกสำหรับตัวจัดการเริ่มต้นระบบ Windows
- **[Process Explorer](https://learn.microsoft.com/en-us/sysinternals/downloads/process-explorer)**: ทางเลือกสำหรับตัวจัดการงาน Windows
- **[Process Monitor](https://learn.microsoft.com/en-us/sysinternals/downloads/procmon)**: ตรวจสอบกิจกรรมและกระบวนการของระบบ
- **[BlueScreenView](https://nirsoft.net/utils/blue_screen_view.html)**: ดูและวิเคราะห์ไฟล์ BSOD crash dumps ของ Windows
- **[NVCleanstall](https://techpowerup.com/download/techpowerup-nvcleanstall)**: ตัวอัปเดตไดรเวอร์การ์ดจอ NVIDIA แบบน้ำหนักเบา
- **[DisplayDriverUninstaller](https://guru3d.com/files-details/display-driver-uninstaller-download.html)**: ลบไดรเวอร์จอและแพ็คเกจออก
- **[Recuva](https://ccleaner.com/recuva)**: เครื่องมือกู้คืนข้อมูลสำหรับไฟล์ที่ถูกลบ
- **[DiskGenius](https://diskgenius.com)**: ตัวจัดการพาร์ติชันและกู้คืนข้อมูลในดิสก์

![โปรแกรมที่มีประโยชน์ (หน้า 1/2)](https://i.imgur.com/NAb78GU.png)

นอกจากนี้ RepairKit ยังมีลิงก์ไปยังเครื่องมือซอฟต์แวร์ที่มีประโยชน์ รวมถึง:

- **[7-Zip](https://7-zip.org)**: ลิงก์ไปยังโปรแกรมบีบอัดไฟล์แบบโอเพ่นซอร์ส
- **[Bitwarden](https://bitwarden.com/download/#downloads-web-browser)**: ลิงก์ไปยังตัวจัดการรหัสผ่านแบบโอเพ่นซอร์ส
- **[Sophos Home](https://home.sophos.com)**: ลิงก์ไปยังซอฟต์แวร์ป้องกันไวรัส Sophos Home
- **[uBlock Origin](https://ublockorigin.com)**: ลิงก์ไปยังส่วนขยายบล็อกโฆษณาที่ทรงพลังสำหรับเบราว์เซอร์
- **[Osprey](https://github.com/Foulest/Osprey)**: ลิงก์ไปยังส่วนขยายปกป้องเบราว์เซอร์
- **[Notepad++](https://notepad-plus-plus.org)**: ลิงก์ไปยังโปรแกรมแก้ไขข้อความแบบโอเพ่นซอร์ส
- **[Twinkle Tray](https://twinkletray.com)**: ลิงก์ไปยังซอฟต์แวร์ควบคุมความสว่างของหน้าจอ






- **[FanControl](https://getfancontrol.com)**: ลิงก์ไปยังซอฟต์แวร์ควบคุมความเร็วพัดลม

![โปรแกรมที่มีประโยชน์ (หน้า 2/2)](https://i.imgur.com/xuQoJqH.png)

### **ทางลัดระบบ**

เข้าถึงยูทิลิตี้สำคัญของ Windows ได้อย่างรวดเร็ว เช่น:

- แอป & ฟีเจอร์
- แอปเริ่มต้น
- Windows Update
- Windows Security
- ตัวจัดการงาน
- และอื่นๆ...

![ทางลัดระบบ](https://i.imgur.com/t5pOrr8.png)

## ดาวน์โหลดและเรียกใช้

ไม่แน่ใจว่าดาวน์โหลดและเรียกใช้ RepairKit อย่างไร? ทำตามขั้นตอนเหล่านี้:

1. ดาวน์โหลดเวอร์ชันล่าสุดของ RepairKit จาก
   [หน้า Releases](https://github.com/Foulest/RepairKit/releases/latest) (คลิกไฟล์ `RepairKit-X.X.X.zip`)
2. แตกไฟล์ ZIP ไปยังโฟลเดอร์บนคอมพิวเตอร์ของคุณ คุณสามารถใช้โปรแกรมอย่าง [7-Zip](https://7-zip.org) เพื่อแตกไฟล์
3. ดับเบิลคลิกที่ไฟล์ `RepairKit-X.X.X.exe` เพื่อเรียกใช้โปรแกรม
4. หาก Windows Defender SmartScreen บล็อกแอป ให้คลิก `ข้อมูลเพิ่มเติม` แล้วคลิก `เรียกใช้ต่อไป`
5. คลิก `ใช่` ที่พรอมต์ User Account Control

ขณะนี้ RepairKit จะเปิดและคุณสามารถเริ่มใช้งานฟีเจอร์ต่างๆ ได้

## การคอมไพล์

1. โคลนรีโพซิทอรี
2. เปิดพรอมต์คำสั่ง/เทอร์มินัลที่ไดเรกทอรีของรีโพซิทอรี
3. รัน `gradlew createExe` บน Windows หรือ `./gradlew createExe` บน macOS หรือ Linux
4. ไฟล์ `RepairKit-X.X.X.zip` ที่สร้างเสร็จจะอยู่ในโฟลเดอร์ `build`

## ขอความช่วยเหลือ


หากต้องการความช่วยเหลือหรือมีข้อสงสัย กรุณาเปิด issue ใน [Issues section](https://github.com/Foulest/RepairKit/issues).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---