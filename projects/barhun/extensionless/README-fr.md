Chargeur Node.js pour les spécificateurs d'importation en tant que chemins de fichiers sans extensions ou en tant que chemins de répertoires

&nbsp;

Installation :

```
npm i extensionless
```

&nbsp;

Démarrez `node` avec l'option suivante ajoutée.

```
--import=extensionless/register
```

Remarque : Si la version de `node` est inférieure à `20.6.0`, cela ne fonctionne pas et il faut utiliser ce drapeau à la place :

```
--experimental-loader=extensionless
```

&nbsp;

Vous pouvez désormais utiliser des spécificateurs d'importation comme chemins de fichiers sans extensions ou comme chemins de répertoires :

```js
// imports from the first existing file in the candidates list as follows

import mod from './mod'
// ['./mod.js', './mod/index.js']

import mod from '../mod' with {type: 'json'}
// ['../mod.json', '../mod/index.json']

import api from '/apps/api'
// ['/apps/api.js', '/apps/api/index.js']

import web from 'file:///apps/web'
// ['file:///apps/web.js', 'file:///apps/web/index.js']
```

&nbsp;

Pour configurer ce module, ajoutez le champ `extensionless` au fichier `package.json` de votre projet :

```json
"extensionless": {
  "lookFor": ["js", "mjs", "cjs"]
}
```

|   Champ   | Valeur par défaut |
| --------- | ----------------- |
| `lookFor` | `["js"]`          |

Note : Si vous utilisez le drapeau `--experimental-transform-types` avec `node`, la valeur `"ts"` est automatiquement ajoutée en début du tableau `lookFor`, de sorte que vous n'aurez pas besoin de la configurer manuellement.

&nbsp;

Lorsqu'il peut être déduit du spécificateur que sa cible est un répertoire, le résolveur recherche uniquement les fichiers index :

```js
// imports from the first existing file in the candidates list as follows

import cur from '.'
// ['./index.js']

import up from '..'
// ['../index.js']

import mod from './mod/'
// ['./mod/index.js']

import mod from '../mod/' with {type: 'json'}
// ['../mod/index.json']

import api from '/apps/api/'
// ['/apps/api/index.js']

import web from 'file:///apps/web/'
// ['file:///apps/web/index.js']
```

&nbsp;

Ce chargeur ajoute également la prise en charge de la résolution des chemins Windows, ce qui vous permet d'utiliser des barres obliques avant ou arrière comme séparateurs.

```js
import mod from '.\\mod'
// ['./mod.js', './mod/index.js']

import mod from '..\\mod\\' with {type: 'json'}
// ['../mod/index.json']

import api from 'C:/apps/api'
// ['/C:/apps/api.js', '/C:/apps/api/index.js']

import web from 'C:\\apps\\web\\'
// ['/C:/apps/web/index.js']
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-29

---