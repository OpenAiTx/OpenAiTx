<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=dexter-xD&project=project-box&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# C语言项目集锦

[![请我喝杯咖啡](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://buymeacoffee.com/trish07)

本项目集包含了为初学者设计的C语言项目，旨在帮助学习和实践各种编程概念，从基础算法到网络编程。每个项目均为独立模块，并配有相应的文档和构建系统。

## 项目概览

### 1. [SHA-512 实现](SHA-512/)
一个加密哈希函数实现，展示了：
- 位操作
- 复杂算法
- 内存管理
- 文件I/O操作

### 2. [HTTP服务器](http-server/)
一个基础的HTTP服务器实现，涵盖：
- 套接字编程
- HTTP协议基础
- 文件服务
- 网络通信

### 3. [UDP服务器-客户端](udp-server-client/)
一个简单的基于UDP的通信系统，内容包括：
- UDP套接字编程
- 客户端-服务器架构
- 网络协议
- 消息交换

### 4. [端口扫描器](port-scanner/)
一个网络诊断工具，演示：
- TCP套接字编程
- 网络扫描技术
- 错误处理
- 命令行参数解析

### 5. [Ping实现](ping/)
自定义Ping工具，涵盖：
- ICMP协议
- 原始套接字编程
- 网络诊断
- 时间测量

### 6. [井字棋](tic-tac-toe/)
一个经典游戏实现，教学：
- 多人游戏服务器
- 套接字编程
- 游戏逻辑
- 用户输入处理

### 7. [聊天系统](chat-system/)
一个实时聊天应用，演示：
- TCP套接字编程
- 多线程
- 实时通信
- 客户端-服务器架构

### 8. [词法分析器](lexical-analyser/)
一个简单的编译器前端组件，演示：
- 源代码分词
- 解析技术
- 编译器设计原理
- 字符串处理

### 9. [算术编译器](arithmetic-compiler/)
一个简单的编译器，输入算术表达式并生成类汇编代码：
- 词法分析（分词）
- 表达式解析与求值
- 汇编代码生成

- 编译器构建基础

### 10. [小行星游戏](asteroid-game/)
一个基于终端的游戏，你需要控制飞船躲避下落的小行星：

- 游戏状态管理
- 用户输入处理
- 基于终端的图形显示
- 实时游戏机制
- 简单的碰撞检测

## 入门指南

本仓库中的每个项目都设计为自包含，并包括：
- 源代码
- Makefile 或 CMake 配置
- 包含构建和使用说明的 README
- 实现细节

开始任何项目的步骤如下：
1. 进入项目目录
2. 阅读项目的 README.md
3. 按照构建说明操作
4. 按说明运行程序

## 先决条件

- GCC 编译器（用于 C 项目）
- G++ 编译器（用于 C++ 项目）
- Make 工具
- CMake（用于 C/C++ 项目）
- 基本的 C/C++ 编程知识
- 对于网络项目：了解基础的网络概念

## 推荐书籍

入门 C 编程，我推荐这本全面的书籍：
[The C Programming Language](https://amzn.to/3F2Y1Zl) —— 学习 C 语言基础和最佳实践的必备资源。

## 学习路径

这些项目按复杂度递增的顺序排列：

1. 从井字棋开始，掌握基础编程概念
2. 进阶到 SHA-512，学习算法实现
3. 尝试 UDP 客户端-服务器，入门基础网络
4. 继续 HTTP 服务器和聊天系统，体验更复杂的网络编程
5. 最后探索端口扫描器和 Ping，掌握高级网络概念

## 贡献方式

欢迎你：
- 报告 Bug
- 提出改进建议
- 添加新功能
- 创建新项目
- 改进文档

## 许可证

本项目为开源，供学习用途使用。

## 注意

部分网络相关项目（端口扫描器、Ping）因使用原始套接字，需要 root/管理员权限运行。请始终负责任地使用这些工具，仅在你有权限的网络上进行测试。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---