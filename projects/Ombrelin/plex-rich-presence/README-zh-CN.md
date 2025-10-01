> [!WARNING]  
>  **项目状态**
> 本项目仅处于维护模式。由于我不再是PLEX用户，我将不会为该项目开发新功能。
> 但是，我仍会审查和整合贡献，如果您想开发特定功能，欢迎提交PR。

# Plex Rich Presence

Plex Rich Presence 是一个跨平台的 .NET 6 GUI 应用程序，允许您在 Discord Rich Presence 状态中显示当前的 PLEX 会话。

<img src="https://github.com/Ombrelin/plex-rich-presence/blob/master/src/PlexRichPresence.UI.Avalonia/Assets/plex-rich-presence.png?raw=true" width="250" height="250">

2.1 版本的新功能：

- 在丰富状态中动态显示媒体缩略图

2.0 版本的新功能：

- 支持非管理员用户
- 支持选择服务器
- CLI 版本
- PLEX 单点登录

## 版本发布

Windows 和 Linux 的发布版本可在 [这里](https://github.com/Ombrelin/plex-rich-presence/releases/latest) 找到

## 截图

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/login.png)

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/server.png)

![screenshots](https://raw.githubusercontent.com/Ombrelin/plex-rich-presence/master/screenshots/activity.png)

## 从源码构建与运行

需要 .NET 8+ SDK

```
cd src/PlexRichPresence.UI.Avalonia
dotnet run
```
## 使用的库

- AvaloniaUI  
- .NET MVVM 工具包  
- Microsoft DI  
- Moq  
- PlexApi  
- Discord RPC .NET  
- FluentAssertions  

## 特别感谢

[@GrandKhan] 设计的标志  

感谢 [Discord](https://discord.com/) 和 [PLEX 媒体服务器](https://plex.tv)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-01

---