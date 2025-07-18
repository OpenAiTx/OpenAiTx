# Agent2Agent (A2A) 示例

<div style="text-align: right;">
  <details>
    <summary>🌐 语言</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

本仓库包含使用 [Agent2Agent (A2A) 协议](https://goo.gle/a2a) 的代码示例和演示。

## 相关仓库

- [A2A](https://github.com/a2aproject/A2A) - A2A 规范与文档。
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK。
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - 用于检查支持 A2A 代理的 UI 工具。

## 贡献指南

欢迎贡献！请参阅 [贡献指南](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)。

## 获取帮助

请使用 [问题页面](https://github.com/a2aproject/a2a-samples/issues) 提出建议、反馈或提交 Bug 报告。

## 免责声明

本仓库本身不是 Google 官方支持的产品。本仓库中的代码仅用于演示目的。

重要提示：所提供的示例代码仅用于演示，并说明了 Agent-to-Agent (A2A) 协议的机制。在构建生产应用时，必须将任何不在您直接控制下运行的代理视为潜在的不可信实体。

从外部代理接收的所有数据——包括但不限于其 AgentCard、消息、工件和任务状态——都应视为不可信输入。例如，恶意代理可能会在其 AgentCard 的字段（如 description、name、skills.description）中提供伪造数据。如果这些数据未经清洗就用于构建大型语言模型（LLM）的提示，可能会导致您的应用受到提示注入攻击。未能在使用前正确验证和清理这些数据，可能会给您的应用带来安全风险。

开发者有责任实施适当的安全措施，如输入验证和凭证安全处理，以保护其系统和用户。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---