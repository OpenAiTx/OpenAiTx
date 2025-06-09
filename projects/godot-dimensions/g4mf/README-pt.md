# Good 4D Model Format (G4MF)

Good 4D Model Format, ou G4MF para abreviar, é um formato de modelo multidimensional focado em 4D baseado em JSON, inspirado no [glTF™](https://github.com/KhronosGroup/glTF) da Khronos, permitindo a transmissão, intercâmbio e interoperabilidade de conteúdo de dimensões superiores entre aplicações.

Arquivos G4MF podem ser dos seguintes tipos:
- `.g4tf` significa "Good 4D model Text File". Inclui os dados JSON em um formato puramente texto em UTF-8, com blobs binários codificados como Base64 dentro de uma string, ou armazenados como arquivos externos. Arquivos G4TF válidos não contêm BOMs ou retornos de carro.
- `.g4b` significa "Good 4D model Binary". Compacta densamente os dados binários para eficiência de tamanho, ao custo de torná-los mais difíceis de inspecionar em um editor de texto.

Leia a especificação aqui: [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md).

## Diferenças em relação ao glTF™

G4MF é inspirado no glTF™ e possui uma estrutura geral semelhante, mas apresenta muitas diferenças.

Principais diferenças:

- G4MF é um formato multidimensional focado em 4D, enquanto o glTF™ é um formato 3D. (obviamente, mas declarado para clareza)
- O glTF™ é projetado para ser um formato final pronto para GPU, com dados armazenados de maneira pronta para serem carregados no OpenGL™ ou Vulkan™. Como APIs gráficas não suportam modelos 4D, 5D, 6D, etc., esse objetivo não faz sentido para o G4MF. Em vez disso, o G4MF é projetado principalmente como um formato de intercâmbio legível por humanos.
- Vértices de malha do G4MF são armazenados de forma tipicamente desduplicada e referenciados por arestas e células. O glTF™ armazena cada triângulo com vértices únicos, o que é mais fácil para carregamento direto na GPU, mas leva a confusão sobre vértices duplicados. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF permite apenas uma cena por arquivo com um nó raiz, enquanto o glTF™ permite múltiplas cenas e múltiplos nós raiz. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- O binário do G4MF utiliza um inteiro sem sinal de 64 bits para o tamanho de arquivos e blocos `.g4b`, em vez de um inteiro sem sinal de 32 bits como no `.glb`, permitindo arquivos maiores que 4 GiB. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF é um formato completamente novo, enquanto o glTF™ é um formato padrão maduro da indústria. Portanto, recomendamos usar glTF™ para modelos 3D, não arquivos 3D G4MF.

Além disso, há muitas diferenças de detalhes finos entre G4MF e glTF™:

- G4MF adiciona uma nova chave inteira obrigatória `"dimension"` ao `"asset"`, que DEVE ser definida ou o arquivo será inválido. Isso significa que modelos 4D DEVEM ter `{ "asset": { "dimension": 4 } }` em seus dados JSON.
- O cabeçalho do asset G4MF contém os arrays `"extensionsUsed"` e `"extensionsRequired"`. No glTF™, estes são definidos no objeto JSON de nível superior.
- As transformações dos nós G4MF usam uma combinação de `"position"` e `"basis"` ou `"rotor"`+`"scale"`, enquanto o glTF™ usa `"translation"`+`"rotation"`+`"scale"` ou uma `"matrix"` 4x4. Ambos os formatos permitem apenas uma transformação linear, o que significa que a propriedade `"matrix"` do glTF™ sempre tem valores (0, 0, 0, 1) na última linha. Essa última linha é útil para enviar os dados à GPU, mas não é significativa para intercâmbio, portanto não está presente no G4MF.
- O `"scale"` do nó G4MF não permite escalas negativas, enquanto o glTF™ permite. G4MF exige que `"basis"` seja usado para inversões/reflexões, se necessário.
- O `"scale"` do nó G4MF permite um único valor representando uma escala uniforme, útil para compactação especialmente em dimensões muito altas. O `"scale"` do glTF™ é sempre um vetor 3D.
- Nós G4MF possuem um booleano `"visible"`, fornecendo a extensão `KHR_node_visibility` do glTF™ na especificação base. https://github.com/KhronosGroup/glTF/pull/2410
- Malhas G4MF possuem `"surfaces"`, que é um nome mais amigável ao usuário. Malhas glTF™ possuem `"primitives"`, que é a terminologia usada pelo OpenGL™. https://www.khronos.org/opengl/wiki/primitive
- Superfícies de malha G4MF definem explicitamente vértices, arestas e células na superfície. Primitivos de malha do glTF™ definem isso dentro de `"attributes"` e `"mode"`.
- Superfícies de malha do G4MF podem ter um booleano `"polytopeCells"`, fornecendo a extensão `FB_ngon_encoding` do glTF™ na especificação base. https://github.com/KhronosGroup/glTF/pull/1620
- Materiais G4MF possuem canais que generalizam o conceito de propriedades de material separadas do glTF™. Por exemplo, a cor base do glTF™ usa `"baseColorFactor"` e `"baseColorTexture"`, sendo que o último possui uma textureInfo que define um `"index"` de textura e um índice `"texCoord"`. Materiais G4MF possuem canais como `"baseColor"` com estas propriedades unificadas sob ele.
- Luzes G4MF estão na especificação base, enquanto luzes glTF™ estão na extensão `KHR_lights_punctual`.
- Luzes G4MF exigem levar em conta a escala do nó ao qual estão anexadas, enquanto luzes glTF™ exigem ignorar a escala do nó ao qual estão anexadas.
- Accessors G4MF possuem uma string `"primitiveType"` com valores como `"uint8"`, `"int16"`, `"float32"`, etc. Accessors do glTF™ têm uma propriedade `"componentType"` cujos valores são enumerações específicas do OpenGL™ como `5121`, `5122`, `5126`, etc. A abordagem do G4MF é mais legível por humanos e extensível, enquanto a do glTF™ exige que humanos consultem uma tabela de enumerações para entender os valores.
- Accessors G4MF possuem um inteiro `"vectorSize"`, generalizando o conceito de accessor do glTF™ de `"SCALAR"`, `"VEC2"`, `"VEC3"` e `"VEC4"` para qualquer tamanho.
- Accessors G4MF não possuem `"count"` como os accessors do glTF™; em vez disso, a contagem é determinada pelo tamanho da view do buffer.
- Accessors G4MF não possuem as propriedades `"normalized"`, `"max"` ou `"min"`, pois não são úteis para intercâmbio.
- Accessors G4MF são contíguos e não suportam ser esparsos, enquanto accessors do glTF™ podem ser esparsos. Isto é útil para otimizações de desempenho prontas para GPU, mas não é útil para intercâmbio.
- Buffer views G4MF não possuem as propriedades `"byteStride"` ou `"target"`, ou seja, G4MF não suporta dados intercalados. Isso é útil no glTF™ para otimizações de desempenho prontas para GPU, mas não é útil para intercâmbio.
- Blocos binários do G4MF possuem um indicador de formato de compressão de 4 bytes, permitindo arquivos binários G4MF comprimidos no futuro.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---