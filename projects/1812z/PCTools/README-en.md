# 🖥️ PCTools

> A simple Python program that seamlessly integrates Windows with Home Assistant to achieve hardware monitoring, remote control, and other functions.

[![GitHub Release](https://img.shields.io/github/v/release/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools/releases/latest)
[![GitHub Downloads](https://img.shields.io/github/downloads/1812z/PCTools/total?style=flat-square&logo=github&label=Downloads)](https://github.com/1812z/PCTools/releases)
[![GitHub Stars](https://img.shields.io/github/stars/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools)
[![License](https://img.shields.io/github/license/1812z/PCTools?style=flat-square)](LICENSE)

---

## ✨ Features

| Feature | Description |
|------|------|
| 📊 **Aida64 Monitoring** | Periodically updates selected sensor data |
| 🎮 **Remote Commands** | Automatically syncs `.bat` and `.lnk` files in the `commands` folder to HA |
| 📸 **Web Monitoring** | Screenshots / Camera / Real-time stream |
| 💬 **Message Notification** | Listens to HA text input and displays Toast messages |
| 🌐 **Sidebar Webpage** | Shortcut key to call out HA webpage sidebar |
| ⌨️ **Shortcut Key Linkage** | Shortcut keys trigger HA binary sensors |
| 📱 **Foreground App Feedback** | Automatically reports current app name, supports [Runtime Tracker](https://github.com/1812z/RunTime_Tracker) |
| 🖥️ **Monitor Control** | Multi-monitor brightness / power / DDC-CI commands |
| 🔊 **Volume Control** | Controls Windows system volume |
| 🌙 **Dark Mode** | Switches system/app dark mode |
| 📶 **Bluetooth Control** | Turns system Bluetooth on/off |
| ⚡ **Command Line** | Executes custom CMD/PowerShell |
| 🎨 **Wallpaper Engine** | Controls Wallpaper Engine |
| ⌨️ **Key Simulation** | Simulates keyboard input (including media keys) |
| 🔗 **URL Launcher** | Opens custom URLs |

**Web Monitoring Endpoints:**
- Screenshot: `http://127.0.0.1:5000/screenshot.jpg`
- Camera: `http://127.0.0.1:5000/video_feed`
- Real-time Screen: `http://127.0.0.1:5000/screen`

---

## 📷 Screenshot Showcase

<details>
<summary>🖼️ Software Interface</summary>
<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/gui.png" alt="GUI" width="600"/>
</details>

<details>
<summary>📱 HA Interface</summary>

**Alternative Secondary Screen** (Recommended to use with [HA_Helper](https://github.com/1812z/Ha_Helper))

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/1743859715274.jpg" alt="Secondary Screen" width="400"/>

**Main Page**

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/image.png" alt="Main Page" height="500"/>

</details>

---

## 🚀 Quick Start

### 1️⃣ Install Environment

**Method One**: Download the archive in [Releases](https://github.com/1812z/PCTools/releases/latest) (with built-in runtime environment)

**Method Two**: Manual configuration
```bash
# Python 3.12
pip install -r requirements.txt
```

### 2️⃣ Install Third-Party Dependencies (Optional)

| Dependency | Purpose |
|------|------|
| MQTT Server | Connect to Home Assistant |
| [Aida64](https://github.com/1812z/PCTools/releases) | Hardware information monitoring |
| [Twinkle Tray](https://github.com/xanderfrangos/twinkle-tray/releases) | Monitor brightness adjustment |

### 3️⃣ Configure Dependencies

1. **Aida64**: Enable memory sharing and select the required sensor data
2. **Twinkle Tray**: Ensure it can properly read monitor information
3. **Wallpaper Engine**: Launch to support related operations

> 💡 After adding/modifying sensors, if conflicts occur, please delete devices in HA/MQTT and restart the software

### 4️⃣ Run the Program

1. Run `打开GUI.bat` to start the interface
2. Enter settings to configure parameters (**press Enter to save**)
3. Enable required plugins (**a program restart is recommended**)
4. Click start, then check new devices in HA’s MQTT integration

### 5️⃣ Auto-start on Boot (Optional)

Click **Auto-start** in settings, the program will run in the background, and you can view the icon in the system tray

---

## 📋 Development Plan

- [x] Keyboard shortcut linkage
- [x] Code optimization
- [x] Plugin logic optimization
- [ ] PC fan control
- [ ] Toast multi-button callback
- [ ] Plugin marketplace
- [ ] Media control
- [ ] NetEase Cloud Music lyrics synchronization

---

## 💡 Recommended Combinations

| Software | Description |
|------|------|
| [OpenRGB](https://openrgb.org/) | RGB lighting control, supports HA integration |
| [HASS.Agent](https://github.com/hass-agent/HASS.Agent) | More stable similar tool |

---

## Acknowledgements

- [python_aida64](https://github.com/gwy15/python_aida64) - Aida64 data reading

---

## 📝 Others

- Supports headless mode: `python core.py`
- Some pages require switching before they refresh


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-23

---