![横幅图片](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n - 为技术团队打造的安全工作流自动化平台

n8n 是一款工作流自动化平台，为技术团队提供代码的灵活性与无代码的高效性。凭借 400+ 集成、原生 AI 能力和公平代码许可，n8n 让你在完全掌控数据和部署的同时，构建强大的自动化流程。

![n8n.io - 截图](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## 主要功能

- **需要时可编写代码**：支持编写 JavaScript/Python、添加 npm 包，或使用可视化界面
- **原生 AI 平台**：基于 LangChain，结合自有数据和模型，构建 AI 智能代理工作流
- **完全可控**：可使用我们的公平代码许可自托管，或选择我们的 [云服务](https://app.n8n.cloud/login)
- **企业级准备**：高级权限、单点登录（SSO）和隔离部署
- **活跃社区**：400+ 集成和 900+ 个即用型 [模板](https://n8n.io/workflows)

## 快速开始

通过 [npx](https://docs.n8n.io/hosting/installation/npm/) 立即体验 n8n（需要 [Node.js](https://nodejs.org/en/)）：

```
npx n8n
```

或使用 [Docker](https://docs.n8n.io/hosting/installation/docker/) 部署：

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

在 http://localhost:5678 访问编辑器

## 资源

- 📚 [文档](https://docs.n8n.io)
- 🔧 [400+ 集成](https://n8n.io/integrations)
- 💡 [示例工作流](https://n8n.io/workflows)
- 🤖 [AI & LangChain 指南](https://docs.n8n.io/langchain/)
- 👥 [社区论坛](https://community.n8n.io)
- 📖 [社区教程](https://community.n8n.io/c/tutorials/28)

## 支持

需要帮助？我们的社区论坛是获取支持和与其他用户交流的最佳场所：
[community.n8n.io](https://community.n8n.io)

## 许可协议

n8n 采用 [公平代码](https://faircode.io) 模式，遵循 [可持续使用许可证](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) 和 [n8n 企业版许可证](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md) 分发。

- **源代码开放**：始终可见的源代码
- **可自托管**：可部署在任何地方
- **可扩展性**：可添加自定义节点和功能

[企业许可证](mailto:license@n8n.io) 提供更多功能和支持。

关于许可模式的更多信息，请参见[文档](https://docs.n8n.io/reference/license/)。

## 参与贡献

发现了 bug 🐛 或有功能建议 ✨？请查阅我们的 [贡献指南](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md) 开始参与。

## 加入我们

想要引领自动化的未来？欢迎查看我们的 [招聘信息](https://n8n.io/careers)，加入我们的团队！

## n8n 是什么意思？

**简短答案：** 意为 "nodemation"，发音为 n-eight-n。

**详细答案：** “我经常被问到这个问题（比我预期的还要多），所以我决定在这里解释一下。当我为这个项目寻找一个合适且可注册的域名时，很快就发现我能想到的好名字都被占用了。最后我选择了 nodemation。‘node-’ 表示它采用了节点视图并基于 Node.js，‘-mation’ 则代表‘automation’（自动化），这正是本项目的目标。不过，我觉得这个名字太长了，无法想象每次在命令行输入这么长的名称。于是，最终我采用了‘n8n’。” —— **Jan Oberhauser, 创始人兼 CEO, n8n.io**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---