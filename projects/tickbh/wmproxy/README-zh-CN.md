# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` 已用 `Rust` 实现 `http/https` 代理、`socks5` 代理、反向代理、负载均衡、静态文件服务器、`websocket` 代理、四层 TCP/UDP 转发、内网穿透等。

## 📦 安装 & 🏃 使用

### 安装

```bash
cargo install wmproxy
```

或者

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
默认端口为 8090，默认监听地址为 127.0.0.1
```bash
# 直接使用默认参数
wmproxy proxy

# 设置账号密码
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# 其它指令
wmproxy --help

# 配置文件方式启动
wmproxy config -c config/client.toml
```

##### 启动二级代理
1. 在本地启动代理
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
# 连接服务端地址
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# 连接服务端是否加密
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# 内网映射配置的数组

  # 将 localhost 的域名转发到本地的 127.0.0.1:8080
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

# 将 tcp 的流量无条件转到 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

由于为纯转发，所以在当前节点设置账号密码没有意义。`-S` 表示连接到的二级代理地址，**有该参数则表示是中转代理，否则是末端代理。**```--ts``` 表示连接父级代理时需要使用加密方式连接。

2. 在远程启动代理
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
# 绑定的 IP 地址
bind_addr = "127.0.0.1:8091"

# 代理支持的功能，1 为 http，2 为 https，4 为 socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# 内网映射 http 绑定地址
map_http_bind = "127.0.0.1:8001"
# 内网映射 tcp 绑定地址
map_tcp_bind = "127.0.0.1:8002"
# 内网映射 https 绑定地址
map_https_bind = "127.0.0.1:8003"
# 内网映射的公钥证书，为空则为默认证书
# map_cert = 
# 内网映射的私钥证书，为空则为默认证书
# map_key =
# 双向认证
two_way_tls = true
# 接收客户端是否为加密客户端
tc = true
# 当前服务模式，server 为服务端，client 为客户端
mode = "server"
```

```--tc``` 表示接收子级代理时需要使用加密方式连接，可以用 ```--cert``` 指定证书公钥，用 ```--key``` 指定证书私钥，用 ```--domain``` 指定证书域名，如果不指定，则默认使用自带的证书参数。
> 至此通过代理访问时，我们已经无法获取真正的请求地址，只能获得代理发起的请求

### 代理间的认证
> 目前提供了两种认证方式，```two_way_tls``` 开启客户端证书认证信息，另一种是服务端配置 ```username``` 和 ```password```，即需要客户端配置相同的用户密码才能启用认证信息。两种方式可叠加使用，也可单独使用。
> 配置添加如下:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 路线图
### socks5

- [x] IPV6 支持
- [x] `SOCKS5` 验证方式
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] `SOCKS5` 命令
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] IPV6 支持

### 内网穿透

- [x] Http 支持
- [x] Https 支持
- [x] Tcp 支持

### 反向代理

- [x] 静态文件服务器
- [x] 被动健康检查
- [x] 主动健康检查
- [x] 配置热加载
- [x] 负载均衡
- [x] 四层 TCP 负载
- [x] 四层 UDP 负载
- [x] 流量控制
- [x] websocket 转发

### 基础能力
- [x] 日志

#### 扩展能力

- [x] 请求限速（limit_req）
- [x] 修改 HTTP 请求 Header
- [x] 支持 HTTP2 的内网穿透
- [x] 控制微端
- [x] try_paths
- [x] tcp 转 websocket
- [x] websocket 转 tcp


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---