# Good 4D Model Format (G4MF)

Good 4D Model Format, oder kurz G4MF, ist ein auf JSON basierendes, 4D-orientiertes, multidimensionales Modellformat, das von Khronos' [glTF™](https://github.com/KhronosGroup/glTF) inspiriert ist und die Übertragung, den Austausch und die Interoperabilität von höherdimensionalen Inhalten zwischen Anwendungen ermöglicht.

G4MF-Dateien können in folgenden Typen vorliegen:
- `.g4tf` steht für "Good 4D model Text File". Es enthält die JSON-Daten in einem rein textbasierten UTF-8-Format, wobei Binärdaten als Base64 innerhalb eines Strings kodiert oder als externe Dateien gespeichert werden. Gültige G4TF-Dateien enthalten weder BOMs noch Wagenrückläufe.
- `.g4b` steht für "Good 4D model Binary". Es packt die Binärdaten dicht für höhere Größeneffizienz, was jedoch das Inspizieren in einem Texteditor erschwert.

Die Spezifikation lesen Sie hier: [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md).

## Unterschiede zu glTF™

G4MF ist von glTF™ inspiriert und besitzt eine ähnliche Gesamtstruktur, weist jedoch viele Unterschiede auf.

Wesentliche Unterschiede:

- G4MF ist ein multidimensionales, 4D-orientiertes Format, während glTF™ ein 3D-Format ist. (offensichtlich, aber zur Klarstellung aufgeführt)
- glTF™ ist als GPU-bereites Last-Mile-Format konzipiert, wobei Daten so gespeichert werden, dass sie direkt in OpenGL™ oder Vulkan™ geladen werden können. Da Grafik-APIs keine 4D-, 5D-, 6D-, usw.-Modelle unterstützen, ergibt dieses Ziel für G4MF keinen Sinn. Stattdessen ist G4MF in erster Linie als menschenlesbares Austauschformat gedacht.
- G4MF-Mesh-Vertices werden typischerweise dedupliziert gespeichert und von Kanten und Zellen referenziert. glTF™ speichert jedes Dreieck mit einzigartigen Vertices, was das direkte Laden in die GPU erleichtert, aber zu Verwirrung über doppelte Vertices führt. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF erlaubt nur eine Szene pro Datei mit einem Wurzelknoten, während glTF™ mehrere Szenen und mehrere Wurzelknoten erlaubt. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- G4MF-Binärdateien verwenden einen 64-Bit-Unsigned-Integer für die Größe von `.g4b`-Dateien und -Chunks, anstelle eines 32-Bit-Unsigned-Integer wie `.glb`, was Dateien größer als 4 GiB ermöglicht. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF ist ein komplett neues Format, während glTF™ ein etabliertes Industriestandard-Format ist. Daher empfehlen wir, glTF™ für 3D-Modelle zu verwenden, nicht G4MF-Dateien im 3D-Bereich.

Darüber hinaus gibt es viele Detailunterschiede zwischen G4MF und glTF™:

- G4MF fügt einen neuen erforderlichen Integer-Schlüssel `"dimension"` zu `"asset"` hinzu, der DEFINIERT sein MUSS, sonst ist die Datei ungültig. Das bedeutet, dass 4D-Modelle `{ "asset": { "dimension": 4 } }` in ihren JSON-Daten enthalten MÜSSEN.
- Der G4MF-Asset-Header enthält die Arrays `"extensionsUsed"` und `"extensionsRequired"`. In glTF™ sind diese im Top-Level-JSON-Objekt definiert.
- G4MF-Node-Transformationen verwenden eine Kombination aus `"position"` und entweder `"basis"` oder `"rotor"`+`"scale"`, während glTF™ `"translation"`+`"rotation"`+`"scale"` oder eine 4x4-`"matrix"` verwendet. Beide Formate erlauben nur eine lineare Transformation, d.h. die glTF™-`"matrix"`-Eigenschaft hat immer (0, 0, 0, 1) Werte in der letzten Zeile. Diese letzte Zeile ist nützlich für die Übergabe der Daten an die GPU, aber nicht für den Austausch, daher ist sie in G4MF nicht vorhanden.
- G4MF-Node-`"scale"` erlaubt keine negativen Skalierungen, während glTF™ dies zulässt. G4MF verlangt, dass für Spiegelungen/Reflexionen, falls nötig, `"basis"` verwendet wird.
- G4MF-Node-`"scale"` erlaubt einen Einzelwert für eine gleichmäßige Skalierung, was besonders bei sehr hohen Dimensionen für Kompaktheit sorgt. glTF™-`"scale"` ist immer ein 3D-Vektor.
- G4MF-Knoten verfügen über ein Boolean `"visible"`, welches die glTF™-Erweiterung `KHR_node_visibility` in der Basisspezifikation bereitstellt. https://github.com/KhronosGroup/glTF/pull/2410
- G4MF-Meshes haben `"surfaces"`, einen benutzerfreundlicheren Namen. glTF™-Meshes haben `"primitives"`, was die Terminologie von OpenGL™ ist. https://www.khronos.org/opengl/wiki/primitive
- G4MF-Mesh-Surfaces definieren explizit Vertices, Kanten und Zellen auf der Oberfläche. glTF™-Mesh-Primitives definieren diese innerhalb von `"attributes"` und `"mode"`.
- G4MF-Mesh-Surfaces können ein Boolean `"polytopeCells"` haben, das die glTF™-Erweiterung `FB_ngon_encoding` in der Basisspezifikation bereitstellt. https://github.com/KhronosGroup/glTF/pull/1620
- G4MF-Materialien verfügen über Kanäle, die das glTF™-Konzept separater Materialeigenschaften verallgemeinern. Zum Beispiel verwendet glTF™ für Basisfarbe `"baseColorFactor"` und `"baseColorTexture"`, wobei letzteres eine textureInfo mit einem Textur-`"index"` und einem `"texCoord"`-Index besitzt. G4MF-Materialien besitzen Kanäle wie `"baseColor"` mit diesen vereinten Eigenschaften.
- G4MF-Lichter sind in der Basisspezifikation enthalten, während glTF™-Lichter in der Erweiterung `KHR_lights_punctual` zu finden sind.
- G4MF-Lichter müssen die Skalierung des Knotens, an den sie angehängt sind, berücksichtigen, während glTF™-Lichter die Skalierung des Knotens ignorieren müssen.
- G4MF-Accessors haben eine `"primitiveType"`-Zeichenkette mit Werten wie `"uint8"`, `"int16"`, `"float32"` usw. glTF™-Accessors besitzen eine `"componentType"`-Eigenschaft, deren Werte OpenGL™-spezifische Aufzählungen wie `5121`, `5122`, `5126` usw. sind. Der Ansatz von G4MF ist menschenlesbarer und erweiterbar, während glTF™-Werte Nachschlagen in einer Aufzählungstabelle erfordern.
- G4MF-Accessors besitzen einen `"vectorSize"`-Integer, der das glTF™-Accessor-Konzept von `"SCALAR"`, `"VEC2"`, `"VEC3"` und `"VEC4"` auf beliebige Größen verallgemeinert.
- G4MF-Accessors haben kein `"count"` wie glTF™-Accessors, stattdessen wird die Anzahl durch die Größe der Buffer View bestimmt.
- G4MF-Accessors verfügen nicht über `"normalized"`, `"max"` oder `"min"` Eigenschaften, da diese für den Austausch nicht nützlich sind.
- G4MF-Accessors sind zusammenhängend und unterstützen keine Sparse-Struktur, während glTF™-Accessors sparse sein können. Dies ist für GPU-Optimierungen nützlich, aber nicht für den Austausch.
- G4MF-Buffer Views verfügen nicht über `"byteStride"` oder `"target"` Eigenschaften, d.h. G4MF unterstützt keine interleaved Daten. Dies ist in glTF™ für GPU-Optimierungen nützlich, aber nicht für den Austausch.
- G4MF-Binär-Chunks haben einen 4-Byte-Komprimierungsformat-Indikator, der in Zukunft komprimierte G4MF-Binärdateien ermöglicht.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---