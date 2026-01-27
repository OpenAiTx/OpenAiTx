<h1 align="center"> Penalización por Derrota — Controlador del Juego Coyote</h1>
<div align="center">
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/actions"><img src="https://img.shields.io/github/actions/workflow/status/hyperzlib/DG-Lab-Coyote-Game-Hub/node.js.yml"></a>
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases"><img src="https://img.shields.io/github/release-date/hyperzlib/DG-Lab-Coyote-Game-Hub"></a>
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/commits/main/"><img src="https://img.shields.io/github/last-commit/hyperzlib/DG-Lab-Coyote-Game-Hub"></a>
</div>
<p></p>
<div align="center">
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/actions">Descargar</a>
  |
  <a href="https://www.bilibili.com/video/BV17m421G7fm/">Vista previa</a>
  |
  <a href="docs/api.md">API del Plugin</a>
</div>
<p></p>
<div align="center">
  <img src="https://raw.githubusercontent.com/hyperzlib/DG-Lab-Coyote-Game-Hub/main/docs/images/screenshot-widget.png" height="200" alt="Captura del Widget">
</div>

## Notas Importantes

Por favor, cumpla con las normativas de la plataforma de transmisión en vivo, no utilice este componente de manera indebida; el autor no se responsabiliza por sanciones como el bloqueo del canal causadas por el uso inapropiado de este componente.

## Método de Uso (Distribución binaria para Windows)

1. Descargue ```coyote-game-hub-windows-amd64-dist.zip``` desde [Releases](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases): [Click aquí](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)
2. Descomprima y ejecute ```start.bat``` para iniciar el servidor

## Método de Uso (Línea de comandos para Linux/MacOS)
1. Instale nodejs (se recomienda usar nvm en Linux, en Mac use ```brew install node@22```)
2. Descargue ```coyote-game-hub-nodejs-server.zip``` desde [Releases](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases): [Click aquí](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)
3. En la ruta descomprimida ejecute ```node server/index.js```

## Método de Uso (Compilación)

(En los siguientes ejemplos se usa ```pnpm``` para instalar dependencias, también puede usar ```npm``` o ```yarn```)

1. Ingrese al directorio ```server``` y ejecute ```pnpm install``` para instalar dependencias

2. Ingrese al directorio ```frontend``` y ejecute ```pnpm install``` para instalar dependencias
3. En el directorio raíz del proyecto, ejecute ```pnpm install``` para instalar las dependencias, luego ejecute ```npm run build``` para compilar el proyecto

4. En el directorio raíz del proyecto, ejecute ```npm start``` para iniciar el servidor

5. Abra en el navegador ```http://localhost:8920``` para ver el panel de control

## Estructura del proyecto

- ```server```: código del lado del servidor
- ```frontend```: código del frontend



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-27

---