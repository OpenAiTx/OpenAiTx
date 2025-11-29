Cargador de Node.js para especificadores de importación como rutas de archivos sin extensiones o como rutas de directorios

&nbsp;

Instalar:

```
npm i extensionless
```

&nbsp;

Inicie `node` con la siguiente bandera añadida.

```
--import=extensionless/register
```

Nota: Si la versión de `node` es inferior a `20.6.0`, esto no funciona y en su lugar se necesita esta bandera:

```
--experimental-loader=extensionless
```

&nbsp;

Ahora puede usar especificadores de importación como rutas de archivo sin extensiones o como rutas de directorio:

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

Para configurar este módulo, agregue el campo `extensionless` al `package.json` de su proyecto:

```json
"extensionless": {
  "lookFor": ["js", "mjs", "cjs"]
}
```

|   Campo   | Valor Predeterminado |
| --------- | ------------------- |
| `lookFor` | `["js"]`            |

Nota: Si usas la bandera `--experimental-transform-types` con `node`, el valor `"ts"` se añade automáticamente al principio del arreglo `lookFor`, para que no tengas que configurarlo manualmente.

&nbsp;

Cuando se puede deducir del especificador que su objetivo es un directorio, el resolvedor busca solo los archivos índice:

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

Este cargador también añade soporte para la resolución de rutas en Windows, con lo que puedes usar barras diagonales hacia adelante o hacia atrás como separadores.

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