
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=androbuster&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🚀 AndroBuster

<div align="center">
  <img width="2808" height="699" alt="bannerfinal" src="https://github.com/user-attachments/assets/7f74539f-0af6-40d9-bafb-9207afd80af8" />

</div> 

<div align="center">

**🔒 渗透测试变得简单**  
*一个强大的目录与子域枚举工具，采用 Flutter 构建*

[![下载 APK](https://img.shields.io/badge/Download-APK-blue?style=for-the-badge&logo=android)](https://github.com/BlackHatDevX/androbuster/releases)
[![GitHub 星标](https://img.shields.io/github/stars/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub 分支](https://img.shields.io/github/forks/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub 问题](https://img.shields.io/github/issues/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster/issues)

</div>

---

## 📖 概述

AndroBuster 是一个**开源安全工具**，灵感来自 GoBuster，提供现代化、跨平台的目录和子域枚举界面。采用 Flutter 构建，拥有简洁直观的用户体验，同时保持了专业安全工具应有的强大与灵活。

### 🎯 AndroBuster 的独特之处？
- 🚀 **跨平台**：支持 Android、iOS 和桌面
- 🔒 **安全为本**：专为渗透测试人员设计
- 💻 **现代 UI**：优美的 Flutter 界面
- ⚡ **高性能**：高效线程与内存管理
- 📱 **移动优先**：针对移动安全测试优化

---

## 🖼️ 截图

<div align="center">

<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 24 AM" src="https://github.com/user-attachments/assets/e12ed93e-876f-408b-9e3d-4a849e8fe2a1" />
<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 34 AM" src="https://github.com/user-attachments/assets/17850561-cef9-46e2-8203-8ba29c223fe7" />

</div>

---



## ✨ 功能

### 🗂️ 目录枚举模式
- **目标 URL 输入**：自动去除末尾斜杠的 URL 规范化处理
- **负面状态码**：过滤不需要的 HTTP 状态码（默认：404）
- **负面页面大小**：根据内容长度排除响应
- **字典支持**：支持大文本输入及文件导入功能
- **线程控制**：可配置线程数以优化性能
- **超时设置**：毫秒级自定义请求超时时间

### 🌐 子域名枚举模式
- **域名输入**：域名规范化处理（无需 http/https）
- **子域名字典**：专用字典管理用于发现子域名
- **协议测试**：自动 HTTPS/HTTP 回退测试
- **子域名校验**：符合 RFC 1123 标准的子域名名称校验
- **专用过滤器**：子域名支持独立的负面状态码和页面大小过滤
- **线程与超时**：可独立于目录模式进行配置

### 📋 结果管理
- **统一结果标签页**：同时查看目录与子域名扫描结果
- **结果格式化**：清晰显示路径、状态码、大小和 URL
- **复制到剪贴板**：结果可导出用于外部分析
- **清除结果**：扫描间轻松清理结果
- **结果计数**：分别统计目录与子域名结果数量

### 📁 文件管理
- **字典导入**：支持最大 50MB 的 .txt 文件
- **智能预览**：按文件大小智能显示内容
- **大文件处理**：高效处理超大字典文件
- **格式支持**：自动处理注释（#）和空行

### 🚀 性能与可靠性
- **后台执行**：应用在后台扫描时仍持续运行
- **内存优化**：高效管理大型字典文件
- **错误处理**：优雅的回退与恢复机制
- **跨平台支持**：基于 Flutter，适用于 Android 和 iOS



---

## 📱 安装

### 📦 发布版本
目前仅提供 Android APK 版本。请从发布页面下载最新的 APK。

<div align="center">

[![下载最新](https://img.shields.io/badge/📥%20下载最新发布-blue?style=for-the-badge)](https://github.com/BlackHatDevX/androbuster/releases)

</div>

### 🔧 源码构建
源代码现已公开，任何人都可以使用、修改并贡献。

---

## 📖 使用指南

### 🗂️ 目录枚举
1. 进入“Dir”标签页
2. 输入目标 URL
3. 配置负状态码和页面大小
4. 粘贴或导入字典
5. 设置线程数和超时时间
6. 启动扫描并监控进度

### 🌐 子域枚举
1. 进入“Subdomain”标签页
2. 输入目标域名（不带 http/https）
3. 配置子域专用过滤器
4. 导入或粘贴子域字典
5. 调整线程数和超时时间
6. 开始子域发现

### 📋 结果管理
- 在“Results”标签页查看所有结果
- 复制结果到剪贴板以便外部分析
- 在不同扫描间清除结果
- 监控扫描进度和完成情况

---

## ⚙️ 配置

### ⚡ 线程数
- **推荐**：大多数情况下建议使用10-20个线程
- **高线程警告**：超过20线程时会警告
- **注意事项**：线程数过高可能会触发限速

### ⏱️ 超时设置
- **默认**：5000毫秒（5秒）
- **调整**：网络较慢可增加，响应较快可减少
- **范围**：支持1000毫秒到30000毫秒

### 🚫 负过滤器
- **状态码**：用逗号分隔的列表（如404,403,500）
- **页面大小**：用逗号分隔的列表（如0,1234,5678）
- **用途**：从结果中排除不需要的响应

---

## 🤝 参与贡献

该项目为**开源**，欢迎大家贡献！源代码现已公开，任何人都可访问。

<div align="center">

[![Star Repository](https://img.shields.io/badge/⭐%20Star%20Repository-yellow?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)

</div>

### 📋 如何贡献
1. **⭐ Star**仓库（可选，但非常感谢！）
2. **🍴 Fork**仓库
3. **🌿 创建**新功能分支
4. **📤 提交**拉取请求

---

## 🙏 致谢与鸣谢

- **🎯 灵感来源**：[GoBuster](https://github.com/OJ/gobuster) - 原始的目录枚举工具
- **🛠️ 构建工具**：[Flutter](https://flutter.dev/) - Google 的原生编译应用 UI 工具包
- **🔒 安全性重点**：专为渗透测试人员和安全研究人员设计
- **🌍 社区**：感谢所有贡献者和支持者

---

## 📄 许可证

本项目为**开源**，采用 MIT 许可证。

---

## ⚠️ 免责声明

本工具仅用于**授权安全测试**和**渗透测试目的**。用户需确保在测试任何系统前已获得适当授权。开发者不对任何滥用本工具的行为负责。

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-24

---