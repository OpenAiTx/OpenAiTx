# Mousehole, un Actualizador de IP para Seedbox en MAM

Un servicio en segundo plano para actualizar la IP de una seedbox para MAM y un servidor HTTP para gestionarlo.

![Mousehole Demo](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/images/demo.webp)

Esto puede ser útil si usas un host/VPN/seedbox para sembrar y su dirección IP no es estable.

Características:

- Servicio en segundo plano que actualiza regularmente MAM con la dirección IP del host.

  Antes de una actualización, Mousehole verifica si realmente necesita actualizar
  comparando la IP actual del host y el AS con la última respuesta de MAM.

- Sitio web frontend para gestionar el servicio, permitiendo:

  - Configurar tu cookie de MAM
  - Mostrar información de estado
  - Activar comprobaciones manualmente

- Servidor API con endpoints de gestión.

  Consulta [API.md](https://github.com/t-mart/mousehole/blob/master/docs/API.md) para
  más detalles.

## Primeros Pasos

Para usar Mousehole, necesitas:

1. [Ejecutar el servicio](#running-the-service)
2. [Configurar tu cookie de MAM vía la interfaz web](#setting-your-mam-cookie)
3. [Manejar errores de MAM](#handling-errors) (si los hay)

### Ejecutando el servicio

#### Docker Compose (recomendado)



```yaml
services:
  gluetun:
    image: qmcgaw/gluetun:latest
    cap_add:
      - NET_ADMIN
    devices:
      - /dev/net/tun:/dev/net/tun
    ports:
      - "5010:5010" # Mousehole port
      - "8080:8080" # qBittorrent Web UI port
      - "6881:6881/tcp" # qBittorrent TCP torrent port
      - "6881:6881/udp" # qBittorrent UDP torrent port
    environment:
      VPN_SERVICE_PROVIDER: "your-vpn-provider"
      FIREWALL_VPN_INPUT_PORTS: "6881" # qBittorrent torrent
      # more is needed here -- see Gluetun documentation
      # https://github.com/qdm12/gluetun-wiki
      # https://github.com/qdm12/gluetun-wiki/tree/main/setup/providers
    restart: unless-stopped

  qbittorrent:
    image: lscr.io/linuxserver/qbittorrent:latest
    network_mode: "service:gluetun"
    environment:
      TZ: Etc/UTC # Set to your timezone for localization
      WEBUI_PORT: 8080
      TORRENTING_PORT: 6881
    restart: unless-stopped

  mousehole:
    image: tmmrtn/mousehole:latest
    network_mode: "service:gluetun"
    environment:
      TZ: Etc/UTC # Set to your timezone for localization
    volumes:
      # persist cookie data across container restarts
      - "mousehole:/srv/mousehole"
    restart: unless-stopped

volumes:
  mousehole:
```


Ejemplos iniciales de Docker Compose:

- ⭐ [Gluetun + qBittorrent + Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/gluetun-qb.md)
- [Wireguard + qBittorrent + Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/wireguard-qb.md)
- [Ejemplo sin VPN](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/non-vpn.md)

Cualquier configuración de VPN puede adaptarse para incluir Mousehole como sidecar. Ver
[Uso de Mousehole como Sidecar con Docker Compose](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/sidecars.md) para
más detalles.

#### Unraid

Consulte la [Guía de instalación de Unraid](https://raw.githubusercontent.com/t-mart/mousehole/master/./contrib/unraid/README.md) para
instrucciones.

#### Local

Ejecute el servidor con:

```bash
bun run start
```

### Configuración de su Cookie MAM

Una vez que Mousehole esté en funcionamiento, navegue a su interfaz web en `http://<host>:5010` en
su navegador. Es probable que sea <http://localhost:5010> si lo está ejecutando
localmente.

Al ejecutarlo por primera vez (o si la cookie se desincroniza), debe
configurar la cookie de Mousehole manualmente.

Al navegar a la interfaz web de Mousehole, verá un formulario para configurar la
cookie -- pegue su cookie y haga clic en el botón "Set".

![Formulario de Cookie de Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/images/cookie-form.png)

Si necesita ayuda para obtener la cookie, haga clic en el botón "¿Qué debo ingresar aquí?"
para un tutorial.


### Manejo de Errores

Incluso con Mousehole en funcionamiento, pueden ocurrir problemas que Mousehole
no puede solucionar automáticamente. Aquí están algunos de los más comunes:

- ["Sesión inválida - Desajuste ASN"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/asn-mismatch.md)
- ["Sesión inválida - Cookie inválida"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/invalid-cookie.md)
- ["Último cambio demasiado reciente"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/last-change-too-recent.md)

## Etiquetas de Docker

Mousehole publica varias etiquetas de imagen en
[Docker Hub](https://hub.docker.com/r/tmmrtn/mousehole):

- Versiones SemVer (`0`, `0.1`, `0.1.11`, etc)
- `latest`, la última versión lanzada
- `edge`, la punta de la rama `master`
- Pull requests dirigidos a `master` para pruebas, etiquetados como `pr-<número>`

Elija `latest` si no sabe cuál escoger.

## Variables de Entorno

- `MOUSEHOLE_PORT`: _(Por defecto `5010`)_ El puerto en el que el servidor HTTP escuchará.
- `MOUSEHOLE_STATE_DIR_PATH`: _(Por defecto `/srv/mousehole`)_ El directorio donde
  el servicio almacenará sus datos.
- `MOUSEHOLE_USER_AGENT`: _(Por defecto `mousehole-by-timtimtim/<version>`)_ El
  agente de usuario a usar para las solicitudes a MAM.
- `MOUSEHOLE_CHECK_INTERVAL_SECONDS`: _(Por defecto `300` (5 minutos))_ El intervalo
  en segundos entre comprobaciones.
- `MOUSEHOLE_STALE_RESPONSE_SECONDS`: _(Por defecto `86400` (1 día))_ El número de
  segundos tras los cuales una respuesta de MAM se considera obsoleta. Esto asegura que
  Mousehole sigue comunicándose con MAM a intervalos regulares y detecta
  cambios fuera de banda en la cookie.
- `TZ`: _(Por defecto `Etc/UTC`)_ La zona horaria para mostrar horas localizadas.

## Contribuir

¿Quieres contribuir? Consulta las [directrices de contribución](https://raw.githubusercontent.com/t-mart/mousehole/master/./CONTRIBUTING.md).

También hay un directorio [`contrib`](./contrib/) con funcionalidades útiles y complementarias.

## Enlaces

- [Repositorio](https://github.com/t-mart/mousehole)
- [Imagen en Docker Hub](https://hub.docker.com/r/tmmrtn/mousehole)
- [Publicación en el foro](https://www.myanonamouse.net/f/t/84712/p/p1013257)

## Desarrollo

- Inicia el servidor de desarrollo con:



  ```bash
  bun run dev
  ```
- Las nuevas versiones pueden ser etiquetadas, lanzadas y enviadas a Docker Hub simplemente
  cambiando la versión en `package.json` y haciendo push a GitHub. Los flujos de trabajo de CI
  se encargarán del resto.

## Atribución

Mouse Hole por Sergey Demushkin de
[Noun Project](https://thenounproject.com/term/mouse-hole/) (CC BY 3.0)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---