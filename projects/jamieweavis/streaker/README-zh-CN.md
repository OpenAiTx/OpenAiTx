# Streaker <img alt="Streaker Logo" align="right" width=40 height=40 alt="Screenshot" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/./.github/icons/icon.svg">

跨平台 GitHub 贡献连续记录及统计追踪菜单栏应用，带提醒通知功能

[![ci](https://github.com/jamieweavis/streaker/actions/workflows/ci.yml/badge.svg)](https://github.com/jamieweavis/streaker/actions)
[![downloads](https://img.shields.io/github/downloads/jamieweavis/streaker/total.svg)](https://github.com/jamieweavis/streaker/releases)
[![version](https://img.shields.io/github/release/jamieweavis/streaker.svg)](https://github.com/jamieweavis/streaker/releases)
[![license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/jamieweavis/streaker/blob/main/LICENSE)

<img width="716" alt="Screenshot" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/screenshot.png">

## 安装

从 **[GitHub 发布页面](https://github.com/jamieweavis/streaker/releases)** 下载最新版本的 Streaker（或查看 **[开发](#development)** 部分自行构建）。

## 功能

- 菜单栏贡献统计
  - 连续记录
    - 最佳
    - 当前
    - 之前
  - 贡献
    - 最高（天）
    - 今日
    - 总计（年）
- 菜单栏图标根据贡献状态变化
  - 空心 - 今日未贡献
  - 实心 - 今日已贡献
  - 皇冠 - 当前处于最佳连续记录
- 三种不同菜单栏图标主题
  - 火焰
  - 瓷砖
  - Octocat
- 提醒通知，防止丢失连续记录

### 菜单栏图标

#### 浅色模式

| 状态 | 火焰 | 瓷砖 | Octocat |
| ----- | ----- | ---- | ------- |
| 待处理 | <img width="20" alt="Flame Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac.svg"> | <img width="20" alt="Tile Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac.svg"> | <img width="20" alt="Octocat Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac.svg"> |
| 已贡献 | <img width="20" alt="Flame Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac.svg"> | <img width="20" alt="Tile Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac.svg"> | <img width="20" alt="Octocat Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac.svg"> |
| 连续贡献 | <img width="20" alt="Flame Crown" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac.svg"> | <img width="20" alt="Tile Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac.svg"> | <img width="20" alt="Octocat Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac.svg"> |

#### 暗黑模式

| 状态 | 火焰 | 瓷砖 | Octocat |
| ----- | ----- | ---- | ------- |
| 待处理 | <img width="20" alt="Flame Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac-white.svg"> | <img width="20" alt="Tile Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac-white.svg"> | <img width="20" alt="Octocat Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac-white.svg"> |
| 已贡献 | <img width="20" alt="Flame Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac-white.svg"> | <img width="20" alt="Tile Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac-white.svg"> | <img width="20" alt="Octocat Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac-white.svg"> |
| 连续贡献 | <img width="20" alt="Flame Crown" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac-white.svg"> | <img width="20" alt="Tile Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac-white.svg"> | <img width="20" alt="Octocat Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac-white.svg"> |

## 开发

### 先决条件

- [Node.js](https://github.com/nodejs/node) (>=22.x.x)
- [pnpm](https://github.com/pnpm/pnpm) (>=10.x.x)

### 快速开始

克隆仓库并安装依赖：

```sh
git clone https://github.com/jamieweavis/streaker.git

cd streaker

pnpm install
```

为您当前的平台打包应用程序：
```bash
pnpm package
```
_打包后的应用程序现在将位于 `out/` 目录中_

在开发模式下运行应用程序：

```bash
pnpm start
```

*目前只有渲染进程支持热重载，`src/main/` 中的更改需要重启*

## 相关内容

- [Streaker CLI](https://github.com/jamieweavis/streaker-cli) - 带有 ASCII 贡献图的 GitHub 贡献连击和统计跟踪命令行应用
- [Contribution](https://github.com/jamieweavis/contribution) - GitHub 贡献图解析器，从用户的 GitHub 贡献图页面计算贡献连击和提交统计数据


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-11

---