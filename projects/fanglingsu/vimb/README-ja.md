# Vimb - Vimに似たブラウザ

[![Build Status](https://travis-ci.com/fanglingsu/vimb.svg?branch=master)](https://travis-ci.com/fanglingsu/vimb)
[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![Latest Release](https://img.shields.io/github/release/fanglingsu/vimb.svg?style=flat)](https://github.com/fanglingsu/vimb/releases/latest)

VimbはPentadactylやVimprobableに触発されたVim風のウェブブラウザです。  
Vimbの目標は完全にキーボード駆動で効率的かつ  
快適なブラウジング体験を低メモリ・CPU使用率で実現し、  
Vimユーザーにとって直感的に使いやすいことです。

Vimbブラウザの動作中のスクリーンショットや詳細は、  
[Vimb][]のプロジェクトページで見ることができます。

## 特徴

- Vimのようなモーダル操作
- 各ブラウザモードごとに割り当て可能なVim風キーバインド
- ほぼすべての設定をランタイムでVimのset構文で変更可能
- `ex`コマンド、検索クエリ、URLの履歴
- コマンド、URL、ブックマークURL、設定変数名、検索クエリの補完
- ヒント機能 - リンク、フォームフィールド、その他クリック可能な要素を  
  クリック、開く、検査するためにマーク
- ca証明書ファイルによるSSL検証
- プレースホルダ付きユーザー定義URLショートカット
- 後で読むためのURIキュー
- 複数のヤンク／ペーストレジスタ
- Vim風autocmd - 特定URI上のイベント後に自動でコマンド実行

## パッケージ

- Arch Linux: [extra/vimb][], [aur/vimb-git][], [aur/vimb-gtk2][]
- Fedora: [fedora/vimb][],
- Gentoo: [tharvik overlay][], [jjakob overlay][]
- openSUSE: [network/vimb][]
- pkgsrc: [pkgsrc/www/vimb][], [pkgsrc/wip/vimb-git][]
- Slackware: [slackbuild/vimb][]

## 依存関係

- gtk+-3.0
- webkit2gtk-4.1
- gst-libav, gst-plugins-good（任意、メディアデコードなどに使用）

## インストール

ローカル環境に合わせて`config.mk`を編集してください。  
tccなど別のコンパイラを使う場合は必要になるかもしれません。  
ただし、UbuntuやDebianのようなシステムではほとんど必要ありません。

読み込みバーの文字やフォントを変えたい場合は、  
`src/config.h`を個人の好みに合わせて編集してください。

デフォルトの`Makefile`は、`config.def.h`が最新のgit pullで更新されても、  
カスタマイズ済みの`config.h`を上書きしません。  
そのため、常に`config.h`と`config.def.h`を比較し、  
`config.def.h`の変更を`config.h`に反映させるようにしてください。

以下のコマンドを実行してVimbをコンパイル・インストールします（必要に応じて最後のコマンドはrootで実行）。  
`PREFIX`を変更する場合は、ビルドとインストール両方で指定する必要があります。

    make PREFIX=/usr
    make PREFIX=/usr install

インストールせずにテスト実行したい場合は、`runsandbox`のmakeターゲットを使います。

    make runsandbox

## メーリングリスト

- 機能要望、問題報告、パッチは[メーリングリスト][mail]で議論できます（[リストアーカイブ][mail-archive]）

## 類似プロジェクト

- [luakit](https://luakit.github.io/)
- [qutebrowser](https://www.qutebrowser.org/)
- [surf](https://surf.suckless.org/)
- [uzbl](https://www.uzbl.org/)
- [wyeb](https://github.com/jun7/wyeb)

## ライセンス

ライセンス情報はLICENSEファイルに記載されています。

## 詳細情報

- https://en.wikipedia.org/wiki/Vimb
- http://thedarnedestthing.com/vimb
- https://blog.jeaye.com/2015/08/23/vimb/

[aur/vimb-git]:        https://aur.archlinux.org/packages/vimb-git
[aur/vimb-gtk2]:       https://aur.archlinux.org/packages/vimb-gtk2/
[extra/vimb]:          https://www.archlinux.org/packages/extra/x86_64/vimb/
[fedora/vimb]:         https://src.fedoraproject.org/rpms/vimb
[tharvik overlay]:     https://github.com/tharvik/overlay/tree/master/www-client/vimb
[jjakob overlay]:      https://github.com/jjakob/gentoo-overlay/tree/master/www-client/vimb
[mail-archive]:        https://sourceforge.net/p/vimb/vimb/vimb-users/ "vimb - mailing list archive"
[mail]:                https://lists.sourceforge.net/lists/listinfo/vimb-users "vimb - mailing list"


[network/vimb]:        https://build.opensuse.org/package/show/network/vimb
[pkgsrc/wip/vimb-git]: http://pkgsrc.se/wip/vimb-git
[pkgsrc/www/vimb]:     http://pkgsrc.se/www/vimb
[slackbuild/vimb]:     https://slackbuilds.org/repository/14.2/network/vimb/
[vimb]:                https://fanglingsu.github.io/vimb/ "Vimb - Vimのようなブラウザ プロジェクトページ"


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---