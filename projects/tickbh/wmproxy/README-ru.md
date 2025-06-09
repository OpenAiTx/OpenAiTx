# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` уже реализовал на `Rust` следующие функции: прокси http/https, прокси socks5, обратный прокси, балансировка нагрузки, сервер статических файлов, прокси websocket, пересылка TCP/UDP на 4-м уровне, проброс во внутреннюю сеть и др.

## 📦 Установка & 🏃 Использование

### Установка

```bash
cargo install wmproxy
```

ИЛИ

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### Использование
Порт по умолчанию — 8090, адрес для прослушивания по умолчанию — 127.0.0.1
```bash
# Запуск с параметрами по умолчанию
wmproxy proxy

# Установка логина и пароля
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Другие команды
wmproxy --help

#Запуск с помощью файла конфигурации
wmproxy config -c config/client.toml
```

##### Запуск вторичного прокси
1. Запустите прокси локально
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
или
```bash
wmproxy config -c config/client.toml
```
Файл конфигурации:
```toml
[proxy]
# Адрес подключения к серверу
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# Шифровать ли соединение с сервером
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# Массив настроек проброса во внутреннюю сеть

  #Перенаправить домен localhost на локальный 127.0.0.1:8080
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

#Безусловная пересылка TCP-трафика на 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Поскольку осуществляется только пересылка, установка логина и пароля на этом узле не имеет смысла. `-S` указывает на адрес вторичного прокси, **если этот параметр указан, то это транзитный прокси, иначе — конечный прокси.** ```--ts``` означает, что при подключении к вышестоящему прокси используется шифрование.

2. Запуск прокси на удалённом сервере
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
или
```bash
wmproxy config -c config/server.toml
```
Файл конфигурации:
```toml
[proxy]
# IP-адрес для привязки
bind_addr = "127.0.0.1:8091"

# Поддерживаемые функции прокси: 1 — http, 2 — https, 4 — socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# Адрес привязки http-проброса во внутреннюю сеть
map_http_bind = "127.0.0.1:8001"
# Адрес привязки tcp-проброса во внутреннюю сеть
map_tcp_bind = "127.0.0.1:8002"
# Адрес привязки https-проброса во внутреннюю сеть
map_https_bind = "127.0.0.1:8003"
# Публичный сертификат для проброса, если пусто — используется сертификат по умолчанию
# map_cert = 
# Приватный ключ для проброса, если пусто — используется ключ по умолчанию
# map_key =
# Двусторонняя аутентификация
two_way_tls = true
# Принимать ли клиентов с шифрованием
tc = true
# Режим работы сервиса: server — сервер, client — клиент
mode = "server"
```

```--tc``` означает, что при приёме дочернего прокси используется шифрованное соединение, можно указать публичный сертификат через ```--cert```, приватный ключ через ```--key```, домен сертификата через ```--domain```. Если параметры не заданы, используется встроенный сертификат.
> В этом случае при доступе через прокси мы уже не можем получить реальный адрес запроса, только адрес, с которого прокси отправил запрос.

### Аутентификация между прокси
> В настоящее время реализованы два типа двусторонней аутентификации: если ```two_way_tls``` включен, требуется клиентский сертификат; если на сервере заданы ```username``` и ```password```, клиент должен указать те же данные для прохождения аутентификации. Оба способа можно использовать вместе или по отдельности.
> Пример конфигурации:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Дорожная карта
### socks5

- [x] Поддержка IPV6
- [x] Методы аутентификации `SOCKS5`
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] Команды `SOCKS5`
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] Поддержка IPV6

### Проброс во внутреннюю сеть

- [x] Поддержка Http
- [x] Поддержка Https
- [x] Поддержка Tcp

### Обратный прокси

- [x] Сервер статических файлов
- [x] Пассивная проверка состояния
- [x] Активная проверка состояния
- [x] Горячая перезагрузка конфигурации
- [x] Балансировка нагрузки
- [x] Балансировка TCP на 4 уровне
- [x] Балансировка UDP на 4 уровне
- [x] Контроль трафика
- [x] Пересылка websocket

### Базовые возможности
- [x] Логирование

#### Расширенные возможности

- [x] Ограничение скорости запросов (limit_req)
- [x] Изменение HTTP-заголовков запроса
- [x] Поддержка проброса HTTP2 во внутреннюю сеть
- [x] Управление микроклиентом
- [x] try_paths
- [x] Перевод tcp в websocket
- [x] Перевод websocket в tcp


## История Star

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---