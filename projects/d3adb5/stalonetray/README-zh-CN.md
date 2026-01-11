# 独立系统托盘 [![构建][badge-build]][yaml-build] [![代码规范][badge-lint]][yaml-lint]

[badge-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml/badge.svg
[yaml-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml
[badge-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml/badge.svg
[yaml-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml

Stalonetray 是一个适用于使用 X11 窗口系统的 Unix 桌面的独立系统托盘（通知区域）。
它的默认构建和运行时依赖极少：仅 Xlib 和 libXinerama，尽管你可以通过禁用某个功能
来舍弃后者，从而实现更极简的配置。Stalonetray 几乎可以在任何窗口管理器下运行。

要开始使用 stalonetray，只需将 `stalonetrayrc.sample` 复制到
`~/.stalonetrayrc` 或 `$XDG_CONFIG_HOME/stalonetrayrc`。该文件注释详尽，
足以帮助你快速上手。

请注意，根据打包维护者构建 stalonetray 的方式，某些功能默认被禁用，
可能无法开箱即用。如果你想自行编译以启用所需功能，请参阅下方的“从源码构建”章节。

## 维护状态

该项目最初由 [Roman Dubtsov (kolbusa)][gh-kolbusa] 开发，最近已更换维护人。
Roman 仍然参与项目，但不再积极维护。

**感谢他多年来对该项目的创建与维护。谢谢你，Roman！**

[gh-kolbusa]: https://github.com/kolbusa

## 安装

包管理器是安装 stalonetray 最便捷的方式。它已被打包进多个 Linux 发行版和 BSD 变种。
在 Debian 和 Ubuntu 上，运行：








```sh
sudo apt install stalonetray
```
在 Fedora 上运行：


```sh
sudo dnf install stalonetray
```

## 从源码构建

Stalonetray 使用 [Meson](https://mesonbuild.com/)。请参考 `meson.options` 文件了解可用的构建选项及其默认值。

要使用 Meson 构建 stalonetray，请确保已安装必要的依赖项
—— 默认情况下只需要 Xlib 和 libXinerama 开发包 —— 
然后运行标准的 Meson 构建命令：


```sh
meson setup builddir
meson compile -C builddir stalonetray
```

这将会在 `builddir` 目录中构建 `stalonetray` 二进制文件。

要构建 stalonetray 的文档，您需要先安装 `xsltproc` 和 DocBook
样式表。然后构建 `manpage` 目标：

```sh
meson compile -C builddir manpage
```

这将在 `builddir` 目录中创建 `stalonetray.1` 文件。

可以通过以下方式从源码安装：

```sh
meson install -C builddir
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-11

---