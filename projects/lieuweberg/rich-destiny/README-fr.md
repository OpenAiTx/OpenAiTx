![GitHub all releases](https://img.shields.io/github/downloads/lieuweberg/rich-destiny/total) ![GitHub release (latest by date)](https://img.shields.io/github/downloads/lieuweberg/rich-destiny/latest/total) ![Time spent coding (15 minute timeout)](https://wakatime.com/badge/user/a637a12a-da87-4487-8b1e-660151dc3e7b/project/94fa2fc6-7e9b-4c74-b6eb-4ce6a09b4cdf.svg)

# rich-destiny
| <img src="https://richdestiny.app/favicon.ico" width="100"> | Programme d’arrière-plan plug-and-play qui affiche votre activité actuelle dans Destiny 2 dans votre statut Discord. Moderne, sans captures d’écran instables et de petite taille. |
| :---: | :---: |

## Contribution ✨

Si vous souhaitez contribuer, génial ! Pour les nouvelles fonctionnalités, veuillez d’abord demander sur le serveur Discord ou créer un ticket avec ce que vous souhaitez réaliser. Si vous voulez corriger un bug, créez simplement une PR. Il est toutefois recommandé de demander, au cas où « ce n’est pas un bug, c’est une fonctionnalité ».

## Développement 🛠
Prérequis :
 - (client) Avoir une version récente de Go 1.x.
 - (client) Pour Windows : avoir git bash. Vous pouvez aussi exécuter les commandes du script de build manuellement, mais j’utilise le script bash :)
 - (web) Avoir une version récente de Node.js et npm.

Compilation :
 - Cloner le dépôt.
  
 - Le client :
   - `cd client`
   - Dupliquer `config.go.example` en `config.go` et remplir les valeurs. Pour l’URI de redirection, vous pouvez utiliser `https://richdestiny.app/login` -- également sur le portail développeur Bungie.net. C’est simplement une redirection vers la redirection locale.
   - `go get`
   - `./build dev`
     - Vous pouvez utiliser `./build vX.Y.Z` avec un numéro de version semver valide, mais pour le développement utilisez dev. Cela désactive automatiquement les mises à jour et peut-être d’autres choses à l’avenir.

 - Le site web :
   - `cd web`
   - `npm install`
   - `npm run start` pour un serveur de développement local ou `npm run build` pour une compilation de production.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-30

---