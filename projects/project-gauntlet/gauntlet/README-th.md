# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

ตัวเรียกใช้งานแอปพลิเคชันข้ามแพลตฟอร์มแบบ Web-first พร้อมปลั๊กอินที่ใช้ React

> [!WARNING]
> Launcher กำลังพัฒนาโดยนักพัฒนาเพียงคนเดียวในเวลาว่างของเขา
> การเปลี่ยนแปลงอาจจะช้าแต่ต่อเนื่อง
>
> อาจมีการเปลี่ยนแปลงที่ทำให้ไม่สามารถใช้งานร่วมกันได้ ซึ่งจะมีการบันทึกไว้ใน [changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md)

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## เดโม

เดโมที่อาจจะล้าสมัยเล็กน้อย

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## ฟีเจอร์

- เน้นปลั๊กอินเป็นหลัก
  - ปลั๊กอินเขียนด้วย TypeScript
  - API สำหรับปลั๊กอินที่หลากหลาย
      - สร้าง UI views
      - คำสั่งแบบ one-shot
      - ให้รายการคำสั่งแบบ one-shot ได้แบบไดนามิก
      - แสดงผล "inline" อย่างรวดเร็วใต้แถบค้นหาหลักตามค่าที่กรอก
      - ดึงข้อมูลจากคลิปบอร์ดและเพิ่มข้อมูลลงคลิปบอร์ด
  - ปลั๊กอินถูกกระจายเป็น branch แยกใน Git repository ซึ่งหมายความว่าการแจกจ่ายปลั๊กอินไม่ต้องใช้เซิร์ฟเวอร์กลาง
  - Plugin ID คือ URL ของ Git Repository
  - UI สำหรับปลั๊กอินใช้ [React](https://github.com/facebook/react)
    - พัฒนาด้วย custom React Reconciler (ไม่ใช้ Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno ช่วย sandbox โค้ดปลั๊กอิน JavaScript เพื่อความปลอดภัยมากขึ้น
    - ปลั๊กอินต้องระบุ permission ที่ต้องการใช้งานอย่างชัดเจน
    - Node.js ใช้สำหรับ tooling ของปลั๊กอิน แต่ในฐานะนักพัฒนาปลั๊กอินคุณจะเขียนโค้ดสำหรับรันบน Deno เสมอ
- ออกแบบมาให้รองรับข้ามแพลตฟอร์มตั้งแต่แรก
- คำสั่งและ View สามารถเปิดใช้งานผ่าน global shortcuts แบบ custom ได้
- สามารถกำหนด search alias ให้กับ Commands หรือ Views ได้เอง
- รองรับธีมแบบ custom
- ฟังก์ชันการทำงานพื้นฐานถูกรวมมาให้ในรูปแบบปลั๊กอิน
  - Applications: แสดงแอปที่ติดตั้งในระบบในผลลัพธ์การค้นหา
    - ปลั๊กอินนี้ยังติดตามหน้าต่างและแอปที่เกี่ยวข้อง ดังนั้นการเปิดแอปที่เปิดค้างไว้จะนำหน้าต่างเดิมกลับมา (ดีฟอลต์)
      - ไม่รองรับทุกระบบในขณะนี้ ดู [feature support](https://gauntlet.sh/docs/feature-support)
  - Calculator: แสดงผลลัพธ์ของการคำนวณทางคณิตศาสตร์ใต้แถบค้นหาหลักโดยตรง
    - รวมถึงการแปลงสกุลเงินโดยใช้อัตราแลกเปลี่ยน
    - ขับเคลื่อนด้วย [Numbat](https://github.com/sharkdp/numbat)
- การจัดอันดับผลลัพธ์การค้นหาตาม Frecency
   - Frecency คือการรวมระหว่างความถี่ (frequency) และความใหม่ (recency)
   - รายการที่ถูกใช้บ่อยจะอยู่สูงกว่าในลิสต์ผลลัพธ์ แต่รายการที่เคยถูกใช้บ่อยในอดีตจะถูกจัดอันดับต่ำกว่ารายการที่เพิ่งถูกใช้บ่อยในระยะหลัง
   - ผลลัพธ์จะจับคู่โดยใช้ substring ต่อคำ

##### การรองรับระบบปฏิบัติการ

##### อย่างเป็นทางการ
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### พยายามรองรับ (Best-effort)
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland ยังไม่รองรับ ดู [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## เริ่มต้นใช้งาน

### ติดตั้ง Gauntlet

ดู [การติดตั้ง](https://gauntlet.sh/docs/installation)

### Global Shortcut

สามารถเปิดหน้าต่างหลักด้วย global shortcut หรือคำสั่ง CLI:
- Global Shortcut (สามารถเปลี่ยนได้ใน Settings)
  - Windows: <kbd>ALT</kbd> + <kbd>Space</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Space</kbd>
  - Linux Wayland
    - อาจไม่รองรับ global shortcut ดู [feature support](https://gauntlet.sh/docs/feature-support)
    - โปรดใช้คำสั่ง CLI แทน และเรียกใช้งานด้วยวิธีเฉพาะของ window manager
  - macOS: <kbd>CMD</kbd> + <kbd>Space</kbd>
- คำสั่ง CLI
  - `gauntlet open`

### ติดตั้งปลั๊กอิน

ติดตั้งปลั๊กอินในหน้าต่าง Settings ใช้ URL ของ Git repository ของปลั๊กอินเพื่อทำการติดตั้ง เช่น `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### สร้างปลั๊กอินของคุณเอง

ดู [เริ่มต้นพัฒนาปลั๊กอิน](https://gauntlet.sh/docs/plugin-development/getting-started)

## ธีม

ดู [การตั้งค่าธีม](https://gauntlet.sh/docs/theming)

## การสร้าง Gauntlet

คุณจะต้องมี:
- NodeJS
- Rust
- Protobuf Compiler
- CMake (ไม่ได้ใช้โดยโปรเจกต์โดยตรง แต่จำเป็นสำหรับ dependency บางตัว)
- บน Linux: `libxkbcommon-dev` (ชื่ออาจแตกต่างกันตาม distro ที่ใช้)

### โหมด Dev

เพื่อ build dev ให้รัน:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
ใน dev (โดยไม่มีฟีเจอร์ "release") แอปจะใช้ไดเรกทอรีภายในโปรเจกต์เท่านั้นในการเก็บสถานะหรือแคช เพื่อป้องกันการรบกวนการติดตั้งแบบ global

### Not-yet-packaged

เพื่อ build ไบนารี release แบบ not-yet-packaged ให้รัน:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Packaged
เพื่อ build แพ็คเกจตามระบบปฏิบัติการ ให้รันคำสั่งต่อไปนี้อย่างใดอย่างหนึ่ง:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

แต่การปล่อยเวอร์ชันใหม่จะต้องทำผ่าน GitHub Actions

## การมีส่วนร่วม

หากคุณต้องการช่วยพัฒนา Gauntlet คุณสามารถช่วยได้มากกว่าการเขียนโค้ด:
- รายงานบั๊กหรือปัญหา UI/UX
- สร้างปลั๊กอิน

สำหรับปัญหาง่าย ๆ สามารถเปิด issue หรือ PR และแก้ไขได้ด้วยตัวเอง
สำหรับการเปลี่ยนแปลงที่สำคัญกว่านี้ กรุณาติดต่อผู้สร้างใน Discord (ลิงก์เชิญอยู่บน README) และพูดคุยกันก่อน

ยินดีต้อนรับทุกการมีส่วนร่วมทุกรูปแบบ

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---