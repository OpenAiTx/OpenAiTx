<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# رابط کاربری تحت وب گلوئتون

یک رابط کاربری تحت وب سبک برای نظارت و کنترل [Gluetun](https://github.com/qdm12/gluetun) — کلاینت VPN برای کانتینر داکر.

![وضعیت: متصل](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)


---

## ویژگی‌ها

- ✨ **پشتیبانی از چند VPN** — نظارت و کنترل همزمان تا ۲۰ نمونه Gluetun
- بنر وضعیت زنده VPN (متصل / متوقف / قطع شده)
- آی‌پی خروجی عمومی، کشور، منطقه، شهر و سازمان
- ارائه‌دهنده VPN، پروتکل (WireGuard / OpenVPN)، جزئیات سرور
- وضعیت پورت فورواردینگ و DNS
- کنترل‌های شروع / توقف VPN
- بروزرسانی خودکار با بازه قابل تنظیم (۵ تا ۶۰ ثانیه)
- ۳۰ تیک آخر نظرسنجی با رنگ‌بندی در نوار تاریخچه
- طراحی واکنشگرا (موبایل، تبلت، دسکتاپ)

---

## تصاویر
![متن جایگزین](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## پیش‌نیازها

- داکر + Docker Compose
- اجرای Gluetun با فعال بودن سرور کنترل HTTP (پورت پیش‌فرض `8000`)
- Gluetun و gluetun-webui در یک شبکه داکر مشترک

> پشتیبانی از `linux/amd64` و `linux/arm64` (قابل اجرا بر روی مک اینتل/اپل سیلیکون، لینوکس و ویندوز).

---

## شروع سریع

### گزینه A1: نمونه تکی (توصیه‌شده)

اضافه کردن `gluetun-webui` به فایل کامپوز فعلی در کنار Gluetun:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  container_name: gluetun-webui
  ports:
    - "127.0.0.1:3000:3000"
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    # Uncomment if Gluetun auth is enabled:
    #- GLUETUN_API_KEY=yourtoken
    #- GLUETUN_USER=username
    #- GLUETUN_PASSWORD=password
  networks:
    - your_network_name
  restart: unless-stopped
  read_only: true
  tmpfs:
    - /tmp
  security_opt:
    - no-new-privileges:true
  cap_drop:
    - ALL
  healthcheck:
    test: ["CMD", "wget", "-qO-", "http://localhost:3000/api/health"]
    interval: 30s
    timeout: 5s
    start_period: 10s
    retries: 3
```

### گزینه A2: چندین نمونه

مانیتور کردن ۲ یا بیشتر نمونه Gluetun با داشبوردهای جداگانه:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  container_name: gluetun-webui
  ports:
    - "127.0.0.1:3000:3000"
  environment:
    - GLUETUN_1_NAME=VPN - London
    - GLUETUN_1_URL=http://gluetun-1:8000
    - GLUETUN_1_API_KEY=token1
    
    - GLUETUN_2_NAME=VPN - Amsterdam  
    - GLUETUN_2_URL=http://gluetun-2:8000
    - GLUETUN_2_API_KEY=token2
    
    - GLUETUN_3_NAME=VPN - Singapore
    - GLUETUN_3_URL=http://gluetun-3:8000
    - GLUETUN_3_API_KEY=token3
  networks:
    - your_network_name
  restart: unless-stopped
  read_only: true
  tmpfs:
    - /tmp
  security_opt:
    - no-new-privileges:true
  cap_drop:
    - ALL
```

### گزینه ب: ساخت محلی

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```
سپس اجرا کنید (هر یک از گزینه‌ها):


```bash
docker compose up -d
```

رابط کاربری در **http://localhost:3000** در دسترس است

---

## راه‌اندازی شبکه

هر دو Gluetun و gluetun-webui باید در یک شبکه داکر باشند تا `http://gluetun:8000` به درستی resolve شود.

**همان فایل کامپوز** — فقط کافیست هر دو سرویس را به یک شبکه اضافه کنید (رایج‌ترین حالت):

```yaml
services:
  gluetun:
    networks:
      - arr-stack
  gluetun-webui:
    networks:
      - arr-stack

networks:
  arr-stack:
    driver: bridge
```

**فایل‌های کامپوز جداگانه** — شبکه موجود Gluetun را به عنوان خارجی ارجاع دهید. نام شبکه خود را با دستور `docker network ls` پیدا کنید:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## پشتیبانی از چند VPN

### نمونه‌های متعدد

gluetun-webui از **مانیتورینگ و کنترل چندین نمونه Gluetun به طور همزمان** پشتیبانی می‌کند. هر نمونه به عنوان یک داشبورد جداگانه در یک شبکه واکنش‌گرا نمایش داده می‌شود.

**پیکربندی**: از متغیرهای محیطی شماره‌گذاری‌شده استفاده کنید:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    # Instance 1
    - GLUETUN_1_NAME=VPN 1
    - GLUETUN_1_URL=http://gluetun-1:8000
    - GLUETUN_1_API_KEY=token1  # optional

    # Instance 2
    - GLUETUN_2_NAME=VPN 2
    - GLUETUN_2_URL=http://gluetun-2:8000
    - GLUETUN_2_API_KEY=token2  # optional

    # Instance 3
    - GLUETUN_3_NAME=VPN 3
    - GLUETUN_3_URL=http://gluetun-3:8000
    - GLUETUN_3_USER=admin
    - GLUETUN_3_PASSWORD=secret  # optional (HTTP Basic auth)
```

**پشتیبانی شده**: تا ۲۰ نمونه (از طریق `GLUETUN_1_URL` تا `GLUETUN_20_URL`)  
**واکنش‌گرا**: ۱ داشبورد با عرض کامل → ۲ داشبورد با نیم‌عرض → ۳ داشبورد با یک‌سوم عرض → ۴ داشبورد با یک‌چهارم عرض → قابل اسکرول از ۵ نمونه به بالا

### سازگاری با نسخه‌های قبلی

اگر هیچ متغیر شماره‌گذاری‌شده‌ای پیکربندی نشود، به **حالت تک‌نمونه قدیمی** بازمی‌گردد:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### احراز هویت برای هر نمونه

هر نمونه می‌تواند احراز هویت متفاوتی داشته باشد:

```yaml
# Instance with API key
- GLUETUN_1_API_KEY=my-secret-token

# Instance with HTTP Basic auth
- GLUETUN_2_USER=admin
- GLUETUN_2_PASSWORD=mysecret

# Instance with no auth
- GLUETUN_3_URL=http://gluetun-3:8000  # auth optional
```
---

## پیکربندی

| متغیر | مقدار پیش‌فرض | توضیحات |
|---|---|---|
| `GLUETUN_1_*` تا `GLUETUN_20_*` | _(خالی)_ | **پیکربندی چند نمونه‌ای** (تا ۲۰ نمونه) |
| `GLUETUN_{N}_URL` | – | آدرس سرور کنترل HTTP Gluetun برای نمونه N |
| `GLUETUN_{N}_NAME` | `Instance {N}` | نام نمایشی برای نمونه N |
| `GLUETUN_{N}_API_KEY` | _(خالی)_ | توکن Bearer برای نمونه N (در صورت فعال بودن احراز هویت) |
| `GLUETUN_{N}_USER` | _(خالی)_ | نام کاربری برای احراز هویت HTTP Basic (نمونه N) |
| `GLUETUN_{N}_PASSWORD` | _(خالی)_ | رمز عبور برای احراز هویت HTTP Basic (نمونه N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **قدیمی** – فقط یک نمونه (در صورت نبود متغیرهای `GLUETUN_1_*`) |
| `GLUETUN_API_KEY` | _(خالی)_ | **قدیمی** – توکن Bearer برای یک نمونه |
| `GLUETUN_USER` | _(خالی)_ | **قدیمی** – نام کاربری برای احراز هویت HTTP Basic |
| `GLUETUN_PASSWORD` | _(خالی)_ | **قدیمی** – رمز عبور برای احراز هویت HTTP Basic |
| `PORT` | `3000` | پورتی که رابط کاربری وب روی آن گوش می‌دهد |
| `TRUST_PROXY` | `false` | اگر پشت پراکسی معکوس اجرا می‌کنید (`nginx`، `Traefik` و غیره) مقدار را `true` قرار دهید |

---

## امنیت

- پورت به `127.0.0.1` متصل است — به شبکه نمایش داده نمی‌شود
- کانتینر به صورت غیر ریشه با سیستم فایل فقط خواندنی و قابلیت‌های حذف شده اجرا می‌شود
- محدودیت نرخ برای تمام مسیرهای API اعمال می‌شود
- جزئیات خطاهای بالادستی فقط در سمت سرور ثبت می‌شوند — پیام‌های عمومی به مرورگر بازگردانده می‌شود

### پیکربندی پراکسی معکوس

اگر gluetun-webui را پشت پراکسی معکوس (`nginx`، `Traefik`، `Caddy` و غیره) اجرا می‌کنید، مقدار `TRUST_PROXY=true` را در متغیرهای محیطی خود قرار دهید:


```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```
این امکان را به برنامه می‌دهد تا هدرهای `X-Forwarded-For` و هدرهای مرتبط را برای محدودسازی نرخ و شناسایی IP به طور دقیق تجزیه کند. **توجه:** این گزینه را فقط زمانی فعال کنید که واقعاً پشت یک پروکسی معکوس قرار دارید، زیرا هدرهای پروکسی را از پروکسی معکوس شما اعتماد می‌کند.

### احراز هویت پروکسی معکوس

کنترل‌های شروع/توقف VPN احراز هویت داخلی ندارند. اگر رابط کاربری را خارج از localhost در معرض دید قرار می‌دهید، آن را پشت یک پروکسی معکوس با احراز هویت HTTP Basic قرار دهید.

**کدی** (`Caddyfile`):

```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
یک هش تولید کنید با: `caddy hash-password`

**انجین‌ایکس** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
یک فایل رمز عبور ایجاد کنید با: `htpasswd -c /etc/nginx/.htpasswd user`

**ترایفیک** (برچسب‌های داکر):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
یک هش تولید کنید با: `htpasswd -nb user password`

---

## قدردانی

- **[Gluetun](https://github.com/qdm12/gluetun)** — کانتینر کلاینت VPN که این وب‌یوآی برای آن ساخته شده است
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — ابزار عالی پایش برای استفاده همراه این وب‌یوآی
- **توسعه با کمک هوش مصنوعی** — این پروژه با کمک هوش مصنوعی ساخته شده است

---

## مجوز

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---