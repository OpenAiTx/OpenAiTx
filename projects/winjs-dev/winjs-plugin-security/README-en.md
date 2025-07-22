<div align="right">
  <details>
    <summary >🌐 Language</summary>
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

A plugin that provides security enhancements for WinJS projects, mainly used to generate SRI (Subresource Integrity) attributes.

## Features

- Automatically generates SRI attributes for `<script>` and `<link>` tags in HTML files
- Supports SHA-256, SHA-384, SHA-512 hash algorithms (configurable)
- Automatically adds `crossorigin="anonymous"` attribute to ensure SRI works properly
- Only effective in production environments; automatically skipped in development

## Installation


```bash
pnpm add @winner-fed/plugin-security
```
## Usage

Add the plugin configuration in your `.winrc.ts` configuration file:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Configuration Options

### `sri`

- **Type**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Default**: Must be set manually
- **Description**: Whether to enable SRI (Subresource Integrity) functionality and optional hash algorithm configuration

When set to `true` or `{}`, the plugin will:

1. Scan the built HTML files
2. Add `integrity` attributes to all `<script>` tags with a `src` attribute
3. Add `integrity` attributes to all `<link>` tags with a `href` attribute
4. Automatically add `crossorigin="anonymous"` attribute (if not present)

You can also specify the hash algorithm via an object:


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
### Output HTML (After Enabling SRI)


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
## Safety Instructions

SRI (Subresource Integrity) is a security feature that allows browsers to verify that fetched resources (such as those from a CDN) have not been maliciously altered. When the browser loads a resource, it calculates the resource's hash and compares it with the hash specified in the `integrity` attribute. If the hashes do not match, the browser will refuse to load the resource.

For `<script>` tags, this results in refusal to execute the code; for CSS links, it results in not loading the styles.

For more information about SRI, see [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity).

## Notes

1. This plugin only takes effect during production builds; it is automatically skipped in the development environment  
2. Ensure that resource files are accessible in the build output directory  
3. The `integrity` attribute must be used together with the `crossorigin` attribute to work properly

## License

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---