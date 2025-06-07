<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">Dokümantasyon</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">Sohbet</a>
</h1>

[![Coverity Scan analizi](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Paketler](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![İndirmeler](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim, [Vim](https://www.vim.org/)'i agresif bir şekilde yeniden yapılandırmayı amaçlayan bir projedir:

- Bakımı basitleştirmek ve [katkıları](CONTRIBUTING.md) teşvik etmek
- Çalışmayı birden fazla geliştiriciye bölmek
- Çekirdekte değişiklik yapmadan [gelişmiş UI'leri] etkinleştirmek
- [Genişletilebilirliği](https://neovim.io/doc/user/ui.html) maksimize etmek

Daha fazla bilgi için [Giriş](https://github.com/neovim/neovim/wiki/Introduction) wiki sayfasına ve [Yol Haritası]'na bakınız.

Özellikler
----------

- Modern [GUI'ler](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust dahil herhangi bir dilden [API erişimi](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
- Gömülü, betiklenebilir [terminal emülatörü](https://neovim.io/doc/user/terminal.html)
- Asenkron [iş kontrolü](https://github.com/neovim/neovim/pull/2247)
- Birden fazla düzenleyici örneği arasında [paylaşılan veri (shada)](https://github.com/neovim/neovim/pull/2506)
- [XDG temel dizinleri](https://github.com/neovim/neovim/pull/3470) desteği
- Ruby ve Python eklentileri dahil çoğu Vim eklentisiyle uyumlu

Tam liste için [`:help nvim-features`][nvim-features] ve son sürümdeki önemli değişiklikler için [`:help news`][nvim-news]'a bakınız!

Paketle kurulum
---------------

Windows, macOS ve Linux için önceden derlenmiş paketler
[Releases](https://github.com/neovim/neovim/releases/) sayfasında bulunabilir.

[Yönetilen paketler], [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo] ve daha fazlasında mevcuttur!

Kaynaktan kurulum
-----------------

Ayrıntılar için [BUILD.md](./BUILD.md) ve [desteklenen platformlar](https://neovim.io/doc/user/support.html#supported-platforms)'a bakınız.

Derleme CMake tabanlıdır, ancak kolaylık olması için bir Makefile da sağlanmıştır.
Bağımlılıkları yükledikten sonra aşağıdaki komutu çalıştırın.

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

Varsayılan olmayan bir konuma kurmak için:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/full/path/
    make install

Derlemeyi incelemek için CMake ipuçları:

- `cmake --build build --target help` tüm derleme hedeflerini listeler.
- `build/CMakeCache.txt` (veya `cmake -LAH build/`) tüm CMake değişkenlerinin çözümlenmiş değerlerini içerir.
- `build/compile_commands.json` her çeviri birimi için tam derleyici çağrılarını gösterir.

Vim'den geçiş
-------------

Talimatlar için [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim)'e bakınız.

Proje dizin yapısı
------------------

    ├─ cmake/           CMake araçları
    ├─ cmake.config/    CMake tanımları
    ├─ cmake.deps/      bağımlılıkları almak ve derlemek için alt proje (isteğe bağlı)
    ├─ runtime/         eklentiler ve dokümantasyon
    ├─ src/nvim/        uygulama kaynak kodu (bkz. src/nvim/README.md)
    │  ├─ api/          API alt sistemi
    │  ├─ eval/         Vimscript alt sistemi
    │  ├─ event/        olay döngüsü alt sistemi
    │  ├─ generators/   kod üretimi (ön derleme)
    │  ├─ lib/          genel veri yapıları
    │  ├─ lua/          Lua alt sistemi
    │  ├─ msgpack_rpc/  RPC alt sistemi
    │  ├─ os/           düşük seviye platform kodu
    │  └─ tui/          yerleşik UI
    └─ test/            testler (bkz. test/README.md)

Lisans
------

[b17d96][license-commit]'dan sonraki Neovim katkıları,
Apache 2.0 lisansı altındadır, Vim'den kopyalanan katkılar hariçtir
(`vim-patch` etiketiyle belirtilir). Ayrıntılar için LICENSE dosyasına bakınız.

    Vim Charityware'dir.  İstediğiniz kadar kullanabilir ve kopyalayabilirsiniz, ancak
    Uganda'daki muhtaç çocuklar için bağış yapmanız teşvik edilir.  Lütfen vim dokümanlarının
    kcc bölümüne bakın veya aşağıdaki URL'lerden ICCF web sitesini ziyaret edin:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    Ayrıca Vim'in geliştirilmesini de destekleyebilirsiniz.  Vim sponsorları
    özellikler için oy kullanabilirler.  Paranın tamamı yine Uganda'ya gider.

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