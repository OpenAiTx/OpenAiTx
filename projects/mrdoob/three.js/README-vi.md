# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### Thư viện JavaScript 3D

Mục tiêu của dự án là tạo ra một thư viện 3D dễ sử dụng, nhẹ, đa trình duyệt, đa mục đích. Các bản dựng hiện tại chỉ bao gồm các bộ kết xuất WebGL và WebGPU nhưng các bộ kết xuất SVG và CSS3D cũng có sẵn dưới dạng tiện ích bổ sung.

[Ví dụ](https://threejs.org/examples/) &mdash;
[Tài liệu](https://threejs.org/docs/) &mdash;
[Sổ tay](https://threejs.org/manual/) &mdash;
[Wiki](https://github.com/mrdoob/three.js/wiki) &mdash;
[Di cư](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[Câu hỏi](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[Diễn đàn](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### Sử dụng

Đoạn mã này tạo ra một cảnh, một camera và một khối hình học, sau đó thêm khối vào cảnh. Tiếp theo, nó tạo một bộ kết xuất `WebGL` cho cảnh và camera, và thêm vùng hiển thị đó vào phần tử `document.body`. Cuối cùng, nó tạo hoạt ảnh cho khối trong cảnh đối với camera.

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// khởi tạo

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

// hoạt ảnh

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

Nếu mọi việc diễn ra suôn sẻ, bạn sẽ thấy [kết quả này](https://jsfiddle.net/v98k6oze/).

### Nhân bản kho lưu trữ này

Nhân bản kho cùng với toàn bộ lịch sử sẽ dẫn đến việc tải về khoảng ~2 GB. Nếu bạn không cần toàn bộ lịch sử, bạn có thể sử dụng tham số `depth` để giảm đáng kể kích thước tải về.

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### Nhật ký thay đổi

[Phát hành](https://github.com/mrdoob/three.js/releases)


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