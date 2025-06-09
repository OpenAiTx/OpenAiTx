# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` è stato realizzato in `Rust` e implementa proxy `http/https`, proxy `socks5`, proxy inverso, bilanciamento del carico, server di file statici, proxy `websocket`, inoltro TCP/UDP di livello 4, penetrazione della rete interna e altro.

## 📦 Installazione & 🏃 Utilizzo

### Installazione

```bash
cargo install wmproxy
```

OPPURE

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### Utilizzo
La porta predefinita è la 8090, l'indirizzo di ascolto predefinito è 127.0.0.1
```bash
# Avvio diretto con parametri predefiniti
wmproxy proxy

# Impostare nome utente e password
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Altri comandi
wmproxy --help

#Avvio tramite file di configurazione
wmproxy config -c config/client.toml
```

##### Avvio di un proxy di secondo livello
1. Avvio del proxy in locale
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
oppure
```bash
wmproxy config -c config/client.toml
```
Il file di configurazione è il seguente:
```toml
[proxy]
# Indirizzo del server a cui connettersi
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# Crittografia della connessione al server
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# Array di configurazioni di mapping della rete interna

  #Inoltra il dominio localhost all'indirizzo locale 127.0.0.1:8080
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

#Inoltra incondizionatamente il traffico tcp su 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Poiché si tratta di un semplice inoltro, impostare nome utente e password sul nodo corrente non ha senso. `-S` indica l'indirizzo del proxy di secondo livello a cui connettersi. **Se presente questo parametro, significa che è un proxy di transito, altrimenti è un proxy finale.** ```--ts``` indica che la connessione al proxy padre deve essere crittografata.

2. Avvio del proxy in remoto
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
oppure
```bash
wmproxy config -c config/server.toml
```
Il file di configurazione è il seguente:
```toml
[proxy]
#Indirizzo IP di binding
bind_addr = "127.0.0.1:8091"

#Funzionalità supportate dal proxy, 1 per http, 2 per https, 4 per socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

#Indirizzo di binding per il mapping http della rete interna
map_http_bind = "127.0.0.1:8001"
#Indirizzo di binding per il mapping tcp della rete interna
map_tcp_bind = "127.0.0.1:8002"
#Indirizzo di binding per il mapping https della rete interna
map_https_bind = "127.0.0.1:8003"
#Certificato pubblico per il mapping della rete interna, se vuoto viene usato il certificato di default
# map_cert = 
#Certificato privato per il mapping della rete interna, se vuoto viene usato il certificato di default
# map_key =
# Autenticazione a doppio senso
two_way_tls = true
#Ricevere client crittografati
tc = true
#Modalità servizio corrente, server per server, client per client
mode = "server"
```

```--tc``` indica che quando si ricevono proxy figli la connessione deve essere crittografata, è possibile specificare il certificato pubblico con ```--cert```, la chiave privata con ```--key```, il dominio del certificato con ```--domain```. Se non specificati, verranno utilizzati i certificati di default.
> Da questo punto in poi, quando si accede tramite proxy, non è più possibile ottenere il vero indirizzo della richiesta, ma solo quello generato dal proxy.

### Autenticazione tra proxy
> Attualmente sono disponibili due modalità di autenticazione: abilitando ```two_way_tls``` si attiva l'autenticazione tramite certificato del client; l'altra modalità prevede che sul server siano configurati ```username``` e ```password```, che il client dovrà impostare uguali per abilitare l'autenticazione. Le due modalità possono essere usate insieme o separatamente.
> Esempio di configurazione:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Roadmap
### socks5

- [x] Supporto IPV6
- [x] Metodi di autenticazione `SOCKS5`
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] Comandi `SOCKS5`
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] Supporto IPV6

### Penetrazione della rete interna

- [x] Supporto Http
- [x] Supporto Https
- [x] Supporto Tcp

### Proxy inverso

- [x] Server di file statici
- [x] Health check passivo
- [x] Health check attivo
- [x] Hot reload della configurazione
- [x] Bilanciamento del carico
- [x] Bilanciamento TCP livello 4
- [x] Bilanciamento UDP livello 4
- [x] Controllo del traffico
- [x] Inoltro websocket

### Funzionalità di base
- [x] Log

#### Funzionalità estese

- [x] Limitazione richiesta (limit_req)
- [x] Modifica dell'header delle richieste HTTP
- [x] Supporto penetrazione rete interna HTTP2
- [x] Controllo micro-client
- [x] try_paths
- [x] tcp verso websocket
- [x] websocket verso tcp


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---