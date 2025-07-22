<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

Sebuah plugin yang menyediakan peningkatan keamanan untuk proyek WinJS, terutama digunakan untuk menghasilkan atribut SRI (Subresource Integrity).

## Fitur

- Otomatis menghasilkan atribut SRI untuk tag `<script>` dan `<link>` dalam file HTML
- Mendukung algoritma hash SHA-256, SHA-384, SHA-512 (dapat dikonfigurasi)
- Otomatis menambahkan atribut `crossorigin="anonymous"` untuk memastikan SRI berfungsi dengan baik
- Hanya berlaku di lingkungan produksi, secara otomatis dilewati di lingkungan pengembangan

## Instalasi


```bash
pnpm add @winner-fed/plugin-security
```
## Cara Penggunaan

Tambahkan konfigurasi plugin di file konfigurasi `.winrc.ts` Anda:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## Opsi Konfigurasi

### `sri`

- **Tipe**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **Nilai default**: Perlu diatur secara manual
- **Deskripsi**: Apakah akan mengaktifkan fitur SRI (Subresource Integrity), serta konfigurasi algoritma hash opsional

Jika diatur ke `true` atau `{}`, plugin akan:

1. Memindai file HTML yang sudah dibangun
2. Menambahkan atribut `integrity` pada semua tag `<script>` yang memiliki atribut `src`
3. Menambahkan atribut `integrity` pada semua tag `<link>` yang memiliki atribut `href`
4. Secara otomatis menambahkan atribut `crossorigin="anonymous"` (jika belum ada)

Anda juga dapat menentukan algoritma hash melalui objek:


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
### Output HTML (setelah SRI diaktifkan)


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
## Petunjuk Keamanan

SRI (Subresource Integrity) adalah fitur keamanan yang memungkinkan browser memverifikasi bahwa sumber daya yang diambil (misalnya sumber daya dari CDN) tidak dimodifikasi secara jahat. Saat browser memuat sumber daya, ia akan menghitung nilai hash dari sumber daya tersebut dan membandingkannya dengan nilai hash yang ditentukan pada atribut `integrity`. Jika nilai hash tidak cocok, browser akan menolak untuk memuat sumber daya tersebut.

Untuk tag `<script>`, hasilnya adalah penolakan untuk mengeksekusi kode di dalamnya; untuk tautan CSS, hasilnya adalah gaya di dalamnya tidak akan dimuat.

Untuk informasi lebih lanjut tentang SRI, silakan lihat [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity).

## Catatan

1. Plugin ini hanya berlaku saat build produksi, lingkungan pengembangan akan otomatis dilewati
2. Pastikan file sumber daya dapat diakses di direktori output build
3. Atribut `integrity` harus digunakan bersama dengan atribut `crossorigin` agar dapat berfungsi dengan baik

## Lisensi

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---