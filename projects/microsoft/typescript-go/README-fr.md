# TypeScript 7

[Vous ne savez pas de quoi il s'agit ? Lisez le post d'annonce !](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## Aperçu

Une version de prévisualisation est disponible sur npm sous le nom `@typescript/native-preview`.

```sh
npm install @typescript/native-preview
npx tsgo # Utilisez ceci comme vous le feriez avec tsc.
```

Une extension de prévisualisation pour VS Code est [disponible sur la marketplace de VS Code](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview).

Pour l'utiliser, ajoutez ceci dans vos paramètres VS Code :

```json
{
    "typescript.experimental.useTsgo": true
}
```

## Comment construire et exécuter

Ce dépôt utilise [Go 1.24 ou supérieur](https://go.dev/dl/), [Rust 1.85 ou supérieur](https://www.rust-lang.org/tools/install), [Node.js avec npm](https://nodejs.org/), et [`hereby`](https://www.npmjs.com/package/hereby).

Pour les tests et la génération de code, ce dépôt contient un sous-module git vers le dépôt principal TypeScript pointant vers le commit en cours de portage.
Lors du clonage, il est recommandé de cloner avec les sous-modules :

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

Si vous avez déjà cloné le dépôt, vous pouvez initialiser le sous-module avec :

```sh
git submodule update --init --recursive
```

Avec le sous-module en place et après un `npm ci`, vous pouvez exécuter des tâches via `hereby`, de façon similaire au dépôt TypeScript :

```sh
hereby build          # Vérifie que le projet compile
hereby test           # Exécute tous les tests
hereby install-tools  # Installe des outils supplémentaires comme les linters
hereby lint           # Exécute tous les linters
hereby format         # Formate tout le code
hereby generate       # Génère tout le code Go (par exemple diagnostics, commis dans le dépôt)
```

Des tâches supplémentaires sont en cours de développement.

`hereby` n'est pas requis pour travailler sur le dépôt ; les outils standards de `go` (par exemple, `go build`, `go test ./...`) fonctionneront normalement.
Les tâches `hereby` sont fournies à titre de commodité pour ceux qui connaissent le dépôt TypeScript.

### Exécution de `tsgo`

Après avoir exécuté `hereby build`, vous pouvez lancer `built/local/tsgo`, qui se comporte essentiellement comme `tsc`.

### Exécution du prototype LSP

Pour déboguer et exécuter l'extension VS Code sans l'installer globalement :

* Lancez VS Code dans l'espace de travail du dépôt (`code .`)
* Copiez `.vscode/launch.template.json` vers `.vscode/launch.json`
* <kbd>F5</kbd> (ou `Debug: Start Debugging` depuis la palette de commandes)

Cela lancera une nouvelle instance de VS Code qui utilise le Corsa LS comme backend. Si tout est correctement configuré, vous devriez voir "tsgo" dans la barre de statut lorsqu’un fichier TypeScript ou JavaScript est ouvert :

![Capture d'écran du prototype LSP](https://raw.githubusercontent.com/microsoft/typescript-go/main/.github/ls-screenshot.png)


## Qu'est-ce qui fonctionne pour le moment ?

Ceci est toujours en cours de développement et n'atteint pas encore la parité complète de fonctionnalités avec TypeScript. Des bugs peuvent exister. Veuillez consulter attentivement cette liste avant de signaler un nouveau problème ou de supposer un changement intentionnel.

| Fonctionnalité | Statut | Remarques |
|---------|--------|-------|
| Création de programme | terminé | Même fichiers et résolution de modules que TS5.8. Tous les modes de résolution ne sont pas encore supportés. |
| Analyse/scanning | terminé | Exactement les mêmes erreurs de syntaxe que TS5.8 |
| Ligne de commande et parsing de `tsconfig.json` | presque terminé | Point d'entrée légèrement différent pour le moment |
| Résolution des types | terminé | Mêmes types que TS5.8 |
| Vérification des types | terminé | Mêmes erreurs, emplacements et messages que TS5.8. L'affichage des types dans les erreurs peut différer (en cours) |
| Inférence spécifique à JavaScript et JS Doc | non prêt | - |
| JSX | terminé | - |
| Génération des déclarations | en cours | La plupart des fonctionnalités courantes sont présentes, mais certains cas limites et indicateurs de fonctionnalité ne sont pas encore gérés |
| Génération (sortie JS) | en cours | `target: esnext` bien supporté, d'autres cibles peuvent comporter des lacunes |
| Mode watch | prototype | Surveille les fichiers et reconstruit, mais pas de réanalyse incrémentielle |
| Mode build / références de projet | non prêt | - |
| Build incrémental | non prêt | - |
| Service de langage (LSP) | prototype | Fonctionnalité minimale (erreurs, survol, aller à la définition). D'autres fonctionnalités arrivent bientôt |
| API | non prêt | - |

Définitions :

 * **terminé** alias "censé être terminé" : Nous ne sommes actuellement pas au courant de déficits ou de travaux majeurs restants. Signalez les bugs si besoin
 * **en cours** : actuellement en développement ; certaines fonctionnalités peuvent fonctionner et d'autres non. Signalez les panics, mais rien d'autre s'il vous plaît
 * **prototype** : preuve de concept uniquement ; ne signalez pas de bugs
 * **non prêt** : soit pas encore commencé, soit trop loin de l'être pour qu'il vaille la peine de s'y intéresser

## Autres remarques

À long terme, nous prévoyons que ce dépôt et son contenu seront fusionnés dans `microsoft/TypeScript`.
En conséquence, le dépôt et le suivi des issues pour typescript-go seront éventuellement fermés, donc traitez les discussions/issues en conséquence.

Pour une liste des changements intentionnels par rapport à TypeScript 5.7, voir CHANGES.md.

## Contribuer

Ce projet accueille volontiers les contributions et suggestions. La plupart des contributions nécessitent que vous acceptiez un
Contrat de Licence de Contributeur (CLA) déclarant que vous avez le droit de, et effectivement, nous accorder
les droits d'utiliser votre contribution. Pour plus de détails, consultez [Contrats de Licence de Contributeur](https://cla.opensource.microsoft.com).

Lorsque vous soumettez une pull request, un bot CLA déterminera automatiquement si vous devez fournir
un CLA et annotera la PR en conséquence (par exemple, vérification de statut, commentaire). Suivez simplement les instructions
fournies par le bot. Vous n'aurez besoin de le faire qu'une seule fois sur tous les dépôts utilisant notre CLA.

Ce projet a adopté le [Code de Conduite Open Source Microsoft](https://opensource.microsoft.com/codeofconduct/).
Pour plus d'informations, consultez la [FAQ du Code de Conduite](https://opensource.microsoft.com/codeofconduct/faq/) ou
contactez [opencode@microsoft.com](mailto:opencode@microsoft.com) pour toute question ou commentaire supplémentaire.

## Marques déposées

Ce projet peut contenir des marques ou logos pour des projets, produits ou services. L'utilisation autorisée des marques ou logos de Microsoft
est soumise et doit respecter les
[Directives Microsoft sur l'utilisation des marques](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general).
L'utilisation des marques ou logos Microsoft dans des versions modifiées de ce projet ne doit pas prêter à confusion ou impliquer un parrainage de Microsoft.
Toute utilisation de marques ou logos de tiers est soumise aux politiques de ces tiers.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---