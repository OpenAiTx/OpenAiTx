<h1 align="center"> Defeat Punishment - Coyote Game Controller</h1>
<div align="center">
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/actions"><img src="https://img.shields.io/github/actions/workflow/status/hyperzlib/DG-Lab-Coyote-Game-Hub/node.js.yml"></a>
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases"><img src="https://img.shields.io/github/release-date/hyperzlib/DG-Lab-Coyote-Game-Hub"></a>
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/commits/main/"><img src="https://img.shields.io/github/last-commit/hyperzlib/DG-Lab-Coyote-Game-Hub"></a>
</div>
<p></p>
<div align="center">
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/actions">Download</a>
  |
  <a href="https://www.bilibili.com/video/BV17m421G7fm/">Preview</a>
  |
  <a href="docs/api.md">Plugin API</a>
</div>
<p></p>
<div align="center">
  <img src="https://raw.githubusercontent.com/hyperzlib/DG-Lab-Coyote-Game-Hub/main/docs/images/screenshot-widget.png" height="200" alt="Widget Screenshot">
</div>

## Notes

Please comply with the relevant regulations of the streaming platform and do not use this widget in violation of rules. The author of this widget is not responsible for any consequences such as channel bans caused by using this widget.

## Usage (Windows Binary Distribution)

1. Download ```coyote-game-hub-windows-amd64-dist.zip``` from [Releases](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases): [Click to go](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)
2. Extract and run ```start.bat``` to start the server

## Usage (Linux/MacOS Command Line)
1. Install nodejs (for Linux, nvm is recommended; for Mac use ```brew install node@22```)
2. Download ```coyote-game-hub-nodejs-server.zip``` from [Releases](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases): [Click to go](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)
3. Run ```node server/index.js``` in the extracted directory

## Usage (Compile and Use)

(The following example uses ```pnpm``` to install dependencies; you can also use ```npm``` or ```yarn```)

1. Enter the ```server``` directory and run ```pnpm install``` to install dependencies

2. Enter the ```frontend``` directory and run ```pnpm install``` to install dependencies

3. Run ```pnpm install``` in the project root directory to install dependencies, then run ```npm run build``` to compile the project

4. Run ```npm start``` in the project root directory to start the server

5. Open ```http://localhost:8920``` in the browser to see the control panel

## Project Structure

- ```server```: Server-side code
- ```frontend```: Front-end code


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-27

---