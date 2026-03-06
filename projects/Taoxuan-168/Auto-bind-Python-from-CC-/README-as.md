
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=en">ইংৰাজী</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-CN">সৰল চৈনিক</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-TW">পৰম্পৰাগত চৈনিক</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ja">জাপানী</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ko">কোৰিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fr">ফ্ৰেঞ্চ</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=de">জাৰ্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=es">স্পেনী</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=it">ইটালীয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pl">পোলিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fa">ফাৰ্সী</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=tr">তুৰ্কী</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=vi">ভিয়েটনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=id">ইন্দোনেশিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

CC++ৰ পৰা Pythonত Auto Bind
===================

> এটা যথেষ্ট সহজ আৰু ব্যৱহাৰযোগ্য আৰু কনফিগাৰ কৰিব পৰা প্রকল্প যি C/C++ কোডৰ পৰা স্বয়ংক্ৰিয়ভাৱে Python কোডত bind কৰে আৰু whl পেকেজ সৃষ্টি কৰে

> এই প্রকল্পটো ক্লোন কৰা হৈছে:
https://github.com/Neutree/c_cpp_project_framework
আৰু কোড কম্পাইলৰ অংশ মূল ৰিপ'ৰ সৈতে একে ৰখা হৈছে

> pybind11ৰ স্বয়ংক্ৰিয় বন্ধন অংশৰ参考 কোড:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## দ্ৰুত আৰম্ভনি

* 1.এই সংৰক্ষণাগাৰটো ক্লোন কৰক, /examples/demo ডাইৰেক্টৰিত প্ৰবেশ কৰক
python project.py menuconfig ব্যৱহাৰ কৰি গ্ৰাফিকেল ইণ্টাৰফেচত কম্পাইল টুলচেইন আৰু হ'ল ফাইল পেকেজ কৰাৰ বাবে কনফিগাৰ কৰক
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> ইয়াত x86 মানে হৈছে স্থানীয় কম্পাইল, arm64 মানে হৈছে MaixCam2 ত কম্পাইল, RISCV64 মানে হৈছে MaiCam/Pro ত কম্পাইল
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2.এটা C/C++ ফাংশন আৰু hpp হেডাৰ ফাইল লিখক, হ'ল পেকেজৰ ফাইলনাম অনুসৰি, যাতে স্বয়ংক্ৰিয় চিনাক্তকৰণ সহজ হয়:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
প্ৰাসংগিক ফাংচনসমূহৰ বাবে @modul মন্তব্য লিখক, পাছত ফাংচন পথ সংযোগ কৰক:
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
প্ৰথম শাৰীত ফাংচনৰ পৰিচয়, @param মানে পাৰামিটাৰৰ পৰিচয়, @return মানে ৰিটার্ন ভেল্যুৰ পৰিচয় (খালী থাকিব পাৰে)
যদি কেৱল কম্পাইল কৰি whl ফাইল হিচাপে পেকেজ কৰিব লাগে তেন্তে main.cpp সম্পাদনা কৰাৰ প্ৰয়োজন নাই
python project build ব্যৱহাৰ কৰি সহজে কম্পাইল আৰু whl ফাইল পেকেজ কৰিব পাৰি
কম্পাইল কৰি whl ইনষ্টল কৰাৰ পাছত সোধাই সোধাই কল কৰিব পাৰি:
```Python
import add
add.test.add(1,1)
```
সাৱধান:
-   এটা হেডাৰ ফাইল এটা মডিউল নামক প্ৰতিনিধিত্ব কৰে, অৰ্থাৎ ইম্পৰ্ট কৰিবলগীয়া মডিউল, যেনে add.hpp মিলায় import add, ইয়াৰ মডিউল নাম add দ্বাৰা আৰম্ভ হ'ব লাগিব
-   cpp_bind_python.py পোনপটীয়াকৈ চলালে কেৱল সংলগ্ন cpp ফাইলটো উৎপন্ন কৰিব পাৰে, --doc DOC পেৰামিটাৰ যোগ কৰিলে টিপ্পণীৰ পৰা স্বয়ংক্ৰিয়ভাৱে ডকুমেন্টেশ্যন সৃষ্টি কৰিব পাৰে

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---