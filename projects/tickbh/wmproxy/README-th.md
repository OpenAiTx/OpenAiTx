# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` ได้ถูกพัฒนาโดยใช้ภาษา `Rust` รองรับการเป็นพร็อกซี `http/https`, พร็อกซี `socks5`, พร็อกซีแบบย้อนกลับ, โหลดบาลานซ์, เซิร์ฟเวอร์ไฟล์สถิต, พร็อกซี `websocket`, การส่งต่อ TCP/UDP ชั้นที่สี่, ทะลุผ่านเครือข่ายภายใน และอื่นๆ

## 📦 การติดตั้ง & 🏃 การใช้งาน

### การติดตั้ง

```bash
cargo install wmproxy
```

หรือ

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### การใช้งาน
พอร์ตเริ่มต้นคือ 8090 และที่อยู่เริ่มต้นคือ 127.0.0.1
```bash
# ใช้ค่าพารามิเตอร์เริ่มต้น
wmproxy proxy

# ตั้งค่าชื่อผู้ใช้และรหัสผ่าน
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# คำสั่งอื่นๆ
wmproxy --help

# เริ่มต้นด้วยไฟล์คอนฟิก
wmproxy config -c config/client.toml
```

##### การเริ่มต้นพร็อกซีระดับสอง
1. เริ่มต้นพร็อกซีที่เครื่อง local
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
หรือ
```bash
wmproxy config -c config/client.toml
```
ไฟล์คอนฟิกตัวอย่าง:
```toml
[proxy]
# ที่อยู่ของเซิร์ฟเวอร์ที่ต้องการเชื่อมต่อ
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# เชื่อมต่อกับเซิร์ฟเวอร์ด้วยการเข้ารหัสหรือไม่
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# อาเรย์ของการตั้งค่าแมปปิ้งภายในเครือข่าย

  # ส่งต่อโดเมน localhost ไปยัง 127.0.0.1:8080 ในเครื่อง local
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

# ส่งต่อทราฟฟิก tcp ทั้งหมดไปที่ 127.0.0.1:8080 โดยไม่มีเงื่อนไข
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

เนื่องจากเป็นการส่งต่ออย่างเดียว ดังนั้นการตั้งค่าชื่อผู้ใช้และรหัสผ่านที่โหนดปัจจุบันจึงไม่มีผล `-S` หมายถึงที่อยู่พร็อกซีระดับสองที่ต้องการเชื่อมต่อ **หากมีพารามิเตอร์นี้จะเป็นพร็อกซีแบบส่งต่อ มิฉะนั้นจะเป็นพร็อกซีปลายทาง** ```--ts``` หมายถึงขณะเชื่อมต่อกับพร็อกซีหลักจะต้องเชื่อมต่อแบบเข้ารหัส

2. เริ่มต้นพร็อกซีที่เครื่อง remote
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
หรือ
```bash
wmproxy config -c config/server.toml
```
ไฟล์คอนฟิกตัวอย่าง:
```toml
[proxy]
# ที่อยู่ IP ที่ผูกไว้
bind_addr = "127.0.0.1:8091"

# ฟังก์ชันที่พร็อกซีรองรับ 1=http, 2=https, 4=socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# ที่อยู่ binding ของ http ภายในเครือข่าย
map_http_bind = "127.0.0.1:8001"
# ที่อยู่ binding ของ tcp ภายในเครือข่าย
map_tcp_bind = "127.0.0.1:8002"
# ที่อยู่ binding ของ https ภายในเครือข่าย
map_https_bind = "127.0.0.1:8003"
# ใบรับรองสาธารณะสำหรับ mapping ภายในเครือข่าย ถ้าว่างจะใช้ใบรับรองเริ่มต้น
# map_cert = 
# ใบรับรองส่วนตัวสำหรับ mapping ภายในเครือข่าย ถ้าว่างจะใช้ใบรับรองเริ่มต้น
# map_key =
# การยืนยันตัวตนแบบสองทาง
two_way_tls = true
# รับรองว่าลูกค้าเชื่อมต่อแบบเข้ารหัสหรือไม่
tc = true
# โหมดของบริการ server=เซิร์ฟเวอร์, client=ไคลเอนต์
mode = "server"
```

```--tc``` หมายถึงขณะรับการเชื่อมต่อจากพร็อกซีลูกจะต้องเชื่อมต่อแบบเข้ารหัส สามารถใช้ ```--cert``` เพื่อระบุ public key ของใบรับรอง, ```--key``` เพื่อระบุ private key ของใบรับรอง, ```--domain``` เพื่อระบุโดเมนของใบรับรอง หากไม่ระบุจะใช้ค่าที่มีมาให้
> หลังจากนี้เมื่อเข้าถึงผ่านพร็อกซี จะไม่สามารถรู้ที่อยู่ที่แท้จริงของคำขอได้ จะเห็นเพียงคำขอที่ออกจากพร็อกซีเท่านั้น

### การยืนยันตัวตนระหว่างพร็อกซี
> ปัจจุบันรองรับการยืนยันตัวตนสองแบบ, ```two_way_tls``` ใช้สำหรับเปิดการยืนยันใบรับรองฝั่งไคลเอนต์, อีกรูปแบบหนึ่งคือฝั่งเซิร์ฟเวอร์ตั้งค่า ```username``` และ ```password``` ซึ่งฝั่งไคลเอนต์ต้องตั้งค่า user/password เดียวกันถึงจะเชื่อมต่อได้ สามารถใช้ร่วมกันหรือแยกใช้งานก็ได้
> ตัวอย่างการตั้งค่า:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Roadmap
### socks5

- [x] รองรับ IPV6
- [x] วิธีการยืนยันตัวตน `SOCKS5`
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] คำสั่ง `SOCKS5`
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] รองรับ IPV6

### ทะลุผ่านเครือข่ายภายใน

- [x] รองรับ Http
- [x] รองรับ Https
- [x] รองรับ Tcp

### พร็อกซีแบบย้อนกลับ

- [x] เซิร์ฟเวอร์ไฟล์สถิต
- [x] ตรวจสุขภาพ (passive health check)
- [x] ตรวจสุขภาพ (active health check)
- [x] โหลดคอนฟิกแบบ hot reload
- [x] โหลดบาลานซ์
- [x] โหลด TCP ชั้นที่สี่
- [x] โหลด UDP ชั้นที่สี่
- [x] ควบคุมทราฟฟิก
- [x] ส่งต่อ websocket

### ความสามารถพื้นฐาน
- [x] ล็อก

#### ความสามารถเสริม

- [x] จำกัดความเร็วคำขอ (limit_req)
- [x] แก้ไข HTTP Request Header
- [x] รองรับ HTTP2 ในการทะลุผ่านเครือข่ายภายใน
- [x] ควบคุม micro client
- [x] try_paths
- [x] tcp ไป websocket
- [x] websocket ไป tcp


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---