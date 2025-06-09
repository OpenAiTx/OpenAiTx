# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` ya ha implementado en `Rust` proxy `http/https`, proxy `socks5`, proxy inverso, balanceo de carga, servidor de archivos estáticos, proxy `websocket`, reenvío TCP/UDP de capa 4, penetración de red interna, entre otros.

## 📦 Instalación & 🏃 Uso

### Instalación

```bash
cargo install wmproxy
```

O

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
El puerto predeterminado es 8090 y la dirección de escucha predeterminada es 127.0.0.1
```bash
# Uso directo con parámetros predeterminados
wmproxy proxy

# Establecer usuario y contraseña
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Otros comandos
wmproxy --help

# Iniciar con archivo de configuración
wmproxy config -c config/client.toml
```

##### Iniciar proxy de segundo nivel
1. Iniciar proxy localmente
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
O bien
```bash
wmproxy config -c config/client.toml
```
El archivo de configuración es el siguiente:
```toml
[proxy]
# Dirección del servidor al que conectarse
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# ¿Encriptar la conexión al servidor?
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# Arreglo de configuración de mapeo de red interna

  # Reenvía el dominio localhost a 127.0.0.1:8080 localmente
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

# Reenvía el tráfico tcp incondicionalmente a 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Como es solo reenvío, no tiene sentido establecer usuario y contraseña en este nodo actual. `-S` indica la dirección del proxy de segundo nivel al que se conecta. **Si este parámetro existe, es un proxy de tránsito; de lo contrario, es un proxy final.** ```--ts``` indica que la conexión al proxy padre debe realizarse de forma cifrada.

2. Iniciar proxy en remoto
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
O bien
```bash
wmproxy config -c config/server.toml
```
El archivo de configuración es el siguiente:
```toml
[proxy]
# Dirección IP a enlazar
bind_addr = "127.0.0.1:8091"

# Funcionalidades soportadas por el proxy, 1 para http, 2 para https, 4 para socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# Dirección de enlace para mapeo http de red interna
map_http_bind = "127.0.0.1:8001"
# Dirección de enlace para mapeo tcp de red interna
map_tcp_bind = "127.0.0.1:8002"
# Dirección de enlace para mapeo https de red interna
map_https_bind = "127.0.0.1:8003"
# Certificado público para mapeo interno, si está vacío se usa el certificado por defecto
# map_cert = 
# Clave privada para mapeo interno, si está vacío se usa la clave por defecto
# map_key =
# Autenticación mutua
two_way_tls = true
# ¿Recibe clientes cifrados?
tc = true
# Modo actual del servicio, server para servidor, client para cliente
mode = "server"
```

```--tc``` indica que se debe usar cifrado al recibir el proxy de nivel inferior, puede usar ```--cert``` para especificar la clave pública del certificado, ```--key``` para especificar la clave privada y ```--domain``` para especificar el dominio del certificado. Si no se especifica, se usan los parámetros de certificado incorporados por defecto.
> Hasta aquí, el acceso a través del proxy ya no puede obtener la dirección real de la solicitud, solo la dirección de la solicitud iniciada por el proxy.

### Autenticación entre proxies
> Actualmente se proporcionan dos métodos de autenticación dual. Si se activa ```two_way_tls``` se requiere autenticación de certificado del cliente. El otro método es configurar ```username``` y ```password``` en el servidor, en cuyo caso el cliente debe configurar el mismo usuario y contraseña para habilitar la autenticación. Ambos métodos se pueden usar juntos o por separado.
> La configuración es la siguiente:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Hoja de ruta
### socks5

- [x] Soporte IPV6
- [x] Métodos de autenticación `SOCKS5`
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] Comandos `SOCKS5`
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] Soporte IPV6

### Penetración de red interna

- [x] Soporte Http
- [x] Soporte Https
- [x] Soporte Tcp

### Proxy inverso

- [x] Servidor de archivos estáticos
- [x] Chequeo de salud pasivo
- [x] Chequeo de salud activo
- [x] Recarga de configuración en caliente
- [x] Balanceo de carga
- [x] Balanceo TCP capa 4
- [x] Balanceo UDP capa 4
- [x] Control de tráfico
- [x] Reenvío websocket

### Capacidades básicas
- [x] Registro (logs)

#### Capacidades extendidas

- [x] Límite de solicitudes (limit_req)
- [x] Modificar cabeceras HTTP
- [x] Soporte de penetración de red interna HTTP2
- [x] Control de micro extremo
- [x] try_paths
- [x] tcp a websocket
- [x] websocket a tcp


## Historial de estrellas

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---