# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### Library 3D JavaScript

Tujuan dari proyek ini adalah untuk menciptakan library 3D yang mudah digunakan, ringan, lintas-browser, dan serbaguna. Build saat ini hanya mencakup renderer WebGL dan WebGPU namun renderer SVG dan CSS3D juga tersedia sebagai addon.

[Contoh](https://threejs.org/examples/) &mdash;
[Dokumentasi](https://threejs.org/docs/) &mdash;
[Manual](https://threejs.org/manual/) &mdash;
[Wiki](https://github.com/mrdoob/three.js/wiki) &mdash;
[Migrasi](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[Pertanyaan](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[Forum](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### Penggunaan

Kode ini membuat sebuah scene, kamera, dan kubus geometris, lalu menambahkan kubus ke dalam scene. Kemudian membuat renderer `WebGL` untuk scene dan kamera, serta menambahkan viewport tersebut ke elemen `document.body`. Terakhir, kubus dianimasikan di dalam scene untuk kamera.

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// inisialisasi

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

// animasi

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

Jika semuanya berjalan dengan baik, Anda akan melihat [ini](https://jsfiddle.net/v98k6oze/).

### Mengkloning repositori ini

Mengkloning repo beserta seluruh riwayatnya menghasilkan unduhan sekitar ~2 GB. Jika Anda tidak memerlukan seluruh riwayat, Anda dapat menggunakan parameter `depth` untuk secara signifikan mengurangi ukuran unduhan.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### Catatan perubahan

[Rilis](https://github.com/mrdoob/three.js/releases)


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