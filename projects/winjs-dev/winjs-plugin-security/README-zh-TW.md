
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# winjs-plugin-security

一個為 WinJS 專案提供安全性增強功能的插件，主要用於生成 SRI（子資源完整性）屬性。

<p>
  <a href="https://npmjs.com/package/@winner-fed/plugin-security">
   <img src="https://img.shields.io/npm/v/@winner-fed/plugin-security?style=flat-square&colorA=564341&colorB=EDED91" alt="npm version" />
  </a>
  <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="license" />
  <a href="https://npmcharts.com/compare/@winner-fed/plugin-security?minimal=true"><img src="https://img.shields.io/npm/dm/@winner-fed/plugin-security.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="downloads" /></a>
</p>

## 功能特性

- 自動為 HTML 檔案中的 `<script>` 與 `<link>` 標籤生成 SRI 屬性
- 支援 SHA-256、SHA-384、SHA-512 雜湊演算法（可設定）
- 自動添加 `crossorigin="anonymous"` 屬性以確保 SRI 正常運作
- 僅於生產環境下生效，開發環境自動略過

## 安裝

```bash
pnpm add @winner-fed/plugin-security
```
## 使用方法

在你的 `.winrc.ts` 配置文件中添加插件設定：


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## 配置選項

### `sri`

- **類型**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **預設值**: 需要手動設定
- **說明**: 是否啟用 SRI（子資源完整性）功能，以及可選的雜湊演算法設定

當設為 `true` 或 `{}` 時，外掛會：

1. 掃描建構後的 HTML 檔案
2. 為所有帶有 `src` 屬性的 `<script>` 標籤添加 `integrity` 屬性
3. 為所有帶有 `href` 屬性的 `<link>` 標籤添加 `integrity` 屬性
4. 自動添加 `crossorigin="anonymous"` 屬性（如不存在時）

你也可以透過物件方式指定雜湊演算法：


```typescript
security: {
  sri: {
    algorithm: 'sha512' // 可选 'sha256' | 'sha384' | 'sha512'，默认 'sha512'
  }
}
```

## 示例

### 输入 HTML

```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css">
</head>
<body>
  <script src="/assets/app.js"></script>
</body>
</html>
```
### 輸出 HTML（啟用 SRI 後）


```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css" integrity="sha512-ABC123..." crossorigin="anonymous">
</head>
<body>
  <script src="/assets/app.js" integrity="sha512-XYZ789..." crossorigin="anonymous"></script>
</body>
</html>
```
## 安全說明

SRI（子資源完整性）是一種安全特性，允許瀏覽器驗證取得的資源（例如從 CDN 取得的資源）沒有被惡意修改。當瀏覽器載入資源時，會計算資源的雜湊值並與 `integrity` 屬性中指定的雜湊值進行比對。如果雜湊值不相符，瀏覽器將拒絕載入該資源。

對於 `<script>` 標籤來說，結果為拒絕執行其中的程式碼；對於 CSS 連結來說，結果為不載入其中的樣式。

關於 SRI 的更多內容，可以參考 [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity)。

## 注意事項

1. 此插件僅在生產環境建置時生效，開發環境會自動略過
2. 需要確保資源檔案在建置輸出目錄中可存取
3. `integrity` 屬性必須與 `crossorigin` 屬性搭配使用才能正常運作

## 授權條款

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---