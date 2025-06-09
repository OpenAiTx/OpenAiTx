# [jQuery](https://jquery.com/) — 新一代 JavaScript

会议目前在 [matrix.org 平台](https://matrix.to/#/#jquery_meeting:gitter.im) 上举行。

会议纪要可在 [meetings.jquery.org](https://meetings.jquery.org/category/core/) 查阅。

jQuery 的最新版本可在 [https://jquery.com/download/](https://jquery.com/download/) 获取。

## 版本支持

| 版本    | 分支         | 状态     |
| ------- | ------------ | -------- |
| 4.x     | main         | Beta     |
| 3.x     | 3.x-stable   | 活跃     |
| 2.x     | 2.x-stable   | 不活跃   |
| 1.x     | 1.x-stable   | 不活跃   |

一旦 4.0.0 正式版发布，3.x 分支将在有限时间内继续收到更新。2.x 和 1.x 分支已不再受支持。

不活跃版本的商业支持由 [HeroDevs](https://herodevs.com/nes) 提供。

了解更多关于我们的[版本支持](https://jquery.com/support/)信息。

## 贡献指南

本着开源软件开发的精神，jQuery 始终鼓励社区成员贡献代码。为帮助你顺利开始并在编码前，请务必认真阅读以下重要的贡献指南：

1. [参与方式](https://contribute.jquery.org/)
2. [核心代码风格指南](https://contribute.jquery.org/style-guide/js/)
3. [为 jQuery 项目编写代码](https://contribute.jquery.org/code/)

### 问题/PR 的引用

GitHub 问题/PR 通常通过 `gh-NUMBER` 引用，其中 `NUMBER` 是问题/PR 的数字 ID。你可以在 `https://github.com/jquery/jquery/issues/NUMBER` 下找到相应的问题或 PR。

jQuery 过去曾使用基于 Trac 的不同 Bug 跟踪器，可在 [bugs.jquery.com](https://bugs.jquery.com/) 访问。该站点已设为只读模式，便于参考以往讨论。当 jQuery 源码中引用这些问题时，使用 `trac-NUMBER` 格式，其中 `NUMBER` 是问题的数字 ID。你可以在 `https://bugs.jquery.com/ticket/NUMBER` 下找到相应问题。

## jQuery 可用的环境

- [浏览器支持](https://jquery.com/browser-support/)
- jQuery 还支持 Node、浏览器扩展和其他非浏览器环境。

## 构建你自己的 jQuery 所需环境

要构建 jQuery，你需要安装最新的 Node.js/npm 和 git 1.7 或更高版本。更早的版本可能可用，但不受支持。

在 Windows 下，你需要下载并安装 [git](https://git-scm.com/downloads) 和 [Node.js](https://nodejs.org/en/download/)。

macOS 用户应安装 [Homebrew](https://brew.sh/)。安装好 Homebrew 后，运行 `brew install git` 安装 git，运行 `brew install node` 安装 Node.js。

Linux/BSD 用户应使用各自的包管理器安装 git 和 Node.js，或者自行编译源码。如果你喜欢，也可以这么做。很简单。

## 如何构建你自己的 jQuery

首先，[克隆 jQuery git 仓库](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository)。

然后，进入 jquery 目录，安装依赖并运行构建脚本：

```bash
cd jquery
npm install
npm run build
```

构建好的 jQuery 会被放在 `dist/` 目录下，还包括一个压缩版和相关的 map 文件。

## 构建所有 jQuery 发布文件

要构建所有 jQuery 变体，运行以下命令：

```bash
npm run build:all
```

这将创建 jQuery 发布版中包含的所有变体，包括 `jquery.js`、`jquery.slim.js`、`jquery.module.js` 和 `jquery.slim.module.js` 及其相关的压缩文件和 sourcemap。

`jquery.module.js` 和 `jquery.slim.module.js` 是 [ECMAScript 模块](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules)，导出 `jQuery` 和 `$` 作为命名导出，放在 `dist-module/` 目录下，而不是 `dist/` 目录。

## 构建自定义 jQuery

构建脚本可以用来创建只包含你需要模块的自定义 jQuery 版本。

除了 `core` 外，任何模块都可以被排除。当排除 `selector` 时，并不会被移除，而是用一个围绕原生 `querySelectorAll` 的小包装器替代（详见下文）。

### 构建脚本帮助

要查看构建脚本的完整可用选项列表，运行以下命令：

```bash
npm run build -- --help
```

### 模块

要排除某个模块，将其相对于 `src` 文件夹的路径（不带 `.js` 后缀）传递给 `--exclude` 选项。使用 `--include` 选项时，默认包含项将被移除，只会构建包含这些模块的版本。

一些可以被排除或包含的示例模块：

- **ajax**：所有 AJAX 功能：`$.ajax()`、`$.get()`、`$.post()`、`$.ajaxSetup()`、`.load()`、transports 及诸如 `.ajaxStart()` 的 ajax 事件简写方法。
- **ajax/xhr**：仅 XMLHTTPRequest AJAX 传输。
- **ajax/script**：仅 `<script>` AJAX 传输；用于获取脚本。
- **ajax/jsonp**：仅 JSONP AJAX 传输；依赖 ajax/script 传输。
- **css**：`.css()` 方法。也会移除**所有**依赖于 css 的模块（包括 **effects**、**dimensions** 和 **offset**）。
- **css/showHide**：非动画的 `.show()`、`.hide()` 和 `.toggle()`；如果你使用类或显式 `.css()` 调用设置 `display` 属性，则可以排除。也会移除 **effects** 模块。
- **deprecated**：已标记为弃用但尚未移除的方法。
- **dimensions**：`.width()` 和 `.height()` 方法，包括 `inner-` 和 `outer-` 变体。
- **effects**：`.animate()` 方法及其简写如 `.slideUp()` 或 `.hide("slow")`。
- **event**：`.on()` 和 `.off()` 方法及所有事件功能。
- **event/trigger**：`.trigger()` 和 `.triggerHandler()` 方法。
- **offset**：`.offset()`、`.position()`、`.offsetParent()`、`.scrollLeft()` 和 `.scrollTop()` 方法。
- **wrap**：`.wrap()`、`.wrapAll()`、`.wrapInner()` 和 `.unwrap()` 方法。
- **core/ready**：如果你的脚本放在 body 末尾，可以排除 ready 模块。通过 `jQuery()` 绑定的 ready 回调会立即调用，但 `jQuery(document).ready()` 将不再是函数，`.on("ready", ...)` 或类似写法也不会被触发。
- **deferred**：排除 jQuery.Deferred。也会排除所有依赖 Deferred 的模块，包括 **ajax**、**effects** 和 **queue**，但用 **core/ready-no-deferred** 替换 **core/ready**。
- **exports/global**：不将全局 jQuery 变量（$ 和 jQuery）附加到 window。
- **exports/amd**：排除 AMD 定义。

- **selector**：完整的 jQuery 选择器引擎。当排除此模块时，将用基于浏览器 `querySelectorAll` 方法的简易选择器引擎替代，不支持 jQuery 选择器扩展或增强语义。详见 [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) 文件。

*注意*：排除完整的 `selector` 模块也会排除所有 jQuery 选择器扩展（如 `effects/animatedSelector` 和 `css/hiddenVisibleSelectors`）。

##### AMD 名称

你可以为 jQuery 的 AMD 定义设置模块名称。默认设置为 "jquery"，这与插件和第三方库兼容，但在某些情况下你可能希望更改。可以将其传递给 `--amd` 参数：

```bash
npm run build -- --amd="custom-name"
```

或者，若要匿名定义，名称留空即可。

```bash
npm run build -- --amd
```

##### 文件名和目录

构建后的 jQuery 文件默认名为 `jquery.js`，位于 `dist/` 目录下。可以通过 `--filename` 更改文件名，通过 `--dir` 更改目录。`--dir` 相对于项目根目录。

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

此命令会创建一个精简版 jQuery，并放在 `tmp/jquery.slim.js` 下。

##### ECMAScript 模块 (ESM) 模式

默认情况下，jQuery 生成常规的 JavaScript 脚本文件。你也可以使用 `--esm` 参数生成一个以 `jQuery` 作为默认导出的 ECMAScript 模块：

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### 工厂模式

默认情况下，jQuery 依赖全局 `window`。对于没有 `window` 的环境，可以生成工厂构建，暴露一个接受 `window` 作为参数的函数，你可以在外部传递（用法详见已发布包的[`README`](build/fixtures/README.md)）。可通过 `--factory` 参数生成此类工厂：

```bash
npm run build -- --filename=jquery.factory.js --factory
```

此选项可以与其他选项如 `--esm` 或 `--slim` 组合使用：

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### 自定义构建示例

使用 `npm run build` 创建自定义构建，列出要排除的模块。排除顶级模块也会排除其相应目录下的所有模块。

排除所有 **ajax** 功能：

```bash
npm run build -- --exclude=ajax
```

排除 **css** 会移除依赖 CSS 的模块：**effects**、**offset**、**dimensions**。

```bash
npm run build -- --exclude=css
```

排除多个模块（`-e` 是 `--exclude` 的别名）：

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

有一个特殊的别名用于生成与官方 jQuery Slim 构建相同配置的版本：

```bash
npm run build -- --filename=jquery.slim.js --slim
```

或者，将 slim 构建为 esm 模块：

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*非官方自定义构建未经过定期测试。请自行承担使用风险。*

## 运行单元测试

确保你已经安装了所需的依赖项：

```bash
npm install
```

启动 `npm start`，在开发过程中自动构建 jQuery：

```bash
npm start
```

使用支持 PHP 的本地服务器运行单元测试。请确保从根目录（而不是 "test" 目录）运行该站点。不需要数据库。Windows 和 Mac 上有预配置的 PHP 本地服务器可用。以下是一些选项：

- Windows: [WAMP 下载](https://www.wampserver.com/en/)
- Mac: [MAMP 下载](https://www.mamp.info/en/downloads/)
- Linux: [LAMP 搭建教程](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose（多平台）](https://code.google.com/p/mongoose/)

## 基本 Git 操作

由于源代码由 Git 版本控制系统管理，了解一些常用功能会很有帮助。

### 清理

如果你想将工作目录还原到上游的状态，可以使用以下命令（注意：你所有的更改都会被清除）：

```bash
git reset --hard upstream/main
git clean -fdx
```

### 变基

对于功能/主题分支，始终应在 `git pull` 时使用 `--rebase` 标志，或者如果你经常处理许多临时的 “待提交到 GitHub 的 Pull Request” 分支，可以运行以下命令自动完成此操作：

```bash
git config branch.autosetuprebase local
```

（参见 `man git-config` 获取更多信息）

### 处理合并冲突

如果在合并时遇到合并冲突，与其手动编辑冲突文件，不如使用 `git mergetool` 工具。尽管默认工具 `xxdiff` 看起来很老旧，但其实非常有用。

以下是一些可用命令：

- `Ctrl + Alt + M` - 尽可能自动合并
- `b` - 跳转到下一个合并冲突
- `s` - 更改冲突行的顺序
- `u` - 撤销一次合并
- `鼠标左键` - 选中一个区块作为最终版本
- `鼠标中键` - 选中一行为最终版本
- `Ctrl + S` - 保存
- `Ctrl + Q` - 退出

## [QUnit](https://api.qunitjs.com) 参考

### 测试方法

```js
expect( numAssertions );
stop();
start();
```

*注意*：QUnit 未来可能为 stop/start 增加参数，但在本测试套件中会忽略，因此可以安全地将 start 和 stop 作为回调传递，无需担心参数问题。

### 断言方法

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## 测试套件便捷方法参考

详见 [test/data/testinit.js](https://raw.githubusercontent.com/jquery/jquery/main/test/data/testinit.js)。

### 返回具有指定 ID 的元素数组

```js
q( ... );
```

示例：

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### 断言选择器匹配指定 ID

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

示例：

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### 触发原生 DOM 事件（不经过 jQuery）

```js
fireNative( node, eventType );
```

示例：

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### 向 URL 添加随机数以防缓存

```js
url( "some/url" );
```

示例：

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### 在 iframe 中运行测试

有些测试可能需要使用标准测试夹具以外的文档，可以在独立的 iframe 中运行。这些测试的实际代码和断言仍然保留在 jQuery 的主测试文件中；只有最小化的测试夹具标记和初始化代码应放在 iframe 文件中。

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

此方法会加载一个页面，使用 `"./data/" + fileName` 构造 url。iframe 页面通过引入 "/test/data/iframeTest.js" 脚本并在适当时机调用 `startIframeTest( [ additional args ] )` 来决定何时回调。通常是在 document ready 或 `window.onload` 之后。

`testCallback` 会接收由 `testIframe` 为本次测试创建的 QUnit `assert` 对象，随后依次为 iframe 的全局 `jQuery`、`window` 和 `document`。如果 iframe 代码向 `startIframeTest` 传递了参数，这些参数会跟在 `document` 后面。

## 有问题？

如有任何问题，欢迎在 [Developing jQuery Core 论坛](https://forum.jquery.com/developing-jquery-core) 或 [libera](https://web.libera.chat/) 的 #jquery 频道提问。
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---