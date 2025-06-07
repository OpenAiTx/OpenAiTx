# Discord GNOME 主题

一个为 Discord 设计的 GNOME 主题，遵循 Adwaita 风格与 GNOME 人机界面指南（在 Discord CSS 允许的范围内尽量实现）。

## 依赖要求

1. Vesktop

   用于启用 Windows 标题栏。

2. 设置 > 语言 > 选择 “English (US)”

   由于 Discord 图标识别方式，这允许自定义图标。你可以[本地化](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss)主题，但请阅读本地化说明。

3. 设置 > 插件 > 启用 “ThemeAttributes”

   这允许在设置对话框中显示图标。

4. 设置 > Vesktop 设置 > 启用 “Discord 标题栏”

   可选，但如果你有标题栏，推荐开启。

### 可选补充

1. 移除 Nitro 相关内容：https://github.com/CroissantDuNord/discord-adblock

## 主题设计理念

### 人机界面指南

由于 Discord 的 CSS 或设计限制，或我个人的选择，主题可能无法完全遵循 HIG。

### 支持范围

以下内容不受支持：

- Discord 实验性功能

  我不是 Discord 的员工，无法了解这些实验性功能是否会被更改、废弃等，即维护负担较重——我还维护着其他项目。

- Nitro

  例外情况——任何可以通过 FakeNitro 插件访问的内容。

你\*可以\*就这些内容提交 issue，但只有在很容易修复（比如缺失图标）的情况下才会修复。

## 安装方法

### 无需配置

将以下内容复制到 设置 > 主题 > 在线主题 的文本框中：

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### 包含配置

将 [gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) 放到 ~/.config/vesktop/themes 目录下。该文件仍会自动更新。

## 预览

![first](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![cozy second](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![third](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---