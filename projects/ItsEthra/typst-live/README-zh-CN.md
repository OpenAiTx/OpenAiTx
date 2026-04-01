# Typst-live
这是一个简单的工具，用于监视您的 [typst](https://github.com/typst/typst) 文件的更改并自动
重新编译它们以实现实时反馈。`typst-live` 允许您在浏览器中打开一个标签页，显示 typst 生成的 pdf，并在源 `.typ` 文件更改时自动重新加载。

## 与 `--watch` 标志的区别
`typst-live` 托管一个网页服务器，自动刷新页面，因此您无需像使用 `typst --watch` 那样手动刷新页面。

## 安装
如果您已经安装了 [rust](https://www.rust-lang.org)，请使用以下命令：

```
cargo install typst-live
```
如果您使用 Nix，可以使用以下命令直接从 GitHub 仓库运行 typst-live：

```
nix run github:ItsEthra/typst-live
```

## 使用方法
### 1. 自动重新编译
* 从终端启动 `typst-live`：
```
$ typst-live <file.typ>
Server is listening on http://127.0.0.1:5599/
```
* 在浏览器中访问 `http://127.0.0.1:5599/`。
* 现在编辑你的 `file.typ`，浏览器标签页中会实时显示更改。

### 2. 手动重新编译方式
你可以使用 `typst-live` 来在不重新编译源文件的情况下重新加载 pdf 文件。
为此，你需要使用 `--no-recompile` 选项，该选项禁用重新编译，仅在浏览器标签页中托管
你的 pdf 文件，你需要指定的 `filename` 为 pdf 文件而非源 `.typ` 文件。
每当 pdf 文件发生变化，浏览器标签页将自动刷新。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-01

---