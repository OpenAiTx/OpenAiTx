
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

Automatyczne wiązanie Pythona z C/C++
===================

> Wystarczająco prosty, łatwy w użyciu i konfigurowalny projekt do automatycznego wiązania kodu C/C++ z Pythonem i generowania paczki whl

> Projekt został sklonowany z:
https://github.com/Neutree/c_cpp_project_framework
oraz część kompilacyjna kodu jest zgodna z oryginalnym repozytorium

> Przykładowy kod automatycznego wiązania pybind11:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## Szybki start

* 1. Sklonuj to repozytorium, przejdź do katalogu /examples/demo
Użyj python project.py menuconfig, aby wejść do graficznego interfejsu konfiguracji narzędzi kompilacyjnych oraz pakowania pliku whl
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> x86 odpowiada kompilacji lokalnej, arm64 kompilacji dla MaixCam2, RISCV64 kompilacji dla MaiCam/Pro
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. Napisz funkcję C/C++ oraz plik nagłówkowy hpp, nazwa pliku powinna odpowiadać nazwie pliku whl, co ułatwia automatyczną identyfikację:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
Dla odpowiedniej funkcji napisz adnotację @modul, a następnie podaj ścieżkę funkcji:
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
Pierwsza linia to opis funkcji, @param to opis parametrów, @return to opis wartości zwracanej (może być pusta)
Jeśli potrzebujesz tylko skompilować i spakować do pliku whl, nie musisz modyfikować main.cpp
Wystarczy użyć python project build, aby rozpocząć kompilację i pakowanie pliku whl
Po zainstalowaniu skompilowanego pliku whl można go od razu wywołać:
```Python
import add
add.test.add(1,1)
```
Uwaga:
-   Jeden plik nagłówkowy odpowiada jednej nazwie modułu, oznacza to moduł do zaimportowania, na przykład add.hpp odpowiada import add, a jego nazwa modułu musi zaczynać się od add
-   Bezpośrednie uruchomienie cpp_bind_python.py generuje tylko powiązany plik cpp, dodanie parametru --doc DOC pozwala automatycznie generować dokumentację z komentarzy

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---