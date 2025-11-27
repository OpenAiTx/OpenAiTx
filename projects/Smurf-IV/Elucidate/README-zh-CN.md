# Elucidate

- [项目描述](#project-description)
- [系统要求](#os-requirements)
- [常见问题](#faqs)
- [路线图](#roadmap)
- [截图](#screenshots)

## 项目描述

Elucidate 是 SnapRAID 命令行应用程序的 Windows 图形用户界面前端。

*该项目是我与其他贡献者共同努力的成果的延续。*

## 系统要求

- Windows 操作系统
- .Net 运行时 4.8.0
- SnapRaid 版本 11.5 或更低
- 目标驱动器上有 10MB 空闲空间

## 常见问题

**问**：什么是 SnapRAID？<br/>
**答**：SnapRAID 是一款适用于 Windows 和 Linux 操作系统的软件定义快照奇偶校验引擎。它在最基本的层面上，通过计算其组件文件的哈希值并将结果存储在奇偶校验文件中，来保护其覆盖的文件系统内容。如果发生硬盘完全故障，可以使用该奇偶校验文件重建丢失的数据。详情请访问 SnapRAID 的[文件保护引擎官方比较页面](http://snapraid.sourceforge.net/compare.html)。

**问**：为什么要用图形界面，命令行不就行了吗？<br/>
**答**：更大的目标是创建一个功能完整的图形界面，附加管理功能，帮助用户维护一个正常运行的 SnapRAID 环境。有时候，“点点点击”对于初学者来说更易上手。SnapRAID 的技术文档和深度可配置性可能让想尝试的人望而却步！

**问**：我还是不确定，还有更多内容吗？<br/>
**答**：有的，请查看[文档](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md)了解图片等内容。

**问**：“更大的目标”是什么？<br/>
**答**：详见下方的 __路线图__。

## 路线图

- [x] 第一阶段
  - [x] 尽力支持最新 SnapRAID 的最低版本。- __进行中。__
  - [x] 易用性
  - [x] SnapRAID 有三个命令，因此让它们对新手来说更容易访问  
  - [x] 进度指示器  
  - [x] 日志记录“交互式”和直接写入日志。  
  - [x] 用户登录时自动启动  
  - [x] 工具提示指导 •

- [x] 第二阶段 第二阶段功能请求  
  - [x] 暂停、更改优先级、中止。  
  - [x] 命令扩展 - “允许对默认参数进行额外参数设置。”  
  - [x] 调度  
    - 已移除，使用命令行  
  - [x] 受保护数据的图形视图。

- [ ] 第三阶段（2017-03 以后重启）  
  - [x] 新编译器和 .Net 4.7.x  
  - [x] 命令行界面  
  - [ ] 通过 Krypton 工具包 / 导航器 / 等新布局  
    - 进行中  
  - [ ] 翻译  
  - [x] 新命令  
  - [ ] 带状态报告的邮件发送器  
  - [ ] 文档测试步骤  
    - 进行中  
  - [ ] 添加到文档 / 更新图片  
    - 进行中  
  - [ ] 添加 _Windows 事件日志_ 报告错误  
  - [x] 添加 _ExceptionLess_ 进行异常在线报告  
  - [x] 显示可恢复内容。

- [ ] 第四阶段（新的 SnapRAID 命令？）  
  - [ ] 扩展帮助，带磁盘恢复 - 交互式指南等。  
  - [ ] 通知用户其 SnapRAID 版本已过时  
  - [ ] 解析 SnapRAID 日志（被以下更改使用）  
  - [ ] 在命令运行后提供阵列状态  
  - [ ] 修改同步命令以包含初始差异  
  - [ ] 修改同步命令，如果差异报告的问题超过阈值则抛出警告  
  - [ ] 添加用户可配置的同步阈值要求设置


## 截图

![起始视图](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![设置表单](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## 你能帮忙吗？
- 寻找测试人员（所有 .Net 平台）
- 可以帮助翻译
- 帮助 / 用户界面指南
- 任何其他想法 :-)
- 这些想法的开发者


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-27

---