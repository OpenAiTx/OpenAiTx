# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` با زبان `Rust` پیاده‌سازی شده است و از قابلیت‌هایی مانند پراکسی `http/https`، پراکسی `socks5`، پراکسی معکوس، بالانس بار، سرور فایل استاتیک، پراکسی `websocket`، فورواردینگ TCP/UDP لایه چهار، تونل‌زنی شبکه داخلی و غیره پشتیبانی می‌کند.

## 📦 نصب و 🏃 استفاده

### نصب

```bash
cargo install wmproxy
```

یا

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### استفاده
پورت پیش‌فرض 8090 و آدرس گوش دادن پیش‌فرض 127.0.0.1 می‌باشد.
```bash
# استفاده مستقیم با پارامترهای پیش‌فرض
wmproxy proxy

# تنظیم نام کاربری و رمز عبور
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# سایر دستورات
wmproxy --help

# راه‌اندازی با فایل پیکربندی
wmproxy config -c config/client.toml
```

##### راه‌اندازی پراکسی سطح دوم
1. راه‌اندازی پراکسی در لوکال
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
یا
```bash
wmproxy config -c config/client.toml
```
نمونه فایل پیکربندی:
```toml
[proxy]
# آدرس سرور جهت اتصال
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# آیا اتصال به سرور رمزنگاری شود
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# آرایه‌ای از تنظیمات نگاشت شبکه داخلی

  # هدایت دامین localhost به 127.0.0.1:8080 در لوکال
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

# هدایت بدون قید و شرط ترافیک TCP به 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

به دلیل اینکه صرفاً فورواردینگ انجام می‌شود، تنظیم نام کاربری و رمز عبور در این نود معنایی ندارد. `-S` آدرس پراکسی سطح دوم برای اتصال است، **وجود این پارامتر به معنای پراکسی میانی و نبود آن به معنای پراکسی انتهایی است.** ```--ts``` به معنای رمزنگاری ارتباط با پراکسی والد می‌باشد.

2. راه‌اندازی پراکسی در ریموت
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
یا
```bash
wmproxy config -c config/server.toml
```
نمونه فایل پیکربندی:
```toml
[proxy]
# آدرس IP برای گوش دادن
bind_addr = "127.0.0.1:8091"

# قابلیت‌های پشتیبانی شده توسط پراکسی؛ 1 برای http، 2 برای https، 4 برای socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# آدرس گوش دادن برای نگاشت http شبکه داخلی
map_http_bind = "127.0.0.1:8001"
# آدرس گوش دادن برای نگاشت tcp شبکه داخلی
map_tcp_bind = "127.0.0.1:8002"
# آدرس گوش دادن برای نگاشت https شبکه داخلی
map_https_bind = "127.0.0.1:8003"
# گواهی عمومی نگاشت شبکه داخلی، در صورت خالی بودن گواهی پیش‌فرض است
# map_cert = 
# کلید خصوصی نگاشت شبکه داخلی، در صورت خالی بودن کلید پیش‌فرض است
# map_key =
# احراز هویت دوطرفه
two_way_tls = true
# پذیرش کلاینت رمزنگاری شده
tc = true
# حالت فعلی سرویس، server برای سرور و client برای کلاینت
mode = "server"
```

```--tc``` به معنای رمزنگاری ارتباط با پراکسی‌های زیرمجموعه است. می‌توانید با ```--cert``` گواهی عمومی و با ```--key``` کلید خصوصی را مشخص کنید و با ```--domain``` دامین مربوط به گواهی را تعیین نمایید، در غیر این صورت پارامتر پیش‌فرض استفاده می‌شود.
> از اینجا به بعد، با استفاده از پراکسی دیگر نمی‌توان به آدرس واقعی درخواست دست یافت و فقط آدرس ارسالی توسط پراکسی قابل مشاهده است.

### احراز هویت بین پراکسی‌ها
> در حال حاضر دو نوع احراز هویت ارائه شده است، با فعال‌سازی ```two_way_tls``` احراز هویت گواهی کلاینت فعال می‌شود. روش دیگر، تنظیم ```username``` و ```password``` در سرور است که کلاینت نیز باید همین مقادیر را برای احراز هویت تنظیم کند. این دو روش می‌توانند به صورت همزمان یا جداگانه استفاده شوند.
> نمونه پیکربندی:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 نقشه راه
### socks5

- [x] پشتیبانی از IPV6
- [x] روش‌های احراز هویت `SOCKS5`
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] دستورات `SOCKS5`
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] پشتیبانی از IPV6

### تونل‌زنی شبکه داخلی

- [x] پشتیبانی از Http
- [x] پشتیبانی از Https
- [x] پشتیبانی از Tcp

### پراکسی معکوس

- [x] سرور فایل استاتیک
- [x] بررسی سلامت غیرفعال
- [x] بررسی سلامت فعال
- [x] بارگذاری مجدد پیکربندی
- [x] بالانس بار
- [x] بالانس TCP لایه چهارم
- [x] بالانس UDP لایه چهارم
- [x] کنترل ترافیک
- [x] فورواردینگ websocket

### قابلیت‌های پایه
- [x] لاگ‌ها

#### قابلیت‌های توسعه‌یافته

- [x] محدودسازی درخواست (limit_req)
- [x] ویرایش Header درخواست HTTP
- [x] پشتیبانی از تونل‌زنی HTTP2 در شبکه داخلی
- [x] کنترل میکروکلاینت
- [x] try_paths
- [x] تبدیل tcp به websocket
- [x] تبدیل websocket به tcp


## تاریخچه ستاره‌ها

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---