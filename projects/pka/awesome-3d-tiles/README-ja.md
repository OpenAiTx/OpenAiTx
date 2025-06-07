# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> 3D Tilesのための素晴らしいオープンソースソフトウェア、ライブラリ、ツール、リソースの厳選リスト。

貢献は歓迎します。[プルリクエスト](https://github.com/pka/awesome-3d-tiles/pulls)でリンクを追加するか、[issue](https://github.com/pka/awesome-3d-tiles/issues)を作成してディスカッションを始めてください。

[3D Tiles](https://github.com/CesiumGS/3d-tiles)は、デスクトップ、Web、モバイルアプリケーション間で膨大かつ異種の3D地理空間コンテンツを共有、可視化、融合、対話するためのオープンスペックです。

3D Tilesは[OGCコミュニティ標準](https://www.ogc.org/standard/3dtiles/)です。

## ビューア

* [CesiumJS](https://github.com/CesiumGS/cesium) - Webブラウザ上で3D地球儀や2D地図を作成するJavaScriptライブラリ。
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - CityGMLおよび3D TilesのためのCesiumベースのビューア。
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - 主要な3D、地理空間、表形式フォーマットのパーサーとエンコーダー。
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - 大規模データセットのWebGLによる視覚的探索データ分析フレームワーク。
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - Three.jsベースの3D Tilesレンダラー。
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - [Three.js](https://threejs.org/)用OGC 3D Tilesローダーモジュール。
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - three.js用3DTilesビューア。
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - Mapbox GL JSカスタムレイヤーによる3D Tiles対応。
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - [A-Frame](https://aframe.io/)で3D-Tilesを利用するコンポーネント。
* [iTowns](https://github.com/iTowns/itowns) - Three.jsベースのJS/WebGLフレームワーク。
* [giro3d](https://gitlab.com/giro3d/giro3d) - Three.jsベースのJS/WebGLフレームワーク（iTownの後継）。
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - アーバンデータの可視化。都市地理空間3Dデータの可視化・対話型Webアプリ作成用フレームワーク（iTowns/Tree.jsベース）。
* [vsgCs](https://github.com/timoore/vsgCs) - Vulkan Scene Graph (VSG) アプリケーション内で3D Tilesや他の地理空間コンテンツを利用するためのライブラリ

## ゲームエンジン・デスクトップGIS・3Dモデリングツール統合（オープンソース）

* [QGIS](https://www.qgis.org/) - マルチプラットフォームデスクトップ地理情報システム（バージョン3.34以降）。
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - GodotエンジンでCesium 3D Tiles機能を統合するGodot 4拡張
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - O3DE向けCesium
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - [Blender](https://www.blender.org/)用3Dモデルタイル化ツール。

## タイル生成（Cesium GS Inc）

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles。
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - 3D TilesストリーミングやglTF処理のためのC++ライブラリ。
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - 3D Tilesデータの変換、最適化、処理、解析用ツール群。
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - glTF / GLBの変換・最適化用JavaScriptツール。

## タイル生成（コミュニティ）

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - APIやCLI経由でpntsやb3dmの読み書き。
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - OBJ, GeoJSON, IFC, CityGML等の各種ジオメトリフォーマットを3dCityDB経由で3D Tilesタイルセット化するPythonツール・ライブラリ。
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - PostGISの3Dジオメトリをb3dmタイルへ変換。
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - 各種空間データをOGC 3D Tilesに変換。
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - 3D都市モデル（CityGML）を3D TilesやMVT、GeoPackage等の各種地理空間フォーマットへ変換。
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - OBJファイルをOGC 3D Tilesに変換。
* [3dtiles](https://github.com/fanvanzh/3dtiles) - Osgb(OpenSceneGraph Binary)、Esri Shapefile、Fbxファイルを3D Tilesに変換。
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - glTFモデルをGlb、b3dmまたは3d tiles形式に変換。
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - CityGMLからCesium 3D Tilesへの変換。
* [vts23dtiles](https://github.com/melowntech/vts-tools) - VTSタイルセットを3D Tilesetに変換。
* [3D City Database](https://www.3dcitydb.org/) - 仮想3D都市モデルの格納・表示・管理用ジオデータベース。
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → 3D点群タイル。
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - I3Sから3D Tilesへの変換。
* [tyler](https://github.com/3DGI/tyler) - CityJSONでエンコードされた3D都市モデルのタイル化。

## glTFツール

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-TransformはglTF 2.0形式の3Dモデルの読み込み、編集、書き出しをサポート。
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - 40種類以上の3Dファイル形式をglTF等へ変換するライブラリ・コンバータ（[file formats](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)）。
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - BlenderのglTF 2.0エクスポーター。

## 地形

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh)は、効率的なクライアントサイド地形レンダリングのための地形メッシュエンコードフォーマットです。これらのファイルはCesiumやdeck.glでサポートされています。

詳細は[awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme)を参照してください。

## デモアプリケーション

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [プレゼンテーション（ドイツ語）](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## 学習資料／ハウツー

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles)
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - FOSS4G-Asia（2024）でのmago3DTiler技術ワークショップ資料

## コミュニティ

* [ディスカッション](https://github.com/pka/awesome-3d-tiles/discussions)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---