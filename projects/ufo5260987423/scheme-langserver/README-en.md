![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

You may read my [paper](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) and cite it as follows
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

Since GitHub may block Chinese IP addresses, I have copied this repository to [here](https://codeberg.org/ufo5260987423/scheme-langserver) and [here](https://gitee.com/ufo5260987423/scheme-langserver). I will continue to update all repositories but I can't guarantee it. I am now also collaborating with [XmacsLabs](https://github.com/XmacsLabs), and you may also find a fork [here](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Now, VSCode can use scheme-langserver!** Please refer to [HERE](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>NOTE: There are many bugs in scheme-langserver. I'm fixing them and asking for help from the community. Please be patient.

>NOTE: You can find the auto-generated type information [here](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). It is now mainly used for next-stage development (maybe including AKKU) and debugging.

Implementing features like autocomplete, go to definition, or documentation on hover is a significant programming effort. However, compared to other languages like Java, Python, JavaScript, and C, language server protocol implementations for Lisp languages are just made in a vacuum. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) and [swish-lint](https://github.com/becls/swish-lint), etc., their work is all based on `repl` (Read-Eval-Print Loop) or keyword tokenizer instead of programming. For example, if a programmer is coding on an unfinished project, in which the code is not fully executable, [Geiser](https://gitlab.com/emacs-geiser) or others would only complete top-level binding identifiers listed by the `environment-symbols` procedure (for [Chez](https://cisco.github.io/ChezScheme/)), or complete symbols instead of identifiers. This means for local bindings and unfinished code, even though programming effort is supposed to be most important, [Geiser](https://gitlab.com/emacs-geiser) and its counterparts are of no help in recognizing an identifier's valid scope. Similar issues occur with go to definition and many other functionalities.

A primary cause is that, for Scheme and other Lisp dialects, their abundant data sets and flexible control structures make program analysis a big challenge. Especially macros, as it seems Scheme is mainly used for genius and meta/macro programming. But I say no. Scheme can do many interesting things if a better programming environment is provided. And now you may [**STARTUP HERE**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

This package is a language server protocol implementation that helps Scheme programming. It provides completion, definition, and type inference. These functionalities are established on static code analysis with the [r6rs standard](http://www.r6rs.org/) and some obvious rules for unfinished code. This package itself and related libraries are published or will be published with [Akku](https://akkuscm.org/), which is a package manager for Scheme.

This package has also been tested with [Chez Scheme](https://cisco.github.io/ChezScheme/) versions 9.4 and 9.5. A detailed test on version 10.0.0 will be done after I upgrade my laptop OS to a newer version.

I do this open source work just in my spare time and I can contribute many splendid ideas to the community, like embedding data flow analysis into scheme-langserver or many other things. And I'm continuously asking for much more donation or funding. You can donate with [this Patreon page](https://www.patreon.com/PoorProgrammer/membership) or [Afdian](https://afdian.com/a/ufo5260987423).

## Compilation, Installation & Configuration is [HERE](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Recent Status
I'll keep fixing bugs, profiling the code, and collecting information for my giant book on homemade type inference systems. This will take me about 1 year. Further developments include a [VScode](https://code.visualstudio.com/) plugin and data flow analysis. But actually, I'm now treating this open source work as a part-time job, and I cannot guarantee a schedule.

## Release 
1.2.9 Now, enjoy type inference!

For previous releases, please refer to [this file](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Features
1. Top-level and local identifier binding completion.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Go to definition.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Compatible with package manager: Akku.
4. File changes synchronizing and corresponding index updating.
5. Hover.
6. References and document highlight (document-scoped references).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Document symbol.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Catching *-syntax (define-syntax, let-syntax, etc.) based local identifier binding.
9. Cross-platform parallel indexing.
10. Self-made source code annotator to be compatible with .sps files.
11. Peephole optimization for API requests with suspendable task.
12. Type inference with a homemade DSL interpreter (I'm very proud of it!). And now it has been embedded into the auto-completion. As the following figure indicates, the "length-b" and "length-a" having "integer?" type are in the front of those recommended options because they can match the parameter type required by "<=".
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
A test can prove this result. Just run `scheme --script tests/protocol/apis/test-completion.sps` and the log file `scheme-langserver.log` will contain results like this:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Abstract interpreter for identifier catching among different file extensions like scm, ss, sps, sls and sld.

### TODOs
14. Renaming.
15. Fully compatible with [r6rs standard](http://www.r6rs.org/).
16. Step-by-step macro expander: well, I actually have implemented one and I wanted to make it a key step to catch identifier binding in self-defined macros. Now, I find this catching is much harder than I thought, and I don't know where the expander could work.
17. Code eval.
18. Code diagnostics.
19. Add cross-language semantic support. Well, can Java, C, Python and many other languages be supported with an AST transformer?
20. Extract expressions/statements into a procedure.

## TODO: Contributing

## Debug

### How to Debug
https://www.scheme.com/debug/debug.html#g1

### Output Log
Following the tips from [Building](#building), [Installation for Lunar Vim](#installation-for-lunarvim) and [Installation for VScode](#todo-installation-for-vscode), if anyone wants to do some development and log something, it will be convenient to add `path-to-log-file` and re-write the file `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` as follows:
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
}
```
### Recurring with Log 
With the above [output log](#output-log), you can use `tests/log-debug.sps` to reproduce bugs:
1. Rename `{path-to-log}` (usually `~/scheme-langserver.log`) to `~/ready-for-analyse.log`;
2. Run `scheme --script tests/log-debug.sps`. If you want to reproduce the multi-threaded environment, you can also run `scheme --script tests/log-debug.sps`.

## Test
Almost all key procedures and APIs are tested. My work is still rough but useful; maybe you would like to see what I've done in the `tests` directory or just run the following command in the `{scheme-langserver-root-directory}`:
```bash
bash test.sh
```
>NOTE
It's hard to test with a threaded environment. So, current tests focus on single-thread.

## Use Scheme-langserver for Other Purposes
### Script-Fu in GIMP
Script-Fu is based on an interpreted language called Scheme, and works by using functions that interact with GIMP's internal functions. Taking [this page](https://dalelane.co.uk/blog/?p=628)'s script as an example, you can use scheme-langserver with script files with the "SCM" extension.

### Others

Well, I'm also interested in [OMN (Opusmodus Notation)](https://opusmodus.com/) and AutoLisp. But I still have many things to do.

## Code Count
```bash
find . -name "*.sls" ! -path "./.akku/*" | xargs wc -l
```
## Detailed Documentation
1. [Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Catching identifier bindings](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchronizing](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~ (Deprecated, and I'm writing a Chinese book for it)
5. [API Analysis](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Contributors

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---