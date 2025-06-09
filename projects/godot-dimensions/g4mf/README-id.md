# Good 4D Model Format (G4MF)

Good 4D Model Format, atau disingkat G4MF, adalah format model multi-dimensi berbasis JSON yang berfokus pada 4D dan terinspirasi oleh [glTF™](https://github.com/KhronosGroup/glTF) dari Khronos, memungkinkan transmisi, pertukaran, dan interoperabilitas konten berdimensi tinggi antar aplikasi.

File G4MF dapat hadir dalam tipe berikut:
- `.g4tf` berarti "Good 4D model Text File". Ini mencakup data JSON dalam format UTF-8 berbasis teks murni, dengan blob biner yang dikodekan sebagai Base64 di dalam string, atau disimpan sebagai file eksternal. File G4TF yang valid tidak mengandung BOM atau carriage return.
- `.g4b` berarti "Good 4D model Binary". Ini mengemas data biner secara padat untuk efisiensi ukuran, dengan konsekuensi lebih sulit untuk diperiksa di editor teks.

Baca spesifikasinya di sini: [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md).

## Perbedaan dari glTF™

G4MF terinspirasi oleh glTF™, dan memiliki struktur keseluruhan yang serupa, tetapi memiliki banyak perbedaan.

Perbedaan utama:

- G4MF adalah format multi-dimensi yang berfokus pada 4D, sedangkan glTF™ adalah format 3D. (jelas, tapi disebutkan demi kejelasan)
- glTF™ dirancang sebagai format siap-GPU jarak akhir, dengan data disimpan sedemikian rupa sehingga siap dimuat ke OpenGL™ atau Vulkan™. Karena API grafis tidak mendukung model 4D, 5D, 6D, dll, tujuan tersebut tidak relevan untuk G4MF. Sebagai gantinya, G4MF dirancang terutama sebagai format pertukaran yang dapat dibaca manusia.
- Verteks mesh G4MF disimpan dengan cara yang biasanya tidak duplikat, dan direferensikan oleh edge dan cell. glTF™ menyimpan setiap segitiga dengan verteks unik, yang lebih mudah untuk langsung dimuat ke GPU, tetapi menyebabkan kebingungan tentang verteks yang terduplikasi. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF hanya mengizinkan satu scene per file dengan satu root node, sementara glTF™ mengizinkan beberapa scene dan beberapa root node. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- Biner G4MF menggunakan bilangan bulat tak bertanda 64-bit untuk ukuran file dan chunk `.g4b`, alih-alih bilangan bulat tak bertanda 32-bit seperti `.glb`, sehingga memungkinkan file lebih besar dari 4 GiB. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF adalah format baru, sedangkan glTF™ adalah format standar industri yang matang. Oleh karena itu, kami merekomendasikan menggunakan glTF™ untuk model 3D, bukan file G4MF 3D.

Selain itu, ada banyak perbedaan detail antara G4MF dan glTF™:

- G4MF menambahkan kunci integer wajib `"dimension"` pada `"asset"`, yang HARUS didefinisikan atau file dianggap tidak valid. Ini berarti bahwa model 4D HARUS memiliki `{ "asset": { "dimension": 4 } }` di data JSON-nya.
- Header aset G4MF berisi array `"extensionsUsed"` dan `"extensionsRequired"`. Pada glTF™, ini didefinisikan di objek JSON tingkat atas.
- Transformasi node G4MF menggunakan kombinasi `"position"` dan salah satu `"basis"` atau `"rotor"`+`"scale"`, sementara glTF™ menggunakan `"translation"`+`"rotation"`+`"scale"` atau `"matrix"` 4x4. Kedua format hanya mengizinkan transformasi linier, artinya properti `"matrix"` pada glTF™ selalu memiliki nilai (0, 0, 0, 1) di baris terakhir. Baris terakhir ini berguna untuk pengiriman data ke GPU, tetapi bukan data bermakna untuk pertukaran, oleh karena itu tidak ada di G4MF.
- `"scale"` pada node G4MF tidak mengizinkan skala negatif, sedangkan glTF™ mengizinkan. G4MF mengharuskan penggunaan `"basis"` untuk flip/refleksi, jika diperlukan.
- `"scale"` pada node G4MF dapat menggunakan satu nilai saja untuk skala seragam, berguna untuk ringkasnya data terutama pada dimensi sangat tinggi. `"scale"` pada glTF™ selalu berupa vektor 3D.
- Node G4MF memiliki boolean `"visible"`, menyediakan ekstensi glTF™ `KHR_node_visibility` di spesifikasi dasar. https://github.com/KhronosGroup/glTF/pull/2410
- Mesh G4MF memiliki `"surfaces"`, yang merupakan nama yang lebih ramah pengguna. Mesh glTF™ memiliki `"primitives"`, sesuai terminologi OpenGL™. https://www.khronos.org/opengl/wiki/primitive
- Permukaan mesh G4MF secara eksplisit mendefinisikan verteks, edge, dan cell pada permukaan. Primitive mesh glTF™ mendefinisikan ini di dalam `"attributes"` dan `"mode"`.
- Permukaan mesh G4MF dapat memiliki boolean `"polytopeCells"`, menyediakan ekstensi glTF™ `FB_ngon_encoding` di spesifikasi dasar. https://github.com/KhronosGroup/glTF/pull/1620
- Material G4MF memiliki channel yang menggeneralisasi konsep properti material terpisah pada glTF™. Misalnya, warna dasar glTF™ menggunakan `"baseColorFactor"` dan `"baseColorTexture"`, dimana yang terakhir memiliki textureInfo yang mendefinisikan indeks tekstur `"index"` dan indeks `"texCoord"`. Material G4MF memiliki channel seperti `"baseColor"` dengan properti ini disatukan di bawahnya.
- Lampu G4MF ada di spesifikasi dasar, sedangkan lampu glTF™ ada di ekstensi `KHR_lights_punctual`.
- Lampu G4MF mengharuskan memperhitungkan skala node tempat lampu tersebut ditempatkan, sedangkan lampu glTF™ mengharuskan mengabaikan skala node tempat lampu ditempatkan.
- Accessor G4MF memiliki string `"primitiveType"` yang berisi nilai seperti `"uint8"`, `"int16"`, `"float32"`, dll. Accessor glTF™ memiliki properti `"componentType"` yang nilainya adalah enumerasi spesifik OpenGL™ seperti `5121`, `5122`, `5126`, dll. Pendekatan G4MF lebih mudah dibaca dan dapat diperluas, sedangkan pendekatan glTF™ mengharuskan manusia merujuk pada tabel enumerasi untuk memahami nilainya.
- Accessor G4MF memiliki integer `"vectorSize"`, menggeneralisasi konsep accessor glTF™ `"SCALAR"`, `"VEC2"`, `"VEC3"`, dan `"VEC4"` ke ukuran apa pun.
- Accessor G4MF tidak memiliki `"count"` seperti accessor glTF™, melainkan jumlahnya ditentukan oleh ukuran buffer view.
- Accessor G4MF tidak memiliki properti `"normalized"`, `"max"`, atau `"min"`, karena ini tidak berguna untuk pertukaran.
- Accessor G4MF bersifat kontigu dan tidak mendukung sparse, sedangkan accessor glTF™ dapat sparse. Ini berguna untuk optimasi performa siap-GPU, namun tidak berguna untuk pertukaran.
- Buffer view G4MF tidak memiliki properti `"byteStride"` atau `"target"`, sehingga G4MF tidak mendukung data interleaved. Ini berguna di glTF™ untuk optimasi performa siap-GPU, namun tidak berguna untuk pertukaran.
- Chunk biner G4MF memiliki indikator format kompresi 4-byte, memungkinkan file biner G4MF terkompresi di masa depan.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---