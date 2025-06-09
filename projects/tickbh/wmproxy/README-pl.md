# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` został zaimplementowany w `Rust` jako serwer proxy `http/https`, proxy `socks5`, proxy odwrócony, z równoważeniem obciążenia, serwer plików statycznych, proxy `websocket`, przekierowanie TCP/UDP na warstwie czwartej, tunelowanie przez NAT itp.

## 📦 Instalacja & 🏃 Użycie

### Instalacja

```bash
cargo install wmproxy
```

LUB

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### Użycie
Domyślny port to 8090, domyślny adres nasłuchiwania to 127.0.0.1
```bash
# Użyj domyślnych parametrów
wmproxy proxy

# Ustawienie nazwy użytkownika i hasła
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Inne polecenia
wmproxy --help

#Uruchomienie z pliku konfiguracyjnego
wmproxy config -c config/client.toml
```

##### Uruchomienie proxy drugiego poziomu
1. Uruchom proxy lokalnie
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
lub
```bash
wmproxy config -c config/client.toml
```
Plik konfiguracyjny wygląda następująco:
```toml
[proxy]
# Adres serwera do połączenia
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# Szyfrowanie połączenia z serwerem
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# Tablica konfiguracji mapowania sieci lokalnej

  # Przekierowanie domeny localhost na lokalny adres 127.0.0.1:8080
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

# Bezwarunkowe przekierowanie ruchu TCP na 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Ponieważ jest to czyste przekierowanie, ustawienie nazwy użytkownika i hasła na tym węźle nie ma sensu. `-S` oznacza adres proxy drugiego poziomu, **jeśli ten parametr jest obecny, to jest to proxy pośredniczące, w przeciwnym razie jest to proxy końcowe.** ```--ts``` oznacza, że połączenie z nadrzędnym proxy jest szyfrowane.

2. Uruchom proxy zdalnie
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
lub
```bash
wmproxy config -c config/server.toml
```
Plik konfiguracyjny wygląda następująco:
```toml
[proxy]
#Adres IP, na którym wiąże się proxy
bind_addr = "127.0.0.1:8091"

# Obsługiwane funkcje proxy: 1 dla http, 2 dla https, 4 dla socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# Adres wiązania dla mapowania http w sieci lokalnej
map_http_bind = "127.0.0.1:8001"
# Adres wiązania dla mapowania tcp w sieci lokalnej
map_tcp_bind = "127.0.0.1:8002"
# Adres wiązania dla mapowania https w sieci lokalnej
map_https_bind = "127.0.0.1:8003"
# Publiczny certyfikat SSL dla mapowania w sieci lokalnej, jeśli pusty to domyślny certyfikat
# map_cert = 
# Prywatny klucz certyfikatu SSL dla mapowania w sieci lokalnej, jeśli pusty to domyślny certyfikat
# map_key =
# Uwierzytelnianie dwukierunkowe
two_way_tls = true
# Czy przyjmować połączenia szyfrowane od klientów
tc = true
# Aktualny tryb serwera: server dla serwera, client dla klienta
mode = "server"
```

```--tc``` oznacza, że po połączeniu z pod-proxy należy użyć szyfrowania. Można użyć ```--cert``` do wskazania certyfikatu publicznego, ```--key``` do wskazania klucza prywatnego, ```--domain``` do wskazania domeny certyfikatu. Jeżeli nie podano, używany jest domyślny certyfikat.
> W tym momencie, uzyskując dostęp przez proxy, nie mamy już możliwości uzyskania prawdziwego adresu żądania, widzimy tylko żądanie wysłane przez proxy.

### Uwierzytelnianie między proxy
> Obecnie dostępne są dwa tryby uwierzytelniania: ```two_way_tls``` włącza uwierzytelnianie certyfikatu klienta, drugi tryb to konfiguracja ```username``` i ```password``` po stronie serwera, co wymaga identycznych danych po stronie klienta do włączenia uwierzytelniania. Oba tryby można używać razem lub osobno.
> Przykład konfiguracji:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Mapa drogowa
### socks5

- [x] Wsparcie IPV6
- [x] Weryfikacja `SOCKS5`
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] Komendy `SOCKS5`
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] Wsparcie IPV6

### Tunelowanie przez NAT

- [x] Wsparcie Http
- [x] Wsparcie Https
- [x] Wsparcie Tcp

### Proxy odwrócony

- [x] Serwer plików statycznych
- [x] Pasywna kontrola zdrowia
- [x] Aktywna kontrola zdrowia
- [x] Gorące przeładowanie konfiguracji
- [x] Równoważenie obciążenia
- [x] Równoważenie TCP na warstwie czwartej
- [x] Równoważenie UDP na warstwie czwartej
- [x] Kontrola ruchu
- [x] Przekierowanie websocket

### Podstawowe możliwości
- [x] Logi

#### Możliwości rozszerzone

- [x] Ograniczanie żądań (limit_req)
- [x] Modyfikacja nagłówków HTTP żądań
- [x] Wsparcie tunelowania HTTP2 w sieci lokalnej
- [x] Kontrola mikrourządzeń
- [x] try_paths
- [x] TCP na websocket
- [x] websocket na TCP


## Historia gwiazdek

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---