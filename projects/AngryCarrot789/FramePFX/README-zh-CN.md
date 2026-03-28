# FramePFX

FramePFX 是一个开源的非线性视频编辑器，使用 C# 编写，UI 采用 Avalonia。

## 重制版
我目前正在进行一个完整的重制（在 remake 分支）。主要区别是新的音频引擎，基于音频驱动的播放而非视频，以及基于 TimeSpan 的定位而非帧。

# 文档

这里是一些文档文件的链接，如果你想了解更多前端和后端内容

[插件系统 + FramePFX API](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Plugins.md)

[自动化/动画系统](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Automation.md)

[命令系统，右键菜单系统，快捷键](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Command%20System%20and%20Shortcuts.md)

[渲染系统](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Rendering.md)

[快捷键系统概览](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Shortcuts.md)

[UI 概览](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/TheUI.md)

# 预览

这是使用 Avalonia 的最新版本：
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-06_17.33.20.png)

这里是导出过程的预览。导出按钮位于 文件 > 导出，你指定路径后点击导出。
要取消渲染，只需点击导出进度窗口后面的对话框中的取消按钮

“导出器：FFmpeg”下方的灰色面板是编码器相关详情
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-07_00.13.06.png)

## 可自定义的 GUI！
主题可以根据你的喜好定制。它们可以保存到磁盘并在应用内修改。内置主题（暗色和亮色）不应修改，因为更改不会被保存。你应该创建一个副本并修改该副本
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-29_08.30.49.png)

# 构建

FramePFX 假设所有内容都是 64 位 --- x86/32 位/AnyCPU 将无法正常工作！

本地项目会在你首次构建 C# 项目时自动下载并编译，  
但是，如果你想使用媒体剪辑和导出功能，则需要单独下载 FFmpeg。  
以下是当前可用的具体版本（仅限 Windows）：  
https://github.com/BtbN/FFmpeg-Builds/releases/download/autobuild-2024-09-30-15-36/ffmpeg-N-117275-g04182b5549-win64-gpl-shared.zip

## 下载  
递归克隆项目：

`git clone --recursive https://github.com/AngryCarrot789/FramePFX`

如果你想安装 FFmpeg 以使用视频媒体剪辑和 FFmpeg 导出：  
- 在解决方案中创建 ffmpeg 文件夹：`cd FramePFX && mkdir ffmpeg`  
- 从下载的 ffmpeg 压缩包中，将 4 个目录和 LICENCE.txt 复制到新建的 ffmpeg 文件夹内

> `\FramePFX\ffmpeg\bin` 文件夹中应该有 8 个 DLL 文件，其中一个应为 avcodec-61.dll。如果不是 61，则说明你下载了错误版本的 FFmpeg。  
你可以删除 EXE 文件，因为它们并未被使用。

## 构建项目  
- 打开 FramePFX.sln。你会看到关于 `portaudio` 项目未加载的错误；忽略它，然后通过点击 `构建` 菜单下的 `生成解决方案` 来构建整个解决方案。

希望这样你就能运行并修改 FramePFX 项目而不会有问题。该项目使用 Avalonia 11.2.2 和 .NET 8（C# 12）。

> 不要修改 portaudio 项目，因为它是由 cmake 自动生成的，你的更改可能会被覆盖。

### 仅限 Windows 的命令

解决方案中的项目使用了 Windows 命令如 mkdir 和 xcopy，可能在其他平台无法使用。  
欢迎提交更跨平台解决方案的拉取请求！

### 可能的构建问题  
有时，SkiaSharp nuget 库不会将 skia 库文件复制到 bin 文件夹中，当你克隆此仓库并构建时。以下是我找到的两种解决方法：  
- 将 `\packages\SkiaSharp.2.88.7\runtimes\win-x64\native\libSkiaSharp.dll` 复制到编辑器的 bin 文件夹。  
- 或者，删除解决方案目录中的 `packages` 文件夹，然后在 Visual Studio 中右击解决方案，选择“清理解决方案”，接着点击“还原 Nuget 包”，然后重新构建所有项目。  
  如果以上都不行，尝试在 nuget 管理器中卸载 SkiaSharp 并重新安装。如果还是不行，那我真的不知道是什么问题了...

# 插件！  
FramePFX 现在支持插件！插件 API 仍在大力开发中，但它已经可以加载插件。  
插件目前必须使用与 FramePFX 相同的依赖版本编译，因为我们不使用 AssemblyLoadContext。

您可以在此处找到更多信息：[插件系统 + FramePFX API](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Plugins.md) 

### 示例
`AnotherTestPlugin` 插件添加了一个测试配置页面（位于 `文件 > 打开编辑器设置`），并且还在导出对话框中添加了一个无用的测试导出器。

添加该页面非常简单，可以在插件的 `OnApplicationLoaded` 处理程序中完成：

```cs
public override async Task OnApplicationLoaded() {
    ApplicationConfigurationManager.Instance.RootEntry.AddEntry(new ConfigurationEntry() {
        DisplayName = "Test Plugin Settings", 
        Id = "config.testplugineditorsettings",
        
        // This page is just a PropertyEditor page. 
        // Completely custom xaml pages are a bit wonky at the moment, 
        // only user controls will work properly due to resource dictionaries
        Page = new TestPluginConfigurationPage()
    });
}
```
这导致了：
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-27_03.33.53.png)

# 待办事项
### Avalonia 重制：
- 实现可以拖放到剪辑/轨道中的效果列表的 UI
### 渲染引擎
- 虽然我们可以访问 port-audio，但我认为整个渲染引擎需要彻底重构。
  以前，通过根据项目帧率从剪辑中提取精确字节数来渲染音频。
  然而，这会导致大量爆音，因为播放的 FPS 并不精准。

  视频渲染也需要重做，因为视口通常很小，但我们渲染的是每个剪辑的全尺寸视频帧，
  然后再缩小。这对于矩形和基本图形来说还好。
  然而，从 MP4 文件渲染 4K 视频帧是一个耗时且复杂的任务，然后缩小到 1080p（或剪辑的 MediaScale），
  最后再缩小到视口（通常约为 500x300 尺寸）是极其浪费的，所以我们需要 RenderFull 和
  RenderPreview 方法，或者一个新的渲染系统。当前的异步渲染技术看起来还不错。
### 自动化引擎
- 添加对平滑插值的支持（例如两个关键帧之间的曲线）。我尝试过做这件事，但难以弄清插值的数学，
  同时在 UI 上做命中测试也有困难。
### 剪辑
- AVMediaVideoClip 对于高分辨率视频非常慢（例如，4K 解码和渲染到屏幕大约需要 40 毫秒），
  而且只有少数视频编码格式似乎能正常工作。许多常见文件格式会出现“解码时发现无效数据”错误。
  我对 FFmpeg 了解不多，但希望将来能以某种方式解决这个问题。
- 实现两个剪辑之间的淡入淡出
### 历史系统
- 目前还没有撤销功能。我可能会在实现其他一些功能（如音频和可能的硬件加速最终帧合成）后尝试实现它。
### 需要修复的 Bug
- 导入某些视频文件可能导致渲染失败（出现某种“解码时发现无效数据”错误）
### 多线程同步
- 我们需要创建锁以使访问和修改应用状态更安全，特别是在活动系统工作之后。

  也许可以创建一个应用范围的锁，用于写入模型状态？这类似于 IntelliJ IDEA 的工作方式；一个主要是读的读写锁。
  写锁只能在主线程上获取（我们使用调度器切换到主线程），但任何线程都可以获取读锁。获取读锁需要阻塞直到没有写操作，
  获取写锁需要阻塞直到所有读者完成（并且在尝试获取写锁时会触发一个事件，让读者取消操作以避免界面冻结）

## 贡献
欢迎热情贡献！只需创建一个拉取请求，或先创建问题然后拉取请求，随你喜欢。
你可以向上滚动查看如何编译和运行/调试该应用的信息。
待办事项列表在上面，你也可以直接在代码库中搜索 `// TODO:`。

你可以在 docs 文件夹中找到详细说明，里面解释了编辑器的核心部分（例如
命令、自动化等）。文档还不完善，因此并未涵盖所有内容

代码库并不完美，欢迎大家帮助尝试规范化！

# 许可
FramePFX 中的所有源文件均遵循 GNU 通用公共许可证版本 3.0 或更高版本（GPL v3.0+）。
FramePFX 使用了一些带有其他许可证的库，如 MIT/LGPL 许可证。

如果某个源文件缺少版权声明，则默认其许可证与 FramePFX 相同

当前使用的 LGPL 部分包括：
- FFmpeg.AutoGen，遵循 GNU 较宽松公共许可证版本 3.0（LGPL v3.0）
- FFmpeg




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---