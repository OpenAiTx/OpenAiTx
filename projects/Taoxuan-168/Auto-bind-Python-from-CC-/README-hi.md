<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

CC++ से Python को ऑटो बाइंड करें
===================

> एक पर्याप्त सरल, उपयोग में आसान और कॉन्फ़िगर करने योग्य परियोजना जो C/C++ कोड को स्वचालित रूप से Python कोड में बाइंड करती है और whl पैकेज उत्पन्न करती है

> यह परियोजना यहां से क्लोन की गई है:
https://github.com/Neutree/c_cpp_project_framework
और कोड कम्पाइल करने वाला भाग मूल रिपॉजिटरी के अनुरूप रखा गया है


> pybind11 की स्वतः बाइंडिंग के लिए संदर्भ कोड:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## शीघ्र प्रारंभ

* 1. इस रिपॉजिटरी को क्लोन करें, और /examples/demo डायरेक्ट्री में जाएं
python project.py menuconfig का उपयोग करके ग्राफिकल इंटरफेस में संकलन टूलचेन और whl फाइल पैकेजिंग को कॉन्फ़िगर करें
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> इसमें x86 आपके स्थानीय कंपाइल के लिए, arm64 MaixCam2 के लिए, और RISCV64 MaiCam/Pro के लिए है
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. एक C/C++ फ़ंक्शन और hpp हेडर फ़ाइल लिखें, जिसे whl पैकेज के नाम के अनुसार नामित करें, ताकि स्वतः पहचान संभव हो सके:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
संबंधित फ़ंक्शन के लिए @modul टिप्पणी लिखें, उसके बाद फ़ंक्शन पथ जोड़ें:
```C++
namespace add::test
{
    /**
     * My function, add two integer.
     * @param a arg a, int type
     * @param b arg b, int type
     * @return int type, will a + b
     * @module add.test.add
     */
    int add(int a, int b);
}
```
जिसमें पहली पंक्ति फंक्शन का परिचय है, @param पैरामीटर का परिचय है, @return रिटर्न वैल्यू का परिचय है (खाली हो सकता है)
यदि केवल संकलित कर whl फ़ाइल के रूप में पैक करना है तो main.cpp को संशोधित करने की आवश्यकता नहीं है
python project build का उपयोग करके संकलन और whl पैकिंग शुरू की जा सकती है
संकलन के बाद whl इंस्टॉल कर सीधे-सीधे कॉल किया जा सकता है:
```Python
import add
add.test.add(1,1)
```
ध्यान दें:
-   एक हेडर फ़ाइल एक मॉड्यूल नाम का प्रतिनिधित्व करती है, जिसका अर्थ है कि आयात किए जाने वाले मॉड्यूल, उदाहरण के लिए add.hpp का अर्थ है import add, इसका मॉड्यूल नाम add से शुरू होना चाहिए
-   cpp_bind_python.py को सीधे चलाने से केवल बाइंड किए गए cpp फ़ाइलें जेनरेट की जा सकती हैं, --doc DOC पैरामीटर जोड़ने से टिप्पणियों से स्वचालित रूप से दस्तावेज़ जेनरेट हो सकते हैं

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---