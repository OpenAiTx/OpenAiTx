# ByeTunes 🎵

**告别 iTunes 同步！**

ByeTunes 是一款原生 iOS 应用，允许你将音乐（MP3、M4A、FLAC、WAV）和铃声直接注入到设备的媒体库中——无需每次同步都连接电脑。它直接与 iOS 媒体数据库通信，让你掌控音乐管理的主动权。

## 功能

-   **直接注入音乐**：无需电脑即可添加歌曲到 Apple Music 库。
-   （暂时禁用）**铃声管理器**：注入自定义铃声（`.m4r` 和 `.mp3` 自动转换）。
-   **播放列表支持**：随时创建和管理播放列表。
-   **无需电脑**（设置完成后）：配对后即可自由使用！
-   **元数据编辑**：自动从 iTunes 或 Deezer 获取。

## 编译说明

要自行构建 ByeTunes，你需要一台安装了 Xcode 的 Mac。

### 前置条件

1.  **Xcode**：建议使用 15 版本及以上。
2.  **iOS 设备**：运行 iOS 16.0 或更高版本。

### 外部库

ByeTunes 依赖 `idevice`（`libimobiledevice` 的替代品）与 iOS 内部文件系统通信。**出于许可和体积原因，这些文件未包含在本仓库中**。

编译应用时，你需要获取以下两个文件并放置于 `MusicManager/` 目录下：

1.  `libidevice_ffi.a`（静态库）
2.  `idevice.h`（头文件）

你可以在这里找到 idevice 并进行编译：[https://github.com/jkcoxson/idevice](https://github.com/jkcoxson/idevice)

*如果没有这些文件，项目将无法编译。*

### 构建步骤

1.  安装 Rust：
    ```bash
    curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
    ```
2.  添加 iOS 架构：
    ```bash
    rustup target add aarch64-apple-ios
    ```
    
3.  如果您尚未安装，请安装 Xcode 命令行工具：
    ```bash
    xcode-select --install
    ```

4.  克隆仓库：
    ```bash
    git clone https://github.com/jkcoxson/idevice
    ```

5.  设置部署目标：
    ```bash
    export IPHONEOS_DEPLOYMENT_TARGET=xx.x
    ```

6.  运行 cargo build:
    ```bash
    cargo build --release --package idevice-ffi --target aarch64-apple-ios
    ```
在idevice文件夹内找到：idevice.h 和 libidevice_ffi.a。将它们移动到Xcode项目中，确保创建 **Bridging-Header.h**  
在你的Xcode项目中，并确保添加：

 ```bash
    #import "idevice.h"
```

**在项目设置 > 构建阶段 > 连接二进制与库中，确保列出了 libidevice_ffi.a。**

## 使用方法

1. **LocalDevVPN**：
    - 从 App Store/Altstore PAL 下载 LocalDevVPN https://apps.apple.com/us/app/localdevvpn/id6755608044。
    - 打开后点击连接，你需要一个活动连接才能导入应用内的配对文件。

2.  **配对**：
    -   第一次启动时，你会看到“导入配对文件”界面。
    -   你需要获取一个`配对文件`。
    -   下载 idevice_pair，参考 https://github.com/jkcoxson/idevice_pair 。
    -   生成你的`配对文件`。
    -   从电脑导出并通过 AirDrop/保存到你的 iPhone。
    -   在 ByeTunes 中导入它。
      
3.  **添加音乐**：
    -   点击“添加歌曲”，从文件应用中选择文件。
    -   点击“注入到设备”，见证神奇发生。
      
4.  **铃声**：
    -   进入铃声标签，添加你的文件，注入即可！

## 注意事项

-   **签名应用**：如果通过签名服务（Signulous、AltStore 等）安装，应用包含一个修复（`asCopy: true`），确保文件导入正常且不崩溃。
-   **备份**：在操作数据库注入前，最好备份你的音乐库！

## 支持与错误报告

发现了错误？我们很乐意修复！

1.  **报告问题**：在 [GitHub Issues](https://github.com/EduAlexxis/ByeTunes/issues) 提交工单。
2.  **加入社区**：在 [Discord](https://discord.gg/dDQ4P4SyKJ) 与我们聊天。
3.  **附加调试日志**：
    *   如果注入失败，请在设置里删除库下使用**调试选项**。
    *   这里有“调试日志”界面，可复制应用日志。
    *   请将日志附在问题报告中——这有助于我们更快解决问题！

---
*由 EduAlexxis ❤️ 制作*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-04

---