# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### Libreria 3D JavaScript

L'obiettivo del progetto è creare una libreria 3D facile da usare, leggera, multipiattaforma e di uso generale. Le build attuali includono solo i renderer WebGL e WebGPU, ma sono disponibili anche i renderer SVG e CSS3D come addon.

[Esempi](https://threejs.org/examples/) &mdash;
[Documentazione](https://threejs.org/docs/) &mdash;
[Manuale](https://threejs.org/manual/) &mdash;
[Wiki](https://github.com/mrdoob/three.js/wiki) &mdash;
[Migrazione](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[Domande](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[Forum](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### Utilizzo

Questo codice crea una scena, una camera e un cubo geometrico, aggiungendo il cubo alla scena. Successivamente crea un renderer `WebGL` per la scena e la camera, aggiungendo quella viewport all'elemento `document.body`. Infine, anima il cubo all'interno della scena per la camera.

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// init

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

// animation

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

Se tutto va bene, dovresti vedere [questo](https://jsfiddle.net/v98k6oze/).

### Clonare questo repository

Clonare il repository con tutta la sua cronologia risulta in un download di circa 2 GB. Se non hai bisogno dell’intera cronologia puoi usare il parametro `depth` per ridurre significativamente la dimensione del download.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### Registro delle modifiche

[Release](https://github.com/mrdoob/three.js/releases)


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