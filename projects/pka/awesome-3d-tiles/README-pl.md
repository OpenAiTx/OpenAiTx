# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> Wyselekcjonowana lista znakomitego otwartego oprogramowania, bibliotek, narzędzi i zasobów dla płytek 3D.

Wkład mile widziany. Dodaj linki poprzez [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) lub utwórz [issue](https://github.com/pka/awesome-3d-tiles/issues), aby rozpocząć dyskusję.

[3D Tiles](https://github.com/CesiumGS/3d-tiles) to otwarta specyfikacja do udostępniania, wizualizacji, łączenia i interakcji z ogromną, heterogeniczną zawartością geoprzestrzenną 3D w aplikacjach desktopowych, webowych i mobilnych.

3D Tiles to [standard społeczności OGC](https://www.ogc.org/standard/3dtiles/).

## Przeglądarki

* [CesiumJS](https://github.com/CesiumGS/cesium) – Biblioteka JavaScript do tworzenia globusów 3D i map 2D w przeglądarce internetowej.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) – Przeglądarka oparta na Cesium dla CityGML i 3D Tiles.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) – Parsery i enkodery dla wielu głównych formatów 3D, geoprzestrzennych i tabelarycznych.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) – Framework WebGL do eksploracyjnej analizy dużych zbiorów danych.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) – Renderer 3D Tiles oparty na Three.js.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) – [Three.js](https://threejs.org/) loader do obsługi OGC 3D Tiles.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) – Przeglądarka 3DTiles dla three.js.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) – Warstwa niestandardowa Mapbox GL JS dla 3D Tiles.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) – Komponent [A-Frame](https://aframe.io/) używający 3D-Tiles.
* [iTowns](https://github.com/iTowns/itowns) – Framework JS/WebGL oparty na Three.js.
* [giro3d](https://gitlab.com/giro3d/giro3d) – Framework JS/WebGL oparty na Three.js (następca iTown).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) – Wizualizacja danych miejskich. Framework do tworzenia aplikacji webowych do wizualizacji i interakcji z geoprzestrzennymi danymi miejskimi 3D (oparty na iTowns/Tree.js).
* [vsgCs](https://github.com/timoore/vsgCs) – biblioteka do używania 3D Tiles i innych treści geoprzestrzennych w aplikacji Vulkan Scene Graph (VSG)

## Integracje z silnikami gier, desktop GIS i narzędziami modelowania 3D (Open source)

* [QGIS](https://www.qgis.org/) – Wieloplatformowy desktopowy system informacji geograficznej (od wersji 3.34).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) – Rozszerzenie Godot 4 integrujące możliwości Cesium 3D Tiles z silnikiem Godot
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) – Cesium dla O3DE
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) – Narzędzie [Blender](https://www.blender.org/) do dzielenia modeli 3D na płytki.

## Tworzenie płytek (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) – OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) – Biblioteka C++ do streamingu 3D Tiles, przetwarzania glTF.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) – Narzędzia i utility do konwersji, optymalizacji, przetwarzania i analizy danych 3D Tiles.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) – Narzędzia JavaScript do konwersji i optymalizacji glTF / GLB.

## Tworzenie płytek (Społeczność)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) – Odczyt i zapis pnts i b3dm przez API lub CLI.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) – Narzędzie i biblioteka Pythona pozwalająca budować zestawy płytek 3D Tiles z różnych formatów geometrycznych, np. OBJ, GeoJSON, IFC lub CityGML przez bazy 3dCityDB.
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) – Konwersja geometrii 3D PostGIS do płytek b3dm.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) – mago 3DTiler konwertuje różne dane przestrzenne do OGC 3D Tiles.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) – Konwertuje modele miast 3D (CityGML) do różnych formatów geoprzestrzennych, w tym 3D Tiles, MVT i GeoPackage.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) – Konwertuje pliki OBJ do OGC 3D tiles.
* [3dtiles](https://github.com/fanvanzh/3dtiles) – Konwertuje pliki Osgb (OpenSceneGraph Binary), Esri Shapefile i Fbx do 3D Tiles.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) – Konwertuje model glTF do formatu Glb, b3dm lub 3d tiles.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) – Konwersja z CityGML do Cesium 3D Tiles.
* [vts23dtiles](https://github.com/melowntech/vts-tools) – Konwersja zestawu płytek VTS do zestawu 3D Tiles.
* [3D City Database](https://www.3dcitydb.org/) – Baza danych geoprzestrzennych do przechowywania, reprezentowania i zarządzania wirtualnymi modelami miast 3D.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) – XYZ → 3D Point Cloud Tiles.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) – Konwersja I3S do 3D Tiles.
* [tyler](https://github.com/3DGI/tyler) – Dzielenie modeli miast 3D zakodowanych w CityJSON na płytki

## Narzędzia glTF

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) – glTF-Transform obsługuje odczyt, edycję i zapis modeli 3D w formacie glTF 2.0.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) – Biblioteka i konwerter ponad 40 formatów plików 3D do glTF i innych ([formaty plików](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Eksporter Blender](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) – Eksporter Blender glTF 2.0.

## Teren

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) to format do kodowania siatek terenu dla wydajnego renderowania terenu po stronie klienta. Pliki te są obsługiwane w Cesium i deck.gl.

Zobacz [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) po więcej zasobów.

## Aplikacje demonstracyjne

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) – [Prezentacja (niemiecki)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## Materiały edukacyjne / Howto

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) – Materiały techniczne z warsztatów mago3DTiler z FOSS4G-Asia (2024)

## Społeczność

* [Dyskusje](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---