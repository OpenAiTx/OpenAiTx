# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### Bibliothèque JavaScript 3D

Le but du projet est de créer une bibliothèque 3D légère, facile à utiliser, multiplateforme et à usage général. Les versions actuelles incluent uniquement des moteurs de rendu WebGL et WebGPU, mais des moteurs de rendu SVG et CSS3D sont également disponibles en tant qu’extensions.

[Exemples](https://threejs.org/examples/) &mdash;
[Docs](https://threejs.org/docs/) &mdash;
[Manuel](https://threejs.org/manual/) &mdash;
[Wiki](https://github.com/mrdoob/three.js/wiki) &mdash;
[Migration](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[Questions](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[Forum](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### Utilisation

Ce code crée une scène, une caméra et un cube géométrique, puis ajoute le cube à la scène. Il crée ensuite un moteur de rendu `WebGL` pour la scène et la caméra, et ajoute ce viewport à l’élément `document.body`. Enfin, il anime le cube dans la scène pour la caméra.

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// initialisation

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

Si tout se passe bien, vous devriez voir [ceci](https://jsfiddle.net/v98k6oze/).

### Clonage de ce dépôt

Cloner le dépôt avec tout son historique entraîne un téléchargement d’environ 2 Go. Si vous n’avez pas besoin de tout l’historique, vous pouvez utiliser le paramètre `depth` pour réduire considérablement la taille du téléchargement.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### Journal des modifications

[Releases](https://github.com/mrdoob/three.js/releases)


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