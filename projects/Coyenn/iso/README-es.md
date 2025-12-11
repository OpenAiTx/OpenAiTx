<div align="center">
  <a href="https://iso.tim.cv/" target="_blank">
    <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-dashboard-bg-image.png" alt="Captura de pantalla del panel de Iso" width="800" />
  </a>
</div>

<br />
<div align="center">
  <a href="https://iso.tim.cv" target="_blank">Demo</a>
  |
  <a href="https://hub.docker.com/r/coyann/iso" target="_blank">Docker</a>
  |
  <a href="https://github.com/Coyenn/iso/" target="_blank">GitHub</a>
</div>
<br />

**Iso** es un panel plug-and-play para todos tus servicios autoalojados.
Construido para mi homelab personal — ahora de código abierto para el tuyo.

- **Totalmente configurable** a través de un solo archivo `config.json`
- **Multilenguaje**: Inglés, Español, Francés, Alemán
- **Listo para iconos**: elige entre un conjunto de iconos integrados o suministra los tuyos
- **Docker-first**: ejecuta en cualquier lugar con un solo comando simple

## ‍️Inicio rápido

### Docker

```bash
docker run -d \
  --name iso \
  -p 3000:3000 \
  -e AUTH_SECRET="changeme" \
  -e AUTH_PASSWORD="changeme" \
  -v ./config:/config \
  coyann/iso
```

### Docker Compose

```yaml
services:
  iso:
    image: coyann/iso:latest
    container_name: iso
    ports:
      - "3000:3000"
    environment:
      - AUTH_SECRET=changeme
      - AUTH_PASSWORD=changeme
    volumes:
      - ./config:/config
    restart: unless-stopped
```

Abre http://localhost:3000 y estarás listo para usarlo!

## Configuración

Iso se configura mediante un único archivo `config.json` ubicado en el directorio `/config`.

### Ejemplo de Configuración

```json
{
  "title": "My Dashboard",
  "services": [
    {
      "order": 1,
      "icon": "tv",
      "label": "Plex",
      "href": "https://plex.example.com"
    },
    {
      "order": 2,
      "icon": "lock",
      "label": "Bitwarden",
      "href": "https://vault.example.com"
    }
  ],
  "locale": "en",
  "theme": "amethyst",
  "greetings": [],
  "pageLoadAnimation": true,
  "search": {
    "enabled": true,
    "engine": "google",
    "engineUrl": "",
    "placeholder": "Search ..."
  }
}
```

### Opciones de Configuración

- **title**: Título del panel mostrado en el encabezado
- **services**: Array de objetos de servicio con:
  - `order`: Orden de visualización (número)
  - `icon`: Nombre del ícono del conjunto incorporado
  - `label`: Nombre para mostrar del servicio
  - `href`: URL del servicio
- **locale**: Código de idioma (`en`, `es`, `fr`, `de`)
- **theme**: Tema de color (por ejemplo, `amethyst`)
- **greetings**: Mensajes de saludo personalizados
- **pageLoadAnimation**: Habilitar/deshabilitar animaciones de página
- **search**: Objeto que contiene configuraciones de la barra de búsqueda
  - `enabled`: Alternar visibilidad de la barra de búsqueda
  - `engine`: Motor de búsqueda incorporado (`google`, `bing`, `duckduckgo`, `startpage`, `qwant`, `searx`, o `custom`)
  - `engineUrl`: URL de motor de búsqueda personalizado. Use `[q]` como marcador de posición para la consulta de búsqueda.
  - `placeholder`: Texto de marcador de posición mostrado en la barra de búsqueda

## Variables de Entorno

| Variable | Descripción | Predeterminado | Requerido |
|----------|-------------|----------------|-----------|
| `AUTH_SECRET` | Clave secreta para autenticación | - | No |
| `AUTH_PASSWORD` | Contraseña para acceso al panel | - | No |
| `APP_DATA_PATH` | Ruta al directorio de configuración | `/config` | No |

## Más Capturas de Pantalla

<div style="display: flex;">
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-settings.png" alt="Captura de pantalla de configuración de Iso" width="400" style="width: 49%;" />
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-login.png" alt="Captura de pantalla de inicio de sesión de Iso" width="400" style="width: 49%;" />
</div>

## Desarrollo

### Prerrequisitos

- Nix

O

- El runtime de JavaScript [Bun](https://bun.sh/)

### Configuración Local

1. Clona el repositorio:
```bash
git clone https://github.com/Coyenn/iso.git
cd iso
```
2. Instalar dependencias:

```bash
bun install
```

3. Inicie el servidor de desarrollo:
```bash
bun dev
```

4. Abra http://localhost:3000 en su navegador

## Licencia

Distribuido bajo la Licencia MIT. Consulte `LICENSE` para más información.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---