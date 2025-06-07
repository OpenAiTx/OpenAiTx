# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### مكتبة جافاسكريبت ثلاثية الأبعاد

هدف المشروع هو إنشاء مكتبة ثلاثية الأبعاد سهلة الاستخدام، وخفيفة الوزن، ومتوافقة مع جميع المتصفحات، وعامة الغرض. الإصدارات الحالية تتضمن فقط عارضات WebGL و WebGPU، لكن عارضات SVG و CSS3D متوفرة أيضًا كملاحق.

[أمثلة](https://threejs.org/examples/) &mdash;
[التوثيق](https://threejs.org/docs/) &mdash;
[الدليل](https://threejs.org/manual/) &mdash;
[ويكي](https://github.com/mrdoob/three.js/wiki) &mdash;
[دليل الترحيل](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[الأسئلة](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[المنتدى](https://discourse.threejs.org/) &mdash;
[ديسكورد](https://discord.gg/56GBJwAnUS)

### طريقة الاستخدام

ينشئ هذا الكود مشهداً وكاميرا ومكعباً هندسياً، ثم يضيف المكعب إلى المشهد. بعد ذلك ينشئ عارض `WebGL` للمشهد والكاميرا، ويضيف هذا المنظور إلى عنصر `document.body`. أخيرًا، يقوم بتحريك المكعب داخل المشهد من أجل الكاميرا.

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

إذا سار كل شيء على ما يرام، يجب أن ترى [هذا](https://jsfiddle.net/v98k6oze/).

### استنساخ هذا المستودع

استنساخ المستودع بكل تاريخه يؤدي إلى تحميل بحجم ~2 جيجابايت. إذا لم تكن بحاجة إلى كامل التاريخ، يمكنك استخدام معامل `depth` لتقليل حجم التحميل بشكل كبير.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### سجل التغييرات

[الإصدارات](https://github.com/mrdoob/three.js/releases)


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