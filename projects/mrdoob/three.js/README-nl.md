# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### JavaScript 3D-bibliotheek

Het doel van dit project is om een eenvoudig te gebruiken, lichtgewicht, cross-browser, algemene 3D-bibliotheek te creëren. De huidige builds bevatten alleen WebGL- en WebGPU-renderers, maar SVG- en CSS3D-renderers zijn ook beschikbaar als add-ons.

[Voorbeelden](https://threejs.org/examples/) &mdash;
[Documentatie](https://threejs.org/docs/) &mdash;
[Handleiding](https://threejs.org/manual/) &mdash;
[Wiki](https://github.com/mrdoob/three.js/wiki) &mdash;
[Migratie](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[Vragen](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[Forum](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### Gebruik

Deze code maakt een scène, een camera en een geometrische kubus, en voegt de kubus toe aan de scène. Vervolgens wordt er een `WebGL`-renderer voor de scène en camera gemaakt en wordt dat viewport toegevoegd aan het `document.body`-element. Tot slot wordt de kubus binnen de scène geanimeerd voor de camera.

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

// animatie

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

Als alles goed gaat, zou je [dit](https://jsfiddle.net/v98k6oze/) moeten zien.

### Deze repository klonen

Het klonen van de repo met de volledige geschiedenis resulteert in een download van ongeveer 2 GB. Als je niet de volledige geschiedenis nodig hebt, kun je de `depth`-parameter gebruiken om de downloadgrootte aanzienlijk te verkleinen.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### Wijzigingslogboek

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