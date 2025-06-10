<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>让你的前端闪耀起来</strong> ✨
</div>

<div align="center">
  用 Gleam 构建 Web 应用的框架！
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Available on Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Documentation" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Website
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      快速开始
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      参考文档
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>由 ❤︎ 构建，
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> 以及
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    贡献者
  </a>
</div>

---

## 目录

- [特性](#features)
- [示例](#example)
- [理念](#philosophy)
- [安装](#installation)
- [接下来](#where-next)
- [支持](#support)

## 特性 {#features}

- 用于构建 HTML 的**声明式**、函数式 API。没有模板，没有宏，
  只有 Gleam。

- 借鉴 Erlang 和 Elm 架构的**状态管理**。

- **受控副作用**，实现可预测、可测试的代码。

- 通用组件。**一次编写，处处运行**。Elm 与 Phoenix LiveView 的结合。

- **内置功能齐全的 CLI**，让脚手架和应用构建变得轻松愉快。

- **服务端渲染**，用于静态 HTML 模板。

## 示例 {#example}

Lustre 提供了[20 多个示例](https://hexdocs.pm/lustre/reference/examples.html)！
以下是一个示例：

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## 理念 {#philosophy}

Lustre 是一个有“主见”的框架，适用于构建中小型 Web 应用。现代前端开发既困难又复杂，其中一部分复杂性是必需的，但很多复杂性是偶然的，或者源自于可选项过多。Lustre 与 Gleam 拥有相同的设计理念：在可能的情况下，事情只应有一种做法。

这意味着默认自带唯一的状态管理系统，借鉴 Elm 和 Erlang/OTP 的模型。打开任何 Lustre 应用，你都能感到熟悉和顺手。

这也意味着我们鼓励用简单的方法来构建视图，而不是复杂的方法。Lustre _确实_ 提供了创建封装状态组件的方式（这是我们在 Elm 中非常缺失的），但这不应成为默认选择。优先使用简单函数而非状态组件。

在确实需要组件的场景下，充分利用 Lustre 组件可以**任意运行**这一特性。Lustre 提供了工具，让你能编写可以在现有 Lustre 应用内运行的组件，也可以将其导出为独立的 Web 组件，或在服务器上用极简运行时打补丁 DOM。Lustre 称这些为**通用组件**，并以 Gleam 的多目标为设计出发点。

## 安装 {#installation}

Lustre 已发布在 [Hex](https://hex.pm/packages/lustre)！你可以通过命令行将其添加到你的 Gleam 项目中：

```sh
gleam add lustre
```

Lustre 还有一个配套开发工具包，你可能也需要安装：

> **注意**：lustre_dev_tools 开发服务器会监听你的文件系统，
> 检测 gleam 代码的变更并自动刷新浏览器。Linux 用户需要安装 [inotify-tools]()

```sh
gleam add --dev lustre_dev_tools
```

## 接下来 {#where-next}

想快速上手 Lustre，可以阅读[快速开始指南](https://hexdocs.pm/lustre/guide/01-quickstart.html)。
如果你更喜欢直接看代码，[examples](https://github.com/lustre-labs/lustre/tree/main/examples)
目录包含了多个小型应用，展示了该框架的不同方面。

你也可以在 [HexDocs](https://hexdocs.pm/lustre) 阅读文档和 API 参考。

## 支持 {#support}

Lustre 主要由我，[Hayleigh](https://github.com/hayleigh-dot-dev) 一个人开发，
是在两份工作的空闲时间完成的。如果你愿意支持我的工作，可以[在 GitHub 上赞助我](https://github.com/sponsors/hayleigh-dot-dev)。

也非常欢迎贡献！如果你发现了 bug，或者有新特性的建议，请提交 issue 或 pull request。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---