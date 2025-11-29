Node.js loader for import specifiers as file paths without extensions or as directory paths

&nbsp;

Install:

```
npm i extensionless
```

&nbsp;

Start `node` with the following flag added.

```
--import=extensionless/register
```

Note: If `node` version is lower than `20.6.0`, this doesn't work and it needs this flag instead:

```
--experimental-loader=extensionless
```

&nbsp;

You can now use import specifiers as file paths without extensions or as directory paths:

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

To configure this module, add the field `extensionless` to your project's `package.json`:

```json
"extensionless": {
  "lookFor": ["js", "mjs", "cjs"]
}
```

|   Field   | Default Value |
| --------- | ------------- |
| `lookFor` | `["js"]`      |

Note: If you use the flag `--experimental-transform-types` with `node`, the value `"ts"` is automatically prepended to the array `lookFor`, so that you won't need to configure it manually.

&nbsp;

When it can be deduced from the specifier that its target is a directory, the resolver looks for only the index files:

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

This loader also adds support for Windows path resolution with which you can use forward or backward slashes as separators.

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
