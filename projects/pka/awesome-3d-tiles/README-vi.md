# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> Danh sách tuyển chọn các phần mềm mã nguồn mở tuyệt vời, thư viện, công cụ và tài nguyên cho 3D tiles.

Hoan nghênh đóng góp. Thêm liên kết thông qua [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) hoặc tạo một [issue](https://github.com/pka/awesome-3d-tiles/issues) để bắt đầu thảo luận.

[3D Tiles](https://github.com/CesiumGS/3d-tiles) là một đặc tả mở để chia sẻ, trực quan hóa, kết hợp và tương tác với dữ liệu không gian 3D lớn, không đồng nhất trên các ứng dụng máy tính để bàn, web và di động.

3D Tiles là một [chuẩn cộng đồng OGC](https://www.ogc.org/standard/3dtiles/).

## Trình xem

* [CesiumJS](https://github.com/CesiumGS/cesium) - Thư viện JavaScript để tạo quả địa cầu 3D và bản đồ 2D trong trình duyệt web.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - Trình xem dựa trên Cesium cho CityGML và 3D Tiles.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - Bộ phân tích cú pháp và bộ mã hóa cho nhiều định dạng 3D, địa lý và dạng bảng chính.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - Khung WebGL cho phân tích dữ liệu khám phá trực quan với tập dữ liệu lớn.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - Bộ kết xuất dựa trên Three.js cho 3D Tiles.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - Mô-đun tải [Three.js](https://threejs.org/) để xử lý OGC 3D Tiles.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - Trình xem 3DTiles cho three.js.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - Lớp tùy chỉnh Mapbox GL JS cho 3D Tiles.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - Thành phần [A-Frame](https://aframe.io/) sử dụng 3D-Tiles.
* [iTowns](https://github.com/iTowns/itowns) - Khung JS/WebGL dựa trên Three.js.
* [giro3d](https://gitlab.com/giro3d/giro3d) - Khung JS/WebGL dựa trên Three.js (kế thừa của iTown).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - Trực quan hóa dữ liệu đô thị. Khung tạo ứng dụng web để trực quan hóa và tương tác với dữ liệu không gian 3D đô thị (dựa trên iTowns/Tree.js).
* [vsgCs](https://github.com/timoore/vsgCs) - Thư viện sử dụng 3D Tiles và nội dung không gian địa lý khác trong ứng dụng Vulkan Scene Graph (VSG)

## Tích hợp game engine, desktop GIS và công cụ mô hình hóa 3D (Mã nguồn mở)

* [QGIS](https://www.qgis.org/) - Hệ thống thông tin địa lý trên máy tính đa nền tảng (từ phiên bản 3.34).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Phần mở rộng Godot 4 tích hợp khả năng 3D Tiles của Cesium vào Godot Engine
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - Cesium cho O3DE
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - Công cụ [Blender](https://www.blender.org/) để chia nhỏ mô hình 3D.

## Tạo tile (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - Thư viện C++ cho truyền tải 3D Tiles, xử lý glTF.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - Công cụ và tiện ích để chuyển đổi, tối ưu, xử lý và phân tích dữ liệu 3D Tiles.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - Công cụ Javascript cho chuyển đổi và tối ưu glTF / GLB.

## Tạo tile (Cộng đồng)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - Đọc và ghi pnts và b3dm qua API hoặc CLI.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - Công cụ và thư viện Python cho phép xây dựng bộ tile 3D Tiles từ nhiều định dạng hình học như OBJ, GeoJSON, IFC hoặc CityGML thông qua cơ sở dữ liệu 3dCityDB.
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - Chuyển đổi hình học 3D PostGIS thành tile b3dm.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - mago 3DTiler chuyển đổi nhiều dữ liệu không gian thành OGC 3D Tiles.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - Chuyển đổi mô hình thành phố 3D (CityGML) sang nhiều định dạng địa lý, bao gồm 3D Tiles, MVT và GeoPackage.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - Chuyển đổi tệp OBJ sang OGC 3D tiles.
* [3dtiles](https://github.com/fanvanzh/3dtiles) - Chuyển đổi tệp Osgb(OpenSceneGraph Binary), Esri Shapefile và Fbx thành 3D Tiles.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - Chuyển đổi mô hình glTF sang định dạng Glb, b3dm hoặc 3d tiles.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - Chuyển đổi từ CityGML sang Cesium 3D Tiles.
* [vts23dtiles](https://github.com/melowntech/vts-tools) - Chuyển đổi bộ tile VTS thành bộ tile 3D Tileset.
* [3D City Database](https://www.3dcitydb.org/) - Cơ sở dữ liệu địa lý để lưu trữ, biểu diễn và quản lý mô hình thành phố 3D ảo.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → 3D Point Cloud Tiles.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - Chuyển đổi I3S sang 3D Tiles.
* [tyler](https://github.com/3DGI/tyler) - Chia nhỏ mô hình thành phố 3D được mã hóa bằng CityJSON

## Công cụ glTF

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform hỗ trợ đọc, chỉnh sửa và ghi mô hình 3D định dạng glTF 2.0.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - Thư viện và công cụ chuyển đổi hơn 40 định dạng tệp 3D sang glTF và nhiều hơn nữa ([các định dạng tệp](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Công cụ xuất glTF 2.0 của Blender.

## Địa hình

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) là một định dạng mã hóa lưới địa hình cho kết xuất địa hình hiệu quả phía client. Các tệp này được hỗ trợ trong Cesium và deck.gl.

Xem thêm [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) để biết thêm tài nguyên.

## Ứng dụng demo

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [Bài thuyết trình (tiếng Đức)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## Tài liệu học tập / Hướng dẫn

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - Tài liệu hội thảo kỹ thuật mago3DTiler từ FOSS4G-Asia (2024)

## Cộng đồng

* [Thảo luận](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---