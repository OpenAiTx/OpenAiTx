# 📦📦 unplugin Imagemin 이미지 압축

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **팁:**
> `1.0 목표` unplugin-imagemin은 1.0 버전 출시를 준비 중이며, 다음 목표를 달성한 후 출시될 예정입니다.

- [x] squoosh의 wasm 문법을 재수정하여 모든 node 버전 지원
- [x] sharp 의존성 제거
- [x] publicDir 이미지 압축 지원
- [x] css 이미지 압축 지원
- [x] 전체 캐시 모드 지원
- [x] Node 22 및 그 이상 지원
- [x] 타입 옵션 지원
- [ ] farm, rsbuild, webpack 등 기타 프레임워크 지원

> [!WARNING]
새로운 기능, 안정성, 호환성 및 성능 기능이 지속적으로 업데이트되고 있습니다.
최신 버전 사용 권장  `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Google [squoosh](https://github.com/GoogleChromeLabs/squoosh)가 더 이상 node 방향을 유지보수하지 않아, 이 포크가 등장했고 일부 호환성 이슈를 수정했습니다. 자세한 내용은 [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest) 참조

### ✨✨ 테스트 중 지속적 반복 개발

```bash
✨ : unplugin-imagemin
✔ : Process start with mode squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Process start with mode squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 주요 기능

- 🍰 png jpeg webp avif svg tiff 포맷 지원
- 🦾 squoosh 기반 고성능
- ✨ 다양한 이미지 포맷 설정 가능
- 🪐 빌드 시점에 코드 압축
- 😃 캐싱 메커니즘
- 🌈 빌드 시점에 다양한 이미지 타입 변환 가능

## Squoosh && Svgo

Unplugin-imagemin은 두 가지 압축 도구를 지원합니다.

[Squoosh](https://github.com/GoogleChromeLabs/squoosh)는 다양한 포맷을 통해 이미지 크기를 줄여주는 이미지 압축 웹 앱입니다.
**Squoosh**는 rust & wasm 기반입니다.

[Svgo](https://github.com/svg/svgo)는 svg 포맷 이미지 압축 지원

## 📦 설치

```bash
pnpm add unplugin-imagemin@latest -D
```

#### vite 및 rollup 지원

<details>
<summary>기본</summary><br>

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
<summary>고급</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // 기본값 true
      cache: false,
      // 다양한 이미지 압축 기본 설정 옵션
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
```
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

DefaultConfiguration은 [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)를 참고하세요.

플러그인 속성 설정은 [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)를 참고하세요.

```typescript
export interface PluginOptions {
  /**
   * @description 이미지 컴파일 및 변환
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description 캐시 사용 여부
   * @default true
   */
  cache?: boolean;
  /**
   * @description 캐시 파일 위치 경로
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description 컴파일 속성
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---