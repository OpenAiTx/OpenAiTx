# Battman
Strayers 为他们那些老旧 iOS 设备打造的现代电池管理器。

### 🌍
[简体中文](https://raw.githubusercontent.com/Torrekie/Battman/master/docs/README-zh_CN.md)

## 截图
<div style="width:20%; margin: auto;" align="middle">
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Main.png?raw=true" alt="Battman 主界面演示" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Gas Gauge.png?raw=true" alt="Battman 电量计演示" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Gas Gauge-1.png?raw=true" alt="Battman 电量计演示 2" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Adapter.png?raw=true" alt="Battman 适配器演示" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Inductive.png?raw=true" alt="Battman 感应充电演示" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Inductive-1.png?raw=true" alt="Battman 感应充电演示 2" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Serial.png?raw=true" alt="Battman 串口演示" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Temperature.png?raw=true" alt="Battman 温度演示" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/ChargingMgmt.png?raw=true" alt="Battman 充电管理演示" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/ChargingLimit.png?raw=true" alt="Battman 充电限制演示" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Thermal.png?raw=true" alt="Battman 热管理演示" width="25%" height="25%" />
</div>

$${\color{grey}真正 \space 软件 \space 的 \space 优雅 \space 在于 \space 代码 \space 艺术 \space 而 \space 非 \space 表面 \space 设计。}$$

<br />

### 优势
- [x] 完全采用 Objective-C 与 C 构建
- [x] 界面完全用出色的 Objective-C 代码编写
- [x] 无 StoryBoards，无附加二进制文件，无 Xcode 资源
- [x] 不涉及 Swift 和 SwiftUI
- [x] 无 CocoaPods，无 Swift 包，无外部代码依赖，无第三方框架
- [x] 支持有无 Xcode 编译
- [x] 可在 Linux 上构建（是的，“你需要 Mac 来做 iOS 应用”是苹果的宣传）
- [x] 直接从硬件获得并操作最底层原始数据
- [x] 支持 iPhone、iPad、iPod、Xcode 模拟器及 Apple Silicon Mac（如果有人捐设备，我甚至可以为 Apple Watch 和 Apple TV 编写代码）
- [x] 深度集成由德州仪器制造的电池电量计芯片
- [x] 显示比 IOPS 和电源管理更多的电源信息
- [x] 识别你的电源适配器、无线充电器，甚至 MagSafe 配件

### 只有 Battman 能做到
iOS 上其他电池工具未做到的功能  
（截至 2025 年 3 月 9 日星期日 UTC+0）  
- [x] 完整的 NotChargingReason 解码（见 [not_charging_reason.h](https://raw.githubusercontent.com/Torrekie/Battman/master/Battman/battery_utils/not_charging_reason.h)）  
- [x] 德州仪器阻抗追踪™信息获取  
- [x] 实时充电电流/电压读取  
- [x] 在 Xcode 模拟器中完美运行（其他人使用 IOPS 其应用在模拟器中无法工作）  
- [x] 智能充电（优化电池充电）通信  
- [x] 低电量模式行为控制  
- [x] 附加 MagSafe 配件的详细信息  
- [x] 附加 Lightning 线缆及配件的详细信息  
- [x] 读取所有硬件温度传感器  

### 要求  

- 已越狱或通过 TrollStore 安装  
- iOS 12+ / macOS 11+（欢迎回移植）  
- arm64（理论上 A7+ / M1+）  
- Gettext libintl（可选，用于本地化）  
- GTK+ 3（可选，用于在基于 GTK+ 的窗口管理器下运行）  

### 下载  

查看最新的[发布版本](https://github.com/Torrekie/Battman/releases/latest)获取预构建包。  

或者，如果您希望自行编译：


```bash
# On macOS, install Xcode and directly build in it
# On Linux or BSD, make sure a LLVM cross toolchain and iPhoneOS.sdk is prepared, modify Battman/Makefile if needed
# On iOS, when you using Torrekie/Comdartiwerk as bootstrap
apt install git odcctools bash clang make sed grep ld64 ldid libintl-dev iphoneos.sdk
git clone https://github.com/Torrekie/Battman
cd Battman
# If Targeting iOS 12 or ealier, download SF-Pro-Display-Regular.otf somewhere, and put it under Battman/
wget <https://LINK/OF/SF-Pro-Display-Regular.otf> -O Battman/SF-Pro-Display-Regular.otf
make -C Battman all
# Produced Battman.ipa will under $(CWD)/Battman/build/Battman.ipa
```
### 已知问题

- 在运行于搭载 A7 到 A10 设备时，Battman 实际上并未与硬件集成，因为这些设备没有 AppleSMC，而是使用 AppleHPM，我们无法测试。

### 测试设备
- iPhone 12 系列 (D52)
- 2021 款 iPad Pro 第三代 (J51)
- iPhone XR
- iPad Air 2

如果 Battman 在您的设备上运行不正常，请提交[问题反馈](../../issues/new)

### 待办事项
- [ ] macOS 的 AppKit/Cocoa 界面
- [ ] iOS/macOS 的 GTK+/X11 界面
- [ ] 自动识别电量计芯片
- [ ] 可选数据收集（用于解码当前未知参数）
- [x] 高级功能（AppleSMC/ApplePMGR 接口）
- [x] 热控
- [ ] 以命令行模式运行
- [ ] 以守护进程模式运行
- [x] 充电限制
- [x] 无线/MagSafe 集成
- [ ] 应用速率限制
- [ ] Jetsam 控制
- [ ] 风扇控制
- [ ] 蓝牙配件（AirPods 等）

### 许可证

截至 2025 年 9 月 27 日星期六 UTC+0，Battman 使用[非自由许可证](https://raw.githubusercontent.com/Torrekie/Battman/master/LICENSE/LICENSE.md)，而非 MIT 许可，如果我想靠这个谋生，你不会责怪我吧？

## 免责声明

请勿用于生产环境，不保证任何担保，风险自负。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-23

---