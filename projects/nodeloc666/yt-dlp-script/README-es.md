
# 🎬 Herramienta de descarga masiva de videos yt-dlp (compatible con Windows / Linux)

> Script de descarga de videos con un clic basado en [yt-dlp](https://github.com/yt-dlp/yt-dlp), inspirado en la [compartición del experto NodeSeek](https://www.nodeseek.com/post-334093-2#15).
> Soporta descarga de videos individuales y en lote, compatible con Windows y distribuciones Linux principales (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Características

* 📥 **Ejecución con un clic**: No requiere configuración manual, solo ingrese según las indicaciones para comenzar la descarga
* 🍪 **Soporte para cookies personalizadas**: Para videos que requieren inicio de sesión para descargar (⚠️ esta función no ha sido verificada, puede contener errores)
* 📂 **Soporte para directorio de salida personalizado**: Guarde fácilmente en la carpeta especificada
* 📃 **Soporte para descarga en lote**: Lee automáticamente los enlaces en el archivo `urls.txt` para descargar
* ⚙️ **Instalación automática de dependencias**: En entornos Linux instala automáticamente `yt-dlp` y `ffmpeg`

---

## 🖼️ Vista previa de capturas

| Ejemplo 1                                                               | Ejemplo 2                                                               |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![Ejemplo 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Ejemplo 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Ejemplo 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Ejemplo 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Uso en Windows

1. Descargue los siguientes archivos:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` versión para Windows](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. Después de descomprimir, coloque los siguientes archivos en la misma carpeta (por ejemplo, carpeta `yt-dlp`):

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (archivo de script)
3. Haga doble clic en `yt-dlp.bat` y siga las indicaciones para descargar el video.  
4. Edite config/config.ini para modificar la configuración predeterminada.  

---  

## 🐧 Uso en Linux (El último script del experto 科技lion también integra esta funcionalidad)  

**Sistemas soportados**: Debian / Ubuntu / Alpine / CentOS  

Despliegue o actualice y ejecute con un solo comando:


```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```
Para desinstalar:


```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Recomendaciones para Android

1. Usa la aplicación [Seal](https://github.com/JunkFood02/Seal) para experimentar las funciones de `yt-dlp` en Android.  
2. También es posible descargar instalando Debian en termux, pero no es necesario, Seal es muy fácil de usar.

---

## ⚠️ Precauciones

1. **Modo de descarga masiva**: El script leerá automáticamente el archivo `config\urls.txt` en el directorio actual, un enlace de video por línea. Si el archivo no existe, se creará automáticamente.  
2. **Aviso sobre uso de recursos**: Los dispositivos con poca memoria deben evitar descargar varios videos grandes simultáneamente o configurar demasiados hilos concurrentes.  
3. **Nota especial para CentOS**: Debido a un entorno especial, no ha sido probado completamente; se recomienda usar en entornos no productivos. Los demás sistemas principales han sido verificados.  
4. Bug pequeño en Linux: El script verifica dependencias al llegar a la página principal; siguiendo el principio de que si funciona no se cambia, no se ha modificado.  
5. Bug pequeño en Windows: Al volver a la página principal desde otra, la opción predeterminada puede fallar y provocar un bucle; limitaciones de capacidad, no se ha corregido bien.  
Dos soluciones:  
    1. Salir y reiniciar  
    2. No usar opción predeterminada, elegir por número

---

## 📄 Licencia

Este proyecto sigue la [Licencia MIT](https://opensource.org/licenses/MIT).

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---