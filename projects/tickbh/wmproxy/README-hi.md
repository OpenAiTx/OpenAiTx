# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy` को `Rust` में लागू किया गया है जो `http/https` प्रॉक्सी, `socks5` प्रॉक्सी, रिवर्स प्रॉक्सी, लोड बैलेंसिंग, स्टैटिक फाइल सर्वर, `websocket` प्रॉक्सी, लेयर 4 TCP/UDP फॉरवर्डिंग, इनरनेट पेनिट्रेशन आदि का समर्थन करता है।

## 📦 इंस्टॉल करें & 🏃 उपयोग करें

### इंस्टॉल करें

```bash
cargo install wmproxy
```

या

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### उपयोग करें
डिफॉल्ट पोर्ट 8090 है, डिफॉल्ट लिसन पता 127.0.0.1 है
```bash
# सीधे डिफॉल्ट पैरामीटर से चलाएँ
wmproxy proxy

# यूजरनेम और पासवर्ड सेट करें
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# अन्य कमांड
wmproxy --help

#कॉन्फ़िगरेशन फ़ाइल के साथ स्टार्ट करें
wmproxy config -c config/client.toml
```

##### द्वितीयक प्रॉक्सी प्रारंभ करें
1. लोकल में प्रॉक्सी प्रारंभ करें
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
या
```bash
wmproxy config -c config/client.toml
```
कॉन्फ़िगरेशन फ़ाइल निम्नलिखित है:
```toml
[proxy]
# सर्वर का पता कनेक्ट करें
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# सर्वर कनेक्शन एन्क्रिप्टेड है या नहीं
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# इनरनेट मैपिंग कॉन्फ़िगरेशन की सूची

  #localhost का डोमेन नाम 127.0.0.1:8080 पर फॉरवर्ड करें
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

#tcp ट्रैफिक को बिना शर्त 127.0.0.1:8080 पर फॉरवर्ड करें
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

क्योंकि यह केवल फॉरवर्डिंग है, इसलिए वर्तमान नोड पर यूजरनेम और पासवर्ड सेट करना बेकार है। `-S` का अर्थ है द्वितीयक प्रॉक्सी का पता जिससे कनेक्ट होना है, **यदि यह पैरामीटर मौजूद है तो यह रिले प्रॉक्सी है, अन्यथा यह अंतिम प्रॉक्सी है।** ```--ts``` का अर्थ है पैरेंट प्रॉक्सी से एन्क्रिप्टेड कनेक्शन बनाना।

2. रिमोट में प्रॉक्सी प्रारंभ करें
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
या
```bash
wmproxy config -c config/server.toml
```
कॉन्फ़िगरेशन फ़ाइल निम्नलिखित है:
```toml
[proxy]
#बाउंड ip पता
bind_addr = "127.0.0.1:8091"

#प्रॉक्सी द्वारा समर्थित कार्य, 1=http, 2=https, 4=socks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

#इनरनेट मैपिंग http बाइंड पता
map_http_bind = "127.0.0.1:8001"
#इनरनेट मैपिंग tcp बाइंड पता
map_tcp_bind = "127.0.0.1:8002"
#इनरनेट मैपिंग https बाइंड पता
map_https_bind = "127.0.0.1:8003"
#इनरनेट मैपिंग का पब्लिक की सर्टिफिकेट, खाली होने पर डिफॉल्ट सर्टिफिकेट
# map_cert = 
#इनरनेट मैपिंग का प्राइवेट की सर्टिफिकेट, खाली होने पर डिफॉल्ट सर्टिफिकेट
# map_key =
# द्वि-दिशा प्रमाणीकरण
two_way_tls = true
#क्या क्लाइंट एन्क्रिप्टेड क्लाइंट है, इसे स्वीकार करें
tc = true
#वर्तमान सेवा मोड, server=सर्वर, client=क्लाइंट
mode = "server"
```

```--tc``` का अर्थ है सब-प्रॉक्सी से एन्क्रिप्टेड कनेक्शन स्वीकार करना। आप ```--cert``` से सर्टिफिकेट का पब्लिक की, ```--key``` से प्राइवेट की, ```--domain``` से डोमेन सेट कर सकते हैं। यदि सेट नहीं किया, तो डिफॉल्ट सर्टिफिकेट का उपयोग होगा।
> इस बिंदु पर प्रॉक्सी के माध्यम से पहुँचने पर, हम वास्तविक अनुरोध का पता प्राप्त नहीं कर सकते, केवल प्रॉक्सी के शुरू किए गए अनुरोध का पता मिलेगा।

### प्रॉक्सी के बीच प्रमाणीकरण
> वर्तमान में दो प्रकार के प्रमाणीकरण उपलब्ध हैं, ```two_way_tls``` क्लाइंट सर्टिफिकेट प्रमाणीकरण सक्षम करता है, दूसरा सर्वर पर ```username``` और ```password``` सेट करने पर क्लाइंट को वही यूज़र-पासवर्ड देना होगा। दोनों को एक साथ या अलग-अलग उपयोग किया जा सकता है।
> कॉन्फ़िगरेशन जोड़ें:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 रोडमैप
### socks5

- [x] IPV6 समर्थन
- [x] `SOCKS5` प्रमाणीकरण
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] `SOCKS5` कमांड्स
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] IPV6 समर्थन

### इनरनेट पेनिट्रेशन

- [x] Http समर्थन
- [x] Https समर्थन
- [x] Tcp समर्थन

### रिवर्स प्रॉक्सी

- [x] स्टैटिक फाइल सर्वर
- [x] पैसिव हेल्थ चेक
- [x] एक्टिव हेल्थ चेक
- [x] कॉन्फ़िगरेशन हॉट लोडिंग
- [x] लोड बैलेंसिंग
- [x] लेयर 4 TCP लोड
- [x] लेयर 4 UDP लोड
- [x] ट्रैफिक कंट्रोल
- [x] websocket फॉरवर्डिंग

### बेसिक क्षमताएँ
- [x] लॉगिंग

#### एक्सटेंशन क्षमताएँ

- [x] अनुरोध गति सीमा (limit_req)
- [x] HTTP अनुरोध हेडर संशोधित करें
- [x] HTTP2 इनरनेट पेनिट्रेशन समर्थन
- [x] माइक्रो क्लाइंट नियंत्रण
- [x] try_paths
- [x] tcp से websocket
- [x] websocket से tcp


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---