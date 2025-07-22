<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

Một plugin tăng cường bảo mật cho dự án WinJS, chủ yếu dùng để sinh thuộc tính SRI (Subresource Integrity).

## Tính năng

- Tự động tạo thuộc tính SRI cho các thẻ `<script>` và `<link>` trong file HTML
- Hỗ trợ các thuật toán băm SHA-256, SHA-384, SHA-512 (có thể cấu hình)
- Tự động thêm thuộc tính `crossorigin="anonymous"` để đảm bảo SRI hoạt động đúng
- Chỉ hoạt động ở môi trường sản xuất, tự động bỏ qua ở môi trường phát triển

## Cài đặt


```bash
pnpm add @winner-fed/plugin-security
```
## Cách sử dụng

Thêm cấu hình plugin vào tệp cấu hình `.winrc.ts` của bạn:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Tùy chọn cấu hình

### `sri`

- **Kiểu**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Giá trị mặc định**: Cần thiết lập thủ công
- **Mô tả**: Bật hay tắt chức năng SRI (Toàn vẹn tài nguyên phụ), cùng tùy chọn cấu hình thuật toán băm

Khi được thiết lập là `true` hoặc `{}` thì plugin sẽ:

1. Quét các tệp HTML sau khi build
2. Thêm thuộc tính `integrity` cho tất cả thẻ `<script>` có thuộc tính `src`
3. Thêm thuộc tính `integrity` cho tất cả thẻ `<link>` có thuộc tính `href`
4. Tự động thêm thuộc tính `crossorigin="anonymous"` (nếu chưa có)

Bạn cũng có thể chỉ định thuật toán băm dưới dạng đối tượng:


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
### Xuất HTML (sau khi bật SRI)


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
## Hướng dẫn an toàn

SRI (Toàn vẹn tài nguyên phụ) là một tính năng bảo mật cho phép trình duyệt xác minh rằng tài nguyên được lấy (ví dụ tài nguyên lấy từ CDN) không bị sửa đổi độc hại. Khi trình duyệt tải tài nguyên, nó sẽ tính toán giá trị băm của tài nguyên và so sánh với giá trị băm được chỉ định trong thuộc tính `integrity`. Nếu giá trị băm không khớp, trình duyệt sẽ từ chối tải tài nguyên đó.

Đối với thẻ `<script>`, kết quả là từ chối thực thi mã trong đó; đối với các liên kết CSS, kết quả là không tải các kiểu dáng bên trong.

Để biết thêm về SRI, bạn có thể xem [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity).

## Lưu ý

1. Plugin này chỉ có hiệu lực khi build sản phẩm, môi trường phát triển sẽ tự động bỏ qua
2. Cần đảm bảo các file tài nguyên có thể truy cập được trong thư mục xuất ra khi build
3. Thuộc tính `integrity` phải được sử dụng cùng với thuộc tính `crossorigin` để hoạt động bình thường

## Giấy phép

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---