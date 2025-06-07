# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> Daftar pilihan perangkat lunak sumber terbuka, pustaka, alat, dan sumber daya terbaik untuk 3D tiles.

Kontribusi sangat diterima. Tambahkan tautan melalui [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) atau buat [issue](https://github.com/pka/awesome-3d-tiles/issues) untuk memulai diskusi.

[3D Tiles](https://github.com/CesiumGS/3d-tiles) adalah spesifikasi terbuka untuk berbagi, memvisualisasikan, menggabungkan, dan berinteraksi dengan konten geospasial 3D heterogen dalam jumlah besar di aplikasi desktop, web, dan mobile.

3D Tiles adalah [standar komunitas OGC](https://www.ogc.org/standard/3dtiles/).

## Penampil (Viewers)

* [CesiumJS](https://github.com/CesiumGS/cesium) - Pustaka JavaScript untuk membuat globe 3D dan peta 2D di peramban web.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - Penampil berbasis Cesium untuk CityGML dan 3D Tiles.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - Parser dan encoder untuk banyak format 3D, geospasial, dan tabular utama.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - Framework bertenaga WebGL untuk analisis data eksploratif visual pada dataset besar.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - Renderer berbasis Three.js untuk 3D Tiles.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - Modul loader [Three.js](https://threejs.org/) untuk menangani OGC 3D Tiles.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - Penampil 3DTiles untuk three.js.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - Layer kustom Mapbox GL JS untuk 3D Tiles.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - Komponen [A-Frame](https://aframe.io/) yang menggunakan 3D-Tiles.
* [iTowns](https://github.com/iTowns/itowns) - Framework JS/WebGL berbasis Three.js.
* [giro3d](https://gitlab.com/giro3d/giro3d) - Framework JS/WebGL berbasis Three.js (penerus iTown).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - Visualisasi Data Perkotaan. Framework untuk membuat aplikasi web guna memvisualisasikan dan berinteraksi dengan data kota 3D geospasial (berbasis iTowns/Tree.js).
* [vsgCs](https://github.com/timoore/vsgCs) - pustaka untuk menggunakan 3D Tiles dan konten geospasial lain dalam aplikasi Vulkan Scene Graph (VSG).

## Integrasi engine game, desktop GIS, dan alat pemodelan 3D (Sumber Terbuka)

* [QGIS](https://www.qgis.org/) - Sistem informasi geografis desktop multi-platform (sejak versi 3.34).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Ekstensi Godot 4 yang mengintegrasikan kemampuan Cesium 3D Tiles ke dalam Godot Engine.
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - Cesium untuk O3DE.
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - Alat [Blender](https://www.blender.org/) untuk membagi model 3D menjadi tile.

## Pembuatan Tile (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - Pustaka C++ untuk streaming 3D Tiles, pemrosesan glTF.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - Alat dan utilitas untuk mengonversi, mengoptimalkan, memproses, dan menganalisis data 3D Tiles.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - Alat Javascript untuk konversi dan optimasi glTF / GLB.

## Pembuatan Tile (Komunitas)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - Membaca dan menulis pnts dan b3dm melalui API atau CLI.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - Alat dan pustaka Python yang memungkinkan pembuatan tileset 3D Tiles dari berbagai format geometris seperti OBJ, GeoJSON, IFC atau CityGML melalui database 3dCityDB.
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - Konversi geometri 3D PostGIS ke tile b3dm.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - mago 3DTiler mengonversi berbagai data spasial ke OGC 3D Tiles.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - Konversi model kota 3D (CityGML) ke berbagai format geospasial, termasuk 3D Tiles, MVT, dan GeoPackage.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - Mengonversi file OBJ ke OGC 3D tiles.
* [3dtiles](https://github.com/fanvanzh/3dtiles) - Mengonversi Osgb (OpenSceneGraph Binary), Esri Shapefile, dan file Fbx ke 3D Tiles.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - Mengonversi model glTF ke format Glb, b3dm, atau 3d tiles.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - Konversi dari CityGML ke Cesium 3D Tiles.
* [vts23dtiles](https://github.com/melowntech/vts-tools) - Mengonversi tileset VTS ke 3D Tileset.
* [3D City Database](https://www.3dcitydb.org/) - Basis data geo untuk menyimpan, merepresentasikan, dan mengelola model kota virtual 3D.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → 3D Point Cloud Tiles.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - Mengonversi I3S ke 3D Tiles.
* [tyler](https://github.com/3DGI/tyler) - Membagi model kota 3D yang dikodekan dalam CityJSON menjadi tile.

## Alat glTF

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform mendukung pembacaan, pengeditan, dan penulisan model 3D dalam format glTF 2.0.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - Pustaka dan konverter untuk 40+ format file 3D ke glTF dan lainnya ([format file](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Eksporter Blender glTF 2.0.

## Terrain

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) adalah format untuk mengkode mesh terrain agar rendering terrain di sisi klien lebih efisien. File semacam ini didukung di Cesium dan deck.gl.

Lihat [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) untuk sumber daya lainnya.

## Aplikasi Demo

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [Presentasi (Jerman)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## Materi Pembelajaran / Cara

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - Materi workshop teknis mago3DTiler dari FOSS4G-Asia (2024)

## Komunitas

* [Diskusi](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---