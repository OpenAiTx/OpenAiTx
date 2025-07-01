![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Anda dapat membaca [paper](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) saya dan mengutipnya seperti ini 
> WANG, Z. (2025, 12 Mei). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

Karena GitHub mungkin memblokir alamat IP Tiongkok, saya harus menyalin repositori ini ke [sini](https://codeberg.org/ufo5260987423/scheme-langserver) dan [sini](https://gitee.com/ufo5260987423/scheme-langserver). Saya akan terus memperbarui semua repositori tetapi saya tidak bisa menjamin. Saya sekarang juga bekerja sama dengan [XmacsLabs](https://github.com/XmacsLabs), Anda juga dapat menemukan fork [di sini](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Sekarang, VSCode dapat menggunakan scheme-langserver!** Silakan lihat [DI SINI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>CATATAN: Ada banyak sekali bug di scheme-langserver. Saya sedang memperbaiki dan meminta bantuan dari komunitas. Mohon bersabar.

>CATATAN: Anda dapat menemukan informasi tipe yang dihasilkan otomatis [di sini](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Sekarang ini terutama digunakan untuk pengembangan tahap selanjutnya (mungkin termasuk AKKU) dan debugging.

Mengimplementasikan dukungan seperti autocomplete, goto definition, atau dokumentasi saat hover adalah upaya besar dalam pemrograman. Namun, jika dibandingkan dengan bahasa lain seperti java, python, javascript, dan c, implementasi protokol server bahasa untuk bahasa lisp hanya dibuat di ruang hampa. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) dan [swish-lint](https://github.com/becls/swish-lint) dll., semua pekerjaan mereka didasarkan pada `repl` (Read-Eval-Print Loop) atau tokenizer kata kunci alih-alih pemrograman. Misalnya, jika seorang programmer sedang mengerjakan proyek yang belum selesai, di mana kode-kodenya belum sepenuhnya dapat dijalankan, [Geiser](https://gitlab.com/emacs-geiser) atau lainnya hanya akan melengkapi pengenal binding tingkat atas yang terdaftar oleh prosedur `environment-symbols` (untuk [Chez](https://cisco.github.io/ChezScheme/)), atau melengkapi simbol alih-alih pengenal. Artinya, untuk binding lokal dan kode yang belum selesai, meskipun usaha pemrograman seharusnya menjadi hal terpenting, [Geiser](https://gitlab.com/emacs-geiser) dan rekan-rekannya tidak membantu mengenali scope valid dari identifier. Kasus serupa juga terjadi pada goto definition dan banyak fungsi lainnya.

Penyebab utamanya adalah, untuk scheme dan dialek lisp lainnya, set data yang melimpah dan struktur kontrol yang fleksibel membuat analisis program menjadi tantangan besar. Terutama pada macro, tampaknya scheme terutama digunakan untuk pemrograman jenius dan meta/macro. Tapi saya katakan tidak. Scheme dapat membuat banyak hal menarik jika lingkungan pemrograman yang lebih baik disediakan. Dan sekarang Anda dapat [**MULAI DI SINI**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Paket ini adalah implementasi protokol server bahasa yang membantu pemrograman scheme. Paket ini menyediakan fitur completion, definition, dan type inference. Fitur-fitur ini didasarkan pada analisis kode statis dengan [standar r6rs](http://www.r6rs.org/) dan beberapa aturan jelas untuk kode yang belum selesai. Paket ini sendiri dan pustaka terkait telah atau akan dipublikasikan dengan [Akku](https://akkuscm.org/), yang merupakan package manager untuk Scheme.

Paket ini juga telah diuji dengan [Chez Scheme](https://cisco.github.io/ChezScheme/) versi 9.4 dan 9.5. Pengujian lebih detail pada versi 10.0.0 akan dilakukan setelah saya memperbarui OS laptop ke versi yang lebih baru.

Saya melakukan pekerjaan open source ini hanya di waktu luang dan saya dapat memberikan banyak ide cemerlang ke komunitas seperti embedding data flow analysis ke dalam scheme-langserver atau banyak hal lain. Dan saya terus meminta donasi atau pendanaan yang lebih banyak. Anda dapat berdonasi melalui [halaman patreon ini](https://www.patreon.com/PoorProgrammer/membership) atau [爱发电](https://afdian.com/a/ufo5260987423).


## Kompilasi, Instalasi & Konfigurasi ada [DI SINI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Status Terkini
Saya akan terus memperbaiki bug, profiling kode, dan mengumpulkan informasi untuk buku besar saya tentang homemade type inference system. Ini akan memakan waktu sekitar 1 tahun. Pengembangan selanjutnya termasuk plugin [VScode](https://code.visualstudio.com/) dan data flow analysis. Tapi sebenarnya, sekarang saya menjadikan pekerjaan open source ini sebagai pekerjaan paruh waktu, dan saya tidak bisa menjamin jadwal.

## Rilis
1.2.9 Sekarang, nikmati type inference!

Rilis sebelumnya silakan lihat [file ini](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Fitur
1. Penyelesaian binding pengenal tingkat atas dan lokal.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Goto definition.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Kompatibel dengan package manager: Akku.
4. Sinkronisasi perubahan file dan perubahan indeks terkait.
5. Hover.
6. Referensi dan highlight dokumen (referensi dalam lingkup dokumen).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Simbol dokumen.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Menangkap binding pengenal lokal berbasis *-syntax (define-syntax, let-syntax, dll.).
9. Pengindeksan paralel lintas platform.
10. Annotator kode sumber buatan sendiri agar kompatibel dengan file .sps.
11. Optimasi peephole untuk permintaan API dengan tugas yang dapat ditangguhkan.
12. Type inference dengan interpreter DSL buatan sendiri (Saya sangat bangga dengan ini!). Dan sekarang sudah tertanam dalam fitur auto-completion. Seperti yang ditunjukkan pada gambar berikut, "length-b" dan "length-a" yang memiliki tipe "integer?" berada di depan opsi yang direkomendasikan karena dapat memenuhi tipe parameter yang dibutuhkan dari "<=". 
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Sebuah pengujian dapat membuktikan hasil ini, cukup jalankan `scheme --script tests/protocol/apis/test-completion.sps` dan file log `scheme-langserver.log` akan berisi hasil seperti ini:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Interpreter abstrak untuk menangkap pengenal di berbagai ekstensi file seperti scm, ss, sps, sls, dan sld.

### TODOs
14. Renaming.
15. Sepenuhnya kompatibel dengan [standar r6rs](http://www.r6rs.org/).
16. Step-by-step macro expander: sebenarnya saya sudah mengimplementasikan satu dan ingin menjadikannya langkah utama untuk menangkap binding identifier dalam macro buatan sendiri. Sekarang, saya menemukan bahwa penangkapan ini jauh lebih sulit dari yang saya kira, dan expander-nya saya tidak tahu akan bekerja di mana.
17. Code eval.
18. Code diagnostic.
19. Menambahkan dukungan semantik lintas bahasa. Apakah java, c, python dan banyak bahasa lain bisa didukung dengan transformer AST?
20. Mengekstrak ekspresi/statemen menjadi sebuah prosedur.

## TODO:Kontribusi

## Debug

### Cara Debug
https://www.scheme.com/debug/debug.html#g1

### Output Log
Mengikuti tips dari [Building](#building), [Installation for Lunar Vim](#installation-for-lunarvim) dan [Installation for VScode](#todo-installation-for-vscode), jika ada yang ingin melakukan pengembangan dan mencatat sesuatu, akan lebih mudah dengan menambahkan `path-to-log-file` dan menulis ulang file `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` seperti berikut:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, sebuah implementasi protokol server bahasa untuk scheme
]]   ,
  },
}
```
### Berulang dengan Log 
Dengan [log keluaran](#output-log) di atas, Anda dapat menggunakan `tests/log-debug.sps` untuk mengulang bug:
1. Ganti nama `{path-to-log}` (biasanya `~/scheme-langserver.log`) menjadi `~/ready-for-analyse.log`;
2. jalankan `scheme --script tests/log-debug.sps`. Jika Anda ingin mereproduksi lingkungan multi-thread, Anda juga dapat menjalankan `scheme --script tests/log-debug.sps`.

## Uji Coba
Hampir semua prosedur kunci dan API telah diuji. Pekerjaan saya memang masih kasar namun berguna, mungkin Anda ingin melihat apa yang telah saya lakukan di direktori `tests` atau cukup jalankan perintah berikut di `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>CATATAN
Sulit melakukan pengujian dengan lingkungan multi-thread. Jadi, pengujian saat ini fokus pada single thread.

## Menggunakan Scheme-langserver untuk Tujuan Lain
### Script-Fu di GIMP
Script-Fu berbasis pada bahasa interpretasi bernama Scheme, dan bekerja dengan menggunakan fungsi-fungsi yang berinteraksi dengan fungsi internal GIMP. Mengambil skrip dari [halaman ini](https://dalelane.co.uk/blog/?p=628) sebagai contoh, Anda dapat menerapkan scheme-langserver pada file skrip dengan ekstensi "SCM".

### Lain-lain

Saya juga tertarik dengan [OMN (Opusmodus Notation)](https://opusmodus.com/) dan AutoLisp. Tapi masih banyak hal yang harus saya kerjakan.

## Penghitungan Kode
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Dokumen Detail
1. [Scheme-langserver: Menganggap Pengeditan Kode Scheme sebagai Prioritas Utama](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Menangkap binding identifier](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Sinkronisasi](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Inferensi tipe](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Kadaluarsa, dan saya sedang menulis buku berbahasa Mandarin untuk itu)
5. [Analisis API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Riwayat Bintang

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Kontributor

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---