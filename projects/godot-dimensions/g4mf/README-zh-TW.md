# Good 4D Model Format (G4MF)

Good 4D Model Format，簡稱 G4MF，是一種以 JSON 為基礎、專注於 4D 多維度的模型格式，受 Khronos 的 [glTF™](https://github.com/KhronosGroup/glTF) 啟發，允許在應用程式之間傳輸、交換及互操作高維度內容。

G4MF 檔案有以下幾種類型：
- `.g4tf` 代表「Good 4D model Text File」。它將 JSON 資料以純文字 UTF-8 格式儲存，二進位資料則以 Base64 編碼存於字串中或儲存為外部檔案。有效的 G4TF 檔案不包含 BOM 或換行字元（carriage returns）。
- `.g4b` 代表「Good 4D model Binary」。它為了儲存效率而密集打包二進位資料，但因此在文字編輯器中較難檢查。

請在此閱讀規範：[Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md)。

## 與 glTF™ 的差異

G4MF 受 glTF™ 啟發，整體結構相似，但有許多不同之處。

主要差異：

- G4MF 是多維、專注於 4D 的格式，而 glTF™ 是 3D 格式。（顯而易見，但為了清楚說明）
- glTF™ 設計為 GPU 就緒的最後一哩格式，資料儲存方式可直接載入 OpenGL™ 或 Vulkan™。由於繪圖 API 不支援 4D、5D、6D 等模型，因此這個目標對 G4MF 無意義。G4MF 主要設計為人類可讀的交換格式。
- G4MF 網格頂點通常去重後儲存，由邊與單元參照。glTF™ 為每個三角形儲存唯一頂點，這方便直接載入 GPU，但會造成頂點重複的混淆。https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF 每個檔案僅允許一個場景且僅有一個根節點，而 glTF™ 允許多個場景和多個根節點。https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- G4MF 二進位檔案及區塊大小使用 64 位元無號整數，而 `.glb` 使用 32 位元無號整數，因此 G4MF 支援超過 4 GiB 的檔案。https://github.com/KhronosGroup/glTF/issues/2114
- G4MF 是全新格式，而 glTF™ 是成熟的產業標準格式。因此，建議 3D 模型使用 glTF™，不要使用 3D G4MF 檔案。

此外，G4MF 與 glTF™ 在許多細節上也有差異：

- G4MF 在 `"asset"` 增加新的必要整數鍵 `"dimension"`，必須定義，否則檔案無效。這表示 4D 模型的 JSON 資料中必須有 `{ "asset": { "dimension": 4 } }`。
- G4MF 資產標頭包含 `"extensionsUsed"` 和 `"extensionsRequired"` 陣列。glTF™ 則定義於頂層 JSON 物件。
- G4MF 節點變換使用 `"position"` 搭配 `"basis"` 或 `"rotor"`+`"scale"`，而 glTF™ 使用 `"translation"`+`"rotation"`+`"scale"` 或 4x4 `"matrix"`。兩者僅允許線性變換，這表示 glTF™ 的 `"matrix"` 屬性最後一列總是 (0, 0, 0, 1)。這最後一列對傳送資料至 GPU 有用，但對交換無意義，因此 G4MF 不包含此資料。
- G4MF 節點 `"scale"` 不允許負數縮放，glTF™ 則允許。G4MF 如需翻轉/鏡射，必須使用 `"basis"`。
- G4MF 節點 `"scale"` 可接受單一值，代表等比縮放，這對高維度資料特別有利於精簡資料。glTF™ `"scale"` 永遠是 3D 向量。
- G4MF 節點有 `"visible"` 布林值，於基礎規範中提供 glTF™ 擴展 `KHR_node_visibility`。https://github.com/KhronosGroup/glTF/pull/2410
- G4MF 網格有 `"surfaces"`，名稱更貼近使用者。glTF™ 網格則稱為 `"primitives"`，是 OpenGL™ 的術語。https://www.khronos.org/opengl/wiki/primitive
- G4MF 網格面明確定義了頂點、邊和單元。glTF™ 網格 primitive 則在 `"attributes"` 與 `"mode"` 內定義。
- G4MF 網格面可有 `"polytopeCells"` 布林值，在基礎規範中提供 glTF™ 擴展 `FB_ngon_encoding`。https://github.com/KhronosGroup/glTF/pull/1620
- G4MF 材質通道概念泛化了 glTF™ 各自獨立的材質屬性。例如 glTF™ 基本色彩用 `"baseColorFactor"` 與 `"baseColorTexture"`，後者中有 textureInfo，定義材質 `"index"` 及 `"texCoord"`。G4MF 材質有如 `"baseColor"` 的通道，將這些屬性統一於其下。
- G4MF 燈光為基礎規範一部分，而 glTF™ 燈光則於擴展 `KHR_lights_punctual`。
- G4MF 燈光需考慮其所附節點的縮放，glTF™ 燈光則需忽略所附節點的縮放。
- G4MF 存取器（accessor）有 `"primitiveType"` 字串，值如 `"uint8"`、`"int16"`、`"float32"` 等。glTF™ 存取器有 `"componentType"` 屬性，值為 OpenGL™ 專用的列舉如 `5121`、`5122`、`5126` 等。G4MF 更易讀且可擴展，而 glTF™ 需查表了解數值。
- G4MF 存取器有 `"vectorSize"` 整數，將 glTF™ `"SCALAR"`、`"VEC2"`、`"VEC3"`、`"VEC4"` 概念推廣至任意大小。
- G4MF 存取器無 `"count"`，而 glTF™ 有，G4MF 的數量由緩衝區視圖大小決定。
- G4MF 存取器無 `"normalized"`、`"max"`、`"min"` 屬性，因這些對交換無用。
- G4MF 存取器資料為連續，不支援稀疏（sparse），而 glTF™ 可支援。這對 GPU 效能優化有用，對交換則無用。
- G4MF 緩衝區視圖無 `"byteStride"` 或 `"target"` 屬性，表示 G4MF 不支援交錯資料。這在 glTF™ 中有助於 GPU 優化，對交換則無用。
- G4MF 二進位區塊有 4 字節壓縮格式指示器，為未來支援壓縮 G4MF 二進位檔案預留。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---