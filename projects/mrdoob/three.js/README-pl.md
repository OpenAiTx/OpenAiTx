# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### Biblioteka JavaScript 3D

Celem projektu jest stworzenie łatwej w użyciu, lekkiej, wieloplatformowej, uniwersalnej biblioteki 3D. Aktualne wersje zawierają tylko renderery WebGL i WebGPU, jednak renderery SVG i CSS3D są również dostępne jako dodatki.

[Przykłady](https://threejs.org/examples/) &mdash;
[Dokumentacja](https://threejs.org/docs/) &mdash;
[Podręcznik](https://threejs.org/manual/) &mdash;
[Wiki](https://github.com/mrdoob/three.js/wiki) &mdash;
[Migracja](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[Pytania](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[Forum](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### Użycie

Ten kod tworzy scenę, kamerę oraz geometryczną kostkę i dodaje ją do sceny. Następnie tworzy renderer `WebGL` dla sceny i kamery oraz dodaje ten viewport do elementu `document.body`. Na koniec animuje kostkę w scenie dla kamery.

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// inicjalizacja

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

// animacja

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

Jeśli wszystko pójdzie dobrze, powinieneś zobaczyć [to](https://jsfiddle.net/v98k6oze/).

### Klonowanie tego repozytorium

Klonowanie repozytorium z całą jego historią skutkuje pobraniem pliku o wielkości około 2 GB. Jeśli nie potrzebujesz całej historii, możesz użyć parametru `depth`, aby znacznie zmniejszyć rozmiar pobieranego pliku.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### Dziennik zmian

[Wydania](https://github.com/mrdoob/three.js/releases)


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