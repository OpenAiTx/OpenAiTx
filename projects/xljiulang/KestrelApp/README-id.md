# KestrelApp
Contoh aplikasi pemrograman jaringan berbasis Kestrel

### 1 Tujuan Proyek
1. Memahami bahwa pemrograman jaringan tidak lagi harus dimulai dari Socket
2. Memahami bahwa pemrograman jaringan tidak lagi membutuhkan kerangka kerja pihak ketiga (termasuk Dotnetty)
3. Memahami pemrograman jaringan bertingkat `telnet` over `websocket` over `tls` over `xxx enkripsi privat` over `tcp`
4. Mampu mengembangkan aplikasi jaringan berbasis KestrelFramework

### 2 Dokumentasi
**Dokumentasi Internal**：[docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**Dokumentasi Eksternal**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
Beberapa pustaka dasar yang diperlukan untuk pemrograman jaringan kestrel
1. Antarmuka middleware Kestrel dan pendaftaran perantara
2. System.Buffers: Kelas operasi buffer
3. System.IO: Kelas operasi stream
4. System.IO.Pipelines: Kelas operasi pipa dupleks
5. Middleware: Beberapa middleware kestrel

### 4 KestrelApp
Aplikasi Kestrel, isi meliputi
1. Konfigurasi EndPoint yang didengarkan
2. Konfigurasi protokol yang digunakan EndPoint

### 5 KestrelApp.Middleware
Pustaka kelas middleware KestrelApp
#### 5.1 Echo
Contoh protokol aplikasi Echo sederhana

#### 5.2 FlowAnalyze
Contoh middleware statistik lalu lintas pada lapisan transportasi

#### 5.3 FlowXor
Contoh middleware pemrosesan XOR lalu lintas pada lapisan transportasi

#### 5.4 HttpProxy
Contoh protokol aplikasi proxy http

#### 5.5 Telnet
Contoh protokol aplikasi Telnet sederhana

#### 5.6 TelnetProxy
Contoh penerusan lalu lintas ke server telnet

#### 5.6 Redis
Server protokol redis, contoh cara menggunakan middleware aplikasi

### Sumber terbuka lebih menarik dengan partisipasimu
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---