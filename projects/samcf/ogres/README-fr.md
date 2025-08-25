![Capture d'écran de l'application Ogres](https://raw.githubusercontent.com/samcf/ogres/main/site/web/media/ogres-media-collection.webp)

## Fonctionnalités

[ogres.app](https://ogres.app) est une table virtuelle gratuite et open-source que vous pouvez utiliser directement dans votre navigateur pour jouer avec vos amis. Elle vise à être une alternative très légère à certains des outils plus complets disponibles aujourd'hui. Son ensemble de fonctionnalités limitées est conçu pour aider les maîtres de donjon à préparer rapidement des rencontres et des aventures avec uniquement l'essentiel.

- Commencez instantanément à préparer votre partie ; sans inscription ni publicité
- Lancez une session collaborative en ligne pour vos amis
- Préparez et gérez plusieurs scènes simultanément
- Suivi d'initiative intégré pour des rencontres fluides
- Design responsive pour téléphones et tablettes
- Facile à utiliser pour d'autres systèmes de jeu
- ... et bien plus encore à venir !

## Contribution

Vous souhaitez aider à corriger des bugs ou étendre les fonctionnalités ? Recherchez les problèmes étiquetés **débutant accepté** et commentez que vous souhaitez y travailler. Voici les instructions pour démarrer un environnement de développement local (réservé aux développeurs).

> [!IMPORTANT]
> Vous devez avoir `node`, `npm` et `clojure` installés.

```sh
#!/bin/sh

# copy the repository
git clone git@github.com:samcf/ogres.git

# install dependencies and start the local web server
# by default opens at http://localhost:8080
npm install
npm start

# run the process that bundles CSS files
npm run style

# optionally, start the application server necessary
# for hosting online sessions
clojure -M -m ogres.server.core 5000
```

## Exécutez votre propre serveur

Vous pouvez exécuter votre propre instance de cette application en utilisant Docker. Pour plus d'informations, consultez les [docs wiki](https://github.com/samcf/ogres/wiki/Docker-Usage). La commande suivante installera et exécutera l'application.

```sh
#!/bin/sh
docker compose up -d
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---