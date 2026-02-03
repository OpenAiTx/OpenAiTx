# 原神实用工具 [![License](https://img.shields.io/badge/License-GPL3.0-green.svg)](https://github.com/lanylow/genshin-utility/blob/main/LICENSE) ![OS](https://img.shields.io/badge/OS-Windows-yellow.svg) [![Discord](https://img.shields.io/badge/chat-discord-informational)](https://discord.gg/MrtJvV5tKv)

一款针对《原神》和《崩坏：星穹铁道》的免费开源工具，包含一些提升体验的功能。仅兼容游戏的操作系统版本。

## 常见问题解答

### 如何加载该模组？
1. 从[最新发布版本](https://github.com/lanylow/genshin-utility/releases)下载并解压二进制文件。
2. 以**管理员身份**打开 `loader.exe`，此时应弹出一个窗口提示正在等待游戏启动。
3. 确保该程序运行后，打开《原神》或《崩坏：星穹铁道》游戏。
4. 游戏启动后，模组将被加载。

### 如何打开和关闭菜单？
默认情况下，切换菜单的按键是 <kbd>INSERT</kbd>，但您可以通过修改配置文件更改此按键。

### 我的配置文件保存在哪里？
`genshin-utility` 文件夹位于您的文档目录中，包含已保存的 `.ini` 格式配置文件。部分更新后，可能需要删除并重新生成配置文件。

### 如果原神实用工具菜单没有弹出怎么办？
此问题最常见的原因是第三方覆盖软件。请确保如 MSI Afterburner (RTSS) 或 Discord 游戏覆盖未附加到游戏进程，因为它们可能会干扰本工具菜单。另一个可能原因是您未通过启动器运行游戏，若直接打开游戏可执行文件，本程序将无法工作。

## 截图

![image](https://github.com/lanylow/genshin-utility/assets/31806776/88492fe8-4016-447a-80ec-b8c4d9225cc9)

## 使用的第三方库

* [imgui](https://github.com/ocornut/imgui) - C++ 图形用户界面库
* [minhook](https://github.com/TsudaKageyu/minhook) - Windows API 钩子库
* [mini](https://github.com/metayeti/mINI) - INI 文件读写库

## 许可证

本项目采用 GPL-3.0 许可证 - 详情请参阅 [LICENSE](https://github.com/lanylow/genshin-utility/blob/main/LICENSE) 文件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-03

---