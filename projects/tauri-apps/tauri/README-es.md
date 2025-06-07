<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-estable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20o%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## Introducción

Tauri es un framework para construir binarios pequeños y extremadamente rápidos para todas las principales plataformas de escritorio. Los desarrolladores pueden integrar cualquier framework de frontend que compile a HTML, JS y CSS para construir su interfaz de usuario. El backend de la aplicación es un binario construido en Rust con una API con la que el frontend puede interactuar.

La interfaz de usuario en las aplicaciones Tauri actualmente utiliza [`tao`](https://docs.rs/tao) como biblioteca de manejo de ventanas en macOS, Windows, Linux, Android e iOS. Para renderizar tu aplicación, Tauri utiliza [WRY](https://github.com/tauri-apps/wry), una biblioteca que proporciona una interfaz unificada al webview del sistema, utilizando WKWebView en macOS e iOS, WebView2 en Windows, WebKitGTK en Linux y Android System WebView en Android.

Para saber más sobre cómo encajan todas estas piezas, consulta este documento [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md).

## Primeros Pasos

Si estás interesado en crear una aplicación Tauri, por favor visita el [sitio web de la documentación](https://tauri.app).

La forma más rápida de comenzar es instalar los [prerrequisitos](https://v2.tauri.app/start/prerequisites/) para tu sistema y crear un nuevo proyecto con [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage). Por ejemplo, con `npm`:

```sh
npm create tauri-app@latest
```

## Características

La lista de características de Tauri incluye, pero no se limita a:

- Empaquetador de aplicaciones integrado para crear paquetes de la aplicación en formatos como `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` e instaladores de Windows como `.exe` (a través de NSIS) y `.msi` (a través de WiX).
- Actualizador automático integrado (solo escritorio)
- Iconos en la bandeja del sistema
- Notificaciones nativas
- Protocolo WebView nativo (tauri no crea un servidor localhost http(s) para servir el contenido de WebView)
- Acción de GitHub para CI optimizado
- Extensión para VS Code

### Plataformas

Tauri actualmente soporta el desarrollo y distribución en las siguientes plataformas:

| Plataforma | Versiones                                                                                                         |
| :--------- | :--------------------------------------------------------------------------------------------------------------- |
| Windows    | 7 y superiores                                                                                                   |
| macOS      | 10.15 y superiores                                                                                               |
| Linux      | webkit2gtk 4.0 para Tauri v1 (por ejemplo Ubuntu 18.04). webkit2gtk 4.1 para Tauri v2 (por ejemplo Ubuntu 22.04).|
| iOS/iPadOS | 9 y superiores                                                                                                   |
| Android    | 7 y superiores (actualmente 8 y superiores)                                                                      |

## Contribuir

Antes de comenzar a trabajar en algo, es mejor comprobar si ya existe una incidencia abierta. También es buena idea pasar por el servidor de Discord y confirmar con el equipo si tiene sentido o si alguien más ya está trabajando en ello.

Por favor, asegúrate de leer la [Guía de Contribución](./.github/CONTRIBUTING.md) antes de hacer un pull request.

¡Gracias a todos los que contribuyen a Tauri!

### Documentación

La documentación en un sistema multilingüe es una propuesta complicada. Por ello, preferimos utilizar documentación inline en el código fuente de Rust y JS tanto como sea posible. Consulta el repositorio que aloja el sitio de documentación para más información: <https://github.com/tauri-apps/tauri-docs>

## Socios

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

Para la lista completa de patrocinadores por favor visita nuestro [sitio web](https://tauri.app#sponsors) y [Open Collective](https://opencollective.com/tauri).

## Organización

Tauri busca ser un colectivo sostenible basado en principios que guían a las [comunidades sostenibles de software libre y abierto](https://sfosc.org). Para este fin, se ha convertido en un Programa dentro de la [Commons Conservancy](https://commonsconservancy.org/), y puedes contribuir financieramente a través de [Open Collective](https://opencollective.com/tauri).

## Licencias

Código: (c) 2015 - Presente - El Programa Tauri dentro de The Commons Conservancy.

MIT o MIT/Apache 2.0 donde sea aplicable.

Logo: CC-BY-NC-ND

- Diseños originales del logo de Tauri por [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) y [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---