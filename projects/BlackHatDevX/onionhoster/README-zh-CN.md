<details align="right">
<summary>🌐 语言</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)

</details>

# OnionHoster v2.2

> **终极 Tor 隐藏服务托管工具** - 在几分钟内将您的网页项目部署到暗网！

[![版本](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![平台](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![许可证](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

---

## 🚀 什么是 OnionHoster？

OnionHoster 是一个强大的跨平台 bash 脚本，只需一条命令即可将任何网页项目转换为 Tor 隐藏服务。无论您是托管 Next.js 应用、Flask 后端，还是静态网站，OnionHoster 都能自动处理所有复杂的 Tor 配置。

### ✨ 为什么选择 OnionHoster？

- **🔧 零配置** - 适用于任何网页项目，开箱即用
- **🌍 跨平台** - 支持 Linux、macOS 及主流发行版
- **⚡ 一键设置** - 2 分钟内完成隐藏服务部署
- **🔄 自动更新** - 内置更新检查器，保持最新
- **💾 备份与恢复** - 永不丢失您的洋葱地址
- **🎯 专业界面** - 美观的彩色界面和直观菜单

---
## 预览

https://github.com/user-attachments/assets/b8fe44e8-2b1f-4fdc-bb52-7c4a5ee2c67e


# ⚠️ 警告：OnionHoster 不是魔法匿名工具 — 请遵循最佳实践，否则风险身份暴露

**系统加固**

* 在虚拟机或容器内运行服务以实现隔离。
* 保持操作系统和软件包更新。
* 禁用不必要的服务/端口，确保只有 Tor 流量进出。

**操作安全（OpSec）实践**

* 不要在同一台机器上使用个人账户或进行个人活动。
* 避免暴露识别性元数据（文件名、头信息、错误消息）。
* 注意日志——记录什么、保存多久以及是否会泄露信息。

**网络卫生**

* 不要将你的隐藏服务与清网身份或域名关联。
* 使用防火墙确保不会意外泄漏到 Tor 以外。
* 考虑使用反向代理以增加隔离。

**测试与监控**

* 使用 torsocks 或 Tor 浏览器验证你的服务仅通过 `.onion` 地址可访问。
* 定期测试是否有泄漏（例如，应用是否尝试从清网获取数据）。

**使用场景意识**

* 对于爱好者/测试/教育用途：上述措施通常已足够。
* 对于高风险、真实世界匿名（记者、举报者、活动家）：需要更深层的操作安全和威胁建模，因为一次失误可能导致身份暴露。


---
## 🎯 适用对象

- **开发者** 希望在 Tor 上测试应用的人员
- **隐私倡导者** 托管匿名服务的人士
- **研究人员** 研究暗网技术的专家
- **企业** 需要匿名托管解决方案的公司
- **爱好者** 探索 Tor 网络的用户

---

## 🚀 快速开始

### 前提条件
- root/sudo 权限
- 网络连接
- 任何 Web 项目（HTML、Next.js、Flask 等）

### 安装与使用

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```

**就是这样！** 🎉

您将获得完整的 OnionHoster 项目，包括：
- 主要的 `onionhoster.sh` 脚本
- 一个专业的 `index.html` 模板用于托管
- 所有文档和示例

脚本将自动：
- 检测您的操作系统
- 安装所有必需的依赖项（Tor、Apache 等）
- 配置 Tor 服务
- 为您呈现直观的菜单

---

## 🎮 功能概览

### 🌐 托管选项
- **静态 HTML** - 托管任何 `index.html` 文件
- **端口转发** - 转发到任何本地应用端口
- **动态应用** - 支持 Next.js、Flask、Node.js 等

### 🛠️ 管理工具
- **服务控制** - 启动、停止及管理您的隐藏服务
- **备份与恢复** - 安全备份和恢复您的 onion 域名
- **URL 刷新** - 需要时生成新的 onion 地址
- **状态监控** - 检查服务健康和状态

### 🔄 智能更新
- **自动检测** - 自动查找最新版本
- **一键更新** - 通过一个菜单选项更新
- **安全更新** - 不会丢失您的配置

---

## 📱 支持的操作系统

| 操作系统 | 包管理器 | 状态 |
|----|----------------|---------|
| **Ubuntu/Debian** | `apt-get` | ✅ 完全支持 |
| **CentOS/RHEL** | `yum` | ✅ 完全支持 |
| **Fedora** | `dnf` | ✅ 完全支持 |
| **Arch Linux** | `pacman` | ✅ 完全支持 |
| **macOS** | `brew` | ✅ 完全支持 |

---

## 🎯 使用场景

### 🏠 个人项目
- 匿名托管您的作品集
- 私密测试网页应用
- 分享内容而不暴露身份

### 🏢 商业应用
- 匿名客户支持门户
- 安全的内部通信系统
- 注重隐私的商业网站

### 🔬 研究与开发
- 暗网技术研究
- 隐私工具开发
- 匿名服务测试

---

## 📖 详细使用说明

### 主菜单选项

1. **托管 index.html** - 提供静态 HTML 文件服务
2. **转发到应用端口** - 代理到任何本地服务
3. **备份 tor 域名** - 保存您的 onion 配置
4. **恢复 tor 域名** - 从备份恢复
5. **查看当前 tor 域名** - 查看您的活动 onion 地址
6. **刷新 tor 域名** - 生成新的 onion 地址
7. **检查更新** - 更新到最新版本
8. **网页服务器状态** - 监控服务健康状况
9. **关于 OnionHoster** - 版本和功能信息

### 示例工作流程

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 高级配置

### 自定义端口转发
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### 备份管理
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```

---

## 🛡️ 安全特性

- **自动 Tor 配置** - 开箱即用的安全默认设置  
- **正确的文件权限** - 安全的文件所有权和访问权限  
- **服务隔离** - 每个隐藏服务独立运行  
- **无数据日志** - 您的活动保持私密  

---

## 🚨 重要说明

- **需要 Root 访问权限** - Tor 服务需系统级配置  
- **Tor 网络** - 您的服务可通过 Tor 浏览器访问  
- **Onion 地址** - 每个服务拥有唯一的 `.onion` 地址  
- **定期备份** - 刷新时 Onion 地址会变化  

---

## 🤝 贡献指南

我们欢迎贡献！无论是：  
- 🐛 Bug 报告  
- 💡 功能请求  
- 📝 文档改进  
- 🔧 代码贡献  

**开始步骤：**  
1. Fork 代码库  
2. 创建功能分支  
3. 进行修改  
4. 提交拉取请求  

---

## 📄 许可协议

本项目采用 MIT 许可证 - 详情见 [LICENSE](LICENSE) 文件。

---

## 🙏 致谢

- **Tor 项目** - 感谢其出色的匿名网络  
- **开源社区** - 感谢持续的改进  
- **用户与贡献者** - 感谢反馈和建议  

---

## 🔗 链接

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)  
- **问题反馈**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)  
- **讨论区**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)  

---

## ⭐ 点亮这个项目

如果 OnionHoster 对你有帮助，请给它点个星！这激励我们不断改进，也帮助其他人发现这个工具。  

---

**准备好匿名了吗？** 🕵️‍♂️  

```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```
*您的匿名托管之旅现在开始！* 🚀



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-20

---