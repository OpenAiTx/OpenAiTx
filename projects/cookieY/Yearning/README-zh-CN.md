<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

一个强大、本地部署的平台，专为DBA和开发者量身打造，实现无缝的SQL检测与查询审核。专注于隐私与高效性，提供直观且安全的MYSQL审核环境。

---
[![OSCS 状态](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![平台支持](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![下载次数](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ 功能特性

- **AI助手**：我们的AI助手提供实时SQL优化建议，提升SQL性能。同时支持文本转SQL，用户可输入自然语言，获得优化后的SQL语句。
  
- **SQL审核**：创建SQL审核工单，配合审批流程与自动语法检查。校验SQL语句的正确性、安全性与合规性。DDL/DML操作会自动生成回滚语句，并提供完整历史日志以便溯源。

- **查询审核**：审核用户查询，限制数据源和数据库，脱敏敏感字段。查询记录会被保存，方便后续查阅。

- **检查规则**：自动化语法检查器支持多种检查规则，适用于大多数自动检查场景。

- **隐私保护**：Yearning为本地可部署的开源解决方案，确保数据库和SQL语句的安全。内置加密机制保护敏感数据，即使发生未授权访问也能保证数据安全。

- **RBAC（基于角色的访问控制）**：创建和管理具有特定权限的角色，根据用户角色限制对查询工单、审核功能及其他敏感操作的访问。

> \[!TIP]
> 获取更详细的信息，请访问我们的 [Yearning 指南](https://next.yearning.io)


## ⚙️ 安装说明

下载 [最新版本](https://github.com/cookieY/Yearning/releases/latest) 并解压。在继续操作前请确保已配置好 `./config.toml`。

### 手动安装

```bash
## 初始化数据库
./Yearning install

## 启动 Yearning
./Yearning run

## 帮助
./Yearning --help
```

### 🚀 Docker 部署
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## 初始化数据库
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## 启动 Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 AI助手

我们的AI助手依托大语言模型，提供SQL优化建议和文本转SQL功能。无论使用默认还是自定义提示词，AI助手都能优化SQL语句并将自然语言输入转化为SQL查询。

![文本转SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 自动SQL检查器

自动SQL检查器根据预设规则和语法对SQL语句进行评估，确保语句符合特定编码标准、最佳实践与安全要求，为SQL验证提供强有力的保障。

![SQL审核](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 SQL语法高亮与自动补全

通过SQL语法高亮和自动补全功能提升查询编写效率。这些特性帮助用户直观区分SQL查询中的关键字、表名、列名和操作符，使查询结构更易阅读和理解。

![SQL查询](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ 工单/查询记录

我们的平台支持用户工单和查询语句的审计。该功能可以追踪和记录所有查询操作，包括数据源、数据库及敏感字段处理，确保合规性并实现查询历史的可追溯性。

![工单/查询记录](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

通过聚焦上述核心功能，Yearning提升用户体验，优化SQL性能，并确保数据库操作的合规性与可追溯性。

## 🛠️ 推荐工具

- [Spug - 开源轻量级自动化运维平台](https://github.com/openspug/spug)

## ☎️ 联系方式

如有疑问，请发送邮件至：henry@yearning.io
## 📋 许可证

Yearning 遵循 AGPL 许可证。详情请参见 [LICENSE](LICENSE)。

2024 © Henry Yee

---

使用 Yearning，体验简化、高效且安全的 SQL 审核与优化新方式。


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---