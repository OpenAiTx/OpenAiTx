# Joplin 的 macOS 主题

适用于笔记应用程序 [Joplin](https://joplinapp.org/) v2.2.4 及以上版本的原生 macOS 风格主题。也适用于非 macOS 设备。

![Joplin 的 macOS 主题](/images/macos-theme-for-joplin.png)

- ✨ 完全样式化的用户界面，包括所有控件，
- 🌜 可选择浅色、深色、浅色带深色侧边栏或自动（根据系统偏好浅色/深色），
- 👌 使用原生图标（仅限 macOS）或 Phosphor 图标系列，
- 👨‍🎨 通过 Joplin 偏好设置轻松自定义。

## 安装

- 打开 Joplin 偏好设置 › “插件”，搜索“macOS theme”并安装该主题。
- 重启 Joplin。享受吧！

确保将“外观 › 主题”设置为“浅色”或“深色”。如果切换笔记本时出现闪烁，请同步“外观 › 主题”下的浅色/深色设置与“macOS theme › 外观”下所选的值。更多自定义选项见下文。

## 自定义

安装后，您可以在 Joplin 的偏好设置中找到一个名为“macOS theme”的额外项目。您需要重启 Joplin 以应用更改。

**Mac 用户**：如果想使用原生图标，请从[苹果官网](https://developer.apple.com/fonts/)下载并安装 SF Pro 字体。

## 没有图标？

**Windows 用户**：如果图标显示为空白方块或缺失，您需要手动安装 Phosphor 字体。请从 [phosphoricons.com](https://phosphoricons.com/)（[直接下载](https://phosphoricons.com/assets/phosphor-icons.zip)）下载，解压文件，安装 `Fonts/regular/Phosphor.ttf`，然后重启 Joplin。

**Mac 用户**：如果“图标系列”设置为“macOS native (SF Pro)”，您需要从[苹果官网](https://developer.apple.com/fonts/)安装 SF Pro 字体。请注意，这仅在 macOS 设备上有效。

## 免责声明

⚠️ Joplin 使用 styled-components 进行样式设计，这使得为应用程序定制主题非常困难。使用了大量 hacky CSS 解决方案和 `!important`，这可能导致未来 Joplin 版本出现界面问题。由于只是 CSS，您的数据依然安全，且您可以轻松恢复样式。

如果遇到问题，欢迎[创建问题](https://github.com/ajilderda/joplin-macos-native-theme/issues)或在[论坛](https://discourse.joplinapp.org/t/plugin-macos-theme-for-joplin)发帖。

## 帮助，安装插件后出现空白屏幕。

如果安装插件后出现空白屏幕，很可能是由于表情符号处理问题。解决方法如下：

1. 首先，找到你的 Joplin 配置目录：

   - macOS: `~/.config/joplin-desktop`
   - Windows: `%APPDATA%\Joplin`
   - Linux: `~/.config/Joplin`

2. 进入 `plugins` 文件夹，删除 macOS 主题插件的 `.jpl` 文件。
3. 重启 Joplin。

### 预防

为了防止此问题发生：

- 不要使用 Joplin 的“选择表情符号...”对话框，而是在笔记本标题文本框中直接添加表情符号（参见[此讨论](https://github.com/andrejilderda/joplin-macos-native-theme/issues/96#issuecomment-1553517708)了解视觉参考）。
- 你现在可以重新安装该插件。

## 开发

你可以通过 Joplin 的偏好设置调整主题。如果想要全面定制，请按照以下步骤制作你自己的构建。

安装依赖：

```sh
npm install
```
要构建插件：


```sh
npm run dist
```

要更新插件框架：

```sh
npm run update
```

构建 CSS 并监视更改：

```sh
npm run dev
```
生成的 CSS 将可在以下地址获取：http://localhost:8080/macos-theme-for-joplin.css

## 贡献

欢迎贡献（尤其是修复）！

### 开发流程

每次修改都要重启 Joplin 有些麻烦。为了加快速度并缩短反馈周期：

1. 运行 `npm run dev`。这将监听 .scss 文件的变化并重建 CSS。
2. 切换 Joplin 的开发者工具（**帮助 › 切换开发者工具**）
3. 选择 [此 gist](https://gist.github.com/andrejilderda/f6673f1b1a986b2dc0cd01607acbff26) 中的两种刷新方法之一。
4. 在开发者工具控制台粘贴并运行脚本以自动刷新 CSS。

这通常效果很好，但请注意，有时修改的样式会与已安装插件的样式冲突。为确认是否如此，可以确保环境干净：

1. 如果已安装 macOS 主题插件，请先卸载。
2. 运行构建：`npm run build`
3. 在 Joplin 中，进入 **插件 › 显示高级设置**。
4. 在 **开发插件** 下，粘贴你的 `dist` 文件夹路径。
5. 重启 Joplin 以加载你的本地插件构建版本。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-23

---