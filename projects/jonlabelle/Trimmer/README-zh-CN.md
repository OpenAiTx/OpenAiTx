# Trimmer

[![ci](https://github.com/jonlabelle/Trimmer/actions/workflows/ci.yml/badge.svg?branch=master)](https://github.com/jonlabelle/Trimmer/actions/workflows/ci.yml)
[![Package Control Installs](https://img.shields.io/packagecontrol/dt/Trimmer.svg?label=installs)](https://packagecontrol.io/packages/Trimmer)
[![Latest Release](https://img.shields.io/github/tag/jonlabelle/Trimmer.svg?label=version)](https://github.com/jonlabelle/Trimmer/releases)
[![MIT License](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/jonlabelle/Trimmer/blob/master/LICENSE.md)

> [Trimmer](https://github.com/jonlabelle/Trimmer) 是一个用于清理空白字符的 [Sublime Text](http://www.sublimetext.com) 插件。

## 功能

- 修剪每行末尾的空白字符。
- 修剪每行开头的空白字符。
- 修剪每行开头和末尾的空白字符。
- 修剪选中的内容中的空白字符。
- 删除空行及仅包含空白字符的行。
- 将连续多个空行合并为一行空行。
- 将连续多个空格合并为一个空格。
- 修剪文件开头和结尾的空行及仅包含空白字符的行。
- 移除空白字符。
- 规范化空格（减少连续空格，删除空行并修剪行）。
- 通过合并连续空格并修剪首尾空白来分词字符串。
- 删除空的、仅包含空白字符的 HTML 和 XML 标签。
- 移除代码注释并合并行。
- 删除相邻重复的行。

## 额外功能

一个 **替换智能字符** 命令，执行以下操作：

- **智能单引号：** `’` _替换为_ `'`
- **智能双引号：** `“` _替换为_ `"`
- **分钟符号：** `′` _替换为_ `'`
- **秒钟符号：** `″` _替换为_ `"`
- **德语引号：** `„` _替换为_ `"` 和 `‚` _替换为_ `'`
- **省略号：** `…` _替换为_ `...`
- **长破折号：** `—` _替换为_ `---`
- **短破折号：** `–` _替换为_ `--`
- **项目符号：** `•` _替换为_ `*`
- **中点符号：** `·` _替换为_ `-`
- **Em 空格** _替换为_ 三个空格  
- **En 空格** _替换为_ 两个空格  
- **不间断空格** _替换为_ 一个空格  
- **细空格** _替换为_ 一个空格  
- **发丝空格** _替换为_ 一个空格  
- **左尖括号引用:** `«` _替换为_ `<<`  
- **右尖括号引用:** `»` _替换为_ `>>`  
- **版权符号:** `©` _替换为_ `(C)`  
- **商标符号:** `™` _替换为_ `(T)`  
- **注册商标符号:** `®` _替换为_ `(R)`  

![屏幕截图](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/command_palette.png)  

观看一个[**快速演示**](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/demo.gif)  

## 安装  

Trimmer 兼容 Sublime Text 2 和 3 以及所有支持的操作系统。  

### Package Control  

安装 Trimmer 最简单且推荐的方式是使用 [Package Control](https://packagecontrol.io)。  

从主应用菜单，导航到：  

- `工具` -> `命令面板...` -> `Package Control: 安装软件包`，输入  
  词语 **_Trimmer_**，然后选择它以完成安装。  

### Git  

使用 Git 安装 Trimmer，请切换到您的 **Sublime Text Packages** 目录  
并克隆 [Trimmer 仓库](https://github.com/jonlabelle/Trimmer)。  

例如，在 **OS X** 上……启动一个新的 **终端** 会话并输入以下命令：


```shell
$ cd ~/Library/Application\ Support/Sublime\ Text\ 3/Packages/
$ git clone https://github.com/jonlabelle/Trimmer
```
### 手动安装

**下载**并**解压**[zip](https://github.com/jonlabelle/Trimmer/zipball/master)
或[tarball](https://github.com/jonlabelle/Trimmer/tarball/master)到你的
Sublime Text 插件目录。

**默认 Sublime Text 插件路径：**

- **OS X:** `~/Library/Application Support/Sublime Text [2|3]/Packages`
- **Linux:** `~/.Sublime Text [2|3]/Packages`
- **Windows:** `%APPDATA%/Sublime Text [2|3]/Packages`

> **注意** 将 `[2|3]` 替换为你安装的 Sublime Text 版本。

## 使用方法

所有命令都可以通过**命令面板**使用前缀
**_Trimmer_**访问，也可以在**主菜单**中通过 `编辑` -> `行` -> _Trimmer_ 命令找到。

- [命令面板截图](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/command_palette.png)
- [主菜单截图](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/main_menu.png)

### 快捷键绑定

_默认_快捷键绑定会修剪每行末尾的多余空白（整个文件）。

- **OS X**: `Ctrl + S`
- **Linux**: `Ctrl + Alt + S`
- **Windows**: `Ctrl + Alt + S`

### Trimmer 命令 API

| 命令                                | 描述                                                                                                  | 作用范围                   |
| ---------------------------------- | ------------------------------------------------------------------------------------------------------ | ------------------------- |
| `trimmer`                          | 修剪每行末尾的空白                                                                                      | 整个文件                   |
| `trim_leading_whitespace`          | 修剪每行开头的空白                                                                                      | 选区或整个文件             |
| `trim_leading_trailing_whitespace` | 修剪每行开头和末尾的空白                                                                                | 选区或整个文件             |



| `trim_selections`                  | 从选区修剪空白字符                                                                              | 选区                     |
| `delete_empty_lines`               | 删除空行，仅含空白字符的行                                                                      | 选区，或整个文件          |
| `collapse_lines`                   | 将多个连续空行合并为一个空行                                                                    | 选区，或整个文件          |
| `collapse_spaces`                  | 将多个连续空格合并为一个空格                                                                    | 选区，或整个文件          |
| `trim_edges`                       | 修剪文件开头和结尾的空行，仅含空白字符的行                                                    | 整个文件                  |
| `remove_blank_spaces`              | 移除所有空白字符（制表符、回车符、换页符、垂直制表符、空格）                                  | 选区，或整个文件          |
| `normalize_spaces`                 | 连续空格缩减，删除空行，行首尾修剪                                                              | 选区，或整个文件          |
| `replace_smart_characters`         | 替换智能字符（智能引号、长短破折号、省略号、不间断空格）                                        | 选区，或整个文件          |
| `tokenize_string`                  | 通过合并连续空格并修剪首尾空白，将字符串转换为标记                                            | 选区，或整个文件          |
| `delete_empty_tags`                | 删除空的，仅含空白字符的 HTML 和 XML 标签                                                      | 选区，或整个文件          |
| `remove_comments`                  | 移除代码注释并合并行                                                                            | 选区，或整个文件          |
| `delete_adjacent_duplicate_lines`  | 删除相邻重复行                                                                                  | 选区，或整个文件          |

## 作者

[Jon LaBelle](https://jonlabelle.com)

## 许可证

Trimmer 采用 [MIT 许可证](http://opensource.org/licenses/MIT) 许可。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-15

---