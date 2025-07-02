# 📦📦 unplugin Imagemin การบีบอัดรูปภาพ

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **เคล็ดลับ:**
> `1.0 goals` unplugin-imagemin กำลังเตรียมปล่อยเวอร์ชัน 1.0 ซึ่งจะปล่อยหลังจากบรรลุเป้าหมายดังต่อไปนี้

- [x] รองรับทุกเวอร์ชันของ node โดยแก้ไขไวยากรณ์ wasm ของ squoosh ใหม่
- [x] ลบ sharp deps ออก
- [x] รองรับการบีบอัดภาพใน publicDir
- [x] รองรับการบีบอัดภาพใน css
- [x] รองรับโหมดแคชเต็มรูปแบบ
- [x] รองรับ Node 22 และเวอร์ชันอื่น ๆ
- [x] ตัวเลือกประเภท (Type options)
- [ ] รองรับ farm, rsbuild, webpack และเฟรมเวิร์กอื่น ๆ

> [!WARNING]
ฟีเจอร์ใหม่ ความเสถียร ความเข้ากันได้ และประสิทธิภาพ กำลังอัปเดตอย่างต่อเนื่อง
แนะนำให้ใช้เวอร์ชันล่าสุด  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
เนื่องจาก Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) ไม่ได้ดูแลพัฒนาในฝั่ง node อีกต่อไป จึงมี fock นี้ขึ้นมาและแก้ไขปัญหาความเข้ากันได้บางอย่าง รายละเอียด [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ การพัฒนาแบบวนซ้ำอย่างต่อเนื่องในขั้นตอนทดสอบ

```bash
✨ : unplugin-imagemin
✔ : Process start with mode squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Process start with mode squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 คุณสมบัติ

- 🍰 รองรับไฟล์ png jpeg webp avif svg tiff
- 🦾 ประสิทธิภาพสูงโดยใช้ squoosh
- ✨ สามารถตั้งค่าหลายรูปแบบของไฟล์ภาพ
- 🪐 บีบอัดโค้ดขณะ build
- 😃 มีระบบแคช
- 🌈 สามารถแปลงประเภทของรูปภาพต่าง ๆ ระหว่าง build

## Squoosh && Svgo

Unplugin-imagemin รองรับเครื่องมือบีบอัดภาพสองแบบ

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) เป็นเว็บแอปสำหรับบีบอัดรูปภาพที่ลดขนาดไฟล์ภาพได้หลากหลายรูปแบบ
**Squoosh** ทำงานร่วมกับ rust & wasm

[Svgo](https://github.com/svg/svgo) รองรับการบีบอัดภาพในรูปแบบ svg

## 📦 การติดตั้ง

```bash
pnpm add unplugin-imagemin@latest -D
```

#### รองรับ vite และ rollup

<details>
<summary>พื้นฐาน</summary><br>

```ts
import { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [vue(), imagemin()],
});
```

<br></details>

<details>
<summary>ขั้นสูง</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // ค่าเริ่มต้น true
      cache: false,
      // ตัวเลือกการตั้งค่าเริ่มต้นสำหรับการบีบอัดภาพแต่ละประเภท
      compress: {
        jpg: {
          quality: 10,
        },
        jpeg: {
          quality: 10,
        },
        png: {
          quality: 10,
        },
```typescript
        webp: {
          quality: 10,
        },
      },
      conversion: [
        { from: 'jpeg', to: 'webp' },
        { from: 'png', to: 'webp' },
        { from: 'JPG', to: 'jpeg' },
      ],
    }),
  ],
});

```

<br></details>

## 🌸 DefaultConfiguration

Squoosh DefaultConfiguration

DefaultConfiguration ดูได้ที่ [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

การตั้งค่าคุณสมบัติของปลั๊กอินดูได้ที่ [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description การคอมไพล์และแปลงรูปภาพ
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description เปิดใช้งานแคชหรือไม่
   * @default true
   */
  cache?: boolean;
  /**
   * @description เส้นทางไปยังตำแหน่งไฟล์แคช
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description คุณสมบัติการคอมไพล์
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---