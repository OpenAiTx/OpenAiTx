# VANB (视频音频网络桥)
# VANB (视频助手 NDI 桥)
# VANB (哇!! NB)

VANB 是一个基于 GStreamer 的视频/音频流转换工具，支持 NDI 与 RTMP 协议间的双向转换。它允许将 NDI 源推流到 RTMP 服务器，或将 RTMP 流转换为 NDI 输出。

本项目使用 [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) 许可证开源。

## 支持平台

目前主要支持以下平台：
- macOS (Apple Silicon)

## 环境要求

### 系统依赖
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### 安装步骤
1. 安装 [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. 通过 Homebrew 安装 GStreamer
```bash
brew install --cask --zap gstreamer-development
```

3. 克隆项目仓库
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. 安装 Python 依赖
```bash
pip install -r requirements.txt
```

5. 配置环境变量 (参考 .env 文件)
```bash
# 配置 NDI SDK 路径
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# 配置 GStreamer 插件路径
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## 使用方法

### NDI 转 RTMP (发送端)
```bash
python vanb_tx.py
```
程序会自动扫描可用的 NDI 源，并提示输入 RTMP 推流地址。

### RTMP 转 NDI (接收端)
```bash
python vanb_rx.py
```
输入 RTMP 拉流地址后，程序会自动创建一个新的 NDI 输出。

## 开发状态

### 已实现功能
- ✓ NDI 到 RTMP 的转换
- ✓ RTMP 到 NDI 的转换
- ✓ 自动帧率和分辨率适配
- ✓ 音视频同步
- ✓ NDI 源自动扫描
- ✓ NDI 输出自动命名
- ✓ VideoToolbox 硬件编解码

### 待实现功能
- ⨯ 配置文件支持 (Profile/config.json)
  - 通过配置文件控制输入输出参数
  - 支持多种转码预设配置
  - 可配置缓冲区大小和延迟参数
  - 支持转码质量和性能平衡配置
- ⨯ 多路流并发处理

## 许可声明

⚠️ **重要提示：许可与合规性**

### 软件许可证

本项目采用 [GNU 通用公共许可证 v3.0](https://www.gnu.org/licenses/gpl-3.0.html) 进行许可。

选择 GPL-3.0 许可证的原因：
1. 本项目使用了多个 GPL 许可的 GStreamer 插件：
   - `x264`: H.264视频编码器 (GPL)
   - `x265`: HEVC/H.265视频编码器 (GPL)
   - `faad`: AAC音频解码器 (GPL)
2. 根据 GPL 的传染性条款，使用 GPL 组件的软件也必须采用 GPL 许可证
3. 选择 GPL-3.0 可以确保与所有依赖组件的许可证兼容

### 许可证要求

使用本项目时，您必须遵守以下要求：
1. **代码开源**: 如果您修改了本项目的代码或将其整合到您的项目中，必须开源您的完整源代码
2. **保持许可证**: 您的项目必须继续使用 GPL-3.0 许可证
3. **版权声明**: 您必须保留原始版权声明和许可证声明
4. **显著注明**: 如果您修改了代码，必须显著注明您所做的改动
5. **专利授权**: GPL-3.0 包含明确的专利授权条款

### GStreamer 组件许可
1. 本项目仅用于开发和测试目的
2. NDI® 是 NewTek, Inc. 的注册商标
3. 使用本项目需要遵守 NewTek NDI® SDK 许可协议
4. 在生产环境中使用前，请确保已获得所有必要的许可和授权

## 问题反馈

如遇到问题，请：
1. 检查是否正确配置了环境变量
2. 确认 GStreamer 插件是否正确安装
3. 查看日志文件中的详细错误信息
4. 通过 Issues 反馈问题，并附上日志和环境信息

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---