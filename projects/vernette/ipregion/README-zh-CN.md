# ipregion

![image](https://i.imgur.com/CRxBuVR.gif)

## 使用方法

### 下载并本地运行

```bash
wget -O ipregion.sh https://ipregion.vrnt.xyz
chmod +x ipregion.sh
```

### 直接从 GitHub 运行

```bash
bash <(wget -qO- https://ipregion.vrnt.xyz)
```

### Docker

#### 运行 IPv4 容器（默认 Docker 桥接网络）

这将仅使用 IPv4 运行您的 IP 地理位置检查，无需主机网络模式：

```bash
docker run --rm vernette/ipregion:latest
```
您可以根据需要附加额外的脚本选项，例如：


```
docker run --rm vernette/ipregion:latest --group geoip
```

#### 使用主机网络运行容器（适用于 IPv4 和 IPv6 或自定义接口）

要访问主机真实网络接口上的 IPv4 和 IPv6，或指定自定义网络接口（例如 eth1），请使用 Docker 主机网络模式：

```bash
docker run --rm --network=host vernette/ipregion:latest
```

```bash
docker run --rm --network=host vernette/ipregion:latest --interface eth1
```

> [!注意]
> 使用 `--network=host` 时，容器共享主机网络栈，这减少了网络隔离但允许完全访问接口。没有 `--network=host` 时，容器使用 Docker 桥接网络，可能不支持 IPv6 或允许接口选择

## 功能

- 多个 GeoIP API 和网络服务（YouTube、Netflix、ChatGPT、Spotify 等）
- 支持 IPv4/IPv6，带 SOCKS5 代理和自定义网络接口
- JSON 输出和带颜色编码的表格

## 依赖项

- bash
- curl
- jq
- util-linux/bsdmainutils

## 关键选项

```bash
./ipregion.sh --help # Show all options
./ipregion.sh --group primary # GeoIP services only
./ipregion.sh --group custom # Popular websites only
./ipregion.sh --ipv4 # IPv4 only
./ipregion.sh --ipv6 # IPv6 only
./ipregion.sh --proxy 127.0.0.1:1080 # Use SOCKS5 proxy
./ipregion.sh --json # JSON output
./ipregion.sh --debug # Debug mode
```
所有选项均可组合使用。

## 国家代码

脚本输出的国家代码采用 ISO 3166-1 alpha-2 格式（例如，RU、US、DE）。

您可以在官方 ISO 网站查询任何国家代码的含义：[https://www.iso.org/obp/ui/#search/code/](https://www.iso.org/obp/ui/#search/code/)

只需在搜索框中输入代码，即可获得完整的国家名称。

## 贡献

欢迎贡献！欢迎提交拉取请求以添加新服务或改进脚本功能。

![Star History Chart](https://api.star-history.com/svg?repos=vernette/ipregion&type=Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---