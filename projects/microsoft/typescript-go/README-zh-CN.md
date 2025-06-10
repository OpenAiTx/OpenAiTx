# TypeScript 7

[不确定这是什么？请阅读公告博文！](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## 预览版

预览版本已在 npm 上以 `@typescript/native-preview` 提供。

```sh
npm install @typescript/native-preview
npx tsgo # 像使用 tsc 一样使用它。
```

预览版 VS Code 扩展已[在 VS Code 市场提供](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview)。

要使用此扩展，请在 VS Code 设置中添加如下内容：

```json
{
    "typescript.experimental.useTsgo": true
}
```

## 如何构建与运行

本仓库使用 [Go 1.24 或更高版本](https://go.dev/dl/)、[Rust 1.85 或更高版本](https://www.rust-lang.org/tools/install)、[带 npm 的 Node.js](https://nodejs.org/)，以及 [`hereby`](https://www.npmjs.com/package/hereby)。

用于测试与代码生成时，本仓库包含了一个指向主 TypeScript 仓库的 git 子模块，指向正在移植的提交。
克隆时，建议带有子模块一起克隆：

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

如果你已克隆仓库，可以使用以下命令初始化子模块：

```sh
git submodule update --init --recursive
```

子模块就位并执行 `npm ci` 后，你可以通过 `hereby` 运行任务，类似于 TypeScript 仓库：

```sh
hereby build          # 验证项目是否可以构建
hereby test           # 运行所有测试
hereby install-tools  # 安装额外工具（如代码检查工具）
hereby lint           # 运行所有代码检查工具
hereby format         # 格式化所有代码
hereby generate       # 生成所有 Go 代码（如诊断信息，提交到仓库）
```

其他任务正在开发中。

在仓库开发时并不强制要求使用 `hereby`；常规的 `go` 工具链（如 `go build`、`go test ./...`）也可以正常工作。
`hereby` 任务仅为熟悉 TypeScript 仓库的开发者提供便利。

### 运行 `tsgo`

在执行 `hereby build` 之后，你可以运行 `built/local/tsgo`，其行为大致与 `tsc` 相同。

### 运行 LSP 原型

如需在不全局安装的情况下调试和运行 VS Code 扩展：

* 在仓库工作区内运行 VS Code（`code .`）
* 将 `.vscode/launch.template.json` 复制为 `.vscode/launch.json`
* 按 <kbd>F5</kbd>（或从命令面板选择 `Debug: Start Debugging`）

这将启动一个新的 VS Code 实例，使用 Corsa LS 作为后端。如果设置正确，当打开 TypeScript 或 JavaScript 文件时，你应能在状态栏看到 "tsgo"：

![LSP 原型截图](.github/ls-screenshot.png)

## 目前已实现的功能？

该项目仍在开发中，尚未与 TypeScript 完全功能等价。可能存在 bug。在提交新问题或假设为故意变更前，请仔细检查以下列表。

| 功能 | 状态 | 说明 |
|---------|--------|-------|
| 程序创建 | 已完成 | 与 TS5.8 相同的文件与模块解析。并非所有解析模式都已支持。 |
| 解析/扫描 | 已完成 | 与 TS5.8 完全相同的语法错误 |
| 命令行与 `tsconfig.json` 解析 | 基本完成 | 入口点目前略有不同 |
| 类型解析 | 已完成 | 与 TS5.8 相同的类型 |
| 类型检查 | 已完成 | 与 TS5.8 相同的错误、定位和消息。错误中的类型回显可能显示不同（开发中） |
| JavaScript 特有的推断与 JS Doc | 未准备好 | - |
| JSX | 已完成 | - |
| 声明发射 | 开发中 | 大多数常用功能已实现，但某些边界情况与功能标志尚未处理 |
| 发射（JS 输出） | 开发中 | `target: esnext` 支持良好，其他目标可能存在缺口 |
| 监听模式 | 原型 | 监听文件并重建，但不支持增量检查 |
| 构建模式/项目引用 | 未准备好 | - |
| 增量构建 | 未准备好 | - |
| 语言服务（LSP） | 原型 | 最小功能（错误、悬停、转到定义）。更多功能即将上线 |
| API | 未准备好 | - |

定义说明：

 * **已完成**：即“认为已完成”：目前没有已知的缺陷或主要待办事项。可提交 bug
 * **开发中**：正在开发中；部分功能可用，部分不可用。可提交 panic，但请勿提交其他问题
 * **原型**：仅为概念验证；请勿提交 bug
 * **未准备好**：尚未开始，或距离可用还有很远，请勿尝试使用

## 其他说明

长期来看，我们预计该仓库及其内容将合并到 `microsoft/TypeScript`。
因此，typescript-go 的仓库与问题追踪器最终会关闭，请据此参与讨论/提交问题。

关于与 TypeScript 5.7 的有意变更列表，请参见 CHANGES.md。

## 贡献

本项目欢迎贡献与建议。大多数贡献需要你同意一份
贡献者许可协议（CLA），声明你有权并确实授予我们
使用你贡献内容的权利。详情请访问 [贡献者许可协议](https://cla.opensource.microsoft.com)。

当你提交拉取请求时，CLA 机器人会自动判断你是否需要
提供 CLA，并在 PR 上标注（如状态检查、评论）。只需按机器人
指示操作即可。你只需在所有使用我们 CLA 的仓库中做一次此操作。

本项目已采用 [Microsoft 开源行为准则](https://opensource.microsoft.com/codeofconduct/)。
更多信息请参阅 [行为准则常见问题](https://opensource.microsoft.com/codeofconduct/faq/) 或
联系 [opencode@microsoft.com](mailto:opencode@microsoft.com) 以获取更多问题或意见。

## 商标声明

本项目可能包含其他项目、产品或服务的商标或标志。对 Microsoft
商标或标志的授权使用需遵循并符合
[Microsoft 商标与品牌指南](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general)。
在本项目的修改版本中使用 Microsoft 商标或标志时，不得引起混淆或暗示获得 Microsoft 赞助。
对第三方商标或标志的任何使用须遵循该第三方的政策。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---