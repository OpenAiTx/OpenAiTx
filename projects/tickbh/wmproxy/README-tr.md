# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy`, `Rust` ile geliştirilmiş bir `http/https` proxy, `socks5` proxy, ters proxy, yük dengeleme, statik dosya sunucusu, `websocket` proxy, Layer 4 TCP/UDP yönlendirme, iç ağ geçişi vb. özelliklere sahiptir.

## 📦 Kurulum & 🏃 Kullanım

### Kurulum

```bash
cargo install wmproxy
```

VEYA

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### Kullanım
Varsayılan port 8090'dır, varsayılan dinleme adresi ise 127.0.0.1'dir.
```bash
# Doğrudan varsayılan parametrelerle başlat
wmproxy proxy

# Kullanıcı adı ve şifre ayarla
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Diğer komutlar
wmproxy --help

# Konfigürasyon dosyası ile başlat
wmproxy config -c config/client.toml
```

##### İkincil proxy başlatma
1. Yerelde proxy başlatma
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
veya
```bash
wmproxy config -c config/client.toml
```
Konfigürasyon dosyası aşağıdaki gibidir:
```toml
[proxy]
# Sunucu adresine bağlantı
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# Sunucuya bağlantı şifreli mi
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# İç ağ haritalama yapılandırmasının dizisi

  # localhost alan adını yereldeki 127.0.0.1:8080 adresine yönlendirir
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

# tcp trafiğini koşulsuz olarak 127.0.0.1:8080'e yönlendirir
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Sadece iletim olduğu için, bu düğümde kullanıcı adı ve şifre ayarlamanın anlamı yoktur. `-S` parametresi ile bağlanılan ikincil proxy adresi belirtilir, **bu parametre varsa ara proxy, yoksa uç proxy anlamına gelir.** ```--ts``` parametresi, üst proxy'ye bağlanırken şifreli bağlantı yapılacağını belirtir.

2. Uzaktan proxy başlatma
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
veya
```bash
wmproxy config -c config/server.toml
```
Konfigürasyon dosyası aşağıdaki gibidir:
```toml
[proxy]
# Bağlanacak ip adresi
bind_addr = "127.0.0.1:8091"

# Proxy'nin desteklediği özellikler, 1=http, 2=https, 4=socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# İç ağ haritalama http dinleme adresi
map_http_bind = "127.0.0.1:8001"
# İç ağ haritalama tcp dinleme adresi
map_tcp_bind = "127.0.0.1:8002"
# İç ağ haritalama https dinleme adresi
map_https_bind = "127.0.0.1:8003"
# İç ağ haritalama için genel anahtar sertifikası, boşsa varsayılan sertifika kullanılır
# map_cert = 
# İç ağ haritalama için özel anahtar sertifikası, boşsa varsayılan sertifika kullanılır
# map_key =
# Çift yönlü kimlik doğrulama
two_way_tls = true
# İstemciden gelen bağlantıların şifreli olup olmadığını kontrol et
tc = true
# Mevcut hizmet modu, server: sunucu, client: istemci
mode = "server"
```

```--tc``` parametresi, alt proxy'den gelen bağlantının şifreli olacağını belirtir, ```--cert``` ile sertifika genel anahtarı, ```--key``` ile sertifika özel anahtarı, ```--domain``` ile sertifika alan adı belirtilebilir, eğer belirtilmezse varsayılan sertifika kullanılır.
> Proxy üzerinden erişilen bağlantılarda, gerçek istek adresini göremeyiz, yalnızca proxy'nin başlattığı isteği görebiliriz.

### Proxy'ler Arası Kimlik Doğrulama
> Şu anda iki tip kimlik doğrulama sağlanmaktadır: ```two_way_tls``` etkinleştirildiğinde istemci sertifika doğrulaması açılır, diğerinde ise sunucu tarafında ```username``` ve ```password``` yapılandırıldığında istemcinin de aynı kullanıcı adı ve şifre ile kimlik doğrulaması gerekir. Bu iki yöntem birlikte veya ayrı ayrı kullanılabilir.
> Yapılandırma aşağıdaki gibi eklenir:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Yol Haritası
### socks5

- [x] IPV6 Desteği
- [x] `SOCKS5` Kimlik Doğrulama Yöntemleri
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] `SOCKS5` Komutları
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] IPV6 Desteği

### İç Ağ Geçişi

- [x] Http Desteği
- [x] Https Desteği
- [x] Tcp Desteği

### Ters Proxy

- [x] Statik Dosya Sunucusu
- [x] Pasif Sağlık Kontrolü
- [x] Aktif Sağlık Kontrolü
- [x] Yapılandırma Sıcak Yükleme
- [x] Yük Dengeleme
- [x] Layer 4 TCP Yük Dengeleme
- [x] Layer 4 UDP Yük Dengeleme
- [x] Trafik Kontrolü
- [x] websocket yönlendirme

### Temel Özellikler
- [x] Loglama

#### Genişletilmiş Özellikler

- [x] İstek Hız Sınırı (limit_req)
- [x] HTTP İstek Header Değiştirme
- [x] HTTP2 ile İç Ağ Geçişi Desteği
- [x] Mikro İstemci Kontrolü
- [x] try_paths
- [x] tcp'den websocket'e yönlendirme
- [x] websocket'ten tcp'ye yönlendirme


## Star Geçmişi

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---