<div align="right">
  <details>
    <summary >🌐 언어</summary>
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

Auto bind Python from CC++
===================

> C/C++ 코드에서 Python 코드로 자동 바인딩하고 whl 패키지를 생성하기 위한 충분히 간단하고 사용하기 쉬우며 구성 가능한 프로젝트

> 본 프로젝트는 다음에서 포크되었습니다:
https://github.com/Neutree/c_cpp_project_framework
그리고 컴파일 코드 부분은 원래 저장소와 동일하게 유지됩니다.


> pybind11 자동 바인딩 참고 코드:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## 빠른 시작

* 1. 이 저장소를 클론하고, /examples/demo 디렉토리로 이동합니다.
python project.py menuconfig를 사용하여 그래픽 인터페이스에서 빌드 툴체인과 whl 파일 패키징 여부를 설정합니다.
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> x86은 로컬 컴파일, arm64는 MaixCam2 컴파일, RISCV64는 MaiCam/Pro 컴파일에 해당합니다.
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. C/C++ 함수를 작성하고 hpp 헤더 파일을 만듭니다. whl 패키지 파일명을 사용하여 자동 인식이 용이하게 해야 합니다.
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
해당 함수에 @modul 주석을 작성하고, 뒤에 함수 경로를 덧붙이세요:
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
其中第一行为函数介绍,@param为参数介绍,@return为返回值介绍(可空)
만약 whl 파일로 컴파일 및 패키징만 필요하다면 main.cpp를 수정할 필요가 없습니다
python project build를 사용하면 컴파일 및 whl 파일 패키징을 시작할 수 있습니다
컴파일 후 whl을 설치하면 바로 호출할 수 있습니다:
```Python
import add
add.test.add(1,1)
```
주의:
-   하나의 헤더 파일은 하나의 모듈명을 나타내며, import할 모듈을 의미합니다. 예를 들어 add.hpp는 import add에 해당하며, 모듈명은 반드시 add로 시작해야 합니다.
-   cpp_bind_python.py를 직접 실행하면 바인딩된 cpp 파일만 생성할 수 있으며, --doc DOC 파라미터를 추가하면 주석에서 자동으로 문서를 생성합니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---