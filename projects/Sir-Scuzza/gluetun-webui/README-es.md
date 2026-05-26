# Gluetun WebUI

Una interfaz web ligera para monitorear y controlar [Gluetun](https://github.com/qdm12/gluetun) — el contenedor cliente VPN para Docker.

![Estado: Conectado](https://img.shields.io/badge/status-connected-brightgreen)
![Nodo 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## Características

- ✨ **Soporte Multi-VPN** — Monitorea y controla hasta 20 instancias de Gluetun simultáneamente
- Banner de estado VPN en vivo (conectado / pausado / desconectado)
- IP pública de salida, país, región, ciudad y organización
- Proveedor VPN, protocolo (WireGuard / OpenVPN), detalles del servidor
- Reenvío de puertos y estado DNS
- Controles de iniciar / detener VPN
- Auto-refresco con intervalo configurable (5s – 60s)
- Últimos 30 ticks de sondeo codificados por colores en la barra de historial
- Diseño responsivo (móvil, tableta, escritorio)

---

## Capturas de pantalla
![texto alternativo](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## Requisitos

- Docker + Docker Compose
- Gluetun ejecutándose con su servidor de control HTTP habilitado (puerto predeterminado `8000`)
- Gluetun y gluetun-webui en la misma red Docker

> Compatible con `linux/amd64` y `linux/arm64` (funciona en Mac Intel/Apple Silicon, Linux y Windows).

---

## Inicio rápido

### Opción A1: Instancia Única (Recomendada)

Agregue `gluetun-webui` a su archivo compose existente junto con Gluetun:

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

### Opción A2: Múltiples Instancias

Monitorea 2 o más instancias de Gluetun con paneles separados:

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

### Opción B: Construir localmente

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

Luego ejecute (cualquiera de las opciones):

```bash
docker compose up -d
```

La interfaz de usuario está disponible en **http://localhost:3000**

---

## Configuración de red

Tanto Gluetun como gluetun-webui deben estar en la misma red Docker para que `http://gluetun:8000` se resuelva correctamente.

**Mismo archivo compose** — solo agregue ambos servicios a la misma red (lo más común):

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

**Archivos de composición separados** — referencia la red existente de Gluetun como externa. Encuentra el nombre de tu red con `docker network ls`:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## Soporte Multi-VPN

### Múltiples Instancias

gluetun-webui soporta la supervisión y control de **múltiples instancias de Gluetun simultáneamente**. Cada instancia se muestra como un panel separado en una cuadrícula adaptable.

**Configuración**: Use variables de entorno numeradas:

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

**Soportado**: Hasta 20 instancias (a través de `GLUETUN_1_URL` hasta `GLUETUN_20_URL`)  
**Adaptable**: 1 panel de ancho completo → 2 de medio ancho → 3 de un tercio de ancho → 4 de un cuarto de ancho → desplazable a partir de 5+

### Compatibilidad hacia atrás

Si no se configuran variables numeradas, vuelve al **modo heredado de instancia única**:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### Autenticación por Instancia

Cada instancia puede tener una autenticación diferente:

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

## Configuración

| Variable | Predeterminado | Descripción |
|---|---|---|
| `GLUETUN_1_*` a `GLUETUN_20_*` | _(vacío)_ | **Configuración multi-instancia** (hasta 20 instancias) |
| `GLUETUN_{N}_URL` | – | URL del servidor de control HTTP de Gluetun para la instancia N |
| `GLUETUN_{N}_NAME` | `Instancia {N}` | Nombre para mostrar de la instancia N |
| `GLUETUN_{N}_API_KEY` | _(vacío)_ | Token Bearer para la instancia N (si la autenticación está habilitada) |
| `GLUETUN_{N}_USER` | _(vacío)_ | Nombre de usuario para autenticación HTTP Basic (instancia N) |
| `GLUETUN_{N}_PASSWORD` | _(vacío)_ | Contraseña para autenticación HTTP Basic (instancia N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **Legado** – solo instancia única (recurso si no hay variables `GLUETUN_1_*`) |
| `GLUETUN_API_KEY` | _(vacío)_ | **Legado** – Token Bearer para instancia única |
| `GLUETUN_USER` | _(vacío)_ | **Legado** – Nombre de usuario para autenticación HTTP Basic |
| `GLUETUN_PASSWORD` | _(vacío)_ | **Legado** – Contraseña para autenticación HTTP Basic |
| `PORT` | `3000` | Puerto en el que escucha la interfaz web |
| `TRUST_PROXY` | `false` | Establecer a `true` si se ejecuta detrás de un proxy inverso (nginx, Traefik, etc.) |

---

## Seguridad

- El puerto está vinculado a `127.0.0.1` — no expuesto a la red
- El contenedor se ejecuta como no-root con sistema de archivos de solo lectura y capacidades reducidas
- Limitación de tasa aplicada a todas las rutas API
- Detalles de errores upstream se registran solo en el servidor — mensajes genéricos se devuelven al navegador

### Configuración del proxy inverso

Si ejecuta gluetun-webui detrás de un proxy inverso (nginx, Traefik, Caddy, etc.), establezca `TRUST_PROXY=true` en sus variables de entorno:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

Esto permite que la aplicación analice correctamente `X-Forwarded-For` y encabezados relacionados para una limitación de tasa y detección de IP precisas. **Nota:** Solo habilítelo si realmente está detrás de un proxy inverso, ya que confía en los encabezados del proxy de su proxy inverso.

### Autenticación del proxy inverso

Los controles de inicio/parada de la VPN no tienen autenticación incorporada. Si expone la interfaz de usuario más allá de localhost, colóquela detrás de un proxy inverso con autenticación HTTP básica.

**Caddy** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
Generar un hash con: `caddy hash-password`

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
Generar un archivo de contraseña con: `htpasswd -c /etc/nginx/.htpasswd user`

**Traefik** (etiquetas de Docker):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
Generar un hash con: `htpasswd -nb user password`

---

## Agradecimientos

- **[Gluetun](https://github.com/qdm12/gluetun)** — El contenedor cliente VPN para el que se creó esta interfaz web  
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — Excelente herramienta de monitoreo para usar con esta interfaz web  
- **Desarrollo asistido por IA** — Este proyecto fue desarrollado con asistencia de IA

---

## Licencia

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---