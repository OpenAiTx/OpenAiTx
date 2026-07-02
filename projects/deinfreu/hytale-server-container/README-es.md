<div align="center" width="100%">

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Dark.png">
  <source media="(prefers-color-scheme: light)" srcset="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Light.png">
  <img alt="Docker Hytale Server Logo" src="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Light.png" width="800">
</picture>

[![GitHub stars](https://img.shields.io/github/stars/deinfreu/hytale-server-container?style=for-the-badge&color=daaa3f)](https://github.com/deinfreu/hytale-server-container)
[![GitHub last commit](https://img.shields.io/github/last-commit/deinfreu/hytale-server-container?style=for-the-badge)](https://github.com/deinfreu/hytale-server-container)
[![Discord](https://img.shields.io/discord/1458149014808821965?style=for-the-badge&label=Discord&labelColor=5865F2)](https://discord.gg/M8yrdnHb32)
[![Docker Pulls](https://img.shields.io/docker/pulls/deinfreu/hytale-server?style=for-the-badge)](https://hub.docker.com/r/deinfreu/hytale-server)
[![Docker Image Size (tag)](https://img.shields.io/docker/image-size/deinfreu/hytale-server/latest-alpine-liberica?sort=date&style=for-the-badge&label=ALPINE%20LIBERICA%20SIZE)](https://hub.docker.com/layers/deinfreu/hytale-server/latest-alpine-liberica/images/)
[![GitHub license](https://img.shields.io/github/license/deinfreu/hytale-server-container?style=for-the-badge)](https://github.com/deinfreu/hytale-server-container/blob/main/LICENSE)

Despliega un servidor dedicado de Hytale con una imagen Docker enfocada en la comunidad creada por más de 10 colaboradores. Este proyecto simplifica el autoalojamiento de Hytale con herramientas integradas de seguridad, redes y depuración. Únete a nuestro Discord activo para soporte directo y para conectar con otros propietarios de servidores. Ya sea que estés probando mods o ejecutando un mundo persistente, este contenedor proporciona un entorno consistente y listo para producción con un solo comando.

</div>

## Soporte y Recursos

* **Documentación:** Optimización detallada del rendimiento y especificaciones de seguridad se encuentran en los [Documentos del Proyecto](https://hytale-server-container.com/?utm_source=github&utm_medium=social&utm_campaign=github_readme).
* **Solución de problemas:** Revisa la página de [soporte](https://hytale-server-container.com/installation/support//?utm_source=github&utm_medium=social&utm_campaign=github_readme) y nuestra [Política de Seguridad](https://raw.githubusercontent.com/deinfreu/hytale-server-container/main/SECURITY.md) antes de reportar problemas. También puedes visitar nuestro [Discord](https://discord.com/invite/2kn2T6zpaV)

## Inicio rápido

Instala docker [CLI](https://docs.docker.com/engine/install/) en Linux o la [GUI](https://docs.docker.com/desktop) en Windows, macOS y Linux

Puedes ejecutar el contenedor ejecutando esto en tu CLI

```bash
docker run \
  --name hytale-server \
  -e SERVER_IP="0.0.0.0" \
  -e SERVER_PORT="5520" \
  -e PROD="FALSE" \
  -e DEBUG="FALSE" \
  -e TZ="Europe/Amsterdam" \
  -p 5520:5520/udp \
  -v "hytale-server:/home/container" \
  -v "/etc/machine-id:/etc/machine-id:ro" \
  --restart unless-stopped \
  deinfreu/hytale-server:latest
```

Alternativamente, puedes desplegar usando Docker Compose. Usa la configuración a continuación o explora la carpeta de [ejemplos](https://github.com/deinfreu/hytale-server-container/tree/main/examples) para plantillas más avanzadas.

```bash
services:
  hytale:
    image: deinfreu/hytale-server:latest
    container_name: hytale-server
    environment:
      SERVER_IP: "0.0.0.0"
      SERVER_PORT: "5520"
      PROD: "FALSE"
      DEBUG: "FALSE"
      TZ: "Europe/Amsterdam"
    restart: unless-stopped
    ports:
      - "5520:5520/udp"
    volumes:
      - ./data:/home/container
      - /etc/machine-id:/etc/machine-id:ro
    tty: true
    stdin_open: true
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-02

---