<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# Gluetun WebUI

واجهة ويب خفيفة الوزن لمراقبة والتحكم في [Gluetun](https://github.com/qdm12/gluetun) — عميل VPN للحاويات عبر Docker.

![الحالة: متصل](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)


---

## الميزات

- ✨ **دعم متعدد لـ VPN** — راقب وتحكم في ما يصل إلى 20 مثيل من Gluetun في نفس الوقت
- شريط حالة VPN مباشر (متصل / متوقف مؤقتًا / غير متصل)
- عنوان IP العام، الدولة، المنطقة، المدينة، والمنظمة
- مزود VPN، البروتوكول (WireGuard / OpenVPN)، تفاصيل الخادم
- حالة إعادة توجيه المنافذ وDNS
- عناصر تحكم بدء / إيقاف VPN
- تحديث تلقائي بفاصل زمني قابل للتكوين (5 ثوانٍ – 60 ثانية)
- آخر 30 نقطة استقصاء ملونة في شريط التاريخ
- تصميم متجاوب (جوال، جهاز لوحي، سطح مكتب)

---

## لقطات شاشة
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## المتطلبات

- Docker + Docker Compose
- Gluetun يعمل مع تفعيل خادم التحكم HTTP الخاص به (المنفذ الافتراضي `8000`)
- Gluetun و gluetun-webui على نفس شبكة Docker

> يدعم `linux/amd64` و `linux/arm64` (يعمل على أجهزة Mac Intel/Apple Silicon، لينكس، وويندوز).

---

## البدء السريع

### الخيار A1: مثيل واحد (موصى به)

أضف `gluetun-webui` إلى ملف التكوين الحالي بجانب Gluetun:

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

### الخيار A2: عدة مثيلات

راقب مثيلين أو أكثر من Gluetun باستخدام لوحات معلومات منفصلة:

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

### الخيار ب: البناء محليًا

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

ثم قم بالتشغيل (أي من الخيارين):

```bash
docker compose up -d
```

واجهة المستخدم متاحة على **http://localhost:3000**

---

## إعداد الشبكة

يجب أن يكون كل من Gluetun و gluetun-webui على نفس شبكة Docker حتى يتم حل `http://gluetun:8000` بشكل صحيح.

**نفس ملف التكوين** — فقط أضف كلا الخدمتين إلى نفس الشبكة (الأكثر شيوعاً):

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

**ملفات تكوين منفصلة** — قم بالإشارة إلى شبكة Gluetun الحالية كشبكة خارجية. اعثر على اسم شبكتك باستخدام `docker network ls`:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## دعم تعدد شبكات VPN

### عدة مثيلات

يدعم gluetun-webui مراقبة والتحكم في **عدة مثيلات من Gluetun في نفس الوقت**. تظهر كل مثيلة كلوحة تحكم منفصلة في شبكة متجاوبة.

**الإعداد**: استخدم متغيرات البيئة المرقمة:

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

**مدعوم**: حتى 20 مثيل (عن طريق `GLUETUN_1_URL` حتى `GLUETUN_20_URL`)  
**متجاوب**: لوحة تحكم بعرض كامل → 2 بعرض نصف → 3 بعرض ثلث → 4 بعرض ربع → قابل للتمرير عند 5+

### التوافق مع الإصدارات السابقة

إذا لم يتم تكوين متغيرات مرقمة، يتم الرجوع إلى **وضع المثيل الواحد القديم**:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### المصادقة لكل مثيل

يمكن أن يكون لكل مثيل مصادقة مختلفة:

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

## الإعدادات

| المتغير | الافتراضي | الوصف |
|---|---|---|
| `GLUETUN_1_*` إلى `GLUETUN_20_*` | _(فارغ)_ | **إعداد متعدد النسخ** (حتى 20 نسخة) |
| `GLUETUN_{N}_URL` | – | عنوان خادم Gluetun HTTP للتحكم للنسخة N |
| `GLUETUN_{N}_NAME` | `Instance {N}` | اسم العرض للنسخة N |
| `GLUETUN_{N}_API_KEY` | _(فارغ)_ | رمز Bearer للنسخة N (إذا تم تفعيل المصادقة) |
| `GLUETUN_{N}_USER` | _(فارغ)_ | اسم المستخدم لمصادقة HTTP Basic (النسخة N) |
| `GLUETUN_{N}_PASSWORD` | _(فارغ)_ | كلمة المرور لمصادقة HTTP Basic (النسخة N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **قديم** – نسخة واحدة فقط (تستخدم إذا لم توجد متغيرات `GLUETUN_1_*`) |
| `GLUETUN_API_KEY` | _(فارغ)_ | **قديم** – رمز Bearer لنسخة واحدة |
| `GLUETUN_USER` | _(فارغ)_ | **قديم** – اسم المستخدم لمصادقة HTTP Basic |
| `GLUETUN_PASSWORD` | _(فارغ)_ | **قديم** – كلمة المرور لمصادقة HTTP Basic |
| `PORT` | `3000` | المنفذ الذي يستمع عليه واجهة الويب |
| `TRUST_PROXY` | `false` | عين إلى `true` إذا كان يعمل خلف وكيل عكسي (nginx، Traefik، إلخ.) |

---

## الأمان

- المنفذ مرتبط بـ `127.0.0.1` — غير مكشوف على الشبكة
- الحاوية تعمل بدون صلاحيات root وبنظام ملفات للقراءة فقط وصلاحيات منخفضة
- تطبيق تحديد معدل الوصول على جميع مسارات API
- تفاصيل أخطاء المصدر الأعلى تسجل فقط على الخادم — رسائل عامة ترجع للمتصفح

### إعداد الوكيل العكسي

إذا قمت بتشغيل gluetun-webui خلف وكيل عكسي (nginx، Traefik، Caddy، إلخ)، قم بتعيين `TRUST_PROXY=true` في متغيرات البيئة لديك:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

يتيح ذلك للتطبيق تحليل ترويسات `X-Forwarded-For` وما يتعلق بها بشكل صحيح لضبط معدل الطلبات واكتشاف عناوين IP بدقة. **ملاحظة:** فعّل هذا الخيار فقط إذا كنت فعلاً خلف وكيل عكسي، حيث أنه يثق بالترويسات القادمة من وكيلك العكسي.

### المصادقة عبر الوكيل العكسي

أزرار بدء/إيقاف VPN لا تتضمن مصادقة مدمجة. إذا عرضت واجهة المستخدم خارج نطاق localhost، ضعها خلف وكيل عكسي مع مصادقة HTTP أساسية.

**كادي** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
قم بإنشاء تجزئة باستخدام: `caddy hash-password`

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
أنشئ ملف كلمة المرور باستخدام: `htpasswd -c /etc/nginx/.htpasswd user`

**ترافيك** (تسميات Docker):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
أنشئ قيمة هاش باستخدام: `htpasswd -nb user password`

---

## الشكر والتقدير

- **[Gluetun](https://github.com/qdm12/gluetun)** — حاوية عميل VPN التي تم بناء واجهة الويب هذه من أجلها
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — أداة مراقبة رائعة يمكن استخدامها مع واجهة الويب هذه
- **التطوير بمساعدة الذكاء الاصطناعي** — تم بناء هذا المشروع بمساعدة الذكاء الاصطناعي

---

## الرخصة

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---