# 🌌 Motor de Fondos de Pantalla Animados para GNOME

> **[Instala ahora en GNOME Extensions](https://extensions.gnome.org/extension/9558/gnome-wallpaper-engine/)**

Sin configuraciones complejas. Sin dependencias pesadas. Solo mpv, ffmpeg + la extensión.

La **forma más simple y confiable** de usar fondos animados en GNOME — totalmente compatible con **Wayland y X11**.

Impulsado por **mpv** para máximo rendimiento, bajo uso de recursos y soporte completo de formatos (MP4, GIF, WebM, MKV…).

Si te gusta este proyecto, considera darle una estrella ⭐ — ¡realmente ayuda!

## ☕ Soporte y Actualizaciones

Si deseas apoyar el proyecto, puedes hacerlo aquí:

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/achu94)

También compartiré actualizaciones de desarrollo, progreso y trabajo entre bastidores en Ko-fi.

No necesitas donar para ver las publicaciones — todos son bienvenidos a seguir y mantenerse informados 🙂

Y si disfrutas el proyecto, ¡una ⭐ en GitHub siempre es apreciada!

---

## 🎥 Demo

> Fondo animado funcionando en GNOME (Wayland)

![demo](https://raw.githubusercontent.com/achu94/gnome-wallpaper-engine/main/assets/demo.gif)

---

## ✨ Características

- 🎬 **Galería Integrada:** Navega y selecciona fondos directamente desde Configuración de GNOME
- 🖼️ **Previsualizaciones en Miniatura:** Previsualizaciones generadas automáticamente para todos los fondos
- 📥 **Importación Inteligente:** Añade videos con un clic y aplica al instante
- 🚀 **Aceleración por GPU (habilitada por defecto):** Usa mpv con `hwdec=auto`
- ⚡ **Uso de CPU Muy Bajo:** Normalmente ~1–3%
- 🔄 **Aplicación Instantánea:** Cambia fondos de pantalla en tiempo real
- 🖥️ **Compatible con Wayland:** Funciona de forma fiable donde la mayoría de herramientas fallan
- 📦 **Configuración Mínima:** Solo requiere mpv y ffmpeg
- 🎞️ **Amplio Soporte de Formatos:** MP4, GIF, WebM, MKV y más
- 🔁 **Inicio Automático:** Inicia automáticamente el fondo de pantalla al iniciar sesión
- 🧩 **Alternar Ícono en la Bandeja:** Mostrar u ocultar el indicador en el panel superior
- ⏸️ **Pausa Automática (Pantalla Completa):** Pausa cuando una aplicación está en pantalla completa
- 🔋 **Pausa Automática (Batería):** Pausa cuando funciona con batería para ahorrar energía

---

## 🚧 Hoja de Ruta

- 🎮 Integración con Steam Wallpaper Engine (detección automática y listado de fondos compatibles)
- 🎛️ Configuraciones avanzadas de reproducción (modos de bucle, velocidad, etc.)
- 🎨 Futuro motor de renderizado (sin mpv)

---

## 🛠 Requisitos

Solo necesitas tener instalado **mpv**:

### Ubuntu / Debian / Zorin OS

```bash
sudo apt update && sudo apt install mpv ffmpeg
```

### Fedora

```bash
sudo dnf install mpv ffmpeg
```

### Arch Linux

```bash
sudo pacman -S mpv ffmpeg
```

### openSUSE

```bash
sudo zypper in mpv ffmpeg
```

## 📦 Instalación

### 🎖️ Extensiones oficiales de GNOME (Más fácil)
Instálalo directamente desde el sitio web de Extensiones de GNOME:

**[Descargar en Extensiones de GNOME](https://extensions.gnome.org/extension/9558/gnome-wallpaper-engine/)**

---

### ⚡ Instalación rápida (ZIP local)

```bash
gnome-extensions install gnome-wallpaper-engine@gjs.com.zip
```
  
Luego:

- Wayland: Cierra sesión y vuelve a iniciarla  
- X11: Presiona `Alt + F2`, escribe `r`, presiona Enter

Finalmente, habilita la extensión usando la aplicación **Extensiones**  
(o a través del indicador del panel superior si está habilitado).

---

### 🧩 Instalación manual

1. Descarga el archivo ZIP de la última versión  
2. Extráelo en:

```
~/.local/share/gnome-shell/extensions/
```

3. Asegúrese de que la carpeta se llame:

```
gnome-wallpaper-engine@gjs.com
```

4. Compila los esquemas de GSettings ejecutando este comando en tu terminal:

```
glib-compile-schemas ~/.local/share/gnome-shell/extensions/gnome-wallpaper-engine@gjs.com/schemas/
```
5. Reiniciar GNOME Shell
    - Wayland: Cierra sesión y vuelve a iniciarla
    - X11: Presiona `Alt + F2`, escribe `r`, presiona Enter

6. Habilita la extensión usando la aplicación **Extensiones**

---

## 📖 Uso

1. Abre la configuración de la extensión
2. Haz clic en **"Agregar Video/GIF"**
3. Selecciona un fondo de pantalla de la galería
4. Los fondos se aplican al instante
5. Opcionalmente usa el indicador del panel superior para iniciar o detener la reproducción
6. Opcionalmente oculta el icono de la bandeja desde la configuración

---

## 💡 Por qué existe

Lo creé para solucionar la falta de soluciones simples y confiables de fondos de pantalla animados en GNOME, especialmente en Wayland.

---

## ⚖️ Licencia

GPL-3.0 — libre y de código abierto.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-28

---