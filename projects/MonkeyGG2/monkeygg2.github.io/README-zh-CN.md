<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">您身边友好的游戏网站。</p>
<br>

欢迎来到 MonkeyGG2，这是为您打造的功能丰富的游戏平台！MonkeyGG2 提供 150 多款游戏，带来独特且可自定义的游戏体验。无论您是玩家、开发者，还是普通用户，MonkeyGG2 都能为您提供无缝且愉悦的游戏环境。

> 欢迎为我们点亮一颗星！特别是如果你 fork 了本仓库或发现本仓库有其他用途。

## 功能特色

-   超过 150 款游戏
-   简单易用
-   部署便捷
-   可自定义
-   代理支持
-   更多功能……

## 自定义

### 设置

#### 隐匿（Cloaking）

隐匿是指在 `about:blank` 标签页中打开页面。此行为默认强制启用，但可以关闭。重定向链接提供预设选项，也可手动配置。

#### 伪装（Masking）

伪装是指更改 about:blank 标签页的图标和标签标题。图标和标签标题提供预设选项，也可手动配置。

#### 快捷键

可以自定义快捷键来执行多种操作。例如，退出游戏、伪装标签页、执行自定义 JavaScript 等均受支持。
> 注意：如果要执行自定义 JavaScript，请确保您知道自己在做什么。如果出现问题，刷新页面通常能解决。

#### 主题

目前支持以下主题自定义功能：
- 切换背景动画（如果您担心游戏中性能问题，请放心，玩游戏时会自动禁用动画）
- 背景颜色
- 方块颜色
- 按钮颜色
- 游戏颜色
- 悬停颜色
- 滚动条颜色
- 滚动轨道颜色
- 字体颜色

> 注意：如果您不小心将颜色设置成无法使用的状态，请清除浏览器的 cookies 和本地存储。

### 高级自定义

> 免责声明：以下自定义仅供本仓库所有者或其 fork 的所有者使用。

`config.jsonc` 文件用于配置整个网站。目前支持如下项目：
- 游戏
- 主题（即将支持）
- 代理配置

#### 游戏

每个游戏条目以游戏显示名称为键，其值应为包含以下三个键值对的对象：
- `"path"`：游戏在 `./games` 目录下的路径
- `"aliases"`：游戏的其他名称列表，用于增强搜索体验
- `"categories"`：游戏所属的分类列表（即将支持添加图标）

可以手动添加条目，但如果要按字母顺序排列会比较繁琐（不过这不是配置生效的必需条件）。
因此，提供了 `add-game-entry.js` 脚本，方便您无需手动编辑文件即可轻松添加新游戏。

```bash
# 你可以使用任何 JS 运行时，如 node.js、bun 或 deno
# 本示例中使用 bun，因为依赖会自动安装
bun add-game-script.js
# 按提示操作，配置将自动更新
```

#### 主题

主题标准尚未实现（TODO）

#### 代理

代理配置项在 **"config"** 键下。
`"proxy"` 键的值为布尔值，用于开启或关闭代理功能。如果为 false，则用户尝试访问代理时会弹出错误对话框。
`"proxyPath"` 键的值为代理路径，可以是绝对路径或相对路径，但代理页面必须支持 **CORS**，因为将以 iframe 形式显示在站点中。

## 部署

### 无代理部署

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

或者，您也可以直接在 [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) 或 [Codeberg](https://codeberg.org/MonkeyGG2/pages) 上 fork 本仓库，并分别部署到 GitHub Pages 或 Codeberg Pages。

### 使用代理部署

请访问 [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) 页面，了解如何通过代理部署 MonkeyGG2。

### 本地运行

```bash
# 警告：如果你有名为 "monkeygg2" 的文件夹，此命令会删除该文件夹内所有文件
# 请在以下两条命令中修改文件夹名称
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# 从这里你可以使用任何静态服务器工具，这里以 npm 的 "live-server" 为例
npm install -g live-server # 如果尚未安装
npx live-server
```

## 许可证

本项目基于 WTFPL 协议分发。详情请见[此处](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---