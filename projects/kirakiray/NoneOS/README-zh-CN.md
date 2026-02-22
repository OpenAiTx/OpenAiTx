# NoneOS - 基于浏览器的轻量级虚拟操作系统

[中文](https://raw.githubusercontent.com/kirakiray/NoneOS/main/./md/README_CN.md) | [日本語](https://raw.githubusercontent.com/kirakiray/NoneOS/main/./md/README_JP.md)

## 项目介绍

NoneOS 是一个创新的基于浏览器的虚拟操作系统解决方案，采用纯静态文件架构，能够在无后端服务器支持的情况下运行。

短期目标：打造一个基于浏览器的轻量级 NAS 系统，实现设备间的无缝连接与协作。

- [x] 支持基于浏览器的文件管理
- [x] 书签同步应用
- [x] 笔记同步应用（类似 Notion）
- [x] 文件传输应用（类似 LocalSend）
- [ ] 重构笔记同步应用

## 快速开始

直接访问官网：[https://os.noneos.com/](https://os.noneos.com/)

### 本地运行
1. 克隆或下载项目，确保本地已安装 nodejs。
2. 安装依赖：
```bash
npm install
```
3. 启动服务器：
```bash
npm run static
```
1. 访问：`http://localhost:5559/`

## 如何创建应用程序？

NoneOS 采用先进的 Web 微应用架构，每个应用程序都建立在强大的 ofa.js 框架上。开发者只需将应用程序目录（例如示例应用 `others/hello-world.napp`）导入系统的“Apps”文件夹，即可轻松创建自己的应用程序，实现快速部署和运行。

我们目前正在编写更详细的开发文档。与此同时，开发者可以：
- 参考官方 ofa.js 文档以了解框架功能。
- 查看 `packages/apps` 目录下的示例应用，作为开发参考。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---