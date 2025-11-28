
# Sammie-Roto
**S**egment **A**nything **M**odel 与 **M**atting **I**ntegrated **E**legantly

![Sammie-Roto 截图](https://raw.githubusercontent.com/Zarxrax/Sammie-Roto/main/sammie/sammie_screenshot.webp)

Sammie-Roto 旨在成为一个用户友好的 AI 辅助视频剪辑遮罩工具。它作为 Adobe 的 Roto Brush 或 DaVinci Resolve 的 Magic Mask 等商业解决方案的免费替代品。它的准确度通常不及手动转描，但通常可以以较少的努力获得相当不错的结果。

## 试试新的 [Sammie-Roto 2](https://github.com/Zarxrax/Sammie-Roto-2)！

### 更新日志
- [2025/10/31] [Sammie-Roto 2](https://github.com/Zarxrax/Sammie-Roto-2) 现已发布！所有未来更新将在该版本上进行。
- [2025/09/22] 新增 PNG 导出、导入图像序列，修复抠像导出中的错误，支持通过命令行加载视频。
- [2025/08/23] 在导出标签页新增选项，可将各种信息加入文件名。
- [2025/08/16] 新增边界修复滑块，帮助修正画面边缘的遮罩。减少抠像时的显存使用。
- [2025/08/03] 新增去重功能，减少动漫内容边缘的噪点。
- [2025/05/10] 支持导入/导出单张图片。导出设置现可记忆。
- [2025/04/23] 新增 Linux/Mac 安装程序，减少显存消耗，多项改进与错误修复。
- [2025/04/04] 抠像页面新增一些调节滑块。
- [2025/02/26] 通过 [MatAnyone](https://github.com/pq-yang/MatAnyone) 新增人体视频抠像支持，以及众多其他改进。
- [2025/01/26] 初始发布

### 功能特点
- 支持 Windows、Linux 和 Mac
- 简单安装程序自动下载所有依赖和模型
- 最低可在 4GB 显存甚至 CPU 上运行（推荐使用 6GB Nvidia GPU）
- 内置 3 个分割模型：Sam 2.1 Large、Sam 2.1 Base+ 以及 EfficientTAM_s_512x512。
- 支持 MatAnyone 模型进行人体视频抠像。
- 界面简洁易用。
- 支持多对象处理。
- 多种遮罩后处理选项，包括边缘平滑。
- 支持去重以减少动漫内容边缘的噪点。
- 多种导出选项：黑白遮罩、Alpha 通道和绿幕。

### 安装（Windows）：
- 从 [发布页面](https://github.com/Zarxrax/Sammie-Roto/releases) 下载最新 Windows 版本
- 解压缩 zip 文件。
- 运行 'install_dependencies.bat' 并按提示操作。
- 运行 'run_sammie.bat' 启动软件。

所有内容都包含在 Sammie-Roto 文件夹中。如果您想删除该应用程序，只需删除此文件夹。您也可以移动该文件夹。

### 安装（Linux，Mac）
- 确保已安装 [Python](https://www.python.org/)（版本 3.10 或更高）
- 从 [releases](https://github.com/Zarxrax/Sammie-Roto/releases) 下载最新的 Linux/Mac 版本
- 解压缩 zip 文件。
- 打开终端，导航到刚刚从 zip 解压的 Sammie-Roto 文件夹。
- 执行以下命令：`bash install_dependencies.sh`，然后按照提示操作。
- MacOS 用户：双击“run_sammie.command”以启动程序。Linux 用户：`bash run_sammie.command` 或以您喜欢的方式执行该文件。

### 教程
[![Sammie-Roto 教程](https://img.youtube.com/vi/042uKTqlJ_c/0.jpg)](https://www.youtube.com/watch?v=042uKTqlJ_c)

### 致谢
* [SAM 2](https://github.com/facebookresearch/sam2)
* [EfficientTAM](https://github.com/yformer/EfficientTAM)
* [MatAnyone](https://github.com/pq-yang/MatAnyone)
* [Wan2GP](https://github.com/deepbeepmeep/Wan2GP)（用于优化 MatAnyone）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-28

---