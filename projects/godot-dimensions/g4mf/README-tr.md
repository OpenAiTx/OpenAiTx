# Good 4D Model Format (G4MF)

Good 4D Model Format, veya kısaca G4MF, Khronos'un [glTF™](https://github.com/KhronosGroup/glTF)'inden esinlenen, uygulamalar arasında daha yüksek boyutlu içeriklerin iletimi, değişimi ve birlikte çalışabilirliğini sağlayan JSON tabanlı, 4D odaklı çok boyutlu bir model formatıdır.

G4MF dosyaları aşağıdaki türlerde olabilir:
- `.g4tf` "Good 4D model Text File" anlamına gelir. JSON verisini tamamen metin tabanlı UTF-8 formatında içerir, ikili bloblar bir dize içinde Base64 olarak kodlanır veya harici dosyalar olarak saklanır. Geçerli G4TF dosyaları BOM veya satır başı karakteri içermez.
- `.g4b` "Good 4D model Binary" anlamına gelir. Boyut verimliliği için ikili verileri yoğun şekilde paketler, ancak bir metin düzenleyicisinde incelemeyi zorlaştırır.

Spesifikasyonu buradan okuyun: [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md).

## glTF™ ile Farkları

G4MF, glTF™'den esinlenmiştir ve genel olarak benzer bir yapıya sahiptir, ancak birçok farklılığı vardır.

Başlıca farklar:

- G4MF çok boyutlu ve 4D odaklı bir formattır, glTF™ ise 3D formattır. (Açıkça, ancak netlik için belirtilmiştir.)
- glTF™, verilerin OpenGL™ veya Vulkan™'a yüklenecek şekilde GPU'ya hazır bir son aşama formatı olarak tasarlanmıştır. Grafik API'leri 4D, 5D, 6D vb. modelleri desteklemediğinden, bu hedef G4MF için anlamlı değildir. Bunun yerine, G4MF öncelikle insan tarafından okunabilir bir değişim formatı olarak tasarlanmıştır.
- G4MF ağ (mesh) köşe noktalarını genellikle çoğaltılmamış şekilde saklar ve kenar ve hücreler tarafından referans edilir. glTF™, her üçgeni benzersiz köşe noktalarıyla saklar, bu da doğrudan GPU'ya yüklemeyi kolaylaştırır, ancak köşe noktalarının çoğaltılması konusunda kafa karışıklığına yol açar. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF, dosya başına yalnızca bir sahne ve bir kök düğüme izin verirken, glTF™ birden fazla sahne ve birden fazla kök düğüme izin verir. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- G4MF ikilileri, `.g4b` dosya ve parçalarının boyutu için 64-bit işaretsiz tamsayı kullanır, `.glb`'deki gibi 32-bit yerine. Bu, 4 GiB'ten büyük dosyalara izin verir. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF yepyeni bir formatken, glTF™ olgun bir endüstri standardı formattır. Bu nedenle, 3D modeller için glTF™ kullanmanızı, 3D G4MF dosyalarını kullanmamanızı öneririz.

Ayrıca, G4MF ile glTF™ arasında birçok ince ayrıntı farkı vardır:

- G4MF, `"asset"`'e yeni bir zorunlu tam sayı anahtarı `"dimension"` ekler; bu TANIMLANMAK ZORUNDADIR, aksi takdirde dosya geçersizdir. Bu, 4D modellerin JSON verilerinde `{ "asset": { "dimension": 4 } }` içermesi gerektiği anlamına gelir.
- G4MF varlık başlığı `"extensionsUsed"` ve `"extensionsRequired"` dizilerini içerir. glTF™'de, bunlar üst düzey JSON nesnesinde tanımlanır.
- G4MF düğüm dönüşümleri `"position"` ve ya `"basis"` ya da `"rotor"`+`"scale"` kombinasyonunu kullanır; glTF™ ise `"translation"`+`"rotation"`+`"scale"` veya 4x4 `"matrix"` kullanır. Her iki formatta da yalnızca doğrusal dönüşüme izin verilir, yani glTF™'de `"matrix"` özelliğinin son satırı her zaman (0, 0, 0, 1) değerlerine sahiptir. Bu son satır, verileri GPU'ya göndermek için yararlıdır, ancak değişim için anlamlı veri değildir, bu nedenle G4MF'de bulunmaz.
- G4MF düğüm `"scale"`'ı negatif ölçeklere izin vermez, glTF™ ise verir. G4MF, gerekirse flip/yansıma için `"basis"` kullanılmasını gerektirir.
- G4MF düğüm `"scale"`'ı, tek bir değer olarak birim ölçek temsilini destekler; bu, özellikle çok yüksek boyutlarda kompaktlık sağlar. glTF™ `"scale"` her zaman 3D vektördür.
- G4MF düğümlerinde `"visible"` boolean'ı bulunur; bu, glTF™'deki `KHR_node_visibility` uzantısını temel spesifikasyona dahil eder. https://github.com/KhronosGroup/glTF/pull/2410
- G4MF ağlarında `"surfaces"` bulunur; bu, daha kullanıcı dostu bir isimdir. glTF™ ağlarında `"primitives"` bulunur, bu terim OpenGL™ tarafından kullanılır. https://www.khronos.org/opengl/wiki/primitive
- G4MF ağ yüzeyleri, köşe noktalarını, kenarları ve yüzeydeki hücreleri açıkça tanımlar. glTF™ ağ primitifleri bunları `"attributes"` ve `"mode"` içinde tanımlar.
- G4MF ağ yüzeylerinde `"polytopeCells"` boolean'ı bulunabilir; bu, glTF™'deki `FB_ngon_encoding` uzantısını temel spesifikasyona dahil eder. https://github.com/KhronosGroup/glTF/pull/1620
- G4MF malzemeleri, glTF™'deki ayrı malzeme özellikleri kavramını genelleştiren kanallara sahiptir. Örneğin, glTF™ temel renk için `"baseColorFactor"` ve `"baseColorTexture"` kullanır; ikincisi bir doku `"index"`i ve `"texCoord"` dizini tanımlayan bir textureInfo'ya sahiptir. G4MF malzemelerinde `"baseColor"` gibi kanallar bu özellikleri bir arada sunar.
- G4MF ışıklar temel spesifikasyonda bulunur; glTF™'de ise ışıklar `KHR_lights_punctual` uzantısındadır.
- G4MF ışıklar, bağlı oldukları düğümün ölçeğini dikkate almayı gerektirir; glTF™ ışıkları ise bağlı olduğu düğümün ölçeğini yoksayar.
- G4MF erişicilerinde `"primitiveType"` dizesi bulunur; `"uint8"`, `"int16"`, `"float32"` gibi değerler alır. glTF™ erişicilerinde ise `"componentType"` özelliği bulunur ve değerleri OpenGL™'ye özgü numaralandırmalar (ör. `5121`, `5122`, `5126`) şeklindedir. G4MF'nin yaklaşımı daha okunabilir ve genişletilebilirdir; glTF™'nin yaklaşımı ise değerleri anlamak için bir numaralandırma tablosu gerektirir.
- G4MF erişicilerinde `"vectorSize"` tamsayısı bulunur ve glTF™'deki `"SCALAR"`, `"VEC2"`, `"VEC3"` ve `"VEC4"` kavramını herhangi bir boyuta geneller.
- G4MF erişicilerinde glTF™ erişicilerindeki gibi `"count"` bulunmaz, bunun yerine sayı, tampon görünümünün boyutundan belirlenir.
- G4MF erişicilerinde `"normalized"`, `"max"` veya `"min"` özellikleri yoktur; bunlar değişim için kullanışlı değildir.
- G4MF erişicileri bitişiktir ve seyrek olmayı desteklemez; glTF™ erişicileri seyrek olabilir. Bu, GPU'ya hazır performans iyileştirmeleri için faydalıdır ancak değişim için gerekli değildir.
- G4MF tampon görünümlerinde `"byteStride"` veya `"target"` özellikleri yoktur; yani G4MF, iç içe geçmiş verileri desteklemez. Bu, glTF™'de GPU'ya hazır performans iyileştirmeleri için faydalıdır ancak değişim için gerekli değildir.
- G4MF ikili parçalarında 4 baytlık bir sıkıştırma formatı göstergesi bulunur; bu, gelecekte sıkıştırılmış G4MF ikili dosyalarına olanak tanır.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---