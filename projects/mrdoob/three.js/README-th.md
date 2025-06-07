# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### ไลบรารี JavaScript สำหรับ 3 มิติ

เป้าหมายของโปรเจกต์นี้คือการสร้างไลบรารี 3 มิติที่ใช้งานง่าย น้ำหนักเบา รองรับหลายเบราว์เซอร์ และใช้งานได้หลากหลาย ปัจจุบันมีเฉพาะตัวเรนเดอร์ WebGL และ WebGPU ในตัว แต่ยังมีตัวเรนเดอร์ SVG และ CSS3D ให้ใช้งานเป็นเสริมด้วย

[ตัวอย่าง](https://threejs.org/examples/) &mdash;
[เอกสาร](https://threejs.org/docs/) &mdash;
[คู่มือ](https://threejs.org/manual/) &mdash;
[วิกิ](https://github.com/mrdoob/three.js/wiki) &mdash;
[การย้ายเวอร์ชัน](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[ถามตอบ](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[ฟอรั่ม](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### การใช้งาน

โค้ดนี้จะสร้างฉาก กล้อง และกล่องทรงเรขาคณิต จากนั้นเพิ่มกล่องนั้นเข้าไปในฉาก แล้วสร้างตัวเรนเดอร์ `WebGL` สำหรับฉากและกล้อง และเพิ่ม viewport นี้เข้าไปยังองค์ประกอบ `document.body` สุดท้ายจะทำการแอนิเมตกล่องในฉากให้กล้องเห็น

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

หากทุกอย่างถูกต้อง คุณควรเห็น [แบบนี้](https://jsfiddle.net/v98k6oze/)

### การโคลนรีโพสิทอรีนี้

การโคลนรีโปพร้อมประวัติทั้งหมดจะมีขนาดไฟล์ประมาณ ~2 GB หากคุณไม่ต้องการประวัติทั้งหมด สามารถใช้พารามิเตอร์ `depth` เพื่อลดขนาดไฟล์ที่ต้องดาวน์โหลดได้อย่างมาก

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### บันทึกการเปลี่ยนแปลง

[รีลีส](https://github.com/mrdoob/three.js/releases)


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