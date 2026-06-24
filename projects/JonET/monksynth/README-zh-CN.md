# MonkSynth

[![Build](https://github.com/JonET/monksynth/actions/workflows/build.yml/badge.svg)](https://github.com/JonET/monksynth/actions/workflows/build.yml)
[![Release](https://img.shields.io/github/v/release/JonET/monksynth?include_prereleases)](https://github.com/JonET/monksynth/releases)
[![License](https://img.shields.io/github/license/JonET/monksynth)](LICENSE)

一个单声道的人声合成器，听起来像僧侣的吟唱。使用共振峰波函数（FOF）合成构建，灵感来自经典的 AudioNerdz （2002）VST 插件 [Delay Lama](http://www.audionerdz.nl/)。

**[下载最新版本](https://github.com/JonET/monksynth/releases)** — 支持 Windows、macOS 和 Linux。

<img src="https://raw.githubusercontent.com/JonET/monksynth/main/docs/screenshot1.png" alt="MonkSynth running in Ableton Live 12 with the classic Delay Lama theme" width="600">

*MonkSynth v0.0.1-beta.1 在 Ableton Live 12 中运行，使用从原始 Delay Lama DLL 导入的经典主题*

## 功能

- 产生真实人声共振峰的 FOF 合成引擎
- 用于实时音高和元音控制的 XY 坐标板
- 内置立体声延迟效果
- MIDI 支持：按键开/关、音高轮、CC1（颤音）、CC5（滑音）、CC7（音量）、CC12（延迟）、CC13（声音）
- 可自动化的**音高弯曲**参数（±12 半音）。硬件音高轮可通过右键菜单 → 音高弯曲 路由到元音（经典 / Delay Lama 兼容，默认）或音高
- 配置化的 ADSR 包络：攻击、衰减、保持、释放
- 多声音模式，最多可达 10 个失谐声音及声音扩散
- 主题系统，右键上下文菜单支持自定义主题
- 从原始 Delay Lama DLL 导入经典主题
- 5 个工厂预设
- VST3 插件格式（Windows、macOS、Linux）和 Audio Unit（macOS）

## 构建

### 先决条件

- CMake 3.20+
- C/C++ 编译器（MSVC、GCC 或 Clang）

### 构建

```bash
cd cpp
cmake -B build
cmake --build build --config Release --target MonkSynth
```
VST3 SDK 由 CMake 自动获取。构建的插件将放置在您的系统 VST3 目录中。

### macOS 音频单元

要同时构建 AU 插件，请安装 [AudioUnit SDK](https://github.com/apple/AudioUnitSDK) 并配置：


```bash
cmake -B build -G Xcode -DSMTG_AUDIOUNIT_SDK_PATH=/path/to/AudioUnitSDK
cmake --build build --config Release --target MonkSynth-au
```

### DSP 单元测试

纯 C 语言的 DSP 层（`dsp/`）有一个小型单元测试套件，测试 ADSR 包络边界、音符堆栈、合奏微调数学、弯音传播和延迟线反馈稳定性。测试是可选的，因此不会影响正常插件构建：

```bash
cd cpp
cmake -B build-tests -DMONKSYNTH_BUILD_TESTS=ON
cmake --build build-tests --config Release
ctest --test-dir build-tests --output-on-failure
```

CI 在 Linux 任务上运行测试套件，然后才打包每个版本，因此任何 DSP 回归都会阻止构建。

## 安装

- **macOS：** 运行 `.pkg` 安装程序 — 同时安装 VST3 和 AU 插件
- **Windows：** 运行 `.exe` 安装程序 — 安装 VST3 插件
- **Linux：** 解压并复制 `MonkSynth.vst3` 到 `~/.vst3/`

### Linux 兼容性

Linux 版本在每次发布时都会验证，在以下发行版家族上以严格加载器语义（Bitwig 风格的 `dlopen(RTLD_NOW)`）干净加载：

- Ubuntu 22.04 / 24.04 LTS（及其衍生版：Linux Mint、Pop!_OS、Elementary、KDE neon）
- Debian 12（及其衍生版：KX Studio、AV Linux、MX Linux）
- Fedora（最新）
- Arch Linux（及其衍生版：Manjaro、EndeavourOS、CachyOS）

如果您的发行版未列出，极有可能仍然可用 — 这些是在 CI 中进行的冒烟测试，用于捕捉缺失共享库类错误，而不是详尽的支持声明。插件基于 Ubuntu 22.04（glibc 2.35）构建，因此任何 glibc ≥ 2.35 的发行版都应兼容。欢迎通过 [GitHub Issues](https://github.com/JonET/monksynth/issues) 报告其他发行版的情况。

## 主题

MonkSynth 不带内置主题。首次启动时，会显示设置界面，您可以从原始 Delay Lama DLL 导入经典外观（该 DLL 可在 [audionerdz.nl](http://www.audionerdz.nl/download.htm) 免费获得）。

您也可以通过右键点击插件 GUI 加载自定义主题。主题文件夹包含一个 `theme.json` 清单文件以及以下 PNG 文件的任意组合（缺失的文件会退回到 1x1 占位符）：

- `background.png` — 主要背景（360x510）
- `monk-strip.png` — 动画精灵图（5x6 网格，311x311 帧）
- `knob-left.png` / `knob-right.png` — 旋钮胶片条（50x3000，60 帧）
- `fader-down-large.png` / `fader-down-sm.png` / `fader-right-sm.png` — 推子把手
- `info.png` — 信息覆盖层（253x275）

**正在寻找新的默认主题以随插件一起发布。** 如果您设计了令您自豪的主题，请提交 PR — 我很乐意在下次发布中包含贡献的主题。右键菜单中有“打开主题文件夹”项，可显示主题在磁盘上的位置。

## 翻译

插件界面（设置屏幕、信息覆盖层、右键菜单及 DLL 导入错误信息）支持英文、日文和韩文。语言自动从操作系统区域设置检测；您可以通过右键 → 语言来手动切换。

**日文和韩文翻译由大型语言模型生成，作为起点。** 非母语者的贡献非常欢迎 — 请提交编辑 `cpp/src/strings_ja.h` 或 `cpp/src/strings_ko.h` 的 PR。每个字符串由 `cpp/src/i18n.h` 中的 `StringId` 枚举索引；保持条目顺序一致，任何不确定的条目请留空字符串以回退到英文。

参数名称（显示在您的DAW自动化通道中）故意保持英文——教程、预设和社区讨论都假设使用英文名称。

## 代码签名政策

由 [SignPath.io](https://about.signpath.io/) 提供免费代码签名，证书由 [SignPath Foundation](https://signpath.org/) 颁发。

Windows VST3 插件和安装程序作为 GitHub Actions 发布构建的一部分进行签名。签名请求仅针对从此仓库构建的有标签发布提交给 SignPath，每个请求在证书应用前均在 SignPath UI 中手动批准。

| 特权角色 | 签名者 |
|----------|--------|
| 作者     | [Jonathan Taylor](https://github.com/JonET) |
| 审核者   | [Jonathan Taylor](https://github.com/JonET) |
| 批准者   | [Jonathan Taylor](https://github.com/JonET) |

### 隐私政策

除非用户或安装、操作人员特别请求，本程序不会向其他联网系统传输任何信息。

## 致谢

- [Delay Lama](http://www.audionerdz.nl/) 由 AudioNerdz (2002) — 这款备受喜爱的免费VST插件启发了本项目
- Xavier Rodet (IRCAM) — 共振峰波函数（FOF）合成技术
- [stb_image_write](https://github.com/nothings/stb) 由 Sean Barrett — 单头文件图像写入（MIT / 公共领域）
- [VST3 SDK](https://github.com/steinbergmedia/vst3sdk) 由 Steinberg — 插件框架（MIT）
- [SignPath Foundation](https://signpath.org/) — 为开源项目提供免费Windows代码签名

## 许可证

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---