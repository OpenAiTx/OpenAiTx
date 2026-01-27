<h1 align="center">Punition de la défaite — Contrôleur de jeu Coyote</h1>
<div align="center">
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/actions"><img src="https://img.shields.io/github/actions/workflow/status/hyperzlib/DG-Lab-Coyote-Game-Hub/node.js.yml"></a>
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases"><img src="https://img.shields.io/github/release-date/hyperzlib/DG-Lab-Coyote-Game-Hub"></a>
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/commits/main/"><img src="https://img.shields.io/github/last-commit/hyperzlib/DG-Lab-Coyote-Game-Hub"></a>
</div>
<p></p>
<div align="center">
  <a href="https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/actions">Télécharger</a>
  |
  <a href="https://www.bilibili.com/video/BV17m421G7fm/">Aperçu</a>
  |
  <a href="docs/api.md">API du plugin</a>
</div>
<p></p>
<div align="center">
  <img src="https://raw.githubusercontent.com/hyperzlib/DG-Lab-Coyote-Game-Hub/main/docs/images/screenshot-widget.png" height="200" alt="Capture d'écran du widget">
</div>

## Remarques

Veuillez respecter les règles de la plateforme de streaming, n’utilisez pas ce composant de manière illégale. L’auteur de ce composant n’est pas responsable des sanctions telles que la suspension du live causées par son utilisation.

## Mode d’emploi (version binaire Windows)

1. Téléchargez depuis [Releases](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases) le fichier ```coyote-game-hub-windows-amd64-dist.zip``` : [Cliquez ici](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)
2. Décompressez et lancez ```start.bat``` pour démarrer le serveur

## Mode d’emploi (ligne de commande Linux/MacOS)
1. Installez nodejs (Linux recommande nvm, Mac utilisez ```brew install node@22```)
2. Téléchargez depuis [Releases](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases) le fichier ```coyote-game-hub-nodejs-server.zip``` : [Cliquez ici](https://github.com/hyperzlib/DG-Lab-Coyote-Game-Hub/releases)
3. Dans le dossier décompressé, exécutez ```node server/index.js```

## Mode d’emploi (compilation)

(L’exemple suivant utilise ```pnpm``` pour installer les dépendances, vous pouvez aussi utiliser ```npm``` ou ```yarn```)

1. Allez dans le dossier ```server```, lancez ```pnpm install``` pour installer les dépendances

2. Allez dans le dossier ```frontend```, lancez ```pnpm install``` pour installer les dépendances
3. Dans le répertoire racine du projet, exécutez ```pnpm install``` pour installer les dépendances, puis ```npm run build``` pour compiler le projet

4. Dans le répertoire racine du projet, exécutez ```npm start``` pour démarrer le serveur

5. Ouvrez dans le navigateur ```http://localhost:8920``` pour voir le panneau de contrôle

## Structure du projet

- ```server``` : code côté serveur
- ```frontend``` : code côté frontend



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-27

---