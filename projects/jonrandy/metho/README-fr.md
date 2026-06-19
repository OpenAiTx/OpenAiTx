
# Metho - Une nouvelle méthode pour les méthodes

<img align="right" height=100 src="https://user-images.githubusercontent.com/1510194/173243187-08fdcc0f-204d-43c0-b07e-5b7bcb2713a4.png">Une petite bibliothèque qui vous permet d’ajouter en toute sécurité des « propriétés dynamiques » aux objets, avec l’aide des Symboles. Cela est utile (entre autres) pour le « monkey patching » des types JavaScript natifs afin de leur donner de nouvelles capacités (voir [metho-number](https://github.com/jonrandy/metho-number), [metho-set](https://github.com/jonrandy/metho-set), [metho-function](https://github.com/jonrandy/metho-function), [metho-array](https://github.com/jonrandy/metho-array), et [metho-string](https://github.com/jonrandy/metho-string)).

Quelques exemples de ce qui est possible :

```js
import * as Metho from 'metho'

const asHex = Metho.add(
  Number.prototype,
  function() { return this.toString(16) }
)

console.log(65534[asHex])  // fffe

const upper = Metho.add(
  String.prototype,
  function() { return this.toUpperCase() }
)
const chunk = Metho.add(
  String.prototype,
  function(length) {
    return this.match(new RegExp('.{1,' + length + '}', 'g'))
  }
)

console.log("Hello World!"[upper][chunk(2)])  // ['HE', 'LL', 'O ', 'WO', 'RL', 'D!']
```

## Comment utiliser

Metho est assez simple, et offre 4 fonctions de base pour ajouter ces « propriétés dynamiques » à votre(s) objet(s) cible(s). Toutes les fonctions retourneront soit un Symbole, soit une fonction qui retourne un Symbole. Ces Symboles sont les « noms » des propriétés.

### `add(targetOrTargets, function, [options={}])`
C’est probablement la fonction dont vous aurez le plus souvent besoin. Elle utilisera soit `addWithParams` soit `addSimple` en fonction du nombre d’arguments que la fonction passée attend - 0 entraînera l’utilisation de `addSimple`, tout autre nombre entraînera l’utilisation de `addWithParams` ou `addProperty` - selon l’état de l’option `outerSyntax`. Lorsqu’ajoutée avec `outerSyntax` réglé sur `true` - la syntaxe de votre propriété sera celle d’un appel de fonction plus classique :
```js
// options.outerSyntax = false
object[property(x)]

// options.outerSyntax = true
object[property](x)
```
Il y a une légère perte de performance lorsqu’on n’utilise pas `outerSyntax` - d’où la raison du switch. Pour spécifier plus d’une cible pour la fonction, vous devez passer un tableau de cibles.

**Note importante** - il a été signalé que les fonctions avec un ou plusieurs arguments par défaut commençant par le premier argument ne semblent pas fonctionner correctement avec la méthode `add`. Bien qu’elles *semblent* se comporter de manière étrange, elles se comportent en réalité correctement car elles ne *s’attendent* pas vraiment à recevoir d’arguments (pour une explication plus claire, voir les informations sur [`function.length`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Function/length) sur MDN). Si vous souhaitez ajouter de telles méthodes, vous devez utiliser directement la méthode `addWithParams`.

### `addWithParams(targetOrTargets, function, [options={}])`
Ajoute une « propriété dynamique » pouvant accepter des paramètres. Si vous souhaitez ne passer **aucun** paramètre lors de l’appel, vous pouvez simplement omettre les parenthèses - cela est particulièrement utile pour les fonctions où tous les paramètres ont des valeurs par défaut ou sont entièrement optionnels.
```js
console.log(object[property(param1, param2)]  // call the dynamic property and pass parameters
console.log(object[propertyWithDefaultParams])  // equivalent to object[propertyWithDefaultParams()]

```

### `addSimple(cibleOuCibles, fonction, [options={}] )`
Ajoute une « propriété dynamique » qui n’a pas de paramètres
```js
console.log(object[property])
```

### `addProperty(cibleOuCibles, valeurPropriete, [options={}])`
Ajoute une propriété régulière à la/aux cible(s) (ne sera pas appelée automatiquement si c'est une fonction)
```js
console.log(object[property])
```

## Utilisation avancée et `options`

La plupart, sinon toutes, des fonctionnalités ci-dessous ont été ajoutées pour faciliter la possibilité d'avoir des 'méthodes' Metho qui peuvent être partagées entre différentes cibles dans différentes bibliothèques (par exemple, la 'méthode' acquiert plus de capacités lorsqu'une deuxième bibliothèque qui l'utilise est importée). Pour un exemple de cela en action, veuillez vous référer aux bibliothèques [metho-string](https://github.com/jonrandy/metho-string) et [metho-array](https://github.com/jonrandy/metho-array) - où cette fonctionnalité est utilisée pour créer des 'méthodes' partagées telles que `reverse` et `chunk`.

### Option `symbolName`
Ceci est utilisé pour donner un nom au Symbole généré (c’est-à-dire lorsqu’il est créé avec `new Symbol(symbolName`)

### Option `register`
Utilisé pour enregistrer en interne le `Symbol` (ou fonction) créé/utilisé dans un registre interne de Metho - utilisé conjointement avec `symbolName` qui deviendra la 'clé' dans le registre

### Option `useSymbol`
Cela permet d'utiliser un Symbole existant au lieu d’en créer un nouveau. Ceci est disponible uniquement pour `addProperty` et `addSimple` - ce qui signifie qu’il peut aussi être passé à `add`

### `data`
Ceci est un symbole créé par Metho dans le but d’être une clé pour stocker des 'données' arbitraires sur un objet cible
```js
myTarget[Metho.data] = "Arbitrary value"
```

### `getRegistered(name)`
Cela renverra le Symbole ou la fonction stockée dans le registre avec le nom donné comme clé

### `addWithSharedSymbolName(target, function, symbolName)`
Une fonction de commodité pour aider à ajouter de nouvelles 'méthodes' à de nouvelles cibles, où la 'méthode' peut déjà exister. Cela se comprend mieux en conjonction avec `metho-string` et `metho-array` mentionnés ci-dessus


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-19

---