<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Votre site de jeux de quartier convivial.</p>
<br>

Bienvenue sur MonkeyGG2, un site de jeux riche en fonctionnalités créé pour vous ! Avec plus de 150 jeux à choisir, MonkeyGG2 offre une expérience de jeu unique et personnalisable. Que vous soyez un joueur, un développeur ou Monsieur Tout-le-monde, MonkeyGG2 propose un environnement de jeu fluide et agréable.

> Pensez à nous donner une étoile ! Surtout si vous avez forké ce dépôt ou si vous en avez trouvé une autre utilité.

## Fonctionnalités

-   Plus de 150 jeux
-   Facile à utiliser
-   Facile à déployer
-   Personnalisable
-   Proxy
-   Et bien plus...

## Personnalisation

### Paramètres

#### Camouflage

Le camouflage consiste à ouvrir la page dans un onglet `about:blank`. Ce comportement est activé par défaut, bien qu’il puisse être désactivé. Des préréglages sont disponibles pour le lien de redirection, mais cela peut également être configuré manuellement.

#### Masquage

Le masquage consiste à changer l’icône et le titre de l’onglet about:blank. Des préréglages sont disponibles pour l’icône et le titre de l’onglet, mais cela peut aussi être configuré manuellement.

#### Raccourcis

Des raccourcis clavier personnalisés peuvent être créés pour réaliser diverses tâches. Par exemple, quitter le jeu, masquer l’onglet, et exécuter du JavaScript personnalisé sont tous pris en charge.
> Remarque : si vous souhaitez exécuter du JavaScript personnalisé, assurez-vous de savoir ce que vous faites. Si vous cassez quelque chose, un rechargement de la page est toujours la solution.

#### Thème

Les personnalisations de thème suivantes sont actuellement prises en charge :
- Activer/désactiver l’animation d’arrière-plan (si vous vous inquiétez des performances pendant le jeu, ne vous inquiétez pas, elle est automatiquement désactivée dès que vous jouez)
- Couleur de fond
- Couleur des blocs
- Couleur des boutons
- Couleur des jeux
- Couleur du survol
- Couleur de la barre de défilement
- Couleur de la piste de défilement
- Couleur de la police

> Remarque : si vous changez accidentellement les couleurs de sorte que le site devienne inutilisable, vous devrez effacer vos cookies et le stockage local.

### Personnalisation avancée

> Avertissement : Les personnalisations suivantes ne sont disponibles que pour les propriétaires du dépôt ou de tout fork de ce dépôt.

Le fichier `config.jsonc` est formaté pour inclure la configuration de l’ensemble du site. Actuellement, les éléments suivants sont pris en charge :
- Jeux
- Thèmes (bientôt disponible)
- Configuration du proxy

#### Jeux

Chaque entrée de jeu possède une clé représentant le nom d’affichage du jeu, et la valeur doit être un objet avec trois paires clé-valeur :
- `"path"` : Chemin vers le jeu depuis le dossier `./games`
- `"aliases"` : Liste des noms alternatifs pour améliorer la recherche
- `"categories"` : Liste des catégories auxquelles le jeu appartient (prise en charge de l’ajout d’icônes bientôt disponible)

Ajouter une entrée manuellement est possible, mais fastidieux, surtout si vous souhaitez trier la liste par ordre alphanumérique (ce n’est pas nécessaire pour que la configuration fonctionne !)
C’est pourquoi le script `add-game-entry.js` a été créé, pour ajouter facilement un nouveau jeu à la configuration sans avoir à éditer le fichier à la main.

```bash
# Vous pouvez utiliser n’importe quel runtime js comme node.js, bun, ou deno
# Pour cette démonstration, bun sera utilisé car les dépendances sont installées automatiquement
bun add-game-script.js
# Répondez aux questions qui suivent et la configuration sera mise à jour
```

#### Thèmes

Le standard de thème n’est pas encore implémenté (À FAIRE)

#### Proxy

Les options de configuration du proxy se trouvent sous la clé **"config"**. 
La valeur de la clé `"proxy"` est un booléen qui active ou désactive la fonction de proxy. Si `"proxy"` est défini sur false, l’utilisateur recevra une boîte de dialogue d’erreur lorsqu’il tentera d’accéder au proxy.
La valeur de la clé `"proxyPath"` est le chemin vers le proxy. Il peut s’agir d’un chemin absolu ou relatif, mais le proxy doit prendre en charge **CORS** car la page proxy sera affichée en iframe sur le site.


## Déploiement

### Sans Proxy

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

Vous pouvez également simplement forker ce dépôt sur [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) ou [Codeberg](https://codeberg.org/MonkeyGG2/pages) et déployer sur GitHub Pages ou Codeberg Pages, respectivement.

### Avec Proxy

Consultez la page [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) pour en savoir plus sur l’hébergement de MonkeyGG2 avec un proxy.

### Exécution en local

```bash
# ATTENTION : si vous avez un dossier nommé "monkeygg2", cette commande supprimera tous les fichiers de ce dossier
# veuillez changer le nom du dossier dans les deux commandes suivantes
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# à partir d’ici, vous pouvez utiliser n’importe quel outil pour exécuter un serveur statique, "live-server" de npm sera utilisé ici
npm install -g live-server # seulement si vous ne l’avez pas déjà installé
npx live-server
```

## Licence

Distribué sous licence WTFPL. Voir [ici](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE) pour plus de détails.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---