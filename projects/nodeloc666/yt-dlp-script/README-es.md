
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 Herramienta de descarga masiva de videos yt-dlp (compatible con Windows / Linux)

> Script de descarga de videos con un solo clic basado en [yt-dlp](https://github.com/yt-dlp/yt-dlp), inspirado por [la publicación compartida por NodeSeek](https://www.nodeseek.com/post-334093-2#15).
> Soporta descarga de videos individuales y por lotes, compatible con Windows y las principales distribuciones de Linux (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Características principales

* 📥 **Ejecución con un clic**: Sin configuración manual, solo ingrese según las indicaciones para comenzar la descarga
* 🍪 **Soporte para Cookie personalizado**: Adecuado para videos que requieren inicio de sesión para descargar (⚠️ Función no verificada, puede tener errores)
* 📂 **Soporte para directorio de salida personalizado**: Guarde fácilmente en la carpeta especificada
* 📃 **Soporte para descarga por lotes**: Lee automáticamente los enlaces del archivo `urls.txt` para descargar
* ⚙️ **Instalación automática de dependencias**: Instala automáticamente `yt-dlp` y `ffmpeg` en entornos Linux

---

## 🖼️ Vista previa de capturas

| Ejemplo 1                                                                  | Ejemplo 2                                                                  |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| ![Ejemplo 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Ejemplo 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Ejemplo 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Ejemplo 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Instrucciones para Windows

1. Descargue los siguientes archivos:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [Versión de Windows de `ffmpeg`](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. Después de descomprimir, coloque los siguientes archivos en el mismo directorio (por ejemplo, carpeta `yt-dlp`):

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (archivo de script)

3. Haga doble clic en `yt-dlp.bat` y siga las indicaciones para descargar videos.
4. Edite config/config.ini para modificar la configuración predeterminada

---

## 🐧 Instrucciones para Linux (El último script del experto lion también integra la misma funcionalidad)

**Sistemas compatibles**: Debian / Ubuntu / Alpine / CentOS

Implementación o actualización y ejecución con un solo clic:

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---