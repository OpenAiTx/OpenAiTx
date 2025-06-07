# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> Una lista curata di eccellente software open source, librerie, strumenti e risorse per 3D Tiles.

Contributi benvenuti. Aggiungi link tramite [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) o crea una [issue](https://github.com/pka/awesome-3d-tiles/issues) per avviare una discussione.

[3D Tiles](https://github.com/CesiumGS/3d-tiles) è una specifica aperta per la condivisione, visualizzazione, fusione e interazione con contenuti geospaziali 3D eterogenei e massivi su applicazioni desktop, web e mobile.

3D Tiles è uno [standard di comunità OGC](https://www.ogc.org/standard/3dtiles/).

## Visualizzatori

* [CesiumJS](https://github.com/CesiumGS/cesium) - Libreria JavaScript per creare globi 3D e mappe 2D in un browser web.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - Visualizzatore basato su Cesium per CityGML e 3D Tiles.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - Parser ed encoder per numerosi principali formati 3D, geospaziali e tabellari.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - Framework WebGL per l'analisi esplorativa di grandi set di dati.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - Renderer basato su Three.js per 3D Tiles.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - Modulo loader [Three.js](https://threejs.org/) per gestire OGC 3D Tiles.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - Visualizzatore 3DTiles per three.js.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - Layer personalizzato Mapbox GL JS per 3D Tiles.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - Componente [A-Frame](https://aframe.io/) che utilizza 3D-Tiles.
* [iTowns](https://github.com/iTowns/itowns) - Framework JS/WebGL basato su Three.js.
* [giro3d](https://gitlab.com/giro3d/giro3d) - Framework JS/WebGL basato su Three.js (successore di iTown).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - Visualizzazione di dati urbani. Framework per creare applicazioni web per visualizzare e interagire con dati urbani geospaziali 3D (basato su iTowns/Tree.js).
* [vsgCs](https://github.com/timoore/vsgCs) - Libreria per utilizzare 3D Tiles e altri contenuti geospaziali all'interno di una applicazione Vulkan Scene Graph (VSG).

## Integrazioni con game engine, GIS desktop e strumenti di modellazione 3D (Open source)

* [QGIS](https://www.qgis.org/) - Sistema informativo geografico desktop multipiattaforma (dalla versione 3.34).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Estensione Godot 4 che integra le capacità Cesium 3D Tiles in Godot Engine.
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - Cesium per O3DE.
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - Strumento [Blender](https://www.blender.org/) per la suddivisione in tile di modelli 3D.

## Creazione tile (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - Libreria C++ per streaming 3D Tiles, elaborazione glTF.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - Strumenti e utilità per convertire, ottimizzare, processare e analizzare dati 3D Tiles.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - Strumenti JavaScript per conversione e ottimizzazione glTF / GLB.

## Creazione tile (Comunità)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - Leggi e scrivi pnts e b3dm via API o CLI.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - Strumento e libreria Python che consente di creare tileset 3D Tiles da vari formati geometrici, ad esempio OBJ, GeoJSON, IFC o CityGML tramite database 3dCityDB.
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - Conversione di geometrie PostGIS 3D in tile b3dm.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - mago 3DTiler converte diversi dati spaziali in OGC 3D Tiles.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - Converte modelli di città 3D (CityGML) in vari formati geospaziali, inclusi 3D Tiles, MVT e GeoPackage.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - Converte file OBJ in OGC 3D tiles.
* [3dtiles](https://github.com/fanvanzh/3dtiles) - Converte Osgb (OpenSceneGraph Binary), Esri Shapefile e file Fbx in 3D Tiles.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - Converte modelli glTF in formato Glb, b3dm o 3d tiles.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - Conversione da CityGML a Cesium 3D Tiles.
* [vts23dtiles](https://github.com/melowntech/vts-tools) - Converte VTS tileset in tileset 3D Tiles.
* [3D City Database](https://www.3dcitydb.org/) - Geo database per archiviare, rappresentare e gestire modelli virtuali 3D di città.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → 3D Point Cloud Tiles.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - Converte I3S in 3D Tiles.
* [tyler](https://github.com/3DGI/tyler) - Suddivisione in tile di modelli 3D di città codificati in CityJSON.

## Strumenti glTF

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform supporta lettura, modifica e scrittura di modelli 3D in formato glTF 2.0.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - Libreria e convertitore per oltre 40 formati di file 3D in glTF e altri ([formati supportati](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Esportatore Blender glTF 2.0.

## Terreno

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) è un formato per codificare mesh di terreno per un efficiente rendering lato client. Tali file sono supportati in Cesium e deck.gl.

Consulta [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) per ulteriori risorse.

## Applicazioni demo

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [Presentazione (tedesco)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## Materiale didattico / Howto

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - Materiale tecnico del workshop mago3DTiler da FOSS4G-Asia (2024)

## Comunità

* [Discussioni](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---