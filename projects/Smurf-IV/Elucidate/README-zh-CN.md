
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [项目描述](#project-description)
- [系统要求](#os-requirements)
- [常见问题](#faqs)
- [路线图](#roadmap)
- [截图](#screenshots)

## 项目描述

Elucidate 是一个 Windows 图形界面前端，用于命令行 SnapRAID 应用程序。

*此项目继续整合我本人及其他贡献者所做的出色工作。

## 系统要求

- Windows 操作系统
- .Net 运行时 4.8.0
- SnapRaid 版本 11.5 或更低
- 目标驱动器需有 10MB 空闲空间

## 常见问题

**问**：SnapRAID 是什么？<br/>
**答**：SnapRAID 是一个为 Windows 和 Linux 操作系统设计的软件快照奇偶校验引擎。最基本的功能是通过计算其组件文件的哈希值并将结果存储在奇偶校验文件中，为文件系统内容提供保护。如果硬盘完全损坏，可以利用该奇偶校验文件重建丢失的数据。详细内容可参见 SnapRAID 的[官方文件保护引擎对比。](http://snapraid.sourceforge.net/compare.html)

**问**：为什么需要图形界面，命令行不是可以用吗！<br/>
**答**：更大的目标是创建一个功能完整的图形界面，并增加一些管理功能，帮助用户维护一个正常运行的 SnapRAID 环境。有时候，“点点鼠标”对于新手来说更容易上手。SnapRAID 的技术文档和深度配置对于想要尝试它的人来说，可能让人望而却步！

**问**：我还是不确定，还有更多内容吗？<br/>
**答**：有的，可以看看[文档](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md)，里面有图片等信息。

**问**：那么，“更大的目标”有哪些？<br/>
**答**：请看下面的 __路线图__ 完整细分。

## 路线图

- [x] 第一阶段
  - [x] 尝试保持对最新 SnapRAID 的最低支持。 - __持续进行中。__
  - [x] 使用简便
  - [x] SnapRAID 有三个命令，所以让新手可以简单访问它们
  - [x] 进度指示器
  - [x] 日志“交互式”及直接写入日志
  - [x] 用户登录时自动启动
  - [x] 工具提示进行引导 •

- [x] 第二阶段 第二阶段功能请求
  - [x] 暂停、改变优先级、终止
  - [x] 命令扩展 - “允许为默认值添加额外参数。”
  - [x] 调度
    - 已移除，请使用命令行
  - [x] 受保护数据的图形视图。

- [ ] 第三阶段（2017-03 及以后重启）
  - [x] 新编译器和 .Net 4.7.x
  - [x] 命令行界面
  - [ ] 通过 Krypton Toolkit / Navigator / 等实现新布局
    - 进行中
  - [ ] 翻译
  - [x] 新命令
  - [ ] 带状态报告的邮件发送器
  - [ ] 编写测试步骤文档
    - 进行中
  - [ ] 补充文档 / 更新图片
    - 进行中
  - [ ] 添加 _Windows 事件日志_ 错误报告
  - [x] 添加 _ExceptionLess_ 用于在线异常报告
  - [x] 显示可恢复的内容。

- [ ] 第四阶段（新的 SnapRAID 命令？）
  - [ ] 扩展帮助，包含磁盘恢复和交互式指南等
  - [ ] 如果用户的 SnapRAID 版本过旧则通知用户
  - [ ] 解释 SnapRAID 日志（供下述更改使用）
  - [ ] 在命令执行后提供阵列状态
  - [ ] 修改 sync 命令以包含初始 diff
  - [ ] 如果 diff 报告的问题超过阈值则 sync 命令发出警告
  - [ ] 增加用户可配置的同步阈值设置


## 截图

![启动视图](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![设置表单](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## 你能帮忙吗？
- 寻找测试人员（所有 .Net 平台）
- 可以帮助翻译
- 帮助 / 用户界面指南
- 其他任何想法 :-)
- 为这些想法提供开发人员


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---