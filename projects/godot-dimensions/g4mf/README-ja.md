# Good 4D Model Format (G4MF)

Good 4D Model Format、略してG4MFは、Khronosの[glTF™](https://github.com/KhronosGroup/glTF)に触発されたJSONベースの4次元（4D）に特化した多次元モデルフォーマットであり、アプリケーション間で高次元コンテンツの送信、交換、相互運用性を可能にします。

G4MFファイルには次の種類があります：
- `.g4tf`は「Good 4D model Text File」の略です。JSONデータを純粋なテキストベースのUTF-8形式で含み、バイナリブロブはBase64で文字列内部にエンコードされるか、外部ファイルとして保存されます。有効なG4TFファイルにはBOMやキャリッジリターンは含まれません。
- `.g4b`は「Good 4D model Binary」の略です。サイズ効率のためにバイナリデータを高密度にパックしますが、テキストエディタでの確認が難しくなります。

仕様書はこちらでご覧ください：[Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md)。

## glTF™との違い

G4MFはglTF™に触発されており、全体的な構造は似ていますが、多くの違いがあります。

主な違い：

- G4MFは多次元の4D中心のフォーマットであり、glTF™は3Dフォーマットです。（明確にするために記載）
- glTF™はGPU向けの最終フォーマットとして設計されており、OpenGL™やVulkan™に直接ロードできるようなデータ形式になっています。グラフィックスAPIは4D、5D、6D等のモデルをサポートしていないため、その目的はG4MFには当てはまりません。G4MFは主に人間が読みやすい交換フォーマットとして設計されています。
- G4MFのメッシュ頂点は通常重複が排除された形で保存され、エッジやセルによって参照されます。glTF™は各三角形ごとに頂点を一意に保存しますが、これはGPUに直接ロードする際には便利ですが、頂点の重複に関する混乱を招きます。https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MFはファイルごとに1つのシーンと1つのルートノードのみを許可しますが、glTF™は複数のシーンと複数のルートノードを許可します。https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- G4MFバイナリは`.g4b`ファイルおよびチャンクのサイズに64ビット符号なし整数を使用しますが、`.glb`は32ビット符号なし整数を使用します。これにより、4GiBを超えるファイルが可能になります。https://github.com/KhronosGroup/glTF/issues/2114
- G4MFは新しいフォーマットであり、glTF™は成熟した業界標準フォーマットです。したがって、3DモデルにはglTF™の使用を推奨し、3D G4MFファイルの使用は推奨しません。

さらに、G4MFとglTF™の間には細かな違いが多数あります：

- G4MFでは、`"asset"`に新しい必須整数キー`"dimension"`が追加されています。これが定義されていない場合、ファイルは無効です。つまり、4DモデルはJSONデータ内に`{ "asset": { "dimension": 4 } }`を含める必要があります。
- G4MFアセットヘッダーには`"extensionsUsed"`および`"extensionsRequired"`配列が含まれます。glTF™ではこれらはトップレベルのJSONオブジェクトで定義されます。
- G4MFノードの変換は`"position"`と、`"basis"`または`"rotor"`+`"scale"`の組み合わせを使用しますが、glTF™は`"translation"`+`"rotation"`+`"scale"`または4x4の`"matrix"`を使用します。両フォーマットとも線形変換のみを許可しており、glTF™の`"matrix"`プロパティの最終行は常に(0, 0, 0, 1)です。この最終行はGPUへのデータ送信には有用ですが、交換用データとしては意味がないため、G4MFには存在しません。
- G4MFノードの`"scale"`は負のスケールを許可しませんが、glTF™は許可します。G4MFでは反転や鏡映には`"basis"`の使用を必要とします。
- G4MFノードの`"scale"`は一つの値で一様スケールを表すことができ、高次元でもコンパクトに記述できます。glTF™の`"scale"`は常に3Dベクトルです。
- G4MFノードには`"visible"`ブール値があり、glTF™の拡張`KHR_node_visibility`をベース仕様に取り入れています。https://github.com/KhronosGroup/glTF/pull/2410
- G4MFメッシュは`"surfaces"`を持ち、よりユーザーフレンドリーな名称です。glTF™メッシュはOpenGL™の用語である`"primitives"`を使用します。https://www.khronos.org/opengl/wiki/primitive
- G4MFメッシュサーフェスは頂点・エッジ・セルを明示的に定義します。glTF™のメッシュプリミティブはこれらを`"attributes"`や`"mode"`内で定義します。
- G4MFメッシュサーフェスは`"polytopeCells"`ブール値を持つことができ、glTF™拡張`FB_ngon_encoding`をベース仕様に取り入れています。https://github.com/KhronosGroup/glTF/pull/1620
- G4MFマテリアルはチャンネルを持ち、glTF™の個別のマテリアルプロパティの概念を一般化しています。例えばglTF™の基本色は`"baseColorFactor"`と`"baseColorTexture"`を使い、後者はテクスチャ`"index"`や`"texCoord"`インデックスを持つtextureInfoを定義します。G4MFマテリアルは`"baseColor"`などのチャンネルでこれらのプロパティを統合しています。
- G4MFのライトはベース仕様に含まれますが、glTF™のライトは`KHR_lights_punctual`拡張に含まれます。
- G4MFのライトは、取り付けられたノードのスケールを考慮する必要がありますが、glTF™のライトはノードのスケールを無視する必要があります。
- G4MFアクセサは`"primitiveType"`文字列を持ち、`"uint8"`、`"int16"`、`"float32"`などの値を取ります。glTF™のアクセサはOpenGL™特有の列挙値（`5121`、`5122`、`5126`など）を持つ`"componentType"`プロパティを持ちます。G4MFのアプローチは人間にとってより読みやすく拡張性がありますが、glTF™のアプローチは値を理解するために列挙表を参照する必要があります。
- G4MFアクセサは`"vectorSize"`整数を持ち、glTF™アクセサの`"SCALAR"`、`"VEC2"`、`"VEC3"`、`"VEC4"`の概念を任意のサイズに一般化しています。
- G4MFアクセサにはglTF™のような`"count"`はなく、バッファビューのサイズによって個数が決まります。
- G4MFアクセサには`"normalized"`、`"max"`、`"min"`プロパティはありません。これらは交換には有用でないためです。
- G4MFアクセサは連続しておりスパース（疎）には対応していませんが、glTF™アクセサはスパースをサポートします。これはGPU向けの最適化には有用ですが、交換用途では有用でありません。
- G4MFバッファビューには`"byteStride"`や`"target"`プロパティがなく、インターリーブデータをサポートしません。これはglTF™ではGPU最適化のために有用ですが、交換用途では有用でありません。
- G4MFバイナリチャンクには4バイトの圧縮フォーマットインジケータがあり、将来的に圧縮G4MFバイナリファイルをサポート可能です。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---