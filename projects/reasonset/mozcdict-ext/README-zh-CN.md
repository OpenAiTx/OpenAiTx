# mozcdict-ext

将外部词汇转换为Mozc系统词典

# 概要

本工具组最初是作为失去Mozc-UT（Mozcdic-UT）带来的损失的“紧急避难”手段而制作的。  
现在旨在通过不同于Mozc-UT的方法，构建更舒适的转换环境。

本工具组从Mozc外部资源构建Mozc系统词典。  
通过将其集成到Mozc中进行构建，可以增加Mozc的词汇量。

本软件不包含以此方式生成的词典。  
也不包含Mozc主体。

本软件最初是作为紧急回避的“过渡”软件制作的，  
但现在在与Mozc-UT稍有不同的方针下开发。

与Mozcdic-UT的主要区别如下：

* 是一个开源项目，许可为GPL v3  
* 软件是用于词典生成的工具，而非生成的词典本身  
* Mozcdic-UT仅针对普通名词，Mozcdict-EXT不限制词性  
* 除了网页词典转换器外，还拥有人工编纂的ByHand词典

# 使用方法

## 生成基础

各目录下的 `mkdict.zsh` 或 `mkdict.rb` 会生成转换后的词典，并输出到标准输出。

此时需满足以下前提条件。

* 运行脚本时，当前目录须为脚本所在目录  
* 需要将Mozc的 `id.def` 文件路径设置到环境变量 `$MOZC_ID_FILE` 中

`id.def` 文件存在于Mozc的 `src/data/dictionary_oss/id.def` 中。  
此文件不包含于本软件中。  
构建时无论如何都需要Mozc，因此建议先获取并更新Mozc的仓库。

如此输出到标准输出的内容可以作为Mozc的系统词典使用，  
将其集成到系统词典中构建即可包含该词典。
推荐将内容追加到 `src/data/dictionary_oss/dictionary09.txt` 中。

## 最后的整理

如果生成了多个词典，跨多个词典进行整理作业会更好。

`.dev.utils/uniqword.rb` 从 `ARGF` 读取词典，若包含品词的同一词汇则排除并输出到 STDOUT。
重复的词汇会输出到 STDERR。

```bash
ruby uniqword.rb ~/dict/neologd.txt ~/dict/sudachi.txt > ~/dict/unified.txt
```

与Mozcdic-UT不同，因为生成专有名词，所以建议进行此操作。

## Archlinux的情况

本项目之外，还准备了名为 `fcitx5-mozc-ext-neologd` 的AUR包。

通过从AUR安装此包，可以包含外部词典构建并安装Mozc。

此外，该包与本项目是不同的。

# 环境变量

## `$MOZC_ID_FILE`

必需。指示MOZC的 `id.def` 所在位置。

## `$WORDCLASS_ROUND`

当没有严格匹配的词性时，向更粗略的词性进行四舍五入。
指定 `no` 时不执行此处理。
在以下词典工具中有效。

* sudachi

## `$ERROR_ON_UNEXPECTED_CLASS`

当存在未知词性词汇时抛出错误。
默认不抛出，指定 `yes` 时抛出。
在以下词典工具中有效。

* sudachi

# 执行选项

## -e / --english

通常，此工具排除“转换为英语”。
加上 `-e` 或 `--english` 选项时，允许英语转换结果。

## --english-proper

未附加`--english`而附加了`--english-proper`时，仅允许英语为固有名词。

## -P / --no-proper

排除固有名词。

## -w / --fullwidth-english (neologd, sudachi)

不排除全角英数字和半角片假名的转换。

更准确地说，通常当匹配Onigmo的正则表达式 `/^[\p{Symbol}\p{In_CJK_Symbols_and_Punctuation}\p{Punctuation}\p{White_Space}\p{In_Halfwidth_and_Fullwidth_Forms}]+$/` 时会被排除，但此选项停止此类排除。

## -W / --exclude-containing-fullwidth-english (byhand)

包含全角英数字或半角片假名时排除。

## --fullwidth-english-proper (neologd, sudachi)

未附加`--fullwidth-english`时仅允许固有名词。

## -s / --symbol

通常，此工具在转换时会排除影响转换的“符号”字符，  
但附加`-s`或`--symbol`选项时，强制包含这些字符。

# 选项默认值

如果不使用命令行选项想要修改默认选项，可以通过配置目录(`${XDG_CONFIG_HOME:-$HOME/.config}/mozcdict-ext`)中的`config.yaml`来设置默认选项。

例如，若想始终启用`--fullwidth-english`，可以如下设置。

```yaml
fullwidth-english: true
```

# 除外

可以使用设定目录中的`exclude.txt`文件，指定想要避免添加到词典中的模式。

除外列表中，每行包含一个模式，读音模式和原形模式通过一个或多个连续的空白字符分隔。

每个模式都会通过`File.fnmatch`进行检查。

例如，如果想要排除所有以`ゃ`开头的读音转换的候选项，可以写成如下：

```
ゃ*    *
```
とする。

# IssueとPR

何か問題があれば、Issueに書くか、Pull Requestを生成してほしい。

ただ、私は既にかなり手出ししている中で善意で本ソフトウェアを作っていることを理解してほしい。
つまり、IssueやPull Requestにまで手が回るかは分からない。
(少なくとも、なるべく対応したいとは思っている。)

# ByHand辞書への語彙追加と欠如している語彙の報告

最新のMozcと、本ソフトウェアのすべての辞書を有効にした状態で変換できない語があれば、[Mozcdict Ext 語彙欠如報告](https://mozc.chienomi.org)にて申請してほしい。

同ページから申請できないものについてはissueにて報告して欲しい。
また、具体的なMozc品詞を指定できる場合も、同ページではなくissueを立てて欲しい。

# ライセンスとパッケージング

このソフトウェアはGPL v3でライセンスされている。
ソフトウェアは「自由に」コピーして使って良い。

一方、このソフトウェアに何か問題があったり、あるいは不足があったりしたとしても私は一切の責任を負うことはできない。
誰もがよく知っている通り、ABSOLUTELY NO WARRANTYである。

本ソフトウェアが提供するのはあくまでも辞書生成ツールである。
しかし、恐らくディストリビューションとして配布したいとすれば、それによってビルドされたMozcだろう。
このようにしてビルドされたMozcは本ツールのライセンスとは全く関係がない。
なぜならば、そのMozcに本ツールは含まれないからだ。
そのようなパッケージは、Mozcと、外部辞書として使われたリソースのライセンス・規約に従うことになるだろう。
そのようにして配布が可能であることもまた、本ソフトウェアおよび私は保証しない。

# 現在の進捗

* NEologd - 機能する
* Sudachi - 一部の品詞についてのみ生成される (実験的・開発中)

# 注意事項


* 本软件生成的词典的许可及其合法性，软件本身不承担任何责任

# 特别征求贡献的内容

sudachi的`clsmap.yaml`（Sudachi的词性分类到Mozc词性分类的转换）

使用`utils/dev-by-cls.rb`可以将词汇按词性分类并输出到`.dev.reference/sudachi-cls`目录下（该目录在`.gitignore`中指定），目前正在以此为参考推进词性分类的整理工作。

# 依赖项

* Ruby >= 3.0  
* Zsh  
* xz(1)  
* curl(1)  
* Git（子模块）

# 关于词典

## neologd

基于mecab-ipadic-NEologd的词典。

## sudachi

复用形态素解析软件Sudachi的词典。

计划不仅使用名词部分，但目前处于停滞状态。

## byhand

针对neologd和sudachi无法转换或转换困难的词汇，手工编辑的词典。

原则上仅收录类似国语小辞典中收录的一般词汇，不包含固有名词。

## Mozc Common User Dict

[Mozc Common User Dict](https://github.com/reasonset/mozc-common-user-dict)是补充本项目的一般词汇用户词典。

由于某些原因难以收录到byhand中的词汇会被收录在这里。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---