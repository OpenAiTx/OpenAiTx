# CreamLinux

CreamLinux 是一款 Linux 图形界面应用程序，简化了 Steam 游戏中 DLC ID 的管理。它提供了一个用户友好的界面，用于安装和配置 CreamAPI（适用于原生 Linux 游戏）和 SmokeAPI（适用于通过 Proton 运行的 Windows 游戏）。

## 观看演示视频：

[![观看演示](https://raw.githubusercontent.com/Novattz/creamlinux-installer/main/./src/assets/screenshot1.png)](https://www.youtube.com/watch?v=neUDotrqnDM)

## 测试版状态

⚠️ **重要提示**：CreamLinux 当前处于测试版阶段。这意味着：

- 某些功能可能尚不完整或会有所变动
- 你可能会遇到错误或意外行为
- 应用程序正在积极开发中
- 你的反馈和错误报告非常宝贵

虽然核心功能正常，但请注意这是早期版本。我会持续努力改进稳定性，添加功能，并提升用户体验。请在 [GitHub Issues 页面](https://github.com/Novattz/creamlinux-installer/issues) 报告你遇到的任何问题。

## 功能

- **自动发现**：自动查找系统中安装的 Steam 游戏
- **原生支持**：为原生 Linux 游戏安装 CreamLinux
- **Proton 支持**：为通过 Proton 运行的 Windows 游戏安装 SmokeAPI
- **DLC 管理**：轻松选择启用哪些 DLC
- **现代界面**：简洁、响应迅速且易于使用的界面

## 安装

### AppImage（推荐）

1. 从[发布](https://github.com/Novattz/creamlinux-installer/releases)页面下载最新的 `creamlinux.AppImage`
2. 赋予其执行权限：
   ```bash
   chmod +x creamlinux.AppImage
   ```
3. 运行它：

   ```bash
   ./creamlinux.AppImage
   ```
   对于Nvidia用户使用此命令：


   ```
   WEBKIT_DISABLE_DMABUF_RENDERER=1 ./creamlinux.AppImage
   ```

### 从源代码构建

#### 先决条件

- Rust 1.77.2 或更高版本
- Node.js 18 或更高版本
- webkit2gtk-4.1（Debian 系统为 libwebkit2gtk-4.1）
- npm 或 yarn

#### 步骤

1. 克隆仓库：

   ```bash
   git clone https://github.com/Novattz/creamlinux-installer.git
   cd creamlinux-installer
   ```
2. 安装依赖项：


   ```bash
   npm install # or yarn
   ```

3. 构建应用程序：

   ```bash
   NO_STRIP=true npm run tauri build
   ```

4. 编译后的二进制文件将位于 `src-tauri/target/release/creamlinux`

### 桌面集成

如果您使用的是 AppImage 版本，可以将其集成到您的桌面环境中：

1. 创建一个桌面条目文件：

   ```bash
   mkdir -p ~/.local/share/applications
   ```

2. 创建 `~/.local/share/applications/creamlinux.desktop` 文件，内容如下（根据您的 AppImage 路径进行调整）：

   ```
   [Desktop Entry]
   Name=Creamlinux
   Exec=/absolute/path/to/CreamLinux.AppImage
   Icon=/absolute/path/to/creamlinux-icon.png
   Type=Application
   Categories=Game;Utility;
   Comment=DLC Manager for Steam games on Linux
   ```

3. 更新您的桌面数据库，使 creamlinux 出现在您的应用启动器中：

```bash
update-desktop-database ~/.local/share/applications
```

## 故障排除

### 常见问题

- **游戏无法加载**：确保Steam中的启动选项设置正确
- **DLC未显示**：尝试刷新游戏列表并重新安装
- **找不到Steam**：确保已安装Steam并至少启动过一次

### 调试日志

日志存储位置：`~/.cache/creamlinux/creamlinux.log`

## 许可证

本项目采用MIT许可证 - 详情见[LICENSE](https://raw.githubusercontent.com/Novattz/creamlinux-installer/main/LICENSE.md)文件。

## 致谢

- [Creamlinux](https://github.com/anticitizn/creamlinux) - 原生支持
- [SmokeAPI](https://github.com/acidicoala/SmokeAPI) - Proton支持
- [Tauri](https://tauri.app/) - 桌面应用框架
- [React](https://reactjs.org/) - UI库


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---