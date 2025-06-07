# Muhteşem 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> 3D tiles için harika açık kaynak yazılımlar, kütüphaneler, araçlar ve kaynaklardan oluşan özenle seçilmiş bir liste.

Katkılarınızı bekliyoruz. Bağlantı eklemek için [pull request](https://github.com/pka/awesome-3d-tiles/pulls) gönderebilir veya bir [issue](https://github.com/pka/awesome-3d-tiles/issues) oluşturarak tartışma başlatabilirsiniz.

[3D Tiles](https://github.com/CesiumGS/3d-tiles), masaüstü, web ve mobil uygulamalar arasında büyük ve heterojen 3B coğrafi içeriklerin paylaşılması, görselleştirilmesi, birleştirilmesi ve etkileşimi için açık bir spesifikasyondur.

3D Tiles bir [OGC topluluk standardıdır](https://www.ogc.org/standard/3dtiles/).

## Görüntüleyiciler

* [CesiumJS](https://github.com/CesiumGS/cesium) - Web tarayıcısında 3B küreler ve 2B haritalar oluşturmak için JavaScript kütüphanesi.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - CityGML ve 3D Tiles için Cesium tabanlı görüntüleyici.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - Birçok önemli 3B, coğrafi ve tablosal format için ayrıştırıcılar ve kodlayıcılar.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - Büyük veri setlerinin görsel keşfi için WebGL tabanlı çerçeve.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - 3D Tiles için Three.js tabanlı render motoru.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - [Three.js](https://threejs.org/) için OGC 3D Tiles yükleyici modülü.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - three.js için 3DTiles görüntüleyici.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - 3D Tiles için Mapbox GL JS özel katmanı.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - [A-Frame](https://aframe.io/) ile 3D-Tiles kullanan bileşen.
* [iTowns](https://github.com/iTowns/itowns) - Three.js tabanlı JS/WebGL çerçevesi.
* [giro3d](https://gitlab.com/giro3d/giro3d) - Three.js tabanlı JS/WebGL çerçevesi (iTown’un halefi).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - Kentsel Veri Görselleştirmesi. Coğrafi 3B kentsel verileri görselleştirmek ve etkileşimli web uygulamaları oluşturmak için çerçeve (iTowns/Three.js tabanlı).
* [vsgCs](https://github.com/timoore/vsgCs) - Vulkan Scene Graph (VSG) uygulamalarında 3D Tiles ve diğer coğrafi içerikleri kullanmak için kütüphane.

## Oyun motoru, masaüstü CBS ve 3B modelleme aracı entegrasyonları (Açık kaynak)

* [QGIS](https://www.qgis.org/) - Çok platformlu masaüstü coğrafi bilgi sistemi (sürüm 3.34’ten itibaren).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Godot Engine’e Cesium 3D Tiles yeteneklerini entegre eden Godot 4 eklentisi.
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - O3DE için Cesium entegrasyonu.
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - [Blender](https://www.blender.org/) ile 3B modelleri döşemek için araç.

## Tile oluşturma (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - 3D Tiles akışı ve glTF işleme için C++ kütüphanesi.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - 3D Tiles verilerini dönüştürmek, optimize etmek, işlemek ve analiz etmek için araçlar ve yardımcı programlar.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - glTF / GLB dönüştürme ve optimizasyonu için Javascript araçları.

## Tile oluşturma (Topluluk)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - API veya CLI üzerinden pnts ve b3dm okuma ve yazma.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - Farklı geometrik formatlardan (ör. OBJ, GeoJSON, IFC, CityGML) 3D Tiles döşemelerini 3dCityDB veritabanları üzerinden oluşturan Python aracı ve kütüphanesi.
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - PostGIS 3B geometrilerini b3dm döşemelerine dönüştürme.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - mago 3DTiler çeşitli mekansal verileri OGC 3D Tiles’a dönüştürür.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - 3B şehir modellerini (CityGML) 3D Tiles, MVT ve GeoPackage dahil olmak üzere çeşitli coğrafi formatlara dönüştürür.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - OBJ dosyalarını OGC 3D Tiles’a dönüştürür.
* [3dtiles](https://github.com/fanvanzh/3dtiles) - Osgb (OpenSceneGraph Binary), Esri Shapefile ve Fbx dosyalarını 3D Tiles’a dönüştürür.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - glTF modelini Glb, b3dm veya 3d tiles formatına dönüştürür.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - CityGML’den Cesium 3D Tiles’a dönüştürür.
* [vts23dtiles](https://github.com/melowntech/vts-tools) - VTS döşeme setini 3D Tileset’e dönüştürür.
* [3D City Database](https://www.3dcitydb.org/) - Sanal 3B şehir modellerini depolamak, temsil etmek ve yönetmek için coğrafi veritabanı.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → 3B Nokta Bulutu Döşemeleri.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - I3S’i 3D Tiles’a dönüştürür.
* [tyler](https://github.com/3DGI/tyler) - CityJSON ile kodlanmış 3B şehir modellerini döşemelere böler.

## glTF araçları

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform, glTF 2.0 formatında 3B modelleri okuma, düzenleme ve yazma desteği sunar.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - 40+ 3B dosya formatını glTF ve daha fazlasına dönüştüren kütüphane ve dönüştürücü ([dosya formatları](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Blender glTF 2.0 dışa aktarıcısı.

## Arazi

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh), verimli istemci tarafı arazi render’ı için arazi ağlarını kodlamak üzere bir formattır. Bu tür dosyalar Cesium ve deck.gl’de desteklenmektedir.

Daha fazla kaynak için [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) sayfasına bakın.

## Demo uygulamaları

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [Sunum (almanca)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## Öğrenme materyali / Nasıl yapılır

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - FOSS4G-Asia (2024) mago3DTiler teknik atölye materyalleri

## Topluluk

* [Tartışmalar](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---