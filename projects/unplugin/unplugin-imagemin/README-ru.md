# 📦📦 unplugin Imagemin Сжатие изображений

[![NPM version](https://img.shields.io/npm/v/unplugin-imagemin?color=a1b858&label=)](https://www.npmjs.com/package/unplugin-imagemin)

> [!IMPORTANT]
> **Советы:**
> `1.0 цели` unplugin-imagemin готовится к выпуску версии 1.0, которая будет выпущена после достижения следующих целей

- [x] Поддержка всех версий node путем ремодификации wasm-синтаксиса squoosh
- [x] удаление зависимостей sharp
- [x] поддержка сжатия изображений из publicDir
- [x] поддержка сжатия изображений в css
- [x] Поддержка полного режима кэширования
- [x] Поддержка Node 22 и выше
- [x] Типы опций
- [ ] Поддержка farm, rsbuild, webpack и других фреймворков

> [!WARNING]
Новые функции, стабильность, совместимость и производительность постоянно обновляются  
Рекомендуется использовать последнюю версию `pnpm add unplugin-imagemin@latest -D`

> [!WARNING]
Поскольку Google [squoosh](https://github.com/GoogleChromeLabs/squoosh) больше не поддерживает node-направление, был создан этот форк и исправлены некоторые проблемы совместимости. Подробнее [squoosh-next](https://github.com/ErKeLost/squoosh-node-latest)

### ✨✨ Непрерывная итеративная разработка в процессе тестирования

```bash
✨ : unplugin-imagemin
✔ : Процесс запущен в режиме squoosh
✅ : [test1.png] [12.39 MB] -> [102.54 KB]
✔ : Процесс запущен в режиме squoosh
✅ : [test2.png] [16.38 MB] -> [76.79 KB]
```

#### 🌈 Возможности

- 🍰 Поддержка форматов png jpeg webp avif svg tiff
- 🦾 Высокая производительность на базе squoosh
- ✨ Возможность настройки нескольких форматов изображений
- 🪐 Сжатие кода на этапе сборки
- 😃 Механизм кэширования
- 🌈 Возможность конвертации различных типов изображений на этапе сборки

## Squoosh && Svgo

Unplugin-imagemin поддерживает два инструмента сжатия

[Squoosh](https://github.com/GoogleChromeLabs/squoosh) — это веб-приложение для сжатия изображений, уменьшающее их размер за счет различных форматов.
**Squoosh** на rust & wasm

[Svgo](https://github.com/svg/svgo) Поддержка сжатия изображений в формате svg

## 📦 Установка

```bash
pnpm add unplugin-imagemin@latest -D
```

#### поддержка vite и rollup

<details>
<summary>Базовый пример</summary><br>

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
<summary>Продвинутый пример</summary><br>

```ts
iimport { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import imagemin from 'unplugin-imagemin/vite';
// https://vitejs.dev/config/
export default defineConfig({
  plugins: [
    vue(),
    imagemin({
      // по умолчанию true
      cache: false,
      // Стандартные параметры сжатия для различных изображений
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

DefaultConfiguration см. [DefaultConfiguration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/compressOptions.ts)

Конфигурация свойств плагина см. [configuration](https://github.com/ErKeLost/unplugin-imagemin/blob/main/src/core/types/index.ts)

```typescript
export interface PluginOptions {
  /**
   * @description Компиляция и конвертация изображений
   * @default []
   */
  conversion?: ConversionItemType[];
  /**
   * @description Включить ли кэширование
   * @default true
   */
  cache?: boolean;
  /**
   * @description Путь к расположению файла кэша
   * @default ./node_modules/.cache/unplugin-imagemin/.unplugin-imagemin-cache
   */
  cacheLocation?: string;
  /**
   * @description Атрибут компиляции
   * @default CompressTypeOptions
   */
  compress?: CompressTypeOptions;
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---