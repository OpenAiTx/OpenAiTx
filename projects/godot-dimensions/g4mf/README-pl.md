# Good 4D Model Format (G4MF)

Good 4D Model Format, czyli w skrócie G4MF, to oparty na JSON format modeli wielowymiarowych skoncentrowany na 4D, inspirowany [glTF™](https://github.com/KhronosGroup/glTF) od Khronos, umożliwiający przesyłanie, wymianę i interoperacyjność treści wyższych wymiarów pomiędzy aplikacjami.

Pliki G4MF mogą występować w następujących typach:
- `.g4tf` oznacza "Good 4D model Text File". Zawiera dane JSON w czysto tekstowym formacie UTF-8, z binarnymi blobami zakodowanymi jako Base64 wewnątrz ciągu znaków lub przechowywanymi jako pliki zewnętrzne. Prawidłowe pliki G4TF nie zawierają BOM ani znaków powrotu karetki.
- `.g4b` oznacza "Good 4D model Binary". Składnie pakuje dane binarne dla efektywności rozmiaru, kosztem trudniejszej inspekcji w edytorze tekstu.

Przeczytaj specyfikację tutaj: [Good 4D Model Format (G4MF) Specification](https://raw.githubusercontent.com/godot-dimensions/g4mf/main/specification/specification.md).

## Różnice względem glTF™

G4MF jest inspirowany glTF™, ma podobną ogólną strukturę, lecz różni się w wielu aspektach.

Główne różnice:

- G4MF to wielowymiarowy format skoncentrowany na 4D, podczas gdy glTF™ to format 3D. (oczywiste, ale podane dla jasności)
- glTF™ został zaprojektowany jako format "last-mile", gotowy dla GPU, z danymi przechowywanymi w sposób gotowy do załadowania do OpenGL™ lub Vulkan™. Ponieważ API graficzne nie obsługują modeli 4D, 5D, 6D itd., ten cel nie ma sensu dla G4MF. Zamiast tego G4MF jest projektowany głównie jako czytelny dla człowieka format wymiany.
- Wierzchołki siatki G4MF są przechowywane zwykle w formie z deduplikacją i referencjonowane przez krawędzie oraz komórki. glTF™ przechowuje każdy trójkąt z unikalnymi wierzchołkami, co ułatwia bezpośrednie ładowanie do GPU, ale prowadzi do zamieszania związanego z duplikacją wierzchołków. https://blender.stackexchange.com/questions/167372/gltf-export-has-twice-the-vertices-it-should/167383#167383
- G4MF pozwala na jedną scenę na plik z jednym węzłem głównym, podczas gdy glTF™ pozwala na wiele scen i wiele węzłów głównych. https://github.com/KhronosGroup/glTF/tree/main/extensions/2.0/Vendor/GODOT_single_root
- Binaria G4MF używają 64-bitowej liczby całkowitej bez znaku do określania rozmiaru plików `.g4b` i ich bloków, zamiast 32-bitowej liczby bez znaku jak `.glb`, co pozwala na pliki większe niż 4 GiB. https://github.com/KhronosGroup/glTF/issues/2114
- G4MF to zupełnie nowy format, podczas gdy glTF™ jest dojrzałym standardem branżowym. Dlatego zalecamy używanie glTF™ dla modeli 3D, a nie 3D w plikach G4MF.

Dodatkowo istnieje wiele szczegółowych różnic między G4MF i glTF™:

- G4MF dodaje nowy wymagany klucz całkowity `"dimension"` do `"asset"`, który MUSI być zdefiniowany, w przeciwnym razie plik jest nieprawidłowy. Oznacza to, że modele 4D MUSZĄ posiadać `{ "asset": { "dimension": 4 } }` w swoich danych JSON.
- Nagłówek asset G4MF zawiera tablice `"extensionsUsed"` i `"extensionsRequired"`. W glTF™ są one zdefiniowane w głównym obiekcie JSON.
- Transformacje węzłów G4MF używają kombinacji `"position"` oraz `"basis"` lub `"rotor"`+`"scale"`, podczas gdy glTF™ używa `"translation"`+`"rotation"`+`"scale"` lub 4x4 `"matrix"`. Oba formaty dopuszczają tylko transformację liniową, co oznacza, że właściwość `"matrix"` w glTF™ zawsze ma wartości (0, 0, 0, 1) w ostatnim wierszu. Ten ostatni wiersz jest przydatny do przesyłania danych do GPU, ale nie ma znaczenia przy wymianie, dlatego nie występuje w G4MF.
- Skala `"scale"` w węźle G4MF nie dopuszcza wartości ujemnych, podczas gdy glTF™ tak. G4MF wymaga użycia `"basis"` do odbić/lustrzanych transformacji, jeśli to konieczne.
- Skala `"scale"` w węźle G4MF może być pojedynczą wartością reprezentującą skalę jednorodną, co jest przydatne dla zwięzłości, zwłaszcza przy bardzo wysokich wymiarach. W glTF™ `"scale"` zawsze jest wektorem 3D.
- Węzły G4MF mają boolean `"visible"`, zapewniając w podstawowej specyfikacji funkcjonalność rozszerzenia glTF™ `KHR_node_visibility`. https://github.com/KhronosGroup/glTF/pull/2410
- Siatki G4MF mają `"surfaces"`, co jest bardziej przyjazną nazwą dla użytkownika. Siatki glTF™ mają `"primitives"`, co jest terminologią używaną w OpenGL™. https://www.khronos.org/opengl/wiki/primitive
- Powierzchnie siatek G4MF jawnie definiują wierzchołki, krawędzie i komórki na powierzchni. Prymitywy siatki glTF™ definiują to wewnątrz `"attributes"` i `"mode"`.
- Powierzchnie siatki G4MF mogą mieć boolean `"polytopeCells"`, zapewniając w podstawowej specyfikacji funkcjonalność rozszerzenia glTF™ `FB_ngon_encoding`. https://github.com/KhronosGroup/glTF/pull/1620
- Materiały G4MF mają kanały, które uogólniają koncepcję oddzielnych właściwości materiału w glTF™. Na przykład, podstawowy kolor glTF™ używa `"baseColorFactor"` i `"baseColorTexture"`, z których ten drugi posiada textureInfo definiujący `"index"` tekstury i `"texCoord"`. Materiały G4MF mają kanały jak `"baseColor"` z tymi właściwościami zjednoczonymi pod nim.
- Światła G4MF są w podstawowej specyfikacji, podczas gdy światła glTF™ są w rozszerzeniu `KHR_lights_punctual`.
- Światła G4MF wymagają uwzględnienia skali węzła, do którego są przypisane, podczas gdy światła glTF™ wymagają ignorowania skali węzła, do którego są przypisane.
- Akcesory G4MF mają ciąg znaków `"primitiveType"` z wartościami jak `"uint8"`, `"int16"`, `"float32"` itd. Akcesory glTF™ mają właściwość `"componentType"`, której wartości są specyficznymi dla OpenGL™ enumeracjami, jak `5121`, `5122`, `5126` itd. Podejście G4MF jest bardziej czytelne i rozszerzalne, podczas gdy podejście glTF™ wymaga od ludzi odniesienia się do tabeli enumeracji, by zrozumieć wartości.
- Akcesory G4MF mają liczbę całkowitą `"vectorSize"`, uogólniając koncepcję akcesora glTF™ `"SCALAR"`, `"VEC2"`, `"VEC3"` i `"VEC4"` na dowolny rozmiar.
- Akcesory G4MF nie mają `"count"` jak akcesory glTF™, liczba jest określana przez rozmiar widoku bufora.
- Akcesory G4MF nie mają właściwości `"normalized"`, `"max"` ani `"min"`, ponieważ nie są one przydatne do wymiany.
- Akcesory G4MF są ciągłe i nie obsługują bycia rzadkimi (sparse), podczas gdy akcesory glTF™ mogą być sparse. Jest to przydatne dla optymalizacji wydajności gotowych do GPU, ale nie jest przydatne do wymiany.
- Widoki bufora G4MF nie mają właściwości `"byteStride"` ani `"target"`, co oznacza, że G4MF nie obsługuje danych przeplatanych (interleaved). Jest to przydatne w glTF™ dla optymalizacji wydajności gotowych do GPU, ale nie jest przydatne do wymiany.
- Binarne bloki G4MF mają 4-bajtowy wskaźnik formatu kompresji, umożliwiając w przyszłości skompresowane binaria G4MF.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---