El Proyecto Media Downloader
![Logotipo de Media Downloader](https://raw.githubusercontent.com/yuri-maxiutenko/MediaDownloader/master/MediaDownloader/Images/icon.png)
====================
Solo una pequeña interfaz amigable para el usuario (C#/WPF, .NET) sobre la excelente utilidad de línea de comandos para descargar videos [yt-dlp](https://github.com/yt-dlp/yt-dlp) que permite descargar videos en diferentes calidades desde varios recursos de internet (YouTube, Vimeo, Facebook, lo que sea). También se admite la descarga de listas de reproducción.

## Características principales

**Media Downloader** es capaz de descargar casi cualquier video de todos los principales proveedores (YouTube, Vimeo, Facebook, etc.). Solo dale un enlace ¡y voilà! También se aceptan enlaces a listas de reproducción.

Actualmente la aplicación soporta los siguientes formatos de descarga:

* Video de mejor calidad
* Video MP4 de mejor calidad
* Mejor video disponible por enlace directo
* Solo audio

Además, **Media Downloader** soporta historial de descargas y guarda la lista de carpetas usadas recientemente.

Viene con un instalador, que incluye todo lo necesario: la propia aplicación, [yt-dlp](https://github.com/yt-dlp/yt-dlp) y el convertidor [FFmpeg](https://ffmpeg.org/).

La aplicación se instala en la carpeta AppData del usuario actual y no requiere permisos de administrador.

Actualmente **Media Downloader** está localizado en inglés y ruso. El idioma de la aplicación se selecciona automáticamente según la configuración regional de Windows.

## Requisitos

A partir de la versión **2.1**, la aplicación utiliza **[.NET 7 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)**. Pero no deberías necesitar instalarlo, ya que Media Downloader se proporciona como **[una aplicación autónoma](https://devblogs.microsoft.com/dotnet/app-trimming-in-net-5/)**.

Además, **yt-dlp** requiere **[Microsoft Visual C++ 2010 Redistributable Package (x86)](https://www.microsoft.com/en-us/download/details.aspx?id=5555)**.

## Capturas de pantalla

Descarga de video en progreso:
![Descarga de video en progreso](https://github.com/yuri-maxiutenko/MediaDownloader/blob/master/Screenshots/Annotation%202020-06-29%20210558.png?raw=true)

Descarga de video completada:
![Descarga de video completada](https://github.com/yuri-maxiutenko/MediaDownloader/blob/master/Screenshots/Annotation%202020-06-29%20210909.png?raw=true)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-21

---