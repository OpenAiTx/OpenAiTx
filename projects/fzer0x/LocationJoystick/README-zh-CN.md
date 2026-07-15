# 位置摇杆

## 英文

位置摇杆是一个用于位置模拟的 Xposed 模块。它提供了一个摇杆覆盖层和各种与位置相关的设置，以增强模拟体验。

⚠️ **[新功能] 无需 Root/Xposed 功能（模拟位置）** ⚠️

# 最新版本发布：https://github.com/fzer0x/LocationJoystick_V4/releases

<div align="center">

## 🚀 加入我们的社区 🚀

<a href="https://t.me/+LTsF8mOwkRE3YzYy">
  <img src="https://img.shields.io/badge/👉_点击此处加入-FF0000?style=for-the-badge&logo=telegram&logoColor=white" />
</a>

🔥 加入并获取支持与更新！

</div>

![截图](https://github.com/fzer0x/LocationJoystick/blob/main/screenshot3.jpg?raw=true)

## 功能

- **摇杆覆盖层：** 使用可定制的摇杆实现实时导航。
- **位置模拟：** 精准模拟您的 GPS 位置。
- **GNSS 模拟：** 完整的 GNSS 状态模拟（卫星数量、SVID、C/N0 等），以模拟真实的定位行为。
- **随机偏移：** 为您的位置添加随机偏移半径，获得更自然的移动效果。
- **收藏夹：** 保存并管理您喜欢的位置，方便快速切换。
- **可定制界面：**
    - 调整摇杆和小地图的透明度（alpha）。
    - 可配置摇杆速度。
    - 持久保存摇杆位置。

## 要求

- **Android：** 10 及以上（最低 SDK 30）
- **Root：** 使用 Xposed 框架时需要 Root。
- **Xposed 框架：** 推荐使用 LSPosed。
- **[新功能] 无需 Root/Xposed 功能（模拟定位）**

## 安装与 LSPosed 范围配置

1. 安装 Location Joystick APK。
2. 打开你的 Xposed 管理器（如 LSPosed）。
3. 启用 **Location Joystick** 模块。
4. **重要：** 在 LSPosed 中配置范围：
    - **Android-System**（必须启用以支持 GNSS 和系统范围模拟）。
    - **目标应用**（如 Pokémon GO、地图）。
5. 重启设备（或在使用 LSPosed 时强制停止目标应用和系统 UI）。
6. 打开 Location Joystick 并授予所需权限（悬浮窗、定位）。

## 使用方法

1. 打开应用，在地图上设置你想要的起始位置。
2. 配置你的模拟设置（速度、精度等）。
3. 启动服务以显示摇杆悬浮窗。
4. 打开目标应用，使用摇杆移动。

## 免责声明

本工具仅供教育和开发用途。使用风险自负。

## 许可协议

详情请见 [LICENSE](LICENSE) 文件。

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


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-15

---