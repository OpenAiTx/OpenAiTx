# ytdlp-gui
一個用 Rust 編寫的 yt-dlp 圖形使用者介面

- [安裝](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [其他發行版](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [從原始碼建置](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [設定](https://github.com/BKSalman/ytdlp-gui#configuration)
- [貢獻](https://github.com/BKSalman/ytdlp-gui#contribution)

# 預覽
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# 安裝
## Linux

### NixOS (Flake)
你可以使用此倉庫中的 flake.nix

在你的 `flake.nix` 中：
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

接著你可以將它作為一般套件加入，不論是 home-manager 或 nixosConfiguration

### Fedora
從發布頁面下載 rpm 套件，然後以 ``sudo dnf localinstall <rpm_package_name>`` 安裝

### Ubuntu
從發布頁面下載 deb 套件，然後以 ``sudo apt install ./<deb_package_name>`` 安裝

### Arch

可在 AUR 取得 [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### 其他發行版

#### 1- 下載 ``yt-dlp``
有兩種方式：

&nbsp; &nbsp; &nbsp; a- 從你的發行版套件庫安裝

&nbsp; &nbsp; &nbsp; b- 或下載[執行檔](https://raw.githubusercontent.com/yt-dlp/yt-dlp/main/releases/latest/download/yt-dlp)，然後移動到你的 bin 目錄，並使用 `chmod +x <bin_file>` 使其可執行

#### 2- 從你的發行版套件庫下載 ``ffmpeg`` 或 ``ffmpeg-free``


#### 3- 從 [發布頁面](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/releases) 下載 ``ytdlp-gui`` 執行檔

## Windows
##### 直接從發布頁面下載 zip 檔案，解壓縮至子資料夾，啟動 ``ytdlp-gui.exe`` 即可

# 從原始碼建置
要從原始碼建置，你需要有 `cargo` 和 `rustc`，可以透過 `rustup`（Rust 工具鏈管理器）安裝，或是從你的發行版套件庫安裝，隨你喜好

之後執行以下指令：
```bash
# 將倉庫克隆到 "ytdlp-gui" 資料夾
git clone https://github.com/BKSalman/ytdlp-gui
# 進入該資料夾
cd ytdlp-gui
# 你可以使用以下指令建置專案
cargo build
# 或以發行模式建置以獲得更佳效能
cargo build -r
```
建置完成後，執行檔會在 `<project-root>/target/debug/ytdlp-gui` 或 `<project-root>/target/release/ytdlp-gui`

你可以直接執行：
```bash
# 從專案根目錄
./target/release/ytdlp-gui
```

或使用 cargo 執行：
```bash
cargo r
# 或發行模式
cargo r -r
```

# 設定

從 v0.2.2+ 起，應用程式會將設定存放在各平台/作業系統預設的設定目錄中，路徑為 ``<config_dir>/ytdlp-gui/config.toml``

預設檔案內容如下：

```toml
# 選用
# 這是 bin 的目錄，不是 bin 本身
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) 若未設定，指令為 `yt-dlp <app_args>`

# 選用
download_folder = "<some_cool_path>" # 預設 = "~/Videos"

[options]
video_resolution = "FullHD" # 選項: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # 選項: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # 選項: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  選項: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### 注意：按下下載按鈕時，畫質/格式選項會自動保存

# 貢獻
歡迎各種形式的貢獻，不論是 Pull requests、Issues（錯誤回報／功能建議）

不過我可能不會很快回覆或實作，因為我專注於其他事情

但我會盡力而為 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---