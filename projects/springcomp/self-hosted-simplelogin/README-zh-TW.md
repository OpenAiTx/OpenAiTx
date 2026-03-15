
<div align="right">
  <details>
    <summary >🌐 語言</summary>
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

這是一個針對 [SimpleLogin](https://simplelogin.io) 所設計的自我託管 docker-compose 組態。

## 先決條件

- 一台 Linux 伺服器（可以是虛擬機或實體伺服器）。本文件展示了在 Ubuntu 18.04 LTS 的設定，但步驟也可適用於其他主流 Linux 發行版。由於大多數元件皆以 Docker 容器方式運行，且 Docker 可能較為耗資源，建議至少有 2 GB 記憶體。伺服器需開放 25 埠（電子郵件）、80、443（Web 應用程式）、22（供 SSH 登入）等連接埠。

- 一個您可以設定 DNS 的網域名稱，可以是子網域。在本文檔的其餘部分，我們假設電子郵件使用 `mydomain.com`，SimpleLogin 網頁應用程式使用 `app.mydomain.com`。請務必在文件中出現這些值時，將其替換為您的網域名稱和子網域名稱。我們常用的一個小技巧是將此 README 檔案下載到您的電腦上，然後將所有出現的 `mydomain.com` 和 `app.mydomain.com` 替換為您的網域。

除了通常在您的網域註冊商介面上完成的 DNS 設定外，下方所有步驟都需在您的伺服器上執行。這些指令應在 `bash`（或任何相容 bash 的 shell，如 `zsh`）下運行。如果您使用其他 shell，如 `fish`，請務必調整這些指令。

- 一些用於驗證設定的實用套件。請通過以下方式安裝它們：

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## DNS 設定

_請參考 [參考文件](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) 以獲得更多細節_

> **請注意**，DNS 變更可能需要最多 24 小時才會傳播。不過實際上會快很多（我們測試約 1 分鐘）。在 DNS 設定時，我們通常會在網域後加上一個點（`.`）來強制使用絕對網域。

您需要設定以下 DNS 記錄：

- **A**：將您的網域映射到伺服器的 IPv4 位址。
- **AAAA**：將您的網域映射到伺服器的 IPv6 位址。
- **MX**：將來信導向您的郵件伺服器（包含 `*` 萬用字元）。
- **PTR**：將您的伺服器 IP 位址映射回您的網域名稱。

設定必要的安全政策：

- **DKIM**：為外寄郵件進行數位簽章以驗證真實性。
- **DMARC**：定義郵件接收方應如何處理驗證失敗的郵件。
- **SPF**：授權特定郵件伺服器代表您的網域發送郵件。

其他步驟：

- **CAA**：指定哪些憑證授權機構可為您的網域簽發 SSL 憑證。
- **MTA-STS**：強制郵件伺服器間使用安全、加密連線。
- **TLS-RPT**：回報 TLS 連線失敗以提升郵件傳遞安全性。

**警告**：設定 CAA 記錄會限制哪些憑證授權機構可以成功為您的網域簽發 SSL 憑證。
這將阻止 Let’s Encrypt 測試伺服器簽發憑證。您可能要延後設定此 DNS 記錄，直到您的網域憑證成功簽發為止。

## Docker

如果您的伺服器尚未安裝 Docker，請依照 [Ubuntu 的 Docker CE](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) 步驟安裝 Docker。

您也可以使用 [docker-install](https://github.com/docker/docker-install) 腳本安裝 Docker，該腳本

```bash
curl -fsSL https://get.docker.com | sh
```

為[預設橋接網路](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)啟用 IPv6

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```
此程序將引導您使用 Docker 容器運行整個堆疊。
這包括：

- traefik
- [SimpleLogin app](https://github.com/simple-login/app) 容器
- postfix

從 Docker 容器運行 SimpleLogin：

1. 在 `/opt/simplelogin` 目錄下複製此倉庫
1. 將 `.env.example` 複製為 `.env` 並設置適當的值。

    - 將 `DOMAIN` 變數設置為您的網域。
    - 將 `SUBDOMAIN` 變數設置為您的網域。預設值為 `app`。
    - 將 `POSTGRES_USER` 變數設置為與 postgres 資格證書相符（如果從頭開始，使用 `simplelogin`）。
    - 將 `POSTGRES_PASSWORD` 設置為與 postgres 資格證書相符（如果從頭開始，請設為隨機金鑰）。
    - 將 `FLASK_SECRET` 設置為任意祕密金鑰。

### Postgres SQL

此倉庫會在 Docker 容器中運行 postgres SQL。

**警告**：本倉庫舊版本運行 `12.1` 版。
請參考[參考文件](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL)以獲取更多細節及
升級說明。

### 運行應用程式

使用以下指令運行應用程式：


```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

您可能希望在此時設置[憑證授權機構授權（CAA）](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa)。

## 下一步

如果以上所有步驟都成功，請打開 <https://app.mydomain.com/> 並建立您的第一個帳號！

預設情況下，新帳號不是高級帳號，因此沒有無限別名。若要讓您的帳號成為高級帳號，
請進入資料庫，找到 "users" 資料表，並將 "lifetime" 欄位設為 "1" 或 "TRUE"：

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

當您建立完所有所需的登入帳號後，請將以下行加入 `.env`，以禁用後續註冊：

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```
然後，若要重新啟動網頁應用程式，請執行：`docker compose restart app`

## 其他

### Postfix 設定 - Spamhaus

Spamhaus 專案維護一份可靠的 IP 位址清單，這些 IP 已知為垃圾郵件來源。
您可以透過向 DNS 基礎設施提交查詢，檢查指定 IP 位址是否在該清單中。

由於 Spamhaus 會封鎖來自公共（開放）DNS 解析器的查詢（請見：<https://check.spamhaus.org/returnc/pub>），且您的 postfix 容器預設可能會使用
公共解析器，因此建議您註冊免費的
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
並取得 Spamhaus DQS 金鑰。

將此金鑰貼上為 `.env` 中的 `SPAMHAUS_DQS_KEY`

若未提供 DQS 金鑰，您的 postfix 容器將檢查 Spamhaus 公共鏡像是否接受其查詢，並據此使用。
如果 Spamhaus 拒絕來自您的 postfix 容器對公共鏡像的查詢，則該功能將完全停用。

### Postfix 設定 - 虛擬別名

postfix 設定支援使用 `postfix/conf.d/virtual` 和 `postfix/conf.d/virtual-regexp` 檔案進行虛擬別名管理。
這些檔案會根據對應的 [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
與 [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl) 樣板檔案於啟動時自動建立。

預設設定如下：

#### virtual.tpl

`virtual` 檔案支援 postfix 的 `virtual_alias_maps` 設定。
其中包含一條規則，將 `unknown@mydomain.com` 對應至 `contact@mydomain.com`，用以示範接收
來自不存在別名的特定地址的電子郵件並轉發至其他已存在的地址。


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

`virtual-regexp` 檔案支援 postfix `virtual_alias_maps` 設定。
它包含一條規則，會將寄送到任意子網域（但該子網域不存在對應別名）的郵件，重寫至屬於以該子網域命名目錄的新別名。
如果該別名不存在，則可以即時建立此別名。


```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

例如，寄送到 `someone@directory.mydomain.com` 的電子郵件將會由 postfix 轉送到 `directory/someone@mydomain.com`。

## 如何從 3.4.0 升級

_本節內容已移至[參考文件](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## 如何從先前的 NGinx 架構升級

_本節內容已移至[參考文件](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---