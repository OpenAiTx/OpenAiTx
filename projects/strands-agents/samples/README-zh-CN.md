<div align="center">
  <div>
    <a href="https://strandsagents.com">
      <img src="https://strandsagents.com/latest/assets/logo-auto.svg" alt="Strands Agents" width="55px" height="105px">
    </a>
  </div>

  <h1>
    Strands Agents 示例
  </h1>

  <h2>
    一种通过几行代码构建 AI 代理的模型驱动方法。
  </h2>

  <div align="center">
    <a href="https://github.com/strands-agents/samples/graphs/commit-activity"><img alt="GitHub commit activity" src="https://img.shields.io/github/commit-activity/m/strands-agents/samples"/></a>
    <a href="https://github.com/strands-agents/samples/issues"><img alt="GitHub open issues" src="https://img.shields.io/github/issues/strands-agents/samples"/></a>
    <a href="https://github.com/strands-agents/samples/pulls"><img alt="GitHub open pull requests" src="https://img.shields.io/github/issues-pr/strands-agents/samples"/></a>
    <a href="https://github.com/strands-agents/samples/blob/main/LICENSE"><img alt="License" src="https://img.shields.io/github/license/strands-agents/samples"/></a>
  </div>
  
  <p>
    <a href="https://strandsagents.com/">文档</a>
    ◆ <a href="https://github.com/strands-agents/samples">示例</a>
    ◆ <a href="https://github.com/strands-agents/sdk-python">Python SDK</a>
    ◆ <a href="https://github.com/strands-agents/tools">工具</a>
    ◆ <a href="https://github.com/strands-agents/agent-builder">代理构建器</a>
    ◆ <a href="https://github.com/strands-agents/mcp-server">MCP 服务器</a>
  </p>
</div>

欢迎来到 Strands Agents 示例仓库！

探索易于使用的示例，开始使用 <a href="https://strandsagents.com">Strands Agents</a>。

本仓库中的示例仅供 **演示和教育用途**。它们展示了概念和技术，但 **不适合直接用于生产环境**。在生产环境中使用前，请始终执行适当的 **安全** 和 **测试** 过程。

## 📚 目录

- [📚 目录](#-目录)
- [🏁 快速开始](#-快速开始)
  - [步骤 1：安装所需包](#步骤-1安装所需包)
  - [步骤 2：设置模型提供者](#步骤-2设置模型提供者)
  - [步骤 3：构建你的第一个 Strands 代理](#步骤-3构建你的第一个-strands-代理)
  - [步骤 4：开始使用 SDK](#步骤-4开始使用-sdk)
  - [步骤 5：探索更多示例](#步骤-5探索更多示例)

## 🏁 快速开始

### 步骤 1：安装所需包

```bash
pip install strands-agents
pip install strands-agents-tools
```
### 第2步：设置模型提供者

按照[此处](https://strandsagents.com/latest/user-guide/quickstart/#model-providers)的说明配置您的模型提供者和模型访问。

### 第3步：构建您的第一个Strands代理


```python
from strands import Agent, tool
from strands_tools import calculator, current_time, python_repl

@tool
def letter_counter(word: str, letter: str) -> int:
    """
    Count the occurrences of a specific letter in a word.
    """
    if not isinstance(word, str) or not isinstance(letter, str):
        return 0
    if len(letter) != 1:
        raise ValueError("The 'letter' parameter must be a single character")
    return word.lower().count(letter.lower())

agent = Agent(tools=[calculator, current_time, python_repl, letter_counter])

message = """
I have 4 requests:

1. What is the time right now?
2. Calculate 3111696 / 74088
3. Tell me how many letter R's are in the word "strawberry" 🍓
4. Output a script that does what we just spoke about!
   Use your python tools to confirm that the script works before outputting it
"""

agent(message)
```
### 第4步：开始使用SDK

从[01-tutorials](./01-tutorials/)目录开始。  
创建你的[第一个代理](./01-tutorials/01-fundamentals/01-first-agent/)，并探索涵盖核心功能的基于笔记本的示例。

### 第5步：探索更多示例

寻找灵感？  
查看[02-samples](./02-samples/)文件夹中的更多示例，了解实际应用案例。

## 贡献 ❤️

我们欢迎贡献！详情请参阅我们的[贡献指南](https://raw.githubusercontent.com/strands-agents/samples/main/CONTRIBUTING.md)，内容包括：  
- 报告错误和功能需求  
- 开发环境设置  
- 通过拉取请求贡献  
- 行为准则  
- 安全问题报告

## 许可证

本项目采用Apache许可证2.0版授权 - 详情见[LICENSE](LICENSE)文件。

## 安全

更多信息请参阅[CONTRIBUTING](https://raw.githubusercontent.com/strands-agents/samples/main/CONTRIBUTING.md#security-issue-notifications)。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---