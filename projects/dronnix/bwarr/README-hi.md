<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=dronnix&project=bwarr&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

## यह क्या है?

[![CI](https://github.com/dronnix/bwarr/actions/workflows/ci.yml/badge.svg)](https://github.com/dronnix/bwarr/actions)
[![codecov](https://codecov.io/gh/dronnix/bwarr/branch/main/graph/badge.svg)](https://codecov.io/gh/dronnix/bwarr)
[![Go Reference](https://pkg.go.dev/badge/github.com/dronnix/bwarr.svg)](https://pkg.go.dev/github.com/dronnix/bwarr)
[![Go Report Card](https://goreportcard.com/badge/github.com/dronnix/bwarr)](https://goreportcard.com/report/github.com/dronnix/bwarr)

ब्लैक-व्हाइट एरे (जिसे BWArr भी कहा जाता है) एक तेज, क्रमबद्ध डेटा संरचना है जो ऐरे पर आधारित है और इसमें ***$O(\log N)$*** **मेमोरी आवंटन** होते हैं.

## डेटा संरचना
ब्लैक-व्हाइट एरे की अवधारणा का आविष्कार और प्रकाशन प्रोफेसर [Z. जॉर्ज मौ](https://www.cs.brandeis.edu/~mou/) ने [Black-White Array: A New Data Structure for Dynamic Data Sets](https://arxiv.org/abs/2004.09051) में किया था। यह रिपॉजिटरी इसकी पहली सार्वजनिक इम्प्लीमेंटेशन को प्रस्तुत करती है।

![प्रोफेसर Z. जॉर्ज मौ](https://www.cs.brandeis.edu/~mou/mou.gif)

### मुख्य विशेषताएँ:
- इंसर्ट्स के लिए $O(\log N)$ मेमोरी अलोकेशन - GC पर कोई दबाव नहीं;
- तेज इंसर्ट, डिलीट, और सर्च ऑपरेशन, $O(\log N)$ समय की अमोर्टाइज्ड जटिलता;
- एरे-आधारित और बिना पॉइंटर के, जिससे यह CPU-फ्रेंडली है: कैश लोकलिटी / अनुक्रमिक पुनरावृत्ति / आदि;
- डुप्लिकेट तत्वों का मूल रूप से समर्थन करता है (मल्टीसेट व्यवहार) - मूल्यों को यूनिक बनाने के लिए स्ट्रक्ट में रैप करने की आवश्यकता नहीं;
- `github.com/google/btree` और `github.com/petar/GoLLRB` के लिए ड्रॉप-इन रिप्लेसमेंट;
- कम मेमोरी ओवरहेड - प्रति तत्व कोई पॉइंटर नहीं, संक्षिप्त मेमोरी प्रतिनिधित्व;
- आसानी से सीरियलाइज़ेबल;

### समझौते
- हर $N$ इंसर्ट ऑपरेशन पर जटिलता $O(N)$ हो सकती है, हालांकि अमोर्टाइज्ड $O(\log N)$ रहती है। रीयल-टाइम सिस्टम्स के लिए, यह लाखों तत्वों वाली कलेक्शनों में लेटेंसी स्पाइक उत्पन्न कर सकता है। इसे असिंक्रोनस/बैकग्राउंड इंसर्ट्स द्वारा कम किया जा सकता है।
- कम तत्वों की स्थिति में `Search()/Delete()` ऑपरेशन $O((\log N)^2)$ ले सकते हैं। 50% तत्व $O(\log N)$ में, 75%  - $O(2\log N)$, 87.5% - $O(3\log N)$, आदि में;
- जब लंबे सिलसिलेवार तत्वों को हटाया जाता है, तो `Max()/Min()` ऑपरेशन $O(N/4)$ ले सकता है। कॉलों की श्रृंखला के लिए अमोर्टाइज्ड जटिलता $O(\log N)$ रहती है।
- जब लंबे सिलसिलेवार तत्वों को हटाया जाता है, तो इटरेशन स्टेप $O(N/4)$ हो सकता है। पूरी कलेक्शन में प्रति तत्व इटरेशन के लिए अमोर्टाइज्ड जटिलता $O(\log N)$ है।

### उपयोग का मामला
इन-मेमोरी कलेक्शन जिनमें रीड-राइट अनुपात 1:1 < r:w < 10:1 हो। BWArr भारी इंसर्ट और डिलीट के लिए अनुकूलित है (कम अलोकेशन और फ्रैग्मेंटेशन के साथ), साथ ही तेज सर्च और इटरेशन भी उपलब्ध कराता है।

###  बेंचमार्क्स

[Google BTree](https://github.com/google/btree) के साथ तुलना में बेंचमार्क्स।

#### इंसर्ट 
N यूनिक रैंडम int64 मानों को एक खाली डेटा संरचना में इंसर्ट करने के लिए समय, अलोकेशन और अलोकेटेड KB मापता है। दोनों BWArr और BTree खाली शुरू होते हैं और सभी मान एक-एक करके इंसर्ट करते हैं।

![इंसर्ट प्रदर्शन](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values.png?raw=true)
![इंसर्ट अलोकेशन्स](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_allocs.png?raw=true)
![इंसर्ट अलोक_बाइट्स](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_unique_values_bytes.png?raw=true)

कम मानों पर अलोकेशन: 

![इंसर्ट अलोकेशन्स स्मॉल](https://github.com/dronnix/bwarr-bench/blob/main/images/insert_performance_allocs_detailed.png?raw=true)




#### प्राप्त करें
पूर्व-जनित डेटा संरचना में N मानों को उनकी कुंजी द्वारा खोजने में लगने वाले समय को मापता है। डेटा संरचना को सभी मानों के साथ समय मापने से पहले भरा जाता है, फिर प्रत्येक मान को कुंजी द्वारा प्राप्त किया जाता है।

![प्राप्ति प्रदर्शन](https://github.com/dronnix/bwarr-bench/blob/main/images/get_all_values_by_key.png?raw=true)

#### इटरेट करें
सभी N मानों के माध्यम से क्रमित और गैर-क्रमित क्रम में इटरेट करने में लगने वाले समय को मापता है।
![क्रमबद्ध इटरेशन प्रदर्शन](https://github.com/dronnix/bwarr-bench/blob/main/images/ordered_iteration_over_all_values.png?raw=true)
![अक्रमबद्ध इटरेशन प्रदर्शन](https://github.com/dronnix/bwarr-bench/blob/main/images/unordered_iteration_over_all_values.png?raw=true)

#### अन्य बेंचमार्क्स
अतिरिक्त बेंचमार्क्स और विवरण [bwarr-bench](https://github.com/dronnix/bwarr-bench) रिपॉजिटरी में उपलब्ध हैं।
अधिक विधियाँ जोड़ी जाएँगी, साथ ही AMD64 और ARM64 आर्किटेक्चर के लिए अलग-अलग बेंचमार्क्स की भी अपेक्षा करें।

## स्थापना

Go 1.22 या उच्चतर की आवश्यकता है।

```bash
go get github.com/dronnix/bwarr
```
फिर अपने कोड में आयात करें:


```go
import "github.com/dronnix/bwarr"
```

## उपयोग

### मूल उदाहरण

```go
package main

import (
    "cmp"
    "fmt"

    "github.com/dronnix/bwarr"
)

func main() {
    // Create a BWArr with an integer comparison function
    // The second parameter (10) is the initial capacity hint
    bwa := bwarr.New(func(a, b int64) int {
        return cmp.Compare(a, b)
    }, 10)

    // Insert elements
    bwa.Insert(42)
    bwa.Insert(17)
    bwa.Insert(99)
    bwa.Insert(23)
    bwa.Insert(8)

    fmt.Printf("Length: %d\n", bwa.Len()) // Output: Length: 5

    // Get an element
    val, found := bwa.Get(42)
    if found {
        fmt.Printf("Found: %d\n", val) // Output: Found: 42
    }

    // Delete an element
    deleted, found := bwa.Delete(17)
    if found {
        fmt.Printf("Deleted: %d\n", deleted) // Output: Deleted: 17
    }

    // Iterate in ascending order
    fmt.Println("Elements in sorted order:")
    bwa.Ascend(func(item int64) bool {
        fmt.Printf("  %d\n", item)
        return true // return false to stop iteration early
    })
    // Output:
    //   8
    //   23
    //   42
    //   99
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---