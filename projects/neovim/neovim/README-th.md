<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">เอกสารประกอบ</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">แชท</a>
</h1>

[![Coverity Scan analysis](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Packages](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Downloads](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim เป็นโปรเจกต์ที่มีเป้าหมายในการปรับโครงสร้าง [Vim](https://www.vim.org/) อย่างจริงจังเพื่อ:

- ลดความซับซ้อนในการดูแลรักษาและส่งเสริม [การมีส่วนร่วม](CONTRIBUTING.md)
- แบ่งงานระหว่างนักพัฒนาหลายคน
- เปิดใช้งาน [UI ขั้นสูง] โดยไม่ต้องแก้ไขแกนหลัก
- เพิ่มขีดความสามารถของ [การขยายระบบ](https://neovim.io/doc/user/ui.html) ให้สูงสุด

ดูข้อมูลเพิ่มเติมได้ที่หน้าวิกิ [บทนำ](https://github.com/neovim/neovim/wiki/Introduction) และ [Roadmap]

คุณลักษณะ
--------

- [GUI สมัยใหม่](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- [เข้าถึง API](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  จากภาษาใดก็ได้ รวมถึง C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- [เทอร์มินัลอีมูเลเตอร์](https://neovim.io/doc/user/terminal.html) ที่ฝังตัวและสคริปต์ได้
- [ควบคุมงานแบบอะซิงโครนัส](https://github.com/neovim/neovim/pull/2247)
- [แชร์ข้อมูล (shada)](https://github.com/neovim/neovim/pull/2506) ระหว่างหลายอินสแตนซ์ของโปรแกรมแก้ไข
- รองรับ [ไดเรกทอรีฐาน XDG](https://github.com/neovim/neovim/pull/3470)
- เข้ากันได้กับปลั๊กอิน Vim ส่วนใหญ่ รวมถึงปลั๊กอิน Ruby และ Python

ดู [`:help nvim-features`][nvim-features] สำหรับรายการทั้งหมด และ [`:help news`][nvim-news] สำหรับการเปลี่ยนแปลงสำคัญในเวอร์ชันล่าสุด!

ติดตั้งจากแพ็กเกจ
--------------------

แพ็กเกจที่สร้างไว้ล่วงหน้าสำหรับ Windows, macOS และ Linux สามารถหาได้จากหน้า
[Releases](https://github.com/neovim/neovim/releases/)

[แพ็กเกจที่มีการจัดการ] มีใน [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo] และอื่น ๆ!

ติดตั้งจากซอร์ส
-------------------

ดู [BUILD.md](./BUILD.md) และ [แพลตฟอร์มที่รองรับ](https://neovim.io/doc/user/support.html#supported-platforms) สำหรับรายละเอียด

การ build ใช้ CMake เป็นหลัก แต่มี Makefile ให้เพื่อความสะดวก
หลังจากติดตั้ง dependencies แล้ว ให้รันคำสั่งต่อไปนี้

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

หากต้องการติดตั้งไปยังตำแหน่งที่ไม่ใช่ค่าเริ่มต้น:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/full/path/
    make install

CMake hints สำหรับตรวจสอบการ build:

- `cmake --build build --target help` แสดงรายการเป้าหมายการ build ทั้งหมด
- `build/CMakeCache.txt` (หรือ `cmake -LAH build/`) มีค่าที่ถูก resolve ของตัวแปร CMake ทั้งหมด
- `build/compile_commands.json` แสดงคำสั่งคอมไพล์เต็มรูปแบบสำหรับแต่ละ translation unit

การเปลี่ยนผ่านจาก Vim
--------------------

ดู [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) สำหรับคำแนะนำ

โครงสร้างโปรเจกต์
--------------

    ├─ cmake/           ยูทิลิตี้ของ CMake
    ├─ cmake.config/    ตัวกำหนดค่า CMake
    ├─ cmake.deps/      ซับโปรเจกต์สำหรับดึงและ build dependencies (ไม่บังคับ)
    ├─ runtime/         ปลั๊กอินและเอกสาร
    ├─ src/nvim/        ซอร์สโค้ดแอปพลิเคชัน (ดูที่ src/nvim/README.md)
    │  ├─ api/          ระบบย่อย API
    │  ├─ eval/         ระบบย่อย Vimscript
    │  ├─ event/        ระบบย่อย event-loop
    │  ├─ generators/   การสร้างโค้ด (ก่อนคอมไพล์)
    │  ├─ lib/          โครงสร้างข้อมูลทั่วไป
    │  ├─ lua/          ระบบย่อย Lua
    │  ├─ msgpack_rpc/  ระบบย่อย RPC
    │  ├─ os/           โค้ดแพลตฟอร์มระดับต่ำ
    │  └─ tui/          UI ที่ติดตั้งมาในตัว
    └─ test/            การทดสอบ (ดูที่ test/README.md)

สัญญาอนุญาต
-------

การมีส่วนร่วมกับ Neovim ตั้งแต่ [b17d96][license-commit] เป็นต้นไป อยู่ภายใต้สัญญาอนุญาต Apache 2.0 ยกเว้นส่วนที่คัดลอกจาก Vim (ระบุด้วย token `vim-patch`) ดูรายละเอียดได้ใน LICENSE

    Vim เป็น Charityware คุณสามารถใช้งานและคัดลอกได้ตามต้องการ แต่ขอแนะนำให้บริจาคสำหรับเด็กยากจนในยูกันดา กรุณาดูที่ส่วน kcc ในเอกสาร Vim หรือเข้าเยี่ยมชมเว็บไซต์ ICCF ตาม URL เหล่านี้:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    คุณยังสามารถสนับสนุนการพัฒนา Vim ได้ ผู้สนับสนุน Vim สามารถโหวตฟีเจอร์ใหม่ ๆ เงินทั้งหมดจะถูกส่งต่อไปยังยูกันดา

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