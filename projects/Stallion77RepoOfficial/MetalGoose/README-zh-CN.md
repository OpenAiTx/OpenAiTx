<div align="center">
  <img src="https://raw.githubusercontent.com/Stallion77RepoOfficial/MetalGoose/main/Assets/logo.png" alt="MetalGoose Logo" width="128" height="128">
  
  # MetalGoose
  
  **macOS 平台的 GPU 加速放大和帧生成**
  
  [![macOS](https://img.shields.io/badge/macOS-26.0%2B-blue?logo=apple)](https://www.apple.com/macos/)
  [![Metal](https://img.shields.io/badge/Metal-4.0-orange?logo=apple)](https://developer.apple.com/metal/)
  [![License](https://img.shields.io/badge/License-GPL--3.0-green)](LICENSE)
  [![Swift](https://img.shields.io/badge/Swift-6.2-FA7343?logo=swift)](https://swift.org)
  
  [功能](#features) • [安装](#installation) • [使用](#usage) • [需求](#requirements) • [构建](#building) • [许可](#license)
</div>

---

## 概述

MetalGoose 是一款原生 macOS 应用，提供游戏和应用的实时放大与帧生成。完全基于 Apple 的 Metal 框架构建，带来类似 NVIDIA DLSS 或 AMD FSR 的流畅高帧率体验，但专为 macOS 设计。

## 功能

### MGUP-1 放大
- **性能模式** — 速度最快，延迟最低
- **均衡模式** — 质量与性能的最佳平衡
- **质量模式** — 最高视觉保真度
- 多种渲染比例：原生，75%，67%，50%，33%
- 对比度自适应锐化（CAS）

### MGFG-1 帧生成
- **2倍、3倍、4倍** 帧数倍增
- **自适应** 或 **固定** 帧生成模式
- 运动补偿插值
- 基于光流的运动估计
- 质量模式：性能，均衡，质量

### 抗锯齿
- **FXAA** — 快速近似抗锯齿
- **SMAA** — 增强的子像素形态学抗锯齿
- **MSAA** — 多重采样抗锯齿
- **TAA** — 带历史数据的时间抗锯齿

### 性能监控
- 实时HUD叠加
- 捕获/输出/插值FPS追踪
- GPU时间和帧时间指标
- VRAM使用监控
- 帧统计

## 要求

| 组件      | 要求            |
|-----------|-----------------|
| **macOS** | 26.0（Tahoe）或更高版本 |
| **芯片**  | Apple Silicon（M1/M2/M3/M4） |
| **Xcode** | 26.0或更高版本  |
| **内存**  | 最少8 GB，推荐16 GB |

## 安装

### 下载发布版本
1. 从[Releases](https://github.com/Stallion77RepoOfficial/MetalGoose/releases)下载最新版本
2. 将`MetalGoose.app`移动到`/Applications`
3. 在提示时授予屏幕录制和辅助功能权限

### 从源码构建
```bash
git clone https://github.com/Stallion77RepoOfficial/MetalGoose
cd MetalGoose
open MetalGoose.xcodeproj
```

## 使用方法

1. **启动 MetalGoose**
2. **选择目标**
   - 选择一个窗口或显示器进行捕获
3. **配置设置**
   - 启用放大（MGUP-1）
   - 启用帧生成（MGFG-1）
   - 选择抗锯齿模式
4. **开始放大**
   - 点击“开始”以开始处理

### 键盘快捷键

| 快捷键   | 操作       |
|----------|------------|
| `⌘ + T`  | 切换缩放   |

# MetalGoose 错误代码

## 界面 (MG-UI)
- MG-UI-002: 最前端应用是 MetalGoose；用户必须切换到目标窗口。
- MG-UI-003: 未找到所选应用的目标窗口。
- MG-UI-004: 未找到显示器。
- MG-UI-005: 检测到全屏窗口；虚拟显示需要窗口模式或无边框模式。
- MG-UI-006: 目标窗口边界不可用。
- MG-UI-007: 未找到目标屏幕的显示器ID。
- MG-UI-008: 显示刷新率不可用。

## 引擎 (MG-ENG)
- MG-ENG-001: Metal管线设置失败。
- MG-ENG-002: Metal设备不可用。
- MG-ENG-003: Metal命令队列不可用。
- MG-ENG-004: MetalFX空间缩放器创建失败。
- MG-ENG-005: 光流管线不可用。
- MG-ENG-006: 帧插值失败。
- MG-ENG-007: 抗锯齿管线不可用。
- MG-ENG-008: 缩放管线不可用。
- MG-ENG-009: CAS管线不可用。
- MG-ENG-010: IOSurface 纹理创建失败。
- MG-ENG-011: 光流管线不可用。
- MG-ENG-012: 光流资源不可用。
- MG-ENG-013: 帧生成管线不可用。

## 虚拟显示器 (MG-VD)
- MG-VD-001: CGVirtualDisplayDescriptor 创建失败。
- MG-VD-002: CGVirtualDisplay 创建失败。
- MG-VD-003: CGVirtualDisplayMode 创建失败。
- MG-VD-004: CGVirtualDisplaySettings 创建失败。
- MG-VD-005: 应用虚拟显示设置失败。
- MG-VD-006: 无活动虚拟显示器。
- MG-VD-007: ScreenCaptureKit 中未找到虚拟显示器。
- MG-VD-008: ScreenCaptureKit 启动捕获失败。
- MG-VD-009: ScreenCaptureKit 停止捕获失败。
- MG-VD-010: ScreenCaptureKit 流因错误停止。

## 辅助功能 / 窗口迁移 (MG-AX)
- MG-AX-001: 未授予辅助功能权限。
- MG-AX-002: 从 AX API 读取窗口列表失败。
- MG-AX-003: 未找到目标 PID 的窗口。
- MG-AX-004: 创建 AX 位置值失败。
- MG-AX-005: 设置 AX 窗口位置失败。
- MG-AX-006: 全屏窗口无法移动到虚拟显示器。
- MG-AX-007: 创建 AX 大小值失败。
- MG-AX-008: 设置 AX 窗口大小失败。
- MG-AX-009: 未找到虚拟显示器屏幕。
- MG-AX-010: 目标 PID 的窗口 ID 未找到。

## 覆盖层 (MG-OV)
- MG-OV-001: 创建覆盖层缺少目标屏幕。
- MG-OV-002: 创建覆盖层缺少窗口框架。
- MG-OV-003: 覆盖层纹理创建不支持的像素格式。

## 鼠标路由 (MG-MO)
- MG-MO-001: 虚拟显示器未配置鼠标路由。

## 许可证

本项目采用 GNU 通用公共许可证 v3.0 许可 - 详情请参阅 [LICENSE](LICENSE) 文件。

## Acknowledgments

- Apple for the Metal framework and documentation
- The macOS gaming community for feedback and testing
- Contributors who helped improve the project

---

RESOURCES THAT USED FOR THIS PROJECT

https://developer.apple.com/documentation/metal
https://developer.apple.com/documentation/metalfx/
https://developer.apple.com/documentation/coreimage
https://developer.apple.com/documentation/screencapturekit/
https://developer.apple.com/documentation/appkit
https://developer.apple.com/documentation/metal/mtltexture
https://developer.apple.com/documentation/corevideo/cvpixelbuffer
https://developer.apple.com/documentation/metalperformanceshaders
https://developer.apple.com/documentation/metal/compute-passes
https://developer.apple.com/documentation/vision
https://developer.apple.com/documentation/vision/vngenerateopticalflowrequest
https://developer.apple.com/documentation/ScreenCaptureKit/capturing-screen-content-in-macos


<div align="center">
  <sub>Built with ❤️ using Metal for macOS</sub>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-16

---