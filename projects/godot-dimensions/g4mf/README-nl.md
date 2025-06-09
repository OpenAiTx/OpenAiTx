# Good 4D Model Format (G4MF)

Good 4D Model Format, of kortweg G4MF, is een JSON-gebaseerd, op 4D gericht multidimensionaal modelformaat geïnspireerd door Khronos’ [glTF™](https://github.com/KhronosGroup/glTF), dat overdracht, uitwisseling en interoperabiliteit van content met hogere dimensies tussen applicaties mogelijk maakt.

G4MF-bestanden kunnen de volgende types hebben:
- `.g4tf` staat voor "Good 4D model Text File". Dit bevat de JSON-data in een puur tekst-gebaseerd UTF-8 formaat, waarbij binaire blobs als Base64 binnen een string zijn gecodeerd, of als externe bestanden worden opgeslagen. Geldige G4TF-bestanden bevatten geen BOMs of carriage returns.
- `.g4b` staat voor "Good 4D model Binary". Dit pakt de binaire data dicht voor efficiënte opslag, ten koste van het moeilijker inspecteren in een teksteditor.

Lees de specificatie hier: [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md).

## Verschillen met glTF™

G4MF is geïnspireerd door glTF™, en heeft een vergelijkbare algemene structuur, maar kent veel verschillen.

Belangrijkste verschillen:

- G4MF is een multidimensionaal, op 4D gericht formaat, terwijl glTF™ een 3D-formaat is. (vanzelfsprekend, maar voor de duidelijkheid vermeld)
- glTF™ is ontworpen als een GPU-klaar last-mile formaat, waarbij data is opgeslagen op een manier die direct in OpenGL™ of Vulkan™ geladen kan worden. Aangezien grafische API’s geen 4D-, 5D-, 6D-, enzovoorts modellen ondersteunen, heeft dat doel geen zin voor G4MF. In plaats daarvan is G4MF primair ontworpen als een mens-leesbaar uitwisselingsformaat.
- G4MF-mesh-vertices worden typisch op een gededupliceerde manier opgeslagen en door edges en cellen gerefereerd. glTF™ slaat elke driehoek met unieke vertices op, wat het direct laden naar de GPU vergemakkelijkt, maar leidt tot verwarring over dubbele vertices. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF staat slechts één scene per bestand toe met één root-node, terwijl glTF™ meerdere scenes en meerdere root-nodes toestaat. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- G4MF binary gebruikt een 64-bits unsigned integer voor de grootte van `.g4b`-bestanden en -chunks, in plaats van een 32-bits unsigned integer zoals `.glb`, waardoor bestanden groter dan 4 GiB mogelijk zijn. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF is een geheel nieuw formaat, terwijl glTF™ een volwassen industriestandaard is. Daarom raden wij aan glTF™ te gebruiken voor 3D-modellen, niet 3D G4MF-bestanden.

Daarnaast zijn er veel detailverschillen tussen G4MF en glTF™:

- G4MF voegt een nieuw vereist integer-key `"dimension"` toe aan `"asset"`, die MOET worden gedefinieerd, anders is het bestand ongeldig. Dit betekent dat 4D-modellen `{ "asset": { "dimension": 4 } }` in hun JSON-data MOETEN hebben.
- G4MF asset-header bevat de arrays `"extensionsUsed"` en `"extensionsRequired"`. In glTF™ zijn deze gedefinieerd in het top-level JSON-object.
- G4MF node-transformaties gebruiken een combinatie van `"position"` en ofwel `"basis"` of `"rotor"`+`"scale"`, terwijl glTF™ `"translation"`+`"rotation"`+`"scale"` of een 4x4 `"matrix"` gebruikt. Beide formaten staan alleen een lineaire transformatie toe, wat betekent dat de glTF™ `"matrix"`-eigenschap altijd (0, 0, 0, 1) waarden in de laatste rij heeft. Deze laatste rij is nuttig voor verzending van data naar de GPU, maar is niet betekenisvol voor uitwisseling, daarom is deze niet aanwezig in G4MF.
- G4MF node `"scale"` staat geen negatieve schalen toe, terwijl glTF™ dit wel doet. G4MF vereist dat `"basis"` wordt gebruikt voor flips/reflecties, indien nodig.
- G4MF node `"scale"` staat een enkele waarde toe die een uniforme schaal aangeeft, nuttig voor compactheid, vooral bij zeer hoge dimensies. glTF™ `"scale"` is altijd een 3D-vector.
- G4MF nodes hebben een `"visible"` boolean, waarmee de glTF™ extensie `KHR_node_visibility` in de basis-specificatie is opgenomen. https://github.com/KhronosGroup/glTF/pull/2410
- G4MF meshes hebben `"surfaces"`, wat een gebruiksvriendelijkere naam is. glTF™ meshes hebben `"primitives"`, de terminologie die door OpenGL™ wordt gebruikt. https://www.khronos.org/opengl/wiki/primitive
- G4MF mesh-surfaces definiëren expliciet vertices, edges en cells op het oppervlak. glTF™ mesh-primitives definiëren deze binnen `"attributes"` en `"mode"`.
- G4MF mesh-surfaces kunnen een `"polytopeCells"` boolean hebben, waarmee de glTF™ extensie `FB_ngon_encoding` in de basis-specificatie is opgenomen. https://github.com/KhronosGroup/glTF/pull/1620
- G4MF-materialen hebben kanalen die het glTF™-concept van gescheiden materiaaleigenschappen generaliseren. Bijvoorbeeld, glTF™ base color gebruikt `"baseColorFactor"` en `"baseColorTexture"`, waarvan de laatste een textureInfo heeft die een texture `"index"` en een `"texCoord"` index definieert. G4MF-materialen hebben kanalen zoals `"baseColor"` waarbij deze eigenschappen zijn samengevoegd.
- G4MF-lichten zijn opgenomen in de basis-specificatie, terwijl glTF™-lichten zich in de `KHR_lights_punctual` extensie bevinden.
- G4MF-lichten vereisen dat rekening wordt gehouden met de schaal van de node waaraan ze zijn gekoppeld, terwijl glTF™-lichten vereisen dat de schaal van de node wordt genegeerd.
- G4MF-accessors hebben een `"primitiveType"` string met waarden zoals `"uint8"`, `"int16"`, `"float32"`, enzovoorts. glTF™-accessors hebben een `"componentType"`-eigenschap waarvan de waarden OpenGL™-specifieke enumeraties zoals `5121`, `5122`, `5126`, enzovoorts zijn. De aanpak van G4MF is mens-leesbaarder en uitbreidbaar, terwijl de aanpak van glTF™ vereist dat men een tabel met enumeraties raadpleegt om de waarden te begrijpen.
- G4MF-accessors hebben een `"vectorSize"` integer, die het glTF™ accessor-concept van `"SCALAR"`, `"VEC2"`, `"VEC3"` en `"VEC4"` generaliseert naar elke grootte.
- G4MF-accessors hebben geen `"count"` zoals glTF™-accessors; in plaats daarvan wordt het aantal bepaald door de grootte van de buffer view.
- G4MF-accessors hebben geen `"normalized"`, `"max"` of `"min"` eigenschappen, aangezien deze niet nuttig zijn voor uitwisseling.
- G4MF-accessors zijn aaneengesloten en ondersteunen geen sparse data, terwijl glTF™-accessors dit wel kunnen. Dit is nuttig voor GPU-klare prestatie-optimalisaties, maar niet voor uitwisseling.
- G4MF buffer views hebben geen `"byteStride"` of `"target"` eigenschappen, wat betekent dat G4MF geen interleaved data ondersteunt. Dit is nuttig in glTF™ voor GPU-klare prestatie-optimalisaties, maar niet voor uitwisseling.
- G4MF binaire chunks hebben een 4-byte compressieformaat-indicator, waarmee in de toekomst gecomprimeerde G4MF-binaire bestanden mogelijk zijn.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---