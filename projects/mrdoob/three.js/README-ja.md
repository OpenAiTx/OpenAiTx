# three.js

[![NPM Package][npm]][npm-url]
[![Build Size][build-size]][build-size-url]
[![NPM Downloads][npm-downloads]][npmtrends-url]
[![Discord][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### JavaScript 3D ライブラリ

このプロジェクトの目的は、使いやすく、軽量で、クロスブラウザ対応の汎用3Dライブラリを作成することです。現在のビルドには WebGL および WebGPU レンダラーのみが含まれていますが、SVG および CSS3D レンダラーもアドオンとして利用可能です。

[サンプル](https://threejs.org/examples/) &mdash;
[ドキュメント](https://threejs.org/docs/) &mdash;
[マニュアル](https://threejs.org/manual/) &mdash;
[Wiki](https://github.com/mrdoob/three.js/wiki) &mdash;
[移行ガイド](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[質問](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[フォーラム](https://discourse.threejs.org/) &mdash;
[Discord](https://discord.gg/56GBJwAnUS)

### 使用方法

このコードは、シーン、カメラ、ジオメトリキューブを作成し、キューブをシーンに追加します。その後、シーンとカメラ用の `WebGL` レンダラーを作成し、そのビューポートを `document.body` 要素に追加します。最後に、シーン内のキューブをカメラでアニメーション表示します。

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// 初期化

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

// アニメーション

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

すべてが正常に動作すれば、[このような表示](https://jsfiddle.net/v98k6oze/)になります。

### このリポジトリのクローン

すべての履歴を含めてリポジトリをクローンすると、約2GBのダウンロードになります。全履歴が不要な場合は、`depth` パラメータを使うことでダウンロードサイズを大幅に削減できます。

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### 変更履歴

[リリース](https://github.com/mrdoob/three.js/releases)


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