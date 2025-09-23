# Node Monkey

Un outil pour inspecter, déboguer et commander des applications Node.js via un navigateur web ou une interface SSH dans votre application (avec vos propres commandes personnalisées).

Node Monkey exécute un serveur simple (ou se connecte à votre serveur existant) et utilise [Socket.IO](https://github.com/LearnBoost/socket.io) pour créer une connexion websocket entre le navigateur et le serveur. Sa fonctionnalité principale capture tout ce qui serait normalement enregistré dans le terminal et le transmet au navigateur pour inspection.

Il est incroyablement facile de commencer (voir [Utilisation rapide](#quick-usage) ci-dessous) mais Node Monkey offre également des fonctionnalités supplémentaires et une flexibilité importante pour un usage plus avancé. Vous pouvez en fait vous connecter en SSH à votre application où Node Monkey fournira une interface en ligne de commande pour exécuter vos propres commandes personnalisées. Cela peut être très utile pour déboguer, surveiller ou contrôler autrement votre application pendant qu’elle fonctionne. Il fournit une authentification pour la sécurité dans les applications en production.

## Contenu

- [Motivation](#motivation)
- [Fonctionnalités](#features)
- [Installation](#installation)
- [Utilisation rapide](#quick-usage)
- [Serveur](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md)
  - [Fournir le vôtre](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own)
  - [Options](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options)
  - [Propriétés](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#properties)
  - [Méthodes](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#methods)
- [Client (navigateur)](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md)
  - [Propriétés](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#properties)
  - [Méthodes](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#methods)
- [SSH](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md)
  - [Configuration](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#setup)
  - [Utilisation](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#usage)
- [Gestion des utilisateurs](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/user-management.md)
- [Contribuer](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/contributing.md)
- [Journal des modifications](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/CHANGELOG.md)
- [Licence MIT](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)

## Motivation

La motivation pour ce projet est venue en essayant de déboguer un serveur Node.js que j’avais écrit et qui utilisait des websockets. J’ai trouvé problématique d’essayer d’inspecter des objets via le terminal car la sortie était trop volumineuse et non navigable. J’ai essayé d’utiliser le débogage intégré qui fonctionne avec le [plugin Chrome Developer Tools](https://github.com/joyent/node/wiki/using-eclipse-as-node-applications-debugger) pour Eclipse. Malheureusement, j’ai rencontré un problème où la mise en place de points d’arrêt pour inspecter des objets faisait que le serveur arrêtait de répondre aux heartbeats, provoquant ainsi la déconnexion du client. Cela sabotait complètement mes efforts de débogage. Tout ce dont j’avais vraiment besoin était un bon moyen d’inspecter les objets.

J’ai cherché sur Google et trouvé des projets comme [node-inspector](https://github.com/dannycoates/node-inspector), qui ne fonctionnait pas avec les dernières versions de Node, et [node-codein](http://thomashunter.name/blog/nodejs-console-object-debug-inspector/) qui avait beaucoup de bugs. Et aucun ne fonctionnait avec Firefox. Donc, Node Monkey est né !

## Fonctionnalités

- Journaliser la sortie console de votre application vers une console navigateur pour une inspection plus facile
  - Fournit un flux pour ceux utilisant Bunyan (voir [ici](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#nodemonkeybunyan_stream))
- Fournit une capacité SSH afin que vous puissiez accéder à un shell dans votre application pour inspection, débogage ou contrôle de votre application  
- Enregistrez des commandes pour votre application qui peuvent être exécutées depuis la console du navigateur ou l'interface SSH  

## Installation

```
npm install --save node-monkey
```

Si vous souhaitez tester des fonctionnalités expérimentales et à venir, exécutez ceci à la place :

```
npm install --save node-monkey@next
```

## Utilisation rapide

Bien que Node Monkey prenne en charge de nombreuses fonctionnalités, la prise en main est conçue pour être extrêmement facile. Il vous suffit d’inclure une ou deux lignes dans votre application. Tout ce qui est enregistré dans la console après cela apparaîtra dans la console du navigateur une fois connecté. Il capture la sortie de la plupart des appels de fonction `console.*` et transmet la sortie au navigateur pour inspection.

L’utilisation la plus simple ressemble à ceci :

```js
const NodeMonkey = require("node-monkey")
NodeMonkey()
```

Node Monkey prend également en charge de nombreuses [options](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options) de configuration et des instances nommées. L'appel prend la forme `NodeMonkey([options[, name])`. Par exemple, pour supprimer la sortie locale de la console et ne voir la sortie que dans votre navigateur ou terminal connecté, vous pourriez faire quelque chose comme ceci :

```js
const NodeMonkey = require("node-monkey")
const monkey = NodeMonkey({
  server: {
    disableLocalOutput: true,
  },
})
```

Vous pouvez inclure Node Monkey dans tous les fichiers de votre application que vous souhaitez et si vous l’utilisez comme dans les exemples ci-dessus, chaque appel à `NodeMonkey()` renverra toujours la même instance que celle que vous avez construite en premier, en ignorant les options passées lors des appels ultérieurs. Cependant, vous pouvez souhaiter créer de nouvelles instances avec des options différentes. Pour ce faire, donnez un nom à votre instance :

```js
const NodeMonkey = require("node-monkey")
const monkey1 = NodeMonkey() // Creates an instance named 'default'
const monkey2 = NodeMonkey("george") // Creates a new instance with default options
const monkey3 = NodeMonkey(
  {
    // Creates a new instance with custom options named 'ninja'
    server: {
      silent: true,
    },
  },
  "ninja",
)
```

Si vous ne spécifiez pas de port pour les instances supplémentaires, il sera automatiquement défini pour vous et s'incrémentera simplement à partir de la valeur par défaut (par exemple 50502, 50504 pour le serveur websocket et 50503, 50505 pour le serveur SSH).

Pour obtenir une instance déjà construite dans un autre fichier, il suffit de l'appeler à nouveau par son nom :

```js
const NodeMonkey = require("node-monkey")
const monkey3 = NodeMonkey("ninja")
```

Lorsque vous démarrez votre application, vous verrez la sortie suivante :

```
Node Monkey listening at http://0.0.0.0:50500
```

Pour connecter votre navigateur, allez simplement à l'adresse affichée dans votre navigateur web (`http://0.0.0.0:50500` dans ce cas). Si vous modifiez les liaisons `host` et `port` par défaut ou utilisez votre propre serveur, assurez-vous d'ajuster l'URL en conséquence. Il vous demandera un nom d'utilisateur et un mot de passe. Jusqu'à ce que vous configuriez un utilisateur, les identifiants par défaut sont `guest` et `guest`.

Si vous fournissez votre propre serveur, vous pouvez voir la sortie dans la console de votre propre application web. Pour savoir comment fournir votre propre serveur, consultez la [documentation](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own). Vous devrez inclure la balise `<script>` suivante dans le code source HTML pour intégrer la sortie de Node Monkey à votre application :

```html
<script type="text/javascript" src="http://0.0.0.0:50500/monkey.js"></script>
```

**NOTE**: You do NOT have to refresh the page when you restart your Node.js application to continue to receive output. Node Monkey will automatically reconnect.

---

### LICENSE: [MIT](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-23

---