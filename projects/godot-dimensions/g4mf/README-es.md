# Good 4D Model Format (G4MF)

El Formato de Modelo 4D Bueno, o G4MF por sus siglas en inglés, es un formato de modelo multidimensional enfocado en 4D basado en JSON e inspirado en el [glTF™](https://github.com/KhronosGroup/glTF) de Khronos, permitiendo la transmisión, intercambio e interoperabilidad de contenido de dimensiones superiores entre aplicaciones.

Los archivos G4MF pueden tener los siguientes tipos:
- `.g4tf` significa "Archivo de Texto de Modelo 4D Bueno". Incluye los datos JSON en un formato puramente de texto en UTF-8, con blobs binarios codificados en Base64 dentro de una cadena, o almacenados como archivos externos. Los archivos G4TF válidos no contienen BOM ni retornos de carro.
- `.g4b` significa "Modelo 4D Bueno Binario". Empaqueta densamente los datos binarios para eficiencia de tamaño, a costa de dificultar su inspección en un editor de texto.

Lea la especificación aquí: [Especificación del Formato de Modelo 4D Bueno (G4MF)](specification/specification.md).

## Diferencias con glTF™

G4MF está inspirado en glTF™, y tiene una estructura general similar, pero presenta muchas diferencias.

Diferencias principales:

- G4MF es un formato multidimensional enfocado en 4D, mientras que glTF™ es un formato 3D. (obvio, pero se indica para mayor claridad)
- glTF™ está diseñado para ser un formato de última milla listo para la GPU, con datos almacenados de forma que puedan ser cargados directamente en OpenGL™ o Vulkan™. Dado que las APIs gráficas no soportan modelos 4D, 5D, 6D, etc., ese objetivo no tiene sentido para G4MF. En cambio, G4MF está diseñado principalmente como un formato de intercambio legible por humanos.
- Los vértices de las mallas en G4MF se almacenan de manera típicamente desduplicada y son referenciados por aristas y celdas. glTF™ almacena cada triángulo con vértices únicos, lo que facilita la carga directa en la GPU, pero lleva a confusiones sobre la duplicación de vértices. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF solo permite una escena por archivo con un nodo raíz, mientras que glTF™ permite múltiples escenas y múltiples nodos raíz. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- El binario G4MF utiliza un entero sin signo de 64 bits para el tamaño de los archivos y fragmentos `.g4b`, en lugar de un entero sin signo de 32 bits como `.glb`, permitiendo archivos mayores a 4 GiB. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF es un formato completamente nuevo, mientras que glTF™ es un estándar industrial maduro. Por lo tanto, recomendamos usar glTF™ para modelos 3D, no archivos 3D G4MF.

Además, existen muchas diferencias de detalle entre G4MF y glTF™:

- G4MF añade una nueva clave entera requerida `"dimension"` en `"asset"`, la cual DEBE estar definida o el archivo es inválido. Esto significa que los modelos 4D DEBEN tener `{ "asset": { "dimension": 4 } }` en sus datos JSON.
- El encabezado de asset de G4MF contiene los arreglos `"extensionsUsed"` y `"extensionsRequired"`. En glTF™, estos se definen en el objeto JSON de nivel superior.
- Las transformaciones de nodo en G4MF usan una combinación de `"position"` y `"basis"` o `"rotor"`+`"scale"`, mientras que glTF™ utiliza `"translation"`+`"rotation"`+`"scale"` o una `"matrix"` 4x4. Ambos formatos solo permiten una transformación lineal, lo que significa que la propiedad `"matrix"` de glTF™ siempre tiene valores (0, 0, 0, 1) en la última fila. Esta última fila es útil para enviar datos a la GPU, pero no es información significativa para el intercambio, por lo tanto, no está presente en G4MF.
- La propiedad `"scale"` de nodo en G4MF no permite escalados negativos, mientras que en glTF™ sí. G4MF requiere que se use `"basis"` para inversiones/reflejos, si es necesario.
- El `"scale"` de los nodos en G4MF permite un solo valor representando un escalado uniforme, útil para compacidad especialmente en dimensiones muy altas. En glTF™ `"scale"` siempre es un vector 3D.
- Los nodos en G4MF tienen un booleano `"visible"`, proporcionando la extensión de glTF™ `KHR_node_visibility` en la especificación base. https://github.com/KhronosGroup/glTF/pull/2410
- Las mallas G4MF tienen `"surfaces"`, que es un nombre más amigable para el usuario. Las mallas glTF™ tienen `"primitives"`, que es la terminología usada por OpenGL™. https://www.khronos.org/opengl/wiki/primitive
- Las superficies de malla en G4MF definen explícitamente los vértices, aristas y celdas en la superficie. Las primitivas de malla glTF™ definen estos dentro de `"attributes"` y `"mode"`.
- Las superficies de malla G4MF pueden tener un booleano `"polytopeCells"`, proporcionando la extensión de glTF™ `FB_ngon_encoding` en la especificación base. https://github.com/KhronosGroup/glTF/pull/1620
- Los materiales en G4MF tienen canales que generalizan el concepto de propiedades materiales separadas de glTF™. Por ejemplo, el color base en glTF™ usa `"baseColorFactor"` y `"baseColorTexture"`, esta última tiene un textureInfo que define un `"index"` de textura y un índice `"texCoord"`. Los materiales G4MF tienen canales como `"baseColor"` con estas propiedades unificadas bajo él.
- Las luces en G4MF están en la especificación base, mientras que en glTF™ están en la extensión `KHR_lights_punctual`.
- Las luces en G4MF requieren tener en cuenta la escala del nodo al que están adjuntas, mientras que en glTF™ se requiere ignorar la escala del nodo al que están adjuntas.
- Los accessors en G4MF tienen una cadena `"primitiveType"` que contiene valores como `"uint8"`, `"int16"`, `"float32"`, etc. Los accessors en glTF™ tienen una propiedad `"componentType"` cuyos valores son enumeraciones específicas de OpenGL™ como `5121`, `5122`, `5126`, etc. El enfoque de G4MF es más legible y extensible, mientras que el de glTF™ requiere que los humanos consulten una tabla de enumeraciones para entender los valores.
- Los accessors en G4MF tienen un entero `"vectorSize"`, generalizando el concepto de accessor de glTF™ de `"SCALAR"`, `"VEC2"`, `"VEC3"` y `"VEC4"` a cualquier tamaño.
- Los accessors en G4MF no tienen `"count"` como los de glTF™, en cambio, la cantidad se determina por el tamaño de la vista del búfer.
- Los accessors en G4MF no tienen las propiedades `"normalized"`, `"max"` o `"min"`, ya que no son útiles para el intercambio.
- Los accessors en G4MF son contiguos y no admiten ser dispersos, mientras que los de glTF™ pueden ser dispersos. Esto es útil para optimizaciones de rendimiento listas para GPU, pero no es útil para el intercambio.
- Las vistas de búfer en G4MF no tienen propiedades `"byteStride"` ni `"target"`, lo que significa que G4MF no soporta datos intercalados. Esto es útil en glTF™ para optimizaciones de rendimiento listas para GPU, pero no es útil para el intercambio.
- Los fragmentos binarios de G4MF tienen un indicador de formato de compresión de 4 bytes, permitiendo archivos binarios G4MF comprimidos en el futuro.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---