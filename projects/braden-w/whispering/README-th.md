<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">การถอดเสียงอย่างไร้รอยต่อ ขับเคลื่อนโดย Whisper Model ของ OpenAI</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## เกี่ยวกับ

Whispering เป็นแอปพลิเคชันถอดเสียงแบบโอเพ่นซอร์สที่ให้ฟังก์ชันแปลงเสียงเป็นข้อความได้ทั่วโลก พร้อมตัวเลือก เช่น คีย์ลัดและการคัดลอก-วางอัตโนมัติ เพื่อให้การถอดเสียงเป็นไปอย่างไร้รอยต่อที่สุด

เบื้องหลังขับเคลื่อนด้วยโมเดล Whisper ของ OpenAI ซึ่งมีความแม่นยำมากกว่าฟีเจอร์ถอดเสียงที่ติดมากับระบบปฏิบัติการอย่างมีนัยสำคัญ

> **หมายเหตุสำคัญ**: Whispering ถูกออกแบบมาเพื่อเป็นเครื่องมือถอดเสียง ไม่ใช่เครื่องมือบันทึกเสียง สำหรับการบันทึกเสียงที่ยาวและต้องการความน่าเชื่อถือสูง แนะนำให้ใช้แอปบันทึกเสียงเฉพาะทางในโทรศัพท์หรืออุปกรณ์ที่ใช้ API บันทึกเสียงของระบบ เพื่อให้ได้คุณภาพเสียงและความเสถียรสูงสุด

## ตัวอย่างสาธิต

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## คุณสมบัติเด่น

1. **ถอดเสียงได้ทั่วโลก**: ใช้งานฟังก์ชันแปลงเสียงเป็นข้อความของ Whisper ได้ทุกที่ ด้วยคีย์ลัดหรือคลิกเพียงสองครั้ง
2. **รองรับหลายแพลตฟอร์ม**:
   - แอปเดสก์ท็อป: ให้ฟีเจอร์ถอดเสียงทั่วทั้งแอปพลิเคชัน
   - ส่วนขยายเบราว์เซอร์: ถอดเสียงได้จากเบราว์เซอร์โดยสื่อสารกับเว็บแอป
3. **ผสานเข้ากับแชท**: ส่วนขยายเบราว์เซอร์เพิ่มปุ่มบันทึกเสียงใน ChatGPT และ Claude บนเว็บไซต์ เพื่อให้สามารถป้อนเสียงและถอดเสียงได้โดยตรงในอินเทอร์เฟซแชท
4. **จัดการถอดเสียง**: ตรวจสอบและแก้ไขข้อความถอดเสียงในแอป Whispering เพื่อความถูกต้องและชัดเจน
5. **คัดลอกคลิปบอร์ดอัตโนมัติ**: เมื่อถอดเสียงเสร็จ ข้อความจะถูกคัดลอกไปยังคลิปบอร์ดโดยอัตโนมัติ พร้อมตัวเลือกวางอัตโนมัติ

## ข้อมูลของฉันถูกจัดเก็บอย่างไร?

Whispering จะจัดเก็บข้อมูลให้มากที่สุดไว้ในเครื่องของคุณ ทั้งไฟล์เสียงและข้อความถอดเสียง วิธีนี้เพื่อความเป็นส่วนตัวและความปลอดภัยสูงสุดในการจัดเก็บข้อมูล สรุปการจัดการข้อมูลดังนี้:

1. **จัดเก็บในเครื่อง**: ไฟล์เสียงและข้อความถอดเสียงจะถูกเก็บใน IndexedDB ซึ่งใช้เก็บข้อมูลแบบ blob และข้อมูลทั้งหมด เช่น ข้อความและถอดเสียง

2. **บริการถอดเสียง**: ข้อมูลเดียวที่ถูกส่งออกนอกเครื่อง คือเสียงที่คุณเลือกใช้บริการถอดเสียงภายนอก โดยคุณมีตัวเลือกดังนี้:
   - บริการภายนอก เช่น OpenAI หรือ Groq
   - บริการถอดเสียงในเครื่อง เช่น `faster-whisper-server` ที่ทุกอย่างอยู่ในอุปกรณ์ของคุณ

3. **ตั้งค่ากำหนดเองได้**: คุณสามารถเลือกบริการถอดเสียงในเมนูตั้งค่าเพื่อความเป็นส่วนตัวสูงสุด


## การติดตั้ง

### เว็บแอป

เข้าใช้งาน [whispering.bradenwong.com](https://whispering.bradenwong.com/) ซึ่งเป็นโฮสต์ของโฟลเดอร์ `apps/app` เวอร์ชันล่าสุดบน Vercel

### ส่วนขยาย Chrome

ติดตั้งส่วนขยาย Chrome ได้จาก Chrome Web Store [ที่นี่](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo)

### แอปเดสก์ท็อป

ดาวน์โหลดและติดตั้งแอป Whispering สำหรับเดสก์ท็อป ตามขั้นตอนของระบบปฏิบัติการที่คุณใช้:

#### Windows

1. ดาวน์โหลดไฟล์ติดตั้งที่ลงท้ายด้วย `.msi` จาก [หน้า releases ล่าสุด](https://github.com/braden-w/whispering/releases)
2. เปิดไฟล์ `.msi` ที่ดาวน์โหลดมาเพื่อเริ่มติดตั้ง
3. หากมีคำเตือนว่าไฟล์ไม่ปลอดภัย ให้คลิก `More Info` -> `Run Anyway` เพื่อดำเนินการต่อ
4. ทำตามคำแนะนำบนหน้าจอจนติดตั้งเสร็จสิ้น

#### macOS

สำหรับ macOS ให้ทำตามขั้นตอนดังนี้:

1. **ดาวน์โหลดไฟล์ติดตั้ง**:
   - ไปที่ [หน้า releases ล่าสุด](https://github.com/braden-w/whispering/releases)
   - เลือกไฟล์ที่เหมาะสม:
     - สำหรับ Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - สำหรับ Intel: `Whispering_x.x.x_x64.dmg`

2. **ติดตั้งแอปพลิเคชัน**:
   - เปิดไฟล์ `.dmg` ที่ดาวน์โหลดมา
   - ลากแอป Whispering ไปยังโฟลเดอร์ Applications

3. **เปิดใช้งาน Whispering**:
   - เปิดแอป Whispering จากโฟลเดอร์ Applications
   - หากพบคำเตือนเกี่ยวกับนักพัฒนาไม่ได้รับการยืนยัน:
     - คลิก `Cancel`
     - คลิกขวาที่แอปใน Finder แล้วเลือก `Open`

4. **แก้ไขปัญหา** (สำหรับ Apple Silicon เท่านั้น):
   หากพบข้อผิดพลาด `"Whispering" is damaged and can't be opened`:
   - เปิด Terminal
   - รันคำสั่งนี้:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - ลองเปิดแอปอีกครั้ง

หลังจากทำตามขั้นตอนข้างต้น Whispering จะพร้อมใช้งานบน macOS ของคุณ

#### Linux

สำหรับ Linux มีหลายทางเลือกในการติดตั้ง เลือกวิธีที่เหมาะกับสภาพแวดล้อมของคุณ:

1. **AppImage**:

   - ดาวน์โหลดไฟล์ `.AppImage` จาก [หน้า releases ล่าสุด](https://github.com/braden-w/whispering/releases)
   - ทำให้ไฟล์สามารถรันได้:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - รัน AppImage:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **แพ็กเกจ DEB (Debian/Ubuntu)**:
   - ดาวน์โหลดไฟล์ `.deb` จาก [หน้า releases ล่าสุด](https://github.com/braden-w/whispering/releases)
   - ติดตั้งแพ็กเกจด้วย `dpkg`:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - แก้ไขปัญหา dependency:
     ```bash
     sudo apt-get install -f
     ```

หลังจากติดตั้งแล้ว แอปจะพร้อมใช้งาน

## การใช้งาน

### ส่วนขยาย Chrome

หลังติดตั้งส่วนขยาย Chrome คุณจะพบไอคอน Whispering ในแถบส่วนขยายของ Chrome คลิกไอคอนนี้เพื่อเปิดส่วนขยาย จากนั้นคลิกปุ่มไมโครโฟนเพื่อบันทึกเสียงของคุณ และคลิกปุ่มสี่เหลี่ยมเมื่อเสร็จ ข้อความถอดเสียงจะแสดงในช่องข้อความด้านล่าง

หากต้องการใช้ฟีเจอร์ ChatGPT หรือ Claude ให้เข้าไปที่หน้าเว็บ ChatGPT หรือ Claude จะเห็นปุ่มบันทึกเสียงใหม่ในอินเทอร์เฟซแชท คลิกเพื่อเริ่มและหยุดบันทึก ข้อความถอดเสียงจะถูกแทรกอัตโนมัติในช่องป้อนข้อความของแชท

หากต้องการใช้คีย์ลัด กด <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> หรือ <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (สามารถปรับเปลี่ยนได้ในหน้าตั้งค่าคีย์ลัดของ Chrome) เพื่อเริ่มบันทึกเสียงจากเว็บไซต์ใดก็ได้ ข้อความถอดเสียงจะถูกคัดลอกไปยังคลิปบอร์ดและวางในช่องป้อนข้อความปัจจุบันโดยอัตโนมัติ

ส่วนขยาย Chrome จะสื่อสารกับ [whispering.bradenwong.com](https://whispering.bradenwong.com) และจะพยายามเปิดแท็บเบื้องหลังโดยอัตโนมัติหากไม่พบแท็บอยู่แล้ว ข้อผิดพลาดส่วนใหญ่เกิดจากการสื่อสารนี้ล้มเหลว เช่น ในกรณีที่แท็บเข้าสู่โหมดพัก

### เว็บแอป

เข้าใช้งานเว็บแอปได้ที่ [whispering.bradenwong.com](https://whispering.bradenwong.com) คลิกปุ่มไมโครโฟนเพื่อเริ่มบันทึกเสียง และคลิกปุ่มสี่เหลี่ยมเมื่อเสร็จ ข้อความถอดเสียงจะแสดงในกล่องข้อความ

### แอปเดสก์ท็อป

หลังจากติดตั้งแอปเดสก์ท็อป Whispering ให้กด <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (สามารถปรับได้ในเมนูตั้งค่า) เพื่อเริ่มบันทึกเสียงจากที่ใดก็ได้บนเดสก์ท็อป ข้อความถอดเสียงจะถูกคัดลอกไปยังคลิปบอร์ดและวางโดยอัตโนมัติ ทั้งสองฟีเจอร์นี้สามารถเปิดหรือปิดได้ในเมนูตั้งค่า

## เทคโนโลยีที่ใช้สร้าง

#### เว็บและเดสก์ท็อป

แอป Whispering ถูกสร้างขึ้นด้วยเทคโนโลยีและไลบรารีต่อไปนี้:

- [Svelte 5](https://svelte.dev): ไลบรารี UI ที่เน้นความตอบสนอง
- [SvelteKit](https://kit.svelte.dev/docs): สำหรับการกำหนดเส้นทางและสร้างเว็บไซต์แบบ static ใช้กับทั้งเว็บไซต์และ frontend ของแอป Tauri
- [Tauri](https://tauri.studio/en/docs/intro/): เฟรมเวิร์กแอปเดสก์ท็อป
- [Effect-TS](https://github.com/Effect-TS/effect): เพิ่มความสามารถแบบฟังก์ชันนัลและความปลอดภัยของชนิดข้อมูลสูงสุด โดยผลลัพธ์และข้อผิดพลาดรวมอยู่ในลายเซ็นของฟังก์ชัน
- [Svelte Sonner](https://svelte-sonner.vercel.app/): ไลบรารี toast สำหรับ Svelte ใช้แสดงข้อผิดพลาดที่เกิดจาก Effect-TS ด้วยฟังก์ชัน `renderAsToast`
- [TanStack Table](https://tanstack.com/table): สำหรับจัดการตารางข้อมูลทั้งหมด
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): API ระดับต่ำสำหรับเก็บข้อมูลขนาดใหญ่ในเบราว์เซอร์ ซิงก์กับ Tanstack Table
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): ไลบรารี UI ที่เลือกใช้
- [TailwindCSS](https://tailwindcss.com/docs): เฟรมเวิร์ก CSS แบบ utility-first สำหรับสร้าง UI อย่างรวดเร็ว
- [Turborepo](https://turborepo.org/): สำหรับจัดการ monorepo ให้ `apps/app` และ `apps/extension` ใช้โค้ดร่วมกัน เพื่อลดการซ้ำซ้อนของโค้ดและรักษาแหล่งข้อมูลเดียว
- [Rust](https://www.rust-lang.org): สำหรับขยายฟีเจอร์เดสก์ท็อป เช่น ใช้ crate `enigo` เพื่อจัดการการวางข้อความอัตโนมัติ
- [Vercel](https://vercel.com/): โฮสต์ที่เหมาะสำหรับโปรเจกต์ส่วนตัวและรวมกับ Turborepo ได้ดี
- [Zapsplat.com](https://www.zapsplat.com/): ไลบรารีเสียงเอฟเฟกต์ปลอดค่าลิขสิทธิ์

#### ส่วนขยาย

ส่วนขยาย Chrome ของ Whispering สร้างขึ้นโดยใช้:

- [Plasmo](https://docs.plasmo.com/): เฟรมเวิร์กสำหรับสร้างส่วนขยาย Chrome เราใช้ [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) เพื่อสื่อสารกับเว็บไซต์ Whispering
- [Effect-TS](https://github.com/Effect-TS/effect): เพิ่มความสามารถแบบฟังก์ชันนัลและความปลอดภัยของชนิดข้อมูลสูงสุด โดยผลลัพธ์และข้อผิดพลาดรวมอยู่ในลายเซ็นของฟังก์ชัน
- [React](https://reactjs.org): ไลบรารี UI สำหรับส่วนขยาย Chrome เนื่องจาก Plasmo ยังไม่รองรับ Svelte 5
- [ShadCN](https://github.com/shadcn): ไลบรารี UI สำหรับส่วนขยาย Chrome
- [TailwindCSS](https://tailwindcss.com/docs): เฟรมเวิร์ก CSS แบบ utility-first สำหรับการสร้างส่วนติดต่อผู้ใช้ที่กำหนดเองได้อย่างรวดเร็ว
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): Chrome extension API
- [Zapsplat.com](https://www.zapsplat.com/): คลังเอฟเฟกต์เสียงที่ไม่มีลิขสิทธิ์

## รัน Whispering ในโหมดพัฒนาแบบ Local

ในการตั้งค่าโปรเจกต์บนเครื่องของคุณ ให้ทำตามขั้นตอนดังนี้:

1. โคลน repository: `git clone https://github.com/braden-w/whispering.git`
2. เปลี่ยนไปยังไดเรกทอรีโปรเจกต์: `cd whispering`
3. ติดตั้ง dependencies ที่จำเป็น: `pnpm i`

เพื่อรันแอป Whispering บนเดสก์ท็อปและเว็บไซต์ในโหมดพัฒนา:

4. เปลี่ยนไปยังไดเรกทอรีแอป: `cd apps/app`
5. รันเซิร์ฟเวอร์พัฒนา: `pnpm tauri dev`

แอปเดสก์ท็อปควรเปิดขึ้นโดยอัตโนมัติสำหรับการพัฒนาแบบ local หากต้องการพัฒนาเว็บแอป ให้เปิดเบราว์เซอร์ของคุณและไปที่ `http://localhost:5173`

เพื่อรันส่วนขยาย Whispering Chrome ในโหมดพัฒนา:

4. เปลี่ยนไปยังไดเรกทอรี extension: `cd apps/extension`
5. รันเซิร์ฟเวอร์พัฒนา: `pnpm dev --target=chrome-mv3`

ในการพัฒนาส่วนขยาย Chrome ให้โหลดเข้า Chrome โดยไปที่ `chrome://extensions` เปิดโหมดนักพัฒนา แล้วโหลดโฟลเดอร์ `apps/extension/build/{platform}-{manifest-version}-dev` เป็นส่วนขยายแบบ unpacked

## สร้าง Executable ด้วยตัวเอง

หากคุณกังวลเกี่ยวกับความน่าเชื่อถือของตัวติดตั้ง หรืออยากควบคุมได้มากขึ้น คุณสามารถสร้าง executable ด้วยตัวเองได้เสมอ ซึ่งอาจต้องตั้งค่ามากขึ้น แต่จะช่วยให้มั่นใจว่าคุณรันโค้ดที่คุณคาดหวังได้ นี่คือข้อดีของซอฟต์แวร์โอเพ่นซอร์ส!

### Chrome

1. เปลี่ยนไปยังไดเรกทอรี extension: `cd apps/extension`
2. ติดตั้ง dependencies ที่จำเป็น: `pnpm i`
3. รัน Plasmo build: `pnpm plasmo build --target=chrome-mv3`
4. ผลลัพธ์จะอยู่ใน `apps/extension/build/chrome-mv3-prod` ซึ่งสามารถโหลดเข้า Chrome เป็นส่วนขยายแบบ unpacked ได้
5. หรือจะ build สำหรับ Chrome Web Store ด้วยคำสั่ง: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. เปลี่ยนไปยังไดเรกทอรี extension: `cd apps/extension`
2. ติดตั้ง dependencies ที่จำเป็น: `pnpm i`
3. รัน Plasmo build: `pnpm plasmo build --target=firefox-mv3`
4. ผลลัพธ์จะอยู่ใน `apps/extension/build/firefox-mv3-prod` ซึ่งสามารถโหลดเข้า Chrome เป็นส่วนขยายแบบ unpacked ได้
5. หรือจะ build สำหรับ Chrome Web Store ด้วยคำสั่ง: `pnpm plasmo build --target=firefox-mv3 --release`

### Desktop

1. เปลี่ยนไปยังไดเรกทอรีแอป: `cd apps/app`
2. ติดตั้ง dependencies ที่จำเป็น: `pnpm i`
3. รัน Tauri Build: `pnpm tauri build`
4. คุณสามารถหา executable ได้ในไดเรกทอรี `apps/app/target/release`

## การร่วมพัฒนา

เรายินดีต้อนรับการมีส่วนร่วมจากชุมชน! หากคุณต้องการช่วยพัฒนา Whispering กรุณาทำตามขั้นตอนดังนี้:

1. Fork repository
2. สร้าง branch ใหม่สำหรับฟีเจอร์หรือการแก้บั๊กของคุณ: `git checkout -b feature/your-feature-name` หรือ `git checkout -b fix/your-bugfix-name`
3. แก้ไขและ commit พร้อมข้อความอธิบายที่เหมาะสม
4. push branch ของคุณไปยัง repository ที่ fork ไว้: `git push origin your-branch-name`
5. สร้าง pull request จาก repository ที่ fork ไปยังต้นฉบับ

กรุณาตรวจสอบให้แน่ใจว่าโค้ดของคุณเป็นไปตามมาตรฐานที่กำหนดไว้ และมีเอกสารประกอบอย่างครบถ้วน

## ลิขสิทธิ์

Whispering เผยแพร่ภายใต้ [MIT License](https://opensource.org/licenses/MIT)

## ผู้สนับสนุน

โปรเจกต์นี้ได้รับการสนับสนุนจากบุคคลและองค์กรที่ยอดเยี่ยมดังต่อไปนี้:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## การสนับสนุนและข้อเสนอแนะ

หากคุณพบปัญหาหรือมีข้อเสนอแนะ กรุณาเปิด issue ที่ [GitHub issues tab](https://github.com/braden-w/whispering/issues) หรือ ติดต่อฉันที่ [whispering@bradenwong.com](mailto:whispering@bradenwong.com) ฉันขอขอบคุณสำหรับข้อเสนอแนะของคุณเป็นอย่างยิ่ง!

ขอบคุณที่ใช้ Whispering และขอให้สนุกกับการเขียน!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---