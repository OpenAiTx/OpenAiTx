# TypeScript 7

[ยังไม่แน่ใจว่านี่คืออะไร? อ่านโพสต์ประกาศ!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## พรีวิว

สามารถใช้งาน build พรีวิวได้บน npm ในชื่อ `@typescript/native-preview`

```sh
npm install @typescript/native-preview
npx tsgo # ใช้งานเหมือนกับ tsc
```

ส่วนขยายพรีวิวสำหรับ VS Code [มีให้ใช้งานบน VS Code marketplace](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview)

เพื่อใช้งานนี้ ให้ตั้งค่าดังนี้ใน VS Code settings:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## วิธี Build และ Run

Repo นี้ใช้ [Go 1.24 หรือสูงกว่า](https://go.dev/dl/), [Rust 1.85 หรือสูงกว่า](https://www.rust-lang.org/tools/install), [Node.js พร้อม npm](https://nodejs.org/), และ [`hereby`](https://www.npmjs.com/package/hereby)

สำหรับการทดสอบและการสร้างโค้ด Repo นี้มี git submodule ไปยัง TypeScript repo หลักที่ชี้ไปยัง commit ที่ถูกพอร์ต
เมื่อต้องการโคลน ควรโคลนพร้อม submodules:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

หากคุณได้โคลน repo แล้ว สามารถ initialize submodule ได้ด้วย:

```sh
git submodule update --init --recursive
```

เมื่อมี submodule และรัน `npm ci` แล้ว สามารถรันงานต่าง ๆ ผ่าน `hereby` เช่นเดียวกับ TypeScript repo:

```sh
hereby build          # ตรวจสอบว่าโปรเจกต์ build สำเร็จ
hereby test           # รันการทดสอบทั้งหมด
hereby install-tools  # ติดตั้งเครื่องมือเพิ่มเติม เช่น linter
hereby lint           # รัน linter ทั้งหมด
hereby format         # จัดรูปแบบโค้ดทั้งหมด
hereby generate       # สร้าง Go code ทั้งหมด (เช่น diagnostics, committed to repo)
```

งานเพิ่มเติมกำลังอยู่ในระหว่างดำเนินการ

`hereby` ไม่จำเป็นสำหรับการทำงานกับ repo นี้; สามารถใช้ `go` tooling ปกติ (เช่น `go build`, `go test ./...`) ได้ตามปกติ
งานของ `hereby` มีไว้เพื่อความสะดวกสำหรับผู้ที่คุ้นเคยกับ TypeScript repo

### การรัน `tsgo`

หลังจากรัน `hereby build` แล้ว คุณสามารถรัน `built/local/tsgo` ซึ่งจะทำงานเหมือนกับ `tsc` เป็นส่วนใหญ่

### การรัน LSP Prototype

เพื่อดีบั๊กและรันส่วนขยาย VS Code โดยไม่ต้องติดตั้งแบบ global:

* เปิด VS Code ใน workspace ของ repo (`code .`)
* คัดลอก `.vscode/launch.template.json` ไปเป็น `.vscode/launch.json`
* <kbd>F5</kbd> (หรือ `Debug: Start Debugging` จาก command palette)

สิ่งนี้จะเปิดอินสแตนซ์ใหม่ของ VS Code ที่ใช้ Corsa LS เป็น backend หากตั้งค่าถูกต้อง จะเห็น "tsgo" ที่ status bar เมื่อเปิดไฟล์ TypeScript หรือ JavaScript:

![LSP Prototype Screenshot](https://raw.githubusercontent.com/microsoft/typescript-go/main/.github/ls-screenshot.png)

## มีอะไรที่ใช้งานได้แล้วบ้าง?

ยังอยู่ในระหว่างพัฒนาและยังไม่ครบฟีเจอร์เท่ากับ TypeScript อาจมีบั๊ก กรุณาตรวจสอบรายการนี้อย่างละเอียดก่อนแจ้ง issue ใหม่หรือคิดว่าเป็นการเปลี่ยนแปลงโดยตั้งใจ

| ฟีเจอร์ | สถานะ | หมายเหตุ |
|---------|--------|-------|
| การสร้างโปรแกรม | เสร็จแล้ว | ไฟล์และการ resolve module เหมือน TS5.8 ยังไม่รองรับโหมด resolve ทั้งหมด |
| การ parsing/scanning | เสร็จแล้ว | ข้อผิดพลาด syntax เหมือนกับ TS5.8 ทุกประการ |
| การพาร์ส Commandline และ `tsconfig.json` | เกือบเสร็จ | จุด entry point อาจต่างกันเล็กน้อยในตอนนี้ |
| การ resolve type | เสร็จแล้ว | เหมือนกับ TS5.8 |
| การตรวจสอบ type | เสร็จแล้ว | ข้อผิดพลาด, ตำแหน่ง, ข้อความ เหมือน TS5.8 การแสดงผล types ใน error อาจต่างกัน (กำลังดำเนินการ) |
| JavaScript inference เฉพาะและ JS Doc | ยังไม่พร้อม | - |
| JSX | เสร็จแล้ว | - |
| Declaration emit | กำลังดำเนินการ | ฟีเจอร์ที่ใช้บ่อยพร้อมแล้ว แต่ edge case กับ feature flag บางอย่างยังไม่รองรับ |
| Emit (JS output) | กำลังดำเนินการ | `target: esnext` รองรับดี เป้าหมายอื่นอาจยังไม่ครบ |
| Watch mode | prototype | ดูไฟล์และ rebuild แต่ไม่มี incremental rechecking |
| Build mode / project references | ยังไม่พร้อม | - |
| Incremental build | ยังไม่พร้อม | - |
| Language service (LSP) | prototype | ฟีเจอร์พื้นฐาน (error, hover, go to def) ฟีเจอร์อื่นกำลังมาเร็ว ๆ นี้ |
| API | ยังไม่พร้อม | - |

คำนิยาม:

 * **เสร็จแล้ว** หรือ "believed done": ขณะนี้ไม่พบปัญหาหรือสิ่งที่ต้องทำเพิ่มแล้ว สามารถแจ้งบั๊กได้
 * **กำลังดำเนินการ**: กำลังพัฒนาอยู่ อาจใช้ได้บางฟีเจอร์ ยังไม่ครบ สามารถแจ้ง panic ได้แต่ยังไม่ต้องแจ้งอย่างอื่น
 * **prototype**: เป็น proof-of-concept เท่านั้น ไม่ต้องแจ้งบั๊ก
 * **ยังไม่พร้อม**: ยังไม่เริ่ม หรือยังห่างไกลจากความพร้อม ไม่ควรยุ่งกับฟีเจอร์นี้ตอนนี้

## หมายเหตุอื่น ๆ

ระยะยาวคาดว่า repo นี้และเนื้อหาจะถูกรวมเข้า `microsoft/TypeScript`
ดังนั้น repo และ issue tracker ของ typescript-go จะถูกปิดในอนาคต กรุณาพิจารณาเรื่องนี้ในการพูดคุย/แจ้งปัญหา

สำหรับรายการการเปลี่ยนแปลงโดยตั้งใจเทียบกับ TypeScript 5.7 ดูที่ CHANGES.md

## การร่วมพัฒนา

โปรเจกต์นี้ยินดีต้อนรับการร่วมพัฒนาและข้อเสนอแนะ การร่วมพัฒนาส่วนใหญ่จะต้องตกลง
Contributor License Agreement (CLA) เพื่อยืนยันว่าคุณมีสิทธิ์และอนุญาตให้เราใช้ผลงานของคุณ รายละเอียดดูที่ [Contributor License Agreements](https://cla.opensource.microsoft.com)

เมื่อคุณส่ง pull request จะมี CLA bot ตรวจสอบอัตโนมัติว่าคุณต้องให้ CLA หรือไม่ และจะแจ้งสถานะที่ PR (เช่น status check, comment) ให้ทำตามคำแนะนำของ bot ซึ่งต้องทำเพียงครั้งเดียวสำหรับ repo ที่ใช้ CLA ของเรา

โปรเจกต์นี้ใช้ [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/)
ดูข้อมูลเพิ่มเติมที่ [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) หรือ
ติดต่อ [opencode@microsoft.com](mailto:opencode@microsoft.com) หากมีคำถามหรือข้อคิดเห็นเพิ่มเติม

## เครื่องหมายการค้า

โปรเจกต์นี้อาจมีเครื่องหมายการค้าหรือโลโก้สำหรับโปรเจกต์ ผลิตภัณฑ์ หรือบริการ การใช้เครื่องหมายการค้าหรือโลโก้ของ Microsoft ต้องเป็นไปตาม
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general)
การใช้เครื่องหมายการค้าหรือโลโก้ของ Microsoft ในเวอร์ชันดัดแปลงของโปรเจกต์นี้ต้องไม่ก่อให้เกิดความสับสนหรือแสดงถึงการสนับสนุนจาก Microsoft
การใช้เครื่องหมายการค้าหรือโลโก้ของบุคคลที่สามเป็นไปตามนโยบายของเจ้าของเครื่องหมายนั้น ๆ

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---