# Rosetta Stonks

- [介绍](#introduction)
- [安装](#install)
  - [基于 Chrome 的浏览器](#chrome-based-browsers)
    - [视觉指南](#chrome-based-browsers)
  - [Firefox](#firefox-based-browsers)
- [使用方法](#how-to-use)
  - [添加时间](#adding-time)
    - [基础课程](#adding-time-in-foundations)
    - [流利度训练](#adding-time-in-fluency-builder)
  - [验证课程](#validating-lesson)
    - [基础课程](#validating-lesson-in-foundations)
    - [流利度训练](#validating-lesson-in-fluency-builder)

## 介绍

RosettaStonks 是一个浏览器扩展，允许用户在 Rosetta Stone 语言学习平台上添加时间和验证课程。

> RosettaStonks，让你的 Rosetta Stone 更加 stonks。

## 安装

### 基于 Chrome 的浏览器

➡️ **首次手动安装 Chrome 扩展？** 请查看[分步视觉指南](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — 包含有用的截图！🖼️

#### 1. 使用 GitHub 发布版本

要在基于 Chrome 的浏览器中使用此扩展，您需要：

- 从最新发布版本中下载文件 `rosettastonks-chrome.tar.gz` 到您的电脑。
- 在电脑上某处创建一个名为 `rosettastonks` 的文件夹来存放该扩展。
- 在 `rosettastonks` 文件夹中运行以下命令。




```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. 使用 nix 包管理器

如果你使用的是支持 **flakes** 的 nix 系统，可以运行以下命令，
它们将安装一个包含所有文件的文件夹，路径为 `/tmp/rosettastonks`。


```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```
该文件夹现已安装在 `/tmp/rosettastonks/`

**此部分适用于所有用户，无论您是使用 github 方法还是 nix 方法。**

在您的浏览器中：

- 访问 `chrome://extensions`
- 打开 `开发者模式` 开关
- 点击 `加载已解压的扩展程序`
- 选择您的 `rosettastonks` 文件夹

### 基于 Firefox 的浏览器

- 从最新版本下载文件 `rosettastonks.xpi`。
- 或者，如果使用支持 flake 的 nix 包管理器，您可以运行
  以下命令。



```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- 进入浏览器中的 `about:addons` 页面  
- 点击设置按钮，进入 `调试插件`。  
- 点击 `加载临时插件`  
- 在文件选择器中选择 `/tmp/rosettastonks.xpi` 文件。  

_警告：此方法仅临时安装扩展，意味着如果关闭浏览器，插件将被卸载。  
这是因为 Firefox 政策不允许使用未验证的扩展。_  

## 如何使用  

### 添加时间  

#### 在 Foundations 中添加时间  

要在 `foundations` 产品中添加时间，需要进入你的练习，  
至少点击忽略或解决一个问题。完成后，扩展页面上  
应出现一个时间字段，你可以在此添加时间。  

#### 在 Fluency builder 中添加时间  

要在 `fluency builder` 产品中添加时间，需要进入你的练习，  
至少完成一个练习。如果未出现添加时间字段，说明  
未捕获到时间请求，你需要刷新问题并再次回答。  
要使时间被添加，需要完成你用来添加时间的课程。  

_注意：如果看不到添加时间字段，说明你在 Rosetta stone 网站上的操作  
未导致添加合法时间，因此需要回答其他问题。_  

### 验证课程  

#### 在 Foundations 中验证课程  

要验证课程，需要开始一个课程，  
通过右下角的 `忽略` 按钮完成所有问题。  
所有问题浏览完毕后，点击 `验证课程` 按钮应能验证课程。  
如果不能，返回主页，点击同一课程，继续操作。




应该问你“你想继续还是重置？”，你可以两者任选，并且  
再次验证课程直到它能正常工作。最多应该在3/4次后生效。  

#### 在流利度构建器中验证课程  

目前，验证课程功能在rosetta stonks上不可用。  

## 构建应用程序  

### 构建工作线程  

工作线程可以使用以下命令打包  

```
$ deno task build:worker
```

这将创建打包文件 `/dist/worker.esm.js`，这是 worker 的打包文件。

### 构建前端

可以使用以下命令打包 worker


```
$ deno task build:frontend
```

这将创建打包文件 `/dist/frontend.esm.js`，该文件是前端的打包文件。

## 打包扩展

### Chrome

要为 Chrome 打包扩展，可以运行以下命令：


```
$ make chrome
```

### Firefox

要为 Firefox 打包扩展，可以运行以下命令：

```
$ make firefox
```

这将生成 `rosettastonks.xpi`，这是可以在 Firefox 中加载的扩展文件。

📸 更喜欢视觉效果？请查看[带图片的 Chrome 安装指南](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---