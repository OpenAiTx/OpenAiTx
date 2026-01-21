媒体下载器项目
![Media Downloader logo](https://raw.githubusercontent.com/yuri-maxiutenko/MediaDownloader/master/MediaDownloader/Images/icon.png)
====================
只是一个基于出色的视频下载命令行工具 [yt-dlp](https://github.com/yt-dlp/yt-dlp) 的小型用户友好型 UI 包装器（C#/WPF，.NET），允许从各种互联网资源（YouTube、Vimeo、Facebook 等）下载不同质量的视频。也支持下载播放列表。

## 主要功能

**媒体下载器** 能够下载几乎所有主流平台（YouTube、Vimeo、Facebook 等）的视频。只需提供链接，即可搞定！播放列表的链接同样支持。

目前应用程序支持以下下载格式：

* 最佳质量视频
* 最佳质量 MP4 视频
* 可通过直接链接获得的最佳质量视频
* 仅音频

此外，**媒体下载器** 支持下载历史记录并保存最近使用的文件夹列表。

附带安装程序，包含所有必要组件：应用程序本身、[yt-dlp](https://github.com/yt-dlp/yt-dlp) 和 [FFmpeg](https://ffmpeg.org/) 转换器。

应用程序安装到当前用户的 AppData 文件夹，无需管理员权限。

目前 **媒体下载器** 支持英语和俄语两种语言。应用语言根据当前 Windows 区域自动选择。

## 系统要求

从版本 **2.1** 起，应用程序使用 **[.NET 7 桌面运行时](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)**。但您无需安装它，因为媒体下载器作为 **[自包含应用程序](https://devblogs.microsoft.com/dotnet/app-trimming-in-net-5/)** 提供。

此外，**yt-dlp** 需要 **[Microsoft Visual C++ 2010 可再发行组件包 (x86)](https://www.microsoft.com/en-us/download/details.aspx?id=5555)**。

## 截图

视频下载进行中：
![Video download in progress](https://github.com/yuri-maxiutenko/MediaDownloader/blob/master/Screenshots/Annotation%202020-06-29%20210558.png?raw=true)

视频下载完成：
![Video download complete](https://github.com/yuri-maxiutenko/MediaDownloader/blob/master/Screenshots/Annotation%202020-06-29%20210909.png?raw=true)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-21

---