# BoostServerTech 聊天

此仓库包含一个用 C++ 编写的聊天应用程序代码。

完整文档请见 [这里](https://anarthal.github.io/servertech-chat/)。

| 构建                                                                                              | 文档                                                                                                                                            | 在线服务器                     |
| -------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------- |
| ![构建状态](https://github.com/anarthal/servertech-chat/actions/workflows/build.yml/badge.svg) | [![构建状态](https://github.com/anarthal/servertech-chat/actions/workflows/doc.yml/badge.svg)](https://anarthal.github.io/servertech-chat/) | [试用！](http://16.171.43.27/) |

## BoostServerTech 项目

这是 [BoostServerTech 项目](https://docs.google.com/document/d/1ZQrod1crs8EaNLLqSYIRMacwR3Rv0hC5l-gfL-jOp2M) 系列的第一个项目，
该系列项目展示了如何使用 C++ 和 Boost 来编写服务器端代码。

## 架构

服务器基于 Boost.Beast，异步（C++20 协程）
且单线程。构建需要 C++20。它使用 Redis 和 MySQL 进行
持久化。

客户端是基于网页的，使用 Next.js。它通过 websocket 与服务器
通信。

你可以在文档的
[本节](https://anarthal.github.io/servertech-chat/01-architecture.html) 中阅读更多关于架构的信息。

## 本地开发

你可以通过使用 Docker Compose 快速在本地主机运行聊天应用，
在仓库根目录的终端运行：

```
docker compose up --build
```
或者你也可以了解如何设置传统的开发环境  
[这里](https://anarthal.github.io/servertech-chat/02-local-dev.html)。

## 几分钟内上线

该项目具有一个CI/CD管道，可以在几分钟内将你的代码部署到服务器。  
你只需要一个启用了SSH的Linux服务器，或一个用于创建服务器的AWS账户。  
你可以在[这里](https://anarthal.github.io/servertech-chat/03-fork-modify-deploy.html)了解更多。

## 想要贡献？

在[cpplang Slack](https://cpplang.slack.com/archives/C06BRML5EFK)给我们留言吧！  
欢迎所有贡献者！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-27

---