# 达芬奇调色项目服务器

![Lint](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/lint.yml/badge.svg)
![Healthcheck](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/stack-healthcheck.yml/badge.svg)
![Docker Build](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/docker.yml/badge.svg)

简单的 Resolve 项目服务器，带自动备份功能

## 目录

- [达芬奇调色项目服务器](#davinci-resolve-project-server)
  - [目录](#table-of-contents)
  - [简介](#introduction)
    - [功能](#features)
  - [配置](#configuration)
    - [数据库](#database)
    - [备份](#backups)
    - [PGAdmin](#pgadmin)
    - [卷位置](#volume-locations)
  - [安装](#installation)
    - [QNAP 安装](#qnap-installation)
    - [群晖](#synology)
    - [Linux](#linux)
  - [不同的 PostgreSQL 版本](#different-postgresql-versions)
    - [设置 PostgreSQL 9.5 或 11 项目服务器](#setting-up-a-postgresql-95-or-11-project-server)
  - [致谢](#thanks)

## 简介

有很多方法可以托管 Resolve 项目服务器，但每种方法都有各自的问题。官方的项目服务器需要手动备份，其他选项对于没有 IT 团队支持的人来说可能比较复杂。希望这是一个对小团队来说更可靠、更简单的解决方案！

### 功能

- **轻量级** - 基于 Docker，因此不需要完整的 macOS 或 Windows 机器或虚拟机。
- **平台无关** - 可以安装在 Windows、Mac、Linux、QNAP、群晖、树莓派，实际上任何能运行 Docker 的设备上。
- **兼容 Resolve 现有的备份/恢复功能** - 所有备份文件均使用标准的 Resolve \*.backup 文件格式，并且可以通过 Resolve UI 恢复。
- **内置 PGAdmin 服务器** - PGAdmin 是管理 PostgreSQL 服务器的工具，有助于诊断问题和迁移/更新整个服务器。

## 配置

我们需要编辑 docker-compose.yml 文件顶部的几项内容，以配置我们的安装：

```yaml
---
version: "3.8"
x-common:
  database: &db-environment
    POSTGRES_DB: database
    POSTGRES_USER: &pg-user postgres
    POSTGRES_PASSWORD: DaVinci
    TZ: America/Chicago
    POSTGRES_LOCATION: &db-location "???:/var/lib/postgresql/data"
  backup: &backup-environment
    SCHEDULE: "@daily"
    BACKUP_KEEP_DAYS: 7
    BACKUP_KEEP_WEEKS: 4
    BACKUP_KEEP_MONTHS: 6
    BACKUP_LOCATION: &bk-location "???:/backups"
  admin: &admin-environment
    PGADMIN_DEFAULT_EMAIL: admin@admin.com
    PGADMIN_DEFAULT_PASSWORD: root
    PGADMIN_PORT: &pgadmin-port "3001:80"
```

### 数据库

要配置服务器本身，我们需要配置以下环境变量：
| 环境变量 | 含义 |
|---|---|
| POSTGRES_DB | 你的数据库名称。可以随意命名。 |
| POSTGRES_USER | 连接数据库时使用的用户名。Resolve 默认是 "postgres" |
| POSTGRES_PASSWORD | 连接数据库时使用的密码。Resolve 默认是 "DaVinci" |
| TZ | 你的时区，这里有一个[列表](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones)|
| POSTGRES_LOCATION | 数据库存储位置。请参见[卷位置](#volume-locations) |

### 备份

要配置备份，我们需要配置以下变量：
| 环境变量 | 含义 |
|---|---|
| SCHEDULE | 备份创建频率的[cron 字符串](https://www.freeformatter.com/cron-expression-generator-quartz.html)。可以是 "@daily", "@every 1h" 等 |
| BACKUP_KEEP_DAYS | 保留的每日备份数量，超过后将删除。 |
| BACKUP_KEEP_WEEKS | 保留的每周备份数量，超过后将删除。 |
| BACKUP_KEEP_MONTHS | 保留的每月备份数量，超过后将删除。 |
| BACKUP_LOCATION | 备份存储位置。请参见[卷位置](#volume-locations) |

### PGAdmin

要配置 PGAdmin，我们需要配置以下变量：
| 环境变量 | 含义 |
|---|---|
| PGADMIN_DEFAULT_EMAIL | PGAdmin 登录使用的邮箱。默认是 "admin@admin.com" |
| PGADMIN_DEFAULT_PASSWORD | PGAdmin 登录使用的密码。默认是 "root" |
| PGADMIN_PORT | 配置 PGAdmin 暴露端口的字符串。格式为 "YOUR_PORT:80" |

### 卷位置

数据库和备份的位置取决于你安装的平台。你需要知道想要存储它们的文件夹的完整路径。例如，在 QNAP NAS 上，如果我想使用名为 "Videos" 的共享文件夹内名为 "Backups" 的文件夹作为备份位置，路径将是 `/shares/Videos/Backups/`，我的 `BACKUP_LOCATION` 值将如下所示：

```yaml
BACKUP_LOCATION: &bk-location "/shares/Videos/Backups/:/backups"
```
在 Ubuntu 上，如果我想使用名为 "database" 的文件夹，位于用户名为 "johndoe" 的用户主目录中作为我的数据库位置，路径将是 `/home/johndoe/database/`，而我的 `POSTGRES_LOCATION` 值将如下所示：


```yaml
POSTGRES_LOCATION: &db-location "johndoe/database/:/var/lib/postgresql/data"
```
我建议将数据库放在SSD上，使用机械硬盘访问速度会明显变慢。

配置好这些设置后，保存修改后的docker-compose.yml文件，然后继续安装！

## 安装

### QNAP 安装

在QNAP NAS上安装相对简单。需要注意的是，请将数据库文件放在SSD上。你以后会感谢我的。

1. 如果你还没有安装，请从QNAP应用商店安装Container Station。
2. 在Container Station中，点击“创建”，然后点击“创建应用程序”。
3. 给你的应用程序起一个名字（例如 ResolveServer）。
4. 复制/粘贴你修改过的docker-compose.yml文件，点击“验证YAML”测试，如果通过，点击“创建”。
5. Container Station会下载所需文件并启动应用。完成后，你应该可以使用数据库名称和凭据连接Resolve到QNAP的IP地址。

### Synology

请参阅[此讨论](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/discussions/15#discussioncomment-4615278)。

### Linux

1. 按照[你的Linux发行版的Docker安装说明](https://docs.docker.com/engine/install/)进行安装。
2. 安装[Docker Compose](https://docs.docker.com/compose/install/)。
3. 将修改后的docker-compose.yml文件移动到Linux机器上的一个文件夹，然后在终端中切换到该文件夹。
4. 运行：
   `docker-compose up -d`
5. Docker-compose会下载所需文件并启动应用。完成后，你应该可以使用数据库名称和凭据连接Resolve到Linux服务器实例的IP地址。

## 不同的PostgreSQL版本

通常，Resolve对不匹配的PostgreSQL版本容忍度不高。Resolve 18使用PostgreSQL 13，这也是本仓库当前的默认版本。Resolve 17及以下版本使用PostgreSQL 9.5。不幸的是，9.5主版本已停止维护，特别是9.5.4存在许多安全漏洞，导致不安全。
由于大多数人仍在使用默认的Resolve服务器凭据，安全性通常不是最大的问题，但如果你试图用旧版本Resolve保护你的项目服务器，建议升级到受支持的PostgreSQL版本。

Resolve 17及以下仍使用PostgreSQL 12中已移除的遗留功能，因此可用的最新主版本是11，该版本将维护至2023年11月9日。

### 设置PostgreSQL 9.5或11项目服务器

要设置PostgreSQL 9.5或11服务器而非13，需要修改docker_compose.yml中的两行：


```yaml
services:
  postgres:
    image: postgres:13
    ...
  pgbackups:
    image: prodrigestivill/postgres-backup-local:13
    ...
...
```
至以下内容：


```yaml
services:
  postgres:
    image: postgres:9.5
    ...
  pgbackups:
    image: prodrigestivill/postgres-backup-local:9.5
    ...
...
```

## 感谢

-感谢 [prodrigestivill](https://github.com/prodrigestivill/) 提供他的 [PostgreSQL 备份 Docker 镜像](https://github.com/prodrigestivill/docker-postgres-backup-local)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---