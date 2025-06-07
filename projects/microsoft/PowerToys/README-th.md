# Microsoft PowerToys

![Hero image for Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[วิธีใช้ PowerToys][usingPowerToys-docs-link] | [ดาวน์โหลด & หมายเหตุเวอร์ชัน][github-release-link] | [การมีส่วนร่วมกับ PowerToys](#contributing) | [มีอะไรเกิดขึ้น](#whats-happening) | [แผนงาน](#powertoys-roadmap)

## เกี่ยวกับ

Microsoft PowerToys คือชุดเครื่องมือสำหรับผู้ใช้ระดับสูงเพื่อปรับแต่งและเพิ่มประสิทธิภาพการใช้งาน Windows ให้มีประสิทธิผลมากยิ่งขึ้น หากต้องการข้อมูลเพิ่มเติมเกี่ยวกับ [ภาพรวม PowerToys และวิธีใช้เครื่องมือต่าง ๆ][usingPowerToys-docs-link] หรือเครื่องมือและทรัพยากรอื่น ๆ สำหรับ [สภาพแวดล้อมการพัฒนา Windows](https://learn.microsoft.com/windows/dev-environment/overview) สามารถเข้าไปดูที่ [learn.microsoft.com][usingPowerToys-docs-link]!

|              | ยูทิลิตี้ปัจจุบัน: |              |
|--------------|--------------------|--------------|
| [Advanced Paste](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Always on Top](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Color Picker](https://aka.ms/PowerToysOverview_ColorPicker) | [Command Not Found](https://aka.ms/PowerToysOverview_CmdNotFound) | [Command Palette](https://aka.ms/PowerToysOverview_CmdPal) |
| [Crop And Lock](https://aka.ms/PowerToysOverview_CropAndLock) | [Environment Variables](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [File Explorer Add-ons](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts File Editor](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Image Resizer](https://aka.ms/PowerToysOverview_ImageResizer) | [Keyboard Manager](https://aka.ms/PowerToysOverview_KeyboardManager) | [Mouse utilities](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Mouse Without Borders](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [Paste as Plain Text](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Quick Accent](https://aka.ms/PowerToysOverview_QuickAccent) | [Registry Preview](https://aka.ms/PowerToysOverview_RegistryPreview) | [Screen Ruler](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Shortcut Guide](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Text Extractor](https://aka.ms/PowerToysOverview_TextExtractor) | [Workspaces](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## การติดตั้งและใช้งาน Microsoft PowerToys

### ข้อกำหนด

- Windows 11 หรือ Windows 10 เวอร์ชัน 2004 (ชื่อรหัส 20H1 / หมายเลขบิลด์ 19041) หรือใหม่กว่า
- โปรเซสเซอร์ x64 หรือ ARM64
- ตัวติดตั้งของเราจะติดตั้งสิ่งเหล่านี้:
   - [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703) bootstrapper ซึ่งจะติดตั้งเวอร์ชันล่าสุด

### ผ่าน GitHub ด้วย EXE [แนะนำ]

ไปที่ [หน้าดาวน์โหลด Microsoft PowerToys ใน GitHub][github-release-link] แล้วคลิกที่ `Assets` ด้านล่างเพื่อแสดงไฟล์ที่มีในเวอร์ชันนั้น โปรดใช้ตัวติดตั้ง PowerToys ที่ตรงกับสถาปัตยกรรมและขอบเขตการติดตั้งของเครื่องคุณ สำหรับผู้ใช้ส่วนใหญ่จะเป็น `x64` และแบบต่อผู้ใช้

<!-- items that need to be updated release to release -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe 
 
|  รายละเอียด   | ชื่อไฟล์ | sha256 hash |
|----------------|----------|-------------|
| ต่อผู้ใช้ - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| ต่อผู้ใช้ - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| ทั้งเครื่อง - x64   | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| ทั้งเครื่อง - ARM64 | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

นี่คือวิธีที่เราแนะนำ

### ผ่าน Microsoft Store

ติดตั้งจาก [หน้า PowerToys ของ Microsoft Store][microsoft-store-link] คุณต้องใช้ [Microsoft Store โฉมใหม่](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/) ซึ่งมีให้สำหรับทั้ง Windows 11 และ Windows 10

### ผ่าน WinGet
ดาวน์โหลด PowerToys จาก [WinGet][winget-link] การอัปเดต PowerToys ผ่าน winget จะเคารพขอบเขตการติดตั้ง PowerToys ปัจจุบัน ในการติดตั้ง PowerToys ให้รันคำสั่งต่อไปนี้ใน command line / PowerShell:

#### ตัวติดตั้งแบบต่อผู้ใช้ [ค่าเริ่มต้น]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### ตัวติดตั้งแบบทั้งเครื่อง

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### วิธีติดตั้งอื่น ๆ

มี [วิธีติดตั้งที่ชุมชนพัฒนาขึ้นเอง](./doc/unofficialInstallMethods.md) เช่น Chocolatey และ Scoop หากคุณต้องการใช้วิธีเหล่านี้ สามารถดูคำแนะนำได้ที่ลิงก์นั้น

## ปลั๊กอิน Run ของบุคคลที่สาม

มีชุดของ [ปลั๊กอินบุคคลที่สาม](./doc/thirdPartyRunPlugins.md) ที่สร้างโดยชุมชน ซึ่งไม่ได้รวมมากับ PowerToys

## การมีส่วนร่วม

โครงการนี้ยินดีรับการมีส่วนร่วมทุกรูปแบบ นอกเหนือจากการเขียนโค้ดฟีเจอร์หรือแก้ไขบั๊กแล้ว คุณสามารถช่วยเหลือได้ด้วยการเขียนสเปค ออกแบบ เขียนเอกสาร หรือหาบั๊ก เราตื่นเต้นที่จะได้ร่วมงานกับชุมชนผู้ใช้ระดับสูงเพื่อสร้างชุดเครื่องมือที่จะช่วยให้คุณใช้งาน Windows ได้อย่างเต็มประสิทธิภาพ

**ก่อนที่คุณจะเริ่มทำฟีเจอร์ที่ต้องการมีส่วนร่วม** กรุณาอ่าน [คู่มือผู้มีส่วนร่วม](CONTRIBUTING.md) ของเรา เรายินดีที่จะร่วมมือกับคุณเพื่อหาแนวทางที่ดีที่สุด ให้คำแนะนำและการโค้ชตลอดกระบวนการพัฒนา และช่วยหลีกเลี่ยงงานซ้ำซ้อน

การมีส่วนร่วมส่วนใหญ่ต้องยอมรับ [Contributor License Agreement (CLA)][oss-CLA] ระบุว่าคุณให้สิทธิ์เราในการใช้งานสิ่งที่คุณมีส่วนร่วมและคุณมีสิทธิ์ทำเช่นนั้น

สำหรับแนวทางการพัฒนา PowerToys กรุณาอ่าน [เอกสารสำหรับนักพัฒนา](/doc/devdocs) เพื่อดูรายละเอียด รวมถึงการตั้งค่าเครื่องของคุณสำหรับคอมไพล์

## มีอะไรเกิดขึ้น

### แผนงาน PowerToys

[แผนงานที่มีลำดับความสำคัญ][roadmap] ของฟีเจอร์และยูทิลิตี้ต่าง ๆ ที่ทีมงานหลักกำลังโฟกัส

### 0.91 - อัปเดตเดือนพฤษภาคม 2025

ในการอัปเดตนี้ เราเน้นที่ฟีเจอร์ใหม่ เสถียรภาพ และระบบอัตโนมัติ

**✨ ไฮไลท์**

 - เราเน้นปรับปรุงประสิทธิภาพของ Command Palette อย่างมากและแก้ไขบั๊กจำนวนมาก ฟีเจอร์ใหม่ที่เพิ่มเข้ามาได้แก่:
 - เพิ่มความสามารถให้ Command Palette ค้นหาไฟล์ใด ๆ โดยใช้ fallback command
 - เพิ่มความสามารถให้ปุ่มลัด Command Palette แบบ global เป็น low-level keyboard hook
 - เพิ่ม fallback command สำหรับเปิด URL ในส่วนขยาย WebSearch ให้ผู้ใช้เปิด URL ในเบราว์เซอร์ได้โดยตรงจาก Command Palette
 - ขณะนี้สามารถกำหนดรูปแบบเองในปลั๊กอินวันที่และเวลา (Date and Time) ของ PT Run และ Command Palette ได้ ขอบคุณ [@htcfreek](https://github.com/htcfreek)!

### Advanced Paste

 - แก้ไขปัญหาที่ Advanced Paste ไม่สามารถสร้าง OCR engine สำหรับบางภาษาอังกฤษ (เช่น en-CA) โดยกำหนดให้ใช้ภาษาโปรไฟล์ของผู้ใช้ ขอบคุณ [@cryolithic](https://github.com/cryolithic)!

### Color Picker

 - แก้ไขปัญหาทรัพยากรค้างทำให้แอปค้างหรือแครช โดยกำจัด Graphics object อย่างถูกต้อง ขอบคุณ [@dcog989](https://github.com/dcog989)!
 - แก้ไขปัญหา Color Picker ปิดตัวเมื่อกดปุ่ม Backspace โดยให้ปิดเฉพาะเมื่อโฟกัสและปรับพฤติกรรม Escape/Backspace ให้เหมือนกัน ขอบคุณ [@PesBandi](https://github.com/PesBandi)!
 - เพิ่มรองรับรูปแบบสี Oklab และ Oklch ใน Color Picker ขอบคุณ [@lemonyte](https://github.com/lemonyte)!

### Command Not Found

 - อัปเดตสคริปต์ WinGet Command Not Found ให้เปิดใช้งานฟีเจอร์ทดลองเฉพาะเมื่อมีอยู่จริงเท่านั้น

### Command Palette

 - อัปเดตเทมเพลตบั๊กให้รวมโมดูล Command Palette ด้วย
 - แก้ไขปัญหา toast window ไม่ปรับตาม DPI ทำให้เค้าโครงเพี้ยนเมื่อใช้การปรับขนาดหน้าจอ
 - แก้ไขปัญหานำทางด้วยคีย์ Up/Down ไม่ขยับ selection เมื่อ caret อยู่ที่ตำแหน่ง 0 และเพิ่มการนำทางต่อเนื่องแบบ PT Run v1 ขอบคุณ [@davidegiacometti](https://github.com/davidegiacometti)!
 - ปรับปรุงโค้ดส่วนขยาย Time and Date ให้เรียบง่ายและชัดเจนขึ้น
 - แก้ไขปัญหาตัวพิมพ์ใหญ่ในคำสั่งทำให้การนำไปยังตัวชี้เมาส์ล้มเหลว โดยเปลี่ยนคำสั่งเป็นตัวพิมพ์เล็ก
 - เพิ่ม fallback command สำหรับเปิด URL ใน WebSearch extension ให้ผู้ใช้เปิด URL ในเบราว์เซอร์ได้โดยตรงจาก Command Palette ขอบคุณ [@htcfreek](https://github.com/htcfreek)!
 - เพิ่มการตั้งค่าเปิด/ปิดไอคอน system tray ใน CmdPal และปรับศัพท์ให้สอดคล้องกับ Windows 11 ขอบคุณ [@davidegiacometti](https://github.com/davidegiacometti)!
 - แก้ไขปัญหา alias โดยลบ alias เก่าเมื่อมีการตั้งค่าใหม่
 - แก้ไขความขัดแย้งชื่อโฟลเดอร์ GitHub casing โดยย้าย Exts และ exts ไปยังโฟลเดอร์ ext ใหม่ เพื่อโครงสร้างที่สอดคล้องกันและป้องกันปัญหา path
 - แก้ไขปัญหาคำสั่ง 'Create New Extension' สร้างชื่อไฟล์ว่างเปล่า
 - เพิ่มความสามารถให้ปุ่มลัด global เป็น low-level keyboard hook
 - เพิ่มรองรับ JUMBO thumbnails เพื่อเข้าถึงไอคอนความละเอียดสูง
 - แก้ไขแครชเมื่อ CmdPal auto-hide ตัวเองขณะเปิด MSAL dialog โดยป้องกันการซ่อนหากถูกปิดการใช้งาน
 - เพิ่มรองรับการเลือกข้อความค้นหาทันทีเมื่อโหลดหน้า
 - แก้ไขบั๊กที่หน้าตั้งค่าส่วนขยายไม่โหลดใหม่เมื่อเปิดซ้ำ โดยอัปเดตฟอร์มตั้งค่าหลังบันทึกการตั้งค่า
 - แก้ไขปัญหา Command Palette ไม่สามารถเปิดจาก runner
 - ปรับปรุงและย้าย logic เครื่องคิดเลข PowerToys Run v1 ไปยัง Command Palette, เพิ่มรองรับ settings และ fallback
 - เพิ่มรองรับคีย์ลัดสำหรับรายการใน list item อีกครั้ง
 - ปรับปรุงการเข้าถึง Command Palette โดยเพิ่มป้ายกำกับที่เหมาะสม ปรับแต่งแอนิเมชัน ปรับปรุงการแปล และแก้ไขปัญหาด้าน a11y
 - นำรองรับ custom format ไปยังปลั๊กอิน Time and Date จัดเรียงและล้าง settings ปรับปรุง error messaging และแก้ไขแครชกรณี edge case เพื่อความเสถียรและใช้งานง่ายขึ้น ขอบคุณ [@htcfreek](https://github.com/htcfreek)!
 - เพิ่ม fallback item สำหรับ system command
 - แก้ไขบั๊ก Windows System Command ที่แสดง key prompt "Empty" สำหรับการเปิดถังรีไซเคิล ขอบคุณ [@jironemo](https://github.com/jironemo)!
 - แก้ไขปัญหา 'more commands' แสดงคำสั่งที่ไม่ควรเห็น ขอบคุณ [@davidegiacometti](https://github.com/davidegiacometti)!
 - แก้ไขปัญหา details view ใน Command Palette แสดงไอคอนใหญ่เกินและข้อความไม่ตรง ปรับให้เหมือนกับ Windows Search
 - แก้ไขบั๊กเนื้อหาหน้าจอว่างเปล่าและปุ่มใน command bar โดนตัดเมื่อใช้ label ยาว ให้แสดงผลถูกต้อง
 - ปรับปรุงการผสาน CmdPal กับ WinGet โดยแก้ไขการแสดงเวอร์ชันของ package ที่ติดตั้ง อัปเดตด้วยไอคอน และย้าย API winget preview ไปยังเวอร์ชันเสถียร
 - แก้ไขบั๊กคำสั่งสำหรับ ContentPage ไม่อัปเดตจนกว่าจะออก โดยทำให้เมนูบริบท (context menu) ถูกเตรียมพร้อมเมื่อมีการเปลี่ยนแปลง
 - เพิ่ม fallback ใน TimeDate extension ให้สามารถค้นหาวันที่/เวลาได้โดยตรงโดยไม่ต้องเลือกคำสั่ง
 - นำเข้า Common.Dotnet.AotCompatibility.props ไปยังไฟล์โครงการ CmdPal หลายไฟล์ เพื่อรองรับการคอมไพล์แบบ AoT
 - แก้ไขแครชใน CmdPal settings เมื่อ HotKey เป็น null เพราะไม่มีใน settings.json ขอบคุณ [@davidegiacometti](https://github.com/davidegiacometti)!
 - เพิ่มเมนูบริบทแบบกรองและซ้อนกันใน CmdPal พร้อมกล่องค้นหาเพื่อคงพฤติกรรมโฟกัส
 - ปรับปรุงคลาส CmdPal เพื่อเพิ่มประสิทธิภาพและความสามารถในการดูแลรักษา โดยการปรับปรุง JSON serialization และเพิ่ม context ใหม่
 - เพิ่มรองรับการคอมไพล์ล่วงหน้า (Ahead-of-Time, AoT)
 - เพิ่มกลไก retry สำหรับการเปิด CmdPal
 - ลบไฟล์ที่ไม่ใช้ใน CmdPal.Common เพื่อลดความซับซ้อนและเตรียมสำหรับการทำ AoT
 - แก้ไขบั๊ก race condition ในการอัปเดต SearchText ที่ทำให้เคอร์เซอร์ในกล่องป้อนข้อมูลกระโดดไปท้ายบรรทัด ให้ SearchText อัปเดตหลังจากมีการเปลี่ยนแปลงจริง
 - เพิ่มรองรับค้นหาไฟล์ใด ๆ ใน fallback command
 - ล้างโค้ดที่เกี่ยวข้องกับ AoT เพื่อลดการทำงานซ้ำซ้อนในการทดสอบ
 - ลดเวลาโหลด CmdPal โดยเรียกใช้ extension หลายตัวแบบขนานและเพิ่ม timeout เพื่อป้องกัน extension ที่มีปัญหากีดกันตัวอื่น
 - ปรับปรุงพฤติกรรม UI โดยปิดรายละเอียดเมื่อ list ว่าง ป้องกันสถานะภาพที่ไม่สอดคล้อง
 - เพิ่มรองรับการยกเลิก fallback command ใน CmdPal เมื่อไม่พบคำสั่งที่ตรงกัน เพื่อรีโหลดให้สะอาด
 - แก้ไขปัญหา leak ในเทมเพลต CmdPal extension โดยจัดการการใช้ ComServer อย่างถูกต้อง
 - ป้องกันไม่ให้หน้าต่าง CmdPal ขยายเต็มจอเมื่อดับเบิ้ลคลิกแถบไตเติล ขอบคุณ [@davidegiacometti](https://github.com/davidegiacometti)!
 - แก้ไขปัญหา Settings UI เปิดมามีขนาดเล็กเกินไป โดยทำให้ขนาดหน้าต่างรองรับ DPI และบังคับขนาดขั้นต่ำผ่าน WinUIEx
 - แก้ไขปัญหาหน้าจอขาววาบและแอนิเมชันครั้งเดียวใน CmdPal โดยใช้ cloaking แทนการซ่อน
 - แก้ไขบั๊กที่ตั้งค่าส่วนขยายทั้งหมดถูกโหลดตอนเริ่มต้น โดยเปลี่ยนไปโหลดตามความจำเป็น ลดภาระเริ่มต้น
 - เพิ่มรองรับป้องกัน CmdPal จากการแครชเมื่อ Adaptive Card parse ล้มเหลว
 - เปลี่ยนจาก shell:AppsFolder เป็น URI activation ใน CmdPal เพื่อความเสถียร
 - เพิ่มความสามารถเปิดตั้งค่า CmdPal จาก PowerToys Settings
 - เพิ่มความสามารถให้ CmdPal ติดตามและอัปเดตรายละเอียด extension แบบเรียลไทม์
 - อัปเดตเทมเพลต extension ของ CmdPal ให้ใช้ toolkit เวอร์ชัน 0.2.0

### Image Resizer

 - แก้ไขปัญหาลบ preset ของ Image Resizer แล้วลบผิดอัน

### Keyboard Manager

 - แก้ไขปัญหา modifier key ที่ไม่ได้ระบุซ้ายหรือขวาแล้วค้างจากการจัดการคีย์ไม่ถูกต้อง โดยติดตามคีย์ที่ถูกกดและส่งคีย์ที่ถูกต้อง ขอบคุณ [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - เพิ่มความสามารถจัดรูปแบบเวลาใน PowerRename ด้วยรูปแบบ 12 ชั่วโมงและรองรับ AM/PM ขอบคุณ [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - เพิ่มรองรับ custom format ในปลั๊กอิน "Time and Date" และปรับปรุงข้อความ error สำหรับ input ไม่ถูกต้อง ขอบคุณ [@htcfreek](https://github.com/htcfreek)!
 - แก้ไขแครช 2 กรณี คือ WFT ในวันที่เก่าเกินไปและการคำนวณสัปดาห์ของเดือนในวันที่ปลายปี (เช่น 31.12.9999) และจัดเรียงการตั้งค่า UI ใหม่ ขอบคุณ [@htcfreek](https://github.com/htcfreek)!
 - แก้ไขปัญหาตัวพิมพ์ใหญ่ในคำสั่งทำให้การนำไปยังตัวชี้เมาส์ล้มเหลว โดยเปลี่ยนคำสั่งเป็นตัวพิมพ์เล็ก
 - เพิ่มรายละเอียดเวอร์ชันในข้อความ error ของปลั๊กอินสำหรับ 'Loading error' และ 'Init error' ขอบคุณ [@htcfreek](https://github.com/htcfreek)!
 - ปรับปรุง result model โดยเพิ่มตัวเลือกสำหรับไม่เรียงลำดับตามการใช้งาน เพื่อให้ผู้พัฒนา plugin สามารถควบคุมลำดับการแสดงผลได้มากขึ้น ขอบคุณ [@CoreyHayward](https://github.com/CoreyHayward) และ [@htcfreek](https://github.com/htcfreek)!

### Quick Accent

 - อัปเดต mapping ตัวอักษรใน GetDefaultLetterKeyEPO โดยแทนที่ "ǔ" ด้วย "ŭ" สำหรับปุ่ม VK_U เพื่อให้ตรงกับเสียงในภาษาเอสเปรันโต ขอบคุณ [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - แก้ไขปัญหา Quick Accent ไม่ทำงานกับคีย์บอร์ดบนหน้าจอ ขอบคุณ [@davidegiacometti](https://github.com/davidegiacometti)!

### Registry Preview

 - ปรับปรุง Registry Preview ให้รองรับการวางคีย์และค่าของรีจิสทรีโดยไม่ต้องเขียนส่วนหัวไฟล์เอง และเพิ่มปุ่มใหม่สำหรับรีเซ็ตแอป ขอบคุณ [@htcfreek](https://github.com/htcfreek)!

### Settings

 - แก้ไขปัญหาแอป Settings แสดงไอคอนว่างเปล่าในแถบงานแบบสุ่ม โดยเลื่อนการกำหนดไอคอนจนกว่าจะเปิดหน้าต่าง
 - เพิ่มความสามารถขยายหน้าต่าง "What's New" เต็มจอเพื่ออ่านสะดวกขึ้น

### Workspaces

 - แก้ไขบั๊กที่เกม Steam ไม่ถูกจับหรือเปิดอย่างถูกต้อง ด้วยการปรับปรุงการกรองหน้าต่างและรวมการจัดการ Steam URL protocol

### เอกสาร

 - เพิ่ม QuickNotes ในเอกสารปลั๊กอินบุคคลที่สามสำหรับ PowerToys Run ขอบคุณ [@ruslanlap](https://github.com/ruslanlap)!
 - เพิ่มปลั๊กอิน Weather และ Pomodoro ในเอกสารปลั๊กอินบุคคลที่สามของ PowerToys Run ขอบคุณ [@ruslanlap](https://github.com/ruslanlap)!
 - เพิ่มปลั๊กอิน Linear ในเอกสารปลั๊กอินบุคคลที่สามของ PowerToys Run ขอบคุณ [@vednig](https://github.com/vednig)!
 - แก้ไขปัญหาการจัดรูปแบบเอกสารและอัปเดตรายชื่อผู้มีส่วนร่วมและสมาชิกทีม ขอบคุณ [@DanielEScherzer](https://github.com/DanielEScherzer) และ [@RokyZevon](https://github.com/RokyZevon)!

### การพัฒนา

 - อัปเดต GitHub Action ให้ติดตั้ง .NET 9 สำหรับการออกเวอร์ชัน MSStore
 - อัปเดตตัวแปรเวอร์ชันใน bug_report.yml เพื่อป้องกันการรายงานเวอร์ชัน v0.70.0 ผิดพลาด
 - อัปเดต GitHub Action ให้ใช้ actions/setup-dotnet จากเวอร์ชัน 3 เป็น 4 สำหรับ MSStore release
 - เพิ่ม securityContext ในไฟล์ config WinGet ให้รันจาก user context และขอ UAC ครั้งเดียวสำหรับ resource ที่ต้องการสิทธิ์สูงใน process แยก ขอบคุณ [@mdanish-kh](https://github.com/mdanish-kh)!
 - เปลี่ยนไฟล์ log จาก .txt เป็น .log เพื่อรองรับการเชื่อมโยงไฟล์และเครื่องมือที่เหมาะสม และเพิ่ม log สำหรับ Workspace ขอบคุณ [@benwa](https://github.com/benwa)!
 - อัปเกรด dependency ของ testing framework และจัดเวอร์ชัน package ให้ตรงกัน
 - อัปเกรด dependency เพื่อแก้ไขช่องโหว่ความปลอดภัย
 - เพิ่มความปลอดภัยให้ repository โดย pin GitHub Actions และ Docker tags ไปยัง commit แบบเต็มและเพิ่มระบบสแกนช่องโหว่อัตโนมัติด้วย Dependency Review Workflow ขอบคุณ [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - อัปเกรด Boost dependency เป็นเวอร์ชันใหม่กว่า
 - อัปเกรด toolkit เป็นเวอร์ชันล่าสุด และปิด warning ที่เกี่ยวกับ AoT
 - แก้ไขปัญหา build fail เมื่อลงนามไฟล์ใหม่ไม่สมบูรณ์
 - อัปเดต release pipeline เพื่อป้องกันการเผยแพร่สัญลักษณ์ส่วนตัว 100 ปี
 - เพิ่ม fuzzing สำหรับ PowerRename เพื่อเพิ่มความเสถียรและเพิ่มคำแนะนำการติดตั้งสำหรับ C++ module อื่น
 - เพิ่ม pre-create โฟลเดอร์ที่ gen ไว้ล่วงหน้าสำหรับทุก .csproj เพื่อป้องกัน build fail
 - อัปเดต WinAppSDK เป็นเวอร์ชัน 1.7 ล่าสุด
 - อัปเกรด Boost dependency สำหรับโครงการ PowerRename Fuzzing เป็นเวอร์ชันล่าสุด
 - อัปเดตเส้นทาง ADO area ใน tsa.json เพื่อแก้ไข TSA pipeline error ที่เกิดจาก path เดิมหมดอายุ
 - เริ่มต้นรองรับ AoT ใน CmdPal โดยมีการวางรากฐานไว้แล้ว
  
### เครื่องมือ/ทั่วไป

 - เพิ่มรองรับสร้างรายงานบั๊กอัตโนมัติโดยสร้าง GitHub issue URL พร้อมข้อมูลระบบและการวินิจฉัย ขอบคุณ [@donlaci](https://github.com/donlaci)!
 - เพิ่มสคริปต์สำหรับ build ตัวติดตั้งในเครื่องเอง เพื่อให้ CmdPal เปิดในสภาพแวดล้อมเครื่องได้
 - ลบ logic การ export PFX เพื่อกำจัดการใช้รหัสผ่าน hardcode และแก้ไขคำเตือนด้านความปลอดภัยของ PSScriptAnalyzer
 - เพิ่มสคริปต์ PowerShell และ CI เพื่อบังคับใช้ Common.Dotnet.CsWinRT.props กับทุกโปรเจกต์ C# ภายใต้โฟลเดอร์ src
   
### แผนสำหรับเวอร์ชัน 0.92

สำหรับ [v0.92][github-next-release-work] เราจะทำงานในหัวข้อต่อไปนี้:

 - ขัดเกลา Command Palette ต่อเนื่อง
 - ทดสอบ UI Automation ใหม่
 - ทำงานเกี่ยวกับการอัปเกรดตัวติดตั้ง
 - อัปเกรด UI ตัวแก้ไขของ Keyboard Manager
 - ความเสถียร/แก้ไขบั๊ก

## ชุมชน PowerToys

ทีม PowerToys รู้สึกขอบคุณอย่างยิ่งที่มี [การสนับสนุนจากชุมชนที่ยอดเยี่ยม][community-link] งานของคุณมีความสำคัญมาก PowerToys คงไม่ได้เป็นอย่างทุกวันนี้หากไม่มีความช่วยเหลือของคุณ ไม่ว่าจะเป็นการแจ้งบั๊ก อัปเดตเอกสาร ช่วยออกแบบ หรือเขียนฟีเจอร์ เราขอขอบคุณและขอใช้โอกาสนี้ยกย่องผลงานของคุณ เดือนต่อเดือน คุณได้ช่วยทำให้ PowerToys เป็นซอฟต์แวร์ที่ดียิ่งขึ้น

## จรรยาบรรณ

โครงการนี้ใช้ [จรรยาบรรณซอฟต์แวร์โอเพ่นซอร์สของ Microsoft][oss-conduct-code]

## นโยบายความเป็นส่วนตัว

แอปพลิเคชันนี้จะบันทึกข้อมูลวินิจฉัยพื้นฐาน (telemetry) สำหรับข้อมูลเพิ่มเติมเกี่ยวกับความเป็นส่วนตัวและข้อมูลที่เรารวบรวม โปรดดู [เอกสารข้อมูลและความเป็นส่วนตัวของ PowerToys](https://aka.ms/powertoys-data-and-privacy-documentation)

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---