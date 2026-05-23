# 🖥️ PCTools

> Programa sencillo en Python que permite una integración perfecta entre Windows y Home Assistant, para funciones como monitoreo de hardware y control remoto.

[![GitHub Release](https://img.shields.io/github/v/release/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools/releases/latest)
[![GitHub Downloads](https://img.shields.io/github/downloads/1812z/PCTools/total?style=flat-square&logo=github&label=Descargas)](https://github.com/1812z/PCTools/releases)
[![GitHub Stars](https://img.shields.io/github/stars/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools)
[![License](https://img.shields.io/github/license/1812z/PCTools?style=flat-square)](LICENSE)

---

## ✨ Características

| Función | Descripción |
|------|------|
| 📊 **Monitoreo Aida64** | Actualización periódica de datos de sensores seleccionados |
| 🎮 **Comandos remotos** | Sincronización automática de archivos `.bat` y `.lnk` en la carpeta `commands` con HA |
| 📸 **Monitoreo web** | Captura de pantalla / cámara / transmisión en vivo |
| 💬 **Notificaciones** | Escucha entradas de texto de HA y muestra mensajes Toast |
| 🌐 **Sidebar web** | Atajo para abrir la barra lateral web de HA |
| ⌨️ **Atajos de teclado** | Atajos que activan sensores binarios en HA |
| 📱 **Retroalimentación de aplicaciones en primer plano** | Reporta automáticamente el nombre de la aplicación activa, compatible con [Runtime Tracker](https://github.com/1812z/RunTime_Tracker) |
| 🖥️ **Control de monitores** | Brillo / encendido / comandos DDC-CI para múltiples monitores |
| 🔊 **Control de volumen** | Controla el volumen del sistema Windows |
| 🌙 **Modo oscuro** | Cambia el modo oscuro del sistema/aplicaciones |
| 📶 **Control Bluetooth** | Enciende y apaga el Bluetooth del sistema |
| ⚡ **Línea de comandos** | Ejecuta comandos personalizados CMD/PowerShell |
| 🎨 **Wallpaper Engine** | Controla Wallpaper Engine |
| ⌨️ **Simulación de teclas** | Simula entradas de teclado (incluye teclas multimedia) |
| 🔗 **Lanzador de URL** | Abre URLs personalizadas |

**Puntos finales de monitoreo web:**
- Captura de pantalla: `http://127.0.0.1:5000/screenshot.jpg`
- Cámara: `http://127.0.0.1:5000/video_feed`
- Transmisión en vivo: `http://127.0.0.1:5000/screen`

---

## 📷 Capturas de pantalla

<details>
<summary>🖼️ Interfaz del software</summary>
<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/gui.png" alt="GUI" width="600"/>
</details>

<details>
<summary>📱 Interfaz HA</summary>

**Pantalla secundaria alternativa** (recomendado usar junto con [HA_Helper](https://github.com/1812z/Ha_Helper))

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/1743859715274.jpg" alt="Pantalla secundaria" width="400"/>

**Página principal**

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/image.png" alt="Página principal" height="500"/>

</details>

---

## 🚀 Inicio rápido

### 1️⃣ Instalación del entorno

**Método uno**: Descargar el archivo comprimido en [Releases](https://github.com/1812z/PCTools/releases/latest) (entorno de ejecución incorporado)

**Método dos**: Configuración manual
```bash
# Python 3.12
pip install -r requirements.txt
```
### 2️⃣ Instalación de software de terceros (opcional)

| Dependencia | Uso |
|------|------|
| Servidor MQTT | Integración con Home Assistant |
| [Aida64](https://github.com/1812z/PCTools/releases) | Monitorización de información de hardware |
| [Twinkle Tray](https://github.com/xanderfrangos/twinkle-tray/releases) | Ajuste de brillo del monitor |

### 3️⃣ Configuración de dependencias

1. **Aida64**: habilitar el uso compartido de memoria y seleccionar los datos del sensor necesarios  
2. **Twinkle Tray**: asegurarse de que pueda leer correctamente la información del monitor  
3. **Wallpaper Engine**: iniciarlo para soportar operaciones relacionadas  

> 💡 Después de añadir/modificar sensores, si hay conflictos, elimine los dispositivos en HA/MQTT y reinicie el software  

### 4️⃣ Ejecutar el programa

1. Ejecutar `AbrirGUI.bat` para iniciar la interfaz  
2. Entrar en configuración para ajustar parámetros (**presione Enter para guardar**)  
3. Activar los plugins necesarios (**se recomienda reiniciar el programa**)  
4. Hacer clic en iniciar y ver los nuevos dispositivos en la integración MQTT de HA  

### 5️⃣ Inicio automático (opcional)

En la configuración, hacer clic en **Inicio automático**, el programa se ejecutará en segundo plano y el icono aparecerá en la bandeja del sistema  

---

## 📋 Plan de desarrollo

- [x] Atajos de teclado vinculados  
- [x] Optimización de código  
- [x] Optimización de la lógica del plugin  
- [ ] Control del ventilador del PC  
- [ ] Callbacks múltiples para botones de Toast  
- [ ] Mercado de plugins  
- [ ] Control multimedia  
- [ ] Sincronización de letras de NetEase Cloud Music


---

## 💡 Combinaciones recomendadas

| Software | Descripción |
|------|------|
| [OpenRGB](https://openrgb.org/) | Control de luces RGB, compatible con integración HA |
| [HASS.Agent](https://github.com/hass-agent/HASS.Agent) | Herramienta similar más estable |

---

## Agradecimientos

- [python_aida64](https://github.com/gwy15/python_aida64) - Lectura de datos de Aida64

---

## 📝 Otros

- Soporta modo sin cabeza: `python core.py`
- Algunas páginas necesitan cambiar para actualizarse


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-23

---