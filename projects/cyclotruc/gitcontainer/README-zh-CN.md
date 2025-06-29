![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**将任何 GitHub 仓库转化为可用于生产环境的 Docker 容器，支持 AI 驱动的 Dockerfile 生成。**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer 是一个 AI 驱动的 Web 应用，通过分析 GitHub 仓库自动生成可用于生产环境的 Dockerfile。只需粘贴 GitHub 仓库链接，即可获得智能选择基础镜像、依赖管理及符合 Docker 最佳实践的定制 Dockerfile。

## 🌟 快速访问

只需将任何 GitHub 仓库链接中的 `github.com` 替换为 `gitcontainer.com`，即可立即进入该仓库的 Dockerfile 生成页面。

例如：
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ 功能亮点

- **🔄 即时 URL 访问**：只需将 GitHub 链接中的 'github.com' 替换为 'gitcontainer.com'
- **🤖 AI 驱动分析**：利用 OpenAI GPT-4 分析仓库结构，智能生成 Dockerfile
- **⚡ 实时流式传输**：通过 WebSocket 流式传输，实时观看 AI 生成 Dockerfile
- **🎯 智能识别**：自动识别技术栈（Python、Node.js、Java、Go 等）
- **🔧 生产级标准**：遵循最佳实践生成 Dockerfile，具备安全性、多阶段构建及优化
- **📋 附加指令**：可添加自定义要求，满足特殊环境需求
- **📄 Docker Compose**：复杂应用可自动建议 docker-compose.yml
- **🎨 现代 UI**：简洁、响应式界面，内置 Monaco 编辑器高亮语法
- **📱 移动友好**：桌面与移动端无缝使用

## 🚀 快速开始

### 先决条件

- Python 3.9 或更高版本
- Git
- OpenAI API key

### 安装步骤

1. **克隆仓库：**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **安装依赖：**
   ```bash
   pip install -r requirements.txt
   ```

3. **配置环境变量：**
   ```bash
   # 创建 .env 文件
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **运行应用：**
   ```bash
   python app.py
   ```

5. **打开浏览器：**
   访问 `http://localhost:8000`

## 🛠️ 工作原理

1. **URL 处理**：将 GitHub 链接中的 'github.com' 替换为 'gitcontainer.com' 即可访问任意仓库
2. **仓库克隆**：Gitcontainer 使用 Git 本地克隆 GitHub 仓库
3. **代码分析**：利用 [gitingest](https://github.com/cyclotruc/gitingest) 分析仓库结构并提取相关信息
4. **AI 生成**：将分析结果和专用提示词发送给 OpenAI GPT-4 以生成 Dockerfile
5. **智能优化**：AI 会考虑以下因素：
   - 技术栈识别
   - 依赖管理
   - 安全最佳实践
   - 需要时采用多阶段构建
   - 端口配置
   - 环境变量
   - 健康检查

## 📁 项目结构

```
cyclotruc-gitcontainer/
├── app.py                 # 主 FastAPI 应用
├── requirements.txt       # Python 依赖
├── .env                  # 环境变量（需自行创建）
├── static/               # 静态资源（图标、CSS）
├── templates/
│   └── index.jinja       # 主要 HTML 模板
└── tools/                # 核心功能模块
    ├── __init__.py
    ├── create_container.py  # AI Dockerfile 生成
    ├── git_operations.py    # GitHub 仓库克隆
    └── gitingest.py        # 仓库分析
```
## 🔧 配置

### 环境变量

| 变量 | 描述 | 是否必填 |
|------|------|----------|
| `OPENAI_API_KEY` | 您的 OpenAI API 密钥 | 是 |
| `PORT` | 服务器端口（默认：8000） | 否 |
| `HOST` | 服务器主机（默认：0.0.0.0） | 否 |

### 高级用法

您可以以编程方式使用这些工具：

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # 克隆仓库
    clone_result = await clone_repo_tool(github_url)
    
    # 使用 gitingest 进行分析
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # 生成 Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# 用法
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 个性化定制

### 添加自定义指令

使用“附加指令”功能进行生成自定义：

- `"使用 Alpine Linux 以减小镜像体积"`
- `"包含 Redis 和 PostgreSQL"`
- `"为生产部署进行优化"`
- `"添加开发工具以便调试"`

## 📝 许可证

本项目采用 MIT 许可证，详见 [LICENSE](LICENSE) 文件。

## 🙏 鸣谢

- **[OpenAI](https://openai.com/)** 提供 GPT-4 API
- **[gitingest](https://github.com/cyclotruc/gitingest)** 提供仓库分析功能
- **[FastAPI](https://fastapi.tiangolo.com/)** 优秀的 Web 框架
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** 代码语法高亮工具

## 🔗 链接

- **GitHub 仓库**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **演示**: 通过示例仓库在线试用
- **问题反馈**: [报告 Bug 或请求功能](https://github.com/cyclotruc/gitcontainer/issues)

---

**由 [Romain Courtois](https://github.com/cyclotruc) ❤️ 制作**

*让任何仓库秒变容器！*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---