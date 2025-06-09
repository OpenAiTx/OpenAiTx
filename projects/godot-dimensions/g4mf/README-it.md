# Good 4D Model Format (G4MF)

Good 4D Model Format, o G4MF in breve, è un formato modello multi-dimensionale focalizzato sul 4D basato su JSON, ispirato al [glTF™](https://github.com/KhronosGroup/glTF) di Khronos, che consente la trasmissione, lo scambio e l'interoperabilità di contenuti di dimensioni superiori tra applicazioni.

I file G4MF possono essere dei seguenti tipi:
- `.g4tf` sta per "Good 4D model Text File". Include i dati JSON in un formato solo testo basato su UTF-8, con blob binari codificati come Base64 all'interno di una stringa, o memorizzati come file esterni. I file G4TF validi non contengono BOM o ritorni a capo.
- `.g4b` sta per "Good 4D model Binary". Impacchetta densamente i dati binari per efficienza di dimensioni, a scapito di rendere più difficile l'ispezione in un editor di testo.

Leggi la specifica qui: [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md).

## Differenze rispetto a glTF™

G4MF è ispirato a glTF™ e ha una struttura complessiva simile, ma presenta molte differenze.

Differenze principali:

- G4MF è un formato multi-dimensionale focalizzato sul 4D, mentre glTF™ è un formato 3D. (ovvio, ma dichiarato per chiarezza)
- glTF™ è progettato come formato finale pronto per la GPU, con dati memorizzati in modo tale da poter essere caricati direttamente in OpenGL™ o Vulkan™. Poiché le API grafiche non supportano modelli 4D, 5D, 6D, ecc., questo obiettivo non ha senso per G4MF. Invece, G4MF è progettato principalmente come formato di scambio leggibile dall'uomo.
- I vertici delle mesh G4MF sono memorizzati tipicamente in modo de-duplicato e referenziati da spigoli e celle. glTF™ memorizza ogni triangolo con vertici unici, il che è più facile per il caricamento diretto sulla GPU, ma porta a confusione riguardo alla duplicazione dei vertici. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF consente un'unica scena per file con un solo nodo radice, mentre glTF™ consente più scene e più nodi radice. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- Il binario G4MF utilizza un intero senza segno a 64 bit per la dimensione dei file e dei chunk `.g4b`, invece di un intero senza segno a 32 bit come `.glb`, permettendo file più grandi di 4 GiB. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF è un formato completamente nuovo, mentre glTF™ è un formato standard industriale maturo. Pertanto, si raccomanda di utilizzare glTF™ per modelli 3D, non file G4MF 3D.

Inoltre, ci sono molte differenze di dettaglio tra G4MF e glTF™:

- G4MF aggiunge una nuova chiave intera obbligatoria `"dimension"` a `"asset"`, che DEVE essere definita altrimenti il file è invalido. Questo significa che i modelli 4D DEVONO avere `{ "asset": { "dimension": 4 } }` nei propri dati JSON.
- L'header dell'asset G4MF contiene gli array `"extensionsUsed"` e `"extensionsRequired"`. In glTF™, questi sono definiti nell'oggetto JSON di livello superiore.
- Le trasformazioni dei nodi G4MF utilizzano una combinazione di `"position"` e di `"basis"` oppure `"rotor"`+`"scale"`, mentre glTF™ usa `"translation"`+`"rotation"`+`"scale"` oppure una `"matrix"` 4x4. Entrambi i formati consentono solo una trasformazione lineare, il che significa che la proprietà `"matrix"` di glTF™ ha sempre valori (0, 0, 0, 1) nell'ultima riga. Quest'ultima riga è utile per inviare i dati alla GPU, ma non è significativa per lo scambio, quindi non è presente in G4MF.
- Lo `"scale"` del nodo G4MF non consente scale negative, mentre glTF™ sì. G4MF richiede che venga usato `"basis"` per ribaltamenti/riflessioni, se necessario.
- Lo `"scale"` del nodo G4MF può essere un singolo valore che rappresenta una scala uniforme, utile per la compattezza specialmente con dimensioni molto elevate. Lo `"scale"` di glTF™ è sempre un vettore 3D.
- I nodi G4MF hanno un booleano `"visible"`, fornendo l'estensione glTF™ `KHR_node_visibility` nella specifica base. https://github.com/KhronosGroup/glTF/pull/2410
- Le mesh G4MF hanno `"surfaces"`, che è un nome più user-friendly. Le mesh glTF™ hanno `"primitives"`, che è la terminologia usata da OpenGL™. https://www.khronos.org/opengl/wiki/primitive
- Le superfici delle mesh G4MF definiscono esplicitamente vertici, spigoli e celle sulla superficie. I primitive delle mesh glTF™ definiscono questi elementi all'interno di `"attributes"` e `"mode"`.
- Le superfici delle mesh G4MF possono avere un booleano `"polytopeCells"`, fornendo l'estensione glTF™ `FB_ngon_encoding` nella specifica base. https://github.com/KhronosGroup/glTF/pull/1620
- I materiali G4MF hanno canali che generalizzano il concetto glTF™ di proprietà di materiale separate. Ad esempio, il colore base di glTF™ usa `"baseColorFactor"` e `"baseColorTexture"`, quest'ultimo con un textureInfo che definisce un `"index"` texture e un indice `"texCoord"`. I materiali G4MF hanno canali come `"baseColor"` con queste proprietà unificate al loro interno.
- Le luci G4MF sono nella specifica base, mentre le luci glTF™ sono nell'estensione `KHR_lights_punctual`.
- Le luci G4MF richiedono di tener conto della scala del nodo a cui sono attaccate, mentre le luci glTF™ richiedono di ignorare la scala del nodo a cui sono attaccate.
- Gli accessor G4MF hanno una stringa `"primitiveType"` che contiene valori come `"uint8"`, `"int16"`, `"float32"`, ecc. Gli accessor glTF™ hanno una proprietà `"componentType"` i cui valori sono enumerazioni specifiche di OpenGL™ come `5121`, `5122`, `5126`, ecc. L'approccio G4MF è più leggibile dall'uomo ed estensibile, mentre quello di glTF™ richiede agli utenti di consultare una tabella di enumerazioni per comprendere i valori.
- Gli accessor G4MF hanno un intero `"vectorSize"`, generalizzando il concetto degli accessor glTF™ di `"SCALAR"`, `"VEC2"`, `"VEC3"` e `"VEC4"` a qualsiasi dimensione.
- Gli accessor G4MF non hanno `"count"` come quelli di glTF™, invece il conteggio viene determinato dalla dimensione della buffer view.
- Gli accessor G4MF non hanno le proprietà `"normalized"`, `"max"` o `"min"`, poiché non sono utili per lo scambio.
- Gli accessor G4MF sono contigui e non supportano la modalità sparse, mentre quelli di glTF™ possono essere sparse. Questo è utile per ottimizzazioni di performance pronte GPU, ma non è utile per lo scambio.
- Le buffer view G4MF non hanno proprietà `"byteStride"` o `"target"`, il che significa che G4MF non supporta dati interleaved. Questo è utile in glTF™ per ottimizzazioni di performance pronte GPU, ma non è utile per lo scambio.
- I chunk binari G4MF hanno un indicatore di formato di compressione a 4 byte, permettendo in futuro file binari G4MF compressi.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---