# suppress-eslint-errors

![Release](https://github.com/amanda-mitchell/suppress-eslint-errors/workflows/Release/badge.svg)

Avez-vous déjà essayé d'activer une nouvelle règle eslint pour être découragé par des centaines ou des milliers d'erreurs dans une base de code existante ?  
Nous aussi.

Parfois, il n'y a pas de bonne raison commerciale pour mettre à jour tout le code existant (qui fonctionne !), surtout dans une base de code plus grande et héritée.  
Pour ces moments, `suppress-eslint-errors` est là pour vous aider.

## Comment ça marche

`suppress-eslint-errors` est un codemod pour [jscodeshift](https://github.com/facebook/jscodeshift) qui exécute eslint sur votre code existant.  
Pour chaque erreur eslint qu'il trouve, il ajoute un petit extrait :

```javascript
// TODO: Fix this the next time the file is edited.
// eslint-disable-next-line cool-new-rule
```

De cette façon, vous pouvez bénéficier de la règle dans un nouveau code sans avoir à traiter immédiatement un énorme arriéré.

## Utilisation

`suppress-eslint-errors` est fourni avec un script wrapper afin que vous puissiez l'appeler directement sans installer quoi que ce soit en plus :

```bash
npx suppress-eslint-errors [jscodeshift options] PATH...
```

Le wrapper appellera `jscodeshift` avec le transformateur et tous les autres arguments que vous lui passerez.
S'il détecte un `.gitignore` dans le répertoire local, il le spécifiera également comme `--ignore-config`.

`suppress-eslint-errors` doit être utilisé avec une copie locale installée d'`eslint`.
S'il ne peut pas en trouver une, il abandonnera tôt.

_NOTE :_ `jscodeshift` présente quelques bugs concernant la gestion des fichiers `.gitignore` qui font parfois qu'il ignore tous les fichiers.
Si cet outil détecte que votre `.gitignore` contient des motifs problématiques, l'option `--ignore-config` sera ignorée.

Dans certains cas, le code produit par ce codemod fera des choix d'indentation malheureux.
Assurez-vous de relancer tous les outils de formatage de code que vous utilisez avant de valider !

## Options

**--message** : Définit le commentaire à ajouter au-dessus des commentaires eslint-disable-next-line.

**--rules** : Liste séparée par des virgules des identifiants de règles ESLint à désactiver. Lorsqu'elle est spécifiée, les violations des règles non incluses dans cet ensemble seront laissées en place.

## Exemples

Supprimer toutes les erreurs dans le fichier `index.js`, en utilisant un commentaire personnalisé :

```bash
npx suppress-eslint-errors ./index.js --message="TODO: Issue #123"
```

Supprimer les violations des règles `eqeqeq` et `@typescript-eslint/no-explicit-any` dans les fichiers .ts et .tsx du répertoire `src` :

```bash
npx suppress-eslint-errors ./src --extensions=ts,tsx --parser=tsx --rules=eqeqeq,@typescript-eslint/no-explicit-any
```

## Nuances

Comme le nom de l’outil l’indique, cela supprime uniquement les _erreurs_ eslint.
Si vous avez des avertissements que vous souhaitez supprimer, modifiez votre configuration eslint pour les transformer en erreurs avant d’exécuter l’outil ou spécifiez les règles à l’aide du drapeau `--rules`.

## Est-ce parfait ?

Certainement pas. Les PR sont les bienvenues pour tout cas particulier que vous rencontrez.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---