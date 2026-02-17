# ipregion

![imagen](https://i.imgur.com/CRxBuVR.gif)

## Uso

### Descargar y ejecutar localmente

```bash
wget -O ipregion.sh https://ipregion.vrnt.xyz
chmod +x ipregion.sh
```

### Ejecutar directamente desde GitHub

```bash
bash <(wget -qO- https://ipregion.vrnt.xyz)
```

### Docker

#### Ejecutar el contenedor para IPv4 (red puente Docker predeterminada)

Esto ejecuta la comprobación de geolocalización IP usando solo IPv4, sin requerir el modo de red del host:

```bash
docker run --rm vernette/ipregion:latest
```

Puede agregar opciones de script adicionales según sea necesario, por ejemplo:

```
docker run --rm vernette/ipregion:latest --group geoip
```

#### Ejecutar el contenedor con red de host (para IPv4 e IPv6 o interfaz personalizada)

Para acceder tanto a IPv4 como a IPv6 en las interfaces de red reales del host, o para especificar una interfaz de red personalizada (por ejemplo, eth1), use el modo de red host de Docker:

```bash
docker run --rm --network=host vernette/ipregion:latest
```

```bash
docker run --rm --network=host vernette/ipregion:latest --interface eth1
```

> [!NOTA]
> Al usar `--network=host`, el contenedor comparte la pila de red del host, lo que reduce el aislamiento de la red pero permite acceso completo a las interfaces. Sin `--network=host`, el contenedor usa la red puente de Docker, que puede no exponer IPv6 ni permitir la selección de interfaces

## Características

- Múltiples APIs GeoIP y servicios web (YouTube, Netflix, ChatGPT, Spotify, etc.)
- Soporte IPv4/IPv6 con proxy SOCKS5 e interfaz de red personalizada
- Salida JSON y tablas codificadas por colores

## Dependencias

- bash
- curl
- jq
- util-linux/bsdmainutils

## Opciones clave

```bash
./ipregion.sh --help # Show all options
./ipregion.sh --group primary # GeoIP services only
./ipregion.sh --group custom # Popular websites only
./ipregion.sh --ipv4 # IPv4 only
./ipregion.sh --ipv6 # IPv6 only
./ipregion.sh --proxy 127.0.0.1:1080 # Use SOCKS5 proxy
./ipregion.sh --json # JSON output
./ipregion.sh --debug # Debug mode
```

Todas las opciones pueden combinarse.

## Códigos de país

El script muestra los códigos de país en formato ISO 3166-1 alpha-2 (por ejemplo, RU, US, DE).

Puedes consultar el significado de cualquier código de país en el sitio oficial de ISO: [https://www.iso.org/obp/ui/#search/code/](https://www.iso.org/obp/ui/#search/code/)

Simplemente ingresa el código en el cuadro de búsqueda para obtener el nombre completo del país.

## Contribuciones

¡Se aceptan contribuciones! No dudes en enviar pull requests para agregar nuevos servicios o mejorar la funcionalidad del script.

![Gráfico de Historial de Estrellas](https://api.star-history.com/svg?repos=vernette/ipregion&type=Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---