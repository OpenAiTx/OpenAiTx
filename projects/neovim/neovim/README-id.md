<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">Dokumentasi</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">Obrolan</a>
</h1>

[![Analisis Coverity Scan](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Paket](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Unduhan](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim adalah proyek yang bertujuan untuk secara agresif merefaktor [Vim](https://www.vim.org/) dengan tujuan:

- Menyederhanakan pemeliharaan dan mendorong [kontribusi](CONTRIBUTING.md)
- Membagi pekerjaan di antara beberapa pengembang
- Mengaktifkan [UI tingkat lanjut] tanpa modifikasi pada inti
- Memaksimalkan [ekstensibilitas](https://neovim.io/doc/user/ui.html)

Lihat halaman wiki [Pengantar](https://github.com/neovim/neovim/wiki/Introduction) dan [Peta Jalan]
untuk informasi lebih lanjut.

Fitur
-----

- [GUI](https://github.com/neovim/neovim/wiki/Related-projects#gui) modern
- [Akses API](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  dari bahasa apapun termasuk C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- [Terminal emulator](https://neovim.io/doc/user/terminal.html) tertanam dan dapat diskrip
- [Kontrol pekerjaan asinkron](https://github.com/neovim/neovim/pull/2247)
- [Data bersama (shada)](https://github.com/neovim/neovim/pull/2506) di antara beberapa instance editor
- Dukungan [direktori dasar XDG](https://github.com/neovim/neovim/pull/3470)
- Kompatibel dengan sebagian besar plugin Vim, termasuk plugin Ruby dan Python

Lihat [`:help nvim-features`][nvim-features] untuk daftar lengkap, dan [`:help news`][nvim-news] untuk perubahan penting di versi terbaru!

Instal dari paket
-----------------

Paket siap pakai untuk Windows, macOS, dan Linux tersedia di halaman
[Rilis](https://github.com/neovim/neovim/releases/).

[Paket terkelola] tersedia di [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo], dan lainnya!

Instal dari sumber
------------------

Lihat [BUILD.md](./BUILD.md) dan [platform yang didukung](https://neovim.io/doc/user/support.html#supported-platforms) untuk detailnya.

Proses build berbasis CMake, tetapi Makefile disediakan untuk kemudahan.
Setelah menginstal dependensi, jalankan perintah berikut.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

Untuk menginstal ke lokasi non-standar:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/full/path/
    make install

Tips CMake untuk memeriksa build:

- `cmake --build build --target help` menampilkan semua target build.
- `build/CMakeCache.txt` (atau `cmake -LAH build/`) berisi nilai akhir dari semua variabel CMake.
- `build/compile_commands.json` menampilkan pemanggilan kompiler lengkap untuk setiap unit translasi.

Transisi dari Vim
-----------------

Lihat [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) untuk instruksi.

Tata letak proyek
-----------------

    ├─ cmake/           Utilitas CMake
    ├─ cmake.config/    Definisi CMake
    ├─ cmake.deps/      subproyek untuk mengambil dan membangun dependensi (opsional)
    ├─ runtime/         plugin dan dokumentasi
    ├─ src/nvim/        kode sumber aplikasi (lihat src/nvim/README.md)
    │  ├─ api/          subsistem API
    │  ├─ eval/         subsistem Vimscript
    │  ├─ event/        subsistem event-loop
    │  ├─ generators/   pembuatan kode (pra-kompilasi)
    │  ├─ lib/          struktur data umum
    │  ├─ lua/          subsistem Lua
    │  ├─ msgpack_rpc/  subsistem RPC
    │  ├─ os/           kode platform tingkat rendah
    │  └─ tui/          UI bawaan
    └─ test/            pengujian (lihat test/README.md)

Lisensi
-------

Kontribusi Neovim sejak [b17d96][license-commit] dilisensikan di bawah
lisensi Apache 2.0, kecuali kontribusi yang disalin dari Vim (diidentifikasi dengan token
`vim-patch`). Lihat LICENSE untuk detailnya.

    Vim adalah Charityware.  Anda dapat menggunakannya dan menyalinnya sebanyak yang Anda suka, namun Anda
    dianjurkan untuk berdonasi untuk anak-anak yang membutuhkan di Uganda.  Silakan lihat bagian
    kcc pada dokumentasi vim atau kunjungi situs web ICCF, tersedia di URL berikut:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    Anda juga dapat mensponsori pengembangan Vim.  Sponsor Vim dapat memilih fitur.
    Uangnya tetap akan diberikan ke Uganda.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[advanced UIs]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[Managed packages]: ./INSTALL.md#install-from-package
[Debian]: https://packages.debian.org/testing/neovim
[Ubuntu]: https://packages.ubuntu.com/search?keywords=neovim
[Fedora]: https://packages.fedoraproject.org/pkgs/neovim/neovim/
[Arch Linux]: https://www.archlinux.org/packages/?q=neovim
[Void Linux]: https://voidlinux.org/packages/?arch=x86_64&q=neovim
[Gentoo]: https://packages.gentoo.org/packages/app-editors/neovim
[Homebrew]: https://formulae.brew.sh/formula/neovim

<!-- vim: set tw=80: -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---