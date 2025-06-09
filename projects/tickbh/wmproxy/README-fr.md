# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` est un proxy `http/https`, proxy `socks5`, proxy inverse, équilibrage de charge, serveur de fichiers statiques, proxy `websocket`, transfert TCP/UDP niveau 4, pénétration de réseau interne, etc., tous réalisés en `Rust`.

## 📦 Installation & 🏃 Utilisation

### Installation

```bash
cargo install wmproxy
```

OU

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### Utilisation
Le port par défaut est 8090 et l'adresse d'écoute par défaut est 127.0.0.1.
```bash
# Utiliser directement les paramètres par défaut
wmproxy proxy

# Définir un nom d'utilisateur et un mot de passe
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Autres commandes
wmproxy --help

# Démarrage via fichier de configuration
wmproxy config -c config/client.toml
```

##### Démarrer un proxy de second niveau
1. Démarrer le proxy en local
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
ou
```bash
wmproxy config -c config/client.toml
```
Le fichier de configuration est le suivant :
```toml
[proxy]
# Adresse du serveur à connecter
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# Chiffrement lors de la connexion au serveur
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# Tableau de configuration de mapping réseau interne

  # Rediriger le domaine localhost vers 127.0.0.1:8080 en local
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

# Rediriger tout le trafic tcp vers 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Étant donné qu'il s'agit d'un simple transfert, il n'est pas utile de définir un nom d'utilisateur et un mot de passe sur ce nœud. `-S` indique l'adresse du proxy de second niveau auquel se connecter. **La présence de ce paramètre signifie qu'il s'agit d'un proxy relais, sinon c'est un proxy final.** ```--ts``` signifie que la connexion au proxy parent doit être chiffrée.

2. Démarrer le proxy à distance
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
ou
```bash
wmproxy config -c config/server.toml
```
Le fichier de configuration est le suivant :
```toml
[proxy]
# Adresse IP à lier
bind_addr = "127.0.0.1:8091"

# Fonctions supportées par le proxy : 1=http, 2=https, 4=socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# Adresse de liaison pour le mapping http interne
map_http_bind = "127.0.0.1:8001"
# Adresse de liaison pour le mapping tcp interne
map_tcp_bind = "127.0.0.1:8002"
# Adresse de liaison pour le mapping https interne
map_https_bind = "127.0.0.1:8003"
# Certificat public pour le mapping interne, si vide utilise le certificat par défaut
# map_cert = 
# Clé privée pour le mapping interne, si vide utilise le certificat par défaut
# map_key =
# Authentification mutuelle
two_way_tls = true
# Accepter la connexion chiffrée des clients
tc = true
# Mode du service, server=serveur, client=client
mode = "server"
```

```--tc``` signifie que la connexion des proxys enfants doit être chiffrée ; vous pouvez utiliser ```--cert``` pour spécifier la clé publique du certificat, ```--key``` pour spécifier la clé privée, et ```--domain``` pour spécifier le domaine du certificat. Si non spécifié, le certificat intégré sera utilisé par défaut.
> À ce stade, l'adresse réelle de la requête n'est plus disponible via le proxy, seule l'adresse initiée par le proxy peut être obtenue.

### Authentification entre proxys
> Actuellement, deux méthodes d'authentification sont proposées : ```two_way_tls``` active l'authentification par certificat côté client, et la configuration côté serveur de ```username``` et ```password``` nécessite la même configuration côté client pour activer l'authentification. Les deux méthodes peuvent être utilisées ensemble ou séparément.
> Ajoutez la configuration comme suit :

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Roadmap
### socks5

- [x] Support IPV6
- [x] Méthodes d'authentification `SOCKS5`
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] Commandes `SOCKS5`
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] Support IPV6

### Pénétration de réseau interne

- [x] Support Http
- [x] Support Https
- [x] Support Tcp

### Proxy inverse

- [x] Serveur de fichiers statiques
- [x] Vérification de santé passive
- [x] Vérification de santé active
- [x] Rechargement à chaud de la configuration
- [x] Équilibrage de charge
- [x] Équilibrage TCP niveau 4
- [x] Équilibrage UDP niveau 4
- [x] Contrôle du trafic
- [x] Transfert websocket

### Capacités de base
- [x] Logs

#### Capacités étendues

- [x] Limitation de débit des requêtes (limit_req)
- [x] Modification des en-têtes HTTP
- [x] Prise en charge de la pénétration HTTP2 dans le réseau interne
- [x] Micro-agent de contrôle
- [x] try_paths
- [x] tcp vers websocket
- [x] websocket vers tcp


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---