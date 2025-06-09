# [jQuery](https://jquery.com/) — JavaScript Nouvelle Génération

Les réunions ont actuellement lieu sur la [plateforme matrix.org](https://matrix.to/#/#jquery_meeting:gitter.im).

Les comptes rendus des réunions sont disponibles sur [meetings.jquery.org](https://meetings.jquery.org/category/core/).

La dernière version de jQuery est disponible sur [https://jquery.com/download/](https://jquery.com/download/).

## Support des versions

| Version | Branche    | Statut   |
| ------- | ---------- | -------- |
| 4.x     | main       | Beta     |
| 3.x     | 3.x-stable | Actif    |
| 2.x     | 2.x-stable | Inactif  |
| 1.x     | 1.x-stable | Inactif  |

Une fois la version finale 4.0.0 publiée, la branche 3.x continuera de recevoir des mises à jour pendant une période limitée. Les branches 2.x et 1.x ne sont plus supportées.

Un support commercial pour les versions inactives est disponible auprès de [HeroDevs](https://herodevs.com/nes).

En savoir plus sur notre [support des versions](https://jquery.com/support/).

## Guides de contribution

Dans l'esprit du développement logiciel open source, jQuery encourage toujours la contribution de code par la communauté. Pour vous aider à démarrer et avant de vous lancer dans l'écriture de code, assurez-vous de lire attentivement ces guides de contribution importants :

1. [S'impliquer](https://contribute.jquery.org/)
2. [Guide de style du cœur](https://contribute.jquery.org/style-guide/js/)
3. [Écriture de code pour les projets jQuery](https://contribute.jquery.org/code/)

### Références aux issues/PRs

Les issues/PRs GitHub sont généralement référencées via `gh-NUMBER`, où `NUMBER` est l'identifiant numérique de l'issue/PR. Vous pouvez trouver une telle issue/PR sous `https://github.com/jquery/jquery/issues/NUMBER`.

jQuery a utilisé par le passé un autre système de suivi de bugs — basé sur Trac — disponible sur [bugs.jquery.com](https://bugs.jquery.com/). Il est conservé en mode lecture seule pour permettre de se référer aux discussions passées. Lorsque le code source de jQuery fait référence à l'une de ces issues, il utilise le motif `trac-NUMBER`, où `NUMBER` est l'identifiant numérique de l'issue. Vous pouvez trouver une telle issue sous `https://bugs.jquery.com/ticket/NUMBER`.

## Environnements d'utilisation de jQuery

- [Support des navigateurs](https://jquery.com/browser-support/)
- jQuery supporte aussi Node, les extensions de navigateur, et d'autres environnements non-navigateurs.

## Ce dont vous avez besoin pour construire votre propre jQuery

Pour construire jQuery, vous devez disposer de la dernière version de Node.js/npm et de git 1.7 ou ultérieur. Les versions antérieures peuvent fonctionner, mais ne sont pas supportées.

Pour Windows, vous devez télécharger et installer [git](https://git-scm.com/downloads) et [Node.js](https://nodejs.org/en/download/).

Les utilisateurs macOS devraient installer [Homebrew](https://brew.sh/). Une fois Homebrew installé, lancez `brew install git` pour installer git,
et `brew install node` pour installer Node.js.

Les utilisateurs Linux/BSD doivent utiliser leur gestionnaire de paquets approprié pour installer git et Node.js, ou compiler à partir des sources
si vous préférez cette méthode. Facile.

## Comment construire votre propre jQuery

D'abord, [clonez le dépôt git de jQuery](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

Ensuite, entrez dans le dossier jquery, installez les dépendances, et exécutez le script de construction :

```bash
cd jquery
npm install
npm run build
```

La version compilée de jQuery sera placée dans le répertoire `dist/`, accompagnée d'une copie minifiée et du fichier map associé.

## Construire tous les fichiers de release jQuery

Pour construire toutes les variantes de jQuery, exécutez la commande suivante :

```bash
npm run build:all
```

Cela créera toutes les variantes que jQuery inclut dans une release, y compris `jquery.js`, `jquery.slim.js`, `jquery.module.js`, et `jquery.slim.module.js` ainsi que leurs fichiers minifiés associés et sourcemaps.

`jquery.module.js` et `jquery.slim.module.js` sont des [modules ECMAScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules) qui exportent `jQuery` et `$` comme exports nommés et sont placés dans le dossier `dist-module/` plutôt que dans le dossier `dist/`.

## Construire un jQuery personnalisé

Le script de construction peut être utilisé pour créer une version personnalisée de jQuery qui n'inclut que les modules dont vous avez besoin.

Tout module peut être exclu à l'exception de `core`. Lorsque vous excluez `selector`, il n'est pas supprimé mais remplacé par un petit wrapper autour du `querySelectorAll` natif (voir ci-dessous pour plus d'informations).

### Aide du script de build

Pour voir la liste complète des options disponibles pour le script de build, exécutez la commande suivante :

```bash
npm run build -- --help
```

### Modules

Pour exclure un module, passez son chemin relatif au dossier `src` (sans l'extension `.js`) à l'option `--exclude`. Lorsque vous utilisez l'option `--include`, les inclusions par défaut sont abandonnées et une version est construite avec seulement ces modules.

Quelques exemples de modules pouvant être exclus ou inclus :

- **ajax** : Toute la fonctionnalité AJAX : `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, transports, et raccourcis d'événements ajax comme `.ajaxStart()`.
- **ajax/xhr** : Uniquement le transport AJAX XMLHTTPRequest.
- **ajax/script** : Uniquement le transport AJAX `<script>` ; utilisé pour récupérer des scripts.
- **ajax/jsonp** : Uniquement le transport AJAX JSONP ; dépend du transport ajax/script.
- **css** : La méthode `.css()`. Supprime aussi **tous** les modules dépendant de css (y compris **effects**, **dimensions** et **offset**).
- **css/showHide** : `.show()`, `.hide()` et `.toggle()` non animés ; peut être exclu si vous utilisez des classes ou des appels explicites à `.css()` pour définir la propriété `display`. Supprime aussi le module **effects**.
- **deprecated** : Méthodes documentées comme obsolètes mais pas encore supprimées.
- **dimensions** : Les méthodes `.width()` et `.height()`, y compris les variantes `inner-` et `outer-`.
- **effects** : La méthode `.animate()` et ses raccourcis comme `.slideUp()` ou `.hide("slow")`.
- **event** : Les méthodes `.on()` et `.off()` et toute la fonctionnalité événementielle.
- **event/trigger** : Les méthodes `.trigger()` et `.triggerHandler()`.
- **offset** : Les méthodes `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()`, et `.scrollTop()`.
- **wrap** : Les méthodes `.wrap()`, `.wrapAll()`, `.wrapInner()`, et `.unwrap()`.
- **core/ready** : Exclure le module ready si vous placez vos scripts à la fin du body. Tout callback ready lié avec `jQuery()` sera simplement appelé immédiatement. Cependant, `jQuery(document).ready()` ne sera pas une fonction et `.on("ready", ...)` ou similaire ne sera pas déclenché.
- **deferred** : Exclure jQuery.Deferred. Cela exclut aussi tous les modules qui dépendent de Deferred, y compris **ajax**, **effects** et **queue**, mais remplace **core/ready** par **core/ready-no-deferred**.
- **exports/global** : Exclure l'attachement des variables globales jQuery ($ et jQuery) à window.
- **exports/amd** : Exclure la définition AMD.

- **selector** : Le moteur de sélection jQuery complet. Lorsque ce module est exclu, il est remplacé par un moteur de sélection rudimentaire basé sur la méthode `querySelectorAll` du navigateur, qui ne supporte pas les extensions de sélecteur jQuery ni les sémantiques avancées. Voir le fichier [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) pour les détails.

*Note* : Exclure le module `selector` complet exclura également toutes les extensions de sélecteur jQuery (comme `effects/animatedSelector` et `css/hiddenVisibleSelectors`).

##### Nom AMD

Vous pouvez définir le nom du module pour la définition AMD de jQuery. Par défaut, il est défini sur "jquery", ce qui est compatible avec les plugins et bibliothèques tierces, mais il peut y avoir des cas où vous souhaitez le changer. Passez-le au paramètre `--amd` :

```bash
npm run build -- --amd="nom-personnalisé"
```

Ou, pour définir anonymement, laissez le nom vide.

```bash
npm run build -- --amd
```

##### Nom du fichier et répertoire

Le nom par défaut du fichier jQuery construit est `jquery.js` ; il est placé dans le répertoire `dist/`. Il est possible de changer le nom du fichier avec `--filename` et le répertoire avec `--dir`. `--dir` est relatif à la racine du projet.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

Ceci créera une version slim de jQuery et la placera sous `tmp/jquery.slim.js`.

##### Mode Module ECMAScript (ESM)

Par défaut, jQuery génère un fichier JavaScript script classique. Vous pouvez également générer un module ECMAScript exportant `jQuery` comme export par défaut en utilisant le paramètre `--esm` :

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Mode Factory

Par défaut, jQuery dépend d'un `window` global. Pour les environnements qui n'en ont pas, vous pouvez générer une version factory qui expose une fonction acceptant `window` comme paramètre que vous pouvez fournir de l'extérieur (voir le [`README` du package publié](build/fixtures/README.md) pour les instructions d'utilisation). Vous pouvez générer une telle factory avec le paramètre `--factory` :

```bash
npm run build -- --filename=jquery.factory.js --factory
```

Cette option peut être combinée avec d'autres comme `--esm` ou `--slim` :

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### Exemples de builds personnalisés

Créez une build personnalisée en utilisant `npm run build`, en listant les modules à exclure. Exclure un module de haut niveau exclut également son répertoire de modules correspondant.

Exclure toute la fonctionnalité **ajax** :

```bash
npm run build -- --exclude=ajax
```

Exclure **css** supprime les modules dépendant de CSS : **effects**, **offset**, **dimensions**.

```bash
npm run build -- --exclude=css
```

Exclure plusieurs modules (`-e` est un alias de `--exclude`) :

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

Il existe un alias spécial pour générer une build avec la même configuration que la build officielle jQuery Slim :

```bash
npm run build -- --filename=jquery.slim.js --slim
```

Ou, pour créer la build slim sous forme de module esm :

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*Les builds personnalisés non officiels ne sont pas testés régulièrement. Utilisez-les à vos propres risques.*

## Exécution des tests unitaires

Assurez-vous d'avoir les dépendances nécessaires :

```bash
npm install
```

Lancez `npm start` pour construire automatiquement jQuery pendant que vous travaillez :

```bash
npm start
```

Exécutez les tests unitaires avec un serveur local qui prend en charge PHP. Assurez-vous d'exécuter le site depuis le répertoire racine, et non depuis le répertoire "test". Aucune base de données n'est requise. Des serveurs PHP locaux préconfigurés sont disponibles pour Windows et Mac. Voici quelques options :

- Windows : [Télécharger WAMP](https://www.wampserver.com/en/)
- Mac : [Télécharger MAMP](https://www.mamp.info/en/downloads/)
- Linux : [Configuration de LAMP](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (la plupart des plateformes)](https://code.google.com/p/mongoose/)

## Git essentiel

Comme le code source est géré par le système de contrôle de version Git, il est utile de connaître certaines fonctionnalités utilisées.

### Nettoyage

Si vous souhaitez réinitialiser votre répertoire de travail à l'état d'origine (upstream), les commandes suivantes peuvent être utilisées (rappelez-vous que tout ce sur quoi vous avez travaillé sera perdu après cela) :

```bash
git reset --hard upstream/main
git clean -fdx
```

### Rebasage

Pour les branches de fonctionnalités ou thématiques, vous devez toujours utiliser l'option `--rebase` avec `git pull`, ou si vous gérez habituellement de nombreuses branches temporaires "à soumettre dans une pull request github", exécutez la commande suivante pour automatiser cela :

```bash
git config branch.autosetuprebase local
```

(voir `man git-config` pour plus d'informations)

### Gestion des conflits de fusion

Si vous obtenez des conflits de fusion lors d'une fusion, au lieu de modifier manuellement les fichiers en conflit, vous pouvez utiliser la fonctionnalité
`git mergetool`. Bien que l'outil par défaut `xxdiff` semble dépassé/vieux, il est plutôt utile.

Voici quelques commandes utilisables dans cet outil :

- `Ctrl + Alt + M` - fusion automatique autant que possible
- `b` - passer au prochain conflit de fusion
- `s` - changer l'ordre des lignes en conflit
- `u` - annuler une fusion
- `bouton gauche de la souris` - marquer un bloc comme gagnant
- `bouton du milieu de la souris` - marquer une ligne comme gagnante
- `Ctrl + S` - enregistrer
- `Ctrl + Q` - quitter

## Référence [QUnit](https://api.qunitjs.com)

### Méthodes de test

```js
expect( numAssertions );
stop();
start();
```

*Remarque* : L'ajout éventuel par QUnit d'un argument à stop/start est ignoré dans cette suite de tests afin que start et stop puissent être passés en tant que callbacks sans se soucier de leurs paramètres.

### Assertions de test

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## Référence des méthodes pratiques de la suite de tests

Voir [test/data/testinit.js](https://github.com/jquery/jquery/blob/main/test/data/testinit.js).

### Retourne un tableau d'éléments avec les identifiants donnés

```js
q( ... );
```

Exemple :

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### Vérifie qu'une sélection correspond aux identifiants donnés

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

Exemple :

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### Déclenche un événement DOM natif sans passer par jQuery

```js
fireNative( node, eventType );
```

Exemple :

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### Ajoute un nombre aléatoire à l'URL pour empêcher la mise en cache

```js
url( "some/url" );
```

Exemple :

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### Exécuter des tests dans une iframe

Certains tests peuvent nécessiter un document autre que le modèle de test standard,
et ceux-ci peuvent être exécutés dans une iframe séparée. Le code de test réel et les assertions
restent dans les fichiers de test principaux de jQuery ; seul le balisage minimal du modèle de test
et le code d'initialisation doivent être placés dans le fichier de l'iframe.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

Ceci charge une page, construisant une URL avec fileName `"./data/" + fileName`.
La page dans l'iframe détermine quand le callback se produit dans le test en
incluant le script "/test/data/iframeTest.js" et en appelant
`startIframeTest( [ additional args ] )` au moment approprié. Souvent, cela
se produira après que document ready ou `window.onload` ait été déclenché.

Le `testCallback` reçoit l'objet QUnit `assert` créé par `testIframe`
pour ce test, suivi par les objets globaux `jQuery`, `window`, et `document` de
l'iframe. Si le code de l'iframe passe des arguments à `startIframeTest`,
ils suivent l'argument `document`.

## Des questions ?

Si vous avez des questions, n'hésitez pas à les poser sur le
[forum Developing jQuery Core](https://forum.jquery.com/developing-jquery-core) ou dans #jquery sur [libera](https://web.libera.chat/).
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---