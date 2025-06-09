# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` wurde mit `Rust` implementiert und bietet `http/https`-Proxy, `socks5`-Proxy, Reverse Proxy, Lastverteilung, statischen Dateiserver, `websocket`-Proxy, Layer-4 TCP/UDP-Weiterleitung, Intranet-Penetration usw.

## 📦 Installation & 🏃 Verwendung

### Installation

```bash
cargo install wmproxy
```

ODER

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### Verwendung
Der Standardport ist 8090, die Standard-Listenadresse ist 127.0.0.1
```bash
# Direkt mit Standardparametern starten
wmproxy proxy

# Benutzername und Passwort setzen
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Weitere Befehle
wmproxy --help

#Start mit Konfigurationsdatei
wmproxy config -c config/client.toml
```

##### Start eines Sekundär-Proxys
1. Proxy lokal starten
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
oder
```bash
wmproxy config -c config/client.toml
```
Die Konfigurationsdatei sieht wie folgt aus:
```toml
[proxy]
# Adresse des Servers
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# Verschlüsselung bei Verbindung zum Server
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# Array von Intranet-Mapping-Konfigurationen

  #Leitet die Domain localhost an 127.0.0.1:8080 weiter
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

#Leitet TCP-Verkehr bedingungslos an 127.0.0.1:8080 weiter
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Da es sich um reine Weiterleitung handelt, ist das Setzen von Benutzername und Passwort am aktuellen Knotenpunkt sinnlos. `-S` gibt die Adresse des Sekundär-Proxys an, **ist dieser Parameter gesetzt, handelt es sich um einen Weiterleitungsproxy, andernfalls um einen Endpunkt-Proxy.** ```--ts``` bedeutet, dass die Verbindung zum übergeordneten Proxy verschlüsselt erfolgt.

2. Proxy auf dem Remote-Server starten
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
oder
```bash
wmproxy config -c config/server.toml
```
Die Konfigurationsdatei sieht wie folgt aus:
```toml
[proxy]
#Gebundene IP-Adresse
bind_addr = "127.0.0.1:8091"

#Unterstützte Proxy-Funktionen, 1 für http, 2 für https, 4 für socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

#Bind-Adresse für http-Intranet-Mapping
map_http_bind = "127.0.0.1:8001"
#Bind-Adresse für tcp-Intranet-Mapping
map_tcp_bind = "127.0.0.1:8002"
#Bind-Adresse für https-Intranet-Mapping
map_https_bind = "127.0.0.1:8003"
# Öffentliches Zertifikat für Intranet-Mapping, leer = Standardzertifikat
# map_cert = 
# Privater Zertifikatsschlüssel für Intranet-Mapping, leer = Standardzertifikat
# map_key =
# Zwei-Wege-Authentifizierung
two_way_tls = true
# Ob der Client verschlüsselt ist
tc = true
#Aktueller Servicemodus, server = Server, client = Client
mode = "server"
```

```--tc``` bedeutet, dass eingehende Verbindungen von Child-Proxys verschlüsselt erfolgen müssen. Mit ```--cert``` kann der öffentliche Schlüssel des Zertifikats angegeben werden, mit ```--key``` der private Schlüssel und mit ```--domain``` der Domainname des Zertifikats. Wird nichts angegeben, wird das mitgelieferte Standardzertifikat verwendet.
> Ab diesem Punkt ist es über den Proxy nicht mehr möglich, die tatsächliche Zieladresse der Anfrage zu erhalten, sondern nur die vom Proxy gestellte Anfrage.

### Authentifizierung zwischen Proxys
> Es gibt derzeit zwei Authentifizierungsmethoden: Mit ```two_way_tls``` wird die Client-Zertifikatsauthentifizierung aktiviert. Bei Angabe von ```username``` und ```password``` auf dem Server muss der Client dieselben Zugangsdaten verwenden, um sich zu authentifizieren. Beide Methoden können kombiniert oder einzeln genutzt werden.
> Beispielkonfiguration:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Roadmap
### socks5

- [x] IPV6-Unterstützung
- [x] `SOCKS5` Authentifizierungsmethoden
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] `SOCKS5` Befehle
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] IPV6-Unterstützung

### Intranet-Penetration

- [x] Http-Unterstützung
- [x] Https-Unterstützung
- [x] Tcp-Unterstützung

### Reverse Proxy

- [x] Statischer Dateiserver
- [x] Passive Health-Checks
- [x] Aktive Health-Checks
- [x] Hot-Reload der Konfiguration
- [x] Lastverteilung
- [x] Layer-4-TCP-Loadbalancing
- [x] Layer-4-UDP-Loadbalancing
- [x] Traffic Control
- [x] Websocket-Weiterleitung

### Basisfunktionen
- [x] Logging

#### Erweiterte Funktionen

- [x] Anfragelimitierung (limit_req)
- [x] Ändern von HTTP Request Headern
- [x] Unterstützung für HTTP2-Intranet-Penetration
- [x] Micro-Client-Steuerung
- [x] try_paths
- [x] TCP zu Websocket
- [x] Websocket zu TCP


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---