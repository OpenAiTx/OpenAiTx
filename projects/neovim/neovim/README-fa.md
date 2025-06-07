<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">مستندات</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">گفت‌وگو</a>
</h1>

[![تجزیه و تحلیل Coverity Scan](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![بسته‌ها](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![دانلودها](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim پروژه‌ای است که با هدف بازسازی تهاجمی [Vim](https://www.vim.org/) به منظور:

- ساده‌سازی نگهداری و تشویق به [مشارکت](CONTRIBUTING.md)
- تقسیم کار بین توسعه‌دهندگان متعدد
- فعال‌سازی [رابط‌های کاربری پیشرفته] بدون تغییر در هسته
- بیشینه‌سازی [قابلیت توسعه](https://neovim.io/doc/user/ui.html)

برای اطلاعات بیشتر به صفحه [معرفی](https://github.com/neovim/neovim/wiki/Introduction) و [نقشه راه] مراجعه کنید.

ویژگی‌ها
--------

- [رابط‌های گرافیکی مدرن](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- [دسترسی API](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  از هر زبانی از جمله C/C++‎، C#‎، Clojure، D، Elixir، Go، Haskell، Java/Kotlin،
  JavaScript/Node.js، Julia، Lisp، Lua، Perl، Python، Racket، Ruby، Rust
- [شبیه‌ساز ترمینال](https://neovim.io/doc/user/terminal.html) داخلی و قابل برنامه‌نویسی
- [کنترل کارهای ناهمزمان](https://github.com/neovim/neovim/pull/2247)
- [اشتراک‌گذاری داده (shada)](https://github.com/neovim/neovim/pull/2506) بین چند نمونه ویرایشگر
- پشتیبانی از [دایرکتوری‌های پایه XDG](https://github.com/neovim/neovim/pull/3470)
- سازگار با اکثر افزونه‌های Vim، از جمله افزونه‌های Ruby و Python

برای فهرست کامل، [`:help nvim-features`][nvim-features] و برای تغییرات قابل توجه نسخه جدید، [`:help news`][nvim-news] را ببینید!

نصب از بسته
--------------------

بسته‌های از پیش ساخته‌شده برای ویندوز، macOS و لینوکس در صفحه
[انتشارها](https://github.com/neovim/neovim/releases/) موجود است.

[بسته‌های مدیریت‌شده] در [Homebrew]، [دبیان]، [اوبونتو]، [فدورا]، [آرچ لینوکس]، [وید لینوکس]، [جنتو] و موارد دیگر موجود است!

نصب از سورس
-------------------

برای جزئیات به [BUILD.md](./BUILD.md) و [پلتفرم‌های پشتیبانی‌شده](https://neovim.io/doc/user/support.html#supported-platforms) مراجعه کنید.

ساخت بر پایه CMake است، اما یک فایل Makefile نیز برای راحتی ارائه شده است.
پس از نصب وابستگی‌ها، دستور زیر را اجرا کنید.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

برای نصب در مسیر دلخواه:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/full/path/
    make install

نکات CMake برای بررسی ساخت:

- `cmake --build build --target help` همه اهداف ساخت را لیست می‌کند.
- `build/CMakeCache.txt` (یا `cmake -LAH build/`) مقادیر نهایی همه متغیرهای CMake را نشان می‌دهد.
- `build/compile_commands.json` فراخوانی کامل کامپایلر برای هر واحد ترجمه را نشان می‌دهد.

انتقال از Vim
--------------------

برای راهنما [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) را ببینید.

ساختار پروژه
--------------

    ├─ cmake/           ابزارهای CMake
    ├─ cmake.config/    تعریف‌های CMake
    ├─ cmake.deps/      زیرپروژه برای دریافت و ساخت وابستگی‌ها (اختیاری)
    ├─ runtime/         افزونه‌ها و مستندات
    ├─ src/nvim/        کد منبع برنامه (به src/nvim/README.md مراجعه کنید)
    │  ├─ api/          زیرسیستم API
    │  ├─ eval/         زیرسیستم Vimscript
    │  ├─ event/        زیرسیستم حلقه رویداد
    │  ├─ generators/   تولید کد (پیش از کامپایل)
    │  ├─ lib/          ساختار داده‌های عمومی
    │  ├─ lua/          زیرسیستم Lua
    │  ├─ msgpack_rpc/  زیرسیستم RPC
    │  ├─ os/           کد سطح پایین پلتفرم
    │  └─ tui/          رابط کاربری داخلی
    └─ test/            تست‌ها (به test/README.md مراجعه کنید)

مجوز
-------

مشارکت‌های Neovim از [b17d96][license-commit] به بعد تحت مجوز Apache 2.0 هستند، به جز مواردی که از Vim کپی شده‌اند (با نشانه `vim-patch`). برای جزئیات به LICENSE مراجعه کنید.

    Vim نرم‌افزاری خیریه است.  می‌توانید تا هر اندازه که دوست دارید از آن استفاده و کپی کنید، اما توصیه می‌شود برای کودکان نیازمند در اوگاندا کمک مالی کنید. لطفاً بخش kcc از مستندات vim را ببینید یا به وب‌سایت ICCF مراجعه کنید:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    همچنین می‌توانید از توسعه Vim حمایت مالی کنید. حامیان Vim می‌توانند برای ویژگی‌ها رأی دهند. پول به هر حال به اوگاندا می‌رسد.

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