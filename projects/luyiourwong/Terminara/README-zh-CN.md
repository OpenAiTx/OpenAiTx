# Terminara

[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)

一个基于终端的 AI 模拟游戏。

## 使用方法

您可以从[最新版本](https://github.com/luyiourwong/Terminara/releases/latest)下载可执行应用程序。

完整压缩包包含可执行文件和默认世界设置文件。如果您只是更新游戏到最新版本，可以只下载可执行文件。

| 操作系统   | 版本                                               |
|---------|--------------------------------------------------|
| Windows | Windows 10, Windows 11                           |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS |
| MacOS   | macOS 13, macOS 14, macOS 15, macOS 26           |

<details>
<summary><strong>手动运行</strong></summary>

### 安装

1.  **克隆仓库：**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **创建虚拟环境：**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    在 Windows 上，使用 `.venv\Scripts\activate`

3.  **安装依赖项：**
    ```bash
    pip install -e .
    ```

### 启动方法 1：使用已安装的命令（推荐）
安装完成后，运行游戏命令：
```bash
terminara
```

### 启动方法2：直接执行
跨平台方式
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
在 Windows 上，使用 `terminara\main.py`

更多信息，请参见 [贡献与开发指南](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)。
</details>

## AI 设置

启动应用程序后，您需要从主菜单配置 AI 设置。

![AI 设置](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

您需要填写以下字段：（兼容 OpenAI API）
- **Host**：API 端点。留空将使用默认的 OpenAI 端点。
- **API Key**：您的 AI 服务 API 密钥。
- **Model**：您想使用的模型。

点击“应用”以保存设置。

### 示例

#### 1. [OpenAI](https://platform.openai.com/)（默认）
- **Host**：（留空）
- **API Key**：`YOUR_OPENAI_API_KEY`
- **Model**：`gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**：`https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**：`YOUR_GEMINI_API_KEY`
- **Model**：`gemini-2.0-flash`

## 世界设置

### 配置存储
世界设置存储在 `terminara/data/worlds` 目录中。（完整版）
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### 创建一个新世界
这里有一个示例世界 [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json)。你可以参考 [schema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) 来创建一个新世界。

## 链接

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [GitHub 仓库](https://github.com/luyiourwong/Terminara)
- [贡献与开发指南](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## 许可

本项目采用 [MIT 许可证](LICENSE) 许可。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---