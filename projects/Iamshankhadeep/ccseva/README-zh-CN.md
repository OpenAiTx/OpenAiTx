<translate-content># CCSeva 🤖

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![GitHub release](https://img.shields.io/github/release/Iamshankhadeep/ccseva.svg)](https://github.com/Iamshankhadeep/ccseva/releases)
[![Build Status](https://img.shields.io/github/actions/workflow/status/Iamshankhadeep/ccseva/ci.yml?branch=main)](https://github.com/Iamshankhadeep/ccseva/actions)
[![Downloads](https://img.shields.io/github/downloads/Iamshankhadeep/ccseva/total.svg)](https://github.com/Iamshankhadeep/ccseva/releases)
[![macOS](https://img.shields.io/badge/macOS-10.15%2B-blue)](https://github.com/Iamshankhadeep/ccseva)

一个美观的 macOS 菜单栏应用，用于实时跟踪您的 Claude Code 使用情况。通过优雅的界面监控令牌消耗、成本和使用模式。

## 截图

![Dashboard](https://raw.githubusercontent.com/Iamshankhadeep/ccseva/main/./screenshots/dashboard.png)
![Analytics](https://raw.githubusercontent.com/Iamshankhadeep/ccseva/main/./screenshots/analytics.png)
![Terminal](https://raw.githubusercontent.com/Iamshankhadeep/ccseva/main/./screenshots/terminal.png)

## 功能

- **实时监控** - 30秒更新一次的令牌使用情况实时追踪
- **菜单栏集成** - 百分比指示器，带颜色编码状态
- **智能套餐检测** - 自动检测 Pro/Max5/Max20/自定义套餐
- **使用分析** - 7天图表、模型细分和趋势分析
- **智能通知** - 70% 和 90% 阈值提醒，带冷却时间
- **成本追踪** - 每日成本估算和燃烧率计算
- **美观界面** - 渐变设计与玻璃拟态效果

## 安装

### 下载（推荐）
从 [GitHub Releases](https://github.com/Iamshankhadeep/ccseva/releases) 下载最新版本：
- **macOS（Apple Silicon）**：`CCSeva-darwin-arm64.dmg`
- **macOS（Intel）**：`CCSeva-darwin-x64.dmg`

### 从源码构建</translate-content>
```bash
git clone https://github.com/Iamshankhadeep/ccseva.git
cd ccseva
npm install
npm run build
npm start
```
<translate-content>
### 开发</translate-content>
```bash
npm run electron-dev  # Hot reload development
```
## 使用说明

1. **启动** - CCSeva 会出现在菜单栏中  
2. **点击** - 查看详细的使用统计数据  
3. **右键点击** - 访问刷新和退出选项  

该应用会自动从 `~/.claude` 目录检测您的 Claude Code 配置，并每 30 秒更新一次。  

## 要求  

- macOS 10.15 及以上版本  
- Node.js 18 及以上（用于源码构建）  
- 已安装并配置 Claude Code CLI  

## 技术栈  

- Electron 36 + React 19 + TypeScript 5  
- Tailwind CSS 3 + Radix UI 组件  
- 使用 ccusage 包进行数据集成  

## 许可证  

MIT 许可证 - 详情请参见 [LICENSE](LICENSE) 文件。  

## 致谢  

基于 ❤️ 构建，使用了 [Electron](https://electronjs.org)、[React](https://reactjs.org)、[Tailwind CSS](https://tailwindcss.com) 和 [ccusage](https://github.com/ryoppippi/ccusage)。  

---  

**注意**：这是一个非官方的 Claude Code 使用跟踪工具。需要有效的 Claude Code 安装和配置。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---