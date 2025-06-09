# Good 4D Model Format (G4MF)

Good 4D Model Format, or G4MF for short, is a JSON-based 4D-focused multi-dimensional model format inspired by Khronos's [glTF™](https://github.com/KhronosGroup/glTF), allowing for transmission, interchange, and interoperability of higher dimensional content between applications.

G4MF files can come in the following types:
- `.g4tf` stands for "Good 4D model Text File". It includes the JSON data in a purely text-based UTF-8 format, with binary blobs encoded as Base64 inside of a string, or stored as external files. Valid G4TF files do not contain BOMs or carriage returns.
- `.g4b` stands for "Good 4D model Binary". It densely packs the binary data for size efficiency, at the cost of making it harder to inspect in a text editor.

Read the specification here: [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md).

## Differences from glTF™

G4MF is inspired by glTF™, and it has a similar overall structure, but has many differences.

Major differences:

- G4MF is a multi-dimensional 4D-focused format, while glTF™ is a 3D format. (obviously, but stated for clarity)
- glTF™ is designed to be a GPU-ready last-mile format, with data stored in a way that is ready to be loaded into OpenGL™ or Vulkan™. Since graphics APIs do not support 4D, 5D, 6D, etc models, that goal does not make sense for G4MF. Instead, G4MF is designed primarily as a human-readable interchange format.
- G4MF mesh vertices are stored in a typically de-duplicated way, and referenced by edges and cells. glTF™ stores each triangle with unique vertices, which is easier for directly loading to the GPU, but leads to confusion about vertices being duplicated. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF only allows one scene per file with one root node, while glTF™ allows multiple scenes and multiple root nodes. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- G4MF binary uses a 64-bit unsigned integer for the size of `.g4b` files and chunks, instead of a 32-bit unsigned integer like `.glb`, allowing for files larger than 4 GiB. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF is a brand new format, while glTF™ is a mature industry standard format. Therefore, we recommend using glTF™ for 3D models, not 3D G4MF files.

Additionally, there are many fine-detail differences between G4MF and glTF™:

- G4MF adds a new required integer key `"dimension"` to `"asset"`, which MUST be defined or the file is invalid. This means that 4D models MUST have `{ "asset": { "dimension": 4 } }` in their JSON data.
- G4MF asset header contains the `"extensionsUsed"` and `"extensionsRequired"` arrays. In glTF™, these are defined in the top-level JSON object.
- G4MF node transforms use a combination of `"position"` and either `"basis"` or `"rotor"`+`"scale"`, while glTF™ uses `"translation"`+`"rotation"`+`"scale"` or a 4x4 `"matrix"`. Both formats only allow a linear transform, meaning the glTF™ `"matrix"` property always has (0, 0, 0, 1) values in the last row. This last row is useful for sending the data to the GPU, but is not meaningful data for interchange, therefore it is not present in G4MF.
- G4MF node `"scale"` does not allow for negative scales, while glTF™ does. G4MF requires that `"basis"` is used for flips/reflections, if needed.
- G4MF node `"scale"` allows for a single value representing a uniform scale, useful for compactness especially with very high dimensions. glTF™ `"scale"` is always a 3D vector.
- G4MF nodes have a `"visible"` boolean, providing the glTF™ extension `KHR_node_visibility` in the base specification. https://github.com/KhronosGroup/glTF/pull/2410
- G4MF meshes have `"surfaces"`, which is a more user-friendly name. glTF™ meshes have `"primitives"`, which is the terminology used by OpenGL™. https://www.khronos.org/opengl/wiki/primitive
- G4MF mesh surfaces explicitly define vertices, edges, and cells on the surface. glTF™ mesh primitives define these inside of `"attributes"` and `"mode"`.
- G4MF mesh surfaces may have a `"polytopeCells"` boolean, providing the glTF™ extension `FB_ngon_encoding` in the base specification. https://github.com/KhronosGroup/glTF/pull/1620
- G4MF materials have channels that generalize the glTF™ concept of separate material properties. For example, glTF™ base color uses `"baseColorFactor"` and `"baseColorTexture"`, the latter of which has a textureInfo which defines a texture `"index"` and a `"texCoord"` index. G4MF materials have channels like `"baseColor"` with these properties unified under it.
- G4MF lights are in the base specification, while glTF™ lights are in the `KHR_lights_punctual` extension.
- G4MF lights require taking into account the scale of the node they are attached to, while glTF™ lights require ignoring the scale of the node they are attached to.
- G4MF accessors have a `"primitiveType"` string that holds values like `"uint8"`, `"int16"`, `"float32"`, etc. glTF™ accessors have a `"componentType"` property whose values are OpenGL™-specific enumerations like `5121`, `5122`, `5126`, etc. G4MF's approach is more human-readable and extensible, while glTF™'s approach requires humans to reference a table of enumerations to understand the values.
- G4MF accessors have a `"vectorSize"` integer, generalizing the glTF™ accessor concept of `"SCALAR"`, `"VEC2"`, `"VEC3"`, and `"VEC4"` to any size.
- G4MF accessors do not have `"count"` like glTF™ accessors, instead the count is determined by the size of the buffer view.
- G4MF accessors do not have `"normalized"`, `"max"`, or `"min"` properties, since these are not useful for interchange.
- G4MF accessors are contiguous and do not support being sparse, while glTF™ accessors can be sparse. This is useful for GPU-ready performance optimizations, but is not useful for interchange.
- G4MF buffer views do not have `"byteStride"` or `"target"` properties, meaning G4MF does not support interleaved data. This is useful in glTF™ for GPU-ready performance optimizations, but is not useful for interchange.
- G4MF binary chunks have a 4-byte compression format indicator, allowing for compressed G4MF binary files in the future.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---