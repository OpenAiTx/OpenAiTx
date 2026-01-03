# sunsetr

<p align="center">
    <img src="https://raw.githubusercontent.com/psi4j/sunsetr/main/.github/assets/logo.png" alt="sunsetr logo" width="144" />
</p>
<p align="center">
    Hyprland、Niri 及所有 Wayland 的自动蓝光过滤器
</p>

<p align="center">
  <a href="https://psi4j.github.io/sunsetr/"><img src="https://img.shields.io/badge/Documentation-mdBook-blue" alt="Documentation"></a>
  <a href="https://github.com/psi4j/sunsetr/blob/main/LICENSE"><img src="https://img.shields.io/github/license/psi4j/sunsetr" alt="License"></a>
  <a href="https://github.com/psi4j/sunsetr/releases"><img src="https://img.shields.io/github/v/release/psi4j/sunsetr" alt="Release"></a>
</p>

<p align="center">
  <a href="https://psi4j.github.io/sunsetr/installation.html">安装</a> | <a href="https://psi4j.github.io/sunsetr/quick-start.html">快速开始</a> | <a href="https://psi4j.github.io/sunsetr/configuration/">配置</a> | <a href="https://psi4j.github.io/sunsetr/commands/">命令</a>
</p>

![此图使用着色器模拟了 sunsetr 的效果](https://raw.githubusercontent.com/psi4j/sunsetr/main/.github/assets/sunsetr.png)

Sunsetr 是一个为 Wayland 合成器设计的自动蓝光过滤器。它自动实现从中性到暖色调的平滑色温过渡，旨在减少眼睛疲劳并改善睡眠。Sunsetr 根据您的地理位置或手动时间设置自动调节显示器。它还可以用于永久保持相同的色温和伽马值，并可在多种用户定义的预设之间切换。控制器能够通过 IPC 与您的 shell 或 UI 应用集成并自动化更改。

## 功能

- **多合成器支持**：兼容 Hyprland、Niri、Sway、River、Wayfire 及其他 Wayland 合成器
- **原生 Hyprland CTM 后端**：支持 Hyprland 的直接颜色变换矩阵
- **更智能的 hyprsunset 管理**：为 hyprsunset（Hyprland）添加更长、更清晰、更精确的日落/日出过渡
- **平滑过渡**：可配置的渐变效果，配合自适应算法
- **预设管理**：在配置文件之间快速切换（例如白天、游戏、周末）
- **热重载**：配置文件更改时实时更新，无需重启
- **自动化 IPC**：基于 Unix 套接字的 IPC，用于脚本和外部集成
- **基于地理位置的过渡**：根据您的位置自动计算日出/日落时间
- **交互式城市选择**：可从全球 10,000 多个城市中选择以获取精确坐标
- **自动时区检测**：默认使用系统时区进行位置估算
- **通用 Wayland 支持**：在 Wayland 合成器上直接协议通信
- **智能默认设置**：开箱即用，设置经过精心调校
- **灵活配置**：为高级用户提供丰富的自定义选项

## 待办事项
- [x] 设置 AUR 软件包  
- [x] 使 Nix 安装可用  
- [x] 实现渐进式过渡  
- [x] 支持多合成器 Wayland  
- [x] 基于地理位置的过渡  
- [x] 实现 Hyprland 原生 CTM 后端  
- [x] 实现用于脚本和外部集成的 IPC  
- [ ] 使 Fedora Copr 安装可用  
- [ ] 使 Debian/Ubuntu 安装可用  

## 💛 感谢  

- 感谢 wlsunset、hyprsunset 和 redshift 的启发  
- 感谢 Hyprwm 团队使 Hyprland 成为可能  
- 感谢 niri 团队打造最佳的基于 Rust 的 Wayland 合成器  
- 感谢 Wayland 社区提供强大的协议生态系统



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---