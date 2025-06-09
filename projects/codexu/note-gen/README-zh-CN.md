![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## 指南

NoteGen 是一款跨平台的 `Markdown` 笔记应用，致力于用 AI 连接记录与写作，将碎片化知识整理为可读笔记。

🖥️ 官方文档：[https://notegen.top](https://notegen.top)

💬 加入 [微信/QQ群](https://github.com/codexu/note-gen/discussions/110)

## 为什么选择 NoteGen？

- 轻量级：[安装包](https://github.com/codexu/note-gen/releases)仅 **20MB**，永久免费，无广告，无捆绑。
- 跨平台：支持 Mac、Windows、Linux，得益于 `Tauri2` 的跨平台能力，未来将支持 iOS 和 Android。
- 支持多种记录方式，包括 `截图`、`文本`、`插画`、`文件`、`链接` 等，满足多场景碎片化记录需求。
- 原生 `Markdown(.md)` 作为存储格式，不做修改，易于迁移。
- 原生离线使用，支持实时同步到 `GitHub、Gitee 私有仓库`，并可历史回滚，同时支持 WebDAV 同步。
- AI 加持：可配置 ChatGPT、Gemini、Ollama、LM Studio、Grok 等模型，支持自定义第三方模型配置。
- RAG：你的笔记就是你的知识库。支持 Embedding 模型与 rerank 模型。

## 截图

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

记录：

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

写作：

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

主题：

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## 从记录到写作

传统笔记应用大多不提供记录功能，用户需要手动复制粘贴内容进行记录，极大影响效率。面对零散的记录内容，整理起来也十分费力。

NoteGen 分为 `记录` 与 `写作` 页面，二者关系如下：

- 记录可整理为笔记，转至写作页进行深度创作。
- 写作时可随时插入记录。

### 记录

记录功能类似于一个 **AI 聊天机器人**，但在与其对话时，你可以关联先前的记录内容，从对话模式切换到整理模式，将记录整理为可读笔记。

以下辅助功能可帮助你更高效地记录：

- **标签**，区分不同记录场景。
- **角色**，支持自定义提示词，精准控制你的 AI 助手。
- **剪贴板助手**，自动识别剪贴板中的文本或图片并录入到你的列表。

### 写作

写作部分分为 **文件管理器** 和 **Markdown 编辑器** 两部分。

**文件管理器**

- 支持本地 Markdown 文件及 GitHub 同步文件的管理。
- 支持无限目录层级。
- 支持多种排序方式。

**Markdown 编辑器**

- 支持所见即所得、即时渲染、分屏预览等模式。
- 支持版本控制与历史回滚。
- 支持 AI 辅助对话、续写、润色、翻译等功能。
- 支持图床，上传图片并转为 Markdown 图片链接。
- 支持 HTML 转 Markdown，自动将浏览器复制内容转为 Markdown 格式。
- 支持大纲、数学公式、思维导图、图表、流程图、甘特图、时序图、五线谱、多媒体、语音朗读、标题锚点、代码高亮与复制、graphviz 渲染、plantuml UML 图等。
- 支持实时本地内容保存，延迟（10s 无编辑）自动同步及历史回滚。

## 其他功能

- 全局搜索，快速定位并跳转到具体内容。
- 图床管理，便于管理图片仓库内容。
- 主题与外观，支持深色主题及 Markdown、代码等外观设置。
- 国际化支持，目前提供中文和英文。

## 如何使用？

### 下载

目前支持 Mac、Windows、Linux。得益于 Tauri2 的跨平台能力，未来将支持 iOS 和 Android。

[下载 NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### 增强

笔记应用无需配置即可直接使用。如需更佳体验，请在设置页配置 AI 与同步功能。

## 参与贡献

- [阅读贡献指南](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [更新计划](https://github.com/codexu/note-gen/issues/46)
- [提交 bug 或改进建议](https://github.com/codexu/note-gen/issues)
- [讨论区](https://github.com/codexu/note-gen/discussions)

## 贡献者

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Star 历史

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---