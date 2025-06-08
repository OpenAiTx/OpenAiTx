# Node HL7 Client

> 一个纯 TypeScript 的 HL7 客户端，适用于 Node.js，实现与 HL7 服务器的无缝通信。

`node-hl7-client` 是一个轻量级、无依赖的库，专为与 HL7 中间件/服务器的高性能通信而构建。它支持发送格式正确的 HL7 消息、处理响应，并能处理单条和批量 HL7 消息格式（MSH、BHS 和 FHS）。

## ✨ 特性

* ⚡ **零外部依赖** —— 超快性能，无冗余。
* 🔁 **自动重连与重试** —— 自动处理连接中断。
* 🧠 **TypeScript + 类型定义** —— 完全类型化，适合现代开发环境。
* 🤝 **配套包可用** —— 可与 [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) 搭配使用，实现完整 HL7 解决方案。
* 💻 **跨平台支持** —— 适用于 Windows、macOS 和 Linux。
* 🧭 **基于标准** —— 类型化构建器确保 MSH、BHS 和 FHS 段遵循 HL7.org 规范。

## 📦 安装

```bash
npm install node-hl7-client
```

## 📚 包含内容

* **HL7 客户端** —— 连接远程 HL7 服务器，发送消息并处理响应。
* **HL7 解析器** —— 将原始 HL7 消息字符串解析为可访问的段。
* **HL7 构建器** —— 构建有效的 HL7 消息、批量消息或完整的 HL7 批量文件。

## 🧾 目录

1. [关键词定义](#keyword-definitions)
2. [文档](#documentation)
3. [致谢](#acknowledgements)
4. [许可证](#license)

## 关键词定义

本 NPM 包旨在支持对患者护理和诊断可能产生影响的医疗应用。本文档及其配套包 [node-hl7-server](https://www.npmjs.com/package/node-hl7-server) 为清晰和互操作性，使用以下标准化定义：

如 **“MUST”**、**“MUST NOT”**、**“REQUIRED”**、**“SHALL”**、**“SHALL NOT”**、**“SHOULD”**、**“SHOULD NOT”**、**“RECOMMENDED”**、**“MAY”** 和 **“OPTIONAL”** 等关键词在整个文档中均保持一致。这些术语即使未大写，也保留其含义。

* **MUST** —— 此词，或 **“REQUIRED”** 或 **“SHALL”**，表示规范的绝对要求。
* **MUST NOT** —— 此短语，或 **“SHALL NOT”**，表示规范的绝对禁止。
* **SHOULD** —— 此词，或 **“RECOMMENDED”**，表示在特定情况下可能有充分理由忽略某项内容，但在这样做之前必须充分理解并权衡其全部影响。
* **SHOULD NOT** —— 此短语，或 **“NOT RECOMMENDED”**，表示在特定情况下该行为可能是可接受的或有用的。在实施前应充分理解其影响并仔细权衡。
* **MAY** —— 此词，或 **“OPTIONAL”**，表示该项为真正的可选项。不包含某选项的实现 **MUST** 仍需与包含该选项的实现互操作，尽管可能功能有所减少。同理，包含选项的实现 **MUST** 也需与不包含选项的实现互操作（当然，除该选项所提供的特定功能外）。

## 📖 文档

完整的 API 文档、使用示例及高级配置均可在项目网站获取：
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 致谢

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) —— 连接逻辑的灵感来源。
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) —— 解析器和构建器的设计参考。
* 我的妻子和女儿 —— 感谢她们的爱、耐心与鼓励。

## 📄 许可证

MIT © [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---