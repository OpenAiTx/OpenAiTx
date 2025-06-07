# Thuật Toán và Cấu Trúc Dữ Liệu JavaScript

> 🇺🇦 UKRAINE [ĐANG BỊ TẤN CÔNG](https://war.ukraine.ua/) BỞI QUÂN ĐỘI NGA. DÂN THƯỜNG ĐANG BỊ GIẾT HẠI. KHU DÂN CƯ ĐANG BỊ NÉM BOM.
> - Hỗ trợ Ukraine qua:
>   - [Quỹ từ thiện Serhiy Prytula](https://prytulafoundation.org/en/)
>   - [Quỹ từ thiện Come Back Alive](https://savelife.in.ua/en/donate-en/)
>   - [Ngân hàng Quốc gia Ukraine](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - Thông tin thêm tại [war.ukraine.ua](https://war.ukraine.ua/) và [Bộ Ngoại giao Ukraine](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

Kho lưu trữ này chứa các ví dụ về nhiều thuật toán và cấu trúc dữ liệu phổ biến dựa trên JavaScript.

Mỗi thuật toán và cấu trúc dữ liệu đều có README riêng với các giải thích liên quan và liên kết để đọc thêm (bao gồm cả video trên YouTube).

_Đọc tài liệu này bằng các ngôn ngữ khác:_
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

*☝ Lưu ý rằng dự án này chỉ nhằm mục đích học tập và nghiên cứu,
không **khuyến khích** sử dụng cho môi trường sản xuất.*

## Cấu Trúc Dữ Liệu

Cấu trúc dữ liệu là cách tổ chức và lưu trữ dữ liệu trong máy tính để có thể truy cập và sửa đổi hiệu quả. Cụ thể hơn, cấu trúc dữ liệu là tập hợp các giá trị dữ liệu, các mối quan hệ giữa chúng, và các hàm hay phép toán có thể áp dụng lên dữ liệu đó.

Hãy nhớ rằng mỗi loại dữ liệu đều có những mặt ưu và nhược điểm riêng. Bạn nên chú ý đến lý do chọn cấu trúc dữ liệu hơn là cách cài đặt nó.

`B` - Cơ bản, `A` - Nâng cao

* `B` [Danh sách liên kết đơn](src/data-structures/linked-list)
* `B` [Danh sách liên kết đôi](src/data-structures/doubly-linked-list)
* `B` [Hàng đợi](src/data-structures/queue)
* `B` [Ngăn xếp](src/data-structures/stack)
* `B` [Bảng băm](src/data-structures/hash-table)
* `B` [Heap](src/data-structures/heap) - phiên bản heap lớn nhất và nhỏ nhất
* `B` [Hàng đợi ưu tiên](src/data-structures/priority-queue)
* `A` [Trie](src/data-structures/trie)
* `A` [Cây](src/data-structures/tree)
  * `A` [Cây tìm kiếm nhị phân](src/data-structures/tree/binary-search-tree)
  * `A` [Cây AVL](src/data-structures/tree/avl-tree)
  * `A` [Cây Đỏ-Đen](src/data-structures/tree/red-black-tree)
  * `A` [Cây đoạn](src/data-structures/tree/segment-tree) - ví dụ truy vấn min/max/tổng theo đoạn
  * `A` [Cây Fenwick](src/data-structures/tree/fenwick-tree) (Binary Indexed Tree)
* `A` [Đồ thị](src/data-structures/graph) (cả có hướng và vô hướng)
* `A` [Tập hợp rời rạc](src/data-structures/disjoint-set) - cấu trúc dữ liệu hợp-nối hoặc hợp-tìm kiếm
* `A` [Bộ lọc Bloom](src/data-structures/bloom-filter)
* `A` [Bộ nhớ đệm LRU](src/data-structures/lru-cache/) - Bộ nhớ đệm sử dụng gần nhất (LRU)

## Thuật Toán

Thuật toán là một tập hợp các quy tắc xác định rõ ràng cách giải một lớp các bài toán. Nó là tập hợp các quy tắc xác định chính xác một chuỗi các phép toán.

`B` - Cơ bản, `A` - Nâng cao

### Thuật Toán Theo Chủ Đề

* **Toán học**
  * `B` [Phép toán trên bit](src/algorithms/math/bits) - đặt/lấy/cập nhật/xóa bit, nhân/chia cho 2, đổi dấu, v.v.
  * `B` [Số thực dấu phẩy động nhị phân](src/algorithms/math/binary-floating-point) - biểu diễn nhị phân của số thực dấu phẩy động
  * `B` [Giai thừa](src/algorithms/math/factorial)
  * `B` [Số Fibonacci](src/algorithms/math/fibonacci) - phiên bản cổ điển và công thức đóng
  * `B` [Ước số nguyên tố](src/algorithms/math/prime-factors) - tìm ước số nguyên tố và đếm chúng bằng định lý Hardy-Ramanujan
  * `B` [Kiểm tra số nguyên tố](src/algorithms/math/primality-test) (phương pháp thử chia)
  * `B` [Thuật toán Euclid](src/algorithms/math/euclidean-algorithm) - tính ước chung lớn nhất (GCD)
  * `B` [Bội chung nhỏ nhất](src/algorithms/math/least-common-multiple) (LCM)
  * `B` [Sàng Eratosthenes](src/algorithms/math/sieve-of-eratosthenes) - tìm tất cả số nguyên tố nhỏ hơn hoặc bằng N
  * `B` [Kiểm tra lũy thừa của 2](src/algorithms/math/is-power-of-two) - kiểm tra số có phải lũy thừa của 2 không (thuật toán đơn giản và bitwise)
  * `B` [Tam giác Pascal](src/algorithms/math/pascal-triangle)
  * `B` [Số phức](src/algorithms/math/complex-number) - số phức và các phép toán cơ bản
  * `B` [Radian & Độ](src/algorithms/math/radian) - chuyển đổi radian sang độ và ngược lại
  * `B` [Khai triển lũy thừa nhanh](src/algorithms/math/fast-powering)
  * `B` [Phương pháp Horner](src/algorithms/math/horner-method) - đánh giá đa thức
  * `B` [Ma trận](src/algorithms/math/matrix) - ma trận và các phép toán cơ bản (nhân, chuyển vị, v.v.)
  * `B` [Khoảng cách Euclid](src/algorithms/math/euclidean-distance) - khoảng cách giữa hai điểm/vecto/ma trận
  * `A` [Phân hoạch số nguyên](src/algorithms/math/integer-partition)
  * `A` [Căn bậc hai](src/algorithms/math/square-root) - phương pháp Newton
  * `A` [Thuật toán π Liu Hui](src/algorithms/math/liu-hui) - tính xấp xỉ π dựa trên đa giác đều
  * `A` [Biến đổi Fourier rời rạc](src/algorithms/math/fourier-transform) - phân tích hàm thời gian (tín hiệu) thành các tần số cấu thành
* **Tập hợp**
  * `B` [Tích Descartes](src/algorithms/sets/cartesian-product) - tích của nhiều tập hợp
  * `B` [Xáo trộn Fisher–Yates](src/algorithms/sets/fisher-yates) - hoán vị ngẫu nhiên của một dãy hữu hạn
  * `A` [Tập hợp con](src/algorithms/sets/power-set) - tất cả tập con của một tập hợp (bitwise, quay lui, cascading)
  * `A` [Hoán vị](src/algorithms/sets/permutations) (có và không lặp lại)
  * `A` [Tổ hợp](src/algorithms/sets/combinations) (có và không lặp lại)
  * `A` [Dãy con chung dài nhất](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [Dãy tăng dài nhất](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Siêu chuỗi chung ngắn nhất](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [Bài toán balo](src/algorithms/sets/knapsack-problem) - loại "0/1" và "không giới hạn"
  * `A` [Dãy con lớn nhất](src/algorithms/sets/maximum-subarray) - cách "Brute Force" và "Lập trình động" (Kadane's)
  * `A` [Tổ hợp có tổng bằng số cho trước](src/algorithms/sets/combination-sum) - tìm tất cả tổ hợp có tổng bằng số cho trước
* **Xâu ký tự**
  * `B` [Khoảng cách Hamming](src/algorithms/string/hamming-distance) - số vị trí hai chuỗi khác nhau
  * `B` [Chuỗi đối xứng](src/algorithms/string/palindrome) - kiểm tra chuỗi đảo ngược có giống không
  * `A` [Khoảng cách Levenshtein](src/algorithms/string/levenshtein-distance) - số phép biến đổi tối thiểu giữa hai chuỗi
  * `A` [Thuật toán Knuth–Morris–Pratt](src/algorithms/string/knuth-morris-pratt) (KMP) - tìm kiếm chuỗi con (so khớp mẫu)
  * `A` [Thuật toán Z](src/algorithms/string/z-algorithm) - tìm kiếm chuỗi con (so khớp mẫu)
  * `A` [Thuật toán Rabin Karp](src/algorithms/string/rabin-karp) - tìm kiếm chuỗi con
  * `A` [Chuỗi con chung dài nhất](src/algorithms/string/longest-common-substring)
  * `A` [So khớp biểu thức chính quy](src/algorithms/string/regular-expression-matching)
* **Tìm kiếm**
  * `B` [Tìm kiếm tuyến tính](src/algorithms/search/linear-search)
  * `B` [Tìm kiếm nhảy](src/algorithms/search/jump-search) (hoặc tìm kiếm theo khối) - tìm trong mảng đã sắp xếp
  * `B` [Tìm kiếm nhị phân](src/algorithms/search/binary-search) - tìm trong mảng đã sắp xếp
  * `B` [Tìm kiếm nội suy](src/algorithms/search/interpolation-search) - tìm trong mảng đã sắp xếp và phân bố đều
* **Sắp xếp**
  * `B` [Sắp xếp nổi bọt](src/algorithms/sorting/bubble-sort)
  * `B` [Sắp xếp chọn](src/algorithms/sorting/selection-sort)
  * `B` [Sắp xếp chèn](src/algorithms/sorting/insertion-sort)
  * `B` [Sắp xếp heap](src/algorithms/sorting/heap-sort)
  * `B` [Sắp xếp trộn](src/algorithms/sorting/merge-sort)
  * `B` [Sắp xếp nhanh](src/algorithms/sorting/quick-sort) - phiên bản tại chỗ và không tại chỗ
  * `B` [Sắp xếp shell](src/algorithms/sorting/shell-sort)
  * `B` [Sắp xếp đếm](src/algorithms/sorting/counting-sort)
  * `B` [Sắp xếp radix](src/algorithms/sorting/radix-sort)
  * `B` [Sắp xếp theo nhóm](src/algorithms/sorting/bucket-sort)
* **Danh sách liên kết**
  * `B` [Duyệt thuận](src/algorithms/linked-list/traversal)
  * `B` [Duyệt ngược](src/algorithms/linked-list/reverse-traversal)
* **Cây**
  * `B` [Duyệt theo chiều sâu](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [Duyệt theo chiều rộng](src/algorithms/tree/breadth-first-search) (BFS)
* **Đồ thị**
  * `B` [Duyệt theo chiều sâu](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [Duyệt theo chiều rộng](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [Thuật toán Kruskal](src/algorithms/graph/kruskal) - tìm cây khung nhỏ nhất (MST) cho đồ thị vô hướng có trọng số
  * `A` [Thuật toán Dijkstra](src/algorithms/graph/dijkstra) - tìm đường đi ngắn nhất từ một đỉnh tới tất cả các đỉnh
  * `A` [Thuật toán Bellman-Ford](src/algorithms/graph/bellman-ford) - tìm đường đi ngắn nhất từ một đỉnh tới tất cả các đỉnh
  * `A` [Thuật toán Floyd-Warshall](src/algorithms/graph/floyd-warshall) - tìm đường đi ngắn nhất giữa mọi cặp đỉnh
  * `A` [Phát hiện chu trình](src/algorithms/graph/detect-cycle) - cho cả đồ thị có hướng và vô hướng (phiên bản DFS và Disjoint Set)
  * `A` [Thuật toán Prim](src/algorithms/graph/prim) - tìm cây khung nhỏ nhất (MST) cho đồ thị vô hướng có trọng số
  * `A` [Sắp xếp topo](src/algorithms/graph/topological-sorting) - phương pháp DFS
  * `A` [Điểm khớp](src/algorithms/graph/articulation-points) - thuật toán Tarjan (dựa trên DFS)
  * `A` [Cầu](src/algorithms/graph/bridges) - thuật toán dựa trên DFS
  * `A` [Đường đi Euler và Chu trình Euler](src/algorithms/graph/eulerian-path) - thuật toán Fleury - đi qua mỗi cạnh đúng một lần
  * `A` [Chu trình Hamilton](src/algorithms/graph/hamiltonian-cycle) - đi qua mỗi đỉnh đúng một lần
  * `A` [Thành phần liên thông mạnh](src/algorithms/graph/strongly-connected-components) - thuật toán Kosaraju
  * `A` [Bài toán người bán hàng](src/algorithms/graph/travelling-salesman) - đường đi ngắn nhất qua tất cả các thành phố và quay lại điểm xuất phát
* **Mật mã học**
  * `B` [Băm đa thức](src/algorithms/cryptography/polynomial-hash) - hàm băm trượt dựa trên đa thức
  * `B` [Mã Rail Fence](src/algorithms/cryptography/rail-fence-cipher) - thuật toán hoán vị mã hóa thông điệp
  * `B` [Mã Caesar](src/algorithms/cryptography/caesar-cipher) - mã thay thế đơn giản
  * `B` [Mã Hill](src/algorithms/cryptography/hill-cipher) - mã thay thế dựa trên đại số tuyến tính
* **Machine Learning**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 hàm JS minh họa cách máy học hoạt động (lan truyền xuôi/ngược)
  * `B` [k-NN](src/algorithms/ml/knn) - thuật toán phân loại k-láng giềng gần nhất
  * `B` [k-Means](src/algorithms/ml/k-means) - thuật toán phân cụm k-Means
* **Xử lý ảnh**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - thuật toán thay đổi kích thước ảnh theo nội dung
* **Thống kê**
  * `B` [Chọn ngẫu nhiên có trọng số](src/algorithms/statistics/weighted-random) - chọn phần tử ngẫu nhiên dựa trên trọng số
* **Thuật toán tiến hóa**
  * `A` [Thuật toán di truyền](https://github.com/trekhleb/self-parking-car-evolution) - ví dụ áp dụng thuật toán di truyền huấn luyện xe tự đỗ
* **Chưa phân loại**
  * `B` [Tháp Hà Nội](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Xoay ma trận vuông](src/algorithms/uncategorized/square-matrix-rotation) - thuật toán tại chỗ
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game) - quay lui, lập trình động (top-down + bottom-up), tham lam
  * `B` [Đường đi duy nhất](src/algorithms/uncategorized/unique-paths) - quay lui, lập trình động, dựa trên tam giác Pascal
  * `B` [Bẫy mưa trên sân thượng](src/algorithms/uncategorized/rain-terraces) - bài toán giữ nước mưa (lập trình động và vét cạn)
  * `B` [Cầu thang đệ quy](src/algorithms/uncategorized/recursive-staircase) - đếm số cách để leo lên đỉnh (4 cách giải)
  * `B` [Thời điểm tốt nhất để mua bán cổ phiếu](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - chia để trị và một lượt duyệt
  * `B` [Dấu ngoặc hợp lệ](src/algorithms/stack/valid-parentheses) - kiểm tra chuỗi có dấu ngoặc hợp lệ không (dùng stack)
  * `A` [Bài toán N-Queens](src/algorithms/uncategorized/n-queens)
  * `A` [Đường đi của quân mã](src/algorithms/uncategorized/knight-tour)

### Thuật Toán Theo Mô Hình

Một mô hình thuật toán là một phương pháp hoặc cách tiếp cận tổng quát cơ sở cho thiết kế một lớp các thuật toán. Nó là một trừu tượng cao hơn khái niệm thuật toán, giống như thuật toán là một trừu tượng cao hơn chương trình máy tính.

* **Vét cạn (Brute Force)** - xem xét tất cả các khả năng và chọn giải pháp tốt nhất
  * `B` [Tìm kiếm tuyến tính](src/algorithms/search/linear-search)
  * `B` [Bẫy mưa trên sân thượng](src/algorithms/uncategorized/rain-terraces)
  * `B` [Cầu thang đệ quy](src/algorithms/uncategorized/recursive-staircase)
  * `A` [Dãy con lớn nhất](src/algorithms/sets/maximum-subarray)
  * `A` [Bài toán người bán hàng](src/algorithms/graph/travelling-salesman)
  * `A` [Biến đổi Fourier rời rạc](src/algorithms/math/fourier-transform)
* **Tham lam (Greedy)** - luôn chọn phương án tốt nhất tại thời điểm hiện tại, không xét đến tương lai
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `A` [Balo không giới hạn](src/algorithms/sets/knapsack-problem)
  * `A` [Thuật toán Dijkstra](src/algorithms/graph/dijkstra)
  * `A` [Thuật toán Prim](src/algorithms/graph/prim)
  * `A` [Thuật toán Kruskal](src/algorithms/graph/kruskal)
* **Chia để trị (Divide and Conquer)** - chia nhỏ bài toán thành các phần nhỏ hơn rồi giải quyết từng phần
  * `B` [Tìm kiếm nhị phân](src/algorithms/search/binary-search)
  * `B` [Tháp Hà Nội](src/algorithms/uncategorized/hanoi-tower)
  * `B` [Tam giác Pascal](src/algorithms/math/pascal-triangle)
  * `B` [Thuật toán Euclid](src/algorithms/math/euclidean-algorithm)
  * `B` [Sắp xếp trộn](src/algorithms/sorting/merge-sort)
  * `B` [Sắp xếp nhanh](src/algorithms/sorting/quick-sort)
  * `B` [Duyệt DFS trên cây](src/algorithms/tree/depth-first-search)
  * `B` [Duyệt DFS trên đồ thị](src/algorithms/graph/depth-first-search)
  * `B` [Ma trận](src/algorithms/math/matrix)
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Khai triển lũy thừa nhanh](src/algorithms/math/fast-powering)
  * `B` [Thời điểm tốt nhất để mua bán cổ phiếu](src/algorithms/uncategorized/best-time-to-buy-sell-stocks)
  * `A` [Hoán vị](src/algorithms/sets/permutations)
  * `A` [Tổ hợp](src/algorithms/sets/combinations)
  * `A` [Dãy con lớn nhất](src/algorithms/sets/maximum-subarray)
* **Lập trình động (Dynamic Programming)** - xây dựng lời giải dựa trên các lời giải con đã tìm trước đó
  * `B` [Số Fibonacci](src/algorithms/math/fibonacci)
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Đường đi duy nhất](src/algorithms/uncategorized/unique-paths)
  * `B` [Bẫy mưa trên sân thượng](src/algorithms/uncategorized/rain-terraces)
  * `B` [Cầu thang đệ quy](src/algorithms/uncategorized/recursive-staircase)
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving)
  * `A` [Khoảng cách Levenshtein](src/algorithms/string/levenshtein-distance)
  * `A` [Dãy con chung dài nhất](src/algorithms/sets/longest-common-subsequence)
  * `A` [Chuỗi con chung dài nhất](src/algorithms/string/longest-common-substring)
  * `A` [Dãy tăng dài nhất](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [Siêu chuỗi chung ngắn nhất](src/algorithms/sets/shortest-common-supersequence)
  * `A` [Balo 0/1](src/algorithms/sets/knapsack-problem)
  * `A` [Phân hoạch số nguyên](src/algorithms/math/integer-partition)
  * `A` [Dãy con lớn nhất](src/algorithms/sets/maximum-subarray)
  * `A` [Thuật toán Bellman-Ford](src/algorithms/graph/bellman-ford)
  * `A` [Thuật toán Floyd-Warshall](src/algorithms/graph/floyd-warshall)
  * `A` [So khớp biểu thức chính quy](src/algorithms/string/regular-expression-matching)
* **Quay lui (Backtracking)** - giống như vét cạn, thử sinh ra tất cả lời giải, nhưng mỗi lần sinh lời giải, kiểm tra xem có thỏa mãn điều kiện không rồi mới tiếp tục, nếu không thì quay lui và đi theo hướng khác. Thường dùng duyệt DFS trên không gian trạng thái.
  * `B` [Jump Game](src/algorithms/uncategorized/jump-game)
  * `B` [Đường đi duy nhất](src/algorithms/uncategorized/unique-paths)
  * `B` [Tập hợp con](src/algorithms/sets/power-set)
  * `A` [Chu trình Hamilton](src/algorithms/graph/hamiltonian-cycle)
  * `A` [Bài toán N-Queens](src/algorithms/uncategorized/n-queens)
  * `A` [Đường đi của quân mã](src/algorithms/uncategorized/knight-tour)
  * `A` [Tổ hợp có tổng bằng số cho trước](src/algorithms/sets/combination-sum)
* **Nhánh và cận (Branch & Bound)** - ghi nhớ chi phí lời giải thấp nhất tại mỗi bước quay lui, dùng chi phí này làm cận dưới để loại bỏ các lời giải tạm thời có chi phí lớn hơn. Thường dùng duyệt BFS kết hợp với DFS trên cây trạng thái.

## Cách sử dụng kho lưu trữ này

**Cài đặt tất cả các phụ thuộc**

```
npm install
```

**Chạy ESLint**

Bạn có thể chạy để kiểm tra chất lượng mã nguồn.

```
npm run lint
```

**Chạy tất cả các bài kiểm thử**

```
npm test
```

**Chạy kiểm thử theo tên**

```
npm test -- 'LinkedList'
```

**Xử lý sự cố**

Nếu kiểm tra lint hoặc test không thành công, hãy thử xóa thư mục `node_modules` và cài lại npm package:

```
rm -rf ./node_modules
npm i
```

Đồng thời, hãy đảm bảo bạn dùng đúng phiên bản Node (`>=16`). Nếu bạn dùng [nvm](https://github.com/nvm-sh/nvm) để quản lý phiên bản Node, hãy chạy `nvm use` tại thư mục gốc dự án để chọn đúng phiên bản.

**Playground**

Bạn có thể thử nghiệm với cấu trúc dữ liệu và thuật toán trong file `./src/playground/playground.js` và viết kiểm thử trong `./src/playground/__test__/playground.test.js`.

Sau đó, chỉ cần chạy lệnh sau để kiểm tra code playground của bạn hoạt động như mong đợi:

```
npm test -- 'playground'
```

## Thông Tin Hữu Ích

### Tài liệu tham khảo

- [▶ Cấu trúc dữ liệu & thuật toán trên YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 Phác thảo cấu trúc dữ liệu](https://okso.app/showcase/data-structures)

### Ký Hiệu Big O

*Big O* dùng để phân loại các thuật toán dựa vào tốc độ hoặc bộ nhớ yêu cầu khi kích thước đầu vào tăng lên.
Biểu đồ dưới đây thể hiện các bậc tăng trưởng phổ biến của thuật toán theo ký hiệu Big O.

![Big O graphs](./assets/big-o-graph.png)

Nguồn: [Big O Cheat Sheet](http://bigocheatsheet.com/).

Bảng dưới đây liệt kê một số ký hiệu Big O thường dùng và so sánh hiệu suất với các kích thước dữ liệu đầu vào khác nhau.

| Ký hiệu Big O   | Loại        | Tính toán cho 10 phần tử | Tính toán cho 100 phần tử | Tính toán cho 1000 phần tử  |
| --------------- | ----------- | ----------------------- | ------------------------ | --------------------------- |
| **O(1)**        | Hằng số     | 1                       | 1                        | 1                           |
| **O(log N)**    | Logarit     | 3                       | 6                        | 9                           |
| **O(N)**        | Tuyến tính  | 10                      | 100                      | 1000                        |
| **O(N log N)**  | n log(n)    | 30                      | 600                      | 9000                        |
| **O(N^2)**      | Bậc hai     | 100                     | 10000                    | 1000000                     |
| **O(2^N)**      | Lũy thừa    | 1024                    | 1.26e+29                 | 1.07e+301                   |
| **O(N!)**       | Giai thừa   | 3628800                 | 9.3e+157                 | 4.02e+2567                  |

### Độ phức tạp thao tác trên cấu trúc dữ liệu

| Cấu trúc dữ liệu      | Truy cập | Tìm kiếm | Thêm     | Xóa      | Ghi chú  |
| ---------------------|:--------:|:--------:|:--------:|:--------:|:-------- |
| **Mảng**             | 1        | n        | n        | n        |          |
| **Ngăn xếp**         | n        | n        | 1        | 1        |          |
| **Hàng đợi**         | n        | n        | 1        | 1        |          |
| **Danh sách liên kết**| n        | n        | 1        | n        |          |
| **Bảng băm**         | -        | n        | n        | n        | Nếu hàm băm hoàn hảo, chi phí sẽ là O(1) |
| **Cây tìm kiếm nhị phân**| n   | n        | n        | n        | Nếu cây cân bằng, chi phí là O(log(n)) |
| **B-Tree**           | log(n)   | log(n)   | log(n)   | log(n)   |          |
| **Cây Đỏ-Đen**       | log(n)   | log(n)   | log(n)   | log(n)   |          |
| **Cây AVL**          | log(n)   | log(n)   | log(n)   | log(n)   |          |
| **Bộ lọc Bloom**     | -        | 1        | 1        | -        | Có thể trả về dương tính giả khi tìm kiếm |

### Độ phức tạp các thuật toán sắp xếp mảng

| Tên                    | Tốt nhất        | Trung bình          | Tệ nhất             | Bộ nhớ    | Ổn định   | Ghi chú   |
| ---------------------- | :-------------: | :-----------------: | :-----------------: | :-------: | :-------: | :-------- |
| **Sắp xếp nổi bọt**    | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1         | Có        |           |
| **Sắp xếp chèn**       | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1         | Có        |           |
| **Sắp xếp chọn**       | n<sup>2</sup>   | n<sup>2</sup>       | n<sup>2</sup>       | 1         | Không     |           |
| **Sắp xếp heap**       | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | 1         | Không     |           |
| **Sắp xếp trộn**       | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | n         | Có        |           |
| **Sắp xếp nhanh**      | n&nbsp;log(n)   | n&nbsp;log(n)       | n<sup>2</sup>       | log(n)    | Không     | Thường cài đặt tại chỗ với O(log(n)) bộ nhớ stack |
| **Sắp xếp shell**      | n&nbsp;log(n)   | phụ thuộc vào dãy gap| n&nbsp;(log(n))<sup>2</sup>  | 1    | Không     |           |
| **Sắp xếp đếm**        | n + r           | n + r               | n + r               | n + r     | Có        | r - số lớn nhất trong mảng |
| **Sắp xếp radix**      | n * k           | n * k               | n * k               | n + k     | Có        | k - độ dài khóa dài nhất    |

## Nhà tài trợ dự án

> Bạn có thể hỗ trợ dự án này qua ❤️️ [GitHub](https://github.com/sponsors/trekhleb) hoặc ❤️️ [Patreon](https://www.patreon.com/trekhleb).

[Những người đang ủng hộ dự án này](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## Tác giả

[@trekhleb](https://trekhleb.dev)

Một vài [dự án](https://trekhleb.dev/projects/) và [bài viết](https://trekhleb.dev/blog/) khác về JavaScript và thuật toán tại [trekhleb.dev](https://trekhleb.dev)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---