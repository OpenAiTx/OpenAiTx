[![Logo de Electron](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![Estado de compilación GitHub Actions](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Invitación a Discord de Electron](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: Traducciones disponibles: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
Consulta estos documentos en otros idiomas en nuestro proyecto de [Crowdin](https://crowdin.com/project/electron).

El framework Electron te permite crear aplicaciones de escritorio multiplataforma usando JavaScript, HTML y CSS. Está basado en [Node.js](https://nodejs.org/) y [Chromium](https://www.chromium.org) y es utilizado por [Visual Studio Code](https://github.com/Microsoft/vscode/) y muchas otras [aplicaciones](https://electronjs.org/apps).

Sigue a [@electronjs](https://twitter.com/electronjs) en Twitter para anuncios importantes.

Este proyecto sigue el [código de conducta](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md) de Contributor Covenant.
Al participar, se espera que respetes este código. Por favor, reporta comportamientos inaceptables a [coc@electronjs.org](mailto:coc@electronjs.org).

## Instalación

Para instalar los binarios precompilados de Electron, utiliza [`npm`](https://docs.npmjs.com/).
El método preferido es instalar Electron como una dependencia de desarrollo en tu aplicación:

```sh
npm install electron --save-dev
```

Para más opciones de instalación y consejos de solución de problemas, consulta [instalación](docs/tutorial/installation.md). Para información sobre cómo gestionar versiones de Electron en tus aplicaciones, consulta [Versionado de Electron](docs/tutorial/electron-versioning.md).

## Compatibilidad de plataformas

Cada versión de Electron proporciona binarios para macOS, Windows y Linux.

* macOS (Big Sur y superior): Electron proporciona binarios de 64 bits para Intel y Apple Silicon / ARM para macOS.
* Windows (Windows 10 y superior): Electron proporciona binarios `ia32` (`x86`), `x64` (`amd64`) y `arm64` para Windows. El soporte para Windows en ARM fue añadido en Electron 5.0.8. El soporte para Windows 7, 8 y 8.1 fue [eliminado en Electron 23, en línea con la política de desaprobación de Windows de Chromium](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: Los binarios precompilados de Electron se construyen en Ubuntu 20.04. También se ha verificado que funcionan en:
  * Ubuntu 18.04 y superior
  * Fedora 32 y superior
  * Debian 10 y superior

## Electron Fiddle

Utiliza [`Electron Fiddle`](https://github.com/electron/fiddle) para construir, ejecutar y empaquetar pequeños experimentos con Electron, ver ejemplos de código para todas las APIs de Electron y probar diferentes versiones de Electron. Está diseñado para facilitar el inicio de tu recorrido con Electron.

## Recursos para aprender Electron

* [electronjs.org/docs](https://electronjs.org/docs) - Toda la documentación de Electron
* [electron/fiddle](https://github.com/electron/fiddle) - Una herramienta para construir, ejecutar y empaquetar pequeños experimentos con Electron
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - Aplicaciones iniciales de ejemplo creadas por la comunidad

## Uso programático

La mayoría de las personas usan Electron desde la línea de comandos, pero si requieres `electron` dentro de tu **aplicación Node** (no tu aplicación Electron) devolverá la ruta del archivo binario. Utilízalo para lanzar Electron desde scripts de Node:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// imprimirá algo similar a /Users/maf/.../Electron
console.log(electron)

// lanzar Electron
const child = proc.spawn(electron)
```

### Espejos

* [China](https://npmmirror.com/mirrors/electron/)

Consulta las [Instrucciones avanzadas de instalación](https://www.electronjs.org/docs/latest/tutorial/installation#mirror) para aprender cómo usar un espejo personalizado.

## Traducciones de la documentación

Gestionamos traducciones de nuestra documentación de forma colaborativa a través de [Crowdin](https://crowdin.com/project/electron).
Actualmente aceptamos traducciones para chino (simplificado), francés, alemán, japonés, portugués, ruso y español.

## Contribuir

Si estás interesado en reportar/solucionar problemas y contribuir directamente a la base de código, consulta [CONTRIBUTING.md](CONTRIBUTING.md) para más información sobre lo que buscamos y cómo empezar.

## Comunidad

La información para reportar errores, obtener ayuda, encontrar herramientas de terceros y aplicaciones de ejemplo, y más se encuentra en la [página de la comunidad](https://www.electronjs.org/community).

## Licencia

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Cuando uses los logos de Electron, asegúrate de seguir la [Política de Marcas Registradas de OpenJS Foundation](https://trademark-policy.openjsf.org/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---