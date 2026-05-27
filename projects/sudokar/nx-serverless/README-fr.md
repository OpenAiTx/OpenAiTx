# nx-serverless-monorepo

[![serverless](http://public.serverless.com/badges/v3.svg)](http://www.serverless.com)
[![](https://img.shields.io/badge/monorepo-Nx-blue)](https://nx.dev/)
![esbuild](https://badges.aleen42.com/src/esbuild.svg)
![npm peer dependency version (scoped)](https://img.shields.io/npm/dependency-version/eslint-config-prettier/peer/eslint)
![code style: prettier](https://img.shields.io/badge/code_style-prettier-ff69b4.svg?style=flat-square)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/sudokar/nx-serverless/blob/master/LICENSE)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/Naereen/badges.svg)](http://isitmaintained.com/project/Naereen/badges 'Percentage of issues still open')
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://github.com/sudokar/nx-serverless)
![Maintained](https://img.shields.io/maintenance/yes/2024.svg)

![TypeScript](https://img.shields.io/badge/typescript-%23007ACC.svg?style=for-the-badge&logo=typescript&logoColor=white)
![GitHub Actions](https://img.shields.io/badge/github%20actions-%232671E5.svg?style=for-the-badge&logo=githubactions&logoColor=white)

Un projet modèle ou boilerplate moderne de style monorepo pour [Serverless framework](https://www.serverless.com/) utilisant la boîte à outils monorepo [Nx](https://nx.dev) 🛠 et le template serverless `aws-nodejs-typescript`

## Table des matières

- [Ce qui est inclus](#whats-included)
- [Disposition du template](#template-layout)
- [Prérequis](#prerequisites)
- [Utilisation](#usage)
- [Aide supplémentaire](#further-help)
- [Nx Cloud](#nx-cloud)
- [Contribution](#contribution)
- [Support](#support)
- [Mainteneur](#maintainer)
- [Licence](#license)

## Ce qui est inclus

- Une disposition de projet template utilisant la dernière version de Nx et du framework Serverless
- Un générateur d’espace de travail facile à utiliser pour générer un template/stack avec les fichiers du framework Serverless et la configuration Nx associée
- Configuré avec le fournisseur AWS et facilement adaptable à n’importe quel fournisseur cloud

## Disposition du template

```shell
.
├── stacks/    # stack for each serverless configuration/template and its associated files
├── libs/      # shared libraries
├── tools/
├── README.md
├── jest.config.js
├── jest.preset.js
├── nx.json
├── package.json
├── serverless.base.ts  # base configuration for serverless
├── tsconfig.base.json
├── workspace.json
├── .editorconfig
├── .eslintrc.json
├── .gitignore
├── .husky              # git hooks
├── .nvmrc
├── .prettierignore
├── .prettierrc
```

## Prérequis

- [Nodejs](https://nodejs.org/) `protip : utilisez nvm`

  > :warning: **Version** : `lts/iron (v20)`. Si vous utilisez [nvm](https://github.com/nvm-sh/nvm), exécutez `nvm use` pour vous assurer d'utiliser la même version de Node en local et dans l'environnement d'exécution de votre lambda.

- :package: Gestionnaire de paquets

  - [Yarn](https://yarnpkg.com)

- 💅 Plugins de formatage de code

  - [Eslint](https://eslint.org/)
  - [Prettier](https://prettier.io/)
  - [EditorConfig](https://editorconfig.org/)

  > Dans votre éditeur de code préféré, installez les plugins pour la liste d'outils ci-dessus

## Utilisation

Selon votre gestionnaire de paquets préféré, suivez les instructions ci-dessous pour construire et déployer la ou les piles serverless.

- **Installer les dépendances du projet**

  ```shell
  yarn install
  ```

- **Générer une nouvelle pile**

  ```shell
  nx g serverless <STACK_NAME>
  ```

  > Exécutez avec l'option `-d` ou `--dry-run` pour une exécution à blanc

- **Générer une nouvelle bibliothèque**

  ```shell
  nx g @nx/node:lib --skipBabelrc --tags lib <LIBRARY_NAME>
  ```

  > Exécutez avec l’option `-d` ou `--dry-run` pour une exécution à blanc

- **Empilement de paquet**

  - Pour empaqueter un empilement unique

    ```shell
    nx run <STACK_NAME>:build --stage=<STAGE_NAME>
    ```

  - Pour empaqueter la pile affectée par un changement

    ```shell
    nx affected:build --stage=<STAGE_NAME>
    ```

  - Pour emballer toutes les piles

    ```shell
    nx run-many --target=build --stage=<STAGE_NAME>
    ```

- **Déployer la pile sur le cloud**

  - Pour déployer une seule pile

    ```shell
    nx run <STACK_NAME>:deploy --stage=<STAGE_NAME>
    ```

  - Pour déployer la pile affectée par un changement

    ```shell
    nx affected:deploy --stage=<STAGE_NAME>
    ```
  - Pour déployer toutes les piles


    ```shell
    nx run-many --target=deploy --all --stage=<STAGE_NAME>
    ```

- **Supprimer une pile du cloud**

  - Pour supprimer une seule pile

    ```shell
    nx run <STACK_NAME>:remove --stage=<STAGE_NAME>
    ```

  - Pour supprimer la pile affectée par un changement

    ```shell
    nx affected:remove --stage=<STAGE_NAME>
    ```
  - Pour supprimer toutes les piles


    ```shell
    nx run-many --target=remove --all --stage=<STAGE_NAME>
    ```

- **Exécuter les tests**

  - Pour exécuter les tests dans une seule pile

    ```shell
    nx run <STACK_NAME>:test --stage=<STAGE_NAME>
    ```
  - Pour exécuter les tests affectés par un changement


    ```shell
    nx affected:test --stage=<STAGE_NAME>
    ```
  - Pour exécuter des tests dans toutes les piles


    ```shell
    nx run-many --target=test --all --stage=<STAGE_NAME>
    ```

- **Exécuter hors ligne / localement**

  - Pour exécuter hors ligne, configurez le plugin `serverless-offline` comme documenté [ici](https://github.com/dherault/serverless-offline) et exécutez la commande ci-dessous

    ```shell
    nx run <STACK_NAME>:serve --stage=<STAGE_NAME>
    ```

- **Comprenez votre espace de travail**

  ```
  nx dep-graph
  ```
## Aide supplémentaire

- Visitez la [Documentation Serverless](https://www.serverless.com/framework/docs/) pour en savoir plus sur le framework Serverless
- Visitez la [Documentation Nx](https://nx.dev) pour en savoir plus sur la boîte à outils Nx dev
- Pourquoi NX, et non Lerna ? Lerna n'est plus maintenu

## Nx Cloud

##### Mémoïsation des calculs dans le cloud

​ Nx Cloud s'associe à Nx pour vous permettre de construire et tester votre code jusqu'à 10 fois plus rapidement.

​ Visitez [Nx Cloud](https://nx.app/) pour en savoir plus et l'activer

## Contribution

Vous avez trouvé un problème ? N’hésitez pas à ouvrir une issue avec les informations pour le reproduire.

Les pull requests sont les bienvenues pour améliorer.

## Support

Vous aimez ce template ?

Cliquez sur <a href="https://www.buymeacoffee.com/sudokar" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="50" width="250"></a>

Ou, ajoutez une étoile :star: au dépôt

## Mainteneur

Ce template est créé et maintenu par [sudokar](https://github.com/sudokar)

## Licence

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-27

---