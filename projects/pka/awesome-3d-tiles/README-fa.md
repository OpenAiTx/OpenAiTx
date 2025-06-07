# 3D Tiles شگفت‌انگیز [![awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)

> یک فهرست منتخب از نرم‌افزارهای متن‌باز، کتابخانه‌ها، ابزارها و منابع عالی برای 3D Tiles.

مشارکت خوش‌آمدید. لینک‌ها را از طریق [pull requests](https://github.com/pka/awesome-3d-tiles/pulls) اضافه کنید یا یک [issue](https://github.com/pka/awesome-3d-tiles/issues) ایجاد کنید تا بحثی را آغاز نمایید.

[3D Tiles](https://github.com/CesiumGS/3d-tiles) یک مشخصات باز برای به‌اشتراک‌گذاری، بصری‌سازی، ترکیب و تعامل با محتوای عظیم و ناهمگون سه‌بعدی مکانی در برنامه‌های دسکتاپ، وب و موبایل است.

3D Tiles یک [استاندارد جامعه OGC](https://www.ogc.org/standard/3dtiles/) است.

## بیننده‌ها

* [CesiumJS](https://github.com/CesiumGS/cesium) - کتابخانه جاوااسکریپت برای ایجاد کره‌های سه‌بعدی و نقشه‌های دوبعدی در مرورگر وب.
* [3DCityDB-Web-Map-Client](https://github.com/3dcitydb/3dcitydb-web-map) - بیننده مبتنی بر Cesium برای CityGML و 3D Tiles.
* [loaders.gl](https://loaders.gl/docs/specifications/category-3d-tiles) - تجزیه‌کننده‌ها و رمزگذارها برای بسیاری از فرمت‌های عمده سه‌بعدی، مکانی و جدولی.
* [deck.gl](https://deck.gl/docs/api-reference/geo-layers/tile-3d-layer) - چهارچوب مبتنی بر WebGL برای تحلیل داده‌های بزرگ به صورت بصری.
* [3d-tiles-renderer](https://github.com/NASA-AMMOS/3DTilesRendererJS) - رندرکننده مبتنی بر Three.js برای 3D Tiles.
* [three-loader-3dtiles](https://github.com/nytimes/three-loader-3dtiles) - ماژول بارگذار [Three.js](https://threejs.org/) برای مدیریت OGC 3D Tiles.
* [threedtiles](https://github.com/ebeaufay/3DTilesViewer) - بیننده 3DTiles برای three.js.
* [mapbox-3dtiles](https://github.com/Geodan/mapbox-3dtiles) - لایه سفارشی Mapbox GL JS برای 3D Tiles.
* [A-Frame component](https://github.com/nytimes/aframe-loader-3dtiles-component) - مولفه [A-Frame](https://aframe.io/) با استفاده از 3D-Tiles.
* [iTowns](https://github.com/iTowns/itowns) - چهارچوب JS/WebGL مبتنی بر Three.js.
* [giro3d](https://gitlab.com/giro3d/giro3d) - چهارچوب JS/WebGL مبتنی بر Three.js (جانشین iTown).
* [UD-Viz](https://github.com/VCityTeam/UD-Viz) - مصورسازی داده شهری. چهارچوبی برای ایجاد برنامه‌های وب جهت نمایش و تعامل با داده‌های سه‌بعدی شهری (مبتنی بر iTowns/Tree.js).
* [vsgCs](https://github.com/timoore/vsgCs) - کتابخانه‌ای برای استفاده از 3D Tiles و محتوای مکانی دیگر در برنامه‌های Vulkan Scene Graph (VSG)

## ادغام با موتور بازی، GIS دسکتاپ و ابزارهای مدل‌سازی سه‌بعدی (متن‌باز)

* [QGIS](https://www.qgis.org/) - سامانه اطلاعات جغرافیایی دسکتاپ چندسکویی (از نسخه 3.34).
* [3D Tiles for Godot](https://github.com/Battle-Road-Labs/3D-Tiles-For-Godot) - افزونه Godot 4 که قابلیت‌های Cesium 3D Tiles را به موتور Godot اضافه می‌کند.
* [Open 3D Engine (O3DE)](https://github.com/CesiumGS/cesium-o3de) - Cesium برای O3DE
* [blender-3d-tiler](https://gitee.com/cesium_processing/blender-3d-tiler) - ابزار [Blender](https://www.blender.org/) برای تکه‌بندی مدل‌های سه‌بعدی.

## ایجاد تایل (Cesium GS Inc)

* Cesium Ion (سرویس SaaS)
* [CDB to 3D Tiles](https://github.com/CesiumGS/cdb-to-3dtiles) - OGC CDB → 3D Tiles.
* [Cesium Native](https://github.com/CesiumGS/cesium-native) - کتابخانه ++C برای پخش جریانی 3D Tiles، پردازش glTF.
* [3D Tiles Tools](https://github.com/CesiumGS/3d-tiles-tools) - ابزارها و امکانات تبدیل، بهینه‌سازی، پردازش و تحلیل داده‌های 3D Tiles.
* [glTF Pipeline](https://github.com/CesiumGS/gltf-pipeline) - ابزارهای جاوااسکریپت برای تبدیل و بهینه‌سازی glTF / GLB.

## ایجاد تایل (جامعه)

* [py3dtiles](https://gitlab.com/py3dtiles/py3dtiles) - خواندن و نوشتن pnts و b3dm از طریق API یا CLI.
* [Python 3DTiles Tilers](https://github.com/VCityTeam/py3dtilers) - ابزار و کتابخانه پایتون برای ساخت مجموعه‌تایل‌های 3D Tiles از فرمت‌های مختلف هندسی مانند OBJ، GeoJSON، IFC یا CityGML با استفاده از پایگاه داده‌های 3dCityDB.
* [pg2b3dm](https://github.com/Geodan/pg2b3dm) - تبدیل هندسه‌های سه‌بعدی PostGIS به تایل‌های b3dm.
* [mago 3DTiler](https://github.com/Gaia3D/mago-3d-tiler) - mago 3DTiler داده‌های مکانی مختلف را به OGC 3D Tiles تبدیل می‌کند.
* [PLATEAU GIS Converter](https://github.com/MIERUNE/plateau-gis-converter) - تبدیل مدل‌های شهری سه‌بعدی (CityGML) به فرمت‌های مختلف مکانی، شامل 3D Tiles، MVT و GeoPackage.
* [Obj2Tiles](https://github.com/OpenDroneMap/Obj2Tiles) - تبدیل فایل‌های OBJ به OGC 3D tiles.
* [3dtiles](https://github.com/fanvanzh/3dtiles) - تبدیل فایل‌های Osgb(OpenSceneGraph Binary)، Esri Shapefile و Fbx به 3D Tiles.
* [gltf-to-3d-tiles](https://github.com/xuzhusheng/gltf-to-3d-tiles) - تبدیل مدل glTF به فرمت Glb، b3dm یا 3d tiles.
* [citygml-to-3dtiles](https://github.com/njam/citygml-to-3dtiles) - تبدیل از CityGML به Cesium 3D Tiles.
* [vts23dtiles](https://github.com/melowntech/vts-tools) - تبدیل مجموعه‌تایل‌های VTS به 3D Tileset.
* [3D City Database](https://www.3dcitydb.org/) - پایگاه داده مکانی برای ذخیره، نمایش و مدیریت مدل‌های سه‌بعدی مجازی شهری.
* [Cesium Point Cloud Generator](https://github.com/tum-gis/cesium-point-cloud-generator) - XYZ → تایل‌های ابر نقطه‌ای سه‌بعدی.
* [loaders.gl tile-converter](https://loaders.gl/docs/modules/tile-converter/cli-reference/tile-converter) - تبدیل I3S به 3D Tiles.
* [tyler](https://github.com/3DGI/tyler) - تکه‌بندی مدل‌های سه‌بعدی شهری کدگذاری شده در CityJSON

## ابزارهای glTF

* [glTF-Transform](https://gltf-transform.donmccurdy.com/cli.html) - glTF-Transform از خواندن، ویرایش و نوشتن مدل‌های سه‌بعدی در فرمت glTF 2.0 پشتیبانی می‌کند.
* [Open Asset Import Library (assimp)](https://github.com/assimp/assimp) - کتابخانه و تبدیل‌کننده برای بیش از 40 فرمت فایل سه‌بعدی به glTF و سایر فرمت‌ها ([فرمت‌های فایل](https://github.com/assimp/assimp/blob/master/doc/Fileformats.md)).
* [Blender exporter](https://docs.blender.org/manual/en/latest/addons/import_export/scene_gltf2.html#extensions) - صادرکننده glTF 2.0 برای Blender.

## زمین (Terrain)

[Quantized Mesh](https://github.com/CesiumGS/quantized-mesh) فرمتی برای کدگذاری مش‌های زمین برای رندرینگ کارآمد سمت کاربر است. چنین فایل‌هایی در Cesium و deck.gl پشتیبانی می‌شوند.

برای منابع بیشتر به [awesome-quantized-mesh-tiles](https://github.com/bertt/awesome-quantized-mesh-tiles#readme) مراجعه کنید.

## برنامه‌های نمایشی

* [3D BAG](https://3dbag.nl/en/viewer)
* [Berlin 3D](https://berlin.virtualcitymap.de/#) | [Bremen 3D](https://bremen.virtualcitymap.de/#/) | [Helsinki 3D](https://kartta.hel.fi/3d/#/) | [Soest 3D](https://soest.virtualcitymap.de/#/)
* [basemap.de](https://basemap.de/beta/)
* [UnrealEngineDigitalTwinLowerSaxony](https://github.com/JulianMuellerLgln/UnrealEngineDigitalTwinLowerSaxony) - [ارائه (آلمانی)](https://pretalx.com/fossgis2025/talk/8P79JV/)
* [Google Photorealistic 3D Tiles](https://developers.google.com/maps/documentation/tile/3d-tiles)

## منابع آموزشی / راهنماها

* [Rendering the World with 3D Tiles](https://cesium.com/learn/presentations/#rendering-the-world-with-3d-tiles).
* [کارگاه mago3DTiler](https://github.com/Gaia3D/mago3d-doc/blob/main/foss4g/Table_Of_Contents_En.md) - مطالب کارگاه فنی mago3DTiler از FOSS4G-Asia (2024)

## جامعه

* [بحث‌ها](https://github.com/pka/awesome-3d-tiles/discussions)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---