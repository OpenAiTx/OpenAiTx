# Good 4D Model Format (G4MF)

Good 4D Model Format，简称 G4MF，是一种基于 JSON、聚焦于 4D 的多维模型格式，灵感来源于 Khronos 的 [glTF™](https://github.com/KhronosGroup/glTF)，允许在应用程序之间传输、交换和互操作更高维度的内容。

G4MF 文件有以下类型：
- `.g4tf` 代表“Good 4D model Text File（优良 4D 模型文本文件）”。它以纯文本 UTF-8 格式包含 JSON 数据，二进制数据块以 Base64 编码为字符串，或存储为外部文件。有效的 G4TF 文件不包含 BOM 或回车符。
- `.g4b` 代表“Good 4D model Binary（优良 4D 模型二进制文件）”。它紧凑地打包二进制数据以提高尺寸效率，但因此在文本编辑器中难以检查。

请在此阅读规范：[Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md)。

## 与 glTF™ 的区别

G4MF 受 glTF™ 启发，整体结构类似，但有许多不同之处。

主要区别：

- G4MF 是一种面向多维、以 4D 为中心的格式，而 glTF™ 是 3D 格式。（显然，但为清晰起见特别说明）
- glTF™ 设计为 GPU 就绪的最后一公里格式，数据以适合直接加载到 OpenGL™ 或 Vulkan™ 的方式存储。由于图形 API 不支持 4D、5D、6D 等模型，这一目标对 G4MF 并不适用。G4MF 主要被设计为一种可读性高的人机交换格式。
- G4MF 网格顶点通常以去重方式存储，并由边和单元引用。glTF™ 将每个三角形存储为唯一顶点，这便于直接加载到 GPU，但会导致顶点重复的困惑。https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF 每个文件只允许一个场景和一个根节点，而 glTF™ 允许多个场景和多个根节点。https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- G4MF 二进制使用 64 位无符号整数存储 `.g4b` 文件和块的大小，而 `.glb` 使用 32 位无符号整数，这允许文件大于 4 GiB。https://github.com/KhronosGroup/glTF/issues/2114
- G4MF 是全新的格式，而 glTF™ 是成熟的行业标准格式。因此，我们建议 3D 模型使用 glTF™，而不是 3D 的 G4MF 文件。

此外，G4MF 和 glTF™ 之间还有许多细节上的不同：

- G4MF 在 `"asset"` 中新增了必需的整数键 `"dimension"`，必须定义，否则文件无效。这意味着 4D 模型的 JSON 数据中必须有 `{ "asset": { "dimension": 4 } }`。
- G4MF 资产头包含 `"extensionsUsed"` 和 `"extensionsRequired"` 数组。在 glTF™ 中，这些定义在顶层 JSON 对象中。
- G4MF 节点变换采用 `"position"` 和 `"basis"` 或 `"rotor"`+`"scale"` 的组合，而 glTF™ 使用 `"translation"`+`"rotation"`+`"scale"` 或 4x4 的 `"matrix"`。两种格式都只允许线性变换，这意味着 glTF™ 的 `"matrix"` 属性最后一行始终为 (0, 0, 0, 1)。这最后一行对 GPU 传输有用，但对交换来说无实际意义，因此在 G4MF 中不包含。
- G4MF 节点 `"scale"` 不允许负缩放，而 glTF™ 允许。G4MF 要求需要翻转/反射时使用 `"basis"`。
- G4MF 节点 `"scale"` 允许单一值，表示统一缩放，这在维度非常高时有助于紧凑。glTF™ 的 `"scale"` 始终是 3D 向量。
- G4MF 节点有 `"visible"` 布尔值，在基础规范中提供了 glTF™ 扩展 `KHR_node_visibility`。https://github.com/KhronosGroup/glTF/pull/2410
- G4MF 网格有 `"surfaces"`，这是更友好的命名。glTF™ 网格有 `"primitives"`，这是 OpenGL™ 的术语。https://www.khronos.org/opengl/wiki/primitive
- G4MF 网格表面明确定义表面上的顶点、边和单元。glTF™ 网格 primitive 在 `"attributes"` 和 `"mode"` 内定义这些。
- G4MF 网格表面可以有 `"polytopeCells"` 布尔值，在基础规范中提供了 glTF™ 扩展 `FB_ngon_encoding`。https://github.com/KhronosGroup/glTF/pull/1620
- G4MF 材质有通道，泛化了 glTF™ 拆分材质属性的概念。例如，glTF™ 的 base color 使用 `"baseColorFactor"` 和 `"baseColorTexture"`，后者有 textureInfo 定义纹理 `"index"` 和 `"texCoord"` 索引。G4MF 材质有如 `"baseColor"` 这样的通道，将这些属性统一在其下。
- G4MF 灯光在基础规范中提供，而 glTF™ 灯光在 `KHR_lights_punctual` 扩展中。
- G4MF 灯光需要考虑其所附节点的缩放，而 glTF™ 灯光要求忽略其所附节点的缩放。
- G4MF accessor 有 `"primitiveType"` 字符串，值如 `"uint8"`、`"int16"`、`"float32"` 等。glTF™ accessor 有 `"componentType"`，其值是 OpenGL™ 专用枚举，如 `5121`、`5122`、`5126` 等。G4MF 方案更易读和可扩展，而 glTF™ 方案需查表才能理解。
- G4MF accessor 有 `"vectorSize"` 整数，将 glTF™ 的 `"SCALAR"`、`"VEC2"`、`"VEC3"` 和 `"VEC4"` 泛化为任意大小。
- G4MF accessor 没有 `"count"`，其数量由 buffer view 大小决定。
- G4MF accessor 没有 `"normalized"`、`"max"` 或 `"min"` 属性，因为这些对交换无意义。
- G4MF accessor 是连续的，不支持稀疏，而 glTF™ accessor 可以是稀疏的。这对 GPU 优化有用，但对交换无意义。
- G4MF buffer view 没有 `"byteStride"` 或 `"target"` 属性，意味着 G4MF 不支持交错数据。这在 glTF™ 中对 GPU 优化有用，但对交换无意义。
- G4MF 二进制块有 4 字节压缩格式指示符，为将来支持压缩 G4MF 二进制文件做准备。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---