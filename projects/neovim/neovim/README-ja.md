<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">ドキュメント</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">チャット</a>
</h1>

[![Coverity Scan analysis](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Packages](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Downloads](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovimは、[Vim](https://www.vim.org/)を積極的にリファクタリングすることを目的としたプロジェクトです。主な目的は以下の通りです。

- メンテナンスの簡素化と[コントリビューション](CONTRIBUTING.md)の促進
- 複数の開発者による作業分担
- コアの変更なしで[高度なUI]を実現
- [拡張性](https://neovim.io/doc/user/ui.html)の最大化

詳細は[はじめに](https://github.com/neovim/neovim/wiki/Introduction)のWikiページや[ロードマップ]をご覧ください。

特徴
--------

- モダンな[GUI](https://github.com/neovim/neovim/wiki/Related-projects#gui)対応
- C/C++、C#、Clojure、D、Elixir、Go、Haskell、Java/Kotlin、JavaScript/Node.js、Julia、Lisp、Lua、Perl、Python、Racket、Ruby、Rustなど、あらゆる言語からの[APIアクセス](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
- 組み込み・スクリプト可能な[ターミナルエミュレータ](https://neovim.io/doc/user/terminal.html)
- 非同期[ジョブ制御](https://github.com/neovim/neovim/pull/2247)
- 複数エディタ間での[共有データ (shada)](https://github.com/neovim/neovim/pull/2506)
- [XDGベースディレクトリ](https://github.com/neovim/neovim/pull/3470)のサポート
- RubyやPythonプラグインを含む、ほとんどのVimプラグインと互換性あり

全機能の一覧は [`:help nvim-features`][nvim-features]、最新バージョンの注目すべき変更は [`:help news`][nvim-news] をご参照ください。

パッケージからのインストール
--------------------

Windows、macOS、Linux用のビルド済みパッケージは[リリースページ](https://github.com/neovim/neovim/releases/)にあります。

[Homebrew]、[Debian]、[Ubuntu]、[Fedora]、[Arch Linux]、[Void Linux]、[Gentoo]など、多くのディストリビューションで[管理パッケージ]が利用できます。

ソースからのインストール
-------------------

詳細は[BUILD.md](./BUILD.md)および[サポートされているプラットフォーム](https://neovim.io/doc/user/support.html#supported-platforms)をご覧ください。

ビルドはCMakeベースですが、利便性のためMakefileも提供されています。
依存関係をインストールした後、以下のコマンドを実行してください。

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

デフォルト以外の場所にインストールする場合：

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/full/path/
    make install

ビルドの確認に役立つCMakeヒント：

- `cmake --build build --target help` で全ビルドターゲットをリスト表示
- `build/CMakeCache.txt` または `cmake -LAH build/` で全CMake変数の解決値を確認
- `build/compile_commands.json` で各トランスレーションユニットに対するコンパイラの実行内容を確認

Vimからの移行
--------------------

手順については [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) をご覧ください。

プロジェクト構成
--------------

    ├─ cmake/           CMakeユーティリティ
    ├─ cmake.config/    CMake定義
    ├─ cmake.deps/      依存関係取得・ビルド用サブプロジェクト（オプション）
    ├─ runtime/         プラグインおよびドキュメント
    ├─ src/nvim/        アプリケーションソースコード（src/nvim/README.md参照）
    │  ├─ api/          APIサブシステム
    │  ├─ eval/         Vimscriptサブシステム
    │  ├─ event/        イベントループサブシステム
    │  ├─ generators/   コード生成（プリコンパイル用）
    │  ├─ lib/          汎用データ構造
    │  ├─ lua/          Luaサブシステム
    │  ├─ msgpack_rpc/  RPCサブシステム
    │  ├─ os/           低レベルプラットフォームコード
    │  └─ tui/          組み込みUI
    └─ test/            テスト（test/README.md参照）

ライセンス
-------

[b17d96][license-commit]以降のNeovimのコントリビューションは、Apache 2.0ライセンスの下で提供されていますが、Vimからコピーされたコントリビューション（`vim-patch`トークンで識別）を除きます。詳細はLICENSEをご覧ください。

    Vimはチャリティウェアです。ご自由にご利用・コピーいただけますが、ウガンダの恵まれない子供たちのために寄付をすることを推奨します。vimドキュメントのkccセクション、またはICCFウェブサイトをご参照ください:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    また、Vimの開発支援も可能です。Vimスポンサーは機能追加の投票ができます。寄付金はすべてウガンダに送られます。

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