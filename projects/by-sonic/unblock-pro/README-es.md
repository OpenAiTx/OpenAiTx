# UnblockPro — Desbloqueo de Discord y YouTube


<p align="center">
  <strong>Bypass automático de DPI para macOS y Windows</strong><br>
  Desbloquea Discord, YouTube y otros servicios con un solo clic
</p>

<p align="center">
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/v/release/by-sonic/unblock-pro?style=for-the-badge&color=blue&label=version" alt="Version"></a>
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/downloads/by-sonic/unblock-pro/total?style=for-the-badge&color=green&label=downloads" alt="Downloads"></a>
  <a href="https://github.com/by-sonic/unblock-pro/blob/main/LICENSE"><img src="https://img.shields.io/github/license/by-sonic/unblock-pro?style=for-the-badge&color=purple" alt="License"></a>
  <img src="https://img.shields.io/badge/platform-macOS%20%7C%20Windows-blue?style=for-the-badge" alt="Platform">
</p>

---

## Descargar

| Plataforma | Archivo | Descripción |
|-----------|---------|-------------|
| **macOS** Apple Silicon (M1/M2/M3/M4) | [UnblockPro-mac-arm64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | Para Mac con procesador M |
| **macOS** Intel | [UnblockPro-mac-x64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | Para Mac con Intel |
| **Windows** | [UnblockPro-win-setup.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | Instalador |
| **Windows** | [UnblockPro-win-portable.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | Versión portátil (sin instalación) |

> Visita [Releases](https://github.com/by-sonic/unblock-pro/releases/latest) y descarga la versión para tu sistema operativo

---

## ¿Qué es?

**UnblockPro** — aplicación de escritorio para evitar bloqueos DPI que permite usar Discord, YouTube y otros servicios sin VPN. Funciona en macOS y Windows.

### Funcionalidades clave

- **Un clic** — pulsa "Conectar" y todo funcionará
- **Selección automática de estrategia** — la aplicación encuentra el método de desbloqueo que funciona para tu proveedor
- **Verificación de conexión** — la estrategia se comprueba con una petición real, no por conjeturas
- **macOS + Windows** — soporte completo para ambas plataformas
- **Inicio automático** — se inicia junto con el sistema  
- **Conexión automática** — se conecta automáticamente al iniciar  
- **Bandeja del sistema** — funciona en segundo plano, no molesta  
- **Limpieza segura** — la configuración del proxy se restablece automáticamente al salir  

---

## Cómo funciona

UnblockPro utiliza la tecnología [zapret](https://github.com/bol-van/zapret) para evitar la inspección profunda de paquetes (DPI):

| Plataforma | Método |
|-----------|-------|
| **macOS** | `tpws` — proxy SOCKS5 con modificación de paquetes. La aplicación configura automáticamente el proxy del sistema |
| **Windows** | `winws` — intercepta paquetes a nivel de controlador mediante WinDivert. No requiere configuración de proxy |

La aplicación prueba secuencialmente varias estrategias (split+disorder, split-tls, methodeol, oob y otras), hasta encontrar una que funcione para su proveedor.

---

## Instalación

### macOS

1. Descargue `UnblockPro-*-mac.zip` desde [Releases](https://github.com/by-sonic/unblock-pro/releases/latest)  
2. Descomprima el ZIP y arrastre `UnblockPro.app` a la carpeta «Aplicaciones»  
3. **Abra la Terminal** y ejecute el comando:

```bash
xattr -cr /Applications/UnblockPro.app
```
4. Inicie la aplicación y haga clic en "Conectar"

> **¿Para qué sirve este comando?** macOS bloquea aplicaciones sin una firma de desarrollador Apple pagada ($99/año). El comando `xattr -cr` elimina la bandera de cuarentena — es seguro, el código del proyecto es completamente abierto. Funciona en Intel y Apple Silicon (M1/M2/M3).

### Windows

1. Descargue el instalador o la versión portátil desde [Releases](https://github.com/by-sonic/unblock-pro/releases/latest)
2. Ejecútelo como administrador
3. Haga clic en "Conectar"

> **Importante:** En Windows se requieren permisos de administrador para que WinDivert funcione

---

## Capturas de pantalla

<p align="center">
  <em>Pantalla principal — estado de conexión, control con un clic</em>
</p>

---

## FAQ

<details>
<summary><strong>¿Es una VPN?</strong></summary>
No. UnblockPro no cifra el tráfico ni lo enruta a través de un servidor remoto. Modifica los paquetes de red localmente para que los sistemas DPI del proveedor no puedan reconocer ni bloquear las solicitudes a Discord/YouTube.
</details>

<details>
<summary><strong>¿Es seguro?</strong></summary>
Sí. La aplicación es de código abierto, no recopila datos ni envía tráfico a través de servidores externos. Todo el código está disponible para auditoría.
</details>

<details>
<summary><strong>¿Qué pasa si la aplicación se bloquea?</strong></summary>
Las configuraciones proxy se restablecen automáticamente en cualquier cierre: normal, inesperado o por kill. En el próximo inicio, las configuraciones también se limpian por seguridad.
</details>


<details>
<summary><strong>Discord/YouTube aún no funciona</strong></summary>
Intente desconectarse y volver a conectarse: la aplicación probará otras estrategias. Si ninguna ayuda, es posible que su proveedor utilice DPI avanzado: cree un Issue.
</details>

<details>
<summary><strong>macOS: «el archivo no se abrió» / Gatekeeper</strong></summary>

Abra la Terminal y ejecute:
```bash
xattr -cr /Applications/UnblockPro.app
```
Después de eso, la aplicación se iniciará normalmente. Esto solo debe hacerse una vez.

Si descargó el `.zip` y lo descomprimió en otra carpeta, indique la ruta al `.app` en lugar de `/Applications/UnblockPro.app`.
</details>

---

## Desarrollo

```bash
# Клонировать репозиторий
git clone https://github.com/by-sonic/unblock-pro.git
cd unblock-pro

# Установить зависимости
npm install

# Запустить в режиме разработки
npm start

# Собрать для текущей ОС
npm run build

# Собрать для macOS
npm run build:mac

# Собрать для Windows
npm run build:win
```

---

## Stack

- **Electron** — framework multiplataforma  
- **zapret** — motor para evadir DPI ([bol-van/zapret](https://github.com/bol-van/zapret))  
- **electron-builder** — compilación y distribución  
- **GitHub Actions** — builds automáticos en el lanzamiento  

---

## Licencia

[MIT](LICENSE) — uso libre, modificación y distribución.  

---

<p align="center">
  <strong>por sonic</strong><br>
  <sub>Si el proyecto te ayudó — pon ⭐️</sub>
</p>

---

### Palabras clave / Keywords

> desbloqueo discord, desbloqueo youtube, evadir bloqueo discord, evadir bloqueo youtube, dpi bypass, antibloqueo, desbloquear discord, discord rusia, youtube rusia, zapret gui, evadir dpi, discord unblock russia, youtube unblock russia, anti dpi, bypass discord block, unblock discord, unblock youtube


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-08

---