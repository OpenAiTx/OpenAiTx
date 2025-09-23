# Node Monkey

一个通过网页浏览器或 SSH 接口检查、调试和控制 Node.js 应用程序的工具（支持自定义命令）。

Node Monkey 运行一个简单的服务器（或附加到您现有的服务器），并使用 [Socket.IO](https://github.com/LearnBoost/socket.io) 在浏览器和服务器之间创建 websocket 连接。其主要功能是捕获通常会被记录到终端的任何内容，并将其传递到浏览器进行检查。

入门非常简单（见下面的[快速使用](#quick-usage)），但 Node Monkey 还提供了额外的功能和显著的灵活性，适合更高级的使用。您实际上可以通过 SSH 登录您的应用程序，Node Monkey 会提供一个命令行接口以执行您自己的自定义命令。这对于调试、监控或以其他方式控制正在运行的应用程序非常有用。它为生产环境应用提供了安全认证。

## 目录

- [动机](#motivation)
- [功能](#features)
- [安装](#installation)
- [快速使用](#quick-usage)
- [服务器](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md)
  - [提供您自己的](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own)
  - [选项](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options)
  - [属性](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#properties)
  - [方法](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#methods)
- [客户端（浏览器）](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md)
  - [属性](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#properties)
  - [方法](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#methods)
- [SSH](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md)
  - [设置](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#setup)
  - [使用](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#usage)
- [用户管理](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/user-management.md)
- [贡献](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/contributing.md)
- [更新日志](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/CHANGELOG.md)
- [MIT 许可证](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)

## 动机

这个项目的动机来自于调试我写的使用 websockets 的 Node.js 服务器时遇到的问题。我发现使用终端检查对象很麻烦，因为输出太大且无法浏览。我尝试使用内置的调试工具，该工具可以配合 Eclipse 的 [Chrome 开发者工具插件](https://github.com/joyent/node/wiki/using-eclipse-as-node-applications-debugger) 使用。不幸的是，我遇到了设置断点检查对象时，服务器停止响应心跳包，导致客户端断开连接的问题。这完全破坏了我的调试过程。我真正需要的只是一个检查对象的好方法。

我在 Google 上搜索，发现了像 [node-inspector](https://github.com/dannycoates/node-inspector) 这样的项目，但它们不支持最新版本的 Node，还有 [node-codein](http://thomashunter.name/blog/nodejs-console-object-debug-inspector/) 有很多漏洞，而且这两个都不支持 Firefox。于是，Node Monkey 就诞生了！

## 功能

- 将应用程序的控制台输出日志发送到浏览器控制台，便于检查
  - 为使用 Bunyan 的用户提供一个流（见[这里](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#nodemonkeybunyan_stream)）
- 提供 SSH 功能，使您可以进入应用程序的 shell 进行检查、调试或控制应用程序  
- 为您的应用程序注册命令，这些命令可以从浏览器控制台或 SSH 界面执行  

## 安装  

```
npm install --save node-monkey
```
如果您有兴趣测试实验性和即将推出的功能，请改用以下命令：


```
npm install --save node-monkey@next
```

## 快速使用

虽然 Node Monkey 支持许多功能，但入门设计得非常简单。你只需在应用程序中包含一两行代码。此后所有输出到控制台的内容，一旦连接上就会显示在浏览器控制台中。它捕获大多数 `console.*` 函数调用的输出，并将输出转发到浏览器以便检查。

最简单的用法如下：

```js
const NodeMonkey = require("node-monkey")
NodeMonkey()
```

Node Monkey 还支持许多配置[选项](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options)和命名实例。调用形式为 `NodeMonkey([options[, name])`。例如，要禁止本地控制台输出，仅在已连接的浏览器或终端中查看输出，可以这样做：

```js
const NodeMonkey = require("node-monkey")
const monkey = NodeMonkey({
  server: {
    disableLocalOutput: true,
  },
})
```

您可以在应用程序中的所有文件中包含 Node Monkey，如果像上面示例那样使用，每次调用 `NodeMonkey()` 都会始终返回您首次构造的相同实例，忽略后续调用中传递的任何选项。 但是，您可能希望使用不同的选项构造新实例。为此，请为您的实例命名：

```js
const NodeMonkey = require("node-monkey")
const monkey1 = NodeMonkey() // Creates an instance named 'default'
const monkey2 = NodeMonkey("george") // Creates a new instance with default options
const monkey3 = NodeMonkey(
  {
    // Creates a new instance with custom options named 'ninja'
    server: {
      silent: true,
    },
  },
  "ninja",
)
```
如果您没有为额外的实例指定端口，它将自动为您设置，并从默认端口递增（例如，websocket服务器为50502、50504，SSH服务器为50503、50505）。

要在另一个文件中获取已构建的实例，只需再次使用名称调用它：


```js
const NodeMonkey = require("node-monkey")
const monkey3 = NodeMonkey("ninja")
```

当您启动应用程序时，您将看到以下输出：

```
Node Monkey listening at http://0.0.0.0:50500
```
要连接您的浏览器，只需访问网页浏览器中显示的地址（在本例中为 `http://0.0.0.0:50500`）。如果您更改了默认的 `host` 和 `port` 绑定或传入了自己的服务器，请务必相应调整您的 URL。它会提示您输入用户名和密码。在您设置用户之前，默认用户名和密码均为 `guest`。

如果您提供了自己的服务器，您可以直接在自己的 Web 应用程序控制台中查看输出。要了解如何提供自己的服务器，请查看[文档](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own)。您需要在 HTML 源代码中包含以下 `<script>` 标签，以将 Node Monkey 的输出集成到您的应用中：


```html
<script type="text/javascript" src="http://0.0.0.0:50500/monkey.js"></script>
```

**NOTE**: You do NOT have to refresh the page when you restart your Node.js application to continue to receive output. Node Monkey will automatically reconnect.

---

### LICENSE: [MIT](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-23

---