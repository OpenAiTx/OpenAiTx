# Good 4D Model Format (G4MF)

Le Good 4D Model Format, ou G4MF pour faire court, est un format de modèle multi-dimensionnel axé sur la 4D basé sur JSON, inspiré par le [glTF™](https://github.com/KhronosGroup/glTF) de Khronos, permettant la transmission, l'échange et l'interopérabilité de contenus de dimensions supérieures entre applications.

Les fichiers G4MF peuvent se présenter sous les types suivants :
- `.g4tf` signifie "Good 4D model Text File". Il inclut les données JSON dans un format purement texte UTF-8, avec des blobs binaires encodés en Base64 à l'intérieur d'une chaîne, ou stockés comme fichiers externes. Les fichiers G4TF valides ne contiennent ni BOM ni retours chariot.
- `.g4b` signifie "Good 4D model Binary". Il compacte densément les données binaires pour une efficacité de taille, au détriment d'une inspection plus difficile dans un éditeur de texte.

Lisez la spécification ici : [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md).

## Différences avec glTF™

G4MF est inspiré par glTF™, et possède une structure générale similaire, mais présente de nombreuses différences.

Différences majeures :

- G4MF est un format multi-dimensionnel axé sur la 4D, tandis que glTF™ est un format 3D. (évident, mais précisé pour la clarté)
- glTF™ est conçu pour être un format prêt pour le GPU, avec des données stockées de manière à pouvoir être chargées directement dans OpenGL™ ou Vulkan™. Comme les API graphiques ne supportent pas les modèles 4D, 5D, 6D, etc., cet objectif n'a pas de sens pour G4MF. À la place, G4MF est principalement conçu comme un format d'échange lisible par l'homme.
- Les sommets des maillages G4MF sont stockés de manière généralement dédupliquée, et référencés par les arêtes et les cellules. glTF™ stocke chaque triangle avec des sommets uniques, ce qui est plus simple pour un chargement direct vers le GPU, mais entraîne une confusion sur la duplication des sommets. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF ne permet qu'une seule scène par fichier avec un seul nœud racine, alors que glTF™ permet plusieurs scènes et plusieurs nœuds racines. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- Le binaire G4MF utilise un entier non signé 64 bits pour la taille des fichiers et blocs `.g4b`, au lieu d'un entier non signé 32 bits comme `.glb`, permettant des fichiers de plus de 4 Gio. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF est un tout nouveau format, tandis que glTF™ est un format standard industriel mature. Par conséquent, nous recommandons d'utiliser glTF™ pour les modèles 3D, et non les fichiers G4MF 3D.

De plus, il existe de nombreuses différences de détail entre G4MF et glTF™ :

- G4MF ajoute une nouvelle clé entière requise `"dimension"` à `"asset"`, qui DOIT être définie sinon le fichier est invalide. Cela signifie que les modèles 4D DOIVENT avoir `{ "asset": { "dimension": 4 } }` dans leurs données JSON.
- L'en-tête d'asset G4MF contient les tableaux `"extensionsUsed"` et `"extensionsRequired"`. Dans glTF™, ceux-ci sont définis dans l'objet JSON de haut niveau.
- Les transformations des nœuds G4MF utilisent une combinaison de `"position"` et soit `"basis"` soit `"rotor"`+`"scale"`, alors que glTF™ utilise `"translation"`+`"rotation"`+`"scale"` ou une `"matrix"` 4x4. Les deux formats n'autorisent qu'une transformation linéaire, ce qui signifie que la propriété `"matrix"` de glTF™ a toujours les valeurs (0, 0, 0, 1) dans la dernière ligne. Cette dernière ligne est utile pour l'envoi des données au GPU, mais n'a pas de sens pour l'échange, donc elle n'est pas présente dans G4MF.
- L'attribut `"scale"` du nœud G4MF n'autorise pas les échelles négatives, alors que glTF™ le permet. G4MF exige que `"basis"` soit utilisé pour les inversions/réflexions, si nécessaire.
- L'attribut `"scale"` du nœud G4MF autorise une seule valeur représentant une échelle uniforme, utile pour la compacité en particulier dans des dimensions très élevées. Le `"scale"` de glTF™ est toujours un vecteur 3D.
- Les nœuds G4MF ont un booléen `"visible"`, fournissant l'extension glTF™ `KHR_node_visibility` dans la spécification de base. https://github.com/KhronosGroup/glTF/pull/2410
- Les maillages G4MF ont des `"surfaces"`, qui est un nom plus convivial. Les maillages glTF™ ont des `"primitives"`, qui est la terminologie utilisée par OpenGL™. https://www.khronos.org/opengl/wiki/primitive
- Les surfaces de maillage G4MF définissent explicitement les sommets, arêtes et cellules à la surface. Les primitives de maillage glTF™ les définissent dans `"attributes"` et `"mode"`.
- Les surfaces de maillage G4MF peuvent avoir un booléen `"polytopeCells"`, fournissant l'extension glTF™ `FB_ngon_encoding` dans la spécification de base. https://github.com/KhronosGroup/glTF/pull/1620
- Les matériaux G4MF possèdent des canaux qui généralisent le concept glTF™ de propriétés matérielles séparées. Par exemple, la couleur de base glTF™ utilise `"baseColorFactor"` et `"baseColorTexture"`, ce dernier ayant un textureInfo qui définit un `"index"` de texture et un indice `"texCoord"`. Les matériaux G4MF ont des canaux comme `"baseColor"` avec ces propriétés unifiées sous ce canal.
- Les lumières G4MF sont dans la spécification de base, alors que les lumières glTF™ sont dans l'extension `KHR_lights_punctual`.
- Les lumières G4MF requièrent de prendre en compte l'échelle du nœud auquel elles sont attachées, alors que les lumières glTF™ requièrent d'ignorer l'échelle du nœud auquel elles sont attachées.
- Les accesseurs G4MF possèdent une chaîne `"primitiveType"` qui prend des valeurs comme `"uint8"`, `"int16"`, `"float32"`, etc. Les accesseurs glTF™ ont une propriété `"componentType"` dont les valeurs sont des énumérations spécifiques à OpenGL™ comme `5121`, `5122`, `5126`, etc. L'approche de G4MF est plus lisible et extensible pour l'humain, tandis que celle de glTF™ oblige à se référer à une table d'énumérations pour comprendre les valeurs.
- Les accesseurs G4MF possèdent un entier `"vectorSize"`, généralisant le concept d'accesseur glTF™ de `"SCALAR"`, `"VEC2"`, `"VEC3"` et `"VEC4"` à n'importe quelle taille.
- Les accesseurs G4MF n'ont pas de `"count"` comme les accesseurs glTF™ ; le compte est déterminé par la taille de la vue du tampon.
- Les accesseurs G4MF n'ont pas les propriétés `"normalized"`, `"max"` ou `"min"`, car elles ne sont pas utiles pour l'échange.
- Les accesseurs G4MF sont contigus et ne supportent pas la sparsité, alors que les accesseurs glTF™ peuvent être clairsemés. Ceci est utile pour des optimisations de performance GPU, mais pas pour l'échange.
- Les vues de tampon G4MF n'ont pas les propriétés `"byteStride"` ou `"target"`, ce qui signifie que G4MF ne prend pas en charge les données entrelacées. Ceci est utile dans glTF™ pour des optimisations de performance GPU, mais n'est pas utile pour l'échange.
- Les blocs binaires G4MF ont un indicateur de format de compression sur 4 octets, permettant de futurs fichiers binaires G4MF compressés.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---