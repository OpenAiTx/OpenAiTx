<h1 align="center">📮 仅为临时邮箱</h1>
<p align="center">由 Cloudflare 提供支持的免费临时邮箱服务
  <br>
  </br>
  <img alt="CodeQL" src="https://github.com/berrysauce/justatemp/actions/workflows/github-code-scanning/codeql/badge.svg">
  <img alt="GitHub release (latest by date including pre-releases)" src="https://img.shields.io/github/v/release/berrysauce/junk.boats?color=blue&include_prereleases&label=latest%20release">
</p>

> ℹ️ 本服务 100% 由 [Cloudflare](https://www.cloudflare.com/) 提供支持

> [!IMPORTANT]
> 本项目之前使用域名 "junk.boats" 提供服务。

### 什么是 justatemp.com？
justatemp.com 是另一个免费使用、开源且当然注重隐私的临时邮箱生成器。您可以使用 justatemp.com 接收来自您不想真正提供邮箱的网站的邮件。所有接收的邮件会公开存储 2 小时，然后永久删除。

<img alt="Just A Temp Screenshot" src="https://public-cdn.berrysauce.me/shared/justatemp-screenshot-yWtqO.png">

### 隐私如何保障？
justatemp.com 仅存储接收的邮件。不存储其他用户数据。邮件会在 2 小时后自动删除。在此之前，任何拥有该接收地址的人都可以查看该地址收到的邮件。为了分析，justatemp.com 使用 Cloudflare 的匿名网页分析。

### 什么是 collector、postmaster 和 postoffice？
- 📮 `mailbox` 是一个 Cloudflare 邮件 worker，用于接收并存储所有传入邮件
- 🚚 `postservice` 是一个由 HonoJS Cloudflare worker 驱动的 API 形式邮件分发服务
- 🏤 `frontend` 是使用 SvelteKit 的前端，向用户显示接收到的邮件

### justatemp.com 如何工作？
传入邮件会发送到 `mailbox` 邮件 worker。它将邮件保存到 Cloudflare KV 数据库。Svelte 前端生成随机邮箱地址，并从 `postservice` 请求该地址的所有邮件。如果有邮件，则按 KV 条目中包含的 UNIX 时间戳排序并显示。

### 开发
更多内容即将推出


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---