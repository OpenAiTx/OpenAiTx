# 🚀 AndroBuster

<div align="center">
  <img width="2808" height="699" alt="bannerfinal" src="https://github.com/user-attachments/assets/7f74539f-0af6-40d9-bafb-9207afd80af8" />

</div> 

<div align="center">

**🔒 渗透测试变得简单**  
*一款基于 Flutter 构建的强大目录和子域枚举工具*

[![Download APK](https://img.shields.io/badge/Download-APK-blue?style=for-the-badge&logo=android)](https://github.com/BlackHatDevX/androbuster/releases)
[![GitHub stars](https://img.shields.io/github/stars/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub forks](https://img.shields.io/github/forks/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub issues](https://img.shields.io/github/issues/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster/issues)

</div>

---

## 📖 概述

AndroBuster 是一款**开源安全工具**，灵感来源于 GoBuster，提供现代化的跨平台目录和子域枚举界面。基于 Flutter 构建，既提供简洁直观的用户体验，又保持了专业安全工具所需的强大功能和灵活性。

### 🎯 AndroBuster 的独特之处？
- 🚀 **跨平台**：支持 Android、iOS 及桌面端
- 🔒 **安全为先**：专为渗透测试人员打造
- 💻 **现代界面**：美观的 Flutter 界面
- ⚡ **高性能**：高效的线程和内存管理
- 📱 **移动优先**：针对移动安全测试优化

---

## 🖼️ 截图

<div align="center">

<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 24 AM" src="https://github.com/user-attachments/assets/e12ed93e-876f-408b-9e3d-4a849e8fe2a1" />
<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 34 AM" src="https://github.com/user-attachments/assets/17850561-cef9-46e2-8203-8ba29c223fe7" />
</div>

---



## ✨ 特性

### 🗂️ 目录枚举模式
- **目标 URL 输入**：自动去除尾部斜杠的清理 URL 处理
- **负面状态码**：过滤不需要的 HTTP 状态码（默认：404）
- **负面页面大小**：基于内容长度排除响应
- **字典支持**：支持大文本输入及文件导入功能
- **线程控制**：可配置线程数以获得最佳性能
- **超时设置**：自定义请求超时时间（毫秒）

### 🌐 子域枚举模式
- **域名输入**：清理域名处理（无需 http/https）
- **子域字典**：专用字典管理用于子域发现
- **协议测试**：自动 HTTPS/HTTP 回退测试
- **子域验证**：符合 RFC 1123 的子域名验证
- **专用过滤器**：子域独立的负面状态码和页面大小过滤
- **线程与超时**：与目录模式独立配置

### 📋 结果管理
- **统一结果标签页**：同时查看目录和子域扫描结果
- **结果格式化**：清晰显示路径、状态码、大小和 URL
- **复制到剪贴板**：导出结果用于外部分析
- **清除结果**：扫描间轻松清理
- **结果计数**：目录和子域结果分别统计

### 📁 文件管理
- **字典导入**：支持最大 50MB 的 .txt 文件
- **智能预览**：根据文件大小显示内容
- **大文件处理**：高效处理超大字典
- **格式支持**：自动处理注释（#）和空行

### 🚀 性能与可靠性
- **后台执行**：应用在后台扫描时持续运行

- **内存优化**：高效处理大型字典列表  
- **错误处理**：优雅的回退和恢复机制  
- **跨平台**：使用 Flutter 构建，支持 Android 和 iOS  

---

## 📱 安装

### 📦 发布版本  
目前仅提供 Android APK 版本。请从发布页面下载最新 APK。  

<div align="center">

[![下载最新版本](https://img.shields.io/badge/📥%20Download%20Latest%20Release-blue?style=for-the-badge)](https://github.com/BlackHatDevX/androbuster/releases)

</div>

### 🔧 从源码构建  
源码现已公开，欢迎所有人使用、修改和贡献。  

---

## 📖 使用指南

### 🗂️ 目录枚举  
1. 进入“Dir”标签页  
2. 输入目标 URL  
3. 配置负面状态码和页面大小  
4. 粘贴或导入字典列表  
5. 设置线程数和超时  
6. 开始扫描并监控进度  

### 🌐 子域名枚举  
1. 进入“Subdomain”标签页  
2. 输入目标域名（不含 http/https）  
3. 配置子域名相关过滤条件  
4. 导入或粘贴子域名字典  
5. 调整线程数和超时设置  


6. 开始子域名发现

### 📋 结果管理
- 在“结果”标签页查看所有结果
- 复制结果到剪贴板以便外部分析
- 不同扫描间清除结果
- 监控扫描进度和完成情况

---

## ⚙️ 配置

### ⚡ 线程数
- **推荐**：大多数场景下使用10-20线程
- **高线程警告**：超过20线程时提示
- **注意事项**：线程过多可能触发速率限制

### ⏱️ 超时设置
- **默认**：5000毫秒（5秒）
- **调整**：网络较慢时增加，响应较快时减少
- **范围**：支持1000毫秒到30000毫秒

### 🚫 负面过滤器
- **状态码**：逗号分隔列表（例如 404,403,500）
- **页面大小**：逗号分隔列表（例如 0,1234,5678）
- **用途**：从结果中排除不需要的响应

---

## 🤝 贡献

该项目为**开源**，欢迎贡献！源码现已公开，供所有人使用。

<div align="center">

[![Star Repository](https://img.shields.io/badge/⭐%20Star%20Repository-yellow?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)

</div>

### 📋 如何贡献
1. **⭐ 收藏** 仓库（可选，但非常感谢！）  
2. **🍴 分叉** 仓库  
3. **🌿 创建** 功能分支  
4. **📤 提交** 拉取请求  

---  

## 🙏 致谢与鸣谢  

- **🎯 灵感来源**：[GoBuster](https://github.com/OJ/gobuster) - 原始目录枚举工具  
- **🛠️ 构建工具**：[Flutter](https://flutter.dev/) - 谷歌用于构建原生编译应用的UI工具包  
- **🔒 安全重点**：专为渗透测试人员和安全研究人员设计  
- **🌍 社区**：感谢所有贡献者和支持者  

---  

## 📄 许可证  

本项目为**开源**，遵循 MIT 许可证。  

---  

## ⚠️ 免责声明  

本工具仅设计用于**授权的安全测试**和**渗透测试目的**。用户有责任确保在测试任何系统前获得适当授权。开发者不对本工具的任何滥用行为负责。  

---  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-24

---