# three.js

[![NPM 패키지][npm]][npm-url]
[![빌드 크기][build-size]][build-size-url]
[![NPM 다운로드][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### JavaScript 3D 라이브러리

이 프로젝트의 목표는 사용하기 쉽고, 가벼우며, 크로스 브라우저를 지원하는 범용 3D 라이브러리를 만드는 것입니다. 현재 빌드에는 WebGL 및 WebGPU 렌더러만 포함되어 있지만, SVG 및 CSS3D 렌더러도 애드온으로 제공됩니다.

[예제](https://threejs.org/examples/) &mdash;
[문서](https://threejs.org/docs/) &mdash;
[매뉴얼](https://threejs.org/manual/) &mdash;
[위키](https://github.com/mrdoob/three.js/wiki) &mdash;
[마이그레이션](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[질문](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[포럼](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### 사용법

이 코드는 씬, 카메라, 그리고 기하학적 큐브를 생성하고, 큐브를 씬에 추가합니다. 그 다음 씬과 카메라를 위한 `WebGL` 렌더러를 생성하고, 해당 뷰포트를 `document.body` 요소에 추가합니다. 마지막으로, 씬 내에서 큐브를 카메라를 기준으로 애니메이션 처리합니다.

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// 초기화

const camera = new THREE.PerspectiveCamera( 70, width / height, 0.01, 10 );
camera.position.z = 1;

const scene = new THREE.Scene();

const geometry = new THREE.BoxGeometry( 0.2, 0.2, 0.2 );
const material = new THREE.MeshNormalMaterial();

const mesh = new THREE.Mesh( geometry, material );
scene.add( mesh );

const renderer = new THREE.WebGLRenderer( { antialias: true } );
renderer.setSize( width, height );
renderer.setAnimationLoop( animate );
document.body.appendChild( renderer.domElement );

// 애니메이션

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

모든 설정이 잘 되었다면, [이것](https://jsfiddle.net/v98k6oze/)을 볼 수 있습니다.

### 리포지토리 클론

모든 히스토리를 포함하여 리포지토리를 클론하면 약 2GB를 다운로드하게 됩니다. 전체 히스토리가 필요하지 않다면, `depth` 파라미터를 사용하여 다운로드 크기를 크게 줄일 수 있습니다.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### 변경 로그

[릴리즈](https://github.com/mrdoob/three.js/releases)


[npm]: https://img.shields.io/npm/v/three
[npm-url]: https://www.npmjs.com/package/three
[build-size]: https://badgen.net/bundlephobia/minzip/three
[build-size-url]: https://bundlephobia.com/result?p=three
[npm-downloads]: https://img.shields.io/npm/dw/three
[npmtrends-url]: https://www.npmtrends.com/three
[discord]: https://img.shields.io/discord/685241246557667386
[discord-url]: https://discord.gg/56GBJwAnUS
[deepwiki]: https://deepwiki.com/badge.svg
[deepwiki-url]: https://deepwiki.com/mrdoob/three.js


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---