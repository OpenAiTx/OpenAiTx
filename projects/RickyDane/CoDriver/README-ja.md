<br/>
<p align="center"><img width="700" src="https://github.com/user-attachments/assets/44295a1a-c904-407d-97af-bc1aa74baa86"/></p>
<br>
<!-- <p align="center"><a target="_blank" href="https://discord.gg/XPakYank"><img src="https://dcbadge.limes.pink/api/server/XPakYank" alt="" /></a></p> -->
<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<a href='https://ko-fi.com/rickydane'>
  <p align="center">
    <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Buy Me a Coffee at ko-fi.com' />
  </p>
</a>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>
<p align="center">
  Rust言語を学びたくて生まれたシンプルなファイルエクスプローラーです。
  <br>
  OSに依存せず、最適化のためにトリミングされています。
</p>

<br/><br/>

パフォーマンスは["jwalk"](https://crates.io/crates/jwalk/versions)と["Tauri"](https://tauri.app/)によって提供されています。
<br/><br/>
CoDriverはファイルやフォルダにアクセスする際にパスのキャッシュを使用しないため、パフォーマンスはRust、ディスクの速度、CPUの性能によって実現されています。

⁉️ このソフトウェアはまだ開発中であり、バグが含まれる可能性があることをご了承ください！
<br/><br/>

# リンク
- <a href="#basic-features">基本機能</a>
- <a href="#advanced-features">高度な機能</a>
- <a href="#dependencies-if-not-working-instantly">依存関係</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">FTP実装（SSHFS）</a>
- <a href="#%EF%B8%8F-language-support">言語サポート</a>
- <a href="#%EF%B8%8F-known-issues">既知の問題</a>
- <a href="#-todos">やることリスト</a>
- <a href="#user-interface">ユーザーインターフェース</a>
- <a href="#speed-comparison">速度比較</a>
<br/>

## 基本機能
- 既知の方法でディレクトリをナビゲート
- コピー＆ペースト、削除、ファイルやフォルダの作成と名前変更
- 「大きなボタン」モード、リストモード、ミラーカラムモードの切り替え
- Escキーでポップアップを閉じる
- Ctrl / Cmd + Gでパスを入力してディレクトリにジャンプ
- リストモードでサイズ、名前、最終更新日時でアイテムを並び替え
<br/>

## 高度な機能
- ファイルやフォルダの圧縮
  - zip
- 作業ディレクトリ内の新しいフォルダにアーカイブを自動展開
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
- ショートカット LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3) でディレクトリへ移動
  - 設定でパスを自分で構成可能
- F6でファイル作成
- F7でフォルダ作成
- ディレクトリで文字を入力するとすぐにディレクトリエントリをフィルター
- デュアルペイン表示
  - F8でファイル検索
  - F5で現在選択中の要素を他のペインにコピー
  - LShift + F5で現在選択中の要素を他のペインに移動
- ファイルをエクスプローラーにドラッグ＆ドロップして現在のディレクトリにコピー
- Ctrl / Cmd + LShift + Mで選択範囲を一括リネーム
  - Ctrl / Cmd + Returnで一括リネーム実行
- ファイルのクイックプレビュー -> ディレクトリエントリを選択してスペースバーを押す。
  - 対応ファイル: すべての画像ファイル（.jpg、.png、...）、.pdf、.mp4、.json、.txt、.html
  - その他のアイテムは、その情報（パス、サイズ、最終更新日時）を示す小さなタイルが表示されます。
- インスタントナビゲーション -> タイプを開始するとディレクトリエントリが自動的にフィルタリングされ、目的の場所への移動が<br/>
  より高速になることがあります。
<br/>

## 依存関係（すぐに動作しない場合）

<details>
<summary>展開して表示</summary>

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
<br/>

## 🖥️ FTP統合（sshfs）
<details>
  <summary>展開して表示</summary>
  <br/>
  依存関係（追加インストールが必要）：
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | 未対応 **_現時点では_** |

  ### インストール：
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
<br/>

## 🏴‍☠️ 言語サポート
- 英語
  - 言語選択オプションは近日公開予定...
</details>
<br/>

## ⚠️ 既知の問題：
- Linuxではウィンドウ外へのドラッグ＆ドロップが現在機能していません
- Windowsでは[Microsoft Visual C++ 再頒布可能パッケージ](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)をインストールする必要がある場合があります
- Windowsの権限設定が少し変わっています
  - 要素のコピーなどで問題が発生した場合は、管理者としてプログラムを実行する必要があるかもしれません
- プログラムが起動しない場合、Linuxシステムにopenssl1.1をインストールする必要がある問題があるかもしれません
- ~~タブ機能はまだ完全には実装されていません~~
<br/>

## 📝 今後の予定：
- 複数言語対応
- お気に入り機能
- オンラインストレージサービス（Googleドライブ等）へのアクセス
<br/>

## ユーザーインターフェース

### リストスタイル
![Screenshot 2024-08-13 at 19 08 02](https://github.com/user-attachments/assets/d643c7f9-44e8-4f94-a23c-69759b600c82)

### グリッドスタイル
![Screenshot 2024-08-13 at 19 08 00](https://github.com/user-attachments/assets/b28b346a-58f3-4f7c-a23d-b19f0695bf23)

### ミラーカラムビュー
![Screenshot 2024-08-13 at 19 08 07](https://github.com/user-attachments/assets/95ab9426-837f-492d-8139-9bf7f1f0c51e)

### デュアルペインビュー
![Screenshot 2024-08-13 at 19 08 25](https://github.com/user-attachments/assets/a3f9a511-5e8f-44ed-95d3-1a59e2cba05b)

## 速度比較
Windows ファイルエクスプローラー: _39.83 秒_<br/>
CoDriver: **_0.81 秒_**

https://github.com/user-attachments/assets/17116fa5-8f43-4339-a4ff-2525e7c94ae0

Windows ファイルエクスプローラー: _44.91 秒_ <br/>
CoDriver: **_< 0.5 秒_**

https://github.com/user-attachments/assets/169da3d0-06ac-4775-a631-5c5708ae4766

</br>

## 貢献方法
tauri v1 アプリケーション開発のためのマシンセットアップ: [Tauri の事前準備](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
準備ができたら、マシン上の任意の場所で ```git clone https://github.com/RickyDane/CoDriver``` または ```gh repo clone RickyDane/CoDriver``` を実行してください。
</br></br>
このプロジェクトのルートディレクトリで ```cargo tauri dev``` を実行すると、CoDriver のビルドと実行を開始できます。
</br>
tauri-cli がインストールされていることを確認してください: ```cargo install tauri-cli```
</br></br>

## Star History

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### その他のサードパーティソフトウェア
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-02

---