# BookBounty

![Build Status](https://github.com/TheWicklowWolf/BookBounty/actions/workflows/main.yml/badge.svg)
![Docker Pulls](https://img.shields.io/docker/pulls/thewicklowwolf/bookbounty.svg)

<img src="/src/static/bookbounty.png" alt="image">


BookBounty is a tool for finding missing Readarr books.


## Run using docker-compose

```yaml
services:
  bookbounty:
    image: thewicklowwolf/bookbounty:latest
    container_name: bookbounty
    ports:
      - 5000:5000
    volumes:
      - /path/to/config:/bookbounty/config
      - /path/to/downloads:/bookbounty/downloads
      - /etc/localtime:/etc/localtime:ro
    restart: unless-stopped

```
---

## Configuración mediante variables de entorno

Ciertos valores pueden configurarse mediante variables de entorno:

* __PUID__: El ID de usuario con el que se ejecutará la aplicación. Por defecto es `1000`. 
* __PGID__: El ID de grupo con el que se ejecutará la aplicación. Por defecto es `1000`.
* __readarr_address__: La URL para Readarr. Por defecto es `http://192.168.1.2:8787`.
* __readarr_api_key__: La clave API para Readarr. Por defecto es ` `.
* __libgen_address__: La URL para Library Genesis. La única URL soportada actualmente es `http://libgen.is`.
* __sleep_interval__: Intervalo para pausar entre descargas (segundos). Por defecto es `0`.
* __sync_schedule__: Horas programadas para ejecutar, p.ej. 14 para 2pm (valores separados por comas en formato 24h). Por defecto es ` `.
* __minimum_match_ratio__: Porcentaje mínimo para un match. Por defecto es `90`.
* __selected_path_type__: Seleccionar estructura de descarga (archivo o carpeta). Por defecto es `file`.
* __search_type__: Seleccionar tipo de búsqueda (ficción o no ficción). Por defecto es `fiction`.
* __library_scan_on_completion__: Indica si escanear la biblioteca de Readarr al completar. Por defecto es `True`.
* __request_timeout__: Tiempo límite para solicitudes (segundos). Por defecto es `120`.
* __thread_limit__: Número máximo de hilos a usar. Por defecto es `1`.
* __selected_language__: Filtrar descarga por idioma (idiomas específicos o todos). Por defecto es `English`. Esto se usa si BookBounty no puede obtener los idiomas del Perfil de Metadatos de Readarr.
* __preferred_extensions_fiction__: Filtrar descarga de ficción por extensión (separadas por comas). Por defecto es `.epub, .mobi, .azw3, .djvu`.
* __preferred_extensions_non_fiction__: Filtrar descarga de no ficción por extensión (separadas por comas). Por defecto es `.pdf .epub, .mobi, .azw3, .djvu`.
* __search_last_name_only__: Usar sólo el apellido del autor en las búsquedas. Por defecto es `False`.
* __search_shortened_title__: Usar título abreviado al buscar (eliminar todo después de `:`). Por defecto es `False`.


## Programación de sincronización

Use una lista separada por comas de horas para iniciar la sincronización (p.ej. `2, 20` iniciará una sincronización a las 2 AM y 8 PM).
> Nota: Hay un margen de hasta 10 minutos desde la hora programada de inicio.


## Integración con Readarr

Tiene dos opciones para integrar BookBounty con Readarr:

1. Mapear directamente `/bookbounty/downloads` a su carpeta principal de Readarr y configurar `selected_path_type=folder`.   
   Este método intentará crear la estructura de carpetas correcta (`/autor/libro/nombrearchivo.ext`, etc.) antes de descargar los archivos directamente en sus respectivas carpetas.

2. Alternativamente, mapear `/bookbounty/downloads` a una carpeta `_unprocessed` y establecer `selected_path_type=file`.
   This method downloads all files into a single folder. After a library scan in Readarr, some files may remain unmapped and require manual import.  
   After importing, you can use the "**Rename Files**" function in Readarr to organize the files into the correct folders.

For both methods, setting `library_scan_on_completion=True` automates the import process in Readarr.

**Note:** Readarr does not automatically rename files upon import.


---


<img src="/src/static/dark.png" alt="image">


---


<img src="/src/static/light.png" alt="image">


---

https://hub.docker.com/r/thewicklowwolf/bookbounty



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-14

---