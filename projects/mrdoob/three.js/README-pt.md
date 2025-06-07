# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### Biblioteca 3D em JavaScript

O objetivo do projeto é criar uma biblioteca 3D de uso geral, fácil de usar, leve e compatível com vários navegadores. As versões atuais incluem apenas renderizadores WebGL e WebGPU, mas renderizadores SVG e CSS3D também estão disponíveis como complementos.

[Exemplos](https://threejs.org/examples/) &mdash;
[Documentação](https://threejs.org/docs/) &mdash;
[Manual](https://threejs.org/manual/) &mdash;
[Wiki](https://github.com/mrdoob/three.js/wiki) &mdash;
[Migração](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[Perguntas](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[Fórum](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### Uso

Este código cria uma cena, uma câmera e um cubo geométrico, e adiciona o cubo à cena. Em seguida, cria um renderizador `WebGL` para a cena e a câmera, e adiciona esse viewport ao elemento `document.body`. Por fim, anima o cubo dentro da cena para a câmera.

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// inicialização

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

// animação

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

Se tudo correr bem, você deve ver [isto](https://jsfiddle.net/v98k6oze/).

### Clonando este repositório

Clonar o repositório com todo o seu histórico resulta em um download de aproximadamente 2 GB. Se você não precisa de todo o histórico, pode usar o parâmetro `depth` para reduzir significativamente o tamanho do download.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### Registro de alterações

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