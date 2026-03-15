
<div align="right">
  <details>
    <summary >🌐 Language</summary>
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

This is a self-hosted docker-compose configuration for [SimpleLogin](https://simplelogin.io).

## Prerequisites

- a Linux server (either a VM or dedicated server). This doc shows the setup for Ubuntu 18.04 LTS but the steps could be adapted for other popular Linux distributions. As most of components run as Docker container and Docker can be a bit heavy, having at least 2 GB of RAM is recommended. The server needs to have the port 25 (email), 80, 443 (for the webapp), 22 (so you can ssh into it) open.

- a domain for which you can config the DNS. It could be a sub-domain. In the rest of the doc, let's say it's `mydomain.com` for the email and `app.mydomain.com` for SimpleLogin webapp. Please make sure to replace these values by your domain name and subdomain name whenever they appear in the doc. A trick we use is to download this README file on your computer and replace all `mydomain.com` and `app.mydomain.com` occurrences by your domain.

Except for the DNS setup that is usually done on your domain registrar interface, all the below steps are to be done on your server. The commands are to run with `bash` (or any bash-compatible shell like `zsh`) being the shell. If you use other shells like `fish`, please make sure to adapt the commands.

- Some utility packages used to verify the setup. Install them by:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## DNS Configuration

_Refer to the [reference documentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) for more details_

> **Please note** that DNS changes could take up to 24 hours to propagate. In practice, it's a lot faster though (~1 minute or so in our test). In DNS setup, we usually use domain with a trailing dot (`.`) at the end to to force using absolute domain.

You will need to setup the following DNS records:

- **A**: Maps your domain to your server's IPv4 address.
- **AAAA**: Maps your domain to your server's IPv6 address.
- **MX**: Directs incoming emails to your mail server (including `*` wildcards).
- **PTR**: Maps your server's IP address back to your domain name.

Set up mandatory security policies:

- **DKIM**: Digitally signs outgoing emails to verify authenticity.
- **DMARC**: Defines how email receivers should handle messages failing authentication.
- **SPF**: Authorizes specific mail servers to send emails from your domain.

Additional steps:

- **CAA**: Specifies which certificate authorities are allowed to issue SSL certificates for your domain.
- **MTA-STS**: Enforces secure, encrypted connections between mail servers.
- **TLS-RPT**: Reports TLS connection failures to improve email delivery security.

**Warning**: setting up a CAA record will restrict which certificate authority can successfully issue SSL certificates for your domain.
This will prevent certificate issuance from Let’s Encrypt staging servers. You may want to differ this DNS record until after SSL certificates are successfully issued for your domain.

## Docker

If you don't already have Docker installed on your server, please follow the steps on [Docker CE for Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) to install Docker.

You can also install Docker using the [docker-install](https://github.com/docker/docker-install) script which is

```bash
curl -fsSL https://get.docker.com | sh
```

Enable IPv6 for [the default bridge network](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```

This procedure will guide you through running the entire stack using Docker containers.
This includes:

- traefik
- The [SimpleLogin app](https://github.com/simple-login/app) containers
- postfix

Run SimpleLogin from Docker containers:

1. Clone this repository in `/opt/simplelogin`
1. Copy `.env.example` to `.env` and set appropriate values.

    - set the `DOMAIN` variable to your domain.
    - set the `SUBDOMAIN` variable to your domain. The default value is `app`.
    - set the `POSTGRES_USER` variable to match the postgres credentials (when starting from scratch, use `simplelogin`).
    - set the `POSTGRES_PASSWORD` to match the postgres credentials (when starting from scratch, set to a random key).
    - set the `FLASK_SECRET` to an arbitrary secret key.

### Postgres SQL

This repository runs a postgres SQL in a Docker container.

**Warning**: previous versions of this repository ran version `12.1`.
Please, refer to the [reference documentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) for more details and
upgrade instructions.

### Running the application

Run the application using the following commands:

```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

You may want to setup [Certificate Authority Authorization (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) at this point.

## Next steps

If all the above steps are successful, open <https://app.mydomain.com/> and create your first account!

By default, new accounts are not premium so don't have unlimited aliases. To make your account premium,
please go to the database, table "users" and set "lifetime" column to "1" or "TRUE":

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

Once you've created all your desired login accounts, add these lines to `.env` to disable further registrations:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```

Then, to restart the web app, apply: `docker compose restart app`

## Miscellaneous

### Postfix configuration - Spamhaus

The Spamhaus Project maintains a reliable list of IP addresses known to be the source of SPAM.
You can check whether a given IP address is in that list by submitting queries to the DNS infrastructure.

Since Spamhaus blocks queries coming from public (open) DNS-Resolvers (see: <https://check.spamhaus.org/returnc/pub>) and your postfix container may use
a public resolver by default, it is recommended to sign up for the free
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
and obtain a Spamhaus DQS key.

Paste this key as `SPAMHAUS_DQS_KEY` in your `.env`

If no DQS-key is provided, your postfix container will check if the Spamhaus public mirrors are accepting its queries and use them instead.
If Spamhaus rejects queries from your postfix container to the public mirrors, it will be disabled entirely.

### Postfix configuration - Virtual aliases

The postfix configuration supports virtual aliases using the `postfix/conf.d/virtual` and `postfix/conf.d/virtual-regexp` files.
Those files are automatically created on startup based upon the corresponding [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
and [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl) template files.

The default configuration is as follows:

#### virtual.tpl

The `virtual` file supports postfix `virtual_alias_maps` settings.
It includes a rule that maps `unknown@mydomain.com` to `contact@mydomain.com` to demonstrate receiving
and email from a specific address that does not correspond to an existing alias, to another one that does.

```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

The `virtual-regexp` file supports postfix `virtual_alias_maps` settings.
It includes a rule that rewrite emails addressed to an arbitrary subdomain, which does not correspond
to an existing alias, to a new alias that belongs to a directory whose name is taken from the subdomain.
That alias may be created on the fly if it does not exist.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

For instance, emails sent to `someone@directory.mydomain.com` will be routed to `directory/someone@mydomain.com` by postfix.

## How-to Upgrade from 3.4.0

_This section has been moved to the [reference documentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## How-to Upgrade from previous NGinx-based setup

_This section has been moved to the [reference documentation](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_
