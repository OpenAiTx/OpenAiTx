# 🌌 GNOME 动态壁纸引擎

> **[立即在 GNOME 扩展中安装](https://extensions.gnome.org/extension/9558/gnome-wallpaper-engine/)**

无需复杂设置。无繁重依赖。仅需 mpv、ffmpeg + 扩展。

在 GNOME 上使用动态壁纸的**最简单且最可靠的方式** — 完全兼容 **Wayland 和 X11**。

由 **mpv** 驱动，确保最大性能、低资源占用及全格式支持（MP4、GIF、WebM、MKV……）。

如果你喜欢这个项目，欢迎给它点个星 ⭐ — 这对我们帮助很大！

## ☕ 支持与更新

如果你想支持该项目，可以通过这里进行：

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/achu94)

我也会在 Ko-fi 分享开发更新、进展和幕后花絮。

你无需捐赠即可查看帖子 — 欢迎所有人关注并保持更新 🙂

如果你喜欢这个项目，GitHub 上的 ⭐ 也非常感谢！

---

## 🎥 演示

> 在 GNOME（Wayland）上运行的动态壁纸

![demo](https://raw.githubusercontent.com/achu94/gnome-wallpaper-engine/main/assets/demo.gif)

---

## ✨ 功能

- 🎬 **集成图库：** 直接从 GNOME 设置浏览和选择壁纸
- 🖼️ **缩略图预览：** 自动生成所有壁纸的预览图
- 📥 **智能导入：** 一键添加视频并即时应用
- 🚀 **GPU 加速（默认启用）：** 使用 mpv 的 `hwdec=auto`
- ⚡ **极低CPU使用率：** 通常约为1–3%
- 🔄 **即时应用：** 实时切换壁纸
- 🖥️ **Wayland支持：** 在大多数工具失败的情况下稳定工作
- 📦 **最小配置：** 只需mpv和ffmpeg
- 🎞️ **广泛格式支持：** MP4、GIF、WebM、MKV等
- 🔁 **自动启动：** 登录时自动启动壁纸
- 🧩 **托盘图标切换：** 显示或隐藏顶部面板指示器
- ⏸️ **自动暂停（全屏）：** 全屏应用激活时暂停
- 🔋 **自动暂停（电池）：** 使用电池时暂停以节省电量

---

## 🚧 路线图

- 🎮 Steam壁纸引擎集成（自动检测并列出兼容壁纸）
- 🎛️ 高级播放设置（循环模式、速度等）
- 🎨 未来渲染引擎（无需mpv）

---

## 🛠 需求

您只需安装**mpv**：

### Ubuntu / Debian / Zorin OS

```bash
sudo apt update && sudo apt install mpv ffmpeg
```

### Fedora

```bash
sudo dnf install mpv ffmpeg
```

### Arch Linux

```bash
sudo pacman -S mpv ffmpeg
```

### openSUSE

```bash
sudo zypper in mpv ffmpeg
```

## 📦 安装

### 🎖️ 官方 GNOME 扩展（最简单）
直接从 GNOME 扩展网站安装：

**[在 GNOME 扩展网站下载](https://extensions.gnome.org/extension/9558/gnome-wallpaper-engine/)**

---

### ⚡ 快速安装（本地 ZIP）

```bash
gnome-extensions install gnome-wallpaper-engine@gjs.com.zip
```
然后：

- Wayland：注销并重新登录
- X11：按 `Alt + F2`，输入 `r`，按回车

最后，使用 **扩展** 应用启用该扩展  
（如果启用了顶部面板指示器，也可以通过它启用）。

---

### 🧩 手动安装

1. 从最新版本下载 ZIP 文件
2. 将其解压到：


```
~/.local/share/gnome-shell/extensions/
```

3. 确保文件夹命名为：

```
gnome-wallpaper-engine@gjs.com
```

4. 在终端中运行此命令以编译 GSettings 模式：

```
glib-compile-schemas ~/.local/share/gnome-shell/extensions/gnome-wallpaper-engine@gjs.com/schemas/
```
5. 重启 GNOME Shell
    - Wayland：注销然后重新登录
    - X11：按 `Alt + F2`，输入 `r`，按回车

6. 使用 **扩展** 应用启用扩展

---

## 📖 使用方法

1. 打开扩展设置
2. 点击 **“添加视频/GIF”**
3. 从图库中选择壁纸
4. 壁纸会即时应用
5. 可选地使用顶部面板指示器开始或停止播放
6. 可选地从设置中隐藏托盘图标

---

## 💡 设计初衷

我开发此扩展是为了解决 GNOME 上缺乏简单且可靠的动态壁纸解决方案的问题，尤其是在 Wayland 上。

---

## ⚖️ 许可证

GPL-3.0 — 免费且开源。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-28

---