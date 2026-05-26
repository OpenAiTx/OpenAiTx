
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
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Buy Me a Coffee at ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Rust言語を学ぶために生まれたシンプルなファイルエクスプローラーです。
  <br>
  OS非依存で、最適化のためにスリム化されています。
</p>

<br/><br/>

パフォーマンスは["jwalk"](https://crates.io/crates/jwalk/versions)と["Tauri"](https://tauri.app/)によって実現されています。
<br/><br/>
CoDriverはファイルやフォルダへのアクセス時にパスキャッシュを使用しておらず、Rustの性能、ディスクの速度、CPUのパワーによってパフォーマンスを実現しています。

⁉️ このソフトウェアはまだ開発中のため、バグが含まれている可能性があります！
<br/><br/>

# リンク
- <a href="#basic-features">基本機能</a>
- <a href="#advanced-features">高度な機能</a>
- <a href="#dependencies-if-not-working-instantly">依存関係</a>
- <a href="#%EF%B8%8F-ftp-sftp-integration">FTP / SFTP 統合</a>
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

## 🖥️ FTP / SFTP 統合

CoDriverは、FTPおよびSFTPリモート接続を完全にネイティブでサポートし、すぐに利用できます。外部依存関係やFUSEレイヤー、`sshfs`マウントは不要です！サイドバーのパネルからリモートサーバーに直接接続できます。

## 🏴‍☠️ 言語サポート
- 英語
  - 言語の選択オプションは近日追加予定 ...

## ⚠️ 既知の問題:
- Linuxでは、ウィンドウ外へのドラッグ＆ドロップが常に動作しない場合があります
- Windowsでは、[Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170) のインストールが必要な場合があります
- ms-windows上の権限設定が少し奇妙です
  - 要素のコピーなどで問題が発生した場合、管理者としてプログラムを実行する必要があるかもしれません
- プログラムが起動しない場合、linuxシステムでopenssl1.1のインストールが必要な場合があります

## 📝 やることリスト:
- 多言語対応
- お気に入り機能
- オンラインストレージサービスへのアクセス（Googleドライブなど）

## ユーザーインターフェース
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## 貢献方法
tauri v1アプリケーション開発のための環境をセットアップしてください: [Tauri 必要条件](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
セットアップが完了したら、マシン上の任意の場所で ```git clone https://github.com/RickyDane/CoDriver``` または ```gh repo clone RickyDane/CoDriver``` を実行してください。
</br></br>
プロジェクトのルートディレクトリで ```cargo tauri dev``` を実行すれば、CoDriverのビルドと実行を開始できます。
</br>
必ず tauri-cli をインストールしてください: ```cargo install tauri-cli```
</br>

## リリース署名

macOS のリリース成果物は署名および公証が必要です。これを行わないと Gatekeeper によりインストールしたアプリが破損していると報告されます。必要な GitHub Actions シークレットや検証コマンドについては [macOS 署名と公証](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) を参照してください。

## スター履歴

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="スター履歴グラフ" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### その他のサードパーティソフトウェア
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---