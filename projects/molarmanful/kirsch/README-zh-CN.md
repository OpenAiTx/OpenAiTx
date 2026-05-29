<div align="center">

![kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/header.png)

</div>

## 目录

- [目录](#table-of-contents)
- [概述](#overview)
- [图库](#gallery)
- [安装/使用](#installation/usage)
  - [Nerd 字体](#nerd-fonts)
  - [Propo](#propo)
  - [Nixpkgs](#nixpkgs)
  - [Nix Flakes](#nix-flakes)
  - [网页](#web)
- [设计说明](#design-notes)
  - [装饰](#flourishes)
  - [间隙](#gaps)
- [贡献](#contributing)
- [致谢](#credits)
- [许可](#licensing)

## 概述

**kirsch** /ˈkɪərʃ/ _名词_

1. _(德语)_ 樱桃。

1. _(Russell A. Kirsch, 1929 - 2020)_ 美国工程师，被公认为
   首个数字图像扫描仪的开发者及像素的发明者。

1. 一款等宽位图字体，边界框为6x16（平均宽度5px，下降4px，
   上升12px，x高度5px，大写字母高度9px）。它融合多种字形和图案，
   在紧凑的尺寸下营造出独特的人文主义风格。

   部分字形来源于[Cozette](https://github.com/slavfox/Cozette)，
   通常经过修改以符合 kirsch 的设计理念。

## 画廊

<details>
<summary><strong>字形</strong></summary>
<div align="center">

![kirsch 字形](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/chars.png)

</div>
</details>

<details>
<summary><strong>字形映射</strong></summary>
<div align="center">

![kirsch 字形映射](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/map.png)

</div>
</details>

<details open>
<summary><strong>示例</strong></summary>
<div align="center">

![kirsch 示例](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/sample.png)

</div>
</details>

## 安装/使用

从 [Releases](https://github.com/molarmanful/kirsch/releases) 下载。
包括位图格式 - OTB、BDF、PCF、DFONT（适用于Mac用户） - 以及
TTF。2x版本适用于HiDPI屏幕。注意PCF不包含
超过 U+FFFF 的字形。

为了获得最清晰的显示效果，尽可能使用位图格式。
如果你的平台不支持位图字体（例如Windows、
VSCode），则在字体大小为16px倍数时使用TTF。

> [!提示]  
> 如果您需要以pt为单位的字体大小，请使用以下换算公式：  
>  
> `pt = px * 72 / dpi`  
>  
> 例如，96dpi屏幕上的16px是 `16px * 72 / 96dpi = 12pt`。  

### Nerd 字体  

kirsch 搭载了自定义的 Nerd 字体字形。支持仍在开发中。为了视觉清晰，kirsch 的 Nerd 字体字形往往会明显超出其宽度。  
我设计这些字形时，预期它们在前后各填充一个空格时效果最佳。  

包含剩余 Nerd 字体的补丁版本可用。  
“Mono”变体使用较小的字形（单宽而非双宽），适用于无法混合宽度的终端。  

### Propo  

对于如 foot 这类部分溢出的终端，kirsch 有一个 Propo 变体可用。  
此变体调整字形，使其单元格不会被终端的字体渲染器裁剪。  

### Nixpkgs  

感谢 [@ejiektpobehuk](https://github.com/ejiektpobehuk)，kirsch 已在 Nixpkgs 中以 `kirsch` 名称提供。  

### Nix Flakes  

kirsch 的版本也推送到  
[FlakeHub](https://flakehub.com/flake/molarmanful/kirsch) 上。`kirsch`（别名为  
`default`）是基础包，而 `kirsch-nerd` 包含 Nerd 字体补丁。  

### Web  

由于缺乏位图支持，我通常不建议在网页上使用 kirsch。  
但对于固执和勇敢的人，WOFF2 格式可用。还有一个  
[CDN 托管的样式表](https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css)





为了方便。

```html
<link
  rel="stylesheet"
  href="https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css"
/>
```

## 设计说明

与我之前的字体 [eldur](https://github.com/molarmanful/eldur) 仅有 4px 平均字符宽度不同，kirsch 的平均字符宽度为 5px。  
这多出来的 1px 宽度为设计带来了意想不到的自由度。更多的字形可以舒适地适应 5px 宽度——例如 “m” 和 “w”——这意味着这些字形不会破坏字距，也不会侵占相邻字形的空间。  
无法适应 5px 宽度的字形现在可以使用 7px 宽度，这保持了平衡和可读性，同时不会对字距产生过大负面影响。

### 装饰笔画

![rogue fijian xylophone](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-flourishes.png)

装饰笔画——例如在 “i” 或 “f” 中——是一种风格选择，但它们也有功能性作用。  
如果没有装饰笔画，“i” 仅占用 1px 宽度，会留下 4px 的尴尬空白。  
在 “i” 的两侧各加 2px 的装饰笔画，使其宽度达到 5px，从而以时尚的方式解决字距问题。

在 “l” 字的情况下，手写风格的装饰笔画进一步将其与其他竖直字符如 `1I|` 区分开来。

### 间隙

![bad queen peg 69](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-gaps.png)

kirsch 的一个显著特点是在字母的“碗”部有间隙。  
填满这个间隙会使字母显得过于方正或过于紧凑，而保持间隙开放则使字形更加简洁。  
这些间隙也呼应了手写风格的笔画收尾。

## 贡献

欢迎提交问题、功能/字形请求和拉取请求！字体文件通过 [bited](https://github.com/molarmanful/bited) 进行编辑。

## 致谢

这些项目启发并帮助我创建了 kirsch，绝对值得








checking out.

- [Bits'n'Picas](https://github.com/kreativekorp/bitsnpicas)
- [Cozette](https://github.com/slavfox/Cozette)
- [Cyreal 字体测试页](http://www.cyreal.org/Font-Testing-Page/)
- [W3 UTF-8 演示](https://www.w3.org/2001/06/utf-8-test/UTF-8-demo.html) /
  [Markus Kuhn UTF-8 演示](https://antofthy.gitlab.io/info/data/utf8-demo.txt)
- [APL386](https://abrudz.github.io/APL386)

## 许可

由 [the kirsch Project Authors](AUTHORS) 用 ♥ 制作。根据 OFL-1.1 许可证发布。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---