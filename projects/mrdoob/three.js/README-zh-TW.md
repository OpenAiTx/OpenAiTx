# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### JavaScript 3D 函式庫

本專案的目標是打造一個易於使用、輕量級、跨瀏覽器且通用的 3D 函式庫。目前的版本僅包含 WebGL 和 WebGPU 渲染器，但 SVG 和 CSS3D 渲染器也可作為附加元件使用。

[範例](https://threejs.org/examples/) &mdash;
[文件](https://threejs.org/docs/) &mdash;
[手冊](https://threejs.org/manual/) &mdash;
[維基](https://github.com/mrdoob/three.js/wiki) &mdash;
[遷移指南](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[問題討論](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[論壇](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### 使用方式

以下程式碼建立了一個場景、一個相機以及一個立方體幾何體，並將立方體加入場景。接著為場景和相機建立一個 `WebGL` 渲染器，並將該視口加入到 `document.body` 元素中。最後，在場景中為相機動畫顯示立方體。

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// 初始化

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

// 動畫

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

如果一切順利，你應該會看到[這個畫面](https://jsfiddle.net/v98k6oze/)。

### 複製此儲存庫

將此儲存庫完整複製（包含所有歷史紀錄）約需下載 2 GB。如果你不需要完整歷史紀錄，可以使用 `depth` 參數來大幅減少下載容量。

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### 變更日誌

[版本發佈](https://github.com/mrdoob/three.js/releases)


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