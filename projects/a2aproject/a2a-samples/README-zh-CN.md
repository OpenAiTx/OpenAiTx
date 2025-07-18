<translate-content># Agent2Agent (A2A) 示例

本仓库包含使用 [Agent2Agent (A2A) 协议](https://goo.gle/a2a) 的代码示例和演示。

## 相关仓库

- [A2A](https://github.com/a2aproject/A2A) - A2A 规范和文档。
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK。
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - 用于检查启用 A2A 的代理的 UI 工具。

## 贡献

欢迎贡献！请参阅[贡献指南](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)。

## 获取帮助

请使用[问题页面](https://github.com/a2aproject/a2a-samples/issues)提供建议、反馈或提交错误报告。

## 免责声明

本仓库本身并非谷歌官方支持的产品。仓库中的代码仅供演示用途。

重要提示：所提供的示例代码用于演示 Agent-to-Agent (A2A) 协议的工作机制。在构建生产应用时，务必将任何不在您直接控制下的代理视为潜在的不可信实体。

所有来自外部代理的数据——包括但不限于其 AgentCard、消息、工件和任务状态——都应视为不可信输入。例如，恶意代理可能提供包含精心制作数据字段（如描述、名称、技能描述）的 AgentCard。如果在未经清理的情况下将这些数据用于构建大型语言模型（LLM）的提示，可能会使您的应用暴露于提示注入攻击中。未能在使用前正确验证和清理这些数据，可能会给您的应用带来安全漏洞。

开发者有责任实施适当的安全措施，如输入验证和凭证的安全处理，以保护其系统和用户。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---