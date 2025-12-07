# Publier une extension VS Code &#8212; GitHub Action

[![Build, Lint, Test and Deploy](https://img.shields.io/github/actions/workflow/status/HaaLeo/publish-vscode-extension/CI.yml?style=flat-square&label=Lint%2C%20Build%2C%20Test%20and%20Deploy)](https://github.com/HaaLeo/publish-vscode-extension/actions?query=workflow%3A%22Build%2C+Lint%2C+Test+and+Deploy%22) [![Coverage Status](https://img.shields.io/coveralls/github/HaaLeo/publish-vscode-extension?style=flat-square)](https://coveralls.io/github/HaaLeo/publish-vscode-extension)  
[![License](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/LICENSE.txt) [![Stars](https://img.shields.io/github/stars/HaaLeo/publish-vscode-extension.svg?label=Stars&logo=github&style=flat-square)](https://github.com/HaaLeo/publish-vscode-extension/stargazers)  
[![Donate](https://img.shields.io/badge/☕️-Buy%20Me%20a%20Coffee-blue.svg?&style=flat-square)](https://www.paypal.me/LeoHanisch/3eur)

Action GitHub pour publier votre extension VS Code sur le [Open VSX Registry](https://open-vsx.org/) ou le [Visual Studio Marketplace](https://marketplace.visualstudio.com).

> Tous les changements majeurs de la **v2** sont listés dans le [changelog](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/CHANGELOG.md#changelog)

## Utilisation

Pour utiliser cette action GitHub, il suffit de [référencer l’action](https://help.github.com/en/actions/configuring-and-managing-workflows/configuring-a-workflow#referencing-actions-in-your-workflow) dans votre fichier de workflow.

### Exemple

L’exemple suivant montre un workflow qui publie une extension à la fois sur le Open VSX Registry et sur le Visual Studio Marketplace lorsqu’un nouveau tag est créé :

```yaml
on:
  push:
    tags:
      - "*"

name: Deploy Extension
jobs:
  deploy:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: actions/setup-node@v4
        with:
          node-version: 20
      - run: npm ci
      - name: Publish to Open VSX Registry
        uses: HaaLeo/publish-vscode-extension@v2
        with:
          pat: ${{ secrets.OPEN_VSX_TOKEN }}
      - name: Publish to Visual Studio Marketplace
        uses: HaaLeo/publish-vscode-extension@v2
        with:
          pat: ${{ secrets.VS_MARKETPLACE_TOKEN }}
          registryUrl: https://marketplace.visualstudio.com
```
Pour empaqueter l’extension une seule fois et publier le fichier `.vsix` **identique** dans les deux registres, on peut utiliser les deux étapes suivantes à la place :


```yaml
- name: Publish to Open VSX Registry
  uses: HaaLeo/publish-vscode-extension@v2
  id: publishToOpenVSX
  with:
    pat: ${{ secrets.OPEN_VSX_TOKEN }}
- name: Publish to Visual Studio Marketplace
  uses: HaaLeo/publish-vscode-extension@v2
  with:
    pat: ${{ secrets.VS_MARKETPLACE_TOKEN }}
    registryUrl: https://marketplace.visualstudio.com
    extensionFile: ${{ steps.publishToOpenVSX.outputs.vsixPath }}
```
Pour un exemple plus complet et complexe, on peut consulter le workflow de [`HaaLeo/vscode-timing`](https://github.com/HaaLeo/vscode-timing/blob/master/.github/workflows/cicd.yml#L1).

### Registre Open VSX

Pour publier sur le Registre Open VSX, assurez-vous que le [namespace de votre extension](https://github.com/eclipse/openvsx/wiki/Publishing-Extensions#2-create-the-namespace) a été créé **au préalable**.
Vous devez définir le paramètre `pat` avec votre [jeton d'accès Open VSX](https://github.com/eclipse/openvsx/wiki/Publishing-Extensions#1-create-an-access-token).
De plus, vous devez vous assurer de ne publier qu’une extension sous licence.
Pour plus d’informations concernant la chronologie d’Open VSX et la licence de ses extensions, consultez le [blog de Brian King](https://blogs.eclipse.org/post/brian-king/open-vsx-registry-under-new-management) (sections « Licensing » et « Timeline »).

Actuellement, cette action GitHub vous permet de publier des extensions qui ne déclarent pas leurs conditions de licence.
Cependant, ce comportement est obsolète et une future version de cette action rejettera les extensions non licenciées.
Par conséquent, je vous encourage vivement à publier une extension avec une licence (permissive) telle que la [licence MIT](https://choosealicense.com/licenses/mit/).

### Visual Studio Marketplace

Pour télécharger votre extension sur le VS Marketplace, vous devez définir l’option `pat` avec le [jeton d’accès](https://code.visualstudio.com/api/working-with-extensions/publishing-extension#get-a-personal-access-token) correspondant.
De plus, le `registryUrl` doit être défini sur `https://marketplace.visualstudio.com`.


## Paramètres d'entrée

Vous pouvez définir tout ou partie des paramètres d'entrée suivants :

|Nom |Type |Obligatoire ? |Par défaut |Description
|-|-|-|-|-
|`pat` |string  |oui |-|Le jeton d’accès personnel au registre correspondant.
|`extensionFile` |string  |non | - |Chemin vers le fichier vsix à publier. Cette option sera priorisée si elle est définie avec `packagePath`.
|`registryUrl` |string  |non |`https://open-vsx.org` |Utiliser l’API du registre à cette URL de base
|`packagePath` |string |non | `./` |Chemin vers l’extension à empaqueter et publier. Lorsque `extensionFile` est défini, `packagePath` est ignoré.
|`baseContentUrl` |string |non | - |Préfixer tous les liens relatifs dans README.md avec cette URL.
|`baseImagesUrl` |string |non | - |Préfixer tous les liens relatifs d’images dans README.md avec cette URL.
|`yarn` |boolean |non | `false` |Utiliser yarn au lieu de npm pour empaqueter les fichiers de l’extension.
|`dryRun` |boolean |non | `false` |Définir cette option à `true` pour empaqueter votre extension sans la publier. En utilisant cette option, définissez `pat` sur une valeur fictive.
|`noVerify` |boolean| non |`false` |Autoriser la publication d’extensions sur le Visual Studio Marketplace qui utilisent une API proposée (enableProposedApi : true). Semblable à l’argument en ligne de commande `--noVerify` de vsce.
|`preRelease` |boolean| non |`false` |Marquer la version de l’extension comme pré-version. Pris en compte uniquement lors de l’empaquetage d’une extension.
|`dependencies` |boolean| non |`true` |Vérifier que les dépendances définies dans `package.json` existent dans `node_modules`. Mettre à `false` si vous utilisez pnpm ou yarn v2+ avec PnP.
|`skipDuplicate` |boolean| non |`false` |Échouer silencieusement si la version existe déjà sur le marketplace. Équivalent à l’option `--skip-duplicate` de l’interface CLI vsce.
|`target` |string| non | - |Architecture(s) cible(s) sur laquelle l’extension doit fonctionner. Séparez plusieurs cibles par des espaces. Ex. : `'win32-x64 linux-x64'`


## Sorties

L'action expose les sorties suivantes :

|Nom |Type |Description
|-|-|-
|`vsixPath` |string |Le chemin vers le fichier VSIX empaqueté et publié.

## Contribution

Si vous avez trouvé un bug ou si une fonctionnalité manque, n'hésitez pas à [ouvrir une issue](https://github.com/HaaLeo/publish-vscode-extension/issues/new/choose).  
Les Pull Requests sont les bienvenues !
Pour commencer à soumettre des modifications de code, veuillez d'abord consulter le fichier [CONTRIBUTING.md](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/./CONTRIBUTING.md).

## Support

Si cette extension vous plaît, assurez-vous de [mettre une étoile au dépôt](https://github.com/HaaLeo/publish-vscode-extension/stargazers). Je suis toujours à la recherche de nouvelles idées et de retours.  
De plus, il est possible de [faire un don via paypal](https://www.paypal.me/LeoHanisch/3eur).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---