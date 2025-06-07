# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> 精选的开源软件、库、工具和3D Tiles相关资源列表。

欢迎贡献。如需添加链接，请通过 [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) 或创建 [issue](https://github.com/pka/awesome-3d-tiles/issues) 开始讨论。

[3D Tiles](https://github.com/CesiumGS/3d-tiles) 是一个开放规范，用于在桌面、网页和移动应用程序之间共享、可视化、融合和交互大规模异构三维地理空间内容。

3D Tiles 是 [OGC 社区标准](https://www.ogc.org/standard/3dtiles/)。

## 查看器

* [CesiumJS](https://github.com/CesiumGS/cesium) - 用于在网页浏览器中创建3D地球和2D地图的JavaScript库。
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - 基于Cesium的CityGML和3D Tiles查看器。
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - 支持多种主要3D、地理空间和表格格式的解析和编码器。
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - 基于WebGL的大型数据集可视探索分析框架。
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - 基于Three.js的3D Tiles渲染器。
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - [Three.js](https://threejs.org/) 的OGC 3D Tiles加载模块。
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - 基于three.js的3DTiles查看器。
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - Mapbox GL JS的3D Tiles自定义图层。
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - [A-Frame](https://aframe.io/) 的3D Tiles组件。
* [iTowns](https://github.com/iTowns/itowns) - 基于Three.js的JS/WebGL框架。
* [giro3d](https://gitlab.com/giro3d/giro3d) - 基于Three.js的JS/WebGL框架（iTown的继任者）。
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - 城市数据可视化。用于创建可视化和交互地理空间3D城市数据的Web应用框架（基于iTowns/Tree.js）。
* [vsgCs](https://github.com/timoore/vsgCs) - 在Vulkan Scene Graph (VSG) 应用中使用3D Tiles和其他地理空间内容的库

## 游戏引擎、桌面GIS和3D建模工具集成（开源）

* [QGIS](https://www.qgis.org/) - 跨平台桌面地理信息系统（自3.34版本起支持）。
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Godot 4扩展，将Cesium 3D Tiles功能集成到Godot引擎中
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - O3DE的Cesium集成
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - [Blender](https://www.blender.org/) 3D模型切片工具。

## 瓦片生成（Cesium GS 公司）

* Cesium Ion（SaaS）
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles。
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - 用于3D Tiles流式传输和glTF处理的C++库。
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - 3D Tiles数据的转换、优化、处理和分析工具。
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - glTF / GLB转换与优化的JavaScript工具。

## 瓦片生成（社区）

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - 通过API或CLI读取和写入pnts及b3dm。
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - 用于从多种几何格式（如OBJ、GeoJSON、IFC或CityGML，通过3dCityDB数据库）构建3D Tiles瓦片集的Python工具和库。
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - 将PostGIS 3D几何体转换为b3dm瓦片。
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - mago 3DTiler将各种空间数据转换为OGC 3D Tiles。
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - 将3D城市模型（CityGML）转换为多种地理空间格式，包括3D Tiles、MVT和GeoPackage。
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - 将OBJ文件转换为OGC 3D Tiles。
* [3dtiles](https://github.com/fanvanzh/3dtiles) - 将Osgb（OpenSceneGraph Binary）、Esri Shapefile和Fbx文件转换为3D Tiles。
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - 将glTF模型转换为Glb、b3dm或3d tiles格式。
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - 从CityGML转换为Cesium 3D Tiles。
* [vts23dtiles](https://github.com/melowntech/vts-tools) - 将VTS瓦片集转换为3D Tileset。
* [3D City Database](https://www.3dcitydb.org/) - 用于存储、表示和管理虚拟3D城市模型的地理数据库。
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → 3D点云瓦片。
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - I3S转3D Tiles。
* [tyler](https://github.com/3DGI/tyler) - 对用CityJSON编码的3D城市模型进行切片

## glTF工具

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform支持读取、编辑和写入glTF 2.0格式的3D模型。
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - 支持40多种3D文件格式转换为glTF及更多格式的库和转换器（[文件格式](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)）。
* [Blender导出器](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Blender的glTF 2.0导出器。

## 地形

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) 是一种用于高效客户端地形渲染的地形网格编码格式。Cesium和deck.gl均支持此格式。

更多资源请参见 [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme)。

## 演示应用

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [演示文稿（德语）](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## 学习资料 / 使用方法

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles)。
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - FOSS4G-Asia（2024）mago3DTiler技术培训材料

## 社区

* [讨论区](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---