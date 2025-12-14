<div align="center">
    <h1>GitQuill</h1>
    <img alt="Logo" src="https://raw.githubusercontent.com/adamsol/GitQuill/master/img/logo.jpg" width="200" />
    <h2>Interface graphique multiplateforme pour Git.</h2>
</div>

| ![](https://raw.githubusercontent.com/adamsol/GitQuill/master/img/screenshots/commit-history.png) | ![](https://raw.githubusercontent.com/adamsol/GitQuill/master/img/screenshots/file-diff.png) |
|-----------------------------------------|------------------------------------|


Fonctionnalités uniques
-----------------------

* Modifier les fichiers directement dans la vue des différences.
* Choisir une coloration syntaxique spécifique pour vos extensions de fichiers.
* Amender rapidement des commits passés avec l’outil de rebasage.
* Configurer les liens depuis les messages de commit vers votre gestionnaire de tickets.
* Configurer des boutons pour exécuter n’importe quelle commande Git en un clic.


Prérequis
---------

* [Git](https://git-scm.com/) 2.23+
* [Node.js](https://nodejs.org/) 18+


Installation
-----------

```sh
npm install
npm run build
npm start
```
Notes
-----

* GitQuill dispose d’un mécanisme personnalisé pour sauvegarder/restaurer le travail en cours (WIP) en utilisant des branches au lieu du stash traditionnel ; cela est dû aux particularités techniques du stash Git qui rendent son intégration cohérente dans l’interface utilisateur difficile.
* Si vous démarrez un rebase avec un fichier sélectionné, GitQuill revertira tout le contenu du commit dans l’index, tout en le gardant dans l’arbre de travail, afin que vous puissiez modifier les fichiers sans quitter l’application.
* Lorsqu’un conflit est détecté, GitQuill réinitialise automatiquement les fichiers non fusionnés, afin d’éviter l’état spécial du dépôt qui complique la gestion. Les marqueurs de conflit restent pour être résolus manuellement.
* GitQuill ne surveille pas les fichiers du dépôt pour les modifications. Le statut est actualisé lorsque l’application reçoit le focus ou lorsque vous effectuez une action pertinente dans l’interface.
* GitQuill appelle directement les commandes `git`. Vous pouvez consulter toutes les opérations exécutées dans les fichiers de log pour chaque dépôt : `.git/.quill/app.log`.


Configuration
-------------

* Fichier de configuration par dépôt : `.git/.quill/config.json5`. Exemple :



  ```js
  {
      autolinks: [
          ['#(\\d+)', 'https://github.com/adamsol/GitQuill/issues/$1'],
      ],
      custom_actions: [
          { icon: 'mdi-download-outline', label: 'Pull', command: ['pull'] },
          { icon: 'mdi-upload-outline', label: 'Push', command: ['push'], click_twice: true },
      ],
  }
  ```

* Fichier de configuration global et automatique (dépôts ouverts, disposition de l’interface utilisateur, etc) : `%AppData%/GitQuill/config.json` pour Windows ; voir https://electronjs.org/docs/api/app#appgetpathname pour les autres plateformes.


Contribuer
----------

Merci de votre intérêt pour le projet ! Je n’accepte généralement pas les pull requests. La meilleure façon de contribuer est de signaler un bug ou de suggérer une fonctionnalité via [Issues](https://github.com/adamsol/GitQuill/issues).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---