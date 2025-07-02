# 📦📦 unplugin Imagemin Nén hình ảnh

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **Gợi ý:**
> `Mục tiêu 1.0` unplugin-imagemin đang chuẩn bị phát hành phiên bản 1.0, sẽ được phát hành sau khi đạt được các mục tiêu sau

- [x] Hỗ trợ tất cả các phiên bản node bằng cách chỉnh sửa lại cú pháp wasm của squoosh
- [x] Loại bỏ phụ thuộc sharp
- [x] Hỗ trợ nén hình ảnh trong publicDir
- [x] Hỗ trợ nén hình ảnh trong css
- [x] Hỗ trợ chế độ bộ nhớ đệm đầy đủ
- [x] Hỗ trợ Node 22 và cao hơn
- [x] Tùy chọn kiểu dữ liệu
- [ ] Hỗ trợ farm, rsbuild, webpack, và các framework khác

> [!WARNING]
Các tính năng mới về tính ổn định, tương thích và hiệu suất liên tục được cập nhật
Khuyến nghị sử dụng phiên bản mới nhất  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Vì Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) không còn duy trì hướng node, nên phiên bản fock này đã xuất hiện và sửa một số vấn đề tương thích. Chi tiết tại [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ Phát triển lặp liên tục trong quá trình thử nghiệm

```bash
✨ : unplugin-imagemin
✔ : Bắt đầu xử lý với chế độ squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Bắt đầu xử lý với chế độ squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 Tính năng

- 🍰 Hỗ trợ định dạng png jpeg webp avif svg tiff
- 🦾 Hiệu suất cao dựa trên squoosh
- ✨ Có thể cấu hình nhiều định dạng hình ảnh
- 🪐 Nén mã nguồn khi build
- 😃 Cơ chế bộ nhớ đệm
- 🌈 Có thể chuyển đổi nhiều loại hình ảnh khi build

## Squoosh && Svgo

Unplugin-imagemin hỗ trợ hai công cụ nén

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) là ứng dụng web nén hình ảnh giúp giảm kích thước hình ảnh qua nhiều định dạng.
**Squoosh** sử dụng rust & wasm

[Svgo](https://github.com/svg/svgo) Hỗ trợ nén hình ảnh định dạng svg

## 📦 Cài đặt

```bash
pnpm add unplugin-imagemin@latest -D
```

#### hỗ trợ vite và rollup

<details>
<summary>Cơ bản</summary><br>

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
<summary>Nâng cao</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // mặc định true
      cache: false,
      // Các tùy chọn cấu hình mặc định cho nén nhiều loại hình ảnh khác nhau
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

Cấu hình mặc định của Squoosh

DefaultConfiguration xem tại [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

Cấu hình thuộc tính Plugin xem tại [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description Biên dịch và chuyển đổi hình ảnh
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description Bật/tắt bộ nhớ đệm
   * @default true
   */
  cache?: boolean;
  /**
   * @description Đường dẫn vị trí tệp bộ nhớ đệm
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description Thuộc tính biên dịch
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---