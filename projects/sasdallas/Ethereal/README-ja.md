# Ethereal

速度、メモリ節約、および信頼性を重視して書かれたカスタムのオールインワンオペレーティングシステム。\
以前は reduceOS として知られていた

## Etherealとは？

Etherealは、モダンなOSが持つすべてのコンポーネントを備えた完全な機能を持つOSをゼロから作成することを目標としたプロジェクトです。

現在、このプロジェクトはユーザモード段階の開発を進めています。

## スクリーンショット

<img width="1925" height="1078" alt="image" src="https://github.com/user-attachments/assets/5f5725af-de16-43bf-9217-6db994f9ff2e" />\
*モダンな1080pデスクトップ環境*

<img width="1040" height="799" alt="image" src="https://github.com/user-attachments/assets/06835253-90cd-4785-a0f8-9f0042ac3676" />\
*DOOMを動かすEthereal旧メインデスクトップ環境*

![](https://preview.redd.it/ethereal-smp-enabled-usb-supporting-multitasking-kernel-v0-ygmgdlm3dowe1.png?width=1620&format=png&auto=webp&s=0473ac09024c17cefb294c8570671e415866b915)\
*デバッグモードで起動中のEthereal*

![Ethereal but REALLY on IRC](https://github.com/user-attachments/assets/fedac2c5-db99-463f-88d9-44b1a239dcdd)\
*Liberaチャット (#ethereal) 上のEthereal*

![](https://preview.redd.it/ethereal-smp-enabled-usb-supporting-multitasking-kernel-v0-ahe88a85dowe1.png?width=682&format=png&auto=webp&s=b435a1e0d57a91b7d4e0479f9649960b74a22de7)\
*DOOMを動かすEthereal*

![fixed](https://github.com/user-attachments/assets/bfdce356-5555-436b-990d-3aad65d22dea)\
*Ethereal用に作られたneofetchクローン（whatarewe）を動かすEthereal*

## 特徴

- 完全なSMP対応カーネル
- カスタムウィンドウマネージャ（Celestial）
- UHCI/EHCI/xHCIコントローラ対応のUSBサポート
- AHCI/IDE対応
- E1000およびRTL8139ネットワークカードドライバを備えたネットワークスタック
- 優先度ベースのラウンドロビンスケジューラと十分にテストされたAPI
- `mlibc` Cライブラリおよびその多彩な関数のサポート
- ACPICAライブラリによる完全なACPIサポート（AML解析を持たないバックアップのMinACPIライブラリ付き）

## プロジェクト構成

- `base`: ベースファイルシステムを含む。`base/initrd`内のファイルは初期ラムディスクに配置される（LiveCD以外の起動用）、`base/sysroot`内のファイルはsysrootに配置される。
- `buildscripts`: ビルドシステム用のビルドスクリプトを含む
- `conf`: アーキテクチャファイル、GRUB設定、追加のブートファイルなどの各種設定ファイルを含む
- `drivers`: Hexahedron用ドライバー。設定に基づいてコピーされる。
- `external`: ACPICAなどの外部プロジェクトを含む。External Componentsを参照。
- `hexahedron`: メインカーネルプロジェクト
- `libkstructures`: リスト/ハッシュマップ/パーサーなどの各種カーネル構造を含む
- `libc`: mlibcを含む

## ビルド


### ACPICAについての注意

ACPICAを使用する場合（デフォルトで有効）、[こちら](https://downloadmirror.intel.com/834974/acpica-unix-20240927.tar.gz)からtarファイルをダウンロードし、`external/acpica/acpica-src`に展開してください。

それ以外の場合は、`conf/build/<arch>.mk`を編集し、`USE_ACPICA`を0に設定してください。  

### ビルド手順

Etherealをビルドするには、ターゲットアーキテクチャ用のEtherealツールチェーンが必要です。\
Etherealツールチェーンは[リポジトリ](https://github.com/sasdallas/Ethereal-Toolchain)で入手可能です。

必要な他のパッケージ：`grub-common`、`xorriso`、`qemu-system`、`meson`、`ninja`

ターゲットビルドアーキテクチャを変更するには、`buildscripts/build-arch.sh`を編集してください。\
`make all`を実行すると、`build-output/ethereal.iso`にISOファイルが作成されます。

現状、Etherealはファイルシステムドライバーを持たないため、LiveCD起動が通常最良の選択です。\
LiveCDの初期ラムディスクはsysrootであり、OSが起動を検出すると初期ラムディスクをRAMにコピーします。

## カーネル引数

Etherealが起動に失敗することが多々あります。これは想定内です。GitHubのIssueを作成してください。

一部の問題は、GRUBの設定画面を'e'で開き、`multiboot entry`の末尾にカーネル引数を追加することで解決できます。\
ここに小さなリストがあります：

- `--debug=`: オプションは `console` と `none` です。`console` の場合、カーネルのデバッグ出力を画面にリダイレクトします。デバッグに便利です
- `--noload=`: 読み込まないドライバ（.sys）ファイルのカンマ区切りリスト。問題のあるドライバ: usb_xhci.sys、ahci.sys、ps2.sys（PS/2をサポートしない場合）
- `--no-acpica`: ACPICAライブラリを無効にし、MinACPI実装にフォールバックします。極端な場合のみ有用です。
- `--no-acpi`: すべてのACPI実装を無効にします。SMPも無効にします。
- `--disable-smp`: ACPIは有効にしますが、SMPを無効にします
- `--disable-cow`: コピーオンライトを無効にします。推奨されませんが、極端な場合に役立つことがあります。
- `--no-psf-font`: initrdからPSFフォントを読み込みません

## 外部コンポーネント
特定の外部コンポーネントは `external`、`libc`、およびカーネルの他の部分で利用可能です。以下はそれらとそのバージョンのリストです：
- ACPICA UNIX*（Intelライセンス）：バージョン20240927 [こちらから入手可能](https://www.intel.com/content/www/us/en/developer/topic-technology/open/acpica/download.html)
- libmusl数学ライブラリ（MITライセンス）：[こちらから入手可能](https://github.com/kraj/musl)
- freetype（GPLライセンス）：[こちらから入手可能](https://sourceforge.net/projects/freetype/)
- mlibc（MITライセンス）：[Etherealフォークはこちら](https://github.com/sasdallas/mlibc)
- tinf（zlibライセンス）：[こちらから入手可能](https://github.com/jibsen/tinf/)
- json-parser（BSD 2条項ライセンス）：[こちらから入手可能](https://github.com/json-parser/json-parser)
- PlutoSVG（MITライセンス）：[こちらから入手可能](https://github.com/sammycage/plutosvg)

## クレジット

Etherealの設計の多くは[klangeのToaruOS](https://github.com/klange/ToaruOS)に触発されました - ありがとうございます！

Etherealの仮想メモリマネージャ設計およびその他の部分は[@mathewndのAstral](https://github.com/mathewnd/Astral)に触発されました

Astralのコードの一部も使用されており、適切な場所でクレジットしています。ライセンスファイルは `external/` に含まれています。

Etherealのロゴとマーキュリーテーマはアーティスト[ArtsySquid](https://artsycomms.carrd.co)によってデザインされました

## ライセンス

HexahedronおよびEtherealのその他すべての非外部コンポーネントはBSD 3条項ライセンス（LICENSEに記載）に準拠します。\
著作権ヘッダーで指定されていない限り、すべてのファイルはこのライセンスに従います。著作権ヘッダーがないファイルはBSD 3条項で保護されていません。

**ライセンス問題:** ファイルに適切なコメントがない場合は、直ちに私に連絡してください（透明性のためGitHubのIssueなどの公開チャネルを通じて連絡いただくのが望ましいです）。

Etherealの目標は**決して**コードを取ることではありませんが、過去にそうしたことがありました。どうぞご連絡ください！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-23

---