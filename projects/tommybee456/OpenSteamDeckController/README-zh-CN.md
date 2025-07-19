# OpenSteamDeckController (v0.1)

一个受 Steam Deck 和 Steam Controller 启发的定制模块化无线控制器。具有触控板、可拆卸两半和完整 HID 支持功能。使用 nRF52840 微控制器和增强型 ShockBurst 协议从零开始构建。[视频](https://youtu.be/ycMgIToLav8?si=cVztny4IiIS_V4oI) 

加入 [Discord！](https://discord.gg/ZtV34Hwx7y)

> **注意**  
> 本项目处于早期开发阶段 — v0.1。请预期重大变更、漏洞和频繁更新。

---

## 🚀 项目目标

- 🎮 模拟类似 Steam Deck 的模块化无线控制器两半
- 🖱️ 支持鼠标、键盘和游戏手柄 HID 模式
- 🧲 使用 Azoteq IQS7211E 传感器自制触控板
- 🔋 磁吸 pogo 针充电和连接系统
- 🛠️ 完全开源的硬件和固件

---

## ✅ v0.1 开发清单

### 硬件
- [x] 左右控制器两半 (nRF52840)
- [x] USB 加密狗 (nRF52840)
- [x] 定制触控板 PCB (IQS7211E)
- [ ] 外壳的 3D 打印版本
- [ ] 控制器 PCB（左右）
- [ ] 摇杆 PCB（以降低成本）
- [ ] gp2040ce + nrf 加密狗

### 固件
- [x] 基于 ESB 的无线通信
- [x] 鼠标 + 游戏手柄 + 键盘 HID 报告
- [x] 触控板和按钮的输入解析
- [ ] 触觉 / 震动支持
- [ ] 陀螺仪支持
- [ ] 校准程序 + 保存到内部存储
- [ ] 可配置模式（手势/点击/鼠标/游戏手柄）
- [ ] Steam Input 兼容性或 XInput 兼容性
- [ ] 电容式摇杆

### 其他
- [ ] 改进文档和图示
- [ ] 设计用户界面或配置工具（软件或添加屏幕）
- [ ] 固件迁移到 Zephyr（未来可选）
- [ ] 优化延迟和丢包处理
- [ ] 降低成本

---

## 📷 媒体资料

即将推出 — 演示图片、构建进度和游戏测试。

---

## 🛠️ 构建说明

_(即将推出)_

- 电路图和板文件（.zip 或链接）
- 固件刷写说明
- 依赖列表和设置

---

## 🤝 贡献

欢迎贡献！随时分叉仓库、提交问题或拉取请求。

如果不确定从哪里开始，请查看[清单](#-v01-开发清单)中的未完成任务。

---

## 📄 许可证

MIT 许可证 — 详见 `LICENSE` 文件。

---

## 💬 联系方式

如有问题或建议，请通过 GitHub Issues 或 [YouTube](https://www.youtube.com/@TommyBee456) 联系。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---