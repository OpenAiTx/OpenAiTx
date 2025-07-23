
# acme-tiny

[![测试](https://github.com/diafygi/acme-tiny/actions/workflows/full-tests-with-coverage.yml/badge.svg?branch=main)](https://github.com/diafygi/acme-tiny/actions/workflows/full-tests-with-coverage.yml)
[![覆盖率状态](https://coveralls.io/repos/github/diafygi/acme-tiny/badge.svg?branch=main)](https://coveralls.io/github/diafygi/acme-tiny?branch=main)

这是一个非常小且可审计的脚本，你可以将其放到服务器上用来签发
和续订 [Let's Encrypt](https://letsencrypt.org/) 证书。由于它必须
在你的服务器上运行并访问你的私有 Let's Encrypt 账户密钥，
我尽量让它尽可能小（目前不到 200 行）。唯一的前提条件是安装 python 和 openssl。

**请务必阅读源代码！你必须信任它使用你的私有账户密钥！**

## 捐赠

如果这个脚本对你有用，请向 EFF 捐赠。我不在那工作，
但他们做的工作非常出色。

[https://eff.org/donate/](https://eff.org/donate/)

## 如何使用这个脚本

如果你已经有一个由 Let's Encrypt 签发的证书，只想续订，
你只需执行步骤 3 和步骤 6。

### 第1步：创建一个 Let's Encrypt 账户私钥（如果你还没有）

你必须有一个注册到 Let's Encrypt 的公钥，并用对应的私钥
对你的请求进行签名。如果你不理解我刚才说的内容，
这个脚本可能不适合你！请使用官方的 Let's Encrypt
[客户端](https://github.com/letsencrypt/letsencrypt)。
为此，你需要最初创建一个密钥，acme-tiny 可以使用该密钥
为你注册账户并签署所有后续请求。



```
openssl genrsa 4096 > account.key
```
#### 使用现有的 Let's Encrypt 密钥

或者你可以转换之前由原始
Let's Encrypt 客户端生成的密钥。

Let's Encrypt 客户端的私有账户密钥以
[JWK](https://tools.ietf.org/html/rfc7517) 格式保存。`acme-tiny` 使用的是 PEM
密钥格式。要转换密钥，你可以使用 JonLundy 的工具
[转换脚本](https://gist.github.com/JonLundy/f25c99ee0770e19dc595)：


```sh
# Download the script
wget -O - "https://gist.githubusercontent.com/JonLundy/f25c99ee0770e19dc595/raw/6035c1c8938fae85810de6aad1ecf6e2db663e26/conv.py" > conv.py

# Copy your private key to your working directory
cp /etc/letsencrypt/accounts/acme-v01.api.letsencrypt.org/directory/<id>/private_key.json private_key.json

# Create a DER encoded private key
openssl asn1parse -noout -out private_key.der -genconf <(python2 conv.py private_key.json)

# Convert to PEM
openssl rsa -in private_key.der -inform der > account.key
```
### 第2步：为您的域创建证书签名请求（CSR）。

ACME协议（Let's Encrypt使用的协议）要求提交CSR文件，
即使是续订也需要。您可以为多次续订使用相同的CSR。注意：
您不能将您的账户私钥用作域的私钥！


```
# Generate a domain private key (if you haven't already)
openssl genrsa 4096 > domain.key
```

```
# For a single domain
openssl req -new -sha256 -key domain.key -subj "/CN=yoursite.com" > domain.csr

# For multiple domains (use this one if you want both www.yoursite.com and yoursite.com)
openssl req -new -sha256 -key domain.key -subj "/" -addext "subjectAltName = DNS:yoursite.com, DNS:www.yoursite.com" > domain.csr

# For multiple domains (same as above but works with openssl < 1.1.1)
openssl req -new -sha256 -key domain.key -subj "/" -reqexts SAN -config <(cat /etc/ssl/openssl.cnf <(printf "[SAN]\nsubjectAltName=DNS:yoursite.com,DNS:www.yoursite.com")) > domain.csr
```
### 第3步：让您的网站托管挑战文件

您必须证明您拥有想要申请证书的域名，因此Let's Encrypt
要求您在这些域名上托管一些文件。该脚本将生成并写入这些
文件到您指定的文件夹中，因此您只需确保该
文件夹在“.well-known/acme-challenge/”的URL路径下被访问。注意：Let's
Encrypt会对您的服务器80端口执行普通的HTTP请求，所以您
必须通过HTTP提供挑战文件（重定向到HTTPS也可以）。


```
# Make some challenge folder (modify to suit your needs)
mkdir -p /var/www/challenges/
```

```nginx
# Example for nginx
server {
    listen 80;
    server_name yoursite.com www.yoursite.com;

    location /.well-known/acme-challenge/ {
        alias /var/www/challenges/;
        try_files $uri =404;
    }

    ...the rest of your config
}
```
### 第4步：获取签名证书！

现在您已经设置好服务器并生成了所有必要的文件，运行此
脚本于您的服务器上，确保具有写入上述文件夹以及读取您的私有账户密钥和CSR的权限。



```
# Run the script on your server
python acme_tiny.py --account-key ./account.key --csr ./domain.csr --acme-dir /var/www/challenges/ > ./signed_chain.crt
```


### 第5步：安装证书

此脚本输出的已签名https证书链可与您的私钥一起使用，
以运行https服务器。您需要将它们包含在
您的网页服务器配置中的https设置中。以下是
配置nginx服务器的示例：


```nginx
server {
    listen 443 ssl;
    server_name yoursite.com www.yoursite.com;

    ssl_certificate /path/to/signed_chain.crt;
    ssl_certificate_key /path/to/domain.key;
    ssl_session_timeout 5m;
    ssl_protocols TLSv1.2;
    ssl_ciphers ECDHE-RSA-AES256-GCM-SHA384:ECDHE-RSA-AES128-GCM-SHA256:DHE-RSA-AES256-GCM-SHA384;
    ssl_session_cache shared:SSL:50m;
    ssl_dhparam /path/to/server.dhparam;
    ssl_prefer_server_ciphers on;

    ...the rest of your config
}

server {
    listen 80;
    server_name yoursite.com www.yoursite.com;

    location /.well-known/acme-challenge/ {
        alias /var/www/challenges/;
        try_files $uri =404;
    }

    ...the rest of your config
}
```


### 步骤6：设置自动续期的定时任务

恭喜！您的网站现在已使用https！不幸的是，Let's Encrypt
证书仅有效90天，因此您需要经常续期。别担心！
这已自动化！只需制作一个bash脚本并将其添加到crontab中（下面
有示例脚本）。

`renew_cert.sh`示例：

```sh
#!/usr/bin/sh
python /path/to/acme_tiny.py --account-key /path/to/account.key --csr /path/to/domain.csr --acme-dir /var/www/challenges/ > /path/to/signed_chain.crt.tmp || exit
mv /path/to/signed_chain.crt.tmp /path/to/signed_chain.crt
service nginx reload
```

```
# Example line in your crontab (runs once per month)
0 0 1 * * /path/to/renew_cert.sh 2>> /var/log/acme_tiny.log
```
**注意：**自 Let's Encrypt 发布 ACME v2（acme-tiny 4.0.0+）以来，中间证书已包含在颁发的证书下载中，
因此您不再需要单独下载中间证书并将其与您的签名证书连接起来。如果您有一个使用 acme-tiny &lt;4.0（例如
2018-03-17 之前）的 shell 脚本或 Makefile，但使用了 acme-tiny 4.0.0+，那么您可能会将中间
证书添加到您的 signed_chain.crt 两次（这不仅
[导致至少 GnuTLS 3.7.0 出现问题](https://gitlab.com/gnutls/gnutls/-/issues/1131)，
还会使证书体积比实际需要的大）。要修复此问题，只需删除下载中间证书并将其添加
到 acme-tiny 证书输出的 bash 代码即可。

## 权限

在设置和运行此脚本时，您最可能遇到的最大问题是权限。您需要尽可能限制对账户私钥和
挑战网页文件夹的访问。我建议创建一个专门处理此脚本、账户私钥和
挑战文件夹的用户。然后赋予该用户写入您已安装
证书文件（例如 `/path/to/signed_chain.crt`）的权限，并能重新加载您的 Web 服务器。这样，
cron 脚本就可以完成它的工作，覆盖旧证书，并
重新加载 Web 服务器，而不会有执行其他操作的权限。

**务必确保：**
* 备份您的账户私钥（例如 `account.key`）
* 不要让此脚本能够读取您的域私钥！
* 不要以 root 身份运行此脚本！

## 测试环境

Let's Encrypt 建议针对其测试服务器测试新的配置，
因此在测试您的新设置时，您可以使用
`--directory-url https://acme-staging-v02.api.letsencrypt.org/directory`
来颁发假测试证书，而不是从 Let's Encrypt 的生产服务器颁发真实证书。
详情请参见 [https://letsencrypt.org/docs/staging-environment/](https://letsencrypt.org/docs/staging-environment/)。

## 反馈/贡献

本项目的范围和代码库非常有限。我很乐意接受
错误报告和拉取请求，但请不要添加任何新功能。此
脚本必须保持在 200 行代码以内，以确保任何想运行它的人都能轻松审核。

如果您想为自己的设置添加功能以简化操作，
请随意！这是开源的，您可以自由地 fork 并根据需要修改。










---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---