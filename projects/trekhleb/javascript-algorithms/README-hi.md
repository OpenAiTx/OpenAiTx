# जावास्क्रिप्ट एल्गोरिद्म और डेटा संरचनाएँ

> 🇺🇦 यूक्रेन [हमले का सामना कर रहा है](https://war.ukraine.ua/) रूसी सेना द्वारा। नागरिक मारे जा रहे हैं। रिहायशी इलाकों पर बमबारी हो रही है।
> - यूक्रेन की सहायता करें:
>   - [Serhiy Prytula चैरिटी फाउंडेशन](https://prytulafoundation.org/en/)
>   - [Come Back Alive चैरिटी फाउंडेशन](https://savelife.in.ua/en/donate-en/)
>   - [यूक्रेन का नेशनल बैंक](https://bank.gov.ua/en/news/all/natsionalniy-bank-vidkriv-spetsrahunok-dlya-zboru-koshtiv-na-potrebi-armiyi)
> - अधिक जानकारी के लिए देखें [war.ukraine.ua](https://war.ukraine.ua/) और [यूक्रेन का MFA](https://twitter.com/MFA_Ukraine)

<hr/>

[![CI](https://github.com/trekhleb/javascript-algorithms/workflows/CI/badge.svg)](https://github.com/trekhleb/javascript-algorithms/actions?query=workflow%3ACI+branch%3Amaster)
[![codecov](https://codecov.io/gh/trekhleb/javascript-algorithms/branch/master/graph/badge.svg)](https://codecov.io/gh/trekhleb/javascript-algorithms)
![repo size](https://img.shields.io/github/repo-size/trekhleb/javascript-algorithms.svg)

यह रिपॉजिटरी जावास्क्रिप्ट आधारित कई लोकप्रिय एल्गोरिद्म और डेटा संरचनाओं के उदाहरणों को शामिल करती है।

हर एल्गोरिद्म और डेटा संरचना का अपना अलग README है, जिसमें संबंधित व्याख्याएँ और आगे पढ़ने के लिए लिंक (जिनमें यूट्यूब वीडियो भी शामिल हैं) दिए गए हैं।

_इसे अन्य भाषाओं में पढ़ें:_
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

*☝ ध्यान दें कि यह प्रोजेक्ट केवल सीखने और शोध के उद्देश्यों के लिए है,
प्रोडक्शन में उपयोग के लिए **नहीं** है।*

## डेटा संरचनाएँ

डेटा संरचना कंप्यूटर में डेटा को व्यवस्थित और संग्रहीत करने का एक विशेष तरीका है ताकि उसे कुशलतापूर्वक एक्सेस और संशोधित किया जा सके। और अधिक सटीक रूप से, डेटा संरचना डेटा मानों का एक संग्रह, उनके बीच के संबंध, और उन पर लागू की जा सकने वाली फंक्शन्स या ऑपरेशन्स का समूह है।

याद रखें कि हर डेटा संरचना के अपने फायदे और नुकसान होते हैं। आपको यह अधिक महत्वपूर्ण रूप से देखना चाहिए कि आप कौन सी डेटा संरचना क्यों चुन रहे हैं, न कि बस उसे कैसे लागू किया जाए।

`B` - शुरुआती, `A` - उन्नत

* `B` [लिंक्ड लिस्ट](src/data-structures/linked-list)
* `B` [डबल लिंक्ड लिस्ट](src/data-structures/doubly-linked-list)
* `B` [क्यू](src/data-structures/queue)
* `B` [स्टैक](src/data-structures/stack)
* `B` [हैश टेबल](src/data-structures/hash-table)
* `B` [हीप](src/data-structures/heap) - मैक्स और मिन हीप संस्करण
* `B` [प्रायोरिटी क्यू](src/data-structures/priority-queue)
* `A` [ट्राई](src/data-structures/trie)
* `A` [ट्री](src/data-structures/tree)
  * `A` [बाइनरी सर्च ट्री](src/data-structures/tree/binary-search-tree)
  * `A` [AVL ट्री](src/data-structures/tree/avl-tree)
  * `A` [रेड-ब्लैक ट्री](src/data-structures/tree/red-black-tree)
  * `A` [सेगमेंट ट्री](src/data-structures/tree/segment-tree) - मिन/मैक्स/सम रेंज क्वेरी के उदाहरणों के साथ
  * `A` [फेनविक ट्री](src/data-structures/tree/fenwick-tree) (बाइनरी इंडेक्स्ड ट्री)
* `A` [ग्राफ](src/data-structures/graph) (डायरेक्टेड और अनडायरेक्टेड दोनों)
* `A` [डिसजॉइंट सेट](src/data-structures/disjoint-set) - यूनियन–फाइंड डेटा संरचना या मर्ज–फाइंड सेट
* `A` [ब्लूम फिल्टर](src/data-structures/bloom-filter)
* `A` [LRU कैश](src/data-structures/lru-cache/) - लिस्ट रिसेंटली यूज्ड (LRU) कैश

## एल्गोरिद्म

एक एल्गोरिद्म समस्याओं की एक श्रेणी को हल करने के लिए एक स्पष्ट निर्दिष्ट तरीका है। यह ऑपरेशन्स के अनुक्रम को सटीक रूप से परिभाषित करने वाले नियमों का एक सेट है।

`B` - शुरुआती, `A` - उन्नत

### विषय के अनुसार एल्गोरिद्म

* **गणित**
  * `B` [बिट मैनिपुलेशन](src/algorithms/math/bits) - बिट सेट/गेट/अपडेट/क्लियर, दो से गुणा/भाग, निगेटिव बनाना आदि।
  * `B` [बाइनरी फ्लोटिंग पॉइंट](src/algorithms/math/binary-floating-point) - फ्लोटिंग-पॉइंट संख्याओं का बाइनरी प्रतिनिधित्व।
  * `B` [फैक्टोरियल](src/algorithms/math/factorial)
  * `B` [फिबोनाच्ची संख्या](src/algorithms/math/fibonacci) - क्लासिक और क्लोज्ड-फॉर्म संस्करण
  * `B` [प्राइम फैक्टर्स](src/algorithms/math/prime-factors) - प्राइम फैक्टर्स ढूँढना और हार्डी-रामानुजन प्रमेय द्वारा गिनना
  * `B` [प्राइमैलिटी टेस्ट](src/algorithms/math/primality-test) (ट्रायल डिवीजन विधि)
  * `B` [यूक्लिडियन एल्गोरिद्म](src/algorithms/math/euclidean-algorithm) - ग्रेटेस्ट कॉमन डिवाइजर (GCD) निकालना
  * `B` [लीस्ट कॉमन मल्टीपल](src/algorithms/math/least-common-multiple) (LCM)
  * `B` [सीव ऑफ इरैटोस्थनीज](src/algorithms/math/sieve-of-eratosthenes) - किसी भी सीमा तक सभी प्राइम नंबर ढूँढना
  * `B` [इज़ पावर ऑफ टू](src/algorithms/math/is-power-of-two) - यह जांचना कि संख्या दो की घात है या नहीं (साधारण और बिटवाइज़ एल्गोरिद्म)
  * `B` [पैस्कल्स ट्रायंगल](src/algorithms/math/pascal-triangle)
  * `B` [कॉम्प्लेक्स नंबर](src/algorithms/math/complex-number) - कॉम्प्लेक्स नंबर और उन पर बुनियादी ऑपरेशन्स
  * `B` [रेडियन और डिग्री](src/algorithms/math/radian) - रेडियन से डिग्री और वापस कन्वर्ज़न
  * `B` [फास्ट पावरिंग](src/algorithms/math/fast-powering)
  * `B` [हॉर्नर विधि](src/algorithms/math/horner-method) - बहुपद मूल्यांकन
  * `B` [मैट्रिसेज़](src/algorithms/math/matrix) - मैट्रिक्स और बुनियादी मैट्रिक्स ऑपरेशन्स (गुणा, ट्रांसपोजिशन, आदि)
  * `B` [यूक्लिडियन डिस्टेंस](src/algorithms/math/euclidean-distance) - दो बिंदुओं/वेक्टरों/मैट्रिक्स के बीच दूरी
  * `A` [पूर्णांक विभाजन](src/algorithms/math/integer-partition)
  * `A` [वर्गमूल](src/algorithms/math/square-root) - न्यूटन की विधि
  * `A` [ल्यू हुई π एल्गोरिद्म](src/algorithms/math/liu-hui) - N-गोन पर आधारित π का अनुमानित मूल्य
  * `A` [डिस्क्रीट फूरियर ट्रांसफॉर्म](src/algorithms/math/fourier-transform) - समय का कोई फंक्शन (सिग्नल) उसकी आवृत्तियों में विभाजित करना
* **सेट्स**
  * `B` [कार्टेशियन प्रोडक्ट](src/algorithms/sets/cartesian-product) - कई सेट्स का गुणनफल
  * `B` [फिशर–येट्स शफल](src/algorithms/sets/fisher-yates) - सीमित अनुक्रम की यादृच्छिक व्यवस्थितता
  * `A` [पावर सेट](src/algorithms/sets/power-set) - किसी सेट के सभी सबसेट्स (बिटवाइज़, बैकट्रैकिंग, और कैस्केडिंग समाधान)
  * `A` [परमुटेशन](src/algorithms/sets/permutations) (पुनरावृत्ति के साथ और बिना)
  * `A` [कॉम्बिनेशन](src/algorithms/sets/combinations) (पुनरावृत्ति के साथ और बिना)
  * `A` [लॉन्गेस्ट कॉमन सबसीक्वेंस](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [लॉन्गेस्ट इंक्रीसिंग सबसीक्वेंस](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [शॉर्टेस्ट कॉमन सुपरसीक्वेंस](src/algorithms/sets/shortest-common-supersequence) (SCS)
  * `A` [नैपसैक समस्या](src/algorithms/sets/knapsack-problem) - "0/1" और "अनबाउंड" संस्करण
  * `A` [मैक्सिमम सबएरे](src/algorithms/sets/maximum-subarray) - "ब्रूट फोर्स" और "डायनामिक प्रोग्रामिंग" (कडाने का) संस्करण
  * `A` [कॉम्बिनेशन सम](src/algorithms/sets/combination-sum) - सभी संयोजन निकालना जो किसी विशिष्ट योग बनाते हैं
* **स्ट्रिंग्स**
  * `B` [हैमिंग दूरी](src/algorithms/string/hamming-distance) - वे स्थान जहाँ प्रतीकों में अंतर है
  * `B` [पलिंड्रोम](src/algorithms/string/palindrome) - यह जांचना कि स्ट्रिंग उलटने पर भी वही है या नहीं
  * `A` [लेवेनश्टीन दूरी](src/algorithms/string/levenshtein-distance) - दो अनुक्रमों के बीच न्यूनतम संपादन दूरी
  * `A` [नथ–मॉरिस–प्रैट एल्गोरिद्म](src/algorithms/string/knuth-morris-pratt) (KMP एल्गोरिद्म) - सबस्ट्रिंग खोज (पैटर्न मिलान)
  * `A` [Z एल्गोरिद्म](src/algorithms/string/z-algorithm) - सबस्ट्रिंग खोज (पैटर्न मिलान)
  * `A` [राबिन कार्प एल्गोरिद्म](src/algorithms/string/rabin-karp) - सबस्ट्रिंग खोज
  * `A` [लॉन्गेस्ट कॉमन सबस्ट्रिंग](src/algorithms/string/longest-common-substring)
  * `A` [रेगुलर एक्सप्रेशन मिलान](src/algorithms/string/regular-expression-matching)
* **सर्चेस**
  * `B` [लिनियर सर्च](src/algorithms/search/linear-search)
  * `B` [जंप सर्च](src/algorithms/search/jump-search) (या ब्लॉक सर्च) - सॉर्टेड ऐरे में सर्च
  * `B` [बाइनरी सर्च](src/algorithms/search/binary-search) - सॉर्टेड ऐरे में सर्च
  * `B` [इंटरपोलेशन सर्च](src/algorithms/search/interpolation-search) - समान रूप से वितरित सॉर्टेड ऐरे में सर्च
* **सॉर्टिंग**
  * `B` [बबल सॉर्ट](src/algorithms/sorting/bubble-sort)
  * `B` [सेलेक्शन सॉर्ट](src/algorithms/sorting/selection-sort)
  * `B` [इन्सर्शन सॉर्ट](src/algorithms/sorting/insertion-sort)
  * `B` [हीप सॉर्ट](src/algorithms/sorting/heap-sort)
  * `B` [मर्ज सॉर्ट](src/algorithms/sorting/merge-sort)
  * `B` [क्विकसॉर्ट](src/algorithms/sorting/quick-sort) - इन-प्लेस और नॉन-इन-प्लेस इम्प्लीमेंटेशन
  * `B` [शेलसॉर्ट](src/algorithms/sorting/shell-sort)
  * `B` [काउंटिंग सॉर्ट](src/algorithms/sorting/counting-sort)
  * `B` [रेडिक्स सॉर्ट](src/algorithms/sorting/radix-sort)
  * `B` [बकेट सॉर्ट](src/algorithms/sorting/bucket-sort)
* **लिंक्ड लिस्ट्स**
  * `B` [सीधा ट्रैवर्सल](src/algorithms/linked-list/traversal)
  * `B` [रिवर्स ट्रैवर्सल](src/algorithms/linked-list/reverse-traversal)
* **ट्रीज़**
  * `B` [डेप्थ-फर्स्ट सर्च](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [ब्रेड्थ-फर्स्ट सर्च](src/algorithms/tree/breadth-first-search) (BFS)
* **ग्राफ्स**
  * `B` [डेप्थ-फर्स्ट सर्च](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [ब्रेड्थ-फर्स्ट सर्च](src/algorithms/graph/breadth-first-search) (BFS)
  * `B` [क्रुस्कल एल्गोरिद्म](src/algorithms/graph/kruskal) - वेटेड अनडायरेक्टेड ग्राफ के लिए न्यूनतम स्पैनिंग ट्री (MST) ढूँढना
  * `A` [डिज्कस्ट्रा एल्गोरिद्म](src/algorithms/graph/dijkstra) - एक ही वर्टेक्स से सभी वर्टेक्स तक सबसे छोटा रास्ता ढूँढना
  * `A` [बेलमैन-फोर्ड एल्गोरिद्म](src/algorithms/graph/bellman-ford) - एक ही वर्टेक्स से सभी वर्टेक्स तक सबसे छोटा रास्ता ढूँढना
  * `A` [फ्लॉयड-वॉरशाल एल्गोरिद्म](src/algorithms/graph/floyd-warshall) - सभी युग्मों के बीच सबसे छोटा रास्ता ढूँढना
  * `A` [सायकल का पता लगाना](src/algorithms/graph/detect-cycle) - डायरेक्टेड और अनडायरेक्टेड दोनों ग्राफ के लिए (DFS और डिसजॉइंट सेट)
  * `A` [प्रिम एल्गोरिद्म](src/algorithms/graph/prim) - वेटेड अनडायरेक्टेड ग्राफ के लिए न्यूनतम स्पैनिंग ट्री (MST) ढूँढना
  * `A` [टोपोलॉजिकल सॉर्टिंग](src/algorithms/graph/topological-sorting) - DFS विधि
  * `A` [आर्टिकुलेशन पॉइंट्स](src/algorithms/graph/articulation-points) - टार्जन एल्गोरिद्म (DFS आधारित)
  * `A` [ब्रिजेस](src/algorithms/graph/bridges) - DFS आधारित एल्गोरिद्म
  * `A` [यूलरियन पाथ और यूलरियन सर्किट](src/algorithms/graph/eulerian-path) - फ्लेरी एल्गोरिद्म - हर एज को एक बार विजिट करें
  * `A` [हैमिल्टोनियन साइकिल](src/algorithms/graph/hamiltonian-cycle) - हर वर्टेक्स को एक बार विजिट करें
  * `A` [स्ट्रॉन्गली कनेक्टेड कंपोनेंट्स](src/algorithms/graph/strongly-connected-components) - कोसाराजू एल्गोरिद्म
  * `A` [ट्रैवलिंग सेल्समैन समस्या](src/algorithms/graph/travelling-salesman) - सबसे छोटा मार्ग जो हर शहर में जाए और वापिस लौटे
* **क्रिप्टोग्राफी**
  * `B` [पॉलिनोमियल हैश](src/algorithms/cryptography/polynomial-hash) - पॉलिनोमियल आधारित रोलिंग हैश फंक्शन
  * `B` [रेल फेंस सिफर](src/algorithms/cryptography/rail-fence-cipher) - संदेशों को एन्कोड करने के लिए ट्रांसपोजिशन सिफर एल्गोरिद्म
  * `B` [सीज़र सिफर](src/algorithms/cryptography/caesar-cipher) - साधारण सब्स्टीट्यूशन सिफर
  * `B` [हिल सिफर](src/algorithms/cryptography/hill-cipher) - रैखिक बीजगणित पर आधारित सब्स्टीट्यूशन सिफर
* **मशीन लर्निंग**
  * `B` [NanoNeuron](https://github.com/trekhleb/nano-neuron) - 7 सिंपल JS फंक्शन्स जो दिखाते हैं कि मशीन कैसे सीख सकती है (फॉरवर्ड/बैकवर्ड प्रोपेगेशन)
  * `B` [k-NN](src/algorithms/ml/knn) - k-नजदीकी पड़ोसी वर्गीकरण एल्गोरिद्म
  * `B` [k-Means](src/algorithms/ml/k-means) - k-मीन्स क्लस्टरिंग एल्गोरिद्म
* **इमेज प्रोसेसिंग**
  * `B` [सीम कार्विंग](src/algorithms/image-processing/seam-carving) - सामग्री-प्रेरित इमेज रिसाइज़िंग एल्गोरिद्म
* **सांख्यिकी**
  * `B` [वेटेड रैंडम](src/algorithms/statistics/weighted-random) - सूची से वज़न के आधार पर यादृच्छिक आइटम का चयन
* **एवोल्यूशनरी एल्गोरिद्म**
  * `A` [जेनेटिक एल्गोरिद्म](https://github.com/trekhleb/self-parking-car-evolution) - जेनेटिक एल्गोरिद्म द्वारा सेल्फ-पार्किंग कारों को ट्रेन करने का उदाहरण
* **अनकैटेगराइज़्ड**
  * `B` [हनोई टॉवर](src/algorithms/uncategorized/hanoi-tower)
  * `B` [वर्ग मैट्रिक्स घुमाव](src/algorithms/uncategorized/square-matrix-rotation) - इन-प्लेस एल्गोरिद्म
  * `B` [जंप गेम](src/algorithms/uncategorized/jump-game) - बैकट्रैकिंग, डायनामिक प्रोग्रामिंग (टॉप-डाउन + बॉटम-अप) और ग्रीडी उदाहरण
  * `B` [युनिक पाथ्स](src/algorithms/uncategorized/unique-paths) - बैकट्रैकिंग, डायनामिक प्रोग्रामिंग और पैस्कल्स ट्रायंगल आधारित उदाहरण
  * `B` [रेन टैरेसेस](src/algorithms/uncategorized/rain-terraces) - ट्रैपिंग रेन वाटर समस्या (डायनामिक प्रोग्रामिंग और ब्रूट फोर्स)
  * `B` [रिकर्सिव स्टेयरकेस](src/algorithms/uncategorized/recursive-staircase) - ऊपर तक पहुँचने के तरीकों की संख्या गिनें (4 समाधान)
  * `B` [शेयर खरीदने-बेचने का सबसे अच्छा समय](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - डिवाइड एंड कंक्वेर और वन-पास उदाहरण
  * `B` [वैध कोष्ठक](src/algorithms/stack/valid-parentheses) - जाँचें कि स्ट्रिंग के कोष्ठक मान्य हैं या नहीं (स्टैक का उपयोग करके)
  * `A` [N-क्वीन समस्या](src/algorithms/uncategorized/n-queens)
  * `A` [नाइट्स टूर](src/algorithms/uncategorized/knight-tour)

### पैरेडाइम के अनुसार एल्गोरिद्म

एल्गोरिद्मिक पैरेडाइम एक सामान्य विधि या दृष्टिकोण है जो एक वर्ग के एल्गोरिद्म के डिज़ाइन के पीछे होता है। यह एल्गोरिद्म की अवधारणा से एक स्तर ऊपर की अमूर्तता है, जैसे कि एल्गोरिद्म कंप्यूटर प्रोग्राम से ऊपर की अमूर्तता है।

* **ब्रूट फोर्स** - सभी संभावनाओं को देखें और सबसे अच्छा समाधान चुनें
  * `B` [लिनियर सर्च](src/algorithms/search/linear-search)
  * `B` [रेन टैरेसेस](src/algorithms/uncategorized/rain-terraces) - ट्रैपिंग रेन वाटर समस्या
  * `B` [रिकर्सिव स्टेयरकेस](src/algorithms/uncategorized/recursive-staircase) - ऊपर तक पहुँचने के तरीकों की संख्या गिनें
  * `A` [मैक्सिमम सबएरे](src/algorithms/sets/maximum-subarray)
  * `A` [ट्रैवलिंग सेल्समैन समस्या](src/algorithms/graph/travelling-salesman) - सबसे छोटा मार्ग जो हर शहर में जाए और वापिस लौटे
  * `A` [डिस्क्रीट फूरियर ट्रांसफॉर्म](src/algorithms/math/fourier-transform) - समय का कोई फंक्शन उसकी आवृत्तियों में विभाजित करना
* **ग्रीडी** - हर समय सबसे अच्छा विकल्प चुनें, भविष्य की चिंता किए बिना
  * `B` [जंप गेम](src/algorithms/uncategorized/jump-game)
  * `A` [अनबाउंड नैपसैक समस्या](src/algorithms/sets/knapsack-problem)
  * `A` [डिज्कस्ट्रा एल्गोरिद्म](src/algorithms/graph/dijkstra) - सभी वर्टेक्स तक सबसे छोटा रास्ता
  * `A` [प्रिम एल्गोरिद्म](src/algorithms/graph/prim) - न्यूनतम स्पैनिंग ट्री
  * `A` [क्रुस्कल एल्गोरिद्म](src/algorithms/graph/kruskal) - न्यूनतम स्पैनिंग ट्री
* **डिवाइड एंड कंक्वेर** - समस्या को छोटे भागों में विभाजित करें और फिर उन्हें हल करें
  * `B` [बाइनरी सर्च](src/algorithms/search/binary-search)
  * `B` [हनोई टॉवर](src/algorithms/uncategorized/hanoi-tower)
  * `B` [पैस्कल्स ट्रायंगल](src/algorithms/math/pascal-triangle)
  * `B` [यूक्लिडियन एल्गोरिद्म](src/algorithms/math/euclidean-algorithm) - GCD निकालना
  * `B` [मर्ज सॉर्ट](src/algorithms/sorting/merge-sort)
  * `B` [क्विकसॉर्ट](src/algorithms/sorting/quick-sort)
  * `B` [ट्री डेप्थ-फर्स्ट सर्च](src/algorithms/tree/depth-first-search) (DFS)
  * `B` [ग्राफ डेप्थ-फर्स्ट सर्च](src/algorithms/graph/depth-first-search) (DFS)
  * `B` [मैट्रिसेज़](src/algorithms/math/matrix) - विभिन्न आकार की मैट्रिक्स बनाना और ट्रैवर्स करना
  * `B` [जंप गेम](src/algorithms/uncategorized/jump-game)
  * `B` [फास्ट पावरिंग](src/algorithms/math/fast-powering)
  * `B` [शेयर खरीदने-बेचने का सबसे अच्छा समय](src/algorithms/uncategorized/best-time-to-buy-sell-stocks) - डिवाइड एंड कंक्वेर और वन-पास उदाहरण
  * `A` [परमुटेशन](src/algorithms/sets/permutations) (पुनरावृत्ति के साथ और बिना)
  * `A` [कॉम्बिनेशन](src/algorithms/sets/combinations) (पुनरावृत्ति के साथ और बिना)
  * `A` [मैक्सिमम सबएरे](src/algorithms/sets/maximum-subarray)
* **डायनामिक प्रोग्रामिंग** - पहले से पाए गए उप-समाधानों का उपयोग करके समाधान बनाना
  * `B` [फिबोनाच्ची संख्या](src/algorithms/math/fibonacci)
  * `B` [जंप गेम](src/algorithms/uncategorized/jump-game)
  * `B` [युनिक पाथ्स](src/algorithms/uncategorized/unique-paths)
  * `B` [रेन टैरेसेस](src/algorithms/uncategorized/rain-terraces) - ट्रैपिंग रेन वाटर समस्या
  * `B` [रिकर्सिव स्टेयरकेस](src/algorithms/uncategorized/recursive-staircase) - ऊपर तक पहुँचने के तरीकों की संख्या गिनें
  * `B` [सीम कार्विंग](src/algorithms/image-processing/seam-carving) - सामग्री-प्रेरित इमेज रिसाइज़िंग एल्गोरिद्म
  * `A` [लेवेनश्टीन दूरी](src/algorithms/string/levenshtein-distance) - दो अनुक्रमों के बीच न्यूनतम संपादन दूरी
  * `A` [लॉन्गेस्ट कॉमन सबसीक्वेंस](src/algorithms/sets/longest-common-subsequence) (LCS)
  * `A` [लॉन्गेस्ट कॉमन सबस्ट्रिंग](src/algorithms/string/longest-common-substring)
  * `A` [लॉन्गेस्ट इंक्रीसिंग सबसीक्वेंस](src/algorithms/sets/longest-increasing-subsequence)
  * `A` [शॉर्टेस्ट कॉमन सुपरसीक्वेंस](src/algorithms/sets/shortest-common-supersequence)
  * `A` [0/1 नैपसैक समस्या](src/algorithms/sets/knapsack-problem)
  * `A` [पूर्णांक विभाजन](src/algorithms/math/integer-partition)
  * `A` [मैक्सिमम सबएरे](src/algorithms/sets/maximum-subarray)
  * `A` [बेलमैन-फोर्ड एल्गोरिद्म](src/algorithms/graph/bellman-ford) - सभी वर्टेक्स तक सबसे छोटा रास्ता
  * `A` [फ्लॉयड-वॉरशाल एल्गोरिद्म](src/algorithms/graph/floyd-warshall) - सभी युग्मों के बीच सबसे छोटा रास्ता
  * `A` [रेगुलर एक्सप्रेशन मिलान](src/algorithms/string/regular-expression-matching)
* **बैकट्रैकिंग** - ब्रूट फोर्स के समान, सभी संभावित समाधान उत्पन्न करने की कोशिश करें, लेकिन हर बार जब आप अगला समाधान उत्पन्न करते हैं, तो जांचें कि क्या यह सभी शर्तों को पूरा करता है, और तभी आगे बढ़ें। अन्यथा, बैकट्रैक करें और समाधान की खोज के लिए दूसरा रास्ता लें। सामान्यतः, स्टेट-स्पेस का DFS ट्रैवर्सल उपयोग किया जाता है।
  * `B` [जंप गेम](src/algorithms/uncategorized/jump-game)
  * `B` [युनिक पाथ्स](src/algorithms/uncategorized/unique-paths)
  * `B` [पावर सेट](src/algorithms/sets/power-set) - सभी सबसेट्स
  * `A` [हैमिल्टोनियन साइकिल](src/algorithms/graph/hamiltonian-cycle) - हर वर्टेक्स को एक बार विजिट करें
  * `A` [N-क्वीन समस्या](src/algorithms/uncategorized/n-queens)
  * `A` [नाइट्स टूर](src/algorithms/uncategorized/knight-tour)
  * `A` [कॉम्बिनेशन सम](src/algorithms/sets/combination-sum) - विशिष्ट योग बनाने वाले सभी संयोजन निकालें
* **ब्रांच & बाउंड** - बैकट्रैकिंग सर्च के हर चरण में अब तक मिले सबसे कम लागत वाले समाधान को याद रखें, और इसी लागत को समस्या के न्यूनतम लागत समाधान के लिए न्यूनतम सीमा के रूप में उपयोग करें ताकि उन आंशिक समाधानों को छोड़ दिया जाए जिनकी लागत इससे अधिक है। सामान्यतः, BFS ट्रैवर्सल का DFS ट्रैवर्सल के साथ संयोजन उपयोग किया जाता है।

## इस रिपॉजिटरी का उपयोग कैसे करें

**सभी डिपेंडेंसीज़ इंस्टॉल करें**

```
npm install
```

**ESLint चलाएँ**

आप इसे कोड क्वालिटी जांचने के लिए चला सकते हैं।

```
npm run lint
```

**सभी टेस्ट चलाएँ**

```
npm test
```

**नाम से टेस्ट चलाएँ**

```
npm test -- 'LinkedList'
```

**समस्या निवारण**

अगर लिंटिंग या टेस्टिंग फेल हो रही हो, तो `node_modules` फोल्डर डिलीट करके npm पैकेज दोबारा इंस्टॉल करें:

```
rm -rf ./node_modules
npm i
```

साथ ही, सुनिश्चित करें कि आप सही Node वर्शन (`>=16`) का उपयोग कर रहे हैं। अगर आप Node वर्शन मैनेजमेंट के लिए [nvm](https://github.com/nvm-sh/nvm) का उपयोग कर रहे हैं, तो प्रोजेक्ट के रूट फोल्डर से `nvm use` चला सकते हैं और सही वर्शन ले लिया जाएगा।

**प्लेग्राउंड**

आप `./src/playground/playground.js` फाइल में डेटा-स्ट्रक्चर और एल्गोरिद्म के साथ प्रयोग कर सकते हैं और उसके लिए टेस्ट `./src/playground/__test__/playground.test.js` में लिख सकते हैं।

फिर, बस निम्नलिखित कमांड चलाएँ ताकि आपके प्लेग्राउंड कोड की जांच हो सके:

```
npm test -- 'playground'
```

## उपयोगी जानकारी

### संदर्भ

- [▶ यूट्यूब पर डेटा संरचनाएँ और एल्गोरिद्म](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)
- [✍🏻 डेटा संरचना स्केच](https://okso.app/showcase/data-structures)

### बिग O संकेतन

*बिग O नोटेशन* का उपयोग एल्गोरिद्म को वर्गीकृत करने के लिए किया जाता है कि उनकी रनिंग टाइम या स्पेस आवश्यकताएँ इनपुट साइज़ के बढ़ने पर कैसे बढ़ती हैं।
नीचे दिए गए चार्ट में, आप बिग O नोटेशन में एल्गोरिद्म की सबसे सामान्य वृद्धि क्रम देख सकते हैं।

![Big O graphs](./assets/big-o-graph.png)

स्रोत: [Big O चीट शीट](http://bigocheatsheet.com/)।

नीचे कुछ सबसे अधिक उपयोग किए जाने वाले बिग O नोटेशनों की सूची है और विभिन्न इनपुट साइज़ के लिए उनके प्रदर्शन की तुलना दी गई है।

| बिग O नोटेशन | प्रकार         | 10 एलिमेंट्स के लिए गणना | 100 एलिमेंट्स के लिए गणना | 1000 एलिमेंट्स के लिए गणना  |
| -------------- | ----------- | ---------------------------- | ----------------------------- | ------------------------------- |
| **O(1)**       | स्थिर        | 1                            | 1                             | 1                               |
| **O(log N)**   | लघुगणकीय    | 3                            | 6                             | 9                               |
| **O(N)**       | रैखिक       | 10                           | 100                           | 1000                            |
| **O(N log N)** | n log(n)    | 30                           | 600                           | 9000                            |
| **O(N^2)**     | द्विघात      | 100                          | 10000                         | 1000000                         |
| **O(2^N)**     | घातांकी      | 1024                         | 1.26e+29                      | 1.07e+301                       |
| **O(N!)**      | फैक्टोरियल   | 3628800                      | 9.3e+157                      | 4.02e+2567                      |

### डेटा संरचना ऑपरेशन्स की जटिलता

| डेटा संरचना          | एक्सेस    | सर्च    | इंसर्शन | डिलीशन  | टिप्पणियाँ  |
| --------------------- | :-------: | :-------: | :-------: | :-------: | :-------- |
| **ऐरे**               | 1         | n         | n         | n         |           |
| **स्टैक**             | n         | n         | 1         | 1         |           |
| **क्यू**              | n         | n         | 1         | 1         |           |
| **लिंक्ड लिस्ट**      | n         | n         | 1         | n         |           |
| **हैश टेबल**          | -         | n         | n         | n         | अगर परफेक्ट हैश फंक्शन है तो O(1) |
| **बाइनरी सर्च ट्री**  | n         | n         | n         | n         | बैलेंस्ड ट्री में लागत O(log(n)) |
| **बी-ट्री**           | log(n)    | log(n)    | log(n)    | log(n)    |           |
| **रेड-ब्लैक ट्री**    | log(n)    | log(n)    | log(n)    | log(n)    |           |
| **AVL ट्री**          | log(n)    | log(n)    | log(n)    | log(n)    |           |
| **ब्लूम फिल्टर**      | -         | 1         | 1         | -         | सर्च के दौरान फॉल्स पॉजिटिव संभव |

### ऐरे सॉर्टिंग एल्गोरिद्म की जटिलता

| नाम                   | सर्वश्रेष्ठ         | औसत               | सबसे खराब           | मेमोरी   | स्थिर      | टिप्पणियाँ  |
| --------------------- | :-------------: | :-----------------: | :-----------------: | :-------: | :-------: | :-------- |
| **बबल सॉर्ट**        | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1         | हाँ        |           |
| **इन्सर्शन सॉर्ट**   | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1         | हाँ        |           |
| **सेलेक्शन सॉर्ट**   | n<sup>2</sup>   | n<sup>2</sup>       | n<sup>2</sup>       | 1         | नहीं       |           |
| **हीप सॉर्ट**        | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | 1         | नहीं       |           |
| **मर्ज सॉर्ट**       | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | n         | हाँ        |           |
| **क्विक सॉर्ट**      | n&nbsp;log(n)   | n&nbsp;log(n)       | n<sup>2</sup>       | log(n)    | नहीं       | क्विकसॉर्ट आमतौर पर इन-प्लेस O(log(n)) स्टैक स्पेस के साथ होता है |
| **शेल सॉर्ट**        | n&nbsp;log(n)   | गैप अनुक्रम पर निर्भर | n&nbsp;(log(n))<sup>2</sup>  | 1         | नहीं       |           |
| **काउंटिंग सॉर्ट**   | n + r           | n + r               | n + r               | n + r     | हाँ        | r - ऐरे में सबसे बड़ी संख्या |
| **रेडिक्स सॉर्ट**    | n * k           | n * k               | n * k               | n + k     | हाँ        | k - सबसे लंबी कुंजी की लंबाई |

## प्रोजेक्ट समर्थक

> आप इस प्रोजेक्ट को ❤️️ [GitHub](https://github.com/sponsors/trekhleb) या ❤️️ [Patreon](https://www.patreon.com/trekhleb) के माध्यम से समर्थन दे सकते हैं।

[इस प्रोजेक्ट को समर्थन देने वाले लोग](https://github.com/trekhleb/javascript-algorithms/blob/master/BACKERS.md) `∑ = 1`

## लेखक

[@trekhleb](https://trekhleb.dev)

[trekhleb.dev](https://trekhleb.dev) पर जावास्क्रिप्ट और एल्गोरिद्म से संबंधित कुछ और [प्रोजेक्ट्स](https://trekhleb.dev/projects/) और [आर्टिकल्स](https://trekhleb.dev/blog/)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---