**此 GitHub 仓库（<https://github.com/Genymobile/scrcpy>）是该项目唯一的官方来源。不要从随机网站下载发布版，即使其名称中包含 `scrcpy`。**

# scrcpy（v3.2）

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_发音为 “**scr**een **c**o**py**”_

本应用可镜像通过 USB 或 [TCP/IP](doc/connection.md#tcpip-wireless) 连接的 Android 设备（视频与音频），并允许通过电脑的键盘和鼠标进行控制。它不需要 _root_ 权限或在设备上安装应用。支持 _Linux_、_Windows_ 和 _macOS_。

![截图](assets/screenshot-debian-600.jpg)

其特点为：

 - **轻量**：原生，只显示设备屏幕
 - **高性能**：30~120fps，取决于设备
 - **高画质**：1920×1080 或更高
 - **低延迟**：[35~70ms][lowlatency]
 - **启动快**：~1 秒即可显示首帧画面
 - **非侵入性**：不会在 Android 设备上留下任何安装内容
 - **用户友好**：无需账号、无广告、无需联网
 - **自由**：自由开源软件

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

其功能包括：
 - [音频转发](doc/audio.md)（Android 11+）
 - [录屏](doc/recording.md)
 - [虚拟显示](doc/virtual_display.md)
 - [在 Android 设备屏幕关闭时镜像](doc/device.md#turn-screen-off)
 - [双向复制粘贴](doc/control.md#copy-paste)
 - [可配置画质](doc/video.md)
 - [相机镜像](doc/camera.md)（Android 12+）
 - [作为网络摄像头（V4L2）镜像](doc/v4l2.md)（仅限 Linux）
 - 物理[键盘][hid-keyboard]和[鼠标][hid-mouse]模拟（HID）
 - [手柄](doc/gamepad.md)支持
 - [OTG 模式](doc/otg.md)
 - 以及更多功能……

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## 先决条件

Android 设备需至少为 API 21（Android 5.0）。

[音频转发](doc/audio.md) 支持 API >= 30（Android 11+）。

请确保你已在设备上[启用 USB 调试][enable-adb]。

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

在某些设备（特别是小米）上，你可能会遇到如下错误：

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

此时，你需要启用[额外选项][control]“USB 调试（安全设置）”（与“USB 调试”为不同条目），以便通过键盘和鼠标进行控制。设置后需要重启设备。

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

请注意，运行 scrcpy 的[OTG 模式](doc/otg.md)时无需 USB 调试。

## 获取应用

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md)（请阅读[如何运行](doc/windows.md#run)）
 - [macOS](doc/macos.md)

## 必备技巧

 - [降低分辨率](doc/video.md#size) 可大幅提升性能（`scrcpy -m1024`）
 - [_右键点击_](doc/mouse.md#mouse-bindings)触发 `BACK`（返回）
 - [_中键点击_](doc/mouse.md#mouse-bindings)触发 `HOME`（主页）
 - <kbd>Alt</kbd>+<kbd>f</kbd> 切换[全屏](doc/window.md#fullscreen)
 - 还有许多其他[快捷键](doc/shortcuts.md)

## 使用示例

有许多选项，已在单独页面中[文档化](#user-documentation)。以下为常用示例。

 - 以 H.265 编码（更高画质）捕获屏幕，限制分辨率为 1920，帧率上限为 60fps，禁用音频，并通过物理键盘模拟控制设备：

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # 简写
    ```

 - 在新的虚拟显示屏启动 VLC（与设备屏幕分离）：

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - 以 H.265 编码和 1920x1080 分辨率（含麦克风）录制设备相机到 MP4 文件：

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - 捕获设备前置摄像头并在电脑上作为网络摄像头（Linux）：

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - 通过物理键盘和鼠标模拟控制设备而不镜像屏幕（无需 USB 调试）：

    ```bash
    scrcpy --otg
    ```

 - 用连接在电脑上的手柄控制设备：

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # 简写
    ```

## 用户文档

本应用有丰富的功能和配置选项。详见以下页面：

 - [连接](doc/connection.md)
 - [视频](doc/video.md)
 - [音频](doc/audio.md)
 - [控制](doc/control.md)
 - [键盘](doc/keyboard.md)
 - [鼠标](doc/mouse.md)
 - [手柄](doc/gamepad.md)
 - [设备](doc/device.md)
 - [窗口](doc/window.md)
 - [录屏](doc/recording.md)
 - [虚拟显示](doc/virtual_display.md)
 - [隧道](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [相机](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [快捷键](doc/shortcuts.md)

## 资源

 - [常见问题解答](FAQ.md)
 - [翻译][wiki]（可能不是最新版）
 - [编译说明](doc/build.md)
 - [开发者文档](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki

## 相关文章

- [Introducing scrcpy][article-intro]
- [Scrcpy 现已支持无线连接][article-tcpip]
- [Scrcpy 2.0，带音频][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## 联系方式

你可以通过[提交 issue][issue]报告 bug、需求新功能或提问。

报告 bug 前请先阅读[常见问题](FAQ.md)，也许能立即解决你的问题。

[issue]: https://github.com/Genymobile/scrcpy/issues

你还可以通过：

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)

## 捐助

我是 [@rom1v](https://github.com/rom1v)，_scrcpy_ 的作者及维护者。

如果你喜欢本应用，可以[支持我的开源工作][donate]：
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## 许可证

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    本软件依据 Apache License, Version 2.0（“许可证”）授权；
    除非遵守本许可证，否则不得使用本文件。
    你可以在以下网址获取许可证副本：

        http://www.apache.org/licenses/LICENSE-2.0

    除非适用法律要求或书面同意，依据本许可证分发的软件
    是按“原样”分发，不附任何明示或暗示的保证。
    有关具体权限和限制，请参阅许可证。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---