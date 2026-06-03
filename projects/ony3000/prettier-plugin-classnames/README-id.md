<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# prettier-plugin-classnames

Sebuah plugin Prettier yang membungkus nama kelas yang panjang berdasarkan opsi `printWidth`.

![Contoh penggunaan plugin ini.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Instalasi[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: Jika versi `prettier-plugin-classnames` Anda kurang dari `0.4.0`, Anda juga perlu menginstal `@prettier/sync`.

## Konfigurasi

Contoh JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

Contoh JS (modul CommonJS):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

Contoh JS (modul ES):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### Pengesampingan Markdown/MDX

Plugin ini tidak mendukung Markdown dan MDX, namun jika plugin ini mendukung bahasa di dalam blok kode (mis. Vue), format yang tidak diinginkan dapat terjadi di dalam blok kode.

Untuk mencegah format yang tidak diinginkan, Anda dapat menggunakan pengaturan override untuk Markdown dan MDX.

Contoh JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"],
  "customFunctions": ["clsx"],
  "overrides": [
    {
      "files": ["*.md", "*.mdx"],
      "options": {
        "plugins": []
      }
    }
  ]
}
```

## Opsi

### Atribut Kustom

Daftar atribut yang nama kelasnya disertakan.<br>
Atribut `class` dan `className` selalu didukung, bahkan jika tidak ada opsi yang ditentukan.

<!-- prettier-ignore -->
Default | Override CLI&nbsp; | Override API&nbsp;
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Fungsi Kustom

Daftar fungsi yang nama kelasnya disertakan.<br>
Fungsi `classNames` selalu didukung, bahkan jika tidak ada opsi yang ditentukan.

<!-- prettier-ignore -->
Default | Override CLI&nbsp; | Override API&nbsp;
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Posisi Akhir

Tersedia pertama kali di v0.5.0.<br>
`absolute-with-indent` ditambahkan di v0.6.0.<br>
`absolute-with-indent` dihapus di v0.8.0, tetapi Anda bisa mendapatkan keluaran yang sama dengan `absolute`.<br>
Nilai default berubah dari `relative` menjadi `absolute` di v0.8.0.

Ini adalah kriteria untuk mengakhiri nama kelas pada setiap baris saat mengganti nama kelas asli dengan nama kelas multi-baris.

- Contoh `absolute`:

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 dark:bg-neutral-900/50
          border border-zinc-400/30 dark:border-neutral-500/30
          rounded-xl px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

- contoh `relative`:

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
       |------------------------------------------------------------|
        className="bg-gray-100/50 dark:bg-neutral-900/50 border
         |------------------------------------------------------------|
          border-zinc-400/30 dark:border-neutral-500/30 rounded-xl
          px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

<!-- prettier-ignore -->
Default | Override CLI | Override API
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Transformasi Sintaks

Pertama kali tersedia di v0.7.7.

Jika terjadi pemisahan baris pada nama kelas yang ditulis dalam sintaks non-ekspresi, maka akan diubah menjadi sintaks ekspresi. Transformasi ini tidak mendukung pemformatan yang dapat dibalik.

<!-- prettier-ignore -->
Default | Override CLI | Override API
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### Lebar Cetak Classnames

Pertama kali tersedia di v0.10.0.

Tentukan lebar cetak dari nama kelas. Jika tidak ada nilai yang diberikan, nilai `printWidth` digunakan sebagai default.

<!-- prettier-ignore -->
Default | Override CLI | Override API
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## Korelasi Versi dengan Plugin Sibling

Mulai dari `0.6.0`, ketika ada rilis minor di satu sisi, saya berencana untuk merefleksikan perubahan tersebut di sisi lain jika memungkinkan.

![Korelasi versi.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Kompatibilitas dengan Plugin Prettier Lainnya

Jika lebih dari satu plugin Prettier dapat menangani teks yang ingin Anda format, Prettier hanya akan menggunakan plugin terakhir dari plugin-plugin tersebut.

Dalam kasus ini, Anda dapat mengkonfigurasinya seperti berikut dengan menambahkan [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) untuk menerapkan plugin-plugin tersebut secara berurutan.

Contoh JSON:

<!-- prettier-ignore -->
```json
{
  "plugins": [
    "prettier-plugin-tailwindcss",
    "prettier-plugin-classnames",
    "prettier-plugin-merge"
  ]
}
```

## Stargazers over time

[![Stargazers over time](https://starchart.cc/ony3000/prettier-plugin-classnames.svg?variant=adaptive)](https://starchart.cc/ony3000/prettier-plugin-classnames)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---