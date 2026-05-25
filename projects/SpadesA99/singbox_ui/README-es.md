# Sing-box UI

**[English](https://raw.githubusercontent.com/SpadesA99/singbox_ui/main/README_EN.md) | 中文**

<div align="center">

[![Docker Image](https://img.shields.io/badge/ghcr.io-singbox__ui-blue?logo=docker)](https://github.com/SpadesA99/singbox_ui/pkgs/container/singbox_ui)
[![Build Status](https://github.com/SpadesA99/singbox_ui/actions/workflows/docker-build.yml/badge.svg)](https://github.com/SpadesA99/singbox_ui/actions)
[![GitHub Stars](https://img.shields.io/github/stars/SpadesA99/singbox_ui?style=flat&logo=github)](https://github.com/SpadesA99/singbox_ui/stargazers)
[![License](https://img.shields.io/github/license/SpadesA99/singbox_ui)](LICENSE)

**Herramienta moderna de gestión de configuraciones sing-box**

Construido con Go 1.24 + Next.js 16, gestionado mediante contenedores Docker

</div>

![Captura de pantalla de la interfaz Sing-box UI](https://raw.githubusercontent.com/SpadesA99/singbox_ui/main/docs/zh.png)

---

## Funciones principales

### Soporte de protocolos

| Protocolos de entrada | Protocolos de salida | Análisis de suscripción |
|-----------------------|---------------------|------------------------|
| WireGuard             | Todos los protocolos de entrada | VMess              |
| Mixto (Socks5+HTTP)   | direct (conexión directa)        | VLESS              |
| VLESS                 | block (bloqueo)                  | Trojan             |
| VMess                 |                                 | Shadowsocks        |
| Trojan                |                                 | AnyTLS             |
| Shadowsocks           |                                 | Formato Clash YAML |
| Hysteria2             |                                 |                    |
| TUIC                  |                                 |                    |
| Naive                 |                                 |                    |
| ShadowTLS             |                                 |                    |
| AnyTLS                 |                                 |                    |
| HTTP                  |                                 |                    |

### Gestión de certificados TLS

- **Certificados automáticos ACME**: Soporte para solicitud y renovación automática con Let's Encrypt  
- **Certificados manuales**: Soporte para subir archivos de certificados propios  
- **Soporte multi-protocolo**: Protocolos TLS como VLESS, VMess, Trojan, Hysteria2, todos soportan ACME  

### Configuración de reglas de enrutamiento

- **Plantillas rápidas**: Activación con un clic de reglas comunes (bloqueo de anuncios, conexión directa a IP/dominios chinos, conexión directa a IP privadas)  
- **Añadir reglas rápidamente**: Soporte para agregar rápido IPs o dominios a listas de conexión directa/proxy/bloqueo  
- **Modo conexión directa**: Configuración automática a modo conexión directa cuando no hay salida proxy  

### Balanceo de carga

- **Modo URLTest**: Basado en salida `urltest` de sing-box, selecciona automáticamente el nodo con menor latencia  
- **Tolerancia configurable**: Valor de tolerancia de latencia personalizable (50 ms por defecto) para evitar cambios frecuentes  
- **Pool dinámico de nodos**: Selección flexible de múltiples nodos desde suscripciones para formar grupo de balanceo  
- **Enrutamiento inteligente**: Generación automática de reglas para distribución inteligente del tráfico  

### Gestión de múltiples instancias

- Soporte para crear múltiples instancias sing-box con nombre  
- Cada instancia con configuración, inicio y parada independientes  
- Logs y monitoreo de estado independientes por contenedor  

### Gestión VPN WireGuard

- Generación de claves Curve25519  
- Caché de claves vinculadas a IP  
- Gestión de configuración cliente (generación masiva, códigos QR, descarga de configuración)  

### Salida Cloudflare WARP

- **Registro con un clic**: Generación automática de par de claves Curve25519 y llamada API de registro Cloudflare, caché local del token del dispositivo, sin configuración manual  
- **Vinculación WARP+**: Soporte para ingresar licencia y vincular cuenta WARP+ para obtener tráfico ilimitado  
- **Selección de endpoint óptima**: Detección real de handshake WireGuard — envío de paquete inicial WG a `IP:Puerto` candidatos, verificación de respuesta de 92 bytes `MessageResponse`, ordenado por tasa de pérdida + RTT promedio para reflejar con precisión la calidad de ruta UDP (referencia [CloudflareWarpSpeedTest](https://github.com/peanut996/CloudflareWarpSpeedTest))  
- **Escaneo de amplia cobertura**: 8 segmentos Cloudflare /24 × 54 puertos UDP WARP conocidos, detección concurrente y muestreo aleatorio para encontrar rápidamente el nodo de borde más rápido  

### Detección de salud de nodos

- Detección concurrente asincrónica en múltiples nodos  
- Estadísticas de tasa de éxito con ventana deslizante  
- Obtención de resultados de detección mediante sondeo API  

### Funciones de gestión  

- Vista previa de configuración (editor JSON)  
- Visualización de registros del contenedor  
- Monitoreo del estado del contenedor  

---  

## Comenzar rápido  

### Docker Compose (recomendado)  

Crear `docker-compose.yml`:

```yaml
services:
  singbox-ui:
    image: ghcr.io/spadesa99/singbox_ui:latest
    container_name: singbox-ui
    restart: unless-stopped
    network_mode: host
    volumes:
      - /var/run/docker.sock:/var/run/docker.sock
      - ./data:/home/data
    environment:
      - DATA_DIR=/home/data
      - HOST_DATA_DIR=${PWD}/data
      - LISTEN_ADDR=127.0.0.1:7000
      - TZ=Asia/Shanghai
```

```bash
docker compose up -d
```

Acceder a http://127.0.0.1:7000

> **Nota**:
> - Use `network_mode: host` para que el contenedor utilice directamente la red del host
> - Escucha por defecto en `127.0.0.1:7000`, acceso local únicamente, puede personalizarse con la variable de entorno `LISTEN_ADDR`
> - Monta el Docker Socket para gestionar el contenedor sing-box
> - `HOST_DATA_DIR` se mapea automáticamente al directorio de datos del host mediante `${PWD}`, para montar en el contenedor sing-box
> - Imagen incorporada de sing-box v1.13.5, se carga automáticamente en el primer inicio, sin necesidad de descarga en línea

### Acceso remoto

El servicio escucha por defecto solo en `127.0.0.1`, se recomienda acceder de forma segura mediante un túnel SSH:

```bash
ssh -L 7000:127.0.0.1:7000 user@your-server
```
Luego acceda en el navegador local a http://127.0.0.1:7000

> **Consejo de seguridad**: No se recomienda cambiar `LISTEN_ADDR` a `0.0.0.0:7000` para exponerlo directamente a la red pública, el panel de administración no tiene protección de autenticación. Para acceso externo, utilice túnel SSH o configure un proxy inverso con autenticación (como Nginx + Basic Auth).

---

## Variables de entorno

| Variable | Descripción | Valor por defecto |
|----------|-------------|-------------------|
| `DATA_DIR` | Directorio de datos dentro del contenedor | `/home/data` |
| `HOST_DATA_DIR` | Directorio de datos en el host (para montar en el contenedor sing-box) | `${PWD}/data` |
| `LISTEN_ADDR` | Dirección de escucha del servicio | `127.0.0.1:7000` |
| `TZ` | Zona horaria | `Asia/Shanghai` |

---

## Stack tecnológico

| Frontend | Backend |
|----------|---------|
| Next.js 16 | Go 1.24 |
| React 19 | Gin 1.11 |
| Tailwind CSS | Docker SDK |
| shadcn/ui | |

---

## Licencia

[Licencia MIT](LICENSE)

## Historial de estrellas

[![Gráfico de historial de estrellas](https://api.star-history.com/svg?repos=SpadesA99/singbox_ui&type=Date)](https://star-history.com/#SpadesA99/singbox_ui&Date)

## Agradecimientos

- [sing-box](https://github.com/SagerNet/sing-box)

- [Next.js](https://nextjs.org/)
- [Gin](https://github.com/gin-gonic/gin)
- [shadcn/ui](https://ui.shadcn.com/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---