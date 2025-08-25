![Ogres 应用截图](https://raw.githubusercontent.com/samcf/ogres/main/site/web/media/ogres-media-collection.webp)

## 功能

[ogres.app](https://ogres.app) 是一个免费且开源的虚拟桌面应用，可以在浏览器中运行，供你与朋友一起游戏。它旨在成为一些更全面工具的轻量级替代品。其有限的核心功能集旨在帮助地下城主快速设置遭遇和冒险，只包含最重要的必需品。

- 立即开始准备你的游戏；无需注册或广告
- 为你的朋友开启在线协作会话
- 同时准备和管理多个场景
- 内置先攻追踪器，简化遭遇流程
- 响应式设计，适用于手机和平板
- 适用于其他游戏系统，易于使用
- … 还有更多计划中功能！

## 贡献

有兴趣帮助修复漏洞或扩展功能？查找标记为 **初学者友好** 的问题，并评论你想参与。以下是启动本地开发环境的说明（仅限开发者）。

> [!重要]
> 你需要安装 `node`、`npm` 和 `clojure`。

```sh
#!/bin/sh

# copy the repository
git clone git@github.com:samcf/ogres.git

# install dependencies and start the local web server
# by default opens at http://localhost:8080
npm install
npm start

# run the process that bundles CSS files
npm run style

# optionally, start the application server necessary
# for hosting online sessions
clojure -M -m ogres.server.core 5000
```

## 运行您自己的服务器

您可以使用 Docker 运行此应用程序的实例。有关更多信息，请参阅 [wiki 文档](https://github.com/samcf/ogres/wiki/Docker-Usage)。以下命令将安装并运行该应用程序。

```sh
#!/bin/sh
docker compose up -d
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---