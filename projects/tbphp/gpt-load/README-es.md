# GPT-Load

中文文档 | [English](https://raw.githubusercontent.com/tbphp/gpt-load/main/README_EN.md)

[![Release](https://img.shields.io/github/v/release/tbphp/gpt-load)](https://github.com/tbphp/gpt-load/releases)
![Go Version](https://img.shields.io/badge/Go-1.23+-blue.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

Un servicio de proxy transparente de interfaz de IA de alto rendimiento y nivel empresarial, diseñado específicamente para empresas y desarrolladores que necesitan integrar múltiples servicios de IA. Desarrollado en Go, cuenta con gestión inteligente de claves, balanceo de carga y funciones de monitoreo completas, diseñado para entornos de producción con alta concurrencia.

Para más detalles, consulte la [documentación oficial](https://www.gpt-load.com/docs)

<a href="https://hellogithub.com/repository/tbphp/gpt-load" target="_blank"><img src="https://api.hellogithub.com/v1/widgets/recommend.svg?rid=554dc4c46eb14092b9b0c56f1eb9021c&claim_uid=Qlh8vzrWJ0HCneG" alt="Featured｜HelloGitHub" style="width: 250px; height: 54px;" width="250" height="54" /></a>

## Características

- **Proxy transparente**: Conserva completamente el formato nativo de la API, soporta múltiples formatos como OpenAI, Google Gemini y Anthropic Claude
- **Gestión inteligente de claves**: Piscina de claves de alto rendimiento, soporta gestión por grupos, rotación automática y recuperación ante fallos
- **Balanceo de carga**: Soporta balanceo de carga ponderado para múltiples puntos finales ascendentes, mejorando la disponibilidad del servicio
- **Manejo inteligente de fallos**: Gestión automática de lista negra de claves y mecanismos de recuperación, asegurando la continuidad del servicio
- **Configuración dinámica**: La configuración del sistema y de grupos soporta recarga en caliente, aplicándose sin reinicio
- **Arquitectura empresarial**: Despliegue maestro-esclavo distribuido, soporta escalabilidad horizontal y alta disponibilidad
- **Gestión moderna**: Interfaz web de gestión basada en Vue 3, intuitiva y fácil de usar
- **Monitoreo completo**: Estadísticas en tiempo real, chequeo de salud, registros detallados de solicitudes
- **Diseño de alto rendimiento**: Transmisión en flujo sin copias, reutilización de pool de conexiones, operaciones atómicas
- **Listo para producción**: Cierre elegante, recuperación de errores, mecanismos de seguridad completos
- **Sistema de autenticación dual**: Autenticación separada para el panel de gestión y el proxy, autenticación proxy soporta claves a nivel global y por grupo

## Servicios de IA soportados

GPT-Load como servicio de proxy transparente, preserva completamente el formato nativo de API de cada proveedor de servicios de IA:

- **Formato OpenAI**: API oficial de OpenAI, Azure OpenAI, y otros servicios compatibles con OpenAI
- **Formato Google Gemini**: APIs nativas de modelos como Gemini Pro, Gemini Pro Vision, etc.
- **Formato Anthropic Claude**: Modelos de la serie Claude, soportando diálogos y generación de texto de alta calidad

## Inicio rápido

### Requisitos del entorno

- Go 1.23+ (construcción desde código fuente)  
- Docker (despliegue en contenedores)  
- MySQL, PostgreSQL o SQLite (almacenamiento de base de datos)  
- Redis (caché y coordinación distribuida, opcional)  

### Método 1: Inicio rápido con Docker

```bash
docker run -d --name gpt-load \
    -p 3001:3001 \
    -e AUTH_KEY=sk-123456 \
    -v "$(pwd)/data":/app/data \
    ghcr.io/tbphp/gpt-load:latest
```

> Usar `sk-123456` para iniciar sesión en la interfaz de administración: <http://localhost:3001>

### Método 2: Usar Docker Compose (recomendado)

**Comando de instalación:**

```bash
# 创建目录
mkdir -p gpt-load && cd gpt-load

# 下载配置文件
wget https://raw.githubusercontent.com/tbphp/gpt-load/refs/heads/main/docker-compose.yml
wget -O .env https://raw.githubusercontent.com/tbphp/gpt-load/refs/heads/main/.env.example

# 启动服务
docker compose up -d
```

La versión predeterminada instalada es SQLite, adecuada para aplicaciones ligeras de un solo equipo.

Si necesita instalar MySQL, PostgreSQL y Redis, descomente los servicios requeridos en el archivo `docker-compose.yml` y configure el entorno correspondiente antes de reiniciar.

**Otros comandos:**

```bash
# 查看服务状态
docker compose ps

# 查看日志
docker compose logs -f

# 重启服务
docker compose down && docker compose up -d

# 更新到最新版本
docker compose pull && docker compose down && docker compose up -d
```

Después del despliegue:

- Acceda a la interfaz de administración web: <http://localhost:3001>
- Dirección del proxy API: <http://localhost:3001/proxy>

> Inicie sesión en el panel de administración usando la clave de autenticación predeterminada `sk-123456`. La clave de autenticación se puede modificar en el archivo .env en AUTH_KEY.

### Método 3: Construcción desde el código fuente

La construcción desde el código fuente requiere tener instalada localmente una base de datos (SQLite, MySQL o PostgreSQL) y Redis (opcional).

```bash
# 克隆并构建
git clone https://github.com/tbphp/gpt-load.git
cd gpt-load
go mod tidy

# 创建配置
cp .env.example .env

# 修改 .env 中 DATABASE_DSN 和 REDIS_DSN 配置
# REDIS_DSN 为可选，如果不配置则启用内存存储

# 运行
make run
```

Después del despliegue:

- Acceda a la interfaz web de administración: <http://localhost:3001>
- Dirección del proxy API: <http://localhost:3001/proxy>

> Use la clave de autenticación predeterminada `sk-123456` para iniciar sesión en el panel de administración, la clave de autenticación se puede modificar en .env en AUTH_KEY.

### Método cuatro: Despliegue en clúster

El despliegue en clúster requiere que todos los nodos estén conectados a la misma base de datos MySQL (o PostgreSQL) y Redis, siendo Redis obligatorio. Se recomienda usar un clúster unificado de MySQL distribuido y Redis.

**Requisitos de despliegue:**

- Todos los nodos deben configurar el mismo `AUTH_KEY`, `DATABASE_DSN`, `REDIS_DSN`
- Arquitectura maestro-esclavo, los nodos esclavos deben configurar la variable de entorno: `IS_SLAVE=true`

Para más detalles, consulte la [documentación de despliegue en clúster](https://www.gpt-load.com/docs/cluster)

## Configuración del sistema

### Resumen de la arquitectura de configuración

GPT-Load utiliza una arquitectura de configuración de dos niveles:

#### 1. Configuración estática (variables de entorno)

- **Características**: Leída al iniciar la aplicación, no modificable en tiempo de ejecución, requiere reiniciar la aplicación para que surta efecto
- **Uso**: Configuración de infraestructura, como conexión a base de datos, puerto del servidor, clave de autenticación, etc.
- **Modo de gestión**: Se establece mediante archivos `.env` o variables de entorno del sistema

#### 2. Configuración dinámica (recarga en caliente)

- **Configuración del sistema**: Almacenada en la base de datos, proporciona un estándar de comportamiento unificado para toda la aplicación
- **Configuración por grupo**: Parámetros de comportamiento personalizados para grupos específicos, pueden sobrescribir la configuración del sistema
- **Prioridad de configuración**: Configuración por grupo > Configuración del sistema > Configuración de entorno
- **Características**: Soporta recarga en caliente, los cambios se aplican inmediatamente sin necesidad de reiniciar la aplicación

<details>
<summary>Configuración estática (variables de entorno)</summary>

**Configuración del servidor:**

| Elemento de configuración | Variable de entorno               | Valor predeterminado | Descripción                 |
| ------------------------- | -------------------------------- | -------------------- | -------------------------- |
| Puerto del servidor       | `PORT`                           | 3001                 | Puerto de escucha del servidor HTTP |
| Dirección del servidor    | `HOST`                           | 0.0.0.0              | Dirección de enlace del servidor HTTP |
| Tiempo de lectura         | `SERVER_READ_TIMEOUT`            | 60                   | Tiempo de espera de lectura del servidor HTTP (segundos) |
| Tiempo de escritura       | `SERVER_WRITE_TIMEOUT`           | 600                  | Tiempo de espera de escritura del servidor HTTP (segundos) |
| Tiempo de inactividad     | `SERVER_IDLE_TIMEOUT`            | 120                  | Tiempo de espera de inactividad de la conexión HTTP (segundos) |
| Tiempo de cierre elegante | `SERVER_GRACEFUL_SHUTDOWN_TIMEOUT` | 10                   | Tiempo de espera para cierre elegante del servicio (segundos) |
| Modo esclavo              | `IS_SLAVE`                      | false                | Identificador de nodo esclavo en despliegue en clúster |
| Zona horaria              | `TZ`                            | `Asia/Shanghai`      | Zona horaria especificada     |

**Configuración de autenticación y base de datos:**

| Elemento de configuración | Variable de entorno       | Valor predeterminado | Descripción                               |
| ------------------------- | ------------------------ | -------------------- | ---------------------------------------- |
| Clave de administración   | `AUTH_KEY`               | `sk-123456`          | Clave de autenticación para el **panel de administración** |
| Conexión a base de datos  | `DATABASE_DSN`           | ./data/gpt-load.db   | Cadena de conexión (DSN) o ruta del archivo de base de datos |
| Conexión Redis            | `REDIS_DSN`              | -                    | Cadena de conexión Redis, si está vacía se usa almacenamiento en memoria |

**Configuración de rendimiento y CORS:**

| Elemento de configuración | Variable de entorno           | Valor predeterminado          | Descripción                     |
| ------------------------- | ---------------------------- | ----------------------------- | ------------------------------ |
| Máximo de solicitudes concurrentes | `MAX_CONCURRENT_REQUESTS` | 100                           | Número máximo permitido de solicitudes concurrentes |
| Habilitar CORS            | `ENABLE_CORS`                | true                          | Si se habilita el intercambio de recursos de origen cruzado (CORS) |
| Orígenes permitidos       | `ALLOWED_ORIGINS`            | `*`                           | Orígenes permitidos, separados por comas |
| Métodos permitidos        | `ALLOWED_METHODS`            | `GET,POST,PUT,DELETE,OPTIONS` | Métodos HTTP permitidos         |
| Cabeceras permitidas      | `ALLOWED_HEADERS`            | `*`                           | Cabeceras permitidas, separadas por comas |
| Permitir credenciales     | `ALLOW_CREDENTIALS`          | false                         | Si se permite enviar credenciales |

**Configuración de registro:**

| Elemento de configuración | Variable de entorno       | Valor predeterminado | Descripción                               |
| ------------------------- | ------------------------ | -------------------- | ---------------------------------------- |
| Nivel de registro         | `LOG_LEVEL`              | `info`               | Nivel de registro: debug, info, warn, error |
| Formato de registro       | `LOG_FORMAT`             | `text`               | Formato de registro: text, json           |
| Habilitar registro en archivo | `LOG_ENABLE_FILE`        | false                | Si se habilita la salida de registro en archivo |
| Ruta del archivo de registro | `LOG_FILE_PATH`   | `./data/logs/app.log` | Ruta de almacenamiento del archivo de registro                   |

**Configuración del proxy:**

GPT-Load leerá automáticamente la configuración del proxy desde las variables de entorno para realizar solicitudes a proveedores de servicios de IA ascendentes.

| Elemento de configuración | Variable de entorno | Valor predeterminado | Descripción                                  |
| ------------------------- | ------------------ | ------------------- | -------------------------------------------- |
| Proxy HTTP                | `HTTP_PROXY`       | -                   | Dirección del servidor proxy para solicitudes HTTP           |
| Proxy HTTPS               | `HTTPS_PROXY`      | -                   | Dirección del servidor proxy para solicitudes HTTPS          |
| Sin proxy                 | `NO_PROXY`         | -                   | Hosts o dominios que no requieren proxy, separados por comas  |

Formatos de protocolo de proxy soportados:

- **HTTP**: `http://user:pass@host:port`
- **HTTPS**: `https://user:pass@host:port`
- **SOCKS5**: `socks5://user:pass@host:port`
</details>

<details>
<summary>Configuración dinámica (recarga en caliente)</summary>

**Configuración básica:**

| Elemento de configuración | Nombre del campo                  | Valor predeterminado          | Sobrescritura por grupo | Descripción                             |
| ------------------------- | -------------------------------- | ---------------------------- | ---------------------- | -------------------------------------- |
| Dirección del proyecto    | `app_url`                        | `http://localhost:3001`      | ❌                     | URL base del proyecto                   |
| Días de retención de logs | `request_log_retention_days`      | 7                            | ❌                     | Días de retención de logs de solicitudes, 0 para no limpiar |
| Intervalo de escritura de logs | `request_log_write_interval_minutes` | 1                            | ❌                     | Periodo para escribir logs en la base de datos (minutos) |
| Clave global de proxy     | `proxy_keys`                     | Valor inicial de AUTH_KEY en entorno | ❌                     | Clave de autenticación proxy global, múltiples separadas por comas |

**Configuración de solicitudes:**

| Elemento de configuración | Nombre del campo           | Valor predeterminado | Sobrescritura por grupo | Descripción                                |
| ------------------------- | -------------------------- | ------------------- | ---------------------- | ------------------------------------------ |
| Tiempo de espera de la solicitud | `request_timeout`         | 600                 | ✅                     | Tiempo de espera total para la solicitud (segundos) |
| Tiempo de conexión        | `connect_timeout`          | 15                  | ✅                     | Tiempo de espera para establecer conexión con el servicio ascendente (segundos) |
| Tiempo de espera de conexión inactiva | `idle_conn_timeout`        | 120                 | ✅                     | Tiempo de espera para conexiones HTTP inactivas (segundos) |
| Tiempo de espera para encabezado de respuesta | `response_header_timeout`  | 600                 | ✅                     | Tiempo de espera para recibir encabezado de respuesta (segundos) |
| Máximo número de conexiones inactivas | `max_idle_conns`           | 100                 | ✅                     | Número máximo de conexiones inactivas en el pool |
| Número máximo de conexiones inactivas por host | `max_idle_conns_per_host` | 50     | ✅         | Número máximo de conexiones inactivas por cada host ascendente     |
| Dirección del servidor proxy       | `proxy_url`               | -      | ✅         | Proxy HTTP/HTTPS para reenviar solicitudes, si está vacío usa la configuración del entorno |

**Configuración de claves:**

| Elemento de configuración         | Nombre del campo                   | Valor por defecto | Sobrescribible por grupo | Descripción                                      |
| -------------------------------- | -------------------------------- | ----------------- | ------------------------ | ------------------------------------------------ |
| Número máximo de reintentos       | `max_retries`                    | 3                 | ✅                       | Número máximo de reintentos con diferentes claves para una solicitud |
| Umbral de lista negra             | `blacklist_threshold`            | 3                 | ✅                       | Número de fallos consecutivos para que una clave entre en lista negra |
| Intervalo de validación de clave | `key_validation_interval_minutes` | 60                | ✅                       | Periodicidad en minutos para la validación periódica de claves en segundo plano |
| Concurrencia de validación de clave | `key_validation_concurrency`      | 10                | ✅                       | Número de validaciones concurrentes para claves inválidas en segundo plano |
| Tiempo de espera para validación | `key_validation_timeout_seconds`  | 20                | ✅                       | Tiempo máximo en segundos para la solicitud API al validar una clave en segundo plano |

</details>

## Interfaz de gestión web

Acceda a la consola de administración: <http://localhost:3001> (dirección predeterminada)

### Visualización de la interfaz

<img src="https://raw.githubusercontent.com/tbphp/gpt-load/main/screenshot/dashboard.png" alt="Panel de control" width="600" />

<br/>

<img src="https://raw.githubusercontent.com/tbphp/gpt-load/main/screenshot/keys.png" alt="Gestión de claves" width="600" />

<br/>

La interfaz de gestión web ofrece las siguientes funcionalidades:

- **Panel de control**: Estadísticas en tiempo real y vista general del estado del sistema
- **Gestión de claves**: Crear y configurar grupos de proveedores de IA, añadir, eliminar y monitorizar claves API
- **Registro de solicitudes**: Historial detallado de solicitudes e información para depuración
- **Configuración del sistema**: Gestión de configuración global y recarga en caliente

## Instrucciones de uso de la API

<details>
<summary>Método de llamada a la interfaz proxy</summary>

GPT-Load enruta solicitudes a diferentes servicios de IA mediante nombres de grupo. La forma de uso es la siguiente:

#### 1. Formato del punto de acceso proxy

```text
http://localhost:3001/proxy/{group_name}/{原始API路径}
```

- `{group_name}`: Nombre del grupo creado en la interfaz de administración
- `{原始API路径}`: Mantener la ruta exactamente igual que el servicio AI original

#### 2. Método de autenticación

Configurar las **claves proxy** (`Proxy Keys`) en la interfaz web de administración, se pueden establecer claves proxy a nivel de sistema y a nivel de grupo.

- **Método de autenticación**: Igual que la API nativa, pero la clave original debe ser reemplazada por la clave proxy configurada.
- **Ámbito de la clave**: Las **claves proxy globales** configuradas en la configuración del sistema pueden usarse en todos los grupos, mientras que las **claves proxy de grupo** configuradas en cada grupo solo son válidas para ese grupo.
- **Formato**: Múltiples claves separadas por comas en inglés.

#### 3. Ejemplo de llamada a la interfaz OpenAI

Supongamos que se creó un grupo llamado `openai`:

**Modo de llamada original:**

```bash
curl -X POST https://api.openai.com/v1/chat/completions \
  -H "Authorization: Bearer sk-your-openai-key" \
  -H "Content-Type: application/json" \
  -d '{"model": "gpt-4.1-mini", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Modo de llamada del agente:**

```bash
curl -X POST http://localhost:3001/proxy/openai/v1/chat/completions \
  -H "Authorization: Bearer your-proxy-key" \
  -H "Content-Type: application/json" \
  -d '{"model": "gpt-4.1-mini", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Notas de cambio:**

- Reemplazar `https://api.openai.com` por `http://localhost:3001/proxy/openai`
- Reemplazar la clave API original por la **clave del proxy**

#### 4. Ejemplo de llamada a la interfaz Gemini

Supongamos que se creó un grupo llamado `gemini`:

**Modo de llamada original:**

```bash
curl -X POST https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-pro:generateContent?key=your-gemini-key \
  -H "Content-Type: application/json" \
  -d '{"contents": [{"parts": [{"text": "Hello"}]}]}'
```

**Método de llamada proxy:**

```bash
curl -X POST http://localhost:3001/proxy/gemini/v1beta/models/gemini-2.5-pro:generateContent?key=your-proxy-key \
  -H "Content-Type: application/json" \
  -d '{"contents": [{"parts": [{"text": "Hello"}]}]}'
```

**Notas de cambios:**

- Reemplazar `https://generativelanguage.googleapis.com` por `http://localhost:3001/proxy/gemini`
- Reemplazar el parámetro URL `key=your-gemini-key` por **clave de proxy**

#### 5. Ejemplo de llamada a la interfaz Anthropic

Supongamos que se creó un grupo llamado `anthropic`:

**Método de llamada original:**

```bash
curl -X POST https://api.anthropic.com/v1/messages \
  -H "x-api-key: sk-ant-api03-your-anthropic-key" \
  -H "anthropic-version: 2023-06-01" \
  -H "Content-Type: application/json" \
  -d '{"model": "claude-sonnet-4-20250514", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Modo de llamada del agente:**

```bash
curl -X POST http://localhost:3001/proxy/anthropic/v1/messages \
  -H "x-api-key: your-proxy-key" \
  -H "anthropic-version: 2023-06-01" \
  -H "Content-Type: application/json" \
  -d '{"model": "claude-sonnet-4-20250514", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Notas de cambio:**

- Reemplazar `https://api.anthropic.com` por `http://localhost:3001/proxy/anthropic`
- Reemplazar la clave API original en el encabezado `x-api-key` por la **clave del proxy**

#### 6. Interfaces soportadas

**Formato OpenAI:**

- `/v1/chat/completions` - Conversación de chat
- `/v1/completions` - Completado de texto
- `/v1/embeddings` - Incrustaciones de texto
- `/v1/models` - Lista de modelos
- Y todas las demás interfaces compatibles con OpenAI

**Formato Gemini:**

- `/v1beta/models/*/generateContent` - Generación de contenido
- `/v1beta/models` - Lista de modelos
- Y todas las demás interfaces nativas de Gemini

**Formato Anthropic:**

- `/v1/messages` - Conversación de mensajes
- `/v1/models` - Lista de modelos (si está disponible)
- Y todas las demás interfaces nativas de Anthropic

#### 7. Configuración del SDK del cliente

**SDK de OpenAI para Python:**

```python
from openai import OpenAI

client = OpenAI(
    api_key="your-proxy-key",  # 使用密钥
    base_url="http://localhost:3001/proxy/openai"  # 使用代理端点
)

response = client.chat.completions.create(
    model="gpt-4.1-mini",
    messages=[{"role": "user", "content": "Hello"}]
)
```

**Google Gemini SDK (Python)：**

```python
import google.generativeai as genai

# 配置 API 密钥和基础 URL
genai.configure(
    api_key="your-proxy-key",  # 使用代理密钥
    client_options={"api_endpoint": "http://localhost:3001/proxy/gemini"}
)

model = genai.GenerativeModel('gemini-2.5-pro')
response = model.generate_content("Hello")
```

**SDK de Anthropic (Python)：**

```python
from anthropic import Anthropic

client = Anthropic(
    api_key="your-proxy-key",  # 使用代理密钥
    base_url="http://localhost:3001/proxy/anthropic"  # 使用代理端点
)

response = client.messages.create(
    model="claude-sonnet-4-20250514",
    messages=[{"role": "user", "content": "Hello"}]
)
```

> **Aviso importante**: Como servicio de proxy transparente, GPT-Load conserva completamente el formato de API nativo y el método de autenticación de cada servicio de IA, solo necesita reemplazar la dirección del endpoint y usar la **clave proxy** configurada en el panel de administración para una migración sin problemas.

</details>

## Licencia

Licencia MIT - Para más detalles, consulte el archivo [LICENSE](LICENSE).

## Historial de estrellas

[![Stargazers over time](https://starchart.cc/tbphp/gpt-load.svg?variant=adaptive)](https://starchart.cc/tbphp/gpt-load)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---