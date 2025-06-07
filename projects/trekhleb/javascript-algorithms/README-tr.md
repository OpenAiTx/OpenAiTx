# JavaScript Algoritmaları ve Veri Yapıları

> 🇺🇦 UKRAYNA [RUS ORDUSU TARAFINDAN SALDIRIYA UĞRUYOR](https://war.ukraine.ua/). SİVİLLER ÖLDÜRÜLÜYOR. YERLEŞİM ALANLARI BOMBALANIYOR.
> - Ukrayna'ya yardım edin:
>   - [Serhiy Prytula Yardım Vakfı](https://prytulafoundation.org/en/)
>   - [Come Back Alive Yardım Vakfı](https://savelife.in.ua/en/donate-en/)
>   - [Ukrayna Merkez Bankası](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - Daha fazla bilgi için [war.ukraine.ua](https://war.ukraine.ua/) ve [Ukrayna Dışişleri Bakanlığı](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

Bu depo, JavaScript tabanlı çok sayıda popüler algoritma ve veri yapısının örneklerini içermektedir.

Her algoritma ve veri yapısının, ilgili açıklamaları ve daha fazla okuma için bağlantıları (YouTube videoları dahil) içeren ayrı bir README dosyası vardır.

_Bunu diğer dillerde okuyun:_
[_简体中文_](README.zh-CN.md),
[_繁體中文_](README.zh-TW.md),
[_한국어_](README.ko-KR.md),
[_日本語_](README.ja-JP.md),
[_Polski_](README.pl-PL.md),
[_Français_](README.fr-FR.md),
[_Español_](README.es-ES.md),
[_Português_](README.pt-BR.md),
[_Русский_](README.ru-RU.md),
[_Türkçe_](README.tr-TR.md),
[_Italiano_](README.it-IT.md),
[_Bahasa Indonesia_](README.id-ID.md),
[_Українська_](README.uk-UA.md),
[_Arabic_](README.ar-AR.md),
[_Tiếng Việt_](README.vi-VN.md),
[_Deutsch_](README.de-DE.md),
[_Uzbek_](README.uz-UZ.md),
[_עברית_](README.he-IL.md)

*☝ Bu projenin sadece öğrenme ve araştırma amaçlı olduğunu ve **üretimde kullanılmak için tasarlanmadığını** unutmayın.*

## Veri Yapıları

Veri yapısı, verilerin bilgisayarda belirli bir şekilde düzenlenmesi ve saklanmasıdır; böylece veriye verimli bir şekilde erişilip değiştirilebilir. Daha spesifik olarak, bir veri yapısı; veri değerlerinin, aralarındaki ilişkilerin ve veriye uygulanabilen fonksiyonların veya işlemlerin bir bütünüdür.

Her veri yapısının kendi avantaj ve dezavantajları olduğunu unutmayın. Bir veri yapısını nasıl uygulayacağınızdan çok neden seçtiğinize dikkat etmelisiniz.

`B` - Başlangıç, `A` - İleri

* `B` [Bağlı Liste](src/data-structures/linked-list)
* `B` [Çift Yönlü Bağlı Liste](src/data-structures/doubly-linked-list)
* `B` [Kuyruk](src/data-structures/queue)
* `B` [Yığın](src/data-structures/stack)
* `B` [Hash Tablosu](src/data-structures/hash-table)
* `B` [Heap](src/data-structures/heap) - maksimum ve minimum heap versiyonları
* `B` [Öncelikli Kuyruk](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [Ağaç](src/data-structures/tree)
  * `A` [İkili Arama Ağacı](src/data-structures/tree/binary-search-tree)
  * `A` [AVL Ağacı](src/data-structures/tree/avl-tree)
  * `A` [Kırmızı-Siyah Ağaç](src/data-structures/tree/red-black-tree)
  * `A` [Segment Ağacı](src/data-structures/tree/segment-tree) - minimum/maksimum/toplam aralık sorguları örnekleriyle
  * `A` [Fenwick Ağacı](src/data-structures/tree/fenwick-tree) (İkili İndeksli Ağaç)
* `A` [Graf](src/data-structures/graph) (yönlü ve yönsüz)
* `A` [Ayrık Küme](src/data-structures/disjoint-set) - birleştir-bul veri yapısı
* `A` [Bloom Filtre](src/data-structures/bloom-filter)
* `A` [LRU Cache](src/data-structures/lru-cache/) - En Son Kullanılan (LRU) önbellek

## Algoritmalar

Bir algoritma, bir problem sınıfını nasıl çözeceğini açıkça tanımlayan bir spesifikasyondur. Bir dizi işlemi kesin kurallarla tanımlar.

`B` - Başlangıç, `A` - İleri

### Konuya Göre Algoritmalar

* **Matematik**
  * `B` [Bit Manipülasyonu](src/algorithms/math/bits) - bit ayarla/oku/güncelle/sil, ikiyle çarp/böl, negatif yap vb.
  * `B` [İkili Kayan Nokta](src/algorithms/math/binary-floating-point) - kayan noktalı sayıların ikili gösterimi.
  * `B` [Faktöriyel](src/algorithms/math/factorial)
  * `B` [Fibonacci Sayısı](src/algorithms/math/fibonacci) - klasik ve kapalı formda versiyonlar
  * `B` [Asal Çarpanlar](src/algorithms/math/prime-factors) - asal çarpanları bulma ve Hardy-Ramanujan teoremiyle sayma
  * `B` [Asallık Testi](src/algorithms/math/primality-test) (bölme yöntemi)
  * `B` [Öklid Algoritması](src/algorithms/math/euclidean-algorithm) - En Büyük Ortak Bölen (GCD) hesaplama
  * `B` [En Küçük Ortak Kat](src/algorithms/math/least-common-multiple) (LCM)
  * `B` [Eratosthenes Eleği](src/algorithms/math/sieve-of-eratosthenes) - belirli bir sınıra kadar tüm asal sayıları bulma
  * `B` [İki Kuvveti mi?](src/algorithms/math/is-power-of-two) - bir sayının iki kuvveti olup olmadığını kontrol etme (naif ve bit işlemleriyle)
  * `B` [Pascal Üçgeni](src/algorithms/math/pascal-triangle)
  * `B` [Karmaşık Sayı](src/algorithms/math/complex-number) - karmaşık sayılar ve temel işlemleri
  * `B` [Radyan & Derece](src/algorithms/math/radian) - radyan-derece dönüşümü
  * `B` [Hızlı Üs Alma](src/algorithms/math/fast-powering)
  * `B` [Horner Yöntemi](src/algorithms/math/horner-method) - polinom değerlendirme
  * `B` [Matrisler](src/algorithms/math/matrix) - matrisler ve temel matris işlemleri (çarpma, transpozisyon vb.)
  * `B` [Öklid Uzaklığı](src/algorithms/math/euclidean-distance) - iki nokta/vektör/matris arasındaki mesafe
  * `A` [Tamsayı Bölme](src/algorithms/math/integer-partition)
  * `A` [Karekök](src/algorithms/math/square-root) - Newton yöntemi
  * `A` [Liu Hui π Algoritması](src/algorithms/math/liu-hui) - N-genler ile π yaklaşık hesaplama
  * `A` [Ayrık Fourier Dönüşümü](src/algorithms/math/fourier-transform) - bir zaman fonksiyonunu (sinyali) frekanslara ayırma
* **Kümeler**
  * `B` [Kartezyen Çarpımı](src/algorithms/sets/cartesian-product) - çoklu kümelerin çarpımı
  * `B` [Fisher–Yates Karıştırma](src/algorithms/sets/fisher-yates) - sonlu bir dizinin rastgele permütasyonu
  * `A` [Kuvvet Kümesi](src/algorithms/sets/power-set) - bir kümenin tüm alt kümeleri (bit işlemi, backtracking ve kademeli çözümler)
  * `A` [Permütasyonlar](src/algorithms/sets/permutations) (tekrarlı ve tekrarsız)
  * `A` [Kombinasyonlar](src/algorithms/sets/combinations) (tekrarlı ve tekrarsız)
  * `A` [En Uzun Ortak Alt Dizi](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [En Uzun Artan Alt Dizi](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [En Kısa Ortak Süper Dizi](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Sırt Çantası Problemi](src/algorithms/sets/knapsack-problem) - "0/1" ve "Sınırsız" versiyonları
  * `A` [Maksimum Alt Dizi](src/algorithms/sets/maximum-subarray) - "Kaba Kuvvet" ve "Dinamik Programlama" (Kadane) versiyonları
  * `A` [Kombinasyon Toplamı](src/algorithms/sets/combination-sum) - belirli bir toplamı oluşturan tüm kombinasyonları bulma
* **Diziler**
  * `B` [Hamming Mesafesi](src/algorithms/string/hamming-distance) - sembollerin farklı olduğu pozisyon sayısı
  * `B` [Palindrom](src/algorithms/string/palindrome) - bir dizinin tersten de aynı olup olmadığını kontrol etme
  * `A` [Levenshtein Mesafesi](src/algorithms/string/levenshtein-distance) - iki dizi arasındaki minimum düzenleme mesafesi
  * `A` [Knuth–Morris–Pratt Algoritması](src/algorithms/string/knuth-morris-pratt) (KMP Algoritması) - alt dizi arama (desen eşleme)
  * `A` [Z Algoritması](src/algorithms/string/z-algorithm) - alt dizi arama (desen eşleme)
  * `A` [Rabin Karp Algoritması](src/algorithms/string/rabin-karp) - alt dizi arama
  * `A` [En Uzun Ortak Alt Dizi](src/algorithms/string/longest-common-substring)
  * `A` [Düzenli İfade Eşleme](src/algorithms/string/regular-expression-matching)
* **Aramalar**
  * `B` [Doğrusal Arama](src/algorithms/search/linear-search)
  * `B` [Atlama Araması](src/algorithms/search/jump-search) (veya Blok Arama) - sıralı dizide arama
  * `B` [İkili Arama](src/algorithms/search/binary-search) - sıralı dizide arama
  * `B` [Enterpolasyon Araması](src/algorithms/search/interpolation-search) - düzgün dağıtılmış sıralı dizide arama
* **Sıralama**
  * `B` [Kabarcık Sıralama](src/algorithms/sorting/bubble-sort)
  * `B` [Seçmeli Sıralama](src/algorithms/sorting/selection-sort)
  * `B` [Eklemeli Sıralama](src/algorithms/sorting/insertion-sort)
  * `B` [Heap Sıralama](src/algorithms/sorting/heap-sort)
  * `B` [Birleştirme Sıralama](src/algorithms/sorting/merge-sort)
  * `B` [Hızlı Sıralama](src/algorithms/sorting/quick-sort) - yerinde ve yerinde olmayan uygulamalar
  * `B` [Kabuk Sıralama](src/algorithms/sorting/shell-sort)
  * `B` [Sayma Sıralama](src/algorithms/sorting/counting-sort)
  * `B` [Radiks Sıralama](src/algorithms/sorting/radix-sort)
  * `B` [Kova Sıralama](src/algorithms/sorting/bucket-sort)
* **Bağlı Listeler**
  * `B` [Düz Traversal](src/algorithms/linked-list/traversal)
  * `B` [Ters Traversal](src/algorithms/linked-list/reverse-traversal)
* **Ağaçlar**
  * `B` [Derinlik Öncelikli Arama](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Genişlik Öncelikli Arama](src/algorithms/tree/breadth-first-search) (BFS)
* **Grafikler**
  * `B` [Derinlik Öncelikli Arama](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Genişlik Öncelikli Arama](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [Kruskal Algoritması](src/algorithms/graph/kruskal) - ağırlıklı yönsüz graf için Minimum Örtücü Ağaç (MST) bulma
  * `A` [Dijkstra Algoritması](src/algorithms/graph/dijkstra) - tek bir düğümden tüm düğümlere en kısa yolları bulma
  * `A` [Bellman-Ford Algoritması](src/algorithms/graph/bellman-ford) - tek bir düğümden tüm düğümlere en kısa yolları bulma
  * `A` [Floyd-Warshall Algoritması](src/algorithms/graph/floyd-warshall) - tüm düğüm çiftleri arasındaki en kısa yolları bulma
  * `A` [Döngü Tespiti](src/algorithms/graph/detect-cycle) - hem yönlü hem yönsüz grafikler için (DFS ve Ayrık Küme tabanlı)
  * `A` [Prim Algoritması](src/algorithms/graph/prim) - ağırlıklı yönsüz graf için Minimum Örtücü Ağaç (MST) bulma
  * `A` [Topolojik Sıralama](src/algorithms/graph/topological-sorting) - DFS yöntemi
  * `A` [Eklem Noktaları](src/algorithms/graph/articulation-points) - Tarjan algoritması (DFS tabanlı)
  * `A` [Köprüler](src/algorithms/graph/bridges) - DFS tabanlı algoritma
  * `A` [Euler Yolu ve Euler Devresi](src/algorithms/graph/eulerian-path) - Fleury algoritması - Her kenarı tam olarak bir kez ziyaret et
  * `A` [Hamilton Döngüsü](src/algorithms/graph/hamiltonian-cycle) - Her düğümü tam olarak bir kez ziyaret et
  * `A` [Güçlü Bağlantılı Bileşenler](src/algorithms/graph/strongly-connected-components) - Kosaraju algoritması
  * `A` [Gezgin Satıcı Problemi](src/algorithms/graph/travelling-salesman) - her şehri ziyaret edip başlangıç noktasına dönen en kısa yol
* **Kriptografi**
  * `B` [Polinom Hash](src/algorithms/cryptography/polynomial-hash) - polinom tabanlı kayan hash fonksiyonu
  * `B` [Raylı Çit Şifrelemesi](src/algorithms/cryptography/rail-fence-cipher) - mesajları şifrelemek için bir transpozisyon şifre algoritması
  * `B` [Sezar Şifrelemesi](src/algorithms/cryptography/caesar-cipher) - basit yerine koyma şifresi
  * `B` [Hill Şifrelemesi](src/algorithms/cryptography/hill-cipher) - doğrusal cebir tabanlı yerine koyma şifresi
* **Makine Öğrenmesi**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - makinelerin nasıl öğrenebileceğini gösteren 7 basit JS fonksiyonu (ileri/geri yayılım)
  * `B` [k-NN](src/algorithms/ml/knn) - k-en yakın komşu sınıflandırma algoritması
  * `B` [k-Ortalamalar](src/algorithms/ml/k-means) - k-Ortalamalar kümeleme algoritması
* **Görüntü İşleme**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - içerik duyarlı görüntü yeniden boyutlandırma algoritması
* **İstatistik**
  * `B` [Ağırlıklı Rastgele](src/algorithms/statistics/weighted-random) - listedeki elemanlardan ağırlıklarına göre rastgele seçim
* **Evrimsel Algoritmalar**
  * `A` [Genetik algoritma](https://github.com/trekhleb/self-parking-car-evolution) - genetik algoritmanın kendini park eden arabaların eğitilmesinde nasıl kullanılabileceğine dair örnek
* **Sınıflandırılmamış**
  * `B` [Hanoi Kulesi](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Kare Matris Döndürme](src/algorithms/uncategorized/square-matrix-rotation) - yerinde algoritma
  * `B` [Atlama Oyunu](src/algorithms/uncategorized/jump-game) - backtracking, dinamik programlama (yukarıdan aşağıya + aşağıdan yukarıya) ve açgözlü örnekler
  * `B` [Benzersiz Yollar](src/algorithms/uncategorized/unique-paths) - backtracking, dinamik programlama ve Pascal Üçgeni tabanlı örnekler
  * `B` [Yağmur Terasları](src/algorithms/uncategorized/rain-terraces) - yağmur suyu toplama problemi (dinamik programlama ve kaba kuvvet versiyonları)
  * `B` [Özyinelemeli Merdiven](src/algorithms/uncategorized/recursive-staircase) - zirveye ulaşmanın kaç yolu olduğunu sayma (4 çözüm)
  * `B` [Hisse Alım Satımı için En İyi Zaman](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - böl ve yönet ve tek geçiş örnekleri
  * `B` [Geçerli Parantezler](src/algorithms/stack/valid-parentheses) - bir dizide geçerli parantez olup olmadığını kontrol etme (yığın kullanarak)
  * `A` [N-Queens Problemi](src/algorithms/uncategorized/n-queens)
  * `A` [Atın Turu](src/algorithms/uncategorized/knight-tour)

### Paradigma Göre Algoritmalar

Bir algoritmik paradigma, bir algoritma sınıfının tasarımının temelini oluşturan genel bir yöntem veya yaklaşımdır. Bu, bir algoritmanın soyutlamasından daha yüksek bir soyutlamadır, tıpkı algoritmanın bilgisayar programından daha yüksek bir soyutlama olması gibi.

* **Kaba Kuvvet** - tüm olasılıkları gözden geçirir ve en iyi çözümü seçer
  * `B` [Doğrusal Arama](src/algorithms/search/linear-search)
  * `B` [Yağmur Terasları](src/algorithms/uncategorized/rain-terraces) - yağmur suyu toplama problemi
  * `B` [Özyinelemeli Merdiven](src/algorithms/uncategorized/recursive-staircase) - zirveye ulaşmanın kaç yolu olduğunu sayma
  * `A` [Maksimum Alt Dizi](src/algorithms/sets/maximum-subarray)
  * `A` [Gezgin Satıcı Problemi](src/algorithms/graph/travelling-salesman) - her şehri ziyaret edip başlangıç noktasına dönen en kısa yol
  * `A` [Ayrık Fourier Dönüşümü](src/algorithms/math/fourier-transform) - bir zaman fonksiyonunu (sinyali) frekanslara ayırma
* **Açgözlü** - mevcut anda en iyi seçeneği seçer, geleceği dikkate almaz
  * `B` [Atlama Oyunu](src/algorithms/uncategorized/jump-game)
  * `A` [Sınırsız Sırt Çantası Problemi](src/algorithms/sets/knapsack-problem)
  * `A` [Dijkstra Algoritması](src/algorithms/graph/dijkstra) - tüm graf düğümlerine en kısa yolu bulma
  * `A` [Prim Algoritması](src/algorithms/graph/prim) - ağırlıklı yönsüz graf için Minimum Örtücü Ağaç (MST) bulma
  * `A` [Kruskal Algoritması](src/algorithms/graph/kruskal) - ağırlıklı yönsüz graf için Minimum Örtücü Ağaç (MST) bulma
* **Böl ve Yönet** - problemi daha küçük parçalara böler ve bu parçaları çözer
  * `B` [İkili Arama](src/algorithms/search/binary-search)
  * `B` [Hanoi Kulesi](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Pascal Üçgeni](src/algorithms/math/pascal-triangle)
  * `B` [Öklid Algoritması](src/algorithms/math/euclidean-algorithm) - En Büyük Ortak Bölen (GCD) hesaplama
  * `B` [Birleştirme Sıralama](src/algorithms/sorting/merge-sort)
  * `B` [Hızlı Sıralama](src/algorithms/sorting/quick-sort)
  * `B` [Ağaç Derinlik Öncelikli Arama](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Graf Derinlik Öncelikli Arama](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Matrisler](src/algorithms/math/matrix) - farklı şekillerde matris oluşturma ve dolaşma
  * `B` [Atlama Oyunu](src/algorithms/uncategorized/jump-game)
  * `B` [Hızlı Üs Alma](src/algorithms/math/fast-powering)
  * `B` [Hisse Alım Satımı için En İyi Zaman](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - böl ve yönet ve tek geçiş örnekleri
  * `A` [Permütasyonlar](src/algorithms/sets/permutations) (tekrarlı ve tekrarsız)
  * `A` [Kombinasyonlar](src/algorithms/sets/combinations) (tekrarlı ve tekrarsız)
  * `A` [Maksimum Alt Dizi](src/algorithms/sets/maximum-subarray)
* **Dinamik Programlama** - daha önce bulunan alt çözümleri kullanarak çözümü oluşturur
  * `B` [Fibonacci Sayısı](src/algorithms/math/fibonacci)
  * `B` [Atlama Oyunu](src/algorithms/uncategorized/jump-game)
  * `B` [Benzersiz Yollar](src/algorithms/uncategorized/unique-paths)
  * `B` [Yağmur Terasları](src/algorithms/uncategorized/rain-terraces) - yağmur suyu toplama problemi
  * `B` [Özyinelemeli Merdiven](src/algorithms/uncategorized/recursive-staircase) - zirveye ulaşmanın kaç yolu olduğunu sayma
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - içerik duyarlı görüntü yeniden boyutlandırma algoritması
  * `A` [Levenshtein Mesafesi](src/algorithms/string/levenshtein-distance) - iki dizi arasındaki minimum düzenleme mesafesi
  * `A` [En Uzun Ortak Alt Dizi](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [En Uzun Ortak Alt Dizi](src/algorithms/string/longest-common-substring)
  * `A` [En Uzun Artan Alt Dizi](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [En Kısa Ortak Süper Dizi](src/algorithms/sets/shortest-common-supersequence)
  * `A` [0/1 Sırt Çantası Problemi](src/algorithms/sets/knapsack-problem)
  * `A` [Tamsayı Bölme](src/algorithms/math/integer-partition)
  * `A` [Maksimum Alt Dizi](src/algorithms/sets/maximum-subarray)
  * `A` [Bellman-Ford Algoritması](src/algorithms/graph/bellman-ford) - tüm graf düğümlerine en kısa yolu bulma
  * `A` [Floyd-Warshall Algoritması](src/algorithms/graph/floyd-warshall) - tüm düğüm çiftleri arasındaki en kısa yolları bulma
  * `A` [Düzenli İfade Eşleme](src/algorithms/string/regular-expression-matching)
* **Backtracking** - kaba kuvvet gibi, tüm olası çözümleri üretmeyi dener, ancak her seferinde bir sonraki çözümü üretirken tüm koşulları sağlayıp sağlamadığını test eder ve yalnızca sağlanıyorsa devam eder. Aksi takdirde geri adım atar ve farklı bir yol dener. Genellikle durum-uzayı üzerinde DFS dolaşımı kullanılır.
  * `B` [Atlama Oyunu](src/algorithms/uncategorized/jump-game)
  * `B` [Benzersiz Yollar](src/algorithms/uncategorized/unique-paths)
  * `B` [Kuvvet Kümesi](src/algorithms/sets/power-set) - bir kümenin tüm alt kümeleri
  * `A` [Hamilton Döngüsü](src/algorithms/graph/hamiltonian-cycle) - Her düğümü tam olarak bir kez ziyaret et
  * `A` [N-Queens Problemi](src/algorithms/uncategorized/n-queens)
  * `A` [Atın Turu](src/algorithms/uncategorized/knight-tour)
  * `A` [Kombinasyon Toplamı](src/algorithms/sets/combination-sum) - belirli bir toplamı oluşturan tüm kombinasyonları bulma
* **Dal & Sınır (Branch & Bound)** - backtracking aramasının her aşamasında şimdiye kadar bulunan en düşük maliyetli çözümü hatırlar ve şimdiye kadar bulunan en düşük maliyetli çözümün maliyetini, problemi en düşük maliyetle çözmenin alt sınırı olarak kullanır; böylece şimdiye kadar bulunan en düşük maliyetten daha yüksek maliyetli kısmi çözümleri eler. Genellikle BFS ve DFS dolaşımı birlikte kullanılır.

## Bu depoyu nasıl kullanırsınız?

**Tüm bağımlılıkları kurun**

```
npm install
```

**ESLint'i çalıştırın**

Kod kalitesini kontrol etmek için çalıştırabilirsiniz.

```
npm run lint
```

**Tüm testleri çalıştırın**

```
npm test
```

**İsme göre test çalıştırma**

```
npm test -- 'LinkedList'
```

**Sorun Giderme**

Eğer lint veya test işlemleri başarısız olursa, `node_modules` klasörünü silip npm paketlerini tekrar yüklemeyi deneyin:

```
rm -rf ./node_modules
npm i
```

Ayrıca, doğru Node sürümünü (`>=16`) kullandığınızdan emin olun. [nvm](https://github.com/nvm-sh/nvm) ile Node sürüm yönetimi yapıyorsanız, projenin kök klasöründe `nvm use` komutunu çalıştırabilirsiniz ve doğru sürüm seçilecektir.

**Oyun Alanı**

`./src/playground/playground.js` dosyasında veri yapıları ve algoritmalarla oynayabilir ve bunun için `./src/playground/__test__/playground.test.js` dosyasında testler yazabilirsiniz.

Ardından, oyun alanı kodunuzun beklendiği gibi çalışıp çalışmadığını test etmek için aşağıdaki komutu çalıştırın:

```
npm test -- 'playground'
```

## Faydalı Bilgiler

### Kaynaklar

- [▶ YouTube'da Veri Yapıları ve Algoritmalar](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Veri Yapısı Çizimleri](https://okso.app/showcase/data-structures)

### Big O Gösterimi

*Big O gösterimi*, algoritmaların çalışma zamanı veya bellek gereksinimlerinin, giriş boyutu büyüdükçe nasıl değiştiğini sınıflandırmak için kullanılır.
Aşağıdaki grafikte, algoritmaların büyüme sıralarının Big O gösterimiyle en yaygın olanlarını bulabilirsiniz.

![Big O grafikleri](./assets/big-o-graph.png)

Kaynak: [Big O Cheat Sheet](http://bigocheatsheet.com/).

Aşağıda, en çok kullanılan bazı Big O gösterimleri ve farklı giriş veri boyutlarına göre performans karşılaştırmaları verilmiştir.

| Big O Gösterimi | Tür         | 10 eleman için işlemler | 100 eleman için işlemler | 1000 eleman için işlemler |
| --------------- | ----------- | ---------------------- | ----------------------- | ------------------------- |
| **O(1)**        | Sabit       | 1                      | 1                       | 1                         |
| **O(log N)**    | Logaritmik  | 3                      | 6                       | 9                         |
| **O(N)**        | Doğrusal    | 10                     | 100                     | 1000                      |
| **O(N log N)**  | n log(n)    | 30                     | 600                     | 9000                      |
| **O(N^2)**      | Kareli      | 100                    | 10000                   | 1000000                   |
| **O(2^N)**      | Üstel       | 1024                   | 1.26e+29                | 1.07e+301                 |
| **O(N!)**       | Faktöriyel  | 3628800                | 9.3e+157                | 4.02e+2567                |

### Veri Yapısı İşlem Karmaşıklıkları

| Veri Yapısı            | Erişim | Arama  | Ekleme | Silme   | Yorumlar  |
| ---------------------- | :----: | :----: | :----: | :-----: | :-------- |
| **Dizi**               | 1      | n      | n      | n       |           |
| **Yığın**              | n      | n      | 1      | 1       |           |
| **Kuyruk**             | n      | n      | 1      | 1       |           |
| **Bağlı Liste**        | n      | n      | 1      | n       |           |
| **Hash Tablosu**       | -      | n      | n      | n       | Mükemmel hash fonksiyonu ile O(1) olabilir |
| **İkili Arama Ağacı**  | n      | n      | n      | n       | Dengeli ağaçta O(log(n)) olur |
| **B-Ağacı**            | log(n) | log(n) | log(n) | log(n)  |           |
| **Kırmızı-Siyah Ağaç** | log(n) | log(n) | log(n) | log(n)  |           |
| **AVL Ağacı**          | log(n) | log(n) | log(n) | log(n)  |           |
| **Bloom Filtre**       | -      | 1      | 1      | -       | Aramada yanlış pozitifler mümkündür |

### Dizi Sıralama Algoritmaları Karmaşıklıkları

| Adı                    | En İyi        | Ortalama            | En Kötü              | Bellek    | Kararlı   | Yorumlar  |
| ---------------------- | :-----------: | :-----------------: | :------------------: | :-------: | :-------: | :-------- |
| **Kabarcık sıralama**  | n             | n<sup>2</sup>       | n<sup>2</sup>        | 1         | Evet      |           |
| **Eklemeli sıralama**  | n             | n<sup>2</sup>       | n<sup>2</sup>        | 1         | Evet      |           |
| **Seçmeli sıralama**   | n<sup>2</sup> | n<sup>2</sup>       | n<sup>2</sup>        | 1         | Hayır     |           |
| **Heap sıralama**      | n&nbsp;log(n) | n&nbsp;log(n)       | n&nbsp;log(n)        | 1         | Hayır     |           |
| **Birleştirme sıralama**| n&nbsp;log(n)| n&nbsp;log(n)       | n&nbsp;log(n)        | n         | Evet      |           |
| **Hızlı sıralama**     | n&nbsp;log(n) | n&nbsp;log(n)       | n<sup>2</sup>        | log(n)    | Hayır     | Genellikle O(log(n)) yığın alanı ile yerinde yapılır |
| **Kabuk sıralama**     | n&nbsp;log(n) | aralığa bağlı       | n&nbsp;(log(n))<sup>2</sup>| 1    | Hayır     |           |
| **Sayma sıralama**     | n + r         | n + r               | n + r                | n + r     | Evet      | r - dizideki en büyük sayı |
| **Radiks sıralama**    | n * k         | n * k               | n * k                | n + k     | Evet      | k - en uzun anahtarın uzunluğu |

## Proje Destekçileri

> Bu projeye ❤️️ [GitHub](https://github.com/sponsors/trekhleb) veya ❤️️ [Patreon](https://www.patreon.com/trekhleb) üzerinden destek olabilirsiniz.

[Bu projeyi destekleyenler](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## Yazar

[@trekhleb](https://trekhleb.dev)

JavaScript ve algoritmalar hakkında daha fazla [proje](https://trekhleb.dev/projects/) ve [makale](https://trekhleb.dev/blog/) için [trekhleb.dev](https://trekhleb.dev) adresini ziyaret edin.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---