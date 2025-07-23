
# Vimb - 类 Vim 浏览器

[![构建状态](https://travis-ci.com/fanglingsu/vimb.svg?branch=master)](https://travis-ci.com/fanglingsu/vimb)
[![许可证: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![最新发布](https://img.shields.io/github/release/fanglingsu/vimb.svg?style=flat)](https://github.com/fanglingsu/vimb/releases/latest)

Vimb 是一款类 Vim 的网页浏览器，灵感来自 Pentadactyl 和 Vimprobable。
Vimb 的目标是构建一个完全键盘驱动、高效且愉悦的浏览体验，
占用低内存和 CPU，且对 Vim 用户直观易用。

更多信息以及 Vimb 浏览器运行时的截图可在
[Vimb][] 项目页面找到。

## 特性

- 它是类似 Vim 的模式化浏览器
- 类 Vim 的键绑定 - 可为每个浏览器模式分配
- 几乎所有配置都可在运行时用 Vim 风格的 set 语法修改
- `ex` 命令、搜索查询、URL 的历史记录
- 自动补全：命令、URL、书签 URL、设置的变量名、搜索查询
- 提示功能 - 标记链接、表单字段及其他可点击元素以
  供点击、打开或检查
- 使用 CA 证书文件进行 SSL 验证
- 用户自定义带占位符的 URL 快捷方式
- 稍后阅读队列，用于收集 URI 以备后用
- 多个剪切板寄存器
- 类 Vim 的 autocmd - 在特定 URI 事件后自动执行命令

## 软件包

- Arch Linux: [extra/vimb][], [aur/vimb-git][], [aur/vimb-gtk2][]
- Fedora: [fedora/vimb][],
- Gentoo: [tharvik overlay][], [jjakob overlay][]
- openSUSE: [network/vimb][]
- pkgsrc: [pkgsrc/www/vimb][], [pkgsrc/wip/vimb-git][]
- Slackware: [slackbuild/vimb][]

## 依赖项

- gtk+-3.0
- webkit2gtk-4.1
- gst-libav, gst-plugins-good（可选，用于媒体解码等）

## 安装

编辑 `config.mk` 以匹配您的本地设置。如果使用其他编译器，比如 tcc，
可能需要这样做。不过大多数人在 Ubuntu 或 Debian 等系统上几乎无需修改。

编辑 `src/config.h` 以符合您的个人偏好，比如更改加载条中使用的字符或字体。

默认的 `Makefile` 不会用 `config.def.h` 的内容覆盖您自定义的 `config.h`，
即使在最新的 git 拉取中有更新。
因此，您应始终将自定义的 `config.h` 与 `config.def.h` 进行比较，
确保将后者的更改合并到您的 `config.h` 中。

运行以下命令编译并安装 Vimb（如有必要，最后一条命令需以 root 身份执行）。
如果想更改 `PREFIX`，请注意构建和安装阶段都需要指定。

    make PREFIX=/usr
    make PREFIX=/usr install

若想不安装直接运行 vimb 进行测试，可使用 'runsandbox' make 目标。

    make runsandbox

## 邮件列表

- 功能请求、问题和补丁可在[邮件列表][mail]中讨论（[列表归档][mail-archive]）

## 类似项目

- [luakit](https://luakit.github.io/)
- [qutebrowser](https://www.qutebrowser.org/)
- [surf](https://surf.suckless.org/)
- [uzbl](https://www.uzbl.org/)
- [wyeb](https://github.com/jun7/wyeb)

## 许可证

许可证信息见 LICENSE 文件。

## 关于

- https://en.wikipedia.org/wiki/Vimb
- http://thedarnedestthing.com/vimb
- https://blog.jeaye.com/2015/08/23/vimb/

[aur/vimb-git]:        https://aur.archlinux.org/packages/vimb-git
[aur/vimb-gtk2]:       https://aur.archlinux.org/packages/vimb-gtk2/
[extra/vimb]:          https://www.archlinux.org/packages/extra/x86_64/vimb/
[fedora/vimb]:         https://src.fedoraproject.org/rpms/vimb
[tharvik overlay]:     https://github.com/tharvik/overlay/tree/master/www-client/vimb
[jjakob overlay]:      https://github.com/jjakob/gentoo-overlay/tree/master/www-client/vimb
[mail-archive]:        https://sourceforge.net/p/vimb/vimb/vimb-users/ "vimb - mailing list archive"
[mail]:                https://lists.sourceforge.net/lists/listinfo/vimb-users "vimb - mailing list"







[network/vimb]:        https://build.opensuse.org/package/show/network/vimb
[pkgsrc/wip/vimb-git]: http://pkgsrc.se/wip/vimb-git
[pkgsrc/www/vimb]:     http://pkgsrc.se/www/vimb
[slackbuild/vimb]:     https://slackbuilds.org/repository/14.2/network/vimb/
[vimb]:                https://fanglingsu.github.io/vimb/ "Vimb - 类 Vim 浏览器项目主页"



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---