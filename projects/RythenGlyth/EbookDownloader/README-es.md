# EbookDownloader
Una herramienta para descargar libros electrónicos comprados de diferentes editoriales.

![Vista previa](https://raw.githubusercontent.com/RythenGlyth/EbookDownloader/master/preview.png)

## Tabla de Contenidos
- [Editoriales compatibles (sitios web)](#supported-publishers-websites)
- [Instalación automática](#automatic-installation)
- [Instalación manual](#manual-installation)
- [Ejecución](#running)
- [Guardar credenciales](#saving-credentials-to-avoid-entering-them-every-time-optional)
- [Bildungslogin (Cornelsen / Westermann)](#bildungslogin)

## Editoriales compatibles (sitios web)
| Editorial | Sitio web | Mejor calidad | Texto seleccionable | Hipervínculos | Notas |
| --- | --- | --- | --- | --- | --- |
| Cornelsen ("Método nuevo") | cornelsen.de | PDF sin pérdida | &check; | &check; |  |
| Cornelsen ("Método antiguo") | cornelsen.de | Composición de imagen (8617px x 11792px) | &check; | &cross; |  |
| Cornelsen.CH | ebooks.cornelsen.ch | PDF sin pérdida | &check; | &cross; |  |
| Cornelsen | scook.de | Composición de imagen (?) | &cross; | &cross; | |
| Allango Klett | allango.net | PDF sin pérdida | &check; | ? | [1] |
| Klett | klett.de | Composición de imagen (3072px x 4096px) | &check; | &check; | |
| Westermann | westermann.de | Composición de imagen (2244px x 3071px) | &check; | &cross; | |
| C.C.BUCHNER | click-and-study.de | Composición de imagen (1658px x 2211px) | &check; | &cross; | |
| C.C.BUCHNER | click-and-teach.de | Composición de imagen (1658px x 2211px) | &check; | &cross; | |
| Book2Look | book2look.com | PDF sin pérdida | &check; | ? | [2] |
| kiosquemag | kiosquemag.com | Composición de imagen (?) | &cross; | &cross; | |
| Helbling Media App | helbling.com | PDF sin pérdida | &check; | &cross; | |

[1]: El sitio web permite descargar archivos que no son propiedad

[2]: No se necesita cuenta, solo el ID del libro

## Instalación automática
Primero, clona o descarga el repositorio.

La herramienta usa librerías de procesamiento de imágenes y debe ejecutarse con nodejs, por lo tanto se requieren algunas dependencias.

Puedes usar los scripts de instalación (`init.bat` para Windows, `init.sh` para distribuciones basadas en Debian) o realizar una instalación manual. Los scripts de instalación descargarán todas las dependencias por ti. Para ejecutarlos, haz doble clic en el archivo `.bat` en Windows o ejecuta el archivo `.sh` en la terminal de Linux después de agregar permisos de ejecución al archivo `.sh`.

## Instalación Manual  
Primero, clona o descarga el repositorio. Luego sigue las instrucciones específicas para cada sistema operativo a continuación:  

### Windows  
1. Descarga `unifont-15.0.01.ttf` desde http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf y colócalo en la raíz del proyecto  
1. Instala `ffmpeg` y coloca el ejecutable ffmpeg (llamado `ffmpeg`) en la raíz del proyecto o añádelo a tu variable de entorno path, si necesitas ayuda puedes seguir [este](https://phoenixnap.com/kb/ffmpeg-windows) tutorial  
1. Instala `mutool` y coloca el ejecutable mutool (llamado `mutool`) en la raíz del proyecto o añádelo a tu variable de entorno path, puedes encontrar las compilaciones más recientes [aquí](https://mupdf.com/releases). Busca las versiones para `windows`. (solo requerido para book2look y cornelsen.ch)  
1. Instala `nodejs` y `npm` si aún no lo has hecho, puedes encontrar ayuda [aquí](https://phoenixnap.com/kb/install-node-js-npm-on-windows)  
1. Ejecuta `npm install`  
1. Opcionalmente instala `image magick` y coloca el ejecutable magick (llamado `magick`) en la raíz del proyecto o añádelo a tu variable de entorno path (requerido solo para el "método antiguo" de cornelsen)  

### Linux  
1. Ejecuta `wget "http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf"`  
1. Instala los paquetes `ffmpeg`, `nodejs`, `mutool`/`mupdf-tools`/`mupdf` (requerido para book2look y cornelsen.ch) y opcionalmente `imagemagick` (requerido solo para el "método antiguo" de cornelsen) con tu gestor de paquetes favorito  
1. Ejecuta `npm install`  

### Linux/Darwin con Nix  
- Si tienes nix-direnv, ejecuta `direnv allow` para obtener todas las dependencias  
- De lo contrario, ejecuta `nix-shell`.  
- Ejecuta `wget "http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf"`  

## Ejecución  
Completa la configuración ejecutando `npm install` en el directorio del proyecto y  
inicia el programa ejecutando `npm start` desde el directorio del proyecto.  

## Guardar credenciales para evitar ingresarlas cada vez (opcional)  
Puedes guardar tus credenciales en un archivo `config.json` para evitar ingresarlas cada vez que inicies el programa. Para hacerlo, crea un archivo llamado `config.json` en la raíz del proyecto y añade el siguiente contenido:

```json
{
    "[PUBLISHER]": {
        "email": "[YOUR_USERNAME_OR_EMAIL]", 
        "passwd": "[YOUR_PASSWORD]"
    },
    "[PUBLISHER]": {
        "email": "[YOUR_USERNAME_OR_EMAIL]", 
        "passwd": "[YOUR_PASSWORD]"
    }
    [...]
}
```

Replace all the square brackets with your data. Publisher keys are: `cornelsen`, `klett`, `allango`, `scook`, `westermann`, `clicknstudy`, `clicknteach`, `kiosquemag`, `cornelsench`, `book2look`, `helbling`

## Bildungslogin

Cornelsen, Click-n-Study, Klett, and Westermann tienen soporte para token-login, permitiendo iniciar sesión usando cuentas de Bildungslogin.

### Cornelsen

1. Abre Bildungslogin e inicia sesión
1. Entra en las herramientas de desarrollo Storage (SHIFT+F9, o alternativamente presiona CTRL+SHIFT+I y haz clic en la pestaña Storage).
1. Abre el libro
1. Selecciona Local storage en las herramientas de desarrollo (posiblemente también necesites seleccionar el sitio web en él)
1. Desplázate hacia abajo en la tabla que se abre hasta encontrar `id_token`. Debería ser una cadena alfanumérica larga.
1. Cópialo. (Doble clic, luego ctrl+c)
1. Úsalo como contraseña, y usa `token` como nombre de usuario.

### Click-and-Study

1. Abre Bildungslogin e inicia sesión
1. Abre el libro
1. Entra en las herramientas de desarrollo Storage (SHIFT+F9, o alternativamente presiona CTRL+SHIFT+I y haz clic en la pestaña Storage).
1. Selecciona Cookies en las herramientas de desarrollo (posiblemente también necesites seleccionar el sitio web en él)
1. Desplázate hacia abajo en la tabla que se abre hasta encontrar `CASSID`. Debería tener una cadena alfanumérica después.
1. Cópialo (los caracteres de aspecto aleatorio). (Doble clic, luego ctrl+c)
1. Úsalo como contraseña, y usa `token` como nombre de usuario.

### Klett

1. Abre Bildungslogin e inicia sesión
1. Abre el libro
1. Entra en las herramientas de desarrollo Storage (SHIFT+F9, o alternativamente presiona CTRL+SHIFT+I y haz clic en la pestaña Storage).
1. Selecciona Cookies en las herramientas de desarrollo (posiblemente también necesites seleccionar el sitio web en él)
1. Desplázate hacia abajo en la tabla que se abre hasta encontrar `SESSION`. Debería tener una cadena alfanumérica después.
1. Cópialo (los caracteres de aspecto aleatorio). (Doble clic, luego ctrl+c)
1. Úsalo como contraseña, y usa **la URL del visor de libros en la que estás** como nombre de usuario.

### Westermann

1. Abre Bildungslogin e inicia sesión
1. Abre el libro
1. Ve a las herramientas de red (CTRL+SHIFT+E, o alternativamente presiona CTRL+SHIFT+I y haz clic en la pestaña Red).
1. Marca `Persistir registros` (posiblemente en el menú de engranaje, probablemente en la parte superior derecha en algún lugar)
1. Recarga la página
1. Ingresa `/api/user` en el campo "Filtrar URLs" de las herramientas de desarrollo
1. Haz clic en la primera entrada que *no* diga OPTIONS
1. Debería abrirse un panel pequeño al lado. Haz clic en su pestaña Encabezados
1. Ingresa `auth` en su campo "Filtrar encabezados" (si está disponible)
1. Desplázate hacia abajo hasta encontrar una cadena larga de letras y números
1. Cópiala y pégala en un documento de texto
1. Cópiala de nuevo desde allí, pero asegúrate de NO seleccionar la parte "Authorization: Bearer ", solo la cadena larga al final.
1. Úsala como contraseña, y usa `token` como nombre de usuario.

## Contribuyendo

Siéntete libre de crear issues y pull requests para contribuir al proyecto.

## Descargo de responsabilidad
Este proyecto es solo para fines educativos. El proyecto no se hace responsable de ningún mal uso del software. Dependiendo de tu jurisdicción, puede ser ilegal usar este software para descargar libros electrónicos sin el consentimiento del editor. En otras jurisdicciones, puede ser legal descargar libros electrónicos solo para uso personal. Por favor, revisa las leyes locales antes de usar este software.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-02

---