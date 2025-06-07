# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> Eine kuratierte Liste großartiger Open-Source-Software, Bibliotheken, Tools und Ressourcen für 3D Tiles.

Beiträge sind willkommen. Fügen Sie Links über [Pull Requests](https://github.com/pka/awesome-3d-tiles/pulls) hinzu oder erstellen Sie ein [Issue](https://github.com/pka/awesome-3d-tiles/issues), um eine Diskussion zu beginnen.

[3D Tiles](https://github.com/CesiumGS/3d-tiles) ist eine offene Spezifikation zum Teilen, Visualisieren, Zusammenführen und Interagieren mit großen, heterogenen 3D-Geodaten auf Desktop-, Web- und mobilen Anwendungen.

3D Tiles ist ein [OGC Community Standard](https://www.ogc.org/standard/3dtiles/).

## Viewer

* [CesiumJS](https://github.com/CesiumGS/cesium) – JavaScript-Bibliothek zur Erstellung von 3D-Globen und 2D-Karten im Webbrowser.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) – Cesium-basierter Viewer für CityGML und 3D Tiles.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) – Parser und Encoder für viele gängige 3D-, Geodaten- und Tabellarformate.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) – WebGL-basiertes Framework zur explorativen Datenanalyse großer Datensätze.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) – Three.js-basierter Renderer für 3D Tiles.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) – [Three.js](https://threejs.org/) Loader-Modul zur Verarbeitung von OGC 3D Tiles.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) – 3DTiles-Viewer für three.js.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) – Mapbox GL JS Custom Layer für 3D Tiles.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) – [A-Frame](https://aframe.io/) Komponente mit 3D-Tiles-Unterstützung.
* [iTowns](https://github.com/iTowns/itowns) – Three.js-basiertes JS/WebGL-Framework.
* [giro3d](https://gitlab.com/giro3d/giro3d) – Three.js-basiertes JS/WebGL-Framework (Nachfolger von iTown).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) – Urban Data Visualization. Framework zur Erstellung von Webanwendungen zur Visualisierung und Interaktion mit geospatialen 3D-Stadtdaten (basiert auf iTowns/Three.js).
* [vsgCs](https://github.com/timoore/vsgCs) – Bibliothek zur Nutzung von 3D Tiles und anderen Geodaten innerhalb einer Vulkan Scene Graph (VSG) Anwendung.

## Game-Engine-, Desktop-GIS- und 3D-Modellierungs-Tool-Integrationen (Open Source)

* [QGIS](https://www.qgis.org/) – Multi-Plattform Desktop-Geoinformationssystem (seit Version 3.34).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) – Godot-4-Erweiterung, die Cesium 3D Tiles-Funktionalität in die Godot Engine integriert.
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) – Cesium für O3DE.
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) – [Blender](https://www.blender.org/) Tool zum Tiling von 3D-Modellen.

## Tile-Erstellung (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) – OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) – C++-Bibliothek für 3D Tiles Streaming, glTF-Verarbeitung.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) – Tools und Utilities zum Konvertieren, Optimieren, Verarbeiten und Analysieren von 3D Tiles Daten.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) – JavaScript-Tools zur glTF / GLB-Konvertierung und -Optimierung.

## Tile-Erstellung (Community)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) – Lesen und Schreiben von pnts und b3dm via API oder CLI.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) – Python-Tool und -Bibliothek zum Erstellen von 3D-Tiles-Tilesets aus verschiedenen Geometrie-Formaten (z.B. OBJ, GeoJSON, IFC oder CityGML über 3dCityDB-Datenbanken).
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) – Konvertierung von PostGIS 3D-Geometrien zu b3dm-Tiles.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) – mago 3DTiler konvertiert verschiedene räumliche Daten in OGC 3D Tiles.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) – Konvertiert 3D-Stadtmodelle (CityGML) in verschiedene Geodatenformate, darunter 3D Tiles, MVT und GeoPackage.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) – Konvertiert OBJ-Dateien in OGC 3D Tiles.
* [3dtiles](https://github.com/fanvanzh/3dtiles) – Konvertiert Osgb (OpenSceneGraph Binary), Esri Shapefile und Fbx-Dateien in 3D Tiles.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) – Konvertiert glTF-Modelle in Glb-, b3dm- oder 3D-Tiles-Format.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) – Konvertiert CityGML zu Cesium 3D Tiles.
* [vts23dtiles](https://github.com/melowntech/vts-tools) – Konvertiert VTS-Tilesets in 3D Tilesets.
* [3D City Database](https://www.3dcitydb.org/) – Geo-Datenbank zum Speichern, Darstellen und Verwalten virtueller 3D-Stadtmodelle.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) – XYZ → 3D Point Cloud Tiles.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) – Konvertiert I3S zu 3D Tiles.
* [tyler](https://github.com/3DGI/tyler) – Tiling von 3D-Stadtmodellen im CityJSON-Format.

## glTF-Tools

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) – glTF-Transform unterstützt das Lesen, Bearbeiten und Schreiben von 3D-Modellen im glTF-2.0-Format.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) – Bibliothek und Konverter für 40+ 3D-Dateiformate in glTF und mehr ([Dateiformate](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Blender Exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) – Blender glTF-2.0-Exporter.

## Terrain

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) ist ein Format zur effizienten Kodierung von Terrain-Meshes für die clientseitige Darstellung. Solche Dateien werden in Cesium und deck.gl unterstützt.

Siehe [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) für weitere Ressourcen.

## Demo-Anwendungen

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) – [Präsentation (deutsch)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## Lernmaterial / Howtos

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) – mago3DTiler technische Workshop-Materialien von der FOSS4G-Asia (2024)

## Community

* [Diskussionen](https://github.com/pka/awesome-3d-tiles/discussions)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---