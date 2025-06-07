# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> Una lista seleccionada de software de código abierto, bibliotecas, herramientas y recursos impresionantes para 3D tiles.

Contribuciones bienvenidas. Agrega enlaces a través de [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) o crea un [issue](https://github.com/pka/awesome-3d-tiles/issues) para iniciar una discusión.

[3D Tiles](https://github.com/CesiumGS/3d-tiles) es una especificación abierta para compartir, visualizar, fusionar e interactuar con contenido geoespacial 3D masivo y heterogéneo en aplicaciones de escritorio, web y móviles.

3D Tiles es un [estándar comunitario de OGC](https://www.ogc.org/standard/3dtiles/).

## Visualizadores

* [CesiumJS](https://github.com/CesiumGS/cesium) - Biblioteca JavaScript para crear globos terráqueos 3D y mapas 2D en un navegador web.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - Visualizador basado en Cesium para CityGML y 3D Tiles.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - Parsers y codificadores para muchos de los principales formatos 3D, geoespaciales y tabulares.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - Framework potenciado por WebGL para análisis visual exploratorio de grandes conjuntos de datos.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - Renderizador basado en Three.js para 3D Tiles.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - Módulo de carga para [Three.js](https://threejs.org/) para manejar OGC 3D Tiles.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - Visualizador de 3DTiles para three.js.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - Capa personalizada de Mapbox GL JS para 3D Tiles.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - Componente para [A-Frame](https://aframe.io/) usando 3D-Tiles.
* [iTowns](https://github.com/iTowns/itowns) - Framework JS/WebGL basado en Three.js.
* [giro3d](https://gitlab.com/giro3d/giro3d) - Framework JS/WebGL basado en Three.js (sucesor de iTown).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - Visualización de Datos Urbanos. Framework para crear aplicaciones web para visualizar e interactuar con datos geoespaciales urbanos 3D (basado en iTowns/Three.js).
* [vsgCs](https://github.com/timoore/vsgCs) - Biblioteca para usar 3D Tiles y otros contenidos geoespaciales dentro de una aplicación Vulkan Scene Graph (VSG).

## Integraciones en motores de juegos, SIG de escritorio y herramientas de modelado 3D (Código abierto)

* [QGIS](https://www.qgis.org/) - Sistema de información geográfica de escritorio multiplataforma (desde la versión 3.34).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Extensión para Godot 4 que integra capacidades de Cesium 3D Tiles en el motor Godot.
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - Cesium para O3DE.
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - Herramienta para [Blender](https://www.blender.org/) para dividir modelos 3D en tiles.

## Creación de tiles (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - Biblioteca C++ para streaming de 3D Tiles y procesamiento de glTF.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - Herramientas y utilidades para convertir, optimizar, procesar y analizar datos de 3D Tiles.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - Herramientas en JavaScript para conversión y optimización de glTF / GLB.

## Creación de tiles (Comunidad)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - Leer y escribir pnts y b3dm vía API o CLI.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - Herramienta y biblioteca Python que permite construir conjuntos de tiles 3D Tiles a partir de varios formatos geométricos, por ejemplo, OBJ, GeoJSON, IFC o CityGML a través de bases de datos 3dCityDB.
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - Conversión de geometrías 3D de PostGIS a tiles b3dm.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - mago 3DTiler convierte varios datos espaciales en OGC 3D Tiles.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - Convierte modelos de ciudad 3D (CityGML) en varios formatos geoespaciales, incluidos 3D Tiles, MVT y GeoPackage.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - Convierte archivos OBJ a OGC 3D tiles.
* [3dtiles](https://github.com/fanvanzh/3dtiles) - Convierte archivos Osgb(OpenSceneGraph Binary), Esri Shapefile y Fbx en 3D Tiles.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - Convierte modelos glTF a formato Glb, b3dm o 3d tiles.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - Convierte de CityGML a Cesium 3D Tiles.
* [vts23dtiles](https://github.com/melowntech/vts-tools) - Convierte un tileset VTS en un 3D Tileset.
* [3D City Database](https://www.3dcitydb.org/) - Base de datos geoespacial para almacenar, representar y gestionar modelos virtuales de ciudades 3D.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → Tiles de Nube de Puntos 3D.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - Convierte I3S a 3D Tiles.
* [tyler](https://github.com/3DGI/tyler) - División en tiles de modelos de ciudad 3D codificados en CityJSON.

## Herramientas glTF

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform permite leer, editar y escribir modelos 3D en formato glTF 2.0.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - Biblioteca y conversor para más de 40 formatos de archivos 3D hacia glTF y otros ([formatos de archivo](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Exportador glTF 2.0 para Blender.

## Terreno

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) es un formato para codificar mallas de terreno para renderizado eficiente de terreno en el cliente. Dichos archivos son soportados en Cesium y deck.gl.

Consulta [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) para más recursos.

## Aplicaciones de demostración

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [Presentación (alemán)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## Material de aprendizaje / Howtos

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - Materiales técnicos del taller mago3DTiler de FOSS4G-Asia (2024)

## Comunidad

* [Discusiones](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---