# janitor
## Objetivo
Janitor es una herramienta independiente que monitorea la disponibilidad de tus dispositivos IOT y te alerta en caso de que un dispositivo desaparezca o deje de transmitir datos. Esto es particularmente útil si tienes muchos sensores, posiblemente con hardware o conexión inestable, para que puedas actuar en caso de cualquier problema y monitorear la estabilidad de tus dispositivos.

Janitor no tiene como objetivo implementar funcionalidades adicionales, por lo tanto no es una alternativa a tu otro software de automatización del hogar (por ejemplo HASS). Enfocarse únicamente en esta funcionalidad permitirá mantener esta herramienta simple y eficiente.

Janitor actualmente soporta los siguientes métodos de monitoreo:
* **MQTT:** Janitor se suscribirá a temas MQTT predefinidos y monitoreará los mensajes entrantes. Se calculará una frecuencia promedio de transmisión para cada canal y en caso de no recibir mensajes nuevos dentro de este intervalo, Janitor te alertará (el umbral puede configurarse como un múltiplo de la frecuencia promedio o como valores absolutos por tema). Este método es particularmente útil para cualquier tipo de sensores que envíen datos regularmente vía MQTT (por ejemplo temperatura).
* **Ping:** Janitor hará ping a hosts predefinidos con una frecuencia predefinida (configurable por host) y te alertará en caso de no recibir respuesta (el umbral usado para pings consecutivamente fallidos puede configurarse). Este método es útil para cualquier tipo de dispositivos IOT, por ejemplo sensores, cámaras, etc.
* **HTTP:** Janitor enviará una solicitud HTTP GET a direcciones predefinidas y verificará la respuesta, y opcionalmente, si la respuesta contiene una cadena predefinida. Janitor te alertará en caso de solicitudes consecutivamente fallidas por encima del umbral configurado. La frecuencia y el tiempo de espera también son configurables por dirección. Este método es útil para cualquier tipo de servicios con interfaz web (por ejemplo APIs, servicios alojados, etc.).
* **Exec:** Janitor ejecutará un comando preconfigurado y verificará su código de salida. Janitor te alertará en caso de ejecuciones consecutivamente fallidas por encima del umbral configurado. La frecuencia y el tiempo de espera también son configurables por comando. Con este método puedes implementar cualquier tipo de monitoreo personalizado.

Janitor actualmente soporta los siguientes métodos de alerta:
* **Telegram:** Janitor enviará un mensaje a un canal de Telegram predefinido.
* **Gotify:** Janitor enviará un mensaje push a Gotify.
* **MQTT:** Janitor publicará un mensaje en un tema preconfigurado en un servidor MQTT preconfigurado. El mensaje contendrá una carga JSON (ver configuración de ejemplo). Esto es adecuado para automatizaciones, por ejemplo en HASS.
* **Exec:** Janitor ejecutará un comando preconfigurado. Esto permite crear cualquier tipo de método de alerta personalizado.

Adicionalmente, Janitor tiene una interfaz web donde puedes ver el estado actual y datos históricos, eliminar ítems, cambiar tiempos de espera, intervalos y umbrales y recargar el archivo de configuración (ver captura de pantalla abajo).

Finalmente, Janitor incluye una API JSON simple con los siguientes endpoints:
* `/api/data` proporciona una instantánea de todos los datos relacionados con el monitoreo.
* `/api/stats` proporciona el conteo de objetivos de monitoreo en estado funcional/disfuncional.
* `/api/metrics` proporciona estadísticas de objetivos en formato de métricas Prometheus.

## Captura de pantalla
![Captura de pantalla](https://raw.githubusercontent.com/a-bali/janitor/master/docs/screenshot.png)

## Compilación e instalación

Janitor está escrito en Go y se compilará en un único binario independiente. Janitor debería compilar y funcionar tanto en Linux como en Windows.

Para compilar, usa al menos la versión 1.16 de Go y ejecuta los siguientes comandos para clonar el repositorio y construir el binario:

    $ git clone https://github.com/a-bali/janitor.git
    $ cd janitor
    $ go build

Esto creará el binario independiente llamado `janitor` que puedes colocar donde desees. Los binarios precompilados para las versiones
están disponibles en Github.
## Configuración y uso

Para la configuración, se requiere un archivo con formato YAML. Por favor, use el [archivo de configuración de ejemplo](https://raw.githubusercontent.com/a-bali/janitor/master/config.yml) y cámbielo según sus necesidades, siguiendo los comentarios en el archivo. La mayoría de las variables son opcionales y tienen valores predeterminados razonables, para más detalles vea los comentarios. Puede referenciar variables de entorno con `$ENV_VAR` o `${ENV_VAR}`, las cuales serán sustituidas por su valor si existen (o por una cadena vacía si no existen).

Una configuración mínima pero ya operativa puede ser tan corta como la siguiente (suponiendo que la interfaz web de Janitor estará disponible en su puerto predeterminado, que es 8080):

    monitor:
      mqtt:
        server: mymqtt.server
        targets:
        - topic: "/sensors/#"
    alert:
      gotify:
        server: "http://mygotify.server:1234"
        token: gotify_token

Una vez que haya creado un archivo de configuración, Janitor puede iniciarse de la siguiente manera:

    $ janitor path/to/your/configfile.yml

Janitor registrará en la salida estándar. El registro también es visible en la interfaz web, donde puede eliminar objetivos monitoreados y recargar el archivo de configuración (por ejemplo, en caso de que haya agregado nuevos objetivos o cambiado alguna de las configuraciones).

Janitor no se ejecutará como demonio. Se recomienda crear un servicio systemd para janitor en caso de que desee que se ejecute de forma continua.

## Ejecución con Docker

La última versión de Janitor está disponible en Docker Hub [`abali/janitor`](https://hub.docker.com/repository/docker/abali/janitor). Para usarlo, mapee su archivo de configuración a `/janitor/config.yml`:

    $ docker run -v $(pwd)/config.yml:/janitor/config.yml -p 8080:8080 abali/janitor

Alternativamente, puede usar el Dockerfile suministrado para construir un contenedor usted mismo:

    $ git clone https://github.com/a-bali/janitor.git
    $ cd janitor
    $ docker build . -t janitor
    $ docker run -v $(pwd)/config.yml:/janitor/config.yml -p 8080:8080 janitor

## Planes futuros y contribuciones


El objetivo de Janitor es claro y simple: monitorear la disponibilidad y operación de dispositivos IOT y alertar en caso de que haya algún problema. Cualquier mejora futura debe seguir este objetivo y, por lo tanto, añadir nuevas formas de monitoreo o nuevas formas de alerta.

Janitor es un software de código abierto y se le anima a enviar solicitudes de extracción a través de Github que mejoren el software.

## Licencia

Janitor está licenciado bajo GPL 3.0.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-25

---