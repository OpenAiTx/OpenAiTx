# EmuReady

แพลตฟอร์มที่ขับเคลื่อนโดยชุมชน สำหรับติดตามความเข้ากันได้ของการจำลองระบบ (Emulation) ในอุปกรณ์และอีมูเลเตอร์ต่าง ๆ

เยี่ยมชมเว็บไซต์ของเรา: [https://emuready.com](https://emuready.com)

---

**ภาพหน้าจอหน้าแรก**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**ภาพหน้าจอหน้ารายการความเข้ากันได้**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**ภาพหน้าจอหน้ารายการเกม**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## ภาพรวม

EmuReady ช่วยให้ผู้ใช้สามารถแบ่งปันและค้นหาข้อมูลความเข้ากันได้ของการจำลองระบบในฮาร์ดแวร์และซอฟต์แวร์ที่แตกต่างกัน ผู้ใช้สามารถมีส่วนร่วมในการรายงานความเข้ากันได้ โหวตรายการ และพูดคุยเกี่ยวกับเกม/อุปกรณ์/อีมูเลเตอร์เฉพาะ

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## ฟีเจอร์

- **ฐานข้อมูลความเข้ากันได้ที่ครอบคลุม**: ติดตามประสิทธิภาพของเกมบนอีมูเลเตอร์และอุปกรณ์ต่าง ๆ
- **การมีส่วนร่วมจากผู้ใช้**: รายงานและระบบโหวตที่ขับเคลื่อนโดยชุมชน
- **ระบบพูดคุย**: เธรดความคิดเห็นพร้อมฟังก์ชันโหวตขึ้น/ลง
- **แดชบอร์ดผู้ดูแล**: จัดการผู้ใช้ รายการ และการดูแลเนื้อหา
- **การออกแบบที่ตอบสนอง**: ใช้งานได้ทั้งบนมือถือ แท็บเล็ต และเดสก์ท็อป

## การปรับปรุงล่าสุด

โค้ดเบสได้รับการปรับปรุงอย่างมีนัยสำคัญด้วยคุณสมบัติดังต่อไปนี้:

### ส่วนประกอบ UI

- สร้างคอมโพเนนต์ **ErrorBoundary** เพื่อการจัดการข้อผิดพลาดและกู้คืนที่ดีขึ้น
- เพิ่มคอมโพเนนต์ **OptimizedImage** โดยใช้ Next.js Image เพื่อประสิทธิภาพที่ดียิ่งขึ้น
- ปรับปรุง **Pagination** ด้วยฟีเจอร์การเข้าถึง การนำทางด้วยคีย์บอร์ด และประสบการณ์ผู้ใช้ที่ดีขึ้น
- ปรับปรุงคอมโพเนนต์ **Badge** ด้วยตัวเลือกและขนาดที่มากขึ้น รวมทั้งรูปแบบ pill
- เพิ่มคอมโพเนนต์ **ThemeToggle** สำหรับสลับระหว่างธีมสว่าง มืด และระบบ
- ใช้งาน **SortableHeader** สำหรับการเรียงลำดับตารางพร้อมตัวบ่งชี้ภาพ

### แคช & ประสิทธิภาพ

- ปรับปรุงการตั้งค่า React Query ด้วยค่าเริ่มต้นที่ดีกว่าสำหรับแคช เวลา stale และตรรกะการลองใหม่
- เพิ่มการปรับแต่งรูปภาพสำหรับภาพอุปกรณ์
- ใช้งานการจัดการข้อผิดพลาดที่เหมาะสมตลอดทั้งแอปพลิเคชัน

### การเข้าถึง

- ปรับปรุงการนำทางด้วยคีย์บอร์ดสำหรับองค์ประกอบที่โต้ตอบได้
- เพิ่ม ARIA labels และ roles ที่เหมาะสม
- ปรับปรุงการจัดการโฟกัส
- ความเปรียบต่างสีที่ดีขึ้นในส่วนประกอบ UI

### ความปลอดภัย

- การตรวจสอบและทำความสะอาดข้อมูลในหลายระดับ (ไคลเอนต์, เซิร์ฟเวอร์, ฐานข้อมูล)
- ใช้งาน Content Security Policy
- ป้องกันการโจมตี XSS และ CSRF
- ระบบยืนยันตัวตนอย่างปลอดภัยด้วย NextAuth.js
- การตรวจสอบไฟล์อัปโหลดและมาตรการความปลอดภัย
- จำกัดความยาวอินพุตและการทำความสะอาดข้อมูลที่เหมาะสม
- การตรวจสอบ UUID เพื่อป้องกันการแก้ไขพารามิเตอร์

### ประสบการณ์นักพัฒนา

- เพิ่มสคริปต์ npm สำหรับเวิร์กโฟลว์การพัฒนา
- โครงสร้างโปรเจกต์ที่ดียิ่งขึ้นด้วยการส่งออกที่สม่ำเสมอ
- ข้อเสนอแนะข้อผิดพลาดที่ดีขึ้นด้วย ErrorBoundary แบบกำหนดเอง
- ปรับปรุงหน้า 404 พร้อมตัวเลือกการนำทางที่ช่วยเหลือผู้ใช้

### ธีม

- เพิ่มการตรวจจับค่าธีมของระบบ
- สร้างตัวเลือกสลับธีมพร้อมตัวเลือก UI หลายรูปแบบ
- ปรับปรุงการใช้งานโหมดมืดในทุกส่วนประกอบ

## เริ่มต้นใช้งาน

### ข้อกำหนดเบื้องต้น

- Node.js 20+
- `npm`
- PostgreSQL (หรือ SQLite สำหรับการพัฒนา)

### การติดตั้ง

1. โคลน repository

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. ติดตั้ง dependencies

```bash
npm install
```

3. ตั้งค่าตัวแปรสภาพแวดล้อม

```bash
cp .env.example .env
```

จากนั้นแก้ไขไฟล์ `.env` ด้วยข้อมูลฐานข้อมูลและการตั้งค่าอื่น ๆ ของคุณ

4. ตั้งค่าฐานข้อมูล

```bash
npx prisma generate
npx prisma db push
```

5. รันเซิร์ฟเวอร์สำหรับนักพัฒนา

```bash
npm run dev
```

6. เปิด [http://localhost:3000](http://localhost:3000) ในเบราว์เซอร์ของคุณ

## สคริปต์ที่พร้อมใช้งาน

- `npm run dev` - เริ่มเซิร์ฟเวอร์สำหรับนักพัฒนา
- `npm run dev:strict` - เริ่มด้วย React strict mode
- `npm run build` - สร้างสำหรับ production
- `npm run start` - เริ่มเซิร์ฟเวอร์ production
- `npm run test` - รันการทดสอบ
- `npm run lint` - รัน ESLint
- `npm run lint:fix` - แก้ไขปัญหา lint อัตโนมัติ
- `npm run format` - จัดรูปแบบโค้ดด้วย Prettier
- `npm run typecheck` - ตรวจสอบประเภท TypeScript
- `npm run analyze` - วิเคราะห์ขนาด bundle
- `npm run clean` - ล้างแคช build
- `npm run prepare-deploy` - เตรียมสำหรับการ deploy (lint, typecheck, test, build)

### คำสั่ง Prisma

- `npx prisma db seed` - เติมข้อมูลตัวอย่างในฐานข้อมูล
- `npx prisma studio` - เปิด Prisma Studio
- `npx prisma db pull` - ดึง schema ฐานข้อมูล
- `npx prisma db push` - ส่ง schema ฐานข้อมูล

ดูรายละเอียดเพิ่มเติมที่ [Prisma Cli Reference](https://www.prisma.io/docs/orm/reference/prisma-cli-reference)

## สแต็กเทคโนโลยี

- **Framework**: Next.js 15
- **Database ORM**: Prisma
- **API**: tRPC
- **Authentication**: NextAuth.js
- **Styling**: Tailwind CSS
- **State Management**: React Query
- **Type Checking**: TypeScript
- **Animation**: Framer Motion
- **Validation**: Zod, Content Security Policy, Input Validation

## การมีส่วนร่วม

เรายินดีต้อนรับทุกการมีส่วนร่วม! กรุณาดู [แนวทางการมีส่วนร่วม](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) สำหรับรายละเอียดเพิ่มเติม

## ใบอนุญาต

โครงการนี้อยู่ภายใต้สัญญาอนุญาต MIT - ดูที่ไฟล์ [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) สำหรับรายละเอียด

## จรรยาบรรณ (TODO)

โปรดทราบว่าโครงการนี้ปฏิบัติตาม [จรรยาบรรณ](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md) การมีส่วนร่วมของคุณถือเป็นการยอมรับข้อกำหนดเหล่านี้

## ความปลอดภัย (TODO)

หากคุณพบช่องโหว่ด้านความปลอดภัย โปรดปฏิบัติตาม [นโยบายความปลอดภัย](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) ของเราในการรายงาน

## ขอบคุณ

- [ผู้มีส่วนร่วมทั้งหมด](https://github.com/Producdevity/emuready/graphs/contributors)
- ชุมชนอีมูเลชันสำหรับแรงบันดาลใจและการสนับสนุน

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---