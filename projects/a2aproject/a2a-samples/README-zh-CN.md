# Agent2Agent (A2A) 示例

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="在 Firebase Studio 中试用"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh">简体中文</a>
    </div>
  </details>
</div>

本仓库包含使用 [Agent2Agent (A2A) 协议](https://goo.gle/a2a) 的代码示例和演示。

## 相关仓库

- [A2A](https://github.com/a2aproject/A2A) - A2A 规范与文档。
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK。
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - 用于检查支持 A2A 代理的 UI 工具。

## 贡献

欢迎贡献！请参阅 [贡献指南](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)。

## 获取帮助

请使用 [问题页面](https://github.com/a2aproject/a2a-samples/issues) 提供建议、反馈或提交错误报告。

## 免责声明

本仓库本身并非 Google 官方支持的产品。仓库中的代码仅用于演示目的。

重要提示：所提供的示例代码仅用于展示 Agent-to-Agent (A2A) 协议的机制。在构建生产级应用时，务必将任何非直接控制的代理视为潜在不受信任的实体。

从外部代理接收的所有数据——包括但不限于其 AgentCard、消息、工件和任务状态——都应作为不受信任的输入进行处理。例如，恶意代理可能会在其 AgentCard 字段（如描述、名称、skills.description）中提供精心构造的数据。如果在构建大型语言模型（LLM）提示时未进行数据清理，可能会使您的应用暴露于提示注入攻击。未能在使用前正确验证和清理这些数据，可能会给您的应用带来安全漏洞。

开发者有责任实施适当的安全措施，如输入验证和凭据安全处理，以保护其系统和用户。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---