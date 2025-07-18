# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### کتابخانه سه‌بعدی جاوااسکریپت

هدف این پروژه ایجاد یک کتابخانه سه‌بعدی آسان برای استفاده، سبک، چندمرورگری و عمومی است. نسخه‌های فعلی تنها شامل رندرکننده‌های WebGL و WebGPU هستند اما رندرکننده‌های SVG و CSS3D نیز به عنوان افزونه در دسترس هستند.

[نمونه‌ها](https://threejs.org/examples/) &mdash;
[مستندات](https://threejs.org/docs/) &mdash;
[راهنما](https://threejs.org/manual/) &mdash;
[ویکی](https://github.com/mrdoob/three.js/wiki) &mdash;
[مهاجرت](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[سوالات](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[فروم](https://discourse.threejs.org/) &mdash;
[دیسکورد](https://discord.gg/56GBJwAnUS)

### نحوه استفاده

این کد یک صحنه، یک دوربین و یک مکعب هندسی ایجاد می‌کند و مکعب را به صحنه اضافه می‌نماید. سپس یک رندرکننده `WebGL` برای صحنه و دوربین ایجاد می‌کند و آن نما را به عنصر `document.body` اضافه می‌کند. در نهایت، مکعب را درون صحنه برای دوربین انیمیت می‌کند.

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

اگر همه چیز به‌خوبی پیش برود، باید [این](https://jsfiddle.net/v98k6oze/) را مشاهده کنید.

### کلون کردن این مخزن

کلون کردن ریپو با تمام تاریخچه آن منجر به دانلودی حدود ۲ گیگابایت می‌شود. اگر به کل تاریخچه نیاز ندارید، می‌توانید با استفاده از پارامتر `depth` حجم دانلود را به طور قابل توجهی کاهش دهید.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### تاریخچه تغییرات

[انتشارها](https://github.com/mrdoob/three.js/releases)


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