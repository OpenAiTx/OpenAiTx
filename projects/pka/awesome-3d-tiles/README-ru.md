# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> Кураторский список отличного открытого программного обеспечения, библиотек, инструментов и ресурсов для 3D tiles.

Добро пожаловать к участию. Добавляйте ссылки через [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) или создайте [issue](https://github.com/pka/awesome-3d-tiles/issues) для начала обсуждения.

[3D Tiles](https://github.com/CesiumGS/3d-tiles) — это открытая спецификация для обмена, визуализации, объединения и взаимодействия с массивным неоднородным трехмерным геопространственным контентом на настольных, веб- и мобильных приложениях.

3D Tiles — это [стандарт сообщества OGC](https://www.ogc.org/standard/3dtiles/).

## Просмотрщики

* [CesiumJS](https://github.com/CesiumGS/cesium) — JavaScript библиотека для создания 3D глобусов и 2D карт в веб-браузере.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) — Просмотрщик на основе Cesium для CityGML и 3D Tiles.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) — Парсеры и кодеры для многих основных 3D, геопространственных и табличных форматов.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) — Фреймворк на WebGL для визуального анализа больших наборов данных.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) — Рендерер 3D Tiles на базе Three.js.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) — Модуль загрузчика [Three.js](https://threejs.org/) для работы с OGC 3D Tiles.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) — Просмотрщик 3DTiles для three.js.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) — Кастомный слой Mapbox GL JS для 3D Tiles.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) — Компонент [A-Frame](https://aframe.io/) с использованием 3D-Tiles.
* [iTowns](https://github.com/iTowns/itowns) — JS/WebGL-фреймворк на основе Three.js.
* [giro3d](https://gitlab.com/giro3d/giro3d) — JS/WebGL-фреймворк на основе Three.js (преемник iTown).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) — Визуализация городских данных. Фреймворк для создания веб-приложений для визуализации и взаимодействия с геопространственными 3D городскими данными (на основе iTowns/Three.js).
* [vsgCs](https://github.com/timoore/vsgCs) — библиотека для использования 3D Tiles и другого геопространственного контента в приложениях Vulkan Scene Graph (VSG).

## Интеграция с игровыми движками, настольными ГИС и 3D-моделирующими инструментами (Open source)

* [QGIS](https://www.qgis.org/) — Мультиплатформенная настольная геоинформационная система (с версии 3.34).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) — Расширение для Godot 4, интегрирующее возможности Cesium 3D Tiles в движок Godot.
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) — Cesium для O3DE.
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) — Инструмент [Blender](https://www.blender.org/) для нарезки 3D моделей на тайлы.

## Создание тайлов (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) — OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) — C++ библиотека для стриминга 3D Tiles, обработки glTF.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) — Инструменты для конвертации, оптимизации, обработки и анализа данных 3D Tiles.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) — Javascript-инструменты для конвертации и оптимизации glTF / GLB.

## Создание тайлов (Сообщество)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) — Чтение и запись pnts и b3dm через API или CLI.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) — Python-инструмент и библиотека для построения наборов 3D Tiles из различных геометрических форматов, например, OBJ, GeoJSON, IFC или CityGML через базы 3dCityDB.
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) — Конвертация 3D-геометрий PostGIS в b3dm-тайлы.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) — mago 3DTiler преобразует различные пространственные данные в OGC 3D Tiles.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) — Конвертация 3D городских моделей (CityGML) в различные геопространственные форматы, включая 3D Tiles, MVT и GeoPackage.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) — Преобразует OBJ-файлы в OGC 3D tiles.
* [3dtiles](https://github.com/fanvanzh/3dtiles) — Конвертирует Osgb (OpenSceneGraph Binary), Esri Shapefile и Fbx-файлы в 3D Tiles.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) — Конвертация glTF модели в Glb, b3dm или 3d tiles формат.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) — Конвертация из CityGML в Cesium 3D Tiles.
* [vts23dtiles](https://github.com/melowntech/vts-tools) — Конвертация набора тайлов VTS в 3D Tileset.
* [3D City Database](https://www.3dcitydb.org/) — Геобаза данных для хранения, отображения и управления виртуальными 3D городскими моделями.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) — XYZ → 3D Point Cloud Tiles.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) — Конвертация I3S в 3D Tiles.
* [tyler](https://github.com/3DGI/tyler) — Нарезка 3D городских моделей, закодированных в CityJSON.

## Инструменты для glTF

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) — Поддержка чтения, редактирования и записи 3D моделей в формате glTF 2.0.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) — Библиотека и конвертер для 40+ 3D-форматов файлов в glTF и другие ([форматы файлов](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) — Экспортер Blender для glTF 2.0.

## Рельеф

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) — это формат кодирования рельефных мешей для эффективного клиентского рендеринга рельефа. Такие файлы поддерживаются в Cesium и deck.gl.

Смотрите [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) для дополнительных ресурсов.

## Демонстрационные приложения

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) — [Презентация (немецкий)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## Обучающие материалы / Howtos

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) — Технические материалы по mago3DTiler с FOSS4G-Asia (2024)

## Сообщество

* [Обсуждения](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---