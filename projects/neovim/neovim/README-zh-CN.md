<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">文档</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">聊天</a>
</h1>

[![Coverity Scan analysis](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Packages](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Downloads](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim 是一个旨在对 [Vim](https://www.vim.org/) 进行激进重构的项目，目标包括：

- 简化维护，鼓励[贡献](CONTRIBUTING.md)
- 实现多开发者协作分工
- 支持[高级 UI]，无需修改核心
- 最大化[可扩展性](https://neovim.io/doc/user/ui.html)

更多信息请参阅 [简介](https://github.com/neovim/neovim/wiki/Introduction) 维基页面和[路线图]。

功能特性
--------

- 现代化的 [GUI](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- 支持包括 C/C++、C#、Clojure、D、Elixir、Go、Haskell、Java/Kotlin、JavaScript/Node.js、Julia、Lisp、Lua、Perl、Python、Racket、Ruby、Rust 等几乎所有语言的 [API 访问](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
- 内嵌可脚本化的 [终端模拟器](https://neovim.io/doc/user/terminal.html)
- 异步 [作业控制](https://github.com/neovim/neovim/pull/2247)
- 多个编辑器实例间的 [共享数据（shada）](https://github.com/neovim/neovim/pull/2506)
- 支持 [XDG 基础目录](https://github.com/neovim/neovim/pull/3470)
- 兼容绝大多数 Vim 插件，包括 Ruby 和 Python 插件

查看 [`:help nvim-features`][nvim-features] 获取全部功能列表，或查看 [`:help news`][nvim-news] 了解最新版本的重要变更！

包管理器安装
--------------------

Windows、macOS 和 Linux 的预编译包可在
[Releases](https://github.com/neovim/neovim/releases/) 页面找到。

[受管包] 可在 [Homebrew]、[Debian]、[Ubuntu]、[Fedora]、[Arch Linux]、[Void Linux]、[Gentoo] 等发行版中获取！

源码安装
-------------------

详细信息请参见 [BUILD.md](./BUILD.md) 以及 [支持的平台](https://neovim.io/doc/user/support.html#supported-platforms)。

构建基于 CMake，同时提供了 Makefile 以便使用。
在安装完依赖后，运行以下命令：

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

如需安装到非默认目录：

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/full/path/
    make install

CMake 构建检查提示：

- `cmake --build build --target help` 列出所有构建目标。
- `build/CMakeCache.txt`（或 `cmake -LAH build/`）包含所有 CMake 变量的解析值。
- `build/compile_commands.json` 显示每个翻译单元的完整编译器调用。

从 Vim 迁移
--------------------

参见 [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) 获取迁移说明。

项目结构
--------------

    ├─ cmake/           CMake 工具
    ├─ cmake.config/    CMake 定义
    ├─ cmake.deps/      用于获取和构建依赖的子项目（可选）
    ├─ runtime/         插件和文档
    ├─ src/nvim/        应用程序源代码（详见 src/nvim/README.md）
    │  ├─ api/          API 子系统
    │  ├─ eval/         Vimscript 子系统
    │  ├─ event/        事件循环子系统
    │  ├─ generators/   代码生成（预编译）
    │  ├─ lib/          通用数据结构
    │  ├─ lua/          Lua 子系统
    │  ├─ msgpack_rpc/  RPC 子系统
    │  ├─ os/           底层平台代码
    │  └─ tui/          内置 UI
    └─ test/            测试（详见 test/README.md）

许可证
-------

自 [b17d96][license-commit] 以来的 Neovim 贡献均遵循 Apache 2.0 许可证，源自 Vim 的贡献（以 `vim-patch` 标记）除外。详细信息请参见 LICENSE。

    Vim 是慈善软件。你可以随意使用和复制，但我们鼓励你为乌干达的贫困儿童捐款。
    详见 Vim 文档中的 kcc 部分，或访问 ICCF 网站，网址如下：

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    你也可以赞助 Vim 的开发。Vim 赞助者可以为新特性投票。资金最终都会捐给乌干达。

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