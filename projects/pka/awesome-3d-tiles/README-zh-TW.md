# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> 精選的 3D Tiles 開源軟體、函式庫、工具及資源列表。

歡迎貢獻。請透過 [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) 新增連結，或建立 [issue](https://github.com/pka/awesome-3d-tiles/issues) 開始討論。

[3D Tiles](https://github.com/CesiumGS/3d-tiles) 是一項開放規範，用於在桌面、網頁及行動應用間，分享、視覺化、融合並互動處理大規模異質三維地理空間內容。

3D Tiles 是 [OGC 社群標準](https://www.ogc.org/standard/3dtiles/)。

## 檢視器

* [CesiumJS](https://github.com/CesiumGS/cesium) - 用於在網頁瀏覽器中建立 3D 地球儀與 2D 地圖的 JavaScript 函式庫。
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - 基於 Cesium 的 CityGML 與 3D Tiles 檢視器。
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - 支援多種主流 3D、地理空間及表格式格式的解析器與編碼器。
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - 基於 WebGL 的大型資料集探索式視覺分析框架。
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - 基於 Three.js 的 3D Tiles 渲染器。
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - [Three.js](https://threejs.org/) 的 OGC 3D Tiles 載入模組。
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - three.js 的 3DTiles 檢視器。
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - Mapbox GL JS 3D Tiles 自定義圖層。
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - [A-Frame](https://aframe.io/) 的 3D-Tiles 元件。
* [iTowns](https://github.com/iTowns/itowns) - 基於 Three.js 的 JS/WebGL 框架。
* [giro3d](https://gitlab.com/giro3d/giro3d) - 基於 Three.js 的 JS/WebGL 框架（iTown 的後繼者）。
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - 城市資料視覺化。基於 iTowns/Tree.js 的 3D 城市地理資料視覺化及互動應用框架。
* [vsgCs](https://github.com/timoore/vsgCs) - 用於 Vulkan Scene Graph (VSG) 應用中載入 3D Tiles 及其他地理空間內容的函式庫。

## 遊戲引擎、桌面 GIS 與 3D 建模工具整合（開源）

* [QGIS](https://www.qgis.org/) - 跨平台桌面地理資訊系統（自 3.34 版起）。
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Godot 4 擴充，整合 Cesium 3D Tiles 功能至 Godot 引擎。
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - O3DE 的 Cesium 整合。
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - [Blender](https://www.blender.org/) 3D 模型分割工具。

## 瓦片產製（Cesium GS Inc）

* Cesium Ion（SaaS）
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles。
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - 3D Tiles 串流與 glTF 處理 C++ 函式庫。
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - 3D Tiles 資料轉換、最佳化、處理與分析工具。
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - glTF / GLB 轉換與最佳化 Javascript 工具。

## 瓦片產製（社群）

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - 透過 API 或 CLI 讀寫 pnts 與 b3dm。
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - Python 工具與函式庫，可將 OBJ、GeoJSON、IFC 或 CityGML 等多種格式，經由 3dCityDB 資料庫建構 3D Tiles tileset。
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - PostGIS 3D 幾何轉換為 b3dm 瓦片。
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - mago 3DTiler 支援多種空間資料轉換為 OGC 3D Tiles。
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - 將 3D 城市模型（CityGML）轉換為 3D Tiles、MVT、GeoPackage 等多種地理空間格式。
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - 將 OBJ 檔轉換成 OGC 3D tiles。
* [3dtiles](https://github.com/fanvanzh/3dtiles) - 將 Osgb（OpenSceneGraph Binary）、Esri Shapefile 及 Fbx 轉換為 3D Tiles。
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - glTF 模型轉換為 Glb、b3dm 或 3d tiles 格式。
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - CityGML 轉 Cesium 3D Tiles。
* [vts23dtiles](https://github.com/melowntech/vts-tools) - VTS tileset 轉換為 3D Tileset。
* [3D City Database](https://www.3dcitydb.org/) - 儲存、表示與管理虛擬 3D 城市模型的地理資料庫。
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → 3D 點雲瓦片。
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - I3S 轉 3D Tiles。
* [tyler](https://github.com/3DGI/tyler) - CityJSON 編碼 3D 城市模型分割為瓦片。

## glTF 工具

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform 支援 glTF 2.0 格式 3D 模型的讀取、編輯與寫入。
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - 支援 40+ 種 3D 檔案格式轉換至 glTF 及其他格式的函式庫（[檔案格式](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)）。
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Blender glTF 2.0 匯出外掛。

## 地形

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) 是一種高效客戶端地形渲染的地形網格編碼格式。Cesium 與 deck.gl 支援該格式。

更多資源請參見 [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme)。

## 範例應用

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [簡報（德文）](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## 學習資源／操作指南

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles)
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - FOSS4G-Asia (2024) mago3DTiler 技術工作坊教材

## 社群

* [討論區](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---