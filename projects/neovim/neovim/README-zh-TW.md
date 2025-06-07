<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">文件</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">聊天室</a>
</h1>

[![Coverity Scan analysis](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Packages](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Downloads](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim 是一個致力於積極重構 [Vim](https://www.vim.org/) 的專案，目標在於：

- 簡化維護並鼓勵[貢獻](CONTRIBUTING.md)
- 分攤多位開發者之間的工作
- 支援 [進階 UI] 而無需修改核心
- 最大化 [可擴充性](https://neovim.io/doc/user/ui.html)

更多資訊請參閱 [簡介](https://github.com/neovim/neovim/wiki/Introduction) Wiki 頁面和[路線圖]。

功能特色
--------

- 現代化 [GUI](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- 提供 [API 存取](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)，支援 C/C++、C#、Clojure、D、Elixir、Go、Haskell、Java/Kotlin、JavaScript/Node.js、Julia、Lisp、Lua、Perl、Python、Racket、Ruby、Rust 等語言
- 內嵌、可腳本化的 [終端機模擬器](https://neovim.io/doc/user/terminal.html)
- 非同步 [工作控制](https://github.com/neovim/neovim/pull/2247)
- 多個編輯器實例間 [共享資料 (shada)](https://github.com/neovim/neovim/pull/2506)
- 支援 [XDG 基礎目錄](https://github.com/neovim/neovim/pull/3470)
- 相容於大多數 Vim 外掛，包括 Ruby 與 Python 外掛

完整清單請見 [`:help nvim-features`][nvim-features]，最新版本重大變更請見 [`:help news`][nvim-news]！

套件安裝
--------------------

Windows、macOS 與 Linux 的預建套件可於
[Releases](https://github.com/neovim/neovim/releases/) 頁面取得。

[受管理的套件] 已收錄於 [Homebrew]、[Debian]、[Ubuntu]、[Fedora]、[Arch Linux]、[Void Linux]、[Gentoo] 等多個發行版本！

原始碼安裝
-------------------

詳細資訊請參閱 [BUILD.md](./BUILD.md) 及[支援平台](https://neovim.io/doc/user/support.html#supported-platforms)。

建構流程以 CMake 為主，並提供 Makefile 方便使用。
安裝完相依套件後，請執行下列指令。

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

如需安裝至非預設路徑：

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/full/path/
    make install

檢查建構資訊的 CMake 小提示：

- `cmake --build build --target help` 列出所有建構目標。
- `build/CMakeCache.txt`（或 `cmake -LAH build/`）包含所有 CMake 變數的解析值。
- `build/compile_commands.json` 顯示每個翻譯單元的完整編譯指令。

從 Vim 遷移
--------------------

請參閱 [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) 取得指引。

專案結構
--------------

    ├─ cmake/           CMake 工具
    ├─ cmake.config/    CMake 定義
    ├─ cmake.deps/      下載與建構相依套件的子專案（可選）
    ├─ runtime/         外掛與文件
    ├─ src/nvim/        應用程式原始碼（詳見 src/nvim/README.md）
    │  ├─ api/          API 子系統
    │  ├─ eval/         Vimscript 子系統
    │  ├─ event/        事件迴圈子系統
    │  ├─ generators/   程式碼生成（編譯前）
    │  ├─ lib/          通用資料結構
    │  ├─ lua/          Lua 子系統
    │  ├─ msgpack_rpc/  RPC 子系統
    │  ├─ os/           低階平台程式碼
    │  └─ tui/          內建 UI
    └─ test/            測試（詳見 test/README.md）

授權條款
-------

自 [b17d96][license-commit] 之後的 Neovim 貢獻內容皆採用 Apache 2.0 授權，來自 Vim 的貢獻（以 `vim-patch` 標記者）除外。詳情請參閱 LICENSE。

    Vim 屬於慈善軟體（Charityware）。您可以自由使用及複製，但鼓勵您為烏干達貧困兒童捐款。詳情請見 vim 文件中的 kcc 部分或瀏覽 ICCF 網站，網址如下：

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    您也可以贊助 Vim 的開發。Vim 贊助者可對新功能進行投票。所有資金最終都會用於援助烏干達。

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