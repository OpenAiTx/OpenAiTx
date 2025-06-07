[![Star History Chart](https://api.star-history.com/svg?repos=labuladong/fucking-algorithm&type=Date)](https://star-history.com/#labuladong/fucking-algorithm&Date)

अंग्रेज़ी संस्करण [labuladong.online](https://labuladong.online/algo/en/) पर भी उपलब्ध है। बस आनंद लें:)

# labuladong की एल्गोरिदम नोट्स

इस रिपॉजिटरी में कुल 60 से अधिक मौलिक लेख हैं, जो सभी LeetCode की समस्याओं पर आधारित हैं, और इसमें सभी प्रश्न प्रकार व तकनीकें शामिल हैं। साथ ही, इसमें **व्यावहारिक उदाहरण, सरल भाषा** का ध्यान रखा गया है, केवल कोड का ढेर नहीं है, आगे सामग्री की सूची भी दी है।

मैं पहले थोड़ी बात करना चाहूँगा। **प्रश्न हल करना केवल प्रश्न हल करना नहीं है, यह सोचने का तरीका विकसित करता है, इस रिपॉजिटरी का उद्देश्य यही एल्गोरिदम सोच पहुँचाना है**। यदि मैं केवल LeetCode समस्याओं का कोड डाल दूँ, तो उसका क्या उपयोग? अगर सोच की व्याख्या और फ्रेमवर्क न हो, तो अधिकतम समय जटिलता लिख दूँ, लेकिन वह तो पहली नजर में दिख जाता है।

अगर केवल उत्तर चाहिए, तो वह तो बहुत आसान है, समस्याओं की टिप्पणियों में तरह-तरह के उत्तर मिल जाते हैं, एक लाइन के Python कोड से हल कर देते हैं, बहुत से लोग लाइक करते हैं। लेकिन सवाल यह है, आप एल्गोरिदम समस्याएँ हल करने आए हैं प्रोग्रामिंग भाषा की चालाकी सीखने या एल्गोरिदम की सोच सीखने? आपकी खुशी आखिर कहां है—दूसरों का कोड कॉपी कर के प्रश्न +1 करना, या अपनी तार्किक सोच और फ्रेमवर्क से बिना उत्तर देखे हल करना?

ऑनलाइन कई विशेषज्ञ मुझे कहते हैं कि मैं बहुत बेसिक लिखता हूँ, या फ्रेमवर्क सोच से एल्गोरिदम नहीं सीखा जा सकता। मेरा कहना है कि एल्गोरिदम सीखना नौकरी के लिए है, प्रतियोगिता के लिए नहीं, मैं भी ऐसे ही सीखा हूँ। हमें चाहिए स्पष्टता, न कि रहस्य।

अगर सरल भाषा में समझाने की कोशिश न की जाए, तो क्या पहले "Introduction to Algorithms" की तारीफ करूं और फिर लोगों को डरा दूं?

**कोई भी काम बार-बार करने से उसमें पैटर्न मिल जाता है, मैंने अलग-अलग एल्गोरिदम पैटर्न और फ्रेमवर्क का सारांश निकाला है, जिससे दूसरों को समय बचाने में मदद मिलेगी**। मैंने खुद से, एक साल तक प्रश्न हल करके और सारांश लिखकर, अपनी खुद की एल्गोरिदम शॉर्टनोट्स तैयार की है, आगे सामग्री सूची दी है, यहां ज्यादा विस्तार नहीं करता।

## सीखना शुरू करने से पहले

**1. पहले इस रिपॉजिटरी को एक स्टार दें, मेरी虚荣心(आत्मसंतुष्टि) के लिए**। लेख की गुणवत्ता एक स्टार के लायक है। मैं आगे भी लिख रहा हूँ, कृपया मुझे प्रेरणा दें, धन्यवाद।

**2. मेरी ऑनलाइन वेबसाइट को बुकमार्क करने की सलाह है, हर लेख की शुरुआत में संबंधित LeetCode प्रश्न का लिंक है, साथ में प्रश्न हल कर सकते हैं, कुल 500 प्रश्नों तक हाथ पकड़ कर हल करवाऊंगा**:

2024 नवीनतम पता: https://labuladong.online/algo/

~~GitHub Pages पता: https://labuladong.online/algo/~~

~~Gitee Pages पता: https://labuladong.gitee.io/algo/~~

## labuladong प्रश्न हल करने का पूरा पैकेज परिचय

### 1. एल्गोरिदम विज़ुअलाइज़ेशन पैनल

मेरी एल्गोरिदम वेबसाइट और सभी सहायक प्लगइन्स में एक एल्गोरिदम विज़ुअलाइज़ेशन टूल शामिल है, जो डाटा स्ट्रक्चर और रिकर्सन प्रक्रिया को विज़ुअलाइज़ करता है, जिससे समझना बेहद आसान हो जाता है। लगभग हर प्रश्न के हल के साथ विज़ुअलाइजेशन पैनल है, विवरण नीचे देखें।

### 2. लर्निंग वेबसाइट

सामग्री निश्चित रूप से मेरी एल्गोरिदम शृंखला ट्यूटोरियल का सबसे मुख्य हिस्सा है, मेरे एल्गोरिदम ट्यूटोरियल वेबसाइट [labuladong.online](https://labuladong.online/algo/) पर प्रकाशित हैं, यकीन है कि आप यहां काफी समय सीखने में बिताएंगे, केवल बुकमार्क में नहीं रखेंगे~

![](https://labuladong.github.io/pictures/简介/web_intro1.jpg)

### 3. Chrome प्लगइन

**मुख्य कार्य:** Chrome प्लगइन LeetCode (चीनी या अंग्रेज़ी) पर मेरे "समाधान" या "सोच" जल्दी देखने की सुविधा देता है, और प्रश्न व एल्गोरिदम तकनीकों के बीच संदर्भ जोड़ता है, वेबसाइट/पब्लिक अकाउंट/कोर्स के साथ काम करता है, जिससे पाठकों को बेहतरीन प्रश्न हल करने का अनुभव मिलता है। इंस्टालेशन मैनुअल नीचे सामग्री सूची में है।

![](https://labuladong.github.io/pictures/简介/chrome_intro.jpg)

### 4. vscode प्लगइन

**मुख्य कार्य:** Chrome प्लगइन जैसे ही कार्य, जो vscode पर प्रश्न हल करने वाले पाठकों के लिए है। इंस्टालेशन मैनुअल नीचे सामग्री सूची में है।

![](https://labuladong.github.io/pictures/简介/vs_intro.jpg)

### 5. Jetbrains प्लगइन

**मुख्य कार्य:** Chrome प्लगइन जैसे ही कार्य, Jetbrains के IDE (PyCharm/Intellij/Goland आदि) पर प्रश्न हल करने वालों के लिए। इंस्टालेशन मैनुअल नीचे सामग्री सूची में है।

![](https://labuladong.github.io/pictures/简介/jb_intro.jpg)

अंत में, सभी को शुभकामनाएँ, सीखने में आनंद लें, प्रश्नों के समुद्र में मुक्त तैरें!

# लेख सूची

<!-- table start -->

### [वेबसाइट परिचय](https://labuladong.online/algo/home/)

### [सहायक प्लगइन और एल्गोरिदम विज़ुअलाइज़ेशन](https://labuladong.online/algo/menu/tools/)
  * [Chrome प्रश्न हल प्लगइन](https://labuladong.online/algo/intro/chrome/)
  * [vscode प्रश्न हल प्लगइन](https://labuladong.online/algo/intro/vscode/)
  * [JetBrains प्रश्न हल प्लगइन](https://labuladong.online/algo/intro/jetbrains/)
  * [एल्गोरिदम विज़ुअलाइज़ेशन पैनल उपयोग गाइड](https://labuladong.online/algo/intro/visualize/)
  * [वेबसाइट पेड मेंबरशिप](https://labuladong.online/algo/intro/site-vip/)

### [शुरुआती और त्वरित सीखने के लिए योजना](https://labuladong.online/algo/menu/plan/)
  * [एल्गोरिदम प्रश्न हल करने के बिंदु और जाल](https://labuladong.online/algo/intro/how-to-learn-algorithms/)
  * [शुरुआती के लिए अध्ययन योजना](https://labuladong.online/algo/intro/beginner-learning-plan/)
  * [त्वरित अध्ययन योजना](https://labuladong.online/algo/intro/quick-learning-plan/)
  * [अभ्यास/पुनरावृत्ति के तरीके](https://labuladong.online/algo/intro/how-to-practice/)
  * [एल्गोरिदम विज़ुअलाइज़ेशन त्वरित पृष्ठ](https://labuladong.online/algo/intro/visualize-catalog/)

### [प्रवेश: प्रोग्रामिंग भाषा मूल बातें और अभ्यास](https://labuladong.online/algo/menu/)
  * [इस अध्याय का परिचय](https://labuladong.online/algo/intro/programming-language-basic/)
  * [C++ भाषा मूल बातें](https://labuladong.online/algo/programming-language-basic/cpp/)
  * [Java भाषा मूल बातें](https://labuladong.online/algo/programming-language-basic/java/)
  * [Golang भाषा मूल बातें](https://labuladong.online/algo/programming-language-basic/golang/)
  * [Python भाषा मूल बातें](https://labuladong.online/algo/programming-language-basic/python/)
  * [JavaScript भाषा मूल बातें](https://labuladong.online/algo/intro/js/)
  * [LeetCode/力扣 प्रश्न हल करने की जानकारी](https://labuladong.online/algo/intro/leetcode/)
  * [प्रोग्रामिंग भाषा में प्रश्न हल करने का अभ्यास](https://labuladong.online/algo/programming-language-basic/lc-practice/)

### [मूल: डाटा स्ट्रक्चर और सॉर्टिंग विशेष अध्याय](https://labuladong.online/algo/menu/quick-start/)
  * [इस अध्याय का परिचय](https://labuladong.online/algo/intro/data-structure-basic/)
  * [समय और स्थान जटिलता की शुरुआत](https://labuladong.online/algo/intro/complexity-basic/)

  * [डायनामिक ऐरे को हाथ पकड़ कर लागू करें](https://labuladong.online/algo/menu/dynamic-array/)
    * [ऐरे (सिक्वेंशियल स्टोरेज) का मूल सिद्धांत](https://labuladong.online/algo/data-structure-basic/array-basic/)
    * [डायनामिक ऐरे कोड इम्प्लीमेंटेशन](https://labuladong.online/algo/data-structure-basic/array-implement/)

  * [सिंगल/डबल लिंक्ड लिस्ट को हाथ पकड़ कर लागू करें](https://labuladong.online/algo/menu/linked-list/)
    * [लिंक्ड लिस्ट (चेन स्टोरेज) का मूल सिद्धांत](https://labuladong.online/algo/data-structure-basic/linkedlist-basic/)
    * [लिंक्ड लिस्ट कोड इम्प्लीमेंटेशन](https://labuladong.online/algo/data-structure-basic/linkedlist-implement/)

  * [क्यू/स्टैक को हाथ पकड़ कर लागू करें](https://labuladong.online/algo/menu/queue-stack/)
    * [क्यू/स्टैक का मूल सिद्धांत](https://labuladong.online/algo/data-structure-basic/queue-stack-basic/)
    * [लिंक्ड लिस्ट से क्यू/स्टैक बनाएं](https://labuladong.online/algo/data-structure-basic/linked-queue-stack/)
    * [रिंग ऐरे तकनीक](https://labuladong.online/algo/data-structure-basic/cycle-array/)
    * [ऐरे से क्यू/स्टैक बनाएं](https://labuladong.online/algo/data-structure-basic/array-queue-stack/)
    * [डबल एंडेड क्यू (Deque) सिद्धांत और इम्प्लीमेंटेशन](https://labuladong.online/algo/data-structure-basic/deque-implement/)

  * [हैश टेबल का सिद्धांत और इम्प्लीमेंटेशन](https://labuladong.online/algo/menu/)
    * [हैश टेबल का मूल सिद्धांत](https://labuladong.online/algo/data-structure-basic/hashmap-basic/)
    * [चेनिंग विधि से हैश टेबल बनाएं](https://labuladong.online/algo/data-structure-basic/hashtable-chaining/)
    * [लिनियर प्रोबिंग के दो मुश्किल बिंदु](https://labuladong.online/algo/data-structure-basic/linear-probing-key-point/)
    * [लिनियर प्रोबिंग के दो कोड इम्प्लीमेंटेशन](https://labuladong.online/algo/data-structure-basic/linear-probing-code/)
    * [हैश सेट का सिद्धांत और कोड इम्प्लीमेंटेशन](https://labuladong.online/algo/data-structure-basic/hash-set/)

  * [हैश टेबल स्ट्रक्चर के विविध परिवर्तन](https://labuladong.online/algo/menu/)
    * [लिंक्ड लिस्ट से हैश टेबल को मजबूत बनाएं (LinkedHashMap)](https://labuladong.online/algo/data-structure-basic/hashtable-with-linked-list/)
    * [ऐरे से हैश टेबल को मजबूत बनाएं (ArrayHashMap)](https://labuladong.online/algo/data-structure-basic/hashtable-with-array/)

  * [बाइनरी ट्री स्ट्रक्चर और ट्रैवर्सल](https://labuladong.online/algo/menu/binary-tree/)
    * [बाइनरी ट्री की मूल बातें और सामान्य प्रकार](https://labuladong.online/algo/data-structure-basic/binary-tree-basic/)
    * [बाइनरी ट्री का रिकर्सन/लेवल ऑर्डर ट्रैवर्सल](https://labuladong.online/algo/data-structure-basic/binary-tree-traverse-basic/)
    * [मल्टी-वे ट्री का रिकर्सन/लेवल ऑर्डर ट्रैवर्सल](https://labuladong.online/algo/data-structure-basic/n-ary-tree-traverse-basic/)

  * [बाइनरी ट्री स्ट्रक्चर के विविध परिवर्तन](https://labuladong.online/algo/menu/binary-tree/)
    * [बाइनरी सर्च ट्री की एप्लीकेशन और विज़ुअलाइज़ेशन](https://labuladong.online/algo/data-structure-basic/tree-map-basic/)
    * [रेड-ब्लैक ट्री का संतुलन और विज़ुअलाइज़ेशन](https://labuladong.online/algo/data-structure-basic/rbtree-basic/)
    * [Trie/डिक्शनरी ट्री/प्रिफिक्स ट्री का सिद्धांत और विज़ुअलाइज़ेशन](https://labuladong.online/algo/data-structure-basic/trie-map-basic/)
    * [बाइनरी हीप का मूल सिद्धांत और विज़ुअलाइज़ेशन](https://labuladong.online/algo/data-structure-basic/binary-heap-basic/)
    * [बाइनरी हीप/प्रायोरिटी क्यू कोड इम्प्लीमेंटेशन](https://labuladong.online/algo/data-structure-basic/binary-heap-implement/)
    * [सेगमेंट ट्री का मूल सिद्धांत और विज़ुअलाइज़ेशन](https://labuladong.online/algo/data-structure-basic/segment-tree-basic/)
    * [अपडेटिंग चल रही है](https://labuladong.online/algo/intro/updating/)

  * [ग्राफ थ्योरी डाटा स्ट्रक्चर और ट्रैवर्सल](https://labuladong.online/algo/menu/graph-theory/)
    * [ग्राफ स्ट्रक्चर की मूल बातें और सामान्य कोड इम्प्लीमेंटेशन](https://labuladong.online/algo/data-structure-basic/graph-basic/)
    * [ग्राफ स्ट्रक्चर का DFS/BFS ट्रैवर्सल](https://labuladong.online/algo/data-structure-basic/graph-traverse-basic/)
    * [Union Find (यूनियन-फाइंड) सिद्धांत](https://labuladong.online/algo/data-structure-basic/union-find-basic/)
    * [अपडेटिंग चल रही है](https://labuladong.online/algo/intro/updating/)

  * [शीर्ष 10 सॉर्टिंग एल्गोरिदम सिद्धांत और विज़ुअलाइज़ेशन](https://labuladong.online/algo/menu/sorting/)
    * [इस अध्याय का परिचय](https://labuladong.online/algo/intro/sorting/)
    * [सॉर्टिंग एल्गोरिदम के मुख्य मापदंड](https://labuladong.online/algo/data-structure-basic/sort-basic/)
    * [चयन सॉर्ट की समस्याएँ](https://labuladong.online/algo/data-structure-basic/select-sort/)
    * [स्थिरता के साथ: बबल सॉर्ट](https://labuladong.online/algo/data-structure-basic/bubble-sort/)
    * [विपरीत सोच: इंसर्शन सॉर्ट](https://labuladong.online/algo/data-structure-basic/insertion-sort/)
    * [O(N^2) से आगे: शेल सॉर्ट](https://labuladong.online/algo/data-structure-basic/shell-sort/)
    * [बाइनरी ट्री प्री-ऑर्डर का उपयोग: क्विक सॉर्ट](https://labuladong.online/algo/data-structure-basic/quick-sort/)
    * [बाइनरी ट्री पोस्ट-ऑर्डर का उपयोग: मर्ज सॉर्ट](https://labuladong.online/algo/data-structure-basic/merge-sort/)
    * [बाइनरी हीप का उपयोग: हीप सॉर्ट](https://labuladong.online/algo/data-structure-basic/heap-sort/)
    * [नई सॉर्टिंग विधि: काउंटिंग सॉर्ट](https://labuladong.online/algo/data-structure-basic/counting-sort/)
    * [सर्वश्रेष्ठ तकनीकों का मिश्रण: बकेट सॉर्ट](https://labuladong.online/algo/data-structure-basic/bucket-sort/)
    * [रेडिक्स सॉर्ट](https://labuladong.online/algo/data-structure-basic/radix-sort/)

  * [अपडेटिंग चल रही है](https://labuladong.online/algo/intro/updating/)


### [शून्य अध्याय, मुख्य प्रश्न हल करने के फ्रेमवर्क का सारांश](https://labuladong.online/algo/menu/core/)
  * [इस अध्याय का परिचय](https://labuladong.online/algo/intro/core-intro/)
  * [डाटा स्ट्रक्चर और एल्गोरिदम का फ्रेमवर्क सोच](https://labuladong.online/algo/essential-technique/algorithm-summary/)
  * [डबल पॉइंटर तकनीक से सात लिंक्ड लिस्ट प्रश्न हल करें](https://labuladong.online/algo/essential-technique/linked-list-skills-summary/)
  * [डबल पॉइंटर तकनीक से सात ऐरे प्रश्न हल करें](https://labuladong.online/algo/essential-technique/array-two-pointers-summary/)
  * [स्लाइडिंग विंडो एल्गोरिदम मुख्य कोड टेम्पलेट](https://labuladong.online/algo/essential-technique/sliding-window-framework/)
  * [बाइनरी सर्च एल्गोरिदम मुख्य कोड टेम्पलेट](https://labuladong.online/algo/essential-technique/binary-search-framework/)
  * [डायनामिक प्रोग्रामिंग प्रश्न हल करने का फ्रेमवर्क](https://labuladong.online/algo/essential-technique/dynamic-programming-framework/)
  * [बैकट्रैक एल्गोरिदम प्रश्न हल करने का फ्रेमवर्क](https://labuladong.online/algo/essential-technique/backtrack-framework/)
  * [BFS एल्गोरिदम प्रश्न हल करने का फ्रेमवर्क](https://labuladong.online/algo/essential-technique/bfs-framework/)
  * [बाइनरी ट्री एल्गोरिदम मुख्य दिशानिर्देश](https://labuladong.online/algo/essential-technique/binary-tree-summary/)
  * [बैकट्रैक एल्गोरिदम से सभी परिमुटेशन/कंबिनेशन/सबसेट प्रश्न हल करें](https://labuladong.online/algo/essential-technique/permutation-combination-subset-all-in-one/)
  * [ग्रीडी एल्गोरिदम प्रश्न हल करने का फ्रेमवर्क](https://labuladong.online/algo/essential-technique/greedy/)
  * [डिवाइड एंड कॉन्कर एल्गोरिदम प्रश्न हल करने का फ्रेमवर्क](https://labuladong.online/algo/essential-technique/divide-and-conquer/)
  * [एल्गोरिदम समय-स्थान जटिलता विश्लेषण गाइड](https://labuladong.online/algo/essential-technique/complexity-analysis/)


### [पहला अध्याय, क्लासिक डाटा स्ट्रक्चर एल्गोरिदम](https://labuladong.online/algo/menu/ds/)
  * [लिंक्ड लिस्ट एल्गोरिदम को हाथ पकड़ कर हल करें](https://labuladong.online/algo/menu/linked-list/)
    * [डबल पॉइंटर तकनीक से सात लिंक्ड लिस्ट प्रश्न हल करें](https://labuladong.online/algo/essential-technique/linked-list-skills-summary/)
    * [【मजबूत अभ्यास】लिंक्ड लिस्ट डबल पॉइंटर क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/linkedlist-two-pointers/)
    * [सिंगल लिंक्ड लिस्ट रिवर्स करने की विभिन्न विधियाँ](https://labuladong.online/algo/data-structure/reverse-linked-list-recursion/)
    * [कैसे पहचानें कि लिंक्ड लिस्ट पैलिंड्रोम है](https://labuladong.online/algo/data-structure/palindrome-linked-list/)

  * [ऐरे एल्गोरिदम को हाथ पकड़ कर हल करें](https://labuladong.online/algo/menu/array/)
    * [डबल पॉइंटर तकनीक से सात ऐरे प्रश्न हल करें](https://labuladong.online/algo/essential-technique/array-two-pointers-summary/)
    * [2D ऐरे के ट्रैवर्सल की विशेष तकनीकें](https://labuladong.online/algo/practice-in-action/2d-array-traversal-summary/)
    * [एक विधि से nSum समस्याएँ हल करें](https://labuladong.online/algo/practice-in-action/nsum/)
    * [【मजबूत अभ्यास】ऐरे डबल पॉइंटर क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/array-two-pointers/)
    * [छोटी लेकिन सुंदर तकनीक: प्रिफिक्स सम ऐरे](https://labuladong.online/algo/data-structure/prefix-sum/)
    * [【मजबूत अभ्यास】प्रिफिक्स सम तकनीक क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/perfix-sum/)
    * [छोटी लेकिन सुंदर तकनीक: डिफरेंस ऐरे](https://labuladong.online/algo/data-structure/diff-array/)
    * [स्लाइडिंग विंडो एल्गोरिदम मुख्य कोड टेम्पलेट](https://labuladong.online/algo/essential-technique/sliding-window-framework/)
    * [【मजबूत अभ्यास】स्लाइडिंग विंडो एल्गोरिदम क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/sliding-window/)
    * [स्लाइडिंग विंडो विस्तार: Rabin Karp स्ट्रिंग मैचिंग एल्गोरिदम](https://labuladong.online/algo/practice-in-action/rabinkarp/)
    * [बाइनरी सर्च एल्गोरिदम मुख्य कोड टेम्पलेट](https://labuladong.online/algo/essential-technique/binary-search-framework/)
    * [वास्तविक उपयोग में बाइनरी सर्च सोच](https://labuladong.online/algo/frequency-interview/binary-search-in-action/)
    * [【मजबूत अभ्यास】बाइनरी सर्च एल्गोरिदम क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/binary-search/)
    * [वेटेड रैंडम सिलेक्शन एल्गोरिदम](https://labuladong.online/algo/frequency-interview/random-pick-with-weight/)
    * [Tian Ji घोड़ा दौड़ के पीछे का एल्गोरिदम निर्णय](https://labuladong.online/algo/practice-in-action/advantage-shuffle/)


  * [बाइनरी ट्री एल्गोरिदम को हाथ पकड़ कर हल करें](https://labuladong.online/algo/menu/binary-tree/)
    * [बाइनरी ट्री एल्गोरिदम मुख्य दिशानिर्देश](https://labuladong.online/algo/essential-technique/binary-tree-summary/)
    * [बाइनरी ट्री सोच (विचार भाग)](https://labuladong.online/algo/data-structure/binary-tree-part1/)
    * [बाइनरी ट्री सोच (निर्माण भाग)](https://labuladong.online/algo/data-structure/binary-tree-part2/)
    * [बाइनरी ट्री सोच (पोस्ट-ऑर्डर भाग)](https://labuladong.online/algo/data-structure/binary-tree-part3/)
    * [बाइनरी ट्री सोच (सीरियलाइजेशन भाग)](https://labuladong.online/algo/data-structure/serialize-and-deserialize-binary-tree/)
    * [बाइनरी सर्च ट्री सोच (गुणभाग)](https://labuladong.online/algo/data-structure/bst-part1/)
    * [बाइनरी सर्च ट्री सोच (मूल ऑपरेशन)](https://labuladong.online/algo/data-structure/bst-part2/)
    * [बाइनरी सर्च ट्री सोच (निर्माण भाग)](https://labuladong.online/algo/data-structure/bst-part3/)
    * [बाइनरी सर्च ट्री सोच (पोस्ट-ऑर्डर भाग)](https://labuladong.online/algo/data-structure/bst-part4/)

  * [100 बाइनरी ट्री प्रश्न टेम्पलेट से हल करें](https://labuladong.online/algo/menu/100-bt/)
    * [इस अध्याय का परिचय](https://labuladong.online/algo/intro/binary-tree-practice/)
    * [【मजबूत अभ्यास】"ट्रैवर्सल" सोच से हल करें I](https://labuladong.online/algo/problem-set/binary-tree-traverse-i/)
    * [【मजबूत अभ्यास】"ट्रैवर्सल" सोच से हल करें II](https://labuladong.online/algo/problem-set/binary-tree-traverse-ii/)
    * [【मजबूत अभ्यास】"ट्रैवर्सल" सोच से हल करें III](https://labuladong.online/algo/problem-set/binary-tree-traverse-iii/)
    * [【मजबूत अभ्यास】"समस्या विभाजन" सोच से हल करें I](https://labuladong.online/algo/problem-set/binary-tree-divide-i/)
    * [【मजबूत अभ्यास】"समस्या विभाजन" सोच से हल करें II](https://labuladong.online/algo/problem-set/binary-tree-divide-ii/)
    * [【मजबूत अभ्यास】दोनों सोचों का उपयोग करें](https://labuladong.online/algo/problem-set/binary-tree-combine-two-view/)
    * [【मजबूत अभ्यास】पोस्ट-ऑर्डर पोजीशन का उपयोग करें I](https://labuladong.online/algo/problem-set/binary-tree-post-order-i/)
    * [【मजबूत अभ्यास】पोस्ट-ऑर्डर पोजीशन का उपयोग करें II](https://labuladong.online/algo/problem-set/binary-tree-post-order-ii/)
    * [【मजबूत अभ्यास】पोस्ट-ऑर्डर पोजीशन का उपयोग करें III](https://labuladong.online/algo/problem-set/binary-tree-post-order-iii/)
    * [【मजबूत अभ्यास】लेवल ऑर्डर ट्रैवर्सल का उपयोग करें I](https://labuladong.online/algo/problem-set/binary-tree-level-i/)
    * [【मजबूत अभ्यास】लेवल ऑर्डर ट्रैवर्सल का उपयोग करें II](https://labuladong.online/algo/problem-set/binary-tree-level-ii/)
    * [【मजबूत अभ्यास】बाइनरी सर्च ट्री क्लासिक उदाहरण I](https://labuladong.online/algo/problem-set/bst1/)
    * [【मजबूत अभ्यास】बाइनरी सर्च ट्री क्लासिक उदाहरण II](https://labuladong.online/algo/problem-set/bst2/)

  * [बाइनरी ट्री का विस्तार](https://labuladong.online/algo/menu/more-bt/)
    * [विस्तार: न्यूनतम सामान्य पूर्वज की समस्या फ्रेमवर्क](https://labuladong.online/algo/practice-in-action/lowest-common-ancestor-summary/)
    * [विस्तार: पूर्ण बाइनरी ट्री में नोड्स की संख्या कैसे गिनें](https://labuladong.online/algo/data-structure/count-complete-tree-nodes/)
    * [विस्तार: लेज़ी एक्सपांड मल्टी-वे ट्री](https://labuladong.online/algo/data-structure/flatten-nested-list-iterator/)
    * [विस्तार: मर्ज सॉर्ट विस्तार और एप्लीकेशन](https://labuladong.online/algo/practice-in-action/merge-sort/)
    * [विस्तार: क्विक सॉर्ट विस्तार और एप्लीकेशन](https://labuladong.online/algo/practice-in-action/quick-sort/)
    * [विस्तार: स्टैक से बाइनरी ट्री का रिकर्सिव/इटरेटिव ट्रैवर्सल](https://labuladong.online/algo/data-structure/iterative-traversal-binary-tree/)

  * [डाटा स्ट्रक्चर खुद डिजाइन करें](https://labuladong.online/algo/menu/design/)
    * [क्यू से स्टैक और स्टैक से क्यू बनाएं](https://labuladong.online/algo/data-structure/stack-queue/)
    * [【मजबूत अभ्यास】स्टैक क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/stack/)
    * [【मजबूत अभ्यास】ब्रैकेट समस्याओं का संकलन](https://labuladong.online/algo/problem-set/parentheses/)
    * [【मजबूत अभ्यास】क्यू क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/queue/)
    * [मोनोटोनिक स्टैक एल्गोरिदम टेम्पलेट से तीन प्रश्न हल करें](https://labuladong.online/algo/data-structure/monotonic-stack/)
    * [【मजबूत अभ्यास】मोनोटोनिक स्टैक के विविध रूप और क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/monotonic-stack/)
    * [मोनोटोनिक क्यू से स्लाइडिंग विंडो समस्या हल करें](https://labuladong.online/algo/data-structure/monotonic-queue/)
    * [【मजबूत अभ्यास】मोनोटोनिक क्यू का सामान्य इम्प्लीमेंटेशन और क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/monotonic-queue/)
    * [एल्गोरिदम जैसे लेगो: हाथ से LRU एल्गोरिदम बनाएं](https://labuladong.online/algo/data-structure/lru-cache/)
    * [एल्गोरिदम जैसे लेगो: हाथ से LFU एल्गोरिदम बनाएं](https://labuladong.online/algo/frequency-interview/lfu/)
    * [किसी भी ऐरे तत्व को O(1) समय में हटाएं/खोजें](https://labuladong.online/algo/data-structure/random-set/)
    * [【मजबूत अभ्यास】हैश टेबल के और प्रश्न](https://labuladong.online/algo/problem-set/hash-table/)
    * [【मजबूत अभ्यास】प्रायोरिटी क्यू क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/binary-heap/)
    * [TreeMap/TreeSet कोड इम्प्लीमेंटेशन](https://labuladong.online/algo/data-structure-basic/tree-map-implement/)
    * [सेगमेंट ट्री कोड इम्प्लीमेंटेशन](https://labuladong.online/algo/data-structure/segment-tree-implement/)
    * [Trie/डिक्शनरी ट्री/प्रिफिक्स ट्री कोड इम्प्लीमेंटेशन](https://labuladong.online/algo/data-structure/trie-implement/)
    * [【मजबूत अभ्यास】Trie ट्री एल्गोरिदम प्रश्न](https://labuladong.online/algo/problem-set/trie/)
    * [फ्रेंड सर्कल टाइमलाइन डिज़ाइन करें](https://labuladong.online/algo/data-structure/design-twitter/)
    * [परीक्षा कक्ष सीट एल्गोरिदम डिज़ाइन करें](https://labuladong.online/algo/frequency-interview/exam-room/)
    * [【मजबूत अभ्यास】अधिक क्लासिक डिज़ाइन प्रश्न](https://labuladong.online/algo/problem-set/ds-design/)
    * [विस्तार: कैलकुलेटर कैसे बनाएं](https://labuladong.online/algo/data-structure/implement-calculator/)
    * [विस्तार: दो बाइनरी हीप से मीडियन एल्गोरिदम](https://labuladong.online/algo/practice-in-action/find-median-from-data-stream/)
    * [विस्तार: ऐरे डुप्लीकेट हटाने की समस्या (कठिन)](https://labuladong.online/algo/frequency-interview/remove-duplicate-letters/)

  * [ग्राफ एल्गोरिदम को हाथ पकड़ कर हल करें](https://labuladong.online/algo/menu/graph/)
    * [साइकल डिटेक्शन और टॉपोलॉजिकल सॉर्ट एल्गोरिदम](https://labuladong.online/algo/data-structure/topological-sort/)
    * [प्रसिद्ध व्यक्ति समस्या](https://labuladong.online/algo/frequency-interview/find-celebrity/)
    * [बाइपार्टाइट ग्राफ निर्धारण एल्गोरिदम](https://labuladong.online/algo/data-structure/bipartite-graph/)
    * [Union-Find एल्गोरिदम](https://labuladong.online/algo/data-structure/union-find/)
    * [【मजबूत अभ्यास】Union-Find क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/union-find/)
    * [Kruskal न्यूनतम स्पैनिंग ट्री एल्गोरिदम](https://labuladong.online/algo/data-structure/kruskal/)
    * [Prim न्यूनतम स्पैनिंग ट्री एल्गोरिदम](https://labuladong.online/algo/data-structure/prim/)
    * [Dijkstra एल्गोरिदम टेम्पलेट और एप्लीकेशन](https://labuladong.online/algo/data-structure/dijkstra/)
    * [【मजबूत अभ्यास】Dijkstra एल्गोरिदम क्लासिक प्रश्न](https://labuladong.online/algo/problem-set/dijkstra/)

### [दूसरा अध्याय, क्लासिक ब्रूट फोर्स सर्च एल्गोरिदम](https://labuladong.online/algo/menu/braute-force-search/)
  * [DFS/बैकट्रैक एल्गोरिदम](https://labuladong.online/algo/menu/dfs/)
    * [बैकट्रैक एल्गोरिदम प्रश्न हल करने का फ्रेमवर्क](https://labuladong.online/algo/essential-technique/backtrack-framework/)
    * [बैकट्रैक एल्गोरिदम अभ्यास: सुडोकू और N क्वीन समस्या](https://labuladong.online/algo/practice-in-action/sudoku-nqueue/)
    * [बैकट्रैक एल्गोरिदम से सभी परिमुटेशन/कंबिनेशन/सबसेट प्रश्न हल करें](https://labuladong.online/algo/essential-technique/permutation-combination-subset-all-in-one/)
    * [बॉल-बॉक्स मॉडल: बैकट्रैक एल्गोरिदम के दो दृष्टिकोण](https://labuladong.online/algo/practice-in-action/two-views-of-backtrack/)
    * [बैकट्रैक एल्गोरिदम/DFS के कुछ सवालों के उत्तर](https://labuladong.online/algo/essential-technique/backtrack-vs-dfs/)
    * [एक लेख में सभी आइलैंड समस्याएँ हल करें](https://labuladong.online/algo/frequency-interview/island-dfs-summary/)
    * [बैकट्रैक एल्गोरिदम अभ्यास: ब्रैकेट जेनरेशन](https://labuladong.online/algo/practice-in-action/generate-parentheses/)
    * [बैकट्रैक एल्गोरिदम अभ्यास: सेट विभाजन](https://labuladong.online/algo/practice-in-action/partition-to-k-equal-sum-subsets/)
    * [【मजबूत अभ्यास】बैकट्रैक एल्गोरिदम क्लासिक प्रश्न I](https://labuladong.online/algo/problem-set/backtrack-i/)
    * [【मजबूत अभ्यास】बैकट्रैक एल्गोरिदम क्लासिक प्रश्न II](https://labuladong.online/algo/problem-set/backtrack-ii/)
    * [【मजबूत अभ्यास】बैकट्रैक एल्गोरिदम क्लासिक प्रश्न III](https://labuladong.online/algo/problem-set/backtrack-iii/)

  * [BFS एल्गोरिदम](https://labuladong.online/algo/menu/bfs/)
    * [BFS एल्गोरिदम प्रश्न हल करने का फ्रेमवर्क](https://labuladong.online/algo/essential-technique/bfs-framework/)
    * [【मजबूत अभ्यास】BFS क्लासिक प्रश्न I](https://labuladong.online/algo/problem-set/bfs/)
    * [【मजबूत अभ्यास】BFS क्लासिक प्रश्न II](https://labuladong.online/algo/problem-set/bfs-ii/)
    * [अपडेटिंग चल रही है](https://labuladong.online/algo/intro/updating/)


### [तीसरा अध्याय, क्लासिक डायनामिक प्रोग्रामिंग एल्गोरिदम](https://labuladong.online/algo/menu/dp/)
  * [डायनामिक प्रोग्रामिंग की मूल तकनीकें](https://labuladong.online/algo/menu/dp-basic/)
    * [डायनामिक प्रोग्रामिंग प्रश्न हल करने का फ्रेमवर्क](https://labuladong.online/algo/essential-technique/dynamic-programming-framework/)
    * [डायनामिक प्रोग्रामिंग डिजाइन: सबसे लंबा बढ़ता उपसर्ग](https://labuladong.online/algo/dynamic-programming/longest-increasing-subsequence/)
    * [base case और मेमो के प्रारंभिक मान कैसे निर्धारित करें?](https://labuladong.online/algo/dynamic-programming/memo-fundamental/)
    * [डायनामिक प्रोग्रामिंग के दो दृष्टिकोण](https://labuladong.online/algo/dynamic-programming/two-views-of-dp/)
    * [डायनामिक प्रोग्रामिंग और बैकट्रैक एल्गोरिदम सोच रूपांतरण](https://labuladong.online/algo/dynamic-programming/word-break/)
    * [डायनामिक प्रोग्रामिंग में स्पेस ऑप्टिमाइज़ेशन](https://labuladong.online/algo/dynamic-programming/space-optimization/)
    * [ऑप्टिमल सबस्ट्रक्चर सिद्धांत और dp ऐरे ट्रैवर्सल दिशा](https://labuladong.online/algo/dynamic-programming/faq-summary/)

  * [सबसीक्वेंस प्रकार की समस्याएँ](https://labuladong.online/algo/menu/subsequence/)
    * [क्लासिक डायनामिक प्रोग्रामिंग: एडिट डिस्टेंस](https://labuladong.online/algo/dynamic-programming/edit-distance/)
    * [डायनामिक प्रोग्रामिंग डिजाइन: अधिकतम उपसर्ग](https://labuladong.online/algo/dynamic-programming/maximum-subarray/)
    * [क्लासिक डायनामिक प्रोग्रामिंग: सबसे लंबा सामान्य उपसर्ग](https://labuladong.online/algo/dynamic-programming/longest-common-subsequence/)
    * [डायनामिक प्रोग्रामिंग उपसर्ग समस्याएँ हल करने का टेम्पलेट](https://labuladong.online/algo/dynamic-programming/subsequence-problem/)

  * [नैपसैक प्रकार की समस्याएँ](https://labuladong.online/algo/menu/knapsack/)
    * [क्लासिक डायनामिक प्रोग्रामिंग: 0-1 नैपसैक समस्या](https://labuladong.online/algo/dynamic-programming/knapsack1/)
    * [क्लासिक डायनामिक प्रोग्रामिंग: सबसेट नैपसैक समस्या](https://labuladong.online/algo/dynamic-programming/knapsack2/)
    * [क्लासिक डायनामिक प्रोग्रामिंग: पूर्ण नैपसैक समस्या](https://labuladong.online/algo/dynamic-programming/knapsack3/)
    * [नैपसैक समस्या का वेरिएशन: टारगेट सम](https://labuladong.online/algo/dynamic-programming/target-sum/)

  * [डायनामिक प्रोग्रामिंग से गेम खेलें](https://labuladong.online/algo/menu/dp-game/)
    * [डायनामिक प्रोग्रामिंग: न्यूनतम पथ योग](https://labuladong.online/algo/dynamic-programming/minimum-path-sum/)
    * [डायनामिक प्रोग्रामिंग से "मैजिक टावर" पार किया](https://labuladong.online/algo/dynamic-programming/magic-tower/)
    * [डायनामिक प्रोग्रामिंग से "Fallout 4" पार किया](https://labuladong.online/algo/dynamic-programming/freedom-trail/)
    * [यात्रा में पैसे बचाएं: वेटेड शॉर्टेस्ट पाथ](https://labuladong.online/algo/dynamic-programming/cheap-travel/)
    * [क्लासिक डायनामिक प्रोग्रामिंग: रेगुलर एक्सप्रेशन](https://labuladong.online/algo/dynamic-programming/regular-expression-matching/)
    * [क्लासिक डायनामिक प्रोग्रामिंग: एग ड्रॉप](https://labuladong.online/algo/dynamic-programming/egg-drop/)
    * [क्लासिक डायनामिक प्रोग्रामिंग: गुब्बारा फोड़ना](https://labuladong.online/algo/dynamic-programming/burst-balloons/)
    * [क्लासिक डायनामिक प्रोग्रामिंग: गेम थ्योरी](https://labuladong.online/algo/dynamic-programming/game-theory/)
    * [LeetCode हाउस रॉबर समस्या को एक विधि से हल करें](https://labuladong.online/algo/dynamic-programming/house-robber/)
    * [LeetCode स्टॉक समस्या को एक विधि से हल करें](https://labuladong.online/algo/dynamic-programming/stock-problem-summary/)

  * [ग्रीडी प्रकार की समस्याएँ](https://labuladong.online/algo/menu/greedy/)
    * [ग्रीडी एल्गोरिदम प्रश्न हल करने का फ्रेमवर्क](https://labuladong.online/algo/essential-technique/greedy/)
    * [अनुभवी ड्राइवर फ्यूलिंग एल्गोरिदम](https://labuladong.online/algo/frequency-interview/gas-station-greedy/)
    * [ग्रीडी एल्गोरिदम: इंटरवल शेड्यूलिंग समस्या](https://labuladong.online/algo/frequency-interview/interval-scheduling/)
    * [स्कैन लाइन तकनीक: मीटिंग रूम आवंटन](https://labuladong.online/algo/frequency-interview/scan-line-technique/)
    * [वीडियो काटकर ग्रीडी एल्गोरिदम बनाएं](https://labuladong.online/algo/frequency-interview/cut-video/)


### [चौथा अध्याय, अन्य सामान्य एल्गोरिदम तकनीकें](https://labuladong.online/algo/menu/other/)
  * [गणितीय ऑपरेशन तकनीकें](https://labuladong.online/algo/menu/math/)
    * [एक लाइन कोड से हल होने वाली समस्याएँ](https://labuladong.online/algo/frequency-interview/one-line-solutions/)
    * [सामान्य बिट ऑपरेशन](https://labuladong.online/algo/frequency-interview/bitwise-operation/)
    * [गेम में रैंडम एल्गोरिदम](https://labuladong.online/algo/frequency-interview/random-algorithm/)
    * [दो लोकप्रिय फैक्टोरियल समस्याएँ](https://labuladong.online/algo/frequency-interview/factorial-problems/)
    * [प्राइम नंबर कैसे जल्दी खोजें](https://labuladong.online/algo/frequency-interview/print-prime-number/)
    * [मॉड्यूलर एक्सपोनेंशिएशन कैसे जल्दी करें](https://labuladong.online/algo/frequency-interview/quick-power/)
    * [कैसे गायब और डुप्लीकेट तत्व एक साथ खोजें](https://labuladong.online/algo/frequency-interview/mismatch-set/)
    * [कुछ काउंटर-इंट्यूटिव प्रायबिलिटी समस्याएँ](https://labuladong.online/algo/frequency-interview/probability-problem/)
    * [【मजबूत अभ्यास】गणितीय तकनीकें प्रश्न](https://labuladong.online/algo/problem-set/math-tricks/)

  * [क्लासिक इंटरव्यू प्रश्न](https://labuladong.online/algo/menu/interview/)
    * [एल्गोरिदम लिखित परीक्षा "स्कोरिंग" तकनीकें](https://labuladong.online/algo/other-skills/tips-in-exam/)
    * [कैसे जल्दी से ट्रैपिंग रेन वॉटर समस्या हल करें](https://labuladong.online/algo/frequency-interview/trapping-rain-water/)
    * [एक लेख में सभी अग्ली नंबर समस्याएँ हल करें](https://labuladong.online/algo/frequency-interview/ugly-number-summary/)
    * [एक विधि से तीन इंटरवल समस्याएँ हल करें](https://labuladong.online/algo/practice-in-action/interval-problem-summary/)
    * [कौन सोच सकता है, डौडीझू भी एल्गोरिदम बन सकता है](https://labuladong.online/algo/practice-in-action/split-array-into-consecutive-subsequences/)
    * [पैनकेक सॉर्टिंग एल्गोरिदम](https://labuladong.online/algo/frequency-interview/pancake-sorting/)
    * [स्ट्रिंग मल्टीप्लिकेशन कैलकुलेशन](https://labuladong.online/algo/practice-in-action/multiply-strings/)
    * [कैसे तय करें कि परफेक्ट रेक्टेंगल है या नहीं](https://labuladong.online/algo/frequency-interview/perfect-rectangle/)

### [परिशिष्ट](https://labuladong.online/algo/menu/appendix/)
  * [labuladong.online अपडेट लॉग](https://labuladong.online/algo/changelog/website/)
  * [विज़ुअलाइजेशन पैनल अपडेट लॉग](https://labuladong.online/algo/changelog/visualize/)
  * [Chrome प्रश्न हल प्लगइन अपडेट लॉग](https://labuladong.online/algo/changelog/chrome/)
  * [vscode प्रश्न हल प्लगइन अपडेट लॉग](https://labuladong.online/algo/changelog/vscode/)
  * [Jetbrain प्रश्न हल प्लगइन अपडेट लॉग](https://labuladong.online/algo/changelog/jetbrain/)
  * [वेबसाइट/प्लगइन समस्या फीडबैक](https://labuladong.online/algo/intro/bug-report/)

<!-- table end -->

# अनुवाद में योगदान देने वाले महानुभावों का धन्यवाद

निकनेम के अक्षर क्रम में सूचीबद्ध:

[ABCpril](https://github.com/ABCpril), 
[andavid](https://github.com/andavid), 
[bryceustc](https://github.com/bryceustc), 
[build2645](https://github.com/build2645), 
[CarrieOn](https://github.com/CarrieOn), 
[cooker](https://github.com/xiaochuhub), 
[Dong Wang](https://github.com/Coder2Programmer), 
[ExcaliburEX](https://github.com/ExcaliburEX), 
[floatLig](https://github.com/floatLig), 
[ForeverSolar](https://github.com/foreversolar), 
[Fulin Li](https://fulinli.github.io/), 
[Funnyyanne](https://github.com/Funnyyanne), 
[GYHHAHA](https://github.com/GYHHAHA), 
[Hi_archer](https://hiarcher.top/), 
[Iruze](https://github.com/Iruze), 
[Jieyixia](https://github.com/Jieyixia), 
[Justin](https://github.com/Justin-YGG), 
[Kevin](https://github.com/Kevin-free), 
[Lrc123](https://github.com/Lrc123), 
[lriy](https://github.com/lriy), 
[Lyjeeq](https://github.com/Lyjeeq), 
[MasonShu](https://greenwichmt.github.io/), 
[Master-cai](https://github.com/Master-cai), 
[miaoxiaozui2017](https://github.com/miaoxiaozui2017), 
[natsunoyoru97](https://github.com/natsunoyoru97), 
[nettee](https://github.com/nettee), 
[PaperJets](https://github.com/PaperJets), 
[qy-yang](https://github.com/qy-yang), 
[realism0331](https://github.com/realism0331), 
[SCUhzs](https://github.com/brucecat), 
[Seaworth](https://github.com/Seaworth), 
[shazi4399](https://github.com/shazi4399), 
[ShuozheLi](https://github.com/ShuoZheLi/), 
[sinjoywong](https://blog.csdn.net/SinjoyWong), 
[sunqiuming526](https://github.com/sunqiuming526), 
[Tianhao Zhou](https://github.com/tianhaoz95), 
[timmmGZ](https://github.com/timmmGZ), 
[tommytim0515](https://github.com/tommytim0515), 
[ucsk](https://github.com/ucsk), 
[wadegrc](https://github.com/wadegrc), 
[walsvid](https://github.com/walsvid), 
[warmingkkk](https://github.com/warmingkkk), 
[Wonderxie](https://github.com/Wonderxie), 
[wsyzxxxx](https://github.com/wsyzxxxx), 
[xiaodp](https://github.com/xiaodp), 
[youyun](https://github.com/youyun), 
[yx-tan](https://github.com/yx-tan), 
[Zero](https://github.com/Mr2er0), 
[Ziming](https://github.com/ML-ZimingMeng/LeetCode-Python3)

# दान करें

यदि यह रिपॉजिटरी आपके लिए उपयोगी है, तो लेखक को एक कप इंस्टेंट कॉफी पिला सकते हैं

<img src="pictures/pay.jpg" width = "200" align=center />

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---