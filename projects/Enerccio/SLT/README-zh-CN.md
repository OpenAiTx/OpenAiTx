# SLT - Jetbrains IDE 系列的 Common Lisp 语言插件

![GitHub release (latest by date)](https://img.shields.io/github/v/release/Enerccio/SLT)
[![Version](https://img.shields.io/jetbrains/plugin/v/21132-slt.svg)](https://plugins.jetbrains.com/plugin/21132-slt)
![JetBrains plugins](https://img.shields.io/jetbrains/plugin/d/21132)
![GitHub Release Date](https://img.shields.io/github/release-date/Enerccio/SLT)
![OSS Lifecycle](https://img.shields.io/osslifecycle/Enerccio/SLT)
![GitHub](https://img.shields.io/github/license/Enerccio/SLT)
![GitHub lisp counter](https://img.shields.io/github/search/Enerccio/SLT/lisp)
[![0.1.0](https://badgen.net/github/milestones/enerccio/SLT/1)](https://github.com/enerccio/SLT/milestone/1)
[![0.2.0](https://badgen.net/github/milestones/enerccio/SLT/2)](https://github.com/enerccio/SLT/milestone/2)
[![0.3.0](https://badgen.net/github/milestones/enerccio/SLT/4)](https://github.com/enerccio/SLT/milestone/4)
[![0.4.0](https://badgen.net/github/milestones/enerccio/SLT/5)](https://github.com/enerccio/SLT/milestone/5)
[![0.5.0](https://badgen.net/github/milestones/enerccio/SLT/6)](https://github.com/enerccio/SLT/milestone/6)
![GitHub all releases](https://img.shields.io/github/downloads/Enerccio/SLT/total)
![GitHub last commit](https://img.shields.io/github/last-commit/Enerccio/SLT)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/Enerccio/SLT)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/Enerccio/SLT)
![Lines of code](https://img.shields.io/tokei/lines/github/Enerccio/SLT)
![GitHub top language](https://img.shields.io/github/languages/top/Enerccio/SLT)
[![(want-to-support-me? T NIL)](https://img.shields.io/liberapay/receives/Enerccio.svg?logo=liberapay)](https://liberapay.com/Enerccio)
![Liberapay patrons](https://img.shields.io/liberapay/patrons/Enerccio)
[![Support me on Patreon](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Denerccio%26type%3Dpledges&style=flat)](https://patreon.com/enerccio)[![Support me on Patreon](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Denerccio%26type%3Dpatrons&style=flat)](https://patreon.com/enerccio)
![Maintenance](https://img.shields.io/maintenance/yes/2023)
![GitHub issues](https://img.shields.io/github/issues/Enerccio/SLT)
![GitHub branch checks state](https://img.shields.io/github/checks-status/Enerccio/SLT/master)

[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/SLT_IDE?style=social)](https://old.reddit.com/r/SLT_IDE/)
![GitHub forks](https://img.shields.io/github/forks/Enerccio/SLT?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/Enerccio/SLT?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/Enerccio/SLT?style=social)
[![Join the chat at https://gitter.im/SLT-Plugin/community](https://badges.gitter.im/SLT-Plugin/Lobby.svg)](https://gitter.im/SLT-Plugin/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
![GitHub Discussions](https://img.shields.io/github/discussions/Enerccio/SLT)

![Image](https://raw.githubusercontent.com/Enerccio/SLT/master/src/main/resources/logo/logo.svg)

**此插件为实验性质，可能随时崩溃！请报告所有错误！**

此插件为 JetBrains IDE 提供 Common Lisp 支持。  
使用修改过的 SLIME/Swank 协议与 Lisp 解释器通信，  
为 Common Lisp 提供 IDE 功能。

# （较为）详细的安装与使用指南

您现在可以从市场下载该插件！https://plugins.jetbrains.com/plugin/21132-slt

https://github.com/Enerccio/SLT/wiki/User-Guide

## 要求

1) 基于 Intellij 的 IDE - 已在 `Intellij Idea Community/Ultimate` 测试，但应支持所有主流 IDE  
   1) 支持版本为 2022.2 及以上  

可选（详见指南）：

1) 安装以下之一的支持的 LISP 解释器：  
   * [Steel Bank Common Lisp](https://www.sbcl.org/)  
   * [Armed Bear Common Lisp](https://armedbear.common-lisp.dev/)  
   * [Clozure Common Lisp](https://ccl.clozure.com/)  
   * [Allegro CL](https://franz.com/products/allegro-common-lisp/)  
   * [CMUCL](https://www.cons.org/cmucl/)  
2) 安装 [Quicklisp](https://www.quicklisp.org/beta/)

（并非所有功能对所有解释器均可用，详见 [FEATURES.md](https://raw.githubusercontent.com/Enerccio/SLT/master/FEATURES.md)）

## 入门

参见 https://github.com/Enerccio/SLT/wiki/User-Guide#plugin-installation

## 插件选项

- SDK 参见上面指南  
- 更改颜色 https://github.com/Enerccio/SLT/wiki/User-Guide#change-colors-of-elements  
- 更改缩进 https://github.com/Enerccio/SLT/wiki/User-Guide#change-indentation-settings

## 编译源码

克隆仓库并修改 gradle.properties 以适配您的 IDE。  
然后使用 gradle 构建插件。  
您也可以在 Intellij Idea 中将其作为项目打开。

## 计划功能 / 目标

* [x] 功能完善后上传市场  
* [x] 自动缩进  
* [x] REPL  
  * [x] REPL 返回值检查  
* [x] 交互式调试  
* [x] 参数帮助（Ctrl+P）  
* [x] 检查  
  * [x] 基础检查  
  * [x] 操作  
  * [x] 符号检查器  
  * [ ] 检查执行  
* [x] 断点  
* [x] 文档  
  * [x] Hyperspec 集成  
* [x] 宏展开（全部、单个、普通）  
* [x] 通过符号名查找函数  
* [x] 符号搜索
* [x] 反向引用  
* [x] 彩虹括号  
* [ ] 重构  
  * [x] 将 lambda 提取为函数  
* [ ] quicklisp 安装包列表 / ASDF 包列表  
* [ ] 尚未评估的修改顶级形式列表  
* [ ] 实际制作一个 IDE，即将插件和依赖作为一个应用，而不是插件  
* [x] SDK 支持  
    * 不是真正的 SDK，因为只有在 Intellij 中可用，而不是（例如）PyCharm，因此  
      这是手动实现的。  
    * [x] 为用户下载 SBCL 和 quicklisp  
* [x] 自动下载 lisp 解释器和 quicklisp  
* [x] 支持不同的 lisp 解释器  

## 许可证  

本项目采用 [Apache License v2](https://raw.githubusercontent.com/Enerccio/SLT/master/LICENSE.txt) 许可。  

# 如何帮助？  

* 请安装插件并试用！  
* 报告所有错误，以便我能全部捕捉。点击[这里](https://github.com/enerccio/SLT/issues/new)报告。  
* 如果你喜欢这个项目，考虑给它点星或者传播信息。  
* 该项目是开源软件，如果你有相关知识并想实现某些功能，可以 fork 仓库并创建 PR！  

## 捐赠  

如果你愿意，可以通过 [Liberapay](https://liberapay.com/Enerccio/donate) 或  
[Patreon](https://www.patreon.com/enerccio) 捐赠以支持我的工作。  

# SLT 到底是什么意思？  

SLT - 言语语言治疗。LISP 唯一的治疗方法！  

同时，也是 Superior Lisp Tooling 的反向首字母缩写！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---