
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# SimpleLogin

这是一个自托管的 [SimpleLogin](https://simplelogin.io) docker-compose 配置。

## 前置条件

- 一台 Linux 服务器（可以是虚拟机或专用服务器）。本文档以 Ubuntu 18.04 LTS 为例进行设置，但步骤也可以适配其他主流 Linux 发行版。由于大部分组件以 Docker 容器运行，而 Docker 可能会比较占用资源，建议至少拥有 2 GB 内存。服务器需要开放 25 端口（邮件）、80、443（用于 Web 应用）、22（用于 ssh 远程登录）。

- 一个您可以配置DNS的域名，可以是子域名。在本文档的其余部分，假设用于邮箱的是 `mydomain.com`，用于 SimpleLogin 网页应用的是 `app.mydomain.com`。请确保在文档中出现这些值时，替换为您的域名和子域名。我们常用的一个小技巧是先将此 README 文件下载到您的电脑上，然后将所有的 `mydomain.com` 和 `app.mydomain.com` 替换为您的域名。

除了通常在您的域名注册商界面完成的 DNS 设置之外，下面的所有步骤都需要在您的服务器上完成。命令需要用 `bash`（或任何兼容 bash 的 shell，如 `zsh`）作为 shell 运行。如果您使用其他 shell，如 `fish`，请确保对命令进行适配。

- 一些用于验证配置的实用程序包。通过以下方式安装它们：

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```
## DNS 配置

_详情请参阅[参考文档](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration)_

> **请注意**，DNS 变更可能需要长达 24 小时才能完全生效。实际上，速度要快得多（我们测试中约 1 分钟左右）。在 DNS 设置中，我们通常使用末尾带点号（`.`）的域名以强制使用绝对域名。

您需要设置以下 DNS 记录：

- **A**：将您的域名映射到服务器的 IPv4 地址。
- **AAAA**：将您的域名映射到服务器的 IPv6 地址。
- **MX**：将传入邮件定向到您的邮件服务器（包括 `*` 通配符）。
- **PTR**：将服务器的 IP 地址映射回您的域名。

设置强制性的安全策略：

- **DKIM**：对外发邮件进行数字签名以验证真实性。
- **DMARC**：定义邮件接收方应如何处理未通过身份验证的邮件。
- **SPF**：授权特定邮件服务器从您的域名发送邮件。

额外步骤：

- **CAA**：指定哪些证书颁发机构被允许为您的域名签发 SSL 证书。
- **MTA-STS**：强制邮件服务器之间使用安全的加密连接。
- **TLS-RPT**：报告 TLS 连接失败以提升邮件传输安全。

**警告**：设置 CAA 记录将限制哪些证书颁发机构可以成功为您的域名签发 SSL 证书。
这将阻止 Let’s Encrypt 测试服务器颁发证书。您可能希望将此 DNS 记录延迟到为域名成功签发 SSL 证书之后再添加。

## Docker

如果您的服务器尚未安装 Docker，请按照[Ubuntu 的 Docker CE 安装步骤](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/)进行安装。

您也可以使用 [docker-install](https://github.com/docker/docker-install) 脚本安装 Docker，脚本是


```bash
curl -fsSL https://get.docker.com | sh
```
启用 IPv6 以用于 [默认桥接网络](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)


```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```
本流程将指导您通过 Docker 容器运行整个堆栈。  
这包括：

- traefik  
- [SimpleLogin 应用](https://github.com/simple-login/app) 容器  
- postfix  

通过 Docker 容器运行 SimpleLogin：

1. 在 `/opt/simplelogin` 克隆此仓库  
1. 复制 `.env.example` 为 `.env` 并设置适当的值。

    - 将 `DOMAIN` 变量设置为您的域名。  
    - 将 `SUBDOMAIN` 变量设置为您的子域名。默认值为 `app`。  
    - 将 `POSTGRES_USER` 变量设置为匹配 postgres 凭据（初次启动时使用 `simplelogin`）。  
    - 将 `POSTGRES_PASSWORD` 设置为匹配 postgres 凭据（初次启动时设置为随机密钥）。  
    - 将 `FLASK_SECRET` 设置为任意的密钥。

### Postgres SQL

此仓库在 Docker 容器中运行 postgres SQL。

**警告**：此仓库之前版本运行的是 `12.1` 版本。  
请参考[参考文档](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL)了解更多细节和升级说明。

### 运行应用

使用以下命令运行应用：



```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```
您可能希望此时设置[证书授权机构授权 (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa)。

## 接下来的步骤

如果上述所有步骤都成功，打开 <https://app.mydomain.com/> 并创建您的第一个账户！

默认情况下，新账户不是高级账户，因此没有无限别名。要将您的账户升级为高级账户，
请进入数据库，找到“users”表，将“lifetime”列设置为“1”或“TRUE”：


```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

一旦你创建了所有想要的登录账户，添加以下行到 `.env` 文件以禁用进一步的注册：

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```

然后，要重启 web 应用，执行：`docker compose restart app`

## 杂项

### Postfix 配置 - Spamhaus

Spamhaus 项目维护了一份已知为垃圾邮件源的 IP 地址可靠列表。  
您可以通过向 DNS 基础设施提交查询来检查某个 IP 地址是否在该列表中。

由于 Spamhaus 会阻止来自公共（开放）DNS 解析器的查询（参见：<https://check.spamhaus.org/returnc/pub>），而您的 postfix 容器默认可能使用公共解析器，  
建议注册免费的  
[Spamhaus 数据查询服务](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)  
并获取 Spamhaus DQS 密钥。

将此密钥作为 `SPAMHAUS_DQS_KEY` 粘贴到您的 `.env` 文件中。

如果未提供 DQS 密钥，您的 postfix 容器将检查 Spamhaus 公共镜像是否接受其查询，并改为使用它们。  
如果 Spamhaus 拒绝您的 postfix 容器对公共镜像的查询，则该功能将完全禁用。

### Postfix 配置 - 虚拟别名

postfix 配置支持使用 `postfix/conf.d/virtual` 和 `postfix/conf.d/virtual-regexp` 文件定义虚拟别名。  
这些文件会在启动时根据相应的 [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)  
和 [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl) 模板文件自动生成。

默认配置如下：

#### virtual.tpl

`virtual` 文件支持 postfix 的 `virtual_alias_maps` 设置。  
它包含一条规则，将 `unknown@mydomain.com` 映射到 `contact@mydomain.com`，以演示如何将来自不存在的别名的特定地址的邮件接收并转发到另一个存在的别名。


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

`virtual-regexp` 文件支持后缀 `virtual_alias_maps` 设置。  
它包含一个规则，将发送到任意子域的邮件重写到一个新的别名，该子域不对应  
现有的别名，该别名属于一个目录，其名称取自子域名。  
如果该别名不存在，可以动态创建该别名。

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```
例如，发送到 `someone@directory.mydomain.com` 的电子邮件将由 postfix 路由到 `directory/someone@mydomain.com`。

## 如何从 3.4.0 升级

_本节内容已移至 [参考文档](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## 如何从以前基于 NGinx 的设置升级

_本节内容已移至 [参考文档](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---