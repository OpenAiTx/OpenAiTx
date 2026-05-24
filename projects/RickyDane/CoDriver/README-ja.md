
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='ko-fi.comでコーヒーを買う' />
  </a>
</p>

<br/>

<p align="center">
  Rust言語を学びたいと思ったことから生まれたシンプルなファイルエクスプローラーです。
  <br>
  OSに依存せず、最適化のためにスリム化されています。
</p>

<br/><br/>

このパフォーマンスは ["jwalk"](https://crates.io/crates/jwalk/versions) と ["Tauri"](https://tauri.app/) によって実現されています。
<br/><br/>
CoDriverはファイルやフォルダへのアクセス時にパスキャッシュを使用せず、Rust、ディスクの速度、CPUの性能によってパフォーマンスを得ています。

⁉️ このソフトウェアはまだ開発途中のため、バグが含まれる場合がありますのでご注意ください！
<br/><br/>

# リンク
- <a href="#basic-features">基本機能</a>
- <a href="#advanced-features">高度な機能</a>
- <a href="#dependencies-if-not-working-instantly">依存関係</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">FTP実装（SSHFS）</a>
- <a href="#%EF%B8%8F-known-issues">既知の問題</a>
- <a href="#-todos">やることリスト</a>
- <a href="#user-interface">ユーザーインターフェース</a>

## 基本機能
- おなじみの方法でディレクトリをナビゲート
- ファイルやフォルダのコピー＆ペースト、削除、新規作成、名前変更
- グリッド、リスト、ミラーカラム表示モードの切り替え
- escでポップアップを閉じる
- Ctrl / Cmd + Gでパスを入力してディレクトリへ直接ジャンプ
- リストモードでサイズ、名前、最終更新日時でアイテムをソート

## 高度な機能
- ファイルやフォルダの圧縮
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- アーカイブの展開
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- ショートカットLAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)でディレクトリへ移動
  - 設定でパスを自分で構成可能
- F6でファイル作成
- F7でフォルダ作成
- デュアルペイン表示
  - F8でファイル検索
  - F5で現在選択中の要素をもう一方のペインにコピー
  - LShift + F5で現在選択中の要素をもう一方のペインに移動
- ファイルをエクスプローラーにドラッグ＆ドロップして現在のディレクトリにコピー
- Ctrl / Cmd + LShift + Mで選択範囲を一括リネーム
  - Ctrl / Cmd + Returnで一括リネームを実行
- ファイルのクイックプレビュー -> ディレクトリエントリを選択しスペースキーを押す
  - 対応ファイル：全画像ファイル(.jpg, .png, ...)、.pdf、.mp4、.json、.txt、.html
  - その他のアイテムは情報付きの小さなタイルを表示（パス、サイズ、最終更新日時）
- インスタントナビゲーション -> タイピングを始めると自動的にディレクトリエントリをフィルタし、<br/>
  目的地へのナビゲーションがより高速に

## 依存関係（すぐに動作しない場合）

<details>
<summary>表示するには展開</summary>

### Linux

- openssl1.1

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### アーチ
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Fedora
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ FTP統合（sshfs）
<details>
  <summary>クリックして表示</summary>
  <br/>
  依存関係（追加でインストールが必要）:
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | まだサポートされていません **_yet_** |

  ### インストール方法:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### Linux
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ 言語サポート
- 英語
  - 言語を選択するオプションは近日中に追加予定 …
</details>

## ⚠️ 既知の問題:
- Linuxでウィンドウ外へのドラッグ＆ドロップが常に動作するとは限りません
- Windowsでは [Microsoft Visual C++ 再頒布可能パッケージ](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170) のインストールが必要になる場合があります
- ms-windowsでの権限設定が少し奇妙です
  - 要素のコピーなどで問題が発生した場合、管理者としてプログラムを実行する必要があるかもしれません
- プログラムが起動しない場合、linuxシステムでopenssl1.1のインストールが必要な場合があります

## 📝 今後の課題:
- 複数言語対応
- お気に入り機能
- オンラインストレージサービスへのアクセス（Google drive等）

## ユーザーインターフェース

### リストスタイル
<img width="1119" height="673" alt="Screenshot 2025-11-16 at 13 53 53" src="https://github.com/user-attachments/assets/cfe15e6f-9936-4e29-9ca5-0f83f366c9dc" />

### グリッドスタイル
<img width="1121" height="674" alt="Screenshot 2025-11-16 at 13 53 46" src="https://github.com/user-attachments/assets/69dbeee0-b53c-4566-b90e-e85ab97e0033" />

### ミラーコラムビュー
<img width="1112" height="664" alt="Screenshot 2025-11-16 at 13 54 29" src="https://github.com/user-attachments/assets/1f540880-2097-423b-8522-1ef466aee1bd" />

### デュアルペインビュー
<img width="1119" height="667" alt="Screenshot 2025-11-16 at 13 55 16" src="https://github.com/user-attachments/assets/80706079-a048-4e9e-93f0-54fa270f30ac" />

## 貢献方法
tauri v1アプリケーション開発のための環境をセットアップしてください: [Tauriの前提条件](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
セットアップ後、マシンの任意の場所で ```git clone https://github.com/RickyDane/CoDriver``` または ```gh repo clone RickyDane/CoDriver``` を実行してください。
</br></br>
このプロジェクトのルートディレクトリで ```cargo tauri dev``` を実行すると、CoDriverのビルドと実行を開始できます。
</br>
tauri-cliがインストールされていることを確認してください: ```cargo install tauri-cli```
</br>

## リリース署名

macOSのリリース成果物は、Gatekeeperがインストールされたアプリが損傷していると報告しないよう、署名および公証化されている必要があります。必要なGitHub Actionsのシークレットや検証コマンドについては、[macOS署名と公証化](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) を参照してください。

## スター履歴

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="スター履歴チャート" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### その他のサードパーティソフトウェア
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---