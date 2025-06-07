# three.js

[![NPM Paketi][npm]][npm-url]
[![Yapı Boyutu][build-size]][build-size-url]
[![NPM İndirmeleri][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### JavaScript 3D kütüphanesi

Projenin amacı, kullanımı kolay, hafif, tarayıcılar arası uyumlu, genel amaçlı bir 3D kütüphanesi oluşturmaktır. Mevcut derlemeler yalnızca WebGL ve WebGPU render motorlarını içerir fakat SVG ve CSS3D render motorları da eklenti olarak mevcuttur.

[Örnekler](https://threejs.org/examples/) &mdash;
[Dökümanlar](https://threejs.org/docs/) &mdash;
[Kullanım Kılavuzu](https://threejs.org/manual/) &mdash;
[Wiki](https://github.com/mrdoob/three.js/wiki) &mdash;
[Geçiş](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[Sorular](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[Forum](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### Kullanım

Bu kod bir sahne, bir kamera ve geometrik bir küp oluşturur ve küpü sahneye ekler. Ardından sahne ve kamera için bir `WebGL` render motoru oluşturur ve bu görüntü alanını `document.body` öğesine ekler. Son olarak, küpü kameraya göre sahne içinde animasyonlu olarak döndürür.

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// başlat

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

// animasyon

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

Her şey yolunda giderse, [bunu](https://jsfiddle.net/v98k6oze/) görmelisiniz.

### Bu depoyu klonlamak

Depoyu tüm geçmişiyle birlikte klonlamak yaklaşık ~2 GB'lık bir indirme ile sonuçlanır. Tüm geçmişe ihtiyacınız yoksa, indirme boyutunu önemli ölçüde azaltmak için `depth` parametresini kullanabilirsiniz.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### Değişiklik günlüğü

[Sürümler](https://github.com/mrdoob/three.js/releases)


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