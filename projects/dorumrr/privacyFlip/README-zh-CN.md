# PrivacyFlip

**Android 设备的自动锁定/解锁隐私控制 🔐📱✨**

**PrivacyFlip** 根据锁定/解锁状态自动管理您的 Android 设备隐私功能。锁定设备时，它可以禁用 **Wi-Fi**、**蓝牙**、**移动数据**、**定位** 服务、**NFC**，甚至 **摄像头/麦克风传感器**。解锁时，它智能地恢复您希望启用的功能。

**支持 Shizuku 或 Root 权限** - 选择您偏好的权限方式！

<div>
  <a href="https://f-droid.org/en/packages/io.github.dorumrr.privacyflip/" target="_blank" rel="noopener"><img height="50" src="https://f-droid.org/badge/get-it-on.png"></a> 
  <a href="https://apt.izzysoft.de/fdroid/index/apk/io.github.dorumrr.privacyflip" target="_blank" rel="noopener"><img height="50" src="https://gitlab.com/IzzyOnDroid/repo/-/raw/master/assets/IzzyOnDroid.png"></a> 
  <a href="https://www.buymeacoffee.com/ossdev"><img height="50" src="https://cdn.buymeacoffee.com/buttons/v2/arial-yellow.png" /></a>
</div>

## 📸 截图

<div align="center">
  <img src="https://raw.githubusercontent.com/dorumrr/privacyFlip/main/fastlane/metadata/android/en-US/images/phoneScreenshots/1.png" alt="PrivacyFlip by Doru Moraru" width="300" style="margin: 10px; border: 1px solid #222222"/>
  <img src="https://raw.githubusercontent.com/dorumrr/privacyFlip/main/fastlane/metadata/android/en-US/images/phoneScreenshots/2.png" alt="PrivacyFlip by Doru Moraru" width="300" style="margin: 10px; border: 1px solid #222222"/>
</div>

## 🔒 功能

### **自动隐私控制**
- **锁屏检测**：屏幕锁定时即时禁用隐私功能
- **解锁检测**：等待正确认证（不仅仅是屏幕亮起）
- **智能恢复**：解锁时可配置功能重新启用

### **受控隐私功能**
- 📶 **Wi-Fi** - 禁用/启用无线连接
- 📱 **蓝牙** - 控制蓝牙无线电
- 📡 **移动数据** - 管理蜂窝数据连接
- 📍 **定位服务** - 控制 GPS 和位置追踪
- 📳 **NFC** - 控制近场通信传感器
- 📷 **摄像头** - 禁用/启用摄像头传感器隐私（Android 12 及以上）
- 🎤 **麦克风** - 禁用/启用麦克风传感器隐私（Android 12 及以上）
- ✈️ **飞行模式** - 锁定时启用飞行模式（可选，禁用所有无线电）
- 🔋 **省电模式** - 锁定时启用省电模式（可选）

### **高级功能**
- **智能禁用选项**：
  - **“仅当未使用/未连接时”** - 如果正在使用中，不禁用WiFi、蓝牙或定位
  - **“仅当未启用时”** - 防止连接重置，不重新启用已开启的功能
  - **“仅当未手动设置时”** - 解锁时尊重手动启用的保护模式

- **应用免除** - 当前台时排除特定应用免受隐私操作影响
- **三星NFC自动重试** - 针对三星支付框架NFC覆盖的可选功能（适用于Galaxy S、Note、Z系列）
- **辅助功能服务** - 试验性支持侧键/电源键即时锁定（可选，需辅助功能权限）
- **高级检测** - 多层蓝牙连接检测防止耳机意外断开

### **可定制时长**
- **锁定延迟**：0-60秒（细粒度），2分钟或5分钟，隐私操作触发前的延迟
- **解锁延迟**：0-60秒（细粒度），2分钟或5分钟，功能恢复前的延迟
- **即时模式**：将延迟设为0，实现即时操作
- **注意**：相机和麦克风忽略自定义延迟，因Android限制立即触发

## 📱 要求

**最低版本：** Android 7.0+（API级别24）
**相机/麦克风功能：** Android 12+（API级别31）

**选择您的权限方式：**

### **选项1：Shizuku**（无需root！）
- 已安装并运行**Shizuku**应用
- 通过USB调试或无线ADB获得**ADB权限**
- **无需root** - 使用ADB级权限工作

### **选项2：Root权限**（推荐给已root设备）
- 通过Magisk、SuperSU或类似工具获得**Root权限**
- 使用UID 0权限实现**最佳性能**

### **选项3：Dhizuku**（设备所有者方式）
- 拥有**设备所有者**或**配置文件所有者**身份
- **无需root**，初始化后无需ADB
- **权限持久** - 重启后依然有效
- **最佳适用**：企业设备、工作配置文件、注重隐私的环境

### **选项4：Sui**（两者兼顾）
- 已root设备，安装了Magisk
- **Sui Magisk** 模块已安装  
- **最佳用户体验** - 无权限提示，自动启动  

### **权限检测优先级**  
1. **Sui** - 提供带 root 权限的 Shizuku API 的 Magisk 模块（最佳用户体验）  
2. **Root** - 通过 Magisk/SuperSU 的传统 root 权限  
3. **Dhizuku** - 设备所有者方法（设置后无需 root 或 ADB）  
4. **Shizuku** - 通过 Shizuku 应用的 ADB 权限  

## 🤝 贡献  

帮助改进此应用。任何贡献都不算小！  

### 如何贡献  

1. **Fork 代码库**  
2. **创建功能分支**（`git checkout -b feature/amazing-feature`）  
3. **进行修改**  
4. **提交修改**（`git commit -m 'Add some amazing feature'`）  
5. **推送分支**（`git push origin feature/amazing-feature`）  
6. **发起 Pull Request**  

所有贡献都受到**重视**和**感谢**！  

## 📄 许可证  

本项目采用 MIT 许可证 - 详情见 [LICENSE](LICENSE) 文件。  

## 💖 支持开发  

PrivacyFlip 保护您的隐私。您也可以保护它的未来！  

[![DONATE](https://img.shields.io/badge/DONATE-FFD700?style=for-the-badge&logoColor=white)](https://buymeacoffee.com/ossdev)  

---  

*深夜努力，只为更光明的明天*  

由 Doru Moraru 创作


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-17

---