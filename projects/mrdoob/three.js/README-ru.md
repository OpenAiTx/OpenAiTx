# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### JavaScript 3D библиотека

Цель проекта — создать простую в использовании, легковесную, кроссбраузерную, универсальную 3D библиотеку. В текущих сборках доступны только рендереры WebGL и WebGPU, но рендереры SVG и CSS3D также доступны как дополнения.

[Примеры](https://threejs.org/examples/) &mdash;
[Документация](https://threejs.org/docs/) &mdash;
[Руководство](https://threejs.org/manual/) &mdash;
[Wiki](https://github.com/mrdoob/three.js/wiki) &mdash;
[Миграция](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[Вопросы](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[Форум](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### Использование

Этот код создаёт сцену, камеру и геометрический куб, а затем добавляет куб в сцену. Далее создаётся рендерер `WebGL` для сцены и камеры, и этот видовой экран добавляется в элемент `document.body`. В конце куб анимируется в сцене для камеры.

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// инициализация

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

// анимация

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

Если всё прошло успешно, вы должны увидеть [это](https://jsfiddle.net/v98k6oze/).

### Клонирование этого репозитория

Клонирование репозитория со всей историей занимает около 2 ГБ. Если вам не нужна вся история, вы можете использовать параметр `depth`, чтобы значительно уменьшить размер загрузки.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### Журнал изменений

[Релизы](https://github.com/mrdoob/three.js/releases)


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