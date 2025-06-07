# Awesome 3D Tiles [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> Uma lista curada de softwares open source incríveis, bibliotecas, ferramentas e recursos para 3D Tiles.

Contribuições são bem-vindas. Adicione links através de [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) ou crie uma [issue](https://github.com/pka/awesome-3d-tiles/issues) para iniciar uma discussão.

[3D Tiles](https://github.com/CesiumGS/3d-tiles) é uma especificação aberta para compartilhar, visualizar, fundir e interagir com grandes volumes de conteúdo geoespacial 3D heterogêneo em aplicativos desktop, web e mobile.

3D Tiles é um [padrão comunitário OGC](https://www.ogc.org/standard/3dtiles/).

## Visualizadores

* [CesiumJS](https://github.com/CesiumGS/cesium) - Biblioteca JavaScript para criar globos 3D e mapas 2D em navegadores web.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - Visualizador baseado em Cesium para CityGML e 3D Tiles.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - Parsers e encoders para diversos formatos principais 3D, geoespaciais e tabulares.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - Framework baseado em WebGL para análise visual exploratória de grandes conjuntos de dados.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - Renderizador para 3D Tiles baseado em Three.js.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - Módulo loader para [Three.js](https://threejs.org/) para lidar com OGC 3D Tiles.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - Visualizador de 3DTiles para three.js.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - Camada personalizada do Mapbox GL JS para 3D Tiles.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - Componente para [A-Frame](https://aframe.io/) usando 3D Tiles.
* [iTowns](https://github.com/iTowns/itowns) - Framework JS/WebGL baseado em Three.js.
* [giro3d](https://gitlab.com/giro3d/giro3d) - Framework JS/WebGL baseado em Three.js (sucessor do iTown).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - Visualização de Dados Urbanos. Framework para criar aplicações web para visualização e interação com dados urbanos geoespaciais 3D (baseado em iTowns/Three.js).
* [vsgCs](https://github.com/timoore/vsgCs) - Biblioteca para usar 3D Tiles e outros conteúdos geoespaciais em aplicações Vulkan Scene Graph (VSG).

## Integrações com engines de jogos, GIS desktop e ferramentas de modelagem 3D (Open source)

* [QGIS](https://www.qgis.org/) - Sistema de informação geográfica desktop multiplataforma (desde a versão 3.34).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - Extensão para Godot 4 que integra capacidades do Cesium 3D Tiles ao Godot Engine.
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - Cesium para O3DE.
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - Ferramenta para [Blender](https://www.blender.org/) para tiling de modelos 3D.

## Criação de Tiles (Cesium GS Inc)

* Cesium Ion (SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - Biblioteca C++ para streaming de 3D Tiles e processamento de glTF.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - Ferramentas e utilitários para conversão, otimização, processamento e análise de dados 3D Tiles.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - Ferramentas Javascript para conversão e otimização glTF / GLB.

## Criação de Tiles (Comunidade)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - Leitura e escrita de pnts e b3dm via API ou CLI.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - Ferramenta e biblioteca Python para construir tilesets 3D Tiles a partir de vários formatos geométricos, como OBJ, GeoJSON, IFC ou CityGML via bancos de dados 3dCityDB.
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - Conversão de geometrias 3D do PostGIS para tiles b3dm.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - Converte vários dados espaciais em OGC 3D Tiles.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - Converte modelos 3D de cidades (CityGML) para vários formatos geoespaciais, incluindo 3D Tiles, MVT e GeoPackage.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - Converte arquivos OBJ para OGC 3D Tiles.
* [3dtiles](https://github.com/fanvanzh/3dtiles) - Converte arquivos Osgb (OpenSceneGraph Binary), Esri Shapefile e Fbx em 3D Tiles.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - Converte modelos glTF para Glb, b3dm ou formato 3D Tiles.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - Conversão de CityGML para Cesium 3D Tiles.
* [vts23dtiles](https://github.com/melowntech/vts-tools) - Converte tilesets VTS em tilesets 3D Tiles.
* [3D City Database](https://www.3dcitydb.org/) - Banco de dados geoespacial para armazenar, representar e gerenciar modelos virtuais 3D de cidades.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → Tiles de nuvem de pontos 3D.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - Converte I3S para 3D Tiles.
* [tyler](https://github.com/3DGI/tyler) - Tiling de modelos de cidades 3D codificados em CityJSON.

## Ferramentas glTF

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - Suporta leitura, edição e escrita de modelos 3D em formato glTF 2.0.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - Biblioteca e conversor para mais de 40 formatos de arquivos 3D para glTF e outros ([formatos suportados](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Exportador do Blender](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - Exportador glTF 2.0 do Blender.

## Terreno

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) é um formato para codificar malhas de terreno para renderização eficiente de terreno no lado do cliente. Arquivos desse tipo são suportados no Cesium e deck.gl.

Veja [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) para mais recursos.

## Aplicações de demonstração

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [Apresentação (alemão)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## Material de aprendizado / Tutoriais

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [mago3DTiler workshop](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - Materiais técnicos do mago3DTiler workshop do FOSS4G-Asia (2024)

## Comunidade

* [Discussions](https://github.com/pka/awesome-3d-tiles/discussions)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---