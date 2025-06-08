# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React 是一个用于构建用户界面的 JavaScript 库。

* **声明式：** React 让创建交互式 UI 变得轻松自如。为应用的每个状态设计简单的视图，当你的数据发生变化时，React 会高效地更新并渲染正确的组件。声明式视图让你的代码更可预测、更易理解，也更容易调试。
* **基于组件：** 构建封装良好的组件，各自管理自己的状态，然后组合它们以构建复杂的 UI。由于组件逻辑是用 JavaScript 编写的，而不是模板，因此你可以轻松地在应用中传递丰富的数据，并将状态保持在 DOM 之外。
* **一次学习，随处编写：** 我们不对你的技术栈做假设，因此你可以在不重写现有代码的情况下，在 React 中开发新功能。React 还可以使用 [Node](https://nodejs.org/en) 在服务器端渲染，并通过 [React Native](https://reactnative.dev/) 支持移动应用开发。

[了解如何在你的项目中使用 React](https://react.dev/learn)。

## 安装

React 从一开始就被设计为可渐进式采用，**你可以根据需要使用少量或大量的 React**：

* 使用 [快速开始](https://react.dev/learn) 体验 React。
* [将 React 添加到现有项目](https://react.dev/learn/add-react-to-an-existing-project)，根据需要使用少量或大量的 React。
* 如果你需要一个强大的 JavaScript 工具链，可以[创建一个新的 React 应用](https://react.dev/learn/start-a-new-react-project)。

## 文档

你可以在 [官网](https://react.dev/) 上找到 React 的文档。

可查看 [快速开始](https://react.dev/learn) 页面以快速了解。

文档分为以下几个部分：

* [快速开始](https://react.dev/learn)
* [教程](https://react.dev/learn/tutorial-tic-tac-toe)
* [React 思维](https://react.dev/learn/thinking-in-react)
* [安装](https://react.dev/learn/installation)
* [描述 UI](https://react.dev/learn/describing-the-ui)
* [添加交互](https://react.dev/learn/adding-interactivity)
* [状态管理](https://react.dev/learn/managing-state)
* [高级指南](https://react.dev/learn/escape-hatches)
* [API 参考](https://react.dev/reference/react)
* [获取支持的途径](https://react.dev/community)
* [贡献指南](https://legacy.reactjs.org/docs/how-to-contribute.html)

你可以通过向[此仓库](https://github.com/reactjs/react.dev)提交 Pull Request 来改进文档。

## 示例

我们在 [官网](https://react.dev/) 上提供了多个示例。以下是第一个示例，助你快速入门：

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

此示例会在页面的某个容器中渲染 “Hello Taylor”。

你会注意到我们使用了类似 HTML 的语法；[我们称之为 JSX](https://react.dev/learn#writing-markup-with-jsx)。使用 React 并不要求必须使用 JSX，但它让代码更易读，编写起来也更像写 HTML。

## 贡献

本仓库的主要目的是不断发展 React 核心，使其更快、更易用。React 的开发在 GitHub 上公开进行，我们感谢社区成员对 bug 修复和功能改进的贡献。阅读下文，了解你如何参与 React 的改进。

### [行为准则](https://code.fb.com/codeofconduct)

Facebook 制定了项目参与者需遵守的行为准则。请阅读[完整内容](https://code.fb.com/codeofconduct)，以了解哪些行为会被接受，哪些不会被容忍。

### [贡献指南](https://legacy.reactjs.org/docs/how-to-contribute.html)

阅读我们的[贡献指南](https://legacy.reactjs.org/docs/how-to-contribute.html)，了解我们的开发流程、如何提交 bug 修复和改进建议，以及如何构建和测试你对 React 的更改。

### [新手任务](https://github.com/facebook/react/labels/good%20first%20issue)

为帮助你熟悉我们的贡献流程，我们整理了一些[新手任务](https://github.com/facebook/react/labels/good%20first%20issue)，这些任务范围较小且易于上手，是不错的入门选择。

### 许可证

React 采用 [MIT 许可证](./LICENSE)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---