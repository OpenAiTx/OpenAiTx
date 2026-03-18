# mdfried

`mdfried` 是一个终端的 Markdown 查看器，它将标题渲染为比其他文本更**大号的文字**。

## 截图

![Screenshot](https://raw.githubusercontent.com/benjajaja/mdfried/master/./assets/screenshot_1.png)

[来自 `master` 的最新测试截图集](https://benjajaja.github.io/mdfried-screenshots/)

## 视频

https://github.com/user-attachments/assets/e69154a7-bea8-4e14-a677-be7ccf0d3cac

# 为什么？

你可以用 *[ratatui](https://ratatui.rs/)* “烹饪”一个终端。但你能**油炸**一个终端吗？
*能！* 你可以**烹饪*并且*油炸**你的 `tty`！~~趁还没迟赶紧跑！~~

> 终端通常处于“烹饪”模式，或称规范模式。
> 使用 `ratatui`🐁，它处于原始模式，但它会为你“烹饪”。

Markdown 显然可以在终端中很好地渲染，但有一个关键方面缺失：
大标题™ 让文本更易读，且内联渲染图片非常方便。

# 怎么做？

通过将标题作为 [ratatui 图片](https://github.com/benjajaja/ratatui-image)渲染，
并使用几种终端图形协议之一：Sixels、Kitty 或 iTerm2。
Kitty 终端还实现了一个 [文本缩放协议](https://sw.kovidgoyal.net/kitty/text-sizing-protocol/)
可以直接缩放文本，无需渲染成图片！

请参见 [ratatui-image](https://github.com/benjajaja/ratatui-image?tab=readme-ov-file#compatibility-matrix)
查看你的终端是否支持图形，以及更多细节。

一般来说，Kitty、WezTerm、iTerm2、Ghostty、Foot、`xterm -ti vt340`，*应该*都能用。

在完全不支持图形的终端，如 Alacritty，图片则使用 Chafa 渲染。


# 安装

* Rust cargo: `cargo install mdfried`
  * 从源码安装：`cargo install --path .`
  * 需要带有开发头文件的 chafa 包，通常名称类似 `libchafa-dev`、`libchafa-devel`、或者只是 `libchafa`，甚至直接叫 `chafa`。
  * 如果完全没有 chafa，或者你不在意它，因为你的终端支持某些图形协议，可以使用 `--no-default-features`。
  * 如果 `cargo install ...` 失败，尝试加上 `--locked`，或者报告一个问题。
* Nix flake: `github:benjajaja/mdfried`
* Nixpkgs: [`mdfried`](https://search.nixos.org/packages?channel=unstable&query=mdfried)
* Arch Linux: `pacman -S mdfried` ([extra 仓库](https://archlinux.org/packages/extra/x86_64/mdfried/))
* Ubuntu: [下载发布版 .deb](https://github.com/benjajaja/mdfried/releases/latest)
* Mac: `brew install mdfried` 或者 [发布的二进制文件](https://github.com/benjajaja/mdfried/releases/latest)
* Windows: [下载发布版 .exe](https://github.com/benjajaja/mdfried/releases/latest)

# 使用

### 运行

```
mdfried ./path/to.md
```
除非您使用的是 Kitty 0.40 版或更高版本，或终端不支持任何图形协议，
否则第一次运行 `mdfried` 时，您需要选择一个字体。
您应该选择与终端正在使用的字体相同的字体，但也可以选择任何字体。
字体设置屏幕允许您搜索系统字体——您需要选择与终端正在使用的字体相同的字体。
字体将直接以预览形式呈现。
确认后，选择将写入配置文件。

如果字体不正确，可以使用 `--setup` 强制重新设置字体。

您也可以将 Markdown 内容通过管道传入：



```
readable https://lobste.rs | markdownify | mdfried
```
### 主要快捷键

键 | 描述
----|------------
`q` 或 `Ctrl-c` | 退出并保留终端内容
`r` | 重新加载文件（除非是管道标准输入）
`j` | 向下滚动一行
`k` | 向上滚动一行
`d` 或 `Ctrl-d` | 向下滚动半页
`u` 或 `Ctrl-u` | 向上滚动半页
`f` 或 `PageDown` 或 `Space` | 向下滚动一页
`b` 或 `PageUp` | 向上滚动一页
`g` | 跳转到文件开头
`G` | 跳转到文件结尾
`<number>G` 或 `<number>g` | 跳转到字符串 #\<number>
`/` | 搜索文本
`n` | 跳转到下一个匹配或链接
`N` | 跳转到上一个匹配或链接
`Enter` | 使用 `xdg-open` 打开选中的链接
`Esc` | 退出搜索或链接模式

在移动操作前输入数字，会执行相应次数的移动。

鼠标滚动仅在设置中启用 `enable_mouse_capture = true` 时有效，但启用后无法选择文本。

### 配置

`~/.config/mdfried/config.toml` 会在首次运行时自动创建。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---