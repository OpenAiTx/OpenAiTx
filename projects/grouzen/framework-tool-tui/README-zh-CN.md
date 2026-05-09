# Framework 系统 TUI

![Rust](https://img.shields.io/badge/lang-rust-orange) ![ratatui](https://img.shields.io/badge/ui-ratatui-blue) ![Framework Laptop](https://img.shields.io/badge/hardware-Framework--Laptop-success)  

一个快速响应的 TUI 仪表盘，用于控制和监控你的 Framework 笔记本硬件——充电、隐私、灯光、USB PD 端口等。

![demo](/docs/screenshots/demo-v0.7.2.gif)

## :octocat: 特性

### Framework 笔记本硬件

- [x] **实时电池和充电状态**，带限制和充电控制
- [x] **麦克风和摄像头隐私开关**
- [ ] **输入面板模式** 选择器（Framework 16）
- [x] **键盘和指纹识别灯光亮度控制**
- [x] **USB PD 端口监控**
- [x] **风扇转速 (RPM)**
- [ ] **温度信息：** CPU/GPU 温度
- [x] **系统信息：** BIOS 详情

## 安装

### :dvd: 二进制文件

Linux、Windows 和 FreeBSD 的预编译二进制文件可在 [Releases](https://github.com/grouzen/framework-tool-tui/releases) 页面下载

### :memo: 从源码安装

需要 [Rust](https://rustup.rs/)（2024 版）和一台 Framework 笔记本。

```sh
git clone https://github.com/grouzen/framework-tool-tui.git
cd framework-tool-tui
cargo build --release
# or via cargo install
cargo install --path .
```

### :penguin: Linux 发行版

#### Gentoo linux

它可以通过官方的 [Gentoo 软件包](https://packages.gentoo.org/packages/app-laptop/framework-tool-tui) 或 [lamdness](https://github.com/grouzen/lamdness-overlay/tree/main/app-laptop/framework-tool-tui) 覆盖层获得

```sh
# Official gentoo repository
sudo emerge -av app-laptop/framework-tool-tui

# or via lamdness overlay
sudo eselect repository enable lamdness
sudo emaint -r lamdness sync
sudo emerge -av app-laptop/framework-tool-tui
```

#### Arch linux

它可以通过 [AUR](https://aur.archlinux.org/packages/framework-tool-tui) 或 [archlinuxcn](https://github.com/archlinuxcn/repo/tree/master/archlinuxcn/framework-tool-tui) 获取

```sh
[yay/paru] -S framework-tool-tui # Install from AUR
sudo pacman -S framework-tool-tui # Install from archlinuxcn
```

#### NixOS Linux

它可通过官方的 [NixOS 软件包](https://search.nixos.org/packages?query=framework-tool-tui) 获取：

```sh
nix-shell -p framework-tool-tui # Install temporarily

# Add to the NixOS configuration or use nix profile to install permanently
```

#### :beer: Linux 版 Homebrew

可通过 [`framework-tool-tui` 配方](https://formulae.brew.sh/formula/framework-tool-tui) 获取

```sh
brew install framework-tool-tui
```

### 😈 FreeBSD


它可在 [FreeBSD ports](https://www.freshports.org/sysutils/framework-tool-tui/) 中获得
```sh
pkg install framework-tool-tui
```

### Windows

目前，您可以选择[从源码安装](#memo-from-source)或[从预编译二进制文件安装](#dvd-binaries)

## :man: 运行

需要以管理员权限运行才能访问硬件控制。

```sh
sudo framework-tool-tui
```

## :pencil: 架构

完整的技术细节请参见 [ARCHITECTURE.md](https://raw.githubusercontent.com/grouzen/framework-tool-tui/main/docs/ARCHITECTURE.md)。  
- 通过 [`framework_lib`](https://github.com/FrameworkComputer/framework-system) 进行硬件轮询

## :handshake: 贡献

欢迎提交拉取请求！有关错误报告或功能请求，请参见 Issues。

### 推送代码前的检查

建议在提交并推送到功能分支之前运行 `cargo make check-all`。

这要求你的系统上安装了 [cargo make](https://github.com/sagiegurari/cargo-make) 运行器：

```sh
cargo install --force cargo-make
```

### 提交信息规范

本项目使用[Conventional Commits](https://www.conventionalcommits.org/)进行自动版本控制和变更日志生成。请按照以下格式编写您的提交信息：

```
<type>: <description>

[optional body]
```

**常见类型：**
- `feat:` - 新功能（触发次版本升级）
- `fix:` - Bug 修复（触发补丁版本升级）
- `docs:` - 文档更改
- `refactor:` - 代码重构
- `test:` - 添加或更新测试
- `chore:` - 维护任务
- `ci:` - CI/CD 变更

**示例：**
```
feat: add thermal monitoring support
fix: correct battery percentage calculation
docs: update installation instructions
```
对于破坏性更改，在类型后添加`!`或在页脚中包含`BREAKING CHANGE:`：

```
feat!: redesign UI layout
```

### 技术栈

- [ratatui](https://ratatui.rs)
- [tokio](https://tokio.rs)
- [framework_lib](https://github.com/FrameworkComputer/framework-system/tree/main/framework_lib)

## :judge: 许可证

```
MIT License

Copyright (c) 2025 Mykhailo Nedokushev

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

```

请参阅 [LICENSE](LICENSE) 和 [Cargo.toml](https://raw.githubusercontent.com/grouzen/framework-tool-tui/main/Cargo.toml:1) 了解许可和依赖项。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-09

---