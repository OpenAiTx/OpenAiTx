# ytdlp-gui
Rustで書かれたyt-dlpのGUI

- [インストール](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [その他のディストリビューション](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [ソースからビルド](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [設定](https://github.com/BKSalman/ytdlp-gui#configuration)
- [貢献](https://github.com/BKSalman/ytdlp-gui#contribution)

# プレビュー
![image](https://github.com/user-attachments/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# インストール
## Linux

### NixOS (Flake)
リポジトリ内のflake.nixを使用できます

`flake.nix`内に以下を記述:
```nix
{
  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs/nixpkgs-unstable";

    ytdlp-gui = {
      url = "github:bksalman/ytdlp-gui";
    };
  };

    outputs = { nixpkgs, ytdlp-gui, ...}:
    let
      system = "x86_64-linux";

      pkgs = import nixpkgs {
        inherit system;
        overlays = [
          ytdlp-gui.overlay
        ];
      };
    in
    {
      ...snip
```

その後、通常のパッケージとしてhome-managerやnixosConfigurationに追加できます

### Fedora
リリースページからrpmパッケージをダウンロードし、``sudo dnf localinstall <rpm_package_name>``でインストール

### Ubuntu
リリースページからdebパッケージをダウンロードし、``sudo apt install ./<deb_package_name>``でインストール

### Arch

AURの[ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)で利用可能

### その他のディストリビューション

#### 1- ``yt-dlp``をダウンロード
いずれかを選択

&nbsp; &nbsp; &nbsp; a- ディストリビューションのリポジトリから

&nbsp; &nbsp; &nbsp; b- または[バイナリ](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp)をダウンロードし、binディレクトリに移動、`chmod +x <bin_file>`で実行可能にする

#### 2- ディストリビューションのリポジトリから``ffmpeg``または``ffmpeg-free``をダウンロード


#### 3- [リリースページ](https://github.com/BKSalman/ytdlp-gui/releases)から``ytdlp-gui``のバイナリをダウンロード

## Windows
##### リリースページからzipファイルをダウンロードし、サブフォルダに展開して``ytdlp-gui.exe``を起動

# ソースからビルド
ソースからビルドするには`cargo`と`rustc`が必要です。`rustup`（Rustツールチェインマネージャー）やディストリビューションのリポジトリからインストールできます

その後、以下のコマンドを実行:
```bash
# リポジトリを"ytdlp-gui"フォルダにクローン
git clone https://github.com/BKSalman/ytdlp-gui
# フォルダに移動
cd ytdlp-gui
# プロジェクトをビルド
cargo build
# またはリリースモードでビルド（パフォーマンス向上）
cargo build -r
```
バイナリは`<project-root>/target/debug/ytdlp-gui`または`<project-root>/target/release/ytdlp-gui`に生成されます

直接実行も可能:
```bash
# プロジェクトルートから
./target/release/ytdlp-gui
```

またはcargoを使って実行:
```bash
cargo r
# リリースモードで
cargo r -r
```

# 設定

v0.2.2以降、アプリケーションの設定は各プラットフォーム/OSのデフォルト設定ディレクトリ内の``<config_dir>/ytdlp-gui/config.toml``に保存されます

デフォルトファイル例:

```toml
# オプション
# bin自体ではなくbinのディレクトリ
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) 設定しない場合、コマンドは `yt-dlp <app_args>`

# オプション
download_folder = "<some_cool_path>" # デフォルト = "~/Videos"

[options]
video_resolution = "FullHD" # 選択肢: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # 選択肢: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # 選択肢: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" # 選択肢: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### 注意: 品質/フォーマットの設定はダウンロードボタンを押すと自動保存されます

# 貢献
プルリクエストやIssue（バグ報告・機能要望）など、あらゆる形の貢献を歓迎します

ただし、他の作業に集中しているため、迅速な返信や対応ができない場合があります

しかし、できる限り対応します👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---