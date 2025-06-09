# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy`已用`Rust`實現`http/https`代理、`socks5`代理、反向代理、負載均衡、靜態檔案伺服器、`websocket`代理、四層TCP/UDP轉發、內網穿透等功能

## 📦 安裝 & 🏃 使用

### 安裝

```bash
cargo install wmproxy
```

或

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### 使用
預設端口為8090，預設監聽地址為127.0.0.1
```bash
# 直接使用預設參數
wmproxy proxy

# 設定帳號密碼
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# 其他指令
wmproxy --help

#配置文件方式啟動
wmproxy config -c config/client.toml
```

##### 啟動二級代理
1. 在本地啟動代理
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
或者
```bash
wmproxy config -c config/client.toml
```
配置文件如下:
```toml
[proxy]
# 連接服務端地址
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# 連接服務端是否加密
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# 內網映射配置的數組

  #將localhost的域名轉發到本地的127.0.0.1:8080
[[proxy.mappings]]
name = "web"
mode = "http"
local_addr = "127.0.0.1:8080"
domain = "localhost"

headers = [
  "proxy x-forward-for {client_ip}",
  "proxy + from $url",
  "+ last-modified 'from proxy'",
  "- etag",
]

#將tcp的流量無條件轉到127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

因為純轉發，所以在當前節點設定帳號密碼沒有意義，`-S`表示連接到的二級代理地址，**有該參數則表示是中轉代理，否則是末端代理。**```--ts```表示連接父級代理時需要使用加密方式連接

2. 在遠端啟動代理
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
或者
```bash
wmproxy config -c config/server.toml
```
配置文件如下:
```toml
[proxy]
#綁定的ip地址
bind_addr = "127.0.0.1:8091"

#代理支持的功能，1為http，2為https，4為socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

#內網映射http綁定地址
map_http_bind = "127.0.0.1:8001"
#內網映射tcp綁定地址
map_tcp_bind = "127.0.0.1:8002"
#內網映射https綁定地址
map_https_bind = "127.0.0.1:8003"
#內網映射的公鑰證書，為空則是默認證書
# map_cert = 
#內網映射的私鑰證書，為空則是默認證書
# map_key =
# 雙向認證
two_way_tls = true
#接收客戶端時是否為加密客戶端
tc = true
#當前服務模式，server為服務端，client為客戶端
mode = "server"
```

```--tc```表示接收子級代理時需要用加密方式連接，可以用```--cert```指定證書的公鑰，```--key```指定證書的私鑰，```--domain```指定證書的域名，如果不指定，則預設使用內建證書參數
> 至此，通過代理訪問時，我們已經無法獲得真正的請求地址，只能獲得代理發起的請求

### 代理間的認證
> 目前提供了兩種認證方式，```two_way_tls```開啟客戶端的證書認證資訊，另一種是在服務端配置```username```和```password```，即需要客戶端配置相同的用戶密碼才能啟用認證資訊，兩種方式可疊加使用或單獨使用。
> 配置添加如下：

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 路線圖
### socks5

- [x] IPV6 支援
- [x] `SOCKS5` 驗證方式
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] `SOCKS5` 指令
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] IPV6 支援

### 內網穿透

- [x] Http 支援
- [x] Https 支援
- [x] Tcp 支援

### 反向代理

- [x] 靜態檔案伺服器
- [x] 被動健康檢查
- [x] 主動健康檢查
- [x] 配置熱加載
- [x] 負載均衡
- [x] 四層TCP負載
- [x] 四層UDP負載
- [x] 流量控制
- [x] websocket轉發

### 基礎能力
- [x] 日誌

#### 擴展能力

- [x] 請求限速(limit_req)
- [x] 修改 HTTP 請求 Header
- [x] 支援 HTTP2 的內網穿透
- [x] 控制微端
- [x] try_paths
- [x] tcp轉websocket
- [x] websocket轉tcp


## Star 歷史

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---