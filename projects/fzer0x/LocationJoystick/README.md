# Location Joystick

## English

Location Joystick is an Xposed module designed for location simulation. It provides a joystick overlay and various location-related settings to enhance the simulation experience.

⚠️ **[NEW] No Root/Xposed functionality (Mock Location)** ⚠️

# LATEST RELEASE: https://github.com/fzer0x/LocationJoystick_V4/releases

<div align="center">

## 🚀 JOIN OUR COMMUNITY 🚀

<a href="https://t.me/+LTsF8mOwkRE3YzYy">
  <img src="https://img.shields.io/badge/👉_CLICK_HERE_TO_JOIN-FF0000?style=for-the-badge&logo=telegram&logoColor=white" />
</a>

🔥 Join and get support & updates!

</div>

![Screenshot](https://github.com/fzer0x/LocationJoystick/blob/main/screenshot3.jpg?raw=true)

## Features

- **Joystick Overlay:** Navigate in real-time with a customizable joystick.
- **Location Simulation:** Mock your GPS location with precision.
- **GNSS Mocking:** Full GNSS status simulation (satellite count, SVID, C/N0, etc.) to simulate realistic positioning behavior.
- **Randomization:** Add a random offset radius to your location for more natural movement.
- **Favorites:** Save and manage your favorite locations for quick switching.
- **Customizable UI:**
    - Adjust joystick and minimap transparency (alpha).
    - Configurable joystick speed.
    - Persistent joystick position saving.

## Requirements

- **Android:** 10+ (Min SDK 30)
- **Root:** Required for Xposed Framework usage.
- **Xposed Framework:** LSPosed is recommended.
- **[NEW] No Root/Xposed functionality (Mock Location)**

## Installation & LSPosed Scope Configuration

1. Install the Location Joystick APK.
2. Open your Xposed Manager (e.g. LSPosed).
3. Enable the **Location Joystick** module.
4. **Important:** Configure the scope in LSPosed:
    - **Android-System** (must be enabled for GNSS & system-wide mocking).
    - **Target App(s)** (e.g. Pokémon GO, Maps).
5. Reboot your device (or force stop the target app and System UI if using LSPosed).
6. Open Location Joystick and grant the required permissions (Overlay, Location).

## Usage

1. Open the app and set your desired starting location on the map.
2. Configure your simulation settings (speed, accuracy, etc.).
3. Start the service to display the joystick overlay.
4. Open your target app and move using the joystick.

## Disclaimer

This tool is intended for educational and development purposes only. Use at your own risk.

## License

See the [LICENSE](LICENSE) file for details.

---

# Location Joystick

## 中文

Location Joystick 是一款用于模拟定位的 Xposed 模块。它提供了一个虚拟摇杆悬浮窗以及多种与定位相关的设置，以增强模拟体验。

⚠️ **[新功能] 无需 Root 或 Xposed 的模拟定位功能** ⚠️



<div align="center">

## 🚀 加入我们的社区 🚀

<a href="https://t.me/+LTsF8mOwkRE3YzYy">
  <img src="https://img.shields.io/badge/👉_点击加入-FF0000?style=for-the-badge&logo=telegram&logoColor=white" />
</a>

🔥 加入即可获取免费福利与最新更新！

# LATEST RELEASE: https://github.com/fzer0x/LocationJoystick_V4/releases

</div>

![截图](https://github.com/fzer0x/LocationJoystick/blob/main/screenshot3.jpg?raw=true)

## 功能

- **虚拟摇杆悬浮窗：** 使用可自定义的摇杆进行实时移动。
- **模拟定位：** 精确模拟你的 GPS 位置。
- **GNSS 模拟：** 完整模拟 GNSS 状态（卫星数量、SVID、C/N0 等），可用于应对高级定位检测机制。
- **随机化：** 为定位添加随机偏移范围，使移动轨迹更加自然。
- **收藏夹：** 保存和管理常用位置，方便快速切换。
- **可自定义界面：**
    - 调整摇杆和小地图透明度（Alpha）。
    - 可配置摇杆移动速度。
    - 自动保存摇杆位置。

## 系统要求

- **Android：** 10+（最低 SDK 30）
- **Root：** 使用 Xposed 框架需要 Root 权限。
- **Xposed 框架：** 推荐使用 LSPosed。
- **[新功能] 无需 Root/Xposed 的模拟定位功能**

## 安装与 LSPosed 作用域配置

1. 安装 Location Joystick APK。
2. 打开 Xposed 管理器（例如 LSPosed）。
3. 启用 **Location Joystick** 模块。
4. **重要：** 在 LSPosed 中配置作用域：
    - **Android-System**（必须勾选，用于 GNSS 和系统级定位模拟）。
    - **目标应用**（例如 Pokémon GO、地图应用等）。
5. 重启设备（如果使用 LSPosed，也可以强制停止目标应用和 System UI）。
6. 打开 Location Joystick 并授予所需权限（悬浮窗、定位）。

## 使用方法

1. 打开应用，并在地图上设置起始位置。
2. 配置模拟参数（速度、精度等）。
3. 启动服务以显示摇杆悬浮窗。
4. 打开目标应用，并使用摇杆进行移动。

## 免责声明

本工具仅供学习与开发用途，使用风险请自行承担。

## 许可证

许可证详情请参阅 [LICENSE](LICENSE) 文件。
