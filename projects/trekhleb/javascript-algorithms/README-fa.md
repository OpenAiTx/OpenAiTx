# الگوریتم‌ها و ساختمان‌های داده جاوااسکریپت

> 🇺🇦 اوکراین [مورد حمله](https://war.ukraine.ua/) ارتش روسیه قرار گرفته است. غیرنظامیان کشته می‌شوند. مناطق مسکونی بمباران می‌شوند.
> - حمایت از اوکراین از طریق:
>   - [بنیاد خیریه سرگی پریتولا](https://prytulafoundation.org/en/)
>   - [بنیاد خیریه Come Back Alive](https://savelife.in.ua/en/donate-en/)
>   - [بانک ملی اوکراین](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - اطلاعات بیشتر در [war.ukraine.ua](https://war.ukraine.ua/) و [وزارت خارجه اوکراین](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

این مخزن شامل نمونه‌هایی مبتنی بر جاوااسکریپت از بسیاری از الگوریتم‌ها و ساختمان‌های داده محبوب است.

هر الگوریتم و ساختمان داده README جداگانه خود را با توضیحات مرتبط و پیوندهایی برای مطالعه بیشتر (شامل ویدئوهای یوتیوب) دارد.

_این را به زبان‌های دیگر بخوانید:_
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

*☝ توجه داشته باشید که این پروژه صرفاً برای اهداف یادگیری و تحقیقاتی است و برای استفاده در تولید (Production) **مناسب نیست**.*

## ساختمان‌های داده

ساختمان داده روشی خاص برای سازماندهی و ذخیره داده در رایانه است تا بتوان به آن به طور مؤثر دسترسی پیدا کرد و آن را تغییر داد. به طور دقیق‌تر، ساختمان داده مجموعه‌ای از مقادیر داده، روابط بین آن‌ها و توابع یا عملیات‌هایی است که می‌توان روی داده اعمال کرد.

به یاد داشته باشید که هر ساختمان داده مزایا و معایب خاص خود را دارد. و باید بیشتر به این توجه کنید که چرا یک ساختمان داده خاص را انتخاب می‌کنید تا اینکه چطور آن را پیاده‌سازی کنید.

`B` - مبتدی، `A` - پیشرفته

* `B` [لیست پیوندی](src/data-structures/linked-list)
* `B` [لیست پیوندی دوطرفه](src/data-structures/doubly-linked-list)
* `B` [صف](src/data-structures/queue)
* `B` [پشته](src/data-structures/stack)
* `B` [جدول هش](src/data-structures/hash-table)
* `B` [هیپ](src/data-structures/heap) - نسخه‌های هیپ بیشینه و کمینه
* `B` [صف اولویت‌دار](src/data-structures/priority-queue)
* `A` [تری (Trie)](src/data-structures/trie)
* `A` [درخت](src/data-structures/tree)
  * `A` [درخت جستجوی دودویی](src/data-structures/tree/binary-search-tree)
  * `A` [درخت AVL](src/data-structures/tree/avl-tree)
  * `A` [درخت قرمز-سیاه](src/data-structures/tree/red-black-tree)
  * `A` [درخت بازه‌ای](src/data-structures/tree/segment-tree) - با مثال‌های کوئری بازه‌ای min/max/sum
  * `A` [درخت فن‌ویک](src/data-structures/tree/fenwick-tree) (درخت نمایه‌گذاری دودویی)
* `A` [گراف](src/data-structures/graph) (هم گراف‌های جهت‌دار و هم بدون جهت)
* `A` [مجموع جدا (Disjoint Set)](src/data-structures/disjoint-set) - ساختمان داده union–find یا merge–find set
* `A` [فیلتر بلوم](src/data-structures/bloom-filter)
* `A` [کش LRU](src/data-structures/lru-cache/) - کش کمترین استفاده‌شده اخیر

## الگوریتم‌ها

الگوریتم یک مشخصه بدون ابهام برای حل یک دسته از مسائل است. الگوریتم مجموعه‌ای از قواعد است که دقیقاً یک توالی عملیات را تعریف می‌کند.

`B` - مبتدی، `A` - پیشرفته

### الگوریتم‌ها بر اساس موضوع

* **ریاضی**
  * `B` [دست‌کاری بیت](src/algorithms/math/bits) - تنظیم/دریافت/به‌روزرسانی/پاک‌کردن بیت‌ها، ضرب/تقسیم بر دو، منفی‌کردن و غیره
  * `B` [اعداد اعشاری دودویی](src/algorithms/math/binary-floating-point) - نمایش دودویی اعداد اعشاری
  * `B` [فاکتوریل](src/algorithms/math/factorial)
  * `B` [اعداد فیبوناچی](src/algorithms/math/fibonacci) - نسخه‌های کلاسیک و فرم بسته
  * `B` [عوامل اول](src/algorithms/math/prime-factors) - یافتن عوامل اول و شمارش آن‌ها با قضیه هاردی-رامانوجان
  * `B` [تست اول بودن](src/algorithms/math/primality-test) (روش تقسیم آزمایشی)
  * `B` [الگوریتم اقلیدسی](src/algorithms/math/euclidean-algorithm) - محاسبه بزرگ‌ترین مقسوم‌علیه مشترک (GCD)
  * `B` [کمترین مضرب مشترک](src/algorithms/math/least-common-multiple) (LCM)
  * `B` [غربال اراتوستن](src/algorithms/math/sieve-of-eratosthenes) - یافتن تمامی اعداد اول تا حد معین
  * `B` [آیا توان دو است؟](src/algorithms/math/is-power-of-two) - بررسی اینکه عدد توان دو است یا نه (روش ساده و بیت)
  * `B` [مثلث پاسکال](src/algorithms/math/pascal-triangle)
  * `B` [عدد مختلط](src/algorithms/math/complex-number) - اعداد مختلط و عملیات پایه روی آن‌ها
  * `B` [رادیان و درجه](src/algorithms/math/radian) - تبدیل رادیان به درجه و بالعکس
  * `B` [توان سریع](src/algorithms/math/fast-powering)
  * `B` [روش هورنر](src/algorithms/math/horner-method) - ارزیابی چندجمله‌ای
  * `B` [ماتریس‌ها](src/algorithms/math/matrix) - ماتریس‌ها و عملیات پایه آن‌ها (ضرب، ترانهاده و ...)
  * `B` [فاصله اقلیدسی](src/algorithms/math/euclidean-distance) - فاصله بین دو نقطه/بردار/ماتریس
  * `A` [تقسیم عدد صحیح](src/algorithms/math/integer-partition)
  * `A` [ریشه دوم](src/algorithms/math/square-root) - روش نیوتن
  * `A` [الگوریتم لیو هوی برای عدد پی](src/algorithms/math/liu-hui) - تقریب عدد پی بر اساس چندضلعی
  * `A` [تبدیل فوریه گسسته](src/algorithms/math/fourier-transform) - تجزیه یک تابع زمانی (سیگنال) به فرکانس‌های تشکیل‌دهنده آن
* **مجموعه‌ها**
  * `B` [ضرب دکارتی](src/algorithms/sets/cartesian-product) - حاصل‌ضرب چند مجموعه
  * `B` [درهم‌ریزی فیشر-ییتس](src/algorithms/sets/fisher-yates) - جایگشت تصادفی یک دنباله محدود
  * `A` [مجموعه توانی](src/algorithms/sets/power-set) - همه زیرمجموعه‌های یک مجموعه (روش بیت، بازگشت و آبشاری)
  * `A` [جایگشت‌ها](src/algorithms/sets/permutations) (با و بدون تکرار)
  * `A` [ترکیب‌ها](src/algorithms/sets/combinations) (با و بدون تکرار)
  * `A` [بیشترین زیررشته مشترک](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [بیشترین زیررشته افزایشی](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [کوتاه‌ترین زبررشته مشترک](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [مسئله کوله‌پشتی](src/algorithms/sets/knapsack-problem) - نوع "۰/۱" و "بدون محدودیت"
  * `A` [زیرآرایه بیشینه](src/algorithms/sets/maximum-subarray) - نسخه‌های "نیروی بی‌رحمانه" و "برنامه‌نویسی پویا" (کادان)
  * `A` [مجموع ترکیب](src/algorithms/sets/combination-sum) - یافتن تمام ترکیب‌هایی که مجموع خاصی را تشکیل می‌دهند
* **رشته‌ها**
  * `B` [فاصله همینگ](src/algorithms/string/hamming-distance) - تعداد موقعیت‌هایی که نمادها متفاوت‌اند
  * `B` [پالین‌دروم](src/algorithms/string/palindrome) - بررسی اینکه رشته از دو طرف یکی است یا نه
  * `A` [فاصله لوینشتاین](src/algorithms/string/levenshtein-distance) - کمترین فاصله ویرایشی بین دو دنباله
  * `A` [الگوریتم کنوث-موریس-پرت](src/algorithms/string/knuth-morris-pratt) (KMP) - جستجوی زیررشته (الگو)
  * `A` [الگوریتم Z](src/algorithms/string/z-algorithm) - جستجوی زیررشته (الگو)
  * `A` [الگوریتم رابین-کارپ](src/algorithms/string/rabin-karp) - جستجوی زیررشته
  * `A` [بیشترین زیررشته مشترک](src/algorithms/string/longest-common-substring)
  * `A` [تطبیق عبارت منظم](src/algorithms/string/regular-expression-matching)
* **جستجو**
  * `B` [جستجوی خطی](src/algorithms/search/linear-search)
  * `B` [جستجوی پرشی](src/algorithms/search/jump-search) (یا جستجوی بلوکی) - جستجو در آرایه مرتب
  * `B` [جستجوی دودویی](src/algorithms/search/binary-search) - جستجو در آرایه مرتب
  * `B` [جستجوی درونیابی](src/algorithms/search/interpolation-search) - جستجو در آرایه مرتب با توزیع یکنواخت
* **مرتب‌سازی**
  * `B` [مرتب‌سازی حبابی](src/algorithms/sorting/bubble-sort)
  * `B` [مرتب‌سازی انتخابی](src/algorithms/sorting/selection-sort)
  * `B` [مرتب‌سازی درجی](src/algorithms/sorting/insertion-sort)
  * `B` [مرتب‌سازی هیپ](src/algorithms/sorting/heap-sort)
  * `B` [مرتب‌سازی ادغامی](src/algorithms/sorting/merge-sort)
  * `B` [مرتب‌سازی سریع](src/algorithms/sorting/quick-sort) - پیاده‌سازی درجا و غیر درجا
  * `B` [مرتب‌سازی شلی](src/algorithms/sorting/shell-sort)
  * `B` [مرتب‌سازی شمارشی](src/algorithms/sorting/counting-sort)
  * `B` [مرتب‌سازی رادیکس](src/algorithms/sorting/radix-sort)
  * `B` [مرتب‌سازی سطلی](src/algorithms/sorting/bucket-sort)
* **لیست‌های پیوندی**
  * `B` [پیمایش مستقیم](src/algorithms/linked-list/traversal)
  * `B` [پیمایش معکوس](src/algorithms/linked-list/reverse-traversal)
* **درخت‌ها**
  * `B` [جستجوی عمقی](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [جستجوی سطحی](src/algorithms/tree/breadth-first-search) (BFS)
* **گراف‌ها**
  * `B` [جستجوی عمقی](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [جستجوی سطحی](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [الگوریتم کروسکال](src/algorithms/graph/kruskal) - یافتن درخت پوشای کمینه برای گراف وزن‌دار بدون جهت
  * `A` [الگوریتم دیکسترا](src/algorithms/graph/dijkstra) - یافتن کوتاه‌ترین مسیرها به همه رئوس از یک رأس
  * `A` [الگوریتم بلمن-فورد](src/algorithms/graph/bellman-ford) - یافتن کوتاه‌ترین مسیرها به همه رئوس از یک رأس
  * `A` [الگوریتم فلوید-وارشال](src/algorithms/graph/floyd-warshall) - یافتن کوتاه‌ترین مسیرها بین همه جفت راس‌ها
  * `A` [تشخیص حلقه](src/algorithms/graph/detect-cycle) - برای گراف‌های جهت‌دار و بدون جهت (نسخه‌های DFS و مجموعه جدا)
  * `A` [الگوریتم پریما](src/algorithms/graph/prim) - یافتن درخت پوشای کمینه برای گراف وزن‌دار بدون جهت
  * `A` [مرتب‌سازی توپولوژیک](src/algorithms/graph/topological-sorting) - روش DFS
  * `A` [نقاط مفصلی](src/algorithms/graph/articulation-points) - الگوریتم تارژان (مبتنی بر DFS)
  * `A` [پل‌ها](src/algorithms/graph/bridges) - الگوریتم مبتنی بر DFS
  * `A` [مسیر اویلری و دور اویلری](src/algorithms/graph/eulerian-path) - الگوریتم فلوری - بازدید از هر یال دقیقاً یک بار
  * `A` [دور همیلتونی](src/algorithms/graph/hamiltonian-cycle) - بازدید از هر رأس دقیقاً یک بار
  * `A` [اجزای به شدت همبند](src/algorithms/graph/strongly-connected-components) - الگوریتم کاساراجو
  * `A` [مسئله فروشنده دوره‌گرد](src/algorithms/graph/travelling-salesman) - کوتاه‌ترین مسیر ممکن که از هر شهر می‌گذرد و به مبدأ بازمی‌گردد
* **رمزنگاری**
  * `B` [هش چندجمله‌ای](src/algorithms/cryptography/polynomial-hash) - تابع هش غلطان مبتنی بر چندجمله‌ای
  * `B` [رمز Fence Rail](src/algorithms/cryptography/rail-fence-cipher) - الگوریتم رمز جابجایی برای کدگذاری پیام‌ها
  * `B` [رمز سزار](src/algorithms/cryptography/caesar-cipher) - رمز جایگزینی ساده
  * `B` [رمز Hill](src/algorithms/cryptography/hill-cipher) - رمز جایگزینی مبتنی بر جبر خطی
* **یادگیری ماشین**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - ۷ تابع ساده JS که نشان می‌دهد ماشین‌ها چگونه یاد می‌گیرند (انتشار رو به جلو/عقب)
  * `B` [k-NN](src/algorithms/ml/knn) - الگوریتم طبقه‌بندی نزدیک‌ترین همسایه
  * `B` [k-Means](src/algorithms/ml/k-means) - الگوریتم خوشه‌بندی k-Means
* **پردازش تصویر**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - الگوریتم تغییر اندازه تصویر بر اساس محتوا
* **آمار**
  * `B` [انتخاب تصادفی وزنی](src/algorithms/statistics/weighted-random) - انتخاب آیتم تصادفی از لیست براساس وزن آیتم‌ها
* **الگوریتم‌های فرگشتی**
  * `A` [الگوریتم ژنتیک](https://github.com/trekhleb/self-parking-car-evolution) - نمونه کاربرد الگوریتم ژنتیک برای آموزش ماشین‌های خودپارک
* **دسته‌بندی نشده**
  * `B` [برج هانوی](src/algorithms/uncategorized/hanoi-tower)
  * `B` [چرخش ماتریس مربعی](src/algorithms/uncategorized/square-matrix-rotation) - الگوریتم درجا
  * `B` [بازی پرش](src/algorithms/uncategorized/jump-game) - بازگشتی، برنامه‌نویسی پویا (بالا به پایین + پایین به بالا) و حریصانه
  * `B` [مسیرهای یکتا](src/algorithms/uncategorized/unique-paths) - بازگشتی، برنامه‌نویسی پویا و مبتنی بر مثلث پاسکال
  * `B` [تراس‌های باران](src/algorithms/uncategorized/rain-terraces) - مسئله گیر افتادن آب باران (برنامه‌نویسی پویا و نیروی بی‌رحمانه)
  * `B` [پلکان بازگشتی](src/algorithms/uncategorized/recursive-staircase) - شمارش تعداد راه‌های رسیدن به بالا (۴ راه حل)
  * `B` [بهترین زمان خرید و فروش سهام](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - تقسیم و حل و روش یک‌بار عبور
  * `B` [پرانتزهای معتبر](src/algorithms/stack/valid-parentheses) - بررسی اعتبار پرانتزها (با استفاده از پشته)
  * `A` [مسئله N-ملکه](src/algorithms/uncategorized/n-queens)
  * `A` [تور اسب](src/algorithms/uncategorized/knight-tour)

### الگوریتم‌ها بر اساس پارادایم

یک پارادایم الگوریتمی یک روش یا رویکرد عمومی است که مبنای طراحی یک دسته از الگوریتم‌هاست. این انتزاعی بالاتر از مفهوم الگوریتم است، همان‌طور که الگوریتم بالاتر از برنامه کامپیوتری است.

* **نیروی بی‌رحمانه** - بررسی همه حالات و انتخاب بهترین راه حل
  * `B` [جستجوی خطی](src/algorithms/search/linear-search)
  * `B` [تراس‌های باران](src/algorithms/uncategorized/rain-terraces)
  * `B` [پلکان بازگشتی](src/algorithms/uncategorized/recursive-staircase)
  * `A` [زیرآرایه بیشینه](src/algorithms/sets/maximum-subarray)
  * `A` [مسئله فروشنده دوره‌گرد](src/algorithms/graph/travelling-salesman)
  * `A` [تبدیل فوریه گسسته](src/algorithms/math/fourier-transform)
* **حریصانه** - انتخاب بهترین گزینه در زمان فعلی بدون توجه به آینده
  * `B` [بازی پرش](src/algorithms/uncategorized/jump-game)
  * `A` [مسئله کوله‌پشتی بدون محدودیت](src/algorithms/sets/knapsack-problem)
  * `A` [الگوریتم دیکسترا](src/algorithms/graph/dijkstra)
  * `A` [الگوریتم پریما](src/algorithms/graph/prim)
  * `A` [الگوریتم کروسکال](src/algorithms/graph/kruskal)
* **تقسیم و حل** - تقسیم مسئله به قسمت‌های کوچک‌تر و حل آن‌ها
  * `B` [جستجوی دودویی](src/algorithms/search/binary-search)
  * `B` [برج هانوی](src/algorithms/uncategorized/hanoi-tower)
  * `B` [مثلث پاسکال](src/algorithms/math/pascal-triangle)
  * `B` [الگوریتم اقلیدسی](src/algorithms/math/euclidean-algorithm)
  * `B` [مرتب‌سازی ادغامی](src/algorithms/sorting/merge-sort)
  * `B` [مرتب‌سازی سریع](src/algorithms/sorting/quick-sort)
  * `B` [جستجوی عمقی درخت](src/algorithms/tree/depth-first-search)
  * `B` [جستجوی عمقی گراف](src/algorithms/graph/depth-first-search)
  * `B` [ماتریس‌ها](src/algorithms/math/matrix)
  * `B` [بازی پرش](src/algorithms/uncategorized/jump-game)
  * `B` [توان سریع](src/algorithms/math/fast-powering)
  * `B` [بهترین زمان خرید و فروش سهام](src/algorithms/uncategorized/best-time-to-buy-sell-stocks)
  * `A` [جایگشت‌ها](src/algorithms/sets/permutations)
  * `A` [ترکیب‌ها](src/algorithms/sets/combinations)
  * `A` [زیرآرایه بیشینه](src/algorithms/sets/maximum-subarray)
* **برنامه‌نویسی پویا** - ساخت راه حل با استفاده از زیربخش‌های قبلاً حل شده
  * `B` [اعداد فیبوناچی](src/algorithms/math/fibonacci)
  * `B` [بازی پرش](src/algorithms/uncategorized/jump-game)
  * `B` [مسیرهای یکتا](src/algorithms/uncategorized/unique-paths)
  * `B` [تراس‌های باران](src/algorithms/uncategorized/rain-terraces)
  * `B` [پلکان بازگشتی](src/algorithms/uncategorized/recursive-staircase)
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving)
  * `A` [فاصله لوینشتاین](src/algorithms/string/levenshtein-distance)
  * `A` [بیشترین زیررشته مشترک](src/algorithms/sets/longest-common-subsequence)
  * `A` [بیشترین زیررشته مشترک](src/algorithms/string/longest-common-substring)
  * `A` [بیشترین زیررشته افزایشی](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [کوتاه‌ترین زبررشته مشترک](src/algorithms/sets/shortest-common-supersequence)
  * `A` [مسئله کوله‌پشتی ۰/۱](src/algorithms/sets/knapsack-problem)
  * `A` [تقسیم عدد صحیح](src/algorithms/math/integer-partition)
  * `A` [زیرآرایه بیشینه](src/algorithms/sets/maximum-subarray)
  * `A` [الگوریتم بلمن-فورد](src/algorithms/graph/bellman-ford)
  * `A` [الگوریتم فلوید-وارشال](src/algorithms/graph/floyd-warshall)
  * `A` [تطبیق عبارت منظم](src/algorithms/string/regular-expression-matching)
* **بازگشت به عقب** - مشابه نیروی بی‌رحمانه، سعی می‌کند تمام راه حل‌های ممکن را ایجاد کند، اما هر بار که راه حل جدیدی ایجاد می‌شود، بررسی می‌کند که آیا همه شرایط را برآورده می‌کند و فقط در این صورت ادامه می‌دهد. در غیر این صورت بازمی‌گردد و مسیر دیگری را امتحان می‌کند. معمولاً پیمایش DFS فضای حالت استفاده می‌شود.
  * `B` [بازی پرش](src/algorithms/uncategorized/jump-game)
  * `B` [مسیرهای یکتا](src/algorithms/uncategorized/unique-paths)
  * `B` [مجموعه توانی](src/algorithms/sets/power-set)
  * `A` [دور همیلتونی](src/algorithms/graph/hamiltonian-cycle)
  * `A` [مسئله N-ملکه](src/algorithms/uncategorized/n-queens)
  * `A` [تور اسب](src/algorithms/uncategorized/knight-tour)
  * `A` [مجموع ترکیب](src/algorithms/sets/combination-sum)
* **شاخه و کران** - کمترین هزینه پیدا شده در هر مرحله از جستجوی بازگشتی را به خاطر می‌سپارد و از این مقدار به عنوان کران پایین برای راه حل‌های جزئی استفاده می‌کند تا راه حل‌های جزئی با هزینه بیشتر از کمترین هزینه یافت شده را حذف کند. معمولاً پیمایش BFS همراه با DFS فضای حالت استفاده می‌شود.

## نحوه استفاده از این مخزن

**نصب همه وابستگی‌ها**

```
npm install
```

**اجرای ESLint**

ممکن است بخواهید برای بررسی کیفیت کد آن را اجرا کنید.

```
npm run lint
```

**اجرای همه تست‌ها**

```
npm test
```

**اجرای تست‌ها با نام**

```
npm test -- 'LinkedList'
```

**عیب‌یابی**

اگر lint یا تست‌ها شکست خورد، پوشه `node_modules` را حذف و دوباره پکیج‌ها را نصب کنید:

```
rm -rf ./node_modules
npm i
```

همچنین مطمئن شوید نسخه Node صحیح (`>=16`) را استفاده می‌کنید. اگر برای مدیریت نسخه Node از [nvm](https://github.com/nvm-sh/nvm) استفاده می‌کنید، می‌توانید از پوشه اصلی پروژه `nvm use` را اجرا کنید تا نسخه صحیح انتخاب شود.

**محیط بازی (Playground)**

می‌توانید با ساختمان‌های داده و الگوریتم‌ها در فایل `./src/playground/playground.js` بازی کنید و برای آن تست بنویسید: `./src/playground/__test__/playground.test.js`

سپس به سادگی با دستور زیر بررسی کنید کد شما همان‌طور که انتظار دارید کار می‌کند:

```
npm test -- 'playground'
```

## اطلاعات مفید

### منابع

- [▶ ساختمان داده و الگوریتم‌ها در یوتیوب](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 طرح‌های ساختمان داده](https://okso.app/showcase/data-structures)

### نماد O بزرگ (Big O Notation)

*نماد O بزرگ* برای طبقه‌بندی الگوریتم‌ها بر اساس رشد زمان اجرا یا مصرف حافظه آن‌ها نسبت به اندازه ورودی استفاده می‌شود.
در نمودار زیر، رایج‌ترین مرتبه‌های رشد الگوریتم‌ها را بر حسب نماد O بزرگ می‌بینید.

![نمودارهای Big O](./assets/big-o-graph.png)

منبع: [Big O Cheat Sheet](http://bigocheatsheet.com/).

در جدول زیر برخی از رایج‌ترین نمادهای Big O و مقایسه عملکرد آن‌ها در اندازه‌های مختلف ورودی آورده شده است.

| نماد Big O      | نوع         | محاسبات برای ۱۰ عنصر | محاسبات برای ۱۰۰ عنصر | محاسبات برای ۱۰۰۰ عنصر     |
| --------------- | ----------- | -------------------- | ---------------------- | --------------------------- |
| **O(1)**        | ثابت        | 1                    | 1                      | 1                           |
| **O(log N)**    | لگاریتمی    | 3                    | 6                      | 9                           |
| **O(N)**        | خطی         | 10                   | 100                    | 1000                        |
| **O(N log N)**  | n log(n)    | 30                   | 600                    | 9000                        |
| **O(N^2)**      | درجه دو     | 100                  | 10000                  | 1000000                     |
| **O(2^N)**      | نمایی       | 1024                 | 1.26e+29               | 1.07e+301                   |
| **O(N!)**       | فاکتوریلی   | 3628800              | 9.3e+157               | 4.02e+2567                  |

### پیچیدگی عملیات ساختمان داده‌ها

| ساختمان داده           | دسترسی    | جستجو    | درج      | حذف      | توضیحات   |
| ---------------------- | :-------: | :------: | :------: | :------: | :-------- |
| **آرایه**              | 1         | n        | n        | n        |           |
| **پشته**               | n         | n        | 1        | 1        |           |
| **صف**                 | n         | n        | 1        | 1        |           |
| **لیست پیوندی**        | n         | n        | 1        | n        |           |
| **جدول هش**            | -         | n        | n        | n        | در صورت هش بی‌نقص، O(1) خواهد بود |
| **درخت جستجوی دودویی** | n         | n        | n        | n        | در صورت تعادل، O(log(n)) است |
| **درخت B**             | log(n)    | log(n)   | log(n)   | log(n)   |           |
| **درخت قرمز-سیاه**     | log(n)    | log(n)   | log(n)   | log(n)   |           |
| **درخت AVL**           | log(n)    | log(n)   | log(n)   | log(n)   |           |
| **فیلتر بلوم**         | -         | 1        | 1        | -        | امکان مثبت کاذب در جستجو وجود دارد |

### پیچیدگی الگوریتم‌های مرتب‌سازی آرایه

| نام                   | بهترین        | میانگین          | بدترین             | حافظه     | پایدار    | توضیحات   |
| --------------------- | :-----------: | :--------------: | :----------------: | :-------: | :-------: | :-------- |
| **مرتب‌سازی حبابی**   | n             | n<sup>2</sup>    | n<sup>2</sup>      | 1         | بله       |           |
| **مرتب‌سازی درجی**    | n             | n<sup>2</sup>    | n<sup>2</sup>      | 1         | بله       |           |
| **مرتب‌سازی انتخابی** | n<sup>2</sup> | n<sup>2</sup>    | n<sup>2</sup>      | 1         | خیر       |           |
| **مرتب‌سازی هیپ**     | n&nbsp;log(n) | n&nbsp;log(n)    | n&nbsp;log(n)      | 1         | خیر       |           |
| **مرتب‌سازی ادغامی**  | n&nbsp;log(n) | n&nbsp;log(n)    | n&nbsp;log(n)      | n         | بله       |           |
| **مرتب‌سازی سریع**    | n&nbsp;log(n) | n&nbsp;log(n)    | n<sup>2</sup>      | log(n)    | خیر       | معمولاً درجا با O(log(n)) فضا اجرا می‌شود |
| **مرتب‌سازی شلی**     | n&nbsp;log(n) | بستگی به gap دارد| n&nbsp;(log(n))<sup>2</sup> | 1 | خیر |           |
| **مرتب‌سازی شمارشی**  | n + r         | n + r            | n + r              | n + r     | بله       | r - بزرگ‌ترین عدد آرایه |
| **مرتب‌سازی رادیکس**  | n * k         | n * k            | n * k              | n + k     | بله       | k - طول بلندترین کلید   |

## پشتیبانان پروژه

> می‌توانید از این پروژه از طریق ❤️️ [GitHub](https://github.com/sponsors/trekhleb) یا ❤️️ [Patreon](https://www.patreon.com/trekhleb) حمایت کنید.

[افرادی که از این پروژه حمایت می‌کنند](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## نویسنده

[@trekhleb](https://trekhleb.dev)

چند [پروژه](https://trekhleb.dev/projects/) و [مقاله](https://trekhleb.dev/blog/) دیگر درباره جاوااسکریپت و الگوریتم‌ها در [trekhleb.dev](https://trekhleb.dev)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---