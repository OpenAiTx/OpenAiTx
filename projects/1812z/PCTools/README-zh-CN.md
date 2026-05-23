# 🖥️ PCTools

> Simple Python program for seamless integration of Windows with Home Assistant, enabling hardware monitoring, remote control, and more.

[![GitHub Release](https://img.shields.io/github/v/release/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools/releases/latest)
[![GitHub Downloads](https://img.shields.io/github/downloads/1812z/PCTools/total?style=flat-square&logo=github&label=Downloads)](https://github.com/1812z/PCTools/releases)
[![GitHub Stars](https://img.shields.io/github/stars/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools)
[![License](https://img.shields.io/github/license/1812z/PCTools?style=flat-square)](LICENSE)

---

## ✨ Features

| Feature | Description |
|------|------|
| 📊 **Aida64 Monitoring** | Periodically update selected sensor data |
| 🎮 **Remote Commands** | Automatically sync `.bat` and `.lnk` files in `commands` folder to HA |
| 📸 **Web Monitoring** | Screenshots / Camera / Live stream |
| 💬 **Message Notifications** | Listen to HA text input and display as Toast messages |
| 🌐 **Sidebar Webpage** | Hotkey to call up HA web sidebar |
| ⌨️ **Hotkey Linkage** | Hotkeys trigger HA binary sensors |
| 📱 **Foreground App Feedback** | Automatically report current app name, supports [Runtime Tracker](https://github.com/1812z/RunTime_Tracker) |
| 🖥️ **Monitor Control** | Multi-monitor brightness / on-off / DDC-CI commands |
| 🔊 **Volume Control** | Control Windows system volume |
| 🌙 **Dark Mode** | Toggle system/app dark mode |
| 📶 **Bluetooth Control** | Turn system Bluetooth on/off |
| ⚡ **Command Line** | Execute custom CMD/PowerShell |
| 🎨 **Wallpaper Engine** | Control Wallpaper Engine |
| ⌨️ **Key Simulation** | Simulate keyboard input (including media keys) |
| 🔗 **URL Launcher** | Open custom URLs |

**Web monitoring endpoints:**
- Screenshot: `http://127.0.0.1:5000/screenshot.jpg`
- Camera: `http://127.0.0.1:5000/video_feed`
- Live screen: `http://127.0.0.1:5000/screen`

---

## 📷 Screenshot Showcase

<details>
<summary>🖼️ 软件界面</summary>
<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/gui.png" alt="GUI" width="600"/>
</details>

<details>
<summary>📱 HA 界面</summary>

**另类副屏** (推荐配合 [HA_Helper](https://github.com/1812z/Ha_Helper))

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/1743859715274.jpg" alt="副屏" width="400"/>

**主页面**

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/image.png" alt="主页面" height="500"/>

</details>

---

## 🚀 快速开始

### 1️⃣ 安装环境

**方式一**：下载 [Releases](https://github.com/1812z/PCTools/releases/latest) 内的压缩包（内置运行环境）

**方式二**：手动配置
```bash
# Python 3.12
pip install -r requirements.txt
```
### 2️⃣ 安装第三方依赖软件(可选)

| 依赖 | 用途 |
|------|------|
| MQTT 服务器 | 接入 Home Assistant |
| [Aida64](https://github.com/1812z/PCTools/releases) | 硬件信息监控 |
| [Twinkle Tray](https://github.com/xanderfrangos/twinkle-tray/releases) | 显示器亮度调节 |

### 3️⃣ 配置依赖

1. **Aida64**：开启内存共享并勾选需要的传感器数据
2. **Twinkle Tray**：确保能正常读取显示器信息
3. **壁纸引擎**：启动以支持相关操作

> 💡 新增/修改传感器后，如有冲突，请删除 HA/MQTT 内的设备并重启软件

### 4️⃣ 运行程序

1. 运行 `打开GUI.bat` 启动界面
2. 进入设置配置参数（**按回车保存**）
3. 启用所需插件（**建议重启程序**）
4. 点击启动，在 HA 的 MQTT 集成中查看新设备

### 5️⃣ 开机自启（可选）

设置中点击 **自启动**，程序将后台运行，在系统托盘查看图标

---

## 📋 开发计划

- [x] 键盘快捷键联动
- [x] 代码优化
- [x] 插件逻辑优化
- [ ] 电脑风扇控制
- [ ] Toast 多按钮回调
- [ ] 插件市场
- [ ] 媒体控制
- [ ] 网易云歌词同步


---

## 💡 推荐搭配

| 软件 | 描述 |
|------|------|
| [OpenRGB](https://openrgb.org/) | RGB 灯光控制，支持 HA 接入 |
| [HASS.Agent](https://github.com/hass-agent/HASS.Agent) | 更稳定的同类工具 |

---

## 致谢

- [python_aida64](https://github.com/gwy15/python_aida64) - Aida64 数据读取

---

## 📝 其他

- 支持无头模式：`python core.py`
- 部分页面需切换后才会刷新


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-23

---