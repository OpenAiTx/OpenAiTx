# Visual Studio Code - Open Source ("Code - OSS")

[![Demandes de fonctionnalités](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Bugs](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## Le Dépôt

Ce dépôt ("`Code - OSS`") est l'endroit où nous (Microsoft) développons le produit [Visual Studio Code](https://code.visualstudio.com) en collaboration avec la communauté. Non seulement nous travaillons ici sur le code et les problèmes, mais nous publions également notre [feuille de route](https://github.com/microsoft/vscode/wiki/Roadmap), nos [plans d'itération mensuels](https://github.com/microsoft/vscode/wiki/Iteration-Plans), ainsi que nos [plans de finalisation](https://github.com/microsoft/vscode/wiki/Running-the-Endgame). Ce code source est disponible pour tous sous la licence standard [MIT](https://github.com/microsoft/vscode/blob/main/LICENSE.txt).

## Visual Studio Code

<p align="center">
  <img alt="VS Code en action" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com) est une distribution du dépôt `Code - OSS` avec des personnalisations spécifiques à Microsoft, publiée sous une [licence produit Microsoft](https://code.visualstudio.com/License/) traditionnelle.

[Visual Studio Code](https://code.visualstudio.com) combine la simplicité d'un éditeur de code avec ce dont les développeurs ont besoin pour leur cycle principal éditer-construire-déboguer. Il offre une édition de code complète, une navigation et une compréhension du code, ainsi qu'un débogage léger, un modèle d'extensibilité riche et une intégration légère avec les outils existants.

Visual Studio Code est mis à jour chaque mois avec de nouvelles fonctionnalités et des corrections de bugs. Vous pouvez le télécharger pour Windows, macOS et Linux sur [le site web de Visual Studio Code](https://code.visualstudio.com/Download). Pour obtenir les dernières versions chaque jour, installez la [version Insiders](https://code.visualstudio.com/insiders).

## Contribution

Il existe de nombreuses façons de participer à ce projet, par exemple :

* [Signaler des bugs et des demandes de fonctionnalités](https://github.com/microsoft/vscode/issues), et nous aider à les vérifier lorsqu'ils sont intégrés
* Examiner les [modifications du code source](https://github.com/microsoft/vscode/pulls)
* Revoir la [documentation](https://github.com/microsoft/vscode-docs) et proposer des pull requests, pour tout, des fautes de frappe au contenu nouveau ou supplémentaire

Si vous souhaitez corriger des problèmes et contribuer directement à la base de code,
veuillez consulter le document [Comment contribuer](https://github.com/microsoft/vscode/wiki/How-to-Contribute), qui couvre les points suivants :

* [Comment compiler et exécuter depuis la source](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [Le flux de travail de développement, y compris le débogage et l'exécution des tests](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [Les directives de codage](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [Soumettre des pull requests](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [Trouver un problème sur lequel travailler](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [Contribuer aux traductions](https://aka.ms/vscodeloc)

## Retour d'information

* Posez une question sur [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)
* [Demander une nouvelle fonctionnalité](CONTRIBUTING.md)
* Votez pour les [demandes de fonctionnalités populaires](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [Soumettre un problème](https://github.com/microsoft/vscode/issues)
* Échangez avec la communauté des auteurs d'extensions sur [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) ou [Slack](https://aka.ms/vscode-dev-community)
* Suivez [@code](https://twitter.com/code) et dites-nous ce que vous en pensez !

Consultez notre [wiki](https://github.com/microsoft/vscode/wiki/Feedback-Channels) pour une description de chacun de ces canaux et des informations sur d'autres canaux communautaires disponibles.

## Projets associés

De nombreux composants principaux et extensions de VS Code résident dans leurs propres dépôts sur GitHub. Par exemple, les dépôts [node debug adapter](https://github.com/microsoft/vscode-node-debug) et [mono debug adapter](https://github.com/microsoft/vscode-mono-debug) sont séparés. Pour une liste complète, veuillez consulter la page [Projets associés](https://github.com/microsoft/vscode/wiki/Related-Projects) sur notre [wiki](https://github.com/microsoft/vscode/wiki).

## Extensions intégrées

VS Code inclut un ensemble d'extensions intégrées situées dans le dossier [extensions](extensions), comprenant des grammaires et des extraits de code pour de nombreux langages. Les extensions qui fournissent un support riche pour un langage (complétion de code, Aller à la Définition) portent le suffixe `language-features`. Par exemple, l'extension `json` fournit la coloration pour `JSON` et l'extension `json-language-features` offre un support avancé pour le langage `JSON`.

## Conteneur de développement

Ce dépôt inclut un conteneur de développement Visual Studio Code Dev Containers / GitHub Codespaces.

* Pour les [Dev Containers](https://aka.ms/vscode-remote/download/containers), utilisez la commande **Dev Containers: Clone Repository in Container Volume...** qui crée un volume Docker pour de meilleures performances d'E/S disque sur macOS et Windows.
  * Si vous avez déjà installé VS Code et Docker, vous pouvez également cliquer [ici](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode) pour commencer. Cela permettra à VS Code d'installer automatiquement l'extension Dev Containers si nécessaire, de cloner le code source dans un volume de conteneur et de lancer un conteneur de développement prêt à l'emploi.

* Pour Codespaces, installez l'extension [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) dans VS Code, puis utilisez la commande **Codespaces: Create New Codespace**.

Docker / le Codespace doit disposer d'au moins **4 cœurs et 6 Go de RAM (8 Go recommandés)** pour effectuer une compilation complète. Consultez le [README du conteneur de développement](.devcontainer/README.md) pour plus d'informations.

## Code de conduite

Ce projet a adopté le [Code de conduite Open Source Microsoft](https://opensource.microsoft.com/codeofconduct/). Pour plus d'informations, consultez la [FAQ du code de conduite](https://opensource.microsoft.com/codeofconduct/faq/) ou contactez [opencode@microsoft.com](mailto:opencode@microsoft.com) pour toute question ou commentaire supplémentaire.

## Licence

Copyright (c) Microsoft Corporation. Tous droits réservés.

Sous licence [MIT](LICENSE.txt).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---