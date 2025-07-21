# winjs-plugin-security

一个为 WinJS 项目提供安全增强功能的插件，主要用于生成 SRI（Subresource Integrity）属性。

## 功能特性

- 自动为 HTML 文件中的 `<script>` 和 `<link>` 标签生成 SRI 属性
- 支持 SHA-256、SHA-384、SHA-512 哈希算法（可配置）
- 自动添加 `crossorigin="anonymous"` 属性以确保 SRI 正常工作
- 仅在生产环境下生效，开发环境自动跳过

## 安装

```bash
pnpm add @winner-fed/plugin-security
```

## 使用方法

在你的 `.winrc.ts` 配置文件中添加插件配置：

```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```

## 配置选项

### `sri`

- **类型**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **默认值**: 需要手动设置
- **描述**: 是否启用 SRI（子资源完整性）功能，以及可选的哈希算法配置

当设置为 `true` 或 `{}` 时，插件会：

1. 扫描构建后的 HTML 文件
2. 为所有带有 `src` 属性的 `<script>` 标签添加 `integrity` 属性
3. 为所有带有 `href` 属性的 `<link>` 标签添加 `integrity` 属性
4. 自动添加 `crossorigin="anonymous"` 属性（如果不存在）

你也可以通过对象方式指定哈希算法：

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

### 输出 HTML（启用 SRI 后）

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

## 安全说明

SRI（子资源完整性）是一种安全特性，允许浏览器验证获取的资源（例如从 CDN 获取的资源）没有被恶意修改。当浏览器加载资源时，会计算资源的哈希值并与 `integrity` 属性中指定的哈希值进行比较。如果哈希值不匹配，浏览器将拒绝加载该资源。

对于 `<script>` 标签来说，结果为拒绝执行其中的代码；对于 CSS links 来说，结果为不加载其中的样式。

关于 SRI 的更多内容，可以查看 [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity)。

## 注意事项

1. 此插件仅在生产构建时生效，开发环境会自动跳过
2. 需要确保资源文件在构建输出目录中可访问
3. `integrity` 属性必须与 `crossorigin` 属性配合使用才能正常工作

## 许可证

MIT

