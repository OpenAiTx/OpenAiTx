![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

你可以阅读我的[论文](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)并按如下方式引用
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

由于 GitHub 可能会屏蔽中国大陆的 IP 地址，我不得不将此仓库复制到[这里](https://codeberg.org/ufo5260987423/scheme-langserver)和[这里](https://gitee.com/ufo5260987423/scheme-langserver)。我会持续更新所有仓库，但无法保证。同时我也与[XmacsLabs](https://github.com/XmacsLabs)合作，你也可以在[这里](https://github.com/XmacsLabs/scheme-langserver)找到一个分支。

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**现在，VSCode 可以使用 scheme-langserver 了！** 请参见[此处](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)。

>注意：scheme-langserver 还有很多很多 bug。我正在修复中，并寻求社区的帮助。请耐心等待。

>注意：你可以在[这里](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result)找到自动生成的类型信息。它目前主要用于下一阶段开发（也许包括 AKKU）和调试。

实现诸如自动补全、跳转定义或悬停文档等支持功能，对于编程来说是一项重大工作。然而，与 java、python、javascript 和 c 等其他语言相比，针对 lisp 语言的语言服务器协议实现几乎处于真空状态。[Geiser](https://gitlab.com/emacs-geiser)、[racket langserver](https://github.com/jeapostrophe/racket-langserver) 以及 [swish-lint](https://github.com/becls/swish-lint) 等等，它们的实现都基于 `repl`（读-求值-输出循环）或关键字分词器，而不是编程。例如，如果程序员正在一个未完成的项目中编写代码，代码尚未完全可执行，[Geiser](https://gitlab.com/emacs-geiser) 或其他工具只能补全由 `environment-symbols` 过程（对于 [Chez](https://cisco.github.io/ChezScheme/)）列出的顶层绑定标识符，或者补全符号而不是标识符。这意味着对于局部绑定和未完成的代码，尽管编程本应是最重要的，[Geiser](https://gitlab.com/emacs-geiser) 及其同类工具在识别标识符的有效作用域方面毫无帮助。类似的情况也出现在跳转定义和许多其他功能上。

主要原因是，对于 scheme 和其他 lisp 方言来说，其丰富的数据集和灵活的控制结构使得程序分析面临巨大挑战。尤其是宏，好像 scheme 主要是为天才和元/宏编程而用。但我认为不是这样。如果有更好的编程环境，Scheme 也可以实现许多有趣的功能。现在你可以[**从这里开始**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)。

本包是一个帮助 scheme 编程的语言服务器协议实现。它提供补全、定义和类型推断功能。这些功能基于[r6rs 标准](http://www.r6rs.org/)和一些针对未完成代码的显式规则进行静态代码分析建立。此包及相关库已经或将要通过 [Akku](https://akkuscm.org/) 发布，Akku 是 Scheme 的包管理器。

本包也已在 [Chez Scheme](https://cisco.github.io/ChezScheme/) 9.4 和 9.5 版本中测试过。将在我的笔记本操作系统升级后，对 10.0.0 版本做详细测试。

我只是业余时间做这个开源项目，我能为社区贡献许多精彩的想法，比如将数据流分析嵌入 scheme-langserver 或其它很多内容。同时我也在不断寻求更多的捐助或资助。你可以通过[这个 patreon 页面](https://www.patreon.com/PoorProgrammer/membership)或[爱发电](https://afdian.com/a/ufo5260987423)进行捐赠。

## 编译、安装与配置请见[这里](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## 最近状态
我会持续修复 bug，对代码进行性能分析，并为我的自制类型推断系统巨著收集资料。这将耗时约一年。后续开发包括 [VScode](https://code.visualstudio.com/) 插件和数据流分析。但实际上，我现在将这个开源工作当作兼职，无法保证进度。

## 发行说明
1.2.9 现在，体验类型推断功能！

以往的发布信息请参见[此文件](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md)。

### 功能特性
1. 顶层和局部标识符绑定补全。
![顶层和局部标识符绑定](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. 跳转定义。
![使用 telescope.nvim 跳转定义](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. 兼容包管理器：Akku。
4. 文件变动同步与相应索引变更。
5. 悬停功能。
6. 引用和文档高亮（文档范围内的引用）。
![使用 telescope.nvim 查找引用](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. 文档符号。
![使用 telescope.nvim 查找文档符号](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. 捕获 *-syntax（define-syntax, let-syntax 等）形式的局部标识符绑定。
9. 跨平台并行索引。
10. 自制源码注释器以兼容 .sps 文件。
11. API 请求的窥孔优化和可挂起任务。
12. 类型推断，基于自制 DSL 解释器（我为此非常自豪！）。现在类型推断已经集成进自动补全。如下图所示，类型为 "integer?" 的 "length-b" 和 "length-a" 会优先出现在推荐选项中，因为它们能匹配 "<=" 所需的参数类型。
![带类型推断的自动补全](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
一个测试可以证明该结果，只需运行 `scheme --script tests/protocol/apis/test-completion.sps`，日志文件 `scheme-langserver.log` 会包含如下内容：
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. 跨 scm、ss、sps、sls、sld 文件扩展名的标识符捕获抽象解释器。

### 待办事项
14. 重命名功能。
15. 完全兼容 [r6rs 标准](http://www.r6rs.org/)。
16. 步进式宏展开器：实际上，我已经实现了一个，我想用它作为捕获自定义宏标识符绑定的关键步骤。但现在我发现这种捕获比我想象的难得多，而且这个展开器我也不知道它能用在哪里。
17. 代码求值。
18. 代码诊断。
19. 增加跨语言语义支持。嗯，java、c、python 及许多其他语言是否可以通过 AST 转换器支持？
20. 抽取表达式/语句为过程。

## TODO: 贡献指南

## 调试

### 如何调试
https://www.scheme.com/debug/debug.html#g1

### 输出日志
按照 [编译](#building)、[Lunar Vim 安装](#installation-for-lunarvim) 和 [VScode 安装](#todo-installation-for-vscode) 的提示，如果有人想开发和记录日志，可以添加 `path-to-log-file` 并重写文件 `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` 如下：
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, a language server protocol implementation for scheme
]]   ,
  },
```
```
### 使用日志进行复现
通过上述的[输出日志](#output-log)，你可以使用 `tests/log-debug.sps` 来复现 bug：
1. 将 `{path-to-log}`（通常为 `~/scheme-langserver.log`）重命名为 `~/ready-for-analyse.log`；
2. 运行 `scheme --script tests/log-debug.sps`。如果你想复现多线程环境，也可以运行 `scheme --script tests/log-debug.sps`。

## 测试
几乎所有关键过程和 API 都经过了测试。我的工作虽然粗糙但很有用，也许你会想在 `tests` 目录下找到我完成的内容，或者直接在 `{scheme-langserver-root-directory}` 下运行如下命令：
``` bash
bash test.sh
```
>注意
在多线程环境下进行测试很难。因此，目前的测试主要集中在单线程环境下。

## 将 Scheme-langserver 用于其他目的
### GIMP 中的 Script-Fu
Script-Fu 基于一种解释型语言 Scheme，可以通过使用与 GIMP 内部函数交互的函数来工作。以[此页面](https://dalelane.co.uk/blog/?p=628)的脚本为例，你可以将 scheme-langserver 应用于扩展名为 "SCM" 的脚本文件。

### 其他

嗯，我对 [OMN (Opusmodus Notation)](https://opusmodus.com/) 和 AutoLisp 也很感兴趣。但我还有许多事情要做。

## 代码统计
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## 详细文档
1. [Scheme-langserver: 将 Scheme 代码编辑作为首要关注点](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)。
2. [捕获标识符绑定](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [同步机制](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md)，~~[类型推断（中文）](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~（已废弃，正在为其编写中文书籍）
5. [API 分析](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star 历史

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## 贡献者

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---