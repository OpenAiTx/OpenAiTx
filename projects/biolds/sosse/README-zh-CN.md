<p>
  <img src="https://raw.githubusercontent.com/biolds/sosse/main/se/static/se/logo.svg" width="64" align="right">
  <a href="https://gitlab.com/biolds1/sosse/" alt="Gitlab 代码覆盖率" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/pipeline-coverage/biolds1/sosse?branch=main&style=flat-square">
  </a>
  <a href="https://gitlab.com/biolds1/sosse/-/pipelines" alt="Gitlab 流水线状态" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/pipeline-status/biolds1/sosse?branch=main&style=flat-square">
  </a>
  <a href="https://sosse.readthedocs.io/en/stable/" alt="文档" style="text-decoration: none">
    <img src="https://img.shields.io/readthedocs/sosse?style=flat-square">
  </a>
  <a href="https://discord.gg/Vt9cMf7BGK" alt="Discord" style="text-decoration: none">
    <img src="https://img.shields.io/discord/1102142186423844944?style=flat-square&color=%235865f2">
  </a>
  <a href="https://gitlab.com/biolds1/sosse/-/blob/main/LICENSE" alt="许可证" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/license/biolds1/sosse?style=flat-square">
  </a>
</p>

# Sosse 🦦

**发现 Sosse** — 基于 Selenium 的开源搜索引擎，专为强大的网页归档、爬取和搜索而构建。
在[官方网站](https://sosse.io)探索其所有功能和能力。

无论您是开发者、研究人员还是数据爱好者，Sosse 都准备好支持您的项目。
加入[GitHub](https://github.com/biolds/sosse)或[GitLab](https://gitlab.com/biolds1/sosse)社区，提交功能请求、报告错误、贡献代码或[开启讨论](https://github.com/biolds/sosse/discussions)。

## 主要功能

- 🌍 **网页搜索**：搜索网页内容，包括动态渲染的页面，支持高级查询。
  ([文档](https://sosse.readthedocs.io/en/stable/guides/search.html))

- 🕑 **定期爬取**：以固定间隔爬取页面，或根据内容变化调整爬取频率。
  ([文档](https://sosse.readthedocs.io/en/stable/crawl/policies.html))

- 🔖 **网页归档**：归档 HTML 内容，调整链接以支持本地使用，下载所需资源，并支持动态内容。
  ([文档](https://sosse.readthedocs.io/en/stable/guides/archive.html))

- 🏷️ **标签**：使用标签组织和筛选爬取或归档的页面，提升搜索和管理效率。
  ([文档](https://sosse.readthedocs.io/en/stable/tags.html))

- 📂 **文件下载**：从网页批量下载二进制文件。
  ([文档](https://sosse.readthedocs.io/en/stable/guides/download.html))

- 📡 **Webhook 集成**：使用高度灵活的 webhook 集成外部服务。连接专有的 AI 平台
  ([文档](https://sosse.readthedocs.io/en/stable/guides/ai_api_processing.html)) 或本地托管解决方案
  ([文档](https://sosse.readthedocs.io/en/stable/guides/local_ai.html))，实现高级数据提取、
  摘要生成、自动标签、通知等功能。

- 🔔 **Atom 订阅源**：为没有订阅源的网站生成内容订阅，或在包含关键词的新页面发布时接收更新。
  ([文档](https://sosse.readthedocs.io/en/stable/guides/feed_website_monitor.html))

- 🔒 **身份验证**：爬虫可通过身份验证访问私密页面并获取内容。
  ([文档](https://sosse.readthedocs.io/en/stable/guides/authentication.html))

- 👥 **权限管理**：管理员可配置爬虫并查看统计数据，经过身份验证的用户可搜索，也可匿名搜索。
  ([文档](https://sosse.readthedocs.io/en/stable/permissions.html))

- 👤 **搜索功能**：包括私有搜索历史 ([文档](https://sosse.readthedocs.io/en/stable/user/history.html))，
  以及外部搜索引擎快捷方式 ([文档](https://sosse.readthedocs.io/en/stable/user/shortcuts.html)) 等。

浏览 📚 [文档](https://sosse.readthedocs.io/en/stable/index.html) 并查看一些
📷 [截图](https://sosse.readthedocs.io/en/stable/screenshots.html)。

Sosse 使用 Python 编写，遵循 [GNU AGPLv3 许可证](https://www.gnu.org/licenses/agpl-3.0.en.html) 发行。它使用基于浏览器的爬取方式，结合 [Mozilla Firefox](https://www.mozilla.org/firefox/) 或
[Google Chromium](https://www.chromium.org/Home) 以及 [Selenium](https://www.selenium.dev/)，对依赖 JavaScript 的页面进行索引。为了更快的爬取，也可使用 [Requests](https://docs.python-requests.org/en/latest/index.html)。Sosse 使用
[PostgreSQL](https://www.postgresql.org/) 进行数据存储。

## 试用

快速通过 Docker 试用最新版本：


```
docker run -p 8005:80 biolds/sosse:stable
```
然后，打开 [http://127.0.0.1:8005/](http://127.0.0.1:8005/) 并使用用户名 `admin` 和密码 `admin` 登录。

有关 Docker 数据持久化或其他安装方法，请参阅[安装指南](https://sosse.readthedocs.io/en/stable/install.html)。

## 保持联系

加入 [Discord 服务器](https://discord.gg/Vt9cMf7BGK) 获取帮助、分享想法或讨论 Sosse！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-29

---