<div align="center">
  <a href="https://iso.tim.cv/" target="_blank">
    <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-dashboard-bg-image.png" alt="Iso dashboard screenshot" width="800" />
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

**Iso** is a plug-and-play dashboard for all your self-hosted services.
Built for my personal homelab — now open-sourced for yours.

- **Fully configurable** through a single `config.json` file
- **Multi-language**: English, Español, Français, Deutsch
- **Icon ready**: choose from a set of built-in icons or supply your own
- **Docker-first**: run anywhere with one simple command

## ‍️Quick Start

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

Open http://localhost:3000 and you're up and running!

## Configuration

Iso is configured through a single `config.json` file located in the `/config` directory.

### Example Configuration

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
### Configuration Options

- **title**: Dashboard title displayed in the header
- **services**: Array of service objects with:
  - `order`: Display order (number)
  - `icon`: Icon name from built-in set
  - `label`: Service display name
  - `href`: Service URL
- **locale**: Language code (`en`, `es`, `fr`, `de`)
- **theme**: Color theme (e.g., `amethyst`)
- **greetings**: Custom greeting messages
- **pageLoadAnimation**: Enable/disable page animations
- **search**: Object containing search bar settings
  - `enabled`: Toggle visibility of the search bar
  - `engine`: Built-in search engine (`google`, `bing`, `duckduckgo`, `startpage`, `qwant`, `searx`, or `custom`)
  - `engineUrl`: Custom search engine URL. Use `[q]` as placeholder for the search query.
  - `placeholder`: Input placeholder text shown in the search bar

## Environment Variables

| Variable | Description | Default | Required |
|----------|-------------|---------|----------|
| `AUTH_SECRET` | Secret key for authentication | - | No |
| `AUTH_PASSWORD` | Password for dashboard access | - | No |
| `APP_DATA_PATH` | Path to config directory | `/config` | No |

## More Screenshots

<div style="display: flex;">
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-settings.png" alt="Iso settings screenshot" width="400" style="width: 49%;" />
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-login.png" alt="Iso login screenshot" width="400" style="width: 49%;" />
</div>

## Development

### Prerequisites

- Nix


Or

- The [Bun](https://bun.sh/) JavaScript runtime

### Local Setup

1. Clone the repository:
```bash
git clone https://github.com/Coyenn/iso.git
cd iso
```
2. Install dependencies:

```bash
bun install
```

3. Start the development server:
```bash
bun dev
```

4. Open http://localhost:3000 in your browser

## License

Distributed under the MIT License. See `LICENSE` for more information.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---