# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

تم تنفيذ `wmproxy` باستخدام لغة `Rust`، ويدعم وكيل `http/https`، وكيل `socks5`، الوكيل العكسي، موازنة التحميل، خادم الملفات الثابتة، وكيل `websocket`، إعادة توجيه TCP/UDP من الطبقة الرابعة، اختراق الشبكة الداخلية، وغيرها.

## 📦 التثبيت & 🏃 الاستخدام

### التثبيت

```bash
cargo install wmproxy
```

أو

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### الاستخدام
المنفذ الافتراضي هو 8090، وعنوان الاستماع الافتراضي هو 127.0.0.1
```bash
# استخدام المعلمات الافتراضية مباشرة
wmproxy proxy

# تعيين اسم مستخدم وكلمة مرور
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# أوامر أخرى
wmproxy --help

# بدء التشغيل باستخدام ملف الإعدادات
wmproxy config -c config/client.toml
```

##### بدء وكيل ثانوي
1. تشغيل الوكيل محليًا
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
أو
```bash
wmproxy config -c config/client.toml
```
ملف الإعدادات كما يلي:
```toml
[proxy]
# عنوان الاتصال بالخادم
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# هل الاتصال بالخادم مشفر
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# مصفوفة إعدادات ربط الشبكة الداخلية

  # إعادة توجيه اسم نطاق localhost إلى العنوان المحلي 127.0.0.1:8080
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

# إعادة توجيه حركة مرور tcp غير مشروطة إلى 127.0.0.1:8080
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

نظرًا لأنه إعادة توجيه فقط، فإن تعيين اسم مستخدم وكلمة مرور على هذه العقدة ليس له معنى. يشير الخيار `-S` إلى عنوان الوكيل الثانوي الذي يتم الاتصال به، **وجود هذا الخيار يعني أنه وكيل وسيط، وإلا فهو وكيل نهائي.** يشير الخيار ```--ts``` إلى أن الاتصال بالوكيل الأعلى يجب أن يكون مشفرًا.

2. تشغيل الوكيل عن بُعد
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
أو
```bash
wmproxy config -c config/server.toml
```
ملف الإعدادات كما يلي:
```toml
[proxy]
# عنوان IP المرتبط
bind_addr = "127.0.0.1:8091"

# الوظائف المدعومة من الوكيل، 1 تعني http، 2 تعني https، 4 تعني socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# عنوان ربط http لربط الشبكة الداخلية
map_http_bind = "127.0.0.1:8001"
# عنوان ربط tcp لربط الشبكة الداخلية
map_tcp_bind = "127.0.0.1:8002"
# عنوان ربط https لربط الشبكة الداخلية
map_https_bind = "127.0.0.1:8003"
# شهادة المفتاح العام لربط الشبكة الداخلية، إذا كانت فارغة فهي الشهادة الافتراضية
# map_cert = 
# شهادة المفتاح الخاص لربط الشبكة الداخلية، إذا كانت فارغة فهي الشهادة الافتراضية
# map_key =
# مصادقة ثنائية الاتجاه
two_way_tls = true
# استقبال العملاء مع تشفير
tc = true
# وضع الخدمة الحالي، server للخادم، client للعميل
mode = "server"
```

يشير الخيار ```--tc``` إلى أن استقبال الوكلاء من المستوى الأدنى يجب أن يكون عبر اتصال مشفر، ويمكنك استخدام ```--cert``` لتحديد شهادة المفتاح العام، و```--key``` لتحديد شهادة المفتاح الخاص، و```--domain``` لتحديد اسم النطاق الخاص بالشهادة، إذا لم يتم تحديدها، سيتم استخدام الشهادة الافتراضية المرفقة.
> من هذه النقطة، لن نتمكن من الحصول على العنوان الحقيقي للطلب، فقط عنوان الطلب الصادر من الوكيل

### المصادقة بين الوكلاء
> حاليًا، هناك طريقتان للمصادقة الثنائية، عند تفعيل ```two_way_tls``` سيتم تفعيل مصادقة شهادة العميل، والطريقة الأخرى هي عند تعيين ```username``` و ```password``` في الخادم، يجب على العميل تعيين نفس اسم المستخدم وكلمة المرور لتفعيل المصادقة، ويمكن استخدام الطريقتين معًا أو كل واحدة على حدة.
> أضف التكوين كما يلي:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 خارطة الطريق
### socks5

- [x] دعم IPV6
- [x] طرق تحقق `SOCKS5`
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] أوامر `SOCKS5`
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] دعم IPV6

### اختراق الشبكة الداخلية

- [x] دعم Http
- [x] دعم Https
- [x] دعم Tcp

### الوكيل العكسي

- [x] خادم ملفات ثابتة
- [x] فحص صحة سلبي
- [x] فحص صحة نشط
- [x] تحميل التكوين ديناميكيًا
- [x] موازنة التحميل
- [x] تحميل TCP من الطبقة الرابعة
- [x] تحميل UDP من الطبقة الرابعة
- [x] التحكم في حركة المرور
- [x] إعادة توجيه websocket

### القدرات الأساسية
- [x] السجلات

#### القدرات الإضافية

- [x] تحديد سرعة الطلبات (limit_req)
- [x] تعديل رأس طلب HTTP
- [x] دعم اختراق الشبكة الداخلية لـ HTTP2
- [x] التحكم في العميل المصغر
- [x] try_paths
- [x] تحويل tcp إلى websocket
- [x] تحويل websocket إلى tcp


## تاريخ النجوم

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---