<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">Repositori Komunitas AstroNvim</h1>

Repositori komunitas AstroNvim berisi spesifikasi konfigurasi plugin — kumpulan plugin yang disumbangkan oleh komunitas untuk AstroNvim, sebuah konfigurasi NeoVim. Spesifikasi ini membantu mengelola berbagai plugin yang digunakan dalam AstroNvim.

## 📦 Pengaturan

Untuk mengintegrasikan plugin komunitas, tambahkan konfigurasi yang disediakan ke pengaturan `plugins` Anda, sebaiknya sebelum Anda mengimpor plugin Anda sendiri untuk menjamin semua perubahan AstroCommunity dimuat sebelum override Anda sendiri. Jika Anda menggunakan [Template AstroNvim](https://github.com/AstroNvim/template) Ini dapat dilakukan dalam file `lua/community.lua` Anda. Jika Anda belum terbiasa dengan konfigurasi plugin, kami sarankan merujuk ke [dokumentasi AstroNvim](https://docs.astronvim.com/configuration/customizing_plugins/).

### Mengimpor Plugin AstroCommunity

Integrasikan konten berikut di dalam file `lua/community.lua` Anda:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/astrocommunity/colorscheme/catppuccin" },
  -- ... impor plugin kontribusi komunitas lainnya di sini
}
```

### Menyesuaikan Instalasi AstroCommunity

Setelah Anda mendefinisikan impor AstroCommunity dalam `lua/community.lua` Anda, Anda dapat menyesuaikan instalasi lebih lanjut dalam definisi plugin Anda sendiri (biasanya dilakukan di direktori `lua/plugins/`). Berikut adalah contoh dengan asumsi Anda sudah menginstal Catppuccin seperti yang ditunjukkan di atas.

```lua
return {
  { -- sesuaikan lebih lanjut opsi yang diatur oleh komunitas
    "catppuccin",
    opts = {
      integrations = {
        sandwich = false,
        noice = true,
        mini = true,
        leap = true,
        markdown = true,
        neotest = true,
        cmp = true,
        overseer = true,
        lsp_trouble = true,
        rainbow_delimiters = true,
      },
    },
  },
}
```

**Catatan:**

- Untuk menonaktifkan impor, atur opsi `enabled` ke `false`. Anda memiliki dua cara untuk memodifikasi plugin yang sudah ada: gunakan nama repositori lengkap (misalnya, "m4xshen/smartcolumn.nvim") atau nama modul (misalnya, "catppuccin"). Ingat, nama modul mungkin berbeda dari nama folder.
- Disarankan menggunakan jalur impor lengkap saat menyesuaikan plugin, dan bukan notasi singkat hanya nama repositori.
- Anda dapat menimpa banyak aspek plugin komunitas termasuk pengaturan, dependensi, dan versi. Untuk detail lebih lanjut tentang opsi yang tersedia, lihat [dokumentasi lazy.nvim](https://lazy.folke.io/).

## Berkontribusi

Jika Anda telah menulis konfigurasi plugin dan ingin menambahkannya ke repositori AstroCommunity, silakan ikuti [Panduan Kontribusi](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) kami dan ajukan pull request. Pastikan Anda telah menguji perubahan Anda secara menyeluruh sebelum pengajuan. Ini bukan repositori resmi, jadi stabilitasnya bergantung pada kontribusi komunitas. Kami sangat antusias melihat bagaimana proyek ini tumbuh dan berkembang!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---