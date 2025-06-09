# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` is implemented in `Rust` and supports `http/https` proxy, `socks5` proxy, reverse proxy, load balancing, static file server, `websocket` proxy, layer 4 TCP/UDP forwarding, intranet penetration, etc.

## 📦 Installation & 🏃 Usage

### Installation

```bash
cargo install wmproxy
```

OR

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### Usage
The default port is 8090, and the default listening address is 127.0.0.1
```bash
# Use default parameters directly
wmproxy proxy

# Set username and password
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Other commands
wmproxy --help

# Start with configuration file
wmproxy config -c config/client.toml
```

##### Start a Secondary Proxy
1. Start the proxy locally
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
or
```bash
wmproxy config -c config/client.toml
```
Configuration file as follows:
```toml
[proxy]
# Address of server to connect to
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# Whether to encrypt connection to server
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# Array for intranet mapping configuration

  # Forward the domain name localhost to local 127.0.0.1:8080
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

# Unconditionally forward tcp traffic to 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Because it is pure forwarding, setting username and password at the current node is meaningless. `-S` indicates the address of the secondary proxy to connect to. **If this parameter exists, it is a relay proxy, otherwise it is an endpoint proxy.** ```--ts``` means to use encrypted connection when connecting to the upstream proxy.

2. Start the proxy remotely
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
or
```bash
wmproxy config -c config/server.toml
```
Configuration file as follows:
```toml
[proxy]
# IP address to bind
bind_addr = "127.0.0.1:8091"

# Supported proxy functions: 1 for http, 2 for https, 4 for socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# Intranet mapping http bind address
map_http_bind = "127.0.0.1:8001"
# Intranet mapping tcp bind address
map_tcp_bind = "127.0.0.1:8002"
# Intranet mapping https bind address
map_https_bind = "127.0.0.1:8003"
# Public certificate for intranet mapping, if empty use default certificate
# map_cert = 
# Private certificate for intranet mapping, if empty use default certificate
# map_key =
# Mutual authentication
two_way_tls = true
# Accept encrypted client connections
tc = true
# Current service mode, server for server, client for client
mode = "server"
```

```--tc``` means to accept encrypted connections from downstream proxies, you can specify the certificate public key with ```--cert```, the private key with ```--key```, and the domain name with ```--domain```. If not specified, the built-in certificate parameters will be used by default.
> At this point, through the proxy, we can no longer obtain the real request address, only the request initiated by the proxy.

### Authentication Between Proxies
> Currently, two types of authentication are provided. ```two_way_tls``` enables client certificate authentication, and if the server is configured with ```username``` and ```password```, the client must be configured with the same username and password to enable authentication. Both methods can be used together or separately.
> Add configuration as follows:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Roadmap
### socks5

- [x] IPV6 support
- [x] `SOCKS5` authentication methods
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] `SOCKS5` Commands
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] IPV6 support

### Intranet Penetration

- [x] Http support
- [x] Https support
- [x] Tcp support

### Reverse Proxy

- [x] Static file server
- [x] Passive health check
- [x] Active health check
- [x] Configuration hot reload
- [x] Load balancing
- [x] Layer 4 TCP load balancing
- [x] Layer 4 UDP load balancing
- [x] Traffic control
- [x] websocket forwarding

### Basic Capabilities
- [x] Logging

#### Extended Capabilities

- [x] Request rate limiting (limit_req)
- [x] Modify HTTP request Header
- [x] Support HTTP2 intranet penetration
- [x] Control micro endpoint
- [x] try_paths
- [x] tcp to websocket
- [x] websocket to tcp


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---