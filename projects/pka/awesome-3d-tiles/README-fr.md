# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> Une liste organisée de logiciels open source, bibliothèques, outils et ressources remarquables pour les 3D Tiles.

Contributions bienvenues. Ajoutez des liens via des [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) ou créez une [issue](https://github.com/pka/awesome-3d-tiles/issues) pour commencer une discussion.

[3D Tiles](https://github.com/CesiumGS/3d-tiles) est une spécification ouverte pour le partage, la visualisation, la fusion et l'interaction avec du contenu géospatial 3D massif et hétérogène sur des applications de bureau, web et mobiles.

3D Tiles est une [norme communautaire de l’OGC](https://www.ogc.org/standard/3dtiles/).

## Visionneuses

* [CesiumJS](https://github.com/CesiumGS/cesium) - Bibliothèque JavaScript pour créer des globes 3D et des cartes 2D dans un navigateur web.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - Visionneuse basée sur Cesium pour CityGML et 3D Tiles.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - Parseurs et encodeurs pour de nombreux formats majeurs 3D, géospatiaux et tabulaires.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - Framework alimenté par WebGL pour l’analyse exploratoire visuelle de grands ensembles de données.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - Rendu basé sur Three.js pour les 3D Tiles.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - Module de chargement [Three.js](https://threejs.org/) pour gérer les OGC 3D Tiles.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - Visionneuse 3DTiles pour three.js.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - Couche personnalisée Mapbox GL JS pour 3D Tiles.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - Composant [A-Frame](https://aframe.io/) utilisant 3D-Tiles.
* [iTowns](https://github.com/iTowns/itowns) - Framework JS/WebGL basé sur Three.js.
* [giro3d](https://gitlab.com/giro3d/giro3d) - Framework JS/WebGL basé sur Three.js (successeur de iTown).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - Visualisation de données urbaines. Framework pour créer des applications web pour visualiser et interagir avec des données urbaines 3D géospatiales (basé sur iTowns/Tree.js).
* [vsgCs](https://github.com/timoore/vsgCs) - Une bibliothèque pour utiliser les 3D Tiles et autres contenus géospatiaux dans une application Vulkan Scene Graph (VSG).

## Moteurs de jeu, SIG de bureau et intégrations d’outils de modélisation 3D (Open source)

* [QGIS](https://www.qgis.org/) - Système d’information géographique de bureau multiplateforme (depuis la version 3.34).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Extension Godot 4 qui intègre les capacités Cesium 3D Tiles dans Godot Engine.
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - Cesium pour O3DE.
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - Outil [Blender](https://www.blender.org/) pour tuiler les modèles 3D.

## Création de tuiles (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - Bibliothèque C++ pour le streaming de 3D Tiles et le traitement glTF.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - Outils et utilitaires pour convertir, optimiser, traiter et analyser des données 3D Tiles.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - Outils JavaScript pour la conversion et l’optimisation glTF / GLB.

## Création de tuiles (Communauté)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - Lire et écrire des fichiers pnts et b3dm via API ou CLI.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - Outil et bibliothèque Python permettant de générer des jeux de tuiles 3D Tiles à partir de divers formats géométriques (ex. OBJ, GeoJSON, IFC ou CityGML via des bases de données 3dCityDB).
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - Conversion des géométries 3D PostGIS vers des tuiles b3dm.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - mago 3DTiler convertit diverses données spatiales en OGC 3D Tiles.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - Conversion de modèles 3D urbains (CityGML) en divers formats géospatiaux, y compris 3D Tiles, MVT et GeoPackage.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - Convertit les fichiers OBJ en tuiles 3D OGC.
* [3dtiles](https://github.com/fanvanzh/3dtiles) - Convertit les fichiers Osgb (OpenSceneGraph Binary), Esri Shapefile et Fbx en 3D Tiles.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - Convertit un modèle glTF en Glb, b3dm ou format 3d tiles.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - Conversion de CityGML vers Cesium 3D Tiles.
* [vts23dtiles](https://github.com/melowntech/vts-tools) - Convertit un jeu de tuiles VTS en jeu de tuiles 3D.
* [3D City Database](https://www.3dcitydb.org/) - Base de données géo pour stocker, représenter et gérer des modèles de villes 3D virtuelles.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → Tuiles de nuage de points 3D.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - Convertit I3S en 3D Tiles.
* [tyler](https://github.com/3DGI/tyler) - Tuilage de modèles 3D urbains encodés en CityJSON.

## Outils glTF

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform prend en charge la lecture, l’édition et l’écriture de modèles 3D au format glTF 2.0.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - Bibliothèque et convertisseur pour plus de 40 formats de fichiers 3D vers glTF et plus ([formats de fichiers](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Exportateur glTF 2.0 pour Blender.

## Terrain

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) est un format pour encoder des maillages de terrain pour un rendu efficace côté client. Ces fichiers sont pris en charge dans Cesium et deck.gl.

Voir [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) pour plus de ressources.

## Applications démo

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [Présentation (allemand)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## Matériel d’apprentissage / Tutoriels

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [Atelier mago3DTiler](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - Matériel technique de l’atelier mago3DTiler du FOSS4G-Asia (2024).

## Communauté

* [Discussions](https://github.com/pka/awesome-3d-tiles/discussions)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---