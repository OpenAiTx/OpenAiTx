![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# ยินดีต้อนรับสู่ Windows Terminal, Console และ Command-Line repo

<details>
  <summary><strong>สารบัญ</strong></summary>

- [การติดตั้งและใช้งาน Windows Terminal](#installing-and-running-windows-terminal)
  - [Microsoft Store \[แนะนำ\]](#microsoft-store-recommended)
  - [วิธีติดตั้งอื่นๆ](#other-install-methods)
    - [ผ่าน GitHub](#via-github)
    - [ผ่าน Windows Package Manager CLI (หรือ winget)](#via-windows-package-manager-cli-aka-winget)
    - [ผ่าน Chocolatey (ไม่เป็นทางการ)](#via-chocolatey-unofficial)
    - [ผ่าน Scoop (ไม่เป็นทางการ)](#via-scoop-unofficial)
- [การติดตั้ง Windows Terminal Canary](#installing-windows-terminal-canary)
- [แผนการพัฒนา Windows Terminal](#windows-terminal-roadmap)
- [ภาพรวม Terminal & Console](#terminal--console-overview)
  - [Windows Terminal](#windows-terminal)
  - [The Windows Console Host](#the-windows-console-host)
  - [คอมโพเนนต์ที่ใช้ร่วมกัน](#shared-components)
  - [การสร้าง Windows Terminal ใหม่](#creating-the-new-windows-terminal)
- [แหล่งข้อมูล](#resources)
- [FAQ](#faq)
  - [ผมคอมไพล์และรัน Terminal ใหม่แล้ว แต่หน้าตาเหมือนคอนโซลเดิม](#i-built-and-ran-the-new-terminal-but-it-looks-just-like-the-old-console)
- [เอกสาร](#documentation)
- [การร่วมพัฒนา](#contributing)
- [การติดต่อทีมงาน](#communicating-with-the-team)
- [คำแนะนำสำหรับนักพัฒนา](#developer-guidance)
- [ข้อกำหนดเบื้องต้น](#prerequisites)
- [การคอมไพล์โค้ด](#building-the-code)
  - [คอมไพล์ใน PowerShell](#building-in-powershell)
  - [คอมไพล์ใน Cmd](#building-in-cmd)
- [การรัน & ดีบั๊ก](#running--debugging)
  - [แนวทางการเขียนโค้ด](#coding-guidance)
- [จรรยาบรรณการใช้โค้ด](#code-of-conduct)

</details>

<br />

ที่เก็บนี้ประกอบด้วยซอร์สโค้ดสำหรับ:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* Windows console host (`conhost.exe`)
* คอมโพเนนต์ที่ใช้ร่วมกันระหว่างสองโปรเจกต์
* [ColorTool](./src/tools/ColorTool)
* [โปรเจกต์ตัวอย่าง](./samples)
  ที่แสดงวิธีเรียกใช้งาน Windows Console APIs

ที่เก็บที่เกี่ยวข้อง:

* [เอกสาร Windows Terminal](https://docs.microsoft.com/windows/terminal)
  ([Repo: ร่วมแก้ไขเอกสาร](https://github.com/MicrosoftDocs/terminal))
* [เอกสาร Console API](https://github.com/MicrosoftDocs/Console-Docs)
* [ฟอนต์ Cascadia Code](https://github.com/Microsoft/Cascadia-Code)

## การติดตั้งและใช้งาน Windows Terminal

> [!NOTE]
> Windows Terminal ต้องใช้ Windows 10 2004 (build 19041) หรือใหม่กว่า

### Microsoft Store [แนะนำ]

ติดตั้ง [Windows Terminal จาก Microsoft Store][store-install-link]
วิธีนี้จะช่วยให้คุณได้รับเวอร์ชันล่าสุดเสมอเมื่อมีการอัปเดตใหม่โดยอัตโนมัติ

นี่เป็นวิธีที่เราขอแนะนำ

### วิธีติดตั้งอื่นๆ

#### ผ่าน GitHub

สำหรับผู้ใช้ที่ไม่สามารถติดตั้ง Windows Terminal จาก Microsoft Store ได้
สามารถดาวน์โหลดไฟล์ติดตั้งแต่ละเวอร์ชันได้จากหน้า [Releases](https://github.com/microsoft/terminal/releases) ของที่เก็บนี้

ดาวน์โหลดไฟล์ `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` จาก
ส่วน **Assets** เพื่อทำการติดตั้งแอป ให้ดับเบิลคลิกที่ไฟล์
`.msixbundle` และตัวติดตั้งจะทำงานโดยอัตโนมัติ หากติดตั้งไม่สำเร็จ คุณสามารถใช้คำสั่งนี้ใน PowerShell ได้เช่นกัน:

```powershell
# หมายเหตุ: หากคุณใช้ PowerShell 7+ กรุณารัน
# Import-Module Appx -UseWindowsPowerShell
# ก่อนใช้งาน Add-AppxPackage

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> หากคุณติดตั้ง Terminal ด้วยตนเอง:
>
> * อาจจำเป็นต้องติดตั้ง [VC++ v14 Desktop Framework Package](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages)
>   ซึ่งจำเป็นเฉพาะบน Windows 10 เวอร์ชันเก่า และเฉพาะเมื่อเกิดข้อผิดพลาดเกี่ยวกับแพ็กเกจเฟรมเวิร์กที่ขาดหายไป
> * Terminal จะไม่อัปเดตอัตโนมัติเมื่อมีเวอร์ชันใหม่ ดังนั้นคุณต้องติดตั้ง Terminal เวอร์ชันล่าสุดด้วยตนเองเป็นประจำเพื่อรับการแก้ไขและปรับปรุงใหม่ๆ!

#### ผ่าน Windows Package Manager CLI (หรือ winget)

ผู้ใช้ [winget](https://github.com/microsoft/winget-cli) สามารถดาวน์โหลดและติดตั้ง
Windows Terminal เวอร์ชันล่าสุดโดยติดตั้งแพ็กเกจ `Microsoft.WindowsTerminal`:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> การรองรับ dependency มีอยู่ใน WinGet เวอร์ชัน [1.6.2631 หรือใหม่กว่า](https://github.com/microsoft/winget-cli/releases) หากต้องการติดตั้ง Terminal เวอร์ชันเสถียร 1.18 หรือใหม่กว่า กรุณาตรวจสอบให้แน่ใจว่าได้อัปเดต WinGet client แล้ว

#### ผ่าน Chocolatey (ไม่เป็นทางการ)

ผู้ใช้ [Chocolatey](https://chocolatey.org) สามารถดาวน์โหลดและติดตั้ง
Windows Terminal เวอร์ชันล่าสุดโดยติดตั้งแพ็กเกจ `microsoft-windows-terminal`:

```powershell
choco install microsoft-windows-terminal
```

หากต้องการอัปเกรด Windows Terminal ด้วย Chocolatey ให้รันคำสั่งต่อไปนี้:

```powershell
choco upgrade microsoft-windows-terminal
```

หากพบปัญหาในการติดตั้งหรืออัปเกรดแพ็กเกจ กรุณาไปที่
[หน้ารายการแพ็กเกจ Windows Terminal](https://chocolatey.org/packages/microsoft-windows-terminal)
และดำเนินการตาม [ขั้นตอนการแก้ไขปัญหา Chocolatey](https://chocolatey.org/docs/package-triage-process)

#### ผ่าน Scoop (ไม่เป็นทางการ)

ผู้ใช้ [Scoop](https://scoop.sh) สามารถดาวน์โหลดและติดตั้ง
Windows Terminal เวอร์ชันล่าสุดโดยติดตั้งแพ็กเกจ `windows-terminal`:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

หากต้องการอัปเดต Windows Terminal ด้วย Scoop ให้รันคำสั่งต่อไปนี้:

```powershell
scoop update windows-terminal
```

หากพบปัญหาในการติดตั้ง/อัปเดตแพ็กเกจ โปรดค้นหาหรือรายงานปัญหาที่ [หน้ารายงานปัญหา](https://github.com/lukesampson/scoop-extras/issues) ของ Scoop Extras bucket repository

---

## การติดตั้ง Windows Terminal Canary
Windows Terminal Canary คือ build รายวันของ Windows Terminal โดย build นี้จะมีซอร์สโค้ดล่าสุดจาก branch `main` ให้คุณได้ทดลองฟีเจอร์ใหม่ๆ ก่อนที่จะเข้าสู่ Windows Terminal Preview

Windows Terminal Canary เป็น build ที่ไม่เสถียรที่สุด อาจพบข้อผิดพลาดก่อนที่เราจะตรวจพบ

Windows Terminal Canary มีทั้งแบบ App Installer และ Portable ZIP

App Installer รองรับการอัปเดตอัตโนมัติ โดยตัวติดตั้งนี้ใช้ได้เฉพาะบน Windows 11

Portable ZIP เป็นแอปแบบพกพา ไม่อัปเดตอัตโนมัติและไม่ตรวจสอบการอัปเดต ตัว Portable ZIP ใช้งานได้ทั้ง Windows 10 (19041+) และ Windows 11

| แบบติดตั้ง      | สถาปัตยกรรม    | ลิงก์                                                  |
|-----------------|:---------------:|--------------------------------------------------------|
| App Installer   | x64, arm64, x86 | [ดาวน์โหลด](https://aka.ms/terminal-canary-installer) |
| Portable ZIP    | x64             | [ดาวน์โหลด](https://aka.ms/terminal-canary-zip-x64)   |
| Portable ZIP    | ARM64           | [ดาวน์โหลด](https://aka.ms/terminal-canary-zip-arm64) |
| Portable ZIP    | x86             | [ดาวน์โหลด](https://aka.ms/terminal-canary-zip-x86)   |

_เรียนรู้เพิ่มเติมเกี่ยวกับ [ประเภทของ Windows Terminal distributions](https://learn.microsoft.com/windows/terminal/distributions)_

---

## แผนการพัฒนา Windows Terminal

แผนสำหรับ Windows Terminal [อธิบายไว้ที่นี่](/doc/roadmap-2023.md) และจะมีการอัปเดตเมื่อโปรเจกต์ดำเนินไป

## ภาพรวม Terminal & Console

โปรดสละเวลาอ่านภาพรวมด้านล่างก่อนเริ่มใช้งานซอร์สโค้ด:

### Windows Terminal

Windows Terminal คือแอปเทอร์มินัลที่ทันสมัย มีฟีเจอร์ครบถ้วน และเพิ่มประสิทธิภาพสำหรับผู้ใช้ command-line มีฟีเจอร์ที่ชุมชนผู้ใช้ Windows command-line เรียกร้อง เช่น แท็บ, rich text, การรองรับหลายภาษา, การปรับแต่ง, ธีม & สไตล์ และอื่นๆ

Terminal ยังต้องตอบโจทย์เป้าหมายเพื่อให้ใช้งานได้รวดเร็ว มีประสิทธิภาพ ไม่ใช้ทรัพยากรหน่วยความจำหรือพลังงานมากเกินไป

### The Windows Console Host

Windows Console host หรือ `conhost.exe` คือประสบการณ์ command-line ดั้งเดิมของ Windows และเป็นโครงสร้างพื้นฐานของ command-line และ Windows Console API server, engine การรับอินพุต, engine การเรนเดอร์, ค่าตั้งค่าผู้ใช้ ฯลฯ โค้ด console host ในที่เก็บนี้คือซอร์สจริงที่ใช้สร้าง `conhost.exe` บน Windows

ตั้งแต่ปี 2014 ทีมงานได้เพิ่มฟีเจอร์ใหม่ให้ Console เช่น พื้นหลังโปร่งแสง, การเลือกตามบรรทัด, รองรับ [ANSI / Virtual Terminal sequences](https://en.wikipedia.org/wiki/ANSI_escape_code), [สี 24-bit](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/), [Pseudoconsole ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) และอื่นๆ

อย่างไรก็ตาม เนื่องจาก Console มีเป้าหมายหลักคือรักษาความเข้ากันได้ย้อนหลัง เราจึงไม่สามารถเพิ่มฟีเจอร์ใหม่ๆ ที่ชุมชนต้องการ เช่น แท็บ, ข้อความ unicode, และอีโมจิ

ข้อจำกัดเหล่านี้เป็นแรงผลักดันให้เราสร้าง Windows Terminal ใหม่

> สามารถอ่านเพิ่มเติมเกี่ยวกับวิวัฒนาการของ command-line ได้ที่ [ชุดบทความในบล็อกนี้](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/) ของทีม Command-Line

### คอมโพเนนต์ที่ใช้ร่วมกัน

ระหว่างการยกเครื่อง Windows Console เราได้ปรับปรุงโค้ดเบสอย่างมาก แยกองค์ประกอบเชิงตรรกะออกเป็นโมดูลและคลาส เพิ่มจุดขยายระบบ เปลี่ยนคอลเลกชัน/คอนเทนเนอร์ที่เขียนเองเป็น [STL containers](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) ที่ปลอดภัยและมีประสิทธิภาพกว่า และทำให้โค้ดเรียบง่ายและปลอดภัยขึ้นด้วย [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil)

การยกเครื่องนี้ทำให้คอมโพเนนต์สำคัญหลายตัวของ Console สามารถนำไปใช้ซ้ำในเทอร์มินัลใดๆ บน Windows ได้ เช่น engine จัดวางและเรนเดอร์ข้อความใหม่ที่ใช้ DirectWrite, text buffer ที่รองรับทั้ง UTF-16 และ UTF-8, VT parser/emitter และอื่นๆ

### การสร้าง Windows Terminal ใหม่

เมื่อเริ่มวางแผนสำหรับ Windows Terminal เราสำรวจและประเมินแนวทางและเทคโนโลยีต่างๆ สุดท้ายเราตัดสินใจว่าเป้าหมายของเราจะสำเร็จดีที่สุดด้วยการลงทุนต่อในโค้ดเบส C++ เดิม ซึ่งช่วยให้เรานำคอมโพเนนต์สมัยใหม่ที่กล่าวมาใช้ซ้ำได้ทั้งใน Console เดิมและ Terminal ใหม่ นอกจากนี้ยังช่วยให้เราสร้าง UI control หลักของ Terminal ให้ผู้อื่นนำไปใช้งานในแอปของตนเองได้

ผลลัพธ์ของงานทั้งหมดนี้อยู่ในที่เก็บนี้ และถูกส่งมอบเป็นแอป Windows Terminal ที่คุณสามารถดาวน์โหลดได้จาก Microsoft Store หรือ [จาก releases ของ repo นี้](https://github.com/microsoft/terminal/releases)

---

## แหล่งข้อมูล

สำหรับข้อมูลเพิ่มเติมเกี่ยวกับ Windows Terminal คุณอาจสนใจแหล่งข้อมูลเหล่านี้:

* [บล็อก Command-Line](https://devblogs.microsoft.com/commandline)
* [ชุดบทความ Command-Line Backgrounder](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* เปิดตัว Windows Terminal: [Terminal "Sizzle Video"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* เปิดตัว Windows Terminal: [Build 2019 Session](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal กับ Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [ตอนที่ 54 - Kayla Cinnamon และ Rich Turner เกี่ยวกับ DevOps บนทีม Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Session: [The Modern Windows Command Line: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## FAQ

### ผมคอมไพล์และรัน Terminal ใหม่แล้ว แต่หน้าตาเหมือนคอนโซลเดิม

สาเหตุ: คุณกำลังเปิด solution ผิดตัวใน Visual Studio

วิธีแก้: ตรวจสอบให้แน่ใจว่าคุณกำลังคอมไพล์และ deploy โปรเจกต์ `CascadiaPackage` ใน Visual Studio

> [!NOTE]
> `OpenConsole.exe` เป็นเพียง `conhost.exe` ที่คอมไพล์ในเครื่องเท่านั้น ซึ่งเป็น Windows Console ดั้งเดิมที่โฮสต์โครงสร้างพื้นฐาน command-line ของ Windows OpenConsole ถูกใช้โดย Windows Terminal เพื่อเชื่อมต่อและสื่อสารกับแอป command-line (ผ่าน [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/))

---

## เอกสาร

เอกสารทั้งหมดของโปรเจกต์อยู่ที่ [aka.ms/terminal-docs](https://aka.ms/terminal-docs) หากคุณต้องการร่วมพัฒนาเอกสาร กรุณาส่ง pull request ที่ [ที่เก็บเอกสาร Windows Terminal](https://github.com/MicrosoftDocs/terminal)

---

## การร่วมพัฒนา

เรายินดีเป็นอย่างยิ่งที่ได้ร่วมงานกับคุณ ชุมชนที่ยอดเยี่ยมของเรา เพื่อสร้างและพัฒนา Windows Terminal ให้ดียิ่งขึ้น!

***ก่อนที่คุณจะเริ่มทำฟีเจอร์หรือแก้ไขใดๆ*** กรุณาอ่านและปฏิบัติตาม
[คู่มือผู้ร่วมพัฒนา](./CONTRIBUTING.md)
เพื่อหลีกเลี่ยงการทำงานซ้ำซ้อนหรือเสียเปล่า

## การติดต่อทีมงาน

วิธีที่ง่ายที่สุดในการติดต่อทีมงานคือผ่าน GitHub issues

กรุณาแจ้งปัญหา คำขอฟีเจอร์ และข้อเสนอแนะใหม่ๆ แต่อย่าลืม **ค้นหาปัญหาที่มีอยู่แล้วก่อนสร้าง issue ใหม่**

หากคุณมีคำถามที่ไม่ถึงขั้นต้องเปิด issue กรุณาติดต่อเราทาง Twitter:

* Christopher Nguyen, Product Manager:
  [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, Engineering Lead: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, Senior Developer: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, Developer: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, Developer
* Leonard Hecker, Developer: [@LeonardHecker](https://twitter.com/LeonardHecker)

## คำแนะนำสำหรับนักพัฒนา

## ข้อกำหนดเบื้องต้น

คุณสามารถตั้งค่าสภาพแวดล้อมเพื่อคอมไพล์ Terminal ได้สองวิธี:

### ใช้ไฟล์ WinGet configuration

หลังจากโคลนที่เก็บแล้ว คุณสามารถใช้ [ไฟล์ WinGet configuration](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine)
เพื่อตั้งค่าสภาพแวดล้อมของคุณ ไฟล์ [configuration เริ่มต้น](.config/configuration.winget) จะติดตั้ง Visual Studio 2022 Community และเครื่องมือที่จำเป็นอื่นๆ มีไฟล์ configuration สำหรับ Visual Studio 2022 รุ่น Enterprise และ Professional ในไดเรกทอรี [.config](.config) ด้วย หากต้องการรันไฟล์ configuration เริ่มต้น ให้ดับเบิลคลิกที่ไฟล์จาก explorer หรือรันคำสั่งนี้:

```powershell
winget configure .config\configuration.winget
```

### การตั้งค่าด้วยตนเอง

* ต้องใช้ Windows 10 2004 (build >= 10.0.19041.0) หรือใหม่กว่า
* ต้อง [เปิดใช้งาน Developer Mode ในแอปตั้งค่า Windows](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development) เพื่อให้ติดตั้งและรัน Windows Terminal ในเครื่องได้
* ต้องติดตั้ง [PowerShell 7 หรือใหม่กว่า](https://github.com/PowerShell/PowerShell/releases/latest)
* ต้องติดตั้ง [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
* ต้องติดตั้ง [VS 2022](https://visualstudio.microsoft.com/downloads/)
* ต้องติดตั้ง Workloads ต่อไปนี้ผ่าน VS Installer หมายเหตุ: การเปิด solution ใน VS 2022 จะ [แจ้งให้ติดตั้งคอมโพเนนต์ที่ขาดหายไปโดยอัตโนมัติ](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * Desktop Development with C++
  * Universal Windows Platform Development
  * **Individual Components ต่อไปนี้**
    * C++ (v143) Universal Windows Platform Tools
* ต้องติดตั้ง [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) เพื่อคอมไพล์โปรเจกต์ทดสอบ

## การคอมไพล์โค้ด

OpenConsole.sln สามารถคอมไพล์ได้ทั้งใน Visual Studio หรือผ่าน command-line โดยใช้สคริปต์และเครื่องมือในไดเรกทอรี **/tools**:

### คอมไพล์ใน PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### คอมไพล์ใน Cmd

```shell
.\tools\razzle.cmd
bcz
```

## การรัน & ดีบั๊ก

หากต้องการดีบั๊ก Windows Terminal ใน VS ให้คลิกขวาที่ `CascadiaPackage` (ใน Solution Explorer) แล้วไปที่ properties ในเมนู Debug ให้เปลี่ยน "Application process" และ "Background task process" เป็น "Native Only"

จากนั้นคุณจะสามารถคอมไพล์และดีบั๊กโปรเจกต์ Terminal ได้โดยกด <kbd>F5</kbd> ตรวจสอบให้เลือกแพลตฟอร์ม "x64" หรือ "x86" เท่านั้น - Terminal ไม่รองรับ "Any Cpu" (เนื่องจากเป็นแอป C++ ไม่ใช่ C#)

> 👉 คุณ _จะไม่สามารถ_ เปิด Terminal ได้โดยตรงด้วยการรัน WindowsTerminal.exe ดูรายละเอียดเพิ่มเติมได้ที่
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### แนวทางการเขียนโค้ด

โปรดอ่านเอกสารสั้นๆ เกี่ยวกับแนวทางปฏิบัติในการเขียนโค้ดของเรา

> 👉 หากคุณพบว่าส่วนใดในเอกสารเหล่านี้ขาดหายไป สามารถร่วมแก้ไขหรือเขียนเอกสารใหม่ในที่เก็บนี้ได้เสมอ

นี่เป็นงานที่กำลังดำเนินการอยู่ เพื่อให้ผู้ร่วมพัฒนาสามารถมีส่วนร่วมกับโปรเจกต์ของเราได้อย่างมีประสิทธิภาพ

* [รูปแบบการเขียนโค้ด](./doc/STYLE.md)
* [โครงสร้างโค้ด](./doc/ORGANIZATION.md)
* [ข้อยกเว้นในโค้ดเก่า](./doc/EXCEPTIONS.md)
* [smart pointer และ macro ที่มีประโยชน์สำหรับใช้กับ Windows ใน WIL](./doc/WIL.md)

---

## จรรยาบรรณการใช้โค้ด

โปรเจกต์นี้ใช้ [Microsoft Open Source Code of Conduct][conduct-code] ดูรายละเอียดเพิ่มเติมที่ [FAQ เรื่องจรรยาบรรณ](https://opensource.microsoft.com/codeofconduct/faq/) หรือสอบถามเพิ่มเติมได้ที่ [opencode@microsoft.com][conduct-email]

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---