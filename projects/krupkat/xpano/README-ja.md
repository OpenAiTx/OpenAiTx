[![tests](https://github.com/krupkat/xpano/actions/workflows/test.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/test.yml)
[![clang-format](https://github.com/krupkat/xpano/actions/workflows/clang-format-check.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/clang-format-check.yml)
[![clang-tidy](https://github.com/krupkat/xpano/actions/workflows/clang-tidy-check.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/clang-tidy-check.yml)

# xpano

Xpanoは、シンプルさと使いやすさに焦点を当てたパノラマ合成ツールで、主な機能は以下の通りです：

- パノラマに合成可能な画像グループの自動検出
- 計算されたパノラマのプレビュー＋ズーム＋パン
- トリミングモード、境界の自動塗りつぶし、選択可能な投影タイプ
- 投影調整：ピッチ、ヨー、ロール
- EXIFメタデータを含むフル解像度パノラマのエクスポート


## 使用技術

このアプリは、画像操作に優れた[OpenCV](https://opencv.org/)ライブラリと、パノラマ計算用の[stitching](https://docs.opencv.org/4.x/d1/d46/group__stitching.html)モジュールを使用しています。

その他の依存関係には、[imgui](https://github.com/ocornut/imgui)、[SDL](https://github.com/libsdl-org/SDL)、[spdlog](https://github.com/gabime/spdlog/)、[Catch2](https://github.com/catchorg/Catch2)、[nativefiledialog-extended](https://github.com/btzy/nativefiledialog-extended)、[alpaca](https://github.com/p-ranav/alpaca)、[thread-pool](https://github.com/bshoshany/thread-pool)、[expected](https://github.com/TartanLlama/expected)、[Exiv2](https://github.com/Exiv2/exiv2)、[multiblend](https://horman.net/multiblend/)、[SIMDe](https://github.com/simd-everywhere/simde)、および[Google Noto](https://fonts.google.com/noto)フォントが含まれます。

## デモ

[YouTube](https://youtu.be/MyiTC3i1hK0)のデモをご覧ください。

![Main Xpano gui](https://gist.githubusercontent.com/krupkat/55ca0f085c944fb1ea2a7dc2a779f141/raw/f90afd675b1c0430db06a46984cbe5309908ddc1/1.webp)

## インストール

FlathubまたはMicrosoft Storeから直接インストール可能です：

<a href='https://flathub.org/apps/details/cz.krupkat.Xpano'><img height='70' alt='Download from Flathub' src='https://flathub.org/assets/badges/flathub-badge-en.png'/></a>&nbsp;&nbsp;<a href='https://apps.microsoft.com/store/detail/9PGQ5X33L0SC?launch=true&mode=full'><img height='70' alt='Download from the Microsoft Store' src='https://get.microsoft.com/images/en-US%20dark.svg'/></a>

追加パッケージの入手先：

- WindowsおよびMacOS用実行ファイル：[GitHub](https://github.com/krupkat/xpano/releases)
- Ubuntu用パッケージ：私の[Launchpad PPA](https://launchpad.net/~krupkat/+archive/ubuntu/code)
- Nixパッケージ：[nixpkgs](https://search.nixos.org/packages?channel=unstable&show=xpano)
- Archlinux AUR：[xpano-git](https://aur.archlinux.org/packages/xpano-git)

## コマンドライン

Xpano は基本的な CLI サポートを備えており、コマンドラインで完全自動実行するか、`--gui` フラグを使って GUI を起動することができます。

```
Xpano [<input files>] [--output=<path>] [--gui] [--help] [--version]
```

## 開発

プロジェクトは `misc/build` ディレクトリの単一スクリプトを実行することでビルドできます。CMake 3.21以上、git、およびC++20対応のコンパイラが必要です。

### NixOS

リポジトリのルートからビルドスクリプトを実行してください：

```
nix-shell misc/build/nix/default.nix
./misc/build/build-nixos.sh
```

実行時の可能な問題 - [トラブルシューティング](https://gist.github.com/krupkat/cd0adbd584e2bfe154accdb393076fc3)。

### MacOS

ライブラリの前提条件: SDL2, spdlog, catch2

brewでインストール: `brew install sdl2 spdlog catch2`

macportsでインストール: `sudo port install libsdl2 spdlog catch2` （詳細は: [#96](https://github.com/krupkat/xpano/pull/96#issuecomment-1575589249)）

リポジトリのルートからビルドスクリプトを実行してください：

```
./misc/build/build-macos.sh
```

### Ubuntu 24.04

ライブラリの前提条件:

```
sudo apt install libgtk-3-dev libopencv-dev libsdl2-dev libspdlog-dev catch2
```

リポジトリのルートからビルドスクリプトを実行します：

```
./misc/build/build-ubuntu-24.sh
```

### Ubuntu 22.04

ライブラリの前提条件:

```
sudo apt install libgtk-3-dev libopencv-dev libsdl2-dev libspdlog-dev
```

リポジトリのルートからビルドスクリプトを実行します:

```
./misc/build/build-ubuntu-22.sh
```

### Windows

Windows Terminalで「Developer PowerShell for VS 2022」プロファイルを開き、リポジトリのルートからビルドスクリプトを実行します：

```
./misc/build/build-windows-latest.ps1
```

## 貢献

貢献は大歓迎です。[オープンイシュー](https://github.com/krupkat/xpano/issues)にはいくつかの拡張案があり、取り組むことができます - もしそのうちの一つに着手する場合は、そちらにコメントを追加してください。

フォーマットやコーディングスタイルに関する詳細は、[貢献ガイドライン](https://github.com/krupkat/xpano/blob/main/CONTRIBUTING.md)をご確認ください。

## ライセンス

*GPL-3.0-or-later* ライセンスのもとで配布されています。詳しくは完全な[ライセンス文](https://github.com/krupkat/xpano/blob/main/LICENSE)をご覧ください。

## 連絡先

トマス・クルプカ - [krupkat.cz](https://krupkat.cz)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-10

---