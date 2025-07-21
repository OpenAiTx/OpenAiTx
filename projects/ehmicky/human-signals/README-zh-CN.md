<translate-content>[![Node](https://img.shields.io/badge/-Node.js-808080?logo=node.js&colorA=404040&logoColor=66cc33)](https://www.npmjs.com/package/human-signals)
[![TypeScript](https://img.shields.io/badge/-Typed-808080?logo=typescript&colorA=404040&logoColor=0096ff)](/src/main.d.ts)
[![Codecov](https://img.shields.io/badge/-Tested%20100%25-808080?logo=codecov&colorA=404040)](https://codecov.io/gh/ehmicky/human-signals)
[![Mastodon](https://img.shields.io/badge/-Mastodon-808080.svg?logo=mastodon&colorA=404040&logoColor=9590F9)](https://fosstodon.org/@ehmicky)
[![Medium](https://img.shields.io/badge/-Medium-808080.svg?logo=medium&colorA=404040)](https://medium.com/@ehmicky)

人性化的进程信号。

这是一个已知进程信号的映射，包含了每个信号的一些信息。

不同于
[`os.constants.signals`](https://nodejs.org/api/os.html#os_signal_constants)
本项目包括：

- 人性化的[描述](#description)
- [默认动作](#action)，包括是否[可以被阻止](#forced)
- 当前操作系统是否[支持](#supported)该信号

# 示例

```js
import { signalsByName, signalsByNumber } from 'human-signals'

console.log(signalsByName.SIGINT)
// {
//   name: 'SIGINT',
//   number: 2,
//   description: 'User interruption with CTRL-C',
//   supported: true,
//   action: 'terminate',
//   forced: false,
//   standard: 'ansi'
// }

console.log(signalsByNumber[8])
// {
//   name: 'SIGFPE',
//   number: 8,
//   description: 'Floating point arithmetic error',
//   supported: true,
//   action: 'core',
//   forced: false,
//   standard: 'ansi'
// }
```
# 安装


```bash
npm install human-signals
```
此软件包适用于 Node.js >=18.18.0。

这是一个 ES 模块。必须使用
[ `import` 或 `import()` 语句](https://gist.github.com/sindresorhus/a39789f98801d908bbc7ff3ecc99d99c)加载，
而非 `require()`。如果使用 TypeScript，必须配置为
[输出 ES 模块](https://www.typescriptlang.org/docs/handbook/esm-node.html)，
而非 CommonJS。

# 用法

## signalsByName

_类型_: `object`

对象，其键是信号的[名称](#name)，值是
[信号对象](#signal)。

## signalsByNumber

_类型_: `object`

对象，其键是信号的[编号](#number)，值是
[信号对象](#signal)。

## signal

_类型_: `object`

信号对象，包含以下属性。

### name

_类型_: `string`

信号的标准名称，例如 `'SIGINT'`。

### number

_类型_: `number`

信号的代码编号，例如 `2`。虽然大多数 `number` 是
跨平台的，但某些在不同操作系统间会有所不同。

### description

_类型_: `string`

信号的人类友好描述，例如
`'用户使用 CTRL-C 中断'`。

### supported

_类型_: `boolean`

当前操作系统是否能在 Node.js 中通过
[`process.on(name, handler)`](https://nodejs.org/api/process.html#process_signal_events)处理此信号。

支持的信号列表
[是操作系统特定的](https://github.com/ehmicky/cross-platform-node-guide/blob/main/docs/6_networking_ipc/signals.md#cross-platform-signals)。

### action

_类型_: `string`\
_枚举_: `'terminate'`, `'core'`, `'ignore'`, `'pause'`, `'unpause'`

当此信号未被处理时的默认动作。

### forced

_类型_: `boolean`

信号的默认动作是否无法被阻止。`SIGTERM`、`SIGKILL` 和 `SIGSTOP` 为 `true`。

### standard

_类型_: `string`\
_枚举_: `'ansi'`, `'posix'`, `'bsd'`, `'systemv'`, `'other'`

定义该信号的标准。

# 支持

如有任何问题，_欢迎随时_ [在 GitHub 提交 issue](../../issues)。

无论个人背景如何，人人皆可参与。我们执行
[行为准则](https://raw.githubusercontent.com/ehmicky/human-signals/main/CODE_OF_CONDUCT.md)，以促进积极且包容的环境。

# 贡献

本项目由 ❤️ 制作。回馈的最简单方式是为项目点星并
在线分享。

如果文档不清楚或有错别字，请点击页面上的 `编辑`
按钮（铅笔图标）并建议修改。

如果您想帮忙修复 bug 或添加新功能，请查看我们的
[贡献指南](https://raw.githubusercontent.com/ehmicky/human-signals/main/CONTRIBUTING.md)。欢迎提交合并请求！



感谢我们出色的贡献者：

<!-- ALL-CONTRIBUTORS-LIST:START -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tbody>
    <tr>
      <td align="center" valign="top" width="14.28%"><a href="https://fosstodon.org/@ehmicky"><img src="https://avatars2.githubusercontent.com/u/8136211?v=4?s=100" width="100px;" alt="ehmicky"/><br /><sub><b>ehmicky</b></sub></a><br /><a href="https://github.com/ehmicky/human-signals/commits?author=ehmicky" title="代码">💻</a> <a href="#design-ehmicky" title="设计">🎨</a> <a href="#ideas-ehmicky" title="创意、计划与反馈">🤔</a> <a href="https://github.com/ehmicky/human-signals/commits?author=ehmicky" title="文档">📖</a></td>
      <td align="center" valign="top" width="14.28%"><a href="http://www.electrovir.com"><img src="https://avatars0.githubusercontent.com/u/1205860?v=4?s=100" width="100px;" alt="electrovir"/><br /><sub><b>electrovir</b></sub></a><br /><a href="https://github.com/ehmicky/human-signals/commits?author=electrovir" title="代码">💻</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://fzy.se"><img src="https://avatars.githubusercontent.com/u/2656517?v=4?s=100" width="100px;" alt="Felix Zedén Yverås"/><br /><sub><b>Felix Zedén Yverås</b></sub></a><br /><a href="https://github.com/ehmicky/human-signals/commits?author=FelixZY" title="代码">💻</a> <a href="https://github.com/ehmicky/human-signals/commits?author=FelixZY" title="测试">⚠️</a></td>
    </tr>
  </tbody>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---