# ytdlp-gui
一个用 Rust 编写的 yt-dlp 图形界面

- [安装](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [其他发行版](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [从源码构建](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [配置](https://github.com/BKSalman/ytdlp-gui#configuration)
- [贡献](https://github.com/BKSalman/ytdlp-gui#contribution)

# 预览
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# 安装
## Linux

### NixOS (Flake)
你可以使用仓库中的 flake.nix

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

然后你可以将它作为普通软件包添加到你的 home-manager 或 nixosConfiguration 中

### Fedora
从发布页面下载 rpm 包，然后使用 ``sudo dnf localinstall <rpm_package_name>`` 安装

### Ubuntu
从发布页面下载 deb 包，然后使用 ``sudo apt install ./<deb_package_name>`` 安装

### Arch

在 AUR 中可用 [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### 其他发行版

#### 1- 下载 ``yt-dlp``
可选择：

&nbsp; &nbsp; &nbsp; a- 从你的发行版仓库安装

&nbsp; &nbsp; &nbsp; b- 或者下载[二进制文件](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp)，然后移动到你的 bin 目录，并通过运行 `chmod +x <bin_file>` 使其可执行

#### 2- 从你的发行版仓库安装 ``ffmpeg`` 或 ``ffmpeg-free``


#### 3- 从[ytdlp-gui发布页面](https://github.com/BKSalman/ytdlp-gui/releases)下载 ``ytdlp-gui`` 二进制文件

## Windows
##### 只需从发布页面下载 zip 文件，解压到子文件夹，然后启动 ``ytdlp-gui.exe``

# 从源码构建
要从源码构建，你需要安装 `cargo` 和 `rustc`，可以通过 `rustup`（Rust 工具链管理器）或者你的发行版仓库安装，任选其一

之后运行以下命令：
```bash
# 克隆仓库到 "ytdlp-gui" 文件夹
git clone https://github.com/BKSalman/ytdlp-gui
# 进入文件夹
cd ytdlp-gui
# 你可以使用下面命令构建项目
cargo build
# 或者用发布模式构建以获得更好性能
cargo build -r
```
然后二进制文件将位于 `<project-root>/target/debug/ytdlp-gui` 或 `<project-root>/target/release/ytdlp-gui`

你可以直接运行：
```bash
# 从项目根目录
./target/release/ytdlp-gui
```

或者使用 cargo 运行：
```bash
cargo r
# 或发布模式
cargo r -r
```

# 配置

从 v0.2.2+ 版本开始，应用会将配置保存在各平台/操作系统的默认配置目录中的 ``<config_dir>/ytdlp-gui/config.toml``

默认文件如下所示：

```toml
# 可选
# 这是二进制文件所在的目录，不是二进制文件本身
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) 如果未设置，命令将是 `yt-dlp <app_args>`

# 可选
download_folder = "<some_cool_path>" # 默认 = "~/Videos"

[options]
video_resolution = "FullHD" # 可选: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # 可选: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # 可选: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" # 可选: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### 注意：按下下载按钮时，质量/格式选项会自动保存

# 贡献
欢迎各种形式的贡献，无论是 Pull requests，还是 Issues（错误报告/功能请求）

不过我可能不会很快回复或实现请求的内容，因为我正在专注于其他事情

但我会尽力的 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---