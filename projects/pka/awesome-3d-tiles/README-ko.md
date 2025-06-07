# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> 3D 타일을 위한 멋진 오픈 소스 소프트웨어, 라이브러리, 도구 및 리소스를 선별한 목록입니다.

기여를 환영합니다. [pull requests](https://github.com/pka/awesome-3d-tiles/pulls)를 통해 링크를 추가하거나, 논의를 시작하려면 [issue](https://github.com/pka/awesome-3d-tiles/issues)를 생성하세요.

[3D Tiles](https://github.com/CesiumGS/3d-tiles)는 대규모 이기종 3D 지리공간 콘텐츠를 데스크탑, 웹, 모바일 애플리케이션 전반에 걸쳐 공유, 시각화, 융합 및 상호작용할 수 있도록 하는 오픈 규격입니다.

3D Tiles는 [OGC 커뮤니티 표준](https://www.ogc.org/standard/3dtiles/)입니다.

## 뷰어

* [CesiumJS](https://github.com/CesiumGS/cesium) - 웹 브라우저에서 3D 지구본과 2D 지도를 생성하는 JavaScript 라이브러리.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - CityGML 및 3D Tiles용 Cesium 기반 뷰어.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - 주요 3D, 지리공간, 테이블 형식 파서 및 인코더.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - 대용량 데이터셋의 시각적 탐색적 데이터 분석을 위한 WebGL 기반 프레임워크.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - Three.js 기반 3D Tiles 렌더러.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - OGC 3D Tiles 처리를 위한 [Three.js](https://threejs.org/) 로더 모듈.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - three.js용 3DTiles 뷰어.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - 3D Tiles용 Mapbox GL JS 커스텀 레이어.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - 3D-Tiles를 사용하는 [A-Frame](https://aframe.io/) 컴포넌트.
* [iTowns](https://github.com/iTowns/itowns) - Three.js 기반 JS/WebGL 프레임워크.
* [giro3d](https://gitlab.com/giro3d/giro3d) - Three.js 기반 JS/WebGL 프레임워크(iTown의 후속작).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - 도시 데이터 시각화. 지리공간 3D 도시 데이터를 시각화하고 상호작용하는 웹 애플리케이션을 만들기 위한 프레임워크(iTowns/Tree.js 기반).
* [vsgCs](https://github.com/timoore/vsgCs) - Vulkan Scene Graph(VSG) 애플리케이션 내에서 3D Tiles 및 기타 지리공간 콘텐츠 사용을 위한 라이브러리.

## 게임 엔진, 데스크탑 GIS 및 3D 모델링 툴 통합(오픈소스)

* [QGIS](https://www.qgis.org/) - 멀티플랫폼 데스크탑 지리정보 시스템(3.34 버전부터 지원).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Godot 4 엔진에 Cesium 3D Tiles 기능을 통합하는 Godot 4 확장.
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - O3DE용 Cesium.
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - [Blender](https://www.blender.org/) 3D 모델 타일링 도구.

## 타일 생성(Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles 변환.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - 3D Tiles 스트리밍, glTF 처리용 C++ 라이브러리.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - 3D Tiles 데이터 변환, 최적화, 처리 및 분석용 도구 및 유틸리티.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - glTF / GLB 변환 및 최적화를 위한 자바스크립트 도구.

## 타일 생성(커뮤니티)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - API 또는 CLI를 통한 pnts 및 b3dm 읽기/쓰기.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - OBJ, GeoJSON, IFC, CityGML 등 다양한 기하 형식에서 3dCityDB 데이터베이스를 통해 3D Tiles 타일셋을 구축할 수 있는 Python 도구 및 라이브러리.
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - PostGIS 3D 지오메트리를 b3dm 타일로 변환.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - 다양한 공간 데이터를 OGC 3D Tiles로 변환하는 mago 3DTiler.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - 3D 도시 모델(CityGML)을 3D Tiles, MVT, GeoPackage 등 다양한 지리공간 형식으로 변환.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - OBJ 파일을 OGC 3D Tiles로 변환.
* [3dtiles](https://github.com/fanvanzh/3dtiles) - Osgb(OpenSceneGraph Binary), Esri Shapefile, Fbx 파일을 3D Tiles로 변환.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - glTF 모델을 Glb, b3dm 또는 3D Tiles 형식으로 변환.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - CityGML을 Cesium 3D Tiles로 변환.
* [vts23dtiles](https://github.com/melowntech/vts-tools) - VTS 타일셋을 3D Tileset으로 변환.
* [3D City Database](https://www.3dcitydb.org/) - 가상 3D 도시 모델을 저장, 표현, 관리하는 지리 데이터베이스.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → 3D 포인트 클라우드 타일.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - I3S를 3D Tiles로 변환.
* [tyler](https://github.com/3DGI/tyler) - CityJSON으로 인코딩된 3D 도시 모델 타일링.

## glTF 도구

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform은 glTF 2.0 형식의 3D 모델을 읽기, 편집, 쓰기를 지원.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - 40개 이상의 3D 파일 포맷을 glTF 등으로 변환하는 라이브러리 및 변환기([지원 파일 포맷](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Blender glTF 2.0 내보내기 도구.

## 지형

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh)는 클라이언트 측에서 효율적인 지형 렌더링을 위해 지형 메시를 인코딩하는 형식입니다. 해당 파일은 Cesium 및 deck.gl에서 지원됩니다.

추가 자료는 [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme)를 참고하세요.

## 데모 애플리케이션

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [발표자료(독일어)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## 학습 자료 / 사용법

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - FOSS4G-Asia(2024) mago3DTiler 기술 워크숍 자료

## 커뮤니티

* [Discussions](https://github.com/pka/awesome-3d-tiles/discussions)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---