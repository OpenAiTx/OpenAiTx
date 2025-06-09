# Good 4D Model Format (G4MF)

Good 4D Model Format, 또는 줄여서 G4MF는 Khronos의 [glTF™](https://github.com/KhronosGroup/glTF)에서 영감을 받은 JSON 기반의 4D 중심 다차원 모델 포맷으로, 애플리케이션 간 고차원 콘텐츠의 전송, 교환, 상호운용성을 가능하게 합니다.

G4MF 파일은 다음과 같은 유형이 있습니다:
- `.g4tf`는 "Good 4D model Text File"의 약자입니다. 이 파일은 JSON 데이터를 순수 텍스트 기반 UTF-8 형식으로 포함하며, 바이너리 블롭은 문자열 내에 Base64로 인코딩되거나 외부 파일로 저장됩니다. 유효한 G4TF 파일에는 BOM 또는 캐리지 리턴이 포함되지 않습니다.
- `.g4b`는 "Good 4D model Binary"의 약자입니다. 사이즈 효율성을 위해 바이너리 데이터를 조밀하게 패킹하지만, 텍스트 에디터에서 내용을 확인하기 어렵다는 단점이 있습니다.

사양서는 여기에서 읽을 수 있습니다: [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md).

## glTF™와의 차이점

G4MF는 glTF™에서 영감을 받았으며 전체적인 구조가 유사하지만, 많은 차이점이 있습니다.

주요 차이점:

- G4MF는 다차원 4D 중심 포맷이고, glTF™는 3D 포맷입니다. (명확성을 위해 명시)
- glTF™는 GPU에 바로 로드할 수 있도록 데이터를 저장하는 마지막 단계 포맷으로 설계되었습니다. OpenGL™이나 Vulkan™ 등 그래픽 API가 4D, 5D, 6D 등을 지원하지 않으므로, 이 목표는 G4MF에는 적합하지 않습니다. 대신 G4MF는 주로 사람이 읽을 수 있는 교환 포맷으로 설계되었습니다.
- G4MF 메시 버텍스는 일반적으로 중복되지 않게 저장되고, 엣지와 셀에 의해 참조됩니다. glTF™는 각 삼각형을 고유한 버텍스로 저장하여 GPU에 바로 로드하기 쉽지만, 버텍스가 중복된 것에 대한 혼란을 초래할 수 있습니다. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF는 파일당 하나의 씬과 하나의 루트 노드만 허용하지만, glTF™는 여러 씬과 여러 루트 노드를 허용합니다. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- G4MF 바이너리는 `.g4b` 파일과 청크의 크기로 64비트 부호 없는 정수를 사용하지만, `.glb`는 32비트 부호 없는 정수를 사용합니다. 따라서 4 GiB를 초과하는 파일도 지원합니다. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF는 완전히 새로운 포맷이고, glTF™는 성숙한 산업 표준 포맷입니다. 따라서 3D 모델에는 glTF™ 사용을 권장하며, 3D G4MF 파일 사용은 권장하지 않습니다.

또한, G4MF와 glTF™ 간에는 다음과 같은 세부적인 차이점들이 있습니다:

- G4MF는 `"asset"`에 필수 정수 키 `"dimension"`을 추가합니다. 이 값이 반드시 정의되어야 하며, 없으면 파일이 유효하지 않습니다. 즉, 4D 모델은 JSON 데이터에 반드시 `{ "asset": { "dimension": 4 } }`를 포함해야 합니다.
- G4MF 에셋 헤더는 `"extensionsUsed"`와 `"extensionsRequired"` 배열을 포함합니다. glTF™에서는 이들이 최상위 JSON 오브젝트에 정의되어 있습니다.
- G4MF 노드 트랜스폼은 `"position"`과 `"basis"` 또는 `"rotor"`+`"scale"` 조합을 사용합니다. glTF™는 `"translation"`+`"rotation"`+`"scale"` 또는 4x4 `"matrix"`를 사용합니다. 두 포맷 모두 선형 변환만 허용하며, glTF™의 `"matrix"` 속성의 마지막 행은 항상 (0, 0, 0, 1) 값입니다. 이 마지막 행은 GPU로 데이터를 전송할 때 유용하지만, 교환을 위한 의미 있는 데이터는 아니므로 G4MF에는 존재하지 않습니다.
- G4MF 노드 `"scale"`은 음수 스케일을 허용하지 않지만, glTF™는 허용합니다. G4MF에서는 필요 시 `"basis"`를 사용하여 플립/반사를 처리해야 합니다.
- G4MF 노드 `"scale"`은 균일 스케일을 나타내는 단일 값도 허용하여, 특히 매우 높은 차원에서의 데이터 압축에 유리합니다. glTF™의 `"scale"`은 항상 3D 벡터입니다.
- G4MF 노드는 `"visible"` 불리언을 포함하여, glTF™의 `KHR_node_visibility` 확장 기능을 기본 사양에 제공합니다. https://github.com/KhronosGroup/glTF/pull/2410
- G4MF 메시에는 `"surfaces"`가 있으며, 이는 보다 사용자 친화적인 명칭입니다. glTF™ 메시에는 `"primitives"`가 있는데, 이는 OpenGL™에서 사용하는 용어입니다. https://www.khronos.org/opengl/wiki/primitive
- G4MF 메시 서피스는 표면의 버텍스, 엣지, 셀을 명시적으로 정의합니다. glTF™ 메시 프리미티브는 이를 `"attributes"`와 `"mode"` 내에 정의합니다.
- G4MF 메시 서피스는 `"polytopeCells"` 불리언을 가질 수 있으며, glTF™의 `FB_ngon_encoding` 확장 기능을 기본 사양에 제공합니다. https://github.com/KhronosGroup/glTF/pull/1620
- G4MF 머티리얼은 glTF™의 개별 머티리얼 속성 개념을 일반화한 채널을 가집니다. 예를 들어, glTF™의 기본 색상은 `"baseColorFactor"`와 `"baseColorTexture"`를 사용하며, 후자는 텍스처 `"index"`와 `"texCoord"` 인덱스를 정의하는 textureInfo를 가집니다. G4MF 머티리얼은 `"baseColor"`와 같은 채널에 이러한 속성을 통합합니다.
- G4MF 라이트는 기본 사양에 포함되어 있지만, glTF™ 라이트는 `KHR_lights_punctual` 확장에 있습니다.
- G4MF 라이트는 연결된 노드의 스케일을 반드시 고려해야 하지만, glTF™ 라이트는 연결된 노드의 스케일을 무시해야 합니다.
- G4MF 액세서는 `"primitiveType"` 문자열을 가지며, `"uint8"`, `"int16"`, `"float32"` 등 값을 가집니다. glTF™ 액세서는 `"componentType"` 속성을 가지며, `5121`, `5122`, `5126` 등 OpenGL™ 전용 열거형 값을 사용합니다. G4MF 방식이 더 사람이 읽기 쉽고 확장 가능합니다. glTF™ 방식은 값을 이해하려면 열거형 테이블을 참고해야 합니다.
- G4MF 액세서는 `"vectorSize"` 정수로, glTF™의 `"SCALAR"`, `"VEC2"`, `"VEC3"`, `"VEC4"` 개념을 임의 크기로 일반화합니다.
- G4MF 액세서에는 glTF™의 `"count"`가 없으며, 개수는 버퍼 뷰의 크기로 결정됩니다.
- G4MF 액세서에는 `"normalized"`, `"max"`, `"min"` 속성이 없으며, 이는 교환에 유용하지 않기 때문입니다.
- G4MF 액세서는 연속적이며, 희소(sparse) 형태를 지원하지 않습니다. 반면 glTF™ 액세서는 sparse를 지원합니다. 이는 GPU를 위한 성능 최적화에 유용하지만, 교환에는 필요하지 않습니다.
- G4MF 버퍼 뷰에는 `"byteStride"`나 `"target"` 속성이 없으므로, G4MF는 인터리브(interleaved) 데이터를 지원하지 않습니다. 이는 glTF™에서 GPU 최적화에 유용하지만, 교환에는 필요하지 않습니다.
- G4MF 바이너리 청크에는 4바이트 압축 포맷 표시자가 있어, 향후 압축된 G4MF 바이너리 파일을 지원할 수 있습니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---