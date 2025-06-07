# خوارزميات وهياكل بيانات جافاسكريبت

> 🇺🇦 أوكرانيا [تتعرض لهجوم](https://war.ukraine.ua/) من الجيش الروسي. المدنيون يُقتلون. المناطق السكنية تتعرض للقصف.
> - ساعد أوكرانيا عبر:
>   - [مؤسسة سيرهي بريتولا الخيرية](https://prytulafoundation.org/en/)
>   - [مؤسسة "عد حياً" الخيرية](https://savelife.in.ua/en/donate-en/)
>   - [البنك الوطني الأوكراني](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - مزيد من المعلومات على [war.ukraine.ua](https://war.ukraine.ua/) و[MFA of Ukraine](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

يحتوي هذا المستودع على أمثلة مبنية على جافاسكريبت للعديد من الخوارزميات وهياكل البيانات الشائعة.

لكل خوارزمية وهيكل بيانات ملف README منفصل مع شروحات وروابط للقراءة الإضافية (بما في ذلك روابط لمقاطع فيديو على يوتيوب).

_اقرأ هذا بلغات أخرى:_
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

*☝ لاحظ أن هذا المشروع مخصص للأغراض التعليمية والبحثية فقط، وليس للاستخدام في الإنتاج.*

## هياكل البيانات

هيكل البيانات هو طريقة معينة لتنظيم وتخزين البيانات في الحاسوب بحيث يمكن الوصول إليها وتعديلها بكفاءة. بشكل أكثر دقة، هيكل البيانات هو مجموعة من القيم والعلاقات بينها والدوال أو العمليات التي يمكن تطبيقها على البيانات.

تذكر أن لكل هيكل بيانات مزاياه وعيوبه. ويجب أن تعير اهتماماً أكبر لسبب اختيارك هيكل بيانات معين بدلاً من كيفية تطبيقه.

`B` - مبتدئ، `A` - متقدم

* `B` [قائمة مرتبطة](src/data-structures/linked-list)
* `B` [قائمة مرتبطة مزدوجة](src/data-structures/doubly-linked-list)
* `B` [طابور](src/data-structures/queue)
* `B` [مكدس](src/data-structures/stack)
* `B` [جدول تجزئة](src/data-structures/hash-table)
* `B` [كومة](src/data-structures/heap) - إصدارات الكومة العظمى والصغرى
* `B` [طابور أولوية](src/data-structures/priority-queue)
* `A` [تري](src/data-structures/trie)
* `A` [شجرة](src/data-structures/tree)
  * `A` [شجرة البحث الثنائية](src/data-structures/tree/binary-search-tree)
  * `A` [شجرة AVL](src/data-structures/tree/avl-tree)
  * `A` [شجرة ريد-بلاك](src/data-structures/tree/red-black-tree)
  * `A` [شجرة القطاعات](src/data-structures/tree/segment-tree) - مع أمثلة على استعلامات النطاق (الحد الأدنى/الأقصى/المجموع)
  * `A` [شجرة فينويك](src/data-structures/tree/fenwick-tree) (شجرة مفهرسة ثنائية)
* `A` [رسم بياني](src/data-structures/graph) (موجه وغير موجه)
* `A` [مجموعة منفصلة](src/data-structures/disjoint-set) - هيكل بيانات اتحاد-بحث أو مجموعة دمج-بحث
* `A` [مرشح بلوم](src/data-structures/bloom-filter)
* `A` [ذاكرة تخزين مؤقت LRU](src/data-structures/lru-cache/) - أقل العناصر استخداماً مؤخراً (LRU)

## الخوارزميات

الخوارزمية هي مواصفة واضحة لكيفية حل فئة من المشكلات. وهي مجموعة من القواعد التي تحدد بدقة تسلسل العمليات.

`B` - مبتدئ، `A` - متقدم

### الخوارزميات حسب الموضوع

* **الرياضيات**
  * `B` [معالجة البتات](src/algorithms/math/bits) - تعيين/قراءة/تحديث/مسح البتات، الضرب/القسمة على اثنين، التحويل إلى سالب، إلخ.
  * `B` [الفاصلة العائمة الثنائية](src/algorithms/math/binary-floating-point) - التمثيل الثنائي للأعداد ذات الفاصلة العائمة.
  * `B` [العامل](src/algorithms/math/factorial)
  * `B` [عدد فيبوناتشي](src/algorithms/math/fibonacci) - الإصدارات الكلاسيكية والمغلقة
  * `B` [العوامل الأولية](src/algorithms/math/prime-factors) - إيجاد العوامل الأولية وحسابها باستخدام مبرهنة هاردي-رامانوجان
  * `B` [اختبار أولية العدد](src/algorithms/math/primality-test) (طريقة القسمة التجريبية)
  * `B` [الخوارزمية الإقليدية](src/algorithms/math/euclidean-algorithm) - حساب القاسم المشترك الأكبر (GCD)
  * `B` [المضاعف المشترك الأصغر](src/algorithms/math/least-common-multiple) (LCM)
  * `B` [منخل إراتوستينس](src/algorithms/math/sieve-of-eratosthenes) - إيجاد جميع الأعداد الأولية حتى حد معين
  * `B` [هل هو قوة اثنين](src/algorithms/math/is-power-of-two) - التحقق ما إذا كان العدد قوة اثنين (خوارزميات بسيطة وبتية)
  * `B` [مثلث باسكال](src/algorithms/math/pascal-triangle)
  * `B` [عدد مركب](src/algorithms/math/complex-number) - الأعداد المركبة والعمليات الأساسية عليها
  * `B` [الراديان والدرجة](src/algorithms/math/radian) - تحويل الراديان إلى درجة والعكس
  * `B` [القوة السريعة](src/algorithms/math/fast-powering)
  * `B` [طريقة هورنر](src/algorithms/math/horner-method) - تقييم كثيرات الحدود
  * `B` [المصفوفات](src/algorithms/math/matrix) - المصفوفات والعمليات الأساسية عليها (الضرب، النقل، إلخ)
  * `B` [المسافة الإقليدية](src/algorithms/math/euclidean-distance) - المسافة بين نقطتين/متجهين/مصفوفات
  * `A` [تقسيم الأعداد الصحيحة](src/algorithms/math/integer-partition)
  * `A` [الجذر التربيعي](src/algorithms/math/square-root) - طريقة نيوتن
  * `A` [خوارزمية ليو هوي لحساب π](src/algorithms/math/liu-hui) - تقريب حسابات π بناءً على المضلع N
  * `A` [تحويل فورييه المتقطع](src/algorithms/math/fourier-transform) - تحليل دالة زمنية (إشارة) إلى الترددات المكونة لها
* **المجموعات**
  * `B` [جداء ديكارتي](src/algorithms/sets/cartesian-product) - جداء عدة مجموعات
  * `B` [تبديل فيشر-ياتس](src/algorithms/sets/fisher-yates) - تبديل عشوائي لتسلسل نهائي
  * `A` [مجموعة القوى](src/algorithms/sets/power-set) - جميع المجموعات الفرعية لمجموعة (حلول بتية، وتتبع رجعي، وتدريجي)
  * `A` [التباديل](src/algorithms/sets/permutations) (مع وبدون تكرار)
  * `A` [التوافيق](src/algorithms/sets/combinations) (مع وبدون تكرار)
  * `A` [أطول سلسلة مشتركة](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [أطول سلسلة متزايدة](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [أقصر سلسلة شاملة مشتركة](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [مشكلة الحقيبة](src/algorithms/sets/knapsack-problem) - "0/1" و"غير محدودة"
  * `A` [أكبر مصفوفة فرعية](src/algorithms/sets/maximum-subarray) - إصدارات "القوة الغاشمة" و"البرمجة الديناميكية" (كاداني)
  * `A` [مجموع التوافيق](src/algorithms/sets/combination-sum) - إيجاد جميع التوافيق التي تشكل مجموعاً معيناً
* **السلاسل النصية**
  * `B` [مسافة هامينغ](src/algorithms/string/hamming-distance) - عدد المواقع التي تختلف فيها الرموز
  * `B` [الجملة العكسية (Palindrome)](src/algorithms/string/palindrome) - التحقق مما إذا كانت السلسلة النصية هي نفسها عند عكسها
  * `A` [مسافة ليفنشتاين](src/algorithms/string/levenshtein-distance) - أقل مسافة تحرير بين سلسلتين
  * `A` [خوارزمية كنوت-موريس-برات](src/algorithms/string/knuth-morris-pratt) (خوارزمية KMP) - البحث عن سلسلة فرعية (مطابقة نمط)
  * `A` [خوارزمية Z](src/algorithms/string/z-algorithm) - البحث عن سلسلة فرعية (مطابقة نمط)
  * `A` [خوارزمية رابن-كارب](src/algorithms/string/rabin-karp) - البحث عن سلسلة فرعية
  * `A` [أطول سلسلة فرعية مشتركة](src/algorithms/string/longest-common-substring)
  * `A` [مطابقة التعبير النمطي](src/algorithms/string/regular-expression-matching)
* **البحث**
  * `B` [البحث الخطي](src/algorithms/search/linear-search)
  * `B` [البحث بالقفز](src/algorithms/search/jump-search) (أو البحث الكتلي) - البحث في مصفوفة مرتبة
  * `B` [البحث الثنائي](src/algorithms/search/binary-search) - البحث في مصفوفة مرتبة
  * `B` [البحث بالتداخل](src/algorithms/search/interpolation-search) - البحث في مصفوفة مرتبة موزعة بانتظام
* **الفرز**
  * `B` [فرز الفقاعات](src/algorithms/sorting/bubble-sort)
  * `B` [فرز الاختيار](src/algorithms/sorting/selection-sort)
  * `B` [فرز الإدراج](src/algorithms/sorting/insertion-sort)
  * `B` [فرز الكومة](src/algorithms/sorting/heap-sort)
  * `B` [فرز الدمج](src/algorithms/sorting/merge-sort)
  * `B` [فرز سريع](src/algorithms/sorting/quick-sort) - تطبيقات في نفس المكان وغير ذلك
  * `B` [فرز شل](src/algorithms/sorting/shell-sort)
  * `B` [فرز العد](src/algorithms/sorting/counting-sort)
  * `B` [فرز الراديكس](src/algorithms/sorting/radix-sort)
  * `B` [فرز الدلو](src/algorithms/sorting/bucket-sort)
* **القوائم المرتبطة**
  * `B` [الاجتياز المباشر](src/algorithms/linked-list/traversal)
  * `B` [الاجتياز العكسي](src/algorithms/linked-list/reverse-traversal)
* **الأشجار**
  * `B` [بحث العمق أولاً](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [بحث الاتساع أولاً](src/algorithms/tree/breadth-first-search) (BFS)
* **الرسوم البيانية**
  * `B` [بحث العمق أولاً](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [بحث الاتساع أولاً](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [خوارزمية كروسكال](src/algorithms/graph/kruskal) - إيجاد الشجرة الممتدة الصغرى (MST) لرسم بياني غير موجه
  * `A` [خوارزمية ديكسترا](src/algorithms/graph/dijkstra) - إيجاد أقصر المسارات لجميع رؤوس الرسم البياني من رأس واحد
  * `A` [خوارزمية بيلمان-فورد](src/algorithms/graph/bellman-ford) - إيجاد أقصر المسارات لجميع رؤوس الرسم البياني من رأس واحد
  * `A` [خوارزمية فلويد-وارشال](src/algorithms/graph/floyd-warshall) - إيجاد أقصر المسارات بين كل زوج من الرؤوس
  * `A` [كشف الدورات](src/algorithms/graph/detect-cycle) - للرسوم البيانية الموجهة وغير الموجهة (إصدارات DFS ومجموعة منفصلة)
  * `A` [خوارزمية بريِم](src/algorithms/graph/prim) - إيجاد الشجرة الممتدة الصغرى (MST) لرسم بياني غير موجه
  * `A` [الترتيب التوبولوجي](src/algorithms/graph/topological-sorting) - طريقة DFS
  * `A` [نقاط الفصل](src/algorithms/graph/articulation-points) - خوارزمية تارجان (تعتمد على DFS)
  * `A` [الجسور](src/algorithms/graph/bridges) - خوارزمية تعتمد على DFS
  * `A` [المسار الأويوليري والدائرة الأويوليرية](src/algorithms/graph/eulerian-path) - خوارزمية فلوري - زيارة كل حافة مرة واحدة فقط
  * `A` [دورة هاميلتونية](src/algorithms/graph/hamiltonian-cycle) - زيارة كل رأس مرة واحدة فقط
  * `A` [المكونات المترابطة بقوة](src/algorithms/graph/strongly-connected-components) - خوارزمية كوساراجو
  * `A` [مشكلة البائع المتجول](src/algorithms/graph/travelling-salesman) - أقصر مسار يزور كل مدينة ويعود إلى نقطة البداية
* **التشفير**
  * `B` [تجزئة متعددة الحدود](src/algorithms/cryptography/polynomial-hash) - دالة تجزئة متدحرجة تعتمد على متعددة الحدود
  * `B` [شفرة السياج السككي](src/algorithms/cryptography/rail-fence-cipher) - خوارزمية تشفير بالإزاحة
  * `B` [شفرة قيصر](src/algorithms/cryptography/caesar-cipher) - تشفير إحلال بسيط
  * `B` [شفرة هيل](src/algorithms/cryptography/hill-cipher) - تشفير إحلال يعتمد على الجبر الخطي
* **تعلم الآلة**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 دوال بسيطة توضح كيف يمكن للآلات أن تتعلم فعلاً (الانتشار الأمامي/العكسي)
  * `B` [k-NN](src/algorithms/ml/knn) - خوارزمية تصنيف الجار الأقرب k
  * `B` [k-Means](src/algorithms/ml/k-means) - خوارزمية تجميع k-الوسيطات
* **معالجة الصور**
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - خوارزمية تغيير حجم الصور بناءً على المحتوى
* **الإحصاء**
  * `B` [عشوائية موزونة](src/algorithms/statistics/weighted-random) - اختيار عنصر عشوائي من القائمة بناءً على أوزان العناصر
* **الخوارزميات التطورية**
  * `A` [الخوارزمية الجينية](https://github.com/trekhleb/self-parking-car-evolution) - مثال على تطبيق الخوارزمية الجينية لتدريب السيارات ذاتية الركن
* **غير مصنف**
  * `B` [برج هانوي](src/algorithms/uncategorized/hanoi-tower)
  * `B` [دوران مصفوفة مربعة](src/algorithms/uncategorized/square-matrix-rotation) - خوارزمية في نفس المكان
  * `B` [لعبة القفز](src/algorithms/uncategorized/jump-game) - أمثلة على التتبع الرجعي، البرمجة الديناميكية (من أعلى إلى أسفل + من أسفل إلى أعلى) والجشع
  * `B` [مسارات فريدة](src/algorithms/uncategorized/unique-paths) - أمثلة على التتبع الرجعي، البرمجة الديناميكية ومثلث باسكال
  * `B` [شرفات المطر](src/algorithms/uncategorized/rain-terraces) - مشكلة حصر ماء المطر (إصدارات البرمجة الديناميكية والقوة الغاشمة)
  * `B` [سلم متكرر](src/algorithms/uncategorized/recursive-staircase) - حساب عدد الطرق للوصول إلى الأعلى (4 حلول)
  * `B` [أفضل وقت للشراء والبيع للأسهم](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - أمثلة التقسيم والتغلب ومرور واحد
  * `B` [أقواس صالحة](src/algorithms/stack/valid-parentheses) - تحقق مما إذا كانت سلسلة نصية تحتوي على أقواس صالحة (باستخدام المكدس)
  * `A` [مشكلة الملكات N](src/algorithms/uncategorized/n-queens)
  * `A` [جولة الحصان](src/algorithms/uncategorized/knight-tour)

### الخوارزميات حسب المنهجية

منهجية الخوارزميات هي طريقة أو نهج عام يكمن وراء تصميم فئة من الخوارزميات. وهي تجريد أعلى من مفهوم الخوارزمية، كما أن الخوارزمية تجريد أعلى من البرنامج الحاسوبي.

* **القوة الغاشمة** - استعراض جميع الاحتمالات واختيار أفضل حل
  * `B` [البحث الخطي](src/algorithms/search/linear-search)
  * `B` [شرفات المطر](src/algorithms/uncategorized/rain-terraces) - مشكلة حصر ماء المطر
  * `B` [سلم متكرر](src/algorithms/uncategorized/recursive-staircase) - حساب عدد الطرق للوصول إلى الأعلى
  * `A` [أكبر مصفوفة فرعية](src/algorithms/sets/maximum-subarray)
  * `A` [مشكلة البائع المتجول](src/algorithms/graph/travelling-salesman) - أقصر مسار يزور كل مدينة ويعود إلى نقطة البداية
  * `A` [تحويل فورييه المتقطع](src/algorithms/math/fourier-transform) - تحليل دالة زمنية (إشارة) إلى الترددات المكونة لها
* **الجشع** - اختيار أفضل خيار في الوقت الحالي دون النظر للمستقبل
  * `B` [لعبة القفز](src/algorithms/uncategorized/jump-game)
  * `A` [مشكلة الحقيبة غير المحدودة](src/algorithms/sets/knapsack-problem)
  * `A` [خوارزمية ديكسترا](src/algorithms/graph/dijkstra) - إيجاد أقصر المسارات لجميع رؤوس الرسم البياني
  * `A` [خوارزمية بريِم](src/algorithms/graph/prim) - إيجاد الشجرة الممتدة الصغرى (MST) لرسم بياني غير موجه
  * `A` [خوارزمية كروسكال](src/algorithms/graph/kruskal) - إيجاد الشجرة الممتدة الصغرى (MST) لرسم بياني غير موجه
* **التقسيم والتغلب** - تقسيم المشكلة إلى أجزاء أصغر ثم حل تلك الأجزاء
  * `B` [البحث الثنائي](src/algorithms/search/binary-search)
  * `B` [برج هانوي](src/algorithms/uncategorized/hanoi-tower)
  * `B` [مثلث باسكال](src/algorithms/math/pascal-triangle)
  * `B` [الخوارزمية الإقليدية](src/algorithms/math/euclidean-algorithm) - حساب القاسم المشترك الأكبر (GCD)
  * `B` [فرز الدمج](src/algorithms/sorting/merge-sort)
  * `B` [فرز سريع](src/algorithms/sorting/quick-sort)
  * `B` [بحث العمق أولاً في الشجرة](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [بحث العمق أولاً في الرسم البياني](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [المصفوفات](src/algorithms/math/matrix) - توليد واجتياز المصفوفات بأشكال مختلفة
  * `B` [لعبة القفز](src/algorithms/uncategorized/jump-game)
  * `B` [القوة السريعة](src/algorithms/math/fast-powering)
  * `B` [أفضل وقت للشراء والبيع للأسهم](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - أمثلة التقسيم والتغلب ومرور واحد
  * `A` [التباديل](src/algorithms/sets/permutations) (مع وبدون تكرار)
  * `A` [التوافيق](src/algorithms/sets/combinations) (مع وبدون تكرار)
  * `A` [أكبر مصفوفة فرعية](src/algorithms/sets/maximum-subarray)
* **البرمجة الديناميكية** - بناء حل باستخدام حلول فرعية تم إيجادها مسبقاً
  * `B` [عدد فيبوناتشي](src/algorithms/math/fibonacci)
  * `B` [لعبة القفز](src/algorithms/uncategorized/jump-game)
  * `B` [مسارات فريدة](src/algorithms/uncategorized/unique-paths)
  * `B` [شرفات المطر](src/algorithms/uncategorized/rain-terraces) - مشكلة حصر ماء المطر
  * `B` [سلم متكرر](src/algorithms/uncategorized/recursive-staircase) - حساب عدد الطرق للوصول إلى الأعلى
  * `B` [Seam Carving](src/algorithms/image-processing/seam-carving) - خوارزمية تغيير حجم الصور بناءً على المحتوى
  * `A` [مسافة ليفنشتاين](src/algorithms/string/levenshtein-distance) - أقل مسافة تحرير بين سلسلتين
  * `A` [أطول سلسلة مشتركة](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [أطول سلسلة فرعية مشتركة](src/algorithms/string/longest-common-substring)
  * `A` [أطول سلسلة متزايدة](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [أقصر سلسلة شاملة مشتركة](src/algorithms/sets/shortest-common-supersequence)
  * `A` [مشكلة الحقيبة 0/1](src/algorithms/sets/knapsack-problem)
  * `A` [تقسيم الأعداد الصحيحة](src/algorithms/math/integer-partition)
  * `A` [أكبر مصفوفة فرعية](src/algorithms/sets/maximum-subarray)
  * `A` [خوارزمية بيلمان-فورد](src/algorithms/graph/bellman-ford) - إيجاد أقصر المسارات لجميع رؤوس الرسم البياني
  * `A` [خوارزمية فلويد-وارشال](src/algorithms/graph/floyd-warshall) - إيجاد أقصر المسارات بين كل زوج من الرؤوس
  * `A` [مطابقة التعبير النمطي](src/algorithms/string/regular-expression-matching)
* **تتبع الرجوع** - بشكل مشابه للقوة الغاشمة، محاولة توليد جميع الحلول الممكنة، ولكن في كل مرة تولد فيها حلاً تاليًا، تختبر ما إذا كان يفي بجميع الشروط وتتابع فقط إذا تحقق ذلك. وإلا، تعود للوراء وتسلك مسارًا مختلفًا للعثور على حل. عادةً ما يُستخدم اجتياز DFS لحالة الفضاء.
  * `B` [لعبة القفز](src/algorithms/uncategorized/jump-game)
  * `B` [مسارات فريدة](src/algorithms/uncategorized/unique-paths)
  * `B` [مجموعة القوى](src/algorithms/sets/power-set) - جميع المجموعات الفرعية لمجموعة
  * `A` [دورة هاميلتونية](src/algorithms/graph/hamiltonian-cycle) - زيارة كل رأس مرة واحدة فقط
  * `A` [مشكلة الملكات N](src/algorithms/uncategorized/n-queens)
  * `A` [جولة الحصان](src/algorithms/uncategorized/knight-tour)
  * `A` [مجموع التوافيق](src/algorithms/sets/combination-sum) - إيجاد جميع التوافيق التي تشكل مجموعاً معيناً
* **الفرع والحدود** - تذكر أقل الحلول تكلفة التي تم العثور عليها في كل مرحلة من مراحل البحث بتتبع الرجوع، واستخدام تكلفة أقل حل تم العثور عليه حتى الآن كحد أدنى لتكلفة الحل الأقل تكلفة، وذلك من أجل تجاهل الحلول الجزئية ذات التكلفة الأعلى من أقل حل تم العثور عليه حتى الآن. عادةً ما يُستخدم اجتياز BFS بالتزامن مع DFS لشجرة حالة الفضاء.

## كيفية استخدام هذا المستودع

**تثبيت جميع التبعيات**

```
npm install
```

**تشغيل ESLint**

قد ترغب في تشغيله لفحص جودة الشيفرة.

```
npm run lint
```

**تشغيل جميع الاختبارات**

```
npm test
```

**تشغيل اختبارات حسب الاسم**

```
npm test -- 'LinkedList'
```

**استكشاف الأخطاء وإصلاحها**

إذا فشلت عملية الفحص أو الاختبار، جرب حذف مجلد `node_modules` وأعد تثبيت حزم npm:

```
rm -rf ./node_modules
npm i
```

تأكد أيضاً من أنك تستخدم إصدار Node الصحيح (`>=16`). إذا كنت تستخدم [nvm](https://github.com/nvm-sh/nvm) لإدارة إصدارات Node، يمكنك تشغيل `nvm use` من مجلد المشروع الرئيسي وسيتم اختيار الإصدار الصحيح تلقائياً.

**ساحة اللعب (Playground)**

يمكنك التجربة مع هياكل البيانات والخوارزميات في ملف `./src/playground/playground.js` وكتابة اختبارات له في `./src/playground/__test__/playground.test.js`.

ثم ببساطة شغّل الأمر التالي لاختبار ما إذا كان كود ساحة اللعب يعمل كما هو متوقع:

```
npm test -- 'playground'
```

## معلومات مفيدة

### مراجع

- [▶ هياكل البيانات والخوارزميات على يوتيوب](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 رسومات هياكل البيانات](https://okso.app/showcase/data-structures)

### تدوين O الكبير (Big O Notation)

يُستخدم *تدوين O الكبير* لتصنيف الخوارزميات وفقاً لكيفية نمو زمن تنفيذها أو متطلبات المساحة مع زيادة حجم الإدخال.
في الرسم البياني أدناه، ستجد أكثر أنواع النمو شيوعاً للخوارزميات في تدوين O الكبير.

![Big O graphs](./assets/big-o-graph.png)

المصدر: [Big O Cheat Sheet](http://bigocheatsheet.com/).

فيما يلي قائمة ببعض تدوينات O الكبيرة الأكثر استخداماً ومقارنات أدائها ضد أحجام بيانات إدخال مختلفة.

| تدوين O الكبير | النوع         | العمليات لـ 10 عناصر | العمليات لـ 100 عنصر | العمليات لـ 1000 عنصر   |
| -------------- | -----------   | -------------------- | -------------------- | ----------------------- |
| **O(1)**       | ثابت          | 1                    | 1                    | 1                       |
| **O(log N)**   | لوغاريتمي     | 3                    | 6                    | 9                       |
| **O(N)**       | خطي           | 10                   | 100                  | 1000                    |
| **O(N log N)** | N log(n)      | 30                   | 600                  | 9000                    |
| **O(N^2)**     | تربيعي        | 100                  | 10000                | 1000000                 |
| **O(2^N)**     | أسي           | 1024                 | 1.26e+29             | 1.07e+301               |
| **O(N!)**      | عاملي         | 3628800              | 9.3e+157             | 4.02e+2567              |

### تعقيد عمليات هياكل البيانات

| هيكل البيانات          | الوصول    | البحث    | الإدراج   | الحذف     | ملاحظات  |
| --------------------- | :-------: | :------: | :-------: | :-------: | :-------- |
| **مصفوفة**            | 1         | n        | n         | n         |           |
| **مكدس**              | n         | n        | 1         | 1         |           |
| **طابور**             | n         | n        | 1         | 1         |           |
| **قائمة مرتبطة**      | n         | n        | 1         | n         |           |
| **جدول تجزئة**        | -         | n        | n         | n         | في حالة وجود دالة تجزئة مثالية ستكون O(1) |
| **شجرة البحث الثنائية**| n         | n        | n         | n         | في حالة الشجرة المتوازنة تكون O(log(n)) |
| **شجرة B**            | log(n)    | log(n)   | log(n)    | log(n)    |           |
| **شجرة ريد-بلاك**     | log(n)    | log(n)   | log(n)    | log(n)    |           |
| **شجرة AVL**          | log(n)    | log(n)   | log(n)    | log(n)    |           |
| **مرشح بلوم**         | -         | 1        | 1         | -         | ممكن وجود إيجابيات كاذبة أثناء البحث |

### تعقيد خوارزميات فرز المصفوفات

| الاسم                  | الأفضل           | المتوسط            | الأسوأ              | الذاكرة    | مستقر      | ملاحظات    |
| ---------------------- | :--------------: | :----------------: | :-----------------: | :--------: | :--------: | :--------- |
| **فرز الفقاعات**      | n                | n<sup>2</sup>      | n<sup>2</sup>       | 1          | نعم        |            |
| **فرز الإدراج**       | n                | n<sup>2</sup>      | n<sup>2</sup>       | 1          | نعم        |            |
| **فرز الاختيار**      | n<sup>2</sup>    | n<sup>2</sup>      | n<sup>2</sup>       | 1          | لا         |            |
| **فرز الكومة**        | n&nbsp;log(n)    | n&nbsp;log(n)      | n&nbsp;log(n)       | 1          | لا         |            |
| **فرز الدمج**         | n&nbsp;log(n)    | n&nbsp;log(n)      | n&nbsp;log(n)       | n          | نعم        |            |
| **فرز سريع**          | n&nbsp;log(n)    | n&nbsp;log(n)      | n<sup>2</sup>       | log(n)     | لا         | غالباً يتم في نفس المكان باستخدام مساحة مكدس O(log(n)) |
| **فرز شل**            | n&nbsp;log(n)    | يعتمد على تسلسل الفجوة | n&nbsp;(log(n))<sup>2</sup> | 1          | لا         |            |
| **فرز العد**          | n + r            | n + r              | n + r               | n + r      | نعم        | r - أكبر رقم في المصفوفة |
| **فرز الراديكس**      | n * k            | n * k              | n * k               | n + k      | نعم        | k - طول أطول مفتاح |

## داعمو المشروع

> يمكنك دعم هذا المشروع عبر ❤️️ [GitHub](https://github.com/sponsors/trekhleb) أو ❤️️ [Patreon](https://www.patreon.com/trekhleb).

[الأشخاص الذين يدعمون هذا المشروع](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## المؤلف

[@trekhleb](https://trekhleb.dev)

بعض [المشاريع](https://trekhleb.dev/projects/) و[المقالات](https://trekhleb.dev/blog/) الإضافية حول جافاسكريبت والخوارزميات على [trekhleb.dev](https://trekhleb.dev)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---