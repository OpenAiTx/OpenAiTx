# `acexy` - ¡Un Proxy AceStream Escrito en Go! ⚡

[![Go Build](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml/badge.svg)](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml)
[![Docker Release](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml/badge.svg?event=release)](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml)

## Tabla de Contenidos

- [¿Cómo Funciona? 🛠](#cómo-funciona-)
- [Características Clave 🔗](#características-clave-)
- [Uso 📐](#uso-)
- [Optimización 🚀](#optimización-)
  - [Alternativa 🧃](#alternativa-)
- [Opciones de Configuración ⚙](#opciones-de-configuración-)

## ¿Cómo Funciona? 🛠

Este proyecto es un envoltorio alrededor de la
[API HTTP intermedia de AceStream](https://docs.acestream.net/developers/start-playback/#using-middleware), que permite tanto
[HLS](https://es.wikipedia.org/wiki/HTTP_Live_Streaming) como
[reproducción MPEG-TS](https://es.wikipedia.org/wiki/HTTP_Live_Streaming)
de una transmisión.

Estaba cansado de las limitaciones de AceStream y algunos de los problemas que 
existen al reproducir una transmisión 📽. Por ejemplo, solo es posible reproducir
el mismo canal para **1 solo cliente**. Para tener múltiples clientes
reproduciendo **diferentes transmisiones**, debes agregar manualmente un `pid` único por 
cliente. Si hubo un error durante la transmisión, **toda la transmisión
se cae**, etc.

Encontré bastante frustrante la experiencia de usar AceStream en una red doméstica
con un solo servidor y múltiples clientes, para intentar optimizar recursos. Esta
es la topología para la que estoy usando AceStream:

![Topología AceStream Para Mi Red](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/topology.svg)

Hay algunos problemas:

* Solo **un cliente** puede reproducir la misma transmisión a la vez 🚫.
* Que cada cliente ejecute AceStream por su cuenta es un desperdicio de recursos
  y satura la red 📉.
* Varios clientes pueden reproducir diferentes streams si tienen un `pid`
  (ID de Reproductor) único asociado 🔓.
* La API HTTP estándar de AceStream no es lo suficientemente resistente a errores,
  si la transmisión se detiene, se detiene para todos los clientes ❌.

## Características Clave 🔗

Al usar `acexy`, automáticamente tienes:

* Un servidor único y centralizado ejecutando **todas tus transmisiones AceStream** ⛓.
* Asignación automática de un `pid` único (ID de Reproductor) **por cliente por stream** 🪪.
* **Multiplexación de Streams** 🕎: El mismo stream puede reproducirse *al
  mismo tiempo en múltiples clientes*.
* Streaming **resistente y a prueba de errores** gracias al Middleware HTTP 🛡.
* *Proxy ultrarrápido y minimalista* ☄ escrito en Go!

Con este proxy, ahora es posible la siguiente arquitectura:

![acexy Topology](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/acexy.svg)

## Uso 📐

`acexy` está disponible y publicado como una imagen Docker. Asegúrate de tener
la última imagen de [Docker](https://docker.com) instalada y disponible.

El contenedor Acexy se conectará a un servidor AceStream. Necesitas
desplegar una imagen Docker, y vincular Acexy dentro de la misma red; O
tener una versión de AceStream ejecutándose en tu host y correr Acexy en modo red de host.

> **INFO**: Hay un archivo `docker-compose.yml` en el repositorio que puedes
> usar directamente para lanzar todo el bloque. Esta es **la configuración recomendada a partir de `v0.2.0`**.

Para ejecutar el bloque de servicios, primero obtén el archivo `docker-compose.yml`, y ejecuta:



```shell
wget https://raw.githubusercontent.com/Javinator9889/acexy/refs/heads/main/docker-compose.yml
docker compose run -d
```

Si no quieres usar Docker Compose, asumiendo que ya tienes un
servidor AceStream, otra forma podría ser:

```shell
docker run --network host ghcr.io/javinator9889/acexy
```

> **NOTA**: Para su conveniencia, se proporciona un archivo `docker-compose.yml` con
> todos los parámetros ajustables posibles. Debe estar listo para ejecutarse y es
> la forma recomendada a partir de la versión `v0.2.0`.

Por defecto, el proxy funcionará en modo MPEG-TS. Para cambiar entre ellos,
debe agregar el **flag `-m3u8`** o establecer la **variable de entorno `ACEXY_M3U8=true`**.

> **NOTA**: El modo HLS - `ACEXY_M3U8` o flag `-m3u8` - está en estado no probado.
> Se desaconseja su uso y no se garantiza que funcione.

Hay un único endpoint disponible: `/ace/getstream` que acepta los mismos
parámetros que la
[AceStream Middleware/HTTP API estándar](https://docs.acestream.net/developers/api-reference/). Por lo tanto,
para ejecutar un stream, simplemente abra el siguiente enlace en su aplicación preferida, como VLC:


```
http://127.0.0.1:8080/ace/getstream?id=dd1e67078381739d14beca697356ab76d49d1a2
```
donde `dd1e67078381739d14beca697356ab76d49d1a2` es el ID del canal AceStream.

## Optimización 🚀

El motor AceStream que se ejecuta detrás del proxy tiene varios puertos que se pueden
exponer para optimizar el rendimiento. Por defecto, son:

- `8621/tcp`
- `8621/udp`

> NOTA: Pueden ajustarse mediante la variable `EXTRA_FLAGS` - dentro de Docker - usando
> la bandera `--port`.

Exponer esos puertos debería ayudar a obtener una experiencia de streaming más estable. Ten en
cuenta que también necesitarás abrir esos puertos en tu gateway.

Para referencia, así es como deberías ejecutar el comando Docker:



```shell
docker run -t -p 8080:8080 -p 8621:8621 ghcr.io/javinator9889/acexy
```

### Alternativa 🧃

AceStream intenta usar UPnP IGD para conectarse a una máquina remota.
El problema es que esto no funciona debido a la capa de puente que añade Docker
(ver: https://docs.docker.com/engine/network/drivers/bridge/).

Si estás ejecutando una sola instancia de Acexy - y una sola instancia de AceStream -
debería ser seguro para ti ejecutar el contenedor con *host networking*. Esto significa:

- El contenedor **puede acceder** a cualquier otra aplicación conectada a tu red principal.
- **No necesitas** exponer ningún puerto.
- El rendimiento **se optimiza** un poco.

> NOTA: Esto solo funciona en entornos Linux. Consulta https://docs.docker.com/engine/network/drivers/host/
> para más información.

El comando es bastante sencillo:

```shell
docker run -t --network host ghcr.io/javinator9889/acexy
```

Eso debería permitir que AceStream use UPnP libremente.

## Opciones de Configuración ⚙

Acexy tiene montones de opciones de configuración que te permiten personalizar el comportamiento. Todas ellas tienen
valores predeterminados que fueron probados para una experiencia óptima, pero puede que necesites ajustarlas
para que se adapten a tus necesidades.

> **PRO-TIP**: Puedes ejecutar `acexy -help` para obtener una vista completa de todas las opciones disponibles.

Como Acexy fue pensado para ejecutarse dentro de un contenedor Docker, todas las variables y configuraciones son
ajustables mediante variables de entorno.


<table>
  <thead>
    <tr>
      <th>Flag</th>
      <th>Variable de Entorno</th>
      <th>Descripción</th>
      <th>Predeterminado</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th><code>-license</code></th>
      <th>-</th>
      <th>Imprime la licencia del programa y sale</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-help</code></th>
      <th>-</th>
      <th>Imprime el mensaje de ayuda y sale</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-addr</code></th>
      <th><code>ACEXY_LISTEN_ADDR</code></th>
      <th>Dirección donde Acexy está escuchando. Útil cuando se ejecuta en modo <code>host</code>.</th>
      <th><code>:8080</code></th>
    <tr>
    <tr>
      <th><code>-scheme</code></th>
      <th><code>ACEXY_SCHEME</code></th>
      <th>
        El esquema del middleware AceStream. Si ha configurado AceStream para trabajar con HTTPS,
        tendrá que ajustar este valor.
      </th>
      <th><code>http</code></th>
    <tr>
    <tr>
      <th><code>-acestream-host</code></th>
      <th><code>ACEXY_HOST</code></th>
      <th>
        Dónde se encuentra el middleware AceStream. Cambie esto si necesita que Acexy se conecte a un
        motor AceStream diferente.
      </th>
      <th><code>localhost</code></th>
    <tr>
    <tr>
      <th><code>-acestream-port</code></th>
      <th><code>ACEXY_PORT</code></th>
      <th>
        El puerto para conectar con el middleware AceStream. Cambie esto si necesita que Acexy se conecte
        a un motor AceStream diferente.
      </th>
      <th><code>6878</code></th>
    <tr>
    <tr>
      <th><code>-m3u8-stream-timeout</code></th>
      <th><code>ACEXY_M3U8_STREAM_TIMEOUT</code></th>
      <th>
        Al ejecutar Acexy en modo M3U8, el tiempo de espera para considerar que una transmisión ha finalizado.
      </th>
      <th><code>60s</code></th>
    <tr>
    <tr>
      <th><code>-m3u8</code></th>
      <th><code>ACEXY_M3U8</code></th>
      <th>
        Habilitar el modo M3U8 en Acexy. <b>ADVERTENCIA</b>: Este modo es experimental y puede no funcionar como se espera.
      </th>
      <th>Deshabilitado</th>
    <tr>
    <tr>
      <th><code>-empty-timeout</code></th>
      <th><code>ACEXY_EMPTY_TIMEOUT</code></th>
      <th>
        Tiempo de espera para considerar que una transmisión ha finalizado una vez que se recibe información vacía del
        middleware. Inútil cuando se está en modo M3U8.
      </th>
      <th><code>1m</code></th>
    <tr>
    <tr>
      <th><code>-buffer-size</code></th>
      <th><code>ACEXY_BUFFER_SIZE</code></th>
      <th>
        Almacena en búfer hasta <code>buffer-size</code> bytes de una transmisión antes de copiar los datos al
        reproductor. Útil para tener mejor estabilidad durante las reproducciones.
      </th>
      <th><code>4.2MiB</code></th>
    <tr>
    <tr>
      <th><code>-no-response-timeout</code></th>
      <th><code>ACEXY_NO_RESPONSE_TIMEOUT</code></th>
      <th>
        Tiempo de espera para que el middleware AceStream devuelva una respuesta para una transmisión recién abierta.
        Esto debe ser lo más bajo posible a menos que tu conexión a Internet sea realmente mala
        (es decir: tengas latencias muy altas).
      </th>
      <th><code>1s</code></th>
    <tr>
  </tbody>
</table>

> **NOTA**: La lista de opciones es extensa pero podría estar desactualizada. Siempre consulta la
> salida del binario Acexy con `-help` en caso de duda.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---