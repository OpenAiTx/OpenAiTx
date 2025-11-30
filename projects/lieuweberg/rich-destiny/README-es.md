![GitHub all releases](https://img.shields.io/github/downloads/lieuweberg/rich-destiny/total) ![GitHub release (latest by date)](https://img.shields.io/github/downloads/lieuweberg/rich-destiny/latest/total) ![Time spent coding (15 minute timeout)](https://wakatime.com/badge/user/a637a12a-da87-4487-8b1e-660151dc3e7b/project/94fa2fc6-7e9b-4c74-b6eb-4ce6a09b4cdf.svg)

# rich-destiny
| <img src="https://richdestiny.app/favicon.ico" width="100"> | Programa de fondo plug-and-play que pone tu actividad actual de Destiny 2 en tu estado de Discord. Moderno, sin capturas de pantalla inestables y muy pequeño en tamaño. |
| :---: | :---: |

## Contribuir ✨

Si quieres contribuir, ¡genial! Para nuevas funciones, por favor pregunta primero en el servidor de Discord o crea un issue con lo que quieres hacer. Si quieres arreglar un error, solo crea un PR. Sin embargo, se recomienda preguntar, en caso de que "no sea un error, sea una función."

## Desarrollo 🛠
Requisitos previos:
 - (cliente) Tener una versión reciente de Go 1.x.
 - (cliente) Para Windows: tener git bash. También puedes ejecutar los comandos del script de compilación manualmente pero yo uso el script bash :)
 - (web) Tener una versión reciente de Node.js y npm.

Compilación:
 - Clona el repositorio.
  
 - El cliente:
   - `cd client`
   - Duplica el `config.go.example` a `config.go` y rellena los valores. Para el URI de redirección, puedes usar `https://richdestiny.app/login` -- también en el portal de desarrolladores de Bungie.net. Es solo una redirección al redirect local.
   - `go get`
   - `./build dev`
     - Puedes usar `./build vX.Y.Z` con un número de versión semver válido, pero para propósitos de desarrollo usa dev. Esto desactiva automáticamente las actualizaciones y posiblemente otras cosas en el futuro.

 - El sitio web:
   - `cd web`
   - `npm install`
   - `npm run start` para un servidor de desarrollo local o `npm run build` para una compilación de producción.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-30

---