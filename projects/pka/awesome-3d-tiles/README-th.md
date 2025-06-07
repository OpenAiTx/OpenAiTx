# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> รายการคัดสรรซอฟต์แวร์โอเพ่นซอร์ส ไลบรารี เครื่องมือ และทรัพยากรที่ยอดเยี่ยมสำหรับ 3D Tiles

ยินดีต้อนรับการมีส่วนร่วม เพิ่มลิงก์ผ่าน [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) หรือสร้าง [issue](https://github.com/pka/awesome-3d-tiles/issues) เพื่อเริ่มการสนทนา

[3D Tiles](https://github.com/CesiumGS/3d-tiles) เป็นข้อกำหนดแบบเปิดสำหรับการแบ่งปัน แสดงผล ผสาน และโต้ตอบกับข้อมูลภูมิสารสนเทศ 3 มิติขนาดใหญ่ที่มีความหลากหลายบนแอปพลิเคชันเดสก์ท็อป เว็บ และมือถือ

3D Tiles เป็น [มาตรฐานชุมชน OGC](https://www.ogc.org/standard/3dtiles/)

## โปรแกรมแสดงผล (Viewers)

* [CesiumJS](https://github.com/CesiumGS/cesium) - ไลบรารี JavaScript สำหรับสร้างโลก 3 มิติและแผนที่ 2 มิติในเว็บเบราว์เซอร์
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - Viewer สำหรับ CityGML และ 3D Tiles ที่ใช้ Cesium
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - เครื่องมือแปลงและเข้ารหัสไฟล์ 3D, geospatial และตารางข้อมูลหลักๆ
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - กรอบงาน WebGL สำหรับวิเคราะห์ข้อมูลขนาดใหญ่แบบสำรวจเชิงภาพ
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - Renderer สำหรับ 3D Tiles ที่ใช้ Three.js
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - โมดูลโหลด [Three.js](https://threejs.org/) สำหรับจัดการ OGC 3D Tiles
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - Viewer 3DTiles สำหรับ three.js
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - Mapbox GL JS custom layer สำหรับ 3D Tiles
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - คอมโพเนนต์ [A-Frame](https://aframe.io/) ที่ใช้ 3D-Tiles
* [iTowns](https://github.com/iTowns/itowns) - กรอบงาน JS/WebGL ที่ใช้ Three.js
* [giro3d](https://gitlab.com/giro3d/giro3d) - กรอบงาน JS/WebGL ที่ใช้ Three.js (สืบทอดจาก iTown)
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - เฟรมเวิร์กสำหรับสร้างเว็บแอปฯ เพื่อแสดงและโต้ตอบกับข้อมูลเมือง 3 มิติ (อิงจาก iTowns/Tree.js)
* [vsgCs](https://github.com/timoore/vsgCs) - ไลบรารีสำหรับใช้ 3D Tiles และเนื้อหาภูมิสารสนเทศอื่นๆ ภายในแอปพลิเคชัน Vulkan Scene Graph (VSG)

## การเชื่อมต่อกับเอนจิ้นเกม, เดสก์ท็อป GIS และเครื่องมือโมเดล 3D (โอเพ่นซอร์ส)

* [QGIS](https://www.qgis.org/) - ระบบภูมิสารสนเทศเชิงพื้นที่บนเดสก์ท็อปแบบข้ามแพลตฟอร์ม (ตั้งแต่เวอร์ชัน 3.34)
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - ส่วนขยาย Godot 4 ที่ผสานความสามารถ Cesium 3D Tiles เข้ากับ Godot Engine
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - Cesium สำหรับ O3DE
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - เครื่องมือ [Blender](https://www.blender.org/) สำหรับแบ่ง tiles โมเดล 3 มิติ

## การสร้าง Tile (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - ไลบรารี C++ สำหรับสตรีม 3D Tiles และประมวลผล glTF
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - เครื่องมือและยูทิลิตี้สำหรับแปลง ปรับปรุง ประมวลผล และวิเคราะห์ข้อมูล 3D Tiles
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - เครื่องมือ Javascript สำหรับแปลงและเพิ่มประสิทธิภาพ glTF / GLB

## การสร้าง Tile (ชุมชน)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - อ่านและเขียน pnts และ b3dm ผ่าน API หรือ CLI
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - เครื่องมือและไลบรารี Python สำหรับสร้าง tileset 3D Tiles จากไฟล์รูปทรงต่างๆ เช่น OBJ, GeoJSON, IFC หรือ CityGML ผ่านฐานข้อมูล 3dCityDB
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - แปลง PostGIS 3D geometries เป็น b3dm tiles
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - แปลงข้อมูลเชิงพื้นที่หลากหลายเป็น OGC 3D Tiles
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - แปลงโมเดลเมือง 3 มิติ (CityGML) เป็นรูปแบบภูมิสารสนเทศต่างๆ รวมถึง 3D Tiles, MVT, และ GeoPackage
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - แปลงไฟล์ OBJ เป็น OGC 3D Tiles
* [3dtiles](https://github.com/fanvanzh/3dtiles) - แปลงไฟล์ Osgb (OpenSceneGraph Binary), Esri Shapefile และ Fbx เป็น 3D Tiles
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - แปลงโมเดล glTF เป็น Glb, b3dm หรือ 3d tiles
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - แปลงจาก CityGML เป็น Cesium 3D Tiles
* [vts23dtiles](https://github.com/melowntech/vts-tools) - แปลง VTS tileset เป็น 3D Tileset
* [3D City Database](https://www.3dcitydb.org/) - ฐานข้อมูลภูมิสารสนเทศเพื่อจัดเก็บ แสดง และจัดการโมเดลเมือง 3 มิติ
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → 3D Point Cloud Tiles
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - แปลง I3S เป็น 3D Tiles
* [tyler](https://github.com/3DGI/tyler) - แบ่ง tiles โมเดลเมือง 3 มิติที่เข้ารหัสด้วย CityJSON

## เครื่องมือ glTF

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - รองรับการอ่าน แก้ไข และเขียนโมเดล 3 มิติในรูปแบบ glTF 2.0
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - ไลบรารีและเครื่องมือแปลงไฟล์ 3D กว่า 40 รูปแบบเป็น glTF และอื่นๆ ([รูปแบบไฟล์](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md))
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Blender glTF 2.0 Exporter

## ภูมิประเทศ (Terrain)

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) คือรูปแบบสำหรับเข้ารหัส mesh ภูมิประเทศเพื่อการแสดงผล terrain ฝั่งลูกข่ายอย่างมีประสิทธิภาพ ไฟล์เหล่านี้รองรับใน Cesium และ deck.gl

ดู [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) สำหรับทรัพยากรเพิ่มเติม

## ตัวอย่างแอปพลิเคชัน (Demo applications)

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [Presentation (german)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## เอกสารเรียนรู้ / วิธีทำ (Learning material / Howtos)

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles)
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - เอกสารเวิร์กช็อป mago3DTiler จาก FOSS4G-Asia (2024)

## ชุมชน (Community)

* [Discussions](https://github.com/pka/awesome-3d-tiles/discussions)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---