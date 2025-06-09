# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` já foi implementado em `Rust` como um proxy `http/https`, proxy `socks5`, proxy reverso, balanceamento de carga, servidor de arquivos estáticos, proxy `websocket`, encaminhamento TCP/UDP em camada 4, penetração de rede interna, entre outros.

## 📦 Instalação & 🏃 Uso

### Instalação

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

### Uso
A porta padrão é 8090 e o endereço de escuta padrão é 127.0.0.1
```bash
# Usar parâmetros padrão diretamente
wmproxy proxy

# Definir usuário e senha
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Outros comandos
wmproxy --help

# Iniciar com arquivo de configuração
wmproxy config -c config/client.toml
```

##### Iniciar proxy secundário
1. Inicie o proxy localmente
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
ou
```bash
wmproxy config -c config/client.toml
```
Exemplo de arquivo de configuração:
```toml
[proxy]
# Endereço do servidor para conexão
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# Encriptar conexão com servidor
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# Array de mapeamentos de rede interna

  # Encaminhar domínio localhost para 127.0.0.1:8080 localmente
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

# Encaminhar tráfego tcp incondicionalmente para 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Como é apenas encaminhamento, definir usuário e senha no nó atual não faz sentido. `-S` indica o endereço do proxy secundário ao qual conectar, **se este parâmetro estiver presente, é um proxy intermediário, caso contrário, é um proxy final.** ```--ts``` indica que a conexão com o proxy pai precisa ser criptografada.

2. Inicie o proxy remotamente
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
ou
```bash
wmproxy config -c config/server.toml
```
Exemplo de arquivo de configuração:
```toml
[proxy]
# Endereço IP para escuta
bind_addr = "127.0.0.1:8091"

# Funcionalidades suportadas pelo proxy: 1 para http, 2 para https, 4 para socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# Endereço de binding para mapeamento http interno
map_http_bind = "127.0.0.1:8001"
# Endereço de binding para mapeamento tcp interno
map_tcp_bind = "127.0.0.1:8002"
# Endereço de binding para mapeamento https interno
map_https_bind = "127.0.0.1:8003"
# Certificado público para mapeamento interno, vazio utiliza padrão
# map_cert = 
# Certificado privado para mapeamento interno, vazio utiliza padrão
# map_key =
# Autenticação mútua
two_way_tls = true
# Aceita cliente criptografado
tc = true
# Modo de serviço: server para servidor, client para cliente
mode = "server"
```

```--tc``` indica que a conexão com o proxy filho precisa ser criptografada, pode-se usar ```--cert``` para especificar o certificado público, ```--key``` para especificar a chave privada, e ```--domain``` para especificar o domínio do certificado. Se não especificado, o certificado padrão será usado.
> A partir deste ponto, ao acessar via proxy, não temos mais como obter o endereço real da solicitação, apenas o endereço enviado pelo proxy.

### Autenticação entre proxies
> Atualmente, são fornecidos dois modos de autenticação: ao ativar ```two_way_tls```, a autenticação de certificado do cliente é habilitada; outra opção é configurar ```username``` e ```password``` no servidor, sendo necessário que o cliente use as mesmas credenciais para autenticar. As duas opções podem ser usadas juntas ou separadamente.
> Exemplo de configuração:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Roteiro
### socks5

- [x] Suporte a IPV6
- [x] Métodos de autenticação `SOCKS5`
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] Comandos `SOCKS5`
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] Suporte a IPV6

### Penetração de rede interna

- [x] Suporte a Http
- [x] Suporte a Https
- [x] Suporte a Tcp

### Proxy reverso

- [x] Servidor de arquivos estáticos
- [x] Verificação passiva de integridade
- [x] Verificação ativa de integridade
- [x] Hot reload de configuração
- [x] Balanceamento de carga
- [x] Balanceamento TCP camada 4
- [x] Balanceamento UDP camada 4
- [x] Controle de tráfego
- [x] Encaminhamento websocket

### Funcionalidades básicas
- [x] Logs

#### Funcionalidades avançadas

- [x] Limite de requisições (limit_req)
- [x] Modificação de headers HTTP
- [x] Suporte a tunelamento HTTP2 para rede interna
- [x] Controle micro
- [x] try_paths
- [x] tcp para websocket
- [x] websocket para tcp


## Histórico de estrelas

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---