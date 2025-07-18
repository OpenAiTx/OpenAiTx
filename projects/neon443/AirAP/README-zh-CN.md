<div align="center"> 
    <br/>
    <p>
        <img src="https://github.com/neon443/AirAP/blob/main/AirAP/Assets.xcassets/AppIcon.appiconset/Icon.png?raw=true" title="cobalt" alt="cobalt logo" width="100" />
    </p>
    <p>
        将你的 iPhone 用作 AirPlay 接收器
        <br/>
        <a href="https://neon443.github.io">
            由 neon443 制作
        </a>
    </p>
    <p>
        <a href="https://testflight.apple.com/join/8aeqD8Q2">
            TestFlight 测试版
        </a>
    </p>
    <br/>
</div>

<div align="center">
  <a href="https://shipwrecked.hackclub.com/?t=ghrm" target="_blank">
    <img src="https://hc-cdn.hel1.your-objectstorage.com/s/v3/739361f1d440b17fc9e2f74e49fc185d86cbec14_badge.png" 
         alt="该项目是 Shipwrecked 的一部分，世界上首个岛屿黑客马拉松！" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP 是一个完全原生的 AirPlay 服务器，使用 Swift 编写，适用于 iOS。基本上，AirAP 允许你将 iPhone 用作 iTunes 或 Mac 上的 AirPlay 接收器，这意味着你可以使用 iPhone 播放设备的声音。

## 什么是 AirAP？

你是否曾想过将音频从 Mac、Apple TV 或其他 iOS 设备流式传输到你的 iPhone？AirAP 通过实现一个在 iOS 上本地运行的完整 AirPlay 服务器，使这一切成为可能。安装后，你的 iPhone 将出现在系统偏好设置的音频面板、Music.app 或任何其他兼容 AirPlay 的应用程序中的可用 AirPlay 目标列表中。

这一概念起初可能显得有些反常——毕竟，我们习惯了从 iPhone 向其他设备流媒体传输。但实际上，有许多场景你会想反向操作。也许你在深夜使用 Mac 工作，想将音频路由到带耳机的 iPhone，以免打扰他人（嗨 👋）。也许你是开发者，测试音频应用时需要快速切换不同的输出设备。或者你只是想重新利用那台旧的有线扬声器。

## 安装 AirAP

要试用，请[打开此 TestFlight 链接](https://testflight.apple.com/join/8aeqD8Q2)，安装 AirAP 并按照说明操作。安装完成后，只需启动 AirAP，确保你的 iPhone 与要流式传输音频的设备连接到同一个 Wi-Fi 网络。你的 iPhone 会自动出现在 AirPlay 设备列表中，准备接收音频——如果没有，尝试重启应用。

## 编译

确保你已安装 [homebrew](https://brew.sh)
```
brew install carthage
git clone https://github.com/neon443/AirAP
cd AirAP
carthage checkout
open AirAP.xcodeproj
```
After adding your Team ID in Project > AirAP > Signing and Capabilities, hit `Command + R` to build and run! 

### thanks to

[qasim/Airstream](https://github.com/qasim/Airstream)
[shairplay](https://github.com/juhovh/shairplay)
would not have been possible without these

---

<sup>
&copy; 2025 Nihaal Sharma. AirPlay, iPhone, iTunes, Mac, and Apple TV are trademarks of Apple Inc.
</sup>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---