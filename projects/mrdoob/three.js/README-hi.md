# three.js

[![NPM पैकेज][npm]][npm-url]
[![बिल्ड साइज़][build-size]][build-size-url]
[![NPM डाउनलोड्स][npm-downloads]][npmtrends-url]
[![डिस्कॉर्ड][discord]][discord-url]
[![DeepWiki][deepwiki]][deepwiki-url]

#### जावास्क्रिप्ट 3D लाइब्रेरी

इस प्रोजेक्ट का उद्देश्य एक आसान-से-उपयोग करने योग्य, हल्की, क्रॉस-ब्राउज़र, सामान्य-उद्देश्य 3D लाइब्रेरी बनाना है। वर्तमान बिल्ड्स में केवल WebGL और WebGPU रेंडरर शामिल हैं, लेकिन SVG और CSS3D रेंडरर भी ऐडऑन के रूप में उपलब्ध हैं।

[उदाहरण](https://threejs.org/examples/) &mdash;
[डॉक्स](https://threejs.org/docs/) &mdash;
[मैन्युअल](https://threejs.org/manual/) &mdash;
[विकी](https://github.com/mrdoob/three.js/wiki) &mdash;
[माइग्रेटिंग](https://github.com/mrdoob/three.js/wiki/Migration-Guide) &mdash;
[प्रश्न](https://stackoverflow.com/questions/tagged/three.js) &mdash;
[फोरम](https://discourse.threejs.org/) &mdash;
[डिस्कॉर्ड](https://discord.gg/56GBJwAnUS)

### उपयोग

यह कोड एक सीन, एक कैमरा, और एक ज्योमेट्रिक घन बनाता है, और घन को सीन में जोड़ता है। फिर यह सीन और कैमरा के लिए एक `WebGL` रेंडरर बनाता है, और उस व्यूपोर्ट को `document.body` एलिमेंट में जोड़ता है। अंत में, यह कैमरे के लिए सीन के अंदर घन को एनिमेट करता है।

```javascript
import * as THREE from 'three';

const width = window.innerWidth, height = window.innerHeight;

// प्रारंभिककरण

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

// एनिमेशन

function animate( time ) {

	mesh.rotation.x = time / 2000;
	mesh.rotation.y = time / 1000;

	renderer.render( scene, camera );

}
```

यदि सब कुछ सही रहा, तो आपको [यह](https://jsfiddle.net/v98k6oze/) दिखाई देना चाहिए।

### इस रिपॉजिटरी को क्लोन करना

पूरा इतिहास के साथ रिपो को क्लोन करने पर लगभग ~2 GB डाउनलोड होता है। यदि आपको पूरा इतिहास नहीं चाहिए तो आप `depth` पैरामीटर का उपयोग करके डाउनलोड साइज़ को काफी हद तक कम कर सकते हैं।

```sh
git clone --depth=1 https://github.com/mrdoob/three.js.git
```

### चेंज लॉग

[रिलीज़](https://github.com/mrdoob/three.js/releases)


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