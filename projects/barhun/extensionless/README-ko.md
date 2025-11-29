확장자 없이 파일 경로로서 또는 디렉터리 경로로서 가져오기 지정자를 위한 Node.js 로더

&nbsp;

설치:

```
npm i extensionless
```
&nbsp;

다음 플래그를 추가하여 `node`를 시작하세요.


```
--import=extensionless/register
```
참고: `node` 버전이 `20.6.0`보다 낮으면 작동하지 않으며 대신 이 플래그가 필요합니다:


```
--experimental-loader=extensionless
```
&nbsp;

이제 확장자가 없는 파일 경로나 디렉터리 경로로 import 지정자를 사용할 수 있습니다:


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

이 모듈을 구성하려면 프로젝트의 `package.json`에 `extensionless` 필드를 추가하세요:

```json
"extensionless": {
  "lookFor": ["js", "mjs", "cjs"]
}
```
|   필드    | 기본값        |
| --------- | ------------- |
| `lookFor` | `["js"]`      |

참고: `node`에서 `--experimental-transform-types` 플래그를 사용하면 `"ts"` 값이 자동으로 `lookFor` 배열 앞에 추가되어 수동으로 설정할 필요가 없습니다.

&nbsp;

지정자에서 대상이 디렉터리임을 추론할 수 있을 때, 리졸버는 인덱스 파일만 찾습니다:


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

이 로더는 또한 Windows 경로 해석을 지원하여 경로 구분자로 슬래시(/) 또는 역슬래시(\)를 사용할 수 있습니다.


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