# Update Browserslist DB

<img width="120" height="120" alt="Logo Browserslist oleh Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

Alat CLI untuk memperbarui `caniuse-lite` dengan basis data browser
dari konfigurasi [Browserslist](https://github.com/browserslist/browserslist/).

Beberapa kueri seperti `last 2 versions` atau `>1%` bergantung pada data aktual
dari `caniuse-lite`.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Disponsori oleh Evil Martians" width="236" height="54">
</a>

## Mengapa Anda perlu menjalankannya secara rutin

`npx update-browserslist-db@latest` memperbarui versi `caniuse-lite`
di file lock npm, yarn, atau pnpm Anda.

Pembaruan ini akan membawa data tentang browser baru ke alat polyfill
seperti Autoprefixer atau Babel dan mengurangi polyfill yang sudah tidak diperlukan.

Anda perlu melakukannya secara rutin karena tiga alasan:

1. Untuk menggunakan versi dan statistik browser terbaru dalam kueri seperti
   `last 2 versions` atau `>1%`. Misalnya, jika Anda membuat proyek
   2 tahun yang lalu dan tidak memperbarui dependensi, `last 1 version`
   akan mengembalikan browser yang berusia 2 tahun.
2. Data browser aktual akan menyebabkan penggunaan polyfill yang lebih sedikit. Ini akan mengurangi
   ukuran file JS dan CSS serta meningkatkan performa situs web.
3. Deduplikasi `caniuse-lite`: untuk menyinkronkan versi di berbagai alat.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---