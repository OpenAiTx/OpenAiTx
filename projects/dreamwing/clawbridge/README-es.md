<div align="center">
  <img src="https://raw.githubusercontent.com/dreamwing/clawbridge/master/public/app-icon.png" width="120" alt="ClawBridge Logo" />
  <h1>Panel de Control ClawBridge</h1>
  <p><strong>El Panel de Control Móvil y Centro de Misión de OpenClaw.</strong></p>

  <a href="https://clawbridge.app">
    <img src="https://img.shields.io/badge/Website-clawbridge.app-3b82f6?style=for-the-badge&logo=google-chrome&logoColor=white" alt="Website" />
  </a>
  <a href="https://github.com/openclaw/openclaw">
    <img src="https://img.shields.io/badge/OpenClaw-Compatible-22c55e?style=for-the-badge&logo=robot-framework&logoColor=white" alt="OpenClaw" />
  </a>
  <a href="LICENSE">
    <img src="https://img.shields.io/badge/License-MIT-fab005?style=for-the-badge" alt="License" />
  </a>
  
  <br/><br/>
  [ <strong>English</strong> | <a href="README_CN.md">简体中文</a> ]
</div>

---

**ClawBridge** es el **Panel de Control Móvil** definitivo para agentes OpenClaw. Funciona como tu **Centro de Misión** de bolsillo: monitorea pensamientos en tiempo real, rastrea costos de tokens y administra tareas en segundo plano desde cualquier lugar, de forma segura e instantánea.

## ✨ Características Clave

*   **📱 Panel Móvil Primero**: Optimizado para pantallas de teléfono. Visualiza registros, estadísticas y controles sin forzar la vista.
*   **🧠 Feed de Actividad en Vivo**: Observa a tu agente "pensar" y ejecutar herramientas en tiempo real. Incluye registro paralelo inteligente (sin tareas en segundo plano perdidas) y deduplicación.
*   **💰 Economía de Tokens**: Rastrea costos y tendencias de uso diarios/mensuales de LLM. Conoce exactamente a dónde va tu dinero.
*   **🔍 [Centro de Control de Costos](https://raw.githubusercontent.com/dreamwing/clawbridge/master/docs/cost-control-center.md)**: 10 diagnósticos automáticos que escanean tu uso, calculan ahorros y te permiten aplicar optimizaciones con un solo toque. Reduce costos de API entre 30–90%.
*   **📜 Línea de Tiempo de Memoria**: Navega los diarios diarios de tu agente y la evolución de la memoria a largo plazo.
*   **🚀 Centro de Misión**: Activa trabajos cron, reinicia servicios o detén scripts descontrolados directamente desde la interfaz.
*   **⚡ Remoto Sin Configuración**: 
    *   **Auto-Puerto**: Encuentra automáticamente un puerto disponible si el 3000 está ocupado.
    *   **Red Inteligente**: Detecta automáticamente **Tailscale/WireGuard** para acceso directo y seguro.
    *   **Túnel Rápido**: Si no se encuentra VPN, genera automáticamente una URL pública temporal vía Cloudflare (Sin Configuración).

## 🚀 Instalación

Ejecuta esta línea en tu servidor OpenClaw (Ubuntu/Debian):

```bash
curl -sL https://clawbridge.app/install.sh | bash
```

Eso es todo. El script hará:
1.  Detectar tu entorno (VPN o Público).
2.  Generar una Clave de Acceso segura.
3.  Proporcionarte una URL lista para usar.

## 📱 Uso

### 1. Acceso sin Configuración (Por Defecto)
Si solo quieres probarlo, el instalador proporciona una URL de **Túnel Rápido**:
`https://<nombre-aleatorio>.trycloudflare.com/?key=<TU_CLAVE>`

*   **Ventajas**: Acceso instantáneo desde cualquier lugar.
*   **Desventajas**: La URL cambia si reinicias el servicio.

### 2. Acceso Directo por VPN (Privacidad Primero)
Si se detecta **Tailscale** o **WireGuard**, el instalador omite el túnel público y te da un enlace privado:
`http://<IP_VPN>:3000/?key=<TU_CLAVE>`

*   **Ventajas**: Velocidad más rápida, máxima privacidad.
*   **Desventajas**: Tu teléfono debe estar conectado a la VPN.

### 3. Dominio Público Permanente (Avanzado)
¿Quieres una URL fija como `dash.tusitio.com`?
1.  Obtén un **Token de Túnel de Cloudflare** desde [Cloudflare Dash \> Networking \> Tunnels](https://dash.cloudflare.com/?to=/:account/tunnels).
2.  Ejecuta el instalador con el token:
    ```bash
    cd skills/clawbridge
    ./install.sh --token=<YOUR_TOKEN>
    ```
    *   O forzar un nuevo Quick Tunnel: `./install.sh --force-cf`
3.  Después de que la instalación sea exitosa, regrese a la página de **Nombre de Host Público** (o **Rutas**) del túnel de Cloudflare y haga clic en **Agregar un nombre de host público** para vincular su propio dominio a `localhost:3000` para acceso permanente.

### 4. Docker (Contenerizado)
Puede ejecutar ClawBridge como un contenedor Docker. Las imágenes se publican automáticamente en el [Registro de Contenedores de GitHub (ghcr.io)](https://github.com/dreamwing/clawbridge/pkgs/container/clawbridge).
```bash
docker pull ghcr.io/dreamwing/clawbridge:latest
docker run -d --name clawbridge \
  -p 3000:3000 \
  -e ACCESS_KEY=your_secret_key \
  -e OPENCLAW_STATE_DIR=/openclaw \
  -e OPENCLAW_WORKSPACE=/openclaw/workspace \
  -v ~/.openclaw:/openclaw:ro \
  -v ./data:/app/data \
  ghcr.io/dreamwing/clawbridge:latest
```

## 📱 Aplicación Móvil (PWA)
1.  Abre el panel de control en Safari (iOS) o Chrome (Android).
2.  Toca "Compartir" -> "Añadir a la pantalla de inicio".
3.  Iníciala como una app nativa (pantalla completa, sin barra del navegador).

## 🛠️ Tecnología Utilizada
*   **Backend**: Node.js (Express, WebSocket) - Proceso ligero sidecar.
*   **Frontend**: JS puro - Sin paso de compilación, carga instantánea.
*   **Túnel**: Cloudflared

## Créditos

Agradecimientos especiales a nuestra comunidad por ayudar a mejorar ClawBridge:
- [@yaochao](https://github.com/yaochao) por reportar problemas críticos de seguridad y portabilidad y sugerir refactorizaciones arquitectónicas (#1, #2, #3, #4, #5, #6, #7).
- [@斯图超哥](https://x.com/StewartLi666) por comentarios sobre compatibilidad con Linux, estabilidad en detección de IP y lógica de actualización rápida del túnel (#12).
- [@zjy4fun](https://github.com/zjy4fun) por valiosas contribuciones en la corrección de la detección del espacio de trabajo (PR #22).
- [@chrisuhg](https://github.com/chrisuhg) por valiosas contribuciones en la resolución de problemas de instalación y bucle de autenticación (Issue #19).
- [@ForceConstant](https://github.com/ForceConstant) por valiosas contribuciones en Solicitud de Funcionalidad: imágenes docker versionadas (#24) (Issue #24).

---
*Licencia MIT. Construido para la Comunidad OpenClaw.*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-14

---