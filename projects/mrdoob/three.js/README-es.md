# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### Biblioteca JavaScript 3D

El objetivo del proyecto es crear una biblioteca 3D fácil de usar, ligera, multiplataforma y de propósito general. Las versiones actuales solo incluyen renderizadores WebGL y WebGPU, pero los renderizadores SVG y CSS3D también están disponibles como complementos.

[Ejemplos](https://threejs.org/examples/) &mdash;
[Documentación](https://threejs.org/docs/) &mdash;
[Manual](https://threejs.org/manual/) &mdash;
[Wiki](https://github.com/mrdoob/three.js/wiki) &mdash;
[Migración](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[Preguntas](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[Foro](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### Uso

Este código crea una escena, una cámara y un cubo geométrico, y agrega el cubo a la escena. Luego crea un renderizador `WebGL` para la escena y la cámara, y agrega ese viewport al elemento `document.body`. Finalmente, anima el cubo dentro de la escena para la cámara.

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// inicialización

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

// animación

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

Si todo funciona correctamente, deberías ver [esto](https://jsfiddle.net/v98k6oze/).

### Clonar este repositorio

Clonar el repositorio con todo su historial resulta en una descarga de aproximadamente 2 GB. Si no necesitas todo el historial, puedes usar el parámetro `depth` para reducir significativamente el tamaño de la descarga.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### Registro de cambios

[Versiones](https://github.com/mrdoob/three.js/releases)


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