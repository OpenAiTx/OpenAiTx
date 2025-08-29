# Janice

一个用于查看大型 JSON 文件的桌面应用程序。

[![GitHub Release](https://img.shields.io/github/v/release/ErikKalkoken/janice)](https://github.com/ErikKalkoken/janice)
[![Fyne](https://img.shields.io/badge/dynamic/regex?url=https%3A%2F%2Fgithub.com%2FErikKalkoken%2Fjanice%2Fblob%2Fmain%2Fgo.mod&search=fyne%5C.io%5C%2Ffyne%5C%2Fv2%20(v%5Cd*%5C.%5Cd*%5C.%5Cd*)&replace=%241&label=Fyne&cacheSeconds=https%3A%2F%2Fgithub.com%2Ffyne-io%2Ffyne)](https://github.com/fyne-io/fyne)
[![build status](https://github.com/ErikKalkoken/janice/actions/workflows/ci-cd.yml/badge.svg)](https://github.com/ErikKalkoken/janice/actions/workflows/ci-cd.yml)
[![codecov](https://codecov.io/gh/ErikKalkoken/janice/graph/badge.svg?token=nei6PLRXrD)](https://codecov.io/gh/ErikKalkoken/janice)
[![GitHub License](https://img.shields.io/github/license/ErikKalkoken/janice)](https://github.com/ErikKalkoken/janice)
[![GitHub Downloads (all assets, all releases)](https://img.shields.io/github/downloads/ErikKalkoken/janice/total)](https://github.com/ErikKalkoken/janice/releases)

[![download](https://github.com/user-attachments/assets/c8de336f-8c42-4501-86bb-dbc9c66db1f0)](https://github.com/ErikKalkoken/janice/releases/latest)

## 目录

- [描述](#description)
- [截图](#screenshots)
- [如何运行](#how-to-run)
- [常见问题](#faq)
- [致谢](#attributions)

## 描述

Janice 是一个用于查看大型 JSON 文件的桌面应用程序。其主要特点包括：

- 以经典树状结构浏览 JSON 文档
- JSON 文件可通过文件对话框打开，从剪贴板粘贴，拖拽到窗口，或作为命令行参数提供
- 支持查看非常大的 JSON 文件（>100MB，>1000万个元素）
- 支持在文档中搜索键和值，支持通配符
- 可导出 JSON 文件的部分内容到新文件或剪贴板
- 将值复制到剪贴板
- 单个可执行文件，无需安装
- 跨平台桌面应用，支持 Windows、Linux 和 macOS
- 自动切换暗色和亮色主题

## 截图

### 亮色主题

![light](https://cdn.imgpile.com/f/0IrYBjJ_xl.png)
### 深色主题

![dark](https://cdn.imgpile.com/f/bdQBc3q_xl.png)

## 如何运行

要运行 Janice，只需下载并解压最新版本到您的计算机。Janice 作为单个可执行文件发布，可以直接运行。您可以在[发布页面](https://github.com/ErikKalkoken/janice/releases)找到最新的下载包。

### Linux

我们为 Linux 桌面提供了两种安装方式：

- AppImage：AppImage 版本允许您直接从可执行文件运行应用，无需安装或 root 权限
- Tarball：tar 文件需要安装，但也允许您将应用集成到桌面环境中。tarball 在不同的 Linux 版本之间也有更广泛的兼容性。

#### AppImage

> [!注意]
> 应用以 [AppImage](https://appimage.org/) 格式发布，因此可以无需安装即可使用，并且能在许多不同的 Linux 发行版上运行。

1. 从发布页面下载最新的 AppImage 文件，并使其具有可执行权限。
1. 执行该文件以启动应用。

> [!提示]
> 如果出现以下错误：`AppImages require FUSE to run.`，您需要先在系统中安装 FUSE。FUSE 是所有 AppImage 运行所需的库。详情请参见[此页面](https://docs.appimage.org/user-guide/troubleshooting/fuse.html#the-appimage-tells-me-it-needs-fuse-to-run)。

#### Tarball

1. 从发布页面下载最新的 tar 文件
1. 解压 tar 文件，例如使用：`tar xf janice-0.12.3-linux-amd64.tar.xz`
1. 运行 `make user-install` 为当前用户安装应用，或运行 `sudo make install` 在系统范围内安装应用

现在您应该在桌面环境的启动器中有了启动应用的快捷方式。

要卸载应用，请根据安装方式运行：`make user-uninstall` 或 `sudo make uninstall`。

### Windows

1. 从 Github 的最新发布中下载 Windows 压缩文件。

1. 将文件解压到您选择的目录中，然后运行 .exe 文件以启动应用程序。

### Mac OS

1. 从 Github 最新发布版本下载适用于您平台（arm 或 intel）的 darwin 压缩文件。  
1. 将文件解压到您选择的目录中。  
1. 运行 .app 文件以启动应用程序。

> [!TIP]  
> MacOS 可能错误地报告此应用为“损坏”，因为它未使用苹果证书签名。您可以通过打开终端并运行以下命令来消除此错误。更多信息请参见 [Fyne 疑难解答](https://docs.fyne.io/faq/troubleshoot#distribution)：  
>  
> ```sudo xattr -r -d com.apple.quarantine Janice.app```

### 从代码库构建并运行

如果您的系统已配置为构建 [Fyne](https://fyne.io/) 应用，您可以使用以下命令直接从代码库构建并运行此应用：

```sh
go run github.com/ErikKalkoken/janice@latest
```

有关如何为 Fyne 配置系统的更多信息，请参见：[入门指南](https://docs.fyne.io/started/)。

## 常见问题

### 我能加载的最大 JSON 文件有多大？

您能加载的最大 JSON 文件主要取决于您的计算机内存大小以及具体的 JSON 文件。内存消耗的主要驱动力是 JSON 文档中的元素数量。

作为对比，我们在一台开发者笔记本上进行了加载测试。该笔记本配备了 8 GB 内存，运行 Ubuntu 22.04 LTS。我们成功加载了最多包含 4500 万个元素的 JSON 文件。测试文件大小约为 2.5 GB。

### JSON 文件是格式化的吗？

是的。JSON 文档以树状结构呈现，键按字母顺序显示。

## 归属

- [Json 图标由 LAB Design Studio 创建 - Flaticon](https://www.flaticon.com/free-icons/json)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---