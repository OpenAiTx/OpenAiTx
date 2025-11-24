# 标注工具

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="在 AppCenter 获取"/>
  </a>
</p>

![<center><b>主窗口 - 亮色主题</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Elementary OS 的图像标注")

## 概述

为您的图片添加注释，让一张图片胜过千言万语。

- 从文件系统、剪贴板加载图片，或创建截图进行标注。
- 添加形状、贴纸、图片、文本、绘图及其他标注以突出图像细节。
- 添加放大镜以增强图像细节。
- 模糊图像部分区域以遮蔽数据。
- 裁剪、调整大小并添加图片边框。
- 控制颜色、线条粗细和字体细节。
- 支持缩放。
- 支持在加载的图片中拾取颜色。
- 无限撤销/重做任何更改。
- 拖放带标注的 PNG 图片副本。
- 导出为 JPEG、PNG、TIFF、BMP、PDF、SVG 和 WebP 图片格式。
- 支持复制带标注的图片到剪贴板。
- 支持打印机。

## 安装

### Debian（从源码编译）

构建 Annotator 需要以下依赖：

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-dev  
- libxml2-dev  
- libgtk-3-dev  
- libhandy-1-dev  
- libwebp-dev  

要从源码安装 Annotator，请运行 `./app install`。  

要运行 Annotator，请运行 `com.github.phase1geo.annotator`。  

### Ubuntu（PPA）  

您可以使用由 @PandaJim 维护的 [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/)。该 PPA 支持 Ubuntu 20.04 及以上版本。请依次输入以下命令  

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```

### Arch Linux

如果你是 Arch Linux 用户，有一个
[AUR 软件包](https://aur.archlinux.org/packages/annotator/)
`annotator`：

```
% yay -S annotator
```

### Flatpak

此外，Annotator 可以通过 Flatpak 安装和运行。

要从源码构建和安装 Flatpak，请运行 `./app flatpak`。

之后，您可以通过以下命令运行它：`flatpak run com.github.phase1geo.annotator`。

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="在 AppCenter 获取"/>
  </a>
</p>

## 致谢

包含来自
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic)
的 `document-edit-symbolic.svg` 和 `image-crop-symbolic.svg`，
遵循 GPL v3.0 许可条款。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-24

---