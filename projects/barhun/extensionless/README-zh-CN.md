Node.js 加载器，用于将导入说明符作为无扩展名的文件路径或目录路径

&nbsp;

安装：

```
npm i extensionless
```

&nbsp;

使用以下标志启动 `node`。

```
--import=extensionless/register
```
注意：如果 `node` 版本低于 `20.6.0`，此方法无法使用，需要使用此标志：


```
--experimental-loader=extensionless
```

&nbsp;

您现在可以将导入说明符用作无扩展名的文件路径或目录路径：

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

要配置此模块，请在项目的 `package.json` 中添加字段 `extensionless`：

```json
"extensionless": {
  "lookFor": ["js", "mjs", "cjs"]
}
```

|   字段    | 默认值        |
| --------- | ------------- |
| `lookFor` | `["js"]`      |

注意：如果你在使用 `node` 时添加了 `--experimental-transform-types` 标志，值 `"ts"` 会自动被添加到 `lookFor` 数组的开头，这样你就不需要手动配置了。

&nbsp;

当可以从说明符推断其目标是目录时，解析器只查找索引文件：

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

该加载器还支持Windows路径解析，允许您使用正斜杠或反斜杠作为分隔符。

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