<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

你可以阅读我的[论文](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)，引用如下
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

由于 GitHub 可能会屏蔽中国大陆的 IP 地址，我不得不将此仓库复制到[这里](https://codeberg.org/ufo5260987423/scheme-langserver)和[这里](https://gitee.com/ufo5260987423/scheme-langserver)。我会持续更新所有仓库，但无法保证同步。目前我也在与[XmacsLabs](https://github.com/XmacsLabs)合作，你也可以在[这里](https://github.com/XmacsLabs/scheme-langserver)找到一个分支。

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**现在，VSCode 已经可以使用 scheme-langserver！** 请参考[这里](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)。

>注意：scheme-langserver 目前有很多很多 bug。我正在修复并寻求社区的帮助。请耐心等待。

>注意：你可以在[这里](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result)找到自动生成的类型信息。这目前主要用于下一阶段开发（也许包括 AKKU）和调试。

实现诸如自动补全、跳转定义或悬停文档等功能，对于编程来说是一项重要工作。然而，与 java、python、javascript 和 c 等其他语言相比，Lisp 语言的语言服务器协议实现基本处于真空状态。[Geiser](https://gitlab.com/emacs-geiser)、[racket langserver](https://github.com/jeapostrophe/racket-langserver) 和 [swish-lint](https://github.com/becls/swish-lint) 等，它们的实现都是基于 `repl`（Read-Eval-Print Loop）或关键字分词器，而不是编程本身。例如，如果程序员正在编写一个尚未完成的项目，其中代码并未完全可执行，[Geiser](https://gitlab.com/emacs-geiser) 或其他工具只会补全通过 `environment-symbols`（以 [Chez](https://cisco.github.io/ChezScheme/) 为例）过程列出的顶层绑定标识符，或者补全符号而不是标识符。这意味着对于局部绑定和未完成的代码，尽管为编程做努力本应最重要，[Geiser](https://gitlab.com/emacs-geiser) 及其同类工具在识别标识符有效作用域方面毫无帮助。类似的情况也出现在跳转定义和许多其他功能上。

主要原因在于，对于 scheme 及其他 lisp 方言，其丰富的数据结构和灵活的控制结构使得程序分析成为一项巨大挑战。尤其是宏，似乎 scheme 主要用于天才和元/宏编程。但我认为不是这样。如果能提供更好的编程环境，Scheme 可以做许多有趣的事情。现在你可以[**从这里开始**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)。

本项目是一个帮助 scheme 编程的语言服务器协议实现。它提供补全、定义和类型推断。这些功能建立在对 [r6rs 标准](http://www.r6rs.org/) 以及针对未完成代码的一些显式规则的静态代码分析之上。本项目本身及相关库已发布或将要通过 [Akku](https://akkuscm.org/) 发布，Akku 是 Scheme 的包管理器。

本项目已在 [Chez Scheme](https://cisco.github.io/ChezScheme/) 9.4 和 9.5 版本上测试过。10.0.0 版本的详细测试将在我升级笔记本操作系统后完成。

我只是业余时间做这个开源项目，但我能为社区带来许多精彩想法，比如将数据流分析嵌入 scheme-langserver 或其他功能。同时我也在不断寻求更多捐助和资金支持。你可以通过[这个 patreon 页面](https://www.patreon.com/PoorProgrammer/membership)或[爱发电](https://afdian.com/a/ufo5260987423)进行捐赠。


## 编译、安装与配置请见[这里](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## 最新进展
我会持续修复 bug、分析代码性能，并为我的自制类型推断系统大书收集资料。这大约需要一年时间。后续开发包括 [VScode](https://code.visualstudio.com/) 插件和数据流分析。但实际上，现在我把这个开源项目当成兼职，无法保证开发进度。

## 版本发布 
1.2.9 现在，享受类型推断吧！

历史版本请参见[这个文件](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md)。

### 功能特色
1. 顶层和局部标识符绑定补全。
![顶层和局部标识符绑定](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. 跳转定义。
![使用 telescope.nvim 跳转定义](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. 兼容包管理器 Akku。
4. 文件变更同步及对应索引更新。
5. 悬停（Hover）。
6. 引用与文档高亮（文档范围内引用）。
![使用 telescope.nvim 查找引用](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. 文档符号。
![使用 telescope.nvim 查找文档符号](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. 捕获 *-syntax（define-syntax, let-syntax 等）形式的本地标识符绑定。
9. 跨平台并行索引。
10. 自制源码注释器，兼容 .sps 文件。
11. 面向 API 请求的窥孔优化，支持可挂起任务。
12. 基于自制 DSL 解释器的类型推断（我对此非常自豪！）。现在已嵌入到自动补全中。如下图所示，类型为 "integer?" 的 "length-b" 和 "length-a" 在推荐选项最前，因为它们能匹配 "<=" 所要求的参数类型。
![带类型推断的自动补全](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
一次测试即可验证该结果，运行 `scheme --script tests/protocol/apis/test-completion.sps`，日志文件 `scheme-langserver.log` 会包含如下内容：
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. 支持不同文件扩展名（如 scm, ss, sps, sls, sld）下的标识符捕获的抽象解释器。

### TODO
14. 重命名。
15. 完全兼容 [r6rs 标准](http://www.r6rs.org/)。
16. 步进式宏展开器：事实上我已经实现了一个，并打算用它作为自定义宏中标识符绑定捕获的关键步骤。现在，我发现这项捕获比想象中难得多，而这个展开器我还不知道能用在哪里。
17. 代码求值。
18. 代码诊断。
19. 增加跨语言语义支持。那么，Java、C、Python 以及许多其他语言能否通过 AST 转换器得到支持？
20. 将表达式/语句提取为过程。

## TODO:贡献

## 调试

### 如何调试
https://www.scheme.com/debug/debug.html#g1

### 输出日志
按照 [构建](#building)、[Lunar Vim 安装](#installation-for-lunarvim) 和 [VScode 安装](#todo-installation-for-vscode) 的提示，如果有人想要进行开发并记录日志，可以方便地添加 `path-to-log-file` 并重写文件 `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua`，内容如下：
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
`scheme-langserver`，一个 scheme 的语言服务器协议实现
]]   ,
  },
}
```
### 日志复现
利用上述 [输出日志](#output-log)，你可以使用 `tests/log-debug.sps` 复现 bug：
1. 将 `{path-to-log}`（通常为 `~/scheme-langserver.log`）重命名为 `~/ready-for-analyse.log`；
2. 运行 `scheme --script tests/log-debug.sps`。如果你想重现多线程环境，也可以运行 `scheme --script tests/log-debug.sps`。

## 测试
几乎所有关键过程和 API 都经过了测试。我的工作虽然粗糙但很有用，你可以在 `tests` 目录中找到我的成果，或者在 `{scheme-langserver-root-directory}` 下直接运行以下命令
``` bash
bash test.sh
```
>注意
在线程环境下做测试很难。因此，目前的测试主要集中在单线程环境下。

## 将 Scheme-langserver 用于其他目的
### GIMP 中的 Script-Fu
Script-Fu 基于一种解释型语言 Scheme，通过函数与 GIMP 的内部函数交互。以[本页面](https://dalelane.co.uk/blog/?p=628)的脚本为例，你可以将 scheme-langserver 应用于扩展名为 "SCM" 的脚本文件。

### 其他

嗯，我也对 [OMN (Opusmodus Notation)](https://opusmodus.com/) 和 AutoLisp 感兴趣。但我还有很多事情要做。

## 代码统计
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## 详细文档
1. [Scheme-langserver：将 Scheme 代码编辑作为一等公民对待](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)。
2. [捕获标识符绑定](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [同步](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md)，~~[类型推断（中文）](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~（已废弃，目前正在为此编写中文书籍）
5. [API 分析](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star 历史

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## 贡献者

![贡献者](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---