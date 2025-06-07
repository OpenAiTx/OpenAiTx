# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> Een samengestelde lijst van geweldige open source software, bibliotheken, tools en bronnen voor 3D tiles.

Bijdragen zijn welkom. Voeg links toe via [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) of maak een [issue](https://github.com/pka/awesome-3d-tiles/issues) om een discussie te starten.

[3D Tiles](https://github.com/CesiumGS/3d-tiles) is een open specificatie voor het delen, visualiseren, combineren en interacteren met enorme heterogene 3D geospatiale inhoud over desktop-, web- en mobiele applicaties.

3D Tiles is een [OGC community standard](https://www.ogc.org/standard/3dtiles/).

## Viewers

* [CesiumJS](https://github.com/CesiumGS/cesium) - JavaScript-bibliotheek voor het maken van 3D-globes en 2D-kaarten in een webbrowser.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - Cesium gebaseerde Viewer voor CityGML en 3D Tiles.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - Parsers en encoders voor vele belangrijke 3D-, geospatiale en tabelvormige formaten.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - WebGL-aangedreven framework voor visuele verkennende data-analyse van grote datasets.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - Three.js gebaseerde renderer voor 3D Tiles.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - [Three.js](https://threejs.org/) loader-module voor het verwerken van OGC 3D Tiles.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - 3DTiles viewer voor three.js.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - Mapbox GL JS custom layer voor 3D Tiles.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - [A-Frame](https://aframe.io/) component die 3D-Tiles gebruikt.
* [iTowns](https://github.com/iTowns/itowns) - Three.js gebaseerde JS/WebGL framework.
* [giro3d](https://gitlab.com/giro3d/giro3d) - Three.js gebaseerde JS/WebGL framework (opvolger van iTown).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - Urban Data Visualisatie. Framework voor het maken van webapplicaties voor het visualiseren en interacteren met geospatiale 3D stedelijke data (gebaseerd op iTowns/Three.js).
* [vsgCs](https://github.com/timoore/vsgCs) - een bibliotheek voor het gebruiken van 3D Tiles en andere geospatiale inhoud binnen een Vulkan Scene Graph (VSG) applicatie

## Game engine, desktop GIS en 3D-modelleringsintegraties (Open source)

* [QGIS](https://www.qgis.org/) - Multi-platform desktop geografisch informatiesysteem (sinds versie 3.34).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Godot 4-extensie die Cesium 3D Tiles mogelijkheden integreert in Godot Engine
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - Cesium voor O3DE
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - [Blender](https://www.blender.org/) tool voor het tegelen van 3D-modellen.

## Tile creatie (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - C++-bibliotheek voor 3D Tiles streaming, glTF-verwerking.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - Tools en hulpprogramma's voor het converteren, optimaliseren, verwerken en analyseren van 3D Tiles-data.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - Javascript-tools voor glTF / GLB-conversie en optimalisatie.

## Tile creatie (Community)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - Lezen en schrijven van pnts en b3dm via API of CLI.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - Python-tool en -bibliotheek waarmee 3D Tiles tilesets uit diverse geometrische formaten kunnen worden gebouwd, zoals OBJ, GeoJSON, IFC of CityGML via 3dCityDB-databases.
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - Conversie van PostGIS 3D-geometrieën naar b3dm-tiles.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - mago 3DTiler converteert diverse ruimtelijke data naar OGC 3D Tiles.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - Converteert 3D stadsmodellen (CityGML) naar verschillende geospatiale formaten, inclusief 3D Tiles, MVT en GeoPackage.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - Converteert OBJ-bestanden naar OGC 3D tiles.
* [3dtiles](https://github.com/fanvanzh/3dtiles) - Converteert Osgb (OpenSceneGraph Binary), Esri Shapefile en Fbx-bestanden naar 3D Tiles.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - Converteert glTF-model naar Glb, b3dm of 3d tiles-formaat.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - Converteert van CityGML naar Cesium 3D Tiles.
* [vts23dtiles](https://github.com/melowntech/vts-tools) - Converteert VTS-tileset naar 3D Tileset.
* [3D City Database](https://www.3dcitydb.org/) - Geodatabank voor het opslaan, weergeven en beheren van virtuele 3D stadsmodellen.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → 3D Point Cloud Tiles.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - Converteer I3S naar 3D Tiles.
* [tyler](https://github.com/3DGI/tyler) - Tegelen van 3D stadsmodellen gecodeerd in CityJSON

## glTF-tools

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform ondersteunt het lezen, bewerken en schrijven van 3D-modellen in glTF 2.0-formaat.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - Bibliotheek en converter voor 40+ 3D-bestandsformaten naar glTF en meer ([bestandstypen](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Blender-exporteur](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Blender glTF 2.0 Exporteur.

## Terrein

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) is een formaat om terrein-meshes te coderen voor efficiënte client-side terreinweergave. Dergelijke bestanden worden ondersteund in Cesium en deck.gl.

Zie [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) voor meer bronnen.

## Demo-applicaties

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [Presentatie (Duits)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## Lesmateriaal / Howtos

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - mago3DTiler technische workshopmaterialen van FOSS4G-Asia (2024)

## Community

* [Discussies](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---