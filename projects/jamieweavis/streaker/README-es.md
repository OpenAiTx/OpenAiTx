# Streaker <img alt="Logotipo de Streaker" align="right" width=40 height=40 alt="Captura de pantalla" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/./.github/icons/icon.svg">

Aplicación de barra de menú multiplataforma para el seguimiento de rachas y estadísticas de contribuciones en GitHub con notificación de recordatorio

[![ci](https://github.com/jamieweavis/streaker/actions/workflows/ci.yml/badge.svg)](https://github.com/jamieweavis/streaker/actions)
[![downloads](https://img.shields.io/github/downloads/jamieweavis/streaker/total.svg)](https://github.com/jamieweavis/streaker/releases)
[![version](https://img.shields.io/github/release/jamieweavis/streaker.svg)](https://github.com/jamieweavis/streaker/releases)
[![license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/jamieweavis/streaker/blob/main/LICENSE)

<img width="716" alt="Captura de pantalla" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/screenshot.png">

## Instalación

Descarga la última versión de Streaker desde la página de **[lanzamientos en GitHub](https://github.com/jamieweavis/streaker/releases)** (o consulta la sección **[Desarrollo](#development)** para compilarlo tú mismo).

## Características

- Estadísticas de contribución en la barra de menú
  - Racha
    - Mejor
    - Actual
    - Anterior
  - Contribuciones
    - Mayor (día)
    - Hoy
    - Total (año)
- El ícono de la barra de menú cambia según el estado de contribución
  - Vacío - no has contribuido hoy
  - Lleno - has contribuido hoy
  - Corona - actualmente estás en tu mejor racha
- Tres temas diferentes para el ícono de la barra de menú
  - Llama
  - Azulejo
  - Octocat
- Notificación de recordatorio para que no pierdas tu racha

### Íconos de la barra de menú

#### Modo Claro

| Estado | Llama | Baldosa | Octocat |
| ------ | ----- | ------- | ------- |
| Pendiente | <img width="20" alt="Flame Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac.svg"> | <img width="20" alt="Tile Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac.svg"> | <img width="20" alt="Octocat Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac.svg"> |
| Contribuido | <img width="20" alt="Flame Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac.svg"> | <img width="20" alt="Tile Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac.svg"> | <img width="20" alt="Octocat Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac.svg"> |
| En racha | <img width="20" alt="Flame Crown" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac.svg"> | <img width="20" alt="Tile Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac.svg"> | <img width="20" alt="Octocat Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac.svg"> |

#### Modo Oscuro

| Estado | Llama | Baldosa | Octocat |
| ------ | ----- | ------- | ------- |
| Pendiente | <img width="20" alt="Flame Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac-white.svg"> | <img width="20" alt="Tile Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac-white.svg"> | <img width="20" alt="Octocat Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac-white.svg"> |
| Contribuido | <img width="20" alt="Flame Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac-white.svg"> | <img width="20" alt="Tile Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac-white.svg"> | <img width="20" alt="Octocat Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac-white.svg"> |
| En racha | <img width="20" alt="Flame Crown" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac-white.svg"> | <img width="20" alt="Tile Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac-white.svg"> | <img width="20" alt="Octocat Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac-white.svg"> |

## Desarrollo

### Requisitos previos

- [Node.js](https://github.com/nodejs/node) (>=22.x.x)
- [pnpm](https://github.com/pnpm/pnpm) (>=10.x.x)

### Comenzando

Clona el repositorio e instala las dependencias:

```sh
git clone https://github.com/jamieweavis/streaker.git

cd streaker

pnpm install
```
Empaquete la aplicación para su plataforma actual:

```bash
pnpm package
```

_La aplicación empaquetada ahora estará en el directorio `out/`_

Ejecute la aplicación en modo de desarrollo:
```bash
pnpm start
```

*Solo el proceso del renderer soporta actualmente la recarga en caliente, los cambios en `src/main/` requerirán un reinicio*

## Relacionado

- [Streaker CLI](https://github.com/jamieweavis/streaker-cli) - Aplicación de línea de comandos para rastrear rachas y estadísticas de contribuciones en GitHub con gráfico ASCII de contribuciones
- [Contribution](https://github.com/jamieweavis/contribution) - Analizador de gráficos de contribuciones de GitHub que calcula la racha de contribuciones y estadísticas de commits desde la página del gráfico de contribuciones de un usuario en GitHub


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-11

---