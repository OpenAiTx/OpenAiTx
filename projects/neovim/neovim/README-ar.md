<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">التوثيق</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">الدردشة</a>
</h1>

[![تحليل Coverity Scan](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![الحزم](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![التنزيلات](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim هو مشروع يهدف إلى إعادة هيكلة [Vim](https://www.vim.org/) بشكل جذري من أجل:

- تبسيط الصيانة وتشجيع [المساهمات](CONTRIBUTING.md)
- توزيع العمل بين عدة مطورين
- تمكين [واجهات المستخدم المتقدمة] دون تعديلات على النواة
- تعظيم [قابلية التوسعة](https://neovim.io/doc/user/ui.html)

راجع صفحة [المقدمة](https://github.com/neovim/neovim/wiki/Introduction) في الويكي و[خارطة الطريق]
لمزيد من المعلومات.

الميزات
--------

- [واجهات مستخدم رسومية حديثة](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- [الوصول إلى واجهة برمجة التطبيقات](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  من أي لغة بما في ذلك C/C++، C#، Clojure، D، Elixir، Go، Haskell، Java/Kotlin،
  JavaScript/Node.js، Julia، Lisp، Lua، Perl، Python، Racket، Ruby، Rust
- [محاكي طرفية](https://neovim.io/doc/user/terminal.html) مدمج وقابل للبرمجة النصية
- [التحكم في المهام غير المتزامن](https://github.com/neovim/neovim/pull/2247)
- [مشاركة البيانات (shada)](https://github.com/neovim/neovim/pull/2506) بين عدة نسخ من المحرر
- دعم [أدلة XDG الأساسية](https://github.com/neovim/neovim/pull/3470)
- متوافق مع أغلب إضافات Vim، بما في ذلك إضافات Ruby وPython

راجع [`:help nvim-features`][nvim-features] للقائمة الكاملة، و [`:help news`][nvim-news] لأهم التغييرات في آخر إصدار!

التثبيت من الحزمة
--------------------

الحزم الجاهزة لأنظمة Windows وmacOS وLinux متوفرة في صفحة
[الإصدارات](https://github.com/neovim/neovim/releases/).

[الحزم المُدارة] متوفرة في [Homebrew]، [Debian]، [Ubuntu]، [Fedora]، [Arch Linux]، [Void Linux]، [Gentoo]، وأكثر!

التثبيت من المصدر
-------------------

راجع [BUILD.md](./BUILD.md) و[المنصات المدعومة](https://neovim.io/doc/user/support.html#supported-platforms) للمزيد من التفاصيل.

البناء يعتمد على CMake، ولكن يوجد ملف Makefile لسهولة الاستخدام.
بعد تثبيت المتطلبات، نفّذ الأمر التالي.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

لتثبيت البرنامج في مسار غير افتراضي:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/full/path/
    make install

تلميحات CMake لفحص البناء:

- `cmake --build build --target help` يعرض جميع أهداف البناء.
- ملف `build/CMakeCache.txt` (أو `cmake -LAH build/`) يحتوي على القيم النهائية لجميع متغيرات CMake.
- ملف `build/compile_commands.json` يعرض أوامر المترجم الكاملة لكل وحدة ترجمة.

الانتقال من Vim
--------------------

راجع [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) للتعليمات.

هيكلية المشروع
--------------

    ├─ cmake/           أدوات CMake
    ├─ cmake.config/    تعريفات CMake
    ├─ cmake.deps/      مشروع فرعي لجلب وبناء التبعيات (اختياري)
    ├─ runtime/         الإضافات والوثائق
    ├─ src/nvim/        كود مصدر التطبيق (انظر src/nvim/README.md)
    │  ├─ api/          نظام واجهة برمجة التطبيقات
    │  ├─ eval/         نظام Vimscript
    │  ├─ event/        نظام حلقة الأحداث
    │  ├─ generators/   توليد الكود (قبل الترجمة)
    │  ├─ lib/          هياكل بيانات عامة
    │  ├─ lua/          نظام Lua
    │  ├─ msgpack_rpc/  نظام RPC
    │  ├─ os/           كود النظام الأساسي منخفض المستوى
    │  └─ tui/          واجهة المستخدم المدمجة
    └─ test/            الاختبارات (انظر test/README.md)

الرخصة
-------

مساهمات Neovim منذ [b17d96][license-commit] مرخصة بموجب رخصة Apache 2.0، باستثناء المساهمات المنسوخة من Vim (والمحددة بكلمة `vim-patch`). راجع LICENSE للتفاصيل.

    Vim هو برنامج خيري. يمكنك استخدامه ونسخه كما تشاء، لكن يُنصح بالتبرع للأطفال المحتاجين في أوغندا. يرجى مراجعة قسم kcc في وثائق Vim أو زيارة موقع ICCF على الروابط التالية:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    يمكنك أيضاً رعاية تطوير Vim. يمكن للرعاة التصويت على الميزات. الأموال تذهب إلى أوغندا على أي حال.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[واجهات المستخدم المتقدمة]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[الحزم المُدارة]: ./INSTALL.md#install-from-package
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