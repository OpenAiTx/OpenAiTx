<h1 align="center">ModernZ - mpv 的简洁替代 OSC</h1>

一个为 [mpv](https://mpv.io/) 设计的简洁现代的 OSC，本项目是 ModernX 的一个分支，旨在通过添加更多功能来增强功能，同时保持 mpv OSC 的核心标准。

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>安装 »</strong></a>
  <br>
  <a href="#configuration">配置</a>
  ·
  <a href="#controls">控制</a>
  ·
  <a href="#interactive-menus">交互菜单</a>
  ·
  <a href="#translations">OSC 语言</a>
  ·
  <a href="#extras">附加脚本</a>
</p>

## 功能

- 🎨 现代且可自定义的界面 [[选项](#configuration)]
- 📷 带缩放控制的图片查看模式 [[详情](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ 按钮：下载、播放列表、速度控制、截图、固定、循环、缓存等 [[详情](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 播放列表、字幕、章节、音轨和音频设备的交互菜单 [[详情](#interactive-menus)]
- 🌐 支持多语言，集成 JSON [locale](#translations)
- ⌨️ 可配置的控制 [[详情](#controls)]
- 🖼️ 视频缩略图预览，使用 [thumbfast](https://github.com/po5/thumbfast)

## 自定义

您可以通过在 `modernz.conf` 中使用 `icon_theme` 选项，将图标主题更改为 `fluent` 或 `material`，以匹配您的喜好和风格。

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

不喜欢白色按钮和文字？您可以完全控制颜色和按钮布局的自定义，完美展现您的风格。

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

有关如何自定义颜色和按钮的详细信息，请参阅配置指南中的[颜色自定义](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style)部分。

## 交互菜单

ModernZ 支持 mpv 内置的控制台/选择功能（[v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0)），用于播放列表、字幕、章节导航等。

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## 安装

1. **禁用默认 OSC**

   - 在您的 `mpv.conf` 中添加 `osc=no`

2. **复制文件**

   - 将 `modernz.lua` 放置于 mpv 的 scripts 目录
   - 将 `fluent-system-icons.ttf` 和 `material-design-icons.ttf` 放置于 mpv 的 fonts 目录
   - （可选）将 `thumbfast.lua` 放置于 mpv 的 scripts 目录

3. **目录位置**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **文件夹结构** [[mpv 手册](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (可选)
   ```

## 配置

1. 在 `/script-opts` 文件夹中创建 `modernz.conf` 以自定义设置

   - [下载默认 modernz.conf](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. 简短配置示例：

   ```EditorConfig
   # 进度条颜色（十六进制格式）
   seekbarfg_color=#B7410E

   # 界面选项
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

有关完整选项列表，请[查看详细列表](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md)。

## 控制

### 按钮交互

- 左键点击：主要操作
- 右键点击：次要操作
- 中键点击/Shift+左键点击：备用操作

> [!注意]
> 中键点击执行与 `Shift+左键点击` 相同的功能，便于单手操作

有关完整的交互列表，请查看[按钮交互指南](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)。

### 快捷键绑定

ModernZ 默认不设置快捷键绑定，以避免干扰您当前的设置。如果需要，可以在 `input.conf` 中添加快捷键绑定：

```
w   script-binding modernz/progress-toggle           # 切换进度条
x   script-message-to modernz osc-show               # 显示 OSC
y   script-message-to modernz osc-visibility cycle   # 循环切换可见性模式
z   script-message-to modernz osc-idlescreen         # 切换空闲屏幕
```

## 翻译

ModernZ 目前提供英文版，但您可以轻松切换到您喜欢的语言！方法如下：

1. **下载语言包：**

从本仓库获取 [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) 文件。该文件包含多种语言的翻译。

2. **将语言包添加到 mpv：**

将下载的 `modernz-locale.json` 文件复制到 mpv 的 `/script-opts` 文件夹。

3. **选择语言：**

有两种方式设置首选语言：

- **推荐方法：** 使用 `modernz.conf` 文件

  ```ini
  # modernz.conf 示例配置
  # 设置语言为简体中文
  language=zh
  ```

- **替代方法：** 编辑 `modernz.lua` 脚本

  打开 `modernz.lua`，找到开头附近的 `user_opts` 部分，将 `language` 值改为您喜欢的语言代码：

  ```lua
  local user_opts = {
      -- 通用
      language = "en",  -- 改成您首选的语言代码
      ...
  }
  ```

**需要更多信息？**

有关可用语言完整列表、贡献指南及详细翻译文档，请访问 [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)。

## 附加脚本

以下脚本均由我编写和维护，欢迎根据需要使用。

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - 一个简单的暂停指示器脚本

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - 一个简单的 mpv 脚本，可自动为指定域名更改 `ytdl-format`（yt-dlp）

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - 一个简单的 mpv 脚本，可自动将视频文件/流的 4:3 画面比例转换为 16:9

更多实用脚本请查看 [mpv 用户脚本 Wiki](https://github.com/mpv-player/mpv/wiki/User-Scripts)，这里汇集了丰富的社区贡献脚本，助力提升您的 mpv 体验。

## 历史

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - 分支自 [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - 分支自 [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - 分支自 [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**为何再次分支？**

- 添加诸多功能：[颜色自定义](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style)、[选项](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md)及[语言集成](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- 将控制台和选择集成到 osc 中，启发 mpv 在默认 osc 中应用该功能。[参考[#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- 添加专门的图片布局。[[详情](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 完全重做项目以符合 mpv 默认 osc 标准，确保兼容性
- 消除旧有的 bug 和代码冗余
    - 这也让其他 `Modern` 分支可基于 ModernZ，如 [zydezu/ModernX](https://github.com/zydezu/ModernX)。[[参考](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

总结来说，就是为了维护并复兴 `modern-osc` 的初衷。
话虽如此，ModernZ 仍然使用了部分旧代码，每一位之前和现在的分支作者及贡献者都值得被认可（包括 mpv 的原生 osc），这就是为什么他们会被详细提及的原因。

#### 致谢：

- 字体：UI Fluent 系统图标 [[详情](https://github.com/microsoft/fluentui-system-icons)] [[字体文件](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- 字体由 [Xurdejl](https://github.com/Xurdejl) 修改以供 ModernZ osc 使用
- [mpv](https://github.com/mpv-player/mpv) 及其 [osc.lua](https://github.com/mpv-player/mpv/blob/master/player/lua/osc.lua)，因为 ModernZ osc 是基于原生 osc 标准重构的，并应用了其更新
- 所有现代 osc 的起源及其分支，如 [历史](#history) 中所述
- 所有直接或间接帮助 ModernZ osc 的 [贡献者](https://github.com/Samillion/ModernZ/graphs/contributors)、测试者和用户 ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---