# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` is geïmplementeerd in `Rust` als een `http/https` proxy, `socks5` proxy, reverse proxy, load balancer, statische bestanden server, `websocket` proxy, layer 4 TCP/UDP forwarding, NAT traversal, enz.

## 📦 Installatie & 🏃 Gebruik

### Installatie

```bash
cargo install wmproxy
```

OF

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### Gebruik
De standaardpoort is 8090, het standaard luisteradres is 127.0.0.1
```bash
# Direct standaardparameters gebruiken
wmproxy proxy

# Stel gebruikersnaam en wachtwoord in
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Andere commando's
wmproxy --help

#Starten met configuratiebestand
wmproxy config -c config/client.toml
```

##### Starten van een secundaire proxy
1. Start de proxy lokaal
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
of
```bash
wmproxy config -c config/client.toml
```
Configuratiebestand als volgt:
```toml
[proxy]
# Adres van de server om te verbinden
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# Encryptie bij verbinden met de server
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# Array van NAT mapping configuraties

  #Stuur domeinnaam localhost door naar lokaal 127.0.0.1:8080
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

#Stuur alle TCP-verkeer zonder voorwaarden door naar 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Omdat het puur forwarding betreft, heeft het instellen van gebruikersnaam/wachtwoord op deze node geen zin. `-S` geeft het adres van de secundaire proxy aan, **als deze parameter is opgegeven, is het een doorstuurproxy, anders een eindproxy.** ```--ts``` geeft aan dat de verbinding met de bovenliggende proxy versleuteld moet zijn.

2. Start de proxy op afstand
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
of
```bash
wmproxy config -c config/server.toml
```
Configuratiebestand als volgt:
```toml
[proxy]
#Gebonden IP-adres
bind_addr = "127.0.0.1:8091"

#Ondersteunde proxy functies, 1 voor http, 2 voor https, 4 voor socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

#HTTP NAT mapping bind adres
map_http_bind = "127.0.0.1:8001"
#TCP NAT mapping bind adres
map_tcp_bind = "127.0.0.1:8002"
#HTTPS NAT mapping bind adres
map_https_bind = "127.0.0.1:8003"
#NAT mapping publieke certificaat, leeg is standaard certificaat
# map_cert = 
#NAT mapping private sleutel, leeg is standaard certificaat
# map_key =
# Two-way authenticatie
two_way_tls = true
#Ontvangen van versleutelde clients
tc = true
#Huidige servicemodus, server is server, client is client
mode = "server"
```

```--tc``` betekent dat versleutelde verbindingen van child proxies worden geaccepteerd. Je kunt met ```--cert``` het publieke certificaat specificeren, met ```--key``` de privésleutel, met ```--domain``` het domein van het certificaat. Indien niet opgegeven, wordt het standaard certificaat gebruikt.
> Vanaf nu is het niet meer mogelijk het echte aanvraagadres te krijgen via de proxy, alleen het door de proxy gestarte verzoek is zichtbaar.

### Authenticatie tussen proxies
> Momenteel zijn er twee authenticatiemethoden beschikbaar: ```two_way_tls``` schakelt clientcertificaat-authenticatie in, de andere is gebruikersnaam/wachtwoord in de serverconfiguratie (```username``` en ```password```) waarvoor de client dezelfde gegevens moet configureren. Beide methodes kunnen gecombineerd of afzonderlijk gebruikt worden.
> Toevoegen aan configuratie als volgt:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Roadmap
### socks5

- [x] IPV6 ondersteuning
- [x] `SOCKS5` authenticatiemethoden
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] `SOCKS5` Commando's
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] IPV6 ondersteuning

### NAT traversal

- [x] Http ondersteuning
- [x] Https ondersteuning
- [x] Tcp ondersteuning

### Reverse proxy

- [x] Statische bestanden server
- [x] Passieve health checks
- [x] Actieve health checks
- [x] Hot-reload van configuratie
- [x] Load balancing
- [x] Layer 4 TCP load balancing
- [x] Layer 4 UDP load balancing
- [x] Verkeerscontrole
- [x] websocket forwarding

### Basisfunctionaliteit
- [x] Logging

#### Uitbreidingsmogelijkheden

- [x] Verzoek-limiet (limit_req)
- [x] HTTP request headers aanpassen
- [x] Ondersteuning voor HTTP2 NAT traversal
- [x] Micro-agent beheer
- [x] try_paths
- [x] tcp naar websocket
- [x] websocket naar tcp


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---