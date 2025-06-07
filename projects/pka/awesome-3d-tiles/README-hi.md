# शानदार 3D टाइल्स [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> 3D टाइल्स के लिए शानदार ओपन सोर्स सॉफ्टवेयर, लाइब्रेरी, टूल्स और संसाधनों की एक क्यूरेटेड सूची।

योगदान का स्वागत है। [पुल रिक्वेस्ट्स](https://github.com/pka/awesome-3d-tiles/pulls) के माध्यम से लिंक जोड़ें या चर्चा शुरू करने के लिए एक [इश्यू](https://github.com/pka/awesome-3d-tiles/issues) बनाएं।

[3D टाइल्स](https://github.com/CesiumGS/3d-tiles) डेस्कटॉप, वेब और मोबाइल एप्लिकेशन में विशाल विषम 3D भू-स्थानिक सामग्री को साझा करने, देखने, संयोजित करने और इंटरैक्ट करने के लिए एक खुला विनिर्देशन है।

3D टाइल्स एक [OGC कम्युनिटी स्टैंडर्ड](https://www.ogc.org/standard/3dtiles/) है।

## व्यूअर्स

* [CesiumJS](https://github.com/CesiumGS/cesium) - वेब ब्राउज़र में 3D ग्लोब और 2D मैप बनाने के लिए जावास्क्रिप्ट लाइब्रेरी।
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - CityGML और 3D टाइल्स के लिए Cesium आधारित व्यूअर।
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - कई प्रमुख 3D, भू-स्थानिक और टेबुलर प्रारूपों के लिए पार्सर और एनकोडर।
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - बड़े डेटासेट के विज़ुअल एक्सप्लोरेटरी डेटा एनालिसिस के लिए WebGL-समर्थित फ्रेमवर्क।
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - Three.js आधारित 3D टाइल्स रेंडरर।
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - OGC 3D टाइल्स को संभालने के लिए [Three.js](https://threejs.org/) लोडर मॉड्यूल।
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - three.js के लिए 3DTiles व्यूअर।
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - 3D टाइल्स के लिए Mapbox GL JS कस्टम लेयर।
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - [A-Frame](https://aframe.io/) के लिए 3D-Tiles का उपयोग करने वाला कंपोनेंट।
* [iTowns](https://github.com/iTowns/itowns) - Three.js आधारित JS/WebGL फ्रेमवर्क।
* [giro3d](https://gitlab.com/giro3d/giro3d) - Three.js आधारित JS/WebGL फ्रेमवर्क (iTown का उत्तराधिकारी)।
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - अर्बन डेटा विज़ुअलाइज़ेशन। भू-स्थानिक 3D शहरी डेटा को विज़ुअलाइज़ और इंटरैक्ट करने के लिए वेब एप्लिकेशन बनाने का फ्रेमवर्क (iTowns/Tree.js पर आधारित)।
* [vsgCs](https://github.com/timoore/vsgCs) - Vulkan Scene Graph (VSG) एप्लिकेशन में 3D टाइल्स और अन्य भू-स्थानिक सामग्री का उपयोग करने के लिए एक लाइब्रेरी

## गेम इंजन, डेस्कटॉप GIS और 3D मॉडलिंग टूल इंटीग्रेशन (ओपन सोर्स)

* [QGIS](https://www.qgis.org/) - मल्टी-प्लेटफॉर्म डेस्कटॉप जियोग्राफिकल इन्फॉर्मेशन सिस्टम (संस्करण 3.34 से)।
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Godot 4 एक्सटेंशन जो Godot इंजन में Cesium 3D टाइल्स क्षमताओं को जोड़ता है।
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - O3DE के लिए Cesium
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - [Blender](https://www.blender.org/) टूल 3D मॉडलों को टाइल करने के लिए।

## टाइल निर्माण (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D टाइल्स।
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - 3D टाइल्स स्ट्रीमिंग, glTF प्रोसेसिंग के लिए C++ लाइब्रेरी।
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - 3D टाइल्स डेटा को बदलने, ऑप्टिमाइज़, प्रोसेस और विश्लेषण करने के लिए टूल्स और यूटिलिटीज।
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - glTF/GLB कन्वर्ज़न और ऑप्टिमाइज़ेशन के लिए जावास्क्रिप्ट टूल्स।

## टाइल निर्माण (कम्युनिटी)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - API या CLI के माध्यम से pnts और b3dm को पढ़ें और लिखें।
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - विभिन्न ज्यामितीय प्रारूपों जैसे OBJ, GeoJSON, IFC या CityGML को 3dCityDB डेटाबेस के माध्यम से 3D टाइल्स टाइलसेट्स में बदलने के लिए पाइथन टूल और लाइब्रेरी।
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - PostGIS 3D ज्यामितीय को b3dm टाइल्स में बदलना।
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - mago 3DTiler विभिन्न स्थानिक डेटा को OGC 3D टाइल्स में बदलता है।
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - 3D सिटी मॉडल (CityGML) को विभिन्न भू-स्थानिक प्रारूपों में बदलें, जिसमें 3D टाइल्स, MVT, और GeoPackage शामिल हैं।
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - OBJ फाइलों को OGC 3D टाइल्स में बदलता है।
* [3dtiles](https://github.com/fanvanzh/3dtiles) - Osgb (OpenSceneGraph Binary), Esri Shapefile और Fbx फाइलों को 3D टाइल्स में बदलता है।
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - glTF मॉडल को Glb, b3dm या 3D टाइल्स प्रारूप में बदलें।
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - CityGML से Cesium 3D टाइल्स में बदलें।
* [vts23dtiles](https://github.com/melowntech/vts-tools) - VTS टाइलसेट को 3D टाइलसेट में बदलें।
* [3D City Database](https://www.3dcitydb.org/) - वर्चुअल 3D सिटी मॉडल को संग्रहित, प्रस्तुत और प्रबंधित करने के लिए जियो डाटाबेस।
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → 3D प्वाइंट क्लाउड टाइल्स।
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - I3S को 3D टाइल्स में बदलें।
* [tyler](https://github.com/3DGI/tyler) - CityJSON में एन्कोडेड 3D सिटी मॉडल को टाइल करना

## glTF टूल्स

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform glTF 2.0 प्रारूप में 3D मॉडलों को पढ़ने, संपादित करने और लिखने का समर्थन करता है।
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - 40+ 3D-फाइल-फॉर्मेट्स को glTF और अधिक ([file formats](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)) में बदलने के लिए लाइब्रेरी और कन्वर्टर।
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Blender glTF 2.0 एक्सपोर्टर।

## टेरेन

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) टेरेन मेषों को कुशल क्लाइंट-साइड टेरेन रेंडरिंग के लिए एन्कोड करने का एक प्रारूप है। ऐसे फाइलों का समर्थन Cesium और deck.gl में किया जाता है।

अधिक संसाधनों के लिए देखें [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme)।

## डेमो एप्लिकेशन

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [प्रस्तुति (जर्मन)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## अध्ययन सामग्री / हाउ-टू

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles)।
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - FOSS4G-Asia (2024) से mago3DTiler तकनीकी कार्यशाला सामग्री

## कम्युनिटी

* [चर्चा](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---