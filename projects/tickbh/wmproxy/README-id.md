# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` telah diimplementasikan dengan `Rust` untuk menyediakan proxy `http/https`, proxy `socks5`, proxy terbalik, penyeimbangan beban, server file statis, proxy `websocket`, penerusan TCP/UDP layer 4, tunneling jaringan internal, dan lain-lain.

## 📦 Instalasi & 🏃 Penggunaan

### Instalasi

```bash
cargo install wmproxy
```

ATAU

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### Penggunaan
Port default adalah 8090 dan alamat listen default adalah 127.0.0.1
```bash
# Langsung gunakan parameter default
wmproxy proxy

# Atur username dan password
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# Perintah lainnya
wmproxy --help

# Jalankan dengan file konfigurasi
wmproxy config -c config/client.toml
```

##### Menjalankan Proxy Tingkat Kedua
1. Jalankan proxy di lokal
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
atau
```bash
wmproxy config -c config/client.toml
```
Contoh file konfigurasi:
```toml
[proxy]
# Alamat server yang akan dikoneksikan
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# Apakah koneksi ke server dienkripsi
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# Array konfigurasi pemetaan jaringan internal

  # Meneruskan domain localhost ke 127.0.0.1:8080 lokal
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

# Meneruskan trafik tcp langsung ke 127.0.0.1:8080 tanpa syarat
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

Karena hanya forwarding murni, maka pengaturan username dan password pada node ini tidak ada artinya. `-S` menunjukkan alamat proxy tingkat kedua yang akan dikoneksikan, **jika parameter ini ada berarti sebagai proxy relay, jika tidak ada berarti sebagai proxy akhir.** ```--ts``` berarti koneksi ke proxy induk menggunakan enkripsi.

2. Jalankan proxy di remote
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
atau
```bash
wmproxy config -c config/server.toml
```
Contoh file konfigurasi:
```toml
[proxy]
# Alamat ip yang di-bind
bind_addr = "127.0.0.1:8091"

# Fungsi proxy yang didukung, 1 untuk http, 2 untuk https, 4 untuk socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# Alamat bind http mapping jaringan internal
map_http_bind = "127.0.0.1:8001"
# Alamat bind tcp mapping jaringan internal
map_tcp_bind = "127.0.0.1:8002"
# Alamat bind https mapping jaringan internal
map_https_bind = "127.0.0.1:8003"
# Sertifikat public key mapping jaringan internal, kosong berarti pakai sertifikat default
# map_cert = 
# Sertifikat private key mapping jaringan internal, kosong berarti pakai sertifikat default
# map_key =
# Autentikasi dua arah
two_way_tls = true
# Menerima koneksi klien terenkripsi
tc = true
# Mode layanan saat ini, server untuk sisi server, client untuk sisi klien
mode = "server"
```

```--tc``` berarti menerima koneksi proxy anak menggunakan enkripsi, dapat menggunakan ```--cert``` untuk menentukan public key sertifikat, ```--key``` untuk menentukan private key sertifikat, ```--domain``` untuk menentukan domain sertifikat, jika tidak ditentukan maka akan menggunakan sertifikat default.
> Sampai tahap ini, saat mengakses melalui proxy, kita sudah tidak bisa mendapatkan alamat permintaan yang asli, hanya bisa mendapatkan permintaan yang dikirim oleh proxy.

### Autentikasi Antar Proxy
> Saat ini disediakan dua jenis autentikasi, dengan mengaktifkan ```two_way_tls``` untuk autentikasi sertifikat klien, dan dengan mengatur ```username``` serta ```password``` pada server yang mengharuskan klien mengatur username dan password yang sama agar dapat menggunakan autentikasi. Kedua metode ini bisa digunakan bersamaan atau sendiri-sendiri.
> Tambahkan konfigurasi seperti berikut:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 Roadmap
### socks5

- [x] Dukungan IPV6
- [x] Metode autentikasi `SOCKS5`
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] Perintah `SOCKS5`
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] Dukungan IPV6

### Tunneling Jaringan Internal

- [x] Dukungan Http
- [x] Dukungan Https
- [x] Dukungan Tcp

### Proxy Terbalik

- [x] Server file statis
- [x] Pemeriksaan kesehatan pasif
- [x] Pemeriksaan kesehatan aktif
- [x] Hot reload konfigurasi
- [x] Penyeimbangan beban
- [x] Load balancing TCP layer 4
- [x] Load balancing UDP layer 4
- [x] Kontrol trafik
- [x] Forwarding websocket

### Kemampuan Dasar
- [x] Log

#### Kemampuan Ekstensi

- [x] Batas kecepatan permintaan (limit_req)
- [x] Modifikasi Header HTTP Request
- [x] Dukungan tunneling HTTP2 jaringan internal
- [x] Kontrol micro-end
- [x] try_paths
- [x] tcp ke websocket
- [x] websocket ke tcp


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---