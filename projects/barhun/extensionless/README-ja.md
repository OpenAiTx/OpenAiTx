拡張子なしのファイルパスやディレクトリパスとしてのimport指定子のためのNode.jsローダー

&nbsp;

インストール:

```
npm i extensionless
```

&nbsp;

次のフラグを追加して `node` を起動します。

```
--import=extensionless/register
```

注意: `node` バージョンが `20.6.0` 未満の場合、これは動作せず、代わりにこのフラグが必要です:

```
--experimental-loader=extensionless
```

&nbsp;

拡張子なしのファイルパスやディレクトリパスとしてインポート指定子を使用できるようになりました：

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

このモジュールを設定するには、プロジェクトの `package.json` にフィールド `extensionless` を追加してください:

```json
"extensionless": {
  "lookFor": ["js", "mjs", "cjs"]
}
```

|   フィールド   | デフォルト値     |
| --------- | ------------- |
| `lookFor` | `["js"]`      |

注：`node`でフラグ`--experimental-transform-types`を使用すると、配列`lookFor`の先頭に自動的に値`"ts"`が追加されるため、手動で設定する必要はありません。

&nbsp;

specifierからそのターゲットがディレクトリであると推測できる場合、リゾルバーはインデックスファイルのみを検索します：

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

このローダーは、Windowsのパス解決もサポートしており、区切り文字としてスラッシュ（/）またはバックスラッシュ（\）を使用できます。

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