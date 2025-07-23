<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/ehmicky/design/main/log-process-errors/log-process-errors_dark.svg"/>
  <img alt="log-process-errors logo" src="https://raw.githubusercontent.com/ehmicky/design/main/log-process-errors/log-process-errors.svg" width="500"/>
</picture>

[![Node](https://img.shields.io/badge/-Node.js-808080?logo=node.js&colorA=404040&logoColor=66cc33)](https://www.npmjs.com/package/log-process-errors)
[![TypeScript](https://img.shields.io/badge/-Typed-808080?logo=typescript&colorA=404040&logoColor=0096ff)](/src/main.d.ts)
[![Codecov](https://img.shields.io/badge/-Tested%20100%25-808080?logo=codecov&colorA=404040)](https://codecov.io/gh/ehmicky/log-process-errors)
[![Mastodon](https://img.shields.io/badge/-Mastodon-808080.svg?logo=mastodon&colorA=404040&logoColor=9590F9)](https://fosstodon.org/@ehmicky)
[![Medium](https://img.shields.io/badge/-Medium-808080.svg?logo=medium&colorA=404040)](https://medium.com/@ehmicky)

[📰 Medium 文章。](https://medium.com/@ehmicky/node-js-process-errors-are-broken-193980f0a77b)

为 Node.js 进程错误献上 ❤️。

这提升了进程错误的处理：
[未捕获](https://nodejs.org/api/process.html#process_event_uncaughtexception)
异常，
[未处理](https://nodejs.org/api/process.html#process_event_unhandledrejection)
的 Promise，过晚
[处理的](https://nodejs.org/api/process.html#process_event_rejectionhandled)
Promise 以及 [警告](https://nodejs.org/api/process.html#process_event_warning)。

# 特性

- 警告和
  [`rejectionHandled`](https://nodejs.org/api/process.html#process_event_rejectionhandled)
  的堆栈追踪
- 针对所有进程错误的[单一事件处理器](#onerror)
- 忽略[重复的](#onerror)进程错误
- [规范化](#error)无效错误
- 进程退出[#exit](#exit)优雅且可被阻止

# 安装

生产代码（例如服务器）可以将此作为生产依赖或
开发依赖安装：
```bash
npm install log-process-errors
```
然而，库应该将此作为开发依赖安装：


```bash
npm install -D log-process-errors
```


这是因为日志记录是全局修改的，库的使用者可能不会
预期这种副作用。此外，这可能导致库之间的冲突。

此包适用于 Node.js >=18.18.0。

这是一个 ES 模块。必须使用
[import 或 import() 语句](https://gist.github.com/sindresorhus/a39789f98801d908bbc7ff3ecc99d99c)
加载，而非 require()。如果使用 TypeScript，必须配置为
[输出 ES 模块](https://www.typescriptlang.org/docs/handbook/esm-node.html)，
而非 CommonJS。

# API

## logProcessErrors(options?)

[`options`](#options) `对象?`\
_返回值_: `() => void`

开始处理进程错误。


```js
import logProcessErrors from 'log-process-errors'
logProcessErrors(options)
```
返回值恢复 Node.js 的默认行为。


```js
const restore = logProcessErrors(options)
restore()
```
## 选项

### exit

_类型_: `boolean`

是否在
[未捕获的异常](https://nodejs.org/api/process.html#process_event_uncaughtexception)
或
[未处理的 promise](https://nodejs.org/api/process.html#process_event_unhandledrejection)
时退出进程。

如果其他库正在监听这些事件，则默认值为 `false`，这样它们可以执行退出操作。否则，默认值为 `true`。

如果仍有任务在进行中，退出会等待这些任务最多完成 3 秒。

### onError

_类型_: `(error, event) => Promise<void> | void`\
_默认值_: `console.error(error)`

每当进程错误发生时调用的函数。重复的进程错误会被忽略。



```js
// Log process errors with Winston instead
logProcessErrors({
  onError: (error, event) => {
    winstonLogger.error(error.stack)
  },
})
```
#### error

_Type_: `Error`

进程错误。保证这是一个
[标准化](https://github.com/ehmicky/normalize-exception)的错误实例。
其消息中还附加了[event](#event)的简要描述。

#### event

_Type_: `Event`

进程事件名称包括：
[`'uncaughtException'`](https://nodejs.org/api/process.html#process_event_uncaughtexception)，
[`'unhandledRejection'`](https://nodejs.org/api/process.html#process_event_unhandledrejection)，
[`'rejectionHandled'`](https://nodejs.org/api/process.html#process_event_rejectionhandled)，
[`'warning'`](https://nodejs.org/api/process.html#process_event_warning)。

# 相关项目

- [`modern-errors`](https://github.com/ehmicky/modern-errors)：以简单、稳定、一致的方式处理错误
- [`modern-errors-process`](https://github.com/ehmicky/modern-errors-process)：处理进程错误
- [`error-custom-class`](https://github.com/ehmicky/error-custom-class)：创建单个错误类
- [`error-class-utils`](https://github.com/ehmicky/error-class-utils)：用于正确创建错误类的工具
- [`error-serializer`](https://github.com/ehmicky/error-serializer)：将错误转换为/从普通对象
- [`normalize-exception`](https://github.com/ehmicky/normalize-exception)：标准化异常/错误
- [`is-error-instance`](https://github.com/ehmicky/is-error-instance)：检查值是否为`Error`实例
- [`merge-error-cause`](https://github.com/ehmicky/merge-error-cause)：合并错误及其`cause`
- [`set-error-class`](https://github.com/ehmicky/set-error-class)：正确更新错误的类
- [`set-error-message`](https://github.com/ehmicky/set-error-message)：正确更新错误的消息
- [`wrap-error-message`](https://github.com/ehmicky/wrap-error-message)：正确包装错误的消息
- [`set-error-props`](https://github.com/ehmicky/set-error-props)：正确更新错误的属性
- [`set-error-stack`](https://github.com/ehmicky/set-error-stack)：正确更新错误的堆栈
- [`error-cause-polyfill`](https://github.com/ehmicky/error-cause-polyfill)：`error.cause`的填充实现
- [`handle-cli-error`](https://github.com/ehmicky/handle-cli-error)：💣 CLI 应用的错误处理器 💥
- [`beautiful-error`](https://github.com/ehmicky/beautiful-error)：美化错误消息和堆栈
- [`error-http-response`](https://github.com/ehmicky/error-http-response)：创建 HTTP 错误响应
- [`winston-error-format`](https://github.com/ehmicky/winston-error-format)：用 Winston 记录错误

# 支持

如有任何问题，_请随时_ [在 GitHub 提交 issue](../../issues)。

无论个人背景如何，欢迎所有人参与。我们执行一套
[行为准则](https://raw.githubusercontent.com/ehmicky/log-process-errors/main/CODE_OF_CONDUCT.md)，以促进积极包容的环境。

# 贡献

本项目由 ❤️ 制作。回馈最简单的方式是为其加星并在线分享。

如果文档不清楚或有错别字，请点击页面上的 `Edit`
按钮（铅笔图标）并建议更正。

如果您想帮助我们修复错误或添加新功能，请查看我们的
[指南](https://raw.githubusercontent.com/ehmicky/log-process-errors/main/CONTRIBUTING.md)。欢迎提交拉取请求！

感谢我们出色的贡献者：

<!-- ALL-CONTRIBUTORS-LIST:START -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="https://fosstodon.org/@ehmicky"><img src="https://avatars2.githubusercontent.com/u/8136211?v=4" width="100px;" alt=""/><br /><sub><b>ehmicky</b></sub></a><br /><a href="https://github.com/ehmicky/log-process-errors/commits?author=ehmicky" title="Code">💻</a> <a href="#design-ehmicky" title="Design">🎨</a> <a href="#ideas-ehmicky" title="Ideas, Planning, & Feedback">🤔</a> <a href="https://github.com/ehmicky/log-process-errors/commits?author=ehmicky" title="Documentation">📖</a></td>
    <td align="center"><a href="https://svachon.com"><img src="https://avatars0.githubusercontent.com/u/170197?v=4" width="100px;" alt=""/><br /><sub><b>Steven Vachon</b></sub></a><br /><a href="#question-stevenvachon" title="Answering Questions">💬</a></td>
    <td align="center"><a href="https://github.com/Hongarc"><img src="https://avatars1.githubusercontent.com/u/19208123?v=4" width="100px;" alt=""/><br /><sub><b>Hongarc</b></sub></a><br /><a href="https://github.com/ehmicky/log-process-errors/commits?author=Hongarc" title="Documentation">📖</a> <a href="https://github.com/ehmicky/log-process-errors/commits?author=Hongarc" title="Code">💻</a></td>
    <td align="center"><a href="https://github.com/abrenneke"><img src="https://avatars0.githubusercontent.com/u/342540?v=4" width="100px;" alt=""/><br /><sub><b>Andy Brenneke</b></sub></a><br /><a href="https://github.com/ehmicky/log-process-errors/issues?q=author%3Aabrenneke" title="Bug reports">🐛</a></td>
  </tr>
</table>

<!-- markdownlint-enable -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---