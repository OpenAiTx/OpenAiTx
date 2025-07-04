![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

一个高效、自给自足的 Python AI Agent 框架，利用 OpenAI Python SDK 解释自然语言指令，动态生成并执行代码，同时无缝管理其运行环境。该框架具备自动依赖安装、安全环境配置、结构化日志记录，以及极简插件接口，可嵌入强大的 Python 工具——所有功能均基于宽松的 Apache 2.0 许可证。

## ⭐ Star 历史

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 环境搭建

### Python 虚拟环境
在搭建项目之前，建议创建一个虚拟环境。请按照以下步骤操作：

了解虚拟环境：[Python 打包指南](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

创建并激活虚拟环境：

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### 项目搭建
该项目需要 OpenAI API 密钥才能运行。请在项目根目录下创建 .env 文件，内容如下：
```
OPENAI_API_KEY=
```
或者你可以复制提供的 .env.example 文件并更新密钥：
```
cp .env.example .env
```

## 🧠 启动
启动 agent，只需运行：
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ 贡献

欢迎贡献、建议、报告 bug 和修复！

如需新增功能、组件或扩展，请先提交 Issue 并讨论，再提交 PR。

## 💖 感谢所有为本项目做出贡献的人
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---