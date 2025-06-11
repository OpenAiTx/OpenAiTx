# Black-Hat-Zig

<p align="center">
  <img alt="GitHub License" src="https://img.shields.io/github/license/CX330Blake/black-hat-zig">
  <img alt="GitHub top language" src="https://img.shields.io/github/languages/top/cx330blake/black-hat-zig">
  <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/cx330blake/black-hat-zig">
  <img alt="X (formerly Twitter) Follow" src="https://img.shields.io/twitter/follow/CX330Blake">
</p>

<p height="350px" align="center">
  <img src="https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Black-Hat-Zig.png">
  <br/>
  <b>สวัสดีแฮกเกอร์ สวัสดีนักพัฒนามัลแวร์ สวัสดีนักรีเวิร์ส ยินดีที่ได้พบคุณที่นี่เพื่อสำรวจพลังด้านมืดของ Zig!</b><br/><br/>
  <b>ดูแลและบริหารโดย <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## สารบัญ

- [แนะนำ](#intro)
- [ทำไมต้อง Zig?](#why-zig)
- [การคอมไพล์โค้ด](#compiling-the-codes)
- [การวาง Payload](#payload-placement)
- [การทำให้ Payload ยากต่อการตรวจจับ](#payload-obfuscation)
- [การเข้ารหัส Payload](#payload-encryption)
- [การรัน Payload](#payload-execution)
- [Reverse Shell](#reverse-shell)
- [เทคนิคมัลแวร์](#malware-techniques)
- [เครื่องมือ Maldev](#maldev-tools)
- [ผู้ร่วมพัฒนา](#contributors)
- [เครดิต & แหล่งอ้างอิง](#credits--references)
- [ประวัติการกด Star](#star-history)
- [ข้อจำกัดความรับผิดชอบ](#disclaimer)

## แนะนำ

> [!IMPORTANT]
> โปรเจกต์นี้มีการอัปเดตอย่างต่อเนื่อง!

โปรเจกต์นี้นำเสนอวิธีการสร้างมัลแวร์หลากหลายแบบด้วยภาษา Zig เนื่องจากผู้เขียนเป็นแฟนตัวยงของภาษา Zig คุณสามารถใช้ repo นี้เพื่อเปลี่ยน Zig ให้เป็นอาวุธ Black-Hat-Zig จะอัปเดตอย่างต่อเนื่องเพื่อให้มีเนื้อหามากที่สุดเท่าที่จะเป็นไปได้ หากคุณต้องการสร้าง PR ให้กับโปรเจกต์นี้ก็จะยอดเยี่ยมมาก

เอาล่ะ มาแฮกโลกกันเถอะ!

## ทำไมต้อง Zig?

- 🤝 ง่ายต่อการทำงานร่วมกับซอร์สโค้ด C/C++
- 🔎 เป็นภาษาใหม่ ทำให้ตรวจจับได้ยากขึ้น
- 💪 ควบคุมระดับต่ำได้อย่างแข็งแกร่ง ต่ำกว่า C เสียอีก
- 😱 ยากต่อการรีเวิร์สเอนจิเนียร์เนื่องจากคอมไพเลอร์ยุคใหม่
- 🛡️ ขึ้นกับ runtime น้อย ไม่มีภาระจากไลบรารีมาตรฐานขนาดใหญ่
- 🎯 ไม่มี undefined behavior - การจัดการ edge case อย่างชัดเจน ช่วยป้องกันแครช

## การคอมไพล์โค้ด

คุณสามารถตรวจสอบโค้ดได้ภายในแต่ละไดเรกทอรี หากโค้ดนั้นใช้ Windows API คุณจะเห็นคำแนะนำในไฟล์ `README.md` ของโปรเจกต์นั้น ๆ เช่น [ตัวอย่างนี้](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

ผมได้ตั้งค่า target เริ่มต้นเป็น `windows-x86_64` สำหรับโค้ดที่ต้องใช้ Windows API ไว้แล้ว คุณสามารถ copy & paste คำสั่งด้านล่างเพื่อคอมไพล์โค้ดได้เลย ไม่ว่าคุณจะอยู่บน Linux, Windows หรือแม้แต่ MacOS! (แต่คุณยังคงต้องใช้ Windows ในการรันไฟล์ที่คอมไพล์ออกมา)

```bash
zig build
```

## การวาง Payload

เทคนิคในการวาง payload อันตรายไว้ใน section ต่าง ๆ ของไฟล์ executable

- [.data Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## การทำให้ Payload ยากต่อการตรวจจับ

เทคนิคการทำให้ payload ถูกปกปิดและหลีกเลี่ยงการตรวจจับด้วย static analysis หรือ pattern matching

- [การปกปิด IP Address](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [การปกปิด IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [การแปลง IPv4 กลับ](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [การปกปิด IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [การแปลง IPv6 กลับ](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [การปกปิด MAC Address](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [การปกปิด MAC Address](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [การแปลง MAC Address กลับ](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [การปกปิด UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [การปกปิด UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [การแปลง UUID กลับ](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## การเข้ารหัส Payload

รูปแบบการเข้ารหัสต่าง ๆ เพื่อซ่อนเจตนาที่แท้จริงของ payload ในขณะจัดเก็บหรือส่งข้อมูล

- [XOR Encryption](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR ด้วย Standard Library](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [RC4 Encryption](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 กับ SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [AES Encryption](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES ด้วย Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES ด้วย Standard Library](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES ด้วย TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## การรัน Payload

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

โค้ดพื้นฐานสำหรับสร้าง reverse shell เพื่อเข้าถึงหรือควบคุมหลังจากเจาะระบบ

- [Reverse Shell ด้วย Standard Library](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## เทคนิคมัลแวร์

รวมเทคนิค offensive tradecraft ที่ถูกปรับมาใช้กับ Zig

- [Process Injection](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [DLL Injection](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Shellcode Injection](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Payload Staging](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [จาก Web Server](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [จาก Windows Registry](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Process Enumeration](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [โดยใช้ CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [โดยใช้ EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [โดยใช้ NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## เครื่องมือ Maldev

- [ZYRA: Your Runtime Armor](https://github.com/cx330blake/zyra)
  - โปรแกรม packer สำหรับ executable เขียนด้วย Zig
- [ZYPE: Your Payload Encryptor](https://github.com/cx330blake/zype)
  - สร้าง code template ใน Zig ที่มี payload ที่เข้ารหัส/ปกปิดไว้พร้อมฟังก์ชันถอดรหัส/ถอดปกปิด

## ผู้ร่วมพัฒนา

โปรเจกต์นี้ดูแลและบริหารโดยหลักโดย [@CX330Blake](https://github.com/CX330Blake) ยินดีต้อนรับ PR ทุกท่าน หวังว่าจะมีคนมาใช้ Zig สำหรับพัฒนา malware มากขึ้น เพื่อให้อีโคซิสเต็มแข็งแกร่งขึ้น

ขอขอบคุณเหล่าผู้ร่วมพัฒนาเหล่านี้ด้วย!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## เครดิต & แหล่งอ้างอิง

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## ประวัติการกด Star

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## ข้อจำกัดความรับผิดชอบ

โปรเจกต์นี้มีไว้เพื่อจุดประสงค์ด้านจริยธรรมและการศึกษาเท่านั้น ห้ามนำไปใช้ในทางอาชญากรรมไซเบอร์

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---