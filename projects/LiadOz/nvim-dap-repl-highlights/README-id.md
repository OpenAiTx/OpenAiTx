
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# nvim-dap-repl-highlights
Tambahkan highlight sintaks pada buffer REPL [nvim-dap](https://github.com/mfussenegger/nvim-dap) menggunakan treesitter.
| Sebelum                                                                                                         | Sesudah                                                                                                        |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Persyaratan
* Neovim 0.9 atau versi yang lebih baru
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Pengaturan
Instal plugin dan persyaratannya menggunakan metode favorit Anda. Setelah terinstal, pastikan Anda telah mengonfigurasi [highlighting](https://github.com/nvim-treesitter/nvim-treesitter#modules) treesitter lalu tambahkan berikut ini ke konfigurasi lua Anda
```lua
require('nvim-dap-repl-highlights').setup()
```
Setelah awalnya memasang plugin, parser dap_repl perlu diinstal, ini dapat dilakukan secara manual dengan menjalankan `:TSInstall dap_repl`.

Atau secara otomatis melalui konfigurasi Treesitter:

**Menggunakan `ensure_installed` (cabang master nvim-treesitter)**
> ⚠️ **CATATAN:** Anda harus memanggil nvim-dap-repl-highlights.setup() sebelum Treesitter, jika tidak parser dap_repl tidak akan ditemukan.
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter.configs').setup {
  highlight = {
    enable = true,
  },
  ensure_installed = { 'dap_repl', ... },
  ...
}
```
**Menggunakan `nvim-treesitter.install` (cabang utama nvim-treesitter)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ Jika ini tidak berfungsi lagi atau API berubah, periksa dokumentasi resmi Treesitter untuk metode instalasi terbaru:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## Penggunaan
Secara default, plugin mendeteksi bahasa yang digunakan di REPL dengan melihat **filetype** yang digunakan untuk meluncurkan dap. Tentu saja untuk mendapatkan penyorotan sintaks untuk bahasa tertentu, Anda perlu memiliki parser treesitter untuk bahasa tersebut, bersama dengan parser `dap_repl`.
Ini mungkin tidak cocok untuk semua kasus penggunaan.

Sebagai alternatif, Anda dapat menggunakan perintah `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` yang akan mengatur penyorotan python di buffer repl saat ini.
Atau, fungsi tersebut dapat dipanggil tanpa menentukan bahasa, yang akan meminta pengguna memilih bahasa.

Selain itu, Anda dapat menentukan dalam konfigurasi **dap** bahasa repl yang akan digunakan, misalnya jika Anda ingin repl python Anda memiliki penyorotan javascript:
```lua
local dap = require('dap')
dap.configurations.python = {
  {
    name = "Python with javascript repl because I like to watch the world burn 🔥🔥🔥",
    type = "python",
    request = "launch",
    program = "${file}",
    repl_lang = "javascript"
  },
}
```
Opsi repl_lang memiliki prioritas lebih tinggi daripada filetype.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---