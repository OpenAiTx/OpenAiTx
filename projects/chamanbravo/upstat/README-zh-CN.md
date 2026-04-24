<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> 简单易用的自托管状态监控工具

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 在线演示

试用一下。

演示服务器（地点：新加坡）：[https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

用户名：`demo`
密码：`demodemo`

## ⭐ 特性

还需要更多功能，但目前...

- 监控 HTTP(s) 的正常运行时间
- 状态和延迟图表
- 通过 Discord 通知
- 60 秒间隔
- 精美、响应迅速、快速的 UI/UX
- 多个状态页面
- 将状态页面映射到特定域名
- Ping 图表
- 证书信息
- PWA
- 支持 Sqlite 和 Postgres 数据库

还有数十个小功能待添加。

## 🔧 安装方法

### 🐳 Docker
对于 Sqlite


```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```
对于 Postgres


```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat 现已运行在 http://localhost:3000

> [!IMPORTANT]
> 部署前请务必更改环境变量值。

### 💪🏻 非 Docker

需求：

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres（可选）

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```
## 技术栈

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 贡献指南

欢迎贡献！贡献使开源社区成为一个令人惊叹的学习、启发和创造的地方。您所做的任何贡献都**非常感谢**。

如果您有改进建议，请先 fork 该仓库，进行修改后提交拉取请求。您也可以直接打开一个带有“enhancement”标签的问题。
别忘了给项目点个星！再次感谢！

1. Fork 项目
2. 创建您的功能分支 (`git checkout -b feature/AmazingFeature`)
3. 提交您的更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 打开拉取请求

## 贡献者

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 许可证

本项目采用 [MIT 许可证](https://opensource.org/license/mit/) 许可。

## 🖼 更多截图

创建监控器

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

监控页面

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />


Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-24

---