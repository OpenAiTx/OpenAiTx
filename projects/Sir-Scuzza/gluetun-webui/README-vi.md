
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

Một giao diện web nhẹ để giám sát và điều khiển [Gluetun](https://github.com/qdm12/gluetun) — container máy khách VPN cho Docker.

![Trạng thái: Đã kết nối](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## Tính năng

- ✨ **Hỗ trợ nhiều VPN** — Giám sát & điều khiển tối đa 20 phiên bản Gluetun cùng lúc
- Biểu ngữ trạng thái VPN trực tiếp (kết nối / tạm dừng / ngắt kết nối)
- IP public đầu ra, quốc gia, vùng, thành phố và tổ chức
- Nhà cung cấp VPN, giao thức (WireGuard / OpenVPN), thông tin máy chủ
- Trạng thái chuyển tiếp cổng và DNS
- Điều khiển Bắt đầu / Dừng VPN
- Tự động làm mới với khoảng thời gian cấu hình (5s – 60s)
- 30 lần kiểm tra cuối được mã màu trong thanh lịch sử
- Thiết kế đáp ứng (di động, máy tính bảng, máy tính để bàn)

---

## Ảnh chụp màn hình
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## Yêu cầu

- Docker + Docker Compose
- Gluetun chạy với máy chủ điều khiển HTTP được bật (cổng mặc định `8000`)
- Gluetun và gluetun-webui trên cùng một mạng Docker

> Hỗ trợ `linux/amd64` và `linux/arm64` (hoạt động trên Mac Intel/Apple Silicon, Linux và Windows).

---

## Khởi động nhanh

### Tùy chọn A1: Một phiên bản (Khuyến nghị)

Thêm `gluetun-webui` vào file compose hiện tại của bạn cùng với Gluetun:

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

### Tùy chọn A2: Nhiều phiên bản

Giám sát từ 2 phiên bản Gluetun trở lên với các bảng điều khiển riêng biệt:

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

### Tùy chọn B: Tự xây dựng trên máy local

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```
  
Sau đó chạy (một trong hai tùy chọn):

```bash
docker compose up -d
```

Giao diện người dùng có sẵn tại **http://localhost:3000**

---

## Thiết lập mạng

Cả Gluetun và gluetun-webui đều phải nằm trên cùng một mạng Docker để `http://gluetun:8000` có thể phân giải đúng.

**Cùng tệp compose** — chỉ cần thêm cả hai dịch vụ vào cùng một mạng (phổ biến nhất):

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

**Các file compose riêng biệt** — tham chiếu mạng hiện tại của Gluetun như một mạng ngoài. Tìm tên mạng của bạn bằng lệnh `docker network ls`:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## Hỗ trợ Multi-VPN

### Nhiều phiên bản

gluetun-webui hỗ trợ giám sát và điều khiển **nhiều phiên bản Gluetun đồng thời**. Mỗi phiên bản sẽ hiển thị dưới dạng một bảng điều khiển riêng biệt trong lưới phản hồi.

**Cấu hình**: Sử dụng các biến môi trường được đánh số:

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

**Hỗ trợ**: Tối đa 20 instance (thông qua `GLUETUN_1_URL` đến `GLUETUN_20_URL`)  
**Tương thích**: 1 bảng điều khiển toàn chiều rộng → 2 nửa chiều rộng → 3 một phần ba chiều rộng → 4 một phần tư chiều rộng → cuộn khi từ 5 trở lên

### Tương thích ngược

Nếu không cấu hình biến có đánh số, sẽ chuyển về **chế độ một instance cũ**:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### Xác thực theo từng phiên bản

Mỗi phiên bản có thể có xác thực khác nhau:

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

## Cấu hình

| Biến | Mặc định | Mô tả |
|---|---|---|
| `GLUETUN_1_*` đến `GLUETUN_20_*` | _(trống)_ | **Cấu hình đa phiên bản** (tối đa 20 phiên bản) |
| `GLUETUN_{N}_URL` | – | URL máy chủ điều khiển HTTP Gluetun cho phiên bản N |
| `GLUETUN_{N}_NAME` | `Instance {N}` | Tên hiển thị cho phiên bản N |
| `GLUETUN_{N}_API_KEY` | _(trống)_ | Mã Bearer cho phiên bản N (nếu bật xác thực) |
| `GLUETUN_{N}_USER` | _(trống)_ | Tên người dùng cho HTTP Basic auth (phiên bản N) |
| `GLUETUN_{N}_PASSWORD` | _(trống)_ | Mật khẩu cho HTTP Basic auth (phiên bản N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **Cũ** – chỉ cho một phiên bản (sử dụng nếu không có biến `GLUETUN_1_*`) |
| `GLUETUN_API_KEY` | _(trống)_ | **Cũ** – Mã Bearer cho một phiên bản |
| `GLUETUN_USER` | _(trống)_ | **Cũ** – Tên người dùng cho HTTP Basic auth |
| `GLUETUN_PASSWORD` | _(trống)_ | **Cũ** – Mật khẩu cho HTTP Basic auth |
| `PORT` | `3000` | Cổng web UI lắng nghe |
| `TRUST_PROXY` | `false` | Đặt thành `true` nếu chạy phía sau reverse proxy (nginx, Traefik, v.v.) |

---

## Bảo mật

- Cổng được gắn với `127.0.0.1` — không công khai ra mạng
- Container chạy dưới quyền non-root với hệ thống tệp chỉ đọc và hạn chế quyền
- Hạn chế tốc độ áp dụng cho tất cả các tuyến API
- Thông tin lỗi từ upstream chỉ được ghi lại phía máy chủ — trình duyệt chỉ nhận thông báo chung

### Cấu hình reverse-proxy

Nếu bạn chạy gluetun-webui phía sau reverse proxy (nginx, Traefik, Caddy, v.v.), hãy đặt `TRUST_PROXY=true` trong biến môi trường:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

Điều này cho phép ứng dụng phân tích đúng các header `X-Forwarded-For` và các header liên quan để giới hạn tốc độ và phát hiện IP chính xác. **Lưu ý:** Chỉ bật tính năng này nếu bạn thực sự đứng sau một reverse proxy, vì nó tin tưởng các header proxy từ reverse proxy của bạn.

### Xác thực reverse-proxy

Các điều khiển khởi động/dừng VPN không có xác thực tích hợp sẵn. Nếu bạn cung cấp giao diện UI ra ngoài localhost, hãy đặt nó sau một reverse proxy với xác thực HTTP Basic.

**Caddy** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
Tạo một mã băm với: `caddy hash-password`

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
Tạo một tệp mật khẩu với: `htpasswd -c /etc/nginx/.htpasswd user`

**Traefik** (nhãn Docker):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
Tạo một hash với: `htpasswd -nb user password`

---

## Lời cảm ơn

- **[Gluetun](https://github.com/qdm12/gluetun)** — Container VPN client mà webui này được xây dựng cho
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — Công cụ giám sát tuyệt vời để sử dụng cùng webui này
- **Phát triển hỗ trợ AI** — Dự án này được xây dựng với sự hỗ trợ của AI

---

## Giấy phép

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---