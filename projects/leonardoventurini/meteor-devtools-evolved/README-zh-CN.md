<div align="center">

<img src="https://media.giphy.com/media/Pt2yOXUALOhpB5dpiM/giphy.gif" alt="Meteor Devtool Evolved Gif" />

<p style="font-size: 30px">
Meteor 开发者工具扩展
</p>
请见证 Meteor 开发者工具的进化。</p>

Meteor Devtools Evolved 目前支持 Google Chrome 和 Mozilla Firefox。

</div>

<p align="center" >
    <a href="https://chrome.google.com/webstore/detail/meteor-devtools-evolved/ibniinmoafhgbifjojidlagmggecmpgf">
    <img width="120" src="https://img.shields.io/badge/%20-Chrome-orange?logo=google-chrome&logoColor=white" alt="下载 Chrome 版" />
    </a>
    <a href="https://addons.mozilla.org/en-US/firefox/addon/meteor-devtools-evolved/">
    <img width="110" src="https://img.shields.io/badge/%20-Firefox-red?logo=mozilla&logoColor=white" alt="下载 Firefox 版" />
    </a>
</p>

[更难，更好，更快，更强](https://www.youtube.com/watch?v=gAjR4_CbPpQ) :rocket:

你刚开始使用 Meteor 吗？想了解“发生了什么”甚至优化你的 Meteor 应用吗？这款工具正适合你。

:point_right: [更新日志](https://raw.githubusercontent.com/leonardoventurini/meteor-devtools-evolved/development/CHANGELOG.md)

### 分布式数据协议 (DDP)

你所需的一切，帮助你跟踪并理解 Meteor 应用内部的运行机制。该扩展允许你过滤和搜索任何 DDP 消息，能够轻松处理成千上万条消息而不卡顿。

### 书签

DDP 检查是临时的，但你可以保存任意多的 DDP 消息以便日后搜索和检索，支持任何主机。请注意，数据保存在 IndexedDB 中。

### Minimongo

不知道哪些数据属于哪里？你可以快速搜索 Minimongo 数据中的任何内容，并通过我们极速定制的对象树形浏览器轻松可视化文档。

---

## 开发

> 免责声明：本项目部分基于 The Bakery 的 [Meteor DevTools](https://github.com/bakery/meteor-devtools) 扩展。遗憾的是该扩展已不再维护。虽然本项目不完全是一个分支，但我确实借鉴了一些有用的知识和架构决策，有些内容自然趋于相同的最实用方案。因此称之为“进化版”。

该扩展几乎完全用 TypeScript 编写，部分 Chrome 特定代码出于实用原因被省略。它使用 MobX 来管理状态，样式采用 SASS。我们还使用了 Palantir 提供的 [Blueprint](https://github.com/palantir/blueprint) 库中的组件。所有部分通过 Webpack 进行整合。

> 欢迎任何人贡献代码，更多信息请见 [这里](https://raw.githubusercontent.com/leonardoventurini/meteor-devtools-evolved/development/CONTRIBUTING.md)。

## Firefox

该扩展的 Firefox 版本由 [@nilooy](https://github.com/nilooy) 贡献。感谢！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-08

---